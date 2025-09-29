<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdminInsertPanel
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
        BtnClear = New Button()
        Label6 = New Label()
        Button3 = New Button()
        BtnInsertAProduct = New Button()
        Panel2 = New Panel()
        BtnUploadAnImage = New Button()
        pbProductPic = New PictureBox()
        Panel1 = New Panel()
        txtProductDesc = New TextBox()
        txtProductStock = New TextBox()
        txtProductPrice = New TextBox()
        txtProductName = New TextBox()
        cmbProductCategory = New ComboBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel2.SuspendLayout()
        CType(pbProductPic, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' BtnClear
        ' 
        BtnClear.Location = New Point(20, 373)
        BtnClear.Margin = New Padding(2)
        BtnClear.Name = "BtnClear"
        BtnClear.Size = New Size(90, 27)
        BtnClear.TabIndex = 17
        BtnClear.Text = "Clear"
        BtnClear.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(292, 26)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(104, 20)
        Label6.TabIndex = 16
        Label6.Text = "Add a Product"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(517, 373)
        Button3.Margin = New Padding(2)
        Button3.Name = "Button3"
        Button3.Size = New Size(90, 27)
        Button3.TabIndex = 15
        Button3.Text = "Cancel"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' BtnInsertAProduct
        ' 
        BtnInsertAProduct.Location = New Point(292, 373)
        BtnInsertAProduct.Margin = New Padding(2)
        BtnInsertAProduct.Name = "BtnInsertAProduct"
        BtnInsertAProduct.Size = New Size(90, 27)
        BtnInsertAProduct.TabIndex = 14
        BtnInsertAProduct.Text = "Save"
        BtnInsertAProduct.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(BtnUploadAnImage)
        Panel2.Controls.Add(pbProductPic)
        Panel2.Location = New Point(386, 70)
        Panel2.Margin = New Padding(2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(221, 290)
        Panel2.TabIndex = 13
        ' 
        ' BtnUploadAnImage
        ' 
        BtnUploadAnImage.Location = New Point(40, 242)
        BtnUploadAnImage.Margin = New Padding(2)
        BtnUploadAnImage.Name = "BtnUploadAnImage"
        BtnUploadAnImage.Size = New Size(144, 27)
        BtnUploadAnImage.TabIndex = 1
        BtnUploadAnImage.Text = "Upload an Image"
        BtnUploadAnImage.UseVisualStyleBackColor = True
        ' 
        ' pbProductPic
        ' 
        pbProductPic.Location = New Point(13, 15)
        pbProductPic.Margin = New Padding(2)
        pbProductPic.Name = "pbProductPic"
        pbProductPic.Size = New Size(193, 222)
        pbProductPic.TabIndex = 0
        pbProductPic.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(txtProductDesc)
        Panel1.Controls.Add(txtProductStock)
        Panel1.Controls.Add(txtProductPrice)
        Panel1.Controls.Add(txtProductName)
        Panel1.Controls.Add(cmbProductCategory)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(15, 70)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(366, 290)
        Panel1.TabIndex = 12
        ' 
        ' txtProductDesc
        ' 
        txtProductDesc.Location = New Point(89, 166)
        txtProductDesc.Margin = New Padding(2)
        txtProductDesc.Multiline = True
        txtProductDesc.Name = "txtProductDesc"
        txtProductDesc.Size = New Size(269, 104)
        txtProductDesc.TabIndex = 9
        ' 
        ' txtProductStock
        ' 
        txtProductStock.Location = New Point(89, 125)
        txtProductStock.Margin = New Padding(2)
        txtProductStock.Name = "txtProductStock"
        txtProductStock.Size = New Size(269, 27)
        txtProductStock.TabIndex = 8
        ' 
        ' txtProductPrice
        ' 
        txtProductPrice.Location = New Point(89, 95)
        txtProductPrice.Margin = New Padding(2)
        txtProductPrice.Name = "txtProductPrice"
        txtProductPrice.Size = New Size(269, 27)
        txtProductPrice.TabIndex = 7
        ' 
        ' txtProductName
        ' 
        txtProductName.Location = New Point(89, 11)
        txtProductName.Margin = New Padding(2)
        txtProductName.Name = "txtProductName"
        txtProductName.Size = New Size(269, 27)
        txtProductName.TabIndex = 6
        ' 
        ' cmbProductCategory
        ' 
        cmbProductCategory.FormattingEnabled = True
        cmbProductCategory.Location = New Point(89, 55)
        cmbProductCategory.Margin = New Padding(2)
        cmbProductCategory.Name = "cmbProductCategory"
        cmbProductCategory.Size = New Size(269, 28)
        cmbProductCategory.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(5, 166)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(92, 20)
        Label5.TabIndex = 4
        Label5.Text = "Description: "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(42, 125)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(52, 20)
        Label4.TabIndex = 3
        Label4.Text = "Stock: "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(47, 94)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 20)
        Label3.TabIndex = 2
        Label3.Text = "Price: "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(19, 55)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 20)
        Label2.TabIndex = 1
        Label2.Text = "Category: "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(39, 11)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 20)
        Label1.TabIndex = 0
        Label1.Text = "Name: "
        ' 
        ' FrmAdminInsertPanel
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(622, 435)
        Controls.Add(BtnClear)
        Controls.Add(Label6)
        Controls.Add(Button3)
        Controls.Add(BtnInsertAProduct)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(2)
        Name = "FrmAdminInsertPanel"
        Text = "FrmAdminInsertPanel"
        Panel2.ResumeLayout(False)
        CType(pbProductPic, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnClear As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents BtnInsertAProduct As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnUploadAnImage As Button
    Friend WithEvents pbProductPic As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtProductDesc As TextBox
    Friend WithEvents txtProductStock As TextBox
    Friend WithEvents txtProductPrice As TextBox
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents cmbProductCategory As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
