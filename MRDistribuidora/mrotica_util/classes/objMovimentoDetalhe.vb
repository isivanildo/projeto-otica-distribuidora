Public Class objMovimentoDetalhe
#Region "Atributos"
    Private _cod_lancamento As Integer
    Private _id_filial As Integer
    Private _item As Integer
    Private _cod_Movimento As Integer
    Private _cod_produto As Integer
    Private _quant As Double
    Private _desconto As Double
    Private _pUnit As Double
    Private _estoqueFis As Double
    Private _estoqueFin As Double
    Private _status As Integer = 0
    Private _pVenda As Double
    Private _descVenda As Double
    Private _historico As String
    Private _icms As Double
    Private _ipi As Double
    Private _data_lancamento As Object
    Public posicao As Integer = 0
    Public max As Integer
    Public chaveCriterio1, chaveCriterio2, chaveCriterio3 As Object
    Public tb As New DataTable
    Public OrigemSalvar As String = ""
    Private lastPos As Integer = 0
    Private sql As String
    Dim d As New dados
#End Region
#Region "GET SET"
    Public Property cod_lancamento()
        Get
            cod_lancamento = _cod_lancamento
        End Get
        Set(ByVal Value)
            _cod_lancamento = Value
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
    Public Property item()
        Get
            item = _item
        End Get
        Set(ByVal Value)
            _item = Value
        End Set
    End Property
    Public Property cod_movimento()
        Get
            cod_movimento = _cod_Movimento
        End Get
        Set(ByVal Value)
            _cod_Movimento = Value
        End Set
    End Property
    Public Property cod_produto()
        Get
            cod_produto = _cod_produto
        End Get
        Set(ByVal Value)
            _cod_produto = Value
        End Set
    End Property
    Public Property quant()
        Get
            quant = _quant
        End Get
        Set(ByVal Value)
            _quant = Value
        End Set
    End Property
    Public Property desconto()
        Get
            desconto = _desconto
        End Get
        Set(ByVal Value)
            _desconto = Value
        End Set
    End Property
    Public Property pUnit()
        Get
            pUnit = _pUnit
        End Get
        Set(ByVal Value)
            _pUnit = Value
        End Set
    End Property
    Public Property estoqueFis()
        Get
            estoqueFis = _estoqueFis
        End Get
        Set(ByVal Value)
            _estoqueFis = Value
        End Set
    End Property
    Public Property estoqueFin()
        Get
            estoqueFin = _estoqueFin
        End Get
        Set(ByVal Value)
            _estoqueFin = Value
        End Set
    End Property
    Public Property status()
        Get
            status = _status
        End Get
        Set(ByVal Value)
            _status = Value
        End Set
    End Property
    Public Property Pvenda()
        Get
            Pvenda = _pVenda
        End Get
        Set(ByVal Value)
            _pVenda = Value
        End Set
    End Property
    Public Property descVenda()
        Get
            descVenda = _descVenda
        End Get
        Set(ByVal Value)
            _descVenda = Value
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
    Public Property icms()
        Get
            icms = _icms
        End Get
        Set(ByVal Value)
            _icms = Value
        End Set
    End Property
    Public Property ipi()
        Get
            ipi = _ipi
        End Get
        Set(ByVal Value)
            _ipi = Value
        End Set
    End Property
    Public Property data_lancamento()
        Get
            data_lancamento = _data_lancamento
        End Get
        Set(ByVal Value)
            _data_lancamento = Value
        End Set
    End Property
#End Region
#Region "Procedimentos"
    Public Sub New()
        Dim sql As String
        sql = "Select * from movimento where cod_lancamento = 0"
        Source(sql)
    End Sub
    Public Sub abre_movimento(ByVal x_cod_movimento As Integer, ByVal x_id_filial As Integer)
        sql = "Select * from movimento where cod_movimento = " & _
        x_cod_movimento & " and id_filial = " & x_id_filial & ""
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
            _cod_lancamento = tb.Rows(p)("cod_lancamento")
            _id_filial = tb.Rows(p)("id_filial")
            _item = tb.Rows(p)("item")
            _cod_Movimento = tb.Rows(p)("cod_movimento")
            _cod_produto = tb.Rows(p)("cod_produto")
            _quant = tb.Rows(p)("quant")
            _desconto = tb.Rows(p)("desconto")
            _pUnit = tb.Rows(p)("punit")
            _estoqueFis = tb.Rows(p)("estoquefis")
            _estoqueFin = tb.Rows(p)("estoqueFin")
            _status = tb.Rows(p)("status")
            _pVenda = tb.Rows(p)("pvenda")
            _descVenda = tb.Rows(p)("descVenda")
            _historico = tb.Rows(p)("historico")
            _icms = rdNum(tb.Rows(p)("icms"))
            _ipi = rdNum(tb.Rows(p)("ipi"))
            _data_lancamento = rdData(tb.Rows(p)("data_lancamento"))
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
    Dim conf As New config
