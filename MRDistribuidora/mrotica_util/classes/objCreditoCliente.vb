Public Class objCreditoCliente
#Region "Atributos"
    Private _cod_credito As Integer
    Private _id_filial As Integer
    Private _cod_cliente As Integer
    Private _cod_filial_cliente As Integer
    Private _cod_fornecedor As Integer
    Private _credito_anterior As Object
    Private _credito As Object
    Private _saldo As Object
    Private _historico As Object
    Private _data As Object
    Private _id_usuario As Integer
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
    Public Property cod_credito()
        Get
            cod_credito = _cod_credito
        End Get
        Set(ByVal value)
            _cod_credito = value
        End Set
    End Property
    Public Property id_filial()
        Get
            id_filial = _id_filial
        End Get
        Set(ByVal value)
            _id_filial = value
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
    Public Property cod_filial_cliente()
        Get
            cod_filial_cliente = _cod_filial_cliente
        End Get
        Set(ByVal value)
            _cod_filial_cliente = value
        End Set
    End Property
    Public Property credito_anterior()
        Get
            credito_anterior = _credito_anterior
        End Get
        Set(ByVal value)
            _credito_anterior = value
        End Set
    End Property
    Public Property credito()
        Get
            credito = _credito
        End Get
        Set(ByVal value)
            _credito = value
        End Set
    End Property
    Public Property saldo()
        Get
            saldo = _saldo
        End Get
        Set(ByVal value)
            _saldo = value
        End Set
    End Property
    Public Property historico()
        Get
            historico = _historico
        End Get
        Set(ByVal value)
            _historico = value
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
        sql = "Select * from credito_cliente where cod_credito = 0"
        Source(sql)
    End Sub
    Public Sub New(ByVal xCod_credito As Integer, ByVal xid_filial As Integer)
        Dim sql As String
        sql = "Select * from credito_cliente where cod_credito = " & xCod_credito & _
        " and id_filial = " & xid_filial & ""
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
            _cod_credito = tb.Rows(p)("cod_credito")
            _id_filial = tb.Rows(p)("id_filial")
            _cod_cliente = tb.Rows(p)("cod_cliente")
            _cod_filial_cliente = tb.Rows(p)("cod_filial_cliente")
            _credito_anterior = tb.Rows(p)("credito_anterior")
            _credito = tb.Rows(p)("credito")
            _saldo = tb.Rows(p)("saldo")
            _historico = rdTexto(tb.Rows(p)("historico"))
            _data = rdData(tb.Rows(p)("data"))
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
        _cod_credito = retorna_Chave("cod_credito", "credito_cliente", " WHere id_filial = " & conf.Filial & "")
        _id_filial = conf.Filial
        _cod_cliente = Nothing
        _cod_filial_cliente = Nothing
        _credito = Nothing
        _credito_anterior = Nothing
        _saldo = Nothing
        _data = Nothing
        _historico = Nothing
        _id_usuario = Nothing
        OrigemSalvar = "Novo" 'Define o tipo de ação ao salvar
    End Function

    Public Function Salvar() As String
        Dim sql As String
        Dim res As String 'Quantidade de registros afetados
        d.conecta()
        If OrigemSalvar = "Novo" Then
            Try
                _credito_anterior = Saldo_anterior()
                _saldo = _credito_anterior + _credito
                sql = "INSERT INTO credito_cliente " & _
                "(cod_credito,id_filial,cod_cliente,cod_filial_cliente," & _
                "credito_anterior,credito,saldo,historico,data,id_usuario) " & _
                "VALUES ( " & _
                _cod_credito & _
                "," & _id_filial & _
                "," & _cod_cliente & _
                "," & _cod_filial_cliente & _
                "," & d.cdin(Saldo_anterior()) & _
                "," & d.cdin(_credito) & _
                "," & d.cdin(Saldo_anterior() + _credito) & _
                "," & d.PStr(_historico) & _
                "," & d.pdtm(_data) & _
                "," & _id_usuario & ")"
                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            
            Dim r As DataRow
            r = tb.NewRow
            r("cod_Credito") = _cod_credito
            r("id_filial") = _id_filial
            r("cod_cliente") = _cod_cliente
            r("cod_filial_cliente") = _cod_filial_cliente
            r("credito_anterior") = wrNum(_credito_anterior)
            r("credito") = wrNum(_credito)
            r("saldo") = wrNum(_saldo)
            r("data") = wrData(_data)
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
                sql = "UPDATE credito_cliente SET cod_cliente = " & _cod_cliente & _
                ",cod_filial_cliente = " & _cod_filial_cliente & _
                ",Credito_anterior = " & d.cdin(_credito_anterior) & _
                ",credito = " & d.cdin(_credito) & _
                ",saldo = " & d.cdin(_saldo) & _
                ",historico = " & d.PStr(_historico) & _
                ",data = " & d.pdtm(_data) & _
                ",id_usuario = " & _id_usuario & _
                "WHERE cod_credito = " & Me._cod_credito & _
                " and id_filial = " & Me._id_filial & ""
                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            
            Dim r As DataRow
            r = tb.Rows(posicao)
            r("cod_Credito") = _cod_credito
            r("id_filial") = _id_filial
            r("cod_cliente") = _cod_cliente
            r("cod_filial_cliente") = _cod_filial_cliente
            r("credito_anterior") = wrNum(_credito_anterior)
            r("credito") = wrNum(_credito)
            r("saldo") = wrNum(_saldo)
            r("data") = wrData(_data)
            r("id_usuario") = _id_usuario
            OrigemSalvar = ""
            Return "OK:" & res & " registro(s) atualizado(s) com sucesso!"
        End If
    End Function

    Public Function salvar_trans() As String
        Dim sql As String
        Dim res As String 'Quantidade de registros afetados
        d.conecta()
        If OrigemSalvar = "Novo" Then
            Try
                _credito_anterior = Saldo_anterior()
                _saldo = _credito_anterior + _credito
                sql = "INSERT INTO credito_cliente " & _
                "(cod_credito,id_filial,cod_cliente,cod_filial_cliente," & _
                "credito_anterior,credito,saldo,historico,data,id_usuario) " & _
                "VALUES ( " & _
                _cod_credito & _
                "," & _id_filial & _
                "," & _cod_cliente & _
                "," & _cod_filial_cliente & _
                "," & d.cdin(Saldo_anterior()) & _
                "," & d.cdin(_credito) & _
                "," & d.cdin(Saldo_anterior() + _credito) & _
                "," & d.PStr(_historico) & _
                "," & d.pdtm(_data) & _
                "," & _id_usuario & ")"
                res = sql
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            OrigemSalvar = ""
            Return res
        End If
        If Me.OrigemSalvar = "Editar" Then
            Try
                sql = "UPDATE credito_cliente SET cod_cliente = " & _cod_cliente & _
                ",cod_filial_cliente = " & _cod_filial_cliente & _
                ",Credito_anterior = " & d.cdin(_credito_anterior) & _
                ",credito = " & d.cdin(_credito) & _
                ",saldo = " & d.cdin(_saldo) & _
                ",historico = " & d.PStr(_historico) & _
                ",data = " & d.pdtm(_data) & _
                ",id_usuario = " & _id_usuario & _
                "WHERE cod_credito = " & Me._cod_credito & _
                " and id_filial = " & Me._id_filial & ""
                res = sql
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            OrigemSalvar = ""
            Return res
        End If
    End Function
    Public Function Saldo_anterior() As Double
        Dim tt As New DataTable
        Dim sql As String
        sql = "SELECT SUM(credito) AS saldo " & _
        "FROM credito_cliente WHERE " & _
        "(cod_cliente = " & Me._cod_cliente & ")" & _
        " AND (cod_filial_cliente = " & Me._cod_filial_cliente & ")"
        Try
            d.carrega_Tabela(sql, tt)
            Return tt.Rows(0)("saldo")
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Public Function Saldo_anterior(ByVal x_filial As Integer, ByVal x_cliente As Integer) As Double
        Dim tt As New DataTable
        Dim sql As String
        sql = "SELECT SUM(credito) AS saldo " & _
        "FROM credito_cliente WHERE " & _
        "(cod_cliente = " & x_cliente & ")" & _
        " AND (cod_filial_cliente = " & x_filial & ")"
        Try
            d.carrega_Tabela(sql, tt)
            Return tt.Rows(0)("saldo")
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Public Function lista_creditos(ByVal x_filial As Integer, ByVal x_cliente As Integer) As DataTable
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT historico, data, Credito_anterior, credito, saldo " & _
        "FROM credito_cliente where (cod_cliente = " & x_cliente & ")" & _
        " AND (cod_filial_cliente = " & x_filial & ") order by data"
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function credito_pacote(ByVal x_cod_pacote As Integer) As String
        sql = "INSERT INTO credito_pacote (cod_pacote ,cod_filial_cliente " & _
           ",cod_cliente, cod_credito,id_filial) VALUES(" & _
           x_cod_pacote & _
           "," & _cod_filial_cliente & _
           "," & _cod_cliente & _
           "," & _cod_credito & _
           "," & _id_filial & ")"
        Return d.Comando(sql, True)
    End Function
