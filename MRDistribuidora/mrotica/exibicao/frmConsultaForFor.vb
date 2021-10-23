Imports System.Data
Imports System.Data.SqlClient
Imports mrotica_util

Public Class frmConsultaForFor

    Public codigo_form As Integer

    Dim d As New dados

    Private Sub frmConsultaPedido_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        carrega_grid()
        carrega_pedidos()
    End Sub

    Private Sub btnOk_Click(sender As System.Object, e As System.EventArgs) Handles btnOk.Click
        codigo_form = DataGridView1.CurrentRow.Cells(0).Value
        Me.Close()
    End Sub

    Private Sub carrega_pedidos()
        Dim strSQL As String = "select cod_fornecedor, fornecedor from fornecedor"
        Dim cmd As New SqlCommand(strSQL, d.con)

        Dim dr As SqlDataReader

        d.conecta()

        dr = cmd.ExecuteReader

        While dr.Read
            DataGridView1.Rows.Add(dr.Item("cod_fornecedor").ToString, dr.Item("fornecedor").ToString)
        End While

        dr.Close()
        d.desconecta()
    End Sub

    Private Sub carrega_grid()
        Dim pedido As New DataGridViewTextBoxColumn
        pedido.HeaderText = "Código"
        pedido.Width = 60
        DataGridView1.Columns.Add(pedido)

        Dim fornecedor As New DataGridViewTextBoxColumn
        fornecedor.HeaderText = "Fornecedor"
        fornecedor.Width = 250
        DataGridView1.Columns.Add(fornecedor)

    End Sub

End Class