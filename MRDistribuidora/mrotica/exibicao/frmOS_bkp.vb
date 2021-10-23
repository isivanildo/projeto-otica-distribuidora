Imports winotica_util
Public Class frmOS_bkp
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
    Public autorizacao As objAutorizacao = Nothing
    Public novo As Boolean = True
    Public n_OS, Filial As Integer
    Public otica As Boolean = False
    Public n_cliente, d_cliente As Integer
    Public filial_cliente, cod_cliente As Integer
    Public tipo_acao As ACAO
    Dim conf As New config
    Dim intUsuario As Integer
    Dim osMaster As New objMaster

    Public Enum ACAO
        NOVA_OS = 1
        TROCA_DIOPTRIA = 2
        TROCA_PRODUTO = 3
    End Enum
#End Region
    Private Sub frmOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carrega_combos()
        If novo = True Then
            tipo_acao = ACAO.NOVA_OS
            'Procedimento 1 Inserir nova OS
            If usuario.acesso(UserID, 1) = False Then
                AVISO("Usuário não tem acesso para Inserir nova OS!", Me, frmAviso.tipo_aviso.tipo_ok, True, Color.Yellow)
                Me.Close()
                Exit Sub
            End If
            os.novo()
            os.id_filial = conf.Loja
            If cod_cliente > 0 Then
                os.cod_filial_cliente = filial_cliente
                os.cod_cliente = cod_cliente
            End If
        Else
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

        'd.carrega_Tabela("Select * from usuarios order by nome", tbUs)
        'cbVendedor.DataSource = tbUs
        'cbVendedor.DisplayMember = "NOME"
        'cbVendedor.ValueMember = "cod_usuario"

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
        chkMontagem.Checked = os.tem_montagem
        cbMontagem.SelectedValue = os.cod_montagem
        chkColoracao.Checked = os.tem_coloracao
        txtCorColoracao.Text = os.cor_coloracao
        carrega_tratamentos()
        If tbTratamentos.Rows.Count > 0 Then chkTratamento.Checked = True Else chkTratamento.Checked = False
        Try
            dtPrevisaoEntrega.Value = os.data_previsao_entrega
        Catch ex As Exception
        End Try
        txtHoraPrevisaoEntrega.Text = os.hora_previsao_entrega
        txtObs.Text = os.observacao
        'cbVendedor.SelectedValue = os.cod_vendedora
        cbLaboratorio.SelectedValue = os.id_laboratorio
        txtDocCliente.Text = os.doc_cliente
        If tipo_acao = ACAO.TROCA_PRODUTO Then
            bloqueia_tab_Armacao()
            tabOS.SelectTab(tabReceita)
            'travaControles(grpODLonge.Controls)
            'travaControles(grpODPerto.Controls)
            ' travaControles(grpOutOd.Controls)
            'travaControles(grpOutOd.Controls)
        End If
        If os.cod_fase <> 1 And tipo_acao <> ACAO.TROCA_DIOPTRIA And tipo_acao <> ACAO.TROCA_PRODUTO Then
            AVISO("Esta OS não pode mais ser alterada, pois já foi verificada!", Me, frmAviso.tipo_aviso.tipo_ok)
        End If
    End Sub
#Region "TabArmação"
    Private Sub btnSeguir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeguir.Click
        If validaTB1() = False Then
            Exit Sub
        End If
        tabOS.SelectTab(tabReceita)
        If os.max > 0 Then
            os.editar()
        End If
        os.cod_tipo_armacao = cbTipoArmacao.SelectedValue
        os.aro_horizontal = txtAroHorizontal.Text
        os.aro_vertical = txtAroVertical.Text
        os.ponte = txtPonte.Text
        os.maior_diametro = txtMaiorDiametro.Text
        os.cod_tipo_armacao = cbTipoArmacao.SelectedValue
        'os.crm_oftalmologista = rdNum(txtCRM.Text)
        If os.max > 0 Then
            MsgBox(os.Salvar())
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
            err.SetError(txtCliente, "Informe o Cliente!")
            tabOS.SelectTab(tabArmacao)
            txtCliente.Focus()
            valido = False
            Exit Sub
        End If
        err.SetError(txtCliente, Nothing)
        valido = True
    End Sub
    Private Sub cbTipoArmacao_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbTipoArmacao.Validating
        If cbLaboratorio.SelectedValue = 0 Then
            err.SetError(cbTipoArmacao, "Informe um tipo de armação!")
            tabOS.SelectTab(tabArmacao)
            cbTipoArmacao.Focus()
            valido = False
            Exit Sub
        End If
        err.SetError(cbTipoArmacao, Nothing)
        valido = True
    End Sub
    Private Sub txtAroHorizontal_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAroHorizontal.Validating
        If br.valida_valor_numerico(txtAroHorizontal.Text, False) = False Then
            err.SetError(txtAroHorizontal, "Valor incorreto!")
            txtAroHorizontal.Focus()
            valido = False
            Exit Sub
        End If
        err.SetError(txtAroHorizontal, Nothing)
        valido = True
    End Sub
    Private Sub txtAroVertical_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAroVertical.Validating
        If br.valida_valor_numerico(txtAroHorizontal.Text, False) = False Then
            err.SetError(txtAroVertical, "Valor incorreto!")
            txtAroVertical.Focus()
            valido = False
            Exit Sub
        End If
        err.SetError(txtAroVertical, Nothing)
        valido = True
    End Sub
    Private Sub txtPonte_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPonte.Validating
        If br.valida_valor_numerico(txtPonte.Text, False) = False Then
            err.SetError(txtPonte, "Valor incorreto!")
            txtPonte.Focus()
            valido = False
            Exit Sub
        End If
        err.SetError(txtPonte, Nothing)
        valido = True
    End Sub
    Private Sub txtMaiorDiametro_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtMaiorDiametro.Validating
        If br.valida_valor_numerico(txtMaiorDiametro.Text, False) = False Then
            err.SetError(txtMaiorDiametro, "Valor incorreto!")
            txtMaiorDiametro.Focus()
            valido = False
            Exit Sub
        End If
        err.SetError(txtMaiorDiametro, Nothing)
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
        'cbTipoArmacao_Validating(Me, Nothing)
        If valido = False Then
            Return False
        Else
            Return True
        End If
    End Function
