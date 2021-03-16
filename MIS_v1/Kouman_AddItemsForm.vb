Imports System.IO

Public Class Kouman_AddItemsForm
    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub AddStudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim student As New FUNCTIONS()

        ComboBox1.DataSource = student.getCategory()
        ' ComboBox1.ValueMember = "id"
        ComboBox1.DisplayMember = "last_name"
        ComboBox1.SelectedIndex = -1

    End Sub

    Private Sub TextBoxPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPhone.KeyPress

        'allow only num on this textbox

        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then

            e.Handled = True
        End If

    End Sub

    Private Sub ButtonUploadImage_Click(sender As Object, e As EventArgs) Handles ButtonUploadImage.Click

        Dim opf As New OpenFileDialog()
        opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"

        If opf.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBoxStudentImage.Image = Image.FromFile(opf.FileName)
        End If



    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Close()
    End Sub

    Private Sub ButtonAddStudent_Click(sender As Object, e As EventArgs) Handles ButtonAddStudent.Click


        Dim student As New FUNCTIONS()
        Dim fname As String = TextBoxFname.Text
        Dim lname As String = ComboBox1.Text
        Dim bdate As Date = DateTimePicker1.Value
        Dim phone As String = TextBoxPhone.Text
        Dim adrs As String = TextBoxAdress.Text
        Dim pic As New MemoryStream

        PictureBoxStudentImage.Image.Save(pic, PictureBoxStudentImage.Image.RawFormat)

        If student.insertStudent(fname, lname, bdate, phone, adrs, pic) Then
            MsgBox("新增成功", MsgBoxStyle.Information, "Add Inventory")

        Else
            MsgBox("錯誤", MsgBoxStyle.Critical, "Inventory")

        End If




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBoxFname.Text = "休閒大學T"
        TextBoxPhone.Text = "560"
        TextBoxAdress.Text = "休閒剪裁版型進化。同時留有以往細節及舒適度。・同時保有休閒感及時尚感。"
        ComboBox1.Text = "上衣"



    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Close()
    End Sub
End Class