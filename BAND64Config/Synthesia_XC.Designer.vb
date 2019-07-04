<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Synthesia_XC
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
        Me.SynPic1 = New System.Windows.Forms.PictureBox()
        Me.SynLabel1 = New System.Windows.Forms.Label()
        Me.RUNButton = New System.Windows.Forms.Button()
        Me.REPORTButton = New System.Windows.Forms.Button()
        Me.SETTINGButton = New System.Windows.Forms.Button()
        Me.EXITButton = New System.Windows.Forms.Button()
        Me.INFOButton = New System.Windows.Forms.Button()
        Me.LinkBAND64 = New System.Windows.Forms.LinkLabel()
        Me.LinkMASTERkreatif = New System.Windows.Forms.LinkLabel()
        CType(Me.SynPic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SynPic1
        '
        Me.SynPic1.Image = Global.BAND64Config.My.Resources.Resources.Synthesia_X
        Me.SynPic1.Location = New System.Drawing.Point(113, 25)
        Me.SynPic1.Name = "SynPic1"
        Me.SynPic1.Size = New System.Drawing.Size(115, 118)
        Me.SynPic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SynPic1.TabIndex = 0
        Me.SynPic1.TabStop = False
        '
        'SynLabel1
        '
        Me.SynLabel1.AutoSize = True
        Me.SynLabel1.Font = New System.Drawing.Font("Adobe Heiti Std R", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.SynLabel1.Location = New System.Drawing.Point(90, 155)
        Me.SynLabel1.Name = "SynLabel1"
        Me.SynLabel1.Size = New System.Drawing.Size(166, 34)
        Me.SynLabel1.TabIndex = 1
        Me.SynLabel1.Text = "Synthesia_X"
        '
        'RUNButton
        '
        Me.RUNButton.Location = New System.Drawing.Point(86, 202)
        Me.RUNButton.Name = "RUNButton"
        Me.RUNButton.Size = New System.Drawing.Size(178, 36)
        Me.RUNButton.TabIndex = 2
        Me.RUNButton.Text = "Execute Synthesia_X"
        Me.RUNButton.UseVisualStyleBackColor = True
        '
        'REPORTButton
        '
        Me.REPORTButton.Location = New System.Drawing.Point(86, 260)
        Me.REPORTButton.Name = "REPORTButton"
        Me.REPORTButton.Size = New System.Drawing.Size(178, 36)
        Me.REPORTButton.TabIndex = 3
        Me.REPORTButton.Text = "Report a Bug"
        Me.REPORTButton.UseVisualStyleBackColor = True
        '
        'SETTINGButton
        '
        Me.SETTINGButton.Location = New System.Drawing.Point(86, 322)
        Me.SETTINGButton.Name = "SETTINGButton"
        Me.SETTINGButton.Size = New System.Drawing.Size(178, 36)
        Me.SETTINGButton.TabIndex = 4
        Me.SETTINGButton.Text = "Settings"
        Me.SETTINGButton.UseVisualStyleBackColor = True
        '
        'EXITButton
        '
        Me.EXITButton.Location = New System.Drawing.Point(86, 452)
        Me.EXITButton.Name = "EXITButton"
        Me.EXITButton.Size = New System.Drawing.Size(178, 36)
        Me.EXITButton.TabIndex = 5
        Me.EXITButton.Text = "Exit"
        Me.EXITButton.UseVisualStyleBackColor = True
        '
        'INFOButton
        '
        Me.INFOButton.Location = New System.Drawing.Point(86, 389)
        Me.INFOButton.Name = "INFOButton"
        Me.INFOButton.Size = New System.Drawing.Size(178, 36)
        Me.INFOButton.TabIndex = 6
        Me.INFOButton.Text = "Info..."
        Me.INFOButton.UseVisualStyleBackColor = True
        '
        'LinkBAND64
        '
        Me.LinkBAND64.AutoSize = True
        Me.LinkBAND64.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.LinkBAND64.Location = New System.Drawing.Point(280, 485)
        Me.LinkBAND64.Name = "LinkBAND64"
        Me.LinkBAND64.Size = New System.Drawing.Size(77, 17)
        Me.LinkBAND64.TabIndex = 7
        Me.LinkBAND64.TabStop = True
        Me.LinkBAND64.Text = "By BAND64"
        '
        'LinkMASTERkreatif
        '
        Me.LinkMASTERkreatif.AutoSize = True
        Me.LinkMASTERkreatif.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.LinkMASTERkreatif.Location = New System.Drawing.Point(243, 502)
        Me.LinkMASTERkreatif.Name = "LinkMASTERkreatif"
        Me.LinkMASTERkreatif.Size = New System.Drawing.Size(114, 17)
        Me.LinkMASTERkreatif.TabIndex = 8
        Me.LinkMASTERkreatif.TabStop = True
        Me.LinkMASTERkreatif.Text = "By MASTERkreatif"
        '
        'Synthesia_XC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 521)
        Me.Controls.Add(Me.LinkMASTERkreatif)
        Me.Controls.Add(Me.LinkBAND64)
        Me.Controls.Add(Me.INFOButton)
        Me.Controls.Add(Me.EXITButton)
        Me.Controls.Add(Me.SETTINGButton)
        Me.Controls.Add(Me.REPORTButton)
        Me.Controls.Add(Me.RUNButton)
        Me.Controls.Add(Me.SynLabel1)
        Me.Controls.Add(Me.SynPic1)
        Me.Name = "Synthesia_XC"
        Me.Text = "Synthesia_X Config"
        CType(Me.SynPic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SynPic1 As PictureBox
    Friend WithEvents SynLabel1 As Label
    Friend WithEvents RUNButton As Button
    Friend WithEvents REPORTButton As Button
    Friend WithEvents SETTINGButton As Button
    Friend WithEvents EXITButton As Button
    Friend WithEvents INFOButton As Button
    Friend WithEvents LinkBAND64 As LinkLabel
    Friend WithEvents LinkMASTERkreatif As LinkLabel
End Class
