Imports MySql.Data.MySqlClient
Public Class frm_edit_section

    Private Sub ClearText()
        txtSectionName.Clear()
        txtTeacher.Clear()
        txtTeacherInfo.Clear()
        cmbYearLevel.SelectedIndex = -1
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
            comm = New MySqlCommand("UPDATE tbl_section SET section_name = @sname, year_level = @slevel, academic_year = @syear, advisory_of = @advisory WHERE id = '" & txtID.Text & "'", conn)
            comm.Parameters.Add("@sname", MySqlDbType.VarChar).Value = txtSectionName.Text
            comm.Parameters.Add("@slevel", MySqlDbType.VarChar).Value = cmbYearLevel.Text
            comm.Parameters.Add("@syear", MySqlDbType.VarChar).Value = Format(Date.Now, "yyyy") & "-" & Format(Date.Now.AddYears(1), "yyyy")
            comm.Parameters.Add("@advisory", MySqlDbType.VarChar).Value = txtTeacherInfo.Text
            adapter = New MySqlDataAdapter(comm)
            comm.ExecuteNonQuery()
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
        conn.Close()

        If txtSectionName.Text <> txtPreviousName.Text Then
            Try
                conn.Open()
                comm = New MySqlCommand("UPDATE tbl_student SET section = @ssection WHERE section = '" & txtPreviousName.Text & "'", conn)
                comm.Parameters.Add("@ssection", MySqlDbType.VarChar).Value = txtSectionName.Text
                adapter = New MySqlDataAdapter(comm)
                comm.ExecuteNonQuery()
            Catch ex As Exception
                conn.Close()
                MessageBox.Show(ex.Message)
            Finally
                conn.Dispose()
            End Try
            conn.Close()
        End If
        MsgBox("Record updated", MsgBoxStyle.Information)
        Me.Close()
        ClearText()
    End Sub
End Class