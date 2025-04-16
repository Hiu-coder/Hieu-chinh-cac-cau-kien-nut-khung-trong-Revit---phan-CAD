Public Class Nhapkichthuoccot
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        matbang.LoaiCot.Add(New cls_LoaiCot With {
                          .Ten = lbLoaiCot.Text,
                          .Cao = txtCao.Text,
                          .Rong = txtRong.Text})
        Me.Close()
    End Sub
End Class