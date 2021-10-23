Imports System.Collections.Generic
Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI

Imports MRUtil
Imports mrotica_util
Public Class frmCliente
    Dim Conf As New Arquivo
    Dim Usu As UsuarioPermissao = New UsuarioPermissao()
    Dim Cliente As New Cliente
    Dim PromotorClienteVenda As PromotorVenda
    Dim FormaClienteCompra As FormaCompra
    Dim PacoteCli As PacoteClienteDetalhes
    'Dim PacoteDetalhe As PacoteClienteDetalhes()
    Dim ServicoCli As Servicos
    Dim LenteTabela As Lentes
    Dim Util As New Geral
    Dim creditoCliente As CreditoCliente
    Dim strRegOp As String
    Dim id_faturas As Integer
    Dim Conexao As New ConexaoDB()
    Dim pedido As objPedidoBalcao

    Private Sub frmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        Geral.TipoReg = Belemtech.TiposReg.Novo 'Usado para indicar uma operação de ñovo registro
        'usado para indicar se o botão editar será ativado ou desativado, se a operaçã anterior
        'partir de um novo registro e ao cancelar o botão editar ficará desativado se partir de outra 
        'operação qualquer o botão editar ficará ativo
        Util.AcaoAnterior = Belemtech.TiposReg.Novo

        Cliente.Novo()

        lblCodFilialCliente.Text = Format(Conf.Filial, "00")
        lblPromotorVenda.DataSource = Nothing

        CarregaCombos()

        txtCnpjCpf.Text = String.Empty
        txtCep.Text = String.Empty
        txtFoneNota.Text = String.Empty
        txtLimiteCompra.Text = 0
        txtlimiteCredito.Text = 0
        txtDiasPagar.Text = 0

        Util.AtivaControles(Me)
        Util.AcaoBotoesNormal(Me, Belemtech.TiposReg.Novo)

        lblStatus.Text = "Modo de Inclusão"

        txtCodCliente.ReadOnly = True
        cbAtivo.Checked = True
        cbTipoPessoa.Focus()
    End Sub

    Private Sub CarregaCombos()

        Dim cidade As New Cidades()
        Dim listaCidade As New List(Of Cidades)
        listaCidade = cidade.RetornaCidade()
        cbCidade.DataSource = listaCidade
        cbCidade.DisplayMember = "NomeCidade"
        cbCidade.ValueMember = "CodigoCidade"

        Dim formaCompra As New FormaCompra()
        Dim listaFormaCompra As New List(Of FormaCompra)
        listaFormaCompra = formaCompra.RetornaDados()
        cbFormaCompra.DataSource = listaFormaCompra
        cbFormaCompra.DisplayMember = "DescricaoCompra"
        cbFormaCompra.ValueMember = "CodigoFormaCompra"

        Dim promotor As New PromotorVenda()
        Dim listaPromotor As New List(Of PromotorVenda)
        listaPromotor = promotor.RetornaRegistro()
        cbPromotor.DataSource = listaPromotor
        cbPromotor.DisplayMember = "NomePromotor"
        cbPromotor.ValueMember = "CodigoPromotor"

        Dim tipocliente As New TipoCliente()
        Dim listaTipoCliente As New List(Of TipoCliente)
        listaTipoCliente = tipocliente.RetornaDados()
        cbTipoCliente.DataSource = listaTipoCliente
        cbTipoCliente.DisplayMember = "DescTipoCliente"
        cbTipoCliente.ValueMember = "CodigoTipoCliente"
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        Geral.TipoReg = Belemtech.TiposReg.Alterar
        'DestravaControles(Me.tabPrinc.Controls)
        'Procedimento 35 Limites de Crédito
        'If usuario.acesso(UserID, 35) = True Then
        'DestravaControles(Me.grpLimite.Controls)
        'End If

        Util.AtivaControles(Me)
        Util.AcaoBotoesNormal(Me, Belemtech.TiposReg.Alterar)
        txtCodCliente.ReadOnly = True
        lblStatus.Text = "Modo Alteração"
        txtNome.Focus()
    End Sub

    Private Sub btnExclui_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Geral.TipoReg = Belemtech.TiposReg.Excluir

        If Geral.TelaAviso("Deseja excluir este registro de cliente?", "INFORMAÇÃO", Me, Belemtech.TipoAviso.SIMNAO, Belemtech.ImagemAviso.Informacao) = Belemtech.Respo.SIM Then
            If Cliente.ExcluirCliente() = True Then
                Util.AcaoBotoesNormal(Me, Belemtech.TiposReg.Excluir)
                lblStatus.Text = ""
            End If
        End If
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim cep As String = String.Empty
        Dim telefoneNota As String = String.Empty

        Cliente.CodigoFilialCliente = Conf.Filial

        Cliente.NomeCliente = txtNome.Text
        Cliente.RazaoSocial = txtRazaoSocial.Text
        Cliente.CpfCnpj = Geral.RetornaSoNumero(txtCnpjCpf.Text)

        If cbTipoPessoa.SelectedIndex <> -1 Then
            If cbTipoPessoa.SelectedIndex = 0 Then
                Cliente.TipoPessoa = "F"
                Cliente.Rg = txtIE.Text
                Cliente.TipoDocumento = "CPF"
            Else
                Cliente.TipoPessoa = "J"
                Cliente.Ie = txtIE.Text
                Cliente.TipoDocumento = "CNPJ"
            End If
        End If

        Cliente.Logradouro = txtEndreço.Text
        Cliente.Complemento = txtComplemento.Text
        Cliente.Bairro = txtBairro.Text
        Cliente.NomeCidade = cbCidade.Text
        Cliente.Uf = txtUF.Text
        Cliente.Cep = Geral.RetornaSoNumero(txtCep.Text)
        Cliente.Telefone = txtFone.Text
        Cliente.Observacao = txtObs.Text
        If txtLimiteCompra.Text = "" Then
            txtLimiteCompra.Text = "0,00"
        End If
        Cliente.LimiteCompra = txtLimiteCompra.Text
        If txtlimiteCredito.Text = "" Then
            txtlimiteCredito.Text = "0,00"
        End If
        Cliente.LimiteCredito = txtlimiteCredito.Text
        Cliente.LimiteCheque = 0
        If txtDiasPagar.Text = "" Then
            txtDiasPagar.Text = "0"
        End If
        Cliente.QtdeDiaPagar = txtDiasPagar.Text
        Cliente.SemDesconto = chkSemDesconto.Checked
        Cliente.CidadeIBGE = cbCidade.SelectedValue
        Cliente.Numero = txtNumero.Text
        If txtFoneNota.Text <> String.Empty Then
            Cliente.TelefoneNota = Geral.RetornaSoNumero(txtFoneNota.Text)
        Else
            Cliente.TelefoneNota = "00000000000"
        End If

        Cliente.Email = txtEmail.Text
        Cliente.CodigoTipoCliente = cbTipoCliente.SelectedValue
        Cliente.TipoIE = 9
        Cliente.EstoquePreferencial = 0
        Cliente.Situacao = cbAtivo.Checked

        If Cliente.VerificaCampoObrigatorio() = True Then
            Geral.TelaAviso(Cliente.MensagemRetorno, "INFORMAÇÃO", Me, Belemtech.TipoAviso.OK, Belemtech.ImagemAviso.Informacao)
            Exit Sub
        End If

        Dim bResultado As Boolean = False

        If Geral.TipoReg = Belemtech.TiposReg.Novo Then
            If Cliente.SalvaCliente() = True Then
                bResultado = True
                txtCodCliente.Text = Format(Cliente.CodigoCliente, "000")
                Geral.TelaAviso("Registro salvo com sucesso.", "INFORMAÇÃO", Me, Belemtech.TipoAviso.OK, Belemtech.ImagemAviso.Informacao)
                Util.DesativaControles(Me)
            End If
        ElseIf Geral.TipoReg = Belemtech.TiposReg.Alterar Then
            If Cliente.AtualizaCliente() = True Then
                bResultado = True
                Geral.TelaAviso("Registro alterado com sucesso.", "INFORMAÇÃO", Me, Belemtech.TipoAviso.OK, Belemtech.ImagemAviso.Informacao)
                Util.DesativaControles(Me)
            End If
        End If

        If bResultado = True Then
            Dim i As Integer = 0
            lblStatus.Text = ""

            PromotorClienteVenda = New PromotorVenda()
            PromotorClienteVenda.ExcluiPromotorVendaCliente(Cliente.CodigoCliente, Cliente.CodigoFilialCliente)
            For i = 0 To lblPromotorVenda.Items.Count - 1
                PromotorClienteVenda.CodigoCliente = Cliente.CodigoCliente
                PromotorClienteVenda.CodigoFilialCliente = Cliente.CodigoFilialCliente
                PromotorClienteVenda.SalvaPromotorVendaCliente(lblPromotorVenda.Items(i).ToString())
            Next

            FormaClienteCompra = New FormaCompra()
            FormaClienteCompra.ExcluiFormaCompraCliente(Cliente.CodigoCliente, Cliente.CodigoFilialCliente)
            For i = 0 To lblFormaCompra.Items.Count - 1
                FormaClienteCompra.CodigoCliente = Cliente.CodigoCliente
                FormaClienteCompra.CodigoFilialCliente = Cliente.CodigoFilialCliente
                FormaClienteCompra.SalvaFormaCompraCliente(lblFormaCompra.Items(i).ToString())
            Next

            Util.AcaoBotoesNormal(Me, Belemtech.TiposReg.Salvar)
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Geral.TipoReg = Belemtech.TiposReg.Cancelar

        If Cliente.CodigoCliente <> 0 Then
            CarregaDados()
        End If

        lblStatus.Text = ""
        gbControlePrincipal.Enabled = True
        lblPromotorVenda.Enabled = False
        'btnNovo.Enabled = True
        'btnAlterar.Enabled = True
        'btnExcluir.Enabled = False
        'btnSalvar.Enabled = False
        'btnCancelar.Enabled = False
        ' btnAddPromotor.Enabled = False
        'btnAddCompra.Enabled = False
        'btnExcluirPromotor.Enabled = False
        'btnExcluirCompra.Enabled = False
        cbFormaCompra.Enabled = False
        Util.DesativaControles(Me)
        Util.AcaoBotoesNormal(Me, Belemtech.TiposReg.Cancelar)


        'travaControles(Me.tabPrinc.Controls)
    End Sub

    Private Sub btnLocalizar_Click(sender As Object, e As EventArgs) Handles btnLocalizar.Click
        Dim f As New frmConsultaProduto
        'Indica de qual tela do formulário está partindo a solicitação para a tela de pesquisa
        'Isso ajuda a formar a tela de pesquisa com os campos corretos no grid de acordo com os dados a serem retornados
        strRegOp = Belemtech.TiposReg.Localizar
        f.strLocalConsulta = "Clientes"
        f.strTela = "Localizar Cliente"
        f.Text = "Localizar cliente"
        f.lblCodigo.Text = "Código Cliente"
        f.lblDescricao.Text = "Nome Cliente"
        f.ShowDialog()
        txtCodCliente.Text = f.codigoCliente
        If f.codigoCliente <> 0 Then
            CarregaDados()
        End If
    End Sub

    Private Sub CarregaDados()
        'Status()

        If strRegOp = Belemtech.TiposReg.Localizar Then
            If (Cliente.RetornaCliente(Convert.ToInt32(txtCodCliente.Text)) = True) Then
                btnAlterar.Enabled = True
            Else
                btnAlterar.Enabled = False
            End If
        Else
            If (Cliente.RetornaCliente(txtNome.Text) = True) Then
                btnAlterar.Enabled = True
            Else
                btnAlterar.Enabled = False
                Geral.TelaAviso("Desculpe, nenhum registro foi encontrado!", "INFORMAÇÃO", Me, Belemtech.TipoAviso.OK, Belemtech.ImagemAviso.Informacao)
                Exit Sub
            End If
        End If

        CarregaCombos()

        If Cliente.intPonteiro = 0 Then
            btnProximo.Enabled = True
            btnUltimo.Enabled = True
            btnAnterior.Enabled = False
            btnPrimeiro.Enabled = False
        End If

        lblCodFilialCliente.Text = Format(Cliente.CodigoFilialCliente, "00")
        txtCodCliente.Text = Format(Cliente.CodigoCliente, "000")
        txtNome.Text = Cliente.NomeCliente
        txtRazaoSocial.Text = Cliente.RazaoSocial

        txtCnpjCpf.Text = Geral.FormataCNPJCPF(Cliente.CpfCnpj)

        txtIE.Text = Cliente.Ie
        txtEndreço.Text = Cliente.Logradouro
        txtNumero.Text = Cliente.Numero
        txtComplemento.Text = Cliente.Complemento
        txtBairro.Text = Cliente.Bairro
        txtUF.Text = Cliente.Uf
        txtCep.Text = Geral.FormataCEP(Cliente.Cep)
        txtFone.Text = Cliente.Telefone
        txtLimiteCompra.Text = Geral.FormataMoeda(Cliente.LimiteCompra)
        txtlimiteCredito.Text = Geral.FormataMoeda(Cliente.LimiteCredito)
        txtLimiteDisponivel.Text = Geral.FormataMoeda(Cliente.LimiteCredito - Cliente.ResumoReceberTotalCliente)
        txtDiasPagar.Text = Cliente.QtdeDiaPagar
        txtEmail.Text = Cliente.Email
        txtObs.Text = Cliente.Observacao
        cbCidade.SelectedValue = Cliente.CidadeIBGE
        chkSemDesconto.Checked = Cliente.SemDesconto
        txtFoneNota.Text = Geral.FormataTelefone(Cliente.TelefoneNota)
        cbTipoCliente.SelectedValue = Cliente.CodigoTipoCliente
        If Cliente.Situacao = False Then
            cbAtivo.Checked = False
        ElseIf Cliente.Situacao = True Then
            cbAtivo.Checked = True
        End If

        If Cliente.TipoPessoa = "F" Then
            cbTipoPessoa.SelectedIndex = 0
        ElseIf Cliente.TipoPessoa = "J" Then
            cbTipoPessoa.SelectedIndex = 1
        End If

        carregaFormaCompra() 'Carrega as formas de venda para o cliente selecionado
        carregaPromotorVenda() 'Carega os promotores de venda associado ao cliente selecionado
        carregaRestricoes()
        formataGridResumo()

        'ciclo = New objCiclo(cliente.cod_cliente, cliente.cod_filial_cliente)
    End Sub

    Private Sub carregaFormaCompra()
        Dim formaCompra As New FormaCompra()
        Dim listaFormaCompra As New List(Of FormaCompra)
        listaFormaCompra = formaCompra.RetornaFormaCompra(Cliente.CodigoCliente)
        Dim i As Integer = 0

        For i = 0 To listaFormaCompra.Count - 1
            lblFormaCompra.Items.Add(listaFormaCompra.Item(i).DescricaoCompra)
        Next
    End Sub

    Private Sub carregaPromotorVenda()
        Dim promotor As New PromotorVenda()
        Dim listaPromotor As New List(Of PromotorVenda)
        listaPromotor = promotor.RetornaPromotorVendaPorCliente(Cliente.CodigoCliente)

        Dim i As Integer

        For i = 0 To listaPromotor.Count - 1
            lblPromotorVenda.Items.Add(listaPromotor.Item(i).NomePromotor)
        Next
    End Sub


    Private Sub txtNome_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNome.KeyDown
        'Select Case e.KeyCode
        'Case Keys.Enter
        'CarregaDados()
        'End Select
    End Sub

    Private Sub btnAddCompra_Click(sender As Object, e As EventArgs) Handles btnAddCompra.Click
        lblFormaCompra.Items.Add(cbFormaCompra.Text)
    End Sub

    Private Sub btnExcluirCompra_Click(sender As Object, e As EventArgs) Handles btnExcluirCompra.Click
        lblFormaCompra.Items.Remove(lblFormaCompra.SelectedItem)
    End Sub

    Private Sub btnAddPromotor_Click(sender As Object, e As EventArgs) Handles btnAddPromotor.Click
        lblPromotorVenda.Items.Add(cbPromotor.Text)
    End Sub

    Private Sub btnExcluirPromotor_Click(sender As Object, e As EventArgs) Handles btnExcluirPromotor.Click
        lblPromotorVenda.Items.Remove(lblPromotorVenda.SelectedItem)
    End Sub

    Private Sub lblFormaCompra_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lblFormaCompra.SelectedIndexChanged
        btnExcluirCompra.Enabled = True
    End Sub

    Private Sub lblPromotorVenda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lblPromotorVenda.SelectedIndexChanged
        btnExcluirPromotor.Enabled = True
    End Sub

    Private Sub txtCep_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCep.ButtonClick
        Dim strCEP As New BuscaCEP()
        strCEP.RetornoCep(txtCep.Text)

        If strCEP.MensagemRetorno <> String.Empty Then
            Geral.TelaAviso(strCEP.MensagemRetorno, "ERROR", Me, Belemtech.TipoAviso.OK, Belemtech.ImagemAviso.Error)
            Exit Sub
        End If

        txtEndreço.Text = strCEP.Logradouro
        txtComplemento.Text = strCEP.Complemento
        txtUF.Text = strCEP.UF
        txtBairro.Text = strCEP.Bairro
        cbCidade.SelectedValue = strCEP.IbgeCodigo
    End Sub

    Private Sub carregaRestricoes()
        Dim tt As New DataTable
        tt = Cliente.RestricaoCliente(True)
        restricoesBloqueado()
    End Sub

    Public Function restricoesBloqueado() As Integer
        Dim tbRestricao As New DataTable
        Dim bloqueio As New RestricaoBloqueio
        Dim dataServer As New ConexaoDB
        Dim resultado As Integer = 0

        tbRestricao = Cliente.ResumoReceberCliente(Cliente.CodigoCliente, Cliente.CodigoFilialCliente)
        bloqueio.DataVencimentoAcordoAberto(Cliente.CodigoCliente, Cliente.CodigoFilialCliente)
        bloqueio.DataVencimentoTituloAberto(Cliente.CodigoCliente, Cliente.CodigoFilialCliente)

        Dim strMensagem As String = ""

        For Each linha As DataRow In tbRestricao.Rows
            If linha("acordo_atrasado") > 0 Then
                btnStatus.BackColor = Color.Red
                btnStatus.ForeColor = Color.AliceBlue
                strMensagem = "CLIENTE COM ACORDO EM ATRASO" & Chr(13)
                resultado = 1
                If DateDiff(DateInterval.Day, bloqueio.DataVencAcordoAberto, dataServer.RetornaDataServidor()) <= 60 Then
                    intDia = 60 - DateDiff(DateInterval.Day, bloqueio.DataVencAcordoAberto, Now())
                End If
            ElseIf linha("titulos_atraso") > 0 Then
                btnStatus.BackColor = Color.Red
                btnStatus.ForeColor = Color.AliceBlue
                strMensagem = "CLIENTE COM TITULOS EM ATRASO" & Chr(13)
                resultado = 2
                If DateDiff(DateInterval.Day, bloqueio.DataVencTituloAberto, dataServer.RetornaDataServidor()) <= 60 Then
                    intDia = 60 - DateDiff(DateInterval.Day, bloqueio.DataVencTituloAberto, Now())
                End If
            ElseIf Cliente.ResumoReceberTotalCliente > Cliente.LimiteCredito Then
                btnStatus.BackColor = Color.Yellow
                btnStatus.ForeColor = Color.AliceBlue
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

    Private Sub formataGridResumo()
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

        grdResumo.DataSource = Cliente.ResumoReceberCliente
    End Sub

    Private Sub frmCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub btnNovoPacote_Click(sender As Object, e As EventArgs) Handles btnNovoPacote.Click
        Geral.TipoReg = Belemtech.TiposReg.Novo
        Util.AcaoAnterior = Belemtech.TiposReg.Novo
        PacoteCli.Novo()
        PacoteCli.CodigoCliente = Cliente.CodigoCliente
        PacoteCli.CodigoFilialCliente = Conf.Filial
        PacoteCli.Observacao = txtObservacaoPacote.Text
        If Geral.TelaAviso("Deseja criar um novo pacote?", "INFORMAÇÃO", Me, Belemtech.TipoAviso.SIMNAO, Belemtech.ImagemAviso.Informacao) = Belemtech.Respo.SIM Then
            If PacoteCli.SalvaPacote() = True Then
                Util.AcaoBotoesNormal(tbPacoteDesconto, Belemtech.TiposReg.Novo)
                Util.AtivaControles(tbPacoteDesconto)
                'Util.DesativaControles(tbPacoteDesconto)
                LimpaLabel()
                CarregaPacote()
                cbPacote.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnExcluirPacote_Click(sender As Object, e As EventArgs) Handles btnExcluirPacote.Click

    End Sub

    Private Sub btnConcluirPacote_Click(sender As Object, e As EventArgs) Handles btnConcluirPacote.Click

        creditoCliente = New CreditoCliente()

        If PacoteCli.Concluido = "S" Then
            abreTelaReceberCredito()
            Exit Sub
        End If
        If grdPacote.Rows.Count > 0 Then
            If Usu.VerificaPermissaoUsuario(19) = True Then
                If Geral.TelaAviso("Deseja concluir o pacote selecionado?", "INFORMAÇÃO", Me, Belemtech.TipoAviso.SIMNAO, Belemtech.ImagemAviso.Informacao) = Belemtech.Respo.SIM Then
                    Dim strHistorico As String = "Aquisição do Pacote " & cbPacote.SelectedValue & " do cliente " & Cliente.NomeCliente

                    creditoCliente.CodigoFilial = Conf.Filial
                    creditoCliente.CodigoCliente = Cliente.CodigoCliente
                    creditoCliente.CodigoFilialCliente = Cliente.CodigoFilialCliente
                    creditoCliente.Credito = Convert.ToDecimal(lblTotalPacote.Text)
                    creditoCliente.Historico = strHistorico
                    creditoCliente.CodigoUsuario = Usu.CodigoUsuario
                    creditoCliente.Concluido = "S"
                    creditoCliente.CodigoPacote = cbPacote.SelectedValue
                    creditoCliente.Observacao = txtObservacaoPacote.Text

                    If creditoCliente.SalvaCreditoCliente() = True Then
                        AcaoConcluido()
                        PacoteCli.RetornaDadosPacote()
                        abreTelaReceberCredito()
                    End If
                End If
            Else
                Geral.TelaAviso("Usuário não tem acesso a operações de Crédito.", "ERROR: 19", Me, Belemtech.TipoAviso.OK, Belemtech.ImagemAviso.Error)
            End If
        Else
            Geral.TelaAviso("Não há item neste pacote para ser concluído!", "INFORMAÇÃO", Me, Belemtech.TipoAviso.OK, Belemtech.ImagemAviso.Informacao)
        End If
    End Sub

    Private Sub abreTelaReceberCredito()
        Dim f As New frmCompraCredito
        f.xCodigoCliente = Cliente.CodigoCliente
        f.xCodigoFilialCliente = Cliente.CodigoFilialCliente
        f.xPacote = CInt(cbPacote.SelectedValue)

        creditoCliente.CodigoCliente = Cliente.CodigoCliente
        creditoCliente.CodigoFilialCliente = Cliente.CodigoFilialCliente
        creditoCliente.CodigoPacote = cbPacote.SelectedValue
        creditoCliente.RetornaCodigoCredito()
        f.xCodigoCredito = creditoCliente.CodigoCredito
        f.ShowDialog()
    End Sub

    Private Sub btnImprimirPacote_Click(sender As Object, e As EventArgs) Handles btnImprimirPacote.Click
        If grdPacote.Rows.Count > 0 Then
            Dim relatorioPacote As New relReciboPacote()
            Dim impressaoPacote As New ReportPrintTool(relatorioPacote)

            relatorioPacote.Parameters("codigocliente").Value = Cliente.CodigoCliente
            relatorioPacote.Parameters("codigofilial").Value = Cliente.CodigoFilialCliente
            relatorioPacote.Parameters("codigopacote").Value = cbPacote.SelectedValue

            relatorioPacote.Parameters("codigocliente").Visible = False
            relatorioPacote.Parameters("codigofilial").Visible = False
            relatorioPacote.Parameters("codigopacote").Visible = False

            'relatorioPacote.ShowPreviewDialog()
            relatorioPacote.ShowRibbonPreview
        Else
            Geral.TelaAviso("Pacote sem item cadastrado para impressão", "INFORMAÇÃO", Me, Belemtech.TipoAviso.OK, Belemtech.ImagemAviso.Informacao)
        End If
    End Sub

    Private Sub tbPacoteDesconto_Enter(sender As Object, e As EventArgs) Handles tbPacoteDesconto.Enter
        If Cliente.CodigoCliente > 0 Then
            PacoteCli = New PacoteClienteDetalhes()
            ServicoCli = New Servicos()
            CarregaPacote()
            CarregaServicos()
            EntraAbaPacote()
        End If

    End Sub

    Private Sub EntraAbaPacote()
        Geral.TipoReg = Belemtech.TiposReg.EntrarPacote
        Util.AcaoBotoesNormal(tbPacoteDesconto, Belemtech.TiposReg.EntrarPacote)
        Util.LimpaTextBox(grpDetalhes)
        Util.DesativaControles(tbPacoteDesconto)
        LimpaLabel()
        cbPacote.Enabled = True
        cbPacote.SelectedIndex = -1
        grdPacote.Columns.Clear()
        grdPacote.DataSource = Nothing
    End Sub

    Private Sub CarregaPacote()
        Dim listaPacote As New List(Of PacoteCliente)
        listaPacote = PacoteCli.RetornaPacote(Cliente.CodigoCliente)

        cbPacote.DataSource = listaPacote
        cbPacote.DisplayMember = "CodigoPacote"
        cbPacote.ValueMember = "CodigoPacote"
        cbPacote.SelectedValue = PacoteCli.CodigoPacote
        cbPacote.Enabled = True
    End Sub

    Private Sub CarregaServicos()
        Dim listaSurfacagem As New List(Of Servicos)
        listaSurfacagem = ServicoCli.RetornaServicos(1)

        cbSurfacagem.DataSource = listaSurfacagem
        cbSurfacagem.DisplayMember = "ProdutoDescricao"
        cbSurfacagem.ValueMember = "CodigoProduto"
        cbSurfacagem.SelectedIndex = -1

        Dim listaMontagem As New List(Of Servicos)
        listaMontagem = ServicoCli.RetornaServicos(2)

        cbMontagem.DataSource = listaMontagem
        cbMontagem.DisplayMember = "ProdutoDescricao"
        cbMontagem.ValueMember = "CodigoProduto"
        cbMontagem.SelectedIndex = -1

        Dim listaTratamento As New List(Of Servicos)
        listaTratamento = ServicoCli.RetornaServicos(4)

        cbTratamento.DataSource = listaTratamento
        cbTratamento.DisplayMember = "ProdutoDescricao"
        cbTratamento.ValueMember = "CodigoProduto"
        cbTratamento.SelectedIndex = -1
    End Sub

    Private Sub txtCodigoProduto_Leave(sender As Object, e As EventArgs) Handles txtCodigoProduto.Leave
        If txtCodigoProduto.Text <> String.Empty Then
            LenteTabela = New Lentes()
            LenteTabela.RetornaCodigoTabela(Convert.ToInt64(txtCodigoProduto.Text))
            txtNomeProduto.Text = LenteTabela.NomeProduto
            lblPrecoTabela.Text = Geral.FormataMoeda(LenteTabela.PrecoVenda)
        Else
            Geral.TelaAviso("Por favor, informar a lente!", "INFORMAÇÃO", Me, Belemtech.TipoAviso.OK, Belemtech.ImagemAviso.Advertencia)
            txtCodigoProduto.Select()
        End If
    End Sub

    Private Sub txtQtdePeca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQtdePeca.KeyPress
        If Not Char.IsControl(e.KeyChar) And Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            Geral.TelaAviso("Informar somente valor númerico inteiro!", "INFORMAÇÃO", Me, Belemtech.TipoAviso.OK, Belemtech.ImagemAviso.Advertencia)
        End If
    End Sub

    Private Sub txtDesconto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDesconto.KeyPress
        If Not Char.IsControl(e.KeyChar) And Not Char.IsDigit(e.KeyChar) And e.KeyChar <> "," Then
            e.Handled = True
            Geral.TelaAviso("Por favor informar o valor do desconto!", "INFORMAÇÃO", Me, Belemtech.TipoAviso.OK, Belemtech.ImagemAviso.Advertencia)
        End If
    End Sub

    Private Sub txtDesconto_Leave(sender As Object, e As EventArgs) Handles txtDesconto.Leave
        If txtDesconto.Text <> String.Empty Then
            Call txtCodigoProduto_Leave(Me, e)
            PrecoFinalProduto()
        Else
            Geral.TelaAviso("Por favor informar o valor do desconto!", "INFORMAÇÃO", Me, Belemtech.TipoAviso.OK, Belemtech.ImagemAviso.Advertencia)
            lblPrecoProdDesc.Text = ""
            lblTotalProduto.Text = ""
            txtDesconto.Text = "0,00"
            txtDesconto.Select()
        End If
    End Sub

    Private Sub AcaoConcluido()
        btnNovoPacote.Enabled = False
        btnExcluirPacote.Enabled = True
        btnConcluirPacote.Enabled = True
        btnImprimirPacote.Enabled = True
        btnCancelarPacote.Enabled = False

        btnAddItemProduto.Enabled = False
        btnExcluirItemProduto.Enabled = False
        btnAddItemSurfacagem.Enabled = False
        btnExcluirItemSurfacagem.Enabled = False
        btnAddItemMontagem.Enabled = False
        btnExcluirItemMontagem.Enabled = False
        btnAddItemTratamento.Enabled = False
        btnExcluirItemTratamento.Enabled = False

        Util.DesativaControles(grpDetalhes)
    End Sub

    Private Sub cbSurfacagem_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbSurfacagem.SelectionChangeCommitted
        ServicoCli.RetornaValorProdutoServico(cbSurfacagem.SelectedValue)
        lblPrecoSuf.Text = Geral.FormataMoeda(ServicoCli.PrecoTabela)
    End Sub

    Private Sub txtDescSurf_Leave(sender As Object, e As EventArgs) Handles txtDescSurf.Leave
        If txtDescSurf.Text <> String.Empty Then
            PrecoFinalSurfacagem()
        Else
            Geral.TelaAviso("Por favor informar o valor do desconto!", "INFORMAÇÃO", Me, Belemtech.TipoAviso.OK, Belemtech.ImagemAviso.Advertencia)
            lblPrecoDescSurf.Text = ""
            lblTotalSurfacagem.Text = ""
            txtDescSurf.Text = "0,00"
            txtDescSurf.Select()
        End If
    End Sub

    Private Sub txtQtdeSurf_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQtdeSurf.KeyPress
        If Not Char.IsControl(e.KeyChar) And Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            Geral.TelaAviso("Informar somente valor númerico inteiro!", "INFORMAÇÃO", Me, Belemtech.TipoAviso.OK, Belemtech.ImagemAviso.Advertencia)
        End If
    End Sub

    Private Sub txtDescSurf_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescSurf.KeyPress
        If Not Char.IsControl(e.KeyChar) And Not Char.IsDigit(e.KeyChar) And e.KeyChar <> "," Then
            e.Handled = True
            Geral.TelaAviso("Informar somente valor númerico inteiro!", "INFORMAÇÃO", Me, Belemtech.TipoAviso.OK, Belemtech.ImagemAviso.Advertencia)
            txtDescSurf.Select()
        End If
    End Sub

    Private Sub cbMontagem_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbMontagem.SelectionChangeCommitted
        ServicoCli.RetornaValorProdutoServico(cbMontagem.SelectedValue)
        lblPrecoMont.Text = Geral.FormataMoeda(ServicoCli.PrecoTabela)
    End Sub

    Private Sub txtQuantMont_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQtdeMont.KeyPress
        If Not Char.IsControl(e.KeyChar) And Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            Geral.TelaAviso("Informar somente valor númerico inteiro!", "INFORMAÇÃO", Me, Belemtech.TipoAviso.OK, Belemtech.ImagemAviso.Advertencia)
        End If
    End Sub

    Private Sub txtDescMont_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescMont.KeyPress
        If Not Char.IsControl(e.KeyChar) And Not Char.IsDigit(e.KeyChar) And e.KeyChar <> "," Then
            e.Handled = True
            Geral.TelaAviso("Informar somente valor númerico inteiro!", "INFORMAÇÃO", Me, Belemtech.TipoAviso.OK, Belemtech.ImagemAviso.Advertencia)
            txtDescSurf.Select()
        End If
    End Sub

    Private Sub txtDescMont_Leave(sender As Object, e As EventArgs) Handles txtDescMont.Leave
        If txtDescMont.Text <> String.Empty Then
            PrecoFinalMontagem()
        Else
            Geral.TelaAviso("Por favor informar o valor do desconto!", "INFORMAÇÃO", Me, Belemtech.TipoAviso.OK, Belemtech.ImagemAviso.Advertencia)
            lblPrecoDescMont.Text = ""
            lblTotalMontagem.Text = ""
            txtDescMont.Text = "0,00"
            txtDescMont.Select()
        End If
    End Sub

    Private Sub cbTratamento_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbTratamento.SelectionChangeCommitted
        ServicoCli.RetornaValorProdutoServico(cbTratamento.SelectedValue)
        lblPrecoTrat.Text = Geral.FormataMoeda(ServicoCli.PrecoTabela)
    End Sub

    Private Sub txtQuantTrat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQtdeTrat.KeyPress
        If Not Char.IsControl(e.KeyChar) And Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            Geral.TelaAviso("Informar somente valor númerico inteiro!", "INFORMAÇÃO", Me, Belemtech.TipoAviso.OK, Belemtech.ImagemAviso.Advertencia)
        End If
    End Sub

    Private Sub txtDescTrat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescTrat.KeyPress
        If Not Char.IsControl(e.KeyChar) And Not Char.IsDigit(e.KeyChar) And e.KeyChar <> "," Then
            e.Handled = True
            Geral.TelaAviso("Informar somente valor númerico inteiro!", "INFORMAÇÃO", Me, Belemtech.TipoAviso.OK, Belemtech.ImagemAviso.Advertencia)
            txtDescTrat.Select()
        End If
    End Sub

    Private Sub txtDescTrat_Leave(sender As Object, e As EventArgs) Handles txtDescTrat.Leave
        If txtDescTrat.Text <> String.Empty Then
            PrecoFinalTratamento()
        Else
            Geral.TelaAviso("Por favor informar o valor do desconto!", "INFORMAÇÃO", Me, Belemtech.TipoAviso.OK, Belemtech.ImagemAviso.Advertencia)
            lblPrecoDescTrat.Text = ""
            lblTotalTratamento.Text = ""
            txtDescTrat.Text = "0,00"
            txtDescTrat.Select()
        End If
    End Sub

    Private Sub txtQtdePeca_Leave(sender As Object, e As EventArgs) Handles txtQtdePeca.Leave
        If txtQtdePeca.Text = String.Empty Then
            Geral.TelaAviso("Por favor, informar a quantidade!", "INFORMAÇÃO", Me, Belemtech.TipoAviso.OK, Belemtech.ImagemAviso.Advertencia)
            txtQtdePeca.Text = "0"
            txtQtdePeca.Select()
        End If
    End Sub

    Private Sub txtQtdeSurf_Leave(sender As Object, e As EventArgs) Handles txtQtdeSurf.Leave
        If txtQtdeSurf.Text = String.Empty Then
            Geral.TelaAviso("Por favor, informar a quantidade!", "INFORMAÇÃO", Me, Belemtech.TipoAviso.OK, Belemtech.ImagemAviso.Advertencia)
            txtQtdeSurf.Text = "0"
            txtQtdeSurf.Select()
        End If
    End Sub

    Private Sub txtQuantMont_Leave(sender As Object, e As EventArgs) Handles txtQtdeMont.Leave
        If txtQtdeMont.Text = String.Empty Then
            Geral.TelaAviso("Por favor, informar a quantidade!", "INFORMAÇÃO", Me, Belemtech.TipoAviso.OK, Belemtech.ImagemAviso.Advertencia)
            txtQtdeMont.Text = "0"
            txtQtdeMont.Select()
        End If
    End Sub

    Private Sub txtQuantTrat_Leave(sender As Object, e As EventArgs) Handles txtQtdeTrat.Leave
        If txtQtdeTrat.Text = String.Empty Then
            Geral.TelaAviso("Por favor, informar a quantidade!", "INFORMAÇÃO", Me, Belemtech.TipoAviso.OK, Belemtech.ImagemAviso.Advertencia)
            txtQtdeTrat.Text = "0"
            txtQtdeTrat.Select()
        End If
    End Sub

    Private Sub MontaGridPacote()
        grdPacote.Columns.Clear()
        grdPacote.DataSource = Nothing

        grdPacote.AutoGenerateColumns = False
        grdPacote.AllowUserToAddRows = False
        grdPacote.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        Dim selecionar As New DataGridViewCheckBoxColumn 'Posição da coluna 0
        selecionar.HeaderText = "Sel."
        selecionar.Width = "50"
        grdPacote.Columns.Add(selecionar)

        Dim item As New DataGridViewTextBoxColumn 'Posição da coluna 1
        item.DataPropertyName = "item"
        item.HeaderText = "Item"
        item.Width = "40"
        item.ReadOnly = True
        grdPacote.Columns.Add(item)

        Dim cod_tab As New DataGridViewTextBoxColumn 'Posição da coluna 2
        cod_tab.DataPropertyName = "cod_produto"
        cod_tab.HeaderText = "Cod Produto"
        cod_tab.Width = 90
        cod_tab.ReadOnly = True
        grdPacote.Columns.Add(cod_tab)

        Dim cnc As New DataGridViewTextBoxColumn 'Posição da coluna 3
        cnc.DataPropertyName = "descricao_prod"
        cnc.HeaderText = "Produto"
        cnc.Width = 200
        cnc.ReadOnly = True
        grdPacote.Columns.Add(cnc)

        Dim cPreco As New DataGridViewTextBoxColumn 'Posição da coluna 4
        cPreco.DataPropertyName = "preco_produto"
        cPreco.HeaderText = "P. Produto"
        cPreco.Width = 60
        cPreco.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        cPreco.DefaultCellStyle.Format = "#,##0.00"
        cPreco.ReadOnly = True
        grdPacote.Columns.Add(cPreco)

        Dim cdesc As New DataGridViewTextBoxColumn 'Posição da coluna 5
        cdesc.DataPropertyName = "desconto_produto"
        cdesc.HeaderText = "Produto Desc(%)"
        cdesc.Width = 50
        cdesc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        cdesc.ReadOnly = True
        grdPacote.Columns.Add(cdesc)

        Dim cpQuant As New DataGridViewTextBoxColumn 'Posição da coluna 6
        cpQuant.DataPropertyName = "qtde_produto"
        cpQuant.HeaderText = "Qtde Prod Contrada"
        cpQuant.Width = 85
        cpQuant.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        cpQuant.ReadOnly = True
        grdPacote.Columns.Add(cpQuant)

        Dim cpdesc As New DataGridViewTextBoxColumn 'Posição da coluna 7
        cpdesc.DataPropertyName = "preco_final_produto"
        cpdesc.HeaderText = "Preço Pago"
        cpdesc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        cpdesc.DefaultCellStyle.Format = "#,##0.00"
        cpdesc.Width = 80
        cpdesc.ReadOnly = True
        grdPacote.Columns.Add(cpdesc)

        Dim cpSaldo As New DataGridViewTextBoxColumn 'Posição da coluna 8
        cpSaldo.DataPropertyName = "saldo"
        cpSaldo.HeaderText = "Saldo Produto"
        cpSaldo.Width = 85
        cpSaldo.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        cpSaldo.ReadOnly = True
        grdPacote.Columns.Add(cpSaldo)

        Dim Status As New DataGridViewTextBoxColumn 'Posição da coluna 9
        Status.DataPropertyName = "status_item"
        Status.HeaderText = "Status Item"
        Status.Width = "100"
        Status.ReadOnly = True
        grdPacote.Columns.Add(Status)

        Dim tiposerv As New DataGridViewTextBoxColumn 'Posição da coluna 10
        tiposerv.DataPropertyName = "tipo"
        tiposerv.HeaderText = "Tipo"
        tiposerv.Width = "50"
        tiposerv.Visible = False
        grdPacote.Columns.Add(tiposerv)

        Dim tb_pacote_det As New DataTable
        tb_pacote_det = Cliente.FiltraPacoteCliente(Cliente.CodigoCliente, Cliente.CodigoFilialCliente, cbPacote.SelectedValue)

        If tb_pacote_det.Rows.Count > 0 Then
            grdPacote.DataSource = tb_pacote_det

            For Each linha As DataGridViewRow In grdPacote.Rows
                If linha.Cells(9).Value = "B" Then
                    linha.Cells(0).Value = True
                End If
            Next
        End If

        PacoteCli.CodigoCliente = Cliente.CodigoCliente
        PacoteCli.CodigoFilialCliente = Cliente.CodigoFilialCliente
        PacoteCli.CodigoPacote = cbPacote.SelectedValue
        lblTotalPacote.Text = Geral.FormataMoeda(PacoteCli.CalculaPrecoFinalPacote())
    End Sub

    Private Sub grdPacote_DoubleClick(sender As Object, e As EventArgs) Handles grdPacote.DoubleClick
        Geral.TipoReg = Belemtech.TiposReg.Alterar

        If (grdPacote.CurrentRow.Cells(0).Value = True) And (grdPacote.CurrentRow.Cells(9).Value = "B") Then
            grdPacote.CurrentRow.Cells(0).ReadOnly = True
        End If

        If PacoteCli.Concluido = "N" Then
            Util.AtivaControles(tbPacoteDesconto)
        End If

        Dim xItem As Integer = grdPacote.CurrentRow.Cells(1).Value

        PacoteCli.RetornaDadosItemPacote(Cliente.CodigoCliente, Cliente.CodigoFilialCliente, cbPacote.SelectedValue, xItem)

        If PacoteCli.TipoServico = "P" Then
            txtCodigoProduto.Text = PacoteCli.CodigoProduto
            Call txtCodigoProduto_Leave(Me, e)
            lblPrecoTabela.Text = Geral.FormataMoeda(PacoteCli.PrecoProduto)
            txtQtdePeca.Text = PacoteCli.QtdeProduto
            txtDesconto.Text = Geral.FormataMoeda(PacoteCli.DescontoProduto)
            lblPrecoProdDesc.Text = Geral.FormataMoeda(PacoteCli.PrecoFinalProduto)
            lblTotalProduto.Text = Geral.Multiplicacao(PacoteCli.QtdeProduto, PacoteCli.PrecoFinalProduto)

            PacoteCli.CodigoCliente = Cliente.CodigoCliente
            PacoteCli.CodigoFilialCliente = Cliente.CodigoFilialCliente
            PacoteCli.CodigoPacote = cbPacote.SelectedValue
            lblTotalPacote.Text = Geral.FormataMoeda(PacoteCli.CalculaPrecoFinalPacote())

            If PacoteCli.Concluido = "N" Then
                btnAddItemProduto.Enabled = True
                btnExcluirItemProduto.Enabled = True
                btnAddItemSurfacagem.Enabled = False
                btnExcluirItemSurfacagem.Enabled = False
                btnAddItemMontagem.Enabled = False
                btnExcluirItemMontagem.Enabled = False
                btnAddItemTratamento.Enabled = False
                btnExcluirItemTratamento.Enabled = False
            End If
        End If

        If PacoteCli.TipoServico = "S" Then
            cbSurfacagem.SelectedValue = PacoteCli.CodigoProduto
            lblPrecoSuf.Text = Geral.FormataMoeda(PacoteCli.PrecoProduto)
            txtQtdeSurf.Text = PacoteCli.QtdeProduto
            txtDescSurf.Text = Geral.FormataMoeda(PacoteCli.DescontoProduto)
            lblPrecoDescSurf.Text = Geral.FormataMoeda(PacoteCli.PrecoFinalProduto)
            lblTotalSurfacagem.Text = Geral.Multiplicacao(PacoteCli.QtdeProduto, PacoteCli.PrecoFinalProduto)

            PacoteCli.CodigoCliente = Cliente.CodigoCliente
            PacoteCli.CodigoFilialCliente = Cliente.CodigoFilialCliente
            PacoteCli.CodigoPacote = cbPacote.SelectedValue
            lblTotalPacote.Text = Geral.FormataMoeda(PacoteCli.CalculaPrecoFinalPacote())

            If PacoteCli.Concluido = "N" Then
                btnAddItemProduto.Enabled = False
                btnExcluirItemProduto.Enabled = False
                btnAddItemSurfacagem.Enabled = True
                btnExcluirItemSurfacagem.Enabled = True
                btnAddItemMontagem.Enabled = False
                btnExcluirItemMontagem.Enabled = False
                btnAddItemTratamento.Enabled = False
                btnExcluirItemTratamento.Enabled = False
            End If
        End If

        If PacoteCli.TipoServico = "M" Then
            cbMontagem.SelectedValue = PacoteCli.CodigoProduto
            lblPrecoMont.Text = Geral.FormataMoeda(PacoteCli.PrecoProduto)
            txtQtdeMont.Text = PacoteCli.QtdeProduto
            txtDescMont.Text = Geral.FormataMoeda(PacoteCli.DescontoProduto)
            lblPrecoDescMont.Text = Geral.FormataMoeda(PacoteCli.PrecoFinalProduto)
            lblTotalMontagem.Text = Geral.Multiplicacao(PacoteCli.QtdeProduto, PacoteCli.PrecoFinalProduto)

            PacoteCli.CodigoCliente = Cliente.CodigoCliente
            PacoteCli.CodigoFilialCliente = Cliente.CodigoFilialCliente
            PacoteCli.CodigoPacote = cbPacote.SelectedValue
            lblTotalPacote.Text = Geral.FormataMoeda(PacoteCli.CalculaPrecoFinalPacote())

            If PacoteCli.Concluido = "N" Then
                btnAddItemProduto.Enabled = False
                btnExcluirItemProduto.Enabled = False
                btnAddItemSurfacagem.Enabled = False
                btnExcluirItemSurfacagem.Enabled = False
                btnAddItemMontagem.Enabled = True
                btnExcluirItemMontagem.Enabled = True
                btnAddItemTratamento.Enabled = False
                btnExcluirItemTratamento.Enabled = False
            End If
        End If

        If PacoteCli.TipoServico = "T" Then
            cbTratamento.SelectedValue = PacoteCli.CodigoProduto
            lblPrecoTrat.Text = Geral.FormataMoeda(PacoteCli.PrecoProduto)
            txtQtdeTrat.Text = PacoteCli.QtdeProduto
            txtDescTrat.Text = Geral.FormataMoeda(PacoteCli.DescontoProduto)
            lblPrecoDescTrat.Text = Geral.FormataMoeda(PacoteCli.PrecoFinalProduto)
            lblTotalTratamento.Text = Geral.Multiplicacao(PacoteCli.QtdeProduto, PacoteCli.PrecoFinalProduto)

            PacoteCli.CodigoCliente = Cliente.CodigoCliente
            PacoteCli.CodigoFilialCliente = Cliente.CodigoFilialCliente
            PacoteCli.CodigoPacote = cbPacote.SelectedValue
            lblTotalPacote.Text = Geral.FormataMoeda(PacoteCli.CalculaPrecoFinalPacote())

            If PacoteCli.Concluido = "N" Then
                btnAddItemProduto.Enabled = False
                btnExcluirItemProduto.Enabled = False
                btnAddItemSurfacagem.Enabled = False
                btnExcluirItemSurfacagem.Enabled = False
                btnAddItemMontagem.Enabled = False
                btnExcluirItemMontagem.Enabled = False
                btnAddItemTratamento.Enabled = True
                btnExcluirItemTratamento.Enabled = True
            End If
        End If

    End Sub

    Private Sub grdPacote_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles grdPacote.CellFormatting
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

    Private Sub grdPacote_KeyDown(sender As Object, e As KeyEventArgs) Handles grdPacote.KeyDown
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

    Private Sub TransferirItensDePacoteToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TransferirItensDePacoteToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles TransferirItensDePacoteToolStripMenuItem.Click
        If Usu.VerificaPermissaoUsuario(54) = True Then
            If MessageBox.Show("Deseja transferir o(s) item(ens) selecionado para um novo pacote?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim intPacote As Integer
                Dim intCodTabela As String
                intPacote = cbPacote.SelectedValue
                PacoteCli.Novo()
                PacoteCli.CodigoFilialCliente = Cliente.CodigoFilialCliente
                PacoteCli.CodigoCliente = Cliente.CodigoCliente
                PacoteCli.SalvaPacote()
                Dim strSQLExcluiPacote As String = ""

                Dim Conexao As New ConexaoDB

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
                                strSQLExcluiPacote = "delete from pacote_cliente where cod_pacote = " & PacoteCli.CodigoPacote & " and cod_cliente = " & PacoteCli.CodigoCliente
                                MessageBox.Show("Informe o novo código do produto.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Conexao.SalvaAtualizaExcluiReg(strSQLExcluiPacote)
                                Exit Sub
                            End If
                            strSQL = "Insert into pacote_cliente_detalhes (cod_pacote,item,cod_tabela,cod_filial_cliente,cod_cliente,desconto" &
                            ",quantidade_contratada,cod_surf,desc_surf,cod_mont,desc_mont,cod_trat,desc_trat,preco_tabela,preco_desc, " &
                            "preco_tabela_surf,preco_surf_desc,quantidade_surf,preco_tabela_mont,preco_mont_desc,quantidade_mont,preco_tabela_trat," &
                            "preco_trat_desc,quantidade_trat,status_item,cod_pacote_ant,cod_usuario) " &
                            "Values(" &
                            PacoteCli.CodigoPacote & "," & tb.Rows(0)("item") & "," & CInt(intCodTabela) & "," & tb.Rows(0)("cod_filial_cliente") & "," &
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
                            strSQLExcluiPacote = "delete from pacote_cliente where cod_pacote = " & PacoteCli.CodigoPacote & " and cod_cliente = " & PacoteCli.CodigoCliente
                            MessageBox.Show("Informe o novo código do produto.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Conexao.SalvaAtualizaExcluiReg(strSQLExcluiPacote)
                        End If
                    End If
                Next

                Dim strSQLPacote As String = "update pacote_cliente set concluido ='S' where cod_pacote = " & PacoteCli.CodigoPacote & " and cod_cliente = " & PacoteCli.CodigoCliente
                Conexao.SalvaAtualizaExcluiReg(strSQLPacote)
                'carrega_pacotes()
            End If
        Else
            MessageBox.Show("Usuário não tem permissão para transferir item de pacote!", "ERROR: 54", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub LimpaLabel()
        lblPrecoTabela.Text = "0,00"
        lblPrecoProdDesc.Text = "0,00"
        lblTotalProduto.Text = "0,00"
        lblPrecoSuf.Text = "0,00"
        lblPrecoMont.Text = "0,00"
        lblPrecoTrat.Text = "0,00"
        lblPrecoDescSurf.Text = "0,00"
        lblPrecoDescMont.Text = "0,00"
        lblPrecoDescTrat.Text = "0,00"
        lblTotalSurfacagem.Text = "0,00"
        lblTotalMontagem.Text = "0,00"
        lblTotalTratamento.Text = "0,00"
        lblTotalPacote.Text = "0,00"
    End Sub

    Private Sub PrecoFinalProduto()
        LenteTabela.PrecoTabela = Convert.ToDecimal(lblPrecoTabela.Text)
        LenteTabela.DescontoPacote = Convert.ToDecimal(txtDesconto.Text)
        LenteTabela.QuantidadePacote = Convert.ToInt32(txtQtdePeca.Text)
        LenteTabela.CalculaPrecoFinalItem()
        lblPrecoProdDesc.Text = Geral.FormataMoeda(LenteTabela.ValorComDesconto)
        lblTotalProduto.Text = Geral.FormataMoeda(LenteTabela.ValorTotalProduto)
        'LenteTabela.TotalProdutoPacote = LenteTabela.ValorTotalProduto
    End Sub

    Private Sub PrecoFinalSurfacagem()
        ServicoCli.PrecoTabela = Convert.ToDecimal(lblPrecoSuf.Text)
        ServicoCli.DescontoPacote = Convert.ToDecimal(txtDescSurf.Text)
        ServicoCli.QuantidadePacote = Convert.ToInt32(txtQtdeSurf.Text)
        ServicoCli.CalculaPrecoFinalItemPacote()
        lblPrecoDescSurf.Text = Geral.FormataMoeda(ServicoCli.ValorComDesconto)
        lblTotalSurfacagem.Text = Geral.FormataMoeda(ServicoCli.ValorTotalProduto)
        ServicoCli.TotalSurfacagem = ServicoCli.ValorTotalProduto
    End Sub

    Private Sub PrecoFinalMontagem()
        ServicoCli.PrecoTabela = Convert.ToDecimal(lblPrecoMont.Text)
        ServicoCli.DescontoPacote = Convert.ToDecimal(txtDescMont.Text)
        ServicoCli.QuantidadePacote = Convert.ToInt32(txtQtdeMont.Text)
        ServicoCli.CalculaPrecoFinalItemPacote()
        lblPrecoDescMont.Text = Geral.FormataMoeda(ServicoCli.ValorComDesconto)
        lblTotalMontagem.Text = Geral.FormataMoeda(ServicoCli.ValorTotalProduto)
        ServicoCli.TotalMontagem = ServicoCli.ValorTotalProduto
    End Sub

    Private Sub PrecoFinalTratamento()
        ServicoCli.PrecoTabela = Convert.ToDecimal(lblPrecoTrat.Text)
        ServicoCli.DescontoPacote = Convert.ToDecimal(txtDescTrat.Text)
        ServicoCli.QuantidadePacote = Convert.ToInt32(txtQtdeTrat.Text)
        ServicoCli.CalculaPrecoFinalItemPacote()
        lblPrecoDescTrat.Text = Geral.FormataMoeda(ServicoCli.ValorComDesconto)
        lblTotalTratamento.Text = Geral.FormataMoeda(ServicoCli.ValorTotalProduto)
        ServicoCli.TotalTratamento = ServicoCli.ValorTotalProduto
    End Sub

    Private Sub cbPacote_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbPacote.SelectionChangeCommitted
        Util.AcaoBotoesNormal(tbPacoteDesconto, Belemtech.TiposReg.Alterar)
        Util.AcaoAnterior = Belemtech.TiposReg.Alterar

        Util.LimpaTextBox(grpDetalhes)
        Util.AtivaControles(grpDetalhes)
        LimpaLabel()

        MontaGridPacote()

        PacoteCli.RetornaDadosPacote()

        If PacoteCli.Concluido = "S" Then
            AcaoConcluido()
        End If
    End Sub

    Private Sub btnAdicionarItemProduto_Click(sender As Object, e As EventArgs) Handles btnAddItemProduto.Click
        PacoteCli.CodigoPacote = cbPacote.SelectedValue
        PacoteCli.CodigoCliente = Cliente.CodigoCliente
        PacoteCli.CodigoFilialCliente = Cliente.CodigoFilialCliente

        PacoteCli.CodigoProduto = Convert.ToInt32(txtCodigoProduto.Text)
        PacoteCli.PrecoProduto = Convert.ToDecimal(lblPrecoTabela.Text)
        PacoteCli.DescontoProduto = Convert.ToDecimal(txtDesconto.Text)
        PacoteCli.PrecoFinalProduto = Convert.ToDecimal(lblPrecoProdDesc.Text)
        PacoteCli.QtdeProduto = Convert.ToInt32(txtQtdePeca.Text)

        PacoteCli.StatusItem = "P"

        If PacoteCli.VerificaCampoObrigatorio() = True Then
            Geral.TelaAviso(PacoteCli.MensagemRetorno, "ERROR", Me, Belemtech.TipoAviso.OK, Belemtech.ImagemAviso.Error)
            Exit Sub
        End If

        PacoteCli.TipoServico = "P"

        If Geral.TelaAviso("Deseja salvar o item no pacote?", "INFORMAÇÃO", Me, Belemtech.TipoAviso.SIMNAO, Belemtech.ImagemAviso.Informacao) = Belemtech.Respo.SIM Then
            If Geral.TipoReg <> Belemtech.TiposReg.Alterar Then
                PacoteCli.SalvarItemPacote()
            Else
                PacoteCli.ItemPacote = grdPacote.CurrentRow.Cells(22).Value.ToString()
                PacoteCli.AtualizaItemPacote()
            End If
            MontaGridPacote()
        End If
    End Sub

    Private Sub btnExcluirItemProduto_Click(sender As Object, e As EventArgs) Handles btnExcluirItemProduto.Click

    End Sub

    Private Sub btnAddItemSurfacagem_Click(sender As Object, e As EventArgs) Handles btnAddItemSurfacagem.Click
        PacoteCli.CodigoPacote = cbPacote.SelectedValue
        PacoteCli.CodigoCliente = Cliente.CodigoCliente
        PacoteCli.CodigoFilialCliente = Cliente.CodigoFilialCliente

        PacoteCli.CodigoProduto = Convert.ToInt32(cbSurfacagem.SelectedValue)
        PacoteCli.PrecoProduto = Convert.ToDecimal(lblPrecoSuf.Text)
        PacoteCli.DescontoProduto = Convert.ToDecimal(txtDescSurf.Text)
        PacoteCli.PrecoFinalProduto = Convert.ToDecimal(lblPrecoDescSurf.Text)
        PacoteCli.QtdeProduto = Convert.ToInt32(txtQtdeSurf.Text)

        PacoteCli.StatusItem = "P"

        If PacoteCli.VerificaCampoObrigatorio() = True Then
            Geral.TelaAviso(PacoteCli.MensagemRetorno, "ERROR", Me, Belemtech.TipoAviso.OK, Belemtech.ImagemAviso.Error)
            Exit Sub
        End If

        PacoteCli.TipoServico = "S"

        If Geral.TelaAviso("Deseja salvar o item no pacote?", "INFORMAÇÃO", Me, Belemtech.TipoAviso.SIMNAO, Belemtech.ImagemAviso.Informacao) = Belemtech.Respo.SIM Then
            If Geral.TipoReg <> Belemtech.TiposReg.Alterar Then
                PacoteCli.SalvarItemPacote()
            Else
                PacoteCli.ItemPacote = grdPacote.CurrentRow.Cells(1).Value.ToString()
                PacoteCli.AtualizaItemPacote()
            End If
            MontaGridPacote()
        End If
    End Sub

    Private Sub btnExcluirItemSurfacagem_Click(sender As Object, e As EventArgs) Handles btnExcluirItemSurfacagem.Click

    End Sub

    Private Sub btnAddItemMontagem_Click(sender As Object, e As EventArgs) Handles btnAddItemMontagem.Click
        PacoteCli.CodigoPacote = cbPacote.SelectedValue
        PacoteCli.CodigoCliente = Cliente.CodigoCliente
        PacoteCli.CodigoFilialCliente = Cliente.CodigoFilialCliente

        PacoteCli.CodigoProduto = Convert.ToInt32(cbMontagem.SelectedValue)
        PacoteCli.PrecoProduto = Convert.ToDecimal(lblPrecoMont.Text)
        PacoteCli.DescontoProduto = Convert.ToDecimal(txtDescMont.Text)
        PacoteCli.PrecoFinalProduto = Convert.ToDecimal(lblPrecoDescMont.Text)
        PacoteCli.QtdeProduto = Convert.ToInt32(txtQtdeMont.Text)

        PacoteCli.StatusItem = "P"

        If PacoteCli.VerificaCampoObrigatorio() = True Then
            Geral.TelaAviso(PacoteCli.MensagemRetorno, "ERROR", Me, Belemtech.TipoAviso.OK, Belemtech.ImagemAviso.Error)
            Exit Sub
        End If

        PacoteCli.TipoServico = "M"

        If Geral.TelaAviso("Deseja salvar o item no pacote?", "INFORMAÇÃO", Me, Belemtech.TipoAviso.SIMNAO, Belemtech.ImagemAviso.Informacao) = Belemtech.Respo.SIM Then
            If Geral.TipoReg <> Belemtech.TiposReg.Alterar Then
                PacoteCli.SalvarItemPacote()
            Else
                PacoteCli.ItemPacote = grdPacote.CurrentRow.Cells(22).Value.ToString()
                PacoteCli.AtualizaItemPacote()
            End If
            MontaGridPacote()
        End If
    End Sub

    Private Sub btnExcluirItemMontagem_Click(sender As Object, e As EventArgs) Handles btnExcluirItemMontagem.Click

    End Sub

    Private Sub btnAddItemTratamento_Click(sender As Object, e As EventArgs) Handles btnAddItemTratamento.Click
        PacoteCli.CodigoPacote = cbPacote.SelectedValue
        PacoteCli.CodigoCliente = Cliente.CodigoCliente
        PacoteCli.CodigoFilialCliente = Cliente.CodigoFilialCliente

        PacoteCli.CodigoProduto = Convert.ToInt32(cbTratamento.SelectedValue)
        PacoteCli.PrecoProduto = Convert.ToDecimal(lblPrecoTrat.Text)
        PacoteCli.DescontoProduto = Convert.ToDecimal(txtDescTrat.Text)
        PacoteCli.PrecoFinalProduto = Convert.ToDecimal(lblPrecoDescTrat.Text)
        PacoteCli.QtdeProduto = Convert.ToInt32(txtQtdeTrat.Text)

        PacoteCli.StatusItem = "P"

        If PacoteCli.VerificaCampoObrigatorio() = True Then
            Geral.TelaAviso(PacoteCli.MensagemRetorno, "ERROR", Me, Belemtech.TipoAviso.OK, Belemtech.ImagemAviso.Error)
            Exit Sub
        End If

        PacoteCli.TipoServico = "T"

        If Geral.TelaAviso("Deseja salvar o item no pacote?", "INFORMAÇÃO", Me, Belemtech.TipoAviso.SIMNAO, Belemtech.ImagemAviso.Informacao) = Belemtech.Respo.SIM Then
            If Geral.TipoReg <> Belemtech.TiposReg.Alterar Then
                PacoteCli.SalvarItemPacote()
            Else
                PacoteCli.ItemPacote = grdPacote.CurrentRow.Cells(22).Value.ToString()
                PacoteCli.AtualizaItemPacote()
            End If
            MontaGridPacote()
        End If
    End Sub

    Private Sub btnExcluirItemTrtamento_Click(sender As Object, e As EventArgs) Handles btnExcluirItemTratamento.Click

    End Sub

    Private Sub btnCancelarPacote_Click(sender As Object, e As EventArgs) Handles btnCancelarPacote.Click
        Util.AcaoBotoesNormal(tbPacoteDesconto, Belemtech.TiposReg.Cancelar)
        cbPacote.Enabled = True
        Util.DesativaControles(grpDetalhes)
    End Sub

    Private Sub tabPedidos_Enter(sender As Object, e As EventArgs) Handles tabPedidos.Enter
        filtra_pedidos()
    End Sub

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

    Private Sub grdPedidos_CurrentCellChanged(sender As Object, e As EventArgs) Handles grdPedidos.CurrentCellChanged
        id_faturas = grdPedidos.CurrentRow.Index
    End Sub

    Private Sub grdPedidos_DoubleClick(sender As Object, e As EventArgs) Handles grdPedidos.DoubleClick
        Dim intContador As Integer = 0
        Dim fil_pedido As Integer
        Dim n_pedido As Integer
        Dim pedido As objPedidoBalcao = New objPedidoBalcao()
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

    Public Function restricoes_bloqueado() As Integer
        Dim tbRestricao As New DataTable
        Dim tbDiaTitulo As New DataTable
        Dim tbDiaAcordo As New DataTable
        Dim strDiaTitulo As String = "select data_vencimento from Titulos_aberto() where cod_cliente = " & Cliente.CodigoCliente &
            " and cod_filial_cliente = " & Cliente.CodigoFilialCliente & " and data_vencimento < GETDATE() and data_recebimento is null"
        Dim strDiaAcordo As String = "select data_vencimento  from Acordo_Aberto() where cod_cliente = " & Cliente.CodigoCliente &
            " and cod_filial_cliente = " & Cliente.CodigoFilialCliente & " and data_vencimento < GETDATE() and data_recebimento is null"
        tbRestricao = Cliente.ResumoReceberCliente(Cliente.CodigoCliente, Cliente.CodigoFilialCliente)

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
            ElseIf Cliente.ResumoReceberTotalCliente > Cliente.LimiteCredito Then
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

    Private Sub btnNovoPedido_Click(sender As Object, e As EventArgs) Handles btnNovoPedido.Click
        Dim intContador As Integer = 0
        Dim aut As Integer
        intUsuario = Usu.CodigoUsuario
        Dim intAcesso As Integer = Usu.VerificaPermissaoMenu(intUsuario)
        'aut = clientenovo.consulta_autorizacao
        Dim strSQL As String = "select * from pedido_autorizacao where cod_cliente = " & Cliente.CodigoCliente &
            " and cod_filial_cliente = " & Cliente.CodigoFilialCliente & " and num_pedido is null and id_filial_pedido is null"
        If Conexao.VerificaExistenciaReg(strSQL) = True Then
            aut = 1
            intContador = restricoes_bloqueado()
            GoTo Inicio
        End If

        If Cliente.CodigoTipoCliente <> 2 Then
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
                pedido.id_filial = Conf.Filial
                pedido.data_pedido = Now
                pedido.cod_vendedor = intUsuario
                pedido.autorizacao = aut
                pedido.cod_filial_cliente = Cliente.CodigoFilialCliente
                pedido.cod_cliente = Cliente.CodigoCliente

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
                        Dim strSQLAut As String = "update pedido_autorizacao set num_pedido = " & pedido.num_pedido & ", id_filial_pedido = " & Conf.Filial
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
            pedido.id_filial = Conf.Filial
            pedido.data_pedido = Now
            pedido.cod_vendedor = intUsuario
            pedido.autorizacao = aut
            pedido.cod_filial_cliente = Cliente.CodigoFilialCliente
            pedido.cod_cliente = Cliente.CodigoCliente
            pedido.Salvar()
            f._num_pedido = pedido.num_pedido
            f._id_filial = pedido.id_filial
            f.intTipoCliente = 2
            f.cbForma.Enabled = False
            f.ShowDialog()
            filtra_pedidos()
        End If

    End Sub

    Private Sub btnImprimirPedidos_Click(sender As Object, e As EventArgs) Handles btnImprimirPedidos.Click
        filtra_pedidos()
    End Sub

    Private Sub filtra_pedidos()
        titPedidos = "Pedidos do Cliente: " & txtNome.Text & ""
        If rbData.Checked = True Then
            tb_pedidos = Cliente.PedidoClienteFaturado(Cliente.CodigoCliente, Cliente.CodigoFilialCliente, dtPedidoIni.Value.Date,
            dtPedidoFim.Value)
            titPedidos = "Pedidos do Cliente: " & txtNome.Text & ". " & vbCrLf &
            " Período: entre " & dtPedidoIni.Value.Date &
            " e " & dtPedidoFim.Value.Date & ""
            formata_grid_pedidos()
        Else
            tb_pedidos = Cliente.PedidosClientes
            formata_grid_pedidos()
        End If
    End Sub

End Class