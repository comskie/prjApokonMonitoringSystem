Imports System.Management
Imports System.Threading
Public Class uctrl_send_sms
    Dim rcvdata As String = ""
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        With frmBrowse_Student
            .ShowDialog()
            txtLRN.Text = .slrn
            txtContact.Text = .scontact
            txtName.Text = .sname
        End With
    End Sub

    Private Sub uctrl_send_sms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SerialPort1.Close()
        Dim ports() As String
        ports = Split(ModemsConnected(), "***")
        For i As Integer = 0 To ports.Length - 2
            cmbConnect.Items.Add(ports(i))

        Next
    End Sub

    Public Function ModemsConnected() As String
        Dim modems As String = ""
        Try
            Dim searcher As New ManagementObjectSearcher(
                "root\CIMV2",
                "SELECT * FROM Win32_POTSModem")

            For Each queryObj As ManagementObject In searcher.Get()
                If queryObj("Status") = "OK" Then
                    modems = modems & (queryObj("AttachedTo") & " - " & queryObj("Description") & "***")
                End If
            Next
        Catch err As ManagementException
            MsgBox("error")
            Return ""
        End Try
        Return modems
    End Function

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Try
            With SerialPort1
                .PortName = lblPort.Text
                .BaudRate = 9600
                .Parity = IO.Ports.Parity.None
                .DataBits = 8
                .StopBits = IO.Ports.StopBits.One
                .Handshake = IO.Ports.Handshake.None
                .RtsEnable = True
                .ReceivedBytesThreshold = 1
                .NewLine = vbCr
                .ReadTimeout = 1000
                .Open()
            End With

            If SerialPort1.IsOpen Then
                lblStatus.Text = "Connected"
                lblStatus.ForeColor = Color.DarkOliveGreen
            Else
                lblStatus.Text = "Error"
                lblStatus.ForeColor = Color.DarkRed
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Try
            With SerialPort1
                .Write("at" & vbCrLf)
                Threading.Thread.Sleep(1000)
                .Write("at+cmgf=1" & vbCrLf)
                Threading.Thread.Sleep(1000)
                .Write("at+cmgs=" & Chr(34) & txtContact.Text & Chr(34) & vbCrLf)
                .Write(txtBody.Text & Chr(26))
                Threading.Thread.Sleep(1000)
                MsgBox(rcvdata.ToString)
            End With
            If rcvdata.ToString.Contains(">") Then
                MsgBox("Message Sent")
            Else
                MsgBox("Error!")
            End If
            InsertToNotificationLogs("sms", txtContact.Text, txtBody.Text)
            ClearText()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ClearText()
        txtBody.Clear()
        txtContact.Clear()
        txtLRN.Clear()
        txtName.Clear()
    End Sub

    Private Sub SerialPort1_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Dim datain As String = ""
        Dim numbytes As Integer = SerialPort1.BytesToRead
        For i As Integer = 1 To numbytes
            datain &= Chr(SerialPort1.ReadChar)
        Next
        test(datain)
    End Sub

    Private Sub test(ByVal indata As String)
        rcvdata &= indata
    End Sub

    Private Sub cmbConnect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbConnect.SelectedValueChanged
        lblPort.Text = Trim(Mid(cmbConnect.Text, 1, 5))
    End Sub

    Private Sub txtLRN_TextChanged(sender As Object, e As EventArgs) Handles txtLRN.TextChanged
        If txtLRN.Text = String.Empty Then
            txtBody.Enabled = False
            btnSend.Enabled = False
        Else
            txtBody.Enabled = True
            btnSend.Enabled = True
        End If
    End Sub

End Class
