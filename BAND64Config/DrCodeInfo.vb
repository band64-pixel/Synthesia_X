Public Class DrCodeInfo
    Private Function GetFileVerInfo(ByVal FileName As String) As Version
        Return Version.Parse(FileVersionInfo.GetVersionInfo(FileName).FileVersion)
    End Function
    Private Sub DrCodeInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VerText.Text = "Ver. " & GetFileVerInfo(Application.StartupPath & "\DrCode.dll").ToString()
    End Sub

    Private Sub REPORTButton_Click(sender As Object, e As EventArgs) Handles REPORTButton.Click
        My.Settings.ReportCategory = "DrCode Engine"
        ReportForm.Show()
    End Sub

    Private Sub EXITButton_Click(sender As Object, e As EventArgs) Handles EXITButton.Click
        Me.Hide()
    End Sub

    Private Sub LinkBAND64_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkBAND64.LinkClicked
        MessageBox.Show("We are making the BAND64 site. Please wait...", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub LinkMASTERkreatif_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkMASTERkreatif.LinkClicked
        Process.Start("http://www.masterkreatif.com")
    End Sub

    Private Sub AbtButton_Click(sender As Object, e As EventArgs) Handles AbtButton.Click
        MessageBox.Show("We are making the DrCode site. Please wait...", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ChkUpdate_Click(sender As Object, e As EventArgs) Handles ChkUpdate.Click
        MessageBox.Show("We are developing the Checking Update. Please wait...", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class