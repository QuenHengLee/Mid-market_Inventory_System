Imports System.IO

Public Class ShowItemsListForm
    Private Sub studentsListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Dim student As New FUNCTIONS()
        DataGridView1.ReadOnly = True
        Dim picCol As New DataGridViewImageColumn()
        DataGridView1.RowTemplate.Height = 80

        DataGridView1.DataSource = student.getStudents()

        picCol = DataGridView1.Columns(5)

        picCol.ImageLayout = DataGridViewImageCellLayout.Stretch

        DataGridView1.AllowUserToAddRows = False


        DataGridView1.Columns(0).HeaderText = "產品名稱"
        DataGridView1.Columns(1).HeaderText = "產品類別"
        DataGridView1.Columns(2).HeaderText = "出廠日期"
        DataGridView1.Columns(3).HeaderText = "定價"
        DataGridView1.Columns(4).HeaderText = "詳細介紹"
        DataGridView1.Columns(5).HeaderText = "照片"

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim IIForm As New ItemInfoForm()
        IIForm.Show()

        IIForm.TextBoxName.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        IIForm.TextBoxCategory.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        IIForm.TextBoxDate.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        IIForm.TextBoxPrice.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        IIForm.TextBoxIndroduction.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()

        'display pic
        Dim pic As Byte()
        pic = DataGridView1.CurrentRow.Cells(5).Value
        Dim picture As New MemoryStream(pic)
        IIForm.PictureBoxImage.Image = Image.FromStream(picture)



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim addStdF As New Kouman_AddItemsForm
        addStdF.Show(Me)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim student As New FUNCTIONS()
        DataGridView1.ReadOnly = True
        Dim picCol As New DataGridViewImageColumn()
        DataGridView1.RowTemplate.Height = 80

        DataGridView1.DataSource = student.getStudents()

        picCol = DataGridView1.Columns(5)

        picCol.ImageLayout = DataGridViewImageCellLayout.Stretch

        DataGridView1.AllowUserToAddRows = False


        DataGridView1.Columns(0).HeaderText = "產品名稱"
        DataGridView1.Columns(1).HeaderText = "產品類別"
        DataGridView1.Columns(2).HeaderText = "出廠日期"
        DataGridView1.Columns(3).HeaderText = "定價"
        DataGridView1.Columns(4).HeaderText = "詳細介紹"
        DataGridView1.Columns(5).HeaderText = "照片"
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

        Dim student As New FUNCTIONS()
        DataGridView1.ReadOnly = True
        Dim picCol As New DataGridViewImageColumn()
        DataGridView1.RowTemplate.Height = 80

        DataGridView1.DataSource = student.getStudents()

        picCol = DataGridView1.Columns(5)

        picCol.ImageLayout = DataGridViewImageCellLayout.Stretch

        DataGridView1.AllowUserToAddRows = False


        DataGridView1.Columns(0).HeaderText = "產品名稱"
        DataGridView1.Columns(1).HeaderText = "產品類別"
        DataGridView1.Columns(2).HeaderText = "出廠日期"
        DataGridView1.Columns(3).HeaderText = "定價"
        DataGridView1.Columns(4).HeaderText = "詳細介紹"
        DataGridView1.Columns(5).HeaderText = "照片"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim student As New FUNCTIONS()
        DataGridView1.ReadOnly = True
        Dim picCol As New DataGridViewImageColumn()
        DataGridView1.RowTemplate.Height = 80

        DataGridView1.DataSource = student.getSearchedStudents(TextBox1.Text)

        picCol = DataGridView1.Columns(5)

        picCol.ImageLayout = DataGridViewImageCellLayout.Stretch

        DataGridView1.AllowUserToAddRows = False


        DataGridView1.Columns(0).HeaderText = "產品名稱"
        DataGridView1.Columns(1).HeaderText = "產品類別"
        DataGridView1.Columns(2).HeaderText = "出廠日期"
        DataGridView1.Columns(3).HeaderText = "定價"
        DataGridView1.Columns(4).HeaderText = "詳細介紹"
        DataGridView1.Columns(5).HeaderText = "照片"
    End Sub
End Class