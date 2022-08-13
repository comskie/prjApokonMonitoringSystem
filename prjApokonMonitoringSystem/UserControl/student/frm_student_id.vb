Imports System.Drawing.Imaging
Public Class frm_student_id
    Private Sub frm_student_id_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fileLoc As String = Application.StartupPath & "\student_id\" & lrnContainer.Text & ".png"
        If System.IO.File.Exists(fileLoc) Then
        Else
            Using bmp = New Bitmap(Panel1.Width, Panel1.Height)
                Panel1.DrawToBitmap(bmp, New Rectangle(0, 0, bmp.Width, bmp.Height))
                bmp.Save(fileLoc)
            End Using
        End If

    End Sub

    Private Sub frm_student_id_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub
End Class