Imports QRCoder
Public Class frm_view_student

    Private Sub frm_view_student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim gen As New QRCodeGenerator
        Dim data = gen.CreateQrCode(txtLRN.Text, QRCodeGenerator.ECCLevel.Q)
        Dim code As New QRCode(data)
        QRContainer.BackgroundImage = code.GetGraphic(6)

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        With frm_student_id
            .nameContainer.Text = txtFname.Text & " " & txtMname.Text & " " & txtLname.Text
            .genderContainer.Text = cmbGender.Text
            .addressContainer.Text = txtAddress.Text
            .lrnContainer.Text = txtLRN.Text
            .QRBox.Image = QRContainer.BackgroundImage
            .Profile.Image = ProfileContainer.Image
            .sectionContainer.Text = txtSection.Text
            .ShowDialog()
        End With


    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim locationFile As String = Application.StartupPath & "\student_id\" & txtLRN.Text & ".png"
        Dim downloadLocation As String
        Try
            If FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                downloadLocation = FolderBrowserDialog1.SelectedPath
                Dim root As Environment.SpecialFolder = FolderBrowserDialog1.RootFolder
                MsgBox("Successfully downloaded ID", MsgBoxStyle.Information)
                My.Computer.Network.DownloadFile(locationFile, downloadLocation & "\qr_id_" & txtLRN.Text & ".png")
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class