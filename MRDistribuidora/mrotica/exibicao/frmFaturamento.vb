Imports System.Data
Imports System.Data.SqlClient
Imports mrotica_util
Public Class frmFaturamento
    Dim tb_produtos As New DataTable
    Dim d As New dados
    Dim total As Double = 0
    Dim str_load As String = "\" 'Caractere para status
    Dim ini_time As Date
    Dim cliente As New objCliente
    Public pusuario As Integer
    Dim xlsExport As New DataDynamics.ActiveReports.Export.Xls.XlsExport
    Dim promotor As New objMaster
    Private Sub frmFaturamento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'tb_produtos = monta_tabela_produto()
        combos()
    End Sub
    Private Function monta_tabela_produto() As DataTable
        Dim tb As New DataTable
        tb.Columns.Add("cod_tabela")
        tb.Columns.Add("Tipo")
        tb.Columns.Add("nome")
        tb.Columns.Add("preco_compra")
        tb.Columns.Add("extras")
        tb.Columns.Add("pedidos")
        tb.Columns.Add("venda_pedidos")
        tb.Columns.Add("OS")
        tb.Columns.Add("venda_os")
        tb.Columns.Add("totalItens")
        tb.Columns.Add("totalCompra")
        tb.Columns.Add("totalVenda")
        tb.Columns.Add("diferenca")
        tb.Columns.Add("porcTotal")
        tb.Columns.Add("fabricante")
        Return tb
    End Function
    Private Function monta_tabela_produto_clientes() As DataTable
        Dim tb As New DataTable
        tb.Columns.Add("cod_tabela")
        tb.Columns.Add("Tipo")
        tb.Columns.Add("nome")
        tb.Columns.Add("preco_compra")
        tb.Columns.Add("extras")
        tb.Columns.Add("pedidos")
        tb.Columns.Add("venda_pedidos")
        tb.Columns.Add("OS")
        tb.Columns.Add("venda_os")
        tb.Columns.Add("totalItens")
        tb.Columns.Add("totalCompra")
        tb.Columns.Add("totalVenda")
        tb.Columns.Add("diferenca")
        tb.Columns.Add("porcTotal")
        tb.Columns.Add("fabricante")
        tb.Columns.Add("cliente")
        Return tb
    End Function
    Private Sub processa_produto(ByVal r As DataRow)
        Dim cod_tabela, extras, pedidos, os, totalItens As Integer
        Dim nome As String
        Dim preco_compra, venda_pedidos, venda_os, totalcompra, totalvenda, diferenca, porcTotal, fabricante As Double
        Dim rn As DataRow
        cod_tabela = r("cod_tabela")
        nome = r("nome_comercial")
        preco_compra = rdNum(r("pdesc"))
        extras = rdNum(r("extras"))
        pedidos = rdNum(r("pedidos"))
        venda_pedidos = rdNum(r("pedidosfin"))
        os = rdNum(r("os"))
        venda_os = rdNum(r("osfin"))
        totalItens = extras + pedidos + os
        totalcompra = totalItens * preco_compra
        totalvenda = venda_pedidos + venda_os
        If totalvenda < 0 Then
            MsgBox(nome & vbTab & venda_pedidos & vbTab & venda_os)
        End If
        diferenca = totalvenda - totalcompra
        porcTotal = 0
        fabricante = rdNum(r("id_fabricante"))
        If extras = Nothing And pedidos = Nothing And os = Nothing Then
            Exit Sub
        End If
        rn = tb_produtos.NewRow
        rn("cod_tabela") = cod_tabela
        rn("Tipo") = "Produtos"
        rn("nome") = nome
        rn("preco_compra") = wrNum(preco_compra)
        rn("extras") = wrNum(extras)
        rn("pedidos") = wrNum(pedidos)
        rn("venda_pedidos") = wrNum(venda_pedidos)
        rn("os") = wrNum(os)
        rn("venda_os") = wrNum(venda_os)
        rn("totalItens") = wrNum(totalItens)
        rn("totalcompra") = wrNum(totalcompra)
        rn("totalvenda") = wrNum(totalvenda)
        total = total + rdNum(totalvenda)
        rn("diferenca") = wrNum(diferenca)
        rn("porctotal") = wrNum(porcTotal)
        rn("fabricante") = wrNum(fabricante)
        tb_produtos.Rows.Add(rn)
    End Sub
    Private Sub processa_servico(ByVal r As DataRow)
        Dim cod_tabela, extras, pedidos, os, totalItens As Integer
        Dim nome As String
        Dim preco_compra, venda_pedidos, venda_os, totalcompra, totalvenda, diferenca, porcTotal As Double
        Dim rn As DataRow
        cod_tabela = 0
        nome = r("produto")
        preco_compra = rdNum(r("custo"))
        extras = 0
        pedidos = 0
        venda_pedidos = 0
        os = rdNum(r("quantidade"))
        venda_os = rdNum(r("venda"))
        totalItens = extras + pedidos + os
        totalcompra = totalItens * preco_compra
        totalvenda = venda_pedidos + venda_os
        diferenca = totalvenda - totalcompra
        porcTotal = 0
        If extras = Nothing And pedidos = Nothing And os = Nothing Then
            Exit Sub
        End If
        rn = tb_produtos.NewRow
        rn("cod_tabela") = cod_tabela
        rn("Tipo") = "Servicos"
        rn("nome") = nome
        rn("preco_compra") = wrNum(preco_compra)
        rn("extras") = wrNum(extras)
        rn("pedidos") = wrNum(pedidos)
        rn("venda_pedidos") = wrNum(venda_pedidos)
        rn("os") = wrNum(os)
        rn("venda_os") = wrNum(venda_os)
        rn("totalItens") = wrNum(totalItens)
        rn("totalcompra") = wrNum(totalcompra)
        rn("totalvenda") = wrNum(totalvenda)
        total = total + rdNum(totalvenda)
        rn("diferenca") = wrNum(diferenca)
        rn("porctotal") = wrNum(porcTotal)
        tb_produtos.Rows.Add(rn)
    End Sub
    Private Function carrega_produtos() As DataTable
        Dim sql As String
        Dim tt As New DataTable
        Dim di, df As Date
        Me.Cursor = Cursors.WaitCursor
        di = dtIni.Value.Date & " 00:00:00"
        df = dtFim.Value.Date & " 23:59:59"
        sql = "SELECT     cod_tabela, nome_comercial, id_fabricante, Extras, pdesc, Pedidos, pedidosFin, OS, OSFin " & _
        "FROM  dbo.faturamento_produtos(" & d.pdtm(di) & "," & d.pdtm(df) & ") AS faturamento_produtos_1 " & _
        "where (cod_tabela <> 2 And cod_tabela <> 0 And cod_tabela <> 1 And id_fabricante <> 99) " & _
        " ORDER BY id_fabricante, nome_comercial"
        d.carrega_Tabela(sql, tt)
        Me.Cursor = Cursors.Default
        Return tt
    End Function
    Private Function carrega_produtos_cliente(ByVal X_Cod_cliente As Integer) As DataTable
        Dim sql As String
        Dim tt As New DataTable
        Dim di, df As Date
        Me.Cursor = Cursors.AppStarting
        di = dtIni.Value.Date & " 00:00:00"
        df = dtFim.Value.Date & " 23:59:59"
        sql = "SELECT     cod_tabela, nome_comercial, id_fabricante, Extras, pdesc, Pedidos, pedidosFin, OS, OSFin " & _
        "FROM  dbo.faturamento_produtos_cliente(" & d.pdtm(di) & "," & d.pdtm(df) & "," & _
        X_Cod_cliente & ") AS faturamento_produtos_1 " & _
        "where (cod_tabela <> 2 And cod_tabela <> 0 And cod_tabela <> 1 And id_fabricante <> 99) " & _
        " ORDER BY id_fabricante, nome_comercial"
        d.carrega_Tabela(sql, tt)
        Me.Cursor = Cursors.Default
        Return tt
    End Function
    Private Function carrega_produtos_anamaria() As DataTable
        Dim sql As String
        Dim tt As New DataTable
        Dim di, df As Date
        di = dtIni.Value.Date & " 00:00:00"
        df = dtFim.Value.Date & " 23:59:59"
        sql = "SELECT nome_comercial,lentes_tabela.id_fabricante, cod_tabela, Preco_compra, desconto_compra, " & _
        "(preco_compra -(preco_compra*(desconto_compra/100))) as pdesc, " & _
        "(SELECT SUM(movimento.quant)*-1 " & _
        "FROM  movimento INNER JOIN " & _
        "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
        "movimento.id_filial = movimentomaster.id_filial INNER JOIN " & _
        "saida_extra ON movimentomaster.cod_movimento = saida_extra.cod_movimento AND " & _
        "movimentomaster.id_filial = saida_extra.id_filial_movimento INNER JOIN " & _
        "OS ON saida_extra.id_filial = OS.id_filial AND saida_extra.cod_os = OS.cod_os INNER JOIN " & _
        "produtos ON movimento.cod_produto = produtos.cod_produto INNER JOIN " & _
        "lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente AND " & _
        "produtos.id_fabricante = lentes_blocos.id_fabricante " & _
        "WHERE     (lentes_blocos.cod_tabela = lentes_tabela.cod_tabela) and " & _
        "(os.cod_cliente < 1000) and (movimentomaster.data >= " & _
        d.pdtm(di) & ") AND (movimentomaster.data <= " & _
        d.pdtm(df) & ")) as Extras, " & _
        "(SELECT     SUM(movimento.quant) * - 1 FROM lentes_blocos INNER JOIN " & _
        "movimentomaster INNER JOIN movimento ON movimentomaster.cod_movimento = " & _
        "movimento.cod_Movimento AND movimentomaster.id_filial = movimento.id_filial " & _
        "INNER JOIN produtos ON movimento.cod_produto = produtos.cod_produto " & _
        "ON lentes_blocos.cod_lente = produtos.cod_lente AND " & _
        "lentes_blocos.id_fabricante = produtos.id_fabricante INNER JOIN " & _
        "saida_pedido ON movimentomaster.cod_movimento = saida_pedido.cod_movimento AND " & _
        "movimentomaster.id_filial = saida_pedido.id_filial INNER JOIN " & _
        "pedido_balcao ON saida_pedido.num_pedido = pedido_balcao.num_pedido AND " & _
        "saida_pedido.id_filial = pedido_balcao.id_filial WHERE " & _
        "(movimentomaster.data >= " & d.pdtm(di) & ") AND (movimentomaster.data <= " & d.pdtm(df) & _
        ") and (pedido_balcao.cod_cliente < 1000) " & _
        "and (lentes_blocos.cod_tabela = lentes_tabela.cod_tabela)) as pedidos, " & _
        "(SELECT     SUM(movimento.quant*(movimento.pvenda-(movimento.pvenda*(movimento.descvenda/100)))) * - 1 " & _
        "FROM lentes_blocos INNER JOIN movimentomaster INNER JOIN " & _
        "movimento ON movimentomaster.cod_movimento = movimento.cod_Movimento AND movimentomaster.id_filial " & _
        "= movimento.id_filial INNER JOIN produtos ON movimento.cod_produto = produtos.cod_produto " & _
        "ON lentes_blocos.cod_lente = produtos.cod_lente AND " & _
        "lentes_blocos.id_fabricante = produtos.id_fabricante INNER JOIN " & _
        "saida_pedido ON movimentomaster.cod_movimento = saida_pedido.cod_movimento AND " & _
        "movimentomaster.id_filial = saida_pedido.id_filial INNER JOIN " & _
        "pedido_balcao ON saida_pedido.num_pedido = pedido_balcao.num_pedido AND " & _
        "saida_pedido.id_filial = pedido_balcao.id_filial " & _
        "WHERE (movimentomaster.data >= " & d.pdtm(di) & ") AND " & _
        "(movimentomaster.data <= " & d.pdtm(df) & ") and (pedido_balcao.cod_cliente < 1000) " & _
        "and (lentes_blocos.cod_tabela = lentes_tabela.cod_tabela)) as pedidosfin, " & _
        "(SELECT     SUM(movimento.quant) *-1 " & _
        "FROM movimento INNER JOIN movimentomaster ON movimento.cod_Movimento = " & _
        "movimentomaster.cod_movimento AND movimento.id_filial = " & _
        "movimentomaster.id_filial INNER JOIN saida_os ON movimentomaster.cod_movimento = " & _
        "saida_os.cod_movimento AND movimentomaster.id_filial = saida_os.id_filial INNER JOIN " & _
        "OS ON saida_os.id_filial_os = OS.id_filial AND saida_os.cod_os = OS.cod_os INNER JOIN " & _
        "produtos ON movimento.cod_produto = produtos.cod_produto INNER JOIN " & _
        "lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente AND " & _
        "produtos.id_fabricante = lentes_blocos.id_fabricante " & _
        "WHERE     (lentes_blocos.cod_tabela = lentes_tabela.cod_tabela) and " & _
        "(os.cod_cliente < 1000) and (movimentomaster.data >= " & d.pdtm(di) & _
        ") AND (movimentomaster.data <=" & d.pdtm(df) & ")) as OS, " & _
        "(SELECT SUM(movimento.quant*(movimento.pvenda-(movimento.pvenda*(movimento.descvenda/100)))) * - 1 " & _
        "FROM movimento INNER JOIN movimentomaster ON movimento.cod_Movimento = " & _
        "movimentomaster.cod_movimento AND movimento.id_filial = " & _
        "movimentomaster.id_filial INNER JOIN saida_os ON movimentomaster.cod_movimento = " & _
        "saida_os.cod_movimento AND movimentomaster.id_filial = saida_os.id_filial INNER JOIN " & _
        "OS ON saida_os.id_filial_os = OS.id_filial AND saida_os.cod_os = OS.cod_os INNER JOIN " & _
        "produtos ON movimento.cod_produto = produtos.cod_produto INNER JOIN " & _
        "lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente AND " & _
        "produtos.id_fabricante = lentes_blocos.id_fabricante " & _
        "WHERE (lentes_blocos.cod_tabela = lentes_tabela.cod_tabela) and " & _
        "(os.cod_cliente < 1000) and (movimentomaster.data >= " & _
        d.pdtm(di) & ") AND (movimentomaster.data <=" & d.pdtm(df) & ")) as OSfin, fabricante.fabricante " & _
        "FROM lentes_tabela " & _
        "inner join fabricante on lentes_tabela.id_fabricante = fabricante.id_fabricante " & _
        "where (cod_tabela > 2) order by lentes_tabela.id_fabricante,lentes_tabela.nome_comercial"
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function

    Private Function carrega_produtos_anamaria(ByVal codigo As Int32) As DataTable
        Dim sql As String
        Dim tt As New DataTable
        Dim di, df As Date
        di = dtIni.Value.Date & " 00:00:00"
        df = dtFim.Value.Date & " 23:59:59"
        sql = "SELECT nome_comercial,lentes_tabela.id_fabricante, cod_tabela, Preco_compra, desconto_compra, " & _
        "(preco_compra -(preco_compra*(desconto_compra/100))) as pdesc, " & _
        "(SELECT SUM(movimento.quant)*-1 " & _
        "FROM  movimento INNER JOIN " & _
        "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
        "movimento.id_filial = movimentomaster.id_filial INNER JOIN " & _
        "saida_extra ON movimentomaster.cod_movimento = saida_extra.cod_movimento AND " & _
        "movimentomaster.id_filial = saida_extra.id_filial_movimento INNER JOIN " & _
        "OS ON saida_extra.id_filial = OS.id_filial AND saida_extra.cod_os = OS.cod_os INNER JOIN " & _
        "produtos ON movimento.cod_produto = produtos.cod_produto INNER JOIN " & _
        "lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente AND " & _
        "produtos.id_fabricante = lentes_blocos.id_fabricante " & _
        "WHERE     (lentes_blocos.cod_tabela = lentes_tabela.cod_tabela) and " & _
        "(os.cod_cliente = " & codigo & ") and (movimentomaster.data >= " & _
        d.pdtm(di) & ") AND (movimentomaster.data <= " & _
        d.pdtm(df) & ")) as Extras, " & _
        "(SELECT     SUM(movimento.quant) * - 1 FROM lentes_blocos INNER JOIN " & _
        "movimentomaster INNER JOIN movimento ON movimentomaster.cod_movimento = " & _
        "movimento.cod_Movimento AND movimentomaster.id_filial = movimento.id_filial " & _
        "INNER JOIN produtos ON movimento.cod_produto = produtos.cod_produto " & _
        "ON lentes_blocos.cod_lente = produtos.cod_lente AND " & _
        "lentes_blocos.id_fabricante = produtos.id_fabricante INNER JOIN " & _
        "saida_pedido ON movimentomaster.cod_movimento = saida_pedido.cod_movimento AND " & _
        "movimentomaster.id_filial = saida_pedido.id_filial INNER JOIN " & _
        "pedido_balcao ON saida_pedido.num_pedido = pedido_balcao.num_pedido AND " & _
        "saida_pedido.id_filial = pedido_balcao.id_filial WHERE " & _
        "(movimentomaster.data >= " & d.pdtm(di) & ") AND (movimentomaster.data <= " & d.pdtm(df) & _
        ") and (pedido_balcao.cod_cliente = " & codigo & ") " & _
        "and (lentes_blocos.cod_tabela = lentes_tabela.cod_tabela)) as pedidos, " & _
        "(SELECT     SUM(movimento.quant*(movimento.pvenda-(movimento.pvenda*(movimento.descvenda/100)))) * - 1 " & _
        "FROM lentes_blocos INNER JOIN movimentomaster INNER JOIN " & _
        "movimento ON movimentomaster.cod_movimento = movimento.cod_Movimento AND movimentomaster.id_filial " & _
        "= movimento.id_filial INNER JOIN produtos ON movimento.cod_produto = produtos.cod_produto " & _
        "ON lentes_blocos.cod_lente = produtos.cod_lente AND " & _
        "lentes_blocos.id_fabricante = produtos.id_fabricante INNER JOIN " & _
        "saida_pedido ON movimentomaster.cod_movimento = saida_pedido.cod_movimento AND " & _
        "movimentomaster.id_filial = saida_pedido.id_filial INNER JOIN " & _
        "pedido_balcao ON saida_pedido.num_pedido = pedido_balcao.num_pedido AND " & _
        "saida_pedido.id_filial = pedido_balcao.id_filial " & _
        "WHERE (movimentomaster.data >= " & d.pdtm(di) & ") AND " & _
        "(movimentomaster.data <= " & d.pdtm(df) & ") and (pedido_balcao.cod_cliente = " & codigo & ") " & _
        "and (lentes_blocos.cod_tabela = lentes_tabela.cod_tabela)) as pedidosfin, " & _
        "(SELECT     SUM(movimento.quant) *-1 " & _
        "FROM movimento INNER JOIN movimentomaster ON movimento.cod_Movimento = " & _
        "movimentomaster.cod_movimento AND movimento.id_filial = " & _
        "movimentomaster.id_filial INNER JOIN saida_os ON movimentomaster.cod_movimento = " & _
        "saida_os.cod_movimento AND movimentomaster.id_filial = saida_os.id_filial INNER JOIN " & _
        "OS ON saida_os.id_filial_os = OS.id_filial AND saida_os.cod_os = OS.cod_os INNER JOIN " & _
        "produtos ON movimento.cod_produto = produtos.cod_produto INNER JOIN " & _
        "lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente AND " & _
        "produtos.id_fabricante = lentes_blocos.id_fabricante " & _
        "WHERE     (lentes_blocos.cod_tabela = lentes_tabela.cod_tabela) and " & _
        "(os.cod_cliente = " & codigo & ") and (movimentomaster.data >= " & d.pdtm(di) & _
        ") AND (movimentomaster.data <=" & d.pdtm(df) & ")) as OS, " & _
        "(SELECT SUM(movimento.quant*(movimento.pvenda-(movimento.pvenda*(movimento.descvenda/100)))) * - 1 " & _
        "FROM movimento INNER JOIN movimentomaster ON movimento.cod_Movimento = " & _
        "movimentomaster.cod_movimento AND movimento.id_filial = " & _
        "movimentomaster.id_filial INNER JOIN saida_os ON movimentomaster.cod_movimento = " & _
        "saida_os.cod_movimento AND movimentomaster.id_filial = saida_os.id_filial INNER JOIN " & _
        "OS ON saida_os.id_filial_os = OS.id_filial AND saida_os.cod_os = OS.cod_os INNER JOIN " & _
        "produtos ON movimento.cod_produto = produtos.cod_produto INNER JOIN " & _
        "lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente AND " & _
        "produtos.id_fabricante = lentes_blocos.id_fabricante " & _
        "WHERE (lentes_blocos.cod_tabela = lentes_tabela.cod_tabela) and " & _
        "(os.cod_cliente = " & codigo & ") and (movimentomaster.data >= " & _
        d.pdtm(di) & ") AND (movimentomaster.data <=" & d.pdtm(df) & ")) as OSfin, fabricante.fabricante " & _
        "FROM lentes_tabela " & _
        "inner join fabricante on lentes_tabela.id_fabricante = fabricante.id_fabricante where (cod_tabela > 2) " & _
        "order by lentes_tabela.id_fabricante,lentes_tabela.nome_comercial"
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function

    Private Function carrega_servicos_anamaria() As DataTable
        Dim sql As String
        Dim tt As New DataTable
        Dim di, df As Date
        di = dtIni.Value.Date & " 00:00:00"
        df = dtFim.Value.Date & " 23:59:59"
        sql = "SELECT produtos.produto, SUM(pedido_balcao_servicos.quant) AS Quantidade, " & _
        "SUM(pedido_balcao_servicos.quant*pedido_balcao_servicos.preco) AS venda, " & _
        "produtos.preco_custo AS custo " & _
        "FROM  pedido_balcao INNER JOIN pedido_balcao_servicos ON pedido_balcao.num_pedido =  " & _
        "pedido_balcao_servicos.num_pedido AND pedido_balcao.id_filial = " & _
        "pedido_balcao_servicos.id_filial INNER JOIN produtos ON " & _
        "pedido_balcao_servicos.cod_servico = produtos.cod_produto " & _
        "WHERE (pedido_balcao.cod_cliente < 1000) AND (pedido_balcao.data_pedido >= " & _
        d.pdtm(di) & ") AND (pedido_balcao.data_pedido <= " & d.pdtm(df) & ") " & _
        " GROUP BY produtos.produto,produtos.preco_custo " & _
        "order by produtos.produto"
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Private Function carrega_servicos() As DataTable
        Dim sql As String
        Dim tt As New DataTable
        Dim di, df As Date
        di = dtIni.Value.Date & " 00:00:00"
        df = dtFim.Value.Date & " 23:59:59"
        'sql = "SELECT produtos.produto, SUM(pedido_balcao_servicos.quant) AS Quantidade, " & _
        '"SUM(pedido_balcao_servicos.quant*pedido_balcao_servicos.preco) AS venda, " & _
        '"sum(pedido_balcao_servicos.compra*pedido_balcao_servicos.quant)/(SUM(pedido_balcao_servicos.quant)) AS custo " & _
        '"FROM  pedido_balcao INNER JOIN pedido_balcao_servicos ON pedido_balcao.num_pedido =  " & _
        '"pedido_balcao_servicos.num_pedido AND pedido_balcao.id_filial = " & _
        '"pedido_balcao_servicos.id_filial INNER JOIN produtos ON " & _
        '"pedido_balcao_servicos.cod_servico = produtos.cod_produto INNER JOIN " & _
        '"OS ON pedido_balcao.num_pedido = OS.num_pedido AND pedido_balcao.id_filial = " & _
        '"OS.id_filial WHERE (OS.cod_cliente > 1000) AND (pedido_balcao.data_pedido >= " & _
        'd.pdtm(di) & ") AND (pedido_balcao.data_pedido <= " & d.pdtm(df) & ") " & _
        '" GROUP BY produtos.produto " & _
        '"order by produtos.produto"
        sql = "SELECT  produtos.produto, Sum(pedido_balcao_servicos.quant) as quantidade, " & _
        "Sum(pedido_balcao_servicos.quant * (pedido_balcao_servicos.preco - pedido_balcao_servicos.preco * " & _
        "(pedido_balcao_servicos.desconto / 100)))as venda ,Sum(pedido_balcao_servicos.quant * " & _
        "(pedido_balcao_servicos.compra))/sum(pedido_balcao_servicos.quant)as custo FROM pedido_balcao INNER JOIN " & _
        "pedido_balcao_servicos ON pedido_balcao.num_pedido = pedido_balcao_servicos.num_pedido AND " & _
        "pedido_balcao.id_filial = pedido_balcao_servicos.id_filial inner join produtos on " & _
        "pedido_balcao_servicos.cod_servico = produtos.cod_produto FULL OUTER JOIN " & _
        "OS ON pedido_balcao.id_filial = OS.id_filial AND pedido_balcao.num_pedido = OS.num_pedido " & _
        "WHERE     (pedido_balcao.data_pedido >=" & d.pdtm(di) & ") AND (pedido_balcao.data_pedido <= " & _
        d.pdtm(df) & ") AND (pedido_balcao.cod_cliente > 1000) " & _
        "group by produtos.produto  ORDER BY produtos.produto"
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Private Function carrega_servicos_cliente(ByVal x_cod_cliente As Integer) As DataTable
        Dim sql As String
        Dim tt As New DataTable
        Dim di, df As Date
        di = dtIni.Value.Date & " 00:00:00"
        df = dtFim.Value.Date & " 23:59:59"
        sql = "SELECT produtos.produto, SUM(pedido_balcao_servicos.quant) AS Quantidade, " & _
        "SUM(pedido_balcao_servicos.quant*pedido_balcao_servicos.preco) AS venda, " & _
        "produtos.preco_custo AS custo " & _
        "FROM  pedido_balcao INNER JOIN pedido_balcao_servicos ON pedido_balcao.num_pedido =  " & _
        "pedido_balcao_servicos.num_pedido AND pedido_balcao.id_filial = " & _
        "pedido_balcao_servicos.id_filial INNER JOIN produtos ON " & _
        "pedido_balcao_servicos.cod_servico = produtos.cod_produto " & _
        "WHERE (pedido_balcao.cod_cliente = " & x_cod_cliente & ") AND " & _
        "(pedido_balcao.data_pedido >= " & _
        d.pdtm(di) & ") AND (pedido_balcao.data_pedido <= " & d.pdtm(df) & ") " & _
        " GROUP BY produtos.produto,produtos.preco_custo " & _
        "order by produtos.produto"

        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Private Sub processa_produto_cliente(ByVal r As DataRow, ByVal cliente As String)
        Dim cod_tabela, extras, pedidos, os, totalItens As Integer
        Dim nome As String
        Dim preco_compra, venda_pedidos, venda_os, totalcompra, totalvenda, diferenca, porcTotal, fabricante As Double
        Dim rn As DataRow
        cod_tabela = r("cod_tabela")
        nome = r("nome_comercial")
        preco_compra = rdNum(r("pdesc"))
        extras = rdNum(r("extras"))
        pedidos = rdNum(r("pedidos"))
        venda_pedidos = rdNum(r("pedidos_fin"))
        os = rdNum(r("os"))
        venda_os = rdNum(r("os_fin"))
        totalItens = extras + pedidos + os
        totalcompra = totalItens * preco_compra
        totalvenda = venda_pedidos + venda_os
        diferenca = totalvenda - totalcompra
        porcTotal = 0
        fabricante = rdNum(r("id_fabricante"))
        If extras = Nothing And pedidos = Nothing And os = Nothing Then
            Exit Sub
        End If
        rn = tb_produtos.NewRow
        rn("cod_tabela") = cod_tabela
        rn("Tipo") = "Produtos"
        rn("nome") = nome
        rn("preco_compra") = wrNum(preco_compra)
        rn("extras") = wrNum(extras)
        rn("pedidos") = wrNum(pedidos)
        rn("venda_pedidos") = wrNum(venda_pedidos)
        rn("os") = wrNum(os)
        rn("venda_os") = wrNum(venda_os)
        rn("totalItens") = wrNum(totalItens)
        rn("totalcompra") = wrNum(totalcompra)
        rn("totalvenda") = wrNum(totalvenda)
        total = total + rdNum(totalvenda)
        rn("diferenca") = wrNum(diferenca)
        rn("porctotal") = wrNum(porcTotal)
        rn("fabricante") = wrNum(fabricante)
        rn("cliente") = cliente
        tb_produtos.Rows.Add(rn)
    End Sub
    Private Sub processa_servico_cliente(ByVal r As DataRow, ByVal cliente As String)
        Dim cod_tabela, extras, pedidos, os, totalItens As Integer
        Dim nome As String
        Dim preco_compra, venda_pedidos, venda_os, totalcompra, totalvenda, diferenca, porcTotal As Double
        Dim rn As DataRow
        cod_tabela = 0
        nome = r("produto")
        preco_compra = rdNum(r("custo"))
        extras = 0
        pedidos = 0
        venda_pedidos = 0
        os = rdNum(r("quantidade"))
        venda_os = rdNum(r("venda"))
        totalItens = extras + pedidos + os
        totalcompra = totalItens * preco_compra
        totalvenda = venda_pedidos + venda_os
        diferenca = totalvenda - totalcompra
        porcTotal = 0
        If extras = Nothing And pedidos = Nothing And os = Nothing Then
            Exit Sub
        End If
        rn = tb_produtos.NewRow
        rn("cod_tabela") = cod_tabela
        rn("Tipo") = "Servicos"
        rn("nome") = nome
        rn("preco_compra") = wrNum(preco_compra)
        rn("extras") = wrNum(extras)
        rn("pedidos") = wrNum(pedidos)
        rn("venda_pedidos") = wrNum(venda_pedidos)
        rn("os") = wrNum(os)
        rn("venda_os") = wrNum(venda_os)
        rn("totalItens") = wrNum(totalItens)
        rn("totalcompra") = wrNum(totalcompra)
        rn("totalvenda") = wrNum(totalvenda)
        total = total + wrNum(totalvenda)
        rn("diferenca") = wrNum(diferenca)
        rn("porctotal") = wrNum(porcTotal)
        rn("Cliente") = cliente
        tb_produtos.Rows.Add(rn)
    End Sub

    Private Function carrega_produtos_vendedora(ByVal x_cod_vendedora As Integer) As DataTable
        Dim sql As String
        Dim tt As New DataTable
        Dim di, df As Date
        di = dtIni.Value.Date & " 00:00:00"
        df = dtFim.Value.Date & " 23:59:59"
        sql = "SELECT nome_comercial,id_fabricante, cod_tabela, Preco_compra, desconto_compra, " & _
        "(preco_compra -(preco_compra*(desconto_compra/100))) as pdesc, " & _
        "(SELECT SUM(movimento.quant)*-1 " & _
        "FROM  movimento INNER JOIN " & _
        "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
        "movimento.id_filial = movimentomaster.id_filial INNER JOIN " & _
        "saida_extra ON movimentomaster.cod_movimento = saida_extra.cod_movimento AND " & _
        "movimentomaster.id_filial = saida_extra.id_filial_movimento INNER JOIN " & _
        "OS ON saida_extra.id_filial = OS.id_filial AND saida_extra.cod_os = OS.cod_os INNER JOIN " & _
        "produtos ON movimento.cod_produto = produtos.cod_produto INNER JOIN " & _
        "lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente AND " & _
        "produtos.id_fabricante = lentes_blocos.id_fabricante " & _
        "WHERE     (lentes_blocos.cod_tabela = lentes_tabela.cod_tabela) and " & _
        "(os.cod_vendedora = " & x_cod_vendedora & ") and (movimentomaster.data >= " & _
        d.pdtm(di) & ") AND (movimentomaster.data <= " & _
        d.pdtm(df) & ")) as Extras, " & _
        "(SELECT     SUM(movimento.quant) * - 1 FROM lentes_blocos INNER JOIN " & _
        "movimentomaster INNER JOIN movimento ON movimentomaster.cod_movimento = " & _
        "movimento.cod_Movimento AND movimentomaster.id_filial = movimento.id_filial " & _
        "INNER JOIN produtos ON movimento.cod_produto = produtos.cod_produto " & _
        "ON lentes_blocos.cod_lente = produtos.cod_lente AND " & _
        "lentes_blocos.id_fabricante = produtos.id_fabricante INNER JOIN " & _
        "saida_pedido ON movimentomaster.cod_movimento = saida_pedido.cod_movimento AND " & _
        "movimentomaster.id_filial = saida_pedido.id_filial INNER JOIN " & _
        "pedido_balcao ON saida_pedido.num_pedido = pedido_balcao.num_pedido AND " & _
        "saida_pedido.id_filial = pedido_balcao.id_filial WHERE " & _
        "(movimentomaster.data >= " & d.pdtm(di) & ") AND (movimentomaster.data <= " & d.pdtm(df) & _
        ") and (pedido_balcao.cod_vendedor = " & x_cod_vendedora & ") " & _
        "and (lentes_blocos.cod_tabela = lentes_tabela.cod_tabela)) as pedidos, " & _
        "(SELECT     SUM(movimento.quant*(movimento.pvenda-movimento.descvenda)) * - 1 " & _
        "FROM lentes_blocos INNER JOIN movimentomaster INNER JOIN " & _
        "movimento ON movimentomaster.cod_movimento = movimento.cod_Movimento AND movimentomaster.id_filial " & _
        "= movimento.id_filial INNER JOIN produtos ON movimento.cod_produto = produtos.cod_produto " & _
        "ON lentes_blocos.cod_lente = produtos.cod_lente AND " & _
        "lentes_blocos.id_fabricante = produtos.id_fabricante INNER JOIN " & _
        "saida_pedido ON movimentomaster.cod_movimento = saida_pedido.cod_movimento AND " & _
        "movimentomaster.id_filial = saida_pedido.id_filial INNER JOIN " & _
        "pedido_balcao ON saida_pedido.num_pedido = pedido_balcao.num_pedido AND " & _
        "saida_pedido.id_filial = pedido_balcao.id_filial " & _
        "WHERE (movimentomaster.data >= " & d.pdtm(di) & ") AND " & _
        "(movimentomaster.data <= " & d.pdtm(df) & ") and (pedido_balcao.cod_vendedor = " & x_cod_vendedora & ") " & _
        "and (lentes_blocos.cod_tabela = lentes_tabela.cod_tabela)) as pedidos_Fin, " & _
        "(SELECT     SUM(movimento.quant) *-1 " & _
        "FROM movimento INNER JOIN movimentomaster ON movimento.cod_Movimento = " & _
        "movimentomaster.cod_movimento AND movimento.id_filial = " & _
        "movimentomaster.id_filial INNER JOIN saida_os ON movimentomaster.cod_movimento = " & _
        "saida_os.cod_movimento AND movimentomaster.id_filial = saida_os.id_filial INNER JOIN " & _
        "OS ON saida_os.id_filial_os = OS.id_filial AND saida_os.cod_os = OS.cod_os INNER JOIN " & _
        "produtos ON movimento.cod_produto = produtos.cod_produto INNER JOIN " & _
        "lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente AND " & _
        "produtos.id_fabricante = lentes_blocos.id_fabricante " & _
        "WHERE     (lentes_blocos.cod_tabela = lentes_tabela.cod_tabela) and " & _
        "(os.cod_vendedora = " & x_cod_vendedora & ") and (movimentomaster.data >= " & d.pdtm(di) & _
        ") AND (movimentomaster.data <=" & d.pdtm(df) & ")) as OS, " & _
        "(SELECT SUM(movimento.quant*(movimento.pvenda-movimento.descvenda)) * - 1 " & _
        "FROM movimento INNER JOIN movimentomaster ON movimento.cod_Movimento = " & _
        "movimentomaster.cod_movimento AND movimento.id_filial = " & _
        "movimentomaster.id_filial INNER JOIN saida_os ON movimentomaster.cod_movimento = " & _
        "saida_os.cod_movimento AND movimentomaster.id_filial = saida_os.id_filial INNER JOIN " & _
        "OS ON saida_os.id_filial_os = OS.id_filial AND saida_os.cod_os = OS.cod_os INNER JOIN " & _
        "produtos ON movimento.cod_produto = produtos.cod_produto INNER JOIN " & _
        "lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente AND " & _
        "produtos.id_fabricante = lentes_blocos.id_fabricante " & _
        "WHERE (lentes_blocos.cod_tabela = lentes_tabela.cod_tabela) and " & _
        "(os.cod_vendedora = " & x_cod_vendedora & ") and (movimentomaster.data >= " & _
        d.pdtm(di) & ") AND (movimentomaster.data <=" & d.pdtm(df) & ")) as OS_fin " & _
        "FROM lentes_tabela where (cod_tabela > 2) order by id_fabricante,nome_comercial"
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Private Function carrega_servicos_vendedora(ByVal x_cod_vendedora As Integer) As DataTable
        Dim sql As String
        Dim tt As New DataTable
        Dim di, df As Date
        di = dtIni.Value.Date & " 00:00:00"
        df = dtFim.Value.Date & " 23:59:59"
        sql = "SELECT produtos.produto, SUM(pedido_balcao_servicos.quant) AS Quantidade, " & _
        "SUM(pedido_balcao_servicos.quant*pedido_balcao_servicos.preco) AS venda, " & _
        "produtos.preco_custo AS custo " & _
        "FROM  pedido_balcao INNER JOIN pedido_balcao_servicos ON pedido_balcao.num_pedido =  " & _
        "pedido_balcao_servicos.num_pedido AND pedido_balcao.id_filial = " & _
        "pedido_balcao_servicos.id_filial INNER JOIN produtos ON " & _
        "pedido_balcao_servicos.cod_servico = produtos.cod_produto INNER JOIN " & _
        "OS ON pedido_balcao.num_pedido = OS.num_pedido AND pedido_balcao.id_filial = " & _
        "OS.id_filial WHERE (OS.cod_vendedora = " & x_cod_vendedora & ") AND (OS.data_verificacao >= " & _
        d.pdtm(di) & ") AND (OS.data_verificacao <= " & d.pdtm(df) & ") " & _
        " GROUP BY produtos.produto,produtos.preco_custo " & _
        "order by produtos.produto"
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Private Sub exporta(ByVal r As DataDynamics.ActiveReports.Document.Document, ByVal path As String)
        If MessageBox.Show("Deseja exportar os dados para área de trabalho?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            xlsExport.Export(r, path)
        End If
    End Sub
    Private Sub btnProdutos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProdutos.Click
        Dim path As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\FaturamentoProdutos.xls"
        Dim intUsuario As Integer = promotor.retorna_codigo_usuario(frmMain.intCodigoUsuario)
        Dim tt As New DataTable
        Dim i, m As Integer
        Dim f As New frmRpt
        Dim r As New rptFaturamentoProdutos
        Dim completo As Boolean
        Dim faturamento As New objFaturamento
        If MessageBox.Show("Exibir com todos os dados?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If promotor.verifica_permissao_usuario(intUsuario, 41) = True Then
                completo = True
            Else
                MessageBox.Show("Usuário sem acesso para visualizar todo os dados.", "ERROR: 41", MessageBoxButtons.OK, MessageBoxIcon.Error)
                completo = False
            End If
        Else
            If promotor.verifica_permissao_usuario(intUsuario, 41) = True Then
                completo = False
            Else
                completo = False
            End If
        End If
        r.completo = completo

        Application.DoEvents()

        faturamento.data_inicial = dtIni.Value.Date & " 00:00:00"
        faturamento.data_final = dtFim.Value.Date & " 23:59:59"

        r.titulo = "Relatório de Faturamento por Produto / Serviço no período de " & dtIni.Value.Date & _
       " até " & dtFim.Value.Date
        r.DataSource = faturamento.faturamento_produtos(pb, 1)
        f.Relat(r)
        f.Show()
        exporta(r.Document, path)
    End Sub

    Private Sub porcentagem()
        Dim r As DataRow
        Dim i, m As Integer
        i = 0
        m = tb_produtos.Rows.Count
        While i < m
            r = tb_produtos.Rows(i)
            r("porctotal") = (rdNum(r("totalvenda")) / total)
            i = i + 1
        End While
    End Sub

    Private Sub btnVendedora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVendedora.Click
        Dim path As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\FaturamentoVendedoras.xls"
        Dim intUsuario As Integer = promotor.retorna_codigo_usuario(frmMain.intCodigoUsuario)
        Dim f As New frmRpt
        'Dim path As String
        Dim tt As New DataTable
        Dim r As New rptFaturamentoVendedor
        Dim sql As String
        Dim di, df As Date
        Dim completo As Boolean
        If MessageBox.Show("Exibir com todos os dados?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If promotor.verifica_permissao_usuario(intUsuario, 41) Then
                completo = True
            Else
                MessageBox.Show("Usuário sem acesso para visualizar todo os dados.", "ERROR: 41", MessageBoxButtons.OK, MessageBoxIcon.Error)
                completo = False
            End If
        Else
            If promotor.verifica_permissao_usuario(intUsuario, 41) = True Then
                completo = False
            Else
                completo = False
            End If
        End If
        r.completo = completo
        Application.DoEvents()
        Cursor = Cursors.AppStarting
        di = dtIni.Value.Date & " 00:00:00"
        df = dtFim.Value.Date & " 23:59:59"
        sql = "SELECT nome, cod_usuario, pDesc, Extra, balcao,OS," &
        "(Extra+balcao+os) as total, PCheio, pFin,  OSCheio, OSFin, (pFin+OSfin+Servicos_fin) as Total_din, " &
        "(((Extra+balcao+os)*pDesc)+servicos_custo) as Custo, servicos_fin, " &
        "((pFin+OSfin+Servicos_fin)-(((Extra+balcao+os)*pDesc)+servicos_custo)) as margem " &
        "FROM faturamento_vendedora(" & d.pdtm(di) & ", " & d.pdtm(df) & ") AS fat  " &
        "where (extra > 0) or (balcao > 0) or (os >0) or (servicos_fin > 0) " &
        "order by (pFin+osfin+servicos_fin) Desc"
        r.titulo = "Relatório de Faturamento por cliente no período de " & dtIni.Value.Date &
        " até " & dtFim.Value.Date & " dos clientes"
        d.carrega_Tabela(sql, tt)
        r.DataSource = tt
        f.Relat(r)
        f.Show()
        exporta(r.Document, path)
        Exit Sub

        Dim i, m As Integer
        Dim vd As Integer
        Dim user As New objUsuario

        vd = InputBox("Código da Vendedora")

        tt = carrega_produtos_vendedora(vd)
        tb_produtos.Clear()
        tb_produtos = monta_tabela_produto()
        i = 0
        m = tt.Rows.Count
        pb.Minimum = 0
        pb.Maximum = m
        While i < m
            processa_produto(tt.Rows(i))
            pb.Value = i
            i = i + 1
        End While
        tt = carrega_servicos_vendedora(vd)
        i = 0
        m = tt.Rows.Count
        pb.Minimum = 0
        pb.Value = 0
        pb.Maximum = m
        While i < m
            processa_servico(tt.Rows(i))
            pb.Value = i
            i = i + 1
        End While
        porcentagem()
        r.titulo = "Relatório de Faturamento por Produto / Serviço no período de " & dtIni.Value.Date &
        " até " & dtFim.Value.Date & " da vendedora: " & user.nome_usuario(vd) & "."
        r.DataSource = tb_produtos
        f.Relat(r)
        f.Show()
        exporta(r.Document, path)
    End Sub

    Dim tt As New DataTable
    Dim i, m As Integer
    Dim f As New frmRpt
    Dim vd As Integer
    Dim user As New objUsuario
    Dim r As New rptFaturamentoProdutos

    Private Sub btnClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClientes.Click
        Dim path As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\FaturamentoCliente.xls"
        Dim intUsuario As Integer = promotor.retorna_codigo_usuario(frmMain.intCodigoUsuario)
        Dim f As New frmRpt
        Dim tt As New DataTable
        Dim r As New rptFaturamentoClientes
        Dim sql As String
        Dim di, df As Date
        Dim completo As Boolean
        If MessageBox.Show("Exibir com todos os dados?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If promotor.verifica_permissao_usuario(intUsuario, 41) = True Then
                completo = True
            Else
                MessageBox.Show("Usuário sem acesso para visualizar todo os dados.", "ERROR: 41", MessageBoxButtons.OK, MessageBoxIcon.Error)
                completo = False
            End If
        Else
            If promotor.verifica_permissao_usuario(intUsuario, 41) = True Then
                completo = False
            Else
                completo = False
            End If
        End If
        r.completo = completo
        Application.DoEvents()
        Cursor = Cursors.AppStarting
        di = dtIni.Value.Date & " 00:00:00"
        df = dtFim.Value.Date & " 23:59:59"
        sql = "SELECT nome_cliente, cod_cliente, cod_filial_cliente, pDesc, Extra, balcao,OS," &
        "(Extra+balcao+os) as total, PCheio, pFin,  OSCheio, OSFin, (pFin+OSfin+Servicos_fin) as Total_din, " &
        "(((Extra+balcao+os)*pDesc)+servicos_custo) as Custo, servicos_fin, " &
        "((pFin+OSfin+Servicos_fin)-(((Extra+balcao+os)*pDesc)+servicos_custo)) as margem " &
        "FROM faturamento_cliente(" & d.pdtm(di) & ", " & d.pdtm(df) & ") AS fat  " &
        "where (extra > 0) or (balcao > 0) or (os >0) or (servicos_fin > 0) " &
        "order by (pFin+osfin+servicos_fin) Desc"
        r.titulo = "Relatório de Faturamento por cliente no período de " & dtIni.Value.Date &
        " até " & dtFim.Value.Date & " dos clientes"
        d.carrega_Tabela(sql, tt)
        r.DataSource = tt
        f.Relat(r)
        Cursor = Cursors.Default
        f.Show()
        exporta(r.Document, path)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sql As String
        Dim tt As New DataTable
        Dim i, m As Integer
        Dim prod As New produtoClass
        sql = "SELECT cod_servico  FROM pedido_balcao_servicos GROUP BY cod_servico"
        d.carrega_Tabela(sql, tt)
        i = 0
        m = tt.Rows.Count
        pb.Maximum = m
        While i < m
            prod.filtra(tt.Rows(i)(0))
            sql = "Update pedido_balcao_servicos set compra = " & d.cdin(prod.compra_servico(prod.fldCod_produto)) &
            " where cod_Servico = " & prod.fldCod_produto & ""
            d.Comando(sql, True)
            i = i + 1
            pb.Value = i
            Application.DoEvents()
        End While

    End Sub

    Private Sub btnDescontos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDescontos.Click
        Dim path As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\FaturamentoProdutosDesconto.xls"
        Dim r As New rptFatProdutosDesconto
        Dim f As New frmRpt
        Dim tt As New DataTable
        Dim di, df As Date
        Dim sql As String
        Me.Cursor = Cursors.AppStarting
        Application.DoEvents()
        di = dtIni.Value.Date & " 00:00:00"
        df = dtFim.Value.Date & " 23:59:59"
        sql = "SELECT cod_tabela, nome_comercial, id_fabricante, pdesc, " &
        "Extras, Pedidos, pedidosCheio, pedidosFin, OS, OSCheio, OSFin " &
        "FROM faturamento_produtos(" & d.pdtm(di) & "," & d.pdtm(df) & ") AS faturamento_produtos_1 " &
        " where (pedidosCheio <> pedidosFin) or (osCheio <> osfin)"
        d.carrega_Tabela(sql, tt)
        r.DataSource = tt
        f.Relat(r)
        f.ShowDialog(Me)
        f.Dispose()
        exporta(r.Document, path)
    End Sub
    Private Sub combos()
        Dim tt As New DataTable
        Dim sql As String
        Dim strSQL As String
        Dim strSQLUF As String
        sql = "Select * from promotor ORDER by cod_promotor"
        d.carrega_Tabela(sql, tt)
        cbPromotor.DataSource = tt
        cbPromotor.DisplayMember = "promotor"
        cbPromotor.ValueMember = "cod_promotor"

        cbCidade.DataSource = cliente.cidades
        cbCidade.DisplayMember = "cidade"
        cbCidade.ValueMember = "codigo"
        cbCidade.SelectedIndex = -1

        strSQLUF = "Select * from uf ORDER by estado"
        d.carrega_Tabela(strSQLUF, tt)
        cbEstado.DataSource = tt
        cbEstado.DisplayMember = "estado"
        cbEstado.ValueMember = "codigo"
        cbEstado.SelectedIndex = -1

        strSQL = "Select * from promotor ORDER by cod_promotor"
        d.carrega_Tabela(strSQL, tt)
        cbPromotorTrans.DataSource = tt
        cbPromotorTrans.DisplayMember = "promotor"
        cbPromotorTrans.ValueMember = "cod_promotor"
    End Sub
    Private Sub btnClientePromo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClientePromo.Click
        Dim path As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\FaturamentoClientePromo.xls"
        Dim f As New frmRpt
        Dim tt As New DataTable
        Dim r As New rptFaturamentoClientes
        Dim sql As String
        Dim di, df As Date
        Dim completo As Boolean
        Dim intUsuario As Integer = CInt(promotor.retorna_codigo_usuario(frmMain.intCodigoUsuario))
        If MessageBox.Show("Exibir com todos os dados?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If promotor.verifica_permissao_usuario(intUsuario, 41) = True Then
                completo = True
            Else
                MessageBox.Show("Usuário sem acesso para visualizar todo os dados.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                completo = False
            End If
        Else
            If promotor.verifica_permissao_usuario(intUsuario, 41) = True Then
                completo = False
            Else
                completo = False
            End If
        End If
        r.completo = completo
        di = dtIni.Value.Date & " 00:00:00"
        df = dtFim.Value.Date & " 23:59:59"
        sql = "SELECT nome_cliente, cod_cliente, cod_filial_cliente, pDesc, Extra, balcao,OS," &
        "(Extra+balcao+os) as total, PCheio, pFin,  OSCheio, OSFin, (pFin+OSfin+Servicos_fin) as Total_din, " &
        "(((Extra+balcao+os)*pDesc)+servicos_custo) as Custo, servicos_fin, " &
        "((pFin+OSfin+Servicos_fin)-(((Extra+balcao+os)*pDesc)+servicos_custo)) as margem " &
        "FROM faturamento_cliente_promotor(" & d.pdtm(di) & ", " & d.pdtm(df) & "," & cbPromotor.SelectedValue & ") AS fat  " &
        "where (extra > 0) or (balcao > 0) or (os >0) or (servicos_fin > 0) " &
        "order by (pFin+osfin+servicos_fin) Desc"
        r.titulo = "Relatório de Faturamento por cliente no período de " & dtIni.Value.Date &
        " até " & dtFim.Value.Date & " dos clientes"
        d.carrega_Tabela(sql, tt)
        r.DataSource = tt
        f.Relat(r)
        f.Show()
        exporta(r.Document, path)
    End Sub
    Private Sub prod_cliente()
        Dim path As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\FaturamentoProdutosCliente.xls"
        Dim intUsuario As Integer = promotor.retorna_codigo_usuario(frmMain.intCodigoUsuario)
        Dim cc As Integer
        Dim fc As New frmConsultaCliente
        Dim completo As Boolean
        If MessageBox.Show("Exibir com todos os dados?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If promotor.verifica_permissao_usuario(intUsuario, 41) Then
                completo = True
            Else
                MessageBox.Show("Usuário sem acesso para visualizar todo os dados.", "ERROR: 41", MessageBoxButtons.OK, MessageBoxIcon.Error)
                completo = False
            End If
        End If
        r.completo = completo
        fc.ShowDialog(Me)
        cc = fc.cod_cliente
        tt = carrega_produtos_cliente(cc)
        tb_produtos.Clear()
        tb_produtos = monta_tabela_produto()
        i = 0
        m = tt.Rows.Count
        pb.Minimum = 0
        pb.Maximum = m
        While i < m
            processa_produto(tt.Rows(i))
            pb.Value = i
            i = i + 1
        End While
        tt = carrega_servicos_cliente(cc)
        i = 0
        m = tt.Rows.Count
        pb.Minimum = 0
        pb.Value = 0
        pb.Maximum = m
        While i < m
            processa_servico(tt.Rows(i))
            pb.Value = i
            i = i + 1
        End While
        porcentagem()
        r.titulo = "Relatório de Faturamento por Produto / Serviço no período de " & dtIni.Value.Date &
        " até " & dtFim.Value.Date & " do Cliente: " & fc.nome & "."
        r.DataSource = tb_produtos
        f.Relat(r)
        f.Show()
        exporta(r.Document, path)
        fc.Dispose()
    End Sub
    Private Sub btnProdCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProdCliente.Click
        prod_cliente()
    End Sub

    Private Sub btnProdOtica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProdOtica.Click
        Dim fc As New frmConsultaOticas
        fc.ShowDialog()

        If fc.intTag = 0 Then
            Exit Sub
        End If

        Dim path As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\FaturamentoProdutosAna.xls"
        Dim intUsuario As Integer = promotor.retorna_codigo_usuario(frmMain.intCodigoUsuario)
        Dim tt As New DataTable
        Dim i, m As Integer
        Dim f As New frmRpt
        Dim r As New rptFaturamentoProdutos
        Dim completo As Boolean
        If MessageBox.Show("Exibir com todos os dados?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If promotor.verifica_permissao_usuario(intUsuario, 41) Then
                completo = True
            Else
                MessageBox.Show("Usuário sem acesso para visualizar todo os dados.", "ERROR: 41", MessageBoxButtons.OK, MessageBoxIcon.Information)
                completo = False
            End If
        Else
            If promotor.verifica_permissao_usuario(intUsuario, 41) = True Then
                completo = False
            Else
                completo = False
            End If
        End If
        r.completo = completo

        If fc.intCodigoCli <= 100 Then
            tt = carrega_produtos_anamaria(fc.intCodigoCli)
            r.titulo = "Relatório de Faturamento por Produto / Serviço " & fc.strCliente & " no período de " & dtIni.Value.Date &
            " até " & dtFim.Value.Date
        Else
            tt = carrega_produtos_anamaria()
            r.titulo = "Relatório de Faturamento por Produto / Serviço Ana Maria no período de " & dtIni.Value.Date &
            " até " & dtFim.Value.Date
        End If

        tb_produtos.Clear()
        tb_produtos = monta_tabela_produto()
        i = 0
        m = tt.Rows.Count
        pb.Minimum = 0
        pb.Maximum = m
        While i < m
            processa_produto(tt.Rows(i))
            pb.Value = i
            i = i + 1
        End While
        tt = carrega_servicos_anamaria()
        i = 0
        m = tt.Rows.Count
        pb.Minimum = 0
        pb.Value = 0
        pb.Maximum = m
        While i < m
            processa_servico(tt.Rows(i))
            pb.Value = i
            i = i + 1
        End While
        porcentagem()
        r.DataSource = tb_produtos
        f.Relat(r)
        f.Show()
        exporta(r.Document, path)
    End Sub

    Private Sub btnClienteCidade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClienteCidade.Click
        Dim path As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\FaturamentoClienteCidade.xls"
        Dim intUsuario As Integer = promotor.retorna_codigo_usuario(frmMain.intCodigoUsuario)
        Dim f As New frmRpt
        Dim tt As New DataTable
        Dim r As New rptFaturamentoClientes
        Dim strSQL As String = ""
        Dim di, df As Date
        Dim completo As Boolean
        If MessageBox.Show("Exibir com todos os dados?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If promotor.verifica_permissao_usuario(intUsuario, 41) Then
                completo = True
            Else
                MessageBox.Show("Usuário sem acesso para visualizar todo os dados.", "ERROR: 41", MessageBoxButtons.OK, MessageBoxIcon.Information)
                completo = False
            End If
        Else
            If promotor.verifica_permissao_usuario(intUsuario, 41) = True Then
                completo = False
            Else
                completo = False
            End If
        End If
        r.completo = completo
        Application.DoEvents()
        Cursor = Cursors.AppStarting
        di = dtIni.Value.Date & " 00:00:00"
        df = dtFim.Value.Date & " 23:59:59"
        If rbCidade.Checked = True Then
            strSQL = "SELECT nome_cliente, cod_cliente, cod_filial_cliente, pDesc, Extra, balcao,OS," &
            "(Extra+balcao+os) as total, PCheio, pFin,  OSCheio, OSFin, (pFin+OSfin+Servicos_fin) as Total_din, " &
            "(((Extra+balcao+os)*pDesc)+servicos_custo) as Custo, servicos_fin, " &
            "((pFin+OSfin+Servicos_fin)-(((Extra+balcao+os)*pDesc)+servicos_custo)) as margem " &
            "FROM faturamento_cliente(" & d.pdtm(di) & ", " & d.pdtm(df) & ") AS fat  " &
            "where ((extra > 0) or (balcao > 0) or (os >0) or (servicos_fin > 0)) " &
            " and (codigo_cidade = " & cbCidade.SelectedValue &
            ") order by (pFin+osfin+servicos_fin) Desc"
            r.titulo = "Relatório de Faturamento por cliente da cidade " & cbCidade.Text & " no período de " & dtIni.Value.Date &
            " até " & dtFim.Value.Date & " dos clientes"
        End If
        If rbUf.Checked = True Then
            strSQL = "SELECT nome_cliente, cod_cliente, cod_filial_cliente, pDesc, Extra, balcao,OS," &
            "(Extra+balcao+os) as total, PCheio, pFin,  OSCheio, OSFin, (pFin+OSfin+Servicos_fin) as Total_din, " &
            "(((Extra+balcao+os)*pDesc)+servicos_custo) as Custo, servicos_fin, " &
            "((pFin+OSfin+Servicos_fin)-(((Extra+balcao+os)*pDesc)+servicos_custo)) as margem " &
            "FROM faturamento_cliente(" & d.pdtm(di) & ", " & d.pdtm(df) & ") AS fat  " &
            "where ((extra > 0) or (balcao > 0) or (os >0) or (servicos_fin > 0)) " &
            " and (uf = " & d.PStr(cbEstado.SelectedValue) &
            ") order by (pFin+osfin+servicos_fin) Desc"
            r.titulo = "Relatório de Faturamento por cliente do estado " & cbEstado.Text & " no período de " & dtIni.Value.Date &
            " até " & dtFim.Value.Date & " dos clientes"
        End If

        d.carrega_Tabela(strSQL, tt)
        pb.Minimum = 0
        pb.Maximum = tt.Rows.Count - 1

        For i = 0 To tt.Rows.Count - 1
            pb.Value = i
            pb.Step = 1
            pb.PerformStep()
        Next

        r.DataSource = tt
        f.Relat(r)
        Cursor = Cursors.Default
        f.Show()
        exporta(r.Document, path)
    End Sub




    Private Sub btnPromotor_Click(sender As System.Object, e As System.EventArgs) Handles btnPromotor.Click
        If chkTransitions.Checked = True Or chkAcclimate.Checked = True Or chkCrizal.Checked = True Then
            Dim intUsuario As Integer = promotor.retorna_codigo_usuario(frmMain.intCodigoUsuario)
            Dim path As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\FaturamentoPromotorTrans.xls"
            Dim f As New frmRpt
            Dim tt As New DataTable
            Dim r As New rptFaturamentoPromotor
            Dim sql As String
            Dim di, df As Date
            Dim completo As Boolean
            Dim intFam As Integer
            Dim strTitulo As String = ""
            ' rcompleto = MessageBox.Show( MsgBox("Exibir com todos os dados?", MsgBoxStyle.YesNo)
            'rcompleto = 
            If MessageBox.Show("Exibir com todos os dados?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If promotor.verifica_permissao_usuario(intUsuario, 41) = True Then
                    completo = True
                Else
                    MessageBox.Show("Usuário sem acesso para visualizar todo os dados.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    completo = False
                End If
            Else
                If promotor.verifica_permissao_usuario(intUsuario, 41) = True Then
                    completo = False
                Else
                    completo = False
                End If
            End If
            r.completo = completo
            di = dtIni.Value.Date & " 00:00:00"
            df = dtFim.Value.Date & " 23:59:59"
            If (chkTransitions.Checked = True) Then
                intFam = 2
                strTitulo = "Transitions"
            ElseIf (chkAcclimate.Checked = True) Then
                intFam = 6
                strTitulo = "Acclimate"
            ElseIf (chkCrizal.Checked = True) Then
                intFam = 3
                strTitulo = "Crizal"
            End If
            sql = "SELECT nome_cliente, cod_cliente, cod_filial_cliente, pDesc, Extra, balcao,OS," &
            "(balcao+os) as total, PCheio, pFin,  OSCheio, OSFin, (pFin+OSfin+Servicos_fin) as Total_din, " &
            "(pFin+OSFin) as Total_Trans,(((Extra+balcao+os)*pDesc)+servicos_custo) as Custo, Servicos_fin, " &
            "((pFin+OSfin+Servicos_fin)-(((Extra+balcao+os)*pDesc)+servicos_custo)) as margem " &
            "FROM faturamento_cliente_promotor_trans(" & d.pdtm(di) & ", " & d.pdtm(df) & "," & cbPromotorTrans.SelectedValue & "," & intFam & ") AS fat  " &
            "where (extra > 0) or (balcao > 0) or (os > 0) " &
            "order by (pFin+osfin+servicos_fin) Desc"

            r.titulo = "Relatório de Faturamento por cliente no período de " & dtIni.Value.Date &
            " até " & dtFim.Value.Date & " das lentes " & strTitulo
            d.carrega_Tabela(sql, tt)
            r.DataSource = tt
            r.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait
            f.Relat(r)
            f.Show()
            exporta(r.Document, path)
        Else
            MessageBox.Show("Por favor, selecione um tipo de lente.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnCrizal_Click(sender As System.Object, e As System.EventArgs) Handles btnCrizal.Click
        Dim intUsuario As Integer = promotor.retorna_codigo_usuario(frmMain.intCodigoUsuario)
        Dim path As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\FaturamentoPromotorTrans.xls"
        Dim f As New frmRpt
        Dim tt As New DataTable
        Dim r As New rptFaturamentoPromotor
        Dim sql As String
        Dim di, df As Date
        Dim completo As Boolean
        Dim intFam As Integer
        Dim strTitulo As String = ""
        Dim i As Integer
        If MessageBox.Show("Exibir com todos os dados?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If promotor.verifica_permissao_usuario(intUsuario, 41) = True Then
                completo = True
            Else
                MessageBox.Show("Usuário sem acesso para visualizar todo os dados.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                completo = False
            End If
        Else
            If promotor.verifica_permissao_usuario(intUsuario, 41) = True Then
                completo = False
            Else
                completo = False
            End If
        End If
        r.completo = completo
        di = dtIni.Value.Date & " 00:00:00"
        df = dtFim.Value.Date & " 23:59:59"
        intFam = 3
        strTitulo = "Crizal"

        sql = "SELECT nome_cliente, cod_cliente, cod_filial_cliente, pDesc, Extra, balcao,OS," &
        "(balcao+os) as total, PCheio, pFin,  OSCheio, OSFin, (pFin+OSfin+Servicos_fin) as Total_din, " &
        "(pFin+OSFin) as Total_Trans,(((Extra+balcao+os)*pDesc)+servicos_custo) as Custo, Servicos_fin, " &
        "((pFin+OSfin+Servicos_fin)-(((Extra+balcao+os)*pDesc)+servicos_custo)) as margem " &
        "FROM faturamento_cliente_promotor_crizal(" & d.pdtm(di) & ", " & d.pdtm(df) & "," & intFam & ") AS fat  " &
        "where (extra > 0) or (balcao > 0) or (os > 0) " &
        "order by (pFin+osfin+servicos_fin) Desc"

        r.titulo = "Relatório de Faturamento por cliente no período de " & dtIni.Value.Date &
        " até " & dtFim.Value.Date & " das lentes " & strTitulo
        d.carrega_Tabela(sql, tt)

        r.DataSource = tt
        r.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait
        f.Relat(r)
        f.Show()
        exporta(r.Document, path)
    End Sub

    Private Sub btnPromotorGeral_Click(sender As System.Object, e As System.EventArgs) Handles btnPromotorGeral.Click
        If chkTransitions.Checked = True Or chkAcclimate.Checked = True Or chkCrizal.Checked = True Then
            Dim intUsuario As Integer = promotor.retorna_codigo_usuario(frmMain.intCodigoUsuario)
            Dim path As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\FaturamentoPromotorTrans.xls"
            Dim f As New frmRpt
            Dim tt As New DataTable
            Dim r As New rptFaturamentoPromotor
            Dim sql As String
            Dim di, df As Date
            Dim completo As Boolean
            Dim intFam As Integer
            Dim strTitulo As String = ""
            ' rcompleto = MessageBox.Show( MsgBox("Exibir com todos os dados?", MsgBoxStyle.YesNo)
            'rcompleto = 
            If MessageBox.Show("Exibir com todos os dados?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If promotor.verifica_permissao_usuario(intUsuario, 41) = True Then
                    completo = True
                Else
                    MessageBox.Show("Usuário sem acesso para visualizar todo os dados.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    completo = False
                End If
            Else
                If promotor.verifica_permissao_usuario(intUsuario, 41) = True Then
                    completo = False
                Else
                    completo = False
                End If
            End If
            r.completo = completo
            di = dtIni.Value.Date & " 00:00:00"
            df = dtFim.Value.Date & " 23:59:59"
            If (chkTransitions.Checked = True) Then
                intFam = 2
                strTitulo = "Transitions"
            ElseIf (chkAcclimate.Checked = True) Then
                intFam = 6
                strTitulo = "Acclimate"
            ElseIf (chkCrizal.Checked = True) Then
                intFam = 3
                strTitulo = "Crizal"
            End If
            sql = "SELECT nome_cliente, cod_cliente, cod_filial_cliente, pDesc, Extra, balcao,OS," &
            "(balcao+os) as total, PCheio, pFin,  OSCheio, OSFin, (pFin+OSfin+Servicos_fin) as Total_din, " &
            "(pFin+OSFin) as Total_Trans,(((Extra+balcao+os)*pDesc)+servicos_custo) as Custo, Servicos_fin, " &
            "((pFin+OSfin+Servicos_fin)-(((Extra+balcao+os)*pDesc)+servicos_custo)) as margem " &
            "FROM faturamento_cliente_promotor_lentes(" & d.pdtm(di) & ", " & d.pdtm(df) & "," & intFam & ") AS fat  " &
            "where (extra > 0) or (balcao > 0) or (os > 0) " &
            "order by (pFin+osfin+servicos_fin) Desc"

            r.titulo = "Relatório de Faturamento por cliente no período de " & dtIni.Value.Date &
            " até " & dtFim.Value.Date & " das lentes " & strTitulo
            d.carrega_Tabela(sql, tt)
            r.DataSource = tt
            r.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait
            f.Relat(r)
            f.Show()
            exporta(r.Document, path)
        Else
            MessageBox.Show("Por favor, selecione um tipo de lente.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub rbCidade_Click(sender As System.Object, e As System.EventArgs) Handles rbCidade.Click
        cbCidade.Enabled = True
        cbEstado.Enabled = False
    End Sub

    Private Sub rbUf_Click(sender As System.Object, e As System.EventArgs) Handles rbUf.Click
        cbCidade.Enabled = False
        cbEstado.Enabled = True
    End Sub


    Private Sub cbPromotorFamilia_Click(sender As System.Object, e As System.EventArgs) Handles cbPromotorFamilia.Click
        If cbFamilia.Checked = True Then
            cbFamilia.Checked = False
        End If
        cbPromotorTrans.Enabled = True
        chkTransitions.Enabled = True
        chkAcclimate.Enabled = True
        chkCrizal.Enabled = True
        btnPromotor.Enabled = True
        btnPromotorGeral.Enabled = False
        If cbPromotorFamilia.Checked = False And cbFamilia.Checked = False Then
            btnPromotor.Enabled = False
            btnPromotorGeral.Enabled = False
        End If
    End Sub

    Private Sub cbFamilia_Click(sender As System.Object, e As System.EventArgs) Handles cbFamilia.Click
        If cbPromotorFamilia.Checked = True Then
            cbPromotorFamilia.Checked = False
        End If
        cbPromotorTrans.Enabled = False
        chkTransitions.Enabled = True
        chkAcclimate.Enabled = True
        chkCrizal.Enabled = True
        btnPromotor.Enabled = False
        btnPromotorGeral.Enabled = True
        If cbPromotorFamilia.Checked = False And cbFamilia.Checked = False Then
            btnPromotor.Enabled = False
            btnPromotorGeral.Enabled = False
        End If
    End Sub

    Private Sub btnProdutosSemFilial_Click(sender As System.Object, e As System.EventArgs) Handles btnProdutosSemFilial.Click
        Dim path As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\FaturamentoProdutos.xls"
        Dim intUsuario As Integer = promotor.retorna_codigo_usuario(frmMain.intCodigoUsuario)
        Dim tt As New DataTable
        Dim i, m As Integer
        Dim f As New frmRpt
        Dim r As New rptFaturamentoProdutos
        Dim completo As Boolean
        Dim faturamento As New objFaturamento
        If MessageBox.Show("Exibir com todos os dados?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If promotor.verifica_permissao_usuario(intUsuario, 41) = True Then
                completo = True
            Else
                MessageBox.Show("Usuário sem acesso para visualizar todo os dados.", "ERROR: 41", MessageBoxButtons.OK, MessageBoxIcon.Error)
                completo = False
            End If
        Else
            If promotor.verifica_permissao_usuario(intUsuario, 41) = True Then
                completo = False
            Else
                completo = False
            End If
        End If
        r.completo = completo

        Application.DoEvents()

        faturamento.data_inicial = dtIni.Value.Date & " 00:00:00"
        faturamento.data_final = dtFim.Value.Date & " 23:59:59"

        r.titulo = "Relatório de Faturamento por Produto / Serviço no período de " & dtIni.Value.Date & _
       " até " & dtFim.Value.Date
        r.DataSource = faturamento.faturamento_produtos(pb, 0)
        f.Relat(r)
        f.Show()
        exporta(r.Document, path)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
    End Sub

End Class