Imports mrotica_util
Public Class frmCadBarraDiop
    Dim prod As New produtoClass
    Dim x_barra As String
    Dim d As New dados
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim f As New frmConsultaProdDiopCod
        Dim es As String
        Dim cod_prod As Integer
        es = txtTipo.Text
        If es.ToString.Trim.ToUpper <> "L" And es.ToString.ToUpper <> "B" And es.ToString.ToUpper.Trim <> "LC" Then
            som_erro()
            MsgBox("Erro!")
            Exit Sub
        End If
        'Se o produto for Lente pronta, abre o formulário 
        'de lente.
        f.txtCodTabela.Text = txtCodTabela.Text
        If eS = "L" Then
            f.tipo = "L"
            f.ShowDialog(Me)
            cod_prod = f.Result
            prod.filtra(cod_prod)
            txtBarra.Text = prod.fldCod_barra
        ElseIf es = "B" Then
            'Se o produto for bloco, abre o formulário 
            'de bloco.
            f.tipo = "B"
            f.ShowDialog(Me)
            cod_prod = f.Result
            prod.filtra(cod_prod)
            txtBarra.Text = prod.fldCod_barra
        ElseIf es = "LC" Then
            'Se o produto for bloco, abre o formulário 
            'de bloco.
            f.tipo = "LC"
            f.ShowDialog(Me)
            cod_prod = f.Result
            prod.filtra(cod_prod)
            txtBarra.Text = prod.fldCod_barra
        End If
        prod.filtra(cod_prod)
        txtNomeLente.Text = prod.fldProduto
        txtBarra.Focus()
    End Sub

    Private Sub txtBarra_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBarra.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                x_barra = txtBarra.Text
                cadastra_barra()
                txtBarra.Text = ""
                Button1.Focus()
        End Select
    End Sub
    Private Sub cadastra_barra()
        Dim r As frmAviso.respo
        r = AVISO("Deseja realmente atribuir este código de barras ao produto " & txtNomeLente.Text & "?", Me, frmAviso.tipo_aviso.tipo_sim_nao)
        Dim sql As String
        Dim nBarra As String
        If r = frmAviso.respo.SIM Then
            prod.editar()
            If IsNumeric(x_barra) Then
                x_barra = CDbl(x_barra)
            End If
            sql = "Update produtos set cod_barra = NULL where cod_barra = '" & x_barra & "'"
            d.Comando(sql, True)
            nBarra = txtBarra.Text
            If IsNumeric(nBarra) Then
                nBarra = CDbl(nBarra)
            End If
            prod.fldCod_barra = nBarra
            AVISO(prod.Salvar(produtoClass.tiposalvar.Normal), Me, frmAviso.tipo_aviso.tipo_ok)
            End If
    End Sub

    Private Sub btnBarra_Click(sender As System.Object, e As System.EventArgs) Handles btnBarra.Click
        cadastra_barra()
    End Sub
End Class