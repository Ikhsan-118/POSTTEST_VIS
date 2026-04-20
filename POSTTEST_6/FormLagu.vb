' =============================================================
' FormLagu.vb
' Form CRUD untuk tabel tblagu (Tabel Anak — FK ke tbalbum)
' Bisa dibuka dengan filter album tertentu atau semua lagu
' =============================================================
Imports MySqlConnector

Public Class FormLagu

    Private _filterKodeAlbum As String = ""
    Private _filterJudulAlbum As String = ""

    ''' <summary>
    ''' Constructor: pass kodeAlbum dan judulAlbum untuk filter.
    ''' Kosongkan keduanya untuk menampilkan semua lagu.
    ''' </summary>
    Public Sub New(kodeAlbum As String, judulAlbum As String)
        InitializeComponent()
        _filterKodeAlbum = kodeAlbum
        _filterJudulAlbum = judulAlbum
    End Sub

    ' ── Helper: kosongkan input ─────────────────────────────
    Private Sub Kosong()
        txtKodeLagu.Clear()
        txtJudulLagu.Clear()
        txtDurasi.Clear()
        txtTrackNo.Clear()
        txtSearch.Clear()
        cbAlbum.SelectedIndex = -1
        ErrorProvider1.Clear()
        txtKodeLagu.Enabled = True
        txtKodeLagu.Focus()
    End Sub

    ' ── Helper: tampilkan data ke grid ─────────────────────
    Private Sub TampilData()
        Dim dt As DataTable
        If _filterKodeAlbum <> "" Then
            dt = GetLaguByAlbum(_filterKodeAlbum)
        Else
            dt = GetAllLagu()
        End If
        dgvLagu.DataSource = dt
        StyleGrid()
        UpdateStatus(dt.Rows.Count)
    End Sub

    Private Sub StyleGrid()
        Dim dgv As DataGridView = dgvLagu
        dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(30, 215, 96)
        dgv.DefaultCellStyle.SelectionForeColor = Color.Black
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(24, 24, 24)
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18)
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(30, 215, 96)
        dgv.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        dgv.EnableHeadersVisualStyles = False
    End Sub

    Private Sub UpdateStatus(count As Integer)
        Dim prefix As String = If(_filterKodeAlbum <> "", $"Album: {_filterJudulAlbum}  |  ", "")
        lblStatus.Text = $"{prefix}Total Lagu: {count}"
    End Sub

    ' ── Load ComboBox album ────────────────────────────────
    Private Sub MuatComboAlbum()
        Dim dt As DataTable = GetAllAlbum()
        cbAlbum.DataSource    = dt
        cbAlbum.DisplayMember = "judulAlbum"
        cbAlbum.ValueMember   = "kodeAlbum"
        cbAlbum.SelectedIndex = -1

        ' Auto-select jika ada filter album
        If _filterKodeAlbum <> "" Then
            cbAlbum.SelectedValue = _filterKodeAlbum
        End If
    End Sub

    ' ── Load Form ──────────────────────────────────────────
    Private Sub FormLagu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _filterJudulAlbum <> "" Then
            Me.Text = $"Lagu — {_filterJudulAlbum}"
            lblFormTitle.Text = $"Lagu dalam Album: {_filterJudulAlbum}"
        Else
            Me.Text = "Spotify — Semua Lagu"
            lblFormTitle.Text = "Semua Lagu"
        End If

        MuatComboAlbum()
        TampilData()
        Kosong()
    End Sub

    ' ══════════════════════════════════════════════════════
    ' TOMBOL SIMPAN
    ' ══════════════════════════════════════════════════════
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()
        If Not ValidasiInputLagu(ErrorProvider1, txtKodeLagu, cbAlbum,
                                  txtJudulLagu, txtDurasi, txtTrackNo) Then Exit Sub

        If KodeLaguSudahAda(txtKodeLagu.Text.Trim()) Then
            MessageBox.Show("Kode Lagu sudah terdaftar!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtKodeLagu.Focus()
            Exit Sub
        End If

        Dim kodeAlbum As String  = cbAlbum.SelectedValue.ToString()
        Dim durasi    As Integer = Integer.Parse(txtDurasi.Text.Trim())
        Dim trackNo   As Integer = Integer.Parse(txtTrackNo.Text.Trim())

        If SimpanLagu(txtKodeLagu.Text.Trim(), kodeAlbum,
                      txtJudulLagu.Text.Trim(), durasi, trackNo) Then
            MessageBox.Show("Lagu berhasil ditambahkan!", "Sukses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
            ' Pertahankan pilihan album jika ada filter
            If _filterKodeAlbum <> "" Then cbAlbum.SelectedValue = _filterKodeAlbum
        End If
    End Sub

    ' ══════════════════════════════════════════════════════
    ' TOMBOL UBAH
    ' ══════════════════════════════════════════════════════
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        ErrorProvider1.Clear()
        If Not ValidasiInputLagu(ErrorProvider1, txtKodeLagu, cbAlbum,
                                  txtJudulLagu, txtDurasi, txtTrackNo) Then Exit Sub

        Dim kodeAlbum As String  = cbAlbum.SelectedValue.ToString()
        Dim durasi    As Integer = Integer.Parse(txtDurasi.Text.Trim())
        Dim trackNo   As Integer = Integer.Parse(txtTrackNo.Text.Trim())

        If UbahLagu(txtKodeLagu.Text.Trim(), kodeAlbum,
                    txtJudulLagu.Text.Trim(), durasi, trackNo) Then
            MessageBox.Show("Lagu berhasil diperbarui!", "Sukses",
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
        If txtKodeLagu.Text.Trim() = "" Then
            MessageBox.Show("Pilih lagu dari tabel terlebih dahulu!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim hasil As DialogResult = MessageBox.Show(
            $"Hapus lagu '{txtJudulLagu.Text}'?",
            "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If hasil = DialogResult.Yes Then
            If HapusLagu(txtKodeLagu.Text.Trim()) Then
                MessageBox.Show("Lagu berhasil dihapus.", "Sukses",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                Kosong()
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

    ' ── Klik baris grid ────────────────────────────────────
    Private Sub dgvLagu_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLagu.CellClick
        ' 1. Validasi agar tidak error jika klik header
        If e.RowIndex < 0 Then Exit Sub

        Dim row As DataGridViewRow = dgvLagu.Rows(e.RowIndex)

        ' 2. Ambil data dasar (Gunakan nama kolom database/DataTable Anda)
        txtKodeLagu.Text = row.Cells("kodeLagu").Value?.ToString()
        txtJudulLagu.Text = row.Cells("Judul Lagu").Value?.ToString()
        txtTrackNo.Text = row.Cells("Track").Value?.ToString()

        ' 3. Konversi durasi (HH:MM:SS ke Detik)
        Dim durasiStr As String = row.Cells("Durasi").Value?.ToString()
        If Not String.IsNullOrEmpty(durasiStr) Then
            Dim parts() As String = durasiStr.Split(":"c)
            Dim totalDetik As Integer = 0

            Try
                If parts.Length = 3 Then ' format HH:MM:SS
                    totalDetik = (Val(parts(0)) * 3600) + (Val(parts(1)) * 60) + Val(parts(2))
                ElseIf parts.Length = 2 Then ' format MM:SS
                    totalDetik = (Val(parts(0)) * 60) + Val(parts(1))
                End If
                txtDurasi.Text = totalDetik.ToString()
            Catch
                txtDurasi.Text = "0"
            End Try
        End If

        ' 4. Logika ComboBox Album (Bagian yang sebelumnya error)
        If _filterKodeAlbum <> "" Then
            cbAlbum.SelectedValue = _filterKodeAlbum
        Else
            ' Pastikan kolom "kodeAlbum" ada di DataGridView sebelum akses nilainya
            If dgvLagu.Columns.Contains("kodeAlbum") Then
                cbAlbum.SelectedValue = row.Cells("kodeAlbum").Value?.ToString()
            End If
        End If

        ' Kunci KodeLagu karena Primary Key tidak boleh diubah saat Edit
        txtKodeLagu.Enabled = False
    End Sub

    ' ── Search real-time ───────────────────────────────────
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Trim() = "" Then
            TampilData()
        Else
            If _filterKodeAlbum <> "" Then
                ' Filter lagu dalam album yang dipilih
                Dim dt As DataTable = SearchLagu(txtSearch.Text.Trim())
                Dim filtered As DataTable = dt.Clone()
                For Each row As DataRow In dt.Rows
                    If row("kodeAlbum").ToString() = _filterKodeAlbum Then
                        filtered.ImportRow(row)
                    End If
                Next
                dgvLagu.DataSource = filtered
            Else
                dgvLagu.DataSource = SearchLagu(txtSearch.Text.Trim())
            End If
            StyleGrid()
            lblStatus.Text = $"Ditemukan: {dgvLagu.RowCount} lagu"
        End If
    End Sub

    ' ── Hanya angka untuk Durasi & Track ──────────────────
    Private Sub txtDurasi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDurasi.KeyPress
        HanyaAngka(e)
    End Sub

    Private Sub txtTrackNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTrackNo.KeyPress
        HanyaAngka(e)
    End Sub

    ' ── Helper tampilan durasi (detik → menit:detik) ───────
    Private Sub txtDurasi_Leave(sender As Object, e As EventArgs) Handles txtDurasi.Leave
        Dim detik As Integer
        If Integer.TryParse(txtDurasi.Text.Trim(), detik) AndAlso detik > 0 Then
            lblDurasiInfo.Text = $"≈ {detik \ 60}:{(detik Mod 60):D2} menit"
        Else
            lblDurasiInfo.Text = ""
        End If
    End Sub

End Class
