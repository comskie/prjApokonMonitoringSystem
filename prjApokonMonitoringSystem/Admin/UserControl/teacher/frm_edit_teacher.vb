Imports MySql.Data.MySqlClient
Public Class frm_edit_teacher
    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim dialogResult As DialogResult = MessageBox.Show("Do you want to edit this teacher?", "Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialogResult = DialogResult.Yes And ValidateInputs() Then
            Try
                conn.Open()
                comm = New MySqlCommand("prcUpdateTeacher", conn)
                With comm
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@col_id", txtColID.Text)
                    .Parameters.AddWithValue("@tid", txtID.Text)
                    .Parameters.AddWithValue("@tfname", txtFname.Text)
                    .Parameters.AddWithValue("@tmname", txtMname.Text)
                    .Parameters.AddWithValue("@tlname", txtLname.Text)
                    .Parameters.AddWithValue("@tgender", cmbGender.Text)
                    .Parameters.AddWithValue("@tnum", txtContactNo.Text)
                    .Parameters.AddWithValue("@tadd", txtEmail.Text)
                    .ExecuteNonQuery()
                End With
            Catch ex As Exception
                MsgBox(ex.Message)
                conn.Close()
            End Try
            conn.Close()


            If txtPassword.Text <> String.Empty Then
                Try
                    conn.Open()
                    comm = New MySqlCommand("prcUpdateAccount", conn)
                    With comm
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.AddWithValue("@uuname", txtID.Text)
                        .Parameters.AddWithValue("@upass", txtPassword.Text)
                        .ExecuteNonQuery()
                    End With
                Catch ex As Exception
                    MsgBox(ex.Message)
                    conn.Close()
                End Try
                conn.Close()
            End If
            MsgBox("Record Updated!", MsgBoxStyle.Information)
            Me.Close()
        End If
    End Sub

    Private Function ValidateInputs() As Boolean
        If txtFname.Text = String.Empty Or txtLname.Text = String.Empty Or cmbGender.Text = String.Empty Or txtContactNo.Text = String.Empty Or txtEmail.Text = String.Empty Then
            MessageBox.Show("Please fill in the textbox.")
            Return False
        Else
            If IsNumeric(txtContactNo.Text) = False Then
                MessageBox.Show("Contact Number must be numberic.")
                Return False
            End If
            Return True
        End If
    End Function


    Private Sub frm_edit_teacher_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

End Class