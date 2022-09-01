Imports CloudinaryDotNet
Imports MySql.Data.MySqlClient
Imports System.Net
Module Connection
    Public conn As New MySqlConnection
    Public comm As New MySqlCommand
    Public reader As MySqlDataReader
    Public adapter As MySqlDataAdapter
    Public school_email As String = "apokon.monitoring@gmail.com"
    Public school_password As String = "txyuonmqgfxekmeb"

    Sub connect()

        Try
            With conn
                .ConnectionString = "server=localhost;user=root;database=apokon_monitoring_system;port=3306;password=1234;"
                If .State = ConnectionState.Open Then
                    conn.Close()
                End If
            End With
        Catch myerror As MySqlException
            MsgBox(myerror.Message)
        End Try
    End Sub

End Module
