<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictGray = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.splitContainerFrames = New System.Windows.Forms.SplitContainer()
        Me.btnCamera = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.imageBoxFrameGrabber = New Emgu.CV.UI.ImageBox()
        Me.imageBoxSkin = New Emgu.CV.UI.ImageBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictGray, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainerFrames.Panel1.SuspendLayout()
        Me.splitContainerFrames.Panel2.SuspendLayout()
        Me.splitContainerFrames.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imageBoxFrameGrabber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imageBoxSkin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Yellow
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(616, 9)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 25)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Result"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(714, 663)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 17)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "Normalisasi X :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Yellow
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(150, 101)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(364, 25)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "Hasil Pengurangan Citra dan Windowing"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.DarkSalmon
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(4, 757)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(226, 25)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Integral Proyeksi Vertikal"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Cyan
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(651, 495)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(248, 25)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Integral Proyeksi Horizontal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(614, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 38)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Hasil Deteksi"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(714, 602)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 17)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Normalisasi Y :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(828, 663)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 17)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "0"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(651, 132)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(255, 360)
        Me.PictureBox2.TabIndex = 25
        Me.PictureBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(828, 602)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 17)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "0"
        '
        'PictGray
        '
        Me.PictGray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictGray.Location = New System.Drawing.Point(4, 132)
        Me.PictGray.Margin = New System.Windows.Forms.Padding(4)
        Me.PictGray.Name = "PictGray"
        Me.PictGray.Size = New System.Drawing.Size(640, 360)
        Me.PictGray.TabIndex = 23
        Me.PictGray.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(662, 635)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 17)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "nilai deteksi minimum X"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Location = New System.Drawing.Point(4, 499)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(640, 255)
        Me.PictureBox3.TabIndex = 24
        Me.PictureBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(662, 573)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 17)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "nilai deteksi minimum Y"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(831, 571)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(78, 22)
        Me.NumericUpDown1.TabIndex = 29
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(831, 635)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(78, 22)
        Me.NumericUpDown2.TabIndex = 30
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Yellow
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(240, 465)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 25)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "First Frame"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Yellow
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(240, 101)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 25)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Gambar Asli"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(35, 17)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 59)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Mulai"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(194, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(180, 64)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Get First Frame"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'splitContainerFrames
        '
        Me.splitContainerFrames.Location = New System.Drawing.Point(2, 3)
        Me.splitContainerFrames.Name = "splitContainerFrames"
        '
        'splitContainerFrames.Panel1
        '
        Me.splitContainerFrames.Panel1.Controls.Add(Me.Label10)
        Me.splitContainerFrames.Panel1.Controls.Add(Me.Label9)
        Me.splitContainerFrames.Panel1.Controls.Add(Me.Button2)
        Me.splitContainerFrames.Panel1.Controls.Add(Me.Button1)
        Me.splitContainerFrames.Panel1.Controls.Add(Me.btnCamera)
        Me.splitContainerFrames.Panel1.Controls.Add(Me.PictureBox4)
        Me.splitContainerFrames.Panel1.Controls.Add(Me.imageBoxFrameGrabber)
        Me.splitContainerFrames.Panel1.Controls.Add(Me.imageBoxSkin)
        Me.splitContainerFrames.Panel1.Controls.Add(Me.PictureBox1)
        '
        'splitContainerFrames.Panel2
        '
        Me.splitContainerFrames.Panel2.Controls.Add(Me.Label13)
        Me.splitContainerFrames.Panel2.Controls.Add(Me.Label12)
        Me.splitContainerFrames.Panel2.Controls.Add(Me.Label11)
        Me.splitContainerFrames.Panel2.Controls.Add(Me.Label7)
        Me.splitContainerFrames.Panel2.Controls.Add(Me.Label8)
        Me.splitContainerFrames.Panel2.Controls.Add(Me.Label1)
        Me.splitContainerFrames.Panel2.Controls.Add(Me.Label6)
        Me.splitContainerFrames.Panel2.Controls.Add(Me.Label4)
        Me.splitContainerFrames.Panel2.Controls.Add(Me.PictureBox2)
        Me.splitContainerFrames.Panel2.Controls.Add(Me.Label5)
        Me.splitContainerFrames.Panel2.Controls.Add(Me.PictGray)
        Me.splitContainerFrames.Panel2.Controls.Add(Me.Label3)
        Me.splitContainerFrames.Panel2.Controls.Add(Me.PictureBox3)
        Me.splitContainerFrames.Panel2.Controls.Add(Me.Label2)
        Me.splitContainerFrames.Panel2.Controls.Add(Me.NumericUpDown1)
        Me.splitContainerFrames.Panel2.Controls.Add(Me.NumericUpDown2)
        Me.splitContainerFrames.Size = New System.Drawing.Size(1540, 884)
        Me.splitContainerFrames.SplitterDistance = 600
        Me.splitContainerFrames.SplitterWidth = 5
        Me.splitContainerFrames.TabIndex = 4
        '
        'btnCamera
        '
        Me.btnCamera.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCamera.FlatAppearance.BorderSize = 0
        Me.btnCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCamera.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCamera.ForeColor = System.Drawing.Color.White
        Me.btnCamera.Image = CType(resources.GetObject("btnCamera.Image"), System.Drawing.Image)
        Me.btnCamera.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCamera.Location = New System.Drawing.Point(433, 17)
        Me.btnCamera.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCamera.Name = "btnCamera"
        Me.btnCamera.Size = New System.Drawing.Size(124, 59)
        Me.btnCamera.TabIndex = 19
        Me.btnCamera.Text = "Deteksi"
        Me.btnCamera.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCamera.UseVisualStyleBackColor = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox4.Location = New System.Drawing.Point(64, 497)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(465, 314)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 12
        Me.PictureBox4.TabStop = False
        '
        'imageBoxFrameGrabber
        '
        Me.imageBoxFrameGrabber.Location = New System.Drawing.Point(455, 852)
        Me.imageBoxFrameGrabber.Margin = New System.Windows.Forms.Padding(4)
        Me.imageBoxFrameGrabber.Name = "imageBoxFrameGrabber"
        Me.imageBoxFrameGrabber.Size = New System.Drawing.Size(122, 80)
        Me.imageBoxFrameGrabber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imageBoxFrameGrabber.TabIndex = 2
        Me.imageBoxFrameGrabber.TabStop = False
        '
        'imageBoxSkin
        '
        Me.imageBoxSkin.Location = New System.Drawing.Point(263, 800)
        Me.imageBoxSkin.Margin = New System.Windows.Forms.Padding(4)
        Me.imageBoxSkin.Name = "imageBoxSkin"
        Me.imageBoxSkin.Size = New System.Drawing.Size(141, 113)
        Me.imageBoxSkin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imageBoxSkin.TabIndex = 2
        Me.imageBoxSkin.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(64, 132)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(465, 314)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1000
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5
        '
        'Timer3
        '
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1623, 830)
        Me.Controls.Add(Me.splitContainerFrames)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Deteksi gerak/Motion Detection"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictGray, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainerFrames.Panel1.ResumeLayout(False)
        Me.splitContainerFrames.Panel1.PerformLayout()
        Me.splitContainerFrames.Panel2.ResumeLayout(False)
        Me.splitContainerFrames.Panel2.PerformLayout()
        Me.splitContainerFrames.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imageBoxFrameGrabber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imageBoxSkin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictGray As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Private WithEvents splitContainerFrames As SplitContainer
    Friend WithEvents btnCamera As Button
    Friend WithEvents PictureBox4 As PictureBox
    Private WithEvents imageBoxFrameGrabber As Emgu.CV.UI.ImageBox
    Private WithEvents imageBoxSkin As Emgu.CV.UI.ImageBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer3 As Timer
End Class
