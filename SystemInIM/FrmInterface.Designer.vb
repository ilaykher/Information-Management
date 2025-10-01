<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInterface
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlHeader = New Panel()
        BtnLogout = New Button()
        lblDeviceMarketSystem = New Label()
        pnlSearchBar = New Panel()
        lblCategory = New Label()
        cmbCategory = New ComboBox()
        txtSearchBar = New TextBox()
        lblSearch = New Label()
        dgvProductDisplay = New DataGridView()
        pnlMain = New Panel()
        Panel1 = New Panel()
        BtnClear = New Button()
        BtnRemove = New Button()
        BtnEdit = New Button()
        BtnSave = New Button()
        BtnRemoveIMG = New Button()
        BtnUploadIMG = New Button()
        txtProductDesc = New TextBox()
        txtProductStock = New TextBox()
        txtProductPrice = New TextBox()
        txtProductName = New TextBox()
        cmbProductCategory = New ComboBox()
        lblDesc = New Label()
        lblStock = New Label()
        lblPrice = New Label()
        lblCategories = New Label()
        lblName = New Label()
        pbPicture = New PictureBox()
        pnlHeader.SuspendLayout()
        pnlSearchBar.SuspendLayout()
        CType(dgvProductDisplay, ComponentModel.ISupportInitialize).BeginInit()
        pnlMain.SuspendLayout()
        Panel1.SuspendLayout()
        CType(pbPicture, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.Controls.Add(BtnLogout)
        pnlHeader.Controls.Add(lblDeviceMarketSystem)
        pnlHeader.Location = New Point(25, 11)
        pnlHeader.Margin = New Padding(2)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1850, 130)
        pnlHeader.TabIndex = 0
        ' 
        ' BtnLogout
        ' 
        BtnLogout.Location = New Point(1546, 32)
        BtnLogout.Margin = New Padding(2)
        BtnLogout.Name = "BtnLogout"
        BtnLogout.Size = New Size(90, 27)
        BtnLogout.TabIndex = 3
        BtnLogout.Text = "Logout"
        BtnLogout.UseVisualStyleBackColor = True
        ' 
        ' lblDeviceMarketSystem
        ' 
        lblDeviceMarketSystem.AutoSize = True
        lblDeviceMarketSystem.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDeviceMarketSystem.Location = New Point(757, 21)
        lblDeviceMarketSystem.Margin = New Padding(2, 0, 2, 0)
        lblDeviceMarketSystem.Name = "lblDeviceMarketSystem"
        lblDeviceMarketSystem.Size = New Size(336, 37)
        lblDeviceMarketSystem.TabIndex = 0
        lblDeviceMarketSystem.Text = "DEVICE MARKET SYSTEM"
        ' 
        ' pnlSearchBar
        ' 
        pnlSearchBar.Controls.Add(lblCategory)
        pnlSearchBar.Controls.Add(cmbCategory)
        pnlSearchBar.Controls.Add(txtSearchBar)
        pnlSearchBar.Controls.Add(lblSearch)
        pnlSearchBar.Location = New Point(631, 21)
        pnlSearchBar.Margin = New Padding(2)
        pnlSearchBar.Name = "pnlSearchBar"
        pnlSearchBar.Size = New Size(1086, 78)
        pnlSearchBar.TabIndex = 0
        ' 
        ' lblCategory
        ' 
        lblCategory.AutoSize = True
        lblCategory.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCategory.Location = New Point(520, 21)
        lblCategory.Margin = New Padding(2, 0, 2, 0)
        lblCategory.Name = "lblCategory"
        lblCategory.Size = New Size(143, 37)
        lblCategory.TabIndex = 14
        lblCategory.Text = "Category:"
        ' 
        ' cmbCategory
        ' 
        cmbCategory.FormattingEnabled = True
        cmbCategory.Items.AddRange(New Object() {"--Select--", "Cellphone", "Computer", "Laptop"})
        cmbCategory.Location = New Point(667, 28)
        cmbCategory.Margin = New Padding(2)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(146, 28)
        cmbCategory.TabIndex = 13
        ' 
        ' txtSearchBar
        ' 
        txtSearchBar.Location = New Point(108, 28)
        txtSearchBar.Margin = New Padding(2)
        txtSearchBar.Name = "txtSearchBar"
        txtSearchBar.Size = New Size(363, 27)
        txtSearchBar.TabIndex = 12
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSearch.Location = New Point(4, 21)
        lblSearch.Margin = New Padding(2, 0, 2, 0)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(116, 37)
        lblSearch.TabIndex = 11
        lblSearch.Text = "Search: "
        ' 
        ' dgvProductDisplay
        ' 
        dgvProductDisplay.AllowUserToAddRows = False
        dgvProductDisplay.AllowUserToDeleteRows = False
        dgvProductDisplay.AllowUserToResizeColumns = False
        dgvProductDisplay.AllowUserToResizeRows = False
        dgvProductDisplay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvProductDisplay.BackgroundColor = SystemColors.AppWorkspace
        dgvProductDisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        dgvProductDisplay.DefaultCellStyle = DataGridViewCellStyle1
        dgvProductDisplay.Location = New Point(631, 119)
        dgvProductDisplay.Margin = New Padding(2)
        dgvProductDisplay.Name = "dgvProductDisplay"
        dgvProductDisplay.ReadOnly = True
        dgvProductDisplay.RowHeadersVisible = False
        dgvProductDisplay.RowHeadersWidth = 62
        dgvProductDisplay.RowTemplate.Height = 150
        dgvProductDisplay.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvProductDisplay.Size = New Size(1086, 743)
        dgvProductDisplay.TabIndex = 1
        ' 
        ' pnlMain
        ' 
        pnlMain.Controls.Add(Panel1)
        pnlMain.Controls.Add(dgvProductDisplay)
        pnlMain.Controls.Add(pnlSearchBar)
        pnlMain.Location = New Point(25, 145)
        pnlMain.Margin = New Padding(2)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(1850, 877)
        pnlMain.TabIndex = 2
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(BtnClear)
        Panel1.Controls.Add(BtnRemove)
        Panel1.Controls.Add(BtnEdit)
        Panel1.Controls.Add(BtnSave)
        Panel1.Controls.Add(BtnRemoveIMG)
        Panel1.Controls.Add(BtnUploadIMG)
        Panel1.Controls.Add(txtProductDesc)
        Panel1.Controls.Add(txtProductStock)
        Panel1.Controls.Add(txtProductPrice)
        Panel1.Controls.Add(txtProductName)
        Panel1.Controls.Add(cmbProductCategory)
        Panel1.Controls.Add(lblDesc)
        Panel1.Controls.Add(lblStock)
        Panel1.Controls.Add(lblPrice)
        Panel1.Controls.Add(lblCategories)
        Panel1.Controls.Add(lblName)
        Panel1.Controls.Add(pbPicture)
        Panel1.Location = New Point(24, 21)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(593, 841)
        Panel1.TabIndex = 30
        ' 
        ' BtnClear
        ' 
        BtnClear.Location = New Point(440, 763)
        BtnClear.Name = "BtnClear"
        BtnClear.Size = New Size(135, 45)
        BtnClear.TabIndex = 16
        BtnClear.Text = "Clear"
        BtnClear.UseVisualStyleBackColor = True
        ' 
        ' BtnRemove
        ' 
        BtnRemove.Location = New Point(299, 763)
        BtnRemove.Name = "BtnRemove"
        BtnRemove.Size = New Size(135, 45)
        BtnRemove.TabIndex = 15
        BtnRemove.Text = "Remove"
        BtnRemove.UseVisualStyleBackColor = True
        ' 
        ' BtnEdit
        ' 
        BtnEdit.Location = New Point(153, 763)
        BtnEdit.Name = "BtnEdit"
        BtnEdit.Size = New Size(135, 45)
        BtnEdit.TabIndex = 14
        BtnEdit.Text = "Edit"
        BtnEdit.UseVisualStyleBackColor = True
        ' 
        ' BtnSave
        ' 
        BtnSave.Location = New Point(12, 763)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(135, 45)
        BtnSave.TabIndex = 13
        BtnSave.Text = "Save"
        BtnSave.UseVisualStyleBackColor = True
        ' 
        ' BtnRemoveIMG
        ' 
        BtnRemoveIMG.Location = New Point(299, 509)
        BtnRemoveIMG.Name = "BtnRemoveIMG"
        BtnRemoveIMG.Size = New Size(132, 29)
        BtnRemoveIMG.TabIndex = 12
        BtnRemoveIMG.Text = "Remove IMG"
        BtnRemoveIMG.UseVisualStyleBackColor = True
        ' 
        ' BtnUploadIMG
        ' 
        BtnUploadIMG.Location = New Point(108, 509)
        BtnUploadIMG.Name = "BtnUploadIMG"
        BtnUploadIMG.Size = New Size(132, 29)
        BtnUploadIMG.TabIndex = 11
        BtnUploadIMG.Text = "Upload IMG"
        BtnUploadIMG.UseVisualStyleBackColor = True
        ' 
        ' txtProductDesc
        ' 
        txtProductDesc.Location = New Point(12, 207)
        txtProductDesc.Margin = New Padding(2)
        txtProductDesc.Multiline = True
        txtProductDesc.Name = "txtProductDesc"
        txtProductDesc.Size = New Size(563, 297)
        txtProductDesc.TabIndex = 9
        ' 
        ' txtProductStock
        ' 
        txtProductStock.Location = New Point(320, 152)
        txtProductStock.Margin = New Padding(2)
        txtProductStock.Name = "txtProductStock"
        txtProductStock.Size = New Size(114, 27)
        txtProductStock.TabIndex = 8
        ' 
        ' txtProductPrice
        ' 
        txtProductPrice.Location = New Point(108, 152)
        txtProductPrice.Margin = New Padding(2)
        txtProductPrice.Name = "txtProductPrice"
        txtProductPrice.Size = New Size(112, 27)
        txtProductPrice.TabIndex = 7
        ' 
        ' txtProductName
        ' 
        txtProductName.Location = New Point(108, 77)
        txtProductName.Margin = New Padding(2)
        txtProductName.Name = "txtProductName"
        txtProductName.Size = New Size(326, 27)
        txtProductName.TabIndex = 6
        ' 
        ' cmbProductCategory
        ' 
        cmbProductCategory.DropDownStyle = ComboBoxStyle.DropDownList
        cmbProductCategory.FormattingEnabled = True
        cmbProductCategory.Items.AddRange(New Object() {"--Select--", "Cellphone", "Computer", "Laptop"})
        cmbProductCategory.Location = New Point(108, 115)
        cmbProductCategory.Margin = New Padding(2)
        cmbProductCategory.Name = "cmbProductCategory"
        cmbProductCategory.Size = New Size(326, 28)
        cmbProductCategory.TabIndex = 5
        ' 
        ' lblDesc
        ' 
        lblDesc.AutoSize = True
        lblDesc.Location = New Point(12, 185)
        lblDesc.Margin = New Padding(2, 0, 2, 0)
        lblDesc.Name = "lblDesc"
        lblDesc.Size = New Size(92, 20)
        lblDesc.TabIndex = 4
        lblDesc.Text = "Description: "
        ' 
        ' lblStock
        ' 
        lblStock.AutoSize = True
        lblStock.Location = New Point(264, 155)
        lblStock.Margin = New Padding(2, 0, 2, 0)
        lblStock.Name = "lblStock"
        lblStock.Size = New Size(52, 20)
        lblStock.TabIndex = 3
        lblStock.Text = "Stock: "
        ' 
        ' lblPrice
        ' 
        lblPrice.AutoSize = True
        lblPrice.Location = New Point(56, 155)
        lblPrice.Margin = New Padding(2, 0, 2, 0)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(48, 20)
        lblPrice.TabIndex = 2
        lblPrice.Text = "Price: "
        ' 
        ' lblCategories
        ' 
        lblCategories.AutoSize = True
        lblCategories.Location = New Point(28, 115)
        lblCategories.Margin = New Padding(2, 0, 2, 0)
        lblCategories.Name = "lblCategories"
        lblCategories.Size = New Size(76, 20)
        lblCategories.TabIndex = 1
        lblCategories.Text = "Category: "
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(48, 80)
        lblName.Margin = New Padding(2, 0, 2, 0)
        lblName.Name = "lblName"
        lblName.Size = New Size(56, 20)
        lblName.TabIndex = 0
        lblName.Text = "Name: "
        ' 
        ' pbPicture
        ' 
        pbPicture.Location = New Point(108, 544)
        pbPicture.Name = "pbPicture"
        pbPicture.Size = New Size(326, 191)
        pbPicture.SizeMode = PictureBoxSizeMode.Zoom
        pbPicture.TabIndex = 10
        pbPicture.TabStop = False
        ' 
        ' FrmInterface
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1902, 1033)
        Controls.Add(pnlMain)
        Controls.Add(pnlHeader)
        Margin = New Padding(2)
        Name = "FrmInterface"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Shopipi"
        WindowState = FormWindowState.Maximized
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlSearchBar.ResumeLayout(False)
        pnlSearchBar.PerformLayout()
        CType(dgvProductDisplay, ComponentModel.ISupportInitialize).EndInit()
        pnlMain.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(pbPicture, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblDeviceMarketSystem As Label
    Friend WithEvents BtnLogout As Button
    Friend WithEvents pnlSearchBar As Panel
    Friend WithEvents lblCategory As Label
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents txtSearchBar As TextBox
    Friend WithEvents lblSearch As Label
    Friend WithEvents dgvProductDisplay As DataGridView
    Friend WithEvents pnlMain As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtProductDesc As TextBox
    Friend WithEvents txtProductStock As TextBox
    Friend WithEvents txtProductPrice As TextBox
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents cmbProductCategory As ComboBox
    Friend WithEvents lblDesc As Label
    Friend WithEvents lblStock As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblCategories As Label
    Friend WithEvents lblName As Label
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnRemove As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnRemoveIMG As Button
    Friend WithEvents BtnUploadIMG As Button
    Friend WithEvents pbPicture As PictureBox
End Class
