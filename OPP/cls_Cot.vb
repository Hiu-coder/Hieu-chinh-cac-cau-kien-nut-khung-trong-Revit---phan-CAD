
Imports Autodesk.AutoCAD.Geometry
Imports System.Xml.Serialization



<Serializable>
<XmlRoot("------")>
Public Class cls_Cot
    <XmlElement("Ten")>
    Public Property Ten As String
    <XmlElement("Diemdat")>
    Public Property Diemdat As cls_Diem
    <XmlElement("Tangdau")>
    Public Property Tangdau As Integer
    <XmlElement("Tangcuoi")>
    Public Property Tangcuoi As Integer
    <XmlElement("Lechgiaotruc")>
    Public Property Lechgiaotruc As cls_Lech
End Class
<Serializable>
Public Class cls_Lech
    <XmlElement("X")>
    Public Property X As Double
    <XmlElement("Y")>
    Public Property Y As Double
End Class
