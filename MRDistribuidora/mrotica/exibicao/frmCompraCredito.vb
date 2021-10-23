Imports System.Data
Imports System.Data.SqlClient
Imports mrotica_util
Imports MRUtil

Public Class frmCompraCredito
    Dim Usu As UsuarioPermissao = New UsuarioPermissao()
    Dim FormaPag As FormaPagamento
    Dim CreditoCliente As CreditoCliente
    Dim PacoteClienteDetalhe As PacoteClienteDetalhes
    Dim Cliente As Cliente
    Dim Lancamentos As Lancamentos
    Dim Conf As New Arquivo


    Dim d As New dados
    Dim tb_itens As New DataTable
    Dim tb_rec As New DataTable

    Public xCodigoCliente, xCodigoFilialCliente, xCodigoCredito, xPacote As Integer

    Dim valor As Double
    Dim intNossoNumero As Long
    Dim intContador As Integer
    Dim datacaixa As New objMaster
    Dim nossonumero As String
    Dim codigobarra As String
    Dim linhadigitavel As String
    Dim intData As Integer
    Dim dataBoleto As Date
    Dim intImprimir As Integer = 0
    Dim intDiasProtesto As Integer
    Dim intProtesto As Integer
    Dim dtVencBoleto As New DateTimePicker
    Dim intUsuario As Integer

    Private Sub frmFatura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Variável responsável por guardar o código do usuário que está realizando a operação

        Usu.RetornaRegistro(frmMain.intCodigoUsuario)
        intUsuario = Usu.CodigoUsuario
        Cliente = New Cliente()
        Cliente.RetornaCliente(xCodigoCliente)
        lblCliente.Text = Cliente.NomeCliente

        PacoteClienteDetalhe = New PacoteClienteDetalhes()
        PacoteClienteDetalhe.CodigoPacote = xPacote
        PacoteClienteDetalhe.CodigoCliente = xCodigocliente
        PacoteClienteDetalhe.CodigoFilialCliente = xCodigoFilialCliente
        txtValorCredito.Text = Geral.FormataMoeda(PacoteClienteDetalhe.CalculaPrecoFinalPacote)

        CreditoCliente = New CreditoCliente()
        CreditoCliente.CodigoCliente = xCodigoCliente
        CreditoCliente.RetornaRegistroCredito(xCodigoCredito, xCodigoFilialCliente)
        txtFilial.Text = CreditoCliente.CodigoFilialCliente
        txtCredito.Text = CreditoCliente.CodigoCredito
        txtHistórico.Text = CreditoCliente.Historico
        CarregaForma()
        MontaGrid()
        lblTotal.Text = Geral.FormataMoeda(CreditoCliente.Credito)
    End Sub

    Private Sub MontaGrid()
        Try
            grdRecebimento.Columns.Clear()
            grdRecebimento.AutoGenerateColumns = False
            grdRecebimento.AllowUserToAddRows = False

            Dim dtVenc As New DataGridViewTextBoxColumn 'Posição 00
            dtVenc.HeaderText = "Data Venc"
            dtVenc.DataPropertyName = "data_vencimento"
            dtVenc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dtVenc.DefaultCellStyle.Format = "dd/MM/yyyy"
            dtVenc.Width = 95
            grdRecebimento.Columns.Add(dtVenc)

            Dim cForma As New DataGridViewTextBoxColumn 'Posição 01
            cForma.HeaderText = "Forma"
            cForma.DataPropertyName = "forma_pagamento"
            cForma.Width = 95
            grdRecebimento.Columns.Add(cForma)

            Dim cValor As New DataGridViewTextBoxColumn 'Posição 02
            cValor.HeaderText = "Valor"
            cValor.DataPropertyName = "valor_pago"
            cValor.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            cValor.DefaultCellStyle.Format = "#,##0.00"
            cValor.Width = 90
            grdRecebimento.Columns.Add(cValor)

            Dim cDoc As New DataGridViewTextBoxColumn 'Posição 03
            cDoc.HeaderText = "Doc"
            cDoc.DataPropertyName = "doc"
            cDoc.Width = 180
            grdRecebimento.Columns.Add(cDoc)

            Dim cLanc As New DataGridViewTextBoxColumn 'Posição 04
            cLanc.HeaderText = "Lanc"
            cLanc.DataPropertyName = "cod_lancamento"
            cLanc.Width = 80
            grdRecebimento.Columns.Add(cLanc)

            Dim cdataLanc As New DataGridViewTextBoxColumn 'posição 05
            cdataLanc.HeaderText = "Data Lanc"
            cdataLanc.DataPropertyName = "data_lancamento"
            cdataLanc.Visible = False
            grdRecebimento.Columns.Add(cdataLanc)

            Dim cFormaPag As New DataGridViewTextBoxColumn 'posição 06
            cFormaPag.HeaderText = "Cod.forma. Pag"
            cFormaPag.DataPropertyName = "cod_forma_pagamento"
            cFormaPag.Visible = False
            grdRecebimento.Columns.Add(cFormaPag)

            grdRecebimento.DataSource = CreditoCliente.RetornaLancamentoPacote

            total_pago()
            If CDbl(txtaPagar.Text) = 0.0 Then
                btnInsereRec.Enabled = False
            Else
                btnInsereRec.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub total_pago()
        txtTotalPago.Text = Geral.FormataMoeda(CreditoCliente.TotalPacotePagoCredito(CreditoCliente.CodigoCredito, Cliente.CodigoCliente, Cliente.CodigoFilialCliente))
        Try
            txtaPagar.Text = Geral.FormataMoeda(CreditoCliente.Credito - Convert.ToDecimal(txtTotalPago.Text))
        Catch ex As Exception
            ex.ToString()
        End Try
    End Sub

    Private Sub btnInsereRec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsereRec.Click
        Dim parcelas As Integer = Convert.ToInt32(txtParcelas.Text)
        Dim strSQL As String = ""
        Lancamentos = New Lancamentos

        'Verifica se a forma de pagamento escolhida foi Boleto Bancário
        If cbForma.SelectedValue = 8 Then
            If datacaixa.convertedata(dtVencimento.Value.ToShortDateString) < datacaixa.convertedata(datacaixa.retornaDataHoraServidor) Then
                MessageBox.Show("Data de vencimento não pode ser inferior a data atual.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If datacaixa.convertedata(dtVencimento.Value.ToShortDateString) = datacaixa.convertedata(datacaixa.retornaDataHoraServidor) Then
                MessageBox.Show("Data de vencimento não pode ser igual a data atual.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If

        If cbForma.SelectedValue = 1 Then
            If datacaixa.convertedata(dtVencimento.Value.ToShortDateString) < datacaixa.convertedata(datacaixa.retornaDataHoraServidor) Then
                MessageBox.Show("Data de vencimento não pode ser inferior a data atual.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If

        Lancamentos.CodigoCliente = Cliente.CodigoCliente
        Lancamentos.CodigoFilialLancamento = Conf.Filial
        Lancamentos.CodigoFilial = Cliente.CodigoFilialCliente
        Lancamentos.CodigoConta = 132
        Lancamentos.FormaPagamento = cbForma.SelectedValue
        Lancamentos.NumeroParcelas = parcelas
        Lancamentos.Historico = txtHistórico.Text
        'Lancamentos.Documento = "" verificar como vai ser usado
        Lancamentos.TipoDocumento = "E"
        Lancamentos.StatusLancamento = 1
        Lancamentos.CodigoFatura = 0
        Lancamentos.Acrescimo = 0
        Lancamentos.Juros = 0
        Lancamentos.Desconto = 0
        Lancamentos.Taxas = 0
        Lancamentos.UsuarioLancamento = intUsuario
        Lancamentos.UsuarioAlteracao = 0
        Lancamentos.CodigoCredito = CreditoCliente.CodigoCredito

        'Verifica se a forma de pagamento escolhida foi Boleto Bancário
        If cbForma.SelectedValue = 8 Then
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
        End If

        'Verifica se a forma de pagamento escolhida foi Dinheiro
        If cbForma.SelectedValue = 1 Then
            Dim i As Integer = 0
            For i = 1 To parcelas Step 1
                Lancamentos.ValorPago = CreditoCliente.Credito
                Lancamentos.NumeroParcela = i
                Lancamentos.DataVencimento = dtVencimento.Value
                Lancamentos.DataRecebimento = dtVencimento.Value
                If Lancamentos.SalvaLancamento() = True Then
                    Lancamentos.SalvaPagamentoCredito()
                End If
            Next

        End If
        MontaGrid()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim f As New frmRpt
        Dim r As New rptReciboPacote
        Cliente = New Cliente()
        Cliente.RetornaCliente(xCodigoCliente)

        r.codigo = "Código: " & Cliente.CodigoCliente
        r.cliente = "Nome Fantasia: " & Cliente.NomeCliente
        r.razao = "Razão Social: " & Cliente.RazaoSocial
        r.fatura = "Pacote Nº " & xPacote
        r.endereco = "Endereço: " & Cliente.Logradouro & " - " & "Bairro: " & Cliente.Bairro & " - " & "CEP: " & Cliente.Cep
        r.municipio = "Cidade: " & Cliente.NomeCidade & "/" & Cliente.Uf
        r.fone = "Fones: " & Cliente.Telefone
        r.tRec = Lista_Rec_Credito(CInt(txtCredito.Text), CInt(txtFilial.Text))
        r.DataSource = Lista_Itens()
        r.aPAGAR = Format(CDbl(txtaPagar.Text), "#,##0.00")
        r.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape
        f.Relat(r)
        f.ShowDialog(Me)
        f.Dispose()
        Me.Close()
    End Sub

    Private Sub montaBoleto()
        'Dim CobreBemX As CobreBemX.ContaCorrente
        Dim Boleto As Object

        'Inicializa o objeto CobreBemX
        'CobreBemX = New CobreBemX.ContaCorrente

        'Instruções por montarem o cabeçalho padrão para emissão do boleto
        'CobreBemX.ArquivoLicenca = My.Computer.FileSystem.CurrentDirectory & "\63882898000199-001-17-7.conf"
        'CobreBemX.CodigoAgencia = "3074-0"
        ' CobreBemX.NumeroContaCorrente = "00060082-2"
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
        Dim valorcentavo As Double
        Dim valordif As Double
        Dim valorreal As Double

        'Função responsável por retorna os dados do cliente como por exemplo: Nome, Endereço, CEP e etc.

        'Cria um loop para criar a quantidade de boleto especificada de acordo com o número de parcelas
        For intContador = 1 To CInt(txtParcelas.Text)

            valor = Format(CDbl(txtaPagar.Text) / CInt(txtParcelas.Text), "#,##0.00")

            If intContador = 1 Then
                valorreal = Format(valor * CInt(txtParcelas.Text), "#,##0.00")
            End If

            If intContador < CInt(txtParcelas.Text) Then
                valordif = Format(valorreal - CDbl(txtaPagar.Text), "#,##0.00")
                valor = Format(valor - valordif, "#,##0.00")
                valorcentavo = Format(valorcentavo + valordif, "#,##0.00")
            End If

            If intContador = CInt(txtParcelas.Text) Then
                valordif = Format(valorreal - CDbl(txtaPagar.Text), "#,##0.00")
                valor = Format(valor - valordif, "#,##0.00")
                valor = Format(valor + valorcentavo, "#,##0.00")
            End If

            intData = intData + 1
            If CInt(txtDias.Text) > 0 Then
                If CInt(txtParcelas.Text) = 1 Then
                    If cbVencimento.Checked = False Then
                        dataBoleto = dtVencimento.Value.AddDays(CInt(txtDias.Text))
                    Else
                        dataBoleto = dtVencimento.Value.ToShortDateString
                    End If
                Else
                    If cbVencimento.Checked = False Then
                        dataBoleto = dtVencimento.Value.AddDays(CInt(txtDias.Text) * intContador)
                    Else
                        If intData = 1 Then
                            dataBoleto = dtVencimento.Value.ToShortDateString
                        Else
                            dataBoleto = dtVencimento.Value.AddDays(CInt(txtDias.Text) * (intData - 1))
                        End If
                    End If
                End If
            Else
                If cbVencimento.Checked = False Then
                    dataBoleto = DateAdd(DateInterval.Month, intContador, dtVencimento.Value)
                Else
                    If intData = 1 Then
                        dataBoleto = dtVencimento.Value.ToShortDateString
                    Else
                        dataBoleto = DateAdd(DateInterval.Month, intData - 1, dtVencimento.Value)
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
            'Boleto = CobreBemX.DocumentosCobranca.Add
            'Boleto.TipoDocumentoCobranca = "DM"
            'Boleto.NumeroDocumento = xPacote & " " & "PAC" & "-" & adiciona_zeros(intContador, 2) & "/" & adiciona_zeros(CInt(txtNparcelas.Text), 2)
            'Boleto.NomeSacado = ttCliente.Rows(0)("razao_social")
            'Boleto.CNPJSacado = ttCliente.Rows(0)("cnpj")
            'Boleto.EnderecoSacado = ttCliente.Rows(0)("endereco")
            'Boleto.BairroSacado = ttCliente.Rows(0)("bairro")
            'Boleto.CidadeSacado = ttCliente.Rows(0)("municipio")
            'Boleto.EstadoSacado = ttCliente.Rows(0)("uf")
            'Boleto.CepSacado = ttCliente.Rows(0)("cep").ToString
            'Boleto.DataDocumento = dtVenc.Value.ToShortDateString
            'Boleto.DataProcessamento = Now.ToShortDateString
            'Boleto.DataVencimento = dtVencBoleto.Value.ToShortDateString
            'Boleto.ValorDocumento = valor
            'Boleto.PadroesBoleto.Demonstrativo = "Referente a aquisição do pacote nº " & xPacote
            'If intProtesto > 0 Then
            'Boleto.PadroesBoleto.InstrucoesCaixa = "<br>Juros .....: 5,00 % ao mês." & _
            '"<br>Multa.... de 1,00 % após 1 dia corrido do vencimento." & _
            '"<br>Protesto...: 5 dias úteis a partir do vencimento."
            'intDiasProtesto = 5
            'Else
            'Boleto.PadroesBoleto.InstrucoesCaixa = "<br>Juros .....: 5,00 % ao mês." & _
            '"<br>Multa.... de 1,00 % após 1 dia corrido do vencimento." & _
            '"<br>Sr. caixa receber até 15 dias após o vencimento."
            'intDiasProtesto = 0
            'End If

            'CobreBemX.CalcularDadosBoletos()
            'nossonumero = Boleto.NossoNumero

            'Monta o código de barra e retira os pontos e espaços para gravação no banco de dados
            codigobarra = Boleto.CodigoBarras
            linhadigitavel = Boleto.LinhaDigitavel.ToString.Replace(".", "")
            linhadigitavel = linhadigitavel.ToString.Replace(" ", "")

            intNossoNumero = nossonumero

            'Instrução responsável por gravar as informações do boleto no banco de dados
            lancaBoleto()
            intNossoNumero = nossonumero.ToString.Substring(7, 10)
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

    Private Sub lancaBoleto()
        Dim parc As Integer = intContador
        Dim par As Int16 = CInt(txtParcelas.Text)
        Dim total As Decimal = Convert.ToDecimal(txtaPagar.Text)
        Dim intLancamento As Integer
        Dim intNumero As Integer
        Dim banco As Int16 = 1
        Dim data_lancamento As DateTime = datacaixa.retornaDataHoraServidor
        Dim data_vencimento As DateTime = dataBoleto
        Dim cod_fatura As Integer = 0
        Dim acrescimo As Double = 0.0
        Dim juros As Double = 0.0
        Dim desconto As Double = 0.0
        Dim taxas As Double = 0.0
        Dim forma_pagamento As Int16 = CInt(cbForma.SelectedValue)
        Dim parcela As Integer = CInt(txtParcelas.Text)
        Dim juros_boleto = ((2.5 / 100) * valor) / 30
        Dim manual As Boolean = False
        Dim documento As Integer = xPacote
        Dim doc As String = "Bol. " & intNossoNumero
        Dim emitente As Int16 = Conf.Filial
        Dim tipodoc As String = "PAC"
        Dim diasprotesto As Int16 = intDiasProtesto
        Dim acaocobranca As String = "01"
        Dim intUsuarioAlt As Integer = 0
        Dim envioboleto As Char = "N"

        '
        Dim strSQL As String = ""
        intLancamento = datacaixa.retornaUltimoRegistro("lancamentos", "cod_lancamento", " where id_filial_lancamento = " & Conf.Filial)
        strSQL = "INSERT INTO lancamentos(cod_lancamento,id_filial_lancamento ,id_filial,data_lancamento," &
       "cod_conta,Valor,cod_forma_pagamento,n_parcelas,n_parcela,data_vencimento,historico,doc,tipo,cod_fatura,acrescimo," &
       "juros,desconto,taxas, usuario_lanc, usuario_alt) VALUES ( " & intLancamento & "," & Conf.Filial & "," & Conf.Filial & "," & d.pdtm(datacaixa.retornaDataHoraServidor) &
       "," & 101 & "," & d.cdin(valor) & "," & forma_pagamento & "," & parcela & "," & parc &
       "," & d.Pdt(data_vencimento) & "," & d.PStr(txtHistórico.Text) & "," & d.PStr(doc) & "," & d.PStr("R") & "," & cod_fatura &
       "," & acrescimo & "," & juros & "," & desconto & "," & taxas & "," & intUsuario & "," & intUsuarioAlt & ")"
        datacaixa.grava_registros(strSQL, True)

        strSQL = "INSERT INTO lancamentos_cliente (id_filial,cod_lancamento,cod_filial_cliente,cod_cliente) VALUES(" & Conf.Filial &
            "," & intLancamento & "," & xCodFilialCliente & "," & xCod_cliente & ")"
        datacaixa.grava_registros(strSQL, True)

        intChave = datacaixa.retornaUltimoRegistro("pagamentos_credito", "cod_pagamento_credito", " where id_filial = " & Conf.Filial)
        strSQL = "INSERT INTO pagamentos_credito(cod_pagamento_credito,cod_credito,id_filial,cod_lancamento) VALUES(" &
        intChave & "," & CInt(txtCredito.Text) & "," & Conf.Filial & "," & intLancamento & ")"
        datacaixa.grava_registros(strSQL, True)


        intNumero = datacaixa.retornaUltimoRegistro("boleto", "numero", " where id_filial = " & Conf.Filial)
        strSQL = "INSERT INTO boleto (Numero,cod_lancamento,id_filial,Documento,Banco,Emitente " &
        ",Nossonumero,Barra,Digitavel,tipo_documento,bol_juros,manual,acrescimo,diasprotesto,acaocobranca,usuario_inc,usuario_alt, enviado) " &
        "VALUES(" & intNumero & "," & intLancamento & "," & Conf.Filial & "," & documento & "," & banco & "," & emitente &
        "," & d.PStr(nossonumero) & "," & d.PStr(codigobarra) & "," & d.PStr(linhadigitavel) & "," & d.PStr(tipodoc) &
        "," & d.cdin(juros_boleto) & "," & d.PStr(manual.ToString) & "," & d.cdin(acrescimo) & "," & diasprotesto & "," & d.PStr(acaocobranca) &
        "," & intUsuario & "," & intUsuarioAlt & "," & d.PStr(envioboleto) & ")"
        datacaixa.grava_registros(strSQL, True)
    End Sub



    Private Sub excluir_credito_cliente()
        Dim strSQLPacote As String = "select cod_cliente, cod_credito from credito_pacote where cod_pacote = " & xPacote & " and cod_cliente = " & xCod_cliente
        Dim intCodCliente As Integer
        Dim intCodCredito As Integer
        Dim tt As New DataTable
        'Instrução responsável por recuperar os dados de cod_credito e cod_cliente
        Try
            tt = datacaixa.retornaRegistro(strSQLPacote).Tables(0)
            intCodCredito = tt.Rows(0)("cod_credito")
            intCodCliente = tt.Rows(0)("cod_cliente").ToString
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        exclui_pagamento_credito(intCodCredito, grdRecebimento.CurrentRow.Cells(4).Value, CInt(txtFilial.Text))

        If grdRecebimento.Rows.Count = 1 Then
            datacaixa.excluir_credito_pacote(xPacote, xCod_cliente) 'Exclui o credito pacote para posterior eclusão do crediot cliente
            Dim strSQLCredito As String = "delete from credito_cliente where cod_cliente = " & intCodCliente & " and cod_credito = " & intCodCredito
            Try
                d.conecta()
                Dim cmdCredito As New SqlCommand(strSQLCredito, d.con)
                cmdCredito.ExecuteNonQuery()
                d.ComandoSQL(strSQLCredito, True)
                d.desconecta()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub


    Private Sub exclui_pagamento_credito(ByVal codcredito As Integer, ByVal codlanc As Integer, ByVal idfilial As Int16)
        Dim strSQL As String = "delete from pagamentos_credito where cod_credito = " & codcredito & " and cod_lancamento = " & codlanc &
            " and id_filial = " & idfilial
        Try
            d.conecta()
            Dim cmd As New SqlCommand(strSQL, d.con)
            cmd.ExecuteNonQuery()
            d.ComandoSQL(strSQL, True)
            d.desconecta()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub grdRec_DoubleClick(sender As System.Object, e As System.EventArgs) Handles grdRecebimento.DoubleClick
        If datacaixa.convertedata(datacaixa.retornaDataHoraServidor) <= datacaixa.convertedata(grdRecebimento.CurrentRow.Cells(5).Value) Then
            Dim i As Integer
            Dim fC As New frmCancelaLancamento
            i = grdRecebimento.CurrentRow.Index
            If MessageBox.Show("Deseja cancelar este recebimento?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                'Procedimento 23 Cancelar Recebimento Fatura
                If datacaixa.verifica_permissao_usuario(intUsuario, 23) = True Then
                    fC.ShowDialog(Me)
                    cancelar_lancamento(tb_rec.Rows(i)("cod_lancamento"), tb_rec.Rows(i)("id_filial"),
                                           intUsuario, Conf.Filial, fC.txtdesc.Text, Now)
                    If grdRecebimento.CurrentRow.Cells(6).Value = 8 Then
                        'Instruções responsáveis por indicar se o arquivo de remessa já foi ou não enviado para o banco
                        Dim strSQLAtualiza As String = "usuario_alt = " & intUsuario & ",enviado = 'S', data_envio = " & d.Pdt(Now()) & "" &
                            " where cod_lancamento = " & tb_rec.Rows(i)("cod_lancamento") & " and id_filial = " & tb_rec.Rows(i)("id_filial")
                        datacaixa.atualiza_registros("Boleto", strSQLAtualiza, True)
                    End If
                    excluir_credito_cliente()
                Else
                    MessageBox.Show("Usuário não tem permissão para cancelar Lançamentos de Fatura!", "ERROR: 23", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Else
                MessageBox.Show("Operação cancelada com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            MontaGrid()
        Else
            MessageBox.Show("Lancamento de pagamento não pode ser excluído" & Chr(13) & "data de lançamento é diferente da data atual.",
                            "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub cbForma_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbForma.SelectedIndexChanged
        If (cbForma.SelectedIndex = 0) Then
            txtParcelas.Enabled = False
            txtParcelas.Text = 1
        Else
            txtParcelas.Text = 1
            txtParcelas.Enabled = True
        End If
    End Sub

    Private Function Lista_Itens() As DataTable
        Dim strSQL As String = "select * from pacote_cliente_detalhes where cod_cliente = " &
            xCod_cliente & " and cod_filial_cliente = " & xCodFilialCliente & " and cod_pacote = " & xPacote
        Return datacaixa.retornaRegistro(strSQL).Tables(0)
    End Function

    Private Function Lista_Rec_Credito(ByVal codcredito As Integer, ByVal codfilial As Integer) As DataTable
        Dim strSQL As String = "SELECT lancamentos.*, forma_pagamento.forma_pagamento, pagamentos_credito.cod_credito FROM " &
            "lancamentos INNER JOIN forma_pagamento ON lancamentos.cod_forma_pagamento = forma_pagamento.cod_forma_pagamento INNER JOIN " &
            "pagamentos_credito ON lancamentos.cod_lancamento = pagamentos_credito.cod_lancamento AND " &
            "lancamentos.id_filial = pagamentos_credito.id_filial WHERE pagamentos_credito.id_filial = " & codfilial &
            " and pagamentos_credito.cod_credito = " & codcredito & " and lancamentos.cod_status_lancamento <> 2"
        Return datacaixa.retornaRegistro(strSQL).Tables(0)
    End Function

    Public Sub cancelar_lancamento(ByVal x_cod_lancamento As Integer, ByVal x_id_filial As Integer, ByVal x_cod_usuario As Integer,
                                        ByVal x_id_filial_canc As Integer, ByVal x_descricao As String, ByVal x_data_canc As String)
        Dim strSQL As String = ""
        Dim cod_cancelamento As Integer
        Dim trans As New objSqlTrans
        cod_cancelamento = datacaixa.retornaUltimoRegistro("cancelamento_lancamento", "cod_cancelamento", "where id_filial_cancelamento = " & x_id_filial_canc)

        strSQL = "INSERT INTO cancelamento_lancamento (cod_cancelamento,id_filial_cancelamento,cod_usuario,cod_lancamento,id_filial, " &
           "descricao,data_cancelamento) VALUES(" & cod_cancelamento & "," & x_id_filial_canc & "," & x_cod_usuario &
           "," & x_cod_lancamento & "," & x_id_filial & "," & d.PStr(x_descricao) & "," & d.Pdt(x_data_canc) & ")"
        datacaixa.grava_registros(strSQL, True)

        strSQL = "UPDATE lancamentos set cod_status_lancamento = 2, usuario_alt = " & x_cod_usuario & " WHERE cod_lancamento = " & x_cod_lancamento &
            " and id_filial_lancamento = " & x_id_filial & ""
        datacaixa.grava_registros(strSQL, True)
    End Sub

    Private Sub CarregaForma()
        FormaPag = New FormaPagamento()

        cbForma.DataSource = FormaPag.RetornaFormaPagamento()
        cbForma.DisplayMember = "DescricaoFormaPagamento"
        cbForma.ValueMember = "CodigoFormaPagamento"

    End Sub
End Class