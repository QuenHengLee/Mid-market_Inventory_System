Public Class Kouman_CheckOrderForm
    '檢視未處理訂單細項
    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick

        Dim showOIF As New Kouman_ShowOrderItemsForm()
        showOIF.Show()

        'showOIF.item_1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        showOIF.Order_Label.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        showOIF.Date_Label.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        showOIF.Total_Label.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        showOIF.OrderIDLabel.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()

        showOIF.item_1.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString()
        showOIF.amount_1.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString()
        showOIF.item_2.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString()
        showOIF.amount_2.Text = DataGridView1.CurrentRow.Cells(10).Value.ToString()
        showOIF.item_3.Text = DataGridView1.CurrentRow.Cells(11).Value.ToString()
        showOIF.amount_3.Text = DataGridView1.CurrentRow.Cells(12).Value.ToString()
        showOIF.item_4.Text = DataGridView1.CurrentRow.Cells(13).Value.ToString()
        showOIF.amount_4.Text = DataGridView1.CurrentRow.Cells(14).Value.ToString()
        showOIF.item_5.Text = DataGridView1.CurrentRow.Cells(15).Value.ToString()
        showOIF.amount_5.Text = DataGridView1.CurrentRow.Cells(16).Value.ToString()

    End Sub
    '檢視已接受訂單細項
    Private Sub DataGridView2_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView2.DoubleClick
        Dim deliveryOIF As New Kouman_DeliveryOrderItemsForm()
        deliveryOIF.Show()

        'showOIF.item_1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        deliveryOIF.Order_Label.Text = DataGridView2.CurrentRow.Cells(1).Value.ToString()
        deliveryOIF.Date_Label.Text = DataGridView2.CurrentRow.Cells(2).Value.ToString()
        deliveryOIF.Total_Label.Text = DataGridView2.CurrentRow.Cells(3).Value.ToString()
        deliveryOIF.OrderIDLabel.Text = DataGridView2.CurrentRow.Cells(0).Value.ToString()

        deliveryOIF.item_1.Text = DataGridView2.CurrentRow.Cells(7).Value.ToString()
        deliveryOIF.amount_1.Text = DataGridView2.CurrentRow.Cells(8).Value.ToString()
        deliveryOIF.item_2.Text = DataGridView2.CurrentRow.Cells(9).Value.ToString()
        deliveryOIF.amount_2.Text = DataGridView2.CurrentRow.Cells(10).Value.ToString()
        deliveryOIF.item_3.Text = DataGridView2.CurrentRow.Cells(11).Value.ToString()
        deliveryOIF.amount_3.Text = DataGridView2.CurrentRow.Cells(12).Value.ToString()
        deliveryOIF.item_4.Text = DataGridView2.CurrentRow.Cells(13).Value.ToString()
        deliveryOIF.amount_4.Text = DataGridView2.CurrentRow.Cells(14).Value.ToString()
        deliveryOIF.item_5.Text = DataGridView2.CurrentRow.Cells(15).Value.ToString()
        deliveryOIF.amount_5.Text = DataGridView2.CurrentRow.Cells(16).Value.ToString()

    End Sub
    '列出未處理訂單
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Button1.BackColor = Color.FromArgb(10, 61, 98)
        Button2.BackColor = Color.FromArgb(116, 125, 140)
        Button3.BackColor = Color.FromArgb(116, 125, 140)
        Button4.BackColor = Color.FromArgb(116, 125, 140)


        DataGridView1.Visible = True
        DataGridView2.Visible = False
        DataGridView3.Visible = False
        DataGridView4.Visible = False

        Dim student As New FUNCTIONS()
        DataGridView1.ReadOnly = True
        DataGridView1.DataSource = student.getRetailerOrder
        DataGridView1.AllowUserToAddRows = False

        DataGridView1.Columns("ro_id").Visible = False
        DataGridView1.Columns("item_1").Visible = False
        DataGridView1.Columns("item_2").Visible = False
        DataGridView1.Columns("item_3").Visible = False
        DataGridView1.Columns("item_4").Visible = False
        DataGridView1.Columns("item_5").Visible = False
        DataGridView1.Columns("amount_1").Visible = False
        DataGridView1.Columns("amount_2").Visible = False
        DataGridView1.Columns("amount_3").Visible = False
        DataGridView1.Columns("amount_4").Visible = False
        DataGridView1.Columns("amount_5").Visible = False
        DataGridView1.Columns("state").Visible = False
        DataGridView1.Columns("remark").Visible = False

        DataGridView1.Columns(0).HeaderText = "訂單編號"
        DataGridView1.Columns(1).HeaderText = "零售商名稱"
        DataGridView1.Columns(2).HeaderText = "訂單日期"
        DataGridView1.Columns(3).HeaderText = "總金額"
    End Sub
    '列出已接受訂單
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Button2.BackColor = Color.FromArgb(10, 61, 98)
        Button1.BackColor = Color.FromArgb(116, 125, 140)
        Button3.BackColor = Color.FromArgb(116, 125, 140)
        Button4.BackColor = Color.FromArgb(116, 125, 140)

        DataGridView1.Visible = False
        DataGridView2.Visible = True
        DataGridView3.Visible = False
        DataGridView4.Visible = False


        Dim student As New FUNCTIONS()
        DataGridView2.ReadOnly = True
        DataGridView2.DataSource = student.getAcceptedOrder
        DataGridView2.AllowUserToAddRows = False

        DataGridView2.Columns("ro_id").Visible = False
        DataGridView2.Columns("item_1").Visible = False
        DataGridView2.Columns("item_2").Visible = False
        DataGridView2.Columns("item_3").Visible = False
        DataGridView2.Columns("item_4").Visible = False
        DataGridView2.Columns("item_5").Visible = False
        DataGridView2.Columns("amount_1").Visible = False
        DataGridView2.Columns("amount_2").Visible = False
        DataGridView2.Columns("amount_3").Visible = False
        DataGridView2.Columns("amount_4").Visible = False
        DataGridView2.Columns("amount_5").Visible = False
        DataGridView2.Columns("state").Visible = False
        DataGridView2.Columns("remark").Visible = False

        DataGridView2.Columns(0).HeaderText = "訂單編號"
        DataGridView2.Columns(1).HeaderText = "零售商名稱"
        DataGridView2.Columns(2).HeaderText = "訂單日期"
        DataGridView2.Columns(3).HeaderText = "總金額"
    End Sub
    '列出已拒絕訂單
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Button4.BackColor = Color.FromArgb(10, 61, 98)
        Button2.BackColor = Color.FromArgb(116, 125, 140)
        Button3.BackColor = Color.FromArgb(116, 125, 140)
        Button1.BackColor = Color.FromArgb(116, 125, 140)

        DataGridView1.Visible = False
        DataGridView2.Visible = False
        DataGridView3.Visible = False
        DataGridView4.Visible = True

        Dim student As New FUNCTIONS()
        DataGridView4.ReadOnly = True
        DataGridView4.DataSource = student.getDeclinedOrder
        DataGridView4.AllowUserToAddRows = False

        DataGridView4.Columns("ro_id").Visible = False
        DataGridView4.Columns("item_1").Visible = False
        DataGridView4.Columns("item_2").Visible = False
        DataGridView4.Columns("item_3").Visible = False
        DataGridView4.Columns("item_4").Visible = False
        DataGridView4.Columns("item_5").Visible = False
        DataGridView4.Columns("amount_1").Visible = False
        DataGridView4.Columns("amount_2").Visible = False
        DataGridView4.Columns("amount_3").Visible = False
        DataGridView4.Columns("amount_4").Visible = False
        DataGridView4.Columns("amount_5").Visible = False
        DataGridView4.Columns("state").Visible = False
        DataGridView4.Columns("remark").Visible = False

        DataGridView4.Columns(0).HeaderText = "訂單編號"
        DataGridView4.Columns(1).HeaderText = "零售商名稱"
        DataGridView4.Columns(2).HeaderText = "訂單日期"
        DataGridView4.Columns(3).HeaderText = "總金額"
    End Sub
    '列出已出貨訂單
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Button3.BackColor = Color.FromArgb(10, 61, 98)
        Button2.BackColor = Color.FromArgb(116, 125, 140)
        Button1.BackColor = Color.FromArgb(116, 125, 140)
        Button4.BackColor = Color.FromArgb(116, 125, 140)

        DataGridView1.Visible = False
        DataGridView2.Visible = False
        DataGridView3.Visible = True
        DataGridView4.Visible = False

        Dim student As New FUNCTIONS()
        DataGridView3.ReadOnly = True
        DataGridView3.DataSource = student.getDeliveriedOrder
        DataGridView3.AllowUserToAddRows = False

        DataGridView3.Columns("ro_id").Visible = False
        DataGridView3.Columns("item_1").Visible = False
        DataGridView3.Columns("item_2").Visible = False
        DataGridView3.Columns("item_3").Visible = False
        DataGridView3.Columns("item_4").Visible = False
        DataGridView3.Columns("item_5").Visible = False
        DataGridView3.Columns("amount_1").Visible = False
        DataGridView3.Columns("amount_2").Visible = False
        DataGridView3.Columns("amount_3").Visible = False
        DataGridView3.Columns("amount_4").Visible = False
        DataGridView3.Columns("amount_5").Visible = False
        DataGridView3.Columns("state").Visible = False
        DataGridView3.Columns("remark").Visible = False

        DataGridView3.Columns(0).HeaderText = "訂單編號"
        DataGridView3.Columns(1).HeaderText = "零售商名稱"
        DataGridView3.Columns(2).HeaderText = "訂單日期"
        DataGridView3.Columns(3).HeaderText = "總金額"
    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class