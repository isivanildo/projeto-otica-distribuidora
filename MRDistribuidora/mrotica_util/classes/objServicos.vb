Public Class objServicos
    Inherits produtoClass
#Region "Atributos"
    Private _cod_produto As Integer
    Private _cod_servico As Object
    Private _cod_tipo_Servico As Object
    Private _prazo As Integer
    Public Shadows posicao As Integer = 0
    Public Shadows max As Integer
    Public Shadows chaveCriterio As Object
    Public tb As New DataTable
    Public Shadows OrigemSalvar As String = ""
    Private lastPos As Integer = 0
    Private sql As String
    Dim prod As New produtoClass
    Dim d As New dados
    Dim énovo As Boolean
#End Region
#Region "GET SET"
    Public Property cod_servico()
        Get
            cod_servico = _cod_servico
        End Get
        Set(ByVal Value)
            _cod_servico = Value
        End Set
    End Property
    Public Property cod_tipo_servico()
        Get
            cod_tipo_servico = _cod_tipo_Servico
        End Get
        Set(ByVal Value)
            _cod_tipo_Servico = Value
        End Set
    End Property
    Public Property Prazo()
        Get
            Prazo = _prazo
        End Get
        Set(ByVal Value)
            _prazo = Value
        End Set
    End Property
#End Region
#Region "Procedimentos"
    Public Sub New()
        Dim sql As String
        sql = "Select * from servicos"
        Source_servico(sql)
    End Sub
    Public Sub Source_servico(ByVal iSql As String)
        sql = iSql
        Me.refreshData()
    End Sub
    Public Sub servico(ByVal cod_produto As Integer)
        Dim sql As String
        sql = "Select * from servicos where cod_produto = " & cod_produto & ""
        Source(sql)
        primeiro()
    End Sub
    Public Overloads Sub refreshData()
        d.carrega_Tabela(sql, tb)
        max = tb.Rows.Count
    End Sub
    Public Overloads Sub Registro(ByVal pos As Integer) 'Move o Registro para a posição indicada
        Dim p As Integer = pos
        If p <= 0 Then p = 0
        If p > max Then p = max
        posicao = p
        If max > 0 Then
            _cod_produto = tb.Rows(p)("cod_produto")
            _cod_servico = tb.Rows(p)("cod_servico")
            _cod_tipo_Servico = tb.Rows(p)("cod_tipo_servico")
            _prazo = tb.Rows(p)("prazo")
            filtra(_cod_produto)
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
    Public Sub editar_servico()
        énovo = False
        editar()
    End Sub
#End Region
#Region "Funções"
    Public Function novo_servico()
        lastPos = posicao 'guarda a posição do último Registro
        'Zera Variáveis
        novo()
        _cod_servico = Nothing
        _cod_tipo_Servico = Nothing
        _prazo = Nothing
        énovo = True  'Define o tipo de ação ao salvar
    End Function
    Public Function Salvar_servico() As String
        Dim cmd As New SqlClient.SqlCommand
        Dim sql As String
        Dim res As String
        d.conecta()
        cmd.Connection = d.con
        If énovo = True Then
            Try
                Salvar(tiposalvar.Normal)
                _cod_servico = retorna_Chave("cod_servico", "servicos", "")
                sql = "Insert into servicos(cod_servico,cod_produto,cod_tipo_servico,prazo)" & _
                "Values(" & _cod_servico & "," & _
                fldCod_produto & "," & d.cdin(_cod_tipo_Servico) & "," & d.cdin(_prazo) & ")"
                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tb.NewRow
            r("cod_produto") = fldCod_produto
            r("cod_tipo_servico") = _cod_tipo_Servico
            r("prazo") = _prazo
            tb.Rows.Add(r)
            max = max + 1
            If max = 1 Then
                posicao = 0
            Else
                posicao = max - 1
            End If
            énovo = False
            Return res & " registro(s) adicionado(s) com sucesso!"
        End If
        If énovo = False Then
            Try
                Salvar(tiposalvar.Normal)
                sql = "Update servicos set " & _
                " cod_tipo_servico = " & _cod_tipo_Servico & _
                ",prazo = " & _prazo & _
                " where cod_produto = " & fldCod_produto & ""
                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tb.Rows(posicao)
            r("cod_tipo_servico") = _cod_tipo_Servico
            r("prazo") = _prazo
            énovo = False
            Return res & " registro(s) atualizado(s) com sucesso!"
        End If
    End Function
    Public Function deletar_servico(ByVal id_prod As Integer) As String
        Dim sql As String
        Dim res As String
        d.conecta()
        sql = "Delete from servicos where cod_produto = " & id_prod & ""
        res = d.Comando(sql, True)
        If res.StartsWith("ER") Then
            Return res
            Exit Function
        End If
        If res.StartsWith("OK") Then
            res = res & vbCrLf & deletar(id_prod, tiposalvar.Normal)
        End If
        Me.refreshData()
        Me.primeiro()
        Return res
    End Function
#End Region
End Class
