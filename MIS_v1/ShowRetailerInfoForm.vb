Public Class ShowRetailerInfoForm
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Close()
    End Sub

    Private Sub ShowRetailerInfoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim student As New FUNCTIONS()
        DataGridView1.ReadOnly = True


        DataGridView1.DataSource = student.getRetailerInfo()





        DataGridView1.Columns("r_id").Visible = False
        DataGridView1.Columns("account").Visible = False
        ' DataGridView1.Columns("revenue").Visible = False

        DataGridView1.Columns(0).HeaderText = "零售商編號"
        DataGridView1.Columns(1).HeaderText = "帳號"
        DataGridView1.Columns(2).HeaderText = "零售商"
        DataGridView1.Columns(3).HeaderText = "負責人"
        DataGridView1.Columns(4).HeaderText = "送貨地址"
        DataGridView1.Columns(5).HeaderText = "連絡電話"
        DataGridView1.Columns(6).HeaderText = "應收帳"


    End Sub
End Class