Imports System.Data
Imports System.Data.SqlClient
Imports winotica_util

Public Class frmNegociacaoDetalhe
    Public codacordo As Integer
    Public idfilial As Int16

    Private Sub btnSair_Click(sender As System.Object, e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub frmNegociacaoDetalhe_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class