Imports System.Runtime.Remoting.Messaging
Imports System.Windows.Forms
Imports Autodesk.AutoCAD.DatabaseServices
Imports Autodesk.AutoCAD.EditorInput

Public Class MainForm
    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        Dim matbang As New cls_Matbang
        matbang.Tang = Convert.ToDouble(txtTang.Text)
        matbang.CaoDo = Convert.ToDouble(txtCaoDo.Text)
        Dim pso As New PromptSelectionOptions()
        pso.MessageForAdding = "Chọn vùng chứa các cấu kiện và lươi trục của cấu kiện:"
        ppr = ed.GetSelection(pso)
        If ppr.Status <> PromptStatus.OK Then
            ed.WriteMessage("\nKhông có đối tượng nào được chọn.")
            Return
        End If
        Dim dlg As New Chontangketthuc(matbang)
        dlg.Show()
        md_Layluoitruc.LayLuoiTruc(matbang)
        md_Laydam.LayDam(matbang)
        md_Laycot.LayCot(matbang)
        cbbMatbang.Items.Add("Tầng " + Convert.ToString(matbang.Tang))
        congtrinh.CongTrinh.Add(matbang)
    End Sub

    Private Sub btnLaybanve_Click(sender As Object, e As EventArgs) Handles btnLaybanve.Click
        md_Xml.Ghixml("D:\NCKH\LaybanveCAD_ver2\MATBANG.xml", congtrinh)
        ed.WriteMessage(vbLf & "Xuất dữ liệu thành công")
        Me.Close()
    End Sub

    Private Sub rdbDam_CheckedChanged(sender As Object, e As EventArgs) Handles rdbDam.CheckedChanged
        Dim haha = congtrinh.CongTrinh.FirstOrDefault(Function(x) ("Tầng " + Convert.ToString(x.Tang)) = cbbMatbang.SelectedItem)
        If rdbDam.Checked = True Then
            dtgvCaukien.DataSource = Nothing
            dtgvCaukien.Rows.Clear()
            dtgvCaukien.Columns.Clear()
            dtgvLoai.DataSource = Nothing
            dtgvLoai.Rows.Clear()
            dtgvLoai.Columns.Clear()



            dtgvCaukien.DataSource = haha.DSDam

            dtgvLoai.DataSource = haha.LoaiDam
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
        ElseIf rdbCot.Checked = True Then
            dtgvCaukien.DataSource = Nothing
            dtgvCaukien.Rows.Clear()
            dtgvCaukien.Columns.Clear()
            dtgvLoai.DataSource = Nothing
            dtgvLoai.Rows.Clear()
            dtgvLoai.Columns.Clear()



            dtgvCaukien.DataSource = haha.DSCot

            dtgvLoai.DataSource = haha.LoaiCot
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

    End Sub

End Class