<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCetak
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCetak))
        gbHobby = New GroupBox()
        GroupBox1 = New GroupBox()
        dtpTanggalLahir = New DateTimePicker()
        txtAlamat = New TextBox()
        txtTelp = New TextBox()
        txtUmur = New TextBox()
        txtNama = New TextBox()
        btnCetak = New Button()
        btnBrowse = New Button()
        pbFoto = New PictureBox()
        rbLaki = New RadioButton()
        rbPerempuan = New RadioButton()
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox5 = New CheckBox()
        CheckBox6 = New CheckBox()
        CheckBox7 = New CheckBox()
        CheckBox8 = New CheckBox()
        CheckBox9 = New CheckBox()
        CheckBox10 = New CheckBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        gbHobby.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(pbFoto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' gbHobby
        ' 
        gbHobby.Controls.Add(CheckBox10)
        gbHobby.Controls.Add(CheckBox9)
        gbHobby.Controls.Add(CheckBox8)
        gbHobby.Controls.Add(CheckBox7)
        gbHobby.Controls.Add(CheckBox6)
        gbHobby.Controls.Add(CheckBox5)
        gbHobby.Controls.Add(CheckBox4)
        gbHobby.Controls.Add(CheckBox3)
        gbHobby.Controls.Add(CheckBox2)
        gbHobby.Controls.Add(CheckBox1)
        gbHobby.Location = New Point(268, 208)
        gbHobby.Name = "gbHobby"
        gbHobby.Size = New Size(279, 230)
        gbHobby.TabIndex = 19
        gbHobby.TabStop = False
        gbHobby.Text = "Hobby"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rbPerempuan)
        GroupBox1.Controls.Add(rbLaki)
        GroupBox1.Location = New Point(268, 107)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(279, 95)
        GroupBox1.TabIndex = 18
        GroupBox1.TabStop = False
        GroupBox1.Text = "Kelamin"
        ' 
        ' dtpTanggalLahir
        ' 
        dtpTanggalLahir.Location = New Point(268, 64)
        dtpTanggalLahir.Name = "dtpTanggalLahir"
        dtpTanggalLahir.Size = New Size(279, 27)
        dtpTanggalLahir.TabIndex = 17
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(575, 285)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(125, 27)
        txtAlamat.TabIndex = 16
        ' 
        ' txtTelp
        ' 
        txtTelp.Location = New Point(575, 208)
        txtTelp.Name = "txtTelp"
        txtTelp.Size = New Size(125, 27)
        txtTelp.TabIndex = 15
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(575, 133)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(125, 27)
        txtUmur.TabIndex = 14
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(575, 66)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(125, 27)
        txtNama.TabIndex = 13
        ' 
        ' btnCetak
        ' 
        btnCetak.Location = New Point(132, 365)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(94, 29)
        btnCetak.TabIndex = 12
        btnCetak.Text = "Cetak"
        btnCetak.UseVisualStyleBackColor = True
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(32, 365)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(94, 29)
        btnBrowse.TabIndex = 11
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' pbFoto
        ' 
        pbFoto.Location = New Point(32, 23)
        pbFoto.Name = "pbFoto"
        pbFoto.Size = New Size(194, 187)
        pbFoto.TabIndex = 10
        pbFoto.TabStop = False
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(16, 26)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(88, 24)
        rbLaki.TabIndex = 0
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-Laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(16, 56)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(104, 24)
        rbPerempuan.TabIndex = 1
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(15, 38)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(77, 24)
        CheckBox1.TabIndex = 0
        CheckBox1.Text = "Kuliner"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(15, 68)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(69, 24)
        CheckBox2.TabIndex = 1
        CheckBox2.Text = "Musik"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(15, 98)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(97, 24)
        CheckBox3.TabIndex = 2
        CheckBox3.Text = "Membaca"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(15, 128)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(76, 24)
        CheckBox4.TabIndex = 3
        CheckBox4.Text = "Desain"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Location = New Point(15, 160)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(107, 24)
        CheckBox5.TabIndex = 4
        CheckBox5.Text = "Skateboard"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' CheckBox6
        ' 
        CheckBox6.AutoSize = True
        CheckBox6.Location = New Point(124, 38)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(65, 24)
        CheckBox6.TabIndex = 5
        CheckBox6.Text = "Tidur"
        CheckBox6.UseVisualStyleBackColor = True
        ' 
        ' CheckBox7
        ' 
        CheckBox7.AutoSize = True
        CheckBox7.Location = New Point(124, 68)
        CheckBox7.Name = "CheckBox7"
        CheckBox7.Size = New Size(74, 24)
        CheckBox7.TabIndex = 6
        CheckBox7.Text = "Hiking"
        CheckBox7.UseVisualStyleBackColor = True
        ' 
        ' CheckBox8
        ' 
        CheckBox8.AutoSize = True
        CheckBox8.Location = New Point(124, 98)
        CheckBox8.Name = "CheckBox8"
        CheckBox8.Size = New Size(94, 24)
        CheckBox8.TabIndex = 7
        CheckBox8.Text = "Berenang"
        CheckBox8.UseVisualStyleBackColor = True
        ' 
        ' CheckBox9
        ' 
        CheckBox9.AutoSize = True
        CheckBox9.Location = New Point(124, 128)
        CheckBox9.Name = "CheckBox9"
        CheckBox9.Size = New Size(92, 24)
        CheckBox9.TabIndex = 8
        CheckBox9.Text = "Olahraga"
        CheckBox9.UseVisualStyleBackColor = True
        ' 
        ' CheckBox10
        ' 
        CheckBox10.AutoSize = True
        CheckBox10.Location = New Point(125, 160)
        CheckBox10.Name = "CheckBox10"
        CheckBox10.Size = New Size(91, 24)
        CheckBox10.TabIndex = 9
        CheckBox10.Text = "Traveling"
        CheckBox10.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(268, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 20)
        Label1.TabIndex = 20
        Label1.Text = "Tanggal Lahir"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(575, 43)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 21
        Label2.Text = "Nama"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(575, 110)
        Label3.Name = "Label3"
        Label3.Size = New Size(45, 20)
        Label3.TabIndex = 22
        Label3.Text = "Umur"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(575, 182)
        Label4.Name = "Label4"
        Label4.Size = New Size(78, 20)
        Label4.TabIndex = 23
        Label4.Text = "No Telpon"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(575, 262)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 20)
        Label5.TabIndex = 24
        Label5.Text = "Alamat"
        ' 
        ' FormCetak
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(gbHobby)
        Controls.Add(GroupBox1)
        Controls.Add(dtpTanggalLahir)
        Controls.Add(txtAlamat)
        Controls.Add(txtTelp)
        Controls.Add(txtUmur)
        Controls.Add(txtNama)
        Controls.Add(btnCetak)
        Controls.Add(btnBrowse)
        Controls.Add(pbFoto)
        Name = "FormCetak"
        Text = "FormCetak"
        gbHobby.ResumeLayout(False)
        gbHobby.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(pbFoto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents gbHobby As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtpTanggalLahir As DateTimePicker
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtTelp As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents btnCetak As Button
    Friend WithEvents btnBrowse As Button
    Friend WithEvents pbFoto As PictureBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox10 As CheckBox
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label

End Class
