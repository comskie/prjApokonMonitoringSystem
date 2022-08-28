Imports MySql.Data.MySqlClient
Public Class uctrl_mystudent_logs
    Private Sub uctrl_mystudent_logs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDateFrom.Value = Date.Now
        dtpDateTo.Value = Date.Now
        displaySection()
    End Sub

    Private Sub displayLogs()
        Try
            comm = New MySqlCommand("SELECT c.id AS 'Log ID', b.lrn AS 'LRN', CONCAT(b.fname, ' ', LEFT(b.mname, 1), '. ', b.lname) AS 'Student Name', d.section_name AS 'Section', timeIN_AM AS 'TimeIN (AM)', c.timeOUT_AM AS 'TimeOUT (AM)', c.timeIN_PM AS 'TimeIN (PM)', c.timeOUT_PM AS 'TimeOUT (PM)', c.logcurrent_date AS 'Date'  FROM tbl_student_section a, tbl_student b, tbl_logs c, tbl_section d, tbl_teacher_section e, tbl_teacher f  WHERE b.lrn = c.lrn AND a.section_id = d.section_id AND a.student_id = c.lrn AND e.teacher_id = f.teacher_id AND e.section_id = d.section_id AND c.logcurrent_date ='" & Format(DateTime.Now, "yyyy/MM/dd") & "' AND d.section_name = '" & cmbSection.Text & "'", conn)

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
                comm = New MySqlCommand("SELECT c.id AS 'Log ID', b.lrn AS 'LRN', CONCAT(b.fname, ' ', LEFT(b.mname, 1), '. ', b.lname) AS 'Student Name', d.section_name AS 'Section', timeIN_AM AS 'TimeIN (AM)', c.timeOUT_AM AS 'TimeOUT (AM)', c.timeIN_PM AS 'TimeIN (PM)', c.timeOUT_PM AS 'TimeOUT (PM)', c.logcurrent_date AS 'Date'  FROM tbl_student_section a, tbl_student b, tbl_logs c, tbl_section d, tbl_teacher_section e, tbl_teacher f  WHERE b.lrn = c.lrn AND a.section_id = d.section_id AND a.student_id = c.lrn AND e.teacher_id = f.teacher_id AND e.section_id = d.section_id AND c.logcurrent_date = '" & Format(DateTime.Now, "yyyy/MM/dd") & "' AND d.section_name = '" & cmbSection.Text & "'", conn)
            ElseIf cmbFilter.Text = "By LRN" Then
                comm = New MySqlCommand("SELECT c.id AS 'Log ID', b.lrn AS 'LRN', CONCAT(b.fname, ' ', LEFT(b.mname, 1), '. ', b.lname) AS 'Student Name', d.section_name AS 'Section', timeIN_AM AS 'TimeIN (AM)', c.timeOUT_AM AS 'TimeOUT (AM)', c.timeIN_PM AS 'TimeIN (PM)', c.timeOUT_PM AS 'TimeOUT (PM)', c.logcurrent_date AS 'Date'  FROM tbl_student_section a, tbl_student b, tbl_logs c, tbl_section d, tbl_teacher_section e, tbl_teacher f  WHERE b.lrn = c.lrn AND a.section_id = d.section_id AND a.student_id = c.lrn AND e.teacher_id = f.teacher_id AND e.section_id = d.section_id AND c.logcurrent_date ='" & Format(DateTime.Now, "yyyy/MM/dd") & "' AND b.lrn LIKE '%" + txtSearchBox.Text + "%' AND d.section_name = '" & cmbSection.Text & "'", conn)
            ElseIf cmbFilter.Text = "By Date" Then
                comm = New MySqlCommand("SELECT c.id AS 'Log ID', b.lrn AS 'LRN', CONCAT(b.fname, ' ', LEFT(b.mname, 1), '. ', b.lname) AS 'Student Name', d.section_name AS 'Section', timeIN_AM AS 'TimeIN (AM)', c.timeOUT_AM AS 'TimeOUT (AM)', c.timeIN_PM AS 'TimeIN (PM)', c.timeOUT_PM AS 'TimeOUT (PM)', c.logcurrent_date AS 'Date'  FROM tbl_student_section a, tbl_student b, tbl_logs c, tbl_section d, tbl_teacher_section e, tbl_teacher f  WHERE b.lrn = c.lrn AND a.section_id = d.section_id AND a.student_id = c.lrn AND e.teacher_id = f.teacher_id AND e.section_id = d.section_id AND c.logcurrent_date BETWEEN '" & Format(dtpDateFrom.Value, "yyyy/MM/dd") & "' AND '" & Format(dtpDateTo.Value, "yyyy/MM/dd") & "' AND d.section_name = '" & cmbSection.Text & "'", conn)
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


    Private Sub displaySection()
        Try
            conn.Open()
            comm = New MySqlCommand("SELECT section_name  From tbl_teacher_section a, tbl_section b, tbl_teacher c Where a.teacher_id = c.teacher_id And a.section_id = b.section_id And a.teacher_id = '" & teacherID & "' And c.teacher_id = '" & teacherID & "'", conn)
            adapter = New MySqlDataAdapter(comm)
            Dim table As New DataTable()
            adapter.Fill(table)

            If table.Rows.Count > 0 Then
                cmbSection.DataSource = table
                cmbSection.DisplayMember = "section_name"
                cmbSection.ValueMember = ""
            End If


        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
        conn.Close()
    End Sub

    Private Sub cmbSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSection.SelectedValueChanged
        If chkboxAutoSearch.Checked = True Then
            filteredSearch()
        End If
    End Sub
End Class
