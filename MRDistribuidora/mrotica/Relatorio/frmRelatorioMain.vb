Imports DevExpress.XtraReports
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting.Preview
Imports DevExpress.XtraReports.Parameters

Public Class frmRelatorioMain
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Report1.Load("C:\MRSystem\MRDistribuidora\mrotica\Relatorio\RelCliente.frx")
        ' Dim tb As TableDataSource = TryCast(Report1.GetDataSource("Table"), TableDataSource)
        ' tb.SelectCommand = "select * from cliente inner join pacote_cliente on " &
        '"cliente.cod_cliente = pacote_cliente.cod_cliente where cliente.cod_cliente = 18 and cliente.cod_filial_cliente = 1 " &
        ' "and pacote_cliente.cod_pacote = 18"
        ' Report1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim relatorio As New testeRel()
        Dim impressoa As New ReportPrintTool(relatorio)

        ' Dim parametro As New Parameter()
        ' parametro.Name = "codcliente"
        'parametro.Value = 19
        'parametro.Type = GetType(System.Int32)
        'parametro.Description = "Codigo"
        'parametro.Visible = False

        'Dim parametro1 As New Parameter()
        ' parametro1.Name = "codfilial"
        ' parametro1.Value = 1
        'parametro1.Type = GetType(System.Int32)
        'parametro1.Description = "Filial"
        'parametro1.Visible = False

        'relatorio.Parameters.Add(parametro1)
        'relatorio.FilterString = "[cod_filial_cliente] = [Parameters.codfilial]"

        'relatorio.Parameters.Add(parametro)
        'relatorio.FilterString = "[cod_cliente] = [Parameters.codcliente]"
        relatorio.Parameters("codigocliente").Value = 19
        relatorio.Parameters("codigofilial").Value = 2
        relatorio.Parameters("codigocliente").Visible = False
        relatorio.Parameters("codigofilial").Visible = False
        relatorio.RequestParameters = False

        impressoa.ShowPreviewDialog()
        'relatorio.CreateDocument()
        'impressoa.ShowRibbonPreview()
    End Sub
End Class