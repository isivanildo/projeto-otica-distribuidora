Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports mrotica_util
Public Class rptRelatorioTratamentoPeriodo
Inherits DataDynamics.ActiveReports.ActiveReport3
	Public Sub New()
	MyBase.New()
		InitializeComponent()
	End Sub
	#Region "ActiveReports Designer generated code"
    Private WithEvents ReportHeader As DataDynamics.ActiveReports.ReportHeader = Nothing
    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader = Nothing
    Private WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader = Nothing
    Private WithEvents GroupHeader2 As DataDynamics.ActiveReports.GroupHeader = Nothing
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
    Private WithEvents GroupFooter2 As DataDynamics.ActiveReports.GroupFooter = Nothing
    Private WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter = Nothing
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
    Private WithEvents ReportFooter As DataDynamics.ActiveReports.ReportFooter = Nothing
	Private txtTitulo As DataDynamics.ActiveReports.TextBox
	Private TextBox As DataDynamics.ActiveReports.TextBox
	Private TextBox4 As DataDynamics.ActiveReports.TextBox
	Private txtTratamento As DataDynamics.ActiveReports.TextBox
	Private txtQ As DataDynamics.ActiveReports.TextBox
	Private Line As DataDynamics.ActiveReports.Line
	Private txtCodProduto As DataDynamics.ActiveReports.TextBox
	Private Label As DataDynamics.ActiveReports.Label
	Private TextBox5 As DataDynamics.ActiveReports.TextBox
	Private Line2 As DataDynamics.ActiveReports.Line
	Private Label1 As DataDynamics.ActiveReports.Label
	Private txtGrupo As DataDynamics.ActiveReports.TextBox
	Private Line1 As DataDynamics.ActiveReports.Line
	Private Label2 As DataDynamics.ActiveReports.Label
	Private txtFinal As DataDynamics.ActiveReports.TextBox
	Private Line3 As DataDynamics.ActiveReports.Line
	Private lblT1 As DataDynamics.ActiveReports.Label
	Private txtTotT1 As DataDynamics.ActiveReports.TextBox
	Private lblT2 As DataDynamics.ActiveReports.Label
	Private txtTotT2 As DataDynamics.ActiveReports.TextBox
	Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptRelatorioTratamentoPeriodo))
            Me.Detail = New DataDynamics.ActiveReports.Detail
            Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader
            Me.ReportFooter = New DataDynamics.ActiveReports.ReportFooter
            Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
            Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
            Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader
            Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
            Me.GroupHeader2 = New DataDynamics.ActiveReports.GroupHeader
            Me.GroupFooter2 = New DataDynamics.ActiveReports.GroupFooter
            Me.txtTitulo = New DataDynamics.ActiveReports.TextBox
            Me.TextBox = New DataDynamics.ActiveReports.TextBox
            Me.TextBox4 = New DataDynamics.ActiveReports.TextBox
            Me.txtTratamento = New DataDynamics.ActiveReports.TextBox
            Me.txtQ = New DataDynamics.ActiveReports.TextBox
            Me.Line = New DataDynamics.ActiveReports.Line
            Me.txtCodProduto = New DataDynamics.ActiveReports.TextBox
            Me.Label = New DataDynamics.ActiveReports.Label
            Me.TextBox5 = New DataDynamics.ActiveReports.TextBox
            Me.Line2 = New DataDynamics.ActiveReports.Line
            Me.Label1 = New DataDynamics.ActiveReports.Label
            Me.txtGrupo = New DataDynamics.ActiveReports.TextBox
            Me.Line1 = New DataDynamics.ActiveReports.Line
            Me.Label2 = New DataDynamics.ActiveReports.Label
            Me.txtFinal = New DataDynamics.ActiveReports.TextBox
            Me.Line3 = New DataDynamics.ActiveReports.Line
            Me.lblT1 = New DataDynamics.ActiveReports.Label
            Me.txtTotT1 = New DataDynamics.ActiveReports.TextBox
            Me.lblT2 = New DataDynamics.ActiveReports.Label
            Me.txtTotT2 = New DataDynamics.ActiveReports.TextBox
            CType(Me.txtTitulo,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox4,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtTratamento,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtQ,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtCodProduto,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox5,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label1,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtGrupo,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label2,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtFinal,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.lblT1,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtTotT1,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.lblT2,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtTotT2,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
            '
            'Detail
            '
            Me.Detail.ColumnSpacing = 0!
            Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtTratamento, Me.txtQ, Me.Line, Me.txtCodProduto})
            Me.Detail.Height = 0.2!
            Me.Detail.Name = "Detail"
            '
            'ReportHeader
            '
            Me.ReportHeader.Height = 0!
            Me.ReportHeader.Name = "ReportHeader"
            '
            'ReportFooter
            '
            Me.ReportFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label2, Me.txtFinal, Me.Line3, Me.lblT1, Me.txtTotT1, Me.lblT2, Me.txtTotT2})
            Me.ReportFooter.Height = 1.290972!
            Me.ReportFooter.Name = "ReportFooter"
            '
            'PageHeader
            '
            Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtTitulo})
            Me.PageHeader.Height = 0.3020833!
            Me.PageHeader.Name = "PageHeader"
            '
            'PageFooter
            '
            Me.PageFooter.Height = 0!
            Me.PageFooter.Name = "PageFooter"
            '
            'GroupHeader1
            '
            Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox})
            Me.GroupHeader1.DataField = "lugar"
            Me.GroupHeader1.Height = 0.2909722!
            Me.GroupHeader1.KeepTogether = true
            Me.GroupHeader1.Name = "GroupHeader1"
            '
            'GroupFooter1
            '
            Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label1, Me.txtGrupo, Me.Line1})
            Me.GroupFooter1.Height = 0.1979167!
            Me.GroupFooter1.Name = "GroupFooter1"
            '
            'GroupHeader2
            '
            Me.GroupHeader2.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox4})
            Me.GroupHeader2.DataField = "cliente"
            Me.GroupHeader2.Height = 0.25!
            Me.GroupHeader2.Name = "GroupHeader2"
            '
            'GroupFooter2
            '
            Me.GroupFooter2.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label, Me.TextBox5, Me.Line2})
            Me.GroupFooter2.Height = 0.1875!
            Me.GroupFooter2.Name = "GroupFooter2"
            '
            'txtTitulo
            '
            Me.txtTitulo.Border.BottomColor = System.Drawing.Color.Black
            Me.txtTitulo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtTitulo.Border.LeftColor = System.Drawing.Color.Black
            Me.txtTitulo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtTitulo.Border.RightColor = System.Drawing.Color.Black
            Me.txtTitulo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtTitulo.Border.TopColor = System.Drawing.Color.Black
            Me.txtTitulo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtTitulo.Height = 0.2!
            Me.txtTitulo.Left = 0.0625!
            Me.txtTitulo.Name = "txtTitulo"
            Me.txtTitulo.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; "
            Me.txtTitulo.Text = "TextBox6"
            Me.txtTitulo.Top = 0!
            Me.txtTitulo.Width = 6.4375!
            '
            'TextBox
            '
            Me.TextBox.Border.BottomColor = System.Drawing.Color.Black
            Me.TextBox.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.TextBox.Border.LeftColor = System.Drawing.Color.Black
            Me.TextBox.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.TextBox.Border.RightColor = System.Drawing.Color.Black
            Me.TextBox.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.TextBox.Border.TopColor = System.Drawing.Color.Black
            Me.TextBox.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.TextBox.DataField = "lugar"
            Me.TextBox.Height = 0.2!
            Me.TextBox.Left = 0.08333326!
            Me.TextBox.Name = "TextBox"
            Me.TextBox.Style = "ddo-char-set: 1; font-weight: bold; "
            Me.TextBox.Text = "TextBox"
            Me.TextBox.Top = 0!
            Me.TextBox.Width = 1.854167!
            '
            'TextBox4
            '
            Me.TextBox4.Border.BottomColor = System.Drawing.Color.Black
            Me.TextBox4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.TextBox4.Border.LeftColor = System.Drawing.Color.Black
            Me.TextBox4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.TextBox4.Border.RightColor = System.Drawing.Color.Black
            Me.TextBox4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.TextBox4.Border.TopColor = System.Drawing.Color.Black
            Me.TextBox4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.TextBox4.DataField = "cliente"
            Me.TextBox4.Height = 0.2!
            Me.TextBox4.Left = 0.3958333!
            Me.TextBox4.Name = "TextBox4"
            Me.TextBox4.Style = "ddo-char-set: 1; font-weight: bold; "
            Me.TextBox4.Text = "TextBox"
            Me.TextBox4.Top = 0!
            Me.TextBox4.Width = 3.354167!
            '
            'txtTratamento
            '
            Me.txtTratamento.Border.BottomColor = System.Drawing.Color.Black
            Me.txtTratamento.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtTratamento.Border.LeftColor = System.Drawing.Color.Black
            Me.txtTratamento.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtTratamento.Border.RightColor = System.Drawing.Color.Black
            Me.txtTratamento.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtTratamento.Border.TopColor = System.Drawing.Color.Black
            Me.txtTratamento.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtTratamento.DataField = "tratamento"
            Me.txtTratamento.Height = 0.2!
            Me.txtTratamento.Left = 0.75!
            Me.txtTratamento.Name = "txtTratamento"
            Me.txtTratamento.Style = ""
            Me.txtTratamento.Text = "TextBox"
            Me.txtTratamento.Top = 0!
            Me.txtTratamento.Width = 2.625!
            '
            'txtQ
            '
            Me.txtQ.Border.BottomColor = System.Drawing.Color.Black
            Me.txtQ.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtQ.Border.LeftColor = System.Drawing.Color.Black
            Me.txtQ.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtQ.Border.RightColor = System.Drawing.Color.Black
            Me.txtQ.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtQ.Border.TopColor = System.Drawing.Color.Black
            Me.txtQ.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtQ.DataField = "quant"
            Me.txtQ.Height = 0.2!
            Me.txtQ.Left = 4.354167!
            Me.txtQ.Name = "txtQ"
            Me.txtQ.Style = "text-align: right; "
            Me.txtQ.Text = "TextBox"
            Me.txtQ.Top = 0!
            Me.txtQ.Width = 0.3333335!
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
            Me.Line.Height = 0!
            Me.Line.Left = 0.75!
            Me.Line.LineWeight = 1!
            Me.Line.Name = "Line"
            Me.Line.Top = 0!
            Me.Line.Width = 4!
            Me.Line.X1 = 0.75!
            Me.Line.X2 = 4.75!
            Me.Line.Y1 = 0!
            Me.Line.Y2 = 0!
            '
            'txtCodProduto
            '
            Me.txtCodProduto.Border.BottomColor = System.Drawing.Color.Black
            Me.txtCodProduto.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtCodProduto.Border.LeftColor = System.Drawing.Color.Black
            Me.txtCodProduto.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtCodProduto.Border.RightColor = System.Drawing.Color.Black
            Me.txtCodProduto.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtCodProduto.Border.TopColor = System.Drawing.Color.Black
            Me.txtCodProduto.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtCodProduto.DataField = "cod_produto"
            Me.txtCodProduto.Height = 0.2!
            Me.txtCodProduto.Left = 5.0625!
            Me.txtCodProduto.Name = "txtCodProduto"
            Me.txtCodProduto.Style = ""
            Me.txtCodProduto.Text = "TextBox"
            Me.txtCodProduto.Top = 0!
            Me.txtCodProduto.Visible = false
            Me.txtCodProduto.Width = 0.4375!
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
            Me.Label.Height = 0.2!
            Me.Label.HyperLink = Nothing
            Me.Label.Left = 3.3125!
            Me.Label.Name = "Label"
            Me.Label.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
            Me.Label.Text = "Total Cliente:"
            Me.Label.Top = 0!
            Me.Label.Width = 1!
            '
            'TextBox5
            '
            Me.TextBox5.Border.BottomColor = System.Drawing.Color.Black
            Me.TextBox5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.TextBox5.Border.LeftColor = System.Drawing.Color.Black
            Me.TextBox5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.TextBox5.Border.RightColor = System.Drawing.Color.Black
            Me.TextBox5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.TextBox5.Border.TopColor = System.Drawing.Color.Black
            Me.TextBox5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.TextBox5.DataField = "quant"
            Me.TextBox5.Height = 0.2!
            Me.TextBox5.Left = 4.354167!
            Me.TextBox5.Name = "TextBox5"
            Me.TextBox5.Style = "text-align: right; "
            Me.TextBox5.SummaryGroup = "GroupHeader2"
            Me.TextBox5.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
            Me.TextBox5.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
            Me.TextBox5.Text = "TextBox"
            Me.TextBox5.Top = 0!
            Me.TextBox5.Width = 0.3333335!
            '
            'Line2
            '
            Me.Line2.Border.BottomColor = System.Drawing.Color.Black
            Me.Line2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.Line2.Border.LeftColor = System.Drawing.Color.Black
            Me.Line2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.Line2.Border.RightColor = System.Drawing.Color.Black
            Me.Line2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.Line2.Border.TopColor = System.Drawing.Color.Black
            Me.Line2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.Line2.Height = 0!
            Me.Line2.Left = 0.75!
            Me.Line2.LineWeight = 1!
            Me.Line2.Name = "Line2"
            Me.Line2.Top = 0!
            Me.Line2.Width = 4!
            Me.Line2.X1 = 0.75!
            Me.Line2.X2 = 4.75!
            Me.Line2.Y1 = 0!
            Me.Line2.Y2 = 0!
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
            Me.Label1.Left = 3.3125!
            Me.Label1.Name = "Label1"
            Me.Label1.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
            Me.Label1.Text = "Total Grupo:"
            Me.Label1.Top = 0!
            Me.Label1.Width = 1!
            '
            'txtGrupo
            '
            Me.txtGrupo.Border.BottomColor = System.Drawing.Color.Black
            Me.txtGrupo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtGrupo.Border.LeftColor = System.Drawing.Color.Black
            Me.txtGrupo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtGrupo.Border.RightColor = System.Drawing.Color.Black
            Me.txtGrupo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtGrupo.Border.TopColor = System.Drawing.Color.Black
            Me.txtGrupo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtGrupo.DataField = "quant"
            Me.txtGrupo.Height = 0.2!
            Me.txtGrupo.Left = 4.354167!
            Me.txtGrupo.Name = "txtGrupo"
            Me.txtGrupo.Style = "text-align: right; "
            Me.txtGrupo.SummaryGroup = "GroupHeader1"
            Me.txtGrupo.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
            Me.txtGrupo.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
            Me.txtGrupo.Text = "TextBox"
            Me.txtGrupo.Top = 0!
            Me.txtGrupo.Width = 0.3333335!
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
            Me.Line1.Height = 0!
            Me.Line1.Left = 0.75!
            Me.Line1.LineWeight = 1!
            Me.Line1.Name = "Line1"
            Me.Line1.Top = 0!
            Me.Line1.Width = 4!
            Me.Line1.X1 = 0.75!
            Me.Line1.X2 = 4.75!
            Me.Line1.Y1 = 0!
            Me.Line1.Y2 = 0!
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
            Me.Label2.Left = 3.3125!
            Me.Label2.Name = "Label2"
            Me.Label2.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
            Me.Label2.Text = "Total Período:"
            Me.Label2.Top = 0.625!
            Me.Label2.Width = 1!
            '
            'txtFinal
            '
            Me.txtFinal.Border.BottomColor = System.Drawing.Color.Black
            Me.txtFinal.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtFinal.Border.LeftColor = System.Drawing.Color.Black
            Me.txtFinal.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtFinal.Border.RightColor = System.Drawing.Color.Black
            Me.txtFinal.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtFinal.Border.TopColor = System.Drawing.Color.Black
            Me.txtFinal.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtFinal.DataField = "quant"
            Me.txtFinal.Height = 0.2!
            Me.txtFinal.Left = 4.359375!
            Me.txtFinal.Name = "txtFinal"
            Me.txtFinal.Style = "text-align: right; "
            Me.txtFinal.SummaryGroup = "GroupHeader1"
            Me.txtFinal.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
            Me.txtFinal.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
            Me.txtFinal.Text = "TextBox"
            Me.txtFinal.Top = 0.625!
            Me.txtFinal.Width = 0.3333335!
            '
            'Line3
            '
            Me.Line3.Border.BottomColor = System.Drawing.Color.Black
            Me.Line3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.Line3.Border.LeftColor = System.Drawing.Color.Black
            Me.Line3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.Line3.Border.RightColor = System.Drawing.Color.Black
            Me.Line3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.Line3.Border.TopColor = System.Drawing.Color.Black
            Me.Line3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.Line3.Height = 0!
            Me.Line3.Left = 0.8125!
            Me.Line3.LineWeight = 1!
            Me.Line3.Name = "Line3"
            Me.Line3.Top = 0!
            Me.Line3.Width = 4!
            Me.Line3.X1 = 0.8125!
            Me.Line3.X2 = 4.8125!
            Me.Line3.Y1 = 0!
            Me.Line3.Y2 = 0!
            '
            'lblT1
            '
            Me.lblT1.Border.BottomColor = System.Drawing.Color.Black
            Me.lblT1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.lblT1.Border.LeftColor = System.Drawing.Color.Black
            Me.lblT1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.lblT1.Border.RightColor = System.Drawing.Color.Black
            Me.lblT1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.lblT1.Border.TopColor = System.Drawing.Color.Black
            Me.lblT1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.lblT1.Height = 0.2!
            Me.lblT1.HyperLink = Nothing
            Me.lblT1.Left = 3!
            Me.lblT1.Name = "lblT1"
            Me.lblT1.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
            Me.lblT1.Text = ""
            Me.lblT1.Top = 0.0625!
            Me.lblT1.Width = 1.3125!
            '
            'txtTotT1
            '
            Me.txtTotT1.Border.BottomColor = System.Drawing.Color.Black
            Me.txtTotT1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtTotT1.Border.LeftColor = System.Drawing.Color.Black
            Me.txtTotT1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtTotT1.Border.RightColor = System.Drawing.Color.Black
            Me.txtTotT1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtTotT1.Border.TopColor = System.Drawing.Color.Black
            Me.txtTotT1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtTotT1.DataField = "quant"
            Me.txtTotT1.Height = 0.2!
            Me.txtTotT1.Left = 4.359375!
            Me.txtTotT1.Name = "txtTotT1"
            Me.txtTotT1.Style = "text-align: right; "
            Me.txtTotT1.SummaryGroup = "GroupHeader1"
            Me.txtTotT1.Top = 0.0625!
            Me.txtTotT1.Width = 0.3333335!
            '
            'lblT2
            '
            Me.lblT2.Border.BottomColor = System.Drawing.Color.Black
            Me.lblT2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.lblT2.Border.LeftColor = System.Drawing.Color.Black
            Me.lblT2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.lblT2.Border.RightColor = System.Drawing.Color.Black
            Me.lblT2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.lblT2.Border.TopColor = System.Drawing.Color.Black
            Me.lblT2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.lblT2.Height = 0.2!
            Me.lblT2.HyperLink = Nothing
            Me.lblT2.Left = 3!
            Me.lblT2.Name = "lblT2"
            Me.lblT2.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
            Me.lblT2.Text = ""
            Me.lblT2.Top = 0.3125!
            Me.lblT2.Width = 1.3125!
            '
            'txtTotT2
            '
            Me.txtTotT2.Border.BottomColor = System.Drawing.Color.Black
            Me.txtTotT2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtTotT2.Border.LeftColor = System.Drawing.Color.Black
            Me.txtTotT2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtTotT2.Border.RightColor = System.Drawing.Color.Black
            Me.txtTotT2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtTotT2.Border.TopColor = System.Drawing.Color.Black
            Me.txtTotT2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtTotT2.DataField = "quant"
            Me.txtTotT2.Height = 0.2!
            Me.txtTotT2.Left = 4.359375!
            Me.txtTotT2.Name = "txtTotT2"
            Me.txtTotT2.Style = "text-align: right; "
            Me.txtTotT2.SummaryGroup = "GroupHeader1"
            Me.txtTotT2.Top = 0.325!
            Me.txtTotT2.Width = 0.3333335!
            '
            'ActiveReport31
            '
            Me.MasterReport = false
            Me.PageSettings.PaperHeight = 11.69!
            Me.PageSettings.PaperWidth = 8.27!
            Me.Sections.Add(Me.ReportHeader)
            Me.Sections.Add(Me.PageHeader)
            Me.Sections.Add(Me.GroupHeader1)
            Me.Sections.Add(Me.GroupHeader2)
            Me.Sections.Add(Me.Detail)
            Me.Sections.Add(Me.GroupFooter2)
            Me.Sections.Add(Me.GroupFooter1)
            Me.Sections.Add(Me.PageFooter)
            Me.Sections.Add(Me.ReportFooter)
            Me.StyleSheet.Add(New DDCssLib.StyleSheetRule(resources.GetString("$this.StyleSheet"), "Normal"))
            Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo"& _ 
                        "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading1", "Normal"))
            Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei"& _ 
                        "ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading2", "Normal"))
            Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo"& _ 
                        "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading3", "Normal"))
            CType(Me.txtTitulo,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox4,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtTratamento,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtQ,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtCodProduto,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox5,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label1,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtGrupo,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label2,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtFinal,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.lblT1,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtTotT1,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.lblT2,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtTotT2,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me,System.ComponentModel.ISupportInitialize).EndInit
        
	End Sub

	#End Region
    Public titulo As String
    Public final As Double = 0
    Public tipoRelatorio As tipo
    Dim Alize, A2, opt, easy, AR As Integer
    Const Talize As Integer = 16087
    Const TA2 As Integer = 36915
    Const TOPT As Integer = 16079
    Const TEASY As Integer = 36914
    Const TAR As Integer = 27366
    Public Enum tipo
        Alize_A2 = 0
        OPT_EASY = 1
        Anti_Risco = 2
    End Enum

    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        txtTitulo.Text = titulo
    End Sub

    Private Sub ReportFooter_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportFooter.Format
        If tipoRelatorio = tipo.Alize_A2 Then
            lblT1.Text = "Crizal Alizé"
            txtTotT1.Text = Alize
            lblT2.Text = "Criza A2"
            txtTotT2.Text = A2
        End If
        If tipoRelatorio = tipo.OPT_EASY Then
            lblT1.Text = "Optikot"
            txtTotT1.Text = opt
            lblT2.Text = "Optikot Easy Clean"
            txtTotT2.Text = easy
        End If
        If tipoRelatorio = tipo.Anti_Risco Then
            lblT1.Text = "Anti-Risco"
            txtTotT1.Text = AR
            lblT2.Text = ""
            txtTotT2.Text = 0
        End If

    End Sub

    Private Sub GroupFooter1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupFooter1.Format
        final = final + CDbl(txtGrupo.Text)
    End Sub

    Private Sub GroupHeader2_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupHeader2.Format

    End Sub

    Private Sub rptRelatorioTratamentoPeriodo_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
      
    End Sub

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        Select Case txtCodProduto.Text
            Case Talize
                Alize = Alize + txtQ.Text
            Case TA2
                A2 = A2 + txtQ.Text
            Case TOPT
                opt = opt + txtQ.Text
            Case TEASY
                easy = easy + txtQ.Text
            Case TAR
                AR = AR + txtQ.Text
        End Select
    End Sub

    Private Sub GroupFooter2_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupFooter2.Format

    End Sub

    Private Sub GroupHeader1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupHeader1.Format

    End Sub
End Class
