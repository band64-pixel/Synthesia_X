﻿'------------------------------------------------------------------------------
' <auto-generated>
'     이 코드는 도구를 사용하여 생성되었습니다.
'     런타임 버전:4.0.30319.42000
'
'     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
'     이러한 변경 내용이 손실됩니다.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    '이 클래스는 ResGen 또는 Visual Studio와 같은 도구를 통해 StronglyTypedResourceBuilder
    '클래스에서 자동으로 생성되었습니다.
    '멤버를 추가하거나 제거하려면 .ResX 파일을 편집한 다음 /str 옵션을 사용하여 ResGen을
    '다시 실행하거나 VS 프로젝트를 다시 빌드하십시오.
    '''<summary>
    '''  지역화된 문자열 등을 찾기 위한 강력한 형식의 리소스 클래스입니다.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  이 클래스에서 사용하는 캐시된 ResourceManager 인스턴스를 반환합니다.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("DrCode.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  이 강력한 형식의 리소스 클래스를 사용하여 모든 리소스 조회에 대해 현재 스레드의 CurrentUICulture 속성을
        '''  재정의합니다.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  &lt;?xml version=&quot;1.0&quot;?&gt;
        '''&lt;Settings version=&quot;1&quot;&gt;
        '''	&lt;setting key=&quot;Graphics.MonitorRectangle&quot;&gt;0,0,1920,983&lt;/setting&gt;
        '''	&lt;setting key=&quot;Internet.LastMetadataCheck&quot;&gt;16483&lt;/setting&gt;
        '''	&lt;setting key=&quot;Library.LastFile&quot;&gt;&lt;/setting&gt;
        '''	&lt;setting key=&quot;Library.LastGroupPath&quot;&gt;Keyboard Classics&lt;/setting&gt;
        '''	&lt;setting key=&quot;System.LastScreen&quot;&gt;title&lt;/setting&gt;
        '''	&lt;setting key=&quot;System.Random&quot;&gt;be7f5194-2f12-4478-9846-80428fb06554&lt;/setting&gt;
        '''	&lt;setting key=&quot;System.TutorialPresented&quot;&gt;1&lt;/setting&gt;
        '''	&lt;setting key=&quot;System.UnlockKey&quot;&gt;Synthkeysia77u/PD94b[나머지 문자열은 잘림]&quot;;과(와) 유사한 지역화된 문자열을 찾습니다.
        '''</summary>
        Friend ReadOnly Property settings() As String
            Get
                Return ResourceManager.GetString("settings", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  System.Byte[] 형식의 지역화된 리소스를 찾습니다.
        '''</summary>
        Friend ReadOnly Property Synthesia() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("Synthesia", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
    End Module
End Namespace
