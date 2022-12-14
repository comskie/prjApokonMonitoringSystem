Imports MySql.Data.MySqlClient
Public Class frmLogin
    Dim password_toggle As Boolean = True

    Private Sub txtPassword_IconRightClick(sender As Object, e As EventArgs) Handles txtPassword.IconRightClick
        If password_toggle = True Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If
        password_toggle = Not password_toggle
    End Sub
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
    End Sub

    Private Sub frmLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Guna2Button1.PerformClick()
        End If
    End Sub

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Try
            conn.Open()
            comm = New MySqlCommand("SELECT * FROM tbl_accounts WHERE BINARY user_username = '" & txtUsername.Text & "' AND BINARY user_password = sha1('" & txtPassword.Text & "')", conn)
            adapter = New MySqlDataAdapter(comm)
            Dim table As New DataTable()
            adapter.Fill(table)

            If table.Rows.Count = 0 Then
                MsgBox("Access Denied. Wrong username or password", MsgBoxStyle.Critical)
                txtUsername.Focus()
            Else
                If table.Rows(0).Item(3).ToString() = "teacher" Then
                    MsgBox("Access Granted! Welcome teacher", MsgBoxStyle.Information)
                    teacherID = txtUsername.Text
                    frmMainPageTeacher.Show()
                ElseIf table.Rows(0).Item(3).ToString() = "admin" Then
                    MsgBox("Access Granted! Welcome admin", MsgBoxStyle.Information)
                    frmMainPage.Show()
                Else
                    MsgBox("There's an error accessing records.")
                End If
                Me.Hide()
            End If
            txtUsername.Text = ""
            txtPassword.Text = ""
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
        conn.Close()
    End Sub

    Private Sub IconButton7_Click(sender As Object, e As EventArgs) Handles IconButton7.Click
        Application.Exit()
    End Sub
End Class
