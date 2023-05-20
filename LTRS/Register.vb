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
        Dim specChar As Integer = 2

        Dim regex As Regex = New Regex("^[\w.+\-]+@gmail\.com$") '^[^@\s]+@[^@\s]+\.[^@\s]+$ ---> old one
        Dim isvalid As Boolean = regex.IsMatch(Email.Text.Trim)
        Dim isspecial As New System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]")


        DOB = Bdate.Value.ToShortDateString
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
        ElseIf Not Password.Text.Length >= 8 Then
            MessageBox.Show("Password must have at least 8 characters!")

        ElseIf Not symbolPassword(Password.Text) = True Then
            MessageBox.Show("Password must have at least 1 special character!")

        ElseIf Not Password.Text Like ConPassword.Text Then
            MessageBox.Show("Passwords do not match!")

        ElseIf diff < 18 Then
            MessageBox.Show("You must be at least 18 years old!")
        Else
            GetLoan.Show()

        End If
    End Sub

    Function symbolPassword(ByVal pwd As String, Optional ByVal numSpecial As Integer = 0) As Boolean

        Dim special As New System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]")

        If special.Matches(pwd).Count = numSpecial Then Return False

        Return True
    End Function

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Me.Hide()
        Dim Register As New Form1
        Register.ShowDialog()
    End Sub

    Private Sub passCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles passCheckbox.CheckedChanged
        If passCheckbox.Checked = True Then
            Password.PasswordChar = ""
            ConPassword.PasswordChar = ""
        Else
            Password.PasswordChar = "*"
            ConPassword.PasswordChar = "*"
        End If
    End Sub
End Class