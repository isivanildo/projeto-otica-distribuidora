Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports mrotica_util
Public Class rptDespesasAcumulado
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
	Private Label As DataDynamics.ActiveReports.Label
	Private Label1 As DataDynamics.ActiveReports.Label
	Private Label2 As DataDynamics.ActiveReports.Label
	Private Line3 As DataDynamics.ActiveReports.Line
	Private Line4 As DataDynamics.ActiveReports.Line
	Private Line5 As DataDynamics.ActiveReports.Line
	Private Line7 As DataDynamics.ActiveReports.Line
	Private Line8 As DataDynamics.ActiveReports.Line
	Private Label3 As DataDynamics.ActiveReports.Label
	Private por As DataDynamics.ActiveReports.TextBox
	Private mes As DataDynamics.ActiveReports.TextBox
	Private TextBox As DataDynamics.ActiveReports.TextBox
	Private anterior As DataDynamics.ActiveReports.TextBox
	Private Line As DataDynamics.ActiveReports.Line
	Private Line1 As DataDynamics.ActiveReports.Line
	Private Line2 As DataDynamics.ActiveReports.Line
	Private Line6 As DataDynamics.ActiveReports.Line
	Private Line10 As DataDynamics.ActiveReports.Line
	Private txtMes As DataDynamics.ActiveReports.TextBox
	Private txtPor As DataDynamics.ActiveReports.TextBox
	Private txtAnt As DataDynamics.ActiveReports.TextBox
	Private Line9 As DataDynamics.ActiveReports.Line
	Private Line11 As DataDynamics.ActiveReports.Line
	Private Line12 As DataDynamics.ActiveReports.Line
	Private Line13 As DataDynamics.ActiveReports.Line
    Private Line14 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line16 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line18 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line17 As DataDynamics.ActiveReports.Line
    Friend WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label4 As DataDynamics.ActiveReports.Label
    Friend WithEvents Line19 As DataDynamics.ActiveReports.Line
    Friend WithEvents Label5 As DataDynamics.ActiveReports.Label
    Friend WithEvents Line20 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line21 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line22 As DataDynamics.ActiveReports.Line
    Friend WithEvents Label6 As DataDynamics.ActiveReports.Label
    Friend WithEvents Line23 As DataDynamics.ActiveReports.Line
    Friend WithEvents Label7 As DataDynamics.ActiveReports.Label
    Friend WithEvents Line24 As DataDynamics.ActiveReports.Line
    Friend WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox6 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox7 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox8 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line25 As DataDynamics.ActiveReports.Line
    Friend WithEvents Label8 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label9 As DataDynamics.ActiveReports.Label
    Friend WithEvents Line26 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line27 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line28 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line29 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line30 As DataDynamics.ActiveReports.Line
    Friend WithEvents Label10 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label11 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label12 As DataDynamics.ActiveReports.Label
    Friend WithEvents Line31 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line32 As DataDynamics.ActiveReports.Line
    Friend WithEvents Label13 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label14 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox9 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox10 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line33 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line34 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line35 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line36 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line37 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line38 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line39 As DataDynamics.ActiveReports.Line
    Friend WithEvents TextBox11 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox12 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox13 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox14 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox15 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line40 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line41 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line42 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line43 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line44 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line45 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line46 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line47 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line48 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line49 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line50 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line51 As DataDynamics.ActiveReports.Line
    Friend WithEvents TextBox16 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox17 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox18 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox19 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox20 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox21 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox22 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox23 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox24 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox25 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox26 As DataDynamics.ActiveReports.TextBox
    Private Line15 As DataDynamics.ActiveReports.Line
	Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptDespesasAcumulado))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.por = New DataDynamics.ActiveReports.TextBox()
        Me.mes = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox = New DataDynamics.ActiveReports.TextBox()
        Me.anterior = New DataDynamics.ActiveReports.TextBox()
        Me.Line = New DataDynamics.ActiveReports.Line()
        Me.Line1 = New DataDynamics.ActiveReports.Line()
        Me.Line2 = New DataDynamics.ActiveReports.Line()
        Me.Line6 = New DataDynamics.ActiveReports.Line()
        Me.Line10 = New DataDynamics.ActiveReports.Line()
        Me.Line18 = New DataDynamics.ActiveReports.Line()
        Me.Line21 = New DataDynamics.ActiveReports.Line()
        Me.Line22 = New DataDynamics.ActiveReports.Line()
        Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader()
        Me.Label = New DataDynamics.ActiveReports.Label()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.Line3 = New DataDynamics.ActiveReports.Line()
        Me.Line4 = New DataDynamics.ActiveReports.Line()
        Me.Line5 = New DataDynamics.ActiveReports.Line()
        Me.Line7 = New DataDynamics.ActiveReports.Line()
        Me.Line8 = New DataDynamics.ActiveReports.Line()
        Me.Label3 = New DataDynamics.ActiveReports.Label()
        Me.Line17 = New DataDynamics.ActiveReports.Line()
        Me.Label4 = New DataDynamics.ActiveReports.Label()
        Me.Line19 = New DataDynamics.ActiveReports.Line()
        Me.Label5 = New DataDynamics.ActiveReports.Label()
        Me.Line20 = New DataDynamics.ActiveReports.Line()
        Me.Label6 = New DataDynamics.ActiveReports.Label()
        Me.Line23 = New DataDynamics.ActiveReports.Line()
        Me.Label7 = New DataDynamics.ActiveReports.Label()
        Me.Line24 = New DataDynamics.ActiveReports.Line()
        Me.ReportFooter = New DataDynamics.ActiveReports.ReportFooter()
        Me.txtMes = New DataDynamics.ActiveReports.TextBox()
        Me.txtPor = New DataDynamics.ActiveReports.TextBox()
        Me.txtAnt = New DataDynamics.ActiveReports.TextBox()
        Me.Line9 = New DataDynamics.ActiveReports.Line()
        Me.Line11 = New DataDynamics.ActiveReports.Line()
        Me.Line12 = New DataDynamics.ActiveReports.Line()
        Me.Line13 = New DataDynamics.ActiveReports.Line()
        Me.Line14 = New DataDynamics.ActiveReports.Line()
        Me.Line15 = New DataDynamics.ActiveReports.Line()
        Me.Line16 = New DataDynamics.ActiveReports.Line()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox6 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox7 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox8 = New DataDynamics.ActiveReports.TextBox()
        Me.Line25 = New DataDynamics.ActiveReports.Line()
        Me.Label8 = New DataDynamics.ActiveReports.Label()
        Me.Label9 = New DataDynamics.ActiveReports.Label()
        Me.Line26 = New DataDynamics.ActiveReports.Line()
        Me.Line27 = New DataDynamics.ActiveReports.Line()
        Me.Line28 = New DataDynamics.ActiveReports.Line()
        Me.Line29 = New DataDynamics.ActiveReports.Line()
        Me.Line30 = New DataDynamics.ActiveReports.Line()
        Me.Label10 = New DataDynamics.ActiveReports.Label()
        Me.Label11 = New DataDynamics.ActiveReports.Label()
        Me.Label12 = New DataDynamics.ActiveReports.Label()
        Me.Line31 = New DataDynamics.ActiveReports.Line()
        Me.Line32 = New DataDynamics.ActiveReports.Line()
        Me.Label13 = New DataDynamics.ActiveReports.Label()
        Me.Label14 = New DataDynamics.ActiveReports.Label()
        Me.TextBox9 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox10 = New DataDynamics.ActiveReports.TextBox()
        Me.Line33 = New DataDynamics.ActiveReports.Line()
        Me.Line34 = New DataDynamics.ActiveReports.Line()
        Me.Line35 = New DataDynamics.ActiveReports.Line()
        Me.Line36 = New DataDynamics.ActiveReports.Line()
        Me.Line37 = New DataDynamics.ActiveReports.Line()
        Me.Line38 = New DataDynamics.ActiveReports.Line()
        Me.Line39 = New DataDynamics.ActiveReports.Line()
        Me.TextBox11 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox12 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox13 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox14 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox15 = New DataDynamics.ActiveReports.TextBox()
        Me.Line40 = New DataDynamics.ActiveReports.Line()
        Me.Line41 = New DataDynamics.ActiveReports.Line()
        Me.Line42 = New DataDynamics.ActiveReports.Line()
        Me.Line43 = New DataDynamics.ActiveReports.Line()
        Me.Line44 = New DataDynamics.ActiveReports.Line()
        Me.Line45 = New DataDynamics.ActiveReports.Line()
        Me.Line46 = New DataDynamics.ActiveReports.Line()
        Me.Line47 = New DataDynamics.ActiveReports.Line()
        Me.Line48 = New DataDynamics.ActiveReports.Line()
        Me.Line49 = New DataDynamics.ActiveReports.Line()
        Me.Line50 = New DataDynamics.ActiveReports.Line()
        Me.Line51 = New DataDynamics.ActiveReports.Line()
        Me.TextBox16 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox17 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox18 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox19 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox20 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox21 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox22 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox23 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox24 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox25 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox26 = New DataDynamics.ActiveReports.TextBox()
        CType(Me.por, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.anterior, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAnt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.por, Me.mes, Me.TextBox, Me.anterior, Me.Line, Me.Line1, Me.Line2, Me.Line6, Me.Line10, Me.Line18, Me.Line21, Me.Line22, Me.TextBox5, Me.TextBox6, Me.TextBox7, Me.TextBox8, Me.Line25, Me.TextBox9, Me.TextBox10, Me.Line33, Me.Line34, Me.Line35, Me.Line36, Me.Line37, Me.Line38, Me.Line39, Me.TextBox11, Me.TextBox12, Me.TextBox13, Me.TextBox14, Me.TextBox15, Me.Line40})
        Me.Detail.Height = 0.2!
        Me.Detail.Name = "Detail"
        '
        'por
        '
        Me.por.Border.BottomColor = System.Drawing.Color.Black
        Me.por.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.por.Border.LeftColor = System.Drawing.Color.Black
        Me.por.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.por.Border.RightColor = System.Drawing.Color.Black
        Me.por.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.por.Border.TopColor = System.Drawing.Color.Black
        Me.por.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.por.Height = 0.2!
        Me.por.Left = 10.25!
        Me.por.Name = "por"
        Me.por.OutputFormat = resources.GetString("por.OutputFormat")
        Me.por.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; "
        Me.por.Text = "TextBox"
        Me.por.Top = 0.0!
        Me.por.Width = 0.56!
        '
        'mes
        '
        Me.mes.Border.BottomColor = System.Drawing.Color.Black
        Me.mes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.mes.Border.LeftColor = System.Drawing.Color.Black
        Me.mes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.mes.Border.RightColor = System.Drawing.Color.Black
        Me.mes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.mes.Border.TopColor = System.Drawing.Color.Black
        Me.mes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.mes.DataField = "acumulado_período"
        Me.mes.Height = 0.1875!
        Me.mes.Left = 2.125!
        Me.mes.Name = "mes"
        Me.mes.OutputFormat = resources.GetString("mes.OutputFormat")
        Me.mes.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; "
        Me.mes.Text = "TextBox"
        Me.mes.Top = 0.0!
        Me.mes.Width = 0.5625!
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
        Me.TextBox.DataField = "nome"
        Me.TextBox.Height = 0.1875!
        Me.TextBox.Left = 0.0625!
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Style = "ddo-char-set: 1; text-align: left; font-size: 7pt; "
        Me.TextBox.Text = "TextBox"
        Me.TextBox.Top = 0.0!
        Me.TextBox.Width = 1.9375!
        '
        'anterior
        '
        Me.anterior.Border.BottomColor = System.Drawing.Color.Black
        Me.anterior.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.anterior.Border.LeftColor = System.Drawing.Color.Black
        Me.anterior.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.anterior.Border.RightColor = System.Drawing.Color.Black
        Me.anterior.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.anterior.Border.TopColor = System.Drawing.Color.Black
        Me.anterior.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.anterior.DataField = "acumulado_mes_anterior"
        Me.anterior.Height = 0.1875!
        Me.anterior.Left = 2.75!
        Me.anterior.Name = "anterior"
        Me.anterior.OutputFormat = resources.GetString("anterior.OutputFormat")
        Me.anterior.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; "
        Me.anterior.Text = "TextBox"
        Me.anterior.Top = 0.0!
        Me.anterior.Width = 0.56!
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
        Me.Line.Height = 0.1875!
        Me.Line.Left = 2.729167!
        Me.Line.LineWeight = 1.0!
        Me.Line.Name = "Line"
        Me.Line.Top = 0.0!
        Me.Line.Width = 0.0!
        Me.Line.X1 = 2.729167!
        Me.Line.X2 = 2.729167!
        Me.Line.Y1 = 0.1875!
        Me.Line.Y2 = 0.0!
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
        Me.Line1.Height = 0.1875!
        Me.Line1.Left = 3.354167!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.0!
        Me.Line1.Width = 0.0!
        Me.Line1.X1 = 3.354167!
        Me.Line1.X2 = 3.354167!
        Me.Line1.Y1 = 0.1875!
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
        Me.Line2.Height = 0.1875!
        Me.Line2.Left = 2.125!
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0.0!
        Me.Line2.Width = 0.0!
        Me.Line2.X1 = 2.125!
        Me.Line2.X2 = 2.125!
        Me.Line2.Y1 = 0.1875!
        Me.Line2.Y2 = 0.0!
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
        Me.Line6.Left = 0.02083333!
        Me.Line6.LineWeight = 1.0!
        Me.Line6.Name = "Line6"
        Me.Line6.Top = 0.0!
        Me.Line6.Width = 10.8125!
        Me.Line6.X1 = 0.02083333!
        Me.Line6.X2 = 10.83333!
        Me.Line6.Y1 = 0.0!
        Me.Line6.Y2 = 0.0!
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
        Me.Line10.Left = 5.229167!
        Me.Line10.LineWeight = 1.0!
        Me.Line10.Name = "Line10"
        Me.Line10.Top = 0.0!
        Me.Line10.Width = 0.0!
        Me.Line10.X1 = 5.229167!
        Me.Line10.X2 = 5.229167!
        Me.Line10.Y1 = 0.1875!
        Me.Line10.Y2 = 0.0!
        '
        'Line18
        '
        Me.Line18.Border.BottomColor = System.Drawing.Color.Black
        Me.Line18.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line18.Border.LeftColor = System.Drawing.Color.Black
        Me.Line18.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line18.Border.RightColor = System.Drawing.Color.Black
        Me.Line18.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line18.Border.TopColor = System.Drawing.Color.Black
        Me.Line18.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line18.Height = 0.1875!
        Me.Line18.Left = 0.0!
        Me.Line18.LineWeight = 1.0!
        Me.Line18.Name = "Line18"
        Me.Line18.Top = 0.0!
        Me.Line18.Width = 0.0!
        Me.Line18.X1 = 0.0!
        Me.Line18.X2 = 0.0!
        Me.Line18.Y1 = 0.1875!
        Me.Line18.Y2 = 0.0!
        '
        'Line21
        '
        Me.Line21.Border.BottomColor = System.Drawing.Color.Black
        Me.Line21.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line21.Border.LeftColor = System.Drawing.Color.Black
        Me.Line21.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line21.Border.RightColor = System.Drawing.Color.Black
        Me.Line21.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line21.Border.TopColor = System.Drawing.Color.Black
        Me.Line21.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line21.Height = 0.1875!
        Me.Line21.Left = 3.979167!
        Me.Line21.LineWeight = 1.0!
        Me.Line21.Name = "Line21"
        Me.Line21.Top = 0.0!
        Me.Line21.Width = 0.0!
        Me.Line21.X1 = 3.979167!
        Me.Line21.X2 = 3.979167!
        Me.Line21.Y1 = 0.1875!
        Me.Line21.Y2 = 0.0!
        '
        'Line22
        '
        Me.Line22.Border.BottomColor = System.Drawing.Color.Black
        Me.Line22.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line22.Border.LeftColor = System.Drawing.Color.Black
        Me.Line22.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line22.Border.RightColor = System.Drawing.Color.Black
        Me.Line22.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line22.Border.TopColor = System.Drawing.Color.Black
        Me.Line22.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line22.Height = 0.1875!
        Me.Line22.Left = 4.604167!
        Me.Line22.LineWeight = 1.0!
        Me.Line22.Name = "Line22"
        Me.Line22.Top = 0.0!
        Me.Line22.Width = 0.0!
        Me.Line22.X1 = 4.604167!
        Me.Line22.X2 = 4.604167!
        Me.Line22.Y1 = 0.1875!
        Me.Line22.Y2 = 0.0!
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label, Me.Label1, Me.Label2, Me.Line3, Me.Line4, Me.Line5, Me.Line7, Me.Line8, Me.Label3, Me.Line17, Me.Label4, Me.Line19, Me.Label5, Me.Line20, Me.Label6, Me.Line23, Me.Label7, Me.Line24, Me.Label8, Me.Label9, Me.Line26, Me.Line27, Me.Line28, Me.Line29, Me.Line30, Me.Label10, Me.Label11, Me.Label12, Me.Line31, Me.Line32, Me.Label13, Me.Label14})
        Me.ReportHeader.Height = 0.7569444!
        Me.ReportHeader.Name = "ReportHeader"
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
        Me.Label.Left = 0.0625!
        Me.Label.Name = "Label"
        Me.Label.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; font-size: 7pt; "
        Me.Label.Text = "Despesa"
        Me.Label.Top = 0.375!
        Me.Label.Width = 1.0!
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
        Me.Label1.Height = 0.3125!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 2.125!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 7pt; "
        Me.Label1.Text = "Acumulado Mês"
        Me.Label1.Top = 0.375!
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
        Me.Label2.Height = 0.3125!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 2.75!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 7pt; "
        Me.Label2.Text = ""
        Me.Label2.Top = 0.375!
        Me.Label2.Width = 0.56!
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
        Me.Line3.Height = 0.375!
        Me.Line3.Left = 2.125!
        Me.Line3.LineWeight = 1.0!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 0.375!
        Me.Line3.Width = 0.0!
        Me.Line3.X1 = 2.125!
        Me.Line3.X2 = 2.125!
        Me.Line3.Y1 = 0.75!
        Me.Line3.Y2 = 0.375!
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
        Me.Line4.Height = 0.375!
        Me.Line4.Left = 2.729167!
        Me.Line4.LineWeight = 1.0!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 0.375!
        Me.Line4.Width = 0.0!
        Me.Line4.X1 = 2.729167!
        Me.Line4.X2 = 2.729167!
        Me.Line4.Y1 = 0.75!
        Me.Line4.Y2 = 0.375!
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
        Me.Line5.Height = 0.375!
        Me.Line5.Left = 3.354167!
        Me.Line5.LineWeight = 1.0!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 0.375!
        Me.Line5.Width = 0.0!
        Me.Line5.X1 = 3.354167!
        Me.Line5.X2 = 3.354167!
        Me.Line5.Y1 = 0.75!
        Me.Line5.Y2 = 0.375!
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
        Me.Line7.Height = 0.0!
        Me.Line7.Left = 0.02083333!
        Me.Line7.LineWeight = 1.0!
        Me.Line7.Name = "Line7"
        Me.Line7.Top = 0.375!
        Me.Line7.Width = 10.8125!
        Me.Line7.X1 = 0.02083333!
        Me.Line7.X2 = 10.83333!
        Me.Line7.Y1 = 0.375!
        Me.Line7.Y2 = 0.375!
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
        Me.Line8.Height = 0.375!
        Me.Line8.Left = 10.84375!
        Me.Line8.LineWeight = 1.0!
        Me.Line8.Name = "Line8"
        Me.Line8.Top = 0.375!
        Me.Line8.Width = 0.0!
        Me.Line8.X1 = 10.84375!
        Me.Line8.X2 = 10.84375!
        Me.Line8.Y1 = 0.75!
        Me.Line8.Y2 = 0.375!
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
        Me.Label3.Left = 0.0!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 9.75pt; "
        Me.Label3.Text = "Despesas Acumuladas Referente aos Períodos Abaixo"
        Me.Label3.Top = 0.0625!
        Me.Label3.Width = 11.0625!
        '
        'Line17
        '
        Me.Line17.Border.BottomColor = System.Drawing.Color.Black
        Me.Line17.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line17.Border.LeftColor = System.Drawing.Color.Black
        Me.Line17.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line17.Border.RightColor = System.Drawing.Color.Black
        Me.Line17.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line17.Border.TopColor = System.Drawing.Color.Black
        Me.Line17.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line17.Height = 0.375!
        Me.Line17.Left = 0.0!
        Me.Line17.LineWeight = 1.0!
        Me.Line17.Name = "Line17"
        Me.Line17.Top = 0.375!
        Me.Line17.Width = 0.0!
        Me.Line17.X1 = 0.0!
        Me.Line17.X2 = 0.0!
        Me.Line17.Y1 = 0.75!
        Me.Line17.Y2 = 0.375!
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
        Me.Label4.Height = 0.3125!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 3.375!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 7pt; "
        Me.Label4.Text = ""
        Me.Label4.Top = 0.375!
        Me.Label4.Width = 0.56!
        '
        'Line19
        '
        Me.Line19.Border.BottomColor = System.Drawing.Color.Black
        Me.Line19.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line19.Border.LeftColor = System.Drawing.Color.Black
        Me.Line19.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line19.Border.RightColor = System.Drawing.Color.Black
        Me.Line19.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line19.Border.TopColor = System.Drawing.Color.Black
        Me.Line19.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line19.Height = 0.375!
        Me.Line19.Left = 3.979167!
        Me.Line19.LineWeight = 1.0!
        Me.Line19.Name = "Line19"
        Me.Line19.Top = 0.375!
        Me.Line19.Width = 0.0!
        Me.Line19.X1 = 3.979167!
        Me.Line19.X2 = 3.979167!
        Me.Line19.Y1 = 0.75!
        Me.Line19.Y2 = 0.375!
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
        Me.Label5.Height = 0.3125!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 4.0!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 7pt; "
        Me.Label5.Text = ""
        Me.Label5.Top = 0.375!
        Me.Label5.Width = 0.56!
        '
        'Line20
        '
        Me.Line20.Border.BottomColor = System.Drawing.Color.Black
        Me.Line20.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line20.Border.LeftColor = System.Drawing.Color.Black
        Me.Line20.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line20.Border.RightColor = System.Drawing.Color.Black
        Me.Line20.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line20.Border.TopColor = System.Drawing.Color.Black
        Me.Line20.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line20.Height = 0.375!
        Me.Line20.Left = 4.604167!
        Me.Line20.LineWeight = 1.0!
        Me.Line20.Name = "Line20"
        Me.Line20.Top = 0.375!
        Me.Line20.Width = 0.0!
        Me.Line20.X1 = 4.604167!
        Me.Line20.X2 = 4.604167!
        Me.Line20.Y1 = 0.75!
        Me.Line20.Y2 = 0.375!
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
        Me.Label6.Height = 0.3125!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 4.625!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 7pt; "
        Me.Label6.Text = ""
        Me.Label6.Top = 0.375!
        Me.Label6.Width = 0.56!
        '
        'Line23
        '
        Me.Line23.Border.BottomColor = System.Drawing.Color.Black
        Me.Line23.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line23.Border.LeftColor = System.Drawing.Color.Black
        Me.Line23.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line23.Border.RightColor = System.Drawing.Color.Black
        Me.Line23.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line23.Border.TopColor = System.Drawing.Color.Black
        Me.Line23.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line23.Height = 0.375!
        Me.Line23.Left = 5.229167!
        Me.Line23.LineWeight = 1.0!
        Me.Line23.Name = "Line23"
        Me.Line23.Top = 0.375!
        Me.Line23.Width = 0.0!
        Me.Line23.X1 = 5.229167!
        Me.Line23.X2 = 5.229167!
        Me.Line23.Y1 = 0.75!
        Me.Line23.Y2 = 0.375!
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
        Me.Label7.Height = 0.3125!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 5.25!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 7pt; "
        Me.Label7.Text = ""
        Me.Label7.Top = 0.375!
        Me.Label7.Width = 0.56!
        '
        'Line24
        '
        Me.Line24.Border.BottomColor = System.Drawing.Color.Black
        Me.Line24.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line24.Border.LeftColor = System.Drawing.Color.Black
        Me.Line24.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line24.Border.RightColor = System.Drawing.Color.Black
        Me.Line24.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line24.Border.TopColor = System.Drawing.Color.Black
        Me.Line24.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line24.Height = 0.375!
        Me.Line24.Left = 5.84375!
        Me.Line24.LineWeight = 1.0!
        Me.Line24.Name = "Line24"
        Me.Line24.Top = 0.375!
        Me.Line24.Width = 0.0!
        Me.Line24.X1 = 5.84375!
        Me.Line24.X2 = 5.84375!
        Me.Line24.Y1 = 0.75!
        Me.Line24.Y2 = 0.375!
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtMes, Me.txtPor, Me.txtAnt, Me.Line9, Me.Line11, Me.Line12, Me.Line13, Me.Line14, Me.Line15, Me.Line16, Me.Line41, Me.Line42, Me.Line43, Me.Line44, Me.Line45, Me.Line46, Me.Line47, Me.Line48, Me.Line49, Me.Line50, Me.Line51, Me.TextBox16, Me.TextBox17, Me.TextBox18, Me.TextBox19, Me.TextBox20, Me.TextBox21, Me.TextBox22, Me.TextBox23, Me.TextBox24, Me.TextBox25, Me.TextBox26})
        Me.ReportFooter.Height = 0.2291667!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'txtMes
        '
        Me.txtMes.Border.BottomColor = System.Drawing.Color.Black
        Me.txtMes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMes.Border.LeftColor = System.Drawing.Color.Black
        Me.txtMes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMes.Border.RightColor = System.Drawing.Color.Black
        Me.txtMes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMes.Border.TopColor = System.Drawing.Color.Black
        Me.txtMes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMes.DataField = "acumulado_período"
        Me.txtMes.Height = 0.1875!
        Me.txtMes.Left = 2.125!
        Me.txtMes.Name = "txtMes"
        Me.txtMes.OutputFormat = resources.GetString("txtMes.OutputFormat")
        Me.txtMes.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 7pt; "
        Me.txtMes.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.txtMes.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.txtMes.Text = "TextBox"
        Me.txtMes.Top = 0.0!
        Me.txtMes.Width = 0.5625!
        '
        'txtPor
        '
        Me.txtPor.Border.BottomColor = System.Drawing.Color.Black
        Me.txtPor.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPor.Border.LeftColor = System.Drawing.Color.Black
        Me.txtPor.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPor.Border.RightColor = System.Drawing.Color.Black
        Me.txtPor.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPor.Border.TopColor = System.Drawing.Color.Black
        Me.txtPor.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPor.Height = 0.2!
        Me.txtPor.Left = 10.25!
        Me.txtPor.Name = "txtPor"
        Me.txtPor.OutputFormat = resources.GetString("txtPor.OutputFormat")
        Me.txtPor.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 7pt; "
        Me.txtPor.Text = "TextBox"
        Me.txtPor.Top = 0.0!
        Me.txtPor.Width = 0.56!
        '
        'txtAnt
        '
        Me.txtAnt.Border.BottomColor = System.Drawing.Color.Black
        Me.txtAnt.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAnt.Border.LeftColor = System.Drawing.Color.Black
        Me.txtAnt.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAnt.Border.RightColor = System.Drawing.Color.Black
        Me.txtAnt.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAnt.Border.TopColor = System.Drawing.Color.Black
        Me.txtAnt.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAnt.DataField = "acumulado_mes_anterior"
        Me.txtAnt.Height = 0.2!
        Me.txtAnt.Left = 2.75!
        Me.txtAnt.Name = "txtAnt"
        Me.txtAnt.OutputFormat = resources.GetString("txtAnt.OutputFormat")
        Me.txtAnt.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 7pt; "
        Me.txtAnt.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.txtAnt.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.txtAnt.Text = "TextBox"
        Me.txtAnt.Top = 0.0!
        Me.txtAnt.Width = 0.56!
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
        Me.Line9.Height = 0.0!
        Me.Line9.Left = 0.02083333!
        Me.Line9.LineWeight = 1.0!
        Me.Line9.Name = "Line9"
        Me.Line9.Top = 0.0!
        Me.Line9.Width = 10.8125!
        Me.Line9.X1 = 0.02083333!
        Me.Line9.X2 = 10.83333!
        Me.Line9.Y1 = 0.0!
        Me.Line9.Y2 = 0.0!
        '
        'Line11
        '
        Me.Line11.Border.BottomColor = System.Drawing.Color.Black
        Me.Line11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line11.Border.LeftColor = System.Drawing.Color.Black
        Me.Line11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line11.Border.RightColor = System.Drawing.Color.Black
        Me.Line11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line11.Border.TopColor = System.Drawing.Color.Black
        Me.Line11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line11.Height = 0.1875!
        Me.Line11.Left = 3.35!
        Me.Line11.LineWeight = 1.0!
        Me.Line11.Name = "Line11"
        Me.Line11.Top = 0.0!
        Me.Line11.Width = 0.0!
        Me.Line11.X1 = 3.35!
        Me.Line11.X2 = 3.35!
        Me.Line11.Y1 = 0.1875!
        Me.Line11.Y2 = 0.0!
        '
        'Line12
        '
        Me.Line12.Border.BottomColor = System.Drawing.Color.Black
        Me.Line12.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line12.Border.LeftColor = System.Drawing.Color.Black
        Me.Line12.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line12.Border.RightColor = System.Drawing.Color.Black
        Me.Line12.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line12.Border.TopColor = System.Drawing.Color.Black
        Me.Line12.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line12.Height = 0.1875!
        Me.Line12.Left = 2.125!
        Me.Line12.LineWeight = 1.0!
        Me.Line12.Name = "Line12"
        Me.Line12.Top = 0.0!
        Me.Line12.Width = 0.0!
        Me.Line12.X1 = 2.125!
        Me.Line12.X2 = 2.125!
        Me.Line12.Y1 = 0.1875!
        Me.Line12.Y2 = 0.0!
        '
        'Line13
        '
        Me.Line13.Border.BottomColor = System.Drawing.Color.Black
        Me.Line13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line13.Border.LeftColor = System.Drawing.Color.Black
        Me.Line13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line13.Border.RightColor = System.Drawing.Color.Black
        Me.Line13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line13.Border.TopColor = System.Drawing.Color.Black
        Me.Line13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line13.Height = 0.1875!
        Me.Line13.Left = 0.4375!
        Me.Line13.LineWeight = 1.0!
        Me.Line13.Name = "Line13"
        Me.Line13.Top = 0.0!
        Me.Line13.Width = 0.0!
        Me.Line13.X1 = 0.4375!
        Me.Line13.X2 = 0.4375!
        Me.Line13.Y1 = 0.1875!
        Me.Line13.Y2 = 0.0!
        '
        'Line14
        '
        Me.Line14.Border.BottomColor = System.Drawing.Color.Black
        Me.Line14.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line14.Border.LeftColor = System.Drawing.Color.Black
        Me.Line14.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line14.Border.RightColor = System.Drawing.Color.Black
        Me.Line14.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line14.Border.TopColor = System.Drawing.Color.Black
        Me.Line14.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line14.Height = 0.0!
        Me.Line14.Left = 0.4375!
        Me.Line14.LineWeight = 1.0!
        Me.Line14.Name = "Line14"
        Me.Line14.Top = 0.1875!
        Me.Line14.Width = 10.41667!
        Me.Line14.X1 = 0.4375!
        Me.Line14.X2 = 10.85417!
        Me.Line14.Y1 = 0.1875!
        Me.Line14.Y2 = 0.1875!
        '
        'Line15
        '
        Me.Line15.Border.BottomColor = System.Drawing.Color.Black
        Me.Line15.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line15.Border.LeftColor = System.Drawing.Color.Black
        Me.Line15.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line15.Border.RightColor = System.Drawing.Color.Black
        Me.Line15.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line15.Border.TopColor = System.Drawing.Color.Black
        Me.Line15.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line15.Height = 0.1875!
        Me.Line15.Left = 9.59!
        Me.Line15.LineWeight = 1.0!
        Me.Line15.Name = "Line15"
        Me.Line15.Top = 0.0!
        Me.Line15.Width = 0.0!
        Me.Line15.X1 = 9.59!
        Me.Line15.X2 = 9.59!
        Me.Line15.Y1 = 0.1875!
        Me.Line15.Y2 = 0.0!
        '
        'Line16
        '
        Me.Line16.Border.BottomColor = System.Drawing.Color.Black
        Me.Line16.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line16.Border.LeftColor = System.Drawing.Color.Black
        Me.Line16.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line16.Border.RightColor = System.Drawing.Color.Black
        Me.Line16.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line16.Border.TopColor = System.Drawing.Color.Black
        Me.Line16.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line16.Height = 0.1875!
        Me.Line16.Left = 2.729167!
        Me.Line16.LineWeight = 1.0!
        Me.Line16.Name = "Line16"
        Me.Line16.Top = 0.0!
        Me.Line16.Width = 0.0!
        Me.Line16.X1 = 2.729167!
        Me.Line16.X2 = 2.729167!
        Me.Line16.Y1 = 0.1875!
        Me.Line16.Y2 = 0.0!
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
        Me.TextBox5.DataField = "acumulado_mes_anterior2"
        Me.TextBox5.Height = 0.2!
        Me.TextBox5.Left = 3.375!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.OutputFormat = resources.GetString("TextBox5.OutputFormat")
        Me.TextBox5.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; "
        Me.TextBox5.Text = "TextBox"
        Me.TextBox5.Top = 0.0!
        Me.TextBox5.Width = 0.56!
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
        Me.TextBox6.DataField = "acumulado_mes_anterior3"
        Me.TextBox6.Height = 0.2!
        Me.TextBox6.Left = 4.0!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.OutputFormat = resources.GetString("TextBox6.OutputFormat")
        Me.TextBox6.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; "
        Me.TextBox6.Text = "TextBox"
        Me.TextBox6.Top = 0.0!
        Me.TextBox6.Width = 0.56!
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
        Me.TextBox7.DataField = "acumulado_mes_anterior4"
        Me.TextBox7.Height = 0.2!
        Me.TextBox7.Left = 4.625!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.OutputFormat = resources.GetString("TextBox7.OutputFormat")
        Me.TextBox7.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; "
        Me.TextBox7.Text = "TextBox"
        Me.TextBox7.Top = 0.0!
        Me.TextBox7.Width = 0.56!
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
        Me.TextBox8.DataField = "acumulado_mes_anterior5"
        Me.TextBox8.Height = 0.2!
        Me.TextBox8.Left = 5.25!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.OutputFormat = resources.GetString("TextBox8.OutputFormat")
        Me.TextBox8.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; "
        Me.TextBox8.Text = "TextBox"
        Me.TextBox8.Top = 0.0!
        Me.TextBox8.Width = 0.56!
        '
        'Line25
        '
        Me.Line25.Border.BottomColor = System.Drawing.Color.Black
        Me.Line25.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line25.Border.LeftColor = System.Drawing.Color.Black
        Me.Line25.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line25.Border.RightColor = System.Drawing.Color.Black
        Me.Line25.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line25.Border.TopColor = System.Drawing.Color.Black
        Me.Line25.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line25.Height = 0.1875!
        Me.Line25.Left = 5.84!
        Me.Line25.LineWeight = 1.0!
        Me.Line25.Name = "Line25"
        Me.Line25.Top = 0.0!
        Me.Line25.Width = 0.0!
        Me.Line25.X1 = 5.84!
        Me.Line25.X2 = 5.84!
        Me.Line25.Y1 = 0.1875!
        Me.Line25.Y2 = 0.0!
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
        Me.Label8.Height = 0.3125!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 5.875!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 7pt; "
        Me.Label8.Text = ""
        Me.Label8.Top = 0.375!
        Me.Label8.Width = 0.56!
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
        Me.Label9.Height = 0.3125!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 6.5!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 7pt; "
        Me.Label9.Text = ""
        Me.Label9.Top = 0.375!
        Me.Label9.Width = 0.56!
        '
        'Line26
        '
        Me.Line26.Border.BottomColor = System.Drawing.Color.Black
        Me.Line26.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line26.Border.LeftColor = System.Drawing.Color.Black
        Me.Line26.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line26.Border.RightColor = System.Drawing.Color.Black
        Me.Line26.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line26.Border.TopColor = System.Drawing.Color.Black
        Me.Line26.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line26.Height = 0.375!
        Me.Line26.Left = 6.46875!
        Me.Line26.LineWeight = 1.0!
        Me.Line26.Name = "Line26"
        Me.Line26.Top = 0.375!
        Me.Line26.Width = 0.0!
        Me.Line26.X1 = 6.46875!
        Me.Line26.X2 = 6.46875!
        Me.Line26.Y1 = 0.75!
        Me.Line26.Y2 = 0.375!
        '
        'Line27
        '
        Me.Line27.Border.BottomColor = System.Drawing.Color.Black
        Me.Line27.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line27.Border.LeftColor = System.Drawing.Color.Black
        Me.Line27.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line27.Border.RightColor = System.Drawing.Color.Black
        Me.Line27.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line27.Border.TopColor = System.Drawing.Color.Black
        Me.Line27.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line27.Height = 0.375!
        Me.Line27.Left = 7.104167!
        Me.Line27.LineWeight = 1.0!
        Me.Line27.Name = "Line27"
        Me.Line27.Top = 0.375!
        Me.Line27.Width = 0.0!
        Me.Line27.X1 = 7.104167!
        Me.Line27.X2 = 7.104167!
        Me.Line27.Y1 = 0.75!
        Me.Line27.Y2 = 0.375!
        '
        'Line28
        '
        Me.Line28.Border.BottomColor = System.Drawing.Color.Black
        Me.Line28.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line28.Border.LeftColor = System.Drawing.Color.Black
        Me.Line28.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line28.Border.RightColor = System.Drawing.Color.Black
        Me.Line28.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line28.Border.TopColor = System.Drawing.Color.Black
        Me.Line28.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line28.Height = 0.375!
        Me.Line28.Left = 7.71875!
        Me.Line28.LineWeight = 1.0!
        Me.Line28.Name = "Line28"
        Me.Line28.Top = 0.375!
        Me.Line28.Width = 0.0!
        Me.Line28.X1 = 7.71875!
        Me.Line28.X2 = 7.71875!
        Me.Line28.Y1 = 0.75!
        Me.Line28.Y2 = 0.375!
        '
        'Line29
        '
        Me.Line29.Border.BottomColor = System.Drawing.Color.Black
        Me.Line29.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line29.Border.LeftColor = System.Drawing.Color.Black
        Me.Line29.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line29.Border.RightColor = System.Drawing.Color.Black
        Me.Line29.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line29.Border.TopColor = System.Drawing.Color.Black
        Me.Line29.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line29.Height = 0.375!
        Me.Line29.Left = 8.96875!
        Me.Line29.LineWeight = 1.0!
        Me.Line29.Name = "Line29"
        Me.Line29.Top = 0.375!
        Me.Line29.Width = 0.0!
        Me.Line29.X1 = 8.96875!
        Me.Line29.X2 = 8.96875!
        Me.Line29.Y1 = 0.75!
        Me.Line29.Y2 = 0.375!
        '
        'Line30
        '
        Me.Line30.Border.BottomColor = System.Drawing.Color.Black
        Me.Line30.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line30.Border.LeftColor = System.Drawing.Color.Black
        Me.Line30.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line30.Border.RightColor = System.Drawing.Color.Black
        Me.Line30.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line30.Border.TopColor = System.Drawing.Color.Black
        Me.Line30.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line30.Height = 0.375!
        Me.Line30.Left = 8.34375!
        Me.Line30.LineWeight = 1.0!
        Me.Line30.Name = "Line30"
        Me.Line30.Top = 0.375!
        Me.Line30.Width = 0.0!
        Me.Line30.X1 = 8.34375!
        Me.Line30.X2 = 8.34375!
        Me.Line30.Y1 = 0.75!
        Me.Line30.Y2 = 0.375!
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
        Me.Label10.Height = 0.3125!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 7.125!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 7pt; "
        Me.Label10.Text = ""
        Me.Label10.Top = 0.375!
        Me.Label10.Width = 0.56!
        '
        'Label11
        '
        Me.Label11.Border.BottomColor = System.Drawing.Color.Black
        Me.Label11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label11.Border.LeftColor = System.Drawing.Color.Black
        Me.Label11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label11.Border.RightColor = System.Drawing.Color.Black
        Me.Label11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label11.Border.TopColor = System.Drawing.Color.Black
        Me.Label11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label11.Height = 0.3125!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 7.75!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 7pt; "
        Me.Label11.Text = ""
        Me.Label11.Top = 0.375!
        Me.Label11.Width = 0.56!
        '
        'Label12
        '
        Me.Label12.Border.BottomColor = System.Drawing.Color.Black
        Me.Label12.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label12.Border.LeftColor = System.Drawing.Color.Black
        Me.Label12.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label12.Border.RightColor = System.Drawing.Color.Black
        Me.Label12.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label12.Border.TopColor = System.Drawing.Color.Black
        Me.Label12.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label12.Height = 0.3125!
        Me.Label12.HyperLink = Nothing
        Me.Label12.Left = 8.375!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 7pt; "
        Me.Label12.Text = ""
        Me.Label12.Top = 0.375!
        Me.Label12.Width = 0.56!
        '
        'Line31
        '
        Me.Line31.Border.BottomColor = System.Drawing.Color.Black
        Me.Line31.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line31.Border.LeftColor = System.Drawing.Color.Black
        Me.Line31.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line31.Border.RightColor = System.Drawing.Color.Black
        Me.Line31.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line31.Border.TopColor = System.Drawing.Color.Black
        Me.Line31.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line31.Height = 0.375!
        Me.Line31.Left = 9.59375!
        Me.Line31.LineWeight = 1.0!
        Me.Line31.Name = "Line31"
        Me.Line31.Top = 0.375!
        Me.Line31.Width = 0.0!
        Me.Line31.X1 = 9.59375!
        Me.Line31.X2 = 9.59375!
        Me.Line31.Y1 = 0.75!
        Me.Line31.Y2 = 0.375!
        '
        'Line32
        '
        Me.Line32.Border.BottomColor = System.Drawing.Color.Black
        Me.Line32.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line32.Border.LeftColor = System.Drawing.Color.Black
        Me.Line32.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line32.Border.RightColor = System.Drawing.Color.Black
        Me.Line32.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line32.Border.TopColor = System.Drawing.Color.Black
        Me.Line32.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line32.Height = 0.375!
        Me.Line32.Left = 10.21875!
        Me.Line32.LineWeight = 1.0!
        Me.Line32.Name = "Line32"
        Me.Line32.Top = 0.375!
        Me.Line32.Width = 0.0!
        Me.Line32.X1 = 10.21875!
        Me.Line32.X2 = 10.21875!
        Me.Line32.Y1 = 0.75!
        Me.Line32.Y2 = 0.375!
        '
        'Label13
        '
        Me.Label13.Border.BottomColor = System.Drawing.Color.Black
        Me.Label13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label13.Border.LeftColor = System.Drawing.Color.Black
        Me.Label13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label13.Border.RightColor = System.Drawing.Color.Black
        Me.Label13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label13.Border.TopColor = System.Drawing.Color.Black
        Me.Label13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label13.Height = 0.3125!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 9.0!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 7pt; "
        Me.Label13.Text = ""
        Me.Label13.Top = 0.375!
        Me.Label13.Width = 0.56!
        '
        'Label14
        '
        Me.Label14.Border.BottomColor = System.Drawing.Color.Black
        Me.Label14.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label14.Border.LeftColor = System.Drawing.Color.Black
        Me.Label14.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label14.Border.RightColor = System.Drawing.Color.Black
        Me.Label14.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label14.Border.TopColor = System.Drawing.Color.Black
        Me.Label14.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label14.Height = 0.3125!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 9.625!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 7pt; "
        Me.Label14.Text = ""
        Me.Label14.Top = 0.375!
        Me.Label14.Width = 0.56!
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
        Me.TextBox9.DataField = "acumulado_mes_anterior6"
        Me.TextBox9.Height = 0.2!
        Me.TextBox9.Left = 5.875!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.OutputFormat = resources.GetString("TextBox9.OutputFormat")
        Me.TextBox9.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; "
        Me.TextBox9.Text = "TextBox"
        Me.TextBox9.Top = 0.0!
        Me.TextBox9.Width = 0.56!
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
        Me.TextBox10.DataField = "acumulado_mes_anterior7"
        Me.TextBox10.Height = 0.2!
        Me.TextBox10.Left = 6.5!
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.OutputFormat = resources.GetString("TextBox10.OutputFormat")
        Me.TextBox10.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; "
        Me.TextBox10.Text = "TextBox"
        Me.TextBox10.Top = 0.0!
        Me.TextBox10.Width = 0.56!
        '
        'Line33
        '
        Me.Line33.Border.BottomColor = System.Drawing.Color.Black
        Me.Line33.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line33.Border.LeftColor = System.Drawing.Color.Black
        Me.Line33.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line33.Border.RightColor = System.Drawing.Color.Black
        Me.Line33.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line33.Border.TopColor = System.Drawing.Color.Black
        Me.Line33.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line33.Height = 0.1875!
        Me.Line33.Left = 6.47!
        Me.Line33.LineWeight = 1.0!
        Me.Line33.Name = "Line33"
        Me.Line33.Top = 0.0!
        Me.Line33.Width = 0.0!
        Me.Line33.X1 = 6.47!
        Me.Line33.X2 = 6.47!
        Me.Line33.Y1 = 0.1875!
        Me.Line33.Y2 = 0.0!
        '
        'Line34
        '
        Me.Line34.Border.BottomColor = System.Drawing.Color.Black
        Me.Line34.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line34.Border.LeftColor = System.Drawing.Color.Black
        Me.Line34.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line34.Border.RightColor = System.Drawing.Color.Black
        Me.Line34.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line34.Border.TopColor = System.Drawing.Color.Black
        Me.Line34.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line34.Height = 0.1875!
        Me.Line34.Left = 7.1!
        Me.Line34.LineWeight = 1.0!
        Me.Line34.Name = "Line34"
        Me.Line34.Top = 0.0!
        Me.Line34.Width = 0.0!
        Me.Line34.X1 = 7.1!
        Me.Line34.X2 = 7.1!
        Me.Line34.Y1 = 0.1875!
        Me.Line34.Y2 = 0.0!
        '
        'Line35
        '
        Me.Line35.Border.BottomColor = System.Drawing.Color.Black
        Me.Line35.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line35.Border.LeftColor = System.Drawing.Color.Black
        Me.Line35.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line35.Border.RightColor = System.Drawing.Color.Black
        Me.Line35.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line35.Border.TopColor = System.Drawing.Color.Black
        Me.Line35.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line35.Height = 0.1875!
        Me.Line35.Left = 7.72!
        Me.Line35.LineWeight = 1.0!
        Me.Line35.Name = "Line35"
        Me.Line35.Top = 0.0!
        Me.Line35.Width = 0.0!
        Me.Line35.X1 = 7.72!
        Me.Line35.X2 = 7.72!
        Me.Line35.Y1 = 0.1875!
        Me.Line35.Y2 = 0.0!
        '
        'Line36
        '
        Me.Line36.Border.BottomColor = System.Drawing.Color.Black
        Me.Line36.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line36.Border.LeftColor = System.Drawing.Color.Black
        Me.Line36.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line36.Border.RightColor = System.Drawing.Color.Black
        Me.Line36.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line36.Border.TopColor = System.Drawing.Color.Black
        Me.Line36.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line36.Height = 0.1875!
        Me.Line36.Left = 8.34!
        Me.Line36.LineWeight = 1.0!
        Me.Line36.Name = "Line36"
        Me.Line36.Top = 0.0!
        Me.Line36.Width = 0.0!
        Me.Line36.X1 = 8.34!
        Me.Line36.X2 = 8.34!
        Me.Line36.Y1 = 0.1875!
        Me.Line36.Y2 = 0.0!
        '
        'Line37
        '
        Me.Line37.Border.BottomColor = System.Drawing.Color.Black
        Me.Line37.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line37.Border.LeftColor = System.Drawing.Color.Black
        Me.Line37.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line37.Border.RightColor = System.Drawing.Color.Black
        Me.Line37.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line37.Border.TopColor = System.Drawing.Color.Black
        Me.Line37.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line37.Height = 0.1875!
        Me.Line37.Left = 8.97!
        Me.Line37.LineWeight = 1.0!
        Me.Line37.Name = "Line37"
        Me.Line37.Top = 0.0!
        Me.Line37.Width = 0.0!
        Me.Line37.X1 = 8.97!
        Me.Line37.X2 = 8.97!
        Me.Line37.Y1 = 0.1875!
        Me.Line37.Y2 = 0.0!
        '
        'Line38
        '
        Me.Line38.Border.BottomColor = System.Drawing.Color.Black
        Me.Line38.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line38.Border.LeftColor = System.Drawing.Color.Black
        Me.Line38.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line38.Border.RightColor = System.Drawing.Color.Black
        Me.Line38.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line38.Border.TopColor = System.Drawing.Color.Black
        Me.Line38.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line38.Height = 0.1875!
        Me.Line38.Left = 9.59!
        Me.Line38.LineWeight = 1.0!
        Me.Line38.Name = "Line38"
        Me.Line38.Top = 0.0!
        Me.Line38.Width = 0.0!
        Me.Line38.X1 = 9.59!
        Me.Line38.X2 = 9.59!
        Me.Line38.Y1 = 0.1875!
        Me.Line38.Y2 = 0.0!
        '
        'Line39
        '
        Me.Line39.Border.BottomColor = System.Drawing.Color.Black
        Me.Line39.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line39.Border.LeftColor = System.Drawing.Color.Black
        Me.Line39.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line39.Border.RightColor = System.Drawing.Color.Black
        Me.Line39.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line39.Border.TopColor = System.Drawing.Color.Black
        Me.Line39.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line39.Height = 0.1875!
        Me.Line39.Left = 10.22!
        Me.Line39.LineWeight = 1.0!
        Me.Line39.Name = "Line39"
        Me.Line39.Top = 0.0!
        Me.Line39.Width = 0.0!
        Me.Line39.X1 = 10.22!
        Me.Line39.X2 = 10.22!
        Me.Line39.Y1 = 0.1875!
        Me.Line39.Y2 = 0.0!
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
        Me.TextBox11.DataField = "acumulado_mes_anterior8"
        Me.TextBox11.Height = 0.2!
        Me.TextBox11.Left = 7.125!
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.OutputFormat = resources.GetString("TextBox11.OutputFormat")
        Me.TextBox11.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; "
        Me.TextBox11.Text = "TextBox"
        Me.TextBox11.Top = 0.0!
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
        Me.TextBox12.DataField = "acumulado_mes_anterior9"
        Me.TextBox12.Height = 0.2!
        Me.TextBox12.Left = 7.75!
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.OutputFormat = resources.GetString("TextBox12.OutputFormat")
        Me.TextBox12.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; "
        Me.TextBox12.Text = "TextBox"
        Me.TextBox12.Top = 0.0!
        Me.TextBox12.Width = 0.56!
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
        Me.TextBox13.DataField = "acumulado_mes_anterior10"
        Me.TextBox13.Height = 0.2!
        Me.TextBox13.Left = 8.375!
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.OutputFormat = resources.GetString("TextBox13.OutputFormat")
        Me.TextBox13.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; "
        Me.TextBox13.Text = "TextBox"
        Me.TextBox13.Top = 0.0!
        Me.TextBox13.Width = 0.56!
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
        Me.TextBox14.DataField = "acumulado_mes_anterior11"
        Me.TextBox14.Height = 0.2!
        Me.TextBox14.Left = 9.0!
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.OutputFormat = resources.GetString("TextBox14.OutputFormat")
        Me.TextBox14.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; "
        Me.TextBox14.Text = "TextBox"
        Me.TextBox14.Top = 0.0!
        Me.TextBox14.Width = 0.56!
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
        Me.TextBox15.DataField = "acumulado_mes_anterior12"
        Me.TextBox15.Height = 0.2!
        Me.TextBox15.Left = 9.625!
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.OutputFormat = resources.GetString("TextBox15.OutputFormat")
        Me.TextBox15.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; "
        Me.TextBox15.Text = "TextBox"
        Me.TextBox15.Top = 0.0!
        Me.TextBox15.Width = 0.56!
        '
        'Line40
        '
        Me.Line40.Border.BottomColor = System.Drawing.Color.Black
        Me.Line40.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line40.Border.LeftColor = System.Drawing.Color.Black
        Me.Line40.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line40.Border.RightColor = System.Drawing.Color.Black
        Me.Line40.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line40.Border.TopColor = System.Drawing.Color.Black
        Me.Line40.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line40.Height = 0.1875!
        Me.Line40.Left = 10.84!
        Me.Line40.LineWeight = 1.0!
        Me.Line40.Name = "Line40"
        Me.Line40.Top = 0.0!
        Me.Line40.Width = 0.0!
        Me.Line40.X1 = 10.84!
        Me.Line40.X2 = 10.84!
        Me.Line40.Y1 = 0.1875!
        Me.Line40.Y2 = 0.0!
        '
        'Line41
        '
        Me.Line41.Border.BottomColor = System.Drawing.Color.Black
        Me.Line41.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line41.Border.LeftColor = System.Drawing.Color.Black
        Me.Line41.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line41.Border.RightColor = System.Drawing.Color.Black
        Me.Line41.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line41.Border.TopColor = System.Drawing.Color.Black
        Me.Line41.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line41.Height = 0.1875!
        Me.Line41.Left = 10.84!
        Me.Line41.LineWeight = 1.0!
        Me.Line41.Name = "Line41"
        Me.Line41.Top = 0.0!
        Me.Line41.Width = 0.0!
        Me.Line41.X1 = 10.84!
        Me.Line41.X2 = 10.84!
        Me.Line41.Y1 = 0.1875!
        Me.Line41.Y2 = 0.0!
        '
        'Line42
        '
        Me.Line42.Border.BottomColor = System.Drawing.Color.Black
        Me.Line42.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line42.Border.LeftColor = System.Drawing.Color.Black
        Me.Line42.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line42.Border.RightColor = System.Drawing.Color.Black
        Me.Line42.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line42.Border.TopColor = System.Drawing.Color.Black
        Me.Line42.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line42.Height = 0.1875!
        Me.Line42.Left = 10.22!
        Me.Line42.LineWeight = 1.0!
        Me.Line42.Name = "Line42"
        Me.Line42.Top = 0.0!
        Me.Line42.Width = 0.0!
        Me.Line42.X1 = 10.22!
        Me.Line42.X2 = 10.22!
        Me.Line42.Y1 = 0.1875!
        Me.Line42.Y2 = 0.0!
        '
        'Line43
        '
        Me.Line43.Border.BottomColor = System.Drawing.Color.Black
        Me.Line43.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line43.Border.LeftColor = System.Drawing.Color.Black
        Me.Line43.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line43.Border.RightColor = System.Drawing.Color.Black
        Me.Line43.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line43.Border.TopColor = System.Drawing.Color.Black
        Me.Line43.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line43.Height = 0.1875!
        Me.Line43.Left = 8.97!
        Me.Line43.LineWeight = 1.0!
        Me.Line43.Name = "Line43"
        Me.Line43.Top = 0.0!
        Me.Line43.Width = 0.0!
        Me.Line43.X1 = 8.97!
        Me.Line43.X2 = 8.97!
        Me.Line43.Y1 = 0.1875!
        Me.Line43.Y2 = 0.0!
        '
        'Line44
        '
        Me.Line44.Border.BottomColor = System.Drawing.Color.Black
        Me.Line44.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line44.Border.LeftColor = System.Drawing.Color.Black
        Me.Line44.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line44.Border.RightColor = System.Drawing.Color.Black
        Me.Line44.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line44.Border.TopColor = System.Drawing.Color.Black
        Me.Line44.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line44.Height = 0.1875!
        Me.Line44.Left = 8.34!
        Me.Line44.LineWeight = 1.0!
        Me.Line44.Name = "Line44"
        Me.Line44.Top = 0.0!
        Me.Line44.Width = 0.0!
        Me.Line44.X1 = 8.34!
        Me.Line44.X2 = 8.34!
        Me.Line44.Y1 = 0.1875!
        Me.Line44.Y2 = 0.0!
        '
        'Line45
        '
        Me.Line45.Border.BottomColor = System.Drawing.Color.Black
        Me.Line45.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line45.Border.LeftColor = System.Drawing.Color.Black
        Me.Line45.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line45.Border.RightColor = System.Drawing.Color.Black
        Me.Line45.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line45.Border.TopColor = System.Drawing.Color.Black
        Me.Line45.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line45.Height = 0.1875!
        Me.Line45.Left = 7.72!
        Me.Line45.LineWeight = 1.0!
        Me.Line45.Name = "Line45"
        Me.Line45.Top = 0.0!
        Me.Line45.Width = 0.0!
        Me.Line45.X1 = 7.72!
        Me.Line45.X2 = 7.72!
        Me.Line45.Y1 = 0.1875!
        Me.Line45.Y2 = 0.0!
        '
        'Line46
        '
        Me.Line46.Border.BottomColor = System.Drawing.Color.Black
        Me.Line46.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line46.Border.LeftColor = System.Drawing.Color.Black
        Me.Line46.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line46.Border.RightColor = System.Drawing.Color.Black
        Me.Line46.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line46.Border.TopColor = System.Drawing.Color.Black
        Me.Line46.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line46.Height = 0.1875!
        Me.Line46.Left = 7.1!
        Me.Line46.LineWeight = 1.0!
        Me.Line46.Name = "Line46"
        Me.Line46.Top = 0.0!
        Me.Line46.Width = 0.0!
        Me.Line46.X1 = 7.1!
        Me.Line46.X2 = 7.1!
        Me.Line46.Y1 = 0.1875!
        Me.Line46.Y2 = 0.0!
        '
        'Line47
        '
        Me.Line47.Border.BottomColor = System.Drawing.Color.Black
        Me.Line47.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line47.Border.LeftColor = System.Drawing.Color.Black
        Me.Line47.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line47.Border.RightColor = System.Drawing.Color.Black
        Me.Line47.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line47.Border.TopColor = System.Drawing.Color.Black
        Me.Line47.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line47.Height = 0.1875!
        Me.Line47.Left = 6.47!
        Me.Line47.LineWeight = 1.0!
        Me.Line47.Name = "Line47"
        Me.Line47.Top = 0.0!
        Me.Line47.Width = 0.0!
        Me.Line47.X1 = 6.47!
        Me.Line47.X2 = 6.47!
        Me.Line47.Y1 = 0.1875!
        Me.Line47.Y2 = 0.0!
        '
        'Line48
        '
        Me.Line48.Border.BottomColor = System.Drawing.Color.Black
        Me.Line48.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line48.Border.LeftColor = System.Drawing.Color.Black
        Me.Line48.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line48.Border.RightColor = System.Drawing.Color.Black
        Me.Line48.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line48.Border.TopColor = System.Drawing.Color.Black
        Me.Line48.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line48.Height = 0.1875!
        Me.Line48.Left = 5.84!
        Me.Line48.LineWeight = 1.0!
        Me.Line48.Name = "Line48"
        Me.Line48.Top = 0.0!
        Me.Line48.Width = 0.0!
        Me.Line48.X1 = 5.84!
        Me.Line48.X2 = 5.84!
        Me.Line48.Y1 = 0.1875!
        Me.Line48.Y2 = 0.0!
        '
        'Line49
        '
        Me.Line49.Border.BottomColor = System.Drawing.Color.Black
        Me.Line49.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line49.Border.LeftColor = System.Drawing.Color.Black
        Me.Line49.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line49.Border.RightColor = System.Drawing.Color.Black
        Me.Line49.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line49.Border.TopColor = System.Drawing.Color.Black
        Me.Line49.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line49.Height = 0.1875!
        Me.Line49.Left = 5.23!
        Me.Line49.LineWeight = 1.0!
        Me.Line49.Name = "Line49"
        Me.Line49.Top = 0.0!
        Me.Line49.Width = 0.0!
        Me.Line49.X1 = 5.23!
        Me.Line49.X2 = 5.23!
        Me.Line49.Y1 = 0.1875!
        Me.Line49.Y2 = 0.0!
        '
        'Line50
        '
        Me.Line50.Border.BottomColor = System.Drawing.Color.Black
        Me.Line50.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line50.Border.LeftColor = System.Drawing.Color.Black
        Me.Line50.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line50.Border.RightColor = System.Drawing.Color.Black
        Me.Line50.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line50.Border.TopColor = System.Drawing.Color.Black
        Me.Line50.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line50.Height = 0.1875!
        Me.Line50.Left = 4.6!
        Me.Line50.LineWeight = 1.0!
        Me.Line50.Name = "Line50"
        Me.Line50.Top = 0.0!
        Me.Line50.Width = 0.0!
        Me.Line50.X1 = 4.6!
        Me.Line50.X2 = 4.6!
        Me.Line50.Y1 = 0.1875!
        Me.Line50.Y2 = 0.0!
        '
        'Line51
        '
        Me.Line51.Border.BottomColor = System.Drawing.Color.Black
        Me.Line51.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line51.Border.LeftColor = System.Drawing.Color.Black
        Me.Line51.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line51.Border.RightColor = System.Drawing.Color.Black
        Me.Line51.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line51.Border.TopColor = System.Drawing.Color.Black
        Me.Line51.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line51.Height = 0.1875!
        Me.Line51.Left = 3.98!
        Me.Line51.LineWeight = 1.0!
        Me.Line51.Name = "Line51"
        Me.Line51.Top = 0.0!
        Me.Line51.Width = 0.0!
        Me.Line51.X1 = 3.98!
        Me.Line51.X2 = 3.98!
        Me.Line51.Y1 = 0.1875!
        Me.Line51.Y2 = 0.0!
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
        Me.TextBox16.DataField = "acumulado_mes_anterior2"
        Me.TextBox16.Height = 0.2!
        Me.TextBox16.Left = 3.375!
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.OutputFormat = resources.GetString("TextBox16.OutputFormat")
        Me.TextBox16.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 7pt; "
        Me.TextBox16.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.TextBox16.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox16.Text = "TextBox"
        Me.TextBox16.Top = 0.0!
        Me.TextBox16.Width = 0.56!
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
        Me.TextBox17.DataField = "acumulado_mes_anterior3"
        Me.TextBox17.Height = 0.2!
        Me.TextBox17.Left = 4.0!
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.OutputFormat = resources.GetString("TextBox17.OutputFormat")
        Me.TextBox17.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 7pt; "
        Me.TextBox17.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.TextBox17.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox17.Text = "TextBox"
        Me.TextBox17.Top = 0.0!
        Me.TextBox17.Width = 0.56!
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
        Me.TextBox18.DataField = "acumulado_mes_anterior4"
        Me.TextBox18.Height = 0.2!
        Me.TextBox18.Left = 4.625!
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.OutputFormat = resources.GetString("TextBox18.OutputFormat")
        Me.TextBox18.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 7pt; "
        Me.TextBox18.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.TextBox18.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox18.Text = "TextBox"
        Me.TextBox18.Top = 0.0!
        Me.TextBox18.Width = 0.56!
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
        Me.TextBox19.DataField = "acumulado_mes_anterior5"
        Me.TextBox19.Height = 0.2!
        Me.TextBox19.Left = 5.25!
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.OutputFormat = resources.GetString("TextBox19.OutputFormat")
        Me.TextBox19.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 7pt; "
        Me.TextBox19.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.TextBox19.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox19.Text = "TextBox"
        Me.TextBox19.Top = 0.0!
        Me.TextBox19.Width = 0.56!
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
        Me.TextBox20.DataField = "acumulado_mes_anterior6"
        Me.TextBox20.Height = 0.2!
        Me.TextBox20.Left = 5.875!
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.OutputFormat = resources.GetString("TextBox20.OutputFormat")
        Me.TextBox20.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 7pt; "
        Me.TextBox20.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.TextBox20.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox20.Text = "TextBox"
        Me.TextBox20.Top = 0.0!
        Me.TextBox20.Width = 0.56!
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
        Me.TextBox21.DataField = "acumulado_mes_anterior7"
        Me.TextBox21.Height = 0.2!
        Me.TextBox21.Left = 6.5!
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.OutputFormat = resources.GetString("TextBox21.OutputFormat")
        Me.TextBox21.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 7pt; "
        Me.TextBox21.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.TextBox21.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox21.Text = "TextBox"
        Me.TextBox21.Top = 0.0!
        Me.TextBox21.Width = 0.56!
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
        Me.TextBox22.DataField = "acumulado_mes_anterior8"
        Me.TextBox22.Height = 0.2!
        Me.TextBox22.Left = 7.125!
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.OutputFormat = resources.GetString("TextBox22.OutputFormat")
        Me.TextBox22.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 7pt; "
        Me.TextBox22.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.TextBox22.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox22.Text = "TextBox"
        Me.TextBox22.Top = 0.0!
        Me.TextBox22.Width = 0.56!
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
        Me.TextBox23.DataField = "acumulado_mes_anterior9"
        Me.TextBox23.Height = 0.2!
        Me.TextBox23.Left = 7.75!
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.OutputFormat = resources.GetString("TextBox23.OutputFormat")
        Me.TextBox23.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 7pt; "
        Me.TextBox23.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.TextBox23.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox23.Text = "TextBox"
        Me.TextBox23.Top = 0.0!
        Me.TextBox23.Width = 0.56!
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
        Me.TextBox24.DataField = "acumulado_mes_anterior10"
        Me.TextBox24.Height = 0.2!
        Me.TextBox24.Left = 8.375!
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.OutputFormat = resources.GetString("TextBox24.OutputFormat")
        Me.TextBox24.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 7pt; "
        Me.TextBox24.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.TextBox24.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox24.Text = "TextBox"
        Me.TextBox24.Top = 0.0!
        Me.TextBox24.Width = 0.56!
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
        Me.TextBox25.DataField = "acumulado_mes_anterior11"
        Me.TextBox25.Height = 0.2!
        Me.TextBox25.Left = 9.0!
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.OutputFormat = resources.GetString("TextBox25.OutputFormat")
        Me.TextBox25.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 7pt; "
        Me.TextBox25.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.TextBox25.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox25.Text = "TextBox"
        Me.TextBox25.Top = 0.0!
        Me.TextBox25.Width = 0.56!
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
        Me.TextBox26.DataField = "acumulado_mes_anterior12"
        Me.TextBox26.Height = 0.2!
        Me.TextBox26.Left = 9.625!
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.OutputFormat = resources.GetString("TextBox26.OutputFormat")
        Me.TextBox26.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 7pt; "
        Me.TextBox26.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.TextBox26.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox26.Text = "TextBox"
        Me.TextBox26.Top = 0.0!
        Me.TextBox26.Width = 0.56!
        '
        'rptDespesasAcumulado
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.69!
        Me.PageSettings.PaperWidth = 8.27!
        Me.PrintWidth = 11.0625!
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
        CType(Me.por, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.anterior, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAnt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

	#End Region
    Public dia As Date
    Dim di, df, dai, daf, dai2, daf2, dai3, daf3, dai4, daf4, dai5, daf5, dai6, daf6, dai7, daf7, dai8, daf8, dai9, daf9,
        dai10, daf10, dai11, daf11, dai12, daf12 As Date
    Dim sql As String
    Dim d As New dados
    Dim tt As New DataTable
    Dim conf As New config
    Private Sub rptDespesasAcumulado_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        df = dia.Date & " 23:59:59"
        di = CDate("01/" & dia.Month & "/" & dia.Year) & " 00:00:01"
        dai = DateAdd(DateInterval.Month, -1, di)
        daf = DateAdd(DateInterval.Month, -1, df)
        dai2 = DateAdd(DateInterval.Month, -2, di)
        daf2 = DateAdd(DateInterval.Month, -2, df)
        dai3 = DateAdd(DateInterval.Month, -3, di)
        daf3 = DateAdd(DateInterval.Month, -3, df)
        dai4 = DateAdd(DateInterval.Month, -4, di)
        daf4 = DateAdd(DateInterval.Month, -4, df)
        dai5 = DateAdd(DateInterval.Month, -5, di)
        daf5 = DateAdd(DateInterval.Month, -5, df)
        dai6 = DateAdd(DateInterval.Month, -6, di)
        daf6 = DateAdd(DateInterval.Month, -6, df)
        dai7 = DateAdd(DateInterval.Month, -7, di)
        daf7 = DateAdd(DateInterval.Month, -7, df)
        dai8 = DateAdd(DateInterval.Month, -8, di)
        daf8 = DateAdd(DateInterval.Month, -8, df)
        dai9 = DateAdd(DateInterval.Month, -9, di)
        daf9 = DateAdd(DateInterval.Month, -9, df)
        dai10 = DateAdd(DateInterval.Month, -10, di)
        daf10 = DateAdd(DateInterval.Month, -10, df)
        dai11 = DateAdd(DateInterval.Month, -11, di)
        daf11 = DateAdd(DateInterval.Month, -11, df)
        dai12 = DateAdd(DateInterval.Month, -12, di)
        daf12 = DateAdd(DateInterval.Month, -12, df)
        Label2.Text = dai.Month & "/" & dai.Year
        Label4.Text = dai2.Month & "/" & dai2.Year
        Label5.Text = dai3.Month & "/" & dai3.Year()
        Label6.Text = dai4.Month & "/" & dai4.Year
        Label7.Text = dai5.Month & "/" & dai5.Year
        Label8.Text = dai6.Month & "/" & dai6.Year
        Label9.Text = dai7.Month & "/" & dai7.Year
        Label10.Text = dai8.Month & "/" & dai8.Year
        Label11.Text = dai9.Month & "/" & dai9.Year
        Label12.Text = dai10.Month & "/" & dai10.Year
        Label13.Text = dai11.Month & "/" & dai11.Year
        Label14.Text = dai12.Month & "/" & dai12.Year
        sql = "SELECT NOME, CLASSIFICACAO, Acumulado_período, Acumulado_mes_anterior, Acumulado_mes_anterior2, Acumulado_mes_anterior3, " &
            "Acumulado_mes_anterior4, Acumulado_mes_anterior5, Acumulado_mes_anterior6, Acumulado_mes_anterior7, Acumulado_mes_anterior8, " &
            "Acumulado_mes_anterior9, Acumulado_mes_anterior10, Acumulado_mes_anterior11, Acumulado_mes_anterior12 " &
        "FROM dbo.Despesas(" & d.pdtm(di) & "," & d.pdtm(df) & "," & d.pdtm(dai) & "," & d.pdtm(daf) &
        "," & d.pdtm(dai2) & "," & d.pdtm(daf2) & "," & d.pdtm(dai3) & "," & d.pdtm(daf3) & "," &
         d.pdtm(dai4) & "," & d.pdtm(daf4) & "," & d.pdtm(dai5) & "," & d.pdtm(daf5) & "," &
         d.pdtm(dai6) & "," & d.pdtm(daf6) & "," & d.pdtm(dai7) & "," & d.pdtm(daf7) & "," &
         d.pdtm(dai8) & "," & d.pdtm(daf8) & "," & d.pdtm(dai9) & "," & d.pdtm(daf9) & "," &
         d.pdtm(dai10) & "," & d.pdtm(daf10) & "," & d.pdtm(dai11) & "," & d.pdtm(daf11) & "," &
         d.pdtm(dai12) & "," & d.pdtm(daf12) & "," & conf.Filial & ") AS Despesas " &
        " where (Acumulado_período > 0 Or Acumulado_mes_anterior > 0 Or Acumulado_mes_anterior2 > 0 " &
        "Or Acumulado_mes_anterior3 > 0 Or Acumulado_mes_anterior4 > 0 Or Acumulado_mes_anterior5 > 0 Or " &
        "Acumulado_mes_anterior6 > 0 Or Acumulado_mes_anterior7 > 0 Or Acumulado_mes_anterior8 > 0 Or " &
        "Acumulado_mes_anterior9 > 0 Or Acumulado_mes_anterior10 > 0 Or Acumulado_mes_anterior11 > 0 Or " &
        "Acumulado_mes_anterior12 > 0) ORDER BY nome"
        d.carrega_Tabela(sql, tt)
        Me.DataSource = tt
    End Sub

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        Try
            'por.Text = (mes.Text / anterior.Text) * 100
            por.Text = Format((mes.Text / (CDbl(anterior.Text) + CDbl(TextBox5.Text) + CDbl(TextBox6.Text) + CDbl(TextBox7.Text) + CDbl(TextBox8.Text) + CDbl(TextBox9.Text) + CDbl(TextBox10.Text) + CDbl(TextBox11.Text) + CDbl(TextBox12.Text) + CDbl(TextBox13.Text) + CDbl(TextBox14.Text) + CDbl(TextBox15.Text))) * 100, "#,##0.00") & "%"
            If por.Text = "+Infinito%" Then
                por.Text = "0,00%"
            End If
        Catch ex As Exception
            por.Text = 0
        End Try
    End Sub

    Private Sub ReportFooter_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportFooter.Format
        Try
            txtPor.Text = Format((txtMes.Text / (CDbl(txtAnt.Text) + CDbl(TextBox16.Text) + CDbl(TextBox17.Text) + CDbl(TextBox18.Text) + CDbl(TextBox19.Text) + CDbl(TextBox20.Text) + CDbl(TextBox21.Text) + CDbl(TextBox22.Text) + CDbl(TextBox23.Text) + CDbl(TextBox24.Text) + CDbl(TextBox25.Text) + CDbl(TextBox26.Text))) * 100, "#,##0.00") & "%"
        Catch ex As Exception
            txtPor.Text = 0
        End Try
    End Sub

    Private Sub ReportHeader_Format(sender As System.Object, e As System.EventArgs) Handles ReportHeader.Format

    End Sub
End Class
