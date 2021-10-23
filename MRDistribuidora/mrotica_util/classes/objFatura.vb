Public Class objFatura
#Region "Atributos"
    Private _cod_fatura As Integer
    Private _id_filial As Integer
    Private _data_lancamento As Object
    Private _cod_filial_cliente As Integer
    Private _cod_Cliente As Integer
    Private _id_usuario As Integer = UserID
    Private _cod_status_fatura As Integer
    Private _observacao As String
    Private _acrescimos As Double
    Public posicao As Integer = 0
    Public max As Integer
    Public chaveCriterio1, chaveCriterio2 As Object
    Public tb As New DataTable
    Public OrigemSalvar As String = ""
    Private lastPos As Integer = 0
    Private sql As String
    Dim d As New dados
    Private _Historico_Desc_Texto As String
#End Region
#Region "GET SET"
    Public Property cod_fatura()
        Get
            cod_fatura = _cod_fatura
        End Get
        Set(ByVal Value)
            _cod_fatura = Value
        End Set
    End Property
    Public Property id_filial()
        Get
            id_filial = _id_filial
        End Get
        Set(ByVal Value)
            _id_filial = Value
        End Set
    End Property
    Public Property data_lancamento()
        Get
            data_lancamento = _data_lancamento
        End Get
        Set(ByVal Value)
            _data_lancamento = Value
        End Set
    End Property
    Public Property cod_filial_cliente()
        Get
            cod_filial_cliente = _cod_filial_cliente
        End Get
        Set(ByVal Value)
            _cod_filial_cliente = Value
        End Set
    End Property
    Public Property cod_cliente()
        Get
            cod_cliente = _cod_Cliente
        End Get
        Set(ByVal Value)
            _cod_Cliente = Value
        End Set
    End Property
    Public Property id_usuario()
        Get
            id_usuario = _id_usuario
        End Get
        Set(ByVal Value)
            _id_usuario = Value
        End Set
    End Property
    Public Property cod_status_fatura()
        Get
            cod_status_fatura = _cod_status_fatura
        End Get
        Set(ByVal Value)
            _cod_status_fatura = Value
        End Set
    End Property
    Public Property observacao()
        Get
            observacao = _observacao
        End Get
        Set(ByVal Value)
            _observacao = Value
        End Set
    End Property
    Public Property acrescimos()
        Get
            acrescimos = _acrescimos
        End Get
        Set(ByVal Value)
            _acrescimos = Value
        End Set
    End Property
    Public Property Historico_Desc_Texto()
        Get
            Historico_Desc_Texto = _Historico_Desc_Texto
        End Get
        Set(value)
            _Historico_Desc_Texto = value
        End Set
    End Property
#End Region
#Region "Procedimentos"
    Public Sub New()
        Dim sql As String
        sql = "Select * from fatura where cod_fatura = 0"
        Source(sql)
    End Sub
    Public Sub abrir_fatura(ByVal x_cod_fatura As Integer, ByVal x_id_filial As Integer)
        Dim sql As String
        sql = "Select * from fatura where cod_fatura =" & x_cod_fatura & _
        " and id_filial = " & x_id_filial & ""
        Source(sql)
    End Sub
    Public Sub Source(ByVal iSql As String)
        sql = iSql
        Me.refreshData()
    End Sub
    Public Sub refreshData()
        d.carrega_Tabela(sql, tb)
        max = tb.Rows.Count
        Me.primeiro()
    End Sub
    Public Sub Registro(ByVal pos As Integer) 'Move o Registro para a posição indicada
        Dim p As Integer = pos
        If p <= 0 Then p = 0
        If p > max Then p = max
        posicao = p
        If max > 0 Then
            _cod_fatura = tb.Rows(p)("cod_fatura")
            _id_filial = tb.Rows(p)("id_filial")
            _data_lancamento = tb.Rows(p)("data_lancamento")
            _cod_filial_cliente = tb.Rows(p)("cod_filial_cliente")
            _cod_Cliente = tb.Rows(p)("cod_cliente")
            _id_usuario = tb.Rows(p)("id_usuario")
            _cod_status_fatura = tb.Rows(p)("cod_status_fatura")
            _observacao = rdTexto(tb.Rows(p)("observacao"))
        End If
    End Sub
    Public Sub proximo()
        If Me.posicao = Me.max - 1 Then Exit Sub
        Me.Registro(Me.posicao + 1)
    End Sub
    Public Sub anterior()
        Me.Registro(Me.posicao - 1)
    End Sub
    Public Sub ultimo()
        Me.Registro(Me.max - 1)
    End Sub
    Public Sub primeiro()
        Me.Registro(0)
    End Sub
    Public Sub ultima_posicao()
        Me.Registro(lastPos)
    End Sub
    Public Sub editar()
        OrigemSalvar = "Editar"
    End Sub
