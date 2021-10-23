Imports mrotica_util
Public Class frmBaixaPedido
#Region "Variáveis"
    Dim prod As New produtoClass
    Dim mov As New objMovimentoDetalhe
    Dim pedido As New objPedidoBalcao
    Dim cliente As New objCliente
    Dim tb_pedido As New DataTable
    Dim tb_itens As New DataTable
    Dim tb_reserva As New DataTable
    Dim d As New dados
    Dim aberto As Boolean = False
    Dim saida As New objSaidaPedido
    Dim i As Integer = 0
    Dim tb_lista As DataTable
    Dim conf As New config
#End Region

    Private Sub frmBaixaPedido_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        encerra_baixa()

    End Sub
    Private Sub frmBaixaPedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        saida_pedido()
        aberto = True
    End Sub
    Public Sub carrega_pedido(ByVal x_num_pedido As Integer, ByVal x_id_filial As Integer)
        pedido.Source("Select * from pedido_balcao where num_pedido = " & x_num_pedido & _
        " and id_filial = " & x_id_filial)
        If tem_os(x_num_pedido, x_id_filial) = True Then
            MsgBox("Este pedido corresponde a uma OS, sua baixa deve ser efetuada no " & _
            "módulo de baixas de OS.", MsgBoxStyle.Exclamation)
            Me.Close()
            Exit Sub
        End If
        If pedido.max > 0 Then
            lblNpedido.Text = pedido.num_pedido
            lblFilial.Text = pedido.id_filial
            dtData.Value = pedido.data_pedido
            Me.cerrega_cliente(pedido.cod_cliente, pedido.cod_filial_cliente)
            carrega_itens(x_num_pedido, x_id_filial)
        End If
    End Sub
    Public Sub saida_pedido()
        If pedido.max = 0 Then Exit Sub
        If saida.existe_saida_pedido(pedido.num_pedido, pedido.id_filial) = True Then
            saida.carrega_saida_pedido(pedido.num_pedido, pedido.id_filial)
            atualiza_lista_baixas()
            If tb_lista.Rows.Count = 0 Then Exit Sub
        Else
            saida.novo()
            saida.cod_movimento = retorna_Chave("cod_movimento", "movimentomaster", " where id_filial = " & conf.Filial & "")
            saida.cod_saida_pedido = retorna_Chave("cod_saida_os", "saida_os", " where cod_movimento = " & saida.cod_movimento & " and id_filial = " & conf.Filial & "") + 1
            saida.cod_natureza = 2
            saida.id_filial = pedido.id_filial
            saida.num_pedido = pedido.num_pedido
            saida.data = Now.ToString
            saida.doc = "Pedido.: " & pedido.id_filial & " - " & pedido.num_pedido
            saida.id_usuario = UserID
            saida.Salvar()
        End If
    End Sub
    Public Sub cerrega_cliente(ByVal x_cod_cliente As Integer, ByVal x_cod_filial_cliente As Integer)
        cliente.Source("Select * from cliente where cod_filial_cliente = " & x_cod_filial_cliente &
        " and cod_cliente = " & x_cod_cliente & "")
        cliente.primeiro()
        txtCliente.Text = cliente.nome_cliente
    End Sub
    Private Sub carrega_itens(ByVal x_num_pedido As Integer, ByVal x_id_filial As Integer)
        tb_itens = pedido.lista_itens(x_num_pedido, x_id_filial, chkBaixados.Checked)
        formata_grid_itens()
    End Sub
    Private Sub carrega_reservas(ByVal cod_prod As Integer)
        Dim sql As String
        sql = "SELECT produtos.produto, status_reserva.Status_reserva, " &
        "reserva_lente_pedido.data_reserva FROM reserva_lente_pedido INNER JOIN " &
        "produtos ON reserva_lente_pedido.cod_produto = produtos.cod_produto INNER JOIN " &
        "status_reserva ON reserva_lente_pedido.id_status_reserva = " &
        "status_reserva.id_status_reserva WHERE " &
        "(reserva_lente_pedido.id_filial = " & pedido.id_filial & ") AND " &
        "(reserva_lente_pedido.num_pedido =" & pedido.num_pedido & ") AND " &
        "(reserva_lente_pedido.cod_produto =" & cod_prod & ")"
        d.carrega_Tabela(sql, tb_reserva)
        formata_grid_Reserva()
        atualiza_lista_baixas()
    End Sub
    Private Sub formata_grid_itens()
        Dim TStb As New DataGridTableStyle
        grdProd.DataSource = tb_itens
        TStb.MappingName = grdProd.DataSource.tablename
        Dim cItem As New DataGridTextBoxColumn
        With cItem
            .MappingName = "item"
            .HeaderText = " "
            .Width = 20
        End With
        TStb.GridColumnStyles.Add(cItem)

        Dim cProd As New DataGridTextBoxColumn
        With cProd
            .MappingName = "Produto"
            .HeaderText = "Produto"
            .Width = 320
        End With
        TStb.GridColumnStyles.Add(cProd)

        Dim cQuant As New DataGridTextBoxColumn
        With cQuant
            .MappingName = "quant"
            .HeaderText = "Q."
            .Width = 20
        End With
        TStb.GridColumnStyles.Add(cQuant)

        Dim cDesc As New DataGridTextBoxColumn
        With cDesc
            .MappingName = "desconto"
            .HeaderText = "Desc."
            .Format = "#,##0.00 "
            .Alignment = HorizontalAlignment.Right
            .Width = 33
        End With
        TStb.GridColumnStyles.Add(cDesc)

        Dim cPreco As New DataGridTextBoxColumn
        With cPreco
            .MappingName = "preco"
            .HeaderText = "P. Unit."
            .Format = "#,##0.00 "
            .Alignment = HorizontalAlignment.Right
        End With
        TStb.GridColumnStyles.Add(cPreco)

        Dim cTotal As New DataGridTextBoxColumn
        With cTotal
            .MappingName = "Total"
            .HeaderText = "Total."
            .Format = "#,##0.00 "
            .Alignment = HorizontalAlignment.Right
        End With
        TStb.GridColumnStyles.Add(cTotal)

        Dim cStatus_item As New DataGridTextBoxColumn
        With cStatus_item
            .MappingName = "status_item"
            .HeaderText = "Status"
            .Width = 150
        End With
        TStb.GridColumnStyles.Add(cStatus_item)

        grdProd.TableStyles.Clear()
        grdProd.TableStyles.Add(TStb)
        grdProd_CurrentCellChanged(Me, Nothing)

    End Sub
    Private Sub grdProd_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdProd.CurrentCellChanged
        Dim sql As String
        If tb_itens.Rows.Count = 0 Then Exit Sub
        Dim status As Integer
        Dim resp As Integer
        Try
            i = grdProd.CurrentRowIndex
            grdProd.Focus()
            prod.Source("Select * from produtos where cod_produto = " & tb_itens.Rows(i)("cod_produto") & "")
            carrega_reservas(prod.fldCod_produto)
            txti.Text = tb_itens.Rows(i)("item")
            lblQReq.Text = tb_itens.Rows(i)("quant")
        Catch ex As Exception

        End Try
        If aberto = True And (tb_itens.Rows(i)("cod_status_item") = 2 Or tb_itens.Rows(i)("cod_status_item") = 1 Or tb_itens.Rows(i)("cod_status_item") = 6) Then
            resp = vbYes
            If resp = vbYes Then
                grdProd.Enabled = False
                grpBaixa.Enabled = True
                txtBarra.Focus()
                aberto = False
            End If
        End If
        'aberto = True
    End Sub
    Private Sub formata_grid_Reserva()
        Dim TStb As New DataGridTableStyle
        grdReserva.DataSource = tb_reserva
        TStb.MappingName = grdReserva.DataSource.tablename

        Dim cProd As New DataGridTextBoxColumn
        With cProd
            .MappingName = "Produto"
            .HeaderText = "Produto"
            .Width = 320
        End With
        TStb.GridColumnStyles.Add(cProd)

        Dim cStatus_item As New DataGridTextBoxColumn
        With cStatus_item
            .MappingName = "status_reserva"
            .HeaderText = "Status"
            .Width = 150
        End With
        TStb.GridColumnStyles.Add(cStatus_item)
        grdReserva.TableStyles.Clear()
        grdReserva.TableStyles.Add(TStb)
    End Sub
    Private Sub txtBarra_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBarra.KeyDown
        Dim es As String
        Dim q As Integer = -1
        Dim f As New frmConsultaProdDiop
        Select Case e.KeyCode
            Case Keys.Enter
                Select Case e.KeyCode
                    Case Keys.Enter
                        If txtBarra.Text = "" Then
                            es = prod.Retorna_especie_Tabela(prod.fldCod_produto)
                            If es = "L" Then
                                f.tipo = "L"
                                f.cod_prod = prod.fldCod_produto
                                f.ShowDialog(Me)
                                If f.Result = True Then
                                    GoTo SAIDA
                                Else
                                    GoTo FIM
                                End If
                            ElseIf es = "B" Then
                                f.tipo = "B"
                                f.cod_prod = prod.fldCod_produto
                                f.ShowDialog(Me)
                                If f.Result = True Then
                                    GoTo SAIDA
                                Else
                                    GoTo FIM
                                End If
                            ElseIf es = "BS" Then
                                f.tipo = "BS"
                                f.cod_prod = prod.fldCod_produto
                                f.ShowDialog(Me)
                                If f.Result = True Then
                                    GoTo SAIDA
                                Else
                                    GoTo FIM
                                End If
                            ElseIf es = "LC" Then
                                f.tipo = "LC"
                                f.cod_prod = prod.fldCod_produto
                                f.ShowDialog(Me)
                                If f.Result = True Then
                                    GoTo SAIDA
                                Else
                                    GoTo FIM
                                End If
                            End If
                        End If
                        If prod.Retorna_cod_prod(txtBarra.Text) = prod.fldCod_produto Then
