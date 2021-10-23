Public Class objBoleto
#Region "Atributos"
    Inherits objPagamento
    Private _numero As Integer
    Private _cod_lancamento As Integer
    Private _id_filial As Integer
    Private _banco As Integer
    Private _documento As Object
    Private _emitente As Int16
    Private _nossonumero As String
    Private _barra As String
    Private _digitavel As String
    Private _tipo_documento As String
    Private _bol_juros As Decimal
    Private _manual As Boolean
    Private _acrescimo As Decimal
    Private _diasprotesto As Integer
    Private _acaocobranca As String
    Private _usuario_inc As Integer
    Private _usuario_alt As Integer
    Private _envio_boleto As String

    Public Shadows posicao As Integer = 0
    Public Shadows max As Integer
    Public Shadows tabela As New DataTable
    Public Shadows OrigemSalvar As String = ""
    Private lastPos As Integer = 0
    Private sql As String
    Dim d As New dados
    Dim tipo_pag As tipo_pagamento
#End Region
#Region "GET SET"
    Public Property numero()
        Get
            numero = _numero
        End Get
        Set(ByVal Value)
            _numero = Value
        End Set
    End Property
    Public Property banco()
        Get
            banco = _banco
        End Get
        Set(ByVal Value)
            _banco = Value
        End Set
    End Property
    Public Property documento()
        Get
            documento = _documento
        End Get
        Set(ByVal Value)
            _documento = Value
        End Set
    End Property
    Public Property tipo_documento()
        Get
            tipo_documento = _tipo_documento
        End Get
        Set(ByVal Value)
            _tipo_documento = Value
        End Set
    End Property
    Public Property emitente()
        Get
            emitente = _emitente
        End Get
        Set(ByVal Value)
            _emitente = Value
        End Set
    End Property
    Public Property nossonumero()
        Get
            nossonumero = _nossonumero
        End Get
        Set(ByVal Value)
            _nossonumero = Value
        End Set
    End Property
    Public Property digitavel()
        Get
            digitavel = _digitavel
        End Get
        Set(ByVal Value)
            _digitavel = Value
        End Set
    End Property
    Public Property barra()
        Get
            barra = _barra
        End Get
        Set(ByVal Value)
            _barra = Value
        End Set
    End Property
    Public Property manual()
        Get
            manual = _manual
        End Get
        Set(ByVal value)
            _manual = value
        End Set
    End Property
    Public Property acrescimo()
        Get
            acrescimo = _acrescimo
        End Get
        Set(ByVal value)
            _acrescimo = value
        End Set
    End Property

    Public Property diasprotesto()
        Get
            diasprotesto = _diasprotesto
        End Get
        Set(value)
            _diasprotesto = value
        End Set
    End Property

    Public Property acaocobranca
        Get
            acaocobranca = _acaocobranca
        End Get
        Set(value)
            _acaocobranca = value
        End Set
    End Property

    Public Property usuario_inc
        Get
            usuario_inc = _usuario_inc
        End Get
        Set(value)
            _usuario_inc = value
        End Set
    End Property

    Public Property usuario_alt
        Get
            usuario_alt = _usuario_alt
        End Get
        Set(value)
            _usuario_alt = value
        End Set
    End Property

    Public Property envio_boleto
        Get
            envio_boleto = _envio_boleto
        End Get
        Set(value)
            _envio_boleto = value
        End Set
    End Property
#End Region
#Region "Procedimentos"
    Public Sub New(ByVal tipo As tipo_pagamento)
        MyBase.New(tipo)
        tipo_pag = tipo
        sql = "Select * from boletos where numero = 0"
        Source(sql)
    End Sub
    Public Sub New()
        MyBase.New(tipo_pagamento.credito)
        sql = "Select * from boleto where numero = 0"
        Source(sql)
    End Sub
    Public Sub filtra(ByVal id_filial As Integer, ByVal codLancamento As Integer)
        sql = "Select * from boleto where cod_lancamento = " & codLancamento & _
        " and id_filial = " & id_filial & ""
        MyBase.filtrar(codLancamento, id_filial)
        Source(sql)
    End Sub

    Public Overloads Sub Source(ByVal iSql As String)
        sql = iSql
        Me.refreshData()
        primeiro()
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
            _banco = tabela.Rows(p)("banco")
            _numero = tabela.Rows(p)("numero")
            _documento = tabela.Rows(p)("documento")
            _tipo_documento = tabela.Rows(p)("tipo_documento")
            _emitente = tabela.Rows(p)("emitente")
            _nossonumero = tabela.Rows(p)("nossonumero")
            _barra = tabela.Rows(p)("barra")
            _digitavel = tabela.Rows(p)("digitavel")
            _manual = tabela.Rows(p)("manual")
            _acrescimo = rdNum(tabela.Rows(p)("acrescimo"))
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
    Public Sub editar_boleto()
        OrigemSalvar = "Editar"
        MyBase.editar()
    End Sub
