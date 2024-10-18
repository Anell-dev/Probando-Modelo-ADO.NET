Imports BLL
Imports System.Data
Public Class Desconectado
    Private negociode As New Negocio()
    Private usuariosDataSet As DataSet ' Variable para almacenar los datos desconectados

    Private Sub Desconectado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usuariosDataSet = negociode.ObtenerUsuariosDesconectado()
        dtwDesconectado.DataSource = usuariosDataSet.Tables("Usuarios")
    End Sub

    Private Sub btnConectado_Click(sender As Object, e As EventArgs) Handles btnConectado.Click
        Dim frm As New frmVista()
        Me.Hide()
        frm.Show()
    End Sub
End Class