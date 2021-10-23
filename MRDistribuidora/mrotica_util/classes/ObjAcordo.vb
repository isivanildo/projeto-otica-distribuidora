Public Class objAcordo
#Region "Atributos"
    Private _cod_acordo As Integer
    Private _filial_acordo As Integer
    Private _data As Object
    Private _descricao As String
    Private _acrescimo As Decimal
    Private _cod_usuario As Integer = UserID
    Private _cod_gerente As Integer
    Private _cod_status_acordo As Integer
    Private _cod_filial_cliente As Int16
    Private _cod_cliente As Int64
    Public posicao As Integer = 0
    Public max As Integer
    Public tb As New DataTable
    Public eNovo As Boolean = False
    Private lastPos As Integer = 0
    Private sql As String
    Dim conf As New config
    Dim d As New dados
#End Region
#Region "GET SET"
    Public Property cod_acordo()
        Get
            cod_acordo = _cod_acordo
        End Get
        Set(ByVal value)
            _cod_acordo = value
        End Set
    End Property
    Public Property filial_acordo()
        Get
            filial_acordo = _filial_acordo
        End Get
        Set(ByVal value)
            _filial_acordo = value
        End Set
    End Property
    Public Property data()
        Get
            data = _data
        End Get
        Set(ByVal value)
            _data = value
        End Set
    End Property
    Public Property descricao()
        Get
            descricao = _descricao
        End Get
        Set(ByVal value)
            _descricao = value
        End Set
    End Property
    Public Property acrescimo()
        Get
            acrescimo = _acrescimo
        End Get
        Set(ByVal value)
            _acrescimo = value
        End Set
    End Property
    Public Property cod_usuario()
        Get
            cod_usuario = _cod_usuario
        End Get
        Set(ByVal value)
            _cod_usuario = value
        End Set
    End Property
    Public Property cod_gerente()
        Get
            cod_gerente = _cod_gerente
        End Get
        Set(ByVal value)
            _cod_gerente = value
        End Set
    End Property
    Public Property cod_status_acordo()
        Get
            cod_status_acordo = _cod_status_acordo
        End Get
        Set(ByVal value)
            _cod_status_acordo = value
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
#End Region
#Region "Procedimentos"
    Public Sub New()
        Dim sql As String
        sql = "Select * from acordo where cod_acordo = 0"
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
            _cod_acordo = tb.Rows(p)("cod_acordo")
            _filial_acordo = tb.Rows(p)("filial_acordo")
            _data = rdData(tb.Rows(p)("data"))
            _descricao = rdTexto(tb.Rows(p)("descricao"))
            _acrescimo = rdNum(tb.Rows(p)("acrescimo"))
            _cod_usuario = tb.Rows(p)("cod_usuario")
            _cod_gerente = rdNum(tb.Rows(p)("cod_gerente"))
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
        eNovo = False
    End Sub
