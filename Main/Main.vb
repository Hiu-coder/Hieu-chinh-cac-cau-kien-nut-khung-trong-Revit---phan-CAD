Imports Autodesk.AutoCAD.Runtime

Public Class Main
    <CommandMethod("LayDam")>
    Public Sub laydam()
        md_Laydam.LayDam()
    End Sub
    <CommandMethod("LayLuoiTruc")>
    Public Sub layluoitruc()
        md_Layluoitruc.LayLuoiTruc()
    End Sub
    <CommandMethod("LayBanVe")>
    Public Sub laybanve()
        Dim dlgmain As New MainForm
        dlgmain.ShowDialog()

    End Sub
End Class
