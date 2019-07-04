<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainScreen
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
        Me.components = New System.ComponentModel.Container()
        Me.VerInf = New System.Windows.Forms.Label()
        Me.Prog = New System.Windows.Forms.ProgressBar()
        Me.TextInf = New System.Windows.Forms.Label()
        Me.Time = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'VerInf
        '
        Me.VerInf.AutoSize = True
        Me.VerInf.BackColor = System.Drawing.Color.Transparent
        Me.VerInf.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.VerInf.Font = New System.Drawing.Font("Samsung Sans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VerInf.ForeColor = System.Drawing.SystemColors.ControlText
        Me.VerInf.Location = New System.Drawing.Point(744, 303)
        Me.VerInf.Name = "VerInf"
        Me.VerInf.Size = New System.Drawing.Size(85, 26)
        Me.VerInf.TabIndex = 1
        Me.VerInf.Text = "Version"
        '
        'Prog
        '
        Me.Prog.Location = New System.Drawing.Point(289, 204)
        Me.Prog.Maximum = 110
        Me.Prog.Name = "Prog"
        Me.Prog.Size = New System.Drawing.Size(289, 45)
        Me.Prog.TabIndex = 2
        '
        'TextInf
        '
        Me.TextInf.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextInf.AutoSize = True
        Me.TextInf.BackColor = System.Drawing.Color.Transparent
        Me.TextInf.Font = New System.Drawing.Font("Adobe Heiti Std R", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextInf.Location = New System.Drawing.Point(373, 263)
        Me.TextInf.Name = "TextInf"
        Me.TextInf.Size = New System.Drawing.Size(118, 30)
        Me.TextInf.TabIndex = 3
        Me.TextInf.Text = "Starting..."
        Me.TextInf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Time
        '
        '
        'MainScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BAND64Config.My.Resources.Resources.MainScreen
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(841, 338)
        Me.Controls.Add(Me.TextInf)
        Me.Controls.Add(Me.Prog)
        Me.Controls.Add(Me.VerInf)
        Me.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainScreen"
        Me.Text = "MainScreen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VerInf As Label
    Friend WithEvents Prog As ProgressBar
    Friend WithEvents TextInf As Label
    Friend WithEvents Time As Timer
End Class
