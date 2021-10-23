Imports mrotica_util
Public Class frmCancelaOS
    Dim d As New dados
    Dim OS As ObjOS
    Dim conf As New config
    Dim saidaOS As New objSaidaOS
    Dim canc As New objCancelOS
    Dim sql As String
    Dim credito As New objCreditoCliente
    Dim pedido_balcao As New objPedidoBalcao
    Dim dev As New objDevolucaoEstoqueOS
    Dim mov As New objMovimentoDetalhe
    Dim user As New objUsuario
    Dim tb_lista As New DataTable
    Dim prod As New produtoClass
    Dim v As New DataView
    Dim valor_cancelamento As Double
    Dim andamentos As New objAndamentos
    Dim acesso As New objMaster

    Private Sub btnOKOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOKOS.Click
        intUsuario = acesso.retorna_codigo_usuario(frmMain.intCodigoUsuario)

        If txtdescricao.Text = "" Then
            MessageBox.Show("É necessário informar o motivo do cancelamento!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtdescricao.Enabled = True
            txtdescricao.Focus()
            Exit Sub
        End If

        If acesso.filtraSaidaOS(OS.cod_os, OS.id_filial, "N") = True Then
            MessageBox.Show("Existe uma saida de OS em aberto, conclua a baixa para fazer o cancelamento!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            Exit Sub
        End If

        If acesso.filtraSaidaOS(OS.cod_os, OS.id_filial, "S") = True Then
            If acesso.verifica_permissao_usuario(intUsuario, 24) = False Then
                MessageBox.Show("Usuário não tem permissão para fazer cancelamento com devolução!", "ERROR: 24", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Exit Sub
            End If
        End If

        If acesso.existe_saida_os(OS.cod_os, conf.Filial, OS.id_filial) = False Then
            'Procedimento 25 Cancelamento de OS sem devolução
            If acesso.verifica_permissao_usuario(intUsuario, 25) = False Then
                MessageBox.Show("Usuário não tem permissão para fazer cancelamento sem devolução!", "ERROR: 25", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Exit Sub
            End If
        End If

        If MessageBox.Show("Deseja continuar o cancelamento da OS informada?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            canc = New objCancelOS(OS.id_filial, OS.cod_os)
            If canc.max = 0 Then
                canc.novo()
                canc.id_filial = OS.id_filial
                canc.cod_os = OS.cod_os
                canc.data = Now.Date
                canc.cod_usuario = intUsuario
                canc.descricao = txtdescricao.Text
                canc.concluido = "N"
                canc.valor_cancelado = 0
                canc.Salvar()
                If acesso.filtraSaidaOS(OS.cod_os, OS.id_filial, "S") = True Then
                    'Procedimento 
                    dev.novo()
                    dev.id_filial = conf.Filial
                    dev.id_filial_os = OS.id_filial
                    dev.cod_os = OS.cod_os
                    dev.doc = "Cancelamento de OS: " & canc.id_filial & "-" & canc.cod_devolucao_os
                    dev.id_usuario = intUsuario
                    dev.Salvar()
                End If
                canc.editar()
                canc.cod_devolucao_os = dev.cod_devolucao_os
                canc.Salvar()
            Else
                If canc.concluido = "S" Then
                    AVISO("Este cancelamento já foi concluído!", Me, frmAviso.tipo_aviso.tipo_ok, True)
                    Me.Close()
                    Exit Sub
                End If
                txtdescricao.Text = canc.descricao
                canc.editar()
                canc.id_filial = OS.id_filial
                canc.cod_os = OS.cod_os
                canc.data = Now.Date
                canc.cod_usuario = user.cod_usuario
                canc.concluido = "N"
                canc.Salvar()
            End If

            If saidaOS.existe_saida_os(OS.cod_os, conf.Filial, OS.id_filial) = False Then
                AVISO("Não houve saída dessa OS, não é necessário fazer devolução de lentes!", Me, frmAviso.tipo_aviso.tipo_ok)
                grpDevolve.Enabled = False
                conclui_cancela()
            Else
                saidaOS.carrega_saida_os(OS.cod_os, conf.Filial, OS.id_filial)
                tb_lista = saidaOS.lista_itens
                'MsgBox(tb_lista.Rows.Count)
                If tb_lista.Rows.Count = 0 Then Exit Sub
                'Compara se os produtos da OS são iguais

                Dim i As Integer
                For i = 0 To tb_lista.Rows.Count - 1

                    If OS.cod_produto_od = OS.cod_produto_oe Then
                        If OS.cod_produto_od = tb_lista.Rows(i)("cod_produto") Then
                            'caso os produtos sejam iguais, não deixa dar baixa
                            txtCodBarraOD.Enabled = True
                        End If
                        If tb_lista.Rows.Count > 1 Then
                            If OS.cod_produto_oe = tb_lista.Rows(i)("cod_produto") Then
                                txtCodBarraOE.Enabled = True
                            End If
                        End If
                    Else
                        If tb_lista.Rows.Count = 1 Then
                            If OS.cod_produto_od = tb_lista.Rows(i)("cod_produto") Then
                                txtCodBarraOD.Enabled = True
                            End If
                            If OS.cod_produto_oe = tb_lista.Rows(i)("cod_produto") Then
                                txtCodBarraOE.Enabled = True
                            End If
                        Else
                            If OS.cod_produto_od = tb_lista.Rows(i)("cod_produto") Or OS.cod_produto_od = tb_lista.Rows(i)("cod_produto") Then 'ultimo 1
                                txtCodBarraOD.Enabled = True
                            End If
                            If OS.cod_produto_oe = tb_lista.Rows(i)("cod_produto") Or OS.cod_produto_oe = tb_lista.Rows(i)("cod_produto") Then ' ultimo 1
                                txtCodBarraOE.Enabled = True
                            End If
                        End If
                    End If

                Next
                ''fim
            End If
            abre_dev()
            prod.filtra(OS.cod_produto_od)
            lblPOD.Text = prod.fldProduto
            If OS.cod_tab_od < 2 Then
                txtCodBarraOD.Enabled = False
            End If

            prod.filtra(OS.cod_produto_oe)
            lblPOE.Text = prod.fldProduto
            If OS.cod_tab_oe < 2 Then
                txtCodBarraOE.Enabled = False
            End If
        Else
            MessageBox.Show("Operação cancelada com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub abre_dev()
        dev = New objDevolucaoEstoqueOS(OS.cod_os, OS.id_filial)
        tb_lista = dev.lista_itens
        If tb_lista.Rows.Count = 0 Then Exit Sub
        'Compara se os produtos da OS são iguais
        If OS.cod_produto_od = OS.cod_produto_oe Then
            If OS.cod_produto_od = tb_lista.Rows(0)("cod_produto") Then
                'caso os produtos sejam iguais, não deixa dar baixa
                txtCodBarraOD.Enabled = False
            End If
            If tb_lista.Rows.Count > 1 Then
                If OS.cod_produto_oe = tb_lista.Rows(1)("cod_produto") Then
                    txtCodBarraOE.Enabled = False
                End If
            End If
        Else
            If tb_lista.Rows.Count = 1 Then
                If OS.cod_produto_od = tb_lista.Rows(0)("cod_produto") Then
                    txtCodBarraOD.Enabled = False
                End If
                If OS.cod_produto_oe = tb_lista.Rows(0)("cod_produto") Then
                    txtCodBarraOE.Enabled = False
                End If
            Else
                If OS.cod_produto_od = tb_lista.Rows(0)("cod_produto") Or OS.cod_produto_od = tb_lista.Rows(1)("cod_produto") Then
                    txtCodBarraOD.Enabled = False
                End If
                If OS.cod_produto_oe = tb_lista.Rows(0)("cod_produto") Or OS.cod_produto_oe = tb_lista.Rows(1)("cod_produto") Then
                    txtCodBarraOE.Enabled = False
                End If
            End If
        End If
    End Sub
    Private Sub txtCodbarraOD_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodBarraOD.KeyDown
        Dim f As New frmConsultaProdDiop
        Dim es As String 'Espécie
        Select Case e.KeyCode
            Case Keys.Enter
                If txtCodBarraOD.Text = "" Then
                    'se não for informado o código de barras, abre tela para confirmação
                    'dos dados do produto
                    es = prod.Retorna_especie_Tabela(OS.cod_produto_od)
                    If es = "L" Then
                        f.tipo = "L"
                        f.cod_prod = OS.cod_produto_od
                        f.ShowDialog(Me)
                        If f.Result = True Then
                            GoTo entrada_od
                        Else
                            GoTo fim
                        End If
                    ElseIf es = "B" Then
                        f.tipo = "B"
                        f.cod_prod = OS.cod_produto_od
                        f.ShowDialog(Me)
                        If f.Result = True Then
                            GoTo entrada_od
                        Else
                            GoTo fim
                        End If
                    ElseIf es = "BS" Then
                        f.tipo = "BS"
                        f.cod_prod = OS.cod_produto_od
                        f.ShowDialog(Me)
                        If f.Result = True Then
                            GoTo entrada_od
                        Else
                            GoTo fim
                        End If
                    End If
                End If
                If prod.Retorna_cod_prod(txtCodBarraOD.Text) <> OS.cod_produto_od Then
                    MsgBox(prod.Retorna_cod_prod(txtCodBarraOD.Text) & " " & OS.cod_produto_od)
                    Dim r As frmAviso.respo
                    r = AVISO("Código de barras não correnponde ao produto!", Me, frmAviso.tipo_aviso.tipo_ok, True)
                    txtCodBarraOD.Text = Nothing
                    Exit Sub
                Else
                    GoTo entrada_od
                End If
fim:
                AVISO("Produto informado não corresponde ao produto da OS.", Me, frmAviso.tipo_aviso.tipo_ok, True)
                Exit Sub
entrada_od:
                'Avalia de há devoluções não concluídas para essa OS.
                dev.filtrar(OS.cod_os, OS.id_filial, "N")
                If dev.max = 0 Then
                    'Caso não haja devoluções não concluídas, insere uma nova devolução.
                End If
                'inere movimento de entrada da peça.
                prod.filtra(OS.cod_produto_od)
                mov.novo()
                mov.item = mov.ret_ultimo_item(dev.cod_movimento)
                mov.cod_movimento = dev.cod_movimento
                mov.cod_produto = prod.fldCod_produto
                mov.quant = 1
                mov.desconto = 0
                mov.pUnit = prod.fldPreco_custo
                mov.Pvenda = 0
                mov.descVenda = 0
                mov.estoqueFis = mov.ret_saldo_fisico(OS.cod_produto_od) + CDbl(1)
                mov.estoqueFin = mov.ret_saldo_fin(OS.cod_produto_od) + ((prod.fldPreco_custo) * 1)
                mov.historico = "Devolução para estoque olho direito da devolução " & dev.cod_devolucao_os &
                " da OS. " & dev.id_filial_os & "-" & dev.cod_os
                mov.Salvar()
                txtCodBarraOD.Enabled = False
                andamentos.insere_andamento(objAndamentos.tipo.devolucao_estoque, dev.id_filial, dev.cod_os, UserID,
                "Devolução para estoque olho direito da devolução " & dev.cod_devolucao_os)
                conclui_Devolucao()
                txtCodBarraOE.Focus()
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
                    es = prod.Retorna_especie_Tabela(OS.cod_produto_oe)
                    If es = "L" Then
                        f.tipo = "L"
                        f.cod_prod = OS.cod_produto_oe
                        f.ShowDialog(Me)
                        If f.Result = True Then
                            GoTo entrada_oe
                        Else
                            GoTo fim
                        End If
                    ElseIf es = "B" Then
                        f.tipo = "B"
                        f.cod_prod = OS.cod_produto_oe
                        f.ShowDialog(Me)
                        If f.Result = True Then
                            GoTo entrada_oe
                        Else
                            GoTo fim
                        End If
                    ElseIf es = "BS" Then
                        f.tipo = "BS"
                        f.cod_prod = OS.cod_produto_oe
                        f.ShowDialog(Me)
                        If f.Result = True Then
                            GoTo entrada_oe
                        Else
                            GoTo fim
                        End If
                    End If
                End If
                If prod.Retorna_cod_prod(txtCodBarraOE.Text) <> OS.cod_produto_oe Then
                    MsgBox(prod.Retorna_cod_prod(txtCodBarraOE.Text) & " " & OS.cod_produto_oe)
                    Dim r As frmAviso.respo
                    r = AVISO("Código de barras não correnponde ao produto!", Me, frmAviso.tipo_aviso.tipo_ok, True)
                    txtCodBarraOE.Text = Nothing
                    Exit Sub
                Else
                    GoTo entrada_oe
                End If
fim:
                AVISO("Produto informado não corresponde ao produto da OS.", Me, frmAviso.tipo_aviso.tipo_ok, True)
                Exit Sub
entrada_oe:
                'Avalia de há devoluções não concluídas para essa OS.
                dev.filtrar(OS.cod_os, OS.id_filial, "N")
                If dev.max = 0 Then
                    'Caso não haja devoluções não concluídas, insere uma nova devolução.
                End If
                'inere movimento de entrada da peça.
                prod.filtra(OS.cod_produto_oe)
                mov.novo()
                mov.item = mov.ret_ultimo_item(dev.cod_movimento)
                mov.cod_movimento = dev.cod_movimento
                mov.cod_produto = prod.fldCod_produto
                mov.quant = 1
                mov.desconto = 0
                mov.pUnit = prod.fldPreco_custo
                mov.Pvenda = 0
                mov.descVenda = 0
                mov.estoqueFis = mov.ret_saldo_fisico(OS.cod_produto_oe) + CDbl(1)
                mov.estoqueFin = mov.ret_saldo_fin(OS.cod_produto_oe) + ((prod.fldPreco_custo) * 1)
                mov.historico = "Devolução para estoque olho esquerdo da devolução " & dev.cod_devolucao_os &
                " da OS. " & dev.id_filial_os & "-" & dev.cod_os
                mov.Salvar()
                txtCodBarraOE.Enabled = False
                andamentos.insere_andamento(objAndamentos.tipo.devolucao_estoque, dev.id_filial, dev.cod_os, UserID,
                "Devolução para estoque olho esquerdo da devolução " & dev.cod_devolucao_os)
                conclui_Devolucao()
        End Select

    End Sub
    Private Sub conclui_Devolucao()
        If txtCodBarraOD.Enabled = False And txtCodBarraOE.Enabled = False Then
            AVISO(dev.conclui_movimento(), Me, frmAviso.tipo_aviso.tipo_ok)
            Pedido(True)
            Me.Close()
        End If
    End Sub
    Private Sub conclui_cancela()
        Pedido(False)
        Me.Close()
    End Sub
    Private Sub Pedido(ByVal Devolucao As Boolean)
        Dim rpt As New rptCancOSrpx
        Dim f As New frmRpt
        Dim valor_credito As Double
        Dim fat_apagar As Double = 0
        Dim fatura As New objFatura
        Dim lista_servicos As String
        Dim lista_devolucao As String
        pedido_balcao.carrega_pedido(OS.num_pedido, conf.Filial)
        valor_cancelamento = pedido_balcao.total_itens + pedido_balcao.total_servicos
        lista_servicos = preenche_lista_servicos(pedido_balcao.lista_servicos(pedido_balcao.num_pedido, pedido_balcao.id_filial))
        fatura.abrir_fatura(pedido_balcao.fatura(1), pedido_balcao.fatura(0))
        fat_apagar = fatura.a_pagar
        If Devolucao = True Then
            pedido_balcao.cancelamento_itens()
            lista_devolucao = preenche_lista_devolucao(dev.lista_itens, Devolucao)
            pedido_balcao.cancela_servicos()
            txtDesc.Text = "Cancelamento Nº " & canc.cod_cancelamento_os & vbCrLf &
            " Motivo: " & txtdescricao.Text & vbCrLf &
            " OS: " & adiciona_zeros(OS.id_filial, 3) & adiciona_zeros(OS.cod_os, 6) &
            " Num. Pedido: " & OS.num_pedido & " Usuário: " & frmMain.intCodigoUsuario & vbCrLf &
            " PRODUTOS " & vbCrLf &
            " OD: " & prod.Retorna_nome_prod(OS.cod_produto_od) & vbCrLf &
            " OE: " & prod.Retorna_nome_prod(OS.cod_produto_oe) & vbCrLf &
            " PRODUTOS DEVOLVIDOS: " &
            lista_devolucao & vbCrLf &
            " SERVIÇOS CANCELADOS: " &
            lista_servicos
        Else
            lista_devolucao = preenche_lista_devolucao(pedido_balcao.lista_itens(pedido_balcao.num_pedido, pedido_balcao.id_filial, False), Devolucao)
            pedido_balcao.cancelamento_itens()
            pedido_balcao.cancela_servicos()
            txtDesc.Text = "Cancelamento Nº " & canc.cod_cancelamento_os & vbCrLf &
            " Motivo: " & txtdescricao.Text & vbCrLf &
            " OS: " & adiciona_zeros(OS.id_filial, 3) & adiciona_zeros(OS.cod_os, 6) &
            " Num. Pedido: " & OS.num_pedido & " Usuário: " & frmMain.intCodigoUsuario & vbCrLf &
            " PRODUTOS " & vbCrLf &
            " OD: " & prod.Retorna_nome_prod(OS.cod_produto_od) & vbCrLf &
            " OE: " & prod.Retorna_nome_prod(OS.cod_produto_oe) & vbCrLf &
            " PRODUTOS CANCELADOS: " &
            lista_devolucao & vbCrLf &
            " SERVIÇOS CANCELADOS: " &
            lista_servicos
        End If
        If pedido_balcao.faturado Then
            Dim res As String = ""
            If fat_apagar < valor_cancelamento Then
                valor_credito = valor_cancelamento - fat_apagar
                If valor_credito < 0 Then
                    valor_credito = valor_cancelamento
                End If
                res = credito.credito_cancelamento(conf.Filial, valor_credito, OS.cod_filial_cliente,
                OS.cod_cliente, "Crédito Ref. Cancelamento da OS " & OS.id_filial &
                "-" & OS.cod_os & vbCrLf & txtDesc.Text)
                If res.StartsWith("OK") Then
                    'fatura.insere_acrescimo(valor_credito, 3, "Ajuste Ref. Cancelamento da OS " & OS.id_filial & _
                    ' "-" & OS.cod_os)
                End If
                txtDesc.Text = txtDesc.Text & vbCrLf & res
            End If
        End If

        pedido_balcao.editar()
        pedido_balcao.cod_status_pedido = 4
        pedido_balcao.Salvar()
        OS.editar()
        OS.cod_fase = Fases_os.Cancelada
        OS.Salvar()
        andamentos.insere_andamento(objAndamentos.tipo.aviso_os, OS.id_filial, OS.cod_os, user.cod_usuario, "OS Cancelada!")
        canc.editar()
        canc.descricao = txtDesc.Text
        canc.valor_cancelado = valor_cancelamento
        canc.Salvar()
        canc.concluir()
        rpt.txtRTF = txtDesc.Text
        f.Relat(rpt)
        f.ShowDialog(Me)
    End Sub
    Private Function preenche_lista_servicos(ByVal tb As DataTable) As String
        Dim i, m As Integer
        Dim str As String = ""
        i = 0
        m = tb.Rows.Count
        While i < m
            str = str & vbCrLf & i + 1 & "-" & tb.Rows(i)("produto") & " Quant.: " & tb.Rows(i)("quant") & " Cancelado"
            i = i + 1
        End While
        Return str
    End Function
    Private Function preenche_lista_devolucao(ByVal tb As DataTable, ByVal devolucao As Boolean) As String
        Dim i, m As Integer
        Dim str As String = ""
        Dim dev As String
        If devolucao = True Then
            dev = " devolvido"
        Else
            dev = " cancelado"
        End If
        i = 0
        m = tb.Rows.Count
        While i < m
            str = str & vbCrLf & i + 1 & "-" & prod.Retorna_nome_prod(tb.Rows(i)("cod_produto")) & " Quant.: " & tb.Rows(i)("quant") & dev & "!"
            i = i + 1
        End While
        Return str
    End Function

    Private Sub frmCancelaOS_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtFilial.Text = conf.Filial
    End Sub

    Private Sub frmCancelaOS_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtOS_Leave(sender As System.Object, e As System.EventArgs) Handles txtOS.Leave
        Dim intFilial As Integer = CInt(txtFilial.Text)
        If txtOS.Text <> String.Empty Then
            OS = New ObjOS(txtOS.Text, intFilial)
            If OS.max = 0 Then
                MessageBox.Show("Não foi possível localizar a OS informada!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtOS.Focus()
                btnOKOS.Enabled = False
                btnSair.Enabled = False
                txtdescricao.Enabled = False
                Exit Sub
            Else
                btnOKOS.Enabled = True
                btnSair.Enabled = True
                txtdescricao.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnSair_Click(sender As System.Object, e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub txtOS_Enter(sender As System.Object, e As System.EventArgs) Handles txtOS.Enter
        txtOS.SelectAll()
    End Sub

    Private Sub txtOS_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtOS.KeyPress
        If Not Char.IsNumber(e.KeyChar) And (Not e.KeyChar = vbBack) Then
            e.Handled = True
            MessageBox.Show("Neste campo só é permitido números.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
