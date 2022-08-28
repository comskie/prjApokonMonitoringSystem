Public Class UserControl_Navs_Notification
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim UC As New uctrl_send_email
        addUserControl(UC, pnlStudent)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim UC As New uctrl_view_notification_logs
        addUserControl(UC, pnlStudent)
    End Sub

    Private Sub UserControl_Navs_Notification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim UC As New uctrl_view_notification_logs
        addUserControl(UC, pnlStudent)
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim UC As New uctrl_send_sms
        addUserControl(UC, pnlStudent)
    End Sub
End Class
