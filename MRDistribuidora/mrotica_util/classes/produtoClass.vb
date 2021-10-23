Public Class produtoClass
#Region "Atributos"
    Private _cod_produto As String
    Private _cod_grupo As Integer
    Private _id_fabricante As Integer
    Private _cod_lente As Object
    Private _produto As String
    Private _und As String
    Private _min_Estoque As Object
    Private _max_estoque As Object
    Private _preco_custo As Object
    Private _preco_venda As Object
    Private _desconto As Object
    Private _cod_barra As String
    Private _obs As String
    Private _estoque As Integer
    Private _preco_compra As Object
    Private _desconto_compra As Object
    Private _fator_preco As Object
    Private _preco_tabela As Object
    Public posicao As Integer = 0
    Public max As Integer
    Public chaveCriterio As Object
    Private tb As New DataTable
    Public OrigemSalvar As String = ""
    Private lastPos As Integer = 0
    Private sql As String
    Public Enum tiposalvar
        Normal = 1
        Transaction = 2
    End Enum
    Dim d As New dados
#End Region

#Region "GET SET"
    Public Property fldCod_produto()
        Get
            fldCod_produto = _cod_produto
        End Get
        Set(ByVal Value)
            _cod_produto = Value
        End Set
    End Property
    Public Property Cod_lente()
        Get
            Cod_lente = _cod_lente
        End Get
        Set(ByVal Value)
            _cod_lente = Value
        End Set
    End Property
    Public Property estoque()
        Get
            estoque = _estoque
        End Get
        Set(ByVal Value)
            _estoque = Value
        End Set
    End Property
    Public Property fldcod_grupo()
        Get
            fldcod_grupo = _cod_grupo
        End Get
        Set(ByVal Value)
            _cod_grupo = Value
        End Set
    End Property
    Public Property fldProduto()
        Get
            fldProduto = _produto
        End Get
        Set(ByVal Value)
            _produto = Value
        End Set
    End Property
    Public Property fldUnd()
        Get
            fldUnd = _und
        End Get
        Set(ByVal Value)
            _und = Value
        End Set
    End Property
    Public Property fldMin_estoque()
        Get
            fldMin_estoque = _min_Estoque
        End Get
        Set(ByVal Value)
            If Value = "" Then Value = 0
            _min_Estoque = Value
        End Set
    End Property
    Public Property fldMax_estoque()
        Get
            fldMax_estoque = _max_estoque
        End Get
        Set(ByVal Value)
            If Value = "" Then Value = 0
            _max_estoque = Value
        End Set
    End Property
    Public Property fld_id_fabricante()
        Get
            fld_id_fabricante = _id_fabricante
        End Get
        Set(ByVal Value)
            _id_fabricante = Value
        End Set
    End Property
    Public Property fldPreco_custo()
        Get
            fldPreco_custo = _preco_custo
        End Get
        Set(ByVal Value)
            _preco_custo = Value
        End Set
    End Property
    Public Property fldPreco_venda()
        Get
            fldPreco_venda = _preco_venda
        End Get
        Set(ByVal Value)
            If Value = "" Then Value = 0
            _preco_venda = Value
        End Set
    End Property
    Public ReadOnly Property Preco_venda()
        Get
            Preco_venda = _preco_venda * _fator_preco
        End Get
    End Property
    Public Property fator_preco()
        Get
            fator_preco = _fator_preco
        End Get
        Set(ByVal Value)
            If Value = Nothing Then Value = 0
            _fator_preco = Value
        End Set
    End Property
    Public Property fldDesconto()
        Get
            fldDesconto = _desconto
        End Get
        Set(ByVal Value)
            If Value = "" Then Value = 0
            Value = cdin(Value)
            _desconto = Value
        End Set
    End Property
    Public Property Preco_compra()
        Get
            Preco_compra = _preco_compra
        End Get
        Set(ByVal Value)
            If Value = "" Then Value = 0
            _preco_compra = Value
        End Set
    End Property
    Public Property Desconto_compra()
        Get
            Desconto_compra = _desconto_compra
        End Get
        Set(ByVal Value)
            If Value = "" Then Value = 0
            Value = cdin(Value)
            _desconto_compra = Value
        End Set
    End Property
    Public Property preco_tabela
        Get
            preco_tabela = _preco_tabela
        End Get
        Set(value)
            If value = "" Then value = 0
            _preco_tabela = value
        End Set
    End Property
    Public Property fldCod_barra()
        Get
            fldCod_barra = _cod_barra
        End Get
        Set(ByVal Value)
            _cod_barra = Value
        End Set
    End Property
    Public Property fldObs()
        Get
            fldObs = _obs
        End Get
        Set(ByVal Value)
            _obs = Value
        End Set
    End Property
