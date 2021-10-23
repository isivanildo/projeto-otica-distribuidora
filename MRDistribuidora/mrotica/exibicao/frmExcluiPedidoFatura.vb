Imports System.Data
Imports System.Data.SqlClient
Imports mrotica_util

Public Class frmExcluiPedidoFatura
    Public intFatura As Integer
    Public intFilial As Integer
    Public intCodCliente As Integer
    Dim d As New dados
    Dim fatura As New objFatura

    Private Sub exclui_item_fatura(ByVal item As Integer, ByVal pedido As Integer, ByVal filial As Integer)
        Dim strSQL As String = "delete from fatura_itens where item = " & item & " and num_pedido = " & pedido & " and id_filial = " & filial
        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            cmd.ExecuteNonQuery()
            d.ComandoSQL(strSQL, True)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            d.desconecta()
        End Try
    End Sub

    Private Sub atualiza_status_pedido(ByVal pedido As Integer, ByVal filial As Integer)
        Dim strSQL As String = "update pedido_balcao set cod_status_pedido = 1 where num_pedido = " & pedido & " and id_filial = " & filial
        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            cmd.ExecuteNonQuery()
            d.ComandoSQL(strSQL, True)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            d.desconecta()
        End Try
    End Sub

    Private Function retornaRegistro(ByVal fatura As Integer, ByVal filial As Integer) As Boolean
        Try
            Dim resultado As Boolean
            resultado = False
            Dim strSQL As String = "SELECT 1 FROM BOLETO INNER JOIN LANCAMENTOS " & _
                "ON BOLETO.cod_lancamento = LANCAMENTOS.cod_lancamento AND BOLETO.id_filial = LANCAMENTOS.id_filial " & _
                "WHERE BOLETO.DOCUMENTO = " & fatura & " AND BOLETO.ID_FILIAL = " & filial & " AND LANCAMENTOS.cod_status_lancamento = 1"
            d.conecta()
            Dim da As New SqlDataAdapter(strSQL, d.con)
            Dim ds As New DataSet
            da.Fill(ds, "Cliente")
            d.desconecta()
            If ds.Tables(0).Rows.Count > 0 Then
                resultado = True
            End If
            Return resultado
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function

    Friend Sub caixa()
        grdPedidoItem.Columns.Clear()
        grdPedidoItem.DataSource = Nothing

        Dim strSQL As String = "SELECT fatura_itens.*, " & _
        "isnull((SELECT sum(pedido_balcao_itens.quant * " & _
        "(pedido_balcao_itens.preco - pedido_balcao_itens.preco * " & _
        "(pedido_balcao_itens.desconto / 100))) AS total " & _
        "FROM pedido_balcao_itens INNER JOIN " & _
        "produtos ON pedido_balcao_itens.cod_produto = produtos.cod_produto " & _
        "WHERE (pedido_balcao_itens.num_pedido = fatura_itens.num_pedido) AND " & _
        "(pedido_balcao_itens.id_filial = fatura_itens.id_filial_pedido)),0) " & _
        "AS Produtos, " & _
        "isnull((SELECT sum(pedido_balcao_servicos.quant * " & _
        "(pedido_balcao_servicos.preco - pedido_balcao_servicos.preco * " & _
        "(pedido_balcao_servicos.desconto / 100))) AS total " & _
        "FROM pedido_balcao_servicos INNER JOIN " & _
        "produtos ON pedido_balcao_servicos.cod_servico = produtos.cod_produto " & _
        "WHERE (pedido_balcao_servicos.num_pedido = fatura_itens.num_pedido) AND " & _
        "(pedido_balcao_servicos.id_filial = fatura_itens.id_filial_pedido)),0) " & _
        "as servicos, " & _
        "(isnull((SELECT sum(pedido_balcao_itens.quant * " & _
        "(pedido_balcao_itens.preco - pedido_balcao_itens.preco * " & _
        "(pedido_balcao_itens.desconto / 100))) AS total " & _
        "FROM pedido_balcao_itens INNER JOIN " & _
        "produtos ON pedido_balcao_itens.cod_produto = produtos.cod_produto " & _
        "WHERE (pedido_balcao_itens.num_pedido = fatura_itens.num_pedido) AND " & _
        "(pedido_balcao_itens.id_filial = fatura_itens.id_filial_pedido)),0) " & _
        "+ " & _
        "isnull((SELECT sum(pedido_balcao_servicos.quant * " & _
        "(pedido_balcao_servicos.preco - pedido_balcao_servicos.preco * " & _
        "(pedido_balcao_servicos.desconto / 100))) " & _
        "AS total " & _
        "FROM pedido_balcao_servicos INNER JOIN " & _
        "produtos ON pedido_balcao_servicos.cod_servico = produtos.cod_produto " & _
        "WHERE (pedido_balcao_servicos.num_pedido = fatura_itens.num_pedido) AND " & _
        "(pedido_balcao_servicos.id_filial = fatura_itens.id_filial_pedido)),0)) " & _
        "as Total " & _
        ",(SELECT pedido_balcao.data_pedido FROM pedido_balcao " & _
        " where pedido_balcao.num_pedido = fatura_itens.num_pedido " & _
        "AND pedido_balcao.id_filial = fatura_itens.id_filial_pedido) as data_pedido " & _
        "FROM  fatura_itens " & _
        "where fatura_itens.cod_fatura =  " & intFatura & _
        " and fatura_itens.id_filial = " & intFilial & " ORDER BY fatura_itens.item"

        grdPedidoItem.AutoGenerateColumns = False
        grdPedidoItem.AllowUserToAddRows = False
        grdPedidoItem.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        Dim item As New DataGridViewTextBoxColumn
        item.HeaderText = "Item"
        item.Width = 40
        item.DataPropertyName = "Item"
        item.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdPedidoItem.Columns.Add(item)

        Dim selecao As New DataGridViewCheckBoxColumn
        selecao.HeaderText = "Selecionar"
        selecao.Width = 70
        grdPedidoItem.Columns.Add(selecao)

        Dim pedido As New DataGridViewTextBoxColumn
        pedido.HeaderText = "Pedido"
        pedido.Width = 70
        pedido.DataPropertyName = "num_pedido"
        pedido.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdPedidoItem.Columns.Add(pedido)

        Dim datapedido As New DataGridViewTextBoxColumn
        datapedido.HeaderText = "Data Pedido"
        datapedido.Width = 90
        datapedido.DataPropertyName = "data_pedido"
        datapedido.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        datapedido.DefaultCellStyle.Format = "dd/MM/yyyy"
        grdPedidoItem.Columns.Add(datapedido)

        Dim produtos As New DataGridViewTextBoxColumn
        produtos.HeaderText = "Produtos"
        produtos.Width = 80
        produtos.DataPropertyName = "Produtos"
        produtos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        produtos.DefaultCellStyle.Format = "#,##0.00"
        grdPedidoItem.Columns.Add(produtos)

        Dim servicos As New DataGridViewTextBoxColumn
        servicos.HeaderText = "Serviços"
        servicos.Width = 80
        servicos.DataPropertyName = "servicos"
        servicos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        servicos.DefaultCellStyle.Format = "#,##0.00"
        grdPedidoItem.Columns.Add(servicos)

        Dim total As New DataGridViewTextBoxColumn
        total.HeaderText = "Total"
        total.Width = 80
        total.DataPropertyName = "total"
        total.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        total.DefaultCellStyle.Format = "#,##0.00"
        grdPedidoItem.Columns.Add(total)

        Try
            d.conecta()
            Dim da As New SqlDataAdapter(strSQL, d.con)
            Dim ds As New DataSet
            da.Fill(ds, "Fatura")
            d.desconecta()
            grdPedidoItem.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnExcluiPedido_Click(sender As System.Object, e As System.EventArgs) Handles btnExcluiPedido.Click
        If MessageBox.Show("Deseja excluir o pedido de dentro da fatura?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            For Each linha As DataGridViewRow In grdPedidoItem.Rows
                If linha.Cells(1).Value = True Then
                    atualiza_status_pedido(linha.Cells(2).Value, intFilial)
                    exclui_item_fatura(linha.Cells(0).Value, linha.Cells(2).Value, intFilial)
                End If
            Next
            MessageBox.Show("Pedido excluído com sucesso na fatura.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Operação cancelada com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        caixa()
    End Sub

    Friend Sub gerencia()
        grdPedidoItem.Columns.Clear()
        grdPedidoItem.DataSource = Nothing

        Dim strSQL As String = "SELECT * FROM faturamento_mensal() " & _
       "WHERE cod_cliente = " & intCodCliente & _
       " AND cod_status_pedido IN (1,2) AND Total > 0 AND Faturado = 0 AND id_filial = " & intFilial & _
       " ORDER BY data_pedido Desc"

        grdPedidoItem.AutoGenerateColumns = False
        grdPedidoItem.AllowUserToAddRows = False
        grdPedidoItem.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        Dim codfilial As New DataGridViewTextBoxColumn
        codfilial.HeaderText = "Filial"
        codfilial.Width = 40
        codfilial.DataPropertyName = "id_filial"
        codfilial.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdPedidoItem.Columns.Add(codfilial)

        Dim selecao As New DataGridViewCheckBoxColumn
        selecao.HeaderText = "Faturado"
        selecao.Width = 55
        grdPedidoItem.Columns.Add(selecao)

        Dim pedido As New DataGridViewTextBoxColumn
        pedido.HeaderText = "Pedido"
        pedido.Width = 55
        pedido.DataPropertyName = "num_pedido"
        pedido.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdPedidoItem.Columns.Add(pedido)

        Dim datapedido As New DataGridViewTextBoxColumn
        datapedido.HeaderText = "Data Pedido"
        datapedido.Width = 90
        datapedido.DataPropertyName = "data_pedido"
        datapedido.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        datapedido.DefaultCellStyle.Format = "dd/MM/yyyy"
        grdPedidoItem.Columns.Add(datapedido)

        Dim cliente As New DataGridViewTextBoxColumn
        cliente.HeaderText = "Cliente"
        cliente.Width = 250
        cliente.DataPropertyName = "nome_cliente"
        grdPedidoItem.Columns.Add(cliente)

        Dim statuspedido As New DataGridViewTextBoxColumn
        statuspedido.HeaderText = "Status Pedido"
        statuspedido.Width = 150
        statuspedido.DataPropertyName = "status_pedido"
        statuspedido.Visible = False
        grdPedidoItem.Columns.Add(statuspedido)

        Dim produtos As New DataGridViewTextBoxColumn
        produtos.HeaderText = "Produtos"
        produtos.Width = 70
        produtos.DataPropertyName = "Produtos"
        produtos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        produtos.DefaultCellStyle.Format = "#,##0.00"
        grdPedidoItem.Columns.Add(produtos)

        Dim servicos As New DataGridViewTextBoxColumn
        servicos.HeaderText = "Serviços"
        servicos.Width = 70
        servicos.DataPropertyName = "servicos"
        servicos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        servicos.DefaultCellStyle.Format = "#,##0.00"
        grdPedidoItem.Columns.Add(servicos)

        Dim total As New DataGridViewTextBoxColumn
        total.HeaderText = "Total"
        total.Width = 70
        total.DataPropertyName = "total"
        total.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        total.DefaultCellStyle.Format = "#,##0.00"
        grdPedidoItem.Columns.Add(total)

        Try
            d.conecta()
            Dim da As New SqlDataAdapter(strSQL, d.con)
            Dim ds As New DataSet
            da.Fill(ds, "FaturaInc")
            d.desconecta()
            grdPedidoItem.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnIncluirPedido_Click(sender As System.Object, e As System.EventArgs) Handles btnIncluirPedido.Click
        If retornaRegistro(intFatura, intFilial) = False Then
            If MessageBox.Show("Deseja inserir o pedido dentro da fatura?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                For Each strItem As DataGridViewRow In grdPedidoItem.Rows
                    If strItem.Cells(1).Value = True Then
                        fatura.cod_fatura = intFatura
                        fatura.id_filial = intFilial
                        fatura.insere_itens_fatura(strItem.Cells(2).Value, strItem.Cells(0).Value)
                    End If
                Next
                MessageBox.Show("Pedido inserido com sucesso na fatura.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Operação cancelada com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Não é possível incluir item na fatura que já tenha boleto cadastrado." & Chr(13) & _
                            "Por favor entrar em contato com a gerência.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        gerencia()
    End Sub


    Private Sub grdPedidoItem_CellValueChanged(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdPedidoItem.CellValueChanged
        If grdPedidoItem.Rows(e.RowIndex).Cells(1).Value = True Then
            grdPedidoItem.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Red
            grdPedidoItem.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.White
        End If
    End Sub

    Private Sub rbExcluir_Click(sender As System.Object, e As System.EventArgs) Handles rbExcluir.Click
        If rbExcluir.Checked = True Then
            btnIncluirPedido.Enabled = False
            btnExcluiPedido.Enabled = True
            caixa()
        End If
    End Sub

    Private Sub rbAdicionar_Click(sender As System.Object, e As System.EventArgs) Handles rbAdicionar.Click
        If rbAdicionar.Checked = True Then
            btnExcluiPedido.Enabled = False
            btnIncluirPedido.Enabled = True
            gerencia()
        End If
    End Sub

End Class