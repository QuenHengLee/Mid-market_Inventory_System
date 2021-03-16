Public Class WholeSale_CheckOrderForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick


        Dim wsOIF As New WholeSale_ShowOrderItemsForm()
        wsOIF.Show()

        'showOIF.item_1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        wsOIF.Order_Label.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        wsOIF.Date_Label.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        wsOIF.Total_Label.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        wsOIF.OrderIDLabel.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()

        wsOIF.item_1.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString()
        wsOIF.amount_1.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString()
        wsOIF.item_2.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString()
        wsOIF.amount_2.Text = DataGridView1.CurrentRow.Cells(10).Value.ToString()
        wsOIF.item_3.Text = DataGridView1.CurrentRow.Cells(11).Value.ToString()
        wsOIF.amount_3.Text = DataGridView1.CurrentRow.Cells(12).Value.ToString()
        wsOIF.item_4.Text = DataGridView1.CurrentRow.Cells(13).Value.ToString()
        wsOIF.amount_4.Text = DataGridView1.CurrentRow.Cells(14).Value.ToString()
        wsOIF.item_5.Text = DataGridView1.CurrentRow.Cells(15).Value.ToString()
        wsOIF.amount_5.Text = DataGridView1.CurrentRow.Cells(16).Value.ToString()

    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub WholeSale_CheckOrderForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        Button1.BackColor = Color.FromArgb(10, 61, 98)


        DataGridView1.Visible = True


        Dim student As New FUNCTIONS()
        DataGridView1.ReadOnly = True
        DataGridView1.DataSource = student.getKoumanOrder
        DataGridView1.AllowUserToAddRows = False

        DataGridView1.Columns("ko_id").Visible = False
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
End Class