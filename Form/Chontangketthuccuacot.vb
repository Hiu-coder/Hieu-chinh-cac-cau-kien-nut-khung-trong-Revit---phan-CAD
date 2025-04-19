Public Class Chontangketthuccuacot
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        matbang.TangKT = Convert.ToDouble(txtTang.Text)
        matbang.CaoDoKT = Convert.ToDouble(txtCaoDo.Text)
        Me.Close()
    End Sub
End Class