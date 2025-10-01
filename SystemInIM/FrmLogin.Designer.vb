<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblUsername = New Label()
        lblPassword = New Label()
        BtnNewAcc = New Button()
        BtnForgotPass = New Button()
        BtnLogin = New Button()
        BtnClear = New Button()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI", 12F)
        lblUsername.Location = New Point(90, 135)
        lblUsername.Margin = New Padding(2, 0, 2, 0)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(108, 28)
        lblUsername.TabIndex = 1
        lblUsername.Text = "Username: "
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 12F)
        lblPassword.Location = New Point(96, 188)
        lblPassword.Margin = New Padding(2, 0, 2, 0)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(102, 28)
        lblPassword.TabIndex = 2
        lblPassword.Text = "Password: "
        ' 
        ' BtnNewAcc
        ' 
        BtnNewAcc.Font = New Font("Segoe UI", 12F)
        BtnNewAcc.Location = New Point(173, 318)
        BtnNewAcc.Margin = New Padding(2)
        BtnNewAcc.Name = "BtnNewAcc"
        BtnNewAcc.Size = New Size(178, 38)
        BtnNewAcc.TabIndex = 4
        BtnNewAcc.Text = "Create New Account"
        BtnNewAcc.UseVisualStyleBackColor = True
        ' 
        ' BtnForgotPass
        ' 
        BtnForgotPass.Font = New Font("Segoe UI", 12F)
        BtnForgotPass.Location = New Point(355, 318)
        BtnForgotPass.Margin = New Padding(2)
        BtnForgotPass.Name = "BtnForgotPass"
        BtnForgotPass.Size = New Size(178, 38)
        BtnForgotPass.TabIndex = 5
        BtnForgotPass.Text = "Forgot Password"
        BtnForgotPass.UseVisualStyleBackColor = True
        ' 
        ' BtnLogin
        ' 
        BtnLogin.Font = New Font("Segoe UI", 12F)
        BtnLogin.Location = New Point(443, 239)
        BtnLogin.Margin = New Padding(2)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(90, 38)
        BtnLogin.TabIndex = 0
        BtnLogin.Text = "Login"
        BtnLogin.UseVisualStyleBackColor = True
        ' 
        ' BtnClear
        ' 
        BtnClear.Font = New Font("Segoe UI", 12F)
        BtnClear.Location = New Point(349, 239)
        BtnClear.Margin = New Padding(2)
        BtnClear.Name = "BtnClear"
        BtnClear.Size = New Size(90, 38)
        BtnClear.TabIndex = 3
        BtnClear.Text = "Clear"
        BtnClear.UseVisualStyleBackColor = True
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI", 10F)
        txtUsername.Location = New Point(205, 132)
        txtUsername.Margin = New Padding(2)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "(Type in your username)"
        txtUsername.Size = New Size(328, 30)
        txtUsername.TabIndex = 6
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 10F)
        txtPassword.Location = New Point(205, 188)
        txtPassword.Margin = New Padding(2)
        txtPassword.Name = "txtPassword"
        txtPassword.PlaceholderText = "(Type in your password)"
        txtPassword.Size = New Size(328, 30)
        txtPassword.TabIndex = 7
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(136, 55)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(329, 41)
        Label1.TabIndex = 8
        Label1.Text = "Device Market System"
        ' 
        ' FrmLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(622, 435)
        Controls.Add(Label1)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(BtnForgotPass)
        Controls.Add(BtnNewAcc)
        Controls.Add(BtnClear)
        Controls.Add(lblPassword)
        Controls.Add(lblUsername)
        Controls.Add(BtnLogin)
        Margin = New Padding(2)
        Name = "FrmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Shopipi System"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnNewAcc As Button
    Friend WithEvents BtnForgotPass As Button
    Friend WithEvents BtnLogin As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label

End Class
