Imports MySql.Data.MySqlClient

Public Class FrmForgotPass

    ' Database connection string
    Private connStr As String = "Server=localhost;Database=information_management;Uid=root;Pwd=;"

    ' Store the username being recovered
    Private currentUsername As String = ""

    ' Step 1: Find Username
    Private Sub BtnFindUsernameDB_Click(sender As Object, e As EventArgs) Handles BtnFindUsernameDB.Click
        Using conn As New MySqlConnection(connStr)
            Try
                conn.Open()

                Dim query As String = "SELECT security_question FROM users WHERE username = @username"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", TxtForgotUsername.Text)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    ' Username found
                    currentUsername = TxtForgotUsername.Text
                    lblAccountFound.Text = "Account found: " & currentUsername
                    lblAccountFound.Visible = True

                    lblSecurityQuestion.Text = reader("security_question").ToString()
                    lblSecurityQuestion.Visible = True
                    lblSec.Visible = True
                    TxtSecurityAns.Visible = True
                    BtnConfirmation.Visible = True
                Else
                    MessageBox.Show("No account found. Double-check the username or create a new account.")
                End If

                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Step 2: Confirm Security Answer
    Private Sub BtnConfirmation_Click(sender As Object, e As EventArgs) Handles BtnConfirmation.Click
        Using conn As New MySqlConnection(connStr)
            Try
                conn.Open()

                Dim query As String = "SELECT security_answer FROM users WHERE username = @username"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", currentUsername)

                Dim dbAnswer As String = cmd.ExecuteScalar()?.ToString()

                If dbAnswer IsNot Nothing AndAlso TxtSecurityAns.Text.Trim().ToLower() = dbAnswer.Trim().ToLower() Then
                    MessageBox.Show("Answer correct. Please set a new password.")

                    lblNewPass.Visible = True
                    TxtNewPass.Visible = True
                    BtnUpdatePass.Visible = True
                Else
                    MessageBox.Show("Incorrect security answer. Try again.")
                    TxtSecurityAns.Clear()
                End If

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Step 3: Update Password
    Private Sub BtnUpdatePass_Click(sender As Object, e As EventArgs) Handles BtnUpdatePass.Click
        Using conn As New MySqlConnection(connStr)
            Try
                conn.Open()

                Dim query As String = "UPDATE users SET password = @newpass WHERE username = @username"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@newpass", TxtNewPass.Text)
                cmd.Parameters.AddWithValue("@username", currentUsername)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Password updated successfully!")

                    Dim BackToLogin As New FrmLogin()
                    BackToLogin.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Error: Password not updated.")
                End If

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Back button
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Dim BackToLogin As New FrmLogin()
        BackToLogin.Show()
        Me.Hide()
    End Sub

    Private Sub lblSecurityQuestion_Click(sender As Object, e As EventArgs) Handles lblSecurityQuestion.Click

    End Sub

    Private Sub lblForgotUsername_Click(sender As Object, e As EventArgs) Handles lblForgotUsername.Click

    End Sub
End Class
