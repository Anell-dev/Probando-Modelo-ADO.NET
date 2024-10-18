Imports BLL
Imports Entities

Public Class frmVista
    Private negocio As New Negocio()

    Private Sub frmVista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim usuarios As List(Of Usuario) = negocio.ObtenerTodosLosUsuarios()
        dtwUsuarios.DataSource = usuarios
    End Sub
End Class
