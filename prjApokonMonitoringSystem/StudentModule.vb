Module StudentModule
    Function GetFieldOfStudentLogType(studentLogType As Enums.StudentLogType)
        Select Case studentLogType
            Case StudentLogType.TimeInAM
                Return "timeIN_AM"
            Case StudentLogType.TimeOutAM
                Return "timeOUT_AM"
            Case StudentLogType.TimeInPM
                Return "timeIN_PM"
            Case StudentLogType.TimeOutPM
                Return "timeOUT_PM"
            Case Else
                Throw New Exception("Error log type!")
        End Select
    End Function

End Module
