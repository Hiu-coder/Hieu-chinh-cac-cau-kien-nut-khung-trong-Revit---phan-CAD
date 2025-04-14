Imports System.Windows.Forms

Public Class Chonnoichuaxml
    Private Sub btnXml_Click(sender As Object, e As EventArgs) Handles btnXml.Click
        Dim dlg As New OpenFileDialog()
        If dlg.ShowDialog() = DialogResult.OK Then
            Dim fileName As String
            fileName = dlg.FileName
            filePath = fileName
        End If
        Me.Close()
    End Sub
    Private Sub txtXml_KeyDown(sender As Object, e As KeyEventArgs) Handles txtXml.KeyDown
        If e.KeyCode = Keys.Enter Then
            filePath = Convert.ToString(txtXml)
        End If
    End Sub
End Class