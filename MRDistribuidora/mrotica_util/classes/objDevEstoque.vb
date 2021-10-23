Public Class objDevolucaoEstoqueOS
#Region "Atributos"
    Private _cod_movimento As Integer
    Private _cod_devolucao_os As Integer
    Private _cod_os As Integer
    Private _id_filial As Integer
    Private _id_filial_os As Integer
    Private _cod_natureza As Integer
    Private _data As Object
    Private _doc As String
    Private _id_usuario As Integer
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
    Public Property cod_movimento()
        Get
            cod_movimento = _cod_movimento
        End Get
        Set(ByVal Value)
            _cod_movimento = Value
        End Set
    End Property
    Public Property cod_devolucao_os()
        Get
            cod_devolucao_os = _cod_devolucao_os
        End Get
        Set(ByVal Value)
            _cod_devolucao_os = Value
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
        sql = "SELECT movimentomaster.cod_natureza, movimentomaster.data, movimentomaster.doc," & _
        "movimentomaster.id_usuario, devolucao_Estoque_OS.cod_movimento, " & _
        "devolucao_Estoque_OS.id_filial, devolucao_Estoque_OS.cod_os, " & _
        "devolucao_Estoque_OS.id_filial_os, devolucao_Estoque_OS.cod_devolucao_os " & _
        "FROM movimentomaster INNER JOIN devolucao_Estoque_OS ON " & _
        "movimentomaster.cod_movimento = devolucao_Estoque_OS.cod_movimento AND " & _
        "movimentomaster.id_filial = devolucao_Estoque_OS.id_filial " & _
        "where devolucao_Estoque_OS.cod_movimento = 0 "
        Source(sql)
    End Sub
    Public Sub New(ByVal x_cod_mov As Integer)
        filtrar(x_cod_mov, conf.Filial)
    End Sub
    Public Sub New(ByVal x_cod_os As Integer, ByVal x_id_filial As Integer)
        Dim sql As String
        'Filtra devolução informando se foi concluída ou não
        sql = "SELECT movimentomaster.cod_natureza, movimentomaster.data, movimentomaster.doc," &
                "movimentomaster.id_usuario, devolucao_Estoque_OS.cod_movimento, " &
                "devolucao_Estoque_OS.id_filial, devolucao_Estoque_OS.cod_os, " &
                "devolucao_Estoque_OS.id_filial_os, devolucao_Estoque_OS.cod_devolucao_os " &
                "FROM movimentomaster INNER JOIN devolucao_Estoque_OS ON " &
                "movimentomaster.cod_movimento = devolucao_Estoque_OS.cod_movimento AND " &
                "movimentomaster.id_filial = devolucao_Estoque_OS.id_filial " &
                "where devolucao_Estoque_OS.cod_os = " & x_cod_os &
                " and devolucao_Estoque_OS.id_filial_os = " & x_id_filial & ""
        Source(sql)
    End Sub
    Public Sub filtrar(ByVal x_cod_devolucao_os As Integer, ByVal x_id_filial As Integer)
        Dim sql As String
        sql = "SELECT movimentomaster.cod_natureza, movimentomaster.data, movimentomaster.doc," &
                "movimentomaster.id_usuario, devolucao_Estoque_OS.cod_movimento, " &
                "devolucao_Estoque_OS.id_filial, devolucao_Estoque_OS.cod_os, " &
                "devolucao_Estoque_OS.id_filial_os, devolucao_Estoque_OS.cod_devolucao_os " &
                "FROM movimentomaster INNER JOIN devolucao_Estoque_OS ON " &
                "movimentomaster.cod_movimento = devolucao_Estoque_OS.cod_movimento AND " &
                "movimentomaster.id_filial = devolucao_Estoque_OS.id_filial " &
                "where devolucao_Estoque_OS.cod_devolucao_os = " & x_cod_devolucao_os &
                " and devolucao_Estoque_OS.id_filial = " & x_id_filial & ""
        Source(sql)
    End Sub
    Public Sub filtrar(ByVal x_cod_OS As Integer, ByVal x_id_filial As Integer, ByVal concluido As String)
        Dim sql As String
        'Filtra devolução informando se foi concluída ou não
        sql = "SELECT movimentomaster.cod_natureza, movimentomaster.data, movimentomaster.doc," &
                "movimentomaster.id_usuario, devolucao_Estoque_OS.cod_movimento, " &
                "devolucao_Estoque_OS.id_filial, devolucao_Estoque_OS.cod_os, " &
                "devolucao_Estoque_OS.id_filial_os, devolucao_Estoque_OS.cod_devolucao_os " &
                "FROM movimentomaster INNER JOIN devolucao_Estoque_OS ON " &
                "movimentomaster.cod_movimento = devolucao_Estoque_OS.cod_movimento AND " &
                "movimentomaster.id_filial = devolucao_Estoque_OS.id_filial " &
                "where devolucao_Estoque_OS.cod_os = " & x_cod_OS &
                " and devolucao_Estoque_OS.id_filial_os = " & x_id_filial & " and " &
                "movimentomaster.concluido = '" & concluido & "'"
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
            _cod_devolucao_os = tb.Rows(p)("cod_devolucao_os")
            _id_filial = tb.Rows(p)("id_filial")
            _id_filial_os = tb.Rows(p)("id_filial_os")
            _cod_os = tb.Rows(p)("cod_os")
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

        _id_filial = conf.Filial
        _id_filial_os = Nothing
        _cod_natureza = 11
        _data = Nothing
        _doc = "Devolução " & _cod_devolucao_os
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
                _cod_devolucao_os = retorna_Chave("cod_devolucao_OS", "Devolucao_estoque_os", " where id_filial = " & conf.Filial)
                _doc = "Devolução " & _cod_devolucao_os
                sql = "INSERT INTO movimentomaster " & _
                "(cod_movimento,cod_natureza,id_filial,data,doc,id_usuario) " & _
                "VALUES ( " & _
                _cod_movimento & _
                "," & _cod_natureza & _
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
                sql = "INSERT INTO devolucao_estoque_os(cod_movimento,cod_devolucao_os,id_filial,id_filial_os,cod_os) " & _
                "VALUES (" & _cod_movimento & "," & _cod_devolucao_os & "," & _id_filial & _
                "," & id_filial_os & "," & _cod_os & ")"
                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tb.NewRow
            r("cod_movimento") = _cod_movimento
            r("cod_devolucao_os") = _cod_devolucao_os
            r("id_filial") = _id_filial
            r("id_filial_os") = _id_filial_os
            r("cod_os") = _cod_os
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
            Try
                sql = "UPDATE movimentomaster SET cod_movimento = " & _cod_movimento & _
                ",cod_natureza = " & _cod_natureza & _
                ",id_filial = " & _id_filial & _
                ",id_filial_os = " & _id_filial_os & _
                ",data = " & d.pdtm(_data) & _
                ",doc = " & d.PStr(_doc) & _
                ",id_usuario = " & _id_usuario & _
                " WHERE cod_movimento = " & _cod_movimento & _
                " and id_filial = " & _id_filial & ""

                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Try
                sql = "UPDATE devolucao_estoque_os SET cod_movimento = " & _cod_movimento & _
                ",cod_devolucao_os = " & _cod_devolucao_os & ",id_filial  = " & _id_filial & _
                ",cod_os  = " & _cod_os & _
                " WHERE cod_movimento = " & Me._cod_movimento & _
                " and id_filial = " & Me._id_filial & ""
                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tb.Rows(posicao)
            r("cod_movimento") = _cod_movimento
            r("cod_devolucao_os") = _cod_devolucao_os
            r("id_filial") = _id_filial
            r("cod_os") = _cod_os
            r("cod_natureza") = _cod_natureza
            r("data") = rdData(_data)
            r("doc") = rdTexto(_doc)
            r("id_usuario") = _id_usuario
            OrigemSalvar = ""
            Return "OK:" & res & " registro(s) atualizado(s) com sucesso!"
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
    Public Function lista_itens() As DataTable
        Dim sql As String
        Dim tb_lista As New DataTable
        sql = "SELECT * FROM movimento " & _
        " WHERE (id_filial = " & Me._id_filial & ") AND " & _
        "(cod_Movimento = " & Me._cod_movimento & ") and status = 0"
        d.carrega_Tabela(sql, tb_lista)
        Return tb_lista
        tb_lista.Dispose()
    End Function
    Public Function tem_produto(ByVal x_cod_prod As Integer) As Integer
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT cod_produto, cod_Movimento, id_filial, status " & _
        "FROM movimento WHERE (cod_Movimento = " & Me._cod_movimento & _
        ") AND (id_filial = " & Me.id_filial & ") AND (cod_produto = " & _
        x_cod_prod & ") AND (status = 0)"
        d.carrega_Tabela(sql, tt)
        Return tt.Rows.Count
    End Function
    Public Function conclui_movimento() As String
        Dim sql As String
        sql = "update movimentomaster set concluido = 'S' " & _
        " where cod_movimento = " & _cod_movimento & " and " & _
        "id_filial = " & _id_filial & ""
        Return d.Comando(sql, True)
    End Function
#End Region
End Class
