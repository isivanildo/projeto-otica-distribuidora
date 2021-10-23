Imports mrotica_util
Public Class frmDevolucaoPedido
    Public dev As objDevolucaoEstoquePedido
    Dim cod_prod As Integer
    Dim qdevolver, qdevolvida As Integer
    Private Sub frmDevolucaoPedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formata_grid_prod()
    End Sub
    Private Sub formata_grid_prod()
        Dim TStb As New DataGridTableStyle
        grdProd.DataSource = dev.lista_itens_devolucao
        TStb.MappingName = grdProd.DataSource.tablename
        Dim cProd As New DataGridTextBoxColumn
        With cProd
            .MappingName = "Cod_produto"
            .HeaderText = "Código"
        End With
        TStb.GridColumnStyles.Add(cProd)

        Dim nProd As New DataGridTextBoxColumn
        With nProd
            .MappingName = "Produto"
            .HeaderText = "Produto"
            .Width = 250
        End With
        TStb.GridColumnStyles.Add(nProd)

        Dim cQuant As New DataGridTextBoxColumn
        With cQuant
            .MappingName = "quant"
            .HeaderText = "Q."
            .Width = 20
        End With
        TStb.GridColumnStyles.Add(cQuant)

        Dim cAtend As New DataGridTextBoxColumn
        With cAtend
            .MappingName = "devolvido"
            .HeaderText = "devolvido"
        End With
        TStb.GridColumnStyles.Add(cAtend)

        Dim cPreco As New DataGridTextBoxColumn
        With cPreco
            .MappingName = "preco"
            .HeaderText = "P. Unit."
            .Format = "#,##0.00 "
            .Alignment = HorizontalAlignment.Right
        End With
        TStb.GridColumnStyles.Add(cPreco)

        Dim cDesc As New DataGridTextBoxColumn
        With cDesc
            .MappingName = "desconto"
            .HeaderText = "Desc."
            .Format = "#,##0.00 "
            .Width = 33
            .Alignment = HorizontalAlignment.Right
        End With
        TStb.GridColumnStyles.Add(cDesc)

        Dim cTotal As New DataGridTextBoxColumn
        With cTotal
            .MappingName = "Total"
            .HeaderText = "Total."
            .Alignment = HorizontalAlignment.Right
            .Format = "#,##0.00 "
        End With
        TStb.GridColumnStyles.Add(cTotal)

        grdProd.TableStyles.Clear()
        grdProd.TableStyles.Add(TStb)
    End Sub
    Private Sub txtBarra_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBarra.KeyDown
        Dim es As Char
        Dim q As Integer = 1
        Dim f As New frmConsultaProdDiop
        Dim prod As New produtoClass
        Dim mov As New objMovimentoDetalhe
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
                    Else
                        f.tipo = "B"
                        f.cod_prod = prod.fldCod_produto
                        f.ShowDialog(Me)
                        If f.Result = True Then
                            GoTo SAIDA
                        Else
                            GoTo FIM
                        End If
                    End If
                End If

                If prod.Retorna_cod_prod(txtBarra.Text) = cod_prod Then
SAIDA:
                    Try
                        If CDbl(lblQDevolver.Text) <= CDbl(lblQDevolvida.Text) Then
                            grdProd.Enabled = True
                            grpBaixa.Enabled = False
                            lblQDevolvida.Text = 0
                            Exit Sub
                        End If
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                        Exit Sub
                    End Try

                    MsgBox(dev.devolve_produto(cod_prod, q))

                    txtBarra.Text = ""
                    totais(cod_prod)
                    cod_prod = Nothing
                    Application.DoEvents()
                    If lblQDevolver.Text <= lblQDevolvida.Text Then
                        Try
                            grdProd.Enabled = True
                            grpBaixa.Enabled = False
                            Exit Sub
                        Catch ex As Exception
                            MsgBox(ex.ToString)
                            Exit Sub
                        End Try
                    End If
                Else
FIM:                MsgBox("Produto não confere com produto requisitado!", MsgBoxStyle.Exclamation)
                    cod_prod = Nothing
                    Exit Sub
                End If
        End Select

    End Sub
    Private Sub grdProd_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdProd.CurrentCellChanged
        Try
            cod_prod = grdProd.Item(grdProd.CurrentRowIndex, 0)
            qdevolver = grdProd.Item(grdProd.CurrentRowIndex, 2)
            qdevolvida = grdProd.Item(grdProd.CurrentRowIndex, 3)
        Catch ex As Exception
            cod_prod = 0
        End Try
        totais(cod_prod)
    End Sub
    Private Sub totais(ByVal x_cod_prod As Integer)
        lblQDevolver.Text = qdevolver 'dev.quantidade_item_devolucao(x_cod_prod)
        grdDevolvido.DataSource = dev.lista_itens_devolvidos(x_cod_prod)
        lblQDevolvida.Text = qdevolvida 'grdDevolvido.DataSource.rows.count
        If lblQDevolver.Text > lblQDevolvida.Text Then
            Try
                grpBaixa.Enabled = True
            Catch ex As Exception
                MsgBox(ex.ToString)
                Exit Sub
            End Try
        Else
            grpBaixa.Enabled = False
        End If
    End Sub
    Private Sub btnConcluirItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConcluir.Click

    End Sub
End Class