Public Class UserControl_Navs_Teacher
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim UC As New uctrl_register_teacher
        addUserControl(UC, pnlTeacher)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim UC As New uctrl_teacher_list
        addUserControl(UC, pnlTeacher)
    End Sub

    Private Sub UserControl_Navs_Teacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim UC As New uctrl_teacher_list
        addUserControl(UC, pnlTeacher)
    End Sub
End Class
