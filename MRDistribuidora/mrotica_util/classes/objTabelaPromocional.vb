Imports mrotica_util
Public Class objTabelaPromocional
#Region "Atributos"
    Private _cod_tabela_promocional As Integer
    Private _id_filial As Integer
    Private _tabela_promocional As Object
    Private _data_inicio As Object
    Private _data_termino As Object
    Public posicao As Integer = 0
    Public max As Integer
    Dim tabela As New DataTable
    Public Shadows OrigemSalvar As String = ""
    Private lastPos As Integer = 0
    Private sql As String
    Dim prod As New produtoClass
    Dim d As New dados
    Dim énovo As Boolean
    Dim conf As New config
#End Region
#Region "GET SET"
    Public Property cod_tabela_promocional()
        Get
            cod_tabela_promocional = _cod_tabela_promocional
        End Get
        Set(ByVal Value)
            _cod_tabela_promocional = Value
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
    Public Property tabela_promocional()
        Get
            tabela_promocional = _tabela_promocional
        End Get
        Set(ByVal Value)
            _tabela_promocional = Value
        End Set
    End Property
    Public Property data_inicio()
        Get
            data_inicio = _data_inicio
        End Get
        Set(ByVal Value)
            _data_inicio = Value
        End Set
    End Property
    Public Property data_termino()
        Get
            data_termino = _data_termino
        End Get
        Set(ByVal Value)
            _data_termino = Value
        End Set
    End Property
#End Region
#Region "Procedimentos"
    Public Sub New()
        Dim sql As String
        sql = "Select * from tabela_promocional where cod_tabela_promocional = 0"
        Source(sql)
    End Sub
    Public Sub filtra(ByVal x_cod_tabela_prom As Integer, ByVal x_id_filial As Integer)
        Dim sql As String
        sql = "Select * from tabela_promocional where cod_tabela_promocional = " & x_cod_tabela_prom & _
        " and id_filial = " & x_id_filial & ""
        Source(sql)
    End Sub
    Public Sub Source(ByVal iSql As String)
        sql = iSql
        Me.refreshData()
    End Sub
    Public Sub refreshData()
        d.carrega_Tabela(sql, tabela)
        max = tabela.Rows.Count
        Me.primeiro()
    End Sub
    Public Sub Registro(ByVal pos As Integer) 'Move o Registro para a posição indicada
        Dim p As Integer = pos
        If p <= 0 Then p = 0
        If p > max Then p = max
        posicao = p
        If max > 0 Then
            _cod_tabela_promocional = tabela.Rows(p)("cod_tabela_promocional")
            _id_filial = tabela.Rows(p)("id_filial")
            _tabela_promocional = tabela.Rows(p)("tabela_promocional")
            _data_inicio = rdData(tabela.Rows(p)("data_inicio"))
            _data_termino = rdData(tabela.Rows(p)("data_termino"))
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
        énovo = False
    End Sub
