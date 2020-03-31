Public Class Form5
    Dim u_admin As String = "admin"
    Dim p_admin As String = "admin"

    Dim u_cek As String = "cek"
    Dim p_cek As String = "cek"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = u_admin And TextBox2.Text = p_admin Then
            Dim myform As New Form3
            myform.Show()
            'Me.Hide()
        ElseIf TextBox1.Text = u_cek And TextBox2.Text = p_cek Then
            Dim myform As New Form2
            myform.Show()
            'Me.Hide()
        Else
            MessageBox.Show("Nama Pengguna atau Kata sandi salah", "Login gagal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim myform As New Form4
        myform.Show()
        'Me.Hide()
    End Sub
End Class