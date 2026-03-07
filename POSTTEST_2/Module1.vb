Module Module1

    Public daftarBuku(99, 1) As String
    Public jumlahBuku As Integer = 0

    Public Sub TambahBuku(ByVal judul As String, ByVal genre As String)

        If jumlahBuku < 100 Then
            daftarBuku(jumlahBuku, 0) = judul
            daftarBuku(jumlahBuku, 1) = genre
            jumlahBuku += 1
        End If

    End Sub

    Public Sub HapusBuku(ByVal judul As String)

        For i As Integer = 0 To jumlahBuku - 1

            If daftarBuku(i, 0).ToLower = judul.ToLower Then

                For j As Integer = i To jumlahBuku - 2
                    daftarBuku(j, 0) = daftarBuku(j + 1, 0)
                    daftarBuku(j, 1) = daftarBuku(j + 1, 1)
                Next

                jumlahBuku -= 1
                Exit For

            End If

        Next

    End Sub

End Module