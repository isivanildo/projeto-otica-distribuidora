Public Class objSaidaExtra
#Region "Atributos"
    Private _cod_movimento As Integer
    Private _id_filial_movimento As Integer
    Private _cod_natureza As Integer
    Private _data As Object
    Private _doc As String
    Private _id_usuario As Integer

    Private _cod_os As Integer
    Private _id_filial_os As Integer
    Private _desc_saida_extra As String
    Private _cod_saida_extra As Integer
    Private _id_usuario_perda As Integer
    Private _id_andamento As Object
    Private _od As String
    Private _oe As String
    Private _npod As Integer
    Private _npoe As Integer
    Private _troca_produto_od As String
    Private _troca_produto_oe As String
    Private _dev_od As String
    Private _dev_oe As String
    Private _od_ok As String
    Private _oe_ok As String

    Public posicao As Integer = 0
    Public max As Integer
    Public tb As New DataTable
    Public OrigemSalvar As String = ""
    Private lastPos As Integer = 0
    Private sql As String
    Dim d As New dados
    'Dim conf As New config
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
    Public Property id_filial_movimento()
        Get
            id_filial_movimento = _id_filial_movimento
        End Get
        Set(ByVal Value)
            _id_filial_movimento = Value
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
    Public Property id_filial_os()
        Get
            id_filial_os = _id_filial_os
        End Get
        Set(ByVal Value)
            _id_filial_os = Value
        End Set
    End Property
    Public Property cod_os()
        Get
            cod_os = _cod_os
        End Get
        Set(ByVal Value)
            _cod_os = Value
        End Set
    End Property
    Public Property Desc_saida_extra()
        Get
            Desc_saida_extra = _desc_saida_extra
        End Get
        Set(ByVal value)
            _desc_saida_extra = value
        End Set
    End Property
    Public Property cod_saida_extra()
        Get
            cod_saida_extra = _cod_saida_extra
        End Get
        Set(ByVal value)
            _cod_saida_extra = value
        End Set
    End Property
    Public Property id_usuario_perda()
        Get
            id_usuario_perda = _id_usuario_perda
        End Get
        Set(ByVal value)
            _id_usuario_perda = value
        End Set
    End Property
    Public Property id_andamento()
        Get
            id_andamento = _id_andamento
        End Get
        Set(ByVal value)
            _id_andamento = value
        End Set
    End Property
    Public Property od()
        Get
            od = _od
        End Get
        Set(ByVal value)
            _od = value
        End Set
    End Property
    Public Property oe()
        Get
            oe = _oe
        End Get
        Set(ByVal value)
            _oe = value
        End Set
    End Property
    Public Property npod()
        Get
            npod = _npod
        End Get
        Set(ByVal value)
            _npod = value
        End Set
    End Property
    Public Property npoe()
        Get
            npoe = _npoe
        End Get
        Set(ByVal value)
            _npoe = value
        End Set
    End Property
    Public Property troca_Produto_od()
        Get
            troca_Produto_od = _troca_produto_od
        End Get
        Set(ByVal value)
            _troca_produto_od = value
        End Set
    End Property
    Public Property troca_Produto_oe()
        Get
            troca_Produto_oe = _troca_produto_oe
        End Get
        Set(ByVal value)
            _troca_produto_oe = value
        End Set
    End Property
    Public Property dev_od()
        Get
            dev_od = _dev_od
        End Get
        Set(ByVal value)
            _dev_od = value
        End Set
    End Property
    Public Property dev_oe()
        Get
            dev_oe = _dev_oe
        End Get
        Set(ByVal value)
            _dev_oe = value
        End Set
    End Property
    Public Property od_ok()
        Get
            od_ok = _od_ok
        End Get
        Set(ByVal value)
            _od_ok = value
        End Set
    End Property
    Public Property oe_ok()
        Get
            oe_ok = _oe_ok
        End Get
        Set(ByVal value)
            _oe_ok = value
        End Set
    End Property
