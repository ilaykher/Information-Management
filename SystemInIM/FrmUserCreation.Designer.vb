<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUserCreation
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
        txtCreateUsername = New TextBox()
        txtCreatePass = New TextBox()
        txtSecurityAnswer = New TextBox()
        cmbSecurityQuestion = New ComboBox()
        lblUsername = New Label()
        lblPass = New Label()
        lblSecQues = New Label()
        lblAnswer = New Label()
        BtnBackToLogin = New Button()
        BtnClear = New Button()
        BtnRegister = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' txtCreateUsername
        ' 
        txtCreateUsername.Font = New Font("Segoe UI", 10F)
        txtCreateUsername.Location = New Point(286, 214)
        txtCreateUsername.Margin = New Padding(2)
        txtCreateUsername.Name = "txtCreateUsername"
        txtCreateUsername.PlaceholderText = "(e.g. user)"
        txtCreateUsername.Size = New Size(266, 30)
        txtCreateUsername.TabIndex = 0
        ' 
        ' txtCreatePass
        ' 
        txtCreatePass.Font = New Font("Segoe UI", 10F)
        txtCreatePass.Location = New Point(286, 252)
        txtCreatePass.Margin = New Padding(2)
        txtCreatePass.Name = "txtCreatePass"
        txtCreatePass.PlaceholderText = "(Type in your password)"
        txtCreatePass.Size = New Size(266, 30)
        txtCreatePass.TabIndex = 1
        ' 
        ' txtSecurityAnswer
        ' 
        txtSecurityAnswer.Font = New Font("Segoe UI", 10F)
        txtSecurityAnswer.Location = New Point(286, 337)
        txtSecurityAnswer.Margin = New Padding(2)
        txtSecurityAnswer.Name = "txtSecurityAnswer"
        txtSecurityAnswer.PlaceholderText = "(Type in your answer)"
        txtSecurityAnswer.Size = New Size(266, 30)
        txtSecurityAnswer.TabIndex = 3
        ' 
        ' cmbSecurityQuestion
        ' 
        cmbSecurityQuestion.Font = New Font("Segoe UI", 10F)
        cmbSecurityQuestion.FormattingEnabled = True
        cmbSecurityQuestion.Items.AddRange(New Object() {"--Select--", "What is your favorite color?", "In what city you were born?", "What was the name of your first pet?", "What's your mother's maiden name?", "What is your birthdate?"})
        cmbSecurityQuestion.Location = New Point(286, 300)
        cmbSecurityQuestion.Margin = New Padding(2)
        cmbSecurityQuestion.Name = "cmbSecurityQuestion"
        cmbSecurityQuestion.Size = New Size(266, 31)
        cmbSecurityQuestion.TabIndex = 4
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI", 12F)
        lblUsername.Location = New Point(165, 214)
        lblUsername.Margin = New Padding(2, 0, 2, 0)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(108, 28)
        lblUsername.TabIndex = 5
        lblUsername.Text = "Username: "
        ' 
        ' lblPass
        ' 
        lblPass.AutoSize = True
        lblPass.Font = New Font("Segoe UI", 12F)
        lblPass.Location = New Point(171, 255)
        lblPass.Margin = New Padding(2, 0, 2, 0)
        lblPass.Name = "lblPass"
        lblPass.Size = New Size(102, 28)
        lblPass.TabIndex = 6
        lblPass.Text = "Password: "
        ' 
        ' lblSecQues
        ' 
        lblSecQues.AutoSize = True
        lblSecQues.Font = New Font("Segoe UI", 12F)
        lblSecQues.Location = New Point(90, 296)
        lblSecQues.Margin = New Padding(2, 0, 2, 0)
        lblSecQues.Name = "lblSecQues"
        lblSecQues.Size = New Size(183, 28)
        lblSecQues.TabIndex = 7
        lblSecQues.Text = "Security Questions: "
        ' 
        ' lblAnswer
        ' 
        lblAnswer.AutoSize = True
        lblAnswer.Font = New Font("Segoe UI", 12F)
        lblAnswer.Location = New Point(189, 333)
        lblAnswer.Margin = New Padding(2, 0, 2, 0)
        lblAnswer.Name = "lblAnswer"
        lblAnswer.Size = New Size(84, 28)
        lblAnswer.TabIndex = 8
        lblAnswer.Text = "Answer: "
        ' 
        ' BtnBackToLogin
        ' 
        BtnBackToLogin.Font = New Font("Segoe UI", 12F)
        BtnBackToLogin.Location = New Point(624, 26)
        BtnBackToLogin.Margin = New Padding(2)
        BtnBackToLogin.Name = "BtnBackToLogin"
        BtnBackToLogin.Size = New Size(147, 37)
        BtnBackToLogin.TabIndex = 9
        BtnBackToLogin.Text = "Back to Login"
        BtnBackToLogin.UseVisualStyleBackColor = True
        ' 
        ' BtnClear
        ' 
        BtnClear.Font = New Font("Segoe UI", 12F)
        BtnClear.Location = New Point(368, 377)
        BtnClear.Margin = New Padding(2)
        BtnClear.Name = "BtnClear"
        BtnClear.Size = New Size(90, 36)
        BtnClear.TabIndex = 10
        BtnClear.Text = "Clear"
        BtnClear.UseVisualStyleBackColor = True
        ' 
        ' BtnRegister
        ' 
        BtnRegister.Font = New Font("Segoe UI", 12F)
        BtnRegister.Location = New Point(462, 377)
        BtnRegister.Margin = New Padding(2)
        BtnRegister.Name = "BtnRegister"
        BtnRegister.Size = New Size(90, 36)
        BtnRegister.TabIndex = 11
        BtnRegister.Text = "Register"
        BtnRegister.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(249, 143)
        Label1.Name = "Label1"
        Label1.Size = New Size(274, 41)
        Label1.TabIndex = 12
        Label1.Text = "Create an Account"
        ' 
        ' FrmUserCreation
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(782, 553)
        Controls.Add(Label1)
        Controls.Add(BtnRegister)
        Controls.Add(BtnClear)
        Controls.Add(BtnBackToLogin)
        Controls.Add(lblAnswer)
        Controls.Add(lblSecQues)
        Controls.Add(lblPass)
        Controls.Add(lblUsername)
        Controls.Add(cmbSecurityQuestion)
        Controls.Add(txtSecurityAnswer)
        Controls.Add(txtCreatePass)
        Controls.Add(txtCreateUsername)
        Margin = New Padding(2)
        Name = "FrmUserCreation"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Device Market System"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtCreateUsername As TextBox
    Friend WithEvents txtCreatePass As TextBox
    Friend WithEvents txtSecurityAnswer As TextBox
    Friend WithEvents cmbSecurityQuestion As ComboBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPass As Label
    Friend WithEvents lblSecQues As Label
    Friend WithEvents lblAnswer As Label
    Friend WithEvents BtnBackToLogin As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnRegister As Button
    Friend WithEvents Label1 As Label
End Class
