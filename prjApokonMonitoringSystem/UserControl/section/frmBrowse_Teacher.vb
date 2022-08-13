Imports MySql.Data.MySqlClient
Public Class frmBrowse_Teacher
    Public tuname As String
    Public tname As String
    Private Sub frmBrowse_Teacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayStudent()
    End Sub
    Private Sub displayStudent()
        Try
            comm = New MySqlCommand("SELECT * FROM tbl_teacher", conn)

            Dim da As New MySqlDataAdapter
            da.SelectCommand = comm
            Dim dt As New DataTable
            dt.Clear()

            da.Fill(dt)
            dgvTeacher.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub filteredSearch()
        Try
            If cmbFilter.Text = "All" Then
                comm = New MySqlCommand("SELECT * FROM tbl_teacher", conn)
            ElseIf cmbFilter.Text = "By Name" Then
                comm = New MySqlCommand("SELECT * FROM tbl_teacher WHERE fname LIKE '%" + txtSearchBox.Text + "%' OR mname LIKE '%" + txtSearchBox.Text + "%' OR lname LIKE '%" + txtSearchBox.Text + "%'", conn)
            ElseIf cmbFilter.Text = "By Gender" Then
                comm = New MySqlCommand("SELECT * FROM tbl_teacher WHERE gender = '" & cmbGender.Text & "'", conn)
            End If

            Dim da As New MySqlDataAdapter
            da.SelectCommand = comm
            Dim dt As New DataTable
            dt.Clear()

            da.Fill(dt)
            dgvTeacher.DataSource = dt
        Catch ex As Exception
        End Try
        conn.Close()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        filteredSearch()
    End Sub

    Private Sub chkboxAutoSearch_CheckedChanged(sender As Object, e As EventArgs) Handles chkboxAutoSearch.CheckedChanged
        If chkboxAutoSearch.Checked = True Then
            btnSearch.Enabled = False
        Else
            btnSearch.Enabled = True
        End If
    End Sub

    Private Sub cmbFilter_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbFilter.SelectedValueChanged
        If cmbFilter.Text = "All" Then
            txtSearchBox.Enabled = False
            cmbGender.Enabled = False
            txtSearchBox.Clear()
        ElseIf cmbFilter.Text = "By Name" Then
            cmbGender.Enabled = False
            txtSearchBox.Enabled = True
        ElseIf cmbFilter.Text = "By Gender" Then
            cmbGender.Enabled = True
            txtSearchBox.Enabled = False
            txtSearchBox.Clear()
        End If
    End Sub

    Private Sub txtSearchBox_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBox.TextChanged
        If chkboxAutoSearch.Checked = True Then
            filteredSearch()
        End If
    End Sub

    Private Sub cmbGender_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbGender.SelectedValueChanged
        If chkboxAutoSearch.Checked = True Then
            filteredSearch()
        End If
    End Sub

    Private Sub dgvTeacher_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTeacher.CellClick
        Dim colName As String = dgvTeacher.Columns(e.ColumnIndex).Name
        Dim selectedRow As DataGridViewRow
        Dim index As Integer
        Try
            index = e.RowIndex
            selectedRow = dgvTeacher.Rows(index)

            Dim dialogResult As DialogResult = MessageBox.Show("Do you want to select " + dgvTeacher.SelectedCells.Item(2).Value.ToString + "?", "Browse Patient", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dialogResult = DialogResult.Yes Then
                tuname = selectedRow.Cells(1).Value.ToString
                tname = selectedRow.Cells(2).Value.ToString + " " + selectedRow.Cells(3).Value.ToString + " " + selectedRow.Cells(4).Value.ToString
                Me.Close()
            Else
                tuname = ""
                tname = ""
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmBrowse_Teacher_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Close()
    End Sub
End Class