#End Region
#Region "Funções"
    Public Function novo()
        lastPos = posicao 'guarda a posição do último Registro
        'Inicializa Variáveis
        _cod_fatura = retorna_Chave("cod_fatura", "fatura", " where id_filial = " & confFilial)
        _id_filial = confFilial
        _data_lancamento = Nothing
        _cod_filial_cliente = Nothing
        _cod_Cliente = Nothing
        _id_usuario = UserID
        _cod_status_fatura = 1
        _observacao = Nothing
        OrigemSalvar = "Novo" 'Define o tipo de ação ao salvar
    End Function
    Public Function Salvar() As String
        Dim sql As String
        Dim res As String 'Quantidade de registros afetados
        d.conecta()
        If OrigemSalvar = "Novo" Then
            Try
                sql = "INSERT INTO Fatura " & _
                "(cod_fatura" & _
                ",id_filial" & _
                ",data_lancamento" & _
                ",cod_filial_cliente" & _
                ",cod_cliente" & _
                ",id_usuario,cod_status_fatura" & _
                ",observacao " & _
                ") " & _
                "VALUES " & _
                "(" & _cod_fatura & _
                "," & _id_filial & _
                "," & d.pdtm(_data_lancamento) & _
                "," & _cod_filial_cliente & _
                "," & _cod_Cliente & _
                "," & _id_usuario & _
                "," & _cod_status_fatura & _
                "," & d.PStr(_observacao) & _
                ")"
                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tb.NewRow
            r("cod_fatura") = _cod_fatura
            r("id_filial") = _id_filial
            r("data_lancamento") = rdData(_data_lancamento)
            r("cod_filial_cliente") = cod_filial_cliente
            r("cod_cliente") = _cod_Cliente
            r("id_usuario") = _id_usuario
            r("cod_status_fatura") = _cod_status_fatura
            r("observacao") = rdTexto(_observacao)
            tb.Rows.Add(r)
            max = max + 1
            If max = 1 Then
                posicao = 0
            Else
                posicao = max - 1
            End If
            OrigemSalvar = ""
            Return "OK:" & res & " registro(s) adicionado(s) com sucesso!"
        End If
        If Me.OrigemSalvar = "Editar" Then
            Try
                sql = "UPDATE Fatura SET cod_fatura = " & _cod_fatura & _
                ",id_filial = " & _id_filial & _
                ",data_lancamento = " & d.pdtm(_data_lancamento) & _
                ",cod_filial_cliente = " & _cod_filial_cliente & _
                ",cod_cliente = " & _cod_Cliente & _
                ",id_usuario = " & _id_usuario & _
                ",cod_status_fatura = " & _cod_status_fatura & _
                ",observacao = " & d.PStr(_observacao) & _
                " WHERE cod_fatura = " & _cod_fatura & " and " & _
                "id_filial = " & _id_filial & ""
                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tb.Rows(posicao)
            r("cod_fatura") = _cod_fatura
            r("id_filial") = _id_filial
            r("data_lancamento") = rdData(_data_lancamento)
            r("cod_filial_cliente") = cod_filial_cliente
            r("cod_cliente") = _cod_Cliente
            r("id_usuario") = _id_usuario
            r("cod_status_fatura") = _cod_status_fatura
            r("observacao") = rdTexto(_observacao)
            OrigemSalvar = ""
            Return "OK:" & res & " registro(s) atualizado(s) com sucesso!"
        End If
    End Function
    Public Function deletar(ByVal cod_fat As Integer, ByVal id_fil As Integer)
        Dim sql As String
        Dim res As String
        sql = "Delete from fatura where cod_fatura = " & cod_fat & _
                " and id_filial = " & id_fil & ""
        d.conecta()
        res = d.Comando(sql, True)
        Me.refreshData()
        Me.primeiro()
        Return res & " Registros foram apagados!"
    End Function
    Public Function insere_itens_fatura(ByVal x_num_pedido As Integer, ByVal x_id_filial_pedido As Integer)
        Dim sql As String
        Dim item As Integer
        item = retorna_Chave("item", "fatura_itens", " where cod_fatura = " & Me._cod_fatura & " and id_filial = " & Me._id_filial & "")
        sql = "Insert into fatura_itens(item,cod_fatura,id_filial," & _
        "num_pedido,id_filial_pedido) values(" & _
        item & "," & Me._cod_fatura & "," & Me._id_filial & "," & x_num_pedido & _
        "," & x_id_filial_pedido & ")"
        Return d.Comando(sql, True)
    End Function
    Public Function remover_itens_fatura(ByVal x_num_pedido As Integer, ByVal x_id_filial_pedido As Integer)
        Dim tsql As String
        tsql = "delete from fatura_itens where cod_fatura = " & Me._cod_fatura & " and id_filial = " & Me._id_filial & _
        " and num_pedido = " & x_num_pedido & _
        " and id_filial_pedido = " & x_id_filial_pedido & ""
        Return d.Comando(tsql, True)
    End Function

    Public Function lista_itens_fatura() As DataTable
        Dim sql As String
        Dim tb As New DataTable
        sql = "SELECT fatura_itens.*, " &
        "isnull((SELECT sum(pedido_balcao_itens.quant * pedido_balcao_itens.preco_fat) AS total " &
        "FROM pedido_balcao_itens INNER JOIN " &
        "produtos ON pedido_balcao_itens.cod_produto = produtos.cod_produto " &
        "WHERE (pedido_balcao_itens.num_pedido = fatura_itens.num_pedido) AND " &
        "(pedido_balcao_itens.id_filial = fatura_itens.id_filial_pedido) AND NOT (pedido_balcao_itens.cod_status_item IN (4,5))),0) " &
        "AS Produtos, " &
        "isnull((SELECT sum(pedido_balcao_servicos.quant * pedido_balcao_servicos.preco) AS total " &
        "FROM pedido_balcao_servicos INNER JOIN " &
        "produtos ON pedido_balcao_servicos.cod_servico = produtos.cod_produto " &
        "WHERE (pedido_balcao_servicos.num_pedido = fatura_itens.num_pedido) AND " &
        "(pedido_balcao_servicos.id_filial = fatura_itens.id_filial_pedido and pedido_balcao_servicos.cod_status_servico = 1)),0) " &
        "as servicos, " &
        "(isnull((SELECT sum(pedido_balcao_itens.quant * pedido_balcao_itens.preco) AS total " &
        "FROM pedido_balcao_itens INNER JOIN " &
        "produtos ON pedido_balcao_itens.cod_produto = produtos.cod_produto " &
        "WHERE (pedido_balcao_itens.num_pedido = fatura_itens.num_pedido) AND " &
        "(pedido_balcao_itens.id_filial = fatura_itens.id_filial_pedido) AND NOT (pedido_balcao_itens.cod_status_item IN (4,5))),0) " &
        "+ " &
        "isnull((SELECT sum(pedido_balcao_servicos.quant * pedido_balcao_servicos.preco) " &
        "AS total " &
        "FROM pedido_balcao_servicos INNER JOIN " &
        "produtos ON pedido_balcao_servicos.cod_servico = produtos.cod_produto " &
        "WHERE (pedido_balcao_servicos.num_pedido = fatura_itens.num_pedido) AND " &
        "(pedido_balcao_servicos.id_filial = fatura_itens.id_filial_pedido and pedido_balcao_servicos.cod_status_servico = 1)),0)) " &
        "as Total " &
        ",(SELECT pedido_balcao.data_pedido FROM pedido_balcao " &
        " where pedido_balcao.num_pedido = fatura_itens.num_pedido " &
        "AND pedido_balcao.id_filial = fatura_itens.id_filial_pedido) as data_pedido, " &
        "(SELECT pedido_balcao.valor_devolvido  FROM pedido_balcao  where " &
        "pedido_balcao.num_pedido = fatura_itens.num_pedido AND pedido_balcao.id_filial = fatura_itens.id_filial_pedido) as valor_devolvido, " &
        " (isnull((SELECT sum(pedido_balcao_itens.quant * pedido_balcao_itens.preco) AS total " &
        "FROM pedido_balcao_itens INNER JOIN produtos ON pedido_balcao_itens.cod_produto = produtos.cod_produto WHERE " &
        "(pedido_balcao_itens.num_pedido = fatura_itens.num_pedido) AND (pedido_balcao_itens.id_filial = fatura_itens.id_filial_pedido) AND NOT (pedido_balcao_itens.cod_status_item IN (4,5))),0) + " &
        "isnull((SELECT sum(pedido_balcao_servicos.quant * pedido_balcao_servicos.preco) AS total " &
        " FROM pedido_balcao_servicos INNER JOIN produtos ON pedido_balcao_servicos.cod_servico = produtos.cod_produto WHERE " &
        "(pedido_balcao_servicos.num_pedido = fatura_itens.num_pedido) AND (pedido_balcao_servicos.id_filial = fatura_itens.id_filial_pedido and " &
        "pedido_balcao_servicos.cod_status_servico = 1)),0)) -  isnull((SELECT pedido_balcao.valor_devolvido  FROM pedido_balcao  where " &
        "pedido_balcao.num_pedido = fatura_itens.num_pedido AND pedido_balcao.id_filial = fatura_itens.id_filial_pedido),0) as TotalGeral " &
        "FROM  fatura_itens " &
        "where fatura_itens.cod_fatura =  " & Me._cod_fatura &
        " and fatura_itens.id_filial = " & Me._id_filial & " ORDER BY fatura_itens.item"
        d.carrega_Tabela(sql, tb)
        Return tb
    End Function

    Public Function lista_itens_fatura_teste() As DataTable
        Dim sql As String
        Dim tb As New DataTable
        sql = "SELECT fatura_itens.*, " &
        "isnull((SELECT sum(pedido_balcao_itens.quant * pedido_balcao_itens.preco) AS total " &
        "FROM pedido_balcao_itens INNER JOIN " &
        "produtos ON pedido_balcao_itens.cod_produto = produtos.cod_produto " &
        "WHERE (pedido_balcao_itens.num_pedido = fatura_itens.num_pedido) AND " &
        "(pedido_balcao_itens.id_filial = fatura_itens.id_filial_pedido) AND NOT (pedido_balcao_itens.cod_status_item IN (4,5))),0) " &
        "AS Produtos, " &
        "isnull((SELECT sum(pedido_balcao_servicos.quant * pedido_balcao_servicos.preco) AS total " &
        "FROM pedido_balcao_servicos INNER JOIN " &
        "produtos ON pedido_balcao_servicos.cod_servico = produtos.cod_produto " &
        "WHERE (pedido_balcao_servicos.num_pedido = fatura_itens.num_pedido) AND " &
        "(pedido_balcao_servicos.id_filial = fatura_itens.id_filial_pedido and pedido_balcao_servicos.cod_status_servico = 1)),0) " &
        "as servicos, " &
        "(isnull((SELECT sum(pedido_balcao_itens.quant * pedido_balcao_itens.preco) AS total " &
        "FROM pedido_balcao_itens INNER JOIN " &
        "produtos ON pedido_balcao_itens.cod_produto = produtos.cod_produto " &
        "WHERE (pedido_balcao_itens.num_pedido = fatura_itens.num_pedido) AND " &
        "(pedido_balcao_itens.id_filial = fatura_itens.id_filial_pedido) AND NOT (pedido_balcao_itens.cod_status_item IN (4,5))),0) " &
        "+ " &
        "isnull((SELECT sum(pedido_balcao_servicos.quant * pedido_balcao_servicos.preco) " &
        "AS total " &
        "FROM pedido_balcao_servicos INNER JOIN " &
        "produtos ON pedido_balcao_servicos.cod_servico = produtos.cod_produto " &
        "WHERE (pedido_balcao_servicos.num_pedido = fatura_itens.num_pedido) AND " &
        "(pedido_balcao_servicos.id_filial = fatura_itens.id_filial_pedido and pedido_balcao_servicos.cod_status_servico = 1)),0)) " &
        "as Total " &
        ",(SELECT pedido_balcao.data_pedido FROM pedido_balcao " &
        " where pedido_balcao.num_pedido = fatura_itens.num_pedido " &
        "AND pedido_balcao.id_filial = fatura_itens.id_filial_pedido) as data_pedido, " &
        "(SELECT pedido_balcao.valor_devolvido  FROM pedido_balcao  where " &
        "pedido_balcao.num_pedido = fatura_itens.num_pedido AND pedido_balcao.id_filial = fatura_itens.id_filial_pedido) as valor_devolvido, " &
        " (isnull((SELECT sum(pedido_balcao_itens.quant * pedido_balcao_itens.preco) AS total " &
        "FROM pedido_balcao_itens INNER JOIN produtos ON pedido_balcao_itens.cod_produto = produtos.cod_produto WHERE " &
        "(pedido_balcao_itens.num_pedido = fatura_itens.num_pedido) AND (pedido_balcao_itens.id_filial = fatura_itens.id_filial_pedido) AND NOT (pedido_balcao_itens.cod_status_item IN (4,5))),0) + " &
        "isnull((SELECT sum(pedido_balcao_servicos.quant * pedido_balcao_servicos.preco) AS total " &
        " FROM pedido_balcao_servicos INNER JOIN produtos ON pedido_balcao_servicos.cod_servico = produtos.cod_produto WHERE " &
        "(pedido_balcao_servicos.num_pedido = fatura_itens.num_pedido) AND (pedido_balcao_servicos.id_filial = fatura_itens.id_filial_pedido and " &
        "pedido_balcao_servicos.cod_status_servico = 1)),0)) -  isnull((SELECT pedido_balcao.valor_devolvido  FROM pedido_balcao  where " &
        "pedido_balcao.num_pedido = fatura_itens.num_pedido AND pedido_balcao.id_filial = fatura_itens.id_filial_pedido),0) as TotalGeral " &
        "FROM  fatura_itens " &
        "where fatura_itens.cod_fatura =  " & Me._cod_fatura &
        " and fatura_itens.id_filial = " & Me._id_filial & " ORDER BY totalgeral"
        d.carrega_Tabela(sql, tb)
        Return tb
    End Function

    Public Function distribui_desconto_caixa(ByVal x_t_desc As Double)
        Dim tItens As New DataTable
        Dim i, m As Integer
        Dim t_pedido, desc As Double
        Dim p As New objPedidoBalcao
        tItens = lista_itens_fatura()
        i = 0
        m = tItens.Rows.Count
        While i < m
            p.carrega_pedido(tItens.Rows(i)("num_pedido"), tItens.Rows(i)("id_filial_pedido"))
            t_pedido = p.total_servicos + p.total_itens
            desc = calcula_desconto_distribuicao(Me.total_fatura("total"), x_t_desc, t_pedido)
            p.distribui_descontos(desc)
            i = i + 1
        End While
    End Function
    Public Function calcula_desconto_distribuicao(ByVal xTotal_Fatura As Double, ByVal xTotalDesc As Double, ByVal xValPedido As Double) As Double
        Dim res As Double
        res = ((xValPedido * xTotalDesc) / xTotal_Fatura)
        Return res
    End Function
    Public Function valor_itens_pacote() As Double
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "SELECT round(sum((pedido_balcao_itens.preco * pedido_balcao_itens.quant)),2) as Total FROM fatura_itens INNER JOIN " & _
        "pedido_balcao_itens ON fatura_itens.num_pedido = pedido_balcao_itens.num_pedido " & _
        "and fatura_itens.id_filial = pedido_balcao_itens.id_filial " & _
        "WHERE (pedido_balcao_itens.Pacote = 'S') AND (NOT pedido_balcao_itens.cod_status_item in (4,5)) " & _
        "AND (fatura_itens.id_filial = " & _id_filial & ") AND " & _
        "(fatura_itens.cod_fatura = " & Me._cod_fatura & ")"
        d.carrega_Tabela(tsql, tt)
        Try
            Return wrNum(tt.Rows(0)("total"))
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Public Function valor_servicos_pacote() As Double
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "SELECT round(sum((pedido_balcao_servicos.preco* pedido_balcao_servicos.quant)),2) as Total FROM fatura_itens INNER JOIN  " & _
        "pedido_balcao_servicos ON fatura_itens.num_pedido = pedido_balcao_servicos.num_pedido " & _
        "and fatura_itens.id_filial = pedido_balcao_servicos.id_filial " & _
        "WHERE (pedido_balcao_servicos.Pacote = 'S') AND (fatura_itens.id_filial = " & _id_filial & ") AND " & _
        "(fatura_itens.cod_fatura = " & Me._cod_fatura & ")"
        d.carrega_Tabela(tsql, tt)
        Try
            Return wrNum(tt.Rows(0)("total"))
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Public Function total_c_acr_e_desc() As Double
        Return total_fatura("total") + Math.Round(acrescimo_fatura(), 2) - Math.Round(desconto_fatura(), 2)
    End Function
    Public Function pago() As Double
        Dim lanc As New objLancamentos
        Return Math.Round(lanc.total_rec_fatura(_cod_fatura, _id_filial), 2)
    End Function
    Public Function a_pagar() As Double
        Return (total_c_acr_e_desc()) - (pago())
    End Function
    Public Function total_fatura() As DataRow
        Dim r As DataRow
        Dim sql As String
        Dim tTotal, tt As New DataTable
        Dim dblServicos, dblProdutos, dblTotal As Double
        'Prepara Tabela para os resultados
        tTotal.Columns.Add("Produtos")
        tTotal.Columns.Add("servicos")
        tTotal.Columns.Add("Total")

        'Produtos
        sql = "SELECT isnull(SUM(pedido_balcao_itens.quant * pedido_balcao_itens.preco),0) AS Produtos " & _
        "FROM fatura_itens INNER JOIN pedido_balcao_itens ON fatura_itens.num_pedido = " & _
        "pedido_balcao_itens.num_pedido AND fatura_itens.id_filial_pedido = " & _
        "pedido_balcao_itens.id_filial WHERE " & _
        "(fatura_itens.cod_fatura = " & Me._cod_fatura & ") AND " & _
        "(fatura_itens.id_filial = " & Me._id_filial & " AND NOT (pedido_balcao_itens.cod_status_item in (4,5)))"
        d.carrega_Tabela(sql, tt)
        dblProdutos = rdNum(tt.Rows(0)("Produtos"))

        'Servicos
        tt.DataSet.Clear() 'Limpa a tabela temporária para receber novos valores
        sql = "SELECT round(SUM(pedido_balcao_servicos.quant * pedido_balcao_servicos.preco),2) as Servicos " & _
        "FROM fatura_itens INNER JOIN  pedido_balcao_servicos ON fatura_itens.num_pedido = " & _
        "pedido_balcao_servicos.num_pedido AND  fatura_itens.id_filial_pedido = " & _
        "pedido_balcao_servicos.id_filial WHERE (fatura_itens.cod_fatura = " & Me._cod_fatura & ")" & _
        "AND (fatura_itens.id_filial = " & Me._id_filial & " and pedido_balcao_servicos.cod_status_servico = 1" & ")"
        d.carrega_Tabela(sql, tt)
        dblServicos = rdNum(tt.Rows(0)("Servicos"))

        'Total
        dblTotal = dblProdutos + dblServicos

        'Monta resultado
        r = tTotal.NewRow
        r("Produtos") = dblProdutos
        r("Servicos") = dblServicos
        r("total") = dblTotal
        tTotal.Rows.Add(r)
        If tTotal.Rows.Count > 0 Then Return tTotal.Rows(0) Else Return Nothing
    End Function
    Public Function Total_Servicos_DescCaixa()
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "SELECT round(SUM(pedido_balcao_servicos.quant * (pedido_balcao_servicos.preco -  " &
        "pedido_balcao_servicos.preco * pedido_balcao_servicos.desconto / 100)),2) as Servicos  " &
        "FROM fatura_itens INNER JOIN  pedido_balcao_servicos ON fatura_itens.num_pedido =  " &
        "pedido_balcao_servicos.num_pedido AND  fatura_itens.id_filial_pedido =  " &
        "pedido_balcao_servicos.id_filial WHERE (fatura_itens.cod_fatura = " & _cod_fatura & ") " &
        " AND (fatura_itens.id_filial =" & _id_filial & ")"
        d.carrega_Tabela(tsql, tt)
        If tt.Rows.Count = 1 Then
            Return tt.Rows(0)(0)
        Else
            Return 0
        End If
    End Function
    Public Function Total_Servicos_DescCaixa(ByVal Filtro As DataTable)
        Dim tsql, sqlFiltro As String
        Dim tt As New DataTable
        tsql = "SELECT round(SUM(pedido_balcao_servicos.quant * (pedido_balcao_servicos.preco -  " &
        "pedido_balcao_servicos.preco * pedido_balcao_servicos.desconto / 100)),2) as Servicos  " &
        "FROM fatura_itens INNER JOIN  pedido_balcao_servicos ON fatura_itens.num_pedido =  " &
        "pedido_balcao_servicos.num_pedido AND  fatura_itens.id_filial_pedido =  " &
        "pedido_balcao_servicos.id_filial "
        For Each r As DataRow In Filtro.Rows
            If sqlFiltro = "" Then
                sqlFiltro = " Where (fatura_itens.cod_fatura = " & r("cod_fatura") & _
                " and fatura_itens.id_filial = " & r("id_filial") & ")"
            Else
                sqlFiltro = sqlFiltro & " or (fatura_itens.cod_fatura = " & r("cod_fatura") & _
                " and fatura_itens.id_filial = " & r("id_filial") & ")"
            End If
        Next
        tsql = tsql & sqlFiltro
        d.carrega_Tabela(tsql, tt)
        If tt.Rows.Count = 1 Then
            Return tt.Rows(0)(0)
        Else
            Return 0
        End If
    End Function
    Public Function Valor_recebido_credito_pacote() As Double
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "SELECT  sum(lancamentos.valor) as total FROM lancamentos INNER JOIN  " & _
        "Pagamentos_fatura ON lancamentos.cod_lancamento =  " & _
        "Pagamentos_fatura.cod_lancamento AND lancamentos.id_filial = Pagamentos_fatura.id_filial " & _
        "INNER JOIN forma_pagamento ON lancamentos.cod_forma_pagamento =  " & _
        " forma_pagamento.cod_forma_pagamento WHERE (Pagamentos_fatura.cod_fatura = " & Me._cod_fatura & ")" & _
        " AND (lancamentos.id_filial = " & Me._id_filial & ") " & _
        " and (lancamentos.cod_forma_pagamento = 9)" & _
        " and (lancamentos.cod_status_lancamento = 1)"
        d.carrega_Tabela(tsql, tt)
        Try
            Return tt.Rows(0)("total")
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Public Function valor_restante_pacote()
        Dim res As Double
        res = (valor_itens_pacote() + valor_servicos_pacote()) - (Valor_recebido_credito_pacote())
        Return Math.Round(res, 2, MidpointRounding.AwayFromZero)
    End Function
    Public Function inserir_pagamento_fatura()

    End Function
    Public Function Deletar_pagamento(ByVal cod_pag As Integer) As String
        Dim sql As String
        sql = "Delete from pagamentos_fatura where cod_pagamento_fatura = " & cod_pag & _
        " and cod_fatura = " & _cod_fatura & ""
        Return d.Comando(sql, True)
    End Function
    Public Function fatura_pedido(ByVal x_pedido As Long, ByVal x_filial_pedido As Integer) As Long()
        'Retorna um array contendo na primeira posição a filial da fatura e 
        'na segunda o número da fatura.
        Dim r(2) As Long
        Dim sql As String
        Dim tt As New DataTable
        sql = "Select cod_fatura,id_filial from fatura_itens where num_pedido = " & _
        x_pedido & " and id_filial_pedido = " & x_filial_pedido & ""
        d.carrega_Tabela(sql, tt)
        If tt.Rows.Count = 1 Then
            r(0) = tt.Rows(0)("id_filial")
            r(1) = tt.Rows(0)("cod_fatura")
        End If
        Return r
    End Function
