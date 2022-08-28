Imports MySql.Data.MySqlClient
Public Class uctrl_register_advisory
    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim dialogResult As DialogResult = MessageBox.Show("Do you want to register this section?", "Register", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialogResult = DialogResult.Yes And ValidateInputs() Then
            Try
                conn.Open()
                comm = New MySqlCommand("prcInsertSection", conn)
                With comm
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@sname", txtSectionName.Text)
                    .Parameters.AddWithValue("@ylvl", cmbYearLevel.Text)
                    .Parameters.AddWithValue("@ayear", Format(Date.Now, "yyyy") & "-" & Format(Date.Now.AddYears(1), "yyyy"))
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Record inserted")
            Catch ex As Exception
            End Try
            conn.Close()

            Try
                conn.Open()
                comm = New MySqlCommand("prcInsertTeacherSection", conn)
                With comm
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@tid", lbltid.Text)
                    .Parameters.AddWithValue("@sid", lblsid.Text)
                    .ExecuteNonQuery()
                End With
            Catch ex As Exception
                MsgBox(ex.Message)
                conn.Close()
            End Try
            conn.Close()

            ClearText()
        End If
    End Sub

    Private Function ValidateInputs() As Boolean
        If txtSectionName.Text = String.Empty Or cmbYearLevel.Text = String.Empty Then
            MessageBox.Show("Please fill in the textbox.")
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub ClearText()
        txtSectionName.Clear()
        txtTeacher.Clear()
        lbltid.Text = ""
        cmbYearLevel.SelectedIndex = -1
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        ClearText()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        With frmBrowse_Teacher
            .ShowDialog()
            lbltid.Text = .tuname
            txtTeacher.Text = .tname
        End With
    End Sub

    Private Sub uctrl_register_advisory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getMaxCol()
    End Sub

    Private Sub getMaxCol()
        Try
            conn.Open()
            comm = New MySqlCommand("SELECT MAX(DISTINCT section_id) + 1 FROM tbl_section", conn)
            adapter = New MySqlDataAdapter(comm)
            Dim table As New DataTable()
            adapter.Fill(table)
            lblsid.Text = table.Rows(0).Item(0).ToString()
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
        conn.Close()
    End Sub
End Class
