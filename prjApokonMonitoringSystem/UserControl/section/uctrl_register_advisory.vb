Imports MySql.Data.MySqlClient
Public Class uctrl_register_advisory
    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox1.Click

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        With frmBrowse_Teacher
            .ShowDialog()
            txtTeacherInfo.Text = .tuname
            txtTeacher.Text = .tname
        End With
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Try
            conn.Open()
            comm = New MySqlCommand("INSERT INTO tbl_section(section_name, year_level, academic_year, advisory_of) VALUES (@sname, @slevel, @syear, @advisory)", conn)
            comm.Parameters.Add("@sname", MySqlDbType.VarChar).Value = txtSectionName.Text
            comm.Parameters.Add("@slevel", MySqlDbType.VarChar).Value = cmbYearLevel.Text
            comm.Parameters.Add("@syear", MySqlDbType.VarChar).Value = Format(Date.Now, "yyyy") & "-" & Format(Date.Now.AddYears(1), "yyyy")
            comm.Parameters.Add("@advisory", MySqlDbType.VarChar).Value = txtTeacherInfo.Text
            adapter = New MySqlDataAdapter(comm)
            comm.ExecuteNonQuery()
            MsgBox("Record inserted", MsgBoxStyle.Information)
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
        conn.Close()
        ClearText()
    End Sub

    Private Sub ClearText()
        txtSectionName.Clear()
        txtTeacher.Clear()
        txtTeacherInfo.Clear()
        cmbYearLevel.SelectedIndex = -1
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        ClearText()
    End Sub
End Class
