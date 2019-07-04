Imports System.IO

Module modINI
    'ini File
    Private Declare Unicode Function WritePrivateProfileString Lib "kernel32" _
    Alias "WritePrivateProfileStringW" (ByVal lpApplicationName As String,
    ByVal lpKeyName As String, ByVal lpString As String,
    ByVal lpFileName As String) As Int32

    Private Declare Unicode Function GetPrivateProfileString Lib "kernel32" _
    Alias "GetPrivateProfileStringW" (ByVal lpApplicationName As String,
    ByVal lpKeyName As String, ByVal lpDefault As String,
    ByVal lpReturnedString As String, ByVal nSize As Int32,
    ByVal lpFileName As String) As Int32

    Public Sub writeIni(ByVal iniFileName As String, ByVal Section As String, ByVal ParamName As String, ByVal ParamVal As String)
        Dim Result As Integer = WritePrivateProfileString(Section, ParamName, ParamVal, iniFileName)
    End Sub

    Public Function ReadIni(ByVal IniFileName As String, ByVal Section As String, ByVal ParamName As String, ByVal ParamDefault As String) As String
        Dim ParamVal As String = Space$(1024)
        Dim LenParamVal As Long = GetPrivateProfileString(Section, ParamName, ParamDefault, ParamVal, Len(ParamVal), IniFileName)
        ReadIni = Left$(ParamVal, LenParamVal)
    End Function
End Module
Public Class BAND64Config
    Dim iniFile = Application.StartupPath + "\settings.ini"
    Dim Section = "synX_settings"

    Private Sub ToolCon_Click(sender As Object, e As EventArgs) Handles ToolCon.Click
        Dim st_synXdir As String = ReadIni(iniFile, Section, "st_synX", "")

        If Not Comb.SelectedItem = Nothing Then
            If Comb.SelectedItem.ToString = "Synthesia_X" Then
                If File.Exists("Synthesia_X.exe") Then
                    If File.Exists(Application.StartupPath + "\settings.ini") Then
                        Synthesia_XC.Show()
                    Else
                        MessageBox.Show("Error: Settings File doesn't exists in this folder." & vbNewLine & vbNewLine & "Path: " & Application.StartupPath & "\settings.ini", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                        If st_synXdir = "Default" Then
                        MessageBox.Show("Error: Synthesia_X doesn't exists in this folder." & vbNewLine & vbNewLine & "Folder: " & Application.StartupPath, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        MessageBox.Show("Error: Synthesia_X doesn't exists in this folder." & vbNewLine & vbNewLine & "Folder: " & st_synXdir, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            End If

            If Comb.SelectedItem.ToString = "DrCode Engine" Then
                If File.Exists(Application.StartupPath + "\DrCode.dll") Then
                    If File.Exists(Application.StartupPath + "\settings.ini") Then
                        DrCodeInfo.Show()
                    Else
                        MessageBox.Show("Error: Settings File doesn't exists in this folder." & vbNewLine & vbNewLine & "Path: " & Application.StartupPath & "\settings.ini", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Error: DrCode Engine doesn't exists in this folder." & vbNewLine & vbNewLine & "Path: " & Application.StartupPath & "\DrCode.dll", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

            If Comb.SelectedItem.ToString = "BAND64's Tool Config" Then
                If File.Exists(Application.StartupPath + "\settings.ini") Then
                    ToolConfigC.Show()
                Else
                    MessageBox.Show("Error: Settings File doesn't exists in this folder." & vbNewLine & vbNewLine & "Path: " & Application.StartupPath & "\settings.ini", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            MessageBox.Show("Error: You didn't select anything.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BAND64Config_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If UBound(Process.GetProcessesByName(Process.GetCurrentProcess.ProcessName)) > 0 Then 'Check Program duplication
            MessageBox.Show("Error!" & vbNewLine & "Synthesia_X is already running :(",
                            Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End If

        If Not ReadIni(iniFile, Section, "CMDCode", "") = "/def" Then 'Check Bypass Warranty
            If My.Settings.synX_cmdCodeW = "NOTREAD" Then
                My.Settings.synX_cmdCodeW = "READ" 'You cheated! :(
            End If
        End If

        My.Settings.ReportCategory = Nothing 'RESET the Report Category Setting.
    End Sub
End Class
