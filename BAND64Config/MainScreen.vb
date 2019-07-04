Public Class MainScreen
    Private Sub MainScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VerInf.Text = My.Application.Info.Version.ToString
        VerInf.Left = 753
        Time.Enabled = True

        'TextInf.Text = "Starting..."
        'TextInf.Left = 373

    End Sub

    Private Sub Time_Tick(sender As Object, e As EventArgs) Handles Time.Tick
        If Not Prog.Value = Prog.Maximum Then
            Prog.Value = Prog.Value + 10
        Else
            Time.Enabled = False
            TextInf.Text = "Starting... Please Wait"
            TextInf.Left = 307
        End If
    End Sub
End Class