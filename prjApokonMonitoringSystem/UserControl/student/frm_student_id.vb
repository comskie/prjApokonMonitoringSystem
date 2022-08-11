Imports System.Drawing.Imaging
Public Class frm_student_id
    Private Sub frm_student_id_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using bmp = New Bitmap(Panel1.Width, Panel1.Height)
            Panel1.DrawToBitmap(bmp, New Rectangle(0, 0, bmp.Width, bmp.Height))
            bmp.Save(Application.StartupPath & "\student_id\" & lrnContainer.Text & ".png")
            bmp.Dispose()
        End Using
    End Sub
End Class