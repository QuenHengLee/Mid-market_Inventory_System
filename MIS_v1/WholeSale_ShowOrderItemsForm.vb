Public Class WholeSale_ShowOrderItemsForm
    Private Sub ButtonAddStudent_Click(sender As Object, e As EventArgs) Handles ButtonAddStudent.Click

        Dim student As New FUNCTIONS()
        Dim orderID As String = OrderIDLabel.Text

        If (student.ws_deliveryOrder(orderID)) And  '傳送下單資訊
              (student.addStock(item_1.Text, amount_1.Text)) And
            (student.addStock(item_2.Text, amount_2.Text)) And
            (student.addStock(item_3.Text, amount_3.Text)) And
            (student.addStock(item_4.Text, amount_4.Text)) And
            (student.addStock(item_5.Text, amount_5.Text)) Then




            MsgBox("出貨成功", MsgBoxStyle.Information, "Add Inventory")
        Else
            MsgBox("錯誤", MsgBoxStyle.Critical, "Inventory")
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Close()
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click

        Dim student As New FUNCTIONS()
        Dim orderID As String = OrderIDLabel.Text

        If (student.ws_declinedOrder(orderID)) Then

            MsgBox("拒絕成功", MsgBoxStyle.Information, "Add Inventory")
        Else
            MsgBox("錯誤", MsgBoxStyle.Critical, "Inventory")
        End If
    End Sub

    Private Sub item_1_Click(sender As Object, e As EventArgs) Handles item_1.Click

    End Sub
End Class