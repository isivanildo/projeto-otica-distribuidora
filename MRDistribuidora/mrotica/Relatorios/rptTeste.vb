Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports mrotica_util
Public Class rptTeste
    Inherits DataDynamics.ActiveReports.ActiveReport3
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub
#Region "ActiveReports Designer generated code"
    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader = Nothing
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
    Private anterior As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox6 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label1 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label4 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label6 As DataDynamics.ActiveReports.Label
    Friend WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents TextBox As DataDynamics.ActiveReports.TextBox
    Private WithEvents ReportHeader As DataDynamics.ActiveReports.ReportHeader
    Public WithEvents Label3 As DataDynamics.ActiveReports.Label
    Private WithEvents ReportFooter As DataDynamics.ActiveReports.ReportFooter
    Private WithEvents Line9 As DataDynamics.ActiveReports.Line
    Friend WithEvents Picture1 As DataDynamics.ActiveReports.Picture
    Friend WithEvents TextBox30 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label8 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox16 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label2 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label5 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label7 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox8 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox10 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label10 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox7 As DataDynamics.ActiveReports.TextBox
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptTeste))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.anterior = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox6 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox7 = New DataDynamics.ActiveReports.TextBox()
        Me.Label4 = New DataDynamics.ActiveReports.Label()
        Me.Label6 = New DataDynamics.ActiveReports.Label()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.TextBox30 = New DataDynamics.ActiveReports.TextBox()
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader()
        Me.TextBox = New DataDynamics.ActiveReports.TextBox()
        Me.Label8 = New DataDynamics.ActiveReports.Label()
        Me.TextBox16 = New DataDynamics.ActiveReports.TextBox()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.Label5 = New DataDynamics.ActiveReports.Label()
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter()
        Me.Label7 = New DataDynamics.ActiveReports.Label()
        Me.TextBox8 = New DataDynamics.ActiveReports.TextBox()
        Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader()
        Me.Label3 = New DataDynamics.ActiveReports.Label()
        Me.Picture1 = New DataDynamics.ActiveReports.Picture()
        Me.ReportFooter = New DataDynamics.ActiveReports.ReportFooter()
        Me.Line9 = New DataDynamics.ActiveReports.Line()
        Me.TextBox10 = New DataDynamics.ActiveReports.TextBox()
        Me.Label10 = New DataDynamics.ActiveReports.Label()
        CType(Me.anterior, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.anterior, Me.TextBox6, Me.TextBox5, Me.TextBox7})
        Me.Detail.Height = 0.1458333!
        Me.Detail.Name = "Detail"
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
        Me.anterior.DataField = "historico"
        Me.anterior.Height = 0.125!
        Me.anterior.Left = 0!
        Me.anterior.Name = "anterior"
        Me.anterior.OutputFormat = resources.GetString("anterior.OutputFormat")
        Me.anterior.Style = "ddo-char-set: 1; text-align: left; font-size: 7pt; "
        Me.anterior.Text = "TextBox"
        Me.anterior.Top = 0!
        Me.anterior.Width = 5.125!
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
        Me.TextBox6.DataField = "credito"
        Me.TextBox6.Height = 0.125!
        Me.TextBox6.Left = 5.875!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.OutputFormat = resources.GetString("TextBox6.OutputFormat")
        Me.TextBox6.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; "
        Me.TextBox6.Text = "TextBox"
        Me.TextBox6.Top = 0!
        Me.TextBox6.Width = 0.5!
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
        Me.TextBox5.DataField = "data"
        Me.TextBox5.Height = 0.125!
        Me.TextBox5.Left = 5.1875!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.OutputFormat = resources.GetString("TextBox5.OutputFormat")
        Me.TextBox5.Style = "ddo-char-set: 1; text-align: left; font-size: 7pt; "
        Me.TextBox5.Text = "TextBox"
        Me.TextBox5.Top = 0!
        Me.TextBox5.Width = 0.625!
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
        Me.TextBox7.DataField = "nome"
        Me.TextBox7.Height = 0.125!
        Me.TextBox7.Left = 6.4375!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.OutputFormat = resources.GetString("TextBox7.OutputFormat")
        Me.TextBox7.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; "
        Me.TextBox7.Text = "TextBox"
        Me.TextBox7.Top = 0!
        Me.TextBox7.Width = 1.0!
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
        Me.Label4.Height = 0.125!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 0!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; font-size: 7pt; "
        Me.Label4.Text = "Historico"
        Me.Label4.Top = 0.3125!
        Me.Label4.Width = 0.5!
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
        Me.Label6.Height = 0.125!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 5.875!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 7pt; "
        Me.Label6.Text = "Cr?dito"
        Me.Label6.Top = 0.3125!
        Me.Label6.Width = 0.5!
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
        Me.Label1.Left = 0.5!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; font-size: 7pt; "
        Me.Label1.Text = "Cliente"
        Me.Label1.Top = 0!
        Me.Label1.Width = 0.375!
        '
        'PageHeader
        '
        Me.PageHeader.Height = 0!
        Me.PageHeader.Name = "PageHeader"
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox30})
        Me.PageFooter.Height = 0.28125!
        Me.PageFooter.Name = "PageFooter"
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
        Me.TextBox30.Height = 0.1875!
        Me.TextBox30.Left = 6.4375!
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Style = "text-align: right; font-size: 6.75pt; "
        Me.TextBox30.Text = "TextBox30"
        Me.TextBox30.Top = 0.0625!
        Me.TextBox30.Width = 0.875!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.BackColor = System.Drawing.Color.Silver
        Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox, Me.Label1, Me.Label8, Me.TextBox16, Me.Label4, Me.Label6, Me.Label2, Me.Label5})
        Me.GroupHeader1.DataField = "nome_cliente"
        Me.GroupHeader1.Height = 0.4270833!
        Me.GroupHeader1.Name = "GroupHeader1"
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
        Me.TextBox.DataField = "nome_cliente"
        Me.TextBox.Height = 0.1875!
        Me.TextBox.Left = 0.5!
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 6.75pt; "
        Me.TextBox.Text = "TextBox"
        Me.TextBox.Top = 0.125!
        Me.TextBox.Width = 2.9375!
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
        Me.Label8.Left = 0!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; font-size: 7pt; "
        Me.Label8.Text = "C?digo"
        Me.Label8.Top = 0!
        Me.Label8.Width = 0.375!
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
        Me.TextBox16.DataField = "cod_cliente"
        Me.TextBox16.Height = 0.1875!
        Me.TextBox16.Left = 0!
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 6.75pt; "
        Me.TextBox16.Text = "TextBox"
        Me.TextBox16.Top = 0.125!
        Me.TextBox16.Width = 0.375!
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
        Me.Label2.Height = 0.125!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 5.1875!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; font-size: 7pt; "
        Me.Label2.Text = "Data"
        Me.Label2.Top = 0.3125!
        Me.Label2.Width = 0.4375!
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
        Me.Label5.Height = 0.125!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 6.4375!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 7pt; "
        Me.Label5.Text = "Usu?rio"
        Me.Label5.Top = 0.3125!
        Me.Label5.Width = 1.0!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label7, Me.TextBox8})
        Me.GroupFooter1.Height = 0.2291667!
        Me.GroupFooter1.Name = "GroupFooter1"
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
        Me.Label7.Height = 0.125!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 5.375!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; font-size: 7pt; "
        Me.Label7.Text = "Total de Cr?dito Cedido:"
        Me.Label7.Top = 0.0625!
        Me.Label7.Width = 1.1875!
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
        Me.TextBox8.DataField = "credito"
        Me.TextBox8.Height = 0.125!
        Me.TextBox8.Left = 6.5625!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.OutputFormat = resources.GetString("TextBox8.OutputFormat")
        Me.TextBox8.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 6.75pt; "
        Me.TextBox8.SummaryGroup = "GroupHeader1"
        Me.TextBox8.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.TextBox8.Text = "TextBox"
        Me.TextBox8.Top = 0.0625!
        Me.TextBox8.Width = 0.625!
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label3, Me.Picture1})
        Me.ReportHeader.Height = 0.5833333!
        Me.ReportHeader.Name = "ReportHeader"
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
        Me.Label3.Left = 1.375!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 9.75pt; "
        Me.Label3.Text = ""
        Me.Label3.Top = 0!
        Me.Label3.Width = 5.9375!
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
        Me.Picture1.Left = 0.0625!
        Me.Picture1.LineWeight = 0!
        Me.Picture1.Name = "Picture1"
        Me.Picture1.SizeMode = DataDynamics.ActiveReports.SizeModes.Zoom
        Me.Picture1.Top = 0!
        Me.Picture1.Width = 1.3125!
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Line9, Me.TextBox10, Me.Label10})
        Me.ReportFooter.Height = 0.5104167!
        Me.ReportFooter.Name = "ReportFooter"
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
        Me.Line9.Height = 0!
        Me.Line9.Left = 0.02083333!
        Me.Line9.LineWeight = 1.0!
        Me.Line9.Name = "Line9"
        Me.Line9.Top = 0!
        Me.Line9.Width = 7.416667!
        Me.Line9.X1 = 0.02083333!
        Me.Line9.X2 = 7.4375!
        Me.Line9.Y1 = 0!
        Me.Line9.Y2 = 0!
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
        Me.TextBox10.DataField = "credito"
        Me.TextBox10.Height = 0.125!
        Me.TextBox10.Left = 6.4375!
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.OutputFormat = resources.GetString("TextBox10.OutputFormat")
        Me.TextBox10.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 6.75pt; "
        Me.TextBox10.SummaryGroup = "GroupHeader1"
        Me.TextBox10.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox10.Text = "TextBox"
        Me.TextBox10.Top = 0.0625!
        Me.TextBox10.Width = 0.875!
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
        Me.Label10.Height = 0.125!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 5.625!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; font-size: 7pt; "
        Me.Label10.Text = "Total de Cr?dito:"
        Me.Label10.Top = 0.0625!
        Me.Label10.Width = 0.8125!
        '
        'rptTeste
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.69!
        Me.PageSettings.PaperWidth = 8.27!
        Me.PrintWidth = 7.541664!
        Me.Sections.Add(Me.ReportHeader)
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.PageFooter)
        Me.Sections.Add(Me.ReportFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule(resources.GetString("$this.StyleSheet"), "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" &
            "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei" &
            "ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" &
            "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading3", "Normal"))
        CType(Me.anterior, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

    Dim d As New dados
    Dim conf As New config

    Private Sub PageFooter_Format(sender As System.Object, e As System.EventArgs) Handles PageFooter.Format
        TextBox30.Text = "P?gina: " & PageNumber
    End Sub

    Private Sub ReportHeader_Format(sender As Object, e As EventArgs) Handles ReportHeader.Format
        If My.Computer.FileSystem.FileExists(conf.ImagemRelatorio) Then
            Picture1.Image = Image.FromFile(conf.ImagemRelatorio)
        End If
    End Sub
End Class
