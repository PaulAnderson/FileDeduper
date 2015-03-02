' Paul's Duplicate file finder - finds duplicate files based on file size.
' Copyright (C) 2013 Paul Anderson
' 
'  This program is free software; you can redistribute it and/or
'  modify it under the terms of the GNU General Public License
'  as published by the Free Software Foundation; either version 2
'  of the License, or (at your option) any later version.
'  
'  This program is distributed in the hope that it will be useful,
'  but WITHOUT ANY WARRANTY; without even the implied warranty of
'  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'  GNU General Public License for more details.
'  
'  You should have received a copy of the GNU General Public License
'  along with this program; if not, write to the Free Software
'  Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.


Public Class frmDeduplicate

    Private FileLengths As New Dictionary(Of String, List(Of String))
    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        PopulateDrivesCombo()
    End Sub
    Private Sub PopulateDrivesCombo()
        For Each drive As String In IO.Directory.GetLogicalDrives()
            DrivesComboBox.Items.Add(drive)
        Next
        If DrivesComboBox.Items.Count > 0 Then DrivesComboBox.SelectedIndex = 0
    End Sub

    Private Sub FindDuplicatesButton_Click(sender As System.Object, e As System.EventArgs) Handles FindDuplicatesButton.Click
        FileLengths = New Dictionary(Of String, List(Of String))
        'clear treeview
        If tvResults.Nodes.Count > 0 Then
            For i = tvResults.Nodes.Count - 1 To 0 Step -1
                tvResults.Nodes.RemoveAt(i)
            Next
        End If

        Dim path As String
        If DrivesComboBox.SelectedItem IsNot Nothing Then
            path = DrivesComboBox.SelectedItem.ToString
        ElseIf Not String.IsNullOrEmpty(DrivesComboBox.Text) Then
            path = DrivesComboBox.Text
        Else
            MessageBox.Show("Enter a start path.")
            Exit Sub
        End If
        FindDuplicates(path)
    End Sub
    Private Sub FindDuplicates(Path As String)
        FindDuplicates(New IO.DirectoryInfo(Path))

        CurrentPathLabel.Text = "Populating Results..."
        Application.DoEvents()

        tvResults.Visible = False

        'Remove file sizes with only 1 file
        Dim FileLengths2 As New Dictionary(Of String, List(Of String))
        For i = 0 To FileLengths.Keys.Count - 1
            If FileLengths(FileLengths.Keys(i)).Count > 1 Then FileLengths2.Add(FileLengths.Keys(i), FileLengths(FileLengths.Keys(i)))
        Next
        FileLengths = FileLengths2

        'Sort lengths
        Dim lengthList As New List(Of Long)(FileLengths.Keys.Count)
        For i = 0 To FileLengths.Keys.Count - 1
            lengthList.Add(FileLengths.Keys(i))
        Next
        lengthList.Sort()

        'Add lengths and filenames to treeview
        Dim newNodeName As String
        Dim endLoopCount As Integer = 0
        If cbLimit.Checked Then endLoopCount = lengthList.Count - 101
        For i As Integer = lengthList.Count - 1 To endLoopCount Step -1
            newNodeName = lengthList(i).ToString
            Dim newNode As TreeNode = tvResults.Nodes.Add(newNodeName, newNodeName)
            newNode.Tag = Constants.NodeType.FileSize
        Next

        For Each node As TreeNode In tvResults.Nodes
            For Each filename As String In FileLengths(node.Name)
                node.Nodes.Add(filename).Tag = Constants.NodeType.File
            Next
            node.Text = getHumanReadableFileSize(node.Text, node.Nodes.Count)
            'If Integer.Parse(node.Text) > 10485760 Then node.Expand() 'expand if >10 mb
        Next

        tvResults.Visible = True

        CurrentPathLabel.Text = "Search Complete."
    End Sub
    Dim units() As String = New String() {"Bytes", "KB", "MB", "GB", "TB"}
    Private Function getHumanReadableFileSize(fileSize As Long, filesCount As Integer) As String

        Const maxNumber As Integer = 1024
        Dim unitNo As Integer = 0

        While fileSize > maxNumber And unitNo < units.Count - 1
            fileSize = fileSize / maxNumber
            unitNo += 1
        End While

        Dim sb As New System.Text.StringBuilder
        sb.Append(fileSize)
        sb.Append(" ")
        sb.Append(units(unitNo))
        sb.Append(" - ")
        sb.Append(filesCount)
        sb.Append(" files")

        Return sb.ToString()

    End Function
    Dim rand As New Random
    Private Sub FindDuplicates(dirInfo As IO.DirectoryInfo)
        CurrentPathLabel.Text = dirInfo.FullName

        'Get file sizes for current directory files
        Dim fileInfo As IO.FileInfo()
        Try
            fileInfo = dirInfo.GetFiles()
        Catch ex As UnauthorizedAccessException
            Exit Sub
        End Try
        For Each file As IO.FileInfo In fileInfo
            Dim fileName As String
            Try
                fileName = file.FullName

            Catch ex As System.IO.PathTooLongException
 
                Dim FullPathField As System.Reflection.FieldInfo = GetType(System.IO.DirectoryInfo).GetField("FullPath", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic)
                Dim directoryName As String = ""
                directoryName = FullPathField.GetValue(dirInfo)

                fileName = directoryName + "\" + file.Name
            End Try

            If file IsNot Nothing AndAlso file.Length >= Constants.MinimumFileSize Then
                If FileLengths.ContainsKey(file.Length) Then
                    'duplicate
                    FileLengths(file.Length).Add(fileName)
                Else
                    'new file size
                    FileLengths.Add(file.Length, New List(Of String) From {fileName})
                End If
            End If
        Next

        'Get subDirectories and recursively find duplicates
        Dim dirsInfo As IO.DirectoryInfo()
        dirsInfo = dirInfo.GetDirectories
        If rand.Next(10) = 1 Then Application.DoEvents()
        For Each subDirInfo In dirsInfo
            FindDuplicates(subDirInfo)
        Next

    End Sub

    Private Sub tvResults_NodeMouseClick(sender As System.Object, e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles tvResults.NodeMouseClick
        OpenNode(e.Node, e.X, e.Y)
    End Sub

    Private Sub OpenFolderButton_Click(sender As System.Object, e As System.EventArgs) Handles OpenFolderButton.Click
        OpenNode(tvResults.SelectedNode)
    End Sub
    Private Sub OpenNode(node As TreeNode, Optional x As Integer = 0, Optional y As Integer = 0)
        If node IsNot Nothing AndAlso node.Tag IsNot Nothing Then
            Select Case node.Tag
                Case Constants.NodeType.File
                    Process.Start("explorer.exe", "/select,""" + node.Text + """")
                Case Constants.NodeType.FileSize
                    If x > 20 Then
                        'Open/Close node if clicked on node text. ignore leftmost area because the control will automatically expand if clicked there
                        If node.IsExpanded Then
                            node.Collapse()
                        Else
                            node.Expand()
                        End If
                    End If
            End Select

        End If
    End Sub

    Private Sub btnExpandAll_Click(sender As System.Object, e As System.EventArgs) Handles btnExpandAll.Click
        tvResults.Visible = False
        Static expanded As Boolean = False
        Select Case expanded
            Case False
                tvResults.ExpandAll()
                btnExpandAll.Text = "Collapse All"
            Case True
                tvResults.CollapseAll()
                btnExpandAll.Text = "Expand All"
        End Select
        expanded = Not expanded
        tvResults.Visible = True
    End Sub
End Class
