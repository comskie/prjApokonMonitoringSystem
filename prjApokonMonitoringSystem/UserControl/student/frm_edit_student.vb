Imports QRCoder
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class frm_edit_student
    Dim image_path As String
    Dim image_url As String
    Private Sub txtLRN_TextChanged(sender As Object, e As EventArgs) Handles txtLRN.TextChanged
        If txtLRN.Text.Length < 1 Then
            QRGenerate.Visible = False
        Else
            QRGenerate.Visible = True
            Dim gen As New QRCodeGenerator
            Dim data = gen.CreateQrCode(txtLRN.Text, QRCodeGenerator.ECCLevel.Q)
            Dim code As New QRCode(data)
            QRGenerate.BackgroundImage = code.GetGraphic(6)
        End If
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        ClearText()
    End Sub

    Private Sub ClearText()
        txtEmail.Clear()
        txtAddress.Clear()
        txtContactNo.Clear()
        txtFname.Clear()
        txtLname.Clear()
        txtLRN.Clear()
        txtMname.Clear()
        txtParent.Clear()
        ProfileContainer.BackgroundImage = Nothing
        cmbGender.SelectedIndex = -1
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim dialogResult As DialogResult = MessageBox.Show("Do you want to edit this student?", "Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialogResult = DialogResult.Yes And ValidateInputs() Then
            Try
                conn.Open()

                comm = New MySqlCommand("UPDATE tbl_student SET lrn=@slrn, fname=@sfname, mname=@smname, lname=@slname, gender=@sgender, address=@saddress, parent_name=@spname, contact_number=@scnum, email_address=@seaddm, section=@ssection, picture_url = @surl WHERE id='" & txtID.Text & "'", conn)
                comm.Parameters.Add("@slrn", MySqlDbType.VarChar).Value = txtLRN.Text
                comm.Parameters.Add("@sfname", MySqlDbType.VarChar).Value = txtFname.Text
                comm.Parameters.Add("@smname", MySqlDbType.VarChar).Value = txtMname.Text
                comm.Parameters.Add("@slname", MySqlDbType.VarChar).Value = txtLname.Text
                comm.Parameters.Add("@sgender", MySqlDbType.VarChar).Value = cmbGender.Text
                comm.Parameters.Add("@saddress", MySqlDbType.VarChar).Value = txtAddress.Text
                comm.Parameters.Add("@spname", MySqlDbType.VarChar).Value = txtParent.Text
                comm.Parameters.Add("@scnum", MySqlDbType.VarChar).Value = txtContactNo.Text
                comm.Parameters.Add("@seaddm", MySqlDbType.VarChar).Value = txtEmail.Text

                If txtPath.Text <> String.Empty Then
                    If checkIfImageExist(txtPath.Text) And txtNewPath.Text <> String.Empty Then
                        image_url = CloudinaryStorage(image_path, txtLRN.Text)
                        comm.Parameters.Add("@surl", MySqlDbType.VarChar).Value = image_url
                    ElseIf checkIfImageExist(txtPath.Text) And txtNewPath.Text = String.Empty Then
                        comm.Parameters.Add("@surl", MySqlDbType.VarChar).Value = txtPath.Text
                    Else
                        comm.Parameters.Add("@surl", MySqlDbType.VarChar).Value = "https://res.cloudinary.com/hwke7fy3v/image/upload/v1661136033/display_picture/default_profile_y3rbxa.jpg"
                    End If
                Else
                    comm.Parameters.Add("@surl", MySqlDbType.VarChar).Value = "https://res.cloudinary.com/hwke7fy3v/image/upload/v1661136033/display_picture/default_profile_y3rbxa.jpg"
                End If

                comm.Parameters.Add("@ssection", MySqlDbType.VarChar).Value = txtSection.Text

                adapter = New MySqlDataAdapter(comm)
                comm.ExecuteNonQuery()
                MessageBox.Show("Record updated")
                conn.Close()
            Catch ex As Exception
                conn.Close()
                MessageBox.Show(ex.Message)
            Finally
                conn.Dispose()
            End Try
            conn.Close()
            Me.Close()
        End If
    End Sub

    Private Function ValidateInputs() As Boolean
        If txtFname.Text = String.Empty Or txtLname.Text = String.Empty Or txtAddress.Text = String.Empty Or cmbGender.Text = String.Empty Or txtSection.Text = String.Empty Or txtParent.Text = String.Empty Or txtContactNo.Text = String.Empty Or txtEmail.Text = String.Empty Then
            MessageBox.Show("Please fill in the textbox.")
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        OpenFileDialog1.Filter = "Choose Image(*.JPG; *.PNG)|*.jpg;*.png"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            ProfileContainer.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
        image_path = IO.Path.GetFullPath(OpenFileDialog1.FileName)
        txtNewPath.Text = image_path
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        With frmCaptureImage
            .ShowDialog()
        End With
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        With frmBrowse_Section
            .ShowDialog()
            txtSection.Text = .ssection
        End With
    End Sub

    Private Sub frm_edit_student_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub
End Class