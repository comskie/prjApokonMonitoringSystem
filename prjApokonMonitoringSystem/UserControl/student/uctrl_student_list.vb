Imports MySql.Data.MySqlClient
Imports System.IO
Public Class uctrl_student_list
    Private Sub uctrl_student_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Dim imgColumn = DirectCast(dgvStudent.Columns(13), DataGridViewImageColumn)
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
            ElseIf cmbFilter.Text = "By Section" Then
                comm = New MySqlCommand("SELECT * FROM tbl_student WHERE section LIKE '%" + txtSearchBox.Text + "%'", conn)
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
        End Try
        conn.Close()
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
                    .txtSection.Text = selectedRow.Cells(14).Value.ToString
                    If selectedRow.Cells(13).Value IsNot Nothing Then
                        Dim ms As New MemoryStream(CType(selectedRow.Cells(13).Value, Byte()))
                        .ProfileContainer.BackgroundImage = Image.FromStream(ms)
                    Else
                        MsgBox("Empty!")
                    End If

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
                    .txtSection.Text = selectedRow.Cells(14).Value.ToString
                    If selectedRow.Cells(13).Value IsNot Nothing Then
                        Dim ms As New MemoryStream(CType(selectedRow.Cells(13).Value, Byte()))
                        .ProfileContainer.BackgroundImage = Image.FromStream(ms)
                    Else
                        MsgBox("Empty!")
                    End If

                    .ShowDialog()
                End With
                displayStudent()
            ElseIf colName = "action_delete" Then
                deleteStudent(selectedRow.Cells(4).Value.ToString)
                displayStudent()
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
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        filteredSearch()
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
        End If
    End Sub

    Private Sub txtSearchBox_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBox.TextChanged
        If chkboxAutoSearch.Checked = True Then
            filteredSearch()
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

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        export_file(dgvStudent, "student")
    End Sub
End Class
