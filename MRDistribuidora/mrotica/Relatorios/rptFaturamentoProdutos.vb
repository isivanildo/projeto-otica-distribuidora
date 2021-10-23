Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports mrotica_util

Public Class rptFaturamentoProdutos
    Inherits DataDynamics.ActiveReports.ActiveReport3
    Public completo As Boolean = True
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
	Private Label1 As DataDynamics.ActiveReports.Label
	Private Label2 As DataDynamics.ActiveReports.Label
	Private Label3 As DataDynamics.ActiveReports.Label
	Private Label4 As DataDynamics.ActiveReports.Label
	Private Label5 As DataDynamics.ActiveReports.Label
	Private Label6 As DataDynamics.ActiveReports.Label
	Private Label7 As DataDynamics.ActiveReports.Label
	Private Label As DataDynamics.ActiveReports.Label
	Private Label8 As DataDynamics.ActiveReports.Label
	Private txtFabricante As DataDynamics.ActiveReports.TextBox
	Private TextBox As DataDynamics.ActiveReports.TextBox
	Private TextBox1 As DataDynamics.ActiveReports.TextBox
	Private TextBox2 As DataDynamics.ActiveReports.TextBox
	Private TextBox3 As DataDynamics.ActiveReports.TextBox
	Private TextBox4 As DataDynamics.ActiveReports.TextBox
	Private TextBox5 As DataDynamics.ActiveReports.TextBox
	Private Line As DataDynamics.ActiveReports.Line
    Private txtCompra As DataDynamics.ActiveReports.TextBox
	Private TextBox7 As DataDynamics.ActiveReports.TextBox
    Private txtMargem As DataDynamics.ActiveReports.TextBox
    Private txtPorcentagem As DataDynamics.ActiveReports.TextBox
    Private TextBox24 As DataDynamics.ActiveReports.TextBox
    Private TextBox25 As DataDynamics.ActiveReports.TextBox
    Private TextBox26 As DataDynamics.ActiveReports.TextBox
    Private TextBox27 As DataDynamics.ActiveReports.TextBox
    Private txtSubCompra As DataDynamics.ActiveReports.TextBox
    Private TextBox29 As DataDynamics.ActiveReports.TextBox
    Private txtSubMargem As DataDynamics.ActiveReports.TextBox
    Private Line5 As DataDynamics.ActiveReports.Line
    Private Line6 As DataDynamics.ActiveReports.Line
    Private TextBox16 As DataDynamics.ActiveReports.TextBox
    Private TextBox17 As DataDynamics.ActiveReports.TextBox
    Private TextBox18 As DataDynamics.ActiveReports.TextBox
    Private TextBox19 As DataDynamics.ActiveReports.TextBox
    Private txtTotalCompra As DataDynamics.ActiveReports.TextBox
    Private TextBox21 As DataDynamics.ActiveReports.TextBox
    Private txtTotalMargem As DataDynamics.ActiveReports.TextBox
    Private Line1 As DataDynamics.ActiveReports.Line
    Private Line2 As DataDynamics.ActiveReports.Line
    Private lblPagina As DataDynamics.ActiveReports.Label
    Private TextBox9 As DataDynamics.ActiveReports.TextBox
    Private TextBox10 As DataDynamics.ActiveReports.TextBox
    Private TextBox11 As DataDynamics.ActiveReports.TextBox
    Private TextBox12 As DataDynamics.ActiveReports.TextBox
    Private TextBox13 As DataDynamics.ActiveReports.TextBox
    Private TextBox14 As DataDynamics.ActiveReports.TextBox
    Private TextBox15 As DataDynamics.ActiveReports.TextBox
    Private Line3 As DataDynamics.ActiveReports.Line
    Private Line4 As DataDynamics.ActiveReports.Line
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptFaturamentoProdutos))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.TextBox = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox()
        Me.Line = New DataDynamics.ActiveReports.Line()
        Me.txtCompra = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox7 = New DataDynamics.ActiveReports.TextBox()
        Me.txtMargem = New DataDynamics.ActiveReports.TextBox()
        Me.txtPorcentagem = New DataDynamics.ActiveReports.TextBox()
        Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader()
        Me.lblTitulo = New DataDynamics.ActiveReports.Label()
        Me.ReportFooter = New DataDynamics.ActiveReports.ReportFooter()
        Me.TextBox9 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox10 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox11 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox12 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox13 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox14 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox15 = New DataDynamics.ActiveReports.TextBox()
        Me.Line3 = New DataDynamics.ActiveReports.Line()
        Me.Line4 = New DataDynamics.ActiveReports.Line()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.Label3 = New DataDynamics.ActiveReports.Label()
        Me.Label4 = New DataDynamics.ActiveReports.Label()
        Me.Label5 = New DataDynamics.ActiveReports.Label()
        Me.Label6 = New DataDynamics.ActiveReports.Label()
        Me.Label7 = New DataDynamics.ActiveReports.Label()
        Me.Label = New DataDynamics.ActiveReports.Label()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.lblPagina = New DataDynamics.ActiveReports.Label()
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader()
        Me.Label8 = New DataDynamics.ActiveReports.Label()
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter()
        Me.TextBox16 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox17 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox18 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox19 = New DataDynamics.ActiveReports.TextBox()
        Me.txtTotalCompra = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox21 = New DataDynamics.ActiveReports.TextBox()
        Me.txtTotalMargem = New DataDynamics.ActiveReports.TextBox()
        Me.Line1 = New DataDynamics.ActiveReports.Line()
        Me.Line2 = New DataDynamics.ActiveReports.Line()
        Me.GroupHeader2 = New DataDynamics.ActiveReports.GroupHeader()
        Me.txtFabricante = New DataDynamics.ActiveReports.TextBox()
        Me.GroupFooter2 = New DataDynamics.ActiveReports.GroupFooter()
        Me.TextBox24 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox25 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox26 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox27 = New DataDynamics.ActiveReports.TextBox()
        Me.txtSubCompra = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox29 = New DataDynamics.ActiveReports.TextBox()
        Me.txtSubMargem = New DataDynamics.ActiveReports.TextBox()
        Me.Line5 = New DataDynamics.ActiveReports.Line()
        Me.Line6 = New DataDynamics.ActiveReports.Line()
        CType(Me.TextBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMargem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPorcentagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPagina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalMargem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFabricante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubMargem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox, Me.TextBox1, Me.TextBox2, Me.TextBox3, Me.TextBox4, Me.TextBox5, Me.Line, Me.txtCompra, Me.TextBox7, Me.txtMargem, Me.txtPorcentagem})
        Me.Detail.Height = 0.1875!
        Me.Detail.Name = "Detail"
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
        Me.TextBox.DataField = "cod_tabela"
        Me.TextBox.Height = 0.2!
        Me.TextBox.Left = 0.0!
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Style = ""
        Me.TextBox.Text = "TextBox"
        Me.TextBox.Top = 0.0!
        Me.TextBox.Width = 0.5625!
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
        Me.TextBox1.DataField = "nome"
        Me.TextBox1.Height = 0.2!
        Me.TextBox1.Left = 0.6875!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = ""
        Me.TextBox1.Text = "TextBox"
        Me.TextBox1.Top = 0.0!
        Me.TextBox1.Width = 3.25!
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
        Me.TextBox2.DataField = "extras"
        Me.TextBox2.Height = 0.2!
        Me.TextBox2.Left = 4.25!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "text-align: right; "
        Me.TextBox2.Text = "TextBox"
        Me.TextBox2.Top = 0.0!
        Me.TextBox2.Width = 0.5625!
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
        Me.TextBox3.DataField = "pedidos"
        Me.TextBox3.Height = 0.2!
        Me.TextBox3.Left = 4.96875!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "text-align: right; "
        Me.TextBox3.Text = "TextBox"
        Me.TextBox3.Top = 0.0!
        Me.TextBox3.Width = 0.5625!
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
        Me.TextBox4.DataField = "OS"
        Me.TextBox4.Height = 0.2!
        Me.TextBox4.Left = 5.625!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Style = "text-align: right; "
        Me.TextBox4.Text = "TextBox"
        Me.TextBox4.Top = 0.0!
        Me.TextBox4.Width = 0.5625!
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
        Me.TextBox5.DataField = "totalitens"
        Me.TextBox5.Height = 0.2!
        Me.TextBox5.Left = 6.3125!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Style = "text-align: right; "
        Me.TextBox5.Text = "TextBox"
        Me.TextBox5.Top = 0.0!
        Me.TextBox5.Width = 0.5625!
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
        Me.Line.Left = 0.0!
        Me.Line.LineStyle = DataDynamics.ActiveReports.LineStyle.Dash
        Me.Line.LineWeight = 1.0!
        Me.Line.Name = "Line"
        Me.Line.Top = 0.0!
        Me.Line.Width = 10.875!
        Me.Line.X1 = 0.0!
        Me.Line.X2 = 10.875!
        Me.Line.Y1 = 0.0!
        Me.Line.Y2 = 0.0!
        '
        'txtCompra
        '
        Me.txtCompra.Border.BottomColor = System.Drawing.Color.Black
        Me.txtCompra.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCompra.Border.LeftColor = System.Drawing.Color.Black
        Me.txtCompra.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCompra.Border.RightColor = System.Drawing.Color.Black
        Me.txtCompra.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCompra.Border.TopColor = System.Drawing.Color.Black
        Me.txtCompra.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCompra.DataField = "totalCompra"
        Me.txtCompra.Height = 0.2!
        Me.txtCompra.Left = 7.4375!
        Me.txtCompra.Name = "txtCompra"
        Me.txtCompra.OutputFormat = resources.GetString("txtCompra.OutputFormat")
        Me.txtCompra.Style = "text-align: right; "
        Me.txtCompra.Text = "TextBox"
        Me.txtCompra.Top = 0.0!
        Me.txtCompra.Width = 0.6875!
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
        Me.TextBox7.DataField = "totalVenda"
        Me.TextBox7.Height = 0.2!
        Me.TextBox7.Left = 8.4375!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.OutputFormat = resources.GetString("TextBox7.OutputFormat")
        Me.TextBox7.Style = "text-align: right; "
        Me.TextBox7.Text = "TextBox"
        Me.TextBox7.Top = 0.0!
        Me.TextBox7.Width = 0.6875!
        '
        'txtMargem
        '
        Me.txtMargem.Border.BottomColor = System.Drawing.Color.Black
        Me.txtMargem.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMargem.Border.LeftColor = System.Drawing.Color.Black
        Me.txtMargem.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMargem.Border.RightColor = System.Drawing.Color.Black
        Me.txtMargem.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMargem.Border.TopColor = System.Drawing.Color.Black
        Me.txtMargem.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMargem.DataField = "diferenca"
        Me.txtMargem.Height = 0.2!
        Me.txtMargem.Left = 9.4375!
        Me.txtMargem.Name = "txtMargem"
        Me.txtMargem.OutputFormat = resources.GetString("txtMargem.OutputFormat")
        Me.txtMargem.Style = "text-align: right; "
        Me.txtMargem.Text = "TextBox"
        Me.txtMargem.Top = 0.0!
        Me.txtMargem.Width = 0.6875!
        '
        'txtPorcentagem
        '
        Me.txtPorcentagem.Border.BottomColor = System.Drawing.Color.Black
        Me.txtPorcentagem.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPorcentagem.Border.LeftColor = System.Drawing.Color.Black
        Me.txtPorcentagem.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPorcentagem.Border.RightColor = System.Drawing.Color.Black
        Me.txtPorcentagem.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPorcentagem.Border.TopColor = System.Drawing.Color.Black
        Me.txtPorcentagem.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPorcentagem.DataField = "porcTotal"
        Me.txtPorcentagem.Height = 0.2!
        Me.txtPorcentagem.Left = 10.1875!
        Me.txtPorcentagem.Name = "txtPorcentagem"
        Me.txtPorcentagem.OutputFormat = resources.GetString("txtPorcentagem.OutputFormat")
        Me.txtPorcentagem.Style = "text-align: right; "
        Me.txtPorcentagem.Text = "TextBox"
        Me.txtPorcentagem.Top = 0.0!
        Me.txtPorcentagem.Width = 0.6875!
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblTitulo})
        Me.ReportHeader.Height = 0.2597222!
        Me.ReportHeader.Name = "ReportHeader"
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
        Me.lblTitulo.Height = 0.2!
        Me.lblTitulo.HyperLink = Nothing
        Me.lblTitulo.Left = 0.0!
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Style = "ddo-char-set: 1; font-weight: bold; "
        Me.lblTitulo.Text = "Produto"
        Me.lblTitulo.Top = 0.0!
        Me.lblTitulo.Width = 10.875!
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox9, Me.TextBox10, Me.TextBox11, Me.TextBox12, Me.TextBox13, Me.TextBox14, Me.TextBox15, Me.Line3, Me.Line4})
        Me.ReportFooter.Height = 0.25!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'TextBox9
        '
        Me.TextBox9.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox9.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox9.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox9.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox9.DataField = "extras"
        Me.TextBox9.Height = 0.2!
        Me.TextBox9.Left = 4.265625!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Style = "text-align: right; "
        Me.TextBox9.SummaryGroup = "GroupHeader1"
        Me.TextBox9.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.TextBox9.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox9.Text = "TextBox"
        Me.TextBox9.Top = 0.0!
        Me.TextBox9.Width = 0.5625!
        '
        'TextBox10
        '
        Me.TextBox10.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox10.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox10.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox10.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox10.DataField = "pedidos"
        Me.TextBox10.Height = 0.2!
        Me.TextBox10.Left = 4.984375!
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Style = "text-align: right; "
        Me.TextBox10.SummaryGroup = "GroupHeader1"
        Me.TextBox10.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.TextBox10.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox10.Text = "TextBox"
        Me.TextBox10.Top = 0.0!
        Me.TextBox10.Width = 0.5625!
        '
        'TextBox11
        '
        Me.TextBox11.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox11.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox11.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox11.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox11.DataField = "OS"
        Me.TextBox11.Height = 0.2!
        Me.TextBox11.Left = 5.640625!
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Style = "text-align: right; "
        Me.TextBox11.SummaryGroup = "GroupHeader1"
        Me.TextBox11.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.TextBox11.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox11.Text = "TextBox"
        Me.TextBox11.Top = 0.0!
        Me.TextBox11.Width = 0.5625!
        '
        'TextBox12
        '
        Me.TextBox12.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox12.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox12.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox12.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox12.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox12.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox12.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox12.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox12.DataField = "totalitens"
        Me.TextBox12.Height = 0.2!
        Me.TextBox12.Left = 6.3125!
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Style = "text-align: right; "
        Me.TextBox12.SummaryGroup = "GroupHeader1"
        Me.TextBox12.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.TextBox12.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox12.Text = "TextBox"
        Me.TextBox12.Top = 0.0!
        Me.TextBox12.Width = 0.5625!
        '
        'TextBox13
        '
        Me.TextBox13.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox13.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox13.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox13.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox13.DataField = "totalCompra"
        Me.TextBox13.Height = 0.2!
        Me.TextBox13.Left = 7.3125!
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.OutputFormat = resources.GetString("TextBox13.OutputFormat")
        Me.TextBox13.Style = "text-align: right; "
        Me.TextBox13.SummaryGroup = "GroupHeader1"
        Me.TextBox13.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.TextBox13.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox13.Text = "TextBox"
        Me.TextBox13.Top = 0.0!
        Me.TextBox13.Width = 0.828125!
        '
        'TextBox14
        '
        Me.TextBox14.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox14.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox14.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox14.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox14.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox14.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox14.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox14.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox14.DataField = "totalVenda"
        Me.TextBox14.Height = 0.2!
        Me.TextBox14.Left = 8.25!
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.OutputFormat = resources.GetString("TextBox14.OutputFormat")
        Me.TextBox14.Style = "text-align: right; "
        Me.TextBox14.SummaryGroup = "GroupHeader1"
        Me.TextBox14.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.TextBox14.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox14.Text = "TextBox"
        Me.TextBox14.Top = 0.0!
        Me.TextBox14.Width = 0.890625!
        '
        'TextBox15
        '
        Me.TextBox15.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox15.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox15.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox15.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox15.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox15.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox15.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox15.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox15.DataField = "diferenca"
        Me.TextBox15.Height = 0.2!
        Me.TextBox15.Left = 9.3125!
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.OutputFormat = resources.GetString("TextBox15.OutputFormat")
        Me.TextBox15.Style = "text-align: right; "
        Me.TextBox15.SummaryGroup = "GroupHeader1"
        Me.TextBox15.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.TextBox15.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox15.Text = "TextBox"
        Me.TextBox15.Top = 0.0!
        Me.TextBox15.Width = 0.8125!
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
        Me.Line3.Height = 0.0!
        Me.Line3.Left = 4.1875!
        Me.Line3.LineStyle = DataDynamics.ActiveReports.LineStyle.Dash
        Me.Line3.LineWeight = 1.0!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 0.0!
        Me.Line3.Width = 6.6875!
        Me.Line3.X1 = 4.1875!
        Me.Line3.X2 = 10.875!
        Me.Line3.Y1 = 0.0!
        Me.Line3.Y2 = 0.0!
        '
        'Line4
        '
        Me.Line4.Border.BottomColor = System.Drawing.Color.Black
        Me.Line4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line4.Border.LeftColor = System.Drawing.Color.Black
        Me.Line4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line4.Border.RightColor = System.Drawing.Color.Black
        Me.Line4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line4.Border.TopColor = System.Drawing.Color.Black
        Me.Line4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line4.Height = 0.0!
        Me.Line4.Left = 4.1875!
        Me.Line4.LineStyle = DataDynamics.ActiveReports.LineStyle.Dash
        Me.Line4.LineWeight = 1.0!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 0.1875!
        Me.Line4.Width = 6.6875!
        Me.Line4.X1 = 4.1875!
        Me.Line4.X2 = 10.875!
        Me.Line4.Y1 = 0.1875!
        Me.Line4.Y2 = 0.1875!
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label1, Me.Label2, Me.Label3, Me.Label4, Me.Label5, Me.Label6, Me.Label7, Me.Label})
        Me.PageHeader.Height = 0.2076389!
        Me.PageHeader.Name = "PageHeader"
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
        Me.Label1.Left = 4.25!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
        Me.Label1.Text = "Extras"
        Me.Label1.Top = -0.015625!
        Me.Label1.Width = 0.5625!
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
        Me.Label2.Left = 4.9375!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
        Me.Label2.Text = "Balcão"
        Me.Label2.Top = -0.015625!
        Me.Label2.Width = 0.5625!
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
        Me.Label3.Left = 5.5625!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
        Me.Label3.Text = "OS"
        Me.Label3.Top = -0.015625!
        Me.Label3.Width = 0.5625!
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
        Me.Label4.Left = 6.3125!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
        Me.Label4.Text = "Total"
        Me.Label4.Top = -0.015625!
        Me.Label4.Width = 0.5625!
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
        Me.Label5.Left = 7.5!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
        Me.Label5.Text = "Compra"
        Me.Label5.Top = -0.015625!
        Me.Label5.Width = 0.5625!
        '
        'Label6
        '
        Me.Label6.Border.BottomColor = System.Drawing.Color.Black
        Me.Label6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label6.Border.LeftColor = System.Drawing.Color.Black
        Me.Label6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label6.Border.RightColor = System.Drawing.Color.Black
        Me.Label6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label6.Border.TopColor = System.Drawing.Color.Black
        Me.Label6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label6.Height = 0.2!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 8.5!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
        Me.Label6.Text = "Venda"
        Me.Label6.Top = -0.015625!
        Me.Label6.Width = 0.5625!
        '
        'Label7
        '
        Me.Label7.Border.BottomColor = System.Drawing.Color.Black
        Me.Label7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label7.Border.LeftColor = System.Drawing.Color.Black
        Me.Label7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label7.Border.RightColor = System.Drawing.Color.Black
        Me.Label7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label7.Border.TopColor = System.Drawing.Color.Black
        Me.Label7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label7.Height = 0.2!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 9.5!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
        Me.Label7.Text = "Margem"
        Me.Label7.Top = -0.015625!
        Me.Label7.Width = 0.5625!
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
        Me.Label.Left = 0.6875!
        Me.Label.Name = "Label"
        Me.Label.Style = "ddo-char-set: 1; font-weight: bold; "
        Me.Label.Text = "Produto \ Serviço"
        Me.Label.Top = -0.015625!
        Me.Label.Width = 1.1875!
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblPagina})
        Me.PageFooter.Height = 0.2!
        Me.PageFooter.Name = "PageFooter"
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
        Me.lblPagina.Left = 8.875!
        Me.lblPagina.Name = "lblPagina"
        Me.lblPagina.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
        Me.lblPagina.Text = "Produto"
        Me.lblPagina.Top = 0.0!
        Me.lblPagina.Width = 1.9375!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label8})
        Me.GroupHeader1.DataField = "tipo"
        Me.GroupHeader1.Height = 0.2597222!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'Label8
        '
        Me.Label8.Border.BottomColor = System.Drawing.Color.Black
        Me.Label8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label8.Border.LeftColor = System.Drawing.Color.Black
        Me.Label8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label8.Border.RightColor = System.Drawing.Color.Black
        Me.Label8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label8.Border.TopColor = System.Drawing.Color.Black
        Me.Label8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label8.DataField = "tipo"
        Me.Label8.Height = 0.2!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 0.0!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "ddo-char-set: 1; font-weight: bold; "
        Me.Label8.Text = "Produto"
        Me.Label8.Top = 0.0!
        Me.Label8.Width = 1.875!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox16, Me.TextBox17, Me.TextBox18, Me.TextBox19, Me.txtTotalCompra, Me.TextBox21, Me.txtTotalMargem, Me.Line1, Me.Line2})
        Me.GroupFooter1.Height = 0.25!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'TextBox16
        '
        Me.TextBox16.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox16.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox16.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox16.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox16.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox16.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox16.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox16.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox16.DataField = "extras"
        Me.TextBox16.Height = 0.2!
        Me.TextBox16.Left = 4.265625!
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Style = "text-align: right; "
        Me.TextBox16.SummaryGroup = "GroupHeader1"
        Me.TextBox16.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox16.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.TextBox16.Text = "TextBox"
        Me.TextBox16.Top = 0.0!
        Me.TextBox16.Width = 0.5625!
        '
        'TextBox17
        '
        Me.TextBox17.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox17.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox17.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox17.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox17.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox17.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox17.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox17.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox17.DataField = "pedidos"
        Me.TextBox17.Height = 0.2!
        Me.TextBox17.Left = 4.984375!
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Style = "text-align: right; "
        Me.TextBox17.SummaryGroup = "GroupHeader1"
        Me.TextBox17.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox17.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.TextBox17.Text = "TextBox"
        Me.TextBox17.Top = 0.0!
        Me.TextBox17.Width = 0.5625!
        '
        'TextBox18
        '
        Me.TextBox18.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox18.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox18.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox18.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox18.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox18.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox18.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox18.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox18.DataField = "OS"
        Me.TextBox18.Height = 0.2!
        Me.TextBox18.Left = 5.640625!
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Style = "text-align: right; "
        Me.TextBox18.SummaryGroup = "GroupHeader1"
        Me.TextBox18.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox18.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.TextBox18.Text = "TextBox"
        Me.TextBox18.Top = 0.0!
        Me.TextBox18.Width = 0.5625!
        '
        'TextBox19
        '
        Me.TextBox19.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox19.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox19.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox19.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox19.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox19.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox19.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox19.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox19.DataField = "totalitens"
        Me.TextBox19.Height = 0.2!
        Me.TextBox19.Left = 6.3125!
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Style = "text-align: right; "
        Me.TextBox19.SummaryGroup = "GroupHeader1"
        Me.TextBox19.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox19.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.TextBox19.Text = "TextBox"
        Me.TextBox19.Top = 0.0!
        Me.TextBox19.Width = 0.5625!
        '
        'txtTotalCompra
        '
        Me.txtTotalCompra.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTotalCompra.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalCompra.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTotalCompra.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalCompra.Border.RightColor = System.Drawing.Color.Black
        Me.txtTotalCompra.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalCompra.Border.TopColor = System.Drawing.Color.Black
        Me.txtTotalCompra.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalCompra.DataField = "totalCompra"
        Me.txtTotalCompra.Height = 0.2!
        Me.txtTotalCompra.Left = 7.3125!
        Me.txtTotalCompra.Name = "txtTotalCompra"
        Me.txtTotalCompra.OutputFormat = resources.GetString("txtTotalCompra.OutputFormat")
        Me.txtTotalCompra.Style = "text-align: right; "
        Me.txtTotalCompra.SummaryGroup = "GroupHeader1"
        Me.txtTotalCompra.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.txtTotalCompra.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.txtTotalCompra.Text = "TextBox"
        Me.txtTotalCompra.Top = 0.0!
        Me.txtTotalCompra.Width = 0.828125!
        '
        'TextBox21
        '
        Me.TextBox21.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox21.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox21.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox21.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox21.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox21.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox21.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox21.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox21.DataField = "totalVenda"
        Me.TextBox21.Height = 0.2!
        Me.TextBox21.Left = 8.25!
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.OutputFormat = resources.GetString("TextBox21.OutputFormat")
        Me.TextBox21.Style = "text-align: right; "
        Me.TextBox21.SummaryGroup = "GroupHeader1"
        Me.TextBox21.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox21.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.TextBox21.Text = "TextBox"
        Me.TextBox21.Top = 0.0!
        Me.TextBox21.Width = 0.890625!
        '
        'txtTotalMargem
        '
        Me.txtTotalMargem.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTotalMargem.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalMargem.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTotalMargem.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalMargem.Border.RightColor = System.Drawing.Color.Black
        Me.txtTotalMargem.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalMargem.Border.TopColor = System.Drawing.Color.Black
        Me.txtTotalMargem.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalMargem.DataField = "diferenca"
        Me.txtTotalMargem.Height = 0.2!
        Me.txtTotalMargem.Left = 9.3125!
        Me.txtTotalMargem.Name = "txtTotalMargem"
        Me.txtTotalMargem.OutputFormat = resources.GetString("txtTotalMargem.OutputFormat")
        Me.txtTotalMargem.Style = "text-align: right; "
        Me.txtTotalMargem.SummaryGroup = "GroupHeader1"
        Me.txtTotalMargem.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.txtTotalMargem.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.txtTotalMargem.Text = "TextBox"
        Me.txtTotalMargem.Top = 0.0!
        Me.txtTotalMargem.Width = 0.8125!
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
        Me.Line1.Left = 4.1875!
        Me.Line1.LineStyle = DataDynamics.ActiveReports.LineStyle.Dash
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.0!
        Me.Line1.Width = 6.6875!
        Me.Line1.X1 = 4.1875!
        Me.Line1.X2 = 10.875!
        Me.Line1.Y1 = 0.0!
        Me.Line1.Y2 = 0.0!
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
        Me.Line2.Height = 0.0!
        Me.Line2.Left = 0.0!
        Me.Line2.LineStyle = DataDynamics.ActiveReports.LineStyle.Dash
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0.0!
        Me.Line2.Width = 6.6875!
        Me.Line2.X1 = 0.0!
        Me.Line2.X2 = 6.6875!
        Me.Line2.Y1 = 0.0!
        Me.Line2.Y2 = 0.0!
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtFabricante})
        Me.GroupHeader2.DataField = "fabricante"
        Me.GroupHeader2.Height = 0.25!
        Me.GroupHeader2.Name = "GroupHeader2"
        '
        'txtFabricante
        '
        Me.txtFabricante.Border.BottomColor = System.Drawing.Color.Black
        Me.txtFabricante.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFabricante.Border.LeftColor = System.Drawing.Color.Black
        Me.txtFabricante.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFabricante.Border.RightColor = System.Drawing.Color.Black
        Me.txtFabricante.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFabricante.Border.TopColor = System.Drawing.Color.Black
        Me.txtFabricante.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFabricante.DataField = "fabricante"
        Me.txtFabricante.Height = 0.2!
        Me.txtFabricante.Left = 0.0625!
        Me.txtFabricante.Name = "txtFabricante"
        Me.txtFabricante.Style = "ddo-char-set: 1; font-weight: bold; font-style: italic; "
        Me.txtFabricante.Text = "TextBox24"
        Me.txtFabricante.Top = 0.0!
        Me.txtFabricante.Width = 1.5!
        '
        'GroupFooter2
        '
        Me.GroupFooter2.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox24, Me.TextBox25, Me.TextBox26, Me.TextBox27, Me.txtSubCompra, Me.TextBox29, Me.txtSubMargem, Me.Line5, Me.Line6})
        Me.GroupFooter2.Height = 0.25!
        Me.GroupFooter2.Name = "GroupFooter2"
        '
        'TextBox24
        '
        Me.TextBox24.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox24.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox24.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox24.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox24.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox24.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox24.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox24.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox24.DataField = "extras"
        Me.TextBox24.Height = 0.2!
        Me.TextBox24.Left = 4.260417!
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Style = "text-align: right; "
        Me.TextBox24.SummaryGroup = "GroupHeader2"
        Me.TextBox24.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox24.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.TextBox24.Text = "TextBox"
        Me.TextBox24.Top = 0.0!
        Me.TextBox24.Width = 0.5625!
        '
        'TextBox25
        '
        Me.TextBox25.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox25.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox25.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox25.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox25.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox25.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox25.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox25.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox25.DataField = "pedidos"
        Me.TextBox25.Height = 0.2!
        Me.TextBox25.Left = 4.979167!
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Style = "text-align: right; "
        Me.TextBox25.SummaryGroup = "GroupHeader2"
        Me.TextBox25.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox25.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.TextBox25.Text = "TextBox"
        Me.TextBox25.Top = 0.0!
        Me.TextBox25.Width = 0.5625!
        '
        'TextBox26
        '
        Me.TextBox26.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox26.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox26.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox26.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox26.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox26.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox26.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox26.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox26.DataField = "OS"
        Me.TextBox26.Height = 0.2!
        Me.TextBox26.Left = 5.635417!
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Style = "text-align: right; "
        Me.TextBox26.SummaryGroup = "GroupHeader2"
        Me.TextBox26.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox26.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.TextBox26.Text = "TextBox"
        Me.TextBox26.Top = 0.0!
        Me.TextBox26.Width = 0.5625!
        '
        'TextBox27
        '
        Me.TextBox27.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox27.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox27.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox27.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox27.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox27.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox27.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox27.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox27.DataField = "totalitens"
        Me.TextBox27.Height = 0.2!
        Me.TextBox27.Left = 6.307292!
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Style = "text-align: right; "
        Me.TextBox27.SummaryGroup = "GroupHeader2"
        Me.TextBox27.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox27.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.TextBox27.Text = "TextBox"
        Me.TextBox27.Top = 0.0!
        Me.TextBox27.Width = 0.5625!
        '
        'txtSubCompra
        '
        Me.txtSubCompra.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSubCompra.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSubCompra.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSubCompra.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSubCompra.Border.RightColor = System.Drawing.Color.Black
        Me.txtSubCompra.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSubCompra.Border.TopColor = System.Drawing.Color.Black
        Me.txtSubCompra.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSubCompra.DataField = "totalCompra"
        Me.txtSubCompra.Height = 0.2!
        Me.txtSubCompra.Left = 7.307292!
        Me.txtSubCompra.Name = "txtSubCompra"
        Me.txtSubCompra.OutputFormat = resources.GetString("txtSubCompra.OutputFormat")
        Me.txtSubCompra.Style = "text-align: right; "
        Me.txtSubCompra.SummaryGroup = "GroupHeader2"
        Me.txtSubCompra.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.txtSubCompra.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.txtSubCompra.Text = "TextBox"
        Me.txtSubCompra.Top = 0.0!
        Me.txtSubCompra.Width = 0.828125!
        '
        'TextBox29
        '
        Me.TextBox29.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox29.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox29.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox29.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox29.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox29.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox29.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox29.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox29.DataField = "totalVenda"
        Me.TextBox29.Height = 0.2!
        Me.TextBox29.Left = 8.244792!
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.OutputFormat = resources.GetString("TextBox29.OutputFormat")
        Me.TextBox29.Style = "text-align: right; "
        Me.TextBox29.SummaryGroup = "GroupHeader2"
        Me.TextBox29.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox29.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.TextBox29.Text = "TextBox"
        Me.TextBox29.Top = 0.0!
        Me.TextBox29.Width = 0.890625!
        '
        'txtSubMargem
        '
        Me.txtSubMargem.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSubMargem.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSubMargem.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSubMargem.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSubMargem.Border.RightColor = System.Drawing.Color.Black
        Me.txtSubMargem.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSubMargem.Border.TopColor = System.Drawing.Color.Black
        Me.txtSubMargem.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSubMargem.DataField = "diferenca"
        Me.txtSubMargem.Height = 0.2!
        Me.txtSubMargem.Left = 9.307292!
        Me.txtSubMargem.Name = "txtSubMargem"
        Me.txtSubMargem.OutputFormat = resources.GetString("txtSubMargem.OutputFormat")
        Me.txtSubMargem.Style = "text-align: right; "
        Me.txtSubMargem.SummaryGroup = "GroupHeader2"
        Me.txtSubMargem.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.txtSubMargem.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.txtSubMargem.Text = "TextBox"
        Me.txtSubMargem.Top = 0.0!
        Me.txtSubMargem.Width = 0.8125!
        '
        'Line5
        '
        Me.Line5.Border.BottomColor = System.Drawing.Color.Black
        Me.Line5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line5.Border.LeftColor = System.Drawing.Color.Black
        Me.Line5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line5.Border.RightColor = System.Drawing.Color.Black
        Me.Line5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line5.Border.TopColor = System.Drawing.Color.Black
        Me.Line5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line5.Height = 0.0!
        Me.Line5.Left = 4.1875!
        Me.Line5.LineStyle = DataDynamics.ActiveReports.LineStyle.Dash
        Me.Line5.LineWeight = 1.0!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 0.0!
        Me.Line5.Width = 6.6875!
        Me.Line5.X1 = 4.1875!
        Me.Line5.X2 = 10.875!
        Me.Line5.Y1 = 0.0!
        Me.Line5.Y2 = 0.0!
        '
        'Line6
        '
        Me.Line6.Border.BottomColor = System.Drawing.Color.Black
        Me.Line6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line6.Border.LeftColor = System.Drawing.Color.Black
        Me.Line6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line6.Border.RightColor = System.Drawing.Color.Black
        Me.Line6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line6.Border.TopColor = System.Drawing.Color.Black
        Me.Line6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line6.Height = 0.0!
        Me.Line6.Left = 4.1875!
        Me.Line6.LineStyle = DataDynamics.ActiveReports.LineStyle.Dash
        Me.Line6.LineWeight = 1.0!
        Me.Line6.Name = "Line6"
        Me.Line6.Top = 0.1875!
        Me.Line6.Width = 6.6875!
        Me.Line6.X1 = 4.1875!
        Me.Line6.X2 = 10.875!
        Me.Line6.Y1 = 0.1875!
        Me.Line6.Y2 = 0.1875!
        '
        'rptFaturamentoProdutos
        '
        Me.MasterReport = False
        Me.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape
        Me.PageSettings.PaperHeight = 11.69!
        Me.PageSettings.PaperWidth = 8.27!
        Me.PrintWidth = 10.88542!
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
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" & _
            "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei" & _
            "ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" & _
            "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading3", "Normal"))
        CType(Me.TextBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMargem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPorcentagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPagina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalMargem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFabricante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubMargem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

	#End Region
    Public titulo As String
    Dim d As New dados
    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format

    End Sub
    Private Sub ReportHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportHeader.Format
        lblTitulo.Text = titulo
    End Sub

    Private Sub PageFooter_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageFooter.Format
        lblPagina.Text = "Página " & Me.PageNumber
    End Sub

    Private Sub GroupHeader2_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupHeader2.Format
        Try
            txtFabricante.Text = fabricante(txtFabricante.Text)
        Catch ex As Exception

        End Try
    End Sub
    Private Function fabricante(ByVal id As Integer) As String
        Dim sql As String
        Dim tt As New DataTable
        sql = "Select fabricante from fabricante where id_fabricante = " & id & ""
        d.carrega_Tabela(sql, tt)
        Try
            Return tt.Rows(0)("fabricante")
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Private Sub rptFaturamentoProdutos_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        If completo = False Then
            txtCompra.Visible = False
            txtSubCompra.Visible = False
            txtTotalCompra.Visible = False
            txtMargem.Visible = False
            txtSubMargem.Visible = False
            txtTotalMargem.Visible = False
            txtPorcentagem.Visible = False
        End If
    End Sub

End Class
