<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chonnoichuaxml
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnXml = New System.Windows.Forms.Button()
        Me.txtXml = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnXml
        '
        Me.btnXml.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnXml.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnXml.Location = New System.Drawing.Point(260, 12)
        Me.btnXml.Name = "btnXml"
        Me.btnXml.Size = New System.Drawing.Size(30, 22)
        Me.btnXml.TabIndex = 3
        Me.btnXml.Text = "..."
        Me.btnXml.UseVisualStyleBackColor = True
        '
        'txtXml
        '
        Me.txtXml.Location = New System.Drawing.Point(12, 12)
        Me.txtXml.Name = "txtXml"
        Me.txtXml.Size = New System.Drawing.Size(242, 22)
        Me.txtXml.TabIndex = 2
        '
        'Chonnoichuaxml
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 50)
        Me.Controls.Add(Me.btnXml)
        Me.Controls.Add(Me.txtXml)
        Me.Name = "Chonnoichuaxml"
        Me.Text = "Chonnoichuaxml"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnXml As Windows.Forms.Button
    Friend WithEvents txtXml As Windows.Forms.TextBox
End Class
