Imports MySql.Data.MySqlClient

Public Module Conexion
    Private ReadOnly connectionString As String = "Server=localhost;Database=tallerevaepe3;Uid=root;Pwd=;"

    ' Devuelve una conexión cerrada (NO la abre)
    Public Function ObtenerConexion() As MySqlConnection
        Dim conn As New MySqlConnection(connectionString)
        Return conn
    End Function
End Module
