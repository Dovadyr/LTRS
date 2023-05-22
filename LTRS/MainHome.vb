Imports System.Net.Mail
Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational

Public Class MainHome
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If String.IsNullOrWhiteSpace(Password.Text) Or String.IsNullOrWhiteSpace(Username.Text) Then
            MessageBox.Show("Enter complete data first!")
        Else
            strcon.Open()
            Try
                cmd.Connection = strcon
                cmd.CommandText = "SELECT * FROM admin WHERE username = @user and password = @pass;"

                cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = Username.Text
                cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = Password.Text
                da.SelectCommand = cmd
                da.Fill(dt)
                strcon.Close()
                da.Dispose()

                If dt.Rows.Count = 0 Then
                    Username.BorderColor = System.Drawing.Color.Tomato
                    Password.BorderColor = System.Drawing.Color.Tomato
                    MessageBox.Show("Invalid Username / Password", "Login Failed!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    Dim MainHome As New Admin_Panel
                    MainHome.Show()
                    Me.Hide()

                    Username.BorderColor = System.Drawing.Color.DodgerBlue
                    Password.BorderColor = System.Drawing.Color.DodgerBlue
                    Username.Clear()
                    Password.Clear()

                End If
            Catch ex As Exception
                MessageBox.Show("Error" & ex.Message.ToString)
            Finally
                cmd.Parameters.Clear()
            End Try

            reminderDue()

        End If
    End Sub
    Sub reminderDue()

        'Dim money As String
        'Dim time As String

        Try
            reloaData("SELECT loans.accID, loans.dueDate, loans.total, login.Fname, login.email 
                       FROM loans 
                       LEFT JOIN login
                       ON loans.accID = login.id
                       WHERE loans.dueDate = DATE_ADD(CURDATE(), INTERVAL 7 DAY) AND loans.loanstatus = 'Approved'", reminderWindow.Guna2DataGridView1)

        Catch

        End Try

        For Each row As DataGridViewRow In reminderWindow.Guna2DataGridView1.Rows
            'money = row.Cells(3).Value.ToString()
            'time = row.Cells(3).Value.ToString()

            ' Check if the row is not empty and has a valid email address in the last column
            If Not row.IsNewRow AndAlso IsValidEmail(row.Cells(4).Value.ToString()) Then
                Dim dateHold As Date = row.Cells(1).Value
                Dim penaltyHold As Decimal = row.Cells(2).Value
                penaltyHold = penaltyHold * 0.01

                Dim dateString As String = dateHold.ToString("MMMM d, yyyy (dddd)")

                ' Send email to the recipient
                Dim recipient As String = "beeflarkins@gmail.com" 'row.Cells(4).Value.ToString() 
                Dim subject As String = "Due Date is near"
                Dim body As String = "Friendly reminder that your loan that amounts to " & row.Cells(2).Value.ToString() & " is due by " & dateString & " . Failing to pay on time will come with a 1% percent penalty for each 30 days of delay which in your case will be " & penaltyHold & "  " 'Change to reminder stuff

                Try
                    SendEmail(recipient, subject, body)
                    Console.WriteLine("Email sent successfully to: " & recipient)
                Catch ex As Exception
                    Console.WriteLine("Failed to send email to: " & recipient)
                    Console.WriteLine("Error message: " & ex.Message)
                End Try
            End If
        Next

    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Me.Close()
        Application.Exit()
    End Sub

    Private Function IsValidEmail(email As String) As Boolean
        Try
            Dim mailAddress As New MailAddress(email)
            Return True
        Catch ex As FormatException
            Return False
        End Try
    End Function

    Private Sub SendEmail(recipient As String, subject As String, body As String)
        Dim smtpClient As New SmtpClient("smtp.gmail.com")
        Dim mailMessage As New MailMessage()

        ' Set the sender, recipient, subject, and body of the email
        mailMessage.From = New MailAddress("ltrsofficial31@gmail.com")
        mailMessage.[To].Add(recipient)
        mailMessage.Subject = subject
        mailMessage.Body = body

        smtpClient.Port = 587
        smtpClient.Credentials = New System.Net.NetworkCredential("ltrsofficial31@gmail.com", "qrowiwzlsnhprwgt")
        smtpClient.EnableSsl = True

        ' Send the email
        smtpClient.Send(mailMessage)
    End Sub
End Class