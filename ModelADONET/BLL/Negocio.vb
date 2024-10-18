
Imports DAL
Imports Entities
Public Class Negocio
    Private objdato As New Dato()
    Public Function ObtenerTodosLosUsuarios() As List(Of Usuario)
        Return objdato.ObtenerUsuarios()
    End Function
End Class


