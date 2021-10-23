Public Class objLenteContato
#Region "Atributos"
    Private _cod_produto As Integer
    Private _base As Object
    Private _esf As Object
    Private _cil As Object
    Private _barra As Object
    Public posicao As Integer = 0
    Public max As Integer
    Public chaveCriterio As Object
    Public tabela As New DataTable
    Public OrigemSalvar As String = ""
    Private lastPos As Integer = 0
    Private sql As String
    Dim d As New dados
    Public Enum tiposalvar
        Normal = 1
        Transaction = 2
    End Enum
#End Region
#Region "GET SET"
    Public Property cod_produto() As Integer
        Get
            cod_produto = _cod_produto
        End Get
        Set(ByVal Value As Integer)
            _cod_produto = Value
        End Set
    End Property
    Public Property base() As Double
        Get
            base = _base
        End Get
        Set(ByVal Value As Double)
            _base = Value
        End Set
    End Property
    Public Property barra()
        Get
            barra = _barra
        End Get
        Set(ByVal Value)
            _barra = Value
        End Set
    End Property
    Public Property esf()
        Get
            esf = _esf
        End Get
        Set(ByVal Value)
            _esf = Value
        End Set
    End Property
    Public Property cil()
        Get
            cil = _cil
        End Get
        Set(ByVal Value)
            _cil = Value
        End Set
    End Property
