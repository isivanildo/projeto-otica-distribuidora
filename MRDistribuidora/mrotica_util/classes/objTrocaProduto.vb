Public Class objTrocaproduto
    Public Enum tipo_troca
        troca_base = 1
        troca_produto = 2
    End Enum
#Region "Atributos"
    Dim conf As New config
    Private _cod_troca_prod As Integer
    Private _id_filial As Integer
    Private _cod_os As Integer
    Private _id_filial_os As Integer
    Private _cod_prod_od As Integer
    Private _cod_prod_od_novo As Integer
    Private _prod_od_ok As String
    Private _cod_prod_oe As Integer
    Private _cod_prod_oe_novo As Integer
    Private _prod_oe_ok As String
    Private _concluido As String
    Private _id_usuario As Integer
    Private _cod_devolucao_os As Integer
    Private _cod_tipo_troca As tipo_troca
    Private _obs As String

    Public posicao As Integer = 0
    Public max As Integer
    Public chaveCriterio1, chaveCriterio2 As Object
    Public tb As New DataTable
    Public OrigemSalvar As String = ""
    Private lastPos As Integer = 0
    Private sql As String
    Dim d As New dados
#End Region
#Region "GET SET"
    Public Property cod_troca_prod()
        Get
            cod_troca_prod = _cod_troca_prod
        End Get
        Set(ByVal Value)
            _cod_troca_prod = Value
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
    Public Property cod_prod_od()
        Get
            cod_prod_od = _cod_prod_od
        End Get
        Set(ByVal value)
            _cod_prod_od = value
        End Set
    End Property
    Public Property cod_prod_od_novo()
        Get
            cod_prod_od_novo = _cod_prod_od_novo
        End Get
        Set(ByVal value)
            _cod_prod_od_novo = value
        End Set
    End Property
    Public Property prod_od_OK()
        Get
            prod_od_OK = _prod_od_ok
        End Get
        Set(ByVal value)
            _prod_od_ok = value
        End Set
    End Property

    Public Property cod_prod_oe()
        Get
            cod_prod_oe = _cod_prod_oe
        End Get
        Set(ByVal value)
            _cod_prod_oe = value
        End Set
    End Property
    Public Property cod_prod_oe_novo()
        Get
            cod_prod_oe_novo = _cod_prod_oe_novo
        End Get
        Set(ByVal value)
            _cod_prod_oe_novo = value
        End Set
    End Property
    Public Property prod_oe_OK()
        Get
            prod_oe_OK = _prod_oe_ok
        End Get
        Set(ByVal value)
            _prod_oe_ok = value
        End Set
    End Property

    Public Property concluido()
        Get
            concluido = _concluido
        End Get
        Set(ByVal value)
            _concluido = value
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
    Public Property id_usuario()
        Get
            id_usuario = _id_usuario
        End Get
        Set(ByVal Value)
            _id_usuario = Value
        End Set
    End Property
    Public Property cod_tipo_troca() As tipo_troca
        Get
            cod_tipo_troca = _cod_tipo_troca
        End Get
        Set(ByVal Value As tipo_troca)
            _cod_tipo_troca = Value
        End Set
    End Property
    Public Property obs() As String
        Get
            obs = _obs
        End Get
        Set(ByVal value As String)
            _obs = value
        End Set
    End Property
