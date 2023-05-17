﻿Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.IO
Imports System.Security.Permissions
Imports System.Windows.Forms.AxHost
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Google.Protobuf.WellKnownTypes
Imports K4os.Compression.LZ4.Streams
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1


Public Class LoansForm
    Dim CurrentMonth As String = Today.Month
    Dim CurrentYear As String = Today.Year

    Dim qStartDate As String = CurrentYear + "-" + CurrentMonth + "-01"
    Dim qEndDate As String = CurrentYear + "-" + CurrentMonth + "-31"
    Dim qstatus As String = "*"


    Private Sub LoansForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        'for datagridview
        Try
            reloaData("SELECT loans.transacID, loans.accID, login.Sname, login.Fname, loans.transacDate, loans.duedate, loans.principal, loans.loanstatus
                       FROM loans
                       LEFT JOIN login
                       ON loans.accID = login.id", Guna2DataGridView1)

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
            cmd.CommandText = "SELECT SUM(interest) AS totalInterest FROM loans WHERE DATE(dueDate) BETWEEN ' " & qStartDate & " ' AND '" & qEndDate & "'"

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

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick
        Try
            If Guna2DataGridView1.Columns(e.ColumnIndex).Name = "button" Then
                Dim dr As DataGridViewRow = Guna2DataGridView1.SelectedRows(0)
                txtAcc.Text = dr.Cells(2).Value.ToString()
                txtTransac.Text = dr.Cells(1).Value.ToString()
                txtFname.Text = dr.Cells(4).Value.ToString()
                txtLname.Text = dr.Cells(3).Value.ToString()
                txtAmount.Text = dr.Cells(7).Value.ToString()
                comboStatus.Text = dr.Cells(8).Value.ToString()


            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        If txtAcc.Text = "" Then
            MessageBox.Show("Please select the record you want to update")

        Else
            'updating status
            Try
                reloadData("Select * FROM loans WHERE transacID= " & txtTransac.Text & "")
                If database.dt.Rows.Count > 0 Then

                    updates("UPDATE loans SET loanstatus = '" & comboStatus.Text & "' WHERE loans.transacID = " & txtTransac.Text & "")
                    Dim msg As String = "Record Updated Successfully"
                    Dim title As String = "Loan Status Change"
                    Dim result = MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Try
                        reloadData("Select * FROM loans WHERE transacID= '" & txtTransac.Text & "' AND loanstatus = 'Approved' AND approvalNotice = 0")
                        If database.dt.Rows.Count > 0 Then
                            approvalMechanism()
                        Else

                        End If
                    Catch

                    End Try

                Else
                    MessageBox.Show("Failed to Update Loan Status") 'change
                End If
            Catch ex As Exception
                MessageBox.Show("Error, you must complete details" & ex.Message.ToString)

            End Try

            'sending approval notics

        End If

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If comboShow.Text = "All" Then
            qstatus = ""
        Else
            qstatus = "WHERE loans.loanstatus = '" + comboShow.Text + "'"
        End If

        Try
            reloaData("SELECT loans.transacID, loans.accID, login.Sname, login.Fname, loans.transacDate, loans.duedate, loans.principal, loans.loanstatus
                       FROM loans
                       LEFT JOIN login
                       ON loans.accID = login.id
                       " & qstatus & "
                       ", Guna2DataGridView1)

        Catch

        End Try

    End Sub

    'FilePrinter


    Dim WithEvents PD As New PrintDocument

    Sub approvalMechanism() 'notfies client that their loan has been approved through email

        Dim filenameVar As String = "Approval_" & CurrentMonth & "_" & CurrentYear & "_" & txtLname.Text & txtFname.Text & ".pdf"

        PD.PrintController = New System.Drawing.Printing.StandardPrintController
        PD.PrinterSettings.PrintToFile = True
        PD.PrinterSettings.PrinterName = "Microsoft Print to PDF"
        PD.PrinterSettings.PrintFileName = "C:\Users\xland\Documents\" + filenameVar 'CHANGE!!!!
        PD.Print()

    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Legal", 850, 1400) 'fixed size
        PD.DefaultPageSettings = pagesetup


    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f8 As New Font("Calibri", 16, FontStyle.Regular)
        Dim f10 As New Font("Calibri", 20, FontStyle.Regular)
        Dim f10b As New Font("Calibri", 20, FontStyle.Bold)
        Dim f14 As New Font("Calibri", 28, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        'font alignment
        Dim right As New StringFormat
        Dim center As New StringFormat

        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        Dim line As String
        line = "*****************************************************************************"

        Dim logoImage As Image = My.Resources.ResourceManager.GetObject("logo-no-background")
        e.Graphics.DrawImage(logoImage, CInt((e.PageBounds.Width - 150) / 2), 5, 150, 35)

        e.Graphics.DrawString("Barangay Bay", f10, Brushes.Black, centermargin, 60, center)
        e.Graphics.DrawString("Phone : 09999999999", f10, Brushes.Black, centermargin, 85, center)

        e.Graphics.DrawString("Transaction ID", f8, Brushes.Black, 0, 125)
        e.Graphics.DrawString(": ", f8, Brushes.Black, 200, 125)
        e.Graphics.DrawString(txtTransac.Text, f8, Brushes.Black, 250, 125)

        e.Graphics.DrawString("Customer Name", f8, Brushes.Black, 0, 145)
        e.Graphics.DrawString(": ", f8, Brushes.Black, 200, 145)
        e.Graphics.DrawString(txtLname.Text + ", " + txtFname.Text, f8, Brushes.Black, 250, 145) '

        e.Graphics.DrawString("Approved On", f8, Brushes.Black, 0, 165)
        e.Graphics.DrawString(": ", f8, Brushes.Black, 200, 165)
        e.Graphics.DrawString(Date.Now.ToString(), f8, Brushes.Black, 250, 165)
        'DetailHeader

        '
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 195)

        Dim height As Integer

        tempCalc()
        Dim interestTemp = CType(interestCalc, String)
        Dim totalTemp = CType(totalCalc, String)


        height += 40

        e.Graphics.DrawString("Principal Amount: ", f8, Brushes.Black, 0, 165 + height)
        e.Graphics.DrawString(txtAmount.Text, f10b, Brushes.Black, rightmargin, 165 + height, right)

        e.Graphics.DrawString("Interest Amount: ", f8, Brushes.Black, 0, 185 + height)
        e.Graphics.DrawString(interestTemp, f10b, Brushes.Black, rightmargin, 185 + height, right)

        Dim height2 As Integer
        height2 = 215 + height

        e.Graphics.DrawString(line, f8, Brushes.Black, 0, height2)
        e.Graphics.DrawString("Total: " + totalTemp, f10b, Brushes.Black, rightmargin, 10 + height2, right)

        e.Graphics.DrawString("~ Congratulations! Your application has been APPROVED! ~", f10, Brushes.Black, centermargin, 70 + height2, center)
        e.Graphics.DrawString("~ Thank you for availing our loan ~", f10, Brushes.Black, centermargin, 90 + height2, center)
        'e.Graphics.DrawString("~ Rosmar Kagayaku ~", f10, Brushes.Black, centermargin, 85 + height2, center)
    End Sub

    Dim interestCalc As Long = 0
    Dim totalCalc As Long = 0

    Sub tempCalc()
        Dim principalTemp As Long

        principalTemp = CType(txtAmount.Text, Long)

        interestCalc = principalTemp * 0.05
        totalCalc = principalTemp + interestCalc


    End Sub
End Class