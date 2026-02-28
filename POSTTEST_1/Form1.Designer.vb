<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnTambah = New Button()
        btnReset = New Button()
        txtIPSemester = New TextBox()
        lblIPSemester = New Label()
        lblIPKText = New Label()
        lblIPK = New Label()
        lblPredikatText = New Label()
        lblPredikat = New Label()
        SuspendLayout()
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(280, 294)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 29)
        btnTambah.TabIndex = 0
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(424, 294)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(94, 29)
        btnReset.TabIndex = 1
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' txtIPSemester
        ' 
        txtIPSemester.Location = New Point(341, 235)
        txtIPSemester.Name = "txtIPSemester"
        txtIPSemester.Size = New Size(125, 27)
        txtIPSemester.TabIndex = 2
        ' 
        ' lblIPSemester
        ' 
        lblIPSemester.AutoSize = True
        lblIPSemester.Location = New Point(359, 96)
        lblIPSemester.Name = "lblIPSemester"
        lblIPSemester.Size = New Size(86, 20)
        lblIPSemester.TabIndex = 3
        lblIPSemester.Text = "IP Semester"
        ' 
        ' lblIPKText
        ' 
        lblIPKText.AutoSize = True
        lblIPKText.Location = New Point(304, 153)
        lblIPKText.Name = "lblIPKText"
        lblIPKText.Size = New Size(89, 20)
        lblIPKText.TabIndex = 4
        lblIPKText.Text = "IP Kumulatif"
        ' 
        ' lblIPK
        ' 
        lblIPK.AutoSize = True
        lblIPK.Location = New Point(304, 185)
        lblIPK.Name = "lblIPK"
        lblIPK.Size = New Size(36, 20)
        lblIPK.TabIndex = 5
        lblIPK.Text = "0.00"
        ' 
        ' lblPredikatText
        ' 
        lblPredikatText.AutoSize = True
        lblPredikatText.Location = New Point(436, 153)
        lblPredikatText.Name = "lblPredikatText"
        lblPredikatText.Size = New Size(63, 20)
        lblPredikatText.TabIndex = 6
        lblPredikatText.Text = "Predikat"
        ' 
        ' lblPredikat
        ' 
        lblPredikat.AutoSize = True
        lblPredikat.Location = New Point(436, 185)
        lblPredikat.Name = "lblPredikat"
        lblPredikat.Size = New Size(15, 20)
        lblPredikat.TabIndex = 7
        lblPredikat.Text = "-"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.WhatsApp_Image_2025_08_07_at_18_12_37
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(lblPredikat)
        Controls.Add(lblPredikatText)
        Controls.Add(lblIPK)
        Controls.Add(lblIPKText)
        Controls.Add(lblIPSemester)
        Controls.Add(txtIPSemester)
        Controls.Add(btnReset)
        Controls.Add(btnTambah)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnTambah As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents txtIPSemester As TextBox
    Friend WithEvents lblIPSemester As Label
    Friend WithEvents lblIPKText As Label
    Friend WithEvents lblIPK As Label
    Friend WithEvents lblPredikatText As Label
    Friend WithEvents lblPredikat As Label

End Class

