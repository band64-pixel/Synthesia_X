Imports System.IO
Public Class Synthesia_XC
    Dim iniFile = Application.StartupPath + "\settings.ini"
    Dim Section = "synX_settings"
    Dim st_synXdir As String = ReadIni(iniFile, Section, "st_synX", "")
    Private Sub RUNButton_Click(sender As Object, e As EventArgs) Handles RUNButton.Click
        If st_synXdir = "Default" Then
            If File.Exists(Application.StartupPath + "\Synthesia_X.exe") Then
                Process.Start(Application.StartupPath + "\Synthesia_X.exe")
            Else
                MessageBox.Show("Error: Synthesia_X doesn't exists in this folder." & vbNewLine & vbNewLine &
                                "Folder: " & Application.StartupPath, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            If File.Exists(st_synXdir) Then
                Process.Start(st_synXdir)
            Else
                MessageBox.Show("Error: Synthesia_X doesn't exists in this folder." & vbNewLine & vbNewLine &
                                "Folder: " & st_synXdir, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub EXITButton_Click(sender As Object, e As EventArgs) Handles EXITButton.Click
        Me.Hide()
    End Sub
    Private Sub REPORTButton_Click(sender As Object, e As EventArgs) Handles REPORTButton.Click
        My.Settings.ReportCategory = "Synthesia_X"
        ReportForm.Show()
    End Sub

    Private Sub SETTINGButton_Click(sender As Object, e As EventArgs) Handles SETTINGButton.Click
        Settings.Show()
        ReadIni(iniFile, Section, "st_synX", "")

        ReadIni(iniFile, Section, "cr_alg", "")
        '0x0 - Default Setting (Crack Synthesia > Execute it)
        '0x1 - Execute Synthesia (Execute Synthesia > Crack it > Execute it again)
        '0x2 - Crack Synthesia Only.
        '0x3 - Execute Synthesia Only.

    End Sub

    Private Sub LinkBAND64_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkBAND64.LinkClicked
        MessageBox.Show("We are making the BAND64 site. Please wait...", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub INFOButton_Click(sender As Object, e As EventArgs) Handles INFOButton.Click
        Synthesia_XInfo.Show()
    End Sub

    Private Sub Synthesia_XC_Exit(sender As Object, e As EventArgs) Handles MyBase.Leave
        EXITButton_Click(Nothing, Nothing)
    End Sub

    Private Sub LinkMASTERkreatif_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkMASTERkreatif.LinkClicked
        Process.Start("http://www.masterkreatif.com")
    End Sub
End Class