#Region "Acrescimos"
    Public Function listaAcrescimos() As DataTable
        Dim sql As String
        Dim tt As New DataTable
        sql = "Select * from acrescimos_fatura where cod_fatura_cred = " & Me._cod_credito & " and " & _
        " id_filial = " & Me._id_filial & " and tipo = 'C'"
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function acrescimo_credito() As Double
        Dim sql As String
        Dim tt As New DataTable
        sql = "Select sum(valor) as total from acrescimos_fatura where cod_fatura_cred = " & Me._cod_credito & " and " & _
        " id_filial = " & Me._id_filial & " and tipo = 'C'"
        d.carrega_Tabela(sql, tt)
        If tt.Rows.Count = 0 Then
            Return 0
        Else
            Return rdNum(tt.Rows(0)("total"))
        End If
    End Function
    Public Function insere_acrescimo(ByVal x_valor As Double, ByVal x_cod_usuario As Integer, ByVal xDesc As String) As String
        Dim sql As String
        sql = "INSERT INTO acrescimos_fatura(cod_acrescimo_fatura,cod_fatura_cred,id_filial " & _
           ",valor,cod_usuario,descricao,data,tipo) VALUES( " & _
           retorna_Chave("cod_acrescimo_fatura", "acrescimos_fatura", "") & _
           "," & Me._cod_credito & _
           "," & Me._id_filial & _
           "," & d.cdin(x_valor) & _
           "," & x_cod_usuario & _
           "," & d.PStr(xDesc) & _
           "," & d.pdtm(Now) & _
           ",'C')"
        Return d.Comando(sql, True)
    End Function
    Public Function deleta_acrescimo(ByVal x_cod_acrescimo_fatura As Integer) As String
        Dim sql As String
        sql = "Delete from acrescimos_fatura where cod_acrescimo_fatura = " & x_cod_acrescimo_fatura & _
        " and cod_fatura_cred = " & Me._cod_credito & " and id_filial = " & Me._id_filial & ""
        Return d.Comando(sql, True)
    End Function
