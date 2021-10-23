Public Class objClienteNovo
    Dim pacote As objPacoteClienteDetalhes
    Dim conf As New config
#Region "Atributos"
    Private _cod_filial_cliente As Integer
    Private _cod_cliente As Integer
    Private _nome_cliente As String
    Private _razao_social As String
    Private _cnpj As String
    Private _ie As String
    Private _endereco As String
    Private _complemento As String
    Private _bairro As String
    Private _municipio As String
    Private _uf As String
    Private _cep As String
    Private _fones As String
    Private _data_ult_alteracao As Date
    Private _observacao As String
    Private _limite_compra As Double
    Private _limite_credito As Double
    Private _limite_cheque As Double
    Private _qtd_dias_pagar As Double
    Private _cod_promotor As Integer
    Private _sem_desconto As Integer
    Private _cod_cidade As Integer
    Private _numero As Integer
    Private _fone_nota As String
    Private _cod_tipo_cliente As Integer
    Private _e_mail As String
    Private _cod_tipo_compra As Integer
    Private _tipo_inscricao_estadual As Integer
    Private _estoque_preferencial As Integer
    Private _insc_suframa As Integer
    Private _ativo As String
    Private _tipo_pessoa As String
    Private _rg As String
    Private _tipodoc As String

    Public Enum tipo_restricao As Integer
        Bloqueio_vendas = 1
        So_a_vista = 2
        Nao_aceitar_cheque = 3
        Pagamento_antecipado = 4
    End Enum

    Public posicao As Integer = 0
    Public max As Integer
    Public Criterio_cod_cliente, Criterio_cod_filial As Object
    Public tabela As New DataTable
    Public OrigemSalvar As String = ""
    Private lastPos As Integer = 0
    Private sql As String
    Dim d As New dados
#End Region
#Region "GET SET"
    Public Property cod_filial_cliente() As Integer
        Get
            cod_filial_cliente = _cod_filial_cliente
        End Get
        Set(ByVal Value As Integer)
            _cod_filial_cliente = Value
        End Set
    End Property
    Public Property cod_cliente() As Integer
        Get
            cod_cliente = _cod_cliente
        End Get
        Set(ByVal Value As Integer)
            _cod_cliente = Value
        End Set
    End Property
    Public Property nome_cliente() As String
        Get
            nome_cliente = _nome_cliente
        End Get
        Set(ByVal Value As String)
            _nome_cliente = Value
        End Set
    End Property
    Public Property razao_social() As String
        Get
            razao_social = _razao_social
        End Get
        Set(ByVal Value As String)
            _razao_social = Value
        End Set
    End Property
    Public Property cnpj() As String
        Get
            cnpj = _cnpj
        End Get
        Set(ByVal Value As String)
            _cnpj = Value
        End Set
    End Property
    Public Property ie() As String
        Get
            ie = _ie
        End Get
        Set(ByVal Value As String)
            _ie = Value
        End Set
    End Property
    Public Property endereco() As String
        Get
            endereco = _endereco
        End Get
        Set(ByVal Value As String)
            _endereco = Value
        End Set
    End Property
    Public Property complemento() As String
        Get
            complemento = _complemento
        End Get
        Set(ByVal Value As String)
            _complemento = Value
        End Set
    End Property
    Public Property bairro() As String
        Get
            bairro = _bairro
        End Get
        Set(ByVal Value As String)
            _bairro = Value
        End Set
    End Property
    Public Property municipio() As String
        Get
            municipio = _municipio
        End Get
        Set(ByVal Value As String)
            _municipio = Value
        End Set
    End Property
    Public Property uf() As String
        Get
            uf = _uf
        End Get
        Set(ByVal Value As String)
            _uf = Value
        End Set
    End Property
    Public Property cep() As String
        Get
            cep = _cep
        End Get
        Set(ByVal Value As String)
            _cep = Value
        End Set
    End Property
    Public Property fones() As String
        Get
            fones = _fones
        End Get
        Set(ByVal Value As String)
            _fones = Value
        End Set
    End Property
    Public Property fone_nota()
        Get
            fone_nota = _fone_nota
        End Get
        Set(ByVal value)
            _fone_nota = limpa_fone(value)
        End Set
    End Property
    Public Property observacao() As String
        Get
            observacao = _observacao
        End Get
        Set(ByVal Value As String)
            _observacao = Value
        End Set
    End Property
    Public Property limite_compra()
        Get
            limite_compra = _limite_compra
        End Get
        Set(ByVal Value As Object)
            _limite_compra = Value
        End Set
    End Property
    Public Property limite_credito()
        Get
            limite_credito = _limite_credito
        End Get
        Set(ByVal Value As Object)
            _limite_credito = Value
        End Set
    End Property
    Public Property limite_cheque() As Object
        Get
            limite_cheque = _limite_cheque
        End Get
        Set(ByVal Value As Object)
            _limite_cheque = Value
        End Set
    End Property
    Public Property qtd_dias_pagar()
        Get
            qtd_dias_pagar = _qtd_dias_pagar
        End Get
        Set(ByVal value)
            _qtd_dias_pagar = value
        End Set
    End Property
    Public Property cod_promotor()
        Get
            cod_promotor = _cod_promotor
        End Get
        Set(ByVal value)
            _cod_promotor = value
        End Set
    End Property
    Public Property sem_desconto() As Boolean
        Get
            sem_desconto = _sem_desconto
        End Get
        Set(ByVal value As Boolean)
            _sem_desconto = CInt(value)
        End Set
    End Property
    Public Property cod_cidade()
        Get
            cod_cidade = _cod_cidade
        End Get
        Set(ByVal value)
            _cod_cidade = value
        End Set
    End Property
    Public Property numero()
        Get
            numero = _numero
        End Get
        Set(ByVal value)
            _numero = rdNum(value)
        End Set
    End Property
    Public Property cod_tipo_cliente
        Get
            cod_tipo_cliente = _cod_tipo_cliente
        End Get
        Set(ByVal value)
            _cod_tipo_cliente = value
        End Set
    End Property
    Public Property e_mail
        Get
            e_mail = _e_mail
        End Get
        Set(ByVal value)
            _e_mail = value
        End Set
    End Property
    Public Property cod_tipo_compra
        Get
            cod_tipo_compra = _cod_tipo_compra
        End Get
        Set(ByVal value)
            _cod_tipo_compra = value
        End Set
    End Property

    Public Property tipo_inscricao_estadual
        Get
            tipo_inscricao_estadual = _tipo_inscricao_estadual
        End Get
        Set(ByVal value)
            _tipo_inscricao_estadual = value
        End Set
    End Property

    Public Property estoque_preferencial
        Get
            estoque_preferencial = _estoque_preferencial
        End Get
        Set(ByVal value)
            _estoque_preferencial = value
        End Set
    End Property

    Public Property inscricao_suframa
        Get
            inscricao_suframa = _insc_suframa
        End Get
        Set(ByVal value)
            _insc_suframa = value
        End Set
    End Property

    Public Property ativo
        Get
            ativo = _ativo
        End Get
        Set(ByVal value)
            _ativo = value
        End Set
    End Property

    Public Property tipo_pessoa
        Get
            tipo_pessoa = _tipo_pessoa
        End Get
        Set(ByVal value)
            _tipo_pessoa = value
        End Set
    End Property

    Public Property rg
        Get
            rg = _rg
        End Get
        Set(ByVal value)
            _rg = value
        End Set
    End Property

    Public Property tipodocumento
        Get
            tipodocumento = _tipodoc
        End Get
        Set(ByVal value)
            _tipodoc = value
        End Set
    End Property
