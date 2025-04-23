Public Class Chontangketthuc
    Public Sub New(matbang As cls_Matbang)
        InitializeComponent()
        Me.Matbang = matbang
    End Sub

    Public Property Matbang As cls_Matbang

    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        Matbang.TangKT = Convert.ToInt32(txtTang.Text)
        Matbang.CaoDoKT = Convert.ToDecimal(txtCaoDo.Text)
        Me.Close()
    End Sub
End Class