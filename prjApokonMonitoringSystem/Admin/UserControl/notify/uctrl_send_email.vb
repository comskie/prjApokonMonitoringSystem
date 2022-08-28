Imports MySql.Data.MySqlClient
Public Class uctrl_send_email
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.png" + "|Office Files|*.doc;*.xls;*.ppt;*.pdf" + "|All Files|*.*"
        txtAttachment.Text = ""
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            txtAttachment.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub txtLRN_TextChanged(sender As Object, e As EventArgs) Handles txtLRN.TextChanged
        If txtLRN.Text = String.Empty Then
            txtBody.Enabled = False
            txtSubject.Enabled = False
            btnSend.Enabled = False
        Else
            txtBody.Enabled = True
            txtSubject.Enabled = True
            btnSend.Enabled = True
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        With frmBrowse_Student
            .ShowDialog()
            txtLRN.Text = .slrn
            txtEmail.Text = .semail
            txtName.Text = .sname
        End With
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        If txtAttachment.Text <> String.Empty Then
            Dim attachment As System.Net.Mail.Attachment
            attachment = New System.Net.Mail.Attachment(txtAttachment.Text)
            SendMail(txtEmail.Text, txtSubject.Text, txtBody.Text, txtLRN.Text, attachment)
        Else
            SendMail(txtEmail.Text, txtSubject.Text, txtBody.Text, txtLRN.Text)
        End If
        InsertToNotificationLogs("email", txtEmail.Text, txtBody.Text)
        ClearText()
    End Sub

    Private Sub ClearText()
        txtLRN.Clear()
        txtEmail.Clear()
        txtBody.Clear()
        txtAttachment.Clear()
        txtName.Clear()
        txtSubject.Clear()
    End Sub
End Class
