Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports DrCode.Synthesia.DrCode
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

    Public Sub WriteIni(ByVal iniFileName As String, ByVal Section As String, ByVal ParamName As String, ByVal ParamVal As String)
        Dim Result As Integer = WritePrivateProfileString(Section, ParamName, ParamVal, iniFileName)
    End Sub

    Public Function ReadIni(ByVal IniFileName As String, ByVal Section As String, ByVal ParamName As String, ByVal ParamDefault As String) As String
        Dim ParamVal As String = Space$(1024)
        Dim LenParamVal As Long = GetPrivateProfileString(Section, ParamName, ParamDefault, ParamVal, Len(ParamVal), IniFileName)
        ReadIni = Left$(ParamVal, LenParamVal)
    End Function
End Module
Module Module1
    Sub Main()
        '-------------------------
        '-----SETTINGS INI-----
        '-------------------------
        'st_synX = Synthesia_X's Path. [synX_settings, String, Default]
        'CrEG =  Crack Engine. [synX_settings, Integer, 0x1]
        'cr_alg = Crack Algorithm. [synX_settings, Integer, 1x0]
        'ChkUpdate = Check if Synthesia_X has newer version than current version. [synX_settings, Boolean, True]
        'ExCode = Exit Console after execute Crack Code. [synX_settings, Boolean, True]
        'ConCh = Is Saved? [variable, Boolean, True]

        Dim iniFile = My.Application.Info.DirectoryPath + "\settings.ini"
        Dim Section = "synX_settings"
        Dim cr_alg = ReadIni(iniFile, Section, "cr_alg", "")
        '1x0 - Default Setting (Crack Synthesia > Execute it)
        '1x1 - Execute Synthesia (Execute Synthesia > Crack it > Execute it again)
        '1x2 - Crack Synthesia Only.
        '1x3 - Execute Synthesia Only.

        Try
            Dim syncr As String = My.Computer.FileSystem.SpecialDirectories.Temp + "\synthesia.x-patch.exe"
            Dim syn_dir As String = "C:\Program Files (x86)\Synthesia\Synthesia.exe"
            'This is my first console application. it looks amazing. isn't it? lol
            'even it's hacking tool!

            '-Console Settings
            Console.Title = "Synthesia_X " & My.Application.Info.Version.ToString
            Console.WriteLine("Synthesia_X By Band64, MASTERkreatif. & Thank you for using Synthesia_X! :D")
            Console.WriteLine()

            '-Check Variable Settings
            If ReadIni(iniFile, Section, "AdvInfo", "") = "True" Then
                Console.WriteLine("-Settings Information")

                Console.WriteLine("st_synX = " & ReadIni(iniFile, Section, "st_synX", ""))
                If ReadIni(iniFile, Section, "st_synX", "") = "Default" Then
                    Console.WriteLine(">> You have Synthesia_X in " & Application.StartupPath + "\Synthesia_X.exe")
                Else
                    Console.WriteLine(">> You have Synthesia_X in " & ReadIni(iniFile, Section, "st_synX", ""))
                End If

                Console.Write("CrEG = " & ReadIni(iniFile, Section, "CrEG", ""))
                If ReadIni(iniFile, Section, "CrEG", "") = "0x0" Then
                    Console.WriteLine(" (InPath Engine)")
                ElseIf ReadIni(iniFile, Section, "CrEG", "") = "0x1" Then
                    Console.WriteLine(" (InPr Engine)")
                ElseIf ReadIni(iniFile, Section, "CrEG", "") = "0x2" Then
                    Console.WriteLine(" (DrCode Engine)")
                End If

                Console.Write("cr_alg = " & ReadIni(iniFile, Section, "cr_alg", ""))
                If ReadIni(iniFile, Section, "cr_alg", "") = "1x0" Then
                    Console.WriteLine(" (CnR Algorithm)")
                ElseIf ReadIni(iniFile, Section, "cr_alg", "") = "1x1" Then
                    Console.WriteLine(" (RCnR Algorithm)")
                ElseIf ReadIni(iniFile, Section, "cr_alg", "") = "1x2" Then
                    Console.WriteLine()
                End If

                Console.WriteLine("ChkUpdate = " & ReadIni(iniFile, Section, "ChkUpdate", ""))
                Console.WriteLine("ExCode = " & ReadIni(iniFile, Section, "ExCode", ""))
                Console.WriteLine("AdvInfo = " & ReadIni(iniFile, Section, "AdvInfo", ""))
                Console.Write("CMDCode = " & ReadIni(iniFile, Section, "CMDCode", ""))

                If ReadIni(iniFile, Section, "CMDCode", "") = "/def" Then
                    Console.WriteLine(" (Warranty)")
                Else
                    Console.WriteLine(" (Not Warranty)")
                End If
            End If

            If ReadIni(iniFile, Section, "ChkUpdate", "") = "True" Then
                If My.Settings.Version > My.Application.Info.Version.ToString Then
                    Console.WriteLine("Check Update - You can update Synthesia_X " & My.Settings.Version & " Version!")
                    Console.WriteLine("Tip: You can download Synthesia_X Latest Version on BAND64's Tool Config.")
                ElseIf My.Settings.Version = My.Application.Info.Version.ToString Then
                    Console.WriteLine("Check Update - You are using Synthesia_X Latest Version!")
                ElseIf My.Settings.Version < My.Application.Info.Version.ToString Then
                    Console.WriteLine("Check Update - You are using Synthesia_X Test Version!!")
                End If
            End If

            If ReadIni(iniFile, Section, "CrEG", "") = "0x0" Then
                If File.Exists("C:\Program Files (x86)\Synthesia\Synthesia.exe") Then
                    If File.Exists("synthesia.x-patch.exe") Then
                        Console.WriteLine()
                        Console.WriteLine("-Command Line")
                        Process.Start("synthesia.x-patch.exe")
                    Else
                        Console.WriteLine(Date.Now.ToString("tt hh:mm:ss") &
                        " - Error! Synthesia Crack doesn't exist. (File: " & My.Application.Info.DirectoryPath() & ")")
                        Console.ReadLine()
                    End If
                End If
            End If

            If ReadIni(iniFile, Section, "CrEG", "") = "0x1" Then 'InPr (0x1) Algorithm
                If File.Exists("C:\Program Files (x86)\Synthesia\Synthesia.exe") Then

                    '-Console Command Line!
                    If cr_alg = "1x0" Then
                        Console.WriteLine()
                        Console.WriteLine("-Command Line")
                    ElseIf cr_alg = "1x1" Then
                        Console.WriteLine()
                        Console.WriteLine("-Command Line")
                    ElseIf cr_alg = "1x2" Then
                        Console.WriteLine()
                        Console.WriteLine("-Command Line")
                    End If

                    If cr_alg = "1x0" Then
                        Console.WriteLine(Date.Now.ToString("tt hh:mm:ss") & " - You can use Synthesia crack after click Patch Button.")
                    ElseIf cr_alg = "1x1" Then
                        Console.WriteLine(Date.Now.ToString("tt hh:mm:ss") & " - You can use Synthesia crack after execute Synthesia.")
                    ElseIf cr_alg = "1x2" Then
                        Console.WriteLine(Date.Now.ToString("tt hh:mm:ss") & " - You can use Synthesia crack after click Patch Button.")
                    ElseIf cr_alg = "1x3" Then
                        Console.WriteLine(Date.Now.ToString("tt hh:mm:ss") & " - You can use Synthesia right now.")
                    End If

                    '-Patch Synthesia Crack / Run Synthesia
                    If cr_alg = "1x0" Then
                        File.WriteAllBytes(syncr, My.Resources.synthesia_x_patch)
                        Process.Start(syncr).WaitForExit()
                        Process.Start(syn_dir)
                        Console.WriteLine(Date.Now.ToString("tt hh:mm:ss") & " - Synthesia_X will close by itself.")
                    ElseIf cr_alg = "1x1" Then
                        Console.WriteLine(Date.Now.ToString("tt hh:mm:ss") & " - Please Exit Synthesia after excute it.")
                        File.WriteAllBytes(syncr, My.Resources.synthesia_x_patch)
                        Process.Start(syn_dir).WaitForExit()
                        Console.WriteLine(Date.Now.ToString("tt hh:mm:ss") & " - Please Click Patch Button.")
                        Process.Start(syncr).WaitForExit()
                        Process.Start(syn_dir)
                        Console.WriteLine(Date.Now.ToString("tt hh:mm:ss") & " - Synthesia_X will close by itself.")
                    ElseIf cr_alg = "1x2" Then
                        File.WriteAllBytes(syncr, My.Resources.synthesia_x_patch)
                        Process.Start(syncr)
                        Console.WriteLine(Date.Now.ToString("tt hh:mm:ss") & " - Synthesia_X will close by itself.")
                    ElseIf cr_alg = "1x3" Then
                        Process.Start(syn_dir)
                        Console.WriteLine(Date.Now.ToString("tt hh:mm:ss") & " - Synthesia_X will close by itself.")
                    End If
                Else
                    Console.WriteLine(Date.Now.ToString("tt hh:mm:ss") &
                                  " - Error! Synthesia doesn't exist. (File: " & syn_dir & ")") 'doesn't exist Error.
                    Console.ReadLine()
                End If
            End If

            If ReadIni(iniFile, Section, "CrEG", "") = "0x2" Then 'DrCode (0x2) Algorithm
                If cr_alg = "1x0" Then
                    Console.WriteLine()
                    Console.WriteLine("-Command Line")
                    If ReadIni(iniFile, Section, "AdvInfo", "") = "True" Then
                        SetCrack("0x0", True)
                    Else SetCrack("0x0", False)
                    End If
                    EditHex("C:\Users\SAMSUNG\Downloads\Workspace\Hello, World!.txt", "C:\Users\SAMSUNG\Downloads\Workspace\Hello, World!_Patched.txt", "6F", "6E", True)
                    Threading.Thread.Sleep(500)
                    Process.Start(syn_dir)
                    Console.WriteLine(Date.Now.ToString("tt hh:mm:ss") & " - Synthesia_X will close by itself.")
                ElseIf cr_alg = "1x1" Then
                    Console.WriteLine()
                    Console.WriteLine("-Command Line")
                    Console.WriteLine(Date.Now.ToString("tt hh:mm:ss") & " - Please Exit Synthesia after excute it.")
                    Process.Start(syn_dir).WaitForExit()
                    If ReadIni(iniFile, Section, "AdvInfo", "") = "True" Then
                        SetCrack("0x0", True)
                    Else SetCrack("0x0", False)
                    End If
                    Threading.Thread.Sleep(500)
                    Process.Start(syn_dir)
                    Console.WriteLine(Date.Now.ToString("tt hh:mm:ss") & " - Synthesia_X will close by itself.")
                ElseIf cr_alg = "1x2" Then
                    Console.WriteLine()
                    Console.WriteLine("-Command Line")
                    If ReadIni(iniFile, Section, "AdvInfo", "") = "True" Then
                        SetCrack("0x0", True)
                    Else SetCrack("0x0", False)
                    End If
                    Console.WriteLine(Date.Now.ToString("tt hh:mm:ss") & " - Synthesia_X will close by itself.")
                ElseIf cr_alg = "1x3" Then
                    Process.Start(syn_dir)
                    Console.WriteLine(Date.Now.ToString("tt hh:mm:ss") & " - Synthesia_X will close by itself.")
                End If
            End If

            If ReadIni(iniFile, Section, "ExCode", "") = "False" Then
                Console.ReadLine()
            End If

        Catch ex As Exception 'Exception
            If ReadIni(iniFile, Section, "AdvInfo", "") = "True" Then
                Console.WriteLine(Date.Now.ToString("tt hh:mm:ss") & " - Error! (" & ex.HResult & ")")
                Console.WriteLine("Error Message: " & ex.Message)
                Console.WriteLine(ex.StackTrace)
                Console.WriteLine()
                Console.WriteLine(ex.TargetSite.ToString & " + " & ex.Source)
                Console.ReadLine()
            Else
                Console.WriteLine(Date.Now.ToString("tt hh:mm:ss") & " - Error! (" & ex.HResult & ")")
                Console.WriteLine("Error Message: " & ex.Message)
                Console.ReadLine()
            End If
        End Try
    End Sub
End Module
