<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.st_synX_Label = New System.Windows.Forms.Label()
        Me.st_synX_Text = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.st_synX_selButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.CrEG_Group = New System.Windows.Forms.GroupBox()
        Me.CrEG_DrCode = New System.Windows.Forms.RadioButton()
        Me.CrEG_InPr = New System.Windows.Forms.RadioButton()
        Me.CrEG_InPath = New System.Windows.Forms.RadioButton()
        Me.cr_algGroup = New System.Windows.Forms.GroupBox()
        Me.Cralg4 = New System.Windows.Forms.RadioButton()
        Me.Cralg3 = New System.Windows.Forms.RadioButton()
        Me.Cralg2 = New System.Windows.Forms.RadioButton()
        Me.Cralg1 = New System.Windows.Forms.RadioButton()
        Me.OpenFileDialog_X = New System.Windows.Forms.OpenFileDialog()
        Me.cmdText = New System.Windows.Forms.TextBox()
        Me.cmdLabel = New System.Windows.Forms.Label()
        Me.ChkUpdate = New System.Windows.Forms.CheckBox()
        Me.ExCode = New System.Windows.Forms.CheckBox()
        Me.SaveFileDialog_set = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog_set = New System.Windows.Forms.OpenFileDialog()
        Me.AdvInfo = New System.Windows.Forms.CheckBox()
        Me.Cr_argGroup = New System.Windows.Forms.GroupBox()
        Me.Crarg2 = New System.Windows.Forms.RadioButton()
        Me.Crarg1 = New System.Windows.Forms.RadioButton()
        Me.CrEG_Group.SuspendLayout()
        Me.cr_algGroup.SuspendLayout()
        Me.Cr_argGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'st_synX_Label
        '
        Me.st_synX_Label.AutoSize = True
        Me.st_synX_Label.Font = New System.Drawing.Font("돋움", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.st_synX_Label.Location = New System.Drawing.Point(12, 22)
        Me.st_synX_Label.Name = "st_synX_Label"
        Me.st_synX_Label.Size = New System.Drawing.Size(107, 12)
        Me.st_synX_Label.TabIndex = 0
        Me.st_synX_Label.Text = "Synthesia_X Path:"
        '
        'st_synX_Text
        '
        Me.st_synX_Text.Location = New System.Drawing.Point(121, 17)
        Me.st_synX_Text.Name = "st_synX_Text"
        Me.st_synX_Text.Size = New System.Drawing.Size(152, 21)
        Me.st_synX_Text.TabIndex = 1
        Me.st_synX_Text.Text = "Default"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.LightCoral
        Me.Label1.Location = New System.Drawing.Point(43, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tip: I recommend writing ""Default""."
        '
        'st_synX_selButton
        '
        Me.st_synX_selButton.Location = New System.Drawing.Point(279, 12)
        Me.st_synX_selButton.Name = "st_synX_selButton"
        Me.st_synX_selButton.Size = New System.Drawing.Size(75, 47)
        Me.st_synX_selButton.TabIndex = 3
        Me.st_synX_selButton.Text = "Select Path!"
        Me.st_synX_selButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(279, 220)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(89, 52)
        Me.SaveButton.TabIndex = 4
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'CrEG_Group
        '
        Me.CrEG_Group.Controls.Add(Me.CrEG_DrCode)
        Me.CrEG_Group.Controls.Add(Me.CrEG_InPr)
        Me.CrEG_Group.Controls.Add(Me.CrEG_InPath)
        Me.CrEG_Group.Location = New System.Drawing.Point(14, 71)
        Me.CrEG_Group.Name = "CrEG_Group"
        Me.CrEG_Group.Size = New System.Drawing.Size(193, 49)
        Me.CrEG_Group.TabIndex = 5
        Me.CrEG_Group.TabStop = False
        Me.CrEG_Group.Text = "Crack Engine"
        '
        'CrEG_DrCode
        '
        Me.CrEG_DrCode.AutoSize = True
        Me.CrEG_DrCode.Checked = True
        Me.CrEG_DrCode.Location = New System.Drawing.Point(122, 21)
        Me.CrEG_DrCode.Name = "CrEG_DrCode"
        Me.CrEG_DrCode.Size = New System.Drawing.Size(65, 16)
        Me.CrEG_DrCode.TabIndex = 1
        Me.CrEG_DrCode.TabStop = True
        Me.CrEG_DrCode.Text = "DrCode"
        Me.CrEG_DrCode.UseVisualStyleBackColor = True
        '
        'CrEG_InPr
        '
        Me.CrEG_InPr.AutoSize = True
        Me.CrEG_InPr.Location = New System.Drawing.Point(71, 21)
        Me.CrEG_InPr.Name = "CrEG_InPr"
        Me.CrEG_InPr.Size = New System.Drawing.Size(45, 16)
        Me.CrEG_InPr.TabIndex = 0
        Me.CrEG_InPr.Text = "InPr"
        Me.CrEG_InPr.UseVisualStyleBackColor = True
        '
        'CrEG_InPath
        '
        Me.CrEG_InPath.AutoSize = True
        Me.CrEG_InPath.Location = New System.Drawing.Point(7, 21)
        Me.CrEG_InPath.Name = "CrEG_InPath"
        Me.CrEG_InPath.Size = New System.Drawing.Size(58, 16)
        Me.CrEG_InPath.TabIndex = 0
        Me.CrEG_InPath.Text = "InPath"
        Me.CrEG_InPath.UseVisualStyleBackColor = True
        '
        'cr_algGroup
        '
        Me.cr_algGroup.Controls.Add(Me.Cralg4)
        Me.cr_algGroup.Controls.Add(Me.Cralg3)
        Me.cr_algGroup.Controls.Add(Me.Cralg2)
        Me.cr_algGroup.Controls.Add(Me.Cralg1)
        Me.cr_algGroup.Location = New System.Drawing.Point(14, 136)
        Me.cr_algGroup.Name = "cr_algGroup"
        Me.cr_algGroup.Size = New System.Drawing.Size(193, 49)
        Me.cr_algGroup.TabIndex = 6
        Me.cr_algGroup.TabStop = False
        Me.cr_algGroup.Text = "Crack Algorithm"
        '
        'Cralg4
        '
        Me.Cralg4.AutoSize = True
        Me.Cralg4.Location = New System.Drawing.Point(150, 20)
        Me.Cralg4.Name = "Cralg4"
        Me.Cralg4.Size = New System.Drawing.Size(40, 16)
        Me.Cralg4.TabIndex = 4
        Me.Cralg4.Text = "RO"
        Me.Cralg4.UseVisualStyleBackColor = True
        '
        'Cralg3
        '
        Me.Cralg3.AutoSize = True
        Me.Cralg3.Location = New System.Drawing.Point(107, 20)
        Me.Cralg3.Name = "Cralg3"
        Me.Cralg3.Size = New System.Drawing.Size(41, 16)
        Me.Cralg3.TabIndex = 3
        Me.Cralg3.Text = "CO"
        Me.Cralg3.UseVisualStyleBackColor = True
        '
        'Cralg2
        '
        Me.Cralg2.AutoSize = True
        Me.Cralg2.Location = New System.Drawing.Point(51, 20)
        Me.Cralg2.Name = "Cralg2"
        Me.Cralg2.Size = New System.Drawing.Size(55, 16)
        Me.Cralg2.TabIndex = 2
        Me.Cralg2.Text = "RCnR"
        Me.Cralg2.UseVisualStyleBackColor = True
        '
        'Cralg1
        '
        Me.Cralg1.AutoSize = True
        Me.Cralg1.Checked = True
        Me.Cralg1.Location = New System.Drawing.Point(6, 20)
        Me.Cralg1.Name = "Cralg1"
        Me.Cralg1.Size = New System.Drawing.Size(47, 16)
        Me.Cralg1.TabIndex = 1
        Me.Cralg1.TabStop = True
        Me.Cralg1.Text = "CnR"
        Me.Cralg1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog_X
        '
        Me.OpenFileDialog_X.FileName = "Synthesia_X.exe"
        Me.OpenFileDialog_X.Filter = "exe File|*.exe"
        Me.OpenFileDialog_X.Title = "Select Synthesia_X Path"
        '
        'cmdText
        '
        Me.cmdText.Location = New System.Drawing.Point(111, 256)
        Me.cmdText.Name = "cmdText"
        Me.cmdText.Size = New System.Drawing.Size(152, 21)
        Me.cmdText.TabIndex = 8
        Me.cmdText.Text = "/def"
        '
        'cmdLabel
        '
        Me.cmdLabel.AutoSize = True
        Me.cmdLabel.Font = New System.Drawing.Font("돋움", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.cmdLabel.Location = New System.Drawing.Point(12, 260)
        Me.cmdLabel.Name = "cmdLabel"
        Me.cmdLabel.Size = New System.Drawing.Size(98, 12)
        Me.cmdLabel.TabIndex = 7
        Me.cmdLabel.Text = "Command Code:"
        '
        'ChkUpdate
        '
        Me.ChkUpdate.AutoSize = True
        Me.ChkUpdate.Checked = True
        Me.ChkUpdate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkUpdate.Location = New System.Drawing.Point(21, 192)
        Me.ChkUpdate.Name = "ChkUpdate"
        Me.ChkUpdate.Size = New System.Drawing.Size(103, 16)
        Me.ChkUpdate.TabIndex = 9
        Me.ChkUpdate.Text = "Check Update"
        Me.ChkUpdate.UseVisualStyleBackColor = True
        '
        'ExCode
        '
        Me.ExCode.AutoSize = True
        Me.ExCode.Checked = True
        Me.ExCode.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ExCode.Location = New System.Drawing.Point(130, 192)
        Me.ExCode.Name = "ExCode"
        Me.ExCode.Size = New System.Drawing.Size(74, 16)
        Me.ExCode.TabIndex = 10
        Me.ExCode.Text = "Auto Exit"
        Me.ExCode.UseVisualStyleBackColor = True
        '
        'SaveFileDialog_set
        '
        Me.SaveFileDialog_set.FileName = "synX_set.bak"
        Me.SaveFileDialog_set.Filter = "Backup File|*.bak"
        Me.SaveFileDialog_set.Title = "Save Settings Backup File"
        '
        'OpenFileDialog_set
        '
        Me.OpenFileDialog_set.Filter = "Backup Fie|*.bak"
        Me.OpenFileDialog_set.Title = "Select Settings Backup File"
        '
        'AdvInfo
        '
        Me.AdvInfo.AutoSize = True
        Me.AdvInfo.Location = New System.Drawing.Point(21, 220)
        Me.AdvInfo.Name = "AdvInfo"
        Me.AdvInfo.Size = New System.Drawing.Size(146, 16)
        Me.AdvInfo.TabIndex = 11
        Me.AdvInfo.Text = "Advanced Information"
        Me.AdvInfo.UseVisualStyleBackColor = True
        '
        'Cr_argGroup
        '
        Me.Cr_argGroup.Controls.Add(Me.Crarg2)
        Me.Cr_argGroup.Controls.Add(Me.Crarg1)
        Me.Cr_argGroup.Location = New System.Drawing.Point(213, 136)
        Me.Cr_argGroup.Name = "Cr_argGroup"
        Me.Cr_argGroup.Size = New System.Drawing.Size(127, 49)
        Me.Cr_argGroup.TabIndex = 7
        Me.Cr_argGroup.TabStop = False
        Me.Cr_argGroup.Text = "Crack Argument"
        '
        'Crarg2
        '
        Me.Crarg2.AutoSize = True
        Me.Crarg2.Enabled = False
        Me.Crarg2.Location = New System.Drawing.Point(67, 20)
        Me.Crarg2.Name = "Crarg2"
        Me.Crarg2.Size = New System.Drawing.Size(54, 16)
        Me.Crarg2.TabIndex = 2
        Me.Crarg2.Text = "ECod"
        Me.Crarg2.UseVisualStyleBackColor = True
        '
        'Crarg1
        '
        Me.Crarg1.AutoSize = True
        Me.Crarg1.Checked = True
        Me.Crarg1.Location = New System.Drawing.Point(6, 20)
        Me.Crarg1.Name = "Crarg1"
        Me.Crarg1.Size = New System.Drawing.Size(55, 16)
        Me.Crarg1.TabIndex = 1
        Me.Crarg1.TabStop = True
        Me.Crarg1.Text = "RSET"
        Me.Crarg1.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 284)
        Me.Controls.Add(Me.Cr_argGroup)
        Me.Controls.Add(Me.AdvInfo)
        Me.Controls.Add(Me.ExCode)
        Me.Controls.Add(Me.ChkUpdate)
        Me.Controls.Add(Me.cmdText)
        Me.Controls.Add(Me.cmdLabel)
        Me.Controls.Add(Me.cr_algGroup)
        Me.Controls.Add(Me.CrEG_Group)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.st_synX_selButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.st_synX_Text)
        Me.Controls.Add(Me.st_synX_Label)
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.CrEG_Group.ResumeLayout(False)
        Me.CrEG_Group.PerformLayout()
        Me.cr_algGroup.ResumeLayout(False)
        Me.cr_algGroup.PerformLayout()
        Me.Cr_argGroup.ResumeLayout(False)
        Me.Cr_argGroup.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents st_synX_Label As Label
    Friend WithEvents st_synX_Text As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents st_synX_selButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents CrEG_Group As GroupBox
    Friend WithEvents CrEG_DrCode As RadioButton
    Friend WithEvents CrEG_InPr As RadioButton
    Friend WithEvents CrEG_InPath As RadioButton
    Friend WithEvents cr_algGroup As GroupBox
    Friend WithEvents Cralg1 As RadioButton
    Friend WithEvents OpenFileDialog_X As OpenFileDialog
    Friend WithEvents Cralg4 As RadioButton
    Friend WithEvents Cralg3 As RadioButton
    Friend WithEvents Cralg2 As RadioButton
    Friend WithEvents cmdText As TextBox
    Friend WithEvents cmdLabel As Label
    Friend WithEvents ChkUpdate As CheckBox
    Friend WithEvents ExCode As CheckBox
    Friend WithEvents SaveFileDialog_set As SaveFileDialog
    Friend WithEvents OpenFileDialog_set As OpenFileDialog
    Friend WithEvents AdvInfo As CheckBox
    Friend WithEvents Cr_argGroup As GroupBox
    Friend WithEvents Crarg2 As RadioButton
    Friend WithEvents Crarg1 As RadioButton
End Class
