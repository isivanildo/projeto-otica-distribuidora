Imports System.Windows.Forms
Imports System.Collections.Generic
Public Class objPedidoBalcao
#Region "Atributos"
    Private _num_pedido As Integer
    Private _id_filial As Integer
    Private _cod_vendedor As Integer
    Private _cod_vendedor_externo As Integer
    Private _data_pedido As Object
    Private _cod_cliente As Integer
    Private _cod_filial_cliente As Integer
    Private _cod_status_pedido As Integer
    Private _cod_status_servico As Integer
    Private _cod_autorizacao As Integer
    Private _filial_autorizacao As Integer
    'Private _autorizacao As objAutorizacao = Nothing
    Private _autorizacao As Integer
    Private _cod_tipo_pedido As Integer = 1
    Private _valor_pago As Double
    Private _forma_pagamento As Integer
    Public restricao As Boolean = False
    Public posicao As Integer = 0
    Public max As Integer
    Public Criterio_num_pedido, Criterio_id_filial As Object
    Public tb As New DataTable
    Public OrigemSalvar As String = ""
    Private lastPos As Integer = 0
    Private sql As String
    Dim conf As config
    Dim d As dados
    Dim tPacDesc As DataTable
    Dim master As New objMaster
#End Region
#Region "GET SET"
    Public Property num_pedido()
        Get
            num_pedido = _num_pedido
        End Get
        Set(ByVal Value)
            _num_pedido = Value
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
    Public Property cod_vendedor()
        Get
            cod_vendedor = _cod_vendedor
        End Get
        Set(ByVal Value)
            _cod_vendedor = Value
        End Set
    End Property
    Public Property cod_vendedor_externo()
        Get
            cod_vendedor_externo = _cod_vendedor_externo
        End Get
        Set(ByVal value)
            _cod_vendedor_externo = value
        End Set
    End Property
    Public Property data_pedido()
        Get
            data_pedido = _data_pedido
        End Get
        Set(ByVal Value)
            _data_pedido = Value
        End Set
    End Property
    Public Property cod_cliente()
        Get
            cod_cliente = _cod_cliente
        End Get
        Set(ByVal Value)
            _cod_cliente = Value
        End Set
    End Property
    Public Property cod_filial_cliente()
        Get
            cod_filial_cliente = _cod_filial_cliente
        End Get
        Set(ByVal Value)
            _cod_filial_cliente = Value
        End Set
    End Property
    Public Property cod_status_pedido()
        Get
            cod_status_pedido = _cod_status_pedido
        End Get
        Set(ByVal Value)
            _cod_status_pedido = Value
        End Set
    End Property
    Public Property cod_status_servico()
        Get
            cod_status_servico = _cod_status_servico
        End Get
        Set(ByVal Value)
            _cod_status_servico = Value
        End Set
    End Property
    Public Property autorizacao()
        Get
            autorizacao = _autorizacao
        End Get
        Set(ByVal value)
            _autorizacao = value
        End Set
    End Property
    Public Property cod_tipo_pedido
        Get
            cod_tipo_pedido = _cod_tipo_pedido
        End Get
        Set(ByVal value)
            _cod_tipo_pedido = value
        End Set
    End Property

    Public Property valor_pago
        Get
            valor_pago = _valor_pago
        End Get
        Set(value)
            _valor_pago = value
        End Set
    End Property

    Public Property forma_pagamento
        Get
            forma_pagamento = _forma_pagamento
        End Get
        Set(value)
            _forma_pagamento = value
        End Set
    End Property


#End Region
#Region "Procedimentos"
    Public Sub New()
        d = New dados
        conf = New config
        Dim sql As String
        sql = "select * from pedido_balcao " &
        "where num_pedido = 0"
        Source(sql)
    End Sub
    Public Sub New(ByVal xdados As dados)
        d = xdados
        Dim sql As String
        sql = "select * from pedido_balcao " &
        "where num_pedido = 0"
        Source(sql)
    End Sub
    Public Sub carrega_pedido(ByVal x_num_pedido As Integer, ByVal x_id_filial As Integer)
        Dim sql As String
        sql = "Select * from pedido_balcao where num_pedido = " & x_num_pedido &
                " and id_filial = " & x_id_filial & ""
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
            With tb
                _num_pedido = .Rows(pos)("num_pedido")
                _id_filial = .Rows(pos)("id_filial")
                _cod_vendedor = .Rows(pos)("cod_vendedor")
                _data_pedido = .Rows(pos)("data_pedido")
                _cod_cliente = .Rows(pos)("cod_cliente")
                _cod_filial_cliente = .Rows(pos)("cod_filial_cliente")
                _cod_status_pedido = .Rows(pos)("cod_status_pedido")
                _cod_autorizacao = rdNum(.Rows(pos)("cod_autorizacao"))
                _filial_autorizacao = rdNum(.Rows(pos)("filial_autorizacao"))
                _cod_tipo_pedido = rdNum(.Rows(pos)("cod_tipo_pedido"))
                _valor_pago = .Rows(pos)("valor_pago")
                _cod_vendedor_externo = .Rows(pos)("cod_vendedor_ext")
                If Not .Rows(pos)("forma") Is DBNull.Value Then
                    _forma_pagamento = .Rows(pos)("forma")
                End If
            End With
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
    Public Function existe(ByVal n_pedido As Integer, ByVal fililal As Integer) As Boolean
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "select * from pedido_balcao " &
        "where num_pedido = " & n_pedido &
        " and id_filial = " & fililal
        d.carrega_Tabela(tsql, tt)
        If tt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function novo()
        lastPos = posicao 'guarda a posição do último Registro
        'Inicializa Variáveis
        _num_pedido = Nothing
        _id_filial = Nothing
        _cod_vendedor = Nothing
        _data_pedido = Nothing
        _cod_cliente = Nothing
        _cod_filial_cliente = Nothing
        _cod_status_pedido = 1
        _cod_tipo_pedido = 1
        OrigemSalvar = "Novo" 'Define o tipo de ação ao salvar
    End Function
    Public Function n_pedido() As Integer
        Dim tsql As String
        Dim tt As New DataTable
        Dim n As Integer = 0
        Dim res As String
