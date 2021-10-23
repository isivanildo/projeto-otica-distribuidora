Public Class objLentes
#Region "Atributos"
    Private _cod_lente As Integer
    Private _cod_tabela As Integer
    Private _id_fabricante As Integer
    Private _cod_tipo_lente As Integer
    Private _nome_lente As String
    Private _especie As String
    Private _esf_maior As Double
    Private _esf_menor As Double
    Private _cil_menor As Double
    Private _adicao_menor As Object
    Private _adicao_maior As Object
    Private _ir As Object
    Private _aco_minimo As Object
    Private _abbe As Object
    Private _preco_custo As Double
    Private _preco_compra As Double
    Private _desconto_compra As Double
    Private _desconto_venda As Double
    Private _preco_venda As Double
    Private _id_material As Integer
    Private _caracteristicas As String
    Private _diametro As Object
    Private _Familia As String
    Private _ativo As Integer
    Private _disponibilidade As String
    Private _adicao As String
    Private _ncm As Long
    Private _tributacao As Integer
    Private _origem As Integer
    Private _unidade As String
    Private _gtin As String
    Private _cest As Integer
    Private _cmv As Decimal
    Private _qtde_entrada As Integer
    Private _qtde_estoque As Integer
    Public posicao As Integer = 0
    Public max As Integer
    Public chaveCriterio1 As Object
    Public chaveCriterio2 As Object
    Private tb As New DataTable
    Public OrigemSalvar As String = ""
    Private lastPos As Integer = 0
    Private sql As String
    Dim d As New dados
    Dim nome_lente_Trans As String 'Variável para armazenar temporariamente o nome da lente,
    'caso seja alterao, dispara o procedimento de atualização de nomes no cadastro de Produtos.
