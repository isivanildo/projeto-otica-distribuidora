Public Class objPacoteCliente
#Region "Atributos"
    Private _cod_pacote As Integer
    Private _cod_filial_cliente As Object
    Private _cod_cliente As Object
    Private _concluido As Object
    Public posicao As Integer = 0
    Public max As Integer
    Public tb As New DataTable
    Public OrigemSalvar As String = ""
    Private lastPos As Integer = 0
    Private sql As String
    Dim d As New dados
    Public pacoteDet As New objPacoteClienteDetalhes
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
    Public Property concluido()
        Get
            concluido = _concluido
        End Get
        Set(ByVal value)
            _concluido = value
        End Set
    End Property
#End Region
#Region "Procedimentos"
    Public Sub New()
        Dim sql As String
        sql = "Select * from pacote_cliente where cod_pacote = 0"
        Source(sql)
    End Sub
    Public Sub filtra(ByVal xCod_cliente As Integer, ByVal xCod_filial_cliente As Integer)
        sql = "select * from pacote_cliente where cod_cliente = " & _
        xCod_cliente & " and cod_filial_cliente = " & xCod_filial_cliente & ""
        Source(sql)
    End Sub
    Public Sub filtra(ByVal xCod_cliente As Integer, ByVal xCod_filial_cliente As Integer, ByVal xCod_pacote As Integer)
        sql = "select * from pacote_cliente where cod_cliente = " & _
        xCod_cliente & " and cod_filial_cliente = " & xCod_filial_cliente & _
        " and cod_pacote = " & xCod_pacote & ""
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
            _cod_filial_cliente = tb.Rows(p)("cod_filial_cliente")
            _cod_cliente = tb.Rows(p)("cod_cliente")
            _concluido = rdTexto(tb.Rows(p)("concluido"))
        Else
            _cod_pacote = 0
            _cod_filial_cliente = 0
            _cod_cliente = 0
            _concluido = "N"
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
        If max = 0 Then
            _cod_pacote = retorna_Chave("cod_pacote", "pacote_cliente", "")
        End If
        _cod_filial_cliente = Nothing
        _cod_cliente = Nothing
        _concluido = "N"
        OrigemSalvar = "Novo" 'Define o tipo de ação ao salvar
    End Sub
    Public Function Salvar() As String
        Dim sql As String
        Dim res As String
        d.conecta()
        If OrigemSalvar = "Novo" Then
            Try
                _cod_pacote = retorna_Chave("cod_pacote", "pacote_cliente", "")
                sql = "Insert into pacote_cliente (cod_pacote,cod_filial_cliente,cod_cliente,concluido,data)" & _
                "Values(" & _
                _cod_pacote & "," & _cod_filial_cliente & "," & _cod_cliente & _
                "," & d.PStr(_concluido) & "," & d.pdtm(Now) & ")"
                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tb.NewRow
            r("cod_pacote") = _cod_pacote
            r("cod_filial_cliente") = _cod_filial_cliente
            r("cod_cliente") = _cod_cliente
            r("concluido") = rdTexto(_concluido)
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
                                " concluido = " & d.PStr(_concluido) & _
                " where cod_pacote = " & _cod_pacote & _
                " and cod_filial_cliente = " & _cod_filial_cliente & _
                " and cod_cliente = " & _cod_cliente & ""
                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tb.Rows(posicao)
            r("cod_pacote") = _cod_pacote
            r("cod_filial_cliente") = _cod_filial_cliente
            r("cod_cliente") = _cod_cliente
            r("concluido") = rdTexto(_concluido)
            OrigemSalvar = ""
            Return "OK:" & res & " registro(s) atualizado(s) com sucesso!"
        End If
    End Function
    Public Function lista_pacotes() As DataTable
        Dim tt As New DataTable
        Dim sql As String
        sql = "select * from pacote_cliente where cod_cliente = " & _
        _cod_cliente & " and cod_filial_cliente = " & _cod_filial_cliente & " order by cod_pacote desc"
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function lista_itens() As DataTable
        Dim tt As New DataTable
        pacoteDet.filtra(_cod_cliente, _cod_filial_cliente, _cod_pacote)
        tt = pacoteDet.lista_itens
        Return tt
    End Function
    Public Function Total()
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT sum(preco_desc*quantidade_contratada)+ sum(preco_surf_desc*quantidade_surf)+" & _
            "sum(preco_mont_desc*quantidade_mont)+sum(preco_trat_desc*quantidade_trat) as total FROM " & _
            "Pacote_cliente_detalhes where cod_cliente = " & _cod_cliente & " And cod_filial_cliente = " & _cod_filial_cliente & _
            " And cod_pacote = " & _cod_pacote
        'sql = "SELECT sum(Preco_desconto*quantidade_contratada)+ " & _
        '"sum(surf_desc*quantidade_contratada)+sum(quantidade_contratada*mont_desc)+sum(trat_desc*quantidade_contratada)" & _
        '" as total " & _
        '"FROM   dbo.lista_pacote_cliente(" & _cod_cliente & "," & _
        '_cod_filial_cliente & "," & _cod_pacote & ")"
        d.carrega_Tabela(sql, tt)
        If tt.Rows.Count > 0 Then
            Return rdNum(tt.Rows(0)("total"))
        Else
            Return 0
        End If
    End Function
    Public Function credito() As DataTable
        Dim tt As New DataTable
        Dim sql As String
        sql = "select * from credito_pacote where " & _
        " cod_cliente = " & _cod_cliente & _
        " and cod_filial_cliente = " & _cod_filial_cliente & _
        " and cod_pacote = " & _cod_pacote & ""
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function detalhe_movimento_item(ByVal x_cod_tabela As Integer) As DataTable
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT pedido_balcao_itens.num_pedido, Pacote_cliente_detalhes.cod_tabela, " & _
        "pedido_balcao_itens.id_filial, produtos.produto, pedido_balcao_itens.quant, " & _
        "pedido_balcao_itens.preco,pedido_balcao_itens.desconto, " & _
        "((pedido_balcao_itens.preco -(pedido_balcao_itens.preco* " & _
        "(pedido_balcao_itens.desconto/100)))* pedido_balcao_itens.quant) as pDesc," & _
        "Pacote_cliente_detalhes.cod_Pacote, pedido_balcao.data_pedido " & _
        "FROM Pacote_cliente_detalhes INNER JOIN " & _
        "pedido_balcao_itens ON Pacote_cliente_detalhes.cod_Pacote = " & _
        "pedido_balcao_itens.cod_pacote " & _
        "INNER JOIN produtos ON pedido_balcao_itens.cod_produto = " & _
        "produtos.cod_produto INNER JOIN pedido_balcao ON " & _
        "pedido_balcao_itens.num_pedido = pedido_balcao.num_pedido AND " & _
        "pedido_balcao_itens.id_filial = pedido_balcao.id_filial " & _
        "INNER JOIN lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente" & _
        " AND produtos.id_fabricante = lentes_blocos.id_fabricante AND " & _
        "Pacote_cliente_detalhes.cod_tabela = lentes_blocos.cod_tabela " & _
        "where (Pacote_cliente_detalhes.cod_Pacote = " & Me._cod_pacote & ") " & _
        " and Pacote_cliente_detalhes.cod_tabela = " & x_cod_tabela & _
        " AND ((pedido_balcao_itens.cod_status_item <> 4) AND " & _
        "(pedido_balcao_itens.cod_status_item <> 5)) " & _
        "order by data_pedido,num_pedido,pedido_balcao_itens.item"
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
#End Region
End Class
