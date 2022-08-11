﻿Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.IO
Imports ZXing
Imports MySql.Data.MySqlClient

Public Class frmScanStudent
    Dim vcd As VideoCaptureDevice
    Dim bmp As Bitmap

    Private Sub Captured(sender As Object, eventArgs As NewFrameEventArgs)
        bmp = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        PictureBox1.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub


    Private Sub frmScanStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim vcdf As New VideoCaptureDeviceForm
        day_today.Text = Format(DateTime.Now, "Long Date")

        If vcdf.ShowDialog = DialogResult.OK Then
            vcd = vcdf.VideoDevice
            AddHandler vcd.NewFrame, New NewFrameEventHandler(AddressOf Captured)
            vcd.Start()
            Timer1.Start()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub frmScanStudent_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            vcd.Stop()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            lblClock.Text = DateTime.Now.ToString("hh:mm:ss tt").ToUpper
            If ValidateTimeLog() = "Timein AM" Then
                timeStatus.Text = "TIME IN (AM)"
            ElseIf ValidateTimeLog() = "Timeout AM" Then
                timeStatus.Text = "TIME OUT (AM)"
            ElseIf ValidateTimeLog() = "Timein PM" Then
                timeStatus.Text = "TIME IN (PM)"
            ElseIf ValidateTimeLog() = "Timeout PM" Then
                timeStatus.Text = "TIME OUT (PM)"
            Else
                timeStatus.Text = "[no data]"
            End If
            Dim Reader As New BarcodeReader()
            Dim result As Result = Reader.Decode(CType(PictureBox1.Image, Bitmap))
            If result IsNot Nothing Then
                SearchStudent(result.Text)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub SearchStudent(ScannedLRN As String)
        Try
            conn.Open()
            comm = New MySqlCommand("SELECT * FROM tbl_student WHERE lrn = '" & ScannedLRN & "'", conn)
            adapter = New MySqlDataAdapter(comm)
            Dim table As New DataTable()
            adapter.Fill(table)

            txtLRN.Text = table.Rows(0).Item(1).ToString()
            txtFname.Text = table.Rows(0).Item(2).ToString()
            txtMname.Text = table.Rows(0).Item(3).ToString()
            txtLname.Text = table.Rows(0).Item(4).ToString()
            If table.Rows(0).Item(5).ToString() = "Male" Then
                cmbGender.SelectedIndex = 0
            Else
                cmbGender.SelectedIndex = 1
            End If
            txtAddress.Text = table.Rows(0).Item(6).ToString()
            txtParent.Text = table.Rows(0).Item(7).ToString()
            txtContactNo.Text = table.Rows(0).Item(8).ToString()
            txtEmail.Text = table.Rows(0).Item(9).ToString()
            If table.Rows(0).Item(10) IsNot Nothing Then
                Dim ms As New MemoryStream(CType(table.Rows(0).Item(10), Byte()))
                ProfileContainer.BackgroundImage = Image.FromStream(ms)
            Else
                MsgBox("Student Not Found!")
            End If
            conn.Close()
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
        conn.Close()

        Dim tts = CreateObject("SAPI.spvoice")
        tts.speak("Welcome " & txtFname.Text & " " & txtMname.Text & " " & txtLname.Text)
        InsertToLogs(txtLRN.Text)
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles day_today.Click

    End Sub
End Class