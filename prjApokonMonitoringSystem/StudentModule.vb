Module StudentModule

    Class StudentUtil
        Enum LogType
            TimeInAM
            TimeOutAM
            TimeInPM
            TimeOutPM
        End Enum

        Public Shared Function GetLogTypeFromDateTime(dateTime As DateTime) As LogType
            Dim timeinAMRange_1 As DateTime = #12:00:00 AM#
            Dim timeinAMRange_2 As DateTime = #11:59:00 AM#
            Dim timeoutAMRange_1 As DateTime = #12:00:00 PM#
            Dim timeoutAMRange_2 As DateTime = #12:30:00 PM#
            Dim timeinPMRange_1 As DateTime = #12:31:00 PM#
            Dim timeinPMRange_2 As DateTime = #4:59:00 PM#
            Dim timeoutPMRange_1 As DateTime = #5:00:00 PM#
            Dim timeoutPMRange_2 As DateTime = #11:59:00 PM#


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

        Public Shared Function GetFieldOfStudentLogType(studentLogType As LogType)
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

    End Class
End Module