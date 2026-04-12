Public Class FormUtama
    ' Visual Studio sudah mendeklarasikan BtnKelolaAlbum di file Designer.
    ' Kamu cukup menulis logikanya saja di sini.

    Private Sub BtnKelolaAlbum_Click(sender As Object, e As EventArgs) Handles btnKelolaAlbum.Click
        ' Membuka Form CRUD (Pastikan nama form kamu adalah FormAlbum)
        Dim frm As New FormAlbum()
        frm.ShowDialog()
    End Sub

    ' Jika kamu ingin menjalankan sesuatu saat form pertama kali dibuka
    Private Sub FormUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Contoh: MessageBox.Show("Selamat Datang di Spotify Management")
    End Sub
End Class