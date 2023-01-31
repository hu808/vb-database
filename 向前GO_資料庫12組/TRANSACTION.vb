Imports MySql.Data.MySqlClient

Public Class TRANSACTION

    Dim con As New MY_CONNECTION

    Public Function insertTransaction(ByVal mid As String, ByVal pno As String, ByVal amount As String, ByVal saleprice As String, ByVal tDate As DateTime, ByVal method As String, ByVal deliver As String) As Boolean

        Dim command As New MySqlCommand("INSERT INTO `transaction`(`mID`, `pNo`, `amount`, `salePrice`,`tDate`, `method`,`deliver`) VALUES (@mid, @pno, @amt, @sp,@td,@mtd,@del)", con.getConnection)

        command.Parameters.Add("@mid", MySqlDbType.VarChar).Value = mid
        command.Parameters.Add("@pno", MySqlDbType.VarChar).Value = pno
        command.Parameters.Add("@amt", MySqlDbType.VarChar).Value = amount
        command.Parameters.Add("@sp", MySqlDbType.VarChar).Value = saleprice
        command.Parameters.Add("@td", MySqlDbType.DateTime).Value = tDate
        command.Parameters.Add("@mtd", MySqlDbType.VarChar).Value = method
        command.Parameters.Add("@del", MySqlDbType.VarChar).Value = deliver


        con.openConnection()

        If command.ExecuteNonQuery() = 1 Then

            Return True

        Else

            Return False

        End If

        con.closeConnection()

    End Function

    Function getmProduct() As DataTable

        Dim command As New MySqlCommand("SELECT `pNo`, `pName`, `price`, `pic` FROM `product` WHERE `pNo` = @pNo")
        command.Connection = con.getConnection
        command.Parameters.Add("@pNo", MySqlDbType.VarChar).Value = 商品清單_Form.LabelpNo.Text

        Dim adapter1 As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter1.Fill(table)

        Return table

    End Function

    Function getmTransaction() As DataTable

        Dim command As New MySqlCommand("SELECT `tID`, `pName`, `amount`, `salePrice`, `tDate` FROM `transaction`,`product`,`member` WHERE member.mID = transaction.mID AND product.pNo = transaction.pNo AND email = @mail")
        command.Connection = con.getConnection

        command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = 登入_Form.TextBoxEM.Text

        Dim adapter1 As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter1.Fill(table)

        Return table

    End Function

    Public Function deleteTransaction(ByVal tid As String) As Boolean

        Dim command As New MySqlCommand("DELETE FROM `transaction` WHERE `tID` = @tid", con.getConnection)

        command.Parameters.Add("@tid", MySqlDbType.VarChar).Value = tid


        con.openConnection()

        If command.ExecuteNonQuery() = 1 Then

            Return True

        Else

            Return False

        End If

        con.closeConnection()

    End Function

End Class
