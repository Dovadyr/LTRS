Public Class LoansHistory
    Private Sub LoansHistory_Load(sender As Object, e As EventArgs) Handles Me.Load
        Guna2TextBox1.Text = publicvariables.txtID
        Guna2TextBox2.Text = publicvariables.txtSname
        Guna2TextBox3.Text = publicvariables.txtFname

        Try
            reloaData("SELECT transacID, transacDate, dueDate, principal, loanstatus FROM loans WHERE accID = '" & publicvariables.txtID & "'", Guna2DataGridView1)

        Catch

        End Try
    End Sub
End Class