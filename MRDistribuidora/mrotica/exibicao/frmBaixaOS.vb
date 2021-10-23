Imports mrotica_util
Public Class frmBaixaOS
#Region "Variáveis"
    Dim Prod As New produtoClass
    Dim pedido As New objPedidoBalcao
    Dim d As New dados
    Dim OS As ObjOS
    Dim mov As New objMovimentoDetalhe
    Dim tb_reserva As New DataTable
    Dim saida As New objSaidaOS
    Dim andamentos As New objAndamentos
    Dim objBaixaOS As New objMaster
    Dim conf As New config
    Dim producao As New objEntradaProducao
    Dim diop As New dioptriaBlocoSurf
    Dim intAutorizado As Int16
    Dim intUsuario As Integer
    Dim usuario As New objUsuario
    Dim Override_Prod As Boolean = False
#End Region
    Dim tbItens As New DataTable
    Private Sub itensTB()
        tbItens.Columns.Add("cod_produto", GetType(Integer))
        tbItens.Columns.Add("Produto", GetType(String))
        tbItens.Columns.Add("Item", GetType(Integer))
        tbItens.Columns.Add("Quant", GetType(Integer))
        tbItens.TableName = "Itens"
    End Sub
    Private Sub itenssaida()
        tb_lista = saida.lista_itens
        carrega_itens(tb_lista)
    End Sub
    Private Sub carrega_itens(t As DataTable)
        tbItens.Rows.Clear()
        For Each r As DataRow In t.Rows
            Dim nr As DataRow
            nr = tbItens.NewRow
            nr("cod_produto") = r("cod_produto")
            nr("produto") = Prod.Retorna_nome_prod(r("cod_produto"))
            nr("Item") = r("item")
            nr("quant") = r("quant")
            tbItens.Rows.Add(nr)
        Next
        Dim TStb As New DataGridTableStyle
        grdSaiu.DataSource = tbItens
        grdSaiu.Refresh()
        TStb.MappingName = tbItens.TableName

        Dim item As New DataGridTextBoxColumn
        With item
            .MappingName = "Item"
            .HeaderText = "Item"
            .Width = 30
        End With
        TStb.GridColumnStyles.Add(item)

        Dim cod As New DataGridTextBoxColumn
        With cod
            .MappingName = "cod_produto"
            .HeaderText = "Cod."
            .Width = 30
        End With
        TStb.GridColumnStyles.Add(cod)


        Dim produto As New DataGridTextBoxColumn
        With produto
            .MappingName = "Produto"
            .HeaderText = "Produto"
            .Width = 250

        End With
        TStb.GridColumnStyles.Add(produto)
        Dim q As New DataGridTextBoxColumn
        With q
            .MappingName = "quant"
            .HeaderText = "Quant."


        End With
        TStb.GridColumnStyles.Add(q)

        grdSaiu.TableStyles.Clear()
        grdSaiu.TableStyles.Add(TStb)

    End Sub
    Private Sub frmBaixaOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        intUsuario = objBaixaOS.retorna_codigo_usuario(frmMain.intCodigoUsuario)
        Dim sql As String
        itensTB()
        sql = "Delete from reserva_lente_os"
        d.Comando(sql, False)
        sql = "Delete from reserva_lente_pedido"
        d.Comando(sql, False)
        If OS.cod_fase = 21 Then
            MessageBox.Show("OS cancelada, não e possivel dar baixa.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            Exit Sub
        End If
        If OS.max = 0 Then
            MessageBox.Show("OS não encontrada.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            Exit Sub
        End If
        If OS.num_pedido <> Nothing Then
            pedido.Source("select * from pedido_balcao " & _
            "where num_pedido = " & OS.num_pedido & "")
        End If
        If OS.cod_tipo_os = 2 Then
            producao.carrega_producao(OS.num_pedido, OS.id_filial)
        End If
        saida_os()
    End Sub
    Public Sub saida_os()
        Dim tb_lista As DataTable
        saida.carrega_saida_os(OS.cod_os, conf.Filial, OS.id_filial)
        If saida.max > 0 Then
            If saida.concluido = "S" Then
                MessageBox.Show("Já foi dado saída nessa OS, verifique se o movimento não" & Chr(13) & "é uma saída extra ou troca de Base/Produto!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                btnBaixa.Enabled = True
            End If
            itenssaida()
            tb_lista = saida.lista_itens
            If tb_lista.Rows.Count = 0 Then Exit Sub
            'Compara se os produtos da OS são iguais
            If OS.cod_produto_od = OS.cod_produto_oe Then
                If OS.cod_produto_od = tb_lista.Rows(0)("cod_produto") Then
                    'caso os produtos sejam iguais, não deixa dar baixa
                    txtBarraOD.Enabled = False
                End If
                If tb_lista.Rows.Count > 1 Then
                    If OS.cod_produto_oe = tb_lista.Rows(1)("cod_produto") Then
                        txtBarraOE.Enabled = False
                    End If
                End If
            Else
                If tb_lista.Rows.Count = 1 Then
                    If OS.cod_produto_od = tb_lista.Rows(0)("cod_produto") Then
                        txtBarraOD.Enabled = False
                    End If
                    If OS.cod_produto_oe = tb_lista.Rows(0)("cod_produto") Then
                        txtBarraOE.Enabled = False
                    End If
                Else
                    If OS.cod_produto_od = tb_lista.Rows(0)("cod_produto") Or OS.cod_produto_od = tb_lista.Rows(1)("cod_produto") Then
                        txtBarraOD.Enabled = False
                    End If
                    If OS.cod_produto_oe = tb_lista.Rows(0)("cod_produto") Or OS.cod_produto_oe = tb_lista.Rows(1)("cod_produto") Then
                        txtBarraOE.Enabled = False
                    End If

                End If
            End If
        Else
            saida.novo()
            saida.cod_movimento = retorna_Chave("cod_movimento", "movimentomaster", " where id_filial = " & conf.Filial & "")
            saida.cod_saida_os = retorna_Chave("cod_saida_os", "saida_os", " where cod_movimento = " & saida.cod_movimento & " and id_filial = " & conf.Filial & "")
            saida.cod_natureza = 2
            saida.cod_os = OS.cod_os
            saida.id_filial_os = OS.id_filial
            saida.data = Now
            saida.doc = "OS.: " & OS.id_filial & " - " & OS.cod_os
            saida.id_usuario = intUsuario
            MsgBox(saida.Salvar())
        End If
    End Sub
    Public Sub carrega_os(ByVal x_os As Integer, ByVal x_filial As Integer)
        OS = New ObjOS(x_os, x_filial)
        If (OS.cod_tab_od = 1 And OS.cod_tab_oe = 1) Then
            GoTo final
        End If
        If (OS.cod_tab_od = 2 And OS.cod_tab_oe = 2) Then
            GoTo final
        End If
        If (OS.cod_tab_od = 3 And OS.cod_tab_oe = 3) Then
            GoTo final
        End If
        If (OS.cod_tab_od = 1 And OS.cod_tab_oe = 2) Then
            GoTo final
        End If
        If (OS.cod_tab_od = 2 And OS.cod_tab_oe = 1) Then
            GoTo final
        End If
        carrega_produtos()
        Exit Sub
final:
        pedido.atualiza_status_pedido(status_pedido.Processado_no_estoque)
        AVISO("Baixa Concluída!", Me, frmAviso.tipo_aviso.tipo_ok)
        andamentos.insere_andamento(objAndamentos.tipo.aviso_os, OS.id_filial, OS.cod_os, intUsuario, "OS de adaptação!")
        OS.editar()
        OS.cod_fase = Fases_os.Estoque_Aguardando_Impressão
        OS.Salvar()
        inserir_fila(OS.cod_os, OS.id_filial)
        Me.Close()

    End Sub
    Private Sub carrega_produtos()
        lblProdEstOD.Text = Prod.Retorna_nome_prod(OS.cod_produto_od)
        lblProdTabelaOD.Text = Prod.Retorna_nome_Tabela(OS.cod_produto_od)
        lblProdEstOE.Text = Prod.Retorna_nome_prod(OS.cod_produto_oe)
        lblProdTabelaOE.Text = Prod.Retorna_nome_Tabela(OS.cod_produto_oe)
    End Sub
    Private Sub txtBarraOD_KeyDown_old(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim q As Integer = -1
        Dim f As New frmConsultaProdDiop
        Dim eS As String
        Dim tipo As String = ""
        Select Case e.KeyCode
            Case Keys.Enter
                If txtBarraOD.Text = "" Then
                    tipo = "Manual"
                    eS = Prod.Retorna_especie_Tabela(OS.cod_produto_od).Trim
                    If eS = "L" Then
                        f.tipo = "L"
                        f.cod_prod = OS.cod_produto_od
                        f.ShowDialog(Me)
                        If f.Result = True Then
                            GoTo SAIDA_OD
                        Else
                            GoTo fim
                        End If
                    ElseIf eS = "B" Then
                        f.tipo = "B"
                        f.cod_prod = OS.cod_produto_od
                        f.ShowDialog(Me)
                        If f.Result = True Then
                            GoTo SAIDA_OD
                        Else
                            GoTo fim
                        End If
                    Else
                        f.tipo = "BS"
                        f.cod_prod = OS.cod_produto_od
                        f.ShowDialog(Me)
                        If f.Result = True Then
                            GoTo SAIDA_OD
                        Else
                            GoTo fim
                        End If
                    End If
                End If
                If Prod.Retorna_cod_prod(txtBarraOD.Text) = OS.cod_produto_od Then
                    tipo = "Barra"
SAIDA_OD:
                    If OS.cod_tab_od = 1 Or OS.cod_tab_od = 2 Then
                        GoTo final
                    End If
                    If OS.retorna_id_reserva_pend(OS.cod_produto_od) = 0 Then 'Verifica se
                        'há uma reserva para o produto, se a resposta for zero, verifica
                        'se há estoque, caso haja, baixa do estoque, caso contrário, exibe
                        'mensagem de saldo insuficiente.
                        If Prod.saldo_estoque_local(OS.cod_produto_od, conf.Filial) >= 1 Then
                            'Caso haja saldo, vai para baixa
                            GoTo baixa
                        Else
                            MessageBox.Show("Saldo insuficiente!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtBarraOD.Text = ""
                        End If
                    Else
baixa:
                        baixa_reserva(OS.retorna_id_reserva_pend(OS.cod_produto_od), OS.id_filial, OS.cod_os, OS.cod_produto_od)
                        cancela_sugestao(OS.cod_produto_od)
                        Prod.Source("Select * from produtos where cod_produto = " & OS.cod_produto_od & "")
                        mov.novo()
                        mov.item = mov.ret_ultimo_item(saida.cod_movimento)
                        mov.cod_movimento = saida.cod_movimento
                        mov.cod_produto = Prod.fldCod_produto
                        mov.quant = q
                        mov.desconto = 0
                        mov.pUnit = Prod.fldPreco_custo
                        mov.Pvenda = Prod.fldPreco_venda
                        mov.descVenda = Prod.fldDesconto
                        mov.estoqueFis = mov.ret_saldo_fisico(OS.cod_produto_od) + CDbl(q)
                        mov.estoqueFin = mov.ret_saldo_fin(OS.cod_produto_od) + ((Prod.fldPreco_custo) * q)
                        mov.historico = "Baixa do olho direito da OS. " & OS.id_filial & "-" & OS.cod_os & " | " & tipo

                        If mov.Salvar().StartsWith("OK") Then
                            If OS.cod_tipo_os = 2 Then
                                Entra_OD()
                            End If
                        End If
                        som_ok()
                        txtBarraOD.Enabled = False
                        OS.editar()
                        OS.cod_fase = Fases_os.Estoque_Aguardando_Processamento
                        OS.Salvar()
                        If intAutorizado = 1 Then
                            andamentos.insere_andamento(objAndamentos.tipo.Baixa_os, OS.id_filial,
                            OS.cod_os, intUsuario, "Baixa de Lente do Olho Direito " & tipo)
                        Else
                            andamentos.insere_andamento(objAndamentos.tipo.Baixa_os, OS.id_filial,
                            OS.cod_os, intUsuario, "Nova Baixa de Lente do Olho Direito " & tipo)
                        End If
final:
                        If txtBarraOE.Enabled = False Then
                            pedido.atualiza_status_pedido(status_pedido.Processado_no_estoque)
                            MessageBox.Show("Baixa concluída com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            OS.editar()
                            OS.cod_fase = Fases_os.Estoque_Aguardando_Impressão
                            OS.Salvar()
                            inserir_fila(OS.cod_os, OS.id_filial)
                            Me.Close()
                        End If
                    End If
                Else
fim:
                    If Prod.Retorna_cod_prod(txtBarraOD.Text) = 0 Then
                        MessageBox.Show("Código de Barras não encontrado!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Produto não confere com produto da OS!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    txtBarraOD.Text = ""
                    Exit Sub
                End If
        End Select
    End Sub
    Private Sub txtBarraOE_KeyDown_old(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim q As Integer = -1 'Quatidade de itens saindo
        Dim f As New frmConsultaProdDiop
        Dim eS As String
        Dim tipo As String
        Select Case e.KeyCode
            Case Keys.Enter
                'Caso não seja informado o código de barras
                'abre formulário para informar detalhes da
                'lente.
                If txtBarraOE.Text = "" Then
                    tipo = "Manual"
                    'Verifica o tipo de produto
                    eS = Prod.Retorna_especie_Tabela(OS.cod_produto_oe).Trim
                    'Se o produto for Lente pronta, abre o formulário 
                    'de lente.
                    If eS = "L" Then
                        f.tipo = "L"
                        'Informa o código do produto para o formulário
                        'avaliar se a dioptria informada bate com o 
                        'produto da os.
                        f.cod_prod = OS.cod_produto_oe
                        f.ShowDialog(Me)
                        'Se a avaliação do produto for positiva,
                        'processa a saida do estoque, caso contrário,
                        'vai para o label Fim.
                        If f.Result = True Then
                            GoTo SAIDA_OE
                        Else
                            GoTo FIM
                        End If
                    ElseIf (eS = "B") Then
                        'Se o produto for bloco, abre o formulário 
                        'de bloco.
                        f.tipo = "B"
                        'Informa o código do produto para o formulário
                        'avaliar se a dioptria informada bate com o 
                        'produto da os.
                        f.cod_prod = OS.cod_produto_oe
                        f.ShowDialog(Me)
                        'Se a avaliação do produto for positiva,
                        'processa a saida do estoque, caso contrário,
                        'vai para o label Fim.
                        If f.Result = True Then
                            GoTo SAIDA_OE
                        Else
                            GoTo FIM
                        End If
                    Else
                        'Se o produto for bloco surfacado, abre o formulário 
                        'de bloco surfacado.
                        f.tipo = "BS"
                        'Informa o código do produto para o formulário
                        'avaliar se a dioptria informada bate com o 
                        'produto da os.
                        f.cod_prod = OS.cod_produto_oe
                        f.ShowDialog(Me)
                        'Se a avaliação do produto for positiva,
                        'processa a saida do estoque, caso contrário,
                        'vai para o label Fim.
                        If f.Result = True Then
                            GoTo SAIDA_OE
                        Else
                            GoTo FIM
                        End If
                    End If
                End If
                'Caso seja informado o código de barras do produto, 
                'avalia se o produto é o mesmo da OS.
                If Prod.Retorna_cod_prod(txtBarraOE.Text) = OS.cod_produto_oe Then
                    tipo = "Barra"
SAIDA_OE:
                    If OS.retorna_id_reserva_pend(OS.cod_produto_oe) = 0 Then 'Verifica se
                        'há uma reserva para o produto, se a resposta for zero, verifica
                        'se há estoque, caso haja, baixa do estoque, caso contrário, exibe
                        'mensagem de saldo insuficiente.
                        If OS.cod_tab_oe = 1 Or OS.cod_tab_oe = 2 Then
                            GoTo final
                        End If
                        If Prod.saldo_estoque_local(OS.cod_produto_oe, conf.Filial) >= 1 Then
                            GoTo baixa
                        Else
                            MessageBox.Show("Saldo insuficiente!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtBarraOE.Text = ""
                        End If
                    Else
baixa:
                        baixa_reserva(OS.retorna_id_reserva_pend(OS.cod_produto_oe), OS.id_filial, OS.cod_os, OS.cod_produto_oe)
                        cancela_sugestao(OS.cod_produto_oe)
                        Prod.Source("Select * from produtos where cod_produto = " & OS.cod_produto_oe & "")
                        mov.novo()
                        mov.item = mov.ret_ultimo_item(saida.cod_movimento)
                        mov.cod_movimento = saida.cod_movimento
                        mov.cod_produto = Prod.fldCod_produto
                        mov.quant = q
                        mov.desconto = 0
                        mov.Pvenda = Prod.fldPreco_venda
                        mov.descVenda = Prod.fldDesconto
                        mov.pUnit = Prod.fldPreco_custo
                        mov.estoqueFis = mov.ret_saldo_fisico(OS.cod_produto_oe) + CDbl(q)
                        mov.estoqueFin = mov.estoqueFis * Prod.fldPreco_custo
                        mov.historico = "Baixa do olho esquerdo da OS. " & OS.id_filial & "-" & OS.cod_os & " | " & tipo
                        If mov.Salvar().StartsWith("OK") Then
                            If OS.cod_tipo_os = 2 Then
                                Entra_OE()
                            End If
                        End If
                        som_ok()
                        txtBarraOE.Enabled = False
                        OS.editar()
                        OS.cod_fase = Fases_os.Estoque_Aguardando_Processamento
                        OS.Salvar()
                        If intAutorizado = 1 Then
                            andamentos.insere_andamento(objAndamentos.tipo.Baixa_os, OS.id_filial,
                            OS.cod_os, intUsuario, "Baixa de Lente do Olho Esquerdo " & tipo)
                        Else
                            andamentos.insere_andamento(objAndamentos.tipo.Baixa_os, OS.id_filial,
                            OS.cod_os, intUsuario, "Nova Baixa de Lente do Olho Esquerdo " & tipo)
                        End If
final:
                        If txtBarraOD.Enabled = False Then
                            pedido.atualiza_status_pedido(status_pedido.Processado_no_estoque)
                            MessageBox.Show("Baixa concluída com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            OS.editar()
                            OS.cod_fase = Fases_os.Estoque_Aguardando_Impressão
                            OS.Salvar()
                            inserir_fila(OS.cod_os, OS.id_filial)
                            Me.Close()
                        End If
                    End If
                Else
FIM:
                    If txtBarraOE.Text <> "" Then
                        If Prod.Retorna_cod_prod(txtBarraOE.Text) = 0 Then
                            MessageBox.Show("Código de Barras não encontrado!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Else
                        MessageBox.Show("Produto não confere com produto da OS!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    txtBarraOE.Text = ""
                    Exit Sub
                End If
        End Select
    End Sub
    Private Sub txtBarraOD_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBarraOD.KeyDown
        Dim q As Integer = -1
        Dim eS As Char
        Dim cod_prod As Long


        Select Case e.KeyCode
            Case Keys.Enter
                If txtBarraOD.Text = "" Then
                    If Override_Prod = False Then
                        eS = Prod.retorna_especie(OS.produto_od_estoque)
                        Dim f As New frmConsultaProdDiop
                        If eS = "L" Then
                            f.tipo = "L"
                            f.cod_prod = OS.produto_od_estoque
                            f.ShowDialog(Me)
                            If f.Result = True Then
                                cod_prod = OS.produto_od_estoque
                                GoTo SAIDA_OD
                            Else
                                GoTo fim
                            End If
                        Else
                            f.tipo = "B"
                            f.cod_prod = OS.produto_od_estoque
                            f.ShowDialog(Me)
                            If f.Result = True Then
                                cod_prod = OS.produto_od_estoque
                                GoTo SAIDA_OD
                            Else
                                GoTo fim
                            End If
                        End If
                    Else
                        eS = InputBox("Digite L para lente e B para bloco:")
                        Dim f As New frmConsultaProdDiopCod
                        If eS = "L" Then
                            f.tipo = "L"
                            f.ShowDialog(Me)
                            cod_prod = f.Result
                            GoTo SAIDA_OD

                        Else
                            f.tipo = "B"

                            f.ShowDialog(Me)
                            cod_prod = f.Result
                        End If
                    End If
                Else
                    Prod.filtraBarras(txtBarraOD.Text)
                    cod_prod = Prod.fldCod_produto
                End If
                Prod.filtra(cod_prod)
                If cod_prod <> OS.produto_od_estoque And Override_Prod = False Then
                    som_erro()
                    AVISO("Produto não confere com produto da OS!", Me, frmAviso.tipo_aviso.tipo_ok)
                    txtBarraOD.Text = ""
                    Exit Sub

                Else

SAIDA_OD:
                    If OS.cod_tab_od = 1 Or OS.cod_tab_od = 2 Then
                        GoTo final
                    End If
                    If OS.retorna_id_reserva_pend(OS.produto_od_estoque) = 0 Then 'Verifica se
                        'há uma reserva para o produto, se a resposta for zero, verifica
                        'se há estoque, caso haja, baixa do estoque, caso contrário, exibe
                        'mensagem de saldo insuficiente.
                        If Prod.saldo_estoque_local(cod_prod, conf.Filial) >= 1 Then
                            'Caso haja saldo, vai para baixa
                            GoTo baixa
                        Else
                            som_erro()
                            AVISO("Saldo insuficiente!", Me, frmAviso.tipo_aviso.tipo_ok)
                            txtBarraOD.Text = ""
                        End If
                    Else
baixa:
                        baixa_reserva(OS.retorna_id_reserva_pend(cod_prod), OS.id_filial, OS.cod_os, cod_prod)
                        Prod.Source("Select * from produtos where cod_produto = " & cod_prod & "")
                        mov.novo()
                        mov.item = mov.ret_ultimo_item(saida.cod_movimento)
                        mov.cod_movimento = saida.cod_movimento
                        mov.cod_produto = Prod.fldCod_produto
                        mov.quant = q
                        mov.desconto = 0
                        mov.pUnit = Prod.fldPreco_custo
                        mov.Pvenda = Prod.fldPreco_venda
                        mov.descVenda = Prod.fldDesconto
                        mov.estoqueFis = mov.ret_saldo_fisico(cod_prod) + CDbl(q)
                        mov.estoqueFin = mov.ret_saldo_fin(cod_prod) + ((Prod.fldPreco_custo) * q)
                        mov.historico = "Baixa do olho direito da OS. " & OS.id_filial & "-" & OS.cod_os & "Override: " & Override_Prod.ToString
                        'mov.Data = Now
                        mov.Salvar()
                        som_ok()
                        txtBarraOD.Enabled = False
                        OS.editar()
                        OS.cod_fase = Fases_os.Estoque_Aguardando_Processamento
                        OS.Salvar()
                        andamentos.insere_andamento(objAndamentos.tipo.Baixa_os, OS.id_filial,
                        OS.cod_os, UserID, "Baixa de Lente do Olho Direito" & " OV: " & Override_Prod.ToString)

final:
                        If txtBarraOE.Enabled = False Then
                            concluir()
                        End If
                    End If
fim:
                    itenssaida()
                End If
        End Select
    End Sub
    Private Sub txtBarraOE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBarraOE.KeyDown
        Dim q As Integer = -1
        Dim eS As Char
        Dim cod_prod As Long


        Select Case e.KeyCode
            Case Keys.Enter
                If txtBarraOE.Text = "" Then
                    If Override_Prod = False Then
                        eS = Prod.retorna_especie(OS.produto_oe_estoque)
                        Dim f As New frmConsultaProdDiop
                        If eS = "L" Then
                            f.tipo = "L"
                            f.cod_prod = OS.produto_oe_estoque
                            f.ShowDialog(Me)
                            If f.Result = True Then
                                cod_prod = OS.produto_oe_estoque
                                GoTo SAIDA_OE
                            Else
                                GoTo fim
                            End If
                        Else
                            f.tipo = "B"
                            f.cod_prod = OS.produto_oe_estoque
                            f.ShowDialog(Me)
                            If f.Result = True Then
                                cod_prod = OS.produto_oe_estoque
                                GoTo SAIDA_OE
                            Else
                                GoTo fim
                            End If
                        End If
                    Else
                        eS = InputBox("Digite L para lente e B para bloco:")
                        Dim f As New frmConsultaProdDiopCod
                        If eS = "L" Then
                            f.tipo = "L"
                            f.ShowDialog(Me)
                            cod_prod = f.Result
                            GoTo SAIDA_OE

                        Else
                            f.tipo = "B"
                            f.ShowDialog(Me)
                            cod_prod = f.Result
                            GoTo SAIDA_OE
                        End If
                    End If
                Else
                    Prod.filtraBarras(txtBarraOE.Text)
                    cod_prod = Prod.fldCod_produto
                End If
                Prod.filtra(cod_prod)
                If cod_prod <> OS.produto_oe_estoque And Override_Prod = False Then
                    som_erro()
                    AVISO("Produto não confere com produto da OS!", Me, frmAviso.tipo_aviso.tipo_ok)
                    txtBarraOE.Text = ""
                    Exit Sub
                Else

SAIDA_OE:
                    If OS.cod_tab_oe = 1 Or OS.cod_tab_oe = 2 Then
                        GoTo final
                    End If
                    If OS.retorna_id_reserva_pend(cod_prod) = 0 Then 'Verifica se
                        'há uma reserva para o produto, se a resposta for zero, verifica
                        'se há estoque, caso haja, baixa do estoque, caso contrário, exibe
                        'mensagem de saldo insuficiente.
                        If Prod.saldo_estoque_local(cod_prod, conf.Filial) >= 1 Then
                            'Caso haja saldo, vai para baixa
                            GoTo baixa
                        Else
                            som_erro()
                            AVISO("Saldo insuficiente!", Me, frmAviso.tipo_aviso.tipo_ok)
                            txtBarraOE.Text = ""
                        End If
                    Else
baixa:
                        baixa_reserva(OS.retorna_id_reserva_pend(cod_prod), OS.id_filial, OS.cod_os, cod_prod)
                        Prod.Source("Select * from produtos where cod_produto = " & cod_prod & "")
                        mov.novo()
                        mov.item = mov.ret_ultimo_item(saida.cod_movimento)
                        mov.cod_movimento = saida.cod_movimento
                        mov.cod_produto = Prod.fldCod_produto
                        mov.quant = q
                        mov.desconto = 0
                        mov.pUnit = Prod.fldPreco_custo
                        mov.Pvenda = Prod.fldPreco_venda
                        mov.descVenda = Prod.fldDesconto
                        mov.estoqueFis = mov.ret_saldo_fisico(cod_prod) + CDbl(q)
                        mov.estoqueFin = mov.ret_saldo_fin(cod_prod) + ((Prod.fldPreco_custo) * q)
                        mov.historico = "Baixa do olho direito da OS. " & OS.id_filial & "-" & OS.cod_os & "Override: " & Override_Prod.ToString
                        'mov.Data = Now
                        mov.Salvar()
                        som_ok()
                        txtBarraOE.Enabled = False
                        OS.editar()
                        OS.cod_fase = Fases_os.Estoque_Aguardando_Processamento
                        OS.Salvar()
                        andamentos.insere_andamento(objAndamentos.tipo.Baixa_os, OS.id_filial,
                        OS.cod_os, UserID, "Baixa de Lente do Olho Direito" & " OV: " & Override_Prod.ToString)
final:
                        If txtBarraOD.Enabled = False Then
                            concluir()
                        End If
                    End If
fim:

                End If
        End Select
    End Sub
    Private Sub baixa_reserva(ByVal id_reserva As Integer, ByVal id_filial As Integer, ByVal cod_os As Integer, ByVal cod_prod As Integer)
        Dim sql As String
        sql = "update reserva_lente_os set id_status_reserva = 1, data_baixa = " &
        d.pdtm(Now.ToString) & " where " &
        " id_reserva = " & id_reserva & " and id_filial = " & id_filial &
        " and cod_os = " & cod_os & ""
        d.Comando(sql, True)
        If OS.num_pedido <> Nothing Then
            Dim tbItens As New DataTable
            sql = "Select * from pedido_balcao_itens where " &
            " num_pedido = " & OS.num_pedido & " and id_filial = " &
            conf.Filial & " and cod_produto = " & cod_prod & " and " &
            " (cod_status_item = 2 or cod_status_item = 1)"
            d.carrega_Tabela(sql, tbItens)
            If tbItens.Rows.Count > 0 Then
                baixa_reserva_pedido(tbItens.Rows(0)("num_pedido"), tbItens.Rows(0)("id_filial"), tbItens.Rows(0)("item"))
            End If
        End If
    End Sub
    Private Sub baixa_reserva_pedido(ByVal x_npedido As Integer, ByVal x_id_filial As Integer, ByVal x_item As Integer)
        Dim sql As String
        sql = "Update pedido_balcao_itens set cod_status_item = 3 " &
        " where num_pedido = " & x_npedido & " and id_filial = " &
        x_id_filial & " and item = " & x_item & ""
        d.Comando(sql, True)
    End Sub
    Private Sub inserir_fila(ByVal x_os, ByVal x_filial)
        Dim f As New objFilaImpressao
        saida.conclui_movimento()
        If OS.cod_tipo_os = 2 Then
            producao.conclui_movimento()
        End If
        MessageBox.Show("Na fila para impressão:" & vbCrLf & f.Inserir_fila(x_os, x_filial, conf.Filial), "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' AVISO("Na fila para impressão:" & vbCrLf & f.Inserir_fila(x_os, x_filial, conf.Filial), Me, frmAviso.tipo_aviso.tipo_ok)
    End Sub
    Private Sub cancela_sugestao(ByVal x_cod_prod As Integer)
        Dim tsql As String
        tsql = "Update top 1 sugestao_pedido_auto set cod_status = 5 " &
        " where cod_produto = " & x_cod_prod & " and cod_os = " &
        OS.cod_os & " and id_filial = " & OS.id_filial & ""
        d.Comando(tsql, True)
    End Sub
    Private Function Entra_OD() As String
        diop.base = OS.base_od
        diop.adicao = OS.adicao_od
        diop.esferico = OS.esf_od_longe
        diop.cilindrico = OS.cil_od_longe
        diop.olho = "D"
        Return producao.insere_item_nota(OS.cod_produto_od, 1, diop)
    End Function
    Private Function Entra_OE() As String
        diop.base = OS.base_oe
        diop.adicao = OS.adicao_oe
        diop.esferico = OS.esf_oe_longe
        diop.cilindrico = OS.cil_oe_longe
        diop.olho = "E"
        Return producao.insere_item_nota(OS.cod_produto_oe, 1, diop)
    End Function

    Private Sub btnBaixa_Click(sender As System.Object, e As System.EventArgs) Handles btnBaixa.Click
        If MessageBox.Show("Deseja realmente realizar a baixa do produto novamente?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            intAutorizado = 1
            txtBarraOD.Enabled = True
            txtBarraOE.Enabled = True

            saida.novo()
            saida.cod_movimento = retorna_Chave("cod_movimento", "movimentomaster", " where id_filial = " & conf.Filial & "")
            saida.cod_saida_os = retorna_Chave("cod_saida_os", "saida_os", " where cod_movimento = " & saida.cod_movimento & " and id_filial = " & conf.Filial & "")
            saida.cod_natureza = 2
            saida.cod_os = OS.cod_os
            saida.id_filial_os = OS.id_filial
            saida.data = Now
            saida.doc = "OS.: " & OS.id_filial & " - " & OS.cod_os
            saida.id_usuario = intUsuario
            saida.Salvar()
            btnBaixa.Enabled = False
        End If
    End Sub

    Private Sub btnSair_Click(sender As System.Object, e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub btnConcluir_Click(sender As Object, e As EventArgs) Handles btnConcluir.Click
        If Override_Prod = True Then
            concluir()
        End If
    End Sub
    Private Sub concluir()
        AVISO("Baixa Concluída!", Me, frmAviso.tipo_aviso.tipo_ok)
        OS.editar()
        OS.cod_fase = Fases_os.Estoque_Aguardando_Impressão
        OS.Salvar()
        inserir_fila(OS.cod_os, OS.id_filial)
        If OS.cod_cliente < 40 Then
            ana_maria_baixado(OS.doc_cliente, OS.cod_cliente)
        End If

        Me.Close()
    End Sub
    Private Sub chkProdDif_CheckedChanged(sender As Object, e As EventArgs) Handles chkProdDif.CheckedChanged
        If chkProdDif.Checked = True Then
            If usuario.acesso(intUsuario, 59) = True Then
                Override_Prod = True
            Else
                MsgBox("Usuário não tem permissão!")
                chkProdDif.Checked = False
            End If
        End If
    End Sub
End Class