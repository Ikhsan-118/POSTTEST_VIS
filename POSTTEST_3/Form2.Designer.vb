<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHasil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormHasil))
        pbFotoHasil = New PictureBox()
        lblNamaHasil = New Label()
        lblUmurHasil = New Label()
        lblTelpHasil = New Label()
        lblJenisKelaminHasil = New Label()
        lblTanggalLahirHasil = New Label()
        lblAlamatHasil = New Label()
        lblHobbyHasil = New Label()
        CType(pbFotoHasil, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbFotoHasil
        ' 
        pbFotoHasil.Location = New Point(66, 140)
        pbFotoHasil.Name = "pbFotoHasil"
        pbFotoHasil.Size = New Size(199, 195)
        pbFotoHasil.TabIndex = 0
        pbFotoHasil.TabStop = False
        ' 
        ' lblNamaHasil
        ' 
        lblNamaHasil.AutoSize = True
        lblNamaHasil.Location = New Point(341, 146)
        lblNamaHasil.Name = "lblNamaHasil"
        lblNamaHasil.Size = New Size(53, 20)
        lblNamaHasil.TabIndex = 1
        lblNamaHasil.Text = "Label1"
        ' 
        ' lblUmurHasil
        ' 
        lblUmurHasil.AutoSize = True
        lblUmurHasil.Location = New Point(341, 187)
        lblUmurHasil.Name = "lblUmurHasil"
        lblUmurHasil.Size = New Size(53, 20)
        lblUmurHasil.TabIndex = 2
        lblUmurHasil.Text = "Label2"
        ' 
        ' lblTelpHasil
        ' 
        lblTelpHasil.AutoSize = True
        lblTelpHasil.Location = New Point(341, 232)
        lblTelpHasil.Name = "lblTelpHasil"
        lblTelpHasil.Size = New Size(53, 20)
        lblTelpHasil.TabIndex = 3
        lblTelpHasil.Text = "Label3"
        ' 
        ' lblJenisKelaminHasil
        ' 
        lblJenisKelaminHasil.AutoSize = True
        lblJenisKelaminHasil.Location = New Point(341, 281)
        lblJenisKelaminHasil.Name = "lblJenisKelaminHasil"
        lblJenisKelaminHasil.Size = New Size(53, 20)
        lblJenisKelaminHasil.TabIndex = 4
        lblJenisKelaminHasil.Text = "Label4"
        ' 
        ' lblTanggalLahirHasil
        ' 
        lblTanggalLahirHasil.AutoSize = True
        lblTanggalLahirHasil.Location = New Point(535, 146)
        lblTanggalLahirHasil.Name = "lblTanggalLahirHasil"
        lblTanggalLahirHasil.Size = New Size(53, 20)
        lblTanggalLahirHasil.TabIndex = 5
        lblTanggalLahirHasil.Text = "Label5"
        ' 
        ' lblAlamatHasil
        ' 
        lblAlamatHasil.AutoSize = True
        lblAlamatHasil.Location = New Point(535, 187)
        lblAlamatHasil.Name = "lblAlamatHasil"
        lblAlamatHasil.Size = New Size(53, 20)
        lblAlamatHasil.TabIndex = 6
        lblAlamatHasil.Text = "Label6"
        ' 
        ' lblHobbyHasil
        ' 
        lblHobbyHasil.AutoSize = True
        lblHobbyHasil.Location = New Point(535, 232)
        lblHobbyHasil.Name = "lblHobbyHasil"
        lblHobbyHasil.Size = New Size(53, 20)
        lblHobbyHasil.TabIndex = 7
        lblHobbyHasil.Text = "Label7"
        ' 
        ' FormHasil
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(lblHobbyHasil)
        Controls.Add(lblAlamatHasil)
        Controls.Add(lblTanggalLahirHasil)
        Controls.Add(lblJenisKelaminHasil)
        Controls.Add(lblTelpHasil)
        Controls.Add(lblUmurHasil)
        Controls.Add(lblNamaHasil)
        Controls.Add(pbFotoHasil)
        Name = "FormHasil"
        Text = "FormHasil"
        CType(pbFotoHasil, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pbFotoHasil As PictureBox
    Friend WithEvents lblNamaHasil As Label
    Friend WithEvents lblUmurHasil As Label
    Friend WithEvents lblTelpHasil As Label
    Friend WithEvents lblJenisKelaminHasil As Label
    Friend WithEvents lblTanggalLahirHasil As Label
    Friend WithEvents lblAlamatHasil As Label
    Friend WithEvents lblHobbyHasil As Label
End Class
