Imports Autodesk.AutoCAD.ApplicationServices
Imports Autodesk.AutoCAD.DatabaseServices
Imports Autodesk.AutoCAD.EditorInput
Imports Autodesk.AutoCAD.Geometry

Module md_BienChung
    Public doc As Document = Application.DocumentManager.MdiActiveDocument
    Public db As Database = doc.Database
    Public ed As Editor = doc.Editor
    Public filePath As String
    Public trucchung As List(Of Line)
    Public matbang As New cls_Matbang
End Module
