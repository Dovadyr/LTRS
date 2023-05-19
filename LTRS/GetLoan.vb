Imports System.Net.Mail
Imports Microsoft
Imports Org.BouncyCastle.X509

Public Class GetLoan
    Dim dateToday As Date = Date.Today
    Dim dateDue As Date = DateAdd("d", 30, dateToday)

    Dim qdateToday As String = dateToday.ToString("yyyy-MM-dd")
    Dim qdateDue As String = dateDue.ToString("yyyy-MM-dd")

    Dim attach1Flag As Integer = 0
    Dim attach2Flag As Integer = 0

    Private Sub GetLoan_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub



    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        If attach1Flag And attach2Flag = 1 Then

            If Not String.Equals(attach1.Text, attach2.Text) Then
                Try
                    Dim mail As New MailMessage()
                    Dim smtpserver As New SmtpClient("smtp.gmail.com")
                    mail.From = New MailAddress("ltrsofficial31@gmail.com")
                    mail.To.Add("ltrsofficial0@gmail.com")
                    mail.Subject = "Initial Loan Requirements"
                    mail.Body = "Amount to Borrow : " + GetLoan2.loanAmountHolder

                    Dim Attach As System.Net.Mail.Attachment
                    Attach = New System.Net.Mail.Attachment(attach1.Text)
                    mail.Attachments.Add(Attach)
                    Attach = New System.Net.Mail.Attachment(attach2.Text)
                    mail.Attachments.Add(Attach)


                    smtpserver.Port = 587
                    smtpserver.Credentials = New System.Net.NetworkCredential("ltrsofficial31@gmail.com", "qrowiwzlsnhprwgt")
                    smtpserver.EnableSsl = True
                    smtpserver.Send(mail)
                    MsgBox("Mail has been Successfully Sent! ", MsgBoxStyle.Information)
                Catch ex As Exception
                    MsgBox(ex.Message, vbCritical)
                Finally
                    create("INSERT INTO loans (`accID`, `principal`, `interest`, `total`, `loanstatus`)VALUES('" & Form1.UserID & "', '" & GetLoan2.inputLoan.Text & "', '" & GetLoan2.interestBox.Text & "', '" & GetLoan2.outputTotal.Text & "', 'Pending')")

                    Dim msg As String = "Registered Successfully"
                    Dim title As String = "Registration"
                    Dim result = MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information)

                    attach1Flag = 0
                    attach2Flag = 0

                    Home.Show()
                    Me.Hide()
                End Try

            Else
                MessageBox.Show("The submitted files are identical to each other")
            End If

        Else
            MessageBox.Show("Please submit complete initial requirements")
        End If

    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs)
        Me.Hide()

    End Sub

    Private Sub btnID_Click(sender As Object, e As EventArgs) Handles btnID.Click
        OpenFileDialog1.ShowDialog()
        attach1.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub btnBill_Click(sender As Object, e As EventArgs) Handles btnBill.Click
        OpenFileDialog1.ShowDialog()
        attach2.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub attach1_TextChanged(sender As Object, e As EventArgs) Handles attach1.TextChanged
        If attach1.Text = "OpenFileDialog1" Then
            attach1.Text = ""
        Else
            attach1Flag = 1
        End If

    End Sub

    Private Sub attach2_TextChanged(sender As Object, e As EventArgs) Handles attach2.TextChanged
        If attach2.Text = "OpenFileDialog1" Then
            attach2.Text = ""
        Else
            attach2Flag = 1
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        GetLoan2.Show()
        Me.Hide()
    End Sub
End Class