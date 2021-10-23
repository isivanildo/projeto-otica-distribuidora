Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports mrotica_util
Public Class rptProdutoDevolucao

    Inherits DataDynamics.ActiveReports.ActiveReport3
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Dim conf As New config

#Region "ActiveReports Designer generated code"
    Private WithEvents ReportHeader As DataDynamics.ActiveReports.ReportHeader = Nothing
    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader = Nothing
    Private WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader = Nothing
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
    Private WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter = Nothing
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
    Private WithEvents ReportFooter As DataDynamics.ActiveReports.ReportFooter = Nothing
    Private Label As DataDynamics.ActiveReports.Label
    Private Label1 As DataDynamics.ActiveReports.Label
    Private Label2 As DataDynamics.ActiveReports.Label
    Private TextBox As DataDynamics.ActiveReports.TextBox
    Private TextBox1 As DataDynamics.ActiveReports.TextBox
    Private TextBox2 As DataDynamics.ActiveReports.TextBox
    Private Line As DataDynamics.ActiveReports.Line
    Private TextBox3 As DataDynamics.ActiveReports.TextBox
    Private Line1 As DataDynamics.ActiveReports.Line
    Private Label3 As DataDynamics.ActiveReports.Label
    Private lblPag As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label4 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox6 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label5 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox7 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox8 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label7 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox9 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox10 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox11 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Shape1 As DataDynamics.ActiveReports.Shape
    Friend WithEvents Label13 As DataDynamics.ActiveReports.Label
    Friend WithEvents Shape10 As DataDynamics.ActiveReports.Shape
    Friend WithEvents Shape5 As DataDynamics.ActiveReports.Shape
    Friend WithEvents Shape9 As DataDynamics.ActiveReports.Shape
    Friend WithEvents Shape11 As DataDynamics.ActiveReports.Shape
    Friend WithEvents Label6 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label10 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label11 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label12 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label14 As DataDynamics.ActiveReports.Label
    Friend WithEvents Picture As DataDynamics.ActiveReports.Picture
    Friend WithEvents TextBox18 As DataDynamics.ActiveReports.TextBox
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptProdutoDevolucao))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.TextBox = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox()
        Me.Line = New DataDynamics.ActiveReports.Line()
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox7 = New DataDynamics.ActiveReports.TextBox()
        Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader()
        Me.Shape1 = New DataDynamics.ActiveReports.Shape()
        Me.Shape11 = New DataDynamics.ActiveReports.Shape()
        Me.Shape10 = New DataDynamics.ActiveReports.Shape()
        Me.Shape5 = New DataDynamics.ActiveReports.Shape()
        Me.Shape9 = New DataDynamics.ActiveReports.Shape()
        Me.Label7 = New DataDynamics.ActiveReports.Label()
        Me.TextBox9 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox10 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox11 = New DataDynamics.ActiveReports.TextBox()
        Me.Label13 = New DataDynamics.ActiveReports.Label()
        Me.TextBox18 = New DataDynamics.ActiveReports.TextBox()
        Me.Label10 = New DataDynamics.ActiveReports.Label()
        Me.Label11 = New DataDynamics.ActiveReports.Label()
        Me.Label12 = New DataDynamics.ActiveReports.Label()
        Me.Label14 = New DataDynamics.ActiveReports.Label()
        Me.Picture = New DataDynamics.ActiveReports.Picture()
        Me.ReportFooter = New DataDynamics.ActiveReports.ReportFooter()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.Label = New DataDynamics.ActiveReports.Label()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.Label4 = New DataDynamics.ActiveReports.Label()
        Me.Label5 = New DataDynamics.ActiveReports.Label()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.lblPag = New DataDynamics.ActiveReports.Label()
        Me.Label6 = New DataDynamics.ActiveReports.Label()
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader()
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter()
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox()
        Me.Line1 = New DataDynamics.ActiveReports.Line()
        Me.Label3 = New DataDynamics.ActiveReports.Label()
        Me.TextBox6 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox8 = New DataDynamics.ActiveReports.TextBox()
        CType(Me.TextBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox, Me.TextBox1, Me.TextBox2, Me.Line, Me.TextBox5, Me.TextBox7})
        Me.Detail.Height = 0.2!
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
        Me.TextBox.DataField = "Produto"
        Me.TextBox.Height = 0.1875!
        Me.TextBox.Left = 0.875!
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Style = "font-size: 9pt; "
        Me.TextBox.Text = "TextBox"
        Me.TextBox.Top = 0!
        Me.TextBox.Width = 4.25!
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
        Me.TextBox1.DataField = "cod_barra"
        Me.TextBox1.Height = 0.1875!
        Me.TextBox1.Left = 0!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "font-size: 9pt; "
        Me.TextBox1.Text = "TextBox1"
        Me.TextBox1.Top = 0!
        Me.TextBox1.Width = 0.8125!
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
        Me.TextBox2.DataField = "quantidade"
        Me.TextBox2.Height = 0.2!
        Me.TextBox2.Left = 5.1875!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "text-align: right; font-size: 9pt; "
        Me.TextBox2.Text = "TextBox1"
        Me.TextBox2.Top = 0!
        Me.TextBox2.Width = 0.5625!
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
        Me.Line.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line.LineWeight = 1.0!
        Me.Line.Name = "Line"
        Me.Line.Top = 0!
        Me.Line.Width = 7.8125!
        Me.Line.X1 = 0!
        Me.Line.X2 = 7.8125!
        Me.Line.Y1 = 0!
        Me.Line.Y2 = 0!
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
        Me.TextBox5.DataField = "preco_nota"
        Me.TextBox5.Height = 0.1875!
        Me.TextBox5.Left = 5.9375!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.OutputFormat = resources.GetString("TextBox5.OutputFormat")
        Me.TextBox5.Style = "text-align: right; font-size: 9pt; "
        Me.TextBox5.Text = "TextBox1"
        Me.TextBox5.Top = 0!
        Me.TextBox5.Width = 0.75!
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
        Me.TextBox7.DataField = "total"
        Me.TextBox7.Height = 0.1875!
        Me.TextBox7.Left = 6.8125!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.OutputFormat = resources.GetString("TextBox7.OutputFormat")
        Me.TextBox7.Style = "text-align: right; font-size: 9pt; "
        Me.TextBox7.Text = "TextBox1"
        Me.TextBox7.Top = 0!
        Me.TextBox7.Width = 0.9375!
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Shape1, Me.Shape11, Me.Shape10, Me.Shape5, Me.Shape9, Me.Label7, Me.TextBox9, Me.TextBox10, Me.TextBox11, Me.Label13, Me.TextBox18, Me.Label10, Me.Label11, Me.Label12, Me.Label14, Me.Picture})
        Me.ReportHeader.Height = 1.510417!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'Shape1
        '
        Me.Shape1.Border.BottomColor = System.Drawing.Color.Black
        Me.Shape1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape1.Border.LeftColor = System.Drawing.Color.Black
        Me.Shape1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape1.Border.RightColor = System.Drawing.Color.Black
        Me.Shape1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape1.Border.TopColor = System.Drawing.Color.Black
        Me.Shape1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape1.Height = 0.75!
        Me.Shape1.Left = 0!
        Me.Shape1.Name = "Shape1"
        Me.Shape1.RoundingRadius = 9.999999!
        Me.Shape1.Top = 0.6875!
        Me.Shape1.Width = 7.8125!
        '
        'Shape11
        '
        Me.Shape11.Border.BottomColor = System.Drawing.Color.Black
        Me.Shape11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape11.Border.LeftColor = System.Drawing.Color.Black
        Me.Shape11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape11.Border.RightColor = System.Drawing.Color.Black
        Me.Shape11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape11.Border.TopColor = System.Drawing.Color.Black
        Me.Shape11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape11.Height = 0.4375!
        Me.Shape11.Left = 6.6875!
        Me.Shape11.Name = "Shape11"
        Me.Shape11.RoundingRadius = 9.999999!
        Me.Shape11.Top = 0.9375!
        Me.Shape11.Width = 1.0625!
        '
        'Shape10
        '
        Me.Shape10.Border.BottomColor = System.Drawing.Color.Black
        Me.Shape10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape10.Border.LeftColor = System.Drawing.Color.Black
        Me.Shape10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape10.Border.RightColor = System.Drawing.Color.Black
        Me.Shape10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape10.Border.TopColor = System.Drawing.Color.Black
        Me.Shape10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape10.Height = 0.4375!
        Me.Shape10.Left = 3.375!
        Me.Shape10.Name = "Shape10"
        Me.Shape10.RoundingRadius = 9.999999!
        Me.Shape10.Top = 0.9375!
        Me.Shape10.Width = 3.1875!
        '
        'Shape5
        '
        Me.Shape5.Border.BottomColor = System.Drawing.Color.Black
        Me.Shape5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape5.Border.LeftColor = System.Drawing.Color.Black
        Me.Shape5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape5.Border.RightColor = System.Drawing.Color.Black
        Me.Shape5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape5.Border.TopColor = System.Drawing.Color.Black
        Me.Shape5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape5.Height = 0.4375!
        Me.Shape5.Left = 1.25!
        Me.Shape5.Name = "Shape5"
        Me.Shape5.RoundingRadius = 9.999999!
        Me.Shape5.Top = 0.9375!
        Me.Shape5.Width = 2.0!
        '
        'Shape9
        '
        Me.Shape9.Border.BottomColor = System.Drawing.Color.Black
        Me.Shape9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape9.Border.LeftColor = System.Drawing.Color.Black
        Me.Shape9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape9.Border.RightColor = System.Drawing.Color.Black
        Me.Shape9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape9.Border.TopColor = System.Drawing.Color.Black
        Me.Shape9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape9.Height = 0.4375!
        Me.Shape9.Left = 0.0625!
        Me.Shape9.Name = "Shape9"
        Me.Shape9.RoundingRadius = 9.999999!
        Me.Shape9.Top = 0.9375!
        Me.Shape9.Width = 1.0625!
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
        Me.Label7.Left = 0.125!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "text-align: right; font-weight: normal; background-color: White; font-size: 9pt; " &
    "font-family: Arial; "
        Me.Label7.Text = "Nº Nota Fiscal"
        Me.Label7.Top = 0.875!
        Me.Label7.Width = 0.875!
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
        Me.TextBox9.DataField = "nota_fiscal"
        Me.TextBox9.Height = 0.1875!
        Me.TextBox9.Left = 0.125!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Style = "text-align: right; font-weight: bold; font-size: 9pt; font-family: Arial; "
        Me.TextBox9.Text = "TextBox9"
        Me.TextBox9.Top = 1.125!
        Me.TextBox9.Width = 0.9375!
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
        Me.TextBox10.DataField = "cod_pedido"
        Me.TextBox10.Height = 0.1875!
        Me.TextBox10.Left = 1.3125!
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Style = "text-align: left; font-weight: bold; font-size: 9pt; "
        Me.TextBox10.Text = "TextBox10"
        Me.TextBox10.Top = 1.125!
        Me.TextBox10.Width = 1.875!
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
        Me.TextBox11.DataField = "fornecedor"
        Me.TextBox11.Height = 0.1875!
        Me.TextBox11.Left = 3.5!
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Style = "font-weight: bold; font-size: 9pt; "
        Me.TextBox11.Text = "TextBox11"
        Me.TextBox11.Top = 1.125!
        Me.TextBox11.Width = 3.0!
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
        Me.Label13.Height = 0.1875!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 0.25!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "text-align: left; font-weight: bold; background-color: White; font-size: 9pt; "
        Me.Label13.Text = "Detalhe da Devolução"
        Me.Label13.Top = 0.625!
        Me.Label13.Width = 1.6875!
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
        Me.TextBox18.DataField = "data"
        Me.TextBox18.Height = 0.1875!
        Me.TextBox18.Left = 6.875!
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.OutputFormat = resources.GetString("TextBox18.OutputFormat")
        Me.TextBox18.Style = "text-align: right; font-weight: bold; font-size: 9pt; "
        Me.TextBox18.Text = "TextBox18"
        Me.TextBox18.Top = 1.125!
        Me.TextBox18.Width = 0.8125!
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
        Me.Label10.Height = 0.375!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 3.0625!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "text-align: center; font-weight: bold; font-size: 9.75pt; "
        Me.Label10.Text = "Label10"
        Me.Label10.Top = 0.0625!
        Me.Label10.Width = 4.6875!
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
        Me.Label11.Height = 0.1875!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 1.5!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "text-align: right; font-weight: normal; background-color: White; font-size: 9pt; " &
    ""
        Me.Label11.Text = "Nº Pedido"
        Me.Label11.Top = 0.875!
        Me.Label11.Width = 0.625!
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
        Me.Label12.Height = 0.1875!
        Me.Label12.HyperLink = Nothing
        Me.Label12.Left = 3.5!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "font-weight: normal; background-color: White; font-size: 9pt; "
        Me.Label12.Text = "Fornecedor"
        Me.Label12.Top = 0.875!
        Me.Label12.Width = 0.6875!
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
        Me.Label14.Height = 0.1875!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 6.8125!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "font-weight: normal; background-color: White; font-size: 9pt; "
        Me.Label14.Text = "Data Entrada"
        Me.Label14.Top = 0.875!
        Me.Label14.Width = 0.8125!
        '
        'Picture
        '
        Me.Picture.Border.BottomColor = System.Drawing.Color.Black
        Me.Picture.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture.Border.LeftColor = System.Drawing.Color.Black
        Me.Picture.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture.Border.RightColor = System.Drawing.Color.Black
        Me.Picture.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture.Border.TopColor = System.Drawing.Color.Black
        Me.Picture.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture.Height = 0.5!
        Me.Picture.Image = CType(resources.GetObject("Picture.Image"), System.Drawing.Image)
        Me.Picture.ImageData = CType(resources.GetObject("Picture.ImageData"), System.IO.Stream)
        Me.Picture.Left = 0!
        Me.Picture.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Picture.LineWeight = 0!
        Me.Picture.Name = "Picture"
        Me.Picture.SizeMode = DataDynamics.ActiveReports.SizeModes.Zoom
        Me.Picture.Top = 0!
        Me.Picture.Width = 2.9375!
        '
        'ReportFooter
        '
        Me.ReportFooter.Height = 0.25!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label, Me.Label1, Me.Label2, Me.Label4, Me.Label5})
        Me.PageHeader.Height = 0.21875!
        Me.PageHeader.Name = "PageHeader"
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
        Me.Label.Left = 0.875!
        Me.Label.Name = "Label"
        Me.Label.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9pt; "
        Me.Label.Text = "Produto"
        Me.Label.Top = 0!
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
        Me.Label1.Height = 0.2!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 5.1875!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 9pt; "
        Me.Label1.Text = "Quant."
        Me.Label1.Top = 0!
        Me.Label1.Width = 0.56!
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
        Me.Label2.Left = 0!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 9pt; "
        Me.Label2.Text = "Barra"
        Me.Label2.Top = 0!
        Me.Label2.Width = 0.5!
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
        Me.Label4.Left = 5.9375!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 9pt; "
        Me.Label4.Text = "V. Unit."
        Me.Label4.Top = 0!
        Me.Label4.Width = 0.75!
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
        Me.Label5.Left = 6.8125!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 9pt; "
        Me.Label5.Text = "Total Prod."
        Me.Label5.Top = 0!
        Me.Label5.Width = 0.9375!
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblPag, Me.Label6})
        Me.PageFooter.Height = 0.3222222!
        Me.PageFooter.Name = "PageFooter"
        '
        'lblPag
        '
        Me.lblPag.Border.BottomColor = System.Drawing.Color.Black
        Me.lblPag.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblPag.Border.LeftColor = System.Drawing.Color.Black
        Me.lblPag.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblPag.Border.RightColor = System.Drawing.Color.Black
        Me.lblPag.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblPag.Border.TopColor = System.Drawing.Color.Black
        Me.lblPag.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblPag.Height = 0.2!
        Me.lblPag.HyperLink = Nothing
        Me.lblPag.Left = 6.6875!
        Me.lblPag.Name = "lblPag"
        Me.lblPag.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 9pt; "
        Me.lblPag.Text = "Produto"
        Me.lblPag.Top = 0!
        Me.lblPag.Width = 1.0!
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
        Me.Label6.Left = 0.1875!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "font-size: 9pt; "
        Me.Label6.Text = "Label6"
        Me.Label6.Top = 0.0625!
        Me.Label6.Width = 5.125!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Height = 0.1041667!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox3, Me.Line1, Me.Label3, Me.TextBox6, Me.TextBox8})
        Me.GroupFooter1.Height = 0.2618056!
        Me.GroupFooter1.Name = "GroupFooter1"
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
        Me.TextBox3.DataField = "quantidade"
        Me.TextBox3.Height = 0.1875!
        Me.TextBox3.Left = 5.1875!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "text-align: right; font-size: 9pt; "
        Me.TextBox3.SummaryGroup = "GroupHeader1"
        Me.TextBox3.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox3.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.TextBox3.Text = "TextBox1"
        Me.TextBox3.Top = 0!
        Me.TextBox3.Width = 0.5625!
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
        Me.Line1.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0!
        Me.Line1.Width = 7.8125!
        Me.Line1.X1 = 0!
        Me.Line1.X2 = 7.8125!
        Me.Line1.Y1 = 0!
        Me.Line1.Y2 = 0!
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
        Me.Label3.Left = 2.8125!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 9pt; "
        Me.Label3.Text = "Totais:"
        Me.Label3.Top = 0!
        Me.Label3.Width = 2.0!
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
        Me.TextBox6.DataField = "preco_nota"
        Me.TextBox6.Height = 0.1875!
        Me.TextBox6.Left = 5.9375!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.OutputFormat = resources.GetString("TextBox6.OutputFormat")
        Me.TextBox6.Style = "text-align: right; font-size: 9pt; "
        Me.TextBox6.SummaryGroup = "GroupHeader1"
        Me.TextBox6.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox6.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.TextBox6.Text = "TextBox1"
        Me.TextBox6.Top = 0!
        Me.TextBox6.Width = 0.75!
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
        Me.TextBox8.DataField = "total"
        Me.TextBox8.Height = 0.1875!
        Me.TextBox8.Left = 6.8125!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.OutputFormat = resources.GetString("TextBox8.OutputFormat")
        Me.TextBox8.Style = "text-align: right; font-size: 9pt; "
        Me.TextBox8.SummaryGroup = "GroupHeader1"
        Me.TextBox8.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox8.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.TextBox8.Text = "TextBox1"
        Me.TextBox8.Top = 0!
        Me.TextBox8.Width = 0.94!
        '
        'rptProdutoDevolucao
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.69!
        Me.PageSettings.PaperWidth = 8.27!
        Me.PrintWidth = 7.84375!
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
        CType(Me.TextBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

    Private Sub PageFooter_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageFooter.Format
        lblPag.Text = "Página " & Me.PageNumber
    End Sub

    Private Sub ReportHeader_Format(sender As Object, e As EventArgs) Handles ReportHeader.Format
        If My.Computer.FileSystem.FileExists(conf.ImagemRelatorio) Then
            Picture.Image = Image.FromFile(conf.ImagemRelatorio)
        End If
    End Sub
End Class
