Imports mrotica_util
Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports MRUtil

Public Class rptCaixa
Inherits DataDynamics.ActiveReports.ActiveReport3
	Public Sub New()
	MyBase.New()
		InitializeComponent()
	End Sub
	#Region "ActiveReports Designer generated code"
    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader = Nothing
    Friend WithEvents Detail As DataDynamics.ActiveReports.Detail
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
    Private srRec As DataDynamics.ActiveReports.SubReport
    Private srDesp As DataDynamics.ActiveReports.SubReport
    Private sbResumo As DataDynamics.ActiveReports.SubReport
    Friend WithEvents Picture1 As DataDynamics.ActiveReports.Picture
    Private WithEvents Subtitulos As DataDynamics.ActiveReports.SubReport
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptCaixa))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.srRec = New DataDynamics.ActiveReports.SubReport()
        Me.srDesp = New DataDynamics.ActiveReports.SubReport()
        Me.sbResumo = New DataDynamics.ActiveReports.SubReport()
        Me.Subtitulos = New DataDynamics.ActiveReports.SubReport()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.Picture1 = New DataDynamics.ActiveReports.Picture()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.srRec, Me.srDesp, Me.sbResumo, Me.Subtitulos})
        Me.Detail.Height = 0.9375!
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
        Me.srRec.Left = 0!
        Me.srRec.Name = "srRec"
        Me.srRec.Report = Nothing
        Me.srRec.Top = 0.1875!
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
        Me.srDesp.Left = 0!
        Me.srDesp.Name = "srDesp"
        Me.srDesp.Report = Nothing
        Me.srDesp.Top = 0.375!
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
        Me.sbResumo.Top = 0.75!
        Me.sbResumo.Width = 3.375!
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
        Me.Subtitulos.Height = 0.125!
        Me.Subtitulos.Left = 0!
        Me.Subtitulos.Name = "Subtitulos"
        Me.Subtitulos.Report = Nothing
        Me.Subtitulos.Top = 0!
        Me.Subtitulos.Width = 7.5!
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
        'rptCaixa
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
    Public diai As String
    Public diaf As String
    Public intFilial As Integer
    Dim Lancamento As New Lancamento
    Dim conf As New config
    Dim rRec As New rptRecebimentosDia
    Dim lanc As New objLancamentos
    Dim rDesp As New rptDespesas
    Dim rResumo As New rptResumoCaixa
    Dim rpttitulos As New rptTitulosCaixa
    Dim d As New dados
    Dim cliente As New objCliente

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        Try
            rRec.diai = diai.ToString() + " 00:00:01"
            rRec.diaf = diaf.ToString() + " 23:59:59"
            rRec.DataSource = Lancamento.ListarReceitasData(diai, diaf, intFilial)
            srRec.Report = rRec
        Catch ex As Exception

        End Try
        Try
            rDesp.diai = diai.ToString() + " 00:00:01"
            rDesp.diaf = diaf.ToString() + " 23:59:59"
            rDesp.DataSource = Lancamento.ListarDespesasData(diai, diaf, intFilial)
            srDesp.Report = rDesp

            If Lancamento.ListarDespesasData(diai, diaf, intFilial).Rows.Count = 0 Then
                srDesp.Visible = False
            End If
        Catch ex As Exception

        End Try

        Try
            rResumo.DataSource = Lancamento.ListarResumoFormasPagamento(diai, diaf, intFilial) 'lanc.listar_resumo_formas_pagamento(diai, diaf, intFilial)
            'lanc.listar_resumo_formas_pagamento(diai, diaf, intFilial)

            sbResumo.Report = rResumo
        Catch ex As Exception

        End Try

        Try
            If conf.Filial = 1 Then
                rpttitulos.diai = diai.ToString() + " 23:59:59"
                rpttitulos.diaf = diaf.ToString() + " 23:59:59"
                rpttitulos.DataSource = Lancamento.TitulosBaixadosDia(diai, diaf) 'cliente.titulos_baixados_dia(diai, diaf)
                Subtitulos.Report = rpttitulos

                'If cliente.titulos_baixados_dia(diai, diaf).Rows.Count = 0 Then
                'titulos.Visible = False
                'If

                If Lancamento.TitulosBaixadosDia(diai, diaf).Rows.Count = 0 Then
                    Subtitulos.Visible = False
                End If
            Else
                Subtitulos.Visible = False
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub PageHeader_Format(sender As Object, e As EventArgs) Handles PageHeader.Format
        If My.Computer.FileSystem.FileExists(conf.ImagemRelatorio) Then
            Picture1.Image = Image.FromFile(conf.ImagemRelatorio)
        End If
    End Sub
End Class
