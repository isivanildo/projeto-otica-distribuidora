Public Class objFaturamento
    Dim tt As New DataTable
    Dim tb_produtos As New DataTable
    Dim i, m As Integer
    Dim d As New dados
    Dim _di, _df As String
    Dim total As Double

    Public Sub New()

    End Sub
    Public Sub New(ByVal xd As dados)
        d = xd
    End Sub
    Public Property data_inicial()
        Get
            data_inicial = _di
        End Get
        Set(ByVal value)
            _di = value
        End Set
    End Property
    Public Property data_final
        Get
            data_final = _df
        End Get
        Set(ByVal value)
            _df = value
        End Set
    End Property

    Public Function faturamento_produtos(ByVal pb As Object, ByVal intControle As Int16) As DataTable
        If intControle = 1 Then
            tt = carrega_produtos(_di, _df)
        Else
            tt = carrega_produtos_sem_filial(_di, _df)
        End If

        tb_produtos.Clear()
        tb_produtos = monta_tabela_produto()
        i = 0
        m = tt.Rows.Count
        pb.Minimum = 0
        pb.Maximum = m
        While i < m
            processa_produto(tt.Rows(i))
            pb.Increment(i + 1)
            pb.Value = i
            i = i + 1
        End While

        If intControle = 1 Then
            tt = carrega_servicos()
        Else
            tt = carrega_servicos_sem_filial()
        End If


        i = 0
        m = tt.Rows.Count
        pb.Minimum = 0
        pb.Value = 0
        pb.Maximum = m
        While i < m
            processa_servico(tt.Rows(i))
            pb.Increment(i + 1)
            pb.Value = i
            i = i + 1
        End While
        porcentagem()
        Return tb_produtos
    End Function

    Public Function faturamento_produtos() As DataTable
        tt = carrega_produtos(_di, _df)
        tb_produtos.Clear()
        tb_produtos = monta_tabela_produto()
        i = 0
        m = tt.Rows.Count

        While i < m
            processa_produto(tt.Rows(i))
            i = i + 1
        End While
        tt.Dispose()

        tt = New DataTable
        tt = carrega_servicos()
        i = 0
        m = tt.Rows.Count
        While i < m
            processa_servico(tt.Rows(i))
            i = i + 1
        End While
        porcentagem()
        Return tb_produtos
    End Function

    Private Function carrega_produtos(ByVal di As Date, ByVal df As Date) As DataTable
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT cod_tabela, nome_comercial, id_fabricante, Extras, pdesc, Pedidos, pedidosFin, OS, OSFin " & _
        "FROM  dbo.faturamento_produtos(" & d.pdtm(di) & "," & d.pdtm(df) & ") AS faturamento_produtos_1 " & _
        "where (cod_tabela <> 2 And cod_tabela <> 0 And cod_tabela <> 1 And id_fabricante <> 99) " & _
        "ORDER BY id_fabricante, nome_comercial"
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function

    Private Function carrega_produtos_sem_filial(ByVal di As Date, ByVal df As Date) As DataTable
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT cod_tabela, nome_comercial, id_fabricante, Extras, pdesc, Pedidos, pedidosFin, OS, OSFin " & _
        "FROM  dbo.faturamento_produtos_sem_filial(" & d.pdtm(di) & "," & d.pdtm(df) & ") AS faturamento_produtos_1 " & _
        "where (cod_tabela <> 2 And cod_tabela <> 0 And cod_tabela <> 1 And id_fabricante <> 99) " & _
        "ORDER BY id_fabricante, nome_comercial"
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function

    Private Function monta_tabela_produto() As DataTable
        Dim tb As New DataTable
        tb.Columns.Add("cod_tabela", System.Type.GetType("System.Int32"))
        tb.Columns.Add("Tipo", System.Type.GetType("System.String"))
        tb.Columns.Add("nome", System.Type.GetType("System.String"))
        tb.Columns.Add("preco_compra", System.Type.GetType("System.Double"))
        tb.Columns.Add("extras", System.Type.GetType("System.Int32"))
        tb.Columns.Add("pedidos", System.Type.GetType("System.Int32"))
        tb.Columns.Add("venda_pedidos", System.Type.GetType("System.Double"))
        tb.Columns.Add("OS", System.Type.GetType("System.Int32"))
        tb.Columns.Add("venda_os", System.Type.GetType("System.Double"))
        tb.Columns.Add("totalItens", System.Type.GetType("System.Double"))
        tb.Columns.Add("totalCompra", System.Type.GetType("System.Double"))
        tb.Columns.Add("totalVenda", System.Type.GetType("System.Double"))
        tb.Columns.Add("diferenca", System.Type.GetType("System.Double"))
        tb.Columns.Add("porcTotal", System.Type.GetType("System.Double"))
        tb.Columns.Add("fabricante", System.Type.GetType("System.String"))
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
        rn("fabricante") = Nfabricante(fabricante)
        tb_produtos.Rows.Add(rn)
    End Sub

    Private Function carrega_servicos() As DataTable
        Dim sql As String
        Dim tt As New DataTable
        Dim di, df As Date
        di = _di
        df = _df
        sql = "SELECT  produtos.produto, Sum(pedido_balcao_servicos.quant) as quantidade, " & _
        "Sum(pedido_balcao_servicos.quant * (pedido_balcao_servicos.preco - pedido_balcao_servicos.preco * " & _
        "(pedido_balcao_servicos.desconto / 100))) as venda ,Sum(pedido_balcao_servicos.quant * " & _
        "(pedido_balcao_servicos.compra))/sum(pedido_balcao_servicos.quant) as custo FROM pedido_balcao INNER JOIN " & _
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

    Private Function carrega_servicos_sem_filial() As DataTable
        Dim sql As String
        Dim tt As New DataTable
        Dim di, df As Date
        di = _di
        df = _df
        sql = "SELECT  produtos.produto, Sum(pedido_balcao_servicos.quant) as quantidade, " & _
        "Sum(pedido_balcao_servicos.quant * (pedido_balcao_servicos.preco - pedido_balcao_servicos.preco * " & _
        "(pedido_balcao_servicos.desconto / 100))) as venda ,Sum(pedido_balcao_servicos.quant * " & _
        "(pedido_balcao_servicos.compra))/sum(pedido_balcao_servicos.quant) as custo FROM pedido_balcao INNER JOIN " & _
        "pedido_balcao_servicos ON pedido_balcao.num_pedido = pedido_balcao_servicos.num_pedido AND " & _
        "pedido_balcao.id_filial = pedido_balcao_servicos.id_filial inner join produtos on " & _
        "pedido_balcao_servicos.cod_servico = produtos.cod_produto FULL OUTER JOIN " & _
        "OS ON pedido_balcao.id_filial = OS.id_filial AND pedido_balcao.num_pedido = OS.num_pedido " & _
        "WHERE     (pedido_balcao.data_pedido >=" & d.pdtm(di) & ") AND (pedido_balcao.data_pedido <= " & _
        d.pdtm(df) & ") AND (pedido_balcao.cod_cliente > 1000) AND (NOT pedido_balcao.cod_cliente in (10723,11049,11050)) " & _
        "group by produtos.produto  ORDER BY produtos.produto"
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function

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
    Private Function Nfabricante(ByVal id As Integer) As String
        Dim sql As String
        Dim tt As New DataTable
        sql = "Select fabricante from fabricante where id_fabricante = " & id & ""
        d.carrega_Tabela(sql, tt)
        Try
            Return tt.Rows(0)("fabricante")
        Catch ex As Exception
            Return ""
        End Try
    End Function

End Class
