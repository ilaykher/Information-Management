Imports MySql.Data.MySqlClient
Imports System.IO


Public Class FrmInterface


    ' --- Form Level Declarations ---
    Private connString As String = "server=localhost; user id=root; password=; database=information_management"
    Private conn As MySqlConnection ' Initialized later or in constructor
    Private dtProducts As New DataTable
    Private ImageList As New List(Of System.Drawing.Image)
    Private SelectedProductID As Integer = -1 ' To track the product being edited/deleted

    ' Constructor for safety (initializes conn)
    Public Sub New()
        InitializeComponent()
        conn = New MySqlConnection(connString)
    End Sub

    ' ===================================================================
    '                       COMMON UTILITY FUNCTIONS
    ' ===================================================================

    Private Sub UpdateUIState()
        ' Clears any selection in the DataGridView
        If dgvProductDisplay.Rows.Count > 0 Then
            dgvProductDisplay.ClearSelection()
        End If

        ' Ensures edit/remove buttons are disabled when no product is selected
        If SelectedProductID = -1 Then
            BtnEdit.Enabled = False
            BtnRemove.Enabled = False
            BtnSave.Text = "Save"
        Else
            BtnEdit.Enabled = True
            BtnRemove.Enabled = True
            BtnSave.Text = "Update"
        End If
    End Sub

    Sub ClearForm()
        ' Clear Product Fields
        txtProductName.Clear()
        cmbProductCategory.SelectedIndex = 0
        txtProductPrice.Clear()
        txtProductStock.Clear()
        txtProductDesc.Clear()

        ' Reset Search/Filter Fields
        txtSearchBar.Clear()
        cmbCategory.SelectedIndex = 0

        ' Reset Image Fields
        ImageList.Clear()
        pbPicture.Image = Nothing
        ' Reset State
        SelectedProductID = -1
        UpdateUIState()
        txtProductName.Focus()
    End Sub

    Function ValidateInput() As Boolean
        ' Consolidated validation
        If String.IsNullOrWhiteSpace(txtProductName.Text) OrElse
           String.IsNullOrWhiteSpace(txtProductPrice.Text) OrElse
           String.IsNullOrWhiteSpace(txtProductStock.Text) Then
            MessageBox.Show("Please fill in Name, Price, and Stock.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If Not IsNumeric(txtProductPrice.Text) OrElse Not IsNumeric(txtProductStock.Text) Then
            MessageBox.Show("Price and Stock must be valid numbers.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    ' ===================================================================
    '                          DATA OPERATIONS
    ' ===================================================================

    Private Sub LoadProducts(Optional searchKeyword As String = "", Optional filterCategory As String = "")
        Try
            If conn.State = ConnectionState.Open Then conn.Close()

            Dim query As String = "SELECT product_id, product_name, category, price, stock, description, image_path FROM products "
            Dim whereClause As New List(Of String)

            ' --- 1. BUILD WHERE CLAUSES (Search across name, category, price, stock) ---
            If Not String.IsNullOrWhiteSpace(searchKeyword) Then
                whereClause.Add("(product_name LIKE @keyword OR category LIKE @keyword OR price LIKE @keyword OR stock LIKE @keyword)")
            End If

            ' Category filter is independent
            If Not String.IsNullOrWhiteSpace(filterCategory) AndAlso filterCategory <> "--Select--" Then
                whereClause.Add("category = @category")
            End If

            If whereClause.Count > 0 Then
                query &= " WHERE " & String.Join(" AND ", whereClause)
            End If

            query &= " ORDER BY product_id DESC"

            Using da As New MySqlDataAdapter(query, conn)
                ' 2. ADD PARAMETERS SAFELY
                If Not String.IsNullOrWhiteSpace(searchKeyword) Then
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & searchKeyword & "%")
                End If
                If Not String.IsNullOrWhiteSpace(filterCategory) AndAlso filterCategory <> "--Select--" Then
                    da.SelectCommand.Parameters.AddWithValue("@category", filterCategory)
                End If

                dtProducts.Clear()
                ' Ensure the IMAGE OBJECT column exists
                If Not dtProducts.Columns.Contains("Product_Image") Then
                    dtProducts.Columns.Add("Product_Image", GetType(System.Drawing.Image))
                End If

                conn.Open()
                da.Fill(dtProducts)
            End Using

            ' 3. Load image files into the 'Product_Image' column
            For Each row As DataRow In dtProducts.Rows
                Dim imagePath As Object = row("image_path")
                If imagePath IsNot DBNull.Value AndAlso Not String.IsNullOrWhiteSpace(imagePath.ToString()) AndAlso File.Exists(imagePath.ToString()) Then
                    row("Product_Image") = System.Drawing.Image.FromFile(imagePath.ToString())
                End If
            Next

            dgvProductDisplay.DataSource = dtProducts

            ' 4. HIDE TECHNICAL COLUMNS
            If dgvProductDisplay.Columns.Contains("product_id") Then
                dgvProductDisplay.Columns("product_id").Visible = False
            End If
            If dgvProductDisplay.Columns.Contains("image_path") Then
                dgvProductDisplay.Columns("image_path").Visible = False
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' ===================================================================
    '                             EVENT HANDLERS
    ' ===================================================================

    Private Sub FrmInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProducts()
        UpdateUIState() ' Initial clear of selection and button states

        ' --- GRID VISUAL CONFIGURATION ---
        dgvProductDisplay.RowTemplate.Height = 150
        If dgvProductDisplay.Columns.Contains("Product_Image") Then
            Dim imgCol As DataGridViewImageColumn = CType(dgvProductDisplay.Columns("Product_Image"), DataGridViewImageColumn)
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom
            dgvProductDisplay.Columns("Product_Image").Width = 150
        End If

        ' --- TEXT ALIGNMENT ---
        Dim columnsToCenter() As String = {"product_name", "category", "stock", "price"}
        For Each columnName As String In columnsToCenter
            If dgvProductDisplay.Columns.Contains(columnName) Then
                dgvProductDisplay.Columns(columnName).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvProductDisplay.Columns(columnName).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            End If
        Next
    End Sub

    Private Sub dgvProductDisplay_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductDisplay.CellClick
        If e.RowIndex < 0 Then Return

        Dim row As DataGridViewRow = dgvProductDisplay.Rows(e.RowIndex)

        ' --- 1. DECLARE AND GET VALUES SAFELY ---
        Dim productIDValue As Object = row.Cells("product_id").Value
        Dim imageCellValue As Object = row.Cells("Product_Image").Value
        Dim imagePathValue As Object = row.Cells("image_path").Value

        ' --- 2. Populate Hidden/Tracker Variables ---
        SelectedProductID = CInt(productIDValue)

        ' --- 3. Populate TextBoxes ---
        txtProductName.Text = row.Cells("product_name").Value.ToString()
        cmbProductCategory.Text = row.Cells("category").Value.ToString()
        txtProductPrice.Text = row.Cells("price").Value.ToString()
        txtProductStock.Text = row.Cells("stock").Value.ToString()
        txtProductDesc.Text = row.Cells("description").Value.ToString()

        ' --- 4. Load Image (Using TryCast for safety) ---
        ImageList.Clear()
        pbPicture.Image = Nothing ' Always clear first

        ' *** FIX: Use TryCast to safely attempt the conversion ***
        Dim loadedImage As System.Drawing.Image = TryCast(imageCellValue, System.Drawing.Image)

        If loadedImage IsNot Nothing Then
            ' The cast succeeded, the product has an image
            pbPicture.Image = loadedImage

            ' Re-store the image and its path for update logic
            If imagePathValue IsNot DBNull.Value Then
                ' Clone the image to prevent file handle issues and set the Tag
                ' We must clone the image because we are modifying its Tag property.
                Using tempImg As New System.Drawing.Bitmap(loadedImage)
                    tempImg.Tag = imagePathValue.ToString()
                    ImageList.Add(tempImg)
                End Using
            End If
        End If
        ' -------------------------------------------------------------

        ' --- 5. Update Button State ---
        UpdateUIState()
    End Sub

    ' --- AUTOMATIC SEARCH TRIGGERS ---
    Private Sub txtSearchBar_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBar.TextChanged
        Dim keyword As String = txtSearchBar.Text.Trim()
        Dim category As String = cmbCategory.Text
        LoadProducts(keyword, category)
        UpdateUIState() ' Clears selection after search
    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged
        Dim keyword As String = txtSearchBar.Text.Trim()
        Dim category As String = cmbCategory.Text
        LoadProducts(keyword, category)
        UpdateUIState() ' Clears selection after filter
    End Sub
    ' ----------------------------------


    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click, BtnEdit.Click
        If Not ValidateInput() Then Return

        Dim sql As String = ""

        ' Use SelectedProductID to determine INSERT or UPDATE
        If SelectedProductID = -1 Then
            sql = "INSERT INTO products (product_name, category, price, stock, description, image_path) VALUES (@name, @category, @price, @stock, @desc, @path)"
        Else
            sql = "UPDATE products SET product_name=@name, category=@category, price=@price, stock=@stock, description=@desc, image_path=@path WHERE product_id=@id"
        End If

        Try
            conn.Open()
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@name", txtProductName.Text)
                cmd.Parameters.AddWithValue("@category", cmbProductCategory.Text)
                cmd.Parameters.AddWithValue("@price", CDec(txtProductPrice.Text))
                cmd.Parameters.AddWithValue("@stock", CInt(txtProductStock.Text))
                cmd.Parameters.AddWithValue("@desc", txtProductDesc.Text)

                ' Get image path from Tag property of the stored image
                Dim imgPath As String = If(ImageList.Count > 0 AndAlso ImageList(0).Tag IsNot Nothing, ImageList(0).Tag.ToString(), "")
                cmd.Parameters.AddWithValue("@path", imgPath)

                If SelectedProductID <> -1 Then
                    cmd.Parameters.AddWithValue("@id", SelectedProductID)
                End If

                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Product " & If(SelectedProductID = -1, "saved", "updated") & " successfully!", "Success")
            LoadProducts()
            ClearForm()

        Catch ex As Exception
            MessageBox.Show("Error processing product: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        If SelectedProductID = -1 Then
            MessageBox.Show("No product selected to remove.", "Selection Required")
            Return
        End If

        If MessageBox.Show("Are you sure you want to permanently delete this product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Return

        Dim sql As String = "DELETE FROM products WHERE product_id=@id"

        Try
            conn.Open()
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id", SelectedProductID)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Product removed successfully!", "Success")
            LoadProducts()
            ClearForm()

        Catch ex As Exception
            MessageBox.Show("Error removing product: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        ClearForm()
        LoadProducts()
        UpdateUIState()
        MessageBox.Show("Form cleared and data grid refreshed.", "Ready for New Entry", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BtnUploadIMG_Click(sender As Object, e As EventArgs) Handles BtnUploadIMG.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png"
            ofd.Multiselect = False

            If ofd.ShowDialog() = DialogResult.OK Then
                Try
                    ' 1. Load the image into the PictureBox
                    pbPicture.Image = System.Drawing.Image.FromFile(ofd.FileName)
                    pbPicture.SizeMode = PictureBoxSizeMode.Zoom

                    ' 2. Store the file path in the ImageList item's Tag property
                    ImageList.Clear()
                    ' Create a copy of the image to keep the file handle free
                    Using tempImg As System.Drawing.Image = System.Drawing.Image.FromFile(ofd.FileName)
                        Dim loadedImage As New System.Drawing.Bitmap(tempImg)
                        loadedImage.Tag = ofd.FileName
                        ImageList.Add(loadedImage)
                    End Using

                Catch ex As Exception
                    MessageBox.Show("Error loading image: " & ex.Message)
                End Try
            End If
        End Using
    End Sub

    Private Sub BtnRemoveIMG_Click(sender As Object, e As EventArgs) Handles BtnRemoveIMG.Click
        If pbPicture.Image IsNot Nothing Then
            pbPicture.Image = Nothing ' Clear the display
            ImageList.Clear()       ' Clear the stored path/image list
        End If
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        ' 1. Ask the user for confirmation
        Dim result As DialogResult = MessageBox.Show(
        "Are you sure you want to log out?",
        "Confirm Logout",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question)

        ' Check if the user clicked 'Yes'
        If result = DialogResult.Yes Then

            ' 2. Hide the current main form
            Me.Hide()

            ' 3. Create a new instance of the login form and show it
            ' Assuming your login form is named FrmLogin
            Dim loginForm As New FrmLogin()
            loginForm.Show()

        End If
    End Sub


End Class