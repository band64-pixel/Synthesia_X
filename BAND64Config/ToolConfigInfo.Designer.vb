<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ToolConfigInfo
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
        Me.AbtButton = New System.Windows.Forms.Button()
        Me.ChkUpdate = New System.Windows.Forms.Button()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.LinkBAND64 = New System.Windows.Forms.LinkLabel()
        Me.SynLabel1 = New System.Windows.Forms.Label()
        Me.SynPic1 = New System.Windows.Forms.PictureBox()
        CType(Me.SynPic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AbtButton
        '
        Me.AbtButton.Location = New System.Drawing.Point(176, 200)
        Me.AbtButton.Name = "AbtButton"
        Me.AbtButton.Size = New System.Drawing.Size(103, 38)
        Me.AbtButton.TabIndex = 19
        Me.AbtButton.Text = "About Site..."
        Me.AbtButton.UseVisualStyleBackColor = True
        '
        'ChkUpdate
        '
        Me.ChkUpdate.Location = New System.Drawing.Point(57, 200)
        Me.ChkUpdate.Name = "ChkUpdate"
        Me.ChkUpdate.Size = New System.Drawing.Size(103, 38)
        Me.ChkUpdate.TabIndex = 18
        Me.ChkUpdate.Text = "Check Update!"
        Me.ChkUpdate.UseVisualStyleBackColor = True
        '
        'VersionLabel
        '
        Me.VersionLabel.AutoSize = True
        Me.VersionLabel.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.VersionLabel.Location = New System.Drawing.Point(245, 296)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(107, 24)
        Me.VersionLabel.TabIndex = 17
        Me.VersionLabel.Text = "Ver. 1.0.0.0"
        '
        'LinkBAND64
        '
        Me.LinkBAND64.AutoSize = True
        Me.LinkBAND64.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.LinkBAND64.Location = New System.Drawing.Point(272, 276)
        Me.LinkBAND64.Name = "LinkBAND64"
        Me.LinkBAND64.Size = New System.Drawing.Size(77, 17)
        Me.LinkBAND64.TabIndex = 16
        Me.LinkBAND64.TabStop = True
        Me.LinkBAND64.Text = "By BAND64"
        '
        'SynLabel1
        '
        Me.SynLabel1.AutoSize = True
        Me.SynLabel1.Font = New System.Drawing.Font("Adobe Heiti Std R", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.SynLabel1.Location = New System.Drawing.Point(30, 139)
        Me.SynLabel1.Name = "SynLabel1"
        Me.SynLabel1.Size = New System.Drawing.Size(282, 34)
        Me.SynLabel1.TabIndex = 21
        Me.SynLabel1.Text = "BAND64's Tool Config"
        '
        'SynPic1
        '
        Me.SynPic1.Image = Global.BAND64Config.My.Resources.Resources.ToolConfigX
        Me.SynPic1.Location = New System.Drawing.Point(44, 12)
        Me.SynPic1.Name = "SynPic1"
        Me.SynPic1.Size = New System.Drawing.Size(252, 118)
        Me.SynPic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SynPic1.TabIndex = 20
        Me.SynPic1.TabStop = False
        '
        'ToolConfigInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 327)
        Me.Controls.Add(Me.SynLabel1)
        Me.Controls.Add(Me.SynPic1)
        Me.Controls.Add(Me.AbtButton)
        Me.Controls.Add(Me.ChkUpdate)
        Me.Controls.Add(Me.VersionLabel)
        Me.Controls.Add(Me.LinkBAND64)
        Me.Name = "ToolConfigInfo"
        Me.Text = "Information about the Tool Config"
        CType(Me.SynPic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AbtButton As Button
    Friend WithEvents ChkUpdate As Button
    Friend WithEvents VersionLabel As Label
    Friend WithEvents LinkBAND64 As LinkLabel
    Friend WithEvents SynLabel1 As Label
    Friend WithEvents SynPic1 As PictureBox
End Class
