Public Class Nhapsolieudam
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        matbang.LoaiDam.Add(New cls_LoaiDam With {
                          .Ten = lbLoaidam.Text,
                          .Cao = txtCao.Text,
                          .Rong = txtRong.Text})
        Me.Close()
    End Sub
End Class