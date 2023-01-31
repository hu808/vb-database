Public Class 我的紀錄_Form
    Dim member As New MEMBER()
    Private Sub 我的紀錄_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ButtonMy檔案.Hide()
        ButtonMy紀錄.Hide()

        DataGridView1.BringToFront()
        Dim allbuy As New TRANSACTION()

        DataGridView1.ReadOnly = True

        DataGridView1.RowTemplate.Height = 30

        DataGridView1.DataSource = allbuy.getmTransaction()

        DataGridView1.AllowUserToAddRows = False

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

    Private Sub ButtonMy檔案_Click(sender As Object, e As EventArgs) Handles ButtonMy檔案.Click

        Me.Hide()
        Dim mdForm As New 我的檔案_Form()
        mdForm.Show()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        ButtonMy檔案.Hide()
        ButtonMy紀錄.Hide()
        ButtonMainGo.FlatAppearance.BorderSize = 0
        ButtonWish.FlatAppearance.BorderSize = 0
        ButtonMy.FlatAppearance.BorderSize = 2
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick

        Dim deleteT As New 訂單詳情_Form()
        deleteT.TextBoxTID.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        deleteT.TextBoxName.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        deleteT.TextBoxAmount.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        deleteT.TextBoxTotalP.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        deleteT.DateTimePickerTD.Value = DataGridView1.CurrentRow.Cells(4).Value

        Dim t_year As Integer = DataGridView1.CurrentRow.Cells(4).Value.Year
        Dim this_year As Integer = Date.Now.Year
        Dim t_month As Integer = DataGridView1.CurrentRow.Cells(4).Value.Month
        Dim this_month As Integer = Date.Now.Month
        Dim t_date As Integer = DataGridView1.CurrentRow.Cells(4).Value.Day
        Dim this_date As Integer = Date.Now.Day
        Dim t_Hour As Integer = DataGridView1.CurrentRow.Cells(4).Value.Hour
        Dim this_Hour As Integer = Date.Now.Hour
        Dim t_Second As Integer = DataGridView1.CurrentRow.Cells(4).Value.Second
        Dim this_Second As Integer = Date.Now.Second

        If this_year - t_year = 0 Then
            If this_month - t_month = 0 Then

                If this_date - t_date = 0 Then

                    deleteT.TextBoxCanDelete.Text = 1

                ElseIf this_date - t_date = 1 Then

                    If this_Hour - t_Hour < 0 Then

                        deleteT.TextBoxCanDelete.Text = 1

                    ElseIf this_Hour - t_Hour = 0 Then

                        If this_Second - t_Second < 0 Then
                            deleteT.TextBoxCanDelete.Text = 1
                        End If

                    End If

                End If
            End If
        End If

        deleteT.Show()

    End Sub

    Private Sub ButtonBuy1_Click(sender As Object, e As EventArgs) Handles ButtonBuy1.Click

        ButtonMy檔案.Hide()
        ButtonMy紀錄.Hide()

        DataGridView1.BringToFront()
        Dim allbuy As New TRANSACTION()

        DataGridView1.ReadOnly = True

        DataGridView1.RowTemplate.Height = 30

        DataGridView1.DataSource = allbuy.getmTransaction()

        DataGridView1.AllowUserToAddRows = False

    End Sub
End Class