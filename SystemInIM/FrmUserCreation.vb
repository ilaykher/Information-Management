Imports Mysql.Data.MySqlClient





Public Class FrmUserCreation


    Private Sub FrmUserCreation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        txtCreateUsername.Clear()
        txtCreatePass.Clear()
        txtSecurityAnswer.Clear()

        txtCreateUsername.Focus()
    End Sub

    Private Sub BtnBackToLogin_Click(sender As Object, e As EventArgs) Handles BtnBackToLogin.Click
        Dim BackToLogin As New FrmLogin()
        BackToLogin.Show()
        Me.Hide()
    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        Dim connStr As String = "Server=localhost;Database=information_management;Uid=root;Pwd=;"

        Using conn As New MySqlConnection(connStr)
            Try
                conn.Open()

                ' Insert new user
                Dim insertQuery As String = "INSERT INTO users (username, password, security_question, security_answer) " &
                                            "VALUES (@username, @password, @question, @answer)"

                Dim insertCmd As New MySqlCommand(insertQuery, conn)
                insertCmd.Parameters.AddWithValue("@username", txtCreateUsername.Text)
                insertCmd.Parameters.AddWithValue("@password", txtCreatePass.Text)
                insertCmd.Parameters.AddWithValue("@question", cmbSecurityQuestion.SelectedItem.ToString())
                insertCmd.Parameters.AddWithValue("@answer", txtSecurityAnswer.Text)

                ' Execute insert
                insertCmd.ExecuteNonQuery()

                MessageBox.Show("Account created successfully!")

                ' Clear form
                txtCreateUsername.Clear()
                txtCreatePass.Clear()
                txtSecurityAnswer.Clear()
                cmbSecurityQuestion.SelectedIndex = -1

                ' Close and go back to login
                Me.Close()

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                conn.Close()
            End Try

        End Using
    End Sub

    Private Sub txtSecurityAnswer_TextChanged(sender As Object, e As EventArgs) Handles txtSecurityAnswer.TextChanged

    End Sub
End Class


