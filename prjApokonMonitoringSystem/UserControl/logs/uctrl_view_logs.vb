Imports MySql.Data.MySqlClient
Public Class uctrl_view_logs
    Private Sub uctrl_view_logs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDateFrom.Value = Date.Now
        dtpDateTo.Value = Date.Now
        displayLogs()
    End Sub
    Private Sub displayLogs()
        Try
            comm = New MySqlCommand("SELECT lrn AS 'LRN', timeIN_AM AS 'TimeIN AM', timeOUT_AM AS 'TimeOUT AM', timeIN_PM AS 'TimeIN PM', timeOUT_PM AS 'TimeOUT PM', DATE_FORMAT(logcurrent_date, '%m/%d/%Y') AS 'Log Date' FROM tbl_logs WHERE logcurrent_date='" & Format(DateTime.Now, "yyyy/MM/dd") & "'", conn)

            Dim da As New MySqlDataAdapter
            da.SelectCommand = comm
            Dim dt As New DataTable
            dt.Clear()

            da.Fill(dt)
            dgvLogs.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        export_file(dgvLogs, "logs")
    End Sub

    Private Sub filteredSearch()
        Try
            If cmbFilter.Text = "Current Date" Then
                comm = New MySqlCommand("SELECT lrn AS 'LRN', timeIN_AM AS 'TimeIN AM', timeOUT_AM AS 'TimeOUT AM', timeIN_PM AS 'TimeIN PM', timeOUT_PM AS 'TimeOUT PM', DATE_FORMAT(logcurrent_date, '%m/%d/%Y') AS 'Log Date' FROM tbl_logs WHERE logcurrent_date='" & Format(DateTime.Now, "yyyy/MM/dd") & "'", conn)
            ElseIf cmbFilter.Text = "By LRN" Then
                comm = New MySqlCommand("SELECT lrn AS 'LRN', timeIN_AM AS 'TimeIN AM', timeOUT_AM AS 'TimeOUT AM', timeIN_PM AS 'TimeIN PM', timeOUT_PM AS 'TimeOUT PM', DATE_FORMAT(logcurrent_date, '%m/%d/%Y') AS 'Log Date' FROM tbl_logs WHERE lrn LIKE '%" + txtSearchBox.Text + "%'", conn)
            ElseIf cmbFilter.Text = "By Date" Then
                comm = New MySqlCommand("SELECT lrn AS 'LRN', timeIN_AM AS 'TimeIN AM', timeOUT_AM AS 'TimeOUT AM', timeIN_PM AS 'TimeIN PM', timeOUT_PM AS 'TimeOUT PM', DATE_FORMAT(logcurrent_date, '%m/%d/%Y') AS 'Log Date' FROM tbl_logs WHERE logcurrent_date BETWEEN '" & Format(dtpDateFrom.Value, "yyyy/MM/dd") & "' AND '" & Format(dtpDateTo.Value, "yyyy/MM/dd") & "'", conn)
            End If

            Dim da As New MySqlDataAdapter
            da.SelectCommand = comm
            Dim dt As New DataTable
            dt.Clear()

            da.Fill(dt)
            dgvLogs.DataSource = dt
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
            txtSearchBox.Enabled = False
            txtSearchBox.Clear()
        ElseIf cmbFilter.Text = "By LRN" Then
            dtpDateFrom.Enabled = False
            dtpDateTo.Enabled = False
            txtSearchBox.Enabled = True
        ElseIf cmbFilter.Text = "By Date" Then
            dtpDateFrom.Enabled = True
            dtpDateTo.Enabled = True
            txtSearchBox.Enabled = False
            txtSearchBox.Clear()
        End If
    End Sub

    Private Sub chkboxAutoSearch_CheckedChanged(sender As Object, e As EventArgs) Handles chkboxAutoSearch.CheckedChanged
        If chkboxAutoSearch.Checked = True Then
            btnSearch.Enabled = False
        Else
            btnSearch.Enabled = True
        End If
    End Sub

    Private Sub txtSearchBox_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBox.TextChanged
        If chkboxAutoSearch.Checked = True Then
            filteredSearch()
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
End Class