#End Region
#Region "Procedimentos"
    Public Sub New()
        Dim sql As String
        sql = "select * from troca_produto where cod_troca_prod = 0 "
        Source(sql)
    End Sub
    Public Sub New(ByVal x_cod_troca As Integer)
        filtrar(x_cod_troca, confFilial)
    End Sub
    Public Sub filtrar(ByVal x_cod_troca_prod As Integer, ByVal x_id_filial As Integer)
        Dim sql As String
        sql = "SELECT * from troca_produto " & _
              "where cod_troca_prod = " & x_cod_troca_prod & _
              " and id_filial = " & x_id_filial & ""
        Source(sql)
    End Sub
    Public Sub filtrar(ByVal x_cod_OS As Integer, ByVal x_id_filial As Integer, ByVal concluido As String)
        Dim sql As String
        'Filtra devolução informando se foi concuída ou não
        sql = "SELECT * from troca_produto " & _
                "where cod_os = " & x_cod_OS & _
                " and id_filial_os = " & x_id_filial & " and " & _
                " concluido = '" & concluido & "'"
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
            _cod_troca_prod = tb.Rows(p)("cod_troca_prod")
            _id_filial = tb.Rows(p)("id_filial")
            _id_filial_os = tb.Rows(p)("id_filial_os")
            _cod_os = tb.Rows(p)("cod_os")
            _cod_prod_od = tb.Rows(p)("cod_prod_od")
            _cod_prod_od_novo = tb.Rows(p)("cod_prod_od_novo")
            _prod_od_ok = tb.Rows(p)("prod_od_ok")

            _cod_prod_oe = tb.Rows(p)("cod_prod_oe")
            _cod_prod_oe_novo = tb.Rows(p)("cod_prod_oe_novo")
            _prod_oe_ok = tb.Rows(p)("prod_oe_ok")

            _concluido = tb.Rows(p)("concluido")
            _cod_devolucao_os = tb.Rows(p)("cod_devolucao_os")
            _id_usuario = tb.Rows(p)("id_usuario")
            _cod_tipo_troca = tb.Rows(0)("cod_tipo_troca")
            _obs = rdTexto(tb.Rows(0)("obs"))
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

        _cod_os = Nothing
        _id_filial_os = Nothing

        _cod_prod_od = Nothing
        _cod_prod_od_novo = Nothing
        _prod_od_ok = "N"

        _cod_prod_oe = Nothing
        _cod_prod_oe_novo = Nothing
        _prod_oe_ok = "N"

        _concluido = "N"

        _cod_devolucao_os = Nothing
        _id_usuario = UserID
        _cod_tipo_troca = Nothing
        _obs = Nothing
        OrigemSalvar = "Novo" 'Define o tipo de ação ao salvar
    End Function
    Public Function Salvar() As String
        Dim sql As String
        Dim res As String 'Quantidade de registros afetados
        d.conecta()
        If OrigemSalvar = "Novo" Then
            Try
                _cod_troca_prod = retorna_Chave("cod_troca_prod", "troca_produto", " where id_filial = 1")
                sql = "INSERT INTO Troca_produto (cod_troca_Prod" & _
                ",id_filial,cod_os,id_filial_os ,cod_prod_od " & _
                ",cod_prod_od_novo ,prod_od_ok ,cod_prod_oe" & _
                ",cod_prod_oe_novo ,prod_oe_ok ,Concluido" & _
                ",cod_devolucao_OS,cod_tipo_troca,obs,id_usuario) " & _
                "VALUES(" & _
                _cod_troca_prod & _
                "," & _id_filial & _
                "," & _cod_os & _
                "," & _id_filial_os & _
                "," & _cod_prod_od & _
                "," & _cod_prod_od_novo & _
                "," & d.PStr(_prod_od_ok) & _
                "," & _cod_prod_oe & _
                "," & _cod_prod_oe_novo & _
                "," & d.PStr(_prod_oe_ok) & _
                "," & d.PStr(_concluido) & _
                "," & _cod_devolucao_os & _
                "," & _cod_tipo_troca & _
                "," & d.PStr(_obs) & _
                "," & _id_usuario & ")"
                res = d.Comando(sql, True)

            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tb.NewRow
            r("cod_troca_prod") = _cod_troca_prod
            r("id_filial") = _id_filial

            r("id_filial_os") = _id_filial_os
            r("cod_os") = _cod_os

            r("cod_prod_od") = _cod_prod_od
            r("cod_prod_od_novo") = _cod_prod_od_novo
            r("prod_od_ok") = _prod_od_ok

            r("cod_prod_oe") = _cod_prod_oe
            r("cod_prod_oe_novo") = _cod_prod_oe_novo
            r("prod_oe_ok") = _prod_oe_ok

            r("id_usuario") = _id_usuario
            r("cod_devolucao_os") = _cod_devolucao_os
            r("cod_tipo_troca") = _cod_tipo_troca
            r("obs") = _obs
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
                sql = "UPDATE Troca_produto SET " & _
                "cod_os =" & _cod_os & _
                ",id_filial_os = " & _id_filial_os & _
                ",cod_prod_od = " & _cod_prod_od & _
                ",cod_prod_od_novo = " & _cod_prod_od_novo & _
                ",prod_od_ok = " & d.PStr(_prod_od_ok) & _
                ",cod_prod_oe = " & _cod_prod_oe & _
                ",cod_prod_oe_novo = " & _cod_prod_oe_novo & _
                ",prod_oe_ok = " & d.PStr(_prod_oe_ok) & _
                ",Concluido = " & d.PStr(_concluido) & _
                ",cod_devolucao_OS = " & _cod_devolucao_os & _
                ",id_usuario = " & _id_usuario & _
                ",cod_tipo_troca = " & _cod_tipo_troca & _
                ",obs = " & d.PStr(_obs) & _
                " WHERE cod_troca_prod = " & _cod_troca_prod & _
                " and id_filial = " & _id_filial & ""

                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try

            Dim r As DataRow
            r = tb.Rows(posicao)
            r("cod_troca_prod") = _cod_troca_prod
            r("id_filial") = _id_filial

            r("id_filial_os") = _id_filial_os
            r("cod_os") = _cod_os

            r("cod_prod_od") = _cod_prod_od
            r("cod_prod_od_novo") = _cod_prod_od_novo
            r("prod_od_ok") = _prod_od_ok

            r("cod_prod_oe") = _cod_prod_oe
            r("cod_prod_oe_novo") = _cod_prod_oe_novo
            r("prod_oe_ok") = _prod_oe_ok

            r("id_usuario") = _id_usuario
            r("cod_devolucao_os") = _cod_devolucao_os
            r("cod_tipo_troca") = _cod_tipo_troca
            r("obs") = _obs
            OrigemSalvar = ""
            Return "OK:" & res & " registro(s) atualizado(s) com sucesso!"
        End If
    End Function
    Public Function deletar(ByVal x_cod_troca As Integer, ByVal x_id_filial As Integer) As String
        Dim res As String
        Dim tsql As String
        d.conecta()
        tsql = "Delete  from troca_produto  where cod_troca_prod = " & x_cod_troca & _
        " and id_filial = " & x_id_filial & ""
        Try
            res = d.Comando(tsql, True)
        Catch ex As Exception
        End Try
        Me.refreshData()
        Me.primeiro()
        Return res & " Registros foram apagados!"
    End Function
    Public Function conclui_troca() As String
        Dim sql As String
        sql = "update troca_produto set concluido = 'S' " & _
        " where cod_troca_prod = " & _cod_troca_prod & " and " & _
        "id_filial = " & _id_filial & ""
        Return d.Comando(sql, True)
    End Function
#End Region
End Class
