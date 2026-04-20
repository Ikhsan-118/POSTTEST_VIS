Imports MySqlConnector

' =============================================================
' DataModule.vb
' Berisi semua fungsi koneksi dan operasi database (CRUD)
' untuk tbalbum dan tblagu (relasi Foreign Key)
' =============================================================
Module DataModule

    ' ── Koneksi ──────────────────────────────────────────────
    Public Function GetConnection() As MySqlConnection
        Dim connStr As String = "server=localhost;port=3306;database=dbspotify;uid=root;pwd=;"
        Return New MySqlConnection(connStr)
    End Function

    ' ═══════════════════════════════════════════════════════════
    ' FUNGSI ALBUM (tbalbum)
    ' ═══════════════════════════════════════════════════════════

    Public Function GetAllAlbum() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT kodeAlbum, judulAlbum, artis, tahunRilis, genre " &
                                  "FROM tbalbum ORDER BY judulAlbum ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data album: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SearchAlbum(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT kodeAlbum, judulAlbum, artis, tahunRilis, genre " &
                                  "FROM tbalbum " &
                                  "WHERE judulAlbum LIKE @kw OR artis LIKE @kw OR genre LIKE @kw " &
                                  "ORDER BY judulAlbum ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kw", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari album: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function KodeSudahAda(kode As String) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM tbalbum WHERE kodeAlbum = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
                End Using
            End Using
        Catch ex As Exception
            Return True
        End Try
    End Function

    Public Function SimpanAlbum(kode As String, judul As String, artis As String,
                                 tahun As Integer, genre As String) As Boolean
        Try
            Dim query As String = "INSERT INTO tbalbum (kodeAlbum, judulAlbum, artis, tahunRilis, genre) " &
                                  "VALUES (@kode, @judul, @artis, @tahun, @genre)"
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
            MessageBox.Show("Gagal menyimpan album: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahAlbum(kode As String, judul As String, artis As String,
                               tahun As Integer, genre As String) As Boolean
        Try
            Dim query As String = "UPDATE tbalbum SET judulAlbum=@judul, artis=@artis, " &
                                  "tahunRilis=@tahun, genre=@genre WHERE kodeAlbum=@kode"
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
            MessageBox.Show("Gagal mengubah album: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusAlbum(kode As String) As Boolean
        Try
            ' Lagu akan ikut terhapus karena ON DELETE CASCADE
            Dim query As String = "DELETE FROM tbalbum WHERE kodeAlbum = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus album: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' ═══════════════════════════════════════════════════════════
    ' FUNGSI LAGU (tblagu) — tabel anak, berelasi ke tbalbum
    ' ═══════════════════════════════════════════════════════════

    Public Function GetAllLagu() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT l.kodeLagu, a.judulAlbum AS 'Album', a.artis AS 'Artis', " &
                "l.trackNo AS 'Track', l.judulLagu AS 'Judul Lagu', " &
                "SEC_TO_TIME(l.durasi) AS 'Durasi', l.kodeAlbum " &
                "FROM tblagu l " &
                "INNER JOIN tbalbum a ON l.kodeAlbum = a.kodeAlbum " &
                "ORDER BY a.judulAlbum ASC, l.trackNo ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data lagu: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function GetLaguByAlbum(kodeAlbum As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT l.kodeLagu, l.trackNo AS 'Track', l.judulLagu AS 'Judul Lagu', " &
                "SEC_TO_TIME(l.durasi) AS 'Durasi' " &
                "FROM tblagu l WHERE l.kodeAlbum = @kode ORDER BY l.trackNo ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kode", kodeAlbum)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memuat lagu: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SearchLagu(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT l.kodeLagu, a.judulAlbum AS 'Album', a.artis AS 'Artis', " &
                "l.trackNo AS 'Track', l.judulLagu AS 'Judul Lagu', " &
                "SEC_TO_TIME(l.durasi) AS 'Durasi', l.kodeAlbum " &
                "FROM tblagu l " &
                "INNER JOIN tbalbum a ON l.kodeAlbum = a.kodeAlbum " &
                "WHERE l.judulLagu LIKE @kw OR a.judulAlbum LIKE @kw OR a.artis LIKE @kw " &
                "ORDER BY a.judulAlbum ASC, l.trackNo ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kw", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari lagu: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function KodeLaguSudahAda(kode As String) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM tblagu WHERE kodeLagu = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
                End Using
            End Using
        Catch ex As Exception
            Return True
        End Try
    End Function

    Public Function SimpanLagu(kodeLagu As String, kodeAlbum As String, judulLagu As String,
                                durasi As Integer, trackNo As Integer) As Boolean
        Try
            Dim query As String = "INSERT INTO tblagu (kodeLagu, kodeAlbum, judulLagu, durasi, trackNo) " &
                                  "VALUES (@kodeLagu, @kodeAlbum, @judulLagu, @durasi, @trackNo)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kodeLagu", kodeLagu)
                    cmd.Parameters.AddWithValue("@kodeAlbum", kodeAlbum)
                    cmd.Parameters.AddWithValue("@judulLagu", judulLagu)
                    cmd.Parameters.AddWithValue("@durasi", durasi)
                    cmd.Parameters.AddWithValue("@trackNo", trackNo)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan lagu: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahLagu(kodeLagu As String, kodeAlbum As String, judulLagu As String,
                              durasi As Integer, trackNo As Integer) As Boolean
        Try
            Dim query As String = "UPDATE tblagu SET kodeAlbum=@kodeAlbum, judulLagu=@judulLagu, " &
                                  "durasi=@durasi, trackNo=@trackNo WHERE kodeLagu=@kodeLagu"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kodeLagu", kodeLagu)
                    cmd.Parameters.AddWithValue("@kodeAlbum", kodeAlbum)
                    cmd.Parameters.AddWithValue("@judulLagu", judulLagu)
                    cmd.Parameters.AddWithValue("@durasi", durasi)
                    cmd.Parameters.AddWithValue("@trackNo", trackNo)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah lagu: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusLagu(kodeLagu As String) As Boolean
        Try
            Dim query As String = "DELETE FROM tblagu WHERE kodeLagu = @kodeLagu"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kodeLagu", kodeLagu)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus lagu: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

End Module
