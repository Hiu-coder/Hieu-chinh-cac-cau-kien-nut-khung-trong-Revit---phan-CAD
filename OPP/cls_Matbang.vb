Imports Autodesk.AutoCAD.Geometry
Imports System.Xml.Serialization
<Serializable>
<XmlRoot("-----------MặtBằng-----------")>
Public Class cls_Matbang
    <XmlElement("Tầng")>
    Public Property Tang As Double
    <XmlElement("CaoĐộ")>
    Public Property CaoDo As Double
    <XmlElement("DanhSáchDầm")>
    Public Property DSDam As List(Of cls_Dam)
    <XmlElement("CácLoạiDầm")>
    Public Property LoaiDam As List(Of cls_LoaiDam)
    <XmlElement("DanhSáchCột")>
    Public Property DSCot As List(Of cls_Cot)
    <XmlElement("LướiTrục")>
    Public Property LuoiTruc As cls_LuoiTruc
    Public Sub New()
        LuoiTruc = New cls_LuoiTruc
        DSDam = New List(Of cls_Dam)
        LoaiDam = New List(Of cls_LoaiDam)
        DSCot = New List(Of cls_Cot)
    End Sub
End Class
