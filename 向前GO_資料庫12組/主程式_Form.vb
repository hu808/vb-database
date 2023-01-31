Public Class 主程式_Form

    Private Sub 主程式_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ButtonMy檔案.Hide()
        ButtonMy紀錄.Hide()

        Dim member As New MEMBER()
        DataGridView1.ReadOnly = True
        DataGridView1.RowTemplate.Height = 50
        DataGridView1.DataSource = member.getMember()
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.Visible = False

        Labeluser.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()


        PictureBoxProduct1.Image = My.Resources._1_1
        PictureBoxProduct2.Image = My.Resources._1_2
        Labelname1.ForeColor = Color.Black
        Labelname2.ForeColor = Color.Black
        Labelmoney1.ForeColor = Color.Black
        Labelmoney2.ForeColor = Color.Black
        Labelname1.Text = "海賊王公仔"
        Labelname2.Text = "Rebecca Bonbon翻糖甜心大托特包"
        Labelmoney1.Text = "$ 500"
        Labelmoney2.Text = "$ 1080"
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click

        Application.Exit()

    End Sub

    Private Sub ButtonMainGo_MouseClick(sender As Object, e As MouseEventArgs) Handles ButtonMainGo.MouseClick

        ButtonMainGo.FlatAppearance.BorderSize = 2
        ButtonWish.FlatAppearance.BorderSize = 0
        ButtonMy.FlatAppearance.BorderSize = 0

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

    Private Sub ButtonMy檔案_Click(sender As Object, e As EventArgs) Handles ButtonMy檔案.Click

        Me.Hide()
        Dim mdForm As New 我的檔案_Form()
        mdForm.Show()

    End Sub

    Private Sub 主程式_Form_paint(sender As Object, e As EventArgs) Handles MyBase.Paint
        ButtonMy檔案.Hide()
        ButtonMy紀錄.Hide()
        ButtonMainGo.FlatAppearance.BorderSize = 2
        ButtonWish.FlatAppearance.BorderSize = 0
        ButtonMy.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub ButtonAfter_Click(sender As Object, e As EventArgs) Handles ButtonAfter.Click

        Dim now As Integer = LabelNowPage.Text
        Dim all As Integer = LabelTotalPge.Text

        If now < all Then
            LabelNowPage.Text = LabelNowPage.Text + 1
        Else
            MsgBox("這是最後一頁!!!")
        End If

        Dim a As Integer = LabelNowPage.Text
        Labelp2.Text = 2 * a
        Labelp1.Text = Labelp2.Text - 1

        If LabelNowPage.Text = 1 Then

            PictureBoxProduct1.Image = My.Resources._1_1
            PictureBoxProduct2.Image = My.Resources._1_2
            Labelname1.Text = "海賊王公仔"
            Labelname2.Text = "Rebecca Bonbon翻糖甜心大托特包"
            Labelmoney1.Text = "$ 500"
            Labelmoney2.Text = "$ 1080"

        ElseIf LabelNowPage.Text = 2 Then

            PictureBoxProduct1.Image = My.Resources._2_1
            PictureBoxProduct2.Image = My.Resources._2_2
            Labelname1.Text = "nike air max 99 二代新款滴塑復古鞋"
            Labelname2.Text = "CHIMEI 14吋智能DC扇DF-14B0ST"
            Labelmoney1.Text = "$ 1700"
            Labelmoney2.Text = "$ 1988"

        ElseIf LabelNowPage.Text = 3 Then

            PictureBoxProduct1.Image = My.Resources._3_1
            PictureBoxProduct2.Image = My.Resources._3_2
            Labelname1.Text = "被批評的勇氣"
            Labelname2.Text = "巴黎萊雅 奢華皮革訂製唇膏 限量款_3.7g640"
            Labelmoney1.Text = "$ 300"
            Labelmoney2.Text = "$ 399"

        ElseIf LabelNowPage.Text = 4 Then

            PictureBoxProduct1.Image = My.Resources._4_1
            PictureBoxProduct2.Image = My.Resources._4_2
            Labelname1.Text = "得意優質抽取式衛生紙"
            Labelname2.Text = "金莎巧克力"
            Labelmoney1.Text = "$ 599"
            Labelmoney2.Text = "$ 299"

        ElseIf LabelNowPage.Text = 5 Then

            PictureBoxProduct1.Image = My.Resources._5_1
            PictureBoxProduct2.Image = My.Resources._5_2
            Labelname1.Text = "來一客杯麵鮮蝦魚板風味"
            Labelname2.Text = "10人份不鏽鋼電鍋TAC-10L-DCR"
            Labelmoney1.Text = "$ 75"
            Labelmoney2.Text = "$ 1945"

        ElseIf LabelNowPage.Text = 6 Then

            PictureBoxProduct1.Image = My.Resources._6_1
            PictureBoxProduct2.Image = My.Resources._6_2
            Labelname1.Text = "倍潔雅超質感抽取式衛生紙"
            Labelname2.Text = "優活Livi抽取式衛生紙"
            Labelmoney1.Text = "$ 729"
            Labelmoney2.Text = "$ 788"

        ElseIf LabelNowPage.Text = 7 Then

            PictureBoxProduct1.Image = My.Resources._7_1
            PictureBoxProduct2.Image = My.Resources._7_2
            Labelname1.Text = "拉麵道-日式豚骨風味"
            Labelname2.Text = "健達繽紛樂"
            Labelmoney1.Text = "$ 88"
            Labelmoney2.Text = "$ 118"

        ElseIf LabelNowPage.Text = 8 Then

            PictureBoxProduct1.Image = My.Resources._8_1
            PictureBoxProduct2.Image = My.Resources._8_2
            Labelname1.Text = "光泉保久乳-全脂牛乳"
            Labelname2.Text = "光泉保久乳-高鈣牛乳"
            Labelmoney1.Text = "$ 384"
            Labelmoney2.Text = "$ 360"

        ElseIf LabelNowPage.Text = 9 Then

            PictureBoxProduct1.Image = My.Resources._9_1
            PictureBoxProduct2.Image = My.Resources._9_2
            Labelname1.Text = "愛之味麥仔茶(微甜)"
            Labelname2.Text = "高露潔纖柔三尖端牙刷"
            Labelmoney1.Text = "$ 159"
            Labelmoney2.Text = "$ 50"

        ElseIf LabelNowPage.Text = 10 Then

            PictureBoxProduct1.Image = My.Resources._10_1
            PictureBoxProduct2.Image = My.Resources._10_2
            Labelname1.Text = "Panasonic國際 負離子速乾吹風機"
            Labelname2.Text = "Panasonic國際 負離子吹風機"
            Labelmoney1.Text = "$ 733"
            Labelmoney2.Text = "$ 1393"

        End If
    End Sub

    Private Sub ButtonBefore_Click(sender As Object, e As EventArgs) Handles ButtonBefore.Click

        If LabelNowPage.Text > 1 Then

            LabelNowPage.Text = LabelNowPage.Text - 1
        Else

            MsgBox("這是第一頁!!!")

        End If

        Dim a As Integer = LabelNowPage.Text
        Labelp2.Text = 2 * a
        Labelp1.Text = Labelp2.Text - 1

        If LabelNowPage.Text = 1 Then

            PictureBoxProduct1.Image = My.Resources._1_1
            PictureBoxProduct2.Image = My.Resources._1_2
            Labelname1.Text = "海賊王公仔"
            Labelname2.Text = "Rebecca Bonbon翻糖甜心大托特包"
            Labelmoney1.Text = "$ 500"
            Labelmoney2.Text = "$ 1080"

        ElseIf LabelNowPage.Text = 2 Then

            PictureBoxProduct1.Image = My.Resources._2_1
            PictureBoxProduct2.Image = My.Resources._2_2
            Labelname1.Text = "nike air max 99 二代新款滴塑復古鞋"
            Labelname2.Text = "CHIMEI 14吋智能DC扇DF-14B0ST"
            Labelmoney1.Text = "$ 1700"
            Labelmoney2.Text = "$ 1988"

        ElseIf LabelNowPage.Text = 3 Then

            PictureBoxProduct1.Image = My.Resources._3_1
            PictureBoxProduct2.Image = My.Resources._3_2
            Labelname1.Text = "被批評的勇氣"
            Labelname2.Text = "巴黎萊雅 奢華皮革訂製唇膏 限量款_3.7g640"
            Labelmoney1.Text = "$ 300"
            Labelmoney2.Text = "$ 399"

        ElseIf LabelNowPage.Text = 4 Then

            PictureBoxProduct1.Image = My.Resources._4_1
            PictureBoxProduct2.Image = My.Resources._4_2
            Labelname1.Text = "得意優質抽取式衛生紙"
            Labelname2.Text = "金莎巧克力"
            Labelmoney1.Text = "$ 599"
            Labelmoney2.Text = "$ 299"

        ElseIf LabelNowPage.Text = 5 Then

            PictureBoxProduct1.Image = My.Resources._5_1
            PictureBoxProduct2.Image = My.Resources._5_2
            Labelname1.Text = "來一客杯麵鮮蝦魚板風味"
            Labelname2.Text = "10人份不鏽鋼電鍋TAC-10L-DCR"
            Labelmoney1.Text = "$ 75"
            Labelmoney2.Text = "$ 1945"

        ElseIf LabelNowPage.Text = 6 Then

            PictureBoxProduct1.Image = My.Resources._6_1
            PictureBoxProduct2.Image = My.Resources._6_2
            Labelname1.Text = "倍潔雅超質感抽取式衛生紙"
            Labelname2.Text = "優活Livi抽取式衛生紙"
            Labelmoney1.Text = "$ 729"
            Labelmoney2.Text = "$ 788"

        ElseIf LabelNowPage.Text = 7 Then

            PictureBoxProduct1.Image = My.Resources._7_1
            PictureBoxProduct2.Image = My.Resources._7_2
            Labelname1.Text = "拉麵道-日式豚骨風味"
            Labelname2.Text = "健達繽紛樂"
            Labelmoney1.Text = "$ 88"
            Labelmoney2.Text = "$ 118"

        ElseIf LabelNowPage.Text = 8 Then

            PictureBoxProduct1.Image = My.Resources._8_1
            PictureBoxProduct2.Image = My.Resources._8_2
            Labelname1.Text = "光泉保久乳-全脂牛乳"
            Labelname2.Text = "光泉保久乳-高鈣牛乳"
            Labelmoney1.Text = "$ 384"
            Labelmoney2.Text = "$ 360"

        ElseIf LabelNowPage.Text = 9 Then

            PictureBoxProduct1.Image = My.Resources._9_1
            PictureBoxProduct2.Image = My.Resources._9_2
            Labelname1.Text = "愛之味麥仔茶(微甜)"
            Labelname2.Text = "高露潔纖柔三尖端牙刷"
            Labelmoney1.Text = "$ 159"
            Labelmoney2.Text = "$ 50"

        ElseIf LabelNowPage.Text = 10 Then

            PictureBoxProduct1.Image = My.Resources._10_1
            PictureBoxProduct2.Image = My.Resources._10_2
            Labelname1.Text = "Panasonic國際 負離子速乾吹風機"
            Labelname2.Text = "Panasonic國際 負離子吹風機"
            Labelmoney1.Text = "$ 733"
            Labelmoney2.Text = "$ 1393"

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim pListF As New 商品清單_Form()
        pListF.Show(Me)

    End Sub
End Class