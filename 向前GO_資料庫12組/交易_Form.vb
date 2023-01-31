Imports System.IO

Public Class 交易_Form
    Private Sub 交易_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LabelTotalP.Text = LabelPrice.Text * TextBoxAmount.Text
        Dim member As New MEMBER()
        DataGridView1.DataSource = member.getMember()
        DataGridView1.Visible = False

        LabelMID.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
    End Sub

    Private Sub ButtonBuy1_Click(sender As Object, e As EventArgs) Handles ButtonBuy1.Click

        Dim t As New TRANSACTION()
        Dim mid As String = LabelMID.Text
        Dim pno As String = LabelpNo.Text
        Dim amount As String = TextBoxAmount.Text
        Dim saleprice As String = LabelTotalP.Text
        Dim tdate As DateTime = DateTime.Now

        Dim method As String = "ATM"
        If RadioButtonCOD.Checked Then
            method = "cash on delivery (COD)"
        ElseIf RadioButtondbcard.Checked Then
            method = "debit card"
        ElseIf RadioButtonATM.Checked Then
            method = "ATM"
        End If

        Dim deliver As String = "Family Mart"
        If RadioButton711.Checked Then
            deliver = "7-11"
        ElseIf RadioButtonHome.Checked Then
            deliver = "home delivery"
        ElseIf RadioButtonFM.Checked Then
            deliver = "Family Mart"
        End If

        If amount.Trim() = "" Then

            MessageBox.Show("數量不可為 0 !!!", "Missing Amount", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        Else
            If t.insertTransaction(mid, pno, amount, saleprice, tdate, method, deliver) Then

                MsgBox("訂單成立", MsgBoxStyle.Information, "Successful")

            Else

                MsgBox("發生錯誤", MsgBoxStyle.Critical, "Error")

            End If
        End If
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click

        If TextBoxAmount.Text = "" Then

            MessageBox.Show("數量不可為 0 !!!", "Missing Amount", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        Else

            LabelTotalP.Text = LabelPrice.Text * TextBoxAmount.Text
            ButtonBuy1.Enabled = True

        End If

    End Sub

    Private Sub TextBoxAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxAmount.KeyPress

        '設定只能輸入數字
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then

            e.Handled = True

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Hide()

    End Sub

End Class