#Region "Funções"
    Public Function novo()
        lastPos = posicao 'guarda a posição do último Registro
        'Inicializa Variáveis
        _id_filial = conf.Filial
        _item = Nothing
        _cod_Movimento = Nothing
        _cod_produto = Nothing
        _quant = Nothing
        _desconto = Nothing
        _pUnit = Nothing
        _estoqueFis = Nothing
        _estoqueFin = Nothing
        _status = 0
        _pVenda = Nothing
        _descVenda = Nothing
        _icms = 17
        _data_lancamento = d.hora
        OrigemSalvar = "Novo" 'Define o tipo de ação ao salvar
    End Function
    Public Function Salvar() As String
        Dim sql As String
        Dim res As String
        d.conecta()
        _cod_lancamento = retorna_Chave("cod_lancamento", "movimento", " where movimento.id_filial = " & conf.Filial & "")
        If OrigemSalvar = "Novo" Then
            Try
                sql = "INSERT INTO movimento (cod_lancamento ,id_filial ,item ,cod_Movimento " &
                ",cod_produto,quant,desconto ,pUnit ,estoqueFis ,estoqueFin ,status ,pVenda " &
                ",descVenda,historico,icms,ipi,data_lancamento) " &
                "VALUES(" & _cod_lancamento & "," & _id_filial & "," & _item & "," &
                _cod_Movimento & "," & _cod_produto & "," & _quant & "," & cdin(_desconto) &
                "," & d.cdin(_pUnit) & "," & d.cdin(_estoqueFis) & "," & d.cdin(_estoqueFin) &
                "," & _status & "," & d.cdin(_pVenda) & "," & d.cdin(_descVenda) &
                "," & d.PStr(_historico) & "," & d.cdin(_icms) & "," & d.cdin(_ipi) &
                "," & d.pdtm(_data_lancamento) & ")"
                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tb.NewRow
            r("cod_lancamento") = _cod_lancamento
            r("id_filial") = _id_filial
            r("item") = _item
            r("cod_movimento") = _cod_Movimento
            r("cod_produto") = _cod_produto
            r("quant") = _quant
            r("desconto") = _desconto
            r("pUnit") = _pUnit
            r("estoqueFis") = _estoqueFis
            r("estoqueFin") = _estoqueFin
            r("status") = _status
            r("pVenda") = _pVenda
            r("descVenda") = _descVenda
            r("historico") = _historico
            r("icms") = _icms
            r("ipi") = _ipi
            r("data_lancamento") = wrData(_data_lancamento)
            tb.Rows.Add(r)
            max = max + 1
            If max = 1 Then
                posicao = 0
            Else
                posicao = max - 1
            End If
            OrigemSalvar = ""
            Return res & " registro(s) adicionado(s) com sucesso!"
        End If
        If Me.OrigemSalvar = "Editar" Then
            Try
                sql = "UPDATE movimento set " &
                " item = " & _item &
                ",cod_Movimento = " & _cod_Movimento &
                ",cod_produto = " & _cod_produto &
                ",quant = " & d.cdin(_quant) &
                ",desconto = " & d.cdin(_desconto) &
                ",pUnit = " & d.cdin(_pUnit) &
                ",estoqueFis = " & d.cdin(_estoqueFis) &
                ",estoqueFin = " & d.cdin(_estoqueFin) &
                ",status = " & _status &
                ",pVenda = " & d.cdin(_pVenda) &
                ",descVenda = " & d.cdin(_descVenda) &
                ",historico = " & d.PStr(_historico) &
                ",icms = " & d.cdin(_icms) &
                ",ipi = " & d.cdin(_ipi) &
                ",data_lancamaento = " & d.pdtm(_data_lancamento) &
                " WHERE cod_lancamento = " & _cod_lancamento &
                " and id_filial = " & _id_filial & ""
                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tb.Rows(posicao)
            r("cod_lancamento") = _cod_lancamento
            r("id_filial") = _id_filial
            r("item") = _item
            r("cod_movimento") = _cod_Movimento
            r("cod_produto") = _cod_produto
            r("quant") = _quant
            r("desconto") = _desconto
            r("pUnit") = _pUnit
            r("estoqueFis") = _estoqueFis
            r("estoqueFin") = _estoqueFin
            r("status") = _status
            r("pVenda") = _pVenda
            r("descVenda") = _descVenda
            r("historico") = _historico
            r("icms") = _icms
            r("ipi") = _ipi
            r("data_lancamento") = _data_lancamento
            OrigemSalvar = ""
            Return res
        End If
    End Function
    Public Function deletar(ByVal id_lanc As Integer, ByVal id_fil As Integer)
        Dim cmd As New SqlClient.SqlCommand
        Dim res As Integer
        d.conecta()
        cmd.Connection = d.con
        cmd.CommandText = "Delete from movimento where cod_lancamento = " & id_lanc &
        " and id_filial = " & id_fil & ""
        Try
            res = cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Me.refreshData()
        Me.primeiro()
        Return res & " Registros foram apagados!"
    End Function
    Public Function lista_compra(ByVal id_mov As Integer, ByVal id_filial As Integer) As DataTable
        Dim sql As String
        Dim tbResp As New DataTable
        sql = "SELECT movimento.item, produtos.produto, movimento.quant," &
        "movimento.pUnit, movimento.desconto,  (movimento.pUnit - (movimento.Punit * (movimento.desconto/100))) AS pDesc, " &
        "(movimento.quant * (movimento.pUnit - (movimento.Punit * (movimento.desconto/100)))) AS ptotDesc " &
        "FROM movimento INNER JOIN produtos ON movimento.cod_produto = produtos.cod_produto " &
        "INNER JOIN lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente AND " &
        "produtos.id_fabricante = lentes_blocos.id_fabricante " &
        "where movimento.cod_movimento = " & id_mov & " and movimento.id_filial = " & id_filial & ""
        d.carrega_Tabela(sql, tbResp)
        Return tbResp
    End Function
    Public Function ret_ultimo_item(ByVal cod_mov As Integer) As Integer
        Dim tb As New DataTable
        Dim sql As String
        sql = "select max(item) as item from movimento where cod_movimento = " & cod_mov &
        " and id_filial = " & confFilial & ""
        d.carrega_Tabela(sql, tb)
        Try
            Return tb.Rows(0)(0) + 1
        Catch ex As Exception
            Return 1
        End Try

        tb.Dispose()
    End Function
    Public Function diferenca_desconto(ByVal cod_mov As Integer, ByVal x_cod_lanc As Integer, ByVal filial As Integer, ByVal desconto As Double, ByVal diferenca As Double, ByVal preco_real As Double)
        Dim sql As String
        Dim tbdif As New DataTable
        d.carrega_Tabela("Select * from diferenca_desconto where cod_lancamento = " &
        x_cod_lanc & "and cod_movimento = " & cod_mov &
        " and id_filial = " & filial & "", tbdif)
        If tbdif.Rows.Count = 0 Then
            If diferenca = 0 Then
                Return "OK"
                Exit Function
            End If
            sql = "insert into diferenca_desconto(cod_movimento,cod_lancamento,id_filial,desconto," &
            "diferenca,preco_real) values(" &
            cod_mov & "," & x_cod_lanc &
            "," & filial & "," & d.cdin(desconto) & "," &
            d.cdin(diferenca) & "," & d.cdin(preco_real) & ")"
        Else
            sql = "update diferenca_desconto set desconto = " & d.cdin(desconto) &
            ", diferenca = " & d.cdin(diferenca) & ", preco_real = " & d.cdin(preco_real) &
            " where cod_movimento = " & cod_mov & " and id_filial = " & filial & " and " &
            "cod_lancamento = " & x_cod_lanc & ""
        End If
        tbdif.Dispose()
        Return d.Comando(sql, True)
    End Function
    Public Function ret_saldo_fisico(ByVal cod_prod As Integer) As Double
        Dim tb As New DataTable
        Dim sql As String
        Dim saldo As Double = 0
        sql = "select sum(movimento.quant) as saldo from movimento where movimento.cod_produto = " & cod_prod &
        " and movimento.id_filial = " & conf.Filial & ""
        d.carrega_Tabela(sql, tb)
        Try
            saldo = rdNum(tb.Rows(0)("saldo"))
        Catch ex As Exception
            Return saldo
        End Try
        Return saldo
    End Function
    Public Function ret_saldo_fisico(ByVal cod_prod As Integer, ByVal dia As Date) As Double
        Dim tb As New DataTable
        Dim sql As String
        Dim saldo As Double = 0
        sql = "select sum(movimento.quant) as saldo from movimento where movimento.cod_produto = " & cod_prod &
        " and movimento.id_filial = " & conf.Filial & " AND (movimento.data_lancamento <= " & d.pdtm(dia) & ""
        d.carrega_Tabela(sql, tb)
        Try
            saldo = rdNum(tb.Rows(0)("saldo"))
        Catch ex As Exception
            Return saldo
        End Try
        Return saldo
    End Function
    Public Function ret_saldo_fin(ByVal cod_prod As Integer) As Double
        Dim tb As Data.DataTable
        Dim sql As String
        Dim saldo As Double = 0
        sql = "select sum(movimento.quant * (movimento.pUnit - (movimento.punit * (movimento.desconto/100)))) as saldo from movimento where movimento.cod_produto = " & cod_prod &
        " and movimento.id_filial = " & conf.Filial & ""
        d.carrega_Tabela(sql, tb)
        Try
            saldo = rdNum(tb.Rows(0)("saldo"))
        Catch ex As Exception

        End Try
        Return saldo
    End Function
    Public Function ret_saldo_fin(ByVal cod_prod As Integer, ByVal dia As Date) As Double
        Dim tb As Data.DataTable
        Dim sql As String
        Dim saldo As Double = 0
        sql = "select sum(movimento.quant * (movimento.pUnit - (movimento.punit * (movimento.desconto/100)))) as saldo from movimento where movimento.cod_produto = " & cod_prod &
        " and movimento.id_filial = " & conf.Filial & " AND (movimento.data_lancamento <= " & d.pdtm(dia) & ""
        d.carrega_Tabela(sql, tb)
        Try
            saldo = rdNum(tb.Rows(0)("saldo"))
        Catch ex As Exception

        End Try
        Return saldo
    End Function
    Public Function ret_saldo_todos_fisico(ByVal cod_len As Integer) As Double
        Dim tb As New DataTable
        Dim sql As String
        Dim saldo As Double = 0
        sql = "SELECT SUM(movimento.quant) AS saldo " & _
        "FROM movimento INNER JOIN " & _
        "produtos ON movimento.cod_produto = produtos.cod_produto INNER JOIN " & _
        "lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente AND " & _
        "produtos.id_fabricante = lentes_blocos.id_fabricante " & _
        "WHERE (lentes_blocos.cod_lente = " & cod_len & ")"
        d.carrega_Tabela(sql, tb)
        Try
            saldo = rdNum(tb.Rows(0)("saldo"))
        Catch ex As Exception
            Return saldo
        End Try
        Return saldo
    End Function
    Public Function ret_saldo_todos_fin(ByVal cod_len As Integer) As Double
        Dim tb As Data.DataTable
        Dim sql As String
        Dim saldo As Double = 0
        sql = "select sum(movimento.quant * (movimento.pUnit - (movimento.punit * (movimento.desconto/100)))) as saldo " & _
        "from movimento INNER JOIN " & _
        "produtos ON movimento.cod_produto = produtos.cod_produto INNER JOIN " & _
        "lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente AND " & _
        "produtos.id_fabricante = lentes_blocos.id_fabricante " & _
        "WHERE (lentes_blocos.cod_lente = " & cod_len & ")"
        d.carrega_Tabela(sql, tb)
        Try
            saldo = rdNum(tb.Rows(0)("saldo"))
        Catch ex As Exception

        End Try
        Return saldo
    End Function
    Public Function atualiza_custo(ByVal cod_len As Integer, ByVal custo As Double)
        Dim sql As String
        Dim res As String
        sql = "update lentes_blocos set preco_custo = " & d.cdin(custo) & " where cod_lente = " & _
        cod_len & ""
        res = d.Comando(sql, True)
        If res.Substring(0, 2) = "ER" Then
            Return res
        Else
            Return res
        End If
    End Function
    Public Function atualiza_custo(ByVal cod_len As Integer, ByVal custo_len As Double, ByVal cod_prod As Integer, ByVal custo_prod As Double)
        Dim sql As String
        Dim res As String
        sql = "update lentes_blocos set preco_custo = " & d.cdin(custo_len) & " where cod_lente = " & _
        cod_len & ""
        res = d.Comando(sql, True)
        sql = "update produtos set preco_custo = " & d.cdin(custo_prod) & " where cod_produto = " & _
        cod_prod & ""
        d.Comando(sql, True)
        Return res
    End Function
    Public Function retorna_cod_lentebloco(ByVal cod_prod As Integer)
        'Retorna o código da tabela lentes_blocos
        Dim tb As New DataTable
        Dim sql As String
        sql = "Select cod_lente from  produtos where cod_produto  = " & cod_prod & ""
        d.carrega_Tabela(sql, tb)
        If tb.Rows.Count = 1 Then
            Return tb.Rows(0)(0)
        Else
            Return 0
        End If
    End Function
    Public Function Giro_produtos(ByVal xcod_tabela As Integer, ByVal di As Date, ByVal df As Date, ByVal fil As Integer) As DataTable
        Dim sql As String
        Dim tt As New DataTable
        Dim prod As New produtoClass
        Dim e As String
        Dim data_inicial, data_final, dI30, di60, di90 As Date
        data_inicial = di.Date & " 00:00:00"
        data_final = df.Date & " 23:59:59"
        dI30 = DateAdd(DateInterval.Day, -30, di).Date & " 00:00:00"
        di60 = DateAdd(DateInterval.Day, -60, di).Date & " 00:00:00"
        di90 = DateAdd(DateInterval.Day, -90, di).Date & " 00:00:00"
        e = prod.ret_especie(xcod_tabela)
        If e.ToUpper.Trim = "L" Then
            sql = "SELECT lentes_blocos.cod_tabela, produtos.produto, produtos.cod_produto, " & _
                    "(" & _
                    "SELECT     SUM(movimento.quant) AS Entradas FROM  movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant > 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(data_inicial) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ") " & _
                    "and (movimento.id_filial = " & fil & ")) " & _
                    "as Entradas_periodo, " & _
                    "(" & _
                    "SELECT SUM(movimento.quant) AS Entradas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant < 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(data_inicial) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ") " & _
                    "and (movimento.id_filial = " & fil & ")) " & _
                    "as saidas_periodo, " & _
                    "((" & _
                    "SELECT     SUM(movimento.quant) AS saidas FROM  movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant < 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(data_inicial) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ") " & _
                    "and (movimento.id_filial = " & fil & ")) / " & _
                    "(" & _
                    "SELECT     SUM(movimento.quant) AS Entradas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant > 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(data_inicial) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ") " & _
                    "and (movimento.id_filial = " & fil & "))*-1) " & _
                    " as giro_periodo, " & _
                    "(" & _
                    "SELECT     SUM(movimento.quant) AS Entradas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant > 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(dI30) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ") " & _
                    "and (movimento.id_filial = " & fil & ")) " & _
                    "as Entradas_30," & _
                    "(" & _
                    "SELECT     SUM(movimento.quant) AS saidas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant < 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(dI30) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ") " & _
                    "and (movimento.id_filial = " & fil & ")) " & _
                    "as saidas_30, " & _
                    "((" & _
                    "SELECT SUM(movimento.quant) AS saidas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant < 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(dI30) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ") " & _
                    "and (movimento.id_filial = " & fil & ")) /" & _
                    "(" & _
                    "SELECT SUM(movimento.quant) AS Entradas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant > 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(dI30) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ") " & _
                    "and (movimento.id_filial = " & fil & "))  *-1) " & _
                    "as giro_30, " & _
                    "(" & _
                    "SELECT SUM(movimento.quant) AS Entradas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant > 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(di60) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ") " & _
                    "and (movimento.id_filial = " & fil & ")) " & _
                    "as Entradas_60, " & _
                    "(" & _
                    "SELECT SUM(movimento.quant) AS saidas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant < 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(di60) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ") " & _
                    "and (movimento.id_filial = " & fil & ")) " & _
                    "as saidas_60, " & _
                    "((" & _
                    "SELECT SUM(movimento.quant) AS saidas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant < 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(di60) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ") " & _
                    "and (movimento.id_filial = " & fil & "))  / " & _
                    "(" & _
                    "SELECT SUM(movimento.quant) AS Entradas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant > 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(di60) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ") " & _
                    "and (movimento.id_filial = " & fil & ")) *-1)" & _
                    "as giro_60, " & _
                    "(" & _
                    "SELECT SUM(movimento.quant) AS Entradas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant > 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(di90) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ") " & _
                    "and (movimento.id_filial = " & fil & ")) " & _
                    "as Entradas_90, " & _
                    "(" & _
                    "SELECT SUM(movimento.quant) AS saidas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant < 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(di90) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ") " & _
                    "and (movimento.id_filial = " & fil & ")) " & _
                    "as saidas_90, " & _
                    "((" & _
                    "SELECT SUM(movimento.quant) AS saidas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant < 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(di90) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ") " & _
                    "and (movimento.id_filial = " & fil & ")) / " & _
                    "(" & _
                    "SELECT SUM(movimento.quant) AS Entradas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant > 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(di90) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ") " & _
                    "and (movimento.id_filial = " & fil & ")) *-1) " & _
                    "as giro_90, " & _
                    "(" & _
                    "(select SUM(movimento.quant) as saldo from movimento where movimento.cod_produto = " & _
                    "produtos.cod_produto and movimento.id_filial = " & fil & ") - " & _
                    "((SELECT COUNT(cod_produto) AS r_lente from reserva_lente_os " & _
                    "WHERE (id_status_reserva = 0) AND (reserva_lente_os.cod_produto = " & _
                    "produtos.cod_produto) and (reserva_lente_os.id_filial = " & fil & "))) + (" & _
                    "SELECT COUNT(cod_produto) AS r_lente FROM reserva_lente_pedido " & _
                    "WHERE (id_status_reserva = 0) AND (reserva_lente_pedido.cod_produto = " & _
                    "produtos.cod_produto) and (reserva_lente_pedido.id_filial = " & fil & "))) AS Saldo " & _
                    ",lentes.esferico , lentes.cilindrico " & _
                    "FROM  lentes_blocos INNER JOIN " & _
                    "produtos ON lentes_blocos.cod_lente = produtos.cod_lente AND " & _
                    "lentes_blocos.id_fabricante = produtos.id_fabricante " & _
                    "INNER JOIN lentes ON produtos.cod_produto = lentes.cod_produto " & _
                    "GROUP BY lentes_blocos.cod_tabela, produtos.produto, produtos.cod_produto, " & _
                    "lentes.esferico, lentes.cilindrico " & _
                    "HAVING (lentes_blocos.cod_tabela = " & xcod_tabela & ") " & _
                    "order by lentes.esferico desc, lentes.cilindrico desc "
        Else
            sql = "SELECT lentes_blocos.cod_tabela, produtos.produto, produtos.cod_produto, " & _
                    "(" & _
                    "SELECT     SUM(movimento.quant) AS Entradas FROM  movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant > 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(data_inicial) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ")) " & _
                    "as Entradas_periodo, " & _
                    "(" & _
                    "SELECT SUM(movimento.quant) AS Entradas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant < 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(data_inicial) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ")) " & _
                    "as saidas_periodo, " & _
                    "((" & _
                    "SELECT     SUM(movimento.quant) AS saidas FROM  movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant < 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(data_inicial) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & "))/ " & _
                    "(" & _
                    "SELECT     SUM(movimento.quant) AS Entradas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant > 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(data_inicial) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & "))*-1) " & _
                    " as giro_periodo, " & _
                    "(" & _
                    "SELECT     SUM(movimento.quant) AS Entradas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant > 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(dI30) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ")) " & _
                    "as Entradas_30," & _
                    "(" & _
                    "SELECT     SUM(movimento.quant) AS saidas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant < 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(dI30) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ")) " & _
                    "as saidas_30, " & _
                    "((" & _
                    "SELECT SUM(movimento.quant) AS saidas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant < 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(dI30) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ")) /" & _
                    "(" & _
                    "SELECT SUM(movimento.quant) AS Entradas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant > 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(dI30) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ")) *-1) " & _
                    "as giro_30, " & _
                    "(" & _
                    "SELECT SUM(movimento.quant) AS Entradas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant > 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(di60) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ")) " & _
                    "as Entradas_60, " & _
                    "(" & _
                    "SELECT SUM(movimento.quant) AS saidas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant < 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(di60) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ")) " & _
                    "as saidas_60, " & _
                    "((" & _
                    "SELECT SUM(movimento.quant) AS saidas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant < 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(di60) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ")) / " & _
                    "(" & _
                    "SELECT SUM(movimento.quant) AS Entradas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant > 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(di60) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ")) *-1)" & _
                    "as giro_60, " & _
                    "(" & _
                    "SELECT SUM(movimento.quant) AS Entradas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant > 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(di90) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ")) " & _
                    "as Entradas_90, " & _
                    "(" & _
                    "SELECT SUM(movimento.quant) AS saidas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant < 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(di90) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ")) " & _
                    "as saidas_90, " & _
                    "((" & _
                    "SELECT SUM(movimento.quant) AS saidas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant < 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(di90) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ")) / " & _
                    "(" & _
                    "SELECT SUM(movimento.quant) AS Entradas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant > 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(di90) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ")) *-1)" & _
                    "as giro_90, " & _
                    "(" & _
                    "(select SUM(movimento.quant) as saldo from movimento where movimento.cod_produto = " & _
                    "produtos.cod_produto) - " & _
                    "((SELECT COUNT(cod_produto) AS r_lente from reserva_lente_os " & _
                    "WHERE (id_status_reserva = 0) AND (reserva_lente_os.cod_produto = " & _
                    "produtos.cod_produto))) + (" & _
                    "SELECT COUNT(cod_produto) AS r_lente FROM reserva_lente_pedido " & _
                    "WHERE (id_status_reserva = 0) AND (reserva_lente_pedido.cod_produto = " & _
                    "produtos.cod_produto))) AS Saldo " & _
                    ",blocos.Base_nominal, blocos.Adicao, blocos.olho " & _
                    "FROM  lentes_blocos INNER JOIN " & _
                    "produtos ON lentes_blocos.cod_lente = produtos.cod_lente AND " & _
                    "lentes_blocos.id_fabricante = produtos.id_fabricante " & _
                    "INNER JOIN blocos ON produtos.cod_produto = blocos.Cod_produto " & _
                    "GROUP BY lentes_blocos.cod_tabela, produtos.produto, produtos.cod_produto, " & _
                    "blocos.Base_nominal, blocos.Adicao, blocos.olho" & _
                    " HAVING (lentes_blocos.cod_tabela = " & xcod_tabela & ") " & _
                    "order by blocos.Base_nominal, blocos.Adicao, blocos.olho "
        End If

        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function Giro_produtos(ByVal xcod_tabela As Integer, ByVal di As Date, ByVal df As Date) As DataTable
        Dim sql As String
        Dim tt As New DataTable
        Dim prod As New produtoClass
        Dim e As String
        Dim data_inicial, data_final, dI30, di60, di90 As Date
        data_inicial = di.Date & " 00:00:00"
        data_final = df.Date & " 23:59:59"
        dI30 = DateAdd(DateInterval.Day, -30, di).Date & " 00:00:00"
        di60 = DateAdd(DateInterval.Day, -60, di).Date & " 00:00:00"
        di90 = DateAdd(DateInterval.Day, -90, di).Date & " 00:00:00"
        e = prod.ret_especie(xcod_tabela)
        If e.ToUpper.Trim = "L" Then
            sql = "SELECT lentes_blocos.cod_tabela, produtos.produto, produtos.cod_produto, " & _
                    "(" & _
                    "SELECT     SUM(movimento.quant) AS Entradas FROM  movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant > 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(data_inicial) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ")) " & _
                    "as Entradas_periodo, " & _
                    "(" & _
                    "SELECT SUM(movimento.quant) AS Entradas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant < 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(data_inicial) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ")) " & _
                    "as saidas_periodo, " & _
                    "((" & _
                    "SELECT     SUM(movimento.quant) AS saidas FROM  movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant < 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(data_inicial) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & "))/ " & _
                    "(" & _
                    "SELECT     SUM(movimento.quant) AS Entradas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant > 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(data_inicial) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & "))*-1) " & _
                    " as giro_periodo, " & _
                    "(" & _
                    "SELECT     SUM(movimento.quant) AS Entradas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant > 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(dI30) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ")) " & _
                    "as Entradas_30," & _
                    "(" & _
                    "SELECT     SUM(movimento.quant) AS saidas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant < 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(dI30) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ")) " & _
                    "as saidas_30, " & _
                    "((" & _
                    "SELECT SUM(movimento.quant) AS saidas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant < 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(dI30) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ")) /" & _
                    "(" & _
                    "SELECT SUM(movimento.quant) AS Entradas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant > 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(dI30) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ")) *-1) " & _
                    "as giro_30, " & _
                    "(" & _
                    "SELECT SUM(movimento.quant) AS Entradas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant > 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(di60) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ")) " & _
                    "as Entradas_60, " & _
                    "(" & _
                    "SELECT SUM(movimento.quant) AS saidas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant < 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(di60) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ")) " & _
                    "as saidas_60, " & _
                    "((" & _
                    "SELECT SUM(movimento.quant) AS saidas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant < 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(di60) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ")) / " & _
                    "(" & _
                    "SELECT SUM(movimento.quant) AS Entradas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant > 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(di60) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ")) *-1)" & _
                    "as giro_60, " & _
                    "(" & _
                    "SELECT SUM(movimento.quant) AS Entradas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant > 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(di90) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ")) " & _
                    "as Entradas_90, " & _
                    "(" & _
                    "SELECT SUM(movimento.quant) AS saidas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant < 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(di90) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ")) " & _
                    "as saidas_90, " & _
                    "((" & _
                    "SELECT SUM(movimento.quant) AS saidas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant < 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(di90) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ")) / " & _
                    "(" & _
                    "SELECT SUM(movimento.quant) AS Entradas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant > 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(di90) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ")) *-1)" & _
                    "as giro_90, " & _
                    "(" & _
                    "(select SUM(movimento.quant) as saldo from movimento where movimento.cod_produto = " & _
                    "produtos.cod_produto) - " & _
                    "((SELECT COUNT(cod_produto) AS r_lente from reserva_lente_os " & _
                    "WHERE (id_status_reserva = 0) AND (reserva_lente_os.cod_produto = " & _
                    "produtos.cod_produto))) + (" & _
                    "SELECT COUNT(cod_produto) AS r_lente FROM reserva_lente_pedido " & _
                    "WHERE (id_status_reserva = 0) AND (reserva_lente_pedido.cod_produto = " & _
                    "produtos.cod_produto))) AS Saldo " & _
                    ",lentes.esferico , lentes.cilindrico " & _
                    "FROM  lentes_blocos INNER JOIN " & _
                    "produtos ON lentes_blocos.cod_lente = produtos.cod_lente AND " & _
                    "lentes_blocos.id_fabricante = produtos.id_fabricante " & _
                    "INNER JOIN lentes ON produtos.cod_produto = lentes.cod_produto " & _
                    "GROUP BY lentes_blocos.cod_tabela, produtos.produto, produtos.cod_produto, " & _
                    "lentes.esferico, lentes.cilindrico " & _
                    "HAVING (lentes_blocos.cod_tabela = " & xcod_tabela & ") " & _
                    "order by lentes.esferico desc, lentes.cilindrico desc "
        Else
            sql = "SELECT lentes_blocos.cod_tabela, produtos.produto, produtos.cod_produto, " & _
                    "(" & _
                    "SELECT     SUM(movimento.quant) AS Entradas FROM  movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant > 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(data_inicial) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ")) " & _
                    "as Entradas_periodo, " & _
                    "(" & _
                    "SELECT SUM(movimento.quant) AS Entradas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant < 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(data_inicial) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ")) " & _
                    "as saidas_periodo, " & _
                    "((" & _
                    "SELECT     SUM(movimento.quant) AS saidas FROM  movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant < 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(data_inicial) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & "))/ " & _
                    "(" & _
                    "SELECT     SUM(movimento.quant) AS Entradas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant > 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(data_inicial) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & "))*-1) " & _
                    " as giro_periodo, " & _
                    "(" & _
                    "SELECT     SUM(movimento.quant) AS Entradas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant > 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(dI30) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ")) " & _
                    "as Entradas_30," & _
                    "(" & _
                    "SELECT     SUM(movimento.quant) AS saidas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant < 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(dI30) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ")) " & _
                    "as saidas_30, " & _
                    "((" & _
                    "SELECT SUM(movimento.quant) AS saidas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant < 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(dI30) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ")) /" & _
                    "(" & _
                    "SELECT SUM(movimento.quant) AS Entradas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant > 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(dI30) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ")) *-1) " & _
                    "as giro_30, " & _
                    "(" & _
                    "SELECT SUM(movimento.quant) AS Entradas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant > 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(di60) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ")) " & _
                    "as Entradas_60, " & _
                    "(" & _
                    "SELECT SUM(movimento.quant) AS saidas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant < 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(di60) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ")) " & _
                    "as saidas_60, " & _
                    "((" & _
                    "SELECT SUM(movimento.quant) AS saidas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant < 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(di60) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ")) / " & _
                    "(" & _
                    "SELECT SUM(movimento.quant) AS Entradas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant > 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(di60) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ")) *-1)" & _
                    "as giro_60, " & _
                    "(" & _
                    "SELECT SUM(movimento.quant) AS Entradas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant > 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(di90) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ")) " & _
                    "as Entradas_90, " & _
                    "(" & _
                    "SELECT SUM(movimento.quant) AS saidas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant < 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(di90) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ")) " & _
                    "as saidas_90, " & _
                    "((" & _
                    "SELECT SUM(movimento.quant) AS saidas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant < 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(di90) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ")) / " & _
                    "(" & _
                    "SELECT SUM(movimento.quant) AS Entradas FROM movimento INNER JOIN " & _
                    "movimentomaster ON movimento.cod_Movimento = movimentomaster.cod_movimento AND " & _
                    "movimento.id_filial = movimentomaster.id_filial " & _
                    "WHERE (movimento.quant > 0) AND (movimento.cod_produto = produtos.cod_produto) " & _
                    "AND (movimentomaster.data >= " & d.pdtm(di90) & ") " & _
                    "AND (movimentomaster.data <= " & d.pdtm(data_final) & ")) *-1)" & _
                    "as giro_90, " & _
                    "(" & _
                    "(select SUM(movimento.quant) as saldo from movimento where movimento.cod_produto = " & _
                    "produtos.cod_produto) - " & _
                    "((SELECT COUNT(cod_produto) AS r_lente from reserva_lente_os " & _
                    "WHERE (id_status_reserva = 0) AND (reserva_lente_os.cod_produto = " & _
                    "produtos.cod_produto))) + (" & _
                    "SELECT COUNT(cod_produto) AS r_lente FROM reserva_lente_pedido " & _
                    "WHERE (id_status_reserva = 0) AND (reserva_lente_pedido.cod_produto = " & _
                    "produtos.cod_produto))) AS Saldo " & _
                    ",blocos.Base_nominal, blocos.Adicao, blocos.olho " & _
                    "FROM  lentes_blocos INNER JOIN " & _
                    "produtos ON lentes_blocos.cod_lente = produtos.cod_lente AND " & _
                    "lentes_blocos.id_fabricante = produtos.id_fabricante " & _
                    "INNER JOIN blocos ON produtos.cod_produto = blocos.Cod_produto " & _
                    "GROUP BY lentes_blocos.cod_tabela, produtos.produto, produtos.cod_produto, " & _
                    "blocos.Base_nominal, blocos.Adicao, blocos.olho" & _
                    " HAVING (lentes_blocos.cod_tabela = " & xcod_tabela & ") " & _
                    "order by blocos.Base_nominal, blocos.Adicao, blocos.olho "
        End If

        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
#End Region
End Class
