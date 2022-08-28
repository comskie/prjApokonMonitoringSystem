Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.IO
Public Class frmCaptureImage
    Dim vcd As VideoCaptureDevice
    Dim bmp As Bitmap

    Private Sub frmCaptureImage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim vcdf As New VideoCaptureDeviceForm
        If vcdf.ShowDialog = DialogResult.OK Then
            vcd = vcdf.VideoDevice
            AddHandler vcd.NewFrame, New NewFrameEventHandler(AddressOf Captured)
            vcd.Start()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub Captured(sender As Object, eventArgs As NewFrameEventArgs)
        bmp = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        Guna2PictureBox1.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Guna2PictureBox2.Image = Guna2PictureBox1.Image
    End Sub

    Private Sub frmCaptureImage_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            vcd.Stop()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        SaveFileDialog1.DefaultExt = ".jpg"
        If Guna2PictureBox2.Image Is Nothing Then
            MessageBox.Show("There's no image captured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                Guna2PictureBox2.Image.Save(SaveFileDialog1.FileName, Imaging.ImageFormat.Jpeg)
            End If
        End If



        Me.Dispose()
        vcd.Stop()
    End Sub
End Class