Imports System.IO

Public Class 商品清單_Form

    Dim check As New 交易_Form()
    Private Sub 商品清單_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim product As New PRODUCT()

        DataGridView1.ReadOnly = True

        Dim picCol As New DataGridViewImageColumn()

        DataGridView1.RowTemplate.Height = 30

        DataGridView1.DataSource = product.getProduct()

        picCol = DataGridView1.Columns(7)

        picCol.ImageLayout = DataGridViewImageCellLayout.Stretch

        DataGridView1.AllowUserToAddRows = False

    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick

        ButtonBuy1.Enabled = True
        LabelProduct.ForeColor = Color.Black
        LabelPrice.ForeColor = Color.Black
        LabelBrand.ForeColor = Color.Black
        LabelSize.ForeColor = Color.Black
        LabelCategory.ForeColor = Color.Black
        LabelOrigin.ForeColor = Color.Black
        LabelpNo.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        updatePNO(LabelpNo.Text)
        LabelProduct.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        LabelPrice.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        LabelBrand.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        LabelSize.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
        LabelCategory.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
        LabelOrigin.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString()

        Dim pic As Byte()
        pic = DataGridView1.CurrentRow.Cells(7).Value
        Dim picture As New MemoryStream(pic)
        PictureBoxProduct.Image = Image.FromStream(picture)

        check.LabelpNo.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        check.LabelProduct.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        check.LabelPrice.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        Dim checkpic As Byte()
        checkpic = DataGridView1.CurrentRow.Cells(7).Value
        Dim checkpicture As New MemoryStream(checkpic)
        check.PictureBoxProduct.Image = Image.FromStream(checkpicture)

    End Sub

    Function updatePNO(ByVal PNO As Decimal) As Decimal
        Static NowpNo As Decimal
        NowpNo = PNO
        TextBoxtry.Text = NowpNo
        Return NowpNo
    End Function

    Private Sub ButtonBuy1_Click(sender As Object, e As EventArgs) Handles ButtonBuy1.Click

        check.Show()

    End Sub
End Class