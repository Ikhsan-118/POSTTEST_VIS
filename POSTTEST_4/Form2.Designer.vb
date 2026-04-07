<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        pbFotoKartu = New PictureBox()
        lblNama = New Label()
        lblID = New Label()
        lblKomunitas = New Label()
        lblKontak = New Label()
        lblHobi = New Label()
        CType(pbFotoKartu, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbFotoKartu
        ' 
        pbFotoKartu.BackgroundImageLayout = ImageLayout.Stretch
        pbFotoKartu.Location = New Point(34, 33)
        pbFotoKartu.Name = "pbFotoKartu"
        pbFotoKartu.Size = New Size(136, 157)
        pbFotoKartu.TabIndex = 1
        pbFotoKartu.TabStop = False
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(214, 34)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(53, 20)
        lblNama.TabIndex = 2
        lblNama.Text = "Label1"
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Location = New Point(214, 64)
        lblID.Name = "lblID"
        lblID.Size = New Size(53, 20)
        lblID.TabIndex = 3
        lblID.Text = "Label2"
        ' 
        ' lblKomunitas
        ' 
        lblKomunitas.AutoSize = True
        lblKomunitas.Location = New Point(214, 96)
        lblKomunitas.Name = "lblKomunitas"
        lblKomunitas.Size = New Size(53, 20)
        lblKomunitas.TabIndex = 4
        lblKomunitas.Text = "Label3"
        ' 
        ' lblKontak
        ' 
        lblKontak.AutoSize = True
        lblKontak.Location = New Point(214, 129)
        lblKontak.Name = "lblKontak"
        lblKontak.Size = New Size(53, 20)
        lblKontak.TabIndex = 5
        lblKontak.Text = "Label4"
        ' 
        ' lblHobi
        ' 
        lblHobi.AutoSize = True
        lblHobi.Location = New Point(214, 164)
        lblHobi.Name = "lblHobi"
        lblHobi.Size = New Size(53, 20)
        lblHobi.TabIndex = 6
        lblHobi.Text = "Label5"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(518, 230)
        Controls.Add(lblHobi)
        Controls.Add(lblKontak)
        Controls.Add(lblKomunitas)
        Controls.Add(lblID)
        Controls.Add(lblNama)
        Controls.Add(pbFotoKartu)
        Name = "Form2"
        Text = "Form2"
        CType(pbFotoKartu, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pbFotoKartu As PictureBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblKomunitas As Label
    Friend WithEvents lblKontak As Label
    Friend WithEvents lblHobi As Label
End Class
