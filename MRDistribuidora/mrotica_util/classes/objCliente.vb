Public Class objCliente
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
    Private _fone_nota As Int64
    Private _cod_tipo_cliente As Integer
    Private _e_mail As String
    Private _cod_tipo_compra As Integer
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
        Set(value)
            _cod_tipo_compra = value
        End Set
    End Property
#End Region
#Region "Procedimentos"
    Public Sub filtra_nome(ByVal n As String)
        Dim tsql As String
        tsql = "Select * from cliente where (nome_cliente like '%" & n & "%') or " & _
        "(razao_social like '%" & n & "%')"
        Source(tsql)
        primeiro()
    End Sub
    Public Sub filtra_cod(ByVal c As Integer)
        Dim tsql As String
        tsql = "Select * from cliente where cod_cliente = " & c & ""
        Source(tsql)
        primeiro()
    End Sub
    Public Sub New()
        Dim sql As String
        sql = "Select * from cliente where cod_cliente = 0"
        Source(sql)
        pacote = New objPacoteClienteDetalhes(d)
    End Sub
    Public Sub New(ByVal Xdados As dados)
        Dim sql As String
        d = Xdados
        sql = "Select * from cliente where cod_cliente = 0"
        pacote = New objPacoteClienteDetalhes(d)
        Source(sql)
    End Sub
    Public Sub mostra_todos(ByVal top As Integer)
        If top = 0 Then
            sql = "Select * from cliente Order by nome_cliente"
        Else
            sql = "select top (" & top.ToString & ") * from cliente Order by nome_cliente"
        End If

        Source(sql)
    End Sub
    Public Sub Clientes_labonorte()
        sql = "Select * from cliente where cod_cliente >= 1000 Order by nome_cliente "
        Source(sql)
    End Sub
    Public Sub Clientes_otica()
        sql = "Select * from cliente where cod_cliente <= 1000 Order by nome_cliente "
        Source(sql)
    End Sub
    Public Sub Source(ByVal iSql As String)
        sql = iSql
        Me.refreshData()
        primeiro()
    End Sub
    Public Sub refreshData()
        d.carrega_Tabela(sql, tabela)
        max = tabela.Rows.Count
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
            _fone_nota = rdNum(tabela.Rows(p)("fone_nota"))
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
                sql = "Insert into cliente(cod_filial_cliente,cod_cliente,nome_cliente," & _
                "razao_social,cnpj,ie,endereco,complemento,bairro,municipio,uf,cep,fones," & _
                "observacao,cod_promotor,limite_compra,limite_credito,limite_cheque, " & _
                "sem_desconto,codigo_cidade,numero,fone_nota, cod_tipo_cliente,e_mail,tipo_compra)" & _
                " Values(" & _
                _cod_filial_cliente & "," & _cod_cliente & "," & _
                d.PStr(_nome_cliente) & _
                "," & d.PStr(_razao_social) & _
                "," & d.PStr(_cnpj) & "," & d.PStr(_ie) & _
                "," & d.PStr(_endereco) & "," & d.PStr(_complemento) & "," & d.PStr(_bairro) & _
                "," & d.PStr(_municipio) & "," & d.PStr(_uf) & "," & d.PStr(_cep) & _
                "," & d.PStr(_fones) & "," & d.PStr(_observacao) & "," & _
                "0" & "," & _
                d.cdin(_limite_compra) & "," & _
                d.cdin(_limite_credito) & "," & _
                d.cdin(_limite_cheque) & _
                "," & _sem_desconto & _
                "," & _cod_cidade & _
                "," & d.cdin(_numero) & _
                "," & _fone_nota & _
                "," & _cod_tipo_cliente & _
                "," & d.PStr(_e_mail) & _
                "," & _cod_tipo_compra & ")"
                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tabela.NewRow
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
            r("codigo_cidade") = wrNum(_cod_cidade)
            r("numero") = wrNum(_numero)
            r("fone_nota") = wrNum(_fone_nota)
            r("cod_tipo_cliente") = wrNum(_cod_tipo_cliente)
            r("e_mail") = _e_mail
            r("tipo_compra") = _cod_tipo_compra
            tabela.Rows.Add(r)
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
                sql = "Update cliente set " & _
                "cod_cliente = " & _cod_cliente & _
                ",nome_cliente = " & d.PStr(_nome_cliente) & _
                ",razao_social = " & d.PStr(_razao_social) & _
                ",cnpj = " & d.PStr(_cnpj) & _
                ",ie = " & d.PStr(_ie) & _
                ",endereco=" & d.PStr(_endereco) & _
                ",complemento=" & d.PStr(_complemento) & _
                ",bairro=" & d.PStr(_bairro) & _
                ",municipio=" & d.PStr(_municipio) & _
                ",uf=" & d.PStr(_uf) & _
                ",cep=" & d.PStr(_cep) & _
                ",fones=" & d.PStr(_fones) & _
                ",observacao =" & d.PStr(_observacao) & _
                ",cod_promotor = 0" & _
                ",limite_compra = " & d.cdin(_limite_compra) & _
                ",limite_credito = " & d.cdin(_limite_credito) & _
                ",limite_cheque = " & d.cdin(_limite_cheque) & _
                ",qtd_dias_pagar = " & d.cdin(_qtd_dias_pagar) & _
                ",sem_desconto = " & _sem_desconto & _
                ",codigo_cidade = " & _cod_cidade & _
                ",numero = " & _numero & _
                ",fone_nota = " & _fone_nota & _
                ",cod_tipo_cliente = " & _cod_tipo_cliente & _
                ",e_mail = " & d.PStr(_e_mail) & _
                ",tipo_compra = " & _cod_tipo_compra & _
                " where cod_cliente = " & Me._cod_cliente & _
                " and cod_filial_cliente = " & Me._cod_filial_cliente & ""
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
            r("fone_nota") = wrNum(_fone_nota)
            r("cod_tipo_cliente") = wrNum(_cod_tipo_cliente)
            r("e_mail") = _e_mail
            r("tipo_compra") = _cod_tipo_compra
            OrigemSalvar = ""
            Return "OK:" & res & " registro(s) atualizado(s) com sucesso!"
        End If
    End Function
    Public Function deletar(ByVal cod_cliente As Integer, ByVal cod_filial_cliente As Integer)
        Dim sql As String
        Dim res As String
        sql = "Delete from cliente where cod_cliente = " & _cod_cliente & _
        " and cod_filial_cliente = " & _cod_filial_cliente & ""
        Try
            res = d.Comando(sql, True)
        Catch ex As Exception
            Return "ER:" & ex.Message
        End Try
        Me.refreshData()
        Me.primeiro()
        Return res & " Registros foram apagados!"
    End Function
    Public Function lista_clientes(ByVal crit_nome As String) As DataTable
        sql = "SELECT     (Cidades.Cidade + '-' + Cidades.UF) AS Cidade, cliente.* " & _
        "FROM cliente LEFT OUTER JOIN Cidades ON cliente.codigo_cidade = Cidades.Codigo " & _
        "where (nome_cliente like '%" & crit_nome & "%') or " & _
        " (razao_social like '%" & crit_nome & "%')"
        Source(sql)
        Return tabela
    End Function
    Public Function lista_clientes() As DataTable
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "Select cliente.nome_cliente,cliente.razao_social,cliente.cnpj,cliente.endereco,cliente.complemento, " & _
        "cliente.fones, cliente.observacao, " & _
        "(select max(data_pedido) from pedido_balcao where cod_cliente = cliente.cod_cliente and " & _
        "cod_filial_cliente = cliente.cod_filial_cliente) as ultima_compra, " & _
        "Cidades.Cidade,cidades.UF    from cliente left outer join Cidades on cliente.codigo_cidade = cidades.Codigo " & _
        "where (cod_tipo_cliente = 1) order by nome_cliente"
        d.carrega_Tabela(tsql, tt)
        Return tt
    End Function
    Public Function lista_clientes_30() As DataTable
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "Select cliente.nome_cliente,cliente.razao_social,cliente.cnpj,cliente.endereco,cliente.complemento, " & _
        "cliente.fones, cliente.observacao, " & _
        "(select max(data_pedido) from pedido_balcao where cod_cliente = cliente.cod_cliente and " & _
        "cod_filial_cliente = cliente.cod_filial_cliente) as ultima_compra, " & _
        "Cidades.Cidade,cidades.UF    from cliente left outer join Cidades on cliente.codigo_cidade = cidades.Codigo " & _
        "where (cod_tipo_cliente = 1) and (select max(data_pedido) from pedido_balcao where cod_cliente = cliente.cod_cliente and " & _
        "cod_filial_cliente = cliente.cod_filial_cliente) >= " & d.pdtm(DateAdd(DateInterval.Day, -30, Now)) & _
        " order by UF,cidade,nome_cliente"
        d.carrega_Tabela(tsql, tt)
        Return tt
    End Function
    Public Function lista_clientes_Ativos_nao_30() As DataTable
        'Listagem de clientes com atividade nos úlmos 120 dias mas sem compras nos últimos 30 dias
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "Select cliente.nome_cliente,cliente.razao_social,cliente.cnpj,cliente.endereco,cliente.complemento, " & _
        "cliente.fones, cliente.observacao, " & _
        "(select max(data_pedido) from pedido_balcao where cod_cliente = cliente.cod_cliente and " & _
        "cod_filial_cliente = cliente.cod_filial_cliente) as ultima_compra, " & _
        "Cidades.Cidade,cidades.UF    from cliente left outer join Cidades on cliente.codigo_cidade = cidades.Codigo " & _
        "where (cod_tipo_cliente = 1) and (select max(data_pedido) from pedido_balcao where cod_cliente = cliente.cod_cliente and " & _
        "cod_filial_cliente = cliente.cod_filial_cliente) >= " & d.pdtm(DateAdd(DateInterval.Day, -120, Now)) & _
        "and (select max(data_pedido) from pedido_balcao where cod_cliente = cliente.cod_cliente and " & _
        "cod_filial_cliente = cliente.cod_filial_cliente) <= " & d.pdtm(DateAdd(DateInterval.Day, -30, Now)) & _
        " order by UF,cidade,ultima_compra, nome_cliente"
        d.carrega_Tabela(tsql, tt)
        Return tt
    End Function
