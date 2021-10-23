Imports mrotica_util
Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class rptVendasSintetico
Inherits DataDynamics.ActiveReports.ActiveReport3
	Public Sub New()
	MyBase.New()
		InitializeComponent()
    End Sub
    Public dia As Date
    Dim cliente As New objCliente
    Dim sql As String
    Dim d As New dados
    Dim tt As New DataTable
    Dim r As DataRow
    Dim tServSub, tServG, tProdSub, tProdG As Double
    Dim c As New config
#Region "ActiveReports Designer generated code"
    Private WithEvents ReportHeader As DataDynamics.ActiveReports.ReportHeader = Nothing
    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader = Nothing
    Private WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader = Nothing
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
    Private WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter = Nothing
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
    Private WithEvents ReportFooter As DataDynamics.ActiveReports.ReportFooter = Nothing
	Private lblTitulo As DataDynamics.ActiveReports.Label
	Private txtCodCliente As DataDynamics.ActiveReports.TextBox
	Private txtCliente As DataDynamics.ActiveReports.TextBox
	Private Label As DataDynamics.ActiveReports.Label
	Private Label1 As DataDynamics.ActiveReports.Label
	Private Label2 As DataDynamics.ActiveReports.Label
	Private Label3 As DataDynamics.ActiveReports.Label
	Private Label4 As DataDynamics.ActiveReports.Label
	Private txtOS As DataDynamics.ActiveReports.TextBox
	Private txtNPedido As DataDynamics.ActiveReports.TextBox
	Private txtProdutos As DataDynamics.ActiveReports.TextBox
	Private txtServicos As DataDynamics.ActiveReports.TextBox
	Private txtTotal As DataDynamics.ActiveReports.TextBox
	Private Line As DataDynamics.ActiveReports.Line
	Private txtSubProd As DataDynamics.ActiveReports.TextBox
	Private txtSubServ As DataDynamics.ActiveReports.TextBox
	Private txtSubTotal As DataDynamics.ActiveReports.TextBox
	Private txtstrSubTotal As DataDynamics.ActiveReports.TextBox
	Private Line1 As DataDynamics.ActiveReports.Line
	Private Line2 As DataDynamics.ActiveReports.Line
	Private lblPag As DataDynamics.ActiveReports.Label
	Private txtTT As DataDynamics.ActiveReports.TextBox
	Private txtServT As DataDynamics.ActiveReports.TextBox
	Private txtProdT As DataDynamics.ActiveReports.TextBox
	Private txtStrTotal As DataDynamics.ActiveReports.TextBox
	Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptVendasSintetico))
            Me.Detail = New DataDynamics.ActiveReports.Detail
            Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader
            Me.ReportFooter = New DataDynamics.ActiveReports.ReportFooter
            Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
            Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
            Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader
            Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
            Me.lblTitulo = New DataDynamics.ActiveReports.Label
            Me.txtCodCliente = New DataDynamics.ActiveReports.TextBox
            Me.txtCliente = New DataDynamics.ActiveReports.TextBox
            Me.Label = New DataDynamics.ActiveReports.Label
            Me.Label1 = New DataDynamics.ActiveReports.Label
            Me.Label2 = New DataDynamics.ActiveReports.Label
            Me.Label3 = New DataDynamics.ActiveReports.Label
            Me.Label4 = New DataDynamics.ActiveReports.Label
            Me.txtOS = New DataDynamics.ActiveReports.TextBox
            Me.txtNPedido = New DataDynamics.ActiveReports.TextBox
            Me.txtProdutos = New DataDynamics.ActiveReports.TextBox
            Me.txtServicos = New DataDynamics.ActiveReports.TextBox
            Me.txtTotal = New DataDynamics.ActiveReports.TextBox
            Me.Line = New DataDynamics.ActiveReports.Line
            Me.txtSubProd = New DataDynamics.ActiveReports.TextBox
            Me.txtSubServ = New DataDynamics.ActiveReports.TextBox
            Me.txtSubTotal = New DataDynamics.ActiveReports.TextBox
            Me.txtstrSubTotal = New DataDynamics.ActiveReports.TextBox
            Me.Line1 = New DataDynamics.ActiveReports.Line
            Me.Line2 = New DataDynamics.ActiveReports.Line
            Me.lblPag = New DataDynamics.ActiveReports.Label
            Me.txtTT = New DataDynamics.ActiveReports.TextBox
            Me.txtServT = New DataDynamics.ActiveReports.TextBox
            Me.txtProdT = New DataDynamics.ActiveReports.TextBox
            Me.txtStrTotal = New DataDynamics.ActiveReports.TextBox
            CType(Me.lblTitulo,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtCodCliente,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtCliente,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label1,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label2,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label3,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label4,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtOS,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtNPedido,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtProdutos,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtServicos,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtTotal,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtSubProd,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtSubServ,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtSubTotal,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtstrSubTotal,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.lblPag,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtTT,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtServT,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtProdT,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtStrTotal,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
            '
            'Detail
            '
            Me.Detail.ColumnSpacing = 0!
            Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtOS, Me.txtNPedido, Me.txtProdutos, Me.txtServicos, Me.txtTotal, Me.Line})
            Me.Detail.Height = 0.2076389!
            Me.Detail.Name = "Detail"
            '
            'ReportHeader
            '
            Me.ReportHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblTitulo})
            Me.ReportHeader.Height = 0.3958333!
            Me.ReportHeader.Name = "ReportHeader"
            '
            'ReportFooter
            '
            Me.ReportFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtTT, Me.txtServT, Me.txtProdT, Me.txtStrTotal})
            Me.ReportFooter.Height = 0.25!
            Me.ReportFooter.Name = "ReportFooter"
            '
            'PageHeader
            '
            Me.PageHeader.Height = 0!
            Me.PageHeader.Name = "PageHeader"
            '
            'PageFooter
            '
            Me.PageFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblPag})
            Me.PageFooter.Height = 0.25!
            Me.PageFooter.Name = "PageFooter"
            '
            'GroupHeader1
            '
            Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtCodCliente, Me.txtCliente, Me.Label, Me.Label1, Me.Label2, Me.Label3, Me.Label4})
            Me.GroupHeader1.DataField = "cod_cliente"
            Me.GroupHeader1.Height = 0.4472222!
            Me.GroupHeader1.KeepTogether = true
            Me.GroupHeader1.Name = "GroupHeader1"
            '
            'GroupFooter1
            '
            Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtSubProd, Me.txtSubServ, Me.txtSubTotal, Me.txtstrSubTotal, Me.Line1, Me.Line2})
            Me.GroupFooter1.Height = 0.1979167!
            Me.GroupFooter1.Name = "GroupFooter1"
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
            Me.lblTitulo.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; "
            Me.lblTitulo.Text = "Label4"
            Me.lblTitulo.Top = 0!
            Me.lblTitulo.Width = 6.5!
            '
            'txtCodCliente
            '
            Me.txtCodCliente.Border.BottomColor = System.Drawing.Color.Black
            Me.txtCodCliente.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtCodCliente.Border.LeftColor = System.Drawing.Color.Black
            Me.txtCodCliente.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtCodCliente.Border.RightColor = System.Drawing.Color.Black
            Me.txtCodCliente.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtCodCliente.Border.TopColor = System.Drawing.Color.Black
            Me.txtCodCliente.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtCodCliente.DataField = "cod_cliente"
            Me.txtCodCliente.Height = 0.2!
            Me.txtCodCliente.Left = 0.1875!
            Me.txtCodCliente.Name = "txtCodCliente"
            Me.txtCodCliente.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
            Me.txtCodCliente.Text = "TextBox"
            Me.txtCodCliente.Top = 0!
            Me.txtCodCliente.Width = 0.625!
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
            Me.txtCliente.Left = 0.8541667!
            Me.txtCliente.Name = "txtCliente"
            Me.txtCliente.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; "
            Me.txtCliente.Text = "TextBox"
            Me.txtCliente.Top = 0!
            Me.txtCliente.Width = 2.3125!
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
            Me.Label.Left = 2.0625!
            Me.Label.Name = "Label"
            Me.Label.Style = ""
            Me.Label.Text = "Pedido"
            Me.Label.Top = 0.25!
            Me.Label.Width = 0.5625!
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
            Me.Label1.Left = 2.8125!
            Me.Label1.Name = "Label1"
            Me.Label1.Style = "text-align: right; "
            Me.Label1.Text = "Produtos"
            Me.Label1.Top = 0.25!
            Me.Label1.Width = 0.625!
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
            Me.Label2.Left = 3.5625!
            Me.Label2.Name = "Label2"
            Me.Label2.Style = "text-align: right; "
            Me.Label2.Text = "Serviços"
            Me.Label2.Top = 0.25!
            Me.Label2.Width = 0.6875!
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
            Me.Label3.Left = 4.4375!
            Me.Label3.Name = "Label3"
            Me.Label3.Style = "text-align: right; "
            Me.Label3.Text = "Total"
            Me.Label3.Top = 0.25!
            Me.Label3.Width = 0.5625!
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
            Me.Label4.Left = 5.125!
            Me.Label4.Name = "Label4"
            Me.Label4.Style = "text-align: left; "
            Me.Label4.Text = "OS"
            Me.Label4.Top = 0.25!
            Me.Label4.Width = 0.5625!
            '
            'txtOS
            '
            Me.txtOS.Border.BottomColor = System.Drawing.Color.Black
            Me.txtOS.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtOS.Border.LeftColor = System.Drawing.Color.Black
            Me.txtOS.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtOS.Border.RightColor = System.Drawing.Color.Black
            Me.txtOS.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtOS.Border.TopColor = System.Drawing.Color.Black
            Me.txtOS.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtOS.Height = 0.2!
            Me.txtOS.Left = 5.125!
            Me.txtOS.Name = "txtOS"
            Me.txtOS.OutputFormat = resources.GetString("txtOS.OutputFormat")
            Me.txtOS.Style = "text-align: left; "
            Me.txtOS.Text = "TextBox"
            Me.txtOS.Top = 0!
            Me.txtOS.Width = 0.625!
            '
            'txtNPedido
            '
            Me.txtNPedido.Border.BottomColor = System.Drawing.Color.Black
            Me.txtNPedido.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtNPedido.Border.LeftColor = System.Drawing.Color.Black
            Me.txtNPedido.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtNPedido.Border.RightColor = System.Drawing.Color.Black
            Me.txtNPedido.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtNPedido.Border.TopColor = System.Drawing.Color.Black
            Me.txtNPedido.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtNPedido.DataField = "num_pedido"
            Me.txtNPedido.Height = 0.2!
            Me.txtNPedido.Left = 2.072917!
            Me.txtNPedido.Name = "txtNPedido"
            Me.txtNPedido.Style = ""
            Me.txtNPedido.Text = "TextBox"
            Me.txtNPedido.Top = 0!
            Me.txtNPedido.Width = 0.625!
            '
            'txtProdutos
            '
            Me.txtProdutos.Border.BottomColor = System.Drawing.Color.Black
            Me.txtProdutos.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtProdutos.Border.LeftColor = System.Drawing.Color.Black
            Me.txtProdutos.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtProdutos.Border.RightColor = System.Drawing.Color.Black
            Me.txtProdutos.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtProdutos.Border.TopColor = System.Drawing.Color.Black
            Me.txtProdutos.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtProdutos.Height = 0.2!
            Me.txtProdutos.Left = 2.822917!
            Me.txtProdutos.Name = "txtProdutos"
            Me.txtProdutos.OutputFormat = resources.GetString("txtProdutos.OutputFormat")
            Me.txtProdutos.Style = "text-align: right; "
            Me.txtProdutos.Text = "TextBox"
            Me.txtProdutos.Top = 0!
            Me.txtProdutos.Width = 0.625!
            '
            'txtServicos
            '
            Me.txtServicos.Border.BottomColor = System.Drawing.Color.Black
            Me.txtServicos.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtServicos.Border.LeftColor = System.Drawing.Color.Black
            Me.txtServicos.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtServicos.Border.RightColor = System.Drawing.Color.Black
            Me.txtServicos.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtServicos.Border.TopColor = System.Drawing.Color.Black
            Me.txtServicos.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtServicos.Height = 0.2!
            Me.txtServicos.Left = 3.635417!
            Me.txtServicos.Name = "txtServicos"
            Me.txtServicos.OutputFormat = resources.GetString("txtServicos.OutputFormat")
            Me.txtServicos.Style = "text-align: right; "
            Me.txtServicos.Text = "TextBox"
            Me.txtServicos.Top = 0!
            Me.txtServicos.Width = 0.625!
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
            Me.txtTotal.Height = 0.2!
            Me.txtTotal.Left = 4.385417!
            Me.txtTotal.Name = "txtTotal"
            Me.txtTotal.OutputFormat = resources.GetString("txtTotal.OutputFormat")
            Me.txtTotal.Style = "text-align: right; "
            Me.txtTotal.Text = "TextBox"
            Me.txtTotal.Top = 0!
            Me.txtTotal.Width = 0.625!
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
            Me.Line.Left = 2.0625!
            Me.Line.LineStyle = DataDynamics.ActiveReports.LineStyle.DashDot
            Me.Line.LineWeight = 1!
            Me.Line.Name = "Line"
            Me.Line.Top = 0!
            Me.Line.Width = 3.75!
            Me.Line.X1 = 2.0625!
            Me.Line.X2 = 5.8125!
            Me.Line.Y1 = 0!
            Me.Line.Y2 = 0!
            '
            'txtSubProd
            '
            Me.txtSubProd.Border.BottomColor = System.Drawing.Color.Black
            Me.txtSubProd.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtSubProd.Border.LeftColor = System.Drawing.Color.Black
            Me.txtSubProd.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtSubProd.Border.RightColor = System.Drawing.Color.Black
            Me.txtSubProd.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtSubProd.Border.TopColor = System.Drawing.Color.Black
            Me.txtSubProd.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtSubProd.Height = 0.2!
            Me.txtSubProd.Left = 2.8125!
            Me.txtSubProd.Name = "txtSubProd"
            Me.txtSubProd.OutputFormat = resources.GetString("txtSubProd.OutputFormat")
            Me.txtSubProd.Style = "text-align: right; "
            Me.txtSubProd.Text = "TextBox"
            Me.txtSubProd.Top = 0.015625!
            Me.txtSubProd.Width = 0.625!
            '
            'txtSubServ
            '
            Me.txtSubServ.Border.BottomColor = System.Drawing.Color.Black
            Me.txtSubServ.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtSubServ.Border.LeftColor = System.Drawing.Color.Black
            Me.txtSubServ.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtSubServ.Border.RightColor = System.Drawing.Color.Black
            Me.txtSubServ.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtSubServ.Border.TopColor = System.Drawing.Color.Black
            Me.txtSubServ.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtSubServ.Height = 0.2!
            Me.txtSubServ.Left = 3.625!
            Me.txtSubServ.Name = "txtSubServ"
            Me.txtSubServ.OutputFormat = resources.GetString("txtSubServ.OutputFormat")
            Me.txtSubServ.Style = "text-align: right; "
            Me.txtSubServ.Text = "TextBox1"
            Me.txtSubServ.Top = 0.015625!
            Me.txtSubServ.Width = 0.625!
            '
            'txtSubTotal
            '
            Me.txtSubTotal.Border.BottomColor = System.Drawing.Color.Black
            Me.txtSubTotal.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtSubTotal.Border.LeftColor = System.Drawing.Color.Black
            Me.txtSubTotal.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtSubTotal.Border.RightColor = System.Drawing.Color.Black
            Me.txtSubTotal.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtSubTotal.Border.TopColor = System.Drawing.Color.Black
            Me.txtSubTotal.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtSubTotal.Height = 0.2!
            Me.txtSubTotal.Left = 4.375!
            Me.txtSubTotal.Name = "txtSubTotal"
            Me.txtSubTotal.OutputFormat = resources.GetString("txtSubTotal.OutputFormat")
            Me.txtSubTotal.Style = "text-align: right; "
            Me.txtSubTotal.Text = "TextBox"
            Me.txtSubTotal.Top = 0!
            Me.txtSubTotal.Width = 0.625!
            '
            'txtstrSubTotal
            '
            Me.txtstrSubTotal.Border.BottomColor = System.Drawing.Color.Black
            Me.txtstrSubTotal.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtstrSubTotal.Border.LeftColor = System.Drawing.Color.Black
            Me.txtstrSubTotal.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtstrSubTotal.Border.RightColor = System.Drawing.Color.Black
            Me.txtstrSubTotal.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtstrSubTotal.Border.TopColor = System.Drawing.Color.Black
            Me.txtstrSubTotal.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtstrSubTotal.Height = 0.2!
            Me.txtstrSubTotal.Left = 0!
            Me.txtstrSubTotal.Name = "txtstrSubTotal"
            Me.txtstrSubTotal.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-style: italic; font-s"& _ 
                "ize: 8pt; "
            Me.txtstrSubTotal.Text = "TextBox"
            Me.txtstrSubTotal.Top = 0!
            Me.txtstrSubTotal.Width = 2.625!
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
            Me.Line1.Left = 2.0625!
            Me.Line1.LineWeight = 1!
            Me.Line1.Name = "Line1"
            Me.Line1.Top = 0!
            Me.Line1.Width = 3!
            Me.Line1.X1 = 2.0625!
            Me.Line1.X2 = 5.0625!
            Me.Line1.Y1 = 0!
            Me.Line1.Y2 = 0!
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
            Me.Line2.Left = 0.0625!
            Me.Line2.LineWeight = 1!
            Me.Line2.Name = "Line2"
            Me.Line2.Top = 0.1875!
            Me.Line2.Width = 5!
            Me.Line2.X1 = 0.0625!
            Me.Line2.X2 = 5.0625!
            Me.Line2.Y1 = 0.1875!
            Me.Line2.Y2 = 0.1875!
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
            Me.lblPag.Left = 5.4375!
            Me.lblPag.Name = "lblPag"
            Me.lblPag.Style = ""
            Me.lblPag.Text = "Pedido"
            Me.lblPag.Top = 0.0625!
            Me.lblPag.Width = 1!
            '
            'txtTT
            '
            Me.txtTT.Border.BottomColor = System.Drawing.Color.Black
            Me.txtTT.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtTT.Border.LeftColor = System.Drawing.Color.Black
            Me.txtTT.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtTT.Border.RightColor = System.Drawing.Color.Black
            Me.txtTT.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtTT.Border.TopColor = System.Drawing.Color.Black
            Me.txtTT.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtTT.Height = 0.2!
            Me.txtTT.Left = 4.375!
            Me.txtTT.Name = "txtTT"
            Me.txtTT.OutputFormat = resources.GetString("txtTT.OutputFormat")
            Me.txtTT.Style = "text-align: right; "
            Me.txtTT.Text = "TextBox"
            Me.txtTT.Top = 0!
            Me.txtTT.Width = 0.625!
            '
            'txtServT
            '
            Me.txtServT.Border.BottomColor = System.Drawing.Color.Black
            Me.txtServT.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtServT.Border.LeftColor = System.Drawing.Color.Black
            Me.txtServT.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtServT.Border.RightColor = System.Drawing.Color.Black
            Me.txtServT.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtServT.Border.TopColor = System.Drawing.Color.Black
            Me.txtServT.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtServT.Height = 0.2!
            Me.txtServT.Left = 3.625!
            Me.txtServT.Name = "txtServT"
            Me.txtServT.OutputFormat = resources.GetString("txtServT.OutputFormat")
            Me.txtServT.Style = "text-align: right; "
            Me.txtServT.Text = "TextBox1"
            Me.txtServT.Top = 0.015625!
            Me.txtServT.Width = 0.625!
            '
            'txtProdT
            '
            Me.txtProdT.Border.BottomColor = System.Drawing.Color.Black
            Me.txtProdT.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtProdT.Border.LeftColor = System.Drawing.Color.Black
            Me.txtProdT.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtProdT.Border.RightColor = System.Drawing.Color.Black
            Me.txtProdT.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtProdT.Border.TopColor = System.Drawing.Color.Black
            Me.txtProdT.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtProdT.Height = 0.2!
            Me.txtProdT.Left = 2.8125!
            Me.txtProdT.Name = "txtProdT"
            Me.txtProdT.OutputFormat = resources.GetString("txtProdT.OutputFormat")
            Me.txtProdT.Style = "text-align: right; "
            Me.txtProdT.Text = "TextBox2"
            Me.txtProdT.Top = 0.015625!
            Me.txtProdT.Width = 0.625!
            '
            'txtStrTotal
            '
            Me.txtStrTotal.Border.BottomColor = System.Drawing.Color.Black
            Me.txtStrTotal.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtStrTotal.Border.LeftColor = System.Drawing.Color.Black
            Me.txtStrTotal.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtStrTotal.Border.RightColor = System.Drawing.Color.Black
            Me.txtStrTotal.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtStrTotal.Border.TopColor = System.Drawing.Color.Black
            Me.txtStrTotal.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtStrTotal.Height = 0.2!
            Me.txtStrTotal.Left = 0!
            Me.txtStrTotal.Name = "txtStrTotal"
            Me.txtStrTotal.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-style: italic; font-s"& _ 
                "ize: 8pt; "
            Me.txtStrTotal.Text = "TextBox"
            Me.txtStrTotal.Top = 0!
            Me.txtStrTotal.Width = 2.625!
            '
            'ActiveReport31
            '
            Me.MasterReport = false
            Me.PageSettings.PaperHeight = 11.69!
            Me.PageSettings.PaperWidth = 8.27!
            Me.Sections.Add(Me.ReportHeader)
            Me.Sections.Add(Me.PageHeader)
            Me.Sections.Add(Me.GroupHeader1)
            Me.Sections.Add(Me.Detail)
            Me.Sections.Add(Me.GroupFooter1)
            Me.Sections.Add(Me.PageFooter)
            Me.Sections.Add(Me.ReportFooter)
            Me.StyleSheet.Add(New DDCssLib.StyleSheetRule(resources.GetString("$this.StyleSheet"), "Normal"))
            Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo"& _ 
                        "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading1", "Normal"))
            Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei"& _ 
                        "ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading2", "Normal"))
            Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo"& _ 
                        "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading3", "Normal"))
            CType(Me.lblTitulo,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtCodCliente,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtCliente,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label1,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label2,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label3,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label4,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtOS,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtNPedido,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtProdutos,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtServicos,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtTotal,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtSubProd,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtSubServ,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtSubTotal,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtstrSubTotal,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.lblPag,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtTT,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtServT,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtProdT,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtStrTotal,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me,System.ComponentModel.ISupportInitialize).EndInit
        
	End Sub

