Imports System.IO
Public Class Logging
    Public Shared Function LogToFile(ByVal Prefix As String,
                              ByVal LogData As String,
                              ByVal LoggingColor As ConsoleColor,
                              Optional ByVal BackgroundColor As ConsoleColor = ConsoleColor.Black,
                              Optional ByVal LogToOwnFile As Boolean = False,
                              Optional ByVal CustomLogFile As String = "")

        Dim RetValue As String

        Try

            Dim LogText As String = "[" & Prefix & "] " & LogData
            Console.BackgroundColor = BackgroundColor
            Console.ForegroundColor = LoggingColor
            Console.WriteLine(LogText)

            If LogToOwnFile = True Then
                My.Computer.FileSystem.WriteAllText(CustomLogFile, LogText, True)
            End If

            RetValue = "1, Logging OK"
        Catch ex As Exception
            RetValue = "0, Failed: " & ex.ToString
        End Try

        Return RetValue
    End Function
End Class
