Imports MySql.Data.MySqlClient
Public Class frmBrowse_Section
    Public ssection As String
    Public ssname As String
    Private Sub frmBrowse_Section_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayStudent()
    End Sub

    Private Sub displayStudent()
        Try

            comm = New MySqlCommand("SELECT * FROM tbl_section", conn)

            Dim da As New MySqlDataAdapter
            da.SelectCommand = comm
            Dim dt As New DataTable
            dt.Clear()

            da.Fill(dt)
            dgvSection.DataSource = dt

        Catch ex As Exception
        End Try
        conn.Close()
    End Sub

    Private Sub filteredSearch()
        Try
            If cmbFilter.Text = "All" Then
                comm = New MySqlCommand("SELECT * FROM tbl_section", conn)
            ElseIf cmbFilter.Text = "By Section" Then
                comm = New MySqlCommand("SELECT * FROM tbl_section WHERE section_name LIKE '%" + txtSearchBox.Text + "%'", conn)
            ElseIf cmbFilter.Text = "By Grade Level" Then
                comm = New MySqlCommand("SELECT * FROM tbl_section WHERE year_level LIKE '%" + cmbYearLevel.Text + "%'", conn)
            End If

            Dim da As New MySqlDataAdapter
            da.SelectCommand = comm
            Dim dt As New DataTable
            dt.Clear()

            da.Fill(dt)
            dgvSection.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
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

    Private Sub txtSearchBox_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBox.TextChanged
        If chkboxAutoSearch.Checked = True Then
            filteredSearch()
        End If
    End Sub

    Private Sub cmbYearLevel_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbYearLevel.SelectedValueChanged
        If chkboxAutoSearch.Checked = True Then
            filteredSearch()
        End If
    End Sub

    Private Sub cmbFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilter.SelectedIndexChanged
        If cmbFilter.Text = "All" Then
            txtSearchBox.Enabled = False
            cmbYearLevel.SelectedIndex = -1
            cmbYearLevel.Enabled = False
            txtSearchBox.Clear()
        ElseIf cmbFilter.Text = "By Section" Then
            txtSearchBox.Enabled = True
            cmbYearLevel.Enabled = False
            cmbYearLevel.SelectedIndex = -1
        ElseIf cmbFilter.Text = "By Grade Level" Then
            txtSearchBox.Enabled = False
            cmbYearLevel.Enabled = True
            txtSearchBox.Clear()
        End If
    End Sub

    Private Sub dgvSection_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSection.CellClick
        Dim colName As String = dgvSection.Columns(e.ColumnIndex).Name
        Dim selectedRow As DataGridViewRow
        Dim index As Integer
        Try
            index = e.RowIndex
            selectedRow = dgvSection.Rows(index)

            Dim dialogResult As DialogResult = MessageBox.Show("Do you want to select " + dgvSection.SelectedCells.Item(2).Value.ToString + "?", "Browse Section", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dialogResult = DialogResult.Yes Then
                ssection = selectedRow.Cells(1).Value.ToString
                ssname = selectedRow.Cells(2).Value.ToString
                Me.Close()
            Else
                ssection = ""
                ssname = ""
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmBrowse_Section_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Close()
    End Sub
End Class