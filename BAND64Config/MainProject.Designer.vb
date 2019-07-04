<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BAND64Config
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
        Me.MainPic1 = New System.Windows.Forms.PictureBox()
        Me.Comb = New System.Windows.Forms.ComboBox()
        Me.ToolCon = New System.Windows.Forms.Button()
        CType(Me.MainPic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainPic1
        '
        Me.MainPic1.Image = Global.BAND64Config.My.Resources.Resources.ToolConfigX
        Me.MainPic1.Location = New System.Drawing.Point(50, 12)
        Me.MainPic1.Name = "MainPic1"
        Me.MainPic1.Size = New System.Drawing.Size(259, 121)
        Me.MainPic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.MainPic1.TabIndex = 0
        Me.MainPic1.TabStop = False
        '
        'Comb
        '
        Me.Comb.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Comb.Items.AddRange(New Object() {"Synthesia_X", "DrCode Engine", "BAND64's Tool Config"})
        Me.Comb.Location = New System.Drawing.Point(95, 150)
        Me.Comb.Name = "Comb"
        Me.Comb.Size = New System.Drawing.Size(164, 25)
        Me.Comb.TabIndex = 1
        Me.Comb.Text = "      Select the Tool"
        '
        'ToolCon
        '
        Me.ToolCon.Location = New System.Drawing.Point(120, 190)
        Me.ToolCon.Name = "ToolCon"
        Me.ToolCon.Size = New System.Drawing.Size(116, 23)
        Me.ToolCon.TabIndex = 2
        Me.ToolCon.Text = "Show Tool Config"
        Me.ToolCon.UseVisualStyleBackColor = True
        '
        'BAND64Config
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 234)
        Me.Controls.Add(Me.ToolCon)
        Me.Controls.Add(Me.Comb)
        Me.Controls.Add(Me.MainPic1)
        Me.Name = "BAND64Config"
        Me.Text = "BAND64's Tool Config"
        CType(Me.MainPic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainPic1 As PictureBox
    Friend WithEvents Comb As ComboBox
    Friend WithEvents ToolCon As Button
End Class
