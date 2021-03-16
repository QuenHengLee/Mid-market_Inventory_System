Public Class Kouman_OrderForm
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Close()

    End Sub

    Private Sub ButtonAddOrder_Click(sender As Object, e As EventArgs) Handles ButtonAddOrder.Click

        Dim student As New FUNCTIONS()

        Dim amount_1 As String = TextBoxAmount_1.Text
        Dim amount_2 As String = TextBoxAmount_2.Text
        Dim amount_3 As String = TextBoxAmount_3.Text
        Dim amount_4 As String = TextBoxAmount_4.Text
        Dim amount_5 As String = TextBoxAmount_5.Text


        Dim today As Date = Label10.Text
        Dim sum As String = TextBox2.Text
        Dim retailer As String = TextBox1.Text


        If (student.addKoumanItems(ComboBox1.Text, amount_1, ComboBox2.Text, amount_2, ComboBox3.Text, amount_3, ComboBox4.Text, amount_4, ComboBox5.Text, amount_5)) And
           (student.addKoumanOrderInfo(retailer, today, sum)) Then
            MsgBox("新增成功", MsgBoxStyle.Information, "Add Inventory")

        Else
            MsgBox("錯誤", MsgBoxStyle.Critical, "Inventory")

        End If
    End Sub

    Private Sub Kouman_OrderForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        Label22.Text = Retailer_MainForm.Label1.Text

        Label10.Text = Format(Now, "yyyy-MM-dd")
        Label10.Visible = False



        Dim student As New FUNCTIONS()

        ComboBox1.DataSource = student.getItems()
        ComboBox1.ValueMember = "id"
        ComboBox1.DisplayMember = "first_name"
        ComboBox1.SelectedIndex = -1


        ComboBox2.DataSource = student.getItems()
        ComboBox2.ValueMember = "id"
        ComboBox2.DisplayMember = "first_name"
        ComboBox2.SelectedIndex = -1

        ComboBox3.DataSource = student.getItems()
        ComboBox3.ValueMember = "id"
        ComboBox3.DisplayMember = "first_name"
        ComboBox3.SelectedIndex = -1


        ComboBox4.DataSource = student.getItems()
        ComboBox4.ValueMember = "id"
        ComboBox4.DisplayMember = "first_name"
        ComboBox4.SelectedIndex = -1

        ComboBox5.DataSource = student.getItems()
        ComboBox5.ValueMember = "id"
        ComboBox5.DisplayMember = "first_name"
        ComboBox5.SelectedIndex = -1
    End Sub

    Private Sub CheckButton_Click(sender As Object, e As EventArgs) Handles CheckButton.Click
        Dim student As New FUNCTIONS()
        DataGridView1.ReadOnly = True
        DataGridView1.DataSource = student.getPrice(ComboBox1.Text, ComboBox2.Text, ComboBox3.Text, ComboBox4.Text, ComboBox5.Text)
        DataGridView1.AllowUserToAddRows = False

        TextBoxAmount_1.ReadOnly = True
        TextBoxAmount_2.ReadOnly = True
        TextBoxAmount_3.ReadOnly = True
        TextBoxAmount_4.ReadOnly = True
        TextBoxAmount_5.ReadOnly = True

        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
        ComboBox3.Enabled = False
        ComboBox4.Enabled = False
        ComboBox5.Enabled = False

    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        TextBox2.Text = Convert.ToInt32(DataGridView1.Rows(0).Cells(0).Value.ToString) * Convert.ToInt32(TextBoxAmount_1.Text) +
                      Convert.ToInt32(DataGridView1.Rows(1).Cells(0).Value.ToString) * Convert.ToInt32(TextBoxAmount_2.Text) +
                      Convert.ToInt32(DataGridView1.Rows(2).Cells(0).Value.ToString) * Convert.ToInt32(TextBoxAmount_3.Text) +
                      Convert.ToInt32(DataGridView1.Rows(3).Cells(0).Value.ToString) * Convert.ToInt32(TextBoxAmount_4.Text) +
                      Convert.ToInt32(DataGridView1.Rows(4).Cells(0).Value.ToString) * Convert.ToInt32(TextBoxAmount_5.Text)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ComboBox1.Text = "防風雨連帽外套"
        ComboBox2.Text = "圓領T恤"
        ComboBox3.Text = "寬版V領毛衣"
        ComboBox4.Text = "織紋寬版上衣"
        ComboBox5.Text = "羔羊絨外套"

        TextBoxAmount_1.Text = 20
        TextBoxAmount_2.Text = 30
        TextBoxAmount_3.Text = 40
        TextBoxAmount_4.Text = 50
        TextBoxAmount_5.Text = 60
    End Sub
End Class