#End Region
#Region "GET SET"
    Public Property cod_lente()
        Get
            cod_lente = _cod_lente
        End Get
        Set(ByVal Value)
            _cod_lente = Value
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
    Public Property id_fabricante()
        Get
            id_fabricante = _id_fabricante
        End Get
        Set(ByVal Value)
            _id_fabricante = Value
        End Set
    End Property
    Public Property cod_tipo_lente()
        Get
            cod_tipo_lente = _cod_tipo_lente
        End Get
        Set(ByVal Value)
            _cod_tipo_lente = Value
        End Set
    End Property
    Public Property id_material()
        Get
            id_material = _id_material
        End Get
        Set(ByVal Value)
            _id_material = Value
        End Set
    End Property
    Public Property nome_lente()
        Get
            nome_lente = _nome_lente
        End Get
        Set(ByVal Value)
            _nome_lente = Value
        End Set
    End Property
    Public Property especie()
        Get
            especie = _especie
        End Get
        Set(ByVal Value)
            _especie = Value
        End Set
    End Property
    Public Property esf_maior()
        Get
            esf_maior = _esf_maior
        End Get
        Set(ByVal Value)
            _esf_maior = Value
        End Set
    End Property
    Public Property esf_menor()
        Get
            esf_menor = _esf_menor
        End Get
        Set(ByVal Value)
            _esf_menor = Value
        End Set
    End Property
    Public Property cil_menor()
        Get
            cil_menor = _cil_menor
        End Get
        Set(ByVal Value)
            _cil_menor = Value
        End Set
    End Property
    Public Property adicao_maior()
        Get
            adicao_maior = _adicao_maior
        End Get
        Set(ByVal Value)
            _adicao_maior = Value
        End Set
    End Property
    Public Property adicao_menor()
        Get
            adicao_menor = _adicao_menor
        End Get
        Set(ByVal Value)
            _adicao_menor = Value
        End Set
    End Property
    Public Property ir()
        Get
            ir = _ir
        End Get
        Set(ByVal Value)
            _ir = Value
        End Set
    End Property
    Public Property aco_minimo()
        Get
            aco_minimo = _aco_minimo
        End Get
        Set(ByVal Value)
            _aco_minimo = Value
        End Set
    End Property
    Public Property abbe()
        Get
            abbe = _abbe
        End Get
        Set(ByVal Value)
            _abbe = Value
        End Set
    End Property
    Public Property preco_compra()
        Get
            preco_compra = _preco_compra
        End Get
        Set(ByVal Value)
            _preco_compra = Value
        End Set
    End Property
    Public Property desconto_compra()
        Get
            desconto_compra = _desconto_compra
        End Get
        Set(ByVal Value)
            _desconto_compra = Value
        End Set
    End Property
    Public Property preco_venda()
        Get
            preco_venda = _preco_venda
        End Get
        Set(ByVal Value)
            _preco_venda = rdTexto(Value)
        End Set
    End Property
    Public Property desconto_venda()
        Get
            desconto_venda = _desconto_venda
        End Get
        Set(ByVal Value)
            _desconto_venda = Value
        End Set
    End Property
    Public Property caracteristicas()
        Get
            caracteristicas = _caracteristicas
        End Get
        Set(ByVal Value)
            _caracteristicas = Value
        End Set
    End Property
    Public Property diametro()
        Get
            diametro = _diametro
        End Get
        Set(ByVal Value)
            _diametro = Value
        End Set
    End Property
    Public Property familia()
        Get
            familia = _Familia
        End Get
        Set(ByVal Value)
            _Familia = Value
        End Set
    End Property
    Public Property ativo()
        Get
            ativo = _ativo
        End Get
        Set(ByVal Value)
            _ativo = Value
        End Set
    End Property

    Public Property disponibilidade()
        Get
            disponibilidade = _disponibilidade
        End Get
        Set(ByVal value)
            _disponibilidade = value
        End Set
    End Property

    Public Property adicao
        Get
            adicao = _adicao
        End Get
        Set(ByVal value)
            _adicao = value
        End Set
    End Property

    Public Property ncm
        Get
            ncm = _ncm
        End Get
        Set(ByVal value)
            _ncm = value
        End Set
    End Property

    Public Property tributacao
        Get
            tributacao = _tributacao
        End Get
        Set(ByVal value)
            _tributacao = value
        End Set
    End Property

    Public Property origem
        Get
            origem = _origem
        End Get
        Set(ByVal value)
            _origem = value
        End Set
    End Property

    Public Property unidade
        Get
            unidade = _unidade
        End Get
        Set(ByVal value)
            _unidade = value
        End Set
    End Property

    Public Property gtin
        Get
            gtin = _gtin
        End Get
        Set(ByVal value)
            _gtin = value
        End Set
    End Property

    Public Property cest
        Get
            cest = _cest
        End Get
        Set(ByVal value)
            _cest = value
        End Set
    End Property

    Public Property cmv
        Get
            cmv = _cmv
        End Get
        Set(ByVal value)
            _cmv = value
        End Set
    End Property

    Public Property qtdeentrada
        Get
            qtdeentrada = _qtde_entrada
        End Get
        Set(ByVal value)
            _qtde_entrada = value
        End Set
    End Property

    Public Property qtdeestoque
        Get
            qtdeestoque = _qtde_estoque
        End Get
        Set(ByVal value)
            _qtde_estoque = value
        End Set
    End Property