#End Region
#Region "Procedimentos"
    Public Sub New()
        Dim sql As String
        sql = "Select produtos.cod_produto, lente_contato.Base," & _
        "lente_contato.esf,lente_contato.cil,produtos.cod_barra from lente_contato " & _
        "inner JOIN produtos on lente_contato.cod_produto =" & _
        "produtos.cod_produto " & _
        "where produtos.cod_produto = 0"
        Source(sql)
    End Sub
    Public Sub New(ByVal id_fab, ByVal id_lente)
        lista_blocos(id_fab, id_lente)
    End Sub
    Public Sub Source(ByVal iSql As String)
        sql = iSql
        Me.refreshData()
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
            _cod_produto = tabela.Rows(p)("cod_produto")
            _base = tabela.Rows(p)("base")
            _barra = rdNum(tabela.Rows(p)("cod_barra"))
            _esf = tabela.Rows(p)("esf")
            _cil = tabela.Rows(p)("cil")
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
        _cod_produto = 0
        _base = Nothing
        _barra = Nothing
        _esf = Nothing
        _cil = Nothing
        OrigemSalvar = "Novo" 'Define o tipo de ação ao salvar
    End Function
    Public Function Salvar(ByVal tipo As tiposalvar) As String
        Dim sql As String
        Dim res As String 'Quantidade de registros afetados
        d.conecta()
        If OrigemSalvar = "Novo" Then
            Try
                sql = "Insert into lente_contato(cod_produto,base,esf,cil)" & _
                "Values(" & _
                _cod_produto & "," & d.cdin(_base) & "," & _
                d.cdin(_esf) & "," & d.cdin(_cil) & ")"
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
            r = tabela.NewRow
            r("cod_produto") = wrNum(_cod_produto)
            r("base") = wrNum(_base)
            r("esf") = wrNum(_esf)
            r("cil") = wrNum(_cil)
            tabela.Rows.Add(r)
            max = max + 1
            If max = 1 Then
                posicao = 0
            Else
                posicao = max - 1
            End If
            OrigemSalvar = ""
            If tipo = tiposalvar.Normal Then
                Return "OK:" & res & " registro(s) adicionado(s) com sucesso!"
            Else
                Return res
            End If
        End If
        If Me.OrigemSalvar = "Editar" Then
            Try
                sql = "Update lente_contato set " & _
                "base = " & d.cdin(_base) & _
                ",esf = " & d.cdin(_esf) & _
                ",cil = " & d.cdin(_cil) & _
                " where cod_produto = " & _cod_produto & ""
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
            r = tabela.Rows(posicao)
            r("base") = wrNum(_base)
            r("cod_barra") = wrNum(_barra)
            r("esf") = wrNum(_esf)
            r("cil") = wrNum(cil)
            OrigemSalvar = ""
            If tipo = tiposalvar.Normal Then
                Return "OK:" & res & " registro(s) atualizado(s) com sucesso!"
            Else
                Return res
            End If
        End If
    End Function
    Public Function deletar(ByVal id_prod As Integer)
        Dim res As String
        Dim sql As String
        Dim trans As New objSqlTrans
        d.conecta()
        If id_prod = 0 Then
            Return "Produto não existe"
            Exit Function
        End If
        sql = "Delete from lente_contato where cod_produto = " & id_prod & ""
        trans.insere_instrucao(sql)
        sql = "Delete from produtos where cod_produto = " & id_prod & ""
        trans.insere_instrucao(sql)

        Try
            res = d.executa_transaction(trans.instrucoes, True)
        Catch ex As Exception
        End Try
        Me.refreshData()
        Me.primeiro()
        Return res & " Registros foram apagados!"
    End Function
    Public Function limpar() As String
        Dim res As String
        Dim sql As String
        Dim id_prod As String
        Dim i, m As Integer
        Dim trans As New objSqlTrans
        d.conecta()
        i = 0
        m = max
        While i < max
            Me.Registro(i)
            id_prod = Me._cod_produto
            sql = "Delete from lente_contato where cod_produto = " & id_prod & ""
            trans.insere_instrucao(sql)
            sql = "Delete from produtos where cod_produto = " & id_prod & ""
            trans.insere_instrucao(sql)
            i = i + 1
        End While
        Try
            res = d.executa_transaction(trans.instrucoes, True)
        Catch ex As Exception
        End Try
        Me.refreshData()
        Me.primeiro()
        Return res & " Registros foram apagados!"
    End Function
    Public Function lista_blocos(ByVal id_fabricante As Integer, ByVal id_lente As Integer) As DataTable
        Dim tt As New DataTable
        sql = "Select lente_contato.Base," & _
        "produtos.cod_produto,produtos.cod_barra," & _
        "lente_contato.esf, lente_contato.cil from lentes_blocos " & _
        "inner JOIN produtos on lentes_blocos.cod_lente =" & _
        "produtos.cod_lente and lentes_blocos.id_fabricante = " & _
        "produtos.id_fabricante " & _
        "inner join lente_contato on produtos.cod_produto = lente_contato.Cod_produto " & _
        "where lentes_blocos.id_fabricante = " & id_fabricante & " and " & _
        "lentes_blocos.cod_lente = " & id_lente & _
        " ORDER BY lente_contato.Base DESC ," & _
        "lente_contato.esf DESC, lente_contato.cil ASC"
        Source(sql)
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function existe_base_diop(ByVal x_base As Double, ByVal x_tabela As Integer _
                                     , ByVal x_esf As Double, ByVal x_cil As Double) As Boolean
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "SELECT lente_contato.Base " & _
        ", lentes_blocos.cod_tabela  " & _
        "FROM lente_contato  INNER JOIN produtos ON lente_contato.cod_produto " & _
        "= produtos.cod_produto INNER JOIN " & _
        "lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente AND " & _
        "produtos.id_fabricante = lentes_blocos.id_fabricante " & _
        "WHERE (lente_contato.Base =" & d.cdin(x_base) & ") " & _
        " AND  (lentes_blocos.cod_tabela =" & x_tabela & ") and (" & _
        "lente_contato.esf = " & d.cdin(x_esf) & ") and (lente_contato.cil = " & d.cdin(x_cil) & ")"
        d.carrega_Tabela(tsql, tt)
        If tt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function confirma_base_diop(ByVal x_base As Double, ByVal x_cod_prod As Integer _
                                     , ByVal x_esf As Double, ByVal x_cil As Double) As Boolean
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "SELECT lente_contato.Base " & _
        ", lentes_blocos.cod_tabela  " & _
        "FROM lente_contato  INNER JOIN produtos ON lente_contato.cod_produto " & _
        "= produtos.cod_produto INNER JOIN " & _
        "lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente AND " & _
        "produtos.id_fabricante = lentes_blocos.id_fabricante " & _
        "WHERE (lente_contato.Base =" & d.cdin(x_base) & ") " & _
        " AND  (produtos.cod_produto =" & x_cod_prod & ") and (" & _
        "lente_contato.esf = " & d.cdin(x_esf) & ") and (lente_contato.cil = " & d.cdin(x_cil) & ")"
        d.carrega_Tabela(tsql, tt)
        If tt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function retorna_cod_produto(ByVal x_tabela As Integer, ByVal x_base As Double _
                                     , ByVal x_esf As Double, ByVal x_cil As Double) As Integer
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "SELECT produtos.cod_produto " & _
        ", lentes_blocos.cod_tabela  " & _
        "FROM lente_contato  INNER JOIN produtos ON lente_contato.cod_produto " & _
        "= produtos.cod_produto INNER JOIN " & _
        "lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente AND " & _
        "produtos.id_fabricante = lentes_blocos.id_fabricante " & _
        "WHERE (lentes_blocos.cod_tabela =" & x_tabela & ") and (" & _
        "lente_contato.esf = " & d.cdin(x_esf) & ") and (lente_contato.cil = " & d.cdin(x_cil) & ")" & _
        " and (lente_contato.base = " & d.cdin(x_base) & ")"
        d.carrega_Tabela(tsql, tt)
        If tt.Rows.Count > 0 Then
            Return tt.Rows(0)("cod_produto")
        Else
            Return 0
        End If
    End Function
#End Region
End Class