#End Region
#Region "Procedimentos"
    Public Sub filtra_nome(ByVal n As String)
        Dim tsql As String
        tsql = "Select * from cliente where (nome_cliente like '%" & n & "%') or " & _
        "(razao_social like '%" & n & "%')"
        d.carrega_Tabela(tsql, tabela)
        max = tabela.Rows.Count
        primeiro()
    End Sub


    Public Sub filtra_cod(ByVal c As Integer)
        Dim tsql As String
        tsql = "Select * from cliente where cod_cliente = " & c & ""
        d.carrega_Tabela(tsql, tabela)
        max = tabela.Rows.Count
        primeiro()
    End Sub


    Public Sub Registro(ByVal pos As Integer) 'Move o Registro para a posição indicada
        Dim p As Integer = pos
        If p <= 0 Then p = 0
        If p > max Then p = max
        posicao = p
        If max > 0 Then
            _cod_cliente = tabela.Rows(p)("cod_cliente")
            _cod_filial_cliente = tabela.Rows(p)("cod_filial_cliente")
            _nome_cliente = rdTexto(tabela.Rows(p)("nome_cliente"))
            _razao_social = rdTexto(tabela.Rows(p)("razao_social"))
            _cnpj = rdTexto(tabela.Rows(p)("cnpj"))
            _ie = rdTexto(tabela.Rows(p)("ie"))
            _endereco = rdTexto(tabela.Rows(p)("endereco"))
            _numero = rdNum(tabela.Rows(p)("numero"))
            _complemento = rdTexto(tabela.Rows(p)("complemento"))
            _bairro = rdTexto(tabela.Rows(p)("bairro"))
            _municipio = rdTexto(tabela.Rows(p)("municipio"))
            _uf = rdTexto(tabela.Rows(p)("uf"))
            _cep = rdTexto(tabela.Rows(p)("cep"))
            _fones = rdTexto(tabela.Rows(p)("fones"))
            _fone_nota = rdTexto(tabela.Rows(p)("fone_nota"))
            _observacao = rdTexto(tabela.Rows(p)("observacao"))
            _limite_compra = rdNum(tabela.Rows(p)("limite_compra"))
            _limite_credito = rdNum(tabela.Rows(p)("limite_credito"))
            _limite_cheque = rdNum(tabela.Rows(p)("limite_cheque"))
            _qtd_dias_pagar = rdNum(tabela.Rows(p)("qtd_dias_pagar"))
            _cod_promotor = rdNum(tabela.Rows(p)("cod_promotor"))
            _sem_desconto = tabela.Rows(p)("sem_desconto")
            _cod_cidade = rdNum(tabela.Rows(p)("codigo_cidade"))
            _cod_tipo_cliente = rdNum(tabela.Rows(p)("cod_tipo_cliente"))
            _e_mail = rdTexto(tabela.Rows(p)("e_mail"))
            _cod_tipo_compra = rdNum(tabela.Rows(p)("tipo_compra"))
            _tipo_inscricao_estadual = rdNum(tabela.Rows(p)("tipoinscricaoestadual"))
            _estoque_preferencial = rdNum(tabela.Rows(p)("estoquepreferencial"))
            _insc_suframa = rdNum(tabela.Rows(p)("insc_suframa"))
            _ativo = rdTexto(tabela.Rows(p)("ativo"))
            _tipo_pessoa = rdTexto(tabela.Rows(p)("tipo_pessoa"))
            _rg = rdTexto(tabela.Rows(p)("rg"))
            _tipodoc = rdTexto(tabela.Rows(p)("tipodoc"))
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
    Public Sub novo()
        lastPos = posicao 'guarda a posição do último Registro
        'Zera Variáveis
        _cod_cliente = Nothing
        _cod_filial_cliente = Nothing
        _nome_cliente = Nothing
        _endereco = Nothing
        _complemento = Nothing
        _bairro = Nothing
        _municipio = Nothing
        _uf = Nothing
        _cep = Nothing
        _fones = Nothing
        _observacao = Nothing
        _limite_compra = 0
        _limite_credito = 0
        _sem_desconto = 1
        _nome_cliente = Nothing
        _fone_nota = Nothing
        _cod_tipo_cliente = Nothing
        _e_mail = Nothing
        _cod_tipo_compra = Nothing
        _tipo_inscricao_estadual = Nothing
        _estoque_preferencial = Nothing
        _insc_suframa = Nothing
        _ativo = Nothing
        _tipo_pessoa = Nothing
        _rg = Nothing
        _tipodoc = Nothing
        OrigemSalvar = "Novo" 'Define o tipo de ação ao salvar
    End Sub
    Public Function Salvar() As String
        Dim cmd As New SqlClient.SqlCommand
        Dim sql As String
        Dim res As String
        d.conecta()
        If OrigemSalvar = "Novo" Then
            Try
                _cod_cliente = retorna_Chave("cod_cliente", "cliente", " where cod_filial_cliente = " & conf.Filial & "")
                sql = "Insert into cliente(cod_filial_cliente,cod_cliente,nome_cliente," &
                "razao_social,cnpj,ie,endereco,complemento,bairro,municipio,uf,cep,fones," &
                "observacao,cod_promotor,limite_compra,limite_credito,limite_cheque, qtd_dias_pagar, " &
                "sem_desconto,codigo_cidade,numero,fone_nota, cod_tipo_cliente,e_mail,tipo_compra, tipoinscricaoestadual, estoquepreferencial, " &
                "insc_suframa, ativo, tipo_pessoa, rg, tipodoc)" &
                " Values(" &
                _cod_filial_cliente & "," & _cod_cliente & "," &
                d.PStr(_nome_cliente) &
                "," & d.PStr(_razao_social) &
                "," & d.PStr(_cnpj) & "," & d.PStr(_ie) &
                "," & d.PStr(_endereco) & "," & d.PStr(_complemento) & "," & d.PStr(_bairro) &
                "," & d.PStr(_municipio) & "," & d.PStr(_uf) & "," & d.PStr(_cep) &
                "," & d.PStr(_fones) & "," & d.PStr(_observacao) & "," &
                "0" & "," &
                d.cdin(_limite_compra) & "," &
                d.cdin(_limite_credito) & "," &
                d.cdin(_limite_cheque) &
                "," & qtd_dias_pagar &
                "," & _sem_desconto &
                "," & _cod_cidade &
                "," & d.cdin(_numero) &
                "," & d.PStr(_fone_nota) &
                "," & _cod_tipo_cliente &
                "," & d.PStr(_e_mail) &
                "," & _cod_tipo_compra &
                "," & _tipo_inscricao_estadual &
                "," & _estoque_preferencial &
                "," & _insc_suframa &
                "," & d.PStr(_ativo) &
                "," & d.PStr(_tipo_pessoa) &
                "," & d.PStr(_rg) &
                "," & d.PStr(_tipodoc) & ")"
                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
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
                sql = "Update cliente set " &
                "cod_cliente = " & _cod_cliente &
                ",nome_cliente = " & d.PStr(_nome_cliente) &
                ",razao_social = " & d.PStr(_razao_social) &
                ",cnpj = " & d.PStr(_cnpj) &
                ",ie = " & d.PStr(_ie) &
                ",endereco=" & d.PStr(_endereco) &
                ",complemento=" & d.PStr(_complemento) &
                ",bairro=" & d.PStr(_bairro) &
                ",municipio=" & d.PStr(_municipio) &
                ",uf=" & d.PStr(_uf) &
                ",cep=" & d.PStr(_cep) &
                ",fones=" & d.PStr(_fones) &
                ",observacao =" & d.PStr(_observacao) &
                ",cod_promotor = 0" &
                ",limite_compra = " & d.cdin(_limite_compra) &
                ",limite_credito = " & d.cdin(_limite_credito) &
                ",limite_cheque = " & d.cdin(_limite_cheque) &
                ",qtd_dias_pagar = " & d.cdin(_qtd_dias_pagar) &
                ",sem_desconto = " & _sem_desconto &
                ",codigo_cidade = " & _cod_cidade &
                ",numero = " & _numero &
                ",fone_nota = " & d.PStr(_fone_nota) &
                ",cod_tipo_cliente = " & _cod_tipo_cliente &
                ",e_mail = " & d.PStr(_e_mail) &
                ",tipo_compra = " & _cod_tipo_compra &
                ",tipoinscricaoestadual = " & _tipo_inscricao_estadual &
                ",estoquepreferencial = " & _estoque_preferencial &
                ",insc_suframa = " & _insc_suframa &
                ",ativo = " & d.PStr(_ativo) &
                ",tipo_pessoa = " & d.PStr(_tipo_pessoa) &
                ",rg = " & d.PStr(_rg) &
                ",tipodoc = " & d.PStr(_tipodoc) &
                " where cod_cliente = " & Me._cod_cliente &
                " And cod_filial_cliente = " & Me._cod_filial_cliente & ""
                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tabela.Rows(posicao)
            r("cod_cliente") = wrNum(_cod_cliente)
            r("cod_filial_cliente") = wrNum(_cod_filial_cliente)
            r("nome_cliente") = rdTexto(_nome_cliente)
            r("razao_social") = rdTexto(_razao_social)
            r("cnpj") = rdTexto(_cnpj)
            r("ie") = rdTexto(_ie)
            r("endereco") = rdTexto(_endereco)
            r("complemento") = rdTexto(_complemento)
            r("bairro") = rdTexto(_bairro)
            r("municipio") = rdTexto(_municipio)
            r("uf") = rdTexto(_uf)
            r("cep") = rdTexto(_cep)
            r("fones") = rdTexto(_fones)
            r("observacao") = rdTexto(_observacao)
            r("limite_compra") = wrNum(_limite_compra)
            r("limite_credito") = wrNum(_limite_credito)
            r("limite_cheque") = wrNum(_limite_cheque)
            r("qtd_dias_pagar") = wrNum(_qtd_dias_pagar)
            r("sem_desconto") = _sem_desconto
            r("codigo_cidade") = _cod_cidade
            r("numero") = wrNum(_numero)
            r("fone_nota") = rdTexto(_fone_nota)
            r("cod_tipo_cliente") = wrNum(_cod_tipo_cliente)
            r("e_mail") = _e_mail
            r("tipo_compra") = _cod_tipo_compra
            r("tipoinscricaoestadual") = wrNum(_tipo_inscricao_estadual)
            r("estoquepreferencial") = wrNum(_estoque_preferencial)
            r("insc_suframa") = wrNum(_insc_suframa)
            r("ativo") = rdTexto(_ativo)
            r("tipo_pessoa") = rdTexto(_tipo_pessoa)
            r("rg") = rdTexto(_rg)
            r("tipodoc") = rdTexto(_tipodoc)
            OrigemSalvar = ""
            Return "OK:" & res & " registro(s) atualizado(s) com sucesso!"
        End If
    End Function
    Public Function deletar(ByVal cod_cliente As Integer, ByVal cod_filial_cliente As Integer)
        Dim sql As String
        Dim res As String
        sql = "Delete from cliente where cod_cliente = " & _cod_cliente &
        " And cod_filial_cliente = " & _cod_filial_cliente & ""
        Try
            res = d.Comando(sql, True)
        Catch ex As Exception
            Return "ER:" & ex.Message
        End Try
        'Me.refreshData()
        Me.primeiro()
        Return res & " Registros foram apagados!"
    End Function
    Public Function lista_clientes(ByVal crit_nome As String) As DataTable
        sql = "SELECT     (Cidades.Cidade + '-' + Cidades.UF) AS Cidade, cliente.* " &
        "FROM cliente LEFT OUTER JOIN Cidades ON cliente.codigo_cidade = Cidades.Codigo " &
        "where (nome_cliente like '%" & crit_nome & "%') or " &
        " (razao_social like '%" & crit_nome & "%')"
        'Source(sql)
        Return tabela
    End Function
    Public Function lista_clientes() As DataTable
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "Select cliente.nome_cliente,cliente.razao_social,cliente.cnpj,cliente.endereco,cliente.complemento, " &
        "cliente.fones, cliente.observacao, " &
        "(select max(data_pedido) from pedido_balcao where cod_cliente = cliente.cod_cliente and " &
        "cod_filial_cliente = cliente.cod_filial_cliente) as ultima_compra, " &
        "Cidades.Cidade,cidades.UF    from cliente left outer join Cidades on cliente.codigo_cidade = cidades.Codigo " &
        "where (cod_tipo_cliente = 1) order by nome_cliente"
        d.carrega_Tabela(tsql, tt)
        Return tt
    End Function
    Public Function lista_clientes_30() As DataTable
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "Select cliente.nome_cliente,cliente.razao_social,cliente.cnpj,cliente.endereco,cliente.complemento, " &
        "cliente.fones, cliente.observacao, " &
        "(select max(data_pedido) from pedido_balcao where cod_cliente = cliente.cod_cliente and " &
        "cod_filial_cliente = cliente.cod_filial_cliente) as ultima_compra, " &
        "Cidades.Cidade,cidades.UF    from cliente left outer join Cidades on cliente.codigo_cidade = cidades.Codigo " &
        "where (cod_tipo_cliente = 1) and (select max(data_pedido) from pedido_balcao where cod_cliente = cliente.cod_cliente and " &
        "cod_filial_cliente = cliente.cod_filial_cliente) >= " & d.pdtm(DateAdd(DateInterval.Day, -30, Now)) &
        " order by UF,cidade,nome_cliente"
        d.carrega_Tabela(tsql, tt)
        Return tt
    End Function
    Public Function lista_clientes_Ativos_nao_30() As DataTable
        'Listagem de clientes com atividade nos úlmos 120 dias mas sem compras nos últimos 30 dias
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "Select cliente.nome_cliente,cliente.razao_social,cliente.cnpj,cliente.endereco,cliente.complemento, " &
        "cliente.fones, cliente.observacao, " &
        "(select max(data_pedido) from pedido_balcao where cod_cliente = cliente.cod_cliente and " &
        "cod_filial_cliente = cliente.cod_filial_cliente) as ultima_compra, " &
        "Cidades.Cidade,cidades.UF    from cliente left outer join Cidades on cliente.codigo_cidade = cidades.Codigo " &
        "where (cod_tipo_cliente = 1) and (select max(data_pedido) from pedido_balcao where cod_cliente = cliente.cod_cliente and " &
        "cod_filial_cliente = cliente.cod_filial_cliente) >= " & d.pdtm(DateAdd(DateInterval.Day, -120, Now)) &
        "and (select max(data_pedido) from pedido_balcao where cod_cliente = cliente.cod_cliente and " &
        "cod_filial_cliente = cliente.cod_filial_cliente) <= " & d.pdtm(DateAdd(DateInterval.Day, -30, Now)) &
        " order by UF,cidade,ultima_compra, nome_cliente"
        d.carrega_Tabela(tsql, tt)
        Return tt
    End Function
