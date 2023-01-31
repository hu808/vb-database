Public Class 許願池_Form

    Private Sub 許願池_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ButtonMy檔案.Hide()
        ButtonMy紀錄.Hide()
        Dim member As New MEMBER()
        DataGridView1.ReadOnly = True
        DataGridView1.DataSource = member.getMember()
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.Visible = False
        Labeluser.Visible = False

        Labeluser.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()

    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click

        Application.Exit()

    End Sub

    Private Sub ButtonMainGo_MouseClick(sender As Object, e As MouseEventArgs) Handles ButtonMainGo.MouseClick

        ButtonMainGo.FlatAppearance.BorderSize = 2
        ButtonWish.FlatAppearance.BorderSize = 0
        ButtonMy.FlatAppearance.BorderSize = 0
        Me.Hide()
        Dim mForm As New 主程式_Form()
        mForm.Show()

    End Sub

    Private Sub ButtonWish_Click(sender As Object, e As EventArgs) Handles ButtonWish.Click

        ButtonMainGo.FlatAppearance.BorderSize = 0
        ButtonWish.FlatAppearance.BorderSize = 2
        ButtonMy.FlatAppearance.BorderSize = 0

    End Sub

    Private Sub ButtonMy_Click(sender As Object, e As EventArgs) Handles ButtonMy.Click

        ButtonMainGo.FlatAppearance.BorderSize = 0
        ButtonWish.FlatAppearance.BorderSize = 0
        ButtonMy.FlatAppearance.BorderSize = 2
        If ButtonMy檔案.Visible = True Then
            ButtonMy檔案.Hide()
            ButtonMy紀錄.Hide()
        Else
            ButtonMy檔案.Show()
            ButtonMy紀錄.Show()
        End If

    End Sub

    Private Sub ButtonMy紀錄_Click(sender As Object, e As EventArgs) Handles ButtonMy紀錄.Click

        Me.Hide()
        Dim mrForm As New 我的紀錄_Form()
        我的紀錄_Form.Show()

    End Sub

    Private Sub ButtonMy檔案_Click(sender As Object, e As EventArgs) Handles ButtonMy檔案.Click

        Me.Hide()
        Dim mdForm As New 我的檔案_Form()
        mdForm.Show()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        ButtonMy檔案.Hide()
        ButtonMy紀錄.Hide()
        ButtonMainGo.FlatAppearance.BorderSize = 0
        ButtonWish.FlatAppearance.BorderSize = 2
        ButtonMy.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBoxProduct1_Enter(sender As Object, e As EventArgs) Handles TextBoxProduct1.Enter

        Dim pname As String = TextBoxProduct1.Text
        'check if the pname is empty
        'check if the textbox contains the default value "商品名稱"
        If pname.Trim().ToLower() = "商品名稱" Or pname.Trim() = "" Then

            'clear the textbox
            TextBoxProduct1.Text = ""
            'change the textbox for color
            TextBoxProduct1.ForeColor = Color.Black

        End If

    End Sub

    Private Sub TextBoxProduct1_Leave(sender As Object, e As EventArgs) Handles TextBoxProduct1.Leave

        Dim pname As String = TextBoxProduct1.Text
        'check if the pname is empty
        'check if the textbox contains the default value "商品名稱"
        If pname.Trim().ToLower() = "商品名稱" Or pname.Trim() = "" Then

            'clear the textbox
            TextBoxProduct1.Text = "商品名稱"
            'change the textbox for color
            TextBoxProduct1.ForeColor = Color.DarkGray

        End If

    End Sub

    Private Sub TextBoxPrice1_Enter(sender As Object, e As EventArgs) Handles TextBoxPrice1.Enter

        Dim hp As String = TextBoxPrice1.Text
        'check if the pname is empty
        'check if the textbox contains the default value "$ 期望價格"
        If hp.Trim().ToLower() = "$ 期望價格" Or hp.Trim() = "" Then

            'clear the textbox
            TextBoxPrice1.Text = ""
            'change the textbox for color
            TextBoxPrice1.ForeColor = Color.Black

        End If

    End Sub

    Private Sub TextBoxPrice1_Leave(sender As Object, e As EventArgs) Handles TextBoxPrice1.Leave

        Dim hp As String = TextBoxPrice1.Text
        'check if the pname is empty
        'check if the textbox contains the default value "$ 期望價格"
        If hp.Trim().ToLower() = "$ 期望價格" Or hp.Trim() = "" Then

            'clear the textbox
            TextBoxPrice1.Text = "$ 期望價格"
            'change the textbox for color
            TextBoxPrice1.ForeColor = Color.DarkGray

        End If

    End Sub

    Private Sub ButtonBuy1_Click(sender As Object, e As EventArgs) Handles ButtonBuy1.Click

        Dim mid As String = DataGridView1.CurrentRow.Cells(0).Value.ToString()

        Dim member As New MEMBER()
        Dim name As String = TextBoxProduct1.Text
        Dim hprice As String = TextBoxPrice1.Text

        If name.Trim() = "" Or hprice.Trim() = "" Or name.Trim() = "商品名稱" Or hprice.Trim() = "$ 期望價格" Then

            MessageBox.Show("有資料未填入", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        Else

            If member.insertHope(mid, name, hprice) Then

                MessageBox.Show("完成許願", "Finish", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else

                MessageBox.Show("發生錯誤，請重新嘗試", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        End If

    End Sub
End Class