Imports MySql.Data.MySqlClient
Public Class frm_edit_section

    Private Sub ClearText()
        txtSectionName.Clear()
        cmbYearLevel.SelectedIndex = -1
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim val1 As String
        Dim dialogResult As DialogResult = MessageBox.Show("Do you want to edit this section?", "Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialogResult = DialogResult.Yes And ValidateInputs() Then
            Try
                conn.Open()
                comm = New MySqlCommand("prcUpdateSection", conn)
                With comm
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@col_id", txtColID.Text)
                    .Parameters.AddWithValue("@sid", txtSID.Text)
                    .Parameters.AddWithValue("@sname", txtSectionName.Text)
                    .Parameters.AddWithValue("@ylvl", cmbYearLevel.Text)
                    .Parameters.AddWithValue("@ayear", Format(Date.Now, "yyyy") & "-" & Format(Date.Now.AddYears(1), "yyyy"))
                    .ExecuteNonQuery()
                End With

                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                conn.Close()
            Finally
                conn.Dispose()
            End Try
            conn.Close()

            If txtTeacher.Text <> prevTeacher.Text And txtTeacher.Text <> String.Empty Then
                val1 = "teacher"
            Else
                val1 = "section"
            End If

            Try
                conn.Open()
                comm = New MySqlCommand("prcUpdateTeacherSection", conn)
                With comm
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@tid", lbltid.Text)
                    .Parameters.AddWithValue("@sid", txtSID.Text)
                    .Parameters.AddWithValue("@val", val1)
                    .ExecuteNonQuery()
                End With
            Catch ex As Exception
                MsgBox(ex.Message)
                conn.Close()
            End Try

            Me.Close()

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

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) 
        ClearText()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        With frmBrowse_Teacher
            .ShowDialog()
            lbltid.Text = .tuname
            txtTeacher.Text = .tname
        End With
    End Sub
End Class