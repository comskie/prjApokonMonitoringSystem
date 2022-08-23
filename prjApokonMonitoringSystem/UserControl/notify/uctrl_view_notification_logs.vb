Imports MySql.Data.MySqlClient
Public Class uctrl_view_notification_logs

    Private Sub displayLogs()
        Try
            comm = New MySqlCommand("SELECT notification_type AS 'Notification Type', sent_to AS 'Sent To', message_content AS 'Message Content', DATE_FORMAT(date_sent, '%m/%d/%Y') AS 'Date Sent' FROM tbl_notification WHERE date_sent='" & Format(DateTime.Now, "yyyy/MM/dd") & "'", conn)
            Dim da As New MySqlDataAdapter
            da.SelectCommand = comm
            Dim dt As New DataTable
            dt.Clear()

            da.Fill(dt)
            dgvNotification.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        export_file(dgvNotification, "notification")
    End Sub

    Private Sub filteredSearch()
        Try
            If cmbFilter.Text = "Current Date" Then
                comm = New MySqlCommand("SELECT notification_type AS 'Notification Type', sent_to AS 'Sent To', message_content AS 'Message Content', DATE_FORMAT(date_sent, '%m/%d/%Y') AS 'Date Sent' FROM tbl_notification WHERE date_sent='" & Format(DateTime.Now, "yyyy/MM/dd") & "'", conn)
            ElseIf cmbFilter.Text = "By Type" Then
                comm = New MySqlCommand("SELECT notification_type AS 'Notification Type', sent_to AS 'Sent To', message_content AS 'Message Content', DATE_FORMAT(date_sent, '%m/%d/%Y') AS 'Date Sent' FROM tbl_notification WHERE notification_type='" & cmbType.Text & "'", conn)
            ElseIf cmbFilter.Text = "By Date" Then
                comm = New MySqlCommand("SELECT notification_type AS 'Notification Type', sent_to AS 'Sent To', message_content AS 'Message Content', DATE_FORMAT(date_sent, '%m/%d/%Y') AS 'Date Sent' FROM tbl_notification WHERE date_sent BETWEEN '" & Format(dtpDateFrom.Value, "yyyy/MM/dd") & "' AND '" & Format(dtpDateTo.Value, "yyyy/MM/dd") & "'", conn)
            End If

            Dim da As New MySqlDataAdapter
            da.SelectCommand = comm
            Dim dt As New DataTable
            dt.Clear()

            da.Fill(dt)
            dgvNotification.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        filteredSearch()
    End Sub

    Private Sub cmbFilter_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbFilter.SelectedValueChanged
        If cmbFilter.Text = "Current Date" Then
            dtpDateFrom.Enabled = False
            dtpDateTo.Enabled = False
            cmbType.Enabled = False
        ElseIf cmbFilter.Text = "By Type" Then
            dtpDateFrom.Enabled = False
            dtpDateTo.Enabled = False
            cmbType.Enabled = True
        ElseIf cmbFilter.Text = "By Date" Then
            dtpDateFrom.Enabled = True
            dtpDateTo.Enabled = True
            cmbType.Enabled = False
        End If
    End Sub

    Private Sub chkboxAutoSearch_CheckedChanged(sender As Object, e As EventArgs) Handles chkboxAutoSearch.CheckedChanged
        If chkboxAutoSearch.Checked = True Then
            btnSearch.Enabled = False
        Else
            btnSearch.Enabled = True
        End If
    End Sub


    Private Sub dtpDateFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateFrom.ValueChanged
        If chkboxAutoSearch.Checked = True Then
            filteredSearch()
        End If
    End Sub

    Private Sub dtpDateTo_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateTo.ValueChanged
        If chkboxAutoSearch.Checked = True Then
            filteredSearch()
        End If
    End Sub

    Private Sub uctrl_view_notification_logs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDateFrom.Value = Date.Now
        dtpDateTo.Value = Date.Now
        displayLogs()
    End Sub

    Private Sub cmbType_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedValueChanged
        If chkboxAutoSearch.Checked = True Then
            filteredSearch()
        End If
    End Sub
End Class
