Imports CloudinaryDotNet
Imports MySql.Data.MySqlClient
Module Connection
    Public conn As New MySqlConnection
    Public comm As New MySqlCommand
    Public reader As MySqlDataReader
    Public adapter As MySqlDataAdapter
    Public school_email As String = "apokon.monitoring@gmail.com"
    Public school_password As String = "txyuonmqgfxekmeb"
    Public Cloudinary As Cloudinary
    Public Const CLOUD_NAME As String = "dsffeuudt"
    Public Const API_KEY As String = "176669418197682"
    Public Const API_SECRET As String = "OGlji-Y32d7pWMFJRf9P45mLWC8"
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
End Module
