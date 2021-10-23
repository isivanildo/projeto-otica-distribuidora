Public Class objCancelOS
    Dim conf As New config
#Region "Atributos"
    Private _cod_cancelamento_os As Integer
    Private _id_filial As Integer
    Private _cod_os As Integer
    Private _cod_devolucao_os As Object
    Private _data As Object
    Private _cod_usuario As Object
    Private _concluido As String
    Private _descricao As Object
    Private _valor_cancelado As Object
    Public saida As New objSaidaOS

    Public posicao As Integer = 0
    Public max As Integer
    Public tabela As New DataTable
    Public Enovo As Boolean = False
    Private lastPos As Integer = 0
    Private sql As String
    Dim d As New dados
#End Region
#Region "GET SET"
    Public Property cod_cancelamento_os() As Integer
        Get
            cod_cancelamento_os = _cod_cancelamento_os
        End Get
        Set(ByVal Value As Integer)
            _cod_cancelamento_os = Value
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
    Public Property cod_os() As Integer
        Get
            cod_os = _cod_os
        End Get
        Set(ByVal Value As Integer)
            _cod_os = Value
        End Set
    End Property
    Public Property cod_devolucao_os() As Object
        Get
            cod_devolucao_os = _cod_devolucao_os
        End Get
        Set(ByVal Value As Object)
            _cod_devolucao_os = Value
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
        sql = "Select * from cancelamento_os where cod_cancelamento_Os = 0"
        Source(sql)
    End Sub
    Public Sub New(ByVal x_id_filial As Integer, ByVal x_cod_os As Integer)
        Dim sql As String
        sql = "Select * from cancelamento_os where id_filial = " & x_id_filial & _
        " and cod_os = " & x_cod_os & ""
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
            _cod_cancelamento_os = tabela.Rows(p)("cod_cancelamento_os")
            _id_filial = tabela.Rows(p)("id_filial")
            _cod_devolucao_os = rdNum(tabela.Rows(p)("cod_devolucao_os"))
            _data = rdData(tabela.Rows(p)("data"))
            _cod_usuario = tabela.Rows(p)("cod_usuario")
            _concluido = rdTexto(tabela.Rows(p)("concluido"))
            _descricao = rdTexto(tabela.Rows(p)("descricao"))
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
        _cod_cancelamento_os = Nothing
        _id_filial = Nothing
        _cod_devolucao_os = Nothing
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
                _cod_cancelamento_os = retorna_Chave("cod_cancelamento_os", "cancelamento_os", " where id_filial = " & conf.Filial & "")
                sql = "INSERT INTO Cancelamento_os (cod_cancelamento_os ,id_filial,cod_os,cod_devolucao_os " & _
                ",data,cod_usuario ,concluido,descricao,valor_cancelado) VALUES(" & _
                _cod_cancelamento_os & _
                "," & _id_filial & _
                "," & _cod_os & _
                "," & d.cdin(_cod_devolucao_os) & _
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
            r("cod_cancelamento_os") = _cod_cancelamento_os
            r("id_filial") = _id_filial
            r("cod_os") = wrNum(_cod_os)
            r("cod_devolucao_os") = wrNum(_cod_devolucao_os)
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
                sql = "UPDATE Cancelamento_os SET id_filial = " & _id_filial & _
                ", cod_devolucao_os = " & d.cdin(_cod_devolucao_os) & _
                ",data = " & d.Pdt(_data) & _
                ",cod_usuario = " & _cod_usuario & _
                ",concluido = " & d.PStr(_concluido) & _
                ",descricao = " & d.PStr(_descricao) & _
                ",valor_cancelado = " & d.cdin(_valor_cancelado) & _
                " WHERE cod_cancelamento_os = " & _cod_cancelamento_os & _
                " and id_filial = " & _id_filial & ""
                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tabela.Rows(posicao)
            r("cod_cancelamento_os") = _cod_cancelamento_os
            r("id_filial") = _id_filial
            r("cod_os") = wrNum(_cod_os)
            r("cod_devolucao_os") = wrNum(_cod_devolucao_os)
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
        sql = "update cancelamento_os set concluido = 'S' " & _
        " where cod_cancelamento_os = " & _cod_cancelamento_os & " and " & _
        " id_filial = " & _id_filial & ""
        Return d.Comando(sql, True)
    End Function
#End Region
End Class