#End Region
#Region "Funções"
    Public Sub novo_boleto()
        lastPos = posicao 'guarda a posição do último Registro
        'Zera Variáveis
        MyBase.novo_lancamento()
        _cod_lancamento = Nothing
        _id_filial = Nothing
        _banco = Nothing
        _numero = Nothing
        _documento = Nothing
        _tipo_documento = Nothing
        _emitente = Nothing
        _nossonumero = Nothing
        _barra = Nothing
        _digitavel = Nothing
        _manual = False
        _acrescimo = Nothing
        _diasprotesto = Nothing
        OrigemSalvar = "Novo" 'Define o tipo de ação ao salvar
    End Sub
    Public Function Salvar_boleto() As String
        Dim sql As String
        Dim r1, res As String
        d.conecta()
        If OrigemSalvar = "Novo" Then
            Try
                r1 = MyBase.salva_pag(tiposalvar.Transaction)
                _numero = retorna_Chave("numero", "boleto", " where id_filial = " & MyBase.id_filial & "")
                _bol_juros = ((2.5 / 100) * MyBase.valor) / 30
                sql = "INSERT INTO boleto (Numero,cod_lancamento,id_filial " & _
                ",Documento,Banco,Emitente " & _
                ",Nossonumero,Barra,Digitavel,tipo_documento,bol_juros,manual,acrescimo,diasprotesto,acaocobranca,usuario_inc,usuario_alt, enviado) " & _
                "VALUES " & _
                "(" & _numero & "," & MyBase.cod_lancamento & _
                "," & MyBase.id_filial & _
                "," & _documento & _
                "," & _banco & _
                "," & _emitente & _
                "," & d.PStr(_nossonumero) & _
                "," & d.PStr(_barra) & _
                "," & d.PStr(_digitavel) & _
                "," & d.PStr(_tipo_documento) & _
                "," & d.cdin(_bol_juros) & _
                "," & d.PStr(_manual.ToString) & _
                "," & d.cdin(_acrescimo) & _
                "," & _diasprotesto & _
                "," & d.PStr(_acaocobranca) & _
                "," & _usuario_inc & _
                "," & _usuario_alt & _
                "," & d.PStr(_envio_boleto) & ")"

                res = d.Comando(sql, True)

            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tabela.NewRow
            ''r("cod_lancamento") = _cod_lancamento
            ''r("id_filial") = _id_filial
            'r("banco") = _banco
            ''r("numero") = _numero
            ''r("cod_cliente") = _cod_cliente
            ''r("id_filial_cliente") = _id_filial_cliente
            ''r("documento") = _documento
            ''r("tipo_documento") = rdTexto(_tipo_documento)
            ' r("emitente") = _emitente
            ''r("nossonumero") = rdTexto(_nossonumero)
            ''r("barra") = rdTexto(_barra)
            ''r("digitavel") = rdTexto(_digitavel)
            ''tabela.Rows.Add(r)
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
                Salvar()
                sql = "UPDATE boleto set Documento =" & _documento & _
               ",Banco = " & _banco & ", Emitente = " & _emitente & _
                ",Nossonumero = " & d.PStr(_nossonumero) & _
                ",Barra = " & d.PStr(_barra) & _
                ",Digitavel = " & d.PStr(_digitavel) & _
                ",tipo_documento = " & d.PStr(_tipo_documento) & _
                ",acrescimo = " & d.cdin(_acrescimo) & _
                ",usuario_alt = " & _usuario_alt & _
                " WHERE numero = " & _numero & " and id_filial = " & _
                _id_filial & ""
                'res = d.Comando(sql, True)
                res = sql
                trans.insere_instrucao(sql)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            'r = tabela.Rows(posicao)
            'r("cod_lancamento") = _cod_lancamento
            'r("id_filial") = _id_filial
            'r("banco") = _banco
            'r("numero") = _numero
            'r("documento") = _documento
            'r("tipo_documento") = rdTexto(_tipo_documento)
            'r("emitente") = _emitente
            'r("nossonumero") = rdTexto(_nossonumero)
            'r("barra") = rdTexto(_barra)
            'r("digitavel") = rdTexto(_digitavel)
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
    Public Function listar_boletos_fatura(ByVal x_n_fatura As Int64, ByVal x_id_filial As Int16) As DataTable
        Dim tsql As String
        Dim tret As New DataTable
        tsql = "Select E.RazaoSocial,  " & _
            "B.CodigoBanco, B.DvBanco, B.CodigoAgencia, B.DvAgencia,  " & _
            "B.ContaCorrente, B.DvConta, B.Carteira, B.Cedente, B.DvCedente,  " & _
            "B.Convenio, B.MensagemPagamento1, B.MensagemPagamento2,  " & _
            "B.MensagemBoleto,  " & _
            "C.razao_social  as Nome, C.Endereco, C.Numero, C.Complemento, C.Bairro,  " & _
            "C.Cep, C.codigo_cidade  as Cod_Cidade, C.ie as T_Inscricao, C.cnpj as CNPj_CPF,  " & _
            "Cid.Cidade, Cid.UF,  " & _
            "T.Tipo_Documento, T.documento as N_Documento,L.n_parcela as Desdobramento,  " & _
            "L.data_lancamento As Emissao,  " & _
            "L.data_vencimento as Vencimento, L.Valor, T.NossoNumero, T.Barra, T.Digitavel, " & _
            "T.Bol_Juros as Juros  " & _
            "From boleto as T  " & _
            "left join lancamentos as L on T.cod_lancamento = L.cod_lancamento  " & _
            "and T.id_filial = L.id_filial  " & _
            "Left Join almoxarifado  as E on E.id_filial = T.Emitente  " & _
            "Left Join conta_Banco as B on B.Banco=T.Banco  " & _
            "left join lancamentos_cliente as LC on LC.id_filial = L.id_filial " & _
            " and LC.cod_lancamento = L.cod_lancamento " & _
            "Left Join Cliente as C on C.cod_cliente = LC.cod_Cliente  " & _
            " and C.cod_filial_cliente = LC.cod_filial_cliente " & _
            "Left Join Cidades as Cid on C.codigo_cidade =Cid.Codigo  " & _
            "where t.documento = " & x_n_fatura & _
            " and t.id_filial = " & x_id_filial & _
            " and t.manual = 'False' " & _
            " and L.cod_status_lancamento <> 2 " & _
            " Order by L.n_parcela "
        d.carrega_Tabela(tsql, tret)
        Return tret
    End Function
    Public Function listar_boletos_remessa(ByVal data As Date) As DataTable
        Dim tsql As String
        Dim tret As New DataTable
        tsql = "SELECT boleto.tipo_documento, boleto.Documento, boleto.Bol_juros, " & _
        " boleto.numero,boleto.nossonumero, lancamentos.n_parcela as parcela," & _
        "lancamentos.data_lancamento, lancamentos.data_vencimento, lancamentos.Valor, " & _
        " cliente.cod_filial_cliente, cliente.cod_cliente " & _
        " FROM boleto INNER JOIN lancamentos ON boleto.cod_lancamento = " & _
        " lancamentos.cod_lancamento AND boleto.id_filial = lancamentos.id_filial INNER JOIN " & _
        " lancamentos_cliente ON lancamentos.cod_lancamento = lancamentos_cliente.cod_lancamento " & _
        " AND lancamentos.id_filial = lancamentos_cliente.id_filial INNER JOIN " & _
        " cliente ON lancamentos_cliente.cod_filial_cliente = cliente.cod_filial_cliente " & _
        " and lancamentos_cliente.cod_cliente = cliente.cod_cliente " & _
        " where lancamentos.data_lancamento >= " & d.pdtm(data.ToShortDateString & " 00:00:00") & _
        " and lancamentos.data_lancamento  <= " & d.pdtm(data.ToShortDateString & " 23:59:59") & _
        " Order by lancamentos.n_parcela "
        d.carrega_Tabela(tsql, tret)
        Return tret
    End Function
#End Region
End Class
