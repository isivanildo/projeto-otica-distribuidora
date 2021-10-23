Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports mrotica_util
Public Class rptItensPedidoEstoque
    Inherits DataDynamics.ActiveReports.ActiveReport3
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub
#Region "ActiveReports Designer generated code"
    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader = Nothing
    Private WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader = Nothing
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
    Private WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter = Nothing
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
    Private Label As DataDynamics.ActiveReports.Label
    Private Label1 As DataDynamics.ActiveReports.Label
    Private Label4 As DataDynamics.ActiveReports.Label
    Private TextBox As DataDynamics.ActiveReports.TextBox
    Private TextBox1 As DataDynamics.ActiveReports.TextBox
    Private TextBox3 As DataDynamics.ActiveReports.TextBox
    Private TextBox5 As DataDynamics.ActiveReports.TextBox
    Private Line As DataDynamics.ActiveReports.Line
    Private txtCod_tabela As DataDynamics.ActiveReports.TextBox
    Private Line1 As DataDynamics.ActiveReports.Line
    Private WithEvents lblData As DataDynamics.ActiveReports.Label
    Private WithEvents fldCliente As DataDynamics.ActiveReports.TextBox
    Private WithEvents fldVendedor As DataDynamics.ActiveReports.TextBox
    Private WithEvents fldPedido As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label2 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents ReportHeader1 As DataDynamics.ActiveReports.ReportHeader
    Friend WithEvents ReportFooter1 As DataDynamics.ActiveReports.ReportFooter
    Friend WithEvents Line2 As DataDynamics.ActiveReports.Line
    Friend WithEvents Label3 As DataDynamics.ActiveReports.Label
    Friend WithEvents Line3 As DataDynamics.ActiveReports.Line
    Friend WithEvents Label5 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label6 As DataDynamics.ActiveReports.Label
    Private WithEvents Line4 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line5 As DataDynamics.ActiveReports.Line
    Friend WithEvents Label7 As DataDynamics.ActiveReports.Label
    Private TextBox6 As DataDynamics.ActiveReports.TextBox
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptItensPedidoEstoque))
        Me.Detail = New DataDynamics.ActiveReports.Detail
        Me.TextBox = New DataDynamics.ActiveReports.TextBox
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox
        Me.Line = New DataDynamics.ActiveReports.Line
        Me.txtCod_tabela = New DataDynamics.ActiveReports.TextBox
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
        Me.lblData = New DataDynamics.ActiveReports.Label
        Me.fldCliente = New DataDynamics.ActiveReports.TextBox
        Me.fldVendedor = New DataDynamics.ActiveReports.TextBox
        Me.fldPedido = New DataDynamics.ActiveReports.TextBox
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader
        Me.Label = New DataDynamics.ActiveReports.Label
        Me.Label1 = New DataDynamics.ActiveReports.Label
        Me.Label4 = New DataDynamics.ActiveReports.Label
        Me.Label2 = New DataDynamics.ActiveReports.Label
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
        Me.Line1 = New DataDynamics.ActiveReports.Line
        Me.TextBox6 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox
        Me.ReportHeader1 = New DataDynamics.ActiveReports.ReportHeader
        Me.ReportFooter1 = New DataDynamics.ActiveReports.ReportFooter
        Me.Line2 = New DataDynamics.ActiveReports.Line
        Me.Label3 = New DataDynamics.ActiveReports.Label
        Me.Line3 = New DataDynamics.ActiveReports.Line
        Me.Label5 = New DataDynamics.ActiveReports.Label
        Me.Label6 = New DataDynamics.ActiveReports.Label
        Me.Line4 = New DataDynamics.ActiveReports.Line
        Me.Line5 = New DataDynamics.ActiveReports.Line
        Me.Label7 = New DataDynamics.ActiveReports.Label
        CType(Me.TextBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCod_tabela, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldVendedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox, Me.TextBox1, Me.TextBox3, Me.TextBox5, Me.Line, Me.txtCod_tabela, Me.TextBox2})
        Me.Detail.Height = 0.1979167!
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
        Me.TextBox.Height = 0.1875!
        Me.TextBox.Left = 0.0!
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Style = "ddo-char-set: 1; font-size: 10pt; "
        Me.TextBox.Text = "TextBox"
        Me.TextBox.Top = 0.0!
        Me.TextBox.Width = 0.3125!
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
        Me.TextBox1.DataField = "produto"
        Me.TextBox1.Height = 0.1875!
        Me.TextBox1.Left = 0.9375!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "ddo-char-set: 1; font-size: 10pt; "
        Me.TextBox1.Text = "TextBox"
        Me.TextBox1.Top = 0.0!
        Me.TextBox1.Width = 3.875!
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
        Me.TextBox3.DataField = "quant"
        Me.TextBox3.Height = 0.1875!
        Me.TextBox3.Left = 4.875!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "ddo-char-set: 1; text-align: right; font-size: 10pt; "
        Me.TextBox3.Text = "TextBox"
        Me.TextBox3.Top = 0.0!
        Me.TextBox3.Width = 0.375!
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
        Me.TextBox5.DataField = "atendido"
        Me.TextBox5.Height = 0.1875!
        Me.TextBox5.Left = 5.322917!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.OutputFormat = resources.GetString("TextBox5.OutputFormat")
        Me.TextBox5.Style = "ddo-char-set: 1; text-align: right; font-size: 10pt; "
        Me.TextBox5.Text = "TextBox"
        Me.TextBox5.Top = 0.0!
        Me.TextBox5.Width = 0.625!
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
        Me.Line.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line.LineWeight = 1.0!
        Me.Line.Name = "Line"
        Me.Line.Top = 0.0!
        Me.Line.Width = 7.1875!
        Me.Line.X1 = 0.0!
        Me.Line.X2 = 7.1875!
        Me.Line.Y1 = 0.0!
        Me.Line.Y2 = 0.0!
        '
        'txtCod_tabela
        '
        Me.txtCod_tabela.Border.BottomColor = System.Drawing.Color.Black
        Me.txtCod_tabela.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCod_tabela.Border.LeftColor = System.Drawing.Color.Black
        Me.txtCod_tabela.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCod_tabela.Border.RightColor = System.Drawing.Color.Black
        Me.txtCod_tabela.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCod_tabela.Border.TopColor = System.Drawing.Color.Black
        Me.txtCod_tabela.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCod_tabela.DataField = "cod_produto"
        Me.txtCod_tabela.Height = 0.1875!
        Me.txtCod_tabela.Left = 0.375!
        Me.txtCod_tabela.Name = "txtCod_tabela"
        Me.txtCod_tabela.Style = "ddo-char-set: 1; text-align: center; font-size: 10pt; "
        Me.txtCod_tabela.Text = "TextBox"
        Me.txtCod_tabela.Top = 0.0!
        Me.txtCod_tabela.Width = 0.5!
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
        Me.TextBox2.DataField = "status_item"
        Me.TextBox2.Height = 0.1875!
        Me.TextBox2.Left = 6.0!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.OutputFormat = resources.GetString("TextBox2.OutputFormat")
        Me.TextBox2.Style = "ddo-char-set: 1; text-align: left; font-size: 10pt; "
        Me.TextBox2.Text = "TextBox"
        Me.TextBox2.Top = 0.0!
        Me.TextBox2.Width = 1.25!
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblData, Me.fldCliente, Me.fldVendedor, Me.fldPedido})
        Me.PageHeader.Height = 0.4375!
        Me.PageHeader.Name = "PageHeader"
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
        Me.lblData.Height = 0.2!
        Me.lblData.HyperLink = Nothing
        Me.lblData.Left = 0.0!
        Me.lblData.Name = "lblData"
        Me.lblData.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; font-size: 10pt; font-famil" & _
            "y: Arial; "
        Me.lblData.Text = "Label1"
        Me.lblData.Top = 0.0!
        Me.lblData.Width = 2.1875!
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
        Me.fldCliente.Left = 2.25!
        Me.fldCliente.Name = "fldCliente"
        Me.fldCliente.Style = "ddo-char-set: 1; font-weight: bold; font-size: 10pt; font-family: Arial; "
        Me.fldCliente.Text = Nothing
        Me.fldCliente.Top = 0.0!
        Me.fldCliente.Width = 4.625!
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
        Me.fldVendedor.Left = 2.25!
        Me.fldVendedor.Name = "fldVendedor"
        Me.fldVendedor.Style = "ddo-char-set: 1; font-weight: bold; font-size: 10pt; font-family: Arial; "
        Me.fldVendedor.Text = Nothing
        Me.fldVendedor.Top = 0.25!
        Me.fldVendedor.Width = 2.375!
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
        Me.fldPedido.Left = 0.0!
        Me.fldPedido.Name = "fldPedido"
        Me.fldPedido.Style = "ddo-char-set: 1; font-weight: bold; font-size: 10pt; font-family: Arial; "
        Me.fldPedido.Text = Nothing
        Me.fldPedido.Top = 0.25!
        Me.fldPedido.Width = 2.125!
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label, Me.Label1, Me.Label4, Me.Label2})
        Me.GroupHeader1.Height = 0.1770833!
        Me.GroupHeader1.Name = "GroupHeader1"
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
        Me.Label.Left = 0.9375!
        Me.Label.Name = "Label"
        Me.Label.Style = "ddo-char-set: 1; font-size: 10pt; "
        Me.Label.Text = "Produto"
        Me.Label.Top = -0.03125!
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
        Me.Label1.Height = 0.1875!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 5.0625!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "ddo-char-set: 1; font-size: 10pt; "
        Me.Label1.Text = "Q."
        Me.Label1.Top = 0.0!
        Me.Label1.Width = 0.3125!
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
        Me.Label4.Left = 5.322917!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "ddo-char-set: 1; text-align: right; font-size: 10pt; "
        Me.Label4.Text = "Atendido"
        Me.Label4.Top = 0.0!
        Me.Label4.Width = 0.625!
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
        Me.Label2.Left = 6.0!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "ddo-char-set: 1; text-align: left; font-size: 10pt; "
        Me.Label2.Text = "Status"
        Me.Label2.Top = 0.0!
        Me.Label2.Width = 0.625!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Line1, Me.TextBox6, Me.TextBox4})
        Me.GroupFooter1.Height = 0.1875!
        Me.GroupFooter1.Name = "GroupFooter1"
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
        Me.Line1.Left = 0.0!
        Me.Line1.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.0!
        Me.Line1.Width = 7.1875!
        Me.Line1.X1 = 0.0!
        Me.Line1.X2 = 7.1875!
        Me.Line1.Y1 = 0.0!
        Me.Line1.Y2 = 0.0!
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
        Me.TextBox6.DataField = "quant"
        Me.TextBox6.Height = 0.1875!
        Me.TextBox6.Left = 4.875!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Style = "ddo-char-set: 1; text-align: right; font-size: 10pt; "
        Me.TextBox6.SummaryGroup = "GroupHeader1"
        Me.TextBox6.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox6.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox6.Text = "TextBox"
        Me.TextBox6.Top = 0.0!
        Me.TextBox6.Width = 0.375!
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
        Me.TextBox4.DataField = "atendido"
        Me.TextBox4.Height = 0.1875!
        Me.TextBox4.Left = 5.322917!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.OutputFormat = resources.GetString("TextBox4.OutputFormat")
        Me.TextBox4.Style = "ddo-char-set: 1; text-align: right; font-size: 10pt; "
        Me.TextBox4.SummaryGroup = "GroupHeader1"
        Me.TextBox4.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox4.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox4.Text = "TextBox"
        Me.TextBox4.Top = 0.0!
        Me.TextBox4.Width = 0.625!
        '
        'ReportHeader1
        '
        Me.ReportHeader1.Height = 0.01041667!
        Me.ReportHeader1.Name = "ReportHeader1"
        '
        'ReportFooter1
        '
        Me.ReportFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Line2, Me.Label3, Me.Line3, Me.Label5, Me.Label6, Me.Line4, Me.Line5, Me.Label7})
        Me.ReportFooter1.Height = 1.4375!
        Me.ReportFooter1.Name = "ReportFooter1"
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
        Me.Line2.Left = 0.5!
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0.875!
        Me.Line2.Width = 2.0!
        Me.Line2.X1 = 0.5!
        Me.Line2.X2 = 2.5!
        Me.Line2.Y1 = 0.875!
        Me.Line2.Y2 = 0.875!
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
        Me.Label3.Left = 0.6875!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "text-align: center; "
        Me.Label3.Text = "Responsável"
        Me.Label3.Top = 0.9375!
        Me.Label3.Width = 1.625!
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
        Me.Line3.Left = 2.75!
        Me.Line3.LineWeight = 1.0!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 0.875!
        Me.Line3.Width = 2.0!
        Me.Line3.X1 = 2.75!
        Me.Line3.X2 = 4.75!
        Me.Line3.Y1 = 0.875!
        Me.Line3.Y2 = 0.875!
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
        Me.Label5.Left = 2.9375!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "text-align: center; "
        Me.Label5.Text = "Conferente"
        Me.Label5.Top = 0.9375!
        Me.Label5.Width = 1.625!
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
        Me.Label6.Height = 0.25!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 0.125!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "text-align: center; "
        Me.Label6.Text = "Data Expedição: ____/____/______"
        Me.Label6.Top = 0.25!
        Me.Label6.Width = 2.5625!
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
        Me.Line4.Left = 0.0!
        Me.Line4.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line4.LineWeight = 1.0!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 0.0!
        Me.Line4.Width = 7.1875!
        Me.Line4.X1 = 0.0!
        Me.Line4.X2 = 7.1875!
        Me.Line4.Y1 = 0.0!
        Me.Line4.Y2 = 0.0!
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
        Me.Line5.Height = 0.0!
        Me.Line5.Left = 5.0625!
        Me.Line5.LineWeight = 1.0!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 0.875!
        Me.Line5.Width = 2.0!
        Me.Line5.X1 = 5.0625!
        Me.Line5.X2 = 7.0625!
        Me.Line5.Y1 = 0.875!
        Me.Line5.Y2 = 0.875!
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
        Me.Label7.Left = 5.25!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "text-align: center; "
        Me.Label7.Text = "Gerente"
        Me.Label7.Top = 0.9375!
        Me.Label7.Width = 1.625!
        '
        'rptItensPedidoEstoque
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.69!
        Me.PageSettings.PaperWidth = 8.27!
        Me.PrintWidth = 7.291667!
        Me.Sections.Add(Me.ReportHeader1)
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.PageFooter)
        Me.Sections.Add(Me.ReportFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule(resources.GetString("$this.StyleSheet"), "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" & _
                    "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei" & _
                    "ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" & _
                    "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading3", "Normal"))
        CType(Me.TextBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCod_tabela, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldVendedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldPedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region
    Dim PROD As New produtoClass
    Public n_pedido As String
    Public Vendedor As String
    Public cliente As String
    Public cod_cliente As String
    Public data As String

    Private Sub rptItensPedido_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
    End Sub

    Private Sub GroupHeader1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupHeader1.Format

    End Sub

    Private Sub GroupFooter1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupFooter1.Format

    End Sub


    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        txtCod_tabela.Text = PROD.Retorna_cod_Tabela(txtCod_tabela.Text)
    End Sub

    Private Sub PageHeader_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        fldPedido.Text = "Pedido: " & n_pedido

        fldVendedor.Text = "Vend.: " & Vendedor
        fldCliente.Text = "Cliente: " & cod_cliente & " " & cliente
        lblData.Text = "Belém, " & data
    End Sub
End Class
