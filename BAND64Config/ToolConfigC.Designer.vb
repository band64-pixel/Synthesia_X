<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ToolConfigC
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
        Me.INFOButton = New System.Windows.Forms.Button()
        Me.EXITButton = New System.Windows.Forms.Button()
        Me.SETTINGButton = New System.Windows.Forms.Button()
        Me.REPORTButton = New System.Windows.Forms.Button()
        Me.TCLabel1 = New System.Windows.Forms.Label()
        Me.TCPic1 = New System.Windows.Forms.PictureBox()
        CType(Me.TCPic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LinkBAND64
        '
        Me.LinkBAND64.AutoSize = True
        Me.LinkBAND64.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.LinkBAND64.Location = New System.Drawing.Point(270, 441)
        Me.LinkBAND64.Name = "LinkBAND64"
        Me.LinkBAND64.Size = New System.Drawing.Size(77, 17)
        Me.LinkBAND64.TabIndex = 15
        Me.LinkBAND64.TabStop = True
        Me.LinkBAND64.Text = "By BAND64"
        '
        'INFOButton
        '
        Me.INFOButton.Location = New System.Drawing.Point(71, 329)
        Me.INFOButton.Name = "INFOButton"
        Me.INFOButton.Size = New System.Drawing.Size(178, 36)
        Me.INFOButton.TabIndex = 14
        Me.INFOButton.Text = "Info..."
        Me.INFOButton.UseVisualStyleBackColor = True
        '
        'EXITButton
        '
        Me.EXITButton.Location = New System.Drawing.Point(71, 392)
        Me.EXITButton.Name = "EXITButton"
        Me.EXITButton.Size = New System.Drawing.Size(178, 36)
        Me.EXITButton.TabIndex = 13
        Me.EXITButton.Text = "Exit"
        Me.EXITButton.UseVisualStyleBackColor = True
        '
        'SETTINGButton
        '
        Me.SETTINGButton.Location = New System.Drawing.Point(71, 262)
        Me.SETTINGButton.Name = "SETTINGButton"
        Me.SETTINGButton.Size = New System.Drawing.Size(178, 36)
        Me.SETTINGButton.TabIndex = 12
        Me.SETTINGButton.Text = "Settings"
        Me.SETTINGButton.UseVisualStyleBackColor = True
        '
        'REPORTButton
        '
        Me.REPORTButton.Location = New System.Drawing.Point(71, 200)
        Me.REPORTButton.Name = "REPORTButton"
        Me.REPORTButton.Size = New System.Drawing.Size(178, 36)
        Me.REPORTButton.TabIndex = 11
        Me.REPORTButton.Text = "Report a Bug"
        Me.REPORTButton.UseVisualStyleBackColor = True
        '
        'TCLabel1
        '
        Me.TCLabel1.AutoSize = True
        Me.TCLabel1.Font = New System.Drawing.Font("Adobe Heiti Std R", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TCLabel1.Location = New System.Drawing.Point(24, 145)
        Me.TCLabel1.Name = "TCLabel1"
        Me.TCLabel1.Size = New System.Drawing.Size(282, 34)
        Me.TCLabel1.TabIndex = 9
        Me.TCLabel1.Text = "BAND64's Tool Config"
        '
        'TCPic1
        '
        Me.TCPic1.Image = Global.BAND64Config.My.Resources.Resources.ToolConfigX
        Me.TCPic1.Location = New System.Drawing.Point(38, 18)
        Me.TCPic1.Name = "TCPic1"
        Me.TCPic1.Size = New System.Drawing.Size(252, 118)
        Me.TCPic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.TCPic1.TabIndex = 8
        Me.TCPic1.TabStop = False
        '
        'ToolConfigC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 470)
        Me.Controls.Add(Me.LinkBAND64)
        Me.Controls.Add(Me.INFOButton)
        Me.Controls.Add(Me.EXITButton)
        Me.Controls.Add(Me.SETTINGButton)
        Me.Controls.Add(Me.REPORTButton)
        Me.Controls.Add(Me.TCLabel1)
        Me.Controls.Add(Me.TCPic1)
        Me.Name = "ToolConfigC"
        Me.Text = "BAND64's Tool Config"
        CType(Me.TCPic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LinkBAND64 As LinkLabel
    Friend WithEvents INFOButton As Button
    Friend WithEvents EXITButton As Button
    Friend WithEvents SETTINGButton As Button
    Friend WithEvents REPORTButton As Button
    Friend WithEvents TCLabel1 As Label
    Friend WithEvents TCPic1 As PictureBox
End Class
