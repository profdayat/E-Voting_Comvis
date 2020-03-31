Namespace EVoting_Comvis
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.imageBoxFrameGrabber = New Emgu.CV.UI.ImageBox()
            Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
            Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.TextBox1 = New System.Windows.Forms.TextBox()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.imageBoxSkin = New Emgu.CV.UI.ImageBox()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.PictureBox11 = New System.Windows.Forms.PictureBox()
            Me.PictureBox10 = New System.Windows.Forms.PictureBox()
            Me.PictureBox9 = New System.Windows.Forms.PictureBox()
            Me.PictureBox8 = New System.Windows.Forms.PictureBox()
            Me.PictureBox7 = New System.Windows.Forms.PictureBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.PictureBox5 = New System.Windows.Forms.PictureBox()
            Me.PictureBox6 = New System.Windows.Forms.PictureBox()
            Me.PictureBox4 = New System.Windows.Forms.PictureBox()
            Me.PictureBox2 = New System.Windows.Forms.PictureBox()
            Me.PictureBox3 = New System.Windows.Forms.PictureBox()
            Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
            Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
            Me.SplitContainer1.Panel1.SuspendLayout()
            Me.SplitContainer1.Panel2.SuspendLayout()
            Me.SplitContainer1.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            CType(Me.imageBoxFrameGrabber, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitContainer2.Panel1.SuspendLayout()
            Me.SplitContainer2.Panel2.SuspendLayout()
            Me.SplitContainer2.SuspendLayout()
            Me.SplitContainer3.Panel1.SuspendLayout()
            Me.SplitContainer3.Panel2.SuspendLayout()
            Me.SplitContainer3.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox3.SuspendLayout()
            CType(Me.imageBoxSkin, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox4.SuspendLayout()
            CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'SplitContainer1
            '
            Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
            Me.SplitContainer1.Name = "SplitContainer1"
            '
            'SplitContainer1.Panel1
            '
            Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
            '
            'SplitContainer1.Panel2
            '
            Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
            Me.SplitContainer1.Size = New System.Drawing.Size(1593, 850)
            Me.SplitContainer1.SplitterDistance = 881
            Me.SplitContainer1.TabIndex = 1
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.imageBoxFrameGrabber)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(881, 850)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Deteksi Isyarat Tangan"
            '
            'imageBoxFrameGrabber
            '
            Me.imageBoxFrameGrabber.Dock = System.Windows.Forms.DockStyle.Fill
            Me.imageBoxFrameGrabber.Location = New System.Drawing.Point(3, 26)
            Me.imageBoxFrameGrabber.Margin = New System.Windows.Forms.Padding(4)
            Me.imageBoxFrameGrabber.Name = "imageBoxFrameGrabber"
            Me.imageBoxFrameGrabber.Size = New System.Drawing.Size(875, 821)
            Me.imageBoxFrameGrabber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.imageBoxFrameGrabber.TabIndex = 3
            Me.imageBoxFrameGrabber.TabStop = False
            '
            'SplitContainer2
            '
            Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
            Me.SplitContainer2.Name = "SplitContainer2"
            '
            'SplitContainer2.Panel1
            '
            Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer3)
            '
            'SplitContainer2.Panel2
            '
            Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox4)
            Me.SplitContainer2.Size = New System.Drawing.Size(708, 850)
            Me.SplitContainer2.SplitterDistance = 349
            Me.SplitContainer2.TabIndex = 0
            '
            'SplitContainer3
            '
            Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
            Me.SplitContainer3.Name = "SplitContainer3"
            Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
            '
            'SplitContainer3.Panel1
            '
            Me.SplitContainer3.Panel1.Controls.Add(Me.GroupBox2)
            '
            'SplitContainer3.Panel2
            '
            Me.SplitContainer3.Panel2.Controls.Add(Me.GroupBox3)
            Me.SplitContainer3.Size = New System.Drawing.Size(349, 850)
            Me.SplitContainer3.SplitterDistance = 429
            Me.SplitContainer3.TabIndex = 0
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.Label2)
            Me.GroupBox2.Controls.Add(Me.Label15)
            Me.GroupBox2.Controls.Add(Me.Label14)
            Me.GroupBox2.Controls.Add(Me.Label1)
            Me.GroupBox2.Controls.Add(Me.TextBox1)
            Me.GroupBox2.Controls.Add(Me.PictureBox1)
            Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(349, 429)
            Me.GroupBox2.TabIndex = 0
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Alat"
            '
            'Label2
            '
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.Red
            Me.Label2.Location = New System.Drawing.Point(22, 268)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(276, 90)
            Me.Label2.TabIndex = 7
            Me.Label2.Text = "-"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label15
            '
            Me.Label15.AutoSize = True
            Me.Label15.Location = New System.Drawing.Point(55, 126)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(205, 20)
            Me.Label15.TabIndex = 6
            Me.Label15.Text = "Penghitung Waktu Mundur"
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label14.ForeColor = System.Drawing.Color.Red
            Me.Label14.Location = New System.Drawing.Point(95, 146)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(124, 135)
            Me.Label14.TabIndex = 5
            Me.Label14.Text = "3"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(15, 45)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(133, 20)
            Me.Label1.TabIndex = 4
            Me.Label1.Text = "Masukkan Nama"
            '
            'TextBox1
            '
            Me.TextBox1.Location = New System.Drawing.Point(19, 79)
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Size = New System.Drawing.Size(279, 27)
            Me.TextBox1.TabIndex = 2
            Me.TextBox1.UseSystemPasswordChar = True
            '
            'PictureBox1
            '
            Me.PictureBox1.Location = New System.Drawing.Point(280, 12)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(63, 61)
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.PictureBox1.TabIndex = 0
            Me.PictureBox1.TabStop = False
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.imageBoxSkin)
            Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(349, 417)
            Me.GroupBox3.TabIndex = 1
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Text = "Mode Grayscale"
            '
            'imageBoxSkin
            '
            Me.imageBoxSkin.Dock = System.Windows.Forms.DockStyle.Fill
            Me.imageBoxSkin.Location = New System.Drawing.Point(3, 26)
            Me.imageBoxSkin.Margin = New System.Windows.Forms.Padding(4)
            Me.imageBoxSkin.Name = "imageBoxSkin"
            Me.imageBoxSkin.Size = New System.Drawing.Size(343, 388)
            Me.imageBoxSkin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.imageBoxSkin.TabIndex = 3
            Me.imageBoxSkin.TabStop = False
            '
            'GroupBox4
            '
            Me.GroupBox4.Controls.Add(Me.PictureBox11)
            Me.GroupBox4.Controls.Add(Me.PictureBox10)
            Me.GroupBox4.Controls.Add(Me.PictureBox9)
            Me.GroupBox4.Controls.Add(Me.PictureBox8)
            Me.GroupBox4.Controls.Add(Me.PictureBox7)
            Me.GroupBox4.Controls.Add(Me.Label8)
            Me.GroupBox4.Controls.Add(Me.Label7)
            Me.GroupBox4.Controls.Add(Me.Label6)
            Me.GroupBox4.Controls.Add(Me.Label5)
            Me.GroupBox4.Controls.Add(Me.Label4)
            Me.GroupBox4.Controls.Add(Me.PictureBox5)
            Me.GroupBox4.Controls.Add(Me.PictureBox6)
            Me.GroupBox4.Controls.Add(Me.PictureBox4)
            Me.GroupBox4.Controls.Add(Me.PictureBox2)
            Me.GroupBox4.Controls.Add(Me.PictureBox3)
            Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(355, 850)
            Me.GroupBox4.TabIndex = 4
            Me.GroupBox4.TabStop = False
            Me.GroupBox4.Text = "Lain"
            '
            'PictureBox11
            '
            Me.PictureBox11.Image = Global.My.Resources.Resources.Slide5
            Me.PictureBox11.Location = New System.Drawing.Point(153, 772)
            Me.PictureBox11.Name = "PictureBox11"
            Me.PictureBox11.Size = New System.Drawing.Size(206, 104)
            Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.PictureBox11.TabIndex = 16
            Me.PictureBox11.TabStop = False
            '
            'PictureBox10
            '
            Me.PictureBox10.Image = Global.My.Resources.Resources.Slide4
            Me.PictureBox10.Location = New System.Drawing.Point(153, 593)
            Me.PictureBox10.Name = "PictureBox10"
            Me.PictureBox10.Size = New System.Drawing.Size(206, 104)
            Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.PictureBox10.TabIndex = 15
            Me.PictureBox10.TabStop = False
            '
            'PictureBox9
            '
            Me.PictureBox9.Image = Global.My.Resources.Resources.Slide3
            Me.PictureBox9.Location = New System.Drawing.Point(153, 410)
            Me.PictureBox9.Name = "PictureBox9"
            Me.PictureBox9.Size = New System.Drawing.Size(206, 104)
            Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.PictureBox9.TabIndex = 14
            Me.PictureBox9.TabStop = False
            '
            'PictureBox8
            '
            Me.PictureBox8.Image = Global.My.Resources.Resources.Slide2
            Me.PictureBox8.Location = New System.Drawing.Point(153, 236)
            Me.PictureBox8.Name = "PictureBox8"
            Me.PictureBox8.Size = New System.Drawing.Size(206, 104)
            Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.PictureBox8.TabIndex = 13
            Me.PictureBox8.TabStop = False
            '
            'PictureBox7
            '
            Me.PictureBox7.Image = Global.My.Resources.Resources.Slide1
            Me.PictureBox7.Location = New System.Drawing.Point(153, 61)
            Me.PictureBox7.Name = "PictureBox7"
            Me.PictureBox7.Size = New System.Drawing.Size(206, 104)
            Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.PictureBox7.TabIndex = 12
            Me.PictureBox7.TabStop = False
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.Location = New System.Drawing.Point(164, 756)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(109, 17)
            Me.Label8.TabIndex = 11
            Me.Label8.Text = "(5) Pilih Calon E"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(164, 577)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(110, 17)
            Me.Label7.TabIndex = 10
            Me.Label7.Text = "(4) Pilih Calon D"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(164, 394)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(109, 17)
            Me.Label6.TabIndex = 9
            Me.Label6.Text = "(3) Pilih Calon C"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(164, 220)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(109, 17)
            Me.Label5.TabIndex = 8
            Me.Label5.Text = "(2) Pilih Calon B"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(165, 45)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(109, 17)
            Me.Label4.TabIndex = 7
            Me.Label4.Text = "(1) Pilih Calon A"
            '
            'PictureBox5
            '
            Me.PictureBox5.Image = Global.My.Resources.Resources._5
            Me.PictureBox5.Location = New System.Drawing.Point(59, 756)
            Me.PictureBox5.Name = "PictureBox5"
            Me.PictureBox5.Size = New System.Drawing.Size(88, 120)
            Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.PictureBox5.TabIndex = 5
            Me.PictureBox5.TabStop = False
            '
            'PictureBox6
            '
            Me.PictureBox6.Image = Global.My.Resources.Resources._4
            Me.PictureBox6.Location = New System.Drawing.Point(59, 577)
            Me.PictureBox6.Name = "PictureBox6"
            Me.PictureBox6.Size = New System.Drawing.Size(88, 120)
            Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.PictureBox6.TabIndex = 4
            Me.PictureBox6.TabStop = False
            '
            'PictureBox4
            '
            Me.PictureBox4.Image = Global.My.Resources.Resources._3
            Me.PictureBox4.Location = New System.Drawing.Point(59, 394)
            Me.PictureBox4.Name = "PictureBox4"
            Me.PictureBox4.Size = New System.Drawing.Size(88, 120)
            Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.PictureBox4.TabIndex = 3
            Me.PictureBox4.TabStop = False
            '
            'PictureBox2
            '
            Me.PictureBox2.Image = Global.My.Resources.Resources._1
            Me.PictureBox2.Location = New System.Drawing.Point(59, 45)
            Me.PictureBox2.Name = "PictureBox2"
            Me.PictureBox2.Size = New System.Drawing.Size(88, 120)
            Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.PictureBox2.TabIndex = 1
            Me.PictureBox2.TabStop = False
            '
            'PictureBox3
            '
            Me.PictureBox3.Image = Global.My.Resources.Resources._2
            Me.PictureBox3.Location = New System.Drawing.Point(59, 220)
            Me.PictureBox3.Name = "PictureBox3"
            Me.PictureBox3.Size = New System.Drawing.Size(88, 120)
            Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.PictureBox3.TabIndex = 2
            Me.PictureBox3.TabStop = False
            '
            'Timer2
            '
            Me.Timer2.Interval = 1000
            '
            'Timer3
            '
            Me.Timer3.Interval = 200
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1593, 850)
            Me.Controls.Add(Me.SplitContainer1)
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.Name = "Form1"
            Me.Text = "E-Voting_Comvis  © 2019 Dayat - All Rights Reserved"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.SplitContainer1.Panel1.ResumeLayout(False)
            Me.SplitContainer1.Panel2.ResumeLayout(False)
            Me.SplitContainer1.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            CType(Me.imageBoxFrameGrabber, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitContainer2.Panel1.ResumeLayout(False)
            Me.SplitContainer2.Panel2.ResumeLayout(False)
            Me.SplitContainer2.ResumeLayout(False)
            Me.SplitContainer3.Panel1.ResumeLayout(False)
            Me.SplitContainer3.Panel2.ResumeLayout(False)
            Me.SplitContainer3.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox3.ResumeLayout(False)
            CType(Me.imageBoxSkin, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents SplitContainer1 As SplitContainer
        Friend WithEvents GroupBox1 As GroupBox
        Private WithEvents imageBoxFrameGrabber As Emgu.CV.UI.ImageBox
        Friend WithEvents SplitContainer2 As SplitContainer
        Friend WithEvents SplitContainer3 As SplitContainer
        Friend WithEvents GroupBox2 As GroupBox
        Friend WithEvents Label1 As Label
        Friend WithEvents TextBox1 As TextBox
        Friend WithEvents GroupBox3 As GroupBox
        Private WithEvents imageBoxSkin As Emgu.CV.UI.ImageBox
        Friend WithEvents Timer2 As Timer
        Friend WithEvents Label14 As Label
        Friend WithEvents Timer3 As Timer
        Friend WithEvents Label15 As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents PictureBox1 As PictureBox
        Friend WithEvents PictureBox2 As PictureBox
        Friend WithEvents PictureBox4 As PictureBox
        Friend WithEvents PictureBox3 As PictureBox
        Friend WithEvents GroupBox4 As GroupBox
        Friend WithEvents PictureBox5 As PictureBox
        Friend WithEvents PictureBox6 As PictureBox
        Friend WithEvents Label8 As Label
        Friend WithEvents Label7 As Label
        Friend WithEvents Label6 As Label
        Friend WithEvents Label5 As Label
        Friend WithEvents Label4 As Label
        Friend WithEvents PictureBox7 As PictureBox
        Friend WithEvents PictureBox8 As PictureBox
        Friend WithEvents PictureBox9 As PictureBox
        Friend WithEvents PictureBox10 As PictureBox
        Friend WithEvents PictureBox11 As PictureBox

#End Region
    End Class
End Namespace

