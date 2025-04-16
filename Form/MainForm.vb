Public Class MainForm
    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        matbang.Tang = Convert.ToDouble(txtTang.Text)
        matbang.CaoDo = Convert.ToDouble(txtCaoDo.Text)
        md_Layluoitruc.LayLuoiTruc()
        md_Laydam.LayDam()
        md_Laycot.LayCot()
        md_Xml.Ghixml("D:\NCKH\LaybanveCAD_ver2\MATBANG.xml", matbang)
    End Sub
End Class