Imports MySql.Data.MySqlClient

Public Class EditFund

    Private Sub EditFund_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            strcon.Open()
            cmd.CommandText = "SELECT fundAmount FROM funds WHERE fundID = '1';"
            Dim myreader As MySqlDataReader = cmd.ExecuteReader
            If (myreader.Read()) Then
                txtCurrent.Text = myreader("fundAmount")
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

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click

        Me.Close()
        Admin_Panel.ShowDialog()

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Try
            reloadData("SELECT fundAmount FROM funds WHERE fundID = '1' ")
            If database.dt.Rows.Count > 0 Then

                updates("UPDATE funds SET fundAmount = '" & txtUpdate.Text & "' WHERE fundID = '1'")
                Dim msg As String = "Record Updated Successfully"
                Dim title As String = "Fund Update"
                Dim result = MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                Admin_Panel.ShowDialog()
            End If

        Catch ex As Exception
            MessageBox.Show("Error" & ex.Message.ToString)

        End Try

    End Sub


End Class