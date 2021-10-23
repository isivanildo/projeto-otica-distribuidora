Imports System.Collections.Generic
Imports MRUtil

Public Class frmEmitente
    Dim util As Geral = New Geral
    Dim emitente As Empresa = New Empresa()
    Dim cidade As Cidades
    Dim uf As Uf
    Dim Conn As New ConexaoDB()
    Dim Usuario As New Usuario

    Private Sub frmEmitente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        util.DesativaControles(Me)
        TabPane1.SelectedPage = tnEmitentes
        CarregaEmitentes()
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        Geral.TipoReg = Belemtech.TiposReg.Novo
        util.AtivaControles(Me)
        util.AcaoBotoes(tsMenus, Belemtech.TiposReg.Novo)
        TabPane1.SelectedPage = tnDadosCadastrais
        AtivaDesativaCamposEmpresa()
        txtCnpjCpf.Focus()
        CarregaCidades()
        CarregaUF()
        txtPais.Text = "1058"
        lblStatus.Text = "Modo de inclusão..."
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        Geral.TipoReg = Belemtech.TiposReg.Alterar
        util.AtivaControles(Me)
        util.AcaoBotoes(tsMenus, Belemtech.TiposReg.Alterar)
        txtCnpjCpf.Enabled = False
        lblStatus.Text = "Modo de Alteração..."

        Dim intIndex As DataGridViewRow = grdEmitente.CurrentRow
        emitente.CnpjCpf = grdEmitente.Rows(intIndex.Index).Cells(0).Value
        emitente.RetornaRegistro(emitente.CnpjCpf)
        txtCnpjCpf.Text = emitente.CnpjCpf
        txtFilial.Text = emitente.Filial
        txtRazaoSocial.Text = emitente.RazaoSocial
        txtFantasia.Text = emitente.NomeFantasia
        txtCep.Text = emitente.Cep
        txtEndereco.Text = emitente.Logradouro
        txtNumero.Text = emitente.Numero
        txtBairro.Text = emitente.Bairro
        cbCidade.SelectedValue = emitente.CidadeIBGE
        cbUF.SelectedValue = emitente.UfIBGE
        txtPais.Text = emitente.PaisIBGE
        txtTelefoneFixo.Text = emitente.TelefoneFixo
        txtCelular.Text = emitente.TelefoneCel
        txtEmail.Text = emitente.Email
        cbAtivo.Checked = emitente.Situacao
        txtIE.Text = emitente.InscricaoEstadual
        txtIM.Text = emitente.InscricaoMunicipal
        txtCRT.Text = emitente.CRT
        txtCnae.Text = emitente.CNAEFiscal
        txtSerie.Text = emitente.SerieNFe
        txtModelo.Text = emitente.ModeloNFe
        txtNumeroNF.Text = emitente.NumeroNFe
        txtZonaHoraria.Text = emitente.ZonaHoraria
        txtIESub.Text = emitente.IESubtitutoTributario
        txtCnpjAutXml.Text = emitente.CpfCnpjAutBaixaXml
        txtCertificado.Text = emitente.Certificado
        cbProducao.Checked = emitente.Producao
        txtInfoComplementar.Text = emitente.InformacaoCompelentar
        txtNomeImpressora.Text = emitente.Impressora

        AtivaDesativaCamposEmpresa() 'procedimento responsável por ativar e desativar os campos dos dados fiscais do sistema para a empresa

        txtIdentificaoEmpresa.Text = emitente.IdEmpresa
        txtidentificacaoNFe.Text = emitente.IdSistemaNFe
        txtIdentificacaoNFCe.Text = emitente.IdSistemaNFCe
        txtIdentificacaoCanNFe.Text = emitente.IdSistemaNFeCan
        txtIdentificacaoCanNFCe.Text = emitente.IdSistemaNFCeCan
        txtIdentificacaoCCe.Text = emitente.IdSistemaNFeCCe
        txtIdentificacaoInuNFe.Text = emitente.IdSistemaInutilizaNFe
        txtIdentificacaoCSC.Text = emitente.CodigoCSC

        TabPane1.SelectedPage = tnDadosCadastrais

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If Geral.TelaAviso("Deseja salvar ou alterar esta empresa?", "INFORMAÇÃO", Me, Belemtech.TipoAviso.SIMNAO, Belemtech.ImagemAviso.Informacao) = Belemtech.Respo.SIM Then
            emitente.CnpjCpf = txtCnpjCpf.Text
            emitente.Filial = Geral.FormataNumero(txtFilial.Text)
            emitente.RazaoSocial = txtRazaoSocial.Text.Trim
            emitente.NomeFantasia = txtFantasia.Text.Trim
            emitente.Cep = txtCep.Text.Trim
            emitente.Logradouro = txtEndereco.Text.Trim
            emitente.Numero = txtNumero.Text.Trim
            emitente.Complemento = txtComplemento.Text.Trim
            emitente.Bairro = txtBairro.Text.Trim
            emitente.CidadeIBGE = cbCidade.SelectedValue
            emitente.UfIBGE = cbUF.SelectedValue
            emitente.PaisIBGE = Geral.FormataNumero(txtPais.Text)
            emitente.TelefoneFixo = txtTelefoneFixo.Text.Trim
            emitente.TelefoneCel = txtCelular.Text.Trim
            emitente.InscricaoEstadual = txtIE.Text.Trim
            emitente.IESubtitutoTributario = txtIESub.Text.Trim
            emitente.InscricaoMunicipal = txtIM.Text.Trim
            emitente.CpfCnpjAutBaixaXml = txtCnpjAutXml.Text.Trim
            emitente.CRT = Geral.FormataNumero(txtCRT.Text)
            emitente.CNAEFiscal = Geral.FormataNumero(txtCnae.Text)
            emitente.SerieNFe = Geral.FormataNumero(txtSerie.Text)
            emitente.ModeloNFe = Geral.FormataNumero(txtModelo.Text)
            emitente.NumeroNFe = Geral.FormataNumero(txtNumeroNF.Text)
            emitente.Certificado = txtCertificado.Text.Trim
            If Not String.IsNullOrEmpty(txtLogo.Text) Then
                emitente.LogoTipo = txtLogo.Text
            End If

            emitente.Email = txtEmail.Text.Trim
            emitente.ZonaHoraria = txtZonaHoraria.Text.Trim
            emitente.Producao = cbProducao.Checked
            emitente.DataCadastro = DateTime.Now
            emitente.Situacao = cbAtivo.Checked
            emitente.InformacaoCompelentar = txtInfoComplementar.Text.Trim
            emitente.Impressora = txtNomeImpressora.Text.Trim
            emitente.IdEmpresa = txtIdentificaoEmpresa.Text.Trim.ToLower()
            emitente.IdSistemaNFe = txtidentificacaoNFe.Text.Trim.ToLower()
            emitente.IdSistemaNFCe = txtIdentificacaoNFCe.Text.Trim.ToLower()
            emitente.IdSistemaNFeCan = txtIdentificacaoCanNFe.Text.Trim.ToLower()
            emitente.IdSistemaNFCeCan = txtIdentificacaoCanNFCe.Text.Trim.ToLower()
            emitente.IdSistemaNFeCCe = txtIdentificacaoCCe.Text.Trim.ToLower()
            emitente.IdSistemaInutilizaNFe = txtIdentificacaoInuNFe.Text.Trim.ToLower()
            emitente.CodigoCSC = txtIdentificacaoCSC.Text.Trim

            If emitente.VerificaCampoObrigatorio() = True Then
                Exit Sub
            End If

            util.DesativaControles(Me)
            util.AcaoBotoes(tsMenus, Belemtech.TiposReg.Salvar)
            If Geral.TipoReg = Belemtech.TiposReg.Novo Then
                emitente.SalvaEmpresa()
            Else
                emitente.AtualizaEmpresa()
            End If
        End If

        lblStatus.Text = ""
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Geral.TipoReg = Belemtech.TiposReg.Excluir
        lblStatus.Text = "Modo de Exclusão..."

        If Conn.VerificaExistenciaReg("select 1 from nfe where emitente = " & emitente.CnpjCpf) = 1 Then
            Geral.TelaAviso("Não é possivel excluir registro quando houver documentos fiscais associados", "ERROR", Me, Belemtech.TipoAviso.OK, Belemtech.ImagemAviso.Error)
            Exit Sub
        End If

        If Geral.TelaAviso("Deseja excluir a empresa selecionada?", "INFORMAÇÃO", Me, Belemtech.TipoAviso.SIMNAO, Belemtech.ImagemAviso.Informacao) = Belemtech.Respo.SIM Then
            emitente.ExcluirEmpresa(emitente.CnpjCpf)
        End If

        util.DesativaControles(Me)
        util.AcaoBotoes(tsMenus, Belemtech.TiposReg.Excluir)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Geral.TipoReg = Belemtech.TiposReg.Cancelar
        util.DesativaControles(Me)
        util.AcaoBotoes(tsMenus, Belemtech.TiposReg.Cancelar)
        lblStatus.Text = ""
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub
    Private Sub frmEmitente_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub CarregaEmitentes()
        grdEmitente.Columns.Clear()
        grdEmitente.DataSource = Nothing
        grdEmitente.AutoGenerateColumns = False
        grdEmitente.AllowUserToAddRows = False
        grdEmitente.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        grdEmitente.ReadOnly = True

        Dim cnpj As New DataGridViewTextBoxColumn
        cnpj.HeaderText = "CNPJ/CPF"
        cnpj.DataPropertyName = "cnpj_cpf"
        cnpj.Width = 120
        grdEmitente.Columns.Add(cnpj)

        Dim filial As New DataGridViewTextBoxColumn
        filial.HeaderText = "Filial"
        filial.DataPropertyName = "filial"
        filial.Width = 40
        filial.DefaultCellStyle.Format = "00"
        filial.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grdEmitente.Columns.Add(filial)

        Dim razaosocial As New DataGridViewTextBoxColumn
        razaosocial.HeaderText = "Razão Social"
        razaosocial.DataPropertyName = "razao_social"
        razaosocial.Width = 300
        grdEmitente.Columns.Add(razaosocial)

        Dim fantasia As New DataGridViewTextBoxColumn
        fantasia.HeaderText = "Fantasia"
        fantasia.DataPropertyName = "nome_fantasia"
        fantasia.Width = 200
        grdEmitente.Columns.Add(fantasia)

        Dim ie As New DataGridViewTextBoxColumn
        ie.HeaderText = "I.E"
        ie.DataPropertyName = "i_estadual"
        grdEmitente.Columns.Add(ie)

        Dim strSQL As String = "select * from emitente"

        Dim tb As New DataTable()
        Conn.CarregaTabela(strSQL, tb)

        grdEmitente.DataSource = tb

    End Sub

    Private Sub grdEmitente_DoubleClick(sender As Object, e As EventArgs) Handles grdEmitente.DoubleClick
        Call btnAlterar_Click(sender, e)
    End Sub

    Private Sub AtivaDesativaCamposEmpresa()
        Usuario.RetornaRegistro(frmMain.intCodigoUsuario)
        If Usuario.Perfil = 1 Then
            txtIdentificaoEmpresa.Enabled = True
            txtidentificacaoNFe.Enabled = True
            txtIdentificacaoNFCe.Enabled = True
            txtIdentificacaoCanNFe.Enabled = True
            txtIdentificacaoCanNFCe.Enabled = True
            txtIdentificacaoCCe.Enabled = True
            txtIdentificacaoInuNFe.Enabled = True
            txtIdentificacaoCSC.Enabled = True
        Else
            txtIdentificaoEmpresa.Enabled = False
            txtidentificacaoNFe.Enabled = False
            txtIdentificacaoNFCe.Enabled = False
            txtIdentificacaoCanNFe.Enabled = False
            txtIdentificacaoCanNFCe.Enabled = False
            txtIdentificacaoCCe.Enabled = False
            txtIdentificacaoInuNFe.Enabled = False
            txtIdentificacaoCSC.Enabled = False
        End If
    End Sub

    Private Sub CarregaCidades()
        cidade = New Cidades()
        Dim lista As New List(Of Cidades)
        lista = cidade.RetornaCidade()

        cbCidade.DataSource = lista
        cbCidade.DisplayMember = "NomeCidade"
        cbCidade.ValueMember = "CodigoCidade"
        cbCidade.SelectedIndex = -1

    End Sub

    Private Sub CarregaUF()
        uf = New Uf()
        Dim lista As New List(Of Uf)

        lista = uf.RetornaEstado()

        cbUF.DataSource = lista
        cbUF.DisplayMember = "Estado"
        cbUF.ValueMember = "CodigoUF"
        cbUF.SelectedIndex = -1
    End Sub

End Class

