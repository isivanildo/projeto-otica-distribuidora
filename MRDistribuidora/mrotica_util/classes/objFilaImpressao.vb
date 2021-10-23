Public Class objFilaImpressao
#Region "Atributos"
    Private _id_filial As Integer
    Private _cod_os As Object
    Private _via As Object
    Private _data_inclusao As Object
    Private _data_impressao As Object
    Private _extra As String
    Private _filial_impressao As Integer
    Public posicao As Integer = 0
    Public max As Integer
    Public chaveCriterio As Object
    Public tb As New DataTable
    Public OrigemSalvar As String = ""
    Private lastPos As Integer = 0
    Private sql As String
    Dim d As New dados
    Dim c As New config
#End Region
#Region "GET SET"
    Public Property id_filial()
        Get
            id_filial = _id_filial
        End Get
        Set(ByVal Value)
            _id_filial = Value
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
    Public Property via()
        Get
            via = _via
        End Get
        Set(ByVal Value)
            _via = Value
        End Set
    End Property
    Public Property data_inclusao()
        Get
            data_inclusao = _data_inclusao
        End Get
        Set(ByVal Value)
            _data_inclusao = Value
        End Set
    End Property
    Public Property data_impressao()
        Get
            data_impressao = _data_impressao
        End Get
        Set(ByVal Value)
            _data_impressao = Value
        End Set
    End Property
    Public Property extra()
        Get
            extra = _extra
        End Get
        Set(ByVal Value)
            _extra = Value
        End Set
    End Property
    Public Property filial_impressao()
        Get
            filial_impressao = _filial_impressao
        End Get
        Set(ByVal value)
            _filial_impressao = value
        End Set
    End Property
