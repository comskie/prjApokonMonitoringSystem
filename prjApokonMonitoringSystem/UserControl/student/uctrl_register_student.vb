Imports MySql.Data.MySqlClient
Imports AForge.Video.DirectShow
Imports System.IO
Imports QRCoder
Public Class uctrl_register_student
    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim ms As New MemoryStream
        ProfileContainer.BackgroundImage.Save(ms, ProfileContainer.BackgroundImage.RawFormat)
        Try
            conn.Open()
            comm = New MySqlCommand("INSERT INTO tbl_student(lrn, fname, mname, lname, gender, address, parent_name, contact_number, email_address, display_picture) VALUES (@slrn, @sfname, @smname, @slname, @sgender, @saddress, @spname, @scnum, @seaddm, @sdp)", conn)
            comm.Parameters.Add("@slrn", MySqlDbType.VarChar).Value = txtLRN.Text
            comm.Parameters.Add("@sfname", MySqlDbType.VarChar).Value = txtFname.Text
            comm.Parameters.Add("@smname", MySqlDbType.VarChar).Value = txtMname.Text
            comm.Parameters.Add("@slname", MySqlDbType.VarChar).Value = txtLname.Text
            comm.Parameters.Add("@sgender", MySqlDbType.VarChar).Value = cmbGender.Text
            comm.Parameters.Add("@saddress", MySqlDbType.VarChar).Value = txtAddress.Text
            comm.Parameters.Add("@spname", MySqlDbType.VarChar).Value = txtParent.Text
            comm.Parameters.Add("@scnum", MySqlDbType.VarChar).Value = txtContactNo.Text
            comm.Parameters.Add("@seaddm", MySqlDbType.VarChar).Value = txtEmail.Text
            comm.Parameters.Add("@sdp", MySqlDbType.LongBlob).Value = ms.ToArray()

            With frm_student_id
                .nameContainer.Text = txtFname.Text & " " & txtMname.Text & " " & txtLname.Text
                .lrnContainer.Text = txtLRN.Text
                .genderContainer.Text = cmbGender.Text
                .addressContainer.Text = txtAddress.Text
                .QRBox.Image = QRGenerate.BackgroundImage
                .Profile.Image = ProfileContainer.BackgroundImage
                .ShowDialog()
            End With

            adapter = New MySqlDataAdapter(comm)
            comm.ExecuteNonQuery()

            MessageBox.Show("Record inserted")
            SendMail(txtEmail.Text, "Apokon Monitoring System Registration", "Hello there " & txtParent.Text & "! " & txtFname.Text & " have successfully registered in Apokon Monitoring System.", txtLRN.Text)
            conn.Close()
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

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        ClearText()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Choose Image(*.JPG; *.PNG)|*.jpg;*.png"
        If ofd.ShowDialog = DialogResult.OK Then
            ProfileContainer.BackgroundImage = Image.FromFile(ofd.FileName)
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        With frmCaptureImage
            .ShowDialog()
        End With
    End Sub

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
End Class
