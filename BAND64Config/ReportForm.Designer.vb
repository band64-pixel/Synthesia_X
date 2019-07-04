<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportForm
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
        Me.Comb1 = New System.Windows.Forms.ComboBox()
        Me.Lab1 = New System.Windows.Forms.Label()
        Me.DescBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lnkButton = New System.Windows.Forms.Button()
        Me.SenButton = New System.Windows.Forms.Button()
        Me.DelButton = New System.Windows.Forms.Button()
        Me.MAIL_ATTACHMENT = New System.Windows.Forms.TextBox()
        Me.attLab = New System.Windows.Forms.Label()
        Me.UplButton = New System.Windows.Forms.Button()
        Me.FileDlg = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'Comb1
        '
        Me.Comb1.FormattingEnabled = True
        Me.Comb1.Location = New System.Drawing.Point(22, 36)
        Me.Comb1.Name = "Comb1"
        Me.Comb1.Size = New System.Drawing.Size(185, 20)
        Me.Comb1.TabIndex = 0
        '
        'Lab1
        '
        Me.Lab1.AutoSize = True
        Me.Lab1.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab1.Location = New System.Drawing.Point(31, 13)
        Me.Lab1.Name = "Lab1"
        Me.Lab1.Size = New System.Drawing.Size(66, 17)
        Me.Lab1.TabIndex = 1
        Me.Lab1.Text = "Category"
        '
        'DescBox
        '
        Me.DescBox.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.DescBox.Location = New System.Drawing.Point(34, 73)
        Me.DescBox.Multiline = True
        Me.DescBox.Name = "DescBox"
        Me.DescBox.ReadOnly = True
        Me.DescBox.Size = New System.Drawing.Size(446, 190)
        Me.DescBox.TabIndex = 2
        Me.DescBox.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                                   " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                               " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   " &
    "                                     Select the Category :)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(223, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Description"
        '
        'lnkButton
        '
        Me.lnkButton.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkButton.Location = New System.Drawing.Point(407, 13)
        Me.lnkButton.Name = "lnkButton"
        Me.lnkButton.Size = New System.Drawing.Size(87, 48)
        Me.lnkButton.TabIndex = 4
        Me.lnkButton.Text = "More Information"
        Me.lnkButton.UseVisualStyleBackColor = True
        '
        'SenButton
        '
        Me.SenButton.Enabled = False
        Me.SenButton.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SenButton.Location = New System.Drawing.Point(423, 318)
        Me.SenButton.Name = "SenButton"
        Me.SenButton.Size = New System.Drawing.Size(70, 23)
        Me.SenButton.TabIndex = 5
        Me.SenButton.Text = "Send!"
        Me.SenButton.UseVisualStyleBackColor = True
        '
        'DelButton
        '
        Me.DelButton.Enabled = False
        Me.DelButton.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelButton.Location = New System.Drawing.Point(338, 318)
        Me.DelButton.Name = "DelButton"
        Me.DelButton.Size = New System.Drawing.Size(70, 23)
        Me.DelButton.TabIndex = 6
        Me.DelButton.Text = "Delete"
        Me.DelButton.UseVisualStyleBackColor = True
        '
        'MAIL_ATTACHMENT
        '
        Me.MAIL_ATTACHMENT.Location = New System.Drawing.Point(133, 275)
        Me.MAIL_ATTACHMENT.Name = "MAIL_ATTACHMENT"
        Me.MAIL_ATTACHMENT.ReadOnly = True
        Me.MAIL_ATTACHMENT.Size = New System.Drawing.Size(251, 21)
        Me.MAIL_ATTACHMENT.TabIndex = 7
        '
        'attLab
        '
        Me.attLab.AutoSize = True
        Me.attLab.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.attLab.Location = New System.Drawing.Point(44, 274)
        Me.attLab.Name = "attLab"
        Me.attLab.Size = New System.Drawing.Size(89, 17)
        Me.attLab.TabIndex = 8
        Me.attLab.Text = "Attachment: "
        '
        'UplButton
        '
        Me.UplButton.Enabled = False
        Me.UplButton.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UplButton.Location = New System.Drawing.Point(394, 274)
        Me.UplButton.Name = "UplButton"
        Me.UplButton.Size = New System.Drawing.Size(75, 23)
        Me.UplButton.TabIndex = 9
        Me.UplButton.Text = "Upload"
        Me.UplButton.UseVisualStyleBackColor = True
        '
        'ReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 353)
        Me.Controls.Add(Me.UplButton)
        Me.Controls.Add(Me.attLab)
        Me.Controls.Add(Me.MAIL_ATTACHMENT)
        Me.Controls.Add(Me.DelButton)
        Me.Controls.Add(Me.SenButton)
        Me.Controls.Add(Me.lnkButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DescBox)
        Me.Controls.Add(Me.Lab1)
        Me.Controls.Add(Me.Comb1)
        Me.Name = "ReportForm"
        Me.Text = "Report a Bug!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Comb1 As ComboBox
    Friend WithEvents Lab1 As Label
    Friend WithEvents DescBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lnkButton As Button
    Friend WithEvents SenButton As Button
    Friend WithEvents DelButton As Button
    Friend WithEvents MAIL_ATTACHMENT As TextBox
    Friend WithEvents attLab As Label
    Friend WithEvents UplButton As Button
    Friend WithEvents FileDlg As OpenFileDialog
End Class
