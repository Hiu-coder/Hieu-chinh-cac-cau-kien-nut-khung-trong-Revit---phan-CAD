Imports Autodesk.AutoCAD.Geometry
Imports System.Xml.Serialization
Imports Autodesk.AutoCAD.DatabaseServices
<Serializable>
<XmlRoot("LuoiTruc")>
Public Class cls_LuoiTruc
    <XmlElement("TrucDoc")>
    Public Property TrucDoc As List(Of cls_TrucDoc)
    <XmlElement("TrucNgang")>
    Public Property TrucNgang As List(Of cls_TrucNgang)
    Public Property DiemGiao As List(Of cls_DiemGiao)

    ' Constructor để tránh lỗi null khi khởi tạo
    Public Sub New()
        TrucDoc = New List(Of cls_TrucDoc)()
        TrucNgang = New List(Of cls_TrucNgang)()
        DiemGiao = New List(Of cls_DiemGiao)
    End Sub
End Class
Public Class cls_DiemGiao
    Public Property Ten As String
    Public Property Toado As Point3d
End Class
Public Class cls_TrucNgang
    <XmlElement("Ten")>
    Public Property Ten As String
    <XmlElement("DiemDau")>
    Public Property DiemDau As cls_Diem
    <XmlElement("DiemCuoi")>
    Public Property DiemCuoi As cls_Diem
    <XmlIgnore>
    Public Property Line As Line
End Class

Public Class cls_TrucDoc
    <XmlElement("Ten")>
    Public Property Ten As String
    <XmlElement("DiemDau")>
    Public Property DiemDau As cls_Diem
    <XmlElement("DiemCuoi")>
    Public Property DiemCuoi As cls_Diem
    <XmlIgnore>
    Public Property Line As Line
End Class

Public Class cls_Diem
    <XmlElement("X")>
    Public Property X As Double
    <XmlElement("Y")>
    Public Property Y As Double
    <XmlElement("Z")>
    Public Property Z As Double

    ' Constructor mặc định
    Public Sub New()
    End Sub

    ' Constructor có tham số
    Public Sub New(px As Double, py As Double, pz As Double)
        X = px
        Y = py
        Z = pz
    End Sub
End Class

