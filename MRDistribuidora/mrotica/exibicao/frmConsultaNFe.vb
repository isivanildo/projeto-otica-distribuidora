Imports System.Data
Imports System.Data.SqlClient
Imports mrotica_util

Public Class frmConsultaNFe
    Dim objPesquisa As New objMaster
    Public intNfe As Integer

    Private Sub frmConsultaNFe_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        grdDados.Columns.Clear()
        grdDados.AutoGenerateColumns = False
        grdDados.AllowUserToAddRows = False
        grdDados.DataSource = Nothing

        Dim numero As New DataGridViewTextBoxColumn 'Posição 00
        numero.HeaderText = "Nº NFe"
        numero.DataPropertyName = "numero"
        numero.Width = 80
        numero.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        numero.DefaultCellStyle.Format = "000000000"
        numero.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        numero.SortMode = DataGridViewColumnSortMode.NotSortable
        grdDados.Columns.Add(numero)

        Dim cliente As New DataGridViewTextBoxColumn 'Posição 01
        cliente.HeaderText = "Cliente"
        cliente.DataPropertyName = "nome_cliente"
        cliente.Width = 370
        grdDados.Columns.Add(cliente)

        Dim valor As New DataGridViewTextBoxColumn 'Posição 02
        valor.HeaderText = "Valor"
        valor.DataPropertyName = "ValorNota"
        valor.Width = 80
        valor.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        valor.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        valor.SortMode = DataGridViewColumnSortMode.NotSortable
        grdDados.Columns.Add(valor)

        Dim situacao As New DataGridViewTextBoxColumn 'Posição 03
        situacao.HeaderText = "Situação"
        situacao.DataPropertyName = "Situacao"
        situacao.Width = 100
        grdDados.Columns.Add(situacao)


        Dim strSQL As String = "select nfe.numero, cliente.nome_cliente, nfe.ValorNota, nfe.Situacao " & _
            "from nfe inner join cliente on nfe.cliente = cliente.cod_cliente where nfe.situacao = 'P'"
        Dim tbNFe As New DataTable
        tbNFe = objPesquisa.retornaRegistro(strSQL).Tables(0)

        If tbNFe.Rows.Count > 0 Then
            grdDados.DataSource = tbNFe

            For Each linha As DataGridViewRow In grdDados.Rows
                If linha.Cells(3).Value = "P" Then
                    linha.Cells(3).Value = "PENDENTE"
                End If
            Next
        End If
    End Sub

    Private Sub btnSair_Click(sender As System.Object, e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        intNfe = grdDados.CurrentRow.Cells(0).Value
        Me.Close()
    End Sub
End Class