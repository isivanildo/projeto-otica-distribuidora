Imports mrotica_util
Public Class frmTabelaPromocional
    Dim d As New dados
    Dim Tabela As New objTabelaPromocional
    Dim cliente As New objCliente
    Public x_cod_tabela As Integer = 0
    Public x_id_filial As Integer = 0
    Dim conf As New config
    Private Sub frmTabelaPromocional_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If x_cod_tabela = 0 Then
            Tabela.novo()
        Else
            Tabela.filtra(x_cod_tabela, x_id_filial)
            txtDescricao.Text = Tabela.tabela_promocional
            dtIni.Value = Tabela.data_inicio
            dtFim.Value = Tabela.data_termino
            Tabela.editar()
            carrega_produtos()
            carrega_clientes()
        End If
    End Sub
    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        'Tabela.id_filial = conf.Filial
        Tabela.tabela_promocional = txtDescricao.Text
        Tabela.data_inicio = dtIni.Value.Date
        Tabela.data_termino = dtFim.Value.Date
        MsgBox(Tabela.Salvar())
    End Sub
#Region "Cliente"
    Private Sub txtCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCliente.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Dim f As New frmConsultaCliente
                f.txtNome.Text = txtCliente.Text
                f.ShowDialog(Me)
                cliente.filtra_cod(f.cod_cliente)
                txtCliente.Text = cliente.nome_cliente
        End Select
    End Sub
    Private Sub carrega_clientes()
        Dim TStb As New DataGridTableStyle
        grdCliente.DataSource = Tabela.lista_clientes
        TStb.MappingName = grdCliente.DataSource.tablename
        Dim cCliente As New DataGridTextBoxColumn
        With cCliente
            .MappingName = "nome_cliente"
            .HeaderText = "Cliente"
            .Width = 300
        End With
        TStb.GridColumnStyles.Add(cCliente)
        Dim codCliente As New DataGridTextBoxColumn
        With codCliente
            .MappingName = "cod_cliente"
            .HeaderText = "Código"
        End With
        TStb.GridColumnStyles.Add(codCliente)
        Dim FilCliente As New DataGridTextBoxColumn
        With FilCliente
            .MappingName = "cod_filial_cliente"
            .HeaderText = "Filial_cliente"
        End With
        TStb.GridColumnStyles.Add(FilCliente)
        grdCliente.TableStyles.Clear()
        grdCliente.TableStyles.Add(TStb)
        grdItens.Refresh()
    End Sub
    Private Sub btnInsereCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsereCliente.Click
        MsgBox(Tabela.insere_cliente(cliente.cod_cliente, cliente.cod_filial_cliente))
        carrega_clientes()
    End Sub

    Private Sub grdCliente_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdCliente.DoubleClick
        Dim cod, filial As Integer
        Try
            cod = grdCliente.Item(grdCliente.CurrentRowIndex, 1)
            filial = grdCliente.Item(grdCliente.CurrentRowIndex, 2)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MsgBox(Tabela.Exclui_cliente(filial, cod))
        carrega_clientes()
    End Sub
#End Region
#Region "Produto"
  
    Private Sub btnInsereProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsereProduto.Click
        If Tabela.existe_produto(txtCodTabela.Text) = True Then
            MsgBox(Tabela.atualiza_produto(txtCodTabela.Text, txtDesconto.Text))
        Else
            MsgBox(Tabela.insere_produto(txtCodTabela.Text, txtDesconto.Text))
        End If
        carrega_produtos()
    End Sub
    Private Sub grdPedidos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdItens.DoubleClick
        Dim cod As Integer
        Try
            cod = grdItens.Item(grdItens.CurrentRowIndex, 0)
        Catch ex As Exception

        End Try
        MsgBox(Tabela.Exclui_produto(cod))
        carrega_produtos()
    End Sub
    Private Sub carrega_produtos()
        Dim TStb As New DataGridTableStyle
        grdItens.DataSource = Tabela.lista_produtos
        TStb.MappingName = grdItens.DataSource.tablename
        Dim cItem As New DataGridTextBoxColumn
        With cItem
            .MappingName = "cod_tabela"
            .HeaderText = "código"
        End With
        TStb.GridColumnStyles.Add(cItem)

        Dim cProd As New DataGridTextBoxColumn
        With cProd
            .MappingName = "nome_comercial"
            .HeaderText = "Produto"
            .Width = 100
        End With
        TStb.GridColumnStyles.Add(cProd)

        Dim cPreco As New DataGridTextBoxColumn
        With cPreco
            .MappingName = "preco_venda"
            .HeaderText = "Preço."
            .Format = "#,##0.00 "
            .Alignment = HorizontalAlignment.Right
        End With
        TStb.GridColumnStyles.Add(cPreco)

        Dim cDesc As New DataGridTextBoxColumn
        With cDesc
            .MappingName = "Desconto"
            .HeaderText = "Desconto%."
            .Format = "#,##0.00 "
            .Alignment = HorizontalAlignment.Right
        End With
        TStb.GridColumnStyles.Add(cDesc)

        Dim cVDesc As New DataGridTextBoxColumn
        With cVDesc
            .MappingName = "valor_desconto"
            .HeaderText = "Desconto R$."
            .Format = "#,##0.00 "
            .Alignment = HorizontalAlignment.Right
        End With
        TStb.GridColumnStyles.Add(cVDesc)
        Dim cVFinal As New DataGridTextBoxColumn
        With cVFinal
            .MappingName = "valor_c_desconto"
            .HeaderText = "Valor Final"
            .Format = "#,##0.00 "
            .Alignment = HorizontalAlignment.Right
        End With
        TStb.GridColumnStyles.Add(cVFinal)

        grdItens.TableStyles.Clear()
        grdItens.TableStyles.Add(TStb)
        grdItens.Refresh()
    End Sub
#End Region

End Class