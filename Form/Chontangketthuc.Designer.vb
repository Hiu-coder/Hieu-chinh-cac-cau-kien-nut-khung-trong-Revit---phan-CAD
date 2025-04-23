<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chontangketthuc
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
        Me.SuspendLayout()
        '
        'btnMain
        '
        Me.btnMain.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnMain.Location = New System.Drawing.Point(196, 105)
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
        Me.txtCaoDo.Location = New System.Drawing.Point(196, 58)
        Me.txtCaoDo.Name = "txtCaoDo"
        Me.txtCaoDo.Size = New System.Drawing.Size(107, 41)
        Me.txtCaoDo.TabIndex = 16
        '
        'lbCaodo
        '
        Me.lbCaodo.AutoSize = True
        Me.lbCaodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lbCaodo.Location = New System.Drawing.Point(12, 61)
        Me.lbCaodo.Name = "lbCaodo"
        Me.lbCaodo.Size = New System.Drawing.Size(185, 36)
        Me.lbCaodo.TabIndex = 14
        Me.lbCaodo.Text = "Cao độ (mm)"
        '
        'txtTang
        '
        Me.txtTang.BackColor = System.Drawing.SystemColors.Info
        Me.txtTang.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtTang.Location = New System.Drawing.Point(196, 11)
        Me.txtTang.Name = "txtTang"
        Me.txtTang.Size = New System.Drawing.Size(107, 41)
        Me.txtTang.TabIndex = 15
        '
        'lbTang
        '
        Me.lbTang.AutoSize = True
        Me.lbTang.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lbTang.Location = New System.Drawing.Point(12, 11)
        Me.lbTang.Name = "lbTang"
        Me.lbTang.Size = New System.Drawing.Size(83, 36)
        Me.lbTang.TabIndex = 13
        Me.lbTang.Text = "Tầng"
        '
        'Chontangketthuc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 146)
        Me.Controls.Add(Me.btnMain)
        Me.Controls.Add(Me.txtCaoDo)
        Me.Controls.Add(Me.lbCaodo)
        Me.Controls.Add(Me.txtTang)
        Me.Controls.Add(Me.lbTang)
        Me.Name = "Chontangketthuc"
        Me.Text = "Chontangketthuc"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMain As Windows.Forms.Button
    Friend WithEvents txtCaoDo As Windows.Forms.TextBox
    Friend WithEvents lbCaodo As Windows.Forms.Label
    Friend WithEvents txtTang As Windows.Forms.TextBox
    Friend WithEvents lbTang As Windows.Forms.Label
End Class