#End Region
#Region "Procedimentos"
    Public Sub New()
        Me.Source("Select * from lentes_blocos order by nome_lente")
    End Sub
    Public Sub New(ByVal top As Integer)
        Me.Source("Select top(" & top & ") * from lentes_blocos order by nome_lente")
    End Sub
    Public Sub New(ByVal dobj As dados)
        d = dobj
        Me.Source("Select * from lentes_blocos order by nome_lente")
    End Sub
    Public Sub filtra(x_cod_tabela As Integer, x_diam As Integer)
        sql = "Select * from lentes_blocos  where cod_tabela = " & x_cod_tabela & _
        " and diametro = " & x_diam & ""
        Me.Source(sql)

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
            _cod_lente = tb.Rows(p)("cod_lente")
            _cod_tabela = rdNum(tb.Rows(p)("cod_tabela"))
            _id_fabricante = tb.Rows(p)("id_fabricante")
            _cod_tipo_lente = tb.Rows(p)("cod_tipo_lente")
            _nome_lente = rdTexto(tb.Rows(p)("nome_lente"))
            _especie = rdTexto(tb.Rows(p)("especie"))
            _esf_maior = rdNum(tb.Rows(p)("esf_maior"))
            _esf_menor = rdNum(tb.Rows(p)("esf_menor"))
            _cil_menor = rdNum(tb.Rows(p)("cil_menor"))
            _adicao_menor = rdNum(tb.Rows(p)("adicao_menor"))
            _adicao_maior = rdNum(tb.Rows(p)("adicao_maior"))
            _ir = rdNum(tb.Rows(p)("IR"))
            _aco_minimo = rdNum(tb.Rows(p)("aco_minimo"))
            _id_material = rdNum(tb.Rows(p)("id_material"))
            _abbe = rdNum(tb.Rows(p)("abbe"))
            _preco_custo = rdNum(tb.Rows(p)("preco_custo"))
            _preco_compra = rdNum(tb.Rows(p)("preco_compra"))
            _desconto_compra = rdNum(tb.Rows(p)("desconto_compra"))
            _preco_venda = rdNum(tb.Rows(p)("preco_venda"))
            _desconto_venda = rdNum(tb.Rows(p)("desconto_venda"))
            _caracteristicas = rdTexto(tb.Rows(p)("caracteristicas"))
            _diametro = rdNum(tb.Rows(p)("diametro"))
            _Familia = rdTexto(tb.Rows(p)("cod_familia"))
            _ativo = rdNum(tb.Rows(p)("ativo"))
            _disponibilidade = rdTexto(tb.Rows(p)("disponibilidade"))
            _adicao = rdTexto(tb.Rows(p)("adicao"))
            _ncm = rdNum(tb.Rows(p)("ncm"))
            _tributacao = rdNum(tb.Rows(p)("tributacao"))
            _origem = rdNum(tb.Rows(p)("origem"))
            _unidade = rdTexto(tb.Rows(p)("unidade"))
            _gtin = rdTexto(tb.Rows(p)("gtin"))
            _cest = rdNum(tb.Rows(p)("cest"))
            _cmv = rdNum(tb.Rows(p)("cmv"))
            _qtde_entrada = rdNum(tb.Rows(p)("qtde_entrada"))
            _qtde_estoque = rdNum(tb.Rows(p)("qtde_estoque"))
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
        nome_lente_Trans = _nome_lente
    End Sub
