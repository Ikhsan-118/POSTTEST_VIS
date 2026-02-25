Public Class Form1

    ' Variabel untuk menyimpan total dan jumlah semester
    Dim totalIPSemester As Double = 0
    Dim jumlahSemester As Integer = 0

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        Dim nilaiIPSemester As Double

        ' Validasi input angka
        If Double.TryParse(txtIPSemester.Text, nilaiIPSemester) Then

            ' Validasi rentang IP
            If nilaiIPSemester >= 0 And nilaiIPSemester <= 4 Then

                totalIPSemester += nilaiIPSemester
                jumlahSemester += 1

                Dim nilaiIPK As Double = totalIPSemester / jumlahSemester
                lblIPK.Text = nilaiIPK.ToString("0.00")

                ' Menentukan predikat IPK
                If nilaiIPK >= 2.0 And nilaiIPK <= 2.75 Then
                    lblPredikat.Text = "Cukup"
                ElseIf nilaiIPK >= 2.76 And nilaiIPK <= 3.0 Then
                    lblPredikat.Text = "Memuaskan"
                ElseIf nilaiIPK >= 3.01 Then
                    lblPredikat.Text = "Sangat Memuaskan"
                Else
                    lblPredikat.Text = "-"
                End If

                ' Kosongkan textbox setelah tambah
                txtIPSemester.Clear()
                txtIPSemester.Focus()

            Else
                MessageBox.Show("IP Semester harus antara 0 sampai 4")
            End If

        Else
            MessageBox.Show("Masukkan angka yang valid!")
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        ' Reset semua data
        totalIPSemester = 0
        jumlahSemester = 0
        lblIPK.Text = "0.00"
        lblPredikat.Text = "-"
        txtIPSemester.Clear()
        txtIPSemester.Focus()

    End Sub
End Class