Imports MySql.Data.MySqlClient
Imports System.IO
Public Class uctrl_mystudent
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

    Private Sub displayStudent()
        Try
            comm = New MySqlCommand("SELECT d.id AS 'ID', d.lrn AS 'LRN', d.fname AS 'First Name', d.mname AS 'Middle Name', d.lname AS 'Last Name', d.gender AS 'Gender', d.address AS 'Address', d.parent_name AS 'Parent Name', d.contact_number AS 'Contact Number', d.email_address AS 'Email Address', e.section_name AS 'Section', d.display_picture AS 'Display Picture' FROM tbl_teacher a, tbl_teacher_section b, tbl_student_section c, tbl_student d, tbl_section e WHERE c.student_id = d.lrn AND c.section_id = e.section_id AND b.teacher_id = a.teacher_id AND b.section_id = e.section_id AND e.section_name = '" & cmbSection.Text & "' ORDER BY d.id ASC", conn)

            Dim da As New MySqlDataAdapter
            da.SelectCommand = comm
            Dim dt As New DataTable
            dt.Clear()

            da.Fill(dt)
            dgvStudent.DataSource = dt
            Dim imgColumn = DirectCast(dgvStudent.Columns(14), DataGridViewImageColumn)
            imgColumn.ImageLayout = DataGridViewImageCellLayout.Stretch

        Catch ex As Exception
        End Try
        conn.Close()
    End Sub

    Private Sub filteredSearch()
        Try
            If cmbFilter.Text = "All" Then
                comm = New MySqlCommand("SELECT d.id AS 'ID', d.lrn AS 'LRN', d.fname AS 'First Name', d.mname AS 'Middle Name', d.lname AS 'Last Name', d.gender AS 'Gender', d.address AS 'Address', d.parent_name AS 'Parent Name', d.contact_number AS 'Contact Number', d.email_address AS 'Email Address', e.section_name AS 'Section', d.display_picture AS 'Display Picture' FROM tbl_teacher a, tbl_teacher_section b, tbl_student_section c, tbl_student d, tbl_section e WHERE c.student_id = d.lrn AND c.section_id = e.section_id AND b.teacher_id = a.teacher_id AND b.section_id = e.section_id AND e.section_name = '" & cmbSection.Text & "' ORDER BY d.id ASC", conn)
            ElseIf cmbFilter.Text = "By Name" Then
                comm = New MySqlCommand("SELECT d.id AS 'ID', d.lrn AS 'LRN', d.fname AS 'First Name', d.mname AS 'Middle Name', d.lname AS 'Last Name', d.gender AS 'Gender', d.address AS 'Address', d.parent_name AS 'Parent Name', d.contact_number AS 'Contact Number', d.email_address AS 'Email Address', e.section_name AS 'Section', d.display_picture AS 'Display Picture' FROM tbl_teacher a, tbl_teacher_section b, tbl_student_section c, tbl_student d, tbl_section e WHERE c.student_id = d.lrn AND c.section_id = e.section_id AND b.teacher_id = a.teacher_id AND b.section_id = e.section_id AND e.section_name = '" & cmbSection.Text & "' AND (d.fname LIKE '%" + txtSearchBox.Text + "%' OR d.mname LIKE '%" + txtSearchBox.Text + "%' OR d.lname LIKE '%" + txtSearchBox.Text + "%') ORDER BY d.id ASC", conn)
            ElseIf cmbFilter.Text = "By Gender" Then
                comm = New MySqlCommand("SELECT d.id AS 'ID', d.lrn AS 'LRN', d.fname AS 'First Name', d.mname AS 'Middle Name', d.lname AS 'Last Name', d.gender AS 'Gender', d.address AS 'Address', d.parent_name AS 'Parent Name', d.contact_number AS 'Contact Number', d.email_address AS 'Email Address', e.section_name AS 'Section', d.display_picture AS 'Display Picture' FROM tbl_teacher a, tbl_teacher_section b, tbl_student_section c, tbl_student d, tbl_section e WHERE c.student_id = d.lrn AND c.section_id = e.section_id AND b.teacher_id = a.teacher_id AND b.section_id = e.section_id AND e.section_name = '" & cmbSection.Text & "' AND d.gender = '" & cmbGender.Text & "'", conn)
            ElseIf cmbFilter.Text = "By LRN" Then
                comm = New MySqlCommand("SELECT d.id AS 'ID', d.lrn AS 'LRN', d.fname AS 'First Name', d.mname AS 'Middle Name', d.lname AS 'Last Name', d.gender AS 'Gender', d.address AS 'Address', d.parent_name AS 'Parent Name', d.contact_number AS 'Contact Number', d.email_address AS 'Email Address', e.section_name AS 'Section', d.display_picture AS 'Display Picture' FROM tbl_teacher a, tbl_teacher_section b, tbl_student_section c, tbl_student d, tbl_section e WHERE c.student_id = d.lrn AND c.section_id = e.section_id AND b.teacher_id = a.teacher_id AND b.section_id = e.section_id AND e.section_name = '" & cmbSection.Text & "' AND d.lrn LIKE '%" + txtSearchBox.Text + "%'", conn)
            End If

            Dim da As New MySqlDataAdapter
            da.SelectCommand = comm
            Dim dt As New DataTable
            dt.Clear()

            da.Fill(dt)
            dgvStudent.DataSource = dt
            Dim imgColumn = DirectCast(dgvStudent.Columns(14), DataGridViewImageColumn)
            imgColumn.ImageLayout = DataGridViewImageCellLayout.Stretch

        Catch ex As Exception
        End Try
        conn.Close()
    End Sub

    Private Sub uctrl_mystudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displaySection()
    End Sub

    Private Sub cmbSection_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbSection.SelectedValueChanged
        If cmbSection.Text = String.Empty Then
            cmbFilter.Enabled = False
            txtSearchBox.Enabled = False
            cmbGender.Enabled = False
        Else
            cmbFilter.Enabled = True
            txtSearchBox.Enabled = True
            cmbGender.Enabled = True
            If chkboxAutoSearch.Checked = True Then
                filteredSearch()
            End If
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        filteredSearch()
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
        ElseIf cmbFilter.Text = "By LRN" Then
            cmbGender.Enabled = False
            txtSearchBox.Enabled = True
        End If
    End Sub

    Private Sub chkboxAutoSearch_CheckedChanged(sender As Object, e As EventArgs) Handles chkboxAutoSearch.CheckedChanged
        If chkboxAutoSearch.Checked = True Then
            btnSearch.Enabled = False
        Else
            btnSearch.Enabled = True
        End If
    End Sub

    Private Sub cmbGender_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbGender.SelectedValueChanged
        If chkboxAutoSearch.Checked = True Then
            filteredSearch()
        End If
    End Sub

    Private Sub txtSearchBox_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBox.TextChanged
        If chkboxAutoSearch.Checked = True Then
            filteredSearch()
        End If
    End Sub

    Private Sub dgvStudent_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudent.CellClick
        Dim colName As String = dgvStudent.Columns(e.ColumnIndex).Name
        Dim selectedRow As New DataGridViewRow
        Dim index As New Integer
        Try
            index = e.RowIndex
            selectedRow = dgvStudent.Rows(index)
            If colName = "action_view" Then
                With frm_view_student
                    .txtLRN.Text = selectedRow.Cells(4).Value.ToString
                    .txtFname.Text = selectedRow.Cells(5).Value.ToString
                    .txtMname.Text = selectedRow.Cells(6).Value.ToString
                    .txtLname.Text = selectedRow.Cells(7).Value.ToString
                    If selectedRow.Cells(8).Value.ToString = "Male" Then
                        .cmbGender.SelectedIndex = 0
                    Else
                        .cmbGender.SelectedIndex = 1
                    End If

                    .txtAddress.Text = selectedRow.Cells(9).Value.ToString
                    .txtParent.Text = selectedRow.Cells(10).Value.ToString
                    .txtContactNo.Text = selectedRow.Cells(11).Value.ToString
                    .txtEmail.Text = selectedRow.Cells(12).Value.ToString
                    .txtSection.Text = selectedRow.Cells(13).Value.ToString
                    Dim img() As Byte = selectedRow.Cells(14).Value
                    Dim ms As New MemoryStream(img)
                    .ProfileContainer.Image = Image.FromStream(ms)
                    .ShowDialog()
                End With
            ElseIf colName = "action_edit" Then
                With frm_edit_student
                    .txtID.Text = selectedRow.Cells(3).Value.ToString
                    .txtLRN.Text = selectedRow.Cells(4).Value.ToString
                    .txtFname.Text = selectedRow.Cells(5).Value.ToString
                    .txtMname.Text = selectedRow.Cells(6).Value.ToString
                    .txtLname.Text = selectedRow.Cells(7).Value.ToString
                    If selectedRow.Cells(8).Value.ToString = "Male" Then
                        .cmbGender.SelectedIndex = 0
                    Else
                        .cmbGender.SelectedIndex = 1
                    End If

                    .txtAddress.Text = selectedRow.Cells(9).Value.ToString
                    .txtParent.Text = selectedRow.Cells(10).Value.ToString
                    .txtContactNo.Text = selectedRow.Cells(11).Value.ToString
                    .txtEmail.Text = selectedRow.Cells(12).Value.ToString
                    .txtSection.Text = selectedRow.Cells(13).Value.ToString
                    Dim img() As Byte = selectedRow.Cells(14).Value
                    Dim ms As New MemoryStream(img)
                    .ProfileContainer.Image = Image.FromStream(ms)
                    .ShowDialog()
                End With
                displayStudent()
            ElseIf colName = "action_delete" Then
                Dim dialogResult As DialogResult = MessageBox.Show("Do you want to delete this student?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If dialogResult = DialogResult.Yes Then
                    deleteStudent(selectedRow.Cells(4).Value.ToString)
                    displayStudent()
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub deleteStudent(sLRN As String)
        Try
            conn.Open()
            comm = New MySqlCommand("DELETE FROM tbl_student WHERE lrn = @slrn", conn)
            comm.Parameters.Add("@slrn", MySqlDbType.VarChar).Value = sLRN

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

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        export_file(dgvStudent, "section")
    End Sub

    Private Sub cmbSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSection.SelectedValueChanged
        If chkboxAutoSearch.Checked = True Then
            filteredSearch()
        End If
    End Sub
End Class
