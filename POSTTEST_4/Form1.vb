Imports System.IO

Public Class Form1

    ' --- NAVIGASI MENUSTRIP ---
    Private Sub InputDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputDataToolStripMenuItem.Click
        TabControl1.SelectedTab = TabControl1.TabPages(0) ' Kembali ke Tab 1 ' [cite: 36, 39]
    End Sub

    Private Sub LihatKartuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatKartuToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub SimpanDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanDataToolStripMenuItem.Click
        SimpanDataKeFile()
    End Sub

    Private Sub BukaDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaDataToolStripMenuItem.Click
        OpenFileDialog1.Filter = "Text File *.txt|*.txt|CSV File *.csv|*.csv" ' [cite: 77]
        OpenFileDialog1.Title = "Buka File Komunitas" ' [cite: 77]
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then ' [cite: 78]
            MessageBox.Show("File berhasil dibuka: " & OpenFileDialog1.FileName, "Informasi") ' [cite: 79]
            ' Logika membaca file bisa ditambahkan di sini
        End If
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim hasil As DialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ' [cite: 107, 108, 110, 111]
        If hasil = DialogResult.Yes Then ' [cite: 119, 120]
            Me.Close() ' [cite: 22]
        End If
    End Sub

    ' --- VALIDASI INPUT: HURUF DAN ANGKA SAJA ---
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        ' Hanya mengizinkan huruf dan spasi
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
        ' Hanya mengizinkan angka
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub mtbTelepon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtbTelepon.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' --- UPLOAD FOTO ---
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialogFoto.Filter = "Image Files|*.jpg;*.jpeg;*.png"
        If OpenFileDialogFoto.ShowDialog() = DialogResult.OK Then
            pbProfil.ImageLocation = OpenFileDialogFoto.FileName
        End If
    End Sub

    ' --- PROSES SIMPAN & CETAK (KLIK BUTTON) ---
    Private Sub btnSimpanCetak_Click(sender As Object, e As EventArgs) Handles btnSimpanCetak.Click
        If ValidasiInput() Then
            Dim hasil As DialogResult = MessageBox.Show("Data sudah lengkap. Apakah data ingin disimpan dan dicetak?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ' [cite: 105, 107]

            If hasil = DialogResult.Yes Then ' [cite: 119, 120]
                TampilkanKeForm2()
                SimpanDataKeFile()
                Form2.Show()
            End If
        Else
            MessageBox.Show("Masih ada inputan yang salah atau kosong. Silakan periksa tanda merah.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' --- FUNGSI VALIDASI ---
    Private Function ValidasiInput() As Boolean
        ErrorProvider1.Clear() ' [cite: 46]
        Dim isValid As Boolean = True

        ' Validasi Textbox Kosong
        If txtNama.Text.Trim() = "" Then ' [cite: 47]
            ErrorProvider1.SetError(txtNama, "Inputan tidak boleh kosong") ' [cite: 48]
            isValid = False
        End If
        If txtId.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtId, "Inputan tidak boleh kosong")
            isValid = False
        End If
        If txtUmur.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtUmur, "Inputan tidak boleh kosong")
            isValid = False
        End If
        If txtEmail.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtEmail, "Inputan tidak boleh kosong")
            isValid = False
        End If
        If txtAlamat.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtAlamat, "Inputan tidak boleh kosong")
            isValid = False
        End If

        ' Validasi MaskedTextBox
        If Not mtbTelepon.MaskCompleted Then ' [cite: 66]
            ErrorProvider1.SetError(mtbTelepon, "Format tidak sesuai") ' [cite: 66]
            isValid = False
        End If

        ' Validasi CheckBox (Minimal 1 terpilih)
        Dim cekHobi As Boolean = chk1.Checked Or chk2.Checked Or chk3.Checked Or chk4.Checked Or chk5.Checked Or chk6.Checked Or chk7.Checked Or chk8.Checked
        If Not cekHobi Then
            ErrorProvider1.SetError(chk1, "Inputan tidak boleh kosong (pilih minimal 1 hobi)")
            isValid = False
        End If

        ' Validasi Foto
        If pbProfil.ImageLocation Is Nothing Then
            ErrorProvider1.SetError(btnBrowse, "Inputan tidak boleh kosong (Pilih Foto)")
            isValid = False
        End If

        Return isValid
    End Function

    ' --- FUNGSI TRANSFER DATA KE FORM 2 ---
    Private Sub TampilkanKeForm2()
        Form2.lblNama.Text = txtNama.Text
        Form2.lblID.Text = "ID: " & txtId.Text

        Dim peran As String = ""
        If rbKetua.Checked Then peran = "Ketua"
        If rbAdmin.Checked Then peran = "Admin"
        If rbAnggota.Checked Then peran = "Anggota"

        Form2.lblKomunitas.Text = "Divisi: " & cmbDevisi.Text & " | Peran: " & peran
        Form2.lblKontak.Text = "Telp: " & mtbTelepon.Text & vbCrLf & "Email: " & txtEmail.Text

        ' Kumpulkan Hobi
        Dim hobi As String = "Aktivitas: "
        If chk1.Checked Then hobi &= chk1.Text & ", "
        If chk2.Checked Then hobi &= chk2.Text & ", "
        If chk3.Checked Then hobi &= chk3.Text & ", "
        If chk4.Checked Then hobi &= chk4.Text & ", "
        If chk5.Checked Then hobi &= chk5.Text & ", "
        If chk6.Checked Then hobi &= chk6.Text & ", "
        If chk7.Checked Then hobi &= chk7.Text & ", "
        If chk8.Checked Then hobi &= chk8.Text & ", "

        Form2.lblHobi.Text = hobi.TrimEnd(", ".ToCharArray())
        Form2.pbFotoKartu.ImageLocation = pbProfil.ImageLocation
    End Sub

    ' --- FUNGSI SAVE FILE DIALOG ---
    Private Sub SimpanDataKeFile()
        SaveFileDialog1.Filter = "Text File *.txt|*.txt|CSV File|*.csv" ' [cite: 94]
        SaveFileDialog1.Title = "Simpan Data Komunitas" ' [cite: 95]
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then ' [cite: 96]
            Dim dataPrint As String = "Nama: " & txtNama.Text & vbCrLf & "ID: " & txtId.Text & vbCrLf & "Telepon: " & mtbTelepon.Text
            IO.File.WriteAllText(SaveFileDialog1.FileName, dataPrint) ' [cite: 97]
            MessageBox.Show("File berhasil disimpan", "Informasi") ' [cite: 97]
        End If
    End Sub

End Class