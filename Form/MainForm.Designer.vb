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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.btnMain = New System.Windows.Forms.Button()
        Me.rdbDam = New System.Windows.Forms.RadioButton()
        Me.rdbCot = New System.Windows.Forms.RadioButton()
        Me.btnLaybanve = New System.Windows.Forms.Button()
        Me.dtgvCaukien = New System.Windows.Forms.DataGridView()
        Me.dtgvMatBang = New System.Windows.Forms.DataGridView()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.dtgvLoai = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtgvLayer = New System.Windows.Forms.DataGridView()
        Me.btnThemLayer = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnXoaLayer = New System.Windows.Forms.Button()
        CType(Me.dtgvCaukien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgvMatBang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgvLoai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtgvLayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnMain
        '
        Me.btnMain.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnMain.Location = New System.Drawing.Point(336, 29)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(84, 33)
        Me.btnMain.TabIndex = 12
        Me.btnMain.Text = "Thêm"
        Me.btnMain.UseVisualStyleBackColor = False
        '
        'rdbDam
        '
        Me.rdbDam.AutoSize = True
        Me.rdbDam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.rdbDam.Location = New System.Drawing.Point(219, 13)
        Me.rdbDam.Name = "rdbDam"
        Me.rdbDam.Size = New System.Drawing.Size(61, 22)
        Me.rdbDam.TabIndex = 15
        Me.rdbDam.TabStop = True
        Me.rdbDam.Text = "Dầm"
        Me.rdbDam.UseVisualStyleBackColor = True
        '
        'rdbCot
        '
        Me.rdbCot.AutoSize = True
        Me.rdbCot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.rdbCot.Location = New System.Drawing.Point(286, 13)
        Me.rdbCot.Name = "rdbCot"
        Me.rdbCot.Size = New System.Drawing.Size(53, 22)
        Me.rdbCot.TabIndex = 17
        Me.rdbCot.TabStop = True
        Me.rdbCot.Text = "Cột"
        Me.rdbCot.UseVisualStyleBackColor = True
        '
        'btnLaybanve
        '
        Me.btnLaybanve.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLaybanve.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnLaybanve.Location = New System.Drawing.Point(336, 147)
        Me.btnLaybanve.Name = "btnLaybanve"
        Me.btnLaybanve.Size = New System.Drawing.Size(84, 87)
        Me.btnLaybanve.TabIndex = 19
        Me.btnLaybanve.Text = "Hoàn thành"
        Me.btnLaybanve.UseVisualStyleBackColor = False
        '
        'dtgvCaukien
        '
        Me.dtgvCaukien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvCaukien.Location = New System.Drawing.Point(6, 41)
        Me.dtgvCaukien.Name = "dtgvCaukien"
        Me.dtgvCaukien.RowHeadersWidth = 51
        Me.dtgvCaukien.RowTemplate.Height = 24
        Me.dtgvCaukien.Size = New System.Drawing.Size(333, 362)
        Me.dtgvCaukien.TabIndex = 18
        '
        'dtgvMatBang
        '
        Me.dtgvMatBang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvMatBang.Location = New System.Drawing.Point(20, 29)
        Me.dtgvMatBang.Name = "dtgvMatBang"
        Me.dtgvMatBang.RowHeadersWidth = 51
        Me.dtgvMatBang.RowTemplate.Height = 24
        Me.dtgvMatBang.Size = New System.Drawing.Size(309, 205)
        Me.dtgvMatBang.TabIndex = 21
        '
        'btnSua
        '
        Me.btnSua.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSua.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnSua.Location = New System.Drawing.Point(336, 69)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(84, 33)
        Me.btnSua.TabIndex = 22
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = False
        '
        'btnXoa
        '
        Me.btnXoa.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnXoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnXoa.Location = New System.Drawing.Point(336, 108)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(84, 33)
        Me.btnXoa.TabIndex = 23
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = False
        '
        'dtgvLoai
        '
        Me.dtgvLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvLoai.Location = New System.Drawing.Point(6, 409)
        Me.dtgvLoai.Name = "dtgvLoai"
        Me.dtgvLoai.RowHeadersWidth = 51
        Me.dtgvLoai.RowTemplate.Height = 24
        Me.dtgvLoai.Size = New System.Drawing.Size(333, 133)
        Me.dtgvLoai.TabIndex = 20
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.btnXoa)
        Me.GroupBox1.Controls.Add(Me.btnSua)
        Me.GroupBox1.Controls.Add(Me.dtgvMatBang)
        Me.GroupBox1.Controls.Add(Me.btnLaybanve)
        Me.GroupBox1.Controls.Add(Me.btnMain)
        Me.GroupBox1.Location = New System.Drawing.Point(459, 200)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(444, 254)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Danh sách mặt bằng công trình"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(456, 467)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(472, 90)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox2.Controls.Add(Me.btnXoaLayer)
        Me.GroupBox2.Controls.Add(Me.dtgvLayer)
        Me.GroupBox2.Controls.Add(Me.btnThemLayer)
        Me.GroupBox2.Location = New System.Drawing.Point(459, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(444, 170)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lấy Layer cấu kiện"
        '
        'dtgvLayer
        '
        Me.dtgvLayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvLayer.Location = New System.Drawing.Point(20, 31)
        Me.dtgvLayer.Name = "dtgvLayer"
        Me.dtgvLayer.RowHeadersWidth = 51
        Me.dtgvLayer.RowTemplate.Height = 24
        Me.dtgvLayer.Size = New System.Drawing.Size(309, 133)
        Me.dtgvLayer.TabIndex = 24
        '
        'btnThemLayer
        '
        Me.btnThemLayer.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnThemLayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnThemLayer.Location = New System.Drawing.Point(335, 41)
        Me.btnThemLayer.Name = "btnThemLayer"
        Me.btnThemLayer.Size = New System.Drawing.Size(84, 44)
        Me.btnThemLayer.TabIndex = 24
        Me.btnThemLayer.Text = "Thêm hoặc Sửa"
        Me.btnThemLayer.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox3.Controls.Add(Me.dtgvCaukien)
        Me.GroupBox3.Controls.Add(Me.dtgvLoai)
        Me.GroupBox3.Controls.Add(Me.rdbCot)
        Me.GroupBox3.Controls.Add(Me.rdbDam)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 24)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(438, 548)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Thông tin cấu kiện"
        '
        'btnXoaLayer
        '
        Me.btnXoaLayer.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnXoaLayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnXoaLayer.Location = New System.Drawing.Point(336, 102)
        Me.btnXoaLayer.Name = "btnXoaLayer"
        Me.btnXoaLayer.Size = New System.Drawing.Size(84, 33)
        Me.btnXoaLayer.TabIndex = 26
        Me.btnXoaLayer.Text = "Xóa"
        Me.btnXoaLayer.UseVisualStyleBackColor = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(941, 628)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        CType(Me.dtgvCaukien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgvMatBang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgvLoai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dtgvLayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMain As Windows.Forms.Button
    Friend WithEvents rdbDam As Windows.Forms.RadioButton
    Friend WithEvents rdbCot As Windows.Forms.RadioButton
    Friend WithEvents btnLaybanve As Windows.Forms.Button
    Friend WithEvents dtgvCaukien As Windows.Forms.DataGridView
    Friend WithEvents dtgvMatBang As Windows.Forms.DataGridView
    Friend WithEvents btnSua As Windows.Forms.Button
    Friend WithEvents btnXoa As Windows.Forms.Button
    Friend WithEvents dtgvLoai As Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents dtgvLayer As Windows.Forms.DataGridView
    Friend WithEvents btnThemLayer As Windows.Forms.Button
    Friend WithEvents GroupBox3 As Windows.Forms.GroupBox
    Friend WithEvents btnXoaLayer As Windows.Forms.Button
End Class
