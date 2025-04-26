Imports System.Drawing
Imports Autodesk.AutoCAD.DatabaseServices
Imports Autodesk.AutoCAD.EditorInput
Imports Autodesk.AutoCAD.Geometry

Module md_Laycot
    Public Sub LayCot(matbang As cls_Matbang)

        Dim Cots As New List(Of BlockReference)()

        Using tr As Transaction = db.TransactionManager.StartTransaction()
            For Each selObj As SelectedObject In ppr.Value
                Dim ent As Entity = TryCast(tr.GetObject(selObj.ObjectId, OpenMode.ForRead), Entity)
                If TypeOf ent Is BlockReference AndAlso ent.Layer = "COT" Then
                    Cots.Add(DirectCast(ent, BlockReference))
                End If
            Next
            Dim strten As New List(Of String)
            For Each t In Cots
                strten.Add(t.Name)
            Next
            Dim loaicot = strten.Distinct().ToList
            For Each item In loaicot
                ' Lấy phần trong dấu ngoặc
                Dim phanNgoac = item.Substring(item.IndexOf("(") + 1)
                phanNgoac = phanNgoac.Replace(")", "") ' bỏ dấu )

                ' Tách b và h
                Dim kichthuoc = phanNgoac.Split("x"c)
                Dim b = Convert.ToDouble(kichthuoc(0))
                Dim h = Convert.ToDouble(kichthuoc(1))
                matbang.LoaiCot.Add(New cls_LoaiCot With {.Ten = item, .Rong = b, .Cao = h})
            Next
            For Each cot In Cots
                Dim haha As cls_LoaiCot = matbang.LoaiCot.FirstOrDefault(Function(x) x.Ten = cot.Name)
                Dim vitri = cot.Position
                For Each l In matbang.LuoiTruc.DiemGiao
                    If Math.Abs(l.Toado.X - vitri.X) < 300 And Math.Abs(l.Toado.Y - vitri.Y) < 300 Then
                        matbang.DSCot.Add(New cls_Cot With {
                                          .Loai = haha,
                                          .Diemdat = l.Ten,
                                          .Goc = cot.Rotation,
                                          .LechgiaotrucX = l.Toado.X - vitri.X,
                                          .LechgiaotrucY = l.Toado.Y - vitri.Y
                                          })
                    End If
                Next
            Next


            tr.Commit()
            ed.WriteMessage("Hoàn thành lấy cột")
        End Using
    End Sub
End Module