#End Region
#Region "TabReceita"
    Private Sub tipo_os_od()
        If tipo_acao = ACAO.TROCA_PRODUTO Or tipo_acao = ACAO.TROCA_DIOPTRIA Then
            'Exit Sub
        End If
        If os.tipo_receita_OD <> Nothing Then
            Dim r As Integer
            r = MsgBox("Deseja realmente trocar o tipo de receita? Todos os dados da receita serão apagados.", MsgBoxStyle.YesNo)
            If r = vbNo Then
                cbTipoRecOD.SelectedValue = os.tipo_receita_OD
            End If
            If r = vbYes Then
                txtEsfODLonge.Text = ""
                txtCilODLonge.Text = ""
                txtDNPODLonge.Text = ""
                txtEsfODPerto.Text = ""
                txtCilODPerto.Text = ""
                txtDNPOdPerto.Text = ""
                txtEixoOD.Text = ""

            End If
        End If
        receita_od()
    End Sub
    Private Sub receita_od()
        With cbTipoRecOD
            If .SelectedValue = tipo_Receita.BIFOCAL Or .SelectedValue = tipo_Receita.PROGRESSIVA Then
                If .SelectedValue = tipo_Receita.BIFOCAL Then os.tipo_receita_OD = tipo_Receita.BIFOCAL
                If .SelectedValue = tipo_Receita.PROGRESSIVA Then os.tipo_receita_OD = tipo_Receita.PROGRESSIVA
                txtAdicaoOD.Enabled = True
                grpODLonge.Enabled = True
                grpOutOd.Enabled = True
                grpODPerto.Enabled = False
            End If
            If .SelectedValue = tipo_Receita.VISAO_simples_longe Then
                os.tipo_receita_OD = tipo_Receita.VISAO_simples_longe
                txtAdicaoOD.Enabled = False
                txtAdicaoOD.Text = 0
                grpODLonge.Enabled = True
                grpOutOd.Enabled = True
                grpODPerto.Enabled = False
            End If
            If .SelectedValue = tipo_Receita.VISAO_simples_perto Then
                grpODPerto.TabIndex = 1
                grpOutOd.TabIndex = 2
                os.tipo_receita_OD = tipo_Receita.VISAO_simples_perto
                txtAdicaoOD.Enabled = False
                txtAdicaoOD.Text = 0
                grpODLonge.Enabled = False
                grpOutOd.Enabled = True
                grpODPerto.Enabled = True
            End If
        End With
    End Sub
    Private Sub tipo_os_oe()
        If tipo_acao = ACAO.TROCA_PRODUTO Or tipo_acao = ACAO.TROCA_DIOPTRIA Then
            'Exit Sub
        End If
        If os.tipo_receita_OE <> Nothing Then
            Dim r As Integer
            r = MsgBox("Deseja realmente trocar o tipo de receita? Todos os dados da receita serão apagados.", MsgBoxStyle.YesNo)
            If r = vbNo Then
                cbTipoRecOE.SelectedValue = os.tipo_receita_OE
            End If
            If r = vbYes Then
                txtEsfOELonge.Text = ""
                txtCilOELonge.Text = ""
                txtDNPOELonge.Text = ""
                txtEsfOEPerto.Text = ""
                txtCilOEPerto.Text = ""
                txtDNPOEPerto.Text = ""
            End If
        End If
        receita_oe()
    End Sub
    Private Sub receita_oe()
        With cbTipoRecOE
            If .SelectedValue = tipo_Receita.BIFOCAL Or .SelectedValue = tipo_Receita.PROGRESSIVA Then
                If .SelectedValue = tipo_Receita.BIFOCAL Then os.tipo_receita_OE = tipo_Receita.BIFOCAL
                If .SelectedValue = tipo_Receita.PROGRESSIVA Then os.tipo_receita_OE = tipo_Receita.PROGRESSIVA
                txtAdicaoOE.Enabled = True
                grpOELonge.Enabled = True
                grpOutOE.Enabled = True
                grpOEPerto.Enabled = False
            End If
            If .SelectedValue = tipo_Receita.VISAO_simples_longe Then
                os.tipo_receita_OE = tipo_Receita.VISAO_simples_longe
                txtAdicaoOE.Enabled = False
                txtAdicaoOE.Text = 0
                grpOELonge.Enabled = True
                grpOutOE.Enabled = True
                grpOEPerto.Enabled = False
            End If
            If .SelectedValue = tipo_Receita.VISAO_simples_perto Then
                os.tipo_receita_OE = tipo_Receita.VISAO_simples_perto
                txtAdicaoOE.Enabled = False
                txtAdicaoOE.Text = 0
                grpOELonge.Enabled = False
                grpOutOE.Enabled = True
                grpOEPerto.Enabled = True
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

    Private Sub txtLenteTabelaOD_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLenteTabelaOD.LostFocus
        Dim strError As New System.ComponentModel.CancelEventArgs
        If tipo_acao = ACAO.TROCA_PRODUTO Then
            validaTB2()
        End If
        Try
            txtLenteTabelaOD_Validating(txtLenteTabelaOD.Text, strError)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub txtLenteTabelaOD_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtLenteTabelaOD.Validating
        If txtLenteTabelaOD.Text = Nothing Then
            err.SetError(txtLenteTabelaOD, "Digite o Código ou pressione a tecla ENTER para consultar.")
            txtLenteTabelaOD.Focus()
            Exit Sub
        End If
        If txtLenteTabelaOD.Text <> Nothing Then lTab.Source("Select * from lentes_tabela where cod_tabela = " & d.cdin(txtLenteTabelaOD.Text) & "")
        If lTab.max > 0 Then
            txtLenteTabelaOD.Text = lTab.cod_tabela
            lblLenteTabOD.Text = lTab.nome_comercial
            os.cod_tab_od = lTab.cod_tabela
            err.SetError(txtLenteTabelaOD, Nothing)
            If os.tipo_receita_OD = tipo_Receita.VISAO_simples_perto Then
                txtEsfODPerto.Focus()
            Else
                txtEsfODLonge.Focus()
            End If
            Exit Sub
        Else
            err.SetError(txtLenteTabelaOD, "Código inexistente")
            txtLenteTabelaOD.Focus()
        End If
    End Sub
    Private Sub txtLenteTabelaOE_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLenteTabelaOE.Enter
        'Quando o campo do código da lente na tabela recebe o foco, o código da lente 
        'no olho direito é informado. As lentes de olho esquerdo e direito devem ser iguais
        txtLenteTabelaOE.Text = txtLenteTabelaOD.Text
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
            err.SetError(txtLenteTabelaOE, "Digite o Código ou pressione a tecla ENTER para consultar.")
            txtLenteTabelaOE.Focus()
            Exit Sub
        End If
        If txtLenteTabelaOE.Text <> Nothing Then lTab.Source("Select * from lentes_tabela where cod_tabela = " & d.cdin(txtLenteTabelaOE.Text) & "")
        If lTab.max > 0 Then
            txtLenteTabelaOE.Text = lTab.cod_tabela
            lblLenteTabOE.Text = lTab.nome_comercial
            os.cod_tab_oe = lTab.cod_tabela
            err.SetError(txtLenteTabelaOE, Nothing)
            If os.tipo_receita_OE = tipo_Receita.VISAO_simples_perto Then
                txtEsfOEPerto.Focus()
            Else
                txtEsfOELonge.Focus()
            End If
            Exit Sub
        Else
            err.SetError(txtLenteTabelaOE, "Código inexistente")
            txtLenteTabelaOE.Focus()
        End If
    End Sub
    Private Function base_od(ByVal esf As Double, ByVal cil As Double, ByVal tipo As Integer) As Boolean
        Dim esfBase As Double
        Dim tb As New DataTable
        Dim sql As String
        Dim esp As String = Nothing
        esp = lTab.ret_especie(os.cod_tab_od)
        If txtBaseOD.Enabled = False Then Exit Function
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
            sql = "SELECT lentes_tabela.nome_comercial, lentes_blocos.nome_lente, blocos.Base_nominal, blocos.Adicao, blocos.olho, blocos.ESF_MAIOR, " & _
                  " blocos.ESF_MENOR, produtos.cod_barra,produtos.cod_produto, lentes_blocos.diametro, lentes_blocos.cod_tabela, lentes_blocos.cod_lente " & _
                  " FROM lentes_blocos INNER JOIN " & _
                  "lentes_tabela ON lentes_blocos.cod_tabela = lentes_tabela.cod_tabela INNER JOIN " & _
                  "produtos ON lentes_blocos.cod_lente = produtos.cod_lente AND lentes_blocos.id_fabricante = produtos.id_fabricante INNER JOIN " & _
                  "blocos ON produtos.cod_produto = blocos.Cod_produto " & _
                  "WHERE blocos.ESF_MAIOR >= " & d.cdin(esfBase) & " AND blocos.ESF_MENOR <=" & d.cdin(esfBase) & " AND (blocos.olho = 'D' or blocos.olho = 'A') " & _
                  " AND dbo.blocos.Adicao = " & d.cdin(txtAdicaoOD.Text) & " and lentes_tabela.cod_tabela = " & d.cdin(txtLenteTabelaOD.Text) & ""
        End If
        If esp = "BS" Then
            sql = "SELECT lentes_tabela.nome_comercial, lentes_blocos.nome_lente, bloco_surfacado.Base_nominal, bloco_surfacado.Adicao, bloco_surfacado.olho, " & _
                 "bloco_surfacado.esf,  bloco_surfacado.cil," & _
                 "  produtos.cod_barra,produtos.cod_produto, lentes_blocos.diametro, lentes_blocos.cod_tabela, lentes_blocos.cod_lente " & _
                  " FROM lentes_blocos INNER JOIN " & _
                  "lentes_tabela ON lentes_blocos.cod_tabela = lentes_tabela.cod_tabela INNER JOIN " & _
                  "produtos ON lentes_blocos.cod_lente = produtos.cod_lente AND lentes_blocos.id_fabricante = produtos.id_fabricante INNER JOIN " & _
                  "bloco_surfacado ON produtos.cod_produto = bloco_surfacado.Cod_produto " & _
                  "WHERE bloco_surfacado.esf = " & d.cdin(esf) & " AND bloco_surfacado.cil =" & d.cdin(cil) & " AND (bloco_surfacado.olho = 'D' or bloco_surfacado.olho = 'A') " & _
                  " AND bloco_surfacado.Adicao = " & d.cdin(txtAdicaoOD.Text) & " and lentes_tabela.cod_tabela = " & d.cdin(txtLenteTabelaOD.Text) & ""
        End If
        If esp = "L" Then
            sql = "SELECT lentes_tabela.nome_comercial, lentes_blocos.nome_lente,produtos.cod_produto, produtos.cod_barra, lentes_blocos.diametro, lentes_blocos.cod_tabela, " & _
            "lentes_blocos.cod_lente FROM lentes_blocos INNER JOIN lentes_tabela ON lentes_blocos.cod_tabela = lentes_tabela.cod_tabela INNER JOIN " & _
            "produtos ON lentes_blocos.cod_lente = produtos.cod_lente AND lentes_blocos.id_fabricante = produtos.id_fabricante INNER JOIN " & _
            "lentes ON produtos.cod_produto = lentes.cod_produto Where " & _
            "lentes.esferico = " & d.cdin(esf) & " AND lentes.cilindrico = " & _
            d.cdin(cil) & " and lentes_tabela.cod_tabela = " & txtLenteTabelaOD.Text & ""
        End If
        d.carrega_Tabela(sql, tb)
        If tb.Rows.Count > 0 Then
            txtEstoqueOD.Text = prod.Retorna_nome_prod(tb.Rows(0)("cod_produto")) & " Barra: " & tb.Rows(0)("cod_barra")
            If esp = "B" Or esp = "BS" Then
                txtBaseOD.Text = tb.Rows(0)("base_nominal")
            Else
                txtBaseOD.Text = 0
            End If

            os.cod_produto_od = tb.Rows(0)("cod_produto")
            lblCodPOD.Text = os.cod_produto_od
            Try
                If CDbl(txtDiametroOD.Text) > CDbl(tb.Rows(0)("diametro")) Then
                    MsgBox("Diametro de montagem maior que diametro da lente/bloco!", MsgBoxStyle.Critical)
                    err.SetError(txtDiametroOD, "Erro de Diametro")
                    valido_tab_receita = False
                    Return False
                End If
            Catch ex As Exception

            End Try

        Else
            MsgBox("Dioptria Indisponível para esta lente!Mude a lente ou altere a dioptria!" & vbCrLf & sql, MsgBoxStyle.Exclamation)
            err.SetError(txtAdicaoOD, "Erro de Dipotria! Dioptria Indisponível!")
            valido_tab_receita = False
            Return False
            Exit Function
        End If
        err.SetError(txtAdicaoOD, Nothing)
        err.SetError(txtDiametroOD, Nothing)
        valido_tab_receita = True
        Return True
    End Function
    Private Function base_oe(ByVal esf As Double, ByVal cil As Double, ByVal tipo As Integer) As Boolean
        Dim esfBase As Double
        Dim tb As New DataTable
        Dim sql As String
        Dim esp As String = Nothing
        If txtBaseOE.Enabled = False Then Exit Function
        esp = lTab.ret_especie(os.cod_tab_oe)
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

            sql = "SELECT lentes_tabela.nome_comercial, lentes_blocos.nome_lente, blocos.Base_nominal, blocos.Adicao, blocos.olho, blocos.ESF_MAIOR, " & _
                  " blocos.ESF_MENOR, produtos.cod_barra,produtos.cod_produto, lentes_blocos.diametro, lentes_blocos.cod_tabela, lentes_blocos.cod_lente " & _
                  " FROM lentes_blocos INNER JOIN " & _
                  "lentes_tabela ON lentes_blocos.cod_tabela = lentes_tabela.cod_tabela INNER JOIN " & _
                  "produtos ON lentes_blocos.cod_lente = produtos.cod_lente AND lentes_blocos.id_fabricante = produtos.id_fabricante INNER JOIN " & _
                  "blocos ON produtos.cod_produto = blocos.Cod_produto " & _
                  "WHERE blocos.ESF_MAIOR >= " & d.cdin(esfBase) & " AND blocos.ESF_MENOR <=" & d.cdin(esfBase) & " AND (blocos.olho = 'E' or blocos.olho = 'A') " & _
                  " AND dbo.blocos.Adicao = " & d.cdin(txtAdicaoOE.Text) & " and lentes_tabela.cod_tabela = " & d.cdin(txtLenteTabelaOE.Text) & ""
        End If
        If esp = "BS" Then
            sql = "SELECT lentes_tabela.nome_comercial, lentes_blocos.nome_lente, bloco_surfacado.Base_nominal, bloco_surfacado.Adicao, bloco_surfacado.olho, " & _
                 "bloco_surfacado.esf,  bloco_surfacado.cil," & _
                 "  produtos.cod_barra,produtos.cod_produto, lentes_blocos.diametro, lentes_blocos.cod_tabela, lentes_blocos.cod_lente " & _
                  " FROM lentes_blocos INNER JOIN " & _
                  "lentes_tabela ON lentes_blocos.cod_tabela = lentes_tabela.cod_tabela INNER JOIN " & _
                  "produtos ON lentes_blocos.cod_lente = produtos.cod_lente AND lentes_blocos.id_fabricante = produtos.id_fabricante INNER JOIN " & _
                  "bloco_surfacado ON produtos.cod_produto = bloco_surfacado.Cod_produto " & _
                  "WHERE bloco_surfacado.esf = " & d.cdin(esf) & " AND bloco_surfacado.cil =" & d.cdin(cil) & " AND (bloco_surfacado.olho = 'E' or bloco_surfacado.olho = 'A') " & _
                  " AND bloco_surfacado.Adicao = " & d.cdin(txtAdicaoOE.Text) & " and lentes_tabela.cod_tabela = " & d.cdin(txtLenteTabelaOD.Text) & ""
        End If
        If esp = "L" Then
            sql = "SELECT lentes_tabela.nome_comercial, lentes_blocos.nome_lente,produtos.cod_produto, produtos.cod_barra, lentes_blocos.diametro, lentes_blocos.cod_tabela, " & _
            "lentes_blocos.cod_lente FROM lentes_blocos INNER JOIN lentes_tabela ON lentes_blocos.cod_tabela = lentes_tabela.cod_tabela INNER JOIN " & _
            "produtos ON lentes_blocos.cod_lente = produtos.cod_lente AND lentes_blocos.id_fabricante = produtos.id_fabricante INNER JOIN " & _
            "lentes ON produtos.cod_produto = lentes.cod_produto Where " & _
            "lentes.esferico = " & d.cdin(esf) & " AND lentes.cilindrico = " & _
            d.cdin(cil) & " and lentes_tabela.cod_tabela = " & d.cdin(txtLenteTabelaOE.Text) & ""
        End If
        d.carrega_Tabela(sql, tb)
        If tb.Rows.Count > 0 Then
            txtEstoqueOE.Text = prod.Retorna_nome_prod(tb.Rows(0)("cod_produto")) & " Barra: " & tb.Rows(0)("cod_barra")
            If esp = "B" Then txtBaseOE.Text = tb.Rows(0)("base_nominal") Else txtBaseOE.Text = 0
            os.cod_produto_oe = tb.Rows(0)("cod_produto")
            lblCodPOE.Text = os.cod_produto_oe
            Try
                If CDbl(txtDiametroOE.Text) > CDbl(tb.Rows(0)("diametro")) Then
                    MsgBox("Diametro de montagem maior que diametro da lente/bloco!", MsgBoxStyle.Critical)
                    err.SetError(txtDiametroOE, "Erro de Diametro")
                    valido_tab_receita = False
                    Return False
                End If
            Catch ex As Exception

            End Try

        Else
            MsgBox("Dioptria Indisponível para esta lente!Mude a lente ou altere a dioptria!", MsgBoxStyle.Exclamation)
            err.SetError(txtAdicaoOE, "Erro de Dipotria! Dioptria Indisponível!")
            Return False
            valido_tab_receita = False
        End If
        err.SetError(txtAdicaoOE, Nothing)
        err.SetError(txtDiametroOE, Nothing)
        valido_tab_receita = True
        Return True
    End Function
    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim res As String
        validaTB2()
        If valido_tab_receita = False Then
            Exit Sub
        End If
        If novo = False Then
            'Procedimento 2 Editar OS
            If usuario.acesso(UserID, 2) = False Then
                AVISO("Usuário não tem permissão para editar OS!", Me, frmAviso.tipo_aviso.tipo_ok, True, Color.Yellow)
                Exit Sub
            End If
            If os.cod_fase <> 1 And tipo_acao <> ACAO.TROCA_DIOPTRIA And tipo_acao <> ACAO.TROCA_PRODUTO Then
                AVISO("Esta OS não pode mais ser alterada, pois já foi verificada!", Me, frmAviso.tipo_aviso.tipo_ok)
                Exit Sub
            End If
            os.editar()
        Else
            '    os.cod_os = os.retorna_chave(conf.Loja)
        End If
        If tipo_acao <> ACAO.TROCA_DIOPTRIA Then

            If os.tipo_receita_OD = tipo_Receita.VISAO_simples_perto Then
                base_od(txtEsfODPerto.Text, txtCilODPerto.Text, os.tipo_receita_OD)
            Else
                base_od(txtEsfODLonge.Text, txtCilODLonge.Text, os.tipo_receita_OD)
            End If
            If os.tipo_receita_OE = tipo_Receita.VISAO_simples_perto And txtBaseOE.Enabled = True Then
                base_oe(txtEsfOEPerto.Text, txtCilOEPerto.Text, os.tipo_receita_OE)
            Else
                base_oe(txtEsfOELonge.Text, txtCilOELonge.Text, os.tipo_receita_OE)
            End If
            'Avaliação de Produtos Especiais
            If tipo_acao = ACAO.TROCA_DIOPTRIA Or tipo_acao = ACAO.TROCA_PRODUTO Then
                Dim r As frmAviso.respo
                Dim range As Double
                'Lente intermediária Access
                If os.cod_tab_od = 11034 Then
                    r = AVISO("Deseja Trocar o Range do Olho Direito?", Me, frmAviso.tipo_aviso.tipo_sim_nao)
                    If r = frmAviso.respo.SIM Then
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
                    r = AVISO("Deseja Trocar o Rangedo olho Esquerdo?", Me, frmAviso.tipo_aviso.tipo_sim_nao)
                    If r = frmAviso.respo.SIM Then
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

                'Lente intermediária interview
                If os.cod_tab_od = 11060 Then
                    r = AVISO("Deseja Trocar o Range do Olho Direito?", Me, frmAviso.tipo_aviso.tipo_sim_nao)
                    If r = frmAviso.respo.SIM Then
                        range = InputBox("Digite o range:(80 ou 130)")
                        If range = 80 Then
                            os.cod_produto_od = 3088
                            lblCodPOD.Text = os.cod_produto_od
                        End If
                        If range = 130 Then
                            os.cod_produto_od = 3089
                            lblCodPOD.Text = os.cod_produto_od
                        End If
                    End If
                End If
                If os.cod_tab_oe = 11060 Then
                    r = AVISO("Deseja Trocar o Rangedo olho Esquerdo?", Me, frmAviso.tipo_aviso.tipo_sim_nao)
                    If r = frmAviso.respo.SIM Then
                        range = InputBox("Digite o range:(80 ou 130)")
                        If range = 80 Then
                            os.cod_produto_oe = 3088
                            lblCodPOE.Text = os.cod_produto_oe
                        End If
                        If range = 130 Then
                            os.cod_produto_oe = 3089
                            lblCodPOE.Text = os.cod_produto_oe
                        End If
                    End If
                End If
                'fim lente intermediaria access
            End If
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
                MsgBox(os.Salvar() & vbCrLf & andamentos.insere_andamento(objAndamentos.tipo.alteracao_os, _
                    os.id_filial, os.cod_os, UserID, edit.Substring(2)) & "Nº da OS: " & os.cod_os)
            End If
        Else
            os.exportado = "N"
            res = os.Salvar
            'Registra os Andamentos
            If res.StartsWith("OK") Then
                If novo = True Then
                    MsgBox(andamentos.insere_andamento(objAndamentos.tipo.inclusao_os, _
                    os.id_filial, os.cod_os, UserID, ""))
                End If
            End If
        End If
        tabOS.SelectTab(tbFinal)
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
    Private Sub txtDNPODLonge_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDNPODLonge.LostFocus

        If br.validaDNP_longe(txtDNPODLonge.Text, txtDNPOdPerto, os.tipo_receita_OD) = False Then
            err.SetError(txtDNPODLonge, "Valor Incorreto")
            txtDNPODLonge.Focus()
            valido_tab_receita = False
            Exit Sub
        Else
            err.SetError(txtDNPODLonge, Nothing)
            valido_tab_receita = True
            Try
                txtDiametroOD.Text = br.diametro(txtAroHorizontal.Text, txtPonte.Text, txtDNPODLonge.Text, txtMaiorDiametro.Text)
            Catch ex As Exception
                AVISO(ex.Message, Me, frmAviso.tipo_aviso.tipo_ok)
            End Try
        End If
        If os.tipo_receita_OD = tipo_Receita.VISAO_simples_longe Then
            base_od(txtEsfODLonge.Text, txtCilODLonge.Text, os.tipo_receita_OD)
        End If
    End Sub
    Private Sub txtDNPOeLonge_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDNPOELonge.LostFocus

        If br.validaDNP_longe(txtDNPOELonge.Text, txtDNPOEPerto, os.tipo_receita_OE) = False Then
            err.SetError(txtDNPOELonge, "Valor Incorreto")
            txtDNPOELonge.Focus()
            valido_tab_receita = False
            Exit Sub
        Else
            err.SetError(txtDNPOELonge, Nothing)
            valido_tab_receita = True
            txtDiametroOE.Text = br.diametro(txtAroHorizontal.Text, txtPonte.Text, txtDNPOELonge.Text, txtMaiorDiametro.Text)
        End If
        If os.tipo_receita_OE = tipo_Receita.VISAO_simples_longe Then
            base_oe(txtEsfOELonge.Text, txtCilOELonge.Text, os.tipo_receita_OE)
        End If
    End Sub
    Private Sub txtAdicaoOD_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAdicaoOD.LostFocus
        Dim resp As String
        If lTab.ret_especie(os.cod_tab_od) = "L" Then
            txtAdicaoOD.Text = ""
            Exit Sub
        End If
        resp = br.Valida_adicao(txtAdicaoOD.Text, txtEsfODLonge.Text, txtCilODLonge.Text, txtEsfODPerto, txtCilODPerto, os.tipo_receita_OD)
        If resp.Substring(0, 3) = "ER!" Then
            If resp = "ER!Esferico não informado!" Then
                MsgBox("Esferico não informado!")
                txtAdicaoOD.Text = ""
                txtEsfODLonge.Focus()
                valido_tab_receita = False
            End If
            If resp = "ER!Valor Incorreto!" Then
                MsgBox("Valor incorreto!")
                txtAdicaoOD.Focus()
                valido_tab_receita = False
            End If
        Else
            valido_tab_receita = True
            If os.tipo_receita_OD = tipo_Receita.PROGRESSIVA Or os.tipo_receita_OD = tipo_Receita.BIFOCAL Or os.tipo_receita_OD = tipo_Receita.VISAO_simples_longe Then
                base_od(txtEsfODLonge.Text, txtCilODLonge.Text, os.tipo_receita_OD)
            End If
        End If
    End Sub
    Private Sub txtAdicaoOe_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAdicaoOE.LostFocus
        Dim resp As String
        If lTab.ret_especie(os.cod_tab_oe) = "L" Then
            txtAdicaoOE.Text = ""
            Exit Sub
        End If
        resp = br.Valida_adicao(txtAdicaoOE.Text, txtEsfOELonge.Text, txtCilOELonge.Text, txtEsfOEPerto, txtCilOEPerto, os.tipo_receita_OE)
        If resp.Substring(0, 3) = "ER!" Then
            If resp = "ER!Esferico não informado!" Then
                MsgBox("Esferico não informado!")
                txtAdicaoOE.Text = ""
                txtEsfOELonge.Focus()
                valido_tab_receita = False
            End If
            If resp = "ER!Valor Incorreto!" Then
                MsgBox("Valor incorreto!")
                txtAdicaoOE.Focus()
                valido_tab_receita = False
            End If
        Else
            valido_tab_receita = True
            If os.tipo_receita_OE = tipo_Receita.PROGRESSIVA Or os.tipo_receita_OE = tipo_Receita.BIFOCAL Or os.tipo_receita_OE = tipo_Receita.VISAO_simples_longe Then
                base_oe(txtEsfOELonge.Text, txtCilOELonge.Text, os.tipo_receita_OE)
            End If
        End If
    End Sub
    Private Sub txtEsfODLonge_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEsfODLonge.LostFocus
        If br.valida_Esf_Longe(txtEsfODLonge.Text, txtAdicaoOD.Text, txtCilODLonge.Text, txtEsfODPerto, txtCilODPerto, os.tipo_receita_OD) = False Then
            err.SetError(txtEsfODLonge, "Valor Incorreto!")
            txtEsfODLonge.Focus()
            valido_tab_receita = False
            Exit Sub
        Else
            err.SetError(txtEsfODLonge, Nothing)
            valido_tab_receita = True
        End If
    End Sub
    Private Sub txtEsfOeLonge_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEsfOELonge.LostFocus

        If br.valida_Esf_Longe(txtEsfOELonge.Text, txtAdicaoOE.Text, txtCilOELonge.Text, txtEsfOEPerto, txtCilOEPerto, os.tipo_receita_OE) = False Then
            err.SetError(txtEsfOELonge, "Valor Incorreto!")
            txtEsfOELonge.Focus()
            valido_tab_receita = False
            Exit Sub
        Else
            err.SetError(txtEsfOELonge, Nothing)
            valido_tab_receita = True
        End If
    End Sub
    Private Sub txtCilODLonge_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCilODLonge.LostFocus

        If br.valida_cil_longe(txtCilODLonge.Text, txtAdicaoOD.Text, txtEsfODLonge.Text, txtEsfODPerto, txtCilODPerto, os.tipo_receita_OD, txtEixoOD) = False Then
            err.SetError(txtCilODLonge, "Valor Incorreto")
            txtCilODLonge.Focus()
            valido_tab_receita = False
        Else
            err.SetError(txtCilODLonge, Nothing)
            valido_tab_receita = True
        End If
        If txtCilODLonge.Text = "0" Then
            txtEixoOD.Text = Nothing
        End If
    End Sub
    Private Sub txtCilOeLonge_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCilOELonge.LostFocus

        If br.valida_cil_longe(txtCilOELonge.Text, txtAdicaoOE.Text, txtEsfOELonge.Text, txtEsfOEPerto, txtCilOEPerto, os.tipo_receita_OE, txtEixoOE) = False Then
            err.SetError(txtCilOELonge, "Valor Incorreto")
            txtCilOELonge.Focus()
            valido_tab_receita = False
        Else
            err.SetError(txtCilOELonge, Nothing)
            valido_tab_receita = True
        End If
        If txtCilOELonge.Text = "0" Then
            txtEixoOE.Text = Nothing
        End If
    End Sub
    Private Sub txtEsfODPerto_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEsfODPerto.LostFocus
        If br.valida_Esf_PERTO(txtEsfODPerto.Text, txtAdicaoOD.Text, txtCilODPerto.Text, os.tipo_receita_OD) = False Then
            err.SetError(txtEsfODPerto, "Valor incorreto!")
            txtEsfODPerto.Focus()
            valido_tab_receita = False
        Else
            err.SetError(txtEsfODPerto, Nothing)
            valido_tab_receita = True
        End If
    End Sub
    Private Sub txtEsfOEPerto_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEsfOEPerto.LostFocus
        If br.valida_Esf_PERTO(txtEsfOEPerto.Text, txtAdicaoOE.Text, txtCilOEPerto.Text, os.tipo_receita_OE) = False Then
            err.SetError(txtEsfOEPerto, "Valor incorreto!")
            txtEsfOEPerto.Focus()
            valido_tab_receita = False
        Else
            err.SetError(txtEsfOEPerto, Nothing)
            valido_tab_receita = True
        End If
    End Sub
    Private Sub txtCilODPerto_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCilODPerto.LostFocus
        If br.valida_cil_Perto(txtCilODPerto.Text, txtAdicaoOD, txtEsfODPerto, os.tipo_receita_OD, txtEixoOD) = False Then
            err.SetError(txtCilODPerto, "Valor incorreto!")
            txtCilODPerto.Focus()
            valido_tab_receita = False
        Else
            err.SetError(txtCilODPerto, Nothing)
            valido_tab_receita = True
        End If
        If txtCilODPerto.Text = "0" Then
            txtEixoOD.Text = Nothing
        End If
    End Sub
    Private Sub txtCilOEPerto_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCilOEPerto.LostFocus
        If br.valida_cil_Perto(txtCilOEPerto.Text, txtAdicaoOE, txtEsfOEPerto, os.tipo_receita_OE, txtEixoOE) = False Then
            err.SetError(txtCilOEPerto, "Valor incorreto!")
            txtCilOEPerto.Focus()
            valido_tab_receita = False
        Else
            err.SetError(txtCilOEPerto, Nothing)
            valido_tab_receita = True
        End If
        If txtCilOEPerto.Text = "0" Then
            txtEixoOE.Text = Nothing
        End If
    End Sub
    Private Sub txtDNPOdPerto_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDNPOdPerto.LostFocus
        If br.valida_DNP_Perto(txtDNPOdPerto.Text, os.tipo_receita_OD) = False Then
            err.SetError(txtDNPOdPerto, "Valor Incorreto")
            txtDNPOdPerto.Focus()
            Exit Sub
        Else
            err.SetError(txtDNPOdPerto, Nothing)
            If os.tipo_receita_OD = tipo_Receita.VISAO_simples_perto Then
                txtDiametroOD.Text = br.diametro(txtAroHorizontal.Text, txtPonte.Text, txtDNPOdPerto.Text, txtMaiorDiametro.Text)
                base_od(txtEsfODPerto.Text, txtCilODPerto.Text, os.tipo_receita_OD)
                txtAlturaOD.Focus()
            End If
        End If
    End Sub
    Private Sub txtDNPOEPerto_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDNPOEPerto.LostFocus
        If br.valida_DNP_Perto(txtDNPOEPerto.Text, os.tipo_receita_OE) = False Then
            err.SetError(txtDNPOdPerto, "Valor Incorreto")
            txtDNPOdPerto.Focus()
            Exit Sub
        Else
            err.SetError(txtDNPOEPerto, Nothing)

            If os.tipo_receita_OE = tipo_Receita.VISAO_simples_perto Then
                txtDiametroOE.Text = br.diametro(txtAroHorizontal.Text, txtPonte.Text, txtDNPOEPerto.Text, txtMaiorDiametro.Text)
                base_oe(txtEsfOEPerto.Text, txtCilOEPerto.Text, os.tipo_receita_OE)
                txtAlturaOE.Focus()
            End If
        End If
    End Sub
    Private Sub txtEixoOD_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEixoOD.Validating
        If os.tipo_receita_OD = tipo_Receita.VISAO_simples_perto Then
            If txtCilODPerto.Text <> "" And txtCilODPerto.Text < 0 Then
                If txtEixoOD.Text = "" Then
                    err.SetError(txtEixoOD, "Informe um valor de Eixo!")
                    txtEixoOD.Focus()
                    valido_tab_receita = False
                ElseIf txtEixoOD.Text = "0" Then
                    txtEixoOD.Text = "180"
                Else
                    err.SetError(txtEixoOD, "")
                    valido_tab_receita = True
                End If
            End If
        Else
            If txtCilODLonge.Text <> "" And txtCilODLonge.Text < 0 Then
                If txtEixoOD.Text = "" Then
                    err.SetError(txtEixoOD, "Informe um valor de Eixo!")
                    txtEixoOD.Focus()
                    valido_tab_receita = False
                ElseIf txtEixoOD.Text = "0" Then
                    txtEixoOD.Text = "180"
                Else
                    err.SetError(txtEixoOD, "")
                    valido_tab_receita = True
                End If
            End If
        End If
    End Sub
    Private Sub txtEixoOE_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEixoOE.Validating
        If os.tipo_receita_OE = tipo_Receita.VISAO_simples_perto Then
            If txtCilOEPerto.Text <> "" And txtCilOEPerto.Text < 0 Then
                If txtEixoOE.Text = "" Then
                    err.SetError(txtEixoOE, "Informe um valor de Eixo!")
                    txtEixoOE.Focus()
                    valido_tab_receita = False
                ElseIf txtEixoOE.Text = "0" Then
                    txtEixoOE.Text = "180"
                Else
                    err.SetError(txtEixoOE, "")
                    valido_tab_receita = True
                End If
            End If
        Else
            If txtCilOELonge.Text <> "" And txtCilOELonge.Text < 0 Then
                If txtEixoOE.Text = "" Then
                    err.SetError(txtEixoOE, "Informe um valor de Eixo!")
                    txtEixoOE.Focus()
                    valido_tab_receita = False
                ElseIf txtEixoOE.Text = "0" Then
                    txtEixoOE.Text = "180"
                Else
                    err.SetError(txtEixoOE, "")
                    valido_tab_receita = True
                End If
            End If
        End If
    End Sub
    Private Sub validaTB2()
        If os.tipo_receita_OD = tipo_Receita.VISAO_simples_perto Then
            txtEsfODPerto_LostFocus(Me, Nothing)
            txtCilODPerto_LostFocus(Me, Nothing)
        Else
            txtDNPODLonge_LostFocus(Me, Nothing)
            txtAdicaoOD_LostFocus(Me, Nothing)
            txtEsfODLonge_LostFocus(Me, Nothing)
            txtCilODLonge_LostFocus(Me, Nothing)
        End If
        If os.tipo_receita_OE = tipo_Receita.VISAO_simples_perto Then
            txtEsfOEPerto_LostFocus(Me, Nothing)
            txtCilOEPerto_LostFocus(Me, Nothing)
        Else
            txtDNPOeLonge_LostFocus(Me, Nothing)
            txtAdicaoOe_LostFocus(Me, Nothing)
            txtEsfOeLonge_LostFocus(Me, Nothing)
            txtCilOeLonge_LostFocus(Me, Nothing)
        End If
        txtEixoOD_Validating(Me, Nothing)
        txtEixoOE_Validating(Me, Nothing)
    End Sub
