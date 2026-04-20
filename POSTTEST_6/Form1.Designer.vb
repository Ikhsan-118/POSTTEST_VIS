' =============================================================
' Form1.Designer.vb  — Halaman utama Spotify App
' =============================================================
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        pnlMain        = New Panel()
        lblLogo        = New Label()
        lblTagline     = New Label()
        lblDivider     = New Label()
        lblMenuTitle   = New Label()
        btnKelolaAlbum = New Button()
        btnKelolaLagu  = New Button()
        lblSpacer      = New Label()
        btnKeluar      = New Button()
        lblFooter      = New Label()

        SuspendLayout()

        ' ════════════════════════════════════════════
        ' FORM
        ' ════════════════════════════════════════════
        Me.Text            = "Spotify — Database App"
        Me.ClientSize      = New Size(480, 540)
        Me.BackColor       = Color.FromArgb(18, 18, 18)
        Me.ForeColor       = Color.White
        Me.Font            = New Font("Segoe UI", 10)
        Me.StartPosition   = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox     = False

        ' ════════════════════════════════════════════
        ' PANEL UTAMA (centered content)
        ' ════════════════════════════════════════════
        pnlMain.Size      = New Size(340, 400)
        pnlMain.Location  = New Point(70, 70)
        pnlMain.BackColor = Color.FromArgb(24, 24, 24)
        pnlMain.Padding   = New Padding(32)

        ' Logo
        lblLogo.Text      = "🎵"
        lblLogo.Font      = New Font("Segoe UI Emoji", 40)
        lblLogo.ForeColor = Color.FromArgb(30, 215, 96)
        lblLogo.TextAlign = ContentAlignment.MiddleCenter
        lblLogo.Dock      = DockStyle.Top
        lblLogo.Height    = 70

        ' App name
        Dim lblAppName As New Label()
        lblAppName.Text      = "SPOTIFY"
        lblAppName.Font      = New Font("Segoe UI", 22, FontStyle.Bold)
        lblAppName.ForeColor = Color.White
        lblAppName.TextAlign = ContentAlignment.MiddleCenter
        lblAppName.Dock      = DockStyle.Top
        lblAppName.Height    = 44

        ' Tagline
        lblTagline.Text      = "Music Database Management"
        lblTagline.Font      = New Font("Segoe UI", 9)
        lblTagline.ForeColor = Color.FromArgb(179, 179, 179)
        lblTagline.TextAlign = ContentAlignment.MiddleCenter
        lblTagline.Dock      = DockStyle.Top
        lblTagline.Height    = 28

        ' Divider
        lblDivider.Height    = 1
        lblDivider.Dock      = DockStyle.Top
        lblDivider.BackColor = Color.FromArgb(40, 40, 40)
        Dim pnlPad As New Panel()
        pnlPad.Height    = 12
        pnlPad.Dock      = DockStyle.Top
        pnlPad.BackColor = Color.Transparent

        ' Menu title
        lblMenuTitle.Text      = "PILIH MENU"
        lblMenuTitle.Font      = New Font("Segoe UI", 7.5, FontStyle.Bold)
        lblMenuTitle.ForeColor = Color.FromArgb(179, 179, 179)
        lblMenuTitle.TextAlign = ContentAlignment.MiddleCenter
        lblMenuTitle.Dock      = DockStyle.Top
        lblMenuTitle.Height    = 28

        ' Tombol
        StyleMenuButton(btnKelolaAlbum, "🎼   Kelola Album",
                        Color.FromArgb(30, 215, 96), Color.Black)
        StyleMenuButton(btnKelolaLagu, "🎵   Kelola Lagu",
                        Color.FromArgb(42, 42, 42), Color.White)

        lblSpacer.Height    = 8
        lblSpacer.Dock      = DockStyle.Top
        lblSpacer.BackColor = Color.Transparent

        StyleMenuButton(btnKeluar, "✕   Keluar",
                        Color.Transparent, Color.FromArgb(179, 179, 179))
        btnKeluar.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60)
        btnKeluar.FlatAppearance.BorderSize  = 1

        ' Footer
        lblFooter.Text      = "POSTTEST 6 · Pemrograman Visual · Informatika UNMUL"
        lblFooter.Font      = New Font("Segoe UI", 7.5)
        lblFooter.ForeColor = Color.FromArgb(100, 100, 100)
        lblFooter.TextAlign = ContentAlignment.MiddleCenter
        lblFooter.Dock      = DockStyle.Bottom
        lblFooter.Height    = 26

        ' ── Susun panel (Dock=Top: urutan terbalik saat ditampilkan)
        pnlMain.Controls.Add(btnKeluar)
        pnlMain.Controls.Add(lblSpacer)
        pnlMain.Controls.Add(btnKelolaLagu)
        pnlMain.Controls.Add(btnKelolaAlbum)
        pnlMain.Controls.Add(lblMenuTitle)
        pnlMain.Controls.Add(pnlPad)
        pnlMain.Controls.Add(lblDivider)
        pnlMain.Controls.Add(lblTagline)
        pnlMain.Controls.Add(lblAppName)
        pnlMain.Controls.Add(lblLogo)

        Me.Controls.Add(lblFooter)
        Me.Controls.Add(pnlMain)

        ResumeLayout(False)
    End Sub

    Private Sub StyleMenuButton(btn As Button, teks As String, bg As Color, fg As Color)
        btn.Text            = teks
        btn.BackColor       = bg
        btn.ForeColor       = fg
        btn.FlatStyle       = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Font            = New Font("Segoe UI", 11, FontStyle.Bold)
        btn.Cursor          = Cursors.Hand
        btn.Dock            = DockStyle.Top
        btn.Height          = 50
        btn.UseVisualStyleBackColor = False
        btn.TextAlign       = ContentAlignment.MiddleCenter
    End Sub

    Friend WithEvents pnlMain        As Panel
    Friend WithEvents lblLogo        As Label
    Friend WithEvents lblTagline     As Label
    Friend WithEvents lblDivider     As Label
    Friend WithEvents lblMenuTitle   As Label
    Friend WithEvents btnKelolaAlbum As Button
    Friend WithEvents btnKelolaLagu  As Button
    Friend WithEvents lblSpacer      As Label
    Friend WithEvents btnKeluar      As Button
    Friend WithEvents lblFooter      As Label
End Class
