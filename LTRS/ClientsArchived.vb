Imports MySql.Data.MySqlClient

Public Class ClientsArchived
    Dim varID As String
    Dim varSname As String
    Dim varFname As String
    Dim varEmail As String
    Dim varPhone As String
    Dim varBdate As Date
    Dim varBdatequery As String
    Dim varPass As String
    Dim varVerified As String

    Private Sub ClientsArchived_Load(sender As Object, e As EventArgs) Handles Me.Load
        'for datagridview
        Try
            reloaData("SELECT id, Sname, Fname, email, phonenum, bdate FROM loginarchive", Guna2DataGridView1)

        Catch

        End Try
    End Sub

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick
        Try
            If Guna2DataGridView1.Columns(e.ColumnIndex).Name = "edit" Then
                Dim dr As DataGridViewRow = Guna2DataGridView1.SelectedRows(0)
                Guna2TextBox1.Text = dr.Cells(2).Value.ToString()
                Guna2TextBox2.Text = dr.Cells(3).Value.ToString()
                Guna2TextBox3.Text = dr.Cells(4).Value.ToString()
                Guna2TextBox4.Text = dr.Cells(5).Value.ToString()
                Guna2TextBox5.Text = dr.Cells(6).Value.ToString()
                Guna2TextBox6.Text = dr.Cells(7).Value.ToString()
                Guna2ComboBox1.Text = dr.Cells(8).Value.ToString()

            ElseIf Guna2DataGridView1.Columns(e.ColumnIndex).Name = "show" Then
                Dim dr As DataGridViewRow = Guna2DataGridView1.SelectedRows(0)
                Guna2TextBox1.Text = dr.Cells(2).Value.ToString()
                Guna2TextBox2.Text = dr.Cells(3).Value.ToString()
                Guna2TextBox3.Text = dr.Cells(4).Value.ToString()
                Guna2TextBox4.Text = dr.Cells(5).Value.ToString()
                Guna2TextBox5.Text = dr.Cells(6).Value.ToString()
                Guna2TextBox6.Text = dr.Cells(7).Value.ToString()


                publicvariables.txtID = Guna2TextBox1.Text
                publicvariables.txtSname = Guna2TextBox2.Text
                publicvariables.txtFname = Guna2TextBox3.Text

                LoansHistory.Show()

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Try
            strcon.Open()
            cmd.CommandText = "SELECT * FROM loginarchive WHERE id = '" & Guna2TextBox1.Text & "'"

            Dim myreader As MySqlDataReader = cmd.ExecuteReader
            If (myreader.Read()) Then
                varID = myreader("id")
                varSname = myreader("Sname")
                varFname = myreader("Fname")
                varEmail = myreader("email")
                varPhone = myreader("phonenum")
                varBdate = myreader("bdate")
                varBdatequery = varBdate.ToString("yyyy-MM-dd")
                varPass = myreader("password")
                varVerified = myreader("verified")

            Else
                MessageBox.Show("No Data Found")
            End If

        Catch ex As Exception
            MessageBox.Show("Error" & ex.Message.ToString)
        Finally
            cmd.Parameters.Clear()
            strcon.Close()
        End Try

        If Guna2ComboBox1.Text = "Verified" Then
            Try
                reloadData("Select * FROM loginarchive WHERE id = " & varID & "")
                If database.dt.Rows.Count > 0 Then

                    'insert
                    updates("INSERT INTO `login`(`id`, `Fname`, `Sname`, `email`, `phonenum`, `bdate`, `password`, `verified`) 
                                 VALUES ('" & varID & "','" & varFname & "','" & varSname & "','" & varEmail & "','" & varPhone & "','" & varBdatequery & "','" & varPass & "','1')")

                    'delete
                    updates("DELETE FROM `loginarchive` WHERE id = '" & varID & "'")

                    Dim msg As String = "Record Archived Successfully"
                    Dim title As String = "Account Status Change"
                    Dim result = MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Me.Refresh()

                Else
                    MessageBox.Show("Failed to Update Account Status")
                End If
            Catch ex As Exception
                MessageBox.Show("Error, you must complete details" & ex.Message.ToString)

            End Try

        ElseIf Guna2ComboBox1.Text = "Pending" Then
            Try
                reloadData("Select * FROM loginarchive WHERE id = " & varID & "")
                If database.dt.Rows.Count > 0 Then

                    'insert
                    updates("INSERT INTO `login`(`id`, `Fname`, `Sname`, `email`, `phonenum`, `bdate`, `password`, `verified`) 
                                 VALUES ('" & varID & "','" & varFname & "','" & varSname & "','" & varEmail & "','" & varPhone & "','" & varBdatequery & "','" & varPass & "','0')")

                    'delete
                    updates("DELETE FROM `loginarchive` WHERE id = '" & varID & "'")

                    Dim msg As String = "Record Archived Successfully"
                    Dim title As String = "Account Status Change"
                    Dim result = MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Me.Refresh()

                Else
                    MessageBox.Show("Failed to Update Account Status")
                End If
            Catch ex As Exception
                MessageBox.Show("Error, you must complete details" & ex.Message.ToString)

            End Try
        Else
            MessageBox.Show("Please select the account to update")
        End If

    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Admin_Panel.Show()
        Me.Close()
    End Sub


End Class