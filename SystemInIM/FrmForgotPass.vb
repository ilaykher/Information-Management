Public Class FrmForgotPass
    Private Sub BtnFindUsernameDB_Click(sender As Object, e As EventArgs) Handles BtnFindUsernameDB.Click
        If TxtForgotUsername.Text = "admin" Then
            lblAccountFound.Visible = True
            lblSecurityQuestion.Visible = True
            lblSec.Visible = True


            TxtSecurityAns.Visible = True
            BtnConfirmation.Visible = True
        End If

    End Sub

    Private Sub BtnConfirmation_Click(sender As Object, e As EventArgs) Handles BtnConfirmation.Click
        If TxtSecurityAns.Text = "Habibi" Then
            lblNewPass.Visible = True
            TxtNewPass.Visible = True
            BtnUpdatePass.Visible = True
        End If
    End Sub
    Private Sub BtnUpdatePass_Click(sender As Object, e As EventArgs) Handles BtnUpdatePass.Click

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Dim BackToLogin As New FrmLogin()
        BackToLogin.Show()
        Me.Hide()
    End Sub

End Class