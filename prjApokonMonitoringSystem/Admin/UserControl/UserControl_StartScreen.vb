Imports MySql.Data.MySqlClient
Public Class UserControl_StartScreen
    Private Sub UserControl_StartScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            comm = New MySqlCommand("SELECT COUNT(id) FROM tbl_teacher", conn)
            adapter = New MySqlDataAdapter(comm)
            Dim table As New DataTable()
            adapter.Fill(table)
            txtTeachers.Text = table.Rows(0).Item(0).ToString()
            table.Clear()
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try

        Try
            comm = New MySqlCommand("SELECT COUNT(lrn) FROM tbl_student", conn)
            adapter = New MySqlDataAdapter(comm)
            Dim table As New DataTable()
            adapter.Fill(table)
            txtStudents.Text = table.Rows(0).Item(0).ToString()
            table.Clear()
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try

        Try
            comm = New MySqlCommand("SELECT COUNT(id) FROM tbl_accounts", conn)
            adapter = New MySqlDataAdapter(comm)
            Dim table As New DataTable()
            adapter.Fill(table)
            txtUsers.Text = table.Rows(0).Item(0).ToString()
            table.Clear()
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
        conn.Close()

    End Sub
End Class
