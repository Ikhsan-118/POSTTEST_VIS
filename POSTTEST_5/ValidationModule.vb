Module ValidationModule
    Public Sub HanyaAngka(e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Function ValidasiTextBox(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
        If txt.Text.Trim() = "" Then
            ep.SetError(txt, pesan)
            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function

    Public Function ValidasiInputAlbum(ep As ErrorProvider, txtKode As TextBox, txtJudul As TextBox, txtArtis As TextBox, txtTahun As TextBox) As Boolean
        Dim vKode = ValidasiTextBox(ep, txtKode, "Kode Album tidak boleh kosong!")
        Dim vJudul = ValidasiTextBox(ep, txtJudul, "Judul Album tidak boleh kosong!")
        Dim vArtis = ValidasiTextBox(ep, txtArtis, "Nama Artis tidak boleh kosong!")
        Dim vTahunStr = ValidasiTextBox(ep, txtTahun, "Tahun rilis tidak boleh kosong!")

        Dim vTahunAngka As Boolean = True
        Dim parseTahun As Integer

        ' Memastikan isi txtTahun adalah angka yang valid untuk mencegah format exception
        If vTahunStr AndAlso Not Integer.TryParse(txtTahun.Text.Trim(), parseTahun) Then
            ep.SetError(txtTahun, "Tahun harus berupa angka!")
            vTahunAngka = False
        End If

        Return vKode And vJudul And vArtis And vTahunStr And vTahunAngka
    End Function
End Module