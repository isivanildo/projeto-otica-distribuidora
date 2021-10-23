Imports System
Imports mrotica_util
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class rptListaEstoqueForncecedor
    Inherits DataDynamics.ActiveReports.ActiveReport3
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub
    Public titulo As String

#Region "ActiveReports Designer generated code"
    Private WithEvents ReportHeader As DataDynamics.ActiveReports.ReportHeader = Nothing
    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader = Nothing
    Private WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader = Nothing
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
    Private WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter = Nothing
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
    Private WithEvents ReportFooter As DataDynamics.ActiveReports.ReportFooter = Nothing
	Private lblTitulo As DataDynamics.ActiveReports.Label
	Private Label11 As DataDynamics.ActiveReports.Label
	Private Label3 As DataDynamics.ActiveReports.Label
	Private Label4 As DataDynamics.ActiveReports.Label
	Private Label5 As DataDynamics.ActiveReports.Label
	Private Label6 As DataDynamics.ActiveReports.Label
	Private Label7 As DataDynamics.ActiveReports.Label
	Private Label8 As DataDynamics.ActiveReports.Label
	Private Label9 As DataDynamics.ActiveReports.Label
	Private Label10 As DataDynamics.ActiveReports.Label
	Private Label12 As DataDynamics.ActiveReports.Label
	Private Label13 As DataDynamics.ActiveReports.Label
	Private Label19 As DataDynamics.ActiveReports.Label
	Private TextBox9 As DataDynamics.ActiveReports.TextBox
	Private TextBox8 As DataDynamics.ActiveReports.TextBox
	Private txtOD As DataDynamics.ActiveReports.TextBox
	Private txtOE As DataDynamics.ActiveReports.TextBox
	Private txtCodTabelaOD As DataDynamics.ActiveReports.TextBox
	Private Label As DataDynamics.ActiveReports.Label
	Private CheckBox As DataDynamics.ActiveReports.CheckBox
	Private CheckBox1 As DataDynamics.ActiveReports.CheckBox
	Private txtCodTabelaOE As DataDynamics.ActiveReports.TextBox
	Private Label1 As DataDynamics.ActiveReports.Label
	Private TextBox As DataDynamics.ActiveReports.TextBox
	Private TextBox1 As DataDynamics.ActiveReports.TextBox
	Private TextBox2 As DataDynamics.ActiveReports.TextBox
	Private TextBox3 As DataDynamics.ActiveReports.TextBox
	Private TextBox4 As DataDynamics.ActiveReports.TextBox
	Private TextBox5 As DataDynamics.ActiveReports.TextBox
	Private TextBox6 As DataDynamics.ActiveReports.TextBox
	Private TextBox7 As DataDynamics.ActiveReports.TextBox
	Private txtBaseOe As DataDynamics.ActiveReports.TextBox
	Private TXTbASEoD As DataDynamics.ActiveReports.TextBox
	Private txtAdicaoOE As DataDynamics.ActiveReports.TextBox
	Private txtAdicaoOd As DataDynamics.ActiveReports.TextBox
	Private txtCod As DataDynamics.ActiveReports.TextBox
	Private txtDoc As DataDynamics.ActiveReports.TextBox
	Private Line As DataDynamics.ActiveReports.Line
	Private txtCodOS As DataDynamics.ActiveReports.TextBox
	Private Barcode As DataDynamics.ActiveReports.Barcode
	Private chkPedOE As DataDynamics.ActiveReports.CheckBox
	Private txtPedido As DataDynamics.ActiveReports.TextBox
	Private TextBox10 As DataDynamics.ActiveReports.TextBox
	Private chkPedOD As DataDynamics.ActiveReports.CheckBox
	Private chkTrat As DataDynamics.ActiveReports.CheckBox
	Private txtTotalGrupo As DataDynamics.ActiveReports.TextBox
	Private txtTotalPedido As DataDynamics.ActiveReports.TextBox
	Private txtNaoPedido As DataDynamics.ActiveReports.TextBox
	Private Label2 As DataDynamics.ActiveReports.Label
	Private Label14 As DataDynamics.ActiveReports.Label
	Private Label15 As DataDynamics.ActiveReports.Label
	Private Line1 As DataDynamics.ActiveReports.Line
	Private lblPagina As DataDynamics.ActiveReports.Label
	Private txtSaldo As DataDynamics.ActiveReports.TextBox
	Private Label16 As DataDynamics.ActiveReports.Label
	Private txtPedidos As DataDynamics.ActiveReports.TextBox
	Private Label17 As DataDynamics.ActiveReports.Label
	Private txtTotal As DataDynamics.ActiveReports.TextBox
	Private Label18 As DataDynamics.ActiveReports.Label
	Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptListaEstoqueForncecedor))
            Me.Detail = New DataDynamics.ActiveReports.Detail
            Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader
            Me.ReportFooter = New DataDynamics.ActiveReports.ReportFooter
            Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
            Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
            Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader
            Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
            Me.lblTitulo = New DataDynamics.ActiveReports.Label
            Me.Label11 = New DataDynamics.ActiveReports.Label
            Me.Label3 = New DataDynamics.ActiveReports.Label
            Me.Label4 = New DataDynamics.ActiveReports.Label
            Me.Label5 = New DataDynamics.ActiveReports.Label
            Me.Label6 = New DataDynamics.ActiveReports.Label
            Me.Label7 = New DataDynamics.ActiveReports.Label
            Me.Label8 = New DataDynamics.ActiveReports.Label
            Me.Label9 = New DataDynamics.ActiveReports.Label
            Me.Label10 = New DataDynamics.ActiveReports.Label
            Me.Label12 = New DataDynamics.ActiveReports.Label
            Me.Label13 = New DataDynamics.ActiveReports.Label
            Me.Label19 = New DataDynamics.ActiveReports.Label
            Me.TextBox9 = New DataDynamics.ActiveReports.TextBox
            Me.TextBox8 = New DataDynamics.ActiveReports.TextBox
            Me.txtOD = New DataDynamics.ActiveReports.TextBox
            Me.txtOE = New DataDynamics.ActiveReports.TextBox
            Me.txtCodTabelaOD = New DataDynamics.ActiveReports.TextBox
            Me.Label = New DataDynamics.ActiveReports.Label
            Me.CheckBox = New DataDynamics.ActiveReports.CheckBox
            Me.CheckBox1 = New DataDynamics.ActiveReports.CheckBox
            Me.txtCodTabelaOE = New DataDynamics.ActiveReports.TextBox
            Me.Label1 = New DataDynamics.ActiveReports.Label
            Me.TextBox = New DataDynamics.ActiveReports.TextBox
            Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
            Me.TextBox2 = New DataDynamics.ActiveReports.TextBox
            Me.TextBox3 = New DataDynamics.ActiveReports.TextBox
            Me.TextBox4 = New DataDynamics.ActiveReports.TextBox
            Me.TextBox5 = New DataDynamics.ActiveReports.TextBox
            Me.TextBox6 = New DataDynamics.ActiveReports.TextBox
            Me.TextBox7 = New DataDynamics.ActiveReports.TextBox
            Me.txtBaseOe = New DataDynamics.ActiveReports.TextBox
            Me.TXTbASEoD = New DataDynamics.ActiveReports.TextBox
            Me.txtAdicaoOE = New DataDynamics.ActiveReports.TextBox
            Me.txtAdicaoOd = New DataDynamics.ActiveReports.TextBox
            Me.txtCod = New DataDynamics.ActiveReports.TextBox
            Me.txtDoc = New DataDynamics.ActiveReports.TextBox
            Me.Line = New DataDynamics.ActiveReports.Line
            Me.txtCodOS = New DataDynamics.ActiveReports.TextBox
            Me.Barcode = New DataDynamics.ActiveReports.Barcode
            Me.chkPedOE = New DataDynamics.ActiveReports.CheckBox
            Me.txtPedido = New DataDynamics.ActiveReports.TextBox
            Me.TextBox10 = New DataDynamics.ActiveReports.TextBox
            Me.chkPedOD = New DataDynamics.ActiveReports.CheckBox
            Me.chkTrat = New DataDynamics.ActiveReports.CheckBox
            Me.txtTotalGrupo = New DataDynamics.ActiveReports.TextBox
            Me.txtTotalPedido = New DataDynamics.ActiveReports.TextBox
            Me.txtNaoPedido = New DataDynamics.ActiveReports.TextBox
            Me.Label2 = New DataDynamics.ActiveReports.Label
            Me.Label14 = New DataDynamics.ActiveReports.Label
            Me.Label15 = New DataDynamics.ActiveReports.Label
            Me.Line1 = New DataDynamics.ActiveReports.Line
            Me.lblPagina = New DataDynamics.ActiveReports.Label
            Me.txtSaldo = New DataDynamics.ActiveReports.TextBox
            Me.Label16 = New DataDynamics.ActiveReports.Label
            Me.txtPedidos = New DataDynamics.ActiveReports.TextBox
            Me.Label17 = New DataDynamics.ActiveReports.Label
            Me.txtTotal = New DataDynamics.ActiveReports.TextBox
            Me.Label18 = New DataDynamics.ActiveReports.Label
            CType(Me.lblTitulo,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label11,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label3,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label4,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label5,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label6,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label7,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label8,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label9,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label10,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label12,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label13,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label19,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox9,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox8,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtOD,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtOE,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtCodTabelaOD,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.CheckBox,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.CheckBox1,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtCodTabelaOE,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label1,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox1,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox2,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox3,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox4,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox5,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox6,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox7,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtBaseOe,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TXTbASEoD,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtAdicaoOE,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtAdicaoOd,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtCod,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtDoc,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtCodOS,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.chkPedOE,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtPedido,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox10,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.chkPedOD,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.chkTrat,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtTotalGrupo,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtTotalPedido,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtNaoPedido,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label2,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label14,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label15,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.lblPagina,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtSaldo,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label16,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtPedidos,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label17,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtTotal,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label18,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
            '
            'Detail
            '
            Me.Detail.ColumnSpacing = 0!
            Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox8, Me.txtOD, Me.txtOE, Me.txtCodTabelaOD, Me.Label, Me.CheckBox, Me.CheckBox1, Me.txtCodTabelaOE, Me.Label1, Me.TextBox, Me.TextBox1, Me.TextBox2, Me.TextBox3, Me.TextBox4, Me.TextBox5, Me.TextBox6, Me.TextBox7, Me.txtBaseOe, Me.TXTbASEoD, Me.txtAdicaoOE, Me.txtAdicaoOd, Me.txtCod, Me.txtDoc, Me.Line, Me.txtCodOS, Me.Barcode, Me.chkPedOE, Me.txtPedido, Me.TextBox10, Me.chkPedOD, Me.chkTrat})
            Me.Detail.Height = 0.3375!
            Me.Detail.KeepTogether = true
            Me.Detail.Name = "Detail"
            '
            'ReportHeader
            '
            Me.ReportHeader.Height = 0!
            Me.ReportHeader.Name = "ReportHeader"
            '
            'ReportFooter
            '
            Me.ReportFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtSaldo, Me.Label16, Me.txtPedidos, Me.Label17, Me.txtTotal, Me.Label18})
            Me.ReportFooter.Height = 0.25!
            Me.ReportFooter.Name = "ReportFooter"
            '
            'PageHeader
            '
            Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblTitulo, Me.Label11, Me.Label3, Me.Label4, Me.Label5, Me.Label6, Me.Label7, Me.Label8, Me.Label9, Me.Label10, Me.Label12, Me.Label13, Me.Label19})
            Me.PageHeader.Height = 0.5194445!
            Me.PageHeader.Name = "PageHeader"
            '
            'PageFooter
            '
            Me.PageFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblPagina})
            Me.PageFooter.Height = 0.2!
            Me.PageFooter.Name = "PageFooter"
            '
            'GroupHeader1
            '
            Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox9})
            Me.GroupHeader1.DataField = "fabricante"
            Me.GroupHeader1.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
            Me.GroupHeader1.Height = 0.3222222!
            Me.GroupHeader1.Name = "GroupHeader1"
            '
            'GroupFooter1
            '
            Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtTotalGrupo, Me.txtTotalPedido, Me.txtNaoPedido, Me.Label2, Me.Label14, Me.Label15, Me.Line1})
            Me.GroupFooter1.Height = 0.21875!
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
            Me.lblTitulo.Left = 0.0625!
            Me.lblTitulo.Name = "lblTitulo"
            Me.lblTitulo.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; "
            Me.lblTitulo.Text = "OS's Pendentes"
            Me.lblTitulo.Top = 0!
            Me.lblTitulo.Width = 8.3125!
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
            Me.Label11.Height = 0.125!
            Me.Label11.HyperLink = Nothing
            Me.Label11.Left = 0!
            Me.Label11.Name = "Label11"
            Me.Label11.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; "
            Me.Label11.Text = "OS"
            Me.Label11.Top = 0.375!
            Me.Label11.Width = 0.6875!
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
            Me.Label3.Height = 0.125!
            Me.Label3.HyperLink = Nothing
            Me.Label3.Left = 8.25!
            Me.Label3.Name = "Label3"
            Me.Label3.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; "
            Me.Label3.Text = "Longe"
            Me.Label3.Top = 0.25!
            Me.Label3.Width = 0.6875!
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
            Me.Label4.Left = 8.25!
            Me.Label4.Name = "Label4"
            Me.Label4.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; "
            Me.Label4.Text = "Esf"
            Me.Label4.Top = 0.375!
            Me.Label4.Width = 0.25!
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
            Me.Label5.Left = 8.625!
            Me.Label5.Name = "Label5"
            Me.Label5.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; "
            Me.Label5.Text = "Cil"
            Me.Label5.Top = 0.375!
            Me.Label5.Width = 0.25!
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
            Me.Label6.Left = 9.125!
            Me.Label6.Name = "Label6"
            Me.Label6.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; "
            Me.Label6.Text = "Perto"
            Me.Label6.Top = 0.25!
            Me.Label6.Width = 0.6875!
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
            Me.Label7.Left = 9.125!
            Me.Label7.Name = "Label7"
            Me.Label7.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; "
            Me.Label7.Text = "Esf"
            Me.Label7.Top = 0.375!
            Me.Label7.Width = 0.25!
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
            Me.Label8.Height = 0.125!
            Me.Label8.HyperLink = Nothing
            Me.Label8.Left = 9.5!
            Me.Label8.Name = "Label8"
            Me.Label8.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; "
            Me.Label8.Text = "Cil"
            Me.Label8.Top = 0.375!
            Me.Label8.Width = 0.25!
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
            Me.Label9.Height = 0.125!
            Me.Label9.HyperLink = Nothing
            Me.Label9.Left = 9.8125!
            Me.Label9.Name = "Label9"
            Me.Label9.Style = "ddo-char-set: 1; text-align: right; font-weight: normal; font-size: 8pt; "
            Me.Label9.Text = "Base"
            Me.Label9.Top = 0.375!
            Me.Label9.Width = 0.375!
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
            Me.Label10.Left = 10.25!
            Me.Label10.Name = "Label10"
            Me.Label10.Style = "ddo-char-set: 1; text-align: right; font-weight: normal; font-size: 8pt; "
            Me.Label10.Text = "Adicao"
            Me.Label10.Top = 0.375!
            Me.Label10.Width = 0.375!
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
            Me.Label12.Height = 0.125!
            Me.Label12.HyperLink = Nothing
            Me.Label12.Left = 6.859375!
            Me.Label12.Name = "Label12"
            Me.Label12.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; "
            Me.Label12.Text = "Já Pedido"
            Me.Label12.Top = 0.375!
            Me.Label12.Width = 0.6875!
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
            Me.Label13.Height = 0.125!
            Me.Label13.HyperLink = Nothing
            Me.Label13.Left = 1.9375!
            Me.Label13.Name = "Label13"
            Me.Label13.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; "
            Me.Label13.Text = "Pedir"
            Me.Label13.Top = 0.375!
            Me.Label13.Width = 0.6875!
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
            Me.Label19.Height = 0.125!
            Me.Label19.HyperLink = Nothing
            Me.Label19.Left = 10.6875!
            Me.Label19.Name = "Label19"
            Me.Label19.Style = "ddo-char-set: 1; text-align: left; font-weight: normal; font-size: 8pt; "
            Me.Label19.Text = "Trat."
            Me.Label19.Top = 0.375!
            Me.Label19.Width = 0.375!
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
            Me.TextBox9.DataField = "Fabricante"
            Me.TextBox9.Height = 0.2!
            Me.TextBox9.Left = 0!
            Me.TextBox9.Name = "TextBox9"
            Me.TextBox9.Style = "ddo-char-set: 1; font-weight: bold; "
            Me.TextBox9.Text = "TextBox9"
            Me.TextBox9.Top = 0!
            Me.TextBox9.Width = 1.875!
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
            Me.TextBox8.DataField = "data_verificacao"
            Me.TextBox8.Height = 0.1375!
            Me.TextBox8.Left = 5.90625!
            Me.TextBox8.Name = "TextBox8"
            Me.TextBox8.OutputFormat = resources.GetString("TextBox8.OutputFormat")
            Me.TextBox8.Style = "ddo-char-set: 1; text-align: left; font-size: 8pt; "
            Me.TextBox8.Top = 0!
            Me.TextBox8.Width = 0.875!
            '
            'txtOD
            '
            Me.txtOD.Border.BottomColor = System.Drawing.Color.Black
            Me.txtOD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtOD.Border.LeftColor = System.Drawing.Color.Black
            Me.txtOD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtOD.Border.RightColor = System.Drawing.Color.Black
            Me.txtOD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtOD.Border.TopColor = System.Drawing.Color.Black
            Me.txtOD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtOD.DataField = "OD"
            Me.txtOD.Height = 0.1375!
            Me.txtOD.Left = 3.088542!
            Me.txtOD.Name = "txtOD"
            Me.txtOD.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
            Me.txtOD.Top = 0!
            Me.txtOD.Width = 2.739583!
            '
            'txtOE
            '
            Me.txtOE.Border.BottomColor = System.Drawing.Color.Black
            Me.txtOE.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtOE.Border.LeftColor = System.Drawing.Color.Black
            Me.txtOE.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtOE.Border.RightColor = System.Drawing.Color.Black
            Me.txtOE.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtOE.Border.TopColor = System.Drawing.Color.Black
            Me.txtOE.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtOE.DataField = "OE"
            Me.txtOE.Height = 0.1375!
            Me.txtOE.Left = 3.078125!
            Me.txtOE.Name = "txtOE"
            Me.txtOE.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
            Me.txtOE.Top = 0.15625!
            Me.txtOE.Width = 2.734375!
            '
            'txtCodTabelaOD
            '
            Me.txtCodTabelaOD.Border.BottomColor = System.Drawing.Color.Black
            Me.txtCodTabelaOD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtCodTabelaOD.Border.LeftColor = System.Drawing.Color.Black
            Me.txtCodTabelaOD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtCodTabelaOD.Border.RightColor = System.Drawing.Color.Black
            Me.txtCodTabelaOD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtCodTabelaOD.Border.TopColor = System.Drawing.Color.Black
            Me.txtCodTabelaOD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtCodTabelaOD.DataField = "cod_tab_od"
            Me.txtCodTabelaOD.Height = 0.1375!
            Me.txtCodTabelaOD.Left = 2.614583!
            Me.txtCodTabelaOD.Name = "txtCodTabelaOD"
            Me.txtCodTabelaOD.Style = "ddo-char-set: 1; font-size: 8pt; "
            Me.txtCodTabelaOD.Top = 0!
            Me.txtCodTabelaOD.Width = 0.4375!
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
            Me.Label.Height = 0.1375!
            Me.Label.HyperLink = Nothing
            Me.Label.Left = 2.375!
            Me.Label.Name = "Label"
            Me.Label.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; "
            Me.Label.Text = "OD:"
            Me.Label.Top = 0!
            Me.Label.Width = 0.3125!
            '
            'CheckBox
            '
            Me.CheckBox.Border.BottomColor = System.Drawing.Color.Black
            Me.CheckBox.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.CheckBox.Border.LeftColor = System.Drawing.Color.Black
            Me.CheckBox.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.CheckBox.Border.RightColor = System.Drawing.Color.Black
            Me.CheckBox.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.CheckBox.Border.TopColor = System.Drawing.Color.Black
            Me.CheckBox.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.CheckBox.Height = 0.125!
            Me.CheckBox.Left = 2.1875!
            Me.CheckBox.Name = "CheckBox"
            Me.CheckBox.Style = ""
            Me.CheckBox.Text = ""
            Me.CheckBox.Top = 0!
            Me.CheckBox.Width = 0.125!
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
            Me.CheckBox1.Height = 0.125!
            Me.CheckBox1.Left = 2.1875!
            Me.CheckBox1.Name = "CheckBox1"
            Me.CheckBox1.Style = ""
            Me.CheckBox1.Text = ""
            Me.CheckBox1.Top = 0.171875!
            Me.CheckBox1.Width = 0.125!
            '
            'txtCodTabelaOE
            '
            Me.txtCodTabelaOE.Border.BottomColor = System.Drawing.Color.Black
            Me.txtCodTabelaOE.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtCodTabelaOE.Border.LeftColor = System.Drawing.Color.Black
            Me.txtCodTabelaOE.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtCodTabelaOE.Border.RightColor = System.Drawing.Color.Black
            Me.txtCodTabelaOE.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtCodTabelaOE.Border.TopColor = System.Drawing.Color.Black
            Me.txtCodTabelaOE.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtCodTabelaOE.DataField = "cod_tab_oe"
            Me.txtCodTabelaOE.Height = 0.1375!
            Me.txtCodTabelaOE.Left = 2.625!
            Me.txtCodTabelaOE.Name = "txtCodTabelaOE"
            Me.txtCodTabelaOE.Style = "ddo-char-set: 1; font-size: 8pt; "
            Me.txtCodTabelaOE.Top = 0.15625!
            Me.txtCodTabelaOE.Width = 0.4375!
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
            Me.Label1.Height = 0.1375!
            Me.Label1.HyperLink = Nothing
            Me.Label1.Left = 2.375!
            Me.Label1.Name = "Label1"
            Me.Label1.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; "
            Me.Label1.Text = "OE:"
            Me.Label1.Top = 0.15625!
            Me.Label1.Width = 0.3125!
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
            Me.TextBox.DataField = "esf_oe_longe"
            Me.TextBox.Height = 0.1375!
            Me.TextBox.Left = 8.0625!
            Me.TextBox.Name = "TextBox"
            Me.TextBox.OutputFormat = resources.GetString("TextBox.OutputFormat")
            Me.TextBox.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
            Me.TextBox.Top = 0.15625!
            Me.TextBox.Width = 0.4270835!
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
            Me.TextBox1.DataField = "esf_od_longe"
            Me.TextBox1.Height = 0.1375!
            Me.TextBox1.Left = 8.0625!
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.OutputFormat = resources.GetString("TextBox1.OutputFormat")
            Me.TextBox1.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
            Me.TextBox1.Text = "TextBox1"
            Me.TextBox1.Top = 0!
            Me.TextBox1.Width = 0.4375!
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
            Me.TextBox2.DataField = "cil_oe_longe"
            Me.TextBox2.Height = 0.1375!
            Me.TextBox2.Left = 8.552083!
            Me.TextBox2.Name = "TextBox2"
            Me.TextBox2.OutputFormat = resources.GetString("TextBox2.OutputFormat")
            Me.TextBox2.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
            Me.TextBox2.Top = 0.15625!
            Me.TextBox2.Width = 0.3125!
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
            Me.TextBox3.DataField = "cil_od_longe"
            Me.TextBox3.Height = 0.1375!
            Me.TextBox3.Left = 8.552083!
            Me.TextBox3.Name = "TextBox3"
            Me.TextBox3.OutputFormat = resources.GetString("TextBox3.OutputFormat")
            Me.TextBox3.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
            Me.TextBox3.Text = "TextBox1"
            Me.TextBox3.Top = 0!
            Me.TextBox3.Width = 0.3125!
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
            Me.TextBox4.DataField = "esf_oe_perto"
            Me.TextBox4.Height = 0.1375!
            Me.TextBox4.Left = 8.989583!
            Me.TextBox4.Name = "TextBox4"
            Me.TextBox4.OutputFormat = resources.GetString("TextBox4.OutputFormat")
            Me.TextBox4.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
            Me.TextBox4.Top = 0.15625!
            Me.TextBox4.Width = 0.375!
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
            Me.TextBox5.DataField = "esf_od_perto"
            Me.TextBox5.Height = 0.1375!
            Me.TextBox5.Left = 8.989583!
            Me.TextBox5.Name = "TextBox5"
            Me.TextBox5.OutputFormat = resources.GetString("TextBox5.OutputFormat")
            Me.TextBox5.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
            Me.TextBox5.Text = "TextBox1"
            Me.TextBox5.Top = 0!
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
            Me.TextBox6.DataField = "cil_oe_perto"
            Me.TextBox6.Height = 0.1375!
            Me.TextBox6.Left = 9.416667!
            Me.TextBox6.Name = "TextBox6"
            Me.TextBox6.OutputFormat = resources.GetString("TextBox6.OutputFormat")
            Me.TextBox6.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
            Me.TextBox6.Text = "TextBox6"
            Me.TextBox6.Top = 0.15625!
            Me.TextBox6.Width = 0.3125!
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
            Me.TextBox7.DataField = "cil_od_perto"
            Me.TextBox7.Height = 0.1375!
            Me.TextBox7.Left = 9.416667!
            Me.TextBox7.Name = "TextBox7"
            Me.TextBox7.OutputFormat = resources.GetString("TextBox7.OutputFormat")
            Me.TextBox7.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
            Me.TextBox7.Text = "TextBox1"
            Me.TextBox7.Top = 0!
            Me.TextBox7.Width = 0.3125!
            '
            'txtBaseOe
            '
            Me.txtBaseOe.Border.BottomColor = System.Drawing.Color.Black
            Me.txtBaseOe.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtBaseOe.Border.LeftColor = System.Drawing.Color.Black
            Me.txtBaseOe.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtBaseOe.Border.RightColor = System.Drawing.Color.Black
            Me.txtBaseOe.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtBaseOe.Border.TopColor = System.Drawing.Color.Black
            Me.txtBaseOe.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtBaseOe.DataField = "base_oe"
            Me.txtBaseOe.Height = 0.1375!
            Me.txtBaseOe.Left = 9.864583!
            Me.txtBaseOe.Name = "txtBaseOe"
            Me.txtBaseOe.OutputFormat = resources.GetString("txtBaseOe.OutputFormat")
            Me.txtBaseOe.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
            Me.txtBaseOe.Top = 0.15625!
            Me.txtBaseOe.Width = 0.3125!
            '
            'TXTbASEoD
            '
            Me.TXTbASEoD.Border.BottomColor = System.Drawing.Color.Black
            Me.TXTbASEoD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.TXTbASEoD.Border.LeftColor = System.Drawing.Color.Black
            Me.TXTbASEoD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.TXTbASEoD.Border.RightColor = System.Drawing.Color.Black
            Me.TXTbASEoD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.TXTbASEoD.Border.TopColor = System.Drawing.Color.Black
            Me.TXTbASEoD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.TXTbASEoD.DataField = "base_od"
            Me.TXTbASEoD.Height = 0.1375!
            Me.TXTbASEoD.Left = 9.864583!
            Me.TXTbASEoD.Name = "TXTbASEoD"
            Me.TXTbASEoD.OutputFormat = resources.GetString("TXTbASEoD.OutputFormat")
            Me.TXTbASEoD.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
            Me.TXTbASEoD.Text = "TextBox1"
            Me.TXTbASEoD.Top = 0!
            Me.TXTbASEoD.Width = 0.3125!
            '
            'txtAdicaoOE
            '
            Me.txtAdicaoOE.Border.BottomColor = System.Drawing.Color.Black
            Me.txtAdicaoOE.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtAdicaoOE.Border.LeftColor = System.Drawing.Color.Black
            Me.txtAdicaoOE.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtAdicaoOE.Border.RightColor = System.Drawing.Color.Black
            Me.txtAdicaoOE.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtAdicaoOE.Border.TopColor = System.Drawing.Color.Black
            Me.txtAdicaoOE.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtAdicaoOE.DataField = "adicao_oe"
            Me.txtAdicaoOE.Height = 0.1375!
            Me.txtAdicaoOE.Left = 10.23958!
            Me.txtAdicaoOE.Name = "txtAdicaoOE"
            Me.txtAdicaoOE.OutputFormat = resources.GetString("txtAdicaoOE.OutputFormat")
            Me.txtAdicaoOE.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
            Me.txtAdicaoOE.Text = "TextBox6"
            Me.txtAdicaoOE.Top = 0.15625!
            Me.txtAdicaoOE.Width = 0.3125!
            '
            'txtAdicaoOd
            '
            Me.txtAdicaoOd.Border.BottomColor = System.Drawing.Color.Black
            Me.txtAdicaoOd.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtAdicaoOd.Border.LeftColor = System.Drawing.Color.Black
            Me.txtAdicaoOd.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtAdicaoOd.Border.RightColor = System.Drawing.Color.Black
            Me.txtAdicaoOd.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtAdicaoOd.Border.TopColor = System.Drawing.Color.Black
            Me.txtAdicaoOd.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtAdicaoOd.DataField = "adicao_od"
            Me.txtAdicaoOd.Height = 0.1375!
            Me.txtAdicaoOd.Left = 10.23958!
            Me.txtAdicaoOd.Name = "txtAdicaoOd"
            Me.txtAdicaoOd.OutputFormat = resources.GetString("txtAdicaoOd.OutputFormat")
            Me.txtAdicaoOd.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
            Me.txtAdicaoOd.Text = "TextBox1"
            Me.txtAdicaoOd.Top = 0!
            Me.txtAdicaoOd.Width = 0.3125!
            '
            'txtCod
            '
            Me.txtCod.Border.BottomColor = System.Drawing.Color.Black
            Me.txtCod.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtCod.Border.LeftColor = System.Drawing.Color.Black
            Me.txtCod.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtCod.Border.RightColor = System.Drawing.Color.Black
            Me.txtCod.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtCod.Border.TopColor = System.Drawing.Color.Black
            Me.txtCod.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtCod.DataField = "cod_cliente"
            Me.txtCod.Height = 0.1375!
            Me.txtCod.Left = 0!
            Me.txtCod.Name = "txtCod"
            Me.txtCod.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
            Me.txtCod.Top = 0!
            Me.txtCod.Width = 0.4375!
            '
            'txtDoc
            '
            Me.txtDoc.Border.BottomColor = System.Drawing.Color.Black
            Me.txtDoc.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtDoc.Border.LeftColor = System.Drawing.Color.Black
            Me.txtDoc.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtDoc.Border.RightColor = System.Drawing.Color.Black
            Me.txtDoc.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtDoc.Border.TopColor = System.Drawing.Color.Black
            Me.txtDoc.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtDoc.DataField = "doc_cliente"
            Me.txtDoc.Height = 0.1375!
            Me.txtDoc.Left = 0.5!
            Me.txtDoc.Name = "txtDoc"
            Me.txtDoc.Style = "ddo-char-set: 1; text-align: left; font-size: 8pt; "
            Me.txtDoc.Top = 0!
            Me.txtDoc.Width = 0.4375!
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
            Me.Line.Top = 0!
            Me.Line.Width = 10.9375!
            Me.Line.X1 = 0!
            Me.Line.X2 = 10.9375!
            Me.Line.Y1 = 0!
            Me.Line.Y2 = 0!
            '
            'txtCodOS
            '
            Me.txtCodOS.Border.BottomColor = System.Drawing.Color.Black
            Me.txtCodOS.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtCodOS.Border.LeftColor = System.Drawing.Color.Black
            Me.txtCodOS.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtCodOS.Border.RightColor = System.Drawing.Color.Black
            Me.txtCodOS.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtCodOS.Border.TopColor = System.Drawing.Color.Black
            Me.txtCodOS.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtCodOS.DataField = "cod_os"
            Me.txtCodOS.Height = 0.1375!
            Me.txtCodOS.Left = 0.5!
            Me.txtCodOS.Name = "txtCodOS"
            Me.txtCodOS.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
            Me.txtCodOS.Top = 0.125!
            Me.txtCodOS.Width = 0.4375!
            '
            'Barcode
            '
            Me.Barcode.Border.BottomColor = System.Drawing.Color.Black
            Me.Barcode.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.Barcode.Border.LeftColor = System.Drawing.Color.Black
            Me.Barcode.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.Barcode.Border.RightColor = System.Drawing.Color.Black
            Me.Barcode.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.Barcode.Border.TopColor = System.Drawing.Color.Black
            Me.Barcode.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.Barcode.DataField = "cod_os"
            Me.Barcode.Font = New System.Drawing.Font("Courier New", 8!)
            Me.Barcode.Height = 0.25!
            Me.Barcode.Left = 1!
            Me.Barcode.Name = "Barcode"
            Me.Barcode.Style = DataDynamics.ActiveReports.BarCodeStyle.Code_128_A
            Me.Barcode.Text = "Barcode"
            Me.Barcode.Top = 0.015625!
            Me.Barcode.Width = 1.0625!
            '
            'chkPedOE
            '
            Me.chkPedOE.Border.BottomColor = System.Drawing.Color.Black
            Me.chkPedOE.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.chkPedOE.Border.LeftColor = System.Drawing.Color.Black
            Me.chkPedOE.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.chkPedOE.Border.RightColor = System.Drawing.Color.Black
            Me.chkPedOE.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.chkPedOE.Border.TopColor = System.Drawing.Color.Black
            Me.chkPedOE.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.chkPedOE.Height = 0.125!
            Me.chkPedOE.Left = 6.921875!
            Me.chkPedOE.Name = "chkPedOE"
            Me.chkPedOE.Style = ""
            Me.chkPedOE.Text = ""
            Me.chkPedOE.Top = 0.15625!
            Me.chkPedOE.Width = 0.125!
            '
            'txtPedido
            '
            Me.txtPedido.Border.BottomColor = System.Drawing.Color.Black
            Me.txtPedido.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtPedido.Border.LeftColor = System.Drawing.Color.Black
            Me.txtPedido.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtPedido.Border.RightColor = System.Drawing.Color.Black
            Me.txtPedido.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtPedido.Border.TopColor = System.Drawing.Color.Black
            Me.txtPedido.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtPedido.DataField = "esf_oe_longe"
            Me.txtPedido.Height = 0.3125!
            Me.txtPedido.Left = 7.0625!
            Me.txtPedido.Name = "txtPedido"
            Me.txtPedido.OutputFormat = resources.GetString("txtPedido.OutputFormat")
            Me.txtPedido.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
            Me.txtPedido.Top = 0!
            Me.txtPedido.Width = 0.9375!
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
            Me.TextBox10.DataField = "data_importacao"
            Me.TextBox10.Height = 0.1375!
            Me.TextBox10.Left = 5.890625!
            Me.TextBox10.Name = "TextBox10"
            Me.TextBox10.OutputFormat = resources.GetString("TextBox10.OutputFormat")
            Me.TextBox10.Style = "ddo-char-set: 1; text-align: left; font-size: 8pt; "
            Me.TextBox10.Top = 0.15625!
            Me.TextBox10.Width = 0.9375!
            '
            'chkPedOD
            '
            Me.chkPedOD.Border.BottomColor = System.Drawing.Color.Black
            Me.chkPedOD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.chkPedOD.Border.LeftColor = System.Drawing.Color.Black
            Me.chkPedOD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.chkPedOD.Border.RightColor = System.Drawing.Color.Black
            Me.chkPedOD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.chkPedOD.Border.TopColor = System.Drawing.Color.Black
            Me.chkPedOD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.chkPedOD.Height = 0.125!
            Me.chkPedOD.Left = 6.932292!
            Me.chkPedOD.Name = "chkPedOD"
            Me.chkPedOD.Style = ""
            Me.chkPedOD.Text = ""
            Me.chkPedOD.Top = 0!
            Me.chkPedOD.Width = 0.125!
            '
            'chkTrat
            '
            Me.chkTrat.Border.BottomColor = System.Drawing.Color.Black
            Me.chkTrat.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.chkTrat.Border.LeftColor = System.Drawing.Color.Black
            Me.chkTrat.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.chkTrat.Border.RightColor = System.Drawing.Color.Black
            Me.chkTrat.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.chkTrat.Border.TopColor = System.Drawing.Color.Black
            Me.chkTrat.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.chkTrat.Height = 0.125!
            Me.chkTrat.Left = 10.75!
            Me.chkTrat.Name = "chkTrat"
            Me.chkTrat.Style = ""
            Me.chkTrat.Text = ""
            Me.chkTrat.Top = 0!
            Me.chkTrat.Width = 0.125!
            '
            'txtTotalGrupo
            '
            Me.txtTotalGrupo.Border.BottomColor = System.Drawing.Color.Black
            Me.txtTotalGrupo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtTotalGrupo.Border.LeftColor = System.Drawing.Color.Black
            Me.txtTotalGrupo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtTotalGrupo.Border.RightColor = System.Drawing.Color.Black
            Me.txtTotalGrupo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtTotalGrupo.Border.TopColor = System.Drawing.Color.Black
            Me.txtTotalGrupo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtTotalGrupo.Height = 0.2!
            Me.txtTotalGrupo.Left = 7.28125!
            Me.txtTotalGrupo.Name = "txtTotalGrupo"
            Me.txtTotalGrupo.Style = "text-align: left; "
            Me.txtTotalGrupo.Text = "TextBox10"
            Me.txtTotalGrupo.Top = 0!
            Me.txtTotalGrupo.Width = 0.40625!
            '
            'txtTotalPedido
            '
            Me.txtTotalPedido.Border.BottomColor = System.Drawing.Color.Black
            Me.txtTotalPedido.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtTotalPedido.Border.LeftColor = System.Drawing.Color.Black
            Me.txtTotalPedido.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtTotalPedido.Border.RightColor = System.Drawing.Color.Black
            Me.txtTotalPedido.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtTotalPedido.Border.TopColor = System.Drawing.Color.Black
            Me.txtTotalPedido.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtTotalPedido.Height = 0.2!
            Me.txtTotalPedido.Left = 9!
            Me.txtTotalPedido.Name = "txtTotalPedido"
            Me.txtTotalPedido.Style = ""
            Me.txtTotalPedido.Text = "TextBox10"
            Me.txtTotalPedido.Top = 0!
            Me.txtTotalPedido.Width = 0.4375!
            '
            'txtNaoPedido
            '
            Me.txtNaoPedido.Border.BottomColor = System.Drawing.Color.Black
            Me.txtNaoPedido.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtNaoPedido.Border.LeftColor = System.Drawing.Color.Black
            Me.txtNaoPedido.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtNaoPedido.Border.RightColor = System.Drawing.Color.Black
            Me.txtNaoPedido.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtNaoPedido.Border.TopColor = System.Drawing.Color.Black
            Me.txtNaoPedido.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtNaoPedido.Height = 0.2!
            Me.txtNaoPedido.Left = 10.375!
            Me.txtNaoPedido.Name = "txtNaoPedido"
            Me.txtNaoPedido.Style = ""
            Me.txtNaoPedido.Text = "TextBox10"
            Me.txtNaoPedido.Top = 0!
            Me.txtNaoPedido.Width = 0.4375!
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
            Me.Label2.Left = 6.239583!
            Me.Label2.Name = "Label2"
            Me.Label2.Style = "text-align: right; "
            Me.Label2.Text = "Total do Grupo:"
            Me.Label2.Top = 0!
            Me.Label2.Width = 1!
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
            Me.Label14.Height = 0.2!
            Me.Label14.HyperLink = Nothing
            Me.Label14.Left = 7.75!
            Me.Label14.Name = "Label14"
            Me.Label14.Style = "text-align: right; "
            Me.Label14.Text = "Pedidos do Grupo:"
            Me.Label14.Top = 0!
            Me.Label14.Width = 1.1875!
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
            Me.Label15.Height = 0.2!
            Me.Label15.HyperLink = Nothing
            Me.Label15.Left = 9.4375!
            Me.Label15.Name = "Label15"
            Me.Label15.Style = "text-align: right; "
            Me.Label15.Text = "Saldo Grupo:"
            Me.Label15.Top = 0!
            Me.Label15.Width = 0.875!
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
            Me.Line1.Left = 5.5!
            Me.Line1.LineWeight = 1!
            Me.Line1.Name = "Line1"
            Me.Line1.Top = 0!
            Me.Line1.Width = 5.4375!
            Me.Line1.X1 = 5.5!
            Me.Line1.X2 = 10.9375!
            Me.Line1.Y1 = 0!
            Me.Line1.Y2 = 0!
            '
            'lblPagina
            '
            Me.lblPagina.Border.BottomColor = System.Drawing.Color.Black
            Me.lblPagina.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.lblPagina.Border.LeftColor = System.Drawing.Color.Black
            Me.lblPagina.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.lblPagina.Border.RightColor = System.Drawing.Color.Black
            Me.lblPagina.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.lblPagina.Border.TopColor = System.Drawing.Color.Black
            Me.lblPagina.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.lblPagina.Height = 0.2!
            Me.lblPagina.HyperLink = Nothing
            Me.lblPagina.Left = 8.0625!
            Me.lblPagina.Name = "lblPagina"
            Me.lblPagina.Style = ""
            Me.lblPagina.Text = ""
            Me.lblPagina.Top = 0!
            Me.lblPagina.Width = 1!
            '
            'txtSaldo
            '
            Me.txtSaldo.Border.BottomColor = System.Drawing.Color.Black
            Me.txtSaldo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtSaldo.Border.LeftColor = System.Drawing.Color.Black
            Me.txtSaldo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtSaldo.Border.RightColor = System.Drawing.Color.Black
            Me.txtSaldo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtSaldo.Border.TopColor = System.Drawing.Color.Black
            Me.txtSaldo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtSaldo.Height = 0.2!
            Me.txtSaldo.Left = 10.38021!
            Me.txtSaldo.Name = "txtSaldo"
            Me.txtSaldo.Style = ""
            Me.txtSaldo.Text = "TextBox10"
            Me.txtSaldo.Top = 0!
            Me.txtSaldo.Width = 0.4375!
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
            Me.Label16.Height = 0.2!
            Me.Label16.HyperLink = Nothing
            Me.Label16.Left = 9.442708!
            Me.Label16.Name = "Label16"
            Me.Label16.Style = "text-align: right; "
            Me.Label16.Text = "Saldo:"
            Me.Label16.Top = 0!
            Me.Label16.Width = 0.875!
            '
            'txtPedidos
            '
            Me.txtPedidos.Border.BottomColor = System.Drawing.Color.Black
            Me.txtPedidos.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtPedidos.Border.LeftColor = System.Drawing.Color.Black
            Me.txtPedidos.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtPedidos.Border.RightColor = System.Drawing.Color.Black
            Me.txtPedidos.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtPedidos.Border.TopColor = System.Drawing.Color.Black
            Me.txtPedidos.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtPedidos.Height = 0.2!
            Me.txtPedidos.Left = 9.005208!
            Me.txtPedidos.Name = "txtPedidos"
            Me.txtPedidos.Style = ""
            Me.txtPedidos.Text = "TextBox11"
            Me.txtPedidos.Top = 0!
            Me.txtPedidos.Width = 0.4375!
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
            Me.Label17.Left = 7.755208!
            Me.Label17.Name = "Label17"
            Me.Label17.Style = "text-align: right; "
            Me.Label17.Text = "Já Pedidos:"
            Me.Label17.Top = 0!
            Me.Label17.Width = 1.1875!
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
            Me.txtTotal.Left = 7.286458!
            Me.txtTotal.Name = "txtTotal"
            Me.txtTotal.Style = "text-align: left; "
            Me.txtTotal.Text = "TextBox12"
            Me.txtTotal.Top = 0!
            Me.txtTotal.Width = 0.40625!
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
            Me.Label18.Height = 0.2!
            Me.Label18.HyperLink = Nothing
            Me.Label18.Left = 6.244792!
            Me.Label18.Name = "Label18"
            Me.Label18.Style = "text-align: right; "
            Me.Label18.Text = "Total da Lista:"
            Me.Label18.Top = 0!
            Me.Label18.Width = 1!
            '
            'ActiveReport31
            '
            Me.MasterReport = false
            Me.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape
            Me.PageSettings.PaperHeight = 11.69!
            Me.PageSettings.PaperWidth = 8.27!
            Me.PrintWidth = 10.95833!
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
            CType(Me.Label11,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label3,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label4,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label5,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label6,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label7,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label8,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label9,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label10,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label12,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label13,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label19,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox9,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox8,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtOD,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtOE,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtCodTabelaOD,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.CheckBox,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.CheckBox1,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtCodTabelaOE,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label1,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox1,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox2,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox3,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox4,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox5,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox6,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox7,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtBaseOe,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TXTbASEoD,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtAdicaoOE,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtAdicaoOd,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtCod,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtDoc,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtCodOS,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.chkPedOE,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtPedido,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox10,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.chkPedOD,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.chkTrat,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtTotalGrupo,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtTotalPedido,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtNaoPedido,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label2,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label14,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label15,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.lblPagina,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtSaldo,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label16,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtPedidos,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label17,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtTotal,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label18,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me,System.ComponentModel.ISupportInitialize).EndInit
        
	End Sub

