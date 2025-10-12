Imports MySql.Data.MySqlClient

Public Class ProductDetails

    Public Property ProductName As String

    Private Sub ProductDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = ProductName

        DisplayDetailsOf(ProductName)
    End Sub


    '============== Show Product Detail Function ===================

    Public Sub DisplayDetailsOf(productName As String)
        Dim connectionString As String = "server=localhost;user=root;password=;database=information_management"

        Using con As New MySqlConnection(connectionString)

            con.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM Products WHERE product_name = @productName", con)
            cmd.Parameters.AddWithValue("@productName", productName)
            Using reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then

                    Label1.Text = reader("product_name").ToString()
                    Label2.Text = "₱HP" & Convert.ToDecimal(reader("price")).ToString("N2")
                    Label3.Text = reader("description").ToString()
                    Label4.Text = "Category: " & reader("category").ToString()
                    Label5.Text = "Stock: " & reader("stock").ToString()
                    Label6.Text = "Created Date: " & reader("created_date").ToString()
                    Dim imagePath As String = reader("image_path").ToString()
                    If Not String.IsNullOrEmpty(imagePath) AndAlso IO.File.Exists(imagePath) Then
                        PictureBox1.Image = Image.FromFile(imagePath)
                        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
                    Else
                        ' Handle missing image file
                        PictureBox1.Image = Nothing
                        MessageBox.Show("Image file not found: " & imagePath, "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                    MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using

        End Using


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub


End Class