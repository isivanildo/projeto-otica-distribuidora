Imports mrotica_util
Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports MRUtil

Public Class rptFatura
Inherits DataDynamics.ActiveReports.ActiveReport3
	Public Sub New()
	MyBase.New()
		InitializeComponent()
    End Sub
    Public tRec As New DataTable
    Dim r As New rptFaturaRec
    Public cliente As String
    Public fatura As String
    Public acrescimo As String
    Public desconto As String
    Public aPagar As String
    Dim conf As New Arquivo
    Dim emitente As New Empresa(conf.Filial)
#Region "ActiveReports Designer generated code"
    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader = Nothing
    Private WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader = Nothing
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
    Private WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter = Nothing
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
	Private txtCliente As DataDynamics.ActiveReports.TextBox
	Private txtFatura As DataDynamics.ActiveReports.TextBox
	Private Picture As DataDynamics.ActiveReports.Picture
    Private lblRazao As DataDynamics.ActiveReports.Label
    Private lblEndereco As DataDynamics.ActiveReports.Label
    Private lblTelefone As DataDynamics.ActiveReports.Label
    Private lblCepMail As DataDynamics.ActiveReports.Label
    Private Line2 As DataDynamics.ActiveReports.Line
    Private TextBox8 As DataDynamics.ActiveReports.TextBox
    Private TextBox9 As DataDynamics.ActiveReports.TextBox
    Private TextBox10 As DataDynamics.ActiveReports.TextBox
    Private TextBox11 As DataDynamics.ActiveReports.TextBox
    Private TextBox12 As DataDynamics.ActiveReports.TextBox
    Private TextBox15 As DataDynamics.ActiveReports.TextBox
    Private TextBox As DataDynamics.ActiveReports.TextBox
    Private TextBox1 As DataDynamics.ActiveReports.TextBox
    Private TextBox2 As DataDynamics.ActiveReports.TextBox
    Private TextBox3 As DataDynamics.ActiveReports.TextBox
    Private TextBox4 As DataDynamics.ActiveReports.TextBox
    Private Line As DataDynamics.ActiveReports.Line
    Private TextBox14 As DataDynamics.ActiveReports.TextBox
    Private TextBox13 As DataDynamics.ActiveReports.TextBox
    Private TextBox5 As DataDynamics.ActiveReports.TextBox
    Private TextBox6 As DataDynamics.ActiveReports.TextBox
    Private TextBox7 As DataDynamics.ActiveReports.TextBox
    Private sbRp As DataDynamics.ActiveReports.SubReport
    Private Line1 As DataDynamics.ActiveReports.Line
    Private txtAcrescimo As DataDynamics.ActiveReports.TextBox
    Private Label4 As DataDynamics.ActiveReports.Label
    Private Label5 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox17 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox16 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox19 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox18 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox20 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox21 As DataDynamics.ActiveReports.TextBox
    Private txtDesconto As DataDynamics.ActiveReports.TextBox
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptFatura))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.TextBox = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox()
        Me.Line = New DataDynamics.ActiveReports.Line()
        Me.TextBox14 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox17 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox19 = New DataDynamics.ActiveReports.TextBox()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.txtCliente = New DataDynamics.ActiveReports.TextBox()
        Me.txtFatura = New DataDynamics.ActiveReports.TextBox()
        Me.Picture = New DataDynamics.ActiveReports.Picture()
        Me.lblRazao = New DataDynamics.ActiveReports.Label()
        Me.lblEndereco = New DataDynamics.ActiveReports.Label()
        Me.lblTelefone = New DataDynamics.ActiveReports.Label()
        Me.lblCepMail = New DataDynamics.ActiveReports.Label()
        Me.Line2 = New DataDynamics.ActiveReports.Line()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader()
        Me.TextBox8 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox9 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox10 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox11 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox12 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox15 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox16 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox18 = New DataDynamics.ActiveReports.TextBox()
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter()
        Me.TextBox13 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox6 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox7 = New DataDynamics.ActiveReports.TextBox()
        Me.sbRp = New DataDynamics.ActiveReports.SubReport()
        Me.Line1 = New DataDynamics.ActiveReports.Line()
        Me.txtAcrescimo = New DataDynamics.ActiveReports.TextBox()
        Me.Label4 = New DataDynamics.ActiveReports.Label()
        Me.Label5 = New DataDynamics.ActiveReports.Label()
        Me.txtDesconto = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox20 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox21 = New DataDynamics.ActiveReports.TextBox()
        CType(Me.TextBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFatura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblRazao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblEndereco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTelefone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCepMail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAcrescimo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDesconto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox, Me.TextBox1, Me.TextBox2, Me.TextBox3, Me.TextBox4, Me.Line, Me.TextBox14, Me.TextBox17, Me.TextBox19})
        Me.Detail.Height = 0.2618056!
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
        Me.TextBox.DataField = "item"
        Me.TextBox.Height = 0.2!
        Me.TextBox.Left = 0.0625!
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Style = "text-align: right; "
        Me.TextBox.Text = "TextBox"
        Me.TextBox.Top = 0!
        Me.TextBox.Width = 0.375!
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
        Me.TextBox1.DataField = "num_pedido"
        Me.TextBox1.Height = 0.2!
        Me.TextBox1.Left = 0.5!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "text-align: right; "
        Me.TextBox1.Text = "TextBox"
        Me.TextBox1.Top = 0!
        Me.TextBox1.Width = 0.5625!
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
        Me.TextBox2.DataField = "produtos"
        Me.TextBox2.Height = 0.2!
        Me.TextBox2.Left = 2.125!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.OutputFormat = resources.GetString("TextBox2.OutputFormat")
        Me.TextBox2.Style = "text-align: right; "
        Me.TextBox2.Text = "TextBox"
        Me.TextBox2.Top = 0!
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
        Me.TextBox3.DataField = "servicos"
        Me.TextBox3.Height = 0.2!
        Me.TextBox3.Left = 2.875!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.OutputFormat = resources.GetString("TextBox3.OutputFormat")
        Me.TextBox3.Style = "text-align: right; "
        Me.TextBox3.Text = "TextBox"
        Me.TextBox3.Top = 0!
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
        Me.TextBox4.DataField = "Total"
        Me.TextBox4.Height = 0.2!
        Me.TextBox4.Left = 3.6875!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.OutputFormat = resources.GetString("TextBox4.OutputFormat")
        Me.TextBox4.Style = "text-align: right; "
        Me.TextBox4.Text = "TextBox"
        Me.TextBox4.Top = 0!
        Me.TextBox4.Width = 0.5625!
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
        Me.Line.Width = 6.4375!
        Me.Line.X1 = 0!
        Me.Line.X2 = 6.4375!
        Me.Line.Y1 = 0!
        Me.Line.Y2 = 0!
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
        Me.TextBox14.DataField = "data_pedido"
        Me.TextBox14.Height = 0.2!
        Me.TextBox14.Left = 1.1875!
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.OutputFormat = resources.GetString("TextBox14.OutputFormat")
        Me.TextBox14.Style = "text-align: left; "
        Me.TextBox14.Text = "TextBox"
        Me.TextBox14.Top = 0.015625!
        Me.TextBox14.Width = 0.6875!
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
        Me.TextBox17.DataField = "valor_devolvido"
        Me.TextBox17.Height = 0.2!
        Me.TextBox17.Left = 4.75!
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.OutputFormat = resources.GetString("TextBox17.OutputFormat")
        Me.TextBox17.Style = "text-align: right; "
        Me.TextBox17.Text = "TextBox"
        Me.TextBox17.Top = 0!
        Me.TextBox17.Width = 0.5625!
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
        Me.TextBox19.DataField = "TotalGeral"
        Me.TextBox19.Height = 0.2!
        Me.TextBox19.Left = 5.5625!
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.OutputFormat = resources.GetString("TextBox19.OutputFormat")
        Me.TextBox19.Style = "text-align: right; "
        Me.TextBox19.Text = "TextBox"
        Me.TextBox19.Top = 0!
        Me.TextBox19.Width = 0.5625!
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtCliente, Me.txtFatura, Me.Picture, Me.lblRazao, Me.lblEndereco, Me.lblTelefone, Me.lblCepMail, Me.Line2})
        Me.PageHeader.Height = 1.604167!
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
        Me.txtCliente.Height = 0.2!
        Me.txtCliente.Left = 0!
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Style = "ddo-char-set: 1; font-weight: bold; "
        Me.txtCliente.Text = "TextBox8"
        Me.txtCliente.Top = 1.0625!
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
        Me.txtFatura.Height = 0.2!
        Me.txtFatura.Left = 0!
        Me.txtFatura.Name = "txtFatura"
        Me.txtFatura.Style = "ddo-char-set: 1; font-weight: bold; "
        Me.txtFatura.Text = "TextBox8"
        Me.txtFatura.Top = 1.25!
        Me.txtFatura.Width = 6.1875!
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
        Me.Picture.Left = 0.0625!
        Me.Picture.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Picture.LineWeight = 0!
        Me.Picture.Name = "Picture"
        Me.Picture.SizeMode = DataDynamics.ActiveReports.SizeModes.Zoom
        Me.Picture.Top = 0!
        Me.Picture.Width = 1.8125!
        '
        'lblRazao
        '
        Me.lblRazao.Border.BottomColor = System.Drawing.Color.Black
        Me.lblRazao.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblRazao.Border.LeftColor = System.Drawing.Color.Black
        Me.lblRazao.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblRazao.Border.RightColor = System.Drawing.Color.Black
        Me.lblRazao.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblRazao.Border.TopColor = System.Drawing.Color.Black
        Me.lblRazao.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblRazao.Height = 0.25!
        Me.lblRazao.HyperLink = Nothing
        Me.lblRazao.Left = 1.9375!
        Me.lblRazao.Name = "lblRazao"
        Me.lblRazao.Style = "ddo-char-set: 1; text-align: center; font-weight: normal; "
        Me.lblRazao.Text = "MR INFORMÁTICA E VIGILÂNCIA ELETRÔNICA"
        Me.lblRazao.Top = 0.125!
        Me.lblRazao.Width = 4.3125!
        '
        'lblEndereco
        '
        Me.lblEndereco.Border.BottomColor = System.Drawing.Color.Black
        Me.lblEndereco.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblEndereco.Border.LeftColor = System.Drawing.Color.Black
        Me.lblEndereco.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblEndereco.Border.RightColor = System.Drawing.Color.Black
        Me.lblEndereco.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblEndereco.Border.TopColor = System.Drawing.Color.Black
        Me.lblEndereco.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblEndereco.Height = 0.25!
        Me.lblEndereco.HyperLink = Nothing
        Me.lblEndereco.Left = 1.9375!
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Style = "ddo-char-set: 1; text-align: center; font-weight: normal; "
        Me.lblEndereco.Text = "Tb. Barão do Triunfo, 907 - Altos - Pedreira"
        Me.lblEndereco.Top = 0.3125!
        Me.lblEndereco.Width = 4.3125!
        '
        'lblTelefone
        '
        Me.lblTelefone.Border.BottomColor = System.Drawing.Color.Black
        Me.lblTelefone.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTelefone.Border.LeftColor = System.Drawing.Color.Black
        Me.lblTelefone.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTelefone.Border.RightColor = System.Drawing.Color.Black
        Me.lblTelefone.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTelefone.Border.TopColor = System.Drawing.Color.Black
        Me.lblTelefone.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblTelefone.Height = 0.25!
        Me.lblTelefone.HyperLink = Nothing
        Me.lblTelefone.Left = 1.9375!
        Me.lblTelefone.Name = "lblTelefone"
        Me.lblTelefone.Style = "ddo-char-set: 1; text-align: center; font-weight: normal; "
        Me.lblTelefone.Text = "Fones: (91) 98411-7203"
        Me.lblTelefone.Top = 0.5!
        Me.lblTelefone.Width = 4.375!
        '
        'lblCepMail
        '
        Me.lblCepMail.Border.BottomColor = System.Drawing.Color.Black
        Me.lblCepMail.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCepMail.Border.LeftColor = System.Drawing.Color.Black
        Me.lblCepMail.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCepMail.Border.RightColor = System.Drawing.Color.Black
        Me.lblCepMail.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCepMail.Border.TopColor = System.Drawing.Color.Black
        Me.lblCepMail.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblCepMail.Height = 0.25!
        Me.lblCepMail.HyperLink = Nothing
        Me.lblCepMail.Left = 1.9375!
        Me.lblCepMail.Name = "lblCepMail"
        Me.lblCepMail.Style = "ddo-char-set: 1; text-align: center; font-weight: normal; "
        Me.lblCepMail.Text = "Cep: 66083-100 - Belém - Pará - Email: labonorte@ig.com.br"
        Me.lblCepMail.Top = 0.6875!
        Me.lblCepMail.Width = 4.375!
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
        Me.Line2.Top = 1.5!
        Me.Line2.Width = 4.25!
        Me.Line2.X1 = 0!
        Me.Line2.X2 = 4.25!
        Me.Line2.Y1 = 1.5!
        Me.Line2.Y2 = 1.5!
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0.25!
        Me.PageFooter.Name = "PageFooter"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox8, Me.TextBox9, Me.TextBox10, Me.TextBox11, Me.TextBox12, Me.TextBox15, Me.TextBox16, Me.TextBox18})
        Me.GroupHeader1.Height = 0.2!
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
        Me.TextBox8.Height = 0.2!
        Me.TextBox8.Left = 0.0625!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Style = "ddo-char-set: 1; font-weight: bold; "
        Me.TextBox8.Text = "Item"
        Me.TextBox8.Top = 0!
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
        Me.TextBox9.Height = 0.2!
        Me.TextBox9.Left = 0.5!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Style = "ddo-char-set: 1; font-weight: bold; "
        Me.TextBox9.Text = "Pedido"
        Me.TextBox9.Top = 0!
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
        Me.TextBox10.Height = 0.2!
        Me.TextBox10.Left = 1.9375!
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
        Me.TextBox10.Text = "Produtos"
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
        Me.TextBox11.Height = 0.2!
        Me.TextBox11.Left = 2.75!
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
        Me.TextBox11.Text = "Serviços"
        Me.TextBox11.Top = 0!
        Me.TextBox11.Width = 0.7083333!
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
        Me.TextBox12.Left = 3.5625!
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
        Me.TextBox12.Text = "Sub Total"
        Me.TextBox12.Top = 0!
        Me.TextBox12.Width = 0.6875!
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
        Me.TextBox15.Height = 0.2!
        Me.TextBox15.Left = 1.1875!
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Style = "ddo-char-set: 1; font-weight: bold; "
        Me.TextBox15.Text = "Data"
        Me.TextBox15.Top = 0!
        Me.TextBox15.Width = 0.5625!
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
        Me.TextBox16.Left = 4.375!
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
        Me.TextBox16.Text = "V. Devolvido"
        Me.TextBox16.Top = 0!
        Me.TextBox16.Width = 0.9375!
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
        Me.TextBox18.Height = 0.1875!
        Me.TextBox18.Left = 5.4375!
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
        Me.TextBox18.Text = "Total"
        Me.TextBox18.Top = 0!
        Me.TextBox18.Width = 0.6875!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox13, Me.TextBox5, Me.TextBox6, Me.TextBox7, Me.sbRp, Me.Line1, Me.txtAcrescimo, Me.Label4, Me.Label5, Me.txtDesconto, Me.TextBox20, Me.TextBox21})
        Me.GroupFooter1.Height = 1.364583!
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
        Me.TextBox13.Left = 1.3125!
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
        Me.TextBox13.Text = "Total"
        Me.TextBox13.Top = 0!
        Me.TextBox13.Width = 0.53125!
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
        Me.TextBox5.DataField = "servicos"
        Me.TextBox5.Height = 0.2!
        Me.TextBox5.Left = 2.755208!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.OutputFormat = resources.GetString("TextBox5.OutputFormat")
        Me.TextBox5.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
        Me.TextBox5.SummaryGroup = "GroupHeader1"
        Me.TextBox5.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox5.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox5.Text = "TextBox"
        Me.TextBox5.Top = 0!
        Me.TextBox5.Width = 0.6875!
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
        Me.TextBox6.DataField = "produtos"
        Me.TextBox6.Height = 0.2!
        Me.TextBox6.Left = 1.984375!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.OutputFormat = resources.GetString("TextBox6.OutputFormat")
        Me.TextBox6.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
        Me.TextBox6.SummaryGroup = "GroupHeader1"
        Me.TextBox6.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox6.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox6.Text = "TextBox"
        Me.TextBox6.Top = 0!
        Me.TextBox6.Width = 0.6875!
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
        Me.TextBox7.DataField = "Total"
        Me.TextBox7.Height = 0.2!
        Me.TextBox7.Left = 3.552083!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.OutputFormat = resources.GetString("TextBox7.OutputFormat")
        Me.TextBox7.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
        Me.TextBox7.SummaryGroup = "GroupHeader1"
        Me.TextBox7.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox7.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox7.Text = "TextBox"
        Me.TextBox7.Top = 0!
        Me.TextBox7.Width = 0.6875!
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
        Me.sbRp.Height = 0.1968504!
        Me.sbRp.Left = 1.75!
        Me.sbRp.Name = "sbRp"
        Me.sbRp.Report = Nothing
        Me.sbRp.Top = 0.9375!
        Me.sbRp.Width = 4.38!
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
        Me.Line1.Width = 6.4375!
        Me.Line1.X1 = 0!
        Me.Line1.X2 = 6.4375!
        Me.Line1.Y1 = 0!
        Me.Line1.Y2 = 0!
        '
        'txtAcrescimo
        '
        Me.txtAcrescimo.Border.BottomColor = System.Drawing.Color.Black
        Me.txtAcrescimo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAcrescimo.Border.LeftColor = System.Drawing.Color.Black
        Me.txtAcrescimo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAcrescimo.Border.RightColor = System.Drawing.Color.Black
        Me.txtAcrescimo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAcrescimo.Border.TopColor = System.Drawing.Color.Black
        Me.txtAcrescimo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAcrescimo.Height = 0.2!
        Me.txtAcrescimo.Left = 5.4375!
        Me.txtAcrescimo.Name = "txtAcrescimo"
        Me.txtAcrescimo.OutputFormat = resources.GetString("txtAcrescimo.OutputFormat")
        Me.txtAcrescimo.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
        Me.txtAcrescimo.SummaryGroup = "GroupHeader1"
        Me.txtAcrescimo.Text = "TextBox"
        Me.txtAcrescimo.Top = 0.3125!
        Me.txtAcrescimo.Width = 0.6875!
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
        Me.Label4.Left = 4.375!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
        Me.Label4.Text = "Acréscimo:"
        Me.Label4.Top = 0.3125!
        Me.Label4.Width = 1.0!
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
        Me.Label5.Left = 4.375!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
        Me.Label5.Text = "Desconto:"
        Me.Label5.Top = 0.5!
        Me.Label5.Width = 1.0!
        '
        'txtDesconto
        '
        Me.txtDesconto.Border.BottomColor = System.Drawing.Color.Black
        Me.txtDesconto.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDesconto.Border.LeftColor = System.Drawing.Color.Black
        Me.txtDesconto.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDesconto.Border.RightColor = System.Drawing.Color.Black
        Me.txtDesconto.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDesconto.Border.TopColor = System.Drawing.Color.Black
        Me.txtDesconto.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDesconto.Height = 0.2!
        Me.txtDesconto.Left = 5.4375!
        Me.txtDesconto.Name = "txtDesconto"
        Me.txtDesconto.OutputFormat = resources.GetString("txtDesconto.OutputFormat")
        Me.txtDesconto.Style = "color: Red; ddo-char-set: 1; text-align: right; font-weight: bold; "
        Me.txtDesconto.SummaryGroup = "GroupHeader1"
        Me.txtDesconto.Text = "TextBox"
        Me.txtDesconto.Top = 0.5!
        Me.txtDesconto.Width = 0.6875!
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
        Me.TextBox20.DataField = "valor_devolvido"
        Me.TextBox20.Height = 0.2!
        Me.TextBox20.Left = 4.625!
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.OutputFormat = resources.GetString("TextBox20.OutputFormat")
        Me.TextBox20.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
        Me.TextBox20.SummaryGroup = "GroupHeader1"
        Me.TextBox20.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox20.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox20.Text = "TextBox"
        Me.TextBox20.Top = 0!
        Me.TextBox20.Width = 0.6875!
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
        Me.TextBox21.DataField = "TotalGeral"
        Me.TextBox21.Height = 0.2!
        Me.TextBox21.Left = 5.4375!
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.OutputFormat = resources.GetString("TextBox21.OutputFormat")
        Me.TextBox21.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
        Me.TextBox21.SummaryGroup = "GroupHeader1"
        Me.TextBox21.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox21.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox21.Text = "TextBox"
        Me.TextBox21.Top = 0!
        Me.TextBox21.Width = 0.6875!
        '
        'rptFatura
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
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
        CType(Me.TextBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFatura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblRazao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblEndereco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTelefone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCepMail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAcrescimo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDesconto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

    Private Sub GroupFooter1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupFooter1.Format
        r.DataSource = tRec
        r.aPagar = Format(CDbl(aPagar), "#,##0.00")
        sbRp.Report = r
        txtAcrescimo.Text = Format(CDbl(acrescimo), "#,##0.00")
        txtDesconto.Text = Format(CDbl(desconto), "#,##0.00")
    End Sub

    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        txtCliente.Text = cliente
        txtFatura.Text = fatura
        cabecalho()
    End Sub
    Private Sub cabecalho()
        lblRazao.Text = emitente.RazaoSocial
        lblEndereco.Text = emitente.Logradouro & " nº " & emitente.Numero & " " & emitente.Complemento & " Bairro: " & emitente.Bairro
        lblTelefone.Text = "Telefone(s): " & emitente.TelefoneFixo
        lblCepMail.Text = "Cep.: " & emitente.cep & " email: " & emitente.email

    End Sub
End Class
