Imports MySql.Data.MySqlClient
Imports System.IO
Public Class uctrl_student_list
    Dim maxRows = 10
    Dim studentPaginate As New StudentPaginate(maxRows)
    Dim currentFilter As StudentFilterEnum = StudentFilterEnum.All
    Dim currentFilterValue As String = ""

    Private Sub uctrl_student_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pgRows.Text = studentPaginate.page.length
        dgvStudent.DataSource = studentPaginate.GetCurrentPage()
    End Sub

    Private Sub SetCurrentFilter()
        If cmbFilter.Text = "By Name" Then
            currentFilter = StudentFilterEnum.Name
        ElseIf cmbFilter.Text = "By Gender" Then
            currentFilter = StudentFilterEnum.Gender
        ElseIf cmbFilter.Text = "By LRN" Then
            currentFilter = StudentFilterEnum.LRN
        ElseIf cmbFilter.Text = "By Section" Then
            currentFilter = StudentFilterEnum.Section
        ElseIf cmbFilter.Text = "No Section" Then
            currentFilter = StudentFilterEnum.NoSection
        Else
            currentFilter = StudentFilterEnum.All
        End If
    End Sub

    Private Sub SetCurrentFilterValue()
        If currentFilter = StudentFilterEnum.All _
            Or currentFilter = StudentFilterEnum.NoSection Then
            currentFilterValue = ""
            Return
        End If

        If currentFilter = StudentFilterEnum.Name _
            Or currentFilter = StudentFilterEnum.LRN _
            Or currentFilter = StudentFilterEnum.Section Then
            currentFilterValue = txtSearchBox.Text
            Return
        End If

        If currentFilter = StudentFilterEnum.Gender Then
            currentFilterValue = cmbGender.Text
            Return
        End If

        currentFilterValue = ""
    End Sub

    Private Sub dgvStudent_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudent.CellClick
        Dim colName As String = dgvStudent.Columns(e.ColumnIndex).Name
        If e.RowIndex >= 0 Then
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
                        If selectedRow.Cells(9).Value.ToString = GenderEnum.Male.ToString Then
                            .cmbGender.SelectedIndex = GenderEnum.Male
                        Else
                            .cmbGender.SelectedIndex = GenderEnum.Female
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
                        If selectedRow.Cells(9).Value.ToString = GenderEnum.Male.ToString Then
                            .cmbGender.SelectedIndex = GenderEnum.Male
                        Else
                            .cmbGender.SelectedIndex = GenderEnum.Female
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
                    RefetchDataDisplay()
                ElseIf colName = "action_delete" Then
                    Dim dialogResult As DialogResult = MessageBox.Show("Do you want to delete this student?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If dialogResult = DialogResult.Yes Then
                        deleteStudent(selectedRow.Cells(5).Value.ToString)
                        RefetchDataDisplay()
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
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
        SetCurrentFilter()

        If currentFilter = StudentFilterEnum.All Then
            txtSearchBox.Enabled = False
            cmbGender.Enabled = False
            txtSearchBox.Clear()
        ElseIf currentFilter = StudentFilterEnum.Name Or currentFilter = StudentFilterEnum.Section Then
            cmbGender.Enabled = False
            txtSearchBox.Enabled = True
            txtSearchBox.Clear()
        ElseIf currentFilter = StudentFilterEnum.Gender Then
            cmbGender.Enabled = True
            txtSearchBox.Enabled = False
            txtSearchBox.Clear()
        ElseIf currentFilter = StudentFilterEnum.LRN Then
            cmbGender.Enabled = False
            txtSearchBox.Enabled = True
            txtSearchBox.Clear()
        ElseIf currentFilter = StudentFilterEnum.NoSection Then
            cmbGender.Enabled = False
            txtSearchBox.Enabled = False
            txtSearchBox.Clear()
        End If
        RefetchDataDisplay()
    End Sub

    Private Sub txtSearchBox_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBox.TextChanged
        If chkboxAutoSearch.Checked = True Then
            RefetchDataDisplay()
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
            RefetchDataDisplay()
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        export_file(dgvStudent, "student")
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        'page next
        If studentPaginate.Next() = -1 Then
            Return
        End If

        currentPg.Text = studentPaginate.page.currentIndex + 1

        dgvStudent.DataSource = studentPaginate.GetCurrentPage()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        'page prev
        If studentPaginate.Prev() = -1 Then
            Return
        End If

        currentPg.Text = studentPaginate.page.currentIndex + 1

        dgvStudent.DataSource = studentPaginate.GetCurrentPage()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        RefetchDataDisplay()
    End Sub

    Private Sub cmbFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilter.SelectedValueChanged
        RefetchDataDisplay()
    End Sub

    Private Sub RefetchDataDisplay()
        SetCurrentFilter()
        SetCurrentFilterValue()

        studentPaginate = New StudentPaginate(maxRows, currentFilter, currentFilterValue)

        currentPg.Text = studentPaginate.page.currentIndex + 1
        pgRows.Text = studentPaginate.page.length
        dgvStudent.DataSource = studentPaginate.GetCurrentPage()
    End Sub
End Class