#End Region
#Region "Procedimentos"
    Public Sub New()
        Dim sql As String
        sql = "Select * from fila_impressao_os where id_filial = 0"
        Source(sql)
    End Sub
    Public Sub Source(ByVal iSql As String)
        sql = iSql
        Me.refreshData()
    End Sub
    Public Sub refreshData()
        d.carrega_Tabela(sql, tb)
        max = tb.Rows.Count
    End Sub
    Public Sub Registro(ByVal pos As Integer) 'Move o Registro para a posição indicada
        Dim p As Integer = pos
        If p <= 0 Then p = 0
        If p > max Then p = max
        posicao = p
        If max > 0 Then
            _cod_os = tb.Rows(p)("cod_os")
            _id_filial = tb.Rows(p)("id_filial")
            _via = tb.Rows(p)("via")
            _data_inclusao = rdData(tb.Rows(p)("data_inclusao"))
            _data_impressao = rdData(tb.Rows(p)("data_impressao"))
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
        _id_filial = Nothing
        _cod_os = Nothing
        _via = Nothing
        _data_inclusao = Nothing
        _data_impressao = Nothing
        _extra = Nothing
        _filial_impressao = c.Filial
        OrigemSalvar = "Novo" 'Define o tipo de ação ao salvar
    End Function
    Public Function Salvar() As String
        Dim sql As String
        Dim res As String
        d.conecta()
        If OrigemSalvar = "Novo" Then
            Try
                sql = "Insert into fila_impressao_os (cod_os,id_filial,via, " & _
                "data_inclusao,data_impressao,extra,filial_impressao) " & _
                "Values(" & _
                _cod_os & "," & _id_filial & "," & _via & "," & _
                d.pdtm(d.hora) & "," & d.pdtm(_data_impressao) & _
                "," & d.PStr(_extra) & _
                "," & _filial_impressao & ")"

                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tb.NewRow
            r("cod_os") = _cod_os
            r("id_filial") = _id_filial
            r("via") = _via
            r("data_inclusao") = rdData(_data_inclusao)
            r("data_impressao") = wrData(_data_impressao)
            r("extra") = rdTexto(_extra)
            r("filial_impressao") = rdNum(_filial_impressao)
            tb.Rows.Add(r)
            max = max + 1
            If max = 1 Then
                posicao = 0
            Else
                posicao = max - 1
            End If
            OrigemSalvar = ""
            Return res '& " registro(s) adicionado(s) com sucesso!"
        End If
        If Me.OrigemSalvar = "Editar" Then
            Try
                sql = "Update fila_impressao_os set " & _
                ",data_inclusao = " & _data_inclusao & _
                ",data_impressao = " & _data_impressao & _
                ",filial_impressao = " & _filial_impressao & _
                " where cod_os = " & Me._cod_os & " and " & _
                "id_filial = " & Me._id_filial & " and " & _
                "via = " & Me._via & ""
                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tb.Rows(posicao)
            r("cod_os") = _cod_os
            r("id_filial") = _id_filial
            r("via") = _via
            r("data_inclusao") = rdData(_data_inclusao)
            r("data_impressao") = rdData(_data_impressao)
            r("filial_impressao") = rdNum(_filial_impressao)
            OrigemSalvar = ""
            Return res '& " registro(s) atualizado(s) com sucesso!"
        End If
    End Function
    Public Function Inserir_fila(ByVal x_cod_os As Integer, ByVal x_id_filial As Integer, ByVal f_impressao As Integer) As String
        Dim sql As String
        Dim via As Integer = 1
        Dim tb_fila As New DataTable
        Dim dv_fila As New DataView
        sql = "Select * from fila_impressao_os where cod_os = " & x_cod_os & _
        " and id_filial = " & x_id_filial & " Order by via DESC"
        d.carrega_Tabela(sql, tb_fila)
        If tb_fila.Rows.Count > 0 Then
            dv_fila.Table = tb_fila
            dv_fila.RowFilter = " data_impressao is null"
            If dv_fila.Count > 0 Then
                Return "Esta O.S. já está na fila aguardando impressao!"
            Else
                via = tb_fila.Rows(0)("via") + 1
            End If
        End If
        Me.novo()
        _id_filial = x_id_filial
        _cod_os = x_cod_os
        _via = via
        _data_inclusao = d.hora
        _extra = "N"
        _filial_impressao = f_impressao
        Return Me.Salvar()
    End Function
    Public Function Inserir_fila(ByVal x_cod_os As Integer, ByVal x_id_filial As Integer, ByVal extra As String, ByVal f_impressao As Integer) As String
        Dim sql As String
        Dim via As Integer = 1
        Dim tb_fila As New DataTable
        Dim dv_fila As New DataView
        sql = "Select * from fila_impressao_os where cod_os = " & x_cod_os & _
        " and id_filial = " & x_id_filial & " Order by via DESC"
        d.carrega_Tabela(sql, tb_fila)
        If tb_fila.Rows.Count > 0 Then
            dv_fila.Table = tb_fila
            dv_fila.RowFilter = " data_impressao is null"
            If dv_fila.Count > 0 Then
                Return "Esta O.S. já está na fila aguardando impressao!"
            Else
                via = tb_fila.Rows(0)("via") + 1
            End If
        End If
        Me.novo()
        _id_filial = x_id_filial
        _cod_os = x_cod_os
        _via = via
        _data_inclusao = d.hora
        _extra = extra
        _filial_impressao = f_impressao
        Return Me.Salvar()
    End Function
    Public Function ultima_via(ByVal x_id_filial As Integer, ByVal x_cod_os As Integer) As Integer
        Dim tb_fila As New DataTable
        sql = "Select * from fila_impressao_os where cod_os = " & x_cod_os & _
       " and id_filial = " & x_id_filial & " Order by via DESC"
        d.carrega_Tabela(sql, tb_fila)
        If tb_fila.Rows.Count > 0 Then
            Return tb_fila.Rows(0)("via") + 1
        Else
            Return 0
        End If
    End Function
#End Region
End Class
