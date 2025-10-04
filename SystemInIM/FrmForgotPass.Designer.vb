<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmForgotPass
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblForgotUsername = New Label()
        TxtForgotUsername = New TextBox()
        BtnFindUsernameDB = New Button()
        lblSec = New Label()
        lblAccountFound = New Label()
        TxtSecurityAns = New TextBox()
        lblSecurityQuestion = New Label()
        lblNewPass = New Label()
        TxtNewPass = New TextBox()
        BtnConfirmation = New Button()
        BtnUpdatePass = New Button()
        BtnBack = New Button()
        Label1 = New Label()
        lblAnswerSec = New Label()
        SuspendLayout()
        ' 
        ' lblForgotUsername
        ' 
        lblForgotUsername.AutoSize = True
        lblForgotUsername.Font = New Font("Segoe UI", 12F)
        lblForgotUsername.Location = New Point(85, 209)
        lblForgotUsername.Margin = New Padding(2, 0, 2, 0)
        lblForgotUsername.Name = "lblForgotUsername"
        lblForgotUsername.Size = New Size(108, 28)
        lblForgotUsername.TabIndex = 0
        lblForgotUsername.Text = "Username: "
        ' 
        ' TxtForgotUsername
        ' 
        TxtForgotUsername.Font = New Font("Segoe UI", 10F)
        TxtForgotUsername.Location = New Point(197, 213)
        TxtForgotUsername.Margin = New Padding(2)
        TxtForgotUsername.Name = "TxtForgotUsername"
        TxtForgotUsername.PlaceholderText = "(e.g. user)"
        TxtForgotUsername.Size = New Size(298, 30)
        TxtForgotUsername.TabIndex = 1
        ' 
        ' BtnFindUsernameDB
        ' 
        BtnFindUsernameDB.Font = New Font("Segoe UI", 12F)
        BtnFindUsernameDB.Location = New Point(511, 213)
        BtnFindUsernameDB.Margin = New Padding(2)
        BtnFindUsernameDB.Name = "BtnFindUsernameDB"
        BtnFindUsernameDB.Size = New Size(120, 40)
        BtnFindUsernameDB.TabIndex = 2
        BtnFindUsernameDB.Text = "Find Account"
        BtnFindUsernameDB.UseVisualStyleBackColor = True
        ' 
        ' lblSec
        ' 
        lblSec.AutoSize = True
        lblSec.Font = New Font("Segoe UI", 12F)
        lblSec.Location = New Point(23, 255)
        lblSec.Margin = New Padding(2, 0, 2, 0)
        lblSec.Name = "lblSec"
        lblSec.Size = New Size(170, 28)
        lblSec.TabIndex = 3
        lblSec.Text = "Security Question:"
        lblSec.Visible = False
        ' 
        ' lblAccountFound
        ' 
        lblAccountFound.AutoSize = True
        lblAccountFound.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        lblAccountFound.Location = New Point(85, 150)
        lblAccountFound.Margin = New Padding(2, 0, 2, 0)
        lblAccountFound.Name = "lblAccountFound"
        lblAccountFound.Size = New Size(327, 41)
        lblAccountFound.TabIndex = 4
        lblAccountFound.Text = "Account: UserAccount"
        lblAccountFound.Visible = False
        ' 
        ' TxtSecurityAns
        ' 
        TxtSecurityAns.Font = New Font("Segoe UI", 10F)
        TxtSecurityAns.Location = New Point(200, 309)
        TxtSecurityAns.Margin = New Padding(2)
        TxtSecurityAns.Name = "TxtSecurityAns"
        TxtSecurityAns.PlaceholderText = "(Input your answer here)"
        TxtSecurityAns.Size = New Size(295, 30)
        TxtSecurityAns.TabIndex = 5
        TxtSecurityAns.Visible = False
        ' 
        ' lblSecurityQuestion
        ' 
        lblSecurityQuestion.AutoSize = True
        lblSecurityQuestion.Font = New Font("Segoe UI", 12F)
        lblSecurityQuestion.Location = New Point(197, 255)
        lblSecurityQuestion.Margin = New Padding(2, 0, 2, 0)
        lblSecurityQuestion.Name = "lblSecurityQuestion"
        lblSecurityQuestion.Size = New Size(260, 28)
        lblSecurityQuestion.TabIndex = 6
        lblSecurityQuestion.Text = "Shows the Security Question"
        lblSecurityQuestion.Visible = False
        ' 
        ' lblNewPass
        ' 
        lblNewPass.AutoSize = True
        lblNewPass.Font = New Font("Segoe UI", 12F)
        lblNewPass.Location = New Point(52, 366)
        lblNewPass.Margin = New Padding(2, 0, 2, 0)
        lblNewPass.Name = "lblNewPass"
        lblNewPass.Size = New Size(141, 28)
        lblNewPass.TabIndex = 7
        lblNewPass.Text = "New Password:"
        lblNewPass.Visible = False
        ' 
        ' TxtNewPass
        ' 
        TxtNewPass.Font = New Font("Segoe UI", 10F)
        TxtNewPass.Location = New Point(197, 360)
        TxtNewPass.Margin = New Padding(2)
        TxtNewPass.Name = "TxtNewPass"
        TxtNewPass.PlaceholderText = "(Type in your new password)"
        TxtNewPass.Size = New Size(298, 30)
        TxtNewPass.TabIndex = 8
        TxtNewPass.UseSystemPasswordChar = True
        TxtNewPass.Visible = False
        ' 
        ' BtnConfirmation
        ' 
        BtnConfirmation.Font = New Font("Segoe UI", 12F)
        BtnConfirmation.Location = New Point(511, 298)
        BtnConfirmation.Margin = New Padding(2)
        BtnConfirmation.Name = "BtnConfirmation"
        BtnConfirmation.Size = New Size(120, 40)
        BtnConfirmation.TabIndex = 9
        BtnConfirmation.Text = "Confirm"
        BtnConfirmation.UseVisualStyleBackColor = True
        BtnConfirmation.Visible = False
        ' 
        ' BtnUpdatePass
        ' 
        BtnUpdatePass.Font = New Font("Segoe UI", 12F)
        BtnUpdatePass.Location = New Point(511, 360)
        BtnUpdatePass.Margin = New Padding(2)
        BtnUpdatePass.Name = "BtnUpdatePass"
        BtnUpdatePass.Size = New Size(120, 40)
        BtnUpdatePass.TabIndex = 10
        BtnUpdatePass.Text = "Update Password"
        BtnUpdatePass.UseVisualStyleBackColor = True
        BtnUpdatePass.Visible = False
        ' 
        ' BtnBack
        ' 
        BtnBack.Font = New Font("Segoe UI", 12F)
        BtnBack.Location = New Point(625, 21)
        BtnBack.Margin = New Padding(2)
        BtnBack.Name = "BtnBack"
        BtnBack.Size = New Size(146, 40)
        BtnBack.TabIndex = 11
        BtnBack.Text = "Back to Login"
        BtnBack.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        Label1.Location = New Point(23, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(385, 82)
        Label1.TabIndex = 12
        Label1.Text = "Fill-up the corresponding " & vbCrLf & "information"
        ' 
        ' lblAnswerSec
        ' 
        lblAnswerSec.AutoSize = True
        lblAnswerSec.Font = New Font("Segoe UI", 12F)
        lblAnswerSec.Location = New Point(114, 310)
        lblAnswerSec.Margin = New Padding(2, 0, 2, 0)
        lblAnswerSec.Name = "lblAnswerSec"
        lblAnswerSec.Size = New Size(79, 28)
        lblAnswerSec.TabIndex = 13
        lblAnswerSec.Text = "Answer:"
        lblAnswerSec.Visible = False
        ' 
        ' FrmForgotPass
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(782, 553)
        Controls.Add(lblAnswerSec)
        Controls.Add(Label1)
        Controls.Add(BtnBack)
        Controls.Add(BtnUpdatePass)
        Controls.Add(BtnConfirmation)
        Controls.Add(TxtNewPass)
        Controls.Add(lblNewPass)
        Controls.Add(lblSecurityQuestion)
        Controls.Add(TxtSecurityAns)
        Controls.Add(lblAccountFound)
        Controls.Add(lblSec)
        Controls.Add(BtnFindUsernameDB)
        Controls.Add(TxtForgotUsername)
        Controls.Add(lblForgotUsername)
        Margin = New Padding(2)
        Name = "FrmForgotPass"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Device Market System"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblForgotUsername As Label
    Friend WithEvents TxtForgotUsername As TextBox
    Friend WithEvents BtnFindUsernameDB As Button
    Friend WithEvents lblSec As Label
    Friend WithEvents lblAccountFound As Label
    Friend WithEvents TxtSecurityAns As TextBox
    Friend WithEvents lblSecurityQuestion As Label
    Friend WithEvents lblNewPass As Label
    Friend WithEvents TxtNewPass As TextBox
    Friend WithEvents BtnConfirmation As Button
    Friend WithEvents BtnUpdatePass As Button
    Friend WithEvents BtnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblAnswerSec As Label
End Class
