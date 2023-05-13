Imports System.Text.RegularExpressions

Public Class Register
    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub Pnum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Pnum.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        End If

        If Pnum.Text.Length >= 11 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim DOB As Date
        Dim DT As Date
        Dim span As TimeSpan
        Dim diff As Double
        Dim fdate As String

        Dim regex As Regex = New Regex("^[^@\s]+@[^@\s]+\.[^@\s]+$")
        Dim isvalid As Boolean = regex.IsMatch(Email.Text.Trim)

        DOB = Me.Bdate.Value.ToShortDateString
        DT = Now().ToShortDateString
        span = (DT - DOB)
        diff = span.Days
        diff = diff / 365
        fdate = Bdate.Value.ToString("yyyy-MM-dd")

        If String.IsNullOrWhiteSpace(Fname.Text) Or String.IsNullOrWhiteSpace(Sname.Text) Or String.IsNullOrWhiteSpace(Email.Text) Or String.IsNullOrWhiteSpace(Pnum.Text) Or String.IsNullOrWhiteSpace(Password.Text) Or String.IsNullOrWhiteSpace(ConPassword.Text) Then


            MessageBox.Show("Enter complete data first!")

        ElseIf Not Pnum.Text Like "09*" Then
            MessageBox.Show("Invalid Phone Number!")

        ElseIf Not isvalid Then
            MessageBox.Show("Invalid Email address!")

        ElseIf Not Password.Text Like ConPassword.Text Then
            MessageBox.Show("Passwords do not match!")

        ElseIf diff < 18 Then
            MessageBox.Show("You must be at least 18 years old!")

        Else
            Try
                reloadData("Select * FROM login WHERE email='" & Email.Text & "' OR phonenum='" & Pnum.Text & "'")
                If database.dt.Rows.Count > 0 Then
                    MessageBox.Show("These credentials already have an account")
                Else
                    create("INSERT INTO login (`Fname`, `Sname`, `email`, `phonenum`, `bdate`, `password`)VALUES('" & Fname.Text & "', '" & Sname.Text & "', '" & Email.Text & "', '" & Pnum.Text & "', '" & fdate & "', '" & Password.Text & "')")

                    Dim msg As String = "Registered Successfully"
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
        End If
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Me.Hide()
        Dim Register As New Form1
        Register.ShowDialog()
    End Sub


End Class