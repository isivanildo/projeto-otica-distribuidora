Imports mrotica_util
Public Class frmMain
    Dim conf As New config
    Dim troca As New objMaster

    Private Sub btnExpedicao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New frmExpedicao
        f.Show()
    End Sub



    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Versão: " & Application.ProductVersion &
        " DB: " & conf.Banco & " Servidor: " & conf.servidorDB & " Loja: " & conf.Filial
    End Sub


    Private Sub btnAndamento_Click(sender As System.Object, e As System.EventArgs) Handles btnAndamento.Click
        Dim f As New frmAndamentos
        f.Show()
    End Sub

    Private Sub btnVerificaAndamento_Click(sender As System.Object, e As System.EventArgs) Handles btnVerificaAndamento.Click
        Dim f As New frmAndamentosOS
        f.Show()
    End Sub

    Private Sub btnSaidaExtra_Click(sender As System.Object, e As System.EventArgs) Handles btnSaidaExtra.Click
        Dim f As New frmSaidaExtra
        f.Show()
    End Sub

    Private Sub btnTroaProd_Click(sender As System.Object, e As System.EventArgs) Handles btnTroaProd.Click
        Dim f As New frmSolTrocaProd
        f.Show()
    End Sub

    Private Sub btnTratamento_Click(sender As System.Object, e As System.EventArgs) Handles btnTratamento.Click
        Dim f As New frmContTratamentos
        f.novo = True
        f.x_id_filial = InputBox("Informe o nº da filial.", "INFORMAÇÃO", "")
        f.x_os = InputBox("Informe o nº da OS.", "INFORMAÇÃO")
        f.ShowDialog(Me)
        f.Dispose()
    End Sub

    Private Sub btnTratamentoRec_Click(sender As System.Object, e As System.EventArgs) Handles btnTratamentoRec.Click
        Dim f As New frmContTratamentos
        f.novo = False
        f.x_id_filial = InputBox("Informe o nº da filial.", "INFORMAÇÃO", "")
        f.x_os = InputBox("Informe a OS:")
        f.ShowDialog(Me)
        f.Dispose()
    End Sub

    Private Sub btnAviso_Click(sender As System.Object, e As System.EventArgs) Handles btnAviso.Click
        Dim f As New frmAvisoOS
        f.Show()
    End Sub

    Private Sub TrocaDeBaseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TrocaDeBaseToolStripMenuItem.Click
        Dim f As New frmTrocaBase
        f.cod_OS = InputBox("Informe o número da OS")
        f.Filial = InputBox("Informe a Filial:", "", 1)
        f.Show()
    End Sub

    Private Sub CancelarTrocaBaseProdutoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CancelarTrocaBaseProdutoToolStripMenuItem.Click
        Dim intFilial As Int16
        Dim intOS As Integer
        intOS = InputBox("Informe o número da OS")
        intFilial = InputBox("Informe a Filial:", "", 1)
        Dim strSQL As String = "Select 1 From Troca_Produto where cod_os = " & intOS & " and id_filial = " & intFilial & " and concluido = 'N'"
        If troca.verifica_existencia_registro(strSQL) = True Then
            If MessageBox.Show("Deseja cancelar a troca para a OS informada?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim strSQLAtualiza As String = "concluido = 'S' where cod_os = " & intOS & " and id_filial = " & intFilial
                troca.atualiza_registros("troca_produto", strSQL, True)
            End If
        Else
            MessageBox.Show("Não existe troca a ser cancelada.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class