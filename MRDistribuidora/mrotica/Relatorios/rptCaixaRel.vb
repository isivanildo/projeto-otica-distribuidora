Imports mrotica_util
Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class rptCaixaRel
    Inherits DataDynamics.ActiveReports.ActiveReport3
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub
#Region "ActiveReports Designer generated code"
    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader = Nothing
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
    Private srRec As DataDynamics.ActiveReports.SubReport
    Private srDesp As DataDynamics.ActiveReports.SubReport
    Private sbResumo As DataDynamics.ActiveReports.SubReport
    Private SubCredito As DataDynamics.ActiveReports.SubReport
    Private sResumoDespesas As DataDynamics.ActiveReports.SubReport
    Private WithEvents subCancOS As DataDynamics.ActiveReports.SubReport
    Private WithEvents Subtitulos As DataDynamics.ActiveReports.SubReport
    Private srDesc As DataDynamics.ActiveReports.SubReport
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptCaixaRel))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.srRec = New DataDynamics.ActiveReports.SubReport()
        Me.srDesp = New DataDynamics.ActiveReports.SubReport()
        Me.sbResumo = New DataDynamics.ActiveReports.SubReport()
        Me.SubCredito = New DataDynamics.ActiveReports.SubReport()
        Me.sResumoDespesas = New DataDynamics.ActiveReports.SubReport()
        Me.srDesc = New DataDynamics.ActiveReports.SubReport()
        Me.subCancOS = New DataDynamics.ActiveReports.SubReport()
        Me.Subtitulos = New DataDynamics.ActiveReports.SubReport()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.srRec, Me.srDesp, Me.sbResumo, Me.SubCredito, Me.sResumoDespesas, Me.srDesc, Me.subCancOS, Me.Subtitulos})
        Me.Detail.Height = 1.759722!
        Me.Detail.Name = "Detail"
        '
        'srRec
        '
        Me.srRec.Border.BottomColor = System.Drawing.Color.Black
        Me.srRec.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.srRec.Border.LeftColor = System.Drawing.Color.Black
        Me.srRec.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.srRec.Border.RightColor = System.Drawing.Color.Black
        Me.srRec.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.srRec.Border.TopColor = System.Drawing.Color.Black
        Me.srRec.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.srRec.CloseBorder = False
        Me.srRec.Height = 0.125!
        Me.srRec.Left = 0.0!
        Me.srRec.Name = "srRec"
        Me.srRec.Report = Nothing
        Me.srRec.Top = 0.375!
        Me.srRec.Width = 7.5!
        '
        'srDesp
        '
        Me.srDesp.Border.BottomColor = System.Drawing.Color.Black
        Me.srDesp.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.srDesp.Border.LeftColor = System.Drawing.Color.Black
        Me.srDesp.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.srDesp.Border.RightColor = System.Drawing.Color.Black
        Me.srDesp.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.srDesp.Border.TopColor = System.Drawing.Color.Black
        Me.srDesp.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.srDesp.CloseBorder = False
        Me.srDesp.Height = 0.125!
        Me.srDesp.Left = 0.0!
        Me.srDesp.Name = "srDesp"
        Me.srDesp.Report = Nothing
        Me.srDesp.Top = 0.5625!
        Me.srDesp.Width = 7.5!
        '
        'sbResumo
        '
        Me.sbResumo.Border.BottomColor = System.Drawing.Color.Black
        Me.sbResumo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.sbResumo.Border.LeftColor = System.Drawing.Color.Black
        Me.sbResumo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.sbResumo.Border.RightColor = System.Drawing.Color.Black
        Me.sbResumo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.sbResumo.Border.TopColor = System.Drawing.Color.Black
        Me.sbResumo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.sbResumo.CloseBorder = False
        Me.sbResumo.Height = 0.125!
        Me.sbResumo.Left = 4.125!
        Me.sbResumo.Name = "sbResumo"
        Me.sbResumo.Report = Nothing
        Me.sbResumo.Top = 0.8125!
        Me.sbResumo.Width = 3.375!
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
        Me.SubCredito.Left = 0.0!
        Me.SubCredito.Name = "SubCredito"
        Me.SubCredito.Report = Nothing
        Me.SubCredito.Top = 1.353346!
        Me.SubCredito.Width = 7.5!
        '
        'sResumoDespesas
        '
        Me.sResumoDespesas.Border.BottomColor = System.Drawing.Color.Black
        Me.sResumoDespesas.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.sResumoDespesas.Border.LeftColor = System.Drawing.Color.Black
        Me.sResumoDespesas.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.sResumoDespesas.Border.RightColor = System.Drawing.Color.Black
        Me.sResumoDespesas.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.sResumoDespesas.Border.TopColor = System.Drawing.Color.Black
        Me.sResumoDespesas.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.sResumoDespesas.CloseBorder = False
        Me.sResumoDespesas.Height = 0.125!
        Me.sResumoDespesas.Left = 2.0!
        Me.sResumoDespesas.Name = "sResumoDespesas"
        Me.sResumoDespesas.Report = Nothing
        Me.sResumoDespesas.Top = 1.0!
        Me.sResumoDespesas.Width = 5.5!
        '
        'srDesc
        '
        Me.srDesc.Border.BottomColor = System.Drawing.Color.Black
        Me.srDesc.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.srDesc.Border.LeftColor = System.Drawing.Color.Black
        Me.srDesc.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.srDesc.Border.RightColor = System.Drawing.Color.Black
        Me.srDesc.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.srDesc.Border.TopColor = System.Drawing.Color.Black
        Me.srDesc.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.srDesc.CloseBorder = False
        Me.srDesc.Height = 0.125!
        Me.srDesc.Left = 0.0!
        Me.srDesc.Name = "srDesc"
        Me.srDesc.Report = Nothing
        Me.srDesc.Top = 0.1875!
        Me.srDesc.Width = 7.5!
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
        Me.subCancOS.Left = 0.0!
        Me.subCancOS.Name = "subCancOS"
        Me.subCancOS.Report = Nothing
        Me.subCancOS.Top = 1.550197!
        Me.subCancOS.Width = 7.5!
        '
        'Subtitulos
        '
        Me.Subtitulos.Border.BottomColor = System.Drawing.Color.Black
        Me.Subtitulos.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Subtitulos.Border.LeftColor = System.Drawing.Color.Black
        Me.Subtitulos.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Subtitulos.Border.RightColor = System.Drawing.Color.Black
        Me.Subtitulos.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Subtitulos.Border.TopColor = System.Drawing.Color.Black
        Me.Subtitulos.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Subtitulos.CloseBorder = False
        Me.Subtitulos.Height = 0.1230315!
        Me.Subtitulos.Left = 0.9350393!
        Me.Subtitulos.Name = "Subtitulos"
        Me.Subtitulos.Report = Nothing
        Me.Subtitulos.Top = 1.181102!
        Me.Subtitulos.Width = 6.545276!
        '
        'PageHeader
        '
        Me.PageHeader.Height = 0.25!
        Me.PageHeader.Name = "PageHeader"
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'rptCaixaRel
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.69!
        Me.PageSettings.PaperWidth = 8.27!
        Me.PrintWidth = 7.520833!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule(resources.GetString("$this.StyleSheet"), "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" & _
            "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei" & _
            "ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" & _
            "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading3", "Normal"))
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region
    Public diai As Date
    Public diaf As Date
    Public intFilial As Integer
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
        'Try
        'rP.dia = dia
        'rP.DataSource = vendas_dia()
        ' srVendas.Report = rP
        'Catch ex As Exception

        'End Try
        Try
            rDesc.DataSource = fatura.listaDescontosDia(diai, conf.Filial)
            srDesc.Report = rDesc
        Catch ex As Exception

        End Try
        Try
            rRec.diai = diai
            rRec.DataSource = lanc.listar_receitas_data(diai, diaf, conf.Filial)
            srRec.Report = rRec
        Catch ex As Exception

        End Try
        Try
            rDesp.diai = diai
            rDesp.diaf = diaf
            rDesp.DataSource = lanc.listar_despesas_data(diai, diaf, conf.Filial)
            srDesp.Report = rDesp
        Catch ex As Exception

        End Try
        Try
            rResumo.DataSource = lanc.listar_resumo_formas_pagamento(diai, diaf, conf.Filial)
            sbResumo.Report = rResumo
        Catch ex As Exception

        End Try
        Try
            rCred.diai = diai
            rCred.diaf = diaf
            rCred.DataSource = lanc.listar_resumo_creditos_dia(diai, diaf, conf.Filial)
            SubCredito.Report = rCred
        Catch ex As Exception

        End Try
        Try
            rdesAcum.dia = diai
            sResumoDespesas.Report = rdesAcum
        Catch ex As Exception

        End Try
        Try
            rpCancOS.DataSource = CancOS()
            subCancOS.Report = rpCancOS
        Catch ex As Exception

        End Try
        Try
            rpttitulos.DataSource = cliente.titulos_baixados_dia(diai, diaf)
            Subtitulos.Report = rpttitulos
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
        tsql = "Select descricao from Cancelamento_os where data = " & d.Pdt(diai) & " and id_filial = " & conf.Filial & ""
        d.carrega_Tabela(tsql, tt)
        Return tt
    End Function
    Private Sub PageFooter_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageFooter.Format
    End Sub

End Class
