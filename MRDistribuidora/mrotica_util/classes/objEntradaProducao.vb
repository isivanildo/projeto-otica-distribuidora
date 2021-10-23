Public Class objEntradaProducao
#Region "Atributos"
    Private _cod_movimento As Integer
    Private _id_filial_movimento As Integer
    Private _num_pedido As Integer
    Private _id_filial_pedido As Integer

    Private _cod_natureza As Integer
    Private _data As Object
    Private _doc As String
    Private _id_usuario As Integer
    Private _concluido As String
    Public posicao As Integer = 0
    Public max As Integer
    Public tb As New DataTable
    Public OrigemSalvar As String = ""
    Private lastPos As Integer = 0
    Private sql As String
    Dim d As New dados
    Dim conf As New config
#End Region
#Region "GET SET"
    Public Property cod_movimento()
        Get
            cod_movimento = _cod_movimento
        End Get
        Set(ByVal Value)
            _cod_movimento = Value
        End Set
    End Property
    Public Property id_filial_movimento()
        Get
            id_filial_movimento = _id_filial_movimento
        End Get
        Set(ByVal Value)
            _id_filial_movimento = Value
        End Set
    End Property
    Public Property id_filial_Pedido()
        Get
            id_filial_Pedido = _id_filial_pedido
        End Get
        Set(ByVal Value)
            _id_filial_pedido = Value
        End Set
    End Property
    Public Property num_pedido()
        Get
            num_pedido = _num_pedido
        End Get
        Set(ByVal Value)
            _num_pedido = Value
        End Set
    End Property
    Public Property cod_natureza()
        Get
            cod_natureza = _cod_natureza
        End Get
        Set(ByVal Value)
            _cod_natureza = Value
        End Set
    End Property
    Public Property data()
        Get
            data = _data
        End Get
        Set(ByVal Value)
            _data = Value
        End Set
    End Property
    Public Property doc()
        Get
            doc = _doc
        End Get
        Set(ByVal Value)
            _doc = Value
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
    Public Property concluido()
        Get
            concluido = _concluido
        End Get
        Set(ByVal Value)
            _concluido = Value
        End Set
    End Property
