Option Strict Off
Option Explicit On
Imports System.Data
Imports System.Data.SqlClient
Imports mrotica_util
Imports MRUtil
Imports Microsoft.Office.Interop
Public Class frmCliente_Old
    Dim Cli As New Cliente
    Dim tb_pacote As New DataTable
    Dim tb_pedidos As New DataTable
    Dim tb_itens As New DataTable
    Dim tb_servico As New DataTable
    Dim pacote As New objPacoteCliente
    Dim produto As New produtoClass
    Dim pedido As New objPedidoBalcao
    Dim acesso As New objMaster
    Dim tabela As New objTabela
    Dim prod As New Produto
    Dim Util As New Geral
    Dim Conexao As New ConexaoDB()
    Dim id_pedido As Integer
    Dim id_faturas As Integer
    Dim conf As New config
    Dim titPedidos As String
    Dim Usu As New UsuarioPermissao
    Dim ciclo As objCiclo
    Dim promotor As New Promotor
    Dim lblCodPromotor As Integer
    Dim intUsuario As Integer
    Dim lanc As New objPagCredito
    Dim intCodCredito As Integer
    Dim resultado As Integer = 0
    Dim strOrigem As String = ""
    Dim intDia As Integer
    Dim strTexto As String = ""
    Dim intControle As Int16
    Dim totalpacote As Double

#Region "Load, Carrega_dados..."
    Private Sub frmCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Usu.RetornaRegistro(frmMain.intCodigoUsuario)
        intUsuario = Usu.CodigoUsuario

        Util.DesativaControles(Me)

        If Usu.VerificaPermissaoUsuario(51) = True Then
            gbControlePrincipal.Enabled = True
            btnNovo.Enabled = True
        End If

        If Usu.VerificaPermissaoUsuario(52) = False Then
            tbcliente.TabPages("tbPacoteDesconto").Enabled = False
        End If

        If Usu.VerificaPermissaoMenu(intUsuario) = 2 Then
            btnNovoPacote.Enabled = False
            btnExcluirPacote.Enabled = False
        End If

    End Sub
    Private Sub CarregaDados()
        Status()

        lblCodFilialCliente.Text = Cli.CodigoFilialCliente
        txtCodCliente.Text = Cli.CodigoCliente
        txtNome.Text = Cli.NomeCliente
        txtRazaoSocial.Text = Cli.RazaoSocial

        txtCnpjCpf.Text = Geral.FormataCNPJCPF(Cli.CpfCnpj)

        txtIE.Text = Cli.Ie
        txtEndreço.Text = Cli.Logradouro
        txtNumero.Text = Cli.Numero
        txtComplemento.Text = Cli.Complemento
        txtBairro.Text = Cli.Bairro
        txtUF.Text = Cli.Uf
        txtCep.Text = Geral.FormataCEP(Cli.Cep)
        txtFone.Text = Cli.Telefone
        txtLimiteCompra.Text = Geral.FormataMoeda(Cli.LimiteCompra)
        txtlimiteCredito.Text = Geral.FormataMoeda(Cli.LimiteCredito)
        txtLimiteDisponivel.Text = Geral.FormataMoeda(Cli.LimiteCredito - Cli.ResumoReceberTotalCliente)
        txtDiasPagar.Text = Cli.QtdeDiaPagar
        txtEmail.Text = Cli.Email
        txtObs.Text = Cli.Observacao
        cbCidade.SelectedValue = Cli.CidadeIBGE
        chkSemDesconto.Checked = Cli.SemDesconto
        txtFoneNota.Text = Geral.FormataTelefone(Cli.TelefoneNota)
        cbTipoCliente.SelectedValue = Cli.CodigoTipoCliente
        If Cli.Situacao = False Then
            cbAtivo.Checked = False
        ElseIf Cli.Situacao = True Then
            cbAtivo.Checked = True
        End If

        If Cli.TipoPessoa = "F" Then
            cbTipoPessoa.SelectedIndex = 0
        ElseIf Cli.TipoPessoa = "J" Then
            cbTipoPessoa.SelectedIndex = 1
        End If

        carrega_restricoes()

        formata_grid_resumo()

        CarregaForma()
        carregaFormaSelecionado()
        'ciclo = New objCiclo(cliente.cod_cliente, cliente.cod_filial_cliente)
    End Sub
    Private Sub CarregaCombos()
        Dim tbPromotor As New DataTable
        Dim tbCidade As New DataTable
        Dim tbTipoCliente As New DataTable
        Dim sql As String = ""
        Dim strSQL As String = ""

        strSQL = "Select * from cidade order by cidade"
        Conexao.CarregaTabela(strSQL, tbCidade)
        cbCidade.DisplayMember = "cidade"
        cbCidade.ValueMember = "codigo"
        cbCidade.DataSource = tbCidade

        strSQL = "Select * from promotor ORDER by cod_promotor"
        Conexao.CarregaTabela(strSQL, tbPromotor)
        cbPromotor.DisplayMember = "promotor"
        cbPromotor.ValueMember = "cod_promotor"
        cbPromotor.DataSource = tbPromotor

        strSQL = "select * from tipo_cliente"
        Conexao.CarregaTabela(strSQL, tbTipoCliente)
        cbTipoCliente.DisplayMember = "tipo_cliente"
        cbTipoCliente.ValueMember = "cod_tipo_cliente"
        cbTipoCliente.DataSource = tbTipoCliente

    End Sub

    Public Function restricoes_bloqueado() As Integer
        Dim tbRestricao As New DataTable
        Dim tbDiaTitulo As New DataTable
        Dim tbDiaAcordo As New DataTable
        Dim strDiaTitulo As String = "select data_vencimento from Titulos_aberto() where cod_cliente = " & Cli.CodigoCliente &
            " and cod_filial_cliente = " & Cli.CodigoFilialCliente & " and data_vencimento < GETDATE() and data_recebimento is null"
        Dim strDiaAcordo As String = "select data_vencimento  from Acordo_Aberto() where cod_cliente = " & Cli.CodigoCliente &
            " and cod_filial_cliente = " & Cli.CodigoFilialCliente & " and data_vencimento < GETDATE() and data_recebimento is null"
        tbRestricao = Cli.ResumoReceberCliente(Cli.CodigoCliente, Cli.CodigoFilialCliente)

        Conexao.CarregaTabela(strDiaTitulo, tbDiaTitulo)

        Conexao.CarregaTabela(strDiaAcordo, tbDiaAcordo)

        Dim strMensagem As String = ""

        For Each linha As DataRow In tbRestricao.Rows
            If linha("acordo_atrasado") > 0 Then
                btnStatus.BackColor = Color.Red
                btnStatus.ForeColor = Color.AliceBlue.Black
                strMensagem = "CLIENTE COM ACORDO EM ATRASO" & Chr(13)
                resultado = 1
                If DateDiff(DateInterval.Day, tbDiaAcordo.Rows(0)("data_vencimento"), Conexao.RetornaDataServidor()) <= 60 Then
                    intDia = 60 - DateDiff(DateInterval.Day, tbDiaAcordo.Rows(0)("data_vencimento"), Now())
                End If
            ElseIf linha("titulos_atraso") > 0 Then
                btnStatus.BackColor = Color.Red
                btnStatus.ForeColor = Color.AliceBlue.Black
                strMensagem = "CLIENTE COM TITULOS EM ATRASO" & Chr(13)
                resultado = 2
                If DateDiff(DateInterval.Day, tbDiaTitulo.Rows(0)("data_vencimento"), Conexao.RetornaDataServidor()) <= 60 Then
                    intDia = 60 - DateDiff(DateInterval.Day, tbDiaTitulo.Rows(0)("data_vencimento"), Now())
                End If
            ElseIf Cli.ResumoReceberTotalCliente > Cli.LimiteCredito Then
                btnStatus.BackColor = Color.Yellow
                btnStatus.ForeColor = Color.AliceBlue.Black
                strMensagem = "CLIENTE SEM LIMITE  DE CRÉDITO" & Chr(13)
                resultado = 3
            Else
                btnStatus.BackColor = Color.Lime
                strMensagem = "LIBERADO"
                resultado = 4
            End If
        Next
        btnStatus.Text = strMensagem
        Return resultado
    End Function

#End Region
#Region "Novo,Salvar, Editar MASTER"

#End Region
#Region "Navegação e Status"
    Public Sub Status()
        If Cli.intMax = 0 Then
            lblStatus.Text = "Não há registros para produtos. Pressione o botão novo para adicionar!"
            lblCodFilialCliente.Text = ""
            txtCodCliente.Text = ""
            Exit Sub
        End If
        If Cli.intPonteiro = Cli.intMax Then

        End If
        lblStatus.Text = "Registro " & Cli.intPonteiro + 1 & " de " & Cli.intMax & "."
    End Sub
