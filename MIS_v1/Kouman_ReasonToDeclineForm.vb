Public Class Kouman_ReasonToDeclineForm
    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Close()
    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Dim student As New FUNCTIONS()
        Dim remark As String = TextBox1.Text
        Dim rid As String = Label2.Text
        If student.reasontodecline(rid, remark) Then
            MsgBox("成功", MsgBoxStyle.Information, "Add Inventory")

        Else
            MsgBox("錯誤", MsgBoxStyle.Critical, "Inventory")

        End If
    End Sub
End Class