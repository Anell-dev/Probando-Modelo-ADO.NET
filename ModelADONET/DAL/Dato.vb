Imports Entities
Imports MySql.Data.MySqlClient

Public Class Dato
    Private connectionString As String = "Server=localhost;Database=usuarios;User Id=root;Password=admin;"

    'Modo Conectado-----------------------------------------------------------------'
    Public Function ObtenerUsuarios() As List(Of Usuario)
        Dim usuarios As New List(Of Usuario)
        Dim query As String = "SELECT id, name, email FROM tbusuario"

        Try
            Using connection As New MySqlConnection(connectionString)
                Dim command As New MySqlCommand(query, connection)

                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()

                While reader.Read()
                    Dim usuario As New Usuario With {
                        .id = reader.GetInt32(0),
                        .name = reader.GetString(1),
                        .email = reader.GetString(2)
                    }
                    usuarios.Add(usuario)
                End While
            End Using
        Catch ex As MySqlException
            ' Manejo de errores de MySQL
            MessageBox.Show("Error al obtener usuarios: " & ex.Message)
        Catch ex As Exception
            ' Manejo de otros errores
            MessageBox.Show("Error inesperado: " & ex.Message)
        End Try

        Return usuarios
    End Function

    'Insert'
    Public Function InsertarUsuarioConectado(nuevoUsuario As Usuario) As Boolean
        Dim query As String = "INSERT INTO tbusuario (name, email) VALUES (@name, @email)"
        Try
            Using connection As New MySqlConnection(connectionString)
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@name", nuevoUsuario.name)
                    command.Parameters.AddWithValue("@email", nuevoUsuario.email)

                    connection.Open()
                    Dim filasAfectadas As Integer = command.ExecuteNonQuery()
                    Return filasAfectadas > 0 ' Retorna verdadero si se insertó un registro
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error al insertar usuario: " & ex.Message)
            Return False
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " & ex.Message)
            Return False
        End Try
    End Function

    'Actualizar'
    Public Function ActualizarUsuarioConectado(usuario As Usuario) As Boolean
        Dim query As String = "UPDATE tbusuario SET name = @name, email = @email WHERE id = @id"
        Try
            Using connection As New MySqlConnection(connectionString)
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@id", usuario.id)
                    command.Parameters.AddWithValue("@name", usuario.name)
                    command.Parameters.AddWithValue("@email", usuario.email)

                    connection.Open()
                    Dim filasAfectadas As Integer = command.ExecuteNonQuery()
                    Return filasAfectadas > 0 ' Retorna verdadero si se actualizó un registro
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error al actualizar usuario: " & ex.Message)
            Return False
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " & ex.Message)
            Return False
        End Try
    End Function

    'Eliminar'
    Public Function EliminarUsuarioConectado(id As Integer) As Boolean
        Dim query As String = "DELETE FROM tbusuario WHERE id = @id"
        Try
            Using connection As New MySqlConnection(connectionString)
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@id", id)

                    connection.Open()
                    Dim filasAfectadas As Integer = command.ExecuteNonQuery()
                    Return filasAfectadas > 0 ' Retorna verdadero si se eliminó un registro
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error al eliminar usuario: " & ex.Message)
            Return False
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " & ex.Message)
            Return False
        End Try
    End Function

    'MODO DESCONECTADO -----------------------------------------------------------------' 
    Public Function ObtenerUsuariosDesconectado() As DataSet
        Dim query As String = "SELECT id, name, email FROM tbusuario"
        Dim usuariosDataSet As New DataSet()

        Try
            Using connection As New MySqlConnection(connectionString)
                Dim adapter As New MySqlDataAdapter(query, connection)

                ' Llenar el DataSet con los datos de la base de datos
                adapter.Fill(usuariosDataSet, "Usuarios")
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error al obtener usuarios en modo desconectado: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " & ex.Message)
        End Try

        Return usuariosDataSet
    End Function

    ' Objeto DataAdapter Actualización de la base de datos '
    Public Function ActualizarUsuarioDesconectado(usuario As Usuario) As Boolean
        Dim query As String = "SELECT id, name, email FROM tbusuario WHERE id = @id"

        Try
            Using connection As New MySqlConnection(connectionString)
                Dim adapter As New MySqlDataAdapter(query, connection)
                adapter.SelectCommand.Parameters.AddWithValue("@id", usuario.id)

                Dim builder As New MySqlCommandBuilder(adapter)
                Dim dataSet As New DataSet()

                ' Llenar el DataSet con los datos del usuario a actualizar
                adapter.Fill(dataSet, "Usuarios")

                If dataSet.Tables("Usuarios").Rows.Count > 0 Then
                    Dim row As DataRow = dataSet.Tables("Usuarios").Rows(0)
                    row("name") = usuario.name
                    row("email") = usuario.email

                    ' Guardar los cambios en la base de datos
                    Dim filasAfectadas As Integer = adapter.Update(dataSet, "Usuarios")
                    Return filasAfectadas > 0
                End If
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error al actualizar usuario en modo desconectado: " & ex.Message)
            Return False
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " & ex.Message)
            Return False
        End Try

        Return False
    End Function
End Class
