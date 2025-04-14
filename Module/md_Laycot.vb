Imports Autodesk.AutoCAD.DatabaseServices
Imports Autodesk.AutoCAD.EditorInput
Imports Autodesk.AutoCAD.Geometry

Module md_Laycot
    Public Sub LayCot()
        Dim ppr As PromptSelectionResult = ed.GetSelection()
        If ppr.Status <> PromptStatus.OK Then
            ed.WriteMessage("\nKhông có đối tượng nào được chọn.")
            Return
        End If
        Dim Cots As New List(Of BlockReference)()

        Using tr As Transaction = db.TransactionManager.StartTransaction()
            For Each selObj As SelectedObject In ppr.Value
                Dim ent As Entity = TryCast(tr.GetObject(selObj.ObjectId, OpenMode.ForRead), Entity)
                If TypeOf ent Is BlockReference AndAlso ent.Layer = "COT" Then
                    Cots.Add(DirectCast(ent, BlockReference))
                End If
            Next
            For Each cot In Cots
                Dim vitri = cot.Position
                Dim diemgiaotruc As cls_Diem = Nothing
                Dim giao = matbang.LuoiTruc.DiemGiao
                For Each diemgiao In giao
                    If Math.Abs(vitri.X - diemgiao.X) < 200 And Math.Abs(vitri.Y - diemgiao.Y) < 200 Then
                        diemgiaotruc = diemgiao
                    End If
                Next
                matbang.DSCot.Add(New cls_Cot With
                               {
                               .Diemdat = New cls_Diem With {.X = vitri.X, .Y = vitri.Y, .Z = vitri.Z},
                               .Ten = "hello",
                               .Tangdau = 1,
                               .Tangcuoi = 2,
                               .Lechgiaotruc = New cls_Lech With {.X = Math.Abs(vitri.X - diemgiaotruc.X), .Y = Math.Abs(vitri.Y - diemgiaotruc.Y)}
                              })
            Next
            tr.Commit()
            ed.WriteMessage("Hoàn thành lấy cột")
        End Using
    End Sub
End Module
