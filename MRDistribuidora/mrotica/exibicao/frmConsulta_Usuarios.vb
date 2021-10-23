Imports System.Data
Imports System.Data.SqlClient
Imports mrotica_util
Imports MRUtil
Imports System.Collections.Generic


Public Class frmConsulta_Usuarios
    Dim user As New Usuario
    Public xIntCodigo As Integer
    Public xStrUsuario As String
    Public xStrSenha As String
    Public xPerfil As Integer
    Public xAtivo As Boolean

    Private Sub frmConsulta_Usuarios_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        grdUsuario.DataSource = user.RetornaDados()

        grdUsuario.Width = 470
        grdUsuario.AllowUserToAddRows = False
        grdUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        grdUsuario.Columns(0).HeaderText = "Código"
        grdUsuario.Columns(0).Width = 70
        grdUsuario.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdUsuario.Columns(1).HeaderText = "Usuário"
        grdUsuario.Columns(1).Width = 170
        grdUsuario.Columns(2).HeaderText = "Senha"
        grdUsuario.Columns(2).Visible = False
        grdUsuario.Columns(3).HeaderText = "Nome Completo"
        grdUsuario.Columns(3).Visible = False
        grdUsuario.Columns(4).HeaderText = "Perfil"
        grdUsuario.Columns(4).Width = 180
        grdUsuario.Columns(4).Visible = True
        grdUsuario.Columns(5).HeaderText = "Ativo"
        grdUsuario.Columns(5).Visible = True
        grdUsuario.Columns(6).HeaderText = "Perfil"
        grdUsuario.Columns(6).Visible = False
    End Sub

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        xIntCodigo = grdUsuario.CurrentRow.Cells(0).Value
        xStrUsuario = grdUsuario.CurrentRow.Cells(1).Value
        xStrSenha = Criptografia.TextoDescriptografado(grdUsuario.CurrentRow.Cells(2).Value)
        xPerfil = grdUsuario.CurrentRow.Cells(6).Value
        xAtivo = grdUsuario.CurrentRow.Cells(5).Value
        Me.Close()
    End Sub

End Class