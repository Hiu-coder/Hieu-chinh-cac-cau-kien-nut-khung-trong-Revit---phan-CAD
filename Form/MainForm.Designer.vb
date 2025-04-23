<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.lbTang = New System.Windows.Forms.Label()
        Me.lbCaodo = New System.Windows.Forms.Label()
        Me.btnMain = New System.Windows.Forms.Button()
        Me.txtCaoDo = New System.Windows.Forms.TextBox()
        Me.txtTang = New System.Windows.Forms.TextBox()
        Me.lbMatbang = New System.Windows.Forms.Label()
        Me.cbbMatbang = New System.Windows.Forms.ComboBox()
        Me.rdbDam = New System.Windows.Forms.RadioButton()
        Me.rdbLuoitruc = New System.Windows.Forms.RadioButton()
        Me.rdbCot = New System.Windows.Forms.RadioButton()
        Me.btnLaybanve = New System.Windows.Forms.Button()
        Me.dtgvLoai = New System.Windows.Forms.DataGridView()
        Me.dtgvCaukien = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.dtgvLoai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgvCaukien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbTang
        '
        Me.lbTang.AutoSize = True
        Me.lbTang.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lbTang.Location = New System.Drawing.Point(293, 5)
        Me.lbTang.Name = "lbTang"
        Me.lbTang.Size = New System.Drawing.Size(83, 36)
        Me.lbTang.TabIndex = 8
        Me.lbTang.Text = "Tầng"
        '
        'lbCaodo
        '
        Me.lbCaodo.AutoSize = True
        Me.lbCaodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lbCaodo.Location = New System.Drawing.Point(293, 55)
        Me.lbCaodo.Name = "lbCaodo"
        Me.lbCaodo.Size = New System.Drawing.Size(185, 36)
        Me.lbCaodo.TabIndex = 9
        Me.lbCaodo.Text = "Cao độ (mm)"
        '
        'btnMain
        '
        Me.btnMain.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnMain.Location = New System.Drawing.Point(477, 99)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(107, 36)
        Me.btnMain.TabIndex = 12
        Me.btnMain.Text = "Thêm"
        Me.btnMain.UseVisualStyleBackColor = False
        '
        'txtCaoDo
        '
        Me.txtCaoDo.BackColor = System.Drawing.SystemColors.Info
        Me.txtCaoDo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtCaoDo.Location = New System.Drawing.Point(477, 52)
        Me.txtCaoDo.Name = "txtCaoDo"
        Me.txtCaoDo.Size = New System.Drawing.Size(107, 41)
        Me.txtCaoDo.TabIndex = 11
        '
        'txtTang
        '
        Me.txtTang.BackColor = System.Drawing.SystemColors.Info
        Me.txtTang.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtTang.Location = New System.Drawing.Point(477, 5)
        Me.txtTang.Name = "txtTang"
        Me.txtTang.Size = New System.Drawing.Size(107, 41)
        Me.txtTang.TabIndex = 10
        '
        'lbMatbang
        '
        Me.lbMatbang.AutoSize = True
        Me.lbMatbang.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lbMatbang.Location = New System.Drawing.Point(6, 11)
        Me.lbMatbang.Name = "lbMatbang"
        Me.lbMatbang.Size = New System.Drawing.Size(112, 29)
        Me.lbMatbang.TabIndex = 13
        Me.lbMatbang.Text = "Mặt bằng"
        '
        'cbbMatbang
        '
        Me.cbbMatbang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cbbMatbang.FormattingEnabled = True
        Me.cbbMatbang.Location = New System.Drawing.Point(124, 8)
        Me.cbbMatbang.Name = "cbbMatbang"
        Me.cbbMatbang.Size = New System.Drawing.Size(103, 33)
        Me.cbbMatbang.TabIndex = 14
        '
        'rdbDam
        '
        Me.rdbDam.AutoSize = True
        Me.rdbDam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.rdbDam.Location = New System.Drawing.Point(10, 152)
        Me.rdbDam.Name = "rdbDam"
        Me.rdbDam.Size = New System.Drawing.Size(74, 29)
        Me.rdbDam.TabIndex = 15
        Me.rdbDam.TabStop = True
        Me.rdbDam.Text = "Dầm"
        Me.rdbDam.UseVisualStyleBackColor = True
        '
        'rdbLuoitruc
        '
        Me.rdbLuoitruc.AutoSize = True
        Me.rdbLuoitruc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.rdbLuoitruc.Location = New System.Drawing.Point(156, 152)
        Me.rdbLuoitruc.Name = "rdbLuoitruc"
        Me.rdbLuoitruc.Size = New System.Drawing.Size(107, 29)
        Me.rdbLuoitruc.TabIndex = 16
        Me.rdbLuoitruc.TabStop = True
        Me.rdbLuoitruc.Text = "Lưới trục"
        Me.rdbLuoitruc.UseVisualStyleBackColor = True
        '
        'rdbCot
        '
        Me.rdbCot.AutoSize = True
        Me.rdbCot.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.rdbCot.Location = New System.Drawing.Point(87, 152)
        Me.rdbCot.Name = "rdbCot"
        Me.rdbCot.Size = New System.Drawing.Size(64, 29)
        Me.rdbCot.TabIndex = 17
        Me.rdbCot.TabStop = True
        Me.rdbCot.Text = "Cột"
        Me.rdbCot.UseVisualStyleBackColor = True
        '
        'btnLaybanve
        '
        Me.btnLaybanve.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLaybanve.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnLaybanve.Location = New System.Drawing.Point(283, 147)
        Me.btnLaybanve.Name = "btnLaybanve"
        Me.btnLaybanve.Size = New System.Drawing.Size(158, 36)
        Me.btnLaybanve.TabIndex = 19
        Me.btnLaybanve.Text = "Hoàn thành"
        Me.btnLaybanve.UseVisualStyleBackColor = False
        '
        'dtgvLoai
        '
        Me.dtgvLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvLoai.Location = New System.Drawing.Point(331, 0)
        Me.dtgvLoai.Name = "dtgvLoai"
        Me.dtgvLoai.RowHeadersWidth = 51
        Me.dtgvLoai.RowTemplate.Height = 24
        Me.dtgvLoai.Size = New System.Drawing.Size(239, 312)
        Me.dtgvLoai.TabIndex = 20
        '
        'dtgvCaukien
        '
        Me.dtgvCaukien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvCaukien.Location = New System.Drawing.Point(3, 0)
        Me.dtgvCaukien.Name = "dtgvCaukien"
        Me.dtgvCaukien.RowHeadersWidth = 51
        Me.dtgvCaukien.RowTemplate.Height = 24
        Me.dtgvCaukien.Size = New System.Drawing.Size(326, 312)
        Me.dtgvCaukien.TabIndex = 18
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dtgvCaukien)
        Me.Panel1.Controls.Add(Me.dtgvLoai)
        Me.Panel1.Location = New System.Drawing.Point(11, 201)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(573, 312)
        Me.Panel1.TabIndex = 21
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 518)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnLaybanve)
        Me.Controls.Add(Me.rdbCot)
        Me.Controls.Add(Me.rdbLuoitruc)
        Me.Controls.Add(Me.rdbDam)
        Me.Controls.Add(Me.cbbMatbang)
        Me.Controls.Add(Me.lbMatbang)
        Me.Controls.Add(Me.btnMain)
        Me.Controls.Add(Me.txtCaoDo)
        Me.Controls.Add(Me.lbCaodo)
        Me.Controls.Add(Me.txtTang)
        Me.Controls.Add(Me.lbTang)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        CType(Me.dtgvLoai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgvCaukien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbTang As Windows.Forms.Label
    Friend WithEvents lbCaodo As Windows.Forms.Label
    Friend WithEvents txtCaoDo As Windows.Forms.TextBox
    Friend WithEvents txtTang As Windows.Forms.TextBox
    Friend WithEvents btnMain As Windows.Forms.Button
    Friend WithEvents lbMatbang As Windows.Forms.Label
    Friend WithEvents cbbMatbang As Windows.Forms.ComboBox
    Friend WithEvents rdbDam As Windows.Forms.RadioButton
    Friend WithEvents rdbLuoitruc As Windows.Forms.RadioButton
    Friend WithEvents rdbCot As Windows.Forms.RadioButton
    Friend WithEvents btnLaybanve As Windows.Forms.Button
    Friend WithEvents dtgvLoai As Windows.Forms.DataGridView
    Friend WithEvents dtgvCaukien As Windows.Forms.DataGridView
    Friend WithEvents Panel1 As Windows.Forms.Panel
End Class
