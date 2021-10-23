Imports mrotica_util
Imports MRUtil

Public Class frmOS
#Region "Variaveis"
    Dim os As New ObjOS
    Dim br As New brOS
    Dim d As New dados
    Dim lTab As New objTabela()
    Dim tbArmacao As New DataTable
    Dim tbTratamentos As New DataTable
    Dim tbUs As New DataTable
    Dim tbLab As New DataTable
    Dim valido As Boolean = False  'usado na avaliação dos campos
    Dim valido_tab_receita As Boolean = False 'usado na avaliação dos campos da receita
    Dim usuario As New objUsuario
    Dim andamentos As New objAndamentos
    Dim prod As New produtoClass
    Dim pedido As New objPedidoBalcao
    Dim produto As New Produto
    Public autorizacao As objAutorizacao = Nothing
    Public novo As Boolean = True
    Public n_OS, Filial As Integer
    Public otica As Boolean = False
    Public n_cliente, d_cliente As Integer
    Public filial_cliente, cod_cliente As Integer
    Public tipo_acao As ACAO
    Public intContador As Int16
    Dim conf As New config
    Dim intUsuario As Integer
    Dim osMaster As New objMaster
    Dim intCodSurf, intCodMont, intCodColoracao As Integer
    Dim intControleOD, intControleOE As Char
    Public strErro As String = ""

    Public Enum ACAO
        NOVA_OS = 1
        TROCA_DIOPTRIA = 2
        TROCA_PRODUTO = 3
    End Enum
#End Region
    Private Sub frmOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblLenteTabOD.AutoCompleteCustomSource = produto.CarregaListaProduto()
        lblLenteTabOE.AutoCompleteCustomSource = produto.CarregaListaProduto()
        carrega_combos() 'Carrega os combos prresente nes tela
        intUsuario = osMaster.retorna_codigo_usuario(frmMain.intCodigoUsuario) 'Recupera o código do usuário que está logado

        'Se tratar de uma nova OS as instruções seguintes são executadas em caso negativo a OS que fois elecionada anteriormente será carregada
        If novo = True Then
            tipo_acao = ACAO.NOVA_OS
            os.novo()
            os.id_filial = conf.Filial
            If cod_cliente > 0 Then
                os.cod_filial_cliente = filial_cliente
                os.cod_cliente = cod_cliente
            End If
            Me.Text = "OS em modo de Cadastro"
        Else
            Me.Text = "OS em modo de Edição"
            carrega_os()
        End If

    End Sub
    Private Sub carrega_combos()
        d.carrega_Tabela("Select * from tipo_armacao", tbArmacao)
        cbTipoArmacao.DataSource = tbArmacao
        cbTipoArmacao.DisplayMember = "tipo_armacao"
        cbTipoArmacao.ValueMember = "cod_tipo_armacao"

        cbTipoRecOD.DataSource = lista_tipo_receita()
        cbTipoRecOD.DisplayMember = "tipo"
        cbTipoRecOD.ValueMember = "cod_tipo"

        cbTipoRecOE.DataSource = lista_tipo_receita()
        cbTipoRecOE.DisplayMember = "tipo"
        cbTipoRecOE.ValueMember = "cod_tipo"

        d.carrega_Tabela("Select * from laboratorio_montagem order by ordem", tbLab)
        cbLaboratorio.DataSource = tbLab
        cbLaboratorio.DisplayMember = "laboratorio"
        cbLaboratorio.ValueMember = "id_laboratorio"

    End Sub
    Private Sub carrega_os()
        If otica = False Then
            os = New ObjOS(n_OS, Filial)
        Else
            os = New ObjOS(d_cliente, n_cliente, "")
        End If

        txtCliente.Text = os.nome_cliente
        cbTipoArmacao.SelectedValue = os.cod_tipo_armacao
        txtAroHorizontal.Text = os.aro_horizontal
        txtAroVertical.Text = os.aro_vertical
        txtPonte.Text = os.ponte
        txtMaiorDiametro.Text = os.maior_diametro
        'Olho direito
        cbTipoRecOD.SelectedValue = os.tipo_receita_OD
        receita_od()
        txtLenteTabelaOD.Text = os.cod_tab_od
        lblLenteTabOD.Text = os.nome_tabela(os.cod_tab_od)
        lblCodPOD.Text = os.cod_produto_od
        txtEstoqueOD.Text = os.nome_Estoque(os.cod_produto_od)
        txtEsfODLonge.Text = os.esf_od_longe
        txtCilODLonge.Text = os.cil_od_longe
        txtDNPODLonge.Text = os.dnp_od_longe
        txtEsfODPerto.Text = os.esf_od_perto
        txtCilODPerto.Text = os.cil_od_perto
        txtDNPOdPerto.Text = os.dnp_od_perto
        txtAdicaoOD.Text = os.adicao_od
        txtAlturaOD.Text = os.altura_od
        txtDiametroOD.Text = os.diametro_od
        txtEixoOD.Text = os.eixo_od
        txtBaseOD.Text = os.base_od
        'Olho equerdo
        cbTipoRecOE.SelectedValue = os.tipo_receita_OE
        receita_oe()
        txtLenteTabelaOE.Text = os.cod_tab_oe
        lblLenteTabOE.Text = os.nome_tabela(os.cod_tab_oe)
        lblCodPOE.Text = os.cod_produto_oe
        txtEstoqueOE.Text = os.nome_Estoque(os.cod_produto_oe)
        txtEsfOELonge.Text = os.esf_oe_longe
        txtCilOELonge.Text = os.cil_oe_longe
        txtDNPOELonge.Text = os.dnp_oe_longe
        txtEsfOEPerto.Text = os.esf_oe_perto
        txtCilOEPerto.Text = os.cil_oe_perto
        txtDNPOEPerto.Text = os.dnp_oe_perto
        txtAdicaoOE.Text = os.adicao_oe
        txtAlturaOE.Text = os.altura_oe
        txtDiametroOE.Text = os.diametro_oe
        txtEixoOE.Text = os.eixo_oe
        txtBaseOE.Text = os.base_oe
        'Final
        chkSurfacagem.Checked = os.tem_surfacagem
        cbSurfacagem.SelectedValue = os.cod_surfacagem
        intCodSurf = os.cod_surfacagem
        chkMontagem.Checked = os.tem_montagem
        cbMontagem.SelectedValue = os.cod_montagem
        intCodMont = os.cod_montagem
        chkColoracao.Checked = os.tem_coloracao
        txtCorColoracao.Text = os.cor_coloracao
        intCodColoracao = os.coloracao

        regrasEdicao() 'Regras utilizadas na edição da OS referente aos campos Adição, Altura, Diametro e etc.

        carrega_tratamentos()
        If tbTratamentos.Rows.Count > 0 Then chkTratamento.Checked = True Else chkTratamento.Checked = False
        Try
            dtPrevisaoEntrega.Value = os.data_previsao_entrega
        Catch ex As Exception
        End Try
        txtHoraPrevisaoEntrega.Text = os.hora_previsao_entrega
        txtObs.Text = os.observacao
        cbLaboratorio.SelectedValue = os.id_laboratorio
        txtDocCliente.Text = os.doc_cliente

        Dim strSQL As String = "Select pedido_balcao.cod_vendedor_ext, usuarios.nome from pedido_balcao inner join usuarios " &
            "on pedido_balcao.cod_vendedor_ext = Usuarios.cod_usuario " &
            "where pedido_balcao.num_pedido = " & os.num_pedido & " and pedido_balcao.id_filial = " & os.id_filial &
            " and pedido_balcao.cod_cliente = " & os.cod_cliente
        Dim ttPedidoVendedor As New DataTable
        ttPedidoVendedor = osMaster.retornaRegistro(strSQL).Tables(0)
        If ttPedidoVendedor.Rows.Count > 0 Then
            txtVendedorExterno.Text = ttPedidoVendedor.Rows(0)("cod_vendedor_ext")
            lblVendedorExt.Text = ttPedidoVendedor.Rows(0)("nome").ToString
            lblVendedorExt.Visible = True
        End If

        'Se a ação se tratar de uma troca de produto a aba de armação será desstivada e em seguida verifica se existe uma troca de produto para
        'a OS informada casa haja uma troca de produto veririca se o OD está ok, caso esteja os grupos que contem os componentes do OD serão
        'desabilitados. em caso do tipo da receita for uma visão simples ou progressiva o grupo do OD para longe será habilitado e o grupo de outras
        'informações será habilitado também e no final verifica-se as regras para habilitação ou não da base, adição, altura e etc.
        If tipo_acao = ACAO.TROCA_PRODUTO Then
            bloqueia_tab_Armacao()
            tabOS.SelectTab(tabReceita)
            strSQL = "SELECT * from troca_produto where cod_os = " & os.cod_os & " and id_filial_os = " & os.id_filial & " and " &
            "concluido = 'N'"
            Dim tbTroca As New DataTable
            tbTroca = osMaster.retornaRegistro(strSQL).Tables(0)
            If tbTroca.Rows.Count > 0 Then
                If tbTroca.Rows(0)("prod_od_ok") = "S" Then
                    grpProdutoOD.Enabled = False
                    grpODLonge.Enabled = False
                    grpODPerto.Enabled = False
                    grpOutOd.Enabled = False
                Else
                    If cbTipoRecOD.SelectedValue = tipo_Receita.VISAO_simples_longe Or cbTipoRecOD.SelectedValue = tipo_Receita.PROGRESSIVA Or
                    cbTipoRecOD.SelectedValue = tipo_Receita.BIFOCAL Then
                        grpODLonge.Enabled = True
                        grpOutOd.Enabled = True
                    End If
                    If cbTipoRecOD.SelectedValue = tipo_Receita.VISAO_simples_perto Then
                        grpODPerto.Enabled = True
                        grpOutOd.Enabled = True
                    End If
                End If

                If tbTroca.Rows(0)("prod_oe_ok") = "S" Then
                    grpProdutoOE.Enabled = False
                    grpOELonge.Enabled = False
                    grpOEPerto.Enabled = False
                    grpOutOE.Enabled = False
                Else
                    If cbTipoRecOE.SelectedValue = tipo_Receita.VISAO_simples_longe Or cbTipoRecOE.SelectedValue = tipo_Receita.PROGRESSIVA Or
                    cbTipoRecOE.SelectedValue = tipo_Receita.BIFOCAL Then
                        grpOELonge.Enabled = True
                        grpOutOE.Enabled = True
                    End If
                    If cbTipoRecOE.SelectedValue = tipo_Receita.VISAO_simples_perto Then
                        grpOEPerto.Enabled = True
                        grpOutOE.Enabled = True
                    End If
                End If
            End If
            regrasEdicaoTroca()
        End If
    End Sub