SAIDA:
                            Try
                                If CDbl(lblQReq.Text) <= CDbl(lblQAtendida.Text) Then
                                    If tb_itens.Rows(i)("quant") <> lblQAtendida.Text Then
                                        'MsgBox(lblQReq.Text & _
                                        'vbCrLf & " <= " & lblQAtendida.Text & " Quant " & tb_itens.Rows(i)("quant"))
                                        Exit Sub
                                    End If
                                    baixa_reserva_pedido(pedido.num_pedido, pedido.id_filial, txti.Text)
                                    grdProd.Enabled = True
                                    grpBaixa.Enabled = False
                                    aberto = True
                                    lblQAtendida.Text = 0
                                    atualiza_lista_baixas()
                                    carrega_itens(pedido.num_pedido, pedido.id_filial)
                                    encerra_baixa()
                                    Exit Sub
                                End If
                            Catch ex As Exception
                                MsgBox(ex.ToString)
                                Exit Sub
                            End Try
                            If pedido.retorna_id_reserva_pend(prod.fldCod_produto) = 0 Then
                                If prod.saldo_estoque_local(prod.fldCod_produto, conf.Filial) <= 0 Then
                                    som_erro()
                                    AVISO("Não há Saldo para atender sua solicitação!", Me, frmAviso.tipo_aviso.tipo_ok)
                                    grdProd.Enabled = True
                                    grpBaixa.Enabled = False
                                    aberto = True
                                    lblQAtendida.Text = 0
                                    atualiza_lista_baixas()
                                    carrega_itens(pedido.num_pedido, pedido.id_filial)
                                    encerra_baixa()
                                    Exit Sub
                                End If
                            End If
                            saida.baixa_produto(prod.fldCod_produto, q, "")
                            txtBarra.Text = ""
                            atualiza_lista_baixas()
                            Application.DoEvents()
                            baixa_reserva(pedido.retorna_id_reserva_pend(prod.fldCod_produto), pedido.id_filial, pedido.num_pedido, prod.fldCod_produto)
                            If lblQReq.Text <= lblQAtendida.Text Then
                                Try
                                    If tb_itens.Rows(i)("quant") <> lblQAtendida.Text Then
                                        Exit Sub
                                    End If
                                    baixa_reserva_pedido(pedido.num_pedido, pedido.id_filial, txti.Text)
                                    grdProd.Enabled = True
                                    grpBaixa.Enabled = False
                                    aberto = True
                                    lblQAtendida.Text = 0
                                    atualiza_lista_baixas()
                                    carrega_itens(pedido.num_pedido, pedido.id_filial)
                                    encerra_baixa()
                                    Exit Sub
                                Catch ex As Exception
                                    MsgBox(ex.ToString)
                                    Exit Sub
                                End Try
                            End If
                        Else
