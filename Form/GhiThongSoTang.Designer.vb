<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GhiThongSoTang
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
        Me.btnMain = New System.Windows.Forms.Button()
        Me.txtCaoDo = New System.Windows.Forms.TextBox()
        Me.lbCaodo = New System.Windows.Forms.Label()
        Me.txtTang = New System.Windows.Forms.TextBox()
        Me.lbTang = New System.Windows.Forms.Label()
        Me.txtCaodomb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTangmb = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnMain
        '
        Me.btnMain.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnMain.Location = New System.Drawing.Point(196, 248)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(107, 36)
        Me.btnMain.TabIndex = 17
        Me.btnMain.Text = "Chọn"
        Me.btnMain.UseVisualStyleBackColor = False
        '
        'txtCaoDo
        '
        Me.txtCaoDo.BackColor = System.Drawing.SystemColors.Info
        Me.txtCaoDo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtCaoDo.Location = New System.Drawing.Point(196, 201)
        Me.txtCaoDo.Name = "txtCaoDo"
        Me.txtCaoDo.Size = New System.Drawing.Size(107, 41)
        Me.txtCaoDo.TabIndex = 16
        '
        'lbCaodo
        '
        Me.lbCaodo.AutoSize = True
        Me.lbCaodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lbCaodo.Location = New System.Drawing.Point(12, 204)
        Me.lbCaodo.Name = "lbCaodo"
        Me.lbCaodo.Size = New System.Drawing.Size(185, 36)
        Me.lbCaodo.TabIndex = 14
        Me.lbCaodo.Text = "Cao độ (mm)"
        '
        'txtTang
        '
        Me.txtTang.BackColor = System.Drawing.SystemColors.Info
        Me.txtTang.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtTang.Location = New System.Drawing.Point(196, 154)
        Me.txtTang.Name = "txtTang"
        Me.txtTang.Size = New System.Drawing.Size(107, 41)
        Me.txtTang.TabIndex = 15
        '
        'lbTang
        '
        Me.lbTang.AutoSize = True
        Me.lbTang.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lbTang.Location = New System.Drawing.Point(12, 154)
        Me.lbTang.Name = "lbTang"
        Me.lbTang.Size = New System.Drawing.Size(180, 36)
        Me.lbTang.TabIndex = 13
        Me.lbTang.Text = "Tầng đặt cột"
        '
        'txtCaodomb
        '
        Me.txtCaodomb.BackColor = System.Drawing.SystemColors.Info
        Me.txtCaodomb.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtCaodomb.Location = New System.Drawing.Point(196, 80)
        Me.txtCaodomb.Name = "txtCaodomb"
        Me.txtCaodomb.Size = New System.Drawing.Size(107, 41)
        Me.txtCaodomb.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 36)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Cao độ (mm)"
        '
        'txtTangmb
        '
        Me.txtTangmb.BackColor = System.Drawing.SystemColors.Info
        Me.txtTangmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtTangmb.Location = New System.Drawing.Point(196, 33)
        Me.txtTangmb.Name = "txtTangmb"
        Me.txtTangmb.Size = New System.Drawing.Size(107, 41)
        Me.txtTangmb.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 36)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Tầng thêm "
        '
        'GhiThongSoTang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 289)
        Me.Controls.Add(Me.txtCaodomb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTangmb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnMain)
        Me.Controls.Add(Me.txtCaoDo)
        Me.Controls.Add(Me.lbCaodo)
        Me.Controls.Add(Me.txtTang)
        Me.Controls.Add(Me.lbTang)
        Me.Name = "GhiThongSoTang"
        Me.Text = "Chontangketthuc"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMain As Windows.Forms.Button
    Friend WithEvents txtCaoDo As Windows.Forms.TextBox
    Friend WithEvents lbCaodo As Windows.Forms.Label
    Friend WithEvents txtTang As Windows.Forms.TextBox
    Friend WithEvents lbTang As Windows.Forms.Label
    Friend WithEvents txtCaodomb As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents txtTangmb As Windows.Forms.TextBox
    Friend WithEvents Label2 As Windows.Forms.Label
End Class
