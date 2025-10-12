Imports MySql.Data.MySqlClient
' Add this line at the top of your FrmLogin file

Public Class FrmLogin

    ' Connection string should be declared once at the class level or form level
    Private connString As String = "server=localhost; user id=root; password=; database=information_management"


    ' LOGIN LOGIC


    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        ' 1. BASIC VALIDATION
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text ' Do NOT trim password as spaces might be intentional

        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If username.Length < 3 Then
            MessageBox.Show("Username must be at least 3 characters", "Validation Error")
            Return
        End If


        'For when an admin is loggin in

        If username.Equals("admin", StringComparison.OrdinalIgnoreCase) Then
        ElseIf password.Length < 6 Then

            MessageBox.Show("Password must be at least 6 characters", "Validation Error")
            Return
        End If
        '=====================



        Dim conn As New MySqlConnection(connString)

        Dim query As String = "SELECT user_id, username FROM users WHERE username = @user AND password = @pass"

        Try
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@user", username)
                cmd.Parameters.AddWithValue("@pass", password)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    ' *** GET user_id and username ***
                    Dim userId As Integer = Convert.ToInt32(reader("user_id"))
                    Dim loggedUsername As String = reader("username").ToString()
                    Dim isAdmin As Boolean = (loggedUsername.ToLower() = "admin")

                    reader.Close()

                    ' Login successful!
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Hide()

                    If isAdmin Then
                        ' Show Admin Interface
                        Dim adminForm As New FrmInterface()
                        adminForm.Show()
                    Else
                        ' Show User Interface - *** PASS THE DATA! ***
                        Dim userform As New UserInetrfaceNew()
                        userform.Show()
                    End If
                Else
                    ' Login failed
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtPassword.Clear()
                    txtPassword.Focus()
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Database connection error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub


    '  OTHER BUTTONS

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtUsername.Focus()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        If String.IsNullOrWhiteSpace(txtUsername.Text) And String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Fields are already empty.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return ' Exit without clearing since already empty
        End If

        ' Clear the fields
        txtUsername.Clear()
        txtPassword.Clear()
        txtUsername.Focus()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim GoToCreateAcc As New FrmUserCreation()
        GoToCreateAcc.Show()
        Hide()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim ForgotPass As New FrmForgotPass()
        ForgotPass.Show()
        Me.Hide()
    End Sub
End Class