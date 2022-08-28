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
        Dim ms As New MemoryStream
        ProfileContainer.Image.Save(ms, ProfileContainer.Image.RawFormat)

        Dim dialogResult As DialogResult = MessageBox.Show("Do you want to register this student?", "Register", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialogResult = DialogResult.Yes And ValidateInputs() Then
            conn.Open()

            Try
                comm = New MySqlCommand("prcUpdateStudent", conn)
                With comm
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@col_id", txtID.Text)
                    .Parameters.AddWithValue("@sid", txtLRN.Text)
                    .Parameters.AddWithValue("@sfname", txtFname.Text)
                    .Parameters.AddWithValue("@smname", txtMname.Text)
                    .Parameters.AddWithValue("@slname", txtLname.Text)
                    .Parameters.AddWithValue("@sgender", cmbGender.Text)
                    .Parameters.AddWithValue("@saddress", txtAddress.Text)
                    .Parameters.AddWithValue("@pname", txtParent.Text)
                    .Parameters.AddWithValue("@pnum", txtContactNo.Text)
                    .Parameters.AddWithValue("@eadd", txtAddress.Text)
                    .Parameters.AddWithValue("@dp", ms.ToArray)
                    .ExecuteNonQuery()
                End With

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
        If txtFname.Text = String.Empty Or txtLname.Text = String.Empty Or txtAddress.Text = String.Empty Or cmbGender.Text = String.Empty Or txtParent.Text = String.Empty Or txtContactNo.Text = String.Empty Or txtEmail.Text = String.Empty Then
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