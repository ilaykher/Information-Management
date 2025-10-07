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
        lblForgotUsername.Font = New Font("Consolas", 14.25F)
        lblForgotUsername.Location = New Point(124, 161)
        lblForgotUsername.Margin = New Padding(2, 0, 2, 0)
        lblForgotUsername.Name = "lblForgotUsername"
        lblForgotUsername.Size = New Size(110, 22)
        lblForgotUsername.TabIndex = 0
        lblForgotUsername.Text = "Username: "
        ' 
        ' TxtForgotUsername
        ' 
        TxtForgotUsername.Font = New Font("Consolas", 14.25F)
        TxtForgotUsername.Location = New Point(238, 158)
        TxtForgotUsername.Margin = New Padding(2)
        TxtForgotUsername.Name = "TxtForgotUsername"
        TxtForgotUsername.PlaceholderText = "(e.g. user)"
        TxtForgotUsername.Size = New Size(261, 30)
        TxtForgotUsername.TabIndex = 1
        ' 
        ' BtnFindUsernameDB
        ' 
        BtnFindUsernameDB.Font = New Font("Consolas", 14.25F)
        BtnFindUsernameDB.Location = New Point(510, 157)
        BtnFindUsernameDB.Margin = New Padding(2)
        BtnFindUsernameDB.Name = "BtnFindUsernameDB"
        BtnFindUsernameDB.Size = New Size(105, 30)
        BtnFindUsernameDB.TabIndex = 2
        BtnFindUsernameDB.Text = "Find Account"
        BtnFindUsernameDB.UseVisualStyleBackColor = True
        ' 
        ' lblSec
        ' 
        lblSec.AccessibleRole = AccessibleRole.None
        lblSec.AutoSize = True
        lblSec.Font = New Font("Consolas", 14.25F)
        lblSec.ForeColor = Color.DarkRed
        lblSec.Location = New Point(34, 207)
        lblSec.Margin = New Padding(2, 0, 2, 0)
        lblSec.Name = "lblSec"
        lblSec.Size = New Size(190, 22)
        lblSec.TabIndex = 3
        lblSec.Text = "Security Question:"
        lblSec.Visible = False
        ' 
        ' lblAccountFound
        ' 
        lblAccountFound.AutoSize = True
        lblAccountFound.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAccountFound.Location = New Point(132, 117)
        lblAccountFound.Margin = New Padding(2, 0, 2, 0)
        lblAccountFound.Name = "lblAccountFound"
        lblAccountFound.Size = New Size(16, 18)
        lblAccountFound.TabIndex = 4
        lblAccountFound.Text = "-"
        ' 
        ' TxtSecurityAns
        ' 
        TxtSecurityAns.Font = New Font("Consolas", 14.25F)
        TxtSecurityAns.Location = New Point(238, 255)
        TxtSecurityAns.Margin = New Padding(2)
        TxtSecurityAns.Name = "TxtSecurityAns"
        TxtSecurityAns.PlaceholderText = "(Input your answer here)"
        TxtSecurityAns.Size = New Size(259, 30)
        TxtSecurityAns.TabIndex = 5
        TxtSecurityAns.Visible = False
        ' 
        ' lblSecurityQuestion
        ' 
        lblSecurityQuestion.AccessibleRole = AccessibleRole.None
        lblSecurityQuestion.AutoSize = True
        lblSecurityQuestion.Font = New Font("Consolas", 14.25F)
        lblSecurityQuestion.ForeColor = Color.DarkRed
        lblSecurityQuestion.Location = New Point(238, 207)
        lblSecurityQuestion.Margin = New Padding(2, 0, 2, 0)
        lblSecurityQuestion.Name = "lblSecurityQuestion"
        lblSecurityQuestion.Size = New Size(280, 22)
        lblSecurityQuestion.TabIndex = 6
        lblSecurityQuestion.Text = "Shows the Security Question"
        lblSecurityQuestion.Visible = False
        ' 
        ' lblNewPass
        ' 
        lblNewPass.AutoSize = True
        lblNewPass.Font = New Font("Consolas", 14.25F)
        lblNewPass.Location = New Point(87, 304)
        lblNewPass.Margin = New Padding(2, 0, 2, 0)
        lblNewPass.Name = "lblNewPass"
        lblNewPass.Size = New Size(140, 22)
        lblNewPass.TabIndex = 7
        lblNewPass.Text = "New Password:"
        lblNewPass.Visible = False
        ' 
        ' TxtNewPass
        ' 
        TxtNewPass.Font = New Font("Consolas", 14.25F)
        TxtNewPass.Location = New Point(236, 301)
        TxtNewPass.Margin = New Padding(2)
        TxtNewPass.Name = "TxtNewPass"
        TxtNewPass.PlaceholderText = "(Type in your new password)"
        TxtNewPass.Size = New Size(261, 30)
        TxtNewPass.TabIndex = 8
        TxtNewPass.UseSystemPasswordChar = True
        TxtNewPass.Visible = False
        ' 
        ' BtnConfirmation
        ' 
        BtnConfirmation.Font = New Font("Consolas", 14.25F)
        BtnConfirmation.Location = New Point(510, 254)
        BtnConfirmation.Margin = New Padding(2)
        BtnConfirmation.Name = "BtnConfirmation"
        BtnConfirmation.Size = New Size(105, 31)
        BtnConfirmation.TabIndex = 9
        BtnConfirmation.Text = "Confirm"
        BtnConfirmation.UseVisualStyleBackColor = True
        BtnConfirmation.Visible = False
        ' 
        ' BtnUpdatePass
        ' 
        BtnUpdatePass.Font = New Font("Consolas", 14.25F)
        BtnUpdatePass.Location = New Point(510, 301)
        BtnUpdatePass.Margin = New Padding(2)
        BtnUpdatePass.Name = "BtnUpdatePass"
        BtnUpdatePass.Size = New Size(105, 31)
        BtnUpdatePass.TabIndex = 10
        BtnUpdatePass.Text = "Update Password"
        BtnUpdatePass.UseVisualStyleBackColor = True
        BtnUpdatePass.Visible = False
        ' 
        ' BtnBack
        ' 
        BtnBack.Font = New Font("Consolas", 14.25F)
        BtnBack.Location = New Point(544, 20)
        BtnBack.Margin = New Padding(2)
        BtnBack.Name = "BtnBack"
        BtnBack.Size = New Size(157, 30)
        BtnBack.TabIndex = 11
        BtnBack.Text = "Back to Login"
        BtnBack.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(20, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(270, 44)
        Label1.TabIndex = 12
        Label1.Text = "Fill-up the corresponding " & vbCrLf & "information"
        ' 
        ' lblAnswerSec
        ' 
        lblAnswerSec.AutoSize = True
        lblAnswerSec.Font = New Font("Consolas", 14.25F)
        lblAnswerSec.Location = New Point(147, 258)
        lblAnswerSec.Margin = New Padding(2, 0, 2, 0)
        lblAnswerSec.Name = "lblAnswerSec"
        lblAnswerSec.Size = New Size(80, 22)
        lblAnswerSec.TabIndex = 13
        lblAnswerSec.Text = "Answer:"
        lblAnswerSec.Visible = False
        ' 
        ' FrmForgotPass
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(725, 378)
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
