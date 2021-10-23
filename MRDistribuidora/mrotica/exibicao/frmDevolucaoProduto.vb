Imports mrotica_util
Public Class frmDevolucaoProduto

    Dim nota As New objEntradaNota

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        Dim rp As New rptProdutoDevolucao
        Dim f As New frmRpt
        rp.DataSource = nota.lista_itens_espelho_nota_pedido_dev(CInt(txtNumPedido.Text), CInt(txtIdFilial.Text))
        rp.Label10.Text = "Produtos a ser devolvidos que não foram pedidos na solicitação do pedido abaixo"
        rp.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait
        f.Relat(rp)
        f.ShowDialog(Me)
    End Sub

    Private Sub btnSair_Click(sender As System.Object, e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub
End Class