Public Class Home
    Dim veriFlag As Boolean
    Dim loanFlag As Boolean
    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Application.Exit()

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        veriCheck()
        loanCountCheck()

        If Not veriFlag = True Then
            MessageBox.Show("Please wait for your account to be verified")
        ElseIf Not loanFlag = False Then
            MessageBox.Show("Please settle your existing loan before applying for another one")
        Else
            GetLoan2.ShowDialog()
            Me.Hide()
        End If

    End Sub

    Sub veriCheck()
        reloadData("Select * FROM login WHERE id='" & Form1.UserID & "' AND verified='1'")
        If database.dt.Rows.Count > 0 Then
            veriFlag = True
        End If
    End Sub

    Sub loanCountCheck()
        reloadData("Select * FROM loans WHERE accID='" & Form1.UserID & "'")
        If database.dt.Rows.Count > 0 Then
            loanFlag = True
        End If
    End Sub
End Class