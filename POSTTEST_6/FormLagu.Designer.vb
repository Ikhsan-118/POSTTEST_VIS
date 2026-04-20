' =============================================================
' FormLagu.Designer.vb
' Designer untuk FormLagu — tema Spotify Dark
' =============================================================
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLagu
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

        ' Controls
        pnlHeader    = New Panel()
        lblAppTitle  = New Label()
        lblFormTitle = New Label()
        pnlLeft      = New Panel()
        dgvLagu      = New DataGridView()
        pnlSearch    = New Panel()
        txtSearch    = New TextBox()
        pnlRight     = New Panel()
        lblKodeLagu  = New Label()
        txtKodeLagu  = New TextBox()
        lblAlbum     = New Label()
        cbAlbum      = New ComboBox()
        lblJudulLagu = New Label()
        txtJudulLagu = New TextBox()
        lblDurasi    = New Label()
        txtDurasi    = New TextBox()
        lblDurasiInfo = New Label()
        lblTrackNo   = New Label()
        txtTrackNo   = New TextBox()
        pnlButtons   = New Panel()
        btnSimpan    = New Button()
        btnUbah      = New Button()
        btnHapus     = New Button()
        btnBatal     = New Button()
        pnlFooter    = New Panel()
        lblStatus    = New Label()
        ErrorProvider1 = New ErrorProvider(components)

        CType(dgvLagu, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()

        ' ════════════════════════════════════════════
        ' FORM
        ' ════════════════════════════════════════════
        Me.Text          = "Spotify — Manajemen Lagu"
        Me.ClientSize    = New Size(920, 580)
        Me.BackColor     = Color.FromArgb(18, 18, 18)
        Me.ForeColor     = Color.White
        Me.Font          = New Font("Segoe UI", 9.5)
        Me.StartPosition = FormStartPosition.CenterScreen

        ' ════════════════════════════════════════════
        ' HEADER
        ' ════════════════════════════════════════════
        pnlHeader.Dock      = DockStyle.Top
        pnlHeader.Height    = 72
        pnlHeader.BackColor = Color.FromArgb(10, 10, 10)

        lblAppTitle.Text      = "🎵  SPOTIFY"
        lblAppTitle.Font      = New Font("Segoe UI", 18, FontStyle.Bold)
        lblAppTitle.ForeColor = Color.FromArgb(30, 215, 96)
        lblAppTitle.AutoSize  = True
        lblAppTitle.Location  = New Point(20, 10)

        lblFormTitle.Text      = "Manajemen Lagu"
        lblFormTitle.Font      = New Font("Segoe UI", 9)
        lblFormTitle.ForeColor = Color.FromArgb(179, 179, 179)
        lblFormTitle.AutoSize  = True
        lblFormTitle.Location  = New Point(24, 42)

        pnlHeader.Controls.Add(lblAppTitle)
        pnlHeader.Controls.Add(lblFormTitle)

        ' ════════════════════════════════════════════
        ' FOOTER
        ' ════════════════════════════════════════════
        pnlFooter.Dock      = DockStyle.Bottom
        pnlFooter.Height    = 32
        pnlFooter.BackColor = Color.FromArgb(10, 10, 10)

        lblStatus.Text      = "Total Lagu: 0"
        lblStatus.ForeColor = Color.FromArgb(179, 179, 179)
        lblStatus.Font      = New Font("Segoe UI", 8.5)
        lblStatus.Dock      = DockStyle.Fill
        lblStatus.TextAlign = ContentAlignment.MiddleLeft
        lblStatus.Padding   = New Padding(16, 0, 0, 0)
        pnlFooter.Controls.Add(lblStatus)

        ' ════════════════════════════════════════════
        ' PANEL KIRI — Grid + Search
        ' ════════════════════════════════════════════
        pnlLeft.Dock      = DockStyle.Left
        pnlLeft.Width     = 560
        pnlLeft.BackColor = Color.FromArgb(18, 18, 18)
        pnlLeft.Padding   = New Padding(16, 12, 8, 12)

        pnlSearch.Height    = 40
        pnlSearch.Dock      = DockStyle.Bottom
        pnlSearch.BackColor = Color.FromArgb(18, 18, 18)

        txtSearch.PlaceholderText = "🔍  Cari judul lagu, artis, album..."
        txtSearch.Dock            = DockStyle.Fill
        txtSearch.BackColor       = Color.FromArgb(42, 42, 42)
        txtSearch.ForeColor       = Color.White
        txtSearch.BorderStyle     = BorderStyle.None
        txtSearch.Font            = New Font("Segoe UI", 10)

        pnlSearch.Controls.Add(txtSearch)

        dgvLagu.Dock                          = DockStyle.Fill
        dgvLagu.BackgroundColor               = Color.FromArgb(18, 18, 18)
        dgvLagu.GridColor                     = Color.FromArgb(40, 40, 40)
        dgvLagu.BorderStyle                   = BorderStyle.None
        dgvLagu.CellBorderStyle               = DataGridViewCellBorderStyle.SingleHorizontal
        dgvLagu.ColumnHeadersBorderStyle      = DataGridViewHeaderBorderStyle.None
        dgvLagu.SelectionMode                 = DataGridViewSelectionMode.FullRowSelect
        dgvLagu.MultiSelect                   = False
        dgvLagu.ReadOnly                      = True
        dgvLagu.AllowUserToAddRows            = False
        dgvLagu.AllowUserToDeleteRows         = False
        dgvLagu.AllowUserToResizeRows         = False
        dgvLagu.RowHeadersVisible             = False
        dgvLagu.AutoSizeColumnsMode           = DataGridViewAutoSizeColumnsMode.Fill
        dgvLagu.DefaultCellStyle.BackColor    = Color.FromArgb(18, 18, 18)
        dgvLagu.DefaultCellStyle.ForeColor    = Color.FromArgb(230, 230, 230)
        dgvLagu.DefaultCellStyle.Font         = New Font("Segoe UI", 9.5)
        dgvLagu.RowTemplate.Height            = 36

        pnlLeft.Controls.Add(dgvLagu)
        pnlLeft.Controls.Add(pnlSearch)

        ' ════════════════════════════════════════════
        ' PANEL KANAN — Input
        ' ════════════════════════════════════════════
        pnlRight.Dock      = DockStyle.Fill
        pnlRight.BackColor = Color.FromArgb(24, 24, 24)
        pnlRight.Padding   = New Padding(24, 16, 24, 16)

        ' Kode Lagu
        lblKodeLagu.Text      = "KODE LAGU"
        lblKodeLagu.ForeColor = Color.FromArgb(179, 179, 179)
        lblKodeLagu.Font      = New Font("Segoe UI", 7.5, FontStyle.Bold)
        lblKodeLagu.Dock      = DockStyle.Top
        lblKodeLagu.Height    = 22

        txtKodeLagu.PlaceholderText = "Contoh: lagu001"
        txtKodeLagu.Dock      = DockStyle.Top
        txtKodeLagu.Height    = 36
        txtKodeLagu.BackColor = Color.FromArgb(42, 42, 42)
        txtKodeLagu.ForeColor = Color.White
        txtKodeLagu.BorderStyle = BorderStyle.FixedSingle
        txtKodeLagu.Font      = New Font("Segoe UI", 10)

        ' ComboBox Album
        lblAlbum.Text      = "ALBUM"
        lblAlbum.ForeColor = Color.FromArgb(179, 179, 179)
        lblAlbum.Font      = New Font("Segoe UI", 7.5, FontStyle.Bold)
        lblAlbum.Dock      = DockStyle.Top
        lblAlbum.Height    = 24

        cbAlbum.Dock          = DockStyle.Top
        cbAlbum.Height        = 36
        cbAlbum.BackColor     = Color.FromArgb(42, 42, 42)
        cbAlbum.ForeColor     = Color.White
        cbAlbum.FlatStyle     = FlatStyle.Flat
        cbAlbum.Font          = New Font("Segoe UI", 10)
        cbAlbum.DropDownStyle = ComboBoxStyle.DropDownList

        ' Judul Lagu
        lblJudulLagu.Text      = "JUDUL LAGU"
        lblJudulLagu.ForeColor = Color.FromArgb(179, 179, 179)
        lblJudulLagu.Font      = New Font("Segoe UI", 7.5, FontStyle.Bold)
        lblJudulLagu.Dock      = DockStyle.Top
        lblJudulLagu.Height    = 24

        txtJudulLagu.PlaceholderText = "Judul Lagu"
        txtJudulLagu.Dock      = DockStyle.Top
        txtJudulLagu.Height    = 36
        txtJudulLagu.BackColor = Color.FromArgb(42, 42, 42)
        txtJudulLagu.ForeColor = Color.White
        txtJudulLagu.BorderStyle = BorderStyle.FixedSingle
        txtJudulLagu.Font      = New Font("Segoe UI", 10)

        ' Durasi
        lblDurasi.Text      = "DURASI (DETIK)"
        lblDurasi.ForeColor = Color.FromArgb(179, 179, 179)
        lblDurasi.Font      = New Font("Segoe UI", 7.5, FontStyle.Bold)
        lblDurasi.Dock      = DockStyle.Top
        lblDurasi.Height    = 24

        txtDurasi.PlaceholderText = "Contoh: 215"
        txtDurasi.Dock      = DockStyle.Top
        txtDurasi.Height    = 36
        txtDurasi.BackColor = Color.FromArgb(42, 42, 42)
        txtDurasi.ForeColor = Color.White
        txtDurasi.BorderStyle = BorderStyle.FixedSingle
        txtDurasi.Font      = New Font("Segoe UI", 10)

        lblDurasiInfo.Text      = ""
        lblDurasiInfo.ForeColor = Color.FromArgb(30, 215, 96)
        lblDurasiInfo.Font      = New Font("Segoe UI", 8)
        lblDurasiInfo.Dock      = DockStyle.Top
        lblDurasiInfo.Height    = 20

        ' Track No
        lblTrackNo.Text      = "NOMOR TRACK"
        lblTrackNo.ForeColor = Color.FromArgb(179, 179, 179)
        lblTrackNo.Font      = New Font("Segoe UI", 7.5, FontStyle.Bold)
        lblTrackNo.Dock      = DockStyle.Top
        lblTrackNo.Height    = 24

        txtTrackNo.PlaceholderText = "Contoh: 1"
        txtTrackNo.Dock      = DockStyle.Top
        txtTrackNo.Height    = 36
        txtTrackNo.BackColor = Color.FromArgb(42, 42, 42)
        txtTrackNo.ForeColor = Color.White
        txtTrackNo.BorderStyle = BorderStyle.FixedSingle
        txtTrackNo.Font      = New Font("Segoe UI", 10)

        ' ── Panel Tombol ──────────────────────────────────
        pnlButtons.Dock      = DockStyle.Top
        pnlButtons.Height    = 48
        pnlButtons.BackColor = Color.Transparent

        StyleBtn(btnSimpan, "Simpan", Color.FromArgb(30, 215, 96), Color.Black)
        StyleBtn(btnUbah,   "Ubah",   Color.FromArgb(255, 167, 38), Color.Black)
        StyleBtn(btnHapus,  "Hapus",  Color.FromArgb(244, 67, 54),  Color.White)
        StyleBtn(btnBatal,  "Batal",  Color.FromArgb(60, 60, 60),   Color.White)

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

        ' ── Susun panel kanan (Dock=Top: urutan terbalik) ─
        pnlRight.Controls.Add(pnlButtons)
        pnlRight.Controls.Add(txtTrackNo)
        pnlRight.Controls.Add(lblTrackNo)
        pnlRight.Controls.Add(lblDurasiInfo)
        pnlRight.Controls.Add(txtDurasi)
        pnlRight.Controls.Add(lblDurasi)
        pnlRight.Controls.Add(txtJudulLagu)
        pnlRight.Controls.Add(lblJudulLagu)
        pnlRight.Controls.Add(cbAlbum)
        pnlRight.Controls.Add(lblAlbum)
        pnlRight.Controls.Add(txtKodeLagu)
        pnlRight.Controls.Add(lblKodeLagu)

        ' ── Tambah ke form ────────────────────────────────
        Me.Controls.Add(pnlRight)
        Me.Controls.Add(pnlLeft)
        Me.Controls.Add(pnlFooter)
        Me.Controls.Add(pnlHeader)

        CType(dgvLagu, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Private Sub StyleBtn(btn As Button, teks As String, bg As Color, fg As Color)
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
    Friend WithEvents pnlHeader    As Panel
    Friend WithEvents lblAppTitle  As Label
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents pnlLeft      As Panel
    Friend WithEvents dgvLagu      As DataGridView
    Friend WithEvents pnlSearch    As Panel
    Friend WithEvents txtSearch    As TextBox
    Friend WithEvents pnlRight     As Panel
    Friend WithEvents lblKodeLagu  As Label
    Friend WithEvents txtKodeLagu  As TextBox
    Friend WithEvents lblAlbum     As Label
    Friend WithEvents cbAlbum      As ComboBox
    Friend WithEvents lblJudulLagu As Label
    Friend WithEvents txtJudulLagu As TextBox
    Friend WithEvents lblDurasi    As Label
    Friend WithEvents txtDurasi    As TextBox
    Friend WithEvents lblDurasiInfo As Label
    Friend WithEvents lblTrackNo   As Label
    Friend WithEvents txtTrackNo   As TextBox
    Friend WithEvents pnlButtons   As Panel
    Friend WithEvents btnSimpan    As Button
    Friend WithEvents btnUbah      As Button
    Friend WithEvents btnHapus     As Button
    Friend WithEvents btnBatal     As Button
    Friend WithEvents pnlFooter    As Panel
    Friend WithEvents lblStatus    As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
