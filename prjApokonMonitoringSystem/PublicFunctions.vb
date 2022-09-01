Imports System.Net.Mail
Imports System.IO
Imports MySql.Data.MySqlClient
Module PublicFunctions
    Public teacherID As String
    Public Sub addUserControl(userControl As UserControl, pnl As Panel)
        userControl.Dock = DockStyle.Fill
        pnl.Controls.Clear()
        pnl.Controls.Add(userControl)
        userControl.BringToFront()
    End Sub

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

    Public Sub import_file(dgv As DataGridView, ProfileContainer As Panel, sectionID As String)
        If dgv.Rows.Count > 0 Then
            For i As Integer = 0 To dgv.Rows.Count - 1 Step +1
                Dim ms As New MemoryStream
                ProfileContainer.BackgroundImage.Save(ms, ProfileContainer.BackgroundImage.RawFormat)
                If checkIfStudentExist(dgv.Rows(i).Cells(0).Value.ToString()) Then
                    Dim dialogResult As DialogResult = MessageBox.Show("Student '" & dgv.Rows(i).Cells(0).Value.ToString() & "' already exists in the database. Do you want to overwrite / update the data?", "Import Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If dialogResult = DialogResult.Yes Then
                        conn.Open()
                        Try
                            comm = New MySqlCommand("prcUpdateStudentImport", conn)
                            With comm
                                .CommandType = CommandType.StoredProcedure
                                .Parameters.AddWithValue("@slrn", dgv.Rows(i).Cells(0).Value.ToString())
                                .Parameters.AddWithValue("@sfname", dgv.Rows(i).Cells(1).Value.ToString())
                                .Parameters.AddWithValue("@smname", dgv.Rows(i).Cells(2).Value.ToString())
                                .Parameters.AddWithValue("@slname", dgv.Rows(i).Cells(3).Value.ToString())
                                .Parameters.AddWithValue("@sgender", dgv.Rows(i).Cells(4).Value.ToString())
                                .Parameters.AddWithValue("@saddress", dgv.Rows(i).Cells(5).Value.ToString())
                                .Parameters.AddWithValue("@spname", dgv.Rows(i).Cells(6).Value.ToString())
                                .Parameters.AddWithValue("@scnum", dgv.Rows(i).Cells(7).Value.ToString())
                                .Parameters.AddWithValue("@seaddm", dgv.Rows(i).Cells(8).Value.ToString())
                                .Parameters.AddWithValue("@sdp", ms.ToArray())
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
                            comm = New MySqlCommand("prcUpdateStudentSection", conn)
                            With comm
                                .CommandType = CommandType.StoredProcedure
                                .Parameters.AddWithValue("@lrn", dgv.Rows(i).Cells(0).Value.ToString())
                                .Parameters.AddWithValue("@sid", sectionID)
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
                    Dim dialogResult As DialogResult = MessageBox.Show("Do you want to import this file?", "Import Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
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
                                .Parameters.AddWithValue("@dp", ms.ToArray())
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
                            comm = New MySqlCommand("prcInsertStudentSection", conn)
                            With comm
                                .CommandType = CommandType.StoredProcedure
                                .Parameters.AddWithValue("@lrn", dgv.Rows(i).Cells(0).Value.ToString())
                                .Parameters.AddWithValue("@sid", sectionID)
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

    Public Sub InsertToLogs(sLRN As String, currentDateTime As DateTime)
        Dim formattedCurrentTime = Format(currentDateTime, "HH:mm:ss")
        Dim formattedCurrentDate = currentDateTime.ToString("yyyy/MM/dd")

        Dim logType = GetStudentLogTypeFromDateTime(currentDateTime)
        Dim logTypeField = GetFieldOfStudentLogType(logType)

        Dim commandString As String

        If CheckIfLogExist(sLRN) Then
            commandString = "UPDATE tbl_logs SET " & logTypeField & " = '" & formattedCurrentTime & "' WHERE logcurrent_date='" & formattedCurrentDate & "' AND lrn = '" & sLRN & "'"
        Else
            commandString = "INSERT INTO tbl_logs(lrn, " & logTypeField & ", logcurrent_date) VALUES ('" & sLRN & "', '" & formattedCurrentTime & "', '" & formattedCurrentDate & "')"
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

    Public Function GetStudentLogTypeFromDateTime(dateTime As DateTime) As Enums.StudentLogType
        Dim timeinAMRange_1 As DateTime = #12:00:00 AM#
        Dim timeinAMRange_2 As DateTime = #11:59:00 AM#
        Dim timeoutAMRange_1 As DateTime = #12:00:00 PM#
        Dim timeoutAMRange_2 As DateTime = #12:30:00 PM#
        Dim timeinPMRange_1 As DateTime = #12:31:00 PM#
        Dim timeinPMRange_2 As DateTime = #4:59:00 PM#
        Dim timeoutPMRange_1 As DateTime = #5:00:00 PM#
        Dim timeoutPMRange_2 As DateTime = #11:59:00 PM#


        If dateTime.TimeOfDay >= timeinAMRange_1.TimeOfDay And dateTime.TimeOfDay <= timeinAMRange_2.TimeOfDay Then
            Return Enums.StudentLogType.TimeInAM
        ElseIf dateTime.TimeOfDay >= timeoutAMRange_1.TimeOfDay And dateTime.TimeOfDay <= timeoutAMRange_2.TimeOfDay Then
            Return Enums.StudentLogType.TimeOutAM
        ElseIf dateTime.TimeOfDay >= timeinPMRange_1.TimeOfDay And dateTime.TimeOfDay <= timeinPMRange_2.TimeOfDay Then
            Return Enums.StudentLogType.TimeInPM
        ElseIf dateTime.TimeOfDay >= timeoutPMRange_1.TimeOfDay And dateTime.TimeOfDay <= timeoutPMRange_2.TimeOfDay Then
            Return Enums.StudentLogType.TimeOutPM
        Else
            Throw New Exception("Error log type")
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
