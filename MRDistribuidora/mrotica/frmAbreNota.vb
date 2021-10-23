Imports mrotica_util
Public Class frmAbreNota
    Dim entrada As New objEntradaNota
    Public x_id_conferencia, x_filial As Integer
    Private Sub frmAbreNota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        grdProd.DataSource = entrada.lista_notas("S")
    End Sub
    Private Sub grdProd_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdProd.CurrentCellChanged
        x_id_conferencia = grdProd.Item(grdProd.CurrentCell.RowNumber, 3)
        x_filial = grdProd.Item(grdProd.CurrentCell.RowNumber, 4)
    End Sub
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        x_id_conferencia = grdProd.Item(grdProd.CurrentCell.RowNumber, 3)
        x_filial = grdProd.Item(grdProd.CurrentCell.RowNumber, 4)
        Me.Close()
    End Sub
End Class