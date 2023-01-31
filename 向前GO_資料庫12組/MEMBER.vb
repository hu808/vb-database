Imports System.IO
Imports MySql.Data.MySqlClient

Public Class MEMBER

    Dim con As New MY_CONNECTION

    Public Function insertMember(ByVal rname As String, ByVal name2 As String, ByVal email As String, ByVal phone As String, ByVal password As String, ByVal cpassword As String, ByVal address As String, ByVal birth As Date, ByVal picture As MemoryStream) As Boolean

        Dim command As New MySqlCommand("INSERT INTO `member`(`real name`, `nickname`, `email`, `phone`, `password`,`Address`,`birth`,`pic`) VALUES (@rn, @n2, @mail, @ph, @pass, @ads, @birth, @pic)", con.getConnection)

        command.Parameters.Add("@rn", MySqlDbType.VarChar).Value = rname
        command.Parameters.Add("@n2", MySqlDbType.VarChar).Value = name2
        command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = email
        command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone
        command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password
        command.Parameters.Add("@ads", MySqlDbType.VarChar).Value = address
        command.Parameters.Add("@birth", MySqlDbType.DateTime).Value = birth
        command.Parameters.Add("@pic", MySqlDbType.Blob).Value = picture.ToArray()

        con.openConnection()

        If command.ExecuteNonQuery() = 1 Then

            Return True

        Else

            Return False

        End If

        con.closeConnection()

    End Function

    Function getMember() As DataTable

        Dim command As New MySqlCommand("SELECT * FROM `member` WHERE `email` = @mail")
        command.Connection = con.getConnection
        command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = 登入_Form.TextBoxEM.Text

        Dim adapter1 As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter1.Fill(table)

        Return table

    End Function

    Function insertHope(ByVal mid As String, ByVal name As String, ByVal hprice As String) As Boolean

        Dim command As New MySqlCommand("INSERT INTO `hope`(`mID`, `name`, `hPrice`) VALUES (@mid,@n,@hp)", con.getConnection)

        command.Parameters.Add("@mid", MySqlDbType.VarChar).Value = mid
        command.Parameters.Add("@n", MySqlDbType.VarChar).Value = name
        command.Parameters.Add("@hp", MySqlDbType.VarChar).Value = hprice

        con.openConnection()

        If command.ExecuteNonQuery() = 1 Then

            Return True

        Else

            Return False

        End If

        con.closeConnection()

    End Function

    Public Function updateMember(ByVal email As String, ByVal name2 As String, ByVal phone As String, ByVal password As String, ByVal address As String, ByVal birth As Date, ByVal picture As MemoryStream) As Boolean

        Dim command As New MySqlCommand("UPDATE `member` SET `nickname`= @n2,`password`=@pass,`birth`=@birth,`phone`=@ph,`Address`=@ads,`pic`=@pic WHERE email = @mail", con.getConnection)

        command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = email
        command.Parameters.Add("@n2", MySqlDbType.VarChar).Value = name2
        command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone
        command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password
        command.Parameters.Add("@ads", MySqlDbType.VarChar).Value = address
        command.Parameters.Add("@birth", MySqlDbType.DateTime).Value = birth
        command.Parameters.Add("@pic", MySqlDbType.Blob).Value = picture.ToArray()

        con.openConnection()

        If command.ExecuteNonQuery() = 1 Then

            Return True

        Else

            Return False

        End If

        con.closeConnection()

    End Function

End Class
