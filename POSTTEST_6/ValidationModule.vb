' =============================================================
' ValidationModule.vb
' Berisi fungsi-fungsi validasi input untuk seluruh form
' =============================================================
Module ValidationModule

    ''' <summary>Validasi TextBox tidak boleh kosong</summary>
    Public Function ValidasiTextBox(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
        If txt.Text.Trim() = "" Then
            ep.SetError(txt, pesan)
            Return False
        End If
        ep.SetError(txt, "")
        Return True
    End Function

    ''' <summary>Validasi ComboBox harus dipilih</summary>
    Public Function ValidasiComboBox(ep As ErrorProvider, cb As ComboBox, pesan As String) As Boolean
        If cb.SelectedIndex < 0 OrElse cb.SelectedValue Is Nothing Then
            ep.SetError(cb, pesan)
            Return False
        End If
        ep.SetError(cb, "")
        Return True
    End Function

    ''' <summary>Validasi input form Album</summary>
    Public Function ValidasiInputAlbum(ep As ErrorProvider,
                                       txtKode As TextBox,
                                       txtJudul As TextBox,
                                       txtArtis As TextBox,
                                       txtTahun As TextBox) As Boolean
        Dim kodeOk  As Boolean = ValidasiTextBox(ep, txtKode,  "Kode Album wajib diisi!")
        Dim judulOk As Boolean = ValidasiTextBox(ep, txtJudul, "Judul Album wajib diisi!")
        Dim artisOk As Boolean = ValidasiTextBox(ep, txtArtis, "Nama Artis wajib diisi!")
        Dim tahunOk As Boolean = ValidasiTextBox(ep, txtTahun, "Tahun Rilis wajib diisi!")

        If tahunOk Then
            Dim t As Integer
            If Not Integer.TryParse(txtTahun.Text.Trim(), t) OrElse t < 1900 OrElse t > 2100 Then
                ep.SetError(txtTahun, "Tahun tidak valid (contoh: 2024)")
                tahunOk = False
            End If
        End If

        Return kodeOk And judulOk And artisOk And tahunOk
    End Function

    ''' <summary>Validasi input form Lagu</summary>
    Public Function ValidasiInputLagu(ep As ErrorProvider,
                                      txtKode As TextBox,
                                      cbAlbum As ComboBox,
                                      txtJudul As TextBox,
                                      txtDurasi As TextBox,
                                      txtTrack As TextBox) As Boolean
        Dim kodeOk   As Boolean = ValidasiTextBox(ep, txtKode,  "Kode Lagu wajib diisi!")
        Dim albumOk  As Boolean = ValidasiComboBox(ep, cbAlbum, "Pilih Album terlebih dahulu!")
        Dim judulOk  As Boolean = ValidasiTextBox(ep, txtJudul, "Judul Lagu wajib diisi!")
        Dim durasiOk As Boolean = ValidasiTextBox(ep, txtDurasi,"Durasi wajib diisi (detik)!")
        Dim trackOk  As Boolean = ValidasiTextBox(ep, txtTrack, "Nomor track wajib diisi!")

        If durasiOk Then
            Dim d As Integer
            If Not Integer.TryParse(txtDurasi.Text.Trim(), d) OrElse d <= 0 Then
                ep.SetError(txtDurasi, "Durasi harus berupa angka positif (detik)")
                durasiOk = False
            End If
        End If

        If trackOk Then
            Dim tr As Integer
            If Not Integer.TryParse(txtTrack.Text.Trim(), tr) OrElse tr <= 0 Then
                ep.SetError(txtTrack, "Nomor track harus berupa angka positif")
                trackOk = False
            End If
        End If

        Return kodeOk And albumOk And judulOk And durasiOk And trackOk
    End Function

    ''' <summary>Mencegah input selain angka pada KeyPress</summary>
    Public Sub HanyaAngka(e As KeyPressEventArgs)
        If Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
    End Sub

    ''' <summary>Cek apakah tombol Enter ditekan</summary>
    Public Function IsEnterKey(e As KeyPressEventArgs) As Boolean
        Return e.KeyChar = ControlChars.Cr
    End Function

End Module
