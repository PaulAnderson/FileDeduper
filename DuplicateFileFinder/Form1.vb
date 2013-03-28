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


Public Class Form1
    Private StartPath As String
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
        If TreeView1.Nodes.Count > 0 Then
            For i = TreeView1.Nodes.Count - 1 To 0 Step -1
                TreeView1.Nodes.RemoveAt(i)
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

        'Remove file sizes with only 1 file
        Dim FileLengths2 As New Dictionary(Of String, List(Of String))
        For i = 0 To FileLengths.Keys.Count - 1
            If FileLengths(FileLengths.Keys(i)).Count > 1 Then FileLengths2.Add(FileLengths.Keys(i), FileLengths(FileLengths.Keys(i)))
        Next
        FileLengths = FileLengths2

        'Sort lengths
        Dim lengthList As New List(Of Integer)(FileLengths.Keys.Count)
        For i = 0 To FileLengths.Keys.Count - 1
            lengthList.Add(FileLengths.Keys(i))
        Next
        lengthList.Sort()

        'Add lengths and filenames to treeview
        For i As Integer = lengthList.Count - 1 To 0 Step -1
            Dim newNode As TreeNode = TreeView1.Nodes.Add(lengthList(i).ToString, lengthList(i).ToString)
        Next
        For Each node As TreeNode In TreeView1.Nodes
            For Each filename As String In FileLengths(node.Text)
                node.Nodes.Add(filename)
            Next
            If Integer.Parse(node.Text) > 10485760 Then node.Expand() 'expand if >10 mb
        Next
    End Sub

    Private Sub FindDuplicates(dirInfo As IO.DirectoryInfo)
        CurrentPathLabel.Text = dirInfo.FullName

        'Get file sizes for current directory files
        Dim fileInfo As IO.FileInfo()
        Try
            fileInfo = dirInfo.GetFiles
        Catch ex As UnauthorizedAccessException
            Exit Sub
        End Try
        For Each file As IO.FileInfo In fileInfo
            If FileLengths.ContainsKey(file.Length) Then
                'duplicate
                FileLengths(file.Length).Add(file.FullName)
            Else
                'new file size
                FileLengths.Add(file.Length, New List(Of String) From {file.FullName})
            End If
        Next

        'Get subDirectories and recursively find duplicates
        Dim dirsInfo As IO.DirectoryInfo()
        dirsInfo = dirInfo.GetDirectories
        Application.DoEvents()
        For Each subDirInfo In dirsInfo
            FindDuplicates(subDirInfo)
        Next

    End Sub
End Class
