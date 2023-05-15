Imports System.Net.Mail
Imports Microsoft

Public Class GetLoan
    Private Sub GetLoan_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub



    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click

        Try
            Dim mail As New MailMessage()
            Dim smtpserver As New SmtpClient("smtp.gmail.com")
            mail.From = New MailAddress("ltrsofficial31@gmail.com")
            mail.To.Add("ltrsofficial0@gmail.com") 'change email
            mail.Subject = "Initial Loan Requirements"
            mail.Body = "test" 'put stuff from other deets

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
        End Try




    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
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
End Class