#End Region
#Region "Funcoes"
    Public Sub novo()
        lastPos = posicao 'guarda a posição do último Registro
        'Inicializa Variáveis
        _cod_acordo = retorna_Chave("cod_acordo", "acordo", " where filial_acordo = " & conf.Filial)
        _filial_acordo = conf.Filial
        _data = Nothing
        _descricao = Nothing
        _acrescimo = Nothing
        _cod_usuario = UserID
        _cod_gerente = Nothing
        _cod_status_acordo = 1
        _cod_cliente = Nothing
        _cod_filial_cliente = Nothing
        eNovo = True  'Define o tipo de ação ao salvar
    End Sub
    Public Function Salvar() As String
        Dim sql As String
        Dim res As String 'Quantidade de registros afetados
        d.conecta()
        If eNovo = True Then
            Try
                sql = "INSERT INTO acordo " & _
                " (cod_acordo,filial_acordo " & _
                ",data,descricao,Acrescimo " & _
                ",cod_usuario,cod_gerente,cod_status_acordo " & _
                ",cod_filial_cliente,cod_cliente) " & _
                "VALUES " & _
                "(" & _cod_acordo & _
                "," & _filial_acordo & _
                "," & d.Pdt(_data) & _
                "," & d.PStr(_descricao) & _
                "," & d.cdin(_acrescimo) & _
                "," & _cod_usuario & _
                "," & d.cdin(_cod_gerente) & _
                ",1" & _
                "," & _cod_filial_cliente & _
                "," & _cod_cliente & _
                ")"
                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tb.NewRow
            r("cod_acordo") = _cod_acordo
            r("filial_acordo") = _filial_acordo
            r("data") = rdData(_data)
            r("descricao") = rdTexto(_descricao)
            r("acrescimo") = rdNum(_acrescimo)
            r("cod_usuario") = _cod_usuario
            r("cod_gerente") = _cod_gerente
            r("cod_status_acordo") = _cod_status_acordo
            r("cod_filial_cliente") = _cod_filial_cliente
            r("cod_cliente") = _cod_cliente
            tb.Rows.Add(r)
            max = max + 1
            If max = 1 Then
                posicao = 0
            Else
                posicao = max - 1
            End If
            eNovo = False
            Return "OK:" & res & " registro(s) adicionado(s) com sucesso!"
            Exit Function
        End If
        If eNovo = False Then
            Try
                sql = "UPDATE acordo set data = " & d.Pdt(_data) & _
                ",descricao = " & d.PStr(_descricao) & _
                ",Acrescimo = " & d.cdin(_acrescimo) & _
                ",cod_usuario = " & _cod_usuario & _
                ",cod_gerente = " & _cod_gerente & _
                ",cod_status_acordo = " & _cod_status_acordo & _
                " WHERE cod_acordo = " & _cod_acordo & " and " & _
                "filial_acordo = " & _filial_acordo & ""
                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tb.Rows(posicao)
            r("cod_acordo") = _cod_acordo
            r("filial_acordo") = _filial_acordo
            r("data") = rdData(_data)
            r("descricao") = rdTexto(_descricao)
            r("acrescimo") = rdNum(_acrescimo)
            r("cod_usuario") = _cod_usuario
            r("cod_gerente") = _cod_gerente
            r("cod_status_acordo") = _cod_status_acordo
            r("cod_filial_cliente") = _cod_filial_cliente
            r("cod_cliente") = _cod_cliente
            eNovo = False
            Return "OK:" & res & " registro(s) atualizado(s) com sucesso!"
        End If
    End Function
    Public Function insere_item(ByVal item As item_acordo)
        Dim tsql As String
        Dim trans As New objSqlTrans
        tsql = "INSERT INTO acordo_itens (item" & _
           ",cod_acordo,filial_acordo,cod_lancamento" & _
           ",id_filial_lancamento) VALUES(" & _
           item.item & _
           "," & _cod_acordo & _
           "," & _filial_acordo & _
           "," & item.cod_lancamento & _
           "," & item.id_filial_lancamento & ")"
        trans.insere_instrucao(tsql)
        tsql = "update lancamentos set cod_status_lancamento = 3 and data_recebimento = " & _
        d.pdtm(Now) & "  where " & _
        " cod_lancamento =  " & item.cod_lancamento & " and id_filial_lancamento = " & _
        item.id_filial_lancamento & ""
        trans.insere_instrucao(tsql)
        Return d.executa_transaction(trans.instrucoes, True)
    End Function
#End Region
End Class
Public Class item_acordo
    Dim _item As Integer
    Dim _cod_lancamento As Integer
    Dim _id_filial_lancamento As Integer
    Dim _cod_acordo As Integer
    Dim _filial_acordo As Integer
    
#Region "GETSET"
    Public ReadOnly Property item()
        Get
            item = _item
        End Get
    End Property
    Public Property cod_lancamento()
        Get
            cod_lancamento = _cod_lancamento
        End Get
        Set(ByVal value)
            _cod_lancamento = value
        End Set
    End Property
    Public Property id_filial_lancamento()
        Get
            id_filial_lancamento = _id_filial_lancamento
        End Get
        Set(ByVal value)
            _id_filial_lancamento = value
        End Set
    End Property
    Public WriteOnly Property cod_acordo()
        Set(ByVal value)
            _cod_acordo = value
        End Set
    End Property
    Public WriteOnly Property filial_acordo()
        Set(ByVal value)
            _filial_acordo = value
        End Set
    End Property
#End Region
    Public Sub New(ByVal x_cod_acordo As Integer, ByVal x_filial_acordo As Integer)
        _item = retorna_Chave("item", "acordo_itens", " where cod_acordo = " & _
                              x_cod_acordo & " and filial_acordo = " & _
                              x_filial_acordo & "")
        _cod_acordo = x_cod_acordo
        _filial_acordo = x_filial_acordo
    End Sub
    
End Class
