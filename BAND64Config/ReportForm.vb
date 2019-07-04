Imports System.Net.Mail
Public Class ReportForm
    Dim iniFile = Application.StartupPath + "\settings.ini"
    Dim Section = "synX_settings"
    Dim st_synXdir As String = ReadIni(iniFile, Section, "st_synX", "")
    Private Sub Comb1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Comb1.SelectedIndexChanged
        If Comb1.SelectedItem.ToString = "doesn't exists in the folder." Then
            If My.Settings.ReportCategory = "Synthesia_X" Then
                If st_synXdir = "Default" Then
                    DescBox.Text = "Check if you have Synthesia_X.exe in this folder." & vbNewLine &
                "Directory Path: " & Application.StartupPath
                    Process.Start("explorer.exe", Application.StartupPath)
                Else
                    DescBox.Text = "Check if you have Synthesia_X.exe in this folder." & vbNewLine &
                    "Directory Path: " & st_synXdir
                    Process.Start("explorer.exe", st_synXdir)
                End If
            ElseIf My.Settings.ReportCategory = "DrCode Engine" Then
                DescBox.Text = "Check if you have DrCode.dll in this folder." & vbNewLine &
               "Directory Path: " & Application.StartupPath
                Process.Start("explorer.exe", Application.StartupPath)
            ElseIf My.Settings.ReportCategory = "BAND64's Tool Config" Then
                DescBox.Text = "Check if you have all files in this folder." & vbNewLine &
               "Directory Path: " & Application.StartupPath
                Process.Start("explorer.exe", Application.StartupPath)
            End If
        ElseIf Comb1.SelectedItem.ToString = "Nothing Patched! (InPath, InPr)" Then
            DescBox.Text = "That's OK! If you click exit button, Synthesia_X will patch automatically!" & vbNewLine &
                "If it didn't patch, Report a Bug to me. Please Click ComboBox and Click (Report a Bug)!"
        ElseIf Comb1.SelectedItem.ToString = "I/O Error." Then
            If My.Settings.ReportCategory = "Synthesia_X" Then
                DescBox.Text = "I think The Vachine abort I/O Permission. or it may a bug..?" & vbNewLine &
                "Please Turn off the vachine and Run it as Administrator! if you didn't solve the I/O Error, Please Report a Bug to me."
            ElseIf My.Settings.ReportCategory = "DrCode Engine" Then
                DescBox.Text = "Checking Failed to Creating or Existing FIle. I think The Vachine abort I/O Permission. or it may a bug..?" & vbNewLine &
                "Please Turn off the vachine and Run it as Administrator! if you didn't solve the I/O Error, Please Report a Bug to me."
            End If
        ElseIf Comb1.SelectedItem.ToString = "Report a Bug!" Then
            DescBox.ReadOnly = False
            DescBox.Text = "Click the Send Button when wrote the bug description." & vbNewLine &
                    "If you want to send the attachment, Upload the attachment. Thanks :D"
            DelButton.Enabled = True
            SenButton.Enabled = True
            UplButton.Enabled = True
        End If

    End Sub

    Private Sub SenButton_Click(sender As Object, e As EventArgs) Handles SenButton.Click
        Try
            Dim Smtp As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp.UseDefaultCredentials = False
            Smtp.Credentials = New Net.NetworkCredential("band64user1@gmail.com", "1973seyounhd175071973")
            Smtp.Port = 587
            Smtp.EnableSsl = True
            Smtp.Host = "smtp.gmail.com"
            e_mail = New MailMessage()
            e_mail.From = New MailAddress("band64user1@gmail.com")
            e_mail.To.Add("band64user@gmail.com")
            e_mail.Subject = "Report Bug " & My.Settings.ReportCategory & " From BAND64's Tool Config."
            e_mail.IsBodyHtml = False 'HTML USING.
            e_mail.Body = DescBox.Text
            If Replace(MAIL_ATTACHMENT.Text, " ", "") <> "" Then
                Dim attachment As Attachment
                'ATTACHMENT SEND
                attachment = New Attachment(MAIL_ATTACHMENT.Text)
                e_mail.Attachments.Add(attachment)
            End If
            Smtp.Send(e_mail)
            MessageBox.Show("Sent! Thank you For reporting bug.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch email_error As Exception
            MessageBox.Show(email_error.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UplButton_Click(sender As Object, e As EventArgs) Handles UplButton.Click
        If FileDlg.ShowDialog() = DialogResult.OK Then
            MAIL_ATTACHMENT.Text = FileDlg.FileName
        Else
            MAIL_ATTACHMENT.Text = ""
            Exit Sub
        End If
    End Sub

    Private Sub DelButton_Click(sender As Object, e As EventArgs) Handles DelButton.Click
        DescBox.Text = Nothing
    End Sub

    Private Sub lnkButton_Click(sender As Object, e As EventArgs) Handles lnkButton.Click
        MessageBox.Show("We are making the BAND64 site. Please wait...", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.ReportCategory = "Synthesia_X" Then
            Dim itemstring As New List(Of String) _
    From {"doesn't exists in the folder.", "Nothing Patched! (InPath, InPr)", "I/O Error.", "Report a Bug!"}

            For Each itmstr In itemstring
                Dim itm As New ListViewItem(New String() {itmstr})
                Comb1.Items.Add(itm.Text)
            Next
        ElseIf My.Settings.ReportCategory = "DrCode Engine" Then
            Dim itemstring As New List(Of String) _
    From {"doesn't exists in the folder.", "I/O Error.", "Report a Bug!"}

            For Each itmstr In itemstring
                Dim itm As New ListViewItem(New String() {itmstr})
                Comb1.Items.Add(itm.Text)
            Next
        ElseIf My.Settings.ReportCategory = "BAND64's Tool Config" Then
            Dim itemstring As New List(Of String) _
   From {"doesn't exists in the folder.", "Report a Bug!"}

            For Each itmstr In itemstring
                Dim itm As New ListViewItem(New String() {itmstr})
                Comb1.Items.Add(itm.Text)
            Next
        End If
    End Sub
End Class