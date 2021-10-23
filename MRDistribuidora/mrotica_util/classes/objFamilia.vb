Public Class objFamilia
#Region "Atributos"
    Private _cod_familia As Integer
    Private _familia As Object
    Private _descricao As Object
    Public posicao As Integer = 0
    Public max As Integer
    Public tb As New DataTable
    Public éNovo As Boolean = False
    Private lastPos As Integer = 0
    Private sql As String
    Dim d As New dados()
#End Region
#Region "GET SET"
    Public Property cod_familia()
        Get
            cod_familia = _cod_familia
        End Get
        Set(ByVal value)
            _cod_familia = value
        End Set
    End Property
    Public Property familia()
        Get
            familia = _familia
        End Get
        Set(ByVal value)
            _familia = value
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
#End Region
#Region "Procedimentos"
    Public Sub New()
        Dim sql As String = ""
        sql = "select * from familia_lentes order by cod_familia"
        Source(sql)
    End Sub
    Public Sub New(ByVal X_dados As dados)
        Dim sql As String = ""
        d = X_dados
        sql = "select * from familia_lentes order by cod_familia"
        Source(sql)
    End Sub
    Public Sub Source(ByVal iSql As String)
        sql = iSql
        Me.refreshData()
    End Sub
    Public Sub refreshData()
        d.carrega_Tabela(sql, tb)
        max = tb.Rows.Count
        If max > 0 Then
            Registro(0)
        End If
    End Sub
    Public Sub Registro(ByVal pos As Integer) 'Move o Registro para a posição indicada
        Dim p As Integer = pos
        If p <= 0 Then p = 0
        If p > max Then p = max
        posicao = p
        If max > 0 Then
            _cod_familia = tb.Rows(p)("cod_familia")
            _familia = rdTexto(tb.Rows(p)("familia"))
            _descricao = rdTexto(tb.Rows(p)("descricao"))
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
        éNovo = False
    End Sub
#End Region
#Region "Funções"
    Public Function novo()
        lastPos = posicao 'guarda a posição do último Registro
        'Zera Variáveis
        _cod_familia = Nothing
        _familia = ""
        _descricao = ""
        éNovo = True
    End Function
    Public Function Salvar() As String
        Dim sql As String = ""
        Dim res As String = ""
        d.conecta()
        If éNovo = True Then
            Try
                _cod_familia = retorna_Chave("cod_familia", "familia_lentes", "")
                sql = "INSERT INTO familia_lentes(cod_familia ,Familia ,descricao) VALUES(" & _
                _cod_familia & "," & d.PStr(_familia) & _
                "," & d.PStr(_descricao) & ")"
                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tb.NewRow
            r("cod_familia") = _cod_familia
            r("familia") = rdTexto(_familia)
            r("descricao") = rdTexto(_descricao)
            tb.Rows.Add(r)
            max = max + 1
            If max = 1 Then
                posicao = 0
            Else
                posicao = max - 1
            End If
            éNovo = False
            Return res
            Exit Function
        End If
        If éNovo = False Then
            Try
                sql = "UPDATE familia_lentes SET Familia = " & d.PStr(_familia) & _
                ",descricao = " & d.PStr(_descricao) & _
                "WHERE cod_familia = " & _cod_familia & ""
                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tb.Rows(posicao)
            r("familia") = rdTexto(_familia)
            r("descricao") = rdTexto(_descricao)
            éNovo = False
            Return "OK:" & res & " registro(s) atualizado(s) com sucesso!"
            Exit Function
        End If
    End Function
    Public Function deletar()
        Dim sql As String = ""
        Dim res As String = ""
        d.conecta()
        sql = "Delete from familia where cod_familia = " & _cod_familia & ""
        Try
            res = d.Comando(sql, True)
        Catch ex As Exception
        End Try
        Me.refreshData()
        Me.primeiro()
        Return res & " Registros foram apagados!"
    End Function
    Public Function Inserir_produto(ByVal cod_tabela As Integer) As String
        Dim tsql As String = ""
        Dim res As String = ""
        tsql = "INSERT INTO familia_lentes_itens (cod_familia " & _
           ",cod_tabela) VALUES(" & _cod_familia & _
           "," & cod_tabela & ")"
        res = d.Comando(tsql, True)
        Return res
    End Function
    Public Function remover_produto(ByVal cod_tabela As Integer) As String
        Dim tsql As String = ""
        Dim res As String = ""
        tsql = "delete from familia_lentes_itens where cod_tabela = " & cod_tabela & _
        " and cod_familia = " & _cod_familia & ""
        res = d.Comando(tsql, True)
        Return res
    End Function
    Public Function lista_produtos() As DataTable
        Dim tsql As String = ""
        Dim tt As New DataTable
        tsql = "SELECT lentes_tabela.nome_comercial, familia_lentes_itens.cod_tabela " & _
        " FROM familia_lentes_itens INNER JOIN lentes_tabela ON familia_lentes_itens.cod_tabela = " & _
        "lentes_tabela.cod_tabela where familia_lentes_itens.cod_familia = " & _cod_familia & ""
        d.carrega_Tabela(tsql, tt)
        Return tt
    End Function
    Public Function Produto_e_familia(ByVal xCod_tabela As Integer, ByVal xCod_familia As Integer) As Boolean
        Dim tSql As String
        Dim tt As New DataTable
        tSql = "Select cod_familia from familia_lentes_itens where " & _
        "cod_familia = " & xCod_familia & " and cod_tabela = " & xCod_tabela & ""
        d.carrega_Tabela(tSql, tt)
        If tt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
#End Region

End Class
