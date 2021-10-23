Public Class objLancamentos

#Region "Atributos"
    Private _cod_lancamento As Integer
    Private _id_filial_lancamento As Object
    Private _id_filial As Object
    Private _data_lancamento As Object
    Private _cod_conta As Object
    Private _valor As Object
    Private _cod_forma_pagamento As Object
    Private _n_parcelas As Object
    Private _n_parcela As Object
    Private _data_vencimento As Object
    Private _data_recebimento As Object
    Private _historico As Object
    Private _doc As Object
    Private _tipo As Object
    Private _cod_filial_cliente As Integer
    Private _cod_cliente As Integer
    Private _cod_fatura_lanc As Integer
    Private _acrescimo_novo As Object
    Private _juros_novo As Object
    Private _desconto_novo As Object
    Private _taxas As Object
    Private _usuario_lanc As Integer
    Private _usuario_alt_lanc As Integer

    Public posicao As Integer = 0
    Public max As Integer
    Public chaveCriterio As Object
    Public tb As New DataTable
    Public OrigemSalvar As String = ""
    Private lastPos As Integer = 0
    Private sql As String
    Public trans As New objSqlTrans
    Public Enum tiposalvar
        Normal = 1
        Transaction = 2
    End Enum
    Dim conf As New config
    Dim d As New dados
#End Region
#Region "GET SET"
    Public Property cod_lancamento()
        Get
            cod_lancamento = _cod_lancamento
        End Get
        Set(ByVal Value)
            _cod_lancamento = Value
        End Set
    End Property
    Public Property id_filial_lancamento()
        Get
            id_filial_lancamento = _id_filial_lancamento
        End Get
        Set(ByVal Value)
            _id_filial_lancamento = Value
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
    Public Property cod_conta()
        Get
            cod_conta = _cod_conta
        End Get
        Set(ByVal Value)
            _cod_conta = Value
        End Set
    End Property
    Public Property valor()
        Get
            valor = _valor
        End Get
        Set(ByVal Value)
            _valor = Value
        End Set
    End Property
    Public Property cod_forma_pagamento()
        Get
            cod_forma_pagamento = _cod_forma_pagamento
        End Get
        Set(ByVal Value)
            _cod_forma_pagamento = Value
        End Set
    End Property
    Public Property n_parcelas()
        Get
            n_parcelas = _n_parcelas
        End Get
        Set(ByVal Value)
            _n_parcelas = Value
        End Set
    End Property
    Public Property n_parcela()
        Get
            n_parcela = _n_parcela
        End Get
        Set(ByVal Value)
            _n_parcela = Value
        End Set
    End Property
    Public Property data_vencimento()
        Get
            data_vencimento = _data_vencimento
        End Get
        Set(ByVal Value)
            _data_vencimento = Value
        End Set
    End Property
    Public Property data_recebimento()
        Get
            data_recebimento = _data_recebimento
        End Get
        Set(ByVal Value)
            _data_recebimento = Value
        End Set
    End Property
    Public Property historico()
        Get
            historico = _historico
        End Get
        Set(ByVal Value)
            _historico = Value
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
    Public Property tipo()
        Get
            tipo = _tipo
        End Get
        Set(ByVal Value)
            _tipo = Value
        End Set
    End Property
    Public Property cod_filial_cliente()
        Get
            cod_filial_cliente = _cod_filial_cliente
        End Get
        Set(ByVal value)
            _cod_filial_cliente = value
        End Set
    End Property
    Public Property cod_cliente()
        Get
            cod_cliente = _cod_cliente
        End Get
        Set(ByVal value)
            _cod_cliente = value
        End Set
    End Property
    Public Property cod_fatura_lanc()
        Get
            cod_fatura_lanc = _cod_fatura_lanc
        End Get
        Set(value)
            _cod_fatura_lanc = value
        End Set
    End Property

    Public Property acrescimo_novo()
        Get
            acrescimo_novo = _acrescimo_novo
        End Get
        Set(value)
            _acrescimo_novo = value
        End Set
    End Property

    Public Property juros_novo()
        Get
            juros_novo = _juros_novo
        End Get
        Set(value)
            _juros_novo = value
        End Set
    End Property

    Public Property desconto_novo()
        Get
            desconto_novo = _desconto_novo
        End Get
        Set(value)
            _desconto_novo = value
        End Set
    End Property

    Public Property taxas()
        Get
            taxas = _taxas
        End Get
        Set(value)
            _taxas = value
        End Set
    End Property

    Public Property usuario_lanc
        Get
            usuario_lanc = _usuario_lanc
        End Get
        Set(value)
            _usuario_lanc = value
        End Set
    End Property

    Public Property usuario_alt_lanc
        Get
            usuario_alt_lanc = _usuario_alt_lanc
        End Get
        Set(value)
            _usuario_alt_lanc = value
        End Set
    End Property

