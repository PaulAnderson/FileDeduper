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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DrivesComboBox = New System.Windows.Forms.ComboBox()
        Me.FindDuplicatesButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbLimit = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CurrentPathLabel = New System.Windows.Forms.Label()
        Me.btnExpandAll = New System.Windows.Forms.Button()
        Me.OpenFolderButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblNoResults = New System.Windows.Forms.Label()
        Me.tvResults = New System.Windows.Forms.TreeView()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Start Path"
        '
        'DrivesComboBox
        '
        Me.DrivesComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DrivesComboBox.FormattingEnabled = True
        Me.DrivesComboBox.Location = New System.Drawing.Point(84, 3)
        Me.DrivesComboBox.Name = "DrivesComboBox"
        Me.DrivesComboBox.Size = New System.Drawing.Size(694, 21)
        Me.DrivesComboBox.TabIndex = 1
        '
        'FindDuplicatesButton
        '
        Me.FindDuplicatesButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FindDuplicatesButton.Location = New System.Drawing.Point(784, 3)
        Me.FindDuplicatesButton.Name = "FindDuplicatesButton"
        Me.FindDuplicatesButton.Size = New System.Drawing.Size(125, 39)
        Me.FindDuplicatesButton.TabIndex = 2
        Me.FindDuplicatesButton.Text = "Find Duplicates"
        Me.FindDuplicatesButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cbLimit)
        Me.Panel1.Controls.Add(Me.DrivesComboBox)
        Me.Panel1.Controls.Add(Me.FindDuplicatesButton)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(912, 51)
        Me.Panel1.TabIndex = 3
        '
        'cbLimit
        '
        Me.cbLimit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbLimit.AutoSize = True
        Me.cbLimit.Checked = True
        Me.cbLimit.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbLimit.Location = New System.Drawing.Point(84, 28)
        Me.cbLimit.Name = "cbLimit"
        Me.cbLimit.Size = New System.Drawing.Size(232, 17)
        Me.cbLimit.TabIndex = 3
        Me.cbLimit.Text = "Limit Display to 100 Largest results (quicker)"
        Me.ToolTip1.SetToolTip(Me.cbLimit, "Un-check to see all results")
        Me.cbLimit.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CurrentPathLabel)
        Me.Panel2.Controls.Add(Me.btnExpandAll)
        Me.Panel2.Controls.Add(Me.OpenFolderButton)
        Me.Panel2.Controls.Add(Me.CloseButton)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 513)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(912, 45)
        Me.Panel2.TabIndex = 4
        '
        'CurrentPathLabel
        '
        Me.CurrentPathLabel.Location = New System.Drawing.Point(3, 3)
        Me.CurrentPathLabel.Name = "CurrentPathLabel"
        Me.CurrentPathLabel.Size = New System.Drawing.Size(513, 39)
        Me.CurrentPathLabel.TabIndex = 2
        '
        'btnExpandAll
        '
        Me.btnExpandAll.Location = New System.Drawing.Point(522, 3)
        Me.btnExpandAll.Name = "btnExpandAll"
        Me.btnExpandAll.Size = New System.Drawing.Size(125, 39)
        Me.btnExpandAll.TabIndex = 1
        Me.btnExpandAll.Text = "Expand All"
        Me.btnExpandAll.UseVisualStyleBackColor = True
        '
        'OpenFolderButton
        '
        Me.OpenFolderButton.Location = New System.Drawing.Point(653, 3)
        Me.OpenFolderButton.Name = "OpenFolderButton"
        Me.OpenFolderButton.Size = New System.Drawing.Size(125, 39)
        Me.OpenFolderButton.TabIndex = 1
        Me.OpenFolderButton.Text = "Open Folder"
        Me.OpenFolderButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(784, 3)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(125, 39)
        Me.CloseButton.TabIndex = 1
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ProgressBar1)
        Me.Panel3.Controls.Add(Me.lblNoResults)
        Me.Panel3.Controls.Add(Me.tvResults)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 51)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(912, 462)
        Me.Panel3.TabIndex = 5
        '
        'lblNoResults
        '
        Me.lblNoResults.AutoSize = True
        Me.lblNoResults.BackColor = System.Drawing.Color.White
        Me.lblNoResults.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoResults.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblNoResults.Location = New System.Drawing.Point(12, 16)
        Me.lblNoResults.Name = "lblNoResults"
        Me.lblNoResults.Size = New System.Drawing.Size(162, 17)
        Me.lblNoResults.TabIndex = 1
        Me.lblNoResults.Text = "No duplicate files found."
        Me.lblNoResults.Visible = False
        '
        'tvResults
        '
        Me.tvResults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvResults.Location = New System.Drawing.Point(0, 0)
        Me.tvResults.Name = "tvResults"
        Me.tvResults.Size = New System.Drawing.Size(912, 462)
        Me.tvResults.TabIndex = 0
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(3, 433)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(906, 23)
        Me.ProgressBar1.TabIndex = 2
        Me.ProgressBar1.Visible = False
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
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DrivesComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FindDuplicatesButton As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents OpenFolderButton As System.Windows.Forms.Button
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents CurrentPathLabel As System.Windows.Forms.Label
    Friend WithEvents tvResults As System.Windows.Forms.TreeView
    Friend WithEvents cbLimit As System.Windows.Forms.CheckBox
    Friend WithEvents btnExpandAll As System.Windows.Forms.Button
    Friend WithEvents lblNoResults As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar

End Class
