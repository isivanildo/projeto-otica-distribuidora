Public Class objEntradaNota
#Region "Atributos"
    Dim _id_conferencia As Object = 0
    Dim _id_filial_nota As Object = 0
    Dim _cod_fornecedor As Object
    Dim _data As Object
    Dim _data_entrada As Object
    Dim _documento As Object
    Dim _pedido As Object
    Dim _cod_movimento As Object = 0
    Dim _id_filial As Object = 0
    Dim _observacao As Object
    Dim _cod_usuario As Object
    Dim _parte As Object
    Dim _valor_total_prod As Object
    Dim _valor_total_nota As Object
    Dim _valor_frete As Object
    Dim _qtde As Object
    Dim _num_parcela As Object
    Dim _valor_parcela As Object
    Dim _tipo_nota As Object
    'Dim _forma_pagamento As Object
    Dim _cod_forma_pagamento As Object
    Dim _cod_pedido As Integer
    Dim _frete_paga As Object
    Dim _reembolso As Object
    Dim _filia_loja As Object
    Dim _os_loja As Object
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
    Public Property id_conferencia()
        Get
            id_conferencia = _id_conferencia
        End Get
        Set(ByVal Value)
            _id_conferencia = Value
        End Set
    End Property
    Public Property id_filial_nota()
        Get
            id_filial_nota = _id_filial_nota
        End Get
        Set(ByVal Value)
            _id_filial_nota = Value
        End Set
    End Property
    Public Property cod_fornecedor()
        Get
            cod_fornecedor = _cod_fornecedor
        End Get
        Set(ByVal Value)
            _cod_fornecedor = Value
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
    Public Property data_entrada()
        Get
            data_entrada = _data_entrada
        End Get
        Set(ByVal Value)
            _data_entrada = Value
        End Set
    End Property
    Public Property documento()
        Get
            documento = _documento
        End Get
        Set(ByVal Value)
            _documento = Value
        End Set
    End Property
    Public Property pedido()
        Get
            pedido = _pedido
        End Get
        Set(ByVal Value)
            _pedido = Value
        End Set
    End Property
    Public Property cod_movimento()
        Get
            cod_movimento = _cod_movimento
        End Get
        Set(ByVal Value)
            _cod_movimento = Value
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
    Public Property observacao()
        Get
            observacao = _observacao
        End Get
        Set(ByVal Value)
            _observacao = Value
        End Set
    End Property
    Public Property cod_usuario()
        Get
            cod_usuario = _cod_usuario
        End Get
        Set(ByVal Value)
            _cod_usuario = Value
        End Set
    End Property
    Public Property parte()
        Get
            parte = _parte
        End Get
        Set(ByVal Value)
            _parte = Value
        End Set
    End Property
    Public Property valor_total_prod
        Get
            valor_total_prod = _valor_total_prod
        End Get
        Set(value)
            _valor_total_prod = value
        End Set
    End Property
    Public Property valor_total_nota
        Get
            valor_total_nota = _valor_total_nota
        End Get
        Set(value)
            _valor_total_nota = value
        End Set
    End Property
    Public Property valor_frete
        Get
            valor_frete = _valor_frete
        End Get
        Set(value)
            _valor_frete = value
        End Set
    End Property
    Public Property quantidade
        Get
            quantidade = _qtde
        End Get
        Set(value)
            _qtde = value
        End Set
    End Property
    Public Property num_parcela
        Get
            num_parcela = _num_parcela
        End Get
        Set(value)
            _num_parcela = value
        End Set
    End Property
    Public Property valor_parcela
        Get
            valor_parcela = _valor_parcela
        End Get
        Set(value)
            _valor_parcela = value
        End Set
    End Property
    Public Property tipo_nota
        Get
            tipo_nota = _tipo_nota
        End Get
        Set(value)
            _tipo_nota = value
        End Set
    End Property
    Public Property cod_forma_pagamento
        Get
            cod_forma_pagamento = _cod_forma_pagamento
        End Get
        Set(value)
            _cod_forma_pagamento = value
        End Set
    End Property
    Public Property cod_pedido
        Get
            cod_pedido = _cod_pedido
        End Get
        Set(value)
            _cod_pedido = value
        End Set
    End Property

    Public Property frete_paga
        Get
            frete_paga = _frete_paga
        End Get
        Set(value)
            _frete_paga = value
        End Set
    End Property

    Public Property reembolso
        Get
            reembolso = _reembolso
        End Get
        Set(value)
            _reembolso = value
        End Set
    End Property

    Public Property filial_loja
        Get
            filial_loja = _filia_loja
        End Get
        Set(value)
            _filia_loja = value
        End Set
    End Property

    Public Property os_loja
        Get
            os_loja = _os_loja
        End Get
        Set(value)
            _os_loja = value
        End Set
    End Property
#End Region

