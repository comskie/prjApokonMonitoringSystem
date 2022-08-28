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
        cmbYearLevel.SelectedIndex = -1
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        ClearText()
    End Sub
End Class
