Imports System.Data
Imports System.Data.SqlClient
Imports mrotica_util
Imports Boleto2Net
Imports System.IO
Imports MRUtil

Public Class frmBoleto
    Dim d As New dados
    Dim conf As New config
    Dim ObjBoleto As New objMaster
    Dim emitente As New Empresa(conf.Filial)

    Dim Boleto As Object

    Private Sub formata_grid()
        grdBoleto.DataSource = Nothing
        grdBoleto.Rows.Clear()
        grdBoleto.Columns.Clear()
        grdBoleto.AutoGenerateColumns = False

        Dim tbBoleto As New DataTable
        Dim dsBoleto As New DataSet

        Dim dtInicial As DateTime = dtIni.Value.ToShortDateString & " 00:00:01"
        Dim dtFinal As DateTime = dtFim.Value.ToShortDateString & " 23:59:59"

        Dim strSQL As String = "SELECT boleto.Nossonumero, boleto.tipo_documento, lancamentos.data_lancamento," &
            "boleto.documento,(isnull((lancamentos.Valor_pago+lancamentos.acrescimo+lancamentos.juros-lancamentos.desconto+lancamentos.taxas),0)+" &
            "isnull((Pagamentos_acordo.acrescimo+Pagamentos_acordo.juros+Pagamentos_acordo.taxas-Pagamentos_acordo.desconto),0)) as Valor," &
            "lancamentos.data_vencimento, lancamentos.data_recebimento,boleto.cod_lancamento, boleto.id_filial, lancamentos.id_filial_lancamento," &
            "lancamentos.n_parcela, lancamentos.n_parcelas, cliente.cod_cliente, cliente.nome_cliente, cliente.razao_social, cliente.cnpj, cliente.endereco, cliente.bairro, cliente.municipio, cliente.uf, cliente.cep," &
            "boleto.Barra, boleto.Digitavel, boleto.diasprotesto, lancamentos.historico FROM boleto INNER JOIN lancamentos ON boleto.cod_lancamento = lancamentos.cod_lancamento AND " &
            "boleto.id_filial = lancamentos.id_filial inner join lancamentos_cliente on lancamentos.id_filial = lancamentos_cliente.id_filial And " &
            "lancamentos.cod_lancamento = lancamentos_cliente.cod_lancamento INNER JOIN cliente ON cliente.cod_cliente = lancamentos_cliente.cod_cliente " &
            "LEFT JOIN Pagamentos_acordo ON lancamentos.cod_lancamento = Pagamentos_acordo.cod_lancamento and lancamentos.id_filial = Pagamentos_acordo.id_filial And " &
            "boleto.cod_lancamento = Pagamentos_acordo.cod_lancamento And boleto.id_filial = Pagamentos_acordo.id_filial " &
            "where lancamentos.data_lancamento >= " & d.pdtm(dtInicial) & " and lancamentos.data_lancamento <= " & d.pdtm(dtFinal) &
            " and lancamentos.cod_status_lancamento = 1 " &
            "and lancamentos.data_recebimento is null and Valor_pago > 0 order by cliente.nome_cliente"

        d.carrega_ds(strSQL, dsBoleto)

        Dim Selecao As New DataGridViewCheckBoxColumn 'Posição 00
        Selecao.HeaderText = "Selecionar"
        Selecao.Width = 70
        grdBoleto.Columns.Add(Selecao)

        Dim CodCliente As New DataGridViewTextBoxColumn 'Posição 01
        CodCliente.HeaderText = "Código"
        CodCliente.DataPropertyName = "cod_cliente"
        CodCliente.Width = 60
        CodCliente.ReadOnly = True
        grdBoleto.Columns.Add(CodCliente)

        Dim Cliente As New DataGridViewTextBoxColumn 'Posição 02
        Cliente.HeaderText = "Cliente"
        Cliente.DataPropertyName = "nome_cliente"
        Cliente.Width = 400
        Cliente.ReadOnly = True
        grdBoleto.Columns.Add(Cliente)

        Dim NossoNumero As New DataGridViewTextBoxColumn 'Posição 03
        NossoNumero.HeaderText = "Nosso Número"
        NossoNumero.DataPropertyName = "nossonumero"
        NossoNumero.Width = 150
        NossoNumero.ReadOnly = True
        grdBoleto.Columns.Add(NossoNumero)

        Dim TipoDoc As New DataGridViewTextBoxColumn 'Posição 04
        TipoDoc.HeaderText = "T. Doc."
        TipoDoc.DataPropertyName = "tipo_documento"
        TipoDoc.Width = 70
        TipoDoc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        TipoDoc.ReadOnly = True
        grdBoleto.Columns.Add(TipoDoc)

        Dim Documento As New DataGridViewTextBoxColumn 'Posição 05
        Documento.HeaderText = "Documento"
        Documento.DataPropertyName = "documento"
        Documento.Width = 90
        Documento.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Documento.ReadOnly = True
        grdBoleto.Columns.Add(Documento)

        Dim Emissao As New DataGridViewTextBoxColumn 'Posição 06
        Emissao.HeaderText = "Emissão"
        Emissao.DataPropertyName = "data_lancamento"
        Emissao.Width = 90
        Emissao.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Emissao.DefaultCellStyle.Format = "dd/MM/yyyy"
        Emissao.ReadOnly = True
        grdBoleto.Columns.Add(Emissao)

        Dim Vencimento As New DataGridViewTextBoxColumn 'Posição 07
        Vencimento.HeaderText = "Vencimento"
        Vencimento.DataPropertyName = "data_vencimento"
        Vencimento.Width = 90
        Vencimento.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Vencimento.DefaultCellStyle.Format = "dd/MM/yyyy"
        Vencimento.ReadOnly = True
        grdBoleto.Columns.Add(Vencimento)

        Dim Valor As New DataGridViewTextBoxColumn 'Posição 08
        Valor.HeaderText = "Valor"
        Valor.DataPropertyName = "valor"
        Valor.Width = 80
        Valor.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Valor.DefaultCellStyle.Format = "#,##0.00"
        Valor.ReadOnly = True
        grdBoleto.Columns.Add(Valor)

        Dim Barra As New DataGridViewTextBoxColumn 'Posição 09
        Barra.HeaderText = "Barra"
        Barra.DataPropertyName = "barra"
        Barra.Width = 100
        Barra.Visible = False
        grdBoleto.Columns.Add(Barra)

        Dim Digitavel As New DataGridViewTextBoxColumn 'Posição 10
        Digitavel.HeaderText = "Digitavel"
        Digitavel.DataPropertyName = "digitavel"
        Digitavel.Width = 100
        Digitavel.Visible = False
        grdBoleto.Columns.Add(Digitavel)

        Dim Parcela As New DataGridViewTextBoxColumn 'Posição 11
        Parcela.HeaderText = "Parcela"
        Parcela.DataPropertyName = "n_parcela"
        Parcela.Width = 100
        Parcela.Visible = False
        grdBoleto.Columns.Add(Parcela)

        Dim RazaoSocial As New DataGridViewTextBoxColumn 'Posição 12
        RazaoSocial.HeaderText = "Razão Social"
        RazaoSocial.DataPropertyName = "razao_social"
        RazaoSocial.Width = 100
        RazaoSocial.Visible = False
        grdBoleto.Columns.Add(RazaoSocial)

        Dim cnpj As New DataGridViewTextBoxColumn 'Posição 13
        cnpj.HeaderText = "CNPJ"
        cnpj.DataPropertyName = "cnpj"
        cnpj.Width = 100
        cnpj.Visible = False
        grdBoleto.Columns.Add(cnpj)

        Dim endereco As New DataGridViewTextBoxColumn 'Posição 14
        endereco.HeaderText = "Endereço"
        endereco.DataPropertyName = "endereco"
        endereco.Width = 100
        endereco.Visible = False
        grdBoleto.Columns.Add(endereco)

        Dim bairro As New DataGridViewTextBoxColumn 'Posição 15
        bairro.HeaderText = "Bairro"
        bairro.DataPropertyName = "bairro"
        bairro.Width = 100
        bairro.Visible = False
        grdBoleto.Columns.Add(bairro)

        Dim municipio As New DataGridViewTextBoxColumn 'Posição 16
        municipio.HeaderText = "Cidade"
        municipio.DataPropertyName = "municipio"
        municipio.Width = 100
        municipio.Visible = False
        grdBoleto.Columns.Add(municipio)

        Dim uf As New DataGridViewTextBoxColumn 'Posição 17
        uf.HeaderText = "UF"
        uf.DataPropertyName = "uf"
        uf.Width = 50
        uf.Visible = False
        grdBoleto.Columns.Add(uf)

        Dim cep As New DataGridViewTextBoxColumn 'Posição 18
        cep.HeaderText = "CEP"
        cep.DataPropertyName = "cep"
        cep.Width = 50
        cep.Visible = False
        grdBoleto.Columns.Add(cep)

        Dim Parcelas As New DataGridViewTextBoxColumn 'Posição 19
        Parcelas.HeaderText = "Parcela"
        Parcelas.DataPropertyName = "n_parcelas"
        Parcelas.Width = 100
        Parcelas.Visible = False
        grdBoleto.Columns.Add(Parcelas)

        Dim DiasProtesto As New DataGridViewTextBoxColumn 'Posição 20
        DiasProtesto.HeaderText = "Protesto"
        DiasProtesto.DataPropertyName = "diasprotesto"
        DiasProtesto.Width = 100
        DiasProtesto.Visible = False
        grdBoleto.Columns.Add(DiasProtesto)

        Dim Historico As New DataGridViewTextBoxColumn 'Posição 21
        Historico.HeaderText = "Historico"
        Historico.DataPropertyName = "historico"
        DiasProtesto.Width = 100
        Historico.Visible = False
        grdBoleto.Columns.Add(Historico)

        Dim codlanc As New DataGridViewTextBoxColumn 'Posição 22
        codlanc.HeaderText = "Cod. Lanc"
        codlanc.DataPropertyName = "cod_lancamento"
        codlanc.Width = 100
        codlanc.Visible = False
        grdBoleto.Columns.Add(codlanc)

        Dim filial As New DataGridViewTextBoxColumn 'Posição 23
        filial.HeaderText = "Filial"
        filial.DataPropertyName = "id_filial"
        filial.Width = 35
        filial.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        filial.Visible = True
        grdBoleto.Columns.Add(filial)

        If dsBoleto.Tables(0).Rows.Count = 0 Then
            MessageBox.Show("Não há registro de boleto a ser exibido no período informado.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnBoleto.Enabled = False
            Exit Sub
        Else
            btnBoleto.Enabled = True
        End If

        grdBoleto.DataSource = dsBoleto.Tables(0)
    End Sub

    Private Sub btnLocalizar_Click(sender As System.Object, e As System.EventArgs) Handles btnLocalizar.Click
        formata_grid()
    End Sub

    Private Sub btnBoleto_Click(sender As System.Object, e As System.EventArgs) Handles btnBoleto.Click
        Dim objBoletos As New Boletos
        Dim strImpressora As String = Nothing
        Dim blnImprimir As Boolean = False
        Dim intCopias As Short = 1

        Try
            ''CRIAÇÃO DA PARTE DO CEDENTE
            'Cabeçalho do Banco
            objBoletos.Banco = Banco.Instancia(756)
            objBoletos.Banco.Cedente = New Cedente
            objBoletos.Banco.Cedente.CPFCNPJ = emitente.CnpjCpf
            objBoletos.Banco.Cedente.Nome = emitente.RazaoSocial
            objBoletos.Banco.Cedente.Observacoes = "Pague em dia e evite multas e juros"

            Dim conta As New ContaBancaria
            conta.Agencia = "1234"
            conta.DigitoAgencia = "0"
            conta.OperacaoConta = String.Empty
            conta.Conta = "12345"
            conta.DigitoConta = "0"
            conta.CarteiraPadrao = "1"

            conta.VariacaoCarteiraPadrao = "01"
            conta.TipoCarteiraPadrao = TipoCarteira.CarteiraCobrancaSimples
            conta.TipoFormaCadastramento = TipoFormaCadastramento.ComRegistro
            conta.TipoImpressaoBoleto = TipoImpressaoBoleto.Empresa
            conta.TipoDocumento = TipoDocumento.Tradicional

            Dim ender As New Endereco
            ender.LogradouroEndereco = "Av. das Pitangas"
            ender.LogradouroNumero = "569"
            ender.LogradouroComplemento = "Logo Ali Meu Irmão"
            ender.Bairro = "São João"
            ender.Cidade = "Sertãozinho"
            ender.UF = "SP"
            ender.CEP = "14170230"

            objBoletos.Banco.Cedente.Codigo = "123456"
            objBoletos.Banco.Cedente.CodigoDV = "6"
            objBoletos.Banco.Cedente.CodigoTransmissao = "000000"
            objBoletos.Banco.Cedente.ContaBancaria = conta
            objBoletos.Banco.Cedente.Endereco = ender

            objBoletos.Banco.FormataCedente()

            For I As Integer = 1 To 1
                ''CRIAÇÃO DO TITULO
                Dim Titulo As New Boleto(objBoletos.Banco)
                Titulo.Sacado = New Sacado With {
                    .CPFCNPJ = grdBoleto.CurrentRow.Cells(13).Value,
                    .Endereco = New Boleto2Net.Endereco With {
                    .Bairro = "Bairro",
                    .CEP = "14154710",
                    .Cidade = "Cidade",
                    .LogradouroComplemento = "",
                    .LogradouroEndereco = "Rua Da Esquina Perdida Logo Ali",
                    .LogradouroNumero = "569",
                    .UF = "SP"},
                    .Nome = "Nome do Pagador",
                    .Observacoes = "Pagar com urgência para não ser protestado."
                }
                Titulo.CodigoOcorrencia = "01"
                Titulo.DescricaoOcorrencia = "Remessa Registrar"
                Titulo.NumeroDocumento = I
                Titulo.NumeroControleParticipante = "12"
                Titulo.NossoNumero = "123456" & I
                Titulo.DataEmissao = Now.Date
                Titulo.DataVencimento = Now.Date.AddDays(15)
                Titulo.ValorTitulo = 200.0
                Titulo.Aceite = "N"
                Titulo.EspecieDocumento = TipoEspecieDocumento.DM
                Titulo.DataDesconto = Now.Date.AddDays(15)
                Titulo.ValorDesconto = 45

                '
                'PARTE DA MULTA
                Titulo.DataMulta = Now.Date.AddDays(15)
                Titulo.PercentualMulta = 2
                Titulo.ValorMulta = Titulo.ValorTitulo * Titulo.PercentualMulta / 100
                Titulo.MensagemInstrucoesCaixa = $"Cobrar multa de {FormatNumber(Titulo.ValorMulta, 2)} após a data de vencimento."
                '
                'PARTE JUROS DE MORA
                Titulo.DataJuros = Now.Date.AddDays(15)
                Titulo.PercentualJurosDia = 10 / 30
                Titulo.ValorJurosDia = Titulo.ValorTitulo * Titulo.PercentualJurosDia / 100
                Dim instrucoes As String = $"Cobrar juros de {FormatNumber(Titulo.PercentualJurosDia, 2)} por dia."
                If String.IsNullOrEmpty(Titulo.MensagemInstrucoesCaixa) Then
                    Titulo.MensagemInstrucoesCaixa = instrucoes
                Else
                    Titulo.MensagemInstrucoesCaixa += Environment.NewLine + instrucoes
                End If
                '
                'Titulo.CodigoInstrucao1 = String.Empty
                'Titulo.ComplementoInstrucao1 = String.Empty

                'Titulo.CodigoInstrucao2 = String.Empty
                'Titulo.ComplementoInstrucao2 = String.Empty

                'Titulo.CodigoInstrucao3 = String.Empty
                'Titulo.ComplementoInstrucao3 = String.Empty
                Titulo.CodigoProtesto = TipoCodigoProtesto.NaoProtestar
                Titulo.DiasProtesto = 0
                Titulo.CodigoBaixaDevolucao = TipoCodigoBaixaDevolucao.NaoBaixarNaoDevolver
                Titulo.DiasBaixaDevolucao = 0
                Titulo.ValidarDados()
                objBoletos.Add(Titulo)
            Next


            '
            If File.Exists(Application.StartupPath & "\remessa.txt") Then
                File.Delete(Application.StartupPath & "\remessa.txt")
            End If
            'GERA ARQUIVO DE REMESSA
            Dim st As New MemoryStream
            Dim remessa = New ArquivoRemessa(objBoletos.Banco, TipoArquivo.CNAB240, 1)
            remessa.GerarArquivoRemessa(objBoletos, st)
            Dim arquivo As New FileStream(Application.StartupPath & "\remessa.txt", FileMode.Create, FileAccess.ReadWrite)

            st.WriteTo(arquivo)
            arquivo.Close()
            st.Close()


            Dim LerArquivo As New StreamReader(Application.StartupPath & "\remessa.txt")

            Dim RefazArquivo As New StreamWriter(Application.StartupPath & "\remessa2.txt") 'Arquivo verificado para ser enviado ao banco
            Dim strTexto As String = Nothing
            Dim conta1 As Integer = 0
            Do While LerArquivo.Peek <> -1
                strTexto = LerArquivo.ReadLine
                conta1 = strTexto.Length
                If conta1 < 240 Then
                    conta1 = 240 - conta1
                    Dim strEspaco As String = Nothing
                    For I As Integer = 1 To conta1
                        strEspaco = strEspaco & " "
                    Next
                    RefazArquivo.WriteLine(strTexto & strEspaco)
                Else
                    RefazArquivo.WriteLine(strTexto)
                End If

            Loop
            RefazArquivo.Close()
            LerArquivo.Close()

            'Solicita se vai imprimir os boletos
            If MessageBox.Show("Deseja imprimir os boletos agora?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                Dim imp As New PrintDialog
                If imp.ShowDialog = DialogResult.OK Then
                    strImpressora = imp.PrinterSettings.PrinterName
                    intCopias = imp.PrinterSettings.Copies
                    blnImprimir = True
                End If
            End If

            'Gera boletos
            Dim numBoletos As Integer = 0
            For Each linha In objBoletos
                numBoletos += 1
                Dim NovoBoleto = New BoletoBancario
                NovoBoleto.Boleto = linha
                Dim pdf = NovoBoleto.MontaBytesPDF(False)
                File.WriteAllBytes(Application.StartupPath & "\boleto" & numBoletos & ".pdf", pdf)

                'Parte da impressão do boleto
                If blnImprimir = True Then
                    Dim MyProcess As New Process
                    MyProcess.StartInfo.CreateNoWindow = False
                    MyProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                    MyProcess.StartInfo.Verb = "print"
                    MyProcess.StartInfo.Arguments = strImpressora

                    MyProcess.StartInfo.FileName = Application.StartupPath & "\boleto" & numBoletos & ".pdf"
                    MyProcess.Start()
                    'MyProcess.WaitForExit(10000)
                    MyProcess.WaitForInputIdle()

                    If MyProcess.Responding Then
                        MyProcess.CloseMainWindow()
                    Else
                        MyProcess.Kill()
                    End If

                    'MyProcess.Close()
                End If
            Next

            MessageBox.Show("Boleto Gerado.")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub grdBoleto_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles grdBoleto.CellFormatting
        grdBoleto.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGoldenrodYellow
    End Sub

    Private Sub cbLista_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbLista.SelectedIndexChanged
        'Variável responsável por guardar o código do usuário que está realizando a operação
        Dim intUsuario As Integer = ObjBoleto.retorna_codigo_usuario(frmMain.intCodigoUsuario)
        Dim intControle As Int16 = 0

        For Each linhaverif As DataGridViewRow In grdBoleto.Rows
            If linhaverif.Cells(0).Value = True Then
                intControle = 1
            End If
        Next

        If intControle = 1 Then
            If MessageBox.Show("Deseja aplicar a ação de cobrança para o(s) boleto(s) selecionado(s)?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                'Varre todos os elementos do grdBoleto
                For Each linha As DataGridViewRow In grdBoleto.Rows
                    If linha.Cells(0).Value = True Then
                        Dim stracao As String = cbLista.Text.Substring(0, 2) 'Pega a ação de cobrança selecionada no ListBox
                        'Instrução SQL a ser executada
                        Dim strSQL As String = "acaocobranca = '" & stracao & "', usuario_alt = " & intUsuario & " where nossonumero = " & d.PStr(linha.Cells(3).Value)
                        ObjBoleto.atualiza_registros("boleto", strSQL, True)
                        If stracao = "02" Then
                            Dim strSQLAtualizaLanc As String = "cod_status_lancamento = 2 where cod_lancamento = " & linha.Cells(22).Value & " and id_filial = " & linha.Cells(23).Value
                            ObjBoleto.atualiza_registros("lancamentos", strSQLAtualizaLanc, True)
                        End If

                    End If
                Next
                MessageBox.Show("Ação de cobrança alterada com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                formata_grid()
            End If
        Else
            MessageBox.Show("Você precisa selecionar pelo menos um boleto para modificar.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub grdBoleto_Click(sender As System.Object, e As System.EventArgs) Handles grdBoleto.Click
        cbLista.Enabled = True
    End Sub

    Private Sub btnRemessa_Click(sender As System.Object, e As System.EventArgs) Handles btnRemessa.Click
        If cbLista.Text <> String.Empty Then
            Dim strNossoNumero As String = ""
            Dim strLista As ArrayList = New ArrayList
            'Varre o grdBoleto para recuperar o nossonumero que foi selecionado no DataGridView
            For Each linha As DataGridViewRow In grdBoleto.Rows
                If linha.Cells(0).Value = True Then
                    strNossoNumero = linha.Cells(3).Value 'Pega o nossonumero e guarda na respectiva variavel
                    strLista.Add("'" & strNossoNumero & "'" & Chr(13)) 'Coloca o nossonumero em uma lista com parenteses para ser utilizada no DB
                End If
            Next

            Dim i, j As Integer

            'Guardo o nossonumero definitivo para a busca dentro do DB
            Dim strGuardaNossoNumero As String = ""

            For i = 0 To strLista.Count - 1
                If j < i Then
                    j = j + 1
                    strGuardaNossoNumero = strGuardaNossoNumero & "," & strLista.Item(i).ToString
                Else
                    strGuardaNossoNumero = strGuardaNossoNumero & strLista.Item(i).ToString
                End If

            Next
            'Monta o arquivo remessa
        Else
            MessageBox.Show("Para gerar o arquivo de remessa alterada, por favor" & Chr(13) & "escolha a ação de cobração a ser aplicada.", "INFORMÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objBoletos As New Boletos
        Dim strImpressora As String = Nothing
        Dim blnImprimir As Boolean = False
        Dim intCopias As Short = 1

        Try
            ''CRIAÇÃO DA PARTE DO CEDENTE
            'Cabeçalho do Banco
            objBoletos.Banco = Banco.Instancia(756)
            objBoletos.Banco.Cedente = New Cedente
            objBoletos.Banco.Cedente.CPFCNPJ = "24.368.434/0001-07"
            objBoletos.Banco.Cedente.Nome = "MR INFORMATICA"
            objBoletos.Banco.Cedente.Observacoes = "Pague isso logo carinha que estou precisando...rs"

            Dim conta As New ContaBancaria
            conta.Agencia = "1234"
            conta.DigitoAgencia = "0"
            conta.OperacaoConta = String.Empty
            conta.Conta = "12345"
            conta.DigitoConta = "0"
            conta.CarteiraPadrao = "1"

            conta.VariacaoCarteiraPadrao = "01"
            conta.TipoCarteiraPadrao = TipoCarteira.CarteiraCobrancaSimples
            conta.TipoFormaCadastramento = TipoFormaCadastramento.ComRegistro
            conta.TipoImpressaoBoleto = TipoImpressaoBoleto.Empresa
            conta.TipoDocumento = TipoDocumento.Tradicional

            Dim ender As New Endereco
            ender.LogradouroEndereco = "Tv Barão do Triunfo"
            ender.LogradouroNumero = "907"
            ender.LogradouroComplemento = "Altos"
            ender.Bairro = "Pedreira"
            ender.Cidade = "Belém"
            ender.UF = "PA"
            ender.CEP = "66083100"

            objBoletos.Banco.Cedente.Codigo = "123456"
            objBoletos.Banco.Cedente.CodigoDV = "6"
            objBoletos.Banco.Cedente.CodigoTransmissao = "000000"
            objBoletos.Banco.Cedente.ContaBancaria = conta
            objBoletos.Banco.Cedente.Endereco = ender

            objBoletos.Banco.FormataCedente()

            For I As Integer = 1 To 1
                ''CRIAÇÃO DO TITULO
                Dim Titulo As New Boleto(objBoletos.Banco)
                Titulo.Sacado = New Sacado With {
                    .CPFCNPJ = "82823120378",
                    .Endereco = New Boleto2Net.Endereco With {
                    .Bairro = "Pedreira",
                    .CEP = "66080680",
                    .Cidade = "Belém",
                    .LogradouroComplemento = "",
                    .LogradouroEndereco = "Travessa Mauriti",
                    .LogradouroNumero = "678",
                    .UF = "PA"},
                    .Nome = "Ivanildo dos Santos Ferreira",
                    .Observacoes = "Pagar com urgência para não ser protestado."
                }
                Titulo.CodigoOcorrencia = "01"
                Titulo.DescricaoOcorrencia = "Remessa Registrar"
                Titulo.NumeroDocumento = I
                Titulo.NumeroControleParticipante = "12"
                Titulo.NossoNumero = "123456" & I
                Titulo.DataEmissao = Now.Date
                Titulo.DataVencimento = Now.Date.AddDays(15)
                Titulo.ValorTitulo = 200.0
                Titulo.Aceite = "N"
                Titulo.EspecieDocumento = TipoEspecieDocumento.DM
                Titulo.DataDesconto = Now.Date.AddDays(15)
                Titulo.ValorDesconto = 45

                '
                'PARTE DA MULTA
                Titulo.DataMulta = Now.Date.AddDays(15)
                Titulo.PercentualMulta = 2
                Titulo.ValorMulta = Titulo.ValorTitulo * Titulo.PercentualMulta / 100
                Titulo.MensagemInstrucoesCaixa = $"Cobrar multa de {FormatNumber(Titulo.ValorMulta, 2)} após a data de vencimento."
                '
                'PARTE JUROS DE MORA
                Titulo.DataJuros = Now.Date.AddDays(15)
                Titulo.PercentualJurosDia = 10 / 30
                Titulo.ValorJurosDia = Titulo.ValorTitulo * Titulo.PercentualJurosDia / 100
                Dim instrucoes As String = $"Cobrar juros de {FormatNumber(Titulo.PercentualJurosDia, 2)} por dia."
                If String.IsNullOrEmpty(Titulo.MensagemInstrucoesCaixa) Then
                    Titulo.MensagemInstrucoesCaixa = instrucoes
                Else
                    Titulo.MensagemInstrucoesCaixa += Environment.NewLine + instrucoes
                End If
                '
                'Titulo.CodigoInstrucao1 = String.Empty
                'Titulo.ComplementoInstrucao1 = String.Empty

                'Titulo.CodigoInstrucao2 = String.Empty
                'Titulo.ComplementoInstrucao2 = String.Empty

                'Titulo.CodigoInstrucao3 = String.Empty
                'Titulo.ComplementoInstrucao3 = String.Empty
                Titulo.CodigoProtesto = TipoCodigoProtesto.NaoProtestar
                Titulo.DiasProtesto = 0
                Titulo.CodigoBaixaDevolucao = TipoCodigoBaixaDevolucao.NaoBaixarNaoDevolver
                Titulo.DiasBaixaDevolucao = 0
                Titulo.ValidarDados()
                objBoletos.Add(Titulo)
            Next


            '
            If File.Exists(Application.StartupPath & "\remessa.txt") Then
                File.Delete(Application.StartupPath & "\remessa.txt")
            End If
            'GERA ARQUIVO DE REMESSA
            Dim st As New MemoryStream
            Dim remessa = New ArquivoRemessa(objBoletos.Banco, TipoArquivo.CNAB240, 1)
            remessa.GerarArquivoRemessa(objBoletos, st)
            Dim arquivo As New FileStream(Application.StartupPath & "\remessa.txt", FileMode.Create, FileAccess.ReadWrite)

            st.WriteTo(arquivo)
            arquivo.Close()
            st.Close()


            Dim LerArquivo As New StreamReader(Application.StartupPath & "\remessa.txt")

            Dim RefazArquivo As New StreamWriter(Application.StartupPath & "\remessa2.txt") 'Arquivo verificado para ser enviado ao banco
            Dim strTexto As String = Nothing
            Dim conta1 As Integer = 0
            Do While LerArquivo.Peek <> -1
                strTexto = LerArquivo.ReadLine
                conta1 = strTexto.Length
                If conta1 < 240 Then
                    conta1 = 240 - conta1
                    Dim strEspaco As String = Nothing
                    For I As Integer = 1 To conta1
                        strEspaco = strEspaco & " "
                    Next
                    RefazArquivo.WriteLine(strTexto & strEspaco)
                Else
                    RefazArquivo.WriteLine(strTexto)
                End If

            Loop
            RefazArquivo.Close()
            LerArquivo.Close()

            'Solicita se vai imprimir os boletos
            If MessageBox.Show("Deseja imprimir os boletos agora?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                Dim imp As New PrintDialog
                If imp.ShowDialog = DialogResult.OK Then
                    strImpressora = imp.PrinterSettings.PrinterName
                    intCopias = imp.PrinterSettings.Copies
                    blnImprimir = True
                End If
            End If

            'Gera boletos
            Dim numBoletos As Integer = 0
            For Each linha In objBoletos
                numBoletos += 1
                Dim NovoBoleto = New BoletoBancario
                NovoBoleto.Boleto = linha
                Dim pdf = NovoBoleto.MontaBytesPDF(False)
                File.WriteAllBytes(Application.StartupPath & "\boleto" & numBoletos & ".pdf", pdf)

                'Parte da impressão do boleto
                If blnImprimir = True Then
                    Dim MyProcess As New Process
                    MyProcess.StartInfo.CreateNoWindow = False
                    MyProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                    MyProcess.StartInfo.Verb = "print"
                    MyProcess.StartInfo.Arguments = strImpressora

                    MyProcess.StartInfo.FileName = Application.StartupPath & "\boleto" & numBoletos & ".pdf"
                    MyProcess.Start()
                    'MyProcess.WaitForExit(10000)
                    MyProcess.WaitForInputIdle()

                    If MyProcess.Responding Then
                        MyProcess.CloseMainWindow()
                    Else
                        MyProcess.Kill()
                    End If

                    'MyProcess.Close()
                End If
            Next

            MessageBox.Show("Boleto Gerado.")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmBoleto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class