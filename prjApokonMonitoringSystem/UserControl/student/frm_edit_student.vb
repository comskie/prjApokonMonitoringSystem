Imports QRCoder
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class frm_edit_student
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
        Dim ms As New MemoryStream
        ProfileContainer.BackgroundImage.Save(ms, ProfileContainer.BackgroundImage.RawFormat)
        Try
            conn.Open()
            comm = New MySqlCommand("UPDATE tbl_student SET lrn=@slrn, fname=@sfname, mname=@smname, lname=@slname, gender=@sgender, address=@saddress, parent_name=@spname, contact_number=@scnum, email_address=@seaddm, display_picture=@sdp WHERE id='" & txtID.Text & "'", conn)
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
    End Sub
End Class