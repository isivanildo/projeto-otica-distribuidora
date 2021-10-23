Public Class objCancalePedido
    Dim conf As New config
#Region "Atributos"
    Private _cod_cancelamento_pedido As Integer
    Private _id_filial As Integer
    Private _num_pedido As Integer
    Private _cod_devolucao_pedido As Object
    Private _data As Object
    Private _cod_usuario As Object
    Private _concluido As String
    Private _descricao As Object
    Private _valor_cancelado As Object

    Public posicao As Integer = 0
    Public max As Integer
    Public tabela As New DataTable
    Public Enovo As Boolean = False
    Private lastPos As Integer = 0
    Private sql As String
    Dim d As New dados
#End Region
#Region "GET SET"
    Public Property cod_cancelamento_pedido() As Integer
        Get
            cod_cancelamento_pedido = _cod_cancelamento_pedido
        End Get
        Set(ByVal Value As Integer)
            _cod_cancelamento_pedido = Value
        End Set
    End Property
    Public Property id_filial() As Integer
        Get
            id_filial = _id_filial
        End Get
        Set(ByVal Value As Integer)
            _id_filial = Value
        End Set
    End Property
    Public Property num_pedido() As Integer
        Get
            num_pedido = _num_pedido
        End Get
        Set(ByVal Value As Integer)
            _num_pedido = Value
        End Set
    End Property
    Public Property cod_devolucao_pedido() As Object
        Get
            cod_devolucao_pedido = _cod_devolucao_pedido
        End Get
        Set(ByVal Value As Object)
            _cod_devolucao_pedido = Value
        End Set
    End Property
    Public Property data() As Object
        Get
            data = _data
        End Get
        Set(ByVal Value As Object)
            _data = Value
        End Set
    End Property
    Public Property cod_usuario() As Integer
        Get
            cod_usuario = _cod_usuario
        End Get
        Set(ByVal Value As Integer)
            _cod_usuario = Value
        End Set
    End Property
    Public Property concluido() As String
        Get
            concluido = _concluido
        End Get
        Set(ByVal Value As String)
            _concluido = Value
        End Set
    End Property
    Public Property descricao() As String
        Get
            descricao = _descricao
        End Get
        Set(ByVal Value As String)
            _descricao = Value
        End Set
    End Property
    Public Property valor_cancelado()
        Get
            valor_cancelado = _valor_cancelado
        End Get
        Set(ByVal value)
            _valor_cancelado = value
        End Set
    End Property

#End Region
#Region "Procedimentos"
    Public Sub New()
        Dim sql As String
        sql = "Select * from cancelamento_pedido where cod_cancelamento_pedido = 0"
        Source(sql)
    End Sub
    Public Sub New(ByVal x_id_filial As Integer, ByVal x_num_pedido As Integer)
        Dim sql As String
        sql = "Select * from cancelamento_pedido where id_filial = " & x_id_filial & _
        " and num_pedido = " & x_num_pedido & ""
        Source(sql)
    End Sub
    Public Sub Source(ByVal iSql As String)
        sql = iSql
        Me.refreshData()
        primeiro()
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
            _cod_cancelamento_pedido = tabela.Rows(p)("cod_cancelamento_pedido")
            _id_filial = tabela.Rows(p)("id_filial")
            _cod_devolucao_pedido = rdNum(tabela.Rows(p)("cod_devolucao_pedido"))
            _data = rdData(tabela.Rows(p)("data"))
            _cod_usuario = tabela.Rows(p)("cod_usuario")
            _concluido = rdTexto(tabela.Rows(p)("concluido"))
            _descricao = rdTexto(tabela.Rows(p)("descricao"))
            _valor_cancelado = rdNum(tabela.Rows(p)("valor_cancelado"))
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
        Enovo = False
    End Sub
#End Region
#Region "Funções"
    Public Sub novo()
        lastPos = posicao 'guarda a posição do último Registro
        'Zera Variáveis
        _cod_cancelamento_pedido = Nothing
        _id_filial = Nothing
        _cod_devolucao_pedido = Nothing
        _data = Nothing
        _cod_usuario = Nothing
        _concluido = "N"
        _descricao = Nothing
        _valor_cancelado = Nothing
        Enovo = True
    End Sub
    Public Function Salvar() As String
        Dim cmd As New SqlClient.SqlCommand
        Dim sql As String
        Dim res As String
        d.conecta()
        If Enovo = True Then
            Try
                _cod_cancelamento_pedido = retorna_Chave("cod_cancelamento_pedido", "cancelamento_pedido", " where id_filial = " & conf.Filial & "")
                sql = "INSERT INTO Cancelamento_pedido (cod_cancelamento_pedido ,id_filial,num_pedido,cod_devolucao_pedido " & _
                ",data,cod_usuario ,concluido,descricao,valor_cancelado) VALUES(" & _
                _cod_cancelamento_pedido & _
                "," & _id_filial & _
                "," & _num_pedido & _
                "," & d.cdin(_cod_devolucao_pedido) & _
                "," & d.Pdt(_data) & _
                "," & _cod_usuario & _
                "," & d.PStr(_concluido) & _
                "," & d.PStr(_descricao) & _
                "," & d.cdin(_valor_cancelado) & ")"
                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tabela.NewRow
            r("cod_cancelamento_pedido") = _cod_cancelamento_pedido
            r("id_filial") = _id_filial
            r("num_pedido") = wrNum(_num_pedido)
            r("cod_devolucao_pedido") = wrNum(_cod_devolucao_pedido)
            r("data") = wrData(_data)
            r("cod_usuario") = _cod_usuario
            r("concluido") = rdTexto(_concluido)
            r("descricao") = rdTexto(_descricao)
            r("valor_cancelado") = rdNum(valor_cancelado)
            tabela.Rows.Add(r)
            max = max + 1
            If max = 1 Then
                posicao = 0
            Else
                posicao = max - 1
            End If
            Enovo = False
            Return "OK:" & res & " registro(s) adicionado(s) com sucesso!"
            Exit Function
        End If
        If Enovo = False Then
            Try
                sql = "UPDATE Cancelamento_pedido SET id_filial = " & _id_filial & _
                ", cod_devolucao_pedido = " & d.cdin(_cod_devolucao_pedido) & _
                ",data = " & d.Pdt(_data) & _
                ",cod_usuario = " & _cod_usuario & _
                ",concluido = " & d.PStr(_concluido) & _
                ",descricao = " & d.PStr(_descricao) & _
                ",valor_cancelado = " & d.cdin(_valor_cancelado) & _
                " WHERE cod_cancelamento_pedido = " & _cod_cancelamento_pedido & _
                " and id_filial = " & _id_filial & ""
                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tabela.Rows(posicao)
            r("cod_cancelamento_pedido") = _cod_cancelamento_pedido
            r("id_filial") = _id_filial
            r("num_pedido") = wrNum(_num_pedido)
            r("cod_devolucao_pedido") = wrNum(_cod_devolucao_pedido)
            r("data") = wrData(_data)
            r("cod_usuario") = _cod_usuario
            r("concluido") = rdTexto(_concluido)
            r("descricao") = rdTexto(_descricao)
            r("valor_cancelado") = wrNum(_valor_cancelado)
            Return "OK:" & res & " registro(s) atualizado(s) com sucesso!"
        End If
    End Function
    Public Function concluir() As String
        Dim sql As String
        sql = "update cancelamento_pedido set concluido = 'S' " & _
        " where cod_cancelamento_pedido = " & _cod_cancelamento_pedido & " and " & _
        " id_filial = " & _id_filial & ""
        Return d.Comando(sql, True)
    End Function
#End Region
End Class