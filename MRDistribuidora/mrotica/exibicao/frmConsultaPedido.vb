Imports System.Data
Imports System.Data.SqlClient
Imports mrotica_util

Public Class frmConsultaPedido

    Public codigopedido As Integer 'Armazena codigo do pedido a ser lançado no formulário anterior
    Public situacao As Boolean 'Utilizado para informar se a situação do pedido está selecionada ou não
    Public descsitucao As String 'Armazena a descrição do andamento do pedido do fornecedor
    Dim strSQL As String = ""

    Dim d As New dados

    Private Sub frmConsultaPedido_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        carrega_grid() 'Carrega e monta o grid
        carrega_pedidos() 'Traz as informações do pedido
    End Sub

    Private Sub btnOk_Click(sender As System.Object, e As System.EventArgs) Handles btnOk.Click
        Dim selecaopar As Boolean
        Dim selecaotot As Boolean

        For Each celulas As DataGridViewRow In DataGridView1.Rows
            selecaopar = celulas.Cells(3).Value
            selecaotot = celulas.Cells(4).Value

            If (selecaopar = True) And (selecaotot = True) Then
                MessageBox.Show("Somente uma situação pode está selecionada.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Next

        codigopedido = DataGridView1.CurrentRow.Cells(0).Value

        If DataGridView1.CurrentRow.Cells(3).Value = True Then
            situacao = True
            descsitucao = carrega_status_pedido_for(7)
        End If

        If DataGridView1.CurrentRow.Cells(4).Value = True Then
            situacao = True
            descsitucao = carrega_status_pedido_for(8)
        End If

        Me.Close()
    End Sub

    'Rotina responsável por trazer os pedidos solicitados
    Private Sub carrega_pedidos()
        Dim strSQL As String = "select top(200) pedido_fornecedor.cod_pedido, pedido_fornecedor.data_pedido, cod_status_pedido, " & _
                                       "sum(pedido_fornecedor_itens.quantidade) as total from pedido_fornecedor inner join " & _
                                       "pedido_fornecedor_itens on pedido_fornecedor.cod_pedido = pedido_fornecedor_itens.cod_pedido " & _
                                       "where (pedido_fornecedor.cod_status_pedido = 1) or (pedido_fornecedor.cod_status_pedido = 7)  " & _
                                       "group by pedido_fornecedor.cod_pedido, pedido_fornecedor.data_pedido, cod_status_pedido " & _
                                       "order by pedido_fornecedor.cod_pedido desc"

        Dim cmd As New SqlCommand(strSQL, d.con)

        Dim dr As SqlDataReader

        d.conecta()

        dr = cmd.ExecuteReader

        Do While dr.Read
            DataGridView1.Rows.Add(dr.Item("cod_pedido").ToString, FormatDateTime(dr.Item("data_pedido").ToString, DateFormat.ShortDate), _
                                   dr("total").ToString, IIf(dr("cod_status_pedido") = 7, True, False))
        Loop

        dr.Close()
        d.desconecta()
    End Sub

    'Rotina responsável por localizar registros
    Private Sub carrega_pedidos(ByVal codigo As String)
        DataGridView1.Rows.Clear()
        If codigo <> String.Empty Then
            strSQL = "select top(200) pedido_fornecedor.cod_pedido, pedido_fornecedor.data_pedido, cod_status_pedido, " & _
                    "sum(pedido_fornecedor_itens.quantidade) as total from pedido_fornecedor inner join " & _
                    "pedido_fornecedor_itens on pedido_fornecedor.cod_pedido = pedido_fornecedor_itens.cod_pedido " & _
                    "where pedido_fornecedor.cod_pedido = " & codigo & "" & _
                    " group by pedido_fornecedor.cod_pedido, pedido_fornecedor.data_pedido, cod_status_pedido " & _
                    "order by pedido_fornecedor.cod_pedido desc"
        Else
            strSQL = "select top(200) pedido_fornecedor.cod_pedido, pedido_fornecedor.data_pedido, cod_status_pedido, " & _
                    "sum(pedido_fornecedor_itens.quantidade) as total from pedido_fornecedor inner join " & _
                    "pedido_fornecedor_itens on pedido_fornecedor.cod_pedido = pedido_fornecedor_itens.cod_pedido " & _
                    "where (pedido_fornecedor.cod_status_pedido = 1) or (pedido_fornecedor.cod_status_pedido = 7)  " & _
                    "group by pedido_fornecedor.cod_pedido, pedido_fornecedor.data_pedido, cod_status_pedido " & _
                    "order by pedido_fornecedor.cod_pedido desc"
        End If

        Dim cmd As New SqlCommand(strSQL, d.con)

        Dim dr As SqlDataReader

        d.conecta()

        dr = cmd.ExecuteReader

        Do While dr.Read
            DataGridView1.Rows.Add(dr.Item("cod_pedido").ToString, FormatDateTime(dr.Item("data_pedido").ToString, DateFormat.ShortDate), _
                                   dr("total").ToString, IIf(dr("cod_status_pedido") = 7, True, False))
        Loop

        dr.Close()
        d.desconecta()
    End Sub

    'Rotina responsável por montar e carregadr o grid
    Private Sub carrega_grid()
        Dim pedido As New DataGridViewTextBoxColumn
        pedido.HeaderText = "Pedido"
        pedido.Width = 70
        pedido.ReadOnly = True
        DataGridView1.Columns.Add(pedido)

        Dim datapedido As New DataGridViewTextBoxColumn
        datapedido.HeaderText = "Data Pedido"
        datapedido.Width = 100
        datapedido.ReadOnly = True
        DataGridView1.Columns.Add(datapedido)

        Dim totalquantped As New DataGridViewTextBoxColumn
        totalquantped.HeaderText = "Qtde"
        totalquantped.Width = 70
        DataGridView1.Columns.Add(totalquantped)


        Dim sitparcial As New DataGridViewCheckBoxColumn
        sitparcial.HeaderText = "At. Parcial"
        sitparcial.Width = 70
        DataGridView1.Columns.Add(sitparcial)

        Dim sittotal As New DataGridViewCheckBoxColumn
        sittotal.HeaderText = "At. Total"
        sittotal.Width = 70
        DataGridView1.Columns.Add(sittotal)

    End Sub

    'Função responsável por trazer o status do pedido do fornecedor
    Private Function carrega_status_pedido_for(ByVal codigo As Integer) As String
        Dim strSQL As String = "select * from status_pedido_fornecedor where cod_status_pedido = " & codigo

        Dim cmd As New SqlCommand(strSQL, d.con)

        Dim dr As SqlDataReader

        d.conecta()
        dr = cmd.ExecuteReader
        dr.Read()

        Return dr.Item("Status_pedido_fornecedor").ToString

        dr.Close()
        d.desconecta()
    End Function


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        carrega_pedidos(txtPedido.Text)
    End Sub
End Class