Imports mrotica_util
Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class rptPedidos_balcao
Inherits DataDynamics.ActiveReports.ActiveReport3
	Public Sub New()
	MyBase.New()
		InitializeComponent()
    End Sub
    Dim total As Double = 0
	#Region "ActiveReports Designer generated code"
    Private WithEvents ReportHeader As DataDynamics.ActiveReports.ReportHeader = Nothing
    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader = Nothing
    Private WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader = Nothing
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
    Private WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter = Nothing
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
    Private WithEvents ReportFooter As DataDynamics.ActiveReports.ReportFooter = Nothing
	Private Label2 As DataDynamics.ActiveReports.Label
	Private Label As DataDynamics.ActiveReports.Label
	Private Label3 As DataDynamics.ActiveReports.Label
	Private Label4 As DataDynamics.ActiveReports.Label
	Private Line3 As DataDynamics.ActiveReports.Line
	Private lblTitulo As DataDynamics.ActiveReports.Label
	Private fldPedido As DataDynamics.ActiveReports.TextBox
	Private fldFilial As DataDynamics.ActiveReports.TextBox
	Private fldCliente As DataDynamics.ActiveReports.TextBox
	Private fldVendedor As DataDynamics.ActiveReports.TextBox
	Private Line As DataDynamics.ActiveReports.Line
	Private TextBox As DataDynamics.ActiveReports.TextBox
	Private subDet As DataDynamics.ActiveReports.SubReport
	Private txtTotal As DataDynamics.ActiveReports.TextBox
	Private Label1 As DataDynamics.ActiveReports.Label
	Private Line1 As DataDynamics.ActiveReports.Line
	Private Line2 As DataDynamics.ActiveReports.Line
	Private Line4 As DataDynamics.ActiveReports.Line
    Private txtTotalDia As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox30 As DataDynamics.ActiveReports.TextBox
	Private Label6 As DataDynamics.ActiveReports.Label
	Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptPedidos_balcao))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.subDet = New DataDynamics.ActiveReports.SubReport()
        Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.Label = New DataDynamics.ActiveReports.Label()
        Me.Label3 = New DataDynamics.ActiveReports.Label()
        Me.Label4 = New DataDynamics.ActiveReports.Label()
        Me.Line3 = New DataDynamics.ActiveReports.Line()
        Me.lblTitulo = New DataDynamics.ActiveReports.Label()
        Me.ReportFooter = New DataDynamics.ActiveReports.ReportFooter()
        Me.Line4 = New DataDynamics.ActiveReports.Line()
        Me.txtTotalDia = New DataDynamics.ActiveReports.Label()
        Me.Label6 = New DataDynamics.ActiveReports.Label()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader()
        Me.fldPedido = New DataDynamics.ActiveReports.TextBox()
        Me.fldFilial = New DataDynamics.ActiveReports.TextBox()
        Me.fldCliente = New DataDynamics.ActiveReports.TextBox()
        Me.fldVendedor = New DataDynamics.ActiveReports.TextBox()
        Me.Line = New DataDynamics.ActiveReports.Line()
        Me.TextBox = New DataDynamics.ActiveReports.TextBox()
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter()
        Me.txtTotal = New DataDynamics.ActiveReports.TextBox()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        Me.Line1 = New DataDynamics.ActiveReports.Line()
        Me.Line2 = New DataDynamics.ActiveReports.Line()
        Me.TextBox30 = New DataDynamics.ActiveReports.TextBox()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalDia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldFilial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldVendedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.subDet})
        Me.Detail.Height = 0.1034722!
        Me.Detail.Name = "Detail"
        '
        'subDet
        '
        Me.subDet.Border.BottomColor = System.Drawing.Color.Black
        Me.subDet.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.subDet.Border.LeftColor = System.Drawing.Color.Black
        Me.subDet.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.subDet.Border.RightColor = System.Drawing.Color.Black
        Me.subDet.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.subDet.Border.TopColor = System.Drawing.Color.Black
        Me.subDet.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.subDet.CloseBorder = False
        Me.subDet.Height = 0.0625!
        Me.subDet.Left = 0.1875!
        Me.subDet.Name = "subDet"
        Me.subDet.Report = Nothing
        Me.subDet.Top = 0.0!
        Me.subDet.Width = 7.0!
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label2, Me.Label, Me.Label3, Me.Label4, Me.Line3, Me.lblTitulo})
        Me.ReportHeader.Height = 0.6444445!
        Me.ReportHeader.Name = "ReportHeader"
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
        Me.Label2.Left = 1.3125!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "ddo-char-set: 1; font-weight: bold; "
        Me.Label2.Text = "Vendedor"
        Me.Label2.Top = 0.4375!
        Me.Label2.Width = 1.0!
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
        Me.Label.Left = 0.0!
        Me.Label.Name = "Label"
        Me.Label.Style = "ddo-char-set: 1; font-weight: bold; "
        Me.Label.Text = "Pedido"
        Me.Label.Top = 0.4375!
        Me.Label.Width = 1.0!
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
        Me.Label3.Left = 3.125!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "ddo-char-set: 1; font-weight: bold; "
        Me.Label3.Text = "Cliente"
        Me.Label3.Top = 0.4375!
        Me.Label3.Width = 1.0!
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
        Me.Label4.Left = 5.0625!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "ddo-char-set: 1; font-weight: bold; "
        Me.Label4.Text = "Status Pedido"
        Me.Label4.Top = 0.4375!
        Me.Label4.Width = 1.0!
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
        Me.Line3.Left = 0.0!
        Me.Line3.LineWeight = 1.0!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 0.453125!
        Me.Line3.Width = 7.0!
        Me.Line3.X1 = 0.0!
        Me.Line3.X2 = 7.0!
        Me.Line3.Y1 = 0.453125!
        Me.Line3.Y2 = 0.453125!
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
        Me.lblTitulo.Left = 0.0625!
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; "
        Me.lblTitulo.Text = "Pedidos"
        Me.lblTitulo.Top = 0.0625!
        Me.lblTitulo.Width = 7.0625!
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Line4, Me.txtTotalDia, Me.Label6})
        Me.ReportFooter.Height = 0.3222222!
        Me.ReportFooter.Name = "ReportFooter"
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
        Me.Line4.Left = 5.197917!
        Me.Line4.LineStyle = DataDynamics.ActiveReports.LineStyle.DashDotDot
        Me.Line4.LineWeight = 1.0!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 0.0!
        Me.Line4.Width = 1.8125!
        Me.Line4.X1 = 5.197917!
        Me.Line4.X2 = 7.010417!
        Me.Line4.Y1 = 0.0!
        Me.Line4.Y2 = 0.0!
        '
        'txtTotalDia
        '
        Me.txtTotalDia.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTotalDia.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalDia.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTotalDia.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalDia.Border.RightColor = System.Drawing.Color.Black
        Me.txtTotalDia.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalDia.Border.TopColor = System.Drawing.Color.Black
        Me.txtTotalDia.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalDia.Height = 0.2!
        Me.txtTotalDia.HyperLink = Nothing
        Me.txtTotalDia.Left = 5.947917!
        Me.txtTotalDia.Name = "txtTotalDia"
        Me.txtTotalDia.Style = "text-align: right; "
        Me.txtTotalDia.Text = "Total"
        Me.txtTotalDia.Top = 0.0!
        Me.txtTotalDia.Width = 1.0!
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
        Me.Label6.Left = 4.875!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "text-align: right; "
        Me.Label6.Text = "Vendas do dia:"
        Me.Label6.Top = 0.0!
        Me.Label6.Width = 1.0!
        '
        'PageHeader
        '
        Me.PageHeader.Height = 0.0!
        Me.PageHeader.Name = "PageHeader"
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox30})
        Me.PageFooter.Height = 0.2708333!
        Me.PageFooter.Name = "PageFooter"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.fldPedido, Me.fldFilial, Me.fldCliente, Me.fldVendedor, Me.Line, Me.TextBox})
        Me.GroupHeader1.DataField = "num_pedido"
        Me.GroupHeader1.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.FirstDetail
        Me.GroupHeader1.Height = 0.21875!
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
        Me.fldPedido.DataField = "num_pedido"
        Me.fldPedido.Height = 0.1875!
        Me.fldPedido.Left = 0.0!
        Me.fldPedido.Name = "fldPedido"
        Me.fldPedido.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; "
        Me.fldPedido.Text = Nothing
        Me.fldPedido.Top = 0.0!
        Me.fldPedido.Width = 1.25!
        '
        'fldFilial
        '
        Me.fldFilial.Border.BottomColor = System.Drawing.Color.Black
        Me.fldFilial.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldFilial.Border.LeftColor = System.Drawing.Color.Black
        Me.fldFilial.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldFilial.Border.RightColor = System.Drawing.Color.Black
        Me.fldFilial.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldFilial.Border.TopColor = System.Drawing.Color.Black
        Me.fldFilial.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldFilial.DataField = "id_filial"
        Me.fldFilial.Height = 0.1875!
        Me.fldFilial.Left = 0.9375!
        Me.fldFilial.Name = "fldFilial"
        Me.fldFilial.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; "
        Me.fldFilial.Text = Nothing
        Me.fldFilial.Top = 0.0!
        Me.fldFilial.Visible = False
        Me.fldFilial.Width = 0.3125!
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
        Me.fldCliente.DataField = "nome_cliente"
        Me.fldCliente.Height = 0.1875!
        Me.fldCliente.Left = 3.125!
        Me.fldCliente.Name = "fldCliente"
        Me.fldCliente.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; "
        Me.fldCliente.Text = Nothing
        Me.fldCliente.Top = 0.0!
        Me.fldCliente.Width = 1.875!
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
        Me.fldVendedor.DataField = "nome"
        Me.fldVendedor.Height = 0.1875!
        Me.fldVendedor.Left = 1.3125!
        Me.fldVendedor.Name = "fldVendedor"
        Me.fldVendedor.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; "
        Me.fldVendedor.Text = Nothing
        Me.fldVendedor.Top = 0.0!
        Me.fldVendedor.Width = 1.75!
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
        Me.Line.LineWeight = 1.0!
        Me.Line.Name = "Line"
        Me.Line.Top = 0.2083333!
        Me.Line.Width = 7.0!
        Me.Line.X1 = 0.0!
        Me.Line.X2 = 7.0!
        Me.Line.Y1 = 0.2083333!
        Me.Line.Y2 = 0.2083333!
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
        Me.TextBox.DataField = "status_pedido"
        Me.TextBox.Height = 0.1875!
        Me.TextBox.Left = 5.0625!
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; "
        Me.TextBox.Text = Nothing
        Me.TextBox.Top = 0.0!
        Me.TextBox.Width = 1.9375!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtTotal, Me.Label1, Me.Line1, Me.Line2})
        Me.GroupFooter1.Height = 0.2076389!
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
        Me.txtTotal.Left = 6.0!
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; "
        Me.txtTotal.Text = Nothing
        Me.txtTotal.Top = 0.0!
        Me.txtTotal.Width = 0.9375!
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
        Me.Label1.Left = 4.875!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "text-align: right; "
        Me.Label1.Text = "Total:"
        Me.Label1.Top = 0.0!
        Me.Label1.Width = 1.0!
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
        Me.Line1.Left = 5.1875!
        Me.Line1.LineStyle = DataDynamics.ActiveReports.LineStyle.DashDotDot
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.0!
        Me.Line1.Width = 1.8125!
        Me.Line1.X1 = 5.1875!
        Me.Line1.X2 = 7.0!
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
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0.1875!
        Me.Line2.Width = 7.0!
        Me.Line2.X1 = 0.0!
        Me.Line2.X2 = 7.0!
        Me.Line2.Y1 = 0.1875!
        Me.Line2.Y2 = 0.1875!
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
        Me.TextBox30.Left = 6.0625!
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Style = "text-align: right; font-size: 6.75pt; "
        Me.TextBox30.Text = "TextBox30"
        Me.TextBox30.Top = 0.0625!
        Me.TextBox30.Width = 0.875!
        '
        'rptPedidos_balcao
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.69!
        Me.PageSettings.PaperWidth = 8.27!
        Me.PrintWidth = 7.177083!
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
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalDia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldPedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldFilial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldVendedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

	#End Region
    Dim pedido As New objPedidoBalcao
    Public dia As String
    Private Sub GroupHeader1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupHeader1.Format
        pedido.carrega_pedido(fldPedido.Text, fldFilial.Text)
        Dim rDet As New rptDetPedido

        rDet.id_filial = pedido.id_filial
        rDet.num_pedido = pedido.num_pedido
        Me.subDet.Report = rDet

        Me.fldPedido.Text = adiciona_zeros(fldPedido.Text, 6)
    End Sub
    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        
    End Sub

    Private Sub GroupFooter1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupFooter1.Format
        txtTotal.Text = cdinShow(pedido.total_itens + pedido.total_servicos)
        total = total + txtTotal.Text
    End Sub

    Private Sub ReportFooter_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportFooter.Format
        txtTotalDia.Text = cdinShow(total)
    End Sub

    Private Sub ReportHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportHeader.Format
        lblTitulo.Text = "Pedidos do Dia " & dia
    End Sub

    Private Sub PageFooter_Format(sender As System.Object, e As System.EventArgs) Handles PageFooter.Format
        TextBox30.Text = "Página: " & PageNumber
    End Sub
End Class
