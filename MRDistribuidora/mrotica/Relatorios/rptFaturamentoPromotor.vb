Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports mrotica_util
Public Class rptFaturamentoPromotor
    Inherits DataDynamics.ActiveReports.ActiveReport3
    Public completo As Boolean
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub
#Region "ActiveReports Designer generated code"
    Private WithEvents ReportHeader As DataDynamics.ActiveReports.ReportHeader = Nothing
    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader = Nothing
    Private WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader = Nothing
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
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
    Private TextBox9 As DataDynamics.ActiveReports.TextBox
    Private TextBox As DataDynamics.ActiveReports.TextBox
    Private TextBox1 As DataDynamics.ActiveReports.TextBox
    Private TextBox2 As DataDynamics.ActiveReports.TextBox
    Private TextBox3 As DataDynamics.ActiveReports.TextBox
    Private TextBox4 As DataDynamics.ActiveReports.TextBox
    Private TextBox5 As DataDynamics.ActiveReports.TextBox
    Private Line As DataDynamics.ActiveReports.Line
    Private TextBox7 As DataDynamics.ActiveReports.TextBox
    Private txtMargem As DataDynamics.ActiveReports.TextBox
    Private TextBox12 As DataDynamics.ActiveReports.TextBox
    Private TextBox13 As DataDynamics.ActiveReports.TextBox
    Private TextBox14 As DataDynamics.ActiveReports.TextBox
    Private TextBox15 As DataDynamics.ActiveReports.TextBox
    Private TextBox10 As DataDynamics.ActiveReports.TextBox
    Private txtTotalCusto As DataDynamics.ActiveReports.TextBox
    Private TextBox16 As DataDynamics.ActiveReports.TextBox
    Private txtTotalMargem As DataDynamics.ActiveReports.TextBox
    Private Line1 As DataDynamics.ActiveReports.Line
    Private Line2 As DataDynamics.ActiveReports.Line
    Friend WithEvents TextBox6 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label9 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox8 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label10 As DataDynamics.ActiveReports.Label
    Private WithEvents txtCusto As DataDynamics.ActiveReports.TextBox
    Private lblPagina As DataDynamics.ActiveReports.Label
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptFaturamentoPromotor))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.TextBox9 = New DataDynamics.ActiveReports.TextBox()
        Me.txtCusto = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox()
        Me.Line = New DataDynamics.ActiveReports.Line()
        Me.TextBox7 = New DataDynamics.ActiveReports.TextBox()
        Me.txtMargem = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox6 = New DataDynamics.ActiveReports.TextBox()
        Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader()
        Me.lblTitulo = New DataDynamics.ActiveReports.Label()
        Me.ReportFooter = New DataDynamics.ActiveReports.ReportFooter()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.Label3 = New DataDynamics.ActiveReports.Label()
        Me.Label4 = New DataDynamics.ActiveReports.Label()
        Me.Label5 = New DataDynamics.ActiveReports.Label()
        Me.Label6 = New DataDynamics.ActiveReports.Label()
        Me.Label7 = New DataDynamics.ActiveReports.Label()
        Me.Label = New DataDynamics.ActiveReports.Label()
        Me.Label8 = New DataDynamics.ActiveReports.Label()
        Me.Label9 = New DataDynamics.ActiveReports.Label()
        Me.Label10 = New DataDynamics.ActiveReports.Label()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.lblPagina = New DataDynamics.ActiveReports.Label()
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader()
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter()
        Me.TextBox12 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox13 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox14 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox15 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox10 = New DataDynamics.ActiveReports.TextBox()
        Me.txtTotalCusto = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox16 = New DataDynamics.ActiveReports.TextBox()
        Me.txtTotalMargem = New DataDynamics.ActiveReports.TextBox()
        Me.Line1 = New DataDynamics.ActiveReports.Line()
        Me.Line2 = New DataDynamics.ActiveReports.Line()
        Me.TextBox8 = New DataDynamics.ActiveReports.TextBox()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCusto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMargem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPagina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalCusto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalMargem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox9, Me.txtCusto, Me.TextBox, Me.TextBox1, Me.TextBox2, Me.TextBox3, Me.TextBox4, Me.TextBox5, Me.Line, Me.TextBox7, Me.txtMargem, Me.TextBox6})
        Me.Detail.Height = 0.229166701!
        Me.Detail.Name = "Detail"
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
        Me.TextBox9.DataField = "servicos_fin"
        Me.TextBox9.Height = 0.1875!
        Me.TextBox9.Left = 4.3125!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.OutputFormat = resources.GetString("TextBox9.OutputFormat")
        Me.TextBox9.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; "
        Me.TextBox9.Text = "TextBox"
        Me.TextBox9.Top = 0.0!
        Me.TextBox9.Width = 0.625!
        '
        'txtCusto
        '
        Me.txtCusto.Border.BottomColor = System.Drawing.Color.Black
        Me.txtCusto.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCusto.Border.LeftColor = System.Drawing.Color.Black
        Me.txtCusto.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCusto.Border.RightColor = System.Drawing.Color.Black
        Me.txtCusto.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCusto.Border.TopColor = System.Drawing.Color.Black
        Me.txtCusto.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCusto.DataField = "Custo"
        Me.txtCusto.Height = 0.1875!
        Me.txtCusto.Left = 4.9375!
        Me.txtCusto.Name = "txtCusto"
        Me.txtCusto.OutputFormat = resources.GetString("txtCusto.OutputFormat")
        Me.txtCusto.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; "
        Me.txtCusto.Text = "TextBox"
        Me.txtCusto.Top = 0.0!
        Me.txtCusto.Width = 0.5625!
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
        Me.TextBox.DataField = "cod_Cliente"
        Me.TextBox.Height = 0.1875!
        Me.TextBox.Left = 0.0!
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Style = "ddo-char-set: 1; font-size: 7pt; "
        Me.TextBox.Text = "TextBox"
        Me.TextBox.Top = 0.0!
        Me.TextBox.Width = 0.4375!
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
        Me.TextBox1.DataField = "nome_cliente"
        Me.TextBox1.Height = 0.1875!
        Me.TextBox1.Left = 0.4375!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "ddo-char-set: 1; font-size: 7pt; "
        Me.TextBox1.Text = "TextBox"
        Me.TextBox1.Top = 0.0!
        Me.TextBox1.Width = 2.25!
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
        Me.TextBox2.DataField = "extra"
        Me.TextBox2.Height = 0.1875!
        Me.TextBox2.Left = 2.6875!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; "
        Me.TextBox2.Text = "TextBox"
        Me.TextBox2.Top = 0.0!
        Me.TextBox2.Width = 0.375!
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
        Me.TextBox3.DataField = "balcao"
        Me.TextBox3.Height = 0.1875!
        Me.TextBox3.Left = 3.0625!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; "
        Me.TextBox3.Text = "TextBox"
        Me.TextBox3.Top = 0.0!
        Me.TextBox3.Width = 0.4375!
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
        Me.TextBox4.Height = 0.1875!
        Me.TextBox4.Left = 3.5!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; "
        Me.TextBox4.Text = "TextBox"
        Me.TextBox4.Top = 0.0!
        Me.TextBox4.Width = 0.375!
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
        Me.TextBox5.DataField = "total"
        Me.TextBox5.Height = 0.1875!
        Me.TextBox5.Left = 3.875!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; "
        Me.TextBox5.Text = "TextBox"
        Me.TextBox5.Top = 0.0!
        Me.TextBox5.Width = 0.4375!
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
        Me.Line.Width = 7.5!
        Me.Line.X1 = 0.0!
        Me.Line.X2 = 7.5!
        Me.Line.Y1 = 0.0!
        Me.Line.Y2 = 0.0!
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
        Me.TextBox7.DataField = "total_Din"
        Me.TextBox7.Height = 0.1875!
        Me.TextBox7.Left = 5.5!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.OutputFormat = resources.GetString("TextBox7.OutputFormat")
        Me.TextBox7.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; "
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
        Me.txtMargem.DataField = "margem"
        Me.txtMargem.Height = 0.1875!
        Me.txtMargem.Left = 6.1875!
        Me.txtMargem.Name = "txtMargem"
        Me.txtMargem.OutputFormat = resources.GetString("txtMargem.OutputFormat")
        Me.txtMargem.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; "
        Me.txtMargem.Text = "TextBox"
        Me.txtMargem.Top = 0.0!
        Me.txtMargem.Width = 0.625!
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
        Me.TextBox6.DataField = "Total_Trans"
        Me.TextBox6.Height = 0.1875!
        Me.TextBox6.Left = 6.8125!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.OutputFormat = resources.GetString("TextBox6.OutputFormat")
        Me.TextBox6.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; "
        Me.TextBox6.Text = "TextBox"
        Me.TextBox6.Top = 0.0!
        Me.TextBox6.Width = 0.6875!
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblTitulo})
        Me.ReportHeader.Height = 0.259722203!
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
        Me.lblTitulo.Height = 0.1875!
        Me.lblTitulo.HyperLink = Nothing
        Me.lblTitulo.Left = 0.0!
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Style = "ddo-char-set: 1; font-weight: bold; font-size: 7pt; "
        Me.lblTitulo.Text = "Produto"
        Me.lblTitulo.Top = 0.0!
        Me.lblTitulo.Width = 7.4375!
        '
        'ReportFooter
        '
        Me.ReportFooter.Height = 0.25!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label1, Me.Label2, Me.Label3, Me.Label4, Me.Label5, Me.Label6, Me.Label7, Me.Label, Me.Label8, Me.Label9, Me.Label10})
        Me.PageHeader.Height = 0.21875!
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
        Me.Label1.Height = 0.1875!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 2.6875!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 7pt; "
        Me.Label1.Text = "Extras"
        Me.Label1.Top = 0.0!
        Me.Label1.Width = 0.375!
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
        Me.Label2.Height = 0.1875!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 3.0625!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 7pt; "
        Me.Label2.Text = "Balcão"
        Me.Label2.Top = 0.0!
        Me.Label2.Width = 0.4375!
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
        Me.Label3.Height = 0.1875!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 3.5!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 7pt; "
        Me.Label3.Text = "OS"
        Me.Label3.Top = 0.0!
        Me.Label3.Width = 0.375!
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
        Me.Label4.Left = 3.875!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 7pt; "
        Me.Label4.Text = "Total"
        Me.Label4.Top = 0.0!
        Me.Label4.Width = 0.4375!
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
        Me.Label5.Left = 4.9375!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 7pt; "
        Me.Label5.Text = "Custo"
        Me.Label5.Top = 0.0!
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
        Me.Label6.Height = 0.1875!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 5.5!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 7pt; "
        Me.Label6.Text = "Venda/Serv."
        Me.Label6.Top = 0.0!
        Me.Label6.Width = 0.6875!
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
        Me.Label7.Height = 0.1875!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 6.1875!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 7pt; "
        Me.Label7.Text = "Margem"
        Me.Label7.Top = 0.0!
        Me.Label7.Width = 0.625!
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
        Me.Label.Height = 0.200000003!
        Me.Label.HyperLink = Nothing
        Me.Label.Left = 0.4375!
        Me.Label.Name = "Label"
        Me.Label.Style = "ddo-char-set: 1; font-weight: bold; font-size: 7pt; "
        Me.Label.Text = "Cliente"
        Me.Label.Top = 0.0!
        Me.Label.Width = 1.1875!
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
        Me.Label8.Height = 0.1875!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 4.3125!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 7pt; "
        Me.Label8.Text = "Serviços"
        Me.Label8.Top = 0.0!
        Me.Label8.Width = 0.625!
        '
        'Label9
        '
        Me.Label9.Border.BottomColor = System.Drawing.Color.Black
        Me.Label9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label9.Border.LeftColor = System.Drawing.Color.Black
        Me.Label9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label9.Border.RightColor = System.Drawing.Color.Black
        Me.Label9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label9.Border.TopColor = System.Drawing.Color.Black
        Me.Label9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label9.Height = 0.1875!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 6.8125!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 7pt; "
        Me.Label9.Text = "Venda/Real"
        Me.Label9.Top = 0.0!
        Me.Label9.Width = 0.6875!
        '
        'Label10
        '
        Me.Label10.Border.BottomColor = System.Drawing.Color.Black
        Me.Label10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label10.Border.LeftColor = System.Drawing.Color.Black
        Me.Label10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label10.Border.RightColor = System.Drawing.Color.Black
        Me.Label10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label10.Border.TopColor = System.Drawing.Color.Black
        Me.Label10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label10.Height = 0.1875!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 0.0!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "ddo-char-set: 1; font-weight: bold; font-size: 7pt; "
        Me.Label10.Text = "Código"
        Me.Label10.Top = 0.0!
        Me.Label10.Width = 0.4375!
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblPagina})
        Me.PageFooter.Height = 0.200000003!
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
        Me.lblPagina.Height = 0.1875!
        Me.lblPagina.HyperLink = Nothing
        Me.lblPagina.Left = 5.625!
        Me.lblPagina.Name = "lblPagina"
        Me.lblPagina.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 7pt; "
        Me.lblPagina.Text = "Produto"
        Me.lblPagina.Top = 0.0!
        Me.lblPagina.Width = 1.875!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.DataField = "tipo"
        Me.GroupHeader1.Height = 0.0!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox12, Me.TextBox13, Me.TextBox14, Me.TextBox15, Me.TextBox10, Me.txtTotalCusto, Me.TextBox16, Me.txtTotalMargem, Me.Line1, Me.Line2, Me.TextBox8})
        Me.GroupFooter1.Height = 0.239583299!
        Me.GroupFooter1.Name = "GroupFooter1"
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
        Me.TextBox12.DataField = "extra"
        Me.TextBox12.Height = 0.1875!
        Me.TextBox12.Left = 2.625!
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; "
        Me.TextBox12.SummaryGroup = "GroupHeader1"
        Me.TextBox12.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox12.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox12.Text = "TextBox"
        Me.TextBox12.Top = 0.0!
        Me.TextBox12.Width = 0.4375!
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
        Me.TextBox13.DataField = "balcao"
        Me.TextBox13.Height = 0.1875!
        Me.TextBox13.Left = 3.0625!
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; "
        Me.TextBox13.SummaryGroup = "GroupHeader1"
        Me.TextBox13.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox13.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox13.Text = "TextBox"
        Me.TextBox13.Top = 0.0!
        Me.TextBox13.Width = 0.4375!
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
        Me.TextBox14.DataField = "OS"
        Me.TextBox14.Height = 0.1875!
        Me.TextBox14.Left = 3.5!
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; "
        Me.TextBox14.SummaryGroup = "GroupHeader1"
        Me.TextBox14.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox14.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox14.Text = "TextBox"
        Me.TextBox14.Top = 0.0!
        Me.TextBox14.Width = 0.375!
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
        Me.TextBox15.DataField = "total"
        Me.TextBox15.Height = 0.1875!
        Me.TextBox15.Left = 3.875!
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; "
        Me.TextBox15.SummaryGroup = "GroupHeader1"
        Me.TextBox15.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox15.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox15.Text = "TextBox"
        Me.TextBox15.Top = 0.0!
        Me.TextBox15.Width = 0.4375!
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
        Me.TextBox10.DataField = "servicos_fin"
        Me.TextBox10.Height = 0.1875!
        Me.TextBox10.Left = 4.3125!
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.OutputFormat = resources.GetString("TextBox10.OutputFormat")
        Me.TextBox10.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; "
        Me.TextBox10.SummaryGroup = "GroupHeader1"
        Me.TextBox10.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox10.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox10.Text = "TextBox"
        Me.TextBox10.Top = 0.0!
        Me.TextBox10.Width = 0.625!
        '
        'txtTotalCusto
        '
        Me.txtTotalCusto.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTotalCusto.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalCusto.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTotalCusto.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalCusto.Border.RightColor = System.Drawing.Color.Black
        Me.txtTotalCusto.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalCusto.Border.TopColor = System.Drawing.Color.Black
        Me.txtTotalCusto.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalCusto.DataField = "Custo"
        Me.txtTotalCusto.Height = 0.1875!
        Me.txtTotalCusto.Left = 4.9375!
        Me.txtTotalCusto.Name = "txtTotalCusto"
        Me.txtTotalCusto.OutputFormat = resources.GetString("txtTotalCusto.OutputFormat")
        Me.txtTotalCusto.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; "
        Me.txtTotalCusto.SummaryGroup = "GroupHeader1"
        Me.txtTotalCusto.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.txtTotalCusto.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.txtTotalCusto.Text = "TextBox"
        Me.txtTotalCusto.Top = 0.0!
        Me.txtTotalCusto.Width = 0.5625!
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
        Me.TextBox16.DataField = "total_Din"
        Me.TextBox16.Height = 0.1875!
        Me.TextBox16.Left = 5.5!
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.OutputFormat = resources.GetString("TextBox16.OutputFormat")
        Me.TextBox16.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; "
        Me.TextBox16.SummaryGroup = "GroupHeader1"
        Me.TextBox16.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox16.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox16.Text = "TextBox"
        Me.TextBox16.Top = 0.0!
        Me.TextBox16.Width = 0.6875!
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
        Me.txtTotalMargem.DataField = "margem"
        Me.txtTotalMargem.Height = 0.1875!
        Me.txtTotalMargem.Left = 6.1875!
        Me.txtTotalMargem.Name = "txtTotalMargem"
        Me.txtTotalMargem.OutputFormat = resources.GetString("txtTotalMargem.OutputFormat")
        Me.txtTotalMargem.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; "
        Me.txtTotalMargem.SummaryGroup = "GroupHeader1"
        Me.txtTotalMargem.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.txtTotalMargem.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.txtTotalMargem.Text = "TextBox"
        Me.txtTotalMargem.Top = 0.0!
        Me.txtTotalMargem.Width = 0.625!
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
        Me.Line1.Width = 3.9375!
        Me.Line1.X1 = 4.1875!
        Me.Line1.X2 = 8.125!
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
        Me.Line2.Width = 7.5!
        Me.Line2.X1 = 0.0!
        Me.Line2.X2 = 7.5!
        Me.Line2.Y1 = 0.0!
        Me.Line2.Y2 = 0.0!
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
        Me.TextBox8.DataField = "Total_Trans"
        Me.TextBox8.Height = 0.1875!
        Me.TextBox8.Left = 6.8125!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.OutputFormat = resources.GetString("TextBox8.OutputFormat")
        Me.TextBox8.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; "
        Me.TextBox8.SummaryGroup = "GroupHeader1"
        Me.TextBox8.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox8.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox8.Text = "TextBox"
        Me.TextBox8.Top = 0.0!
        Me.TextBox8.Width = 0.6875!
        '
        'rptFaturamentoPromotor
        '
        Me.MasterReport = False
        Me.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape
        Me.PageSettings.PaperHeight = 11.6899996!
        Me.PageSettings.PaperWidth = 8.27000046!
        Me.PrintWidth = 7.52099991!
        Me.Sections.Add(Me.ReportHeader)
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail)
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
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCusto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMargem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPagina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalCusto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalMargem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
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

    Private Sub rptFaturamentoClientes_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        If completo = False Then
            txtCusto.Visible = False
            txtTotalCusto.Visible = False
            txtMargem.Visible = False
            txtTotalMargem.Visible = False
        End If
    End Sub

End Class
