Public Class objPedidoCompra
    Public Enum status_sugestao_pedido
        sugerido = 1
        efetuado = 2
        nao_efetuado = 3
        pedido_2 = 4
        cancelado = 5
    End Enum
    Public Enum status_item_pedido
        ok = 1
        pedido_2 = 2
        cancelado = 3
    End Enum
    Public Enum status_pedido
        Pedido_em_aberto = 1
        pedido_efetuado = 2
        pedido_chegou = 3
        pedido_em_conferencia = 4
        Nota_Lancada = 5
        pedido_cancelado = 6
    End Enum
#Region "Atributos"
    Private _cod_pedido As Integer
    Private _id_filial As Integer
    Private _cod_fornecedor As Integer
    Private _data_pedido As Object
    Private _cod_status_pedido As Integer
    Private _cod_tipo As Integer
    Private _data_recebimento As Object
    Private _cod_usuario As Integer
    Private _nota_fiscal As Object
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
    Public Property cod_pedido()
        Get
            cod_pedido = _cod_pedido
        End Get
        Set(ByVal Value)
            _cod_pedido = Value
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
    Public Property cod_fornecedor()
        Get
            cod_fornecedor = _cod_fornecedor
        End Get
        Set(ByVal Value)
            _cod_fornecedor = Value
        End Set
    End Property
    Public Property data_pedido()
        Get
            data_pedido = _data_pedido
        End Get
        Set(ByVal Value)
            _data_pedido = Value
        End Set
    End Property
    Public Property cod_status_pedido()
        Get
            cod_status_pedido = _cod_status_pedido
        End Get
        Set(ByVal Value)
            _cod_status_pedido = Value
        End Set
    End Property
    Public Property cod_tipo()
        Get
            cod_tipo = _cod_tipo
        End Get
        Set(ByVal Value)
            _cod_tipo = Value
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
    Public Property cod_usuario()
        Get
            cod_usuario = _cod_usuario
        End Get
        Set(ByVal Value)
            _cod_usuario = Value
        End Set
    End Property
    Public Property nota_fiscal()
        Get
            nota_fiscal = _nota_fiscal
        End Get
        Set(ByVal Value)
            _nota_fiscal = Value
        End Set
    End Property
