Imports System.Data.Odbc

Module Module2

    Public motion_status As String
    Public aktif As Boolean

    Public CONN As OdbcConnection
    Public CMD As OdbcCommand
    Public DS As New DataSet
    Public DA As OdbcDataAdapter
    Public RD As OdbcDataReader
    Public LokasiData As String

    Public Sub Koneksi()
        LokasiData = "Driver={MySQL ODBC 3.51 Driver};Database=db_smart_sistem;server=localhost;uid=root"
        CONN = New OdbcConnection(LokasiData)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
    End Sub

End Module
