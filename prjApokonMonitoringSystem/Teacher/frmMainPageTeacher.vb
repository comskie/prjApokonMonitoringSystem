Imports FontAwesome.Sharp
Public Class frmMainPageTeacher
    Private Sub tmrTimer_Tick(sender As Object, e As EventArgs) Handles tmrTimer.Tick
        lblClock.Text = DateTime.Now.ToString("hh:mm:ss tt").ToUpper
    End Sub

    Private Sub IconButton7_Click(sender As Object, e As EventArgs) Handles IconButton7.Click
        Application.Exit()
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to logout? Please select an option", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            teacherID = ""
            Me.Close()
            frmLogin.Show()
        End If
    End Sub

    Private currentBtn As IconButton

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(46, 52, 88)
            currentBtn.IconColor = Color.White
            currentBtn.ForeColor = Color.White
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
        End If
    End Sub

    Private Sub ActivateButton(senderBtn As Object, customColor As Color, lblFormTitle As String)
        Try
            If senderBtn IsNot Nothing Then
                DisableButton()
                currentBtn = CType(senderBtn, IconButton)
                currentBtn.BackColor = Color.FromArgb(37, 36, 81)
                currentBtn.ForeColor = customColor
                currentBtn.IconColor = customColor
                currentBtn.TextAlign = ContentAlignment.MiddleCenter
                currentBtn.ImageAlign = ContentAlignment.MiddleRight
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
                currentIcon.IconChar = currentBtn.IconChar
                currentIcon.IconColor = customColor

                lblTitle.Text = lblFormTitle
                lblTitle.ForeColor = customColor
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        ActivateButton(sender, Color.FromArgb(248, 233, 161), "Student")
        Dim UC As New uctrl_mystudent
        addUserControl(UC, UserControlPanel)
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        ActivateButton(sender, Color.FromArgb(248, 233, 161), "Logs")
        Dim UC As New uctrl_mystudent_logs
        addUserControl(UC, UserControlPanel)
    End Sub
End Class