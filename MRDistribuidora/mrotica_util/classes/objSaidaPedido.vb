Public Class objSaidaPedido
#Region "Atributos"
    Private _cod_movimento As Integer
    Private _cod_saida_Pedido As Integer
    Private _num_pedido As Integer
    Private _id_filial As Integer
    Private _cod_natureza As Integer
    Private _data As Object
    Private _doc As String
    Private _id_usuario As Integer
    Public posicao As Integer = 0
    Public max As Integer
    Public chaveCriterio1, chaveCriterio2 As Object
    Public tb As New DataTable
    Public OrigemSalvar As String = ""
    Private lastPos As Integer = 0
    Private sql As String
    Dim d As New dados
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
    Public Property cod_saida_pedido()
        Get
            cod_saida_pedido = _cod_saida_Pedido
        End Get
        Set(ByVal Value)
            _cod_saida_Pedido = Value
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
#End Region
#Region "Procedimentos"
    Public Sub New()
        Dim sql As String
        sql = "SELECT movimentomaster.cod_natureza, movimentomaster.data, " & _
        "movimentomaster.doc, movimentomaster.id_usuario, saida_pedido.cod_movimento, " & _
        "saida_pedido.id_filial, saida_pedido.num_pedido, saida_pedido.cod_saida_pedido " & _
        "FROM movimentomaster INNER JOIN " & _
        "saida_pedido ON movimentomaster.cod_movimento = saida_pedido.cod_movimento " & _
        "AND movimentomaster.id_filial = saida_pedido.id_filial " & _
        " Where saida_pedido.cod_saida_pedido = 0"
        Source(sql)
    End Sub
    Public Sub New(ByVal cod_mov As Integer)
        Dim sql As String
        sql = "SELECT movimentomaster.cod_natureza, movimentomaster.data, " &
        "movimentomaster.doc, movimentomaster.id_usuario, saida_pedido.cod_movimento, " &
        "saida_pedido.id_filial, saida_pedido.num_pedido, saida_pedido.cod_saida_pedido " &
        "FROM movimentomaster INNER JOIN " &
        "saida_pedido ON movimentomaster.cod_movimento = saida_pedido.cod_movimento " &
        "AND movimentomaster.id_filial = saida_pedido.id_filial " &
        "where saida_pedido.cod_movimento = " & cod_mov & " and saida_pedido.id_filial = " & confFilial & ""
        Source(sql)
    End Sub
    Public Sub carrega_saida_pedido(ByVal x_num_pedido As Integer, ByVal x_id_filial As Integer)
        Dim sql As String
        sql = "SELECT movimentomaster.cod_natureza, movimentomaster.data, " &
        "movimentomaster.doc, movimentomaster.id_usuario, saida_pedido.cod_movimento, " &
        "saida_pedido.id_filial, saida_pedido.num_pedido, saida_pedido.cod_saida_pedido " &
        "FROM movimentomaster INNER JOIN " &
        "saida_pedido ON movimentomaster.cod_movimento = saida_pedido.cod_movimento " &
        "AND movimentomaster.id_filial = saida_pedido.id_filial " &
        "where saida_pedido.num_pedido = " & x_num_pedido &
        " and saida_pedido.id_filial = " & x_id_filial & ""
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
            _cod_saida_Pedido = tb.Rows(p)("cod_saida_pedido")
            _id_filial = tb.Rows(p)("id_filial")
            _num_pedido = tb.Rows(p)("num_pedido")
            _cod_natureza = tb.Rows(p)("cod_natureza")
            _data = tb.Rows(p)("data")
            _doc = tb.Rows(p)("doc")
            _id_usuario = tb.Rows(p)("id_usuario")
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
        _cod_movimento = retorna_Chave("cod_movimento", "movimentomaster", " where id_filial = " & confFilial)
        _cod_saida_Pedido = Nothing
        _num_pedido = Nothing
        _id_filial = confFilial
        _cod_natureza = 2
        _data = Nothing
        _doc = Nothing
        _id_usuario = UserID
        OrigemSalvar = "Novo" 'Define o tipo de ação ao salvar
    End Function
    Public Function Salvar() As String
        Dim cmd As New SqlClient.SqlCommand
        Dim sql As String
        Dim res As String
        d.conecta()
        cmd.Connection = d.con
        If OrigemSalvar = "Novo" Then
            Try
                sql = "INSERT INTO movimentomaster " &
                "(cod_movimento,cod_natureza,id_filial,data,doc,id_usuario) " &
                "VALUES (" &
                _cod_movimento &
                "," & _cod_natureza &
                "," & _id_filial &
                "," & d.pdtm(_data) &
                "," & d.PStr(_doc) &
                "," & _id_usuario & ")"
                cmd.CommandText = sql
                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Try
                _cod_saida_Pedido = retorna_Chave("cod_saida_pedido", "saida_pedido", " where id_filial = " & confFilial & "")
                sql = "INSERT INTO saida_pedido(cod_movimento,cod_saida_pedido,id_filial,num_pedido) " & _
                "VALUES (" & _cod_movimento & "," & _cod_saida_Pedido & "," & _id_filial & _
                "," & _num_pedido & ")"

                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tb.NewRow
            r("cod_movimento") = _cod_movimento
            r("cod_saida_pedido") = _cod_saida_Pedido
            r("id_filial") = _id_filial
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
                sql = "UPDATE movimentomaster SET cod_movimento = " & _cod_movimento & _
                ",cod_natureza = " & _cod_natureza & _
                ",id_filial = " & _id_filial & _
                ",data = " & d.pdtm(_data) & _
                ",doc = " & d.PStr(_doc) & _
                ",id_usuario = " & _id_usuario & _
                " WHERE cod_movimento = " & chaveCriterio1 & _
                " and id_filial = " & chaveCriterio2 & ""
                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Try
                sql = "UPDATE saida_pedido SET cod_movimento = " & _cod_movimento & _
                ",cod_saida_pedido = " & _cod_saida_Pedido & ",id_filial  = " & _id_filial & _
                ",num_pedido  = " & _num_pedido & _
                " WHERE cod_movimento = " & chaveCriterio1 & _
                " and id_filial = " & chaveCriterio2 & ""
            Catch ex As Exception
                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tb.Rows(posicao)
            r("cod_movimento") = _cod_movimento
            r("cod_saida_pedido") = _cod_saida_Pedido
            r("id_filial") = _id_filial
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
    Public Function existe_saida_pedido(ByVal x_num_pedido As Integer, ByVal x_id_filial As Integer) As Boolean
        Dim sql As String
        Dim tb_saida As New DataTable
        sql = "SELECT movimentomaster.cod_natureza, movimentomaster.data, " & _
        "movimentomaster.doc, movimentomaster.id_usuario, saida_pedido.cod_movimento, " & _
        "saida_pedido.id_filial, saida_pedido.num_pedido, saida_pedido.cod_saida_pedido " & _
        "FROM movimentomaster INNER JOIN " & _
        "saida_pedido ON movimentomaster.cod_movimento = saida_pedido.cod_movimento " & _
        "AND movimentomaster.id_filial = saida_pedido.id_filial " & _
        "where saida_pedido.num_pedido = " & x_num_pedido & _
        " and saida_pedido.id_filial = " & x_id_filial & ""
        d.carrega_Tabela(sql, tb_saida)
        If tb_saida.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function lista_itens() As DataTable
        Dim sql As String
        Dim tb_lista As New DataTable
        sql = "SELECT * FROM movimento " & _
        " WHERE (id_filial = " & Me.id_filial & ") AND " & _
        "(cod_Movimento = " & Me.cod_movimento & ") and status = 0"
        d.carrega_Tabela(sql, tb_lista)
        Return tb_lista
        tb_lista.Dispose()
    End Function
    Public Function conclui_movimento() As String
        Dim sql As String
        sql = "update movimentomaster set concluido = 'S' " & _
        " where cod_movimento = " & _cod_movimento & " and " & _
        "id_filial = " & _id_filial & ""
        Return d.Comando(sql, True)
    End Function
    Public Function baixa_produto(ByVal xcod_prod As Integer, ByVal xq As Integer, ByVal hist As String) As String
        Dim mov As New objMovimentoDetalhe
        Dim prod As New produtoClass
        prod.filtra(xcod_prod)
        mov.novo()
        mov.cod_lancamento = retorna_Chave("cod_lancamento", "movimento", " where id_filial = " & Me._id_filial & "")
        mov.id_filial = _id_filial
        mov.item = mov.ret_ultimo_item(_cod_movimento)
        mov.cod_movimento = _cod_movimento
        mov.cod_produto = prod.fldCod_produto
        mov.quant = xq
        mov.desconto = 0
        mov.Pvenda = prod.fldPreco_venda
        mov.descVenda = prod.fldDesconto
        mov.pUnit = prod.fldPreco_custo
        mov.estoqueFis = mov.ret_saldo_fisico(prod.fldCod_produto) + CDbl(xq)
        mov.estoqueFin = mov.estoqueFis * prod.fldPreco_custo
        If hist = "" Then
            mov.historico = "Baixa de produto do Pedido " & _num_pedido & "-" & _id_filial
        Else
            mov.historico = hist
        End If

        Return mov.Salvar()
    End Function
#End Region
End Class
