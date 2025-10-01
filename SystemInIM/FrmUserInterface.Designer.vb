<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUserInterface
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
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        dgvProductDisplay = New DataGridView()
        lblDeviceMarketSystem = New Label()
        BtnLogout = New Button()
        pnlSearchBar = New Panel()
        lblCategory = New Label()
        cmbCategorySearch = New ComboBox()
        txtSearchBar = New TextBox()
        lblSearch = New Label()
        BtnRefresh = New Button()
        BtnBuyNow = New Button()
        BtnAddToCart = New Button()
        Panel2 = New Panel()
        lblShowBalance = New Label()
        lblSetBalance = New Label()
        BtnBalance = New Button()
        txtUserBalance = New TextBox()
        lblWelcome = New Label()
        tbControlMain = New TabControl()
        TabPage1 = New TabPage()
        BtnViewDetails = New Button()
        TabPage2 = New TabPage()
        BtnRemoveAll = New Button()
        BtnRefreshAll = New Button()
        BtnRemoveAddToCart = New Button()
        Panel3 = New Panel()
        Label1 = New Label()
        cmbCategoryViewCart = New ComboBox()
        txtBoxSearchBarViewCart = New TextBox()
        Label2 = New Label()
        DataGridView1 = New DataGridView()
        BtnPlaceAnOrder = New Button()
        CType(dgvProductDisplay, ComponentModel.ISupportInitialize).BeginInit()
        pnlSearchBar.SuspendLayout()
        Panel2.SuspendLayout()
        tbControlMain.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvProductDisplay
        ' 
        dgvProductDisplay.AllowUserToAddRows = False
        dgvProductDisplay.AllowUserToDeleteRows = False
        dgvProductDisplay.AllowUserToOrderColumns = True
        dgvProductDisplay.AllowUserToResizeColumns = False
        dgvProductDisplay.AllowUserToResizeRows = False
        dgvProductDisplay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvProductDisplay.BackgroundColor = SystemColors.AppWorkspace
        dgvProductDisplay.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 12F)
        DataGridViewCellStyle2.ForeColor = SystemColors.Info
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvProductDisplay.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvProductDisplay.ColumnHeadersHeight = 29
        dgvProductDisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvProductDisplay.Location = New Point(361, 87)
        dgvProductDisplay.Margin = New Padding(2)
        dgvProductDisplay.MultiSelect = False
        dgvProductDisplay.Name = "dgvProductDisplay"
        dgvProductDisplay.ReadOnly = True
        dgvProductDisplay.RowHeadersVisible = False
        dgvProductDisplay.RowHeadersWidth = 62
        dgvProductDisplay.RowTemplate.Height = 150
        dgvProductDisplay.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvProductDisplay.Size = New Size(1330, 562)
        dgvProductDisplay.TabIndex = 2
        ' 
        ' lblDeviceMarketSystem
        ' 
        lblDeviceMarketSystem.BackColor = Color.FromArgb(CByte(102), CByte(126), CByte(234))
        lblDeviceMarketSystem.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDeviceMarketSystem.ForeColor = Color.White
        lblDeviceMarketSystem.Location = New Point(351, 27)
        lblDeviceMarketSystem.Margin = New Padding(2, 0, 2, 0)
        lblDeviceMarketSystem.Name = "lblDeviceMarketSystem"
        lblDeviceMarketSystem.Padding = New Padding(20)
        lblDeviceMarketSystem.Size = New Size(1200, 89)
        lblDeviceMarketSystem.TabIndex = 0
        lblDeviceMarketSystem.Text = "DEVICE MARKET SYSTEM"
        lblDeviceMarketSystem.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BtnLogout
        ' 
        BtnLogout.Font = New Font("Segoe UI", 12F)
        BtnLogout.Location = New Point(377, 88)
        BtnLogout.Margin = New Padding(2)
        BtnLogout.Name = "BtnLogout"
        BtnLogout.Size = New Size(126, 38)
        BtnLogout.TabIndex = 3
        BtnLogout.Text = "Logout"
        BtnLogout.UseVisualStyleBackColor = True
        ' 
        ' pnlSearchBar
        ' 
        pnlSearchBar.Controls.Add(lblCategory)
        pnlSearchBar.Controls.Add(cmbCategorySearch)
        pnlSearchBar.Controls.Add(txtSearchBar)
        pnlSearchBar.Controls.Add(lblSearch)
        pnlSearchBar.Location = New Point(361, 19)
        pnlSearchBar.Margin = New Padding(2)
        pnlSearchBar.Name = "pnlSearchBar"
        pnlSearchBar.Size = New Size(986, 64)
        pnlSearchBar.TabIndex = 5
        ' 
        ' lblCategory
        ' 
        lblCategory.AutoSize = True
        lblCategory.Font = New Font("Segoe UI", 12F)
        lblCategory.Location = New Point(553, 15)
        lblCategory.Margin = New Padding(2, 0, 2, 0)
        lblCategory.Name = "lblCategory"
        lblCategory.Size = New Size(96, 28)
        lblCategory.TabIndex = 14
        lblCategory.Text = "Category:"
        ' 
        ' cmbCategorySearch
        ' 
        cmbCategorySearch.FormattingEnabled = True
        cmbCategorySearch.Items.AddRange(New Object() {"--Select--", "Cellphone", "Computer", "Laptop"})
        cmbCategorySearch.Location = New Point(661, 12)
        cmbCategorySearch.Margin = New Padding(2)
        cmbCategorySearch.Name = "cmbCategorySearch"
        cmbCategorySearch.Size = New Size(146, 36)
        cmbCategorySearch.TabIndex = 13
        ' 
        ' txtSearchBar
        ' 
        txtSearchBar.BorderStyle = BorderStyle.FixedSingle
        txtSearchBar.Location = New Point(103, 16)
        txtSearchBar.Margin = New Padding(2)
        txtSearchBar.Name = "txtSearchBar"
        txtSearchBar.Size = New Size(410, 34)
        txtSearchBar.TabIndex = 12
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Font = New Font("Segoe UI", 12F)
        lblSearch.Location = New Point(12, 15)
        lblSearch.Margin = New Padding(2, 0, 2, 0)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(79, 28)
        lblSearch.TabIndex = 11
        lblSearch.Text = "Search: "
        ' 
        ' BtnRefresh
        ' 
        BtnRefresh.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        BtnRefresh.Location = New Point(77, 505)
        BtnRefresh.Name = "BtnRefresh"
        BtnRefresh.Size = New Size(190, 101)
        BtnRefresh.TabIndex = 20
        BtnRefresh.Text = "Refresh"
        BtnRefresh.UseVisualStyleBackColor = True
        ' 
        ' BtnBuyNow
        ' 
        BtnBuyNow.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold)
        BtnBuyNow.Location = New Point(77, 254)
        BtnBuyNow.Name = "BtnBuyNow"
        BtnBuyNow.Size = New Size(190, 101)
        BtnBuyNow.TabIndex = 19
        BtnBuyNow.Text = "Buy Now"
        BtnBuyNow.UseVisualStyleBackColor = True
        ' 
        ' BtnAddToCart
        ' 
        BtnAddToCart.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold)
        BtnAddToCart.Location = New Point(77, 132)
        BtnAddToCart.Name = "BtnAddToCart"
        BtnAddToCart.Size = New Size(190, 101)
        BtnAddToCart.TabIndex = 17
        BtnAddToCart.Text = "Add to Cart"
        BtnAddToCart.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(lblShowBalance)
        Panel2.Controls.Add(lblSetBalance)
        Panel2.Controls.Add(BtnBalance)
        Panel2.Controls.Add(txtUserBalance)
        Panel2.Controls.Add(lblWelcome)
        Panel2.Controls.Add(BtnLogout)
        Panel2.Location = New Point(45, 119)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(524, 188)
        Panel2.TabIndex = 22
        ' 
        ' lblShowBalance
        ' 
        lblShowBalance.AutoSize = True
        lblShowBalance.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblShowBalance.ForeColor = Color.FromArgb(CByte(51), CByte(51), CByte(51))
        lblShowBalance.Location = New Point(61, 93)
        lblShowBalance.Name = "lblShowBalance"
        lblShowBalance.Size = New Size(90, 25)
        lblShowBalance.TabIndex = 25
        lblShowBalance.Text = "Balance: "
        ' 
        ' lblSetBalance
        ' 
        lblSetBalance.AutoSize = True
        lblSetBalance.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblSetBalance.Location = New Point(19, 142)
        lblSetBalance.Name = "lblSetBalance"
        lblSetBalance.Size = New Size(141, 28)
        lblSetBalance.TabIndex = 24
        lblSetBalance.Text = "Add Balance: "
        ' 
        ' BtnBalance
        ' 
        BtnBalance.BackColor = Color.FromArgb(CByte(40), CByte(167), CByte(69))
        BtnBalance.Cursor = Cursors.Hand
        BtnBalance.FlatAppearance.BorderSize = 0
        BtnBalance.FlatStyle = FlatStyle.Flat
        BtnBalance.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        BtnBalance.ForeColor = Color.White
        BtnBalance.Location = New Point(377, 137)
        BtnBalance.Margin = New Padding(2)
        BtnBalance.Name = "BtnBalance"
        BtnBalance.Size = New Size(126, 38)
        BtnBalance.TabIndex = 23
        BtnBalance.Text = "Set Balance"
        BtnBalance.UseVisualStyleBackColor = False
        ' 
        ' txtUserBalance
        ' 
        txtUserBalance.BorderStyle = BorderStyle.FixedSingle
        txtUserBalance.Font = New Font("Segoe UI", 12F)
        txtUserBalance.Location = New Point(165, 139)
        txtUserBalance.Margin = New Padding(2)
        txtUserBalance.Name = "txtUserBalance"
        txtUserBalance.Size = New Size(198, 34)
        txtUserBalance.TabIndex = 22
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        lblWelcome.ForeColor = Color.FromArgb(CByte(51), CByte(51), CByte(51))
        lblWelcome.Location = New Point(19, 19)
        lblWelcome.Margin = New Padding(2, 0, 2, 0)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(133, 32)
        lblWelcome.TabIndex = 1
        lblWelcome.Text = "Welcome, "
        ' 
        ' tbControlMain
        ' 
        tbControlMain.Controls.Add(TabPage1)
        tbControlMain.Controls.Add(TabPage2)
        tbControlMain.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tbControlMain.Location = New Point(45, 313)
        tbControlMain.Name = "tbControlMain"
        tbControlMain.SelectedIndex = 0
        tbControlMain.Size = New Size(1799, 708)
        tbControlMain.TabIndex = 6
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(BtnRefresh)
        TabPage1.Controls.Add(BtnViewDetails)
        TabPage1.Controls.Add(BtnBuyNow)
        TabPage1.Controls.Add(BtnAddToCart)
        TabPage1.Controls.Add(dgvProductDisplay)
        TabPage1.Controls.Add(pnlSearchBar)
        TabPage1.Font = New Font("Segoe UI", 12F)
        TabPage1.Location = New Point(4, 50)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1791, 654)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Shop"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' BtnViewDetails
        ' 
        BtnViewDetails.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        BtnViewDetails.Location = New Point(77, 375)
        BtnViewDetails.Name = "BtnViewDetails"
        BtnViewDetails.Size = New Size(190, 101)
        BtnViewDetails.TabIndex = 20
        BtnViewDetails.Text = "View Details"
        BtnViewDetails.UseVisualStyleBackColor = True
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(BtnRemoveAll)
        TabPage2.Controls.Add(BtnRefreshAll)
        TabPage2.Controls.Add(BtnRemoveAddToCart)
        TabPage2.Controls.Add(Panel3)
        TabPage2.Controls.Add(DataGridView1)
        TabPage2.Controls.Add(BtnPlaceAnOrder)
        TabPage2.Font = New Font("Segoe UI", 12F)
        TabPage2.Location = New Point(4, 50)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1791, 654)
        TabPage2.TabIndex = 1
        TabPage2.Text = "View Cart"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' BtnRemoveAll
        ' 
        BtnRemoveAll.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnRemoveAll.Location = New Point(77, 505)
        BtnRemoveAll.Name = "BtnRemoveAll"
        BtnRemoveAll.Size = New Size(190, 101)
        BtnRemoveAll.TabIndex = 22
        BtnRemoveAll.Text = "Remove All"
        BtnRemoveAll.UseVisualStyleBackColor = True
        ' 
        ' BtnRefreshAll
        ' 
        BtnRefreshAll.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        BtnRefreshAll.Location = New Point(77, 254)
        BtnRefreshAll.Name = "BtnRefreshAll"
        BtnRefreshAll.Size = New Size(190, 101)
        BtnRefreshAll.TabIndex = 20
        BtnRefreshAll.Text = "Refresh"
        BtnRefreshAll.UseVisualStyleBackColor = True
        ' 
        ' BtnRemoveAddToCart
        ' 
        BtnRemoveAddToCart.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        BtnRemoveAddToCart.Location = New Point(77, 375)
        BtnRemoveAddToCart.Name = "BtnRemoveAddToCart"
        BtnRemoveAddToCart.Size = New Size(190, 101)
        BtnRemoveAddToCart.TabIndex = 21
        BtnRemoveAddToCart.Text = "Remove "
        BtnRemoveAddToCart.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(cmbCategoryViewCart)
        Panel3.Controls.Add(txtBoxSearchBarViewCart)
        Panel3.Controls.Add(Label2)
        Panel3.Location = New Point(361, 19)
        Panel3.Margin = New Padding(2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(986, 64)
        Panel3.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(553, 15)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 28)
        Label1.TabIndex = 14
        Label1.Text = "Category:"
        ' 
        ' cmbCategoryViewCart
        ' 
        cmbCategoryViewCart.FormattingEnabled = True
        cmbCategoryViewCart.Items.AddRange(New Object() {"--Select--", "Cellphone", "Computer", "Laptop"})
        cmbCategoryViewCart.Location = New Point(661, 12)
        cmbCategoryViewCart.Margin = New Padding(2)
        cmbCategoryViewCart.Name = "cmbCategoryViewCart"
        cmbCategoryViewCart.Size = New Size(146, 36)
        cmbCategoryViewCart.TabIndex = 13
        ' 
        ' txtBoxSearchBarViewCart
        ' 
        txtBoxSearchBarViewCart.Location = New Point(103, 16)
        txtBoxSearchBarViewCart.Margin = New Padding(2)
        txtBoxSearchBarViewCart.Name = "txtBoxSearchBarViewCart"
        txtBoxSearchBarViewCart.Size = New Size(410, 34)
        txtBoxSearchBarViewCart.TabIndex = 12
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(12, 15)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 28)
        Label2.TabIndex = 11
        Label2.Text = "Search: "
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = SystemColors.AppWorkspace
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(361, 87)
        DataGridView1.Margin = New Padding(2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.RowTemplate.Height = 75
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(1330, 562)
        DataGridView1.TabIndex = 3
        ' 
        ' BtnPlaceAnOrder
        ' 
        BtnPlaceAnOrder.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        BtnPlaceAnOrder.Location = New Point(77, 132)
        BtnPlaceAnOrder.Name = "BtnPlaceAnOrder"
        BtnPlaceAnOrder.Size = New Size(190, 101)
        BtnPlaceAnOrder.TabIndex = 19
        BtnPlaceAnOrder.Text = "Place Order"
        BtnPlaceAnOrder.UseVisualStyleBackColor = True
        ' 
        ' FrmUserInterface
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(250))
        ClientSize = New Size(1902, 1033)
        Controls.Add(lblDeviceMarketSystem)
        Controls.Add(tbControlMain)
        Controls.Add(Panel2)
        Cursor = Cursors.Hand
        Name = "FrmUserInterface"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Shopipi"
        WindowState = FormWindowState.Maximized
        CType(dgvProductDisplay, ComponentModel.ISupportInitialize).EndInit()
        pnlSearchBar.ResumeLayout(False)
        pnlSearchBar.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        tbControlMain.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvProductDisplay As DataGridView
    Friend WithEvents BtnLogout As Button
    Friend WithEvents lblDeviceMarketSystem As Label
    Friend WithEvents pnlSearchBar As Panel
    Friend WithEvents lblCategory As Label
    Friend WithEvents cmbCategorySearch As ComboBox
    Friend WithEvents txtSearchBar As TextBox
    Friend WithEvents lblSearch As Label
    Friend WithEvents BtnRefresh As Button
    Friend WithEvents BtnBuyNow As Button
    Friend WithEvents BtnAddToCart As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblShowBalance As Label
    Friend WithEvents lblSetBalance As Label
    Friend WithEvents BtnBalance As Button
    Friend WithEvents txtUserBalance As TextBox
    Friend WithEvents lblWelcome As Label
    Friend WithEvents tbControlMain As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents BtnRemoveAddToCart As Button
    Friend WithEvents BtnRefreshAll As Button
    Friend WithEvents BtnPlaceAnOrder As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbCategoryViewCart As ComboBox
    Friend WithEvents txtBoxSearchBarViewCart As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnRemoveAll As Button
    Friend WithEvents BtnViewDetails As Button
End Class
