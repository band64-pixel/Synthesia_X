Imports System.IO
Imports System.Text

Public Class Settings
    Dim Starto As Boolean = False
    Dim Tmp As String = My.Computer.FileSystem.SpecialDirectories.Temp
    Dim userRoot = Environment.GetEnvironmentVariable("USERPROFILE")

    Dim iniFile = My.Application.Info.DirectoryPath + "\settings.ini"
    Dim Section = "synX_settings"
    Private Sub St_synX_selButton_Click(sender As Object, e As EventArgs) Handles st_synX_selButton.Click
        If OpenFileDialog_X.ShowDialog = DialogResult.OK Then
            st_synX_Text.Text = OpenFileDialog_X.FileName
        End If
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Try
            '---Comand Code!---
            If Not cmdText.Text = "/def" Then 'Writing ini | Command Code (Warning!)
                If My.Settings.synX_cmdCodeW = "NOTREAD" Then
                    If MessageBox.Show("Are you sure about using Command Code?",
                                       Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        My.Settings.synX_cmdCodeW = "READ"
                        writeIni(iniFile, Section, "CMDCode", cmdText.Text)
                        MessageBox.Show("Enabled CMDCode! If you don't know how to use it, Type '/?' or '/help' to help.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ElseIf DialogResult.No Then
                        cmdText.Text = "/def"
                    End If
                End If
            End If

            If cmdText.Text = "/help" Then 'Command Code | Show Help
                Dim cmdh As String = Tmp + "\syn_CMDCode-help.txt"
                File.WriteAllText(cmdh, My.Resources.CMDCode_help)
                MessageBox.Show(File.ReadAllText(cmdh), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            If cmdText.Text = "/?" Then 'Command Code | Show Help
                Dim cmdh As String = Tmp + "\syn_CMDCode-help.txt"
                File.WriteAllText(cmdh, My.Resources.CMDCode_help)
                MessageBox.Show(File.ReadAllText(cmdh), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            If My.Settings.synX_cmdCodeW = "READ" Then 'Command Code | Reset To Default, synX_cmdCode = NOTREAD
                If cmdText.Text = "/rtd /read" Then
                    If MessageBox.Show("Are you sure about Reset the Warranty To Default?" & vbNewLine &
                                   "It will reset the Command Code too.", Me.Text, MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question) = DialogResult.Yes Then
                        My.Settings.synX_cmdCodeW = "NOTREAD"
                        cmdText.Text = "/def"
                        writeIni(iniFile, Section, "CMDCode", "/def")
                    End If
                End If
            End If

            If cmdText.Text = "/rtd /set" Then 'Command Code | Reset To Default, All
                If MessageBox.Show("Are you sure about Reset the All Settings To Default?" & vbNewLine &
                                       "It will reset the Command Code too.", Me.Text, MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question) = DialogResult.Yes Then
                    st_synX_Text.Text = "Default" 'Synthesia_X Path
                    CrEG_InPath.Checked = False 'Crack Engine (Current: InPr) 
                    CrEG_InPr.Checked = True
                    CrEG_DrCode.Checked = False
                    Cralg1.Checked = True 'Crack Algorithm
                    Cralg2.Checked = False
                    Cralg3.Checked = False
                    Cralg4.Checked = False
                    Crarg1.Checked = True
                    Crarg2.Checked = False
                    ChkUpdate.Checked = True
                    ExCode.Checked = True
                    AdvInfo.Checked = False
                    cmdText.Text = "/def"

                    writeIni(iniFile, Section, "st_synX", "Default")
                    writeIni(iniFile, Section, "CrEG", "0x2")
                    writeIni(iniFile, Section, "cr_alg", "1x0")
                    writeIni(iniFile, Section, "cr_arg", "2x0")
                    writeIni(iniFile, Section, "ChkUpdate", "True")
                    writeIni(iniFile, Section, "ExCode", "True")
                    writeIni(iniFile, Section, "AdvInfo", "True")
                    writeIni(iniFile, Section, "CMDCode", "/def")
                    My.Settings.synX_cmdCodeW = "NOTREAD"

                    If File.Exists(Tmp + "\syn_Synthesia.zip") Then File.Delete(Tmp + "\syn_Synthesia.zip")
                    If File.Exists(Tmp + "\syn_Synthesia.exe") Then File.Delete(Tmp + "\syn_Synthesia.exe")
                    If File.Exists(Tmp + "\syn_Synthesia.xml") Then File.Delete(Tmp + "\syn_Synthesia.xml")
                    If File.Exists(Tmp + "\syn_CMDCode-help.txt") Then File.Delete(Tmp + "\syn_CMDCode-help.txt")
                    If File.Exists("C:\Program Files (x86)\Synthesia\Synthesia.exe.bak") Then File.Delete("C:\Program Files (x86)\Synthesia\Synthesia.exe.bak")
                    If File.Exists(userRoot + "\Roaming\Synthesia\settings.xml.bak") Then File.Delete(userRoot + "\Roaming\Synthesia\settings.xml.bak")
                End If
            End If

            If cmdText.Text = "/set /bak" Then 'Command Code | Backup Settings
                If SaveFileDialog_set.ShowDialog = DialogResult.OK Then
                    Dim byt As Byte() = Encoding.UTF8.GetBytes(File.ReadAllText(Application.StartupPath + "\settings.ini"))
                    Dim B64F As String = Convert.ToBase64String(byt)
                    Dim fs As FileStream = IO.File.Create(SaveFileDialog_set.FileName)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(B64F)
                    fs.Write(info, 0, info.Length)
                    fs.Close()
                End If
            End If

            If cmdText.Text = "/set /restore" Then 'Command Code | Restore Settings
                If OpenFileDialog_set.ShowDialog = DialogResult.OK Then
                    File.WriteAllBytes(Application.StartupPath + "\settings.ini",
                                       Convert.FromBase64String(File.ReadAllText(OpenFileDialog_set.FileName)))
                    st_synX_Text.Text = ReadIni(iniFile, Section, "st_synX", "")
                    If ReadIni(iniFile, Section, "CrEG", "") = "0x0" Then
                        CrEG_InPath.Checked = True
                        CrEG_InPr.Checked = False
                        CrEG_DrCode.Checked = False
                    ElseIf ReadIni(iniFile, Section, "CrEG", "") = "0x1" Then
                        CrEG_InPath.Checked = False
                        CrEG_InPr.Checked = True
                        CrEG_DrCode.Checked = False
                    ElseIf ReadIni(iniFile, Section, "CrEG", "") = "0x2" Then
                        CrEG_InPath.Checked = False
                        CrEG_InPr.Checked = False
                        CrEG_DrCode.Checked = True
                    End If
                    If ReadIni(iniFile, Section, "cr_alg", "") = "1x0" Then
                        Cralg1.Checked = True
                        Cralg2.Checked = False
                        Cralg3.Checked = False
                        Cralg4.Checked = False
                    ElseIf ReadIni(iniFile, Section, "cr_alg", "") = "1x1" Then
                        Cralg1.Checked = False
                        Cralg2.Checked = True
                        Cralg3.Checked = False
                        Cralg4.Checked = False
                    ElseIf ReadIni(iniFile, Section, "cr_alg", "") = "1x2" Then
                        Cralg1.Checked = False
                        Cralg2.Checked = False
                        Cralg3.Checked = True
                        Cralg4.Checked = False
                    ElseIf ReadIni(iniFile, Section, "cr_alg", "") = "1x3" Then
                        Cralg1.Checked = False
                        Cralg2.Checked = False
                        Cralg3.Checked = False
                        Cralg4.Checked = True
                    End If
                    If ReadIni(iniFile, Section, "cr_arg", "") = "2x0" Then
                        Crarg1.Checked = True
                        Crarg2.Checked = False
                    ElseIf ReadIni(iniFile, Section, "cr_arg", "") = "2x1" Then
                        Crarg1.Checked = False
                        Crarg2.Checked = True
                    End If
                    If ReadIni(iniFile, Section, "ChkUpdate", "") = "True" Then
                        ChkUpdate.Checked = True
                    Else
                        ChkUpdate.Checked = False
                    End If
                    If ReadIni(iniFile, Section, "ExCode", "") = "True" Then
                        ExCode.Checked = True
                    Else
                        ExCode.Checked = False
                    End If
                    cmdText.Text = ReadIni(iniFile, Section, "CMDCode", "")
                End If
            End If

            If cmdText.Text = "/set /tmp" Then 'Command Code | Remove the Tempoary Files | It may fix some errors.
                If MessageBox.Show("Are you sure about Remove the Tempoary Files?" & vbNewLine &
                                       "It may fix some errors.", Me.Text, MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question) = DialogResult.Yes Then
                    If File.Exists(Tmp + "\syn_Synthesia.zip") Then File.Delete(Tmp + "\syn_Synthesia.zip")
                    If File.Exists(Tmp + "\syn_Synthesia.exe") Then File.Delete(Tmp + "\syn_Synthesia.exe")
                    If File.Exists(Tmp + "\syn_Synthesia.xml") Then File.Delete(Tmp + "\syn_Synthesia.xml")
                    If File.Exists(Tmp + "\syn_CMDCode-help.txt") Then File.Delete(Tmp + "\syn_CMDCode-help.txt")
                    If File.Exists("C:\Program Files (x86)\Synthesia\Synthesia.exe.bak") Then File.Delete("C:\Program Files (x86)\Synthesia\Synthesia.exe.bak")
                    If File.Exists(userRoot + "\Roaming\Synthesia\settings.xml.bak") Then File.Delete(userRoot + "\Roaming\Synthesia\settings.xml.bak")
                End If
            End If

            writeIni(iniFile, Section, "st_synX", st_synX_Text.Text) 'Writing ini | Synthesia_X Path

            If CrEG_InPath.Checked = True Then 'Writing ini | Crack Engine
                writeIni(iniFile, Section, "CrEG", "0x0")
            ElseIf CrEG_InPr.Checked = True Then
                writeIni(iniFile, Section, "CrEG", "0x1")
            ElseIf CrEG_DrCode.Checked = True Then
                writeIni(iniFile, Section, "CrEG", "0x2")
            End If

            If Cralg1.Checked = True Then 'Writing ini | Crack Algorithm
                writeIni(iniFile, Section, "cr_alg", "1x0")
            ElseIf Cralg2.Checked = True Then
                writeIni(iniFile, Section, "cr_alg", "1x1")
            ElseIf Cralg3.Checked = True Then
                writeIni(iniFile, Section, "cr_alg", "1x2")
            ElseIf Cralg4.Checked = True Then
                writeIni(iniFile, Section, "cr_alg", "1x3")
            End If

            If Crarg1.Checked = True Then
                writeIni(iniFile, Section, "cr_arg", "2x0")
            ElseIf Crarg2.Checked = True Then
                writeIni(iniFile, Section, "cr_arg", "2x1")
            End If

            If ChkUpdate.Checked = True Then 'Writing ini | Check Update
                writeIni(iniFile, Section, "ChkUpdate", "True")
            Else
                writeIni(iniFile, Section, "ChkUpdate", "False")
            End If

            If ExCode.Checked = True Then 'Writing ini | Auto Exit
                writeIni(iniFile, Section, "ExCode", "True")
            Else
                writeIni(iniFile, Section, "ExCode", "False")
            End If

            If AdvInfo.Checked = True Then 'Writing ini | Advanced Information
                writeIni(iniFile, Section, "AdvInfo", "True")
            Else
                writeIni(iniFile, Section, "AdvInfo", "False")
            End If

            MessageBox.Show("Saved Settings!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error!" & vbNewLine & "Error Message: " & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            st_synX_Text.Text = ReadIni(iniFile, Section, "st_synX", "") 'Reading ini | Synthesia_X Path

            If ReadIni(iniFile, Section, "CrEG", "") = "0x0" Then 'Reading ini | Crack Engine
                CrEG_InPath.Checked = True
                CrEG_InPr.Checked = False
                CrEG_DrCode.Checked = False
            ElseIf ReadIni(iniFile, Section, "CrEG", "") = "0x1" Then
                CrEG_InPath.Checked = False
                CrEG_InPr.Checked = True
                CrEG_DrCode.Checked = False
            ElseIf ReadIni(iniFile, Section, "CrEG", "") = "0x2" Then
                CrEG_InPath.Checked = False
                CrEG_InPr.Checked = False
                CrEG_DrCode.Checked = True
            End If

            If ReadIni(iniFile, Section, "cr_alg", "") = "1x0" Then 'Reading ini | Crack Algorithm
                Cralg1.Checked = True
                Cralg2.Checked = False
                Cralg3.Checked = False
                Cralg4.Checked = False
            ElseIf ReadIni(iniFile, Section, "cr_alg", "") = "1x1" Then
                Cralg1.Checked = False
                Cralg2.Checked = True
                Cralg3.Checked = False
                Cralg4.Checked = False
            ElseIf ReadIni(iniFile, Section, "cr_alg", "") = "1x2" Then
                Cralg1.Checked = False
                Cralg2.Checked = False
                Cralg3.Checked = True
                Cralg4.Checked = False
            ElseIf ReadIni(iniFile, Section, "cr_alg", "") = "1x3" Then
                Cralg1.Checked = False
                Cralg2.Checked = False
                Cralg3.Checked = False
                Cralg4.Checked = True
            End If

            If ReadIni(iniFile, Section, "cr_arg", "") = "2x0" Then 'Reading ini | Crack Argument
                Crarg1.Checked = True
                Crarg2.Checked = False
            ElseIf ReadIni(iniFile, Section, "cr_arg", "") = "2x1" Then
                Crarg1.Checked = False
                Crarg2.Checked = True
            End If

            If Not ReadIni(iniFile, Section, "CrEG", "") = "0x2" Then 'Reading ini | Crack Engine, 0x2: Group.Enabled = False
                Cr_argGroup.Enabled = False
            End If

            If ReadIni(iniFile, Section, "CrEG", "") = "0x0" Then 'Reading ini | Crack Engine, 0x0: Group.Enabled = False
                cr_algGroup.Enabled = False
            End If

            If ReadIni(iniFile, Section, "ChkUpdate", "") = "True" Then 'Reading ini | Check Update
                ChkUpdate.Checked = True
            Else
                ChkUpdate.Checked = False
            End If

            If ReadIni(iniFile, Section, "ExCode", "") = "True" Then 'Reading ini | Auto Exit
                ExCode.Checked = True
            Else
                ExCode.Checked = False
            End If

            If ReadIni(iniFile, Section, "AdvInfo", "") = "True" Then 'Reading ini | Advanced Information
                AdvInfo.Checked = True
            Else
                AdvInfo.Checked = False
            End If

            cmdText.Text = ReadIni(iniFile, Section, "CMDCode", "") 'Reading ini | Command Code

            Starto = True

        Catch ex As Exception
            MessageBox.Show(Date.Now.ToString("tt hh:mm:ss") & " - Error! " & ex.Message,
                            Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AdvInfo_CheckedChanged(sender As Object, e As EventArgs) Handles AdvInfo.CheckedChanged
        If Starto = True Then
            If AdvInfo.Checked = True Then
                MessageBox.Show("This mode is for developer." & vbNewLine & "Synthesia_X will show you Values of Settings.",
                                Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub CrEG_InPath_CheckedChanged(sender As Object, e As EventArgs) Handles CrEG_InPath.CheckedChanged
        If CrEG_InPath.Checked = True Then
            MessageBox.Show("This Crack Engine is old version." & vbNewLine &
                            "You can't use Crack Algorithm! Even, you have to need Synthesia Crack Program!" & vbNewLine &
                            "Otherwise, Synthesia_X will crashs it.",
                            Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            If cr_algGroup.Enabled = True Then cr_algGroup.Enabled = False
            If Cr_argGroup.Enabled = True Then Cr_argGroup.Enabled = False
        End If
    End Sub

    Private Sub CrEG_DrCode_CheckedChanged(sender As Object, e As EventArgs) Handles CrEG_DrCode.CheckedChanged
        If CrEG_DrCode.Checked = True Then
            If cr_algGroup.Enabled = False Then cr_algGroup.Enabled = True
            If Cr_argGroup.Enabled = False Then Cr_argGroup.Enabled = True
        End If
    End Sub

    Private Sub CrEG_InPr_CheckedChanged(sender As Object, e As EventArgs) Handles CrEG_InPr.CheckedChanged
        If CrEG_InPr.Checked = True Then
            If cr_algGroup.Enabled = False Then cr_algGroup.Enabled = True
            If Cr_argGroup.Enabled = True Then Cr_argGroup.Enabled = False
        End If
    End Sub
End Class