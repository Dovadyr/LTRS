Imports System.Globalization
Imports System.Reflection
Imports System.Text.RegularExpressions

Public Class GetLoan2
    Dim aFlag As Boolean

    Public loanAmountHolder As String
    Private Sub inputLoan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles inputLoan.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If inputLoan.Text = "" Then
            MessageBox.Show("Please input amount to be calculated")

        Else

            aFlag = True


            Dim textInputA As String
            Dim textInputB As String
            Dim a = inputLoan.Text
            Dim b = 0.05
            Dim c = a * b 'compute interest
            Dim d = a + c 'add principal and interest

            textInputA = CType(a, String)
            textInputB = CType(b, String)
            loanAmountHolder = textInputA

            interestBox.Text = c
            computeBox.Text = textInputA + " x " + textInputB
            outputTotal.Text = d
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        If Not aFlag = False Then
            Me.Hide()
            GetLoan.ShowDialog()

        Else
            MessageBox.Show("Please enter the desired loan amount and press COMPUTE button")
        End If
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        aFlag = False
        inputLoan.Clear()
        computeBox.Clear()
        outputTotal.Clear()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Hide()
        Home.ShowDialog()
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Me.Close()
        Application.Exit()
    End Sub
End Class