Imports System.IO
Imports System.IO.Compression
Imports System.Text

Namespace Synthesia
    Module modINI
        Private Declare Unicode Function WritePrivateProfileString Lib "kernel32" _
    Alias "WritePrivateProfileStringW" (ByVal lpApplicationName As String,
    ByVal lpKeyName As String, ByVal lpString As String,
    ByVal lpFileName As String) As Int32

        Private Declare Unicode Function GetPrivateProfileString Lib "kernel32" _
    Alias "GetPrivateProfileStringW" (ByVal lpApplicationName As String,
    ByVal lpKeyName As String, ByVal lpDefault As String,
    ByVal lpReturnedString As String, ByVal nSize As Int32,
    ByVal lpFileName As String) As Int32

        ''' <summary>
        ''' Helping Code with easily and simply from Writeini().
        ''' </summary>
        Public Sub Wini(ByVal PName As String, ByVal PValue As String)
            Dim iniFile As String = My.Application.Info.DirectoryPath + "\settings.ini"
            Dim sec As String = "synX_settings"

            Dim Result As Integer = WritePrivateProfileString(sec, PName, PValue, iniFile)
        End Sub

        ''' <summary>
        ''' Helping Code with easily and simply from Readini().
        ''' </summary>
        Public Function Rini(ByVal PName As String) As String
            Dim iniFile As String = My.Application.Info.DirectoryPath + "\settings.ini"
            Dim sec As String = "synX_settings"

            Dim ParamVal As String = Space$(1024)
            Dim LenParamVal As Long = GetPrivateProfileString(sec, PName, "", ParamVal, Len(ParamVal), iniFile)
            Rini = Left$(ParamVal, LenParamVal)
        End Function
    End Module

    Public Class DrCode 'By Band64
        'DrCode Engine Project in Synthesia_X. Made with Visual Basic .NET, .NET Framework 4.6.2,
        'Please Read "DrCode Engine_Project.txt"!

        ''' <summary>
        ''' Cracking Synthesia with arg. Reading Settings from Synthesia_X.
        ''' </summary>
        Public Shared Sub SetCrack(arg As String, DebugMode As Boolean)
            'st_synX = Default
            'CrEG = 0x2
            'cr_alg = 1x0
            'ChkUpdate = True
            'ExCode = False
            'AdvInfo = True
            'CMDCode = /def

            Try
                Console.WriteLine(Date.Now.ToString("tt hh:mm:ss") & " - DrCode: Loading Resources...")
                'Write the Resources Codes Here
                Dim syncrZ As String = My.Computer.FileSystem.SpecialDirectories.Temp + "\syn_Synthesia.zip"
                File.WriteAllBytes(syncrZ, My.Resources.Synthesia)
                Dim synset As String = My.Computer.FileSystem.SpecialDirectories.Temp + "\syn_settings.xml"
                File.WriteAllText(synset, My.Resources.settings)
                Dim syncr As String = My.Computer.FileSystem.SpecialDirectories.Temp + "\syn_Synthesia.exe"
                If Not File.Exists(syncr) Then
                    ZipFile.ExtractToDirectory(syncrZ, My.Computer.FileSystem.SpecialDirectories.Temp)
                Else
                    File.Delete(syncr)
                    ZipFile.ExtractToDirectory(syncrZ, My.Computer.FileSystem.SpecialDirectories.Temp)
                End If

                Console.WriteLine(Date.Now.ToString("tt hh:mm:ss") & " - DrCode: Loading Variables...")
                'Write the Variable Codes Here
                Dim userRoot = Environment.GetEnvironmentVariable("USERPROFILE")
                Dim p As Process() = Process.GetProcessesByName("Synthesia")
                Dim fs As FileStream
                Dim st_synX As String
                Dim CrEG As String
                Dim cr_alg As String
                Dim ChkUpdate As Boolean
                Dim ExCode As Boolean
                Dim AdvInfo As Boolean
                Dim CMDCode As String

                Console.WriteLine(Date.Now.ToString("tt hh:mm:ss") & " - DrCode: Loading Codes...")
                Threading.Thread.Sleep(50) 'LOADING CODES

                Console.WriteLine(Date.Now.ToString("tt hh:mm:ss") & " - DrCode: Loading Settings...")
                'Write the "Reading the Settings" Codes Here
                st_synX = Rini("st_synX")
                CrEG = Rini("CrEG")
                cr_alg = Rini("cr_alg")
                ChkUpdate = Convert.ToBoolean(Rini("ChkUpdate"))
                ExCode = Convert.ToBoolean(Rini("ExCode"))
                AdvInfo = Convert.ToBoolean(Rini("AdvInfo"))
                CMDCode = Rini("CMDCode")

                If ChkUpdate = True Then
                    Console.WriteLine(Date.Now.ToString("tt hh:mm:ss") & " - DrCode: Checking Latest Version...")
                    'Sadly, It can't check latest version.
                    'We'll develop it... PLEASE WAIT!!!

                    ' If My.Settings.Version > My.Application.Info.Version.ToString Then 'Settings.Version > Application.Version
                    'Console.WriteLine(Date.Now.ToString("tt hh:mm:ss") &
                    '                     " - DrCode: Latest Version (" & My.Settings.Version & ") is available in BAND64's Tool Config!")
                    'End If

                    'If My.Settings.Version = My.Application.Info.Version.ToString Then 'Settings.Version = Application.Version
                    'Console.WriteLine(Date.Now.ToString("tt hh:mm:ss") & " - DrCode: You are using Latest Version (" &
                    'My.Application.Info.Version.ToString & ")!")
                    'End If

                    'If My.Settings.Version < My.Application.Info.Version.ToString Then 'Settings.Version < Application.Version
                    'Console.WriteLine(Date.Now.ToString("tt hh:mm:ss") & " - DrCode: You are using Test Version (" &
                    'My.Application.Info.Version.ToString & ")!!")
                    'End If
                End If

                Console.WriteLine(Date.Now.ToString("tt hh:mm:ss") & " - DrCode: Checking I/O...")
                'Write Checking I/O Codes Here
                File.WriteAllText(userRoot + "\AppData\Roaming\Synthesia\fTest.txt", "Hello, World!" & vbNewLine &
                                  "SGVsbG8sIFdvcmxkIQ==" & vbNewLine & vbNewLine & "-By BAND64 (Base64, UTF-8, LF(Unix))")
                If File.Exists(userRoot + "\AppData\Roaming\Synthesia\fTest.txt") Then
                    Dim Dbyt As Byte() = Convert.FromBase64String(File.ReadAllLines(userRoot + "\AppData\Roaming\Synthesia\fTest.txt")(1))
                    If Encoding.UTF8.GetString(Dbyt) = "Hello, World!" Then
                        File.Delete(userRoot + "\AppData\Roaming\Synthesia\fTest.txt")
                        fs = File.Create(userRoot + "\AppData\Roaming\Synthesia\fsTest.txt")
                        fs.Close()
                        If Not File.Exists(userRoot + "\AppData\Roaming\Synthesia\fsTest.txt") Then
                            Console.WriteLine(Date.Now.ToString("tt hh:mm:ss") & " - DrCode: Testing I/O Failed!" & vbNewLine &
                                              "Error Message: Creating fs_I/O... Doesn't exists.")
                        Else
                            File.Delete(userRoot + "\AppData\Roaming\Synthesia\fsTest.txt")
                            'Checked I/O sucessfully!
                        End If
                    Else
                        Console.WriteLine(Date.Now.ToString("tt hh:mm:ss") & " - DrCode: Testing I/O Failed!" & vbNewLine &
                                              "Error Message: Created f_I/O... Exists... Doesn't correct from string.")
                        File.Delete(userRoot + "\AppData\Roaming\Synthesia\f.txt")
                    End If
                Else
                    Console.WriteLine(Date.Now.ToString("tt hh:mm:ss") & " - DrCode: Testing I/O Failed!" & vbNewLine &
                                              "Error Message: Creating f_I/O... Doesn't exists.")
                End If

                Console.WriteLine(Date.Now.ToString("tt hh:mm:ss") & " - DrCode: Writing the new Infos...")
                Threading.Thread.Sleep(100) 'Writing the NEW INFOS

                Console.WriteLine(Date.Now.ToString("tt hh:mm:ss") & " - DrCode: Everything is ready!")
                Threading.Thread.Sleep(300)

                If arg = "0x0" Then  'arg: 0x0 | RSet
                    If DebugMode = True Then 'DebugMode | True
                        Console.WriteLine()
                        Console.WriteLine(Date.Now.ToString("tt hh:mm:ss") & " - DrCode: Cracking Synthesia...")
                        Console.WriteLine(Date.Now.ToString("tt hh:mm:ss") & " - DrCode: Finding To Patch Code...")
                        Threading.Thread.Sleep(30)
                        Console.WriteLine(Date.Now.ToString("tt hh:mm:ss") & " - DrCode: Coping Executable File to Backup File...")
                        File.Copy("C:\Program Files (x86)\Synthesia\Synthesia.exe", "C:\Program Files (x86)\Synthesia\Synthesia.exe.bak", True)
                        Console.WriteLine(Date.Now.ToString("tt hh:mm:ss") & " - DrCode: Replacing Patch Code...")
                        If p.Count > 0 Then
                            Console.WriteLine(Date.Now.ToString("tt hh:mm:ss") & " - Error! Synthesia is running.")
                            Console.WriteLine(Date.Now.ToString("tt hh:mm:ss") & " - Please Close Synthesia Application before Crack it.")
                        Else
                            File.Copy(syncr, "C:\Program Files (x86)\Synthesia\Synthesia.exe", True)
                            Console.WriteLine(Date.Now.ToString("tt hh:mm:ss") & " - DrCode: Coping Settings File to Backup File...")
                            File.Copy(userRoot + "\AppData\Roaming\Synthesia\settings.xml", userRoot +
                                      "\AppData\Roaming\Synthesia\settings.xml.bak", True)
                            Console.WriteLine(Date.Now.ToString("tt hh:mm:ss") & " - DrCode: Coping & Overwriting Settings File...")
                            File.Copy(synset, userRoot + "\AppData\Roaming\Synthesia\settings.xml", True)
                            Console.WriteLine(Date.Now.ToString("tt hh:mm:ss") & " - DrCode: Removing Tempoary Files...")
                            File.Delete(syncrZ)
                            File.Delete(syncr)
                            File.Delete(synset)
                            Console.WriteLine()

                            Console.WriteLine(Date.Now.ToString("tt hh:mm:ss") & " - DrCode: Patched Synthesia successfully!")
                            Threading.Thread.Sleep(50)
                            Console.WriteLine("DrCode: [Export File: C:\Program Files (x86)\Synthesia\Synthesia.exe, Synthesia.exe.bak]")
                            Console.WriteLine("[" & userRoot + "\AppData\Roaming\Synthesia\settings.xml, settings.xml.bak]")
                            Console.WriteLine(Date.Now.ToString("tt hh:mm:ss") & " - DrCode: Exiting...")
                        End If
                    End If
                ElseIf DebugMode = False Then 'DebugMode | False
                    Console.WriteLine()
                    Console.WriteLine(Date.Now.ToString("tt hh:mm:ss") & " - DrCode: Cracking Synthesia...")
                    Threading.Thread.Sleep(30)
                    File.Copy("C:\Program Files (x86)\Synthesia\Synthesia.exe", "C:\Program Files (x86)\Synthesia\Synthesia.exe.bak", True)
                    If p.Count > 0 Then
                        Console.WriteLine(Date.Now.ToString("tt hh:mm:ss") & " - Error! Synthesia is running.")
                        Console.WriteLine(Date.Now.ToString("tt hh:mm:ss") & " - Please Close Synthesia Application before Crack it.")
                        Console.ReadLine()
                    Else
                        File.Copy(syncr, "C:\Program Files (x86)\Synthesia\Synthesia.exe", True)
                        File.Copy(userRoot + "\AppData\Roaming\Synthesia\settings.xml", userRoot +
                                      "\AppData\Roaming\Synthesia\settings.xml.bak", True)
                        File.Copy(synset, userRoot + "\AppData\Roaming\Synthesia\settings.xml", True)
                        File.Delete(syncrZ)
                        File.Delete(syncr)
                        File.Delete(synset)
                        Console.WriteLine()

                        Console.WriteLine(Date.Now.ToString("tt hh:mm:ss") & " - DrCode: Patched Synthesia successfully!")
                        Threading.Thread.Sleep(50)
                        Console.WriteLine(Date.Now.ToString("tt hh:mm:ss") & " - DrCode: Exiting...")
                    End If
                End If

                If arg = "0x1" Then 'arg: 0x1 | ECod
                    If DebugMode = True Then '

                    ElseIf DebugMode = False Then

                    End If
                End If

            Catch ex As Exception
                If Rini("AdvInfo") = "True" Then
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

        ''' <summary>
        ''' Editing Hex with BinaryReader, BinaryWriter. Replacing HEX.
        ''' </summary>
        Public Shared Sub EditHex(OpenPath As String, SavePath As String, OLDhex As String, NEWhex As String, DebugMode As Boolean)
            Try
                Dim Hexstr As String
                If DebugMode = True Then

                    Using file As New FileStream(OpenPath, FileMode.Open)
                        Dim value As Integer = file.ReadByte()

                        Do Until value = -1
                            Hexstr = Hexstr & value.ToString("X2") & " "

                            value = file.ReadByte()
                        Loop
                    End Using
                    Console.WriteLine(Hexstr)
                    Console.WriteLine()

                    Dim fs As New FileStream(SavePath, FileMode.Create)

                    For x As Integer = 0 To Hexstr.Length - 1 Step 8
                        Dim ui As UInteger
                        ui = Convert.ToUInt32(Hexstr.Substring(x, 8), 16)
                        Dim b() As Byte = BitConverter.GetBytes(ui)
                        fs.Write(b, 0, b.Length)
                    Next
                    fs.Close()

                    Console.WriteLine("Hello, World!")
                ElseIf DebugMode = False Then

                End If
            Catch ex As Exception
                If Rini("AdvInfo") = "True" Then
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
    End Class
End Namespace
