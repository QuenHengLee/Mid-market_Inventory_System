Public Class Kouman_ShowOrderItemsForm

    Private Sub ShowOrderItemsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim student As New FUNCTIONS()
        '  DataGridView1.ReadOnly = True
        ' DataGridView1.DataSource = student.getOrderItems
        ' DataGridView1.AllowUserToAddRows = False


        'Label1.Text 代表選擇訂單ID


    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Close()
    End Sub

    Private Sub ButtonAddStudent_Click(sender As Object, e As EventArgs) Handles ButtonAddStudent.Click
        Dim student As New FUNCTIONS()
        Dim orderID As String = OrderIDLabel.Text

        If student.acceptOrder(orderID) Then

            MsgBox("接受成功", MsgBoxStyle.Information, "Add Inventory")

        Else
            MsgBox("錯誤", MsgBoxStyle.Critical, "Inventory")

        End If






    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Dim student As New FUNCTIONS()
        Dim orderID As String = OrderIDLabel.Text
        Dim RTDForm As New Kouman_ReasonToDeclineForm()
        RTDForm.Label2.Text = OrderIDLabel.Text


        If student.declineOrder(orderID) Then
            RTDForm.Show()
            ' MsgBox("拒絕成功", MsgBoxStyle.Information, "Add Inventory")

        Else
            MsgBox("錯誤", MsgBoxStyle.Critical, "Inventory")

        End If
    End Sub

    Private Sub amount_4_Click(sender As Object, e As EventArgs) Handles amount_4.Click

    End Sub
End Class