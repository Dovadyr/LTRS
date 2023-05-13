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
                       computation.monthly, computation.totalAmount  
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
        End Try

        'for Predicted

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