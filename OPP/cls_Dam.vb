
Imports Autodesk.AutoCAD.Geometry
Imports System.Xml.Serialization

<Serializable>
<XmlRoot("--------")>
Public Class cls_Dam
    <XmlElement("LoaiDam")>
    Public Property Loaidam As cls_LoaiDam
    <XmlElement("TrucXet")>
    Public Property Trucxet As String
    <XmlElement("LechTrucY1")>
    Public Property LechTrucY1 As Double
    <XmlElement("LechTrucY2")>
    Public Property LechTrucY2 As Double
    <XmlElement("LechTrucX1")>
    Public Property LechTrucX1 As Double
    <XmlElement("LechTrucX2")>
    Public Property LechTrucX2 As Double
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
Public Class cls_DamforDtgv
    Public Property Loai As String
    Public Property Trucxet As String
End Class
