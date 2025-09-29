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
        SuspendLayout()
        ' 
        ' lblForgotUsername
        ' 
        lblForgotUsername.AutoSize = True
        lblForgotUsername.Location = New Point(126, 84)
        lblForgotUsername.Name = "lblForgotUsername"
        lblForgotUsername.Size = New Size(100, 25)
        lblForgotUsername.TabIndex = 0
        lblForgotUsername.Text = "Username: "
        ' 
        ' TxtForgotUsername
        ' 
        TxtForgotUsername.Location = New Point(232, 81)
        TxtForgotUsername.Name = "TxtForgotUsername"
        TxtForgotUsername.Size = New Size(276, 31)
        TxtForgotUsername.TabIndex = 1
        ' 
        ' BtnFindUsernameDB
        ' 
        BtnFindUsernameDB.Location = New Point(514, 78)
        BtnFindUsernameDB.Name = "BtnFindUsernameDB"
        BtnFindUsernameDB.Size = New Size(182, 34)
        BtnFindUsernameDB.TabIndex = 2
        BtnFindUsernameDB.Text = "Find Account"
        BtnFindUsernameDB.UseVisualStyleBackColor = True
        ' 
        ' lblSec
        ' 
        lblSec.AutoSize = True
        lblSec.Location = New Point(71, 186)
        lblSec.Name = "lblSec"
        lblSec.Size = New Size(155, 25)
        lblSec.TabIndex = 3
        lblSec.Text = "Security Question:"
        lblSec.Visible = False
        ' 
        ' lblAccountFound
        ' 
        lblAccountFound.AutoSize = True
        lblAccountFound.Location = New Point(315, 38)
        lblAccountFound.Name = "lblAccountFound"
        lblAccountFound.Size = New Size(186, 25)
        lblAccountFound.TabIndex = 4
        lblAccountFound.Text = "Account: UserAccount"
        lblAccountFound.Visible = False
        ' 
        ' TxtSecurityAns
        ' 
        TxtSecurityAns.Location = New Point(232, 237)
        TxtSecurityAns.Name = "TxtSecurityAns"
        TxtSecurityAns.Size = New Size(276, 31)
        TxtSecurityAns.TabIndex = 5
        TxtSecurityAns.Visible = False
        ' 
        ' lblSecurityQuestion
        ' 
        lblSecurityQuestion.AutoSize = True
        lblSecurityQuestion.Location = New Point(340, 186)
        lblSecurityQuestion.Name = "lblSecurityQuestion"
        lblSecurityQuestion.Size = New Size(63, 25)
        lblSecurityQuestion.TabIndex = 6
        lblSecurityQuestion.Text = "Label1"
        lblSecurityQuestion.Visible = False
        ' 
        ' lblNewPass
        ' 
        lblNewPass.AutoSize = True
        lblNewPass.Location = New Point(95, 326)
        lblNewPass.Name = "lblNewPass"
        lblNewPass.Size = New Size(131, 25)
        lblNewPass.TabIndex = 7
        lblNewPass.Text = "New Password:"
        lblNewPass.Visible = False
        ' 
        ' TxtNewPass
        ' 
        TxtNewPass.Location = New Point(232, 326)
        TxtNewPass.Name = "TxtNewPass"
        TxtNewPass.Size = New Size(276, 31)
        TxtNewPass.TabIndex = 8
        TxtNewPass.Visible = False
        ' 
        ' BtnConfirmation
        ' 
        BtnConfirmation.Location = New Point(514, 234)
        BtnConfirmation.Name = "BtnConfirmation"
        BtnConfirmation.Size = New Size(182, 34)
        BtnConfirmation.TabIndex = 9
        BtnConfirmation.Text = "Confirm"
        BtnConfirmation.UseVisualStyleBackColor = True
        BtnConfirmation.Visible = False
        ' 
        ' BtnUpdatePass
        ' 
        BtnUpdatePass.Location = New Point(514, 326)
        BtnUpdatePass.Name = "BtnUpdatePass"
        BtnUpdatePass.Size = New Size(182, 34)
        BtnUpdatePass.TabIndex = 10
        BtnUpdatePass.Text = "Update Password"
        BtnUpdatePass.UseVisualStyleBackColor = True
        BtnUpdatePass.Visible = False
        ' 
        ' BtnBack
        ' 
        BtnBack.Location = New Point(12, 29)
        BtnBack.Name = "BtnBack"
        BtnBack.Size = New Size(158, 34)
        BtnBack.TabIndex = 11
        BtnBack.Text = "Back to Login"
        BtnBack.UseVisualStyleBackColor = True
        ' 
        ' FrmForgotPass
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
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
        Name = "FrmForgotPass"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FrmForgotPass"
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
End Class
