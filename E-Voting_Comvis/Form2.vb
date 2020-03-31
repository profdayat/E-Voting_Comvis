Imports System.Data.Odbc

Public Class Form2

    Dim tdes As New TripleDES("12345")
    Dim arr() As String

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call Koneksi()
        DA = New OdbcDataAdapter("select * From t_rekap_hasil_pemungutan_suara ", CONN)
        DS = New DataSet
        DA.Fill(DS, "t_rekap_hasil_pemungutan_suara")
        Dim total As Integer = DS.Tables("t_rekap_hasil_pemungutan_suara").Rows.Count

        Label2.Text = total

        ReDim arr(total - 1)

        For i As Integer = 0 To total - 1

            Dim Decrypt As String = tdes.Decrypt(CType(DS.Tables("t_rekap_hasil_pemungutan_suara").Rows(i).ItemArray(0), String))

            arr(i) = Decrypt.Substring(0, 1)
            DataGridView1.Rows.Add(1)
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(0).Value = Decrypt.Substring(0, 1)
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(1).Value = Decrypt.Substring(1, 19)
            DataGridView1.Update()

            DataGridView1.FirstDisplayedScrollingRowIndex = DataGridView1.Rows(DataGridView1.RowCount - 2).Index

            'DataGridView1.Refresh()

            DataGridView1.CurrentCell = DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(0)

            DataGridView1.Rows(DataGridView1.RowCount - 2).Selected = True

        Next

        DA = New OdbcDataAdapter("select * From t_enkripsi_hasil_pemungutan_suara ", CONN)
        DS = New DataSet
        DA.Fill(DS, "t_enkripsi_hasil_pemungutan_suara")
        Label1.Text = CType(DS.Tables("t_enkripsi_hasil_pemungutan_suara").Rows.Count - total, String)

        TextBox1.Select()

        perbarui()
    End Sub

    Private Sub TextBox1_KeyPress(sender As System.Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress

        If (e.KeyChar = Chr(13)) Then
            proses_rekap()
            TextBox1.Clear()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        proses_rekap()
        TextBox1.Clear()
    End Sub

    Sub proses_rekap()
        Call Koneksi()
        CMD = New OdbcCommand("Select * From t_enkripsi_hasil_pemungutan_suara where UNION_KODE='" & TextBox1.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then
            MsgBox("hasil tidak ditemukan!", MsgBoxStyle.Critical, "kesalahan") '("hasil tidak ditemukan!")
            TextBox1.Focus()
        Else

            CMD = New OdbcCommand("Select * From t_rekap_hasil_pemungutan_suara where UNION_KODE='" & TextBox1.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            If Not RD.HasRows Then

                Dim hsl_rekap As String = RD.Item("UNION_KODE")

                Dim simpan As String = "insert into t_rekap_hasil_pemungutan_suara values ('" & hsl_rekap & "')"
                CMD = New OdbcCommand(simpan, CONN)
                CMD.ExecuteNonQuery()

                MsgBox(hsl_rekap, MsgBoxStyle.Information, "Berhasil")
                TextBox1.Focus()

                Dim Decrypt As String = tdes.Decrypt(hsl_rekap)

                DataGridView1.Rows.Add(1)
                DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(0).Value = Decrypt.Substring(0, 1)
                DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(1).Value = Decrypt.Substring(1, 19)

                DataGridView1.Update()

                DataGridView1.FirstDisplayedScrollingRowIndex = DataGridView1.Rows(DataGridView1.RowCount - 2).Index

                DataGridView1.CurrentCell = DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(0)

                DataGridView1.Rows(DataGridView1.RowCount - 2).Selected = True

                perbarui()
            Else
                MsgBox("qr code ini pernah direkap!", MsgBoxStyle.Critical, "kesalahan") '("hasil tidak ditemukan!")
                TextBox1.Focus()
            End If
        End If
    End Sub

    Sub perbarui()
        Dim belum As Integer
        Dim sudah As Integer
        Dim counts As New Dictionary(Of String, Integer)

        Call Koneksi()
        DA = New OdbcDataAdapter("select * From t_enkripsi_hasil_pemungutan_suara ", CONN)
        DS = New DataSet
        DA.Fill(DS, "t_enkripsi_hasil_pemungutan_suara")
        belum = CType(DS.Tables("t_enkripsi_hasil_pemungutan_suara").Rows.Count, String)

        sudah = DataGridView1.RowCount - 1

        Label1.Text = belum - sudah
        Label2.Text = sudah

        TextBox1.Select()

        DA = New OdbcDataAdapter("select * From t_rekap_hasil_pemungutan_suara ", CONN)
        Dim Dl As DataSet = New DataSet
        DA.Fill(Dl, "t_rekap_hasil_pemungutan_suara")
        Dim total As Integer = Dl.Tables("t_rekap_hasil_pemungutan_suara").Rows.Count

        Dim arr(total - 1)

        For i As Integer = 0 To total - 1

            Dim Decrypt As String = tdes.Decrypt(CType(Dl.Tables("t_rekap_hasil_pemungutan_suara").Rows(i).ItemArray(0), String))

            arr(i) = Decrypt.Substring(0, 1)

        Next

        Array.Sort(arr)

        For i As Integer = 0 To total - 1
            If Not counts.ContainsKey(arr(i)) Then
                counts.Add(arr(i), 1)
            Else
                counts.Item(arr(i)) = counts.Item(arr(i)) + 1
            End If
        Next

        Dim totpem As Integer
        Dim calno As Integer

        Dim infocalon(5) As Integer
        Dim infopemilih(5) As Integer

        Dim info(5) As String

        For Each kvp As KeyValuePair(Of String, Integer) In counts
            info(kvp.Key) = kvp.Value '"0" & kvp.Key & kvp.Value

            infocalon(kvp.Key) = kvp.Key
            infopemilih(kvp.Key) = kvp.Value

            If kvp.Value > totpem Then
                totpem = kvp.Value
                calno = kvp.Key
            End If
        Next

        c1.Text = "Calon Urut-" & "1" & " Total pemilih " & infopemilih(1)
        c2.Text = "Calon Urut-" & "2" & " Total pemilih " & infopemilih(2)
        c3.Text = "Calon Urut-" & "3" & " Total pemilih " & infopemilih(3)
        c4.Text = "Calon Urut-" & "4" & " Total pemilih " & infopemilih(4)
        c5.Text = "Calon Urut-" & "5" & " Total pemilih " & infopemilih(5)

        If belum - sudah < 1 Then
            LabelPemenang.Text = "PEMENANG Calon Urut-" & calno & " Total pemilih " & totpem
        End If

    End Sub

End Class