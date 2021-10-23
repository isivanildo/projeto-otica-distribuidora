Public Class objSaidaOS
#Region "Atributos"
    Private _cod_movimento As Integer
    Private _cod_saida_os As Integer
    Private _cod_os As Integer
    Private _id_filial As Integer
    Private _id_filial_os As Integer
    Private _cod_natureza As Integer
    Private _data As Object
    Private _doc As String
    Private _id_usuario As Integer
    Private _concluido As String
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
    Public Property cod_saida_os()
        Get
            cod_saida_os = _cod_saida_os
        End Get
        Set(ByVal Value)
            _cod_saida_os = Value
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
    Public Property concluido()
        Get
            concluido = _concluido
        End Get
        Set(ByVal Value)
            _concluido = Value
        End Set
    End Property
#End Region
#Region "Procedimentos"
    Public Sub New()
        Dim sql As String
        sql = "SELECT movimentomaster.cod_natureza, movimentomaster.data, " & _
        "movimentomaster.doc, movimentomaster.concluido, " & _
        "movimentomaster.id_usuario, saida_os.cod_movimento, " & _
        "saida_os.id_filial,saida_os.id_filial_os, saida_os.cod_os, saida_os.cod_saida_os " & _
        "FROM movimentomaster INNER JOIN " & _
        "saida_os ON movimentomaster.cod_movimento = saida_os.cod_movimento AND " & _
        "movimentomaster.id_filial = saida_os.id_filial Where saida_os.cod_saida_os = 0"
        Source(sql)
    End Sub
    Public Sub New(ByVal cod_mov As Integer)
        Dim sql As String
        sql = "SELECT movimentomaster.cod_natureza, movimentomaster.data, " &
        "movimentomaster.doc, movimentomaster.concluido," &
        "movimentomaster.id_usuario, saida_os.cod_movimento, " &
        "saida_os.id_filial,saida_os.id_filial_os, saida_os.cod_os, saida_os.cod_saida_os " &
        "FROM movimentomaster INNER JOIN " &
        "saida_os ON movimentomaster.cod_movimento = saida_os.cod_movimento AND " &
        "movimentomaster.id_filial = saida_os.id_filial " &
        "where saida_os.cod_movimento = " & cod_mov & " and saida_os.id_filial = " & conf.Filial &
        " order by movimentomaster.data Desc"
        Source(sql)
    End Sub
    Public Sub carrega_saida_os(ByVal x_cod_os As Integer, ByVal x_id_filial As Integer, ByVal x_id_filial_os As Integer)
        Dim sql As String
        sql = "SELECT movimentomaster.cod_natureza, movimentomaster.data, " &
        "movimentomaster.doc,movimentomaster.concluido, " &
        "movimentomaster.id_usuario, saida_os.cod_movimento, " &
        "saida_os.id_filial,saida_os.id_filial_os, saida_os.cod_os, saida_os.cod_saida_os " &
        "FROM movimentomaster INNER JOIN " &
        "saida_os ON movimentomaster.cod_movimento = saida_os.cod_movimento AND " &
        "movimentomaster.id_filial = saida_os.id_filial " &
        "where saida_os.cod_os = " & x_cod_os & " and saida_os.id_filial = " & x_id_filial &
        " and saida_os.id_filial_os = " & x_id_filial_os & " order by movimentomaster.data Desc"
        Source(sql)
    End Sub
    Public Sub carrega_saida_os(ByVal x_cod_os As Integer, ByVal x_id_filial As Integer, ByVal x_id_filial_os As Integer, ByVal x_concluido As String)
        Dim sql As String
        sql = "SELECT movimentomaster.cod_natureza, movimentomaster.data, " &
        "movimentomaster.doc,movimentomaster.concluido, " &
        "movimentomaster.id_usuario, saida_os.cod_movimento, " &
        "saida_os.id_filial,saida_os.id_filial_os, saida_os.cod_os, saida_os.cod_saida_os " &
        "FROM movimentomaster INNER JOIN " &
        "saida_os ON movimentomaster.cod_movimento = saida_os.cod_movimento AND " &
        "movimentomaster.id_filial = saida_os.id_filial " &
        "where saida_os.cod_os = " & x_cod_os & " and saida_os.id_filial = " & x_id_filial &
        " and saida_os.id_filial_os = " & x_id_filial_os & " and movimentomaster.concluido = " &
        d.PStr(x_concluido) & " order by movimentomaster.data Desc"
        Source(sql)
    End Sub
    Public Sub filtra(ByVal x_cod_os As Integer, ByVal x_id_filial As Integer, ByVal x_id_filial_os As Integer, ByVal x_concluido As String)
        Dim sql As String
        sql = "SELECT movimentomaster.cod_natureza, movimentomaster.data, " &
        "movimentomaster.doc,movimentomaster.concluido, " &
        "movimentomaster.id_usuario, saida_os.cod_movimento, " &
        "saida_os.id_filial,saida_os.id_filial_os, saida_os.cod_os, saida_os.cod_saida_os " &
        "FROM movimentomaster INNER JOIN " &
        "saida_os ON movimentomaster.cod_movimento = saida_os.cod_movimento AND " &
        "movimentomaster.id_filial = saida_os.id_filial " &
        "where saida_os.cod_os = " & x_cod_os & " and saida_os.id_filial = " & x_id_filial &
        " and saida_os.id_filial_os = " & x_id_filial_os &
        " AND (movimentomaster.concluido = '" & x_concluido & "') order by movimentomaster.data Desc"
        Source(sql)
    End Sub
    Public Sub filtra(ByVal x_cod_os As Integer, ByVal x_id_filial_os As Integer, ByVal x_concluido As String)
        Dim sql As String
        sql = "SELECT movimentomaster.cod_natureza, movimentomaster.data, " &
        "movimentomaster.doc,movimentomaster.concluido, " &
        "movimentomaster.id_usuario, saida_os.cod_movimento, " &
        "saida_os.id_filial,saida_os.id_filial_os, saida_os.cod_os, saida_os.cod_saida_os " &
        "FROM movimentomaster INNER JOIN " &
        "saida_os ON movimentomaster.cod_movimento = saida_os.cod_movimento AND " &
        "movimentomaster.id_filial = saida_os.id_filial " &
        "where saida_os.cod_os = " & x_cod_os &
        " And saida_os.id_filial_os = " & x_id_filial_os &
        " AND (movimentomaster.concluido = '" & x_concluido & "') order by movimentomaster.data Desc"
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
            _cod_saida_os = tb.Rows(p)("cod_saida_os")
            _id_filial = tb.Rows(p)("id_filial")
            _id_filial_os = tb.Rows(p)("id_filial_os")
            _cod_os = tb.Rows(p)("cod_os")
            _cod_natureza = tb.Rows(p)("cod_natureza")
            _data = tb.Rows(p)("data")
            _doc = tb.Rows(p)("doc")
            _id_usuario = tb.Rows(p)("id_usuario")
            _concluido = rdTexto(tb.Rows(p)("concluido"))
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
        _cod_movimento = retorna_Chave("cod_movimento", "movimentomaster", " where id_filial = " & conf.Filial)
        _cod_saida_os = retorna_Chave("cod_saida_os", "saida_os", " where id_filial = " & conf.Filial)

        ' _cod_compra = retorna_Chave("cod_compra", "compras", "where id_filial = " & confFilial)
        _id_filial = conf.Filial
        _id_filial_os = Nothing
        _cod_natureza = 2
        _data = Nothing
        _doc = Nothing
        _id_usuario = UserID
        OrigemSalvar = "Novo" 'Define o tipo de ação ao salvar
    End Function
    Public Function Salvar() As String
        Dim cmd As New SqlClient.SqlCommand
        Dim sql As String
        Dim res As String 'Quantidade de registros afetados
        d.conecta()
        cmd.Connection = d.con
        If OrigemSalvar = "Novo" Then
            Try
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
                sql = "INSERT INTO saida_os(cod_movimento,cod_saida_os,id_filial,id_filial_os,cod_os) " & _
                "VALUES (" & _cod_movimento & "," & _cod_saida_os & "," & _id_filial & _
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
            r("cod_saida_os") = _cod_saida_os
            r("id_filial") = _id_filial
            r("id_filial_os") = _id_filial_os
            r("cod_os") = _cod_os
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
                ",id_filial_os = " & _id_filial_os & _
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
                sql = "UPDATE saida_os SET cod_movimento = " & _cod_movimento & _
                ",cod_saida_os = " & _cod_saida_os & ",id_filial  = " & _id_filial & _
                ",cod_os  = " & _cod_os & _
                " WHERE cod_movimento = " & chaveCriterio1 & _
                " and id_filial = " & chaveCriterio2 & ""
                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tb.Rows(posicao)
            r("cod_movimento") = _cod_movimento
            r("cod_saida_os") = _cod_saida_os
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
    Public Function existe_saida_os(ByVal x_cod_os As Integer, ByVal x_id_filial As Integer, ByVal x_id_filial_os As Integer) As Boolean
        Dim sql As String
        Dim tb_saida As New DataTable
        sql = "SELECT movimentomaster.cod_natureza, movimentomaster.data, " & _
        "movimentomaster.doc, " & _
        "movimentomaster.id_usuario, saida_os.cod_movimento, " & _
        "saida_os.id_filial,saida_os.id_filial_os, saida_os.cod_os, saida_os.cod_saida_os " & _
        "FROM movimentomaster INNER JOIN " & _
        "saida_os ON movimentomaster.cod_movimento = saida_os.cod_movimento AND " & _
        "movimentomaster.id_filial = saida_os.id_filial " & _
        "where saida_os.cod_os = " & x_cod_os & " and saida_os.id_filial = " & x_id_filial & _
        " and saida_os.id_filial_os = " & x_id_filial_os & ""
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
        " WHERE (id_filial = " & Me._id_filial & ") AND " & _
        "(cod_Movimento = " & Me._cod_movimento & ") and status = 0"
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
    Public Function tem_produto(ByVal x_cod_prod As Integer) As Integer
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT cod_produto, cod_Movimento, id_filial, status " & _
        "FROM movimento WHERE (cod_Movimento = " & Me._cod_movimento & _
        ") AND (id_filial = " & Me._id_filial & ") AND (cod_produto = " & _
        x_cod_prod & ") AND (status = 0)"
        d.carrega_Tabela(sql, tt)
        Return tt.Rows.Count
    End Function
#End Region
End Class
