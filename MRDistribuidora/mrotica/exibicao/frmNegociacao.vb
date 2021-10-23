Imports System.Data
Imports System.Data.SqlClient
Imports mrotica_util

Public Class frmNegociacao
    Dim tbfatura As New DataTable
    Dim d As New dados
    Public credito As New objCreditoCliente
    Dim tb_itens As New DataTable
    Dim tb_rec As New DataTable
    Public tb_Det As New DataTable
    Public novo As Boolean = False
    Dim lanc As New objPagCredito
    Dim pacote As New objPacoteCliente
    Dim conf As New config
    Dim cliente As New objCliente
    Dim user As New objUsuario
    Public xCod_cliente, xCodFilialCliente, xPacote As Integer
    Dim valor As Double
    Dim intNossoNumero As Long
    Dim intContador As Integer
    Dim acordo As New objMaster
    Public valorref As Double = 0.0
    Public intAcordo As Integer
    Dim intTotalReg As Integer
    Public intControle As Integer
    Dim intData As Integer
    Dim intImprimir As Integer = 0
    Dim intDiasProtesto As Integer
    Dim intProtesto As Integer
    Dim nossonumero As String
    Dim codigobarra As String
    Dim linhadigitavel As String
    Dim ttCliente As New DataTable
    Dim dsCliente As New DataSet
    Dim dataBoleto As Date
    Dim dtVencBoleto As New DateTimePicker
    Dim intUsuario As Integer
    Public intTipo As Int16
    Dim objWord As Microsoft.Office.Interop.Word.Application
    Dim objDoc As Microsoft.Office.Interop.Word.Document

    Private Sub frmNegociacao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Variável responsável por guardar o código do usuário que está realizando a operação
        intUsuario = acordo.retorna_codigo_usuario(frmMain.intCodigoUsuario)

        carrega_combos()
        lblTotalPago.Text = "0,00"

        'Caso o Acordo seja zero significa que se trato de um acordo novo
        If intAcordo = 0 Then
            Dim intcodAcordo As Integer
            'Recupera o último codigo do acordo registrado na tabela controle
            intcodAcordo = acordo.retornaUltimoRegistro("controle", "numeroAcordo") + 1
            txtAcordo.Text = intcodAcordo
            Dim strSQL As String = "numeroAcordo = " & intcodAcordo
            acordo.atualiza_registros("controle", strSQL, True)
        End If

        'Verifica se o acordo foi cancelado, em caso positivo as instruções seguinte dentro do bloco if será executada
        If acordo.verifica_existencia_registro("SELECT STATUS_ACORDO FROM CLIENTE_ACORDO WHERE COD_ACORDO = " & intAcordo & " AND COD_CLIENTE = " & xCod_cliente & " AND STATUS_ACORDO = 3") = True Then
            btnGerar.Enabled = False
            btnCancelar.Enabled = False
            btnDetalhes.Enabled = False
            mmNegociacao.Enabled = False
            btnComprovante.Enabled = False
            cbVencimento.Enabled = False
        End If

        'Verifica se o acordo foi fechado, em caso positivo as instruções seguinte dentro do bloco if será executada
        If acordo.verifica_existencia_registro("SELECT STATUS_ACORDO FROM CLIENTE_ACORDO WHERE COD_ACORDO = " & intAcordo & " AND COD_CLIENTE = " & xCod_cliente & " AND STATUS_ACORDO = 2") = True Then
            btnGerar.Enabled = False
            btnCancelar.Enabled = False
            mmNegociacao.Enabled = False
            btnComprovante.Enabled = False
            cbVencimento.Enabled = False
        End If

        'Coloca a taxa de juros dentro do valor padrão de 5%
        txtTaxaJuros.Text = Format(0.05, "##0.0%")

        'Dá um refresh nos dados do DataGrid
        Lista_Rec()

        'Se o o valor a pagar for maior que zero o valor será preenchido com o valor a pagar
        If CDbl(lblaPagar.Text) > 0.0 Then
            txtValor.Text = lblaPagar.Text
        End If
    End Sub

    Private Sub carrega_combos()
        Dim tb_forma As New DataTable
        d.carrega_Tabela("Select * from forma_pagamento where cod_forma_pagamento in (1,7,8)", tb_forma)
        cbForma.DataSource = tb_forma
        cbForma.ValueMember = "cod_forma_pagamento"
        cbForma.DisplayMember = "forma_pagamento"
    End Sub
    Private Sub Lista_Rec()
        Try
            'Caso o intAcordo seja maior que zero é por que o registro de acordo já existe,nesta caso vamos realizar apenas o movimento
            'de recebimento de acordo.
            If intAcordo > 0 Then
                txtAcordo.Text = adiciona_zeros(intAcordo, 5)
            End If

            tb_rec = lanc.Listar_Rec_acordo(CInt(txtAcordo.Text), conf.Filial, intTipo)

            If intTipo = 1 Then
                If tb_rec.Rows.Count = 0 Then
                    MsgBox("Registro não encontrado")
                    Me.Close()
                    Exit Sub
                End If
            End If

            If tb_rec.Rows.Count = 0 Then
                Exit Sub
            End If

            grdRec.Columns.Clear()
            grdRec.DataSource = Nothing
            grdRec.AllowUserToAddRows = False
            grdRec.AutoGenerateColumns = False

            Dim cParcelas As New DataGridViewTextBoxColumn
            With cParcelas
                .DataPropertyName = "n_parcela"
                .HeaderText = "Parcela"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Width = 60
            End With
            grdRec.Columns.Add(cParcelas)

            Dim cVenc As New DataGridViewTextBoxColumn
            With cVenc
                .DataPropertyName = "data_vencimento"
                .HeaderText = "Data Venc"
                .Width = 95
            End With
            grdRec.Columns.Add(cVenc)

            Dim cPag As New DataGridViewTextBoxColumn
            With cPag
                .DataPropertyName = "data_recebimento"
                .HeaderText = "Data Rec"
                .Width = 95
            End With
            grdRec.Columns.Add(cPag)

            Dim cForma As New DataGridViewTextBoxColumn
            With cForma
                .DataPropertyName = "forma_pagamento"
                .HeaderText = "Forma"
                .Width = 150
            End With
            grdRec.Columns.Add(cForma)

            Dim cValor As New DataGridViewTextBoxColumn
            With cValor
                .DataPropertyName = "valortotal"
                .HeaderText = "V. Parcela"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DefaultCellStyle.Format = "#,##0.00"
                .Width = 80
            End With
            grdRec.Columns.Add(cValor)

            Dim cJuros As New DataGridViewTextBoxColumn
            With cJuros
                .DataPropertyName = "juros"
                .HeaderText = "Juros"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DefaultCellStyle.Format = "#,##0.00"
                .Width = 80
            End With
            grdRec.Columns.Add(cJuros)

            Dim cDesconto As New DataGridViewTextBoxColumn
            With cDesconto
                .DataPropertyName = "desconto"
                .HeaderText = "Desconto"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DefaultCellStyle.Format = "#,##0.00"
                .Width = 80
            End With
            grdRec.Columns.Add(cDesconto)

            Dim cValorPago As New DataGridViewTextBoxColumn
            With cValorPago
                .DataPropertyName = "ValorPago"
                .HeaderText = "V. Pago"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DefaultCellStyle.Format = "#,##0.00"
                .Width = 80
            End With
            grdRec.Columns.Add(cValorPago)

            Dim cDoc As New DataGridViewTextBoxColumn
            With cDoc
                .DataPropertyName = "doc"
                .HeaderText = "Documento"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Width = 100
            End With
            grdRec.Columns.Add(cDoc)

            Dim cLanc As New DataGridViewTextBoxColumn
            With cLanc
                .DataPropertyName = "cod_lancamento"
                .HeaderText = "Lanc"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Width = 100
                .Visible = False
            End With
            grdRec.Columns.Add(cLanc)

            grdRec.DataSource = tb_rec

            For Each linha As DataGridViewRow In grdRec.Rows
                If linha.Cells(2).Value Is DBNull.Value Then
                    linha.Cells(7).Value = "0,00"
                End If
            Next

            intTotalReg = tb_rec.Rows.Count

            If intTotalReg > 0 Then
                txtFilial.Enabled = False
                txtAcordo.Enabled = False
                txtValorAcordo.Enabled = False
                txtDias.Enabled = False
                txtHistórico.Enabled = False
                txtAcrescimo.Enabled = False
                txtJuros.Enabled = False
                txtTaxas.Enabled = False
                dtVenc.Enabled = False
                cbForma.Enabled = False
                txtValor.Enabled = False
                txtNparcelas.Enabled = False
                btnGerar.Enabled = False
                btnDetalhes.Enabled = True
                txtTaxaJuros.Enabled = False
            End If

            Total()
            total_pago()

            lblCliente.Text = tb_rec.Rows(0)("cod_cliente") & " - " & tb_rec.Rows(0)("nome_cliente").ToString
            txtFilial.Text = tb_rec.Rows(0)("id_filial").ToString
            txtValorAcordo.Text = Format(CDbl(tb_rec.Rows(0)("valor").ToString) * intTotalReg, "#,##0.00")
            txtHistórico.Text = tb_rec.Rows(0)("historico").ToString

            If acordo.verifica_existencia_registro("SELECT * FROM CLIENTE_ACORDO_DET WHERE COD_ACORDO = " & CInt(txtAcordo.Text) & "") = True Then
                Dim strSQL As String = "SELECT * FROM CLIENTE_ACORDO_DET WHERE COD_ACORDO = " & CInt(txtAcordo.Text) & ""
                tb_Det = acordo.retornaRegistro(strSQL).Tables(0)
            End If

            For Each linha As DataGridViewRow In grdRec.Rows
                If linha.Cells(2).Value IsNot DBNull.Value Then
                    btnCancelar.Enabled = False
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub total_pago()
        lblTotalPago.Text = Format(CDbl(acordo.retornaValorPagoAcordoTotal(CInt(txtAcordo.Text), conf.Filial)), "#,##0.00")
        Try
            lblaPagar.Text = Format(CDbl(acordo.retornaValoraPagarAcordo(CInt(txtAcordo.Text), conf.Filial)), "#,##0.00")
        Catch ex As Exception
            ex.ToString()
        End Try
    End Sub

    Private Sub Total()
        lblTotal.Text = Format(acordo.retornaValorAcordo(CInt(txtAcordo.Text), conf.Filial), "#,##0.00")
        txtAcrescimo.Text = Format(acordo.retornaValorAcordoAcrescimo(CInt(txtAcordo.Text), conf.Filial), "#,##0.00")
        txtJuros.Text = Format(acordo.retornaValorAcordoJuros(CInt(txtAcordo.Text), conf.Filial), "#,##0.00")
        txtTaxas.Text = Format(acordo.retornaValorAcordoTaxas(CInt(txtAcordo.Text), conf.Filial), "#,##0.00")
        lblDesconto.Text = Format(acordo.retornaValorAcordoDesconto(CInt(txtAcordo.Text), conf.Filial), "#,##0.00")
    End Sub

    Private Sub lancaBoletos()
        Dim parc As Integer = 1
        Dim data As Date
        Dim conta As New objContaBanco()
        Dim CRED As New objCreditoCliente
        Dim boleto As New objBoleto(objPagamento.tipo_pagamento.credito)
        Dim par As Int16 = txtNparcelas.Text
        Dim total As Decimal = Convert.ToDecimal(txtValor.Text)
        Dim valor As Decimal = Decimal.Round(Convert.ToDecimal(txtValor.Text) / Convert.ToDecimal(par), 2)
        Dim Ult As Decimal = Convert.ToDecimal(total) - (valor * (par - 1))
        data = dtVenc.Value
        conta.filtra(conf.Filial, 1)

        While parc <= par
            boleto.novo_boleto()
            boleto.data_lancamento = acordo.retornaDataHoraServidor
            boleto.data_vencimento = data
            boleto.cod_fat_cred = credito.cod_credito
            boleto.documento = pacote.cod_pacote
            boleto.id_filial = credito.id_filial
            boleto.id_filial_lancamento = conf.Filial
            boleto.cod_conta = 101
            boleto.cod_forma_pagamento = cbForma.SelectedValue

            boleto.historico = "Boleto " & adiciona_zeros(parc, 2) &
            " de " & adiciona_zeros(par, 2) & "  do Credito " & adiciona_zeros(credito.id_filial, 4) & "-" &
            adiciona_zeros(credito.cod_credito, 6) &
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
            boleto.cod_filial_cliente = credito.cod_filial_cliente
            boleto.cod_cliente = credito.cod_cliente
            boleto.tipo_documento = "PAC"
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
    Private Sub lancaBoletoManual()
        Dim parc As Integer = intContador
        Dim conta As New objContaBanco()
        Dim par As Int16 = txtNparcelas.Text
        Dim acrescimo As Double = Format(CDbl(txtAcrescimo.Text) / par, "#,##0.00")
        Dim juros As Double = Format(CDbl(txtJuros.Text) / par, "#,##0.00")
        Dim taxas As Double = Format(CDbl(txtTaxas.Text) / par, "#,##0.00")
        Dim descontoacordo As Double = Format(CDbl(lblDesconto.Text) / par, "#,##0.00")
        Dim valor As Decimal = Format((CDbl(txtValor.Text) / par) - acrescimo - juros - taxas + descontoacordo, "#,##0.00")

        'Retorna o número do último lançamento da tabela lançamentos
        Dim intcodlanc As Integer = acordo.retornaUltimoRegistro("lancamentos", "cod_lancamento", "where id_filial_lancamento = " & conf.Filial)
        'Retorna o número último boelto da tabela boleto
        Dim intnumboleto As Integer = acordo.retornaUltimoRegistro("boleto", "numero", "where id_filial = " & conf.Filial)
        Dim intcodpagamento As Integer = acordo.retornaUltimoRegistro("pagamentos_acordo", "cod_pagamento_acordo", "where id_filial = " & conf.Filial)

        conta.filtra(1, 1)
        Dim data_lancamento As Date = acordo.retornaDataHoraServidor
        Dim data_vencimento As Date = dataBoleto
        Dim desconto As Double = 0.0
        Dim banco As Integer = 1
        Dim emitente As Integer = 1
        Dim manual As Boolean = True
        Dim intConta As Integer = 101
        Dim intFatura As Integer = 0
        Dim tipo_doc = "NEG"
        Dim tipo As String = "R"
        Dim nossonumero As String = intNossoNumero
        Dim documento As String = "Bol. " & intNossoNumero
        Dim barra As String = codigobarra
        Dim digitavel As String = linhadigitavel
        Dim codbarraacordo As String = adiciona_zeros(xCodFilialCliente, 2) & adiciona_zeros(xCod_cliente, 5) & adiciona_zeros(txtAcordo.Text, 5) & adiciona_zeros(parc, 2)
        Dim acaocobranca As String = "01"

        acordo.salva_lancamentos(intcodlanc, conf.Filial, xCodFilialCliente, acordo.retornaDataHoraServidor, intConta, valor, cbForma.SelectedValue,
        par, parc, acordo.convertedata(dataBoleto), txtHistórico.Text, documento, tipo, intFatura, 0, 0, 0, 0, intUsuario, 0)

        acordo.salva_lancamento_cliente(conf.Filial, intcodlanc, xCodFilialCliente, xCod_cliente)

        'Número 1 significa satus do pagamento acordo ativo
        acordo.salva_pagamento_acordo(intcodpagamento, CInt(txtAcordo.Text), xCodFilialCliente, intcodlanc, conf.Filial, codbarraacordo, valor, acrescimo, juros, descontoacordo, taxas)

        acordo.salva_boletos(intnumboleto, intcodlanc, conf.Filial, CInt(txtAcordo.Text), banco, emitente, nossonumero, barra, digitavel, tipo_doc, juros, manual, acrescimo, intDiasProtesto, acaocobranca, intUsuario, 0, "N")
    End Sub

    Private Sub lancaDinheiro()
        Dim parc As Integer = intContador
        Dim data As Date
        Dim conta As New objContaBanco()
        Dim par As Int16 = txtNparcelas.Text
        Dim acrescimo As Double = Format(CDbl(txtAcrescimo.Text) / par, "#,##0.00")
        Dim juros As Double = Format(CDbl(txtJuros.Text) / par, "#,##0.00")
        Dim taxas As Double = Format(CDbl(txtTaxas.Text) / par, "#,##0.00")
        Dim descontoacordo As Double = Format(CDbl(lblDesconto.Text) / par, "#,##0.00")

        valor = Format((CDbl(txtValor.Text) / par) - acrescimo - juros - taxas + descontoacordo, "#,##0.00")

        intData = intData + 1

        'Retorna o número do último lançamento da tabela lançamentos
        Dim intcodlanc As Integer = acordo.retornaUltimoRegistro("lancamentos", "cod_lancamento", "where id_filial_lancamento = " & conf.Filial)
        'Retorna o número último boelto da tabela boleto
        Dim intnumboleto As Integer = acordo.retornaUltimoRegistro("boleto", "numero", "where id_filial = " & conf.Filial)
        Dim intcodpagamento As Integer = acordo.retornaUltimoRegistro("pagamentos_acordo", "cod_pagamento_acordo", "where id_filial = " & conf.Filial)
        '
        'data = DateAdd(DateInterval.Month, intContador, dtVenc.Value)

        If CInt(txtDias.Text) > 0 Then
            If CInt(txtNparcelas.Text) = 1 Then
                If cbVencimento.Checked = False Then
                    data = dtVenc.Value.AddDays(CInt(txtDias.Text))
                Else
                    data = dtVenc.Value.ToShortDateString
                End If
            Else
                If cbVencimento.Checked = False Then
                    data = dtVenc.Value.AddDays(CInt(txtDias.Text) * intContador)
                Else
                    If intData = 1 Then
                        data = dtVenc.Value.ToShortDateString
                    Else
                        data = dtVenc.Value.AddDays(CInt(txtDias.Text) * (intData - 1))
                    End If
                End If
            End If
        Else
            If cbVencimento.Checked = False Then
                data = DateAdd(DateInterval.Month, intContador, dtVenc.Value)
            Else
                If intData = 1 Then
                    data = dtVenc.Value.ToShortDateString
                Else
                    data = DateAdd(DateInterval.Month, intData - 1, dtVenc.Value)
                End If
            End If
        End If

        'Caso o dia informado seja sábado ou domingo a data de vencimento será no dia útil seguinte.
        If data.DayOfWeek = 6 Then
            data = data.AddDays(2)
        ElseIf data.DayOfWeek = 0 Then
            data = data.AddDays(1)
        End If

        dtVencBoleto.Value = data

        Dim data_lancamento As Date = acordo.retornaDataHoraServidor
        Dim data_vencimento As Date = dtVencBoleto.Value.ToShortDateString
        Dim desconto As Double = 0.0
        Dim banco As Integer = 1
        Dim emitente As Integer = 1
        Dim manual As Boolean = True
        Dim intConta As Integer = 101
        Dim intFatura As Integer = 0
        Dim tipo_doc = "NEG"
        Dim tipo As String = "E"
        Dim documento As String = "Acordo: " & adiciona_zeros(CInt(txtAcordo.Text), 5)
        Dim codbarraacordo As String = adiciona_zeros(xCodFilialCliente, 2) & adiciona_zeros(xCod_cliente, 5) & adiciona_zeros(txtAcordo.Text, 5) & adiciona_zeros(parc, 2)

        acordo.salva_lancamentos(intcodlanc, conf.Filial, xCodFilialCliente, acordo.retornaDataHoraServidor, intConta, valor, cbForma.SelectedValue,
        par, parc, acordo.convertedata(data), txtHistórico.Text, documento, tipo, intFatura, 0, 0, 0, 0, intUsuario, 0)

        acordo.salva_lancamento_cliente(conf.Filial, intcodlanc, xCodFilialCliente, xCod_cliente)

        'Número 1 significa status do pagamento acordo ativo
        acordo.salva_pagamento_acordo(intcodpagamento, CInt(txtAcordo.Text), xCodFilialCliente, intcodlanc, conf.Filial, codbarraacordo, valor, acrescimo, juros, descontoacordo, taxas)
    End Sub


    Private Sub ReceberAcordoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ReceberAcordoToolStripMenuItem.Click
        Call grdRec_DoubleClick(sender, e)

        If quantRegistroPago() = grdRec.Rows.Count Then
            Dim strSQL As String = "status_acordo = '2' where cod_acordo = " & CInt(txtAcordo.Text) & " and cod_cliente = " & tb_rec.Rows(0)("cod_cliente")
            acordo.atualiza_registros("cliente_acordo", strSQL, True)
        End If
    End Sub

    Private Sub CancelarRecebimentoAcordoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CancelarRecebimentoAcordoToolStripMenuItem.Click
        If grdRec.CurrentRow.Cells(2).Value.ToString <> String.Empty Then
            If acordo.convertedata(acordo.retornaDataHoraServidor) = acordo.convertedata(grdRec.CurrentRow.Cells(2).Value) Then
                If MessageBox.Show("Deseja cancelar o recebimento desta parcela?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim cod_lanc As Integer = grdRec.CurrentRow.Cells(9).Value
                    Dim data As DateTime = acordo.retornaDataHoraServidor
                    Dim strSQL As String = ""
                    strSQL = "update lancamentos set data_recebimento = NULL where cod_lancamento = " & cod_lanc &
                        " and id_filial = " & xCodFilialCliente
                    Dim cmd As New SqlCommand(strSQL, d.con)
                    d.conecta()
                    Try
                        cmd.ExecuteNonQuery()
                        d.ComandoSQL(strSQL, True)
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    Finally
                        d.desconecta()
                    End Try
                Else
                    MessageBox.Show("Recebimento cancelado com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Este cancelamento não pode ser excluído, data de recebimento" & Chr(13) & "difere da data atual do caixa aberto.", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Lista_Rec()
        Else
            MessageBox.Show("Esta parcela não pode ser cancelado, pois, não há pagamento para a mesma.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        If quantRegistroPago() < grdRec.Rows.Count Then
            Dim strSQL As String = "status_acordo = '1' where cod_acordo = " & CInt(txtAcordo.Text) & " and cod_cliente = " & tb_rec.Rows(0)("cod_cliente")
            acordo.atualiza_registros("cliente_acordo", strSQL, True)
        End If
    End Sub


    Private Sub grdRec_DoubleClick(sender As System.Object, e As System.EventArgs) Handles grdRec.DoubleClick
        Dim f As New frmDetalheAcordo
        f.codlanc = grdRec.CurrentRow.Cells(9).Value
        f.data = acordo.retornaDataHoraServidor
        f.xCodFilialCliente = xCodFilialCliente
        f.intAcordo = CInt(txtAcordo.Text)
        f.dtVencimento = grdRec.CurrentRow.Cells(1).Value
        If grdRec.CurrentRow.Cells(2).Value.ToString = "" Then
            f.dtRecebimento = acordo.retornaDataHoraServidor
        Else
            f.dtRecebimento = grdRec.CurrentRow.Cells(2).Value
            f.btnReceber.Enabled = False
            f.txtDesconto.Enabled = False
        End If
        f.valor = Format(acordo.retornaValorAcordo(CInt(txtAcordo.Text), conf.Filial) / intTotalReg, "#,##0.00")
        f.ShowDialog()
        Lista_Rec()
    End Sub

    Private Sub txtTaxas_Leave(sender As System.Object, e As System.EventArgs) Handles txtTaxas.Leave
        Dim valor As Double = Format(CDbl(lblTotal.Text) + CDbl(txtTaxas.Text) - CDbl(lblDesconto.Text), "#,##0.00")
        lblaPagar.Text = Format(valor, "#,##0.00")
    End Sub


    Private Sub grdRec_Click(sender As System.Object, e As System.EventArgs) Handles grdRec.Click
        If grdRec.Rows.Count > 0 Then
            txtNparcelas.Text = CInt(grdRec.CurrentRow.Cells(0).Value)
            dtVenc.Text = grdRec.CurrentRow.Cells(1).Value
            cbForma.Text = grdRec.CurrentRow.Cells(3).Value
            txtValor.Text = Format(grdRec.CurrentRow.Cells(4).Value, "#,##0.00")
        End If
    End Sub

    Private Sub btnImprimir_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub txtValor_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtValor.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "," And Not e.KeyChar = "." Then
            e.Handled = True
            MessageBox.Show("Campo só aceita valor monetário.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txtNparcelas_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNparcelas.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack Then
            e.Handled = True
            MessageBox.Show("Campo só aceita valor númerico.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txtDias_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtDias.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack Then
            e.Handled = True
            MessageBox.Show("Campo só aceita valor númerico.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txtTaxas_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTaxas.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "," And Not e.KeyChar = "." Then
            e.Handled = True
            MessageBox.Show("Campo só aceita valor monetário.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub



    Private Sub montaBoleto()
        'Dim CobreBemX As CobreBemX.ContaCorrente
        'Dim Boleto As Object

        'Inicializa o objeto CobreBemX
        'CobreBemX = New CobreBemX.ContaCorrente

        'Instruções por montarem o cabeçalho padrão para emissão do boleto
        'CobreBemX.ArquivoLicenca = My.Computer.FileSystem.CurrentDirectory & "\63882898000199-001-17-7.conf"
        'CobreBemX.CodigoAgencia = "3074-0"
        'CobreBemX.NumeroContaCorrente = "00060082-2"
        'CobreBemX.CodigoCedente = "1178558"
        'CobreBemX.InicioNossoNumero = "0000000001"
        'CobreBemX.FimNossoNumero = "9999999999"
        'CobreBemX.ProximoNossoNumero = acordo.retornaUltimoRegistro("Controle", "nossonumero")
        'CobreBemX.LocalPagamento = "Pagável em qualquer banco até o vencimento."
        'CobreBemX.OutroDadoConfiguracao1 = "019"
        'CobreBemX.PadroesBoleto.PadroesBoletoImpresso.ArquivoLogotipo = My.Computer.FileSystem.CurrentDirectory & "\Imagens\logo.jpg"
        'CobreBemX.PadroesBoleto.PadroesBoletoImpresso.CaminhoImagensCodigoBarras = My.Computer.FileSystem.CurrentDirectory & "\Imagens\"
        'CobreBemX.PadroesBoleto.PadroesBoletoImpresso.LayoutBoleto = "PadraoReciboPersonalizado"
        'CobreBemX.PadroesBoleto.PadroesBoletoImpresso.HTMLReciboPersonalizado = txtTextoBoleto.Text
        'CobreBemX.PadroesBoleto.PadroesBoletoImpresso.MargemSuperior = 20

        'Valor que será registrado no Boleto
        Dim valordif As Double
        Dim valorreal As Double
        Dim valorcentavo As Double

        'Função responsável por retorna os dados do cliente como por exemplo: Nome, Endereço, CEP e etc.
        carregaDadosCliente(xCod_cliente)

        'Cria um loop para criar a quantidade de boelto especificada de acordo com o número de parcelas
        For intContador = 1 To CInt(txtNparcelas.Text)
            valor = CDbl(txtValor.Text) / CInt(txtNparcelas.Text)
            'valor = Format(CDbl(txtValor.Text) / CInt(txtNparcelas.Text), "#,##0.00")

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
            'Boleto = CobreBemX.DocumentosCobranca.Add
            'Boleto.TipoDocumentoCobranca = "DM"
            'Boleto.NumeroDocumento = CInt(txtAcordo.Text) & " " & "NEG" & "-" & adiciona_zeros(intContador, 2) & "/" & adiciona_zeros(CInt(txtNparcelas.Text), 2)
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
            'Boleto.PadroesBoleto.Demonstrativo = txtHistórico.Text
            'If intProtesto > 0 Then
            'Boleto.PadroesBoleto.InstrucoesCaixa = "<br>Juros .....: 5,00 % ao mês." & _
            '   "<br>Multa.... de 1,00 % após 1 dia corrido do vencimento" & _
            '  "<br>Protesto...: 5 dias úteis a partir do vencimento"
            'intDiasProtesto = 5
            'Else
            'Boleto.PadroesBoleto.InstrucoesCaixa = "<br>Juros .....: 5,00 % ao mês." & _
            '   "<br>Multa.... de 1,00 % após 1 dia corrido do vencimento." & _
            '  "<br>Sr. caixa receber até 15 dias após o vencimento."
            'intDiasProtesto = 0
            'End If

            'CobreBemX.CalcularDadosBoletos()
            'nossonumero = Boleto.NossoNumero

            'Monta o código de barra e retira os pontos e espaços para gravação no banco de dados
            'codigobarra = Boleto.CodigoBarras
            'linhadigitavel = Boleto.LinhaDigitavel.ToString.Replace(".", "")
            'linhadigitavel = linhadigitavel.ToString.Replace(" ", "")

            'intNossoNumero = nossonumero
            'Instrução responsável por gravar as informações do boleto no banco de dados
            'lancaBoletoManual()
            'intNossoNumero = nossonumero.ToString.Substring(7, 10)
            'Atualiza a sequencia do nosso número para gravar o próximo nosso número
            'acordo.atualiza_registros("Controle", "nossonumero = " & intNossoNumero, False)
        Next

        'Se a váriavel intImprimir for igual a 1 gera o boleto bancário para impressão, caso seja igua a 0 o boelto não será gerado
        'impressão nesse momento, podendo ser impresso depois no menu Financeiro - Imprime Boleto
        'If intImprimir = 1 Then
        'CobreBemX.ImprimeBoletos()
        'End If

        'Limpa o objeto CobreBemX
        'CobreBemX = Nothing
        '  intData = 0
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

    'Rotina responsável por verificar se a quantidade total de registro é igual a quantidade de registro que já foram pagos
    Private Function quantRegistroPago() As Int16
        Dim intContador As Int16
        For Each linha As DataGridViewRow In grdRec.Rows
            If linha.Cells(2).Value.ToString <> String.Empty Then
                intContador = intContador + 1
            End If
        Next
        Return intContador
    End Function


    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        If acordo.verifica_existencia_registro("SELECT STATUS_ACORDO FROM CLIENTE_ACORDO WHERE COD_ACORDO = " & intAcordo & " AND COD_CLIENTE = " & xCod_cliente) = False Then
            MessageBox.Show("Acordo não pertence a este cliente. Por tanto não pode ser cancelado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If MessageBox.Show("Deseja cancelar este acordo?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            For Each linha As DataRow In tb_Det.Rows
                Dim strSQLAtualizaStatus As String = "cod_status_lancamento = 1, data_recebimento = NULL " &
                    "where cod_lancamento = " & CInt(linha.Item(0).ToString) & " and id_filial = " & CInt(linha.Item(1).ToString)
                acordo.atualiza_registros("Lancamentos", strSQLAtualizaStatus, True)
                'acordo.atualiza_status_lancamentos(CInt(linha.Item(0).ToString), CInt(linha.Item(1).ToString), 1)
                Dim strSQL As String = "WHERE COD_ACORDO = " & CInt(txtAcordo.Text) & ""
                acordo.excluir_registros("cliente_acordo_det", strSQL, True)
            Next

            For Each linhacan As DataGridViewRow In grdRec.Rows
                acordo.atualiza_status_lancamentos(CInt(linhacan.Cells(9).Value), CInt(txtFilial.Text), 2)
            Next

            MessageBox.Show("Acordo cancelado com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim strSQLAtualiza As String = "STATUS_ACORDO = 3 WHERE COD_ACORDO = " & CInt(txtAcordo.Text) & " AND COD_CLIENTE = " & xCod_cliente
            acordo.atualiza_registros("cliente_acordo", strSQLAtualiza, True)

            If acordo.verifica_existencia_registro("SELECT STATUS_ACORDO FROM CLIENTE_ACORDO WHERE COD_ACORDO = " & intAcordo & " AND COD_CLIENTE = " & xCod_cliente & " AND STATUS_ACORDO = 3") = True Then
                btnGerar.Enabled = False
                btnCancelar.Enabled = False
                mmNegociacao.Enabled = False
                btnComprovante.Enabled = False
                cbVencimento.Enabled = False
            End If
        Else
            MessageBox.Show("Operação cancelada com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnGerar_Click(sender As System.Object, e As System.EventArgs) Handles btnGerar.Click
        If txtNparcelas.Text = String.Empty Then
            MessageBox.Show("Número de parcela(s) precisa ser informada.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNparcelas.Text = 1
            Exit Sub
        End If

        If txtDias.Text = String.Empty Then
            txtDias.Text = 0
            Exit Sub
        End If

        If txtValor.Text <> String.Empty Then
            If cbForma.SelectedValue = 8 Then
                If acordo.convertedata(dtVenc.Value.ToShortDateString) < acordo.convertedata(acordo.retornaDataHoraServidor) Then
                    MessageBox.Show("Data de vencimento não pode ser inferior a data atual.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                If acordo.convertedata(dtVenc.Value.ToShortDateString) = acordo.convertedata(acordo.retornaDataHoraServidor) Then
                    MessageBox.Show("Data de vencimento não pode ser igual a data atual.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If

            If cbForma.SelectedValue = 1 Or cbForma.SelectedValue = 7 Then
                If acordo.convertedata(dtVenc.Value.ToShortDateString) < acordo.convertedata(acordo.retornaDataHoraServidor) Then
                    MessageBox.Show("Data de vencimento não pode ser inferior a data atual.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If

            If CDbl(txtValor.Text) = CDbl(lblaPagar.Text) Then
                If MessageBox.Show("Deseja fechar este acordo para este cliente?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    acordo.salva_acordo(CInt(txtAcordo.Text), xCodFilialCliente, xCod_cliente, acordo.retornaDataHoraServidor, "1", intUsuario)

                    If cbForma.SelectedValue = 1 Or cbForma.SelectedValue = 7 Then
                        strTipo = "Dinheiro"
                        For intContador = 1 To CInt(txtNparcelas.Text)
                            lancaDinheiro()
                        Next
                    End If

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

                    Lista_Rec()

                    For Each linha As DataRow In tb_Det.Rows
                        acordo.inseri_Detalhe_Acordo(CInt(linha.Item(0).ToString), CInt(linha.Item(1).ToString), CInt(txtAcordo.Text),
                                                     CInt(linha.Item(2).ToString), linha.Item(3).ToString)
                        acordo.atualiza_status_lancamentos(CInt(linha.Item(0).ToString), CInt(linha.Item(1).ToString), 3)
                        Dim strSQL As String = "data_recebimento = " & d.Pdt(acordo.retornaDataHoraServidor) & " where cod_lancamento = " & linha.Item(0).ToString &
                            " and id_filial = " & linha.Item(1).ToString
                        acordo.atualiza_registros("Lancamentos", strSQL, True)
                    Next
                    intAcordo = CInt(txtAcordo.Text)
                Else
                    MessageBox.Show("Acordo cancelado com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("O Campo valor não pode ser diferente do campo a pagar!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("O Campo valor não pode ser nulo!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnComprovante_Click(sender As System.Object, e As System.EventArgs) Handles btnComprovante.Click
        Dim f As New frmRpt
        Dim r As New rptReciboAcordo
        r.tRec = lanc.Listar_Rec_acordo(CInt(txtAcordo.Text), conf.Filial)
        r.DataSource = r.tRec
        f.Relat(r)
        f.ShowDialog(Me)
        f.Dispose()
        Me.Close()
    End Sub


    Private Sub preencheDados(ByVal cabecalho As String, ByVal dados As String)
        With objWord.Selection.Find
            .ClearFormatting()
            .Text = cabecalho
            '.Replacement.Text = dados
            .Format = False
            .MatchCase = False
            .MatchWholeWord = False
            .MatchSoundsLike = False
            .MatchAllWordForms = False
            While .Execute
                Forward = True
                objWord.Selection.Select()
                Clipboard.SetDataObject(dados)
                objWord.Selection.Paste()
            End While
        End With
        Clipboard.Clear()
        Clipboard.SetText(dados)
        Clipboard.Clear()
    End Sub

    Private Sub btnDetalhes_Click(sender As System.Object, e As System.EventArgs) Handles btnDetalhes.Click
        If MessageBox.Show("Deseja gerar o contrata do acordo para este cliente?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            objWord = New Microsoft.Office.Interop.Word.Application
            objDoc = objWord.Documents.Open(My.Computer.FileSystem.CurrentDirectory & "\Acordo.docx")

            Dim strSQL As String = "select * from cliente_acordo_det where cod_acordo = " & CInt(txtAcordo.Text) & " and id_filial = " & CInt(txtFilial.Text)
            Dim ttAcordoDet As New DataTable
            ttAcordoDet = acordo.retornaRegistro(strSQL).Tables(0)
            Dim ttLancamento As New DataTable

            Dim strDataAcordo As String = "Select data from cliente_acordo where cod_acordo = " & CInt(txtAcordo.Text) & " and cod_cliente = " & tb_rec.Rows(0)("cod_cliente").ToString
            Dim ttData As New DataTable
            ttData = acordo.retornaRegistro(strDataAcordo).Tables(0)

            Dim dtEmissao, dtVencimento, tipoDoc, intDocumento, strDias, strValor, strMulta, strTeste, strMultaTotal, strJuros, strJurosTot, strTotal, strValTot, _
                strMontante, strNParc, dtDataParc, dtVencAcordo, strTotalAcordo, strForma, intCodAcordo, strDesc, strDescTotal, strTotalGeral, strSoma As String

            For i = 0 To ttAcordoDet.Rows.Count - 1
                Dim strSQLLanc As String = "select lancamentos.data_lancamento, lancamentos.data_vencimento, lancamentos.data_recebimento," & _
                    "isnull(lancamentos.Valor,0)+isnull(Pagamentos_acordo.acrescimo+Pagamentos_acordo.taxas+Pagamentos_acordo.juros-Pagamentos_acordo.desconto,0) as valor, " & _
                    "boleto.tipo_documento, boleto.Nossonumero, boleto.documento, isnull(Pagamentos_acordo.cod_acordo,0) as cod_acordo, " & _
                    "DATEDIFF(DAY,data_vencimento," & d.Pdt(ttData.Rows(0)("data")) & ") as dias, " & _
                    "round((((isnull(lancamentos.Valor,0)+isnull(Pagamentos_acordo.acrescimo+Pagamentos_acordo.taxas+Pagamentos_acordo.juros-Pagamentos_acordo.desconto,0)) * 1 / 100)),2) as multa," & _
                    "round((((isnull(lancamentos.Valor,0)+isnull(Pagamentos_acordo.acrescimo+Pagamentos_acordo.taxas+Pagamentos_acordo.juros-Pagamentos_acordo.desconto,0)) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento," & d.Pdt(ttData.Rows(0)("data")) & "))),2) as juros," & _
                    "round((isnull(lancamentos.Valor,0)+isnull(Pagamentos_acordo.acrescimo+Pagamentos_acordo.taxas+Pagamentos_acordo.juros-Pagamentos_acordo.desconto,0) + " & _
                    "((isnull(lancamentos.Valor,0)+isnull(Pagamentos_acordo.acrescimo+Pagamentos_acordo.taxas+Pagamentos_acordo.juros-Pagamentos_acordo.desconto,0)) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento," & d.Pdt(ttData.Rows(0)("data")) & ")) + " & _
                    "((isnull(lancamentos.Valor,0)+isnull(Pagamentos_acordo.acrescimo+Pagamentos_acordo.taxas+Pagamentos_acordo.juros-Pagamentos_acordo.desconto,0)) * 1 / 100)),2) as total, " & _
                    "round((isnull(lancamentos.Valor,0)+isnull(Pagamentos_acordo.acrescimo+Pagamentos_acordo.taxas+ Pagamentos_acordo.juros-Pagamentos_acordo.desconto,0) +  " & _
                    "((isnull(lancamentos.Valor,0)+isnull(Pagamentos_acordo.acrescimo+Pagamentos_acordo.taxas+Pagamentos_acordo.juros-Pagamentos_acordo.desconto,0)) * 1 / 100)),2) as totalvalormulta from " & _
                    "lancamentos left join boleto on boleto.cod_lancamento = lancamentos.cod_lancamento and boleto.id_filial = lancamentos.id_filial " & _
                    "left join Pagamentos_acordo on Pagamentos_acordo.cod_lancamento = lancamentos.cod_lancamento and Pagamentos_acordo.id_filial = lancamentos.id_filial " & _
                    "where lancamentos.cod_lancamento = " & ttAcordoDet.Rows(i)("cod_lancamento") & " and lancamentos.id_filial = " & ttAcordoDet.Rows(i)("id_filial")
                ttLancamento = acordo.retornaRegistro(strSQLLanc).Tables(0)
                dtEmissao = dtEmissao & FormatDateTime(ttLancamento.Rows(0)("data_lancamento"), DateFormat.ShortDate) & vbCrLf
                dtVencimento = dtVencimento & FormatDateTime(ttLancamento.Rows(0)("data_vencimento"), DateFormat.ShortDate) & vbCrLf
                strTipo = strTipo & ttLancamento.Rows(0)("tipo_documento") & vbCrLf
                intDocumento = intDocumento & ttLancamento.Rows(0)("documento") & vbCrLf
                intCodAcordo = intCodAcordo & ttLancamento.Rows(0)("cod_acordo") & vbCrLf

                If ttLancamento.Rows(0)("dias") > 0 Then
                    strDias = strDias & ttLancamento.Rows(0)("dias") & vbCrLf
                Else
                    strDias = strDias & 0 & vbCrLf
                End If

                strValor = strValor & Format(ttLancamento.Rows(0)("valor"), "#,##0.00") & vbCrLf

                strMulta = strMulta & Format(ttLancamento.Rows(0)("multa"), "#,##0.00") & vbCrLf

                strTeste = Format(ttLancamento.Rows(0)("totalvalormulta"), "#,##0.00")

                strMultaTotal = Format(CDbl(strMultaTotal) + CDbl(ttLancamento.Rows(0)("multa")), "#,##0.00")

                If ttLancamento.Rows(0)("juros") > 0 Then
                    strJuros = strJuros & Format(ttLancamento.Rows(0)("juros"), "#,##0.00") & vbCrLf
                Else
                    strJuros = strJuros & 0.0 & vbCrLf
                End If

                If ttLancamento.Rows(0)("juros") > 0 Then
                    strJurosTot = Format(CDbl(strJurosTot) + CDbl(ttLancamento.Rows(0)("juros")), "#,##0.00")
                Else
                    strJurosTot = strJurosTot + 0
                End If

                If ttLancamento.Rows(0)("juros") > 0 Then
                    strTotal = strTotal & Format(ttLancamento.Rows(0)("total"), "#,##0.00") & vbCrLf
                Else
                    strTotal = strTotal & strTeste & vbCrLf
                End If

                strValTot = Format(CDbl(strValTot) + CDbl(ttLancamento.Rows(0)("valor")), "#,##0.00")

                If ttLancamento.Rows(0)("juros") > 0 Then
                    strMontante = Format(CDbl(strMontante) + CDbl(ttLancamento.Rows(0)("total")), "#,##0.00")
                Else
                    strMontante = Format(CDbl(strMontante) + CDbl(ttLancamento.Rows(0)("valor") + CDbl(ttLancamento.Rows(0)("multa"))), "#,##0.00")
                End If

                If ttLancamento.Rows(0)("juros") > 0 Then
                    strTotalGeral = Format(CDbl(strTotalGeral) + CDbl(ttLancamento.Rows(0)("total")), "#,##0.00")
                End If
            Next


            For j = 0 To tb_rec.Rows.Count - 1
                strNParc = strNParc & tb_rec.Rows(j)("n_parcela") & vbCrLf
                dtDataParc = dtDataParc & FormatDateTime(tb_rec.Rows(j)("data_lancamento"), DateFormat.ShortDate) & vbCrLf
                dtVencAcordo = dtVencAcordo & FormatDateTime(tb_rec.Rows(j)("data_vencimento"), DateFormat.ShortDate) & vbCrLf
                strTotalAcordo = strTotalAcordo & Format(tb_rec.Rows(j)("valortotal"), "#,##0.00") & vbCrLf
                strForma = strForma & tb_rec.Rows(j)("forma_pagamento") & vbCrLf
                strDesc = Format(CDbl(strDesc) + CDbl(tb_rec.Rows(j)("descacordo")), "#,##0.00")
                strDescTotal = Format(CDbl(strDescTotal) + CDbl(tb_rec.Rows(j)("descacordo")), "#,##0.00")
                strSoma = Format(CDbl(strSoma) + CDbl(tb_rec.Rows(j)("valortotal")), "#,##0.00")
            Next


            preencheDados("@devedor", tb_rec.Rows(0)("razao_social").ToString)
            preencheDados("@cnpj", tb_rec.Rows(0)("cnpj").ToString)
            preencheDados("@inscestadual", tb_rec.Rows(0)("ie").ToString)
            preencheDados("@endereco", tb_rec.Rows(0)("endereco").ToString)
            preencheDados("@numero", tb_rec.Rows(0)("numero").ToString)
            preencheDados("@bairro", tb_rec.Rows(0)("bairro").ToString)
            preencheDados("@cidade", tb_rec.Rows(0)("municipio").ToString)
            preencheDados("@cep", tb_rec.Rows(0)("cep").ToString)
            preencheDados("@uf", tb_rec.Rows(0)("uf").ToString)
            preencheDados("@data", FormatDateTime(acordo.retornaDataHoraServidor(), DateFormat.ShortDate))
            preencheDados("@montante", strMontante)
            preencheDados("@extenso", NumeroToExtenso(CDbl(strMontante)))
            preencheDados("@descmonte", strDescTotal)
            preencheDados("@extdesc", NumeroToExtenso(CDbl(strDescTotal)))
            preencheDados("@acordomonte", strSoma)
            preencheDados("@extacordo", NumeroToExtenso(CDbl(strSoma)))
            preencheDados("@emissao", dtEmissao.ToString)
            preencheDados("@vencimento", dtVencimento.ToString)
            preencheDados("@tipodoc", strTipo.ToString)
            preencheDados("@documento", intDocumento.ToString)
            preencheDados("@doc", intCodAcordo.ToString)
            preencheDados("@diasatraso", strDias.ToString)
            preencheDados("@valor", strValor.ToString)
            preencheDados("@multa", strMulta.ToString)
            preencheDados("@juros", strJuros.ToString)
            preencheDados("@total", strTotal.ToString)
            preencheDados("@valtot", strValTot)
            preencheDados("@multot", strMultaTotal)
            preencheDados("@jurotot", strJurosTot)
            preencheDados("@sub", strMontante)
            preencheDados("@desconto", strDesc)
            preencheDados("@geral", Format(CDbl(strMontante) - CDbl(strDesc), "#,##0.00"))
            preencheDados("@nparcela", strNParc.ToString)
            preencheDados("@dacordo", dtDataParc.ToString)
            preencheDados("@vacordo", dtVencAcordo.ToString)
            preencheDados("@forma", strForma.ToString)
            preencheDados("@vlacordo", strTotalAcordo.ToString)
            preencheDados("@soma", strSoma)
            preencheDados("@escrita", acordo.dataPorExtenso())
            preencheDados("@assinatura", tb_rec.Rows(0)("razao_social").ToString)
            objWord.ActiveDocument.SaveAs(My.Computer.FileSystem.SpecialDirectories.Desktop & "\Acordo_" & CInt(txtAcordo.Text) & ".docx")
            objWord.Quit()
            objWord = Nothing

            'Dim documento As New Document
            'documento.LoadFromFile(My.Computer.FileSystem.CurrentDirectory & "\AcordoCopia.docx")
            'documento.SaveToFile(My.Computer.FileSystem.SpecialDirectories.Desktop & "\Acordo_" & CInt(txtAcordo.Text) & ".pdf", FileFormat.PDF)
            MessageBox.Show("Contrato gerado com sucesso na área de trabalho do computador.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub



    '

    Public Function NumeroToExtenso(ByVal number As Decimal) As String
        Dim cent As Integer
        Try
            ' se for =0 retorna 0 reais
            If number = 0 Then
                Return "Zero Reais"
            End If
            ' Verifica a parte decimal, ou seja, os centavos
            cent = Decimal.Round((number - Int(number)) * 100, MidpointRounding.ToEven)
            ' Verifica apenas a parte inteira
            number = Int(number)
            ' Caso existam centavos
            If cent > 0 Then
                ' Caso seja 1 não coloca "Reais" mas sim "Real"
                If number = 1 Then
                    Return "Um Real e " + getDecimal(cent) + "centavos"
                    ' Caso o valor seja inferior a 1 Real
                ElseIf number = 0 Then
                    Return getDecimal(cent) + "centavos"
                Else
                    Return getInteger(number) + "Reais e " + getDecimal(cent) + "centavos"
                End If
            Else
                ' Caso seja 1 não coloca "Reais" mas sim "Real"
                If number = 1 Then
                    Return "Um Real"
                Else
                    Return getInteger(number) + "Reais"
                End If
            End If
        Catch ex As Exception
            Return ""
        End Try
    End Function
    ''' <summary>
    ''' Função auxiliar - Parte decimal a converter
    ''' </summary>
    ''' <param name="number">Parte decimal a converter</param>
    Public Function getDecimal(ByVal number As Byte) As String
        Try
            Select Case number
                Case 0
                    Return ""
                Case 1 To 19
                    Dim strArray() As String = _
                       {"Um", "Dois", "Três", "Quatro", "Cinco", "Seis", _
                        "Sete", "Oito", "Nove", "Dez", "Onze", _
                        "Doze", "Treze", "Quatorze", "Quinze", _
                        "Dezesseis", "Dezessete", "Dezoito", "Dezenove"}
                    Return strArray(number - 1) + " "
                Case 20 To 99
                    Dim strArray() As String = _
                        {"Vinte", "Trinta", "Quarenta", "Cinquenta", _
                        "Sessenta", "Setenta", "Oitenta", "Noventa"}
                    If (number Mod 10) = 0 Then
                        Return strArray(number \ 10 - 2) + " "
                    Else
                        Return strArray(number \ 10 - 2) + " e " + getDecimal(number Mod 10) + " "
                    End If
                Case Else
                    Return ""
            End Select
        Catch ex As Exception
            Return ""
        End Try
    End Function
    ''' <summary>
    ''' Função auxiliar - Parte inteira a converter
    ''' </summary>
    ''' <param name="number">Parte inteira a converter</param>
    Public Function getInteger(ByVal number As Decimal) As String
        Try
            number = Int(number)
            Select Case number
                Case Is < 0
                    Return "-" & getInteger(-number)
                Case 0
                    Return ""
                Case 1 To 19
                    Dim strArray() As String = _
                        {"Um", "Dois", "Três", "Quatro", "Cinco", "Seis", _
                        "Sete", "Oito", "Nove", "Dez", "Onze", "Doze", _
                        "Treze", "Quatorze", "Quinze", "Dezesseis", _
                        "Dezessete", "Dezoito", "Dezenove"}
                    Return strArray(number - 1) + " "
                Case 20 To 99
                    Dim strArray() As String = _
                        {"Vinte", "Trinta", "Quarenta", "Cinquenta", _
                        "Sessenta", "Setenta", "Oitenta", "Noventa"}
                    If (number Mod 10) = 0 Then
                        Return strArray(number \ 10 - 2)
                    Else
                        Return strArray(number \ 10 - 2) + " e " + getInteger(number Mod 10)
                    End If
                Case 100
                    Return "Cem"
                Case 101 To 999
                    Dim strArray() As String = _
                           {"Cento", "Duzentos", "Trezentos", "Quatrocentos", "Quinhentos", _
                           "Seiscentos", "Setecentos", "Oitocentos", "Novecentos"}
                    If (number Mod 100) = 0 Then
                        Return strArray(number \ 100 - 1) + " "
                    Else
                        Return strArray(number \ 100 - 1) + " e " + getInteger(number Mod 100)
                    End If
                Case 1000 To 1999
                    Select Case (number Mod 1000)
                        Case 0
                            Return "Mil"
                        Case Is <= 100
                            Return "Mil e " + getInteger(number Mod 1000)
                        Case Else
                            Return "Mil, " + getInteger(number Mod 1000)
                    End Select
                Case 2000 To 999999
                    Select Case (number Mod 1000)
                        Case 0
                            Return getInteger(number \ 1000) & "Mil"
                        Case Is <= 100
                            Return getInteger(number \ 1000) & "Mil e " & getInteger(number Mod 1000)
                        Case Else
                            Return getInteger(number \ 1000) & "Mil, " & getInteger(number Mod 1000)
                    End Select
                Case 1000000 To 1999999
                    Select Case (number Mod 1000000)
                        Case 0
                            Return "Um Milhão"
                        Case Is <= 100
                            Return getInteger(number \ 1000000) + "Milhão e " & getInteger(number Mod 1000000)
                        Case Else
                            Return getInteger(number \ 1000000) + "Milhão, " & getInteger(number Mod 1000000)
                    End Select
                Case 2000000 To 999999999
                    Select Case (number Mod 1000000)
                        Case 0
                            Return getInteger(number \ 1000000) + " Milhões"
                        Case Is <= 100
                            Return getInteger(number \ 1000000) + "Milhões e " & getInteger(number Mod 1000000)
                        Case Else
                            Return getInteger(number \ 1000000) + "Milhões, " & getInteger(number Mod 1000000)
                    End Select
                Case 1000000000 To 1999999999
                    Select Case (number Mod 1000000000)
                        Case 0
                            Return "Um Bilhão"
                        Case Is <= 100
                            Return getInteger(number \ 1000000000) + "Bilhão e " + getInteger(number Mod 1000000000)
                        Case Else
                            Return getInteger(number \ 1000000000) + "Bilhão, " + getInteger(number Mod 1000000000)
                    End Select
                Case Else
                    Select Case (number Mod 1000000000)
                        Case 0
                            Return getInteger(number \ 1000000000) + " Bilhões"
                        Case Is <= 100
                            Return getInteger(number \ 1000000000) + "Bilhões e " + getInteger(number Mod 1000000000)
                        Case Else
                            Return getInteger(number \ 1000000000) + "Bilhões, " + getInteger(number Mod 1000000000)
                    End Select
            End Select
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Private Sub txtTaxaJuros_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtTaxaJuros.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Dim taxa As Double = CDbl(txtTaxaJuros.Text.Replace("%", "")) / 100
                If (taxa * 100) >= 1 And (taxa * 100) <= 5 Then
                    Dim juros As Double = CDbl(txtJuros.Text)
                    Dim taxajuros As Double = CDbl(txtTaxaJuros.Text.Replace("%", ""))
                    Dim resultado As Double = (juros / 5) * taxajuros
                    Dim desconto As Double = juros - resultado
                    lblDesconto.Text = Format(desconto, "#,##0.00")
                    txtTaxaJuros.Text = Format(taxa, "##0.0%")
                    calcDesconto()
                    lblJuros.Text = Format(CDbl(txtJuros.Text) - CDbl(lblDesconto.Text), "#,##0.00")
                    If (taxa * 100) = 5 Then
                        lblJuros.Text = Format(0.0, "#,##0.00")
                    End If
                Else
                    MessageBox.Show("Taxa de juros não pode ser menor que 1% ou maior que 5%", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
        End Select
    End Sub

    Private Sub txtTaxaJuros_Leave(sender As System.Object, e As System.EventArgs) Handles txtTaxaJuros.Leave
        Dim taxa As Double = CDbl(txtTaxaJuros.Text.Replace("%", "")) / 100
        If (taxa * 100) >= 1 And (taxa * 100) <= 5 Then
            Dim juros As Double = CDbl(txtJuros.Text)
            Dim taxajuros As Double = CDbl(txtTaxaJuros.Text.Replace("%", ""))
            Dim resultado As Double = (juros / 5) * taxajuros
            Dim desconto As Double = juros - resultado
            lblDesconto.Text = Format(desconto, "#,##0.00")
            txtTaxaJuros.Text = Format(taxa, "##0.0%")
            calcDesconto()
            lblJuros.Text = Format(CDbl(txtJuros.Text) - CDbl(lblDesconto.Text), "#,##0.00")
            If (taxa * 100) = 5 Then
                lblJuros.Text = Format(0.0, "#,##0.00")
            End If
        Else
            MessageBox.Show("Taxa de juros não pode ser menor que 1% ou maior que 5%", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub calcDesconto()
        Dim valor As Double = Format(CDbl(lblTotal.Text) + CDbl(txtTaxas.Text) - CDbl(lblDesconto.Text), "#,##0.00")
        lblaPagar.Text = Format(valor, "#,##0.00")
        txtValor.Text = lblaPagar.Text
    End Sub

    Private Sub frmNegociacao_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        intMarcaDesc = 1
    End Sub
End Class