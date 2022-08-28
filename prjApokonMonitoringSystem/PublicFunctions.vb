﻿Imports System.Net.Mail
Imports System.IO
Imports MySql.Data.MySqlClient
Imports CloudinaryDotNet
Imports CloudinaryDotNet.Actions
Imports System.Net

Module PublicFunctions
    Public cloudinary As Cloudinary
    Public teacherID As String
    Public Sub addUserControl(userControl As UserControl, pnl As Panel)
        userControl.Dock = DockStyle.Fill
        pnl.Controls.Clear()
        pnl.Controls.Add(userControl)
        userControl.BringToFront()
    End Sub

    Function getTeacherID(uname As String) As String
        Try
            comm = New MySqlCommand("SELECT teacher_id FROM tbl_teacher WHERE BINARY username = '" & uname & "'", conn)
            adapter = New MySqlDataAdapter(comm)
            Dim table As New DataTable()
            adapter.Fill(table)
            Return table.Rows(0).Item(0).ToString()
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
        conn.Close()
        Return "error"
    End Function

    Public Sub SendMail(MailReceiver As String, MailSubject As String, MailBody As String, LRN As String, attachment As System.Net.Mail.Attachment)
        Try
            Dim smpt_server As New SmtpClient
            Dim email As New MailMessage
            smpt_server.UseDefaultCredentials = False
            smpt_server.Credentials = New Net.NetworkCredential(school_email, school_password)
            smpt_server.Port = 587
            smpt_server.EnableSsl = True
            smpt_server.Host = "smtp.gmail.com"
            email = New MailMessage()
            email.From = New MailAddress(school_email)
            email.To.Add(MailReceiver)
            email.Subject = MailSubject
            email.IsBodyHtml = False
            email.Body = MailBody
            email.Attachments.Add(attachment)
            smpt_server.Send(email)
            MsgBox("Email successfully sent", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub SendMail(MailReceiver As String, MailSubject As String, MailBody As String, LRN As String)
        Try
            Dim smpt_server As New SmtpClient
            Dim email As New MailMessage
            smpt_server.UseDefaultCredentials = False
            smpt_server.Credentials = New Net.NetworkCredential(school_email, school_password)
            smpt_server.Port = 587
            smpt_server.EnableSsl = True
            smpt_server.Host = "smtp.gmail.com"
            email = New MailMessage()
            email.From = New MailAddress(school_email)
            email.To.Add(MailReceiver)
            email.Subject = MailSubject
            email.IsBodyHtml = False
            email.Body = MailBody
            smpt_server.Send(email)
            MsgBox("Email successfully sent", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub InsertToNotificationLogs(ntype As String, nsentto As String, nbody As String)
        Try
            conn.Open()
            comm = New MySqlCommand("prcInsertNotification", conn)
            With comm
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@ntype", ntype)
                .Parameters.AddWithValue("@nsent", nsentto)
                .Parameters.AddWithValue("@mcont", nbody)
                .Parameters.AddWithValue("@ndate", Format(DateTime.Now, "yyyy/MM/dd"))
                .ExecuteNonQuery()
            End With
            MessageBox.Show("Record inserted")

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Public Sub export_file(dgv As DataGridView, moduleName As String)
        Dim sfd As New SaveFileDialog()
        sfd.FileName = "export_" & moduleName & "_" & Format(Date.Now, "ddMMyyy")
        sfd.Filter = "CSV File | *.csv"

        If sfd.ShowDialog() = DialogResult.OK Then
            Using sw As StreamWriter = File.CreateText(sfd.FileName)
                Dim dgvColumnNames As List(Of String) = dgv.Columns.Cast(Of DataGridViewColumn).ToList().Select(Function(c) c.Name).ToList()
                sw.WriteLine(String.Join(",", dgvColumnNames))

                For Each row As DataGridViewRow In dgv.Rows
                    Dim rowData As New List(Of String)
                    For Each column As DataGridViewColumn In dgv.Columns
                        rowData.Add(Convert.ToString(row.Cells(column.Name).Value))
                    Next
                    sw.WriteLine(String.Join(",", rowData))
                Next
                Process.Start(sfd.FileName)
            End Using
        End If
    End Sub

    Public Sub import_file(dgv As DataGridView, ProfileContainer As Panel, section As String)
        If dgv.Rows.Count > 0 Then
            For i As Integer = 0 To dgv.Rows.Count - 1 Step +1
                Dim ms As New MemoryStream
                ProfileContainer.BackgroundImage.Save(ms, ProfileContainer.BackgroundImage.RawFormat)
                If checkIfStudentExist(dgv.Rows(i).Cells(0).Value.ToString()) Then
                    Dim dialogResult As DialogResult = MessageBox.Show("Do you want to register this student?", "Register", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If dialogResult = DialogResult.Yes Then
                        conn.Open()
                        Try
                            comm = New MySqlCommand("prcInsertStudent", conn)
                            With comm
                                .CommandType = CommandType.StoredProcedure
                                .Parameters.AddWithValue("@sid", dgv.Rows(i).Cells(0).Value.ToString())
                                .Parameters.AddWithValue("@sfname", dgv.Rows(i).Cells(1).Value.ToString())
                                .Parameters.AddWithValue("@smname", dgv.Rows(i).Cells(2).Value.ToString())
                                .Parameters.AddWithValue("@slname", dgv.Rows(i).Cells(3).Value.ToString())
                                .Parameters.AddWithValue("@sgender", dgv.Rows(i).Cells(4).Value.ToString())
                                .Parameters.AddWithValue("@saddress", dgv.Rows(i).Cells(5).Value.ToString())
                                .Parameters.AddWithValue("@pname", dgv.Rows(i).Cells(6).Value.ToString())
                                .Parameters.AddWithValue("@pnum", dgv.Rows(i).Cells(7).Value.ToString())
                                .Parameters.AddWithValue("@eadd", dgv.Rows(i).Cells(8).Value.ToString())
                                .ExecuteNonQuery()
                            End With
                        Catch ex As Exception
                            conn.Close()
                            MessageBox.Show(ex.Message)
                        Finally
                            conn.Dispose()
                        End Try
                        conn.Close()

                        conn.Open()
                        Try
                            comm = New MySqlCommand("prcInsertStudent", conn)
                            With comm
                                .CommandType = CommandType.StoredProcedure
                                .Parameters.AddWithValue("@sid", dgv.Rows(i).Cells(0).Value.ToString())
                                .Parameters.AddWithValue("@sfname", dgv.Rows(i).Cells(1).Value.ToString())
                                .Parameters.AddWithValue("@smname", dgv.Rows(i).Cells(2).Value.ToString())
                                .Parameters.AddWithValue("@slname", dgv.Rows(i).Cells(3).Value.ToString())
                                .Parameters.AddWithValue("@sgender", dgv.Rows(i).Cells(4).Value.ToString())
                                .Parameters.AddWithValue("@saddress", dgv.Rows(i).Cells(5).Value.ToString())
                                .Parameters.AddWithValue("@pname", dgv.Rows(i).Cells(6).Value.ToString())
                                .Parameters.AddWithValue("@pnum", dgv.Rows(i).Cells(7).Value.ToString())
                                .Parameters.AddWithValue("@eadd", dgv.Rows(i).Cells(8).Value.ToString())
                                .ExecuteNonQuery()
                            End With
                        Catch ex As Exception
                            conn.Close()
                            MessageBox.Show(ex.Message)
                        Finally
                            conn.Dispose()
                        End Try
                        conn.Close()
                    End If
                Else
                    Try
                        conn.Open()
                        comm = New MySqlCommand("INSERT INTO tbl_student(lrn, fname, mname, lname, gender, address, parent_name, contact_number, email_address, display_picture, section) VALUES (@slrn, @sfname, @smname, @slname, @sgender, @saddress, @spname, @scnum, @seaddm, @sdp, @ssection)", conn)
                        comm.Parameters.Add("@slrn", MySqlDbType.VarChar).Value = dgv.Rows(i).Cells(0).Value.ToString()
                        comm.Parameters.Add("@sfname", MySqlDbType.VarChar).Value = dgv.Rows(i).Cells(1).Value.ToString()
                        comm.Parameters.Add("@smname", MySqlDbType.VarChar).Value = dgv.Rows(i).Cells(2).Value.ToString()
                        comm.Parameters.Add("@slname", MySqlDbType.VarChar).Value = dgv.Rows(i).Cells(3).Value.ToString()
                        comm.Parameters.Add("@sgender", MySqlDbType.VarChar).Value = dgv.Rows(i).Cells(4).Value.ToString()
                        comm.Parameters.Add("@saddress", MySqlDbType.VarChar).Value = dgv.Rows(i).Cells(5).Value.ToString()
                        comm.Parameters.Add("@spname", MySqlDbType.VarChar).Value = dgv.Rows(i).Cells(6).Value.ToString()
                        comm.Parameters.Add("@scnum", MySqlDbType.VarChar).Value = dgv.Rows(i).Cells(7).Value.ToString()
                        comm.Parameters.Add("@seaddm", MySqlDbType.VarChar).Value = dgv.Rows(i).Cells(8).Value.ToString()
                        comm.Parameters.Add("@sdp", MySqlDbType.LongBlob).Value = ms.ToArray()
                        comm.Parameters.Add("@ssection", MySqlDbType.VarChar).Value = section
                        adapter = New MySqlDataAdapter(comm)
                        comm.ExecuteNonQuery()
                    Catch ex As Exception
                        conn.Close()
                        MessageBox.Show(ex.Message)
                    Finally
                        conn.Dispose()
                    End Try
                    conn.Close()
                End If
            Next
        Else
            MsgBox("Table is empty")
        End If

    End Sub

    Function checkIfStudentExist(sLRN As String) As Boolean
        Try
            conn.Open()
            comm = New MySqlCommand("SELECT COUNT(*) FROM tbl_student WHERE lrn = '" & sLRN & "'", conn)
            adapter = New MySqlDataAdapter(comm)
            Dim table As New DataTable()
            adapter.Fill(table)

            If table.Rows.Count = 0 Then
                Return True
            Else
                If table.Rows(0).Item(0).ToString() = "0" Then
                    Return False
                Else
                    Return True
                End If
            End If
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
        Return False
        conn.Close()
    End Function

    Public Sub InsertToLogs(sLRN As String)
        Dim commandString As String = ""
        If CheckIfLogExist(sLRN) Then
            If ValidateTimeLog() = "Timein AM" Then
                commandString = "UPDATE tbl_logs SET timeIN_AM = '" & Format(DateTime.Now, "HH:mm:ss") & "' WHERE logcurrent_date='" & DateTime.Now.ToString("yyyy/MM/dd") & "' AND lrn = '" & sLRN & "'"
            ElseIf ValidateTimeLog() = "Timeout AM" Then
                commandString = "UPDATE tbl_logs SET timeOUT_AM = '" & Format(DateTime.Now, "HH:mm:ss") & "' WHERE logcurrent_date ='" & DateTime.Now.ToString("yyyy/MM/dd") & "' AND lrn = '" & sLRN & "'"
            ElseIf ValidateTimeLog() = "Timein PM" Then
                commandString = "UPDATE tbl_logs SET timeIN_PM = '" & Format(DateTime.Now, "HH:mm:ss") & "' WHERE logcurrent_date = '" & DateTime.Now.ToString("yyyy/MM/dd") & "' AND lrn = '" & sLRN & "'"
            ElseIf ValidateTimeLog() = "Timeout PM" Then
                commandString = "UPDATE tbl_logs SET timeOUT_PM = '" & Format(DateTime.Now, "HH:mm:ss") & "' WHERE logcurrent_date = '" & DateTime.Now.ToString("yyyy/MM/dd") & "' AND lrn = '" & sLRN & "'"
            End If
        Else
            If ValidateTimeLog() = "Timein AM" Then
                commandString = "INSERT INTO tbl_logs(lrn, timeIN_AM, logcurrent_date) VALUES ('" & sLRN & "', '" & Format(DateTime.Now, "HH:mm:ss") & "', '" & Format(DateTime.Now, "yyyy/MM/dd") & "')"
            ElseIf ValidateTimeLog() = "Timeout AM" Then
                commandString = "INSERT INTO tbl_logs(lrn, timeOUT_AM, logcurrent_date) VALUES ('" & sLRN & "', '" & Format(DateTime.Now, "HH:mm:ss") & "', '" & Format(DateTime.Now, "yyyy/MM/dd") & "')"
            ElseIf ValidateTimeLog() = "Timein PM" Then
                commandString = "INSERT INTO tbl_logs(lrn, timeIN_PM, logcurrent_date) VALUES ('" & sLRN & "', '" & Format(DateTime.Now, "HH:mm:ss") & "', '" & Format(DateTime.Now, "yyyy/MM/dd") & "')"
            ElseIf ValidateTimeLog() = "Timeout PM" Then
                commandString = "INSERT INTO tbl_logs(lrn, timeOUT_PM, logcurrent_date) VALUES ('" & sLRN & "', '" & Format(DateTime.Now, "HH:mm:ss") & "', '" & Format(DateTime.Now, "yyyy/MM/dd") & "')"
            End If
        End If
        InsertTheLogs(commandString)
    End Sub

    Public Sub InsertTheLogs(cmdStr As String)
        Try
            conn.Open()
            comm = New MySqlCommand(cmdStr, conn)
            adapter = New MySqlDataAdapter(comm)
            comm.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
        conn.Close()
    End Sub
    Public Function ValidateTimeLog()
        Dim timeinAMRange_1 As DateTime = #12:00:00 AM#
        Dim timeinAMRange_2 As DateTime = #11:59:00 AM#
        Dim timeoutAMRange_1 As DateTime = #12:00:00 PM#
        Dim timeoutAMRange_2 As DateTime = #12:30:00 PM#
        Dim timeinPMRange_1 As DateTime = #12:31:00 PM#
        Dim timeinPMRange_2 As DateTime = #4:59:00 PM#
        Dim timeoutPMRange_1 As DateTime = #5:00:00 PM#
        Dim timeoutPMRange_2 As DateTime = #11:59:00 PM#


        If DateTime.Now.TimeOfDay >= timeinAMRange_1.TimeOfDay And DateTime.Now.TimeOfDay <= timeinAMRange_2.TimeOfDay Then
            Return "Timein AM"
        ElseIf DateTime.Now.TimeOfDay >= timeoutAMRange_1.TimeOfDay And DateTime.Now.TimeOfDay <= timeoutAMRange_2.TimeOfDay Then
            Return "Timeout AM"
        ElseIf DateTime.Now.TimeOfDay >= timeinPMRange_1.TimeOfDay And DateTime.Now.TimeOfDay <= timeinPMRange_2.TimeOfDay Then
            Return "Timein PM"
        ElseIf DateTime.Now.TimeOfDay >= timeoutPMRange_1.TimeOfDay And DateTime.Now.TimeOfDay <= timeoutPMRange_2.TimeOfDay Then
            Return "Timeout PM"
        Else
            Return "Error"
        End If
    End Function

    Public Function CheckIfLogExist(sLRN As String) As String
        Dim currentDate As String
        currentDate = Date.Now.ToString("yyyy/MM/dd")
        Try
            conn.Open()
            comm = New MySqlCommand("SELECT * FROM tbl_logs WHERE lrn = '" & sLRN & "' AND logcurrent_date = '" & currentDate & "'", conn)
            adapter = New MySqlDataAdapter(comm)
            Dim table As New DataTable()
            adapter.Fill(table)

            If table.Rows.Count = 0 Then
                Return False
            Else
                If table.Rows(0).Item(0).ToString() = "0" Then
                    Return False
                Else
                    Return True
                End If
            End If

            conn.Close()
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
        conn.Close()
        Return False
    End Function

    'Function CloudinaryStorage(path As String, sLRN As String) As String
    '    Dim acc As New Account(CLOUD_NAME, API_KEY, API_SECRET)
    '    cloudinary = New Cloudinary(acc)
    '    cloudinary.Api.Secure = True
    '    cloudinary.Api.UrlImgUp.Transform(New Transformation().Quality(50).FetchFormat("auto"))
    '    Return uploadImage(path, sLRN)
    'End Function

    'Public Sub deleteImage(sLRN As String)
    '    Dim acc As New Account(CLOUD_NAME, API_KEY, API_SECRET)
    '    cloudinary = New Cloudinary(acc)
    '    Dim DeletionParams = New DeletionParams("display_picture/" & sLRN)
    '    cloudinary.DeleteFolder("display_picture/" & sLRN)
    '    cloudinary.Destroy(DeletionParams)
    'End Sub

    'Function uploadImage(path As String, sLRN As String) As String
    '    Dim uploadParams = New ImageUploadParams
    '    uploadParams.Folder = "display_picture/" + sLRN
    '    uploadParams.PublicId = sLRN
    '    uploadParams.File = New FileDescription(path)
    '    Dim uploadResult = cloudinary.Upload(uploadParams)
    '    Return uploadResult.Url.ToString
    'End Function

    'Function checkIfImageExist(sURL As String) As Boolean
    '    Try
    '        Using client = New WebClient()
    '            Using stream = client.OpenRead(sURL)
    '                Return True
    '            End Using
    '        End Using
    '    Catch
    '        Return False
    '    End Try
    'End Function
End Module
