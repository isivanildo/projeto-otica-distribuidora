Public Class objTabela
#Region "Atributos"
    Private _cod_tabela As Integer
    Private _id_fabricante As Integer
    Private _cod_tipo_lente As Integer
    Private _nome_comercial As String
    Private _especie As Object
    Private _ir As Object
    Private _aco_minimo As Object
    Private _abbe As Object
    Private _desconto_venda As Object
    Private _preco_venda As Object
    Private _id_material As Integer
    Private _caracteristicas As Object
    Private _disponibilidade As Object
    Private _adicao As Object
    Private _preco_compra As Object
    Private _desconto_compra As Object
    Private _preco_nota As Object
    Private _fator_preco_prod As Integer
    Private _ncm As Integer
    Private _tributacao As Integer
    Private _origem As Char
    Private _unidade As String
    Private _labonorte_sai As Boolean
    Public bloco_digital As New bloco_digital
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
    Public Property cod_tabela()
        Get
            cod_tabela = _cod_tabela
        End Get
        Set(ByVal Value)
            _cod_tabela = Value
        End Set
    End Property
    Public Property id_fabricante()
        Get
            id_fabricante = _id_fabricante
        End Get
        Set(ByVal Value)
            _id_fabricante = Value
        End Set
    End Property
    Public Property cod_tipo_lente()
        Get
            cod_tipo_lente = _cod_tipo_lente
        End Get
        Set(ByVal Value)
            _cod_tipo_lente = Value
        End Set
    End Property
    Public Property id_material()
        Get
            id_material = _id_material
        End Get
        Set(ByVal Value)
            _id_material = Value
        End Set
    End Property
    Public Property nome_comercial()
        Get
            nome_comercial = _nome_comercial
        End Get
        Set(ByVal Value)
            _nome_comercial = Value
        End Set
    End Property
    Public Property especie()
        Get
            especie = _especie
        End Get
        Set(ByVal Value)
            _especie = Value
        End Set
    End Property
    Public Property ir()
        Get
            ir = _ir
        End Get
        Set(ByVal Value)
            _ir = Value
        End Set
    End Property
    Public Property aco_minimo()
        Get
            aco_minimo = _aco_minimo
        End Get
        Set(ByVal Value)
            _aco_minimo = Value
        End Set
    End Property
    Public Property abbe()
        Get
            abbe = _abbe
        End Get
        Set(ByVal Value)
            _abbe = Value
        End Set
    End Property
    Public Property preco_venda()
        Get
            preco_venda = _preco_venda
        End Get
        Set(ByVal Value)
            _preco_venda = Value
        End Set
    End Property
    Public Property desconto_venda()
        Get
            desconto_venda = _desconto_venda
        End Get
        Set(ByVal Value)
            _desconto_venda = Value
        End Set
    End Property
    Public Property caracteristicas()
        Get
            caracteristicas = _caracteristicas
        End Get
        Set(ByVal Value)
            _caracteristicas = Value
        End Set
    End Property
    Public Property disponibilidade()
        Get
            disponibilidade = _disponibilidade
        End Get
        Set(ByVal Value)
            _disponibilidade = Value
        End Set
    End Property
    Public Property adicao()
        Get
            adicao = _adicao
        End Get
        Set(ByVal Value)
            _adicao = Value
        End Set
    End Property
    Public Property preco_compra()
        Get
            preco_compra = _preco_compra
        End Get
        Set(ByVal Value)
            _preco_compra = Value
        End Set
    End Property
    Public Property desconto_compra()
        Get
            desconto_compra = _desconto_compra
        End Get
        Set(ByVal Value)
            _desconto_compra = Value
        End Set
    End Property
    Public Property preco_nota()
        Get
            preco_nota = _preco_nota
        End Get
        Set(ByVal Value)
            _preco_nota = Value
        End Set
    End Property
    Public Property fator_preco_prod
        Get
            fator_preco_prod = _fator_preco_prod
        End Get
        Set(value)
            _fator_preco_prod = value
        End Set
    End Property
    Public Property ncm
        Get
            ncm = _ncm
        End Get
        Set(value)
            _ncm = value
        End Set
    End Property
    Public Property tributacao
        Get
            tributacao = _tributacao
        End Get
        Set(value)
            _tributacao = value
        End Set
    End Property
    Public Property origem
        Get
            origem = _origem
        End Get
        Set(value)
            _origem = value
        End Set
    End Property
    Public Property unidade
        Get
            unidade = _unidade
        End Get
        Set(value)
            _unidade = value
        End Set
    End Property
    Public Property labonorte_sai
        Get
            labonorte_sai = _labonorte_sai
        End Get
        Set(value)
            _labonorte_sai = value
        End Set
    End Property

