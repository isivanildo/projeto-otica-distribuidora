Imports System.Windows.Forms
Public Class objPacoteClienteDetalhes
#Region "Atributos"
    Private _cod_pacote As Integer
    Private _item As Integer
    Private _cod_tabela As Integer
    Private _cod_filial_cliente As Object
    Private _cod_cliente As Object
    Private _desconto As Object
    Private _quantidade_contratada As Object
    Private _cod_surf As Object
    Private _desc_surf As Object
    Private _cod_mont As Object
    Private _desc_mont As Object
    Private _cod_trat As Object
    Private _desc_trat As Object
    Private _preco_tabela As Object
    Private _preco_desc As Object
    Private _preco_tabela_surf As Object
    Private _preco_surf_desc As Object
    Private _quantidade_surf As Object
    Private _preco_tabela_mont As Object
    Private _preco_mont_desc As Object
    Private _quantidade_mont As Object
    Private _preco_tabela_trat As Object
    Private _preco_trat_desc As Object
    Private _quantidade_trat As Object
    Private _status_item As Char
    Private _cod_pacote_ant As Integer
    Private _cod_usuario As Integer

    Public posicao As Integer = 0
    Public max As Integer
    Public tb As New DataTable
    Public OrigemSalvar As String = ""
    Private lastPos As Integer = 0
    Private sql As String
    Dim d As New dados
#End Region
#Region "GET SET"
    Public Property cod_pacote()
        Get
            cod_pacote = _cod_pacote
        End Get
        Set(ByVal value)
            _cod_pacote = value
        End Set
    End Property
    Public Property item()
        Get
            item = _item
        End Get
        Set(ByVal value)
            _item = value
        End Set
    End Property
    Public Property cod_tabela()
        Get
            cod_tabela = _cod_tabela
        End Get
        Set(ByVal Value)
            _cod_tabela = Value
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
    Public Property desconto()
        Get
            desconto = _desconto
        End Get
        Set(ByVal value)
            _desconto = value
        End Set
    End Property
    Public Property quantidade_contratada()
        Get
            quantidade_contratada = _quantidade_contratada
        End Get
        Set(ByVal value)
            _quantidade_contratada = value
        End Set
    End Property
    Public Property cod_surf()
        Get
            cod_surf = _cod_surf
        End Get
        Set(ByVal value)
            _cod_surf = value
        End Set
    End Property
    Public Property desc_surf()
        Get
            desc_surf = _desc_surf
        End Get
        Set(ByVal value)
            _desc_surf = value
        End Set
    End Property
    Public Property cod_mont()
        Get
            cod_mont = _cod_mont
        End Get
        Set(ByVal value)
            _cod_mont = value
        End Set
    End Property
    Public Property desc_mont()
        Get
            desc_mont = _desc_mont
        End Get
        Set(ByVal value)
            _desc_mont = value
        End Set
    End Property
    Public Property cod_trat
        Get
            cod_trat = _cod_trat
        End Get
        Set(value)
            _cod_trat = value
        End Set
    End Property
    Public Property desc_trat
        Get
            desc_trat = _desc_trat
        End Get
        Set(value)
            _desc_trat = value
        End Set
    End Property
    Public Property preco_tabela
        Get
            preco_tabela = _preco_tabela
        End Get
        Set(value)
            _preco_tabela = value
        End Set
    End Property
    Public Property preco_desc
        Get
            preco_desc = _preco_desc
        End Get
        Set(value)
            _preco_desc = value
        End Set
    End Property
    Public Property preco_tabela_surf
        Get
            preco_tabela_surf = _preco_tabela_surf
        End Get
        Set(value)
            _preco_tabela_surf = value
        End Set
    End Property
    Public Property preco_surf_desc
        Get
            preco_surf_desc = _preco_surf_desc
        End Get
        Set(value)
            _preco_surf_desc = value
        End Set
    End Property
    Public Property quantidade_surf
        Get
            quantidade_surf = _quantidade_surf
        End Get
        Set(value)
            _quantidade_surf = value
        End Set
    End Property
    Public Property preco_tabela_mont
        Get
            preco_tabela_mont = _preco_tabela_mont
        End Get
        Set(value)
            _preco_tabela_mont = value
        End Set
    End Property
    Public Property preco_mont_desc
        Get
            preco_mont_desc = _preco_mont_desc
        End Get
        Set(value)
            _preco_mont_desc = value
        End Set
    End Property
    Public Property quantidade_mont
        Get
            quantidade_mont = _quantidade_mont
        End Get
        Set(value)
            _quantidade_mont = value
        End Set
    End Property
    Public Property preco_tabela_trat
        Get
            preco_tabela_trat = _preco_tabela_trat
        End Get
        Set(value)
            _preco_tabela_trat = value
        End Set
    End Property
    Public Property preco_trat_desc
        Get
            preco_trat_desc = _preco_trat_desc
        End Get
        Set(value)
            _preco_trat_desc = value
        End Set
    End Property
    Public Property quantidade_trat
        Get
            quantidade_trat = _quantidade_trat
        End Get
        Set(value)
            _quantidade_trat = value
        End Set
    End Property
    Public Property status_item
        Get
            status_item = _status_item
        End Get
        Set(value)
            _status_item = value
        End Set
    End Property
    Public Property cod_pacote_ant
        Get
            cod_pacote_ant = _cod_pacote_ant
        End Get
        Set(value)
            _cod_pacote_ant = value
        End Set
    End Property
    Public Property cod_usuario
        Get
            cod_usuario = _cod_usuario
        End Get
        Set(value)
            _cod_usuario = value
        End Set
    End Property
