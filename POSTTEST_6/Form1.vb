' =============================================================
' Form1.vb  — Halaman utama / splash screen
' =============================================================
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Animasi sederhana: fade-in opacity
        Me.Opacity = 0
        Dim tmr As New Timer()
        tmr.Interval = 20
        AddHandler tmr.Tick, Sub(s, ea)
            If Me.Opacity < 1 Then
                Me.Opacity += 0.05
            Else
                CType(s, Timer).Stop()
            End If
        End Sub
        tmr.Start()
    End Sub

    Private Sub btnKelolaAlbum_Click(sender As Object, e As EventArgs) Handles btnKelolaAlbum.Click
        Dim frm As New FormAlbum()
        frm.ShowDialog()
    End Sub

    Private Sub btnKelolaLagu_Click(sender As Object, e As EventArgs) Handles btnKelolaLagu.Click
        Dim frm As New FormLagu("", "")
        frm.ShowDialog()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Dim hasil As DialogResult = MessageBox.Show(
            "Keluar dari aplikasi?", "Konfirmasi",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

End Class
