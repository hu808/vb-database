Public Class 訂單詳情_Form

    Dim transaction As New TRANSACTION()
    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click

        If TextBoxCanDelete.Text = 1 Then

            Dim tid As Integer = Convert.ToInt32(TextBoxTID.Text)

            If MsgBox("確定要刪除訂單嗎?", MsgBoxStyle.YesNo, "Delete") = MsgBoxResult.Yes Then

                If transaction.deleteTransaction(tid) Then
                    MsgBox("訂單已刪除", MsgBoxStyle.Information, "Delete")
                Else
                    MsgBox("發生錯誤，請重新嘗試", MsgBoxStyle.Information, "Delete")
                End If
            End If

        Else
            MsgBox("訂單已超過24小時，已無法刪除訂單!!!", MsgBoxStyle.Information, "Delete")
        End If

    End Sub
End Class