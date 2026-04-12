Public Class FormAlbum
    ' Prosedur untuk membersihkan form
    Private Sub Kosong()
        txtKodeAlbum.Clear()
        txtJudul.Clear()
        txtArtis.Clear()
        txtTahun.Clear()
        txtGenree.Clear()
        txtSearch.Clear()
        txtKodeAlbum.Enabled = True
        txtKodeAlbum.Focus()
    End Sub

    Private Sub TampilData()
        dgvAlbum.DataSource = GetAllAlbum()
    End Sub

    Private Sub FormAlbum_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
    End Sub

    ' Event klik tombol Simpan
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If SimpanAlbum(txtKodeAlbum.Text, txtJudul.Text, txtArtis.Text, Val(txtTahun.Text), txtGenree.Text) Then
            MessageBox.Show("Album Berhasil Disimpan")
            TampilData()
            Kosong()
        End If
    End Sub

    ' Event klik tombol Ubah
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If UbahAlbum(txtKodeAlbum.Text, txtJudul.Text, txtArtis.Text, Val(txtTahun.Text), txtGenree.Text) Then
            MessageBox.Show("Album Berhasil Diperbarui")
            TampilData()
            Kosong()
        End If
    End Sub

    ' Klik sel di DataGridView untuk memindahkan data ke TextBox
    Private Sub dgvAlbum_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAlbum.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvAlbum.Rows(e.RowIndex)
            txtKodeAlbum.Text = row.Cells(0).Value.ToString()
            txtJudul.Text = row.Cells(1).Value.ToString()
            txtArtis.Text = row.Cells(2).Value.ToString()
            txtTahun.Text = row.Cells(3).Value.ToString()
            txtGenree.Text = row.Cells(4).Value.ToString() ' Mengambil data genre ke txtGenree
            txtKodeAlbum.Enabled = False
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosong()
    End Sub
End Class