inicio:
        tsql = "Select * from num_pedido where id_filial = " & _id_filial & " "
        d.carrega_Tabela(tsql, tt)

        If tt.Rows.Count > 0 Then
            If tt.Rows(0)("lock") = 1 Then
                GoTo inicio
            Else
                Try
                    If d.Comando("Update num_pedido set lock = 1 where id_filial = " & _id_filial, False).StartsWith("OK") Then
                        n = tt.Rows(0)("num_pedido") + 1
                        res = d.Comando("Update num_pedido set num_pedido = " & n & ", lock = 0 where id_filial = " & _id_filial, False)
                        If res.StartsWith("OK") Then
                            Return n
                        End If
                    End If
                Catch ex As Exception
                    GoTo inicio
                End Try
            End If
        End If
    End Function
    Public Function Salvar() As String
        Dim sql As String
        Dim res As String
        d.conecta()
        If OrigemSalvar = "Novo" Then
            Try
                If _num_pedido = 0 Or num_pedido = Nothing Then
                    _num_pedido = n_pedido()
                End If
                sql = "INSERT INTO pedido_balcao " &
                "(num_pedido,id_filial,cod_vendedor,data_pedido,cod_cliente," &
                "cod_filial_cliente," &
                " cod_status_pedido,cod_autorizacao,filial_autorizacao,cod_tipo_pedido,valor_pago,valor_apagar,cod_vendedor_ext,forma) VALUES ( " &
                _num_pedido & "," & _id_filial & "," & cod_vendedor &
                "," & d.pdtm(data_pedido) & "," & _cod_cliente & "," &
                _cod_filial_cliente & "," & _cod_status_pedido &
                "," & _cod_autorizacao & "," & _filial_autorizacao &
                "," & _cod_tipo_pedido &
                "," & "0" &
                "," & "0" &
                "," & _cod_vendedor_externo &
                "," & _forma_pagamento & ")"
                res = d.Comando(sql, True)
                If res.Substring(0, 3) = "ER:" Then
                    Return "ER:" & res.Substring(3) & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
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
            r("num_pedido") = _num_pedido
            r("id_filial") = _id_filial
            r("cod_vendedor") = _cod_vendedor
            r("data_pedido") = rdData(_data_pedido)
            r("cod_cliente") = _cod_cliente
            r("cod_filial_cliente") = _cod_filial_cliente
            r("cod_status_pedido") = _cod_status_pedido
            r("cod_tipo_pedido") = _cod_tipo_pedido
            r("valor_pago") = _valor_pago
            r("cod_vendedor_ext") = _cod_vendedor_externo
            r("forma") = _forma_pagamento

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
                sql = "update pedido_balcao " &
                " set num_pedido = " & _num_pedido &
                ",id_filial = " & _id_filial &
                ",cod_vendedor = " & _cod_vendedor &
                ",data_pedido = " & d.pdtm(_data_pedido) &
                ",cod_cliente = " & _cod_cliente &
                ",cod_filial_cliente = " & _cod_filial_cliente &
                ", cod_status_pedido = " & _cod_status_pedido &
                ", cod_tipo_pedido = " & _cod_tipo_pedido &
                " Where num_pedido = " & Me._num_pedido &
                " and id_filial = " & Me._id_filial & ""
                res = d.Comando(sql, True)
                If res.Substring(0, 3) = "ER:" Then
                    Return "ER:" & res.Substring(3) & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                    Registro(lastPos)
                    Exit Function
                End If
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            Try
                r = tb.Rows(posicao)
                r("num_pedido") = _num_pedido
                r("id_filial") = _id_filial
                r("cod_vendedor") = _cod_vendedor
                r("data_pedido") = rdData(_data_pedido)
                r("cod_cliente") = _cod_cliente
                r("cod_filial_cliente") = _cod_filial_cliente
                r("cod_status_pedido") = _cod_status_pedido
                r("cod_tipo_pedido") = _cod_tipo_pedido
                r("valor_pago") = _valor_pago
                r("cod_vendedor_ext") = _cod_vendedor_externo
                r("forma") = _forma_pagamento
            Catch ex As Exception

            End Try

            OrigemSalvar = ""
            Return res & " registro(s) atualizado(s) com sucesso!"
        End If
    End Function
    Public Function deletar(ByVal id_mov As Integer, ByVal id_fil As Integer)
        Dim cmd As New SqlClient.SqlCommand
        Dim res As String
        d.conecta()
        cmd.Connection = d.con
        cmd.CommandText = "Delete from pedido_balcao where num_pedido = " & Criterio_num_pedido &
        " and id_filial = " & Criterio_id_filial & ""
        Try
            res = d.Comando(sql, True)
        Catch ex As Exception

        End Try
        Me.refreshData()
        Me.primeiro()
        Return res & " Registros foram apagados!"
    End Function
    Public Function insere_item(ByVal xnum_pedido As Integer, ByVal xid_filial As Integer, ByVal xcod_produto As Integer, ByVal xquant As Integer,
                                ByVal xdesconto As Double, ByVal xpreco As Double, ByVal x_status_item As Integer)
        Dim sql_item As String
        Dim xitem As Integer
        Dim atendido As Integer = 0
        Dim res As String = ""
        Dim p As New produtoClass
        Dim qFinal As Integer = 0
        'monta_tab_pacote()



        If pacote_desconto(p.Retorna_cod_Tabela(xcod_produto), xquant) = True Then
            Dim strSQL As String = "select * from pacote_cliente where cod_pacote = " & tPacDesc.Rows(0)("cod_pac") & " and concluido = 'S'"
            'Verifica se o pacote já está faturado, em caso negativo o produto não é inserido no pedido //* Ivanildo 24/09/2013
            If master.verifica_existencia_registro(strSQL) = False Then
                MessageBox.Show("Produto pertencente a pacote não faturado. Por favor faturar" & Chr(13) & "primeiro o pacote, para dar prosseguimento a venda.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Function
            End If

            Dim i, m As Integer
            i = 0
            m = tPacDesc.Rows.Count
            While i < m
                xitem = item(xnum_pedido, xid_filial)
                sql_item = "Insert into pedido_balcao_itens (num_pedido," &
                       "id_filial,item,cod_produto,quant,compra,desconto,preco,cod_status_item,pacote,cod_pacote) " &
                       "values(" & xnum_pedido & "," & xid_filial & "," & xitem & "," &
                       xcod_produto & "," & tPacDesc.Rows(i)("quant") & "," & d.cdin(p.compra_tabela_c_desconto(xcod_produto)) &
                       "," & d.cdin(tPacDesc.Rows(i)("desc")) & "," &
                       d.cdin(xpreco) & "," & x_status_item &
                       ",'S'," & tPacDesc.Rows(i)("cod_pac") & ")"

                res = res & vbTab & d.Comando(sql_item, True) & " - " & xitem
                atendido = atendido + tPacDesc.Rows(i)("quant")
                i = i + 1
            End While
            If atendido < xquant Then GoTo insere_normal
            Return res
            Exit Function
        Else
insere_normal:

            xitem = item(xnum_pedido, xid_filial)
            sql_item = "Insert into pedido_balcao_itens (num_pedido," &
            "id_filial,item,cod_produto,quant,compra,desconto,preco,cod_status_item) " &
            "values(" & xnum_pedido & "," & xid_filial & "," & xitem & "," &
            xcod_produto & "," & (xquant - atendido) & "," & d.cdin(p.compra_tabela_c_desconto(xcod_produto)) &
            "," & d.cdin(xdesconto) & "," &
            d.cdin(xpreco) & "," & x_status_item & ")"
            res = res & vbCrLf & d.Comando(sql_item, True) & " - " & xitem
            Return res
        End If
    End Function
    Public Function insere_item_dev(ByVal xcod_produto As Integer, ByVal xquant As Integer,
    ByVal xdesconto As Double, ByVal xpreco As Double, ByVal xPacote As Integer, ByVal XdesCaixa As Double)
        Dim sql_item As String
        Dim xitem As Integer
        Dim res As String = ""
        Dim p As New produtoClass
        Dim qFinal As Integer = 0
        Dim pac As String = "N"
        If xPacote > 0 Then
            pac = "S"
            xitem = item(_num_pedido, _id_filial)
            sql_item = "Insert into pedido_balcao_itens (num_pedido," &
                   "id_filial,item,cod_produto,quant,compra,desconto," &
                   "preco,cod_status_item,pacote,cod_pacote) " &
                   "values(" & _num_pedido & "," & _id_filial & "," & xitem & "," &
                   xcod_produto & "," & xquant & "," &
                   d.cdin(p.compra_tabela_c_desconto(xcod_produto)) &
                   "," & d.cdin(xdesconto) & "," &
                   d.cdin(xpreco) & ",1," &
                   d.PStr(pac) & "," & d.cdin(xPacote) & ")"
        Else
            xitem = item(_num_pedido, _id_filial)
            sql_item = "Insert into pedido_balcao_itens (num_pedido," &
                   "id_filial,item,cod_produto,quant,compra,desconto," &
                   "preco,cod_status_item,pacote) " &
                   "values(" & _num_pedido & "," & _id_filial & "," & xitem & "," &
                   xcod_produto & "," & xquant & "," &
                   d.cdin(p.compra_tabela_c_desconto(xcod_produto)) &
                   "," & d.cdin(xdesconto) & "," &
                   d.cdin(xpreco) & ",1," &
                   d.PStr(pac) & ")"
        End If

        res = d.Comando(sql_item, True)
        Return res
        Exit Function
    End Function
    Private Sub monta_tab_pacote()
        Try
            tPacDesc.Dispose()
        Catch ex As Exception

        End Try

        tPacDesc = New DataTable
        tPacDesc.Columns.Add("desc")
        tPacDesc.Columns.Add("quant")
        tPacDesc.Columns.Add("cod_pac")
    End Sub
    Private Function pacote_desconto(ByVal xTabela As Integer, ByVal xReq As Integer) As Boolean
        Dim pacote As New objPacoteClienteDetalhes(Me._cod_filial_cliente, Me._cod_cliente)
        Dim tt As New DataTable
        Dim saldo As Double
        Dim r As DataRow
        tt = pacote.lista_itens_com_saldo(xTabela)
        If tt.Rows.Count = 0 Then
            Return False
        End If
        If tt.Rows.Count = 1 Then
            saldo = tt.Rows(0)("saldo")
            If xReq <= saldo Then
                r = tPacDesc.NewRow
                r("desc") = tt.Rows(0)("desconto")
                r("quant") = xReq
                r("cod_pac") = tt.Rows(0)("cod_pacote")
                tPacDesc.Rows.Add(r)
            Else
                r = tPacDesc.NewRow
                r("desc") = tt.Rows(0)("desconto")
                r("quant") = saldo
                r("cod_pac") = tt.Rows(0)("cod_pacote")
                tPacDesc.Rows.Add(r)
            End If
            Return True
        Else
            Dim linha, linhas As Integer
            Dim falta As Integer = xReq
            linhas = tt.Rows.Count
            linha = 0
            While linha < linhas
                saldo = tt.Rows(linha)("saldo")
                If falta <= saldo Then
                    r = tPacDesc.NewRow
                    r("desc") = tt.Rows(linha)("desconto")
                    r("quant") = falta
                    r("cod_pac") = tt.Rows(linha)("cod_pacote")
                    tPacDesc.Rows.Add(r)
                    Return True
                    Exit Function
                Else
                    r = tPacDesc.NewRow
                    r("desc") = tt.Rows(linha)("desconto")
                    r("quant") = saldo
                    r("cod_pac") = tt.Rows(linha)("cod_pacote")
                    tPacDesc.Rows.Add(r)
                    falta = falta - saldo
                End If
                linha = linha + 1
            End While
            Return True
        End If
    End Function
    Public Function deleta_item(ByVal xnum_pedido As Integer, ByVal xid_filial As Integer, ByVal xitem As Integer)
        Dim sql_item As String
        Dim ret As String
        If retorna_status_item(xitem) = status_item_pedido.baixado_estoque Then
            Return "Produto Já baixado do Estoque, não pode ser excluído!"
        End If
        Cancelareserva(retorna_cod_item(xitem), retorna_quant_item(xitem))
        sql_item = "delete from pedido_balcao_itens where " &
        " num_pedido = " & xnum_pedido & " and id_filial = " & xid_filial &
        " and  item = " & xitem & ""
        ret = d.Comando(sql_item, True) & " - " & xitem
        Return ret
    End Function
    Public Function cancela_item(ByVal xnum_pedido As Integer, ByVal xid_filial As Integer, ByVal xitem As Integer) As String
        Dim sql As String
        sql = "Update pedido_balcao_itens set cod_status_item = 4,preco=0,desconto = 0 where " &
        " num_pedido = " & xnum_pedido & " and id_filial = " & xid_filial &
        " and item = " & xitem & ""
        Return d.Comando(sql, True)
    End Function
    Public Function devolve_item_status(ByVal xnum_pedido As Integer, ByVal xid_filial As Integer, ByVal xitem As Integer, ByVal status As Integer) As String
        Dim sql As String
        sql = "Update pedido_balcao_itens set cod_status_item = " & status & " where " &
        " num_pedido = " & xnum_pedido & " and id_filial = " & xid_filial &
        " and item = " & xitem & ""
        Return d.Comando(sql, True)
    End Function
    Public Function altera_status_item(ByVal xitem As Integer, ByVal status As Integer) As String
        Dim sql As String
        sql = "Update pedido_balcao_itens set cod_status_item = " & status & " where " &
        " num_pedido = " & _num_pedido & " and id_filial = " & _id_filial &
        " and item = " & xitem & ""
        Return d.Comando(sql, True)
    End Function
    Public Function altera_preco_item(ByVal xitem As Integer, ByVal preco As Double, ByVal desconto As Double) As String
        Dim sql As String
        sql = "Update pedido_balcao_itens set preco = " & d.cdin(preco - (preco * desconto / 100)) & ", preco_tab = " & d.cdin(preco) &
            ", desconto = " & d.cdin(desconto) &
            " where num_pedido = " & _num_pedido & " and id_filial = " & _id_filial & " and item = " & xitem & ""
        Return d.Comando(sql, True)
    End Function

    Public Function altera_preco_servico(ByVal xitem As Integer, ByVal preco As Double, ByVal desconto As Double) As String
        Dim sql As String
        sql = "Update pedido_balcao_servicos set preco = " & d.cdin(preco - (preco * desconto / 100)) & ", preco_tab = " & d.cdin(preco) &
            ", desconto = " & d.cdin(desconto) &
            " where num_pedido = " & _num_pedido & " and id_filial = " & _id_filial & " and item_servico = " & xitem & ""
        Return d.Comando(sql, True)
    End Function
    Public Function zera_valor_devolvidos() As String
        Dim sql As String
        sql = "Update pedido_balcao_itens set preco =0, desconto = 0  where " &
        " num_pedido = " & _num_pedido & " and id_filial = " & _id_filial &
        " and (cod_status_item = 5)"
        Return d.Comando(sql, True)
    End Function
    Public Function Devolucao_itens() As String
        Dim sql As String
        sql = "Update pedido_balcao_itens set cod_status_item = 5,preco=0,desconto = 0 where " &
        " num_pedido = " & _num_pedido & " and id_filial = " & _id_filial & ""
        Return d.Comando(sql, True)
    End Function
    Public Function cancelamento_itens() As String
        Dim sql As String
        sql = "Update pedido_balcao_itens set cod_status_item = 4,preco=0,desconto = 0 where " &
        " num_pedido = " & _num_pedido & " and id_filial = " & _id_filial & ""
        Return d.Comando(sql, True)
    End Function
    Public Function limpa_servicos() As String
        Dim sql As String
        sql = "Delete from pedido_balcao_servicos where num_pedido = " & _num_pedido &
        " and id_filial = " & _id_filial & ""
        Return d.Comando(sql, True)
    End Function
    Public Function cancela_servicos() As String
        Dim sql As String
        sql = "Update pedido_balcao_servicos set cod_status_servico = 2,preco=0,desconto = 0 where " &
        " num_pedido = " & _num_pedido & " and id_filial = " & _id_filial & ""
        Return d.Comando(sql, True)
    End Function
    Public Function item(ByVal xnum_pedido As Integer, ByVal xid_filial As Integer)
        Dim tb As New DataTable
        Dim v As Integer
        sql = "Select max(item) as chave from pedido_balcao_itens where num_pedido = " &
        xnum_pedido & " and id_filial = " & xid_filial & ""
        d.carrega_Tabela(sql, tb)
        If IsDBNull(tb.Rows(0)("chave")) = True Then v = 1 Else v = tb.Rows(0)("chave") + 1
        Return v
        tb.Dispose()
    End Function
    Public Function ultimo_item()
        Dim tb As New DataTable
        Dim v As Integer
        sql = "Select max(item) as chave from pedido_balcao_itens where num_pedido = " &
        _num_pedido & " and id_filial = " & _id_filial & ""
        d.carrega_Tabela(sql, tb)
        If IsDBNull(tb.Rows(0)("chave")) = True Then v = 0 Else v = tb.Rows(0)("chave")
        Return v
        tb.Dispose()
    End Function
    Public Function retorna_cod_item(ByVal item As Integer) As Integer
        Dim sql_item As String
        Dim tt As New DataTable
        sql_item = "select cod_produto from pedido_balcao_itens where " &
        " num_pedido = " & _num_pedido & " and id_filial = " & _id_filial &
        " and  item = " & item & ""
        d.carrega_Tabela(sql_item, tt)
        If tt.Rows.Count > 0 Then
            Return tt.Rows(0)("cod_produto")
        Else
            Return 0
        End If
    End Function
    Public Function retorna_status_item(ByVal item As Integer) As Integer
        Dim sql_item As String
        Dim tt As New DataTable
        sql_item = "select cod_status_item from pedido_balcao_itens where " &
        " num_pedido = " & _num_pedido & " and id_filial = " & _id_filial &
        " and  item = " & item & ""
        d.carrega_Tabela(sql_item, tt)
        If tt.Rows.Count > 0 Then
            Return tt.Rows(0)("cod_status_item")
        Else
            Return 0
        End If
    End Function
    Public Function retorna_quant_item(ByVal item As Integer) As Integer
        Dim sql_item As String
        Dim tt As New DataTable
        sql_item = "select quant from pedido_balcao_itens where " &
        " num_pedido = " & _num_pedido & " and id_filial = " & _id_filial &
        " and  item = " & item & ""
        d.carrega_Tabela(sql_item, tt)
        If tt.Rows.Count > 0 Then
            Return tt.Rows(0)("quant")
        Else
            Return 0
        End If
    End Function
    Public Function insere_servico(ByVal xnum_pedido, ByVal xid_filial, ByVal xcod_produto, ByVal xquant, ByVal xdesconto, ByVal xpreco, ByVal xstatus, ByVal xcodpac, ByVal xPacote, ByVal xprecotab)
        Dim sql_item As String
        Dim xitem As Integer
        Dim p As New produtoClass
        Dim ePacote As String = "N"
        If xPacote <> Nothing Then
            ePacote = "S"
        End If
        xitem = item_servico(xnum_pedido, xid_filial)
        If ePacote = "S" Then
            sql_item = "Insert into pedido_balcao_servicos (num_pedido," &
                    "id_filial,item_servico,cod_servico,quant,desconto,preco,compra,cod_status_servico,cod_pacote " &
                    ",pacote,preco_tab) " &
                    "values(" & xnum_pedido & "," & xid_filial & "," & xitem & "," &
                    xcod_produto & "," & xquant & "," & d.cdin(xdesconto) & "," &
                    d.cdin(xpreco) & "," & d.cdin(p.compra_servico(xcod_produto)) &
                    "," & xstatus & "," & xcodpac & "," & d.PStr(ePacote) & "," & d.cdin(xprecotab) & ")"
        Else
            sql_item = "Insert into pedido_balcao_servicos (num_pedido," &
                    "id_filial,item_servico,cod_servico,quant,desconto,preco,compra, " &
                    "cod_status_servico,pacote, preco_tab) " &
                    "values(" & xnum_pedido & "," & xid_filial & "," & xitem & "," &
                    xcod_produto & "," & xquant & "," & d.cdin(xdesconto) & "," &
                    d.cdin(xpreco) & "," & d.cdin(p.compra_servico(xcod_produto)) &
                    "," & xstatus & "," & d.PStr(ePacote) & "," & d.cdin(xprecotab) & ")"
        End If

        Return d.Comando(sql_item, True)
    End Function
    Public Function deleta_servico(ByVal xnum_pedido, ByVal xid_filial, ByVal xitem)
        Dim sql_item As String
        sql_item = "delete from pedido_balcao_servicos " &
        "where num_pedido = " & xnum_pedido &
        " and id_filial = " & xid_filial &
        " and item_servico = " & xitem & ""
        Return d.Comando(sql_item, True)
    End Function
    Public Function item_servico(ByVal xnum_pedido As Integer, ByVal xid_filial As Integer)
        Dim tb As New DataTable
        Dim v As Integer
        sql = "Select max(item_servico) as chave from pedido_balcao_servicos where num_pedido = " &
        xnum_pedido & " and id_filial = " & xid_filial & ""
        d.carrega_Tabela(sql, tb)
        If IsDBNull(tb.Rows(0)("chave")) = True Then v = 1 Else v = tb.Rows(0)("chave") + 1
        Return v
        tb.Dispose()
    End Function
    Public Function lista_itens(ByVal x_num_pedido As Integer, ByVal x_id_filial As Integer, ByVal so_nao_baixados As Boolean) As DataTable
        Dim sql As String
        Dim tb_itens As New DataTable
        sql = "SELECT pedido_balcao_itens.item, produtos.produto,produtos.cod_produto," &
        "pedido_balcao_itens.quant, pedido_balcao_itens.cod_pacote," &
        "ISNULL((SELECT    sum(movimento.quant) FROM movimentomaster INNER JOIN " &
        "saida_pedido ON movimentomaster.cod_movimento = saida_pedido.cod_movimento AND " &
        "movimentomaster.id_filial = saida_pedido.id_filial RIGHT OUTER JOIN " &
        "movimento ON movimentomaster.cod_movimento = movimento.cod_Movimento AND " &
        "movimentomaster.id_filial = movimento.id_filial WHERE (saida_pedido.num_pedido = " &
        x_num_pedido & ") AND (saida_pedido.id_filial = " & x_id_filial & ") " &
        "and (movimento.cod_produto = produtos.cod_produto) group by movimento.cod_produto),0)*-1 as atendido " &
        ",pedido_balcao_itens.desconto, pedido_balcao_itens.preco, pedido_balcao_itens.preco_tab, " &
        "ISNULL(pedido_balcao_itens.preco * pedido_balcao_itens.quant,0) as total" &
        ",status_item_pedido.status_item,status_item_pedido.cod_status_item " &
        ",pedido_balcao_itens.cod_pacote FROM pedido_balcao_itens INNER JOIN " &
        "produtos ON pedido_balcao_itens.cod_produto = produtos.cod_produto INNER JOIN " &
        "status_item_pedido ON pedido_balcao_itens.cod_status_item = " &
        "status_item_pedido.cod_status_item where pedido_balcao_itens.num_pedido = " & x_num_pedido &
        " and pedido_balcao_itens.id_filial = " & x_id_filial & ""
        If so_nao_baixados = True Then
            sql = sql &
        " and (pedido_balcao_itens.quant > (ISNULL((SELECT    sum(movimento.quant) FROM movimentomaster INNER JOIN " &
        "saida_pedido ON movimentomaster.cod_movimento = saida_pedido.cod_movimento AND " &
        "movimentomaster.id_filial = saida_pedido.id_filial RIGHT OUTER JOIN " &
        "movimento ON movimentomaster.cod_movimento = movimento.cod_Movimento AND " &
        "movimentomaster.id_filial = movimento.id_filial WHERE (saida_pedido.num_pedido = " &
        x_num_pedido & ") AND (saida_pedido.id_filial = " & x_id_filial & ") " &
        "and (movimento.cod_produto = produtos.cod_produto) group by movimento.cod_produto),0)*-1))"
        End If
        sql = sql & " order by item"
        d.carrega_Tabela(sql, tb_itens)
        Return tb_itens
    End Function
    Public Function lista_servicos(ByVal x_num_pedido, ByVal x_id_filial) As DataTable
        Dim sql As String
        Dim tb_serv As New DataTable
        sql = "SELECT pedido_balcao_Servicos.item_servico, pedido_balcao_servicos.cod_servico,produtos.produto, pedido_balcao_servicos.quant, " &
        "pedido_balcao_servicos.desconto, pedido_balcao_servicos.preco, " &
        "(pedido_balcao_servicos.quant * pedido_balcao_servicos.preco) AS total, " &
        "pedido_balcao_servicos.cod_pacote, isnull(pedido_balcao_servicos.preco_tab,0) as preco_tab, status_servico_pedido.status_servico " &
        "FROM pedido_balcao_servicos INNER JOIN " &
        "produtos ON pedido_balcao_servicos.cod_servico = produtos.cod_produto " &
        "INNER JOIN status_servico_pedido on pedido_balcao_servicos.cod_status_servico = status_servico_pedido.cod_status_servico " &
        "WHERE  (pedido_balcao_servicos.num_pedido =" & x_num_pedido & ") AND " &
        "(pedido_balcao_servicos.id_filial = " & x_id_filial & ")" &
        " ORDER BY pedido_balcao_Servicos.item_servico"
        d.carrega_Tabela(sql, tb_serv)
        Return tb_serv
    End Function
    Public Function total_servicos(ByVal x_num_pedido, ByVal x_id_filial) As Double
        Dim sql As String
        Dim tb_serv As New DataTable
        sql = "SELECT  SUM(quant * preco) AS total " &
        "FROM pedido_balcao_servicos WHERE (num_pedido =" & x_num_pedido & ") AND" &
        " (id_filial =" & x_id_filial & ")"
        d.carrega_Tabela(sql, tb_serv)
        Return rdDinheiro(tb_serv.Rows(0)("total"))
    End Function
    Public Function total_servicos() As Double
        Dim sql As String
        Dim tb_serv As New DataTable
        sql = "SELECT  SUM(quant * preco) AS total " &
        "FROM pedido_balcao_servicos WHERE (num_pedido =" & Me._num_pedido & ") AND" &
        " (id_filial =" & Me._id_filial & ")"
        d.carrega_Tabela(sql, tb_serv)
        Return rdDinheiro(tb_serv.Rows(0)("total"))
    End Function
    'Ivanildo 07/06/2014
    Public Function total_serv_desc(ByVal x_num_pedido, ByVal x_id_filial) As Double
        Dim strSQL As String = ""
        Dim tb_serv As New DataTable
        strSQL = "select isnull((SUM(pedido_balcao_servicos.preco_tab  * pedido_balcao_servicos.quant) - " &
            "SUM(pedido_balcao_servicos.preco * pedido_balcao_servicos.quant)),0) as total " &
            "from pedido_balcao_servicos where pedido_balcao_servicos.num_pedido = " & x_num_pedido & " and pedido_balcao_servicos.id_filial = " & x_id_filial
        d.carrega_Tabela(strSQL, tb_serv)
        Return rdDinheiro(tb_serv.Rows(0)("total"))
    End Function

    Public Function total_prod_desc(ByVal x_num_pedido, ByVal x_id_filial) As Double
        Dim strSQL As String = ""
        Dim tb_prod As New DataTable
        strSQL = "select isnull((SUM(pedido_balcao_itens.preco_tab  * pedido_balcao_itens.quant) - " &
            "SUM(pedido_balcao_itens.preco * pedido_balcao_itens.quant)),0) as total " &
            "from pedido_balcao_itens where pedido_balcao_itens.num_pedido = " & x_num_pedido & " and pedido_balcao_itens.id_filial = " & x_id_filial
        d.carrega_Tabela(strSQL, tb_prod)
        Return rdDinheiro(tb_prod.Rows(0)("total"))
    End Function
    'Fim
    Public Function total_servicos_sem_desconto() As Double
        Dim sql As String
        Dim tb_serv As New DataTable
        sql = "SELECT  SUM(quant * preco) AS total " &
        "FROM pedido_balcao_servicos WHERE (num_pedido =" & Me._num_pedido & ") AND" &
        " (id_filial =" & Me._id_filial & ")"
        d.carrega_Tabela(sql, tb_serv)
        Return rdDinheiro(tb_serv.Rows(0)("total"))
    End Function
    Public Function total_itens(ByVal x_num_pedido, ByVal x_id_filial) As Double
        Dim sql As String
        Dim tb_itens As New DataTable
        sql = "SELECT  SUM(quant * preco) as total " &
        "FROM pedido_balcao_itens WHERE (num_pedido =" & x_num_pedido & ") AND" &
        " (id_filial =" & x_id_filial & ")"
        d.carrega_Tabela(sql, tb_itens)
        Return rdDinheiro(tb_itens.Rows(0)("total"))
    End Function
    Public Function valor_item(ByVal preco As Double, ByVal quant As Integer, ByVal desc As Double) As Double
        Return (preco - (preco * (desc / 100))) * quant
    End Function
    Public Function total_itens() As Double
        Dim sql As String
        Dim tb_itens As New DataTable
        sql = "SELECT  SUM(quant * preco) AS total " &
        "FROM pedido_balcao_itens WHERE (num_pedido =" & Me._num_pedido & ") AND" &
        " (id_filial =" & Me._id_filial & ")"
        d.carrega_Tabela(sql, tb_itens)
        Return rdDinheiro(tb_itens.Rows(0)("total"))
    End Function
    Public Function total_pedido() As Double
        Return total_servicos() + total_itens()
    End Function
    Public Function total_itens_sem_desconto() As Double
        Dim sql As String
        Dim tb_itens As New DataTable
        sql = "SELECT  SUM(quant * preco) AS total " &
        "FROM pedido_balcao_itens WHERE (num_pedido =" & Me._num_pedido & ") AND" &
        " (id_filial =" & Me._id_filial & ")"
        d.carrega_Tabela(sql, tb_itens)
        Return rdDinheiro(tb_itens.Rows(0)("total"))
    End Function
    Public Function diferenca_desconto() As Double
        Dim res As Double
        res = ((total_itens_sem_desconto() + total_servicos_sem_desconto()) - (total_itens() + total_servicos()))
        Return res
    End Function
    Public Function retorna_chave(ByVal filial As Integer) As Integer
        Dim sql As String
        Dim t As New DataTable
        sql = "Select num_pedido from pedido_balcao where id_filial = " & filial & " ORDER BY num_pedido DESC"
        d.carrega_Tabela(sql, t)
        If t.Rows.Count = 0 Then
            Return 1
        Else
            Return t.Rows(0)("num_pedido") + 1
        End If
    End Function
    Public Function retorna_id_reserva_pend(ByVal X_cod_prod As Integer)
        Dim sql As String
        Dim tb_res As New DataTable
        sql = "SELECT id_reserva " &
        "FROM reserva_lente_pedido " &
        "WHERE (id_filial = " & _id_filial & " )  " &
        "AND (num_pedido = " & _num_pedido & ") " &
        "AND (cod_produto = " & X_cod_prod & ") " &
        "AND (id_status_reserva = 0) " &
        "ORDER BY id_reserva"
        d.carrega_Tabela(sql, tb_res)
        If tb_res.Rows.Count > 0 Then
            Return tb_res.Rows(0)("id_reserva")
        Else
            Return 0
        End If
    End Function
    Public Function atualiza_status_pedido(ByVal status As Integer) As String
        Return d.Comando("Update pedido_balcao set cod_status_pedido = " & status &
        " where num_pedido = " & Me._num_pedido & " and id_filial = " & Me._id_filial & "", True)
    End Function
    Public Function Sugere_compra(ByVal cod_prod As Integer, ByVal quant As Integer)
        Dim sql As String
        'Faz uma Sugestão de Pedido Automático, para itens que não estão
        'disponíveis no estoque!
        sql = "INSERT INTO sugestao_pedido_auto_os " &
        "(cod_produto,data,cod_status,num_pedido,id_filial,quant) VALUES " &
        "(" & cod_prod &
        "," & d.pdtm(Now.ToString) &
        ",1," & Me.num_pedido & "," & Me.id_filial & "," & quant & ")"
        Return d.Comando(sql, False)
    End Function
    Public Function lista_pedidos_dia(ByVal dia As Date) As DataTable
        Dim sql As String
        Dim tt As New DataTable
        Dim di, df As String
        di = extrai_data_dmy(dia) & " 00:00:01"
        df = extrai_data_dmy(dia) & " 23:59:59"
        sql = "SELECT cliente.nome_cliente, pedido_balcao.num_pedido, pedido_balcao.cod_cliente, Usuarios.NOME, pedido_balcao.data_pedido, " &
        "status_pedido.Status_pedido, pedido_balcao.id_filial FROM pedido_balcao INNER JOIN " &
        "cliente ON pedido_balcao.cod_filial_cliente = cliente.COD_FILIAL_CLIENTE AND " &
        "pedido_balcao.cod_cliente = cliente.Cod_cliente INNER JOIN " &
        "Usuarios ON pedido_balcao.cod_vendedor = Usuarios.cod_usuario INNER JOIN " &
        "status_pedido ON pedido_balcao.cod_status_pedido = status_pedido.cod_status_pedido " &
        " where pedido_balcao.data_pedido >= " & d.pdtm(di) & " and pedido_balcao.data_pedido <=" &
        d.pdtm(df) & ""
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function lista_pedidos_dia_labo(ByVal dia As Date, ByVal filial As Integer) As DataTable
        Dim sql As String
        Dim tt As New DataTable
        Dim di, df As String
        di = extrai_data_dmy(dia) & " 00:00:01"
        df = extrai_data_dmy(dia) & " 23:59:59"
        sql = "SELECT cliente.nome_cliente, pedido_balcao.num_pedido, pedido_balcao.cod_cliente, Usuarios.NOME, pedido_balcao.data_pedido, " &
        "pedido_balcao.cod_status_pedido," &
        "status_pedido.Status_pedido, pedido_balcao.id_filial FROM pedido_balcao INNER JOIN " &
        "cliente ON pedido_balcao.cod_filial_cliente = cliente.COD_FILIAL_CLIENTE AND " &
        "pedido_balcao.cod_cliente = cliente.Cod_cliente INNER JOIN " &
        "Usuarios ON pedido_balcao.cod_vendedor = Usuarios.cod_usuario INNER JOIN " &
        "status_pedido ON pedido_balcao.cod_status_pedido = status_pedido.cod_status_pedido " &
        " where pedido_balcao.data_pedido >= " & d.pdtm(di) & " and pedido_balcao.data_pedido <=" &
        d.pdtm(df) & " and pedido_balcao.id_filial = " & conf.Filial & ""
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Private Function Cancelareserva(ByVal xcod_prod As Integer, ByVal quant As Integer) As String
        'Baixa a reserva da Lente no arquivo de reservas do pedido
        Dim sql As String
        Dim id_reserva As Integer
        Dim i As Integer = 0
        Dim ret As String
        While i < quant
            id_reserva = retorna_id_reserva_pend(xcod_prod)
            sql = "update reserva_lente_pedido set id_status_reserva = 2 where " &
            " id_reserva = " & id_reserva & " and id_filial = " & _id_filial &
            " and num_pedido = " & _num_pedido & ""
            ret = ret & vbCrLf & d.Comando(sql, True)
            i = i + 1
        End While
        Return ret
    End Function
    Public Function faturado() As Boolean
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT count(item) as itens FROM fatura_itens  " &
        "WHERE (num_pedido = " & _num_pedido & ") AND  " &
        "(id_filial_pedido = " & _id_filial & ")"
        d.carrega_Tabela(sql, tt)
        If tt.Rows(0)(0) = 0 Then Return False Else Return True
    End Function
    Public Function fatura() As String()
        Dim sql As String
        Dim fat(2) As String 'Retorna Array de Strings com identificação da fatura
        Dim tt As New DataTable
        sql = "SELECT id_filial,cod_fatura FROM fatura_itens  " &
        "WHERE (num_pedido = " & _num_pedido & ") AND  " &
        "(id_filial_pedido = " & _id_filial & ")"
        d.carrega_Tabela(sql, tt)
        If tt.Rows.Count = 1 Then
            fat(0) = tt.Rows(0)("id_filial")
            fat(1) = tt.Rows(0)("cod_fatura")
        Else
            fat(0) = 0
            fat(1) = 0
        End If
        Return fat
    End Function
    'Desconto Caixa
    Public Function calcula_desconto_distribuicao(ByVal xTotal_pedido As Double, ByVal xTotalDesc As Double, ByVal xValItemDesconto As Double) As Double
        Dim res As Double
        res = (xValItemDesconto * xTotalDesc) / xTotal_pedido
        Return res
    End Function
    Public Function distribui_descontos(ByVal x_total_desc As Double) As String
        Dim tbi As New DataTable
        Dim tbs As New DataTable
        Dim res As String
        tbi = lista_itens(_num_pedido, _id_filial, False)
        res = distribui_itens(tbi, x_total_desc)
        tbs = lista_servicos(_num_pedido, _id_filial)
        res = res & vbCrLf & distribui_servicos(tbs, x_total_desc)
        Return res
    End Function
    Private Function distribui_itens(ByVal t As DataTable, ByVal x_total_desc As Double) As String
        Dim i, m, item As Integer
        Dim preco, desc As Double
        Dim total_pedido As Double
        Dim res As String = ""
        total_pedido = total_itens() + total_servicos() 'Valor total do pedido
        i = 0 'Inicia contador
        m = t.Rows.Count 'Seta o máximo com o número máximo de itens
        While i < m
            'If t.Rows(i)("cod_status_item") <> 4 And t.Rows(i)("cod_status_item") <> 5 Then
            preco = t.Rows(i)("total")
            item = t.Rows(i)("item")
            desc = calcula_desconto_distribuicao(total_pedido, x_total_desc, preco)
            res = "Item " & item & vbCrLf & res
            i = i + 1
            ' End If
        End While
        Return res
    End Function
    Private Function distribui_servicos(ByVal t As DataTable, ByVal x_total_desc As Double)
        Dim i, m, item As Integer
        Dim preco, desc As Double
        Dim total_pedido As Double
        Dim res As String
        total_pedido = total_itens() + total_servicos() 'Valor total do pedido
        i = 0 'Inicia contador
        m = t.Rows.Count 'Seta o máximo com o número máximo de itens
        While i < m
            preco = t.Rows(i)("total")
            item = t.Rows(i)("item_servico")
            desc = calcula_desconto_distribuicao(total_pedido, x_total_desc, preco)
            res = "Serv Item " & item & vbCrLf & res
            i = i + 1
        End While
    End Function

    'Desconto Caixa
    Public Function cancela_pedido_zerado(ByVal x_filial As Integer, ByVal x_pedido As Integer) As String
        Dim itens, servicos As Double
        itens = total_itens(x_pedido, x_filial)
        servicos = total_servicos(x_pedido, x_filial)
        If (itens + servicos) = 0 Then
            Return atualiza_status_pedido(4)
        Else
            Return "Não Cancelado!"
        End If

    End Function
    ''' <summary>
    ''' Retorna OS do pedido
    ''' </summary>
    ''' <param name="n_pedido">
    ''' O número do pedido
    ''' </param>
    ''' <param name="x_id_filial">
    ''' A filial onde o pedido foi gerado e que identifica a OS
    ''' </param>
    ''' <returns>Caso o pedido seja de OS, retorna o número da OS
    ''' caso contrário, retorna zero
    ''' </returns>
    ''' <remarks></remarks>
    Public Function os(ByVal n_pedido As Integer, ByVal x_id_filial As Integer) As String
        Dim sql As String
        Dim tt As New DataTable
        sql = "select cod_os from os where num_pedido = " & n_pedido &
        " and id_filial = " & x_id_filial & ""
        d.carrega_Tabela(sql, tt)
        If tt.Rows.Count > 0 Then
            Return tt.Rows(0)("cod_os")
        Else
            Return 0
        End If
    End Function
    Public Function lista_OSs() As DataTable
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "select os.cod_os,os.id_filial from OS inner join pedido_balcao on pedido_balcao.num_pedido = os.num_pedido " &
        "and pedido_balcao.id_filial = os.id_filial and pedido_balcao.num_pedido = " & Me._num_pedido &
        " and pedido_balcao.id_filial = " & Me._id_filial & ""
        d.carrega_Tabela(tsql, tt)
        Return tt
    End Function
    Public Function lista_OS_string() As String
        Dim tsql As String
        Dim tt As New DataTable
        Dim res As String = ""
        tsql = "select os.cod_os,os.id_filial from OS inner join pedido_balcao on pedido_balcao.num_pedido = os.num_pedido " &
        "and pedido_balcao.id_filial = os.id_filial and pedido_balcao.num_pedido = " & Me._num_pedido &
        " and pedido_balcao.id_filial = " & Me._id_filial & ""
        d.carrega_Tabela(tsql, tt)
        For Each r As DataRow In tt.Rows
            res = res & r("id_filial") & "-" & r("cod_os") & ". "
        Next
        Return res
    End Function
    Public Function atualiza_precos_otica()
        Dim tsql As String
        Dim tt As New DataTable
        Dim uSql As String
        Dim p As New produtoClass(d)
        Dim res As String = ""
        tsql = "SELECT num_pedido, id_filial, item, cod_produto FROM pedido_balcao_itens where num_pedido = " & Me.num_pedido &
        " and id_filial = " & Me.id_filial
        d.carrega_Tabela(tsql, tt)
        For Each r As DataRow In tt.Rows
            Dim i As Integer
            Dim preco As Double
            i = r("item")
            p.Source("Select * from produtos where cod_produto = " & r("cod_produto"))
            preco = ((p.Preco_compra - (p.Preco_compra * (p.Desconto_compra / 100))) +
                               (p.Preco_compra - (p.Preco_compra * (p.Desconto_compra / 100))) * 0.15)
            uSql = "Update pedido_balcao_itens set preco = " & d.cdin(preco) & ", desconto = 0 " &
                " where  " &
                " num_pedido = " & Me.num_pedido & " and id_filial = " & Me.id_filial &
                " and item = " & i & ""
            res = res & vbTab & d.Comando(uSql, True)
        Next
        Return res
    End Function
#End Region
#Region "Itens OS"
    Public Function novo_pedido_otica(ByVal os As ObjOS) As String
        Dim resp As String = ""
        If os.num_pedido = 0 Then
            Me.id_filial = os.id_filial
            Me.cod_cliente = os.cod_cliente
            Me.cod_filial_cliente = os.cod_filial_cliente
            Me.cod_vendedor = 2
            Me.data_pedido = Now
            resp = Me.Salvar()
            If resp.StartsWith("OK") Then
                resp = inserir_produtos_otica(os)
            End If
            Return resp
        End If
    End Function
    Private Function inserir_produtos_otica(ByVal os As ObjOS) As String
        Dim p As New produtoClass(d)
        Dim i, m As Integer
        Dim status_item As Integer = 1
        Dim andamentos As New objAndamentos(os.cod_os, os.id_filial)
        Dim tbTratamentos As New DataTable
        Dim resp As String = ""
        Try
            'Processando olho direito
            p.Source("Select * from produtos where cod_produto = " & os.cod_produto_od & "")
            Me.insere_item(Me._num_pedido, Me._id_filial, os.cod_produto_od, 1, 0,
                                ((p.Preco_compra - (p.Preco_compra * (p.Desconto_compra / 100))) +
                               (p.Preco_compra - (p.Preco_compra * (p.Desconto_compra / 100))) * 0.15), status_item)
            'Processando olho esquerdo
            p.Source("Select * from produtos where cod_produto = " & os.cod_produto_oe & "")
            Me.insere_item(Me._num_pedido, Me._id_filial, os.cod_produto_oe, 1, 0,
                                ((p.Preco_compra - (p.Preco_compra * (p.Desconto_compra / 100))) +
                               (p.Preco_compra - (p.Preco_compra * (p.Desconto_compra / 100))) * 0.15), status_item)
            resp = resp & "Nº da OS na Labonorte: " & os.cod_os & " " & Chr(13) & os.grava_numero_pedido(Me.num_pedido, os.cod_os, os.id_filial)
        Catch ex As Exception
            resp = "Itens: " & ex.ToString
        End Try

        Return resp
    End Function
#End Region
End Class
Public Class itemProducao
    'classe item para ser usado no pedido de Produção
#Region "Atributos"
    Dim _item As Integer
    Dim _cod_produto_origem As Integer 'Código do bloco de origem na tabela produtos 
    Dim _cod_tabela_origem As Integer 'Código do bloco de origem na tabela lentes_tabela
    Dim _cod_produto_destino As Integer 'Código do bloco surfaçado de destino na tabela produtos
    Dim _cod_tabela_destino As Integer 'Código do bloco surfaçado de destino na tabela lentes_tabela

    Dim _esf As Double
    Dim _cil As Double
    Dim _base As Double
    Dim _adicao As Double
    Dim _olho As String
    Dim _quantidade As Integer
    Dim _existe As Boolean = False
    Dim d As New dados
#End Region
#Region "Get Set"
    Public Property Item As Integer
        Get
            Item = _item
        End Get
        Set(ByVal value As Integer)
            _item = value
        End Set
    End Property
    Public Property cod_produto_origem As Integer
        Get
            cod_produto_origem = _cod_produto_origem
        End Get
        Set(ByVal value As Integer)
            _cod_produto_origem = value
        End Set
    End Property
    Public Property cod_tabela_origem As Integer
        Get
            cod_tabela_origem = _cod_tabela_origem
        End Get
        Set(ByVal value As Integer)
            _cod_tabela_origem = value
        End Set
    End Property

    Public Property cod_produto_destino As Integer
        Get
            cod_produto_destino = _cod_produto_destino
        End Get
        Set(ByVal value As Integer)
            _cod_produto_destino = value
        End Set
    End Property
    Public Property cod_tabela_destino As Integer
        Get
            cod_tabela_destino = _cod_tabela_destino
        End Get
        Set(ByVal value As Integer)
            _cod_tabela_destino = value
        End Set
    End Property
    Public Property esf As Double
        Get
            esf = _esf
        End Get
        Set(ByVal value As Double)
            _esf = value
        End Set
    End Property
    Public Property cil As Double
        Get
            cil = _cil
        End Get
        Set(ByVal value As Double)
            _cil = value
        End Set
    End Property
    Public Property base As Double
        Get
            base = _base
        End Get
        Set(ByVal value As Double)
            _base = value
        End Set
    End Property
    Public Property adicao As Double
        Get
            adicao = _adicao
        End Get
        Set(ByVal value As Double)
            _adicao = value
        End Set
    End Property
    Public Property olho As String
        Get
            olho = _olho
        End Get
        Set(ByVal value As String)
            _olho = value
        End Set
    End Property
    Public Property quantidade As Integer
        Get
            quantidade = _quantidade
        End Get
        Set(ByVal value As Integer)
            _quantidade = value
        End Set
    End Property
    Public Property existe As Boolean
        Get
            existe = _existe
        End Get
        Set(ByVal value As Boolean)
            _existe = value
        End Set
    End Property
#End Region
#Region "Procedimentos"
    Public Sub New(ByVal xCod_tabela_destino As Integer, ByVal adicao As Double, ByVal base As Double, ByVal esf As Double, ByVal cil As Double, ByVal olho As String)
        _adicao = adicao
        _base = base
        _olho = olho
        _esf = esf
        _cil = cil
        _cod_tabela_destino = xCod_tabela_destino
        existe = info(_cod_tabela_destino)
    End Sub
    Private Function info(ByVal cod_tabela_destino As Integer) As Boolean
        Dim lentes As New objBlocoSurf()
        Dim bloco As New objblocos()
        _cod_tabela_origem = lentes.retorna_bloco_origem(cod_tabela_destino)
        _cod_produto_destino = lentes.retorna_cod_produto(_adicao, _olho, _cod_tabela_destino, _esf, cil)
        lentes.filtra(_cod_produto_destino)
        _base = lentes.base
        _cod_produto_origem = bloco.retorna_cod_produto(_base, _adicao, _olho, _cod_tabela_origem)
        If cod_produto_destino = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function nome_destino() As String
        Dim p As New produtoClass()
        Return p.Retorna_nome_prod(_cod_produto_destino)
    End Function
#End Region
End Class
