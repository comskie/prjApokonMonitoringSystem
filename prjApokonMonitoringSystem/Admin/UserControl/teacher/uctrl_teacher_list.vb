Imports MySql.Data.MySqlClient
Public Class uctrl_teacher_list
    Private Sub displayTeacher()
        Try
            comm = New MySqlCommand("SELECT id AS 'ID', teacher_id AS 'Teacher ID', fname AS 'First Name', mname AS 'Middle Name', lname AS 'Last Name', gender AS 'Gender', contact_number AS 'Contact Number', email_address AS 'Email Address' FROM tbl_teacher", conn)

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
                comm = New MySqlCommand("SELECT id AS 'ID', teacher_id AS 'Teacher ID', fname AS 'First Name', mname AS 'Middle Name', lname AS 'Last Name', gender AS 'Gender', contact_number AS 'Contact Number', email_address AS 'Email Address' FROM tbl_teacher", conn)
            ElseIf cmbFilter.Text = "By Name" Then
                comm = New MySqlCommand("SELECT id AS 'ID', teacher_id AS 'Teacher ID', fname AS 'First Name', mname AS 'Middle Name', lname AS 'Last Name', gender AS 'Gender', contact_number AS 'Contact Number', email_address AS 'Email Address' FROM tbl_teacher fname LIKE '%" + txtSearchBox.Text + "%' OR mname LIKE '%" + txtSearchBox.Text + "%' OR lname LIKE '%" + txtSearchBox.Text + "%'", conn)
            ElseIf cmbFilter.Text = "By Gender" Then
                comm = New MySqlCommand("SELECT id AS 'ID', teacher_id AS 'Teacher ID', fname AS 'First Name', mname AS 'Middle Name', lname AS 'Last Name', gender AS 'Gender', contact_number AS 'Contact Number', email_address AS 'Email Address' FROM tbl_teacher WHERE gender = '" & cmbGender.Text & "'", conn)

            End If

            Dim da As New MySqlDataAdapter
            da.SelectCommand = comm
            Dim dt As New DataTable
            dt.Clear()

            da.Fill(dt)
            dgvTeacher.DataSource = dt
            Dim imgColumn = DirectCast(dgvTeacher.Columns(13), DataGridViewImageColumn)
            imgColumn.ImageLayout = DataGridViewImageCellLayout.Stretch
        Catch ex As Exception
        End Try
        conn.Close()
    End Sub

    Private Sub uctrl_teacher_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayTeacher()
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

    Private Sub cmbGender_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbGender.SelectedValueChanged
        If chkboxAutoSearch.Checked = True Then
            filteredSearch()
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

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        export_file(dgvTeacher, "teacher")
    End Sub

    Private Sub dgvTeacher_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTeacher.CellClick
        Dim colName As String = dgvTeacher.Columns(e.ColumnIndex).Name
        Dim selectedRow As New DataGridViewRow
        Dim index As New Integer
        Try
            index = e.RowIndex
            selectedRow = dgvTeacher.Rows(index)
            If colName = "action_view" Then
                With frm_view_teacher
                    .txtID.Text = selectedRow.Cells(4).Value.ToString
                    .txtFname.Text = selectedRow.Cells(5).Value.ToString
                    .txtMname.Text = selectedRow.Cells(6).Value.ToString
                    .txtLname.Text = selectedRow.Cells(7).Value.ToString
                    If selectedRow.Cells(8).Value.ToString = Gender.Male Then
                        .cmbGender.SelectedIndex = 0
                    Else
                        .cmbGender.SelectedIndex = 1
                    End If
                    .txtContactNo.Text = selectedRow.Cells(9).Value.ToString
                    .txtEmail.Text = selectedRow.Cells(10).Value.ToString
                    .ShowDialog()
                End With
            ElseIf colName = "action_edit" Then
                With frm_edit_teacher
                    .txtColID.Text = selectedRow.Cells(3).Value.ToString
                    .txtID.Text = selectedRow.Cells(4).Value.ToString
                    .txtFname.Text = selectedRow.Cells(5).Value.ToString
                    .txtMname.Text = selectedRow.Cells(6).Value.ToString
                    .txtLname.Text = selectedRow.Cells(7).Value.ToString

                    If selectedRow.Cells(8).Value.ToString = Gender.Male Then
                        .cmbGender.SelectedIndex = 0
                    Else
                        .cmbGender.SelectedIndex = 1
                    End If
                    .txtContactNo.Text = selectedRow.Cells(9).Value.ToString
                    .txtEmail.Text = selectedRow.Cells(10).Value.ToString
                    .ShowDialog()
                End With
                displayTeacher()
            ElseIf colName = "action_delete" Then
                Dim dialogResult As DialogResult = MessageBox.Show("Do you want to delete this teacher?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If dialogResult = DialogResult.Yes Then
                    deleteTeacher(selectedRow.Cells(3).Value.ToString, selectedRow.Cells(4).Value.ToString)
                    displayTeacher()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub deleteTeacher(teacherID As String, userName As String)
        Try
            conn.Open()
            comm = New MySqlCommand("DELETE FROM tbl_teacher WHERE id = @tid", conn)
            comm.Parameters.Add("@tid", MySqlDbType.VarChar).Value = teacherID

            adapter = New MySqlDataAdapter(comm)
            comm.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
        conn.Close()

        Try
            conn.Open()
            comm = New MySqlCommand("DELETE FROM tbl_accounts WHERE user_username = @uname", conn)
            comm.Parameters.Add("@uname", MySqlDbType.VarChar).Value = userName
            adapter = New MySqlDataAdapter(comm)
            comm.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
        MessageBox.Show("Record Deleted")
        conn.Close()
    End Sub
End Class
