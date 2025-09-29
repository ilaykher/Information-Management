Public Class FrmInterface
    Private Sub BtnAddProduct_Click(sender As Object, e As EventArgs) Handles BtnAddProduct.Click
        Dim AddProduct As New FrmAdminInsertPanel()
        AddProduct.Show()
    End Sub

    Private Sub BtnUpdateProduct_Click(sender As Object, e As EventArgs) Handles BtnUpdateProduct.Click
        Dim updateProduct As New FrmAdminUpdatePanel()
        updateProduct.Show()
    End Sub
End Class