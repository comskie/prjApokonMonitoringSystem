Imports MySql.Data.MySqlClient
Imports System.IO
Public Class uctrl_student_list
    Dim pageRows As Integer
    Private Sub uctrl_student_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'Dim numbutton As Integer = 1
        'Dim newbutton As Integer = 1
        'numbutton = Math.Ceiling(count1 / 12)
        'For i = 1 To numbutton
        '    Dim buttonn As New Button
        '    Controls.Add(buttonn)
        '    buttonn.Top = 400
        '    buttonn.Left = newbutton * 70
        '    buttonn.Text = i
        '    buttonn.Name = i
        '    buttonn.BackColor = Color.Azure
        '    newbutton = newbutton + 1
        'Next

        count_rows()

        If CDbl(currentPg.Text) = 1 Or pageRows = 1 Then
            load_data()
        End If

        'displayStudent(1, 5)
    End Sub

    Private Sub count_rows()
        Try
            conn.Open()

            Dim comm As MySqlCommand
            If cmbFilter.Text = "By Name" And txtSearchBox.Text <> String.Empty Then
                comm = New MySqlCommand("SELECT count(*) FROM tbl_student_section c, tbl_student d, tbl_section e WHERE c.student_id = d.lrn AND c.section_id = e.section_id AND d.fname LIKE '%" + txtSearchBox.Text + "%' OR mname LIKE '%" + txtSearchBox.Text + "%' OR lname LIKE '%" + txtSearchBox.Text + "%' ORDER BY d.id ASC", conn)
            ElseIf cmbFilter.Text = "By Name" And txtSearchBox.Text = String.Empty Then
                comm = New MySqlCommand("SELECT count(*) FROM tbl_student_section c, tbl_student d, tbl_section e WHERE c.student_id = d.lrn AND c.section_id = e.section_id ORDER BY d.id ASC", conn)
            ElseIf cmbFilter.Text = "By Gender" Then
                comm = New MySqlCommand("SELECT count(*) FROM tbl_student_section c, tbl_student d, tbl_section e WHERE c.student_id = d.lrn AND c.section_id = e.section_id AND d.gender = '" & cmbGender.Text & "' ORDER BY d.id ASC", conn)
            ElseIf cmbFilter.Text = "By LRN" Then
                comm = New MySqlCommand("SELECT count(*) FROM tbl_student_section c, tbl_student d, tbl_section e WHERE c.student_id = d.lrn AND c.section_id = e.section_id AND d.lrn LIKE '%" + txtSearchBox.Text + "%' ORDER BY d.id ASC", conn)
            ElseIf cmbFilter.Text = "By Section" Then
                comm = New MySqlCommand("SELECT count(*) FROM tbl_student_section c, tbl_student d, tbl_section e WHERE c.student_id = d.lrn AND c.section_id = e.section_id AND d.section LIKE '%" + txtSearchBox.Text + "%' ORDER BY d.id ASC", conn)
            ElseIf cmbFilter.Text = "No Section" Then
                comm = New MySqlCommand("SELECT count(*) FROM tbl_student_section c, tbl_student d WHERE c.student_id = d.lrn AND c.section_id IS NULL ORDER BY d.id ASC", conn)
            Else
                comm = New MySqlCommand("SELECT count(*) FROM tbl_student_section c, tbl_student d, tbl_section e WHERE c.student_id = d.lrn AND c.section_id = e.section_id ORDER BY d.id ASC", conn)
            End If

            Dim count1 = Convert.ToString(comm.ExecuteScalar)
            pageRows = Math.Ceiling(count1 / 10)
            pgRows.Text = pageRows
            conn.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub load_data()
        Try
            Dim f1 As Integer = CDbl(currentPg.Text) * 10 - 10 + 1
            Dim t1 As Integer = CDbl(currentPg.Text) * 10
            Dim cmd As New MySqlCommand(getCommandString(f1, t1), conn)
            Dim da As New MySqlDataAdapter
            da.SelectCommand = cmd
            Dim dt As New DataTable
            da.Fill(dt)
            dgvStudent.DataSource = dt
            Dim imgColumn = DirectCast(dgvStudent.Columns(15), DataGridViewImageColumn)
            imgColumn.ImageLayout = DataGridViewImageCellLayout.Stretch
        Catch ex As Exception

        End Try

    End Sub

    Function getCommandString(val1 As String, val2 As String) As String
        If cmbFilter.Text = "All" Then
            Return "SELECT * FROM(SELECT row_number() Over (Order By d.id) As RowNumber, d.id As 'ID', d.lrn AS 'LRN', d.fname AS 'First Name', d.mname AS 'Middle Name', d.lname AS 'Last Name', d.gender AS 'Gender', d.address AS 'Address', d.parent_name AS 'Parent Name', d.contact_number AS 'Contact Number', d.email_address AS 'Email Address', e.section_name AS 'Section', d.display_picture AS 'Display Picture'  From tbl_student_section c, tbl_student d, tbl_section e Where c.student_id = d.lrn And c.section_id = e.section_id Order By d.id ASC) tablerow WHERE RowNumber BETWEEN '" & val1 & "' And '" & val2 & "'"
        ElseIf cmbFilter.Text = "By Name" And txtSearchBox.Text <> String.Empty Then
            Return "SELECT * FROM(SELECT row_number() Over (Order By d.id) As RowNumber, d.id As 'ID', d.lrn AS 'LRN', d.fname AS 'First Name', d.mname AS 'Middle Name', d.lname AS 'Last Name', d.gender AS 'Gender', d.address AS 'Address', d.parent_name AS 'Parent Name', d.contact_number AS 'Contact Number', d.email_address AS 'Email Address', e.section_name AS 'Section', d.display_picture AS 'Display Picture'  From tbl_student_section c, tbl_student d, tbl_section e Where c.student_id = d.lrn And c.section_id = e.section_id  AND d.fname LIKE '%" + txtSearchBox.Text + "%' OR d.mname LIKE '%" + txtSearchBox.Text + "%' OR d.lname LIKE '%" + txtSearchBox.Text + "%' Order By d.id ASC) tablerow WHERE RowNumber BETWEEN '" & val1 & "' And '" & val2 & "'"
        ElseIf cmbFilter.Text = "By Name" And txtSearchBox.Text = String.Empty Then
            Return "SELECT * FROM(SELECT row_number() Over (Order By d.id) As RowNumber, d.id As 'ID', d.lrn AS 'LRN', d.fname AS 'First Name', d.mname AS 'Middle Name', d.lname AS 'Last Name', d.gender AS 'Gender', d.address AS 'Address', d.parent_name AS 'Parent Name', d.contact_number AS 'Contact Number', d.email_address AS 'Email Address', e.section_name AS 'Section', d.display_picture AS 'Display Picture'  From tbl_student_section c, tbl_student d, tbl_section e Where c.student_id = d.lrn And c.section_id = e.section_id Order By d.id ASC) tablerow WHERE RowNumber BETWEEN '" & val1 & "' And '" & val2 & "'"
        ElseIf cmbFilter.Text = "By Gender" Then
            Return "SELECT * FROM(SELECT row_number() Over (Order By d.id) As RowNumber, d.id As 'ID', d.lrn AS 'LRN', d.fname AS 'First Name', d.mname AS 'Middle Name', d.lname AS 'Last Name', d.gender AS 'Gender', d.address AS 'Address', d.parent_name AS 'Parent Name', d.contact_number AS 'Contact Number', d.email_address AS 'Email Address', e.section_name AS 'Section', d.display_picture AS 'Display Picture'  From tbl_student_section c, tbl_student d, tbl_section e Where c.student_id = d.lrn And c.section_id = e.section_id AND d.gender = '" & cmbGender.Text & "' ORDER BY d.id ASC) tablerow WHERE RowNumber BETWEEN '" & val1 & "' And '" & val2 & "'"
        ElseIf cmbFilter.Text = "By LRN" Then
            Return "SELECT * FROM(SELECT row_number() Over (Order By d.id) As RowNumber, d.id As 'ID', d.lrn AS 'LRN', d.fname AS 'First Name', d.mname AS 'Middle Name', d.lname AS 'Last Name', d.gender AS 'Gender', d.address AS 'Address', d.parent_name AS 'Parent Name', d.contact_number AS 'Contact Number', d.email_address AS 'Email Address', e.section_name AS 'Section', d.display_picture AS 'Display Picture'  From tbl_student_section c, tbl_student d, tbl_section e Where c.student_id = d.lrn And c.section_id = e.section_id AND d.lrn LIKE '%" + txtSearchBox.Text + "%' Order By d.id ASC) tablerow WHERE RowNumber BETWEEN '" & val1 & "' And '" & val2 & "'"
        ElseIf cmbFilter.Text = "By Section" Then
            Return "SELECT * FROM(SELECT row_number() Over (Order By d.id) As RowNumber, d.id As 'ID', d.lrn AS 'LRN', d.fname AS 'First Name', d.mname AS 'Middle Name', d.lname AS 'Last Name', d.gender AS 'Gender', d.address AS 'Address', d.parent_name AS 'Parent Name', d.contact_number AS 'Contact Number', d.email_address AS 'Email Address', e.section_name AS 'Section', d.display_picture AS 'Display Picture'  From tbl_student_section c, tbl_student d, tbl_section e Where c.student_id = d.lrn And c.section_id = e.section_id AND d.section LIKE '%" + txtSearchBox.Text + "%' Order By d.id ASC) tablerow WHERE RowNumber BETWEEN '" & val1 & "' And '" & val2 & "'"
        ElseIf cmbFilter.Text = "No Section" Then
            Return "SELECT * FROM(SELECT * FROM(SELECT row_number() Over (Order By d.id) As RowNumber, d.id As 'ID', d.lrn AS 'LRN', d.fname AS 'First Name', d.mname AS 'Middle Name', d.lname AS 'Last Name', d.gender AS 'Gender', d.address AS 'Address', d.parent_name AS 'Parent Name', d.contact_number AS 'Contact Number', d.email_address AS 'Email Address', e.section_name AS 'Section', d.display_picture AS 'Display Picture'  From tbl_student_section c, tbl_student d, tbl_section e Where c.student_id = d.lrn And c.section_id = e.section_id AND c.section_id IS NULL Order By d.id ASC) tablerow WHERE RowNumber BETWEEN '" & val1 & "' And '" & val2 & "'"
        Else
            Return "Error"
        End If
    End Function

    'Private Sub displayStudent(val1 As String, val2 As String)
    '    Try
    '        comm = New MySqlCommand("SELECT * FROM(SELECT row_number() Over (Order By d.id) As RowNumber, d.id As 'ID', d.lrn AS 'LRN', d.fname AS 'First Name', d.mname AS 'Middle Name', d.lname AS 'Last Name', d.gender AS 'Gender', d.address AS 'Address', d.parent_name AS 'Parent Name', d.contact_number AS 'Contact Number', d.email_address AS 'Email Address', e.section_name AS 'Section', d.display_picture AS 'Display Picture'  From tbl_student_section c, tbl_student d, tbl_section e Where c.student_id = d.lrn And c.section_id = e.section_id Order By d.id ASC) tablerow WHERE RowNumber BETWEEN 1 And 5", conn)

    '        Dim da As New MySqlDataAdapter
    '        da.SelectCommand = comm
    '        Dim dt As New DataTable
    '        dt.Clear()

    '        da.Fill(dt)
    '        dgvStudent.DataSource = dt
    '        Dim imgColumn = DirectCast(dgvStudent.Columns(14), DataGridViewImageColumn)
    '        imgColumn.ImageLayout = DataGridViewImageCellLayout.Stretch

    '    Catch ex As Exception
    '    End Try
    '    conn.Close()
    'End Sub

    'Private Sub filteredSearch()
    '    Try
    '        If cmbFilter.Text = "All" Then
    '            comm = New MySqlCommand("Select d.id As 'ID', d.lrn AS 'LRN', d.fname AS 'First Name', d.mname AS 'Middle Name', d.lname AS 'Last Name', d.gender AS 'Gender', d.address AS 'Address', d.parent_name AS 'Parent Name', d.contact_number AS 'Contact Number', d.email_address AS 'Email Address', e.section_name AS 'Section', d.display_picture AS 'Display Picture' FROM tbl_student_section c, tbl_student d, tbl_section e WHERE c.student_id = d.lrn AND c.section_id = e.section_id ORDER BY d.id ASC", conn)
    '        ElseIf cmbFilter.Text = "By Name" Then
    '            comm = New MySqlCommand("SELECT d.id AS 'ID', d.lrn AS 'LRN', d.fname AS 'First Name', d.mname AS 'Middle Name', d.lname AS 'Last Name', d.gender AS 'Gender', d.address AS 'Address', d.parent_name AS 'Parent Name', d.contact_number AS 'Contact Number', d.email_address AS 'Email Address', e.section_name AS 'Section', d.display_picture AS 'Display Picture' FROM tbl_student_section c, tbl_student d, tbl_section e WHERE c.student_id = d.lrn AND c.section_id = e.section_id AND fname LIKE '%" + txtSearchBox.Text + "%' OR mname LIKE '%" + txtSearchBox.Text + "%' OR lname LIKE '%" + txtSearchBox.Text + "%' ORDER BY d.id ASC", conn)
    '        ElseIf cmbFilter.Text = "By Gender" Then
    '            comm = New MySqlCommand("SELECT d.id AS 'ID', d.lrn AS 'LRN', d.fname AS 'First Name', d.mname AS 'Middle Name', d.lname AS 'Last Name', d.gender AS 'Gender', d.address AS 'Address', d.parent_name AS 'Parent Name', d.contact_number AS 'Contact Number', d.email_address AS 'Email Address', e.section_name AS 'Section', d.display_picture AS 'Display Picture' FROM tbl_student_section c, tbl_student d, tbl_section e WHERE c.student_id = d.lrn AND c.section_id = e.section_id AND gender = '" & cmbGender.Text & "' ORDER BY d.id ASC", conn)
    '        ElseIf cmbFilter.Text = "By LRN" Then
    '            comm = New MySqlCommand("SELECT d.id AS 'ID', d.lrn AS 'LRN', d.fname AS 'First Name', d.mname AS 'Middle Name', d.lname AS 'Last Name', d.gender AS 'Gender', d.address AS 'Address', d.parent_name AS 'Parent Name', d.contact_number AS 'Contact Number', d.email_address AS 'Email Address', e.section_name AS 'Section', d.display_picture AS 'Display Picture' FROM tbl_student_section c, tbl_student d, tbl_section e WHERE c.student_id = d.lrn AND c.section_id = e.section_id AND lrn LIKE '%" + txtSearchBox.Text + "%' ORDER BY d.id ASC", conn)
    '        ElseIf cmbFilter.Text = "By Section" Then
    '            comm = New MySqlCommand("SELECT d.id AS 'ID', d.lrn AS 'LRN', d.fname AS 'First Name', d.mname AS 'Middle Name', d.lname AS 'Last Name', d.gender AS 'Gender', d.address AS 'Address', d.parent_name AS 'Parent Name', d.contact_number AS 'Contact Number', d.email_address AS 'Email Address', e.section_name AS 'Section', d.display_picture AS 'Display Picture' FROM tbl_student_section c, tbl_student d, tbl_section e WHERE c.student_id = d.lrn AND c.section_id = e.section_id AND section LIKE '%" + txtSearchBox.Text + "%' ORDER BY d.id ASC", conn)
    '        ElseIf cmbFilter.Text = "No Section" Then
    '            comm = New MySqlCommand("SELECT d.id AS 'ID', d.lrn AS 'LRN', d.fname AS 'First Name', d.mname AS 'Middle Name', d.lname AS 'Last Name', d.gender AS 'Gender', d.address AS 'Address', d.parent_name AS 'Parent Name', d.contact_number AS 'Contact Number', d.email_address AS 'Email Address', c.section_id AS 'Section', d.display_picture AS 'Display Picture'  FROM tbl_student_section c, tbl_student d WHERE c.student_id = d.lrn AND c.section_id IS NULL ORDER BY d.id ASC", conn)
    '        End If

    '        Dim da As New MySqlDataAdapter
    '        da.SelectCommand = comm
    '        Dim dt As New DataTable
    '        dt.Clear()

    '        da.Fill(dt)
    '        dgvStudent.DataSource = dt
    '        Dim imgColumn = DirectCast(dgvStudent.Columns(14), DataGridViewImageColumn)
    '        imgColumn.ImageLayout = DataGridViewImageCellLayout.Stretch

    '    Catch ex As Exception
    '    End Try
    '    conn.Close()
    'End Sub

    Private Sub dgvStudent_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudent.CellClick
        Dim colName As String = dgvStudent.Columns(e.ColumnIndex).Name
        Dim selectedRow As New DataGridViewRow
        Dim index As New Integer
        Try
            index = e.RowIndex
            selectedRow = dgvStudent.Rows(index)
            If colName = "action_view" Then
                With frm_view_student
                    .txtLRN.Text = selectedRow.Cells(5).Value.ToString
                    .txtFname.Text = selectedRow.Cells(6).Value.ToString
                    .txtMname.Text = selectedRow.Cells(7).Value.ToString
                    .txtLname.Text = selectedRow.Cells(8).Value.ToString
                    If selectedRow.Cells(9).Value.ToString = "Male" Then
                        .cmbGender.SelectedIndex = 0
                    Else
                        .cmbGender.SelectedIndex = 1
                    End If

                    .txtAddress.Text = selectedRow.Cells(10).Value.ToString
                    .txtParent.Text = selectedRow.Cells(11).Value.ToString
                    .txtContactNo.Text = selectedRow.Cells(12).Value.ToString
                    .txtEmail.Text = selectedRow.Cells(13).Value.ToString
                    .txtSection.Text = selectedRow.Cells(14).Value.ToString
                    Dim img() As Byte = selectedRow.Cells(15).Value
                    Dim ms As New MemoryStream(img)
                    .ProfileContainer.Image = Image.FromStream(ms)
                    .ShowDialog()
                End With
            ElseIf colName = "action_edit" Then
                With frm_edit_student
                    .txtID.Text = selectedRow.Cells(4).Value.ToString
                    .txtLRN.Text = selectedRow.Cells(5).Value.ToString
                    .txtFname.Text = selectedRow.Cells(6).Value.ToString
                    .txtMname.Text = selectedRow.Cells(7).Value.ToString
                    .txtLname.Text = selectedRow.Cells(8).Value.ToString
                    If selectedRow.Cells(9).Value.ToString = "Male" Then
                        .cmbGender.SelectedIndex = 0
                    Else
                        .cmbGender.SelectedIndex = 1
                    End If

                    .txtAddress.Text = selectedRow.Cells(10).Value.ToString
                    .txtParent.Text = selectedRow.Cells(11).Value.ToString
                    .txtContactNo.Text = selectedRow.Cells(12).Value.ToString
                    .txtEmail.Text = selectedRow.Cells(13).Value.ToString
                    .txtSection.Text = selectedRow.Cells(14).Value.ToString
                    Dim img() As Byte = selectedRow.Cells(15).Value
                    Dim ms As New MemoryStream(img)
                    .ProfileContainer.Image = Image.FromStream(ms)
                    .ShowDialog()
                End With
                load_data()
            ElseIf colName = "action_delete" Then
                Dim dialogResult As DialogResult = MessageBox.Show("Do you want to delete this student?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If dialogResult = DialogResult.Yes Then
                    deleteStudent(selectedRow.Cells(5).Value.ToString)
                    load_data()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
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

    Private Sub cmbFilter_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbFilter.SelectedValueChanged
        If cmbFilter.Text = "All" Then
            txtSearchBox.Enabled = False
            cmbGender.Enabled = False
            txtSearchBox.Clear()
        ElseIf cmbFilter.Text = "By Name" Or cmbFilter.Text = "By Section" Then
            cmbGender.Enabled = False
            txtSearchBox.Enabled = True
        ElseIf cmbFilter.Text = "By Gender" Then
            cmbGender.Enabled = True
            txtSearchBox.Enabled = False
            txtSearchBox.Clear()
        ElseIf cmbFilter.Text = "By LRN" Then
            cmbGender.Enabled = False
            txtSearchBox.Enabled = True
        ElseIf cmbFilter.Text = "No Section" Then
            cmbGender.Enabled = False
            txtSearchBox.Enabled = False
            txtSearchBox.Clear()
        End If

        If chkboxAutoSearch.Checked = True Then
            Label1.Text = "1"
            count_rows()
            load_data()
        End If
    End Sub

    Private Sub txtSearchBox_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBox.TextChanged
        If chkboxAutoSearch.Checked = True Then
            currentPg.Text = "1"
            count_rows()
            load_data()
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
            currentPg.Text = "1"
            count_rows()
            load_data()
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        export_file(dgvStudent, "student")
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        If CDbl(currentPg.Text) < pageRows Then
            currentPg.Text = CDbl(currentPg.Text) + 1
            load_data()
        End If
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        If CDbl(currentPg.Text) > 1 Then
            currentPg.Text = CDbl(currentPg.Text) - 1
            load_data()
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        currentPg.Text = "1"
        count_rows()
        load_data()
    End Sub

    Private Sub cmbFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilter.SelectedValueChanged
        currentPg.Text = "1"
        count_rows()
    End Sub
End Class
