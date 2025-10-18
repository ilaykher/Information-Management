Public Class modeOfPayment

    Public Property ProductID As Integer
    Public Property ProductName As String
    Public Property ProductPrice As Decimal
    Public Property ProductQuantity As Integer
    Public Property ProductDescription As String

    ' For multi-item usage (from Cart) - optional
    Private ReadOnly _selectedItems As List(Of (ProductName As String, Price As Decimal, Quantity As Integer))

    ' ---------- Parameterless constructor (required by Designer) ----------
    Public Sub New()
        InitializeComponent()
        ' any other init here
    End Sub

    ' ---------- Constructor that accepts a list (optional) ----------
    Public Sub New(items As List(Of (ProductName As String, Price As Decimal, Quantity As Integer)))
        ' Call the parameterless ctor so InitializeComponent runs
        Me.New()
        _selectedItems = items
    End Sub

    '============== At Load ===================
    Private Sub modeOfPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.Items.Add("  Cash on Delivery   ")
        ComboBox1.Items.Add("  Online Payment   ")

        ComboBox1.SelectedIndex = 0

        ' ===== Show items in Label1 =====
        If _selectedItems IsNot Nothing AndAlso _selectedItems.Count > 0 Then
            Dim displayText As New Text.StringBuilder()
            displayText.AppendLine(New String("-"c, 30))

            For Each item In _selectedItems
                displayText.AppendLine($"Product: {item.ProductName}")
                displayText.AppendLine($"Price: ₱{item.Price:N2}")
                displayText.AppendLine($"Quantity: {item.Quantity}")
                displayText.AppendLine(New String("-"c, 30))
            Next

            Label3.Text = displayText.ToString()
        ElseIf Not String.IsNullOrEmpty(ProductName) Then
            ' Single product (if opened from ProductDetails)
            Label3.Text = $"Product: {ProductName}{Environment.NewLine}" &
                      $"Price: ₱{ProductPrice:N2}{Environment.NewLine}" &
                      $"Quantity: {ProductQuantity}"
        Else
            Label3.Text = "No products selected."
        End If
    End Sub

    Private Sub modeOfpayment_close(sender As Object, e As EventArgs) Handles MyBase.Closed
        paymentIsOpened = False
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
End Class