#End Region
#Region "Procedimentos"
    Public Sub New()
        Dim sql As String
        sql = "Select * from lancamentos where cod_lancamento = 0 " &
        "ORDER BY cod_lancamento,ID_Filial"
        Source(sql)
    End Sub
    Public Sub filtrar(ByVal dia As Date)
        Dim di, df As String
        di = extrai_data_dmy(dia) & " 00:00:01"
        df = extrai_data_dmy(dia) & " 23:59:59"
        sql = "Select * from lancamentos where data_lancamento >= " &
        d.pdtm(di) & " and data_lancamento <= " & d.pdtm(df) &
        " and id_filial_lancamento = " & conf.Filial &
        "ORDER BY cod_lancamento,ID_Filial"
        Source(sql)
    End Sub
    Public Sub filtrar(ByVal xCod As Integer, ByVal xfilial As Integer)

        sql = "Select * from lancamentos where cod_lancamento =  " &
        xCod & " and id_filial = " & xfilial &
        " ORDER BY cod_lancamento,ID_Filial"
        Source(sql)
    End Sub
    Public Sub filtrar(ByVal diai As Date, ByVal diaf As Date, ByVal so_despesas As Boolean, ByVal filial As Integer)
        Dim di, df As String
        di = extrai_data_dmy(diai) & " 00:00:01"
        df = extrai_data_dmy(diaf) & " 23:59:59"
        sql = "Select lancamentos.* FROM lancamentos INNER JOIN " &
        "Contas ON lancamentos.cod_conta = Contas.CONTA" &
        " where data_lancamento >= " &
        d.pdtm(di) & " and data_lancamento <= " & d.pdtm(df) &
        " and id_filial_lancamento = " & filial & ""
        If so_despesas = True Then
            sql = sql & " and contas.tipo = 'S'"
        End If
        sql = sql & " ORDER BY cod_lancamento,ID_Filial"
        Source(sql)
    End Sub
    Public Sub filtrar_outras_receitas(ByVal dia As Date)
        Dim sql As String
        Dim tt As New DataTable
        Dim di, df As String
        di = extrai_data_dmy(dia) & " 00:00:01"
        df = extrai_data_dmy(dia) & " 23:59:59"
        sql = "SELECT lancamentos.*, Contas.NOME AS conta FROM lancamentos INNER JOIN " &
        "Contas ON lancamentos.cod_conta = Contas.CONTA where " &
        "lancamentos.data_lancamento >= " & d.pdtm(di) &
        "and lancamentos.data_lancamento <= " & d.pdtm(df) &
        " and id_filial_lancamento = " & conf.Filial &
        " and contas.classificacao like '1.3%'"
        Source(sql)
    End Sub
    Public Sub Source(ByVal iSql As String)
        sql = iSql
        Me.refreshData()
    End Sub
    Public Sub refreshData()
        d.carrega_Tabela(sql, tb)
        max = tb.Rows.Count
        primeiro()
    End Sub
    Public Sub Registro(ByVal pos As Integer)
        Dim p As Integer = pos
        If p <= 0 Then p = 0
        If p > max Then p = max
        posicao = p
        If max > 0 Then
            _cod_lancamento = tb.Rows(p)("cod_lancamento")
            _id_filial_lancamento = tb.Rows(p)("id_filial_lancamento")
            _id_filial = tb.Rows(p)("id_filial")
            _data_lancamento = rdData(tb.Rows(p)("data_lancamento"))
            _cod_conta = tb.Rows(p)("cod_conta")
            _valor = tb.Rows(p)("valor_pago")
            _cod_forma_pagamento = tb.Rows(p)("cod_forma_pagamento")
            _n_parcelas = tb.Rows(p)("n_parcelas")
            _n_parcela = tb.Rows(p)("n_parcela")
            _data_vencimento = rdData(tb.Rows(p)("data_vencimento"))
            _data_recebimento = rdData(tb.Rows(p)("data_recebimento"))
            _historico = rdTexto(tb.Rows(p)("historico"))
            _doc = rdTexto(tb.Rows(p)("doc"))
            _tipo = rdTexto(tb.Rows(p)("tipo"))
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
        trans = New objSqlTrans
        lastPos = posicao 'guarda a posição do último Registro
        'Zera Variáveis
        _cod_lancamento = Nothing
        _id_filial_lancamento = Nothing
        _id_filial = Nothing
        _data_lancamento = Nothing
        _cod_conta = Nothing
        _valor = Nothing
        _cod_forma_pagamento = Nothing
        _n_parcelas = Nothing
        _n_parcela = Nothing
        _data_vencimento = Nothing
        _data_recebimento = Nothing
        _historico = Nothing
        _doc = Nothing
        _tipo = Nothing
        _cod_fatura_lanc = Nothing
        OrigemSalvar = "Novo" 'Define o tipo de ação ao salvar
    End Function
    Public Function Salvar() As String
        Dim sql As String
        Dim res As String
        Dim chave As Integer
        d.conecta()
        If OrigemSalvar = "Novo" Then
            chave = retorna_Chave("cod_lancamento", "lancamentos", " where id_filial_lancamento = " & conf.Filial & "")
            _cod_lancamento = chave
            Try
                sql = "INSERT INTO lancamentos (cod_lancamento" &
           ",id_filial_lancamento ,id_filial,data_lancamento " &
           ",cod_conta,Valor,cod_forma_pagamento,n_parcelas,n_parcela " &
           ",data_vencimento ,data_recebimento,historico,doc,tipo,cod_fatura,acrescimo,juros,desconto,taxas,usuario_lanc, usuario_alt) " &
           "VALUES ( " &
            _cod_lancamento &
           "," & _id_filial_lancamento &
           "," & _id_filial &
           "," & d.pdtm(_data_lancamento) &
           "," & _cod_conta &
           "," & d.cdin(_valor) &
           "," & _cod_forma_pagamento &
           "," & _n_parcelas &
           "," & _n_parcela &
           "," & d.Pdt(_data_vencimento) &
           "," & d.Pdt(_data_recebimento) &
           "," & d.PStr(_historico) &
           "," & d.PStr(_doc) &
           "," & d.PStr(_tipo) &
           "," & _cod_fatura_lanc &
           "," & _acrescimo_novo &
           "," & _juros_novo &
           "," & _desconto_novo &
           "," & _taxas &
           "," & _usuario_lanc &
           "," & _usuario_alt_lanc & ")"

                res = d.Comando(sql, True)

                If _cod_cliente > 0 Then
                    insere_cliente_lancamento()
                End If

            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tb.NewRow
            r("cod_lancamento") = _cod_lancamento
            r("id_filial_lancamento") = _id_filial_lancamento
            r("id_filial") = _id_filial
            r("data_lancamento") = rdData(_data_lancamento)
            r("cod_conta") = _cod_conta
            r("valor_pago") = wrNum(_valor)
            r("cod_forma_pagamento") = _cod_forma_pagamento
            r("n_parcelas") = _n_parcelas
            r("n_parcela") = _n_parcela
            r("data_vencimento") = wrData(_data_vencimento)
            r("data_recebimento") = wrData(_data_recebimento)
            r("historico") = rdTexto(_historico)
            r("doc") = rdTexto(_doc)
            r("tipo") = rdTexto(_tipo)
            r("cod_fatura") = _cod_fatura_lanc
            r("acrescimo") = _acrescimo_novo
            r("juros") = _juros_novo
            r("desconto") = _desconto_novo
            r("taxas") = _taxas
            r("usuario_lanc") = _usuario_lanc
            r("usuario_alt") = _usuario_alt_lanc
            tb.Rows.Add(r)
            max = max + 1
            If max = 1 Then
                posicao = 0
            Else
                posicao = max - 1
            End If
            OrigemSalvar = ""
            Return "OK:" & res & " registro(s) adicionado(s) com sucesso!"
        Else
            Try
                sql = "UPDATE lancamentos SET id_filial_lancamento = " &
                _id_filial_lancamento & ",id_filial = " & _id_filial &
                ",data_lancamento = " & d.pdtm(data_lancamento) &
                ",cod_conta = " & _cod_conta & ",Valor = " & d.cdin(valor) &
                ",cod_forma_pagamento = " & _cod_forma_pagamento &
                ",n_parcelas = " & _n_parcelas &
                ",n_parcela = " & n_parcela &
                ",data_vencimento = " & d.Pdt(_data_vencimento) &
                ",data_recebimento =" & d.Pdt(_data_recebimento) &
                ",historico = " & d.PStr(_historico) &
                ",doc = " & d.PStr(_doc) &
                ",tipo = " & d.PStr(_tipo) &
                ",cod_fatura = " & _cod_fatura_lanc &
                ",acrescimo = " & _acrescimo_novo &
                ",juros = " & _juros_novo &
                ",desconto = " & _desconto_novo &
                ",taxas = " & _taxas &
                ",usuario_lanc = " & _usuario_lanc &
                ",usuario_alt = " & _usuario_alt_lanc &
                " WHERE cod_lancamento = " & Me._cod_lancamento &
                " and id_filial = " & Me._id_filial & ""

                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tb.Rows(posicao)
            r("id_filial_lancamento") = _id_filial_lancamento
            r("id_filial") = _id_filial
            r("data_lancamento") = rdData(_data_lancamento)
            r("cod_conta") = _cod_conta
            r("valor") = wrNum(_valor)
            r("cod_forma_pagamento") = _cod_forma_pagamento
            r("n_parcelas") = _n_parcelas
            r("n_parcela") = _n_parcela
            r("data_vencimento") = rdData(_data_vencimento)
            r("data_recebimento") = rdData(_data_recebimento)
            r("historico") = rdTexto(_historico)
            r("doc") = rdTexto(_doc)
            r("tipo") = rdTexto(_tipo)
            r("cod_fatura") = _cod_fatura_lanc
            r("acrescimo") = _acrescimo_novo
            r("juros") = _juros_novo
            r("desconto") = _desconto_novo
            r("taxas") = _taxas
            r("usuario_lanc") = _usuario_lanc
            r("usuario_alt") = _usuario_alt_lanc
            OrigemSalvar = ""
            Return "OK:" & res & " registro(s) atualizado(s) com sucesso!"
        End If
    End Function
    Public Function insere_cliente_lancamento() As String
        Dim tsql As String
        tsql = "INSERT INTO lancamentos_cliente (id_filial" &
           ",cod_lancamento,cod_filial_cliente,cod_cliente) " &
           "VALUES(" & _id_filial &
           "," & _cod_lancamento &
           "," & _cod_filial_cliente &
           "," & _cod_cliente & ")"
        Return d.Comando(tsql, True)
    End Function

    Public Function concluir_SQL_transaction() As String
        Return d.executa_transaction(trans.instrucoes, True)
    End Function

    Public Function deletar()
        Dim sql As String
        Dim res As String
        sql = "Delete from lancamentos where cod_lancamento = " & _cod_lancamento &
        " and id_filial_lancamento = " & _id_filial_lancamento & ""
        Try
            res = d.Comando(sql, True)
        Catch ex As Exception
            res = ex.Message
        End Try
        Me.refreshData()
        Me.primeiro()
        Return res & " Registro(s) foi(ram) apagado(s)!"
    End Function
    Public Function deletar(ByVal x_cod_lancamento As Integer, ByVal x_filial As Integer)
        Dim sql As String
        Dim res As String
        sql = "Delete from lancamentos where cod_lancamento = " & x_cod_lancamento &
        " and id_filial = " & x_filial & ""
        Try
            res = d.Comando(sql, True)
        Catch ex As Exception
            res = ex.Message
        End Try
        Me.refreshData()
        Me.primeiro()
        Return res & " Registro(s) foi(ram) apagado(s)!"
    End Function
    ''' <summary>
    ''' Função para Retornar o código do cliente de um recebimento 
    ''' de fatura para devolução de crédito em caso de cancelamento!
    ''' </summary>
    ''' <param name="x_cod_lancamento">
    ''' O código do lancamento
    ''' </param>
    ''' <param name="x_id_filial">
    ''' A filial do lancamento
    ''' </param>
    ''' <returns>
    ''' Array de strings contendo na posição 0 cod_filial_cliente e 
    ''' na posição 1 cod_cliente.
    ''' Caso nenhum cliente seja encontrado, retorna 0 na posição 0
    ''' </returns>
    Public Function Ret_cliente_lancamento_fatura(ByVal x_cod_lancamento As Integer, ByVal x_id_filial As Integer) As String()
        Dim cliente(2) As String
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "SELECT Fatura.cod_filial_cliente, Fatura.cod_cliente " &
        " FROM Fatura INNER JOIN Pagamentos_fatura ON Fatura.cod_fatura = " &
        "Pagamentos_fatura.cod_fatura AND Fatura.id_filial = " &
        "Pagamentos_fatura.id_filial where (cod_lancamento = " & x_cod_lancamento &
        ") and (id_filial_lancamento = " & x_id_filial & ")"
        d.carrega_Tabela(tsql, tt)
        If tt.Rows.Count > 0 Then
            'Passa para a posição 0 o campo cod_filial_cliente
            cliente(0) = tt.Rows(0)(0)
            'passa para a posição 1 o campo cod_cliente
            cliente(1) = tt.Rows(0)(1)
        Else
            'caso não haja cliente, retorna 0 na posição 0
            cliente(0) = 0
        End If
        Return cliente
    End Function
    Public Function Listar_Rec_fatura(ByVal x_cod_fatura As Integer, ByVal x_id_filial As Integer) As DataTable
        Dim sql As String
        Dim tb_lista As DataTable
        sql = "SELECT Pagamentos_fatura.cod_pagamento_fatura , Pagamentos_fatura.cod_fatura," &
        "lancamentos.cod_lancamento,lancamentos.id_filial_lancamento,lancamentos.id_filial,lancamentos.data_lancamento," &
        "lancamentos.cod_conta, sum(lancamentos.Valor_pago+lancamentos.acrescimo-lancamentos.desconto ) as valor," &
        "lancamentos.cod_forma_pagamento, lancamentos.n_parcelas, lancamentos.n_parcela,lancamentos.data_vencimento," &
        "lancamentos.data_recebimento,lancamentos.historico, lancamentos.doc, lancamentos.tipo, lancamentos.cod_status_lancamento," &
        "lancamentos.cod_fatura,lancamentos.acrescimo, lancamentos.juros, lancamentos.desconto, forma_pagamento.forma_pagamento " &
        "FROM lancamentos INNER JOIN " &
        " Pagamentos_fatura ON lancamentos.cod_lancamento = " &
        "Pagamentos_fatura.cod_lancamento AND " &
        "lancamentos.id_filial = Pagamentos_fatura.id_filial AND " &
        "lancamentos.id_filial_lancamento = pagamentos_fatura.id_filial_lancamento " &
        "INNER JOIN forma_pagamento ON lancamentos.cod_forma_pagamento = " &
        "forma_pagamento.cod_forma_pagamento " &
        "WHERE (Pagamentos_fatura.cod_fatura = " & x_cod_fatura & ") " &
        "AND (pagamentos_fatura.id_filial = " & x_id_filial & ")" &
        "And (lancamentos.cod_status_lancamento <> 2) " &
        "group by Pagamentos_fatura.cod_pagamento_fatura , Pagamentos_fatura.cod_fatura,lancamentos.cod_lancamento," &
        "lancamentos.id_filial_lancamento,lancamentos.id_filial,lancamentos.data_lancamento, lancamentos.cod_conta," &
        "lancamentos.cod_forma_pagamento, lancamentos.n_parcelas, lancamentos.n_parcela, lancamentos.data_vencimento," &
        "lancamentos.data_recebimento, lancamentos.historico, lancamentos.doc, lancamentos.tipo, lancamentos.cod_status_lancamento," &
        "lancamentos.cod_fatura, lancamentos.acrescimo, lancamentos.juros, lancamentos.desconto,forma_pagamento.forma_pagamento, " &
        "cliente.cod_cliente, cliente.nome_cliente"
        d.carrega_Tabela(sql, tb_lista)
        Return tb_lista
        tb_lista.Dispose()
    End Function

    Public Function Listar_Recibo(ByVal x_cod_fatura As Integer, ByVal x_id_filial As Integer) As DataTable
        Dim sql As String
        Dim tb_lista As DataTable
        sql = "SELECT Pagamentos_fatura.cod_pagamento_fatura , Pagamentos_fatura.cod_fatura," &
        "lancamentos.cod_lancamento,lancamentos.id_filial_lancamento,lancamentos.id_filial,lancamentos.data_lancamento," &
        "lancamentos.cod_conta, sum(lancamentos.Valor_pago+lancamentos.acrescimo-lancamentos.desconto ) as valor," &
        "lancamentos.cod_forma_pagamento, lancamentos.n_parcelas, lancamentos.n_parcela,lancamentos.data_vencimento," &
        "lancamentos.data_recebimento,lancamentos.historico, lancamentos.doc, lancamentos.tipo, lancamentos.cod_status_lancamento," &
        "lancamentos.cod_fatura,lancamentos.acrescimo, lancamentos.juros, lancamentos.desconto, forma_pagamento.forma_pagamento, " &
        "cliente.cod_cliente, cliente.nome_cliente FROM lancamentos INNER JOIN " &
        " Pagamentos_fatura ON lancamentos.cod_lancamento = " &
        "Pagamentos_fatura.cod_lancamento AND " &
        "lancamentos.id_filial = Pagamentos_fatura.id_filial AND " &
        "lancamentos.id_filial_lancamento = pagamentos_fatura.id_filial_lancamento " &
        "INNER JOIN forma_pagamento ON lancamentos.cod_forma_pagamento = " &
        "forma_pagamento.cod_forma_pagamento inner join lancamentos_cliente on lancamentos.cod_lancamento = lancamentos_cliente.cod_lancamento " &
        "inner join cliente on lancamentos_cliente.cod_cliente = cliente.cod_cliente " &
        "WHERE (Pagamentos_fatura.cod_fatura = " & x_cod_fatura & ") " &
        "AND (pagamentos_fatura.id_filial = " & x_id_filial & ")" &
        "And (lancamentos.cod_status_lancamento <> 2) " &
        "group by Pagamentos_fatura.cod_pagamento_fatura , Pagamentos_fatura.cod_fatura,lancamentos.cod_lancamento," &
        "lancamentos.id_filial_lancamento,lancamentos.id_filial,lancamentos.data_lancamento, lancamentos.cod_conta," &
        "lancamentos.cod_forma_pagamento, lancamentos.n_parcelas, lancamentos.n_parcela, lancamentos.data_vencimento," &
        "lancamentos.data_recebimento, lancamentos.historico, lancamentos.doc, lancamentos.tipo, lancamentos.cod_status_lancamento," &
        "lancamentos.cod_fatura, lancamentos.acrescimo, lancamentos.juros, lancamentos.desconto,forma_pagamento.forma_pagamento, cliente.cod_cliente, cliente.nome_cliente"
        d.carrega_Tabela(sql, tb_lista)
        Return tb_lista
        tb_lista.Dispose()
    End Function
    Public Function Listar_Rec_credito(ByVal x_cod_credito As Integer, ByVal x_id_filial As Integer) As DataTable
        Dim tsql As String
        Dim tb_lista As DataTable
        tsql = "SELECT lancamentos.*, forma_pagamento.forma_pagamento, " &
        "pagamentos_credito.cod_credito FROM lancamentos INNER JOIN " &
        "forma_pagamento ON lancamentos.cod_forma_pagamento = " &
        "forma_pagamento.cod_forma_pagamento INNER JOIN " &
        "pagamentos_credito ON lancamentos.cod_lancamento = " &
        "pagamentos_credito.cod_lancamento AND " &
        "lancamentos.id_filial = pagamentos_credito.id_filial " &
        "WHERE (pagamentos_credito.id_filial = " & x_id_filial &
        " and pagamentos_credito.cod_credito = " & x_cod_credito & ") " &
        "and (lancamentos.cod_status_lancamento <> 2)"
        d.carrega_Tabela(tsql, tb_lista)
        Return tb_lista
        tb_lista.Dispose()
    End Function

    Public Function Listar_Rec_acordo(ByVal x_cod_acordo As Integer, ByVal x_id_filial As Integer, ByVal tipo As Integer) As DataTable
        Dim tsql As String
        Dim tb_lista As DataTable
        If tipo = 0 Then
            tsql = "SELECT cliente.cod_cliente, cliente.nome_cliente, cliente.razao_social, cliente.cnpj, cliente.ie, cliente.endereco, cliente.numero," &
                "cliente.bairro, cliente.municipio, cliente.cep, cliente.uf, lancamentos.*," &
            "SUM(lancamentos.valor+Pagamentos_acordo.acrescimo+Pagamentos_acordo.juros+Pagamentos_acordo.taxas-Pagamentos_acordo.desconto) as valortotal," &
            "lancamentos.juros,lancamentos.desconto," &
            "SUM((lancamentos.valor_pago+Pagamentos_acordo.acrescimo+Pagamentos_acordo.juros-Pagamentos_acordo.desconto+Pagamentos_acordo.taxas) + (lancamentos.juros - lancamentos.desconto)) as ValorPago," &
            "forma_pagamento.forma_pagamento, " &
            "pagamentos_acordo.cod_acordo, isnull(Pagamentos_acordo.desconto,0) as descacordo FROM lancamentos INNER JOIN " &
            "forma_pagamento ON lancamentos.cod_forma_pagamento = " &
            "forma_pagamento.cod_forma_pagamento INNER JOIN " &
            "pagamentos_acordo ON lancamentos.cod_lancamento = " &
            "pagamentos_acordo.cod_lancamento AND " &
            "lancamentos.id_filial = pagamentos_acordo.id_filial " &
            "INNER JOIN cliente_acordo ON cliente_acordo.cod_acordo = Pagamentos_acordo.cod_acordo and " &
            "cliente_acordo.cod_filial_cliente = lancamentos.id_filial " &
            "INNER JOIN cliente ON cliente.cod_cliente = cliente_acordo.cod_cliente " &
            "WHERE (pagamentos_acordo.id_filial = " & x_id_filial &
            " and pagamentos_acordo.cod_acordo = " & x_cod_acordo & ") " &
            "and (lancamentos.cod_status_lancamento <> 2) " &
            "group by lancamentos.cod_lancamento, lancamentos.id_filial_lancamento, lancamentos.id_filial, lancamentos.data_lancamento," &
            "lancamentos.cod_conta, lancamentos.Valor_pago, lancamentos.cod_forma_pagamento, lancamentos.n_parcelas, lancamentos.n_parcela," &
            "lancamentos.data_vencimento, lancamentos.data_recebimento, lancamentos.historico, lancamentos.doc, lancamentos.tipo," &
            "lancamentos.cod_status_lancamento, lancamentos.cod_fatura, lancamentos.acrescimo, lancamentos.juros, lancamentos.desconto," &
            "forma_pagamento.forma_pagamento, pagamentos_acordo.cod_acordo, cliente.nome_cliente, cliente.cod_cliente, lancamentos.taxas," &
            "cliente.razao_social, cliente.cnpj, cliente.ie, cliente.endereco, cliente.numero,cliente.bairro, cliente.municipio, cliente.cep," &
            "pagamentos_acordo.desconto, cliente.uf, lancamentos.usuario_lanc, lancamentos.usuario_alt"
        Else
            tsql = "SELECT cliente.cod_cliente, cliente.nome_cliente, cliente.razao_social, cliente.cnpj, cliente.ie, cliente.endereco, cliente.numero," &
                "cliente.bairro, cliente.municipio, cliente.cep, cliente.uf, lancamentos.*," &
            "SUM(lancamentos.valor_pago+Pagamentos_acordo.acrescimo+Pagamentos_acordo.juros+Pagamentos_acordo.taxas-Pagamentos_acordo.desconto) as valortotal," &
            "lancamentos.juros,lancamentos.desconto," &
            "SUM((lancamentos.valor_pago+Pagamentos_acordo.acrescimo+Pagamentos_acordo.juros-Pagamentos_acordo.desconto+Pagamentos_acordo.taxas) + (lancamentos.juros - lancamentos.desconto)) as ValorPago," &
            "forma_pagamento.forma_pagamento, " &
            "pagamentos_acordo.cod_acordo, isnull(Pagamentos_acordo.desconto,0) as descacordo FROM lancamentos INNER JOIN " &
            "forma_pagamento ON lancamentos.cod_forma_pagamento = " &
            "forma_pagamento.cod_forma_pagamento INNER JOIN " &
            "pagamentos_acordo ON lancamentos.cod_lancamento = " &
            "pagamentos_acordo.cod_lancamento AND " &
            "lancamentos.id_filial = pagamentos_acordo.id_filial " &
            "INNER JOIN cliente_acordo ON cliente_acordo.cod_acordo = Pagamentos_acordo.cod_acordo and " &
            "cliente_acordo.cod_filial_cliente = lancamentos.id_filial " &
            "INNER JOIN cliente ON cliente.cod_cliente = cliente_acordo.cod_cliente " &
            "WHERE (pagamentos_acordo.id_filial = " & x_id_filial &
            " and pagamentos_acordo.cod_acordo = " & x_cod_acordo & ") " &
            "and (lancamentos.cod_status_lancamento <> 2) " &
            "group by lancamentos.cod_lancamento, lancamentos.id_filial_lancamento, lancamentos.id_filial, lancamentos.data_lancamento," &
            "lancamentos.cod_conta, lancamentos.Valor_pago, lancamentos.cod_forma_pagamento, lancamentos.n_parcelas, lancamentos.n_parcela," &
            "lancamentos.data_vencimento, lancamentos.data_recebimento, lancamentos.historico, lancamentos.doc, lancamentos.tipo," &
            "lancamentos.cod_status_lancamento, lancamentos.cod_fatura, lancamentos.acrescimo, lancamentos.juros, lancamentos.desconto," &
            "forma_pagamento.forma_pagamento, pagamentos_acordo.cod_acordo, cliente.nome_cliente, cliente.cod_cliente, lancamentos.taxas," &
            "cliente.razao_social, cliente.cnpj, cliente.ie, cliente.endereco, cliente.numero,cliente.bairro, cliente.municipio, cliente.cep," &
            "pagamentos_acordo.desconto, cliente.uf, lancamentos.usuario_lanc, lancamentos.usuario_alt"
        End If
        d.carrega_Tabela(tsql, tb_lista)
        Return tb_lista
        tb_lista.Dispose()
    End Function

    Public Function Listar_Rec_acordo(ByVal x_cod_acordo As Integer, ByVal x_id_filial As Integer) As DataTable
        Dim tsql As String
        Dim tb_lista As DataTable
        tsql = "SELECT cliente.cod_cliente, cliente.nome_cliente, lancamentos.*," &
        "SUM(lancamentos.valor_pago+Pagamentos_acordo.acrescimo+Pagamentos_acordo.juros-Pagamentos_acordo.desconto+Pagamentos_acordo.taxas) as valortotal," &
        "lancamentos.juros,lancamentos.desconto," &
        "SUM((lancamentos.valor_pago+Pagamentos_acordo.acrescimo+Pagamentos_acordo.juros-Pagamentos_acordo.desconto+Pagamentos_acordo.taxas) + (lancamentos.juros - lancamentos.desconto)) as ValorPago," &
        "forma_pagamento.forma_pagamento, " &
        "pagamentos_acordo.cod_acordo FROM lancamentos INNER JOIN " &
        "forma_pagamento ON lancamentos.cod_forma_pagamento = " &
        "forma_pagamento.cod_forma_pagamento INNER JOIN " &
        "pagamentos_acordo ON lancamentos.cod_lancamento = " &
        "pagamentos_acordo.cod_lancamento AND " &
        "lancamentos.id_filial = pagamentos_acordo.id_filial " &
        "INNER JOIN cliente_acordo ON cliente_acordo.cod_acordo = Pagamentos_acordo.cod_acordo and " &
        "cliente_acordo.cod_filial_cliente = lancamentos.id_filial " &
        "INNER JOIN cliente ON cliente.cod_cliente = cliente_acordo.cod_cliente " &
        "WHERE (pagamentos_acordo.id_filial = " & x_id_filial &
        " and pagamentos_acordo.cod_acordo = " & x_cod_acordo & ") " &
        "and (lancamentos.cod_status_lancamento <> 2) " &
        "group by lancamentos.cod_lancamento, lancamentos.id_filial_lancamento, lancamentos.id_filial, lancamentos.data_lancamento," &
        "lancamentos.cod_conta, lancamentos.Valor_pago, lancamentos.cod_forma_pagamento, lancamentos.n_parcelas, lancamentos.n_parcela," &
        "lancamentos.data_vencimento, lancamentos.data_recebimento, lancamentos.historico, lancamentos.doc, lancamentos.tipo," &
        "lancamentos.cod_status_lancamento, lancamentos.cod_fatura, lancamentos.acrescimo, lancamentos.juros, lancamentos.desconto," &
        "forma_pagamento.forma_pagamento, pagamentos_acordo.cod_acordo, cliente.nome_cliente, cliente.cod_cliente, lancamentos.taxas, " &
        "lancamentos.usuario_lanc, lancamentos.usuario_alt"
        d.carrega_Tabela(tsql, tb_lista)
        Return tb_lista
        tb_lista.Dispose()
    End Function

    Public Function total_rec_fatura(ByVal x_cod_fatura As Integer, ByVal x_id_filial As Integer) As Double
        Dim sql As String
        Dim tbTotal As New DataTable
        sql = "SELECT     SUM(lancamentos.Valor_pago+lancamentos.acrescimo-lancamentos.desconto) AS Total " &
        "FROM lancamentos INNER JOIN " &
        "Pagamentos_fatura ON lancamentos.cod_lancamento = Pagamentos_fatura.cod_lancamento " &
        "AND lancamentos.id_filial = Pagamentos_fatura.id_filial " &
        "WHERE (Pagamentos_fatura.cod_fatura = " & x_cod_fatura & ") AND " &
        "(Pagamentos_fatura.id_filial = " & x_id_filial & ") " &
        "AND (lancamentos.cod_status_lancamento IN (1,3))"
        d.carrega_Tabela(sql, tbTotal)
        If tbTotal.Rows.Count > 0 Then
            If IsDBNull(tbTotal.Rows(0)("total")) = True Then
                Return Nothing
            Else
                Return tbTotal.Rows(0)("total")
            End If
        End If
    End Function
    Public Function total_rec_credito(ByVal x_cod_credito As Integer, ByVal x_id_filial As Integer) As Double
        Dim sql As String
        Dim tbTotal As New DataTable
        sql = "SELECT     SUM(lancamentos.Valor_pago) AS Total " &
        "FROM lancamentos INNER JOIN pagamentos_credito ON " &
        "lancamentos.cod_lancamento = pagamentos_credito.cod_lancamento AND " &
        "lancamentos.id_filial = pagamentos_credito.id_filial " &
        "WHERE (pagamentos_credito.cod_credito = " & x_cod_credito & ") AND " &
        "(pagamentos_credito.id_filial = " & x_id_filial & ") " &
        " and (lancamentos.cod_status_lancamento <> 2)"
        d.carrega_Tabela(sql, tbTotal)
        If tbTotal.Rows.Count > 0 Then
            If IsDBNull(tbTotal.Rows(0)("total")) = True Then
                Return Nothing
            Else
                Return tbTotal.Rows(0)("total")
            End If
        End If
    End Function
    Public Function listar_despesas_data(ByVal dtInicial As Date, ByVal dtFinal As Date, ByVal filial As Integer) As DataTable
        Dim sql As String
        Dim tt As New DataTable
        Dim di, df As String

        di = extrai_data_dmy(dtInicial) & " 00:00:01"
        df = extrai_data_dmy(dtFinal) & " 23:59:59"
        sql = "SELECT lancamentos.*, Contas.NOME AS conta FROM lancamentos INNER JOIN " &
        "Contas ON lancamentos.cod_conta = Contas.CONTA where " &
        "lancamentos.data_lancamento >= " & d.pdtm(di) &
        "and lancamentos.data_lancamento <= " & d.pdtm(df) &
        " and id_filial_lancamento = " & filial &
        " and contas.tipo  = 'S' " &
        " and (lancamentos.cod_status_lancamento <> 2)"
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function listar_outras_receitas_data(ByVal dia As Date) As DataTable
        Dim sql As String
        Dim tt As New DataTable
        Dim di, df As String

        di = extrai_data_dmy(dia) & " 00:00:01"
        df = extrai_data_dmy(dia) & " 23:59:59"
        sql = "SELECT lancamentos.*, Contas.NOME AS conta FROM lancamentos INNER JOIN " &
        "Contas ON lancamentos.cod_conta = Contas.CONTA where " &
        "lancamentos.data_lancamento >= " & d.pdtm(di) &
        "and lancamentos.data_lancamento <= " & d.pdtm(df) &
        " and id_filial_lancamento = " & conf.Filial &
        " and contas.classificacao like '1.3%' " &
        " and (lancamentos.cod_status_lancamento <> 2)"
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function total_despesas_data(ByVal dtIni As Date, ByVal dtFim As Date, ByVal filial As Int16) As Double
        Dim sql As String
        Dim tt As New DataTable
        Dim di, df As String

        di = extrai_data_dmy(dtIni) & " 00:00:01"
        df = extrai_data_dmy(dtFim) & " 23:59:59"
        sql = "select SUM(lancamentos.Valor_pago) AS Total FROM lancamentos INNER JOIN " &
        "Contas ON lancamentos.cod_conta = Contas.CONTA where " &
        "lancamentos.data_lancamento >= " & d.pdtm(di) &
        "and lancamentos.data_lancamento <= " & d.pdtm(df) &
        " and id_filial_lancamento = " & filial &
        " and contas.tipo  = 'S' " &
        " and (lancamentos.cod_status_lancamento <> 2)"
        d.carrega_Tabela(sql, tt)
        Try
            If tt.Rows.Count > 0 Then
                Return tt.Rows(0)("total")
            Else
                Return 0
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function listar_receitas_data(ByVal dtInicial As Date, ByVal dtFinal As Date, ByVal filial As Integer) As DataTable
        Dim sql As String
        Dim tt As New DataTable
        Dim di, df As String
        di = extrai_data_dmy(dtInicial) & " 00:00:01"
        df = extrai_data_dmy(dtFinal) & " 23:59:59"
        sql = "select fp.forma_pagamento, l.cod_forma_pagamento, l.historico, l.Valor_Pago, l.acrescimo, l.juros, l.desconto, l.taxas, " &
            "l.data_lancamento, l.doc, l.cod_fatura, f.cod_cliente, c.nome_cliente, l.data_recebimento from lancamentos l inner join forma_pagamento fp on " &
            "fp.cod_forma_pagamento = l.cod_forma_pagamento inner join Fatura f on l.cod_fatura = f.cod_fatura and l.id_filial = f.id_filial inner join cliente c " &
            "on f.cod_cliente = c.cod_cliente  And f.id_filial = c.cod_filial_cliente " &
            "where l.data_recebimento >= " & d.Pdt(di) & " and l.data_recebimento <= " & d.Pdt(df) & " and l.tipo IN ('E','R') and " &
            "l.id_filial = " & filial

        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function listar_resumo_formas_pagamento(ByVal dtInicial As Date, ByVal dtFinal As Date, ByVal filial As Integer)
        Dim sql, strSQL As String
        Dim di, df As Date
        Dim tt As New DataTable
        Dim ttTeste As New DataTable
        Dim i, j As Int16
        Dim valor As Double
        di = dtInicial.Date & " 00:00:00"
        df = dtFinal.Date & " 23:59:59"
        sql = "SELECT SUM((lancamentos.Valor_pago+lancamentos.acrescimo+lancamentos.juros+lancamentos.taxas-lancamentos.desconto) +" &
        "ISNULL((Pagamentos_acordo.acrescimo+Pagamentos_acordo.juros+Pagamentos_acordo.taxas-Pagamentos_acordo.desconto),0)) as Total," &
        "lancamentos.cod_forma_pagamento, forma_pagamento.forma_pagamento " &
        "FROM lancamentos INNER JOIN  forma_pagamento ON lancamentos.cod_forma_pagamento " &
        "= forma_pagamento.cod_forma_pagamento " &
        "LEFT JOIN Pagamentos_acordo ON LANCAMENTOS.cod_lancamento = Pagamentos_acordo.cod_lancamento AND lancamentos.id_filial = Pagamentos_acordo.id_filial" &
        " WHERE (lancamentos.data_recebimento >= " & d.Pdt(di) &
        " and lancamentos.data_recebimento <= " & d.Pdt(df) &
        " and lancamentos.tipo <> 'S' " &
        " and (lancamentos.cod_status_lancamento = 1)" &
        " and (lancamentos.id_filial_lancamento = " & filial & ")" &
        ") GROUP BY lancamentos.cod_forma_pagamento,forma_pagamento.forma_pagamento"

        strSQL = "SELECT SUM((lancamentos.Valor_Pago+lancamentos.acrescimo+lancamentos.juros+lancamentos.taxas-lancamentos.desconto) +" &
        "ISNULL((Pagamentos_acordo.acrescimo+Pagamentos_acordo.juros+Pagamentos_acordo.taxas-Pagamentos_acordo.desconto),0)) as Total," &
        "lancamentos.cod_forma_pagamento, forma_pagamento.forma_pagamento " &
        "FROM lancamentos INNER JOIN  forma_pagamento ON lancamentos.cod_forma_pagamento " &
        "= forma_pagamento.cod_forma_pagamento " &
        "LEFT JOIN Pagamentos_acordo ON LANCAMENTOS.cod_lancamento = Pagamentos_acordo.cod_lancamento AND lancamentos.id_filial = Pagamentos_acordo.id_filial" &
        " WHERE (lancamentos.data_recebimento >= " & d.Pdt(di) &
        " and lancamentos.data_recebimento <= " & d.Pdt(df) &
        " and lancamentos.tipo <> 'S' " &
        " and (lancamentos.cod_status_lancamento = 1)" &
        " and (lancamentos.id_filial_lancamento IN (1,2,3,4))" &
        ") GROUP BY lancamentos.cod_forma_pagamento,forma_pagamento.forma_pagamento"

        d.carrega_Tabela(strSQL, ttTeste)

        For j = 0 To ttTeste.Rows.Count - 1
            If ttTeste.Rows(j)("cod_forma_pagamento") = 8 Then
                valor = valor + ttTeste.Rows(j)("total")
            End If
        Next

        d.carrega_Tabela(sql, tt)

        For i = 0 To tt.Rows.Count - 1
            If tt.Rows(i)("cod_forma_pagamento") = 8 Then
                tt.Rows(i)("total") = Format(valor, "#,##0.00")
            End If

            If conf.Filial <> 1 Then
                If tt.Rows(i)("cod_forma_pagamento") = 8 Then
                    tt.Rows(i)("total") = Format(0, "#,##0.00")
                End If
            End If
        Next

        Return tt
    End Function

    Public Function listar_resumo_caixa_receita(ByVal diaini As Date, ByVal diafim As Date, ByVal filial As Integer)
        Dim sql As String
        Dim dtdiaini, dtdiafim, dtmesini, dtmesfim, dtmesantini, dtmesantfim, dtanoini, dtanofim As DateTime
        Dim tt As New DataTable
        Dim intMes, intMesAtual, intMesAnterior, intAnoAtual As Int32
        dtdiaini = diaini.Date & " 00:00:01"
        dtdiafim = diafim.Date & " 23:59:59"

        intMes = dtdiaini.Month
        If intMes = 1 Then
            dtmesini = "01" & "/" & dtdiaini.Month & "/" & dtdiaini.Year & " 00:00:01"
            dtmesfim = dtdiafim.Date & " 23:59:59"

            dtmesantini = "01" & "/" & 12 & "/" & dtdiaini.Year - 1 & " 00:00:01"
            dtmesantfim = dtdiafim.Day & "/" & 12 & "/" & dtdiafim.Year - 1 & " 23:59:59"

            dtanoini = "01" & "/" & dtdiaini.Month & "/" & dtdiaini.Year - 1 & " 00:00:01"
            dtanofim = dtdiafim.Day & "/" & dtdiafim.Month & "/" & dtdiafim.Year - 1 & " 23:59:59"
        Else
            dtmesini = "01" & "/" & dtdiaini.Month & "/" & dtdiaini.Year & " 00:00:01"
            dtmesfim = dtdiafim.Date & " 23:59:59"

            If diaini.Month = 3 Then
                If diaini.Day > 28 Then
                    dtmesantini = "01" & "/" & dtdiaini.Month - 1 & "/" & dtdiaini.Year & " 00:00:01"
                    dtmesantfim = 28 & "/" & dtdiafim.Month - 1 & "/" & dtdiafim.Year & " 23:59:59"
                    GoTo prossegue
                End If
            End If

            If diaini.Day = 31 Then
                dtmesantini = "01" & "/" & dtdiaini.Month - 1 & "/" & dtdiaini.Year & " 00:00:01"
                dtmesantfim = dtdiafim.Day - 1 & "/" & dtdiafim.Month - 1 & "/" & dtdiafim.Year & " 23:59:59"
                GoTo prossegue
            End If


            dtmesantini = "01" & "/" & dtdiaini.Month - 1 & "/" & dtdiaini.Year & " 00:00:01"
            dtmesantfim = dtdiafim.Day & "/" & dtdiafim.Month - 1 & "/" & dtdiafim.Year & " 23:59:59"

prossegue:
            dtanoini = "01" & "/" & dtdiaini.Month & "/" & dtdiaini.Year - 1 & " 00:00:01"
            dtanofim = dtdiafim.Day & "/" & dtdiafim.Month & "/" & dtdiafim.Year - 1 & " 23:59:59"
        End If


        sql = "select forma_pagamento.*, ISNULL((select sum(lancamentos.Valor_Pago+lancamentos.acrescimo+lancamentos.juros+lancamentos.taxas-lancamentos.desconto) + " &
            "isnull(sum(Pagamentos_acordo.acrescimo + Pagamentos_acordo.juros + Pagamentos_acordo.taxas - Pagamentos_acordo.desconto), 0) " &
            "from lancamentos left join Pagamentos_acordo on lancamentos.cod_lancamento = Pagamentos_acordo.cod_lancamento and lancamentos.id_filial = Pagamentos_acordo.id_filial " &
            "where lancamentos.cod_forma_pagamento = forma_pagamento.cod_forma_pagamento and lancamentos.data_recebimento >= " & d.pdtm(dtdiaini) & " and lancamentos.data_recebimento <= " & d.pdtm(dtdiafim) & " and lancamentos.tipo <> 'S' " &
            "and lancamentos.cod_status_lancamento = 1 and lancamentos.cod_forma_pagamento = forma_pagamento.cod_forma_pagamento  and lancamentos.id_filial_lancamento = 1),0) as receita_dia," &
            "ISNULL((select sum(lancamentos.Valor_Pago+lancamentos.acrescimo+lancamentos.juros+lancamentos.taxas-lancamentos.desconto) + " &
            "isnull(sum(Pagamentos_acordo.acrescimo + Pagamentos_acordo.juros + Pagamentos_acordo.taxas - Pagamentos_acordo.desconto), 0) " &
            "from lancamentos left join Pagamentos_acordo on lancamentos.cod_lancamento = Pagamentos_acordo.cod_lancamento and lancamentos.id_filial = Pagamentos_acordo.id_filial " &
            "where lancamentos.cod_forma_pagamento = forma_pagamento.cod_forma_pagamento and lancamentos.data_recebimento >= " & d.pdtm(dtmesini) & " and lancamentos.data_recebimento <= " & d.pdtm(dtmesfim) & " and lancamentos.tipo <> 'S' " &
            "and lancamentos.cod_status_lancamento = 1 and lancamentos.cod_forma_pagamento = forma_pagamento.cod_forma_pagamento  and lancamentos.id_filial_lancamento = 1),0) as receita_mes, " &
            "ISNULL((select sum(lancamentos.Valor_Pago+lancamentos.acrescimo+lancamentos.juros+lancamentos.taxas-lancamentos.desconto) + " &
            "isnull(sum(Pagamentos_acordo.acrescimo + Pagamentos_acordo.juros + Pagamentos_acordo.taxas - Pagamentos_acordo.desconto), 0) " &
            "from lancamentos left join Pagamentos_acordo on lancamentos.cod_lancamento = Pagamentos_acordo.cod_lancamento and lancamentos.id_filial = Pagamentos_acordo.id_filial " &
            "where lancamentos.cod_forma_pagamento = forma_pagamento.cod_forma_pagamento and lancamentos.data_recebimento >= " & d.pdtm(dtmesantini) & " and lancamentos.data_recebimento <= " & d.pdtm(dtmesantfim) & " and lancamentos.tipo <> 'S' " &
            "and lancamentos.cod_status_lancamento = 1 and lancamentos.cod_forma_pagamento = forma_pagamento.cod_forma_pagamento  and lancamentos.id_filial_lancamento = 1),0) as receita_mes_anterior," &
            "ISNULL((select sum(lancamentos.Valor_Pago+lancamentos.acrescimo+lancamentos.juros+lancamentos.taxas-lancamentos.desconto) + " &
            "isnull(sum(Pagamentos_acordo.acrescimo + Pagamentos_acordo.juros + Pagamentos_acordo.taxas - Pagamentos_acordo.desconto), 0) " &
            "from lancamentos left join Pagamentos_acordo on lancamentos.cod_lancamento = Pagamentos_acordo.cod_lancamento " &
            "and lancamentos.id_filial = Pagamentos_acordo.id_filial where lancamentos.cod_forma_pagamento = forma_pagamento.cod_forma_pagamento and " &
            "lancamentos.data_recebimento >= " & d.pdtm(dtanoini) & " and lancamentos.data_recebimento <= " & d.pdtm(dtanofim) & " and lancamentos.tipo <> 'S' " &
            "and lancamentos.cod_status_lancamento = 1 and lancamentos.cod_forma_pagamento = forma_pagamento.cod_forma_pagamento  and lancamentos.id_filial_lancamento = 1),0) as receita_ano_anterior " &
            "from forma_pagamento where (ISNULL((select sum(lancamentos.Valor_Pago+lancamentos.acrescimo+lancamentos.juros+lancamentos.taxas-lancamentos.desconto) + " &
            "isnull(sum(Pagamentos_acordo.acrescimo + Pagamentos_acordo.juros + Pagamentos_acordo.taxas - Pagamentos_acordo.desconto), 0) " &
            "from lancamentos left join Pagamentos_acordo on lancamentos.cod_lancamento = Pagamentos_acordo.cod_lancamento and lancamentos.id_filial = Pagamentos_acordo.id_filial " &
            "where lancamentos.cod_forma_pagamento = forma_pagamento.cod_forma_pagamento and lancamentos.data_recebimento >= " & d.pdtm(dtdiaini) & " and lancamentos.data_recebimento <= " & d.pdtm(dtdiafim) & " and lancamentos.tipo <> 'S' " &
            "and lancamentos.cod_status_lancamento = 1 and lancamentos.cod_forma_pagamento = forma_pagamento.cod_forma_pagamento  and lancamentos.id_filial_lancamento = 1),0) > 0) and forma_pagamento.cod_forma_pagamento  <> 9 "
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function

    Public Function listar_resumo_caixa_despesa(ByVal diaini As Date, ByVal diafim As Date, ByVal filial As Integer)
        Dim sql As String
        Dim dtdiaini, dtdiafim, dtmesini, dtmesfim, dtmesantini, dtmesantfim, dtanoini, dtanofim As Date
        Dim tt As New DataTable
        Dim intMes, intMesAtual, intMesAnterior, intAnoAtual As Int32
        dtdiaini = diaini.Date & " 00:00:01"
        dtdiafim = diafim.Date & " 23:59:59"
        intMes = dtdiaini.Month
        If intMes = 1 Then
            dtmesini = "01" & "/" & dtdiaini.Month & "/" & dtdiaini.Year & " 00:00:01"
            dtmesfim = dtdiafim.Date & " 23:59:59"

            dtmesantini = "01" & "/" & 12 & "/" & dtdiaini.Year - 1 & " 00:00:01"
            dtmesantfim = dtdiafim.Day & "/" & 12 & "/" & dtdiafim.Year - 1 & " 23:59:59"

            dtanoini = "01" & "/" & dtdiaini.Month & "/" & dtdiaini.Year - 1 & " 00:00:01"
            dtanofim = dtdiafim.Day & "/" & dtdiafim.Month & "/" & dtdiafim.Year - 1 & " 23:59:59"
        Else
            dtmesini = "01" & "/" & dtdiaini.Month & "/" & dtdiaini.Year & " 00:00:01"
            dtmesfim = dtdiafim.Date & " 23:59:59"

            If diaini.Month = 3 Then
                If diaini.Day > 28 Then
                    dtmesantini = "01" & "/" & dtdiaini.Month - 1 & "/" & dtdiaini.Year & " 00:00:01"
                    dtmesantfim = 28 & "/" & dtdiafim.Month - 1 & "/" & dtdiafim.Year & " 23:59:59"
                    GoTo prossegue
                End If
            End If

            If diaini.Day = 31 Then
                dtmesantini = "01" & "/" & dtdiaini.Month - 1 & "/" & dtdiaini.Year & " 00:00:01"
                dtmesantfim = dtdiafim.Day - 1 & "/" & dtdiafim.Month - 1 & "/" & dtdiafim.Year & " 23:59:59"
                GoTo prossegue
            End If

            dtmesantini = "01" & "/" & dtdiaini.Month - 1 & "/" & dtdiaini.Year & " 00:00:01"
            dtmesantfim = dtdiafim.Day & "/" & dtdiafim.Month - 1 & "/" & dtdiafim.Year & " 23:59:59"

prossegue:
            dtanoini = "01" & "/" & dtdiaini.Month & "/" & dtdiaini.Year - 1 & " 00:00:01"
            dtanofim = dtdiafim.Day & "/" & dtdiafim.Month & "/" & dtdiafim.Year - 1 & " 23:59:59"
        End If

        sql = "SELECT contas.*," &
            "ISNULL((select sum(lancamentos.valor_Pago) from lancamentos where lancamentos.data_recebimento >= " & d.pdtm(dtdiaini) & " and lancamentos.data_recebimento <= " & d.pdtm(dtdiafim) &
            "and lancamentos.cod_conta = contas.CONTA and lancamentos.id_filial = 1 and contas.TIPO = 'S'),0) as despesas_dia," &
            "ISNULL((select sum(lancamentos.valor_pago) from lancamentos where lancamentos.data_recebimento >= " & d.pdtm(dtmesini) & " and lancamentos.data_recebimento <= " & d.pdtm(dtmesfim) &
            "and lancamentos.cod_conta = contas.CONTA and lancamentos.id_filial = 1 and contas.TIPO = 'S'),0) as acumulado_mes," &
            "ISNULL((select sum(lancamentos.valor_pago) from lancamentos where lancamentos.data_recebimento >= " & d.pdtm(dtmesantini) & " and lancamentos.data_recebimento <= " & d.pdtm(dtmesantfim) &
            "and lancamentos.cod_conta = contas.CONTA and lancamentos.id_filial = 1 and contas.TIPO = 'S'),0) as despesa_mes_anterior," &
            "ISNULL((select sum(lancamentos.valor_pago) from lancamentos where lancamentos.data_recebimento >= " & d.pdtm(dtanoini) & " and lancamentos.data_recebimento <= " & d.pdtm(dtanofim) &
            "and lancamentos.cod_conta = contas.CONTA and lancamentos.id_filial = 1 and contas.TIPO = 'S'),0) as despesas_ano_anterior " &
            "from contas where tipo= 'S' and (ISNULL((select sum(lancamentos.valor_pago) from lancamentos where lancamentos.data_recebimento >= " & d.pdtm(dtmesini) & " and lancamentos.data_recebimento <= " & d.pdtm(dtmesfim) &
            "and lancamentos.cod_conta = contas.CONTA and lancamentos.id_filial = 1 and contas.TIPO = 'S'),0) > 0) or " &
            "(ISNULL((select sum(lancamentos.valor_pago) from lancamentos where lancamentos.data_recebimento >= " & d.pdtm(dtmesantini) & " and lancamentos.data_recebimento <= " & d.pdtm(dtmesantfim) &
            "and lancamentos.cod_conta = contas.CONTA and lancamentos.id_filial = 1 and contas.TIPO = 'S'),0) > 0)"

        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function listar_resumo_creditos_dia(ByVal dtIni As Date, ByVal dtFim As Date, ByVal filial As Integer) As DataTable
        Dim sql As String
        Dim di, df As Date
        Dim tt As New DataTable
        di = dtIni.Date & " 00:00:00"
        df = dtFim.Date & " 23:59:59"
        sql = "SELECT cliente.nome_cliente, credito_cliente.Credito_anterior, " &
        "credito_cliente.credito, credito_cliente.saldo, credito_cliente.historico," &
        "Usuarios.NOME FROM credito_cliente INNER JOIN cliente ON " &
        "credito_cliente.cod_filial_cliente = cliente.cod_filial_cliente AND " &
        "credito_cliente.cod_cliente = cliente.cod_cliente INNER JOIN " &
        "Usuarios ON credito_cliente.id_usuario = Usuarios.cod_usuario" &
        " WHERE (credito_cliente.data >= " & d.pdtm(di) &
        " and credito_cliente.data <= " & d.pdtm(df) &
        " and credito_cliente.id_filial = " & filial &
        " ) Order by cliente.nome_cliente, credito_cliente.data"
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function cancelar_lancamento(ByVal x_cod_lancamento As Integer, ByVal x_id_filial As Integer,
                                        ByVal x_cod_usuario As Integer, ByVal x_id_filial_canc As Integer,
                                        ByVal x_descricao As String, ByVal x_data_canc As String) As String
        Dim tSql As String
        Dim cod_cancelamento As Integer
        Dim trans As New objSqlTrans
        cod_cancelamento = retorna_Chave("cod_cancelamento", "cancelamento_lancamento" _
                                         , " where id_filial_cancelamento = " & x_id_filial_canc & "")
        tSql = "INSERT INTO cancelamento_lancamento (cod_cancelamento " &
           ",id_filial_cancelamento,cod_usuario,cod_lancamento,id_filial " &
           ",descricao,data_cancelamento) VALUES(" &
           cod_cancelamento &
           "," & x_id_filial_canc &
           "," & x_cod_usuario &
           "," & x_cod_lancamento &
           "," & x_id_filial &
           "," & d.PStr(x_descricao) &
           "," & d.Pdt(x_data_canc) & ")"
        trans.insere_instrucao(tSql)
        Me.filtrar(x_cod_lancamento, x_id_filial)
        'Caso o lancamento seja um recebimento de crédito de cliente 
        'ou crédito de pacote, faz a devolução do crédito para o cliente
        If _cod_forma_pagamento = 6 Or _cod_forma_pagamento = 9 Then
            Dim credito As New objCreditoCliente
            Dim cliente As String()
            cliente = Ret_cliente_lancamento_fatura(_cod_lancamento, _id_filial_lancamento)
            If cliente(0) = 0 Then

            Else
                credito.novo()
                credito.id_filial = _id_filial_lancamento
                credito.id_usuario = x_cod_usuario
                credito.cod_filial_cliente = cliente(0)
                credito.cod_cliente = cliente(1)
                credito.data = Now
                credito.credito = _valor
                credito.historico = "Devolução de crédito do cliente pois o " &
                "recebimento do lancamento nº " & _id_filial_lancamento & "-" &
                _cod_lancamento & " foi cancelado. " & x_descricao & ""
                trans.insere_instrucao(credito.salvar_trans)
            End If
        End If
        tSql = "UPDATE lancamentos set cod_status_lancamento = 2 " & "," & " usuario_alt = " & x_cod_usuario &
            "WHERE cod_lancamento = " & x_cod_lancamento &
            " and id_filial_lancamento = " & x_id_filial & ""
        trans.insere_instrucao(tSql)
        Return d.executa_transaction(trans.instrucoes, True)
    End Function
#End Region
End Class
