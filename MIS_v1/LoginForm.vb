Imports MySql.Data.MySqlClient
Public Class LoginForm

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBoxLogin.ImageLocation = "../../myImages/loginIco.png"
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Close()
    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click

        Dim db As New MY_DB()
        Dim adapter As New MySqlDataAdapter()
        Dim table As New DataTable()
        Dim command As New MySqlCommand("SELECT * FROM `user` WHERE `username` = @usn AND `password` = @pass", db.getConnection)

        command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = TextBoxUsername.Text
        command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = TextBoxPassword.Text

        adapter.SelectCommand = command
        adapter.Fill(table)

        If table.Rows.Count > 0 Then

            '判斷登入使用者
            If TextBoxUsername.Text = "kouman" Then
                Dim fmain As New Kouman_MainForm()
                fmain.Show()
                Me.Close()

            ElseIf TextBoxUsername.Text = "retailer1" Then
                Retailer_MainForm.Label1.Text = "開開心心服飾店"
                Retailer_MainForm.Label2.Text = "happy"
                Retailer_OrderForm.TextBox1.Text = "開開心心服飾店"
                Retailer_CheckOrderForm.Label1.Text = "開開心心服飾店"
                Retailer_MainForm.Show()
                Me.Close()
            ElseIf TextBoxUsername.Text = "retailer2" Then
                Dim rmain As New Retailer_MainForm()
                rmain.Label1.Text = "NCYU服飾"
                Retailer_OrderForm.TextBox1.Text = "NCYU服飾"
                Retailer_CheckOrderForm.Label1.Text = "NCYU服飾"
                rmain.Show()
                Me.Close()
            ElseIf TextBoxUsername.Text = "wholesale" Then
                Dim wsmain As New WholeSale_MainForm
                wsmain.Show()
                Me.Close()
            End If


        Else
            MsgBox("錯誤的帳號或密碼", MsgBoxStyle.Critical, "Login Error")
        End If







    End Sub

    Private Sub CheckBoxPass_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxPass.CheckedChanged

        If TextBoxPassword.UseSystemPasswordChar Then
            'show password
            TextBoxPassword.UseSystemPasswordChar = False
        Else
            'hide password
            TextBoxPassword.UseSystemPasswordChar = True
        End If


    End Sub

    Private Sub TextBoxUsername_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUsername.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBoxUsername.Text = "retailer1"
        TextBoxPassword.Text = "retailer1"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBoxUsername.Text = "retailer2"
        TextBoxPassword.Text = "retailer2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBoxUsername.Text = "wholesale"
        TextBoxPassword.Text = "wholesale"
    End Sub
End Class
