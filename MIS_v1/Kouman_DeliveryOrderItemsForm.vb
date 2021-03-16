Public Class Kouman_DeliveryOrderItemsForm


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Close()
    End Sub

    Private Sub ButtonAddStudent_Click(sender As Object, e As EventArgs) Handles ButtonAddStudent.Click

        Dim student As New FUNCTIONS()
        Dim orderID As String = OrderIDLabel.Text

        If (student.deliveryOrder(orderID)) And  '傳送下單資訊
           (student.reduceStock(item_1.Text, amount_1.Text)) And '扣除數量
           (student.reduceStock(item_2.Text, amount_2.Text)) And
           (student.reduceStock(item_3.Text, amount_3.Text)) And
           (student.reduceStock(item_4.Text, amount_4.Text)) And
           (student.reduceStock(item_5.Text, amount_5.Text)) And
           (student.recordSoldAmount(item_1.Text, amount_1.Text)) And '紀錄售出數量
           (student.recordSoldAmount(item_2.Text, amount_2.Text)) And
           (student.recordSoldAmount(item_3.Text, amount_3.Text)) And
           (student.recordSoldAmount(item_4.Text, amount_4.Text)) And
           (student.recordSoldAmount(item_5.Text, amount_5.Text)) Then




            MsgBox("出貨成功", MsgBoxStyle.Information, "Add Inventory")
        Else
            MsgBox("錯誤", MsgBoxStyle.Critical, "Inventory")
        End If
    End Sub







    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Close()
    End Sub

End Class