' =============================================================
' FormAlbum.vb
' Form CRUD untuk tabel tbalbum (Tabel Induk)
' Fitur: Simpan, Ubah, Hapus, Cari, Pilih dari DataGridView
' Navigasi ke FormLagu untuk melihat lagu per album
' =============================================================
Imports MySqlConnector

Public Class FormAlbum

    ' ── Helper: kosongkan semua input ──────────────────────
    Private Sub Kosong()
        txtKodeAlbum.Clear()
        txtJudul.Clear()
        txtArtis.Clear()
        txtTahun.Clear()
        txtGenre.Clear()
        txtSearch.Clear()
        ErrorProvider1.Clear()
        txtKodeAlbum.Enabled = True
        txtKodeAlbum.Focus()
    End Sub

    ' ── Helper: tampilkan data ke grid ─────────────────────
    Private Sub TampilData()
        dgvAlbum.DataSource = GetAllAlbum()
        StyleGrid(dgvAlbum)
    End Sub

    ' ── Style grid agar lebih rapi ─────────────────────────
    Private Sub StyleGrid(dgv As DataGridView)
        dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(30, 215, 96)
        dgv.DefaultCellStyle.SelectionForeColor = Color.Black
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(24, 24, 24)
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18)
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(30, 215, 96)
        dgv.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        dgv.EnableHeadersVisualStyles = False
        If dgv.Columns.Contains("kodeAlbum") Then
            dgv.Columns("kodeAlbum").HeaderText = "Kode"
            dgv.Columns("kodeAlbum").Width = 80
        End If
        If dgv.Columns.Contains("judulAlbum") Then
            dgv.Columns("judulAlbum").HeaderText = "Judul Album"
            dgv.Columns("judulAlbum").Width = 200
        End If
        If dgv.Columns.Contains("artis") Then
            dgv.Columns("artis").HeaderText = "Artis"
            dgv.Columns("artis").Width = 140
        End If
        If dgv.Columns.Contains("tahunRilis") Then
            dgv.Columns("tahunRilis").HeaderText = "Tahun"
            dgv.Columns("tahunRilis").Width = 65
        End If
        If dgv.Columns.Contains("genre") Then
            dgv.Columns("genre").HeaderText = "Genre"
            dgv.Columns("genre").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End If
    End Sub

    ' ── Load form ──────────────────────────────────────────
    Private Sub FormAlbum_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        Kosong()
        UpdateStatusBar()
    End Sub

    ' ── Status bar total album ──────────────────────────────
    Private Sub UpdateStatusBar()
        Dim dt As DataTable = GetAllAlbum()
        lblStatus.Text = $"Total Album: {dt.Rows.Count}"
    End Sub

    ' ══════════════════════════════════════════════════════
    ' TOMBOL SIMPAN
    ' ══════════════════════════════════════════════════════
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()
        If Not ValidasiInputAlbum(ErrorProvider1, txtKodeAlbum, txtJudul, txtArtis, txtTahun) Then Exit Sub

        If KodeSudahAda(txtKodeAlbum.Text.Trim()) Then
            MessageBox.Show("Kode Album sudah terdaftar!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtKodeAlbum.Focus()
            Exit Sub
        End If

        Dim tahun As Integer = Integer.Parse(txtTahun.Text.Trim())
        If SimpanAlbum(txtKodeAlbum.Text.Trim(), txtJudul.Text.Trim(),
                       txtArtis.Text.Trim(), tahun, txtGenre.Text.Trim()) Then
            MessageBox.Show("Album berhasil ditambahkan!", "Sukses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
            UpdateStatusBar()
        End If
    End Sub

    ' ══════════════════════════════════════════════════════
    ' TOMBOL UBAH
    ' ══════════════════════════════════════════════════════
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        ErrorProvider1.Clear()
        If Not ValidasiInputAlbum(ErrorProvider1, txtKodeAlbum, txtJudul, txtArtis, txtTahun) Then Exit Sub

        Dim tahun As Integer = Integer.Parse(txtTahun.Text.Trim())
        If UbahAlbum(txtKodeAlbum.Text.Trim(), txtJudul.Text.Trim(),
                     txtArtis.Text.Trim(), tahun, txtGenre.Text.Trim()) Then
            MessageBox.Show("Data Album berhasil diperbarui!", "Sukses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        Else
            MessageBox.Show("Data tidak ditemukan!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' ══════════════════════════════════════════════════════
    ' TOMBOL HAPUS
    ' ══════════════════════════════════════════════════════
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtKodeAlbum.Text.Trim() = "" Then
            MessageBox.Show("Pilih album dari tabel terlebih dahulu!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim hasil As DialogResult = MessageBox.Show(
            $"Hapus album '{txtJudul.Text}'?" & Environment.NewLine &
            "Semua lagu dalam album ini juga akan ikut terhapus (CASCADE).",
            "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If hasil = DialogResult.Yes Then
            If HapusAlbum(txtKodeAlbum.Text.Trim()) Then
                MessageBox.Show("Album berhasil dihapus.", "Sukses",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                Kosong()
                UpdateStatusBar()
            End If
        End If
    End Sub

    ' ══════════════════════════════════════════════════════
    ' TOMBOL BATAL
    ' ══════════════════════════════════════════════════════
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosong()
        TampilData()
    End Sub

    ' ══════════════════════════════════════════════════════
    ' TOMBOL LIHAT LAGU — buka FormLagu dengan filter album
    ' ══════════════════════════════════════════════════════
    Private Sub btnLihatLagu_Click(sender As Object, e As EventArgs) Handles btnLihatLagu.Click
        If txtKodeAlbum.Text.Trim() = "" Then
            MessageBox.Show("Pilih album dari tabel terlebih dahulu!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim frm As New FormLagu(txtKodeAlbum.Text.Trim(), txtJudul.Text.Trim())
        frm.ShowDialog()
        TampilData()
    End Sub

    ' ══════════════════════════════════════════════════════
    ' TOMBOL KELOLA SEMUA LAGU — buka FormLagu tanpa filter
    ' ══════════════════════════════════════════════════════
    Private Sub btnSemuaLagu_Click(sender As Object, e As EventArgs) Handles btnSemuaLagu.Click
        Dim frm As New FormLagu("", "")
        frm.ShowDialog()
    End Sub

    ' ── Klik baris pada DataGridView ───────────────────────
    Private Sub dgvAlbum_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAlbum.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvAlbum.Rows(e.RowIndex)
            txtKodeAlbum.Text = row.Cells("kodeAlbum").Value?.ToString()
            txtJudul.Text     = row.Cells("judulAlbum").Value?.ToString()
            txtArtis.Text     = row.Cells("artis").Value?.ToString()
            txtTahun.Text     = row.Cells("tahunRilis").Value?.ToString()
            txtGenre.Text     = row.Cells("genre").Value?.ToString()
            txtKodeAlbum.Enabled = False
        End If
    End Sub

    ' ── Search real-time ───────────────────────────────────
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Trim() = "" Then
            TampilData()
        Else
            dgvAlbum.DataSource = SearchAlbum(txtSearch.Text.Trim())
            StyleGrid(dgvAlbum)
        End If
        lblStatus.Text = $"Ditemukan: {dgvAlbum.RowCount} album"
    End Sub

    ' ── Hanya angka untuk field Tahun ──────────────────────
    Private Sub txtTahun_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTahun.KeyPress
        HanyaAngka(e)
    End Sub

End Class
