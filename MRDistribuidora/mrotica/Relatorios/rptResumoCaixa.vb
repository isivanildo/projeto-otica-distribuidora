Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports mrotica_util

Public Class rptResumoCaixa
Inherits DataDynamics.ActiveReports.ActiveReport3
	Public Sub New()
	MyBase.New()
		InitializeComponent()
	End Sub
	#Region "ActiveReports Designer generated code"
    Private WithEvents ReportHeader As DataDynamics.ActiveReports.ReportHeader = Nothing
    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader = Nothing
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
    Private WithEvents ReportFooter As DataDynamics.ActiveReports.ReportFooter = Nothing
	Private Label4 As DataDynamics.ActiveReports.Label
	Private txtForma As DataDynamics.ActiveReports.TextBox
	Private txtValor As DataDynamics.ActiveReports.TextBox
	Private Line As DataDynamics.ActiveReports.Line
	Private TextBox2 As DataDynamics.ActiveReports.TextBox
	Private txtDespesas As DataDynamics.ActiveReports.TextBox
	Private Label As DataDynamics.ActiveReports.Label
	Private txtDinheiro As DataDynamics.ActiveReports.TextBox
	Private Label1 As DataDynamics.ActiveReports.Label
	Private Label2 As DataDynamics.ActiveReports.Label
	Private txtSaldo As DataDynamics.ActiveReports.TextBox
    Private Label3 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label5 As DataDynamics.ActiveReports.Label
    Private Line1 As DataDynamics.ActiveReports.Line
	Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptResumoCaixa))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txtForma = New DataDynamics.ActiveReports.TextBox()
        Me.txtValor = New DataDynamics.ActiveReports.TextBox()
        Me.Line = New DataDynamics.ActiveReports.Line()
        Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader()
        Me.Label4 = New DataDynamics.ActiveReports.Label()
        Me.ReportFooter = New DataDynamics.ActiveReports.ReportFooter()
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox()
        Me.txtDespesas = New DataDynamics.ActiveReports.TextBox()
        Me.Label = New DataDynamics.ActiveReports.Label()
        Me.txtDinheiro = New DataDynamics.ActiveReports.TextBox()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.txtSaldo = New DataDynamics.ActiveReports.TextBox()
        Me.Label3 = New DataDynamics.ActiveReports.Label()
        Me.Line1 = New DataDynamics.ActiveReports.Line()
        Me.Label5 = New DataDynamics.ActiveReports.Label()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        CType(Me.txtForma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDespesas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDinheiro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtForma, Me.txtValor, Me.Line})
        Me.Detail.Height = 0.21875!
        Me.Detail.Name = "Detail"
        '
        'txtForma
        '
        Me.txtForma.Border.BottomColor = System.Drawing.Color.Black
        Me.txtForma.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtForma.Border.LeftColor = System.Drawing.Color.Black
        Me.txtForma.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtForma.Border.RightColor = System.Drawing.Color.Black
        Me.txtForma.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtForma.Border.TopColor = System.Drawing.Color.Black
        Me.txtForma.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtForma.DataField = "forma_pagamento"
        Me.txtForma.Height = 0.1875!
        Me.txtForma.Left = 0.9375!
        Me.txtForma.Name = "txtForma"
        Me.txtForma.Style = "ddo-char-set: 1; font-size: 8pt; "
        Me.txtForma.Top = 0.0!
        Me.txtForma.Width = 1.25!
        '
        'txtValor
        '
        Me.txtValor.Border.BottomColor = System.Drawing.Color.Black
        Me.txtValor.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtValor.Border.LeftColor = System.Drawing.Color.Black
        Me.txtValor.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtValor.Border.RightColor = System.Drawing.Color.Black
        Me.txtValor.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtValor.Border.TopColor = System.Drawing.Color.Black
        Me.txtValor.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtValor.DataField = "total"
        Me.txtValor.Height = 0.1875!
        Me.txtValor.Left = 2.25!
        Me.txtValor.Name = "txtValor"
        Me.txtValor.OutputFormat = resources.GetString("txtValor.OutputFormat")
        Me.txtValor.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
        Me.txtValor.Text = Nothing
        Me.txtValor.Top = 0.0!
        Me.txtValor.Width = 1.125!
        '
        'Line
        '
        Me.Line.Border.BottomColor = System.Drawing.Color.Black
        Me.Line.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line.Border.LeftColor = System.Drawing.Color.Black
        Me.Line.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line.Border.RightColor = System.Drawing.Color.Black
        Me.Line.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line.Border.TopColor = System.Drawing.Color.Black
        Me.Line.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line.Height = 0.0!
        Me.Line.Left = 0.75!
        Me.Line.LineWeight = 1.0!
        Me.Line.Name = "Line"
        Me.Line.Top = 0.1875!
        Me.Line.Width = 2.6875!
        Me.Line.X1 = 0.75!
        Me.Line.X2 = 3.4375!
        Me.Line.Y1 = 0.1875!
        Me.Line.Y2 = 0.1875!
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label4})
        Me.ReportHeader.Height = 0.25!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'Label4
        '
        Me.Label4.Border.BottomColor = System.Drawing.Color.Black
        Me.Label4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label4.Border.LeftColor = System.Drawing.Color.Black
        Me.Label4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label4.Border.RightColor = System.Drawing.Color.Black
        Me.Label4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label4.Border.TopColor = System.Drawing.Color.Black
        Me.Label4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label4.Height = 0.1875!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 0.6875!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; "
        Me.Label4.Text = "RESUMO MOVIMENTAÇÃO ENTRADA"
        Me.Label4.Top = 0.0!
        Me.Label4.Width = 2.875!
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox2, Me.txtDespesas, Me.Label, Me.txtDinheiro, Me.Label1, Me.Label2, Me.txtSaldo, Me.Label3, Me.Line1, Me.Label5})
        Me.ReportFooter.Height = 1.333333!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'TextBox2
        '
        Me.TextBox2.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.DataField = "total"
        Me.TextBox2.Height = 0.1875!
        Me.TextBox2.Left = 2.25!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.OutputFormat = resources.GetString("TextBox2.OutputFormat")
        Me.TextBox2.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; "
        Me.TextBox2.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.TextBox2.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox2.Text = Nothing
        Me.TextBox2.Top = 0.0!
        Me.TextBox2.Width = 1.125!
        '
        'txtDespesas
        '
        Me.txtDespesas.Border.BottomColor = System.Drawing.Color.Black
        Me.txtDespesas.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDespesas.Border.LeftColor = System.Drawing.Color.Black
        Me.txtDespesas.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDespesas.Border.RightColor = System.Drawing.Color.Black
        Me.txtDespesas.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDespesas.Border.TopColor = System.Drawing.Color.Black
        Me.txtDespesas.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDespesas.Height = 0.1875!
        Me.txtDespesas.Left = 2.25!
        Me.txtDespesas.Name = "txtDespesas"
        Me.txtDespesas.OutputFormat = resources.GetString("txtDespesas.OutputFormat")
        Me.txtDespesas.Style = "ddo-char-set: 1; text-align: right; font-weight: normal; font-size: 8pt; "
        Me.txtDespesas.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.txtDespesas.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.txtDespesas.Text = Nothing
        Me.txtDespesas.Top = 0.8125!
        Me.txtDespesas.Width = 1.125!
        '
        'Label
        '
        Me.Label.Border.BottomColor = System.Drawing.Color.Black
        Me.Label.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label.Border.LeftColor = System.Drawing.Color.Black
        Me.Label.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label.Border.RightColor = System.Drawing.Color.Black
        Me.Label.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label.Border.TopColor = System.Drawing.Color.Black
        Me.Label.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label.Height = 0.1875!
        Me.Label.HyperLink = Nothing
        Me.Label.Left = 0.875!
        Me.Label.Name = "Label"
        Me.Label.Style = "ddo-char-set: 1; text-align: right; font-weight: normal; font-size: 8pt; "
        Me.Label.Text = "Despesas:"
        Me.Label.Top = 0.8125!
        Me.Label.Width = 0.75!
        '
        'txtDinheiro
        '
        Me.txtDinheiro.Border.BottomColor = System.Drawing.Color.Black
        Me.txtDinheiro.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDinheiro.Border.LeftColor = System.Drawing.Color.Black
        Me.txtDinheiro.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDinheiro.Border.RightColor = System.Drawing.Color.Black
        Me.txtDinheiro.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDinheiro.Border.TopColor = System.Drawing.Color.Black
        Me.txtDinheiro.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDinheiro.Height = 0.1875!
        Me.txtDinheiro.Left = 2.25!
        Me.txtDinheiro.Name = "txtDinheiro"
        Me.txtDinheiro.OutputFormat = resources.GetString("txtDinheiro.OutputFormat")
        Me.txtDinheiro.Style = "ddo-char-set: 1; text-align: right; font-weight: normal; font-size: 8pt; "
        Me.txtDinheiro.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.txtDinheiro.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.txtDinheiro.Text = Nothing
        Me.txtDinheiro.Top = 0.625!
        Me.txtDinheiro.Width = 1.125!
        '
        'Label1
        '
        Me.Label1.Border.BottomColor = System.Drawing.Color.Black
        Me.Label1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Border.LeftColor = System.Drawing.Color.Black
        Me.Label1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Border.RightColor = System.Drawing.Color.Black
        Me.Label1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Border.TopColor = System.Drawing.Color.Black
        Me.Label1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Height = 0.2!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.9375!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "ddo-char-set: 1; text-align: right; font-weight: normal; font-size: 8pt; "
        Me.Label1.Text = "Receita:"
        Me.Label1.Top = 0.625!
        Me.Label1.Width = 0.6875!
        '
        'Label2
        '
        Me.Label2.Border.BottomColor = System.Drawing.Color.Black
        Me.Label2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label2.Border.LeftColor = System.Drawing.Color.Black
        Me.Label2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label2.Border.RightColor = System.Drawing.Color.Black
        Me.Label2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label2.Border.TopColor = System.Drawing.Color.Black
        Me.Label2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label2.Height = 0.2!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 1.3125!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; "
        Me.Label2.Text = "Saldo:"
        Me.Label2.Top = 1.0625!
        Me.Label2.Width = 0.6875!
        '
        'txtSaldo
        '
        Me.txtSaldo.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSaldo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSaldo.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSaldo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSaldo.Border.RightColor = System.Drawing.Color.Black
        Me.txtSaldo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSaldo.Border.TopColor = System.Drawing.Color.Black
        Me.txtSaldo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSaldo.Height = 0.1875!
        Me.txtSaldo.Left = 2.25!
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.OutputFormat = resources.GetString("txtSaldo.OutputFormat")
        Me.txtSaldo.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; "
        Me.txtSaldo.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.txtSaldo.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.txtSaldo.Text = Nothing
        Me.txtSaldo.Top = 1.0625!
        Me.txtSaldo.Width = 1.125!
        '
        'Label3
        '
        Me.Label3.Border.BottomColor = System.Drawing.Color.Black
        Me.Label3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label3.Border.LeftColor = System.Drawing.Color.Black
        Me.Label3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label3.Border.RightColor = System.Drawing.Color.Black
        Me.Label3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label3.Border.TopColor = System.Drawing.Color.Black
        Me.Label3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label3.Height = 0.2!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 1.3125!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; "
        Me.Label3.Text = "Total:"
        Me.Label3.Top = 0.0!
        Me.Label3.Width = 0.6875!
        '
        'Line1
        '
        Me.Line1.Border.BottomColor = System.Drawing.Color.Black
        Me.Line1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line1.Border.LeftColor = System.Drawing.Color.Black
        Me.Line1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line1.Border.RightColor = System.Drawing.Color.Black
        Me.Line1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line1.Border.TopColor = System.Drawing.Color.Black
        Me.Line1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line1.Height = 0.0!
        Me.Line1.Left = 0.75!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 1.0625!
        Me.Line1.Width = 2.6875!
        Me.Line1.X1 = 0.75!
        Me.Line1.X2 = 3.4375!
        Me.Line1.Y1 = 1.0625!
        Me.Line1.Y2 = 1.0625!
        '
        'Label5
        '
        Me.Label5.Border.BottomColor = System.Drawing.Color.Black
        Me.Label5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label5.Border.LeftColor = System.Drawing.Color.Black
        Me.Label5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label5.Border.RightColor = System.Drawing.Color.Black
        Me.Label5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label5.Border.TopColor = System.Drawing.Color.Black
        Me.Label5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label5.Height = 0.1875!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 0.6875!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; "
        Me.Label5.Text = "RESUMO MOVIMENTAÇÃO CAIXA DINHEIRO"
        Me.Label5.Top = 0.375!
        Me.Label5.Width = 2.875!
        '
        'PageHeader
        '
        Me.PageHeader.Height = 0.0!
        Me.PageHeader.Name = "PageHeader"
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'rptResumoCaixa
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.69!
        Me.PageSettings.PaperWidth = 8.27!
        Me.PrintWidth = 3.468749!
        Me.Sections.Add(Me.ReportHeader)
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.PageFooter)
        Me.Sections.Add(Me.ReportFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule(resources.GetString("$this.StyleSheet"), "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" & _
            "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei" & _
            "ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" & _
            "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading3", "Normal"))
        CType(Me.txtForma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDespesas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDinheiro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

	#End Region
    Public despesas As Double
    Public Dinheiro As Double
    Dim l As New config
    Private Sub ReportFooter_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportFooter.Format
        txtDespesas.Text = Format(rltDespesas, "#,##0.00")
        rltDespesas = Nothing
        txtDinheiro.Text = Format(Dinheiro, "#,##0.00")
        txtSaldo.Text = Format((CDbl(Dinheiro) - CDbl(txtDespesas.Text)), "#,##0.00")
    End Sub

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        If txtForma.Text = "Dinheiro" Then
            If txtValor.Text <> "" Then
                Dinheiro = txtValor.Text
            Else
                Dinheiro = 0.0
            End If
        End If

        If txtForma.Text = "Dinheiro" Then
            txtForma.Text = "Caixa Dinheiro"
        End If

        If txtForma.Text = "Boleto Bancário" Then
            txtForma.Text = "Caixa Banco"
        End If
    End Sub


End Class
