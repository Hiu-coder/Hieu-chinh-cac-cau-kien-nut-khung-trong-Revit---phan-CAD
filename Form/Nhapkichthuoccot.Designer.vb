<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nhapkichthuoccot
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
        Me.btnOK = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCao = New System.Windows.Forms.TextBox()
        Me.txtRong = New System.Windows.Forms.TextBox()
        Me.lbLoaiCot = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(271, 68)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(100, 32)
        Me.btnOK.TabIndex = 11
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.Location = New System.Drawing.Point(237, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "b="
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.Location = New System.Drawing.Point(237, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "h="
        '
        'txtCao
        '
        Me.txtCao.Location = New System.Drawing.Point(271, 40)
        Me.txtCao.Name = "txtCao"
        Me.txtCao.Size = New System.Drawing.Size(100, 22)
        Me.txtCao.TabIndex = 8
        '
        'txtRong
        '
        Me.txtRong.Location = New System.Drawing.Point(271, 12)
        Me.txtRong.Name = "txtRong"
        Me.txtRong.Size = New System.Drawing.Size(100, 22)
        Me.txtRong.TabIndex = 7
        '
        'lbLoaiCot
        '
        Me.lbLoaiCot.AutoSize = True
        Me.lbLoaiCot.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lbLoaiCot.Location = New System.Drawing.Point(4, 11)
        Me.lbLoaiCot.Name = "lbLoaiCot"
        Me.lbLoaiCot.Size = New System.Drawing.Size(50, 29)
        Me.lbLoaiCot.TabIndex = 6
        Me.lbLoaiCot.Text = "Cot"
        '
        'Nhapkichthuoccot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 113)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCao)
        Me.Controls.Add(Me.txtRong)
        Me.Controls.Add(Me.lbLoaiCot)
        Me.Name = "Nhapkichthuoccot"
        Me.Text = "Nhapkichthuoccot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOK As Windows.Forms.Button
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents txtCao As Windows.Forms.TextBox
    Friend WithEvents txtRong As Windows.Forms.TextBox
    Friend WithEvents lbLoaiCot As Windows.Forms.Label
End Class
