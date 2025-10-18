<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transactionHistory
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
        Button1 = New Button()
        Label1 = New Label()
        Panel1 = New Panel()
        DataGridView1 = New DataGridView()
        Button2 = New Button()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.SlateGray
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = SystemColors.ButtonFace
        Button1.Location = New Point(12, 73)
        Button1.Name = "Button1"
        Button1.Size = New Size(209, 39)
        Button1.TabIndex = 0
        Button1.Text = "Transaction History"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(13, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(178, 28)
        Label1.TabIndex = 1
        Label1.Text = "Transaction HIstory"
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(DataGridView1)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(245, 32)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(629, 437)
        Panel1.TabIndex = 2
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(-1, 68)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(629, 368)
        DataGridView1.TabIndex = 2
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.SlateGray
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.White
        Button2.Location = New Point(12, 135)
        Button2.Name = "Button2"
        Button2.Size = New Size(162, 39)
        Button2.TabIndex = 3
        Button2.Text = "Pending Orders"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' transactionHistory
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.OldLace
        ClientSize = New Size(922, 498)
        Controls.Add(Button2)
        Controls.Add(Panel1)
        Controls.Add(Button1)
        Name = "transactionHistory"
        Text = "transactionHistory"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
