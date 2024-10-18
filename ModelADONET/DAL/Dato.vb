Imports Entities
Imports MySql.Data.MySqlClient

Public Class Dato
    Private connectionString As String = "Server=localhost;Database=usuarios;User Id=root;Password=admin;"

    Public Function ObtenerUsuarios() As List(Of Usuario)
        Dim usuarios As New List(Of Usuario)
        Dim query As String = "SELECT id, nombre, email FROM tbusuario"

        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand(query, connection)

            connection.Open()
            Dim reader As MySqlDataReader = command.ExecuteReader()

            While reader.Read()
                Dim usuario As New Usuario With {
                    .id = reader.GetInt32(0),
                    .nombre = reader.GetString(1),
                    .correo = reader.GetString(2)
                }
                usuarios.Add(usuario)
            End While
        End Using

        Return usuarios
    End Function
End Class
