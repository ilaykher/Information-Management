Imports MySql.Data.MySqlClient

Public Class ViewCart
    Private Sub ViewCart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' --------------------Populate combobox :D

        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.Items.Add("  Search By Name:")
        ComboBox1.Items.Add("  Search By Category")

        ComboBox1.SelectedIndex = 0
        LoadCart(Globals.LoggedInUserId)
    End Sub

    Public Sub LoadCart(userid As Integer)

        '===================CART DESIGN========================


        With DataGridView1
            ' checkbox column
            Dim chkColumn As New DataGridViewCheckBoxColumn()
            chkColumn.HeaderText = "Select"
            chkColumn.Name = "chkSelect"
            chkColumn.Width = 50
            DataGridView1.Columns.Insert(0, chkColumn)

            'picture column
            Dim imgColumn As New DataGridViewImageColumn()
            imgColumn.HeaderText = "Image"
            imgColumn.Name = "imgProduct"
            imgColumn.Width = 100
            DataGridView1.Columns.Insert(1, imgColumn)

            '===design===
            .EnableHeadersVisualStyles = False
            .GridColor = Color.OldLace
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            .RowHeadersVisible = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .AllowUserToAddRows = False

            ' === Fonts ===
            .DefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Regular)
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)

            'row 
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            .RowTemplate.Height = 80

        End With

        '=========================================


        Dim connectionString As String = "server=localhost;user=root;password=;database=information_management"

        Dim con As New MySqlConnection(connectionString)
        con.Open()

        Using cmd As New MySqlCommand("SELECT product_name, price, quantity FROM cart WHERE user_id = @userid", con)
            cmd.Parameters.AddWithValue("@userid", userid)

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            DataGridView1.DataSource = dt
        End Using

        'make each row uneditable unless its chkselect row'
        For Each col As DataGridViewColumn In DataGridView1.Columns
            If col.Name = "chkSelect" Then
                col.ReadOnly = False
            Else
                col.ReadOnly = True
            End If
        Next


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class