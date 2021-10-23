Imports mrotica_util
Imports System.Data
Imports System.Data.SqlClient

Public Class frmConferenciaNotaRel
    Dim estoque As New objMaster
    Dim d As New dados
    Dim entrada As New objEntradaNota

    Dim nota As New objEntradaNota

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        Dim rp As New rptEspelhoNota
        Dim f As New frmRpt

        If (txtNumPedido.Text = String.Empty) Or (txtIdFilial.Text = String.Empty) Then
            MessageBox.Show("Os campos Número Pedido e Filial são obrigatórios para a operação.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        rp.DataSource = entrada.lista_itens_espelho_nota_rel(CInt(txtNumPedido.Text), CInt(txtIdFilial.Text))
        rp.Label21.Text = "Espelho da Nota Fiscal"
        rp.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape
        f.Relat(rp)
        f.ShowDialog(Me)
    End Sub

    Private Sub btnSair_Click(sender As System.Object, e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

End Class