Public Class WholeSale_MainForm
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim Lform As New LoginForm()
        Lform.Show()

        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Button7.BackColor = Color.FromArgb(179, 55, 113)
        With WholeSale_CheckOrderForm
            .TopLevel = False
            Panel2.Controls.Add(WholeSale_CheckOrderForm)
            .BringToFront()
            .Show()
        End With



    End Sub
End Class