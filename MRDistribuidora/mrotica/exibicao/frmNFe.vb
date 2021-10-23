Imports System
Imports System.Xml
Imports System.IO
Imports mrotica_util
Imports System.Net
Imports System.Web
Imports MRUtil
Imports Vinco.iContNFe.NFeIntegratorInterOp
Imports Vinco.iContNFe.NFeIntegratorInterOp.Interface

Public Class frmNFe

    Dim d As New ConexaoDB
    Dim cli As New ClienteOtica
    Dim op As New NaturezaOperacao
    Dim cst As New CstNFe
    Dim emitente As New Empresa
    Dim mun As New Municipio
    Dim uf As New Uf
    Dim oNFe As NFeIntegrator = New NFeIntegrator()
    Dim conf As New config
    Dim pedido As New Pedido
    Dim Fatura As New Fatura
    Dim Util As New Geral

    Dim dadosNFe As New MRUtil.NFe
    Dim dadosNFeItem As New NFe_Item
    Dim dadosNFeCobranca As New NFe_Cobranca
    'Dim conn As New ConexaoDB

    Dim notafiscal As New objMaster

    Dim strXML As String = ""
    Dim strChaveNFe As String = ""
    Dim strProtocolo As String = ""
    Dim strRecibo As String = ""
    Dim strProtocoloAut As String = ""
    Dim nume As Integer = 0
    Dim vICMSTotal As Decimal = 0.0
    Dim vNota As Decimal = 0.0
    Dim vBCIcms As Decimal = 0.0
    Dim vProdServTotal As Decimal = 0.0
    Dim vBaseICMSSubTrib As Decimal = 0.0
    Dim vICMSSubTrib As Decimal = 0.0
    Dim vServicoTotal As Decimal = 0.0
    Dim vISS As Decimal = 0.0
    Dim vBaseISS As Decimal = 0.0
    Dim vIPI As Decimal = 0.0
    Dim vCofinsTotal As Decimal = 0.0
    Dim vPISTotal As Decimal = 0.0
    Dim vTotalCofins As Decimal = 0.0
    Dim vImpostoTotal As Decimal = 0.0
    Dim vDescontoTotal As Decimal = 0.0
    Dim intVia As Int16
    Public tipoLanc As Char
    Dim vTotalFatura As Decimal = 0.0
    Dim vDif As Decimal = 0.0
    Dim requestData As String
    Public TipoRegistro As String
    Public SituacaoNota As String

    'variaveis publics
    Public emit As String
    Public numNota As Integer
    Public serieNota As String
    Public modeloNota As String
    Public nomeCliente As String
    Public codigoCliente As Integer
    Dim dllInicializada As Boolean = False

    Private Sub frmNFe_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        tabPainel.SelectedPageIndex = 0

        If modeloNota <> String.Empty Then
            If modeloNota = "55" Then
                rbNFe.Checked = True
            Else
                rbNFCe.Checked = True
            End If
        End If

        If TipoRegistro = "N" Then
            Util.DesativaControles(Me)
            btnNovoeDoc.Enabled = True
        Else
            carregaNaturezaOperacao()
            carregaMeioPagamento()
            carregaFornecedor()
            carregaModalidadeFrete()
            btnNovoeDoc.Enabled = False
            btnGerar.Enabled = True
            btnEmitirNFe.Enabled = True
        End If

        carregaEmitente()

        If cbEmitente.SelectedIndex <> -1 Then
            emitente.RetornaRegistro(emit)
        End If

        If SituacaoNota = "N" Or SituacaoNota = "C" Then
            Util.DesativaControles(Me)
            btnGerar.Enabled = False
            btnEmitirNFe.Enabled = False
        End If

    End Sub

    Private Sub txtCodigo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs)
        'If e.KeyCode = Keys.Enter Then
        'retornaProduto()
        ' End If
    End Sub
    Private Sub carregaNaturezaOperacao()
        Dim strSQL As String = "select * from NaturezaOperacao"
        Dim tbNaturezaOperacao As New DataTable
        d.CarregaTabela(strSQL, tbNaturezaOperacao)
        cbOperacao.DisplayMember = "descricao"
        cbOperacao.ValueMember = "codigonat"
        cbOperacao.DataSource = tbNaturezaOperacao
        cbOperacao.SelectedIndex = -1
    End Sub

    Private Sub carregaMeioPagamento()
        Dim strSQL As String = "select * from MeioPag"
        Dim tbMeioPagamento As New DataTable
        d.CarregaTabela(strSQL, tbMeioPagamento)
        cbMeioPagamento.DisplayMember = "descricao"
        cbMeioPagamento.ValueMember = "codigo"
        cbMeioPagamento.DataSource = tbMeioPagamento
        cbMeioPagamento.SelectedIndex = -1
    End Sub

    Private Sub carregaEmitente()
        Dim tabela As New DataTable
        Dim strSQL As String = ""

        If String.IsNullOrEmpty(emit) Then
            strSQL = "select cnpj_cpf, razao_social from emitente"
        Else
            strSQL = "select cnpj_cpf, razao_social from emitente where cnpj_cpf = " & Geral.AspasSQL(emit)
        End If

        d.CarregaTabela(strSQL, tabela)
        cbEmitente.DisplayMember = "razao_social"
        cbEmitente.ValueMember = "cnpj_cpf"
        cbEmitente.DataSource = tabela

        If String.IsNullOrEmpty(emit) Then
            cbEmitente.SelectedIndex = -1
        Else
            cbEmitente.SelectedValue = emit
            dadosNFe.Registro(emit, serieNota, modeloNota, numNota)
            txtNumeroNFE.Text = Format(dadosNFe.NumeroDocFiscal, "0000")
            txtSerie.Text = dadosNFe.Serie
            txtModelo.Text = dadosNFe.Modelo
            txtNumFatura.Text = dadosNFe.Documento
            txtFilial.Text = dadosNFe.FilialDocumento
            lblNomeCliente.Text = nomeCliente
            txtNFeRef.Text = dadosNFe.ReferenciaChaveNFe
            cbOperacao.SelectedValue = dadosNFe.NaturezaOperacao
            dadosNFeCobranca.Registro(emit, serieNota, modeloNota, numNota)

            op.RetornaRegistro(cbOperacao.SelectedValue)

            If op.FinalidadeNota = 4 Then
                cbMeioPagamento.SelectedValue = dadosNFeCobranca.MeioPagamento
                cbFormaPagamento.Enabled = False
                cbMeioPagamento.Enabled = False
            Else
                If dadosNFeCobranca.TipoPagamento = 0 Then
                    cbFormaPagamento.SelectedIndex = 0
                Else
                    cbFormaPagamento.SelectedIndex = 1
                End If
                cbMeioPagamento.SelectedValue = dadosNFeCobranca.MeioPagamento
                cbFormaPagamento.Enabled = True
                cbMeioPagamento.Enabled = True
            End If


            carregaItens()
        End If

    End Sub

    Private Sub carregaFornecedor()
        Dim tabela As New DataTable
        Dim strSQL As String = "select cgc, nome from fornec order by nome"
        d.CarregaTabela(strSQL, tabela)
        cbFornecedor.DisplayMember = "nome"
        cbFornecedor.ValueMember = "cgc"
        cbFornecedor.DataSource = tabela
        cbFornecedor.SelectedIndex = -1
    End Sub

    Private Sub carregaModalidadeFrete()
        Dim strSQL As String = "select * from NFe_Frete"
        Dim tbModalidaFrete As New DataTable
        d.CarregaTabela(strSQL, tbModalidaFrete)
        cbModalidadeFrete.DisplayMember = "descricao"
        cbModalidadeFrete.ValueMember = "codigo"
        cbModalidadeFrete.DataSource = tbModalidaFrete
        cbModalidadeFrete.SelectedIndex = 5
    End Sub

    'Função que verifica a situação da NF-e se ela tá P - Pendente, N - Normal, I - Inutilizada e C - Cancelada
    Private Sub carregaItens()
        grdItens.Columns.Clear()
        grdItens.DataSource = Nothing
        grdItens.AutoGenerateColumns = False
        grdItens.AllowUserToAddRows = False

        Dim codigo As New DataGridViewTextBoxColumn 'Posição 00
        codigo.HeaderText = "Item"
        codigo.DataPropertyName = "item"
        codigo.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        codigo.SortMode = DataGridViewColumnSortMode.NotSortable
        codigo.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        codigo.DefaultCellStyle.Format = "000"
        codigo.Width = 40
        grdItens.Columns.Add(codigo)

        Dim produto As New DataGridViewTextBoxColumn 'Posição 01
        produto.HeaderText = "Cód. Produto"
        produto.DataPropertyName = "cod_produto"
        produto.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        produto.DefaultCellStyle.Format = "000000"
        produto.SortMode = DataGridViewColumnSortMode.NotSortable
        produto.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        produto.Width = 80
        grdItens.Columns.Add(produto)

        Dim ncm As New DataGridViewTextBoxColumn 'Posição 02
        ncm.HeaderText = "NCM"
        ncm.DataPropertyName = "ncm"
        ncm.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ncm.SortMode = DataGridViewColumnSortMode.NotSortable
        ncm.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        ncm.Width = 70
        grdItens.Columns.Add(ncm)

        Dim descricao As New DataGridViewTextBoxColumn 'Posição 03
        descricao.HeaderText = "Produto"
        descricao.DataPropertyName = "produto"
        descricao.Width = 300
        grdItens.Columns.Add(descricao)

        Dim quant As New DataGridViewTextBoxColumn 'Posição 04
        quant.HeaderText = "Quant"
        quant.DataPropertyName = "quant"
        quant.Width = 50
        quant.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        quant.SortMode = DataGridViewColumnSortMode.NotSortable
        quant.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        quant.DefaultCellStyle.Format = "##0.00"
        grdItens.Columns.Add(quant)

        Dim unit As New DataGridViewTextBoxColumn 'Posição 05
        unit.HeaderText = "Unitário"
        unit.DataPropertyName = "preco_tab"
        unit.Width = 70
        unit.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        unit.SortMode = DataGridViewColumnSortMode.NotSortable
        unit.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        unit.DefaultCellStyle.Format = "#,##0.00"
        grdItens.Columns.Add(unit)

        Dim desconto As New DataGridViewTextBoxColumn 'Posição 06
        desconto.HeaderText = "Desconto"
        desconto.DataPropertyName = "desconto"
        desconto.Width = 70
        desconto.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        desconto.SortMode = DataGridViewColumnSortMode.NotSortable
        desconto.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        desconto.DefaultCellStyle.Format = "#,##0.00"
        grdItens.Columns.Add(desconto)

        Dim total As New DataGridViewTextBoxColumn 'Posição 07
        total.HeaderText = "Total"
        total.DataPropertyName = "total"
        total.Width = 70
        total.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        total.SortMode = DataGridViewColumnSortMode.NotSortable
        total.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        total.DefaultCellStyle.Format = "#,##0.00"
        grdItens.Columns.Add(total)

        Dim gtin As New DataGridViewTextBoxColumn 'Posição 08
        gtin.HeaderText = "GTIN"
        gtin.DataPropertyName = "gtin"
        gtin.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        gtin.SortMode = DataGridViewColumnSortMode.NotSortable
        gtin.Width = 60
        grdItens.Columns.Add(gtin)

        Dim unidade As New DataGridViewTextBoxColumn 'Posição 09
        unidade.HeaderText = "Unidade"
        unidade.DataPropertyName = "unidade"
        unit.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        unit.SortMode = DataGridViewColumnSortMode.NotSortable
        unidade.Width = 60
        grdItens.Columns.Add(unidade)

        Dim cest As New DataGridViewTextBoxColumn 'Posição 10
        cest.HeaderText = "CEST"
        cest.DataPropertyName = "cest"
        cest.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        cest.SortMode = DataGridViewColumnSortMode.NotSortable
        cest.Visible = False
        grdItens.Columns.Add(cest)

        Dim strSQL As String = ""

        strSQL = "select cod_tabela,nome_lente, preco, preco_tab ,desconto, sum(quant) as quant, produto, cod_produto, ncm, gtin, unidade, cest," &
            "sum(preco * quant) as total from lista_itens_fatura_nfe(" & Convert.ToInt32(txtNumFatura.Text) & "," & Convert.ToInt32(txtFilial.Text) &
            ") group by cod_tabela, nome_lente, preco, preco_tab, desconto, quant, produto, cod_produto,ncm, " &
        "gtin, unidade, cest"

        Dim tb As New DataTable()

        d.CarregaTabela(strSQL, tb)

        grdItens.DataSource = tb

        Dim vtotal As Decimal = 0.0
        Dim subtotalprodutos As Decimal = 0.0
        Dim totaldesc As Decimal = 0.0
        Dim totalprodutos As Decimal = 0.0
    End Sub

    Private Function f_trucate(ByVal numero As Double, ByVal fator As Byte) As Double
        f_trucate = Fix(numero * 10 ^ fator) / 10 ^ fator
    End Function


    Public Function arredondaValor(ByVal valor As Double, ByVal parcelas As Int32) As Double
        Dim intQuantidadeCasasDecimais As Integer = 2

        Dim intElevado As Double = Math.Pow(10, intQuantidadeCasasDecimais)
        Dim valorParcelas As Double = Math.Truncate(valor / parcelas * intElevado) / intElevado
        Dim valorUltimaParcela As Double = valor - (valorParcelas * (parcelas - 1))
        Return valorUltimaParcela
    End Function

    Private Sub btnLocalizar_Click(sender As Object, e As EventArgs) Handles btnLocalizar.Click
        ' Dim f As New frmConsultaCli
        'f.ShowDialog()
        'f.Dispose()

        'Dim codc As Integer = f.codigocliente
        'Dim codf As Integer = f.codigofilialcliente
        'pedido.RetornaPedido(Convert.ToInt32(txtNumPedido.Text), Convert.ToInt32(txtFilial.Text))
        'txtCodCliente.Text = pedido.CodigoCliente
        'cli.RetornaCliente(Convert.ToInt32(txtCodCliente.Text))
        'lblNomeCliente.Text = cli.RazaoSocial
        Fatura.RetornaRegistro(Convert.ToInt32(txtNumFatura.Text), Convert.ToInt32(txtFilial.Text))
        cli.FiltraCliente(Fatura.CodigoCliente)
        If cli.NomeCliente IsNot Nothing Then
            lblNomeCliente.Text = cli.NomeCliente
        Else
            lblNomeCliente.Text = ""
        End If

        carregaItens()
    End Sub

    Private Sub cbEmitente_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbEmitente.SelectionChangeCommitted
        If rbNFe.Checked = True Or rbNFCe.Checked = True Then
            If cbEmitente.SelectedIndex <> -1 Then
                emitente.RetornaRegistro(cbEmitente.SelectedValue)
                If TipoRegistro = "N" Then
                    If rbNFe.Checked = True Then
                        txtNumeroNFE.Text = Format(emitente.NumeroNFe, "0000")
                        txtSerie.Text = emitente.SerieNFe
                        txtModelo.Text = emitente.ModeloNFe
                    Else
                        txtNumeroNFE.Text = Format(emitente.NumeroNFCe, "0000")
                        txtSerie.Text = emitente.SerieNFCe
                        txtModelo.Text = emitente.ModeloNFCe
                    End If
                End If
            End If
        Else
            cbEmitente.SelectedIndex = -1
            MessageBox.Show("Por favor informar o tipo de documento fiscal.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub chkManual_CheckedChanged(sender As Object, e As EventArgs) Handles chkManual.CheckedChanged
        If chkManual.Checked = True Then
            txtCodigo.Enabled = True
            txtQuantidade.Enabled = True
            txtVUnitario.Enabled = True
            txtDescontoProd.Enabled = True
            btnAdicionar.Enabled = True
        End If
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        'carregaItensAvulso()
    End Sub

    Private Sub txtCodigo_Leave(sender As Object, e As EventArgs) Handles txtCodigo.Leave
        If txtCodigo.Text <> String.Empty Then
            CarregaProduto()
        End If
    End Sub

    Private Sub CarregaProduto()
        Dim strSQL As String = "select codigo, descricao, unidade, ncm, gtin from produto"
        Dim tb As New DataTable
        d.CarregaTabela(strSQL, tb)

        If tb.Rows.Count > 0 Then
            lblDescriao.Text = tb.Rows(0)("descricao").ToString()
            txtQuantidade.Text = "1"
            txtVUnitario.Text = "0,00"
            txtDescontoProd.Text = "0,00"
        End If
    End Sub

    Private Function VerificaCamposPreenchidos() As Boolean
        Dim resultado As Boolean = False

        If rbNFe.Checked = False And rbNFCe.Checked = False Then
            MessageBox.Show("Por favor informar o tipo do documento fiscal!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            resultado = True
        ElseIf cbEmitente.Text = String.Empty Then
            MessageBox.Show("Por favor informar o emitente para emissão da NF-e!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            resultado = True
            GoTo ponto
        ElseIf cbOperacao.Text = String.Empty Then
            MessageBox.Show("Por favor informar o tipo de operação para emissão da NF-e!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            resultado = True
            GoTo ponto
        ElseIf txtNumFatura.Text = String.Empty Then
            MessageBox.Show("Por favor informar o número do orçamento do cliente!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            resultado = True
            GoTo ponto
        ElseIf txtFilial.Text = String.Empty Then
            MessageBox.Show("Por favor informar a filial!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            resultado = True
            GoTo ponto
        ElseIf cbFormaPagamento.Text = String.Empty Then
            MessageBox.Show("Por favor informar a forma de pagamento para emissão da NF-e!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            resultado = True
            GoTo ponto
        ElseIf cbMeioPagamento.Text = String.Empty Then
            MessageBox.Show("Por favor informar o meio de pagamento para emissão da NF-e!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            resultado = True
            GoTo ponto
        End If

ponto:
        Return resultado
    End Function

    Private Sub tabPainel_SelectedPageChanged(sender As Object, e As DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs) Handles tabPainel.SelectedPageChanged
        If tabPainel.SelectedPage.Name = "tabNavCancelar" Then
            btnEmitirNFe.Enabled = False
        ElseIf tabPainel.SelectedPage.Name = "tabNavNFE" Then
            btnEmitirNFe.Enabled = True
        End If
    End Sub

    Private Sub rbNFCe_CheckedChanged(sender As Object, e As EventArgs) Handles rbNFCe.CheckedChanged
        If rbNFCe.Checked = True Then
            cbFornecedor.Enabled = False
        End If
    End Sub

    Private Sub rbNFe_CheckedChanged(sender As Object, e As EventArgs) Handles rbNFe.CheckedChanged
        If rbNFe.Checked = True Then
            cbFornecedor.Enabled = True
        End If
    End Sub

    Private Sub GeraNota()
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

        op.RetornaRegistro(cbOperacao.SelectedValue)

        If cbEmitente.SelectedIndex <> -1 Then
            Call cbEmitente_SelectionChangeCommitted(Nothing, Nothing)
        End If

        If op.FinalidadeNota <> 4 Then
            If cbOperacao.SelectedIndex = -1 Then
                MessageBox.Show("Por favor, informar a natureza de oepração!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                mmMensagemNFe.Text = ""
                Exit Sub
            End If

            If cbFormaPagamento.SelectedIndex = -1 Then
                MessageBox.Show("Por favor, informar a forma e pagamento!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                mmMensagemNFe.Text = ""
                Exit Sub
            End If

            If cbFormaPagamento.SelectedIndex = 0 Then
                dadosNFeCobranca.TipoPagamento = 0
            Else
                dadosNFeCobranca.TipoPagamento = 1
            End If
        End If

        If cbMeioPagamento.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, informar o meio de pagamento!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            mmMensagemNFe.Text = ""
            Exit Sub
        End If


        '====================CABEÇALHO NFE====================
        dadosNFe.Emitente = emitente.CnpjCpf
        dadosNFe.NumeroDocFiscal = Convert.ToInt32(txtNumeroNFE.Text)
        dadosNFe.NaturezaOperacao = op.CodigoNatureza
        dadosNFe.FinaldiadeNota = op.FinalidadeNota
        dadosNFe.Serie = Convert.ToInt32(txtSerie.Text)
        If rbNFe.Checked Then
            dadosNFe.Modelo = emitente.ModeloNFe
        Else
            dadosNFe.Modelo = emitente.ModeloNFCe
        End If
        dadosNFe.TipoNFe = op.TipoNFe
        dadosNFe.DataEmissao = DateTime.Now
        dadosNFe.CodigoFilial = conf.Filial

        If TipoRegistro = "A" Then
            Fatura.RetornaRegistro(Convert.ToInt32(txtNumFatura.Text), Convert.ToInt32(txtFilial.Text))
            cli.FiltraCliente(Fatura.CodigoCliente)
        End If

        dadosNFe.CodigoCliente = cli.CodigoCliente

        dadosNFe.ConsumidorFinal = op.ConsumidorFinal
        dadosNFe.Observacao = txtObservacao.Text
        dadosNFe.SituacaoNFe = "D" 'D = em digitação
        dadosNFe.ReferenciaChaveNFe = txtNFeRef.Text
        dadosNFe.DestinoOperacao = op.DestinoOperacao 'Identificador de local de destino da operação / 1 = OP. Interna / 2= Op. Interestadual / 3 = Op. Ext
        dadosNFe.ConsumidorPresente = op.ConsumidorPresente 'Indicador de presença do comprador no estabelecimento comercial

        dadosNFe.Documento = Convert.ToInt32(txtNumFatura.Text)
        dadosNFe.OrigemDoc = "F"

        dadosNFe.CanceladoUsuario = 0
        dadosNFe.TipoFatura = "A" 'A = Automática / M = Manual
        dadosNFe.Frete = cbModalidadeFrete.SelectedValue

        dadosNFe.FilialDocumento = conf.Filial
        dadosNFe.FilialCliente = conf.Filial

        Dim strSQLExisteNFe As String = "select 1 from nfe where emitente = '" & emitente.CnpjCpf & "' and numero = " & Convert.ToInt32(txtNumeroNFE.Text) &
                " and serie = " & Convert.ToInt32(txtSerie.Text) & " and modelo = " & dadosNFe.Modelo & ""

        If d.VerificaExistenciaReg(strSQLExisteNFe) = 0 Then
            dadosNFe.SalvaNFe()
            If rbNFe.Checked Then
                emitente.AtualizaNumeroNota("NFe")
            Else
                emitente.AtualizaNumeroNota("NFCe")
            End If
        Else
            dadosNFe.AtualizaNFe()
        End If
        '====================FIM CABEÇALHO NFE====================


        '====================DADOS DE COBRANÇA====================
        dadosNFeCobranca.Emitente = emitente.CnpjCpf
        dadosNFeCobranca.NumeroNFe = Convert.ToInt32(txtNumeroNFE.Text)
        dadosNFeCobranca.Serie = Convert.ToInt32(txtSerie.Text)
        dadosNFeCobranca.Modelo = Convert.ToInt32(txtModelo.Text)
        dadosNFeCobranca.MeioPagamento = cbMeioPagamento.SelectedValue

        Dim strSQLExisteNFeCob As String = "select 1 from nfe_cobranca where emitente = '" & emitente.CnpjCpf & "' and numero = " & Convert.ToInt32(txtNumeroNFE.Text) &
                " and serie = " & Convert.ToInt32(txtSerie.Text) & " and modelo = " & Convert.ToInt32(txtModelo.Text) & ""
        If d.VerificaExistenciaReg(strSQLExisteNFeCob) = 0 Then
            dadosNFeCobranca.SalvaCobrancaNFe()
        Else
            dadosNFeCobranca.AtualizaCobrancaNFe()
        End If
        '====================FIM DADOS COBRANÇA====================

        If grdItens.Rows.Count > 0 Then
            dadosNFeItem.Emitente = emitente.CnpjCpf
            dadosNFeItem.NumeroDocFiscal = Convert.ToInt32(txtNumeroNFE.Text)
            dadosNFeItem.Serie = Convert.ToInt32(txtSerie.Text)
            dadosNFeItem.Modelo = Convert.ToInt32(txtModelo.Text)
            dadosNFeItem.ExcluirNFeItem()
        End If

        '=====================DADOS ITEM NOTA======================
        For Each linha As DataGridViewRow In grdItens.Rows
            Dim qCom As Double = CDbl(linha.Cells(4).Value)
            Dim vUnitarioTrib As Decimal = Convert.ToDecimal(linha.Cells(5).Value) 'Valor unitário que realmente será tributado
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
            Dim codigoEan As String = linha.Cells(8).Value.ToString().Trim()

            i += 1
            '////////////Detalhamento de Produtos e Serviços da NF-e///////////////
            dadosNFeItem.Emitente = emitente.CnpjCpf
            dadosNFeItem.NumeroDocFiscal = txtNumeroNFE.Text
            dadosNFeItem.Serie = txtSerie.Text.Trim()
            If rbNFe.Checked Then
                dadosNFeItem.Modelo = emitente.ModeloNFe
            Else
                dadosNFeItem.Modelo = emitente.ModeloNFCe
            End If

            cst.RetornaRegistro(op.CodigoNatureza)

            dadosNFeItem.Item = i
            dadosNFeItem.ProdutoCodigo = CInt(linha.Cells(1).Value)

            dadosNFeItem.Quantidade = qCom
            dadosNFeItem.ValorUnitario = vUnitarioTrib
            vProduto = qCom * vUnitarioTrib
            vDescontoItem = (vProduto * Convert.ToDecimal(linha.Cells(6).Value)) / 100
            dadosNFeItem.VDesconto = vDescontoItem

            'vNotaItem = vProduto
            vProduto = vProduto - vDescontoItem

            dadosNFeItem.CFOP = notafiscal.so_numeros(cst.CFOP)
            dadosNFeItem.NCM = CInt(linha.Cells(2).Value)

            If linha.Cells(10).Value IsNot DBNull.Value Then
                dadosNFeItem.CEST = CInt(linha.Cells(10).Value)
            End If

            dadosNFeItem.Origem = cst.CodigoOrigemMercadoria
            dadosNFeItem.Unidade = linha.Cells(9).Value.ToString().Trim()

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

            vNotaTotal = vNotaTotal + vProduto
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

            Dim strSQLExisteNFeItem As String = "select 1 from nfe_item where emitente = '" & emitente.CnpjCpf & "' and numero = " & Convert.ToInt32(txtNumeroNFE.Text) &
                " and serie = " & Convert.ToInt32(txtSerie.Text) & " and modelo = " & dadosNFe.Modelo & " and item = " & i

            If d.VerificaExistenciaReg(strSQLExisteNFeItem) = 0 Then
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

        If op.FinalidadeNota = 4 Then
            dadosNFe.ValorNota = 0
        End If

        dadosNFe.AtualizaNFeGerada()

        Util.AcaoBotoes(ToolStrip1, "GerarNFe")
    End Sub

    Private Sub EnviaNota()
        Try
            SplashScreenManager1.ShowWaitForm()
            Dim tpAmbiente, tpImpressao, tpFin, tpEmis As Integer
            'Verifica se a DLL foi nicializazda, em caso negativo a DLL será inicializada
            If dllInicializada = False Then
                InicializacaoPadraoNF()
            End If

            If rbNFe.Checked = True Then
                oNFe.SetIdKeySistema(emitente.IdSistemaNFe)
                tpImpressao = 1
            Else
                oNFe.SetIdKeySistema(emitente.IdSistemaNFCe)
                oNFe.CodigoCSC = emitente.CodigoCSC
                tpImpressao = 4
            End If


            If emitente.Producao = True Then
                tpAmbiente = 1
            Else
                tpAmbiente = 2
            End If

            op.RetornaRegistro(cbOperacao.SelectedValue)

            tpFin = op.FinalidadeNota
            'If op.FinalidadeNota = 1 Then
            'tpFin = 1
            'ElseIf op.FinalidadeNota = 2 Then
            'tpFin = 2
            'ElseIf op.FinalidadeNota = 3 Then
            'tpFin = 3
            'ElseIf op.FinalidadeNota = 4 Then
            'tpFin = 4
            'End If

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
            'oNFe.SetNumeroCopias(1)

            'Define se a DLL imprimirá diretamenta para a impressão Padrão do windows
            'oNFe.PrintToDefaultPrinter = False

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
                dadosNFe.NumeroDocFiscal = Convert.ToInt32(txtNumeroNFE.Text)
                dadosNFe.Serie = Convert.ToInt32(txtSerie.Text)
                dadosNFe.Modelo = Convert.ToInt32(txtModelo.Text)

                dadosNFe.DataEmissao = retorno.DataRecebimento
                dadosNFe.SituacaoNFe = "N"
                dadosNFe.DataSaida = retorno.DataRecebimento
                dadosNFe.ChaveNFe = retorno.ChaveNFe
                dadosNFe.ProtocoloAutorizacao = retorno.Protocolo
                dadosNFe.DataProtocoloAut = retorno.DataRecebimento
                dadosNFe.Justificativa = retorno.xMotivo
                dadosNFe.NFeAssinadaXml = retorno.XMLProc
                dadosNFe.AtualizaNFeEnviada()

                SplashScreenManager1.CloseWaitForm()

                MessageBox.Show("Nota Fiscal autorizada com sucesso. Protocolo: " + retorno.Protocolo)

                Util.DesativaControles(Me)
                'Verifica se deu erro no envio do email, como o email só em viando no caso da NF-e que autorizada
                'só é necessario veirificar aqui
                'esse erro não interfere no processo de autorização
                If Not String.IsNullOrEmpty(retorno.ErrorEnvioEmail) Then
                    MessageBox.Show("Erro no email: " & retorno.ErrorEnvioEmail)
                End If
            Else
                SplashScreenManager1.CloseWaitForm()
                'Caso contrario indica qual foi o motivo da rejeição.
                MessageBox.Show("Mensagem: " + retorno.xMotivo)
            End If
        Catch ex As ApplicationException
            SplashScreenManager1.CloseWaitForm()
            MessageBox.Show(ex.Message, "ApplicationException", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            SplashScreenManager1.CloseWaitForm()
            MessageBox.Show(String.Format("{0}", ex), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        mmMensagemNFe.Text = "Documento fiscal gerado com sucesso..."
        Util.AcaoBotoes(ToolStrip1, "EmitirNFe")
    End Sub

    Private Sub btnGerar_Click(sender As Object, e As EventArgs) Handles btnGerar.Click
        If grdItens.Rows.Count = 0 Then
            MessageBox.Show("Nota não pode ser gerada sem item.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If MessageBox.Show("Deseja gerar o arquivo para emissão do documento fiscal?", "CONFIRMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            mmMensagemNFe.Text = "Por favor aguarde, gerando dados...."
            GeraNota()
            mmMensagemNFe.Text = "Dados Gerados com sucesso"
        End If
    End Sub

    Private Sub btnEmitirNFe_Click(sender As Object, e As EventArgs) Handles btnEmitirNFe.Click
        EnviaNota()
    End Sub

    Private Sub btnImprimirNFe_Click(sender As Object, e As EventArgs) Handles btnImprimirNFe.Click
        mmMensagemNFe.Text = "Por favor aguarde, gerando impressão...."
        SplashScreenManager1.ShowWaitForm()

        Dim strSQL As String = "select situacao, nfeassinadaxml from nfe where emitente = " & emitente.CnpjCpf & " and " &
            "numero = " & Convert.ToInt32(txtNumeroNFE.Text) & " and serie = " & Convert.ToInt32(txtSerie.Text) & " and modelo = " &
            Convert.ToInt32(txtModelo.Text)

        Dim tb As New DataTable
        tb = d.CarregaTabela(strSQL, tb)

        If tb.Rows.Count > 0 Then
            If tb.Rows(0)("situacao").ToString() = "N" Or tb.Rows(0)("situacao").ToString() = "C" Then
                If dllInicializada = False Then
                    InicializacaoPadraoNF()
                End If

                If rbNFe.Checked = True Then
                    oNFe.SetIdKeySistema(emitente.IdSistemaNFe)
                Else
                    oNFe.SetIdKeySistema(emitente.IdSistemaNFCe)
                End If

                'Define no numero de copias que serão impressas
                oNFe.SetNumeroCopias(1)

                If rbNFCe.Checked = True Then
                    If emitente.Impressora <> String.Empty Then
                        oNFe.SelectPrinter = emitente.Impressora

                        'Define se a DLL imprimirá diretamenta para a impressão Padrão do windows
                        oNFe.PrintToDefaultPrinter = False
                    Else
                        Dim iRetorno As Integer
                        iRetorno = Declaracoes.iCFImprimir_NFCe_Daruma(tb.Rows(0)("nfeassinadaxml").ToString(), "", "", 48, 1)
                        SplashScreenManager1.CloseWaitForm()
                    End If
                Else
                    SplashScreenManager1.CloseWaitForm()
                    oNFe.ObterViewPdfNfeFromXML(tb.Rows(0)("nfeassinadaxml").ToString())
                End If

                mmMensagemNFe.Text = "Impressão gerada com sucesso...."
            Else
                SplashScreenManager1.CloseWaitForm()
                MessageBox.Show("Não é possível gerar DANFE de uma nota que " & vbCrLf & "não foi autorizada ou cancelada!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                mmMensagemNFe.Text = ""
            End If
        End If

        Util.AcaoBotoes(ToolStrip1, "ImprimirNFe")
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

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs)
        CancelaNota()
    End Sub

    Private Sub CancelaNota()
        Try
            'Verifica se a DLL foi nicializazda, em caso negativo a DLL será inicializada
            If dllInicializada = False Then
                InicializacaoPadraoNF()
            End If

            oNFe.SetIdKeySistema(emitente.IdSistemaNFe)

            'Set de configurações de emissão: ambiente, impressão, finalidade, tipo de emisão
            oNFe.SetEnvironment(1, 1, 1, 1)

            'Set do endereço no file system onde as NFe//s autorizadas serão armazenadas
            oNFe.EnderecoCancelada = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Cancelada")

            oNFe.ClearParams()

            'No exemplo utlizado, existe somente 1 filtro
            '- um com o numero da Nota Fiscal no sistema
            'Os filtros devem ser alimentados na mesma ordem que eles foram criados
            'no ConfigExtractor

            'Adiciona o valor no filtro
            oNFe.AddParams(emitente.CnpjCpf) 'cnpjemitente
            oNFe.AddParams(dadosNFe.NumeroDocFiscal) 'numeronfe
            oNFe.AddParams(dadosNFe.CodigoCliente) 'codigocliente
            oNFe.AddParams(dadosNFe.CodigoFilial) 'codigofilial
            oNFe.AddParams(dadosNFe.Modelo) 'modelo NF
            oNFe.AddParams(dadosNFe.Serie) 'Serie

            Dim retorno As IRetornoEvento = oNFe.CancelarPorEvento("")

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
                dadosNFe.NumeroDocFiscal = Convert.ToInt32(txtNumeroNFE.Text)
                dadosNFe.Serie = Convert.ToInt32(txtSerie.Text)
                dadosNFe.Modelo = Convert.ToInt32(txtModelo.Text)

                dadosNFe.SituacaoNFe = "C"
                dadosNFe.ProtocoloCancelamento = retorno.nProt
                dadosNFe.DataProtocoloCancelamento = DateTime.Now
                dadosNFe.NFeCanceladaXml = retorno.ProcEventoNFe
                dadosNFe.CanceladoUsuario = 1
                dadosNFe.AtualizaNFeCancelada()

                MessageBox.Show("Nota Fiscal cancelada com sucesso. Protocolo: " + retorno.Protocolo)
            Else
                'Caso contrario indica qual foi o motivo da rejeição.
                MessageBox.Show("Mensagem: " + retorno.xMotivo)
            End If
        Catch ex As ApplicationException
            MessageBox.Show(ex.Message, "ApplicationException", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(String.Format("{0}", ex), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnNovoeDoc_Click(sender As Object, e As EventArgs) Handles btnNovoeDoc.Click
        TipoRegistro = "N"
        Geral.TipoReg = TipoRegistro
        Util.AtivaControles(Me)
        txtFilial.Text = conf.Filial
        lblNomeCliente.Text = ""
        carregaNaturezaOperacao()
        carregaMeioPagamento()
        carregaFornecedor()
        carregaModalidadeFrete()
        Util.AcaoBotoes(ToolStrip1, "NovoDoc")
        grdItens.DataSource = Nothing
        mmMensagemNFe.Text = "Modo inclusão de documento fiscal"
    End Sub

    Private Sub cbOperacao_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbOperacao.SelectionChangeCommitted
        If cbOperacao.SelectedIndex <> -1 Then
            op.RetornaRegistro(cbOperacao.SelectedValue)

            If op.FinalidadeNota = 4 Then
                cbFormaPagamento.Enabled = False
                cbMeioPagamento.SelectedValue = 90
                cbMeioPagamento.Enabled = False
            Else
                cbFormaPagamento.Enabled = True
                cbMeioPagamento.Enabled = True
                cbFormaPagamento.SelectedIndex = -1
                cbMeioPagamento.SelectedIndex = -1
            End If
        End If
    End Sub
End Class