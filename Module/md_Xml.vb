Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Xml.Serialization

Module md_Xml

    Sub Ghixml(fileluu As String, doituong As cls_CongTrinh)
        ' Xuất XML ra tệp
        Dim serializer As New XmlSerializer(GetType(cls_CongTrinh))
        Using writer As New StreamWriter(fileluu)
            serializer.Serialize(writer, doituong)
        End Using
    End Sub

End Module
