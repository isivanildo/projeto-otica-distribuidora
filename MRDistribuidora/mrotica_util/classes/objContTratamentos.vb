Public Class objContTratamentos
#Region "Atributos"
    Private _cod_controle_tratamento As Integer
    Private _cod_filial As Integer
    Private _id_filial_os As Integer
    Private _cod_os As Integer
    Private _os_fornecedor As Object
    Private _data_envio As Object
    Private _data_retorno As Object
    Private _cod_usuario As Integer
    Private _obs As String

    Public posicao As Integer = 0
    Public max As Integer
    Public chaveCriterio As Object
    Public tb As New DataTable
    Public OrigemSalvar As String = ""
    Private lastPos As Integer = 0
    Private sql As String
    Dim d As New dados
#End Region
#Region "GET SET"
    Public Property cod_controle_andamento()
        Get
            cod_controle_andamento = _cod_controle_tratamento
        End Get
        Set(ByVal Value)
            _cod_controle_tratamento = Value
        End Set
    End Property
    Public Property cod_filial()
        Get
            cod_filial = _cod_filial
        End Get
        Set(ByVal Value)
            _cod_filial = Value
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
    Public Property id_filial_os()
        Get
            id_filial_os = _id_filial_os
        End Get
        Set(ByVal Value)
            _id_filial_os = Value
        End Set
    End Property
    Public Property os_fornecedor()
        Get
            os_fornecedor = _os_fornecedor
        End Get
        Set(ByVal value)
            _os_fornecedor = value
        End Set
    End Property
    Public Property data_envio()
        Get
            data_envio = _data_envio
        End Get
        Set(ByVal value)
            _data_envio = value
        End Set
    End Property
    Public Property data_retorno()
        Get
            data_retorno = _data_retorno
        End Get
        Set(ByVal value)
            _data_retorno = value
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
    Public Property obs()
        Get
            obs = _obs
        End Get
        Set(ByVal value)
            _obs = value
        End Set
    End Property
