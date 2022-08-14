Imports MySql.Data.MySqlClient
Public Class frm_edit_teacher
    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Try
            conn.Open()
            comm = New MySqlCommand("UPDATE tbl_teacher SET username=@uname, fname=@tfname, mname=@tmname, lname=@tlname, gender=@tgender, contact_number=@tcnum, email_address=@teaddm WHERE id = '" & txtID.Text & "'", conn)
            comm.Parameters.Add("@uname", MySqlDbType.VarChar).Value = txtUsername.Text
            comm.Parameters.Add("@tfname", MySqlDbType.VarChar).Value = txtFname.Text
            comm.Parameters.Add("@tmname", MySqlDbType.VarChar).Value = txtMname.Text
            comm.Parameters.Add("@tlname", MySqlDbType.VarChar).Value = txtLname.Text
            comm.Parameters.Add("@tgender", MySqlDbType.VarChar).Value = cmbGender.Text
            comm.Parameters.Add("@tcnum", MySqlDbType.VarChar).Value = txtContactNo.Text
            comm.Parameters.Add("@teaddm", MySqlDbType.VarChar).Value = txtEmail.Text
            adapter = New MySqlDataAdapter(comm)
            comm.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
        conn.Close()

        If txtPrevious.Text <> txtUsername.Text Then
            Try
                conn.Open()
                comm = New MySqlCommand("UPDATE tbl_section SET advisory_of=@advisory WHERE advisory_of = '" & txtPrevious.Text & "'", conn)
                comm.Parameters.Add("@advisory", MySqlDbType.VarChar).Value = txtUsername.Text
                adapter = New MySqlDataAdapter(comm)
                comm.ExecuteNonQuery()
                conn.Close()
            Catch ex As Exception
                conn.Close()
                MessageBox.Show(ex.Message)
            Finally
                conn.Dispose()
            End Try
            conn.Close()
        End If


        If txtPassword.Text <> String.Empty Then
            Try
                conn.Open()
                comm = New MySqlCommand("UPDATE tbl_accounts SET username=@uname, password=sha1(@upass), user_role=@urole WHERE id = '" & txtAccountID.Text & "'", conn)
                comm.Parameters.Add("@uname", MySqlDbType.VarChar).Value = txtUsername.Text
                comm.Parameters.Add("@upass", MySqlDbType.VarChar).Value = txtPassword.Text
                comm.Parameters.Add("@urole", MySqlDbType.VarChar).Value = "teacher"
                adapter = New MySqlDataAdapter(comm)
                comm.ExecuteNonQuery()
                conn.Close()
            Catch ex As Exception
                conn.Close()
                MessageBox.Show(ex.Message)
            Finally
                conn.Dispose()
            End Try
            conn.Close()

        Else
            Try
                conn.Open()
                comm = New MySqlCommand("UPDATE tbl_accounts SET username=@uname, user_role=@urole WHERE id = '" & txtAccountID.Text & "'", conn)
                comm.Parameters.Add("@uname", MySqlDbType.VarChar).Value = txtUsername.Text
                comm.Parameters.Add("@urole", MySqlDbType.VarChar).Value = "teacher"
                adapter = New MySqlDataAdapter(comm)
                comm.ExecuteNonQuery()
                conn.Close()
            Catch ex As Exception
                conn.Close()
                MessageBox.Show(ex.Message)
            Finally
                conn.Dispose()
            End Try
            conn.Close()
        End If
        MsgBox("Record Updated!", MsgBoxStyle.Information)
        'ClearText()
        Me.Close()
    End Sub

    Private Sub frm_edit_teacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            comm = New MySqlCommand("SELECT id FROM tbl_accounts WHERE username = '" & txtUsername.Text & "'", conn)
            adapter = New MySqlDataAdapter(comm)
            Dim table As New DataTable()
            adapter.Fill(table)
            txtAccountID.Text = table.Rows(0).Item(0).ToString()
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
        conn.Close()
    End Sub

    Private Sub frm_edit_teacher_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub
End Class