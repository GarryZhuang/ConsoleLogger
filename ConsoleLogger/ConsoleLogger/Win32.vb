Imports System.Runtime.InteropServices

Public Class Win32
    'Open the Console
    <DllImport("kernel32.dll")> Public Shared Function AllocConsole() As Boolean

    End Function

    'Close the Console
    <DllImport("kernel32.dll")> Public Shared Function FreeConsole() As Boolean

    End Function

    'Force Import Console
    <DllImport("kernel32.dll")> Public Shared Function AttachConsole(ByVal dwProcessId As Integer) As Boolean

    End Function
End Class
