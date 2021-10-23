Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class rptEspelhoNota

    Inherits DataDynamics.ActiveReports.ActiveReport3
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
    Friend WithEvents Label8 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox10 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label9 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox11 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label10 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox12 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label11 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox13 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label12 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox14 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Shape1 As DataDynamics.ActiveReports.Shape
    Friend WithEvents Label13 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label14 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label15 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label16 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox15 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox16 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox17 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Shape2 As DataDynamics.ActiveReports.Shape
    Friend WithEvents Label17 As DataDynamics.ActiveReports.Label
    Friend WithEvents CheckBox1 As DataDynamics.ActiveReports.CheckBox
    Friend WithEvents CheckBox2 As DataDynamics.ActiveReports.CheckBox
    Friend WithEvents Shape4 As DataDynamics.ActiveReports.Shape
    Friend WithEvents Shape3 As DataDynamics.ActiveReports.Shape
    Friend WithEvents Shape8 As DataDynamics.ActiveReports.Shape
    Friend WithEvents Shape7 As DataDynamics.ActiveReports.Shape
    Friend WithEvents Shape6 As DataDynamics.ActiveReports.Shape
    Friend WithEvents Line2 As DataDynamics.ActiveReports.Line
    Friend WithEvents Shape10 As DataDynamics.ActiveReports.Shape
    Friend WithEvents Shape5 As DataDynamics.ActiveReports.Shape
    Friend WithEvents Shape9 As DataDynamics.ActiveReports.Shape
    Friend WithEvents Shape12 As DataDynamics.ActiveReports.Shape
    Friend WithEvents Shape11 As DataDynamics.ActiveReports.Shape
    Friend WithEvents Label18 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label6 As DataDynamics.ActiveReports.Label
    Friend WithEvents Shape13 As DataDynamics.ActiveReports.Shape
    Friend WithEvents Label19 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Shape14 As DataDynamics.ActiveReports.Shape
    Friend WithEvents Label20 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox19 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label21 As DataDynamics.ActiveReports.Label
    Friend WithEvents Picture As DataDynamics.ActiveReports.Picture
    Friend WithEvents Label22 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox18 As DataDynamics.ActiveReports.TextBox
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptEspelhoNota))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.TextBox = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox()
        Me.Line = New DataDynamics.ActiveReports.Line()
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox7 = New DataDynamics.ActiveReports.TextBox()
        Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader()
        Me.Shape1 = New DataDynamics.ActiveReports.Shape()
        Me.Shape13 = New DataDynamics.ActiveReports.Shape()
        Me.Shape11 = New DataDynamics.ActiveReports.Shape()
        Me.Shape10 = New DataDynamics.ActiveReports.Shape()
        Me.Label9 = New DataDynamics.ActiveReports.Label()
        Me.Shape5 = New DataDynamics.ActiveReports.Shape()
        Me.Shape9 = New DataDynamics.ActiveReports.Shape()
        Me.Shape12 = New DataDynamics.ActiveReports.Shape()
        Me.Shape8 = New DataDynamics.ActiveReports.Shape()
        Me.Shape7 = New DataDynamics.ActiveReports.Shape()
        Me.Shape6 = New DataDynamics.ActiveReports.Shape()
        Me.Shape4 = New DataDynamics.ActiveReports.Shape()
        Me.Shape3 = New DataDynamics.ActiveReports.Shape()
        Me.Label7 = New DataDynamics.ActiveReports.Label()
        Me.TextBox9 = New DataDynamics.ActiveReports.TextBox()
        Me.Label8 = New DataDynamics.ActiveReports.Label()
        Me.TextBox10 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox11 = New DataDynamics.ActiveReports.TextBox()
        Me.Label10 = New DataDynamics.ActiveReports.Label()
        Me.TextBox12 = New DataDynamics.ActiveReports.TextBox()
        Me.Label11 = New DataDynamics.ActiveReports.Label()
        Me.TextBox13 = New DataDynamics.ActiveReports.TextBox()
        Me.Label12 = New DataDynamics.ActiveReports.Label()
        Me.TextBox14 = New DataDynamics.ActiveReports.TextBox()
        Me.Label13 = New DataDynamics.ActiveReports.Label()
        Me.Label14 = New DataDynamics.ActiveReports.Label()
        Me.Label15 = New DataDynamics.ActiveReports.Label()
        Me.Label16 = New DataDynamics.ActiveReports.Label()
        Me.TextBox15 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox16 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox17 = New DataDynamics.ActiveReports.TextBox()
        Me.Shape2 = New DataDynamics.ActiveReports.Shape()
        Me.Label17 = New DataDynamics.ActiveReports.Label()
        Me.CheckBox1 = New DataDynamics.ActiveReports.CheckBox()
        Me.CheckBox2 = New DataDynamics.ActiveReports.CheckBox()
        Me.Line2 = New DataDynamics.ActiveReports.Line()
        Me.Label18 = New DataDynamics.ActiveReports.Label()
        Me.TextBox18 = New DataDynamics.ActiveReports.TextBox()
        Me.Label19 = New DataDynamics.ActiveReports.Label()
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox()
        Me.Shape14 = New DataDynamics.ActiveReports.Shape()
        Me.Label20 = New DataDynamics.ActiveReports.Label()
        Me.TextBox19 = New DataDynamics.ActiveReports.TextBox()
        Me.Label21 = New DataDynamics.ActiveReports.Label()
        Me.Picture = New DataDynamics.ActiveReports.Picture()
        Me.Label22 = New DataDynamics.ActiveReports.Label()
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
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TextBox.Height = 0.2!
        Me.TextBox.Left = 0.875!
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Style = "font-size: 8.25pt; "
        Me.TextBox.Text = "TextBox"
        Me.TextBox.Top = 0!
        Me.TextBox.Width = 5.4375!
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
        Me.TextBox1.Style = "font-size: 8.25pt; "
        Me.TextBox1.Text = "TextBox1"
        Me.TextBox1.Top = 0!
        Me.TextBox1.Width = 0.75!
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
        Me.TextBox2.Left = 7.3125!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "text-align: right; font-size: 8.25pt; "
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
        Me.Line.Width = 10.8125!
        Me.Line.X1 = 0!
        Me.Line.X2 = 10.8125!
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
        Me.TextBox5.Left = 8.3125!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.OutputFormat = resources.GetString("TextBox5.OutputFormat")
        Me.TextBox5.Style = "text-align: right; font-size: 8.25pt; "
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
        Me.TextBox7.Left = 9.4375!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.OutputFormat = resources.GetString("TextBox7.OutputFormat")
        Me.TextBox7.Style = "text-align: right; font-size: 8.25pt; "
        Me.TextBox7.Text = "TextBox1"
        Me.TextBox7.Top = 0!
        Me.TextBox7.Width = 0.9375!
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Shape1, Me.Shape13, Me.Shape11, Me.Shape10, Me.Label9, Me.Shape5, Me.Shape9, Me.Shape12, Me.Shape8, Me.Shape7, Me.Shape6, Me.Shape4, Me.Shape3, Me.Label7, Me.TextBox9, Me.Label8, Me.TextBox10, Me.TextBox11, Me.Label10, Me.TextBox12, Me.Label11, Me.TextBox13, Me.Label12, Me.TextBox14, Me.Label13, Me.Label14, Me.Label15, Me.Label16, Me.TextBox15, Me.TextBox16, Me.TextBox17, Me.Shape2, Me.Label17, Me.CheckBox1, Me.CheckBox2, Me.Line2, Me.Label18, Me.TextBox18, Me.Label19, Me.TextBox4, Me.Shape14, Me.Label20, Me.TextBox19, Me.Label21, Me.Picture, Me.Label22})
        Me.ReportHeader.Height = 2.78125!
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
        Me.Shape1.Height = 2.0625!
        Me.Shape1.Left = 0!
        Me.Shape1.Name = "Shape1"
        Me.Shape1.RoundingRadius = 9.999999!
        Me.Shape1.Top = 0.6875!
        Me.Shape1.Width = 10.8125!
        '
        'Shape13
        '
        Me.Shape13.Border.BottomColor = System.Drawing.Color.Black
        Me.Shape13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape13.Border.LeftColor = System.Drawing.Color.Black
        Me.Shape13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape13.Border.RightColor = System.Drawing.Color.Black
        Me.Shape13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape13.Border.TopColor = System.Drawing.Color.Black
        Me.Shape13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape13.Height = 0.5625!
        Me.Shape13.Left = 0.0625!
        Me.Shape13.Name = "Shape13"
        Me.Shape13.RoundingRadius = 9.999999!
        Me.Shape13.Top = 2.125!
        Me.Shape13.Width = 8.5625!
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
        Me.Shape11.Height = 0.375!
        Me.Shape11.Left = 8.375!
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
        Me.Shape10.Height = 0.375!
        Me.Shape10.Left = 4.125!
        Me.Shape10.Name = "Shape10"
        Me.Shape10.RoundingRadius = 9.999999!
        Me.Shape10.Top = 0.9375!
        Me.Shape10.Width = 4.125!
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
        Me.Label9.Left = 4.25!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "font-weight: bold; background-color: White; font-size: 8.25pt; font-family: Arial" &
    "; "
        Me.Label9.Text = "Fornecedor"
        Me.Label9.Top = 0.875!
        Me.Label9.Width = 0.6875!
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
        Me.Shape5.Height = 0.375!
        Me.Shape5.Left = 1.75!
        Me.Shape5.Name = "Shape5"
        Me.Shape5.RoundingRadius = 9.999999!
        Me.Shape5.Top = 0.9375!
        Me.Shape5.Width = 2.25!
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
        Me.Shape9.Height = 0.375!
        Me.Shape9.Left = 0.0625!
        Me.Shape9.Name = "Shape9"
        Me.Shape9.RoundingRadius = 9.999999!
        Me.Shape9.Top = 0.9375!
        Me.Shape9.Width = 1.5!
        '
        'Shape12
        '
        Me.Shape12.Border.BottomColor = System.Drawing.Color.Black
        Me.Shape12.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape12.Border.LeftColor = System.Drawing.Color.Black
        Me.Shape12.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape12.Border.RightColor = System.Drawing.Color.Black
        Me.Shape12.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape12.Border.TopColor = System.Drawing.Color.Black
        Me.Shape12.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape12.Height = 0.375!
        Me.Shape12.Left = 3.0625!
        Me.Shape12.Name = "Shape12"
        Me.Shape12.RoundingRadius = 9.999999!
        Me.Shape12.Top = 1.625!
        Me.Shape12.Width = 1.1875!
        '
        'Shape8
        '
        Me.Shape8.Border.BottomColor = System.Drawing.Color.Black
        Me.Shape8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape8.Border.LeftColor = System.Drawing.Color.Black
        Me.Shape8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape8.Border.RightColor = System.Drawing.Color.Black
        Me.Shape8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape8.Border.TopColor = System.Drawing.Color.Black
        Me.Shape8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape8.Height = 0.375!
        Me.Shape8.Left = 6.8125!
        Me.Shape8.Name = "Shape8"
        Me.Shape8.RoundingRadius = 9.999999!
        Me.Shape8.Top = 1.625!
        Me.Shape8.Width = 1.3125!
        '
        'Shape7
        '
        Me.Shape7.Border.BottomColor = System.Drawing.Color.Black
        Me.Shape7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape7.Border.LeftColor = System.Drawing.Color.Black
        Me.Shape7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape7.Border.RightColor = System.Drawing.Color.Black
        Me.Shape7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape7.Border.TopColor = System.Drawing.Color.Black
        Me.Shape7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape7.Height = 0.375!
        Me.Shape7.Left = 5.5625!
        Me.Shape7.Name = "Shape7"
        Me.Shape7.RoundingRadius = 9.999999!
        Me.Shape7.Top = 1.625!
        Me.Shape7.Width = 1.1875!
        '
        'Shape6
        '
        Me.Shape6.Border.BottomColor = System.Drawing.Color.Black
        Me.Shape6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape6.Border.LeftColor = System.Drawing.Color.Black
        Me.Shape6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape6.Border.RightColor = System.Drawing.Color.Black
        Me.Shape6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape6.Border.TopColor = System.Drawing.Color.Black
        Me.Shape6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape6.Height = 0.375!
        Me.Shape6.Left = 4.3125!
        Me.Shape6.Name = "Shape6"
        Me.Shape6.RoundingRadius = 9.999999!
        Me.Shape6.Top = 1.625!
        Me.Shape6.Width = 1.1875!
        '
        'Shape4
        '
        Me.Shape4.Border.BottomColor = System.Drawing.Color.Black
        Me.Shape4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape4.Border.LeftColor = System.Drawing.Color.Black
        Me.Shape4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape4.Border.RightColor = System.Drawing.Color.Black
        Me.Shape4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape4.Border.TopColor = System.Drawing.Color.Black
        Me.Shape4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape4.Height = 0.375!
        Me.Shape4.Left = 1.625!
        Me.Shape4.Name = "Shape4"
        Me.Shape4.RoundingRadius = 9.999999!
        Me.Shape4.Top = 1.625!
        Me.Shape4.Width = 1.375!
        '
        'Shape3
        '
        Me.Shape3.Border.BottomColor = System.Drawing.Color.Black
        Me.Shape3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape3.Border.LeftColor = System.Drawing.Color.Black
        Me.Shape3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape3.Border.RightColor = System.Drawing.Color.Black
        Me.Shape3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape3.Border.TopColor = System.Drawing.Color.Black
        Me.Shape3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape3.Height = 0.375!
        Me.Shape3.Left = 0.0625!
        Me.Shape3.Name = "Shape3"
        Me.Shape3.RoundingRadius = 9.999999!
        Me.Shape3.Top = 1.625!
        Me.Shape3.Width = 1.5!
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
        Me.Label7.Style = "text-align: right; font-weight: bold; background-color: White; font-size: 8.25pt;" &
    " "
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
        Me.TextBox9.DataField = "Documento"
        Me.TextBox9.Height = 0.1979167!
        Me.TextBox9.Left = 0.5!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Style = "text-align: right; font-weight: bold; font-size: 8.25pt; "
        Me.TextBox9.Text = "TextBox9"
        Me.TextBox9.Top = 1.083333!
        Me.TextBox9.Width = 1.0!
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
        Me.Label8.Left = 1.8125!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "text-align: right; font-weight: bold; background-color: White; font-size: 8.25pt;" &
    " font-family: Arial; "
        Me.Label8.Text = "Nº Pedido"
        Me.Label8.Top = 0.875!
        Me.Label8.Width = 0.625!
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
        Me.TextBox10.Height = 0.2!
        Me.TextBox10.Left = 1.78125!
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Style = "text-align: left; font-weight: bold; font-size: 8.25pt; font-family: Arial; "
        Me.TextBox10.Text = "TextBox10"
        Me.TextBox10.Top = 1.083333!
        Me.TextBox10.Width = 2.1875!
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
        Me.TextBox11.Height = 0.2!
        Me.TextBox11.Left = 4.25!
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Style = "font-weight: bold; font-size: 8.25pt; font-family: Arial; "
        Me.TextBox11.Text = "TextBox11"
        Me.TextBox11.Top = 1.083333!
        Me.TextBox11.Width = 3.875!
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
        Me.Label10.Left = 0.1875!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "text-align: right; font-weight: bold; background-color: White; font-size: 8.25pt;" &
    " "
        Me.Label10.Text = "Valor Total Produtos"
        Me.Label10.Top = 1.5625!
        Me.Label10.Width = 1.1875!
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
        Me.TextBox12.DataField = "valortotalprod"
        Me.TextBox12.Height = 0.1875!
        Me.TextBox12.Left = 0.25!
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.OutputFormat = resources.GetString("TextBox12.OutputFormat")
        Me.TextBox12.Style = "text-align: right; font-weight: bold; font-size: 8.25pt; "
        Me.TextBox12.Text = "TextBox12"
        Me.TextBox12.Top = 1.770833!
        Me.TextBox12.Width = 1.25!
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
        Me.Label11.Left = 1.75!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "text-align: right; font-weight: bold; background-color: White; font-size: 8.25pt;" &
    " "
        Me.Label11.Text = "Valor Total Nota"
        Me.Label11.Top = 1.5625!
        Me.Label11.Width = 1.0!
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
        Me.TextBox13.DataField = "valortotalnota"
        Me.TextBox13.Height = 0.1875!
        Me.TextBox13.Left = 1.875!
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.OutputFormat = resources.GetString("TextBox13.OutputFormat")
        Me.TextBox13.Style = "text-align: right; font-weight: bold; font-size: 8.25pt; "
        Me.TextBox13.Text = "TextBox13"
        Me.TextBox13.Top = 1.770833!
        Me.TextBox13.Width = 1.0625!
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
        Me.Label12.Left = 3.1875!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "text-align: right; font-weight: bold; background-color: White; font-size: 8.25pt;" &
    " "
        Me.Label12.Text = "Valor do Frete"
        Me.Label12.Top = 1.5625!
        Me.Label12.Width = 0.875!
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
        Me.TextBox14.DataField = "valorfrete"
        Me.TextBox14.Height = 0.1875!
        Me.TextBox14.Left = 3.25!
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.OutputFormat = resources.GetString("TextBox14.OutputFormat")
        Me.TextBox14.Style = "text-align: right; font-weight: bold; font-size: 8.25pt; "
        Me.TextBox14.Text = "TextBox14"
        Me.TextBox14.Top = 1.770833!
        Me.TextBox14.Width = 0.9375!
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
        Me.Label13.Text = "Detalhe da Nota Fiscal"
        Me.Label13.Top = 0.625!
        Me.Label13.Width = 1.3125!
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
        Me.Label14.Left = 4.4375!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "text-align: right; font-weight: bold; background-color: White; font-size: 8.25pt;" &
    " "
        Me.Label14.Text = "Qtde. Item(ns)"
        Me.Label14.Top = 1.5625!
        Me.Label14.Width = 0.875!
        '
        'Label15
        '
        Me.Label15.Border.BottomColor = System.Drawing.Color.Black
        Me.Label15.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label15.Border.LeftColor = System.Drawing.Color.Black
        Me.Label15.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label15.Border.RightColor = System.Drawing.Color.Black
        Me.Label15.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label15.Border.TopColor = System.Drawing.Color.Black
        Me.Label15.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label15.Height = 0.1875!
        Me.Label15.HyperLink = Nothing
        Me.Label15.Left = 5.6875!
        Me.Label15.Name = "Label15"
        Me.Label15.Style = "text-align: right; font-weight: bold; background-color: White; font-size: 8.25pt;" &
    " "
        Me.Label15.Text = "Nº Parcela(s)"
        Me.Label15.Top = 1.5625!
        Me.Label15.Width = 0.8125!
        '
        'Label16
        '
        Me.Label16.Border.BottomColor = System.Drawing.Color.Black
        Me.Label16.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label16.Border.LeftColor = System.Drawing.Color.Black
        Me.Label16.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label16.Border.RightColor = System.Drawing.Color.Black
        Me.Label16.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label16.Border.TopColor = System.Drawing.Color.Black
        Me.Label16.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label16.Height = 0.1875!
        Me.Label16.HyperLink = Nothing
        Me.Label16.Left = 6.9375!
        Me.Label16.Name = "Label16"
        Me.Label16.Style = "text-align: right; font-weight: bold; background-color: White; font-size: 8.25pt;" &
    " "
        Me.Label16.Text = "Valor Parcela(s)"
        Me.Label16.Top = 1.5625!
        Me.Label16.Width = 0.9375!
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
        Me.TextBox15.DataField = "Qtde"
        Me.TextBox15.Height = 0.1875!
        Me.TextBox15.Left = 4.5!
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.OutputFormat = resources.GetString("TextBox15.OutputFormat")
        Me.TextBox15.Style = "text-align: right; font-weight: bold; font-size: 8.25pt; "
        Me.TextBox15.Text = "TextBox15"
        Me.TextBox15.Top = 1.770833!
        Me.TextBox15.Width = 0.9375!
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
        Me.TextBox16.DataField = "numParcelas"
        Me.TextBox16.Height = 0.1875!
        Me.TextBox16.Left = 5.875!
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.OutputFormat = resources.GetString("TextBox16.OutputFormat")
        Me.TextBox16.Style = "text-align: right; font-weight: bold; font-size: 8.25pt; "
        Me.TextBox16.Text = "TextBox16"
        Me.TextBox16.Top = 1.75!
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
        Me.TextBox17.DataField = "valorParcela"
        Me.TextBox17.Height = 0.1875!
        Me.TextBox17.Left = 7.0625!
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.OutputFormat = resources.GetString("TextBox17.OutputFormat")
        Me.TextBox17.Style = "text-align: right; font-weight: bold; font-size: 8.25pt; "
        Me.TextBox17.Text = "TextBox17"
        Me.TextBox17.Top = 1.770833!
        Me.TextBox17.Width = 1.0!
        '
        'Shape2
        '
        Me.Shape2.Border.BottomColor = System.Drawing.Color.Black
        Me.Shape2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape2.Border.LeftColor = System.Drawing.Color.Black
        Me.Shape2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape2.Border.RightColor = System.Drawing.Color.Black
        Me.Shape2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape2.Border.TopColor = System.Drawing.Color.Black
        Me.Shape2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape2.Height = 0.8125!
        Me.Shape2.Left = 9.75!
        Me.Shape2.Name = "Shape2"
        Me.Shape2.RoundingRadius = 9.999999!
        Me.Shape2.Top = 0.9375!
        Me.Shape2.Width = 1.0!
        '
        'Label17
        '
        Me.Label17.Border.BottomColor = System.Drawing.Color.Black
        Me.Label17.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label17.Border.LeftColor = System.Drawing.Color.Black
        Me.Label17.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label17.Border.RightColor = System.Drawing.Color.Black
        Me.Label17.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label17.Border.TopColor = System.Drawing.Color.Black
        Me.Label17.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label17.Height = 0.1875!
        Me.Label17.HyperLink = Nothing
        Me.Label17.Left = 9.8125!
        Me.Label17.Name = "Label17"
        Me.Label17.Style = "text-align: left; font-weight: bold; background-color: White; font-size: 8.25pt; " &
    "font-family: Arial; "
        Me.Label17.Text = "Tipo Nota"
        Me.Label17.Top = 0.8125!
        Me.Label17.Width = 0.6875!
        '
        'CheckBox1
        '
        Me.CheckBox1.Border.BottomColor = System.Drawing.Color.Black
        Me.CheckBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.CheckBox1.Border.LeftColor = System.Drawing.Color.Black
        Me.CheckBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.CheckBox1.Border.RightColor = System.Drawing.Color.Black
        Me.CheckBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.CheckBox1.Border.TopColor = System.Drawing.Color.Black
        Me.CheckBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.CheckBox1.Height = 0.1875!
        Me.CheckBox1.Left = 9.8125!
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Style = "font-weight: bold; font-size: 8.25pt; font-family: Arial; "
        Me.CheckBox1.Text = "Importada"
        Me.CheckBox1.Top = 1.125!
        Me.CheckBox1.Width = 0.875!
        '
        'CheckBox2
        '
        Me.CheckBox2.Border.BottomColor = System.Drawing.Color.Black
        Me.CheckBox2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.CheckBox2.Border.LeftColor = System.Drawing.Color.Black
        Me.CheckBox2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.CheckBox2.Border.RightColor = System.Drawing.Color.Black
        Me.CheckBox2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.CheckBox2.Border.TopColor = System.Drawing.Color.Black
        Me.CheckBox2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.CheckBox2.Height = 0.1875!
        Me.CheckBox2.Left = 9.8125!
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Style = "font-weight: bold; font-size: 8.25pt; font-family: Arial; "
        Me.CheckBox2.Text = "Digitada"
        Me.CheckBox2.Top = 1.4375!
        Me.CheckBox2.Width = 0.875!
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
        Me.Line2.Top = 1.4375!
        Me.Line2.Width = 9.4375!
        Me.Line2.X1 = 0!
        Me.Line2.X2 = 9.4375!
        Me.Line2.Y1 = 1.4375!
        Me.Line2.Y2 = 1.4375!
        '
        'Label18
        '
        Me.Label18.Border.BottomColor = System.Drawing.Color.Black
        Me.Label18.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label18.Border.LeftColor = System.Drawing.Color.Black
        Me.Label18.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label18.Border.RightColor = System.Drawing.Color.Black
        Me.Label18.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label18.Border.TopColor = System.Drawing.Color.Black
        Me.Label18.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label18.Height = 0.1875!
        Me.Label18.HyperLink = Nothing
        Me.Label18.Left = 8.5!
        Me.Label18.Name = "Label18"
        Me.Label18.Style = "font-weight: bold; background-color: White; font-size: 8.25pt; font-family: Arial" &
    "; "
        Me.Label18.Text = "Data Entrada"
        Me.Label18.Top = 0.875!
        Me.Label18.Width = 0.8125!
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
        Me.TextBox18.DataField = "processado"
        Me.TextBox18.Height = 0.2!
        Me.TextBox18.Left = 8.5625!
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.OutputFormat = resources.GetString("TextBox18.OutputFormat")
        Me.TextBox18.Style = "text-align: right; font-weight: bold; font-size: 8.25pt; font-family: Arial; "
        Me.TextBox18.Text = "TextBox18"
        Me.TextBox18.Top = 1.083333!
        Me.TextBox18.Width = 0.8125!
        '
        'Label19
        '
        Me.Label19.Border.BottomColor = System.Drawing.Color.Black
        Me.Label19.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label19.Border.LeftColor = System.Drawing.Color.Black
        Me.Label19.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label19.Border.RightColor = System.Drawing.Color.Black
        Me.Label19.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label19.Border.TopColor = System.Drawing.Color.Black
        Me.Label19.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label19.Height = 0.1875!
        Me.Label19.HyperLink = Nothing
        Me.Label19.Left = 0.1875!
        Me.Label19.Name = "Label19"
        Me.Label19.Style = "text-align: right; font-weight: bold; background-color: White; font-size: 8.25pt;" &
    " "
        Me.Label19.Text = "Observação"
        Me.Label19.Top = 2.0625!
        Me.Label19.Width = 0.75!
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
        Me.TextBox4.DataField = "observacao"
        Me.TextBox4.Height = 0.4375!
        Me.TextBox4.Left = 1.0625!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.OutputFormat = resources.GetString("TextBox4.OutputFormat")
        Me.TextBox4.Style = "text-align: left; font-weight: normal; font-size: 8.25pt; "
        Me.TextBox4.Text = "TextBox19"
        Me.TextBox4.Top = 2.1875!
        Me.TextBox4.Width = 7.3125!
        '
        'Shape14
        '
        Me.Shape14.Border.BottomColor = System.Drawing.Color.Black
        Me.Shape14.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape14.Border.LeftColor = System.Drawing.Color.Black
        Me.Shape14.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape14.Border.RightColor = System.Drawing.Color.Black
        Me.Shape14.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape14.Border.TopColor = System.Drawing.Color.Black
        Me.Shape14.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape14.Height = 0.375!
        Me.Shape14.Left = 8.1875!
        Me.Shape14.Name = "Shape14"
        Me.Shape14.RoundingRadius = 9.999999!
        Me.Shape14.Top = 1.625!
        Me.Shape14.Width = 1.5!
        '
        'Label20
        '
        Me.Label20.Border.BottomColor = System.Drawing.Color.Black
        Me.Label20.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label20.Border.LeftColor = System.Drawing.Color.Black
        Me.Label20.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label20.Border.RightColor = System.Drawing.Color.Black
        Me.Label20.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label20.Border.TopColor = System.Drawing.Color.Black
        Me.Label20.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label20.Height = 0.1875!
        Me.Label20.HyperLink = Nothing
        Me.Label20.Left = 8.3125!
        Me.Label20.Name = "Label20"
        Me.Label20.Style = "text-align: left; font-weight: bold; background-color: White; font-size: 8.25pt; " &
    ""
        Me.Label20.Text = "Forma Pag."
        Me.Label20.Top = 1.5625!
        Me.Label20.Width = 0.875!
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
        Me.TextBox19.DataField = "forma_pagamento"
        Me.TextBox19.Height = 0.1875!
        Me.TextBox19.Left = 8.25!
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.OutputFormat = resources.GetString("TextBox19.OutputFormat")
        Me.TextBox19.Style = "text-align: left; font-weight: bold; font-size: 8.25pt; "
        Me.TextBox19.Text = "TextBox17"
        Me.TextBox19.Top = 1.770833!
        Me.TextBox19.Width = 1.375!
        '
        'Label21
        '
        Me.Label21.Border.BottomColor = System.Drawing.Color.Black
        Me.Label21.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label21.Border.LeftColor = System.Drawing.Color.Black
        Me.Label21.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label21.Border.RightColor = System.Drawing.Color.Black
        Me.Label21.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label21.Border.TopColor = System.Drawing.Color.Black
        Me.Label21.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label21.Height = 0.25!
        Me.Label21.HyperLink = Nothing
        Me.Label21.Left = 1.9375!
        Me.Label21.Name = "Label21"
        Me.Label21.Style = "text-align: center; font-weight: bold; font-size: 9.75pt; "
        Me.Label21.Text = "Label21"
        Me.Label21.Top = 0.125!
        Me.Label21.Width = 7.3125!
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
        Me.Picture.Width = 1.8125!
        '
        'Label22
        '
        Me.Label22.Border.BottomColor = System.Drawing.Color.Black
        Me.Label22.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label22.Border.LeftColor = System.Drawing.Color.Black
        Me.Label22.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label22.Border.RightColor = System.Drawing.Color.Black
        Me.Label22.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label22.Border.TopColor = System.Drawing.Color.Black
        Me.Label22.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label22.DataField = "tiponota"
        Me.Label22.Height = 0.1979167!
        Me.Label22.HyperLink = Nothing
        Me.Label22.Left = 9.75!
        Me.Label22.Name = "Label22"
        Me.Label22.Style = ""
        Me.Label22.Text = "Label22"
        Me.Label22.Top = 2.4375!
        Me.Label22.Visible = False
        Me.Label22.Width = 1.0!
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
        Me.Label.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; "
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
        Me.Label1.Left = 7.3125!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; "
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
        Me.Label2.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 8.25pt; "
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
        Me.Label4.Left = 8.3125!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; "
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
        Me.Label5.Left = 9.4375!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; "
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
        Me.lblPag.Left = 9.375!
        Me.lblPag.Name = "lblPag"
        Me.lblPag.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; font-fa" &
    "mily: Arial; "
        Me.lblPag.Text = "Produto"
        Me.lblPag.Top = 0.07291666!
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
        Me.Label6.Top = 0.09375!
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
        Me.TextBox3.Left = 7.3125!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "text-align: right; font-weight: bold; font-size: 8.25pt; font-family: Arial; "
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
        Me.Line1.Width = 10.8125!
        Me.Line1.X1 = 0!
        Me.Line1.X2 = 10.8125!
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
        Me.Label3.Left = 4.375!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; font-fa" &
    "mily: Arial; "
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
        Me.TextBox6.Left = 8.3125!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.OutputFormat = resources.GetString("TextBox6.OutputFormat")
        Me.TextBox6.Style = "text-align: right; font-weight: bold; font-size: 8.25pt; font-family: Arial; "
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
        Me.TextBox8.Left = 9.4375!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.OutputFormat = resources.GetString("TextBox8.OutputFormat")
        Me.TextBox8.Style = "text-align: right; font-weight: bold; font-size: 8.25pt; font-family: Arial; "
        Me.TextBox8.SummaryGroup = "GroupHeader1"
        Me.TextBox8.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox8.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.TextBox8.Text = "TextBox1"
        Me.TextBox8.Top = 0!
        Me.TextBox8.Width = 0.94!
        '
        'rptEspelhoNota
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.69!
        Me.PageSettings.PaperWidth = 8.27!
        Me.PrintWidth = 10.875!
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
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).EndInit()
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

        If Label6.Text = "Label6" Then
            Label6.Text = "Nota fiscal faturada em " & TextBox16.Text & "x."
        End If
    End Sub

    Private Sub Detail_Format(sender As System.Object, e As System.EventArgs) Handles Detail.Format
        If Label21.Text = "Reembolso de produtos" Then
            TextBox5.Text = ""
            TextBox7.Text = ""
            TextBox6.Text = ""
            TextBox8.Text = ""
        End If
    End Sub


    Private Sub GroupFooter1_Format(sender As System.Object, e As System.EventArgs) Handles GroupFooter1.Format
        If Label21.Text = "Reembolso de produtos" Then
            TextBox6.Text = ""
            TextBox8.Text = ""
        End If
    End Sub

    Private Sub ReportHeader_Format(sender As System.Object, e As System.EventArgs) Handles ReportHeader.Format
        If Label22.Text = "I" Then
            CheckBox1.Checked = True
        ElseIf Label22.Text = "D" Then
            CheckBox2.Checked = True
        End If
    End Sub
End Class