#End Region
#Region "Procedimentos"
    Public Sub New()
        Dim sql As String
        sql = "Select * from pacote_cliente_detalhes where cod_pacote = 0"
        Source(sql)
    End Sub
    Public Sub New(ByVal Xdados As dados)
        Dim sql As String
        d = Xdados
        sql = "Select * from pacote_cliente_detalhes where cod_pacote = 0"
        Source(sql)
    End Sub
    Public Sub New(ByVal x_cod_filial_Cliente As Integer, ByVal x_cod_cliente As Integer, ByVal x_cod_pacote As Integer)
        filtra(x_cod_cliente, x_cod_filial_Cliente, x_cod_pacote)
    End Sub
    Public Sub New(ByVal x_cod_filial_Cliente As Integer, ByVal x_cod_cliente As Integer)
        filtra(x_cod_cliente, x_cod_filial_Cliente)
    End Sub
    Public Sub filtra(ByVal xCod_cliente As Integer, ByVal xCod_filial_cliente As Integer, ByVal xCod_pacote As Integer)
        sql = "select * from pacote_cliente_detalhes where cod_cliente = " & _
        xCod_cliente & " and cod_filial_cliente = " & xCod_filial_cliente & _
        " and cod_pacote = " & xCod_pacote & ""
        Source(sql)
    End Sub
    Public Sub filtra(ByVal xCod_cliente As Integer, ByVal xCod_filial_cliente As Integer)
        sql = "select * from pacote_cliente_detalhes where cod_cliente = " & _
        xCod_cliente & " and cod_filial_cliente = " & xCod_filial_cliente & ""
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
    Public Sub Registro(ByVal pos As Integer) 'Move o Registro para a posição indicada
        Dim p As Integer = pos
        If p <= 0 Then p = 0
        If p > max Then p = max
        posicao = p
        If max > 0 Then
            _cod_pacote = tb.Rows(p)("cod_pacote")
            _item = tb.Rows(p)("item")
            _cod_tabela = tb.Rows(p)("cod_tabela")
            _cod_filial_cliente = tb.Rows(p)("cod_filial_cliente")
            _cod_cliente = tb.Rows(p)("cod_cliente")
            _desconto = rdNum(tb.Rows(p)("desconto"))
            _quantidade_contratada = rdNum(tb.Rows(p)("quantidade_contratada"))
            _preco_tabela = rdNum(tb.Rows(p)("preco_tabela"))
            _preco_desc = rdNum(tb.Rows(p)("preco_desc"))
            _cod_surf = rdNum(tb.Rows(p)("cod_surf"))
            _preco_tabela_surf = rdNum(tb.Rows(p)("preco_tabela_surf"))
            _preco_surf_desc = rdNum(tb.Rows(p)("preco_surf_desc"))
            _quantidade_surf = rdNum(tb.Rows(p)("quantidade_surf"))
            _cod_mont = rdNum(tb.Rows(p)("cod_mont"))
            _preco_tabela_mont = rdNum(tb.Rows(p)("preco_tabela_mont"))
            _preco_mont_desc = rdNum(tb.Rows(p)("preco_mont_desc"))
            _quantidade_mont = rdNum(tb.Rows(p)("quantidade_mont"))
            _cod_trat = rdNum(tb.Rows(p)("cod_trat"))
            _preco_tabela_trat = rdNum(tb.Rows(p)("preco_tabela_trat"))
            _preco_trat_desc = rdNum(tb.Rows(p)("preco_trat_desc"))
            _quantidade_trat = rdNum(tb.Rows(p)("quantidade_trat"))

        Else
            _cod_pacote = 0
            _item = 0
            _cod_tabela = 0
            _cod_filial_cliente = 0
            _cod_cliente = 0
            _desconto = 0
            _quantidade_contratada = 0
            _preco_tabela = 0
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
        'Zera Variáveis
        _cod_pacote = 0
        _cod_tabela = 0
        _cod_filial_cliente = Nothing
        _cod_cliente = Nothing
        _desconto = Nothing
        _quantidade_contratada = Nothing
        _cod_surf = Nothing
        _desc_surf = Nothing
        _cod_mont = Nothing
        _desc_mont = Nothing
        _cod_trat = Nothing
        _desc_trat = Nothing
        _preco_tabela = Nothing
        _preco_desc = Nothing
        OrigemSalvar = "Novo" 'Define o tipo de ação ao salvar
    End Function

    Public Function Salvar() As String
        Dim sql As String
        Dim res As String
        d.conecta()
        If OrigemSalvar = "Novo" Then
            Try
                _item = retorna_Chave("item", "pacote_cliente_detalhes ", " where cod_pacote = " & _cod_pacote & " and cod_cliente = " & _
                _cod_cliente & " and cod_filial_cliente = " & cod_filial_cliente)
                sql = "Insert into pacote_cliente_detalhes (cod_pacote,item,cod_tabela,cod_filial_cliente,cod_cliente,desconto" & _
                ",quantidade_contratada,cod_surf,desc_surf,cod_mont,desc_mont,cod_trat,desc_trat,preco_tabela,preco_desc, " & _
                "preco_tabela_surf,preco_surf_desc,quantidade_surf,preco_tabela_mont,preco_mont_desc,quantidade_mont,preco_tabela_trat," & _
                "preco_trat_desc,quantidade_trat,status_item,cod_pacote_ant,cod_usuario) " & _
                "Values(" & _
                _cod_pacote & "," & _item & "," & _cod_tabela & "," & _cod_filial_cliente & "," & _cod_cliente & _
                "," & d.cdin(_desconto) & "," & d.cdin(_quantidade_contratada) & _
                "," & d.cdin(_cod_surf) & "," & d.cdin(_desc_surf) & "," & _
                d.cdin(_cod_mont) & "," & d.cdin(_desc_mont) & "," & d.cdin(_cod_trat) & "," & d.cdin(_desc_trat) & _
                "," & d.cdin(_preco_tabela) & "," & d.cdin(_preco_desc) & "," & d.cdin(_preco_tabela_surf) & "," & d.cdin(_preco_surf_desc) & _
                "," & d.cdin(_quantidade_surf) & "," & d.cdin(_preco_tabela_mont) & "," & d.cdin(_preco_mont_desc) & "," & d.cdin(_quantidade_mont) & _
                "," & d.cdin(_preco_tabela_trat) & "," & d.cdin(_preco_trat_desc) & "," & d.cdin(_quantidade_trat) & _
                "," & d.PStr(_status_item) & _
                "," & _cod_pacote_ant & _
                "," & _cod_usuario & ")"
                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tb.NewRow
            r("cod_pacote") = _cod_pacote
            r("item") = _item
            r("cod_tabela") = _cod_tabela
            r("cod_filial_cliente") = _cod_filial_cliente
            r("cod_cliente") = _cod_cliente
            r("desconto") = wrNum(_desconto)
            r("quantidade_contratada") = wrNum(_quantidade_contratada)
            r("cod_surf") = wrNum(_cod_surf)
            r("desc_surf") = wrNum(_desc_surf)
            r("cod_mont") = wrNum(_cod_mont)
            r("desc_mont") = wrNum(_desc_mont)
            r("cod_trat") = wrNum(_cod_trat)
            r("desc_trat") = wrNum(_desc_trat)
            r("preco_tabela") = wrNum(_preco_tabela)
            r("preco_desc") = wrNum(_preco_desc)
            r("preco_tabela_surf") = wrNum(_preco_tabela_surf)
            r("preco_surf_desc") = wrNum(_preco_surf_desc)
            r("quantidade_surf") = wrNum(_quantidade_surf)
            r("preco_tabela_mont") = wrNum(_preco_tabela_mont)
            r("preco_mont_desc") = wrNum(_preco_mont_desc)
            r("quantidade_mont") = wrNum(_quantidade_mont)
            r("preco_tabela_trat") = wrNum(_preco_tabela_trat)
            r("preco_trat_desc") = wrNum(_preco_trat_desc)
            r("quantidade_trat") = wrNum(_quantidade_trat)
            r("status_item") = _status_item
            r("cod_pacote_ant") = _cod_pacote_ant
            r("cod_usuario") = _cod_usuario
            tb.Rows.Add(r)
            max = max + 1
            If max = 1 Then
                posicao = 0
            Else
                posicao = max - 1
            End If
            OrigemSalvar = ""
            Return res
        End If
        If Me.OrigemSalvar = "Editar" Then
            Try
                sql = "Update pacote_cliente set " & _
                "cod_tabela = " & _cod_tabela & _
                ",cod_filial_cliente = " & _cod_filial_cliente & _
                ",cod_cliente = " & _cod_cliente & _
                ",desconto = " & d.cdin(_desconto) & _
                ",quantidade_contratada = " & d.cdin(_quantidade_contratada) & _
                ",cod_surf = " & d.cdin(_cod_surf) & _
                ",desc_surf = " & d.cdin(_desc_surf) & _
                ",cod_mont = " & d.cdin(_cod_mont) & _
                ",desc_mont = " & d.cdin(_desc_mont) & _
                ",cod_trat = " & d.cdin(_cod_trat) & _
                ",desc_trat = " & d.cdin(_desc_mont) & _
                ",preco_tabela = " & d.cdin(_preco_tabela) & _
                ",preco_desc = " & d.cdin(_preco_desc) & _
                ",preco_tabela_surf = " & d.cdin(preco_tabela_surf) & _
                ",preco_surf_desc = " & d.cdin(preco_surf_desc) & _
                ",quantidade_surf = " & d.cdin(quantidade_surf) & _
                ",preco_tabela_mont = " & d.cdin(preco_tabela_mont) & _
                ",preco_mont_desc = " & d.cdin(preco_mont_desc) & _
                ",quantidade_mont = " & d.cdin(quantidade_mont) & _
                ",preco_tabela_trat = " & d.cdin(preco_tabela_trat) & _
                ",preco_trat_desc = " & d.cdin(preco_trat_desc) & _
                ",quantidade_trat = " & d.cdin(quantidade_trat) & _
                ",status_item = " & d.PStr(status_item) & _
                ",cod_pacote_ant = " & cod_pacote_ant & _
                ",cod_usuario = " & cod_usuario & _
                " where cod_pacote = " & _cod_pacote & _
                " and cod_cliente = " & _cod_cliente & _
                " and cod_filial_cliente = " & _cod_filial_cliente & _
                " and item = " & _item & ""
                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tb.Rows(posicao)
            r("cod_pacote") = _cod_pacote
            r("item") = _item
            r("cod_tabela") = _cod_tabela
            r("cod_filial_cliente") = _cod_filial_cliente
            r("cod_cliente") = _cod_cliente
            r("desconto") = wrNum(_desconto)
            r("quantidade_contratada") = wrNum(_quantidade_contratada)
            r("cod_surf") = wrNum(_cod_surf)
            r("desc_surf") = wrNum(_desc_surf)
            r("cod_mont") = wrNum(_cod_mont)
            r("desc_mont") = wrNum(_desc_mont)
            r("cod_trat") = wrNum(_cod_trat)
            r("desc_trat") = wrNum(_desc_trat)
            r("preco_tabela") = wrNum(_preco_tabela)
            r("preco_desc") = wrNum(_preco_desc)
            r("preco_tabela_surf") = wrNum(_preco_tabela_surf)
            r("preco_surf_desc") = wrNum(_preco_surf_desc)
            r("quantidade_surf") = wrNum(_quantidade_surf)
            r("preco_tabela_mont") = wrNum(_preco_tabela_mont)
            r("preco_mont_desc") = wrNum(_preco_mont_desc)
            r("quantidade_mont") = wrNum(_quantidade_mont)
            r("preco_tabela_trat") = wrNum(_preco_tabela_trat)
            r("preco_trat_desc") = wrNum(_preco_trat_desc)
            r("quantidade_trat") = wrNum(_quantidade_trat)
            r("status_item") = _status_item
            r("cod_pacote_ant") = _cod_pacote_ant
            r("cod_usuario") = _cod_usuario
            OrigemSalvar = ""
            Return "OK:" & res & " registro(s) atualizado(s) com sucesso!"
        End If
    End Function
    Public Function deletar(ByVal x_item As Integer)
        Dim res As String
        Dim sql As String
        d.conecta()
        sql = "Delete from pacote_cliente_detalhes " & _
        " where cod_pacote = " & _cod_pacote & _
        " and cod_cliente = " & _cod_cliente & _
        " and cod_filial_cliente = " & _cod_filial_cliente & _
        " and item = " & x_item & ""
        Try
            res = d.Comando(sql, True)
        Catch ex As Exception
            res = ex.ToString
        End Try
        If res.StartsWith("OK") Then
            sql = "Delete from pacote_cliente_lanc where cod_pacote = " & _cod_pacote & _
            " and cod_filial_cliente = " & _cod_filial_cliente & _
            " and cod_cliente = " & _cod_cliente & _
            " and cod_tabela = " & _cod_tabela & ""
            d.Comando(sql, True)
        End If
        refreshData()
        Return res
    End Function
    Public Function lista_itens() As DataTable
        Dim tt As New DataTable
        sql = "SELECT Pacote_cliente_detalhes.*, " & _
        "cliente.nome_cliente, lentes_tabela.nome_comercial, " & _
        "lentes_tabela.preco_venda,Pacote_cliente_detalhes.desconto, " & _
        "round((lentes_tabela.preco_venda-(lentes_tabela.preco_venda* " & _
        "(pacote_cliente_detalhes.desconto/100))),2,2) as Preco_desconto, " & _
        "(SELECT     SUM(Contratada - Utilizado) AS saldo " & _
        "FROM  saldos_pacotes(pacote_cliente_detalhes.cod_tabela ," & _
        "pacote_cliente_detalhes.cod_filial_cliente, pacote_cliente_detalhes.cod_cliente) " & _
        "AS saldos WHERE (cod_Pacote = pacote_cliente_detalhes.cod_pacote)) as Saldo, " & _
        "(Select produtos.produto from produtos where produtos.cod_produto = " & _
        "pacote_cliente_detalhes.cod_surf) as surfacagem, " & _
        "isnull(isnull((Select produtos.preco_venda from produtos where produtos.cod_produto = " & _
        "pacote_cliente_detalhes.cod_surf),0) - ( " & _
        "isnull((Select produtos.preco_venda from produtos where produtos.cod_produto = " & _
        "pacote_cliente_detalhes.cod_surf),0)*(pacote_cliente_detalhes.desc_surf/100)),0) " & _
        "as surf_desc, " & _
        "(Select produtos.produto from produtos where produtos.cod_produto = " & _
        "pacote_cliente_detalhes.cod_mont) as montagem, " & _
        "isnull(isnull((Select produtos.preco_venda from produtos where produtos.cod_produto = " & _
        "pacote_cliente_detalhes.cod_mont),0) " & _
        "- ( isnull((Select produtos.preco_venda from produtos where produtos.cod_produto = " & _
        "pacote_cliente_detalhes.cod_mont),0)*(pacote_cliente_detalhes.desc_mont/100)),0)" & _
        "as mont_desc, " & _
        "(Select produtos.produto from produtos where produtos.cod_produto = pacote_cliente_detalhes.cod_trat) as tratamento,isnull( " & _
        "isnull((Select produtos.preco_venda from produtos where produtos.cod_produto = pacote_cliente_detalhes.cod_trat),0) " & _
        "- ( isnull((Select produtos.preco_venda from produtos where produtos.cod_produto = " & _
        "pacote_cliente_detalhes.cod_trat),0)*(pacote_cliente_detalhes.desc_trat/100)),0) as trat_desc, pacote_cliente.data " & _
        "FROM  lentes_tabela INNER JOIN cliente INNER JOIN " & _
        "Pacote_cliente_detalhes ON cliente.cod_filial_cliente = Pacote_cliente_detalhes.cod_filial_cliente " & _
        "AND cliente.cod_cliente = Pacote_cliente_detalhes.cod_cliente ON " & _
        "lentes_tabela.cod_tabela = Pacote_cliente_detalhes.cod_tabela " & _
        "INNER JOIN pacote_cliente on Pacote_cliente_detalhes.cod_Pacote = pacote_cliente.cod_Pacote " & _
        "where pacote_cliente_detalhes.cod_cliente = " & Me._cod_cliente & _
        " and pacote_cliente_detalhes.cod_filial_cliente = " & Me._cod_filial_cliente & _
        " and pacote_cliente_detalhes.cod_pacote = " & Me._cod_pacote & " order by item"
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function lista_item(ByVal xCodTabela As Integer) As DataTable
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT * FROM lista_pacote_cliente(" & Me._cod_cliente & _
        "," & Me._cod_filial_cliente & "," & Me._cod_pacote & ") AS lista_pacote " & _
        " WHERE (cod_tabela = " & xCodTabela & ") "
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function lista_itens_com_saldo(ByVal x_tabela As Integer) As DataTable
        Dim tt As New DataTable
        sql = "SELECT Pacote_cliente_detalhes.*, " & _
        "cliente.nome_cliente, lentes_tabela.nome_comercial, " & _
        "lentes_tabela.preco_venda,Pacote_cliente_detalhes.desconto, " & _
        "(lentes_tabela.preco_venda-(lentes_tabela.preco_venda* " & _
        "(pacote_cliente_detalhes.desconto/100))) as Preco_desconto, " & _
        "(SELECT     SUM(Contratada - Utilizado) AS saldo " & _
        "FROM  saldos_pacotes(pacote_cliente_detalhes.cod_tabela ," & _
        "pacote_cliente_detalhes.cod_filial_cliente, pacote_cliente_detalhes.cod_cliente) " & _
        "AS saldos WHERE (cod_Pacote = pacote_cliente_detalhes.cod_pacote)) as Saldo " & _
        "FROM  lentes_tabela INNER JOIN cliente INNER JOIN " & _
        "Pacote_cliente_detalhes ON cliente.cod_filial_cliente = Pacote_cliente_detalhes.cod_filial_cliente " & _
        "AND cliente.cod_cliente = Pacote_cliente_detalhes.cod_cliente ON " & _
        "lentes_tabela.cod_tabela = Pacote_cliente_detalhes.cod_tabela " & _
        "where pacote_cliente_detalhes.cod_cliente = " & Me._cod_cliente & _
        " and pacote_cliente_detalhes.cod_filial_cliente = " & Me._cod_filial_cliente & _
        " and pacote_cliente_detalhes.cod_tabela = " & x_tabela & _
        " and (SELECT     SUM(Contratada - Utilizado) AS saldo " & _
        "FROM  saldos_pacotes(pacote_cliente_detalhes.cod_tabela ," & _
        "pacote_cliente_detalhes.cod_filial_cliente, pacote_cliente_detalhes.cod_cliente) " & _
        "AS saldos WHERE (cod_Pacote = pacote_cliente_detalhes.cod_pacote)) > 0 " & _
        "and Pacote_cliente_detalhes.status_item  = 'L' " & _
        "order by pacote_cliente_detalhes.cod_pacote"
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function saldo_disponivel(ByVal x_cod_tabela As Integer) As Integer
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT     SUM(Contratada - Utilizado) AS saldo " & _
        "FROM saldos_pacotes(" & x_cod_tabela & "," & _cod_filial_cliente & "," & _cod_cliente & ") AS saldos_pacotes_1 " & _
        "WHERE  (cod_Pacote = " & _cod_pacote & ")"
        d.carrega_Tabela(sql, tt)
        Return tt.Rows(0)(0)
    End Function
#End Region
End Class
