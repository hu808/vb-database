Imports System.IO
Imports MySql.Data.MySqlClient

Public Class 註冊_Form
    Private Sub 註冊_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click

        Application.Exit()

    End Sub

    Private Sub TextBoxRealname_Leave(sender As Object, e As EventArgs) Handles TextBoxRealname.Leave

        If TextBoxRealname.Text = "" Then

            LabelRN.ForeColor = Color.Red
        Else
            LabelRN.ForeColor = Color.White

        End If

    End Sub

    Private Sub TextBoxName2_Leave(sender As Object, e As EventArgs) Handles TextBoxName2.Leave

        If TextBoxName2.Text = "" Then

            LabelN2.ForeColor = Color.Red
        Else
            LabelN2.ForeColor = Color.White

        End If

    End Sub

    Private Sub TextBoxPhone_Leave(sender As Object, e As EventArgs) Handles TextBoxPhone.Leave

        If TextBoxPhone.Text = "" Then

            LabelPH.ForeColor = Color.Red
        Else
            LabelPH.ForeColor = Color.White

        End If

    End Sub

    Private Sub TextBoxEmail_Leave(sender As Object, e As EventArgs) Handles TextBoxEmail.Leave

        If TextBoxEmail.Text = "" Then

            LabelEM.ForeColor = Color.Red
        Else
            LabelEM.ForeColor = Color.White

        End If

    End Sub

    Private Sub TextBoxAddress_Leave(sender As Object, e As EventArgs) Handles TextBoxAddress.Leave

        If TextBoxAddress.Text = "" Then

            LabelAD.ForeColor = Color.Red
        Else
            LabelAD.ForeColor = Color.White

        End If

    End Sub

    Private Sub TextBoxPassword_Leave(sender As Object, e As EventArgs) Handles TextBoxPassword.Leave

        If TextBoxPassword.Text = "" Then

            LabelPass1.ForeColor = Color.Red
        Else
            LabelPass1.ForeColor = Color.White

        End If

    End Sub

    Private Sub TextBoxConfirmPassword_Leave(sender As Object, e As EventArgs) Handles TextBoxConfirmPassword.Leave

        If TextBoxConfirmPassword.Text = "" Then

            LabelPass2.ForeColor = Color.Red
        Else
            LabelPass2.ForeColor = Color.White

        End If

    End Sub

    Private Sub ButtonRegister_Click(sender As Object, e As EventArgs) Handles ButtonRegister.Click

        ' check if fields are empty
        ' check if the password = the confirm password
        ' check if the ussername already exists

        ' get textboxes values
        Dim member As New MEMBER()
        Dim rname As String = TextBoxRealname.Text
        Dim name2 As String = TextBoxName2.Text
        Dim email As String = TextBoxEmail.Text
        Dim phone As String = TextBoxPhone.Text
        Dim password As String = TextBoxPassword.Text
        Dim cpassword As String = TextBoxConfirmPassword.Text
        Dim address As String = TextBoxAddress.Text
        Dim birth As Date = DateTimePickerBirth.Value
        Dim pic As New MemoryStream



        '檢查生日是否正確
        Dim born_year As Integer = DateTimePickerBirth.Value.Year
        Dim this_year As Integer = Date.Now.Year
        Dim born_month As Integer = DateTimePickerBirth.Value.Month
        Dim this_month As Integer = Date.Now.Month
        Dim born_date As Integer = DateTimePickerBirth.Value.Day
        Dim this_date As Integer = Date.Now.Day

        '驗證
        If PictureBoxUserPicture.Image Is Nothing Or address.Trim() = "" Or rname.Trim() = "" Or name2.Trim() = "" Or phone.Trim() = "" Or email.Trim() = "" Or password.Trim() = "" Then

            MessageBox.Show("有一個或多個資料未填入", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        ElseIf Not String.Equals(password, cpassword) Then

            MessageBox.Show("請注意!!!兩次輸入的密碼不一致，請重新輸入", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf EmailExist(email) Then

            MessageBox.Show("這個信箱已註冊,請登入或選擇另一個信箱", "Duplicate email", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TextBoxEmail.Text = ""
            LabelEM.ForeColor = Color.Red

        ElseIf Birthday(born_year, born_month, born_date) Then

            MsgBox("你這時還未出生喔~ 親~", MsgBoxStyle.Information, "Error")

            Else
                PictureBoxUserPicture.Image.Save(pic, PictureBoxUserPicture.Image.RawFormat)
                If member.insertMember(rname, name2, email, phone, password, cpassword, address, birth, pic) Then

                    MessageBox.Show("註冊成功，請前往登入", "User Added", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else

                    MessageBox.Show("發生錯誤，請重新嘗試", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If

            End If

    End Sub

    ' create a function to 檢查生日是否正確
    Public Function Birthday(ByVal born_year As String, ByVal born_month As String, ByVal born_date As String) As Boolean

        Dim this_year As Integer = Date.Now.Year
        Dim this_month As Integer = Date.Now.Month
        Dim this_date As Integer = Date.Now.Day

        If this_year - born_year < 0 Then

            Return True

        ElseIf this_year - born_year > 0 Then

            Return False

        ElseIf this_year - born_year = 0 Then

            If this_month - born_month < 0 Then

                Return True

            ElseIf this_month - born_month > 0 Then

                Return False

            Else

                If this_date - born_date < 0 Then

                    Return True
                Else
                    Return False
                End If
            End If
        End If
        Return False
    End Function

    ' create a function to check if the username already exists
    Public Function EmailExist(ByVal email As String) As Boolean

        Dim con As New MY_CONNECTION()
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand("SELECT * FROM `member` WHERE `email` = @mail", con.getConnection())
        command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = email

        adapter.SelectCommand = command
        adapter.Fill(table)

        ' if the email exist return true
        If table.Rows.Count > 0 Then

            Return True

            ' if not return false
        Else
            Return False

        End If

    End Function

    Private Sub ButtonClose_MouseEnter(sender As Object, e As EventArgs) Handles ButtonClose.MouseEnter

        ButtonClose.ForeColor = Color.White

    End Sub

    Private Sub ButtonClose_MouseLeave(sender As Object, e As EventArgs) Handles ButtonClose.MouseLeave

        ButtonClose.ForeColor = Color.Black

    End Sub

    Private Sub LabelGoToSignIn_MouseEnter(sender As Object, e As EventArgs) Handles LabelGoToSignIn.MouseEnter

        LabelGoToSignIn.ForeColor = Color.Red

    End Sub

    Private Sub LabelGoToSignUp_MouseLeave(sender As Object, e As EventArgs) Handles LabelGoToSignIn.MouseLeave

        LabelGoToSignIn.ForeColor = Color.FromArgb(8, 61, 119)

    End Sub

    Private Sub LabelGoToSignIn_Click(sender As Object, e As EventArgs) Handles LabelGoToSignIn.Click

        Me.Hide()
        登入_Form.Show()

    End Sub

    Private Sub CheckBoxShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxShowPass.CheckedChanged
        If CheckBoxShowPass.Checked Then
            TextBoxPassword.UseSystemPasswordChar = False
            TextBoxConfirmPassword.UseSystemPasswordChar = False
        Else
            If TextBoxPassword.Text = "" And TextBoxConfirmPassword.Text = "" Then
                TextBoxPassword.UseSystemPasswordChar = False
                TextBoxConfirmPassword.UseSystemPasswordChar = False
            Else
                TextBoxPassword.UseSystemPasswordChar = True
                TextBoxConfirmPassword.UseSystemPasswordChar = True
            End If
        End If
    End Sub

    Private Sub TextBoxPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPhone.KeyPress

        '設定只能輸入數字
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then

            e.Handled = True

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim opf As New OpenFileDialog()
        opf.Filter = "Select Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then

            PictureBoxUserPicture.Image = Image.FromFile(opf.FileName)

        End If
    End Sub
End Class