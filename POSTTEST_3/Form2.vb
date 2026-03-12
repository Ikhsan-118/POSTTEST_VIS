Public Class FormHasil

    ' Metode untuk menerima data dari FormCetak
    Public Sub TerimaData(foto As Image, nama As String, umur As String, telp As String, jk As String, tglLahir As String, alamat As String, hobby As String)

        pbFotoHasil.SizeMode = PictureBoxSizeMode.StretchImage
        pbFotoHasil.Image = foto

        lblNamaHasil.Text = "Nama : " & nama
        lblUmurHasil.Text = "Umur : " & umur & " Tahun"
        lblTelpHasil.Text = "No. Telp : " & telp
        lblJenisKelaminHasil.Text = "Gender : " & jk
        lblTanggalLahirHasil.Text = "Tgl Lahir : " & tglLahir
        lblAlamatHasil.Text = "Alamat : " & alamat
        lblHobbyHasil.Text = "Hobby : " & hobby

    End Sub

End Class