#Region "Pedidos/OS"
    Public Function pedidos_clientes() As DataTable
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT cliente.cod_cliente,cliente.cod_filial_cliente,cliente.nome_cliente," &
        "pedido_balcao.id_filial, pedido_balcao.num_pedido, " &
        "(SELECT Left(OS,LEN(OS)-1)as delimited_list " &
        "FROM ( " &
        "select " &
        "CAST(" &
        "(SELECT cast(id_filial as varchar(3)) + '-' + cast(cod_os as varchar(10)) + ';' " &
        "FROM OS " &
        "where (os.num_pedido = pedido_balcao.num_pedido and os.id_filial = pedido_balcao.id_filial and cod_fase <> 21) " &
        "for xml path ('')) as varchar(max)) " &
        "as os " &
        ") as temp ) as OS, " &
        "pedido_balcao.data_pedido, pedido_balcao.cod_status_pedido, " &
        "status_pedido.Status_pedido, Usuarios.NOME,  " &
        "(SELECT count(item) as itens FROM fatura_itens  " &
        "WHERE (num_pedido =pedido_balcao.num_pedido) AND  " &
        "(id_filial_pedido =pedido_balcao.id_filial)) as  " &
        "Faturado," &
        "isnull((SELECT sum(pedido_balcao_itens.quant *  " &
        "pedido_balcao_itens.preco) AS total  " &
        "FROM pedido_balcao_itens INNER JOIN  " &
        "produtos ON pedido_balcao_itens.cod_produto = produtos.cod_produto  " &
        "WHERE (pedido_balcao_itens.num_pedido = pedido_balcao.num_pedido) AND  " &
        "(pedido_balcao_itens.id_filial = pedido_balcao.id_filial)),0)  " &
        "AS Produtos,  " &
        "isnull((SELECT sum(pedido_balcao_servicos.quant *  " &
        "pedido_balcao_servicos.preco) AS total  " &
        "FROM pedido_balcao_servicos INNER JOIN  " &
        "produtos ON pedido_balcao_servicos.cod_servico = produtos.cod_produto  " &
        "WHERE (pedido_balcao_servicos.num_pedido = pedido_balcao.num_pedido) AND  " &
        "(pedido_balcao_servicos.id_filial = pedido_balcao.id_filial)),0)  " &
        "as servicos,  " &
        "(isnull((SELECT sum(pedido_balcao_itens.quant *  " &
        "pedido_balcao_itens.preco) AS total  " &
        "FROM pedido_balcao_itens INNER JOIN  " &
        "produtos ON pedido_balcao_itens.cod_produto = produtos.cod_produto  " &
        "WHERE (pedido_balcao_itens.num_pedido = pedido_balcao.num_pedido) AND  " &
        "(pedido_balcao_itens.id_filial = pedido_balcao.id_filial)),0)  " &
        "+  " &
        "isnull((SELECT sum(pedido_balcao_servicos.quant *  " &
        "pedido_balcao_servicos.preco)  " &
        "AS total  " &
        "FROM pedido_balcao_servicos INNER JOIN  " &
        "produtos ON pedido_balcao_servicos.cod_servico = produtos.cod_produto  " &
        "WHERE (pedido_balcao_servicos.num_pedido = pedido_balcao.num_pedido) AND  " &
        "(pedido_balcao_servicos.id_filial = pedido_balcao.id_filial)),0))  " &
        "as Total " &
        ",(SELECT Left(item,LEN(item)-1)as delimited_list " &
        "FROM ( " &
        "select " &
        "CAST(" &
        "(SELECT cast(id_filial as varchar(3)) + '-' + cast(cod_fatura as varchar(10)) + ';' " &
        "FROM fatura_itens " &
        "where (fatura_itens.num_pedido = pedido_balcao.num_pedido And fatura_itens.id_filial_pedido = pedido_balcao.id_filial) " &
        "for xml path ('')) as varchar(max)) " &
        "as item " &
        ") as temp ) as n_fatura " &
        "FROM pedido_balcao INNER JOIN  " &
        "status_pedido ON pedido_balcao.cod_status_pedido =  " &
        "status_pedido.cod_status_pedido INNER JOIN  " &
        "Usuarios ON pedido_balcao.cod_vendedor = Usuarios.cod_usuario  " &
        "inner join cliente on pedido_balcao.cod_cliente = cliente.cod_cliente and " &
        "pedido_balcao.cod_filial_cliente = cliente.cod_filial_cliente " &
        "WHERE (pedido_balcao.cod_filial_cliente =" & _cod_filial_cliente & ") AND " &
        "(pedido_balcao.cod_cliente = " & _cod_cliente & ")" &
        " and dateadd(DAY ,30,pedido_balcao.data_pedido ) > " & d.Pdt(Now()) & "  ORDER BY pedido_balcao.data_pedido Desc"
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function pedido_cliente(ByVal x_cod_cliente As Integer, ByVal xFilial As Integer, ByVal x_num As Integer) As DataRow
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT cliente.cod_cliente,cliente.cod_filial_cliente,cliente.nome_cliente, " &
        "pedido_balcao.id_filial, pedido_balcao.num_pedido, " &
        "(SELECT Left(OS,LEN(OS)-1)as delimited_list " &
        "FROM ( " &
        "select " &
        "CAST(" &
        "(SELECT cast(id_filial as varchar(3)) + '-' + cast(cod_os as varchar(10)) + ';' " &
        "FROM OS " &
        "where (os.num_pedido = pedido_balcao.num_pedido and os.id_filial = pedido_balcao.id_filial and cod_fase <> 21) " &
        "for xml path ('')) as varchar(max)) " &
        "as os " &
        ") as temp ) as OS, " &
        "pedido_balcao.data_pedido, pedido_balcao.cod_status_pedido, " &
        "status_pedido.Status_pedido, Usuarios.NOME,  " &
        "(SELECT count(item) as itens FROM fatura_itens  " &
        "WHERE (num_pedido =pedido_balcao.num_pedido) AND  " &
        "(id_filial_pedido =pedido_balcao.id_filial)) as  " &
        "Faturado," &
        "isnull((SELECT sum(pedido_balcao_itens.quant *  " &
        "(pedido_balcao_itens.preco - pedido_balcao_itens.preco *  " &
        "(pedido_balcao_itens.desconto / 100))) AS total  " &
        "FROM pedido_balcao_itens INNER JOIN  " &
        "produtos ON pedido_balcao_itens.cod_produto = produtos.cod_produto  " &
        "WHERE (pedido_balcao_itens.num_pedido = pedido_balcao.num_pedido) AND  " &
        "(pedido_balcao_itens.id_filial = pedido_balcao.id_filial)),0)  " &
        "AS Produtos,  " &
        "isnull((SELECT sum(pedido_balcao_servicos.quant *  " &
        "(pedido_balcao_servicos.preco - pedido_balcao_servicos.preco *  " &
        "(pedido_balcao_servicos.desconto / 100))) AS total  " &
        "FROM pedido_balcao_servicos INNER JOIN  " &
        "produtos ON pedido_balcao_servicos.cod_servico = produtos.cod_produto  " &
        "WHERE (pedido_balcao_servicos.num_pedido = pedido_balcao.num_pedido) AND  " &
        "(pedido_balcao_servicos.id_filial = pedido_balcao.id_filial)),0)  " &
        "as servicos,  " &
        "(isnull((SELECT sum(pedido_balcao_itens.quant *  " &
        "(pedido_balcao_itens.preco - pedido_balcao_itens.preco *  " &
        "(pedido_balcao_itens.desconto / 100))) AS total  " &
        "FROM pedido_balcao_itens INNER JOIN  " &
        "produtos ON pedido_balcao_itens.cod_produto = produtos.cod_produto  " &
        "WHERE (pedido_balcao_itens.num_pedido = pedido_balcao.num_pedido) AND  " &
        "(pedido_balcao_itens.id_filial = pedido_balcao.id_filial)),0)  " &
        "+  " &
        "isnull((SELECT sum(pedido_balcao_servicos.quant *  " &
        "(pedido_balcao_servicos.preco - pedido_balcao_servicos.preco *  " &
        "(pedido_balcao_servicos.desconto / 100)))  " &
        "AS total  " &
        "FROM pedido_balcao_servicos INNER JOIN  " &
        "produtos ON pedido_balcao_servicos.cod_servico = produtos.cod_produto  " &
        "WHERE (pedido_balcao_servicos.num_pedido = pedido_balcao.num_pedido) AND  " &
        "(pedido_balcao_servicos.id_filial = pedido_balcao.id_filial)),0))  " &
        "as Total " &
        ",(SELECT Left(item,LEN(item)-1)as delimited_list " &
        "FROM ( " &
        "select " &
        "CAST(" &
        "(SELECT cast(id_filial as varchar(3)) + '-' + cast(cod_fatura as varchar(10)) + ';' " &
        "FROM fatura_itens " &
        "where (fatura_itens.num_pedido = pedido_balcao.num_pedido And fatura_itens.id_filial_pedido = pedido_balcao.id_filial) " &
        "for xml path ('')) as varchar(max)) " &
        "as item " &
        ") as temp ) as n_fatura " &
        "FROM pedido_balcao INNER JOIN  " &
        "status_pedido ON pedido_balcao.cod_status_pedido =  " &
        "status_pedido.cod_status_pedido INNER JOIN  " &
        "Usuarios ON pedido_balcao.cod_vendedor = Usuarios.cod_usuario  " &
        "inner join cliente on pedido_balcao.cod_cliente = cliente.cod_cliente " &
        "and pedido_balcao.cod_filial_cliente = cliente.cod_filial_cliente " &
        "WHERE (pedido_balcao.cod_filial_cliente =" & xFilial & ") AND " &
        "(pedido_balcao.cod_cliente = " & x_cod_cliente & " and " &
        "pedido_balcao.num_pedido = " & x_num & ")" &
        " ORDER BY pedido_balcao.data_pedido Desc"
        d.carrega_Tabela(sql, tt)

        Return tt.Rows(0)
    End Function
    Public Function pedido_cliente_faturado(ByVal x_cod_cliente As Integer, ByVal xFilial As Integer, ByVal faturado As Boolean) As DataTable
        Dim sql As String
        Dim tt As New DataTable
        Dim f As String
        If faturado = True Then
            f = "  > 0"
        Else
            f = " = 0"
        End If
        sql = "SELECT cliente.cod_cliente,cliente.cod_filial_cliente,cliente.nome_cliente," &
        "pedido_balcao.id_filial, pedido_balcao.num_pedido, " &
      "(SELECT Left(OS,LEN(OS)-1)as delimited_list " &
        "FROM ( " &
        "select " &
        "CAST(" &
        "(SELECT cast(id_filial as varchar(3)) + '-' + cast(cod_os as varchar(10)) + ';' " &
        "FROM OS " &
        "where (os.num_pedido = pedido_balcao.num_pedido and os.id_filial = pedido_balcao.id_filial and cod_fase <> 21) " &
        "for xml path ('')) as varchar(max)) " &
        "as os " &
        ") as temp ) as OS, " &
      "pedido_balcao.data_pedido, pedido_balcao.cod_status_pedido, " &
      "status_pedido.Status_pedido, Usuarios.NOME,  " &
      "(SELECT count(item) as itens FROM fatura_itens  " &
      "WHERE (num_pedido =pedido_balcao.num_pedido) AND  " &
      "(id_filial_pedido =pedido_balcao.id_filial)) as  " &
      "Faturado," &
      "isnull((SELECT sum(pedido_balcao_itens.quant *  " &
      "(pedido_balcao_itens.preco - pedido_balcao_itens.preco *  " &
      "(pedido_balcao_itens.desconto / 100))) AS total  " &
      "FROM pedido_balcao_itens INNER JOIN  " &
      "produtos ON pedido_balcao_itens.cod_produto = produtos.cod_produto  " &
      "WHERE (pedido_balcao_itens.num_pedido = pedido_balcao.num_pedido) AND  " &
      "(pedido_balcao_itens.id_filial = pedido_balcao.id_filial)),0)  " &
      "AS Produtos,  " &
      "isnull((SELECT sum(pedido_balcao_servicos.quant *  " &
      "(pedido_balcao_servicos.preco - pedido_balcao_servicos.preco *  " &
      "(pedido_balcao_servicos.desconto / 100))) AS total  " &
      "FROM pedido_balcao_servicos INNER JOIN  " &
      "produtos ON pedido_balcao_servicos.cod_servico = produtos.cod_produto  " &
      "WHERE (pedido_balcao_servicos.num_pedido = pedido_balcao.num_pedido) AND  " &
      "(pedido_balcao_servicos.id_filial = pedido_balcao.id_filial)),0)  " &
      "as servicos,  " &
      "(isnull((SELECT sum(pedido_balcao_itens.quant *  " &
      "(pedido_balcao_itens.preco - pedido_balcao_itens.preco *  " &
      "(pedido_balcao_itens.desconto / 100))) AS total  " &
      "FROM pedido_balcao_itens INNER JOIN  " &
      "produtos ON pedido_balcao_itens.cod_produto = produtos.cod_produto  " &
      "WHERE (pedido_balcao_itens.num_pedido = pedido_balcao.num_pedido) AND  " &
      "(pedido_balcao_itens.id_filial = pedido_balcao.id_filial)),0)  " &
      "+  " &
      "isnull((SELECT sum(pedido_balcao_servicos.quant *  " &
      "(pedido_balcao_servicos.preco - pedido_balcao_servicos.preco *  " &
      "(pedido_balcao_servicos.desconto / 100)))  " &
      "AS total  " &
      "FROM pedido_balcao_servicos INNER JOIN  " &
      "produtos ON pedido_balcao_servicos.cod_servico = produtos.cod_produto  " &
      "WHERE (pedido_balcao_servicos.num_pedido = pedido_balcao.num_pedido) AND  " &
      "(pedido_balcao_servicos.id_filial = pedido_balcao.id_filial)),0))  " &
      "as Total " &
     ",(SELECT Left(item,LEN(item)-1)as delimited_list " &
        "FROM ( " &
        "select " &
        "CAST(" &
        "(SELECT cast(id_filial as varchar(3)) + '-' + cast(cod_fatura as varchar(10)) + ';' " &
        "FROM fatura_itens " &
        "where (fatura_itens.num_pedido = pedido_balcao.num_pedido And fatura_itens.id_filial_pedido = pedido_balcao.id_filial) " &
        "for xml path ('')) as varchar(max)) " &
        "as item " &
        ") as temp ) as n_fatura " &
      "FROM pedido_balcao INNER JOIN  " &
      "status_pedido ON pedido_balcao.cod_status_pedido =  " &
      "status_pedido.cod_status_pedido INNER JOIN  " &
      "Usuarios ON pedido_balcao.cod_vendedor = Usuarios.cod_usuario  " &
      "inner join cliente on pedido_balcao.cod_cliente = cliente.cod_cliente " &
      "and pedido_balcao.cod_filial_cliente = cliente.cod_filial_cliente " &
       "WHERE (pedido_balcao.cod_filial_cliente =" & _cod_filial_cliente & ") AND " &
      "(pedido_balcao.cod_cliente = " & _cod_cliente & ")" &
      " and (SELECT count(item) as itens FROM fatura_itens  " &
      "WHERE (num_pedido =pedido_balcao.num_pedido) AND  " &
      "(id_filial_pedido =pedido_balcao.id_filial))  " &
      f &
      " ORDER BY pedido_balcao.data_pedido Desc"
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function pedido_cliente_faturado(ByVal x_cod_cliente As Integer,
    ByVal xFilial As Integer,
    ByVal di As Date, ByVal df As Date, ByVal faturado As Boolean) As DataTable
        Dim sql As String
        Dim tt As New DataTable
        Dim f As String
        If faturado = True Then
            f = " > 0 "
        Else
            f = " = 0 "
        End If
        sql = "SELECT cliente.cod_cliente,cliente.cod_filial_cliente,cliente.nome_cliente, " &
        "pedido_balcao.id_filial, pedido_balcao.num_pedido, " &
    "(SELECT Left(OS,LEN(OS)-1)as delimited_list " &
        "FROM ( " &
        "select " &
        "CAST(" &
        "(SELECT cast(id_filial as varchar(3)) + '-' + cast(cod_os as varchar(10)) + ';' " &
        "FROM OS " &
        "where (os.num_pedido = pedido_balcao.num_pedido and os.id_filial = pedido_balcao.id_filial and cod_fase <> 21) " &
        "for xml path ('')) as varchar(max)) " &
        "as os " &
        ") as temp ) as OS, " &
      "pedido_balcao.data_pedido, pedido_balcao.cod_status_pedido, " &
      "status_pedido.Status_pedido, Usuarios.NOME,  " &
      "(SELECT count(item) as itens FROM fatura_itens  " &
      "WHERE (num_pedido =pedido_balcao.num_pedido) AND  " &
      "(id_filial_pedido =pedido_balcao.id_filial)) as  " &
      "Faturado," &
      "isnull((SELECT sum(pedido_balcao_itens.quant *  " &
      "(pedido_balcao_itens.preco - pedido_balcao_itens.preco *  " &
      "(pedido_balcao_itens.desconto / 100))) AS total  " &
      "FROM pedido_balcao_itens INNER JOIN  " &
      "produtos ON pedido_balcao_itens.cod_produto = produtos.cod_produto  " &
      "WHERE (pedido_balcao_itens.num_pedido = pedido_balcao.num_pedido) AND  " &
      "(pedido_balcao_itens.id_filial = pedido_balcao.id_filial)),0)  " &
      "AS Produtos,  " &
      "isnull((SELECT sum(pedido_balcao_servicos.quant *  " &
      "(pedido_balcao_servicos.preco - pedido_balcao_servicos.preco *  " &
      "(pedido_balcao_servicos.desconto / 100))) AS total  " &
      "FROM pedido_balcao_servicos INNER JOIN  " &
      "produtos ON pedido_balcao_servicos.cod_servico = produtos.cod_produto  " &
      "WHERE (pedido_balcao_servicos.num_pedido = pedido_balcao.num_pedido) AND  " &
      "(pedido_balcao_servicos.id_filial = pedido_balcao.id_filial)),0)  " &
      "as servicos,  " &
      "(isnull((SELECT sum(pedido_balcao_itens.quant *  " &
      "(pedido_balcao_itens.preco - pedido_balcao_itens.preco *  " &
      "(pedido_balcao_itens.desconto / 100))) AS total  " &
      "FROM pedido_balcao_itens INNER JOIN  " &
      "produtos ON pedido_balcao_itens.cod_produto = produtos.cod_produto  " &
      "WHERE (pedido_balcao_itens.num_pedido = pedido_balcao.num_pedido) AND  " &
      "(pedido_balcao_itens.id_filial = pedido_balcao.id_filial)),0)  " &
      "+  " &
      "isnull((SELECT sum(pedido_balcao_servicos.quant *  " &
      "(pedido_balcao_servicos.preco - pedido_balcao_servicos.preco *  " &
      "(pedido_balcao_servicos.desconto / 100)))  " &
      "AS total  " &
      "FROM pedido_balcao_servicos INNER JOIN  " &
      "produtos ON pedido_balcao_servicos.cod_servico = produtos.cod_produto  " &
      "WHERE (pedido_balcao_servicos.num_pedido = pedido_balcao.num_pedido) AND  " &
      "(pedido_balcao_servicos.id_filial = pedido_balcao.id_filial)),0))  " &
      "as Total " &
     ",(SELECT Left(item,LEN(item)-1)as delimited_list " &
        "FROM ( " &
        "select " &
        "CAST(" &
        "(SELECT cast(id_filial as varchar(3)) + '-' + cast(cod_fatura as varchar(10)) + ';' " &
        "FROM fatura_itens " &
        "where (fatura_itens.num_pedido = pedido_balcao.num_pedido And fatura_itens.id_filial_pedido = pedido_balcao.id_filial) " &
        "for xml path ('')) as varchar(max)) " &
        "as item " &
        ") as temp ) as n_fatura " &
      "FROM pedido_balcao INNER JOIN  " &
      "status_pedido ON pedido_balcao.cod_status_pedido =  " &
      "status_pedido.cod_status_pedido INNER JOIN  " &
      "Usuarios ON pedido_balcao.cod_vendedor = Usuarios.cod_usuario  " &
      "inner join cliente on pedido_balcao.cod_cliente = cliente.cod_cliente " &
      "and pedido_balcao.cod_filial_cliente = cliente.cod_filial_cliente " &
      "WHERE (pedido_balcao.cod_filial_cliente =" & _cod_filial_cliente & ") AND " &
      "(pedido_balcao.cod_cliente = " & _cod_cliente & ")" &
      " and (SELECT count(item) as itens FROM fatura_itens  " &
      "WHERE (num_pedido =pedido_balcao.num_pedido) AND  " &
      "(id_filial_pedido =pedido_balcao.id_filial)) " &
      f &
      " and (pedido_balcao.data_pedido >= " & d.Pdt(di) &
      " and pedido_balcao.data_pedido <= " & d.Pdt(df) & ")" &
      " ORDER BY cliente.nome_cliente, pedido_balcao.data_pedido Desc"
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function pedido_clientes_faturado(ByVal xFilial As Integer,
     ByVal faturado As Boolean) As DataTable
        Dim Tsql As String
        Dim tt As New DataTable
        Dim f As String
        If faturado = True Then
            f = ">= 1"
        Else
            f = "=0"
        End If
        Tsql = "select * from pedidos_FATURADOS() AS PEDIDOS_FATURADOS " &
        " where faturado " & f &
        " ORDER BY nome_cliente,  data_pedido Desc"
        d.carrega_Tabela(Tsql, tt)
        Return tt
    End Function
    Public Function pedido_cliente_faturado(ByVal x_cod_cliente As Integer,
    ByVal xFilial As Integer,
    ByVal di As Date, ByVal df As Date) As DataTable
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT cliente.cod_cliente,cliente.cod_filial_cliente,cliente.nome_cliente," &
        "pedido_balcao.id_filial, pedido_balcao.num_pedido," &
     "(SELECT Left(OS,LEN(OS)-1)as delimited_list " &
        "FROM ( " &
        "select " &
        "CAST(" &
        "(SELECT cast(id_filial as varchar(3)) + '-' + cast(cod_os as varchar(10)) + ';' " &
        "FROM OS " &
        "where (os.num_pedido = pedido_balcao.num_pedido and os.id_filial = pedido_balcao.id_filial and cod_fase <> 21) " &
        "for xml path ('')) as varchar(max)) " &
        "as os " &
        ") as temp ) as OS, " &
      "pedido_balcao.data_pedido, pedido_balcao.cod_status_pedido, " &
      "status_pedido.Status_pedido, Usuarios.NOME,  " &
      "(SELECT count(item) as itens FROM fatura_itens  " &
      "WHERE (num_pedido =pedido_balcao.num_pedido) AND  " &
      "(id_filial_pedido =pedido_balcao.id_filial)) as  " &
      "Faturado," &
      "isnull((SELECT sum(pedido_balcao_itens.quant *  " &
      "(pedido_balcao_itens.preco - pedido_balcao_itens.preco *  " &
      "(pedido_balcao_itens.desconto / 100))) AS total  " &
      "FROM pedido_balcao_itens INNER JOIN  " &
      "produtos ON pedido_balcao_itens.cod_produto = produtos.cod_produto  " &
      "WHERE (pedido_balcao_itens.num_pedido = pedido_balcao.num_pedido) AND  " &
      "(pedido_balcao_itens.id_filial = pedido_balcao.id_filial)),0)  " &
      "AS Produtos,  " &
      "isnull((SELECT sum(pedido_balcao_servicos.quant *  " &
      "(pedido_balcao_servicos.preco - pedido_balcao_servicos.preco *  " &
      "(pedido_balcao_servicos.desconto / 100))) AS total  " &
      "FROM pedido_balcao_servicos INNER JOIN  " &
      "produtos ON pedido_balcao_servicos.cod_servico = produtos.cod_produto  " &
      "WHERE (pedido_balcao_servicos.num_pedido = pedido_balcao.num_pedido) AND  " &
      "(pedido_balcao_servicos.id_filial = pedido_balcao.id_filial)),0)  " &
      "as servicos,  " &
      "(isnull((SELECT sum(pedido_balcao_itens.quant *  " &
      "(pedido_balcao_itens.preco - pedido_balcao_itens.preco *  " &
      "(pedido_balcao_itens.desconto / 100))) AS total  " &
      "FROM pedido_balcao_itens INNER JOIN  " &
      "produtos ON pedido_balcao_itens.cod_produto = produtos.cod_produto  " &
      "WHERE (pedido_balcao_itens.num_pedido = pedido_balcao.num_pedido) AND  " &
      "(pedido_balcao_itens.id_filial = pedido_balcao.id_filial)),0)  " &
      "+  " &
      "isnull((SELECT sum(pedido_balcao_servicos.quant *  " &
      "(pedido_balcao_servicos.preco - pedido_balcao_servicos.preco *  " &
      "(pedido_balcao_servicos.desconto / 100)))  " &
      "AS total  " &
      "FROM pedido_balcao_servicos INNER JOIN  " &
      "produtos ON pedido_balcao_servicos.cod_servico = produtos.cod_produto  " &
      "WHERE (pedido_balcao_servicos.num_pedido = pedido_balcao.num_pedido) AND  " &
      "(pedido_balcao_servicos.id_filial = pedido_balcao.id_filial)),0))  " &
      "as Total " &
      ",(SELECT Left(item,LEN(item)-1)as delimited_list " &
        "FROM ( " &
        "select " &
        "CAST(" &
        "(SELECT cast(id_filial as varchar(3)) + '-' + cast(cod_fatura as varchar(10)) + ';' " &
        "FROM fatura_itens " &
        "where (fatura_itens.num_pedido = pedido_balcao.num_pedido And fatura_itens.id_filial_pedido = pedido_balcao.id_filial) " &
        "for xml path ('')) as varchar(max)) " &
        "as item " &
        ") as temp ) as n_fatura " &
      "FROM pedido_balcao INNER JOIN  " &
      "status_pedido ON pedido_balcao.cod_status_pedido =  " &
      "status_pedido.cod_status_pedido INNER JOIN  " &
      "Usuarios ON pedido_balcao.cod_vendedor = Usuarios.cod_usuario  " &
      "inner join cliente on pedido_balcao.cod_cliente = cliente.cod_cliente " &
      "and pedido_balcao.cod_filial_cliente = cliente.cod_filial_cliente     " &
      "WHERE (pedido_balcao.cod_filial_cliente =" & _cod_filial_cliente & ") AND " &
      "(pedido_balcao.cod_cliente = " & _cod_cliente & ")" &
      " and (pedido_balcao.data_pedido >= " & d.Pdt(di) &
      " and pedido_balcao.data_pedido <= " & d.Pdt(df) & ")" &
      " ORDER BY cliente.nome_cliente,pedido_balcao.data_pedido Desc"
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function os_Cliente() As DataTable
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT OS.cod_os, OS.id_filial, fases_OS.fase, " &
        "os.observacao " &
        "FROM OS INNER JOIN fases_OS ON OS.cod_fase = " &
        "fases_OS.cod_fase where os.cod_filial_cliente = " &
        Me._cod_filial_cliente & " and cod_cliente = " &
        Me._cod_cliente & " and dateadd(DAY ,30,os.data_previsao_entrega ) > " & d.Pdt(Now()) & " order by cod_os desc"
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function os_Cliente(ByVal dIni As DateTime, ByVal dFim As DateTime) As DataTable
        Dim strSQL As String = ""
        Dim tt As New DataTable
        strSQL = "SELECT OS.cod_os, OS.id_filial, fases_OS.fase, " &
        "os.observacao " &
        "FROM OS INNER JOIN fases_OS ON OS.cod_fase = " &
        "fases_OS.cod_fase where os.cod_filial_cliente = " &
        Me._cod_filial_cliente & " and cod_cliente = " &
        Me._cod_cliente & " and os.data_previsao_entrega >= '" & dIni & "' and os.data_previsao_entrega <= '" & dFim & "' order by cod_os desc"
        d.carrega_Tabela(strSQL, tt)
        Return tt
    End Function
