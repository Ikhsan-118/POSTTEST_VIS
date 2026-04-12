Imports MySqlConnector

Module ConnectionModule
    ' Sesuaikan dengan setting XAMPP kamu
    Public ReadOnly ConnectionString As String = "Server=localhost; Port=3306; Database=dbspotify; User ID=root; Password=;"

    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(ConnectionString)
    End Function
End Module