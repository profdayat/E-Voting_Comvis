Imports Emgu.CV.Structure
Imports Emgu.CV
Imports System.Data.Odbc

Imports System.Net
Imports System.IO
Imports Newtonsoft.Json

Namespace EVoting_Comvis
    Partial Public Class Form1
        Inherits Form

        Private grabber As Capture

        Private currentFrame As Image(Of Bgr, Byte)
        Private currentFrameCopy As Image(Of Bgr, Byte)

        Private YCrCb_min As Ycc
        Private YCrCb_max As Ycc

        Private contourspoint As Contour(Of Point)
        Private biggestContourPoint As Contour(Of Point)
        Private approxContourpoint As Contour(Of Point)
        Private hull As Seq(Of Point)
        Private filteredHull As Seq(Of Point)
        Private defects As Seq(Of MCvConvexityDefect)
        Private defectArray() As MCvConvexityDefect

        Private handRect As Rectangle
        Private box As MCvBox2D

        Private verified As Boolean
        Private temporary As Integer = -1
        Private detik As Integer = 4
        Private timer_3 As Boolean

        Private jari As Integer

        Dim WithEvents cetakQR As New Printing.PrintDocument()


        Public Sub New()
            InitializeComponent()

            aktif = True 'parameter form pemungutan suara

            grabber = New Emgu.CV.Capture(1) 'Membuka kamera

            'memulai menjalankan frame
            AddHandler Application.Idle, AddressOf FrameGrabber
        End Sub

        Private Sub FrameGrabber(ByVal sender As Object, ByVal e As EventArgs)

            If motion_status = "-" Then
                grabber.Dispose()
                RemoveHandler Application.Idle, AddressOf FrameGrabber
                Me.Close()
            End If

            Label1.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")
            TextBox1.Focus()
            currentFrame = grabber.QueryFrame()

            'frame grabber
            currentFrame = grabber.QueryFrame()

            'cek ketersediaan frame
            If currentFrame IsNot Nothing Then

                currentFrameCopy = currentFrame.Copy() 'salin frame

                Dim skin As Image(Of Gray, Byte) = DetectSkin(currentFrameCopy) 'skin evaluation

                Dim erosi As Image(Of Gray, Byte) = Erotion(skin) 'erotion

                Dim dilasi As Image(Of Gray, Byte) = Dilation(erosi) 'dilation

                featureExtraction(dilasi) 'feature extraction

                imageBoxSkin.Image = dilasi 'Tampikan di imageBox
                imageBoxFrameGrabber.Image = currentFrame 'Tampilkan frame asli dan kontur
            End If

        End Sub

        Function DetectSkin(ByVal Img As Image(Of Bgr, Byte)) As Image(Of Gray, Byte)
            'Code adapted from here
            ' http://blog.csdn.net/scyscyao/archive/2010/04/09/5468577.aspx
            ' Look at this paper for reference (Chinese!!!!!)
            ' http://www.chinamca.com/UploadFile/200642991948257.pdf

            Dim currentYCrCbFrame As Image(Of Ycc, Byte) = Img.Convert(Of Ycc, Byte)()
            Dim skin As New Image(Of Gray, Byte)(Img.Width, Img.Height)

            Dim y, cr, cb, x1, y1, value As Integer

            Dim rows As Integer = Img.Rows
            Dim cols As Integer = Img.Cols
            Dim YCrCbData(,,) As Byte = currentYCrCbFrame.Data
            Dim skinData(,,) As Byte = skin.Data

            For i As Integer = 0 To rows - 1
                For j As Integer = 0 To cols - 1
                    y = YCrCbData(i, j, 0)
                    cr = YCrCbData(i, j, 1)
                    cb = YCrCbData(i, j, 2)

                    cb -= 109
                    cr -= 152
                    x1 = (819 * cr - 614 * cb) \ 32 + 51
                    y1 = (819 * cr + 614 * cb) \ 32 + 77
                    x1 = x1 * 41 \ 1024
                    y1 = y1 * 73 \ 1024
                    value = x1 * x1 + y1 * y1
                    If y < 100 Then
                        skinData(i, j, 0) = If(value < 700, CByte(255), CByte(0))
                    Else
                        skinData(i, j, 0) = If(value < 850, CByte(255), CByte(0))
                    End If

                Next j
            Next i

            Return skin
        End Function

        Function Erotion(ByVal skin As Image(Of Gray, Byte)) As Image(Of Gray, Byte)
            Dim erosi As New Image(Of Gray, Byte)(skin.Width, skin.Height)
            Dim rect_6 As New StructuringElementEx(6, 6, 3, 3, Emgu.CV.CvEnum.CV_ELEMENT_SHAPE.CV_SHAPE_RECT)

            CvInvoke.cvErode(skin, erosi, rect_6, 1) 'PENGIKISAN 1 ITERASI

            Return erosi
        End Function

        Function Dilation(ByVal skin As Image(Of Gray, Byte)) As Image(Of Gray, Byte)
            Dim dilasi As New Image(Of Gray, Byte)(skin.Width, skin.Height)
            Dim rect_6 As New StructuringElementEx(6, 6, 3, 3, Emgu.CV.CvEnum.CV_ELEMENT_SHAPE.CV_SHAPE_RECT)
            CvInvoke.cvDilate(skin, dilasi, rect_6, 2) 'PEMUAIAN 2 ITERASI
            Return dilasi
        End Function

        Private Sub featureExtraction(ByVal skin As Image(Of Gray, Byte))
            Using storage As New MemStorage()

                'mencari kontur dari warna kulit yang terdeteksi
                contourspoint = skin.FindContours(Emgu.CV.CvEnum.CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_SIMPLE,
                                                                      Emgu.CV.CvEnum.RETR_TYPE.CV_RETR_LIST, storage)

                '================== Pencarian kontur terbesar =======================================
                'mengkosongkan kontur terbesar
                biggestContourPoint = Nothing

                'cek ketersediaan kontur
                Dim Result1 As Double = 0
                Dim Result2 As Double = 0
                Do While contourspoint IsNot Nothing

                    Result1 = contourspoint.Area
                    If Result1 > Result2 Then
                        Result2 = Result1
                        biggestContourPoint = contourspoint
                    End If
                    contourspoint = contourspoint.HNext
                Loop
                '=====================================================================================

                'cek ketersediaan kontur terbesar
                If biggestContourPoint IsNot Nothing Then

                    '========================== ApproxPolygon =================================
                    approxContourpoint = biggestContourPoint.ApproxPoly(biggestContourPoint.Perimeter * 0.0025, storage)
                    currentFrame.Draw(approxContourpoint, New Bgr(Color.LimeGreen), 2) 'gambar garis kontur dengan warna hijau
                    biggestContourPoint = approxContourpoint
                    '==========================================================================

                    '========================== Convex Hull ====================================
                    hull = biggestContourPoint.GetConvexHull(Emgu.CV.CvEnum.ORIENTATION.CV_CLOCKWISE) 'ambil lambung cembung
                    currentFrame.Draw(biggestContourPoint, New Bgr(Color.LimeGreen), 2)
                    currentFrame.DrawPolyline(hull.ToArray(), True, New Bgr(200, 125, 75), 2) 'gambar polyline
                    '============================================================================

                    '============================ Convexity Defect =============================
                    defects = biggestContourPoint.GetConvexityDefacts(storage, Emgu.CV.CvEnum.ORIENTATION.CV_CLOCKWISE)
                    defectArray = defects.ToArray() 'masukkan kedalam array
                    '===========================================================================

                    '============================ kotak dan filtering ========================================
                    box = hull.GetMinAreaRect()
                    Dim points() As PointF = box.GetVertices() 'ambil sudut kotak
                    handRect = box.MinAreaRect()

                    ''membuat titik bulat
                    Dim ps(points.Length - 1) As Point
                    For i As Integer = 0 To points.Length - 1
                        ps(i) = New Point(CInt(Math.Truncate(points(i).X)), CInt(Math.Truncate(points(i).Y)))
                        Dim startCircle As New CircleF(ps(i), 5.0F)
                        'filterpoint.Draw(startCircle, New Bgr(Color.White), 10)
                    Next i

                    '========================== Filter Hull =====================================
                    filteredHull = New Seq(Of Point)(storage)
                    For i As Integer = 0 To hull.Total - 1
                        If Math.Sqrt(Math.Pow(hull(i).X - hull(i + 1).X, 2) +
                                     Math.Pow(hull(i).Y - hull(i + 1).Y, 2)) > CInt(box.size.Width) \ 10 Then
                            filteredHull.Push(hull(i))
                        End If
                    Next i
                    'convexhull.DrawPolyline(filteredHull.ToArray(), True, New Bgr(Color.White), 3) 'gambar polyline
                    '===========================================================================


                    ' =============== Get jumlah jari =================

                    Dim fingerNum As Integer = 0 'wadah hasil

                    For i = 0 To defects.Total - 1

                        Dim startPoint As New PointF(CSng(defectArray(i).StartPoint.X), CSng(defectArray(i).StartPoint.Y))
                        Dim depthPoint As New PointF(CSng(defectArray(i).DepthPoint.X), CSng(defectArray(i).DepthPoint.Y))
                        Dim endPoint As New PointF(CSng(defectArray(i).EndPoint.X), CSng(defectArray(i).EndPoint.Y))

                        Dim startDepthLine As New LineSegment2D(defectArray(i).StartPoint, defectArray(i).DepthPoint)
                        Dim depthEndLine As New LineSegment2D(defectArray(i).DepthPoint, defectArray(i).EndPoint)

                        Dim startCircle As New CircleF(startPoint, 5.0F)
                        Dim depthCircle As New CircleF(depthPoint, 5.0F)
                        Dim endCircle As New CircleF(endPoint, 5.0F)

                        '================= penentuan jumlah jari dalam research ================================================
                        If (startCircle.Center.Y < box.center.Y OrElse
                            depthCircle.Center.Y < box.center.Y) AndAlso
                            startCircle.Center.Y < depthCircle.Center.Y AndAlso
                                    (Math.Sqrt(Math.Pow(startCircle.Center.X - depthCircle.Center.X, 2) +
                                        Math.Pow(startCircle.Center.Y - depthCircle.Center.Y, 2)) > box.size.Height / 6.5) Then
                            fingerNum += 1
                            currentFrame.Draw(startDepthLine, New Bgr(Color.Green), 2)
                            'currentFrame.Draw(depthEndLine, New Bgr(Color.Magenta), 2)

                            currentFrame.Draw(startCircle, New Bgr(Color.Red), 2) 'menggambar lingkaran awal berwarna merah
                            currentFrame.Draw(depthCircle, New Bgr(Color.Yellow), 5) ' menggambar lingkaran dalam berwarna kuning
                        Else
                            'currentFrame.Draw(startDepthLine, New Bgr(Color.Red), 2)
                        End If

                        '=================================================================================

                    Next i
                    '======================= Akhir Get jumlah jari ==========================


                    '========= tampilkan teks sesuai dengan total jari yang terdeteksi ======================
                    Dim totalFinger As String

                    Dim font As New MCvFont(Emgu.CV.CvEnum.FONT.CV_FONT_HERSHEY_DUPLEX, 2.0R, 2.0R)

                    If fingerNum = 1 Then
                        totalFinger = "(1) Calon A"

                    ElseIf fingerNum = 2 Then
                        totalFinger = "(2) Calon B"

                    ElseIf fingerNum = 3 Then
                        totalFinger = "(3) Calon C"

                    ElseIf fingerNum = 4 Then
                        totalFinger = "(4) Calon D"

                    ElseIf fingerNum = 5 Then
                        totalFinger = "(5) Calon E"
                    Else
                        totalFinger = "TIDAK MEMILIH"

                    End If
                    currentFrame.Draw(totalFinger, font, New Point(150, 80), New Bgr(Color.Blue))
                    '========= Akhir menampilka teks sesuai dengan total jari yang terdeteksi ======================

                    jari = fingerNum 'HASIL DETEKSI dimasukkan ke variabel global

                    If verified = True Then 'jika data terverifikasi bernilai true
                        timer_jalan()
                    End If

                Else

                    detik = 4
                    Timer2.Stop()
                    Label14.Text = "3"

                End If
            End Using
        End Sub

        Private Sub TextBox1_KeyPress(sender As System.Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress

            If (e.KeyChar = Chr(13)) Then

                If TextBox1.Text <> "" Then

                    request_dpt()

                End If

            End If
        End Sub

        Sub request_dpt()
            Dim request As HttpWebRequest
            Dim response As HttpWebResponse
            Dim reader As StreamReader

            '===================konversi ASCII ke hex============================
            Dim str As String = TextBox1.Text
            Dim byteArray() As Byte
            Dim hexNumbers As System.Text.StringBuilder = New System.Text.StringBuilder
            byteArray = System.Text.ASCIIEncoding.ASCII.GetBytes(str)
            For i As Integer = 0 To byteArray.Length - 1
                hexNumbers.Append(byteArray(i).ToString("x"))
            Next
            '======================================================================

            '====================Integrasi dan cek presensi DPT====================
            Dim hx As String = hexNumbers.ToString()

            'alamat url sistem verifikator DPT
            Dim url As String = "http://localhost/postoriq/integrasi/api/" & hx '"http://192.168.43.186/dayzul/integrasi/api/" & hx
            Dim rawresp As String = Nothing

            Try
                'request dan response
                request = DirectCast(WebRequest.Create(url), HttpWebRequest)
                response = DirectCast(request.GetResponse(), HttpWebResponse)

                'pembaca respose
                reader = New StreamReader(response.GetResponseStream())
                rawresp = reader.ReadToEnd()

                'parsing file json/deserialize object
                Dim result = JsonConvert.DeserializeObject(Of List(Of Header))(rawresp)

                'wadah untuk parsing
                Dim data As String = Nothing

                'isi variabel data dengan kode unik dpt
                For Each t_presensi In result
                    data = t_presensi.kode_unik_dpt '& t_presensi.waktu_datang
                Next

                If data <> "404" Then 'kondisi jika sudah registrasi

                    cek_katalis() 'panggil proses cek katalis

                Else 'kondisi jika DPT belum registrasi
                    msgboxautoclose("Maaf, Mohon regristrasi di panitia...", MsgBoxStyle.Exclamation, "Maaf !!", 5)
                    TextBox1.Text = ""
                    TextBox1.Focus()
                End If

            Catch ex As WebException
                msgboxautoclose("Cek koneksi...", MsgBoxStyle.Exclamation, "Perhatian !!", 5)
                TextBox1.Text = ""
                TextBox1.Focus()
            End Try
        End Sub

        Sub cek_katalis()
            Call Koneksi()
            CMD = New OdbcCommand("Select * From t_katalis where KODE_UNIK_DPT_K='" & TextBox1.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If Not RD.HasRows Then
                verified = True
                Timer3.Start()
            Else

                msgboxautoclose("Maaf, QRCode ini telah memilih Calon PILDES...", MsgBoxStyle.Exclamation, "Maaf !!", 5)

                TextBox1.Text = ""
                TextBox1.Focus()
            End If
        End Sub

        Sub simpan()

            Call Koneksi()

            Dim waktu As String = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")
            Dim simpann As String = "INSERT INTO `t_katalis` (`KODE_UNIK_DPT_K`, `WAKTU_MEMILIH`) VALUES('" & TextBox1.Text & "', now())"
            CMD = New OdbcCommand(simpann, CONN)
            CMD.ExecuteNonQuery()


            'password triple des
            Dim tdes As New TripleDES("12345")

            Dim hsl_enkrip As String = tdes.Encrypt(jari & waktu & TextBox1.Text) 'Enkripsi

            Dim QR_Generate As New MessagingToolkit.QRCode.Codec.QRCodeEncoder 'Generate QR Code

            PictureBox1.Image = QR_Generate.Encode(hsl_enkrip) 'Tampilkan QR Code

            'PictureBox1.Image.Save("D:\QR.jpg")
            'If My.Computer.FileSystem.FileExists("C:\QR.jpg") Then
            '    Print("C:\QR.jpg")
            'End If

            'cetakQR.Print() 'Cetak QR Code


            'simpan ke database
            Dim simpan As String = "insert into t_enkripsi_hasil_pemungutan_suara values ('" & hsl_enkrip & "')"
            CMD = New OdbcCommand(simpan, CONN)
            CMD.ExecuteNonQuery()

            msgboxautoclose("Terima kasih telah menjadi pemilih PILDES.." & vbNewLine & "Waktu :" & waktu, MsgBoxStyle.Information, "Suksess...", 5)

            PictureBox1.Image = Nothing

        End Sub

        Sub timer_jalan()
            If temporary <> jari Then

                detik = 4
                Timer2.Stop()
                temporary = jari
            End If

            If detik = 4 Then
                Timer2.Start()
                TextBox1.Enabled = False
            End If

            If detik < 1 And temporary <> 0 Then
                verified = False 'mengubah nilai bolean menjadi false
                Timer2.Stop()
                Timer3.Stop()
                simpan()
                detik = 4
                TextBox1.Text = ""
                Label2.Text = ""
                TextBox1.Enabled = True
                TextBox1.Focus()
            End If
        End Sub

        Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
            detik = detik - 1
            Label14.Text = Str(detik)
            If detik = 0 Then
                Timer2.Stop()
                Label14.Text = "3"
            End If

        End Sub

        Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
            If timer_3 = True Then
                Label2.Text = ""
                timer_3 = False
            Else
                Label2.Text = "• Silahkan Anda MEMILIH"
                timer_3 = True
            End If
        End Sub

        Public Class Header
            Public Property kode_unik_dpt As String
            Public Property waktu_datang As String

        End Class

        Private Sub PrintImage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles cetakQR.PrintPage
            e.Graphics.DrawImage(PictureBox1.Image, 10, 0)
        End Sub

        Private Declare Sub keybd_event Lib "user32" (ByVal bVk As Byte,
                       ByVal bScan As Byte,
                       ByVal dwFlags As Byte,
                       ByVal dwExtraInfo As Byte)

        Private Const VK_RETURN As Byte = &HD
        Private Const KEYEVENTF_KEYDOWN As Byte = &H0
        Private Const KEYEVENTF_KEYUP As Byte = &H2

        Public Sub msgboxautoclose(ByVal Message As String, Optional ByVal Style As MsgBoxStyle = Nothing, Optional ByVal title As String = Nothing, Optional ByVal delay As Integer = 5)
            Dim t As New Threading.Thread(AddressOf closeMsgbox)
            t.Start(delay) '5 second default delay
            MsgBox(Message, Style, title)

        End Sub

        Private Sub closeMsgbox(ByVal delay As Object)
            Threading.Thread.Sleep(CInt(delay) * 1000)
            AppActivate(Me.Text)
            keybd_event(VK_RETURN, 0, KEYEVENTF_KEYDOWN, 0)
            keybd_event(VK_RETURN, 0, KEYEVENTF_KEYUP, 0)
        End Sub

    End Class
End Namespace