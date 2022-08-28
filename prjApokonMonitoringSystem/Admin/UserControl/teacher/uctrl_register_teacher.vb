Imports MySql.Data.MySqlClient
Public Class uctrl_register_teacher
    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim dialogResult As DialogResult = MessageBox.Show("Do you want to register this teacher?", "Register", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialogResult = DialogResult.Yes And ValidateInputs() Then

            Try
                conn.Open()
                comm = New MySqlCommand("prcInsertTeacher", conn)
                With comm
                    .CommandType = CommandType.StoredProcedure
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
            Try
                conn.Open()
                comm = New MySqlCommand("prcInsertAccount", conn)
                With comm
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@uuname", txtID.Text)
                    .Parameters.AddWithValue("@upass", txtPassword.Text)
                    .Parameters.AddWithValue("@urole", "teacher")
                    .ExecuteNonQuery()
                End With

            Catch ex As Exception
                MsgBox(ex.Message)
                conn.Close()
            End Try
            conn.Close()
            Try
                conn.Open()
                comm = New MySqlCommand("prcInsertTeacherSection", conn)
                With comm
                    .CommandType = CommandType.StoredProcedure
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@tid", txtID.Text)
                    .Parameters.AddWithValue("@sid", lblsid.Text)
                    .ExecuteNonQuery()
                End With
            Catch ex As Exception
                MsgBox(ex.Message)
                conn.Close()
            End Try
            conn.Close()
            MessageBox.Show("Record inserted")
            ClearText()
        End If
    End Sub

    Private Function ValidateInputs() As Boolean
        If txtFname.Text = String.Empty Or txtLname.Text = String.Empty Or cmbGender.Text = String.Empty Or txtContactNo.Text = String.Empty Or txtEmail.Text = String.Empty Or txtPassword.Text = String.Empty Then
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

    Private Sub ClearText()
        txtSection.Clear()
        lblsid.Text = ""
        txtID.Clear()
        txtContactNo.Clear()
        txtEmail.Clear()
        txtFname.Clear()
        txtLname.Clear()
        txtMname.Clear()
        txtPassword.Clear()
        cmbGender.SelectedIndex = -1
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        With frmBrowse_Section
            .ShowDialog()
            txtSection.Text = .ssname
            lblsid.Text = .ssection
        End With
    End Sub
End Class
