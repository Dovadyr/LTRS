﻿Imports Microsoft.Win32
Imports MySql.Data.MySqlClient

Public Class Form1
    Public UserID As Integer

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If String.IsNullOrWhiteSpace(Password.Text) Or String.IsNullOrWhiteSpace(Username.Text) Then
            MessageBox.Show("Enter complete data first!")
        Else
            strcon.Open()
            Try
                cmd.Connection = strcon
                cmd.CommandText = "SELECT * FROM login WHERE email = @user and password = @pass;"

                cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = Username.Text
                cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = Password.Text
                da.SelectCommand = cmd
                da.Fill(dt)
                da.Dispose()
                cmd.Parameters.Clear()

                If dt.Rows.Count = 0 Then
                    Username.BorderColor = System.Drawing.Color.Tomato
                    Password.BorderColor = System.Drawing.Color.Tomato
                    MessageBox.Show("Invalid Email / Password", "Login Failed!", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Else
                    Try
                        cmd.CommandText = "SELECT id FROM login WHERE email = @user"

                        cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = Username.Text

                        Dim myreader As MySqlDataReader = cmd.ExecuteReader
                        If (myreader.Read()) Then
                            UserID = myreader("id")
                        Else
                            MessageBox.Show("No Data Found")
                        End If

                    Catch ex As Exception
                        MessageBox.Show("Error" & ex.Message.ToString)
                    Finally
                        cmd.Parameters.Clear()

                    End Try

                    Dim Form1 As New Home
                    Home.Show()
                    Me.Hide()

                    Username.BorderColor = System.Drawing.Color.DodgerBlue
                    Password.BorderColor = System.Drawing.Color.DodgerBlue

                    Username.Clear()
                    Password.Clear()


                End If
            Catch ex As Exception
                MessageBox.Show("Error" & ex.Message.ToString)
            Finally
                cmd.Parameters.Clear()
                strcon.Close()
            End Try

        End If
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Me.Hide()
        CPass.ShowDialog()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Me.Hide()
        Register.ShowDialog()
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Hide()
        MainHome.ShowDialog()
    End Sub

    Private Sub passCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles passCheckbox.CheckedChanged
        If passCheckbox.Checked = True Then
            Password.PasswordChar = ""
        Else
            Password.PasswordChar = "*"
        End If
    End Sub
End Class
