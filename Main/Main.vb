Imports Autodesk.AutoCAD.LayerManager
Imports Autodesk.AutoCAD.Runtime

Public Class Main

    <CommandMethod("LayBanVe")>
    Public Sub laybanve()
        System.IO.File.WriteAllText("D:\NCKH\LaybanveCAD_ver2\MATBANG.xml", "")
        congtrinh = New cls_CongTrinh
        layerLuoiTruc = Nothing
        layerDam = Nothing
        layerCot = Nothing
        Dim dlgmain As New MainForm
        dlgmain.ShowDialog()

    End Sub
End Class