#Region "Descontos"
    Public Function listaDescontos() As DataTable
        Dim sql As String
        Dim tt As New DataTable
        sql = "Select * from descontos_fatura where cod_fatura = " & Me._cod_fatura & " and " & _
        " id_filial = " & Me._id_filial & ""
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function listaDescontosDia(ByVal dia As Date, ByVal filial As Integer) As DataTable
        Dim sql As String
        Dim di, df As Date
        Dim tt As New DataTable
        di = dia.Date & " 00:00:00"
        df = dia.Date & " 23:59:59"
        sql = "SELECT descontos_fatura.cod_fatura, descontos_fatura.descricao, descontos_fatura.valor, " & _
        "Usuarios.NOME as usuario, descontos_fatura.data FROM descontos_fatura INNER JOIN " & _
        "Usuarios ON descontos_fatura.cod_usuario = Usuarios.cod_usuario " & _
        "WHERE (descontos_fatura.data >= " & d.pdtm(di) & ") and (descontos_fatura.data <= " & d.pdtm(df) & ")" & _
        " and (descontos_fatura.id_filial = " & filial & ")"
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function desconto_fatura() As Double
        Dim sql As String
        Dim tt As New DataTable
        sql = "Select sum(valor) as total from descontos_fatura where cod_fatura = " & Me._cod_fatura & " and " & _
        " id_filial = " & Me._id_filial & ""
        d.carrega_Tabela(sql, tt)
        If tt.Rows.Count = 0 Then
            Return 0
        Else
            Return rdNum(tt.Rows(0)("total"))
        End If
    End Function
    Public Function insere_desconto(ByVal x_valor As Double, ByVal x_cod_usuario As Integer, ByVal xDesc As String) As String
        Dim sql As String
        sql = "INSERT INTO descontos_fatura(cod_desconto_fatura,cod_fatura,id_filial " & _
           ",valor,cod_usuario,descricao,data) VALUES( " & _
           retorna_Chave("cod_desconto_fatura", "descontos_fatura", "") & _
           "," & Me._cod_fatura & _
           "," & Me._id_filial & _
           "," & d.cdin(x_valor) & _
           "," & x_cod_usuario & _
           "," & d.PStr(xDesc) & _
           "," & d.pdtm(Now) & _
           ")"
        Return d.Comando(sql, True)
    End Function
    Public Function deleta_desconto(ByVal x_cod_desconto_fatura As Integer) As String
        Dim sql As String
        sql = "Delete from descontos_fatura where cod_desconto_fatura = " & x_cod_desconto_fatura & _
        " and cod_fatura = " & Me._cod_fatura & " and id_filial = " & Me._id_filial & ""
        Return d.Comando(sql, True)
    End Function
