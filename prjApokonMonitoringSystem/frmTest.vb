Imports MySql.Data.MySqlClient
Public Class frmTest

    Public conn As New MySqlConnection
    Public comm As New MySqlCommand
    Public reader As MySqlDataReader
    Public adapter As MySqlDataAdapter
    Dim mysqlconnection As MySqlConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mysqlconnection = New MySqlConnection
        mysqlconnection.ConnectionString = "server=vmucrn65rion.ap-southeast-2.psdb.cloud;user=uni5ebv1yrc3;database=monitoring_system;port=3306;password=pscale_pw_roJcqGhDx6m_f7Fd2CnevLvMauZ6cnAL24UkXwsIURc;SslMode=VerifyFull"
        'mysqlconnection.Open()
        Try
            mysqlconnection.Open()
        Catch myerror As MySqlException
            MsgBox(myerror.Message)
            Exit Sub
        End Try
        MsgBox("connected to database!")
    End Sub
End Class