Public Class objDevolucaoEstoquePedido
#Region "Atributos"
    Private _cod_movimento As Integer
    Private _id_filial As Integer
    Private _num_pedido As Integer
    Private _id_filial_pedido As Integer
    Private _cod_devolucao_pedido As Integer
    Private _cod_filial_devolucao As Integer
    Private _cod_natureza As Integer
    Private _data As Object
    Private _doc As String
    Private _id_usuario As Integer
    Private _concluido As String
    Private _valor_itens As Object
    Public posicao As Integer = 0
    Public max As Integer
    Public chaveCriterio1, chaveCriterio2 As Object
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
    Public Property id_filial()
        Get
            id_filial = _id_filial
        End Get
        Set(ByVal Value)
            _id_filial = Value
        End Set
    End Property
    Public Property cod_devolucao_pedido()
        Get
            cod_devolucao_pedido = _cod_devolucao_pedido
        End Get
        Set(ByVal Value)
            _cod_devolucao_pedido = Value
        End Set
    End Property
    Public Property cod_filial_devolucao()
        Get
            cod_filial_devolucao = _cod_filial_devolucao
        End Get
        Set(ByVal value)
            _cod_filial_devolucao = value
        End Set
    End Property
    Public Property id_filial_pedido()
        Get
            id_filial_pedido = _id_filial_pedido
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
        Set(ByVal value)
            _concluido = value
        End Set
    End Property
    Public Property valor_itens()
        Get
            valor_itens = _valor_itens
        End Get
        Set(ByVal value)
            _valor_itens = value
        End Set
    End Property
