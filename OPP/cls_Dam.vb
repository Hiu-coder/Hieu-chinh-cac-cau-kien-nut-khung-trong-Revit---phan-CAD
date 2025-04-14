
Imports Autodesk.AutoCAD.Geometry
Imports System.Xml.Serialization

<Serializable>
<XmlRoot("--------")>
Public Class cls_Dam
    <XmlElement("Tên")>
    Public Property Ten As String
    <XmlElement("Đầu")>
    Public Property Dau As cls_Diem
    <XmlElement("Cuối")>
    Public Property Cuoi As cls_Diem
    <XmlElement("Rộng")>
    Public Property Rong As Double
    <XmlElement("Cao")>
    Public Property Cao As Double
    <XmlElement("Lệchtrục")>
    Public Property LechTruc As Double
    Public Sub New()

    End Sub
End Class
<Serializable>
Public Class cls_LoaiDam
    <XmlElement("Tên")>
    Public Property Ten As String
    <XmlElement("Cao")>
    Public Property Cao As Double
    <XmlElement("Rộng")>
    Public Property Rong As Double
    Public Sub New()

    End Sub
End Class

