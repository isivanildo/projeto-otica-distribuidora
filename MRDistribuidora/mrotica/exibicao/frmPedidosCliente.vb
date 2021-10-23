Imports mrotica_util
Public Class frmPedidosCliente
    Dim d As New dados
    Dim tb As New DataTable
    Dim id As Integer
    Public id_filial As Integer = Nothing
    Public num_pedido As Integer = Nothing
    Public status As Integer = Nothing
    Public faturado As Boolean
    Public ttRes As New DataTable
    Private Sub frmPedidosCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub
    Private Sub Cria_tabela()
        ttRes.Columns.Add("id_filial")
        ttRes.Columns.Add("num_pedido")
        ttRes.Columns.Add("cod_status_pedido")
        ttRes.Columns.Add("faturado")
    End Sub
    Public Sub carrega_pedidos(ByVal x_cod_filial_cliente As Integer, ByVal x_cod_cliente As Integer)
        Dim sql As String
        sql = "SELECT pedido_balcao.id_filial, pedido_balcao.num_pedido, " & _
        "pedido_balcao.data_pedido, pedido_balcao.cod_status_pedido, " & _
        "status_pedido.Status_pedido, Usuarios.NOME,  " & _
        "(SELECT count(item) as itens FROM fatura_itens  " & _
        "WHERE (num_pedido =pedido_balcao.num_pedido) AND  " & _
        "(id_filial_pedido =pedido_balcao.id_filial)) as  " & _
        "Faturado," & _
        "isnull((SELECT sum(pedido_balcao_itens.quant *  " & _
        "(pedido_balcao_itens.preco - pedido_balcao_itens.preco *  " & _
        "(pedido_balcao_itens.desconto / 100))) AS total  " & _
        "FROM pedido_balcao_itens INNER JOIN  " & _
        "produtos ON pedido_balcao_itens.cod_produto = produtos.cod_produto  " & _
        "WHERE (pedido_balcao_itens.num_pedido = pedido_balcao.num_pedido) AND  " & _
        "(pedido_balcao_itens.id_filial = pedido_balcao.id_filial)),0)  " & _
        "AS Produtos,  " & _
        "isnull((SELECT sum(pedido_balcao_servicos.quant *  " & _
        "(pedido_balcao_servicos.preco - pedido_balcao_servicos.preco *  " & _
        "(pedido_balcao_servicos.desconto / 100))) AS total  " & _
        "FROM pedido_balcao_servicos INNER JOIN  " & _
        "produtos ON pedido_balcao_servicos.cod_servico = produtos.cod_produto  " & _
        "WHERE (pedido_balcao_servicos.num_pedido = pedido_balcao.num_pedido) AND  " & _
        "(pedido_balcao_servicos.id_filial = pedido_balcao.id_filial)),0)  " & _
        "as servicos,  " & _
        "(isnull((SELECT sum(pedido_balcao_itens.quant *  " & _
        "(pedido_balcao_itens.preco - pedido_balcao_itens.preco *  " & _
        "(pedido_balcao_itens.desconto / 100))) AS total  " & _
        "FROM pedido_balcao_itens INNER JOIN  " & _
        "produtos ON pedido_balcao_itens.cod_produto = produtos.cod_produto  " & _
        "WHERE (pedido_balcao_itens.num_pedido = pedido_balcao.num_pedido) AND  " & _
        "(pedido_balcao_itens.id_filial = pedido_balcao.id_filial)),0)  " & _
        "+  " & _
        "isnull((SELECT sum(pedido_balcao_servicos.quant *  " & _
        "(pedido_balcao_servicos.preco - pedido_balcao_servicos.preco *  " & _
        "(pedido_balcao_servicos.desconto / 100)))  " & _
        "AS total  " & _
        "FROM pedido_balcao_servicos INNER JOIN  " & _
        "produtos ON pedido_balcao_servicos.cod_servico = produtos.cod_produto  " & _
        "WHERE (pedido_balcao_servicos.num_pedido = pedido_balcao.num_pedido) AND  " & _
        "(pedido_balcao_servicos.id_filial = pedido_balcao.id_filial)),0))  " & _
        "as Total    " & _
        "FROM pedido_balcao INNER JOIN  " & _
        "status_pedido ON pedido_balcao.cod_status_pedido =  " & _
        "status_pedido.cod_status_pedido INNER JOIN  " & _
        "Usuarios ON pedido_balcao.cod_vendedor = Usuarios.cod_usuario  " & _
        "WHERE (pedido_balcao.cod_filial_cliente =" & x_cod_filial_cliente & ") AND " & _
        "(pedido_balcao.cod_cliente = " & x_cod_cliente & ")" & _
        " ORDER BY pedido_balcao.data_pedido Desc"
        d.carrega_Tabela(sql, tb)
        grdPedidos.DataSource = tb
        formata_grid()
    End Sub
    Private Sub formata_grid()
        Dim TStb As New DataGridTableStyle
        TStb.MappingName = grdPedidos.DataSource.tablename
        Dim cFilial As New DataGridTextBoxColumn
        With cFilial
            .MappingName = "id_filial"
            .HeaderText = "Filial"
            .Width = 30
        End With
        TStb.GridColumnStyles.Add(cFilial)
        Dim cNum As New DataGridTextBoxColumn
        With cNum
            .MappingName = "num_Pedido"
            .HeaderText = "Pedido"
        End With
        TStb.GridColumnStyles.Add(cNum)

        Dim cData As New DataGridTextBoxColumn
        With cData
            .MappingName = "data_pedido"
            .HeaderText = "data"
            .Width = 100
        End With
        TStb.GridColumnStyles.Add(cData)
        Dim cStatus As New DataGridTextBoxColumn
        With cStatus
            .MappingName = "status_pedido"
            .HeaderText = "Status"
            .Width = 130
        End With
        TStb.GridColumnStyles.Add(cStatus)
        Dim cVend As New DataGridTextBoxColumn
        With cVend
            .MappingName = "nome"
            .HeaderText = "vendedor(a)"
            .Width = 130
        End With
        TStb.GridColumnStyles.Add(cVend)

        Dim cFaturado As New DataGridBoolColumn
        With cFaturado
            cFaturado.TrueValue = 1
            cFaturado.FalseValue = 0
            .MappingName = "faturado"
            .HeaderText = "Faturado"
            .Width = 50
        End With
        TStb.GridColumnStyles.Add(cFaturado)
        Dim ctotal As New DataGridTextBoxColumn
        With ctotal
            .MappingName = "total"
            .HeaderText = "Total"
            .Format = "R$#,##0.00"
        End With
        TStb.GridColumnStyles.Add(ctotal)
        grdPedidos.TableStyles.Clear()
        grdPedidos.TableStyles.Add(TStb)
    End Sub
    Private Sub grdPedidos_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdPedidos.CurrentCellChanged
        Try
            id = grdPedidos.CurrentRowIndex
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Try
            Dim i, m As Integer
            Dim r As DataRow
            Cria_tabela()
            i = 0
            m = tb.Rows.Count
            While i < m
                If grdPedidos.IsSelected(i) = True Then
                    r = ttRes.NewRow
                    r("id_filial") = tb.Rows(i)("id_filial")
                    r("num_pedido") = tb.Rows(i)("num_pedido")
                    r("cod_status_pedido") = tb.Rows(i)("cod_status_pedido")
                    r("faturado") = tb.Rows(i)("faturado")
                    ttRes.Rows.Add(r)
                End If
                i = i + 1
            End While
        Catch ex As Exception

        End Try
        Me.Close()
    End Sub

End Class