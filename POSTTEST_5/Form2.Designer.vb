<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAlbum
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAlbum))
        dgvAlbum = New DataGridView()
        ErrorProvider1 = New ErrorProvider(components)
        txtKodeAlbum = New TextBox()
        txtJudul = New TextBox()
        txtSearch = New TextBox()
        txtArtis = New TextBox()
        txtTahun = New TextBox()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        txtGenree = New TextBox()
        CType(dgvAlbum, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvAlbum
        ' 
        dgvAlbum.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAlbum.Location = New Point(12, 12)
        dgvAlbum.Name = "dgvAlbum"
        dgvAlbum.RowHeadersWidth = 51
        dgvAlbum.Size = New Size(463, 294)
        dgvAlbum.TabIndex = 0
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' txtKodeAlbum
        ' 
        txtKodeAlbum.Location = New Point(494, 12)
        txtKodeAlbum.Name = "txtKodeAlbum"
        txtKodeAlbum.PlaceholderText = "Kode Album"
        txtKodeAlbum.Size = New Size(194, 27)
        txtKodeAlbum.TabIndex = 1
        ' 
        ' txtJudul
        ' 
        txtJudul.Location = New Point(494, 45)
        txtJudul.Name = "txtJudul"
        txtJudul.PlaceholderText = "Judul"
        txtJudul.Size = New Size(194, 27)
        txtJudul.TabIndex = 2
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(12, 312)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Search..."
        txtSearch.Size = New Size(463, 27)
        txtSearch.TabIndex = 3
        ' 
        ' txtArtis
        ' 
        txtArtis.Location = New Point(494, 78)
        txtArtis.Name = "txtArtis"
        txtArtis.PlaceholderText = "Artis"
        txtArtis.Size = New Size(194, 27)
        txtArtis.TabIndex = 4
        ' 
        ' txtTahun
        ' 
        txtTahun.Location = New Point(494, 111)
        txtTahun.Name = "txtTahun"
        txtTahun.PlaceholderText = "Tahun"
        txtTahun.Size = New Size(194, 27)
        txtTahun.TabIndex = 5
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(494, 190)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(94, 29)
        btnSimpan.TabIndex = 7
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.Location = New Point(594, 190)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(94, 29)
        btnUbah.TabIndex = 8
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(494, 225)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 9
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(594, 225)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(94, 29)
        btnBatal.TabIndex = 10
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' txtGenree
        ' 
        txtGenree.Location = New Point(494, 144)
        txtGenree.Name = "txtGenree"
        txtGenree.PlaceholderText = "Genre"
        txtGenree.Size = New Size(194, 27)
        txtGenree.TabIndex = 11
        ' 
        ' FormAlbum
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(718, 351)
        Controls.Add(txtGenree)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(txtTahun)
        Controls.Add(txtArtis)
        Controls.Add(txtSearch)
        Controls.Add(txtJudul)
        Controls.Add(txtKodeAlbum)
        Controls.Add(dgvAlbum)
        Name = "FormAlbum"
        Text = "FormAlbum"
        CType(dgvAlbum, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvAlbum As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents txtKodeAlbum As TextBox
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents txtArtis As TextBox
    Friend WithEvents txtTahun As TextBox
    Friend WithEvents txtGenreTe As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents txtGenree As TextBox
End Class