#End Region
#Region "Procedimentos"
    Public Sub New()
        Dim sql As String
        sql = "SELECT movimentomaster.cod_movimento, movimentomaster.id_filial, " & _
        "movimentomaster.cod_natureza, movimentomaster.data, " & _
        "movimentomaster.doc, movimentomaster.concluido, " & _
        "movimentomaster.id_usuario, producao.num_pedido, " & _
        "producao.id_filial_pedido " & _
        "FROM movimentomaster INNER JOIN " & _
        "pedido_producao_entrada as producao ON movimentomaster.cod_movimento = " & _
        "producao.cod_movimento  AND movimentomaster.id_filial = producao.id_filial_movimento " & _
        "WHERE PRODUCAO.num_pedido = 0"
        Source(sql)
    End Sub
    
    Public Sub carrega_producao(ByVal x_num_pedido As Integer, ByVal x_id_filial As Integer)
        Dim sql As String
        sql = "SELECT movimentomaster.cod_movimento, movimentomaster.id_filial, " & _
        "movimentomaster.cod_natureza, movimentomaster.data, " & _
        "movimentomaster.doc, movimentomaster.concluido, " & _
        "movimentomaster.id_usuario, producao.num_pedido, " & _
        "producao.id_filial_pedido " & _
        "FROM movimentomaster INNER JOIN " & _
        "pedido_producao_entrada as producao ON movimentomaster.cod_movimento = " & _
        "producao.cod_movimento  AND movimentomaster.id_filial = producao.id_filial_movimento " & _
        "WHERE PRODUCAO.num_pedido = " & x_num_pedido & _
        " and producao.id_filial_pedido = " & x_id_filial & ""
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
            _cod_movimento = tb.Rows(p)("cod_movimento")
            _id_filial_movimento = tb.Rows(p)("id_filial")
            _id_filial_pedido = tb.Rows(p)("id_filial_pedido")
            _num_pedido = tb.Rows(p)("num_pedido")
            _cod_natureza = tb.Rows(p)("cod_natureza")
            _data = tb.Rows(p)("data")
            _doc = tb.Rows(p)("doc")
            _id_usuario = tb.Rows(p)("id_usuario")
            _concluido = rdTexto(tb.Rows(p)("concluido"))
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
        _cod_movimento = retorna_Chave("cod_movimento", "movimentomaster", " where id_filial = " & conf.Filial)
        ' _cod_compra = retorna_Chave("cod_compra", "compras", "where id_filial = " & confFilial)
        _id_filial_movimento = conf.Filial
        _id_filial_pedido = Nothing
        _cod_natureza = 14
        _data = Nothing
        _doc = Nothing
        _id_usuario = UserID
        OrigemSalvar = "Novo" 'Define o tipo de ação ao salvar
    End Function
    Public Function Salvar() As String
        Dim sql As String
        Dim res As String 'Quantidade de registros afetados
        Dim trans As New objSqlTrans
        d.conecta()
        If OrigemSalvar = "Novo" Then
            Try
                sql = "INSERT INTO movimentomaster " & _
                "(cod_movimento,cod_natureza,id_filial,data,doc,id_usuario) " & _
                "VALUES ( " & _
                _cod_movimento & _
                "," & _cod_natureza & _
                "," & _id_filial_movimento & _
                "," & d.pdtm(_data) & _
                "," & d.PStr(_doc) & _
                "," & _id_usuario & ")"
                trans.insere_instrucao(sql)
                sql = "INSERT INTO pedido_producao_entrada (cod_movimento, " & _
                "id_filial_movimento,num_pedido,id_filial_pedido) " & _
                "VALUES (" & _cod_movimento & "," & _id_filial_movimento & "," & _
                _num_pedido & "," & _id_filial_pedido & ")"
                trans.insere_instrucao(sql)
                res = d.executa_transaction(trans.instrucoes, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tb.NewRow
            r("cod_movimento") = _cod_movimento
            r("id_filial") = _id_filial_movimento
            r("id_filial_Pedido") = _id_filial_pedido
            r("num_pedido") = _num_pedido
            r("cod_natureza") = _cod_natureza
            r("data") = rdData(_data)
            r("doc") = rdTexto(_doc)
            r("id_usuario") = _id_usuario
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
                sql = "UPDATE movimentomaster " & _
                "cod_natureza = " & _cod_natureza & _
                ",data = " & d.pdtm(_data) & _
                ",doc = " & d.PStr(_doc) & _
                ",id_usuario = " & _id_usuario & _
                ",concluido = " & d.PStr(_concluido) & _
                 " WHERE cod_movimento = " & _cod_movimento & _
                " and id_filial = " & _id_filial_movimento & ""
                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tb.Rows(posicao)
            r("cod_movimento") = _cod_movimento
            r("id_filial") = _id_filial_movimento
            r("id_filial_Pedido") = _id_filial_pedido
            r("num_pedido") = _num_pedido
            r("cod_natureza") = _cod_natureza
            r("data") = rdData(_data)
            r("doc") = rdTexto(_doc)
            r("id_usuario") = _id_usuario
            OrigemSalvar = ""
            Return "OK:" & res & " registro(s) atualizado(s) com sucesso!"
        End If
    End Function
    Public Function deletar(ByVal id_mov As Integer, ByVal id_fil As Integer)
        Dim cmd As New SqlClient.SqlCommand
        Dim res As Integer
        d.conecta()
        cmd.Connection = d.con
        cmd.CommandText = "Delete from movimentomaster where cod_movimento = " & id_mov & _
        " and id_filial = " & id_fil & ""
        Try
            res = cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Me.refreshData()
        Me.primeiro()
        Return res & " Registros foram apagados!"
    End Function
    Public Function existe_entrada_producao(ByVal x_num_pedido As Integer, ByVal x_id_filial As Integer) As Boolean
        Dim sql As String
        Dim tb_prod As New DataTable
        sql = "SELECT movimentomaster.cod_natureza, movimentomaster.data, " & _
        "movimentomaster.doc, movimentomaster.concluido, " & _
        "movimentomaster.id_usuario, producao.num_pedido, " & _
        "producao.id_filial_pedido " & _
        "FROM movimentomaster INNER JOIN " & _
        "pedido_producao_entrada as producao ON movimentomaster.cod_movimento = " & _
        "producao.cod_movimento  AND movimentomaster.id_filial = producao.id_filial_movimento " & _
        "WHERE PRODUCAO.num_pedido = " & x_num_pedido & _
        " and producao.id_filial_pedido = "
        d.carrega_Tabela(sql, tb_prod)
        If tb_prod.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function lista_itens() As DataTable
        Dim sql As String
        Dim tb_lista As New DataTable
        sql = "SELECT * FROM movimento " & _
        " WHERE (id_filial = " & Me._id_filial_movimento & ") AND " & _
        "(cod_Movimento = " & Me._cod_movimento & ") and status = 0"
        d.carrega_Tabela(sql, tb_lista)
        Return tb_lista
        tb_lista.Dispose()
    End Function
    Public Function conclui_movimento() As String
        Dim sql As String
        sql = "update movimentomaster set concluido = 'S' " & _
        " where cod_movimento = " & _cod_movimento & " and " & _
        "id_filial = " & _id_filial_movimento & ""
        Return d.Comando(sql, True)
    End Function
    Public Function tem_produto(ByVal x_cod_prod As Integer) As Integer
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT cod_produto, cod_Movimento, id_filial, status " & _
        "FROM movimento WHERE (cod_Movimento = " & Me._cod_movimento & _
        ") AND (id_filial = " & Me._id_filial_movimento & ") AND (cod_produto = " & _
        x_cod_prod & ") AND (status = 0)"
        d.carrega_Tabela(sql, tt)
        Return tt.Rows.Count
    End Function
    Public Function insere_item_nota(ByVal x_cod_prod As Integer, ByVal q As Double, ByVal diop As dioptriaBlocoSurf) As String
        Dim media_len, media_prod As Double
        Dim mov As New objMovimentoDetalhe
        Dim cod_tab As Integer
        Dim cod_len As Integer
        Dim item As Integer
        Dim cod_prod As Integer
        Dim res As String

        Dim p As New produtoClass

        cod_tab = p.Retorna_cod_Tabela(x_cod_prod)
        cod_prod = retorna_produto_destino(cod_tab, diop)
        p.filtra(cod_prod)

        item = mov.ret_ultimo_item(_cod_movimento)
        mov.novo()
        mov.item = item
        mov.cod_movimento = _cod_movimento
        mov.id_filial = _id_filial_movimento
        mov.cod_produto = p.fldCod_produto
        mov.quant = q
        mov.desconto = p.Desconto_compra
        mov.pUnit = p.Preco_compra
        mov.estoqueFis = mov.ret_saldo_fisico(p.fldCod_produto) + CDbl(q)
        mov.estoqueFin = mov.estoqueFis * ((p.Preco_compra - (p.Preco_compra * (p.Desconto_compra / 100))))
        '( + mov.ret_saldo_fin(txtCodProd.Text)
        cod_len = mov.retorna_cod_lentebloco(p.fldCod_produto)
        media_len = media_movel(mov.ret_saldo_todos_fisico(cod_len), mov.ret_saldo_todos_fin(cod_len), q, (p.Preco_compra) - (p.Preco_compra * (p.Desconto_compra / 100)))
        media_prod = media_movel(mov.ret_saldo_fisico(p.fldCod_produto), mov.ret_saldo_fin(p.fldCod_produto), q, (p.Preco_compra) - (p.Preco_compra * (p.Desconto_compra / 100)))
        mov.atualiza_custo(cod_len, media_len, p.fldCod_produto, media_prod)
        mov.historico = "Entrada automática do pedido de produção " & adiciona_zeros(_id_filial_pedido, 3) & "-" & _num_pedido
        res = mov.Salvar()
        Return res
    End Function
    Private Function retorna_produto_destino(ByVal xcod_tab As Integer, ByVal diop As dioptriaBlocoSurf) As Integer
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "select produtos.cod_produto " & _
        "from bloco_surfacado inner join produtos on " & _
        "bloco_surfacado.cod_produto = produtos.cod_produto " & _
        "inner join lentes_blocos on produtos.cod_lente = lentes_blocos.cod_lente " & _
        " where (bloco_surfacado.Base_nominal = " & d.cdin(diop.base) & _
        " And  bloco_surfacado.Adicao = " & d.cdin(diop.adicao) & _
        " And bloco_surfacado.Esf = " & d.cdin(diop.esferico) & _
        " and bloco_surfacado.Cil = " & d.cdin(diop.cilindrico) & _
        " and ((bloco_surfacado.Olho = " & d.PStr(diop.olho) & _
        ") or (bloco_surfacado.Olho = 'A')) " & _
        "and lentes_blocos.cod_tabela = " & _
        "(select cod_tabela_destino from bloco_surfacado_origem where cod_tabela_origem = " & xcod_tab & "))"
        d.carrega_Tabela(tsql, tt)
        Return tt.Rows(0)("cod_produto")
    End Function
    Public Function listagem_estoque() As DataTable
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT OS.cod_os, OS.id_filial, os.data_venda,OS.data_verificacao, OS.cod_cliente, OS.doc_cliente,  " & _
        "OS.cod_tab_od, OS.cod_tab_oe,  " & _
        "(Select top(1) andamentos.data from andamentos where cod_os = os.cod_os  " & _
        "and id_filial = os.id_filial) as data_importacao,  " & _
        "(SELECT nome_comercial FROM lentes_tabela WHERE (cod_tabela = OS.cod_tab_od)) AS OD,  " & _
        "(SELECT nome_comercial FROM lentes_tabela wHERE (cod_tabela = OS.cod_tab_oe)) AS OE,  " & _
        "Fases_os.fase, cliente.nome_cliente, OS.esf_od_longe, OS.cil_od_longe, OS.esf_od_perto, " & _
        "OS.cil_od_perto, OS.base_od, OS.adicao_od, OS.esf_oe_longe, OS.cil_oe_longe, OS.esf_oe_perto, " & _
        "OS.cil_oe_perto, OS.base_oe, OS.adicao_oe, fabricante.fabricante " & _
        ",os.num_pedido " & _
        "FROM fabricante INNER JOIN lentes_tabela ON fabricante.id_fabricante =  " & _
        "lentes_tabela.id_fabricante FULL OUTER JOIN  " & _
        "OS INNER JOIN fases_OS ON OS.cod_fase = fases_OS.cod_fase " & _
        "inner join pedido_balcao on pedido_balcao.num_pedido = os.num_pedido " & _
        "and pedido_balcao.id_filial = os.id_filial " & _
        "INNER Join cliente ON OS.cod_filial_cliente = cliente.cod_filial_cliente AND  " & _
        "OS.cod_cliente = cliente.cod_cliente ON lentes_tabela.cod_tabela = OS.cod_tab_od AND  " & _
        "lentes_tabela.cod_tabela = OS.cod_tab_oe " & _
        "WHERE ((OS.cod_fase = 2) OR (OS.cod_fase = 3) OR (OS.cod_fase = 5)  " & _
        " OR (OS.cod_fase = 20)) " & _
        "and ((os.cod_tab_od + os.cod_tab_oe) > 5)  " & _
        "and (pedido_balcao.num_pedido = " & Me._num_pedido & _
        " and pedido_balcao.id_filial =" & Me._id_filial_pedido & ")" & _
        " ORDER BY fabricante.fabricante, OD,OE, OS.base_od, OS.adicao_od,  " & _
        " OS.base_oe, OS.adicao_oe, OS. esf_od_longe, OS.cil_od_longe, OS.esf_od_perto, OS.cil_od_perto,  " & _
        "OS.esf_oe_longe, OS.cil_oe_longe, OS.esf_oe_perto, OS.cil_oe_perto, " & _
        "OS.data_verificacao, OS.cod_cliente, OS.doc_cliente"
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function lista_pedidos() As DataTable
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "SELECT movimentomaster.cod_movimento, movimentomaster.id_filial, " & _
        "movimentomaster.cod_natureza, movimentomaster.data, " & _
        "movimentomaster.doc, movimentomaster.concluido, " & _
        "movimentomaster.id_usuario, producao.num_pedido, " & _
        "producao.id_filial_pedido " & _
        "FROM movimentomaster INNER JOIN " & _
        "pedido_producao_entrada as producao ON movimentomaster.cod_movimento = " & _
        "producao.cod_movimento  AND movimentomaster.id_filial = producao.id_filial_movimento " & _
        " order by data desc"
        d.carrega_Tabela(tsql, tt)
        Return tt
    End Function
#End Region
End Class
