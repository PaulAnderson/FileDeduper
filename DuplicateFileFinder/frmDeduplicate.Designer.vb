<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeduplicate
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DrivesComboBox = New System.Windows.Forms.ComboBox()
        Me.FindDuplicatesButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CurrentPathLabel = New System.Windows.Forms.Label()
        Me.OpenFolderButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.tvResults = New System.Windows.Forms.TreeView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Start Path"
        '
        'DrivesComboBox
        '
        Me.DrivesComboBox.FormattingEnabled = True
        Me.DrivesComboBox.Location = New System.Drawing.Point(65, 3)
        Me.DrivesComboBox.Name = "DrivesComboBox"
        Me.DrivesComboBox.Size = New System.Drawing.Size(94, 21)
        Me.DrivesComboBox.TabIndex = 1
        '
        'FindDuplicatesButton
        '
        Me.FindDuplicatesButton.Location = New System.Drawing.Point(165, 3)
        Me.FindDuplicatesButton.Name = "FindDuplicatesButton"
        Me.FindDuplicatesButton.Size = New System.Drawing.Size(94, 23)
        Me.FindDuplicatesButton.TabIndex = 2
        Me.FindDuplicatesButton.Text = "Find Duplicates"
        Me.FindDuplicatesButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DrivesComboBox)
        Me.Panel1.Controls.Add(Me.FindDuplicatesButton)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(912, 29)
        Me.Panel1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CurrentPathLabel)
        Me.Panel2.Controls.Add(Me.OpenFolderButton)
        Me.Panel2.Controls.Add(Me.CloseButton)
        Me.Panel2.Controls.Add(Me.ProgressBar1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 527)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(912, 31)
        Me.Panel2.TabIndex = 4
        '
        'CurrentPathLabel
        '
        Me.CurrentPathLabel.AutoSize = True
        Me.CurrentPathLabel.Location = New System.Drawing.Point(133, 8)
        Me.CurrentPathLabel.Name = "CurrentPathLabel"
        Me.CurrentPathLabel.Size = New System.Drawing.Size(0, 13)
        Me.CurrentPathLabel.TabIndex = 2
        '
        'OpenFolderButton
        '
        Me.OpenFolderButton.Location = New System.Drawing.Point(724, 3)
        Me.OpenFolderButton.Name = "OpenFolderButton"
        Me.OpenFolderButton.Size = New System.Drawing.Size(104, 23)
        Me.OpenFolderButton.TabIndex = 1
        Me.OpenFolderButton.Text = "Open Folder"
        Me.OpenFolderButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(834, 3)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 1
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(3, 3)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(124, 23)
        Me.ProgressBar1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.tvResults)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 29)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(912, 498)
        Me.Panel3.TabIndex = 5
        '
        'tvResults
        '
        Me.tvResults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvResults.Location = New System.Drawing.Point(0, 0)
        Me.tvResults.Name = "tvResults"
        Me.tvResults.Size = New System.Drawing.Size(912, 498)
        Me.tvResults.TabIndex = 0
        '
        'frmDeduplicate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 558)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmDeduplicate"
        Me.Text = "Paul's Duplicate File Finder"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DrivesComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FindDuplicatesButton As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents OpenFolderButton As System.Windows.Forms.Button
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents CurrentPathLabel As System.Windows.Forms.Label
    Friend WithEvents tvResults As System.Windows.Forms.TreeView

End Class