#End Region
#Region "Procedimentos"
    Public Sub New()
        Me.Source("Select * from lentes_tabela order by id_fabricante, nome_comercial")
    End Sub
    Public Sub New(ByVal top As Integer)
        Me.Source("Select top(" & top & ") * from lentes_tabela order by id_fabricante, nome_comercial")
    End Sub
    Public Sub New(ByVal xdados As dados)
        d = xdados
        Me.Source("Select * from lentes_tabela order by id_fabricante,nome_comercial")
    End Sub
    Public Sub filtra(ByVal xCodTabela As Integer)
        Me.Source("Select * from lentes_tabela where cod_tabela = " & xCodTabela & " order by nome_comercial")
    End Sub
    Public Sub New(ByVal sql As String)
        Me.Source(sql)
    End Sub
    Public Sub Source(ByVal iSql As String)
        sql = iSql
        Me.refreshData()
    End Sub
    Public Sub refreshData()
        d.carrega_Tabela(sql, tb)
        max = tb.Rows.Count
        Registro(0)
    End Sub
    Public Sub Registro(ByVal pos As Integer) 'Move o Registro para a posição indicada
        Dim p As Integer = pos
        If p <= 0 Then p = 0
        If p > max Then p = max
        posicao = p
        If max > 0 Then
            _cod_tabela = tb.Rows(p)("cod_tabela")
            _id_fabricante = tb.Rows(p)("id_fabricante")
            _cod_tipo_lente = tb.Rows(p)("cod_tipo_lente")
            _nome_comercial = rdTexto(tb.Rows(p)("nome_comercial"))
            _especie = rdTexto(tb.Rows(p)("especie"))
            _ir = rdNum(tb.Rows(p)("IR"))
            _aco_minimo = rdNum(tb.Rows(p)("aco_minimo"))
            _id_material = rdNum(tb.Rows(p)("id_material"))
            _abbe = rdNum(tb.Rows(p)("abbe"))
            _preco_venda = rdNum(tb.Rows(p)("preco_venda"))
            _desconto_venda = rdNum(tb.Rows(p)("desconto_venda"))
            _caracteristicas = rdTexto(tb.Rows(p)("caracteristicas"))
            _disponibilidade = rdTexto(tb.Rows(p)("disponibilidade"))
            _adicao = rdTexto(tb.Rows(p)("adicao"))
            _preco_compra = rdNum(tb.Rows(p)("preco_compra"))
            _desconto_compra = rdNum(tb.Rows(p)("desconto_compra"))
            _preco_nota = rdNum(tb.Rows(p)("preco_nota"))
            _ncm = rdNum(tb.Rows(p)("ncm"))
            _tributacao = rdNum(tb.Rows(p)("tributacao"))
            _origem = rdTexto(tb.Rows(p)("origem"))
            _unidade = rdTexto(tb.Rows(p)("unidade"))
            _labonorte_sai = True
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
        _cod_tabela = 0
        _id_fabricante = 0
        _cod_tipo_lente = 0
        _nome_comercial = ""
        _ir = Nothing
        _aco_minimo = Nothing
        _abbe = Nothing
        _preco_venda = Nothing
        _desconto_venda = Nothing
        _disponibilidade = Nothing
        _adicao = ""
        _preco_compra = Nothing
        _desconto_compra = Nothing
        _preco_nota = Nothing
        _ncm = 0
        _tributacao = 0
        _origem = "N"
        _unidade = "UN"
        OrigemSalvar = "Novo" 'Define o tipo de ação ao salvar
    End Function
    Public Function Salvar() As String
        Dim cmd As New SqlClient.SqlCommand
        Dim sql As String
        Dim res As String 'Quantidade de registros afetados
        d.conecta()
        cmd.Connection = d.con
        If OrigemSalvar = "Novo" Then
            Try
                sql = "Insert into lentes_tabela(cod_tabela,id_fabricante,cod_tipo_lente, " &
                "nome_comercial,especie, " &
                "ir,aco_minimo,abbe,id_material," &
                "preco_venda,desconto_venda,caracteristicas,disponibilidade,adicao," &
                "preco_compra,desconto_compra,preco_nota,ncm,tributacao,origem,unidade,labonorte_sai) Values(" &
                _cod_tabela & "," &
                _id_fabricante &
                "," & _cod_tipo_lente & "," &
                d.PStr(_nome_comercial) &
                "," & d.PStr(_especie) &
                "," & d.cdin(_ir) & "," &
                d.cdin(_aco_minimo) &
                "," & d.cdin(_abbe) & "," &
                _id_material &
                "," & d.cdin(_preco_venda) & "," &
                d.cdin(_desconto_venda) & "," &
                d.PStr(_caracteristicas) & "," &
                d.PStr(_disponibilidade) &
                "," & d.PStr(_adicao) &
                "," & d.cdin(_preco_compra) & "," &
                d.cdin(_desconto_compra) & "," &
                d.cdin(_preco_nota) & "," &
                _ncm & "," &
                _tributacao & "," &
                d.PStr(_origem) & "," &
                d.PStr(_unidade) & "," &
                d.PStr(_labonorte_sai.ToString) &
                ")"
                res = d.Comando(sql, True)
                If res.Substring(0, 3) = "ER:" Then
                    Return res & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                    Registro(lastPos)
                    Exit Function
                End If
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tb.NewRow
            r("cod_tabela") = _cod_tabela
            r("id_fabricante") = _id_fabricante
            r("cod_tipo_lente") = _cod_tipo_lente
            r("nome_comercial") = rdTexto(_nome_comercial)
            r("especie") = rdTexto(_especie)
            r("ir") = wrNum(_ir)
            r("aco_minimo") = wrNum(_aco_minimo)
            r("abbe") = wrNum(_abbe)
            r("id_material") = _id_material
            r("preco_venda") = wrNum(_preco_venda)
            r("desconto_venda") = wrNum(_desconto_venda)
            r("caracteristicas") = rdTexto(_caracteristicas)
            r("disponibilidade") = rdTexto(_disponibilidade)
            r("adicao") = rdTexto(_adicao)
            r("preco_compra") = wrNum(_preco_compra)
            r("desconto_compra") = wrNum(_desconto_compra)
            r("preco_nota") = wrNum(_preco_nota)
            r("ncm") = _ncm
            r("tributacao") = _tributacao
            r("origem") = rdTexto(_origem)
            r("unidade") = rdTexto(_unidade)
            r("labonorte_sai") = _labonorte_sai
            tb.Rows.Add(r)
            max = max + 1
            If max = 1 Then
                posicao = 0
            Else
                posicao = max - 1
            End If
            OrigemSalvar = ""
            Return res & " adicionado(s) com sucesso!"
        End If
        If Me.OrigemSalvar = "Editar" Then
            Try
                sql = "Update lentes_tabela set " &
                "cod_tabela = " & _cod_tabela &
                ",id_fabricante = " & _id_fabricante &
                ",cod_tipo_lente = " & _cod_tipo_lente &
                ",nome_comercial = " & d.PStr(_nome_comercial) &
                ",especie = " & d.PStr(_especie) &
                ",ir = " & d.cdin(_ir) &
                ",aco_minimo=" & d.cdin(_aco_minimo) &
                ",abbe = " & d.cdin(_abbe) &
                ",id_material = " & _id_material &
                ",preco_venda = " & d.cdin(_preco_venda) &
                ",desconto_venda = " & d.cdin(_desconto_venda) &
                ",caracteristicas = " & d.PStr(_caracteristicas) &
                ",disponibilidade = " & d.PStr(_disponibilidade) &
                ",adicao = " & d.PStr(_adicao) &
                ",preco_compra = " & d.cdin(_preco_compra) &
                ",desconto_compra = " & d.cdin(_desconto_compra) &
                ",preco_nota = " & d.cdin(_preco_nota) &
                ",ncm = " & _ncm &
                ",tributacao = " & _tributacao &
                ",origem = " & d.PStr(_origem) &
                ",unidade = " & d.PStr(_unidade) &
                ",labonorte_sai = " & d.PStr(_labonorte_sai.ToString) &
                " where cod_tabela = " & chaveCriterio & ""
                res = d.Comando(sql, True)
                If res.Substring(0, 3) = "ER:" Then
                    'Captura o erro da execução do d.comando(sql,true)
                    Return res 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                    Registro(lastPos)
                    Exit Function
                End If
                sql = "update produtos set produtos.preco_venda = " & d.cdin(_preco_venda) &
                ", produtos.desconto = " & d.cdin(_desconto_venda) &
                ", produtos.preco_tabela = " & d.cdin(Format(_preco_venda - (_preco_venda * _desconto_venda / 100), "#,##0.00")) &
                ", produtos.fator_preco = " & _fator_preco_prod &
                ", produtos.preco_compra = " & d.cdin(_preco_compra) &
                ", produtos.desconto_compra = " & d.cdin(_desconto_compra) &
                " FROM  produtos INNER JOIN " &
                "lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente AND " &
                "produtos.id_fabricante = lentes_blocos.id_fabricante INNER JOIN " &
                "lentes_tabela ON lentes_blocos.cod_tabela = lentes_tabela.cod_tabela " &
                " where lentes_tabela.cod_tabela = " & _cod_tabela & ""
                MsgBox(d.Comando(sql, True))
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tb.Rows(posicao)
            r("cod_tabela") = _cod_tabela
            r("id_fabricante") = _id_fabricante
            r("cod_tipo_lente") = _cod_tipo_lente
            r("nome_comercial") = rdTexto(_nome_comercial)
            r("especie") = rdTexto(_especie)
            r("ir") = wrNum(_ir)
            r("aco_minimo") = wrNum(_aco_minimo)
            r("abbe") = wrNum(_abbe)
            r("id_material") = _id_material
            r("preco_venda") = wrNum(_preco_venda)
            r("desconto_venda") = wrNum(_desconto_venda)
            r("caracteristicas") = rdTexto(_caracteristicas)
            r("disponibilidade") = rdTexto(_disponibilidade)
            r("adicao") = rdTexto(_adicao)
            r("preco_compra") = wrNum(_preco_compra)
            r("desconto_compra") = wrNum(_desconto_compra)
            r("preco_nota") = wrNum(_preco_nota)
            r("ncm") = _ncm
            r("tributacao") = _tributacao
            r("origem") = rdTexto(_origem)
            r("unidade") = rdTexto(_unidade)
            r("labonorte_sai") = _labonorte_sai
            OrigemSalvar = ""
            Return res & " atualizado(s) com sucesso!"
        End If
    End Function
    Public Function deletar(ByVal id_tabela As Integer)
        Dim cmd As New SqlClient.SqlCommand
        Dim res As String
        Dim sql As String
        d.conecta()
        Try
            res = d.Comando("Delete from lentes_tabela where cod_tabela = " & id_tabela & "", True)
            If res.Substring(0, 3) = "ER:" Then
                'Captura o erro da execução do d.comando(sql,true)
                Return res & vbCrLf & "O registro não pode ser apagado!"
                Registro(lastPos)
                Exit Function
            End If
        Catch ex As Exception
            Return "ER:" & "O registro não pode ser apagado!" & vbCrLf & ex.Message
            Exit Function
        End Try
        Me.refreshData()
        Me.primeiro()
        Return "OK:" & res & " Registro(s) foi(ram) apagado(s)!"
    End Function
    Public Function lista_lentes(ByVal sql As String) As DataTable
        Dim tbr As New DataTable
        d.carrega_Tabela(sql, tbr)
        Return tbr
    End Function
    Public Function ret_especie(ByVal cod_tab As Integer) As String
        Dim tbTipo As New DataTable
        Dim sql As String
        sql = "Select especie from lentes_tabela where cod_tabela = " & cod_tab & ""
        d.carrega_Tabela(sql, tbTipo)
        Return tbTipo.Rows(0)("especie").ToString.Trim
    End Function
    Public Function ret_nome_tabela(ByVal xCod_tabela As Integer) As String
        Dim tSql As String
        Dim tt As New DataTable
        tSql = "Select nome_comercial from lentes_tabela where cod_tabela = " & xCod_tabela & ""
        Try
            d.carrega_Tabela(tSql, tt)
            Return tt.Rows(0)("nome_comercial")
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Public Function gera_exporta_nfe(ByVal nreg As Integer) As String
        Dim ret As String
        ret = "PRODUTO|9"
        posicao = nreg
        Registro(posicao)
        While posicao < nreg + 9
            Registro(posicao)
            ret = ret & vbCrLf & "A|1.02"
            ret = ret & vbCrLf & "I|" & _cod_tabela & "|" & trataSTRNFe(_nome_comercial.ToUpper) &
            "|||||UN|" & cdinN(_preco_venda) & "||UN|" & cdinN(_preco_venda) & "|1.0000"
            ret = ret & vbCrLf & "M|0|1"
            ret = ret & vbCrLf & "N|00|0|3|17||||"
            posicao = posicao + 1
            If posicao = max Then Exit While
        End While
        Return ret
    End Function
    Public Function gera_exporta_nfe_produto(ByVal cod_prod As Integer) As String
        Dim ret As String
        ret = "PRODUTO|1"
        filtra(cod_prod)
        ret = ret & vbCrLf & "A|1.02"
        ret = ret & vbCrLf & "I|" & _cod_tabela & "|" & trataSTRNFe(_nome_comercial.ToUpper) &
        "|||||UN|" & cdinN(_preco_venda) & "||UN|" & cdinN(_preco_venda) & "|1.0000"
        ret = ret & vbCrLf & "M|0|1"
        ret = ret & vbCrLf & "N|00|0|3|17||||"
        Return ret
    End Function
    Public Function saldo_filial(ByVal xfilial As Integer) As DataRow
        Dim tsql As String
        Dim tt As New DataTable
        Dim dr As DataRow
        tsql = "SELECT isnull(SUM(movimento.quant),0) AS Saldo,isnull((SUM(movimento.quant) * " &
        "(lentes_tabela.Preco_compra - (lentes_tabela.preco_compra*( lentes_tabela.desconto_compra/100)))),0) " &
        "as saldo_fin FROM movimento INNER JOIN " &
        "produtos ON movimento.cod_produto = produtos.cod_produto INNER JOIN " &
        "lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente AND " &
        "produtos.id_fabricante = lentes_blocos.id_fabricante INNER JOIN " &
        "lentes_tabela ON lentes_blocos.cod_tabela = lentes_tabela.cod_tabela " &
        "WHERE     (lentes_blocos.cod_tabela =" & _cod_tabela & ") AND " &
        "(movimento.id_filial = " & xfilial & ") " &
        "GROUP BY lentes_tabela.Preco_compra, lentes_tabela.desconto_compra"
        d.carrega_Tabela(tsql, tt)
        Try
            dr = tt.Rows(0)
        Catch ex As Exception
            dr = Nothing
        End Try
        Return dr
    End Function
    Public Function entrada_periodo_filial(ByVal di As String, ByVal df As String, ByVal filial As Integer) As Double
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "SELECT     SUM(movimento.quant) AS quant " &
        "FROM lentes_blocos INNER JOIN produtos ON lentes_blocos.cod_lente = " &
        "produtos.cod_lente AND lentes_blocos.id_fabricante = " &
        "produtos.id_fabricante INNER JOIN movimento ON produtos.cod_produto = " &
        "movimento.cod_produto WHERE (lentes_blocos.cod_tabela = " & _cod_tabela & ")" &
        " and (movimento.quant > 0) " &
        "AND (movimento.data_lancamento >= " & d.pdtm(di) & ")" &
        "AND (movimento.data_lancamento <= " & d.pdtm(df) &
        ") and (movimento.id_filial = " & filial & ")" &
        " GROUP BY lentes_blocos.cod_tabela"

        Try
            d.carrega_Tabela(tsql, tt)
            Return tt.Rows(0)("quant")
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Public Function saida_periodo_filial(ByVal di As String, ByVal df As String, ByVal filial As Integer) As Double
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "SELECT     SUM(movimento.quant) AS quant " &
        "FROM lentes_blocos INNER JOIN produtos ON lentes_blocos.cod_lente = " &
        "produtos.cod_lente AND lentes_blocos.id_fabricante = " &
        "produtos.id_fabricante INNER JOIN movimento ON produtos.cod_produto = " &
        "movimento.cod_produto WHERE (lentes_blocos.cod_tabela = " & _cod_tabela & ")" &
        " and (movimento.quant < 0) " &
        "AND (movimento.data_lancamento >= " & d.pdtm(di) & ")" &
        "AND (movimento.data_lancamento <= " & d.pdtm(df) &
        ") and (movimento.id_filial = " & filial & ")" &
        " GROUP BY lentes_blocos.cod_tabela"

        Try
            d.carrega_Tabela(tsql, tt)
            Return tt.Rows(0)("quant")
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Public Function saldo() As DataRow
        Dim tsql As String
        Dim tt As New DataTable
        Dim dr As DataRow
        tsql = "SELECT isnull(SUM(movimento.quant),0) AS Saldo,isnull((SUM(movimento.quant) * " &
        "(lentes_tabela.Preco_compra - (lentes_tabela.preco_compra*( lentes_tabela.desconto_compra/100)))),0) " &
        "as saldo_fin FROM movimento INNER JOIN " &
        "produtos ON movimento.cod_produto = produtos.cod_produto INNER JOIN " &
        "lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente AND " &
        "produtos.id_fabricante = lentes_blocos.id_fabricante INNER JOIN " &
        "lentes_tabela ON lentes_blocos.cod_tabela = lentes_tabela.cod_tabela " &
        "WHERE     (lentes_blocos.cod_tabela =" & _cod_tabela & ") " &
        "GROUP BY lentes_tabela.Preco_compra, lentes_tabela.desconto_compra"
        d.carrega_Tabela(tsql, tt)
        If tt.Rows.Count = 0 Then
            tt = New DataTable
            tt.Columns.Add("saldo")
            tt.Columns.Add("saldo_fin")
            dr = tt.NewRow
            dr("saldo") = 0
            dr("saldo_fin") = 0
        Else
            dr = tt.Rows(0)
        End If
        Return dr
    End Function
    Public Function nome_fabricante() As String
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "select fabricante from fabricante where id_fabricante = " &
        _id_fabricante & ""
        d.carrega_Tabela(tsql, tt)
        Return tt.Rows(0)("fabricante")
    End Function
