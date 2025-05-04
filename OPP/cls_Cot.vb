
Imports Autodesk.AutoCAD.Geometry
Imports System.Xml.Serialization

<Serializable>
<XmlRoot("------")>
Public Class cls_Cot
    <XmlElement("LoaiCot")>
    Public Property Loai As cls_LoaiCot
    <XmlElement("DiemDat")>
    Public Property Diemdat As String
    <XmlElement("LechgiaotrucX")>
    Public Property LechgiaotrucX As Double
    <XmlElement("LechgiaotrucY")>
    Public Property LechgiaotrucY As Double
    <XmlElement("Goc")>
    Public Property Goc As Double

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
Public Class cls_CotforDtgv
    Public Property Loai As String
    Public Property DiemDat As String
End Class