#Region "Procedimentos"
    Public Sub New()
        Dim sql As String
        sql = "Select * from conferencia_nota_master " & _
        "where id_conferencia = 0"
        Source(sql)
    End Sub
    Public Sub New(ByVal db As dados)
        Dim sql As String
        d = db
        sql = "Select * from conferencia_nota_master " & _
        "where id_conferencia = 0"
        Source(sql)
    End Sub
    Public Sub carrega_nota(ByVal x_cod_nota As Integer, ByVal x_id_filial As Integer)
        Dim sql As String
        sql = "Select * from conferencia_nota_master " & _
            "where id_conferencia = " & x_cod_nota & _
            " and id_filial_nota = " & x_id_filial & ""
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
            With tb
                _id_conferencia = .Rows(pos)("id_conferencia")
                _id_filial_nota = .Rows(pos)("id_filial_nota")
                _cod_fornecedor = .Rows(pos)("cod_fornecedor")
                _data = rdData(.Rows(pos)("data"))
                _data_entrada = rdData(.Rows(pos)("data_entrada"))
                _documento = rdTexto(.Rows(pos)("documento"))
                _pedido = rdTexto(.Rows(pos)("pedido"))
                _cod_movimento = .Rows(pos)("cod_movimento")
                _id_filial = .Rows(pos)("id_filial")
                _observacao = rdTexto(.Rows(pos)("observacao"))
                _parte = rdNum(.Rows(pos)("parte"))
                _valor_total_prod = (.Rows(pos)("ValorTotalProd"))
                _valor_total_nota = (.Rows(pos)("ValorTotalNota"))
                _valor_frete = (.Rows(pos)("ValorFrete"))
                _qtde = (.Rows(pos)("Qtde"))
                _num_parcela = (.Rows(pos)("NumParcelas"))
                _valor_parcela = (.Rows(pos)("ValorParcela"))
                _tipo_nota = (.Rows(pos)("tiponota"))
                _cod_forma_pagamento = .Rows(pos)("forma_pagamento")
                _cod_pedido = .Rows(pos)("cod_pedido")
                _frete_paga = .Rows(pos)("frete")
                _reembolso = .Rows(pos)("reembolso")
                _filia_loja = rdTexto(.Rows(pos)("filial_loja"))
                _os_loja = rdTexto(.Rows(pos)("os_loja"))
            End With
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
        _id_conferencia = 0
        _id_filial_nota = 0
        _cod_fornecedor = Nothing
        _data = Nothing
        _data_entrada = Nothing
        _documento = Nothing
        _pedido = Nothing
        _cod_movimento = Nothing
        _id_filial = Nothing
        _cod_usuario = Nothing
        _parte = Nothing
        _valor_total_prod = Nothing
        _valor_total_nota = Nothing
        _valor_frete = Nothing
        _qtde = Nothing
        _num_parcela = Nothing
        _valor_parcela = Nothing
        _tipo_nota = 0
        '_forma_pagamento = Nothing
        _cod_forma_pagamento = Nothing
        _cod_pedido = 0
        _frete_paga = Nothing
        _reembolso = Nothing
        _filia_loja = Nothing
        _os_loja = Nothing
        OrigemSalvar = "Novo" 'Define o tipo de ação ao salvar
    End Function
    Public Function Salvar() As String
        Dim sql As String
        Dim res As String
        Dim chave_movimento As Integer
        d.conecta()
        If OrigemSalvar = "Novo" Then
            Try
                chave_movimento = retorna_Chave("cod_movimento", "movimentomaster", " where id_filial = " & conf.Filial & "")
                _cod_movimento = chave_movimento
                _id_filial = conf.Filial
                sql = "INSERT INTO movimentomaster " &
                       "(cod_movimento,cod_natureza,id_filial,data,doc,id_usuario,concluido) " &
                       "VALUES ( " &
                       chave_movimento &
                       ",1" &
                       "," & conf.Filial &
                       "," & d.pdtm(d.hora) &
                       "," & d.PStr(_documento) &
                       "," & _cod_usuario &
                       ",'N')"
                res = d.Comando(sql, True)
                _id_conferencia = chave()
                sql = "INSERT INTO conferencia_nota_master (id_conferencia,id_filial_nota,Documento " &
           ",data,pedido,cod_movimento,id_filial,data_entrada,cod_fornecedor,observacao,cod_usuario,parte,ValorTotalProd " &
           ",ValorTotalNota,ValorFrete,Qtde,NumParcelas,ValorParcela,tiponota,forma_pagamento,cod_pedido,frete,reembolso,filial_loja,os_loja)" &
            "VALUES (" & _id_conferencia &
           "," & _id_filial_nota &
           "," & d.PStr(_documento) &
           "," & d.Pdt(_data) &
           "," & d.PStr(_pedido) &
           "," & chave_movimento &
           "," & _id_filial &
           "," & d.Pdt(_data_entrada) &
           "," & d.PStr(_cod_fornecedor) &
           "," & d.PStr(_observacao) &
           "," & _cod_usuario &
           "," & d.cdin(_parte) &
           "," & d.cdin(_valor_total_prod) &
           "," & d.cdin(_valor_total_nota) &
           "," & d.cdin(_valor_frete) &
           "," & _qtde &
           "," & _num_parcela &
           "," & d.cdin(_valor_parcela) &
           "," & d.PStr(_tipo_nota) &
           "," & d.PStr(_cod_forma_pagamento) &
           "," & _cod_pedido &
           "," & d.PStr(_frete_paga) &
           "," & d.PStr(_reembolso) &
           "," & d.PStr(_filia_loja) &
           "," & d.PStr(_os_loja) & ")"

                res = d.Comando(sql, True)
                If res.Substring(0, 3) = "ER:" Then
                    Return "ER:" & res.Substring(3) & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                    Registro(lastPos)
                    Exit Function
                End If
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tb.NewRow
            r("id_conferencia") = _id_conferencia
            r("id_filial_nota") = _id_filial_nota
            r("cod_fornecedor") = _cod_fornecedor
            r("data") = wrData(_data)
            r("data_entrada") = wrData(_data_entrada)
            r("documento") = rdTexto(_documento)
            r("pedido") = rdTexto(_pedido)
            r("cod_movimento") = wrNum(_cod_movimento)
            r("id_filial") = wrNum(_id_filial)
            r("observacao") = rdTexto(_observacao)
            r("cod_usuario") = _cod_usuario
            r("parte") = wrNum(_parte)
            r("ValorTotalProd") = _valor_total_prod
            r("ValorTotalNota") = _valor_total_nota
            r("ValorFrete") = _valor_frete
            r("Qtde") = _qtde
            r("NumParcelas") = _num_parcela
            r("ValorParcela") = _valor_parcela
            r("tiponota") = _tipo_nota
            r("forma_pagamento") = _cod_forma_pagamento
            r("cod_pedido") = _cod_pedido
            r("frete") = _frete_paga
            r("reembolso") = _reembolso
            r("filial_loja") = _filia_loja
            r("os_loja") = _os_loja

            tb.Rows.Add(r)
            max = max + 1
            If max = 1 Then
                posicao = 0
            Else
                posicao = max - 1
            End If
            OrigemSalvar = ""
            Return res & " adicionado(s) com sucesso!"
        End If
        If Me.OrigemSalvar = "Editar" Then
            Try
                sql = "UPDATE conferencia_nota_master " &
                "SET Documento = " & d.PStr(_documento) &
                ",data = " & d.Pdt(_data) &
                ",pedido = " & d.PStr(_pedido) &
                ",cod_movimento = " & d.cdin(_cod_movimento) &
                ",data_entrada = " & d.Pdt(_data_entrada) &
                ",cod_fornecedor = " & _cod_fornecedor &
                ",observacao = " & d.PStr(_observacao) &
                ",parte = " & rdNum(_parte) &
                " Where id_conferencia = " & Me._id_conferencia &
                " and id_filial_nota = " & Me._id_filial_nota & ""
                res = d.Comando(sql, True)
                sql = "Update movimentomaster set id_usuario = " & _cod_usuario &
                " where cod_movimento = " & _cod_movimento & ""
                d.Comando(sql, True)
                If res.Substring(0, 3) = "ER:" Then
                    Return "ER:" & res.Substring(3) & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                    Registro(lastPos)
                    Exit Function
                End If
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tb.Rows(posicao)
            r("id_filial") = _id_filial
            r("cod_fornecedor") = _cod_fornecedor
            r("data") = wrData(_data)
            r("data_entrada") = wrData(_data_entrada)
            r("documento") = rdTexto(_documento)
            r("pedido") = rdTexto(_pedido)
            r("cod_movimento") = wrNum(_cod_movimento)
            r("id_filial") = wrNum(_id_filial)
            r("observacao") = rdTexto(_observacao)
            r("cod_usuario") = wrNum(_cod_usuario)
            OrigemSalvar = ""
            Return res & " registro(s) atualizado(s) com sucesso!"
        End If
    End Function
    Public Function deletar(ByVal x_cod_pedido As Integer, ByVal x_id_filial As Integer)
        Dim sql As String
        Dim res As String
        d.conecta()
        sql = "Delete from pedido_fornecedor where cod_pedido = " & x_cod_pedido &
        " and id_filial = " & x_id_filial & ""
        Try
            res = d.Comando(sql, True)
        Catch ex As Exception

        End Try
        Me.refreshData()
        Me.primeiro()
        Return res & " Registros foram apagados!"
    End Function
    Public Function chave()
        Return retorna_Chave("id_conferencia", "conferencia_nota_master", " where id_filial_nota = " & _id_filial_nota & "")
    End Function
    Public Function insere_item(ByVal x_cod_produto As Integer,
    ByVal x_quantidade As Double,
    ByVal x_user As Integer, ByVal x_preco_nota As String, ByVal x_cod_tabela As Integer, ByVal x_desconto_compra As String, ByVal x_tipo As String) As String
        Dim valor As String
        Dim desconto As String
        valor = x_preco_nota.Replace(",", ".")
        desconto = x_desconto_compra.Replace(",", ".")
        Dim sql As String
        Dim item As Integer
        item = retorna_Chave("id_item", "conferencia_nota", " Where id_conferencia = " _
        & _id_conferencia & " and id_filial_nota = " & _id_filial_nota & "")
        sql = "Insert into conferencia_nota(id_conferencia,id_filial_nota,id_item,cod_produto," &
        "quant,user_id,preco_nota,cod_tabela,desconto_compra,avulsa) values(" &
          _id_conferencia & "," & _id_filial_nota & "," & item & "," & x_cod_produto &
          "," & x_quantidade & "," & x_user & "," & valor & "," & x_cod_tabela & "," & desconto & ",'" & x_tipo & "')"
        Return d.Comando(sql, True)
    End Function
    Public Function lista_itens(ByVal ORD As String) As DataTable
        Dim sql As String
        Dim tb As New DataTable
        sql = "SELECT produtos.produto, produtos.cod_barra, conferencia_nota.quant AS quantidade " &
        ",conferencia_nota.id_item,conferencia_nota.processado,conferencia_nota.preco_nota,PRODUTOS.COD_PRODUTO " &
        "FROM conferencia_nota INNER JOIN produtos ON conferencia_nota.cod_produto = " &
        "produtos.cod_produto " &
        "WHERE (conferencia_nota.id_conferencia = " & _id_conferencia & ") and (conferencia_nota." &
        "id_filial_nota = " & _id_filial_nota & ") AND Avulsa = 'N' order by conferencia_nota.id_item " & ORD & ""
        d.carrega_Tabela(sql, tb)
        Return tb
    End Function
    'Ivanildo 14/09
    Public Function lista_itens_exibir(ByVal ORD As String, ByVal intFilial As Integer) As DataTable
        Dim sql As String
        ' Dim strteste As String
        Dim tb As New DataTable
        'sql = "SELECT produtos.produto, produtos.cod_barra, conferencia_nota.quant AS quantidade " & _
        '",conferencia_nota.id_item,conferencia_nota.processado,conferencia_nota.preco_nota,PRODUTOS.COD_PRODUTO " & _
        '"FROM conferencia_nota INNER JOIN produtos ON conferencia_nota.cod_produto = " & _
        '"produtos.cod_produto " & _
        '"WHERE (conferencia_nota.id_conferencia = " & _id_conferencia & ") and (conferencia_nota." & _
        '"id_filial_nota = " & _id_filial_nota & ") order by conferencia_nota.id_item " & ORD & ""

        sql = "SELECT produtos.produto, produtos.cod_barra, conferencia_nota.quant AS quantidade" &
            ",conferencia_nota.id_item,conferencia_nota.processado,conferencia_nota.preco_nota,PRODUTOS.COD_PRODUTO," &
            "conferencia_nota_item.preco, SUM(conferencia_nota_item.qtde) as totalqtde " &
            "FROM conferencia_nota LEFT JOIN produtos ON conferencia_nota.cod_produto =  produtos.cod_produto " &
            "LEFT JOIN conferencia_nota_item ON conferencia_nota.id_conferencia = conferencia_nota_item.id_conferencia " &
            "AND conferencia_nota.cod_produto =  conferencia_nota_item.cod_produto " &
            "WHERE (conferencia_nota.id_conferencia = " & _id_conferencia & ") and (conferencia_nota.id_filial_nota = " & intFilial &
            ") group by produtos.produto, produtos.cod_barra, conferencia_nota.quant, conferencia_nota.id_item,conferencia_nota.processado," &
            "conferencia_nota.preco_nota,PRODUTOS.COD_PRODUTO, conferencia_nota_item.preco " &
            "order by conferencia_nota.id_item " & ORD & ""

        d.carrega_Tabela(sql, tb)
        Return tb
    End Function

    Public Function lista_itens_avulsa(ByVal ORD As String) As DataTable
        Dim sql As String
        Dim tb As New DataTable
        sql = "SELECT produtos.produto, produtos.cod_barra, conferencia_nota.quant AS quantidade " &
        ",conferencia_nota.id_item,conferencia_nota.processado,conferencia_nota.preco_nota,PRODUTOS.COD_PRODUTO " &
        "FROM conferencia_nota INNER JOIN produtos ON conferencia_nota.cod_produto = " &
        "produtos.cod_produto " &
        "WHERE (conferencia_nota.id_conferencia = " & _id_conferencia & ") and (conferencia_nota." &
        "id_filial_nota = " & _id_filial_nota & ") AND Avulsa = 'S' order by conferencia_nota.id_item " & ORD & ""
        d.carrega_Tabela(sql, tb)
        Return tb
    End Function
    'Fim 14/09

    Public Function lista_itens_impressao() As DataTable
        Dim sql As String
        Dim tb As New DataTable
        sql = "SELECT lentes_blocos.nome_lente,lentes_blocos.cod_tabela, produtos.produto, " &
        "produtos.cod_barra, conferencia_nota.quant AS quantidade " &
        ",conferencia_nota.id_item,conferencia_nota.processado,PRODUTOS.COD_PRODUTO " &
        "FROM conferencia_nota INNER JOIN produtos ON conferencia_nota.cod_produto = " &
        "produtos.cod_produto INNER JOIN lentes_blocos ON produtos.cod_lente = " &
        "lentes_blocos.cod_lente AND produtos.id_fabricante = lentes_blocos.id_fabricante " &
        "WHERE (conferencia_nota.id_conferencia = " & _id_conferencia & ") and (conferencia_nota." &
        "id_filial_nota = " & _id_filial_nota & ") order by lentes_blocos.nome_lente, produtos.produto "
        d.carrega_Tabela(sql, tb)
        Return tb
    End Function
    Public Function lista_itens_espelho_nota() As DataTable
        Dim sql As String
        Dim tb As New DataTable
        sql = "SELECT lentes_blocos.nome_lente,lentes_blocos.cod_tabela, produtos.produto, " &
        "produtos.cod_barra, conferencia_nota.quant AS quantidade,conferencia_nota.id_item " &
        ",conferencia_nota.processado,conferencia_nota.preco_nota,sum(conferencia_nota.quant * conferencia_nota.preco_nota) as total " &
        ",PRODUTOS.COD_PRODUTO " &
        "FROM conferencia_nota LEFT JOIN produtos ON conferencia_nota.cod_produto = " &
        "produtos.cod_produto LEFT JOIN lentes_blocos ON produtos.cod_lente = " &
        "lentes_blocos.cod_lente AND produtos.id_fabricante = lentes_blocos.id_fabricante " &
        "WHERE (conferencia_nota.id_conferencia = " & _id_conferencia & ") and (conferencia_nota." &
        "id_filial_nota = " & _id_filial_nota & ") " &
        "group by lentes_blocos.nome_lente,lentes_blocos.cod_tabela, " &
        "produtos.produto,produtos.cod_barra, conferencia_nota.quant,conferencia_nota.id_item" &
        ",conferencia_nota.processado,conferencia_nota.preco_nota,PRODUTOS.COD_PRODUTO order by produtos.cod_barra"
        d.carrega_Tabela(sql, tb)
        Return tb
    End Function

    Public Function lista_itens_espelho_nota(ByVal idConferencia As Integer, ByVal idFilial As Integer) As DataTable
        Dim sql As String
        Dim tb As New DataTable
        sql = "SELECT lentes_blocos.nome_lente,lentes_blocos.cod_tabela, produtos.produto, " &
        "produtos.cod_barra, conferencia_nota.quant AS quantidade,conferencia_nota.id_item " &
        ",conferencia_nota.processado,conferencia_nota.preco_nota,sum(conferencia_nota.quant * conferencia_nota.preco_nota) as total " &
        ",PRODUTOS.COD_PRODUTO " &
        "FROM conferencia_nota LEFT JOIN produtos ON conferencia_nota.cod_produto = " &
        "produtos.cod_produto LEFT JOIN lentes_blocos ON produtos.cod_lente = " &
        "lentes_blocos.cod_lente AND produtos.id_fabricante = lentes_blocos.id_fabricante " &
        "WHERE (conferencia_nota.id_conferencia = " & _id_conferencia & ") and (conferencia_nota." &
        "id_filial_nota = " & _id_filial_nota & ") group by lentes_blocos.nome_lente,lentes_blocos.cod_tabela, " &
        "produtos.produto,produtos.cod_barra, conferencia_nota.quant,conferencia_nota.id_item" &
        ",conferencia_nota.processado,conferencia_nota.preco_nota,PRODUTOS.COD_PRODUTO order by produtos.cod_barra"
        d.carrega_Tabela(sql, tb)
        Return tb
    End Function

    Public Function lista_itens_espelho_nota_rel(ByVal numPedido As Integer, ByVal idFilial As Integer) As DataTable
        Dim sql As String
        Dim tb As New DataTable
        sql = "SELECT lentes_blocos.nome_lente,lentes_blocos.cod_tabela, produtos.produto, " &
        "produtos.cod_barra, conferencia_nota.quant AS quantidade,conferencia_nota.id_item " &
        ",conferencia_nota.processado,conferencia_nota.preco_nota,sum(conferencia_nota.quant * conferencia_nota.preco_nota) as total " &
        ",PRODUTOS.COD_PRODUTO, conferencia_nota_master.Documento, conferencia_nota_master.cod_Pedido, fornecedor.Fornecedor,  " &
        "conferencia_nota_master.valortotalprod,conferencia_nota_master.valortotalnota,conferencia_nota_master.valorfrete, " &
        "conferencia_nota_master.Qtde, conferencia_nota_master.numParcelas, conferencia_nota_master.valorparcela, " &
        "conferencia_nota_master.Observacao, forma_pagamento.forma_pagamento, conferencia_nota_master.tiponota " &
        "FROM conferencia_nota LEFT JOIN produtos ON conferencia_nota.cod_produto = " &
        "produtos.cod_produto LEFT JOIN lentes_blocos ON produtos.cod_lente = " &
        "lentes_blocos.cod_lente AND produtos.id_fabricante = lentes_blocos.id_fabricante " &
        "LEFT JOIN conferencia_nota_master ON conferencia_nota.id_conferencia = conferencia_nota_master.id_conferencia " &
        "LEFT JOIN fornecedor ON conferencia_nota_master.cod_fornecedor = fornecedor.cod_fornecedor " &
        "LEFT JOIN forma_pagamento ON conferencia_nota_master.forma_pagamento = forma_pagamento.cod_forma_pagamento " &
        "WHERE (conferencia_nota_master.cod_pedido = " & numPedido & ") and (conferencia_nota_master." &
        "id_filial_nota = " & idFilial & ") group by lentes_blocos.nome_lente,lentes_blocos.cod_tabela, " &
        "produtos.produto,produtos.cod_barra, conferencia_nota.quant,conferencia_nota.id_item" &
        ",conferencia_nota.processado,conferencia_nota.preco_nota,PRODUTOS.COD_PRODUTO, " &
        "conferencia_nota_master.Documento, conferencia_nota_master.cod_Pedido, fornecedor.Fornecedor,  " &
        "conferencia_nota_master.valortotalprod,conferencia_nota_master.valortotalnota,conferencia_nota_master.valorfrete, " &
        "conferencia_nota_master.Qtde, conferencia_nota_master.numParcelas, conferencia_nota_master.valorparcela, conferencia_nota_master.Observacao, " &
        "forma_pagamento.forma_pagamento, conferencia_nota_master.tiponota " &
        "order by produtos.cod_barra"
        d.carrega_Tabela(sql, tb)
        Return tb
    End Function

    'Função responsável por listar os produtos que vieram e que não estavam pedidos no pedido informado no lançamento da nota fiscal
    Public Function lista_itens_espelho_nota_pedido_dev(ByVal intPedido As Integer, ByVal idfilialnota As Integer) As DataTable
        Dim sql As String
        Dim teste As String
        Dim tb As New DataTable
        sql = "SELECT lentes_blocos.nome_lente,lentes_blocos.cod_tabela, produtos.produto, produtos.cod_barra, " &
            "conferencia_nota.quant AS quantidade,conferencia_nota.id_item,conferencia_nota.processado," &
            "conferencia_nota.preco_nota,sum(conferencia_nota.quant * conferencia_nota.preco_nota) as total " &
            ",PRODUTOS.COD_PRODUTO, conferencia_nota_master.cod_pedido,conferencia_nota_master.data, nota_pedido.nota_fiscal,fornecedor.fornecedor " &
            "FROM conferencia_nota LEFT JOIN produtos ON conferencia_nota.cod_produto = produtos.cod_produto " &
            "LEFT JOIN lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente AND produtos.id_fabricante = lentes_blocos.id_fabricante " &
            "LEFT JOIN conferencia_nota_master ON conferencia_nota.id_conferencia = conferencia_nota_master.id_conferencia " &
            "LEFT JOIN nota_pedido ON conferencia_nota_master.cod_movimento = nota_pedido.cod_movimento " &
            "LEFT JOIN fornecedor ON fornecedor.cod_fornecedor = conferencia_nota_master.cod_fornecedor " &
            "WHERE (conferencia_nota_master.cod_pedido = " & intPedido & ") and (conferencia_nota_master.id_filial_nota = " & idfilialnota & ") " &
            "and (conferencia_nota.avulsa = 'D') group by lentes_blocos.nome_lente,lentes_blocos.cod_tabela,produtos.produto, produtos.cod_barra," &
            "conferencia_nota.quant, conferencia_nota.id_item,conferencia_nota.processado,conferencia_nota.preco_nota,PRODUTOS.COD_PRODUTO," &
            "conferencia_nota_master.cod_pedido,nota_pedido.nota_fiscal, conferencia_nota_master.data, fornecedor.fornecedor " &
            "order by produtos.cod_barra"

        d.carrega_Tabela(sql, tb)
        Return tb
    End Function

    'Função responsável por listar os produtos que vieram e que não estavam pedidos no pedido informado no lançamento da nota fiscal
    Public Function lista_itens_espelho_nota_pedido_dev() As DataTable
        Dim sql As String
        Dim tb As New DataTable
        sql = "SELECT lentes_blocos.nome_lente,lentes_blocos.cod_tabela, produtos.produto, " &
        "produtos.cod_barra, conferencia_nota.quant AS quantidade,conferencia_nota.id_item " &
        ",conferencia_nota.processado,conferencia_nota.preco_nota,sum(conferencia_nota.quant * conferencia_nota.preco_nota) as total " &
        ",PRODUTOS.COD_PRODUTO " &
        "FROM conferencia_nota LEFT JOIN produtos ON conferencia_nota.cod_produto = " &
        "produtos.cod_produto LEFT JOIN lentes_blocos ON produtos.cod_lente = " &
        "lentes_blocos.cod_lente AND produtos.id_fabricante = lentes_blocos.id_fabricante " &
        "WHERE (conferencia_nota.id_conferencia = " & _id_conferencia & ") and (conferencia_nota." &
        "id_filial_nota = " & _id_filial_nota & ") and (conferencia_nota.avulsa = 'D') group by lentes_blocos.nome_lente,lentes_blocos.cod_tabela, " &
        "produtos.produto,produtos.cod_barra, conferencia_nota.quant,conferencia_nota.id_item" &
        ",conferencia_nota.processado,conferencia_nota.preco_nota,PRODUTOS.COD_PRODUTO order by produtos.cod_barra"
        d.carrega_Tabela(sql, tb)
        Return tb
    End Function

    Public Function lista_itens_impressao_nota(ByVal NF As String) As DataTable
        Dim sql As String
        Dim tb As New DataTable
        sql = "SELECT lentes_blocos.nome_lente, lentes_blocos.cod_tabela, produtos.produto, produtos.cod_barra, " &
        "SUM(conferencia_nota.quant) AS quantidade FROM conferencia_nota INNER JOIN " &
        "produtos ON conferencia_nota.cod_produto = produtos.cod_produto INNER JOIN " &
        "lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente AND produtos.id_fabricante = " &
        "lentes_blocos.id_fabricante INNER JOIN conferencia_nota_master ON conferencia_nota.id_conferencia = " &
        "conferencia_nota_master.id_conferencia AND conferencia_nota.id_filial_nota = " &
        "conferencia_nota_master.id_filial_nota " &
        " WHERE (conferencia_nota_master.Documento = " & d.PStr(NF) & ")" &
        " GROUP BY lentes_blocos.nome_lente, lentes_blocos.cod_tabela, produtos.produto, produtos.cod_barra " &
        " ORDER BY lentes_blocos.nome_lente, produtos.produto"
        d.carrega_Tabela(sql, tb)
        Return tb
    End Function
    Public Function lista_itens_impressao_nota_pedido(ByVal tb As DataTable) As DataTable
        Dim sql, sqlFiltro, sqlfim As String
        Dim tt As New DataTable
        Dim i As Integer = 0
        sql = "SELECT lentes_blocos.nome_lente, lentes_blocos.cod_tabela, produtos.produto, produtos.cod_barra, " &
        "SUM(conferencia_nota.quant) AS quantidade FROM conferencia_nota INNER JOIN " &
        "produtos ON conferencia_nota.cod_produto = produtos.cod_produto INNER JOIN " &
        "lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente AND produtos.id_fabricante = " &
        "lentes_blocos.id_fabricante INNER JOIN conferencia_nota_master ON conferencia_nota.id_conferencia = " &
        "conferencia_nota_master.id_conferencia AND conferencia_nota.id_filial_nota = " &
        "conferencia_nota_master.id_filial_nota "
        sqlFiltro = " Where "
        For Each r As DataRow In tb.Rows
            If i = 0 Then
                sqlFiltro = sqlFiltro & " (conferencia_nota_master.id_conferencia = " & r("id_conferencia") &
                " and conferencia_nota_master.id_filial = " & r("id_filial") & ")"
            Else
                sqlFiltro = sqlFiltro & " Or (conferencia_nota_master.id_conferencia = " & r("id_conferencia") &
                " and conferencia_nota_master.id_filial = " & r("id_filial") & ")"
            End If
            i = i + 1
        Next

        sqlfim = " GROUP BY lentes_blocos.nome_lente, lentes_blocos.cod_tabela, produtos.produto, produtos.cod_barra " &
        " ORDER BY lentes_blocos.nome_lente, produtos.produto"
        sql = sql & sqlFiltro & sqlfim
        d.carrega_Tabela(sql, tb)
        Return tb
    End Function

    Public Function exclui_item(ByVal x_item As Integer) As String
        Dim sql As String
        Dim r As String
        sql = "Delete from conferencia_nota " &
        " where (id_conferencia = " & Me._id_conferencia & ") and (id_filial_nota = " &
        Me._id_filial_nota & ") and (id_item = " & x_item & ")"
        r = d.Comando(sql, True)
        Return r
    End Function
    Public Function PROCESSADO(ByVal x_item As Integer) As String
        Dim sql As String
        Dim r As String
        sql = "update conferencia_nota " &
        " set processado = " & d.pdtm(Now) &
        " where (id_conferencia = " & Me._id_conferencia & ") and (id_filial_nota = " &
        Me._id_filial_nota & ") and (id_item = " & x_item & ")"
        r = d.Comando(sql, True)
        Return r
    End Function

    'Ivanildo 14/09
    Public Sub PROCESSADO_AVULSA()
        Dim sql As String
        Dim r As String
        sql = "update conferencia_nota " &
        " set processado = " & d.pdtm(Now) &
        " where (id_conferencia = " & Me._id_conferencia & ") and (id_filial_nota = " &
        Me._id_filial_nota & ") and (avulsa = 'S')"
        d.Comando(sql, True)
    End Sub
    'Fim 14/09
    'Ivanildo 14/09
    Public Sub PROCESSADO_DEVOLUCAO()
        Dim sql As String
        Dim r As String
        sql = "update conferencia_nota " &
        " set processado = " & d.pdtm(Now) &
        " where (id_conferencia = " & Me._id_conferencia & ") and (id_filial_nota = " &
        Me._id_filial_nota & ") and (avulsa = 'D')"
        d.Comando(sql, True)
    End Sub
    'Fim 14/09

    Public Function atualiza_quantidade(ByVal x_item As Integer, ByVal quant As Integer) As String
        Dim sql As String
        Dim r As String
        sql = "update conferencia_nota " &
        " set quant = " & quant &
        " where (id_conferencia = " & Me._id_conferencia & ") and (id_filial_nota = " &
        Me._id_filial_nota & ") and (id_item = " & x_item & ")"
        r = d.Comando(sql, True)
        Return r
    End Function

    'Atualiza preço compra na tabela conferencia_nota
    Public Sub atualiza_preco_compra(ByVal x_item As Integer, ByVal preco As Double)
        Dim valor As String
        valor = preco
        Dim conn As New System.Data.SqlClient.SqlConnection
        Dim sql As String
        ' Dim cod_lente As Integer
        sql = "update conferencia_nota " &
        " set preco_nota = " & valor.Replace(",", ".") &
        " where (id_conferencia = " & Me._id_conferencia & ") and (id_filial_nota = " & Me._id_filial_nota & ") and (id_item = " & x_item & ")"
        Dim cmd As New System.Data.SqlClient.SqlCommand(sql, conn)
        d.conecta()

        cmd.Connection = d.con

        cmd.ExecuteNonQuery()
    End Sub

    'Atualiza preço desconto na tabela conferencia_nota
    Public Sub atualiza_desconto_compra(ByVal x_item As Integer, ByVal preco_nota As Double, ByVal preco_compra As Double)
        Dim valor_nota As Double
        Dim valor_preco As Double
        Dim Total As Double
        Dim Total_Formato As String
        Dim Total_Geral As Double
        valor_nota = CDbl(preco_nota)
        valor_preco = CDbl(preco_compra)
        Total = 100 - ((preco_nota / preco_compra) * 100)
        Total_Geral = FormatNumber(Total, 2)
        Total_Formato = Total_Geral
        Dim conn As New System.Data.SqlClient.SqlConnection
        Dim sql As String
        ' Dim cod_lente As Integer
        sql = "update conferencia_nota " &
        " set desconto_compra = " & Total_Formato.Replace(",", ".") &
        " where (id_conferencia = " & Me._id_conferencia & ") and (id_filial_nota = " & Me._id_filial_nota & ") and (id_item = " & x_item & ")"
        Dim cmd As New System.Data.SqlClient.SqlCommand(sql, conn)
        d.conecta()

        cmd.Connection = d.con

        cmd.ExecuteNonQuery()
    End Sub

    'Atualiza preço compra na tabela lentes_tabela
    Public Function retorna_codigo_tabela(ByVal x_item As Integer) As Integer
        Dim tt As New DataTable
        Dim sql As String
        ' Dim cod_lente As Integer
        sql = "select cod_tabela from conferencia_nota" &
        " where (id_conferencia = " & Me._id_conferencia & ") and (id_filial_nota = " &
        Me._id_filial_nota & ") and (id_item = " & x_item & ")"

        d.carrega_Tabela(sql, tt)

        Return tt.Rows(0)("cod_tabela") '& "-" & tt.Rows(1)("cod_tabela")
    End Function

    Public Function lista_notas(ByVal tipo As String) As DataTable
        Dim sql As String
        Dim tt As New DataTable
        If tipo = "N" Then
            sql = "SELECT conferencia_nota_master.Documento, conferencia_nota_master.data, " &
              "movimentomaster.concluido,conferencia_nota_master.pedido,conferencia_nota_master.parte," &
              "conferencia_nota_master.id_conferencia, " &
              "conferencia_nota_master.id_filial_nota,usuarios.nome as usuario FROM conferencia_nota_master INNER JOIN " &
              "movimentomaster ON conferencia_nota_master.cod_movimento = movimentomaster." &
              "cod_movimento AND conferencia_nota_master.id_filial = movimentomaster.id_filial " &
              " INNER JOIN Usuarios ON movimentomaster.id_usuario = Usuarios.cod_usuario " &
              "Where conferencia_nota_master.id_filial_nota = " & conf.Filial &
              " And movimentomaster.concluido = 'N' order by conferencia_nota_master.data DESC"
        Else
            sql = "SELECT conferencia_nota_master.Documento, conferencia_nota_master.data, " &
  "movimentomaster.concluido,conferencia_nota_master.pedido,conferencia_nota_master.parte," &
  "conferencia_nota_master.id_conferencia, " &
  "conferencia_nota_master.id_filial_nota,usuarios.nome as usuario FROM conferencia_nota_master INNER JOIN " &
  "movimentomaster ON conferencia_nota_master.cod_movimento = movimentomaster." &
  "cod_movimento AND conferencia_nota_master.id_filial = movimentomaster.id_filial " &
  " INNER JOIN Usuarios ON movimentomaster.id_usuario = Usuarios.cod_usuario " &
  "Where conferencia_nota_master.id_filial_nota = " & conf.Filial &
  " order by conferencia_nota_master.data DESC"
        End If
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function limpa_nota()
        Dim sql As String
        sql = "Delete from conferencia_nota where id_conferencia = " & _id_conferencia & _
        " and id_filial_nota = " & _id_filial_nota & ""
        Return d.Comando(sql, True)
    End Function
    Public Function conclui() As String
        Dim sql As String
        sql = "Update movimentomaster set concluido = 'S' " & _
        "where cod_movimento = " & Me._cod_movimento & _
        "and id_filial = " & Me._id_filial & ""
        Return d.Comando(sql, True)
    End Function
    Public Function concluido() As String
        Dim sql As String
        Dim tt As New DataTable
        sql = "Select concluido from movimentomaster " & _
        "where cod_movimento = " & Me._cod_movimento & _
        "and id_filial = " & Me._id_filial & ""
        d.carrega_Tabela(sql, tt)
        Try
            Return tt.Rows(0)("concluido")
        Catch ex As Exception
            Return "N"
        End Try

    End Function
    Public Function documento_conferencia(ByVal id_conferencia As Integer, ByVal id_filial As Integer) As String
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "select conferencia_nota_master.Documento from conferencia_nota_master where id_conferencia = " & id_conferencia & _
        "and id_filial = " & id_filial
        d.carrega_Tabela(tsql, tt)
        If tt.Rows.Count > 0 Then
            Return tt.Rows(0)("documento")
        Else
            Return ""
        End If
    End Function
#End Region

End Class
