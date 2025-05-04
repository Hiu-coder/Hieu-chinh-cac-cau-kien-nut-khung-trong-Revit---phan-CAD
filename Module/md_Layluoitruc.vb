Imports System.Runtime.InteropServices
Imports Autodesk.AutoCAD.ApplicationServices
Imports Autodesk.AutoCAD.DatabaseServices
Imports Autodesk.AutoCAD.EditorInput
Imports Autodesk.AutoCAD.Geometry

Module md_Layluoitruc
    Public Sub LayLuoiTruc(matbang As cls_Matbang)


        ' Khởi tạo đối tượng lưu trữ lưới trục


        Using tr As Transaction = db.TransactionManager.StartTransaction()


            For Each id As ObjectId In ppr.Value.GetObjectIds()
                Dim ent As Entity = TryCast(tr.GetObject(id, OpenMode.ForRead), Entity)
                If TypeOf ent Is Line AndAlso ent.Layer.ToUpper().Contains("TRUC") Then
                    Dim line As Line = DirectCast(ent, Line)


                    ' Kiểm tra trục ngang (song song trục X)
                    If Math.Abs(line.StartPoint.Y - line.EndPoint.Y) < 0.001 Then
                        matbang.LuoiTruc.TrucNgang.Add(New cls_TrucNgang With {
                            .Ten = LayTenTruc(ppr, line, tr),
                            .DiemDau = New cls_Diem(line.StartPoint.X, line.StartPoint.Y, line.StartPoint.Z),
                            .DiemCuoi = New cls_Diem(line.EndPoint.X, line.EndPoint.Y, line.EndPoint.Z),
                            .Line = line})



                        ' Kiểm tra trục dọc (song song trục Y)
                    ElseIf Math.Abs(line.StartPoint.X - line.EndPoint.X) < 0.001 Then
                        matbang.LuoiTruc.TrucDoc.Add(New cls_TrucDoc With {
                            .Ten = LayTenTruc(ppr, line, tr),
                            .DiemDau = New cls_Diem(line.StartPoint.X, line.StartPoint.Y, line.StartPoint.Z),
                            .DiemCuoi = New cls_Diem(line.EndPoint.X, line.EndPoint.Y, line.EndPoint.Z),
                            .Line = line
                            })

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
                    matbang.LuoiTruc.DiemGiao.Add(New cls_DiemGiao With {.Ten = trucNgang.Ten + trucDoc.Ten, .Toado = giaoDiem, .Toadoxml = New cls_Diem(giaoDiem.X, giaoDiem.Y, giaoDiem.Z)})
                Next
            Next

            tr.Commit()
        End Using
        ed.WriteMessage(vbLf & "Xuất dữ liệu lưới trục và điểm giao thành công: ")
    End Sub


    Public Function LayTenTruc(ppr As PromptSelectionResult, line As Line, tr As Transaction) As String
        ' Danh sách block cần xét (loại bỏ block trên layer "COT")
        Dim blkRefs As New List(Of BlockReference)
        For Each id As ObjectId In ppr.Value.GetObjectIds()
            Dim ent As Entity = TryCast(tr.GetObject(id, OpenMode.ForRead), Entity)
            If TypeOf ent Is BlockReference Then
                Dim blkRef As BlockReference = CType(ent, BlockReference)
                If blkRef.Layer.ToUpper() <> "COT" Then
                    blkRefs.Add(blkRef)
                End If
            End If
        Next

        If blkRefs.Count = 0 Then
            Return "KhongTimThayBlock"
        End If

        ' Tạo đường line kéo dài
        Dim trucXet As Line = ExtendLINE(line, 1000)

        ' Xét từng block
        For Each blkRef As BlockReference In blkRefs

            If LineGiaoBlock(trucXet, blkRef, tr) = True Then
                If blkRef.AttributeCollection.Count > 0 Then
                    For Each attId As ObjectId In blkRef.AttributeCollection
                        Dim attRef As AttributeReference = TryCast(tr.GetObject(attId, OpenMode.ForRead), AttributeReference)
                        If attRef IsNot Nothing Then
                            Return attRef.TextString
                        End If
                    Next
                End If
                ' Nổ block để kiểm tra text
                Dim exploded As New DBObjectCollection()
                If Not blkRef.IsDynamicBlock Then
                    blkRef.Explode(exploded)
                    For Each obj As DBObject In exploded
                        Dim ent As Entity = TryCast(obj, Entity)
                        If TypeOf ent Is DBText Then
                            Dim txt As DBText = CType(ent, DBText)
                            Return txt.TextString
                        End If
                    Next
                End If
            End If
        Next

        Return "KhongCoTen"
    End Function

    Public Function ExtendLINE(line As Line, extensionLength As Double) As Line
        Dim startPoint As Point3d = line.StartPoint
        Dim endPoint As Point3d = line.EndPoint
        Dim direction As Vector3d = endPoint - startPoint
        Dim unitDir As Vector3d = direction.GetNormal()

        Dim newStart As Point3d = startPoint - unitDir * extensionLength
        Dim newEnd As Point3d = endPoint + unitDir * extensionLength

        Return New Line(newStart, newEnd)
    End Function

    Public Function LineGiaoBlock(line As Line, blockRef As BlockReference, tr As Transaction) As Boolean
        Try
            If blockRef Is Nothing Then Return False

            Dim ext As Extents3d

            Try
                ext = blockRef.GeometricExtents
            Catch
                Return False
            End Try

            Dim pts As Point3d() = {
                New Point3d(ext.MinPoint.X, ext.MinPoint.Y, 0),
                New Point3d(ext.MaxPoint.X, ext.MinPoint.Y, 0),
                New Point3d(ext.MaxPoint.X, ext.MaxPoint.Y, 0),
                New Point3d(ext.MinPoint.X, ext.MaxPoint.Y, 0)
            }

            Dim lineSeg As New LineSegment3d(line.StartPoint, line.EndPoint)

            For i As Integer = 0 To 3
                Dim p1 = pts(i)
                Dim p2 = pts((i + 1) Mod 4)

                If p1.DistanceTo(p2) < Tolerance.Global.EqualPoint Then Continue For

                Dim edge As New LineSegment3d(p1, p2)

                Dim result = lineSeg.IntersectWith(edge)
                If result IsNot Nothing AndAlso result.Length > 0 Then
                    Return True
                End If
            Next

            Return False
        Catch ex As Exception
            Return False
        End Try
    End Function




End Module

