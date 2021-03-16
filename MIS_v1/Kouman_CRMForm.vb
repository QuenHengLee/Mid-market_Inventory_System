Public Class Kouman_CRMForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ShowRetailerInfoForm.Show()
    End Sub

    Private Sub Kouman_CRMForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim student As New FUNCTIONS

        DataGridView1.DataSource = student.getRevenue
        DataGridView1.Visible = False

        Dim retailer_1 As String = DataGridView1.Rows(0).Cells(0).Value.ToString
        Dim retailer_2 As String = DataGridView1.Rows(1).Cells(0).Value.ToString
        Dim retailer_3 As String = DataGridView1.Rows(2).Cells(0).Value.ToString
        Dim retailer_4 As String = DataGridView1.Rows(3).Cells(0).Value.ToString
        Dim retailer_5 As String = DataGridView1.Rows(4).Cells(0).Value.ToString

        Dim sum_1 As String = DataGridView1.Rows(0).Cells(1).Value.ToString
        Dim sum_2 As String = DataGridView1.Rows(1).Cells(1).Value.ToString
        Dim sum_3 As String = DataGridView1.Rows(2).Cells(1).Value.ToString
        Dim sum_4 As String = DataGridView1.Rows(3).Cells(1).Value.ToString
        Dim sum_5 As String = DataGridView1.Rows(4).Cells(1).Value.ToString


        Chart1.Series(0).Points.AddXY(retailer_1, sum_1)
        Chart1.Series(0).Points.AddXY(retailer_2, sum_2)
        Chart1.Series(0).Points.AddXY(retailer_3, sum_3)
        Chart1.Series(0).Points.AddXY(retailer_4, sum_4)
        Chart1.Series(0).Points.AddXY(retailer_5, sum_5)





    End Sub
End Class