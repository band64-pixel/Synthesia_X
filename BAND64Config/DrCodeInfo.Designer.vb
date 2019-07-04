<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DrCodeInfo
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
        Me.LinkBAND64 = New System.Windows.Forms.LinkLabel()
        Me.EXITButton = New System.Windows.Forms.Button()
        Me.REPORTButton = New System.Windows.Forms.Button()
        Me.DrLabel1 = New System.Windows.Forms.Label()
        Me.VerText = New System.Windows.Forms.Label()
        Me.AbtButton = New System.Windows.Forms.Button()
        Me.ChkUpdate = New System.Windows.Forms.Button()
        Me.DrPic1 = New System.Windows.Forms.PictureBox()
        Me.LinkMASTERkreatif = New System.Windows.Forms.LinkLabel()
        CType(Me.DrPic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LinkBAND64
        '
        Me.LinkBAND64.AutoSize = True
        Me.LinkBAND64.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.LinkBAND64.Location = New System.Drawing.Point(344, 337)
        Me.LinkBAND64.Name = "LinkBAND64"
        Me.LinkBAND64.Size = New System.Drawing.Size(77, 17)
        Me.LinkBAND64.TabIndex = 12
        Me.LinkBAND64.TabStop = True
        Me.LinkBAND64.Text = "By BAND64"
        '
        'EXITButton
        '
        Me.EXITButton.Location = New System.Drawing.Point(106, 318)
        Me.EXITButton.Name = "EXITButton"
        Me.EXITButton.Size = New System.Drawing.Size(178, 36)
        Me.EXITButton.TabIndex = 11
        Me.EXITButton.Text = "Exit"
        Me.EXITButton.UseVisualStyleBackColor = True
        '
        'REPORTButton
        '
        Me.REPORTButton.Location = New System.Drawing.Point(106, 255)
        Me.REPORTButton.Name = "REPORTButton"
        Me.REPORTButton.Size = New System.Drawing.Size(178, 36)
        Me.REPORTButton.TabIndex = 10
        Me.REPORTButton.Text = "Report a Bug"
        Me.REPORTButton.UseVisualStyleBackColor = True
        '
        'DrLabel1
        '
        Me.DrLabel1.AutoSize = True
        Me.DrLabel1.Font = New System.Drawing.Font("Adobe Heiti Std R", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DrLabel1.Location = New System.Drawing.Point(88, 140)
        Me.DrLabel1.Name = "DrLabel1"
        Me.DrLabel1.Size = New System.Drawing.Size(197, 34)
        Me.DrLabel1.TabIndex = 9
        Me.DrLabel1.Text = "DrCode Engine"
        '
        'VerText
        '
        Me.VerText.AutoSize = True
        Me.VerText.Font = New System.Drawing.Font("Adobe Heiti Std R", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.VerText.Location = New System.Drawing.Point(309, 378)
        Me.VerText.Name = "VerText"
        Me.VerText.Size = New System.Drawing.Size(117, 26)
        Me.VerText.TabIndex = 13
        Me.VerText.Text = "Ver. 1.0.0.0"
        '
        'AbtButton
        '
        Me.AbtButton.Location = New System.Drawing.Point(197, 189)
        Me.AbtButton.Name = "AbtButton"
        Me.AbtButton.Size = New System.Drawing.Size(103, 38)
        Me.AbtButton.TabIndex = 15
        Me.AbtButton.Text = "About Site..."
        Me.AbtButton.UseVisualStyleBackColor = True
        '
        'ChkUpdate
        '
        Me.ChkUpdate.Location = New System.Drawing.Point(78, 189)
        Me.ChkUpdate.Name = "ChkUpdate"
        Me.ChkUpdate.Size = New System.Drawing.Size(103, 38)
        Me.ChkUpdate.TabIndex = 14
        Me.ChkUpdate.Text = "Check Update!"
        Me.ChkUpdate.UseVisualStyleBackColor = True
        '
        'DrPic1
        '
        Me.DrPic1.Image = Global.BAND64Config.My.Resources.Resources.DrCode
        Me.DrPic1.Location = New System.Drawing.Point(123, 12)
        Me.DrPic1.Name = "DrPic1"
        Me.DrPic1.Size = New System.Drawing.Size(131, 125)
        Me.DrPic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.DrPic1.TabIndex = 8
        Me.DrPic1.TabStop = False
        '
        'LinkMASTERkreatif
        '
        Me.LinkMASTERkreatif.AutoSize = True
        Me.LinkMASTERkreatif.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.LinkMASTERkreatif.Location = New System.Drawing.Point(307, 354)
        Me.LinkMASTERkreatif.Name = "LinkMASTERkreatif"
        Me.LinkMASTERkreatif.Size = New System.Drawing.Size(114, 17)
        Me.LinkMASTERkreatif.TabIndex = 16
        Me.LinkMASTERkreatif.TabStop = True
        Me.LinkMASTERkreatif.Text = "By MASTERkreatif"
        '
        'DrCodeInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 411)
        Me.Controls.Add(Me.LinkMASTERkreatif)
        Me.Controls.Add(Me.AbtButton)
        Me.Controls.Add(Me.ChkUpdate)
        Me.Controls.Add(Me.VerText)
        Me.Controls.Add(Me.LinkBAND64)
        Me.Controls.Add(Me.EXITButton)
        Me.Controls.Add(Me.REPORTButton)
        Me.Controls.Add(Me.DrLabel1)
        Me.Controls.Add(Me.DrPic1)
        Me.Name = "DrCodeInfo"
        Me.Text = "DrCode Config"
        CType(Me.DrPic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LinkBAND64 As LinkLabel
    Friend WithEvents EXITButton As Button
    Friend WithEvents REPORTButton As Button
    Friend WithEvents DrLabel1 As Label
    Friend WithEvents DrPic1 As PictureBox
    Friend WithEvents VerText As Label
    Friend WithEvents AbtButton As Button
    Friend WithEvents ChkUpdate As Button
    Friend WithEvents LinkMASTERkreatif As LinkLabel
End Class
