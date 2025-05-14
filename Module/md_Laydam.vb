Imports System.Drawing
Imports System.Net
Imports System.Windows.Forms
Imports Autodesk.AutoCAD.ApplicationServices
Imports Autodesk.AutoCAD.DatabaseServices
Imports Autodesk.AutoCAD.EditorInput
Imports Autodesk.AutoCAD.Geometry
Imports Autodesk.AutoCAD.Runtime

Module md_Laydam
    'Dim usedBeamLines As New HashSet(Of ObjectId)()

    Public Sub LayDam(matbang As cls_Matbang)

        Using tr As Transaction = db.TransactionManager.StartTransaction()

            Dim beamLines As New List(Of Line)()
            Dim tendam As New List(Of DBText)

            For Each selObj As SelectedObject In ppr.Value
                Dim ent As Entity = TryCast(tr.GetObject(selObj.ObjectId, OpenMode.ForRead), Entity)
                If TypeOf ent Is Line AndAlso ent.Layer = layerDam Then
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
                            'usedBeamLines.Add(dam.ObjectId)
                        ElseIf (dam.StartPoint.Y - trucxet.StartPoint.Y) < 0 Then
                            damtrai.Add(dam)
                            'usedBeamLines.Add(dam.ObjectId)
                        End If
                    ElseIf Ktrass(dam, trucxet) = True And Math.Abs(dam.StartPoint.X - trucxet.StartPoint.X) < 500 And Math.Abs(trucxet.StartPoint.X - trucxet.EndPoint.X) < 0.01 Then

                        If (dam.StartPoint.X - trucxet.StartPoint.X) > 0 Then
                            damphai.Add(dam)
                            'usedBeamLines.Add(dam.ObjectId)
                        ElseIf (dam.StartPoint.X - trucxet.StartPoint.X) < 0 Then
                            damtrai.Add(dam)
                            'usedBeamLines.Add(dam.ObjectId)
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
                If haha Is Nothing Then
                    ed.WriteMessage("dầm thuộc trục " + ha.Ten + " chưa được đặt tên.")
                    Exit Sub

                End If

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
            'Dim unusedLines = beamLines.Where(Function(l) Not usedBeamLines.Contains(l.ObjectId)).ToList()
            'If unusedLines IsNot Nothing Then
            '    For Each beam In unusedLines
            '        For Each beamktra In unusedLines
            '            If Ktrass(beam, beamktra) = True Then
            '                Dim tamtruc As New Point3d((beam.StartPoint.X + beam.EndPoint.X) / 2, (beam.StartPoint.Y + beam.EndPoint.Y) / 2, 0)
            '                Dim ten As String
            '                For Each td In tendam
            '                    Dim kc = td.Position.DistanceTo(tamtruc)
            '                    If kc < 3000 Then
            '                        ten = td.TextString
            '                    End If
            '                    Dim haha As cls_LoaiDam = matbang.LoaiDam.FirstOrDefault(Function(x) x.Ten = ten)
            '                    Dim ha = matbang.LuoiTruc.TrucDoc.FirstOrDefault
            '                    matbang.DSDam.Add(New cls_Dam With {
            '                                             .Loaidam = haha,
            '                                             .Trucxet = ha.Ten,
            '                                             .LechTrucX1 = (ha.Line.StartPoint.X - beam.StartPoint.X),
            '                                             .LechTrucX2 = (ha.Line.EndPoint.X - beam.EndPoint.X),
            '                                             .LechTrucY1 = (ha.Line.StartPoint.Y - (beam.StartPoint.Y + beamktra.StartPoint.Y) / 2),
            '                                             .LechTrucY2 = (ha.Line.EndPoint.Y - (beam.EndPoint.Y + beamktra.EndPoint.Y) / 2)
            '                                             })
            '                Next

            '            End If
            '        Next
            '    Next
            'End If
            tr.Commit()
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
