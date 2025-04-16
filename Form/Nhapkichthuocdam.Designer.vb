<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nhapkichthuocdam
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
        Me.lbLoaidam = New System.Windows.Forms.Label()
        Me.txtRong = New System.Windows.Forms.TextBox()
        Me.txtCao = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbLoaidam
        '
        Me.lbLoaidam.AutoSize = True
        Me.lbLoaidam.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lbLoaidam.Location = New System.Drawing.Point(12, 9)
        Me.lbLoaidam.Name = "lbLoaidam"
        Me.lbLoaidam.Size = New System.Drawing.Size(63, 29)
        Me.lbLoaidam.TabIndex = 0
        Me.lbLoaidam.Text = "Dam"
        '
        'txtRong
        '
        Me.txtRong.Location = New System.Drawing.Point(279, 10)
        Me.txtRong.Name = "txtRong"
        Me.txtRong.Size = New System.Drawing.Size(100, 22)
        Me.txtRong.TabIndex = 1
        '
        'txtCao
        '
        Me.txtCao.Location = New System.Drawing.Point(279, 38)
        Me.txtCao.Name = "txtCao"
        Me.txtCao.Size = New System.Drawing.Size(100, 22)
        Me.txtCao.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.Location = New System.Drawing.Point(245, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "h="
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.Location = New System.Drawing.Point(245, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "b="
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(279, 66)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(100, 32)
        Me.btnOK.TabIndex = 5
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'Nhapkichthuocdam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 110)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCao)
        Me.Controls.Add(Me.txtRong)
        Me.Controls.Add(Me.lbLoaidam)
        Me.Name = "Nhapkichthuocdam"
        Me.Text = "Nhapsolieudam"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbLoaidam As Windows.Forms.Label
    Friend WithEvents txtRong As Windows.Forms.TextBox
    Friend WithEvents txtCao As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents btnOK As Windows.Forms.Button
End Class