#End Region
#Region "Conclusão"
    Private Sub chkTratamento_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTratamento.CheckedChanged
        Dim sql As String
        If os.cod_fase <> 1 And tipo_acao <> ACAO.TROCA_DIOPTRIA And tipo_acao <> ACAO.TROCA_PRODUTO Then
            AVISO("OS Já foi verificada e concluída!", Me, frmAviso.tipo_aviso.tipo_ok, True)
            Exit Sub
        End If
        If chkTratamento.Checked = False Then
            cbTratamento.DataSource = Nothing
            sql = "Delete from tratamentos_os where id_filial = " & os.id_filial & _
            " and cod_os = " & os.cod_os & ""
            MsgBox(d.Comando(sql, True))
            andamentos.insere_andamento(objAndamentos.tipo.aviso_os, os.id_filial, os.cod_os, _
            UserID, "Tratamento(s) Excluído(s)")
            lstTratamentos.DataSource = Nothing
        Else
            Dim tbTrat As New DataTable
            sql = "SELECT produtos.cod_produto, produtos.produto " & _
            "FROM produtos INNER JOIN " & _
            "servicos ON produtos.cod_produto = servicos.cod_produto " & _
            "WHERE (servicos.cod_tipo_servico = 4)"
            d.carrega_Tabela(sql, tbTrat)
            cbTratamento.DataSource = tbTrat
            cbTratamento.DisplayMember = "produto"
            cbTratamento.ValueMember = "cod_produto"
        End If
    End Sub

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
            sql = "SELECT produtos.cod_produto, produtos.produto " & _
            "FROM produtos INNER JOIN " & _
            "servicos ON produtos.cod_produto = servicos.cod_produto " & _
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
            sql = "SELECT produtos.cod_produto, produtos.produto  " & _
            "FROM produtos INNER JOIN " & _
            "servicos ON produtos.cod_produto = servicos.cod_produto " & _
            "WHERE (servicos.cod_tipo_servico = 2)"
            d.carrega_Tabela(sql, tbMont)
            cbMontagem.DataSource = tbMont
            cbMontagem.DisplayMember = "produto"
            cbMontagem.ValueMember = "cod_produto"
        End If
    End Sub
    Private Sub btnInserirTratamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirTratamento.Click
        Dim sql As String
        Dim dv As New DataView
        If os.cod_fase <> 1 And tipo_acao <> ACAO.TROCA_DIOPTRIA And tipo_acao <> ACAO.TROCA_PRODUTO Then
            AVISO("OS Já foi verificada e concluída!", Me, frmAviso.tipo_aviso.tipo_ok, True)
            Exit Sub
        End If
        Try
            dv.Table = tbTratamentos
            dv.RowFilter = "cod_produto = " & cbTratamento.SelectedValue & ""
            If dv.Count > 0 Then
                MsgBox("Tratamento já esxixte!", MsgBoxStyle.Critical)
                dv.Dispose()
                Exit Sub
            End If
        Catch ex As Exception

        End Try
        sql = "insert into tratamentos_os(id_filial,cod_os,cod_produto) values(" & _
        os.id_filial & "," & os.cod_os & "," & cbTratamento.SelectedValue & ")"
        MsgBox(d.Comando(sql, True))
        andamentos.insere_andamento(objAndamentos.tipo.aviso_os, os.id_filial, os.cod_os, _
                                    UserID, "Tratamento " & cbTratamento.Text & " incluido!")
        carrega_tratamentos()
    End Sub
    Private Sub carrega_tratamentos()
        Dim sql As String
        sql = "SELECT produtos.produto,tratamentos_os.cod_produto " & _
              "FROM tratamentos_os INNER JOIN " & _
              "produtos ON tratamentos_os.cod_produto = produtos.cod_produto " & _
              "WHERE (tratamentos_os.id_filial =" & os.id_filial & ") AND " & _
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

        intUsuario = osMaster.retorna_codigo_usuario(frmMain.strUsuario)
        'Procedimento 3: Concluir OS
        If os.cod_fase <> 1 And tipo_acao <> ACAO.TROCA_DIOPTRIA And tipo_acao <> ACAO.TROCA_PRODUTO Then
            AVISO("OS Já foi verificada e concluída!", Me, frmAviso.tipo_aviso.tipo_ok, True)
            Exit Sub
        End If
        If usuario.acesso(UserID, 3) = False Then
            AVISO("Usuário não tem permissão para concluir OS!", Me, frmAviso.tipo_aviso.tipo_ok, True)
            Exit Sub
        End If
        If valida_conclusao() = False Then
            AVISO("Não é possível concluir!", Me, frmAviso.tipo_aviso.tipo_ok, True)
            Exit Sub
        End If

        os.editar()
        os.cod_surfacagem = cbSurfacagem.SelectedValue
        os.cod_montagem = cbMontagem.SelectedValue
        os.cor_coloracao = txtCorColoracao.Text
        os.data_previsao_entrega = dtPrevisaoEntrega.Value
        os.hora_previsao_entrega = txtHoraPrevisaoEntrega.Text
        os.observacao = txtObs.Text
        os.cod_vendedora = intUsuario
        os.id_laboratorio = cbLaboratorio.SelectedValue
        os.doc_cliente = txtDocCliente.Text
        If os.tem_bloco Then
            'Caso haja blocos, indica que o laboratório de surfaçagem a
            'ser usado é o de número 1, laboratório da Labonorte.
            os.cod_lab_surf = 1
        End If
        Dim res As String
        Dim vautorizado As Double
        res = os.row_editado
        If res.StartsWith("OK") Then
            MsgBox(os.Salvar())
            If novo = False Then
                MsgBox(andamentos.insere_andamento(objAndamentos.tipo.alteracao_os, _
                                os.id_filial, os.cod_os, UserID, res.Substring(3)) & "Nº da OS: " & os.cod_os)
                If tipo_acao = ACAO.TROCA_DIOPTRIA Or tipo_acao = ACAO.TROCA_PRODUTO Then
                    Me.Close()
                    Exit Sub
                End If
            End If
        End If

        If pedido.existe(os.num_pedido, os.id_filial) = False Then
            Dim r As Integer
            r = MsgBox("Deseja Concluir a OS agora?", MsgBoxStyle.YesNo)
            If r = vbYes Then
                pedido.novo()
                pedido.autorizacao = 0
                pedido.num_pedido = os.num_pedido
                ' pedido.num_pedido = d.retorna_Chave("num_pedido", "pedido_balcao", " where id_filial = " & conf.Loja & "")
                pedido.id_filial = conf.Loja
                pedido.cod_cliente = os.cod_cliente
                pedido.cod_filial_cliente = os.cod_filial_cliente
                pedido.cod_vendedor = intUsuario
                pedido.cod_vendedor_externo = CInt(txtVendedorExterno.Text)
                pedido.data_pedido = Now
                pedido.forma_pagamento = osMaster.retornaFormaPagCli(os.cod_cliente, os.cod_filial_cliente)
                pedido.Salvar()
                os.editar()
                os.num_pedido = pedido.num_pedido
                os.cod_fase = Fases_os.Verificacao
                os.data_verificacao = d.hora
                MsgBox(os.Salvar() & vbCrLf & " número da OS: " & os.cod_os)
                andamentos.insere_andamento(objAndamentos.tipo.verificacao_os, os.id_filial, _
                os.cod_os, UserID, "")

                inserir_produtos(pedido, pedido.num_pedido, pedido.id_filial)

                Dim f As New frmPedido
                f._num_pedido = os.num_pedido
                f._id_filial = os.id_filial
                f.txtVendedorExterno.Text = CInt(txtVendedorExterno.Text)
                f.cbForma.Enabled = True
                f.Show()
                Me.Close()
                f.Focus()
            End If
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
        valor = valor + _
        pedido.valor_item(prod.Preco_venda, 1, prod.desconto(os.cod_cliente, os.cod_filial_cliente))
        'Surfacagem
        If chkSurfacagem.Checked Then
            prod.filtra(cbSurfacagem.SelectedValue)
            valor = valor + _
            pedido.valor_item(prod.Preco_venda, os.OlhosBloco, prod.desconto(os.cod_cliente, os.cod_filial_cliente))
        End If
        'Montagem
        If chkMontagem.Checked Then
            prod.filtra(cbMontagem.SelectedValue)
            valor = valor + _
            pedido.valor_item(prod.Preco_venda, os.olhos, prod.desconto(os.cod_cliente, os.cod_filial_cliente))
        End If
        If os.coloracao <> 0 Then
            prod.filtra(os.coloracao)
            valor = valor + _
            pedido.valor_item(prod.Preco_venda, os.olhos, prod.desconto(os.cod_cliente, os.cod_filial_cliente))
        End If
        'Tratamentos
        m = tbTratamentos.Rows.Count
        i = 0
        While i < m
            prod.filtra(tbTratamentos.Rows(i)("cod_produto"))
            valor = valor + _
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
        tsql = "Select os.*, (select nome_comercial from lentes_tabela where cod_tabela = os.cod_tab_od) as TAB_OD, " & _
        "(select nome_comercial from lentes_tabela where cod_tabela = os.cod_tab_oe) as TAB_OE, " & _
        "(select produto from produtos where cod_produto = os.cod_produto_od) as EST_OD," & _
        "(select produto from produtos where cod_produto = os.cod_produto_oe) as EST_OE, " & _
        "(select produto from produtos where cod_produto = os.cod_montagem) as Armacao " & _
        "FROM OS where OS.id_filial = " & os.id_filial & _
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
    Private Sub inserir_produtos(ByVal xPedido As objPedidoBalcao, ByVal x_num_pedido As Integer, ByVal x_id_filial As Integer)
        Dim p As New produtoClass
        Dim i, m As Integer
        Dim status_item As Integer = 1
        Dim fase_os As Fases_os
        'Processando olho direito
        p.Source("Select * from produtos where cod_produto = " & os.cod_produto_od & "")
        'Avalia se há estoque na Loja para Atender ao pedido
        If p.saldo_estoque_local(p.fldCod_produto, confLoja) >= 1 Then
            'Caso haja estoque, Efetua reserva do Produto
            Dim sql_res As String
            Dim chave As Integer
            chave = retorna_Chave("id_reserva", "reserva_lente_os", " where id_filial = " & conf.Loja & "")
            sql_res = "Insert into reserva_lente_os(id_reserva,id_filial,cod_os,cod_produto," & _
            "id_status_reserva,data_reserva) values(" & _
            chave & "," & confLoja & "," & os.cod_os & "," & p.fldCod_produto & _
            ",0," & d.pdtm(Now) & ")"
            MsgBox(d.Comando(sql_res, True) & " Reserva")
            fase_os = Fases_os.Estoque_Aguardando_Processamento
            status_item = status_item_pedido.reservado
            andamentos.insere_andamento(objAndamentos.tipo.Reserva_lente, os.id_filial, _
            os.cod_os, UserID, "Reserva de Lente do olho Direito")
        Else
            'Caso não haja estoque, efetua sugestão de pedido
            os.Sugere_compra(p.fldCod_produto, os.doc_cliente)
            status_item = status_item_pedido.Aguardando_processamento
            'Marca na OS a fase Estoque \ Aguardando Pedido
            fase_os = Fases_os.Estoque_Aguardando_Pedido
            andamentos.insere_andamento(objAndamentos.tipo.sugestao_pedido, os.id_filial, _
            os.cod_os, UserID, "Lente do olho Direito aguardando pedido")
        End If
        xPedido.insere_item(x_num_pedido, x_id_filial, p.fldCod_produto, 1, p.desconto(os.cod_cliente, os.cod_filial_cliente), p.Preco_venda, status_item)
        'Processando olho esquerdo
        status_item = Nothing
        p.Source("Select * from produtos where cod_produto = " & os.cod_produto_oe & "")
        If p.saldo_estoque_local(p.fldCod_produto, confLoja) >= 1 Then
            Dim sql_res As String
            Dim chave As Integer
            chave = retorna_Chave("id_reserva", "reserva_lente_os", " where id_filial = " & conf.Loja & "") + 1
            sql_res = "Insert into reserva_lente_os(id_reserva,id_filial,cod_os,cod_produto," & _
            "id_status_reserva,data_reserva) values(" & _
            chave & "," & confLoja & "," & os.cod_os & "," & p.fldCod_produto & _
            ",0," & d.pdtm(Now) & ")"
            d.Comando(sql_res, True)
            status_item = status_item_pedido.reservado
            andamentos.insere_andamento(objAndamentos.tipo.Reserva_lente, os.id_filial, _
            os.cod_os, UserID, "Reserva de Lente do olho Esquerdo")
            If fase_os <> Fases_os.Estoque_Aguardando_Pedido Then
                fase_os = Fases_os.Estoque_Aguardando_Processamento
            End If
        Else
            os.Sugere_compra(p.fldCod_produto, os.doc_cliente)
            status_item = status_item_pedido.Aguardando_processamento
            fase_os = Fases_os.Estoque_Aguardando_Pedido
            andamentos.insere_andamento(objAndamentos.tipo.sugestao_pedido, os.id_filial, _
           os.cod_os, UserID, "Lente do olho Esquerdo aguardando pedido")
        End If
        xPedido.insere_item(x_num_pedido, x_id_filial, p.fldCod_produto, 1, p.desconto(os.cod_cliente, os.cod_filial_cliente), p.Preco_venda, status_item)
        'Processando Serviços
        Dim Olhos As Integer = 0
        Dim olhosBloco As Integer = 0
        Olhos = os.olhos
        olhosBloco = os.OlhosBloco
        Dim xpac As Integer = 0 'Guarda o código do pacote se existir
        Dim xSurf As Integer = 0 'Guarda o código da surfaçagem do pacote se existir
        Dim xMont As Integer = 0 'Guarda o código da montagem do pacote se existir
        Dim dSurf As Integer = 0 'Guarda o desconto da surfaçagem de pacote se existir
        Dim dMont As Integer = 0 'Guarda o desconto da montagem de pacote se existir
        Dim xPacote As New objPacoteClienteDetalhes
        Try
            xpac = rdNum(xPedido.lista_itens(xPedido.num_pedido, xPedido.id_filial, False).Rows(0)("cod_pacote"))
        Catch ex As Exception
            xpac = 0
        End Try

        If xpac > 0 Then
            Dim tt As New DataTable 'Tabela temporaria para guardar o item do pacote
            xPacote.filtra(os.cod_cliente, os.cod_filial_cliente, xpac)
            tt = xPacote.lista_item(os.cod_tab_od)
            If tt.Rows.Count > 0 Then
                'Se o produto da OS inserido no pedido for um item de pacote, verifica
                'se esse item tem serviços de montagem e surfaçagem com desconto no pacote
                'e os armazena nas variáveis
                xSurf = rdNum(tt.Rows(0)("cod_surf"))
                dSurf = rdNum(tt.Rows(0)("desc_surf"))
                xMont = rdNum(tt.Rows(0)("cod_mont"))
                dMont = rdNum(tt.Rows(0)("desc_mont"))
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
                xPedido.insere_servico(x_num_pedido, x_id_filial, xSurf, olhosBloco, dSurf, p.fldPreco_venda, 1, xpac)
            Else
                'Caso a surfaçagem não seja do pacote, selecina o produto referente
                'à surfaçagem e insere no pedido com preço normal
                p.Source("Select * from produtos where cod_produto = " & os.cod_surfacagem & "")
                If olhosBloco = 0 Then
                    olhosBloco = InputBox("Não há produtos na OS, deseja cobrar pela Surfaçagem? (digite 0 para não, 1 ou 2 para cobrar)")
                    If olhosBloco > 2 Then olhosBloco = 2
                End If
                xPedido.insere_servico(x_num_pedido, x_id_filial, p.fldCod_produto, Olhos, p.fldDesconto, p.fldPreco_venda, 1, Nothing)
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
                xPedido.insere_servico(x_num_pedido, x_id_filial, xMont, Olhos, dMont, p.fldPreco_venda, 1, xpac)
            Else
                'Caso a montagem não seja do pacote, selecina o produto referente
                'à surfaçagem e insere no pedido com preço normal
                p.Source("Select * from produtos where cod_produto = " & os.cod_montagem & "")
                If Olhos = 0 Then
                    Olhos = InputBox("Não há produtos na OS, deseja cobrar pela Montagem? (digite 0 para não, 1 ou 2 para cobrar)")
                    If Olhos > 2 Then Olhos = 2
                End If
                xPedido.insere_servico(x_num_pedido, x_id_filial, p.fldCod_produto, Olhos, p.fldDesconto, p.fldPreco_venda, 1, Nothing)
            End If
        End If
        If os.coloracao <> 0 Then
            p.Source("Select * from produtos where cod_produto = " & os.coloracao & "")
            If Olhos = 0 Then
                Olhos = InputBox("Não há produtos na OS, deseja cobrar pela coloração? (digite 0 para não, 1 ou 2 para cobrar)")
                If Olhos > 2 Then Olhos = 2
            End If
            xPedido.insere_servico(x_num_pedido, x_id_filial, p.fldCod_produto, Olhos, p.fldDesconto, p.fldPreco_venda, 1, Nothing)
        End If
        m = tbTratamentos.Rows.Count
        While i < m
            p.Source("Select * from produtos where cod_produto = " & tbTratamentos.Rows(i)("cod_produto") & "")
            If Olhos = 0 Then
                Olhos = InputBox("Não há produtos na OS, deseja cobrar pelo tratamento? (digite 0 para não, 1 ou 2 para cobrar)")
                If Olhos > 2 Then Olhos = 2
            End If
            xPedido.insere_servico(x_num_pedido, x_id_filial, p.fldCod_produto, Olhos, p.fldDesconto, p.fldPreco_venda, 1, Nothing)
            i = i + 1
        End While
    End Sub
    Private Function pode_surfacar() As Boolean
        If os.tem_bloco = False And chkSurfacagem.Checked = True Then
            AVISO("Nenhum dos Produtos da os é bloco, portanto não pode haver surfaçagem!", Me, frmAviso.tipo_aviso.tipo_ok, True)
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
                    AVISO("Esta base não existe!", Me, frmAviso.tipo_aviso.tipo_ok, True)
                    Exit Sub
                Else
                    txtBaseOD.Text = base
                    os.cod_produto_od = Existe_od(base)
                    lblCodPOD.Text = os.cod_produto_od
                    prod.filtra(os.cod_produto_od)
                    txtEstoqueOD.Text = prod.Retorna_nome_prod(os.cod_produto_od) & " Barra: " & prod.fldCod_barra & ""
                    txtBaseOD.Enabled = False
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
                    AVISO("Esta base não existe!", Me, frmAviso.tipo_aviso.tipo_ok, True)
                    Exit Sub
                Else
                    txtBaseOE.Text = base
                    os.cod_produto_oe = existe_oe(base)
                    lblCodPOE.Text = os.cod_produto_oe
                    prod.filtra(os.cod_produto_oe)
                    txtEstoqueOE.Text = prod.Retorna_nome_prod(os.cod_produto_oe) & " Barra: " & prod.fldCod_barra & ""
                    txtBaseOE.Enabled = False
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
            'AVISO("Quantidade de " & prod.fldProduto & " :" & prod.saldo_estoque_local(cod_prod, confLoja) & _
            'prod.fldUnd & ".", Me, frmAviso.tipo_aviso.tipo_ok)
            Return cod_prod
        Else
            Return 0
        End If
    End Function

End Class