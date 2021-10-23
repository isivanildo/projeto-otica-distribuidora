Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports mrotica_util

Public Class rptPedido
    Inherits DataDynamics.ActiveReports.ActiveReport3
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub
    Public tbItens As New DataTable
    Public tbServ As New DataTable
    Public Total As String
    Public n_pedido As String
    Public filial As Integer
    Public Vendedor As String
    Public cliente As String
    Public cod_cliente As String
    Public data As String
    Dim conf As New config
    Dim d As New dados
#Region "ActiveReports Designer generated code"
    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader = Nothing
    Private WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader = Nothing
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
    Private WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter = Nothing
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
	Private fldPedido As DataDynamics.ActiveReports.TextBox
	Private fldVendedor As DataDynamics.ActiveReports.TextBox
	Private fldCliente As DataDynamics.ActiveReports.TextBox
	Private lblData As DataDynamics.ActiveReports.Label
	Private Line As DataDynamics.ActiveReports.Line
	Private subItens As DataDynamics.ActiveReports.SubReport
	Private subServ As DataDynamics.ActiveReports.SubReport
	Private txtTotal As DataDynamics.ActiveReports.TextBox
    Private Label As DataDynamics.ActiveReports.Label
    Friend WithEvents lblEconomia As DataDynamics.ActiveReports.Label
    Private WithEvents lblRazaoSocial As DataDynamics.ActiveReports.Label
    Private WithEvents lblEndereco As DataDynamics.ActiveReports.Label
    Private WithEvents lblFone As DataDynamics.ActiveReports.Label
    Friend WithEvents Picture1 As DataDynamics.ActiveReports.Picture
    Friend WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Barcode1 As DataDynamics.ActiveReports.Barcode
    Friend WithEvents Label1 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Private Line1 As DataDynamics.ActiveReports.Line
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptPedido))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.subItens = New DataDynamics.ActiveReports.SubReport()
        Me.subServ = New DataDynamics.ActiveReports.SubReport()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader()
        Me.fldPedido = New DataDynamics.ActiveReports.TextBox()
        Me.fldVendedor = New DataDynamics.ActiveReports.TextBox()
        Me.fldCliente = New DataDynamics.ActiveReports.TextBox()
        Me.lblData = New DataDynamics.ActiveReports.Label()
        Me.Line = New DataDynamics.ActiveReports.Line()
        Me.lblRazaoSocial = New DataDynamics.ActiveReports.Label()
        Me.lblEndereco = New DataDynamics.ActiveReports.Label()
        Me.lblFone = New DataDynamics.ActiveReports.Label()
        Me.Picture1 = New DataDynamics.ActiveReports.Picture()
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox()
        Me.Barcode1 = New DataDynamics.ActiveReports.Barcode()
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter()
        Me.txtTotal = New DataDynamics.ActiveReports.TextBox()
        Me.Label = New DataDynamics.ActiveReports.Label()
        Me.lblEconomia = New DataDynamics.ActiveReports.Label()
        Me.Line1 = New DataDynamics.ActiveReports.Line()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox()
        CType(Me.fldPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldVendedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblRazaoSocial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblEndereco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblEconomia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.subItens, Me.subServ})
        Me.Detail.Height = 0.3125!
        Me.Detail.Name = "Detail"
        '
        'subItens
        '
        Me.subItens.Border.BottomColor = System.Drawing.Color.Black
        Me.subItens.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.subItens.Border.LeftColor = System.Drawing.Color.Black
        Me.subItens.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.subItens.Border.RightColor = System.Drawing.Color.Black
        Me.subItens.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.subItens.Border.TopColor = System.Drawing.Color.Black
        Me.subItens.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.subItens.CloseBorder = False
        Me.subItens.Height = 0.125!
        Me.subItens.Left = 0!
        Me.subItens.Name = "subItens"
        Me.subItens.Report = Nothing
        Me.subItens.Top = 0!
        Me.subItens.Width = 7.5625!
        '
        'subServ
        '
        Me.subServ.Border.BottomColor = System.Drawing.Color.Black
        Me.subServ.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.subServ.Border.LeftColor = System.Drawing.Color.Black
        Me.subServ.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.subServ.Border.RightColor = System.Drawing.Color.Black
        Me.subServ.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.subServ.Border.TopColor = System.Drawing.Color.Black
        Me.subServ.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.subServ.CloseBorder = False
        Me.subServ.Height = 0.125!
        Me.subServ.Left = 0!
        Me.subServ.Name = "subServ"
        Me.subServ.Report = Nothing
        Me.subServ.Top = 0.1875!
        Me.subServ.Width = 7.5625!
        '
        'PageHeader
        '
        Me.PageHeader.Height = 0!
        Me.PageHeader.Name = "PageHeader"
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0!
        Me.PageFooter.Name = "PageFooter"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.fldPedido, Me.fldVendedor, Me.fldCliente, Me.lblData, Me.Line, Me.lblRazaoSocial, Me.lblEndereco, Me.lblFone, Me.Picture1, Me.TextBox1, Me.Barcode1})
        Me.GroupHeader1.Height = 1.0!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'fldPedido
        '
        Me.fldPedido.Border.BottomColor = System.Drawing.Color.Black
        Me.fldPedido.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldPedido.Border.LeftColor = System.Drawing.Color.Black
        Me.fldPedido.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldPedido.Border.RightColor = System.Drawing.Color.Black
        Me.fldPedido.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldPedido.Border.TopColor = System.Drawing.Color.Black
        Me.fldPedido.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldPedido.Height = 0.1875!
        Me.fldPedido.Left = 1.5625!
        Me.fldPedido.Name = "fldPedido"
        Me.fldPedido.Style = "ddo-char-set: 0; font-weight: bold; font-size: 6.75pt; font-family: Arial; "
        Me.fldPedido.Text = Nothing
        Me.fldPedido.Top = 0.8125!
        Me.fldPedido.Width = 1.625!
        '
        'fldVendedor
        '
        Me.fldVendedor.Border.BottomColor = System.Drawing.Color.Black
        Me.fldVendedor.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldVendedor.Border.LeftColor = System.Drawing.Color.Black
        Me.fldVendedor.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldVendedor.Border.RightColor = System.Drawing.Color.Black
        Me.fldVendedor.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldVendedor.Border.TopColor = System.Drawing.Color.Black
        Me.fldVendedor.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldVendedor.Height = 0.1875!
        Me.fldVendedor.Left = 5.5!
        Me.fldVendedor.Name = "fldVendedor"
        Me.fldVendedor.Style = "ddo-char-set: 0; font-weight: bold; font-size: 6.75pt; font-family: Arial; "
        Me.fldVendedor.Text = Nothing
        Me.fldVendedor.Top = 0.8125!
        Me.fldVendedor.Width = 1.9375!
        '
        'fldCliente
        '
        Me.fldCliente.Border.BottomColor = System.Drawing.Color.Black
        Me.fldCliente.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldCliente.Border.LeftColor = System.Drawing.Color.Black
        Me.fldCliente.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldCliente.Border.RightColor = System.Drawing.Color.Black
        Me.fldCliente.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldCliente.Border.TopColor = System.Drawing.Color.Black
        Me.fldCliente.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldCliente.Height = 0.1875!
        Me.fldCliente.Left = 3.3125!
        Me.fldCliente.Name = "fldCliente"
        Me.fldCliente.Style = "ddo-char-set: 0; font-weight: bold; font-size: 6.75pt; font-family: Arial; "
        Me.fldCliente.Text = Nothing
        Me.fldCliente.Top = 0.625!
        Me.fldCliente.Width = 4.125!
        '
        'lblData
        '
        Me.lblData.Border.BottomColor = System.Drawing.Color.Black
        Me.lblData.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblData.Border.LeftColor = System.Drawing.Color.Black
        Me.lblData.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblData.Border.RightColor = System.Drawing.Color.Black
        Me.lblData.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblData.Border.TopColor = System.Drawing.Color.Black
        Me.lblData.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblData.Height = 0.1875!
        Me.lblData.HyperLink = Nothing
        Me.lblData.Left = 1.5625!
        Me.lblData.Name = "lblData"
        Me.lblData.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 6.75pt; font-fam" &
    "ily: Arial; "
        Me.lblData.Text = "Label1"
        Me.lblData.Top = 0.625!
        Me.lblData.Width = 1.625!
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
        Me.Line.Left = 0.25!
        Me.Line.LineWeight = 1.0!
        Me.Line.Name = "Line"
        Me.Line.Top = 1.0!
        Me.Line.Width = 7.5625!
        Me.Line.X1 = 0.25!
        Me.Line.X2 = 7.8125!
        Me.Line.Y1 = 1.0!
        Me.Line.Y2 = 1.0!
        '
        'lblRazaoSocial
        '
        Me.lblRazaoSocial.Border.BottomColor = System.Drawing.Color.Black
        Me.lblRazaoSocial.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblRazaoSocial.Border.LeftColor = System.Drawing.Color.Black
        Me.lblRazaoSocial.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblRazaoSocial.Border.RightColor = System.Drawing.Color.Black
        Me.lblRazaoSocial.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblRazaoSocial.Border.TopColor = System.Drawing.Color.Black
        Me.lblRazaoSocial.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblRazaoSocial.Height = 0.125!
        Me.lblRazaoSocial.HyperLink = Nothing
        Me.lblRazaoSocial.Left = 2.25!
        Me.lblRazaoSocial.Name = "lblRazaoSocial"
        Me.lblRazaoSocial.Style = "ddo-char-set: 0; text-align: center; font-weight: normal; font-size: 8.25pt; "
        Me.lblRazaoSocial.Text = "TAVEIRA COMÉRCIO DE PRODUTOS ÓTICOS LTDA"
        Me.lblRazaoSocial.Top = 0!
        Me.lblRazaoSocial.Width = 3.5!
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
        Me.lblEndereco.Height = 0.125!
        Me.lblEndereco.HyperLink = Nothing
        Me.lblEndereco.Left = 1.9375!
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Style = "ddo-char-set: 0; text-align: center; font-weight: normal; font-size: 8.25pt; "
        Me.lblEndereco.Text = "Rua Ó de Almeida, 298 - Térreo - Campina"
        Me.lblEndereco.Top = 0.125!
        Me.lblEndereco.Width = 4.1875!
        '
        'lblFone
        '
        Me.lblFone.Border.BottomColor = System.Drawing.Color.Black
        Me.lblFone.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblFone.Border.LeftColor = System.Drawing.Color.Black
        Me.lblFone.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblFone.Border.RightColor = System.Drawing.Color.Black
        Me.lblFone.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblFone.Border.TopColor = System.Drawing.Color.Black
        Me.lblFone.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblFone.Height = 0.125!
        Me.lblFone.HyperLink = Nothing
        Me.lblFone.Left = 2.1875!
        Me.lblFone.Name = "lblFone"
        Me.lblFone.Style = "ddo-char-set: 0; text-align: center; font-weight: normal; font-size: 8.25pt; "
        Me.lblFone.Text = "Fones: (91) 3230-3124 / 3241-1837 - Fax: (91) 3241-9440"
        Me.lblFone.Top = 0.25!
        Me.lblFone.Width = 3.6875!
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
        Me.Picture1.Top = 0!
        Me.Picture1.Width = 1.3125!
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
        Me.TextBox1.Height = 0.1875!
        Me.TextBox1.Left = 3.3125!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "ddo-char-set: 0; font-weight: bold; font-size: 6.75pt; font-family: Arial; "
        Me.TextBox1.Text = Nothing
        Me.TextBox1.Top = 0.8125!
        Me.TextBox1.Width = 2.0625!
        '
        'Barcode1
        '
        Me.Barcode1.Border.BottomColor = System.Drawing.Color.Black
        Me.Barcode1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Barcode1.Border.LeftColor = System.Drawing.Color.Black
        Me.Barcode1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Barcode1.Border.RightColor = System.Drawing.Color.Black
        Me.Barcode1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Barcode1.Border.TopColor = System.Drawing.Color.Black
        Me.Barcode1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Barcode1.Font = New System.Drawing.Font("Courier New", 8.0!)
        Me.Barcode1.Height = 0.35!
        Me.Barcode1.Left = 0!
        Me.Barcode1.Name = "Barcode1"
        Me.Barcode1.Style = DataDynamics.ActiveReports.BarCodeStyle.Code_128_A
        Me.Barcode1.Text = "Barcode1"
        Me.Barcode1.Top = 0.625!
        Me.Barcode1.Width = 1.5!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtTotal, Me.Label, Me.lblEconomia, Me.Line1, Me.Label1, Me.TextBox2})
        Me.GroupFooter1.Height = 0.46875!
        Me.GroupFooter1.Name = "GroupFooter1"
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
        Me.txtTotal.Height = 0.1875!
        Me.txtTotal.Left = 6.3125!
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; "
        Me.txtTotal.Text = "TextBox"
        Me.txtTotal.Top = 0.0625!
        Me.txtTotal.Width = 0.875!
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
        Me.Label.Left = 5.25!
        Me.Label.Name = "Label"
        Me.Label.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; "
        Me.Label.Text = "Total Pedido:"
        Me.Label.Top = 0.0625!
        Me.Label.Width = 1.0!
        '
        'lblEconomia
        '
        Me.lblEconomia.Border.BottomColor = System.Drawing.Color.Black
        Me.lblEconomia.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblEconomia.Border.LeftColor = System.Drawing.Color.Black
        Me.lblEconomia.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblEconomia.Border.RightColor = System.Drawing.Color.Black
        Me.lblEconomia.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblEconomia.Border.TopColor = System.Drawing.Color.Black
        Me.lblEconomia.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblEconomia.Height = 0.1875!
        Me.lblEconomia.HyperLink = Nothing
        Me.lblEconomia.Left = 0!
        Me.lblEconomia.Name = "lblEconomia"
        Me.lblEconomia.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-style: normal; font-si" &
    "ze: 8.25pt; "
        Me.lblEconomia.Text = ""
        Me.lblEconomia.Top = 0!
        Me.lblEconomia.Width = 5.125!
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
        Me.Line1.LineStyle = DataDynamics.ActiveReports.LineStyle.Dash
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.4375!
        Me.Line1.Width = 7.5625!
        Me.Line1.X1 = 0!
        Me.Line1.X2 = 7.5625!
        Me.Line1.Y1 = 0.4375!
        Me.Line1.Y2 = 0.4375!
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
        Me.Label1.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 8.25pt; "
        Me.Label1.Text = "Forma Pagamento:"
        Me.Label1.Top = 0.25!
        Me.Label1.Width = 1.125!
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
        Me.TextBox2.Height = 0.1875!
        Me.TextBox2.Left = 1.125!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 8.25pt; "
        Me.TextBox2.Text = "TextBox"
        Me.TextBox2.Top = 0.25!
        Me.TextBox2.Width = 1.5!
        '
        'rptPedido
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.69!
        Me.PageSettings.PaperWidth = 8.27!
        Me.PrintWidth = 7.552083!
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
        CType(Me.fldPedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldVendedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblRazaoSocial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblEndereco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblEconomia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region
    Private Sub rptServ_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        Dim rItens As New rptItensPedido
        Dim rServ As New rptServPedido
        If tbItens.Rows.Count > 0 Then
            rItens.tb = tbItens
            Me.subItens.Report = rItens
        End If
        If tbServ.Rows.Count > 0 Then
            rServ.tb = tbServ
            Me.subServ.Report = rServ
        End If

        If My.Computer.FileSystem.FileExists(conf.ImagemRelatorio) Then
            Picture1.Image = Image.FromFile(conf.ImagemRelatorio)
        End If
    End Sub
    Private Sub GroupFooter1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupFooter1.Format
        txtTotal.Text = Total
    End Sub

    Private Sub GroupHeader1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupHeader1.Format
        fldPedido.Text = "Pedido: " & n_pedido.PadLeft(3, "0") & " OS: " & os(n_pedido)

        fldVendedor.Text = "Vend.: " & Vendedor
        fldCliente.Text = "Cliente: " & cod_cliente & " " & cliente
        lblData.Text = data
        cabecalho()
    End Sub
    Private Sub cabecalho()
        Dim emitente As New objEmpresa()
        emitente.Registro(Convert.ToInt16(conf.Filial))
        'Dim emitente As New objEmitente(conf.Filial)
        lblRazaoSocial.Text = emitente.RazaoSocial
        lblEndereco.Text = emitente.Logradouro & " nº " & emitente.Numero & " " & emitente.Complemento & " Bairro: " & emitente.Bairro
        lblFone.Text = "Telefone(s): " & emitente.TelefoneFixo

    End Sub
    Private Function os(ByVal n_pedido As Integer) As String
        Dim sql As String
        Dim tt As New DataTable
        sql = "select cod_os from os where num_pedido = " & n_pedido & " and id_filial = " & filial
        d.carrega_Tabela(sql, tt)
        If tt.Rows.Count > 0 Then
            Return tt.Rows(0)("cod_os")
        End If
    End Function


End Class
