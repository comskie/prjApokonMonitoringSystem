Imports MySql.Data.MySqlClient
Imports System.IO
Public Class uctrl_backup
    Dim SqlConnection As MySqlConnection
    Public Sub connect_db()
        Try
            SqlConnection = New MySqlConnection("Server= " & txtServerName.Text & "; User Id = " & txtServerUserID.Text & "; Password=" & txtServerPassword.Text & ";")
            If SqlConnection.State = ConnectionState.Closed Then
                SqlConnection.Open()

            End If
        Catch ex As Exception
            MsgBox("Connection Failed!")
        End Try
    End Sub
    Dim dt As New DataTable
    Dim cmd As String
    Dim dtseCt As Integer
    Dim da As MySqlDataAdapter

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Try
            connect_db()
            cmd = "SELECT DISTINCT TABLE_SCHEMA FROM information_schema.TABLES"
            da = New MySqlDataAdapter(cmd, SqlConnection)
            da.Fill(dt)
            dtseCt = 0

            cmbDBList.Enabled = True
            cmbDBList.Items.Clear()
            cmbDBList.Items.Add("== SELECT DATABASE ==")

            While dtseCt < dt.Rows.Count
                cmbDBList.Items.Add(dt.Rows(dtseCt)(0).ToString)
                dtseCt = dtseCt + 1
            End While
            cmbDBList.SelectedIndex = 0
            Guna2Button1.Enabled = True
            Guna2Button2.Enabled = True
            Guna2Button3.Enabled = False

            SqlConnection.Close()
            dt.Dispose()
            da.Dispose()
        Catch ex As Exception
            MsgBox("Connection Failed")
        End Try
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim DbFile As String
        Try
            SaveFileDialog1.Filter = "SQL Dump File (*.sql)|*.sql|All files (*.*)|*.*"
            SaveFileDialog1.FileName = "DATABASE BACKUP " + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".sql"
            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                connect_db()
                DbFile = SaveFileDialog1.FileName
                Dim BackupProcess As New Process
                With BackupProcess
                    .StartInfo.FileName = "cmd.exe"
                    .StartInfo.UseShellExecute = False
                    .StartInfo.WorkingDirectory = "C:\Program Files\MySQL\MySQL Server 8.0\bin"
                    .StartInfo.RedirectStandardInput = True
                    .StartInfo.RedirectStandardOutput = True
                    .Start()
                End With

                Dim BackupStream As StreamWriter = BackupProcess.StandardInput
                Dim myStreamReader As StreamReader = BackupProcess.StandardOutput
                BackupStream.WriteLine("mysqldump --user=" & txtServerUserID.Text & " --password=" & txtServerPassword.Text & " --host=" & txtServerName.Text & " " & cmbDBList.Text & " > """ + DbFile + """")
                BackupStream.Close()
                BackupProcess.WaitForExit()
                BackupProcess.Close()
                SqlConnection.Close()
                MsgBox("MySQL dump successfully created!", MessageBoxIcon.Information, "Backup")
            End If
        Catch ex As Exception
            MsgBox("There is an error. Backup process failed.", MessageBoxIcon.Error, "Backup")
        End Try
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim DbFile As String
        Try
            OpenFileDialog1.Filter = "SQL Dump File (*.sql)|*.sql|All files (*.*)|*.*"
            OpenFileDialog1.FileName = ""
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                connect_db()
                DbFile = SaveFileDialog1.FileName
                Dim BackupProcess As New Process
                With BackupProcess
                    .StartInfo.FileName = "cmd.exe"
                    .StartInfo.UseShellExecute = False
                    .StartInfo.WorkingDirectory = "C:\Program Files\MySQL\MySQL Server 8.0\bin"
                    .StartInfo.RedirectStandardInput = True
                    .StartInfo.RedirectStandardOutput = True
                    .Start()
                End With

                Dim BackupStream As StreamWriter = BackupProcess.StandardInput
                Dim myStreamReader As StreamReader = BackupProcess.StandardOutput
                'BackupStream.WriteLine("mysql --user=" & txtServerUserID.Text & " --password=" & txtServerPassword.Text & " --host=" & txtServerName.Text & " " & cmbDBList.Text & " > """ + DbFile + """")
                BackupStream.WriteLine("mysqldump.exe --defaults-file='C:\Users\MYPC~1\AppData\Local\Temp\tmp9mm3izq3.cnf' --host=" & txtServerName.Text & " --port=3306 --default-character-set=utf8 --user=" & txtServerUserID.Text & "--protocol=tct --set-gtid-purged=OFF --column-statistics=FALSE --skip-triggers " & cmbDBList.Text & " > " + DbFile)
                BackupStream.Close()
                BackupProcess.WaitForExit()
                BackupProcess.Close()
                SqlConnection.Close()
                MsgBox("MySQL restored successfully!", MessageBoxIcon.Information, "Restore")
            End If
        Catch ex As Exception
            MsgBox("There is an error. Backup process failed.", MessageBoxIcon.Error, "Restore")
        End Try
    End Sub
End Class