#End Region
#Region "Procedimentos"
    Public Sub New()
        Dim sql As String
        sql = "Select * from controle_tratamento where cod_controle_tratamento = 0"
        Source(sql)
    End Sub
    Public Sub filtra(ByVal x_cod_controle_tratamento As Integer)
        sql = "select * from controle_tratamento where cod_controle_tratamento = " & x_cod_controle_tratamento &
        " and cod_filial = " & confFilial & ""
        Source(sql)
    End Sub
    Public Sub filtra(ByVal x_cod_os As Integer, ByVal x_id_filial_os As Integer)
        sql = "select * from controle_tratamento where cod_os = " & x_cod_os & _
        " and id_filial_os = " & x_id_filial_os & " order by data_envio asc"
        Source(sql)
    End Sub

    Public Sub Source(ByVal iSql As String)
        sql = iSql
        Me.refreshData()
    End Sub
    Public Sub refreshData()
        d.carrega_Tabela(sql, tb)
        max = tb.Rows.Count
        primeiro()
    End Sub
    Public Sub Registro(ByVal pos As Integer) 'Move o Registro para a posição indicada
        Dim p As Integer = pos
        If p <= 0 Then p = 0
        If p > max Then p = max
        posicao = p
        If max > 0 Then
            _cod_controle_tratamento = tb.Rows(p)("cod_controle_tratamento")
            _cod_filial = tb.Rows(p)("cod_filial")
            _cod_os = tb.Rows(p)("cod_os")
            _id_filial_os = tb.Rows(p)("id_filial_os")
            _os_fornecedor = rdTexto(tb.Rows(p)("os_fornecedor"))
            _data_envio = rdData(tb.Rows(p)("data_envio"))
            _data_retorno = rdData(tb.Rows(p)("data_retorno"))
            _cod_usuario = tb.Rows(p)("cod_usuario")
            _obs = rdTexto(tb.Rows(p)("obs"))
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
        _cod_controle_tratamento = retorna_Chave("cod_controle_tratamento", "controle_tratamento", "where cod_filial = " & confFilial & "")
        _cod_filial = confFilial
        _cod_os = Nothing
        _id_filial_os = Nothing
        _os_fornecedor = Nothing
        _data_envio = Nothing
        _data_retorno = Nothing
        _cod_usuario = Nothing
        _obs = Nothing
        OrigemSalvar = "Novo" 'Define o tipo de ação ao salvar
    End Function
    Public Function Salvar() As String
        Dim sql As String
        Dim res As String
        d.conecta()
        If OrigemSalvar = "Novo" Then
            Try
                sql = "INSERT INTO Controle_tratamento (cod_controle_tratamento" & _
                ",cod_filial ,id_filial_os ,cod_os ,os_fornecedor ,data_envio" & _
                ",data_retorno ,cod_usuario,obs) VALUES (" & _cod_controle_tratamento & _
                "," & _cod_filial & "," & id_filial_os & "," & _cod_os & _
                "," & d.PStr(_os_fornecedor) & _
                "," & d.Pdt(_data_envio) & _
                "," & d.Pdt(_data_retorno) & _
                "," & _cod_usuario & _
                "," & d.PStr(_obs) & ")"
                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tb.NewRow
            r("cod_controle_tratamento") = _cod_controle_tratamento
            r("cod_filial") = _cod_filial
            r("cod_os") = _cod_os
            r("id_filial_os") = _id_filial_os
            r("os_fornecedor") = _os_fornecedor
            r("data_envio") = wrData(_data_envio)
            r("data_retorno") = wrData(_data_retorno)
            r("cod_usuario") = _cod_usuario
            r("obs") = _obs
            tb.Rows.Add(r)
            max = max + 1
            If max = 1 Then
                posicao = 0
            Else
                posicao = max - 1
            End If
            OrigemSalvar = ""
            Return res
        End If
        If Me.OrigemSalvar = "Editar" Then
            Try
                sql = "UPDATE Controle_tratamento SET cod_controle_tratamento = " & _
                _cod_controle_tratamento & ",cod_filial = " & _cod_filial & _
                ",id_filial_os =" & _id_filial_os & ",cod_os = " & _cod_os & _
                ",os_fornecedor = " & d.PStr(_os_fornecedor) & ",data_envio = " & _
                d.Pdt(_data_envio) & ",data_retorno =" & d.Pdt(_data_retorno) & _
                ",cod_usuario = " & _cod_usuario & ",obs = " & d.PStr(_obs) & _
                " WHERE cod_controle_tratamento = " & _cod_controle_tratamento & _
                " and cod_filial = " & _cod_filial & ""
                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tb.Rows(posicao)
            r("cod_controle_tratamento") = _cod_controle_tratamento
            r("cod_filial") = _cod_filial
            r("cod_os") = _cod_os
            r("id_filial_os") = _id_filial_os
            r("os_fornecedor") = _os_fornecedor
            r("data_envio") = wrData(_data_envio)
            r("data_retorno") = wrData(_data_retorno)
            r("cod_usuario") = _cod_usuario
            r("obs") = _obs
            OrigemSalvar = ""
            Return "OK:" & res & " registro(s) atualizado(s) com sucesso!"
        End If
    End Function
    Public Function deletar(ByVal x_cod_controle_tratamento As Integer, ByVal x_cod_filial As Integer)
        Dim cmd As New SqlClient.SqlCommand
        Dim res As Integer
        d.conecta()
        cmd.Connection = d.con
        cmd.CommandText = "Delete from controle_tratamento " & _
        " WHERE cod_controle_tratamento = " & x_cod_controle_tratamento & _
                " and cod_filial = " & x_cod_filial & ""
        Try
            res = cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Me.refreshData()
        Me.primeiro()
        Return res & " Registros foram apagados!"
    End Function
#End Region
End Class
