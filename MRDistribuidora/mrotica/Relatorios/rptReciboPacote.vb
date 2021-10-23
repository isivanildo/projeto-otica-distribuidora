Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports mrotica_util

Public Class rptReciboPacote
    Inherits DataDynamics.ActiveReports.ActiveReport3
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub
    Public tRec As New DataTable
    Dim r As New rptFaturaRec
    Dim conf As New config
    Public cliente As String
    Public fatura As String
    Public razao As String
    Public endereco As String
    Public fone As String
    Public municipio As String
    Public codigo As String
    Dim total As Double = 0
    Public aPAGAR As String
#Region "ActiveReports Designer generated code"
    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader = Nothing
    Private WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader = Nothing
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
    Private WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter = Nothing
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
	Private txtCliente As DataDynamics.ActiveReports.TextBox
	Private txtFatura As DataDynamics.ActiveReports.TextBox
    Private Label As DataDynamics.ActiveReports.Label
	Private Label1 As DataDynamics.ActiveReports.Label
	Private Label2 As DataDynamics.ActiveReports.Label
	Private Label3 As DataDynamics.ActiveReports.Label
	Private Line2 As DataDynamics.ActiveReports.Line
	Private TextBox8 As DataDynamics.ActiveReports.TextBox
	Private TextBox10 As DataDynamics.ActiveReports.TextBox
	Private TextBox11 As DataDynamics.ActiveReports.TextBox
	Private TextBox12 As DataDynamics.ActiveReports.TextBox
	Private TextBox9 As DataDynamics.ActiveReports.TextBox
	Private TextBox15 As DataDynamics.ActiveReports.TextBox
    Private TextBox As DataDynamics.ActiveReports.TextBox
	Private TextBox1 As DataDynamics.ActiveReports.TextBox
	Private TextBox2 As DataDynamics.ActiveReports.TextBox
	Private TextBox3 As DataDynamics.ActiveReports.TextBox
	Private txtPdesc As DataDynamics.ActiveReports.TextBox
	Private txtQuant As DataDynamics.ActiveReports.TextBox
	Private txtVtot As DataDynamics.ActiveReports.TextBox
	Private Line As DataDynamics.ActiveReports.Line
	Private TextBox13 As DataDynamics.ActiveReports.TextBox
	Private TextBox6 As DataDynamics.ActiveReports.TextBox
	Private sbRp As DataDynamics.ActiveReports.SubReport
    Private txtTotal As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtSurf As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtMont As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox14 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox7 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Picture1 As DataDynamics.ActiveReports.Picture
    Private WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox16 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox17 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox18 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox19 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox20 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox21 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox22 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox24 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox26 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox28 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox23 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox25 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox27 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox29 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox30 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox31 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox33 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox32 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox35 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox34 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox37 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox39 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox36 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox38 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox41 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox43 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox40 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox42 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox44 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line3 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line6 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line8 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line10 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line4 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line5 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line7 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line9 As DataDynamics.ActiveReports.Line
    Private Line1 As DataDynamics.ActiveReports.Line
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptReciboPacote))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txtMont = New DataDynamics.ActiveReports.TextBox()
        Me.txtSurf = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox()
        Me.txtPdesc = New DataDynamics.ActiveReports.TextBox()
        Me.txtQuant = New DataDynamics.ActiveReports.TextBox()
        Me.txtVtot = New DataDynamics.ActiveReports.TextBox()
        Me.Line = New DataDynamics.ActiveReports.Line()
        Me.TextBox7 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox24 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox26 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox28 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox33 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox35 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox37 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox39 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox41 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox43 = New DataDynamics.ActiveReports.TextBox()
        Me.Line3 = New DataDynamics.ActiveReports.Line()
        Me.Line6 = New DataDynamics.ActiveReports.Line()
        Me.Line8 = New DataDynamics.ActiveReports.Line()
        Me.Line10 = New DataDynamics.ActiveReports.Line()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.txtCliente = New DataDynamics.ActiveReports.TextBox()
        Me.txtFatura = New DataDynamics.ActiveReports.TextBox()
        Me.Label = New DataDynamics.ActiveReports.Label()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.Label3 = New DataDynamics.ActiveReports.Label()
        Me.Line2 = New DataDynamics.ActiveReports.Line()
        Me.Picture1 = New DataDynamics.ActiveReports.Picture()
        Me.TextBox16 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox17 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox18 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox19 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox20 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox21 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox22 = New DataDynamics.ActiveReports.TextBox()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader()
        Me.TextBox8 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox10 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox11 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox12 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox9 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox15 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox14 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox23 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox25 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox27 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox32 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox34 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox36 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox38 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox40 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox42 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox44 = New DataDynamics.ActiveReports.TextBox()
        Me.Line4 = New DataDynamics.ActiveReports.Line()
        Me.Line5 = New DataDynamics.ActiveReports.Line()
        Me.Line7 = New DataDynamics.ActiveReports.Line()
        Me.Line9 = New DataDynamics.ActiveReports.Line()
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter()
        Me.TextBox13 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox6 = New DataDynamics.ActiveReports.TextBox()
        Me.sbRp = New DataDynamics.ActiveReports.SubReport()
        Me.txtTotal = New DataDynamics.ActiveReports.TextBox()
        Me.Line1 = New DataDynamics.ActiveReports.Line()
        Me.TextBox29 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox30 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox31 = New DataDynamics.ActiveReports.TextBox()
        CType(Me.txtMont, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSurf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPdesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuant, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVtot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFatura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtMont, Me.txtSurf, Me.TextBox, Me.TextBox1, Me.TextBox2, Me.TextBox3, Me.txtPdesc, Me.txtQuant, Me.txtVtot, Me.Line, Me.TextBox7, Me.TextBox24, Me.TextBox26, Me.TextBox28, Me.TextBox33, Me.TextBox35, Me.TextBox37, Me.TextBox39, Me.TextBox41, Me.TextBox43, Me.Line3, Me.Line6, Me.Line8, Me.Line10})
        Me.Detail.Height = 0.1979167!
        Me.Detail.Name = "Detail"
        '
        'txtMont
        '
        Me.txtMont.Border.BottomColor = System.Drawing.Color.Black
        Me.txtMont.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMont.Border.LeftColor = System.Drawing.Color.Black
        Me.txtMont.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMont.Border.RightColor = System.Drawing.Color.Black
        Me.txtMont.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMont.Border.TopColor = System.Drawing.Color.Black
        Me.txtMont.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMont.DataField = "preco_tabela_mont"
        Me.txtMont.Height = 0.1875!
        Me.txtMont.Left = 6.1875!
        Me.txtMont.Name = "txtMont"
        Me.txtMont.OutputFormat = resources.GetString("txtMont.OutputFormat")
        Me.txtMont.Style = "text-align: right; font-size: 6.75pt; "
        Me.txtMont.Text = "TextBox"
        Me.txtMont.Top = 0!
        Me.txtMont.Width = 0.5625!
        '
        'txtSurf
        '
        Me.txtSurf.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSurf.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSurf.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSurf.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSurf.Border.RightColor = System.Drawing.Color.Black
        Me.txtSurf.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSurf.Border.TopColor = System.Drawing.Color.Black
        Me.txtSurf.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSurf.DataField = "desc_surf"
        Me.txtSurf.Height = 0.1875!
        Me.txtSurf.Left = 4.6875!
        Me.txtSurf.Name = "txtSurf"
        Me.txtSurf.OutputFormat = resources.GetString("txtSurf.OutputFormat")
        Me.txtSurf.Style = "text-align: right; font-size: 6.75pt; "
        Me.txtSurf.Text = "TextBox"
        Me.txtSurf.Top = 0!
        Me.txtSurf.Width = 0.375!
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
        Me.TextBox.DataField = "item"
        Me.TextBox.Height = 0.1875!
        Me.TextBox.Left = 0!
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Style = "text-align: right; font-size: 6.75pt; "
        Me.TextBox.Text = "TextBox"
        Me.TextBox.Top = 0!
        Me.TextBox.Width = 0.25!
        '
        'txtNomeLente
        '
        Me.TextBox1.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.DataField = "nome_lente"
        Me.TextBox1.Height = 0.1875!
        Me.TextBox1.Left = 0.3125!
        Me.TextBox1.Name = "txtNomeLente"
        Me.TextBox1.Style = "text-align: left; font-size: 6.75pt; "
        Me.TextBox1.Text = "TextBox"
        Me.TextBox1.Top = 0!
        Me.TextBox1.Width = 1.625!
        '
        'txtPrecoProduto
        '
        Me.TextBox2.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.DataField = "preco_produto"
        Me.TextBox2.Height = 0.1875!
        Me.TextBox2.Left = 2.0!
        Me.TextBox2.Name = "txtPrecoProduto"
        Me.TextBox2.Style = "text-align: right; font-size: 6.75pt; "
        Me.TextBox2.Text = "TextBox"
        Me.TextBox2.Top = 0!
        Me.TextBox2.Width = 0.56!
        '
        'txtDescontoProduto
        '
        Me.TextBox3.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox3.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox3.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox3.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox3.DataField = "desconto_produto"
        Me.TextBox3.Height = 0.1875!
        Me.TextBox3.Left = 2.625!
        Me.TextBox3.Name = "txtDescontoProduto"
        Me.TextBox3.OutputFormat = resources.GetString("txtDescontoProduto.OutputFormat")
        Me.TextBox3.Style = "text-align: right; font-size: 6.75pt; "
        Me.TextBox3.Text = "TextBox"
        Me.TextBox3.Top = 0!
        Me.TextBox3.Width = 0.35!
        '
        'txtPdesc
        '
        Me.txtPdesc.Border.BottomColor = System.Drawing.Color.Black
        Me.txtPdesc.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPdesc.Border.LeftColor = System.Drawing.Color.Black
        Me.txtPdesc.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPdesc.Border.RightColor = System.Drawing.Color.Black
        Me.txtPdesc.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPdesc.Border.TopColor = System.Drawing.Color.Black
        Me.txtPdesc.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPdesc.DataField = "preco_final_produto"
        Me.txtPdesc.Height = 0.1875!
        Me.txtPdesc.Left = 3.0625!
        Me.txtPdesc.Name = "txtPdesc"
        Me.txtPdesc.OutputFormat = resources.GetString("txtPdesc.OutputFormat")
        Me.txtPdesc.Style = "text-align: right; font-size: 6.75pt; "
        Me.txtPdesc.Text = "TextBox"
        Me.txtPdesc.Top = 0!
        Me.txtPdesc.Width = 0.5!
        '
        'txtQuant
        '
        Me.txtQuant.Border.BottomColor = System.Drawing.Color.Black
        Me.txtQuant.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtQuant.Border.LeftColor = System.Drawing.Color.Black
        Me.txtQuant.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtQuant.Border.RightColor = System.Drawing.Color.Black
        Me.txtQuant.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtQuant.Border.TopColor = System.Drawing.Color.Black
        Me.txtQuant.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtQuant.DataField = "qtde_produto"
        Me.txtQuant.Height = 0.1875!
        Me.txtQuant.Left = 3.625!
        Me.txtQuant.Name = "txtQuant"
        Me.txtQuant.OutputFormat = resources.GetString("txtQuant.OutputFormat")
        Me.txtQuant.Style = "text-align: right; font-size: 6.75pt; "
        Me.txtQuant.Text = "TextBox"
        Me.txtQuant.Top = 0!
        Me.txtQuant.Width = 0.375!
        '
        'txtVtot
        '
        Me.txtVtot.Border.BottomColor = System.Drawing.Color.Black
        Me.txtVtot.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtVtot.Border.LeftColor = System.Drawing.Color.Black
        Me.txtVtot.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtVtot.Border.RightColor = System.Drawing.Color.Black
        Me.txtVtot.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtVtot.Border.TopColor = System.Drawing.Color.Black
        Me.txtVtot.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtVtot.DataField = "qtde_produto*preco_produto"
        Me.txtVtot.Height = 0.1875!
        Me.txtVtot.Left = 10.4375!
        Me.txtVtot.Name = "txtVtot"
        Me.txtVtot.OutputFormat = resources.GetString("txtVtot.OutputFormat")
        Me.txtVtot.Style = "text-align: right; font-size: 6.75pt; "
        Me.txtVtot.Text = "TextBox"
        Me.txtVtot.Top = 0!
        Me.txtVtot.Width = 0.5!
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
        Me.Line.Left = 0!
        Me.Line.LineWeight = 1.0!
        Me.Line.Name = "Line"
        Me.Line.Top = 0!
        Me.Line.Width = 10.94!
        Me.Line.X1 = 0!
        Me.Line.X2 = 10.94!
        Me.Line.Y1 = 0!
        Me.Line.Y2 = 0!
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
        Me.TextBox7.DataField = "preco_final_tratamento"
        Me.TextBox7.Height = 0.1875!
        Me.TextBox7.Left = 9.375!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.OutputFormat = resources.GetString("TextBox7.OutputFormat")
        Me.TextBox7.Style = "text-align: right; font-size: 6.75pt; "
        Me.TextBox7.Text = "TextBox7"
        Me.TextBox7.Top = 0!
        Me.TextBox7.Width = 0.5625!
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
        Me.TextBox24.DataField = "qtde_surfacagem"
        Me.TextBox24.Height = 0.1875!
        Me.TextBox24.Left = 5.75!
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.OutputFormat = resources.GetString("TextBox24.OutputFormat")
        Me.TextBox24.Style = "text-align: right; font-size: 6.75pt; "
        Me.TextBox24.Text = "TextBox"
        Me.TextBox24.Top = 0!
        Me.TextBox24.Width = 0.375!
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
        Me.TextBox26.DataField = "qtde_montagem"
        Me.TextBox26.Height = 0.1875!
        Me.TextBox26.Left = 7.875!
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.OutputFormat = resources.GetString("TextBox26.OutputFormat")
        Me.TextBox26.Style = "text-align: right; font-size: 6.75pt; "
        Me.TextBox26.Text = "TextBox"
        Me.TextBox26.Top = 0!
        Me.TextBox26.Width = 0.375!
        '
        'TextBox28
        '
        Me.TextBox28.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox28.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox28.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox28.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox28.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox28.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox28.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox28.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox28.DataField = "qtde_tratamento"
        Me.TextBox28.Height = 0.1875!
        Me.TextBox28.Left = 9.9375!
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.OutputFormat = resources.GetString("TextBox28.OutputFormat")
        Me.TextBox28.Style = "text-align: right; font-size: 6.75pt; "
        Me.TextBox28.Text = "TextBox"
        Me.TextBox28.Top = 0!
        Me.TextBox28.Width = 0.375!
        '
        'TextBox33
        '
        Me.TextBox33.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox33.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox33.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox33.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox33.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox33.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox33.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox33.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox33.DataField = "preco_final_surfacagem"
        Me.TextBox33.Height = 0.1875!
        Me.TextBox33.Left = 4.0625!
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.OutputFormat = resources.GetString("TextBox33.OutputFormat")
        Me.TextBox33.Style = "text-align: right; font-size: 6.75pt; "
        Me.TextBox33.Text = "TextBox"
        Me.TextBox33.Top = 0!
        Me.TextBox33.Width = 0.56!
        '
        'TextBox35
        '
        Me.TextBox35.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox35.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox35.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox35.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox35.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox35.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox35.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox35.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox35.DataField = "preco_surfacagem"
        Me.TextBox35.Height = 0.1875!
        Me.TextBox35.Left = 5.125!
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.OutputFormat = resources.GetString("TextBox35.OutputFormat")
        Me.TextBox35.Style = "text-align: right; font-size: 6.75pt; "
        Me.TextBox35.Text = "TextBox"
        Me.TextBox35.Top = 0!
        Me.TextBox35.Width = 0.56!
        '
        'TextBox37
        '
        Me.TextBox37.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox37.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox37.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox37.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox37.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox37.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox37.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox37.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox37.DataField = "desconto_montagem"
        Me.TextBox37.Height = 0.1875!
        Me.TextBox37.Left = 6.8125!
        Me.TextBox37.Name = "TextBox37"
        Me.TextBox37.OutputFormat = resources.GetString("TextBox37.OutputFormat")
        Me.TextBox37.Style = "text-align: right; font-size: 6.75pt; "
        Me.TextBox37.Text = "TextBox"
        Me.TextBox37.Top = 0!
        Me.TextBox37.Width = 0.375!
        '
        'TextBox39
        '
        Me.TextBox39.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox39.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox39.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox39.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox39.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox39.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox39.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox39.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox39.DataField = "preco_final_montagem"
        Me.TextBox39.Height = 0.1875!
        Me.TextBox39.Left = 7.25!
        Me.TextBox39.Name = "TextBox39"
        Me.TextBox39.OutputFormat = resources.GetString("TextBox39.OutputFormat")
        Me.TextBox39.Style = "text-align: right; font-size: 6.75pt; "
        Me.TextBox39.Text = "TextBox"
        Me.TextBox39.Top = 0!
        Me.TextBox39.Width = 0.56!
        '
        'TextBox41
        '
        Me.TextBox41.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox41.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox41.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox41.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox41.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox41.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox41.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox41.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox41.DataField = "preco_tratamento"
        Me.TextBox41.Height = 0.1875!
        Me.TextBox41.Left = 8.3125!
        Me.TextBox41.Name = "TextBox41"
        Me.TextBox41.OutputFormat = resources.GetString("TextBox41.OutputFormat")
        Me.TextBox41.Style = "text-align: right; font-size: 6.75pt; "
        Me.TextBox41.Text = "TextBox"
        Me.TextBox41.Top = 0!
        Me.TextBox41.Width = 0.5625!
        '
        'TextBox43
        '
        Me.TextBox43.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox43.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox43.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox43.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox43.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox43.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox43.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox43.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox43.DataField = "descinto_tratamento"
        Me.TextBox43.Height = 0.1875!
        Me.TextBox43.Left = 8.9375!
        Me.TextBox43.Name = "TextBox43"
        Me.TextBox43.OutputFormat = resources.GetString("TextBox43.OutputFormat")
        Me.TextBox43.Style = "text-align: right; font-size: 6.75pt; "
        Me.TextBox43.Text = "TextBox"
        Me.TextBox43.Top = 0!
        Me.TextBox43.Width = 0.375!
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
        Me.Line3.Height = 0.1875!
        Me.Line3.Left = 4.041667!
        Me.Line3.LineWeight = 1.0!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 0!
        Me.Line3.Width = 0!
        Me.Line3.X1 = 4.041667!
        Me.Line3.X2 = 4.041667!
        Me.Line3.Y1 = 0!
        Me.Line3.Y2 = 0.1875!
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
        Me.Line6.Height = 0.1875!
        Me.Line6.Left = 6.17!
        Me.Line6.LineWeight = 1.0!
        Me.Line6.Name = "Line6"
        Me.Line6.Top = 0!
        Me.Line6.Width = 0!
        Me.Line6.X1 = 6.17!
        Me.Line6.X2 = 6.17!
        Me.Line6.Y1 = 0!
        Me.Line6.Y2 = 0.1875!
        '
        'Line8
        '
        Me.Line8.Border.BottomColor = System.Drawing.Color.Black
        Me.Line8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line8.Border.LeftColor = System.Drawing.Color.Black
        Me.Line8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line8.Border.RightColor = System.Drawing.Color.Black
        Me.Line8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line8.Border.TopColor = System.Drawing.Color.Black
        Me.Line8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line8.Height = 0.1875!
        Me.Line8.Left = 8.28!
        Me.Line8.LineWeight = 1.0!
        Me.Line8.Name = "Line8"
        Me.Line8.Top = 0!
        Me.Line8.Width = 0!
        Me.Line8.X1 = 8.28!
        Me.Line8.X2 = 8.28!
        Me.Line8.Y1 = 0!
        Me.Line8.Y2 = 0.1875!
        '
        'Line10
        '
        Me.Line10.Border.BottomColor = System.Drawing.Color.Black
        Me.Line10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line10.Border.LeftColor = System.Drawing.Color.Black
        Me.Line10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line10.Border.RightColor = System.Drawing.Color.Black
        Me.Line10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line10.Border.TopColor = System.Drawing.Color.Black
        Me.Line10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line10.Height = 0.1875!
        Me.Line10.Left = 10.375!
        Me.Line10.LineWeight = 1.0!
        Me.Line10.Name = "Line10"
        Me.Line10.Top = 0!
        Me.Line10.Width = 0!
        Me.Line10.X1 = 10.375!
        Me.Line10.X2 = 10.375!
        Me.Line10.Y1 = 0!
        Me.Line10.Y2 = 0.1875!
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtCliente, Me.txtFatura, Me.Label, Me.Label1, Me.Label2, Me.Label3, Me.Line2, Me.Picture1, Me.TextBox16, Me.TextBox17, Me.TextBox18, Me.TextBox19, Me.TextBox20, Me.TextBox21, Me.TextBox22})
        Me.PageHeader.Height = 2.041667!
        Me.PageHeader.Name = "PageHeader"
        '
        'txtCliente
        '
        Me.txtCliente.Border.BottomColor = System.Drawing.Color.Black
        Me.txtCliente.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCliente.Border.LeftColor = System.Drawing.Color.Black
        Me.txtCliente.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCliente.Border.RightColor = System.Drawing.Color.Black
        Me.txtCliente.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCliente.Border.TopColor = System.Drawing.Color.Black
        Me.txtCliente.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCliente.Height = 0.1875!
        Me.txtCliente.Left = 0!
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; "
        Me.txtCliente.Text = "TextBox8"
        Me.txtCliente.Top = 0.96875!
        Me.txtCliente.Width = 6.1875!
        '
        'txtFatura
        '
        Me.txtFatura.Border.BottomColor = System.Drawing.Color.Black
        Me.txtFatura.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFatura.Border.LeftColor = System.Drawing.Color.Black
        Me.txtFatura.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFatura.Border.RightColor = System.Drawing.Color.Black
        Me.txtFatura.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFatura.Border.TopColor = System.Drawing.Color.Black
        Me.txtFatura.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtFatura.Height = 0.1875!
        Me.txtFatura.Left = 0!
        Me.txtFatura.Name = "txtFatura"
        Me.txtFatura.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; "
        Me.txtFatura.Text = "TextBox8"
        Me.txtFatura.Top = 1.8125!
        Me.txtFatura.Width = 1.625!
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
        Me.Label.Left = 3.651042!
        Me.Label.Name = "Label"
        Me.Label.Style = "ddo-char-set: 0; text-align: center; font-weight: normal; font-size: 8.25pt; font" &
    "-family: Arial; "
        Me.Label.Text = "TAVEIRA COMÉRCIO DE PRODUTOS ÓTICOS LTDA"
        Me.Label.Top = 0.09375!
        Me.Label.Width = 3.625!
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
        Me.Label1.Left = 3.651042!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "ddo-char-set: 0; text-align: center; font-weight: normal; font-size: 8.25pt; font" &
    "-family: Arial; "
        Me.Label1.Text = "Rua Ó de Almeida, 298 - Térreo - Campina"
        Me.Label1.Top = 0.21875!
        Me.Label1.Width = 3.625!
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
        Me.Label2.Left = 3.651042!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "ddo-char-set: 0; text-align: center; font-weight: normal; font-size: 8.25pt; font" &
    "-family: Arial; "
        Me.Label2.Text = "Fones: (91) 3230-3124 / 3241-1837 - Fax: (91) 3241-9440"
        Me.Label2.Top = 0.375!
        Me.Label2.Width = 3.6875!
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
        Me.Label3.Left = 3.651042!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "ddo-char-set: 0; text-align: center; font-weight: normal; font-size: 8.25pt; font" &
    "-family: Arial; "
        Me.Label3.Text = "Cep: 66017-050 - Belém - Pará - Email: labonorte@ig.com.br"
        Me.Label3.Top = 0.53125!
        Me.Label3.Width = 3.6875!
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
        Me.Line2.Left = 0!
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 2.0!
        Me.Line2.Width = 10.94!
        Me.Line2.X1 = 0!
        Me.Line2.X2 = 10.94!
        Me.Line2.Y1 = 2.0!
        Me.Line2.Y2 = 2.0!
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
        Me.Picture1.Top = 0.125!
        Me.Picture1.Width = 1.3125!
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
        Me.TextBox16.Height = 0.1875!
        Me.TextBox16.Left = 1.6875!
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; "
        Me.TextBox16.Text = "Data Compra:"
        Me.TextBox16.Top = 1.8125!
        Me.TextBox16.Width = 0.8125!
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
        Me.TextBox17.DataField = "data"
        Me.TextBox17.Height = 0.1875!
        Me.TextBox17.Left = 2.5!
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.OutputFormat = resources.GetString("TextBox17.OutputFormat")
        Me.TextBox17.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; "
        Me.TextBox17.Text = "Data Compra:"
        Me.TextBox17.Top = 1.8125!
        Me.TextBox17.Width = 0.8125!
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
        Me.TextBox18.DataField = "razao_social"
        Me.TextBox18.Height = 0.1875!
        Me.TextBox18.Left = 0!
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; "
        Me.TextBox18.Text = "TextBox8"
        Me.TextBox18.Top = 1.125!
        Me.TextBox18.Width = 6.1875!
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
        Me.TextBox19.Height = 0.1875!
        Me.TextBox19.Left = 0!
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; "
        Me.TextBox19.Text = "TextBox8"
        Me.TextBox19.Top = 1.28125!
        Me.TextBox19.Width = 6.1875!
        '
        'TextBox20
        '
        Me.TextBox20.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox20.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox20.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox20.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox20.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox20.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox20.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox20.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox20.Height = 0.1875!
        Me.TextBox20.Left = 0!
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; "
        Me.TextBox20.Text = "TextBox8"
        Me.TextBox20.Top = 1.59375!
        Me.TextBox20.Width = 4.5!
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
        Me.TextBox21.Height = 0.1875!
        Me.TextBox21.Left = 0!
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; "
        Me.TextBox21.Text = "TextBox8"
        Me.TextBox21.Top = 1.4375!
        Me.TextBox21.Width = 4.5!
        '
        'TextBox22
        '
        Me.TextBox22.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox22.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox22.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox22.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox22.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox22.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox22.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox22.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox22.Height = 0.1875!
        Me.TextBox22.Left = 0!
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; "
        Me.TextBox22.Text = "TextBox8"
        Me.TextBox22.Top = 0.8125!
        Me.TextBox22.Width = 1.625!
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0!
        Me.PageFooter.Name = "PageFooter"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.BackColor = System.Drawing.Color.Silver
        Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox8, Me.TextBox10, Me.TextBox11, Me.TextBox12, Me.TextBox9, Me.TextBox15, Me.TextBox5, Me.TextBox4, Me.TextBox14, Me.TextBox23, Me.TextBox25, Me.TextBox27, Me.TextBox32, Me.TextBox34, Me.TextBox36, Me.TextBox38, Me.TextBox40, Me.TextBox42, Me.TextBox44, Me.Line4, Me.Line5, Me.Line7, Me.Line9})
        Me.GroupHeader1.Height = 0.1770833!
        Me.GroupHeader1.Name = "GroupHeader1"
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
        Me.TextBox8.Height = 0.1875!
        Me.TextBox8.Left = 0!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Style = "ddo-char-set: 0; font-weight: bold; font-size: 6.75pt; font-family: Arial; "
        Me.TextBox8.Text = "Item"
        Me.TextBox8.Top = 0!
        Me.TextBox8.Width = 0.25!
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
        Me.TextBox10.Height = 0.2!
        Me.TextBox10.Left = 0.3125!
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 6.75pt; font-fam" &
    "ily: Arial; "
        Me.TextBox10.Text = "Produto"
        Me.TextBox10.Top = 0!
        Me.TextBox10.Width = 0.7083333!
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
        Me.TextBox11.Height = 0.1875!
        Me.TextBox11.Left = 2.0!
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; font-fa" &
    "mily: Arial; "
        Me.TextBox11.Text = "Preço"
        Me.TextBox11.Top = 0!
        Me.TextBox11.Width = 0.56!
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
        Me.TextBox12.Height = 0.1875!
        Me.TextBox12.Left = 2.625!
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; font-fa" &
    "mily: Arial; "
        Me.TextBox12.Text = "Desc.%"
        Me.TextBox12.Top = 0!
        Me.TextBox12.Width = 0.38!
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
        Me.TextBox9.Height = 0.1875!
        Me.TextBox9.Left = 3.0625!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; font-fa" &
    "mily: Arial; "
        Me.TextBox9.Text = "Sub Prod"
        Me.TextBox9.Top = 0!
        Me.TextBox9.Width = 0.5!
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
        Me.TextBox15.Height = 0.1875!
        Me.TextBox15.Left = 3.625!
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; font-fa" &
    "mily: Arial; "
        Me.TextBox15.Text = "Quant"
        Me.TextBox15.Top = 0!
        Me.TextBox15.Width = 0.375!
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
        Me.TextBox5.Height = 0.1875!
        Me.TextBox5.Left = 10.4375!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; font-fa" &
    "mily: Arial; "
        Me.TextBox5.Text = "Total"
        Me.TextBox5.Top = 0!
        Me.TextBox5.Width = 0.5!
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
        Me.TextBox4.Height = 0.1875!
        Me.TextBox4.Left = 4.6875!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; font-fa" &
    "mily: Arial; "
        Me.TextBox4.Text = "Desc %"
        Me.TextBox4.Top = 0!
        Me.TextBox4.Width = 0.375!
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
        Me.TextBox14.Height = 0.1875!
        Me.TextBox14.Left = 6.1875!
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; font-fa" &
    "mily: Arial; "
        Me.TextBox14.Text = "Preço Mont"
        Me.TextBox14.Top = 0!
        Me.TextBox14.Width = 0.5625!
        '
        'TextBox23
        '
        Me.TextBox23.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox23.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox23.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox23.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox23.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox23.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox23.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox23.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox23.Height = 0.1875!
        Me.TextBox23.Left = 5.75!
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; font-fa" &
    "mily: Arial; "
        Me.TextBox23.Text = "Quant"
        Me.TextBox23.Top = 0!
        Me.TextBox23.Width = 0.375!
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
        Me.TextBox25.Height = 0.1875!
        Me.TextBox25.Left = 7.875!
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; font-fa" &
    "mily: Arial; "
        Me.TextBox25.Text = "Quant"
        Me.TextBox25.Top = 0!
        Me.TextBox25.Width = 0.375!
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
        Me.TextBox27.Height = 0.1875!
        Me.TextBox27.Left = 9.9375!
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; font-fa" &
    "mily: Arial; "
        Me.TextBox27.Text = "Quant"
        Me.TextBox27.Top = 0!
        Me.TextBox27.Width = 0.375!
        '
        'TextBox32
        '
        Me.TextBox32.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox32.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox32.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox32.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox32.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox32.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox32.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox32.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox32.Height = 0.1875!
        Me.TextBox32.Left = 4.0625!
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; font-fa" &
    "mily: Arial; "
        Me.TextBox32.Text = "Preço Surf"
        Me.TextBox32.Top = 0!
        Me.TextBox32.Width = 0.5625!
        '
        'TextBox34
        '
        Me.TextBox34.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox34.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox34.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox34.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox34.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox34.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox34.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox34.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox34.Height = 0.1875!
        Me.TextBox34.Left = 5.125!
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; font-fa" &
    "mily: Arial; "
        Me.TextBox34.Text = "Sub Surf"
        Me.TextBox34.Top = 0!
        Me.TextBox34.Width = 0.5625!
        '
        'TextBox36
        '
        Me.TextBox36.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox36.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox36.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox36.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox36.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox36.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox36.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox36.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox36.Height = 0.1875!
        Me.TextBox36.Left = 6.8125!
        Me.TextBox36.Name = "TextBox36"
        Me.TextBox36.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; font-fa" &
    "mily: Arial; "
        Me.TextBox36.Text = "Desc %"
        Me.TextBox36.Top = 0!
        Me.TextBox36.Width = 0.375!
        '
        'TextBox38
        '
        Me.TextBox38.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox38.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox38.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox38.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox38.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox38.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox38.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox38.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox38.Height = 0.1875!
        Me.TextBox38.Left = 7.25!
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; font-fa" &
    "mily: Arial; "
        Me.TextBox38.Text = "Sub Mont"
        Me.TextBox38.Top = 0!
        Me.TextBox38.Width = 0.5625!
        '
        'TextBox40
        '
        Me.TextBox40.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox40.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox40.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox40.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox40.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox40.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox40.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox40.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox40.Height = 0.1875!
        Me.TextBox40.Left = 8.3125!
        Me.TextBox40.Name = "TextBox40"
        Me.TextBox40.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; font-fa" &
    "mily: Arial; "
        Me.TextBox40.Text = "Preço Trat"
        Me.TextBox40.Top = 0!
        Me.TextBox40.Width = 0.5625!
        '
        'TextBox42
        '
        Me.TextBox42.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox42.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox42.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox42.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox42.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox42.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox42.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox42.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox42.Height = 0.1875!
        Me.TextBox42.Left = 8.9375!
        Me.TextBox42.Name = "TextBox42"
        Me.TextBox42.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; font-fa" &
    "mily: Arial; "
        Me.TextBox42.Text = "Desc %"
        Me.TextBox42.Top = 0!
        Me.TextBox42.Width = 0.375!
        '
        'TextBox44
        '
        Me.TextBox44.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox44.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox44.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox44.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox44.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox44.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox44.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox44.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox44.Height = 0.1875!
        Me.TextBox44.Left = 9.375!
        Me.TextBox44.Name = "TextBox44"
        Me.TextBox44.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; font-fa" &
    "mily: Arial; "
        Me.TextBox44.Text = "Sub Trat"
        Me.TextBox44.Top = 0!
        Me.TextBox44.Width = 0.5625!
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
        Me.Line4.Height = 0.1875!
        Me.Line4.Left = 4.04!
        Me.Line4.LineWeight = 1.0!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 0!
        Me.Line4.Width = 0!
        Me.Line4.X1 = 4.04!
        Me.Line4.X2 = 4.04!
        Me.Line4.Y1 = 0!
        Me.Line4.Y2 = 0.1875!
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
        Me.Line5.Height = 0.1875!
        Me.Line5.Left = 6.166667!
        Me.Line5.LineWeight = 1.0!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 0!
        Me.Line5.Width = 0!
        Me.Line5.X1 = 6.166667!
        Me.Line5.X2 = 6.166667!
        Me.Line5.Y1 = 0!
        Me.Line5.Y2 = 0.1875!
        '
        'Line7
        '
        Me.Line7.Border.BottomColor = System.Drawing.Color.Black
        Me.Line7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line7.Border.LeftColor = System.Drawing.Color.Black
        Me.Line7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line7.Border.RightColor = System.Drawing.Color.Black
        Me.Line7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line7.Border.TopColor = System.Drawing.Color.Black
        Me.Line7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line7.Height = 0.1875!
        Me.Line7.Left = 8.28125!
        Me.Line7.LineWeight = 1.0!
        Me.Line7.Name = "Line7"
        Me.Line7.Top = 0!
        Me.Line7.Width = 0!
        Me.Line7.X1 = 8.28125!
        Me.Line7.X2 = 8.28125!
        Me.Line7.Y1 = 0!
        Me.Line7.Y2 = 0.1875!
        '
        'Line9
        '
        Me.Line9.Border.BottomColor = System.Drawing.Color.Black
        Me.Line9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line9.Border.LeftColor = System.Drawing.Color.Black
        Me.Line9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line9.Border.RightColor = System.Drawing.Color.Black
        Me.Line9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line9.Border.TopColor = System.Drawing.Color.Black
        Me.Line9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line9.Height = 0.1875!
        Me.Line9.Left = 10.375!
        Me.Line9.LineWeight = 1.0!
        Me.Line9.Name = "Line9"
        Me.Line9.Top = 0!
        Me.Line9.Width = 0!
        Me.Line9.X1 = 10.375!
        Me.Line9.X2 = 10.375!
        Me.Line9.Y1 = 0!
        Me.Line9.Y2 = 0.1875!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox13, Me.TextBox6, Me.sbRp, Me.txtTotal, Me.Line1, Me.TextBox29, Me.TextBox30, Me.TextBox31})
        Me.GroupFooter1.Height = 0.5194445!
        Me.GroupFooter1.Name = "GroupFooter1"
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
        Me.TextBox13.Height = 0.2!
        Me.TextBox13.Left = 2.4375!
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; "
        Me.TextBox13.Text = "Total"
        Me.TextBox13.Top = 0!
        Me.TextBox13.Width = 0.53125!
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
        Me.TextBox6.DataField = "quantidade_contratada"
        Me.TextBox6.Height = 0.1875!
        Me.TextBox6.Left = 3.625!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.OutputFormat = resources.GetString("TextBox6.OutputFormat")
        Me.TextBox6.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; "
        Me.TextBox6.SummaryGroup = "GroupHeader1"
        Me.TextBox6.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox6.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox6.Text = "TextBox"
        Me.TextBox6.Top = 0!
        Me.TextBox6.Width = 0.38!
        '
        'sbRp
        '
        Me.sbRp.Border.BottomColor = System.Drawing.Color.Black
        Me.sbRp.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.sbRp.Border.LeftColor = System.Drawing.Color.Black
        Me.sbRp.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.sbRp.Border.RightColor = System.Drawing.Color.Black
        Me.sbRp.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.sbRp.Border.TopColor = System.Drawing.Color.Black
        Me.sbRp.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.sbRp.CloseBorder = False
        Me.sbRp.Height = 0.1875!
        Me.sbRp.Left = 6.1875!
        Me.sbRp.Name = "sbRp"
        Me.sbRp.Report = Nothing
        Me.sbRp.Top = 0.3125!
        Me.sbRp.Width = 4.375!
        '
        'txtTotal
        '
        Me.txtTotal.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTotal.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotal.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTotal.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotal.Border.RightColor = System.Drawing.Color.Black
        Me.txtTotal.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotal.Border.TopColor = System.Drawing.Color.Black
        Me.txtTotal.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotal.DataField = "produtos"
        Me.txtTotal.Height = 0.1875!
        Me.txtTotal.Left = 10.3125!
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.OutputFormat = resources.GetString("txtTotal.OutputFormat")
        Me.txtTotal.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; "
        Me.txtTotal.SummaryGroup = "GroupHeader1"
        Me.txtTotal.Text = "TextBox"
        Me.txtTotal.Top = 0!
        Me.txtTotal.Width = 0.625!
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
        Me.Line1.Left = 0!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0!
        Me.Line1.Width = 10.94!
        Me.Line1.X1 = 0!
        Me.Line1.X2 = 10.94!
        Me.Line1.Y1 = 0!
        Me.Line1.Y2 = 0!
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
        Me.TextBox29.DataField = "quantidade_surf"
        Me.TextBox29.Height = 0.1875!
        Me.TextBox29.Left = 5.75!
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.OutputFormat = resources.GetString("TextBox29.OutputFormat")
        Me.TextBox29.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; "
        Me.TextBox29.SummaryGroup = "GroupHeader1"
        Me.TextBox29.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox29.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox29.Text = "TextBox"
        Me.TextBox29.Top = 0!
        Me.TextBox29.Width = 0.38!
        '
        'TextBox30
        '
        Me.TextBox30.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox30.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox30.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox30.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox30.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox30.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox30.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox30.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox30.DataField = "quantidade_mont"
        Me.TextBox30.Height = 0.1875!
        Me.TextBox30.Left = 7.875!
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.OutputFormat = resources.GetString("TextBox30.OutputFormat")
        Me.TextBox30.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; "
        Me.TextBox30.SummaryGroup = "GroupHeader1"
        Me.TextBox30.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox30.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox30.Text = "TextBox"
        Me.TextBox30.Top = 0!
        Me.TextBox30.Width = 0.38!
        '
        'TextBox31
        '
        Me.TextBox31.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox31.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox31.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox31.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox31.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox31.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox31.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox31.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox31.DataField = "quantidade_trat"
        Me.TextBox31.Height = 0.1875!
        Me.TextBox31.Left = 9.94!
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.OutputFormat = resources.GetString("TextBox31.OutputFormat")
        Me.TextBox31.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; "
        Me.TextBox31.SummaryGroup = "GroupHeader1"
        Me.TextBox31.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox31.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox31.Text = "TextBox"
        Me.TextBox31.Top = 0!
        Me.TextBox31.Width = 0.38!
        '
        'rptReciboPacote
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.69!
        Me.PageSettings.PaperWidth = 8.27!
        Me.PrintWidth = 10.98958!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule(resources.GetString("$this.StyleSheet"), "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" &
            "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei" &
            "ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" &
            "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading3", "Normal"))
        Me.WatermarkPrintOnPages = "A4"
        CType(Me.txtMont, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSurf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPdesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuant, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVtot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFatura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region
    Private Sub GroupFooter1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupFooter1.Format
        r.DataSource = tRec
        r.aPagar = aPAGAR

        sbRp.Report = r
        txtTotal.Text = Format(total, "#,##0.00")
    End Sub

    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        txtCliente.Text = cliente
        txtFatura.Text = fatura
        TextBox18.Text = razao
        TextBox19.Text = endereco
        TextBox20.Text = fone
        TextBox21.Text = municipio
        TextBox22.Text = codigo

        If My.Computer.FileSystem.FileExists(conf.ImagemRelatorio) Then
            Picture1.Image = Image.FromFile(conf.ImagemRelatorio)
        End If
    End Sub

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        txtVtot.Text = Format((txtQuant.Text * CDbl(txtPdesc.Text)) + (TextBox24.Text * CDbl(TextBox35.Text)) + (TextBox26.Text * CDbl(TextBox39.Text)) + (TextBox28.Text * CDbl(TextBox7.Text)), "#,##0.00")
        total = total + txtVtot.Text
    End Sub

End Class
