Imports Autodesk.AutoCAD.EditorInput

Public Class MainForm
    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        matbang.Tang = Convert.ToDouble(txtTang.Text)
        matbang.CaoDo = Convert.ToDouble(txtCaoDo.Text)
        Me.Close()
        Dim pso As New PromptSelectionOptions()
        pso.MessageForAdding = "Chọn vùng chứa các cấu kiện và lươi trục của cấu kiện:"
        ppr = ed.GetSelection(pso)
        If ppr.Status <> PromptStatus.OK Then
            ed.WriteMessage("\nKhông có đối tượng nào được chọn.")
            Return
        End If
        md_Layluoitruc.LayLuoiTruc()
        md_Laydam.LayDam()
        Dim dlgkt As New Chontangketthuccuacot
        dlgkt.ShowDialog()
        md_Laycot.LayCot()
        md_Xml.Ghixml("D:\NCKH\LaybanveCAD_ver2\MATBANG.xml", matbang)
        ed.WriteMessage(vbLf & "Xuất dữ liệu thành công")
    End Sub

End Class