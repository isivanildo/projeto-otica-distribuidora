Imports System.IO
Imports mrotica_util
Imports MRUtil
Imports Vinco.iContNFe.NFeIntegratorInterOp
Imports Vinco.iContNFe.NFeIntegratorInterOp.Interface

Public Class frmNFeLista
    Dim emitente As New Empresa
    Dim op As New NaturezaOperacao
    Dim d As New ConexaoDB
    Dim oNFe As NFeIntegrator = New NFeIntegrator()

    Dim dadosNFe As New NFe
    Dim dadosNFeCCe As New NFe_CCe
    Dim dadosNFeInutilizada As New NFe_Inutilizada

    Dim dllInicializada As Boolean = False

    Dim emitenteCnpj As String
    Dim numeroDoc As Integer
    Dim codigoCliente As Integer
    Dim codigoFilial As Integer
    Dim modeloNF As Integer
    Dim serieNF As Integer
    Dim chaveNFe As String
    Dim situacaoNFe As String
    Dim codigoNatureza As Integer
    Dim justificativaCan As String

    Private Sub frmNFeLista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregaEmitente()
    End Sub

    Private Sub carregaEmitente()
        Dim d As New dados()
        Dim tabela As New DataTable
        Dim strSQL As String = "select cnpj_cpf, razao_social from emitente"
        d.carrega_Tabela(strSQL, tabela)
        cbEmitente.DisplayMember = "razao_social"
        cbEmitente.ValueMember = "cnpj_cpf"
        cbEmitente.DataSource = tabela
        cbEmitente.SelectedIndex = -1
    End Sub

    Private Sub MontaGridNFe()
        grdNFe.Columns.Clear()
        grdNFe.DataSource = Nothing
        grdNFe.AutoGenerateColumns = False
        grdNFe.AllowUserToAddRows = False
        grdNFe.ReadOnly = True

        Dim numero As New DataGridViewTextBoxColumn 'Posição 00
        numero.HeaderText = "Número"
        numero.DataPropertyName = "numero"
        numero.DefaultCellStyle.Format = "0000"
        numero.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        numero.Width = 60
        grdNFe.Columns.Add(numero)

        Dim operacao As New DataGridViewTextBoxColumn 'Posição 01
        operacao.HeaderText = "Nat. Operação"
        operacao.DataPropertyName = "descricao"
        operacao.Width = 170
        grdNFe.Columns.Add(operacao)

        Dim serie As New DataGridViewTextBoxColumn 'Posição 02
        serie.HeaderText = "Serie"
        serie.DataPropertyName = "serie"
        serie.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        serie.Width = 40
        grdNFe.Columns.Add(serie)

        Dim modelo As New DataGridViewTextBoxColumn 'Posição 03
        modelo.HeaderText = "Modelo"
        modelo.DataPropertyName = "modelo"
        modelo.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        modelo.Width = 50
        grdNFe.Columns.Add(modelo)

        Dim situacao1 As New DataGridViewTextBoxColumn 'Posição 04
        situacao1.HeaderText = "Tipo Nota"
        situacao1.Width = 80
        grdNFe.Columns.Add(situacao1)

        Dim dataemissao As New DataGridViewTextBoxColumn 'Posição 05
        dataemissao.HeaderText = "Data Emissão"
        dataemissao.DataPropertyName = "d_emissao"
        dataemissao.Width = 100
        dataemissao.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdNFe.Columns.Add(dataemissao)

        Dim cliente As New DataGridViewTextBoxColumn 'Posição 06
        cliente.HeaderText = "Cliente"
        cliente.DataPropertyName = "nome_cliente"
        cliente.Width = 280
        grdNFe.Columns.Add(cliente)

        Dim situacao As New DataGridViewTextBoxColumn 'Posição 07
        situacao.HeaderText = "Situação"
        situacao.DataPropertyName = "situacao"
        situacao.Width = 60
        situacao.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdNFe.Columns.Add(situacao)

        Dim valornota As New DataGridViewTextBoxColumn 'Posição 08
        valornota.HeaderText = "Valor Nota"
        valornota.DataPropertyName = "valornota"
        valornota.Width = 70
        valornota.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        valornota.SortMode = DataGridViewColumnSortMode.NotSortable
        valornota.DefaultCellStyle.Format = "#,##0.00"
        grdNFe.Columns.Add(valornota)

        Dim tiponfe As New DataGridViewTextBoxColumn 'Posição 09
        tiponfe.HeaderText = "Tipo NFe"
        tiponfe.DataPropertyName = "tiponfe"
        tiponfe.Width = 80
        tiponfe.Visible = False
        grdNFe.Columns.Add(tiponfe)

        Dim codcliente As New DataGridViewTextBoxColumn 'Posição 10
        codcliente.HeaderText = "Cliente"
        codcliente.DataPropertyName = "cliente"
        codcliente.Width = 80
        codcliente.Visible = False
        grdNFe.Columns.Add(codcliente)

        Dim filial As New DataGridViewTextBoxColumn 'Posição 11
        filial.HeaderText = "Filial"
        filial.DataPropertyName = "filial"
        filial.Width = 80
        filial.Visible = False
        grdNFe.Columns.Add(filial)

        Dim chaveNFe As New DataGridViewTextBoxColumn 'Posição 12
        chaveNFe.HeaderText = "Chave NFe"
        chaveNFe.DataPropertyName = "chavenfe"
        chaveNFe.Width = 80
        chaveNFe.Visible = False
        grdNFe.Columns.Add(chaveNFe)

        Dim justificativa As New DataGridViewTextBoxColumn 'Posição 13
        justificativa.HeaderText = "Justificativa"
        justificativa.DataPropertyName = "justificativa"
        justificativa.Width = 80
        justificativa.Visible = False
        grdNFe.Columns.Add(justificativa)

        Dim xmlAutorizada As New DataGridViewTextBoxColumn 'Posição 14
        xmlAutorizada.HeaderText = "XML Assinada"
        xmlAutorizada.DataPropertyName = "nfeassinadaxml"
        xmlAutorizada.Width = 80
        xmlAutorizada.Visible = False
        grdNFe.Columns.Add(xmlAutorizada)

        Dim codigonatureza As New DataGridViewTextBoxColumn 'Posição 15
        codigonatureza.HeaderText = "Cod Natrueza"
        codigonatureza.DataPropertyName = "codigonat"
        codigonatureza.Width = 80
        codigonatureza.Visible = False
        grdNFe.Columns.Add(codigonatureza)

        Dim strSQL As String = ""

        strSQL = "select nf.numero, nf.serie, nf.modelo, nf.tiponfe, nf.d_emissao, nf.cliente, " &
        "nf.situacao, nf.valornota, nat.descricao, c.nome_cliente, nf.filial, nf.chavenfe, nf.justificativa, nf.nfeassinadaxml, nat.codigonat " &
        "from nfe nf inner join " &
        "NaturezaOperacao nat on nf.natoperacao = nat.codigonat inner join cliente c " &
        "on nf.cliente = c.cod_cliente And nf.filial = c.cod_filial_cliente " &
        "where nf.emitente = " & Geral.AspasSQL(emitente.CnpjCpf) + " order by nf.numero desc"

        Dim tb As New DataTable()

        d.CarregaTabela(strSQL, tb)

        grdNFe.DataSource = tb
    End Sub


    Private Sub cbEmitente_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbEmitente.SelectionChangeCommitted
        If cbEmitente.SelectedIndex <> -1 Then
            emitente.RetornaRegistro(cbEmitente.SelectedValue)
            MontaGridNFe()
        End If
    End Sub

    Private Sub grdNFe_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles grdNFe.CellFormatting
        For Each linha As DataGridViewRow In grdNFe.Rows
            If linha.Cells(9).Value = 0 Then
                linha.Cells(4).Value = "ENTRADA"
            Else
                linha.Cells(4).Value = "SAIDA"
            End If
        Next
    End Sub

    Private Sub grdNFe_DoubleClick(sender As Object, e As EventArgs) Handles grdNFe.DoubleClick
        Dim f As New frmNFe
        f.emit = emitente.CnpjCpf
        f.numNota = grdNFe.CurrentRow.Cells(0).Value
        f.serieNota = grdNFe.CurrentRow.Cells(2).Value
        f.modeloNota = grdNFe.CurrentRow.Cells(3).Value
        f.nomeCliente = grdNFe.CurrentRow.Cells(6).Value
        f.codigoCliente = grdNFe.CurrentRow.Cells(11).Value
        f.TipoRegistro = "A"
        f.SituacaoNota = grdNFe.CurrentRow.Cells(7).Value
        f.ShowDialog()
        MontaGridNFe()
    End Sub

    Private Sub CancelaNota()
        Try
            Dim tpAmbiente, tpImpressao, tpFin, tpEmis As Integer
            mmRetornoCancelamento.Text = "Aguarde Cancelando..."
            'Verifica se a DLL foi nicializazda, em caso negativo a DLL será inicializada
            If dllInicializada = False Then
                InicializacaoPadraoNF()
            End If

            If rbNFe.Checked = True Then
                oNFe.SetIdKeySistema(emitente.IdSistemaNFeCan)
                tpImpressao = 1
            Else
                oNFe.SetIdKeySistema(emitente.IdSistemaNFCeCan)
                tpImpressao = 4
            End If


            If emitente.Producao = True Then
                tpAmbiente = 1
            Else
                tpAmbiente = 2
            End If

            op.RetornaRegistro(codigoNatureza)

            If op.FinalidadeNota = 1 Then
                tpFin = 1
            ElseIf op.FinalidadeNota = 2 Then
                tpFin = 2
            ElseIf op.FinalidadeNota = 3 Then
                tpFin = 3
            ElseIf op.FinalidadeNota = 4 Then
                tpFin = 4
            End If

            If emitente.WebService = "NORMAL" Then
                tpEmis = 1
            End If

            'Set de configurações de emissão: ambiente, impressão, finalidade, tipo de emisão
            oNFe.SetEnvironment(tpAmbiente, tpImpressao, tpFin, tpEmis)

            'Set do endereço no file system onde as NFe//s autorizadas serão armazenadas
            oNFe.EnderecoCancelada = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Cancelada")

            oNFe.ClearParams()

            'No exemplo utlizado, existe somente 1 filtro
            '- um com o numero da Nota Fiscal no sistema
            'Os filtros devem ser alimentados na mesma ordem que eles foram criados
            'no ConfigExtractor

            'Adiciona o valor no filtro
            oNFe.AddParams(emitenteCnpj) 'cnpjemitente
            oNFe.AddParams(numeroDoc) 'numeronfe
            oNFe.AddParams(serieNF) 'Serie
            oNFe.AddParams(modeloNF) 'modelo NF

            Dim retorno As IRetornoEvento = oNFe.CancelarPorEvento(txtJustificativaCan.Text)

            Dim erros As IErroXSD() = oNFe.GetErroXSD()

            If erros IsNot Nothing AndAlso erros.Length > 0 Then
                For i As Integer = 0 To erros.Length - 1
                    MessageBox.Show(erros(i).Descricao, erros(i).Titulo, MessageBoxButtons.OK, MessageBoxIcon.[Error])
                Next
            End If


            If retorno.cStat = 135 Then
                'Se o cStat for igual a 135 isso indica que a nota foi autorizada com sucesso
                'nesse momento podemos armazenar todos os dados no sistema
                'retorno.ChaveNFe -> Chave da NFe
                'retorno.DataRecebimento -> Data da Autorização
                'retorno.Protocolo -> numero do protocolo
                'retorno.XMLProc -> XML da NF-e com o protocolo de autorização
                'retorno.PDF -> Binario com o PDF
                dadosNFe.Emitente = emitente.CnpjCpf
                dadosNFe.NumeroDocFiscal = Convert.ToInt32(grdNFe.CurrentRow.Cells(0).Value)
                dadosNFe.Serie = Convert.ToInt32(grdNFe.CurrentRow.Cells(2).Value)
                dadosNFe.Modelo = Convert.ToInt32(grdNFe.CurrentRow.Cells(3).Value)

                dadosNFe.SituacaoNFe = "C"
                dadosNFe.Justificativa = txtJustificativaCan.Text
                dadosNFe.ProtocoloCancelamento = retorno.nProt
                dadosNFe.DataProtocoloCancelamento = retorno.dhRegEvento
                dadosNFe.NFeCanceladaXml = retorno.ProcEventoNFe
                dadosNFe.CanceladoUsuario = 1
                dadosNFe.AtualizaNFeCancelada()
                MessageBox.Show("Nota Fiscal cancelada com sucesso. Protocolo: " + retorno.nProt)
                mmRetornoCancelamento.Text = ""
                MontaGridNFe()

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

    Private Function InicializacaoPadraoNF() As Boolean
        'Informa o local onde os caches serão mantidos, o cache é excencial para emissão
        'em contingencia. É interessante no caso do uso de IIS, separar o cache em pastas
        'diferentes entre as aplicações web, pois o cache de regras é por empresa.
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

    Private Sub btnCancelarNFe_Click(sender As Object, e As EventArgs) Handles btnCancelarNFe.Click
        If txtJustificativaCan.Text = String.Empty Then
            MessageBox.Show("Por favor, informar a justificativa do cancelamento!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tabPainel.SelectedPageIndex = 1
            txtJustificativaCan.Select()
            Exit Sub
        End If
        CancelaNota()
    End Sub

    Private Sub tabPainel_SelectedPageChanged(sender As Object, e As DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs) Handles tabPainel.SelectedPageChanged
        If tabPainel.SelectedPage.Name = "tabNavCancelar" Then
            btnCCe.Enabled = False
            Dim d1 As Integer = DateDiff(DateInterval.Hour, grdNFe.CurrentRow.Cells(5).Value, DateTime.Now)
            If situacaoNFe = "C" Or situacaoNFe = "D" Or d1 > 24 Then
                txtChaveCancelamento.Text = chaveNFe
                txtNumNFeCan.Enabled = False
                txtChaveCancelamento.Enabled = False
                txtJustificativaCan.Enabled = False
                btnCancelarNFe.Enabled = False
                If situacaoNFe = "C" Then
                    txtJustificativaCan.Text = justificativaCan
                Else
                    txtJustificativaCan.Text = ""
                End If
            Else
                txtNumNFeCan.Enabled = False
                txtChaveCancelamento.Text = chaveNFe
                txtChaveCancelamento.Enabled = False
                txtJustificativaCan.Enabled = True
                btnCancelarNFe.Enabled = True
                txtJustificativaCan.Text = ""
            End If

            txtNumNFeCan.Text = numeroDoc
            btnInutilizar.Enabled = False
        ElseIf tabPainel.SelectedPage.Name = "tabNavCCe" Then
            btnCancelarNFe.Enabled = False
            If grdNFe.CurrentRow.Cells(7).Value = "C" Or grdNFe.CurrentRow.Cells(7).Value = "D" Then
                btnCCe.Enabled = False
                txtNumeroNotaCCe.Enabled = False
                txtChaveCCe.Enabled = False
                txtDescricaoCCe.Enabled = False
            Else
                btnCCe.Enabled = True
                txtNumeroNotaCCe.Enabled = True
                txtChaveCCe.Enabled = False
                txtDescricaoCCe.Enabled = True
            End If
            txtNumeroNotaCCe.Text = numeroDoc
            txtNumeroNotaCCe.Enabled = False
            txtChaveCCe.Text = chaveNFe
            btnInutilizar.Enabled = False

            If modeloNF = 65 Then
                btnCCe.Enabled = False
            End If
        ElseIf tabPainel.SelectedPage.Name = "tabNavInutilizada" Then
            btnInutilizar.Enabled = True
        ElseIf tabPainel.SelectedPage.Name = "tabNavNFE" Then
            btnCancelarNFe.Enabled = False
            btnCCe.Enabled = False
            btnInutilizar.Enabled = False
        End If
    End Sub

    Private Sub grdNFe_SelectionChanged(sender As Object, e As EventArgs) Handles grdNFe.SelectionChanged
        emitenteCnpj = emitente.CnpjCpf
        numeroDoc = grdNFe.CurrentRow.Cells(0).Value
        codigoCliente = grdNFe.CurrentRow.Cells(10).Value
        codigoFilial = grdNFe.CurrentRow.Cells(11).Value
        serieNF = grdNFe.CurrentRow.Cells(2).Value
        modeloNF = grdNFe.CurrentRow.Cells(3).Value
        chaveNFe = grdNFe.CurrentRow.Cells(12).Value.ToString()
        codigoNatureza = grdNFe.CurrentRow.Cells(15).Value.ToString()
        situacaoNFe = grdNFe.CurrentRow.Cells(7).Value.ToString()
        justificativaCan = grdNFe.CurrentRow.Cells(13).Value.ToString()

        If situacaoNFe = "D" Then
            btnImprimirNFe.Enabled = False
        Else
            btnImprimirNFe.Enabled = True
        End If

        If modeloNF = 55 Then
            rbNFe.Checked = True
            gbTipoDocumento.Enabled = False
        Else
            rbNFCe.Checked = True
            gbTipoDocumento.Enabled = False
        End If

    End Sub

    Private Sub btnImprimirNFe_Click(sender As Object, e As EventArgs) Handles btnImprimirNFe.Click
        mmMensagemNFe.Text = "Por favor aguarde, gerando impressão...."
        SplashScreenManager1.ShowWaitForm()

        Dim strSQL As String = "select situacao, nfeassinadaxml from nfe where emitente = " & Geral.AspasSQL(emitente.CnpjCpf) & " and " &
            "numero = " & numeroDoc & " and serie = " & serieNF & " and modelo = " & modeloNF

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
                MessageBox.Show("Não é possível gerar DANFE de uma nota que " & vbCrLf & "não foi autorizada ou cancelada!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                mmMensagemNFe.Text = ""
            End If
        End If
    End Sub

    Private Sub btnCCe_Click(sender As Object, e As EventArgs) Handles btnCCe.Click
        If txtDescricaoCCe.Text = String.Empty Then
            MessageBox.Show("Por favor, informar a descrição da carta de correção!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tabPainel.SelectedPageIndex = 2
            txtDescricaoCCe.Select()
            Exit Sub
        End If
        EnviaCCeNota()
    End Sub

    Private Sub EnviaCCeNota()
        Try
            Dim tpAmbiente, tpImpressao, tpFin, tpEmis As Integer
            mmRetornoCCe.Text = "Aguarde, registrando a carta de correção..."
            'Verifica se a DLL foi nicializazda, em caso negativo a DLL será inicializada
            If dllInicializada = False Then
                InicializacaoPadraoNF()
            End If

            oNFe.SetIdKeySistema(emitente.IdSistemaNFeCCe)

            If emitente.Producao = True Then
                tpAmbiente = 1
            Else
                tpAmbiente = 2
            End If

            tpImpressao = 1

            op.RetornaRegistro(codigoNatureza)

            If op.FinalidadeNota = 1 Then
                tpFin = 1
            ElseIf op.FinalidadeNota = 2 Then
                tpFin = 2
            ElseIf op.FinalidadeNota = 3 Then
                tpFin = 3
            ElseIf op.FinalidadeNota = 4 Then
                tpFin = 4
            End If

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

            'Define se a DLL imprimirá diretamenta para a impressão Padrão do windows
            oNFe.PrintToDefaultPrinter = False

            oNFe.ClearParams()

            'No exemplo utlizado, existe somente 1 filtro
            '- um com o numero da Nota Fiscal no sistema
            'Os filtros devem ser alimentados na mesma ordem que eles foram criados
            'no ConfigExtractor

            dadosNFeCCe.Emitente = emitente.CnpjCpf
            dadosNFeCCe.NumeroNFe = numeroDoc
            dadosNFeCCe.Serie = serieNF
            dadosNFeCCe.Modelo = modeloNF

            dadosNFeCCe.RegistroNumeroEvento(emitente.CnpjCpf, serieNF, modeloNF, numeroDoc)
            dadosNFeCCe.NumeroEvento = dadosNFeCCe.NumeroEvento
            dadosNFeCCe.Descricao = txtDescricaoCCe.Text
            dadosNFeCCe.UsuarioInclusao = 1
            dadosNFeCCe.SalvaCCeNFe()

            'Adiciona o valor no filtro
            oNFe.AddParams(emitente.CnpjCpf) 'cnpjemitente
            oNFe.AddParams(numeroDoc) 'numeronfe
            oNFe.AddParams(serieNF) 'Serie
            oNFe.AddParams(modeloNF) 'modelo NF
            oNFe.AddParams(dadosNFeCCe.NumeroEvento)

            Dim retorno As IRetornoCCe = oNFe.CartaDeCorrecao()

            Dim erros As IErroXSD() = oNFe.GetErroXSD()

            If erros IsNot Nothing AndAlso erros.Length > 0 Then
                For i As Integer = 0 To erros.Length - 1
                    MessageBox.Show(erros(i).Descricao, erros(i).Titulo, MessageBoxButtons.OK, MessageBoxIcon.[Error])
                Next
            End If

            If retorno.cStat = 135 Or retorno.cStat = 128 Or retorno.cStat = 136 Then

                dadosNFeCCe.ChaveNFe = txtChaveCCe.Text
                dadosNFeCCe.Protocolo = retorno.nProt
                dadosNFeCCe.DataEvento = retorno.dhRegEvento
                dadosNFeCCe.CCeAssinada = retorno.ProcEventoNFe
                dadosNFeCCe.AtualizaCCeNFe()

                MessageBox.Show("Carta de correção registrada com sucesso. Protocolo: " + retorno.nProt)
                mmRetornoCCe.Text = "Carta de correção registrada com sucesso..."
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

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles btnInutilizar.Click
        InutilizarNFe()
    End Sub

    Private Sub InutilizarNFe()
        Try
            Dim tpAmbiente, tpImpressao, tpFin, tpEmis As Integer
            If txtNumeroInicial.Text = String.Empty Or txtNumeroFinal.Text = String.Empty Or txtSerie.Text = String.Empty Or
                    txtModelo.Text = String.Empty Or txtJusInutilizada.Text = String.Empty Then
                MessageBox.Show("Por favor, informar todos os dados para inutilização!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            mmRetornoInutilizada.Text = "Aguarde, registrando a inutilização..."
            'Verifica se a DLL foi nicializazda, em caso negativo a DLL será inicializada
            If dllInicializada = False Then
                InicializacaoPadraoNF()
            End If

            oNFe.SetIdKeySistema(emitente.IdSistemaInutilizaNFe)

            tpAmbiente = 1
            tpImpressao = 1
            tpFin = 1
            tpEmis = 1

            'Set de configurações de emissão: ambiente, impressão, finalidade, tipo de emisão
            oNFe.SetEnvironment(tpAmbiente, tpImpressao, tpFin, tpEmis)

            'Set do endereço no file system onde as NFe//s autorizadas serão armazenadas
            oNFe.EnderecoCancelada = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Inutilizada")

            'Define no numero de copias que serão impressas
            oNFe.SetNumeroCopias(1)

            'Define se a DLL imprimirá diretamenta para a impressão Padrão do windows
            oNFe.PrintToDefaultPrinter = False

            oNFe.ClearParams()

            'No exemplo utlizado, existe somente 1 filtro
            '- um com o numero da Nota Fiscal no sistema
            'Os filtros devem ser alimentados na mesma ordem que eles foram criados
            'no ConfigExtractor

            Dim contador As Integer = 0
            Dim numeroInicial As Integer = Convert.ToInt64(txtNumeroInicial.Text)
            Dim numeroFinal As Integer = Convert.ToInt64(txtNumeroFinal.Text)

            For contador = numeroInicial To numeroFinal
                dadosNFeInutilizada.Emitente = emitente.CnpjCpf
                dadosNFeInutilizada.NumeroNFe = contador
                dadosNFeInutilizada.Serie = Convert.ToInt32(txtSerie.Text)
                dadosNFeInutilizada.Modelo = Convert.ToInt32(txtModelo.Text)
                dadosNFeInutilizada.Justificativa = txtJusInutilizada.Text

                Dim strSQL As String = "select 1 from nfe where emitente = " & Geral.AspasSQL(emitente.CnpjCpf) & " numero = " & contador &
                    " and serie = " & Convert.ToInt32(txtSerie.Text) & " and modelo = " & Convert.ToInt32(txtModelo.Text) +
                    " and situacao in ('N', 'C')"
                If d.VerificaExistenciaReg(strSQL) = 1 Then
                    MessageBox.Show("Não é possível inutilizar a nota de nº " & contador.ToString() & vbCrLf & "pois a mesma já foi autorizada.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    If dadosNFeInutilizada.SalvaNFeInutilizada() = False Then
                        MessageBox.Show("Nota Fiscal nº " & contador.ToString() + " não foi possível inutilizá-la" & vbCrLf &
                                        "esta nota já está registrada como inutilizada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Next

            'Adiciona o valor no filtro
            oNFe.AddParams(emitente.CnpjCpf) 'cnpjemitente
            oNFe.AddParams(numeroInicial)
            oNFe.AddParams(numeroFinal)
            oNFe.AddParams(serieNF) 'Serie
            oNFe.AddParams(modeloNF) 'modelo NF

            Dim retorno As IRetornoCCe = oNFe.InutilizarPorIntegracao()

            Dim erros As IErroXSD() = oNFe.GetErroXSD()

            If erros IsNot Nothing AndAlso erros.Length > 0 Then
                For i As Integer = 0 To erros.Length - 1
                    MessageBox.Show(erros(i).Descricao, erros(i).Titulo, MessageBoxButtons.OK, MessageBoxIcon.[Error])
                Next
            End If

            If retorno.cStat = 102 Then
                MessageBox.Show("Inutilização efetuada com sucesso: " + retorno.Protocolo)
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
End Class