<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Chontangketthuccuacot
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.txtCaoDo = New System.Windows.Forms.TextBox()
        Me.txtTang = New System.Windows.Forms.TextBox()
        Me.lbCaodo = New System.Windows.Forms.Label()
        Me.lbTang = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.GroupBox1.Controls.Add(Me.btnOK)
        Me.GroupBox1.Controls.Add(Me.txtCaoDo)
        Me.GroupBox1.Controls.Add(Me.txtTang)
        Me.GroupBox1.Controls.Add(Me.lbCaodo)
        Me.GroupBox1.Controls.Add(Me.lbTang)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(401, 157)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Chọn tầng kết thúc cột"
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnOK.Location = New System.Drawing.Point(323, 80)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(72, 41)
        Me.btnOK.TabIndex = 12
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'txtCaoDo
        '
        Me.txtCaoDo.BackColor = System.Drawing.SystemColors.Info
        Me.txtCaoDo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtCaoDo.Location = New System.Drawing.Point(197, 101)
        Me.txtCaoDo.Name = "txtCaoDo"
        Me.txtCaoDo.Size = New System.Drawing.Size(100, 41)
        Me.txtCaoDo.TabIndex = 11
        '
        'txtTang
        '
        Me.txtTang.BackColor = System.Drawing.SystemColors.Info
        Me.txtTang.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtTang.Location = New System.Drawing.Point(197, 54)
        Me.txtTang.Name = "txtTang"
        Me.txtTang.Size = New System.Drawing.Size(100, 41)
        Me.txtTang.TabIndex = 10
        '
        'lbCaodo
        '
        Me.lbCaodo.AutoSize = True
        Me.lbCaodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lbCaodo.Location = New System.Drawing.Point(6, 104)
        Me.lbCaodo.Name = "lbCaodo"
        Me.lbCaodo.Size = New System.Drawing.Size(185, 36)
        Me.lbCaodo.TabIndex = 9
        Me.lbCaodo.Text = "Cao độ (mm)"
        '
        'lbTang
        '
        Me.lbTang.AutoSize = True
        Me.lbTang.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lbTang.Location = New System.Drawing.Point(6, 54)
        Me.lbTang.Name = "lbTang"
        Me.lbTang.Size = New System.Drawing.Size(83, 36)
        Me.lbTang.TabIndex = 8
        Me.lbTang.Text = "Tầng"
        '
        'Chontangketthuccuacot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 178)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Chontangketthuccuacot"
        Me.Text = "Chontangketthuccuacot"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents btnOK As Windows.Forms.Button
    Friend WithEvents txtCaoDo As Windows.Forms.TextBox
    Friend WithEvents txtTang As Windows.Forms.TextBox
    Friend WithEvents lbCaodo As Windows.Forms.Label
    Friend WithEvents lbTang As Windows.Forms.Label
End Class
