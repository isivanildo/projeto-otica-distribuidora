Imports System.Data
Imports System.Data.SqlClient
Imports mrotica_util
Public Class frmDebitoClienteVenc
    Dim d As New dados
    Dim acesso As New objMaster
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        Dim f As New frmRpt
        Dim r As New rptDebitoCliente
        Dim strSQL As String = "select cod_cliente, nome_cliente, SUM(Valor_pago) as valor, min(data_vencimento) as data_venc," &
            "MAX(data_lancamento) as data_lanc, " &
            "case " &
            "when MAX(data_lancamento) > min(data_vencimento)  then 'Comprou' " &
            "else 'Não comprou' " &
            "end as Situacao " &
            "from verifica_debito() where data_vencimento < " & d.Pdt(dtIni.Value.Date) & " and data_recebimento is null " &
            "and cod_status_lancamento = 1  group by cod_cliente, nome_cliente " &
            "having MAX(convert(nvarchar(10),(data_lancamento),23)) > min(convert(nvarchar(10),(data_vencimento),23))"
        Try
            d.conecta()
            Dim da As New SqlDataAdapter(strSQL, d.con)
            Dim ds As New DataSet
            da.Fill(ds, "Cliente")
            If (ds Is Nothing = False) Then
                MessageBox.Show("Nenhum registro encontrado para ser exibido.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If


            r.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait
            r.DataSource = ds.Tables(0)
            f.Relat(r)
            f.ShowDialog()
            f.Dispose()
            d.desconecta()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub btnSair_Click_1(sender As System.Object, e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

End Class