#End Region
    Dim d As New dados
    Dim tt As New DataTable
    Dim conf As New config
    Dim grpPedido, grpTotal, Pedido, Total As Integer
    Dim os As ObjOS
    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        txtDoc.Text = adiciona_zeros(txtDoc.Text, 6)
        If CDbl(txtDoc.Text) = 0 Then txtDoc.Text = ""
        txtCod.Text = adiciona_zeros(txtCod.Text, 3)
        txtPedido.Text = os_pedido(txtCodOS.Text)
        os = New ObjOS(txtCodOS.Text, conf.Filial)
        Try
            chkPedOD.Checked = japedido(txtCodOS.Text, conf.Filial, "D")
            chkPedOE.Checked = japedido(txtCodOS.Text, conf.Filial, "E")
            If chkPedOD.Checked = True Or chkPedOE.Checked = True Then
                grpPedido = grpPedido + 1
            End If
            grpTotal = grpTotal + 1
            If CDbl(TXTbASEoD.Text) = 0 Then
                TXTbASEoD.Text = ""
            End If
            If CDbl(txtBaseOe.Text) = 0 Then
                txtBaseOe.Text = ""
            End If
            If CDbl(txtAdicaoOd.Text) = 0 Then
                txtAdicaoOd.Text = ""
            End If
            If CDbl(txtAdicaoOE.Text) = 0 Then
                txtAdicaoOE.Text = ""
            End If
            chkTrat.Checked = os.tem_tratamento
        Catch ex As Exception

        End Try
    End Sub
    Private Function japedido(ByVal cod_os As Integer, ByVal fil As Integer, ByVal olho As String) As Boolean
        Dim sql As String
        sql = "Select id from os_pedido where cod_os = " & cod_os & " and id_filial = " & fil & _
        " and olho = " & d.PStr(olho) & ""
        d.carrega_Tabela(sql, tt)
        If tt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub PageFooter_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageFooter.Format
        lblPagina.Text = Me.PageNumber
    End Sub
    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        lblTitulo.Text = "OS's Pendentes. Emissão: " & Now.ToString & ". " & titulo
    End Sub
    Private Function os_pedido(ByVal n_os As Integer) As String
        Dim sql As String
        Dim tt As New DataTable
        Dim i, t As Integer
        Dim strRes As String
        sql = "SELECT pedido_fornecedor.data_pedido, OS_pedido.cod_pedido, OS_pedido.cod_os " & _
        "FROM  OS_pedido INNER JOIN " & _
        "pedido_fornecedor ON OS_pedido.cod_pedido = pedido_fornecedor.cod_pedido " & _
        "WHERE (os_pedido.cod_os = " & n_os & ")"
        d.carrega_Tabela(sql, tt)

        i = 0
        t = tt.Rows.Count
        While i < t
            strRes = strRes & " " & tt.Rows(i)("cod_pedido") & "-" & tt.Rows(i)("data_pedido")
            i = i + 1
        End While
        Return strRes
    End Function
    Private Sub rptListaEstoqueForncecedor_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        grpPedido = 0
        grpTotal = 0
        Pedido = 0
        Total = 0
    End Sub

    Private Sub GroupFooter1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupFooter1.Format
        txtTotalGrupo.Text = grpTotal
        txtTotalPedido.Text = grpPedido
        txtNaoPedido.Text = grpTotal - grpPedido
        Total = Total + grpTotal
        Pedido = Pedido + grpPedido
        grpPedido = 0
        grpTotal = 0
    End Sub

    Private Sub ReportFooter_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportFooter.Format
        txtTotal.Text = Total
        txtPedidos.Text = Pedido
        txtSaldo.Text = Total - Pedido
    End Sub
End Class
