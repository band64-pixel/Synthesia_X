Public Class Synthesia_XInfo
    Private Function GetFileVerInfo(ByVal FileName As String) As Version
        Return Version.Parse(FileVersionInfo.GetVersionInfo(FileName).FileVersion)
    End Function

    Dim iniFile = Application.StartupPath + "\settings.ini"
    Dim Section = "synX_settings"
    Dim st_synXdir As String = ReadIni(iniFile, Section, "st_synX", "")
    Private Sub Synthesia_XInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If st_synXdir = "Default" Then
            VersionLabel.Text = "Ver. " & GetFileVerInfo(Application.StartupPath & "\Synthesia_X.exe").ToString()
        Else
            VersionLabel.Text = "Ver. " & GetFileVerInfo(st_synXdir).ToString()
        End If
    End Sub

    Private Sub LinkMASTERkreatif_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkMASTERkreatif.LinkClicked
        Process.Start("http://www.masterkreatif.com")
    End Sub

    Private Sub LinkBAND64_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkBAND64.LinkClicked
        MessageBox.Show("We are making the BAND64 site. Please wait...", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub AbtButton_Click(sender As Object, e As EventArgs) Handles AbtButton.Click
        MessageBox.Show("We are making the Synthesia_X site. Please wait...", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ChkUpdate_Click(sender As Object, e As EventArgs) Handles ChkUpdate.Click
        MessageBox.Show("We are developing the Checking Update. Please wait...", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class