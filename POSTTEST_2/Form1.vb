Public Class Form1

    'Menampilkan data buku ke ListBox
    Sub TampilData()

        ListBox1.Items.Clear()
        For i As Integer = 0 To jumlahBuku - 1
            ListBox1.Items.Add(daftarBuku(i, 0) & " (" & daftarBuku(i, 1) & ")")
        Next

    End Sub


    'Saat program pertama dijalankan
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TambahBuku("Harry Potter", "Fantasi")
        TambahBuku("Sherlock Holmes", "Misteri")
        TampilData()

    End Sub


    'Tombol Tambah
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        TambahBuku(txtJudul.Text, txtGenre.Text)
        TampilData()
        txtJudul.Clear()
        txtGenre.Clear()

    End Sub


    'Tombol Hapus
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        HapusBuku(txtHapus.Text)
        TampilData()
        txtHapus.Clear()

    End Sub

End Class