#End Region
#Region "Faturas"
    Public Function faturas_cliente() As DataTable
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT faturas_cliente.* FROM faturas_cliente() AS faturas_cliente " &
        " WHERE (cod_filial_cliente = " & _cod_filial_cliente & ") AND " &
        "(cod_cliente = " & _cod_cliente & ") ORDER BY data_lancamento DESC"
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function faturas_cliente(ByVal di As Date, ByVal df As Date) As DataTable
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT faturas_cliente.* FROM faturas_cliente() AS faturas_cliente " &
        " WHERE (cod_filial_cliente = " & _cod_filial_cliente & ") AND " &
        "(cod_cliente = " & _cod_cliente & ") and (data_lancamento >= " & d.pdtm(di) &
        ") and (data_lancamento <= " & d.pdtm(df) &
        ") ORDER BY data_lancamento DESC"
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function faturas_clientes_com_saldo()
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "SELECT * FROM faturas_cliente() AS faturas_cliente " &
        "where (saldo <> 0) and cod_tipo_cliente = 1 order by nome_cliente, data_lancamento Desc"
        d.carrega_Tabela(tsql, tt)
        Return tt
    End Function
    Public Function faturas_clientes_com_saldo_sintetico()
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "SELECT nome_cliente, SUM(saldo) AS saldo FROM faturas_cliente() " &
        "AS faturas_cliente WHERE (cod_cliente > 1000) " &
        "GROUP BY nome_cliente HAVING(SUM(saldo) <> 0) " &
        "ORDER BY saldo DESC"
        d.carrega_Tabela(tsql, tt)
        Return tt
    End Function
    Public Function saldo_faturas_clientes() As Double
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "SELECT SUM(saldo) AS saldo FROM faturas_cliente() AS faturas_cliente " &
        "WHERE (cod_cliente > 1000) "
        d.carrega_Tabela(tsql, tt)
        Return tt.Rows(0)(0)
    End Function
    Public Function saldo_faturas_cliente_areceber() As Double
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "SELECT isnull(SUM(saldo),0) AS Saldo " &
        "FROM  faturas_cliente() AS faturas_cliente " &
        "where (cod_cliente = " & _cod_cliente & ") " &
        "and (cod_filial_cliente = " & _cod_filial_cliente & ") and saldo > 0"
        d.carrega_Tabela(tsql, tt)
        Return tt.Rows(0)(0)
    End Function

    Public Function saldo_faturas_cliente_apagar() As Double
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "SELECT isnull(SUM(saldo),0) AS Saldo " &
        "FROM  faturas_cliente() AS faturas_cliente " &
        "where (cod_cliente = " & _cod_cliente & ") " &
        "and (cod_filial_cliente = " & _cod_filial_cliente & ") and saldo < 0"
        d.carrega_Tabela(tsql, tt)
        Return tt.Rows(0)(0)
    End Function

