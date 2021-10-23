Imports mrotica_util
Public Class frmDescontosFatura
    Public fatura As objFatura
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        fatura.Historico_Desc_Texto = txtDesc.Text
        MsgBox(fatura.insere_desconto(txtValor.Text, UserID, txtDesc.Text))
        grdDesc.DataSource = fatura.listaDescontos
        Me.Close()
    End Sub
    Private Sub frmDescontosFatura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        grdDesc.DataSource = fatura.listaDescontos
    End Sub

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub grdDesc_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdDesc.DoubleClick
        Dim id As Integer
        id = grdDesc.Item(0, grdDesc.CurrentCell.ColumnNumber)
        fatura.deleta_desconto(id)
        grdDesc.DataSource = fatura.listaDescontos
    End Sub
End Class