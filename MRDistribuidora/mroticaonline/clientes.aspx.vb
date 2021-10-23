Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.Configuration


Public Class cliente
    Inherits System.Web.UI.Page

    Dim classe As New Classeweb
    Dim lblCodigoPromotor As Integer

    Public Sub combos()
        Dim tt As New DataTable

        Dim strSQLCidade As String = "Select * from cidades order by cidade,uf"
        classe.carrega_Tabela(strSQLCidade, tt)
        cbCidade.DataTextField = "cidade"
        cbCidade.DataValueField = "codigo"
        cbCidade.DataSource = tt
        cbCidade.DataBind()

        Dim SQL As String = "Select * from promotor ORDER by cod_promotor"
        classe.carrega_Tabela(SQL, tt)
        dbPromotor.DataTextField = "promotor"
        dbPromotor.DataValueField = "cod_promotor"
        dbPromotor.DataSource = tt
        dbPromotor.DataBind()

        cbTipoCliente.DataTextField = "tipo_cliente"
        cbTipoCliente.DataValueField = "cod_tipo_cliente"
        cbTipoCliente.DataSource = classe.tb_tipo_cliente
        cbTipoCliente.DataBind()
    End Sub

    Private Sub formata_grid_resumo()
        grdResumo.AutoGenerateColumns = False
        grdResumo.DataSource = Nothing
        grdResumo.Columns.Clear()

        Dim cPedidos As New BoundField
        With cPedidos
            .DataField = "Pedidos"
            .HeaderText = "Ped. Aberto"
            .HeaderStyle.Width = 100
            .DataFormatString = "{0:#,##0.00}"
            .ItemStyle.HorizontalAlign = HorizontalAlign.Right
        End With
        grdResumo.Columns.Add(cPedidos)

        Dim cFaturas As New BoundField
        With cFaturas
            .DataField = "Faturas_aberto"
            .HeaderText = "Fat. Aberto"
            .HeaderStyle.Width = 100
            .DataFormatString = "{0:#,##0.00}"
            .ItemStyle.HorizontalAlign = HorizontalAlign.Right
        End With
        grdResumo.Columns.Add(cFaturas)

        Dim cTitAtraso As New BoundField
        With cTitAtraso
            .DataField = "titulos_atraso"
            .HeaderText = "Bol. Atraso"
            .HeaderStyle.Width = 100
            .DataFormatString = "{0:#,##0.00}"
            .ItemStyle.HorizontalAlign = HorizontalAlign.Right
        End With
        grdResumo.Columns.Add(cTitAtraso)

        Dim cTitVencer As New BoundField
        With cTitVencer
            .DataField = "titulos_vencer"
            .HeaderText = "Bol. a Vencer"
            .HeaderStyle.Width = 100
            .DataFormatString = "{0:#,##0.00}"
            .ItemStyle.HorizontalAlign = HorizontalAlign.Right
        End With
        grdResumo.Columns.Add(cTitVencer)

        Dim cTitTotal As New BoundField
        With cTitTotal
            .DataField = "titulos_aberto"
            .HeaderText = "Tot. Boletos"
            .HeaderStyle.Width = 100
            .DataFormatString = "{0:#,##0.00}"
            .ItemStyle.HorizontalAlign = HorizontalAlign.Right
        End With
        grdResumo.Columns.Add(cTitTotal)

        Dim cCheques As New BoundField
        With cCheques
            .DataField = "cheques_vencer"
            .HeaderText = "Cheques"
            .HeaderStyle.Width = 100
            .DataFormatString = "{0:#,##0.00}"
            .ItemStyle.HorizontalAlign = HorizontalAlign.Right
        End With
        grdResumo.Columns.Add(cCheques)

        Dim ctotal As New BoundField
        With ctotal
            .DataField = "total_aberto"
            .HeaderText = "Total Aberto"
            .HeaderStyle.Width = 100
            .DataFormatString = "{0:#,##0.00}"
            .ItemStyle.HorizontalAlign = HorizontalAlign.Right
        End With
        grdResumo.Columns.Add(ctotal)

        grdResumo.DataSource = classe.resumo_receber_cliente
        grdResumo.DataBind()
    End Sub

    Private Sub c_dados()
        'Status()
        'If cliente.max = 0 Then
        'LimpaControles(Me.tabPrinc.Controls)
        'LimpaControles(Me.grpLimite.Controls)
        ' FormatPacote()
        'Exit Sub
        'End If
        txtFilialCadastro.Text = classe.cod_filial_cliente
        txtCodCliente.Text = classe.cod_cliente
        txtNomeCliente.Text = classe.nome_cliente
        txtRazao.Text = classe.razao_social
        txtCnpj.Text = classe.cnpj
        txtIe.Text = classe.ie
        txtEndereco.Text = classe.endereco
        txtNumero.Text = classe.numero
        txtComplemento.Text = classe.complemento
        txtBairro.Text = classe.bairro
        txtUf.Text = classe.uf
        txtCep.Text = classe.cep
        txtTelefones.Text = classe.fones
        txtLimiteCompra.Text = Format(classe.limite_compra, "#,##0.00")
        txtLimiteCredito.Text = Format(classe.limite_credito, "#,##0.00")
        txtLimiteDisponivel.Text = Format(classe.limite_credito - classe.resumo_receber_total_cliente, "#,##0.00")
        txtDiasPagar.Text = classe.qtd_dias_pagar
        txtEmailNf.Text = classe.e_mail
        dbPromotor.SelectedValue = classe.cod_promotor
        txtObservacoes.Text = classe.observacao
        cbCidade.SelectedValue = classe.cod_cidade
        txtTelefoneNf.Text = classe.fone_nota
        cbTipoCliente.SelectedValue = classe.cod_tipo_cliente
        'carrega_restricoes()
        restricoes_bloqueado()
        formata_grid_resumo()
        classe.exibi_promotor_cb(txtFilialCadastro.Text, txtCodCliente.Text, ListBox1)

        'ciclo = New objCiclo(cliente.cod_cliente, cliente.cod_filial_cliente)
    End Sub


    Private Sub limpaControles(ByVal controle As Control)
        For Each ctl In controle.Controls
            If TypeOf ctl Is TextBox Then
                DirectCast(ctl, TextBox).Text = String.Empty
            ElseIf ctl.controls.count > 0 Then
                limpaControles(ctl)
            End If
        Next
    End Sub

    Protected Sub btnSalvar_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles btnSalvar.Click
        classe.cod_filial_cliente = txtFilialCadastro.Text
        classe.cod_cliente = txtCodCliente.Text
        classe.nome_cliente = txtNomeCliente.Text
        classe.razao_social = txtRazao.Text
        classe.cnpj = txtCnpj.Text
        classe.ie = txtIe.Text
        classe.endereco = txtEndereco.Text
        classe.numero = txtNumero.Text
        classe.complemento = txtComplemento.Text
        classe.bairro = txtBairro.Text
        classe.cep = txtCep.Text
        classe.cod_cidade = cbCidade.SelectedValue
        classe.uf = txtUf.Text
        classe.fones = txtTelefones.Text
        classe.fone_nota = txtTelefoneNf.Text
        classe.e_mail = txtEmailNf.Text
        classe.cod_tipo_cliente = cbTipoCliente.SelectedValue
        classe.cod_promotor = dbPromotor.SelectedValue
        classe.limite_compra = txtLimiteCompra.Text
        classe.qtd_dias_pagar = txtDiasPagar.Text
        classe.limite_credito = txtLimiteCredito.Text
        classe.observacao = txtObservacoes.Text

        If Session("strStatus").ToString = "Novo" Then
            classe.Salvar()
        ElseIf Session("strStatus").ToString = "Editar" Then
            classe.Editar()
        End If

        btnNovo.Enabled = True
        btnEditar.Enabled = True
        btnExcluir.Enabled = False
        btnSalvar.Enabled = False
        btnCancelar.Enabled = False
        Session.Remove("strStatus")
    End Sub

    Protected Sub btnNovo_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles btnNovo.Click
        Session("strStatus") = "Novo"
        grdResumo.DataSource = Nothing
        grdResumo.DataBind()

        Me.limpaControles(Me)
        txtFilialCadastro.Text = 1
        txtCodCliente.Text = classe.retornaUltimoRegistro("cliente", "cod_cliente", " where cod_filial_cliente = " & 1 & "")
        ListBox1.DataSource = Nothing
        ListBox1.Items.Clear()
        combos()
        txtLimiteCompra.Text = 0
        txtLimiteCredito.Text = 0
        txtDiasPagar.Text = 0
        txtLimiteDisponivel.Text = 0

        'lblStatus.Text = "Modo de Adição. Clique em Salvar ou Cancelar"

        ListBox1.Enabled = True
        btnNovo.Enabled = False
        btnEditar.Enabled = False
        btnExcluir.Enabled = False
        btnSalvar.Enabled = True
        btnCancelar.Enabled = True
    End Sub

    Protected Sub btnAdicionar_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles btnAdicionar.Click
        classe.grava_promotor(dbPromotor.SelectedValue, txtFilialCadastro.Text, txtCodCliente.Text)
        classe.exibi_promotor_cb(txtFilialCadastro.Text, txtCodCliente.Text, ListBox1)
    End Sub

    Protected Sub btnExcluiPromotor_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles btnExcluiPromotor.Click
        classe.excluir_promotor(lblCodigoPromotor, CInt(txtFilialCadastro.Text), CInt(txtCodCliente.Text))
        classe.exibi_promotor_cb(txtFilialCadastro.Text, txtCodCliente.Text, ListBox1)
    End Sub

    Protected Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        lblCodigoPromotor = classe.exibi_codigo_promotor(ListBox1.Text)
    End Sub

    Protected Sub btnEditar_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles btnEditar.Click
        Session("strStatus") = "Editar"
        btnNovo.Enabled = False
        btnEditar.Enabled = False
        btnExcluir.Enabled = True
        btnSalvar.Enabled = True
        btnCancelar.Enabled = True
    End Sub


    Protected Sub btnCancelar_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles btnCancelar.Click
        btnNovo.Enabled = True
        btnEditar.Enabled = True
        btnExcluir.Enabled = False
        btnSalvar.Enabled = False
        btnCancelar.Enabled = False
    End Sub

    Public Function restricoes_bloqueado() As Boolean
        Dim tt As New DataTable
        Dim rest As String
        tt = classe.restricoes_cliente(False)
        If tt.Rows.Count > 0 Then
            For Each r As DataRow In tt.Rows
                If r("cod_tipo_restricao") = 1 Then
                    btnStatus.BackColor = Drawing.Color.Red
                    btnStatus.Text = "Cliente Bloqueado".ToUpper
                    Return True
                    Exit Function
                Else
                    rest = rest & vbCrLf & r("tipo_restricao")
                End If
            Next
            btnStatus.BackColor = Drawing.Color.Yellow
            btnStatus.Text = rest.ToUpper
        Else
            btnStatus.BackColor = Drawing.Color.Lime
            btnStatus.Text = "Liberado".ToUpper
        End If
        'verifica se cliente tem títulos em atraso
        If classe.titulos_atraso_cliente_total(CInt(txtCodCliente.Text), CInt(txtFilialCadastro.Text)) > 0 Then
            btnStatus.Text = "Cliente com Títulos em aberto".ToUpper
            btnStatus.BackColor = Drawing.Color.Red
            Return True
            Exit Function
        End If
        If CDbl(classe.resumo_receber_total_cliente) > classe.limite_credito Then
            If CDbl(classe.limite_credito) = 0 Then
                btnStatus.Text = "Cliente sem limite de crédito".ToUpper
                btnStatus.BackColor = Drawing.Color.Yellow
                btnStatus.ForeColor = Drawing.Color.Black
                Return False
            End If
            btnStatus.Text = "Limite de crédito excedido".ToUpper
            btnStatus.BackColor = Drawing.Color.Red
            Return True
            Exit Function

        End If
        Return False
    End Function

    Private Sub formata_grid_titulo()
        grdTitulo.AutoGenerateColumns = False
        grdTitulo.DataSource = Nothing
        grdTitulo.Columns.Clear()

        Dim nossonumero As New BoundField
        With nossonumero
            .DataField = "nossonumero"
            .HeaderText = "Nosso Número"
            .HeaderStyle.Width = 80
            .ItemStyle.HorizontalAlign = HorizontalAlign.Right
        End With
        grdTitulo.Columns.Add(nossonumero)

        Dim tipodocumento As New BoundField
        With tipodocumento
            .DataField = "tipo_documento"
            .HeaderText = "T. Doc."
            .HeaderStyle.Width = 80
        End With
        grdTitulo.Columns.Add(tipodocumento)

        Dim documento As New BoundField
        With documento
            .DataField = "documento"
            .HeaderText = "Documento"
            .ItemStyle.HorizontalAlign = HorizontalAlign.Right
        End With
        grdTitulo.Columns.Add(documento)

        Dim emissao As New BoundField
        With emissao
            .DataField = "data_lancamento"
            .HeaderText = "Emissão"
            .HeaderStyle.Width = 80
            .ItemStyle.HorizontalAlign = HorizontalAlign.Right
            .DataFormatString = "{0:dd/MM/yyyy}"
        End With
        grdTitulo.Columns.Add(emissao)

        Dim vencimento As New BoundField
        With vencimento
            .DataField = "data_vencimento"
            .HeaderText = "Vencimento"
            .HeaderStyle.Width = 80
            .ItemStyle.HorizontalAlign = HorizontalAlign.Right
            .DataFormatString = "{0:dd/MM/yyyy}"
        End With
        grdTitulo.Columns.Add(vencimento)

        Dim valor As New BoundField
        With valor
            .DataField = "valor"
            .HeaderText = "Valor"
            .HeaderStyle.Width = 80
            .DataFormatString = "{0:#,##0.00}"
            .ItemStyle.HorizontalAlign = HorizontalAlign.Right
        End With
        grdTitulo.Columns.Add(valor)

        Dim pagamento As New BoundField
        With pagamento
            .DataField = "data_recebimento"
            .HeaderText = "Pagamento"
            .HeaderStyle.Width = 80
            .ItemStyle.HorizontalAlign = HorizontalAlign.Right
            .DataFormatString = "{0:dd/MM/yyyy}"
        End With
        grdTitulo.Columns.Add(pagamento)

        Dim codlanc As New BoundField
        With codlanc
            .DataField = "cod_lancamento"
            .HeaderText = "Lanc."
            .HeaderStyle.Width = 80
            .ItemStyle.HorizontalAlign = HorizontalAlign.Right
        End With
        grdTitulo.Columns.Add(codlanc)

        Dim filial As New BoundField
        With filial
            .DataField = "id_filial"
            .HeaderText = "Filial"
            .HeaderStyle.Width = 80
            .ItemStyle.HorizontalAlign = HorizontalAlign.Right
        End With
        grdTitulo.Columns.Add(filial)

        Dim filiallanc As New BoundField
        With filiallanc
            .DataField = "id_filial_lancamento"
            .HeaderText = "Filial Lanc."
            .HeaderStyle.Width = 80
            .ItemStyle.HorizontalAlign = HorizontalAlign.Right
        End With
        grdTitulo.Columns.Add(filiallanc)

        grdTitulo.DataSource = classe.titulos_Cliente(CInt(txtFilialCadastro.Text), CInt(txtCodCliente.Text))
        grdTitulo.DataBind()

    End Sub

    Protected Sub grdTitulo_RowDataBound(sender As Object, e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles grdTitulo.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            Dim data As Date = Now.ToShortDateString
            If (data <= e.Row.Cells(4).Text) And e.Row.Cells(6).Text = "&nbsp;" Then
                e.Row.BackColor = Drawing.Color.Yellow
            End If

            If e.Row.Cells(6).Text = "&nbsp;" And (data > e.Row.Cells(4).Text) Then
                e.Row.BackColor = Drawing.Color.Red
                e.Row.ForeColor = Drawing.Color.Yellow
            End If

            If e.Row.Cells(6).Text <> "&nbsp;" Then
                e.Row.BackColor = Drawing.Color.LightBlue
                e.Row.ForeColor = Drawing.Color.Black
            End If
        End If
    End Sub

    Protected Sub TabContainer1_ActiveTabChanged(sender As Object, e As EventArgs) Handles TabContainer1.ActiveTabChanged
        If TabContainer1.ActiveTabIndex = 6 Then
            lblAtrasados.Text = Format(CDbl(classe.titulos_atraso_cliente_total(CInt(txtCodCliente.Text), CInt(txtFilialCadastro.Text))), "#,##0.00")
            lblPendentes.Text = Format(CDbl(classe.titulos_cliente_pendente_total_sem_atraso(CInt(txtCodCliente.Text), CInt(txtFilialCadastro.Text))), "#,##0.00")
            formata_grid_titulo()
        End If
    End Sub

    Protected Sub btnFiltrar_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles btnFiltrar.Click
        If txtCodCliente.Text <> String.Empty Then
            classe.filtra_cod(txtCodCliente.Text)
        End If

        ' If txtNomeCliente.Text <> String.Empty Then
        'classe.filtra_nome(txtNomeCliente.Text)
        'End If
        combos()
        c_dados()
        carregaForma()
    End Sub

    Private Sub carregaForma()
        grdForma.AutoGenerateColumns = False
        grdForma.DataSource = Nothing
        grdForma.Columns.Clear()

        Dim tt As New DataTable
        Dim strSQL As String = "select descricao from tipo_compra inner join forma_compra on codigo = codigo_tipo_compra " & _
            "where cod_cliente = " & CInt(txtCodCliente.Text)

        Dim descricao As New BoundField
        descricao.DataField = "Descricao"
        descricao.ItemStyle.Width = 120
        grdForma.Columns.Add(descricao)

        tt = classe.retornaRegistro(strSQL).Tables(0)
        grdForma.DataSource = tt
        grdForma.DataBind()
    End Sub

End Class