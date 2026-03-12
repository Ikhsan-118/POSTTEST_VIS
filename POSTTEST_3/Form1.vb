Public Class FormCetak

    ' Fitur Browse Foto
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        openFileDialog.Title = "Pilih Foto Profile"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            pbFoto.Image = Image.FromFile(openFileDialog.FileName)
            pbFoto.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    ' Validasi Nama Hanya Huruf dan Spasi
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Validasi Umur dan No Telepon Hanya Angka
    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress, txtTelp.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Validasi Inputan Kosong & Cetak Kartu
    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        ' Cek Textbox kosong
        If String.IsNullOrWhiteSpace(txtNama.Text) OrElse
           String.IsNullOrWhiteSpace(txtUmur.Text) OrElse
           String.IsNullOrWhiteSpace(txtTelp.Text) OrElse
           String.IsNullOrWhiteSpace(txtAlamat.Text) Then
            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Cek Foto Kosong
        If pbFoto.Image Is Nothing Then
            MessageBox.Show("Inputan tidak boleh kosong (Foto belum diunggah)", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Cek RadioButton (Jenis Kelamin) Kosong
        If Not rbLaki.Checked AndAlso Not rbPerempuan.Checked Then
            MessageBox.Show("Inputan tidak boleh kosong (Pilih Jenis Kelamin)", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Cek CheckBox (Hobby) Kosong
        Dim isHobbyChecked As Boolean = False
        Dim daftarHobby As String = ""

        For Each ctrl As Control In gbHobby.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim chk As CheckBox = DirectCast(ctrl, CheckBox)
                If chk.Checked Then
                    isHobbyChecked = True
                    daftarHobby &= chk.Text & ", "
                End If
            End If
        Next

        If Not isHobbyChecked Then
            MessageBox.Show("Inputan tidak boleh kosong (Pilih minimal 1 Hobby)", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        daftarHobby = daftarHobby.TrimEnd(", ".ToCharArray())
        Dim jenisKelamin As String = If(rbLaki.Checked, "Laki-laki", "Perempuan")

        ' Buka Form Hasil dan kirim data
        Dim formHasil As New FormHasil()
        formHasil.TerimaData(pbFoto.Image, txtNama.Text, txtUmur.Text, txtTelp.Text, jenisKelamin, dtpTanggalLahir.Value.ToString("dd MMMM yyyy"), txtAlamat.Text, daftarHobby)

        formHasil.ShowDialog()
    End Sub

End Class