Public Class Kouman_DashBoardForm
    Private Sub DashBoardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim student As New FUNCTIONS()


#Region "顯示目前已使用多少倉庫空間 "
        DataGridView2.DataSource = student.getKoumanStock()
        DataGridView2.Visible = False
        Dim sum As Decimal
        Dim storage As Decimal = 5000

        For i = 0 To DataGridView2.Rows.Count - 1
            sum += DataGridView2.Rows(i).Cells(8).Value
        Next
        Label4.Text = sum / storage * 100
#End Region


#Region "顯示目前有幾筆未處理訂單"
        DataGridView3.DataSource = student.getRetailerOrder
        DataGridView3.Visible = False
        Label12.Text = DataGridView3.RowCount - 1
#End Region

#Region "顯示當季應收帳款"
        DataGridView4.DataSource = student.getDeliveriedOrder
        DataGridView4.Visible = False
        Dim Accounts_receivable As Integer

        For i = 0 To DataGridView4.Rows.Count - 1
            Accounts_receivable += DataGridView4.Rows(i).Cells(3).Value
        Next
        Label3.Text = +Accounts_receivable
#End Region


#Region "低庫存警示"
        DataGridView1.ReadOnly = True
        DataGridView1.DataSource = student.getLowInventory()
        DataGridView1.Columns("id").Visible = False
        DataGridView1.Columns(1).HeaderText = "商品"
        DataGridView1.Columns(2).HeaderText = "類別"
        DataGridView1.Columns(3).HeaderText = "僅剩數量"
#End Region


#Region "銷售排行榜"
        DataGridView5.DataSource = student.getBestSeller()
        DataGridView5.Columns(0).HeaderText = "熱銷商品"
        DataGridView5.Columns(1).HeaderText = "售出數量"
#End Region


    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        '數量顯示紅字
        If (e.ColumnIndex = 3) Then
            e.CellStyle.ForeColor = Color.Red
        End If
    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim student As New FUNCTIONS()
        DataGridView3.DataSource = student.getRetailerOrder
        DataGridView3.Visible = False
        Label12.Text = DataGridView3.RowCount - 1


        DataGridView2.DataSource = student.getKoumanStock()
        DataGridView2.Visible = False
        Dim sum As Decimal
        Dim storage As Decimal = 5000

        DataGridView4.DataSource = student.getDeliveriedOrder
        DataGridView4.Visible = False
        Dim Accounts_receivable As Integer

        For i = 0 To DataGridView4.Rows.Count - 1
            Accounts_receivable += DataGridView4.Rows(i).Cells(3).Value
        Next
        Label3.Text = +Accounts_receivable

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)
        ShowRetailerInfoForm.Show()
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) 
        'DataGridView5.Visible = False
        'DataGridView1.Visible = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) 
        'DataGridView5.Visible = True
        'DataGridView1.Visible = False
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class