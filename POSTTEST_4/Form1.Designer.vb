<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        MenuStrip1 = New MenuStrip()
        InputDataToolStripMenuItem = New ToolStripMenuItem()
        LihatKartuToolStripMenuItem = New ToolStripMenuItem()
        SimpanDataToolStripMenuItem = New ToolStripMenuItem()
        BukaDataToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        cmbDevisi = New ComboBox()
        rbPerempuan = New RadioButton()
        rbPria = New RadioButton()
        dtpTanggalLahir = New DateTimePicker()
        Me.txtUmur = New TextBox()
        Me.txtId = New TextBox()
        txtNama = New TextBox()
        TabPage2 = New TabPage()
        mtbTelepon = New MaskedTextBox()
        txtAlamat = New TextBox()
        txtEmail = New TextBox()
        TabPage3 = New TabPage()
        btnSimpanCetak = New Button()
        Me.chk8 = New CheckBox()
        Me.chk7 = New CheckBox()
        Me.chk6 = New CheckBox()
        Me.chk5 = New CheckBox()
        Me.chk4 = New CheckBox()
        chk3 = New CheckBox()
        chk2 = New CheckBox()
        chk1 = New CheckBox()
        GroupBox1 = New GroupBox()
        rbAnggota = New RadioButton()
        rbAdmin = New RadioButton()
        rbKetua = New RadioButton()
        btnBrowse = New Button()
        pbProfil = New PictureBox()
        ErrorProvider1 = New ErrorProvider(components)
        OpenFileDialog1 = New OpenFileDialog()
        OpenFileDialogFoto = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        MenuStrip1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(pbProfil, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {InputDataToolStripMenuItem, LihatKartuToolStripMenuItem, SimpanDataToolStripMenuItem, BukaDataToolStripMenuItem, KeluarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InputDataToolStripMenuItem
        ' 
        InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        InputDataToolStripMenuItem.Size = New Size(93, 24)
        InputDataToolStripMenuItem.Text = "Input Data"
        ' 
        ' LihatKartuToolStripMenuItem
        ' 
        LihatKartuToolStripMenuItem.Name = "LihatKartuToolStripMenuItem"
        LihatKartuToolStripMenuItem.Size = New Size(94, 24)
        LihatKartuToolStripMenuItem.Text = "Lihat Kartu"
        ' 
        ' SimpanDataToolStripMenuItem
        ' 
        SimpanDataToolStripMenuItem.Name = "SimpanDataToolStripMenuItem"
        SimpanDataToolStripMenuItem.Size = New Size(109, 24)
        SimpanDataToolStripMenuItem.Text = "Simpan Data"
        ' 
        ' BukaDataToolStripMenuItem
        ' 
        BukaDataToolStripMenuItem.Name = "BukaDataToolStripMenuItem"
        BukaDataToolStripMenuItem.Size = New Size(91, 24)
        BukaDataToolStripMenuItem.Text = "Buka Data"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(65, 24)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Location = New Point(34, 66)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(391, 357)
        TabControl1.TabIndex = 1
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(cmbDevisi)
        TabPage1.Controls.Add(rbPerempuan)
        TabPage1.Controls.Add(rbPria)
        TabPage1.Controls.Add(dtpTanggalLahir)
        TabPage1.Controls.Add(Me.txtUmur)
        TabPage1.Controls.Add(Me.txtId)
        TabPage1.Controls.Add(txtNama)
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(383, 324)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Data Utama"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' cmbDevisi
        ' 
        cmbDevisi.FormattingEnabled = True
        cmbDevisi.Location = New Point(29, 242)
        cmbDevisi.Name = "cmbDevisi"
        cmbDevisi.Size = New Size(151, 28)
        cmbDevisi.TabIndex = 6
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(90, 203)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(104, 24)
        rbPerempuan.TabIndex = 5
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbPria
        ' 
        rbPria.AutoSize = True
        rbPria.Location = New Point(28, 202)
        rbPria.Name = "rbPria"
        rbPria.Size = New Size(55, 24)
        rbPria.TabIndex = 4
        rbPria.TabStop = True
        rbPria.Text = "Pria"
        rbPria.UseVisualStyleBackColor = True
        ' 
        ' dtpTanggalLahir
        ' 
        dtpTanggalLahir.Location = New Point(26, 165)
        dtpTanggalLahir.Name = "dtpTanggalLahir"
        dtpTanggalLahir.Size = New Size(259, 27)
        dtpTanggalLahir.TabIndex = 3
        ' 
        ' txtUmur
        ' 
        Me.txtUmur.Location = New Point(24, 117)
        Me.txtUmur.Name = "txtUmur"
        Me.txtUmur.PlaceholderText = "Umur"
        Me.txtUmur.Size = New Size(125, 27)
        Me.txtUmur.TabIndex = 2
        ' 
        ' txtId
        ' 
        Me.txtId.Location = New Point(25, 73)
        Me.txtId.Name = "txtId"
        Me.txtId.PlaceholderText = "Id"
        Me.txtId.Size = New Size(125, 27)
        Me.txtId.TabIndex = 1
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(24, 27)
        txtNama.Name = "txtNama"
        txtNama.PlaceholderText = "Nama"
        txtNama.Size = New Size(125, 27)
        txtNama.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(mtbTelepon)
        TabPage2.Controls.Add(txtAlamat)
        TabPage2.Controls.Add(txtEmail)
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(383, 324)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Kontak & Info"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' mtbTelepon
        ' 
        mtbTelepon.Location = New Point(34, 129)
        mtbTelepon.Mask = "0000-0000-0000"
        mtbTelepon.Name = "mtbTelepon"
        mtbTelepon.Size = New Size(125, 27)
        mtbTelepon.TabIndex = 2
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(31, 80)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.PlaceholderText = "Alamat"
        txtAlamat.Size = New Size(125, 27)
        txtAlamat.TabIndex = 1
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(29, 34)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Email"
        txtEmail.Size = New Size(125, 27)
        txtEmail.TabIndex = 0
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(btnSimpanCetak)
        TabPage3.Controls.Add(Me.chk8)
        TabPage3.Controls.Add(Me.chk7)
        TabPage3.Controls.Add(Me.chk6)
        TabPage3.Controls.Add(Me.chk5)
        TabPage3.Controls.Add(Me.chk4)
        TabPage3.Controls.Add(chk3)
        TabPage3.Controls.Add(chk2)
        TabPage3.Controls.Add(chk1)
        TabPage3.Controls.Add(GroupBox1)
        TabPage3.Controls.Add(btnBrowse)
        TabPage3.Controls.Add(pbProfil)
        TabPage3.Location = New Point(4, 29)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(383, 324)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Profil & Aktivitas"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' btnSimpanCetak
        ' 
        btnSimpanCetak.Location = New Point(94, 275)
        btnSimpanCetak.Name = "btnSimpanCetak"
        btnSimpanCetak.Size = New Size(183, 29)
        btnSimpanCetak.TabIndex = 11
        btnSimpanCetak.Text = "Simpan Dan Cetak Kartu"
        btnSimpanCetak.UseVisualStyleBackColor = True
        ' 
        ' chk8
        ' 
        Me.chk8.AutoSize = True
        Me.chk8.Location = New Point(275, 209)
        Me.chk8.Name = "chk8"
        Me.chk8.Size = New Size(77, 24)
        Me.chk8.TabIndex = 10
        Me.chk8.Text = "Humas"
        Me.chk8.UseVisualStyleBackColor = True
        ' 
        ' chk7
        ' 
        Me.chk7.AutoSize = True
        Me.chk7.Location = New Point(275, 183)
        Me.chk7.Name = "chk7"
        Me.chk7.Size = New Size(65, 24)
        Me.chk7.TabIndex = 9
        Me.chk7.Text = "Tidur"
        Me.chk7.UseVisualStyleBackColor = True
        ' 
        ' chk6
        ' 
        Me.chk6.AutoSize = True
        Me.chk6.Location = New Point(274, 157)
        Me.chk6.Name = "chk6"
        Me.chk6.Size = New Size(92, 24)
        Me.chk6.TabIndex = 8
        Me.chk6.Text = "Fotografi"
        Me.chk6.UseVisualStyleBackColor = True
        ' 
        ' chk5
        ' 
        Me.chk5.AutoSize = True
        Me.chk5.Location = New Point(274, 131)
        Me.chk5.Name = "chk5"
        Me.chk5.Size = New Size(82, 24)
        Me.chk5.TabIndex = 7
        Me.chk5.Text = "Menulis"
        Me.chk5.UseVisualStyleBackColor = True
        ' 
        ' chk4
        ' 
        Me.chk4.AutoSize = True
        Me.chk4.Location = New Point(169, 208)
        Me.chk4.Name = "chk4"
        Me.chk4.Size = New Size(84, 24)
        Me.chk4.TabIndex = 6
        Me.chk4.Text = "Blogger"
        Me.chk4.UseVisualStyleBackColor = True
        ' 
        ' chk3
        ' 
        chk3.AutoSize = True
        chk3.Location = New Point(169, 182)
        chk3.Name = "chk3"
        chk3.Size = New Size(76, 24)
        chk3.TabIndex = 5
        chk3.Text = "Desain"
        chk3.UseVisualStyleBackColor = True
        ' 
        ' chk2
        ' 
        chk2.AutoSize = True
        chk2.Location = New Point(169, 157)
        chk2.Name = "chk2"
        chk2.Size = New Size(97, 24)
        chk2.TabIndex = 4
        chk2.Text = "Push Rank"
        chk2.UseVisualStyleBackColor = True
        ' 
        ' chk1
        ' 
        chk1.AutoSize = True
        chk1.Location = New Point(169, 131)
        chk1.Name = "chk1"
        chk1.Size = New Size(90, 24)
        chk1.TabIndex = 3
        chk1.Text = "Ngoding"
        chk1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.LightGray
        GroupBox1.Controls.Add(rbAnggota)
        GroupBox1.Controls.Add(rbAdmin)
        GroupBox1.Controls.Add(rbKetua)
        GroupBox1.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = SystemColors.Desktop
        GroupBox1.Location = New Point(182, 15)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(182, 104)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Peran"
        ' 
        ' rbAnggota
        ' 
        rbAnggota.AutoSize = True
        rbAnggota.Location = New Point(12, 71)
        rbAnggota.Name = "rbAnggota"
        rbAnggota.Size = New Size(92, 24)
        rbAnggota.TabIndex = 2
        rbAnggota.TabStop = True
        rbAnggota.Text = "Anggota"
        rbAnggota.UseVisualStyleBackColor = True
        ' 
        ' rbAdmin
        ' 
        rbAdmin.AutoSize = True
        rbAdmin.Location = New Point(11, 47)
        rbAdmin.Name = "rbAdmin"
        rbAdmin.Size = New Size(78, 24)
        rbAdmin.TabIndex = 1
        rbAdmin.TabStop = True
        rbAdmin.Text = "Admin"
        rbAdmin.UseVisualStyleBackColor = True
        ' 
        ' rbKetua
        ' 
        rbKetua.AutoSize = True
        rbKetua.Location = New Point(11, 22)
        rbKetua.Name = "rbKetua"
        rbKetua.Size = New Size(72, 24)
        rbKetua.TabIndex = 0
        rbKetua.TabStop = True
        rbKetua.Text = "Ketua"
        rbKetua.UseVisualStyleBackColor = True
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(43, 189)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(94, 29)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' pbProfil
        ' 
        pbProfil.BackgroundImageLayout = ImageLayout.Stretch
        pbProfil.Location = New Point(20, 15)
        pbProfil.Name = "pbProfil"
        pbProfil.Size = New Size(136, 157)
        pbProfil.TabIndex = 0
        pbProfil.TabStop = False
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' OpenFileDialogFoto
        ' 
        OpenFileDialogFoto.FileName = "OpenFileDialog2"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(TabControl1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(pbProfil, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InputDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatKartuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dtpTanggalLahir As DateTimePicker
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents cmbDevisi As ComboBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbPria As RadioButton
    Friend WithEvents mtbTelepon As MaskedTextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents pbProfil As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbAnggota As RadioButton
    Friend WithEvents rbAdmin As RadioButton
    Friend WithEvents rbKetua As RadioButton
    Friend WithEvents chk8 As CheckBox
    Friend WithEvents chk7 As CheckBox
    Friend WithEvents chk6 As CheckBox
    Friend WithEvents chk5 As CheckBox
    Friend WithEvents chk4 As CheckBox
    Friend WithEvents chk3 As CheckBox
    Friend WithEvents chk2 As CheckBox
    Friend WithEvents chk1 As CheckBox
    Friend WithEvents btnSimpanCetak As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents OpenFileDialogFoto As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
