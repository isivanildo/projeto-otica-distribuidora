Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class rptGiro
Inherits DataDynamics.ActiveReports.ActiveReport3
	Public Sub New()
	MyBase.New()
		InitializeComponent()
    End Sub
    Public titulo As String
	#Region "ActiveReports Designer generated code"
    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader = Nothing
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
	Private lblTitulo As DataDynamics.ActiveReports.Label
	Private TextBox As DataDynamics.ActiveReports.TextBox
	Private TextBox1 As DataDynamics.ActiveReports.TextBox
	Private TextBox2 As DataDynamics.ActiveReports.TextBox
	Private TextBox3 As DataDynamics.ActiveReports.TextBox
	Private TextBox4 As DataDynamics.ActiveReports.TextBox
	Private Label1 As DataDynamics.ActiveReports.Label
	Private Label2 As DataDynamics.ActiveReports.Label
	Private Label3 As DataDynamics.ActiveReports.Label
	Private Label4 As DataDynamics.ActiveReports.Label
	Private TextBox5 As DataDynamics.ActiveReports.TextBox
	Private TextBox6 As DataDynamics.ActiveReports.TextBox
	Private TextBox7 As DataDynamics.ActiveReports.TextBox
	Private Label5 As DataDynamics.ActiveReports.Label
	Private Label6 As DataDynamics.ActiveReports.Label
	Private Label7 As DataDynamics.ActiveReports.Label
	Private Label8 As DataDynamics.ActiveReports.Label
	Private TextBox8 As DataDynamics.ActiveReports.TextBox
	Private TextBox9 As DataDynamics.ActiveReports.TextBox
	Private TextBox10 As DataDynamics.ActiveReports.TextBox
	Private Label9 As DataDynamics.ActiveReports.Label
	Private Label10 As DataDynamics.ActiveReports.Label
	Private Label11 As DataDynamics.ActiveReports.Label
	Private Label12 As DataDynamics.ActiveReports.Label
	Private TextBox11 As DataDynamics.ActiveReports.TextBox
	Private TextBox12 As DataDynamics.ActiveReports.TextBox
	Private TextBox13 As DataDynamics.ActiveReports.TextBox
	Private Label13 As DataDynamics.ActiveReports.Label
	Private Label14 As DataDynamics.ActiveReports.Label
	Private Label15 As DataDynamics.ActiveReports.Label
	Private Label16 As DataDynamics.ActiveReports.Label
	Private Line As DataDynamics.ActiveReports.Line
	Private Line1 As DataDynamics.ActiveReports.Line
	Private Line2 As DataDynamics.ActiveReports.Line
	Private Line3 As DataDynamics.ActiveReports.Line
	Private Line4 As DataDynamics.ActiveReports.Line
	Private Line5 As DataDynamics.ActiveReports.Line
	Private Line7 As DataDynamics.ActiveReports.Line
	Private Line8 As DataDynamics.ActiveReports.Line
	Private Line9 As DataDynamics.ActiveReports.Line
	Private Line11 As DataDynamics.ActiveReports.Line
	Private Line12 As DataDynamics.ActiveReports.Line
	Private Line13 As DataDynamics.ActiveReports.Line
	Private Line15 As DataDynamics.ActiveReports.Line
	Private Line16 As DataDynamics.ActiveReports.Line
	Private Line17 As DataDynamics.ActiveReports.Line
	Private Label17 As DataDynamics.ActiveReports.Label
	Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptGiro))
            Me.Detail = New DataDynamics.ActiveReports.Detail
            Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
            Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
            Me.lblTitulo = New DataDynamics.ActiveReports.Label
            Me.TextBox = New DataDynamics.ActiveReports.TextBox
            Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
            Me.TextBox2 = New DataDynamics.ActiveReports.TextBox
            Me.TextBox3 = New DataDynamics.ActiveReports.TextBox
            Me.TextBox4 = New DataDynamics.ActiveReports.TextBox
            Me.Label1 = New DataDynamics.ActiveReports.Label
            Me.Label2 = New DataDynamics.ActiveReports.Label
            Me.Label3 = New DataDynamics.ActiveReports.Label
            Me.Label4 = New DataDynamics.ActiveReports.Label
            Me.TextBox5 = New DataDynamics.ActiveReports.TextBox
            Me.TextBox6 = New DataDynamics.ActiveReports.TextBox
            Me.TextBox7 = New DataDynamics.ActiveReports.TextBox
            Me.Label5 = New DataDynamics.ActiveReports.Label
            Me.Label6 = New DataDynamics.ActiveReports.Label
            Me.Label7 = New DataDynamics.ActiveReports.Label
            Me.Label8 = New DataDynamics.ActiveReports.Label
            Me.TextBox8 = New DataDynamics.ActiveReports.TextBox
            Me.TextBox9 = New DataDynamics.ActiveReports.TextBox
            Me.TextBox10 = New DataDynamics.ActiveReports.TextBox
            Me.Label9 = New DataDynamics.ActiveReports.Label
            Me.Label10 = New DataDynamics.ActiveReports.Label
            Me.Label11 = New DataDynamics.ActiveReports.Label
            Me.Label12 = New DataDynamics.ActiveReports.Label
            Me.TextBox11 = New DataDynamics.ActiveReports.TextBox
            Me.TextBox12 = New DataDynamics.ActiveReports.TextBox
            Me.TextBox13 = New DataDynamics.ActiveReports.TextBox
            Me.Label13 = New DataDynamics.ActiveReports.Label
            Me.Label14 = New DataDynamics.ActiveReports.Label
            Me.Label15 = New DataDynamics.ActiveReports.Label
            Me.Label16 = New DataDynamics.ActiveReports.Label
            Me.Line = New DataDynamics.ActiveReports.Line
            Me.Line1 = New DataDynamics.ActiveReports.Line
            Me.Line2 = New DataDynamics.ActiveReports.Line
            Me.Line3 = New DataDynamics.ActiveReports.Line
            Me.Line4 = New DataDynamics.ActiveReports.Line
            Me.Line5 = New DataDynamics.ActiveReports.Line
            Me.Line7 = New DataDynamics.ActiveReports.Line
            Me.Line8 = New DataDynamics.ActiveReports.Line
            Me.Line9 = New DataDynamics.ActiveReports.Line
            Me.Line11 = New DataDynamics.ActiveReports.Line
            Me.Line12 = New DataDynamics.ActiveReports.Line
            Me.Line13 = New DataDynamics.ActiveReports.Line
            Me.Line15 = New DataDynamics.ActiveReports.Line
            Me.Line16 = New DataDynamics.ActiveReports.Line
            Me.Line17 = New DataDynamics.ActiveReports.Line
            Me.Label17 = New DataDynamics.ActiveReports.Label
            CType(Me.lblTitulo,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox1,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox2,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox3,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox4,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label1,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label2,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label3,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label4,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox5,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox6,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox7,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label5,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label6,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label7,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label8,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox8,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox9,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox10,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label9,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label10,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label11,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label12,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox11,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox12,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox13,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label13,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label14,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label15,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label16,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label17,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
            '
            'Detail
            '
            Me.Detail.ColumnSpacing = 0!
            Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox, Me.TextBox1, Me.TextBox2, Me.TextBox3, Me.TextBox4, Me.Label1, Me.Label2, Me.Label3, Me.Label4, Me.TextBox5, Me.TextBox6, Me.TextBox7, Me.Label5, Me.Label6, Me.Label7, Me.Label8, Me.TextBox8, Me.TextBox9, Me.TextBox10, Me.Label9, Me.Label10, Me.Label11, Me.Label12, Me.TextBox11, Me.TextBox12, Me.TextBox13, Me.Label13, Me.Label14, Me.Label15, Me.Label16, Me.Line, Me.Line1, Me.Line2, Me.Line3, Me.Line4, Me.Line5, Me.Line7, Me.Line8, Me.Line9, Me.Line11, Me.Line12, Me.Line13, Me.Line15, Me.Line16, Me.Line17, Me.Label17})
            Me.Detail.Height = 0.8027778!
            Me.Detail.Name = "Detail"
            '
            'PageHeader
            '
            Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblTitulo})
            Me.PageHeader.Height = 0.5104167!
            Me.PageHeader.Name = "PageHeader"
            '
            'PageFooter
            '
            Me.PageFooter.Height = 0.25!
            Me.PageFooter.Name = "PageFooter"
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
            Me.lblTitulo.Left = 0!
            Me.lblTitulo.Name = "lblTitulo"
            Me.lblTitulo.Style = ""
            Me.lblTitulo.Text = "Label"
            Me.lblTitulo.Top = 0!
            Me.lblTitulo.Width = 6.6875!
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
            Me.TextBox.Left = 0!
            Me.TextBox.Name = "TextBox"
            Me.TextBox.Style = ""
            Me.TextBox.Text = "TextBox"
            Me.TextBox.Top = 0!
            Me.TextBox.Width = 5.5625!
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
            Me.TextBox1.DataField = "saldo"
            Me.TextBox1.Height = 0.2!
            Me.TextBox1.Left = 6.0625!
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Style = ""
            Me.TextBox1.Text = "TextBox1"
            Me.TextBox1.Top = 0!
            Me.TextBox1.Width = 0.375!
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
            Me.TextBox2.DataField = "Entradas_periodo"
            Me.TextBox2.Height = 0.2!
            Me.TextBox2.Left = 0!
            Me.TextBox2.Name = "TextBox2"
            Me.TextBox2.Style = ""
            Me.TextBox2.Text = "TextBox1"
            Me.TextBox2.Top = 0.5625!
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
            Me.TextBox3.DataField = "saidas_periodo"
            Me.TextBox3.Height = 0.2!
            Me.TextBox3.Left = 0.4375!
            Me.TextBox3.Name = "TextBox3"
            Me.TextBox3.Style = ""
            Me.TextBox3.Text = "TextBox1"
            Me.TextBox3.Top = 0.5625!
            Me.TextBox3.Width = 0.375!
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
            Me.TextBox4.DataField = "giro_periodo"
            Me.TextBox4.Height = 0.2!
            Me.TextBox4.Left = 0.875!
            Me.TextBox4.Name = "TextBox4"
            Me.TextBox4.OutputFormat = resources.GetString("TextBox4.OutputFormat")
            Me.TextBox4.Style = ""
            Me.TextBox4.Text = "TextBox1"
            Me.TextBox4.Top = 0.5625!
            Me.TextBox4.Width = 0.375!
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
            Me.Label1.Left = 0!
            Me.Label1.Name = "Label1"
            Me.Label1.Style = "text-align: center; "
            Me.Label1.Text = "Período"
            Me.Label1.Top = 0.1875!
            Me.Label1.Width = 1.1875!
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
            Me.Label2.Left = 0!
            Me.Label2.Name = "Label2"
            Me.Label2.Style = "text-align: center; "
            Me.Label2.Text = "Ent."
            Me.Label2.Top = 0.375!
            Me.Label2.Width = 0.3125!
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
            Me.Label3.Left = 0.4375!
            Me.Label3.Name = "Label3"
            Me.Label3.Style = "text-align: center; "
            Me.Label3.Text = "Sai."
            Me.Label3.Top = 0.375!
            Me.Label3.Width = 0.3125!
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
            Me.Label4.Left = 0.875!
            Me.Label4.Name = "Label4"
            Me.Label4.Style = "text-align: center; "
            Me.Label4.Text = "Giro"
            Me.Label4.Top = 0.375!
            Me.Label4.Width = 0.3125!
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
            Me.TextBox5.DataField = "Entradas_30"
            Me.TextBox5.Height = 0.2!
            Me.TextBox5.Left = 1.4375!
            Me.TextBox5.Name = "TextBox5"
            Me.TextBox5.Style = ""
            Me.TextBox5.Text = "TextBox1"
            Me.TextBox5.Top = 0.5625!
            Me.TextBox5.Width = 0.375!
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
            Me.TextBox6.DataField = "saidas_30"
            Me.TextBox6.Height = 0.2!
            Me.TextBox6.Left = 1.875!
            Me.TextBox6.Name = "TextBox6"
            Me.TextBox6.Style = ""
            Me.TextBox6.Text = "TextBox1"
            Me.TextBox6.Top = 0.5625!
            Me.TextBox6.Width = 0.375!
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
            Me.TextBox7.DataField = "giro_30"
            Me.TextBox7.Height = 0.2!
            Me.TextBox7.Left = 2.3125!
            Me.TextBox7.Name = "TextBox7"
            Me.TextBox7.OutputFormat = resources.GetString("TextBox7.OutputFormat")
            Me.TextBox7.Style = ""
            Me.TextBox7.Text = "TextBox1"
            Me.TextBox7.Top = 0.5625!
            Me.TextBox7.Width = 0.375!
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
            Me.Label5.Left = 1.4375!
            Me.Label5.Name = "Label5"
            Me.Label5.Style = "text-align: center; "
            Me.Label5.Text = "30 Dias"
            Me.Label5.Top = 0.1875!
            Me.Label5.Width = 1.1875!
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
            Me.Label6.Left = 1.4375!
            Me.Label6.Name = "Label6"
            Me.Label6.Style = "text-align: center; "
            Me.Label6.Text = "Ent."
            Me.Label6.Top = 0.375!
            Me.Label6.Width = 0.3125!
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
            Me.Label7.Left = 1.875!
            Me.Label7.Name = "Label7"
            Me.Label7.Style = "text-align: center; "
            Me.Label7.Text = "Sai."
            Me.Label7.Top = 0.375!
            Me.Label7.Width = 0.3125!
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
            Me.Label8.Left = 2.3125!
            Me.Label8.Name = "Label8"
            Me.Label8.Style = "text-align: center; "
            Me.Label8.Text = "Giro"
            Me.Label8.Top = 0.375!
            Me.Label8.Width = 0.3125!
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
            Me.TextBox8.DataField = "Entradas_60"
            Me.TextBox8.Height = 0.2!
            Me.TextBox8.Left = 2.875!
            Me.TextBox8.Name = "TextBox8"
            Me.TextBox8.Style = ""
            Me.TextBox8.Text = "TextBox1"
            Me.TextBox8.Top = 0.5625!
            Me.TextBox8.Width = 0.375!
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
            Me.TextBox9.DataField = "saidas_60"
            Me.TextBox9.Height = 0.2!
            Me.TextBox9.Left = 3.3125!
            Me.TextBox9.Name = "TextBox9"
            Me.TextBox9.Style = ""
            Me.TextBox9.Text = "TextBox1"
            Me.TextBox9.Top = 0.5625!
            Me.TextBox9.Width = 0.375!
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
            Me.TextBox10.DataField = "giro_60"
            Me.TextBox10.Height = 0.2!
            Me.TextBox10.Left = 3.75!
            Me.TextBox10.Name = "TextBox10"
            Me.TextBox10.OutputFormat = resources.GetString("TextBox10.OutputFormat")
            Me.TextBox10.Style = ""
            Me.TextBox10.Text = "TextBox1"
            Me.TextBox10.Top = 0.5625!
            Me.TextBox10.Width = 0.375!
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
            Me.Label9.Left = 2.875!
            Me.Label9.Name = "Label9"
            Me.Label9.Style = "text-align: center; "
            Me.Label9.Text = "60 Dias"
            Me.Label9.Top = 0.1875!
            Me.Label9.Width = 1.1875!
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
            Me.Label10.Left = 2.875!
            Me.Label10.Name = "Label10"
            Me.Label10.Style = "text-align: center; "
            Me.Label10.Text = "Ent."
            Me.Label10.Top = 0.375!
            Me.Label10.Width = 0.3125!
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
            Me.Label11.Left = 3.3125!
            Me.Label11.Name = "Label11"
            Me.Label11.Style = "text-align: center; "
            Me.Label11.Text = "Sai."
            Me.Label11.Top = 0.375!
            Me.Label11.Width = 0.3125!
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
            Me.Label12.Left = 3.75!
            Me.Label12.Name = "Label12"
            Me.Label12.Style = "text-align: center; "
            Me.Label12.Text = "Giro"
            Me.Label12.Top = 0.375!
            Me.Label12.Width = 0.3125!
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
            Me.TextBox11.DataField = "Entradas_90"
            Me.TextBox11.Height = 0.2!
            Me.TextBox11.Left = 4.3125!
            Me.TextBox11.Name = "TextBox11"
            Me.TextBox11.Style = ""
            Me.TextBox11.Text = "TextBox1"
            Me.TextBox11.Top = 0.5625!
            Me.TextBox11.Width = 0.375!
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
            Me.TextBox12.DataField = "saidas_90"
            Me.TextBox12.Height = 0.2!
            Me.TextBox12.Left = 4.75!
            Me.TextBox12.Name = "TextBox12"
            Me.TextBox12.Style = ""
            Me.TextBox12.Text = "TextBox1"
            Me.TextBox12.Top = 0.5625!
            Me.TextBox12.Width = 0.375!
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
            Me.TextBox13.DataField = "giro_90"
            Me.TextBox13.Height = 0.2!
            Me.TextBox13.Left = 5.1875!
            Me.TextBox13.Name = "TextBox13"
            Me.TextBox13.OutputFormat = resources.GetString("TextBox13.OutputFormat")
            Me.TextBox13.Style = ""
            Me.TextBox13.Text = "TextBox1"
            Me.TextBox13.Top = 0.5625!
            Me.TextBox13.Width = 0.375!
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
            Me.Label13.Left = 4.3125!
            Me.Label13.Name = "Label13"
            Me.Label13.Style = "text-align: center; "
            Me.Label13.Text = "90 Dias"
            Me.Label13.Top = 0.1875!
            Me.Label13.Width = 1.1875!
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
            Me.Label14.Left = 4.3125!
            Me.Label14.Name = "Label14"
            Me.Label14.Style = "text-align: center; "
            Me.Label14.Text = "Ent."
            Me.Label14.Top = 0.375!
            Me.Label14.Width = 0.3125!
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
            Me.Label15.Left = 4.75!
            Me.Label15.Name = "Label15"
            Me.Label15.Style = "text-align: center; "
            Me.Label15.Text = "Sai."
            Me.Label15.Top = 0.375!
            Me.Label15.Width = 0.3125!
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
            Me.Label16.Left = 5.1875!
            Me.Label16.Name = "Label16"
            Me.Label16.Style = "text-align: center; "
            Me.Label16.Text = "Giro"
            Me.Label16.Top = 0.375!
            Me.Label16.Width = 0.3125!
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
            Me.Line.LineWeight = 1!
            Me.Line.Name = "Line"
            Me.Line.Top = 0.75!
            Me.Line.Width = 7.125!
            Me.Line.X1 = 0!
            Me.Line.X2 = 7.125!
            Me.Line.Y1 = 0.75!
            Me.Line.Y2 = 0.75!
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
            Me.Line1.LineStyle = DataDynamics.ActiveReports.LineStyle.DashDot
            Me.Line1.LineWeight = 1!
            Me.Line1.Name = "Line1"
            Me.Line1.Top = 0.1875!
            Me.Line1.Width = 7.125!
            Me.Line1.X1 = 0!
            Me.Line1.X2 = 7.125!
            Me.Line1.Y1 = 0.1875!
            Me.Line1.Y2 = 0.1875!
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
            Me.Line2.LineStyle = DataDynamics.ActiveReports.LineStyle.DashDot
            Me.Line2.LineWeight = 1!
            Me.Line2.Name = "Line2"
            Me.Line2.Top = 0.375!
            Me.Line2.Width = 5.5625!
            Me.Line2.X1 = 0!
            Me.Line2.X2 = 5.5625!
            Me.Line2.Y1 = 0.375!
            Me.Line2.Y2 = 0.375!
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
            Me.Line3.Left = 0.375!
            Me.Line3.LineStyle = DataDynamics.ActiveReports.LineStyle.DashDot
            Me.Line3.LineWeight = 1!
            Me.Line3.Name = "Line3"
            Me.Line3.Top = 0.375!
            Me.Line3.Width = 0!
            Me.Line3.X1 = 0.375!
            Me.Line3.X2 = 0.375!
            Me.Line3.Y1 = 0.375!
            Me.Line3.Y2 = 0.75!
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
            Me.Line4.Left = 0.8125!
            Me.Line4.LineStyle = DataDynamics.ActiveReports.LineStyle.DashDot
            Me.Line4.LineWeight = 1!
            Me.Line4.Name = "Line4"
            Me.Line4.Top = 0.375!
            Me.Line4.Width = 0!
            Me.Line4.X1 = 0.8125!
            Me.Line4.X2 = 0.8125!
            Me.Line4.Y1 = 0.375!
            Me.Line4.Y2 = 0.75!
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
            Me.Line5.Height = 0.5625!
            Me.Line5.Left = 1.25!
            Me.Line5.LineStyle = DataDynamics.ActiveReports.LineStyle.DashDot
            Me.Line5.LineWeight = 1!
            Me.Line5.Name = "Line5"
            Me.Line5.Top = 0.1875!
            Me.Line5.Width = 0!
            Me.Line5.X1 = 1.25!
            Me.Line5.X2 = 1.25!
            Me.Line5.Y1 = 0.1875!
            Me.Line5.Y2 = 0.75!
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
            Me.Line7.Height = 0.375!
            Me.Line7.Left = 1.8125!
            Me.Line7.LineStyle = DataDynamics.ActiveReports.LineStyle.DashDot
            Me.Line7.LineWeight = 1!
            Me.Line7.Name = "Line7"
            Me.Line7.Top = 0.375!
            Me.Line7.Width = 0!
            Me.Line7.X1 = 1.8125!
            Me.Line7.X2 = 1.8125!
            Me.Line7.Y1 = 0.375!
            Me.Line7.Y2 = 0.75!
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
            Me.Line8.Left = 2.25!
            Me.Line8.LineStyle = DataDynamics.ActiveReports.LineStyle.DashDot
            Me.Line8.LineWeight = 1!
            Me.Line8.Name = "Line8"
            Me.Line8.Top = 0.375!
            Me.Line8.Width = 0!
            Me.Line8.X1 = 2.25!
            Me.Line8.X2 = 2.25!
            Me.Line8.Y1 = 0.375!
            Me.Line8.Y2 = 0.75!
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
            Me.Line9.Height = 0.5625!
            Me.Line9.Left = 2.6875!
            Me.Line9.LineStyle = DataDynamics.ActiveReports.LineStyle.DashDot
            Me.Line9.LineWeight = 1!
            Me.Line9.Name = "Line9"
            Me.Line9.Top = 0.1875!
            Me.Line9.Width = 0!
            Me.Line9.X1 = 2.6875!
            Me.Line9.X2 = 2.6875!
            Me.Line9.Y1 = 0.1875!
            Me.Line9.Y2 = 0.75!
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
            Me.Line11.Height = 0.375!
            Me.Line11.Left = 3.25!
            Me.Line11.LineStyle = DataDynamics.ActiveReports.LineStyle.DashDot
            Me.Line11.LineWeight = 1!
            Me.Line11.Name = "Line11"
            Me.Line11.Top = 0.375!
            Me.Line11.Width = 0!
            Me.Line11.X1 = 3.25!
            Me.Line11.X2 = 3.25!
            Me.Line11.Y1 = 0.375!
            Me.Line11.Y2 = 0.75!
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
            Me.Line12.Height = 0.375!
            Me.Line12.Left = 3.6875!
            Me.Line12.LineStyle = DataDynamics.ActiveReports.LineStyle.DashDot
            Me.Line12.LineWeight = 1!
            Me.Line12.Name = "Line12"
            Me.Line12.Top = 0.375!
            Me.Line12.Width = 0!
            Me.Line12.X1 = 3.6875!
            Me.Line12.X2 = 3.6875!
            Me.Line12.Y1 = 0.375!
            Me.Line12.Y2 = 0.75!
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
            Me.Line13.Height = 0.5625!
            Me.Line13.Left = 4.125!
            Me.Line13.LineStyle = DataDynamics.ActiveReports.LineStyle.DashDot
            Me.Line13.LineWeight = 1!
            Me.Line13.Name = "Line13"
            Me.Line13.Top = 0.1875!
            Me.Line13.Width = 0!
            Me.Line13.X1 = 4.125!
            Me.Line13.X2 = 4.125!
            Me.Line13.Y1 = 0.1875!
            Me.Line13.Y2 = 0.75!
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
            Me.Line15.Height = 0.375!
            Me.Line15.Left = 4.6875!
            Me.Line15.LineStyle = DataDynamics.ActiveReports.LineStyle.DashDot
            Me.Line15.LineWeight = 1!
            Me.Line15.Name = "Line15"
            Me.Line15.Top = 0.375!
            Me.Line15.Width = 0!
            Me.Line15.X1 = 4.6875!
            Me.Line15.X2 = 4.6875!
            Me.Line15.Y1 = 0.375!
            Me.Line15.Y2 = 0.75!
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
            Me.Line16.Height = 0.375!
            Me.Line16.Left = 5.125!
            Me.Line16.LineStyle = DataDynamics.ActiveReports.LineStyle.DashDot
            Me.Line16.LineWeight = 1!
            Me.Line16.Name = "Line16"
            Me.Line16.Top = 0.375!
            Me.Line16.Width = 0!
            Me.Line16.X1 = 5.125!
            Me.Line16.X2 = 5.125!
            Me.Line16.Y1 = 0.375!
            Me.Line16.Y2 = 0.75!
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
            Me.Line17.Height = 0.5625!
            Me.Line17.Left = 5.5625!
            Me.Line17.LineStyle = DataDynamics.ActiveReports.LineStyle.DashDot
            Me.Line17.LineWeight = 1!
            Me.Line17.Name = "Line17"
            Me.Line17.Top = 0.1875!
            Me.Line17.Width = 0!
            Me.Line17.X1 = 5.5625!
            Me.Line17.X2 = 5.5625!
            Me.Line17.Y1 = 0.1875!
            Me.Line17.Y2 = 0.75!
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
            Me.Label17.Height = 0.2!
            Me.Label17.HyperLink = Nothing
            Me.Label17.Left = 5.625!
            Me.Label17.Name = "Label17"
            Me.Label17.Style = ""
            Me.Label17.Text = "Saldo:"
            Me.Label17.Top = 0!
            Me.Label17.Width = 0.4375!
            '
            'ActiveReport31
            '
            Me.MasterReport = false
            Me.PageSettings.PaperHeight = 11.69!
            Me.PageSettings.PaperWidth = 8.27!
            Me.PrintWidth = 7.135417!
            Me.Sections.Add(Me.PageHeader)
            Me.Sections.Add(Me.Detail)
            Me.Sections.Add(Me.PageFooter)
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
            CType(Me.TextBox2,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox3,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox4,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label1,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label2,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label3,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label4,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox5,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox6,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox7,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label5,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label6,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label7,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label8,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox8,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox9,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox10,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label9,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label10,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label11,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label12,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox11,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox12,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox13,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label13,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label14,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label15,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label16,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label17,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me,System.ComponentModel.ISupportInitialize).EndInit
        
	End Sub

	#End Region

    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        lblTitulo.Text = titulo
    End Sub
End Class