#End Region
#Region "Acrescimos"
    Public Function listaAcrescimos() As DataTable
        Dim sql As String
        Dim tt As New DataTable
        sql = "Select * from acrescimos_fatura where cod_fatura_cred = " & Me._cod_fatura & " and " & _
        " id_filial = " & Me._id_filial & " and tipo = 'F'"
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function listaAcrescimosDia(ByVal dia As Date) As DataTable
        Dim sql As String
        Dim di, df As Date
        Dim tt As New DataTable
        di = dia.Date & " 00:00:00"
        df = dia.Date & " 23:59:59"
        sql = "SELECT acrescimos_fatura.cod_fatura_cred, acrescimos_fatura.descricao, acrescimos_fatura.valor, " & _
        "Usuarios.NOME as usuario, acrescimos_fatura.data FROM acrescimos_fatura INNER JOIN " & _
        "Usuarios ON acrescimos_fatura.cod_usuario = Usuarios.cod_usuario " & _
        "WHERE (acrescimos_fatura.data >= " & d.pdtm(di) & ") and (acrescimos_fatura.data <= " & d.pdtm(df) & ")"
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function acrescimo_fatura() As Double
        Dim sql As String
        Dim tt As New DataTable
        sql = "Select sum(valor) as total from acrescimos_fatura where cod_fatura_cred = " & Me._cod_fatura & " and " & _
        " id_filial = " & Me._id_filial & " and tipo = 'F'"
        d.carrega_Tabela(sql, tt)
        If tt.Rows.Count = 0 Then
            Return 0
        Else
            Return rdNum(tt.Rows(0)("total"))
        End If
    End Function
    Public Function insere_acrescimo(ByVal x_valor As Double, ByVal x_cod_usuario As Integer, ByVal xDesc As String) As String
        Dim sql As String
        sql = "INSERT INTO acrescimos_fatura(cod_acrescimo_fatura,cod_fatura_cred,id_filial " & _
           ",valor,cod_usuario,descricao,data,tipo) VALUES( " & _
           retorna_Chave("cod_acrescimo_fatura", "acrescimos_fatura", "") & _
           "," & Me._cod_fatura & _
           "," & Me._id_filial & _
           "," & d.cdin(x_valor) & _
           "," & x_cod_usuario & _
           "," & d.PStr(xDesc) & _
           "," & d.pdtm(Now) & _
           ",'F')"
        Return d.Comando(sql, True)
    End Function
    Public Function deleta_acrescimo(ByVal x_cod_acrescimo_fatura As Integer) As String
        Dim sql As String
        sql = "Delete from acrescimos_fatura where cod_acrescimo_fatura = " & x_cod_acrescimo_fatura & _
        " and cod_fatura_cred = " & Me._cod_fatura & " and id_filial = " & Me._id_filial & ""
        Return d.Comando(sql, True)
    End Function
