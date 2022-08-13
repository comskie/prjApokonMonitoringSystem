Imports MySql.Data.MySqlClient
Public Class uctrl_register_teacher
    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Try
            conn.Open()
            comm = New MySqlCommand("INSERT INTO tbl_teacher(username, fname, mname, lname, gender, contact_number, email_address) VALUES (@uname, @tfname, @tmname, @tlname, @tgender, @tcnum, @teaddm)", conn)
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

        Try
            conn.Open()
            comm = New MySqlCommand("INSERT INTO tbl_accounts(username, password, user_role) VALUES (@uname, @upass, @urole)", conn)
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
        MsgBox("Record Inserted!", MsgBoxStyle.Information)
        ClearText()
    End Sub

    Private Sub ClearText()
        txtContactNo.Clear()
        txtEmail.Clear()
        txtFname.Clear()
        txtLname.Clear()
        txtMname.Clear()
        txtPassword.Clear()
        txtUsername.Clear()
        cmbGender.SelectedIndex = -1
    End Sub

End Class
