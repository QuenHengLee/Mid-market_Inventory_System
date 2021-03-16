Public Class Kouman_MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = Image.FromFile("../../myImages/warehouse.png")
    End Sub

    Private Sub AddNewStudentToolStripMenuItem_Click(sender As Object, e As EventArgs)

        Dim addStdF As New Kouman_AddItemsForm
        addStdF.Show(Me)


        'addStdF.Show() 開新視窗且背景是窗關閉me不會跟著關閉
        'addStdF.ShowDialog()  開新視窗且不可點選背景視窗

    End Sub

    Private Sub StudentsListToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim stdList As New ShowItemsListForm()
        stdList.Show(Me)
    End Sub

    Private Sub 查看下游訂單ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim chereOrder As New Kouman_CheckOrderForm()
        chereOrder.Show(Me)
    End Sub

    Private Sub 重新登入ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim Lform As New LoginForm()
        Lform.Show()
        Me.Close()
    End Sub

    Private Sub 查看庫存ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim KSform As New Kouman_CheckStockForm
        KSform.Show()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim Lform As New LoginForm()
        Lform.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Button1.BackColor = Color.FromArgb(179, 55, 113)
        Button2.BackColor = Color.FromArgb(44, 58, 71)
        Button3.BackColor = Color.FromArgb(44, 58, 71)
        Button4.BackColor = Color.FromArgb(44, 58, 71)
        Button6.BackColor = Color.FromArgb(44, 58, 71)

        With Kouman_DashBoardForm
            .TopLevel = False
            Panel2.Controls.Add(Kouman_DashBoardForm)
            .BringToFront()
            .Show()
        End With





        'Dim addStdF As New AddStudentForm
        'addStdF.Show(Me)


        'addStdF.Show() 開新視窗且背景是窗關閉me不會跟著關閉
        'addStdF.ShowDialog()  開新視窗且不可點選背景視窗
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Button1.BackColor = Color.FromArgb(44, 58, 71)
        Button2.BackColor = Color.FromArgb(179, 55, 113)
        Button3.BackColor = Color.FromArgb(44, 58, 71)
        Button4.BackColor = Color.FromArgb(44, 58, 71)
        Button6.BackColor = Color.FromArgb(44, 58, 71)

        With ShowItemsListForm
            .TopLevel = False
            Panel2.Controls.Add(ShowItemsListForm)
            .BringToFront()
            .Show()
        End With




        'Dim stdList As New studentsListForm()
        'stdList.Show(Me)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Button1.BackColor = Color.FromArgb(44, 58, 71)
        Button2.BackColor = Color.FromArgb(44, 58, 71)
        Button3.BackColor = Color.FromArgb(179, 55, 113)
        Button4.BackColor = Color.FromArgb(44, 58, 71)
        Button6.BackColor = Color.FromArgb(44, 58, 71)

        With Kouman_CheckStockForm
            .TopLevel = False
            Panel2.Controls.Add(Kouman_CheckStockForm)
            .BringToFront()
            .Show()
        End With



        ' Dim KSform As New KoumanStockForm
        ' KSform.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click


        Button1.BackColor = Color.FromArgb(44, 58, 71)
        Button2.BackColor = Color.FromArgb(44, 58, 71)
        Button3.BackColor = Color.FromArgb(44, 58, 71)
        Button4.BackColor = Color.FromArgb(179, 55, 113)
        Button6.BackColor = Color.FromArgb(44, 58, 71)

        With Kouman_CheckOrderForm
            .TopLevel = False
            Panel2.Controls.Add(Kouman_CheckOrderForm)
            .BringToFront()
            .Show()
        End With

        'Dim chereOrder As New CheckRetailerOrderForm()
        'chereOrder.Show(Me)
    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs)


        Dim dbform As New Kouman_DashBoardForm
        dbform.Show(Me)
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click

        Button1.BackColor = Color.FromArgb(44, 58, 71)
        Button2.BackColor = Color.FromArgb(44, 58, 71)
        Button3.BackColor = Color.FromArgb(44, 58, 71)
        Button6.BackColor = Color.FromArgb(179, 55, 113)
        Button4.BackColor = Color.FromArgb(44, 58, 71)
        With Kouman_CRMForm
            .TopLevel = False
            Panel2.Controls.Add(Kouman_CRMForm)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub
End Class