#End Region
#Region "Funções auxiliares"
    Public Function cidades() As DataTable
        Dim tcid As New DataTable
        Dim dr As SqlClient.SqlDataReader
        Dim dd As New dados()
        tcid.Columns.Add("codigo")
        tcid.Columns.Add("cidade")
        dd.carrega_reader("Select * from cidades order by cidade,uf", dr)

        While dr.Read
            Dim r As DataRow
            r = tcid.NewRow
            r("codigo") = dr("codigo")
            r("cidade") = dr("cidade").ToString & " - " & dr("UF")
            tcid.Rows.Add(r)
        End While
        Return tcid
    End Function
    Public Function nomecidade(ByVal cod As Integer) As String
        Dim tcid As New DataTable
        Dim d As New dados
        d.carrega_Tabela("Select * from cidades where cod_cidade = " &
                         cod & "", tcid)
        If tcid.Rows.Count = 1 Then
            Return tcid.Rows(0)("cidade")
        Else
            Return ""
        End If
    End Function
    Public Function nomeUF(ByVal cod As Integer) As String
        Dim tcid As New DataTable
        Dim d As New dados
        d.carrega_Tabela("Select * from cidades where cod_cidade = " &
                         cod & "", tcid)
        If tcid.Rows.Count = 1 Then
            Return tcid.Rows(0)("UF")
        Else
            Return ""
        End If
    End Function
    Public Function exporta_nfe() As String
        Dim strResult As String
        strResult = "CLIENTE|1" & vbCrLf & "A|1.02" & vbCrLf &
        "E|CNPJ|" & limpaCNPJIE(_cnpj) & "|" & trataSTRNFe(_razao_social) & "|" & limpaCNPJIE(_ie) &
        "||" & trataSTRNFe(_endereco) & "|" & _numero & "|" & trataSTRNFe(_complemento) &
        "|" & _bairro & "|" & _cod_cidade & "|" & nomecidade(_cod_cidade) &
        "|" & _uf & "|" & _cep & "|1058|BRASIL|" & _fone_nota
        Return strResult
    End Function
    Public Function limpaCNPJIE(ByVal input As String) As String
        Dim strResult As String
        strResult = input.Replace(".", "")
        strResult = strResult.Replace("-", "")
        strResult = strResult.Replace("/", "")
        Return strResult
    End Function
    Public Function ValidaIE(ByVal ie As String, ByVal uf As String) As Boolean
        Dim ret As Integer
        Try
            ie = limpaCNPJIE(ie)
            ret = ConsisteInscricaoEstadual(ie, uf)
            If ret = 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Shared Function ValidaCPF(ByVal CPF As String) As Boolean
        Dim i, a, n1, n2 As Integer

        CPF = CPF.Replace(".", "").Replace(",", "").Replace("/", "").Replace("-", "")
        CPF = CPF.Trim

        If CPF = "" OrElse
          CPF.Trim.Length <> 11 OrElse
          CPF = "11111111111" OrElse
          CPF = "22222222222" OrElse
          CPF = "33333333333" OrElse
          CPF = "44444444444" OrElse
          CPF = "55555555555" OrElse
          CPF = "66666666666" OrElse
          CPF = "77777777777" OrElse
          CPF = "88888888888" OrElse
          CPF = "99999999999" Then
            Return False
        End If

        For a = 0 To 1
            n1 = 0
            For i = 1 To 9 + a
                n1 = n1 + Val(Mid(CPF, i, 1)) * (11 + a - i)
            Next
            n2 = 11 - (n1 - (Int(n1 / 11) * 11))
            If n2 = 10 Or n2 = 11 Then n2 = 0
            If n2 <> Val(Mid(CPF, 10 + a, 1)) Then
                Return False
            End If
        Next
        Return True
    End Function
    Public Function ValidaCNPJ(ByVal CGC As String) As Boolean
        Dim RecebeCNPJ As String
        Dim Numero(14) As Integer
        Dim Soma, Resultado1, Resultado2 As Integer

        RecebeCNPJ = limpaCNPJIE(CGC.Trim)

        If RecebeCNPJ.Length <> 14 Or
        RecebeCNPJ = "00000000000000" Or
        RecebeCNPJ = "11111111111111" Or
        RecebeCNPJ = "22222222222222" Or
        RecebeCNPJ = "33333333333333" Or
        RecebeCNPJ = "44444444444444" Or
        RecebeCNPJ = "55555555555555" Or
        RecebeCNPJ = "66666666666666" Or
        RecebeCNPJ = "77777777777777" Or
        RecebeCNPJ = "88888888888888" Or
        RecebeCNPJ = "99999999999999" Then
            Return False
        Else
            Numero(1) = CInt(Mid(RecebeCNPJ, 1, 1))
            Numero(2) = CInt(Mid(RecebeCNPJ, 2, 1))
            Numero(3) = CInt(Mid(RecebeCNPJ, 3, 1))
            Numero(4) = CInt(Mid(RecebeCNPJ, 4, 1))
            Numero(5) = CInt(Mid(RecebeCNPJ, 5, 1))
            Numero(6) = CInt(Mid(RecebeCNPJ, 6, 1))
            Numero(7) = CInt(Mid(RecebeCNPJ, 7, 1))
            Numero(8) = CInt(Mid(RecebeCNPJ, 8, 1))
            Numero(9) = CInt(Mid(RecebeCNPJ, 9, 1))
            Numero(10) = CInt(Mid(RecebeCNPJ, 10, 1))
            Numero(11) = CInt(Mid(RecebeCNPJ, 11, 1))
            Numero(12) = CInt(Mid(RecebeCNPJ, 12, 1))
            Numero(13) = CInt(Mid(RecebeCNPJ, 13, 1))
            Numero(14) = CInt(Mid(RecebeCNPJ, 14, 1))

            Soma = Numero(1) * 5 + Numero(2) * 4 + Numero(3) * 3 + Numero(4) * 2 + Numero(5) * 9 + Numero(6) * 8 + Numero(7) * 7 + Numero(8) * 6 + Numero(9) * 5 + Numero(10) * 4 + Numero(11) * 3 + Numero(12) * 2
            Soma = Soma - (11 * (Int(Soma / 11)))

            If Soma = 0 Or Soma = 1 Then
                Resultado1 = 0
            Else
                Resultado1 = 11 - Soma
            End If

            If Resultado1 = Numero(13) Then
                Soma = Numero(1) * 6 + Numero(2) * 5 + Numero(3) * 4 + Numero(4) * 3 + Numero(5) * 2 + Numero(6) * 9 + Numero(7) * 8 + Numero(8) * 7 + Numero(9) * 6 + Numero(10) * 5 + Numero(11) * 4 + Numero(12) * 3 + Numero(13) * 2
                Soma = Soma - (11 * (Int(Soma / 11)))

                If Soma = 0 Or Soma = 1 Then
                    Resultado2 = 0
                Else
                    Resultado2 = 11 - Soma
                End If

                If Resultado2 = Numero(14) Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If
        End If
    End Function