#End Region
#Region "NFe"
    Public Function Lista_NFe_b() As DataTable
        Dim tsql As String
        Dim tt As New DataTable
        Dim tRet As New DataTable
        tsql = "SELECT cod_tabela, nome_lente, " &
"(SUM(quant)) as quantidade,((SUM(preco_desconto*quant))/SUM(quant)) as vunit " &
",(SUM(preco_desconto*quant)) as total " &
"FROM lista_itens_fatura_nfe(" & _cod_fatura & "," & _id_filial & ") AS lista " &
"GROUP BY cod_tabela, nome_lente"
        d.carrega_Tabela(tsql, tt)
        ' monta_tabela_nfe(tRet, tt)
        Return tRet
    End Function
    Public Function Lista_NFe(ByVal total_fatura As Double) As DataTable
        Dim tsql As String
        Dim tt As New DataTable
        Dim tRet As New DataTable
        tsql = "SELECT cod_tabela ,nome_comercial , " &
        "(SUM(quant)) as quantidade,((SUM(preco_desconto*quant))/SUM(quant)) as vunit " &
        ",(SUM(preco_desconto*quant)) as total  " &
        "FROM lista_itens_fatura_nfe_tabela() AS lista " &
        "where cod_fatura =  " & _cod_fatura &
        " and id_filial = " & _id_filial &
        " GROUP BY COD_tabela, nome_comercial ORDER BY nome_comercial"
        d.carrega_Tabela(tsql, tt)
        monta_tabela_nfe(tRet, tt, total_fatura)
        Return tRet
    End Function
    Public Function Lista_NFe_faturas(ByVal faturas As DataTable) As DataTable
        Dim tsql, sqlMid, sqlEnd As String
        Dim tt As New DataTable
        Dim tRet As New DataTable
        tsql = "SELECT cod_tabela ,nome_comercial , " &
        "(SUM(quant)) as quantidade,((SUM(preco_desconto*quant))/SUM(quant)) as vunit " &
        ",(SUM(preco_desconto*quant)) as total  " &
        "FROM lista_itens_faturas_nfe_tabela() AS lista "
        sqlEnd = "GROUP BY COD_tabela, nome_comercial ORDER BY nome_comercial"
        For Each r As DataRow In faturas.Rows
            If sqlMid = "" Then
                sqlMid = " Where (cod_fatura = " & r("cod_fatura") & _
                " and id_filial = " & r("id_filial") & ")"
            Else
                sqlMid = sqlMid & " or (cod_fatura = " & r("cod_fatura") & _
                " and id_filial = " & r("id_filial") & ")"
            End If
        Next
        tsql = tsql & sqlMid & sqlEnd
        If faturas.Rows.Count = 0 Then
            tsql = ""
        End If
        d.carrega_Tabela(tsql, tt)
        monta_tabela_nfe(tRet, tt, faturas)
        Return tRet
    End Function
    Private Sub monta_tabela_nfe(ByRef tabRet As DataTable, ByVal tabIn As DataTable, ByVal totalFatura As Double)
        Dim serv As Double = rdNum(Total_Servicos_DescCaixa())
        Dim nr As DataRow
        Dim i As Integer = 0
        Dim totalSoma, dif As Double
        tabRet.Columns.Add("cod_tabela")
        tabRet.Columns.Add("produto")
        tabRet.Columns.Add("quant")
        tabRet.Columns.Add("vunit")
        tabRet.Columns.Add("vtotal")
        If serv > 0 Then
            serv = serv / tabIn.Rows.Count
            For Each r As DataRow In tabIn.Rows
                nr = tabRet.NewRow
                nr("cod_tabela") = r("cod_tabela")
                nr("produto") = r("nome_comercial")
                nr("quant") = r("quantidade")
                nr("vunit") = Math.Round((r("total") + serv) / r("quantidade"), 2)
                nr("vtotal") = nr("vunit") * nr("quant")
                totalSoma = totalSoma + nr("vtotal")
                If i = tabIn.Rows.Count - 1 Then
                    dif = totalFatura - totalSoma
                    nr("vtotal") = nr("vtotal") + dif
                    nr("vunit") = nr("vtotal") / nr("quant")
                End If
                tabRet.Rows.Add(nr)
                i = i + 1
            Next
        Else
            For Each r As DataRow In tabIn.Rows
                nr = tabRet.NewRow
                nr("cod_tabela") = r("cod_tabela")
                nr("produto") = r("nome_comercial")
                nr("quant") = r("quantidade")
                nr("vtotal") = Math.Round(r("total"), 2)
                nr("vunit") = Math.Round(r("vunit"), 2)
                tabRet.Rows.Add(nr)
            Next
        End If
    End Sub
    Private Sub monta_tabela_nfe(ByRef tabRet As DataTable, ByVal tabIn As DataTable, ByVal filtro As DataTable)
        Dim serv As Double = rdNum(Total_Servicos_DescCaixa(filtro))
        Dim nr As DataRow
        tabRet.Columns.Add("cod_tabela")
        tabRet.Columns.Add("produto")
        tabRet.Columns.Add("quant")
        tabRet.Columns.Add("vunit")
        tabRet.Columns.Add("vtotal")
        If serv > 0 Then
            serv = serv / tabIn.Rows.Count
            For Each r As DataRow In tabIn.Rows
                nr = tabRet.NewRow
                nr("cod_tabela") = r("cod_tabela")
                nr("produto") = r("nome_comercial")
                nr("quant") = r("quantidade")
                nr("vtotal") = r("total") + serv
                nr("vunit") = (r("total") + serv) / r("quantidade")
                tabRet.Rows.Add(nr)
            Next
        Else
            For Each r As DataRow In tabIn.Rows
                nr = tabRet.NewRow
                nr("cod_tabela") = r("cod_tabela")
                nr("produto") = r("nome_comercial")
                nr("quant") = r("quantidade")
                nr("vtotal") = r("total")
                nr("vunit") = r("vunit")
                tabRet.Rows.Add(nr)
            Next
        End If
    End Sub
    Public Function resumo_nfe_periodo(ByVal inicial As Date, ByVal final As Date) As DataTable
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "select  nf.Numero,nf.Emissao,cliente.razao_social,cliente.nome_cliente, " & _
        "nf.Valor,nf.V_Icms as ICMS from NF inner join cliente on cliente.cod_cliente = nf.Cliente " & _
        "where nf.Emissao  >= " & d.pdtm(inicial) & _
        " and nf.Emissao <= " & d.pdtm(final) & _
        " and Situacao = 'N' order by emissao"
        d.carrega_Tabela(tsql, tt)
        Return tt
    End Function
#End Region
#End Region
End Class
