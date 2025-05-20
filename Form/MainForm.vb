Imports System.Runtime.Remoting.Messaging
Imports System.Windows.Forms
Imports Autodesk.AutoCAD.DatabaseServices
Imports Autodesk.AutoCAD.EditorInput

Public Class MainForm
    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        If layerCot IsNot Nothing AndAlso layerDam IsNot Nothing AndAlso layerLuoiTruc IsNot Nothing Then
            Dim matbang As New cls_Matbang
            Dim pso As New PromptSelectionOptions()
            pso.MessageForAdding = "Chọn vùng chứa các cấu kiện và lưới trục của cấu kiện:"
            ppr = ed.GetSelection(pso)
            If ppr.Status <> PromptStatus.OK Then
                ed.WriteMessage("\nKhông có đối tượng nào được chọn.")
                Return
            End If
            md_Layluoitruc.LayLuoiTruc(matbang)
            If matbang.LuoiTruc Is Nothing Then
                ed.WriteMessage("\nKhông có đối tượng lưới trục nào được chọn.")
                Return
            End If
            md_Laydam.LayDam(matbang)
            If matbang.DSDam.Count = 0 Then
                ed.WriteMessage("\nKhông có đối tượng dầm nào được chọn.")
                Return
            End If
            If matbang.LoaiDam.Count = 0 Then
                ed.WriteMessage("\nDầm chưa được đặt tên.")
                Return
            End If
            md_Laycot.LayCot(matbang)
            If matbang.DSCot.Count = 0 Then
                ed.WriteMessage("\nKhông có đối tượng cột nào được chọn.")
                Return
            End If
            If matbang.LoaiCot.Count = 0 Then
                ed.WriteMessage("\nCột chưa được đặt tên.")
                Return
            End If
            Dim dlg As New GhiThongSoTang(matbang)
            dlg.ShowDialog()
            dlg.BringToFront()
            congtrinh.CongTrinh.Add(matbang)
            dtgvMatBang.DataSource = Nothing
            dtgvMatBang.Rows.Clear()
            dtgvMatBang.Columns.Clear()

            dtgvMatBang.DataSource = congtrinh.CongTrinh
            dtgvMatBang.Columns("TangKT").Visible = False
            dtgvMatBang.Columns("CaoDoKT").Visible = False
            dtgvMatBang.Columns("LuoiTruc").Visible = False
        Else
            layerLuoiTruc = "TRUC"
            layerDam = "DAM"
            layerCot = "COT"
            Dim dslayer As New List(Of cls_Layer) From {
                New cls_Layer With {.Caukien = "LuoiTruc", .TenLayer = layerLuoiTruc},
                New cls_Layer With {.Caukien = "Cot", .TenLayer = layerCot},
                New cls_Layer With {.Caukien = "Dam", .TenLayer = layerDam}
            }
            dtgvLayer.DataSource = dslayer
            Return
        End If
    End Sub

    Private Sub btnLaybanve_Click(sender As Object, e As EventArgs) Handles btnLaybanve.Click
        md_Xml.Ghixml("D:\NCKH\LaybanveCAD_ver2\MATBANG.xml", congtrinh)
        ed.WriteMessage(vbLf & "Xuất dữ liệu thành công")
        Me.Close()
    End Sub

    Private Sub rdbDam_CheckedChanged(sender As Object, e As EventArgs) Handles rdbDam.CheckedChanged

        If haha IsNot Nothing Then

            If rdbDam.Checked = True Then
                'Clear va gan data cho dtgv
                dtgvCaukien.DataSource = Nothing
                dtgvCaukien.Rows.Clear()
                dtgvCaukien.Columns.Clear()
                dtgvLoai.DataSource = Nothing
                dtgvLoai.Rows.Clear()
                dtgvLoai.Columns.Clear()
                Dim hoho As New List(Of cls_DamforDtgv)
                For Each hihi In haha.DSDam
                    hoho.Add(New cls_DamforDtgv With {.Loai = hihi.Loaidam.Ten, .Trucxet = hihi.Trucxet})
                Next
                dtgvCaukien.DataSource = hoho
                dtgvLoai.DataSource = haha.LoaiDam
                'tao cot moi va Gán giá trị cho cột STT
                If Not dtgvCaukien.Columns.Contains("STT") Then
                    Dim sttCol As New DataGridViewTextBoxColumn()
                    sttCol.Name = "STT"
                    sttCol.HeaderText = "STT"
                    sttCol.ReadOnly = True
                    dtgvCaukien.Columns.Insert(0, sttCol) ' Thêm vào vị trí đầu
                End If
                For i As Integer = 0 To dtgvCaukien.Rows.Count - 1
                    dtgvCaukien.Rows(i).Cells("STT").Value = i + 1
                Next
            ElseIf rdbCot.Checked = True Then
                'Clear va gan data cho dtgv
                dtgvCaukien.DataSource = Nothing
                dtgvCaukien.Rows.Clear()
                dtgvCaukien.Columns.Clear()
                dtgvLoai.DataSource = Nothing
                dtgvLoai.Rows.Clear()
                dtgvLoai.Columns.Clear()
                Dim hoho As New List(Of cls_CotforDtgv)
                For Each hihi In haha.DSCot
                    hoho.Add(New cls_CotforDtgv With {.Loai = hihi.Loai.Ten, .DiemDat = hihi.Diemdat})
                Next
                dtgvCaukien.DataSource = hoho

                dtgvLoai.DataSource = haha.LoaiCot
                'tao cot moi va Gán giá trị cho cột STT
                If Not dtgvCaukien.Columns.Contains("STT") Then
                    Dim sttCol As New DataGridViewTextBoxColumn()
                    sttCol.Name = "STT"
                    sttCol.HeaderText = "STT"
                    sttCol.ReadOnly = True
                    dtgvCaukien.Columns.Insert(0, sttCol) ' Thêm vào vị trí đầu
                End If

                ' Gán giá trị cho cột STT
                For i As Integer = 0 To dtgvCaukien.Rows.Count - 1
                    dtgvCaukien.Rows(i).Cells("STT").Value = i + 1
                Next
            End If
        End If
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click

    End Sub

    Private Sub dtgvMatBang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvMatBang.CellClick
        Dim row = dtgvMatBang.Rows(e.RowIndex)
        haha = Nothing
        haha = congtrinh.CongTrinh.FirstOrDefault(Function(x) (Convert.ToString(x.Tang)) = Convert.ToString(row.Cells("Tang").Value))
        If dtgvCaukien.Rows IsNot Nothing And dtgvCaukien.Columns IsNot Nothing Then
            dtgvCaukien.DataSource = Nothing
            dtgvCaukien.Columns.Clear()
            dtgvCaukien.Rows.Clear()
            dtgvLoai.DataSource = Nothing
            dtgvLoai.Columns.Clear()
            dtgvLoai.Rows.Clear()
            rdbDam.Checked = False
            rdbCot.Checked = False
        End If
    End Sub

    Private Sub btnThemLayer_Click(sender As Object, e As EventArgs) Handles btnThemLayer.Click
        Dim dslayer As New List(Of cls_Layer)
        Dim peo1 As New PromptEntityOptions(vbLf & "Chọn một đối tượng DÂM:")
        Dim per1 As PromptEntityResult = ed.GetEntity(peo1)
        If per1.Status <> PromptStatus.OK Then
            ed.WriteMessage(vbLf & "Không có đối tượng nào được chọn.")
            Return
        End If
        Using tr As Transaction = db.TransactionManager.StartTransaction()
            Dim ent As Entity = TryCast(tr.GetObject(per1.ObjectId, OpenMode.ForRead), Entity)
            If ent IsNot Nothing Then
                Dim layer = New cls_Layer With {.Caukien = "DAM", .TenLayer = ent.Layer}
                layerDam = ent.Layer
                dslayer.Add(layer)
            Else
                ed.WriteMessage(vbLf & "Không thể đọc đối tượng.")
            End If
            tr.Commit()
        End Using

        Dim peo2 As New PromptEntityOptions(vbLf & "Chọn một đối tượng CỘT:")
        Dim per2 As PromptEntityResult = ed.GetEntity(peo2)
        If per2.Status <> PromptStatus.OK Then
            ed.WriteMessage(vbLf & "Không có đối tượng nào được chọn.")
            Return
        End If
        Using tr As Transaction = db.TransactionManager.StartTransaction()
            Dim ent As Entity = TryCast(tr.GetObject(per2.ObjectId, OpenMode.ForRead), Entity)
            If ent IsNot Nothing Then
                Dim layer = New cls_Layer With {.Caukien = "COT", .TenLayer = ent.Layer}
                layerCot = ent.Layer
                dslayer.Add(layer)
            Else
                ed.WriteMessage(vbLf & "Không thể đọc đối tượng.")
            End If
            tr.Commit()
        End Using

        Dim peo3 As New PromptEntityOptions(vbLf & "Chọn một đối tượng LƯỚI TRỤC:")
        Dim per3 As PromptEntityResult = ed.GetEntity(peo3)
        If per3.Status <> PromptStatus.OK Then
            ed.WriteMessage(vbLf & "Không có đối tượng nào được chọn.")
            Return
        End If
        Using tr As Transaction = db.TransactionManager.StartTransaction()
            Dim ent As Entity = TryCast(tr.GetObject(per3.ObjectId, OpenMode.ForRead), Entity)
            If ent IsNot Nothing Then
                Dim layer = New cls_Layer With {.Caukien = "LUOITRUC", .TenLayer = ent.Layer}
                layerLuoiTruc = ent.Layer
                dslayer.Add(layer)
            Else
                ed.WriteMessage(vbLf & "Không thể đọc đối tượng.")
            End If
            tr.Commit()
        End Using
        If layerLuoiTruc Is Nothing Then
            layerLuoiTruc = "TRUC"
        End If
        If layerDam Is Nothing Then
            layerDam = "DAM"
        End If
        If layerCot Is Nothing Then
            layerCot = "COT"
        End If
        dtgvLayer.DataSource = Nothing
        dtgvLayer.Rows.Clear()
        dtgvLayer.Columns.Clear()
        dtgvLayer.DataSource = dslayer
    End Sub

    Private Sub btnXoaLayer_Click(sender As Object, e As EventArgs) Handles btnXoaLayer.Click
        dtgvLayer.DataSource = Nothing
        dtgvLayer.Rows.Clear()
        dtgvLayer.Columns.Clear()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class