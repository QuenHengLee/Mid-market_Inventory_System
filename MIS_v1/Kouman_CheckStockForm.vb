



Public Class Kouman_CheckStockForm


    Public sum As Decimal

    Private Sub KoumanStockForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim student As New FUNCTIONS()
        DataGridView1.ReadOnly = True


        DataGridView1.DataSource = student.getKoumanStock()



        ' DataGridView1.Columns("id").Visible = False
        DataGridView1.Columns("birthday").Visible = False
        DataGridView1.Columns("address").Visible = False
        DataGridView1.Columns("phone").Visible = False
        DataGridView1.Columns("picture").Visible = False
        DataGridView1.Columns("clothes_id").Visible = False
        DataGridView1.Columns("s_amount").Visible = False
        DataGridView1.Columns("m_amount").Visible = False
        DataGridView1.Columns("l_amount").Visible = False
        DataGridView1.Columns("sold_amount").Visible = False

        DataGridView1.Columns(0).HeaderText = "產品編號"
        DataGridView1.Columns(1).HeaderText = "產品名稱"
        DataGridView1.Columns(2).HeaderText = "產品類別"
        DataGridView1.Columns(8).HeaderText = "總數量"
        DataGridView1.Columns(9).HeaderText = "S號數量"
        DataGridView1.Columns(10).HeaderText = "M號數量"
        DataGridView1.Columns(11).HeaderText = "L號數量"


        DataGridView1.AllowUserToAddRows = False

        Dim sum As Decimal
        For i = 0 To DataGridView1.Rows.Count - 1
            Sum += DataGridView1.Rows(i).Cells(8).Value
        Next

        Label1.Text = Sum / 10








    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim student As New FUNCTIONS()
        DataGridView1.ReadOnly = True


        DataGridView1.DataSource = student.getKoumanStock()



        ' DataGridView1.Columns("id").Visible = False
        DataGridView1.Columns("birthday").Visible = False
        DataGridView1.Columns("address").Visible = False
        DataGridView1.Columns("phone").Visible = False
        DataGridView1.Columns("picture").Visible = False
        DataGridView1.Columns("clothes_id").Visible = False

        DataGridView1.Columns(0).HeaderText = "產品編號"
        DataGridView1.Columns(1).HeaderText = "產品名稱"
        DataGridView1.Columns(2).HeaderText = "產品類別"
        DataGridView1.Columns(8).HeaderText = "總數量"
        DataGridView1.Columns(9).HeaderText = "S號數量"
        DataGridView1.Columns(10).HeaderText = "M號數量"
        DataGridView1.Columns(11).HeaderText = "L號數量"


        DataGridView1.AllowUserToAddRows = False

        Dim sum As Decimal
        For i = 0 To DataGridView1.Rows.Count - 1
            sum += DataGridView1.Rows(i).Cells(8).Value
        Next

        Label1.Text = sum / 10
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Kouman_OrderForm.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim student As New FUNCTIONS()
        DataGridView1.ReadOnly = True


        DataGridView1.DataSource = student.getKoumanSearchedStock(TextBox1.Text)



        ' DataGridView1.Columns("id").Visible = False
        DataGridView1.Columns("birthday").Visible = False
        DataGridView1.Columns("address").Visible = False
        DataGridView1.Columns("phone").Visible = False
        DataGridView1.Columns("picture").Visible = False
        DataGridView1.Columns("clothes_id").Visible = False

        DataGridView1.Columns(0).HeaderText = "產品編號"
        DataGridView1.Columns(1).HeaderText = "產品名稱"
        DataGridView1.Columns(2).HeaderText = "產品類別"
        DataGridView1.Columns(8).HeaderText = "總數量"
        DataGridView1.Columns(9).HeaderText = "S號數量"
        DataGridView1.Columns(10).HeaderText = "M號數量"
        DataGridView1.Columns(11).HeaderText = "L號數量"


        DataGridView1.AllowUserToAddRows = False
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class