#End Region
End Class
Public Class bloco_digital
#Region "Atributos"
    Private _cod_origem As Integer
    Private _cod_destino As Integer
    Private _nome_lente As String
    Dim d As dados
#End Region
#Region "Get Set"
    Public Property cod_origem() As Integer
        Get
            cod_origem = _cod_origem
        End Get
        Set(ByVal value As Integer)
            _cod_origem = value
        End Set
    End Property
    Public Property cod_destino() As Integer
        Get
            cod_destino = _cod_destino
        End Get
        Set(ByVal value As Integer)
            _cod_destino = value
        End Set
    End Property
    Public ReadOnly Property nome_lente() As String
        Get
            nome_lente = _nome_lente
        End Get
    End Property
#End Region
    Public Sub New()

    End Sub
    Public Sub New(ByVal cod_destino As Integer, ByVal db As dados)
        Dim tt As New DataTable
        d = db
        carrega(cod_destino)
    End Sub
    Public Sub carrega(ByVal cod_destino As Integer)
        Dim tt As New DataTable
        Dim tsql As String
        tsql = "Select * from bloco_digital_origem where cod_tabela_destino = " & cod_destino & ""
        d.carrega_Tabela(tsql, tt)
        If tt.Rows.Count = 0 Then
            _cod_destino = Nothing
            _cod_origem = Nothing
            _nome_lente = Nothing
        Else
            _cod_destino = tt.Rows(0)("cod_tabela_destino")
            _cod_origem = tt.Rows(0)("cod_tabela_origem")
            _nome_lente = ret_nome_tabela(_cod_origem)
        End If
    End Sub
    Private Function ret_nome_tabela(ByVal xCod_tabela As Integer) As String
        Dim tSql As String
        Dim tt As New DataTable
        tSql = "Select nome_comercial from lentes_tabela where cod_tabela = " & xCod_tabela & ""
        Try
            d.carrega_Tabela(tSql, tt)
            Return tt.Rows(0)("nome_comercial")
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Public Function insere(ByVal xCod_origem As Integer, ByVal xCod_destino As Integer) As String
        Dim tsql As String
        Dim res As String
        tsql = "INSERT INTO bloco_digital_origem(cod_tabela_origem ,cod_tabela_destino) VALUES(" & xCod_origem &
           "," & xCod_destino & ")"
        res = d.Comando(tsql, True)
        If res.StartsWith("OK") Then
            carrega(xCod_destino)
        End If
    End Function
    Public Function excluir() As String
        Dim tsql As String
        Dim res As String
        tsql = "delete from bloco_digital_origem where cod_tabela_origem = " & _cod_origem & " and cod_tabela_destino = " & cod_destino & ""
        res = d.Comando(tsql, True)
        Return res
    End Function

End Class
