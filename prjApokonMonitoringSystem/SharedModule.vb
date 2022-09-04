Module SharedModule
    Enum GenderEnum
        Male = 0
        Female = 1
    End Enum

    Class Page
        Public currentIndex As Integer
        Public length As Integer

        Public Sub New(len As Integer)
            currentIndex = 0
            length = len

            If length = 0 Then
                length = 1
            End If
        End Sub

        Public Function [Next]() As Integer
            If currentIndex >= (length - 1) Then
                Return -1
            End If

            currentIndex += 1

            Return currentIndex
        End Function

        Public Function Prev() As Integer
            If currentIndex = 0 Then
                Return -1
            End If

            currentIndex -= 1

            Return currentIndex
        End Function
    End Class
End Module
