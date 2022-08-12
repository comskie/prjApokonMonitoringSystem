Imports MySql.Data.MySqlClient
Public Class frmBrowse_Student
    Public slrn As String
    Public semail As String
    Public sname As String
    Private Sub dgvStudent_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudent.CellClick
        Dim colName As String = dgvStudent.Columns(e.ColumnIndex).Name
        Dim selectedRow As DataGridViewRow
        Dim index As Integer
        Try
            index = e.RowIndex
            selectedRow = dgvStudent.Rows(index)

            Dim dialogResult As DialogResult = MessageBox.Show("Do you want to select " + dgvStudent.SelectedCells.Item(1).Value.ToString + "?", "Browse Patient", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dialogResult = DialogResult.Yes Then
                slrn = selectedRow.Cells(0).Value.ToString
                sname = selectedRow.Cells(2).Value.ToString + " " + selectedRow.Cells(3).Value.ToString + " " + selectedRow.Cells(4).Value.ToString
                semail = selectedRow.Cells(9).Value.ToString
                Me.Close()
            Else
                slrn = ""
                semail = ""
                sname = ""
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmBrowse_Student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayStudent()
    End Sub

    Private Sub displayStudent()
        Try
            comm = New MySqlCommand("SELECT * FROM tbl_student", conn)

            Dim da As New MySqlDataAdapter
            da.SelectCommand = comm
            Dim dt As New DataTable
            dt.Clear()

            da.Fill(dt)
            dgvStudent.DataSource = dt
            Dim imgColumn = DirectCast(dgvStudent.Columns(10), DataGridViewImageColumn)
            imgColumn.ImageLayout = DataGridViewImageCellLayout.Stretch
        Catch ex As Exception
        End Try
        conn.Close()
    End Sub

    Private Sub filteredSearch()
        Try
            If cmbFilter.Text = "All" Then
                comm = New MySqlCommand("SELECT * FROM tbl_student", conn)
            ElseIf cmbFilter.Text = "By Name" Then
                comm = New MySqlCommand("SELECT * FROM tbl_student WHERE fname LIKE '%" + txtSearchBox.Text + "%' OR mname LIKE '%" + txtSearchBox.Text + "%' OR lname LIKE '%" + txtSearchBox.Text + "%'", conn)
            ElseIf cmbFilter.Text = "By Gender" Then
                comm = New MySqlCommand("SELECT * FROM tbl_student WHERE gender = '" & cmbGender.Text & "'", conn)
            ElseIf cmbFilter.Text = "By LRN" Then
                comm = New MySqlCommand("SELECT * FROM tbl_student WHERE lrn LIKE '%" + txtSearchBox.Text + "%'", conn)
            End If

            Dim da As New MySqlDataAdapter
            da.SelectCommand = comm
            Dim dt As New DataTable
            dt.Clear()

            da.Fill(dt)
            dgvStudent.DataSource = dt
            Dim imgColumn = DirectCast(dgvStudent.Columns(13), DataGridViewImageColumn)
            imgColumn.ImageLayout = DataGridViewImageCellLayout.Stretch

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        filteredSearch()
    End Sub
End Class