#End Region
#Region "Procedimentos"
    Public Sub New()
        Source("Select * from produtos where cod_produto = 0")
    End Sub
    Public Sub New(ByVal xdados As dados)
        d = xdados
        Source("Select * from produtos where cod_produto = 0")
    End Sub
    Public Sub filtra(ByVal x_cod_produto As Integer)
        Source("Select * from produtos where cod_produto = " & x_cod_produto & "")
    End Sub
    Public Sub filtraBarras(ByVal x_barras As Long)
        Source("Select * from produtos where cod_barra = " & x_barras & "")
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
            _cod_produto = tb.Rows(p)("cod_produto")
            _cod_grupo = tb.Rows(p)("cod_grupo")
            _id_fabricante = tb.Rows(p)("id_fabricante")
            _cod_lente = rdNum(tb.Rows(p)("cod_lente"))
            _produto = rdTexto(tb.Rows(p)("Produto"))
            _und = rdTexto(tb.Rows(p)("unidade"))
            _min_Estoque = rdNum(tb.Rows(p)("min_estoque"))
            _max_estoque = rdNum(tb.Rows(p)("Max_estoque"))
            _preco_custo = rdNum(tb.Rows(p)("preco_custo"))
            _preco_venda = rdNum(tb.Rows(p)("preco_venda"))
            _preco_tabela = rdNum(tb.Rows(p)("preco_tabela"))
            _desconto = rdNum(tb.Rows(p)("desconto"))
            _cod_barra = rdNum(tb.Rows(p)("cod_barra"))
            _obs = rdTexto(tb.Rows(p)("observacao"))
            _estoque = rdNum(tb.Rows(p)("estoque"))
            _preco_compra = rdNum(tb.Rows(p)("preco_compra"))
            _desconto_compra = rdNum(tb.Rows(p)("desconto_compra"))
            _fator_preco = rdNum(tb.Rows(p)("fator_preco"))
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
        _cod_produto = chave()
        _cod_grupo = Nothing
        _produto = ""
        _cod_lente = Nothing
        _und = ""
        _min_Estoque = Nothing
        _max_estoque = Nothing
        _id_fabricante = Nothing
        _preco_custo = 0
        _preco_venda = 0
        _preco_tabela = 0
        _preco_compra = 0
        _desconto_compra = 0
        _desconto = 0
        _cod_barra = Nothing
        _obs = ""
        _estoque = 1
        _fator_preco = 1
        OrigemSalvar = "Novo" 'Define o tipo de ação ao salvar
    End Function

    Public Function Salvar(ByVal tipo As tiposalvar) As String
        Dim cmd As New SqlClient.SqlCommand
        Dim sql As String
        Dim res As String
        d.conecta()
        cmd.Connection = d.con
        If OrigemSalvar = "Novo" Then
            Try
                '_cod_produto = chave()
                sql = "Insert into produtos(cod_produto,cod_lente,cod_grupo,Produto,unidade," &
                "min_estoque,max_estoque,id_fabricante,preco_custo,preco_venda,preco_tabela,desconto," &
                "cod_barra,observacao,estoque,preco_compra,desconto_compra,fator_preco) Values(" &
                d.PStr(_cod_produto) & "," & cdin(_cod_lente) & "," & _cod_grupo & "," & d.PStr(_produto) & "," &
                d.PStr(_und) & "," & d.cdin(_min_Estoque) & "," & d.cdin(_max_estoque) & "," & _id_fabricante & "," &
                d.cdin(_preco_custo) & "," & d.cdin(_preco_venda) & "," & d.cdin(_preco_tabela) & "," & d.cdin(_desconto) & "," &
                d.cdin(_cod_barra) & "," & d.PStr(_obs) & "," & d.cdin(_estoque) &
                "," & d.cdin(_preco_compra) & "," & d.cdin(_desconto_compra) &
                "," & d.cdin(_fator_preco) & ")"
                If tipo = tiposalvar.Normal Then
                    res = d.Comando(sql, True)
                Else
                    res = sql
                End If
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tb.NewRow
            r("cod_produto") = _cod_produto
            r("estoque") = _estoque
            r("cod_lente") = wrNum(_cod_lente)
            r("cod_grupo") = _cod_grupo
            r("produto") = rdTexto(_produto)
            r("unidade") = rdTexto(_und)
            r("min_Estoque") = wrNum(_min_Estoque)
            r("max_estoque") = wrNum(_max_estoque)
            r("id_fabricante") = wrNum(_id_fabricante)
            r("preco_custo") = wrNum(_preco_custo)
            r("preco_venda") = wrNum(_preco_venda)
            r("preco_tabela") = wrNum(_preco_tabela)
            r("desconto") = wrNum(_desconto)
            r("cod_barra") = wrNum(_cod_barra)
            r("observacao") = rdTexto(_obs)
            r("preco_compra") = wrNum(_preco_compra)
            r("desconto") = wrNum(_desconto)
            r("fator_preco") = wrNum(_fator_preco)
            tb.Rows.Add(r)
            max = max + 1
            If max = 1 Then
                posicao = 0
            Else
                posicao = max - 1
            End If
            OrigemSalvar = ""
        End If

        If Me.OrigemSalvar = "Editar" Then
            Try
                sql = "Update produtos set " &
                "cod_lente = " & d.cdin(_cod_lente) & ",cod_grupo = " & d.cdin(_cod_grupo) & "," &
                "Produto = " & d.PStr(_produto) & ",unidade = " & d.PStr(_und) & "," &
                "min_estoque = " & d.cdin(_min_Estoque) & ",max_estoque = " & d.cdin(_max_estoque) & "," &
                "id_fabricante = " & d.cdin(_id_fabricante) & ",preco_venda = " & d.cdin(_preco_venda) &
                ",preco_tabela = " & d.cdin(_preco_tabela) & ",preco_custo = " & d.cdin(_preco_custo) &
                ",desconto = " & d.cdin(_desconto) & ",cod_barra = " & d.cdin(_cod_barra) & ",observacao = " &
                d.PStr(_obs) & ", estoque = " & d.cdin(_estoque) &
                ",preco_compra =" & d.cdin(_preco_compra) &
                ",desconto_compra=" & d.cdin(_desconto_compra) &
                ",fator_preco = " & d.cdin(_fator_preco) &
                " Where cod_produto = " & _cod_produto & ""
                If tipo = tiposalvar.Normal Then
                    res = d.Comando(sql, True)
                Else
                    res = sql
                End If
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tb.Rows(posicao)
            r("estoque") = _estoque
            r("cod_lente") = wrNum(_cod_lente)
            r("cod_grupo") = _cod_grupo
            r("produto") = rdTexto(_produto)
            r("unidade") = rdTexto(_und)
            r("min_Estoque") = wrNum(_min_Estoque)
            r("max_estoque") = wrNum(_max_estoque)
            r("id_fabricante") = wrNum(_id_fabricante)
            r("preco_custo") = wrNum(_preco_custo)
            r("preco_venda") = wrNum(_preco_venda)
            r("preco_tabela") = wrNum(_preco_tabela)
            r("desconto") = wrNum(_desconto)
            r("cod_barra") = wrNum(_cod_barra)
            r("observacao") = rdTexto(_obs)
            r("preco_compra") = wrNum(_preco_compra)
            r("desconto") = wrNum(_desconto)
            r("fator_preco") = wrNum(_fator_preco)
            OrigemSalvar = ""
        End If
        Return res
    End Function

    Public Function deletar(ByVal id As String, ByVal tipo As tiposalvar) As String
        Dim sql As String
        Dim res As String
        d.conecta()
        sql = "Delete from produtos where cod_produto = " & id & ""
        Try
            res = d.Comando(sql, True)
        Catch ex As Exception
            res = "ER:" & ex.Message
        End Try
        Me.refreshData()
        Me.primeiro()
        Return res
    End Function

    Public Function chave()
        Return retorna_Chave("cod_produto", "produtos", "")
    End Function

    Public Function Consultar_produtos(ByVal nome1 As String) As Data.DataTable
        Dim tbProd As New DataTable
        Dim sql As String
        nome1 = nome1.Replace(" ", "%")
        sql = "Select  produto,id_fabricante, cod_lente,cod_produto " & _
              "FROM produtos WHERE produto LIKE '%" & nome1 & "%'"
        d.carrega_Tabela(sql, tbProd)
        Return tbProd
        tbProd.Dispose()
    End Function

    Public Function Consultar_produtos_nTabela(ByVal nome_tabela As String) As Data.DataTable
        Dim tbProd As New DataTable
        Dim sql As String
        nome_tabela = nome_tabela.Replace(" ", "%")
        sql = "SELECT produtos.produto, lentes_tabela.nome_comercial, " &
        "lentes_tabela.id_fabricante, produtos.cod_lente, produtos.cod_produto " &
        "FROM  produtos INNER JOIN lentes_blocos ON produtos.cod_lente = " &
        "lentes_blocos.cod_lente AND produtos.id_fabricante = lentes_blocos.id_fabricante " &
        "INNER JOIN lentes_tabela ON lentes_blocos.cod_tabela = lentes_tabela.cod_tabela " &
        "WHERE (lentes_tabela.nome_comercial LIKE '%" & nome_tabela & "%')"
        d.carrega_Tabela(sql, tbProd)
        Return tbProd
        tbProd.Dispose()
    End Function

    Public Function ConsultarProdutoDescricao(ByVal descricaoproduto As String, ByVal telaPesquisa As String) As Data.DataTable
        Dim tbProd As New DataTable
        Dim sql As String = ""
        descricaoproduto = descricaoproduto.Replace(" ", "%")
        If telaPesquisa = "Consultar Produto" Then
            sql = "SELECT produtos.produto, lentes_tabela.nome_comercial, " &
            "lentes_tabela.id_fabricante, produtos.cod_lente, produtos.cod_produto, lentes_blocos.nome_lente " &
            "FROM  produtos INNER JOIN lentes_blocos ON produtos.cod_lente = " &
            "lentes_blocos.cod_lente AND produtos.id_fabricante = lentes_blocos.id_fabricante " &
            "INNER JOIN lentes_tabela ON lentes_blocos.cod_tabela = lentes_tabela.cod_tabela " &
            "WHERE (lentes_tabela.nome_comercial LIKE '%" & descricaoproduto & "%') or " &
            "(produtos.produto LIKE '%" & descricaoproduto & "%') order by produtos.produto"
        ElseIf telaPesquisa = "Localizar Produto" Then
            sql = "SELECT lt.nome_comercial, lt.id_fabricante, lb.cod_lente, lb.nome_lente FROM " &
            "lentes_blocos lb INNER JOIN  lentes_tabela lt ON lb.cod_tabela = lt.cod_tabela " &
            "WHERE (lt.nome_comercial LIKE '%" & descricaoproduto & "%') " &
            "group by lb.nome_lente, lt.nome_comercial, lt.id_fabricante, lb.cod_lente"
        End If

        d.carrega_Tabela(sql, tbProd)
        Return tbProd
        tbProd.Dispose()
    End Function

    Public Function ConsultarProdutoTabela(ByVal codigotabela As Integer, ByVal telaPesquisa As String) As Data.DataTable
        Dim tbProd As New DataTable
        Dim sql As String = ""
        If telaPesquisa = "Consultar Produto" Then
            sql = " SELECT produtos.produto, lentes_tabela.nome_comercial, " &
            "lentes_tabela.id_fabricante, produtos.cod_lente, produtos.cod_produto, lentes_blocos.nome_lente " &
            "FROM  produtos INNER JOIN lentes_blocos ON produtos.cod_lente = " &
            "lentes_blocos.cod_lente AND produtos.id_fabricante = lentes_blocos.id_fabricante " &
            "INNER JOIN lentes_tabela ON lentes_blocos.cod_tabela = lentes_tabela.cod_tabela " &
            "WHERE (lentes_tabela.cod_tabela = " & codigotabela & ")"
        ElseIf telaPesquisa = "Localizar Produto" Then
            sql = "SELECT lt.nome_comercial, lt.id_fabricante, lb.cod_lente, lb.nome_lente FROM " &
            "lentes_blocos lb INNER JOIN  lentes_tabela lt ON lb.cod_tabela = lt.cod_tabela " &
            "WHERE (lt.cod_tabela = " & codigotabela & ")"
        End If

        d.carrega_Tabela(sql, tbProd)
        Return tbProd
        tbProd.Dispose()
    End Function

    Public Function Consultar_produtos_barra(ByVal barra As String) As Data.DataTable
        Dim tbProd As New DataTable
        Dim sql As String
        Try
            If IsNumeric(barra) Then
                barra = CDbl(barra)
            End If
            sql = "Select produto,id_fabricante, cod_lente,cod_produto " &
                          "FROM produtos WHERE cod_barra = '" & barra & "'"
            d.carrega_Tabela(sql, tbProd)
            Return tbProd
            tbProd.Dispose()
        Catch ex As Exception

        End Try
    End Function

    Public Function Retorna_nome_prod(ByVal cod_prod As Integer) As String
        Dim tb As New DataTable
        Dim sql As String
        sql = "Select produto from produtos where cod_produto = " & cod_prod & ""
        d.carrega_Tabela(sql, tb)
        If tb.Rows.Count = 1 Then
            Return tb.Rows(0)("produto")
        Else
            Return 0
        End If
    End Function

    Public Function Retorna_nome_Tabela(ByVal cod_prod As Integer) As String
        Dim tb As New DataTable
        Dim sql As String
        sql = "SELECT lentes_tabela.nome_comercial " & _
        "FROM produtos INNER JOIN " & _
        "lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente " & _
        "AND produtos.id_fabricante = lentes_blocos.id_fabricante INNER JOIN " & _
        "lentes_tabela ON lentes_blocos.cod_tabela = lentes_tabela.cod_tabela " & _
        "WHERE (produtos.cod_produto =" & cod_prod & ")"
        d.carrega_Tabela(sql, tb)
        If tb.Rows.Count = 1 Then
            Return tb.Rows(0)("nome_comercial")
        Else
            Return 0
        End If
    End Function

    Public Function Retorna_cod_Tabela(ByVal cod_prod As Integer) As String
        Dim tb As New DataTable
        Dim sql As String
        sql = "SELECT lentes_tabela.cod_Tabela " & _
        "FROM produtos INNER JOIN " & _
        "lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente " & _
        "AND produtos.id_fabricante = lentes_blocos.id_fabricante INNER JOIN " & _
        "lentes_tabela ON lentes_blocos.cod_tabela = lentes_tabela.cod_tabela " & _
        "WHERE (produtos.cod_produto =" & cod_prod & ")"
        d.carrega_Tabela(sql, tb)
        If tb.Rows.Count = 1 Then
            Return tb.Rows(0)("cod_tabela")
        Else
            Return 0
        End If
    End Function

    Public Function retorna_especie(ByVal x_cod_prod As Integer) As String
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT lentes_tabela.cod_tabela, lentes_tabela.especie " & _
        "FROM produtos INNER JOIN lentes_blocos ON produtos.cod_lente = " & _
        "lentes_blocos.cod_lente AND produtos.id_fabricante = " & _
        "lentes_blocos.id_fabricante INNER JOIN " & _
        "lentes_tabela ON lentes_blocos.cod_tabela = lentes_tabela.cod_tabela " & _
        "WHERE     (produtos.cod_produto = " & x_cod_prod & ")"
        d.carrega_Tabela(sql, tt)
        Try
            Return tt.Rows(0)("especie")
        Catch ex As Exception

        End Try
    End Function

    Public Function ret_especie(ByVal x_cod_tabela As Integer) As String
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT lentes_tabela.especie " & _
        "FROM lentes_tabela " & _
        " WHERE (cod_tabela = " & x_cod_tabela & ")"
        d.carrega_Tabela(sql, tt)
        Try
            Return tt.Rows(0)("especie")
        Catch ex As Exception

        End Try
    End Function

    Public Function Retorna_especie_Tabela(ByVal cod_prod As Integer) As String
        Dim tb As New DataTable
        Dim sql As String
        sql = "SELECT lentes_tabela.especie " & _
        "FROM produtos INNER JOIN " & _
        "lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente " & _
        "AND produtos.id_fabricante = lentes_blocos.id_fabricante INNER JOIN " & _
        "lentes_tabela ON lentes_blocos.cod_tabela = lentes_tabela.cod_tabela " & _
        "WHERE (produtos.cod_produto =" & cod_prod & ")"
        d.carrega_Tabela(sql, tb)
        If tb.Rows.Count = 1 Then
            Return tb.Rows(0)("especie").ToString.Trim
        Else
            Return 0
        End If
    End Function

    Public Function Retorna_cod_prod(ByVal x_cod_barras As String) As String
        Dim tbx As New DataTable
        Dim tsql As String
        tsql = "Select cod_produto from produtos where cod_barra = " & d.PStr(x_cod_barras)
        d.carrega_Tabela(tsql, tbx)
        If tbx.Rows.Count = 1 Then
            Return tbx.Rows(0)("cod_produto")
        Else
            Return 0
        End If
    End Function

    Public Function Retorna_cod_prod(ByVal x_cod_tabela As Integer, ByVal x_adicao As Double _
    , ByVal x_base As Double, ByVal x_olho As String) As String
        Dim tbx As New DataTable
        Dim tsql As String
        tsql = "SELECT produtos.cod_produto FROM produtos INNER JOIN " & _
        "lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente " & _
        "AND produtos.id_fabricante = lentes_blocos.id_fabricante INNER JOIN " & _
        "blocos ON produtos.cod_produto = blocos.Cod_produto " & _
        "WHERE  (blocos.Base_nominal =" & d.cdin(x_base) & ") AND (blocos.Adicao = " & _
         cdin(x_adicao) & ") AND (blocos.olho = " & d.PStr(x_olho) & ") AND " & _
         "(lentes_blocos.cod_tabela = " & x_cod_tabela & ")"
        d.carrega_Tabela(tsql, tbx)
        If tbx.Rows.Count = 1 Then
            Return tbx.Rows(0)("cod_produto")
        Else
            Return 0
        End If
    End Function

    'Atualiza o nome da Lente/Bloco no cadastro de Produtos
    Public Function atualizar_nome(ByVal nome As String, ByVal tipo As String, ByVal fab As Integer, ByVal lente As Integer)
        Dim nFinal As String 'nome Final
        Dim tb As New DataTable 'Tabela para Registros a serem alterados
        Dim tsql As String 'Instrução para produtos source de itens que serão alterados
        Dim i As Integer = 0 'Contador
        'Se tipo "B"-Bloco
        If tipo = "B" Then
            tsql = "SELECT blocos.cod_produto,blocos.Base_nominal, blocos.Adicao, blocos.olho, produtos.cod_lente " & _
            "FROM blocos INNER JOIN produtos ON blocos.Cod_produto = produtos.cod_produto " & _
            "WHERE (produtos.id_fabricante =" & fab & ") AND (produtos.cod_lente = " & lente & ")"
            d.carrega_Tabela(tsql, tb)
            'Para cada registro na Tabela, gera o nome e atualiza na tabela de produtos
            While i < tb.Rows.Count
                nFinal = nome & " Base " & tb.Rows(i)("base_nominal") & " Adição " & _
                tb.Rows(i)("adicao") & " Olho " & tb.Rows(i)("olho")
                atualiza_nome(nFinal, tb.Rows(i)("cod_produto"))
                i = i + 1
            End While
        ElseIf tipo = "BS" Then
            tsql = "SELECT  produtos.cod_lente, bloco_surfacado.Base_nominal, bloco_surfacado.Adicao, " & _
            "bloco_surfacado.olho, bloco_surfacado.cod_produto, bloco_surfacado.esf as esferico, " & _
            "bloco_surfacado.cil as cilindrico FROM produtos INNER JOIN " & _
            "bloco_surfacado ON produtos.cod_produto = bloco_surfacado.cod_produto " & _
            " WHERE (produtos.id_fabricante = " & fab & ") AND (produtos.cod_lente = " & lente & ")"
            d.carrega_Tabela(tsql, tb)
            'Para cada registro na Tabela, gera o nome e atualiza na tabela de produtos
            Dim esf As String
            Dim cil As String

            While i < tb.Rows.Count
                If rdNum(tb.Rows(i)("esferico")) > 0 Then
                    esf = "+" & FormatNumber(rdNum(tb.Rows(i)("esferico")), 2, TriState.True, TriState.False, TriState.True)
                Else
                    esf = FormatNumber(rdNum(tb.Rows(i)("esferico")), 2, TriState.True, TriState.False, TriState.True)
                End If
                cil = FormatNumber(rdNum(tb.Rows(i)("cilindrico")), 2, TriState.True, TriState.False, TriState.True)
                nFinal = nome & " Base " & tb.Rows(i)("base_nominal") & " Adição " & _
               tb.Rows(i)("adicao") & " Olho " & tb.Rows(i)("olho")
                nFinal = nFinal & " " & esf & " com " & cil
                atualiza_nome(nFinal, tb.Rows(i)("cod_produto"))
                i = i + 1
            End While
        ElseIf tipo = "L" Then
            tsql = "SELECT  produtos.cod_lente, lentes.cod_produto, lentes.esferico, " & _
              "lentes.cilindrico FROM produtos INNER JOIN " & _
              "lentes ON produtos.cod_produto = lentes.cod_produto " & _
              " WHERE (produtos.id_fabricante = " & fab & ") AND (produtos.cod_lente = " & lente & ")"
            d.carrega_Tabela(tsql, tb)
            'Para cada registro na Tabela, gera o nome e atualiza na tabela de produtos
            Dim esf As String
            Dim cil As String

            While i < tb.Rows.Count
                If rdNum(tb.Rows(i)("esferico")) > 0 Then
                    esf = "+" & FormatNumber(rdNum(tb.Rows(i)("esferico")), 2, TriState.True, TriState.False, TriState.True)
                Else
                    esf = FormatNumber(rdNum(tb.Rows(i)("esferico")), 2, TriState.True, TriState.False, TriState.True)
                End If
                cil = FormatNumber(rdNum(tb.Rows(i)("cilindrico")), 2, TriState.True, TriState.False, TriState.True)
                nFinal = nome & " " & esf & " com " & cil
                atualiza_nome(nFinal, tb.Rows(i)("cod_produto"))
                i = i + 1
            End While
        Else
            tsql = "SELECT  produtos.cod_lente, lente_contato.cod_produto, lente_contato.esf, " & _
              "lente_contato.cil, lente_contato.base FROM produtos INNER JOIN " & _
              "lente_contato ON produtos.cod_produto = lente_contato.cod_produto " & _
              " WHERE (produtos.id_fabricante = " & fab & ") AND (produtos.cod_lente = " & lente & ")"
            d.carrega_Tabela(tsql, tb)
            'Para cada registro na Tabela, gera o nome e atualiza na tabela de produtos
            Dim esf As String
            Dim cil As String
            Dim base As String
            While i < tb.Rows.Count
                If rdNum(tb.Rows(i)("esf")) > 0 Then
                    esf = "+" & FormatNumber(rdNum(tb.Rows(i)("esf")), 2, TriState.True, TriState.False, TriState.True)
                Else
                    esf = FormatNumber(rdNum(tb.Rows(i)("esf")), 2, TriState.True, TriState.False, TriState.True)
                End If
                If rdNum(tb.Rows(i)("cil")) <> 0 Then
                    cil = " com " & FormatNumber(rdNum(tb.Rows(i)("cil")), 2, TriState.True, TriState.False, TriState.True).ToString
                Else
                    cil = ""
                End If
                base = FormatNumber(rdNum(tb.Rows(i)("base")), 2, TriState.True, TriState.False, TriState.True)
                nFinal = nome & " " & base & " " & esf & " " & cil
                atualiza_nome(nFinal, tb.Rows(i)("cod_produto"))
                i = i + 1
            End While
        End If
    End Function

    Private Sub atualiza_nome(ByVal nome As String, ByVal cod_prod As Integer)
        Dim tsql As String
        tsql = "update produtos set produto = " & d.PStr(nome) & _
        " where cod_produto = " & cod_prod & ""
        d.Comando(tsql, True)
    End Sub

    Public Function nome_lente_contato(ByVal nome As String, ByVal base As String, ByVal esf As String, ByVal cil As String) As String
        If rdNum(esf) > 0 Then
            esf = "+" & FormatNumber(rdNum(esf), 2, TriState.True, TriState.False, TriState.True)
        Else
            esf = FormatNumber(rdNum(esf), 2, TriState.True, TriState.False, TriState.True)
        End If
        If rdNum(cil) <> 0 Then
            cil = " com " & FormatNumber(rdNum(cil), 2, TriState.True, TriState.False, TriState.True).ToString
        Else
            cil = ""
        End If
        base = FormatNumber(rdNum(base), 2, TriState.True, TriState.False, TriState.True).ToString
        Return (nome & " " & base & " " & esf & " " & cil).Trim
    End Function

    Public Function ret_saldo_fisico(ByVal cod_prod As Integer, filial As Integer) As Double
        Dim tb As New DataTable
        Dim tsql As String
        Dim saldo As Double = 0
        tsql = "select sum(movimento.quant) as saldo from movimento where movimento.cod_produto = " & cod_prod & _
        " and movimento.id_filial = " & filial & ""
        d.carrega_Tabela(tsql, tb)
        Try
            saldo = rdNum(tb.Rows(0)("saldo"))
        Catch ex As Exception
            Return saldo
        End Try
        Return saldo
    End Function

    Public Function ret_saldo_fin(ByVal cod_prod As Integer, filial As Integer) As Double
        Dim tb As Data.DataTable
        Dim tsql As String
        Dim saldo As Double = 0
        tsql = "select sum((movimento.quant * (movimento.pUnit - movimento.desconto))) as saldo from movimento where movimento.cod_produto = " & cod_prod & _
        " and movimento.id_filial = " & filial & ""
        d.carrega_Tabela(tsql, tb)
        Try
            saldo = rdNum(tb.Rows(0)("saldo"))
        Catch ex As Exception

        End Try
        Return saldo
    End Function

    Public Function ret_saldo_todos_fisico(ByVal cod_prod As Integer) As Double
        Dim tb As New DataTable
        Dim tsql As String
        Dim saldo As Double = 0
        tsql = "select sum(movimento.quant) as saldo from movimento where movimento.cod_produto = " & cod_prod & ""
        d.carrega_Tabela(tsql, tb)
        Try
            saldo = rdNum(tb.Rows(0)("saldo"))
        Catch ex As Exception
            Return saldo
        End Try
        Return saldo
    End Function

    Public Function ret_saldo_todos_fin(ByVal cod_prod As Integer) As Double
        Dim tb As Data.DataTable
        Dim tsql As String
        Dim saldo As Double = 0
        tsql = "select sum((movimento.quant * (movimento.pUnit - movimento.desconto))) as saldo from movimento where movimento.cod_produto = " & cod_prod & ""
        d.carrega_Tabela(tsql, tb)
        Try
            saldo = rdNum(tb.Rows(0)("saldo"))
        Catch ex As Exception

        End Try
        Return saldo
    End Function

    Public Function saldo_estoque_local(ByVal x_cod_prod As Integer, ByVal x_id_filial As Integer) As Integer
        Dim tsql As String
        Dim tb_saldo As New DataTable
        Dim saldo As Integer
        'Se o Banco de dados for local consulta estoque local
        tsql = "SELECT produtos.cod_produto, movimento.id_filial, " & _
        "(SUM(movimento.quant) - ((SELECT     COUNT(cod_produto) AS r_lente " & _
        "FROM reserva_lente_os " & _
        " WHERE (id_status_reserva = 0) AND (cod_produto = produtos.cod_produto) " & _
        " and (id_filial = movimento.id_filial)) + (SELECT     COUNT(cod_produto) " & _
        " AS r_lente FROM reserva_lente_pedido " & _
        " WHERE (id_status_reserva = 0) And (cod_produto = produtos.cod_produto) " & _
        " and (id_filial = movimento.id_filial)))) AS Saldo " & _
        " FROM movimento INNER JOIN " & _
        " produtos ON movimento.cod_produto = produtos.cod_produto " & _
        " WHERE (produtos.cod_produto = " & x_cod_prod & ") and " & _
        " (movimento.id_filial = " & x_id_filial & ")" & _
        " GROUP BY produtos.cod_produto,movimento.id_filial"
        d.carrega_Tabela(tsql, tb_saldo)
        If tb_saldo.Rows.Count = 0 Then
            saldo = 0
        Else
            saldo = tb_saldo.Rows(0)("Saldo")
        End If
        Return saldo
        tb_saldo.Dispose()
    End Function

    Public Function desconto(ByVal x_cod_cliente As Integer, ByVal x_filial_cliente As Integer) As Double
        Dim tsql As String
        Dim tt As New DataTable
        Dim desc As Double
        Dim cliente As New objCliente
        cliente.filtra_cod(x_cod_cliente)

        desc = desconto_promo(Retorna_cod_Tabela(_cod_produto), Now.Date, Now.Date, x_filial_cliente, x_cod_cliente)
        If desc = 0 Then
            If cliente.sem_desconto = True Then
                Return 0
            Else
                Return _desconto
            End If
        Else
            Return desc
        End If
    End Function

    Public Function desconto_promo(ByVal x_cod_tabela As Integer, ByVal xdi As Date, ByVal xdf As Date, ByVal x_Fil_cliente As Integer, ByVal x_cod_cliente As Integer) As Double
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "SELECT tabela_promocional_itens.desconto " & _
        "FROM tabela_promocional INNER JOIN tabela_promocional_clientes ON " & _
        "tabela_promocional.cod_tabela_promocional = tabela_promocional_clientes.cod_tabela_promocional AND " & _
        "tabela_promocional.id_filial = tabela_promocional_clientes.id_filial INNER JOIN " & _
        "tabela_promocional_itens ON tabela_promocional.cod_tabela_promocional = " & _
        "tabela_promocional_itens.cod_tabela_promocional AND " & _
        "tabela_promocional.id_filial = tabela_promocional_itens.id_filial " & _
        "WHERE (tabela_promocional_clientes.cod_cliente = " & x_cod_cliente & ") AND " & _
        "(tabela_promocional_clientes.cod_filial_cliente = " & x_Fil_cliente & ") AND " & _
        "(tabela_promocional.data_inicio <= " & d.pdtm(xdi) & ") AND " & _
        "(tabela_promocional.data_termino >= " & d.pdtm(xdf) & _
        ") AND (tabela_promocional_itens.cod_tabela = " & x_cod_tabela & ")"
        d.carrega_Tabela(tsql, tt)
        If tt.Rows.Count = 0 Then
            Return 0
        Else
            Return rdNum(tt.Rows(0)(0))
        End If
    End Function

    Public Function tipo_surfacagem(ByVal x_cod_produto As Integer) As Integer
        Dim tsql As String
        Dim tt As New DataTable
        Dim material As Integer
        tsql = "SELECT lentes_blocos.id_material " & _
        "FROM lentes_blocos INNER JOIN produtos ON " & _
        "lentes_blocos.cod_lente = produtos.cod_lente " & _
        "AND lentes_blocos.id_fabricante = produtos.id_fabricante " & _
        " WHERE (lentes_blocos.especie = 'B') And produtos.cod_produto = " & _
        x_cod_produto & ""
        d.carrega_Tabela(tsql, tt)
        If tt.Rows.Count > 0 Then
            material = tt.Rows(0)("id_material")
        End If
        tt.Clear()
        tsql = "Select surfacagem from materiais where id_material = " & material & ""
        d.carrega_Tabela(tsql, tt)
        Try
            Return tt.Rows(0)("surfacagem")
        Catch ex As Exception
            Return 0
        End Try

    End Function

    Public Function Saldos_(ByVal x_cod_prod As Integer) As DataTable
        Dim tSql As String
        Dim tt As New DataTable
        tSql = "SELECT     produtos.cod_produto,produtos.produto, almoxarifado.id_filial, " & _
        "((select sUM(movimento.quant) FROM movimento WHERE(cod_produto = produtos.cod_produto) " & _
        "and (id_filial = almoxarifado.id_filial)) - ((SELECT COUNT(cod_produto) AS r_lente " & _
        "FROM reserva_lente_os WHERE (id_status_reserva = 0) AND " & _
        "(cod_produto = produtos.cod_produto) and (id_filial = almoxarifado.id_filial)) " & _
        ")) AS Saldo FROM produtos CROSS JOIN almoxarifado " & _
        "where (produtos.cod_produto = " & x_cod_prod & ")"
        d.carrega_Tabela(tSql, tt)
        Return tt
    End Function

    Public Function saldos_labo(ByVal x_cod_tabela As Integer, ByVal crit As String, ByVal filial As Integer) As DataTable
        Dim tsql As String
        Dim tt As New DataTable
        'crit = crit.Replace(" ", "%")
        tsql = "SELECT produtos.cod_produto, produtos.produto, " & _
        "isnull((SELECT SUM(quant) as q " & _
        "FROM movimento WHERE (cod_produto = produtos.cod_produto) and (movimento.id_filial = " & filial & ")) " & _
        ",0) AS Saldo, " & _
        "lentes_blocos.cod_tabela FROM produtos INNER JOIN " & _
        "lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente " & _
        "AND produtos.id_fabricante = lentes_blocos.id_fabricante " & _
        " WHERE (lentes_blocos.cod_tabela = " & x_cod_tabela & ") " & _
        "and (produtos.produto like '%" & crit & "%') " & _
        "order by produtos.produto"
        d.carrega_Tabela(tsql, tt)
        Return tt
    End Function

    Public Function Extrato(ByVal x_cod_prod As Long, ByVal di As Date, ByVal df As Date) As DataTable
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "SELECT cod_lancamento, quant, estoqueFis, Historico, data_lancamento, cod_produto " & _
        "FROM movimento WHERE (cod_produto = " & x_cod_prod & ") AND " & _
        "(data_lancamento >= " & d.pdtm(di) & " ) and (data_lancamento <= " & d.pdtm(df) & ") " & _
        "ORDER BY cod_lancamento"
        d.carrega_Tabela(tsql, tt)
        Return tt
    End Function

    Public Function Extrato(ByVal x_cod_prod As Long, ByVal di As Date, ByVal df As Date, ByVal filial As Integer) As DataTable
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "SELECT cod_lancamento, quant, estoqueFis, Historico, data_lancamento, cod_produto " & _
        "FROM movimento WHERE (cod_produto = " & x_cod_prod & ") AND " & _
        "(data_lancamento >= " & d.pdtm(di) & " ) and (data_lancamento <= " & d.pdtm(df) & ") " & _
        "and (movimento.id_filial = " & filial & ") " & _
        "ORDER BY cod_lancamento"
        d.carrega_Tabela(tsql, tt)
        Return tt
    End Function

    Public Function compra_tabela_c_desconto() As Double
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "SELECT  (lentes_tabela.Preco_compra - lentes_tabela.Preco_compra * " & _
        "(lentes_tabela.desconto_compra / 100)) AS pdesc " & _
        "FROM produtos INNER JOIN lentes_blocos ON produtos.cod_lente = " & _
        "lentes_blocos.cod_lente AND produtos.id_fabricante = lentes_blocos.id_fabricante INNER JOIN " & _
        "lentes_tabela ON lentes_blocos.cod_tabela = lentes_tabela.cod_tabela " & _
        " WHERE (produtos.cod_produto = " & _cod_produto & ")"
        d.carrega_Tabela(tsql, tt)
        If tt.Rows.Count = 0 Then
            Return 0
        Else
            Return rdNum(tt.Rows(0)(0))
        End If
    End Function

    Public Function compra_tabela_c_desconto(ByVal X_cod_prod As Integer) As Double
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT round((lentes_tabela.Preco_compra - lentes_tabela.Preco_compra * " & _
        "(lentes_tabela.desconto_compra / 100)),2) AS pdesc " & _
        "FROM produtos INNER JOIN lentes_blocos ON produtos.cod_lente = " & _
        "lentes_blocos.cod_lente AND produtos.id_fabricante = lentes_blocos.id_fabricante INNER JOIN " & _
        "lentes_tabela ON lentes_blocos.cod_tabela = lentes_tabela.cod_tabela " & _
        " WHERE (produtos.cod_produto = " & X_cod_prod & ")"
        d.carrega_Tabela(sql, tt)
        If tt.Rows.Count = 0 Then
            Return 0
        Else
            Return tt.Rows(0)(0)
        End If
    End Function

    Public Function compra_servico(ByVal X_cod_prod As Integer) As Double
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT preco_custo from produtos where cod_produto = " & X_cod_prod & ""
        d.carrega_Tabela(sql, tt)
        If tt.Rows.Count = 0 Then
            Return 0
        Else
            Return tt.Rows(0)(0)
        End If
    End Function

    Public Function retorna_faturamento_periodo(ByVal x_cod_tabela As Integer, ByVal xDI As Date, ByVal xDF As Date) As Double
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT faturamento_produtos_Graf_1.*,((pedidosCheio+pedidosFin)/2) as media " & _
        " FROM faturamento_produtos_Graf(" & d.pdtm(xDI) & "," & d.pdtm(xDF) & " ) AS " & _
        "faturamento_produtos_Graf_1 where (cod_tabela = " & x_cod_tabela & ")"
        d.carrega_Tabela(sql, tt)
        If tt.Rows.Count = 0 Then
            Return 0
        Else
            Return tt.Rows(0)("pedidos")
        End If
    End Function

    Public Function detalhamento_pedidos(ByVal cod_produto As Integer, ByVal filial As Integer) As DataTable
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "select pedido_balcao_itens.num_pedido,   pedido_balcao_itens.cod_produto,produtos.produto, " & _
        "lentes_blocos.nome_lente ,status_item_pedido.status_item,lentes_blocos.cod_tabela from pedido_balcao_itens " & _
        "inner join produtos on produtos.cod_produto = pedido_balcao_itens.cod_produto " & _
        "inner join lentes_blocos on produtos.cod_lente = lentes_blocos.cod_lente  " & _
        "inner join status_item_pedido on pedido_balcao_itens.cod_status_item = status_item_pedido.cod_status_item " & _
        "where (pedido_balcao_itens.id_filial = " & filial & ")" & _
        "and pedido_balcao_itens.cod_produto = " & cod_produto & _
        " order by status_item_pedido.status_item"
        d.carrega_Tabela(tsql, tt)
        Return tt
    End Function

    Public Function lista_outros_produtos() As DataTable
        Dim tt As New DataTable
        d.carrega_Tabela("Select produto,cod_produto from produtos where cod_grupo = 5 order by produto", tt)
        Return tt
    End Function

#End Region
End Class
