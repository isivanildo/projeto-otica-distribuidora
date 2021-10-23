Imports System.Data
Imports System.Data.SqlClient
Imports mrotica_util
Imports MRUtil
Imports Vinco.iContNFe.NFeIntegratorInterOp
Imports Vinco.iContNFe.NFeIntegratorInterOp.Interface
Imports System.IO

Public Class frmFatura
    Dim tbfatura As New DataTable
    Dim d As New dados
    Dim Lancamento As New Pagamento
    Dim FaturaTeste As New Fatura
    Dim Conexao As New ConexaoDB()
    Dim ClienteOt As New ClienteOtica
    Public fatura As New objFatura
    Dim Fat As New Fatura
    Dim BoletoPagamento As New BoletoLancamento
    'Dim Pagamento As New Pagamento
    Dim tb_itens As New DataTable
    Dim tb_rec As New DataTable
    Public novo As Boolean = False
    Dim lanc As New objPagFatura
    Dim conf As New config
    Public user As New objUsuario
    Dim emitente As New Empresa(conf.Filial)
    Dim dadosNFe As New MRUtil.NFe
    Dim dadosNFeItem As New NFe_Item
    Dim dadosNFeCobranca As New NFe_Cobranca
    Dim op As New NaturezaOperacao
    Dim cst As New CstNFe
    Dim oNFe As NFeIntegrator = New NFeIntegrator()
    Dim Estoque As New Estoque
    Dim Usuario As New Usuario
    Dim PedidoItem As New PedidoItens
    ''
    Dim intContador As Integer
    Dim valordif As Double = 0
    Dim contador As Integer
    Dim Label4 As New Label
    Dim datacaixa As New objMaster
    Dim intNossoNumero As Long
    'Dim resto As Double = 0.0
    Dim somadiferenca As Double = 0.0
    Public intAtualiza As Integer
    Dim pdfExport As New DataDynamics.ActiveReports.Export.Pdf.PdfExport
    Dim nossonumero As String
    Dim codigobarra As String
    Dim linhadigitavel As String
    Dim codigocliente As Integer
    Dim ttCliente As New DataTable
    Dim dsCliente As New DataSet
    Dim intData As Integer
    Dim dataBoleto As Date
    Dim intImprimir As Integer = 0
    Dim intDiasProtesto As Integer
    Dim intProtesto As Integer
    Dim dtVencBoleto As New DateTimePicker
    Dim intUsuario As Integer
    Dim valor As Double
    Dim intControle As Integer
    Public intTipoCliente As Integer
    Dim dllInicializada As Boolean = False
    Private Sub frmFatura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        intUsuario = datacaixa.retorna_codigo_usuario(frmMain.intCodigoUsuario)
        Dim intAcesso As Integer = datacaixa.verifica_permissao_menu(intUsuario)
        Usuario.RetornaRegistro(frmMain.intCodigoUsuario)

        If intAcesso = 6 Then
            Label14.Enabled = True
            Label15.Enabled = True
            txtTroco.Enabled = True
            lblTroco.Enabled = True
        End If

        carrega_combos()

        If cbForma.SelectedIndex = 0 Then
            txtNparcelas.Enabled = False
        End If

        abre_fatura(lblFatura.Text, lblFilial.Text)
        descontos()
        Label13.Text = lblFilial.Text & " - " & lblFatura.Text
        lblCliente.Text = retornaNomeCliente(CInt(lblFatura.Text), CInt(lblFilial.Text))
        mostraPedidoFatura()
        Lista_Rec()
        mostraItensFatura()
        DesativaControle()
    End Sub

    Private Sub carrega_combos()
        Dim tb_forma As New DataTable
        d.carrega_Tabela("Select * from forma_pagamento where status = 'A'", tb_forma)
        cbForma.DataSource = tb_forma
        cbForma.ValueMember = "cod_forma_pagamento"
        cbForma.DisplayMember = "forma_pagamento"
    End Sub

    Private Sub Lista_Rec()
        grdRec.Columns.Clear()
        grdRec.AutoGenerateColumns = False
        grdRec.AllowUserToAddRows = False

        Dim strSQL As String
        strSQL = "SELECT l.cod_lancamento,l.id_filial_lancamento,l.id_filial,l.data_lancamento,l.cod_conta, sum(l.Valor_Pago + acrescimo - desconto) as valor_pago, " &
            "l.cod_forma_pagamento, l.n_parcelas, l.n_parcela, l.data_vencimento, l.data_recebimento, l.historico, l.doc, l.tipo, l.cod_status_lancamento, " +
            "l.cod_fatura, l.acrescimo, l.juros, l.taxas, l.usuario_lanc, l.usuario_alt, fp.forma_pagamento FROM lancamentos l INNER JOIN forma_pagamento fp ON " &
            "l.cod_forma_pagamento = fp.cod_forma_pagamento WHERE l.cod_fatura = " & lblFatura.Text & " And id_filial = " & lblFilial.Text &
            " And l.cod_status_lancamento IN (1,3) group by l.cod_lancamento, l.id_filial_lancamento, l.id_filial, l.data_lancamento, l.cod_conta, l.Valor_Pago, " &
            "l.cod_forma_pagamento, l.n_parcelas, l.n_parcela, l.data_vencimento, l.data_recebimento, l.historico, l.doc, l.tipo, l.cod_status_lancamento, " &
            "l.cod_fatura, l.acrescimo, l.juros, l.desconto, l.taxas, l.usuario_lanc, l.usuario_alt, fp.forma_pagamento"

        Dim dLanc As New DataGridViewTextBoxColumn
        dLanc.HeaderText = "Data Rec."
        dLanc.DataPropertyName = "data_vencimento"
        dLanc.Width = 80
        dLanc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdRec.Columns.Add(dLanc)

        Dim cForma As New DataGridViewTextBoxColumn
        cForma.HeaderText = "Forma"
        cForma.DataPropertyName = "forma_pagamento"
        cForma.Width = 100
        grdRec.Columns.Add(cForma)


        Dim cValor As New DataGridViewTextBoxColumn
        cValor.HeaderText = "Valor"
        cValor.DataPropertyName = "valor_pago"
        cValor.Width = 70
        cValor.DefaultCellStyle.Format = "#,##0.00"
        cValor.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdRec.Columns.Add(cValor)

        Dim cDoc As New DataGridViewTextBoxColumn
        cDoc.HeaderText = "Documento"
        cDoc.DataPropertyName = "doc"
        cDoc.Width = 250
        grdRec.Columns.Add(cDoc)

        Dim cLanc As New DataGridViewTextBoxColumn
        cLanc.HeaderText = "Lanc"
        cLanc.DataPropertyName = "cod_lancamento"
        cLanc.Width = 60
        cLanc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdRec.Columns.Add(cLanc)

        Dim cFilialLancamento As New DataGridViewTextBoxColumn
        cFilialLancamento.HeaderText = "Filial"
        cFilialLancamento.DataPropertyName = "id_filial_lancamento"
        cFilialLancamento.Visible = False
        grdRec.Columns.Add(cFilialLancamento)

        Try
            d.conecta()
            Dim da As New SqlDataAdapter(strSQL, d.con)
            Dim ds As New DataSet
            da.Fill(ds, "Lancamento")
            grdRec.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            'dr.Close()
            d.desconecta()
        End Try

        'descontos()
        TotalProdutosServicos()

        Label16.Text = "Itens de Pacote restante p/ Pagar: " & Format(CDbl(fatura.valor_restante_pacote), "#,##0.00") & Chr(13) &
                "Produtos: " & Format(CDbl(fatura.valor_itens_pacote), "#,##0.00") & " Serviços: " & Format(CDbl(fatura.valor_servicos_pacote), "#,##0.00")
    End Sub

    Private Sub TotalProdutosServicos()
        FaturaTeste.RetornaRegistro(Convert.ToInt32(lblFatura.Text), Convert.ToInt32(lblFilial.Text))
        FaturaTeste.RetornaTotais(Convert.ToInt32(lblFatura.Text), Convert.ToInt32(lblFilial.Text))
        txtTotalProd.Text = String.Format("{0:##0.00}", FaturaTeste.TotalProdutos)
        txtTotalServ.Text = String.Format("{0:##0.00}", FaturaTeste.TotalServicos)
        txtTotalFatura.Text = String.Format("{0:##0.00}", FaturaTeste.TotalFatura)

        Dim vDesconto, vAcrescimo As Decimal

        vAcrescimo = Convert.ToDecimal(txtAcrescimo.Text)
        vDesconto = Convert.ToDecimal(txtDesconto.Text)

        txtTotalPago.Text = String.Format("{0:##0.00}", FaturaTeste.TotalPago)

        If vDesconto > 0 Then
            txtaPagar.Text = String.Format("{0:##0.00}", FaturaTeste.TotalFatura - vDesconto - FaturaTeste.TotalPago)
        ElseIf vAcrescimo > 0 Then
            txtaPagar.Text = String.Format("{0:##0.00}", FaturaTeste.TotalFatura + vAcrescimo - FaturaTeste.TotalPago)
        ElseIf vDesconto > 0 And vAcrescimo > 0 Then
            txtaPagar.Text = String.Format("{0:##0.00}", FaturaTeste.TotalFatura + vAcrescimo - vDesconto)
        Else
            txtaPagar.Text = String.Format("{0:##0.00}", FaturaTeste.TotalFatura - FaturaTeste.TotalPago)
        End If
        'txtaPagar.Text = String.Format("{0:##0.00}", FaturaTeste.TotalFatura - vDesconto - FaturaTeste.TotalPago)

        'txtaPagar.Text = String.Format("{0:##0.00}", FaturaTeste.TotalFatura - vDesconto - FaturaTeste.TotalPago)
        txtValor.Text = Convert.ToDecimal(txtaPagar.Text)

    End Sub

    Private Sub descontos()
        txtDesconto.Text = Format(fatura.desconto_fatura(), "#,##0.00")
        txtAcrescimo.Text = Format(fatura.acrescimo_fatura(), "#,##0.00")
    End Sub

    Private Sub nova_fatura()
        fatura.novo()
        Dim f As New frmConsultaCliente
        f.ShowDialog(Me)
        fatura.cod_filial_cliente = f.cod_filial
        fatura.cod_cliente = f.cod_cliente
        Me.lblCliente.Text = f.cod_filial & "-" & f.cod_cliente & ": " & f.nome
        f.Dispose()
        fatura.data_lancamento = datacaixa.retornaDataHoraServidor
        fatura.id_filial = conf.Filial
        fatura.id_usuario = UserID
        MsgBox(fatura.Salvar())
        lblFilial.Text = fatura.id_filial
        lblFatura.Text = fatura.cod_fatura
    End Sub
    Public Sub abre_fatura(ByVal cod_fatura As Integer, ByVal cod_filial As Integer)
        fatura.abrir_fatura(cod_fatura, cod_filial)
        lblFilial.Text = fatura.id_filial
        lblFatura.Text = fatura.cod_fatura
        'txtAcrescimo.Text = fatura.acrescimos
        TotalProdutosServicos()
    End Sub

    Private Sub lancaBoletos()
        Dim parc As Integer = 1
        Dim data As Date
        Dim conta As New objContaBanco()
        Dim CRED As New objCreditoCliente
        Dim boleto As New objBoleto(objPagamento.tipo_pagamento.Fatura)
        Dim par As Int16 = txtNparcelas.Text
        Dim total As Decimal = Convert.ToDecimal(txtValor.Text)
        Dim valor As Decimal = Decimal.Round(Convert.ToDecimal(txtValor.Text) / Convert.ToDecimal(par), 2)
        Dim Ult As Decimal = Convert.ToDecimal(total) - (valor * (par - 1))
        data = dtVenc.Value
        conta.filtra(conf.Filial, 1)

        While parc <= par
            boleto.novo_boleto()
            boleto.data_lancamento = datacaixa.retornaDataHoraServidor
            boleto.data_vencimento = data
            boleto.cod_fat_cred = fatura.cod_fatura
            boleto.documento = fatura.cod_fatura
            boleto.id_filial = fatura.id_filial
            boleto.id_filial_lancamento = conf.Filial
            boleto.cod_conta = 101
            boleto.cod_forma_pagamento = cbForma.SelectedValue
            boleto.cod_fatura_lanc = fatura.cod_fatura

            boleto.historico = "Boleto " & adiciona_zeros(parc, 2) &
            " de " & adiciona_zeros(par, 2) & "  da fatura " & adiciona_zeros(fatura.id_filial, 4) & "-" &
            adiciona_zeros(fatura.cod_fatura, 6) &
            " Pedidos: " & pedidos()
            boleto.n_parcela = parc
            boleto.n_parcelas = par
            boleto.tipo = "R"
            If parc = par Then
                boleto.valor = Ult
            Else
                boleto.valor = valor
            End If
            boleto.nossonumero = conta.NossoNumero()
            boleto.barra = conta.FormataCodigoBarra(data, boleto.valor, boleto.nossonumero)
            boleto.digitavel = conta.FormataLinhaDigitavel(boleto.barra)
            boleto.cod_filial_cliente = fatura.cod_filial_cliente
            boleto.cod_cliente = fatura.cod_cliente
            boleto.tipo_documento = "FAT"
            boleto.banco = conta.codigoBanco04de25
            boleto.emitente = conf.Filial
            boleto.manual = False
            boleto.Salvar_boleto()
            boleto.concluir_SQL_transaction()
            conta.atualiza_nosso_inicial()
            parc = parc + 1
            data = DateAdd(DateInterval.Day, 30, data)
        End While

    End Sub
    Private Sub lancaBoletoManualNovo()
        Dim parc As Integer = intContador
        Dim conta As New objContaBanco()
        Dim CRED As New objCreditoCliente

        Dim par As Int16 = CInt(txtNparcelas.Text)
        Dim total As Double = Format(CDbl(txtValor.Text), "#,##0.00")

        conta.filtra(1, 1)
        BoletoPagamento.Novo()
        BoletoPagamento.DataLancamento = datacaixa.retornaDataHoraServidor
        BoletoPagamento.DataVencimento = dataBoleto
        BoletoPagamento.CodigoFaturaCredito = fatura.cod_fatura
        BoletoPagamento.Doc = fatura.cod_fatura
        BoletoPagamento.CodigoFilial = fatura.id_filial
        BoletoPagamento.CodigoFilialLancamento = conf.Filial
        BoletoPagamento.CodigoConta = 101
        BoletoPagamento.CodigoFormaPag = cbForma.SelectedValue
        BoletoPagamento.Historico = "Boleto " & adiciona_zeros(intContador, 2) &
        "  da fatura " & adiciona_zeros(fatura.id_filial, 4) & "-" &
        adiciona_zeros(fatura.cod_fatura, 6) &
        " Pedidos: " & pedidos()
        BoletoPagamento.NumeroParcela = parc
        BoletoPagamento.NumeroParcelas = par
        BoletoPagamento.Tipo = "R"
        BoletoPagamento.CodigoStatusLanc = 1
        BoletoPagamento.ValorPago = valor
        BoletoPagamento.CodigoFatura = fatura.cod_fatura
        BoletoPagamento.Acrescimo = 0.0
        BoletoPagamento.Juros = 0.0
        BoletoPagamento.Desconto = 0.0
        BoletoPagamento.Taxa = 0.0
        BoletoPagamento.NossoNumeto = intNossoNumero
        BoletoPagamento.Documento = "Bol. " & BoletoPagamento.NossoNumeto
        BoletoPagamento.Barra = codigobarra
        BoletoPagamento.Digitavel = linhadigitavel
        BoletoPagamento.CodigoFilial = fatura.cod_filial_cliente
        BoletoPagamento.CodigoCliente = fatura.cod_cliente
        BoletoPagamento.TipoDocumento = "FAT"
        BoletoPagamento.Banco = conta.codigoBanco04de25
        BoletoPagamento.Emitente = conf.Filial
        BoletoPagamento.Manual = True
        BoletoPagamento.DiasProtesto = intDiasProtesto
        BoletoPagamento.AcaoCobranca = "01"
        BoletoPagamento.UsuarioLanc = intUsuario 'Indica o usuário que fez inclusão do lançamento na tabela boleto
        BoletoPagamento.UsuarioAlt = intUsuario 'Indica o usuário que fez inclusão do lançamento na tabela lançamento
        BoletoPagamento.Enviado = "N"
        BoletoPagamento.TipoPag = "Fatura"

        If BoletoPagamento.SalvaBoleto() = True Then
            MovimentaEstoque()
            RegraPagamento()
            RegraDesconto()
        End If
    End Sub

    Private Sub lancaBoletoManual()
        Dim parc As Integer = intContador
        Dim data As Date
        Dim conta As New objContaBanco()
        Dim CRED As New objCreditoCliente
        Dim boleto As New objBoleto(objPagamento.tipo_pagamento.Fatura)
        Dim par As Int16 = CInt(txtNparcelas.Text)
        Dim total As Double = Format(CDbl(txtValor.Text), "#,##0.00")
        'Dim valor As Decimal = Decimal.Round(Convert.ToDecimal(txtValor.Text) / Convert.ToDecimal(par), 2)
        Dim valor As Double = Format(CDbl(txtValor.Text) / par, "#,##0.00")

        Dim lanca_resgatado As Integer

        data = DateAdd(DateInterval.Month, intContador - 1, dtVenc.Value)
        conta.filtra(conf.Filial, 1)
        boleto.novo_boleto()
        boleto.data_lancamento = datacaixa.retornaDataHoraServidor
        boleto.data_vencimento = data
        boleto.cod_fat_cred = fatura.cod_fatura
        boleto.documento = fatura.cod_fatura
        boleto.id_filial = fatura.id_filial
        boleto.id_filial_lancamento = conf.Filial
        boleto.cod_conta = 101
        boleto.cod_forma_pagamento = cbForma.SelectedValue
        boleto.historico = "Boleto Manual " & adiciona_zeros(intContador, 2) &
        "  da fatura " & adiciona_zeros(fatura.id_filial, 4) & "-" &
        adiciona_zeros(fatura.cod_fatura, 6) &
        " Pedidos: " & pedidos()
        boleto.n_parcela = parc
        boleto.n_parcelas = par
        boleto.tipo = "R"
        boleto.valor = valor
        boleto.cod_fatura_lanc = fatura.cod_fatura
        boleto.acrescimo_novo = 0.0
        boleto.juros_novo = 0.0
        boleto.desconto_novo = 0.0
        boleto.taxas = 0.0
        'Dim nosso As String = "11785588" & adiciona_zeros(InputBox("Ultimos numeros do Nosso Numero:"), 9)
        Dim nosso As String = "117855808" & adiciona_zeros(intNossoNumero, 8)
        boleto.nossonumero = nosso
        boleto.doc = "Bol. " & boleto.nossonumero
        boleto.barra = conta.FormataCodigoBarra(data, boleto.valor, boleto.nossonumero)
        boleto.digitavel = conta.FormataLinhaDigitavel(boleto.barra)
        boleto.cod_filial_cliente = fatura.cod_filial_cliente
        boleto.cod_cliente = fatura.cod_cliente
        boleto.tipo_documento = "FAT"
        boleto.banco = conta.codigoBanco04de25
        boleto.emitente = conf.Filial
        boleto.manual = True
        boleto.diasprotesto = intDiasProtesto
        boleto.acaocobranca = "01"
        boleto.usuario_inc = intUsuario
        boleto.usuario_alt = 0
        boleto.envio_boleto = "S"
        boleto.Salvar_boleto()
        boleto.concluir_SQL_transaction()
        'MsgBox(boleto.concluir_SQL_transaction())
    End Sub

    Private Sub txtAcrescimo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAcrescimo.KeyDown
        If CDbl(txtaPagar.Text) <> 0.0 Then
            Dim intUsuario As Integer = datacaixa.retorna_codigo_usuario(frmMain.intCodigoUsuario)
            'Conceder Desconto Procedimento 20
            If datacaixa.verifica_permissao_usuario(intUsuario, 20) = True Then
                Select Case e.KeyCode
                    Case Keys.Enter
                        Dim f As New frmAcrescimosFatura
                        f.origem = frmAcrescimosFatura.tipoAcrescimo.fatura
                        f.fatura = fatura
                        f.ShowDialog(Me)
                        descontos()
                        TotalProdutosServicos()
                End Select
            Else
                MessageBox.Show("Usuário não pode adicionar acréscimo no caixa.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Não é possível fazer lançamentos de acréscimo para fatura fechada.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txtAcrescimo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAcrescimo.LostFocus
        fatura.editar()
        fatura.acrescimos = txtAcrescimo.Text
        fatura.Salvar()
    End Sub
    Private Sub grdRec_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdRec.DoubleClick
        If datacaixa.convertedata(datacaixa.retornaDataHoraServidor) <= datacaixa.convertedata(grdRec.CurrentRow.Cells(0).Value) Then
            Dim r As frmAviso.respo
            Dim fC As New frmCancelaLancamento
            If MessageBox.Show("Deseja cancelar este recebimento?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If datacaixa.verifica_permissao_usuario(intUsuario, 23) = True Then
                    fC.ShowDialog(Me)
                    Dim cod_lanc, filial_lanc As Integer
                    cod_lanc = grdRec.CurrentRow.Cells(4).Value
                    filial_lanc = grdRec.CurrentRow.Cells(5).Value
                    lanc.cancelar_lancamento(cod_lanc, filial_lanc, intUsuario, conf.Filial, fC.txtdesc.Text, Now)

                    If cbForma.SelectedValue = 8 Then
                        'Instruções responsáveis por indicar se o arquivo de remessa já foi ou não enviado para o banco
                        Dim strSQLAtualiza As String = "usuario_alt = " & intUsuario & ",enviado = 'S', data_envio = " & d.Pdt(Now()) & "" &
                            " where cod_lancamento = " & cod_lanc & " and id_filial = " & CInt(lblFilial.Text)
                        datacaixa.atualiza_registros("Boleto", strSQLAtualiza, True)
                    End If
                Else
                    MessageBox.Show("Usuário não tem permissão para cancelar Lançamentos de Fatura!", "ERROR: 23", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If

            Lista_Rec()
            AtivaControle()
            If txtaPagar.Text > 0 Then
                btnCancelar.Enabled = True
            End If
        Else
            MessageBox.Show("Lançamento não pode ser excluído, data de recebimento" & Chr(13) & "difere da data atual do caixa aberto.", "ERROR",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function pedidos() As String
        Dim i As DataGridViewRow
        Dim str As String
        For Each i In grdPedido.Rows
            str = str & " - " & i.Cells(0).Value.ToString
        Next
        Return str
    End Function

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim f As New frmRpt
        Dim r As New rptFatura
        'FaturaTeste.RetornaRegistro(lblFatura.Text, lblFilial.Text)
        r.DataSource = fatura.lista_itens_fatura
        ClienteOt.FiltraCliente(FaturaTeste.CodigoCliente)
        r.cliente = "Cliente: " & ClienteOt.CodigoCliente & "-" & ClienteOt.NomeCliente
        r.fatura = "Fatura: " & adiciona_zeros(FaturaTeste.CodigoFilial, 4) & "-" & adiciona_zeros(FaturaTeste.CodigoFatura, 6) &
        " Emitida em: " & FaturaTeste.DataLancamento
        r.desconto = txtDesconto.Text
        r.acrescimo = txtAcrescimo.Text
        r.aPagar = txtaPagar.Text
        r.tRec = Lancamento.ListaRecebimentoFatura(FaturaTeste.CodigoFilial, FaturaTeste.CodigoFatura)
        f.Relat(r)
        f.Show()
    End Sub

    Private Sub txtDesconto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDesconto.KeyDown
        If CDbl(txtaPagar.Text) <> 0.0 Then
            Dim intUsuario As Integer = datacaixa.retorna_codigo_usuario(frmMain.intCodigoUsuario)
            'Conceder Desconto Procedimento 20
            If datacaixa.verifica_permissao_usuario(intUsuario, 20) = True Then
                Select Case e.KeyCode
                    Case Keys.Enter
                        Dim f As New frmDescontosFatura
                        f.fatura = fatura
                        f.ShowDialog(Me)
                        descontos()
                        TotalProdutosServicos()
                End Select
            Else
                MessageBox.Show("Usuário não pode conceder desconto no caixa.", "ERROR: 20", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Não é possível fazer lançamentos de desconto para fatura fechada.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub mostraPedidoFatura()
        grdPedido.Columns.Clear()
        grdPedido.DataSource = Nothing
        grdPedido.AllowUserToAddRows = False
        grdPedido.AutoGenerateColumns = False

        Dim strSQL As String = "SELECT fatura_itens.*, " &
        "isnull((SELECT sum(pedido_balcao_itens.quant * pedido_balcao_itens.preco) AS total " &
        "FROM pedido_balcao_itens INNER JOIN " &
        "produtos ON pedido_balcao_itens.cod_produto = produtos.cod_produto " &
        "WHERE (pedido_balcao_itens.num_pedido = fatura_itens.num_pedido) AND " &
        "(pedido_balcao_itens.id_filial = fatura_itens.id_filial_pedido) AND NOT (pedido_balcao_itens.cod_status_item IN (4,5))),0) " &
        "AS Produtos, " &
        "isnull((SELECT sum(pedido_balcao_servicos.quant * pedido_balcao_servicos.preco) AS total " &
        "FROM pedido_balcao_servicos INNER JOIN " &
        "produtos ON pedido_balcao_servicos.cod_servico = produtos.cod_produto " &
        "WHERE (pedido_balcao_servicos.num_pedido = fatura_itens.num_pedido) AND " &
        "(pedido_balcao_servicos.id_filial = fatura_itens.id_filial_pedido and pedido_balcao_servicos.cod_status_servico = 1)),0) " &
        "as servicos, " &
        "(isnull((SELECT sum(pedido_balcao_itens.quant * pedido_balcao_itens.preco) AS total " &
        "FROM pedido_balcao_itens INNER JOIN " &
        "produtos ON pedido_balcao_itens.cod_produto = produtos.cod_produto " &
        "WHERE (pedido_balcao_itens.num_pedido = fatura_itens.num_pedido) AND " &
        "(pedido_balcao_itens.id_filial = fatura_itens.id_filial_pedido) AND NOT (pedido_balcao_itens.cod_status_item IN (4,5))),0) " &
        "+ " &
        "isnull((SELECT sum(pedido_balcao_servicos.quant * pedido_balcao_servicos.preco) " &
        "AS total " &
        "FROM pedido_balcao_servicos INNER JOIN " &
        "produtos ON pedido_balcao_servicos.cod_servico = produtos.cod_produto " &
        "WHERE (pedido_balcao_servicos.num_pedido = fatura_itens.num_pedido) AND " &
        "(pedido_balcao_servicos.id_filial = fatura_itens.id_filial_pedido and pedido_balcao_servicos.cod_status_servico = 1)),0)) " &
        "as Total " &
        ",(SELECT pedido_balcao.data_pedido FROM pedido_balcao " &
        " where pedido_balcao.num_pedido = fatura_itens.num_pedido " &
        "AND pedido_balcao.id_filial = fatura_itens.id_filial_pedido) as data_pedido, " &
        "(SELECT pedido_balcao.valor_pago  FROM pedido_balcao " &
        "where(pedido_balcao.num_pedido = fatura_itens.num_pedido) " &
        "AND pedido_balcao.id_filial = fatura_itens.id_filial_pedido) as totalpago, " &
        "(SELECT pedido_balcao.valor_apagar  FROM pedido_balcao " &
        "where(pedido_balcao.num_pedido = fatura_itens.num_pedido) " &
        "AND pedido_balcao.id_filial = fatura_itens.id_filial_pedido) as totalapagar " &
        "FROM  fatura_itens " &
        "where fatura_itens.cod_fatura =  " & CInt(lblFatura.Text) &
        " and fatura_itens.id_filial = " & conf.Filial & " order by total"


        Dim ttPedido As New DataTable

        Dim pedido As New DataGridViewTextBoxColumn 'Posição 00
        pedido.HeaderText = "pedido"
        pedido.DataPropertyName = "num_pedido"
        grdPedido.Columns.Add(pedido)

        Dim total As New DataGridViewTextBoxColumn 'Posição 01
        total.HeaderText = "Total"
        total.DataPropertyName = "total"
        total.DefaultCellStyle.Format = "#,##0.00"
        grdPedido.Columns.Add(total)

        Dim totalpago As New DataGridViewTextBoxColumn 'Posição 02
        totalpago.HeaderText = "Pago"
        totalpago.DataPropertyName = "totalpago"
        totalpago.DefaultCellStyle.Format = "#,##0.00"
        grdPedido.Columns.Add(totalpago)

        Dim totalapagar As New DataGridViewTextBoxColumn 'Posição 03
        totalapagar.HeaderText = "A Pagar"
        totalapagar.DataPropertyName = "totalapagar"
        totalapagar.DefaultCellStyle.Format = "#,##0.00"
        grdPedido.Columns.Add(totalapagar)

        ttPedido = datacaixa.retornaRegistro(strSQL).Tables(0)
        grdPedido.DataSource = ttPedido

        Label4.Text = ""
        For Each teste As DataGridViewRow In grdPedido.Rows
            Dim teste2 As String
            Dim valor As Double = teste.Cells(1).Value
            teste2 = teste.Cells(0).Value & " - " & Format(valor, "#,##0.00")
            Label4.Text = Label4.Text & teste2 & Chr(13)
        Next
    End Sub

    Private Sub atualizaPedidoBalcao(ByVal pedido As Integer, ByVal valorreal As Double, ByVal valorapagar As Double, ByVal tipo As Int16)
        Dim strSQL As String = ""
        If tipo = 1 Then
            strSQL = "UPDATE PEDIDO_BALCAO SET COD_STATUS_PEDIDO = 3, VALOR_PAGO = " & Replace(valorreal, ",", ".") & "," &
                     " VALOR_APAGAR = " & Replace(valorapagar, ",", ".") & " WHERE NUM_PEDIDO = " & pedido & " AND ID_FILIAL = " & conf.Filial
        ElseIf tipo = 2 Then
            strSQL = "UPDATE PEDIDO_BALCAO SET COD_STATUS_PEDIDO = 5, VALOR_PAGO = " & Replace(valorreal, ",", ".") & "," &
                     " VALOR_APAGAR = " & Replace(valorapagar, ",", ".") & " WHERE NUM_PEDIDO = " & pedido & " AND ID_FILIAL = " & conf.Filial
        End If

        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            d.desconecta()
        End Try
    End Sub

    Private Sub cancelaFaturaItens(ByVal fatura As Integer)
        Dim strSQL As String = ""
        strSQL = "DELETE FROM FATURA_ITENS WHERE COD_FATURA = " & fatura & " AND ID_FILIAL = " & conf.Filial
        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            cmd.ExecuteNonQuery()
            d.ComandoSQL(strSQL, True)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            d.desconecta()
        End Try
    End Sub

    Private Sub cancelaFatura(ByVal fatura As Integer)
        Dim strSQL As String = ""
        strSQL = "cod_status_fatura = 3 WHERE cod_fatura = " & fatura & " AND ID_FILIAL = " & conf.Filial
        datacaixa.atualiza_registros("Fatura", strSQL, True)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Try
            If MessageBox.Show("Deseja cancelar o faturamento desta fatura?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                For Each linha As DataGridViewRow In grdItens.Rows
                    Dim strSQL As String = "select num_pedido, cod_status_pedido from pedidos where num_pedido = " & linha.Cells(2).Value &
                    " and id_filial = " & fatura.id_filial & " and cod_cliente = " & fatura.cod_cliente

                    Dim ttPedido As New DataTable
                    ttPedido = datacaixa.retornaRegistro(strSQL).Tables(0)
                    If linha.Cells(2).Value = ttPedido.Rows(0)("num_pedido") Then
                        Dim strSQLAtualiza As String = "cod_status_pedido = " & ttPedido.Rows(0)("cod_status_pedido") &
                            ", valor_pago = 0.0, valor_apagar = 0.0 where num_pedido = " & linha.Cells(2).Value &
                            " and id_filial = " & fatura.id_filial & " and cod_cliente = " & fatura.cod_cliente
                        datacaixa.atualiza_registros("pedido_balcao", strSQLAtualiza, True)
                    End If
                Next
                cancelaFaturaItens(CInt(lblFatura.Text))
                cancelaFatura(CInt(lblFatura.Text))
                intControle = 1
                Me.Close()
                MessageBox.Show("Fatura cancelada com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DesativaControle()
        If FaturaTeste.StatusFatura = 2 Then
            dtVenc.Enabled = False
            cbForma.Enabled = False
            txtValor.Enabled = False
            txtNparcelas.Enabled = False
            txtDias.Enabled = False
            btnCancelar.Enabled = False
            btnOK.Enabled = False
            btnItemPedido.Enabled = False
        End If
    End Sub

    Private Sub AtivaControle()
        If CDbl(txtTotalFatura.Text) > CDbl(txtTotalPago.Text) Then
            dtVenc.Enabled = True
            cbForma.Enabled = True
            txtValor.Enabled = True
            txtNparcelas.Enabled = True
            txtDias.Enabled = True
            btnCancelar.Enabled = True
            btnOK.Enabled = True
        End If
    End Sub

    Private Sub txtValor_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtValor.KeyPress
        If Not IsNumeric(e.KeyChar) And (Not e.KeyChar = vbBack) And (Not e.KeyChar = ",") Then
            e.Handled = True
            MessageBox.Show("Campo só permite valor monetário no formato" & Chr(13) &
                            "da moeda corrente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txtNparcelas_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNparcelas.KeyPress
        If Not IsNumeric(e.KeyChar) And (Not e.KeyChar = vbBack) Then
            e.Handled = True
            MessageBox.Show("Campo só permite valor númerico.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnZerarValor_Click(sender As System.Object, e As System.EventArgs) Handles btnExportarPdf.Click
        Dim f As New frmRpt
        Dim r As New rptFatura
        Dim path As String = ""
        r.DataSource = fatura.lista_itens_fatura
        'cliente.filtra_cod(fatura.cod_cliente)
        ClienteOt.FiltraCliente(fatura.cod_cliente)
        r.cliente = "Cliente: " & ClienteOt.CodigoCliente & "-" & ClienteOt.NomeCliente
        r.fatura = "Fatura: " & adiciona_zeros(fatura.id_filial, 4) & "-" & adiciona_zeros(fatura.cod_fatura, 6) &
        " Emitida em: " & fatura.data_lancamento
        r.desconto = txtDesconto.Text
        r.acrescimo = txtAcrescimo.Text
        r.aPagar = txtaPagar.Text
        r.tRec = lanc.Listar_Rec_fatura(fatura.cod_fatura, fatura.id_filial)
        path = My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & ClienteOt.NomeCliente & ".pdf"
        f.Relat(r)
        f.Dispose()
        exportaPDF(r.Document, path)
    End Sub

    Private Sub txtTroco_Leave(sender As System.Object, e As System.EventArgs) Handles txtTroco.Leave
        Dim valor As Double = 0.0
        Dim troco As Double = 0.0
        Dim total As Double = 0.0

        troco = CDbl(txtTroco.Text)
        valor = CDbl(txtValor.Text)
        total = troco - valor
        lblTroco.Visible = True
        lblTroco.Text = Format(CDbl(total), "#,##0.00")
    End Sub

    Private Sub txtTroco_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtTroco.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Dim valor As Double = 0.0
                Dim troco As Double = 0.0
                Dim total As Double = 0.0

                troco = CDbl(txtTroco.Text)
                valor = CDbl(txtValor.Text)
                total = troco - valor
                lblTroco.Visible = True
                lblTroco.Text = Format(CDbl(total), "#,##0.00")
        End Select
    End Sub

    Private Sub atualizaPrecoCaixaProduto(ByVal pedido As Integer, ByVal filial As Integer)
        Dim strSQL As String = ""
        strSQL = "UPDATE PEDIDO_BALCAO_ITENS SET DESC_CAIXA = 0.0 " &
                     "WHERE NUM_PEDIDO = " & pedido & " AND ID_FILIAL = " & filial
        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            d.desconecta()
        End Try
    End Sub

    Private Sub atualizaPrecoCaixaServico(ByVal pedido As Integer, ByVal filial As Integer)
        Dim strSQL As String = ""
        strSQL = "UPDATE PEDIDO_BALCAO_SERVICOS SET DESC_CAIXA = 0.0 " &
                     "WHERE NUM_PEDIDO = " & pedido & " AND ID_FILIAL = " & filial
        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            d.desconecta()
        End Try
    End Sub

    Private Function retornaNomeCliente(ByVal fatura As Integer, ByVal filial As Integer) As String
        Try
            Dim strSQL As String = "SELECT CLIENTE.COD_CLIENTE, CLIENTE.NOME_CLIENTE FROM CLIENTE INNER JOIN FATURA ON CLIENTE.COD_CLIENTE = FATURA.COD_CLIENTE " &
                "WHERE FATURA.COD_FATURA = " & fatura & " AND FATURA.ID_FILIAL = " & filial
            d.conecta()
            Dim da As New SqlDataAdapter(strSQL, d.con)
            Dim ds As New DataSet
            da.Fill(ds, "Cliente")
            d.desconecta()
            codigocliente = ds.Tables(0).Rows(0)("cod_cliente").ToString
            Return ds.Tables(0).Rows(0)("cod_cliente").ToString & " - " & ds.Tables(0).Rows(0)("nome_cliente").ToString
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function

    Private Sub btnItemPedido_Click(sender As System.Object, e As System.EventArgs) Handles btnItemPedido.Click
        If MessageBox.Show("Deseja visualizar item desta fatura?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim f As New frmExcluiPedidoFatura
            f.intFatura = lblFatura.Text
            Dim intFilial As Integer = fatura.cod_filial_cliente 'CInt(lblFilial.Text)
            Dim intCodCliente As Integer = fatura.cod_cliente 'CInt(lblCliente.Text.Substring(0, 5))
            Dim intUsuario As Integer = datacaixa.retorna_codigo_usuario(frmMain.intCodigoUsuario)

            If datacaixa.verifica_permissao_menu(intUsuario) = 5 Then
                f.intFilial = intFilial
                f.intCodCliente = intCodCliente
                f.gerencia()
                f.rbAdicionar.Checked = True
                f.btnExcluiPedido.Enabled = False
                f.ShowDialog()
            End If

            If datacaixa.verifica_permissao_menu(intUsuario) = 6 Then
                f.intFilial = intFilial
                f.intCodCliente = intCodCliente
                f.caixa()
                f.rbExcluir.Checked = True
                f.btnExcluiPedido.Enabled = False
                f.ShowDialog()
            End If

            mostraPedidoFatura()
            mostraItensFatura()
            Lista_Rec()
        Else
            MessageBox.Show("Operação cancelada com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub mostraItensFatura()
        grdItens.Columns.Clear()
        grdItens.DataSource = Nothing

        grdItens.AllowUserToAddRows = False
        grdItens.AutoGenerateColumns = False

        Dim item As New DataGridViewTextBoxColumn 'Posição 00
        item.HeaderText = "Item"
        item.DataPropertyName = "Item"
        item.Width = 50
        grdItens.Columns.Add(item)

        Dim data As New DataGridViewTextBoxColumn 'Posição 01
        data.HeaderText = "Data"
        data.DataPropertyName = "data_pedido"
        data.DefaultCellStyle.Format = "dd/MM/yyyy"
        data.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        data.Width = 80
        grdItens.Columns.Add(data)

        Dim pedido As New DataGridViewTextBoxColumn 'Posição 02
        pedido.HeaderText = "Nº Pedido"
        pedido.DataPropertyName = "num_pedido"
        pedido.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdItens.Columns.Add(pedido)

        Dim produtos As New DataGridViewTextBoxColumn 'Posição 03
        produtos.HeaderText = "Produtos"
        produtos.DataPropertyName = "produtos"
        produtos.DefaultCellStyle.Format = "#,##0.00"
        produtos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdItens.Columns.Add(produtos)

        Dim servicos As New DataGridViewTextBoxColumn 'Posição 04
        servicos.HeaderText = "Serviços"
        servicos.DataPropertyName = "servicos"
        servicos.DefaultCellStyle.Format = "#,##0.00"
        servicos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdItens.Columns.Add(servicos)

        Dim total As New DataGridViewTextBoxColumn 'Posição 05
        total.HeaderText = "Total"
        total.DataPropertyName = "Total"
        total.DefaultCellStyle.Format = "#,##0.00"
        total.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdItens.Columns.Add(total)

        Dim valordevolvido As New DataGridViewTextBoxColumn 'Posição 06
        valordevolvido.HeaderText = "Devolvido"
        valordevolvido.DataPropertyName = "valor_devolvido"
        valordevolvido.DefaultCellStyle.Format = "#,##0.00"
        valordevolvido.Visible = False
        grdItens.Columns.Add(valordevolvido)

        Dim sel As New DataGridViewCheckBoxColumn
        sel.HeaderText = "Sel."
        sel.Width = 30
        grdItens.Columns.Add(sel)

        grdItens.DataSource = fatura.lista_itens_fatura

        For Each linha As DataGridViewRow In grdItens.Rows
            If linha.Cells(6).Value > 0.0 Then
                linha.DefaultCellStyle.BackColor = Color.Red
                linha.DefaultCellStyle.ForeColor = Color.White
                linha.Cells(7).Value = True
            End If
        Next
    End Sub

    Private Sub exportaPDF(ByVal r As DataDynamics.ActiveReports.Document.Document, ByVal path As String)
        If MessageBox.Show("Deseja exportar os dados para área de trabalho?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            pdfExport.Export(r, path)
            MessageBox.Show("Arquivo exportado com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub




    Private Sub montaBoleto()
        'Dim CobreBemX As CobreBemX.ContaCorrente
        Dim BoletoX As Object
        'Dim Email As Object

        'Inicializa o objeto CobreBemX
        'CobreBemX = New CobreBemX.ContaCorrente

        'Instruções por montarem o cabeçalho padrão para emissão do boleto
        'CobreBemX.ArquivoLicenca = My.Computer.FileSystem.CurrentDirectory & "\63882898000199-001-17-7.conf"
        'CobreBemX.CodigoAgencia = "3074-0"
        'CobreBemX.NumeroContaCorrente = "00060082-2"
        'CobreBemX.CodigoCedente = "1178558"
        'CobreBemX.InicioNossoNumero = "0000000001"
        'CobreBemX.FimNossoNumero = "9999999999"
        'CobreBemX.ProximoNossoNumero = datacaixa.retornaUltimoRegistro("Controle", "nossonumero")
        'CobreBemX.LocalPagamento = "Pagável em qualquer banco até o vencimento."
        'CobreBemX.OutroDadoConfiguracao1 = "019"
        'CobreBemX.PadroesBoleto.PadroesBoletoImpresso.ArquivoLogotipo = My.Computer.FileSystem.CurrentDirectory & "\Imagens\logo.jpg"
        'CobreBemX.PadroesBoleto.PadroesBoletoImpresso.CaminhoImagensCodigoBarras = My.Computer.FileSystem.CurrentDirectory & "\Imagens\"
        'CobreBemX.PadroesBoleto.PadroesBoletoImpresso.LayoutBoleto = "PadraoReciboPersonalizado"
        'CobreBemX.PadroesBoleto.PadroesBoletoImpresso.HTMLReciboPersonalizado = txtTextoBoleto.Text
        'CobreBemX.PadroesBoleto.PadroesBoletoImpresso.MargemSuperior = 20

        'Valor que será registrado no Boleto
        'Dim valor As Double
        Dim valorreal As Double
        Dim valorcentavo As Double

        'Função responsável por retorna os dados do cliente como por exemplo: Nome, Endereço, CEP e etc.
        carregaDadosCliente(codigocliente)

        'Cria um loop para criar a quantidade de boelto especificada de acordo com o número de parcelas
        For intContador = 1 To CInt(txtNparcelas.Text)
            valor = Format(CDbl(txtValor.Text) / CInt(txtNparcelas.Text), "#,##0.00")

            If intContador = 1 Then
                valorreal = Format(valor * CInt(txtNparcelas.Text), "#,##0.00")
            End If

            If intContador < CInt(txtNparcelas.Text) Then
                valordif = Format(valorreal - CDbl(txtValor.Text), "#,##0.00")
                valor = Format(valor - valordif, "#,##0.00")
                valorcentavo = Format(valorcentavo + valordif, "#,##0.00")
            End If

            If intContador = CInt(txtNparcelas.Text) Then
                valordif = Format(valorreal - CDbl(txtValor.Text), "#,##0.00")
                valor = Format(valor - valordif, "#,##0.00")
                valor = Format(valor + valorcentavo, "#,##0.00")
            End If

            intData = intData + 1
            If CInt(txtDias.Text) > 0 Then
                If CInt(txtNparcelas.Text) = 1 Then
                    If cbVencimento.Checked = False Then
                        dataBoleto = dtVenc.Value.AddDays(CInt(txtDias.Text))
                    Else
                        dataBoleto = dtVenc.Value.ToShortDateString
                    End If
                Else
                    If cbVencimento.Checked = False Then
                        dataBoleto = dtVenc.Value.AddDays(CInt(txtDias.Text) * intContador)
                    Else
                        If intData = 1 Then
                            dataBoleto = dtVenc.Value.ToShortDateString
                        Else
                            dataBoleto = dtVenc.Value.AddDays(CInt(txtDias.Text) * (intData - 1))
                        End If
                    End If
                End If
            Else
                If cbVencimento.Checked = False Then
                    dataBoleto = DateAdd(DateInterval.Month, intContador, dtVenc.Value)
                Else
                    If intData = 1 Then
                        dataBoleto = dtVenc.Value.ToShortDateString
                    Else
                        dataBoleto = DateAdd(DateInterval.Month, intData - 1, dtVenc.Value)
                    End If
                End If
            End If

            'Caso o dia informado seja sábado ou domingo a data de vencimento será no dia útil seguinte.
            If dataBoleto.DayOfWeek = 6 Then
                dataBoleto = dataBoleto.AddDays(2)
            ElseIf dataBoleto.DayOfWeek = 0 Then
                dataBoleto = dataBoleto.AddDays(1)
            End If

            dtVencBoleto.Value = dataBoleto

            'As próximas instruções são responsáveis por monta os dados do Boleto
            '   BoletoX = CobreBemX.DocumentosCobranca.Add
            '  BoletoX.TipoDocumentoCobranca = "DM"
            ' BoletoX.NumeroDocumento = CInt(lblFatura.Text) & " " & "FAT" & "-" & adiciona_zeros(intContador, 2) & "/" & adiciona_zeros(CInt(txtNparcelas.Text), 2)
            'BoletoX.NomeSacado = ttCliente.Rows(0)("razao_social")
            'BoletoX.CNPJSacado = ttCliente.Rows(0)("cnpj")
            'BoletoX.EnderecoSacado = ttCliente.Rows(0)("endereco")
            'BoletoX.BairroSacado = ttCliente.Rows(0)("bairro")
            'BoletoX.CidadeSacado = ttCliente.Rows(0)("municipio")
            'BoletoX.EstadoSacado = ttCliente.Rows(0)("uf")
            'BoletoX.CepSacado = ttCliente.Rows(0)("cep").ToString
            'BoletoX.DataDocumento = dtVenc.Value.ToShortDateString
            'BoletoX.DataProcessamento = Now.ToShortDateString
            'BoletoX.DataVencimento = dtVencBoleto.Value.ToShortDateString
            'BoletoX.ValorDocumento = valor
            'BoletoX.PadroesBoleto.Demonstrativo = "Boleto " & adiciona_zeros(intContador, 2) & "  da fatura " &
            'adiciona_zeros(fatura.id_filial, 4) & "-" & adiciona_zeros(fatura.cod_fatura, 6) & " Pedidos: " & pedidos()
            If intProtesto > 0 Then
                '   BoletoX.PadroesBoleto.InstrucoesCaixa = "<br>Juros .....: 5,00 % ao mês." &
                '  "<br>Multa.... de 1,00 % após 1 dia corrido do vencimento." &
                ' "<br>Protesto...: 5 dias úteis a partir do vencimento."
                'intDiasProtesto = 5
            Else
                'BoletoX.PadroesBoleto.InstrucoesCaixa = "<br>Juros .....: 5,00 % ao mês." &
                '"<br>Multa.... de 1,00 % após 1 dia corrido do vencimento." &
                '"<br>Sr. caixa receber até 15 dias após o vencimento."
                'intDiasProtesto = 0
            End If

            'CobreBemX.CalcularDadosBoletos()
            'nossonumero = BoletoX.NossoNumero

            'Monta o código de barra e retira os pontos e espaços para gravação no banco de dados
            'codigobarra = BoletoX.CodigoBarras
            'linhadigitavel = BoletoX.LinhaDigitavel.ToString.Replace(".", "")
            'linhadigitavel = linhadigitavel.ToString.Replace(" ", "")

            intNossoNumero = nossonumero

            'Instrução responsável por gravar as informações do boleto no banco de dados
            lancaBoletoManualNovo()
            intNossoNumero = 1 'nossonumero.ToString.Substring(7, 10)
            'Atualiza a sequencia do nosso número para gravar o próximo nosso número
            datacaixa.atualiza_registros("Controle", "nossonumero = " & intNossoNumero, False)
        Next

        'Se a váriavel intImprimir for igual a 1 gera o boleto bancário para impressão, caso seja igua a 0 o boelto não será gerado
        'impressão nesse momento, podendo ser impresso depois no menu Financeiro - Imprime Boleto
        If intImprimir = 1 Then
            'CobreBemX.ImprimeBoletos()
        End If

        'Limpa o objeto CobreBemX
        CobreBemX = Nothing
        intData = 0
    End Sub


    Private Sub carregaDadosCliente(ByVal codcliente As Integer)
        Try
            Dim strSQL As String = "SELECT * FROM CLIENTE WHERE COD_CLIENTE = " & codcliente
            d.conecta()
            d.carrega_ds(strSQL, dsCliente)
            ttCliente = dsCliente.Tables(0)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        If cbForma.SelectedValue = 8 Then
            If datacaixa.convertedata(dtVenc.Value.ToShortDateString) < datacaixa.convertedata(datacaixa.retornaDataHoraServidor) Then
                MessageBox.Show("Data de vencimento não pode ser inferior a data atual.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If datacaixa.convertedata(dtVenc.Value.ToShortDateString) = datacaixa.convertedata(datacaixa.retornaDataHoraServidor) Then
                MessageBox.Show("Data de vencimento não pode ser igual a data atual.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If

        If cbForma.SelectedValue = 1 Or cbForma.SelectedValue = 7 Then
            If datacaixa.convertedata(dtVenc.Value.ToShortDateString) < datacaixa.convertedata(datacaixa.retornaDataHoraServidor) Then
                MessageBox.Show("Data de vencimento não pode ser inferior a data atual.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If


        If CDbl(txtValor.Text) > CDbl(txtaPagar.Text) Then
            MessageBox.Show("Valor pago não pode ser maior que o valor da fatura.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If txtValor.Text = "" Then
            MessageBox.Show("Preenchar o valor a ser recebido.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If cbForma.SelectedValue <> 7 Then
            If (fatura.valor_restante_pacote <> 0) And (cbForma.SelectedValue <> 9) Then
                MsgBox("Escolha o pacote")
                Exit Sub
            End If
        End If

        If MessageBox.Show("Deseja faturar esse pedido?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim parcela As Integer = 1
            Dim parcelas As Int16 = CInt(txtNparcelas.Text)

            Dim vTotalProduto As Double = Convert.ToDecimal(txtTotalProd.Text)
            Dim vTotalServico As Double = Convert.ToDecimal(txtTotalServ.Text)
            Dim vAcrescimo As Double = Convert.ToDecimal(txtAcrescimo.Text)
            Dim vDesconto As Decimal = Convert.ToDecimal(txtDesconto.Text)
            'Dim vTotalFatura As Decimal = Convert.ToDecimal(txtTotalFatura.Text) / parcelas
            Dim vAPagar As Decimal = ((vTotalProduto + vTotalServico + vAcrescimo) - vDesconto) / parcelas
            txtaPagar.Text = vAPagar
            Dim vPago As Decimal = Convert.ToDecimal(txtValor.Text) / parcelas

            Dim dataVecimento As DateTime = dtVenc.Value
            Dim intervaloDias As Integer = Convert.ToInt32(txtDias.Text)
            'Dim CRED As New objCreditoCliente
            'Dim boleto As New objBoleto(objPagamento.tipo_pagamento.Fatura)
            'Dim total As Double = Convert.ToDecimal(txtValor.Text)
            Dim valor As Double = Convert.ToDecimal(txtValor.Text) / parcelas
            'Dim Ult As Double = Format((total) - (valor * (par - 1)), "#,##0.00")

            'Dim dataBaseAcresDesc As String = datacaixa.convertedata(dtVenc.Value)
            ' Dim dataAcrescimo As String = datacaixa.convertedata(datacaixa.retornaDataAcrescimo(CInt(lblFatura.Text), CInt(lblFilial.Text), dataBaseAcresDesc))
            ' Dim valorAcrescimo As Double = datacaixa.retornaValorAcrescimo(CInt(lblFatura.Text), CInt(lblFilial.Text), dataAcrescimo)

            'Dim dataDesconto As String = datacaixa.convertedata(datacaixa.retornaDataDesconto(CInt(lblFatura.Text), CInt(lblFilial.Text), dataBaseAcresDesc))
            'Dim valorDesconto As Double = datacaixa.retornaValorDesconto(CInt(lblFatura.Text), CInt(lblFilial.Text), dataDesconto)

            'If dataAcrescimo = datacaixa.convertedata(dtVenc.Value) Then
            'f CDbl(valorAcrescimo) > 0.0 Then
            'Ult = CDbl(txtValor.Text)
            'End If
            'End If

            'If dataDesconto = datacaixa.convertedata(dtVenc.Value) Then
            ' If CDbl(valorDesconto) > 0.0 Then
            ' Ult = CDbl(txtValor.Text)
            ' End If
            ' End If

            'If dataDesconto = datacaixa.convertedata(dtVenc.Value) Then
            'If CDbl(valorDesconto) > 0.0 And CDbl(valorAcrescimo) > 0.0 Then
            'Ult = CDbl(txtValor.Text)
            'End If
            'End If


            Dim valorpacote As Double
            For Each item As DataGridViewRow In grdRec.Rows
                If item.Cells(1).Value = "Crédito Pacote" Then
                    valorpacote = CDbl(item.Cells(2).Value)
                End If
            Next

            'Crédito Pacote
            ' If cbForma.SelectedValue = 11 Then
            'Dim us As New objUsuario
            'Dim _valor, restante As Double
            'MsgBox("Crédito disponível: " & CRED.Saldo_anterior(fatura.cod_filial_cliente, fatura.cod_cliente))
            '_valor = CDbl(txtValor.Text)
            'restante = CDbl(fatura.valor_restante_pacote)
            'If _valor > restante Then
            'AVISO("O valor de produtos e serviços de pacote restante na fatura é de " &
            'cdinShow(fatura.valor_restante_pacote) & "! Só produtos e serviços de pacote podem utilizar" &
            '       " créditos de pacote na fatura", Me, frmAviso.tipo_aviso.tipo_ok, True)
            'Exit Sub
            'End If
            'If CDbl(txtValor.Text) > CRED.Saldo_anterior(fatura.cod_filial_cliente, fatura.cod_cliente) Then
            'AVISO("Credito insuficiente", Me, frmAviso.tipo_aviso.tipo_ok, True)
            't Sub
            'End If
            '19 Operações com crédito
            '   If us.login(Me).StartsWith("ER") Then
            '  AVISO("Problemas com Login!", Me, frmAviso.tipo_aviso.tipo_ok, True)
            ' Exit Sub
            'Else
            '   If us.acesso(19) = False Then
            '  AVISO("Usuário não tem acesso a operações de Crédito!", Me, frmAviso.tipo_aviso.tipo_ok, True)
            ' Exit Sub
            'End If
            'End If
            'CRED.novo()
            'CRED.cod_filial_cliente = fatura.cod_filial_cliente
            'CRED.cod_cliente = fatura.cod_cliente
            'CRED.credito = CDbl(txtValor.Text) * -1
            'CRED.historico = "Abatimento de crédito na Fatura: " & adiciona_zeros(fatura.id_filial, 4) & "-" & _
            'adiciona_zeros(fatura.cod_fatura, 6) & _
            '" Pedidos: " & pedidos()
            'CRED.data = Now
            'CRED.id_usuario = us.cod_usuario
            'CRED.Salvar()
            'While parcela <= parcelas
            'lanc.novo_lancamento()
            'lanc.data_lancamento = datacaixa.retornaDataHoraServidor()
            'lanc.data_vencimento = dataVecimento
            'lanc.cod_fatura = fatura.cod_fatura
            'lanc.id_filial = fatura.id_filial
            'lanc.id_filial_lancamento = conf.Filial
            'lanc.cod_conta = 51
            'lanc.cod_forma_pagamento = cbForma.SelectedValue
            'lanc.data_recebimento = datacaixa.retornaDataHoraServidor
            'lanc.historico = "Receb. da fatura " & adiciona_zeros(fatura.id_filial, 4) & "-" &
            'adiciona_zeros(fatura.cod_fatura, 6) &
            '" Pedidos: " & pedidos()
            'lanc.n_parcela = parcela
            'lanc.n_parcelas = txtNparcelas.Text
            'lanc.tipo = "E"
            'lanc.valor = valor
            'lanc.cod_fatura_lanc = fatura.cod_fatura
            'lanc.acrescimo_novo = 0.0
            'lanc.juros_novo = 0.0
            'lanc.desconto_novo = 0.0
            'lanc.taxas = 0.0
            'lanc.salva_pag()
            'parcela = parcela + 1
            'dataVecimento = DateAdd(DateInterval.Day, intervaloDias, dataVecimento)
            'End While

            'GoTo fim
            'End If
            '   Dim vPacote As Double = 0
            '  Dim vTotal As Double = 0
            ' Dim vDif As Double = 0
            'Dim vPago As Double = 0
            'vPacote = fatura.valor_itens_pacote + fatura.valor_servicos_pacote
            'vTotal = CDbl(txtTotalFatura.Text)
            'vPago = CDbl(txtValor.Text)
            'vDif = FormatCurrency(vTotal - vPacote + CDbl(txtAcrescimo.Text), 2)
            ' If vPacote > 0 Then
            'If vPago > vDif Then
            'AVISO("O valor de produtos que não pertence a pacote na fatura é de " &
            'cdinShow(CDbl(txtTotalFatura.Text) - fatura.valor_itens_pacote) & "! Itens de pacote " &
            '  "devem ser pagos com créditos de pacote!", Me, frmAviso.tipo_aviso.tipo_ok, True)
            'it Sub
            'End If
            'End If
            'Crédito Cliente
            'If cbForma.SelectedValue = 6 Then
            'Dim us As New objUsuario
            'MsgBox(CRED.Saldo_anterior(fatura.cod_filial_cliente, fatura.cod_cliente))
            'If CDbl(txtValor.Text) > CRED.Saldo_anterior(fatura.cod_filial_cliente, fatura.cod_cliente) Then
            'AVISO("Credito insuficiente", Me, frmAviso.tipo_aviso.tipo_ok, True)
            'xit Sub
            'End If
            '19 Operações com crédito
            'If us.login(Me).StartsWith("ER") Then
            'O("Problemas com Login!", Me, frmAviso.tipo_aviso.tipo_ok, True)
            ' Exit Sub
            ' Else
            'If us.acesso(19) = False Then
            'AVISO("Usuário não tem acesso a operações de Crédito!", Me, frmAviso.tipo_aviso.tipo_ok, True)
            'Exit Sub
            'End If
            'End If
            'CRED.novo()
            'CRED.cod_filial_cliente = fatura.cod_filial_cliente
            'CRED.cod_cliente = fatura.cod_cliente
            'CRED.credito = CDbl(txtValor.Text) * -1
            'CRED.historico = "Abatimento de crédito na Fatura: " & adiciona_zeros(fatura.id_filial, 4) & "-" & _
            ''adiciona_zeros(fatura.cod_fatura, 6) & _
            '" Pedidos: " & pedidos()
            'CRED.data = Now
            'CRED.id_usuario = us.cod_usuario
            'CRED.Salvar()
            ' lanc.novo_lancamento()
            'lanc.data_lancamento = Conexao.RetornaDataServidor
            'lanc.data_vencimento = dataVecimento
            'anc.cod_fatura = fatura.cod_fatura
            'lanc.id_filial = fatura.id_filial
            'nc.id_filial_lancamento = conf.Filial
            'lanc.cod_conta = 51
            'lanc.cod_forma_pagamento = cbForma.SelectedValue
            'lanc.data_recebimento = datacaixa.retornaDataHoraServidor
            'lanc.historico = "Receb. da fatura " & adiciona_zeros(fatura.id_filial, 4) & "-" & _
            'ciona_zeros(fatura.cod_fatura, 6) & _
            ' " Pedidos: " & pedidos()
            'c.cod_filial_cliente = fatura.cod_filial_cliente
            'lanc.cod_cliente = fatura.cod_cliente
            'c.n_parcela = parc
            'lanc.n_parcelas = txtNparcelas.Text
            'lanc.tipo = "E"
            'lanc.valor = valor
            'lanc.cod_fatura_lanc = fatura.cod_fatura
            'lanc.acrescimo_novo = 0.0
            'c.juros_novo = 0.0
            'lanc.desconto_novo = 0.0
            'lanc.taxas = 0.0
            'lanc.salva_pag()
            'parc = parc + 1
            'dataVecimneto = DateAdd(DateInterval.Day, 30, dataVecimneto)
            'GoTo fim
            ' If

            If cbForma.SelectedValue = 8 Then
                    'For intContador = 1 To CInt(txtNparcelas.Text)
                    If MessageBox.Show("Deseja gerar o boleto agora?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        If MessageBox.Show("Deseja que o título seja protestado?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            intProtesto = 1
                        Else
                            intProtesto = 0
                        End If

                        intImprimir = 1
                        montaBoleto()
                    Else
                        intImprimir = 0
                        montaBoleto()
                    End If
                    GoTo fim
                End If

                While parcela <= parcelas
                    Lancamento.Novo()
                    Lancamento.CodigoCliente = fatura.cod_cliente
                    Lancamento.DataLancamento = datacaixa.retornaDataHoraServidor()

                    Lancamento.CodigoConta = 101

                Lancamento.CodigoFormaPag = cbForma.SelectedValue
                Lancamento.NumeroParcelas = parcelas
                Lancamento.NumeroParcela = parcela
                Lancamento.DataVencimento = DateAdd(DateInterval.Day, intervaloDias, dataVecimento)

                If cbForma.SelectedValue = 1 Or cbForma.SelectedValue = 2 _
            Or cbForma.SelectedValue = 4 Or cbForma.SelectedValue = 5 Or cbForma.SelectedValue = 7 Then
                        Lancamento.DataRecebimento = datacaixa.retornaDataHoraServidor
                    End If

                    Lancamento.Tipo = "E"
                    Lancamento.CodigoStatusLanc = 1
                    Lancamento.CodigoFatura = fatura.cod_fatura

                    If vDesconto > 0 Then
                        If grdRec.Rows.Count = 0 Then
                            Lancamento.ValorPago = vPago + vDesconto
                        Else
                            Lancamento.ValorPago = vPago
                            vDesconto = 0
                        End If
                    ElseIf vAcrescimo > 0 Then
                        Lancamento.ValorPago = vPago - vAcrescimo
                    Else
                        Lancamento.ValorPago = vPago
                    End If

                    Lancamento.Acrescimo = vAcrescimo
                    Lancamento.Desconto = vDesconto
                    Lancamento.Juros = 0.0
                    Lancamento.Taxa = 0.0

                    If fatura.Historico_Desc_Texto <> String.Empty Then
                        Lancamento.Historico = fatura.Historico_Desc_Texto
                    Else
                        Lancamento.Documento = "Receb. da fatura " & adiciona_zeros(fatura.id_filial, 4) & "-" &
                adiciona_zeros(fatura.cod_fatura, 6) &
                " Pedidos: " & pedidos()
                    End If

                    Lancamento.CodigoFilial = fatura.id_filial
                    Lancamento.CodigoFilialLancamento = conf.Filial

                    Lancamento.UsuarioLanc = intUsuario
                    Lancamento.UsuarioAlt = 0

                    Lancamento.TotalFatura = Convert.ToDecimal(txtTotalFatura.Text)
                    Lancamento.TipoPag = "Fatura"

                    If Lancamento.SalvaPagamento = True Then
                        MovimentaEstoque()
                        RegraPagamento()
                        RegraDesconto()
                        EmiteCupom()
                    End If

                    'If Lancamento.SalvaLancamento() = "OK" Then
                    'MovimentaEstoque()
                    'RegraPagamento()
                    'RegraDesconto()
                    'EmiteCupom()
                    'End If

                    parcela = parcela + 1
                    dataVecimento = DateAdd(DateInterval.Day, intervaloDias, dataVecimento)
                End While

fim:

            End If

            Lista_Rec()

        mostraPedidoFatura()
        DesativaControle()

        'fim do novo
    End Sub

    Private Sub frmFatura_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If intTipoCliente = 1 Then
            If grdRec.Rows.Count = 0 Then
                If intControle = 0 Then
                    If grdItens.Rows.Count > 1 Then
                        MessageBox.Show("Como não há registro de recebimento nesta fatura" & Chr(13) & "os pedidos da fatura ficaram em aberto.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Como não há registro de recebimento nesta fatura" & Chr(13) & "o pedido da fatura ficará em aberto.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                    For Each linha As DataGridViewRow In grdItens.Rows
                        Dim strSQL As String = "select num_pedido, cod_status_pedido from pedidos where num_pedido = " & linha.Cells(2).Value &
                        " and id_filial = " & fatura.id_filial & " and cod_cliente = " & fatura.cod_cliente

                        Dim ttPedido As New DataTable
                        ttPedido = datacaixa.retornaRegistro(strSQL).Tables(0)
                        If linha.Cells(2).Value = ttPedido.Rows(0)("num_pedido") Then
                            Dim strSQLAtualiza As String = "cod_status_pedido = " & ttPedido.Rows(0)("cod_status_pedido") &
                                ", valor_pago = 0.0, valor_apagar = 0.0 where num_pedido = " & linha.Cells(2).Value &
                                " and id_filial = " & fatura.id_filial & " and cod_cliente = " & fatura.cod_cliente
                            datacaixa.atualiza_registros("pedido_balcao", strSQLAtualiza, True)
                        End If
                    Next

                    cancelaFaturaItens(CInt(lblFatura.Text))
                    cancelaFatura(CInt(lblFatura.Text))
                    intControle = 1
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub cbForma_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbForma.SelectionChangeCommitted
        If (cbForma.SelectedValue = 1) Or (cbForma.SelectedValue = 2) Or (cbForma.SelectedValue = 4) Or (cbForma.SelectedValue = 7) Then
            txtNparcelas.Enabled = False
            txtNparcelas.Text = 1
        Else
            txtNparcelas.Text = 1
            txtNparcelas.Enabled = True
        End If
    End Sub


    Private Sub RegraPagamento()
        Dim diferenca As Decimal = 0
        Dim strSQL As String = String.Empty

        Dim tbFaturaPedidos As New DataTable()
        tbFaturaPedidos = fatura.lista_itens_fatura_teste()

        Dim sit, i As Integer
        Dim qtde As Integer = tbFaturaPedidos.Rows.Count
        Dim vDividido, vSobra, vDif, vSoma, vPago, vAPagar, vAcrescimo, vDesconto As Decimal
        vAcrescimo = Convert.ToDecimal(txtAcrescimo.Text)
        vDesconto = Convert.ToDecimal(txtDesconto.Text)
        If vDesconto > 0 Then
            vDividido = (Convert.ToDecimal(txtValor.Text) + vDesconto) / qtde
        ElseIf vAcrescimo > 0 Then
            vDividido = (Convert.ToDecimal(txtValor.Text) - vAcrescimo) / qtde
        Else
            vDividido = Convert.ToDecimal(txtValor.Text) / qtde
        End If


        For Each linha As DataRow In tbFaturaPedidos.Rows
            Dim tbPedido As New DataTable
            strSQL = "select valor_pago from pedido_balcao where num_pedido = " & linha("num_pedido") & " and id_filial = " & linha("id_filial")
            Conexao.CarregaTabela(strSQL, tbPedido)

            If tbPedido.Rows(0)("valor_pago") = 0 Then
                If vDividido > Convert.ToDecimal(linha("totalgeral")) Then
                    vPago = Convert.ToDecimal(linha("totalgeral"))
                    vSobra = vDividido - Convert.ToDecimal(linha("totalgeral"))
                    vDividido = vDividido + vSobra
                    vAPagar = 0
                    sit = 3
                    i = i + 1
                ElseIf vDividido < Convert.ToDecimal(linha("totalgeral")) Then
                    vPago = vDividido
                    vAPagar = Convert.ToDecimal(linha("totalgeral")) - vPago
                    sit = 5
                Else
                    vPago = Convert.ToDecimal(linha("totalgeral"))
                    vAPagar = 0
                    sit = 3
                    i = i + 1
                End If
            End If

            If tbPedido.Rows(0)("valor_pago") > 0 Then
                vSoma = tbPedido.Rows(0)("valor_pago") + vDividido
                If vSoma > Convert.ToDecimal(linha("totalgeral")) Then
                    vDif = vSoma - Convert.ToDecimal(linha("totalgeral"))
                    vPago = Convert.ToDecimal(linha("totalgeral"))
                    vDividido = vDividido + vDif
                    vAPagar = 0
                    sit = 3
                    i = i + 1
                ElseIf vSoma < Convert.ToDecimal(linha("totalgeral")) Then
                    vPago = vSoma
                    vAPagar = Convert.ToDecimal(linha("totalgeral")) - vPago
                    sit = 5
                Else
                    vPago = Convert.ToDecimal(linha("totalgeral"))
                    vAPagar = 0
                    sit = 3
                    i = i + 1
                End If
            End If

            strSQL = "update pedido_balcao set valor_pago = " & Geral.ValorMoeda(vPago.ToString()) & "," &
            "valor_apagar = " & Geral.ValorMoeda(vAPagar.ToString()) & "," &
            "cod_status_pedido = " & sit & " where num_pedido = " & linha("num_pedido") &
                " And id_filial = " & linha("id_filial")
            Conexao.SalvaAtualizaExcluiReg(strSQL)

            If i = tbFaturaPedidos.Rows.Count Then
                strSQL = "update fatura set cod_status_fatura = 2 where cod_fatura = " & fatura.cod_fatura & " And id_filial = " & fatura.id_filial
                Conexao.SalvaAtualizaExcluiReg(strSQL)
            End If

        Next

    End Sub

    Private Sub EmiteCupom()
        If MessageBox.Show("Deseja emitir o cupom fiscal agora?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            Dim strSQL As String = ""

            strSQL = "select cod_tabela,nome_lente, preco, preco_tab ,sum(((preco_tab * desconto)/100) * quant) as valordesconto, sum(quant) as quant, produto, cod_produto, ncm, gtin, unidade, " &
                "sum(preco * quant) as total from lista_itens_fatura_nfe(" & Convert.ToInt32(lblFatura.Text) & "," & Convert.ToInt32(lblFilial.Text) &
                ") group by cod_tabela, nome_lente, preco, preco_tab, desconto, quant, produto, cod_produto, ncm, gtin, unidade"

            Dim tbNFe As New DataTable()

            Conexao.CarregaTabela(strSQL, tbNFe)

            Dim vBICMSTotal As Decimal = 0.00
            Dim vICMSTotal As Decimal = 0.0
            Dim vBICMSSubTotal As Decimal = 0.0
            Dim vICMSSubTotal As Decimal = 0.0
            Dim vProdutosTotal As Decimal = 0.0
            Dim vServicoTotal As Decimal = 0.0
            Dim vDescontoTotal As Decimal = 0.0
            Dim vIPITotal As Decimal = 0.0
            Dim vPISTotal As Decimal = 0.0
            Dim vCOFINSTotal As Decimal = 0.0
            Dim vBISSTotal As Decimal = 0.0
            Dim vISSTotal As Decimal = 0.0
            Dim vNotaTotal As Decimal = 0.0
            Dim vImpostoTotal As Decimal = 0.0
            Dim i As Integer
            Dim retorno As Boolean = False

            Dim strModeloNota As Int32

            strModeloNota = emitente.ModeloNFCe

            '==========CABEÇALHO NFE==========
            dadosNFe.Emitente = emitente.CnpjCpf
            dadosNFe.NumeroDocFiscal = Convert.ToInt32(emitente.NumeroNFCe)
            op.RetornaRegistro(1)
            dadosNFe.NaturezaOperacao = op.CodigoNatureza
            dadosNFe.Serie = Convert.ToInt32(1)

            dadosNFe.Modelo = emitente.ModeloNFCe
            dadosNFe.TipoNFe = op.TipoNFe
            dadosNFe.DataEmissao = DateTime.Now
            dadosNFe.CodigoFilial = conf.Filial
            dadosNFe.CodigoCliente = fatura.cod_cliente
            dadosNFe.ConsumidorFinal = op.ConsumidorFinal
            'dadosNFe.Observacao = txtObservacao.Text
            dadosNFe.SituacaoNFe = "D" 'D = em digitação
            dadosNFe.DestinoOperacao = op.DestinoOperacao 'Identificador de local de destino da operação / 1 = OP. Interna / 2= Op. Interestadual / 3 = Op. Ext
            dadosNFe.ConsumidorPresente = op.ConsumidorPresente 'Indicador de presença do comprador no estabelecimento comercial

            dadosNFe.Documento = Convert.ToInt32(fatura.cod_fatura)
            dadosNFe.OrigemDoc = "F"

            dadosNFe.CanceladoUsuario = 0
            dadosNFe.TipoFatura = "A" 'A = Automática / M = Manual
            dadosNFe.Frete = 9

            Select Case cbForma.SelectedValue
                Case 1, 2, 4
                    dadosNFeCobranca.TipoPagamento = 0
                Case Else
                    dadosNFeCobranca.TipoPagamento = 1
            End Select

            ClienteOt.FiltraCliente(fatura.cod_cliente)
            dadosNFe.FilialDocumento = conf.Filial
            dadosNFe.FilialCliente = ClienteOt.CodigoFilial
            dadosNFe.FinaldiadeNota = op.FinalidadeNota

            'Dim strSQLExisteNFe As String = "select 1 from nfe where emitente = '" & emitente.CnpjCpf & "' and numero = " & Convert.ToInt32(txtNumeroNFE.Text) &
            '       " and serie = " & Convert.ToInt32(txtSerie.Text) & " and modelo = " & strModeloNota & ""

            If dadosNFe.SalvaNFe() = True Then
                emitente.AtualizaNumeroNota("NFCe")
            End If

            '==========FIM CABEÇALHO NFE==========


            '==========DADOS DE COBRANÇA==========
            dadosNFeCobranca.Emitente = emitente.CnpjCpf
            dadosNFeCobranca.NumeroNFe = emitente.NumeroNFCe
            dadosNFeCobranca.Serie = emitente.SerieNFCe
            dadosNFeCobranca.Modelo = emitente.ModeloNFCe

            If cbForma.SelectedValue.ToString().Length = 1 Then
                dadosNFeCobranca.MeioPagamento = "0" & cbForma.SelectedValue
            Else
                dadosNFeCobranca.MeioPagamento = cbForma.SelectedValue
            End If

            dadosNFeCobranca.SalvaCobrancaNFe()

            '==========FIM DADOS COBRANÇA==========

            '===========DADOS ITEM NOTA============
            For Each linha As DataRow In tbNFe.Rows
                Dim qCom As Double = CDbl(linha("quant"))
                Dim vUnitarioTrib As Decimal = Convert.ToDecimal(linha("preco_tab")) 'Valor unitário que realmente será tributado
                Dim vProduto As Decimal = 0.0
                Dim vServicoItem As Decimal = 0.0
                Dim pICMSItem As Decimal = 0.00
                Dim bICMSItem As Decimal = 0.0
                Dim vICMSItem As Decimal = 0.0
                Dim pICMSSubItem As Decimal = 0.0
                Dim bICMSSubItem As Decimal = 0.0
                Dim vICMSSubItem As Decimal = 0.0
                Dim pIPIItem As Decimal = 0.0
                Dim bIPIItem As Decimal = 0.0
                Dim vIPIItem As Decimal = 0.0
                Dim pPISItem As Decimal = 0.0
                Dim bPISItem As Decimal = 0.0
                Dim vPISItem As Decimal = 0.0
                Dim pCofinsItem As Decimal = 0.0
                Dim bCOFINSItem As Decimal = 0.0
                Dim vCofinsItem As Decimal = 0.0
                Dim pISSItem As Decimal = 0.0
                Dim bISSItem As Decimal = 0.0
                Dim vISSItem As Decimal = 0.0
                Dim pReducaoItem As Decimal = 0.0
                Dim MargemSTItem As Decimal = 0.0
                Dim ReducaoSTItem As Decimal = 0.0
                Dim vImpostoItem As Decimal = 0.0
                Dim vDescontoItem As Decimal = 0.0
                Dim vNotaItem As Decimal = 0.0
                Dim codigoEan As String = linha("gtin").ToString().Trim()

                i += 1
                '////////////Detalhamento de Produtos e Serviços da NF-e///////////////
                dadosNFeItem.Emitente = emitente.CnpjCpf
                dadosNFeItem.NumeroDocFiscal = emitente.NumeroNFCe
                dadosNFeItem.Serie = emitente.SerieNFCe

                dadosNFeItem.Modelo = emitente.ModeloNFCe

                cst.RetornaRegistro(op.CodigoNatureza)

                dadosNFeItem.Item = i
                dadosNFeItem.ProdutoCodigo = CInt(linha("cod_produto"))

                dadosNFeItem.Quantidade = qCom
                dadosNFeItem.ValorUnitario = vUnitarioTrib
                vProduto = qCom * vUnitarioTrib
                vDescontoItem = Convert.ToDecimal(linha("valordesconto"))
                dadosNFeItem.VDesconto = vDescontoItem

                'vNotaItem = vProduto
                vProduto = vProduto - vDescontoItem

                dadosNFeItem.CFOP = datacaixa.so_numeros(cst.CFOP)
                dadosNFeItem.NCM = CInt(linha("ncm"))
                dadosNFeItem.Origem = cst.CodigoOrigemMercadoria
                dadosNFeItem.Unidade = linha("unidade").ToString().Trim()

                dadosNFeItem.ModBC = cst.ModBC

                '////////////ICMS///////////////
                'If emitente.CRT = 1 Then 'Grupo de tributação do ICMS 00
                dadosNFeItem.CST = cst.CSOSN
                pICMSItem = cst.PIcms
                dadosNFeItem.PICMS = pICMSItem

                If emitente.CRT = 1 Then
                    bICMSItem = 0
                Else
                    bICMSItem = vProduto
                End If

                dadosNFeItem.BICMS = bICMSItem
                vICMSItem = (pICMSItem * bICMSItem) / 100
                dadosNFeItem.VICMS = vICMSItem
                'End If

                '////////////PIS///////////////
                'Caso o código CST seja 1 ou 2 será cálculado o PIS de cada um produto
                'Caso o CST seja 7 será isento do PIS
                If cst.CST_PIS = "01" Or cst.CST_PIS = "02" Then
                    dadosNFeItem.CSTPIS = cst.CST_PIS
                    pPISItem = cst.PPIS
                    dadosNFeItem.PPIS = pPISItem
                    vPISItem = (vProduto * pPISItem) / 100
                    dadosNFeItem.VPIS = vPISItem
                    bPISItem = vProduto
                    dadosNFeItem.BPIS = bPISItem
                ElseIf cst.CST_PIS = "07" Or cst.CST_PIS = "49" Then
                    dadosNFeItem.CSTPIS = cst.CST_PIS 'Código de situação tributária do PIS
                End If

                '////////////COFINS///////////////
                'Caso o código CST seja 1 ou 2 será cálculado o COFINS de cada um produto
                'Caso o CST seja 7 será isento do COFINS
                If cst.CST_COFINS = "01" Or cst.CST_COFINS = "02" Then
                    dadosNFeItem.CSTCOFINS = cst.CST_COFINS
                    pCofinsItem = cst.PCOFINS
                    dadosNFeItem.PCOFINS = pCofinsItem
                    vCofinsItem = (vProduto * pCofinsItem) / 100
                    dadosNFeItem.VCOFINS = vCofinsItem
                    bCOFINSItem = vProduto
                    dadosNFeItem.BCOFINS = bCOFINSItem
                ElseIf cst.CST_COFINS = "07" Or cst.CST_COFINS = "49" Then
                    dadosNFeItem.CSTCOFINS = cst.CST_COFINS 'Código de situação tributária do PIS
                End If

                'Instrução responsável por gravar as informações da operação na tabela NFe_Item, necessária para uma posterior averiguação de envio
                'da NFe, só mexer nessa instrução quando houver acrescimo de novos campos na tabela ou mudanção de nome das variáveis referente a 
                'inclução de informação na tabela em questão.
                vImpostoItem = (vICMSItem + vPISItem + vCofinsItem)
                dadosNFeItem.VImposto = vImpostoItem


                vNotaTotal = vNotaTotal + vProduto 'vNotaItem
                vBICMSTotal = vBICMSTotal + bICMSItem
                vICMSTotal = vICMSTotal + vICMSItem
                vBICMSSubTotal = vBICMSSubTotal + bICMSSubItem
                vICMSSubTotal = vICMSSubTotal + vICMSSubItem
                vProdutosTotal = vProdutosTotal + vProduto
                vServicoTotal = vServicoTotal + vServicoItem
                vDescontoTotal = vDescontoTotal + vDescontoItem
                vBISSTotal = vBISSTotal + bISSItem
                vISSTotal = vISSTotal + vISSItem
                vIPITotal = vIPITotal + vIPIItem
                vPISTotal = vPISTotal + vPISItem
                vCOFINSTotal = vCOFINSTotal + vCofinsItem
                vImpostoTotal = vImpostoTotal + vImpostoItem

                dadosNFeItem.FlagIPI = 0

                Dim strSQLExisteNFeItem As String = "select 1 from nfe_item where emitente = '" & emitente.CnpjCpf & "' and numero = " & Convert.ToInt32(emitente.NumeroNFCe) &
                    " and serie = " & Convert.ToInt32(emitente.SerieNFCe) & " and modelo = " & strModeloNota & " and item = " & i

                If Conexao.VerificaExistenciaReg(strSQLExisteNFeItem) = 0 Then
                    dadosNFeItem.SalvaNFeItem()
                Else
                    dadosNFeItem.AtualizaNFeItem()
                End If

            Next

            dadosNFe.ValorNota = vNotaTotal
            dadosNFe.BaseICMS = vBICMSTotal
            dadosNFe.ValorICMS = vICMSTotal
            dadosNFe.BaseICMSSub = vBICMSSubTotal
            dadosNFe.ValorICMSSub = vICMSSubTotal
            dadosNFe.ValorProdutos = vProdutosTotal
            dadosNFe.ValorServicos = vServicoTotal
            dadosNFe.Desconto = vDescontoTotal
            dadosNFe.BaseISS = vBISSTotal
            dadosNFe.ValorISS = vISSTotal
            dadosNFe.ValoIPI = vIPITotal
            dadosNFe.ValorPIS = vPISTotal
            dadosNFe.ValorCofins = vCOFINSTotal
            dadosNFe.ValorImpostos = vImpostoTotal

            dadosNFe.AtualizaNFeGerada()

            EnviaNota()

        End If
    End Sub

    Private Sub EnviaNota()
        Try
            SplashScreenManager1.ShowWaitForm()

            Dim tpAmbiente, tpImpressao, tpFin, tpEmis As Integer
            'Verifica se a DLL foi nicializazda, em caso negativo a DLL será inicializada
            If dllInicializada = False Then
                InicializacaoPadraoNF()
            End If

            oNFe.SetIdKeySistema(emitente.IdSistemaNFCe)
            oNFe.CodigoCSC = emitente.CodigoCSC
            tpImpressao = 4

            If emitente.Producao = True Then
                tpAmbiente = 1
            Else
                tpAmbiente = 2
            End If

            op.RetornaRegistro(1)

            tpFin = 1

            If emitente.WebService = "NORMAL" Then
                tpEmis = 1
            End If

            'Set de configurações de emissão: ambiente, impressão, finalidade, tipo de emisão
            oNFe.SetEnvironment(tpAmbiente, tpImpressao, tpFin, tpEmis)

            'Set do tipo de nota, entrada ou saida
            oNFe.SetTipoNota(op.TipoNFe)

            'Set do endereço no file system onde as NFe//s autorizadas serão armazenadas
            oNFe.EnderecoAutorizada = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Autorizada")

            'Define no numero de copias que serão impressas
            oNFe.SetNumeroCopias(1)

            'If emitente.Impressora <> String.Empty Then
            'oNFe.SelectPrinter = emitente.Impressora

            'Define se a DLL imprimirá diretamenta para a impressão Padrão do windows
            'oNFe.PrintToDefaultPrinter = True
            'End If


            oNFe.ClearParams()

            'No exemplo utlizado, existe somente 1 filtro
            '- um com o numero da Nota Fiscal no sistema
            'Os filtros devem ser alimentados na mesma ordem que eles foram criados
            'no ConfigExtractor

            'Adiciona o valor no filtro
            oNFe.AddParams(emitente.CnpjCpf) 'cnpjemitente
            oNFe.AddParams(dadosNFe.NumeroDocFiscal) 'numeronfe
            oNFe.AddParams(dadosNFe.CodigoCliente) 'codigocliente
            oNFe.AddParams(dadosNFe.FilialCliente) 'codigofilial
            oNFe.AddParams(dadosNFe.Modelo) 'modelo NF
            oNFe.AddParams(dadosNFe.Serie) 'Serie

            Dim retorno As IRetornoAutorizar = oNFe.Autorizar()

            Dim erros As IErroXSD() = oNFe.GetErroXSD()

            If erros IsNot Nothing AndAlso erros.Length > 0 Then
                For i As Integer = 0 To erros.Length - 1
                    MessageBox.Show(erros(i).Descricao, erros(i).Titulo, MessageBoxButtons.OK, MessageBoxIcon.[Error])
                Next
            End If

            If retorno.cStat = 100 Then
                'Se o cStat for igual a 100 isso indica que a nota foi autorizada com sucesso
                'nesse momento podemos armazenar todos os dados no sistema
                'retorno.ChaveNFe -> Chave da NFe
                'retorno.DataRecebimento -> Data da Autorização
                'retorno.Protocolo -> numero do protocolo
                'retorno.XMLProc -> XML da NF-e com o protocolo de autorização
                'retorno.PDF -> Binario com o PDF
                dadosNFe.Emitente = emitente.CnpjCpf
                dadosNFe.NumeroDocFiscal = emitente.NumeroNFCe
                dadosNFe.Serie = emitente.SerieNFCe
                dadosNFe.Modelo = emitente.ModeloNFCe

                dadosNFe.DataEmissao = retorno.DataRecebimento
                dadosNFe.SituacaoNFe = "N"
                dadosNFe.DataSaida = retorno.DataRecebimento
                dadosNFe.ChaveNFe = retorno.ChaveNFe
                dadosNFe.ProtocoloAutorizacao = retorno.Protocolo
                dadosNFe.DataProtocoloAut = retorno.DataRecebimento
                dadosNFe.Justificativa = retorno.xMotivo
                dadosNFe.NFeAssinadaXml = retorno.XMLProc
                dadosNFe.AtualizaNFeEnviada()

                'Dim teste = retorno.XMLProcSimplificado

                If emitente.Impressora <> String.Empty Then
                    oNFe.SelectPrinter = emitente.Impressora

                    'Define se a DLL imprimirá diretamenta para a impressão Padrão do windows
                    oNFe.PrintToDefaultPrinter = False
                Else
                    Dim iRetorno As Integer
                    iRetorno = Declaracoes.iCFImprimir_NFCe_Daruma(retorno.XMLProc, "", "", 48, 1)
                End If

                SplashScreenManager1.CloseWaitForm()

                MessageBox.Show("Cupom Fiscal autorizado com sucesso. Protocolo: " + retorno.Protocolo)

                'oNFe.ShowPrinterList()
                '    oNFe.ObterViewPdfNfeFromXML(dadosNFe.NFeAssinadaXml)

                'Verifica se deu erro no envio do email, como o email só em viando no caso da NF-e que autorizada
                'só é necessario veirificar aqui
                'esse erro não interfere no processo de autorização
                If Not String.IsNullOrEmpty(retorno.ErrorEnvioEmail) Then
                    MessageBox.Show("Erro no email: " & retorno.ErrorEnvioEmail)
                End If
            Else
                'Caso contrario indica qual foi o motivo da rejeição.
                SplashScreenManager1.CloseWaitForm()
                MessageBox.Show("Mensagem: " + retorno.xMotivo)
            End If
        Catch ex As ApplicationException
            SplashScreenManager1.CloseWaitForm()
            MessageBox.Show(ex.Message, "ApplicationException", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            SplashScreenManager1.CloseWaitForm()
            MessageBox.Show(String.Format("{0}", ex), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Function InicializacaoPadraoNF() As Boolean
        'Informa o local onde os caches serão mantidos, o cache é excencial para emissão
        'em contingencia. É interessante no caso do uso de IIS, separar o cache em pastas
        'diferentes entre as aplicações web, pois o cache de regras é por empresa.
        'oNFe.DebugLog = True
        oNFe.CacheFolder = AppDomain.CurrentDomain.BaseDirectory

        'Seta o IdKey Empresa, esta propriedade permite setar qual empresa vai emitir NFe
        'o uso dessa propriedade elimina o uso do arquivo Empresa.Config, este valor é encontrado no portal do iContNFe, no cadastro de empresas.
        oNFe.IdKeyEmpresa = emitente.IdEmpresa

        'Define que DLL esta em modo normal de emissão, esse modo não esta relacionado diretamente com a contingencia da NFe
        oNFe.Contingencia = False

        'Define se os erros serão //lançados// para o programa chamador
        'ou se eles retornarão na propriedade Error das interfaces de retorno
        'Se utilizado como True, o erro aparecerá no `On Erro Goto`
        oNFe.Throwable = True

        'Inicializa a DLL de InterOp
        oNFe.Start()

        dllInicializada = True
        Return dllInicializada
    End Function

    Private Sub MovimentaEstoque()
        Estoque.CodigoNatureza = 2
        Estoque.CodigoFilial = conf.Filial
        Estoque.Data = Now
        Estoque.Documento = "SAÍDA PELO RECEBIMENTO FATURA: " & Estoque.CodigoFilial & " - " & FaturaTeste.CodigoFatura
        Estoque.CodigoUsuario = Usuario.CodigoUsuario
        Estoque.Concluido = "S"
        Dim i As Integer
        Dim tb As DataTable
        For Each linha As DataGridViewRow In grdItens.Rows
            tb = New DataTable()

            Dim strSQL As String = "select * from pedido_balcao_itens where num_pedido = " & linha.Cells(2).Value & " and id_filial = " & conf.Filial

            Conexao.CarregaTabela(strSQL, tb)

            For Each dados As DataRow In tb.Rows
                i = i + 1
                Estoque.Item = i
                Estoque.CodigoMovimento = Estoque.CodigoMovimento
                Estoque.Codigoproduto = Convert.ToInt32(dados("cod_produto").ToString())
                Estoque.Desconto = Convert.ToDecimal(dados("desconto").ToString())
                Estoque.PrecoUnitario = Convert.ToDecimal(dados("compra").ToString())
                Estoque.Quantidade = Convert.ToDecimal(dados("quant").ToString()) * (-1)
                Estoque.EstoqueFisico = Estoque.RetornaSaldo - (Estoque.Quantidade * -1)
                Estoque.EstoqueFinanceiro = Estoque.PrecoUnitario * Estoque.EstoqueFisico
                Estoque.StatusMov = 0
                Estoque.PrecoVenda = Convert.ToDecimal(dados("preco").ToString())
                Estoque.DescontoVenda = Convert.ToDecimal(dados("desconto").ToString())
                Estoque.Historico = "Baixa de produto do Pedido " & dados("num_pedido").ToString() & " - " & dados("id_filial").ToString()
                Estoque.ICMS = 17
                Estoque.IPI = 0
                Estoque.DataLancamento = Now

                Dim strSQLControlaEstoque As String = "select controla_estoque from produtos where cod_produto = " & Estoque.Codigoproduto

                If Conexao.RetornaUltimoRegistro(strSQLControlaEstoque) = Convert.ToBoolean("True") Then
                    If Estoque.SalvaMovimentoMaster = True Then
                        Estoque.SalvaMovimentaEstoque()
                    End If
                End If
            Next

        Next
    End Sub

    Private Sub RegraDesconto()
        Dim vDesconto As Decimal = Convert.ToDecimal(txtDesconto.Text)
        Dim vDescontoRateado As Decimal = 0
        Dim vDescontoAcumulado As Decimal = 0
        Dim vDescontoDado As Decimal = 0
        Dim vAtual As Decimal = 0
        Dim tb As New DataTable
        Dim i, j As Integer

        If vDesconto > 0.0 Then
            For Each linha As DataGridViewRow In grdItens.Rows
                Dim strSQL As String = "select sum(quant) as quant from pedido_balcao_itens where num_pedido = " & linha.Cells(2).Value & " and id_filial = " & lblFilial.Text
                Conexao.CarregaTabela(strSQL, tb)

                i = i + tb.Rows(0)("quant")
            Next

            vDescontoRateado = vDesconto / i

            For Each linha As DataGridViewRow In grdItens.Rows
                Dim strSQL As String = "select * from pedido_balcao_itens where num_pedido = " & linha.Cells(2).Value & " and id_filial = " & lblFilial.Text
                Conexao.CarregaTabela(strSQL, tb)

                j = j + 1

                For Each dados As DataRow In tb.Rows
                    PedidoItem.AtualizaPrecoItemFatura(dados("num_pedido"), dados("id_filial"), dados("item"), dados("cod_produto"), dados("preco"))

                    j = j + 1
                    If i = j Then
                        vDescontoAcumulado = String.Format("{0:##0.00}", vDescontoAcumulado + vDescontoRateado)
                        vAtual = String.Format("{0:##0.00}", Convert.ToDecimal(dados("preco")) - (vDesconto - vDescontoAcumulado))
                    Else
                        vDescontoAcumulado = String.Format("{0:##0.00}", vDescontoAcumulado + vDescontoRateado)
                        vAtual = String.Format("{0:##0.00}", Convert.ToDecimal(dados("preco")) - vDescontoRateado)
                    End If

                    vDescontoDado = 100 - String.Format("{0:##0.00}", ((vAtual / Convert.ToDecimal(dados("preco_tab"))) * 100))

                    PedidoItem.AtualizaPrecoItemDescFatura(dados("num_pedido"), dados("id_filial"), dados("item"), dados("cod_produto"), vAtual, vDescontoDado)
                Next
            Next
        End If

    End Sub

    Private Sub btnRecibo_Click(sender As Object, e As EventArgs) Handles btnRecibo.Click
        Dim f As New frmRpt
        Dim r As New rptRecibo
        r.tRec = lanc.Listar_Recibo(CInt(lblFatura.Text), conf.Filial)
        r.DataSource = r.tRec
        f.Relat(r)
        f.ShowDialog(Me)
        f.Dispose()
        Me.Close()
    End Sub
End Class