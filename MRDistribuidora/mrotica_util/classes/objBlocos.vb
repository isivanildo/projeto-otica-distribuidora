Public Class objblocos
#Region "Atributos"
    Private _cod_produto As Integer
    Private _base As Object
    Private _adicao As Object
    Private _olho As Char
    Private _esf_maior As Object
    Private _esf_menor As Object
    Private _barra As Object
    Public posicao As Integer = 0
    Public max As Integer
    Public chaveCriterio As Object
    Public tabela As New DataTable
    Public OrigemSalvar As String = ""
    Private lastPos As Integer = 0
    Private sql As String
    Dim d As New dados
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
    Public Property adicao()
        Get
            adicao = _adicao
        End Get
        Set(ByVal Value)
            _adicao = Value
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
    Public Property olho()
        Get
            olho = _olho
        End Get
        Set(ByVal Value)
            _olho = Value
        End Set
    End Property
#End Region
#Region "Procedimentos"
    Public Sub New()
        Dim sql As String
        sql = "Select produtos.cod_produto, blocos.Base_nominal," & _
        "blocos.Adicao,blocos.olho from lentes_blocos " & _
        "inner JOIN produtos on lentes_blocos.cod_lente =" & _
        "produtos.cod_lente and lentes_blocos.id_fabricante = " & _
        "produtos.id_fabricante " & _
        "inner join blocos on produtos.cod_produto = blocos.Cod_produto " & _
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
            _base = tabela.Rows(p)("base_nominal")
            _adicao = tabela.Rows(p)("adicao")
            _barra = rdNum(tabela.Rows(p)("cod_barra"))
            _esf_maior = tabela.Rows(p)("esf_maior")
            _esf_menor = tabela.Rows(p)("esf_menor")
            _olho = rdTexto(tabela.Rows(p)("olho"))
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
        _adicao = Nothing
        _barra = Nothing
        _esf_maior = Nothing
        _esf_menor = Nothing
        _olho = Nothing
        OrigemSalvar = "Novo" 'Define o tipo de ação ao salvar
    End Function
    Public Function Salvar() As String
        Dim sql As String
        Dim res As String 'Quantidade de registros afetados
        d.conecta()
        If OrigemSalvar = "Novo" Then
            Try
                sql = "Insert into blocos(cod_produto,base_nominal,adicao,olho,esf_maior,esf_menor) " & _
                "Values(" & _
                _cod_produto & "," & d.cdin(_base) & "," & d.cdin(_adicao) & "," & d.PStr(_olho) & "," & _
                d.cdin(_esf_maior) & "," & d.cdin(_esf_menor) & ")"
                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tabela.NewRow
            r("cod_produto") = wrNum(_cod_produto)
            r("base_nominal") = wrNum(_base)
            r("adicao") = wrNum(_adicao)
            r("esf_maior") = wrNum(_esf_maior)
            r("esf_menor") = wrNum(_esf_menor)
            r("olho") = rdTexto(_olho)
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
                sql = "Update blocos set " & _
                "base_nominal = " & d.cdin(_base) & _
                ",adicao = " & d.cdin(_adicao) & _
                ",olho = " & d.PStr(_olho) & _
                ",esf_maior = " & d.cdin(_esf_maior) & _
                ",esf_menor = " & d.cdin(_esf_menor) & _
                " where cod_produto = " & chaveCriterio & ""
                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tabela.Rows(posicao)
            r("base_nominal") = wrNum(_base)
            r("adicao") = wrNum(_adicao)
            r("cod_barra") = wrNum(_barra)
            r("esf_maior") = wrNum(_esf_maior)
            r("esf_menor") = wrNum(_esf_menor)
            r("olho") = rdTexto(_olho)
            OrigemSalvar = ""
            Return "OK:" & res & " registro(s) atualizado(s) com sucesso!"
        End If
    End Function
    Public Function deletar(ByVal id_prod As Integer)
        Dim res As String
        Dim sql As String
        d.conecta()
        sql = "Delete from blocos where cod_produto = " & id_prod & ""
        Try
            res = d.Comando(sql, True)
        Catch ex As Exception
        End Try
        Me.refreshData()
        Me.primeiro()
        Return res & " Registros foram apagados!"
    End Function
    Public Function lista_blocos(ByVal id_fabricante As Integer, ByVal id_lente As Integer) As DataTable
        sql = "Select blocos.Base_nominal," & _
        "blocos.Adicao,blocos.olho,produtos.cod_produto,produtos.cod_barra," & _
        "blocos.esf_maior, blocos.esf_menor from lentes_blocos " & _
        "inner JOIN produtos on lentes_blocos.cod_lente =" & _
        "produtos.cod_lente and lentes_blocos.id_fabricante = " & _
        "produtos.id_fabricante " & _
        "inner join blocos on produtos.cod_produto = blocos.Cod_produto " & _
        "where lentes_blocos.id_fabricante = " & id_fabricante & " and " & _
        "lentes_blocos.cod_lente = " & id_lente & _
        " ORDER BY blocos.Base_nominal DESC ," & _
        "blocos.Adicao ASC ,blocos.olho ASC"
        Source(sql)
    End Function
    Public Function lista_blocos_sem_barra(ByVal id_fabricante As Integer, ByVal id_lente As Integer) As DataTable
        sql = "Select blocos.Base_nominal," & _
        "blocos.Adicao,blocos.olho,produtos.cod_produto,produtos.cod_barra," & _
        "blocos.esf_maior, blocos.esf_menor from lentes_blocos " & _
        "inner JOIN produtos on lentes_blocos.cod_lente =" & _
        "produtos.cod_lente and lentes_blocos.id_fabricante = " & _
        "produtos.id_fabricante " & _
        "inner join blocos on produtos.cod_produto = blocos.Cod_produto " & _
        "where lentes_blocos.id_fabricante = " & id_fabricante & " and " & _
        "lentes_blocos.cod_lente = " & id_lente & _
        " and produtos.cod_barra is null " & _
        " ORDER BY blocos.Base_nominal DESC ," & _
        "blocos.Adicao ASC ,blocos.olho ASC"
        Source(sql)
    End Function
    Public Function faixa_diop_base(ByVal base As Double, ByVal Xesf_menor As Double, ByVal Xesf_maior As Double, ByVal fab As Integer, ByVal lente As Integer)
        Dim sql As String
        sql = "Update blocos set esf_maior = " & d.cdin(Xesf_maior) & ",esf_menor = " & _
        d.cdin(Xesf_menor) & _
        " FROM blocos INNER JOIN produtos ON blocos.Cod_produto = produtos.cod_produto " & _
        " WHERE (blocos.Cod_produto = blocos.Cod_produto) And (blocos.Base_nominal = " & d.cdin(base) & ") " & _
        " And (produtos.id_fabricante = " & fab & ") And (produtos.cod_lente =" & lente & ")"
        d.Comando(sql, True)
    End Function
    Public Function confirma_bloco_Base(ByVal x_base As Double, ByVal x_adicao As Double, ByVal x_olho As String, ByVal x_cod_prod As Integer) As Boolean
        Dim sql As String
        Dim tb_base As New DataTable
        sql = "SELECT produtos.cod_produto, blocos.Adicao, blocos.olho " & _
        "FROM produtos INNER JOIN blocos ON produtos.cod_produto = blocos.Cod_produto " & _
        "WHERE (blocos.Base_nominal = " & d.cdin(x_base) & ") AND " & _
        "(blocos.Adicao = " & d.cdin(x_adicao) & ") AND (blocos.olho = " & d.PStr(x_olho) & _
        ")  AND (produtos.cod_produto = " & x_cod_prod & ")"
        d.carrega_Tabela(sql, tb_base)
        If tb_base.Rows.Count = 1 Then Return True Else Return False
    End Function
    Public Function existe_base_adicao_olho(ByVal x_base As Double, ByVal x_adicao As Double, ByVal x_olho As String, ByVal x_tabela As Integer) As Boolean
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT blocos.Base_nominal, blocos.Adicao, blocos.olho, lentes_blocos.cod_tabela " & _
        "FROM blocos INNER JOIN produtos ON blocos.Cod_produto = produtos.cod_produto INNER JOIN " & _
        "lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente AND " & _
        "produtos.id_fabricante = lentes_blocos.id_fabricante " & _
        "WHERE (blocos.Base_nominal = " & d.cdin(x_base) & ") And (blocos.Adicao = " & d.cdin(x_adicao) & _
        ") AND (blocos.olho = " & d.PStr(x_olho) & ") AND (lentes_blocos.cod_tabela = " & x_tabela & ")"
        d.carrega_Tabela(sql, tt)
        If tt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function retorna_cod_produto(ByVal x_base As Double, ByVal x_adicao As Double, ByVal x_olho As String, ByVal x_cod_tabela As Integer)
        Dim sql As String
        Dim tb_R As New DataTable
        sql = "SELECT blocos.Cod_produto FROM produtos INNER JOIN " & _
        "lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente AND " & _
        "produtos.id_fabricante = lentes_blocos.id_fabricante INNER JOIN " & _
        "lentes_tabela ON lentes_blocos.cod_tabela = lentes_tabela.cod_tabela INNER JOIN " & _
        "blocos ON produtos.cod_produto = blocos.Cod_produto " & _
        "WHERE (blocos.Base_nominal = " & d.cdin(x_base) & ") AND " & _
        "(blocos.Adicao = " & d.cdin(x_adicao) & ") AND " & _
        "(blocos.olho = " & d.PStr(x_olho) & ") AND " & _
        "(lentes_tabela.cod_tabela = " & x_cod_tabela & ") AND (lentes_blocos.Ativo <> 0)"
        d.carrega_Tabela(sql, tb_R)
        If tb_R.Rows.Count > 0 Then
            Return tb_R.Rows(0)(0)
        Else
            Return 0
        End If
    End Function
    Public Function retorna_cod_produto_interview(ByVal x_base As Double, ByVal x_adicao As Double, ByVal x_olho As String, ByVal x_cod_tabela As Integer)
        Dim sql As String
        Dim tb_R As New DataTable
        Dim str As String
        Dim p As Integer
        sql = "SELECT blocos.Cod_produto FROM produtos INNER JOIN " & _
        "lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente AND " & _
        "produtos.id_fabricante = lentes_blocos.id_fabricante INNER JOIN " & _
        "lentes_tabela ON lentes_blocos.cod_tabela = lentes_tabela.cod_tabela INNER JOIN " & _
        "blocos ON produtos.cod_produto = blocos.Cod_produto " & _
        "WHERE (blocos.Base_nominal = " & d.cdin(x_base) & ") AND " & _
        "(blocos.Adicao = " & d.cdin(x_adicao) & ") AND " & _
        "(blocos.olho = " & d.PStr(x_olho) & ") AND " & _
        "(lentes_tabela.cod_tabela = " & x_cod_tabela & ") AND (lentes_blocos.Ativo = -1)"
        d.carrega_Tabela(sql, tb_R)
        str = "Digite 1 para Range 80 e Digite 2 para Range 130"
        p = InputBox(str)

        If p > 0 And p <= 2 Then
            Return tb_R.Rows(p - 1)(0)
        Else
            Return 0
        End If
    End Function
#End Region
End Class
