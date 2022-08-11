﻿Imports System.Net.Mail
Imports System.IO
Imports MySql.Data.MySqlClient
Module PublicFunctions
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

            Dim attachment As System.Net.Mail.Attachment
            attachment = New System.Net.Mail.Attachment(Application.StartupPath & "\student_id\" & LRN & ".png")
            email.Attachments.Add(attachment)

            smpt_server.Send(email)
        Catch ex As Exception
            MsgBox(ex.Message)
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

    Public Sub import_file(dgv As DataGridView, ProfileContainer As Panel)
        If dgv.Rows.Count > 0 Then
            For i As Integer = 0 To dgv.Rows.Count - 1 Step +1
                Dim ms As New MemoryStream
                ProfileContainer.BackgroundImage.Save(ms, ProfileContainer.BackgroundImage.RawFormat)
                Try
                    conn.Open()
                    comm = New MySqlCommand("INSERT INTO tbl_student(lrn, fname, mname, lname, gender, address, parent_name, contact_number, email_address, display_picture) VALUES (@slrn, @sfname, @smname, @slname, @sgender, @saddress, @spname, @scnum, @seaddm, @sdp)", conn)
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

                    adapter = New MySqlDataAdapter(comm)
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    MessageBox.Show(ex.Message)
                Finally
                    conn.Dispose()
                End Try
                conn.Close()
            Next
        Else
            MsgBox("Table is empty")
        End If

    End Sub

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
        InsertTheLogs(sLRN, commandString)
    End Sub

    Public Sub InsertTheLogs(sLRN As String, cmdStr As String)
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

End Module