#End Region
#Region "Titulos/Cheques"
    Public Function titulos_Cliente() As DataTable
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "SELECT substring(boleto.Nossonumero,0,18) as nossonumero, boleto.tipo_documento, lancamentos.data_lancamento," &
        "boleto.documento,(lancamentos.Valor_pago+lancamentos.acrescimo+lancamentos.juros-lancamentos.desconto+lancamentos.taxas) + " &
        "ISNULL((Pagamentos_acordo.acrescimo + Pagamentos_acordo.juros + Pagamentos_acordo.taxas - Pagamentos_acordo.desconto),0) as Valor," &
        "lancamentos.data_vencimento, lancamentos.data_recebimento ," &
        "boleto.cod_lancamento, boleto.id_filial,lancamentos.id_filial_lancamento " &
        " FROM boleto INNER JOIN lancamentos ON boleto.cod_lancamento = " &
        "lancamentos.cod_lancamento AND boleto.id_filial = lancamentos.id_filial " &
        "inner join lancamentos_cliente on lancamentos.id_filial = " &
        "lancamentos_cliente.id_filial and lancamentos.cod_lancamento = " &
        "lancamentos_cliente.cod_lancamento " &
        "LEFT JOIN Pagamentos_acordo ON Pagamentos_acordo.cod_lancamento = lancamentos.cod_lancamento and " &
        "Pagamentos_acordo.id_filial = lancamentos.id_filial " &
        "where lancamentos_cliente.cod_filial_cliente = " &
        _cod_filial_cliente & " and lancamentos_cliente.cod_cliente = " &
        _cod_cliente & " and lancamentos.cod_status_lancamento = 1 order by data_recebimento, data_vencimento"
        d.carrega_Tabela(tsql, tt)
        Return tt
    End Function

    Public Function titulos_baixados_dia(ByVal dtInicial As Date, ByVal dtFinal As Date, ByVal filial As Integer) As DataTable
        Dim tsql As String
        Dim tt As New DataTable
        Dim ti, tf As String
        ti = dtInicial.ToShortDateString & " 00:00:00"
        tf = dtFinal.ToShortDateString & " 23:59:59"
        tsql = "SELECT cliente.cod_cliente,nome_cliente,boleto.Nossonumero, " &
        "boleto.tipo_documento,boleto.documento, lancamentos.data_lancamento," &
        "(lancamentos.Valor + isnull((Pagamentos_acordo.acrescimo+Pagamentos_acordo.juros+Pagamentos_acordo.taxas-Pagamentos_acordo.desconto),0)) as Valor," &
        "lancamentos.Valor,lancamentos.acrescimo,lancamentos.juros," &
        "lancamentos.desconto,(lancamentos.Valor+lancamentos.acrescimo+lancamentos.juros+lancamentos.taxas-lancamentos.desconto) + " &
        "ISNULL((Pagamentos_acordo.acrescimo+Pagamentos_acordo.juros+Pagamentos_acordo.taxas-Pagamentos_acordo.desconto),0) as total," &
        "lancamentos.data_vencimento, lancamentos.data_recebimento " &
        " FROM boleto INNER JOIN lancamentos ON boleto.cod_lancamento = " &
        "lancamentos.cod_lancamento AND boleto.id_filial = lancamentos.id_filial " &
        "inner join lancamentos_cliente on lancamentos.id_filial = " &
        "lancamentos_cliente.id_filial and lancamentos.cod_lancamento = " &
        "lancamentos_cliente.cod_lancamento " &
        "inner join cliente on lancamentos_cliente.cod_filial_cliente = " &
        "cliente.cod_filial_cliente and lancamentos_cliente.cod_cliente = " &
        "cliente.cod_cliente " &
        "LEFT JOIN Pagamentos_acordo ON LANCAMENTOS.cod_lancamento = Pagamentos_acordo.cod_lancamento AND " &
        "lancamentos.id_filial = Pagamentos_acordo.id_filial " &
        "where lancamentos.data_recebimento >= " &
        d.pdtm(ti) & " and lancamentos.data_recebimento <= " &
        d.pdtm(tf) & " and lancamentos.cod_status_lancamento <> 2 " &
        " and lancamentos.id_filial_lancamento = " & filial &
        " order by lancamentos.data_recebimento, boleto.nossonumero"
        d.carrega_Tabela(tsql, tt)
        Return tt
    End Function
    Public Function titulos_atraso() As DataTable
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "select * from Titulos_aberto() as titulos_aberto " &
        " where data_vencimento < " & d.pdtm(Now) &
        " order by nome_cliente, tipo_documento,documento, data_vencimento"
        d.carrega_Tabela(tsql, tt)
        Return tt
    End Function
    Public Function titulos_atraso_total() As String
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "SELECT sum(Valor)  from Titulos_aberto() as titulos_aberto " &
        " where data_vencimento < " & d.pdtm(Now) & ""
        d.carrega_Tabela(tsql, tt)
        Try
            Return cdinShow(tt.Rows(0)(0))
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Public Function titulos_atraso_cliente_total() As String
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "SELECT sum(Valor)  from Titulos_aberto() as titulos_aberto " &
        " where cod_cliente = " & _cod_cliente &
        " and cod_filial_cliente = " & _cod_filial_cliente &
        " and dateadd(day,0,data_vencimento) < " & d.Pdt(Now) & " and data_recebimento is null"

        d.carrega_Tabela(tsql, tt)
        Try
            Return tt.Rows(0)(0)
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function titulos_cliente_pendente_total_sem_atraso() As String
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "SELECT sum(lancamentos.Valor+ISNULL(pagamentos_acordo.acrescimo+pagamentos_acordo.juros+pagamentos_acordo.taxas-pagamentos_acordo.desconto,0)) as valor " &
        "FROM lancamentos left JOIN lancamentos_cliente ON lancamentos.cod_lancamento =" &
        "lancamentos_cliente.cod_lancamento AND lancamentos.id_filial = " &
        "lancamentos_cliente.id_filial left JOIN cliente ON " &
        "lancamentos_cliente.cod_filial_cliente = cliente.cod_filial_cliente " &
        "and lancamentos_cliente.cod_cliente = cliente.cod_cliente  " &
        "left join forma_pagamento on forma_pagamento.cod_forma_pagamento = " &
        "lancamentos.cod_forma_pagamento left join boleto on boleto.cod_lancamento = " &
        "lancamentos.cod_lancamento and boleto.id_filial = lancamentos.id_filial " &
        "left join Pagamentos_acordo on Pagamentos_acordo.cod_lancamento = lancamentos.cod_lancamento and Pagamentos_acordo.id_filial = lancamentos.id_filial " &
        "where lancamentos.data_recebimento is null " &
        " and lancamentos.cod_status_lancamento <> 2 " &
        " and lancamentos_cliente.cod_cliente = " & _cod_cliente &
        " and lancamentos_cliente.cod_filial_cliente = " & _cod_filial_cliente &
        " and lancamentos.data_vencimento >= " & d.Pdt(Now) & ""
        d.carrega_Tabela(tsql, tt)
        Try
            Return cdinShow(tt.Rows(0)(0))
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function cheques_cliente() As DataTable
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "SELECT bancos.banco, cheques.agencia, cheques.conta, cheques.cheque, " &
        "cheques.acrescimo, lancamentos.Valor, lancamentos.data_vencimento, " &
        "lancamentos.data_recebimento, lancamentos.n_parcela, lancamentos.n_parcelas " &
        "FROM cheques INNER JOIN lancamentos ON cheques.cod_lancamento = " &
        "lancamentos.cod_lancamento AND cheques.id_filial = lancamentos.id_filial INNER JOIN " &
        "lancamentos_cliente ON lancamentos.cod_lancamento = lancamentos_cliente.cod_lancamento " &
        "AND lancamentos.id_filial = lancamentos_cliente.id_filial INNER JOIN " &
        "bancos ON cheques.cod_banco = bancos.cod_banco where lancamentos_cliente.cod_filial_cliente = " &
        _cod_filial_cliente & " and lancamentos_cliente.cod_cliente = " &
        _cod_cliente & " order by data_vencimento DESC"
        d.carrega_Tabela(tsql, tt)
        Return tt
    End Function
    Public Function resumo_receber(ord As String) As DataTable
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "select receber.nome_cliente,receber.Pedidos_nao_faturados," &
        "receber.Saldo_faturas,(receber.Pedidos_nao_faturados + receber.Saldo_faturas) " &
        "as nao_faturados_Faturas_aberto,receber.titulos_atraso,receber.titulos_a_vencer, " &
        "(receber.titulos_atraso+receber.titulos_a_vencer) as titulos_aberto," &
        "receber.cheques_a_vencer ,(receber.Pedidos_nao_faturados + receber.Saldo_faturas " &
        "+receber.titulos_atraso+receber.titulos_a_vencer+receber.cheques_a_vencer) " &
        "as total_aberto   from resumo_receber() as receber " &
        "where Pedidos_nao_faturados > 0 or Saldo_faturas <> 0 or " &
        "titulos_a_vencer > 0 or titulos_atraso > 0 or cheques_a_vencer > 0 " &
        ord
        d.carrega_Tabela(tsql, tt)
        Return tt
    End Function
    Public Function resumo_receber_total() As String
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "select sum((receber.Pedidos_nao_faturados + receber.Saldo_faturas " &
        "+receber.titulos_atraso+receber.titulos_a_vencer+receber.cheques_a_vencer)) " &
        "as total_aberto   from resumo_receber() as receber "
        d.carrega_Tabela(tsql, tt)
        Try
            Return cdinShow(tt.Rows(0)(0))
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Public Function resumo_receber_cliente() As DataTable
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "select round(receber.Pedidos_nao_faturados,2) as Pedidos," &
        "round(receber.Saldo_faturas,2) as Faturas_aberto, " &
        "round(receber.titulos_atraso,2) as titulos_atraso,round(receber.titulos_a_vencer,2) as titulos_vencer, " &
        "round((receber.titulos_atraso+receber.titulos_a_vencer),2) as titulos_aberto," &
        "round(receber.cheques_a_vencer,2) AS cheques_vencer ,round((receber.Pedidos_nao_faturados + receber.Saldo_faturas " &
        "+receber.titulos_atraso+receber.titulos_a_vencer+receber.cheques_a_vencer+receber.acordo_atrasado),2) " &
        "as total_aberto, round((receber.acordo_atrasado),2) as acordo_atrasado  from resumo_receber() as receber " &
        "where cod_cliente = " & _cod_cliente &
        " and cod_filial_cliente = " & _cod_filial_cliente & ""
        d.carrega_Tabela(tsql, tt)
        Return tt
    End Function
    Public Function resumo_receber_total_cliente() As String

        Dim tsql As String
        Dim tt As New DataTable
        tsql = "select sum((receber.Pedidos_nao_faturados + receber.Saldo_faturas " &
        "+receber.titulos_atraso+receber.titulos_a_vencer+receber.cheques_a_vencer)) " &
        "as total_aberto   from resumo_receber() as receber " &
        "where cod_cliente = " & _cod_cliente &
        " and cod_filial_cliente = " & _cod_filial_cliente & ""
        d.carrega_Tabela(tsql, tt)
        Try
            Return cdinShow(tt.Rows(0)(0))
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Public Function lista_titulos_acordo() As DataTable
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "select * from boleto inner join lancamentos " &
        "on boleto.cod_lancamento = lancamentos.cod_lancamento " &
        "and boleto.id_filial = lancamentos.id_filial_lancamento " &
        "inner join lancamentos_cliente on lancamentos.cod_lancamento " &
        "= lancamentos_cliente.cod_lancamento and lancamentos." &
        "id_filial_lancamento = lancamentos_cliente.id_filial " &
        "where cod_status_lancamento = 1 and " &
        "data_recebimento is null " &
        "and data_vencimento < GETDATE() " &
        "and cod_cliente = " & _cod_cliente &
        "and cod_filial_cliente = " & _cod_filial_cliente &
        " order by data_vencimento"
        d.carrega_Tabela(tsql, tt)
        Return tt
    End Function
    Public Function resumo_receber_atraso() As DataTable
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "select resumo.nome_cliente,resumo.titulos_atraso_15 as ate15, " &
        "resumo.titulos_atraso_30 as ate30,resumo.titulos_atraso_60 as ate60, " &
        "resumo.titulos_atraso_90 as ate90, " &
        "resumo.titulos_atraso_mais_90 as acima90, " &
        "(resumo.titulos_a_vencer + resumo.cheques_a_vencer) as a_vencer " &
        "from titulos_atraso_resumo() as Resumo " &
        "where (titulos_atraso_15 <> 0) " &
        "or titulos_atraso_30 <> 0 " &
        "or titulos_atraso_60 <> 0 " &
        "or titulos_atraso_90 <> 0 " &
        "or titulos_atraso_mais_90 <> 0 " &
        "or (resumo.titulos_a_vencer + resumo.cheques_a_vencer) <> 0 " &
        "order by titulos_atraso_mais_90 desc,titulos_atraso_90 desc,titulos_atraso_60 desc, titulos_atraso_30 desc,titulos_atraso_15 desc"
        d.carrega_Tabela(tsql, tt)
        Return tt
    End Function
