Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class rptListaPontuacao
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
	Private lblTitulo As DataDynamics.ActiveReports.Label
	Private TextBox As DataDynamics.ActiveReports.TextBox
	Private TextBox1 As DataDynamics.ActiveReports.TextBox
	Private Label2 As DataDynamics.ActiveReports.Label
	Private Label3 As DataDynamics.ActiveReports.Label
	Private Label4 As DataDynamics.ActiveReports.Label
	Private Label5 As DataDynamics.ActiveReports.Label
	Private TextBox2 As DataDynamics.ActiveReports.TextBox
	Private TextBox3 As DataDynamics.ActiveReports.TextBox
	Private TextBox4 As DataDynamics.ActiveReports.TextBox
	Private TextBox7 As DataDynamics.ActiveReports.TextBox
	Private TextBox8 As DataDynamics.ActiveReports.TextBox
	Private Line1 As DataDynamics.ActiveReports.Line
	Private TextBox5 As DataDynamics.ActiveReports.TextBox
	Private Label As DataDynamics.ActiveReports.Label
	Private TextBox6 As DataDynamics.ActiveReports.TextBox
	Private Line As DataDynamics.ActiveReports.Line
	Private Line2 As DataDynamics.ActiveReports.Line
	Private Label1 As DataDynamics.ActiveReports.Label
	Private Line3 As DataDynamics.ActiveReports.Line
	Private lblPagina As DataDynamics.ActiveReports.Label
	Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptListaPontuacao))
            Me.Detail = New DataDynamics.ActiveReports.Detail
            Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader
            Me.ReportFooter = New DataDynamics.ActiveReports.ReportFooter
            Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
            Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
            Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader
            Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
            Me.GroupHeader2 = New DataDynamics.ActiveReports.GroupHeader
            Me.GroupFooter2 = New DataDynamics.ActiveReports.GroupFooter
            Me.lblTitulo = New DataDynamics.ActiveReports.Label
            Me.TextBox = New DataDynamics.ActiveReports.TextBox
            Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
            Me.Label2 = New DataDynamics.ActiveReports.Label
            Me.Label3 = New DataDynamics.ActiveReports.Label
            Me.Label4 = New DataDynamics.ActiveReports.Label
            Me.Label5 = New DataDynamics.ActiveReports.Label
            Me.TextBox2 = New DataDynamics.ActiveReports.TextBox
            Me.TextBox3 = New DataDynamics.ActiveReports.TextBox
            Me.TextBox4 = New DataDynamics.ActiveReports.TextBox
            Me.TextBox7 = New DataDynamics.ActiveReports.TextBox
            Me.TextBox8 = New DataDynamics.ActiveReports.TextBox
            Me.Line1 = New DataDynamics.ActiveReports.Line
            Me.TextBox5 = New DataDynamics.ActiveReports.TextBox
            Me.Label = New DataDynamics.ActiveReports.Label
            Me.TextBox6 = New DataDynamics.ActiveReports.TextBox
            Me.Line = New DataDynamics.ActiveReports.Line
            Me.Line2 = New DataDynamics.ActiveReports.Line
            Me.Label1 = New DataDynamics.ActiveReports.Label
            Me.Line3 = New DataDynamics.ActiveReports.Line
            Me.lblPagina = New DataDynamics.ActiveReports.Label
            CType(Me.lblTitulo,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox1,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label2,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label3,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label4,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label5,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox2,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox3,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox4,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox7,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox8,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox5,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox6,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label1,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.lblPagina,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
            '
            'Detail
            '
            Me.Detail.ColumnSpacing = 0!
            Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox2, Me.TextBox3, Me.TextBox4, Me.TextBox7, Me.TextBox8, Me.Line1})
            Me.Detail.Height = 0.1979167!
            Me.Detail.Name = "Detail"
            '
            'ReportHeader
            '
            Me.ReportHeader.Height = 0!
            Me.ReportHeader.Name = "ReportHeader"
            '
            'ReportFooter
            '
            Me.ReportFooter.Height = 0!
            Me.ReportFooter.Name = "ReportFooter"
            '
            'PageHeader
            '
            Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblTitulo})
            Me.PageHeader.Height = 0.4784722!
            Me.PageHeader.Name = "PageHeader"
            '
            'PageFooter
            '
            Me.PageFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblPagina})
            Me.PageFooter.Height = 0.25!
            Me.PageFooter.Name = "PageFooter"
            '
            'GroupHeader1
            '
            Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox})
            Me.GroupHeader1.DataField = "Fabricante"
            Me.GroupHeader1.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
            Me.GroupHeader1.Height = 0.2291667!
            Me.GroupHeader1.Name = "GroupHeader1"
            '
            'GroupFooter1
            '
            Me.GroupFooter1.Height = 0!
            Me.GroupFooter1.Name = "GroupFooter1"
            '
            'GroupHeader2
            '
            Me.GroupHeader2.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox1, Me.Label2, Me.Label3, Me.Label4, Me.Label5})
            Me.GroupHeader2.DataField = "Vendedora"
            Me.GroupHeader2.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
            Me.GroupHeader2.Height = 0.5416667!
            Me.GroupHeader2.Name = "GroupHeader2"
            '
            'GroupFooter2
            '
            Me.GroupFooter2.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox5, Me.Label, Me.TextBox6, Me.Line, Me.Line2, Me.Label1, Me.Line3})
            Me.GroupFooter2.Height = 1.25!
            Me.GroupFooter2.Name = "GroupFooter2"
            '
            'lblTitulo
            '
            Me.lblTitulo.Border.BottomColor = System.Drawing.Color.Black
            Me.lblTitulo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.lblTitulo.Border.LeftColor = System.Drawing.Color.Black
            Me.lblTitulo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.lblTitulo.Border.RightColor = System.Drawing.Color.Black
            Me.lblTitulo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.lblTitulo.Border.TopColor = System.Drawing.Color.Black
            Me.lblTitulo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.lblTitulo.Height = 0.4375!
            Me.lblTitulo.HyperLink = Nothing
            Me.lblTitulo.Left = 0!
            Me.lblTitulo.Name = "lblTitulo"
            Me.lblTitulo.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 12pt; "
            Me.lblTitulo.Text = ""
            Me.lblTitulo.Top = 0!
            Me.lblTitulo.Width = 6.875!
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
            Me.TextBox.DataField = "Fabricante"
            Me.TextBox.Height = 0.2!
            Me.TextBox.Left = 0!
            Me.TextBox.Name = "TextBox"
            Me.TextBox.Style = "ddo-char-set: 1; font-weight: bold; "
            Me.TextBox.Text = "TextBox"
            Me.TextBox.Top = 0!
            Me.TextBox.Width = 1!
            '
            'TextBox1
            '
            Me.TextBox1.Border.BottomColor = System.Drawing.Color.Black
            Me.TextBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.TextBox1.Border.LeftColor = System.Drawing.Color.Black
            Me.TextBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.TextBox1.Border.RightColor = System.Drawing.Color.Black
            Me.TextBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.TextBox1.Border.TopColor = System.Drawing.Color.Black
            Me.TextBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.TextBox1.DataField = "Vendedora"
            Me.TextBox1.Height = 0.2!
            Me.TextBox1.Left = 0.3125!
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Style = "ddo-char-set: 1; font-weight: bold; "
            Me.TextBox1.Text = "TextBox"
            Me.TextBox1.Top = 0!
            Me.TextBox1.Width = 2.895833!
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
            Me.Label2.Left = 0.375!
            Me.Label2.Name = "Label2"
            Me.Label2.Style = ""
            Me.Label2.Text = "Produto"
            Me.Label2.Top = 0.3125!
            Me.Label2.Width = 1!
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
            Me.Label3.Left = 3.3125!
            Me.Label3.Name = "Label3"
            Me.Label3.Style = ""
            Me.Label3.Text = "Número da OS"
            Me.Label3.Top = 0.3125!
            Me.Label3.Width = 1.125!
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
            Me.Label4.Height = 0.2!
            Me.Label4.HyperLink = Nothing
            Me.Label4.Left = 4.6875!
            Me.Label4.Name = "Label4"
            Me.Label4.Style = "text-align: right; "
            Me.Label4.Text = "Pontos"
            Me.Label4.Top = 0.3125!
            Me.Label4.Width = 0.5!
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
            Me.Label5.Height = 0.2!
            Me.Label5.HyperLink = Nothing
            Me.Label5.Left = 5.3125!
            Me.Label5.Name = "Label5"
            Me.Label5.Style = "text-align: left; "
            Me.Label5.Text = "Tratamento"
            Me.Label5.Top = 0.3125!
            Me.Label5.Width = 0.9375!
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
            Me.TextBox2.DataField = "nome_comercial"
            Me.TextBox2.Height = 0.2!
            Me.TextBox2.Left = 0.375!
            Me.TextBox2.Name = "TextBox2"
            Me.TextBox2.Style = ""
            Me.TextBox2.Text = "TextBox"
            Me.TextBox2.Top = 0!
            Me.TextBox2.Width = 2.8125!
            '
            'TextBox3
            '
            Me.TextBox3.Border.BottomColor = System.Drawing.Color.Black
            Me.TextBox3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.TextBox3.Border.LeftColor = System.Drawing.Color.Black
            Me.TextBox3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.TextBox3.Border.RightColor = System.Drawing.Color.Black
            Me.TextBox3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.TextBox3.Border.TopColor = System.Drawing.Color.Black
            Me.TextBox3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.TextBox3.DataField = "Tratamento"
            Me.TextBox3.Height = 0.2!
            Me.TextBox3.Left = 5.25!
            Me.TextBox3.Name = "TextBox3"
            Me.TextBox3.Style = ""
            Me.TextBox3.Text = "TextBox"
            Me.TextBox3.Top = 0!
            Me.TextBox3.Width = 1.25!
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
            Me.TextBox4.DataField = "pontuacao"
            Me.TextBox4.Height = 0.2!
            Me.TextBox4.Left = 4.8125!
            Me.TextBox4.Name = "TextBox4"
            Me.TextBox4.Style = "text-align: right; "
            Me.TextBox4.Text = "TextBox"
            Me.TextBox4.Top = 0!
            Me.TextBox4.Width = 0.375!
            '
            'TextBox7
            '
            Me.TextBox7.Border.BottomColor = System.Drawing.Color.Black
            Me.TextBox7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.TextBox7.Border.LeftColor = System.Drawing.Color.Black
            Me.TextBox7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.TextBox7.Border.RightColor = System.Drawing.Color.Black
            Me.TextBox7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.TextBox7.Border.TopColor = System.Drawing.Color.Black
            Me.TextBox7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.TextBox7.DataField = "id_filial"
            Me.TextBox7.Height = 0.2!
            Me.TextBox7.Left = 3.3125!
            Me.TextBox7.Name = "TextBox7"
            Me.TextBox7.Style = "text-align: right; "
            Me.TextBox7.Text = "TextBox"
            Me.TextBox7.Top = 0!
            Me.TextBox7.Width = 0.375!
            '
            'TextBox8
            '
            Me.TextBox8.Border.BottomColor = System.Drawing.Color.Black
            Me.TextBox8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.TextBox8.Border.LeftColor = System.Drawing.Color.Black
            Me.TextBox8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.TextBox8.Border.RightColor = System.Drawing.Color.Black
            Me.TextBox8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.TextBox8.Border.TopColor = System.Drawing.Color.Black
            Me.TextBox8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.TextBox8.DataField = "cod_os"
            Me.TextBox8.Height = 0.2!
            Me.TextBox8.Left = 3.75!
            Me.TextBox8.Name = "TextBox8"
            Me.TextBox8.Style = "text-align: left; "
            Me.TextBox8.Text = "TextBox"
            Me.TextBox8.Top = 0!
            Me.TextBox8.Width = 0.6875!
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
            Me.Line1.Left = 0.375!
            Me.Line1.LineStyle = DataDynamics.ActiveReports.LineStyle.Dash
            Me.Line1.LineWeight = 1!
            Me.Line1.Name = "Line1"
            Me.Line1.Top = 0!
            Me.Line1.Width = 6.125!
            Me.Line1.X1 = 0.375!
            Me.Line1.X2 = 6.5!
            Me.Line1.Y1 = 0!
            Me.Line1.Y2 = 0!
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
            Me.TextBox5.DataField = "pontuacao"
            Me.TextBox5.Height = 0.2!
            Me.TextBox5.Left = 4.8125!
            Me.TextBox5.Name = "TextBox5"
            Me.TextBox5.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
            Me.TextBox5.SummaryGroup = "GroupHeader2"
            Me.TextBox5.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
            Me.TextBox5.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
            Me.TextBox5.Text = "TextBox"
            Me.TextBox5.Top = 0!
            Me.TextBox5.Width = 0.375!
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
            Me.Label.Left = 3.5625!
            Me.Label.Name = "Label"
            Me.Label.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
            Me.Label.Text = "Total de Pontos"
            Me.Label.Top = 0!
            Me.Label.Width = 1.1875!
            '
            'TextBox6
            '
            Me.TextBox6.Border.BottomColor = System.Drawing.Color.Black
            Me.TextBox6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.TextBox6.Border.LeftColor = System.Drawing.Color.Black
            Me.TextBox6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.TextBox6.Border.RightColor = System.Drawing.Color.Black
            Me.TextBox6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.TextBox6.Border.TopColor = System.Drawing.Color.Black
            Me.TextBox6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.TextBox6.DataField = "Vendedora"
            Me.TextBox6.Height = 0.2!
            Me.TextBox6.Left = 1.9375!
            Me.TextBox6.Name = "TextBox6"
            Me.TextBox6.Style = "text-align: center; "
            Me.TextBox6.Text = "TextBox"
            Me.TextBox6.Top = 0.9375!
            Me.TextBox6.Width = 2.895833!
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
            Me.Line.Left = 1.8125!
            Me.Line.LineWeight = 1!
            Me.Line.Name = "Line"
            Me.Line.Top = 0.875!
            Me.Line.Width = 3.125!
            Me.Line.X1 = 1.8125!
            Me.Line.X2 = 4.9375!
            Me.Line.Y1 = 0.875!
            Me.Line.Y2 = 0.875!
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
            Me.Line2.Left = 0.375!
            Me.Line2.LineWeight = 1!
            Me.Line2.Name = "Line2"
            Me.Line2.Top = 0!
            Me.Line2.Width = 6.125!
            Me.Line2.X1 = 0.375!
            Me.Line2.X2 = 6.5!
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
            Me.Label1.Left = 0.1875!
            Me.Label1.Name = "Label1"
            Me.Label1.Style = ""
            Me.Label1.Text = "Declaro que recebi as pontuações acima:"
            Me.Label1.Top = 0.3125!
            Me.Label1.Width = 2.6875!
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
            Me.Line3.Left = 0!
            Me.Line3.LineStyle = DataDynamics.ActiveReports.LineStyle.Dash
            Me.Line3.LineWeight = 1!
            Me.Line3.Name = "Line3"
            Me.Line3.Top = 1.1875!
            Me.Line3.Width = 6.8125!
            Me.Line3.X1 = 0!
            Me.Line3.X2 = 6.8125!
            Me.Line3.Y1 = 1.1875!
            Me.Line3.Y2 = 1.1875!
            '
            'lblPagina
            '
            Me.lblPagina.Border.BottomColor = System.Drawing.Color.Black
            Me.lblPagina.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.lblPagina.Border.LeftColor = System.Drawing.Color.Black
            Me.lblPagina.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.lblPagina.Border.RightColor = System.Drawing.Color.Black
            Me.lblPagina.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.lblPagina.Border.TopColor = System.Drawing.Color.Black
            Me.lblPagina.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.lblPagina.Height = 0.2!
            Me.lblPagina.HyperLink = Nothing
            Me.lblPagina.Left = 5.375!
            Me.lblPagina.Name = "lblPagina"
            Me.lblPagina.Style = "text-align: right; "
            Me.lblPagina.Text = ""
            Me.lblPagina.Top = 0!
            Me.lblPagina.Width = 1.4375!
            '
            'ActiveReport31
            '
            Me.MasterReport = false
            Me.PageSettings.PaperHeight = 11.69!
            Me.PageSettings.PaperWidth = 8.27!
            Me.PrintWidth = 6.854167!
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
            CType(Me.lblTitulo,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox1,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label2,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label3,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label4,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label5,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox2,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox3,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox4,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox7,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox8,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox5,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox6,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label1,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.lblPagina,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me,System.ComponentModel.ISupportInitialize).EndInit
        
	End Sub

	#End Region
    Public titulo As String
    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        lblTitulo.Text = titulo
    End Sub

    Private Sub PageFooter_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageFooter.Format
        lblPagina.Text = "Página " & Me.PageNumber
    End Sub
End Class
