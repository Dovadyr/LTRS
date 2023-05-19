Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class Admin_Panel
    Dim CurrentMonth As String = Today.Month
    Dim CurrentYear As String = Today.Year
    Dim nextMonth As Date = DateAdd("d", 30, Date.Today)
    Dim nextMonthStr As String = nextMonth.ToString("MM")
    Dim nextDayStr As String = nextMonth.ToString("MM") '

    Dim qStartDate As String = CurrentYear + "-" + CurrentMonth + "-01"
    Dim qEndDate As String = CurrentYear + "-" + CurrentMonth + "-30"

    Dim qPredictStart As String = CurrentYear + "-" + nextMonthStr + "-01"
    Dim qPredictEnd As String = CurrentYear + "-" + nextMonthStr + "-30"
    'Dim qPredictEnd As String = nextMonth

    Private Sub Admin_Panel_Load(sender As Object, e As EventArgs) Handles Me.Load
        'for datagridview
        Try
            reloaData("SELECT transacID, accID, principal, interest, total FROM loans WHERE loanstatus = 'Pending'", Guna2DataGridView1)

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

        'for Predicted Earnings
        Try
            strcon.Open()
            cmd.CommandText = "SELECT SUM(interest) AS totalInterest FROM loans WHERE DATE(dueDate) BETWEEN ' " & qPredictStart & " ' AND '" & qPredictEnd & "'"

            'cmd.Parameters.Add("@month", MySqlDbType.VarChar).Value = CurrentMonth
            'cmd.Parameters.Add("@year", MySqlDbType.VarChar).Value = CurrentYear

            Dim myreader As MySqlDataReader = cmd.ExecuteReader
            If (myreader.Read()) Then
                TotalEarnings.Text = myreader("totalInterest")
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
            cmd.CommandText = "SELECT COUNT(*) AS active FROM loans WHERE loanstatus = 'Approved'"

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

    Private Sub btnToLoans_Click(sender As Object, e As EventArgs) Handles btnToLoans.Click
        Me.Hide()
        LoansForm.ShowDialog()
    End Sub

    Private Sub btnToEdit_Click(sender As Object, e As EventArgs) Handles btnToEdit.Click

    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Me.Close()
        Application.Exit()

    End Sub
End Class