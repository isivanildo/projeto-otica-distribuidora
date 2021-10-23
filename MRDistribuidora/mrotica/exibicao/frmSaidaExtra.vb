Imports mrotica_util
Public Class frmSaidaExtra
    Dim sExtra As New objSaidaExtra
    Dim os As New ObjOS
    Dim x_os, id_filial As Integer
    Dim prod As New produtoClass
    Dim mov As New objMovimentoDetalhe
    Dim andamentos As New objAndamentos
    Dim dev As New objDevolucaoEstoqueOS
    Dim d As New dados
    Dim saida_os As New objSaidaOS
    Dim conf As New config
    Public nSaidaExtra As Integer
    Public nFilial As Integer
    Dim objExtra As New objMaster
    Dim intControle As Int16 = 0
    Dim intUsuario As Integer = 0

    Private Sub frmSaidaExtra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If nSaidaExtra = Nothing Then nSaidaExtra = InputBox("Número da Saída Extra:")
        If nFilial = Nothing Then nFilial = InputBox("Filial Saída Extra:")
        sExtra.carrega_saida_extra(nSaidaExtra, nFilial, "N")
        If sExtra.max = 0 Then
            sExtra.carrega_saida_extra(nSaidaExtra, nFilial, "S")
            If sExtra.max > 0 Then
                MessageBox.Show("Esta saída extra já foi concluída.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                Exit Sub
            Else
                MessageBox.Show("Saída extra não encontrada.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

        'Avalia se há devolução não concluída
        dev.filtrar(sExtra.cod_os, sExtra.id_filial_os, "N")
        If dev.max = 0 Then
            'Caso não haja devolução em aberto, avalia se há uma devolução concluída
            'se houver, bloqueia o grupo de devolução e passa para a saída dos produtos
            'da troca
            dev.filtrar(sExtra.cod_os, sExtra.id_filial_os, "S")
            Debug.Print(dev.max)
        End If

        abrir_saida()
        intUsuario = objExtra.retorna_codigo_usuario(frmMain.intCodigoUsuario)
    End Sub
    Private Sub abrir_saida()
        os = New ObjOS(sExtra.cod_os, sExtra.id_filial_os)
        'Lado direito
        txtCodOD.Text = os.cod_produto_od
        txtpod.Text = prod.Retorna_nome_prod(os.cod_produto_od)
        If sExtra.od = "S" And txtCodOD.Text <> "0" And sExtra.od_ok = "N" Then
            txtCodBarraOD.Enabled = True
        Else
            txtCodBarraOD.Enabled = False
        End If
        'Lado esquerdo
        txtCodOE.Text = os.cod_produto_oe
        txtPoe.Text = prod.Retorna_nome_prod(os.cod_produto_oe)
        If sExtra.oe = "S" And txtCodOE.Text <> "0" And sExtra.oe_ok = "N" Then
            txtCodBarraOE.Enabled = True
        Else
            txtCodBarraOE.Enabled = False
        End If
        txtObs.Text = sExtra.Desc_saida_extra
        troca()
    End Sub
    Private Function troca() As Boolean
        Dim troca_aberta As Boolean = False
        If sExtra.troca_Produto_od = "S" Then
            'Analisa se o produto do olho direito foi
            'perdido.
            If sExtra.od = "N" Then
                'caso não tenha sido perdido, será necessário devolvar.
                'Avalia então se já foi devolvido.
                If sExtra.dev_od = "N" Then
                    txtBarraDevOD.Enabled = True
                    troca_aberta = True
                    txtCodDevOD.Text = os.cod_produto_od
                    txtPDevOD.Text = prod.Retorna_nome_prod(os.cod_produto_od)
                End If
            End If
            txtCodOD.Text = sExtra.npod
            txtpod.Text = prod.Retorna_nome_prod(txtCodOD.Text)
            txtCodOD.Enabled = True
            If txtCodOD.Text <> "0" And sExtra.od_ok = "N" Then
                txtCodBarraOD.Enabled = True
                txtCodOD.Enabled = False
            Else
                txtCodBarraOD.Enabled = False
            End If
            If sExtra.od_ok = "S" Then txtCodOD.Enabled = False
        End If
        If sExtra.troca_Produto_oe = "S" Then
            'Analisa se o produto do olho equerdo foi
            'perdido.
            If sExtra.oe = "N" Then
                'caso não tenha sido perdido, será necessário devolvar.
                'Avalia então se já foi devolvido.
                If sExtra.dev_oe = "N" Then
                    txtBarraDevOE.Enabled = True
                    troca_aberta = True
                    txtCodDevOE.Text = os.cod_produto_oe
                    txtPDevOE.Text = prod.Retorna_nome_prod(os.cod_produto_oe)
                End If
            End If
            txtCodOE.Text = sExtra.npoe
            txtPoe.Text = prod.Retorna_nome_prod(txtCodOE.Text)
            txtCodOE.Enabled = True
            If txtCodOE.Text <> "0" And sExtra.oe_ok = "N" Then
                txtCodOE.Enabled = False
                txtCodBarraOE.Enabled = True
            Else
                txtCodBarraOE.Enabled = False
            End If
            If sExtra.oe_ok = "N" Then txtCodOE.Enabled = False
        End If
        If troca_aberta = True Then
            grpDev.Enabled = True
            grpNovo.Enabled = False
        Else
            grpDev.Enabled = False
            grpNovo.Enabled = True

        End If
        saida()
    End Function
    Private Sub saida()
        If sExtra.troca_Produto_od = "S" Or sExtra.troca_Produto_oe = "S" Then
            If sExtra.od = "N" Or sExtra.oe = "N" Then
                saida_os.filtra(sExtra.cod_os, sExtra.id_filial_os, "N")
                If saida_os.max = 0 Then
                    With saida_os
                        .novo()
                        .cod_movimento = retorna_Chave("cod_movimento", "movimentomaster", " where id_filial = " & conf.Filial & "")
                        .cod_saida_os = retorna_Chave("cod_saida_os", "saida_os", " where cod_movimento = " & .cod_movimento & " and id_filial = " & conf.Filial & "")
                        .cod_natureza = 2
                        .cod_os = sExtra.cod_os
                        .id_filial_os = sExtra.id_filial_os
                        .data = d.hora
                        .doc = "baixa troca de produto da saída Extra: " & sExtra.cod_saida_extra
                        .id_usuario = UserID
                        .Salvar()
                    End With
                End If
            End If
        End If
    End Sub
    Private Sub txtCodbarraOD_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodBarraOD.KeyDown
        Dim q As Integer = -1
        Dim f As New frmConsultaProdDiop
        Dim eS As Char
        Dim hist_and As String
        Dim strSQL As String = ""
        intControle = 0
        Select Case e.KeyCode
            Case Keys.Enter
                If txtCodBarraOD.Text = "" Then
                    eS = prod.Retorna_especie_Tabela(txtCodOD.Text)
                    If eS = "L" Then
                        f.tipo = "L"
                        f.cod_prod = txtCodOD.Text
                        f.ShowDialog(Me)
                        If f.Result = True Then
                            GoTo SAIDA_OD
                        Else
                            GoTo fim
                        End If
                    Else
                        f.tipo = "B"
                        f.cod_prod = txtCodOD.Text
                        f.ShowDialog(Me)
                        If f.Result = True Then
                            GoTo SAIDA_OD
                        Else
                            GoTo fim
                        End If
                    End If
                End If
                If prod.Retorna_cod_prod(txtCodBarraOD.Text) = txtCodOD.Text Then
SAIDA_OD:
                    Dim intCodigo As Integer
                    If intControle = 0 Then
                        If prod.saldo_estoque_local(txtCodOD.Text, conf.Filial) >= 1 Then
                            'Caso haja saldo, vai para baixa
                            GoTo baixa
                        Else
                            MessageBox.Show("Saldo insuficiente.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtCodBarraOD.Text = ""
                            Exit Sub
                        End If
                    Else
                        intCodigo = prod.Retorna_cod_prod(txtCodBarraOD.Text)
                        If prod.saldo_estoque_local(intCodigo, conf.Filial) >= 1 Then
                            'Caso haja saldo, vai para baixa
                            GoTo baixa
                        Else
                            MessageBox.Show("Saldo insuficiente.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtCodBarraOD.Text = ""
                            Exit Sub
                        End If
                    End If

baixa:
                    If intControle = 0 Then
                        prod.Source("Select * from produtos where cod_produto = " & txtCodOD.Text & "")
                    Else
                        prod.Source("Select * from produtos where cod_produto = " & intCodigo & "")
                    End If


                    mov.novo()
                    'Se houver troca e o produto não foi perdido,
                    'não será uma saída extra, e sim uma saída normal.
                    If sExtra.troca_Produto_od = "S" And sExtra.od = "N" Then
                        mov.item = mov.ret_ultimo_item(saida_os.cod_movimento)
                        mov.cod_movimento = saida_os.cod_movimento
                        mov.historico = "Saída do olho direito da OS. " & sExtra.id_filial_os
                        hist_and = "Baixa do Olho Direito."
                    Else
                        mov.item = mov.ret_ultimo_item(sExtra.cod_movimento)
                        mov.cod_movimento = sExtra.cod_movimento
                        mov.historico = "Saída Extra do olho direito da OS. " & sExtra.id_filial_os & "-" & sExtra.cod_os
                        If intControle = 0 Then
                            hist_and = "Saída Extra do Olho Direito."
                        Else
                            Dim fTexto As New frmObs
                            fTexto.ShowDialog()
                            hist_and = fTexto.txtTexto.Text
                            fTexto.Dispose()
                            'hist_and = "Devido falta na industria da " & txtpod.Text & " tivemos que efetuar troca de produto por " & prod.fldProduto
                        End If
                    End If
                    mov.cod_produto = prod.fldCod_produto
                    mov.quant = q
                    mov.desconto = 0
                    mov.pUnit = prod.fldPreco_custo
                    mov.Pvenda = 0
                    mov.descVenda = 0
                    If intControle = 0 Then
                        mov.estoqueFis = mov.ret_saldo_fisico(os.cod_produto_od) + CDbl(q)
                    Else
                        mov.estoqueFis = mov.ret_saldo_fisico(prod.fldCod_produto) + CDbl(q)
                    End If
                    If intControle = 0 Then
                        mov.estoqueFin = mov.ret_saldo_fin(os.cod_produto_od) + ((prod.fldPreco_custo) * q)
                    Else
                        mov.estoqueFin = mov.ret_saldo_fin(prod.fldCod_produto) + ((prod.fldPreco_custo) * q)
                    End If

                    mov.Salvar()
                    sExtra.editar()
                    sExtra.od_ok = "S"
                    sExtra.Salvar()
                    som_ok()
                    andamentos.insere_andamento(objAndamentos.tipo.Baixa_os, os.id_filial,
                    os.cod_os, UserID, hist_and)

                    'Atualiza o código do produto do olho direito na OS
                    If intControle = 1 Then
                        strSQL = "cod_produto = " & intCodigo & " where num_pedido = " & os.num_pedido & " and id_filial = " & os.id_filial & " and item = 1"
                        objExtra.atualiza_registros("pedido_balcao_itens", strSQL, True)
                    End If

                    abrir_saida()
                    If txtCodBarraOE.Enabled = False Then
                        MessageBox.Show("Baixa concluída com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        os.editar()
                        os.cod_tab_od = objExtra.retornaCodigoTabela(prod.fldCod_produto)
                        os.cod_produto_od = prod.fldCod_produto
                        os.cod_fase = Fases_os.Estoque_Aguardando_Impressão
                        os.Salvar()
                        inserir_fila(os.cod_os, os.id_filial)
                        Me.Close()
                    End If
                Else
fim:
                    If MessageBox.Show("Produto não confere com produto da OS, deseja fazer a baixa assim mesmo?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        If objExtra.verifica_permissao_usuario(intUsuario, 56) = True Then
                            intControle = 1
                            GoTo SAIDA_OD
                        Else
                            MessageBox.Show("Usuário não tem permissão de acesso para realizar" & Chr(13) & "troca de prtodutos diferentes em uma sáida extra.", "ERROR: 56", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If
                    End If
                    txtCodBarraOD.Text = ""
                    Exit Sub
                End If
        End Select
    End Sub
    Private Sub txtCodbarraOE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodBarraOE.KeyDown
        Dim q As Integer = -1
        Dim f As New frmConsultaProdDiop
        Dim eS As Char
        Dim hist_and As String
        intControle = 0
        Select Case e.KeyCode
            Case Keys.Enter
                If txtCodBarraOE.Text = "" Then
                    eS = prod.Retorna_especie_Tabela(txtCodOE.Text)
                    If eS = "L" Then
                        f.tipo = "L"
                        f.cod_prod = txtCodOE.Text
                        f.ShowDialog(Me)
                        If f.Result = True Then
                            GoTo SAIDA_OE
                        Else
                            GoTo fim
                        End If
                    Else
                        f.tipo = "B"
                        f.cod_prod = txtCodOE.Text
                        f.ShowDialog(Me)
                        If f.Result = True Then
                            GoTo SAIDA_OE
                        Else
                            GoTo fim
                        End If
                    End If
                End If
                If prod.Retorna_cod_prod(txtCodBarraOE.Text) = txtCodOE.Text Then
SAIDA_OE:
                    Dim intCodigo As Integer
                    If intControle = 0 Then
                        If prod.saldo_estoque_local(txtCodOE.Text, conf.Filial) >= 1 Then
                            'Caso haja saldo, vai para baixa
                            GoTo baixa
                        Else
                            MessageBox.Show("Saldo insuficiente.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtCodBarraOE.Text = ""

                            Exit Sub
                        End If
                    Else
                        intCodigo = prod.Retorna_cod_prod(txtCodBarraOE.Text)
                        If prod.saldo_estoque_local(intCodigo, conf.Filial) >= 1 Then
                            'Caso haja saldo, vai para baixa
                            GoTo baixa
                        Else
                            MessageBox.Show("Saldo insuficiente.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtCodBarraOE.Text = ""
                            Exit Sub
                        End If
                    End If
baixa:

                    If intControle = 0 Then
                        prod.Source("Select * from produtos where cod_produto = " & txtCodOE.Text & "")
                    Else
                        prod.Source("Select * from produtos where cod_produto = " & intCodigo & "")
                    End If

                    mov.novo()
                    'Se houver troca e o produto não foi perdido,
                    'não será uma saída extra, e sim uma saída normal.
                    If sExtra.troca_Produto_oe = "S" And sExtra.oe = "N" Then
                        mov.item = mov.ret_ultimo_item(saida_os.cod_movimento)
                        mov.cod_movimento = saida_os.cod_movimento
                        mov.historico = "Saída do olho esquerdo da OS. " & sExtra.id_filial_os
                        hist_and = "Baixa do Olho Esquerdo"
                    Else
                        mov.item = mov.ret_ultimo_item(sExtra.cod_movimento)
                        mov.cod_movimento = sExtra.cod_movimento
                        mov.historico = "Saída Extra do olho esquerdo da OS. " & sExtra.id_filial_os & "-" & sExtra.cod_os
                        If intControle = 0 Then
                            hist_and = "Saída Extra do Olho esquerdo."
                        Else
                            Dim fTexto As New frmObs
                            fTexto.ShowDialog()
                            hist_and = fTexto.txtTexto.Text
                            fTexto.Dispose()
                            'hist_and = "Devido falta na industria da " & txtPoe.Text & " tivemos que efetuar troca de produto por " & prod.fldProduto
                        End If
                    End If
                    mov.cod_produto = prod.fldCod_produto
                    mov.quant = q
                    mov.desconto = 0
                    mov.pUnit = prod.fldPreco_custo
                    mov.Pvenda = 0
                    mov.descVenda = 0
                    If intControle = 0 Then
                        mov.estoqueFis = mov.ret_saldo_fisico(os.cod_produto_oe) + CDbl(q)
                    Else
                        mov.estoqueFis = mov.ret_saldo_fisico(prod.fldCod_produto) + CDbl(q)
                    End If
                    If intControle = 0 Then
                        mov.estoqueFin = mov.ret_saldo_fin(os.cod_produto_oe) + ((prod.fldPreco_custo) * q)
                    Else
                        mov.estoqueFin = mov.ret_saldo_fin(prod.fldCod_produto) + ((prod.fldPreco_custo) * q)
                    End If
                    mov.Salvar()
                    som_ok()
                    txtCodBarraOE.Enabled = False
                    os.editar()
                    os.cod_fase = Fases_os.Estoque_Aguardando_Processamento
                    os.Salvar()
                    sExtra.editar()
                    sExtra.oe_ok = "S"
                    sExtra.Salvar()
                    andamentos.insere_andamento(objAndamentos.tipo.Baixa_os, os.id_filial,
                    os.cod_os, UserID, hist_and)

                    'Atualiza o código do produto do olho esquerdo na OS
                    If intControle = 1 Then
                        strSQL = "cod_produto = " & intCodigo & " where num_pedido = " & os.num_pedido & " and id_filial = " & os.id_filial & " and item = 2"
                        objExtra.atualiza_registros("pedido_balcao_itens", strSQL, True)
                    End If

                    abrir_saida()
                    If txtCodBarraOD.Enabled = False Then
                        MessageBox.Show("Baixa concluída com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        os.editar()
                        os.cod_tab_oe = objExtra.retornaCodigoTabela(prod.fldCod_produto)
                        os.cod_produto_oe = prod.fldCod_produto
                        os.cod_fase = Fases_os.Estoque_Aguardando_Impressão
                        os.Salvar()
                        inserir_fila(os.cod_os, os.id_filial)
                        Me.Close()
                    End If
                Else
fim:
                    If MessageBox.Show("Produto não confere com produto da OS, deseja fazer a baixa assim mesmo?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        If objExtra.verifica_permissao_usuario(intUsuario, 56) = True Then
                            intControle = 1
                            GoTo SAIDA_OE
                        Else
                            MessageBox.Show("Usuário não tem permissão de acesso para realizar" & Chr(13) & "troca de prtodutos diferentes em uma sáida extra.", "ERROR: 56", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If
                    End If
                    txtCodBarraOE.Text = ""
                    Exit Sub
                End If
        End Select

    End Sub
    Private Sub inserir_fila(ByVal x_os As Integer, ByVal x_filial As Integer)
        Dim f As New objFilaImpressao
        sExtra.conclui_movimento()
        If saida_os.max > 0 Then saida_os.conclui_movimento()
        MessageBox.Show("Na fila para impressão:" & vbCrLf & f.Inserir_fila(x_os, x_filial, "S", conf.Filial), "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub novos_produtos()
        Dim f As New frmOS
        Dim r As String
        If os.data_verificacao <> Nothing Then
            r = os.desverifica_os
            If r.Substring(0, 2) = "ER" Then
                MessageBox.Show(r, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        f.tipo_acao = frmOS.ACAO.TROCA_PRODUTO
        f.n_OS = os.cod_os
        f.Filial = os.id_filial
        f.novo = False
        f.ShowDialog(Me)
        sExtra.editar()
        sExtra.npod = f.lblCodPOD.Text
        sExtra.npoe = f.lblCodPOE.Text
        MsgBox(sExtra.Salvar())
        abrir_saida()
    End Sub
    Private Sub txtCodOD_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodOD.KeyDown
        If sExtra.troca_Produto_od = "S" Then
            novos_produtos()
        End If
    End Sub
    Private Sub nova_devolucao()
        dev.novo()
        dev.id_filial = conf.Filial
        dev.id_filial_os = sExtra.id_filial_os
        dev.cod_os = sExtra.cod_os
        dev.data = d.hora
        dev.id_usuario = UserID
        dev.Salvar()
    End Sub
    Private Sub conclui_Devolucao()
        If txtBarraDevOD.Enabled = False And txtBarraDevOE.Enabled = False Then
            AVISO(dev.conclui_movimento(), Me, frmAviso.tipo_aviso.tipo_ok)
        End If
    End Sub
    Private Sub txtBarraDevOD_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBarraDevOD.KeyDown
        Dim f As New frmConsultaProdDiop
        Dim es As String 'Espécie
        Select Case e.KeyCode
            Case Keys.Enter
                If txtBarraDevOD.Text = "" Then
                    'se não for informado o código de barras, abre tela para confirmação
                    'dos dados do produto
                    es = prod.Retorna_especie_Tabela(txtCodDevOD.Text)
                    If es = "L" Then
                        f.tipo = "L"
                        f.cod_prod = txtCodDevOD.Text
                        f.ShowDialog(Me)
                        If f.Result = True Then
                            GoTo entrada_od
                        Else
                            GoTo FIM
                        End If
                    Else
                        f.tipo = "B"
                        f.cod_prod = txtCodDevOD.Text
                        f.ShowDialog(Me)
                        If f.Result = True Then
                            GoTo entrada_od
                        Else
                            GoTo fim
                        End If
                    End If
                End If
                If prod.Retorna_cod_prod(txtBarraDevOD.Text) <> txtCodDevOD.Text Then
                    MsgBox(prod.Retorna_cod_prod(txtBarraDevOD.Text) & " " & txtCodDevOD.Text)
                    MessageBox.Show("Código de barras não correnponde ao produto.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtBarraDevOD.Text = Nothing
                    Exit Sub
                Else
                    GoTo entrada_od
                End If
fim:
                MessageBox.Show("Produto informado não corresponde ao produto da OS.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
entrada_od:
                'Avalia de há devoluções não concluídas para essa OS.
                dev.filtrar(sExtra.cod_os, sExtra.id_filial_os, "N")
                If dev.max = 0 Then
                    'Caso não haja devoluções não concluídas, insere uma nova devolução.
                    nova_devolucao()
                End If
                'inere movimento de entrada da peça.
                prod.filtra(txtCodDevOD.Text)
                mov.novo()
                mov.item = mov.ret_ultimo_item(dev.cod_movimento)
                mov.cod_movimento = dev.cod_movimento
                mov.cod_produto = prod.fldCod_produto
                mov.quant = 1
                mov.desconto = 0
                mov.pUnit = prod.fldPreco_custo
                mov.Pvenda = 0
                mov.descVenda = 0
                mov.estoqueFis = mov.ret_saldo_fisico(os.cod_produto_od) + CDbl(1)
                mov.estoqueFin = mov.ret_saldo_fin(os.cod_produto_od) + ((prod.fldPreco_custo) * 1)
                mov.historico = "Devolução para estoque olho direito da devolução " & dev.cod_devolucao_os & _
                " da OS. " & dev.id_filial_os & "-" & dev.cod_os
                mov.Salvar()
                sExtra.editar()
                sExtra.dev_od = "S"
                sExtra.Salvar()
                txtBarraDevOD.Enabled = False
                andamentos.insere_andamento(objAndamentos.tipo.devolucao_estoque, dev.id_filial, dev.cod_os, UserID, _
                "Devolução para estoque olho direito da devolução " & dev.cod_devolucao_os)
                conclui_Devolucao()
                abrir_saida()
        End Select

    End Sub
    Private Sub txtBarraDevOE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBarraDevOE.KeyDown
        Dim f As New frmConsultaProdDiop
        Dim es As String 'Espécie
        Select Case e.KeyCode
            Case Keys.Enter
                If txtBarraDevOE.Text = "" Then
                    'se não for informado o código de barras, abre tela para confirmação
                    'dos dados do produto
                    es = prod.Retorna_especie_Tabela(txtCodDevOE.Text)
                    If es = "L" Then
                        f.tipo = "L"
                        f.cod_prod = txtCodDevOE.Text
                        f.ShowDialog(Me)
                        If f.Result = True Then
                            GoTo entrada_oe
                        Else
                            GoTo FIM
                        End If
                    Else
                        f.tipo = "B"
                        f.cod_prod = txtCodDevOE.Text
                        f.ShowDialog(Me)
                        If f.Result = True Then
                            GoTo entrada_oe
                        Else
                            GoTo fim
                        End If
                    End If
                End If
                If prod.Retorna_cod_prod(txtBarraDevOE.Text) <> txtCodDevOE.Text Then
                    MsgBox(prod.Retorna_cod_prod(txtBarraDevOE.Text) & " " & txtCodDevOE.Text)
                    MessageBox.Show("Código de barras não correnponde ao produto.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtBarraDevOE.Text = Nothing
                    Exit Sub
                Else
                    GoTo entrada_oe
                End If
fim:
                MessageBox.Show("Produto informado não corresponde ao produto da OS.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
entrada_oe:
                'Avalia de há devoluções não concluídas para essa OS.
                dev.filtrar(sExtra.cod_os, sExtra.id_filial_os, "N")
                If dev.max = 0 Then
                    'Caso não haja devoluções não concluídas, insere uma nova devolução.
                    nova_devolucao()
                End If
                'inere movimento de entrada da peça.
                prod.filtra(txtCodDevOE.Text)
                mov.novo()
                mov.item = mov.ret_ultimo_item(dev.cod_movimento)
                mov.cod_movimento = dev.cod_movimento
                mov.cod_produto = prod.fldCod_produto
                mov.quant = 1
                mov.desconto = 0
                mov.pUnit = prod.fldPreco_custo
                mov.Pvenda = 0
                mov.descVenda = 0
                mov.estoqueFis = mov.ret_saldo_fisico(os.cod_produto_od) + CDbl(1)
                mov.estoqueFin = mov.ret_saldo_fin(os.cod_produto_od) + ((prod.fldPreco_custo) * 1)
                mov.historico = "Devolução para estoque olho direito da devolução " & dev.cod_devolucao_os & _
                " da OS. " & dev.id_filial_os & "-" & dev.cod_os
                mov.Salvar()
                sExtra.editar()
                sExtra.dev_oe = "S"
                sExtra.Salvar()
                txtBarraDevOE.Enabled = False
                andamentos.insere_andamento(objAndamentos.tipo.devolucao_estoque, dev.id_filial, dev.cod_os, UserID, _
                "Devolução para estoque olho direito da devolução " & dev.cod_devolucao_os)
                conclui_Devolucao()
                abrir_saida()
        End Select
    End Sub
End Class
