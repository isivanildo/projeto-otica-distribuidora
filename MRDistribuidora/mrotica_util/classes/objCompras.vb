Public Class objcompras
#Region "Atributos"
    Private _cod_movimento As Integer
    Private _cod_compra As Integer
    Private _id_filial As Integer
    Private _cod_fornecedor As Integer
    Private _cod_natureza As Integer
    Private _data As Object
    Private _doc As String
    Private _id_usuario As Integer = UserID
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
    Public Property cod_movimento()
        Get
            cod_movimento = _cod_movimento
        End Get
        Set(ByVal Value)
            _cod_movimento = Value
        End Set
    End Property
    Public Property cod_compra()
        Get
            cod_compra = _cod_compra
        End Get
        Set(ByVal Value)
            _cod_compra = Value
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
    Public Property cod_fornecedor()
        Get
            cod_fornecedor = _cod_fornecedor
        End Get
        Set(ByVal Value)
            _cod_fornecedor = Value
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
#End Region
#Region "Procedimentos"
    Public Sub New()
        Dim sql As String
        sql = "SELECT compras.cod_movimento, compras.cod_compra, compras.id_filial, compras.cod_fornecedor, " & _
        "movimentomaster.cod_natureza, movimentomaster.data, " & _
        "movimentomaster.doc, movimentomaster.id_usuario FROM compras INNER JOIN " & _
        "movimentomaster ON compras.cod_movimento = movimentomaster.cod_movimento " & _
        "AND compras.id_filial = movimentomaster.id_filial " & _
        "where compras.cod_movimento = 0"
        Source(sql)
    End Sub
    Public Sub New(ByVal cod_mov As Integer)
        Dim sql As String
        sql = "SELECT compras.cod_movimento, compras.cod_compra, compras.id_filial, compras.cod_fornecedor, " &
        "movimentomaster.cod_natureza, movimentomaster.data, " &
        "movimentomaster.doc, movimentomaster.id_usuario FROM compras INNER JOIN " &
        "movimentomaster ON compras.cod_movimento = movimentomaster.cod_movimento " &
        "AND compras.id_filial = movimentomaster.id_filial " &
        "where compras.cod_movimento = " & cod_mov & " and compras.id_filial = " & confFilial & ""
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
            _cod_compra = tb.Rows(p)("cod_compra")
            _id_filial = tb.Rows(p)("id_filial")
            _cod_fornecedor = tb.Rows(p)("cod_fornecedor")
            _cod_natureza = tb.Rows(p)("cod_natureza")
            _data = tb.Rows(p)("data")
            _doc = tb.Rows(p)("doc").ToString.Trim
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
        _cod_movimento = retorna_Chave("cod_movimento", "movimentomaster", " where id_filial = " & confFilial)
        _cod_compra = retorna_Chave("cod_compra", "compras", "where id_filial = " & confFilial)
        _id_filial = confFilial
        _cod_fornecedor = 0
        _cod_natureza = 1
        _data = Nothing
        _doc = Nothing
        _id_usuario = UserID
        OrigemSalvar = "Novo" 'Define o tipo de ação ao salvar
    End Function
    Public Function Salvar() As String
        Dim sql As String
        Dim res As String 'Quantidade de registros afetados
        d.conecta()
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
                sql = "INSERT INTO compras (cod_movimento,cod_compra,id_filial,cod_fornecedor) " & _
                "VALUES (" & _cod_movimento & "," & _cod_compra & "," & _id_filial & _
                "," & _cod_fornecedor & ")"
                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tb.NewRow
            r("cod_movimento") = _cod_movimento
            r("cod_compra") = _cod_compra
            r("id_filial") = _id_filial
            r("cod_fornecedor") = _cod_fornecedor
            r("cod_natureza") = _cod_natureza = 0
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
                ",data = " & d.Pdt(_data) & _
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
                sql = "UPDATE compras SET cod_movimento = " & _cod_movimento & _
                ",cod_compra = " & _cod_compra & ",id_filial  = " & _id_filial & _
                ",cod_fornecedor  = " & _cod_fornecedor & _
                " WHERE cod_movimento = " & chaveCriterio1 & _
                " and id_filial = " & chaveCriterio2 & ""
            Catch ex As Exception
                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tb.Rows(posicao)
            r("cod_movimento") = _cod_movimento
            r("cod_compra") = _cod_compra
            r("id_filial") = _id_filial
            r("cod_fornecedor") = _cod_fornecedor
            r("cod_natureza") = _cod_natureza = 0
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
    Public Function listar_detalhes_compra_dif() As DataTable
        Dim sql As String
        Dim tb_r As New DataTable
        sql = "SELECT movimento.item, produtos.produto, produtos.cod_barra," & _
        "movimento.desconto, movimento.pUnit, movimento.quant," & _
        "((movimento.punit-(movimento.punit*(movimento.desconto/100)))" & _
        "*movimento.quant) as Preco,isnull((diferenca_desconto.diferenca*movimento.quant)" & _
        ",0) as diferenca, isnull((diferenca_desconto.preco_real*movimento.quant)" & _
        ",0) as Preco_real FROM movimento INNER JOIN produtos ON movimento.cod_produto" & _
        "= produtos.cod_produto LEFT OUTER JOIN diferenca_desconto ON " & _
        "movimento.cod_lancamento = diferenca_desconto.cod_lancamento " & _
        "AND movimento.id_filial = diferenca_desconto.id_filial " & _
        " where movimento.cod_movimento = " & _cod_movimento & " and " & _
        "movimento.id_filial = " & _id_filial & ""
        d.carrega_Tabela(sql, tb_r)
        Return tb_r
    End Function
    Public Function conclui_movimento() As String
        Dim sql As String
        sql = "update movimentomaster set concluido = 'S' " & _
        " where cod_movimento = " & _cod_movimento & " and " & _
        "id_filial = " & _id_filial & ""
        Return d.Comando(sql, True)
    End Function
#End Region
End Class
