Public Class objCheque
#Region "Atributos"
    Inherits objPagamento
    Private _cod_lancamento As Integer
    Private _id_filial As Integer
    Private _cod_banco As Integer
    Private _agencia As Object
    Private _conta As Object
    Private _cheque As Int64
    Private _acrescimo As Double

    Public Shadows posicao As Integer = 0
    Public Shadows max As Integer
    Public tabela As New DataTable
    Public Shadows OrigemSalvar As String = ""
    Private lastPos As Integer = 0
    Private sql As String
    Dim d As New dados
#End Region
#Region "GET SET"
    Public Property cod_banco()
        Get
            cod_banco = _cod_banco
        End Get
        Set(ByVal Value)
            _cod_banco = Value
        End Set
    End Property
    Public Property agencia()
        Get
            agencia = _agencia
        End Get
        Set(ByVal Value)
            _agencia = Value
        End Set
    End Property
    Public Property conta()
        Get
            conta = _conta
        End Get
        Set(ByVal Value)
            _conta = Value
        End Set
    End Property
    Public Property cheque()
        Get
            cheque = _cheque
        End Get
        Set(ByVal Value)
            _cheque = Value
        End Set
    End Property
    Public Property acrescimo()
        Get
            acrescimo = _acrescimo
        End Get
        Set(ByVal Value)
            _acrescimo = Value
        End Set
    End Property
#End Region
#Region "Procedimentos"
    Public Sub New(ByVal tipo As tipo_pagamento)
        MyBase.New(tipo)
        sql = "Select * from cheques where cheque = 0"
        Source(sql)
    End Sub
    Public Overloads Sub Source(ByVal iSql As String)
        sql = iSql
        Me.refreshData()
    End Sub
    Public Overloads Sub refreshData()
        d.carrega_Tabela(sql, tabela)
        max = tabela.Rows.Count
    End Sub
    Public Overloads Sub Registro(ByVal pos As Integer) 'Move o Registro para a posição indicada
        Dim p As Integer = pos
        If p <= 0 Then p = 0
        If p > max Then p = max
        posicao = p
        If max > 0 Then
            _cod_lancamento = tabela.Rows(p)("cod_lancamento")
            _id_filial = tabela.Rows(p)("id_filial")
            _cod_banco = tabela.Rows(p)("cod_banco")
            _agencia = tabela.Rows(p)("agencia")
            _conta = tabela.Rows(p)("conta")
            _cheque = tabela.Rows(p)("cheque")
            _acrescimo = tabela.Rows(p)("acrescimo")
        End If
    End Sub
    Public Overloads Sub proximo()
        If Me.posicao = Me.max - 1 Then Exit Sub
        Me.Registro(Me.posicao + 1)
    End Sub
    Public Overloads Sub anterior()
        Me.Registro(Me.posicao - 1)
    End Sub
    Public Overloads Sub ultimo()
        Me.Registro(Me.max - 1)
    End Sub
    Public Overloads Sub primeiro()
        Me.Registro(0)
    End Sub
    Public Overloads Sub ultima_posicao()
        Me.Registro(lastPos)
    End Sub
    Public Sub editar_cheque()
        OrigemSalvar = "Editar"
    End Sub
