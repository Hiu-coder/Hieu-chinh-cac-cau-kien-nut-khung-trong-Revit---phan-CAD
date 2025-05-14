Imports Autodesk.AutoCAD.ApplicationServices
Imports Autodesk.AutoCAD.DatabaseServices
Imports Autodesk.AutoCAD.EditorInput
Imports Autodesk.AutoCAD.Geometry

Module md_BienChung
    Public doc As Document = Application.DocumentManager.MdiActiveDocument
    Public db As Database = doc.Database
    Public ed As Editor = doc.Editor
    Public congtrinh As cls_CongTrinh
    Public ppr As PromptSelectionResult
    Public haha As cls_Matbang
    Public layerDam As String
    Public layerCot As String
    Public layerLuoiTruc As String
End Module