#End Region
    Public Function credito_cancelamento(ByVal x_id_filial As Integer, _
                                         ByVal x_valor As Double, ByVal x_cod_filial_cliente As _
                                        Integer, ByVal x_cod_cliente As Integer _
                                        , ByVal x_descricao As String) As String
        Dim tsql As String
        Dim res As String
        Dim chave As Integer = retorna_Chave("cod_credito_cancelamento", "credito_cancelamento", " where id_filial = " & x_id_filial & "")
        tsql = "INSERT INTO credito_cancelamento " & _
           "(cod_credito_cancelamento" & _
           ",id_filial" & _
           ",data" & _
           ",cod_filial_cliente" & _
           ",cod_cliente" & _
           ",descricao,valor) VALUES " & _
           "(" & chave & _
           "," & x_id_filial & _
           "," & d.pdtm(Now) & _
           "," & x_cod_filial_cliente & _
           "," & x_cod_cliente & _
           "," & d.PStr(x_descricao) & _
           "," & d.cdin(x_valor) & ")"
        Try
            res = d.Comando(tsql, True)
        Catch ex As Exception
            res = "ER:" & ex.Message
        End Try
        If res.StartsWith("OK") Then

            Return "OK Crédito cancelamento " & x_id_filial & "-" & chave & _
            " aguardando confirmação do financeiro."

        Else
            Return res
        End If
    End Function
    Public Function retorna_credito_cancelamento(ByVal x_filial As Integer, ByVal x_num_cred As Integer) As DataTable
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "Select * from credito_cancelamento where id_filial = " & x_filial & _
        " and cod_credito_cancelamento = " & x_num_cred & ""
        d.carrega_Tabela(tsql, tt)
        Return tt
    End Function
    Public Function confirma_credito_cancelamento(ByVal x_filial As Integer, _
    ByVal x_num_cred As Integer, ByVal confirmado As Boolean, ByVal x_usuario As Integer) As String
        Dim tsql As String
        Dim sn As String
        If confirmado = True Then
            sn = "S"
        Else
            sn = "N"
        End If
        tsql = "update credito_cancelamento set concluido = 'S',  " & _
        " confirmado = " & d.PStr(sn) & _
        ", cod_usuario = " & x_usuario & _
        " where id_filial = " & x_filial & _
        " and cod_credito_cancelamento = " & x_num_cred & ""
        Return d.Comando(tsql, True)
    End Function

#End Region

    Function retornaRegistro(strSQLOS As String) As Object
        Throw New NotImplementedException
    End Function

End Class
