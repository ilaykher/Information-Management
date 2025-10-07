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
        BtnLogin = New Button()
        BtnClear = New Button()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        Label1 = New Label()
        LinkLabel1 = New LinkLabel()
        LinkLabel2 = New LinkLabel()
        SuspendLayout()
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI", 12F)
        lblUsername.Location = New Point(22, 125)
        lblUsername.Margin = New Padding(2, 0, 2, 0)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(88, 21)
        lblUsername.TabIndex = 1
        lblUsername.Text = "Username: "
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 12F)
        lblPassword.Location = New Point(27, 184)
        lblPassword.Margin = New Padding(2, 0, 2, 0)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(83, 21)
        lblPassword.TabIndex = 2
        lblPassword.Text = "Password: "
        ' 
        ' BtnLogin
        ' 
        BtnLogin.Font = New Font("Segoe UI", 12F)
        BtnLogin.Location = New Point(249, 444)
        BtnLogin.Margin = New Padding(2)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(161, 29)
        BtnLogin.TabIndex = 0
        BtnLogin.Text = "Login"
        BtnLogin.UseVisualStyleBackColor = True
        ' 
        ' BtnClear
        ' 
        BtnClear.Font = New Font("Segoe UI", 12F)
        BtnClear.Location = New Point(60, 444)
        BtnClear.Margin = New Padding(2)
        BtnClear.Name = "BtnClear"
        BtnClear.Size = New Size(161, 29)
        BtnClear.TabIndex = 3
        BtnClear.Text = "Clear"
        BtnClear.UseVisualStyleBackColor = True
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI", 10F)
        txtUsername.Location = New Point(121, 123)
        txtUsername.Margin = New Padding(2)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "(Type in your username)"
        txtUsername.Size = New Size(288, 25)
        txtUsername.TabIndex = 6
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 10F)
        txtPassword.Location = New Point(121, 184)
        txtPassword.Margin = New Padding(2)
        txtPassword.Name = "txtPassword"
        txtPassword.PlaceholderText = "(Type in your password)"
        txtPassword.Size = New Size(288, 25)
        txtPassword.TabIndex = 7
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(108, 43)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(265, 32)
        Label1.TabIndex = 8
        Label1.Text = "Device Market System"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel1.Location = New Point(161, 292)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(151, 21)
        LinkLabel1.TabIndex = 9
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Create New Account"
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.AutoSize = True
        LinkLabel2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel2.Location = New Point(172, 333)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(126, 21)
        LinkLabel2.TabIndex = 10
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "Forgot Password"
        ' 
        ' FrmLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(470, 547)
        Controls.Add(LinkLabel2)
        Controls.Add(LinkLabel1)
        Controls.Add(Label1)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(BtnClear)
        Controls.Add(lblPassword)
        Controls.Add(lblUsername)
        Controls.Add(BtnLogin)
        Margin = New Padding(2)
        Name = "FrmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Log In"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnLogin As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel

End Class
