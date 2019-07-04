<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Synthesia_XInfo
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
        Me.SynLabel1 = New System.Windows.Forms.Label()
        Me.SynPic1 = New System.Windows.Forms.PictureBox()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.ChkUpdate = New System.Windows.Forms.Button()
        Me.AbtButton = New System.Windows.Forms.Button()
        Me.LinkMASTERkreatif = New System.Windows.Forms.LinkLabel()
        CType(Me.SynPic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LinkBAND64
        '
        Me.LinkBAND64.AutoSize = True
        Me.LinkBAND64.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.LinkBAND64.Location = New System.Drawing.Point(284, 256)
        Me.LinkBAND64.Name = "LinkBAND64"
        Me.LinkBAND64.Size = New System.Drawing.Size(77, 17)
        Me.LinkBAND64.TabIndex = 10
        Me.LinkBAND64.TabStop = True
        Me.LinkBAND64.Text = "By BAND64"
        '
        'SynLabel1
        '
        Me.SynLabel1.AutoSize = True
        Me.SynLabel1.Font = New System.Drawing.Font("Adobe Heiti Std R", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.SynLabel1.Location = New System.Drawing.Point(89, 133)
        Me.SynLabel1.Name = "SynLabel1"
        Me.SynLabel1.Size = New System.Drawing.Size(166, 34)
        Me.SynLabel1.TabIndex = 9
        Me.SynLabel1.Text = "Synthesia_X"
        '
        'SynPic1
        '
        Me.SynPic1.Image = Global.BAND64Config.My.Resources.Resources.Synthesia_X
        Me.SynPic1.Location = New System.Drawing.Point(110, 12)
        Me.SynPic1.Name = "SynPic1"
        Me.SynPic1.Size = New System.Drawing.Size(115, 118)
        Me.SynPic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SynPic1.TabIndex = 8
        Me.SynPic1.TabStop = False
        '
        'VersionLabel
        '
        Me.VersionLabel.AutoSize = True
        Me.VersionLabel.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.VersionLabel.Location = New System.Drawing.Point(258, 295)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(107, 24)
        Me.VersionLabel.TabIndex = 11
        Me.VersionLabel.Text = "Ver. 1.0.0.0"
        '
        'ChkUpdate
        '
        Me.ChkUpdate.Location = New System.Drawing.Point(61, 184)
        Me.ChkUpdate.Name = "ChkUpdate"
        Me.ChkUpdate.Size = New System.Drawing.Size(103, 38)
        Me.ChkUpdate.TabIndex = 12
        Me.ChkUpdate.Text = "Check Update!"
        Me.ChkUpdate.UseVisualStyleBackColor = True
        '
        'AbtButton
        '
        Me.AbtButton.Location = New System.Drawing.Point(180, 184)
        Me.AbtButton.Name = "AbtButton"
        Me.AbtButton.Size = New System.Drawing.Size(103, 38)
        Me.AbtButton.TabIndex = 13
        Me.AbtButton.Text = "About Site..."
        Me.AbtButton.UseVisualStyleBackColor = True
        '
        'LinkMASTERkreatif
        '
        Me.LinkMASTERkreatif.AutoSize = True
        Me.LinkMASTERkreatif.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.LinkMASTERkreatif.Location = New System.Drawing.Point(247, 276)
        Me.LinkMASTERkreatif.Name = "LinkMASTERkreatif"
        Me.LinkMASTERkreatif.Size = New System.Drawing.Size(114, 17)
        Me.LinkMASTERkreatif.TabIndex = 14
        Me.LinkMASTERkreatif.TabStop = True
        Me.LinkMASTERkreatif.Text = "By MASTERkreatif"
        '
        'Synthesia_XInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 324)
        Me.Controls.Add(Me.LinkMASTERkreatif)
        Me.Controls.Add(Me.AbtButton)
        Me.Controls.Add(Me.ChkUpdate)
        Me.Controls.Add(Me.VersionLabel)
        Me.Controls.Add(Me.LinkBAND64)
        Me.Controls.Add(Me.SynLabel1)
        Me.Controls.Add(Me.SynPic1)
        Me.Name = "Synthesia_XInfo"
        Me.Text = "Information about Synthesia_X"
        CType(Me.SynPic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LinkBAND64 As LinkLabel
    Friend WithEvents SynLabel1 As Label
    Friend WithEvents SynPic1 As PictureBox
    Friend WithEvents VersionLabel As Label
    Friend WithEvents ChkUpdate As Button
    Friend WithEvents AbtButton As Button
    Friend WithEvents LinkMASTERkreatif As LinkLabel
End Class
