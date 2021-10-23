Imports mrotica_util
Imports MRUtil
Public Class frmClassificacaoFiscal
    Dim Conn As New ConexaoDB
    Dim Util As New Geral
    Dim NaturezaOp As New NaturezaOperacao
    Dim codigonat As Integer
    Private Sub frmClassificacaoFiscal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        Geral.TipoReg = "N"
        NaturezaOp.Novo()
        Util.AtivaControles(Me)
        Util.AcaoBotoes(ToolStrip1, "Novo")
        Dim chave As Integer = Conn.RetornaChave("codigonat", "naturezaoperacao", "")
        txtCodigo.Text = String.Format("{0:000}", chave)
        txtCodigo.Enabled = False
        txtDescricao.Focus()
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        Util.AtivaControles(Me)
        txtCodigo.Enabled = True
        txtCodigo.Focus()
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        NaturezaOp.CodigoNatureza = Convert.ToInt32(txtCodigo.Text)
        NaturezaOp.Descricao = txtDescricao.Text
        NaturezaOp.Observacao = txtObservacao.Text

        If cbConsumidorFinal.SelectedIndex = 0 Then
            NaturezaOp.ConsumidorFinal = 0
        Else
            NaturezaOp.ConsumidorFinal = 1
        End If

        If rbEntrada.Checked = True Then NaturezaOp.TipoNFe = 0 Else NaturezaOp.TipoNFe = 1

        If rbCusto.Checked Then
            NaturezaOp.PrecoUsado = 0
        Else
            NaturezaOp.PrecoUsado = 1
        End If

        If cbDestinoOperacao.SelectedIndex = 0 Then
            NaturezaOp.DestinoOperacao = 1
        ElseIf cbDestinoOperacao.SelectedIndex = 1 Then
            NaturezaOp.DestinoOperacao = 2
        Else
            NaturezaOp.DestinoOperacao = 3
        End If

        If cbConsumidorPresente.SelectedIndex = 0 Then
            NaturezaOp.ConsumidorPresente = 0
        ElseIf cbConsumidorPresente.SelectedIndex = 1 Then
            NaturezaOp.ConsumidorPresente = 1
        ElseIf cbConsumidorPresente.SelectedIndex = 2 Then
            NaturezaOp.ConsumidorPresente = 2
        ElseIf cbConsumidorPresente.SelectedIndex = 3 Then
            NaturezaOp.ConsumidorPresente = 3
        Else
            NaturezaOp.ConsumidorPresente = 9
        End If

        If cbFinalidade.SelectedIndex = 0 Then
            NaturezaOp.FinalidadeNota = 1
        ElseIf cbFinalidade.SelectedIndex = 1 Then
            NaturezaOp.FinalidadeNota = 2
        ElseIf cbFinalidade.SelectedIndex = 2 Then
            NaturezaOp.FinalidadeNota = 3
        Else
            NaturezaOp.FinalidadeNota = 4
        End If


        If Geral.TipoReg = "N" Then
            NaturezaOp.SalvaOperacao()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Util.DesativaControles(Me)
        Util.AcaoBotoes(ToolStrip1, "Cancelar")
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub txtCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigo.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Dim f As New frmConsultaNatOperacao
                f.ShowDialog()
                txtCodigo.Text = f.codigonat
                f.Dispose()
                txtCodigo_Leave(sender, e)
                txtDescricao.Focus()
        End Select
    End Sub

    Private Sub txtCodigo_Leave(sender As Object, e As EventArgs) Handles txtCodigo.Leave
        NaturezaOp.RetornaRegistro(Convert.ToInt32(txtCodigo.Text))
        txtDescricao.Text = NaturezaOp.Descricao
        txtObservacao.Text = NaturezaOp.Observacao

        If NaturezaOp.FinalidadeNota = 1 Then
            cbFinalidade.SelectedIndex = 0
        ElseIf NaturezaOp.FinalidadeNota = 2 Then
            cbFinalidade.SelectedIndex = 1
        ElseIf NaturezaOp.FinalidadeNota = 3 Then
            cbFinalidade.SelectedIndex = 2
        ElseIf NaturezaOp.FinalidadeNota = 4 Then
            cbFinalidade.SelectedIndex = 3
        End If

        If NaturezaOp.ConsumidorFinal = 0 Then
            cbConsumidorFinal.SelectedIndex = 0
        ElseIf NaturezaOp.ConsumidorFinal = 1 Then
            cbConsumidorFinal.SelectedIndex = 1
        End If

        If NaturezaOp.PrecoUsado = 0 Then
            rbCusto.Checked = True
        ElseIf NaturezaOp.PrecoUsado = 1 Then
            rbVenda.Checked = True
        End If

        If NaturezaOp.TipoNFe = 0 Then
            rbEntrada.Checked = True
        ElseIf NaturezaOp.TipoNFe = 1 Then
            rbSaida.Checked = True
        End If

        If NaturezaOp.DestinoOperacao = 1 Then
            cbDestinoOperacao.SelectedIndex = 0
        ElseIf NaturezaOp.DestinoOperacao = 2 Then
            cbDestinoOperacao.SelectedIndex = 1
        ElseIf NaturezaOp.DestinoOperacao = 3 Then
            cbDestinoOperacao.SelectedIndex = 2
        End If

        If NaturezaOp.ConsumidorPresente = 0 Then
            cbConsumidorPresente.SelectedIndex = 0
        ElseIf NaturezaOp.ConsumidorPresente = 1 Then
            cbConsumidorPresente.SelectedIndex = 1
        ElseIf NaturezaOp.ConsumidorPresente = 2 Then
            cbConsumidorPresente.SelectedIndex = 2
        ElseIf NaturezaOp.ConsumidorPresente = 3 Then
            cbConsumidorPresente.SelectedIndex = 3
        ElseIf NaturezaOp.ConsumidorPresente = 9 Then
            cbConsumidorPresente.SelectedIndex = 4
        End If

    End Sub
End Class