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
        SuspendLayout()
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Location = New Point(119, 191)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(100, 25)
        lblUsername.TabIndex = 1
        lblUsername.Text = "Username: "
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Location = New Point(119, 258)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(96, 25)
        lblPassword.TabIndex = 2
        lblPassword.Text = "Password: "
        ' 
        ' BtnNewAcc
        ' 
        BtnNewAcc.Location = New Point(119, 397)
        BtnNewAcc.Name = "BtnNewAcc"
        BtnNewAcc.Size = New Size(223, 34)
        BtnNewAcc.TabIndex = 4
        BtnNewAcc.Text = "Create New Account"
        BtnNewAcc.UseVisualStyleBackColor = True
        ' 
        ' BtnForgotPass
        ' 
        BtnForgotPass.Location = New Point(348, 397)
        BtnForgotPass.Name = "BtnForgotPass"
        BtnForgotPass.Size = New Size(223, 34)
        BtnForgotPass.TabIndex = 5
        BtnForgotPass.Text = "Forgot Password"
        BtnForgotPass.UseVisualStyleBackColor = True
        ' 
        ' BtnLogin
        ' 
        BtnLogin.Location = New Point(459, 317)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(112, 34)
        BtnLogin.TabIndex = 0
        BtnLogin.Text = "Login"
        BtnLogin.UseVisualStyleBackColor = True
        ' 
        ' BtnClear
        ' 
        BtnClear.Location = New Point(341, 317)
        BtnClear.Name = "BtnClear"
        BtnClear.Size = New Size(112, 34)
        BtnClear.TabIndex = 3
        BtnClear.Text = "Clear"
        BtnClear.UseVisualStyleBackColor = True
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(225, 188)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(346, 31)
        txtUsername.TabIndex = 6
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(225, 258)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(346, 31)
        txtPassword.TabIndex = 7
        ' 
        ' FrmLogin
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(778, 544)
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

End Class
