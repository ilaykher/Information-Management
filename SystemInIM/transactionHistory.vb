Public Class transactionHistory
    Private Sub transactionHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'When this button is clicked the datagrid view shows pernding orderrs instead
        Button1.Width = 162
        Button2.Width = 200

        Label1.Text = "Pending Orders"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'When this button is clicked the datagrid view shows transaction History instead
        Button1.Width = 200
        Button2.Width = 162

        Label1.Text = "Transaction History"
    End Sub
End Class