Public Class objTrocaDioptria
#Region "Atributos"
    Private _cod_movimento As Integer
    Private _id_filial As Integer
    Private _cod_natureza As Integer
    Private _data As Object
    Private _doc As String
    Private _id_usuario As Integer
    Private _historico As String
    Private _prod_entra As Long
    Private _prod_sai As Long
    Public posicao As Integer = 0
    Private sql As String
    Dim d As New dados
    Dim conf As New config
    Dim mov As New objMovimentoDetalhe
    Dim prod As New produtoClass
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
    Public Property id_filial()
        Get
            id_filial = _id_filial
        End Get
        Set(ByVal Value)
            _id_filial = Value
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
    Public Property historico()
        Get
            historico = _historico
        End Get
        Set(ByVal Value)
            _historico = Value
        End Set
    End Property

    Public Property prod_Entra()
        Get
            prod_Entra = _prod_entra
        End Get
        Set(ByVal Value)
            _prod_entra = Value
        End Set
    End Property
    Public Property prod_sai()
        Get
            prod_sai = _prod_sai
        End Get
        Set(ByVal Value)
            _prod_sai = Value
        End Set
    End Property

#End Region
#Region "Procedimentos"
#End Region
#Region "Funções"
    Public Sub novo()
        _id_filial = conf.Filial
        _cod_natureza = 13
        _data = Now
        _doc = "Ajuste de Produto no Estoque"
        _id_usuario = Nothing
        _historico = Nothing
        _prod_entra = Nothing
        _prod_sai = Nothing
    End Sub
    Public Function Salvar() As String
        Dim cmd As New SqlClient.SqlCommand
        Dim sql As String
        Dim res As Integer 'Quantidade de registros afetados
        d.conecta()
        cmd.Connection = d.con
        Try
            _cod_movimento = retorna_Chave("cod_movimento", "movimentomaster", " where id_filial = " & conf.Filial)
            sql = "INSERT INTO movimentomaster " & _
            "(cod_movimento,cod_natureza,id_filial,data,doc,id_usuario) " & _
            "VALUES ( " & _
            _cod_movimento & _
            "," & _cod_natureza & _
            "," & _id_filial & _
            "," & d.pdtm(_data) & _
            "," & d.PStr(_doc) & _
            "," & _id_usuario & ")"
            cmd.CommandText = sql
            res = cmd.ExecuteNonQuery()
            d.ComandoSQL(sql, True)

            Entra(_prod_entra)
            sai(_prod_sai)

            conclui_movimento()
        Catch ex As Exception
            Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
            Exit Function
        End Try
        Return "OK:" & res & " registro(s) adicionado(s) com sucesso!"
    End Function
    Private Sub Entra(ByVal x_cod_prod As Long)
        Dim q As Integer = 1
        prod.Source("Select * from produtos where cod_produto = " & x_cod_prod & "")
        mov.novo()
        mov.item = mov.ret_ultimo_item(_cod_movimento)
        mov.cod_movimento = _cod_movimento
        mov.cod_produto = x_cod_prod
        mov.quant = q
        mov.desconto = 0
        mov.pUnit = prod.fldPreco_custo
        mov.Pvenda = prod.fldPreco_venda
        mov.descVenda = prod.fldDesconto
        mov.estoqueFis = mov.ret_saldo_fisico(x_cod_prod) + CDbl(q)
        mov.estoqueFin = mov.ret_saldo_fin(x_cod_prod) + ((prod.fldPreco_custo) * q)
        mov.historico = "Entrada do produto " & " " & _historico
        mov.Salvar()
    End Sub
    Private Sub sai(ByVal x_cod_prod As Long)
        Dim q As Integer = -1
        prod.Source("Select * from produtos where cod_produto = " & x_cod_prod & "")
        mov.novo()
        mov.item = mov.ret_ultimo_item(_cod_movimento)
        mov.cod_movimento = _cod_movimento
        mov.cod_produto = x_cod_prod
        mov.quant = q
        mov.desconto = 0
        mov.pUnit = prod.fldPreco_custo
        mov.Pvenda = prod.fldPreco_venda
        mov.descVenda = prod.fldDesconto
        mov.estoqueFis = mov.ret_saldo_fisico(x_cod_prod) + CDbl(q)
        mov.estoqueFin = mov.ret_saldo_fin(x_cod_prod) + ((prod.fldPreco_custo) * q)
        mov.historico = "Saída do produto " & " " & _historico
        mov.Salvar()
    End Sub
    Public Function conclui_movimento() As String
        Dim sql As String
        sql = "update movimentomaster set concluido = 'S' " & _
        " where cod_movimento = " & _cod_movimento & " and " & _
        "id_filial = " & _id_filial & ""
        Return d.Comando(sql, True)
    End Function
#End Region
End Class