#End Region
#Region "Procedimentos"
    Public Sub New()
        Dim sql As String
        sql = "SELECT movimentomaster.cod_natureza, movimentomaster.data, movimentomaster.doc," & _
        "movimentomaster.id_usuario, Devolucao_pedido_balcao.id_filial, " & _
        "Devolucao_pedido_balcao.cod_movimento, Devolucao_pedido_balcao.num_pedido," & _
        "Devolucao_pedido_balcao.id_filial_pedido, Devolucao_pedido_balcao.cod_filial_devolucao, " & _
        "Devolucao_pedido_balcao.cod_devolucao_pedido,movimentomaster.concluido, " & _
        "Devolucao_pedido_balcao.valor_itens " & _
        "FROM movimentomaster INNER JOIN Devolucao_pedido_balcao ON  " & _
        "movimentomaster.cod_movimento = Devolucao_pedido_balcao.cod_movimento AND " & _
        "movimentomaster.id_filial = Devolucao_pedido_balcao.id_filial " & _
        "WHERE (Devolucao_pedido_balcao.cod_movimento = 0) "
        Source(sql)
    End Sub
    Public Sub New(ByVal x_num_pedido As Integer, ByVal x_id_filial As Integer)
        filtrar(x_num_pedido, x_id_filial)
    End Sub
    Public Sub filtrar(ByVal x_num_pedido As Integer, ByVal x_id_filial As Integer)
        Dim sql As String
        'Filtra devolução 
        sql = "SELECT movimentomaster.cod_natureza, movimentomaster.data, movimentomaster.doc," & _
        "movimentomaster.id_usuario, Devolucao_pedido_balcao.id_filial, " & _
        "Devolucao_pedido_balcao.cod_movimento, Devolucao_pedido_balcao.num_pedido," & _
        "Devolucao_pedido_balcao.id_filial_pedido, Devolucao_pedido_balcao.cod_filial_devolucao, " & _
        "Devolucao_pedido_balcao.cod_devolucao_pedido,movimentomaster.concluido, " & _
        "Devolucao_pedido_balcao.valor_itens " & _
        "FROM movimentomaster INNER JOIN Devolucao_pedido_balcao ON  " & _
        "movimentomaster.cod_movimento = Devolucao_pedido_balcao.cod_movimento AND " & _
        "movimentomaster.id_filial = Devolucao_pedido_balcao.id_filial " & _
        "WHERE     (Devolucao_pedido_balcao.num_pedido = " & x_num_pedido & ")" & _
        " and (Devolucao_pedido_balcao.id_filial_pedido = " & x_id_filial & ") " & _
        " ORDER BY movimentomaster.data Desc"
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
            _id_filial = tb.Rows(p)("id_filial")
            _cod_devolucao_pedido = tb.Rows(p)("cod_devolucao_pedido")
            _cod_filial_devolucao = tb.Rows(p)("cod_filial_devolucao")
            _num_pedido = tb.Rows(p)("num_pedido")
            _id_filial_pedido = tb.Rows(p)("id_filial_pedido")
            _cod_natureza = tb.Rows(p)("cod_natureza")
            _data = tb.Rows(p)("data")
            _doc = tb.Rows(p)("doc")
            _id_usuario = tb.Rows(p)("id_usuario")
            _concluido = rdTexto(tb.Rows(p)("concluido"))
            _valor_itens = rdNum(tb.Rows(p)("valor_itens"))
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
        _cod_filial_devolucao = conf.Filial
        _id_filial = conf.Filial
        _id_filial_pedido = Nothing
        _cod_natureza = 12
        _data = Nothing
        _doc = "Devolução " & _cod_devolucao_pedido
        _id_usuario = UserID
        OrigemSalvar = "Novo" 'Define o tipo de ação ao salvar
    End Function
    Public Function Salvar() As String
        Dim sql As String
        Dim res As String 'Quantidade de registros afetados
        d.conecta()
        If OrigemSalvar = "Novo" Then
            Try
                _cod_movimento = retorna_Chave("cod_movimento", "movimentomaster", " where id_filial = " & conf.Filial)
                _cod_devolucao_pedido = retorna_Chave("cod_devolucao_pedido", "Devolucao_pedido_balcao", " where cod_filial_devolucao = " & conf.Filial)
                sql = "INSERT INTO movimentomaster " & _
                "(cod_movimento,cod_natureza,id_filial,data,doc,id_usuario) " & _
                "VALUES ( " & _
                _cod_movimento & _
                ",12" & _
                "," & _id_filial & _
                "," & d.pdtm(_data) & _
                "," & d.PStr(_doc) & _
                "," & _id_usuario & ")"
                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Try
                sql = "INSERT INTO devolucao_pedido_balcao(cod_movimento," & _
                "id_filial, cod_devolucao_pedido, cod_filial_devolucao, " & _
                "id_filial_pedido,num_pedido) " & _
                "VALUES (" & _cod_movimento & "," & _id_filial & _
                "," & _cod_devolucao_pedido & "," & _cod_filial_devolucao & _
                "," & id_filial_pedido & "," & _num_pedido & ")"
                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tb.NewRow
            r("cod_movimento") = _cod_movimento
            r("id_filial") = _id_filial
            r("cod_devolucao_pedido") = _cod_devolucao_pedido
            r("cod_filial_devolucao") = _cod_filial_devolucao
            r("id_filial_pedido") = _id_filial_pedido
            r("num_pedido") = _num_pedido
            r("cod_natureza") = _cod_natureza
            r("data") = wrData(_data)
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

        End If
    End Function
    Public Function deletar(ByVal id_mov As Integer, ByVal id_fil As Integer)
        Dim sql As String
        Dim res As Integer
        d.conecta()
        sql = "Delete from movimentomaster where cod_movimento = " & id_mov & _
        " and id_filial = " & id_fil & ""
        Try
            res = d.Comando(sql, True)
        Catch ex As Exception
        End Try
        Me.refreshData()
        Me.primeiro()
        Return res & " Registros foram apagados!"
    End Function
    Public Function lista_itens_devolvidos(ByVal x_cod_produto As Integer) As DataTable
        Dim sql As String
        Dim tb_lista As New DataTable
        sql = "SELECT * FROM movimento " & _
        " WHERE (id_filial = " & Me._id_filial & ") AND " & _
        "(cod_Movimento = " & Me._cod_movimento & ") AND " & _
        "(cod_produto = " & x_cod_produto & ") and status = 0"
        d.carrega_Tabela(sql, tb_lista)
        Return tb_lista
        tb_lista.Dispose()
    End Function
    Public Function lista_itens_devolucao() As DataTable
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT * FROM lista_itens_dev_pedido(" & _cod_devolucao_pedido & _
        "," & _cod_filial_devolucao & ") AS dev "
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function Valor_total_itens() As Double
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "SELECT   SUM(total) as valor " & _
        "FROM lista_itens_dev_pedido(" & _cod_devolucao_pedido & "," & _cod_filial_devolucao & ") AS dev"
        d.carrega_Tabela(tsql, tt)
        Try
            Return tt.Rows(0)(0)
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Public Function quantidade_item_devolucao(ByVal xcodProd As Integer) As Integer
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT devolucao_pedido_balcao_itens.quant  " & _
        "FROM devolucao_pedido_balcao_itens " & _
        "where  devolucao_pedido_balcao_itens.cod_devolucao_pedido = " & _cod_devolucao_pedido & _
        " and devolucao_pedido_balcao_itens.cod_filial_devolucao = " & _cod_filial_devolucao & _
        " and pedido_balcao_itens.cod_produto = " & xcodProd & ""
        d.carrega_Tabela(sql, tt)
        If tt.Rows.Count > 0 Then
            Return tt.Rows(0)("quant")
        Else
            Return 0
        End If
    End Function
    Public Function insere_item_devolucao(ByVal xitem As Integer, ByVal xquant As Integer, ByVal valor As Double) As String
        Dim sql As String
        sql = "Insert into devolucao_pedido_balcao_itens(cod_devolucao_pedido,cod_filial_devolucao,id_item,quant,valor) values(" & _
        _cod_devolucao_pedido & "," & _cod_filial_devolucao & "," & xitem & "," & xquant & _
        "," & d.cdin(valor) & ")"
        Return d.Comando(sql, True)
    End Function
    Public Function devolve_produto(ByVal x_cod_prod, ByVal xquant) As String
        Dim mov As New objMovimentoDetalhe
        Dim prod As New produtoClass
        prod.filtra(x_cod_prod)
        mov.novo()
        mov.cod_lancamento = retorna_Chave("cod_lancamento", "movimento", " where id_filial = " & _id_filial & "")
        mov.id_filial = _id_filial
        mov.item = mov.ret_ultimo_item(_cod_movimento)
        mov.cod_movimento = _cod_movimento
        mov.cod_produto = prod.fldCod_produto
        mov.quant = xquant
        mov.desconto = 0
        mov.Pvenda = prod.fldPreco_venda
        mov.descVenda = prod.fldDesconto
        mov.pUnit = prod.fldPreco_custo
        mov.estoqueFis = mov.ret_saldo_fisico(prod.fldCod_produto) + CDbl(xquant)
        mov.estoqueFin = mov.estoqueFis * prod.fldPreco_custo
        mov.historico = "Devolução de produto do pedido" & _num_pedido & "-" & _id_filial_pedido
        Return mov.Salvar
    End Function
    Public Function conclui_movimento() As String
        Dim sql As String
        sql = "update movimentomaster set concluido = 'S' " & _
        " where cod_movimento = " & _cod_movimento & " and " & _
        "id_filial = " & _id_filial & ""
        Return d.Comando(sql, True)
    End Function
    Public Function todos_devolvidos() As Boolean
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "SELECT sum(quant) as quant, sum(devolvido) as devolvido " & _
        " FROM lista_itens_dev_pedido(" & _cod_devolucao_pedido & "," & _cod_filial_devolucao & ") AS dev"
        Try
            d.carrega_Tabela(tsql, tt)
            If tt.Rows(0)("quant") <> tt.Rows(0)("devolvido") Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try
        
        
    End Function
    Public Function atualiza_valor_itens(ByVal Valor As Double) As String
        Dim tsql As String
        Dim res As String
        Valor = _valor_itens + Valor
        tsql = "Update Devolucao_pedido_balcao set valor_itens = " & _
       d.cdin(Valor) & " where cod_devolucao_pedido = " & _
       _cod_devolucao_pedido & " and cod_filial_devolucao = " & _
       _cod_filial_devolucao & ""
        res = d.Comando(tsql, True)
        If res.StartsWith("OK") Then
            Dim r As DataRow
            r = tb.Rows(posicao)
            r("valor_itens") = wrNum(Valor)
            Registro(posicao)
        End If
        Return res
    End Function
#End Region
End Class
