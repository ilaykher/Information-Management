Public Class FrmLogin
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnNewAcc_Click(sender As Object, e As EventArgs) Handles BtnNewAcc.Click
        Dim GoToCreateAcc As New FrmUserCreation()
        GoToCreateAcc.Show()
        Me.Hide()
    End Sub
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        'Input login succesfully notif
        'Add database connection here later
        'Add validation for username and password here later

        Dim productTable As New FrmInterface()
        productTable.Show()
        Me.Hide()
    End Sub
    Private Sub BtnForgotPass_Click(sender As Object, e As EventArgs) Handles BtnForgotPass.Click
        Dim ForgotPass As New FrmForgotPass()
        ForgotPass.Show()
        Me.Hide()
    End Sub
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        txtUsername.Clear()
        txtPassword.Clear()
        txtUsername.Focus()
    End Sub
End Class