#End Region
#Region "PAcote"

    Private Sub btnNovoPacote_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovoPacote.Click
        If MessageBox.Show("Deseja criar um novo pacote?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim codpacote As Integer = Conexao.RetornaChave("cod_pacote", "pacote_cliente", "where cod_filial_cliente = " & CInt(lblCodFilialCliente.Text))
            Dim strSQL As String = "Insert into pacote_cliente (cod_pacote,cod_filial_cliente,cod_cliente,concluido,data) " &
                "values(" & codpacote & "," & CInt(lblCodFilialCliente.Text) & "," & CInt(txtCodCliente.Text) & "," &
                Geral.AspasSQL("N") & "," & Geral.DataSQL(Now) & ")"
            Conexao.SalvaAtualizaExcluiReg(strSQL)
            carrega_pacotes() 'Dá um refresh e carrega os pacotes para o cliente corrente
            lblCodigoProduto.Text = ""
            txtProduto.Text = ""
            txtQuant.Text = ""
            txtDesconto.Text = ""
            lblPreco.Text = 0.0
            lblPrecoProdPacDesc.Text = 0.0
            btnNovoItemPacote.Enabled = True
            btnSalvarPacote.Enabled = True
            btnDeletarItemPacote.Enabled = True
        Else
            MessageBox.Show("Operação cancelada com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub FormatPacote()
        grdPacote.Columns.Clear()
        grdPacote.DataSource = Nothing

        grdPacote.AutoGenerateColumns = False
        grdPacote.AllowUserToAddRows = False
        grdPacote.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        Dim selecionar As New DataGridViewCheckBoxColumn 'Posição da coluna 0
        selecionar.HeaderText = "Sel."
        selecionar.Width = "50"
        grdPacote.Columns.Add(selecionar)

        Dim cod_tab As New DataGridViewTextBoxColumn 'Posição da coluna 1
        cod_tab.DataPropertyName = "cod_tabela"
        cod_tab.HeaderText = "Cod Tabela"
        cod_tab.Width = 90
        cod_tab.ReadOnly = True
        grdPacote.Columns.Add(cod_tab)

        Dim cnc As New DataGridViewTextBoxColumn 'Posição da coluna 2
        cnc.DataPropertyName = "nome_Comercial"
        cnc.HeaderText = "Produto"
        cnc.Width = 250
        cnc.ReadOnly = True
        grdPacote.Columns.Add(cnc)

        Dim cPreco As New DataGridViewTextBoxColumn 'Posição da coluna 3
        cPreco.DataPropertyName = "preco_tabela"
        cPreco.HeaderText = "Preço"
        cPreco.Width = 60
        cPreco.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        cPreco.DefaultCellStyle.Format = "#,##0.00"
        cPreco.ReadOnly = True
        grdPacote.Columns.Add(cPreco)

        Dim cdesc As New DataGridViewTextBoxColumn 'Posição da coluna 4
        cdesc.DataPropertyName = "desconto"
        cdesc.HeaderText = "Desc.%"
        cdesc.Width = 50
        cdesc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        cdesc.ReadOnly = True
        grdPacote.Columns.Add(cdesc)

        Dim cpdesc As New DataGridViewTextBoxColumn 'Posição da coluna 5
        cpdesc.DataPropertyName = "preco_desc"
        cpdesc.HeaderText = "Preço Desc."
        cpdesc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        cpdesc.DefaultCellStyle.Format = "#,##0.00"
        cpdesc.Width = 100
        cpdesc.ReadOnly = True
        grdPacote.Columns.Add(cpdesc)

        Dim cpQuant As New DataGridViewTextBoxColumn 'Posição da coluna 6
        cpQuant.DataPropertyName = "Quantidade_contratada"
        cpQuant.HeaderText = "Quantidade"
        cpQuant.Width = 85
        cpQuant.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        cpQuant.ReadOnly = True
        grdPacote.Columns.Add(cpQuant)

        Dim cpSaldo As New DataGridViewTextBoxColumn 'Posição da coluna 7
        cpSaldo.DataPropertyName = "saldo"
        cpSaldo.HeaderText = "Disponível"
        cpSaldo.Width = 85
        cpSaldo.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        cpSaldo.ReadOnly = True
        grdPacote.Columns.Add(cpSaldo)

        Dim cpSurf As New DataGridViewTextBoxColumn 'Posição da coluna 8
        cpSurf.DataPropertyName = "surfacagem"
        cpSurf.HeaderText = "Surfaçagem"
        cpSurf.Width = 250
        cpSurf.ReadOnly = True
        grdPacote.Columns.Add(cpSurf)

        Dim cpPrecoSurf As New DataGridViewTextBoxColumn 'Posição da coluna 9
        cpPrecoSurf.DataPropertyName = "preco_tabela_surf"
        cpPrecoSurf.HeaderText = "Preço Surf"
        cpPrecoSurf.Width = 100
        cpPrecoSurf.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        cpPrecoSurf.DefaultCellStyle.Format = "#,##0.00"
        cpPrecoSurf.ReadOnly = True
        grdPacote.Columns.Add(cpPrecoSurf)

        Dim cpDescSurf As New DataGridViewTextBoxColumn 'Posição da coluna 10
        cpDescSurf.DataPropertyName = "desc_surf"
        cpDescSurf.HeaderText = "Desc.%"
        cpDescSurf.Width = 50
        cpDescSurf.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        cpDescSurf.ReadOnly = True
        grdPacote.Columns.Add(cpDescSurf)

        Dim cpSurfDesc As New DataGridViewTextBoxColumn 'Posição da coluna 11
        cpSurfDesc.DataPropertyName = "preco_surf_desc"
        cpSurfDesc.HeaderText = "Total Surf"
        cpSurfDesc.Width = 100
        cpSurfDesc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        cpSurfDesc.DefaultCellStyle.Format = "#,##0.00"
        cpSurfDesc.ReadOnly = True
        grdPacote.Columns.Add(cpSurfDesc)

        Dim cpMont As New DataGridViewTextBoxColumn 'Posição da coluna 12
        cpMont.DataPropertyName = "montagem"
        cpMont.HeaderText = "Montagem"
        cpMont.Width = 250
        cpMont.ReadOnly = True
        grdPacote.Columns.Add(cpMont)

        Dim cpPrecoMont As New DataGridViewTextBoxColumn 'Posição da coluna 13
        cpPrecoMont.DataPropertyName = "preco_tabela_mont"
        cpPrecoMont.HeaderText = "Preço Mont"
        cpPrecoMont.Width = 100
        cpPrecoMont.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        cpPrecoMont.DefaultCellStyle.Format = "#,##0.00"
        cpPrecoMont.ReadOnly = True
        grdPacote.Columns.Add(cpPrecoMont)

        Dim cpDescmont As New DataGridViewTextBoxColumn 'Posição da coluna 14
        cpDescmont.DataPropertyName = "desc_mont"
        cpDescmont.HeaderText = "Desc.%"
        cpDescmont.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        cpDescmont.Width = 50
        cpDescmont.ReadOnly = True
        grdPacote.Columns.Add(cpDescmont)

        Dim cpmontDesc As New DataGridViewTextBoxColumn 'Posição da coluna 15
        cpmontDesc.DataPropertyName = "preco_mont_desc"
        cpmontDesc.HeaderText = "Preço."
        cpmontDesc.Width = 100
        cpmontDesc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        cpmontDesc.DefaultCellStyle.Format = "#,##0.00"
        cpmontDesc.ReadOnly = True
        grdPacote.Columns.Add(cpmontDesc)

        'Ivanildo 19/10
        Dim cpTrat As New DataGridViewTextBoxColumn 'Posição da coluna 16
        cpTrat.DataPropertyName = "tratamento"
        cpTrat.HeaderText = "Tratamento"
        cpTrat.Width = 250
        cpTrat.ReadOnly = True
        grdPacote.Columns.Add(cpTrat)

        Dim cpPrecoTrat As New DataGridViewTextBoxColumn 'Posição da coluna 17
        cpPrecoTrat.DataPropertyName = "preco_tabela_trat"
        cpPrecoTrat.HeaderText = "Preço Trat"
        cpPrecoTrat.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        cpPrecoTrat.Width = 100
        cpPrecoTrat.DefaultCellStyle.Format = "#,##0.00"
        cpPrecoTrat.ReadOnly = True
        grdPacote.Columns.Add(cpPrecoTrat)

        Dim cpDescTrat As New DataGridViewTextBoxColumn 'Posição da coluna 18
        cpDescTrat.DataPropertyName = "desc_trat"
        cpDescTrat.HeaderText = "Desc.%"
        cpDescTrat.Width = 50
        cpDescTrat.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        cpDescTrat.ReadOnly = True
        grdPacote.Columns.Add(cpDescTrat)

        Dim cpTratDesc As New DataGridViewTextBoxColumn 'Posição da coluna 19
        cpTratDesc.DataPropertyName = "trat_Desc"
        cpTratDesc.HeaderText = "Preço."
        cpTratDesc.Width = 60
        cpTratDesc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        cpTratDesc.DefaultCellStyle.Format = "#,##0.00"
        cpDescTrat.ReadOnly = True
        grdPacote.Columns.Add(cpTratDesc)

        Dim Status As New DataGridViewTextBoxColumn 'Posição da coluna 20
        Status.DataPropertyName = "status_item"
        Status.HeaderText = "Status Item"
        Status.Width = "100"
        Status.ReadOnly = True
        grdPacote.Columns.Add(Status)

        Dim pacoteant As New DataGridViewTextBoxColumn 'Posição da coluna 21
        pacoteant.DataPropertyName = "cod_pacote_ant"
        pacoteant.HeaderText = "Pacote Ant."
        pacoteant.Width = "100"
        pacoteant.ReadOnly = True
        grdPacote.Columns.Add(pacoteant)

        Dim item As New DataGridViewTextBoxColumn 'Posição da coluna 22
        item.DataPropertyName = "item"
        item.HeaderText = "Item"
        item.Width = "50"
        item.Visible = False
        item.ReadOnly = True
        grdPacote.Columns.Add(item)

        'Fim

        Dim tb_pacote_det As New DataTable
        tb_pacote_det = Cli.FiltraPacoteCliente(Cli.CodigoCliente, Cli.CodigoFilialCliente, cbPacote.SelectedValue)

        If tb_pacote_det.Rows.Count > 0 Then
            grdPacote.DataSource = tb_pacote_det

            For Each linha As DataGridViewRow In grdPacote.Rows
                If linha.Cells(20).Value = "B" Then
                    linha.Cells(0).Value = True
                End If
            Next

            totalpacote = Cli.TotalPacote(Cli.CodigoCliente, Cli.CodigoFilialCliente, cbPacote.SelectedValue)
            lblTotal.Text = Format(CDbl(totalpacote), "#,##0.00")
        End If
    End Sub

    Private Sub carrega_pacotes()
        Dim tt As New DataTable
        tt = Cli.ListaPacotes(CInt(txtCodCliente.Text), CInt(lblCodFilialCliente.Text))
        If tt.Rows.Count > 0 Then
            cbPacote.DataSource = tt
            cbPacote.DisplayMember = "cod_pacote"
            cbPacote.ValueMember = "cod_pacote"
        End If
    End Sub

    Private Sub carrega_produto_pacote(ByVal codtabela As Integer)
        Dim tb As New DataTable

        tb = Cli.FiltraPacoteDetalhe(CInt(txtCodCliente.Text), CInt(lblCodFilialCliente.Text), cbPacote.SelectedValue, codtabela)
        If tb.Rows.Count > 0 Then
            carrega_servicos()
            lblCodigoProduto.Text = tb.Rows(0)("cod_tabela")
            txtProduto.Text = tb.Rows(0)("nome_comercial")
            txtQuant.Text = tb.Rows(0)("quantidade_contratada")
            txtDesconto.Text = tb.Rows(0)("desconto")
            lblPreco.Text = Format(CDbl(tb.Rows(0)("preco_tabela")), "#,##0.00")
            lblPrecoProdPacDesc.Text = Format(CDbl(tb.Rows(0)("preco_desc")), "#,##0.00")
            cbSurfacagem.SelectedValue = tb.Rows(0)("cod_surf")
            lblPrecoSuf.Text = Format(CDbl(tb.Rows(0)("preco_tabela_surf")), "#,##0.00")
            txtQtdeSurf.Text = tb.Rows(0)("quantidade_surf")
            txtDescSurf.Text = Format(CDbl(tb.Rows(0)("desc_surf")), "#,##0.00")
            lblPrecoDescSurf.Text = Format(CDbl(tb.Rows(0)("preco_surf_desc")), "#,##0.00")
            cbMontagem.SelectedValue = tb.Rows(0)("cod_mont")
            lblPrecoMont.Text = Format(CDbl(tb.Rows(0)("preco_tabela_mont")), "#,##0.00")
            txtQuantMont.Text = tb.Rows(0)("quantidade_mont")
            txtDescMont.Text = Format(CDbl(tb.Rows(0)("desc_mont")), "#,##0.00")
            lblPrecoDescMont.Text = Format(CDbl(tb.Rows(0)("preco_mont_desc")), "#,##0.00")
            cbTratamento.SelectedValue = tb.Rows(0)("cod_trat")
            lblPrecoTrat.Text = Format(CDbl(tb.Rows(0)("preco_tabela_trat")), "#,##0.00")
            txtQuantTrat.Text = tb.Rows(0)("quantidade_trat")
            txtDescTrat.Text = Format(CDbl(tb.Rows(0)("desc_trat")), "#,##0.00")
            lblPrecoDescTrat.Text = Format(CDbl(tb.Rows(0)("preco_trat_desc")), "#,##0.00")
            travaControles(tbPacoteDesconto.Controls)
            valortotalproduto()
        End If
    End Sub
    Private Sub btnNovoPacote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovoItemPacote.Click
        ativaControle()
        DestravaControles(tbPacoteDesconto.Controls)
        btnNovoItemPacote.Enabled = False
        LimpaControles(tbPacoteDesconto.Controls)
        pacote.pacoteDet.novo()
        txtDescMont.Text = CDbl(0.0)
        txtDescSurf.Text = CDbl(0.0)
        txtDescTrat.Text = CDbl(0.0)
        lblCodigoProduto.Text = ""
        txtProduto.Text = ""
        txtQuant.Text = ""
        txtDesconto.Text = ""
        lblPreco.Text = CDbl(0.0)
        lblPrecoProdPacDesc.Text = CDbl(0.0)
        lblPrecoSuf.Text = CDbl(0.0)
        txtQtdeSurf.Text = 0
        txtDescSurf.Text = CDbl(0.0)
        lblPrecoDescSurf.Text = CDbl(0.0)
        lblPrecoMont.Text = CDbl(0.0)
        txtQuantMont.Text = 0
        txtDescMont.Text = CDbl(0.0)
        lblPrecoDescMont.Text = CDbl(0.0)
        lblPrecoTrat.Text = CDbl(0.0)
        txtQuantTrat.Text = 0
        txtDescTrat.Text = CDbl(0.0)
        lblPrecoDescTrat.Text = CDbl(0.0)

        lblTotal.Text = 0.0
        lblCodigoProduto.Focus()
    End Sub
    Private Sub btnSalvarPacote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarPacote.Click
        If (lblCodigoProduto.Text = "") Or (txtProduto.Text = "") Or (txtQuant.Text = "") Or (txtDesconto.Text = "") Then
            MessageBox.Show("Preencha os campos necessários para os itens do pacote.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If MessageBox.Show("Deseja salvar o item de pacote?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim item As Integer = Conexao.RetornaChave("item", "pacote_cliente_detalhes", "where cod_pacote = " & cbPacote.SelectedValue &
            " and cod_cliente = " & CInt(txtCodCliente.Text) & " and cod_filial_cliente = " & CInt(lblCodFilialCliente.Text))
            Dim codpacote As Integer = CInt(cbPacote.SelectedValue)
            Dim codtabela As Integer = CInt(lblCodigoProduto.Text)
            Dim codfilialcliente As Integer = CInt(lblCodFilialCliente.Text)
            Dim codcliente As Integer = CInt(txtCodCliente.Text)
            Dim desconto As Double = CDbl(txtDesconto.Text)
            Dim quant As Integer = CInt(txtQuant.Text)
            Dim codsurf As Integer = CInt(cbSurfacagem.SelectedValue)
            Dim descsurf As Double = CDbl(txtDescSurf.Text)
            Dim codmontagem As Integer = CInt(cbMontagem.SelectedValue)
            Dim descmontagem As Double = CDbl(txtDescMont.Text)
            Dim codtrat As Integer = CInt(cbTratamento.SelectedValue)
            Dim desctratamento As Double = CDbl(txtDescTrat.Text)
            Dim precotabela As Double = CDbl(lblPreco.Text)
            Dim precodesc As Double = CDbl(lblPrecoProdPacDesc.Text)
            Dim precotabelasurf As Double = CDbl(lblPrecoSuf.Text)
            Dim precosurfdesc As Double = CDbl(lblPrecoDescSurf.Text)
            Dim quantsurf As Integer = CInt(txtQtdeSurf.Text)
            Dim precotabelamont As Double = CDbl(lblPrecoMont.Text)
            Dim precomontdesc As Double = CDbl(lblPrecoDescMont.Text)
            Dim quantmont As Integer = CInt(txtQuantMont.Text)
            Dim precotabelatrat As Double = CDbl(lblPrecoTrat.Text)
            Dim precotratdesc As Double = CDbl(lblPrecoDescTrat.Text)
            Dim quanttrat As Integer = CInt(txtQuantTrat.Text)
            Dim statusitem As Char = "L"
            Dim codpacoteant As Integer = 0
            'Instrução para gravar os itens de pacotes
            Dim strSQL As String = "Insert into pacote_cliente_detalhes (cod_pacote,item,cod_tabela,cod_filial_cliente,cod_cliente,desconto" &
            ",quantidade_contratada,cod_surf,desc_surf,cod_mont,desc_mont,cod_trat,desc_trat,preco_tabela,preco_desc, " &
            "preco_tabela_surf,preco_surf_desc,quantidade_surf,preco_tabela_mont,preco_mont_desc,quantidade_mont,preco_tabela_trat," &
            "preco_trat_desc,quantidade_trat,status_item,cod_pacote_ant,cod_usuario) " &
            "Values(" & codpacote & "," & item & "," & codtabela & "," & codfilialcliente & "," & codcliente & "," & Geral.ValorMoeda(desconto) & "," &
            quant & "," & codsurf & "," & Geral.ValorMoeda(descsurf) & "," & codmontagem & "," & Geral.ValorMoeda(descmontagem) & "," & codtrat & "," &
             Geral.ValorMoeda(desctratamento) & "," & Geral.ValorMoeda(precotabela) & "," & Geral.ValorMoeda(precodesc) & "," & Geral.ValorMoeda(precotabelasurf) & "," &
            Geral.ValorMoeda(precosurfdesc) & "," & quantsurf & "," & Geral.ValorMoeda(precotabelamont) & "," & Geral.ValorMoeda(precomontdesc) & "," & quantmont &
            "," & Geral.ValorMoeda(precotabelatrat) & "," & Geral.ValorMoeda(precotratdesc) & "," & quanttrat & "," & Geral.AspasSQL(statusitem) &
            "," & codpacoteant & "," & intUsuario & ")"

            Conexao.SalvaAtualizaExcluiReg(strSQL) 'Instrução responsável por salvar os itens dentro do pacote para o cliente atual

            btnNovoItemPacote.Enabled = True
            desativaControle()
            FormatPacote() 'Dá um refresh no grid do pacote de itens
            MessageBox.Show("Item do pacote salvo com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Operação cancelada com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub txtProduto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtProduto.KeyDown
        Dim f As New frmConsultaProduto
        f.ShowDialog(Me)
        lblCodigoProduto.Text = f.cod_prod
        txtProduto.Text = f.nome_prod
        f.Dispose()
    End Sub


    Private Sub btnConcluirPacote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConcluirPacote.Click
    End Sub

    Private Sub carrega_servicos()
        Dim sql As String
        Dim tt As New DataTable
        Dim ttSurf As New DataTable
        Dim ttMont As New DataTable
        Dim ttTrat As New DataTable
        Dim r, rr As DataRow
        ttSurf.Columns.Add("cod_prod")
        ttSurf.Columns.Add("servico")
        ttMont.Columns.Add("cod_prod")
        ttMont.Columns.Add("servico")
        ttTrat.Columns.Add("cod_prod")
        ttTrat.Columns.Add("servico")
        sql = "SELECT servicos.cod_produto,produtos.produto FROM produtos INNER JOIN " &
        "servicos ON produtos.cod_produto = servicos.cod_produto WHERE (servicos.cod_tipo_servico = 1)"
        Conexao.CarregaTabela(sql, tt)
        Try
            r = ttSurf.NewRow
            r("cod_prod") = 0
            r("servico") = "Sem Surfaçagem"
            ttSurf.Rows.Add(r)
            For Each rr In tt.Rows
                r = ttSurf.NewRow
                r("cod_prod") = wrNum(rr("cod_produto"))
                r("servico") = rdTexto(rr("produto"))
                ttSurf.Rows.Add(r)
            Next
            cbSurfacagem.DataSource = ttSurf
            cbSurfacagem.DisplayMember = "servico"
            cbSurfacagem.ValueMember = "cod_prod"
            sql = "SELECT servicos.cod_produto,produtos.produto FROM produtos INNER JOIN " &
           "servicos ON produtos.cod_produto = servicos.cod_produto WHERE (servicos.cod_tipo_servico = 2)"
            Conexao.CarregaTabela(sql, tt)
            r = ttMont.NewRow
            r("cod_prod") = 0
            r("servico") = "Sem Montagem"
            ttMont.Rows.Add(r)
            For Each rr In tt.Rows
                r = ttMont.NewRow
                r("cod_prod") = wrNum(rr("cod_produto"))
                r("servico") = rdTexto(rr("produto"))
                ttMont.Rows.Add(r)
            Next
            cbMontagem.DataSource = ttMont
            cbMontagem.DisplayMember = "servico"
            cbMontagem.ValueMember = "cod_prod"

            'Ivanildo 19/10
            sql = "SELECT servicos.cod_produto,produtos.produto FROM produtos INNER JOIN " &
            "servicos ON produtos.cod_produto = servicos.cod_produto WHERE (servicos.cod_tipo_servico = 4)"
            Conexao.CarregaTabela(sql, tt)
            r = ttTrat.NewRow
            r("cod_prod") = 0
            r("servico") = "Sem Tratamento"
            ttTrat.Rows.Add(r)
            For Each rr In tt.Rows
                r = ttTrat.NewRow
                r("cod_prod") = wrNum(rr("cod_produto"))
                r("servico") = rdTexto(rr("produto"))
                ttTrat.Rows.Add(r)
            Next
            cbTratamento.DataSource = ttTrat
            cbTratamento.DisplayMember = "servico"
            cbTratamento.ValueMember = "cod_prod"
            'Fim
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

#End Region
#Region "Pedidos "
    Private Sub formata_grid_pedidos()
        grdPedidos.Columns.Clear()
        grdPedidos.AutoGenerateColumns = False
        grdPedidos.AllowUserToAddRows = False
        grdPedidos.DataSource = Nothing

        Dim cFilial As New DataGridViewTextBoxColumn
        With cFilial
            .DataPropertyName = "id_filial"
            .HeaderText = "Filial"
            .Width = 40
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With
        grdPedidos.Columns.Add(cFilial)

        Dim cNum As New DataGridViewTextBoxColumn
        With cNum
            .DataPropertyName = "num_Pedido"
            .HeaderText = "Nº Pedido"
            .Width = 80
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With
        grdPedidos.Columns.Add(cNum)

        Dim cData As New DataGridViewTextBoxColumn
        With cData
            .DataPropertyName = "data_pedido"
            .HeaderText = "Data Pedido"
            .Width = 110
        End With
        grdPedidos.Columns.Add(cData)

        Dim cStatus As New DataGridViewTextBoxColumn
        With cStatus
            .DataPropertyName = "status_pedido"
            .HeaderText = "Status Pedido"
            .Width = 150
        End With
        grdPedidos.Columns.Add(cStatus)

        Dim cVend As New DataGridViewTextBoxColumn
        With cVend
            .DataPropertyName = "nome"
            .HeaderText = "Vendedor(a)"
            .Width = 165
        End With
        grdPedidos.Columns.Add(cVend)

        Dim cFaturado As New DataGridViewCheckBoxColumn
        With cFaturado
            cFaturado.TrueValue = 1
            cFaturado.FalseValue = 0
            .DataPropertyName = "faturado"
            .HeaderText = "Faturado"
            .Width = 70
        End With
        grdPedidos.Columns.Add(cFaturado)

        Dim ctotal As New DataGridViewTextBoxColumn
        With ctotal
            .DataPropertyName = "total"
            .HeaderText = "Total"
            .DefaultCellStyle.Format = "#,##0.00"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With
        grdPedidos.Columns.Add(ctotal)

        Dim nFatura As New DataGridViewTextBoxColumn
        With nFatura
            .DataPropertyName = "n_fatura"
            .HeaderText = "Nº Fatura"
            .Width = 80
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With
        grdPedidos.Columns.Add(nFatura)

        Dim OS As New DataGridViewTextBoxColumn
        With OS
            .DataPropertyName = "OS"
            .HeaderText = "Nº OS"
            .Width = 70
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With
        grdPedidos.Columns.Add(OS)

        Dim forma As New DataGridViewTextBoxColumn
        With forma
            .DataPropertyName = "forma"
            .HeaderText = "Forma"
            .Visible = False
        End With
        grdPedidos.Columns.Add(forma)

        grdPedidos.DataSource = tb_pedidos

    End Sub

    Private Sub filtra_pedidos()
        titPedidos = "Pedidos do Cliente: " & txtNome.Text & ""
        If rbData.Checked = True Then
            tb_pedidos = Cli.PedidoClienteFaturado(Cli.CodigoCliente, Cli.CodigoFilialCliente, dtPedidoIni.Value.Date,
            dtPedidoFim.Value)
            titPedidos = "Pedidos do Cliente: " & txtNome.Text & ". " & vbCrLf &
            " Período: entre " & dtPedidoIni.Value.Date &
            " e " & dtPedidoFim.Value.Date & ""
            formata_grid_pedidos()
        Else
            tb_pedidos = Cli.PedidosClientes
            formata_grid_pedidos()
        End If
    End Sub
    Private Sub txtDesconto_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDesconto.DoubleClick
        Dim preco_final As Double
        Dim desconto As Double
        Dim pd As Double
        preco_final = InputBox("Informe o preço final:")
        desconto = tabela.preco_venda - preco_final
        pd = (desconto / tabela.preco_venda) * 100
        txtDesconto.Text = pd
    End Sub
#End Region

#Region "Faturas "
    Private Sub formata_grid_faturas()

        grdFaturas.Columns.Clear()
        grdFaturas.DataSource = Nothing
        grdFaturas.AllowUserToAddRows = False
        grdFaturas.AutoGenerateColumns = False

        Dim cFatura As New DataGridViewTextBoxColumn
        With cFatura
            .DataPropertyName = "cod_fatura"
            .HeaderText = "Fatura"
            .Width = 60
        End With
        grdFaturas.Columns.Add(cFatura)

        Dim cData As New DataGridViewTextBoxColumn
        With cData
            .DataPropertyName = "data_lancamento"
            .HeaderText = "Data"
            .Width = 80
            .DefaultCellStyle.Format = "dd/MM/yyyy"
        End With
        grdFaturas.Columns.Add(cData)

        Dim cValor As New DataGridViewTextBoxColumn
        With cValor
            .DataPropertyName = "total_fatura"
            .HeaderText = "Total Fatura"
            .Width = 100
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .DefaultCellStyle.Format = "#,##0.00"
        End With
        grdFaturas.Columns.Add(cValor)

        Dim cPago As New DataGridViewTextBoxColumn
        With cPago
            .DataPropertyName = "pago"
            .HeaderText = "Valor Pago"
            .Width = 100
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .DefaultCellStyle.Format = "#,##0.00"
        End With
        grdFaturas.Columns.Add(cPago)

        Dim cacrescimo As New DataGridViewTextBoxColumn
        With cacrescimo
            .DataPropertyName = "acrescimo"
            .HeaderText = "V. Acréscimo"
            .Width = 100
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .DefaultCellStyle.Format = "#,##0.00"
        End With
        grdFaturas.Columns.Add(cacrescimo)

        Dim cDesc As New DataGridViewTextBoxColumn
        With cDesc
            .DataPropertyName = "desconto"
            .HeaderText = "V. Desconto."
            .Width = 100
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .DefaultCellStyle.Format = "#,##0.00"
        End With
        grdFaturas.Columns.Add(cDesc)

        Dim cSaldo As New DataGridViewTextBoxColumn
        With cSaldo
            .DataPropertyName = "saldo"
            .HeaderText = "Saldo"
            .Width = 100
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .DefaultCellStyle.Format = "#,##0.00"
        End With
        grdFaturas.Columns.Add(cSaldo)

        Dim cFilial As New DataGridViewTextBoxColumn
        With cFilial
            .DataPropertyName = "id_filial"
            .HeaderText = "Filial"
            .Width = 50
        End With
        grdFaturas.Columns.Add(cFilial)


        If chkFiltroFatura.Checked = True Then
            Dim di, df As String
            di = dtFatIni.Value.ToShortDateString & " 00:00:00"
            df = dtFatFim.Value.ToShortDateString & " 23:59:59"
            grdFaturas.DataSource = Cli.FaturasCliente(di, df)
        Else
            grdFaturas.DataSource = Cli.FaturasCliente()
        End If

        saldo_fatura()
    End Sub
    Private Sub saldo_fatura()
        Dim receber As Double 'Variável que guardará o resultado do saldo de faturas do cliente
        Dim pagar As Double
        pagar = Cli.SaldoFaturasClienteApagar
        receber = Cli.SaldoFaturasClienteAreceber

        'Avalia se o resultado é maior que zero, caso seja, o cliente tem débito de faturas 
        'a pagar e o resultado será exibido em vermelho, caso contrário o resultado será 
        'exibido em azul.
        If pagar < 0 Then
            lblSaldoFatura.ForeColor = Color.Blue
            lblSaldoFatura.Text = Format(CDbl(pagar), "#,##0.00")
        End If

        If receber > 0 Then
            lblSaldoReceber.ForeColor = Color.Red
            lblSaldoReceber.Text = Format(CDbl(receber), "#,##0.00")
        End If

    End Sub

#End Region
#Region "OS"
    Private Sub formata_grid_OS(ByVal tipo As Integer)
        grdOS.Columns.Clear()
        grdOS.DataSource = Nothing
        grdOS.AutoGenerateColumns = False
        grdOS.AllowUserToAddRows = False

        Dim filial As New DataGridViewTextBoxColumn
        filial.DataPropertyName = "id_filial"
        filial.HeaderText = "Filial"
        filial.Width = 35
        filial.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdOS.Columns.Add(filial)

        Dim os As New DataGridViewTextBoxColumn
        os.DataPropertyName = "cod_os"
        os.HeaderText = "OS"
        os.Width = 70
        os.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdOS.Columns.Add(os)

        Dim fase As New DataGridViewTextBoxColumn
        fase.DataPropertyName = "fase"
        fase.HeaderText = "Fase"
        fase.Width = 220
        grdOS.Columns.Add(fase)

        Dim obs As New DataGridViewTextBoxColumn
        obs.DataPropertyName = "observacao"
        obs.HeaderText = "Obs"
        obs.Width = 530
        grdOS.Columns.Add(obs)

        If tipo = 1 Then
            grdOS.DataSource = Cli.OSCliente
        Else
            Dim dt1 As String = Geral.DataSQL(dtInicial.Value & " 00:00:01")
            Dim dt2 As String = Geral.DataSQL(dtFinal.Value & " 23:59:59")
            grdOS.DataSource = Cli.OSCliente(dt1, dt2)
        End If


    End Sub

    Private Sub PrintOS(ByVal filial As Integer, ByVal os As Integer)
        Dim tsql As String
        Dim tt As New DataTable
        Dim r As New rptOS
        Dim f As New frmRpt
        Dim d As New dados
        tsql = "Select os.*, (select nome_comercial from lentes_tabela where cod_tabela = os.cod_tab_od) as TAB_OD, " &
        "(select nome_comercial from lentes_tabela where cod_tabela = os.cod_tab_oe) as TAB_OE, " &
        "(select produto from produtos where cod_produto = os.cod_produto_od) as EST_OD," &
        "(select produto from produtos where cod_produto = os.cod_produto_oe) as EST_OE, " &
        "(select produto from produtos where cod_produto = os.cod_montagem) as Armacao " &
        "FROM OS where os.id_filial = " & filial &
        "and OS.cod_os = " & os & ""
        d.carrega_Tabela(tsql, tt)
        r.DataSource = tt
        r.Fila = False

        pedido.carrega_pedido(tt.Rows(0)("num_pedido"), tt.Rows(0)("id_filial"))
        tb_itens = pedido.lista_itens(tt.Rows(0)("num_pedido"), tt.Rows(0)("id_filial"), False)
        tb_servico = pedido.lista_servicos(tt.Rows(0)("num_pedido"), tt.Rows(0)("id_filial"))

        r.r.filial = pedido.id_filial
        r.r.n_pedido = pedido.num_pedido
        r.r.data = pedido.data_pedido
        r.r.cliente = "Ivanildo Ferreira"
        r.r.Vendedor = "Renata Pereira"
        r.r.cod_cliente = pedido.cod_cliente
        r.r.Total = lblTotal.Text
        r.r.Barcode1.Text = pedido.cod_filial_cliente.ToString.PadLeft(2, "0") & pedido.cod_cliente.ToString.PadLeft(5, "0") & pedido.num_pedido.ToString.PadLeft(7, "0")
        r.r.tbItens = tb_itens
        r.r.tbServ = tb_servico
        r.r.Total = Format(pedido.total_itens + pedido.total_servicos, "#,##0.00")

        r.r2.filial = pedido.id_filial
        r.r2.n_pedido = pedido.num_pedido
        r.r2.data = pedido.data_pedido
        r.r2.cliente = Cli.NomeCliente
        r.r2.Vendedor = acesso.retornaUsuario(intUsuario)
        r.r2.cod_cliente = pedido.cod_cliente
        r.r2.Total = lblTotal.Text
        r.r2.Barcode1.Text = pedido.cod_filial_cliente.ToString.PadLeft(2, "0") & pedido.cod_cliente.ToString.PadLeft(5, "0") & pedido.num_pedido.ToString.PadLeft(7, "0")
        r.r2.tbItens = tb_itens
        r.r2.tbServ = tb_servico
        r.r2.Total = Format(pedido.total_itens + pedido.total_servicos, "#,##0.00")

        Dim strSQLForma As String = "select descricao from tipo_compra where codigo = " & pedido.forma_pagamento
        Dim ttForma As New DataTable
        ttForma = acesso.retornaRegistro(strSQLForma).Tables(0)

        If ttForma.Rows.Count > 0 Then
            r.r.TextBox2.Text = ttForma.Rows(0)("descricao")
            r.r2.TextBox2.Text = ttForma.Rows(0)("descricao")
        Else
            r.r.TextBox2.Text = "Não Informado."
            r.r2.TextBox2.Text = "Não Informado."
        End If


        f.Relat(r)
        f.Show()
    End Sub
#End Region
#Region "Credito"
    Dim cred As New objCreditoCliente
    Private Sub carrega_creditos()
        grdCred.Columns.Clear()
        grdCred.DataSource = Nothing
        grdCred.AllowUserToAddRows = False
        grdCred.AutoGenerateColumns = False

        Dim historico As New DataGridViewTextBoxColumn
        historico.HeaderText = "Histórico"
        historico.DataPropertyName = "Historico"
        historico.Width = 440
        grdCred.Columns.Add(historico)

        Dim data As New DataGridViewTextBoxColumn
        data.HeaderText = "Data"
        data.DataPropertyName = "data"
        data.Width = 100
        data.DefaultCellStyle.Format = "dd/MM/yyyy"
        data.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdCred.Columns.Add(data)

        Dim creditoant As New DataGridViewTextBoxColumn
        creditoant.HeaderText = "Crédito Anterior"
        creditoant.DataPropertyName = "credito_anterior"
        creditoant.Width = 120
        creditoant.DefaultCellStyle.Format = "#,##0.00"
        creditoant.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdCred.Columns.Add(creditoant)

        Dim credito As New DataGridViewTextBoxColumn
        credito.HeaderText = "Crédito"
        credito.DataPropertyName = "credito"
        credito.Width = 100
        credito.DefaultCellStyle.Format = "#,##0.00"
        credito.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdCred.Columns.Add(credito)

        Dim saldo As New DataGridViewTextBoxColumn
        saldo.HeaderText = "Saldo"
        saldo.DataPropertyName = "saldo"
        saldo.Width = 100
        saldo.DefaultCellStyle.Format = "#,##0.00"
        saldo.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdCred.Columns.Add(saldo)

        grdCred.DataSource = cred.lista_creditos(Cli.CodigoFilialCliente, Cli.CodigoCliente)
        lblSaldoCredito.Text = "Saldo Crédito: " & Format(cred.Saldo_anterior(Cli.CodigoFilialCliente, Cli.CodigoCliente), "#,##0.00")
    End Sub
#End Region
#Region "Titulos Cheques"
    Private Sub carrega_titulos()
        Dim tt As New DataTable
        Dim dRecebimento As String

        grdTitulos.Columns.Clear()
        grdTitulos.AutoGenerateColumns = False
        grdTitulos.AllowUserToAddRows = False
        grdTitulos.DataSource = Nothing

        Dim nossonumero As New DataGridViewTextBoxColumn 'Posição 00
        nossonumero.HeaderText = "Nosso Número"
        nossonumero.DataPropertyName = "nossonumero"
        nossonumero.Width = 120
        nossonumero.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdTitulos.Columns.Add(nossonumero)

        Dim tipodocumento As New DataGridViewTextBoxColumn 'Posição 01
        tipodocumento.HeaderText = "T. Doc."
        tipodocumento.DataPropertyName = "tipo_documento"
        tipodocumento.Width = 70
        tipodocumento.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grdTitulos.Columns.Add(tipodocumento)

        Dim documento As New DataGridViewTextBoxColumn 'Posição 02
        documento.HeaderText = "Nº Documento"
        documento.DataPropertyName = "documento"
        documento.Width = 100
        documento.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdTitulos.Columns.Add(documento)

        Dim emissao As New DataGridViewTextBoxColumn 'Posição 03
        emissao.HeaderText = "Emissão"
        emissao.DataPropertyName = "data_lancamento"
        emissao.Width = 80
        emissao.DefaultCellStyle.Format = "dd/MM/yyyy"
        emissao.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdTitulos.Columns.Add(emissao)

        Dim vencimento As New DataGridViewTextBoxColumn 'Posição 04
        vencimento.HeaderText = "Vencimento"
        vencimento.DataPropertyName = "data_vencimento"
        vencimento.Width = 80
        vencimento.DefaultCellStyle.Format = "dd/MM/yyyy"
        vencimento.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdTitulos.Columns.Add(vencimento)

        Dim valor As New DataGridViewTextBoxColumn 'Posição 05
        valor.HeaderText = "Valor"
        valor.DataPropertyName = "valor"
        valor.Width = 80
        valor.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        valor.DefaultCellStyle.Format = "#,##0.00"
        grdTitulos.Columns.Add(valor)

        Dim pagamento As New DataGridViewTextBoxColumn 'Posição 06
        pagamento.HeaderText = "Pagamento"
        pagamento.DataPropertyName = "data_recebimento"
        pagamento.Width = 80
        pagamento.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdTitulos.Columns.Add(pagamento)

        Dim lancamento As New DataGridViewTextBoxColumn 'Posição 07
        lancamento.HeaderText = "Lançamento"
        lancamento.DataPropertyName = "cod_lancamento"
        lancamento.Width = 80
        lancamento.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdTitulos.Columns.Add(lancamento)

        Dim filial As New DataGridViewTextBoxColumn 'Posição 08
        filial.HeaderText = "Filial"
        filial.DataPropertyName = "id_filial"
        filial.Width = 30
        filial.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        filial.Visible = False
        grdTitulos.Columns.Add(filial)

        Dim filiallanc As New DataGridViewTextBoxColumn 'Posição 09
        filiallanc.HeaderText = "Filial Lanc"
        filiallanc.DataPropertyName = "id_filial_lancamento"
        filiallanc.Width = 30
        filiallanc.Visible = False
        filiallanc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdTitulos.Columns.Add(filiallanc)

        tt = Cli.TitulosCliente
        grdTitulos.DataSource = tt

        lblTotalAtrasoTitulos.Text = String.Format("{0:##0.00}", Cli.TitulosAtrasoClienteTotal)
        lblTotalPendenteTitulos.Text = String.Format("{0:##0.00}", Cli.TitulosClientePendenteTotalSemAtraso)
        lblTotalTitulosPendentes.Text = Format(CDbl(lblTotalAtrasoTitulos.Text) + CDbl(lblTotalPendenteTitulos.Text), "#,##0.00")
    End Sub
    Private Sub carrega_cheques()
        grdCheques.DataSource = Cli.ChequesCliente
        grdCheques.Refresh()
    End Sub
    Private Sub carrega_restricoes()
        Dim tt As New DataTable
        tt = Cli.RestricaoCliente(True)
        restricoes_bloqueado()
    End Sub

    Private Sub formata_grid_resumo()
        grdResumo.Columns.Clear()
        grdResumo.DataSource = Nothing

        grdResumo.AutoGenerateColumns = False
        grdResumo.AllowUserToAddRows = False


        Dim cPedidos As New DataGridViewTextBoxColumn
        With cPedidos
            .DataPropertyName = "Pedidos"
            .HeaderText = "Ped. Aberto"
            .Width = 90
            .DefaultCellStyle.Format = "#,##0.00"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With
        grdResumo.Columns.Add(cPedidos)


        Dim cFaturas As New DataGridViewTextBoxColumn
        With cFaturas
            .DataPropertyName = "Faturas_aberto"
            .HeaderText = "Fat. Aberto"
            .Width = 90
            .DefaultCellStyle.Format = "#,##0.00"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With
        grdResumo.Columns.Add(cFaturas)


        Dim cTitAtraso As New DataGridViewTextBoxColumn
        With cTitAtraso
            .DataPropertyName = "titulos_atraso"
            .HeaderText = "Bol. Atraso"
            .Width = 90
            .DefaultCellStyle.Format = "#,##0.00"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With
        grdResumo.Columns.Add(cTitAtraso)

        Dim cTitVencer As New DataGridViewTextBoxColumn
        With cTitVencer
            .DataPropertyName = "titulos_vencer"
            .HeaderText = "Bol. a Vencer"
            .Width = 100
            .DefaultCellStyle.Format = "#,##0.00"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With
        grdResumo.Columns.Add(cTitVencer)

        Dim cTitTotal As New DataGridViewTextBoxColumn
        With cTitTotal
            .DataPropertyName = "titulos_aberto"
            .HeaderText = "Tot. Boletos"
            .Width = 90
            .DefaultCellStyle.Format = "#,##0.00"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With
        grdResumo.Columns.Add(cTitTotal)

        Dim cAcordoAtrasado As New DataGridViewTextBoxColumn
        With cAcordoAtrasado
            .DataPropertyName = "acordo_atrasado"
            .HeaderText = "Acordo Atrasado"
            .Width = 110
            .DefaultCellStyle.Format = "#,##0.00"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With
        grdResumo.Columns.Add(cAcordoAtrasado)

        Dim cCheques As New DataGridViewTextBoxColumn
        With cCheques
            .DataPropertyName = "cheques_vencer"
            .HeaderText = "Cheques"
            .Width = 90
            .DefaultCellStyle.Format = "#,##0.00"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With
        grdResumo.Columns.Add(cCheques)

        Dim ctotal As New DataGridViewTextBoxColumn
        With ctotal
            .DataPropertyName = "total_aberto"
            .HeaderText = "Total Aberto"
            .Width = 90
            .DefaultCellStyle.Format = "#,##0.00"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With
        grdResumo.Columns.Add(ctotal)

        grdResumo.DataSource = Cli.ResumoReceberCliente
    End Sub
#End Region

    Private Sub btnImprimirPedidos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirPedidos.Click
        Dim rpt As New rptPedidosCliente
        Dim f As New frmRpt
        rpt.DataSource = tb_pedidos
        rpt.TITULO = titPedidos
        f.Relat(rpt)
        f.Show()
    End Sub

    Private Sub CancelarPedidoZeradoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarPedidoZeradoToolStripMenuItem.Click
        Dim filial, pedido As Integer
        Dim ped As New objPedidoBalcao
        filial = grdPedidos.CurrentRow.Cells(0).Value
        pedido = grdPedidos.CurrentRow.Cells(1).Value
        ped.carrega_pedido(pedido, filial)
        If ped.max > 0 Then
            MsgBox(ped.cancela_pedido_zerado(filial, pedido))
            filtra_pedidos()
        Else
            MsgBox("Pedido não encontrado!")
        End If
    End Sub

    Private Sub grdPedidos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdPedidos.DoubleClick
        Dim intContador As Integer = 0
        Dim fil_pedido As Integer
        Dim n_pedido As Integer
        Dim pedido As New objPedidoBalcao
        fil_pedido = grdPedidos.CurrentRow.Cells(0).Value
        n_pedido = grdPedidos.CurrentRow.Cells(1).Value
        pedido.carrega_pedido(n_pedido, fil_pedido)

        If restricoes_bloqueado() = 4 Then
            intContador = 4
Inicio:
            If pedido.cod_tipo_pedido = 1 Then
                Dim f As New frmPedido
                Try
                    f._num_pedido = n_pedido
                    f._id_filial = fil_pedido
                Catch ex As Exception
                    Exit Sub
                End Try
                f.intContador = intContador
                f.ShowDialog()
                filtra_pedidos()
            Else
                Dim f As New frmPedidoProducao
                Try
                    f._num_pedido = n_pedido
                    f._id_filial = fil_pedido
                Catch ex As Exception
                    Exit Sub
                End Try
                f.origem = "editar"
                f.ShowDialog()
                filtra_pedidos()
            End If

        Else
            intContador = restricoes_bloqueado()
            If (intContador = 1) Or (intContador = 2) Then
                MessageBox.Show("Cliente bloqueado por atraso na fatura ou pagamento de acordo." & Chr(13) & "Somente venda a vista.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf intContador = 3 Then
                MessageBox.Show("Cliente sem limite de crédito. Somente venda a vista.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            GoTo Inicio
        End If

    End Sub

    Private Sub btnNovoPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovoPedido.Click
        Dim intContador As Integer = 0
        Dim aut As Integer
        intUsuario = Usu.CodigoUsuario
        Dim intAcesso As Integer = Usu.VerificaPermissaoMenu(intUsuario)
        'aut = clientenovo.consulta_autorizacao
        Dim strSQL As String = "select * from pedido_autorizacao where cod_cliente = " & Cli.CodigoCliente &
            " and cod_filial_cliente = " & Cli.CodigoFilialCliente & " and num_pedido is null and id_filial_pedido is null"
        If Conexao.VerificaExistenciaReg(strSQL) = True Then
            aut = 1
            intContador = restricoes_bloqueado()
            GoTo Inicio
        End If

        If Cli.CodigoTipoCliente <> 2 Then
            If restricoes_bloqueado() = 4 Then
                intContador = restricoes_bloqueado()
Inicio:

                'Procedimento 6: Inserir Item Pedido
                If Usu.VerificaPermissaoUsuario(4) = False Then
                    MessageBox.Show("Usuário não tem permissão para gerar novo pedido!", "ERROR: 4", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                Dim f As New frmPedido
                pedido.novo()
                pedido.id_filial = conf.Filial
                pedido.data_pedido = Now
                pedido.cod_vendedor = intUsuario
                pedido.autorizacao = aut
                pedido.cod_filial_cliente = Cli.CodigoFilialCliente
                pedido.cod_cliente = Cli.CodigoCliente

                If (intContador = 1) Or (intContador = 2) Then
                    pedido.forma_pagamento = 1
                End If

                If pedido.Salvar.StartsWith("OK") Then
                    Try
                        f._num_pedido = pedido.num_pedido
                        f._id_filial = pedido.id_filial
                    Catch ex As Exception
                        Exit Sub
                    End Try
                    'f.origem = "editar"
                    f.intContador = intContador
                    If aut = 1 Then
                        Dim strSQLAut As String = "update pedido_autorizacao set num_pedido = " & pedido.num_pedido & ", id_filial_pedido = " & conf.Filial
                        Conexao.SalvaAtualizaExcluiReg(strSQLAut)
                    End If
                    f.ShowDialog()
                    filtra_pedidos()
                End If
            Else
                intContador = restricoes_bloqueado() 'Define o tipo de restrição para o bloqueio: 1 = Acordo atraso; 2 = Titulos em Atraso; 3 = Sem limite de crédito
                If (intContador = 1) Or (intContador = 2) Then

                    If intContador = 1 Then 'Se o cliente estiver coma cordo em atraso a um período superior a 7 dias fica bloqueado sem comprar
                        If intDia >= 7 Then
                            MessageBox.Show("Cliente não pode realizar compra devido está bloqueado" & Chr(13) &
                            "por falta de pagamento de acordo a mais de 7 dias.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Sub
                        End If
                    End If

                    If intDia > 0 Then
                        MessageBox.Show("Cliente bloqueado por atraso na fatura ou pagamento de acordo." & Chr(13) & "Somente venda a vista." & Chr(13) &
                        "Faltam " & intDia & " dias para o cliente ser bloqueado definitivamente.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        MessageBox.Show("Cliente não pode realizar compra devido está bloqueado" & Chr(13) &
                                        "por falta de pagamento há mais de 60 dias em atraso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                    intDia = 0
                ElseIf intContador = 3 Then
                    MessageBox.Show("Cliente sem limite de crédito. Somente venda a vista.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
                GoTo Inicio
            End If
        Else
            Dim f As New frmPedido
            pedido.novo()
            pedido.id_filial = conf.Filial
            pedido.data_pedido = Now
            pedido.cod_vendedor = intUsuario
            pedido.autorizacao = aut
            pedido.cod_filial_cliente = Cli.CodigoFilialCliente
            pedido.cod_cliente = Cli.CodigoCliente
            pedido.Salvar()
            f._num_pedido = pedido.num_pedido
            f._id_filial = pedido.id_filial
            f.intTipoCliente = 2
            f.cbForma.Enabled = False
            f.ShowDialog()
            filtra_pedidos()
        End If

    End Sub

    Private Sub btnNovaOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovaOS.Click
        intUsuario = Usu.CodigoUsuario
        If Usu.VerificaPermissaoUsuario(1) = False Then
            MessageBox.Show("Usuário não tem permissão para gerar nova OS.", "ERROR: 1", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim intContador As Integer = 0
        Dim aut As Int16

        Dim strSQL As String = "select * from pedido_autorizacao where cod_cliente = " & Cli.CodigoCliente &
        " and cod_filial_cliente = " & Cli.CodigoFilialCliente & " and num_pedido is null and id_filial_pedido is null"
        If Conexao.VerificaExistenciaReg(strSQL) = 1 Then
            aut = 1
            intContador = restricoes_bloqueado()
            GoTo Inicio
        End If

        If restricoes_bloqueado() = 4 Then
            intContador = restricoes_bloqueado()
Inicio:
            Dim f As New frmOS
            'f.autorizacao = aut
            f.filial_cliente = Cli.CodigoFilialCliente
            f.cod_cliente = Cli.CodigoCliente
            f.txtCliente.Text = Cli.NomeCliente
            f.intContador = intContador
            If aut = 1 Then
                Dim strSQLAut As String = "update pedido_autorizacao set num_pedido = " & pedido.num_pedido & ", id_filial_pedido = " & conf.Filial
                Conexao.SalvaAtualizaExcluiReg(strSQLAut)
            End If
            f.novo = True
            f.Show(Me)
        Else
            intContador = restricoes_bloqueado()
            If (intContador = 1) Or (intContador = 2) Then

                If intContador = 1 Then 'Se o cliente estiver coma cordo em atraso a um período superior a 7 dias fica bloqueado sem comprar
                    If intDia >= 7 Then
                        MessageBox.Show("Cliente não pode realizar compra devido está bloqueado" & Chr(13) &
                        "por falta de pagamento de acordo a mais de 7 dias.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                End If

                If intDia > 0 Then
                    MessageBox.Show("Cliente bloqueado por atraso na fatura ou pagamento de acordo." & Chr(13) & "Somente venda a vista." & Chr(13) &
                    "Faltam " & intDia & " dias para o cliente ser bloqueado definitivamente.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    MessageBox.Show("Cliente não pode realizar compra devido está bloqueado" & Chr(13) &
                                    "por falta de pagamento há mais de 60 dias em atraso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
                intDia = 0
            ElseIf intContador = 3 Then
                MessageBox.Show("Cliente sem limite de crédito. Somente venda a vista.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            GoTo Inicio
        End If

    End Sub

    Private Sub btnAlteraOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlteraOS.Click
        'Procedimento 2 Editar OS
        If Usu.VerificaPermissaoUsuario(2) = False Then
            MessageBox.Show("Usuário sem permissão para editar OS.", "ERROR: 2", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim f As New frmOS
        Dim fi, o As Integer
        Dim aut As objAutorizacao
        'aut = clientenovo.consulta_autorizacao
        fi = grdOS.CurrentRow.Cells(0).Value
        o = grdOS.CurrentRow.Cells(1).Value
        Dim strSQLPedido As String = "Select num_pedido, id_filial from os where cod_os = " & o & " and id_filial = " & fi
        Dim ttPedido As New DataTable
        Conexao.CarregaTabela(strSQLPedido, ttPedido)
        Dim strSQLStatusPed As String = "Select cod_status_pedido from pedido_balcao where num_pedido = " & ttPedido.Rows(0)("num_pedido") & " and id_filial = " & ttPedido.Rows(0)("id_filial")
        Dim ttStatusPedido As New DataTable
        Conexao.CarregaTabela(strSQLStatusPed, ttStatusPedido)

        If ttStatusPedido.Rows.Count > 0 Then
            If ttStatusPedido.Rows(0)("cod_status_pedido") <> 1 Then
                MessageBox.Show("Esta OS não pode ser mais alterada.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If
        f.novo = False
        f.autorizacao = aut
        f.n_OS = o
        f.Filial = fi
        f.Show()
    End Sub


    Private Sub btnCredito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCredito.Click
        If Usu.VerificaPermissaoUsuario(40) = True Then
            Dim credito As New objCreditoCliente
            Dim us As New objUsuario
            credito.novo()
            credito.cod_filial_cliente = Cli.CodigoFilialCliente
            credito.cod_cliente = Cli.CodigoCliente
            credito.data = Now
            credito.id_filial = conf.Filial
            credito.id_usuario = intUsuario
            credito.credito = InputBox("Valor Crédito")
            credito.historico = InputBox("Histórico")
            MsgBox(credito.Salvar)
        Else
            MessageBox.Show("Usuário sem permissão para lançar crédito livre.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        carrega_creditos()
    End Sub

    Private Sub btnAdicionar_Click(sender As System.Object, e As System.EventArgs) Handles btnAdicionar.Click
        If MessageBox.Show("Deseja associar o promotor selecionado ao cliente?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            promotor.CodigoPromotor = cbPromotor.SelectedValue
            promotor.CodigoFilialCliente = Cli.CodigoFilialCliente
            promotor.CodigoCliente = Cli.CodigoCliente
            promotor.SalvaPromotorCliente()
            MessageBox.Show("Promotor inserido com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            promotor.CarregaRegistro(lblCodFilialCliente.Text, txtCodCliente.Text)
        End If
    End Sub

    Private Sub btnExcluir_Click(sender As System.Object, e As System.EventArgs) Handles btnExcluir.Click
        If MessageBox.Show("Deseja excluir o promotor selecionado do cliente?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            promotor.ExcluirPromotor(lblCodPromotor)
            MessageBox.Show("Promotor excluído com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'promotor.exibi_promotor_cb(lblCodFilialCliente.Text, txtCodCliente.Text, ListBox1)
        End If
    End Sub

    Private Sub tbPacoteDesconto_Enter(sender As System.Object, e As System.EventArgs) Handles tbPacoteDesconto.Enter
        cbPacote.DataSource = Nothing
        intControle = 1
        Dim strSQL As String = ""
        Dim codcliente As Integer = CInt(txtCodCliente.Text)
        Dim codfilialcliente As Integer = CInt(lblCodFilialCliente.Text)
        strSQL = "select * from pacote_cliente where cod_cliente = " & codcliente & " and cod_filial_cliente = " & codfilialcliente & " order by cod_pacote desc"

        Conexao.CarregaTabela(strSQL, tb_pacote)
        If tb_pacote.Rows.Count > 0 Then
            cbPacote.DisplayMember = "cod_pacote"
            cbPacote.ValueMember = "cod_pacote"
            cbPacote.DataSource = tb_pacote
            cbPacote.SelectedIndex = -1
        End If
    End Sub

    Private Sub tabPedidos_Enter(sender As System.Object, e As System.EventArgs) Handles tabPedidos.Enter
        filtra_pedidos()
    End Sub

    Private Sub tbOS_Enter(sender As System.Object, e As System.EventArgs) Handles tbOS.Enter
        formata_grid_OS(1)
    End Sub

    Private Sub tabFatura_Enter(sender As System.Object, e As System.EventArgs) Handles tabFatura.Enter
        formata_grid_faturas()
    End Sub

    Private Sub tbCreditos_Enter(sender As System.Object, e As System.EventArgs) Handles tbCreditos.Enter
        carrega_creditos()
    End Sub

    Private Sub tbTitulos_Enter(sender As System.Object, e As System.EventArgs) Handles tbTitulos.Enter
        carrega_titulos()
    End Sub

    Private Sub tbCheques_Enter(sender As System.Object, e As System.EventArgs) Handles tbCheques.Enter
        carrega_cheques()
    End Sub

    Private Sub btnPrimeiro_Click(sender As System.Object, e As System.EventArgs) Handles btnPrimeiro.Click
        Cli.Primeiro()
        CarregaDados()

        If Cli.intPonteiro = 0 Then
            btnAnterior.Enabled = False
            btnPrimeiro.Enabled = False
            btnProximo.Enabled = True
            btnUltimo.Enabled = True
        End If
    End Sub


    Private Sub btnAnterior_Click(sender As System.Object, e As System.EventArgs) Handles btnAnterior.Click
        Cli.Anterior()
        CarregaDados()

        If Cli.intPonteiro > 0 Then
            btnAnterior.Enabled = True
            btnPrimeiro.Enabled = True
            btnProximo.Enabled = True
            btnUltimo.Enabled = True
        End If
        If Cli.intPonteiro = 0 Then
            btnAnterior.Enabled = False
            btnPrimeiro.Enabled = False
            btnProximo.Enabled = True
            btnUltimo.Enabled = True
        End If
    End Sub

    Private Sub btnProximo_Click(sender As System.Object, e As System.EventArgs) Handles btnProximo.Click
        Cli.Proximo()
        CarregaDados()

        If Cli.intPonteiro + 1 < Cli.intMax Then
            btnAnterior.Enabled = True
            btnPrimeiro.Enabled = True
            btnProximo.Enabled = True
            btnUltimo.Enabled = True
        Else
            btnAnterior.Enabled = True
            btnPrimeiro.Enabled = True
            btnProximo.Enabled = False
            btnUltimo.Enabled = False
        End If

    End Sub

    Private Sub btnUltimo_Click(sender As System.Object, e As System.EventArgs) Handles btnUltimo.Click
        Cli.Ultimo()
        CarregaDados()

        If Cli.intPonteiro + 1 = Cli.intMax Then
            btnPrimeiro.Enabled = True
            btnAnterior.Enabled = True
            btnProximo.Enabled = False
            btnUltimo.Enabled = False
        End If
    End Sub

    Private Sub btnNovo_Click(sender As System.Object, e As System.EventArgs) Handles btnNovo.Click
        Geral.TipoReg = Belemtech.TiposReg.Novo
        lblCodFilialCliente.Text = conf.Filial
        Cli.Novo()
        ListBox1.DataSource = Nothing
        CarregaForma()

        CarregaCombos()

        Util.AtivaControles(Me)
        txtCnpjCpf.Text = String.Empty
        txtCep.Text = String.Empty
        txtFoneNota.Text = String.Empty
        txtLimiteCompra.Text = 0
        txtlimiteCredito.Text = 0
        txtDiasPagar.Text = 0

        lblStatus.Text = "Modo de Adição. Clique em Salvar ou Cancelar"

        btnAdicionar.Enabled = True
        btnNovo.Enabled = False
        btnEditar.Enabled = False
        btnSalvar.Enabled = True
        btnCancelar.Enabled = True
        grdForma.Enabled = True
        txtCodCliente.ReadOnly = True
        cbAtivo.Checked = True
        cbTipoPessoa.Focus()
    End Sub

    Private Sub btnEditar_Click(sender As System.Object, e As System.EventArgs) Handles btnEditar.Click
        Geral.TipoReg = Belemtech.TiposReg.Alterar
        'DestravaControles(Me.tabPrinc.Controls)
        'Procedimento 35 Limites de Crédito
        'If usuario.acesso(UserID, 35) = True Then
        'DestravaControles(Me.grpLimite.Controls)
        'End If

        Util.AtivaControles(Me)
        ListBox1.Enabled = True
        btnAdicionar.Enabled = True
        btnNovo.Enabled = False
        btnEditar.Enabled = False
        btnExclui.Enabled = True
        btnSalvar.Enabled = True
        btnCancelar.Enabled = True
        grdForma.Enabled = True
        txtCodCliente.ReadOnly = True
        txtNome.Focus()
    End Sub

    Private Sub btnSalvar_Click(sender As System.Object, e As System.EventArgs) Handles btnSalvar.Click
        Dim cep As String = String.Empty
        Dim telefoneNota As String = String.Empty

        Cli.CodigoFilialCliente = conf.Filial

        Cli.NomeCliente = txtNome.Text
        Cli.RazaoSocial = txtRazaoSocial.Text
        Cli.CpfCnpj = Geral.RetornaSoNumero(txtCnpjCpf.Text)

        If cbTipoPessoa.SelectedIndex = 0 Then
            Cli.TipoPessoa = "F"
            Cli.Rg = txtIE.Text
            Cli.TipoDocumento = "CPF"
        Else
            Cli.TipoPessoa = "J"
            Cli.Ie = txtIE.Text
            Cli.TipoDocumento = "CNPJ"
        End If

        Cli.Logradouro = txtEndreço.Text
        Cli.Complemento = txtComplemento.Text
        Cli.Bairro = txtBairro.Text
        Cli.NomeCidade = cbCidade.Text
        Cli.Uf = txtUF.Text
        Cli.Cep = Geral.RetornaSoNumero(txtCep.Text)
        Cli.Telefone = txtFone.Text
        Cli.Observacao = txtObs.Text
        Cli.LimiteCompra = Convert.ToDecimal(txtLimiteCompra.Text)
        Cli.LimiteCredito = Convert.ToDecimal(txtlimiteCredito.Text)
        Cli.LimiteCheque = 0
        Cli.QtdeDiaPagar = txtDiasPagar.Text
        Cli.SemDesconto = chkSemDesconto.Checked
        Cli.CidadeIBGE = cbCidade.SelectedValue
        Cli.Numero = txtNumero.Text
        If txtFoneNota.Text <> String.Empty Then
            Cli.TelefoneNota = Geral.RetornaSoNumero(txtFoneNota.Text)
        Else
            Cli.TelefoneNota = "00000000000"
        End If

        Cli.Email = txtEmail.Text
        Cli.CodigoTipoCliente = cbTipoCliente.SelectedValue
        Cli.TipoIE = 9
        Cli.EstoquePreferencial = 0
        Cli.Situacao = cbAtivo.Checked

        If Cli.VerificaCampoObrigatorio() = True Then
            Exit Sub
        End If

        If Geral.TipoReg = Belemtech.TiposReg.Novo Then
            Cli.CodigoCliente = Conexao.RetornaChave("cod_cliente", "cliente", "where cod_filial_cliente = " & conf.Filial)
            Cli.SalvaCliente()
        ElseIf Geral.TipoReg = Belemtech.TiposReg.Alterar Then
            Cli.AtualizaCliente()
        End If


fim:


        For Each linha As DataGridViewRow In grdForma.Rows
            Dim strSQLExcluir As String = "delete from FORMA_COMPRA WHERE COD_CLIENTE = " & Cli.CodigoCliente & " AND COD_FILIAL_CLIENTE = " &
                                        Cli.CodigoFilialCliente & " AND CODIGO_TIPO_COMPRA = " & linha.Cells(1).Value

            Conexao.SalvaAtualizaExcluiReg(strSQLExcluir)

            If linha.Cells(0).Value = True Then
                Dim strSQLInsert As String = "INSERT INTO FORMA_COMPRA (CODIGO_TIPO_COMPRA, COD_CLIENTE, COD_FILIAL_CLIENTE) VALUES(" &
                        linha.Cells(1).Value & "," & Cli.CodigoCliente & "," & Cli.CodigoFilialCliente & ")"
                Conexao.SalvaAtualizaExcluiReg(strSQLInsert)
            End If
        Next

        Cli.RetornaRegistroCodigo(Cli.CodigoCliente)
        'clientenovo.filtra_cod(clientenovo.cod_cliente)
        CarregaDados()
        Status()
        Me.Cursor = Cursors.Default
        ListBox1.Enabled = False
        btnNovo.Enabled = True
        btnEditar.Enabled = True
        btnExclui.Enabled = False
        btnSalvar.Enabled = False
        btnCancelar.Enabled = False
        btnAdicionar.Enabled = False
        btnExcluir.Enabled = False
        grdForma.Enabled = False
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        If Cli.CodigoCliente <> 0 Then
            CarregaDados()
        End If

        lblStatus.Text = ""
        gbControlePrincipal.Enabled = True
        ListBox1.Enabled = False
        btnNovo.Enabled = True
        btnEditar.Enabled = True
        btnExclui.Enabled = False
        btnSalvar.Enabled = False
        btnCancelar.Enabled = False
        btnAdicionar.Enabled = False
        btnExcluir.Enabled = False
        grdForma.Enabled = False
        Util.DesativaControles(Me)

        'travaControles(Me.tabPrinc.Controls)
    End Sub

    Private Sub btnExclui_Click(sender As System.Object, e As System.EventArgs) Handles btnExclui.Click
        btnNovo.Enabled = True
        btnEditar.Enabled = True
        btnExclui.Enabled = False
        btnSalvar.Enabled = False
        btnExclui.Enabled = False
        btnCancelar.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        filtra_pedidos()
    End Sub


    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        formata_grid_OS(2)
    End Sub


    Private Sub grdPacote_DoubleClick(sender As System.Object, e As System.EventArgs) Handles grdPacote.DoubleClick
        Dim intCodTabela As Integer
        Dim intCodPacote As Integer
        Dim fr As New frmRpt
        Dim r As New rptPacoteDetMov
        intCodTabela = grdPacote.CurrentRow.Cells(1).Value
        intCodPacote = cbPacote.SelectedValue
        r.DataSource = Cli.DetalheMovimentoItem(intCodPacote, intCodTabela)
        r.lblTitulo.Text = "Movimentação do Pacote: " & cbPacote.SelectedValue &
        " Cliente: " & Cli.NomeCliente
        fr.Relat(r)
        fr.ShowDialog(Me)
        fr.Dispose()
    End Sub

    Private Sub btnExcluirPacote_Click(sender As System.Object, e As System.EventArgs) Handles btnExcluirPacote.Click
        Dim strSQLCredito As String = ""
        Dim tt As New DataTable
        strSQLCredito = "select * from credito_pacote where cod_cliente = " & Cli.CodigoCliente &
        " and cod_filial_cliente = " & Cli.CodigoFilialCliente & " and cod_pacote = " & cbPacote.SelectedValue
        Conexao.CarregaTabela(strSQLCredito, tt)
        'Caso exista o crédito de pacote a instrução seguinte é executada e finalizado
        If tt.Rows.Count > 0 Then
            MessageBox.Show("Pacote não pode ser excluído. Cancele o recebimento " & Chr(13) &
                            "do pacote para prosseguir com a exclusão.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Se não existir lançamento de crédito de pacote a instrução seguinte é executada
        If MessageBox.Show("Deseja excluir este pacote?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim i, j, total As Integer
            For Each linha As DataGridViewRow In grdPacote.Rows
                If linha.Cells(6).Value = linha.Cells(7).Value Then
                    i = i + 1
                End If
            Next

            For j = 0 To grdPacote.Rows.Count - 1
                total = j + 1
            Next

            'Caso o pacote não tenha sido movimento as instruções seguintes são executadas com o proposito de excluir o item de pacote
            'e o pacote em questão
            If i = total Then
                Cli.ExcluirItemPacote(CInt(cbPacote.SelectedValue), CInt(txtCodCliente.Text))
                Cli.ExcluirItemPacote(cbPacote.SelectedValue, CInt(txtCodCliente.Text))
                MessageBox.Show("Pacote excluído com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                carrega_pacotes() 'Dá um refresh na tela de pacote
            Else
                MessageBox.Show("Pacote não pode ser excluído, pois, já houve movimentação" & Chr(13) &
                "de itens do pacote referido.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub


    Private Sub btnImprimir_Click(sender As System.Object, e As System.EventArgs) Handles btnImprimir.Click
        Dim codigocredito As Integer = Cli.RetornaCodigoCredito(CInt(cbPacote.SelectedValue), CInt(txtCodCliente.Text))
        If grdPacote.Rows.Count > 0 Then
            Dim f As New frmRpt
            Dim r As New rptReciboPacote

            Dim valorapacote As Double
            Dim valorpago As Double
            Dim total As Double
            Cli.RetornaRegistroCodigo(Cli.CodigoCliente)
            r.codigo = "Código: " & Cli.CodigoCliente
            r.cliente = "Nome Fantasia: " & Cli.NomeCliente
            r.razao = "Razão Social: " & Cli.RazaoSocial
            r.fatura = "Pacote Nº " & adiciona_zeros(cbPacote.SelectedValue, 6)
            r.endereco = "Endereço: " & Cli.Logradouro & " - " & "Bairro: " & Cli.Bairro & " - " & "CEP: " & Cli.Cep
            r.municipio = "Cidade: " & Cli.NomeCidade & "/" & Cli.Uf
            r.fone = "Fones: " & Cli.Telefone
            r.tRec = lanc.Listar_Rec_credito(codigocredito, conf.Filial)
            r.DataSource = Cli.FiltraPacoteDetalhe(Cli.CodigoCliente, Cli.CodigoFilialCliente, cbPacote.SelectedValue)
            '
            valorapacote = Cli.TotalPacote(Cli.CodigoCliente, Cli.CodigoFilialCliente, CInt(cbPacote.SelectedValue))
            valorpago = Cli.TotalPacotePago(Cli.CodigoCliente, Cli.CodigoFilialCliente, CInt(cbPacote.SelectedValue))
            total = valorapacote - valorpago
            r.aPAGAR = Format(CDbl(total), "#,##0.00")
            '
            r.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape
            f.Relat(r)
            f.ShowDialog(Me)
            f.Dispose()
        Else
            MessageBox.Show("Não é possível imprimir comprovante do pacote, pois, o mesmo" & Chr(13) &
                "não possui item(ens) cadastrado(s).", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ativaControle()
        lblCodigoProduto.Enabled = True
        txtProduto.Enabled = True
        txtQuant.Enabled = True
        txtDesconto.Enabled = True
        cbSurfacagem.Enabled = True
        txtQtdeSurf.Enabled = True
        txtDescSurf.Enabled = True
        cbMontagem.Enabled = True
        txtQuantMont.Enabled = True
        txtDescMont.Enabled = True
        cbTratamento.Enabled = True
        txtQuantTrat.Enabled = True
        txtDescTrat.Enabled = True
    End Sub

    Private Sub desativaControle()
        lblCodigoProduto.Enabled = False
        txtProduto.Enabled = False
        txtQuant.Enabled = False
        txtDesconto.Enabled = False
        cbSurfacagem.Enabled = False
        txtQtdeSurf.Enabled = False
        txtDescSurf.Enabled = False
        cbMontagem.Enabled = False
        txtQuantMont.Enabled = False
        txtDescMont.Enabled = False
        cbTratamento.Enabled = False
        txtQuantTrat.Enabled = False
        txtDescTrat.Enabled = False

        txtDescMont.Text = CDbl(0.0)
        txtDescSurf.Text = CDbl(0.0)
        txtDescTrat.Text = CDbl(0.0)
        lblCodigoProduto.Text = ""
        txtProduto.Text = ""
        txtQuant.Text = ""
        txtDesconto.Text = ""
        lblPreco.Text = CDbl(0.0)
        lblPrecoProdPacDesc.Text = CDbl(0.0)
        lblPrecoSuf.Text = CDbl(0.0)
        txtQtdeSurf.Text = 0
        txtDescSurf.Text = CDbl(0.0)
        lblPrecoDescSurf.Text = CDbl(0.0)
        lblPrecoMont.Text = CDbl(0.0)
        txtQuantMont.Text = 0
        txtDescMont.Text = CDbl(0.0)
        lblPrecoDescMont.Text = CDbl(0.0)
        lblPrecoTrat.Text = CDbl(0.0)
        txtQuantTrat.Text = 0
        txtDescTrat.Text = CDbl(0.0)
        lblPrecoDescTrat.Text = CDbl(0.0)

        lblCodigoProduto.Focus()
    End Sub

    Private Sub lblCodigoProduto_Leave(sender As System.Object, e As System.EventArgs) Handles lblCodigoProduto.Leave
        tabela.filtra(lblCodigoProduto.Text)
        txtProduto.Text = tabela.nome_comercial
        lblPreco.Text = Format(CDbl(tabela.preco_venda), "#,##0.00")
    End Sub

    Private Sub cbSurfacagem_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbSurfacagem.SelectedIndexChanged
        If cbSurfacagem.SelectedIndex <> 0 Then
            lblPrecoSuf.Text = Format(Cli.RetornaPrecoServico(CInt(cbSurfacagem.SelectedValue)), "#,##0.00")
        End If
    End Sub

    Private Sub txtDescSurf_Leave(sender As System.Object, e As System.EventArgs) Handles txtDescSurf.Leave
        Dim precodesconto As Double = CDbl(lblPrecoSuf.Text) * txtDescSurf.Text / 100
        lblPrecoDescSurf.Text = Format(CDbl(lblPrecoSuf.Text) - precodesconto, "#,##0.00")
    End Sub

    Private Sub cbMontagem_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbMontagem.SelectedIndexChanged
        If cbMontagem.SelectedIndex <> 0 Then
            lblPrecoMont.Text = Cli.RetornaPrecoServico(cbMontagem.SelectedValue)
        End If
    End Sub

    Private Sub txtDescMont_Leave(sender As System.Object, e As System.EventArgs) Handles txtDescMont.Leave
        Dim precodesconto As Double = CDbl(lblPrecoMont.Text) * txtDescMont.Text / 100
        lblPrecoDescMont.Text = Format(CDbl(lblPrecoMont.Text) - precodesconto, "#,##0.00")
    End Sub

    Private Sub cbTratamento_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbTratamento.SelectedIndexChanged
        If cbTratamento.SelectedIndex <> 0 Then
            lblPrecoTrat.Text = Format(Cli.RetornaPrecoServico(CInt(cbTratamento.SelectedValue)), "#,##0.00")
        End If
    End Sub

    Private Sub txtDescTrat_Leave(sender As System.Object, e As System.EventArgs) Handles txtDescTrat.Leave
        If cbTratamento.SelectedIndex <> 0 Then
            lblPrecoDescTrat.Text = Format(Cli.RetornaPrecoServico(CInt(cbTratamento.SelectedValue)), "#,##0.00")
        End If
        'Dim precodesconto As Double = CDbl(lblPrecoTrat.Text) * txtDescTrat.Text / 100
        'lblPrecoDescTrat.Text = Format(CDbl(lblPrecoTrat.Text) - precodesconto, "#,##0.00")
    End Sub

    Private Sub grdFaturas_DoubleClick(sender As System.Object, e As System.EventArgs) Handles grdFaturas.DoubleClick
        Dim f As New frmFatura
        Dim fat As Integer
        Dim fil As Integer
        fat = grdFaturas.CurrentRow.Cells(0).Value
        fil = grdFaturas.CurrentRow.Cells(7).Value
        f.abre_fatura(fat, fil)
        f.ShowDialog(Me)
        'Se a fatura não tiver 
        If f.fatura.lista_itens_fatura.Rows.Count = 0 Then
            MsgBox(f.fatura.deletar(f.fatura.cod_fatura, f.fatura.id_filial))
        End If
        f.Dispose()
        'formata_grid_faturas()
    End Sub

    Private Sub grdFaturas_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles grdFaturas.CellFormatting
        If Format(CDbl(grdFaturas.Rows(e.RowIndex).Cells(6).Value), "#,##0.00") < 0.0 Then
            'grdFaturas.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Red
            'grdFaturas.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Yellow
            grdFaturas.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        formata_grid_faturas()
    End Sub

    Private Sub carregaAcordo()
        grdAcordo.Columns.Clear()
        grdAcordo.DataSource = Nothing
        grdAcordo.AutoGenerateColumns = False
        grdAcordo.AllowUserToAddRows = False

        Dim selecao As New DataGridViewCheckBoxColumn 'Posição 00
        selecao.HeaderText = "Selecionar"
        selecao.Width = 70
        grdAcordo.Columns.Add(selecao)

        Dim codfatura As New DataGridViewTextBoxColumn 'Posição 01
        codfatura.DataPropertyName = "cod_fatura_real"
        codfatura.HeaderText = "Nº Fatura"
        codfatura.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        codfatura.Width = 80
        grdAcordo.Columns.Add(codfatura)

        Dim codacordo As New DataGridViewTextBoxColumn 'Posição 02
        codacordo.DataPropertyName = "cod_acordo"
        codacordo.HeaderText = "Nº Acordo"
        codacordo.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        codacordo.Width = 80
        grdAcordo.Columns.Add(codacordo)

        Dim codpacote As New DataGridViewTextBoxColumn 'Posição 03
        codpacote.DataPropertyName = "cod_pacote"
        codpacote.HeaderText = "Nº Pacote"
        codpacote.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        codpacote.Width = 80
        grdAcordo.Columns.Add(codpacote)

        Dim emissao As New DataGridViewTextBoxColumn 'Posição 04
        emissao.DataPropertyName = "data_lancamento"
        emissao.HeaderText = "Emissão"
        emissao.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        emissao.DefaultCellStyle.Format = "dd/MM/yyyy"
        emissao.Width = 85
        grdAcordo.Columns.Add(emissao)

        Dim vencimento As New DataGridViewTextBoxColumn 'Posição 05
        vencimento.DataPropertyName = "data_vencimento"
        vencimento.HeaderText = "Vencimento"
        vencimento.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        vencimento.DefaultCellStyle.Format = "dd/MM/yyyy"
        codacordo.Width = 85
        grdAcordo.Columns.Add(vencimento)

        Dim valor As New DataGridViewTextBoxColumn 'Posição 06
        valor.DataPropertyName = "valor"
        valor.HeaderText = "Valor"
        valor.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        valor.DefaultCellStyle.Format = "#,##0.00"
        valor.Width = 75
        grdAcordo.Columns.Add(valor)

        Dim doc As New DataGridViewTextBoxColumn 'Posição 07
        doc.DataPropertyName = "doc"
        doc.HeaderText = "Documento"
        doc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        doc.Width = 145
        grdAcordo.Columns.Add(doc)

        Dim lanc As New DataGridViewTextBoxColumn 'Posição 08
        lanc.DataPropertyName = "cod_lancamento"
        lanc.HeaderText = "Lançamento"
        lanc.Width = 80
        lanc.Visible = False
        grdAcordo.Columns.Add(lanc)

        Dim idfilial As New DataGridViewTextBoxColumn 'Posição 09
        idfilial.DataPropertyName = "id_filial"
        idfilial.HeaderText = "Filial"
        idfilial.Width = 80
        idfilial.Visible = False
        grdAcordo.Columns.Add(idfilial)

        Dim multa As New DataGridViewTextBoxColumn 'Posição 10
        multa.DataPropertyName = "multa_total"
        multa.HeaderText = "Multa"
        multa.Width = 80
        multa.Visible = False
        grdAcordo.Columns.Add(multa)

        Dim juros As New DataGridViewTextBoxColumn 'Posição 11
        juros.DataPropertyName = "juros_total"
        juros.HeaderText = "Juros"
        juros.Width = 80
        juros.Visible = False
        grdAcordo.Columns.Add(juros)

        Dim recebimento As New DataGridViewTextBoxColumn 'Posição 12
        recebimento.DataPropertyName = "data_recebimento"
        recebimento.HeaderText = "Recebiemnto"
        recebimento.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        recebimento.DefaultCellStyle.Format = "dd/MM/yyyy"
        recebimento.Width = 85
        recebimento.Visible = False
        grdAcordo.Columns.Add(recebimento)

        grdAcordo.DataSource = Cli.TituloClienteAcordo(CInt(txtCodCliente.Text), CInt(lblCodFilialCliente.Text))
    End Sub

    Private Sub tbAcordo_Enter(sender As System.Object, e As System.EventArgs) Handles tbAcordo.Enter
        carregaAcordo()
        carregaDetAcordo()
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        If conf.Filial = 1 Then
            Dim f As New frmNegociacao
            Dim tbAcordoDet As New DataTable
            Dim dr As DataRow

            tbAcordoDet.Clear()
            tbAcordoDet.Columns.Add("CodLanc", GetType(Int64))
            tbAcordoDet.Columns.Add("IdFilial", GetType(Integer))
            tbAcordoDet.Columns.Add("Documento", GetType(Integer))
            tbAcordoDet.Columns.Add("TipoDoc", GetType(String))

            Dim listafatura, listapacote, listaacordo As String
            If Usu.VerificaPermissaoUsuario(53) = True Then
                For Each linha As DataGridViewRow In grdAcordo.Rows
                    If linha.Cells(0).Value = True Then
                        dr = tbAcordoDet.NewRow()
                        Dim i, j As Integer
                        Dim valortotal As Double
                        Dim multa_total, juros_total As Double
                        Dim totaldebito As Double
                        f.lblCliente.Text = Cli.CodigoCliente & " - " & Cli.NomeCliente
                        f.txtFilial.Text = Cli.CodigoFilialCliente

                        valortotal = valortotal + linha.Cells(6).Value

                        If linha.Cells(1).Value IsNot DBNull.Value Then
                            If CInt(linha.Cells(1).Value > 0) Then
                                listafatura = listafatura & linha.Cells(1).Value & ","
                                dr.Item("Documento") = linha.Cells(1).Value
                                dr.Item("TipoDoc") = "FAT"
                            End If
                        End If
                        listafatura = listafatura

                        If linha.Cells(2).Value IsNot DBNull.Value Then
                            listaacordo = listaacordo & linha.Cells(2).Value & ","
                            dr.Item("Documento") = linha.Cells(2).Value
                            dr.Item("TipoDoc") = "NEG"
                        End If
                        listaacordo = listaacordo

                        If linha.Cells(3).Value IsNot DBNull.Value Then
                            listapacote = listapacote & linha.Cells(3).Value & ","
                            dr.Item("Documento") = linha.Cells(3).Value
                            dr.Item("TipoDoc") = "PAC"
                        End If
                        listapacote = listapacote

                        dr.Item("CodLanc") = linha.Cells(8).Value
                        dr.Item("IdFilial") = linha.Cells(9).Value
                        tbAcordoDet.Rows.Add(dr)
                        f.tb_Det = tbAcordoDet

                        multa_total = Format(CDbl(multa_total) + CDbl(linha.Cells(10).Value), "#,##0.00")
                        If CDbl(linha.Cells(11).Value) < 0 Then
                            juros_total = Format(CDbl(juros_total) + CDbl(0.0), "#,##0.00")
                        Else
                            juros_total = Format(CDbl(juros_total) + CDbl(linha.Cells(11).Value), "#,##0.00")
                        End If

                        totaldebito = Format(CDbl(totaldebito) + CDbl(linha.Cells(6).Value), "#,##0.00")

                        f.txtValorAcordo.Text = Format(CDbl(valortotal), "#,##0.00")
                        f.xCod_cliente = Cli.CodigoCliente
                        f.xCodFilialCliente = Cli.CodigoFilialCliente
                        f.txtAcrescimo.Text = Format(multa_total, "#,##0.00")
                        f.txtJuros.Text = Format(juros_total, "#,##0.00")
                        f.lblTotal.Text = Format(CDbl(totaldebito) + CDbl(multa_total) + CDbl(juros_total), "#,##0.00")
                        f.lblaPagar.Text = Format(CDbl(totaldebito) + CDbl(multa_total) + CDbl(juros_total), "#,##0.00")
                    End If
                Next
                If listafatura <> "" Then
                    listafatura = "Fatura: " & listafatura
                End If
                If listaacordo <> "" Then
                    listaacordo = "Acordo: " & listaacordo
                End If
                If listapacote <> "" Then
                    listapacote = "Pacote: " & listapacote
                End If
                f.txtHistórico.Text = "Negociação referente a débitos dos documentos: " & listafatura & listaacordo & listapacote
                f.intTipo = 0
                f.ShowDialog()

                carregaAcordo()
                carregaDetAcordo()
            Else
                MessageBox.Show("Usuário sem permissão para acessar este módulo.", "ERROR: 53", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        Dim f As New frmNegociacao
        f.intTipo = 1
        f.intAcordo = InputBox("Digite o nº do acordo.", "Acordo")
        f.xCodFilialCliente = Cli.CodigoFilialCliente
        f.xCod_cliente = Cli.CodigoCliente
        f.ShowDialog()
        carregaAcordo()
        carregaDetAcordo()
    End Sub

    Private Sub AtualizarPagamentoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AtualizarPagamentoToolStripMenuItem.Click
        For Each linha As DataGridViewRow In grdAcordo.Rows
            If linha.Selected = True Then
                'promotor.atualiza_status_lancamentos_temp(CInt(linha.Cells(7).Value), CInt(linha.Cells(8).Value), 3, CInt(linha.Cells(1).Value))
            End If
        Next
        carregaAcordo()
    End Sub

    Private Sub carregaDetAcordo()
        grdDetAcordo.Columns.Clear()
        grdDetAcordo.DataSource = Nothing
        grdDetAcordo.AutoGenerateColumns = False
        grdDetAcordo.AllowUserToAddRows = False

        Dim codacordo As New DataGridViewTextBoxColumn
        codacordo.DataPropertyName = "cod_acordo"
        codacordo.HeaderText = "Nº Acordo"
        codacordo.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        codacordo.Width = 80
        codacordo.DefaultCellStyle.Format = "00000"
        grdDetAcordo.Columns.Add(codacordo)

        Dim status As New DataGridViewTextBoxColumn
        status.DataPropertyName = "status_acordo"
        status.HeaderText = "Status"
        status.Width = 60
        grdDetAcordo.Columns.Add(status)

        grdDetAcordo.DataSource = Cli.RetornaAcordo(CInt(txtCodCliente.Text), CInt(lblCodFilialCliente.Text))
    End Sub

    Private Sub grdDetAcordo_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles grdDetAcordo.CellFormatting
        If grdDetAcordo.Rows(e.RowIndex).Cells(1).Value = "Aberto" Then
            grdDetAcordo.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Red
            grdDetAcordo.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.White
        End If

        If grdDetAcordo.Rows(e.RowIndex).Cells(1).Value = "Cancelado" Then
            grdDetAcordo.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Yellow
        End If

        If grdDetAcordo.Rows(e.RowIndex).Cells(1).Value = "Fechado" Then
            grdDetAcordo.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Blue
            grdDetAcordo.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.White
        End If
    End Sub

    Private Sub ativaDesativaControle()
        Dim strSQL As String = "select * from pacote_cliente where cod_pacote = " & cbPacote.SelectedValue & " and cod_cliente = " & txtCodCliente.Text &
        " and concluido = 'S'"
        If Conexao.VerificaExistenciaReg(strSQL) = 1 Then
            btnNovoItemPacote.Enabled = False
            btnSalvarPacote.Enabled = False
            btnDeletarItemPacote.Enabled = False
            btnImprimir.Enabled = True
            desativaControle()
        Else
            btnNovoItemPacote.Enabled = True
            btnSalvarPacote.Enabled = True
            btnDeletarItemPacote.Enabled = True
            btnImprimir.Enabled = False
            ativaControle()
        End If
    End Sub


    Private Sub TransferirItensDePacoteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TransferirItensDePacoteToolStripMenuItem.Click
        If Usu.VerificaPermissaoUsuario(54) = True Then
            If MessageBox.Show("Deseja transferir o(s) item(ens) selecionado para um novo pacote?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim intPacote As Integer
                Dim intCodTabela As String
                intPacote = cbPacote.SelectedValue
                pacote.novo()
                pacote.cod_filial_cliente = Cli.CodigoFilialCliente
                pacote.cod_cliente = Cli.CodigoCliente
                pacote.Salvar()
                Dim strSQLExcluiPacote As String = ""

                For Each linha As DataGridViewRow In grdPacote.Rows
                    Dim strSQLPacoteDet As String = "select * from Pacote_cliente_detalhes where cod_pacote = " & intPacote &
                        " and item = " & linha.Cells(22).Value
                    Dim strSQL As String = ""
                    Dim ds As New DataSet
                    Conexao.CarregaDataSet(strSQLPacoteDet, ds)
                    Dim tb As New DataTable
                    tb = ds.Tables(0)

                    If (linha.Cells(0).Value = True) And (linha.Cells(20).Value = "L") Then
                        If linha.Cells(7).Value > 0 Then
                            intCodTabela = InputBox("Informar o novo código à substituir o código: " & linha.Cells(1).Value)
                            If intCodTabela = "" Then
                                strSQLExcluiPacote = "delete from pacote_cliente where cod_pacote = " & pacote.cod_pacote & " and cod_cliente = " & pacote.cod_cliente
                                MessageBox.Show("Informe o novo código do produto.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Conexao.SalvaAtualizaExcluiReg(strSQLExcluiPacote)
                                Exit Sub
                            End If
                            strSQL = "Insert into pacote_cliente_detalhes (cod_pacote,item,cod_tabela,cod_filial_cliente,cod_cliente,desconto" &
                            ",quantidade_contratada,cod_surf,desc_surf,cod_mont,desc_mont,cod_trat,desc_trat,preco_tabela,preco_desc, " &
                            "preco_tabela_surf,preco_surf_desc,quantidade_surf,preco_tabela_mont,preco_mont_desc,quantidade_mont,preco_tabela_trat," &
                            "preco_trat_desc,quantidade_trat,status_item,cod_pacote_ant,cod_usuario) " &
                            "Values(" &
                            pacote.cod_pacote & "," & tb.Rows(0)("item") & "," & CInt(intCodTabela) & "," & tb.Rows(0)("cod_filial_cliente") & "," &
                            tb.Rows(0)("cod_cliente") & "," & Geral.ValorMoeda(tb.Rows(0)("desconto")) & "," & Geral.ValorMoeda(linha.Cells(7).Value) &
                            "," & Geral.ValorMoeda(tb.Rows(0)("cod_surf")) & "," & Geral.ValorMoeda(tb.Rows(0)("desc_surf")) & "," &
                            Geral.ValorMoeda(tb.Rows(0)("cod_mont")) & "," & Geral.ValorMoeda(tb.Rows(0)("desc_mont")) & "," & Geral.ValorMoeda(tb.Rows(0)("cod_trat")) & "," &
                            Geral.ValorMoeda(tb.Rows(0)("desc_trat")) & "," & Geral.ValorMoeda(tb.Rows(0)("preco_tabela")) & "," & Geral.ValorMoeda(tb.Rows(0)("preco_desc")) & "," &
                            Geral.ValorMoeda(tb.Rows(0)("preco_tabela_surf")) & "," & Geral.ValorMoeda(tb.Rows(0)("preco_surf_desc")) &
                            "," & Geral.ValorMoeda(tb.Rows(0)("quantidade_surf")) & "," & Geral.NumeroSQL(tb.Rows(0)("cod_pacote")) & "," & Geral.ValorMoeda(tb.Rows(0)("preco_mont_desc")) &
                            "," & Geral.ValorMoeda(tb.Rows(0)("quantidade_mont")) & "," & Geral.ValorMoeda(tb.Rows(0)("preco_tabela_trat")) & "," &
                            Geral.ValorMoeda(tb.Rows(0)("preco_trat_desc")) & "," & Geral.ValorMoeda(tb.Rows(0)("quantidade_trat")) &
                            "," & Geral.AspasSQL(tb.Rows(0)("status_item")) & "," & intPacote & "," & intUsuario & ")"
                            Dim cmd As New SqlCommand(strSQL, Conexao.Conn)
                            If Conexao.ConectadoBanco = True Then
                                cmd.ExecuteNonQuery()
                                'd.ComandoSQL(strSQL, True)
                                cmd.Dispose()
                                'd.desconecta()
                            End If

                            'Atualiza o Status do Item do Pacote L = Liberado, B = Bloqueado e S = Suspenso
                            Dim strSQLStatus As String = "update pacote_cliente_detalhes set status_item = 'B', cod_pacote_ant = 0 " &
                                ", cod_usuario = " & intUsuario & "  where cod_pacote = " & intPacote & " and item = " & tb.Rows(0)("item")
                            Conexao.SalvaAtualizaExcluiReg(strSQLStatus)
                        Else
                            strSQLExcluiPacote = "delete from pacote_cliente where cod_pacote = " & pacote.cod_pacote & " and cod_cliente = " & pacote.cod_cliente
                            MessageBox.Show("Informe o novo código do produto.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Conexao.SalvaAtualizaExcluiReg(strSQLExcluiPacote)
                        End If
                    End If
                Next

                Dim strSQLPacote As String = "update pacote_cliente set concluido ='S' where cod_pacote = " & pacote.cod_pacote & " and cod_cliente = " & pacote.cod_cliente
                Conexao.SalvaAtualizaExcluiReg(strSQLPacote)
                carrega_pacotes()
            End If
        Else
            MessageBox.Show("Usuário não tem permissão para transferir item de pacote!", "ERROR: 54", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub grdPacote_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles grdPacote.CellFormatting
        If grdPacote.Rows(e.RowIndex).Cells(0).Value = True Then
            grdPacote.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Red
            grdPacote.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.White
            grdPacote.Rows(e.RowIndex).DefaultCellStyle.Font = New Font(grdPacote.DefaultCellStyle.Font, FontStyle.Bold)
        End If

        If grdPacote.Rows(e.RowIndex).Cells(0).Value = False Then
            grdPacote.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
            grdPacote.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
            grdPacote.Rows(e.RowIndex).DefaultCellStyle.Font = New Font(grdPacote.DefaultCellStyle.Font, FontStyle.Regular)
        End If
    End Sub

    Private Sub grdPacote_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles grdPacote.KeyDown
        'Caso seja pressionado a tecla F2 a ação seguinte é executada
        If e.KeyCode = Keys.F2 Then
            If ToolStripStatusLabel1.Enabled = True Then
                grdPacote.CurrentRow.Cells(0).Value = True
            End If
        End If

        'Caso seja pressionado a tecla F3 a ação seguinte é executada
        If e.KeyCode = Keys.F3 Then
            If ToolStripStatusLabel2.Enabled = True Then
                grdPacote.CurrentRow.Cells(0).Value = False
            End If
        End If

        'Caso seja pressionado a tecla F4 a ação seguinte é executada
        If e.KeyCode = Keys.F4 Then
            If grdPacote.CurrentRow.Cells(7).Value = 0 Then 'Caso o saldo disponível esteja zerado, esta mensagem será disparada
                MessageBox.Show("Não é possível fazer transferência de produtos com saldo zero.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If grdPacote.CurrentRow.Cells(20).Value = "B" Then 'Caso o item do pacote esteja bloqueado é por que já foi feito a a transferência
                MessageBox.Show("Este produtos já foi transferido.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If ToolStripStatusLabel3.Enabled = True Then
                Call TransferirItensDePacoteToolStripMenuItem_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub txtCodCliente_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtCodCliente.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                travaControles(Me.tabPrinc.Controls)
                travaControles(grpLimite.Controls)

                Cli.RetornaRegistroCodigo(Convert.ToInt32(txtCodCliente.Text))

                ListBox1.Text = ""
                If Cli.intMax = 1 Then
                    btnProximo.Enabled = False
                    btnUltimo.Enabled = False
                    btnAnterior.Enabled = False
                    btnPrimeiro.Enabled = False
                Else
                    btnProximo.Enabled = True
                    btnUltimo.Enabled = True
                    btnAnterior.Enabled = False
                    btnPrimeiro.Enabled = False
                End If
                Cli.Primeiro()
                CarregaCombos()
                CarregaDados()
                'promotor.exibi_promotor_cb(lblCodFilialCliente.Text, lblCodCliente.Text, ListBox1)
        End Select
    End Sub

    Private Sub txtCodCliente_Click(sender As System.Object, e As System.EventArgs) Handles txtCodCliente.Click
        txtCodCliente.ReadOnly = False
        txtCodCliente.Enabled = True
        txtCodCliente.SelectAll()
    End Sub

    Private Sub txtNome_Click(sender As System.Object, e As System.EventArgs)
        txtNome.ReadOnly = False
        txtNome.Enabled = True
        txtNome.SelectAll()
    End Sub

    Private Sub txtCodCliente_Leave(sender As System.Object, e As System.EventArgs) Handles txtCodCliente.Leave
        If Cli.intMax > 0 Then
            txtCodCliente.ReadOnly = True
        End If
    End Sub

    Private Sub tabPrinc_Enter(sender As System.Object, e As System.EventArgs) Handles tabPrinc.Enter
        txtNome.Focus()
    End Sub

    Private Sub grdPacote_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdPacote.CellClick
        If (grdPacote.CurrentRow.Cells(0).Value = True) And (grdPacote.CurrentRow.Cells(20).Value = "B") Then
            grdPacote.CurrentRow.Cells(0).ReadOnly = True
        End If
        carrega_servicos()
        carrega_produto_pacote(grdPacote.CurrentRow.Cells(1).Value)
    End Sub

    Private Sub CarregaForma()
        grdForma.Columns.Clear()
        grdForma.DataSource = Nothing
        grdForma.AutoGenerateColumns = False
        grdForma.AllowUserToAddRows = False

        Dim selecionar As New DataGridViewCheckBoxColumn
        selecionar.HeaderText = ""
        selecionar.Width = 25
        grdForma.Columns.Add(selecionar)

        Dim codigo As New DataGridViewTextBoxColumn
        codigo.DataPropertyName = "codigo"
        codigo.HeaderText = ""
        codigo.Width = 25
        codigo.Visible = False
        grdForma.Columns.Add(codigo)

        Dim descricao As New DataGridViewTextBoxColumn
        descricao.DataPropertyName = "descricao"
        descricao.HeaderText = ""
        descricao.Width = 100
        grdForma.Columns.Add(descricao)

        Dim strSQL As String = "select * from tipo_compra"
        Dim tt As New DataTable

        Conexao.CarregaTabela(strSQL, tt)
        grdForma.DataSource = tt

    End Sub

    Private Sub carregaFormaSelecionado()
        Dim strSQL As String = "select * from forma_compra where cod_cliente = " & Cli.CodigoCliente
        Dim tt As New DataTable
        Conexao.CarregaTabela(strSQL, tt)

        Dim i As Integer

        For Each linha As DataGridViewRow In grdForma.Rows
            For i = 0 To tt.Rows.Count - 1
                If linha.Cells(1).Value = tt.Rows(i)("codigo_tipo_compra") Then
                    linha.Cells(0).Value = True
                End If
            Next
        Next
    End Sub

    Private Function retornaCidade(ByVal codigo As Integer) As String
        Dim tt As New DataTable
        Dim strSQL As String = "select cidade from cidades where codigo = " & codigo
        Conexao.CarregaTabela(strSQL, tt)

        Return tt.Rows(0)("cidade").ToString
    End Function

    Private Sub grdTitulos_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles grdTitulos.CellFormatting
        If (grdTitulos.Rows(e.RowIndex).Cells(4).Value >= FormatDateTime(CDate(Conexao.RetornaDataServidor), DateFormat.ShortDate)) And (grdTitulos.Rows(e.RowIndex).Cells(6).Value Is DBNull.Value) Then
            grdTitulos.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Yellow
            grdTitulos.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
        ElseIf (CDate(grdTitulos.Rows(e.RowIndex).Cells(4).Value) < FormatDateTime(CDate(Conexao.RetornaDataServidor), DateFormat.ShortDate)) And (grdTitulos.Rows(e.RowIndex).Cells(6).Value Is DBNull.Value) Then
            grdTitulos.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Red
            grdTitulos.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.White
        ElseIf Not grdTitulos.Rows(e.RowIndex).Cells(6).Value Is DBNull.Value Then
            grdTitulos.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightBlue
            grdTitulos.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
        End If
    End Sub

    Private Sub BaixaDeTítuloToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BaixaDeTítuloToolStripMenuItem.Click
        If MessageBox.Show("Deseja realizar a baixa do título selecionado?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim strSQL As String = "update lancamentos set data_recebimento = " & Geral.DataSQL(Conexao.RetornaDataServidor) & "," & " usuario_alt = " & intUsuario &
                " where cod_lancamento = " & grdTitulos.CurrentRow.Cells(7).Value &
            " and id_filial = " & grdTitulos.CurrentRow.Cells(8).Value & " and id_filial_lancamento = " & grdTitulos.CurrentRow.Cells(9).Value
            Conexao.SalvaAtualizaExcluiReg(strSQL)
            carrega_titulos()
        End If
    End Sub

    Private Sub CancelarBaixaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CancelarBaixaToolStripMenuItem.Click
        If Conexao.RetornaDataServidor = grdTitulos.CurrentRow.Cells(6).Value Then
            If MessageBox.Show("Deseja realizar o cancelamento da baixa do título selecionado?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim strSQL As String = "update lancamentos set data_recebimento = NULL " & "," & " usuario_alt = " & intUsuario &
                    " where cod_lancamento = " & grdTitulos.CurrentRow.Cells(7).Value &
                " and id_filial = " & grdTitulos.CurrentRow.Cells(8).Value & " and id_filial_lancamento = " & grdTitulos.CurrentRow.Cells(9).Value
                Conexao.SalvaAtualizaExcluiReg(strSQL)
                carrega_titulos()
            End If
        Else
            MessageBox.Show("Cancelamento da baixa do título não pode ser concluída." & Chr(13) & "Por que a data da baixa difere da data atual.", "INFORMAÇAÕ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub grdOS_DoubleClick(sender As System.Object, e As System.EventArgs) Handles grdOS.DoubleClick
        Dim f, o As Integer
        f = grdOS.CurrentRow.Cells(0).Value
        o = grdOS.CurrentRow.Cells(1).Value
        PrintOS(f, o)
    End Sub

    Private Sub ReeimprimirOSCanceladaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ReeimprimirOSCanceladaToolStripMenuItem.Click
        'Retorna o número do pedido e da filia em que a OS está vinculada
        Dim intOrdem As Integer
        Dim strSQLPedido As String = "select num_pedido, id_filial, cod_os, cod_cliente from os where cod_os = " & grdOS.CurrentRow.Cells(1).Value & " and id_filial = " & grdOS.CurrentRow.Cells(0).Value
        Dim ttOS As New DataTable

        Conexao.CarregaTabela(strSQLPedido, ttOS)

        Dim fc As New frmRpt
        Dim r As New rptOSCancelada
        Dim tt As New DataTable
        Dim strSQL As String = "select os.cod_os, os.id_filial, os.num_pedido, os.cod_cliente, cliente.nome_cliente, " &
            "(select produtos.produto from produtos inner join OS on produtos.cod_produto = os.cod_produto_od where os.cod_os = " & ttOS.Rows(0)("cod_os") &
            " and os.id_filial = " & ttOS.Rows(0)("id_filial") & ") as OD," &
            "(select produtos.produto from produtos inner join OS on produtos.cod_produto = os.cod_produto_oe where os.cod_os = " & ttOS.Rows(0)("cod_os") &
            " and os.id_filial = " & ttOS.Rows(0)("id_filial") & ") as OE," &
            "(select OS_Cancelada.descricao from OS_Cancelada inner join OS on OS_Cancelada.cod_os = os.cod_os and OS_Cancelada.id_filial = os.id_filial " &
            "where os_cancelada.cod_os = " & ttOS.Rows(0)("cod_os") & " and OS_Cancelada.id_filial = " & ttOS.Rows(0)("id_filial") & ") as Descricao, " &
            "(select OS_Cancelada.data from OS_Cancelada inner join OS on OS_Cancelada.cod_os = os.cod_os and OS_Cancelada.id_filial = os.id_filial " &
            "where os_cancelada.cod_os = " & ttOS.Rows(0)("cod_os") & " and OS_Cancelada.id_filial = " & ttOS.Rows(0)("id_filial") & ") as data " &
            "from OS inner join cliente on os.cod_cliente = cliente.cod_cliente and os.cod_filial_cliente = cliente.cod_filial_cliente " &
            "where os.cod_cliente = " & ttOS.Rows(0)("cod_cliente") & " And os.cod_os = " & ttOS.Rows(0)("cod_os")

        Conexao.CarregaTabela(strSQL, tt)
        r.DataSource = tt
        r.Label3.Text = "OS Cancelada"
        fc.Relat(r)
        fc.ShowDialog(Me)
        fc.Dispose()
    End Sub

    Private Sub grdAcordo_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles grdAcordo.CellFormatting
        If Geral.DataSQL(CDate(grdAcordo.Rows(e.RowIndex).Cells(5).Value)) < Geral.DataSQL(Now()) Then
            grdAcordo.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Red
            grdAcordo.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.White
        ElseIf grdAcordo.Rows(e.RowIndex).Cells(12).Value Is DBNull.Value Then
            grdAcordo.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Yellow
            grdAcordo.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
        End If
    End Sub

    Private Sub grdPedidos_CurrentCellChanged(sender As System.Object, e As System.EventArgs) Handles grdPedidos.CurrentCellChanged
        Try
            id_faturas = grdPedidos.CurrentRow.Index
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCancelarOS_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelarOS.Click
        If MessageBox.Show("Deseja cancelar a OS Nº: " & grdOS.CurrentRow.Cells(1).Value, "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            'Retorna o número do pedido e da filia em que a OS está vinculada
            Dim intOrdem As Integer
            Dim strSQLPedido As String = "select num_pedido, id_filial, cod_os, cod_cliente from os where cod_os = " & grdOS.CurrentRow.Cells(1).Value & " and id_filial = " & grdOS.CurrentRow.Cells(0).Value
            Dim ttOS As New DataTable

            Conexao.CarregaTabela(strSQLPedido, ttOS)

            'Retorna o status do pedido, se está em aberto, faturado e etc
            Dim strSQLStatusPedido As String = "select cod_status_pedido from pedido_balcao where num_pedido = " & ttOS.Rows(0)("num_pedido") &
                " and id_filial = " & ttOS.Rows(0)("id_filial")
            Dim ttPedido As New DataTable

            Conexao.CarregaTabela(strSQLStatusPedido, ttPedido)

            'Retotna a descrição do status do pedido
            Dim strSQLStatus As String = "select status_pedido from status_pedido where cod_status_pedido = " & ttPedido.Rows(0)("cod_status_pedido")
            Dim ttStatus As New DataTable
            Conexao.CarregaTabela(strSQLStatus, ttStatus)

            'Verifica se o pedido está em aberto em caso positivo as instruções seguintes são executadas
            If ttPedido.Rows(0)("cod_status_pedido") = 1 Then
                'Atualiza a OS para o status de cancelada
                Dim strSQLOS As String = "update os set cod_fase = 21 where cod_os = " & grdOS.CurrentRow.Cells(1).Value & " and id_filial = " & grdOS.CurrentRow.Cells(0).Value
                Conexao.SalvaAtualizaExcluiReg(strSQLOS)

                'Atualiza o status do pedido para cancelado
                Dim strSQLAtualizaPed As String = "update pedido_balcao set cod_status_pedido = 4 where num_pedido = " & ttOS.Rows(0)("num_pedido") & " and id_filial = " & ttOS.Rows(0)("id_filial")
                Conexao.SalvaAtualizaExcluiReg(strSQLAtualizaPed)

                'Atualiza o status do item do pedido para cancelado
                Dim strSQLAtualizaItemPed As String = "update pedido_balcao_itens set cod_status_item = 4 where num_pedido = " & ttOS.Rows(0)("num_pedido") & " and id_filial = " & ttOS.Rows(0)("id_filial")
                Conexao.SalvaAtualizaExcluiReg(strSQLAtualizaItemPed)

                'Atualiza o status do serviço parfa cancelado caso haja serviço vinculado ao pedido
                Dim strSQLAtualizaItemServ As String = "update pedido_balcao_servicos set cod_status_servico = 2 where num_pedido = " & ttOS.Rows(0)("num_pedido") & " and id_filial = " & ttOS.Rows(0)("id_filial")
                Conexao.SalvaAtualizaExcluiReg(strSQLAtualizaItemServ)

                Dim f As New frmTexto
                f.ShowDialog()
                strTexto = f.txtTexto.Text
                f.Dispose()

                Dim strSQLInsert As String = "Insert into OS_Cancelada (cod_os, id_filial,descricao,data,usuario) values(" &
                    grdOS.CurrentRow.Cells(1).Value & "," & grdOS.CurrentRow.Cells(0).Value & "," & Geral.DataSQL(strTexto) & "," & Geral.DataSQL(Now()) & "," & intUsuario & ")"
                Conexao.SalvaAtualizaExcluiReg(strSQLInsert)

                intOrdem = Conexao.RetornaChave("ordem", "andamentos", "where cod_os = " & ttOS.Rows(0)("cod_os") & " and id_filial = " & ttOS.Rows(0)("id_filial"))

                Dim strSQLOrdem As String = "INSERT INTO andamentos(id_filial, cod_os, id_filial_andamento, ordem, data, cod_andamento, cod_usuario," &
                "cod_status_andamento ,Observacao) VALUES(" & ttOS.Rows(0)("id_filial") & "," & ttOS.Rows(0)("cod_os") & "," & conf.Filial &
                "," & intOrdem & "," & Geral.DataSQL(Now()) & "," & 703 & "," & intUsuario & "," & 1 & "," & Geral.AspasSQL(strTexto) & ")"
                Conexao.SalvaAtualizaExcluiReg(strSQLOrdem)

                MessageBox.Show("OS Nº " & grdOS.CurrentRow.Cells(1).Value & " cancelada com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Dim fc As New frmRpt
                Dim r As New rptOSCancelada
                Dim tt As New DataTable
                Dim strSQL As String = "select os.cod_os, os.id_filial, os.num_pedido, os.cod_cliente, cliente.nome_cliente, " &
                    "(select produtos.produto from produtos inner join OS on produtos.cod_produto = os.cod_produto_od where os.cod_os = " & ttOS.Rows(0)("cod_os") &
                    " and os.id_filial = " & ttOS.Rows(0)("id_filial") & ") as OD," &
                    "(select produtos.produto from produtos inner join OS on produtos.cod_produto = os.cod_produto_oe where os.cod_os = " & ttOS.Rows(0)("cod_os") &
                    " and os.id_filial = " & ttOS.Rows(0)("id_filial") & ") as OE," &
                    "(select OS_Cancelada.descricao from OS_Cancelada inner join OS on OS_Cancelada.cod_os = os.cod_os and OS_Cancelada.id_filial = os.id_filial " &
                    "where os_cancelada.cod_os = " & ttOS.Rows(0)("cod_os") & " and OS_Cancelada.id_filial = " & ttOS.Rows(0)("id_filial") & ") as Descricao, " &
                    "(select OS_Cancelada.data from OS_Cancelada inner join OS on OS_Cancelada.cod_os = os.cod_os and OS_Cancelada.id_filial = os.id_filial " &
                    "where os_cancelada.cod_os = " & ttOS.Rows(0)("cod_os") & " and OS_Cancelada.id_filial = " & ttOS.Rows(0)("id_filial") & ") as data " &
                    "from OS inner join cliente on os.cod_cliente = cliente.cod_cliente and os.cod_filial_cliente = cliente.cod_filial_cliente " &
                    "where os.cod_cliente = " & ttOS.Rows(0)("cod_cliente") & " And os.cod_os = " & ttOS.Rows(0)("cod_os")
                Conexao.CarregaTabela(strSQL, tt)
                r.DataSource = tt
                r.Label3.Text = "OS Cancelada"
                fc.Relat(r)
                fc.ShowDialog(Me)
                fc.Dispose()

            Else
                MessageBox.Show("OS não pode ser cancelada devido ter sido " & ttStatus.Rows(0)("status_pedido").ToString & ".", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        formata_grid_OS(1)
    End Sub

    Function municipio() As String
        Dim strSQL As String = "Select * From Cidades where codigo = " & cbCidade.SelectedValue
        Dim tbCidade As New DataTable
        Conexao.CarregaTabela(strSQL, tbCidade)
        Return tbCidade.Rows(0)("cidade")
    End Function

    Private Sub btnDeletarItemPacote_Click(sender As System.Object, e As System.EventArgs) Handles btnDeletarItemPacote.Click
        If grdPacote.Rows.Count > 0 Then
            If grdPacote.CurrentRow.Cells(0).Value = True Then
                If MessageBox.Show("Deseja excluir o item selecionado: " & grdPacote.CurrentRow.Cells(1).Value.ToString & "?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim intCodTabela = grdPacote.CurrentRow.Cells(1).Value
                    Cli.ExcluirItemPacote(CInt(cbPacote.SelectedValue), CInt(txtCodCliente.Text), CInt(grdPacote.CurrentRow.Cells(1).Value))
                    MessageBox.Show("Item excluído com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    desativaControle()
                End If
            Else
                MessageBox.Show("Selecione o item a ser excluído.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            grdPacote.Columns.Clear()
            grdPacote.DataSource = Nothing

            grdPacote.AutoGenerateColumns = False
            grdPacote.AllowUserToAddRows = False
            grdPacote.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            FormatPacote()
        Else
            MessageBox.Show("Não há item a ser excluído do pacote.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub valortotalproduto()
        'Mostra o total de produtos
        Dim precodesconto As Double = CDbl(lblPreco.Text) - (CDbl(lblPreco.Text) * CDbl(txtDesconto.Text) / 100)
        Dim totalproduto As Double = precodesconto * CInt(txtQuant.Text)
        lblTotalProduto.Text = Format(totalproduto, "#,##0.00")

        'Mostra o valor total de itens da surfaçagem
        Dim precodescsurf As Double = CDbl(lblPrecoSuf.Text) - (CDbl(lblPrecoSuf.Text) * CDbl(txtDescSurf.Text) / 100)
        Dim totalsurfacagem As Double = precodescsurf * CInt(txtQtdeSurf.Text)
        lblTotalSurfacagem.Text = Format(totalsurfacagem, "#,##0.00")

        'Mostra o valor total de itens da montagem
        Dim precodescmont As Double = CDbl(lblPrecoMont.Text) - (CDbl(lblPrecoMont.Text) * CDbl(txtDescMont.Text) / 100)
        Dim totalmontagem As Double = precodescmont * CInt(txtQuantMont.Text)
        lblTotalMontagem.Text = Format(totalmontagem, "#,##0.00")

        'Mostra o valor total de itens do tratamento
        Dim precodesctrat As Double = CDbl(lblPrecoTrat.Text) - (CDbl(lblPrecoMont.Text) * CDbl(txtDescTrat.Text) / 100)
        Dim totaltratamento As Double = precodesctrat * CInt(txtQuantTrat.Text)
        lblTotalTratamento.Text = Format(totaltratamento, "#,##0.00")
    End Sub

    Private Sub cbPacote_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbPacote.SelectedIndexChanged
        If intControle = 1 Then
            intControle = 0
        Else
            Try
                If cbPacote.SelectedValue > 0 Then
                    FormatPacote()
                    If grdPacote.Rows.Count > 0 Then
                        carrega_produto_pacote(grdPacote.CurrentRow.Cells(1).Value)
                    Else
                        lblCodigoProduto.Text = ""
                        txtProduto.Text = ""
                        txtQuant.Text = ""
                        txtDesconto.Text = ""
                        lblPreco.Text = ""
                        lblPrecoProdPacDesc.Text = ""
                        lblPrecoSuf.Text = ""
                        txtQtdeSurf.Text = ""
                        txtDescSurf.Text = ""
                        lblPrecoDescSurf.Text = ""
                        lblPrecoMont.Text = ""
                        txtQuantMont.Text = ""
                        txtDescMont.Text = ""
                        lblPrecoDescMont.Text = ""
                        lblPrecoTrat.Text = ""
                        txtQuantTrat.Text = ""
                        txtDescTrat.Text = ""
                        lblPrecoDescTrat.Text = ""
                        carrega_servicos()
                    End If


                    Dim strSQL As String = "Select 1 From Pacote_Cliente where cod_cliente = " & CInt(txtCodCliente.Text) &
                    " and cod_filial_cliente = " & CInt(lblCodFilialCliente.Text) & " and cod_pacote = " & CInt(cbPacote.SelectedValue) &
                    " and concluido = 'S'"
                    If Conexao.VerificaExistenciaReg(strSQL) = 1 Then
                        btnNovoItemPacote.Enabled = False
                        btnSalvarPacote.Enabled = False
                        btnDeletarItemPacote.Enabled = False
                        btnConcluirPacote.Enabled = False
                    Else
                        btnNovoItemPacote.Enabled = True
                        btnSalvarPacote.Enabled = True
                        btnDeletarItemPacote.Enabled = True
                        btnConcluirPacote.Enabled = True
                    End If
                Else
                    grdPacote.DataSource = Nothing
                    lblCodigoProduto.Text = ""
                    txtProduto.Text = ""
                    txtQuant.Text = ""
                    txtDesconto.Text = ""
                    lblPreco.Text = ""
                    lblPrecoProdPacDesc.Text = ""
                    lblPrecoSuf.Text = ""
                    txtQtdeSurf.Text = ""
                    txtDescSurf.Text = ""
                    lblPrecoDescSurf.Text = ""
                    lblPrecoMont.Text = ""
                    txtQuantMont.Text = ""
                    txtDescMont.Text = ""
                    lblPrecoDescMont.Text = ""
                    lblPrecoTrat.Text = ""
                    txtQuantTrat.Text = ""
                    txtDescTrat.Text = ""
                    lblPrecoDescTrat.Text = ""
                    lblTotal.Text = ""
                    lblTotalProduto.Text = ""
                    lblTotalSurfacagem.Text = ""
                    lblTotalMontagem.Text = ""
                    lblTotalTratamento.Text = ""
                    carrega_servicos()
                End If

                Dim intContagem As Int16

                For Each linha As DataGridViewRow In grdPacote.Rows
                    If linha.Cells(6).Value = linha.Cells(7).Value Then
                        intContagem = +1
                    End If

                    If intContagem = grdPacote.Rows.Count Then
                        btnConcluirPacote.Enabled = True
                    End If

                    If linha.Cells(20).Value = "B" Then
                        btnConcluirPacote.Enabled = False
                    End If
                Next
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub txtDesconto_Leave(sender As System.Object, e As System.EventArgs) Handles txtDesconto.Leave
        Dim precodesconto As Double = CDbl(lblPreco.Text) * txtDesconto.Text / 100
        lblPrecoProdPacDesc.Text = Format(CDbl(lblPreco.Text) - precodesconto, "#,##0.00")
        lblTotalProduto.Text = Format((CDbl(lblPreco.Text) - precodesconto) * CInt(txtQuant.Text), "#,##0.00")
    End Sub

    Private Sub txtCep_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCep.ButtonClick
        Dim strCEP As New BuscaCEP()
        strCEP.RetornoCep(txtCep.Text)

        If strCEP.MensagemRetorno <> String.Empty Then
            MessageBox.Show(strCEP.MensagemRetorno, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        txtEndreço.Text = strCEP.Logradouro
        txtComplemento.Text = strCEP.Complemento
        txtUF.Text = strCEP.UF
        txtBairro.Text = strCEP.Bairro
        cbCidade.SelectedValue = strCEP.IbgeCodigo
    End Sub

    Private Sub txtNome_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNome.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                CarregaPesquisa()
        End Select
    End Sub

    Private Sub CarregaPesquisa()
        If Cli.RetornaRegistroCodigo(Convert.ToInt32(txtCodCliente.Text)) = True Then
            btnEditar.Enabled = True
        Else
            btnEditar.Enabled = False
        End If

        If txtNome.Text <> String.Empty Then
            If Cli.RetornaRegistroNome(txtNome.Text) = False Then
                MessageBox.Show("Desculpe, nenhum registro foi encontrado!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Cli.Novo()
                Exit Sub
            End If
        End If

        ListBox1.Text = ""

        If Cli.intPonteiro = 0 Then
            btnProximo.Enabled = True
            btnUltimo.Enabled = True
            btnAnterior.Enabled = False
            btnPrimeiro.Enabled = False
        End If

        CarregaCombos()
        CarregaDados()
    End Sub

    Private Sub cbTipoPessoa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipoPessoa.SelectedIndexChanged
        If cbTipoPessoa.SelectedIndex = 0 Then
            txtCnpjCpf.Properties.Mask.EditMask = "\d\d\d\.\d\d\d\.\d\d\d\-\d\d"
            txtCnpjCpf.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular
        ElseIf cbTipoPessoa.SelectedIndex = 1 Then
            txtCnpjCpf.Properties.Mask.EditMask = "\d\d\.\d\d\d\.\d\d\d/\d\d\d\d-\d?\d?"
            txtCnpjCpf.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular
        End If
    End Sub

    Private Sub btnLocalizar_Click(sender As Object, e As EventArgs) Handles btnLocalizar.Click
        Dim f As New frmConsultaProduto
        'Indica de qual tela do formulário está partindo a solicitação para a tela de pesquisa
        'Isso ajuda a formar a tela de pesquisa com os campos corretos no grid de acordo com os dados a serem retornados
        f.strLocalConsulta = "Clientes"
        f.strTela = "Localizar Cliente"
        f.Text = "Localizar cliente"
        f.lblCodigo.Text = "Código Cliente"
        f.lblDescricao.Text = "Nome Cliente"
        f.ShowDialog()
        txtCodCliente.Text = f.codigoCliente
        If f.codigoCliente > 0 Then
            CarregaPesquisa()
        End If
    End Sub


End Class