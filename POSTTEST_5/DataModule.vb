Imports MySqlConnector
Imports System.Data

Module DataModule
    ' CREATE: Simpan Data Baru
    Public Function SimpanAlbum(kode As String, judul As String, artis As String, tahun As Integer, genre As String) As Boolean
        Try
            Dim query As String = "INSERT INTO tbalbum (kodeAlbum, judulAlbum, artis, tahunRilis, genre) VALUES (@kode, @judul, @artis, @tahun, @genre)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@judul", judul)
                    cmd.Parameters.AddWithValue("@artis", artis)
                    cmd.Parameters.AddWithValue("@tahun", tahun)
                    cmd.Parameters.AddWithValue("@genre", genre)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal simpan: " & ex.Message)
            Return False
        End Try
    End Function

    ' UPDATE: Ubah Data
    Public Function UbahAlbum(kode As String, judul As String, artis As String, tahun As Integer, genre As String) As Boolean
        Try
            Dim query As String = "UPDATE tbalbum SET judulAlbum=@judul, artis=@artis, tahunRilis=@tahun, genre=@genre WHERE kodeAlbum=@kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@judul", judul)
                    cmd.Parameters.AddWithValue("@artis", artis)
                    cmd.Parameters.AddWithValue("@tahun", tahun)
                    cmd.Parameters.AddWithValue("@genre", genre)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function
End Module