Public Class objBlocoSurf
#Region "Atributos"
    Private _cod_produto As Integer
    Private _base As Object
    Private _adicao As Object
    Private _olho As Char
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
        sql = "Select produtos.cod_produto, bloco_surfacado.Base_nominal," & _
        "bloco_surfacado.Adicao,bloco_surfacado.olho,bloco_surfacado.esf, bloco_surfacado.cil from lentes_blocos " & _
        "inner JOIN produtos on lentes_blocos.cod_lente =" & _
        "produtos.cod_lente and lentes_blocos.id_fabricante = " & _
        "produtos.id_fabricante " & _
        "inner join bloco_surfacado on produtos.cod_produto = bloco_surfacado.Cod_produto " & _
        "where produtos.cod_produto = 0"
        Source(sql)
    End Sub
    Public Sub New(ByVal id_fab, ByVal id_lente)
        lista_blocos(id_fab, id_lente)
    End Sub
    Public Sub filtra(ByVal x_cod_produto As Integer)
        Dim sql As String
        sql = "Select produtos.cod_produto, bloco_surfacado.Base_nominal," & _
        "bloco_surfacado.Adicao,bloco_surfacado.olho, " & _
        "bloco_surfacado.esf,bloco_surfacado.cil from lentes_blocos " & _
        "inner JOIN produtos on lentes_blocos.cod_lente =" & _
        "produtos.cod_lente and lentes_blocos.id_fabricante = " & _
        "produtos.id_fabricante " & _
        "inner join bloco_surfacado on produtos.cod_produto = bloco_surfacado.Cod_produto " & _
        "where produtos.cod_produto = " & x_cod_produto & ""
        Source(sql)
    End Sub
    Public Sub Source(ByVal iSql As String)
        sql = iSql
        Me.refreshData()
    End Sub
    Public Sub refreshData()
        d.carrega_Tabela(sql, tabela)
        max = tabela.Rows.Count
        primeiro()
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
            _esf = tabela.Rows(p)("esf")
            _cil = tabela.Rows(p)("cil")
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
        _esf = Nothing
        _cil = Nothing
        _olho = Nothing
        OrigemSalvar = "Novo" 'Define o tipo de ação ao salvar
    End Function
    Public Function Salvar() As String
        Dim sql As String
        Dim res As String 'Quantidade de registros afetados
        d.conecta()
        If OrigemSalvar = "Novo" Then
            Try
                sql = "Insert into bloco_surfacado(cod_produto,base_nominal,adicao,olho,esf,cil)" & _
                "Values(" & _
                _cod_produto & "," & d.cdin(_base) & "," & d.cdin(_adicao) & "," & d.PStr(_olho) & "," & _
                d.cdin(_esf) & "," & d.cdin(_cil) & ")"
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
                sql = "Update bloco_surfacado set " & _
                "base_nominal = " & d.cdin(_base) & _
                ",adicao = " & d.cdin(_adicao) & _
                ",olho = " & d.PStr(_olho) & _
                ",esf = " & d.cdin(_esf) & _
                ",cil = " & d.cdin(_cil) & _
                " where cod_produto = " & _cod_produto & ""
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
            r("esf") = wrNum(_esf)
            r("cil") = wrNum(cil)
            r("olho") = rdTexto(_olho)
            OrigemSalvar = ""
            Return "OK:" & res & " registro(s) atualizado(s) com sucesso!"
        End If
    End Function
    Public Function altera_base_dioptria(esf As Double, cil As Double, base As Double, cod_lente As Integer) As String
        Dim tsql As String
        Dim res As String
        tsql = "Update bloco_surfacado set " & _
               "base_nominal = " & d.cdin(base) & _
             "from lentes_blocos  " & _
             "inner JOIN produtos on lentes_blocos.cod_lente = " & _
        "produtos.cod_lente and lentes_blocos.id_fabricante =  " & _
        "produtos.id_fabricante " & _
        "inner join bloco_surfacado on produtos.cod_produto = bloco_surfacado.Cod_produto  " & _
        "where (lentes_blocos.cod_lente =" & cod_lente & ")" & _
        "and bloco_surfacado.esf = " & d.cdin(esf) & _
        "and bloco_surfacado.cil = " & d.cdin(cil) & ""
        res = d.Comando(tsql, True)
        Return res
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
        sql = "Delete from bloco_surfacado where cod_produto = " & id_prod & ""
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
            sql = "Delete from bloco_surfacado where cod_produto = " & id_prod & ""
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
        sql = "Select bloco_surfacado.Base_nominal," & _
        "bloco_surfacado.Adicao,bloco_surfacado.olho,produtos.cod_produto,produtos.cod_barra," & _
        "bloco_surfacado.esf, bloco_surfacado.cil from lentes_blocos " & _
        "inner JOIN produtos on lentes_blocos.cod_lente =" & _
        "produtos.cod_lente and lentes_blocos.id_fabricante = " & _
        "produtos.id_fabricante " & _
        "inner join bloco_surfacado on produtos.cod_produto = bloco_surfacado.Cod_produto " & _
        "where lentes_blocos.id_fabricante = " & id_fabricante & " and " & _
        "lentes_blocos.cod_lente = " & id_lente & _
        " ORDER BY bloco_surfacado.Base_nominal DESC ," & _
        "bloco_surfacado.Adicao ASC , bloco_surfacado.esf DESC, bloco_surfacado.cil ASC,bloco_surfacado.olho"
        Source(sql)
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function lista_blocos_sem_barra(ByVal id_fabricante As Integer, ByVal id_lente As Integer) As DataTable
        sql = "Select bloco_surfacado.Base_nominal," & _
        "bloco_surfacado.Adicao,bloco_surfacado.olho,produtos.cod_produto,produtos.cod_barra," & _
        "bloco_surfacado.esf_maior, bloco_surfacado.esf_menor from lentes_blocos " & _
        "inner JOIN produtos on lentes_blocos.cod_lente =" & _
        "produtos.cod_lente and lentes_blocos.id_fabricante = " & _
        "produtos.id_fabricante " & _
        "inner join blocos on produtos.cod_produto = bloco_surfacado.Cod_produto " & _
        "where lentes_blocos.id_fabricante = " & id_fabricante & " and " & _
        "lentes_blocos.cod_lente = " & id_lente & _
        " and produtos.cod_barra is null " & _
        " ORDER BY blocos.Base_nominal DESC ," & _
        "blocos.Adicao ASC ,blocos.olho ASC"
        Source(sql)
    End Function
    Public Function existe_base_diop(ByVal x_base As Double, ByVal x_adicao As Double, ByVal x_olho As String, ByVal x_tabela As Integer _
                                     , ByVal x_esf As Double, ByVal x_cil As Double) As Boolean
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "SELECT bloco_surfacado.Base_nominal " & _
        ", bloco_surfacado.Adicao, bloco_surfacado.olho, lentes_blocos.cod_tabela  " & _
        "FROM bloco_surfacado  INNER JOIN produtos ON bloco_surfacado.cod_produto " & _
        "= produtos.cod_produto INNER JOIN " & _
        "lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente AND " & _
        "produtos.id_fabricante = lentes_blocos.id_fabricante " & _
        "WHERE (bloco_surfacado.Base_nominal =" & d.cdin(x_base) & ") And (bloco_surfacado.Adicao =" & d.cdin(x_adicao) & _
        ") AND (bloco_surfacado.olho =" & d.PStr(x_olho) & ") AND (lentes_blocos.cod_tabela =" & x_tabela & ") and (" & _
        "bloco_surfacado.esf = " & d.cdin(x_esf) & ") and (bloco_surfacado.cil = " & d.cdin(x_cil) & ")"
        d.carrega_Tabela(tsql, tt)
        If tt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function retorna_cod_produto(ByVal x_adicao As Double, ByVal x_olho As String, ByVal x_tabela As Integer _
                                     , ByVal x_esf As Double, ByVal x_cil As Double) As Integer
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "SELECT produtos.cod_produto " & _
        ", bloco_surfacado.Adicao, bloco_surfacado.olho, lentes_blocos.cod_tabela  " & _
        "FROM bloco_surfacado  INNER JOIN produtos ON bloco_surfacado.cod_produto " & _
        "= produtos.cod_produto INNER JOIN " & _
        "lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente AND " & _
        "produtos.id_fabricante = lentes_blocos.id_fabricante " & _
        "WHERE (bloco_surfacado.Adicao =" & d.cdin(x_adicao) & _
        ") AND (bloco_surfacado.olho =" & d.PStr(x_olho) & ") AND (lentes_blocos.cod_tabela =" & x_tabela & ") and (" & _
        "bloco_surfacado.esf = " & d.cdin(x_esf) & ") and (bloco_surfacado.cil = " & d.cdin(x_cil) & ")"
        d.carrega_Tabela(tsql, tt)
        If tt.Rows.Count > 0 Then
            Return tt.Rows(0)("cod_produto")
        Else
            Return 0
        End If
    End Function
    Public Function confirma_bloco_Base(ByVal x_base As Double, ByVal x_adicao As Double, ByVal x_olho As String, ByVal x_cod_prod As Integer, _
                                        ByVal x_esf As Double, ByVal x_cil As Double) As Integer
        Dim sql As String
        Dim tb_base As New DataTable
        sql = "SELECT produtos.cod_produto, bloco_surfacado.Adicao, bloco_surfacado.olho " & _
        "FROM produtos INNER JOIN bloco_surfacado ON produtos.cod_produto = bloco_surfacado.Cod_produto " & _
        "WHERE (bloco_surfacado.Adicao =" & d.cdin(x_adicao) & _
        ") AND (bloco_surfacado.olho =" & d.PStr(x_olho) & ") AND (" & _
        "bloco_surfacado.esf = " & d.cdin(x_esf) & ") and (bloco_surfacado.cil = " & d.cdin(x_cil) & _
        ")  AND (produtos.cod_produto = " & x_cod_prod & ")"
        d.carrega_Tabela(sql, tb_base)
        If tb_base.Rows.Count = 1 Then Return True Else Return False
    End Function
    Public Function insere_origem(ByVal cod_origem As Integer, ByVal cod_destino As Integer) As String
        Dim tsql As String
        tsql = "Insert into bloco_surfacado_origem(cod_tabela_origem,cod_tabela_destino) values(" & _
            cod_origem & "," & cod_destino & ")"
        Return d.Comando(tsql, True)
    End Function
    Public Function exclui_origem(ByVal cod_origem As Integer, ByVal cod_destino As Integer) As String
        Dim tsql As String
        tsql = "delete from bloco_surfacado_origem Where " & _
            " cod_tabela_origem = " & cod_origem & " and " & _
            " cod_tabela_destino = " & cod_destino & ""
        Return d.Comando(tsql, True)
    End Function
    Public Function retorna_bloco_origem(ByVal cod_destino As Integer) As Integer
        Dim res As Integer
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "Select cod_tabela_origem from bloco_surfacado_origem where cod_tabela_destino = " & _
            cod_destino & ""
        d.carrega_Tabela(tsql, tt)
        If tt.Rows.Count = 0 Then
            res = 0
        Else
            res = tt.Rows(0)("cod_tabela_origem")
        End If
        Return res
    End Function
    Public Function retorna_diop_cod_produto(ByVal xCod_produto As Integer) As dioptriaBlocoSurf
        Dim tsql As String
        Dim diop As New dioptriaBlocoSurf
        Dim tt As New DataTable
        Dim r As DataRow
        tsql = "select * from bloco_surfacado where cod_produto = " & xCod_produto & ""
        d.carrega_Tabela(tsql, tt)
        If tt.Rows.Count > 0 Then
            r = tt.Rows(0)
            diop.encontrado = True
            diop.base = r("base")
            diop.adicao = r("adicao")
            diop.olho = r("olho").ToString
            diop.esferico = r("esf")
            diop.cilindrico = r("cil")
        Else
            diop.encontrado = False
        End If
        Return diop
    End Function

#End Region
End Class
Public Class dioptriaBlocoSurf
    'Retorna um conjunto de dados contendo a dioptria de um
    'bloco surfaçado
    Dim _esferico As Double
    Dim _cilindrico As Double
    Dim _base As Double
    Dim _adicao As Double
    Dim _olho As String
    Dim _encontrado As Boolean = False
    Public Property esferico
        Get
            esferico = _esferico
        End Get
        Set(ByVal value)
            _esferico = value
        End Set
    End Property
    Public Property cilindrico
        Get
            cilindrico = _cilindrico
        End Get
        Set(ByVal value)
            _cilindrico = value
        End Set
    End Property
    Public Property base
        Get
            base = _base
        End Get
        Set(ByVal value)
            _base = value
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
    Public Property olho As String
        Get
            olho = _olho
        End Get
        Set(ByVal value As String)
            _olho = value
        End Set
    End Property
    Public Property encontrado As Boolean
        Get
            encontrado = _encontrado
        End Get
        Set(ByVal value As Boolean)
            _encontrado = value
        End Set
    End Property
End Class
