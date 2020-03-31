Imports Emgu.CV.Structure
Imports Emgu.CV
Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices

Public Class Form4

    Inherits Form

    Private currentFrame As Image(Of Bgr, Byte)
    Private currentFrameCopy As Image(Of Bgr, Byte)

    Private grabber As Capture

    Private frameWidth As Integer
    Private frameHeight As Integer

    Private minX As Integer
    Private minY As Integer

    Dim Detik As Long
    Dim FirstFrame() As Byte, Detik_GetFirstFrame As Long
    Dim Xmin, Ymin, Xmax, Ymax As Integer
    Dim Tes3D(,,) As Integer

    Dim proyeksi_V() As Long 'variabel proyeksi vertikal
    Dim proyeksi_H() As Long 'variabel proyeksi horizontal

    Dim mouseY As Boolean = Nothing
    Dim mouseX As Boolean = Nothing

    Dim minX_norm As Integer
    Dim minY_norm As Integer

    'Dim p As Process = Nothing

    'Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer,
    '<MarshalAs(UnmanagedType.AsAny)> ByVal lParam As Object) As Integer

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'InitializeComponent()
        grabber = New Emgu.CV.Capture(0) 'Membuka kamera

        'memulai menjalankan frame
        AddHandler Application.Idle, AddressOf FrameGrabber
    End Sub

    Private Sub FrameGrabber(ByVal sender As Object, ByVal e As EventArgs)
        currentFrame = grabber.QuerySmallFrame()

        'cek ketersediaan frame
        If currentFrame IsNot Nothing Then
            currentFrameCopy = currentFrame.Copy() 'salin frame
            NumericUpDown1.Maximum = currentFrameCopy.Rows
            NumericUpDown2.Maximum = currentFrameCopy.Cols

            Timer2.Start()

            PictureBox1.Image = currentFrame.Bitmap 'tampilkan citra asli
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim bmap As Image

        Detik = Detik + 1
        If Detik Mod 2 = 0 And btnCamera.Enabled = False Then
            bmap = Nothing
            bmap = PictureBox1.Image
            'bmap.Save("d:\misal.bmp")
            PictGray.Image = bmap 'Image.FromFile("c:\001.png") '
            '=== READ FAST IMAGE ========
            Dim bmp As New System.Drawing.Bitmap(PictGray.Image) 'IMAGE FROM PICTURE BOX...
            Dim bmpdata As BitmapData
            Dim g_RowSizeBytes As Integer
            Dim RGBvalues() As Byte, RGBOlah() As Byte

            'Call LockBitmap(bmp)      'LOCKING BITMAP
            Dim bounds As Rectangle = New Rectangle(0, 0, bmp.Width, bmp.Height)
            bmpdata = bmp.LockBits(bounds, Imaging.ImageLockMode.ReadWrite, Imaging.PixelFormat.Format24bppRgb)
            g_RowSizeBytes = bmpdata.Stride
            Dim total_size As Integer
            total_size = bmpdata.Stride * bmpdata.Height 'Stride adalh lebar * 3 (24 bit, 3-> RGB)
            ReDim RGBvalues(total_size), RGBOlah(total_size)
            Marshal.Copy(bmpdata.Scan0, RGBvalues, 0, total_size)
            '--------------------------------------------

            Dim GrayPict As New Bitmap(PictGray.Image)
            'PictureBox4.Image = GrayPict
            Dim Gray As Integer
            Dim RedValue As Int32
            Dim GreenValue As Int32
            Dim BlueValue As Int32
            Dim GrayValue, GrayFirstFrame, Gray1, Gray2, Jum_data As Int32
            Dim Nilai As Byte = 80
            Dim ScanLine As Integer = 0
            Dim stepX, stepY, findX, findY As Integer

            ScanLine = bmpdata.Stride
            Dim PixPos As Integer = 0       'Posisi Pixel        

            stepX = 3
            stepY = 3

            Xmin = 1000
            Ymin = 1000
            Xmax = -1
            Ymax = -1


            ReDim proyeksi_V(bmp.Width)
            ReDim proyeksi_H(bmp.Height)

            For x = stepX - 1 To bmp.Width - 1 Step stepX
                For y = stepY - 1 To bmp.Height - 1 Step stepY
                    GrayValue = 0
                    GrayFirstFrame = 0
                    Jum_data = 0
                    If ((x >= 0 And x < bmp.Width - 2) And (y >= 0 And y < bmp.Height - 2)) Then
                        For xx = -1 To 1
                            For yy = -1 To 1
                                findX = x + xx
                                findY = y + yy

                                PixPos = ((bmp.Width * 3 * findY) + (findX * 3)) ' pixel is made of 3 parts (RGB colors)
                                BlueValue = RGBvalues(PixPos)  'Nilai BLUE
                                GreenValue = RGBvalues(PixPos + 1)  'Nilai GREEN
                                RedValue = RGBvalues(PixPos + 2)  ' Nilai RED
                                Gray1 = Fix((BlueValue + RedValue + GreenValue) / 3)

                                BlueValue = FirstFrame(PixPos)  'Nilai BLUE
                                GreenValue = FirstFrame(PixPos + 1)  'Nilai GREEN
                                RedValue = FirstFrame(PixPos + 2)  ' Nilai RED
                                Gray2 = Fix((BlueValue + RedValue + GreenValue) / 3)

                                'total semua gray ukuran 3x3 pixel 
                                GrayValue = GrayValue + Gray1
                                GrayFirstFrame = GrayFirstFrame + Gray2
                                'jumlah data gray yang ada dalm looping
                                Jum_data = Jum_data + 1



                            Next
                        Next

                    End If

                    'Rata-rata Gray dalam looping (kisaran 9 pixel)
                    If Jum_data > 0 Then
                        GrayValue = Fix(GrayValue / Jum_data)
                        GrayFirstFrame = Fix(GrayFirstFrame / Jum_data)
                    End If

                    Gray = Math.Abs(GrayValue - GrayFirstFrame)

                    If Gray > 60 Then
                        Gray = 255

                        If x > Xmax Then
                            Xmax = x
                        End If

                        If y > Ymax Then
                            Ymax = y
                        End If

                        If x < Xmin Then
                            Xmin = x
                        End If

                        If y < Ymin Then
                            Ymin = y
                        End If

                        proyeksi_V(x) = proyeksi_V(x) + 1 'ambil data proyeksi vertikal
                        proyeksi_H(y) = proyeksi_H(y) + 1 'ambil data proyeksi horizontal

                    Else
                        Gray = 0

                    End If

                    '------ KHUSUS Hasil Motion detection -----------
                    RGBOlah(PixPos) = Gray
                    RGBOlah(PixPos + 1) = Gray
                    RGBOlah(PixPos + 2) = Gray
                    '------------------------------------------------

                    'GrayPict.SetPixel(x, y, Color.FromArgb(Gray, Gray, Gray))

                Next
            Next
            'PictureBox4.Refresh()

            ''Integral Proyeksi Vertikal''
            'inisialisasi
            Dim Max = -1000
            Dim wadahV As New Bitmap(bmp.Width, bmp.Height)
            Dim LineV As Graphics = Graphics.FromImage(wadahV)

            'Gambarkan Histogram secara vertikal
            For x = 0 To bmp.Width - 1
                For y = 0 To bmp.Height - 1

                Next
                Dim Pena As New Pen(Brushes.Red, 2) 'Warna dan ke ketebalan pen histogram
                Dim TinggiV As Single = (PictureBox3.Height * CSng((proyeksi_V(x) * 3) / bmp.Height)) 'Normalisasi tinggi histogram
                Dim PosisiX As Single = (PictureBox3.Width * CSng(x / bmp.Width)) 'Normalisasi Lebar histogram
                LineV.DrawLine(Pena, PosisiX, 0, PosisiX, TinggiV) 'menggambar histogram

                LineV.DrawLine(Pena, 0, CSng(Label5.Text), PictureBox3.Width, CSng(Label5.Text)) 'menggambar batas

                If Max < proyeksi_V(x) Then Max = proyeksi_V(x) 'isi variabel max dengan proyeksi vertikal

                PictureBox3.Image = (wadahV) 'tampikan wadah histogram kedalam PictureBox3
            Next

            ''Integral Proyeksi Horizontal''
            Dim wadahH As New Bitmap(bmp.Width, bmp.Height)
            Dim LineH As Graphics = Graphics.FromImage(wadahH)
            For y = 0 To bmp.Height - 1
                For x = 0 To bmp.Width - 1

                Next
                Dim Penal As New Pen(Brushes.Blue, 2) 'Warna dan ke ketebalan pen histogram
                Dim TinggiH As Single = (PictureBox2.Width * CSng((proyeksi_H(y) * 3) / bmp.Width)) 'Normalisasi tinggi histogram
                Dim PosisiY As Single = (PictureBox2.Height * CSng(y / bmp.Height)) 'Normalisasi Lebar histogram
                LineH.DrawLine(Penal, 0, PosisiY, TinggiH, PosisiY) 'menggambar histogram

                LineH.DrawLine(Penal, CSng(Label4.Text), 0, CSng(Label4.Text), PictureBox2.Height) 'menggambar batas

                PictureBox2.Image = (wadahH) 'tampikan wadah histogram kedalam PictureBox3
            Next

            'Update nilai scanline0 dengan marshal
            Marshal.Copy(RGBOlah, 0, bmpdata.Scan0, total_size)
            'tampilkan data
            PictGray.Image = (bmp)
            'PictureBox4.Image = bmp
            'Call UnlockBitmap(bmp)      'UNLOCKING BITMAP
            bmp.UnlockBits(bmpdata)
            RGBvalues = Nothing
            bmpdata = Nothing
            ''PictureBox1.Image.Save("d:\misal.bmp")
            'PictGray.Image.Save("c:\misal.bmp")
            'PictureBox3.Image.Save("c:\PROYEKSI_V.bmp")
            'PictureBox2.Image.Save("c:\PROYEKSI_H.bmp")
            '---------------------------------------------

        End If
        'End If
    End Sub

    Private Sub btnCamera_Click(sender As Object, e As EventArgs) Handles btnCamera.Click
        btnCamera.Enabled = False
        'Me.Opacity = 0
    End Sub

    Private Sub PictGray_MouseMove(sender As Object, e As MouseEventArgs)
        If btnCamera.Enabled = True Then
            Dim x As Integer, y As Integer
            Dim citra As Bitmap = New Bitmap(PictGray.Image)
            Dim warna As Color
            Dim vr, vg, vb As Integer

            x = e.X
            y = e.Y
            'mousePath.AddLine(x, y, x, y)
            warna = citra.GetPixel(x, y)

            vr = warna.R.ToString
            vg = warna.G.ToString
            vb = warna.B.ToString

            'rgbval.Text = "Red = " & vr & "; Green = " & vg & "; Blue = " & vb
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        get_first_frame()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Detik_GetFirstFrame = Detik_GetFirstFrame + 1
        If Detik_GetFirstFrame = 5 Then
            get_first_frame()
            btnCamera.Enabled = False
        End If
    End Sub

    Sub get_first_frame()

        Dim bmap As Image

        bmap = Nothing
        bmap = PictureBox1.Image
        PictureBox4.Image = bmap
        'bmap.Save("d:\misal.bmp")
        PictGray.Image = bmap 'Image.FromFile("c:\1.png") '
        '=== READ FAST IMAGE ========
        Dim bmp As New System.Drawing.Bitmap(PictGray.Image) 'IMAGE FROM PICTURE BOX...
        Dim bmpdata As BitmapData
        Dim g_RowSizeBytes As Integer

        'Call LockBitmap(bmp)      'LOCKING BITMAP
        Dim bounds As Rectangle = New Rectangle(0, 0, bmp.Width, bmp.Height)
        bmpdata = bmp.LockBits(bounds, Imaging.ImageLockMode.ReadWrite, Imaging.PixelFormat.Format24bppRgb)
        g_RowSizeBytes = bmpdata.Stride
        Dim total_size As Integer
        total_size = bmpdata.Stride * bmpdata.Height 'Stride adalh lebar * 3 (24 bit, 3-> RGB)
        ReDim FirstFrame(total_size)

        'deklarasi array 3d
        ReDim Tes3D(bmpdata.Width, bmpdata.Height, 3)
        Marshal.Copy(bmpdata.Scan0, FirstFrame, 0, total_size)
        '--------------------------------------------

        Dim RedValue As Int32
        Dim GreenValue As Int32
        Dim BlueValue As Int32
        Dim GrayValue As Int32
        Dim Nilai As Byte = 80
        'Dim R As Int32, G As Int32, B As Int32
        Dim HistoR(255) As Integer, HistoG(255) As Integer, HistoB(255) As Integer
        Dim Rmax As Integer = -1, Gmax As Integer = -1, Bmax As Integer = -1
        Dim ScanLine As Integer = 0

        ScanLine = bmpdata.Stride

        Dim PixPos As Integer = 0       'Posisi Pixel                
        For x = 0 To bmp.Width - 1 'Pixels start with 0 so we need Height - 1 
            For y = 0 To bmp.Height - 1

                PixPos = ((bmp.Width * 3 * y) + (x * 3)) ' pixel is made of 3 parts (RGB colors)

                BlueValue = FirstFrame(PixPos)  'Nilai BLUE
                GreenValue = FirstFrame(PixPos + 1)  'Nilai GREEN
                RedValue = FirstFrame(PixPos + 2)  ' Nilai RED
                GrayValue = Int((RedValue + GreenValue + RedValue) / 3)

                'Tes3D(x, y, 0) = BlueValue
                'Tes3D(x, y, 1) = GreenValue
                'Tes3D(x, y, 2) = RedValue

                'Update nilai RGBOlah
                FirstFrame(PixPos) = GrayValue
                FirstFrame(PixPos + 1) = GrayValue
                FirstFrame(PixPos + 2) = GrayValue

            Next
        Next

        'Update nilai scanline0 dengan marshal
        'Marshal.Copy(RGBOlah, 0, bmpdata.Scan0, total_size)

        'Call UnlockBitmap(bmp)      'UNLOCKING BITMAP
        bmp.UnlockBits(bmpdata)
        bmpdata = Nothing
        '---------------------------------------------
        'End If
        'End If
    End Sub

    Private Sub PictGray_Paint(sender As Object, e As PaintEventArgs) Handles PictGray.Paint
        Timer3.Enabled = True
        'TextBox1.Text = Ymax - Ymin & " - " & Xmax - Xmin
        If Xmax > 0 And Ymax > 0 And Xmin > 0 And Ymin > 0 Then
            If Ymax - Ymin > NumericUpDown1.Value And Xmax - Xmin > NumericUpDown2.Value Then

                motion_status = "aktif"
                Label1.Text = "Manusia!"

                Dim mypen As Pen = New Pen(Color.Blue, 3)
                Dim mypen1 As Pen = New Pen(Color.Crimson, 3)
                e.Graphics.DrawLine(mypen, Xmin, Ymin, Xmax, Ymax)
                e.Graphics.DrawLine(mypen, Xmin, Ymax, Xmax, Ymin)
                e.Graphics.DrawLine(mypen1, Xmin, Ymin, Xmin, Ymax)
                e.Graphics.DrawLine(mypen, Xmin, Ymin, Xmax, Ymin)
                e.Graphics.DrawLine(mypen1, Xmax, Ymin, Xmax, Ymax)
                e.Graphics.DrawLine(mypen, Xmin, Ymax, Xmax, Ymax)
            Else
                motion_status = "-"
                Label1.Text = "Bukan manusia"
            End If
        Else
            motion_status = "-"
            Label1.Text = "tidak ada gerak"
        End If

    End Sub

    Private Sub PictureBox2_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseDown
        mouseX = True
    End Sub

    Private Sub PictureBox2_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseUp
        mouseX = False
    End Sub

    Private Sub PictureBox3_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseDown
        mouseY = True
    End Sub

    Private Sub PictureBox3_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseUp
        mouseY = False

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        minY = CInt(NumericUpDown1.Value)
    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged
        minX = CInt(NumericUpDown2.Value)
    End Sub

    Private Sub PictureBox2_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseMove
        If mouseX = True Then

            minX = e.X

            minX_norm = CInt(PictGray.Width * CSng((minX) / PictureBox2.Width))
            If minX_norm <= 0 Then
                minX_norm = 0
                minX = 0
            ElseIf minX_norm >= PictGray.Width Then
                minX_norm = PictGray.Width
                minX = PictureBox2.Width
            End If

            Label4.Text = minX
            NumericUpDown2.Value = minX_norm

        End If
    End Sub

    Private Sub PictureBox3_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseMove
        If mouseY = True Then

            minY = e.Y

            minY_norm = CInt(PictGray.Height * CSng((minY) / PictureBox3.Height))
            If minY_norm <= 0 Then
                minY_norm = 0
                minY = 0
            ElseIf minY_norm >= PictGray.Height Then
                minY_norm = PictGray.Height
                minY = PictureBox3.Height
            End If

            Label5.Text = minY
            NumericUpDown1.Value = minY_norm

        End If
    End Sub

    Private Sub PictGray_Click(sender As Object, e As EventArgs) Handles PictGray.Click

        Dim x As Integer = 100
        Dim y As Integer = 220

        Dim minY_normal = CInt(PictGray.Height * CSng((y) / PictureBox3.Height))
        Dim minX_normal = CInt(PictGray.Width * CSng((x) / PictureBox2.Width))
        Label4.Text = x
        Label5.Text = y

        NumericUpDown1.Value = minY_normal
        NumericUpDown2.Value = minX_normal
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If Label1.Text <> "Manusia!" Then 'kondisi jika selain manusia

            aktif = False
            'Timer3.Enabled = False

        Else 'kondisi jika manusia terdeteksi
            If aktif <> True Then 'kondisi jika form pemungutan suara belum terbuka

                Dim myform As New EVoting_Comvis.Form1 'inisialisasi form
                myform.Show() 'tampilkan form pemungutan suara

            End If
        End If

    End Sub

End Class
