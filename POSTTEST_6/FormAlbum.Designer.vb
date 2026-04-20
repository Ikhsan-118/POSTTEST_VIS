' =============================================================
' FormAlbum.Designer.vb  — Auto-generated (dapat diedit manual)
' Tema: Spotify Dark  (#121212 bg, #1DB954 accent)
' =============================================================
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAlbum
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()

        ' ── Controls ─────────────────────────────────────────
        pnlHeader    = New Panel()
        lblAppTitle  = New Label()
        lblSubTitle  = New Label()
        pnlLeft      = New Panel()
        dgvAlbum     = New DataGridView()
        pnlSearch    = New Panel()
        picSearch    = New PictureBox()
        txtSearch    = New TextBox()
        pnlRight     = New Panel()
        lblFormTitle = New Label()
        lblKode      = New Label()
        txtKodeAlbum = New TextBox()
        lblJudul     = New Label()
        txtJudul     = New TextBox()
        lblArtis     = New Label()
        txtArtis     = New TextBox()
        lblTahun     = New Label()
        txtTahun     = New TextBox()
        lblGenre     = New Label()
        txtGenre     = New TextBox()
        pnlButtons   = New Panel()
        btnSimpan    = New Button()
        btnUbah      = New Button()
        btnHapus     = New Button()
        btnBatal     = New Button()
        pnlLaguButtons = New Panel()
        btnLihatLagu = New Button()
        btnSemuaLagu = New Button()
        pnlFooter    = New Panel()
        lblStatus    = New Label()
        ErrorProvider1 = New ErrorProvider(components)

        ' ── Begin Init ───────────────────────────────────────
        CType(dgvAlbum, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()

        ' ════════════════════════════════════════════
        ' FORM
        ' ════════════════════════════════════════════
        Me.Text            = "Spotify — Manajemen Album"
        Me.ClientSize      = New Size(900, 600)
        Me.BackColor       = Color.FromArgb(18, 18, 18)
        Me.ForeColor       = Color.White
        Me.Font            = New Font("Segoe UI", 9.5)
        Me.StartPosition   = FormStartPosition.CenterScreen
        Me.MinimumSize     = New Size(900, 600)

        ' ════════════════════════════════════════════
        ' PANEL HEADER
        ' ════════════════════════════════════════════
        pnlHeader.Dock      = DockStyle.Top
        pnlHeader.Height    = 72
        pnlHeader.BackColor = Color.FromArgb(10, 10, 10)
        pnlHeader.Padding   = New Padding(20, 0, 20, 0)

        lblAppTitle.Text      = "🎵  SPOTIFY"
        lblAppTitle.Font      = New Font("Segoe UI", 18, FontStyle.Bold)
        lblAppTitle.ForeColor = Color.FromArgb(30, 215, 96)
        lblAppTitle.AutoSize  = True
        lblAppTitle.Location  = New Point(20, 10)

        lblSubTitle.Text      = "Manajemen Album Musik"
        lblSubTitle.Font      = New Font("Segoe UI", 9)
        lblSubTitle.ForeColor = Color.FromArgb(179, 179, 179)
        lblSubTitle.AutoSize  = True
        lblSubTitle.Location  = New Point(24, 42)

        pnlHeader.Controls.Add(lblAppTitle)
        pnlHeader.Controls.Add(lblSubTitle)

        ' ════════════════════════════════════════════
        ' PANEL FOOTER (status bar)
        ' ════════════════════════════════════════════
        pnlFooter.Dock      = DockStyle.Bottom
        pnlFooter.Height    = 32
        pnlFooter.BackColor = Color.FromArgb(10, 10, 10)
        pnlFooter.Padding   = New Padding(16, 0, 0, 0)

        lblStatus.Text      = "Total Album: 0"
        lblStatus.ForeColor = Color.FromArgb(179, 179, 179)
        lblStatus.Font      = New Font("Segoe UI", 8.5)
        lblStatus.Dock      = DockStyle.Fill
        lblStatus.TextAlign = ContentAlignment.MiddleLeft
        pnlFooter.Controls.Add(lblStatus)

        ' ════════════════════════════════════════════
        ' PANEL KIRI — DataGridView + Search
        ' ════════════════════════════════════════════
        pnlLeft.Dock      = DockStyle.Left
        pnlLeft.Width     = 540
        pnlLeft.BackColor = Color.FromArgb(18, 18, 18)
        pnlLeft.Padding   = New Padding(16, 12, 8, 12)

        ' Panel Search
        pnlSearch.Height    = 40
        pnlSearch.Dock      = DockStyle.Bottom
        pnlSearch.BackColor = Color.FromArgb(18, 18, 18)

        txtSearch.PlaceholderText = "🔍  Cari album, artis, genre..."
        txtSearch.Dock            = DockStyle.Fill
        txtSearch.BackColor       = Color.FromArgb(42, 42, 42)
        txtSearch.ForeColor       = Color.White
        txtSearch.BorderStyle     = BorderStyle.None
        txtSearch.Font            = New Font("Segoe UI", 10)
        txtSearch.Padding         = New Padding(4)

        pnlSearch.Controls.Add(txtSearch)

        ' DataGridView
        dgvAlbum.Dock                          = DockStyle.Fill
        dgvAlbum.BackgroundColor               = Color.FromArgb(18, 18, 18)
        dgvAlbum.GridColor                     = Color.FromArgb(40, 40, 40)
        dgvAlbum.BorderStyle                   = BorderStyle.None
        dgvAlbum.CellBorderStyle               = DataGridViewCellBorderStyle.SingleHorizontal
        dgvAlbum.ColumnHeadersBorderStyle      = DataGridViewHeaderBorderStyle.None
        dgvAlbum.SelectionMode                 = DataGridViewSelectionMode.FullRowSelect
        dgvAlbum.MultiSelect                   = False
        dgvAlbum.ReadOnly                      = True
        dgvAlbum.AllowUserToAddRows            = False
        dgvAlbum.AllowUserToDeleteRows         = False
        dgvAlbum.AllowUserToResizeRows         = False
        dgvAlbum.RowHeadersVisible             = False
        dgvAlbum.AutoSizeColumnsMode           = DataGridViewAutoSizeColumnsMode.Fill
        dgvAlbum.DefaultCellStyle.BackColor    = Color.FromArgb(18, 18, 18)
        dgvAlbum.DefaultCellStyle.ForeColor    = Color.FromArgb(230, 230, 230)
        dgvAlbum.DefaultCellStyle.Font         = New Font("Segoe UI", 9.5)
        dgvAlbum.RowTemplate.Height            = 36

        pnlLeft.Controls.Add(dgvAlbum)
        pnlLeft.Controls.Add(pnlSearch)

        ' ════════════════════════════════════════════
        ' PANEL KANAN — Input Form
        ' ════════════════════════════════════════════
        pnlRight.Dock      = DockStyle.Fill
        pnlRight.BackColor = Color.FromArgb(24, 24, 24)
        pnlRight.Padding   = New Padding(24, 16, 24, 16)

        lblFormTitle.Text      = "Detail Album"
        lblFormTitle.Font      = New Font("Segoe UI", 12, FontStyle.Bold)
        lblFormTitle.ForeColor = Color.FromArgb(30, 215, 96)
        lblFormTitle.Dock      = DockStyle.Top
        lblFormTitle.Height    = 36

        ' Kode Album
        lblKode.Text      = "KODE ALBUM"
        lblKode.ForeColor = Color.FromArgb(179, 179, 179)
        lblKode.Font      = New Font("Segoe UI", 7.5, FontStyle.Bold)
        lblKode.Dock      = DockStyle.Top
        lblKode.Height    = 20

        txtKodeAlbum.PlaceholderText = "Contoh: hindia1"
        txtKodeAlbum.Dock      = DockStyle.Top
        txtKodeAlbum.Height    = 36
        txtKodeAlbum.BackColor = Color.FromArgb(42, 42, 42)
        txtKodeAlbum.ForeColor = Color.White
        txtKodeAlbum.BorderStyle = BorderStyle.FixedSingle
        txtKodeAlbum.Font      = New Font("Segoe UI", 10)

        ' Judul
        lblJudul.Text      = "JUDUL ALBUM"
        lblJudul.ForeColor = Color.FromArgb(179, 179, 179)
        lblJudul.Font      = New Font("Segoe UI", 7.5, FontStyle.Bold)
        lblJudul.Dock      = DockStyle.Top
        lblJudul.Height    = 24

        txtJudul.PlaceholderText = "Judul Album"
        txtJudul.Dock      = DockStyle.Top
        txtJudul.Height    = 36
        txtJudul.BackColor = Color.FromArgb(42, 42, 42)
        txtJudul.ForeColor = Color.White
        txtJudul.BorderStyle = BorderStyle.FixedSingle
        txtJudul.Font      = New Font("Segoe UI", 10)

        ' Artis
        lblArtis.Text      = "ARTIS"
        lblArtis.ForeColor = Color.FromArgb(179, 179, 179)
        lblArtis.Font      = New Font("Segoe UI", 7.5, FontStyle.Bold)
        lblArtis.Dock      = DockStyle.Top
        lblArtis.Height    = 24

        txtArtis.PlaceholderText = "Nama Artis / Band"
        txtArtis.Dock      = DockStyle.Top
        txtArtis.Height    = 36
        txtArtis.BackColor = Color.FromArgb(42, 42, 42)
        txtArtis.ForeColor = Color.White
        txtArtis.BorderStyle = BorderStyle.FixedSingle
        txtArtis.Font      = New Font("Segoe UI", 10)

        ' Tahun
        lblTahun.Text      = "TAHUN RILIS"
        lblTahun.ForeColor = Color.FromArgb(179, 179, 179)
        lblTahun.Font      = New Font("Segoe UI", 7.5, FontStyle.Bold)
        lblTahun.Dock      = DockStyle.Top
        lblTahun.Height    = 24

        txtTahun.PlaceholderText = "Contoh: 2024"
        txtTahun.Dock      = DockStyle.Top
        txtTahun.Height    = 36
        txtTahun.BackColor = Color.FromArgb(42, 42, 42)
        txtTahun.ForeColor = Color.White
        txtTahun.BorderStyle = BorderStyle.FixedSingle
        txtTahun.Font      = New Font("Segoe UI", 10)

        ' Genre
        lblGenre.Text      = "GENRE"
        lblGenre.ForeColor = Color.FromArgb(179, 179, 179)
        lblGenre.Font      = New Font("Segoe UI", 7.5, FontStyle.Bold)
        lblGenre.Dock      = DockStyle.Top
        lblGenre.Height    = 24

        txtGenre.PlaceholderText = "Indie, Pop, Rock, dll."
        txtGenre.Dock      = DockStyle.Top
        txtGenre.Height    = 36
        txtGenre.BackColor = Color.FromArgb(42, 42, 42)
        txtGenre.ForeColor = Color.White
        txtGenre.BorderStyle = BorderStyle.FixedSingle
        txtGenre.Font      = New Font("Segoe UI", 10)

        ' ── Panel Tombol CRUD ─────────────────────────────
        pnlButtons.Dock      = DockStyle.Top
        pnlButtons.Height    = 48
        pnlButtons.BackColor = Color.Transparent

        StyleButton(btnSimpan, "Simpan", Color.FromArgb(30, 215, 96), Color.Black)
        StyleButton(btnUbah,   "Ubah",   Color.FromArgb(255, 167, 38), Color.Black)
        StyleButton(btnHapus,  "Hapus",  Color.FromArgb(244, 67, 54),  Color.White)
        StyleButton(btnBatal,  "Batal",  Color.FromArgb(60, 60, 60),   Color.White)

        btnSimpan.Size     = New Size(80, 36)
        btnUbah.Size       = New Size(80, 36)
        btnHapus.Size      = New Size(80, 36)
        btnBatal.Size      = New Size(80, 36)
        btnSimpan.Location = New Point(0, 6)
        btnUbah.Location   = New Point(88, 6)
        btnHapus.Location  = New Point(176, 6)
        btnBatal.Location  = New Point(264, 6)

        pnlButtons.Controls.Add(btnSimpan)
        pnlButtons.Controls.Add(btnUbah)
        pnlButtons.Controls.Add(btnHapus)
        pnlButtons.Controls.Add(btnBatal)

        ' ── Panel Tombol Lagu ─────────────────────────────
        pnlLaguButtons.Dock      = DockStyle.Top
        pnlLaguButtons.Height    = 48
        pnlLaguButtons.BackColor = Color.Transparent

        StyleButton(btnLihatLagu, "🎵 Lagu Album Ini", Color.FromArgb(30, 215, 96), Color.Black)
        StyleButton(btnSemuaLagu, "📋 Semua Lagu",     Color.FromArgb(60, 60, 60),  Color.White)

        btnLihatLagu.Size     = New Size(160, 36)
        btnSemuaLagu.Size     = New Size(130, 36)
        btnLihatLagu.Location = New Point(0, 6)
        btnSemuaLagu.Location = New Point(168, 6)

        pnlLaguButtons.Controls.Add(btnLihatLagu)
        pnlLaguButtons.Controls.Add(btnSemuaLagu)

        ' ── Susun panel kanan (Dock=Top dibaca LIFO) ──────
        ' Urutan tambah ke panel = kebalikan urutan tampil
        pnlRight.Controls.Add(pnlLaguButtons)   ' paling bawah
        pnlRight.Controls.Add(pnlButtons)
        pnlRight.Controls.Add(txtGenre)
        pnlRight.Controls.Add(lblGenre)
        pnlRight.Controls.Add(txtTahun)
        pnlRight.Controls.Add(lblTahun)
        pnlRight.Controls.Add(txtArtis)
        pnlRight.Controls.Add(lblArtis)
        pnlRight.Controls.Add(txtJudul)
        pnlRight.Controls.Add(lblJudul)
        pnlRight.Controls.Add(txtKodeAlbum)
        pnlRight.Controls.Add(lblKode)
        pnlRight.Controls.Add(lblFormTitle)      ' paling atas

        ' ── Tambah ke Form ────────────────────────────────
        Me.Controls.Add(pnlRight)
        Me.Controls.Add(pnlLeft)
        Me.Controls.Add(pnlFooter)
        Me.Controls.Add(pnlHeader)

        CType(dgvAlbum, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    ' ── Helper style tombol ────────────────────────────────
    Private Sub StyleButton(btn As Button, teks As String, bg As Color, fg As Color)
        btn.Text            = teks
        btn.BackColor       = bg
        btn.ForeColor       = fg
        btn.FlatStyle       = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Font            = New Font("Segoe UI", 9, FontStyle.Bold)
        btn.Cursor          = Cursors.Hand
        btn.UseVisualStyleBackColor = False
    End Sub

    ' ── Deklarasi kontrol ─────────────────────────────────
    Friend WithEvents pnlHeader       As Panel
    Friend WithEvents lblAppTitle     As Label
    Friend WithEvents lblSubTitle     As Label
    Friend WithEvents pnlLeft         As Panel
    Friend WithEvents dgvAlbum        As DataGridView
    Friend WithEvents pnlSearch       As Panel
    Friend WithEvents picSearch       As PictureBox
    Friend WithEvents txtSearch       As TextBox
    Friend WithEvents pnlRight        As Panel
    Friend WithEvents lblFormTitle    As Label
    Friend WithEvents lblKode         As Label
    Friend WithEvents txtKodeAlbum    As TextBox
    Friend WithEvents lblJudul        As Label
    Friend WithEvents txtJudul        As TextBox
    Friend WithEvents lblArtis        As Label
    Friend WithEvents txtArtis        As TextBox
    Friend WithEvents lblTahun        As Label
    Friend WithEvents txtTahun        As TextBox
    Friend WithEvents lblGenre        As Label
    Friend WithEvents txtGenre        As TextBox
    Friend WithEvents pnlButtons      As Panel
    Friend WithEvents btnSimpan       As Button
    Friend WithEvents btnUbah         As Button
    Friend WithEvents btnHapus        As Button
    Friend WithEvents btnBatal        As Button
    Friend WithEvents pnlLaguButtons  As Panel
    Friend WithEvents btnLihatLagu    As Button
    Friend WithEvents btnSemuaLagu    As Button
    Friend WithEvents pnlFooter       As Panel
    Friend WithEvents lblStatus       As Label
    Friend WithEvents ErrorProvider1  As ErrorProvider
End Class
