Imports MySql.Data.MySqlClient
Public Class uctrl_section_list
    Private Sub uctrl_section_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displaySection()
    End Sub

    Private Sub displaySection()
        Try
            comm = New MySqlCommand("SELECT c.id AS 'ID', c.section_id AS 'Section ID', c.section_name AS 'Section Name', c.year_level AS 'Year Level', c.academic_year AS 'Academic Year', CONCAT(b.fname, ' ', LEFT(b.mname, 1), '. ', b.lname) AS 'Handled By' FROM tbl_teacher_section a, tbl_teacher b, tbl_section c WHERE a.teacher_id = b.teacher_id AND a.section_id = c.section_id", conn)

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
                comm = New MySqlCommand("SELECT c.id AS 'ID', c.section_id AS 'Section ID', c.section_name AS 'Section Name', c.year_level AS 'Year Level', c.academic_year AS 'Academic Year', CONCAT(b.fname, ' ', LEFT(b.mname, 1), '. ', b.lname) AS 'Handled By' FROM tbl_teacher_section a, tbl_teacher b, tbl_section c WHERE a.teacher_id = b.teacher_id AND a.section_id = c.section_id", conn)
            ElseIf cmbFilter.Text = "By Section" Then
                comm = New MySqlCommand("SELECT c.id AS 'ID', c.section_id AS 'Section ID', c.section_name AS 'Section Name', c.year_level AS 'Year Level', c.academic_year AS 'Academic Year', CONCAT(b.fname, ' ', LEFT(b.mname, 1), '. ', b.lname) AS 'Handled By' FROM tbl_teacher_section a, tbl_teacher b, tbl_section c WHERE a.teacher_id = b.teacher_id AND a.section_id = c.section_id AND c.section_name LIKE '%" + txtSearchBox.Text + "%'", conn)
            ElseIf cmbFilter.Text = "By Grade Level" Then
                comm = New MySqlCommand("SELECT c.id AS 'ID', c.section_id AS 'Section ID', c.section_name AS 'Section Name', c.year_level AS 'Year Level', c.academic_year AS 'Academic Year', CONCAT(b.fname, ' ', LEFT(b.mname, 1), '. ', b.lname) AS 'Handled By' FROM tbl_teacher_section a, tbl_teacher b, tbl_section c WHERE a.teacher_id = b.teacher_id AND a.section_id = c.section_id AND c.year_level LIKE '%" + cmbYearLevel.Text + "%'", conn)
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

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        export_file(dgvSection, "section")
    End Sub

    Private Sub dgvSection_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSection.CellClick
        Dim colName As String = dgvSection.Columns(e.ColumnIndex).Name
        Dim selectedRow As New DataGridViewRow
        Dim index As New Integer
        Try
            index = e.RowIndex
            selectedRow = dgvSection.Rows(index)
            If colName = "action_view" Then
                With frm_view_section
                    .txtID.Text = selectedRow.Cells(4).Value.ToString
                    .txtSectionName.Text = selectedRow.Cells(5).Value.ToString
                    If selectedRow.Cells(6).Value.ToString = "Kinder 1" Then
                        .cmbYearLevel.SelectedIndex = 0
                    ElseIf selectedRow.Cells(6).Value.ToString = "Kinder 2" Then
                        .cmbYearLevel.SelectedIndex = 1
                    ElseIf selectedRow.Cells(6).Value.ToString = "Grade 1" Then
                        .cmbYearLevel.SelectedIndex = 2
                    ElseIf selectedRow.Cells(6).Value.ToString = "Grade 2" Then
                        .cmbYearLevel.SelectedIndex = 3
                    ElseIf selectedRow.Cells(6).Value.ToString = "Grade 3" Then
                        .cmbYearLevel.SelectedIndex = 4
                    ElseIf selectedRow.Cells(6).Value.ToString = "Grade 4" Then
                        .cmbYearLevel.SelectedIndex = 5
                    ElseIf selectedRow.Cells(6).Value.ToString = "Grade 5" Then
                        .cmbYearLevel.SelectedIndex = 6
                    ElseIf selectedRow.Cells(6).Value.ToString = "Grade 6" Then
                        .cmbYearLevel.SelectedIndex = 7
                    End If
                    .ShowDialog()
                End With
            ElseIf colName = "action_edit" Then
                With frm_edit_section
                    .txtColID.Text = selectedRow.Cells(3).Value.ToString
                    .txtSID.Text = selectedRow.Cells(4).Value.ToString
                    .txtSectionName.Text = selectedRow.Cells(5).Value.ToString
                    .txtTeacher.Text = selectedRow.Cells(8).Value.ToString
                    .prevTeacher.Text = selectedRow.Cells(8).Value.ToString
                    If selectedRow.Cells(6).Value.ToString = "Kinder 1" Then
                        .cmbYearLevel.SelectedIndex = 0
                    ElseIf selectedRow.Cells(6).Value.ToString = "Kinder 2" Then
                        .cmbYearLevel.SelectedIndex = 1
                    ElseIf selectedRow.Cells(6).Value.ToString = "Grade 1" Then
                        .cmbYearLevel.SelectedIndex = 2
                    ElseIf selectedRow.Cells(6).Value.ToString = "Grade 2" Then
                        .cmbYearLevel.SelectedIndex = 3
                    ElseIf selectedRow.Cells(6).Value.ToString = "Grade 3" Then
                        .cmbYearLevel.SelectedIndex = 4
                    ElseIf selectedRow.Cells(6).Value.ToString = "Grade 4" Then
                        .cmbYearLevel.SelectedIndex = 5
                    ElseIf selectedRow.Cells(6).Value.ToString = "Grade 5" Then
                        .cmbYearLevel.SelectedIndex = 6
                    ElseIf selectedRow.Cells(6).Value.ToString = "Grade 6" Then
                        .cmbYearLevel.SelectedIndex = 7
                    End If
                    .ShowDialog()
                End With
                displaySection()
            ElseIf colName = "action_delete" Then
                Dim dialogResult As DialogResult = MessageBox.Show("Do you want to delete this section?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If dialogResult = DialogResult.Yes Then
                    deleteSection(selectedRow.Cells(3).Value.ToString)
                    displaySection()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub deleteSection(sID As String)
        Try
            conn.Open()
            comm = New MySqlCommand("DELETE FROM tbl_section WHERE id = @sid", conn)
            comm.Parameters.Add("@sid", MySqlDbType.VarChar).Value = sID

            adapter = New MySqlDataAdapter(comm)
            comm.ExecuteNonQuery()
            MessageBox.Show("Record Deleted")
            conn.Close()
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
        conn.Close()
    End Sub
End Class
