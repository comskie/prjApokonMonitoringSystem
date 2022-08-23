Imports CloudinaryDotNet
Imports MySql.Data.MySqlClient
Imports System.Net
Module Connection
    Public conn As New MySqlConnection
    Public comm As New MySqlCommand
    Public reader As MySqlDataReader
    Public adapter As MySqlDataAdapter
    Sub connect()
        Try
            With conn
                .ConnectionString = "server=localhost;user=root;database=monitoring_system;port=3306;password=1234;"
                If .State = ConnectionState.Open Then
                    conn.Close()
                End If
            End With
        Catch myerror As MySqlException
            MsgBox(myerror.Message)
        End Try
    End Sub

    Public Function CheckForInternetConnection() As Boolean
        Try
            Using client = New WebClient()
                Using stream = client.OpenRead("http://www.google.com")
                    Return True
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function

End Module
