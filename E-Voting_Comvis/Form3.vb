Imports System.ComponentModel
Imports System.Data.Odbc
Imports System.Windows.Forms.DataVisualization.Charting

Imports System.Threading
Public Class Form3

    Dim tdes As New TripleDES("12345")

    Dim counts As New Dictionary(Of String, Integer)
    Dim informasi As New Dictionary(Of String, Integer)
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilGrid()
    End Sub

    Sub tampilchart()
        Chart1.Series.Clear()

        Chart1.Series.Add("Hasil Pemungutan")

        Dim pemenangtmp As Integer
        Dim pemenang As Integer

        For Each kvp As KeyValuePair(Of String, Integer) In counts
            Debug.Print(kvp.Key & kvp.Value)

            Chart1.Series(0).ChartType = SeriesChartType.StackedColumn


            Chart1.Series(0).Points.Clear()
            Chart1.Series(0).Points.AddXY(kvp.Key, kvp.Value)
            If kvp.Value > pemenangtmp Then
                pemenangtmp = kvp.Value
                pemenang = kvp.Key
            End If
        Next
        Chart1.Update()

        Label4.Text = pemenang & " dengan total " & pemenangtmp & " pemilih"
    End Sub
    Sub TampilGrid()
        Call Koneksi()
        DA = New OdbcDataAdapter("select * From t_enkripsi_hasil_pemungutan_suara ", CONN)
        DS = New DataSet
        DA.Fill(DS, "t_enkripsi_hasil_pemungutan_suara")
        'DataGridView1.DataSource = DS.Tables("hsl")
        'DataGridView1.ReadOnly = True

        Label7.Text = "Total seluruh pemilih = " & CType(DS.Tables("t_enkripsi_hasil_pemungutan_suara").Rows.Count, String)

        Dim total As Integer = DS.Tables("t_enkripsi_hasil_pemungutan_suara").Rows.Count - 1

        Dim arr(total) As String

        'Dim counts As New Dictionary(Of String, Integer)
        For i As Integer = 0 To total
            'Label1.Text = i
            Dim Decrypt As String = tdes.Decrypt(CType(DS.Tables("t_enkripsi_hasil_pemungutan_suara").Rows(i).ItemArray(0), String))


            arr(i) = Decrypt.Substring(0, 1)
            DataGridView1.Rows.Add(1)
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(0).Value = Decrypt.Substring(0, 1)
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(1).Value = Decrypt.Substring(1, 19)
            DataGridView1.Update()
            'tampilchart()
            'If i = 29 Then

            'End If

        Next

        Array.Sort(arr)

        For i As Integer = 0 To total
            If Not counts.ContainsKey(arr(i)) Then
                counts.Add(arr(i), 1)
            Else
                counts.Item(arr(i)) = counts.Item(arr(i)) + 1
            End If
        Next

        'Thread.Sleep(5000)

        Chart1.Series.Clear()
        Chart1.Series.Add("Hasil Pemungutan")

        Dim totpem As Integer
        Dim calno As Integer

        Dim infocalon(5) As Integer
        Dim infopemilih(5) As Integer

        Dim info(5) As String

        For Each kvp As KeyValuePair(Of String, Integer) In counts
            ' Debug.Print(kvp.Key & kvp.Value)
            'Chart1.Series(0).Points.Clear()

            Chart1.Series(0).ChartType = SeriesChartType.StackedColumn



            Chart1.Series(0).Points.AddXY(kvp.Key, kvp.Value)
            'Chart1.Series(1).Points.AddXY(kvp.Key, kvp.Value)

            info(kvp.Key) = kvp.Value '"0" & kvp.Key & kvp.Value

            infocalon(kvp.Key) = kvp.Key
            infopemilih(kvp.Key) = kvp.Value

            If kvp.Value > totpem Then
                totpem = kvp.Value
                calno = kvp.Key
            End If

            'If kvp.Value > totpem Then
            '    totpem = kvp.Value
            '    calno = kvp.Key
            'End If
            Chart1.Update()
        Next

        'Array.Sort(info)
        'Array.Reverse(info)

        Label1.Text = "Calon Urut-" & infocalon(1) & " Total pemilih " & infopemilih(1)
        Label2.Text = "Calon Urut-" & infocalon(2) & " Total pemilih " & infopemilih(2)
        Label3.Text = "Calon Urut-" & infocalon(3) & " Total pemilih " & infopemilih(3)
        Label4.Text = "Calon Urut-" & infocalon(4) & " Total pemilih " & infopemilih(4)
        Label5.Text = "Calon Urut-" & infocalon(5) & " Total pemilih " & infopemilih(5)

        Label6.Text = "PEMENANG Calon Urut-" & calno & " Total pemilih " & totpem


        'Dim array As String = DS.Tables("hasil").Rows(0).ItemArray(0)

        'TextBox1.Text = arr(0)

        'With Chart1
        '    Dim nmsiswa() As String = {"Calon A", "Calon B", "Calon C", "Calon D", "Calon E"}
        '    .Series.Clear()
        '    For a As Integer = 0 To nmsiswa.Length - 1
        '        .Series.Add(nmsiswa(a))

        '    Next


        '    .Series(0).ChartType = SeriesChartType.Pie
        '    .Series(1).ChartType = SeriesChartType.Pie
        '    .Series(2).ChartType = SeriesChartType.Pie
        '    .Series(3).ChartType = SeriesChartType.Pie

        '    .Series(0).Points.AddXY(nmsiswa(0), counts.Values(0))
        '    .Series(1).Points.AddXY(nmsiswa(1), counts.Values(1))
        '    .Series(2).Points.AddXY(nmsiswa(2), counts.Values(2))
        '    .Series(3).Points.AddXY(nmsiswa(3), counts.Values(3))

        'End With

        'tr.Abort()
    End Sub
End Class
