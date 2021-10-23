Imports mrotica_util
Public Class frmTrocaProduto_bkp
    Dim os As New ObjOS
    Dim tTroca As New DataTable
    Dim troca As New objTrocaproduto
    Dim d As New dados
    Dim sql As String
    Dim dev As New objDevolucaoEstoqueOS
    Dim mov As New objMovimentoDetalhe
    Public x_cod_troca As Integer
    Public x_id_filial As Integer
    Dim prod As New produtoClass
    Dim pod, poe, npod, npoe As Integer
    Dim andamentos As New objAndamentos
    Dim saida As New objSaidaOS
    Dim BR As New brOS
    Dim conf As New config
    Dim base As New objMaster

    Private Sub frmTrocaProduto_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        concluir_troca()
    End Sub
    Private Sub frmTrocaProduto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        abre_troca()
    End Sub
    Private Sub abre_troca()
        sql = "select * from troca_produto where cod_troca_Prod = " & x_cod_troca & " and id_filial = " & x_id_filial
        troca.filtrar(x_cod_troca, x_id_filial)
        If troca.max = 0 Then
            MessageBox.Show("Troca não existe!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            Exit Sub
        End If
        If troca.concluido = "S" Then
            MessageBox.Show("Esta troca já foi concluída!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            Exit Sub
        End If
        os = New ObjOS(troca.cod_os, troca.id_filial_os)
        'Avalia se há devolução não concluída
        dev.filtrar(troca.cod_devolucao_os, troca.id_filial)
        If dev.max = 0 Then
            If nova_devolucao().StartsWith("ER") Then
                MsgBox("Ocorreu um erro na gravação da troca, tente novamente!")
                Me.Close()
                Exit Sub
            End If
        End If
        pod = troca.cod_prod_od
        poe = troca.cod_prod_oe
        If pod <> poe Then
            If dev.tem_produto(pod) = 1 Then
                txtCodbarraOD.Enabled = False
            Else
                If os.cod_tab_od = 1 Or os.cod_tab_od = 2 Then
                    txtCodbarraOD.Enabled = False
                Else
                    txtCodbarraOD.Enabled = True
                End If
            End If
            If dev.tem_produto(poe) = 1 Then
                txtCodBarraOE.Enabled = False
            Else
                If os.cod_tab_oe = 1 Or os.cod_tab_oe = 2 Then
                    txtCodBarraOE.Enabled = False
                Else
                    txtCodBarraOE.Enabled = True
                End If
            End If
        Else
            If dev.tem_produto(pod) = 0 Then
                txtCodbarraOD.Enabled = True
                txtCodBarraOE.Enabled = True
            End If
            If dev.tem_produto(pod) = 1 Then
                txtCodbarraOD.Enabled = False
            End If
            If dev.tem_produto(poe) > 1 Then
                txtCodBarraOE.Enabled = False
                txtCodbarraOD.Enabled = False
            End If
        End If
        If pod = 0 Then
            txtCodbarraOD.Enabled = False
        End If
        If poe = 0 Then
            txtCodBarraOE.Enabled = False
        End If
        npod = troca.cod_prod_od_novo
        npoe = troca.cod_prod_oe_novo


        txtcodOD.Text = pod
        txtCodOE.Text = poe
        txtPod.Text = prod.Retorna_nome_prod(pod)
        txtPoe.Text = prod.Retorna_nome_prod(poe)

        txtCodnOD.Text = npod
        txtCodNOE.Text = npoe
        txtnpod.Text = prod.Retorna_nome_prod(npod)
        txtnPoe.Text = prod.Retorna_nome_prod(npoe)
        saida.carrega_saida_os(troca.cod_os, conf.Filial, troca.id_filial_os)
        novo(npod, npoe)
        If txtCodbarraOD.Enabled = False And txtCodBarraOE.Enabled = False Then
            grpNovo.Enabled = True
        End If
        txtObs.Text = troca.obs
    End Sub
    Private Sub novo(ByVal xnpod, ByVal xnpoe)
        txtCodBarraNOD.Enabled = True
        txtCodBarraNOE.Enabled = True
        If troca.cod_tipo_troca = objTrocaproduto.tipo_troca.troca_base Then
            txtCodnOD.ReadOnly = True
            txtCodNOE.ReadOnly = True
            If troca.cod_prod_od_novo = 0 Then
                txtCodBarraNOD.Enabled = False
                txtCodbarraOD.Enabled = False
            Else
                If xnpod = poe Then
                    If saida.tem_produto(xnpod) > 1 Then
                        txtCodBarraNOD.Enabled = False
                    End If
                Else
                    If saida.tem_produto(xnpod) = 1 Then
                        txtCodBarraNOD.Enabled = False
                    End If
                End If
            End If
            If troca.cod_prod_oe_novo = 0 Then
                txtCodBarraNOE.Enabled = False
                txtCodBarraOE.Enabled = False
            Else
                If xnpod = xnpoe Then
                    If saida.tem_produto(xnpoe) > 1 Then
                        txtCodBarraNOD.Enabled = False
                        txtCodBarraNOE.Enabled = False
                    End If
                Else
                    If xnpoe = pod Then
                        If saida.tem_produto(xnpoe) > 1 Then
                            txtCodBarraNOE.Enabled = False
                        End If
                    Else
                        If saida.tem_produto(xnpoe) = 1 Then
                            txtCodBarraNOE.Enabled = False
                        End If
                    End If
                End If
            End If
        Else
            If xnpod <> xnpoe Then
                If saida.tem_produto(xnpod) = 1 Then
                    txtCodBarraNOD.Enabled = False
                Else
                    If os.cod_tab_od = 1 Or os.cod_tab_od = 2 Then
                        txtCodBarraNOD.Enabled = False
                    Else
                        txtCodBarraNOD.Enabled = True
                    End If
                End If

                If saida.tem_produto(xnpoe) = 1 Then
                    txtCodBarraNOE.Enabled = False
                Else
                    If os.cod_tab_oe = 1 Or os.cod_tab_oe = 2 Then
                        txtCodBarraNOE.Enabled = False
                    Else
                        txtCodBarraNOE.Enabled = True
                    End If
                End If
            Else
                If saida.tem_produto(xnpod) = 0 Then
                    txtCodBarraNOD.Enabled = True
                    txtCodBarraNOE.Enabled = True
                End If
                If saida.tem_produto(xnpod) = 1 Then
                    txtCodBarraNOD.Enabled = False
                End If
                If saida.tem_produto(xnpoe) > 1 Then
                    txtCodBarraNOE.Enabled = False
                    txtCodBarraNOD.Enabled = False
                End If
            End If
        End If
    End Sub
    Private Sub txtCodbarraOD_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodbarraOD.KeyDown
        Dim f As New frmConsultaProdDiop
        Dim es As String 'Espécie
        Select Case e.KeyCode
            Case Keys.Enter
                If txtCodbarraOD.Text = "" Then
                    'se não for informado o código de barras, abre tela para confirmação
                    'dos dados do produto
                    es = prod.Retorna_especie_Tabela(txtcodOD.Text)
                    If es = "L" Then
                        f.tipo = "L"
                        f.cod_prod = txtcodOD.Text
                        f.ShowDialog(Me)
                        If f.Result = True Then
                            GoTo entrada_od
                        Else
                            GoTo FIM
                        End If
                    Else
                        f.tipo = "B"
                        f.cod_prod = txtcodOD.Text
                        f.ShowDialog(Me)
                        If f.Result = True Then
                            GoTo entrada_od
                        Else
                            GoTo fim
                        End If
                    End If
                End If
                If prod.Retorna_cod_prod(txtCodbarraOD.Text) <> txtcodOD.Text Then
                    MsgBox(prod.Retorna_cod_prod(txtCodbarraOD.Text) & " " & txtcodOD.Text)
                    MessageBox.Show("Código de barras não correnponde ao produto!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtCodbarraOD.Text = Nothing
                    Exit Sub
                Else
                    GoTo entrada_od
                End If
fim:
                MessageBox.Show("Produto informado não corresponde ao produto da OS.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
entrada_od:
                'Avalia de há devoluções não concluídas para essa OS.
                dev.filtrar(troca.cod_devolucao_os, troca.id_filial)
                If dev.max = 0 Then
                    'Caso não haja devoluções não concluídas, insere uma nova devolução.
                    nova_devolucao()
                End If
                'inere movimento de entrada da peça.
                prod.filtra(txtcodOD.Text)
                mov.novo()
                mov.item = mov.ret_ultimo_item(dev.cod_movimento)
                mov.cod_movimento = dev.cod_movimento
                mov.cod_produto = prod.fldCod_produto
                mov.quant = 1
                mov.desconto = 0
                mov.pUnit = prod.fldPreco_custo
                mov.Pvenda = 0
                mov.descVenda = 0
                mov.estoqueFis = mov.ret_saldo_fisico(CInt(txtcodOD.Text)) + CDbl(1)
                mov.estoqueFin = mov.ret_saldo_fin(CInt(txtcodOD.Text)) + ((prod.fldPreco_custo) * 1)
                mov.historico = "Devolução para estoque olho direito. Nº da devolução " & dev.cod_devolucao_os & _
                " da OS. " & dev.id_filial_os & "-" & dev.cod_os
                mov.Salvar()
                txtCodbarraOD.Enabled = False
                andamentos.insere_andamento(objAndamentos.tipo.devolucao_estoque, dev.id_filial, dev.cod_os, UserID, _
                "Devolução para estoque olho direito da devolução " & dev.cod_devolucao_os)
                conclui_Devolucao()
                txtCodBarraOE.Focus()
                abre_troca()
        End Select

    End Sub
    Private Sub txtCodbarraOE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodBarraOE.KeyDown
        Dim f As New frmConsultaProdDiop
        Dim es As String 'Espécie
        Select Case e.KeyCode
            Case Keys.Enter
                If txtCodBarraOE.Text = "" Then
                    'se não for informado o código de barras, abre tela para confirmação
                    'dos dados do produto
                    es = prod.Retorna_especie_Tabela(txtCodOE.Text)
                    If es = "L" Then
                        f.tipo = "L"
                        f.cod_prod = txtCodOE.Text
                        f.ShowDialog(Me)
                        If f.Result = True Then
                            GoTo entrada_oe
                        Else
                            GoTo FIM
                        End If
                    Else
                        f.tipo = "B"
                        f.cod_prod = txtCodOE.Text
                        f.ShowDialog(Me)
                        If f.Result = True Then
                            GoTo entrada_oe
                        Else
                            GoTo fim
                        End If
                    End If
                End If
                If prod.Retorna_cod_prod(txtCodBarraOE.Text) <> txtCodOE.Text Then
                    MsgBox(prod.Retorna_cod_prod(txtCodBarraOE.Text) & " " & txtCodOE.Text)
                    Dim r As frmAviso.respo
                    MessageBox.Show("Código de barras não correnponde ao produto!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtCodBarraOE.Text = Nothing
                    Exit Sub
                Else
                    GoTo entrada_oe
                End If
fim:
                MessageBox.Show("Produto informado não corresponde ao produto da OS.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
entrada_oe:
                'Avalia de há devoluções não concluídas para essa OS.
                dev.filtrar(troca.cod_devolucao_os, troca.id_filial)
                If dev.max = 0 Then
                    'Caso não haja devoluções não concluídas, insere uma nova devolução.
                    nova_devolucao()
                End If
                'inere movimento de entrada da peça.
                prod.filtra(txtCodOE.Text)
                mov.novo()
                mov.item = mov.ret_ultimo_item(dev.cod_movimento)
                mov.cod_movimento = dev.cod_movimento
                mov.cod_produto = prod.fldCod_produto
                mov.quant = 1
                mov.desconto = 0
                mov.pUnit = prod.fldPreco_custo
                mov.Pvenda = 0
                mov.descVenda = 0
                mov.estoqueFis = mov.ret_saldo_fisico(CInt(txtCodOE.Text)) + CDbl(1)
                mov.estoqueFin = mov.ret_saldo_fin(CInt(txtCodOE.Text)) + ((prod.fldPreco_custo) * 1)
                mov.historico = "Devolução para estoque olho esquerdo. Nº da devolução " & dev.cod_devolucao_os & _
                " da OS. " & dev.id_filial_os & "-" & dev.cod_os
                mov.Salvar()
                txtCodBarraOE.Enabled = False
                andamentos.insere_andamento(objAndamentos.tipo.devolucao_estoque, dev.id_filial, dev.cod_os, UserID, _
                "Devolução para estoque olho esquerdo da devolução " & dev.cod_devolucao_os)
                conclui_Devolucao()
                txtCodBarraNOD.Focus()
                abre_troca()
        End Select

    End Sub
    Private Function nova_devolucao() As String
        Dim res As String
        dev.novo()
        dev.id_filial = conf.Filial
        dev.id_filial_os = troca.id_filial_os
        dev.cod_os = troca.cod_os
        dev.data = d.hora
        dev.id_usuario = UserID
        res = dev.Salvar()
        If res.StartsWith("OK") Then
            troca.editar()
            troca.cod_devolucao_os = dev.cod_devolucao_os
            res = troca.Salvar()
        End If
        Return res
    End Function
    Private Sub conclui_Devolucao()
        If txtCodbarraOD.Enabled = False And txtCodBarraOE.Enabled = False Then
            MessageBox.Show(dev.conclui_movimento(), "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub txtCodBarraNOD_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodBarraNOD.KeyDown
        Dim q As Integer = -1
        Dim f As New frmConsultaProdDiop
        Dim eS As Char

        Select Case e.KeyCode
            Case Keys.Enter
                If txtCodBarraNOD.Text = "" Then
                    eS = prod.Retorna_especie_Tabela(txtCodnOD.Text)
                    If eS = "L" Then
                        f.tipo = "L"
                        f.cod_prod = txtCodnOD.Text
                        f.ShowDialog(Me)
                        If f.Result = True Then
                            GoTo SAIDA_OD
                        Else
                            GoTo FIM
                        End If
                    Else
                        f.tipo = "B"
                        f.cod_prod = txtCodnOD.Text
                        f.ShowDialog(Me)
                        If f.Result = True Then
                            GoTo SAIDA_OD
                        Else
                            GoTo fim
                        End If
                    End If
                End If
                If prod.Retorna_cod_prod(txtCodBarraNOD.Text) = txtCodnOD.Text Then
SAIDA_OD:
                    If prod.saldo_estoque_local(txtCodnOD.Text, conf.Filial) >= 1 Then
                        'Caso haja saldo, vai para baixa
                        GoTo baixa
                    Else
                        MessageBox.Show("Saldo insuficiente!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtCodBarraNOD.Text = ""
                        Exit Sub
                    End If
baixa:
                    If saida.existe_saida_os(troca.cod_os, conf.Filial, troca.id_filial_os) = False Then
                        nova_saida()
                    Else
                        saida.carrega_saida_os(troca.cod_os, conf.Filial, troca.id_filial_os)
                    End If
                    prod.Source("Select * from produtos where cod_produto = " & txtCodnOD.Text & "")
                    mov.novo()
                    mov.item = mov.ret_ultimo_item(saida.cod_movimento)
                    mov.cod_movimento = saida.cod_movimento
                    mov.cod_produto = prod.fldCod_produto
                    mov.quant = q
                    mov.desconto = 0
                    mov.pUnit = prod.fldPreco_custo
                    mov.Pvenda = prod.fldPreco_venda
                    mov.descVenda = prod.fldDesconto
                    mov.estoqueFis = mov.ret_saldo_fisico(os.cod_produto_od) + CDbl(q)
                    mov.estoqueFin = mov.ret_saldo_fin(os.cod_produto_od) + ((prod.fldPreco_custo) * q)
                    mov.historico = "Baixa do olho direito da OS. " & dev.id_filial_os & "-" & dev.cod_os
                    mov.Salvar()
                    som_ok()
                    txtCodBarraNOD.Enabled = False
                    os.editar()
                    os.cod_fase = Fases_os.Estoque_Aguardando_Processamento
                    os.Salvar()
                    andamentos.insere_andamento(objAndamentos.tipo.Baixa_os, os.id_filial, _
                    os.cod_os, UserID, "Baixa de Lente do Olho Direito")
                    If txtCodBarraNOD.Enabled = False Then
                        MessageBox.Show("Baixa Concluída!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        os.editar()
                        os.cod_fase = Fases_os.Estoque_Aguardando_Impressão
                        os.Salvar()
                        inserir_fila(os.cod_os, os.id_filial)
                        troca.editar()
                        troca.prod_od_OK = "S"
                        troca.Salvar()
                        concluir_troca()
                    End If
                    txtCodBarraNOE.Focus()
                    atualiza_prod_od()
                Else
fim:
                    MessageBox.Show("Produto não confere com produto da OS!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtCodBarraNOD.Text = ""
                    Exit Sub
                End If
        End Select
    End Sub

    Private Sub txtCodBarraNOE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodBarraNOE.KeyDown
        Dim q As Integer = -1
        Dim f As New frmConsultaProdDiop
        Dim eS As Char
        Select Case e.KeyCode
            Case Keys.Enter
                If txtCodBarraNOE.Text = "" Then
                    eS = prod.Retorna_especie_Tabela(txtCodNOE.Text)
                    If eS = "L" Then
                        f.tipo = "L"
                        f.cod_prod = txtCodNOE.Text
                        f.ShowDialog(Me)
                        If f.Result = True Then
                            GoTo SAIDA_Oe
                        Else
                            GoTo FIM
                        End If
                    Else
                        f.tipo = "B"
                        f.cod_prod = txtCodNOE.Text
                        f.ShowDialog(Me)
                        If f.Result = True Then
                            GoTo SAIDA_Oe
                        Else
                            GoTo fim
                        End If
                    End If
                End If
                If prod.Retorna_cod_prod(txtCodBarraNOE.Text) = txtCodNOE.Text Then
SAIDA_OE:
                    If prod.saldo_estoque_local(txtCodNOE.Text, conf.Filial) >= 1 Then
                        'Caso haja saldo, vai para baixa
                        GoTo baixa
                    Else
                        som_erro()
                        MessageBox.Show("Saldo insuficiente!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtCodBarraNOE.Text = ""
                        Exit Sub
                    End If
baixa:
                    If saida.existe_saida_os(troca.cod_os, conf.Filial, troca.id_filial_os) = False Then
                        nova_saida()
                    Else
                        saida.carrega_saida_os(troca.cod_os, conf.Filial, troca.id_filial_os)
                    End If
                    prod.Source("Select * from produtos where cod_produto = " & txtCodNOE.Text & "")
                    mov.novo()
                    mov.item = mov.ret_ultimo_item(saida.cod_movimento)
                    mov.cod_movimento = saida.cod_movimento
                    mov.cod_produto = prod.fldCod_produto
                    mov.quant = q
                    mov.desconto = 0
                    mov.pUnit = prod.fldPreco_custo
                    mov.Pvenda = prod.fldPreco_venda
                    mov.descVenda = prod.fldDesconto
                    mov.estoqueFis = mov.ret_saldo_fisico(os.cod_produto_oe) + CDbl(q)
                    mov.estoqueFin = mov.ret_saldo_fin(os.cod_produto_oe) + ((prod.fldPreco_custo) * q)
                    mov.historico = "Baixa do olho esquerdo da OS. " & dev.id_filial_os & "-" & dev.cod_os
                    mov.Salvar()
                    som_ok()
                    txtCodBarraNOE.Enabled = False
                    os.editar()
                    os.cod_fase = Fases_os.Estoque_Aguardando_Processamento
                    os.Salvar()
                    andamentos.insere_andamento(objAndamentos.tipo.Baixa_os, os.id_filial, _
                    os.cod_os, UserID, "Baixa de Lente do Olho esquerdo")
                    If txtCodBarraNOE.Enabled = False Then
                        MessageBox.Show("Baixa Concluída!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        os.editar()
                        os.cod_fase = Fases_os.Estoque_Aguardando_Impressão
                        os.Salvar()
                        inserir_fila(os.cod_os, os.id_filial)
                        troca.editar()
                        troca.prod_oe_OK = "S"
                        troca.Salvar()
                        concluir_troca()
                    End If
                    atualiza_prod_oe()
                Else
fim:
                    MessageBox.Show("Produto não confere com produto da OS!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtCodBarraNOE.Text = ""
                    Exit Sub
                End If
        End Select
    End Sub
    Private Sub inserir_fila(ByVal x_os As Integer, ByVal x_filial As Integer)
        Dim f As New objFilaImpressao
        saida.conclui_movimento()
        dev.conclui_movimento()
        troca.conclui_troca()
        MessageBox.Show("Na fila para impressão:" & vbCrLf & f.Inserir_fila(x_os, x_filial, conf.Filial), "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'AVISO("Na fila para impressão:" & vbCrLf & f.Inserir_fila(x_os, x_filial, conf.Filial), Me, frmAviso.tipo_aviso.tipo_ok)
    End Sub
    Private Sub nova_saida()
        saida.novo()
        saida.cod_movimento = retorna_Chave("cod_movimento", "movimentomaster", " where id_filial = " & conf.Filial & "")
        saida.cod_saida_os = retorna_Chave("cod_saida_os", "saida_os", " where cod_movimento = " & saida.cod_movimento & " and id_filial = " & conf.Filial & "")
        saida.cod_natureza = 2
        saida.cod_os = troca.cod_os
        saida.id_filial_os = troca.id_filial_os
        saida.data = d.hora
        saida.doc = "baixa troca de base: " & troca.cod_troca_prod
        saida.id_usuario = UserID
        saida.Salvar()
    End Sub
    Private Sub txtCodnOD_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodnOD.KeyDown
        If troca.cod_tipo_troca = objTrocaproduto.tipo_troca.troca_base Then
            Exit Sub
        End If
        novos_produtos(e)
    End Sub
    Private Sub novos_produtos(ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim f As New frmOS
        Select Case e.KeyCode
            Case Keys.Enter
                Dim r As String
                If os.data_verificacao <> Nothing Then
                    r = os.desverifica_os
                    If r.Substring(0, 2) = "ER" Then
                        AVISO(r, Me, frmAviso.tipo_aviso.tipo_ok, True)
                        Exit Sub
                    End If
                End If
                f.tipo_acao = frmOS.ACAO.TROCA_PRODUTO
                f.n_OS = os.cod_os
                f.Filial = os.id_filial
                f.novo = False
                f.ShowDialog(Me)
                If f.strErro = "Error" Then
                    Exit Sub
                End If
                If f.strErro = "Salvo" Then
                    troca.editar()
                    troca.cod_prod_od_novo = f.lblCodPOD.Text
                    troca.cod_prod_oe_novo = f.lblCodPOE.Text
                    MsgBox(troca.Salvar())
                    abre_troca()
                    f.Dispose()
                End If
        End Select
    End Sub
    Private Sub concluir_troca()
        If (txtCodBarraNOD.Enabled = False) And (txtCodBarraNOE.Enabled = False) _
        And txtCodbarraOD.Enabled = False And txtCodBarraOE.Enabled = False Then
            Dim res As String
            res = troca.conclui_troca()
            If res.StartsWith("OK") Then
                MessageBox.Show(res & vbCrLf & " Troca concluída com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub atualiza_prod_od()
        Dim strSQL As String = ""
        strSQL = "cod_produto = " & os.cod_produto_od & " where num_pedido = " & os.num_pedido & " and id_filial = " & os.id_filial & " and item = 1"
        base.atualiza_registros("pedido_balcao_itens", strSQL, True)
    End Sub

    Private Sub atualiza_prod_oe()
        Dim strSQL As String = ""
        strSQL = "cod_produto = " & os.cod_produto_oe & " where num_pedido = " & os.num_pedido & " and id_filial = " & os.id_filial & " and item = 2"
        base.atualiza_registros("pedido_balcao_itens", strSQL, True)
    End Sub
End Class