FIM:                        MsgBox("Produto não confere com produto requisitado!", MsgBoxStyle.Exclamation)
                            Exit Sub
                        End If
                End Select
        End Select
    End Sub
    Private Sub baixa_reserva(ByVal id_reserva As Integer, ByVal id_filial As Integer, ByVal num_pedido As Integer, ByVal cod_prod As Integer)
        'Baixa a reserva da Lente no arquivo de reservas do pedido
        Dim sql As String
        sql = "update reserva_lente_pedido set id_status_reserva = 1 where " & _
        " id_reserva = " & id_reserva & " and id_filial = " & id_filial & _
        " and num_pedido = " & num_pedido & ""
        d.Comando(sql, True)
        atualiza_lista_baixas()
        'carrega_itens(pedido.num_pedido, pedido.id_filial)
        carrega_reservas(prod.fldCod_produto)
    End Sub
    Private Sub baixa_reserva_pedido(ByVal x_npedido As Integer, ByVal x_id_filial As Integer, ByVal x_item As Integer)
        Dim sql As String
        'Atualiza o Satus do item do pedido de reservado para baixado no estoque
        sql = "Update pedido_balcao_itens set cod_status_item = " & status_item_pedido.baixado_estoque & _
        " where num_pedido = " & x_npedido & " and id_filial = " & _
        x_id_filial & " and item = " & x_item & ""
        d.Comando(sql, True)
    End Sub
    Private Sub atualiza_lista_baixas()
        Dim dv As New DataView
        tb_lista = saida.lista_itens
        formata_grid_Reserva()
        lblQAtendida.Text = 0
        Try
            dv.Table = tb_lista
            dv.RowFilter = "cod_produto = " & prod.fldCod_produto & ""
        Catch ex As Exception

        End Try
        lblQAtendida.Text = dv.Count
    End Sub
    Private Sub encerra_baixa()
        Dim dv As New DataView
        dv.Table = tb_itens
        dv.RowFilter = " cod_status_item <> " & status_item_pedido.baixado_estoque & _
        " and cod_status_item <> " & status_item_pedido.cancelado & " and cod_status_item " & _
        " <> " & status_item_pedido.devolvido_estoque & ""
        If dv.Count = 0 Then
            conclui_baixa_estoque()
        End If
    End Sub
    Private Sub conclui_baixa_estoque()
        pedido.editar()
        pedido.cod_status_pedido = status_pedido.Processado_no_estoque
        pedido.Salvar()
        saida.conclui_movimento()
    End Sub
    Private Function tem_os(ByVal x_num_pedido As Integer, ByVal x_id_filial As Integer) As Boolean
        Dim sql As String
        Dim tb As New DataTable
        sql = "Select num_pedido from os where num_pedido = " & x_num_pedido & _
        " and id_filial = " & x_id_filial & " and cod_tipo_os <> 2"
        d.carrega_Tabela(sql, tb)
        If tb.Rows.Count > 0 Then Return True Else Return False
    End Function
 
    Private Sub chkBaixados_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBaixados.CheckedChanged
        carrega_itens(pedido.num_pedido, pedido.id_filial)
    End Sub

End Class