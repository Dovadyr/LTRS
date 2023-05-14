Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient
Public Class Admin_Panel
    Dim CurrentMonth As String = Today.Month
    Dim CurrentYear As String = Today.Year

    Private Sub Admin_Panel_Load(sender As Object, e As EventArgs) Handles Me.Load

        'for datagridview
        Try
            reloaData("SELECT loans.transacID, loans.accID,
                       loans.transacDate, loans.principal, 
                       computation.totalAmount  
                       FROM loans
                       LEFT JOIN computation 
                       ON loans.transacID = computation.transacID", Guna2DataGridView1)

        Catch

        End Try

        'for Current Fund
        Try
            strcon.Open()
            cmd.CommandText = "SELECT fundAmount FROM funds WHERE fundID = '1';"
            Dim myreader As MySqlDataReader = cmd.ExecuteReader
            If (myreader.Read()) Then
                CurrentMoney.Text = myreader("fundAmount")
            Else
                MessageBox.Show("No Data Found")
            End If

        Catch ex As Exception
            MessageBox.Show("Error" & ex.Message.ToString)
        Finally
            cmd.Parameters.Clear()
            strcon.Close()
        End Try

        'for Earnings
        Try
            strcon.Open()
            cmd.CommandText = "SELECT SUM(amount) AS Paid FROM payments WHERE DATE(payDate) BETWEEN '@year-@month-01' AND '2023-5-31'"

            cmd.Parameters.Add("@month", MySqlDbType.VarChar).Value = CurrentMonth
            cmd.Parameters.Add("@year", MySqlDbType.VarChar).Value = CurrentYear

            Dim myreader As MySqlDataReader = cmd.ExecuteReader
            If (myreader.Read()) Then
                TotalEarnings.Text = myreader("Paid")
            Else
                MessageBox.Show("No Data Found")
            End If

        Catch ex As Exception
            MessageBox.Show("Error" & ex.Message.ToString)
        Finally
            cmd.Parameters.Clear()
            strcon.Close()
        End Try

        'for Active Loan Count
        Try
            strcon.Open()
            cmd.CommandText = "SELECT COUNT(*) AS active FROM loans WHERE status = '0'"

            Dim myreader As MySqlDataReader = cmd.ExecuteReader
            If (myreader.Read()) Then
                ActiveLoans.Text = myreader("active")
            Else
                MessageBox.Show("No Data Found")
            End If

        Catch ex As Exception
            MessageBox.Show("Error" & ex.Message.ToString)
        Finally
            cmd.Parameters.Clear()
            strcon.Close()
        End Try
    End Sub

    Private Sub Guna2GradientCircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientCircleButton1.Click
        Me.Hide()
        Dim Admin_Panel As New ClientForm
        ClientForm.ShowDialog()
    End Sub

    Private Sub Guna2GradientCircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientCircleButton2.Click
        Me.Hide()
        Dim Admin_Panel As New LoansForm
        LoansForm.ShowDialog()
    End Sub


End Class