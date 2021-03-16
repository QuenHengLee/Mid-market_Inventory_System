Public Class Retailer_MainForm
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click


        'Dim rof As New Retailer_OrderForm()
        'rof.Show()


        With Retailer_OrderForm
            .TopLevel = False
            Panel2.Controls.Add(Retailer_OrderForm)
            .BringToFront()
            .Show()
        End With



        'Dim reOrderF As New RetailerOrderForm
        'reOrderF.Show(Me)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim Lform As New LoginForm()
        Lform.Show()

        Me.Close()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub RetailerForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        PictureBox1.Image = Image.FromFile("../../myImages/shop.png")
        Label3.Text = Label1.Text
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        With ShowItemsListForm
            .TopLevel = False
            Panel2.Controls.Add(ShowItemsListForm)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With Retailer_CheckOrderForm
            .TopLevel = False
            Panel2.Controls.Add(Retailer_CheckOrderForm)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Panel2_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class