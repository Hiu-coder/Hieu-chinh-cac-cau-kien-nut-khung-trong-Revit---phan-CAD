
Imports Autodesk.AutoCAD.Geometry
Imports System.Xml.Serialization



<Serializable>
<XmlRoot("------")>
Public Class cls_Cot
    <XmlElement("Ten")>
    Public Property Ten As String
    <XmlElement("Diemdat")>
    Public Property Diemdat As cls_Diem
    <XmlElement("Lechgiaotruc")>
    Public Property Lechgiaotruc As cls_Lech
End Class
<Serializable>
Public Class cls_LoaiCot
    <XmlElement("Tên")>
    Public Property Ten As String
    <XmlElement("Cao")>
    Public Property Cao As Double
    <XmlElement("Rộng")>
    Public Property Rong As Double
    Public Sub New()

    End Sub
End Class
<Serializable>
Public Class cls_Lech
    <XmlElement("X")>
    Public Property X As Double
    <XmlElement("Y")>
    Public Property Y As Double
End Class