#End Region
    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        Try
            r = cliente.pedido_cliente(txtCodCliente.Text, 1, txtNPedido.Text)
            txtProdutos.Text = Format(r("produtos"), "#,##0.00")
            tProdSub = tProdSub + txtProdutos.Text
            txtServicos.Text = Format(r("servicos"), "#,##0.00")
            tServSub = tServSub + txtServicos.Text
            txtTotal.Text = Format(r("total"), "#,##0.00")
            txtOS.Text = r("OS")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GroupHeader1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupHeader1.Format
        Try
            cliente.filtra_cod(txtCodCliente.Text)
            txtCliente.Text = cliente.nome_cliente
        Catch ex As Exception

        End Try
        

    End Sub
    Private Sub GroupFooter1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupFooter1.Format
        Try
            txtSubProd.Text = Format(tProdSub, "#,##0.00")
            txtSubServ.Text = Format(tServSub, "#,##0.00")
            txtSubTotal.Text = Format(tProdSub + tServSub, "#,##0.00")
            tProdG = tProdG + tProdSub
            tServG = tServG + tServSub
            txtstrSubTotal.Text = "Totais de " & txtCliente.Text
            tServSub = 0
            tProdSub = 0
        Catch ex As Exception

        End Try
        
    End Sub
    Private Sub PageFooter_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageFooter.Format
        lblPag.Text = "Página " & Me.PageNumber
    End Sub
    Private Sub ReportFooter_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportFooter.Format
        Try
            txtProdT.Text = Format(tProdG, "#,##0.00")
            txtServT.Text = Format(tServG, "#,##0.00")
            txtTT.Text = Format(tProdG + tServG, "#,##0.00")
            txtStrTotal.Text = "Totais do dia " & dia.Date
        Catch ex As Exception

        End Try
        
    End Sub
    Private Sub ReportHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportHeader.Format
        lblTitulo.Text = "Vendas do dia " & dia.Date
    End Sub
End Class
