<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        btnHapus = New Button()
        Label4 = New Label()
        btnTambah = New Button()
        Label3 = New Label()
        txtHapus = New TextBox()
        Label2 = New Label()
        txtGenre = New TextBox()
        txtJudul = New TextBox()
        ListBox1 = New ListBox()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(400, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 20)
        Label1.TabIndex = 0
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.White
        GroupBox1.Controls.Add(btnHapus)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(btnTambah)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(txtHapus)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtGenre)
        GroupBox1.Controls.Add(txtJudul)
        GroupBox1.Font = New Font("Sylfaen", 10.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(525, 35)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(242, 371)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Buku App"
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(78, 304)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 7
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(9, 243)
        Label4.Name = "Label4"
        Label4.Size = New Size(172, 22)
        Label4.TabIndex = 2
        Label4.Text = "Judul Buku (Hapus)"
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(78, 180)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 29)
        btnTambah.TabIndex = 6
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(9, 119)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 22)
        Label3.TabIndex = 1
        Label3.Text = "Genre"
        ' 
        ' txtHapus
        ' 
        txtHapus.Location = New Point(9, 268)
        txtHapus.Name = "txtHapus"
        txtHapus.Size = New Size(125, 30)
        txtHapus.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(9, 43)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 22)
        Label2.TabIndex = 0
        Label2.Text = "Judul Buku"
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(9, 144)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(125, 30)
        txtGenre.TabIndex = 4
        ' 
        ' txtJudul
        ' 
        txtJudul.Location = New Point(9, 68)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(125, 30)
        txtJudul.TabIndex = 3
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(154, 42)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(335, 364)
        ListBox1.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(ListBox1)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents txtHapus As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnHapus As Button

End Class
