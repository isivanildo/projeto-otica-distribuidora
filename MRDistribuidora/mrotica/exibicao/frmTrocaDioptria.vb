Imports mrotica_util
Public Class frmTrocaDioptria
    Dim prod As New produtoClass
    Dim troca As New objTrocaDioptria
    Dim Ajuste As New objMaster

    Private Sub txtEntra_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEntra.KeyDown
        Dim f As New frmConsultaProdDiopCod
        Dim eS As Char
        Dim tipo As String
        Select Case e.KeyCode
            Case Keys.Enter
                'Caso não seja informado o código de barras
                'abre formulário para informar detalhes da
                'lente.
                If txtSai.Text = "" Then
                    tipo = "Manual"
                    'Verifica o tipo de produto
                    eS = prod.ret_especie(txtCodTabela.Text)
                    'Se o produto for Lente pronta, abre o formulário 
                    'de lente.
                    If eS = "L" Then
                        f.tipo = "L"
                        f.txtCodTabela.Text = txtCodTabela.Text
                        f.ShowDialog(Me)
                        txtEntra.Text = f.Result
                    Else
                        f.tipo = "B"
                        f.txtCodTabela.Text = txtCodTabela.Text
                        f.ShowDialog(Me)
                        txtEntra.Text = f.Result
                    End If
                    lblEntra.Text = prod.Retorna_nome_prod(txtEntra.Text)
                End If
        End Select
    End Sub
    Private Sub txtSai_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSai.KeyDown
        Dim f As New frmConsultaProdDiopCod
        Dim eS As Char
        Dim tipo As String
        Select Case e.KeyCode
            Case Keys.Enter
                'Caso não seja informado o código de barras
                'abre formulário para informar detalhes da
                'lente.
                If txtSai.Text = "" Then
                    tipo = "Manual"
                    'Verifica o tipo de produto
                    eS = prod.ret_especie(txtCodTabela.Text)
                    'Se o produto for Lente pronta, abre o formulário 
                    'de lente.
                    If eS = "L" Then
                        f.tipo = "L"
                        f.txtCodTabela.Text = txtCodTabela.Text
                        f.ShowDialog(Me)
                        txtSai.Text = f.Result
                    Else
                        f.tipo = "B"
                        f.txtCodTabela.Text = txtCodTabela.Text
                        f.ShowDialog(Me)
                        txtSai.Text = f.Result
                    End If
                    lblSai.Text = prod.Retorna_nome_prod(txtSai.Text)
                End If
        End Select
    End Sub

    Private Sub btnConcluir_Click(sender As System.Object, e As System.EventArgs) Handles btnConcluir.Click
        Dim intUsuario As Integer = Ajuste.retorna_codigo_usuario(frmMain.intCodigoUsuario)
        If txtEntra.Text = "" Then
            MessageBox.Show("Informe o código do produto que entra!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtEntra.Focus()
            Exit Sub
        End If
        If txtSai.Text = "" Then
            MessageBox.Show("Informe o código do produto que sai!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtSai.Focus()
            Exit Sub
        End If
        troca.novo()
        troca.historico = "para ajuste do estoque"
        troca.prod_Entra = txtEntra.Text
        troca.prod_sai = txtSai.Text
        troca.id_usuario = intUsuario
        MsgBox(troca.Salvar)
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub


    Private Sub txtCodTabela_Leave(sender As System.Object, e As System.EventArgs)
        ToolStripStatusLabel1.Text = "Pressione ENTER"
    End Sub

End Class