#End Region
#Region "Funções"
    Public Sub novo_cheque()
        lastPos = posicao 'guarda a posição do último Registro
        'Zera Variáveis
        MyBase.novo_lancamento()
        _cod_lancamento = Nothing
        _id_filial = Nothing
        _cod_banco = Nothing
        _agencia = Nothing
        _conta = Nothing
        _cheque = Nothing
        _acrescimo = Nothing
        OrigemSalvar = "Novo" 'Define o tipo de ação ao salvar
    End Sub
    Public Function Salvar_cheque(ByVal tipo As tiposalvar) As String
        Dim sql As String
        Dim r1, res As String
        d.conecta()
        r1 = MyBase.salva_pag(tiposalvar.Transaction)
        If OrigemSalvar = "Novo" Then
            Try
                sql = "INSERT INTO cheques " & _
                "(cod_lancamento " & _
                ",id_filial " & _
                ",cod_banco " & _
                ",agencia " & _
                ",conta " & _
                ",cheque " & _
                ",acrescimo)" & _
                " VALUES" & _
                "(" & cod_lancamento & _
                "," & id_filial & _
                "," & _cod_banco & _
                "," & _agencia & _
                "," & _conta & _
                "," & _cheque & _
                "," & d.cdin(_acrescimo) & ")"
                If tipo = tiposalvar.Normal Then
                    res = d.Comando(sql, True)
                Else
                    trans.insere_instrucao(sql)
                    Return sql
                End If
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tabela.NewRow
            r("cod_lancamento") = _cod_lancamento
            r("id_filial") = _id_filial
            r("cod_banco") = _cod_banco
            r("agencia") = _agencia
            r("conta") = _conta
            r("cheque") = _cheque
            r("acrescimo") = wrNum(_acrescimo)
            tabela.Rows.Add(r)
            max = max + 1
            If max = 1 Then
                posicao = 0
            Else
                posicao = max - 1
            End If
            OrigemSalvar = ""
            Return "OK:" & res & " registro(s) adicionado(s) com sucesso!"
        Else
            Try
                sql = "UPDATE cheques " & _
                "SET cod_lancamento = " & _cod_lancamento & _
                ",id_filial = " & _id_filial & _
                ",cod_banco = " & _cod_banco & _
                ",agencia = " & _agencia & _
                ",conta = " & _conta & _
                ",cheque = " & _cheque & _
                ",acrescimo = " & _acrescimo & _
                " WHERE cod_lancamento = " & _cod_lancamento & _
                " and id_filial = " & _id_filial & ""
                If tipo = tiposalvar.Normal Then
                    res = d.Comando(sql, True)
                Else
                    trans.insere_instrucao(sql)
                    Return sql
                End If
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tabela.Rows(posicao)
            r("cod_lancamento") = _cod_lancamento
            r("id_filial") = _id_filial
            r("cod_banco") = _cod_banco
            r("agencia") = _agencia
            r("conta") = _conta
            r("cheque") = _cheque
            r("acrescimo") = wrNum(_acrescimo)
            OrigemSalvar = ""
            Return "OK:" & res & " registro(s) atualizado(s) com sucesso!"
        End If
    End Function
    Public Function deletar_cheque(ByVal x_cod_lancamento As Integer, ByVal x_id_filial As Integer)
        Dim cmd As New SqlClient.SqlCommand
        Dim res As Integer
        d.conecta()
        cmd.Connection = d.con
        cmd.CommandText = "Delete from lancamentos where cod_lancamento = " & x_cod_lancamento & _
        "and id_filial = " & x_id_filial & ""
        Try
            res = cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Me.refreshData()
        Me.primeiro()
        Return res & " Registros foram apagados!"
    End Function
    Public Function listar_cheques_fatura(ByVal x_cod_fatura As Integer, ByVal x_id_filial As Integer) As DataTable
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT cheques.cheque, cheques.acrescimo, lancamentos.Valor, " & _
        "lancamentos.cod_lancamento, " & _
        "lancamentos.id_filial, lancamentos.Valor + cheques.acrescimo AS total, " & _
        "Pagamentos_fatura.cod_fatura, Pagamentos_fatura.id_filial AS filial_fatura " & _
        "FROM lancamentos INNER JOIN cheques ON lancamentos.cod_lancamento = " & _
        "cheques.cod_lancamento AND lancamentos.id_filial = cheques.id_filial INNER JOIN " & _
        "Pagamentos_fatura ON lancamentos.cod_lancamento = Pagamentos_fatura.cod_lancamento " & _
        "AND lancamentos.id_filial = Pagamentos_fatura.id_filial " & _
        "where Pagamentos_fatura.cod_fatura = " & x_cod_fatura & _
        " and Pagamentos_fatura.id_filial = " & x_id_filial & _
        " and lancamentos.cod_status_lancamento = 1"
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function listar_cheques_credito(ByVal x_cod_credito As Integer, ByVal x_id_filial As Integer) As DataTable
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT cheques.cheque, cheques.acrescimo, lancamentos.Valor, " & _
        "lancamentos.cod_lancamento, lancamentos.id_filial, " & _
        "lancamentos.Valor + cheques.acrescimo AS total " & _
        " FROM lancamentos INNER JOIN cheques ON lancamentos.cod_lancamento " & _
        "= cheques.cod_lancamento AND lancamentos.id_filial = cheques.id_filial " & _
        "INNER JOIN pagamentos_credito ON lancamentos.cod_lancamento = " & _
        "pagamentos_credito.cod_lancamento AND lancamentos.id_filial = " & _
        "pagamentos_credito.id_filial WHERE     " & _
        "(pagamentos_credito.cod_credito = " & x_cod_credito & ") AND " & _
        "(pagamentos_credito.id_filial = " & x_id_filial & ")"
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
#End Region
End Class
