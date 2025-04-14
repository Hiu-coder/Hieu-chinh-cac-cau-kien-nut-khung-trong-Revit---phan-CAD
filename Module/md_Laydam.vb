Imports System.Drawing
Imports System.Net
Imports System.Windows.Forms
Imports Autodesk.AutoCAD.ApplicationServices
Imports Autodesk.AutoCAD.DatabaseServices
Imports Autodesk.AutoCAD.EditorInput
Imports Autodesk.AutoCAD.Geometry
Imports Autodesk.AutoCAD.Runtime

Module md_Laydam

    Public Sub LayDam()
        Dim ppr As PromptSelectionResult = ed.GetSelection()
        If ppr.Status <> PromptStatus.OK Then
            ed.WriteMessage("\nKhông có đối tượng nào được chọn.")
            Return
        End If


        Using tr As Transaction = db.TransactionManager.StartTransaction()

            Dim beamLines As New List(Of Line)()
            Dim tendam As New List(Of DBText)

            ' Lấy tất cả các Line có layer "DAM"
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
            For Each a In loaidam
                Dim dlg As New Nhapsolieudam
                dlg.lbLoaidam.Text = a
                dlg.ShowDialog()
            Next
            For Each trucxet In trucchung
                Dim tamtruc As New Point3d((trucxet.StartPoint.X + trucxet.EndPoint.X) / 2, (trucxet.StartPoint.Y + trucxet.EndPoint.Y) / 2, 0)
                ed.WriteMessage(vbCrLf & $"--- Đang xử lý trục : {trucxet.StartPoint} -> {trucxet.EndPoint}")
                Dim damphai As New List(Of Line)
                Dim damtrai As New List(Of Line)
                For Each dam In beamLines
                    If Ktrass(dam, trucxet) = True And Math.Abs(dam.StartPoint.Y - trucxet.StartPoint.Y) < 500 And Math.Abs(trucxet.StartPoint.Y - trucxet.EndPoint.Y) < 0.01 Then

                        If (dam.StartPoint.Y - trucxet.StartPoint.Y) > 0 Then
                            damphai.Add(dam)
                            ed.WriteMessage(vbCrLf & $"--- dầm phải thêm : {dam.StartPoint} -> {dam.EndPoint}")
                        ElseIf (dam.StartPoint.Y - trucxet.StartPoint.Y) < 0 Then
                            damtrai.Add(dam)
                            ed.WriteMessage(vbCrLf & $"--- dầm trái thêm : {dam.StartPoint} -> {dam.EndPoint}")
                        End If
                    ElseIf Ktrass(dam, trucxet) = True And Math.Abs(dam.StartPoint.X - trucxet.StartPoint.X) < 500 And Math.Abs(trucxet.StartPoint.X - trucxet.EndPoint.X) < 0.01 Then

                        If (dam.StartPoint.X - trucxet.StartPoint.X) > 0 Then
                            damphai.Add(dam)
                            ed.WriteMessage(vbCrLf & $"--- dầm phải thêm : {dam.StartPoint} -> {dam.EndPoint}")
                        ElseIf (dam.StartPoint.X - trucxet.StartPoint.X) < 0 Then
                            damtrai.Add(dam)
                            ed.WriteMessage(vbCrLf & $"--- dầm trái thêm : {dam.StartPoint} -> {dam.EndPoint}")
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
                If damphai.Count > damtrai.Count Then

                    For Each dp In damphai


                        Dim dau = Tinhtoadotamtruc(dp, damtrai.First, 1)
                        Dim cuoi = Tinhtoadotamtruc(dp, damtrai.First, 2)
                        matbang.DSDam.Add(New cls_Dam With {
                                    .Ten = ten,
                                    .Dau = New cls_Diem() With {.X = dau.X, .Y = dau.Y, .Z = dau.Z},
                                    .Cuoi = New cls_Diem() With {.X = cuoi.X, .Y = cuoi.Y, .Z = cuoi.Z},
                                    .Cao = haha.Cao,
                                    .Rong = Math.Abs(dp.StartPoint.Y - damtrai.First.StartPoint.Y),
                                    .LechTruc = Math.Abs((Math.Abs(dp.StartPoint.Y - damtrai.First.StartPoint.Y) / 2) - Math.Abs(trucxet.StartPoint.Y - dp.StartPoint.Y))})
                    Next
                Else
                    For Each dt In damtrai
                        Dim dau = Tinhtoadotamtruc(dt, damphai.First, 1)
                        Dim cuoi = Tinhtoadotamtruc(dt, damphai.First, 2)
                        matbang.DSDam.Add(New cls_Dam With {
                                    .Ten = ten,
                                    .Dau = New cls_Diem() With {.X = dau.X, .Y = dau.Y, .Z = dau.Z},
                                    .Cuoi = New cls_Diem() With {.X = cuoi.X, .Y = cuoi.Y, .Z = cuoi.Z},
                                    .Cao = haha.Cao,
                                    .Rong = Math.Abs(dt.StartPoint.Y - damphai.First.StartPoint.Y),
                                    .LechTruc = Math.Abs((dt.StartPoint.Y + damphai.First.StartPoint.Y) / 2 - trucxet.StartPoint.Y)})
                    Next
                End If
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
End Module
