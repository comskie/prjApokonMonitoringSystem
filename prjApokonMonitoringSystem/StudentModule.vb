Imports MySql.Data.MySqlClient

Module StudentModule
    Enum StudentFilterEnum
        All
        Name
        Gender
        LRN
        Section
        NoSection
    End Enum


    Class StudentPaginate
        Public rowsCount As Integer
        Public page As Page
        Public filter As StudentFilterEnum
        Public filterValue As String

        Public Sub New(rowsCount_ As Integer, Optional filter_ As StudentFilterEnum = StudentFilterEnum.All, Optional filterValue_ As String = "")
            rowsCount = rowsCount_
            filter = filter_
            filterValue = filterValue_
            page = New Page(GetMaxPages(rowsCount, filter, filterValue))
        End Sub

        Public Function GetCurrentPage() As DataTable
            Dim queryString =
                "SELECT
                row_number() Over (
                    Order By
                        d.id
                ) As RowNumber,
                d.id As 'ID',
                d.lrn AS 'LRN',
                d.fname AS 'First Name',
                d.mname AS 'Middle Name',
                d.lname AS 'Last Name',
                d.gender AS 'Gender',
                d.address AS 'Address',
                d.parent_name AS 'Parent Name',
                d.contact_number AS 'Contact Number',
                d.email_address AS 'Email Address',
                e.section_name AS 'Section',
                d.display_picture AS 'Display Picture'
            From
                tbl_student_section c,
                tbl_student d,
                tbl_section e
            Where
                c.student_id = d.lrn
                AND c.section_id = e.section_id"

            Select Case filter
                Case StudentFilterEnum.Name
                    queryString &= " AND (CONCAT(d.fname, ' ', d.mname, ' ', d.lname) LIKE '%" & filterValue & "%')"
                Case StudentFilterEnum.Gender
                    queryString &= " AND d.gender = '" & filterValue & "'"
                Case StudentFilterEnum.LRN
                    queryString &= " AND d.lrn LIKE '%" & filterValue & "%'"
                Case StudentFilterEnum.Section
                    queryString &= " AND e.section_name LIKE '%" & filterValue & "%'"
                Case StudentFilterEnum.NoSection
                    queryString &= " AND c.section_id IS NULL"
            End Select

            queryString &= " ORDER BY d.id ASC" _
                        & " LIMIT " & rowsCount & " OFFSET " & page.currentIndex * 10

            conn.Open()
            Dim cmd As New MySqlCommand(queryString, conn)
            Dim da As New MySqlDataAdapter With {
                .SelectCommand = cmd
            }

            Dim dt As New DataTable
            da.Fill(dt)

            conn.Close()

            Return dt
        End Function

        Public Function [Next]()
            Return page.Next()
        End Function

        Public Function Prev()
            Return page.Prev()
        End Function

        Public Shared Function GetMaxPages(maxRows As Integer, filter As StudentFilterEnum, value As String) As Integer
            Dim queryString =
                "SELECT
                    COUNT(d.lrn)
                From
                    tbl_student_section c,
                    tbl_student d,
                    tbl_section e
                Where
                    c.student_id = d.lrn
                    And c.section_id = e.section_id"

            Select Case filter
                Case StudentFilterEnum.Name
                    queryString &= " AND (CONCAT(d.fname, ' ', d.mname, ' ', d.lname) LIKE '%" & value & "%')"
                Case StudentFilterEnum.Gender
                    queryString &= " AND d.gender = '" & value & "'"
                Case StudentFilterEnum.LRN
                    queryString &= " AND d.lrn LIKE '%" & value & "%'"
                Case StudentFilterEnum.Section
                    queryString &= " AND e.section_name LIKE '%" & value & "%'"
                Case StudentFilterEnum.NoSection
                    queryString &= " AND c.section_id IS NULL"
            End Select
            conn.Open()
            Dim comm As New MySqlCommand(queryString, conn)
            Dim rowsCount = CInt(comm.ExecuteScalar)
            conn.Close()

            Return Math.Ceiling(rowsCount / maxRows)
        End Function


        Public Shared Function Paginate(pageIndex As Integer, maxRows As Integer, filter As StudentFilterEnum, value As String) As DataTable
            Dim queryString =
                "SELECT
                row_number() Over (
                    Order By
                        d.id
                ) As RowNumber,
                d.id As 'ID',
                d.lrn AS 'LRN',
                d.fname AS 'First Name',
                d.mname AS 'Middle Name',
                d.lname AS 'Last Name',
                d.gender AS 'Gender',
                d.address AS 'Address',
                d.parent_name AS 'Parent Name',
                d.contact_number AS 'Contact Number',
                d.email_address AS 'Email Address',
                e.section_name AS 'Section',
                d.display_picture AS 'Display Picture'
            From
                tbl_student_section c,
                tbl_student d,
                tbl_section e
            Where
                c.student_id = d.lrn
                And c.section_id = e.section_id"

            Select Case filter
                Case StudentFilterEnum.Name
                    queryString &= " AND (CONCAT(d.fname, ' ', d.mname, ' ', d.lname) LIKE '%" & value & "%')"
                Case StudentFilterEnum.Gender
                    queryString &= " AND d.gender = '" & value & "'"
                Case StudentFilterEnum.LRN
                    queryString &= " AND d.lrn LIKE '%" & value & "%'"
                Case StudentFilterEnum.Section
                    queryString &= " AND e.section_name LIKE '%" & value & "%'"
                Case StudentFilterEnum.NoSection
                    queryString &= " AND c.section_id IS NULL"
            End Select

            queryString &= " ORDER BY d.id ASC" _
                        & " LIMIT " & maxRows & " OFFSET " & pageIndex * 10

            conn.Open()
            Dim cmd As New MySqlCommand(queryString, conn)
            Dim da As New MySqlDataAdapter With {
                .SelectCommand = cmd
            }

            Dim dt As New DataTable
            da.Fill(dt)

            conn.Close()

            Return dt
        End Function
    End Class

    Class StudentUtil
        Private Shared ReadOnly timeinAMRangeMin = TimeSpan.Parse("00:00:00") '12:00:00 AM
        Private Shared ReadOnly timeinAMRangeMax = TimeSpan.Parse("11:59:00") '11:59:00 AM
        Private Shared ReadOnly timeoutAMRangeMin = TimeSpan.Parse("12:00:00") '12:00:00 PM
        Private Shared ReadOnly timeoutAMRangeMax = TimeSpan.Parse("12:30:00") '12:30:00 PM
        Private Shared ReadOnly timeinPMRangeMin = TimeSpan.Parse("12:31:00") '12:31:00 PM
        Private Shared ReadOnly timeinPMRangeMax = TimeSpan.Parse("16:59:00") ' 4:59:00 PM
        Private Shared ReadOnly timeoutPMRangeMin = TimeSpan.Parse("17:00:00") '5:00:00 PM
        Private Shared ReadOnly timeoutPMRangeMax = TimeSpan.Parse("23:59:00") '11:59:00 PM

        Enum LogType
            TimeInAM
            TimeOutAM
            TimeInPM
            TimeOutPM
        End Enum

        Public Shared Function GetLogTypeFromTimeSpan(time As TimeSpan) As LogType

            If time >= timeinAMRangeMin And time <= timeinAMRangeMax Then
                Return LogType.TimeInAM
            ElseIf time >= timeoutAMRangeMin And time <= timeoutAMRangeMax Then
                Return LogType.TimeOutAM
            ElseIf time >= timeinPMRangeMin And time <= timeinPMRangeMax Then
                Return LogType.TimeInPM
            ElseIf time >= timeoutPMRangeMin And time <= timeoutPMRangeMax Then
                Return LogType.TimeOutPM
            Else
                Throw New Exception("Invalid log type")
            End If
        End Function

        Public Shared Function GetTableFieldFromLogType(studentLogType As LogType) As String
            Select Case studentLogType
                Case LogType.TimeInAM
                    Return "timeIN_AM"
                Case LogType.TimeOutAM
                    Return "timeOUT_AM"
                Case LogType.TimeInPM
                    Return "timeIN_PM"
                Case LogType.TimeOutPM
                    Return "timeOUT_PM"
                Case Else
                    Throw New Exception("Error log type!")
            End Select
        End Function

        Public Shared Function StudentExists(LRN As String) As Boolean
            If LRN.Length <> 12 Then
                Return False
            End If

            Try
                conn.Open()
                comm = New MySqlCommand("SELECT lrn FROM tbl_student WHERE lrn = '" & LRN & "' limit 1", conn)
                adapter = New MySqlDataAdapter(comm)

                Dim table As New DataTable()
                adapter.Fill(table)

                If table.Rows.Count = 1 Then
                    Return True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            conn.Dispose()
            conn.Close()
            Return False
        End Function

    End Class
End Module