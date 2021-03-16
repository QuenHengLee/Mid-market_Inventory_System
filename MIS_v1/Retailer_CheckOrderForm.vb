Public Class Retailer_CheckOrderForm
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Button6.BackColor = Color.FromArgb(10, 61, 98)
        Button5.BackColor = Color.FromArgb(116, 125, 140)
        Button4.BackColor = Color.FromArgb(116, 125, 140)


        Dim retailer As String
        retailer = Label1.Text


        Dim student As New FUNCTIONS()
        DataGridView1.ReadOnly = True
        DataGridView1.DataSource = student.getSendedOrder(retailer)
        DataGridView1.AllowUserToAddRows = False

        DataGridView1.Columns(0).HeaderText = "零售商"
        DataGridView1.Columns(1).HeaderText = "訂單日期"
        DataGridView1.Columns(2).HeaderText = "總金額"
        DataGridView1.Columns(3).HeaderText = "狀態"
        DataGridView1.Columns(4).HeaderText = "備註"
        DataGridView1.Columns("remark").Visible = False



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button4.BackColor = Color.FromArgb(10, 61, 98)
        Button5.BackColor = Color.FromArgb(116, 125, 140)
        Button6.BackColor = Color.FromArgb(116, 125, 140)


        Dim retailer As String
        retailer = Label1.Text

        Dim student As New FUNCTIONS()
        DataGridView1.ReadOnly = True
        DataGridView1.DataSource = student.getDeclinedFromKoumanOrder(retailer)
        DataGridView1.AllowUserToAddRows = False

        DataGridView1.Columns(0).HeaderText = "零售商"
        DataGridView1.Columns(1).HeaderText = "訂單日期"
        DataGridView1.Columns(2).HeaderText = "總金額"
        DataGridView1.Columns(3).HeaderText = "狀態"
        DataGridView1.Columns(4).HeaderText = "備註"

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Button5.BackColor = Color.FromArgb(10, 61, 98)
        Button6.BackColor = Color.FromArgb(116, 125, 140)
        Button4.BackColor = Color.FromArgb(116, 125, 140)


        Dim retailer As String
        retailer = Label1.Text

        Dim student As New FUNCTIONS()
        DataGridView1.ReadOnly = True
        DataGridView1.DataSource = student.getFinishedOrder(retailer)
        DataGridView1.AllowUserToAddRows = False

        DataGridView1.Columns(0).HeaderText = "零售商"
        DataGridView1.Columns(1).HeaderText = "訂單日期"
        DataGridView1.Columns(2).HeaderText = "總金額"
        DataGridView1.Columns(3).HeaderText = "狀態"
        DataGridView1.Columns(4).HeaderText = "備註"
        DataGridView1.Columns("remark").Visible = False

    End Sub

    Private Sub Retailer_CheckOrderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim RDR As New Retailer_DeclinedReasonForm()
        RDR.Show()

        RDR.TextBox2.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()

    End Sub
End Class