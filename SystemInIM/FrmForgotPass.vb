Imports MySql.Data.MySqlClient

Public Class FrmForgotPass

    'DB
    Private connStr As String = "Server=localhost;Database=information_management;Uid=root;Pwd=;"

    ' Store the username being recovered
    Private currentUsername As String = ""

    ' Find Username
    Private Sub BtnFindUsernameDB_Click(sender As Object, e As EventArgs) Handles BtnFindUsernameDB.Click
        Dim inputUsername As String = TxtForgotUsername.Text.Trim()

        If String.IsNullOrWhiteSpace(inputUsername) Then
            MessageBox.Show("Enter a username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtForgotUsername.Focus()
            Return
        End If

        If inputUsername.Length < 3 Then
            MessageBox.Show("Username should be at least 3 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtForgotUsername.Focus()
            Return
        End If

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
                    lblAnswerSec.Visible = True
                Else
                    MessageBox.Show("No account found. Double-check the username or create a new account.")
                End If

                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub


    'Confirm Security Answer
    Private Sub BtnConfirmation_Click(sender As Object, e As EventArgs) Handles BtnConfirmation.Click
        Dim inputAnswer As String = TxtSecurityAns.Text.Trim()

        If String.IsNullOrWhiteSpace(inputAnswer) Then
            MessageBox.Show("Enter your security answer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtSecurityAns.Focus()
            Return
        End If

        If currentUsername = "" Then
            MessageBox.Show("Find your account first.", "Process Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtForgotUsername.Focus()
            Return
        End If

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
                    TxtSecurityAns.Focus()
                End If

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Step 3: Update Password
    Private Sub BtnUpdatePass_Click(sender As Object, e As EventArgs) Handles BtnUpdatePass.Click
        Dim newPassword As String = TxtNewPass.Text ' Do NOT trim for security reasons

        If String.IsNullOrEmpty(newPassword) Then
            MessageBox.Show("Enter a new password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtNewPass.Focus()
            Return
        End If

        If newPassword.Length < 6 Then
            MessageBox.Show("New password should be at least 6 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtNewPass.Focus()
            Return
        End If

        Dim oldPassword As String = ""
        Using connCheck As New MySqlConnection(connStr)
            Try
                connCheck.Open()
                ' Query to fetch the current/old password
                Dim checkQuery As String = "SELECT password FROM users WHERE username = @username"
                Using checkCmd As New MySqlCommand(checkQuery, connCheck)
                    checkCmd.Parameters.AddWithValue("@username", currentUsername)
                    oldPassword = checkCmd.ExecuteScalar()?.ToString()
                End Using
            Catch ex As Exception
                ' Handle error but allow the process to continue by showing an error message
                ' Returning True here would stop the update, which is a safer default.
                MessageBox.Show("Error checking existing password: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End Try
        End Using

        If newPassword = oldPassword Then
            MessageBox.Show("The new password cannot be the same as your old password. Please choose a different one.", "Security Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            TxtNewPass.Clear()
            TxtNewPass.Focus()
            Return
        End If



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

    Private Sub FrmForgotPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