#End Region
#Region "Funções"
    Public Function novo()
        lastPos = posicao 'guarda a posição do último Registro
        'Zera Variáveis
        _cod_lente = 0
        _cod_tabela = Nothing
        _id_fabricante = 0
        _cod_tipo_lente = 0
        _nome_lente = ""
        _esf_maior = Nothing
        _esf_menor = Nothing
        _cil_menor = Nothing
        _adicao_maior = Nothing
        _adicao_menor = Nothing
        _ir = Nothing
        _aco_minimo = Nothing
        _abbe = Nothing
        _preco_compra = Nothing
        _desconto_compra = Nothing
        _preco_venda = Nothing
        _desconto_venda = Nothing
        _diametro = Nothing
        _Familia = ""
        _ativo = 1
        OrigemSalvar = "Novo" 'Define o tipo de ação ao salvar
    End Function
    Public Function Salvar() As String
        Dim sql As String
        Dim res As String 'Quantidade de registros afetados
        d.conecta()
        If OrigemSalvar = "Novo" Then
            Try
                _cod_lente = retorna_Chave("cod_lente", "lentes_blocos", "")
                sql = "Insert into lentes_blocos(cod_lente,cod_tabela,id_fabricante,cod_tipo_lente, " & _
                "nome_lente,especie,esf_maior,esf_menor,cil_menor,adicao_menor,adicao_maior, " & _
                "ir,aco_minimo,abbe,id_material,preco_compra,desconto_compra," & _
                "preco_venda,desconto_venda,caracteristicas,diametro,ativo) Values(" & _
                _cod_lente & "," & _cod_tabela & "," & _id_fabricante & "," & _cod_tipo_lente & "," & _
                d.PStr(_nome_lente) & "," & d.PStr(_especie) & "," & d.cdin(_esf_maior) & _
                "," & d.cdin(_esf_menor) & "," & d.cdin(_cil_menor) & "," & d.cdin(_adicao_menor) & _
                "," & d.cdin(_adicao_maior) & "," & d.cdin(_ir) & "," & d.cdin(_aco_minimo) & _
                "," & d.cdin(_abbe) & "," & _id_material & "," & d.cdin(_preco_compra) & _
                "," & d.cdin(_desconto_compra) & "," & d.cdin(_preco_venda) & "," & _
                d.cdin(_desconto_venda) & "," & d.PStr(_caracteristicas) & "," & d.cdin(_diametro) & _
                "," & _ativo & ")"

                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tb.NewRow
            r("cod_lente") = _cod_lente
            r("cod_tabela") = _cod_tabela
            r("id_fabricante") = _id_fabricante
            r("cod_tipo_lente") = _cod_tipo_lente
            r("nome_lente") = rdTexto(_nome_lente)
            r("especie") = rdTexto(_especie)
            r("esf_maior") = wrNum(_esf_maior)
            r("esf_menor") = wrNum(_esf_menor)
            r("cil_menor") = wrNum(_cil_menor)
            r("adicao_menor") = wrNum(_adicao_menor)
            r("adicao_maior") = wrNum(_adicao_maior)
            r("ir") = wrNum(_ir)
            r("aco_minimo") = wrNum(_aco_minimo)
            r("abbe") = wrNum(_abbe)
            r("id_material") = _id_material
            r("preco_compra") = wrNum(_preco_compra)
            r("desconto_compra") = wrNum(_desconto_compra)
            r("preco_venda") = wrNum(_preco_venda)
            r("desconto_venda") = wrNum(_desconto_venda)
            r("caracteristicas") = rdTexto(_caracteristicas)
            r("diametro") = wrNum(_diametro)
            r("ativo") = wrNum(_ativo)
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
                sql = "Update lentes_blocos set " &
                "cod_lente = " & _cod_lente &
                ",cod_tabela = " & _cod_tabela &
                ",id_fabricante = " & _id_fabricante &
                ",cod_tipo_lente = " & _cod_tipo_lente &
                ",nome_lente = " & d.PStr(_nome_lente) &
                ",especie = " & d.PStr(_especie) &
                ",esf_maior = " & d.cdin(_esf_maior) &
                ",esf_menor = " & d.cdin(_esf_menor) &
                ",cil_menor = " & d.cdin(_cil_menor) &
                ",adicao_menor =" & d.cdin(_adicao_menor) &
                ",adicao_maior =" & d.cdin(_adicao_maior) &
                ",ir = " & d.cdin(_ir) &
                ",aco_minimo=" & d.cdin(_aco_minimo) &
                ",abbe = " & d.cdin(_abbe) &
                ",id_material = " & _id_material &
                ",preco_compra = " & d.cdin(_preco_compra) &
                ",desconto_compra = " & d.cdin(_desconto_compra) &
                ",preco_venda = " & d.cdin(_preco_venda) &
                ",desconto_venda = " & d.cdin(_desconto_venda) &
                ",caracteristicas = " & d.PStr(_caracteristicas) &
                ",diametro = " & d.cdin(_diametro) &
                ",ativo = " & _ativo &
                " where cod_lente = " & chaveCriterio1 & " and " &
                "id_fabricante = " & chaveCriterio2 & ""
                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            'Novo 15/11/2019
            sql = "update produtos set produto = " & d.PStr(_nome_lente) &
                ", produtos.unidade = " & d.PStr(_unidade) &
                ", produtos.preco_venda = " & d.cdin(_preco_venda) &
                ", produtos.desconto = " & d.cdin(_desconto_venda) &
                ", produtos.preco_tabela = " & d.cdin(Format(_preco_venda - (_preco_venda * _desconto_venda / 100), "#,##0.00")) &
                ", produtos.fator_preco = " & 1 &
                ", produtos.preco_compra = " & d.cdin(_preco_compra) &
                ", produtos.desconto_compra = " & d.cdin(_desconto_compra) &
                ", produtos.ncm = " & d.PStr(_ncm) &
                ", produtos.tributacao = " & wrNum(_tributacao) &
                ", produtos.origem = " & wrNum(_origem) &
                ", produtos.gtin = " & d.PStr(_gtin) &
                " FROM  produtos INNER JOIN " &
                "lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente AND " &
                "produtos.id_fabricante = lentes_blocos.id_fabricante INNER JOIN " &
                "lentes_tabela ON lentes_blocos.cod_tabela = lentes_tabela.cod_tabela " &
                " where lentes_tabela.cod_tabela = " & _cod_tabela & ""
            MsgBox(d.Comando(sql, True))
            'Fim Novo
            Dim r As DataRow
            r = tb.Rows(posicao)
            r("cod_lente") = _cod_lente
            r("cod_tabela") = _cod_tabela
            r("id_fabricante") = _id_fabricante
            r("cod_tipo_lente") = _cod_tipo_lente
            r("nome_lente") = rdTexto(_nome_lente)
            r("especie") = rdTexto(_especie)
            r("esf_maior") = wrNum(_esf_maior)
            r("esf_menor") = wrNum(_esf_menor)
            r("cil_menor") = wrNum(_cil_menor)
            r("adicao_menor") = wrNum(_adicao_menor)
            r("adicao_maior") = wrNum(_adicao_maior)
            r("ir") = wrNum(_ir)
            r("aco_minimo") = wrNum(_aco_minimo)
            r("abbe") = wrNum(_abbe)
            r("id_material") = _id_material
            r("preco_compra") = wrNum(_preco_compra)
            r("desconto_compra") = wrNum(_desconto_compra)
            r("preco_venda") = wrNum(_preco_venda)
            r("desconto_venda") = wrNum(_desconto_venda)
            r("caracteristicas") = rdTexto(_caracteristicas)
            r("diametro") = wrNum(_diametro)
            r("ativo") = wrNum(_ativo)
            OrigemSalvar = ""
            If _nome_lente <> nome_lente_Trans Then
                Dim p As New produtoClass
                p.atualizar_nome(_nome_lente, _especie, _id_fabricante, _cod_lente)
            End If
            nome_lente_Trans = ""
            Return res & " atualizado(s) com sucesso!"
        End If
    End Function
    Public Function deletar(ByVal id_lente As Integer, ByVal id_fabricante As Integer)
        Dim sql As String
        Dim res As String
        d.conecta()

        sql = "Delete from lentes_blocos where id_fabricante = " & id_fabricante & _
        " and cod_lente = " & id_lente & ""
        Try
            res = d.Comando(sql, True)
        Catch ex As Exception
            Return "ER:" & "O registro não pode ser apagado!" & vbCrLf & ex.Message
            Exit Function
        End Try
        Me.refreshData()
        Me.primeiro()
        Return "OK:" & res & " Registro(s) foi(ram) apagado(s)!"
    End Function
    Public Function nome_tabela(ByVal cod_tabela As Integer) As String
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "Select nome_comercial from lentes_tabela where cod_tabela = " & cod_tabela & ""
        d.carrega_Tabela(tsql, tt)
        If tt.Rows.Count > 0 Then
            Return tt.Rows(0)("nome_comercial")
        Else
            Return ""
        End If
    End Function
    Public Function existe(x_cod_tabela As Integer, x_diam As Integer) As Boolean
        Dim tt As New DataTable
        Dim tsql As String
        tsql = "Select * from lentes_blocos  where cod_tabela = " & x_cod_tabela & _
        " and diametro = " & x_diam & ""
        d.carrega_Tabela(tsql, tt)
        If tt.Rows.Count = 0 Then Return False Else Return True
    End Function
#End Region
End Class
