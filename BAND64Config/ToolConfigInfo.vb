Public Class ToolConfigInfo

    Private Sub LinkBAND64_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkBAND64.LinkClicked
        MessageBox.Show("We are making the BAND64 site. Please wait...", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ToolConfigInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VersionLabel.Text = "Ver. " & My.Application.Info.Version.ToString
    End Sub

    Private Sub AbtButton_Click(sender As Object, e As EventArgs) Handles AbtButton.Click
        MessageBox.Show("We are making the BAND64's Tool Config site. Please wait...", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ChkUpdate_Click(sender As Object, e As EventArgs) Handles ChkUpdate.Click
        MessageBox.Show("We are developing the Checking Update. Please wait...", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class