#Region "Pedidos/OS"
    Public Function pedidos_clientes() As DataTable
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT cliente.cod_cliente,cliente.cod_filial_cliente,cliente.nome_cliente," & _
        "pedido_balcao.id_filial, pedido_balcao.num_pedido, " & _
        "(SELECT Left(OS,LEN(OS)-1)as delimited_list " & _
        "FROM ( " & _
        "select " & _
        "CAST(" & _
        "(SELECT cast(id_filial as varchar(3)) + '-' + cast(cod_os as varchar(10)) + ';' " & _
        "FROM OS " & _
        "where (os.num_pedido = pedido_balcao.num_pedido and os.id_filial = pedido_balcao.id_filial and cod_fase <> 21) " & _
        "for xml path ('')) as varchar(max)) " & _
        "as os " & _
        ") as temp ) as OS, " & _
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
        "as Total " & _
        ",(SELECT Left(item,LEN(item)-1)as delimited_list " & _
        "FROM ( " & _
        "select " & _
        "CAST(" & _
        "(SELECT cast(id_filial as varchar(3)) + '-' + cast(cod_fatura as varchar(10)) + ';' " & _
        "FROM fatura_itens " & _
        "where (fatura_itens.num_pedido = pedido_balcao.num_pedido And fatura_itens.id_filial_pedido = pedido_balcao.id_filial) " & _
        "for xml path ('')) as varchar(max)) " & _
        "as item " & _
        ") as temp ) as n_fatura " & _
        "FROM pedido_balcao INNER JOIN  " & _
        "status_pedido ON pedido_balcao.cod_status_pedido =  " & _
        "status_pedido.cod_status_pedido INNER JOIN  " & _
        "Usuarios ON pedido_balcao.cod_vendedor = Usuarios.cod_usuario  " & _
        "inner join cliente on pedido_balcao.cod_cliente = cliente.cod_cliente and " & _
        "pedido_balcao.cod_filial_cliente = cliente.cod_filial_cliente " & _
        "WHERE (pedido_balcao.cod_filial_cliente =" & _cod_filial_cliente & ") AND " & _
        "(pedido_balcao.cod_cliente = " & _cod_cliente & ")" & _
        " and dateadd(DAY ,30,pedido_balcao.data_pedido ) > " & d.Pdt(Now()) & "  ORDER BY pedido_balcao.data_pedido Desc"
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function pedido_cliente(ByVal x_cod_cliente As Integer, ByVal xFilial As Integer, ByVal x_num As Integer) As DataRow
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT cliente.cod_cliente,cliente.cod_filial_cliente,cliente.nome_cliente, " & _
        "pedido_balcao.id_filial, pedido_balcao.num_pedido, " & _
        "(SELECT Left(OS,LEN(OS)-1)as delimited_list " & _
        "FROM ( " & _
        "select " & _
        "CAST(" & _
        "(SELECT cast(id_filial as varchar(3)) + '-' + cast(cod_os as varchar(10)) + ';' " & _
        "FROM OS " & _
        "where (os.num_pedido = pedido_balcao.num_pedido and os.id_filial = pedido_balcao.id_filial and cod_fase <> 21) " & _
        "for xml path ('')) as varchar(max)) " & _
        "as os " & _
        ") as temp ) as OS, " & _
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
        "as Total " & _
        ",(SELECT Left(item,LEN(item)-1)as delimited_list " & _
        "FROM ( " & _
        "select " & _
        "CAST(" & _
        "(SELECT cast(id_filial as varchar(3)) + '-' + cast(cod_fatura as varchar(10)) + ';' " & _
        "FROM fatura_itens " & _
        "where (fatura_itens.num_pedido = pedido_balcao.num_pedido And fatura_itens.id_filial_pedido = pedido_balcao.id_filial) " & _
        "for xml path ('')) as varchar(max)) " & _
        "as item " & _
        ") as temp ) as n_fatura " & _
        "FROM pedido_balcao INNER JOIN  " & _
        "status_pedido ON pedido_balcao.cod_status_pedido =  " & _
        "status_pedido.cod_status_pedido INNER JOIN  " & _
        "Usuarios ON pedido_balcao.cod_vendedor = Usuarios.cod_usuario  " & _
        "inner join cliente on pedido_balcao.cod_cliente = cliente.cod_cliente " & _
        "and pedido_balcao.cod_filial_cliente = cliente.cod_filial_cliente " & _
        "WHERE (pedido_balcao.cod_filial_cliente =" & xFilial & ") AND " & _
        "(pedido_balcao.cod_cliente = " & x_cod_cliente & " and " & _
        "pedido_balcao.num_pedido = " & x_num & ")" & _
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
        sql = "SELECT cliente.cod_cliente,cliente.cod_filial_cliente,cliente.nome_cliente," & _
        "pedido_balcao.id_filial, pedido_balcao.num_pedido, " & _
      "(SELECT Left(OS,LEN(OS)-1)as delimited_list " & _
        "FROM ( " & _
        "select " & _
        "CAST(" & _
        "(SELECT cast(id_filial as varchar(3)) + '-' + cast(cod_os as varchar(10)) + ';' " & _
        "FROM OS " & _
        "where (os.num_pedido = pedido_balcao.num_pedido and os.id_filial = pedido_balcao.id_filial and cod_fase <> 21) " & _
        "for xml path ('')) as varchar(max)) " & _
        "as os " & _
        ") as temp ) as OS, " & _
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
      "as Total " & _
     ",(SELECT Left(item,LEN(item)-1)as delimited_list " & _
        "FROM ( " & _
        "select " & _
        "CAST(" & _
        "(SELECT cast(id_filial as varchar(3)) + '-' + cast(cod_fatura as varchar(10)) + ';' " & _
        "FROM fatura_itens " & _
        "where (fatura_itens.num_pedido = pedido_balcao.num_pedido And fatura_itens.id_filial_pedido = pedido_balcao.id_filial) " & _
        "for xml path ('')) as varchar(max)) " & _
        "as item " & _
        ") as temp ) as n_fatura " & _
      "FROM pedido_balcao INNER JOIN  " & _
      "status_pedido ON pedido_balcao.cod_status_pedido =  " & _
      "status_pedido.cod_status_pedido INNER JOIN  " & _
      "Usuarios ON pedido_balcao.cod_vendedor = Usuarios.cod_usuario  " & _
      "inner join cliente on pedido_balcao.cod_cliente = cliente.cod_cliente " & _
      "and pedido_balcao.cod_filial_cliente = cliente.cod_filial_cliente " & _
       "WHERE (pedido_balcao.cod_filial_cliente =" & _cod_filial_cliente & ") AND " & _
      "(pedido_balcao.cod_cliente = " & _cod_cliente & ")" & _
      " and (SELECT count(item) as itens FROM fatura_itens  " & _
      "WHERE (num_pedido =pedido_balcao.num_pedido) AND  " & _
      "(id_filial_pedido =pedido_balcao.id_filial))  " & _
      f & _
      " ORDER BY pedido_balcao.data_pedido Desc"
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function pedido_cliente_faturado(ByVal x_cod_cliente As Integer, _
    ByVal xFilial As Integer, _
    ByVal di As Date, ByVal df As Date, ByVal faturado As Boolean) As DataTable
        Dim sql As String
        Dim tt As New DataTable
        Dim f As String
        If faturado = True Then
            f = " > 0 "
        Else
            f = " = 0 "
        End If
        sql = "SELECT cliente.cod_cliente,cliente.cod_filial_cliente,cliente.nome_cliente, " & _
        "pedido_balcao.id_filial, pedido_balcao.num_pedido, " & _
    "(SELECT Left(OS,LEN(OS)-1)as delimited_list " & _
        "FROM ( " & _
        "select " & _
        "CAST(" & _
        "(SELECT cast(id_filial as varchar(3)) + '-' + cast(cod_os as varchar(10)) + ';' " & _
        "FROM OS " & _
        "where (os.num_pedido = pedido_balcao.num_pedido and os.id_filial = pedido_balcao.id_filial and cod_fase <> 21) " & _
        "for xml path ('')) as varchar(max)) " & _
        "as os " & _
        ") as temp ) as OS, " & _
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
      "as Total " & _
     ",(SELECT Left(item,LEN(item)-1)as delimited_list " & _
        "FROM ( " & _
        "select " & _
        "CAST(" & _
        "(SELECT cast(id_filial as varchar(3)) + '-' + cast(cod_fatura as varchar(10)) + ';' " & _
        "FROM fatura_itens " & _
        "where (fatura_itens.num_pedido = pedido_balcao.num_pedido And fatura_itens.id_filial_pedido = pedido_balcao.id_filial) " & _
        "for xml path ('')) as varchar(max)) " & _
        "as item " & _
        ") as temp ) as n_fatura " & _
      "FROM pedido_balcao INNER JOIN  " & _
      "status_pedido ON pedido_balcao.cod_status_pedido =  " & _
      "status_pedido.cod_status_pedido INNER JOIN  " & _
      "Usuarios ON pedido_balcao.cod_vendedor = Usuarios.cod_usuario  " & _
      "inner join cliente on pedido_balcao.cod_cliente = cliente.cod_cliente " & _
      "and pedido_balcao.cod_filial_cliente = cliente.cod_filial_cliente " & _
      "WHERE (pedido_balcao.cod_filial_cliente =" & _cod_filial_cliente & ") AND " & _
      "(pedido_balcao.cod_cliente = " & _cod_cliente & ")" & _
      " and (SELECT count(item) as itens FROM fatura_itens  " & _
      "WHERE (num_pedido =pedido_balcao.num_pedido) AND  " & _
      "(id_filial_pedido =pedido_balcao.id_filial)) " & _
      f & _
      " and (pedido_balcao.data_pedido >= " & d.Pdt(di) & _
      " and pedido_balcao.data_pedido <= " & d.Pdt(df) & ")" & _
      " ORDER BY cliente.nome_cliente, pedido_balcao.data_pedido Desc"
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function pedido_clientes_faturado(ByVal xFilial As Integer, _
     ByVal faturado As Boolean) As DataTable
        Dim Tsql As String
        Dim tt As New DataTable
        Dim f As String
        If faturado = True Then
            f = ">= 1"
        Else
            f = "=0"
        End If
        Tsql = "select * from pedidos_FATURADOS() AS PEDIDOS_FATURADOS " & _
        " where faturado " & f & _
        " ORDER BY nome_cliente,  data_pedido Desc"
        d.carrega_Tabela(Tsql, tt)
        Return tt
    End Function
    Public Function pedido_cliente_faturado(ByVal x_cod_cliente As Integer, _
    ByVal xFilial As Integer, _
    ByVal di As Date, ByVal df As Date) As DataTable
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT cliente.cod_cliente,cliente.cod_filial_cliente,cliente.nome_cliente," & _
        "pedido_balcao.id_filial, pedido_balcao.num_pedido," & _
     "(SELECT Left(OS,LEN(OS)-1)as delimited_list " & _
        "FROM ( " & _
        "select " & _
        "CAST(" & _
        "(SELECT cast(id_filial as varchar(3)) + '-' + cast(cod_os as varchar(10)) + ';' " & _
        "FROM OS " & _
        "where (os.num_pedido = pedido_balcao.num_pedido and os.id_filial = pedido_balcao.id_filial and cod_fase <> 21) " & _
        "for xml path ('')) as varchar(max)) " & _
        "as os " & _
        ") as temp ) as OS, " & _
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
      "as Total " & _
      ",(SELECT Left(item,LEN(item)-1)as delimited_list " & _
        "FROM ( " & _
        "select " & _
        "CAST(" & _
        "(SELECT cast(id_filial as varchar(3)) + '-' + cast(cod_fatura as varchar(10)) + ';' " & _
        "FROM fatura_itens " & _
        "where (fatura_itens.num_pedido = pedido_balcao.num_pedido And fatura_itens.id_filial_pedido = pedido_balcao.id_filial) " & _
        "for xml path ('')) as varchar(max)) " & _
        "as item " & _
        ") as temp ) as n_fatura " & _
      "FROM pedido_balcao INNER JOIN  " & _
      "status_pedido ON pedido_balcao.cod_status_pedido =  " & _
      "status_pedido.cod_status_pedido INNER JOIN  " & _
      "Usuarios ON pedido_balcao.cod_vendedor = Usuarios.cod_usuario  " & _
      "inner join cliente on pedido_balcao.cod_cliente = cliente.cod_cliente " & _
      "and pedido_balcao.cod_filial_cliente = cliente.cod_filial_cliente     " & _
      "WHERE (pedido_balcao.cod_filial_cliente =" & _cod_filial_cliente & ") AND " & _
      "(pedido_balcao.cod_cliente = " & _cod_cliente & ")" & _
      " and (pedido_balcao.data_pedido >= " & d.Pdt(di) & _
      " and pedido_balcao.data_pedido <= " & d.Pdt(df) & ")" & _
      " ORDER BY cliente.nome_cliente,pedido_balcao.data_pedido Desc"
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function os_Cliente() As DataTable
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT OS.cod_os, OS.id_filial, fases_OS.fase, " & _
        "os.observacao " & _
        "FROM OS INNER JOIN fases_OS ON OS.cod_fase = " & _
        "fases_OS.cod_fase where os.cod_filial_cliente = " & _
        Me._cod_filial_cliente & " and cod_cliente = " & _
        Me._cod_cliente & " and dateadd(DAY ,30,os.data_previsao_entrega ) > " & d.Pdt(Now()) & " order by cod_os desc"
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function os_Cliente(ByVal dIni As DateTime, ByVal dFim As DateTime) As DataTable
        Dim strSQL As String = ""
        Dim tt As New DataTable
        strSQL = "SELECT OS.cod_os, OS.id_filial, fases_OS.fase, " & _
        "os.observacao " & _
        "FROM OS INNER JOIN fases_OS ON OS.cod_fase = " & _
        "fases_OS.cod_fase where os.cod_filial_cliente = " & _
        Me._cod_filial_cliente & " and cod_cliente = " & _
        Me._cod_cliente & " and os.data_previsao_entrega >= '" & dIni & "' and os.data_previsao_entrega <= '" & dFim & "' order by cod_os desc"
        d.carrega_Tabela(strSQL, tt)
        Return tt
    End Function
