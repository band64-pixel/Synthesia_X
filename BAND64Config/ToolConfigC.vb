Public Class ToolConfigC
    Private Sub REPORTButton_Click(sender As Object, e As EventArgs) Handles REPORTButton.Click
        My.Settings.ReportCategory = "BAND64's Tool Config"
        ReportForm.Show()
    End Sub

    Private Sub EXITButton_Click(sender As Object, e As EventArgs) Handles EXITButton.Click
        Me.Hide()
    End Sub

    Private Sub INFOButton_Click(sender As Object, e As EventArgs) Handles INFOButton.Click
        ToolConfigInfo.Show()
    End Sub

    Private Sub LinkBAND64_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkBAND64.LinkClicked
        MessageBox.Show("We are making the BAND64 site. Please wait...", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class