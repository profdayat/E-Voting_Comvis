<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.c1 = New System.Windows.Forms.Label()
        Me.LabelPemenang = New System.Windows.Forms.Label()
        Me.c4 = New System.Windows.Forms.Label()
        Me.c5 = New System.Windows.Forms.Label()
        Me.c2 = New System.Windows.Forms.Label()
        Me.c3 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 21)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(214, 22)
        Me.TextBox1.TabIndex = 14
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 21)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(278, 267)
        Me.DataGridView1.TabIndex = 15
        '
        'Column1
        '
        Me.Column1.HeaderText = "Calon"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 50
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Waktu memilih"
        Me.Column2.Name = "Column2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(25, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Jumlah belum rekap"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(25, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Jumlah sudah rekap"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 17)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Belum rekap"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 17)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Sudah rekap"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(307, 229)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Jumlah"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(353, 14)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(293, 294)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Hasil Rekap"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(226, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 27)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Rekap"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 14)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(307, 64)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Input Scan QR Code"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.c1)
        Me.GroupBox4.Controls.Add(Me.LabelPemenang)
        Me.GroupBox4.Controls.Add(Me.c4)
        Me.GroupBox4.Controls.Add(Me.c5)
        Me.GroupBox4.Controls.Add(Me.c2)
        Me.GroupBox4.Controls.Add(Me.c3)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox4.Location = New System.Drawing.Point(0, 308)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(660, 264)
        Me.GroupBox4.TabIndex = 24
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Deskripsi"
        '
        'c1
        '
        Me.c1.AutoSize = True
        Me.c1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1.Location = New System.Drawing.Point(17, 34)
        Me.c1.Name = "c1"
        Me.c1.Size = New System.Drawing.Size(65, 20)
        Me.c1.TabIndex = 8
        Me.c1.Text = "Label5"
        '
        'LabelPemenang
        '
        Me.LabelPemenang.AutoSize = True
        Me.LabelPemenang.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPemenang.Location = New System.Drawing.Point(15, 193)
        Me.LabelPemenang.Name = "LabelPemenang"
        Me.LabelPemenang.Size = New System.Drawing.Size(25, 32)
        Me.LabelPemenang.TabIndex = 12
        Me.LabelPemenang.Text = "-"
        '
        'c4
        '
        Me.c4.AutoSize = True
        Me.c4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c4.Location = New System.Drawing.Point(17, 125)
        Me.c4.Name = "c4"
        Me.c4.Size = New System.Drawing.Size(65, 20)
        Me.c4.TabIndex = 10
        Me.c4.Text = "Label8"
        '
        'c5
        '
        Me.c5.AutoSize = True
        Me.c5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c5.Location = New System.Drawing.Point(17, 155)
        Me.c5.Name = "c5"
        Me.c5.Size = New System.Drawing.Size(65, 20)
        Me.c5.TabIndex = 11
        Me.c5.Text = "Label9"
        '
        'c2
        '
        Me.c2.AutoSize = True
        Me.c2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c2.Location = New System.Drawing.Point(17, 65)
        Me.c2.Name = "c2"
        Me.c2.Size = New System.Drawing.Size(75, 20)
        Me.c2.TabIndex = 9
        Me.c2.Text = "Label10"
        '
        'c3
        '
        Me.c3.AutoSize = True
        Me.c3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c3.Location = New System.Drawing.Point(17, 94)
        Me.c3.Name = "c3"
        Me.c3.Size = New System.Drawing.Size(75, 20)
        Me.c3.TabIndex = 10
        Me.c3.Text = "Label11"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 572)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rekapitulasi Hasil Pemungutan Suara"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents c1 As Label
    Friend WithEvents LabelPemenang As Label
    Friend WithEvents c4 As Label
    Friend WithEvents c5 As Label
    Friend WithEvents c2 As Label
    Friend WithEvents c3 As Label
End Class
