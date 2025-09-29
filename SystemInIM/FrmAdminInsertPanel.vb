Imports MySql.Data.MySqlClient

Public Class FrmAdminInsertPanel
    Private Sub BtnInsertAProduct_Click(sender As Object, e As EventArgs) Handles BtnInsertAProduct.Click
        Dim connStr As String = "Server=localhost;Database=information_management;Uid=root;Pwd=;"

        Using conn As New MySqlConnection(connStr)

            Try


            Catch ex As Exception

            End Try
        End Using
    End Sub
End Class