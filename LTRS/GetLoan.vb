Imports System.Drawing.Printing
Imports System.IO
Imports System.Net.Mail
Imports Google.Protobuf.WellKnownTypes
Imports K4os.Compression.LZ4.Streams
Imports System.Text.RegularExpressions
Imports Microsoft
Imports Org.BouncyCastle.Asn1
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

    Sub primaryDetails()

        Dim fdate = Register.Bdate.Value.ToString("yyyy-MM-dd")
        Try
            reloadData("Select * FROM login WHERE email='" & Register.Email.Text & "' OR phonenum='" & Register.Pnum.Text & "'")
            If database.dt.Rows.Count > 0 Then
                MessageBox.Show("These credentials already have an account")
            Else
                create("INSERT INTO login (`Fname`, `Sname`, `email`, `phonenum`, `bdate`, `password`)VALUES('" & Register.Fname.Text & "', '" & Register.Sname.Text & "', '" & Register.Email.Text & "', '" & Register.Pnum.Text & "', '" & fdate & "', '" & Register.Password.Text & "')")
                Dim msg As String = "Submitted Successfully"
                Dim title As String = "Registration"
                Dim result = MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                If result = DialogResult.OK Then
                    Me.Hide()
                    Dim Register As New Form1
                    Register.ShowDialog()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error, you must complete details" & ex.Message.ToString)

        End Try
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        If Not Guna2CheckBox1.Checked = True Then
            MessageBox.Show("You have to Read and Agree to the Terms and Conditions in order to register")
        ElseIf Not linkFlag = True Then
            MessageBox.Show("You have to Read the Terms and Conditions in order to agree")
        Else
            If attach1Flag And attach2Flag = 1 Then

                If Not String.Equals(attach1.Text, attach2.Text) Then
                    Try
                        Dim mail As New MailMessage()
                        Dim smtpserver As New SmtpClient("smtp.gmail.com")
                        mail.From = New MailAddress("ltrsofficial31@gmail.com")
                        mail.To.Add("ltrsofficial0@gmail.com")
                        mail.Subject = "Initial Requirements"
                        mail.Body = "Name : " + Register.Sname.Text + ", " + Register.Fname.Text & Environment.NewLine &
                                    "Address : " + Guna2TextBox1.Text + " " & Environment.NewLine

                        Dim Attach As System.Net.Mail.Attachment
                        Attach = New System.Net.Mail.Attachment(attach1.Text)
                        mail.Attachments.Add(Attach)
                        Attach = New System.Net.Mail.Attachment(attach2.Text)
                        mail.Attachments.Add(Attach)


                        smtpserver.Port = 587
                        smtpserver.Credentials = New System.Net.NetworkCredential("ltrsofficial31@gmail.com", "qrowiwzlsnhprwgt")
                        smtpserver.EnableSsl = True
                        smtpserver.Send(mail)
                    Catch ex As Exception
                        MsgBox(ex.Message, vbCritical)
                    Finally
                        primaryDetails()

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
        OpenFileDialog1.Filter = "JPEGs|*.jpg|PDF|*.pdf|PNG|*.png"
        OpenFileDialog1.FilterIndex = 1
        attach1.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub btnBill_Click(sender As Object, e As EventArgs) Handles btnBill.Click
        OpenFileDialog1.ShowDialog()
        OpenFileDialog1.Filter = "JPEGs|*.jpg|PDF|*.pdf|PNG|*.png"
        OpenFileDialog1.FilterIndex = 1
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
        Register.Show()
        Me.Hide()
    End Sub

    Dim linkFlag As Boolean
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim pdf As Byte() = My.Resources.TermsAndConditions
        Using tmp As New FileStream("TermsAndConditions.pdf", FileMode.Create)
            tmp.Write(pdf, 0, pdf.Length)
        End Using
        Process.Start("TermsAndConditions.pdf")
        linkFlag = True
    End Sub

End Class