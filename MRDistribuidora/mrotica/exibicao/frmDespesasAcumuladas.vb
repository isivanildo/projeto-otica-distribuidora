Imports mrotica_util
Public Class frmDespesasAcumuladas
    Dim excelExport As New DataDynamics.ActiveReports.Export.Xls.XlsExport

    Private Sub exportaExcel(ByVal r As DataDynamics.ActiveReports.Document.Document, ByVal path As String)
        If MessageBox.Show("Deseja exportar os dados para área de trabalho?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            excelExport.Export(r, path)
        End If
    End Sub

    Private Sub btnSair_Click(sender As System.Object, e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        Dim f As New frmRpt
        Dim r As New rptDespesasAcumulado
        r.dia = dtIni.Value.Date
        r.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape
        f.Relat(r)
        f.ShowDialog()
        f.Dispose()
    End Sub

    Private Sub btnExportarExcel_Click(sender As System.Object, e As System.EventArgs) Handles btnExportarExcel.Click
        Dim f As New frmRpt
        Dim r As New rptDespesasAcumulado
        Dim strCaminho As String = ""
        r.dia = dtIni.Value.Date
        r.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape
        f.Relat(r)
        f.Dispose()
        strCaminho = My.Computer.FileSystem.SpecialDirectories.Desktop + "\Despesas Acumuladas.xls"
        exportaExcel(r.Document, strCaminho)
    End Sub
End Class