Imports System.Runtime.InteropServices
Imports Autodesk.AutoCAD.ApplicationServices
Imports Autodesk.AutoCAD.DatabaseServices
Imports Autodesk.AutoCAD.EditorInput
Imports Autodesk.AutoCAD.Geometry

Module md_Layluoitruc
    Public Sub LayLuoiTruc(matbang As cls_Matbang)


        ' Khởi tạo đối tượng lưu trữ lưới trục


        Using tr As Transaction = db.TransactionManager.StartTransaction()
            Dim indexNgang As Integer = 1
            Dim indexDoc As Integer = 1

            For Each id As ObjectId In ppr.Value.GetObjectIds()
                Dim ent As Entity = TryCast(tr.GetObject(id, OpenMode.ForRead), Entity)
                If TypeOf ent Is Line AndAlso ent.Layer.ToUpper().Contains("TRUC") Then
                    Dim line As Line = DirectCast(ent, Line)


                    ' Kiểm tra trục ngang (song song trục X)
                    If Math.Abs(line.StartPoint.Y - line.EndPoint.Y) < 0.001 Then
                        matbang.LuoiTruc.TrucNgang.Add(New cls_TrucNgang With {
                            .Ten = "N" & indexNgang,
                            .DiemDau = New cls_Diem(line.StartPoint.X, line.StartPoint.Y, line.StartPoint.Z),
                            .DiemCuoi = New cls_Diem(line.EndPoint.X, line.EndPoint.Y, line.EndPoint.Z),
                            .Line = line})

                        indexNgang += 1

                        ' Kiểm tra trục dọc (song song trục Y)
                    ElseIf Math.Abs(line.StartPoint.X - line.EndPoint.X) < 0.001 Then
                        matbang.LuoiTruc.TrucDoc.Add(New cls_TrucDoc With {
                            .Ten = "D" & indexDoc,
                            .DiemDau = New cls_Diem(line.StartPoint.X, line.StartPoint.Y, line.StartPoint.Z),
                            .DiemCuoi = New cls_Diem(line.EndPoint.X, line.EndPoint.Y, line.EndPoint.Z),
                            .Line = line
                            })
                        indexDoc += 1
                    End If
                End If
            Next

            ' Tìm các điểm giao nhau giữa trục ngang và trục dọc
            For Each trucNgang In matbang.LuoiTruc.TrucNgang
                Dim tn = trucNgang.Line
                For Each trucDoc In matbang.LuoiTruc.TrucDoc
                    Dim td = trucDoc.Line
                    ' Tính giao điểm
                    Dim giaoDiem As New Point3d(td.StartPoint.X, tn.StartPoint.Y, 0)
                    matbang.LuoiTruc.DiemGiao.Add(New cls_DiemGiao With {.Ten = trucNgang.Ten + trucDoc.Ten, .Toado = giaoDiem})
                Next
            Next

            tr.Commit()
        End Using
        ed.WriteMessage(vbLf & "Xuất dữ liệu lưới trục và điểm giao thành công: ")
    End Sub
End Module

