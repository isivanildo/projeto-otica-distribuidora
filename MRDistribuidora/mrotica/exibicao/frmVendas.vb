Imports System.Data
Imports System.Data.SqlClient
Imports mrotica_util

Public Class frmVendas
    Dim d As New dados
    Dim conf As New config
    Dim intFornecedor As Integer
    Dim tbComissao As New DataTable

    Private Sub btnOk_Click(sender As System.Object, e As System.EventArgs) Handles btnOk.Click
        Dim f As New frmRpt
        Dim r As New rptVendas
        Dim strSQL As String = ""
        Dim dtInicial As DateTime = dtIni.Value.ToShortDateString & " 00:00:01"
        Dim dtFinal As DateTime = dtFim.Value.ToShortDateString & " 23:59:59"
        Try
            If rbVendedorExt.Checked = True Then
                strSQL = "select cliente.nome_cliente,  pedido_balcao.num_pedido, pedido_balcao.data_pedido," & _
                "isnull((SELECT sum(pedido_balcao_itens.quant *  (pedido_balcao_itens.preco - pedido_balcao_itens.preco *  (pedido_balcao_itens.desconto / 100))) AS total  " & _
                "FROM pedido_balcao_itens INNER JOIN  produtos ON pedido_balcao_itens.cod_produto = produtos.cod_produto WHERE (pedido_balcao_itens.num_pedido = pedido_balcao.num_pedido) AND " & _
                "(pedido_balcao_itens.id_filial = pedido_balcao.id_filial) AND NOT (Pedido_balcao_itens.cod_status_item in (4,5))),0)  AS produtos," & _
                "isnull((SELECT sum(pedido_balcao_servicos.quant *  (pedido_balcao_servicos.preco - pedido_balcao_servicos.preco * " & _
                "(pedido_balcao_servicos.desconto / 100))) AS total  FROM pedido_balcao_servicos INNER JOIN  produtos ON pedido_balcao_servicos.cod_servico = produtos.cod_produto " & _
                "WHERE (pedido_balcao_servicos.num_pedido = pedido_balcao.num_pedido) AND (pedido_balcao_servicos.id_filial = pedido_balcao.id_filial) and pedido_balcao_servicos.cod_status_servico = 1),0)  as servicos, " & _
                "(isnull((SELECT sum(pedido_balcao_itens.quant * (pedido_balcao_itens.preco - pedido_balcao_itens.preco *  (pedido_balcao_itens.desconto / 100))) AS total " & _
                "FROM pedido_balcao_itens INNER JOIN  produtos ON pedido_balcao_itens.cod_produto = produtos.cod_produto " & _
                "WHERE (pedido_balcao_itens.num_pedido = pedido_balcao.num_pedido) AND " & _
                "(pedido_balcao_itens.id_filial = pedido_balcao.id_filial) AND NOT (Pedido_balcao_itens.cod_status_item in (4,5))),0) + " & _
                "isnull((SELECT sum(pedido_balcao_servicos.quant *  (pedido_balcao_servicos.preco - pedido_balcao_servicos.preco * " & _
                "(pedido_balcao_servicos.desconto / 100))) AS total  FROM pedido_balcao_servicos INNER JOIN  produtos ON pedido_balcao_servicos.cod_servico = produtos.cod_produto " & _
                "WHERE (pedido_balcao_servicos.num_pedido = pedido_balcao.num_pedido) AND (pedido_balcao_servicos.id_filial = pedido_balcao.id_filial) and pedido_balcao_servicos.cod_status_servico = 1),0)) as total, " & _
                "isnull(os.cod_os,0) as os, Usuarios.NOME from pedido_balcao inner join cliente on pedido_balcao.cod_cliente = cliente.cod_cliente " & _
                "left join OS on os.num_pedido = pedido_balcao.num_pedido inner join Usuarios on Usuarios.cod_usuario = pedido_balcao.cod_vendedor_ext " & _
                "inner join fatura_itens on fatura_itens.num_pedido = pedido_balcao.num_pedido " & _
                "inner join fatura on fatura.cod_fatura = fatura_itens.cod_fatura " & _
                "where fatura.data_lancamento >= " & d.pdtm(dtInicial) & " and fatura.data_lancamento <= " & d.pdtm(dtFinal) & _
                " and pedido_balcao.cod_vendedor_ext = " & cbVendedor.SelectedValue & _
                " and (isnull((SELECT sum(pedido_balcao_itens.quant *  (pedido_balcao_itens.preco - pedido_balcao_itens.preco * " & _
                "(pedido_balcao_itens.desconto / 100))) AS total  FROM pedido_balcao_itens INNER JOIN  produtos ON " & _
                "pedido_balcao_itens.cod_produto = produtos.cod_produto  WHERE (pedido_balcao_itens.num_pedido = pedido_balcao.num_pedido) AND " & _
                "(pedido_balcao_itens.id_filial = pedido_balcao.id_filial) AND NOT (Pedido_balcao_itens.cod_status_item in (4,5))),0) + " & _
                "isnull((SELECT sum(pedido_balcao_servicos.quant *  (pedido_balcao_servicos.preco - pedido_balcao_servicos.preco *  " & _
                "(pedido_balcao_servicos.desconto / 100))) AS total  FROM pedido_balcao_servicos INNER JOIN  produtos ON " & _
                "pedido_balcao_servicos.cod_servico = produtos.cod_produto WHERE (pedido_balcao_servicos.num_pedido = pedido_balcao.num_pedido) AND " & _
                "(pedido_balcao_servicos.id_filial = pedido_balcao.id_filial) and pedido_balcao_servicos.cod_status_servico = 1),0)) > 0 " & _
                "group by cliente.nome_cliente,pedido_balcao.num_pedido, pedido_balcao.data_pedido, pedido_balcao.id_filial, OS.cod_os, Usuarios.NOME"


                r.Label3.Text = "Relatório de Vendas referente ao período de " & dtIni.Text & " à " & dtFim.Text
                r.GroupHeader1.Height = 0.0
                r.Label5.Visible = False
                r.perc = CDbl(tbComissao.Rows(0)("comissao_vend_ext").ToString)
            End If

            If rbVendedorInt.Checked = True Then
                strSQL = "select cliente.nome_cliente,  pedido_balcao.num_pedido, pedido_balcao.data_pedido," & _
                "isnull((SELECT sum(pedido_balcao_itens.quant *  (pedido_balcao_itens.preco - pedido_balcao_itens.preco *  (pedido_balcao_itens.desconto / 100))) AS total  " & _
                "FROM pedido_balcao_itens INNER JOIN  produtos ON pedido_balcao_itens.cod_produto = produtos.cod_produto WHERE (pedido_balcao_itens.num_pedido = pedido_balcao.num_pedido) AND " & _
                "(pedido_balcao_itens.id_filial = pedido_balcao.id_filial) AND NOT (Pedido_balcao_itens.cod_status_item in (4,5))),0)  AS produtos," & _
                "isnull((SELECT sum(pedido_balcao_servicos.quant *  (pedido_balcao_servicos.preco - pedido_balcao_servicos.preco * " & _
                "(pedido_balcao_servicos.desconto / 100))) AS total  FROM pedido_balcao_servicos INNER JOIN  produtos ON pedido_balcao_servicos.cod_servico = produtos.cod_produto " & _
                "WHERE (pedido_balcao_servicos.num_pedido = pedido_balcao.num_pedido) AND (pedido_balcao_servicos.id_filial = pedido_balcao.id_filial) and pedido_balcao_servicos.cod_status_servico = 1),0)  as servicos, " & _
                "(isnull((SELECT sum(pedido_balcao_itens.quant * (pedido_balcao_itens.preco - pedido_balcao_itens.preco *  (pedido_balcao_itens.desconto / 100))) AS total " & _
                "FROM pedido_balcao_itens INNER JOIN  produtos ON pedido_balcao_itens.cod_produto = produtos.cod_produto " & _
                "WHERE (pedido_balcao_itens.num_pedido = pedido_balcao.num_pedido) AND " & _
                "(pedido_balcao_itens.id_filial = pedido_balcao.id_filial) AND NOT (Pedido_balcao_itens.cod_status_item in (4,5))),0) + " & _
                "isnull((SELECT sum(pedido_balcao_servicos.quant *  (pedido_balcao_servicos.preco - pedido_balcao_servicos.preco * " & _
                "(pedido_balcao_servicos.desconto / 100))) AS total  FROM pedido_balcao_servicos INNER JOIN  produtos ON pedido_balcao_servicos.cod_servico = produtos.cod_produto " & _
                "WHERE (pedido_balcao_servicos.num_pedido = pedido_balcao.num_pedido) AND (pedido_balcao_servicos.id_filial = pedido_balcao.id_filial) and pedido_balcao_servicos.cod_status_servico = 1),0)) as total, " & _
                "isnull(os.cod_os,0) as os, Usuarios.NOME from pedido_balcao inner join cliente on pedido_balcao.cod_cliente = cliente.cod_cliente " & _
                "left join OS on os.num_pedido = pedido_balcao.num_pedido inner join Usuarios on Usuarios.cod_usuario = pedido_balcao.cod_vendedor " & _
                "inner join fatura_itens on fatura_itens.num_pedido = pedido_balcao.num_pedido " & _
                "inner join fatura on fatura.cod_fatura = fatura_itens.cod_fatura " & _
                "where fatura.data_lancamento >= " & d.pdtm(dtInicial) & " and fatura.data_lancamento <= " & d.pdtm(dtFinal) & _
                " and pedido_balcao.cod_vendedor = " & cbVendedor.SelectedValue & _
                " and (isnull((SELECT sum(pedido_balcao_itens.quant *  (pedido_balcao_itens.preco - pedido_balcao_itens.preco * " & _
                "(pedido_balcao_itens.desconto / 100))) AS total  FROM pedido_balcao_itens INNER JOIN  produtos ON " & _
                "pedido_balcao_itens.cod_produto = produtos.cod_produto  WHERE (pedido_balcao_itens.num_pedido = pedido_balcao.num_pedido) AND " & _
                "(pedido_balcao_itens.id_filial = pedido_balcao.id_filial) AND NOT (Pedido_balcao_itens.cod_status_item in (4,5))),0) + " & _
                "isnull((SELECT sum(pedido_balcao_servicos.quant *  (pedido_balcao_servicos.preco - pedido_balcao_servicos.preco *  " & _
                "(pedido_balcao_servicos.desconto / 100))) AS total  FROM pedido_balcao_servicos INNER JOIN  produtos ON " & _
                "pedido_balcao_servicos.cod_servico = produtos.cod_produto WHERE (pedido_balcao_servicos.num_pedido = pedido_balcao.num_pedido) AND " & _
                "(pedido_balcao_servicos.id_filial = pedido_balcao.id_filial) and pedido_balcao_servicos.cod_status_servico = 1),0)) > 0 " & _
                "group by cliente.nome_cliente,pedido_balcao.num_pedido, pedido_balcao.data_pedido, pedido_balcao.id_filial, OS.cod_os, Usuarios.NOME"

                r.Label3.Text = "Relatório de Vendas referente ao período de " & dtIni.Text & " à " & dtFim.Text
                r.GroupHeader1.Height = 0.0
                r.Label5.Visible = False
                r.perc = CDbl(tbComissao.Rows(0)("comissao_vend_int").ToString)
            End If

            d.conecta()
            Dim da As New SqlDataAdapter(strSQL, d.con)
            Dim ds As New DataSet
            da.Fill(ds, "Vendas")

            If ds.Tables(0).Rows.Count > 0 Then
                r.DataSource = ds.Tables(0)
            Else
                MessageBox.Show("Não há registro a ser exibido.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            r.TextBox5.Text = ds.Tables(0).Rows.Count
            f.Relat(r)
            f.ShowDialog()
            f.Dispose()
            d.desconecta()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnSair_Click(sender As System.Object, e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub frmVendas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        carregacombo()
        carregaComissao()
    End Sub

    Private Sub carregacombo()
        Dim strSQL As String = "select cod_usuario, nome from usuarios where cod_tipo_usuario = 2"
        d.conecta()
        Dim da As New SqlDataAdapter(strSQL, d.con)
        Dim ds As New DataSet
        da.Fill(ds, "Vendedores")
        cbVendedor.ValueMember = "cod_usuario"
        cbVendedor.DisplayMember = "nome"
        cbVendedor.DataSource = ds.Tables(0)
        d.desconecta()
    End Sub

    Private Sub carregaComissao()
        Dim strSQL As String = "select comissao_vend_ext, comissao_vend_int from controle"
        d.conecta()
        Dim da As New SqlDataAdapter(strSQL, d.con)
        Dim ds As New DataSet
        da.Fill(ds, "Comissao")
        tbComissao = ds.Tables(0)
        d.desconecta()
    End Sub
End Class