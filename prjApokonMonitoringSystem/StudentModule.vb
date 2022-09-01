Imports MySql.Data.MySqlClient

Module StudentModule

    Class StudentUtil
        Enum LogType
            TimeInAM
            TimeOutAM
            TimeInPM
            TimeOutPM
        End Enum

        Public Shared Function GetLogTypeFromDateTime(dateTime As DateTime) As LogType
            Dim time = dateTime.TimeOfDay

            Dim timeinAMRange_1 As DateTime = #12:00:00 AM#
            Dim timeinAMRange_2 As DateTime = #11:59:00 AM#
            Dim timeoutAMRange_1 As DateTime = #12:00:00 PM#
            Dim timeoutAMRange_2 As DateTime = #12:30:00 PM#
            Dim timeinPMRange_1 As DateTime = #12:31:00 PM#
            Dim timeinPMRange_2 As DateTime = #4:59:00 PM#
            Dim timeoutPMRange_1 As DateTime = #5:00:00 PM#
            Dim timeoutPMRange_2 As DateTime = #11:59:00 PM#

            MsgBox(timeoutPMRange_1.TimeOfDay)


            If dateTime.TimeOfDay >= timeinAMRange_1.TimeOfDay And dateTime.TimeOfDay <= timeinAMRange_2.TimeOfDay Then
                Return LogType.TimeInAM
            ElseIf dateTime.TimeOfDay >= timeoutAMRange_1.TimeOfDay And dateTime.TimeOfDay <= timeoutAMRange_2.TimeOfDay Then
                Return LogType.TimeOutAM
            ElseIf dateTime.TimeOfDay >= timeinPMRange_1.TimeOfDay And dateTime.TimeOfDay <= timeinPMRange_2.TimeOfDay Then
                Return LogType.TimeInPM
            ElseIf dateTime.TimeOfDay >= timeoutPMRange_1.TimeOfDay And dateTime.TimeOfDay <= timeoutPMRange_2.TimeOfDay Then
                Return LogType.TimeOutPM
            Else
                Throw New Exception("Error log type")
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