#End Region
#Region "Funções"
    Public Sub novo()
        lastPos = posicao 'guarda a posição do último Registro
        'Zera Variáveis
        _cod_tabela_promocional = Nothing
        _id_filial = conf.Filial
        _tabela_promocional = Nothing
        _data_inicio = Nothing
        _data_termino = Nothing
        énovo = True  'Define o tipo de ação ao salvar
    End Sub
    Public Function Salvar() As String
        Dim sql As String
        Dim res As String
        d.conecta()
        If énovo = True Then
            Try
                _cod_tabela_promocional = retorna_Chave("cod_tabela_promocional", "tabela_promocional", " Where id_filial = " & conf.Filial & "")
                sql = "INSERT INTO tabela_promocional " & _
                "(cod_tabela_promocional " & _
                ",id_filial " & _
                ",tabela_promocional " & _
                ",data_inicio " & _
                ",data_termino) VALUES(" & _
                _cod_tabela_promocional & _
                "," & _id_filial & _
                "," & d.PStr(_tabela_promocional) & _
                "," & d.Pdt(_data_inicio) & _
                "," & d.Pdt(_data_termino) & ")"
                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tabela.NewRow
            r("cod_tabela_promocional") = _cod_tabela_promocional
            r("id_filial") = _id_filial
            r("tabela_promocional") = rdTexto(_tabela_promocional)
            r("data_inicio") = rdData(_data_inicio)
            r("data_termino") = rdData(_data_termino)
            tabela.Rows.Add(r)
            max = max + 1
            If max = 1 Then
                posicao = 0
            Else
                posicao = max - 1
            End If
            énovo = False
            Return res & " registro(s) adicionado(s) com sucesso!"
        End If
        If énovo = False Then
            Try
                sql = "UPDATE tabela_promocional SET tabela_promocional = " & d.PStr(_tabela_promocional) & _
                ",data_inicio = " & d.Pdt(_data_inicio) & ",data_termino = " & d.Pdt(_data_termino) & _
                " WHERE cod_tabela_promocional = " & _cod_tabela_promocional & " and " & _
                "id_filial = " & _id_filial & ""
                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tabela.Rows(posicao)
            r("cod_tabela_promocional") = _cod_tabela_promocional
            r("id_filial") = _id_filial
            r("tabela_promocional") = rdTexto(_tabela_promocional)
            r("data_inicio") = rdData(_data_inicio)
            r("data_termino") = rdData(_data_termino)
            énovo = False
            Return res & " registro(s) atualizado(s) com sucesso!"
        End If
    End Function
    Public Function insere_produto(ByVal x_cod_tabela As Integer, ByVal x_desconto As Double) As String
        Dim sql As String
        sql = "INSERT INTO tabela_promocional_itens " & _
            "(item " & _
            ",cod_tabela_promocional " & _
            ",id_filial " & _
            ",cod_tabela " & _
            ",desconto) VALUES " & _
           "(" & retorna_Chave("item", "tabela_promocional_itens", " Where cod_tabela_promocional = " & _
           _cod_tabela_promocional & " and id_filial = " & _id_filial & "") & _
           "," & _cod_tabela_promocional & _
           "," & _id_filial & _
           "," & x_cod_tabela & _
           "," & d.cdin(x_desconto) & ")"
        Return d.Comando(sql, True)
    End Function
    Public Function insere_cliente(ByVal x_cod_cliente As Integer, ByVal x_cod_filial_cliente As Integer) As String
        Dim sql As String
        sql = "INSERT INTO tabela_promocional_clientes " & _
           "(cod_tabela_promocional " & _
           ",id_filial " & _
           ",cod_cliente " & _
           ",cod_filial_cliente) VALUES(" & _
            _cod_tabela_promocional & _
           "," & _id_filial & _
           "," & x_cod_cliente & _
           "," & x_cod_filial_cliente & ")"
        Return d.Comando(sql, True)
    End Function
    Public Function lista_produtos() As DataTable
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT tabela_promocional_itens.cod_tabela, lentes_blocos.nome_lente, " &
        "lentes_blocos.preco_venda, tabela_promocional_itens.desconto, " &
        "(lentes_blocos.preco_venda*(tabela_promocional_itens.desconto/100)) as valor_desconto, " &
        "(lentes_blocos.preco_venda - " &
        "(lentes_blocos.preco_venda*(tabela_promocional_itens.desconto/100))) as valor_c_desconto " &
        "FROM tabela_promocional_itens INNER JOIN " &
        "lentes_blocos ON tabela_promocional_itens.cod_tabela = lentes_blocos.cod_tabela " &
        "WHERE (tabela_promocional_itens.cod_tabela_promocional = " & _cod_tabela_promocional &
        ") AND (tabela_promocional_itens.id_filial = " & _id_filial & ")"
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function lista_clientes() As DataTable
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT  cliente.cod_filial_cliente,cliente.cod_cliente,cliente.nome_cliente, tabela_promocional_clientes.cod_filial_cliente, " & _
        "tabela_promocional_clientes.cod_cliente FROM tabela_promocional_clientes INNER JOIN " & _
        "cliente ON tabela_promocional_clientes.cod_filial_cliente = cliente.cod_filial_cliente AND " & _
        "tabela_promocional_clientes.cod_cliente = cliente.cod_cliente " & _
        "WHERE     (tabela_promocional_clientes.cod_tabela_promocional = " & _cod_tabela_promocional & ")" & _
        "AND (tabela_promocional_clientes.id_filial = " & _id_filial & ")"
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function lista_tabelas() As DataTable
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT  * from tabela_promocional order by data_inicio"
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function

    Public Function existe_produto(ByVal x_cod_tabela As Integer) As Boolean
        Dim sql As String
        Dim tt As New DataTable
        sql = "Select cod_tabela from tabela_promocional_itens where " & _
        "cod_tabela = " & x_cod_tabela & " and cod_tabela_promocional = " & _
        _cod_tabela_promocional & " and id_filial = " & _id_filial & ""
        d.carrega_Tabela(sql, tt)
        If tt.Rows.Count = 0 Then Return False Else Return True
    End Function
    Public Function atualiza_produto(ByVal x_cod_tabela As Integer, ByVal x_desconto As Double) As String
        Dim sql As String
        Dim tt As New DataTable
        sql = "update tabela_promocional_itens set desconto = " & d.cdin(x_desconto) & " where " & _
        "cod_tabela = " & x_cod_tabela & " and cod_tabela_promocional = " & _
        _cod_tabela_promocional & " and id_filial = " & _id_filial & ""
        Return d.Comando(sql, True)
    End Function
    Public Function Exclui_produto(ByVal x_cod_tabela As Integer) As String
        Dim sql As String
        Dim tt As New DataTable
        sql = "Delete from tabela_promocional_itens where " & _
        "cod_tabela = " & x_cod_tabela & " and cod_tabela_promocional = " & _
        _cod_tabela_promocional & " and id_filial = " & _id_filial & ""
        Return d.Comando(sql, True)
    End Function
    Public Function Exclui_cliente(ByVal x_filial_cliente As Integer, ByVal x_cod_cliente As Integer) As String
        Dim sql As String
        Dim tt As New DataTable
        sql = "Delete from tabela_promocional_clientes where " & _
        "cod_cliente = " & x_cod_cliente & "and cod_filial_cliente = " & _
        x_filial_cliente & " and cod_tabela_promocional = " & _
        _cod_tabela_promocional & " and id_filial = " & _id_filial & ""
        Return d.Comando(sql, True)
    End Function
    Public Function desconto(ByVal x_cod_tabela As Integer, ByVal xdi As Date, ByVal xdf As Date, ByVal x_Fil_cliente As Integer, ByVal x_cod_cliente As Integer) As Double
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT tabela_promocional_itens.desconto " & _
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
        d.carrega_Tabela(sql, tt)
        If tt.Rows.Count = 0 Then
            Return 0
        Else
            Return rdNum(tt.Rows(0)(0))
        End If
    End Function
#End Region
End Class
