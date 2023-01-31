Imports MySql.Data.MySqlClient

Public Class 登入_Form
    Private Sub 登入_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    '打x鍵
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click

        Application.Exit()

    End Sub

    'when the textbox get the focus
    Private Sub TextBoxEM_Enter(sender As Object, e As EventArgs) Handles TextBoxEM.Enter

        Dim email As String = TextBoxEM.Text
        'check if the email is empty
        'check if the textbox contains the default value "email"
        If email.Trim().ToLower() = "email" Or email.Trim() = "" Then

            'clear the textbox
            TextBoxEM.Text = ""
            'change the textbox for color
            TextBoxEM.ForeColor = Color.Black

        End If

    End Sub

    'when the textbox get lost the focus
    Private Sub TextBoxEM_Leave(sender As Object, e As EventArgs) Handles TextBoxEM.Leave

        Dim email As String = TextBoxEM.Text
        'check if the email is empty
        'check if the textbox contains the default value "email"
        If email.Trim().ToLower() = "email" Or email.Trim() = "" Then

            'set the textbox text
            TextBoxEM.Text = "email"
            'change the textbox for color
            TextBoxEM.ForeColor = Color.DarkGray

        End If

    End Sub

    'when the textbox get the focus
    Private Sub TextBoxPassword_Enter(sender As Object, e As EventArgs) Handles TextBoxPassword.Enter

        Dim pass As String = TextBoxPassword.Text
        'check if the username is empty
        'check if the textbox contains the default value "username"
        If pass.Trim().ToLower() = "password" Or pass.Trim() = "" Then

            'clear the textbox
            TextBoxPassword.Text = ""
            'change the textbox for color
            TextBoxPassword.ForeColor = Color.Black
            'use system password
            TextBoxPassword.UseSystemPasswordChar = True

        End If

    End Sub

    'when the textbox get lost the focus
    Private Sub TextBoxPassword_Leave(sender As Object, e As EventArgs) Handles TextBoxPassword.Leave

        Dim pass As String = TextBoxPassword.Text
        'check if the username is empty
        'check if the textbox contains the default value "password"
        If pass.Trim().ToLower() = "password" Or pass.Trim() = "" Then

            'set the textbox text
            TextBoxPassword.Text = "password"
            'change the textbox for color
            TextBoxPassword.ForeColor = Color.DarkGray
            'set system password to the false
            TextBoxPassword.UseSystemPasswordChar = False

        End If

    End Sub

    'button login
    Private Sub Buttonlogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click

        'before the member can login we need to check if the textboxes are empty
        'if they contains the default values ( email & password )
        'check if this member exist in the database

        Dim conn As New MY_CONNECTION()
        Dim adapter As New MySqlDataAdapter()
        Dim table As New DataTable()
        Dim command As New MySqlCommand("SELECT  `email`, `password` FROM `member` WHERE `email` = @mail AND `password` = @pass", conn.getConnection())

        command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = TextBoxEM.Text
        command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = TextBoxPassword.Text


        If TextBoxEM.Text.Trim() = "" Or TextBoxEM.Text.Trim().ToLower() = "email" Then

            MessageBox.Show("請輸入註冊信箱", "Missing email", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf TextBoxPassword.Text.Trim() = "" Or TextBoxPassword.Text.Trim().ToLower() = "password" Then

            MessageBox.Show("請輸入密碼", "Missing Password", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            adapter.SelectCommand = command
            adapter.Fill(table)

            If table.Rows.Count > 0 Then

                MessageBox.Show("登入成功", "Login", MessageBoxButtons.OK)
                Me.Hide()
                Dim mainAppForm As New 主程式_Form()
                mainAppForm.Show()

            Else
                MessageBox.Show("此信箱 Or/And 密碼不存在", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        End If

    End Sub

    Private Sub LabelGoToSignUp_MouseEnter(sender As Object, e As EventArgs) Handles LabelGoToSignUp.MouseEnter

        LabelGoToSignUp.ForeColor = Color.Red

    End Sub

    Private Sub LabelGoToSignUp_MouseLeave(sender As Object, e As EventArgs) Handles LabelGoToSignUp.MouseLeave

        LabelGoToSignUp.ForeColor = Color.FromArgb(8, 61, 119)


    End Sub

    Private Sub LabelGoToSignUp_Click(sender As Object, e As EventArgs) Handles LabelGoToSignUp.Click

        Me.Hide()
        註冊_Form.Show()

    End Sub

    Private Sub CheckBoxShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxShowPass.CheckedChanged
        If CheckBoxShowPass.Checked Then
            TextBoxPassword.UseSystemPasswordChar = False
        Else
            If TextBoxPassword.Text = "password" Then
                TextBoxPassword.UseSystemPasswordChar = False
            Else
                TextBoxPassword.UseSystemPasswordChar = True
            End If
        End If
    End Sub
End Class