#End Region
#Region "Procedimentos"
    Public Sub New()
        Dim sql As String
        sql = "SELECT movimentomaster.cod_movimento, movimentomaster.cod_natureza, " & _
        "movimentomaster.data, movimentomaster.doc, movimentomaster.id_usuario, " & _
        "movimentomaster.concluido, saida_extra.id_filial_movimento, " & _
        "saida_extra.id_filial, saida_extra.cod_os, saida_extra.Desc_saida_extra, " & _
        "saida_extra.cod_saida_extra, saida_extra.id_usuario_perda, " & _
        "saida_extra.id_andamento, saida_extra.od, saida_extra.oe, saida_extra.nPOD, " & _
        "saida_extra.nPOE, saida_extra.trocaProdutoOd,saida_extra.trocaProdutoOe " & _
        ",saida_extra.dev_od,saida_extra.dev_oe " & _
        ",saida_extra.od_ok,saida_extra.oe_ok " & _
        "FROM movimentomaster INNER JOIN " & _
        "saida_extra ON movimentomaster.cod_movimento = saida_extra.cod_movimento " & _
        "AND movimentomaster.id_filial = saida_extra.id_filial_movimento " & _
        "Where saida_extra.cod_saida_Extra = 0"
        Source(sql)
    End Sub
    Public Sub New(ByVal xdados As dados)
        Dim sql As String
        d = xdados
        sql = "SELECT movimentomaster.cod_movimento, movimentomaster.cod_natureza, " & _
        "movimentomaster.data, movimentomaster.doc, movimentomaster.id_usuario, " & _
        "movimentomaster.concluido, saida_extra.id_filial_movimento, " & _
        "saida_extra.id_filial, saida_extra.cod_os, saida_extra.Desc_saida_extra, " & _
        "saida_extra.cod_saida_extra, saida_extra.id_usuario_perda, " & _
        "saida_extra.id_andamento, saida_extra.od, saida_extra.oe, saida_extra.nPOD, " & _
        "saida_extra.nPOE, saida_extra.trocaProdutoOd,saida_extra.trocaProdutoOe " & _
        ",saida_extra.dev_od,saida_extra.dev_oe " & _
        ",saida_extra.od_ok,saida_extra.oe_ok " & _
        "FROM movimentomaster INNER JOIN " & _
        "saida_extra ON movimentomaster.cod_movimento = saida_extra.cod_movimento " & _
        "AND movimentomaster.id_filial = saida_extra.id_filial_movimento " & _
        "Where saida_extra.cod_saida_Extra = 0"
        Source(sql)
    End Sub
    Public Sub New(ByVal cod_mov As Integer)
        Dim sql As String
        sql = "SELECT movimentomaster.cod_movimento, movimentomaster.cod_natureza, " &
        "movimentomaster.data, movimentomaster.doc, movimentomaster.id_usuario, " &
        "movimentomaster.concluido, saida_extra.id_filial_movimento, " &
        "saida_extra.id_filial, saida_extra.cod_os, saida_extra.Desc_saida_extra, " &
        "saida_extra.cod_saida_extra, saida_extra.id_usuario_perda, " &
        "saida_extra.id_andamento, saida_extra.od, saida_extra.oe, saida_extra.nPOD, " &
        "saida_extra.nPOE, saida_extra.trocaProdutoOd,saida_extra.trocaProdutoOe " &
        ",saida_extra.dev_od,saida_extra.dev_oe " &
        ",saida_extra.od_ok,saida_extra.oe_ok " &
        "FROM movimentomaster INNER JOIN " &
        "saida_extra ON movimentomaster.cod_movimento = saida_extra.cod_movimento " &
        "AND movimentomaster.id_filial = saida_extra.id_filial_movimento " &
         "where saida_extra.cod_movimento = " & cod_mov & " and saida_extra.id_filial_movimento = " & confFilial & ""
        Source(sql)
    End Sub
    Public Sub carrega_saida_extra_os(ByVal x_cod_os As Integer, ByVal x_id_filial_os As Integer, ByVal x_concluido As String)
        Dim sql As String
        sql = "SELECT movimentomaster.cod_movimento, movimentomaster.cod_natureza, " & _
        "movimentomaster.data, movimentomaster.doc, movimentomaster.id_usuario, " & _
        "movimentomaster.concluido, saida_extra.id_filial_movimento, " & _
        "saida_extra.id_filial, saida_extra.cod_os, saida_extra.Desc_saida_extra, " & _
        "saida_extra.cod_saida_extra, saida_extra.id_usuario_perda, " & _
        "saida_extra.id_andamento, saida_extra.od, saida_extra.oe, saida_extra.nPOD, " & _
        "saida_extra.nPOE, saida_extra.trocaProdutoOd,saida_extra.trocaProdutoOe " & _
        ",saida_extra.dev_od,saida_extra.dev_oe " & _
        ",saida_extra.od_ok,saida_extra.oe_ok " & _
        "FROM movimentomaster INNER JOIN " & _
        "saida_extra ON movimentomaster.cod_movimento = saida_extra.cod_movimento " & _
        "AND movimentomaster.id_filial = saida_extra.id_filial_movimento " & _
        "where saida_extra.cod_os = " & x_cod_os & " and saida_extra.id_filial = " & x_id_filial_os & _
        " and movimentomaster.concluido = " & d.PStr(x_concluido) & ""
        Source(sql)
    End Sub
    Public Sub carrega_saida_extra(ByVal x_cod_saida_extra As Integer, ByVal x_id_filial As Integer, ByVal x_concluido As String)
        Dim sql As String
        sql = "SELECT movimentomaster.cod_movimento, movimentomaster.cod_natureza, " & _
        "movimentomaster.data, movimentomaster.doc, movimentomaster.id_usuario, " & _
        "movimentomaster.concluido, saida_extra.id_filial_movimento, " & _
        "saida_extra.id_filial, saida_extra.cod_os, saida_extra.Desc_saida_extra, " & _
        "saida_extra.cod_saida_extra, saida_extra.id_usuario_perda, " & _
        "saida_extra.id_andamento, saida_extra.od, saida_extra.oe, saida_extra.nPOD, " & _
        "saida_extra.nPOE, saida_extra.trocaProdutoOd,saida_extra.trocaProdutoOe " & _
        ",saida_extra.dev_od,saida_extra.dev_oe " & _
        ",saida_extra.od_ok,saida_extra.oe_ok " & _
        "FROM movimentomaster INNER JOIN " & _
        "saida_extra ON movimentomaster.cod_movimento = saida_extra.cod_movimento " & _
        "AND movimentomaster.id_filial = saida_extra.id_filial_movimento " & _
        "where saida_extra.cod_saida_extra = " & x_cod_saida_extra & " and " & _
        "saida_extra.id_filial_movimento = " & x_id_filial & " and movimentomaster.concluido = " & _
        d.PStr(x_concluido)
        Source(sql)
    End Sub
    Public Sub filtra(ByVal x_cod_os As Integer, ByVal x_id_filial_movimento As Integer, ByVal x_id_filial_os As Integer, ByVal x_concluido As String)
        Dim sql As String
        sql = "SELECT movimentomaster.cod_movimento, movimentomaster.cod_natureza, " & _
        "movimentomaster.data, movimentomaster.doc, movimentomaster.id_usuario, " & _
        "movimentomaster.concluido, saida_extra.id_filial_movimento, " & _
        "saida_extra.id_filial, saida_extra.cod_os, saida_extra.Desc_saida_extra, " & _
        "saida_extra.cod_saida_extra, saida_extra.id_usuario_perda, " & _
        "saida_extra.id_andamento, saida_extra.od, saida_extra.oe, saida_extra.nPOD, " & _
        "saida_extra.nPOE, saida_extra.trocaProdutoOd,saida_extra.trocaProdutoOe " & _
        ",saida_extra.dev_od,saida_extra.dev_oe " & _
        ",saida_extra.od_ok,saida_extra.oe_ok " & _
        "FROM movimentomaster INNER JOIN " & _
        "saida_extra ON movimentomaster.cod_movimento = saida_extra.cod_movimento " & _
        "AND movimentomaster.id_filial = saida_extra.id_filial_movimento " & _
        "where saida_extra.cod_os = " & x_cod_os & " and saida_os.id_filial = " & x_id_filial_os & _
        " and saida_extra.id_filial_movimento = " & x_id_filial_movimento & _
        " AND (movimentomaster.concluido = '" & x_concluido & "')"
        Source(sql)
    End Sub
    Public Sub filtra(ByVal x_cod_os As Integer, ByVal x_id_filial_os As Integer, ByVal x_concluido As String)
        Dim sql As String
        sql = "SELECT movimentomaster.cod_movimento, movimentomaster.cod_natureza, " & _
        "movimentomaster.data, movimentomaster.doc, movimentomaster.id_usuario, " & _
        "movimentomaster.concluido, saida_extra.id_filial_movimento, " & _
        "saida_extra.id_filial, saida_extra.cod_os, saida_extra.Desc_saida_extra, " & _
        "saida_extra.cod_saida_extra, saida_extra.id_usuario_perda, " & _
        "saida_extra.id_andamento, saida_extra.od, saida_extra.oe, saida_extra.nPOD, " & _
        "saida_extra.nPOE, saida_extra.trocaProdutoOd,saida_extra.trocaProdutoOe " & _
        ",saida_extra.dev_od,saida_extra.dev_oe " & _
        ",saida_extra.od_ok,saida_extra.oe_ok " & _
        "FROM movimentomaster INNER JOIN " & _
        "saida_extra ON movimentomaster.cod_movimento = saida_extra.cod_movimento " & _
        "AND movimentomaster.id_filial = saida_extra.id_filial_movimento " & _
        " where saida_extra.cod_os = " & x_cod_os & " and saida_extra.id_filial = " & x_id_filial_os & _
        " AND (movimentomaster.concluido = '" & x_concluido & "')"
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
            _id_filial_movimento = tb.Rows(p)("id_filial_movimento")
            _cod_natureza = tb.Rows(p)("cod_natureza")
            _data = tb.Rows(p)("data")
            _doc = tb.Rows(p)("doc")
            _id_usuario = tb.Rows(p)("id_usuario")


            _id_filial_os = tb.Rows(p)("id_filial")
            _cod_os = tb.Rows(p)("cod_os")
            _cod_saida_extra = tb.Rows(p)("cod_saida_extra")
            _id_usuario_perda = tb.Rows(p)("id_usuario_perda")
            _id_andamento = tb.Rows(p)("id_andamento")
            _od = rdTexto(tb.Rows(p)("od"))
            _oe = rdTexto(tb.Rows(p)("oe"))
            _npod = rdNum(tb.Rows(p)("npod"))
            _npoe = rdNum(tb.Rows(p)("npoe"))
            _troca_produto_od = rdTexto(tb.Rows(p)("trocaprodutoOD"))
            _troca_produto_oe = rdTexto(tb.Rows(p)("trocaProdutoOE"))
            _desc_saida_extra = rdTexto(tb.Rows(p)("desc_saida_extra"))
            _dev_od = rdTexto(tb.Rows(p)("dev_od"))
            _dev_oe = rdTexto(tb.Rows(p)("dev_oe"))
            _od_ok = rdTexto(tb.Rows(p)("od_ok"))
            _oe_ok = rdTexto(tb.Rows(p)("oe_ok"))
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
        'Inicializa Variáveis
        _id_filial_movimento = Nothing
        _cod_natureza = 10
        _data = Nothing
        _doc = Nothing
        _id_usuario = Nothing

        _id_filial_os = Nothing
        _cod_os = Nothing
        _cod_saida_extra = Nothing
        _id_usuario_perda = Nothing
        _id_andamento = Nothing
        _od = Nothing
        _oe = Nothing
        _npod = Nothing
        _npoe = Nothing
        _troca_produto_od = Nothing
        _troca_produto_oe = Nothing
        _dev_od = "N"
        _dev_oe = "N"
        _od_ok = Nothing
        _oe_ok = Nothing

        OrigemSalvar = "Novo" 'Define o tipo de ação ao salvar
    End Sub
    Public Function Salvar() As String
        Dim sql As String
        Dim res As String 'Resposta do save
        d.conecta()
        If _id_andamento = Nothing Then
            _id_andamento = 1
        End If
        If OrigemSalvar = "Novo" Then
            Try
                _cod_saida_extra = d.retorna_Chave("cod_saida_extra", "saida_extra", " where id_filial_movimento = " & _id_filial_movimento & "")
                _cod_movimento = d.retorna_Chave("cod_movimento", "movimentomaster", " where id_filial = " & _id_filial_movimento & "")
                _doc = "Saída Extra " & _cod_saida_extra
                sql = "INSERT INTO movimentomaster " & _
                "(cod_movimento,cod_natureza,id_filial,data,doc,id_usuario) " & _
                "VALUES ( " & _
                _cod_movimento & _
                "," & _cod_natureza & _
                "," & _id_filial_movimento & _
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
                'trata OK
                If _od_ok = Nothing Then
                    If _od = "N" And _troca_produto_od = "N" Then
                        _od_ok = "S"
                    Else
                        _od_ok = "N"
                    End If
                End If
                If _oe_ok = Nothing Then
                    If _oe = "N" And _troca_produto_oe = "N" Then
                        _oe_ok = "S"
                    Else
                        _oe_ok = "N"
                    End If
                End If
                sql = "INSERT INTO saida_extra (cod_movimento,id_filial_movimento,id_filial" & _
                ",cod_os,Desc_saida_extra,cod_saida_extra,id_usuario_perda ,id_andamento ,od" & _
                ",oe,nPOD,nPOE,trocaProdutoOD,trocaProdutoOe,dev_od,dev_oe,od_ok,oe_ok) VALUES(" & _
                _cod_movimento & _
                "," & _id_filial_movimento & _
                "," & _id_filial_os & _
                "," & _cod_os & _
                "," & d.PStr(_desc_saida_extra) & _
                "," & _cod_saida_extra & _
                "," & _id_usuario_perda & _
                "," & _id_andamento & _
                "," & d.PStr(_od) & _
                "," & d.PStr(_oe) & _
                "," & _npod & _
                "," & _npoe & _
                "," & d.PStr(_troca_produto_od) & _
                "," & d.PStr(_troca_produto_oe) & _
                "," & d.PStr(_dev_od) & _
                "," & d.PStr(_dev_oe) & _
                "," & d.PStr(_od_ok) & _
                "," & d.PStr(_oe_ok) & _
                ")"
                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tb.NewRow
            r("cod_movimento") = _cod_movimento
            r("id_filial_movimento") = _id_filial_movimento
            r("cod_natureza") = _cod_natureza
            r("data") = wrData(_data)
            r("doc") = rdTexto(_doc)
            r("id_usuario") = _id_usuario

            r("id_filial") = _id_filial_os
            r("cod_os") = _cod_os
            r("cod_saida_extra") = _cod_saida_extra
            r("id_usuario_perda") = _id_usuario_perda
            r("id_andamento") = wrNum(_id_andamento)
            r("od") = rdTexto(_od)
            r("oe") = rdTexto(_oe)
            r("npod") = wrNum(_npod)
            r("npoe") = wrNum(_npoe)
            r("trocaprodutood") = rdTexto(_troca_produto_od)
            r("trocaprodutooe") = rdTexto(_troca_produto_oe)
            r("dev_od") = rdTexto(_dev_od)
            r("dev_oe") = rdTexto(_dev_oe)
            r("od_ok") = rdTexto(_od_ok)
            r("oe_ok") = rdTexto(_oe_ok)
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
                ",id_filial = " & _id_filial_movimento & _
                ",data = " & d.pdtm(_data) & _
                ",doc = " & d.PStr(_doc) & _
                ",id_usuario = " & _id_usuario & _
                " WHERE cod_movimento = " & _cod_movimento & _
                " and id_filial = " & _id_filial_movimento & ""
                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Try
                sql = "UPDATE saida_extra SET cod_movimento = " & _cod_movimento & _
                ",id_filial_movimento = " & _id_filial_movimento & _
                ",id_filial = " & _id_filial_os & _
                ",cod_os = " & _cod_os & _
                ",Desc_saida_extra = " & d.PStr(_desc_saida_extra) & _
                ",cod_saida_extra = " & _cod_saida_extra & _
                ",id_usuario_perda = " & _id_usuario_perda & _
                ",id_andamento = " & _id_andamento & _
                ",od = " & d.PStr(_od) & _
                ",oe = " & d.PStr(_oe) & _
                ",nPOD = " & _npod & _
                ",nPOE = " & _npoe & _
                ",trocaProdutoOD = " & d.PStr(_troca_produto_od) & _
                ",trocaProdutoOE = " & d.PStr(_troca_produto_oe) & _
                ",dev_od = " & d.PStr(_dev_od) & _
                ",dev_oe = " & d.PStr(_dev_oe) & _
                ",od_ok = " & d.PStr(_od_ok) & _
                ",oe_ok = " & d.PStr(_oe_ok) & _
                " WHERE cod_movimento = " & _cod_movimento & _
                " and id_filial_movimento = " & _id_filial_movimento & ""
                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tb.Rows(posicao)
            r("cod_movimento") = _cod_movimento
            r("id_filial_movimento") = _id_filial_movimento
            r("cod_natureza") = _cod_natureza
            r("data") = wrData(_data)
            r("doc") = rdTexto(_doc)
            r("id_usuario") = _id_usuario

            r("id_filial") = _id_filial_os
            r("cod_os") = _cod_os
            r("cod_saida_extra") = _cod_saida_extra
            r("id_usuario_perda") = _id_usuario_perda
            r("id_andamento") = _id_andamento
            r("od") = rdTexto(_od)
            r("oe") = rdTexto(_oe)
            r("npod") = rdTexto(_npod)
            r("npoe") = rdTexto(_npoe)
            r("trocaprodutoOD") = rdTexto(_troca_produto_od)
            r("trocaprodutoOE") = rdTexto(_troca_produto_oe)
            r("dev_od") = rdTexto(_dev_od)
            r("dev_oe") = rdTexto(_dev_oe)
            r("od_ok") = rdTexto(_od_ok)
            r("oe_ok") = rdTexto(_oe_ok)
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
    Public Function existe_saida_extra(ByVal x_cod_os As Integer, ByVal x_id_filial_movimento As Integer, ByVal x_id_filial_os As Integer) As Boolean
        Dim sql As String
        Dim tb_saida As New DataTable
        sql = "SELECT movimentomaster.cod_movimento, movimentomaster.cod_natureza, " & _
        "movimentomaster.data, movimentomaster.doc, movimentomaster.id_usuario, " & _
        "movimentomaster.concluido, saida_extra.id_filial_movimento, " & _
        "saida_extra.id_filial, saida_extra.cod_os, saida_extra.Desc_saida_extra, " & _
        "saida_extra.cod_saida_extra, saida_extra.id_usuario_perda, " & _
        "saida_extra.id_andamento, saida_extra.od, saida_extra.oe, saida_extra.nPOD, " & _
        "saida_extra.nPOE, saida_extra.trocaProdutoOd,saida_extra.trocaProdutoOe " & _
        "FROM movimentomaster INNER JOIN " & _
        "saida_extra ON movimentomaster.cod_movimento = saida_extra.cod_movimento " & _
        "AND movimentomaster.id_filial = saida_extra.id_filial_movimento " & _
        "where saida_extra.cod_os = " & x_cod_os & " and saida_os.id_filial = " & x_id_filial_os & _
        " and saida_extra.id_filial_movimento = " & x_id_filial_movimento & " and movimentomaster.concluido = 'N'"
        d.carrega_Tabela(sql, tb_saida)
        If tb_saida.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function existe_saida_extra(ByVal x_cod_os As Integer, ByVal x_id_filial_os As Integer, ByVal x_concluido As String) As Boolean
        Dim sql As String
        Dim tb_saida As New DataTable
        sql = "SELECT movimentomaster.cod_movimento, movimentomaster.cod_natureza, " & _
        "movimentomaster.data, movimentomaster.doc, movimentomaster.id_usuario, " & _
        "movimentomaster.concluido, saida_extra.id_filial_movimento, " & _
        "saida_extra.id_filial, saida_extra.cod_os, saida_extra.Desc_saida_extra, " & _
        "saida_extra.cod_saida_extra, saida_extra.id_usuario_perda, " & _
        "saida_extra.id_andamento, saida_extra.od, saida_extra.oe, saida_extra.nPOD, " & _
        "saida_extra.nPOE, saida_extra.trocaProdutoOd,saida_extra.trocaProdutoOe " & _
        "FROM movimentomaster INNER JOIN " & _
        "saida_extra ON movimentomaster.cod_movimento = saida_extra.cod_movimento " & _
        "AND movimentomaster.id_filial = saida_extra.id_filial_movimento " & _
        "where saida_extra.cod_os = " & x_cod_os & " and saida_os.id_filial = " & x_id_filial_os & _
        " and movimentomaster.concluido = " & d.PStr(x_concluido) & ""
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
        " WHERE (id_filial = " & Me.id_filial_movimento & ") AND " & _
        "(cod_Movimento = " & Me.cod_movimento & ") and status = 0"
        d.carrega_Tabela(sql, tb_lista)
        Return tb_lista
        tb_lista.Dispose()
    End Function
    Public Function conclui_movimento() As String
        Dim sql As String
        sql = "update movimentomaster set concluido = 'S' " & _
        " where cod_movimento = " & _cod_movimento & " and " & _
        "id_filial = " & _id_filial_movimento & ""
        Return d.Comando(sql, True)
    End Function
#End Region
End Class
