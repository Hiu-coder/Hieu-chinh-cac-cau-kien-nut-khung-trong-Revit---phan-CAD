Imports System.Windows.Forms

Public Class GhiThongSoTang
    Public Sub New(matbang As cls_Matbang)
        InitializeComponent()
        Me.Matbang = matbang
    End Sub

    Public Property Matbang As cls_Matbang

    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        If txtCaoDo.Text = "" Or txtCaodomb.Text = "" Or txtTang.Text = "" Or txtTangmb.Text = "" Then
            Return
        End If
        Matbang.TangKT = Convert.ToInt32(txtTang.Text)
        Matbang.CaoDoKT = Convert.ToDecimal(txtCaoDo.Text)
        Matbang.Tang = Convert.ToInt32(txtTangmb.Text)
        Matbang.CaoDo = Convert.ToDecimal(txtCaodomb.Text)
        Me.Close()
    End Sub


End Class