#End Region
#Region "Faturas"
    Public Function faturas_cliente() As DataTable
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT faturas_cliente.* FROM faturas_cliente() AS faturas_cliente " & _
        " WHERE (cod_filial_cliente = " & _cod_filial_cliente & ") AND " & _
        "(cod_cliente = " & _cod_cliente & ") ORDER BY data_lancamento DESC"
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function faturas_cliente(ByVal di As Date, ByVal df As Date) As DataTable
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT faturas_cliente.* FROM faturas_cliente() AS faturas_cliente " & _
        " WHERE (cod_filial_cliente = " & _cod_filial_cliente & ") AND " & _
        "(cod_cliente = " & _cod_cliente & ") and (data_lancamento >= " & d.pdtm(di) & _
        ") and (data_lancamento <= " & d.pdtm(df) & _
        ") ORDER BY data_lancamento DESC"
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function faturas_clientes_com_saldo()
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "SELECT * FROM faturas_cliente() AS faturas_cliente " & _
        "where (saldo <> 0) and cod_tipo_cliente = 1 order by nome_cliente, data_lancamento Desc"
        d.carrega_Tabela(tsql, tt)
        Return tt
    End Function
    Public Function faturas_clientes_com_saldo_sintetico()
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "SELECT nome_cliente, SUM(saldo) AS saldo FROM faturas_cliente() " & _
        "AS faturas_cliente WHERE (cod_cliente > 1000) " & _
        "GROUP BY nome_cliente HAVING(SUM(saldo) <> 0) " & _
        "ORDER BY saldo DESC"
        d.carrega_Tabela(tsql, tt)
        Return tt
    End Function
    Public Function saldo_faturas_clientes() As Double
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "SELECT SUM(saldo) AS saldo FROM faturas_cliente() AS faturas_cliente " & _
        "WHERE (cod_cliente > 1000) "
        d.carrega_Tabela(tsql, tt)
        Return tt.Rows(0)(0)
    End Function
    Public Function saldo_faturas_cliente_areceber() As Double
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "SELECT isnull(SUM(saldo),0) AS Saldo " & _
        "FROM  faturas_cliente() AS faturas_cliente " & _
        "where (cod_cliente = " & _cod_cliente & ") " & _
        "and (cod_filial_cliente = " & _cod_filial_cliente & ") and saldo > 0"
        d.carrega_Tabela(tsql, tt)
        Return tt.Rows(0)(0)
    End Function

    Public Function saldo_faturas_cliente_apagar() As Double
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "SELECT isnull(SUM(saldo),0) AS Saldo " & _
        "FROM  faturas_cliente() AS faturas_cliente " & _
        "where (cod_cliente = " & _cod_cliente & ") " & _
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
        dd.carrega_reader("Select * from cidade order by cidade,uf", dr)

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
        d.carrega_Tabela("Select * from cidades where cod_cidade = " & _
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
        d.carrega_Tabela("Select * from cidades where cod_cidade = " & _
                         cod & "", tcid)
        If tcid.Rows.Count = 1 Then
            Return tcid.Rows(0)("UF")
        Else
            Return ""
        End If
    End Function
    Public Function exporta_nfe() As String
        Dim strResult As String
        strResult = "CLIENTE|1" & vbCrLf & "A|1.02" & vbCrLf & _
        "E|CNPJ|" & limpaCNPJIE(_cnpj) & "|" & trataSTRNFe(_razao_social) & "|" & limpaCNPJIE(_ie) & _
        "||" & trataSTRNFe(_endereco) & "|" & _numero & "|" & trataSTRNFe(_complemento) & _
        "|" & _bairro & "|" & _cod_cidade & "|" & nomecidade(_cod_cidade) & _
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

        If CPF = "" OrElse _
          CPF.Trim.Length <> 11 OrElse _
          CPF = "11111111111" OrElse _
          CPF = "22222222222" OrElse _
          CPF = "33333333333" OrElse _
          CPF = "44444444444" OrElse _
          CPF = "55555555555" OrElse _
          CPF = "66666666666" OrElse _
          CPF = "77777777777" OrElse _
          CPF = "88888888888" OrElse _
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

        If RecebeCNPJ.Length <> 14 Or _
        RecebeCNPJ = "00000000000000" Or _
        RecebeCNPJ = "11111111111111" Or _
        RecebeCNPJ = "22222222222222" Or _
        RecebeCNPJ = "33333333333333" Or _
        RecebeCNPJ = "44444444444444" Or _
        RecebeCNPJ = "55555555555555" Or _
        RecebeCNPJ = "66666666666666" Or _
        RecebeCNPJ = "77777777777777" Or _
        RecebeCNPJ = "88888888888888" Or _
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
        tsql = "SELECT substring(boleto.Nossonumero,0,18) as nossonumero, boleto.tipo_documento, lancamentos.data_lancamento," & _
        "boleto.documento,(lancamentos.Valor+lancamentos.acrescimo+lancamentos.juros-lancamentos.desconto+lancamentos.taxas) + " & _
        "ISNULL((Pagamentos_acordo.acrescimo + Pagamentos_acordo.juros + Pagamentos_acordo.taxas - Pagamentos_acordo.desconto),0) as Valor," & _
        "lancamentos.data_vencimento, lancamentos.data_recebimento ," & _
        "boleto.cod_lancamento, boleto.id_filial,lancamentos.id_filial_lancamento " & _
        " FROM boleto INNER JOIN lancamentos ON boleto.cod_lancamento = " & _
        "lancamentos.cod_lancamento AND boleto.id_filial = lancamentos.id_filial " & _
        "inner join lancamentos_cliente on lancamentos.id_filial = " & _
        "lancamentos_cliente.id_filial and lancamentos.cod_lancamento = " & _
        "lancamentos_cliente.cod_lancamento " & _
        "LEFT JOIN Pagamentos_acordo ON Pagamentos_acordo.cod_lancamento = lancamentos.cod_lancamento and " & _
        "Pagamentos_acordo.id_filial = lancamentos.id_filial " & _
        "where lancamentos_cliente.cod_filial_cliente = " & _
        _cod_filial_cliente & " and lancamentos_cliente.cod_cliente = " & _
        _cod_cliente & " and lancamentos.cod_status_lancamento = 1 order by data_recebimento, data_vencimento"
        d.carrega_Tabela(tsql, tt)
        Return tt
    End Function

    Public Function titulos_baixados_dia(ByVal dtInicial As Date, ByVal dtFinal As Date) As DataTable
        Dim tsql As String
        Dim tt As New DataTable
        Dim ti, tf As String
        ti = dtInicial.ToShortDateString & " 00:00:00"
        tf = dtFinal.ToShortDateString & " 23:59:59"
        tsql = "SELECT cliente.cod_cliente,nome_cliente,boleto.Nossonumero, " & _
        "boleto.tipo_documento,boleto.documento, lancamentos.data_lancamento," & _
        "(lancamentos.Valor + isnull((Pagamentos_acordo.acrescimo+Pagamentos_acordo.juros+Pagamentos_acordo.taxas-Pagamentos_acordo.desconto),0)) as Valor," & _
        "lancamentos.Valor,lancamentos.acrescimo,lancamentos.juros," & _
        "lancamentos.desconto,(lancamentos.Valor+lancamentos.acrescimo+lancamentos.juros+lancamentos.taxas-lancamentos.desconto) + " & _
        "ISNULL((Pagamentos_acordo.acrescimo+Pagamentos_acordo.juros+Pagamentos_acordo.taxas-Pagamentos_acordo.desconto),0) as total," & _
        "lancamentos.data_vencimento, lancamentos.data_recebimento " & _
        " FROM boleto INNER JOIN lancamentos ON boleto.cod_lancamento = " & _
        "lancamentos.cod_lancamento AND boleto.id_filial = lancamentos.id_filial " & _
        "inner join lancamentos_cliente on lancamentos.id_filial = " & _
        "lancamentos_cliente.id_filial and lancamentos.cod_lancamento = " & _
        "lancamentos_cliente.cod_lancamento " & _
        "inner join cliente on lancamentos_cliente.cod_filial_cliente = " & _
        "cliente.cod_filial_cliente and lancamentos_cliente.cod_cliente = " & _
        "cliente.cod_cliente " & _
        "LEFT JOIN Pagamentos_acordo ON LANCAMENTOS.cod_lancamento = Pagamentos_acordo.cod_lancamento AND " & _
        "lancamentos.id_filial = Pagamentos_acordo.id_filial " & _
        "where lancamentos.data_recebimento >= " & _
        d.pdtm(ti) & " and lancamentos.data_recebimento <= " & _
        d.pdtm(tf) & " and not (lancamentos.cod_status_lancamento in (2,3)) " & _
        " and lancamentos.id_filial_lancamento IN (1,2,3,4)" & _
        " order by lancamentos.data_recebimento, boleto.nossonumero"
        d.carrega_Tabela(tsql, tt)
        Return tt
    End Function
    Public Function titulos_atraso() As DataTable
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "select * from Titulos_aberto() as titulos_aberto " & _
        " where data_vencimento < " & d.pdtm(Now) & _
        " order by nome_cliente, tipo_documento,documento, data_vencimento"
        d.carrega_Tabela(tsql, tt)
        Return tt
    End Function
    Public Function titulos_atraso_total() As String
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "SELECT sum(Valor)  from Titulos_aberto() as titulos_aberto " & _
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
        tsql = "SELECT sum(Valor)  from Titulos_aberto() as titulos_aberto " & _
        " where cod_cliente = " & _cod_cliente & _
        " and cod_filial_cliente = " & _cod_filial_cliente & _
        " and dateadd(day,2,data_vencimento) < " & d.Pdt(Now) & " and data_recebimento is null"

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
        tsql = "SELECT sum(lancamentos.Valor)  " & _
        " FROM lancamentos INNER JOIN lancamentos_cliente ON lancamentos.cod_lancamento =" & _
        "lancamentos_cliente.cod_lancamento AND lancamentos.id_filial = " & _
        "lancamentos_cliente.id_filial INNER JOIN cliente ON " & _
        "lancamentos_cliente.cod_filial_cliente = cliente.cod_filial_cliente " & _
        "and lancamentos_cliente.cod_cliente = cliente.cod_cliente  " & _
        "inner join forma_pagamento on forma_pagamento.cod_forma_pagamento = " & _
        "lancamentos.cod_forma_pagamento inner join boleto on boleto.cod_lancamento = " & _
        "lancamentos.cod_lancamento and boleto.id_filial = lancamentos.id_filial " & _
        "where lancamentos.data_recebimento is null " & _
        " and lancamentos.cod_status_lancamento <> 2 " & _
        " and lancamentos_cliente.cod_cliente = " & _cod_cliente & _
        " and lancamentos_cliente.cod_filial_cliente = " & _cod_filial_cliente & _
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
        tsql = "SELECT bancos.banco, cheques.agencia, cheques.conta, cheques.cheque, " & _
        "cheques.acrescimo, lancamentos.Valor, lancamentos.data_vencimento, " & _
        "lancamentos.data_recebimento, lancamentos.n_parcela, lancamentos.n_parcelas " & _
        "FROM cheques INNER JOIN lancamentos ON cheques.cod_lancamento = " & _
        "lancamentos.cod_lancamento AND cheques.id_filial = lancamentos.id_filial INNER JOIN " & _
        "lancamentos_cliente ON lancamentos.cod_lancamento = lancamentos_cliente.cod_lancamento " & _
        "AND lancamentos.id_filial = lancamentos_cliente.id_filial INNER JOIN " & _
        "bancos ON cheques.cod_banco = bancos.cod_banco where lancamentos_cliente.cod_filial_cliente = " & _
        _cod_filial_cliente & " and lancamentos_cliente.cod_cliente = " & _
        _cod_cliente & " order by data_vencimento DESC"
        d.carrega_Tabela(tsql, tt)
        Return tt
    End Function
    Public Function resumo_receber(ord As String) As DataTable
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "select receber.nome_cliente,receber.Pedidos_nao_faturados," & _
        "receber.Saldo_faturas,(receber.Pedidos_nao_faturados + receber.Saldo_faturas) " & _
        "as nao_faturados_Faturas_aberto,receber.titulos_atraso,receber.titulos_a_vencer, " & _
        "(receber.titulos_atraso+receber.titulos_a_vencer) as titulos_aberto," & _
        "receber.cheques_a_vencer ,(receber.Pedidos_nao_faturados + receber.Saldo_faturas " & _
        "+receber.titulos_atraso+receber.titulos_a_vencer+receber.cheques_a_vencer) " & _
        "as total_aberto   from resumo_receber() as receber " & _
        "where Pedidos_nao_faturados > 0 or Saldo_faturas <> 0 or " & _
        "titulos_a_vencer > 0 or titulos_atraso > 0 or cheques_a_vencer > 0 " & _
        ord
        d.carrega_Tabela(tsql, tt)
        Return tt
    End Function
    Public Function resumo_receber_total() As String
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "select sum((receber.Pedidos_nao_faturados + receber.Saldo_faturas " & _
        "+receber.titulos_atraso+receber.titulos_a_vencer+receber.cheques_a_vencer)) " & _
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
        tsql = "select round(receber.Pedidos_nao_faturados,2) as Pedidos," & _
        "round(receber.Saldo_faturas,2) as Faturas_aberto, " & _
        "round(receber.titulos_atraso,2) as titulos_atraso,round(receber.titulos_a_vencer,2) as titulos_vencer, " & _
        "round((receber.titulos_atraso+receber.titulos_a_vencer),2) as titulos_aberto," & _
        "round(receber.cheques_a_vencer,2) AS cheques_vencer ,round((receber.Pedidos_nao_faturados + receber.Saldo_faturas " & _
        "+receber.titulos_atraso+receber.titulos_a_vencer+receber.cheques_a_vencer),2) " & _
        "as total_aberto   from resumo_receber() as receber " & _
        "where cod_cliente = " & _cod_cliente & _
        " and cod_filial_cliente = " & _cod_filial_cliente & ""
        d.carrega_Tabela(tsql, tt)
        Return tt
    End Function
    Public Function resumo_receber_total_cliente() As String

        Dim tsql As String
        Dim tt As New DataTable
        tsql = "select sum((receber.Pedidos_nao_faturados + receber.Saldo_faturas " & _
        "+receber.titulos_atraso+receber.titulos_a_vencer+receber.cheques_a_vencer)) " & _
        "as total_aberto   from resumo_receber() as receber " & _
        "where cod_cliente = " & _cod_cliente & _
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
        tsql = "select * from boleto inner join lancamentos " & _
        "on boleto.cod_lancamento = lancamentos.cod_lancamento " & _
        "and boleto.id_filial = lancamentos.id_filial_lancamento " & _
        "inner join lancamentos_cliente on lancamentos.cod_lancamento " & _
        "= lancamentos_cliente.cod_lancamento and lancamentos." & _
        "id_filial_lancamento = lancamentos_cliente.id_filial " & _
        "where cod_status_lancamento = 1 and " & _
        "data_recebimento is null " & _
        "and data_vencimento < GETDATE() " & _
        "and cod_cliente = " & _cod_cliente & _
        "and cod_filial_cliente = " & _cod_filial_cliente & _
        " order by data_vencimento"
        d.carrega_Tabela(tsql, tt)
        Return tt
    End Function
    Public Function resumo_receber_atraso() As DataTable
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "select resumo.nome_cliente,resumo.titulos_atraso_15 as ate15, " & _
        "resumo.titulos_atraso_30 as ate30,resumo.titulos_atraso_60 as ate60, " & _
        "resumo.titulos_atraso_90 as ate90, " & _
        "resumo.titulos_atraso_mais_90 as acima90, " & _
        "(resumo.titulos_a_vencer + resumo.cheques_a_vencer) as a_vencer " & _
        "from titulos_atraso_resumo() as Resumo " & _
        "where (titulos_atraso_15 <> 0) " & _
        "or titulos_atraso_30 <> 0 " & _
        "or titulos_atraso_60 <> 0 " & _
        "or titulos_atraso_90 <> 0 " & _
        "or titulos_atraso_mais_90 <> 0 " & _
        "or (resumo.titulos_a_vencer + resumo.cheques_a_vencer) <> 0 " & _
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
        tsql = "INSERT INTO restricoes_cliente (cod_restricao" & _
        ",cod_filial_cliente,cod_cliente,cod_usuario " & _
        ",descricao, cod_tipo_restricao,data_inicio) " & _
        "VALUES(" & chave & _
        "," & _cod_filial_cliente & _
        "," & _cod_cliente & _
        "," & UserID & _
        "," & d.PStr(txtMotivo) & _
        "," & tipo & _
        "," & d.Pdt(Now.Date) & _
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
        tsql = "SELECT restricoes_cliente.cod_restricao, restricoes_cliente.descricao, " & _
        "tipo_restricao.tipo_restricao,restricoes_cliente.data_inicio, " & _
        "restricoes_cliente.data_fim, restricoes_cliente.cod_tipo_restricao " & _
        "FROM restricoes_cliente INNER JOIN " & _
        "tipo_restricao ON restricoes_cliente.cod_tipo_restricao = " & _
        "tipo_restricao.cod_tipo_restricao where restricoes_cliente.cod_filial_cliente = " & _
        _cod_filial_cliente & " and restricoes_cliente.cod_cliente = " & _cod_cliente & ""
        If todas = False Then
            tsql = tsql & " and restricoes_cliente.data_fim is null "
        End If
        d.carrega_Tabela(tsql, tt)
        Return tt
    End Function
    Public Function encerra_restricao(ByVal cod As Integer) As String
        Dim tsql As String
        tsql = "update restricoes_cliente set data_fim = " & _
        d.pdtm(Now) & " WHERE cod_restricao = " & cod & _
        " and cod_filial_cliente = " & _cod_filial_cliente & _
        " and cod_cliente = " & _cod_cliente & ""
        Return d.Comando(tsql, True)
    End Function

    'Criado por Ivanildo
    Public Function Debito_Cliente(ByVal data As Date) As DataTable
        Dim strSQL As String = "select cod_cliente, nome_cliente, SUM(Valor) as valor, min(data_vencimento) as data_venc," & _
        "MAX(data_lancamento) as data_lanc, " & _
        "case " & _
        "when MAX(data_lancamento) > min(data_vencimento)  then 'Comprou' " & _
        "else 'Não comprou' " & _
        "end as Situacao " & _
        "from verifica_debito() where data_vencimento < " & d.Pdt(data) & " and data_recebimento is null " & _
        "and cod_status_lancamento = 1  group by cod_cliente, nome_cliente " & _
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
        tsql = "select * from autorizacao where cod_filial_cliente = " & _cod_filial_cliente &
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

        tsql = "update autorizacao set valor = " & d.cdin(valor) &
        " where filial_autorizacao = " & filial_aut &
        " and cod_autorizacao = " & cod_autorizacao & ""
        Return d.Comando(tsql, True)
    End Function
    Public Function exclui_autorizacao(ByVal filial_aut As Integer, ByVal cod_autorizacao As Integer) As String
        Dim tsql As String
        tsql = "delete from autorizacao " &
        " where filial_autorizacao = " & filial_aut &
        " and cod_autorizacao = " & cod_autorizacao & ""
        Return d.Comando(tsql, True)
    End Function
#End Region
#End Region
End Class
Public Class objAutorizacao
#Region "Variaveis"
    Private _cod_autorizacao As Integer
    Private _filial_autorizacao As Integer
    Private _cod_filial_cliente As Integer
    Private _cod_cliente As Integer
    Private _cod_usuario As Integer
    Private _valor As Decimal
    Private _data As Date
    Private _data_uso As Object
    Private _id_filial_pedido As Object
    Private _num_pedido As Object
    Private _descricao As String
    Dim sql As String
    Dim tabela As New DataTable
    Public max, posicao, lastpos As Integer
    Dim d As New dados
#End Region
#Region "GET SET"
    Public ReadOnly Property cod_autorizacao()
        Get
            cod_autorizacao = _cod_autorizacao
        End Get
    End Property
    Public ReadOnly Property filial_autorizacao()
        Get
            filial_autorizacao = _filial_autorizacao
        End Get
    End Property
    Public ReadOnly Property cod_filial_cliente()
        Get
            cod_filial_cliente = _cod_filial_cliente
        End Get
    End Property
    Public ReadOnly Property cod_cliente()
        Get
            cod_cliente = _cod_cliente
        End Get
    End Property
    Public ReadOnly Property cod_usuario()
        Get
            cod_usuario = _cod_usuario
        End Get
    End Property
    Public ReadOnly Property valor()
        Get
            valor = _valor
        End Get
    End Property
    Public ReadOnly Property data()
        Get
            data = _data
        End Get
    End Property
    Public Property data_uso()
        Get
            data_uso = _data_uso
        End Get
        Set(ByVal value)
            _data_uso = value
        End Set
    End Property
    Public Property id_filial_pedido()
        Get
            id_filial_pedido = _id_filial_pedido
        End Get
        Set(ByVal value)
            _id_filial_pedido = value
        End Set
    End Property
    Public Property num_pedido()
        Get
            num_pedido = _num_pedido
        End Get
        Set(ByVal value)
            _num_pedido = value
        End Set
    End Property
    Public ReadOnly Property descricao()
        Get
            descricao = _descricao
        End Get
    End Property
#End Region
#Region "Procedimentos"
    Public Sub New(ByVal x_cod_cliente As Integer, ByVal x_cod_filial_cliente As Integer)
        sql = "Select * from autorizacao where cod_cliente = " & x_cod_cliente &
        " and cod_filial_cliente = " & x_cod_filial_cliente & " and data_uso IS NULL"
        Source(sql)
    End Sub
    Public Sub New(ByVal x_cod_cliente As Integer, ByVal x_cod_filial_cliente As Integer, ByVal xd As dados)
        d = xd
        sql = "Select * from autorizacao where cod_cliente = " & x_cod_cliente &
        " and cod_filial_cliente = " & x_cod_filial_cliente & " and data_uso IS NULL"
        Source(sql)
    End Sub
    Public Sub New(ByVal x_cod_autorizacao As Integer, ByVal x_filial_autorizacao As Integer, ByVal i As Integer)
        sql = "Select * from autorizacao where cod_autorizacao = " & x_cod_autorizacao &
        " and cod_filial_cliente = " & x_filial_autorizacao & ""
        Source(sql)
    End Sub
    Public Sub Source(ByVal iSql As String)
        sql = iSql
        Me.refreshData()
        primeiro()
    End Sub
    Public Sub refreshData()
        d.carrega_Tabela(sql, tabela)
        max = tabela.Rows.Count
    End Sub
    Public Sub Registro(ByVal pos As Integer) 'Move o Registro para a posição indicada
        Dim p As Integer = pos
        If p <= 0 Then p = 0
        If p > max Then p = max
        posicao = p
        If max > 0 Then
            _cod_cliente = tabela.Rows(p)("cod_cliente")
            _cod_filial_cliente = tabela.Rows(p)("cod_filial_cliente")
            _cod_autorizacao = tabela.Rows(p)("cod_autorizacao")
            _filial_autorizacao = tabela.Rows(p)("filial_autorizacao")
            _cod_usuario = tabela.Rows(p)("cod_usuario")
            _valor = rdNum(tabela.Rows(p)("valor"))
            _data = rdData(tabela.Rows(p)("data"))
            _data_uso = rdData(tabela.Rows(p)("data_uso"))
            _id_filial_pedido = rdNum(tabela.Rows(p)("id_filial_pedido"))
            _num_pedido = rdNum(tabela.Rows(p)("num_pedido"))
            _descricao = rdTexto(tabela.Rows(p)("descricao"))
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
        Me.Registro(lastpos)
    End Sub
#End Region
#Region "Funcoes"
    Public Function EOF() As Boolean
        If posicao = max Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function registra_uso(ByVal data As Date, ByVal filial As Integer, ByVal pedido As Integer) As String
        Dim tsql As String
        tsql = "Update autorizacao set data_uso =" &
        d.pdtm(data) & ", id_filial_pedido = " &
        filial & ", num_pedido = " & pedido &
        " where cod_autorizacao = " & _cod_autorizacao &
        " and filial_autorizacao = " & _filial_autorizacao & ""
        Return d.Comando(tsql, True)
    End Function

#End Region
End Class
Public Class objCiclo
#Region "Variaveis"
    Private _cod_ciclo As Integer
    Private _filial_ciclo As Integer
    Private _cod_filial_cliente As Integer
    Private _cod_cliente As Integer
    Private _inicio_ciclo As Object
    Private _fim_ciclo As Object
    Dim sql As String
    Dim eNovo As Boolean
    Dim tabela As New DataTable
    Public max, posicao, lastpos As Integer
    Dim d As New dados
    Dim conf As New config
#End Region
#Region "GET SET"
    Public Property cod_ciclo()
        Get
            cod_ciclo = _cod_ciclo
        End Get
        Set(ByVal value)
            _cod_ciclo = value
        End Set
    End Property
    Public Property filial_ciclo()
        Get
            filial_ciclo = _filial_ciclo
        End Get
        Set(ByVal value)
            _filial_ciclo = value
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
    Public Property inicio_ciclo()
        Get
            inicio_ciclo = _inicio_ciclo
        End Get
        Set(ByVal value)
            _inicio_ciclo = value
        End Set
    End Property
    Public Property fim_ciclo()
        Get
            fim_ciclo = _fim_ciclo
        End Get
        Set(ByVal value)
            _fim_ciclo = value
        End Set
    End Property
#End Region
#Region "Procedimentos"
    Public Sub New(ByVal x_cod_cliente As Integer, ByVal x_cod_filial_cliente As Integer)
        sql = "Select * from ciclo_faturamento where cod_cliente = " & x_cod_cliente &
        " and cod_filial_cliente = " & x_cod_filial_cliente & ""
        Source(sql)
    End Sub
    Public Sub Source(ByVal iSql As String)
        sql = iSql
        Me.refreshData()
        primeiro()
    End Sub
    Public Sub refreshData()
        d.carrega_Tabela(sql, tabela)
        max = tabela.Rows.Count
    End Sub
    Public Sub Registro(ByVal pos As Integer) 'Move o Registro para a posição indicada
        Dim p As Integer = pos
        If p <= 0 Then p = 0
        If p > max Then p = max
        posicao = p
        If max > 0 Then
            _cod_cliente = tabela.Rows(p)("cod_cliente")
            _cod_filial_cliente = tabela.Rows(p)("cod_filial_cliente")
            _cod_ciclo = tabela.Rows(p)("cod_ciclo")
            _filial_ciclo = tabela.Rows(p)("filial_ciclo")
            _inicio_ciclo = rdData(tabela.Rows(p)("inicio_ciclo"))
            _fim_ciclo = rdData(tabela.Rows(p)("fim_ciclo"))
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
        Me.Registro(lastpos)
    End Sub
    Public Sub novo()
        eNovo = True
    End Sub
#End Region
#Region "Funcoes"
    Public Function EOF() As Boolean
        If posicao = max Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function salvar()
        Dim TSQL As String
        If eNovo = True Then
            If Me.max > 0 Then
                Return "ER: Cliente já tem ciclo!"
                Exit Function
            End If
            _cod_ciclo = retorna_Chave("cod_ciclo", "ciclo_faturamento", " where filial_ciclo = " & conf.Filial)
            TSQL = "INSERT INTO ciclo_faturamento (cod_ciclo,filial_ciclo,cod_cliente,cod_filial_cliente" & _
           ",Inicio_ciclo ,fim_ciclo) VALUES(" & _cod_ciclo & _
           "," & _filial_ciclo & _
           "," & _cod_cliente & _
           "," & _cod_filial_cliente & _
           "," & d.Pdt(_inicio_ciclo) & _
           "," & d.Pdt(_fim_ciclo) & ")"
            Return d.Comando(TSQL, True)
            eNovo = False
            Exit Function
        Else
            TSQL = "update ciclo_faturamento set inicio_ciclo = " & d.Pdt(_inicio_ciclo) & _
            ", fim_ciclo = " & d.Pdt(_fim_ciclo) & " where cod_ciclo = " & _cod_ciclo & _
            " and filial_ciclo = " & _filial_ciclo & ""
            Return d.Comando(TSQL, True)
            Exit Function
        End If
    End Function

#End Region
End Class
