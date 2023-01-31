Imports MySql.Data.MySqlClient

Public Class PRODUCT

    Dim con As New MY_CONNECTION

    Public Function getProduct() As DataTable

        Dim command As New MySqlCommand("SELECT * FROM `product`")
        command.Connection = con.getConnection

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        Return table

    End Function

End Class
