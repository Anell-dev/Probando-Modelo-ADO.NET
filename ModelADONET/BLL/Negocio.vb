
Imports DAL
Imports Entities
Public Class Negocio
    Private objdato As New Dato()
    Public Function ObtenerTodosLosUsuarios() As List(Of Usuario)
        Return objdato.ObtenerUsuarios()
    End Function

    Public Function AgregarUsuario(nuevoUsuario As Usuario) As Boolean
        Return objdato.InsertarUsuarioConectado(nuevoUsuario)
    End Function

    ' Método para actualizar un usuario
    Public Function ModificarUsuario(usuario As Usuario) As Boolean
        Return objdato.ActualizarUsuarioConectado(usuario)
    End Function

    ' Método para eliminar un usuario
    Public Function BorrarUsuario(id As Integer) As Boolean
        Return objdato.EliminarUsuarioConectado(id)
    End Function



    ' obtener usuarios en modo desconectado
    ' Método para obtener usuarios en modo desconectado 
    Public Function ObtenerUsuariosDesconectado() As DataSet
        Return objdato.ObtenerUsuariosDesconectado()
    End Function
    'Actualizacion'
    Public Function ActualizacionBDdesconectado(usuario As Usuario) As Boolean
        Return objdato.ActualizarUsuarioDesconectado(usuario)
    End Function


End Class