#End Region
#Region "Restrições"
    Public Function insere_restricao(ByVal txtMotivo As String, ByVal tipo As tipo_restricao) As String
        Dim tsql As String
        Dim chave As Integer
        chave = retorna_Chave("cod_restricao", "restricoes_cliente", "")
        tsql = "INSERT INTO restricoes_cliente (cod_restricao" &
        ",cod_filial_cliente,cod_cliente,cod_usuario " &
        ",descricao, cod_tipo_restricao,data_inicio) " &
        "VALUES(" & chave &
        "," & _cod_filial_cliente &
        "," & _cod_cliente &
        "," & UserID &
        "," & d.PStr(txtMotivo) &
        "," & tipo &
        "," & d.Pdt(Now.Date) &
        ")"
        Return d.Comando(tsql, True)
    End Function
    Public Function tb_tipos_restricao() As DataTable
        Dim tt As New DataTable
        d.carrega_Tabela("select * from tipo_restricao", tt)
        Return tt
    End Function
    Public Function tb_tipo_cliente() As DataTable
        Dim tt As New DataTable
        d.carrega_Tabela("select * from tipo_cliente", tt)
        Return tt
    End Function
    Public Function restricoes_cliente(ByVal todas As Boolean) As DataTable
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "SELECT restricoes_cliente.cod_restricao, restricoes_cliente.descricao, " &
        "tipo_restricao.tipo_restricao,restricoes_cliente.data_inicio, " &
        "restricoes_cliente.data_fim, restricoes_cliente.cod_tipo_restricao " &
        "FROM restricoes_cliente INNER JOIN " &
        "tipo_restricao ON restricoes_cliente.cod_tipo_restricao = " &
        "tipo_restricao.cod_tipo_restricao where restricoes_cliente.cod_filial_cliente = " &
        _cod_filial_cliente & " and restricoes_cliente.cod_cliente = " & _cod_cliente & ""
        If todas = False Then
            tsql = tsql & " and restricoes_cliente.data_fim is null "
        End If
        d.carrega_Tabela(tsql, tt)
        Return tt
    End Function
    Public Function encerra_restricao(ByVal cod As Integer) As String
        Dim tsql As String
        tsql = "update restricoes_cliente set data_fim = " &
        d.pdtm(Now) & " WHERE cod_restricao = " & cod &
        " and cod_filial_cliente = " & _cod_filial_cliente &
        " and cod_cliente = " & _cod_cliente & ""
        Return d.Comando(tsql, True)
    End Function

    'Criado por Ivanildo
    Public Function Debito_Cliente(ByVal data As Date) As DataTable
        Dim strSQL As String = "select cod_cliente, nome_cliente, SUM(Valor) as valor, min(data_vencimento) as data_venc," &
        "MAX(data_lancamento) as data_lanc, " &
        "case " &
        "when MAX(data_lancamento) > min(data_vencimento)  then 'Comprou' " &
        "else 'Não comprou' " &
        "end as Situacao " &
        "from verifica_debito() where data_vencimento < " & d.Pdt(data) & " and data_recebimento is null " &
        "and cod_status_lancamento = 1  group by cod_cliente, nome_cliente " &
        "having MAX(convert(nvarchar(10),(data_lancamento),23)) > min(convert(nvarchar(10),(data_vencimento),23))"
        Dim tt As New DataTable
        d.carrega_Tabela(strSQL, tt)
        Return tt
    End Function