#Region "TabArmação"
    Private Sub btnSeguir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeguir.Click
        'Verifica se os valores informados como aro horizontal, vertical, ponte e maior diametro foram informados e que não sejam negativos
        'Caso seja positivo ele irá proseguir, em caso negativo sai da instrução
        If validaTB1() = False Then
            Exit Sub
        End If

        tabOS.SelectTab(tabReceita) 'Segue para o pagetab da receita para que os dados da receita sejam preenchidos

        'Verifica se foi encontrada alguma OS em caso positivo passa a instrução de edição para a OS em uma variável chamada OrigemSalvar
        If os.max > 0 Then
            os.editar()
        End If

        'Repassa o valor dos campos da tela para os campos das OS's
        os.cod_tipo_armacao = cbTipoArmacao.SelectedValue
        os.aro_horizontal = txtAroHorizontal.Text
        os.aro_vertical = txtAroVertical.Text
        os.ponte = txtPonte.Text
        os.maior_diametro = txtMaiorDiametro.Text
        'os.crm_oftalmologista = rdNum(txtCRM.Text)

        'Atualiza essas nova informações na OS
        If os.max > 0 Then
            MessageBox.Show(os.Salvar(), "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
    Private Sub txtCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCliente.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Dim f As New frmConsultaCliente
                f.txtNome.Text = txtCliente.Text
                f.ShowDialog(Me)
                txtCliente.Text = f.nome
                os.cod_cliente = f.cod_cliente
                os.cod_filial_cliente = f.cod_filial
        End Select
    End Sub
#End Region
#Region "Validação TabArmação"
    Private Sub txtCliente_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCliente.Validating
        If os.cod_cliente = Nothing Or txtCliente.Text = "" Then
            MessageBox.Show("Informe o cliente vinculado a OS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tabOS.SelectTab(tabArmacao)
            txtCliente.Focus()
            valido = False
            Exit Sub
        End If
        valido = True
    End Sub
    Private Sub cbTipoArmacao_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbTipoArmacao.Validating
        If cbTipoArmacao.SelectedValue = 0 Then
            MessageBox.Show("Informe o tipo de armação.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tabOS.SelectTab(tabArmacao)
            cbTipoArmacao.Focus()
            valido = False
            Exit Sub
        End If
        valido = True
    End Sub
    Private Sub txtAroHorizontal_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAroHorizontal.Validating
        If osMaster.valida_valor_numerico(txtAroHorizontal.Text, False) = False Then
            MessageBox.Show("Valor do aro horizontal informado inváldio.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAroHorizontal.Focus()
            valido = False
            Exit Sub
        End If
        valido = True
    End Sub
    Private Sub txtAroVertical_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAroVertical.Validating
        If osMaster.valida_valor_numerico(txtAroVertical.Text, False) = False Then
            MessageBox.Show("Valor do aro vertical informado inváldio.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAroVertical.Focus()
            valido = False
            Exit Sub
        End If
        valido = True
    End Sub
    Private Sub txtPonte_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPonte.Validating
        If osMaster.valida_valor_numerico(txtPonte.Text, False) = False Then
            MessageBox.Show("Valor da ponte informado inváldio.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPonte.Focus()
            valido = False
            Exit Sub
        End If
        valido = True
    End Sub
    Private Sub txtMaiorDiametro_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtMaiorDiametro.Validating
        If osMaster.valida_valor_numerico(txtMaiorDiametro.Text, False) = False Then
            MessageBox.Show("Valor do maior diametro informado inváldio.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMaiorDiametro.Focus()
            valido = False
            Exit Sub
        End If
        valido = True
    End Sub
    Private Sub tabReceita_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabReceita.Enter
        If validaTB1() = False Then
            tabOS.SelectTab(tabArmacao)
        End If
    End Sub
    Private Function validaTB1() As Boolean
        txtCliente_Validating(Me, Nothing)
        txtAroVertical_Validating(Me, Nothing)
        txtAroHorizontal_Validating(Me, Nothing)
        txtPonte_Validating(Me, Nothing)
        txtMaiorDiametro_Validating(Me, Nothing)
        If valido = False Then
            Return False
        Else
            Return True
        End If
    End Function
#End Region
#Region "TabReceita"
    Private Sub tipo_os_od()
        If os.tipo_receita_OD <> Nothing Then
            If MessageBox.Show("Deseja realmente trocar o tipo de receita? Todos os dados da receita serão apagados.", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                cbTipoRecOD.SelectedValue = os.tipo_receita_OD
                intControleOD = "N"
            Else
                txtLenteTabelaOD.Text = ""
                lblLenteTabOD.Text = ""
                lblCodPOD.Text = ""
                txtEstoqueOD.Text = ""
                txtEsfODLonge.Text = ""
                txtCilODLonge.Text = ""
                txtDNPODLonge.Text = ""
                txtEsfODPerto.Text = ""
                txtCilODPerto.Text = ""
                txtDNPOdPerto.Text = ""
                txtAlturaOD.Text = ""
                txtDiametroOD.Text = ""
                txtEixoOD.Text = ""
                txtBaseOD.Text = ""
                txtLenteTabelaOD.Focus()
            End If
        End If
        intControleOD = "S"
        receita_od()
    End Sub

    Private Sub receita_od()
        With cbTipoRecOD
            If .SelectedValue = tipo_Receita.BIFOCAL Or .SelectedValue = tipo_Receita.PROGRESSIVA Then
                If .SelectedValue = tipo_Receita.BIFOCAL Then
                    os.tipo_receita_OD = tipo_Receita.BIFOCAL
                End If
                If .SelectedValue = tipo_Receita.PROGRESSIVA Then
                    os.tipo_receita_OD = tipo_Receita.PROGRESSIVA
                End If
                txtAdicaoOD.Enabled = True
            End If
            If .SelectedValue = tipo_Receita.VISAO_simples_longe Then
                os.tipo_receita_OD = tipo_Receita.VISAO_simples_longe
                txtAdicaoOD.Enabled = False
                txtAdicaoOD.Text = ""
            End If
            If .SelectedValue = tipo_Receita.VISAO_simples_perto Then
                os.tipo_receita_OD = tipo_Receita.VISAO_simples_perto
                txtAdicaoOD.Enabled = False
                txtAdicaoOD.Text = ""
            End If
        End With
    End Sub

    Private Sub tipo_os_oe()
        If os.tipo_receita_OE <> Nothing Then
            If MessageBox.Show("Deseja realmente trocar o tipo de receita? Todos os dados da receita serão apagados.", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                cbTipoRecOE.SelectedValue = os.tipo_receita_OE
                txtLenteTabelaOE.Text = os.cod_tab_oe
                intControleOE = "N"
            Else
                txtLenteTabelaOE.Text = ""
                lblLenteTabOE.Text = ""
                lblCodPOE.Text = ""
                txtEstoqueOE.Text = ""
                txtEsfOELonge.Text = ""
                txtCilOELonge.Text = ""
                txtDNPOELonge.Text = ""
                txtEsfOEPerto.Text = ""
                txtCilOEPerto.Text = ""
                txtDNPOEPerto.Text = ""
                txtAlturaOE.Text = ""
                txtDiametroOE.Text = ""
                txtEixoOE.Text = ""
                txtBaseOE.Text = ""
                txtLenteTabelaOE.Focus()
            End If
        End If
        intControleOE = "S"
        receita_oe()
    End Sub
    Private Sub receita_oe()
        With cbTipoRecOE
            If .SelectedValue = tipo_Receita.BIFOCAL Or .SelectedValue = tipo_Receita.PROGRESSIVA Then
                If .SelectedValue = tipo_Receita.BIFOCAL Then
                    os.tipo_receita_OE = tipo_Receita.BIFOCAL
                End If
                If .SelectedValue = tipo_Receita.PROGRESSIVA Then
                    os.tipo_receita_OE = tipo_Receita.PROGRESSIVA
                End If
                txtAdicaoOE.Enabled = True
            End If
            If .SelectedValue = tipo_Receita.VISAO_simples_longe Then
                os.tipo_receita_OE = tipo_Receita.VISAO_simples_longe
                txtAdicaoOE.Enabled = False
                txtAdicaoOE.Text = ""
            End If
            If .SelectedValue = tipo_Receita.VISAO_simples_perto Then
                os.tipo_receita_OE = tipo_Receita.VISAO_simples_perto
                txtAdicaoOE.Enabled = False
                txtAdicaoOE.Text = ""
            End If
        End With
    End Sub
    Private Sub txtLenteTabelaOD_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLenteTabelaOD.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim f As New frmConsultaLenteTabela
            f.ShowDialog(Me)
            txtLenteTabelaOD.Text = f.cod_tabela
            lblLenteTabOD.Text = f.nome_tabela
            f.Dispose()
        End If
    End Sub


    Private Sub txtLenteTabelaOD_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtLenteTabelaOD.Validating
        If txtLenteTabelaOD.Text <> String.Empty Then
            If txtLenteTabelaOD.Text = Nothing Then
                MessageBox.Show("Digite o código ou pressione a tecla ENTER para consultar.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtLenteTabelaOD.Focus()
                txtLenteTabelaOD.SelectAll()
                Exit Sub
            End If

            If txtLenteTabelaOD.Text <> Nothing Then
                lTab.Source("Select * from lentes_tabela where cod_tabela = " & d.cdin(txtLenteTabelaOD.Text) & "")
            End If

            'Verifica se o tipo de lente é unifocal em caso positivo se for escolhido progressiva ou bifocal ele mostra mensagem de erro
            If lTab.cod_tipo_lente = 21 Then
                If (cbTipoRecOD.SelectedValue = tipo_Receita.PROGRESSIVA) Or (cbTipoRecOD.SelectedValue = tipo_Receita.BIFOCAL) Then
                    MessageBox.Show("O código de lente informado é de uma visão simples." & vbCrLf &
                                "Por favor troque o tipo de receita.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtLenteTabelaOD.Focus()
                    txtLenteTabelaOD.SelectAll()
                    Exit Sub
                End If
            End If

            'Verifica se o tipo de lente é progressiva em caso positivo se for escolhido unifical ele mostra amensagem de erro
            If (lTab.cod_tipo_lente = 11) Or (lTab.cod_tipo_lente = 30) Or (lTab.cod_tipo_lente = 40) Then
                If txtLenteTabelaOD.Text = 11060 Then
                    GoTo continua
                End If
                If (cbTipoRecOD.SelectedValue = tipo_Receita.VISAO_simples_longe) Or (cbTipoRecOD.SelectedValue = tipo_Receita.VISAO_simples_perto) Then
                    MessageBox.Show("O código de lente informado não é de uma visão simples." & vbCrLf &
                                "Por favor troque o tipo de receita.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtLenteTabelaOD.Focus()
                    txtLenteTabelaOD.SelectAll()
                    Exit Sub
                End If
            End If

continua:   If lTab.max > 0 Then
                txtLenteTabelaOD.Text = lTab.cod_tabela
                lblLenteTabOD.Text = lTab.nome_comercial
                os.cod_tab_od = lTab.cod_tabela
                Exit Sub
            Else
                MessageBox.Show("Código da tabela informado inexistente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtLenteTabelaOD.Focus()
                txtLenteTabelaOD.SelectAll()
            End If

        End If
    End Sub

    Private Sub txtLenteTabelaOE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLenteTabelaOE.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim f As New frmConsultaLenteTabela
            f.ShowDialog(Me)
            txtLenteTabelaOE.Text = f.cod_tabela
            lblLenteTabOE.Text = f.nome_tabela
            f.Dispose()
        End If
    End Sub
    Private Sub txtLenteTabelaOE_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtLenteTabelaOE.Validating
        If txtLenteTabelaOE.Text = Nothing Then
            MessageBox.Show("Digite o código ou pressione a tecla ENTER para consultar.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtLenteTabelaOE.Focus()
            txtLenteTabelaOE.SelectAll()
            Exit Sub
        End If

        If txtLenteTabelaOE.Text <> Nothing Then
            lTab.Source("Select * from lentes_tabela where cod_tabela = " & d.cdin(txtLenteTabelaOE.Text) & "")
        End If

        'Verifica se o tipo de lente é unifocal em caso positivo se for escolhido progressiva ou bifocal ele mostra mensagem de erro
        If lTab.cod_tipo_lente = 21 Then
            If (cbTipoRecOE.SelectedValue = tipo_Receita.PROGRESSIVA) Or (cbTipoRecOE.SelectedValue = tipo_Receita.BIFOCAL) Then
                MessageBox.Show("O código de lente informado é de uma visão simples." & vbCrLf &
                                "Por favor troque o tipo de receita.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtLenteTabelaOE.Focus()
                txtLenteTabelaOE.SelectAll()
                Exit Sub
            End If
        End If

        'Verifica se o tipo de lente é progressiva em caso positivo se for escolhido unifical ele mostra amensagem de erro
        If (lTab.cod_tipo_lente = 11) Or (lTab.cod_tipo_lente = 30) Or (lTab.cod_tipo_lente = 40) Then
            If txtLenteTabelaOD.Text = 11060 Then
                GoTo continua
            End If
            If (cbTipoRecOE.SelectedValue = tipo_Receita.VISAO_simples_longe) Or (cbTipoRecOE.SelectedValue = tipo_Receita.VISAO_simples_perto) Then
                MessageBox.Show("O código de lente informado não é de uma visão simples." & vbCrLf &
                                "Por favor troque o tipo de receita.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtLenteTabelaOE.Focus()
                txtLenteTabelaOE.SelectAll()
                Exit Sub
            End If
        End If

continua: If lTab.max > 0 Then
            txtLenteTabelaOE.Text = lTab.cod_tabela
            lblLenteTabOE.Text = lTab.nome_comercial
            os.cod_tab_oe = lTab.cod_tabela
            If os.tipo_receita_OE = tipo_Receita.VISAO_simples_perto Then
                txtEsfOEPerto.Focus()
            Else
                txtEsfOELonge.Focus()
            End If

            Exit Sub
        Else
            MessageBox.Show("Código inexistente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtLenteTabelaOE.Focus()
            txtLenteTabelaOE.SelectAll()
        End If
    End Sub
    Private Function base_od(ByVal esf As Double, ByVal cil As Double, ByVal tipo As Integer) As Boolean
        Dim esfBase As Double
        Dim tb As New DataTable
        Dim strSQL As String = ""
        Dim esp As String = Nothing
        Dim strAdicao As String = ""
        esp = lTab.ret_especie(os.cod_tab_od)

        If txtAdicaoOD.Text = String.Empty Then
            strAdicao = 0
        Else
            strAdicao = txtAdicaoOD.Text
        End If

        'Se a espécie de lente for do tipo Bloco as instruções sequintes serão executadas
        If esp = "B" Then
            If tipo = tipo_Receita.VISAO_simples_perto Then
                If CDbl(txtEsfODPerto.Text) < 0 Then
                    esfBase = CDbl(txtEsfODPerto.Text) + CDbl(txtCilODPerto.Text)
                Else
                    esfBase = CDbl(txtEsfODPerto.Text)
                End If
            Else
                If CDbl(txtEsfODLonge.Text) < 0 Then
                    esfBase = CDbl(txtEsfODLonge.Text) + CDbl(txtCilODLonge.Text)
                Else
                    esfBase = CDbl(txtEsfODLonge.Text)
                End If
            End If
            strSQL = "SELECT lentes_tabela.nome_comercial, lentes_blocos.nome_lente, blocos.Base_nominal, blocos.Adicao, blocos.olho, blocos.ESF_MAIOR, " &
                  " blocos.ESF_MENOR, produtos.cod_barra,produtos.cod_produto, lentes_blocos.diametro, lentes_blocos.cod_tabela, lentes_blocos.cod_lente " &
                  " FROM lentes_blocos INNER JOIN " &
                  "lentes_tabela ON lentes_blocos.cod_tabela = lentes_tabela.cod_tabela INNER JOIN " &
                  "produtos ON lentes_blocos.cod_lente = produtos.cod_lente AND lentes_blocos.id_fabricante = produtos.id_fabricante INNER JOIN " &
                  "blocos ON produtos.cod_produto = blocos.Cod_produto " &
                  "WHERE blocos.ESF_MAIOR >= " & d.cdin(esfBase) & " AND blocos.ESF_MENOR <=" & d.cdin(esfBase) & " AND (blocos.olho = 'D' or blocos.olho = 'A') " &
                  " AND dbo.blocos.Adicao = " & d.cdin(strAdicao) & " and lentes_tabela.cod_tabela = " & d.cdin(txtLenteTabelaOD.Text) & ""
            txtBaseOD.Enabled = True
        End If

        'Se a espécie de lente for do tipo Bloco Surfaçado as instruções sequintes serão executadas
        If esp = "BS" Then
            strSQL = "SELECT lentes_tabela.nome_comercial, lentes_blocos.nome_lente, bloco_surfacado.Base_nominal, bloco_surfacado.Adicao, bloco_surfacado.olho, " &
                 "bloco_surfacado.esf,  bloco_surfacado.cil," &
                 "  produtos.cod_barra,produtos.cod_produto, lentes_blocos.diametro, lentes_blocos.cod_tabela, lentes_blocos.cod_lente " &
                  " FROM lentes_blocos INNER JOIN " &
                  "lentes_tabela ON lentes_blocos.cod_tabela = lentes_tabela.cod_tabela INNER JOIN " &
                  "produtos ON lentes_blocos.cod_lente = produtos.cod_lente AND lentes_blocos.id_fabricante = produtos.id_fabricante INNER JOIN " &
                  "bloco_surfacado ON produtos.cod_produto = bloco_surfacado.Cod_produto " &
                  "WHERE bloco_surfacado.esf = " & d.cdin(esf) & " AND bloco_surfacado.cil =" & d.cdin(cil) & " AND (bloco_surfacado.olho = 'D' or bloco_surfacado.olho = 'A') " &
                  " AND bloco_surfacado.Adicao = " & d.cdin(strAdicao) & " and lentes_tabela.cod_tabela = " & d.cdin(txtLenteTabelaOD.Text) & ""
            txtBaseOD.Enabled = True
        End If

        'Se a espécie de lente for do tipo Lente as instruções sequintes serão executadas
        If esp = "L" Then
            Dim parametro As String = ""
            If txtLenteTabelaOD.Text = 0 Then
                parametro = "Where lentes_tabela.cod_tabela = " & d.cdin(txtLenteTabelaOD.Text) & ""
            Else
                parametro = "INNER JOIN lentes ON produtos.cod_produto = lentes.cod_produto Where lentes.esferico = " & d.cdin(esf) &
                    " AND lentes.cilindrico = " & d.cdin(cil) & " and lentes_tabela.cod_tabela = " & d.cdin(txtLenteTabelaOD.Text) & ""
            End If

            strSQL = "SELECT lentes_tabela.nome_comercial, lentes_blocos.nome_lente,produtos.cod_produto, produtos.cod_barra, lentes_blocos.diametro, lentes_blocos.cod_tabela, " &
            "lentes_blocos.cod_lente FROM lentes_blocos INNER JOIN lentes_tabela ON lentes_blocos.cod_tabela = lentes_tabela.cod_tabela INNER JOIN " &
            "produtos ON lentes_blocos.cod_lente = produtos.cod_lente AND lentes_blocos.id_fabricante = produtos.id_fabricante " & parametro & ""
            txtBaseOD.Enabled = False
        End If

        d.carrega_Tabela(strSQL, tb)

        If tb.Rows.Count > 0 Then
            'Retorna o nome do produto com o respectivo código de barra
            txtEstoqueOD.Text = prod.Retorna_nome_prod(tb.Rows(0)("cod_produto")) & " Barra: " & tb.Rows(0)("cod_barra")
            'Se a espécie for do tipo Bloco ou Bloco Surfaçado o TextBox da Base do olho direito será preenchida
            If esp = "B" Or esp = "BS" Then
                txtBaseOD.Text = tb.Rows(0)("base_nominal")
            Else
                txtBaseOD.Text = ""
            End If

            'Repassa o código do produto para o campo da OS e o Label em questão
            os.cod_produto_od = tb.Rows(0)("cod_produto")
            lblCodPOD.Text = os.cod_produto_od

            Try
                'Caso o diametro informado seja maior que o diametro da lente a mensagem seguinte será mostrada
                If CDbl(txtDiametroOD.Text) > CDbl(tb.Rows(0)("diametro")) Then
                    MessageBox.Show("Diametro de montagem maior que o diametro da lente/bloco.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    valido_tab_receita = True
                    Return False
                End If
            Catch ex As Exception

            End Try
        Else
            MessageBox.Show("Dioptria Indisponível para esta lente! Mude a lente ou altere a dioptria!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            valido_tab_receita = False
            Return False
            Exit Function
        End If

        valido_tab_receita = True
        Return True
    End Function

    Private Function base_oe(ByVal esf As Double, ByVal cil As Double, ByVal tipo As Integer) As Boolean
        Dim esfBase As Double
        Dim tb As New DataTable
        Dim sql As String
        Dim esp As String = Nothing
        Dim strAdicao As String = ""

        esp = lTab.ret_especie(os.cod_tab_oe)

        If txtAdicaoOE.Text = String.Empty Then
            strAdicao = 0
        Else
            strAdicao = txtAdicaoOE.Text
        End If

        'Se a espécie de lente for do tipo Bloco as instruções sequintes serão executadas
        If esp = "B" Then
            If tipo = tipo_Receita.VISAO_simples_perto Then
                If CDbl(txtEsfOEPerto.Text) < 0 Then
                    esfBase = CDbl(txtEsfOEPerto.Text) + CDbl(txtCilOEPerto.Text)
                Else
                    esfBase = CDbl(txtEsfOEPerto.Text)
                End If
            Else
                If CDbl(txtEsfOELonge.Text) < 0 Then
                    esfBase = CDbl(txtEsfOELonge.Text) + CDbl(txtCilOELonge.Text)
                Else
                    esfBase = CDbl(txtEsfOELonge.Text)
                End If
            End If

            sql = "SELECT lentes_tabela.nome_comercial, lentes_blocos.nome_lente, blocos.Base_nominal, blocos.Adicao, blocos.olho, blocos.ESF_MAIOR, " &
                  " blocos.ESF_MENOR, produtos.cod_barra,produtos.cod_produto, lentes_blocos.diametro, lentes_blocos.cod_tabela, lentes_blocos.cod_lente " &
                  " FROM lentes_blocos INNER JOIN " &
                  "lentes_tabela ON lentes_blocos.cod_tabela = lentes_tabela.cod_tabela INNER JOIN " &
                  "produtos ON lentes_blocos.cod_lente = produtos.cod_lente AND lentes_blocos.id_fabricante = produtos.id_fabricante INNER JOIN " &
                  "blocos ON produtos.cod_produto = blocos.Cod_produto " &
                  "WHERE blocos.ESF_MAIOR >= " & d.cdin(esfBase) & " AND blocos.ESF_MENOR <=" & d.cdin(esfBase) & " AND (blocos.olho = 'E' or blocos.olho = 'A') " &
                  " AND dbo.blocos.Adicao = " & d.cdin(strAdicao) & " and lentes_tabela.cod_tabela = " & d.cdin(txtLenteTabelaOE.Text) & ""
            txtBaseOE.Enabled = True
        End If

        'Se a espécie de lente for do tipo Bloco Surfaçado as instruções sequintes serão executadas
        If esp = "BS" Then
            sql = "SELECT lentes_tabela.nome_comercial, lentes_blocos.nome_lente, bloco_surfacado.Base_nominal, bloco_surfacado.Adicao, bloco_surfacado.olho, " &
                 "bloco_surfacado.esf,  bloco_surfacado.cil," &
                 "  produtos.cod_barra,produtos.cod_produto, lentes_blocos.diametro, lentes_blocos.cod_tabela, lentes_blocos.cod_lente " &
                  " FROM lentes_blocos INNER JOIN " &
                  "lentes_tabela ON lentes_blocos.cod_tabela = lentes_tabela.cod_tabela INNER JOIN " &
                  "produtos ON lentes_blocos.cod_lente = produtos.cod_lente AND lentes_blocos.id_fabricante = produtos.id_fabricante INNER JOIN " &
                  "bloco_surfacado ON produtos.cod_produto = bloco_surfacado.Cod_produto " &
                  "WHERE bloco_surfacado.esf = " & d.cdin(esf) & " AND bloco_surfacado.cil =" & d.cdin(cil) & " AND (bloco_surfacado.olho = 'E' or bloco_surfacado.olho = 'A') " &
                  " AND bloco_surfacado.Adicao = " & d.cdin(strAdicao) & " and lentes_tabela.cod_tabela = " & d.cdin(txtLenteTabelaOD.Text) & ""
            txtBaseOE.Enabled = True
        End If

        'Se a espécie de lente for do tipo Lente as instruções sequintes serão executadas
        If esp = "L" Then
            Dim parametro As String = ""
            If txtLenteTabelaOE.Text = 0 Then
                parametro = "Where lentes_tabela.cod_tabela = " & d.cdin(txtLenteTabelaOE.Text) & ""
            Else
                parametro = "INNER JOIN lentes ON produtos.cod_produto = lentes.cod_produto Where lentes.esferico = " & d.cdin(esf) &
                    " AND lentes.cilindrico = " & d.cdin(cil) & " and lentes_tabela.cod_tabela = " & d.cdin(txtLenteTabelaOE.Text) & ""
            End If

            sql = "SELECT lentes_tabela.nome_comercial, lentes_blocos.nome_lente,produtos.cod_produto, produtos.cod_barra, lentes_blocos.diametro, lentes_blocos.cod_tabela, " &
            "lentes_blocos.cod_lente FROM lentes_blocos INNER JOIN lentes_tabela ON lentes_blocos.cod_tabela = lentes_tabela.cod_tabela INNER JOIN " &
            "produtos ON lentes_blocos.cod_lente = produtos.cod_lente AND lentes_blocos.id_fabricante = produtos.id_fabricante " & parametro
            txtBaseOE.Enabled = False
        End If

        d.carrega_Tabela(sql, tb)
        If tb.Rows.Count > 0 Then
            'Retorna o nome do produto com o respectivo código de barra
            txtEstoqueOE.Text = prod.Retorna_nome_prod(tb.Rows(0)("cod_produto")) & " Barra: " & tb.Rows(0)("cod_barra")
            'Se a espécie for do tipo Bloco ou Bloco Surfaçado o TextBox da Base do olho direito será preenchida
            If esp = "B" Or esp = "BS" Then
                txtBaseOE.Text = tb.Rows(0)("base_nominal")
            Else
                txtBaseOE.Text = ""
            End If

            'Repassa o código do produto para o campo da OS e o Label em questão
            os.cod_produto_oe = tb.Rows(0)("cod_produto")
            lblCodPOE.Text = os.cod_produto_oe
            Try
                If CDbl(txtDiametroOE.Text) > CDbl(tb.Rows(0)("diametro")) Then
                    MessageBox.Show("Diametro de montagem maior que o diametro da lente/bloco.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    valido_tab_receita = True
                    Return False
                End If
            Catch ex As Exception

            End Try
        Else
            MessageBox.Show("Dioptria Indisponível para esta lente! Mude a lente ou altere a dioptria!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            valido_tab_receita = False
            Return False
        End If
        valido_tab_receita = True
        Return True
    End Function

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        If (txtLenteTabelaOD.Text <> String.Empty) And (txtLenteTabelaOE.Text <> String.Empty) Then
            Dim res As String

            'Verifica se os dados da receita estão todos validos e corretos, caso não esteja saimos da instrução aqui
            'e seremos remetidos as rotinas de validações novamente
            If valido_tab_receita = False Then
                MessageBox.Show("Não foi possível salvar a OS, existem dados inconsistentes." & vbCrLf & "Por favor corrigir os dados da receita.",
                                "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            'Se caso não se tratar de ums OS nova a os corrente entra em modo de edição
            If novo = False Then
                os.editar()
                'Se o código da lente do olho direito for igual a zero será passado o valor zero para o código do produto do olho direito
                If txtLenteTabelaOD.Text = 0 Then
                    os.cod_produto_od = 0
                    lblCodPOD.Text = os.cod_produto_od
                End If
                'Se o código da lente do olho direito for igual a zero será passado o valor zero para o código do produto do olho direito
                If txtLenteTabelaOE.Text = 0 Then
                    os.cod_produto_oe = 0
                    lblCodPOE.Text = os.cod_produto_oe
                End If

                'Se o código da surfaçagem for diferente de vazio, as instruções seguintes serão analisadas para verificar se o código do produto
                'do olho direito ou esquerdo são do tipo "B" se for verificarar se o codigo do serviço faz parde do pedido informado se fizer
                'a quantidade do serviço será diminuido de um
                If os.cod_surfacagem <> Nothing Then
                    Dim strSQL As String = ""
                    Dim intQtde As Integer = 0

                    If osMaster.tem_bloco(CInt(lblCodPOD.Text)) = True Then
                        intQtde = 1
                        strSQL = "quant = " & intQtde & " where num_pedido = " & os.num_pedido & " and id_filial = " & os.id_filial &
                            " and cod_servico = " & os.cod_surfacagem
                        osMaster.atualiza_registros("pedido_balcao_servicos", strSQL, True)

                    End If

                    If osMaster.tem_bloco(CInt(lblCodPOE.Text)) = True Then
                        If intQtde = 1 Then
                            intQtde = intQtde + 1
                        Else
                            intQtde = 1
                        End If
                        strSQL = "quant = " & intQtde & " where num_pedido = " & os.num_pedido & " and id_filial = " & os.id_filial &
                            " and cod_servico = " & os.cod_surfacagem
                        osMaster.atualiza_registros("pedido_balcao_servicos", strSQL, True)
                    End If

                    If osMaster.tem_bloco(CInt(lblCodPOD.Text)) = False And osMaster.tem_bloco(CInt(lblCodPOE.Text)) = False Then
                        If intQtde = 0 Then
                            strSQL = "where num_pedido = " & os.num_pedido & " and id_filial = " & os.id_filial & " and cod_servico = " & os.cod_surfacagem
                            osMaster.excluir_registros("pedido_balcao_servicos", strSQL, True)
                            os.cod_surfacagem = Nothing
                            os.cod_lab_surf = 0
                            chkSurfacagem.Checked = False
                            cbSurfacagem.DataSource = Nothing
                        End If
                    End If
                End If

            End If

            'Se a ação se tratar de uma troca de produto a instrução seguinte é executada onde verificar se existe uma troca para a OS
            'caso exista a troca verifica se o produto do OD está OK, caso não esteja verificar se o codigo do novo produto é igual ao código
            'do produto solicitado na traca de produto se forem significa que não houve mudança de produto e a mensage seguinte é apresentada
            If tipo_acao = ACAO.TROCA_PRODUTO Then
                Dim strSQL As String = "SELECT * from troca_produto where cod_os = " & os.cod_os & " and id_filial_os = " & os.id_filial & " and " &
                "concluido = 'N'"
                Dim tbTroca As New DataTable
                tbTroca = osMaster.retornaRegistro(strSQL).Tables(0)
                If tbTroca.Rows.Count > 0 Then
                    If tbTroca.Rows(0)("prod_od_ok") = "N" Then
                        If tbTroca.Rows(0)("cod_prod_od") = CInt(lblCodPOD.Text) Then
                            MessageBox.Show("Esta troca não pode ser feita, devido um dos produtos solicitado" & vbCrLf &
                            "na troca não corresponder a nenhum produto alterado na OS.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            strErro = "Error"
                            Exit Sub
                        End If
                    End If

                    'Se a ação se tratar de uma troca de produto a instrução seguinte é executada onde verificar se existe uma troca para a OS
                    'caso exista a troca verifica se o produto do OE está OK, caso não esteja verificar se o codigo do novo produto é igual ao código
                    'do produto solicitado na traca de produto se forem significa que não houve mudança de produto e a mensage seguinte é apresentada
                    If tbTroca.Rows(0)("prod_oe_ok") = "N" Then
                        If tbTroca.Rows(0)("cod_prod_oe") = CInt(lblCodPOE.Text) Then
                            MessageBox.Show("Esta troca não pode ser feita, devido um dos produtos solicitado" & vbCrLf &
                            "na troca não corresponder a nenhum produto alterado na OS.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            strErro = "Error"
                            Exit Sub
                        End If
                    End If
                End If
            End If

            'Avaliação de Produtos Especiais
            If tipo_acao = ACAO.TROCA_DIOPTRIA Or tipo_acao = ACAO.TROCA_PRODUTO Then
                Dim r As frmAviso.respo
                Dim range As Double
                'Lente intermediária Access
                If os.cod_tab_od = 11034 Then
                    If MessageBox.Show("Deseja Trocar o Range do Olho Direito?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        range = InputBox("Digite o range:(0,75 ou 1,25)")
                        If range = 0.75 Then
                            os.cod_produto_od = 1284
                            lblCodPOD.Text = os.cod_produto_od
                        End If
                        If range = 1.25 Then
                            os.cod_produto_od = 20596
                            lblCodPOD.Text = os.cod_produto_od
                        End If
                    End If
                End If
                If os.cod_tab_oe = 11034 Then
                    If MessageBox.Show("Deseja Trocar o Range do olho Esquerdo?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        range = InputBox("Digite o range:(0,75 ou 1,25)")
                        If range = 0.75 Then
                            os.cod_produto_oe = 1284
                            lblCodPOE.Text = os.cod_produto_oe
                        End If
                        If range = 1.25 Then
                            os.cod_produto_oe = 20596
                            lblCodPOE.Text = os.cod_produto_oe
                        End If
                    End If
                End If
                'fim lente intermediaria access
            End If

            os.altura_od = txtAlturaOD.Text
            os.altura_oe = txtAlturaOE.Text
            os.base_od = txtBaseOD.Text
            os.diametro_od = txtDiametroOD.Text
            os.diametro_oe = txtDiametroOE.Text
            os.dnp_od_longe = txtDNPODLonge.Text
            os.dnp_oe_longe = txtDNPOELonge.Text
            os.base_od = txtBaseOD.Text
            os.base_oe = txtBaseOE.Text
            os.adicao_od = txtAdicaoOD.Text
            os.adicao_oe = txtAdicaoOE.Text
            os.esf_od_longe = txtEsfODLonge.Text
            os.esf_oe_longe = txtEsfOELonge.Text
            os.cil_od_longe = txtCilODLonge.Text
            os.cil_oe_longe = txtCilOELonge.Text
            os.esf_od_perto = txtEsfODPerto.Text
            os.esf_oe_perto = txtEsfOEPerto.Text
            os.cil_od_perto = txtCilODPerto.Text
            os.cil_oe_perto = txtCilOEPerto.Text
            os.dnp_od_perto = txtDNPOdPerto.Text
            os.dnp_oe_perto = txtDNPOEPerto.Text
            os.eixo_od = txtEixoOD.Text
            os.eixo_oe = txtEixoOE.Text
            If novo = False Then
                Dim edit As String
                edit = os.row_editado
                If edit.StartsWith("OK") Then
                    MsgBox(os.Salvar() & vbCrLf & andamentos.insere_andamento(objAndamentos.tipo.alteracao_os,
                        os.id_filial, os.cod_os, intUsuario, edit.Substring(3)) & "Nº da OS: " & os.cod_os)
                    'Novo 10/06/2014
                    Dim strSQLOD As String = "cod_produto = " & CInt(lblCodPOD.Text) & " where num_pedido = " & os.num_pedido & " and id_filial = " & os.id_filial &
                        " and item = 1"
                    osMaster.atualiza_registros("pedido_balcao_itens", strSQLOD, True)
                    Dim strSQLOE As String = "cod_produto = " & CInt(lblCodPOE.Text) & " where num_pedido = " & os.num_pedido & " and id_filial = " & os.id_filial &
                    " and item = 2"
                    osMaster.atualiza_registros("pedido_balcao_itens", strSQLOE, True)
                    'Fim Novo
                    strErro = "Salvo"
                End If
            Else
                res = os.Salvar
                'Registra os Andamentos
                If res.StartsWith("OK") Then
                    If novo = True Then
                        MessageBox.Show(andamentos.insere_andamento(objAndamentos.tipo.inclusao_os, os.id_filial, os.cod_os, UserID, ""), "INFORMAÇÃO",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information)

                    End If
                End If
            End If
            tabOS.SelectTab(tbFinal)
        Else
            MessageBox.Show("Informe o código da lente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

#End Region

#Region "Validação TabReceita"
    Private Sub cbTipoRecOD_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbTipoRecOD.Validating
        tipo_os_od()
    End Sub
    Private Sub cbTipoRecOE_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbTipoRecOE.Enter
        'Quando o combo para escolha do tipo de lente receber foco, copia o tipo
        'do olho direito
        cbTipoRecOE.SelectedValue = cbTipoRecOD.SelectedValue
    End Sub
    Private Sub cbTipoRecOe_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbTipoRecOE.Validating
        tipo_os_oe()
    End Sub

    Private Sub txtEixoOD_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEixoOD.Validating
        If os.tipo_receita_OD = tipo_Receita.VISAO_simples_perto Then
            If txtCilODPerto.Text <> "" And txtCilODPerto.Text < 0 Then
                If txtEixoOD.Text = "" Then
                    MessageBox.Show("Por favor informe o valor do eixo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtEixoOD.Focus()
                    txtEixoOD.SelectAll()
                    valido_tab_receita = False
                ElseIf txtEixoOD.Text = "0" Then
                    txtEixoOD.Text = "180"
                Else
                    valido_tab_receita = True
                End If
            End If
        Else
            If txtCilODLonge.Text <> "" And txtCilODLonge.Text < 0 Then
                If txtEixoOD.Text = "" Then
                    MessageBox.Show("Por favor informe o valor do eixo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtEixoOD.Focus()
                    txtEixoOD.SelectAll()
                    valido_tab_receita = False
                ElseIf txtEixoOD.Text = "0" Then
                    txtEixoOD.Text = "180"
                Else
                    valido_tab_receita = True
                End If
            End If
        End If
    End Sub

    Private Sub txtEixoOE_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEixoOE.Validating
        If os.tipo_receita_OE = tipo_Receita.VISAO_simples_perto Then
            If txtCilOEPerto.Text <> "" And txtCilOEPerto.Text < 0 Then
                If txtEixoOE.Text = "" Then
                    MessageBox.Show("Por favor informe o valor do eixo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtEixoOE.Focus()
                    valido_tab_receita = False
                ElseIf txtEixoOE.Text = "0" Then
                    txtEixoOE.Text = "180"
                Else
                    valido_tab_receita = True
                End If
            End If
        Else
            If txtCilOELonge.Text <> "" And txtCilOELonge.Text < 0 Then
                If txtEixoOE.Text = "" Then
                    MessageBox.Show("Por favor informe o valor do eixo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtEixoOE.Focus()
                    valido_tab_receita = False
                ElseIf txtEixoOE.Text = "0" Then
                    txtEixoOE.Text = "180"
                Else
                    valido_tab_receita = True
                End If
            End If
        End If
    End Sub

#End Region
#Region "Conclusão"
    Private Sub chkSurfacagem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSurfacagem.CheckedChanged
        Dim sql As String
        If chkSurfacagem.Checked = False Then
            cbSurfacagem.DataSource = Nothing
        Else
            If pode_surfacar() = False Then
                cbSurfacagem.DataSource = Nothing
                Exit Sub
            End If
            Dim tbSurf As New DataTable
            'Seleciona o tipo de serviços 1 que na tabela de tipo_servico equivale a surfaçagem 
            sql = "SELECT produtos.cod_produto, produtos.produto " &
            "FROM produtos INNER JOIN " &
            "servicos ON produtos.cod_produto = servicos.cod_produto " &
            "WHERE (servicos.cod_tipo_servico = 1)"
            d.carrega_Tabela(sql, tbSurf)
            cbSurfacagem.DataSource = tbSurf
            cbSurfacagem.DisplayMember = "produto"
            cbSurfacagem.ValueMember = "cod_produto"
            cbSurfacagem.SelectedValue = prod.tipo_surfacagem(os.cod_produto_od)
        End If
    End Sub
    Private Sub chkMontagem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMontagem.CheckedChanged
        Dim sql As String
        If chkMontagem.Checked = False Then
            cbMontagem.DataSource = Nothing
        Else
            Dim tbMont As New DataTable
            'Seleciona o tipo de serviços 2 que na tabela de tipo_servico equivale a montagem 
            sql = "SELECT produtos.cod_produto, produtos.produto  " &
            "FROM produtos INNER JOIN " &
            "servicos ON produtos.cod_produto = servicos.cod_produto " &
            "WHERE (servicos.cod_tipo_servico = 2)"
            d.carrega_Tabela(sql, tbMont)
            cbMontagem.DataSource = tbMont
            cbMontagem.DisplayMember = "produto"
            cbMontagem.ValueMember = "cod_produto"
        End If
    End Sub
    Private Sub btnInserirTratamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirTratamento.Click
        Dim strSQL As String = "select 1 from tratamentos_os where cod_produto = " & cbTratamento.SelectedValue & " and id_filial = " & os.id_filial &
            " and cod_os = " & os.num_pedido
        If osMaster.verifica_existencia_registro(strSQL) = True Then
            MessageBox.Show("Tratamento já existente para esta OS.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim strSQLInsert As String = "insert into tratamentos_os(id_filial,cod_os,cod_produto) values(" &
            os.id_filial & "," & os.cod_os & "," & cbTratamento.SelectedValue & ")"
            osMaster.grava_registros(strSQLInsert, True)

            andamentos.insere_andamento(objAndamentos.tipo.aviso_os, os.id_filial, os.cod_os,
            UserID, "Tratamento " & cbTratamento.Text & " incluido!")
        End If
        carrega_tratamentos()
    End Sub

    Private Sub carrega_tratamentos()
        Dim sql As String
        sql = "SELECT produtos.produto,tratamentos_os.cod_produto " &
              "FROM tratamentos_os INNER JOIN " &
              "produtos ON tratamentos_os.cod_produto = produtos.cod_produto " &
              "WHERE (tratamentos_os.id_filial =" & os.id_filial & ") AND " &
              " (tratamentos_os.cod_os = " & os.cod_os & ")"
        d.carrega_Tabela(sql, tbTratamentos)
        lstTratamentos.DataSource = tbTratamentos
        lstTratamentos.DisplayMember = "produto"
        lstTratamentos.ValueMember = "cod_produto"
    End Sub

    Private Sub btnConcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConcluir.Click
        If txtVendedorExterno.Text = String.Empty Then
            MessageBox.Show("Por favor informar o código do vendedor externo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtVendedorExterno.Focus()
            Exit Sub
        End If

        os.editar()
        os.cod_surfacagem = cbSurfacagem.SelectedValue
        os.cod_montagem = cbMontagem.SelectedValue
        os.cor_coloracao = txtCorColoracao.Text
        os.data_previsao_entrega = dtPrevisaoEntrega.Value
        os.hora_previsao_entrega = txtHoraPrevisaoEntrega.Text
        os.observacao = txtObs.Text.Replace("'", "``")
        os.cod_vendedora = intUsuario
        os.id_laboratorio = cbLaboratorio.SelectedValue
        os.doc_cliente = txtDocCliente.Text
        If os.tem_bloco Then
            'Caso haja blocos, indica que o laboratório de surfaçagem a
            'ser usado é o de número 1, laboratório da Labonorte.
            os.cod_lab_surf = 1
        End If

        'Novo
        If novo = False Then
            atualiza_servicos(os.num_pedido, os.id_filial)
        End If
        'Fim Novo

        Dim res As String
        Dim vautorizado As Double
        res = os.row_editado
        If res.StartsWith("OK") Then
            MessageBox.Show(os.Salvar(), "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If novo = False Then
                MessageBox.Show(andamentos.insere_andamento(objAndamentos.tipo.alteracao_os,
                                os.id_filial, os.cod_os, intUsuario, res.Substring(3)) & "Nº da OS: " & os.cod_os,
                                "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If tipo_acao = ACAO.TROCA_DIOPTRIA Or tipo_acao = ACAO.TROCA_PRODUTO Then
                    Me.Close()
                    Exit Sub
                End If
            End If
        End If

        If pedido.existe(os.num_pedido, os.id_filial) = False Then
            Dim r As Integer
            If MessageBox.Show("Deseja concluir a OS agora?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                pedido.novo()
                pedido.autorizacao = 0
                pedido.num_pedido = os.num_pedido
                pedido.id_filial = conf.Filial
                pedido.cod_cliente = os.cod_cliente
                pedido.cod_filial_cliente = os.cod_filial_cliente
                pedido.cod_vendedor = intUsuario
                pedido.cod_vendedor_externo = CInt(txtVendedorExterno.Text)
                pedido.data_pedido = Now
                pedido.forma_pagamento = 1 'Forma de pagamento Apenas dinheiro
                'If (intContador = 1) Or (intContador = 2) Then
                'pedido.forma_pagamento = 1
                'Else
                '   pedido.forma_pagamento = 0
                'End If
                pedido.Salvar()
                os.editar()
                os.num_pedido = pedido.num_pedido
                os.cod_fase = Fases_os.Verificacao
                os.data_verificacao = d.hora
                MessageBox.Show(os.Salvar() & vbCrLf & " número da OS: " & os.cod_os, "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)

                SplashScreenManager1.ShowWaitForm()
                andamentos.insere_andamento(objAndamentos.tipo.verificacao_os, os.id_filial,
                os.cod_os, intUsuario, "")

                inserir_produtos(pedido.num_pedido, pedido.id_filial)

                Dim f As New frmPedido
                f._num_pedido = os.num_pedido
                f._id_filial = os.id_filial
                f.txtVendedorExterno.Text = CInt(txtVendedorExterno.Text)
                f.intContador = intContador
                f.strOS = "S"
                f.Show()
                Me.Close()
                f.Focus()
            End If
            SplashScreenManager1.CloseWaitForm()
        End If
        Me.Close()
    End Sub

    Private Function valor_autorizacao() As Decimal
        Dim valor As Decimal
        Dim m, i As Int32
        'OD
        prod.filtra(os.cod_produto_od)
        valor = pedido.valor_item(prod.Preco_venda, 1, prod.desconto(os.cod_cliente, os.cod_filial_cliente))
        'OE
        prod.filtra(os.cod_produto_oe)
        valor = valor +
        pedido.valor_item(prod.Preco_venda, 1, prod.desconto(os.cod_cliente, os.cod_filial_cliente))
        'Surfacagem
        If chkSurfacagem.Checked Then
            prod.filtra(cbSurfacagem.SelectedValue)
            valor = valor +
            pedido.valor_item(prod.Preco_venda, os.OlhosBloco, prod.desconto(os.cod_cliente, os.cod_filial_cliente))
        End If
        'Montagem
        If chkMontagem.Checked Then
            prod.filtra(cbMontagem.SelectedValue)
            valor = valor +
            pedido.valor_item(prod.Preco_venda, os.olhos, prod.desconto(os.cod_cliente, os.cod_filial_cliente))
        End If
        If os.coloracao <> 0 Then
            prod.filtra(os.coloracao)
            valor = valor +
            pedido.valor_item(prod.Preco_venda, os.olhos, prod.desconto(os.cod_cliente, os.cod_filial_cliente))
        End If
        'Tratamentos
        m = tbTratamentos.Rows.Count
        i = 0
        While i < m
            prod.filtra(tbTratamentos.Rows(i)("cod_produto"))
            valor = valor +
            pedido.valor_item(prod.Preco_venda, os.olhos, prod.desconto(os.cod_cliente, os.cod_filial_cliente))
            i = i + 1
        End While
        Return valor
    End Function
    Private Sub PrintOS()
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
        "FROM OS where OS.id_filial = " & os.id_filial &
        "and OS.cod_os = " & os.cod_os & ""
        d.carrega_Tabela(tsql, tt)
        r.DataSource = tt
        r.Fila = False
        f.Relat(r)
        f.ShowDialog(Me)
    End Sub
    Private Sub chkColoracao_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkColoracao.CheckedChanged
        If chkColoracao.Checked = True Then
            os.coloracao = 16083
        Else
            os.coloracao = Nothing
            txtCorColoracao.Text = Nothing
        End If
    End Sub
    Private Sub inserir_produtos(ByVal x_num_pedido As Integer, ByVal x_id_filial As Integer)
        Dim p As New produtoClass
        Dim i, m As Integer
        Dim status_item As Integer = 1
        Dim fase_os As Fases_os
        Dim xPedido As New objPedidoBalcao
        Dim intTotalEstoque As Integer
        'Processando olho direito
        Dim strSQLOD As String = "Select * from produtos where cod_produto = " & os.cod_produto_od & ""
        Dim ttProdutoOD As New DataTable
        Dim intItem As Int16 = 0

        'Guarda os registros encontrados referente aos produtos
        ttProdutoOD = osMaster.retornaRegistro(strSQLOD).Tables(0)
        intTotalEstoque = osMaster.saldo_estoque(ttProdutoOD.Rows(0)("cod_produto"), conf.Filial)

        'Avalia se há estoque na Loja para Atender ao pedido
        If intTotalEstoque >= 1 Then
            'Caso haja estoque, Efetua reserva do Produto
            Dim sql_res As String
            fase_os = Fases_os.Estoque_Aguardando_Processamento
            status_item = status_item_pedido.reservado
            andamentos.insere_andamento(objAndamentos.tipo.Reserva_lente, os.id_filial,
            os.cod_os, UserID, "Reserva de Lente do olho Direito")
        Else
            'Caso não haja estoque, efetua sugestão de pedido
            status_item = status_item_pedido.Aguardando_processamento
            'Marca na OS a fase Estoque \ Aguardando Pedido
            fase_os = Fases_os.Estoque_Aguardando_Pedido
            andamentos.insere_andamento(objAndamentos.tipo.sugestao_pedido, os.id_filial,
            os.cod_os, UserID, "Lente do olho Direito aguardando pedido")
        End If

        Dim ttPacoteOD As New DataTable
        ttPacoteOD = osMaster.lista_itens_com_saldo_pacote(os.cod_tab_od, os.cod_cliente, os.cod_filial_cliente)
        Dim valorcompraOD As Double = Format(ttProdutoOD.Rows(0)("preco_compra") - (ttProdutoOD.Rows(0)("preco_compra") * ttProdutoOD.Rows(0)("desconto_compra") / 100), "#,##0.00")
        Dim valorprecoOD As Double = Format(ttProdutoOD.Rows(0)("preco_venda") * ttProdutoOD.Rows(0)("fator_preco") - (ttProdutoOD.Rows(0)("preco_venda") * ttProdutoOD.Rows(0)("desconto") / 100), "#,##0.00")

        If ttPacoteOD.Rows.Count > 0 Then
            'Instrução responsável por verificar se existem débitos em aberto de pacote caso exista o produto do pacote não é colocado
            'Como de pacote e sim como um produto normal. 11/11/2014
            Dim strSQLCredito As String = ""
            If ttPacoteOD.Rows(0)("cod_pacote_ant") = 0 Then
                strSQLCredito = "Select cod_credito from credito_pacote where cod_cliente = " & os.cod_cliente &
                    " and cod_filial_cliente = " & os.cod_filial_cliente & " and cod_pacote = " & ttPacoteOD.Rows(0)("cod_pacote")
            Else
                strSQLCredito = "Select cod_credito from credito_pacote where cod_cliente = " & os.cod_cliente &
                    " and cod_filial_cliente = " & os.cod_filial_cliente & " and cod_pacote = " & ttPacoteOD.Rows(0)("cod_pacote_ant")
            End If

            Dim tbCredito As New DataTable
            tbCredito = osMaster.retornaRegistro(strSQLCredito).Tables(0)

            Dim strSQLCreditoLanc As String = "Select * From Pagamentos_Credito where cod_credito = " & tbCredito.Rows(0)("cod_credito") & " and id_filial = " & conf.Filial

            Dim tbCreditoLanc As New DataTable
            tbCreditoLanc = osMaster.retornaRegistro(strSQLCreditoLanc).Tables(0)
            For Each linha As DataRow In tbCreditoLanc.Rows
                Dim strSQLLanc As String = "Select cod_lancamento, data_vencimento, data_recebimento from lancamentos where cod_lancamento = " & linha("cod_lancamento") &
                    " and id_filial = " & conf.Filial
                Dim tbLancamento As New DataTable
                tbLancamento = osMaster.retornaRegistro(strSQLLanc).Tables(0)
                If (DateAdd(DateInterval.Day, 6, tbLancamento.Rows(0)("data_vencimento")) < Now) And tbLancamento.Rows(0)("data_recebimento") Is DBNull.Value Then
                    MessageBox.Show("Cliente não poderá usar item de pacote existente." & Chr(13) & "Débito em aberto referente ao pacote nº " & ttPacoteOD.Rows(0)("cod_pacote"),
                                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    GoTo s_pacoteOD
                End If
            Next
            'Fim - 11/11/2014

            Dim strSQLPacoteOD As String = "Select 1 From Pacote_cliente where cod_pacote = " & ttPacoteOD.Rows(0)("cod_pacote") & " and cod_cliente = " & ttPacoteOD.Rows(0)("cod_cliente") &
                " and concluido = 'S'"
            If osMaster.verifica_existencia_registro(strSQLPacoteOD) = True Then
                sql_item = "Insert into pedido_balcao_itens (num_pedido," &
                "id_filial,item,cod_produto,quant,compra,desconto,preco,cod_status_item,pacote,cod_pacote,preco_tab,preco_fat) " &
                "values(" & os.num_pedido & "," & conf.Filial & "," & 1 & "," &
                os.cod_produto_od & "," & 1 & "," & d.cdin(valorcompraOD) &
                 "," & d.cdin(ttPacoteOD.Rows(0)("desconto")) & "," &
                 d.cdin(ttPacoteOD.Rows(0)("preco_desc")) & "," & status_item &
                ",'S'," & ttPacoteOD.Rows(0)("cod_pacote") & "," & d.cdin(ttPacoteOD.Rows(0)("preco_tabela")) & "," &
                d.cdin(ttPacoteOD.Rows(0)("preco_desc")) & ")"
                osMaster.grava_registros(sql_item, True)
            Else
                GoTo s_pacoteOD
            End If
        Else
s_pacoteOD: sql_item = "Insert into pedido_balcao_itens (num_pedido," &
            "id_filial,item,cod_produto,quant,compra,desconto,preco,cod_status_item, preco_tab, preco_fat) " &
            "values(" & os.num_pedido & "," & conf.Filial & "," & 1 & "," &
            os.cod_produto_od & "," & 1 & "," & d.cdin(valorcompraOD) &
            "," & d.cdin(CDbl(0.0)) & "," &
            d.cdin(valorprecoOD) & "," & status_item &
            "," & d.cdin(valorprecoOD) & "," &
            d.cdin(valorprecoOD) & ")"
            osMaster.grava_registros(sql_item, True)
        End If


        ''''
        'xPedido.insere_item(x_num_pedido, x_id_filial, p.fldCod_produto, 1, p.desconto(os.cod_cliente, os.cod_filial_cliente), p.Preco_venda, status_item)
        'Processando olho esquerdo
        status_item = Nothing

        Dim strSQLOE As String = "Select * from produtos where cod_produto = " & os.cod_produto_oe & ""
        Dim ttProdutoOE As New DataTable

        'Guarda os registros encontrados referente aos produtos
        ttProdutoOE = osMaster.retornaRegistro(strSQLOE).Tables(0)
        intTotalEstoque = osMaster.saldo_estoque(ttProdutoOE.Rows(0)("cod_produto"), conf.Filial)
        If intTotalEstoque >= 1 Then
            Dim sql_res As String
            status_item = status_item_pedido.reservado
            andamentos.insere_andamento(objAndamentos.tipo.Reserva_lente, os.id_filial,
            os.cod_os, UserID, "Reserva de Lente do olho Esquerdo")
            If fase_os <> Fases_os.Estoque_Aguardando_Pedido Then
                fase_os = Fases_os.Estoque_Aguardando_Processamento
            End If
        Else
            os.Sugere_compra(p.fldCod_produto, os.doc_cliente)
            status_item = status_item_pedido.Aguardando_processamento
            fase_os = Fases_os.Estoque_Aguardando_Pedido
            andamentos.insere_andamento(objAndamentos.tipo.sugestao_pedido, os.id_filial,
           os.cod_os, UserID, "Lente do olho Esquerdo aguardando pedido")
        End If

        '''
        Dim ttPacoteOE As New DataTable
        ttPacoteOE = osMaster.lista_itens_com_saldo_pacote(os.cod_tab_oe, os.cod_cliente, os.cod_filial_cliente)
        Dim valorcompraOE As Double = Format(ttProdutoOE.Rows(0)("preco_compra") - (ttProdutoOE.Rows(0)("preco_compra") * ttProdutoOE.Rows(0)("desconto_compra") / 100), "#,##0.00")
        Dim valorprecoOE As Double = Format(ttProdutoOE.Rows(0)("preco_venda") * ttProdutoOE.Rows(0)("fator_preco") - (ttProdutoOE.Rows(0)("preco_venda") * ttProdutoOE.Rows(0)("desconto") / 100), "#,##0.00")

        If ttPacoteOE.Rows.Count > 0 Then
            'Instrução responsável por verificar se existem débitos em aberto de pacote caso exista o produto do pacote não é colocado
            'Como de pacote e sim como um produto normal. 11/11/2014
            Dim strSQLCredito As String = ""
            If ttPacoteOE.Rows(0)("cod_pacote_ant") = 0 Then
                strSQLCredito = "Select cod_credito from credito_pacote where cod_cliente = " & os.cod_cliente &
                    " and cod_filial_cliente = " & os.cod_filial_cliente & " and cod_pacote = " & ttPacoteOE.Rows(0)("cod_pacote")
            Else
                strSQLCredito = "Select cod_credito from credito_pacote where cod_cliente = " & os.cod_cliente &
                    " and cod_filial_cliente = " & os.cod_filial_cliente & " and cod_pacote = " & ttPacoteOE.Rows(0)("cod_pacote_ant")
            End If

            Dim tbCredito As New DataTable
            tbCredito = osMaster.retornaRegistro(strSQLCredito).Tables(0)
            Dim strSQLCreditoLanc As String = "Select * From Pagamentos_Credito where cod_credito = " & tbCredito.Rows(0)("cod_credito") & " and id_filial = " & conf.Filial
            Dim tbCreditoLanc As New DataTable
            tbCreditoLanc = osMaster.retornaRegistro(strSQLCreditoLanc).Tables(0)
            For Each linha As DataRow In tbCreditoLanc.Rows
                Dim strSQLLanc As String = "Select cod_lancamento, data_vencimento, data_recebimento from lancamentos where cod_lancamento = " & linha("cod_lancamento") &
                    " and id_filial = " & conf.Filial
                Dim tbLancamento As New DataTable
                tbLancamento = osMaster.retornaRegistro(strSQLLanc).Tables(0)
                If (DateAdd(DateInterval.Day, 6, tbLancamento.Rows(0)("data_vencimento")) < Now) And tbLancamento.Rows(0)("data_recebimento") Is DBNull.Value Then
                    MessageBox.Show("Cliente não poderá usar item de pacote existente." & Chr(13) & "Débito em aberto referente ao pacote nº " & ttPacoteOE.Rows(0)("cod_pacote"),
                                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    GoTo s_pacoteOE
                End If
            Next
            'Fim - 11/11/2014

            Dim strSQLPacoteOE As String = "Select 1 From Pacote_cliente where cod_pacote = " & ttPacoteOE.Rows(0)("cod_pacote") & " and cod_cliente = " & ttPacoteOE.Rows(0)("cod_cliente") &
                    " and concluido = 'S'"
            If osMaster.verifica_existencia_registro(strSQLPacoteOE) = True Then
                If os.cod_produto_od = 0 Then
                    intItem = 1
                Else
                    intItem = 2
                End If
                sql_item = "Insert into pedido_balcao_itens (num_pedido," &
                "id_filial,item,cod_produto,quant,compra,desconto,preco,cod_status_item,pacote,cod_pacote, preco_tab, preco_fat) " &
                "values(" & os.num_pedido & "," & conf.Filial & "," & intItem & "," &
                os.cod_produto_oe & "," & 1 & "," & d.cdin(valorcompraOE) &
                 "," & d.cdin(ttPacoteOE.Rows(0)("desconto")) & "," &
                 d.cdin(ttPacoteOE.Rows(0)("preco_desc")) & "," & status_item &
                ",'S'," & ttPacoteOE.Rows(0)("cod_pacote") & "," & d.cdin(ttPacoteOE.Rows(0)("preco_tabela")) & "," &
                d.cdin(ttPacoteOE.Rows(0)("preco_desc")) & ")"
                osMaster.grava_registros(sql_item, True)
            Else
                GoTo s_pacoteOE
            End If
        Else
s_pacoteOE:
            If os.cod_produto_od = 0 Then
                intItem = 1
            Else
                intItem = 2
            End If
            sql_item = "Insert into pedido_balcao_itens (num_pedido," &
            "id_filial,item,cod_produto,quant,compra,desconto,preco,cod_status_item, preco_tab, preco_fat) " &
            "values(" & os.num_pedido & "," & conf.Filial & "," & intItem & "," &
            os.cod_produto_oe & "," & 1 & "," & d.cdin(valorcompraOE) &
            "," & d.cdin(CDbl(0.0)) & "," &
            d.cdin(valorprecoOE) & "," & status_item &
            "," & d.cdin(valorprecoOE) & "," &
            d.cdin(valorprecoOE) & ")"
            osMaster.grava_registros(sql_item, True)
        End If
        ''


        'xPedido.insere_item(x_num_pedido, x_id_filial, p.fldCod_produto, 1, p.desconto(os.cod_cliente, os.cod_filial_cliente), p.Preco_venda, status_item)
        'Processando Serviços
        Dim Olhos As Integer = 0
        Dim olhosBloco As Integer = 0
        Olhos = os.olhos
        olhosBloco = os.OlhosBloco
        Dim xpac As Integer = 0  'Guarda o código do pacote se existir
        Dim xSurf As Integer = 0 'Guarda o código da surfaçagem do pacote se existir
        Dim xMont As Integer = 0 'Guarda o código da montagem do pacote se existir
        Dim dSurf As Integer = 0 'Guarda o desconto da surfaçagem de pacote se existir
        Dim dMont As Integer = 0 'Guarda o desconto da montagem de pacote se existir
        Dim xTrat As Integer = 0 'Guarda o desconto da montagem de pacote se existir
        Dim dTrat As Integer = 0 'Guarda o desconto da montagem de pacote se existir
        Dim pSurf As Double = 0 'Guarda o preço da surfasagem
        Dim pMont As Double = 0 'Guarda o preço da montagem
        Dim pTrat As Double = 0 'Guarda o preço do tratamento

        Dim xPacote As New objPacoteClienteDetalhes
        Dim ttPacote As New DataTable
        Try
            ttPacote = xPedido.lista_itens(os.num_pedido, os.id_filial, False)
            xpac = ttPacote.Rows(0)("cod_pacote")
        Catch ex As Exception
            xpac = 0
        End Try

        If xpac > 0 Then
            Dim tt As New DataTable 'Tabela temporaria para guardar o item do pacote
            'xPacote.filtra(os.cod_cliente, os.cod_filial_cliente, xpac)
            Dim strSQLPacote As String = "select * from pacote_cliente_detalhes where cod_cliente = " & _
            os.cod_cliente & " and cod_filial_cliente = " & os.cod_filial_cliente & " and cod_pacote = " & xpac & " and cod_tabela = " & os.cod_tab_od
            tt = osMaster.retornaRegistro(strSQLPacote).Tables(0)
            'tt = xPacote.lista_item(os.cod_tab_od)
            If tt.Rows.Count > 0 Then
                'Se o produto da OS inserido no pedido for um item de pacote, verifica
                'se esse item tem serviços de montagem e surfaçagem com desconto no pacote
                'e os armazena nas variáveis
                xSurf = tt.Rows(0)("cod_surf")
                dSurf = tt.Rows(0)("desc_surf")
                pSurf = tt.Rows(0)("preco_surf_desc")
                pSurfTab = tt.Rows(0)("preco_tabela_surf")
                xMont = tt.Rows(0)("cod_mont")
                dMont = tt.Rows(0)("desc_mont")
                pMont = tt.Rows(0)("preco_mont_desc")
                pMontTab = tt.Rows(0)("preco_tabela_mont")
                xTrat = tt.Rows(0)("cod_trat")
                dTrat = tt.Rows(0)("desc_trat")
                pTrat = tt.Rows(0)("preco_trat_desc")
                pTratTab = tt.Rows(0)("preco_tabela_trat")
            End If
        End If

        If os.cod_surfacagem <> 0 Then
            If xSurf <> 0 Then 'verifica se a surfaçagem está inclusa no pacote.
                If os.cod_surfacagem <> xSurf Then
                    'Caso a surfaçagem da Os esteja diferente do pacote, altera na OS.
                    os.editar()
                    os.cod_surfacagem = xSurf
                    os.Salvar()
                End If
                'Seleciona o produto referente à surfaçagem e insere o serviço
                'no pedido com o desconto do pacote.
                p.Source("Select * from produtos where cod_produto = " & os.cod_surfacagem & "")
                If olhosBloco = 0 Then
                    olhosBloco = InputBox("Não há produtos na OS, deseja cobrar pela Surfaçagem? (digite 0 para não, 1 ou 2 para cobrar)")
                    If olhosBloco > 2 Then olhosBloco = 2
                End If
                'Ivanildo 06/01/2015
                If olhosBloco = 1 Then
                    olhosBloco = 1
                Else
                    olhosBloco = Olhos
                End If
                'Fim Ivanildo
                xPedido.insere_servico(x_num_pedido, x_id_filial, xSurf, olhosBloco, dSurf, pSurf, 1, xpac, "S", pSurfTab)
            Else
                'Caso a surfaçagem não seja do pacote, selecina o produto referente
                'à surfaçagem e insere no pedido com preço normal
                p.Source("Select * from produtos where cod_produto = " & os.cod_surfacagem & "")
                If olhosBloco = 0 Then
                    olhosBloco = InputBox("Não há produtos na OS, deseja cobrar pela Surfaçagem? (digite 0 para não, 1 ou 2 para cobrar)")
                    If olhosBloco > 2 Then olhosBloco = 2
                End If
                'Ivanildo 06/01/2015
                If olhosBloco = 1 Then
                    olhosBloco = 1
                Else
                    olhosBloco = Olhos
                End If
                'Fim Ivanildo
                xPedido.insere_servico(x_num_pedido, x_id_filial, p.fldCod_produto, olhosBloco, p.fldDesconto, p.fldPreco_venda, 1, xpac, Nothing, p.fldPreco_venda)
            End If
        End If
        If os.cod_montagem <> 0 Then
            If xMont <> 0 Then 'Verifica se a montagem está inclusa no pacote.
                If os.cod_montagem <> xMont Then
                    'Caso a montagem da OS esteja diferente do pacote, altera na OS.
                    os.editar()
                    os.cod_montagem = xMont
                    os.Salvar()
                End If
                'Seleciona o produto referente à montagem e insere o serviço
                'no pedido com o desconto do pacote.
                p.Source("Select * from produtos where cod_produto = " & os.cod_montagem & "")
                If Olhos = 0 Then
                    Olhos = InputBox("Não há produtos na OS, deseja cobrar pela Montagem? (digite 0 para não, 1 ou 2 para cobrar)")
                    If Olhos > 2 Then Olhos = 2
                End If
                xPedido.insere_servico(x_num_pedido, x_id_filial, xMont, Olhos, dMont, pMont, 1, xpac, "S", pMontTab)
            Else
                'Caso a montagem não seja do pacote, selecina o produto referente
                'à surfaçagem e insere no pedido com preço normal
                p.Source("Select * from produtos where cod_produto = " & os.cod_montagem & "")
                If Olhos = 0 Then
                    Olhos = InputBox("Não há produtos na OS, deseja cobrar pela Montagem? (digite 0 para não, 1 ou 2 para cobrar)")
                    If Olhos > 2 Then Olhos = 2
                End If
                xPedido.insere_servico(x_num_pedido, x_id_filial, p.fldCod_produto, Olhos, p.fldDesconto, p.fldPreco_venda, 1, xpac, Nothing, p.fldPreco_venda)
            End If
        End If
        If os.coloracao <> 0 Then
            p.Source("Select * from produtos where cod_produto = " & os.coloracao & "")
            If Olhos = 0 Then
                Olhos = InputBox("Não há produtos na OS, deseja cobrar pela coloração? (digite 0 para não, 1 ou 2 para cobrar)")
                If Olhos > 2 Then Olhos = 2
            End If
            xPedido.insere_servico(x_num_pedido, x_id_filial, p.fldCod_produto, Olhos, p.fldDesconto, p.fldPreco_venda, 1, xpac, Nothing, p.fldPreco_venda)
        End If
        m = tbTratamentos.Rows.Count
        While i < m
            p.Source("Select * from produtos where cod_produto = " & tbTratamentos.Rows(i)("cod_produto") & "")
            If Olhos = 0 Then
                Olhos = InputBox("Não há produtos na OS, deseja cobrar pelo tratamento? (digite 0 para não, 1 ou 2 para cobrar)")
                If Olhos > 2 Then Olhos = 2
            End If
            'Ivanildo 06/01/2015
            If olhosBloco = 1 Then
                olhosBloco = 1
            Else
                olhosBloco = Olhos
            End If
            'Fim Ivanildo
            xPedido.insere_servico(x_num_pedido, x_id_filial, p.fldCod_produto, olhosBloco, p.fldDesconto, p.fldPreco_venda, 1, xpac, Nothing, p.fldPreco_venda)
            i = i + 1
        End While
    End Sub
    Private Function pode_surfacar() As Boolean
        If os.tem_bloco = False And chkSurfacagem.Checked = True Then
            MessageBox.Show("Nenhum dos produtos da OS é bloco, portanto não pode haver surfaçagem.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            chkSurfacagem.Checked = False
            Return False
        Else
            Return True
        End If
    End Function
    Private Function valida_conclusao() As Boolean
        Dim valido As Boolean = True
        If pode_surfacar() = False Then
            valido = False
        End If
        Return valido
    End Function
    Private Sub cbSurfacagem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbSurfacagem.Click
        cbSurfacagem.SelectedValue = prod.tipo_surfacagem(os.cod_produto_od)
    End Sub
#End Region
#Region "Bloqueios"
    Private Sub bloqueia_tab_Armacao()
        travaControles(grpArmacao.Controls)
        travaControles(grpCliente.Controls)
        travaControles(grpOftalm.Controls)
    End Sub
#End Region
    Private Sub txtBaseOD_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBaseOD.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Dim base As Double
                Try
                    base = InputBox("Digite a base desejada!")
                Catch ex As Exception

                End Try
                If Existe_od(base) = 0 Then
                    MessageBox.Show("Esta base informada não existe.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Else
                    txtBaseOD.Text = base
                    os.cod_produto_od = Existe_od(base)
                    lblCodPOD.Text = os.cod_produto_od
                    prod.filtra(os.cod_produto_od)
                    txtEstoqueOD.Text = prod.Retorna_nome_prod(os.cod_produto_od) & " Barra: " & prod.fldCod_barra & ""
                End If
        End Select
    End Sub
    Private Sub txtBaseOe_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBaseOE.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Dim base As Double
                Try
                    base = InputBox("Digite a base desejada!")
                Catch ex As Exception

                End Try
                If existe_oe(base) = 0 Then
                    MessageBox.Show("Esta base informada não existe.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Else
                    txtBaseOE.Text = base
                    os.cod_produto_oe = existe_oe(base)
                    lblCodPOE.Text = os.cod_produto_oe
                    prod.filtra(os.cod_produto_oe)
                    txtEstoqueOE.Text = prod.Retorna_nome_prod(os.cod_produto_oe) & " Barra: " & prod.fldCod_barra & ""
                End If
        End Select
    End Sub
    Private Function Existe_od(ByVal base As Double) As Integer
        Dim cod_prod As Integer
        Dim o As String

        If os.tipo_receita_OD = tipo_Receita.PROGRESSIVA Or os.tipo_receita_OD = tipo_Receita.BIFOCAL Then
            o = "D"
            If os.cod_tab_od = "11003" Or os.cod_tab_od = "110032" Or os.cod_tab_od = "11139" Or os.cod_tab_od = "111392" _
            Or os.cod_tab_od = "11051" Or os.cod_tab_od = "11011" Or os.cod_tab_od = "11055" Then
                o = "A"
            End If
        Else
            o = "A"
        End If
        cod_prod = prod.Retorna_cod_prod(os.cod_tab_od, os.adicao_od, base, o)
        If cod_prod <> 0 Then
            prod.filtra(cod_prod)
            Return cod_prod
        Else
            Return 0
        End If
    End Function
    Private Function existe_oe(ByVal base As Double) As Integer
        Dim cod_prod As Integer
        Dim o As String
        If os.tipo_receita_OE = tipo_Receita.PROGRESSIVA Or os.tipo_receita_OE = tipo_Receita.BIFOCAL Then
            o = "E"
            If os.cod_tab_oe = "11003" Or os.cod_tab_oe = "110032" Or os.cod_tab_oe = "11139" Or os.cod_tab_oe = "111392" _
            Or os.cod_tab_oe = "11051" Or os.cod_tab_oe = "11011" Or os.cod_tab_oe = "11055" Then
                o = "A"
            End If
        Else
            o = "A"
        End If
        cod_prod = prod.Retorna_cod_prod(os.cod_tab_oe, os.adicao_oe, base, o)
        If cod_prod <> 0 Then
            prod.filtra(cod_prod)
            'AVISO("Quantidade de " & prod.fldProduto & " :" & prod.saldo_estoque_local(cod_prod, confFilial) & _
            'prod.fldUnd & ".", Me, frmAviso.tipo_aviso.tipo_ok)
            Return cod_prod
        Else
            Return 0
        End If
    End Function

    Private Sub atualiza_servicos(ByVal x_num_pedido As Integer, ByVal x_id_filial As Integer)
        Dim p As New produtoClass
        Dim i, m As Integer
        Dim status_item As Integer = 1
        Dim fase_os As Fases_os
        Dim xPedido As New objPedidoBalcao
        Dim intTotalEstoque As Integer
        '''
        'xPedido.insere_item(x_num_pedido, x_id_filial, p.fldCod_produto, 1, p.desconto(os.cod_cliente, os.cod_filial_cliente), p.Preco_venda, status_item)
        'Processando Serviços
        Dim Olhos As Integer = 0
        Dim olhosBloco As Integer = 0
        Olhos = os.olhos
        olhosBloco = os.OlhosBloco
        Dim xpac As Integer = 0  'Guarda o código do pacote se existir
        Dim xSurf As Integer = 0 'Guarda o código da surfaçagem do pacote se existir
        Dim xMont As Integer = 0 'Guarda o código da montagem do pacote se existir
        Dim dSurf As Integer = 0 'Guarda o desconto da surfaçagem de pacote se existir
        Dim dMont As Integer = 0 'Guarda o desconto da montagem de pacote se existir
        Dim xTrat As Integer = 0 'Guarda o desconto da montagem de pacote se existir
        Dim dTrat As Integer = 0 'Guarda o desconto da montagem de pacote se existir
        Dim pSurf As Double = 0 'Guarda o preço da surfasagem
        Dim pMont As Double = 0 'Guarda o preço da montagem
        Dim pTrat As Double = 0 'Guarda o preço do tratamento

        Dim xPacote As New objPacoteClienteDetalhes
        Dim ttPacote As New DataTable
        Try
            ttPacote = xPedido.lista_itens(os.num_pedido, os.id_filial, False)
            xpac = ttPacote.Rows(0)("cod_pacote")
        Catch ex As Exception
            xpac = 0
        End Try

        If xpac > 0 Then
            Dim tt As New DataTable 'Tabela temporaria para guardar o item do pacote
            'xPacote.filtra(os.cod_cliente, os.cod_filial_cliente, xpac)
            Dim strSQLPacote As String = "select * from pacote_cliente_detalhes where cod_cliente = " & _
            os.cod_cliente & " and cod_filial_cliente = " & os.cod_filial_cliente & " and cod_pacote = " & xpac & " and cod_tabela = " & os.cod_tab_od
            tt = osMaster.retornaRegistro(strSQLPacote).Tables(0)
            'tt = xPacote.lista_item(os.cod_tab_od)
            If tt.Rows.Count > 0 Then
                'Se o produto da OS inserido no pedido for um item de pacote, verifica
                'se esse item tem serviços de montagem e surfaçagem com desconto no pacote
                'e os armazena nas variáveis
                xSurf = tt.Rows(0)("cod_surf")
                dSurf = tt.Rows(0)("desc_surf")
                pSurf = tt.Rows(0)("preco_surf_desc")
                pSurfTab = tt.Rows(0)("preco_tabela_surf")
                xMont = tt.Rows(0)("cod_mont")
                dMont = tt.Rows(0)("desc_mont")
                pMont = tt.Rows(0)("preco_mont_desc")
                pMontTab = tt.Rows(0)("preco_tabela_mont")
                xTrat = tt.Rows(0)("cod_trat")
                dTrat = tt.Rows(0)("desc_trat")
                pTrat = tt.Rows(0)("preco_trat_desc")
                pTratTab = tt.Rows(0)("preco_tabela_trat")
            End If
        End If

        Dim strSQLSur As String = "Select cod_surfacagem from os where cod_os = " & os.cod_os & " and id_filial = " & os.id_filial & " and cod_cliente = " & os.cod_cliente
        Dim ttSurf As New DataTable
        ttSurf = osMaster.retornaRegistro(strSQLSur).Tables(0)
        If ttSurf.Rows.Count > 0 Then
            If Not ttSurf.Rows(0)("cod_surfacagem") Is DBNull.Value Then
                If ttSurf.Rows(0)("cod_surfacagem") <> os.cod_surfacagem Then
                    Dim strSQLDel As String = "where num_pedido = " & os.num_pedido & " and id_filial = " & os.id_filial & " and cod_servico = " & intCodSurf
                    osMaster.excluir_registros("pedido_balcao_servicos", strSQLDel, True)
                End If
            End If
        End If

        If os.cod_surfacagem <> 0 Then
            Dim strSQL As String = "select 1 from pedido_balcao_servicos where num_pedido = " & os.num_pedido & " and id_filial = " & os.id_filial & _
            " and cod_servico = " & os.cod_surfacagem
            If xSurf <> 0 Then 'verifica se a surfaçagem está inclusa no pacote.
                If os.cod_surfacagem <> xSurf Then
                    'Caso a surfaçagem da Os esteja diferente do pacote, altera na OS.
                    os.editar()
                    os.cod_surfacagem = xSurf
                    os.Salvar()
                End If
                'Seleciona o produto referente à surfaçagem e insere o serviço
                'no pedido com o desconto do pacote.
                p.Source("Select * from produtos where cod_produto = " & os.cod_surfacagem & "")
                If olhosBloco = 0 Then
                    olhosBloco = InputBox("Não há produtos na OS, deseja cobrar pela Surfaçagem? (digite 0 para não, 1 ou 2 para cobrar)")
                    If olhosBloco > 2 Then olhosBloco = 2
                End If
                If osMaster.verifica_existencia_registro(strSQL) = False Then
                    xPedido.insere_servico(x_num_pedido, x_id_filial, xSurf, olhosBloco, dSurf, pSurf, 1, xpac, "S", pSurfTab)
                End If
            Else
                'Caso a surfaçagem não seja do pacote, selecina o produto referente
                'à surfaçagem e insere no pedido com preço normal
                p.Source("Select * from produtos where cod_produto = " & os.cod_surfacagem & "")
                If olhosBloco = 0 Then
                    olhosBloco = InputBox("Não há produtos na OS, deseja cobrar pela Surfaçagem? (digite 0 para não, 1 ou 2 para cobrar)")
                    If olhosBloco > 2 Then olhosBloco = 2
                End If
                If osMaster.verifica_existencia_registro(strSQL) = False Then
                    xPedido.insere_servico(x_num_pedido, x_id_filial, p.fldCod_produto, Olhos, p.fldDesconto, p.fldPreco_venda, 1, xpac, Nothing, p.fldPreco_venda)
                End If
            End If
        End If


        Dim strSQLMont As String = "Select cod_montagem from os where cod_os = " & os.cod_os & " and id_filial = " & os.id_filial & " and cod_cliente = " & os.cod_cliente
        Dim ttMont As New DataTable
        ttMont = osMaster.retornaRegistro(strSQLMont).Tables(0)
        If ttMont.Rows.Count > 0 Then
            If Not ttMont.Rows(0)("cod_montagem") Is DBNull.Value Then
                If ttMont.Rows(0)("cod_montagem") <> os.cod_montagem Then
                    Dim strSQLDel As String = "where num_pedido = " & os.num_pedido & " and id_filial = " & os.id_filial & " and cod_servico = " & intCodMont
                    osMaster.excluir_registros("pedido_balcao_servicos", strSQLDel, True)
                End If
            End If
        End If

        If os.cod_montagem <> 0 Then
            Dim strSQL As String = "select 1 from pedido_balcao_servicos where num_pedido = " & os.num_pedido & " and id_filial = " & os.id_filial & _
            " and cod_servico = " & os.cod_montagem
            If xMont <> 0 Then 'Verifica se a montagem está inclusa no pacote.
                If os.cod_montagem <> xMont Then
                    'Caso a montagem da OS esteja diferente do pacote, altera na OS.
                    os.editar()
                    os.cod_montagem = xMont
                    os.Salvar()
                End If
                'Seleciona o produto referente à montagem e insere o serviço
                'no pedido com o desconto do pacote.
                p.Source("Select * from produtos where cod_produto = " & os.cod_montagem & "")
                If Olhos = 0 Then
                    Olhos = InputBox("Não há produtos na OS, deseja cobrar pela Montagem? (digite 0 para não, 1 ou 2 para cobrar)")
                    If Olhos > 2 Then Olhos = 2
                End If
                If osMaster.verifica_existencia_registro(strSQL) = False Then
                    xPedido.insere_servico(x_num_pedido, x_id_filial, xMont, olhosBloco, dMont, pMont, 1, xpac, "S", pMontTab)
                End If
            Else
                'Caso a montagem não seja do pacote, selecina o produto referente
                'à surfaçagem e insere no pedido com preço normal
                p.Source("Select * from produtos where cod_produto = " & os.cod_montagem & "")
                If Olhos = 0 Then
                    Olhos = InputBox("Não há produtos na OS, deseja cobrar pela Montagem? (digite 0 para não, 1 ou 2 para cobrar)")
                    If Olhos > 2 Then Olhos = 2
                End If
                If osMaster.verifica_existencia_registro(strSQL) = False Then
                    xPedido.insere_servico(x_num_pedido, x_id_filial, p.fldCod_produto, Olhos, p.fldDesconto, p.fldPreco_venda, 1, xpac, Nothing, p.fldPreco_venda)
                End If
            End If
        End If


        Dim strSQLColoracao As String = "Select coloracao from os where cod_os = " & os.cod_os & " and id_filial = " & os.id_filial & " and cod_cliente = " & os.cod_cliente
        Dim ttColoracao As New DataTable
        ttColoracao = osMaster.retornaRegistro(strSQLColoracao).Tables(0)
        If ttColoracao.Rows.Count > 0 Then
            If Not ttColoracao.Rows(0)("coloracao") Is DBNull.Value Then
                If ttColoracao.Rows(0)("coloracao") <> os.coloracao Then
                    Dim strSQLDel As String = "where num_pedido = " & os.num_pedido & " and id_filial = " & os.id_filial & " and cod_servico = " & intCodColoracao
                    osMaster.excluir_registros("pedido_balcao_servicos", strSQLDel, True)
                End If
            End If
        End If

        If os.coloracao > 0 Then
            If intCodColoracao <> os.coloracao Then
                Dim strSQLDel As String = "where num_pedido = " & os.num_pedido & " and id_filial = " & os.id_filial & " and cod_servico = " & intCodColoracao
                osMaster.excluir_registros("pedido_balcao_servicos", strSQLDel, True)
            End If
        End If

        If os.coloracao <> 0 Then
            Dim strSQL As String = "select 1 from pedido_balcao_servicos where num_pedido = " & os.num_pedido & " and id_filial = " & os.id_filial & _
            " and cod_servico = " & os.coloracao

            p.Source("Select * from produtos where cod_produto = " & os.coloracao & "")
            If Olhos = 0 Then
                Olhos = InputBox("Não há produtos na OS, deseja cobrar pela coloração? (digite 0 para não, 1 ou 2 para cobrar)")
                If Olhos > 2 Then Olhos = 2
            End If
            If osMaster.verifica_existencia_registro(strSQL) = False Then
                xPedido.insere_servico(x_num_pedido, x_id_filial, p.fldCod_produto, Olhos, p.fldDesconto, p.fldPreco_venda, 1, xpac, Nothing, p.fldPreco_venda)
            End If
        End If

        m = tbTratamentos.Rows.Count
        While i < m
            p.Source("Select * from produtos where cod_produto = " & tbTratamentos.Rows(i)("cod_produto") & "")
            If Olhos = 0 Then
                Olhos = InputBox("Não há produtos na OS, deseja cobrar pelo tratamento? (digite 0 para não, 1 ou 2 para cobrar)")
                If Olhos > 2 Then Olhos = 2
            End If

            Dim strSQL As String = "select 1 from pedido_balcao_servicos where num_pedido = " & os.num_pedido & " and id_filial = " & os.id_filial & _
            " and cod_servico = " & tbTratamentos.Rows(i)("cod_produto")

            If osMaster.verifica_existencia_registro(strSQL) = False Then
                xPedido.insere_servico(x_num_pedido, x_id_filial, p.fldCod_produto, Olhos, p.fldDesconto, p.fldPreco_venda, 1, xpac, Nothing, p.fldPreco_venda)
            End If

            i = i + 1
        End While
    End Sub


    Private Sub txtVendedorExterno_Leave(sender As System.Object, e As System.EventArgs) Handles txtVendedorExterno.Leave
        Dim strSQL As String = "Select nome from usuarios where cod_usuario = " & CInt(txtVendedorExterno.Text)
        Dim ttUsuario As New DataTable
        ttUsuario = osMaster.retornaRegistro(strSQL).Tables(0)
        If ttUsuario.Rows.Count > 0 Then
            lblVendedorExt.Text = ttUsuario.Rows(0)("nome").ToString
            lblVendedorExt.Visible = True
        End If
    End Sub

    Private Sub btnExcluir_Click(sender As System.Object, e As System.EventArgs) Handles btnExcluir.Click
        If MessageBox.Show("Deseja excluir o tratamento selecionado?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim sql As String
            sql = "where id_filial = " & os.id_filial & " and cod_os = " & os.cod_os & " and cod_produto = " & lstTratamentos.SelectedValue
            osMaster.excluir_registros("tratamentos_os", sql, True)
            andamentos.insere_andamento(objAndamentos.tipo.aviso_os, os.id_filial, os.cod_os, _
            UserID, "Tratamento(s) Excluído(s)")
            'Verifica se existem tratamentos gravados na tabela pedido_balcao_servicos, caso exista o tratamento é excluído
            Dim strSQL As String = "select 1 from pedido_balcao_servicos where num_pedido = " & os.num_pedido & " and id_filial = " & os.id_filial & _
                " and cod_servico = " & lstTratamentos.SelectedValue

            If osMaster.verifica_existencia_registro(strSQL) = True Then
                Dim strSQLDel As String = "where num_pedido = " & os.num_pedido & " and id_filial = " & os.id_filial & _
                " and cod_servico = " & lstTratamentos.SelectedValue
                osMaster.excluir_registros("pedido_balcao_servicos", strSQLDel, True)
            End If
            carrega_tratamentos()
        Else
            MessageBox.Show("Operação cancelada com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub chkTratamento_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTratamento.CheckedChanged
        If chkTratamento.Checked = True Then
            Dim strSQL As String = ""
            Dim tbTrat As New DataTable
            strSQL = "SELECT produtos.cod_produto, produtos.produto " & _
            "FROM produtos INNER JOIN " & _
            "servicos ON produtos.cod_produto = servicos.cod_produto " & _
            "WHERE (servicos.cod_tipo_servico = 4)"
            d.carrega_Tabela(strSQL, tbTrat)
            cbTratamento.DataSource = tbTrat
            cbTratamento.DisplayMember = "produto"
            cbTratamento.ValueMember = "cod_produto"
            btnInserirTratamento.Enabled = True
            btnExcluir.Enabled = True
        Else
            lstTratamentos.DataSource = Nothing
            btnInserirTratamento.Enabled = False
            btnExcluir.Enabled = False
        End If
    End Sub

    Private Sub tbFinal_Enter(sender As System.Object, e As System.EventArgs) Handles tbFinal.Enter
        If chkTratamento.Checked = True Then
            btnInserirTratamento.Enabled = True
            btnExcluir.Enabled = True
        Else
            btnInserirTratamento.Enabled = False
            btnExcluir.Enabled = False
        End If
    End Sub

    Private Sub txtDNPODLonge_Leave(sender As System.Object, e As System.EventArgs) Handles txtDNPODLonge.Leave
        If txtDNPODLonge.Text <> String.Empty Then
            If osMaster.validaDNP_longe(txtDNPODLonge.Text, txtDNPOdPerto, os.tipo_receita_OD) = False Then
                MessageBox.Show("Valor da DNP para longe incorreta. Por favor corrigir.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtDNPODLonge.Focus()
                txtDNPODLonge.SelectAll()
                valido_tab_receita = False
                Exit Sub
            Else
                valido_tab_receita = True
                txtDiametroOD.Text = osMaster.calculaDiametro(txtAroHorizontal.Text, txtPonte.Text, txtDNPODLonge.Text, txtMaiorDiametro.Text)
            End If

            If os.tipo_receita_OD = tipo_Receita.VISAO_simples_longe Then
                base_od(txtEsfODLonge.Text, txtCilODLonge.Text, os.tipo_receita_OD)
            End If

            grpOutOd.Enabled = True
            txtAdicaoOD.Focus()

            If txtAdicaoOD.Enabled = False Then
                If txtAlturaOD.Text = String.Empty Then
                    txtAlturaOD.Focus()
                Else
                    txtAdicaoOD.Focus()
                End If
            End If

            If txtAdicaoOD.Enabled = True Then
                If txtAdicaoOD.Text = String.Empty Then
                    txtAdicaoOD.Focus()
                End If
            End If

        End If
    End Sub

    Private Sub txtDNPOELonge_Leave(sender As System.Object, e As System.EventArgs) Handles txtDNPOELonge.Leave
        If txtDNPOELonge.Text <> String.Empty Then
            If osMaster.validaDNP_longe(txtDNPOELonge.Text, txtDNPOEPerto, os.tipo_receita_OE) = False Then
                MessageBox.Show("Valor da DNP para longe incorreta. Por favor corrigir.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtDNPOELonge.Focus()
                txtDNPOELonge.SelectAll()
                valido_tab_receita = False
                Exit Sub
            Else
                valido_tab_receita = True
                txtDiametroOE.Text = osMaster.calculaDiametro(txtAroHorizontal.Text, txtPonte.Text, txtDNPOELonge.Text, txtMaiorDiametro.Text)
            End If

            If os.tipo_receita_OE = tipo_Receita.VISAO_simples_longe Then
                base_oe(txtEsfOELonge.Text, txtCilOELonge.Text, os.tipo_receita_OE)
            End If

            grpOutOE.Enabled = True
            txtAdicaoOE.Focus()

            If txtAdicaoOE.Enabled = False Then
                If txtAlturaOE.Text = String.Empty Then
                    txtAlturaOE.Focus()
                Else
                    txtAdicaoOE.Focus()
                End If
            End If

            If txtAdicaoOE.Enabled = True Then
                If txtAdicaoOE.Text = String.Empty Then
                    txtAdicaoOE.Focus()
                End If
            End If
        End If
    End Sub


    Private Sub txtAdicaoOD_Leave(sender As System.Object, e As System.EventArgs) Handles txtAdicaoOD.Leave
        Dim resp As String
        If lTab.ret_especie(os.cod_tab_od) = "L" Then
            txtAdicaoOD.Text = ""
            Exit Sub
        End If

        If txtAdicaoOD.Text <> String.Empty Then
            resp = osMaster.Valida_adicao(txtAdicaoOD.Text, txtEsfODLonge.Text, txtCilODLonge.Text, txtEsfODPerto, txtCilODPerto, os.tipo_receita_OD)
            If resp.Substring(0, 3) = "ER!" Then
                If resp = "ER!Esferico não informado!" Then
                    MessageBox.Show("Esférico não informado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtAdicaoOD.Text = ""
                    txtEsfODLonge.Focus()
                    txtEsfODLonge.SelectAll()
                    valido_tab_receita = False
                End If
                If resp = "ER!Valor Incorreto!" Then
                    MessageBox.Show("Valor incorreto.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtAdicaoOD.Focus()
                    txtAdicaoOD.SelectAll()
                    valido_tab_receita = False
                End If
            Else
                valido_tab_receita = True
                If os.tipo_receita_OD = tipo_Receita.PROGRESSIVA Or os.tipo_receita_OD = tipo_Receita.BIFOCAL Or os.tipo_receita_OD = tipo_Receita.VISAO_simples_longe Then
                    base_od(txtEsfODLonge.Text, txtCilODLonge.Text, os.tipo_receita_OD)
                End If
            End If
        End If
    End Sub

    Private Sub txtLenteTabelaOD_Leave(sender As System.Object, e As System.EventArgs) Handles txtLenteTabelaOD.Leave
        If txtLenteTabelaOD.Text <> String.Empty Then
            If txtLenteTabelaOD.Text = 0 Then
                grpODLonge.Enabled = False
                grpODPerto.Enabled = False
                grpOutOd.Enabled = False
                lblCodPOD.Text = 0
                valido_tab_receita = True
            ElseIf txtLenteTabelaOD.Text > 0 Then
                If cbTipoRecOD.SelectedValue = tipo_Receita.VISAO_simples_longe Or cbTipoRecOD.SelectedValue = tipo_Receita.PROGRESSIVA Or
            cbTipoRecOD.SelectedValue = tipo_Receita.BIFOCAL Then
                    If intControleOD = "S" Then
                        grpODLonge.Enabled = True
                        grpODPerto.Enabled = False
                    End If
                End If
                If cbTipoRecOD.SelectedValue = tipo_Receita.VISAO_simples_perto Then
                    If intControleOD = "S" Then
                        grpODPerto.Enabled = True
                        grpODLonge.Enabled = False
                    End If
                End If
            End If

            Try
                txtLenteTabelaOD_Validating(txtLenteTabelaOD.Text, strError)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub txtCilODLonge_Leave(sender As System.Object, e As System.EventArgs) Handles txtCilODLonge.Leave
        If osMaster.valida_cil_longe(txtCilODLonge.Text, txtAdicaoOD.Text, txtEsfODLonge.Text, txtEsfODPerto, txtCilODPerto, os.tipo_receita_OD, txtEixoOD) = False Then
            MessageBox.Show("Valor do cilindríco para longe incorreto. Por favor corrigir.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCilODLonge.Focus()
            txtCilODLonge.SelectAll()
            valido_tab_receita = False
        Else
            valido_tab_receita = True
        End If
        If txtCilODLonge.Text = "0" Then
            txtEixoOD.Text = Nothing
        End If
    End Sub

    Private Sub txtEsfODLonge_Leave(sender As System.Object, e As System.EventArgs) Handles txtEsfODLonge.Leave
        If osMaster.valida_Esf_Longe(txtEsfODLonge.Text, txtAdicaoOD.Text, txtCilODLonge.Text, txtEsfODPerto, txtCilODPerto, os.tipo_receita_OD) = False Then
            MessageBox.Show("Valor do esférico para longe incorreto. Por favor corrigir.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtEsfODLonge.Focus()
            txtEsfODLonge.SelectAll()
            valido_tab_receita = False
            Exit Sub
        Else
            valido_tab_receita = True
        End If
    End Sub

    Private Sub txtLenteTabelaOE_Leave(sender As System.Object, e As System.EventArgs) Handles txtLenteTabelaOE.Leave
        If txtLenteTabelaOE.Text <> String.Empty Then
            If txtLenteTabelaOE.Text = 0 Then
                grpOELonge.Enabled = False
                grpOEPerto.Enabled = False
                grpOutOE.Enabled = False
                lblCodPOE.Text = 0
                valido_tab_receita = True
            ElseIf txtLenteTabelaOE.Text > 0 Then
                If cbTipoRecOE.SelectedValue = tipo_Receita.VISAO_simples_longe Or cbTipoRecOE.SelectedValue = tipo_Receita.PROGRESSIVA Or
                    cbTipoRecOE.SelectedValue = tipo_Receita.BIFOCAL Then
                    If intControleOE = "S" Then
                        grpOELonge.Enabled = True
                        grpOEPerto.Enabled = False
                    End If
                End If
                If cbTipoRecOE.SelectedValue = tipo_Receita.VISAO_simples_perto Then
                    If intControleOE = "S" Then
                        grpOEPerto.Enabled = True
                        grpOELonge.Enabled = False
                    End If
                End If
            End If

            Try
                txtLenteTabelaOE_Validating(txtLenteTabelaOD.Text, strError)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub txtEsfOELonge_Leave(sender As System.Object, e As System.EventArgs) Handles txtEsfOELonge.Leave
        If osMaster.valida_Esf_Longe(txtEsfOELonge.Text, txtAdicaoOE.Text, txtCilOELonge.Text, txtEsfOEPerto, txtCilOEPerto, os.tipo_receita_OE) = False Then
            MessageBox.Show("Valor do esférico para longe incorreto. Por favor corrigir.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtEsfOELonge.Focus()
            txtEsfOELonge.SelectAll()
            valido_tab_receita = False
            Exit Sub
        Else
            valido_tab_receita = True
        End If
    End Sub

    Private Sub txtCilOELonge_Leave(sender As System.Object, e As System.EventArgs) Handles txtCilOELonge.Leave
        If osMaster.valida_cil_longe(txtCilOELonge.Text, txtAdicaoOE.Text, txtEsfOELonge.Text, txtEsfOEPerto, txtCilOEPerto, os.tipo_receita_OE, txtEixoOE) = False Then
            MessageBox.Show("Valor do cilindríco para longe incorreto. Por favor corrigir.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCilOELonge.Focus()
            txtCilOELonge.SelectAll()
            valido_tab_receita = False
        Else
            valido_tab_receita = True
        End If
        If txtCilOELonge.Text = "0" Then
            txtEixoOE.Text = Nothing
        End If
    End Sub

    Private Sub txtAdicaoOE_Leave(sender As System.Object, e As System.EventArgs) Handles txtAdicaoOE.Leave
        Dim resp As String
        If lTab.ret_especie(os.cod_tab_oe) = "L" Then
            txtAdicaoOE.Text = ""
            Exit Sub
        End If
        resp = osMaster.Valida_adicao(txtAdicaoOE.Text, txtEsfOELonge.Text, txtCilOELonge.Text, txtEsfOEPerto, txtCilOEPerto, os.tipo_receita_OE)
        If resp.Substring(0, 3) = "ER!" Then
            If resp = "ER!Esferico não informado!" Then
                MessageBox.Show("Esférico não informado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtAdicaoOE.Text = ""
                txtEsfOELonge.Focus()
                txtEsfOELonge.SelectAll()
                valido_tab_receita = False
            End If
            If resp = "ER!Valor Incorreto!" Then
                MessageBox.Show("Valor incorreto.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtAdicaoOE.Focus()
                txtAdicaoOE.SelectAll()
                valido_tab_receita = False
            End If
        Else
            valido_tab_receita = True
            If os.tipo_receita_OE = tipo_Receita.PROGRESSIVA Or os.tipo_receita_OE = tipo_Receita.BIFOCAL Or os.tipo_receita_OE = tipo_Receita.VISAO_simples_longe Then
                base_oe(txtEsfOELonge.Text, txtCilOELonge.Text, os.tipo_receita_OE)
            End If
        End If
    End Sub

    Private Sub txtEsfODPerto_Leave(sender As System.Object, e As System.EventArgs) Handles txtEsfODPerto.Leave
        If br.valida_Esf_PERTO(txtEsfODPerto.Text, txtAdicaoOD.Text, txtCilODPerto.Text, os.tipo_receita_OD) = False Then
            MessageBox.Show("Valor do esférico para perto incorreto. Por favor corrigir.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtEsfODPerto.Focus()
            txtEsfODPerto.SelectAll()
            valido_tab_receita = False
        Else
            valido_tab_receita = True
        End If
    End Sub

    Private Sub txtCilODPerto_Leave(sender As System.Object, e As System.EventArgs) Handles txtCilODPerto.Leave
        If br.valida_cil_Perto(txtCilODPerto.Text, txtAdicaoOD, txtEsfODPerto, os.tipo_receita_OD, txtEixoOD) = False Then
            MessageBox.Show("Valor do cilíndrico para perto incorreto. Por favor corrigir.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCilODPerto.Focus()
            txtCilODPerto.SelectAll()
            valido_tab_receita = False
        Else
            valido_tab_receita = True
        End If
        If txtCilODPerto.Text = "0" Then
            txtEixoOD.Text = Nothing
        End If
    End Sub

    Private Sub txtEsfOEPerto_Leave(sender As System.Object, e As System.EventArgs) Handles txtEsfOEPerto.Leave
        If br.valida_Esf_PERTO(txtEsfOEPerto.Text, txtAdicaoOE.Text, txtCilOEPerto.Text, os.tipo_receita_OE) = False Then
            MessageBox.Show("Valor do esférico para perto incorreto. Por favor corrigir.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtEsfOEPerto.Focus()
            txtEsfOEPerto.SelectAll()
            valido_tab_receita = False
        Else
            valido_tab_receita = True
        End If
    End Sub

    Private Sub txtCilOEPerto_Leave(sender As System.Object, e As System.EventArgs) Handles txtCilOEPerto.Leave
        If br.valida_cil_Perto(txtCilOEPerto.Text, txtAdicaoOE, txtEsfOEPerto, os.tipo_receita_OE, txtEixoOE) = False Then
            MessageBox.Show("Valor do cilíndrico para perto incorreto. Por favor corrigir.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCilOEPerto.Focus()
            txtCilOEPerto.SelectAll()
            valido_tab_receita = False
        Else
            valido_tab_receita = True
        End If
        If txtCilOEPerto.Text = "0" Then
            txtEixoOE.Text = Nothing
        End If
    End Sub

    Private Sub txtDNPOdPerto_Leave(sender As System.Object, e As System.EventArgs) Handles txtDNPOdPerto.Leave
        If txtDNPOdPerto.Text <> String.Empty Then
            If osMaster.valida_DNP_Perto(txtDNPOdPerto.Text, os.tipo_receita_OD) = False Then
                MessageBox.Show("Valor da DNP para longe incorreta. Por favor corrigir.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtDNPOdPerto.Focus()
                txtDNPOdPerto.SelectAll()
                valido_tab_receita = False
                Exit Sub
            Else
                valido_tab_receita = True
                txtDiametroOD.Text = osMaster.calculaDiametro(txtAroHorizontal.Text, txtPonte.Text, txtDNPOdPerto.Text, txtMaiorDiametro.Text)
            End If

            If os.tipo_receita_OD = tipo_Receita.VISAO_simples_perto Then
                base_od(txtEsfODPerto.Text, txtCilODPerto.Text, os.tipo_receita_OD)
            End If

            grpOutOd.Enabled = True
            txtAdicaoOD.Focus()

            If txtAdicaoOD.Enabled = False Then
                txtAlturaOD.Focus()
            Else
                txtAdicaoOD.Focus()
            End If
        End If
    End Sub

    Private Sub lblLenteTabOD_Leave(sender As Object, e As EventArgs) Handles lblLenteTabOD.Leave
        If lblLenteTabOD.Text.Contains("-") Then
            Dim strODDesc As String = lblLenteTabOD.Text
            strODDesc = strODDesc.Substring(0, strODDesc.IndexOf("-"))
            Dim strRestante As String = lblLenteTabOD.Text
            Dim iteste As Integer = lblLenteTabOD.Text.Length - strODDesc.Length
            Dim strCodigo As String = lblLenteTabOD.Text.Substring(strODDesc.Length, iteste)
            lblLenteTabOD.Text = strODDesc
            txtLenteTabelaOD.Text = strCodigo.Replace("-", "")
            txtLenteTabelaOD_Leave(sender, e)
            txtEsfODLonge.Focus()
        End If
    End Sub

    Private Sub lblLenteTabOE_Leave(sender As Object, e As EventArgs) Handles lblLenteTabOE.Leave
        If lblLenteTabOE.Text.Contains("-") Then
            Dim strOEDesc As String = lblLenteTabOE.Text
            strOEDesc = strOEDesc.Substring(0, strOEDesc.IndexOf("-"))
            Dim strRestante As String = lblLenteTabOD.Text
            Dim iteste As Integer = lblLenteTabOD.Text.Length - strOEDesc.Length
            Dim strCodigo As String = lblLenteTabOD.Text.Substring(strOEDesc.Length, iteste)
            lblLenteTabOD.Text = strOEDesc
            txtLenteTabelaOD.Text = strCodigo.Replace("-", "")
            txtLenteTabelaOE_Leave(sender, e)
            txtEsfOELonge.Focus()
        End If
    End Sub

    Private Sub txtDNPOEPerto_Leave(sender As System.Object, e As System.EventArgs) Handles txtDNPOEPerto.Leave
        If txtDNPOEPerto.Text <> String.Empty Then
            If osMaster.valida_DNP_Perto(txtDNPOEPerto.Text, os.tipo_receita_OE) = False Then
                MessageBox.Show("Valor da DNP para longe incorreta. Por favor corrigir.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtDNPOEPerto.Focus()
                txtDNPOEPerto.SelectAll()
                valido_tab_receita = False
                Exit Sub
            Else
                valido_tab_receita = True
                txtDiametroOE.Text = osMaster.calculaDiametro(txtAroHorizontal.Text, txtPonte.Text, txtDNPOEPerto.Text, txtMaiorDiametro.Text)
            End If

            If os.tipo_receita_OE = tipo_Receita.VISAO_simples_perto Then
                base_oe(txtEsfOEPerto.Text, txtCilOEPerto.Text, os.tipo_receita_OE)
            End If

            grpOutOE.Enabled = True
            txtAdicaoOE.Focus()

            If txtAdicaoOE.Enabled = False Then
                txtAlturaOE.Focus()
            Else
                txtAdicaoOE.Focus()
            End If
        End If
    End Sub

    Private Sub regrasEdicao()
        'Regras utilizadas para habilitar os campos de informações dos campos abaixo referente ao olho direito
        'grpOutOd.Enabled = True
        If os.adicao_od <> Nothing Then
            txtAdicaoOD.Enabled = True
        End If
        If os.altura_od <> Nothing Then
            txtAlturaOD.Enabled = True
        End If
        If os.diametro_od <> Nothing Then
            txtDiametroOD.Enabled = True
        End If
        If os.eixo_od = Nothing Then
            txtEixoOD.Enabled = False
        Else
            txtEixoOD.Enabled = True
        End If
        If os.base_od <> Nothing Then
            txtBaseOD.Enabled = True
        Else
            txtBaseOD.Enabled = False
        End If

        'If os.cod_tab_od = 0 Then
        'grpODLonge.Enabled = False
        'grpODPerto.Enabled = False
        'OutOd.Enabled = False
        'End If

        grpODLonge.Enabled = False
        grpODPerto.Enabled = False
        grpOutOd.Enabled = False

        'Regras utilizadas para habilitar os campos de informações dos campos abaixo referente ao olho esquerdo
        'grpOutOE.Enabled = True
        If os.adicao_oe <> Nothing Then
            txtAdicaoOE.Enabled = True
        End If
        If os.altura_oe <> Nothing Then
            txtAlturaOE.Enabled = True
        End If
        If os.diametro_oe <> Nothing Then
            txtDiametroOE.Enabled = True
        End If
        If os.eixo_oe = Nothing Then
            txtEixoOE.Enabled = False
        Else
            txtEixoOE.Enabled = True
        End If
        If os.base_oe <> Nothing Then
            txtBaseOE.Enabled = True
        Else
            txtBaseOE.Enabled = False
        End If

        ' If os.cod_tab_oe = 0 Then
        'grpOELonge.Enabled = False
        'grpOEPerto.Enabled = False
        'grpOutOE.Enabled = False
        'End If

        grpOELonge.Enabled = False
        grpOEPerto.Enabled = False
        grpOutOE.Enabled = False
    End Sub

    Private Sub regrasEdicaoTroca()
        'Regras utilizadas para habilitar os campos de informações dos campos abaixo referente ao olho direito
        If os.adicao_od <> Nothing Then
            txtAdicaoOD.Enabled = True
        End If
        If os.altura_od <> Nothing Then
            txtAlturaOD.Enabled = True
        End If
        If os.diametro_od <> Nothing Then
            txtDiametroOD.Enabled = True
        End If
        If os.eixo_od = Nothing Then
            txtEixoOD.Enabled = False
        Else
            txtEixoOD.Enabled = True
        End If
        If os.base_od <> Nothing Then
            txtBaseOD.Enabled = True
        Else
            txtBaseOD.Enabled = False
        End If

        'Regras utilizadas para habilitar os campos de informações dos campos abaixo referente ao olho esquerdo
        If os.adicao_oe <> Nothing Then
            txtAdicaoOE.Enabled = True
        End If
        If os.altura_oe <> Nothing Then
            txtAlturaOE.Enabled = True
        End If
        If os.diametro_oe <> Nothing Then
            txtDiametroOE.Enabled = True
        End If
        If os.eixo_oe = Nothing Then
            txtEixoOE.Enabled = False
        Else
            txtEixoOE.Enabled = True
        End If
        If os.base_oe <> Nothing Then
            txtBaseOE.Enabled = True
        Else
            txtBaseOE.Enabled = False
        End If
    End Sub

    Private Sub txtAlturaOD_Leave(sender As System.Object, e As System.EventArgs) Handles txtAlturaOD.Leave
        If txtAlturaOD.Text = String.Empty Then
            MessageBox.Show("Por favor informe a altura.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtAlturaOD.Focus()
        End If
    End Sub

    Private Sub txtAlturaOE_Leave(sender As System.Object, e As System.EventArgs) Handles txtAlturaOE.Leave
        If txtAlturaOE.Text = String.Empty Then
            MessageBox.Show("Por favor informe a altura.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtAlturaOD.Focus()
        End If
    End Sub

    Private Sub frmOS_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If tipo_acao = ACAO.TROCA_PRODUTO Then
            If strErro = String.Empty Then
                strErro = "Error"
            End If
        End If
    End Sub
End Class