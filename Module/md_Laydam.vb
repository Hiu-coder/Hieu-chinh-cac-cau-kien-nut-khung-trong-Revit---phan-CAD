Imports System.Drawing
Imports System.Net
Imports System.Windows.Forms
Imports Autodesk.AutoCAD.ApplicationServices
Imports Autodesk.AutoCAD.DatabaseServices
Imports Autodesk.AutoCAD.EditorInput
Imports Autodesk.AutoCAD.Geometry
Imports Autodesk.AutoCAD.Runtime

Module md_Laydam

    Public Sub LayDam(matbang As cls_Matbang)

        Using tr As Transaction = db.TransactionManager.StartTransaction()

            Dim beamLines As New List(Of Line)()
            Dim tendam As New List(Of DBText)
            'Dim pp As PromptSelectionResult
            'Dim ps As New PromptSelectionOptions()
            'ps.MessageForAdding = "Chọn cấu kiện DẦM để lấy Layer:"
            'pp = ed.GetSelection(ps)
            'If pp.Status <> PromptStatus.OK Then
            '    ed.WriteMessage("\nKhông có đối tượng nào được chọn.")
            '    Return
            'End If

            For Each selObj As SelectedObject In ppr.Value
                Dim ent As Entity = TryCast(tr.GetObject(selObj.ObjectId, OpenMode.ForRead), Entity)
                If TypeOf ent Is Line AndAlso ent.Layer = "DAM" Then
                    beamLines.Add(DirectCast(ent, Line))
                End If
            Next
            For Each selObj As SelectedObject In ppr.Value
                Dim ent As Entity = TryCast(tr.GetObject(selObj.ObjectId, OpenMode.ForRead), Entity)
                If TypeOf ent Is DBText Then
                    tendam.Add(DirectCast(ent, DBText))
                End If
            Next
            Dim strten As New List(Of String)
            For Each t In tendam
                strten.Add(t.TextString)
            Next
            Dim loaidam = strten.Distinct().ToList
            For Each item In loaidam
                ' Lấy phần trong dấu ngoặc
                Dim phanNgoac = item.Substring(item.IndexOf("(") + 1)
                phanNgoac = phanNgoac.Replace(")", "") ' bỏ dấu )

                ' Tách b và h
                Dim kichthuoc = phanNgoac.Split("x"c)
                Dim b = Convert.ToDouble(kichthuoc(0))
                Dim h = Convert.ToDouble(kichthuoc(1))
                matbang.LoaiDam.Add(New cls_LoaiDam With {.Ten = item, .Rong = b, .Cao = h})
            Next

            For Each ha In matbang.LuoiTruc.TrucNgang
                Dim trucxet = ha.Line
                Dim tamtruc As New Point3d((trucxet.StartPoint.X + trucxet.EndPoint.X) / 2, (trucxet.StartPoint.Y + trucxet.EndPoint.Y) / 2, 0)
                Dim damphai As New List(Of Line)
                Dim damtrai As New List(Of Line)
                For Each dam In beamLines
                    If Ktrass(dam, trucxet) = True And Math.Abs(dam.StartPoint.Y - trucxet.StartPoint.Y) < 500 And Math.Abs(trucxet.StartPoint.Y - trucxet.EndPoint.Y) < 0.01 Then
                        If (dam.StartPoint.Y - trucxet.StartPoint.Y) > 0 Then
                            damphai.Add(dam)
                        ElseIf (dam.StartPoint.Y - trucxet.StartPoint.Y) < 0 Then
                            damtrai.Add(dam)
                        End If
                    ElseIf Ktrass(dam, trucxet) = True And Math.Abs(dam.StartPoint.X - trucxet.StartPoint.X) < 500 And Math.Abs(trucxet.StartPoint.X - trucxet.EndPoint.X) < 0.01 Then

                        If (dam.StartPoint.X - trucxet.StartPoint.X) > 0 Then
                            damphai.Add(dam)
                        ElseIf (dam.StartPoint.X - trucxet.StartPoint.X) < 0 Then
                            damtrai.Add(dam)
                        End If
                    End If
                Next
                Dim ten As String
                For Each td In tendam
                    Dim kc = td.Position.DistanceTo(tamtruc)
                    If kc < 3000 Then
                        ten = td.TextString
                    End If
                Next
                Dim haha As cls_LoaiDam = matbang.LoaiDam.FirstOrDefault(Function(x) x.Ten = ten)
                Dim l1 = Join(damphai)
                Dim l2 = Join(damtrai)
                matbang.DSDam.Add(New cls_Dam With {
                                         .Loaidam = haha,
                                         .Trucxet = ha.Ten,
                                         .LechTrucX1 = (ha.Line.StartPoint.X - l1.StartPoint.X),
                                         .LechTrucX2 = (ha.Line.EndPoint.X - l1.EndPoint.X),
                                         .LechTrucY1 = (ha.Line.StartPoint.Y - (l1.StartPoint.Y + l2.StartPoint.Y) / 2),
                                         .LechTrucY2 = (ha.Line.EndPoint.Y - (l1.EndPoint.Y + l2.EndPoint.Y) / 2)
                                         })

            Next
            For Each ha In matbang.LuoiTruc.TrucDoc
                Dim trucxet = ha.Line
                Dim tamtruc As New Point3d((trucxet.StartPoint.X + trucxet.EndPoint.X) / 2, (trucxet.StartPoint.Y + trucxet.EndPoint.Y) / 2, 0)
                Dim damphai As New List(Of Line)
                Dim damtrai As New List(Of Line)
                For Each dam In beamLines
                    If Ktrass(dam, trucxet) = True And Math.Abs(dam.StartPoint.Y - trucxet.StartPoint.Y) < 500 And Math.Abs(trucxet.StartPoint.Y - trucxet.EndPoint.Y) < 0.01 Then
                        If (dam.StartPoint.Y - trucxet.StartPoint.Y) > 0 Then
                            damphai.Add(dam)
                        ElseIf (dam.StartPoint.Y - trucxet.StartPoint.Y) < 0 Then
                            damtrai.Add(dam)
                        End If
                    ElseIf Ktrass(dam, trucxet) = True And Math.Abs(dam.StartPoint.X - trucxet.StartPoint.X) < 500 And Math.Abs(trucxet.StartPoint.X - trucxet.EndPoint.X) < 0.01 Then

                        If (dam.StartPoint.X - trucxet.StartPoint.X) > 0 Then
                            damphai.Add(dam)
                        ElseIf (dam.StartPoint.X - trucxet.StartPoint.X) < 0 Then
                            damtrai.Add(dam)
                        End If
                    End If
                Next
                Dim ten As String
                For Each td In tendam
                    Dim kc = td.Position.DistanceTo(tamtruc)
                    If kc < 3000 Then
                        ten = td.TextString
                    End If
                Next
                Dim haha As cls_LoaiDam = matbang.LoaiDam.FirstOrDefault(Function(x) x.Ten = ten)
                Dim l1 = Join(damphai)
                Dim l2 = Join(damtrai)
                matbang.DSDam.Add(New cls_Dam With {
                                         .Loaidam = haha,
                                         .Trucxet = ha.Ten,
                                         .LechTrucX1 = (ha.Line.StartPoint.X - (l1.StartPoint.X + l2.StartPoint.X) / 2),
                                         .LechTrucX2 = (ha.Line.EndPoint.X - (l1.EndPoint.X + l2.EndPoint.X) / 2),
                                         .LechTrucY1 = (ha.Line.StartPoint.Y - l1.StartPoint.Y),
                                         .LechTrucY2 = (ha.Line.EndPoint.Y - l1.EndPoint.Y)
                                         })

            Next


            tr.Commit()
            ed.WriteMessage("Hoàn thành lấy dầm")

        End Using
    End Sub

    Function Ktrass(line1 As Line, line2 As Line) As Boolean

        Dim vector1 As Vector3d = line1.Delta
        Dim vector2 As Vector3d = line2.Delta

        vector1 = vector1.GetNormal()
        vector2 = vector2.GetNormal()

        Dim dotProduct As Double = vector1.DotProduct(vector2)
        Return Math.Abs(dotProduct) = 1
    End Function
    Function Tinhtoadotamtruc(line1 As Line, line2 As Line, diem As Integer) As Point3d
        'diem = 1 nghĩa là đầu dầm
        If diem = 1 Then
            'dọc
            If Math.Abs(line1.StartPoint.X - line1.EndPoint.X) < 0.01 And Math.Abs(line2.StartPoint.X - line2.EndPoint.X) < 0.01 Then
                Return New Point3d((line1.StartPoint.X + line2.StartPoint.X) / 2, line1.StartPoint.Y, 0)
                'ngang
            ElseIf Math.Abs(line1.StartPoint.Y - line1.EndPoint.Y) < 0.01 And Math.Abs(line2.StartPoint.Y - line2.EndPoint.Y) < 0.01 Then
                Return New Point3d(line1.StartPoint.X, (line1.StartPoint.Y + line2.StartPoint.Y) / 2, 0)
            End If
            'diem = 2 nghĩa là cuối dầm
        ElseIf diem = 2 Then
            'dọc
            If Math.Abs(line1.StartPoint.X - line1.EndPoint.X) < 0.01 And Math.Abs(line2.StartPoint.X - line2.EndPoint.X) < 0.01 Then
                Return New Point3d((line1.StartPoint.X + line2.StartPoint.X) / 2, line1.EndPoint.Y, 0)
                'ngang
            ElseIf Math.Abs(line1.StartPoint.Y - line1.EndPoint.Y) < 0.01 And Math.Abs(line2.StartPoint.Y - line2.EndPoint.Y) < 0.01 Then
                Return New Point3d(line1.EndPoint.X, (line1.StartPoint.Y + line2.StartPoint.Y) / 2, 0)
            End If
        End If
    End Function
    Function Tinhchieurong(line1 As Line, line2 As Line)
        ' Lấy một điểm bất kỳ trên line2 (ví dụ StartPoint)
        Dim pointOnLine2 As Point3d = line2.StartPoint

        ' Lấy vector pháp tuyến của line1
        Dim direction As Vector3d = line1.Delta
        Dim normal As Vector3d = New Vector3d(-direction.Y, direction.X, 0).GetNormal()

        ' Tạo đường thẳng vuông góc đi từ line2 về phía line1
        Dim projectedPoint As Point3d = pointOnLine2 + normal * 1000 ' Đi xa để chắc chắn cắt line1
        Dim testLine As New Line(pointOnLine2, projectedPoint)

        ' Tính khoảng cách từ pointOnLine2 đến line1 (khoảng cách vuông góc)
        Dim closestPoint As Point3d = line1.GetClosestPointTo(pointOnLine2, False)
        Dim distance As Double = pointOnLine2.DistanceTo(closestPoint)
        Return distance
    End Function
    Public Function Join(lines As List(Of Line)) As Line


        ' Lấy tất cả điểm đầu và cuối
        Dim allPoints As New List(Of Point3d)()
        For Each ln In lines
            allPoints.Add(ln.StartPoint)
            allPoints.Add(ln.EndPoint)
        Next

        ' Tìm 2 điểm xa nhau nhất
        Dim maxDist As Double = -1
        Dim pt1 As Point3d = Nothing
        Dim pt2 As Point3d = Nothing

        For i = 0 To allPoints.Count - 2
            For j = i + 1 To allPoints.Count - 1
                Dim dist = allPoints(i).DistanceTo(allPoints(j))
                If dist > maxDist Then
                    maxDist = dist
                    pt1 = allPoints(i)
                    pt2 = allPoints(j)
                End If
            Next
        Next

        Return New Line(pt1, pt2)
    End Function
End Module