#End Region
#Region "Procedimentos"
    Public Sub New()
        Dim sql As String
        sql = "select * from pedido_fornecedor " & _
        "where cod_pedido = 0"
        Source(sql)
    End Sub
    Public Sub carrega_pedido(ByVal x_cod_pedido As Integer, ByVal x_id_filial As Integer)
        Dim sql As String
        sql = "select * from pedido_fornecedor " & _
        "where cod_pedido =" & x_cod_pedido & " and " & _
        " id_filial = " & x_id_filial & ""
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
                _cod_pedido = .Rows(pos)("cod_pedido")
                _id_filial = .Rows(pos)("id_filial")
                _cod_fornecedor = .Rows(pos)("cod_fornecedor")
                _data_pedido = .Rows(pos)("data_pedido")
                _cod_status_pedido = .Rows(pos)("cod_status_pedido")
                _cod_tipo = .Rows(pos)("cod_tipo")
                _data_recebimento = .Rows(pos)("data_recebimento")
                _cod_usuario = .Rows(pos)("cod_usuario")
                _nota_fiscal = rdTexto(.Rows(pos)("nota_fiscal"))
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
        _cod_pedido = Nothing
        _id_filial = Nothing
        _cod_fornecedor = Nothing
        _data_pedido = Nothing
        _cod_status_pedido = Nothing
        _cod_tipo = Nothing
        _data_recebimento = Nothing
        _cod_usuario = Nothing
        _cod_status_pedido = 1
        _nota_fiscal = Nothing
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
                cod_pedido = chave()
                sql = "INSERT INTO pedido_fornecedor (cod_pedido,id_filial ,cod_fornecedor" & _
                ",data_pedido,cod_status_pedido,cod_tipo,data_recebimento,cod_usuario,nota_fiscal) " & _
                "VALUES(" & _
                _cod_pedido & _
                "," & _id_filial & _
                "," & _cod_fornecedor & _
                "," & d.Pdt(_data_pedido) & _
                "," & _cod_status_pedido & _
                "," & _cod_tipo & _
                "," & d.Pdt(_data_recebimento) & _
                "," & cod_usuario & _
                "," & d.PStr(_nota_fiscal) & ")"
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
            r("cod_pedido") = _cod_pedido
            r("id_filial") = _id_filial
            r("cod_fornecedor") = _cod_fornecedor
            r("data_pedido") = wrData(_data_pedido)
            r("cod_status_pedido") = _cod_status_pedido
            r("cod_tipo") = _cod_tipo
            r("data_recebimento") = wrData(_data_recebimento)
            r("cod_tipo") = _cod_usuario
            r("nota_fiscal") = _nota_fiscal

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
                sql = "UPDATE pedido_fornecedor SET " & _
                " cod_fornecedor = " & _cod_fornecedor & _
                ",data_pedido = " & d.Pdt(_data_pedido) & _
                ",cod_status_pedido = " & _cod_status_pedido & _
                ",cod_tipo = " & _cod_tipo & _
                ",data_recebimento = " & d.Pdt(_data_recebimento) & _
                ",cod_usuario = " & _cod_usuario & _
                ",nota_fiscal = " & d.PStr(_nota_fiscal) & _
                " Where cod_pedido = " & Me._cod_pedido & _
                " and id_filial = " & Me._id_filial & ""
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
            r = tb.Rows(posicao)
            r("cod_pedido") = _cod_pedido
            r("id_filial") = _id_filial
            r("cod_fornecedor") = _cod_fornecedor
            r("data_pedido") = wrData(_data_pedido)
            r("cod_status_pedido") = _cod_status_pedido
            r("cod_tipo") = _cod_tipo
            r("data_recebimento") = wrData(_data_recebimento)
            r("cod_tipo") = _cod_usuario
            r("nota_fiscal") = _nota_fiscal
            OrigemSalvar = ""
            Return res & " registro(s) atualizado(s) com sucesso!"
        End If
    End Function
    Public Function deletar(ByVal x_cod_pedido As Integer, ByVal x_id_filial As Integer)
        Dim cmd As New SqlClient.SqlCommand
        Dim res As String
        d.conecta()
        cmd.Connection = d.con
        cmd.CommandText = "Delete from pedido_fornecedor where cod_pedido = " & x_cod_pedido & _
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
        Return retorna_Chave("cod_pedido", "pedido_fornecedor", " where id_filial = " & _id_filial & "")
    End Function
    Public Function insere_item(ByVal X_cod_pedido As Integer, _
    ByVal x_id_filial As Integer, ByVal x_cod_produto As Integer, _
    ByVal x_quantidade As Double, ByVal x_Preco_compra As Double, ByVal x_desconto_compra As Double, _
    ByVal x_status_item As Integer, ByVal x_doc_cliente As Object) As String
        Dim sql As String
        Dim item As Integer
        item = retorna_Chave("item", "pedido_fornecedor_itens", " Where cod_pedido = " _
        & X_cod_pedido & " and id_filial = " & x_id_filial & "")
        sql = "INSERT INTO pedido_fornecedor_itens (cod_pedido,id_filial,item,cod_produto" & _
        ",quantidade,Preco_compra,desconto_compra,cod_status,doc_cliente) VALUES(" & _
        X_cod_pedido & "," & x_id_filial & "," & item & "," & x_cod_produto & _
        "," & d.cdin(x_quantidade) & _
        "," & d.cdin(x_Preco_compra) & _
        "," & d.cdin(x_desconto_compra) & _
        "," & x_status_item & _
        "," & d.PStr(x_doc_cliente) & ")"
        Return d.Comando(sql, True)
    End Function
    Public Function lista_itens() As DataTable
        Dim sql As String
        Dim tb As New DataTable
        sql = "SELECT pedido_fornecedor_itens.item,lentes_tabela.cod_tabela, " & _
        "produtos.produto, produtos.cod_barra,pedido_fornecedor_itens.quantidade, " & _
        "((pedido_fornecedor_itens.Preco_compra)-(pedido_fornecedor_itens.Preco_compra*(" & _
        "pedido_fornecedor_itens.desconto_compra/100))) as Preco,produtos.cod_produto," & _
        "pedido_fornecedor_itens.Preco_compra,pedido_fornecedor_itens.desconto_compra," & _
        "(((pedido_fornecedor_itens.Preco_compra)-(pedido_fornecedor_itens.Preco_compra*(" & _
        "pedido_fornecedor_itens.desconto_compra/100)))*pedido_fornecedor_itens.quantidade) " & _
        "as Total, pedido_fornecedor_itens.doc_cliente FROM pedido_fornecedor_itens " & _
        "INNER Join produtos ON pedido_fornecedor_itens.cod_produto = produtos.cod_produto " & _
        "INNER JOIN lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente AND " & _
        "produtos.id_fabricante = lentes_blocos.id_fabricante INNER JOIN " & _
        "lentes_tabela ON lentes_blocos.cod_tabela = lentes_tabela.cod_tabela " & _
        "WHERE (pedido_fornecedor_itens.cod_pedido = " & Me._cod_pedido & ") " & _
        "AND (pedido_fornecedor_itens.id_filial = " & Me._id_filial & ")" & _
        " order by pedido_fornecedor_itens.item"

        d.carrega_Tabela(sql, tb)
        Return tb
    End Function
    Public Function lista_atendidos() As DataTable
        Dim sql As String
        Dim tb As New DataTable
        sql = "SELECT lentes_tabela.cod_tabela, produtos.produto,produtos.cod_barra," & _
        "produtos.cod_produto, pedido_fornecedor_itens.cod_status,pedido_fornecedor_itens.item," & _
        "SUM(pedido_fornecedor_itens.quantidade) AS quant, " & _
        "SUM(pedido_fornecedor_itens.atendido) AS Atend " & _
        "FROM  pedido_fornecedor_itens INNER JOIN " & _
        "produtos ON pedido_fornecedor_itens.cod_produto = produtos.cod_produto INNER JOIN " & _
        "lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente AND " & _
        "produtos.id_fabricante = lentes_blocos.id_fabricante INNER JOIN " & _
        "lentes_tabela ON lentes_blocos.cod_tabela = lentes_tabela.cod_tabela " & _
       "WHERE (pedido_fornecedor_itens.cod_pedido = " & Me._cod_pedido & ") " & _
        "AND (pedido_fornecedor_itens.id_filial = " & Me._id_filial & ") " & _
        "GROUP BY lentes_tabela.cod_tabela, produtos.produto,produtos.cod_barra," & _
        "produtos.cod_produto,pedido_fornecedor_itens.cod_status,pedido_fornecedor_itens.item " & _
        "ORDER BY pedido_fornecedor_itens.item,PRODUTOS.PRODUTO"
        d.carrega_Tabela(sql, tb)
        Return tb
        tb.Dispose()
    End Function
    Public Function lista_Pedido_x_OS() As DataTable
        Dim sql As String
        Dim tb As New DataTable
        sql = "SELECT pedido_fornecedor_itens.item,pedido_fornecedor_itens.cod_produto, pedido_fornecedor_itens.quantidade, " & _
        "pedido_fornecedor_itens.atendido, OS.id_filial AS Filial_os, OS.cod_os, " & _
        "OS.cod_cliente, OS.doc_cliente, produtos.cod_barra, " & _
        "produtos.produto, pedido_fornecedor_os.num_pedido " & _
        "FROM pedido_fornecedor_itens INNER JOIN " & _
        "pedido_fornecedor_os ON pedido_fornecedor_itens.id_filial = " & _
        "pedido_fornecedor_os.id_filial AND " & _
        "pedido_fornecedor_itens.cod_pedido = pedido_fornecedor_os.cod_pedido AND " & _
        "pedido_fornecedor_itens.item = pedido_fornecedor_os.item INNER JOIN " & _
        "OS ON pedido_fornecedor_os.id_filial = OS.id_filial AND " & _
        "pedido_fornecedor_os.cod_os = OS.cod_os INNER JOIN " & _
        "produtos ON pedido_fornecedor_itens.cod_produto = produtos.cod_produto " & _
        "WHERE (pedido_fornecedor_itens.cod_pedido =" & Me.cod_pedido & ") AND " & _
        "(pedido_fornecedor_itens.id_filial = " & Me.id_filial & ") " & _
        " Order by filial_os,cod_os,num_pedido"
        d.carrega_Tabela(sql, tb)
        Return tb
        tb.Dispose()
    End Function
    Public Function lista_Pedido_x_Balcao() As DataTable
        Dim sql As String
        Dim tb As New DataTable
        sql = "SELECT pedido_fornecedor_itens.cod_produto, " & _
        "pedido_fornecedor_itens.quantidade, pedido_fornecedor_itens.atendido, " & _
        "produtos.cod_barra, produtos.produto, " & _
        "pedido_fornecedor_os.num_pedido " & _
        "FROM  pedido_fornecedor_itens INNER JOIN " & _
        "pedido_fornecedor_os ON pedido_fornecedor_itens.id_filial = " & _
        "pedido_fornecedor_os.id_filial AND " & _
        "pedido_fornecedor_itens.cod_pedido = pedido_fornecedor_os.cod_pedido " & _
        "AND pedido_fornecedor_itens.item = pedido_fornecedor_os.item INNER JOIN " & _
        "produtos ON pedido_fornecedor_itens.cod_produto = produtos.cod_produto " & _
        "WHERE (pedido_fornecedor_itens.cod_pedido =" & Me.cod_pedido & ") AND " & _
        "(pedido_fornecedor_itens.id_filial = " & Me.id_filial & ") " & _
        " AND (pedido_fornecedor_os.num_pedido <> 0) " & _
        " ORDER BY pedido_fornecedor_os.num_pedido"
        d.carrega_Tabela(sql, tb)
        Return tb
        tb.Dispose()
    End Function
    Public Function listar_nao_atendidos_auto() As DataTable
        Dim sql As String
        Dim tb As New DataTable
        sql = "SELECT pedido_fornecedor_itens.cod_produto, pedido_fornecedor_itens.item, " & _
        "pedido_fornecedor_os.cod_pedido, sugestao_pedido_auto_os.cod_os, " & _
        "sugestao_pedido_auto_os.id_filial, pedido_fornecedor_itens.atendido " & _
        "FROM pedido_fornecedor_itens INNER JOIN " & _
        "sugestao_pedido_auto_os ON pedido_fornecedor_itens.id_filial = " & _
        "sugestao_pedido_auto_os.id_filial INNER JOIN " & _
        "pedido_fornecedor_os ON pedido_fornecedor_itens.id_filial " & _
        "= pedido_fornecedor_os.id_filial AND " & _
        "pedido_fornecedor_itens.cod_pedido = pedido_fornecedor_os.cod_pedido AND " & _
        "pedido_fornecedor_itens.item = pedido_fornecedor_os.item AND " & _
        "sugestao_pedido_auto_os.cod_os = pedido_fornecedor_os.cod_os AND " & _
        "sugestao_pedido_auto_os.id_filial = pedido_fornecedor_os.id_filial AND " & _
        "sugestao_pedido_auto_os.id = pedido_fornecedor_os.id " & _
        " WHERE (pedido_fornecedor_itens.cod_pedido = " & Me._cod_pedido & _
        ") And (pedido_fornecedor_itens.id_filial = " & Me._id_filial & ")" & _
        " and (pedido_fornecedor_itens.atendido = 0) and " & _
        "(pedido_fornecedor_itens.cod_status = 1)"
        d.carrega_Tabela(sql, tb)
        Return tb
        tb.Dispose()
    End Function
    Public Function listar_nao_atendidos_comum() As DataTable
        Dim sql As String
        Dim tb As New DataTable
        sql = "SELECT     cod_produto, item, atendido FROM pedido_fornecedor_itens " & _
        " WHERE (cod_pedido = " & Me._cod_pedido & ") AND (id_filial = " & Me._id_filial & ") AND (atendido = 0) AND (cod_status = 1)"
        MsgBox(sql)
        d.carrega_Tabela(sql, tb)
        Return tb
        tb.Dispose()
    End Function
    Public Function Atualizar_status_item_auto(ByVal x_item As Integer, ByVal x_id_filial As Integer, ByVal x_cod_pedido As Integer, ByVal status As status_sugestao_pedido)
        Dim sql As String
        sql = "UPDATE sugestao_pedido_auto_os set cod_status = " & status & _
        " FROM  pedido_fornecedor_itens INNER JOIN " & _
        "sugestao_pedido_auto_os ON pedido_fornecedor_itens.id_filial = " & _
        "sugestao_pedido_auto_os.id_filial INNER JOIN " & _
        "pedido_fornecedor_os ON pedido_fornecedor_itens.id_filial = " & _
        "pedido_fornecedor_os.id_filial AND " & _
        "pedido_fornecedor_itens.cod_pedido = pedido_fornecedor_os.cod_pedido " & _
        "AND pedido_fornecedor_itens.item = pedido_fornecedor_os.item AND " & _
        "sugestao_pedido_auto_os.cod_os = pedido_fornecedor_os.cod_os AND " & _
        "sugestao_pedido_auto_os.id_filial = pedido_fornecedor_os.id_filial AND " & _
        "sugestao_pedido_auto_os.id = pedido_fornecedor_os.id " & _
        "WHERE (pedido_fornecedor_itens.cod_pedido = " & x_cod_pedido & ") AND " & _
        "(pedido_fornecedor_itens.id_filial = " & x_id_filial & ") AND " & _
        "(pedido_fornecedor_itens.item = " & x_item & ")"
        Return d.Comando(sql, True)
    End Function
    Public Function item_atendido(ByVal x_cod_prod) As String 'Retorna um caractere dizendo se
        'o item existe ou não: E quando existe e N quando não acompanhado pelo numero do item.
        'Ex E1, E existe item 1 ou N não existe. 
        'Caso o produto exista mas já tenha sido atendido, retorna apenas E
        'Caso o status do item seja diferente de OK, retorna S acompanhado do status
        'Ex: S2, Existe, com status 2 
        Dim sql As String
        Dim tb_x As New DataTable
        Dim dv As New DataView
        sql = "SELECT  item,cod_produto, quantidade, atendido,cod_status " & _
        "FROM pedido_fornecedor_itens WHERE " & _
        "(cod_produto = " & x_cod_prod & ") and (cod_pedido = " & Me._cod_pedido & _
        ") and (id_filial = " & Me._id_filial & ")"
        d.carrega_Tabela(sql, tb_x)
        dv.Table = tb_x
        If tb_x.Rows.Count = 0 Then
            Return "N"
        End If
        dv.RowFilter = "(quantidade > atendido)"
        If dv.Count = 0 Then
            Return "E"
        End If
        If dv.Count > 0 And dv(0)("cod_status") = 1 Then
            Return "E" & dv.Item(0)("item")
        End If
        If dv.Count > 0 And dv(0)("cod_status") <> 1 Then
            Return "S" & dv.Item(0)("item")
        End If
    End Function
    Public Function atende_pedido(ByVal x_item As Integer) As String
        Dim sql As String
        sql = "update pedido_fornecedor_itens set atendido = " & _
        (quant_atend_item(x_item) + 1) & _
        "where " & _
        "(cod_pedido = " & Me._cod_pedido & ") and (id_filial = " & _
        Me._id_filial & ") and (item = " & x_item & ")"
        Return d.Comando(sql, True)
    End Function
    Public Function quant_atend_item(ByVal x_item As Integer) As Integer
        Dim sql As String
        Dim tb_x As New DataTable
        sql = "select atendido from pedido_fornecedor_itens where " & _
        "(cod_pedido = " & Me._cod_pedido & ") and (id_filial = " & _
        Me._id_filial & ") and (item = " & x_item & ")"
        d.carrega_Tabela(sql, tb_x)
        Return tb_x.Rows(0)(0)
    End Function
    Public Function status_item(ByVal x_item As Integer, ByVal status As status_item_pedido) As String
        Dim sql As String
        sql = "update pedido_fornecedor_itens set cod_status = " & status & _
        " where (cod_pedido = " & Me._cod_pedido & ") and (id_filial = " & _
        Me._id_filial & ") and (item = " & x_item & ")"
        Return d.Comando(sql, True)
    End Function
    Public Function retorna_status_item(ByVal x_item As Integer) As DataRow
        Dim sql As String
        Dim t As New DataTable
        sql = "SELECT pedido_fornecedor_itens.cod_status, status_item_pedido_forn.status " & _
        "FROM pedido_fornecedor_itens INNER JOIN " & _
        "status_item_pedido_forn ON pedido_fornecedor_itens.cod_status = " & _
        "status_item_pedido_forn.cod_status" & _
        " where (cod_pedido = " & Me._cod_pedido & ") and (id_filial = " & _
        Me._id_filial & ") and (item = " & x_item & ")"
        d.carrega_Tabela(sql, t)
        Try
            Return t.Rows(0)
        Catch ex As Exception

        End Try
    End Function
    Public Function exclui_item(ByVal x_item As Integer) As String
        Dim sql As String
        Dim r As String
        sql = "Delete from pedido_fornecedor_itens " & _
        " where (cod_pedido = " & Me._cod_pedido & ") and (id_filial = " & _
        Me._id_filial & ") and (item = " & x_item & ")"
        r = d.Comando(sql, True)
        Return r
    End Function
    Public Function Razao_faturamento()
        Dim tt As New DataTable
        Dim sql As String
        Dim strResult As String = ""
        sql = "SELECT Fornecedor, Razao_faturamento, codigo_faturamento " & _
        "FROM  fornecedor where cod_fornecedor = " & _cod_fornecedor & ""
        d.carrega_Tabela(sql, tt)
        Try
            strResult = tt.Rows(0)("Razao_faturamento")
            If IsDBNull(tt.Rows(0)("codigo_faturamento")) = False Then
                strResult = strResult & " Código:" & tt.Rows(0)("codigo_faturamento")
            End If
        Catch ex As Exception

        End Try
        Return strResult
    End Function
    Public Function itens_xml_essilor() As String
        Dim tt As New DataTable
        Dim tsql As String
        Dim r As DataRow
        Dim barra As String
        Dim q As Integer
        Dim arqXML As String = "<pedido>" & vbCrLf & _
                    "<cliente>63882898000199</cliente>" & vbCrLf & _
                    "<filial>" & vbCrLf & _
                    "<codigo>MRJ</codigo>"
        tsql = "SELECT produtos.cod_barra, sum(pedido_fornecedor_itens.quantidade) as quantidade " & _
        " FROM pedido_fornecedor_itens INNER JOIN produtos ON pedido_fornecedor_itens.cod_produto " & _
        "= produtos.cod_produto where (pedido_fornecedor_itens.cod_pedido = " & Me._cod_pedido & ") " & _
        "  and (pedido_fornecedor_itens.id_filial = " & Me._id_filial & ") " & _
        " group by produtos.cod_barra"
        d.carrega_Tabela(tsql, tt)
        For Each r In tt.Rows
            If arqXML = "" Then
                arqXML = "<item>" & vbCrLf & _
                "<opc>" & adiciona_zeros(r("cod_barra"), 10) & "</opc>" & vbCrLf & _
                "<qtd>" & r("quantidade") & "</qtd>" & vbCrLf & _
                "</item>"
            Else
                arqXML = arqXML & vbCrLf & _
                "<item>" & vbCrLf & _
                "<opc>" & adiciona_zeros(r("cod_barra"), 10) & "</opc>" & vbCrLf & _
                "<qtd>" & r("quantidade") & "</qtd>" & vbCrLf & _
                "</item>"
            End If
        Next
        arqXML = arqXML & vbCrLf & _
        "</filial>" & vbCrLf & _
        "</pedido>"
        Return arqXML
    End Function
#End Region

End Class
