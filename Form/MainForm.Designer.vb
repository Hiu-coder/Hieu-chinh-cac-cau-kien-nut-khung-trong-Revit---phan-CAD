<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.lb4 = New System.Windows.Forms.Label()
        Me.pibTest = New System.Windows.Forms.PictureBox()
        Me.lbTang = New System.Windows.Forms.Label()
        Me.lbCaodo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnMain = New System.Windows.Forms.Button()
        Me.txtCaoDo = New System.Windows.Forms.TextBox()
        Me.txtTang = New System.Windows.Forms.TextBox()
        CType(Me.pibTest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lb4
        '
        Me.lb4.AutoSize = True
        Me.lb4.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.lb4.Font = New System.Drawing.Font("Arial", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lb4.Location = New System.Drawing.Point(689, 31)
        Me.lb4.Name = "lb4"
        Me.lb4.Size = New System.Drawing.Size(160, 42)
        Me.lb4.TabIndex = 6
        Me.lb4.Text = "Bản Test"
        Me.lb4.Visible = False
        '
        'pibTest
        '
        Me.pibTest.Location = New System.Drawing.Point(361, 79)
        Me.pibTest.Name = "pibTest"
        Me.pibTest.Size = New System.Drawing.Size(828, 538)
        Me.pibTest.TabIndex = 7
        Me.pibTest.TabStop = False
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.GroupBox1.Controls.Add(Me.btnMain)
        Me.GroupBox1.Controls.Add(Me.txtCaoDo)
        Me.GroupBox1.Controls.Add(Me.txtTang)
        Me.GroupBox1.Controls.Add(Me.lbCaodo)
        Me.GroupBox1.Controls.Add(Me.lbTang)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(343, 538)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mặt bằng"
        '
        'btnMain
        '
        Me.btnMain.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnMain.Location = New System.Drawing.Point(64, 169)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(210, 48)
        Me.btnMain.TabIndex = 12
        Me.btnMain.Text = "Lấy bản vẽ"
        Me.btnMain.UseVisualStyleBackColor = False
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
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1231, 633)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pibTest)
        Me.Controls.Add(Me.lb4)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        CType(Me.pibTest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lb4 As Windows.Forms.Label
    Friend WithEvents pibTest As Windows.Forms.PictureBox
    Friend WithEvents lbTang As Windows.Forms.Label
    Friend WithEvents lbCaodo As Windows.Forms.Label
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents txtCaoDo As Windows.Forms.TextBox
    Friend WithEvents txtTang As Windows.Forms.TextBox
    Friend WithEvents btnMain As Windows.Forms.Button
End Class
