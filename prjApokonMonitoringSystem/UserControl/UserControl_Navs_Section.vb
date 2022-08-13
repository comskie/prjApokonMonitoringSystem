Public Class UserControl_Navs_Section
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim UC As New uctrl_register_advisory
        addUserControl(UC, pnlSection)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim UC As New uctrl_section_list
        addUserControl(UC, pnlSection)
    End Sub

    Private Sub UserControl_Navs_Section_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim UC As New uctrl_section_list
        addUserControl(UC, pnlSection)
    End Sub
End Class
