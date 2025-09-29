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
        SuspendLayout()
        ' 
        ' txtCreateUsername
        ' 
        txtCreateUsername.Location = New Point(271, 68)
        txtCreateUsername.Name = "txtCreateUsername"
        txtCreateUsername.Size = New Size(331, 31)
        txtCreateUsername.TabIndex = 0
        ' 
        ' txtCreatePass
        ' 
        txtCreatePass.Location = New Point(271, 115)
        txtCreatePass.Name = "txtCreatePass"
        txtCreatePass.Size = New Size(331, 31)
        txtCreatePass.TabIndex = 1
        ' 
        ' txtSecurityAnswer
        ' 
        txtSecurityAnswer.Location = New Point(271, 259)
        txtSecurityAnswer.Name = "txtSecurityAnswer"
        txtSecurityAnswer.Size = New Size(331, 31)
        txtSecurityAnswer.TabIndex = 3
        ' 
        ' cmbSecurityQuestion
        ' 
        cmbSecurityQuestion.FormattingEnabled = True
        cmbSecurityQuestion.Items.AddRange(New Object() {"What is your favorite color?", "In what city you were born?", "What was the name of your first pet?", "What's your mother's maiden name?", "What is your birthdate?"})
        cmbSecurityQuestion.Location = New Point(271, 208)
        cmbSecurityQuestion.Name = "cmbSecurityQuestion"
        cmbSecurityQuestion.Size = New Size(331, 33)
        cmbSecurityQuestion.TabIndex = 4
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Location = New Point(150, 74)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(100, 25)
        lblUsername.TabIndex = 5
        lblUsername.Text = "Username: "
        ' 
        ' lblPass
        ' 
        lblPass.AutoSize = True
        lblPass.Location = New Point(154, 121)
        lblPass.Name = "lblPass"
        lblPass.Size = New Size(96, 25)
        lblPass.TabIndex = 6
        lblPass.Text = "Password: "
        ' 
        ' lblSecQues
        ' 
        lblSecQues.AutoSize = True
        lblSecQues.Location = New Point(82, 211)
        lblSecQues.Name = "lblSecQues"
        lblSecQues.Size = New Size(168, 25)
        lblSecQues.TabIndex = 7
        lblSecQues.Text = "Security Questions: "
        ' 
        ' lblAnswer
        ' 
        lblAnswer.AutoSize = True
        lblAnswer.Location = New Point(171, 262)
        lblAnswer.Name = "lblAnswer"
        lblAnswer.Size = New Size(79, 25)
        lblAnswer.TabIndex = 8
        lblAnswer.Text = "Answer: "
        ' 
        ' BtnBackToLogin
        ' 
        BtnBackToLogin.Location = New Point(645, 12)
        BtnBackToLogin.Name = "BtnBackToLogin"
        BtnBackToLogin.Size = New Size(143, 34)
        BtnBackToLogin.TabIndex = 9
        BtnBackToLogin.Text = "Back to Login"
        BtnBackToLogin.UseVisualStyleBackColor = True
        ' 
        ' BtnClear
        ' 
        BtnClear.Location = New Point(372, 317)
        BtnClear.Name = "BtnClear"
        BtnClear.Size = New Size(112, 34)
        BtnClear.TabIndex = 10
        BtnClear.Text = "Clear"
        BtnClear.UseVisualStyleBackColor = True
        ' 
        ' BtnRegister
        ' 
        BtnRegister.Location = New Point(490, 317)
        BtnRegister.Name = "BtnRegister"
        BtnRegister.Size = New Size(112, 34)
        BtnRegister.TabIndex = 11
        BtnRegister.Text = "Register"
        BtnRegister.UseVisualStyleBackColor = True
        ' 
        ' FrmUserCreation
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
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
        Name = "FrmUserCreation"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Shopipi"
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
End Class
