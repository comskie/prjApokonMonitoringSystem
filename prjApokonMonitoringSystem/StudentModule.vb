Imports MySql.Data.MySqlClient

Module StudentModule

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