#End Region

#Region "Autorizacao"
    Public Function insere_autorizacao(ByVal valor As Double, ByVal descricao As String, ByVal cod_usuario As Integer) As String
        Dim tsql As String
        Dim chave As Integer
        chave = retorna_Chave("cod_autorizacao", "autorizacao", " where filial_autorizacao = " & conf.Filial & "")
        tsql = "INSERT INTO autorizacao (cod_autorizacao ,filial_autorizacao ,cod_filial_cliente " &
        " ,cod_cliente,cod_usuario,valor,data,descricao) " &
        "VALUES(" & chave &
        "," & conf.Filial &
        "," & _cod_filial_cliente &
        "," & _cod_cliente &
        "," & cod_usuario &
        "," & d.cdin(valor) &
        "," & d.pdtm(Now) &
        "," & d.PStr(descricao) &
        ")"
        Return d.Comando(tsql, True)
    End Function
    Public Function lista_AUT_cliente() As DataTable
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "select * from autorizacao where cod_filial_cliente = " & _cod_filial_cliente & _
        " and cod_cliente = " & cod_cliente & " order by data desc"
        d.carrega_Tabela(tsql, tt)
        Return tt
    End Function
    Public Function consulta_autorizacao() As objAutorizacao
        Dim aut As New objAutorizacao(_cod_cliente, _cod_filial_cliente)
        Return aut
    End Function
    Public Function alt_valor_autorizacao(ByVal valor As Double, ByVal filial_aut As Integer, ByVal cod_autorizacao As Integer) As String
        Dim tsql As String

        tsql = "update autorizacao set valor = " & d.cdin(valor) & _
        " where filial_autorizacao = " & filial_aut & _
        " and cod_autorizacao = " & cod_autorizacao & ""
        Return d.Comando(tsql, True)
    End Function
    Public Function exclui_autorizacao(ByVal filial_aut As Integer, ByVal cod_autorizacao As Integer) As String
        Dim tsql As String
        tsql = "delete from autorizacao " & _
        " where filial_autorizacao = " & filial_aut & _
        " and cod_autorizacao = " & cod_autorizacao & ""
        Return d.Comando(tsql, True)
    End Function
#End Region
#End Region
End Class