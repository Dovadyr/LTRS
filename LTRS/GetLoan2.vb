Imports System.Globalization
Imports System.Text.RegularExpressions

Public Class GetLoan2
    Private Sub inputLoan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles inputLoan.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim textInputA As String
        Dim textInputB As String
        Dim a = inputLoan.Text
        Dim b = 0.05
        Dim c = a * b 'compute interest
        Dim d = a + c 'add principal and interest

        textInputA = CType(a, String)
        textInputB = CType(b, String)
        computeBox.Text = textInputA + " x " + textInputB
        outputTotal.Text = d
    End Sub
End Class