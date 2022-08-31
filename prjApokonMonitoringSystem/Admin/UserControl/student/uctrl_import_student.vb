Imports Microsoft.Office.Interop
Public Class uctrl_import_student
    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim xlRange As Excel.Range
        Dim xlRow As Integer

        Dim strFilename As String = ""
        Dim data(0 To 100) As String

        With OpenFileDialog1
            .Title = "Choose File"
            .Filter = "Excel Office| *.xls;*.xlsx"
            .FileName = ""
            .ShowDialog()
            strFilename = .FileName
            txtFileLocation.Text = .FileName
        End With

        If strFilename <> String.Empty Then
            xlApp = New Excel.Application
            xlWorkBook = xlApp.Workbooks.Open(strFilename)
            xlWorkSheet = CType(xlWorkBook.Sheets(1), Excel.Worksheet)
            xlRange = xlWorkSheet.UsedRange
            For xlRow = 2 To xlRange.Rows.Count
                dgvImported.Rows.Add(xlRange.Cells(xlRow, 1).Text, xlRange.Cells(xlRow, 2).Text, xlRange.Cells(xlRow, 3).Text, xlRange.Cells(xlRow, 4).Text, xlRange.Cells(xlRow, 5).Text, xlRange.Cells(xlRow, 6).Text, xlRange.Cells(xlRow, 7).Text, xlRange.Cells(xlRow, 8).Text, xlRange.Cells(xlRow, 9).Text)
            Next
            xlWorkBook.Close()
            xlApp.Quit()
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim locationFile As String = Application.StartupPath & "\files\student_import_template.xlsx"
        Dim downloadLocation As String
        Dim fndate As String = DateTime.Now.ToString("yyyyMMddHHmmss")
        Try
            If FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                downloadLocation = FolderBrowserDialog1.SelectedPath
                Dim root As Environment.SpecialFolder = FolderBrowserDialog1.RootFolder
                MsgBox("Successfully downloaded template", MsgBoxStyle.Information)
                My.Computer.Network.DownloadFile(locationFile, downloadLocation & "\student_import_template" & fndate & ".xlsx")
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        With frmBrowse_Section
            .ShowDialog()
            import_file(dgvImported, ProfileContainer, .ssection)
        End With
        dgvImported.Rows.Clear()
        dgvImported.Refresh()
    End Sub

    Private Sub txtFileLocation_TextChanged(sender As Object, e As EventArgs) Handles txtFileLocation.TextChanged
        If txtFileLocation.Text = String.Empty And dgvImported.Rows.Count < 1 Then
            Guna2Button2.Enabled = False
        Else
            Guna2Button2.Enabled = True
        End If
    End Sub
End Class
