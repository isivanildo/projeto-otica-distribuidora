Imports mrotica_util
Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class rptOperacoesCredito
    Inherits DataDynamics.ActiveReports.ActiveReport3
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub
#Region "ActiveReports Designer generated code"
    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader = Nothing
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
    Private SubCredito As DataDynamics.ActiveReports.SubReport
    Friend WithEvents Picture1 As DataDynamics.ActiveReports.Picture
    Private WithEvents subCancOS As DataDynamics.ActiveReports.SubReport
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptOperacoesCredito))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.SubCredito = New DataDynamics.ActiveReports.SubReport()
        Me.subCancOS = New DataDynamics.ActiveReports.SubReport()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.Picture1 = New DataDynamics.ActiveReports.Picture()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.SubCredito, Me.subCancOS})
        Me.Detail.Height = 0.4375!
        Me.Detail.Name = "Detail"
        '
        'SubCredito
        '
        Me.SubCredito.Border.BottomColor = System.Drawing.Color.Black
        Me.SubCredito.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.SubCredito.Border.LeftColor = System.Drawing.Color.Black
        Me.SubCredito.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.SubCredito.Border.RightColor = System.Drawing.Color.Black
        Me.SubCredito.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.SubCredito.Border.TopColor = System.Drawing.Color.Black
        Me.SubCredito.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.SubCredito.CloseBorder = False
        Me.SubCredito.Height = 0.125!
        Me.SubCredito.Left = 0!
        Me.SubCredito.Name = "SubCredito"
        Me.SubCredito.Report = Nothing
        Me.SubCredito.Top = 0.0625!
        Me.SubCredito.Width = 7.5!
        '
        'subCancOS
        '
        Me.subCancOS.Border.BottomColor = System.Drawing.Color.Black
        Me.subCancOS.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.subCancOS.Border.LeftColor = System.Drawing.Color.Black
        Me.subCancOS.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.subCancOS.Border.RightColor = System.Drawing.Color.Black
        Me.subCancOS.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.subCancOS.Border.TopColor = System.Drawing.Color.Black
        Me.subCancOS.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.subCancOS.CloseBorder = False
        Me.subCancOS.Height = 0.125!
        Me.subCancOS.Left = 0!
        Me.subCancOS.Name = "subCancOS"
        Me.subCancOS.Report = Nothing
        Me.subCancOS.Top = 0.25!
        Me.subCancOS.Width = 7.5!
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Picture1})
        Me.PageHeader.Height = 0.5!
        Me.PageHeader.Name = "PageHeader"
        '
        'Picture1
        '
        Me.Picture1.Border.BottomColor = System.Drawing.Color.Black
        Me.Picture1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture1.Border.LeftColor = System.Drawing.Color.Black
        Me.Picture1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture1.Border.RightColor = System.Drawing.Color.Black
        Me.Picture1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture1.Border.TopColor = System.Drawing.Color.Black
        Me.Picture1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture1.Height = 0.5!
        Me.Picture1.Image = CType(resources.GetObject("Picture1.Image"), System.Drawing.Image)
        Me.Picture1.ImageData = CType(resources.GetObject("Picture1.ImageData"), System.IO.Stream)
        Me.Picture1.Left = 0!
        Me.Picture1.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Picture1.LineWeight = 0!
        Me.Picture1.Name = "Picture1"
        Me.Picture1.SizeMode = DataDynamics.ActiveReports.SizeModes.Zoom
        Me.Picture1.Top = 0!
        Me.Picture1.Width = 1.3125!
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0!
        Me.PageFooter.Name = "PageFooter"
        '
        'rptOperacoesCredito
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.69!
        Me.PageSettings.PaperWidth = 8.27!
        Me.PrintWidth = 7.520833!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule(resources.GetString("$this.StyleSheet"), "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" &
            "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei" &
            "ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" &
            "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading3", "Normal"))
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region
    Public diai As Date
    Public diaf As Date
    Dim conf As New config
    Dim rP As New rptVendasSintetico
    Dim ped As New objPedidoBalcao
    Dim rRec As New rptRecebimentosDia
    Dim lanc As New objLancamentos
    Dim rDesp As New rptDespesas
    Dim rdesAcum As New rptDespesasAcumulado
    Dim rResumo As New rptResumoCaixa
    Dim rCred As New rptCreditosDia
    Dim fatura As New objFatura
    Dim rDesc As New rptDescontoCaixa
    Dim rpCancOS As New rptOSsCanceladas
    Dim rpttitulos As New rptTitulosCaixa
    Dim d As New dados
    Dim Despesas As Double
    Dim cliente As New objCliente
    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        Try
            rCred.diai = diai
            rCred.DataSource = lanc.listar_resumo_creditos_dia(diai, diaf, conf.Filial)
            SubCredito.Report = rCred

            If lanc.listar_resumo_creditos_dia(diai, diaf, conf.Filial).Rows.Count = 0 Then
                SubCredito.Visible = False
            End If
        Catch ex As Exception

        End Try
        Try
            rpCancOS.DataSource = CancOS()
            subCancOS.Report = rpCancOS
        Catch ex As Exception

        End Try
    End Sub
    Private Function vendas_dia() As DataTable
        Dim sql As String
        Dim tt As New DataTable
        sql = "Select * from pedido_balcao where cod_cliente > 1000 " & _
        "and (data_pedido >= " & d.pdtm(diai.Date & " 00:00:00") & _
        "and data_pedido <=" & d.pdtm(diaf.Date & " 23:59:59") & _
        "and pedido_balcao.id_filial = " & conf.Filial & ") order by cod_cliente"
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Private Function CancOS() As DataTable
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "Select descricao from Cancelamento_os where data >= " & d.Pdt(diai) & " and data <= " & d.Pdt(diaf) & " and id_filial = " & conf.Filial & ""
        d.carrega_Tabela(tsql, tt)
        Return tt
    End Function

End Class
