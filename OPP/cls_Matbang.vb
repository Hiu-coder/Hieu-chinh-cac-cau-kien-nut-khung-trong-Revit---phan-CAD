﻿Imports Autodesk.AutoCAD.Geometry
Imports System.Xml.Serialization
<Serializable>
Public Class cls_CongTrinh
    <XmlElement("MatBang")>
    Public Property CongTrinh As List(Of cls_Matbang)
    Public Sub New()
        CongTrinh = New List(Of cls_Matbang)
    End Sub
End Class
<Serializable>
<XmlRoot("-----------MặtBằng-----------")>
Public Class cls_Matbang
    <XmlElement("Tầng")>
    Public Property Tang As Integer
    <XmlElement("CaoĐộ")>
    Public Property CaoDo As Double
    <XmlElement("TầngKetThuc")>
    Public Property TangKT As Integer
    <XmlElement("CaoĐộKetThuc")>
    Public Property CaoDoKT As Double
    <XmlElement("DanhSáchDầm")>
    Public Property DSDam As List(Of cls_Dam)
    <XmlElement("CácLoạiDầm")>
    Public Property LoaiDam As List(Of cls_LoaiDam)
    <XmlElement("DanhSáchCột")>
    Public Property DSCot As List(Of cls_Cot)
    <XmlElement("CácLoạiCot")>
    Public Property LoaiCot As List(Of cls_LoaiCot)
    <XmlElement("LướiTrục")>
    Public Property LuoiTruc As cls_LuoiTruc
    Public Sub New()
        LuoiTruc = New cls_LuoiTruc
        DSDam = New List(Of cls_Dam)
        LoaiDam = New List(Of cls_LoaiDam)
        DSCot = New List(Of cls_Cot)
        LoaiCot = New List(Of cls_LoaiCot)
    End Sub
End Class
Public Class MatBangForDtgv
    Public Property Tang As Integer
    Public Property CaoDo As Double
    Public Property TangKT As Integer
    Public Property CaoDoKT As Double
    Public Property SoLuongDam As Integer
    Public Property SoLuongCot As Integer
End Class
