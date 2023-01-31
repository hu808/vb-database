Imports System.IO
Public Class 我的檔案_Form

    Private Sub 我的檔案_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ButtonMy檔案.Hide()
        ButtonMy紀錄.Hide()

        Dim member As New MEMBER()

        DataGridView1.ReadOnly = True
        'Dim picCol As New DataGridViewImageColumn()
        DataGridView1.RowTemplate.Height = 50
        DataGridView1.DataSource = member.getMember()
        ' picCol = DataGridView1.Columns(9)
        'picCol.ImageLayout = DataGridViewImageCellLayout.Stretch
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.Visible = False

        TextBoxName.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        TextBoxName2.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        TextBoxPass.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        DateTimePicker1.Value = DataGridView1.CurrentRow.Cells(4).Value
        TextBoxPhone.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
        TextBoxEM.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString()
        TextBoxAddress.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString()
        LabelCredit.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString()

        Dim pic As Byte()
        pic = DataGridView1.CurrentRow.Cells(8).Value
        Dim picture As New MemoryStream(pic)
        PictureBoxMemberImage.Image = Image.FromStream(picture)

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
        Me.Hide()
        Dim wForm As New 許願池_Form()
        wForm.Show()

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
        mrForm.Show()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        ButtonMy檔案.Hide()
        ButtonMy紀錄.Hide()
        ButtonMainGo.FlatAppearance.BorderSize = 0
        ButtonWish.FlatAppearance.BorderSize = 0
        ButtonMy.FlatAppearance.BorderSize = 2
    End Sub

    Private Sub ButtonBefore_Click(sender As Object, e As EventArgs) Handles ButtonBefore.Click

        DateTimePicker1.Enabled = True
        TextBoxName2.Enabled = True
        TextBoxPhone.Enabled = True
        TextBoxPass.Enabled = True
        TextBoxAddress.Enabled = True
        ButtonUploadimage.Enabled = True

    End Sub

    Private Sub ButtonUploadimage_Click(sender As Object, e As EventArgs) Handles ButtonUploadimage.Click

        Dim opf As New OpenFileDialog()
        opf.Filter = "Select Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then

            PictureBoxMemberImage.Image = Image.FromFile(opf.FileName)

        End If

    End Sub

    Private Sub ButtonAfter_Click(sender As Object, e As EventArgs) Handles ButtonAfter.Click

        Dim member As New MEMBER()
        Dim name2 As String = TextBoxName2.Text
        Dim phone As String = TextBoxPhone.Text
        Dim password As String = TextBoxPass.Text
        Dim address As String = TextBoxAddress.Text
        Dim birth As Date = DateTimePicker1.Value
        Dim pic As New MemoryStream

        PictureBoxMemberImage.Image.Save(pic, PictureBoxMemberImage.Image.RawFormat)

        '檢查生日是否正確
        Dim born_year As Integer = DateTimePicker1.Value.Year
        Dim this_year As Integer = Date.Now.Year
        Dim born_month As Integer = DateTimePicker1.Value.Month
        Dim this_month As Integer = Date.Now.Month
        Dim born_date As Integer = DateTimePicker1.Value.Day
        Dim this_date As Integer = Date.Now.Day

        '驗證
        If name2.Trim() = "" Or address.Trim() = "" Or phone.Trim() = "" Or password.Trim() = "" Then

            MessageBox.Show("有一個或多個資料未填入", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        ElseIf born_year - this_year > 0 Then

            If born_month - this_month > 0 Then

                If born_date - this_date > 0 Then

                    MsgBox("你這時還未出生喔~ 親~")
                End If
            End If

        Else

            Dim email As String = TextBoxEM.Text
            If member.updateMember(email, name2, phone, password, address, birth, pic) Then

                MessageBox.Show("已儲存更改", "User Edit", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DateTimePicker1.Enabled = False
                TextBoxName2.Enabled = False
                TextBoxPhone.Enabled = False
                TextBoxPass.Enabled = False
                TextBoxAddress.Enabled = False
                ButtonUploadimage.Enabled = False
            Else

                MessageBox.Show("發生錯誤，請重新嘗試", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        End If

    End Sub

    Private Sub TextBoxPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPhone.KeyPress

        '設定只能輸入數字
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then

            e.Handled = True

        End If

    End Sub
End Class