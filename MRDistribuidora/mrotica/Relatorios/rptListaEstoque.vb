Imports System
Imports mrotica_util
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class rptListaEstoque
    Inherits DataDynamics.ActiveReports.ActiveReport3
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub
    Dim fil, c_os As String
    Dim prod As New produtoClass
#Region "ActiveReports Designer generated code"
    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader = Nothing
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
	Private Label2 As DataDynamics.ActiveReports.Label
	Private Label6 As DataDynamics.ActiveReports.Label
	Private txtOSOtica As DataDynamics.ActiveReports.TextBox
	Private txtcodCliente As DataDynamics.ActiveReports.TextBox
	Private Label4 As DataDynamics.ActiveReports.Label
	Private txtCodProdOD As DataDynamics.ActiveReports.TextBox
	Private TextBox As DataDynamics.ActiveReports.TextBox
	Private txtIdFilial As DataDynamics.ActiveReports.TextBox
	Private txtCodOS As DataDynamics.ActiveReports.TextBox
	Private txtOs As DataDynamics.ActiveReports.TextBox
	Private txtOD As DataDynamics.ActiveReports.TextBox
	Private txtOE As DataDynamics.ActiveReports.TextBox
	Private Label As DataDynamics.ActiveReports.Label
	Private Label1 As DataDynamics.ActiveReports.Label
	Private Line As DataDynamics.ActiveReports.Line
	Private TextBox1 As DataDynamics.ActiveReports.TextBox
	Private txtFase As DataDynamics.ActiveReports.TextBox
	Private Label3 As DataDynamics.ActiveReports.Label
	Private txtcodProdOE As DataDynamics.ActiveReports.TextBox
	Private Label5 As DataDynamics.ActiveReports.Label
	Private txtCodTabelaOD As DataDynamics.ActiveReports.TextBox
	Private txtCodTabelaOE As DataDynamics.ActiveReports.TextBox
	Private txtDocCliente As DataDynamics.ActiveReports.TextBox
	Private CheckBox As DataDynamics.ActiveReports.CheckBox
	Private CheckBox1 As DataDynamics.ActiveReports.CheckBox
	Private Barcode As DataDynamics.ActiveReports.Barcode
	Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptListaEstoque))
            Me.Detail = New DataDynamics.ActiveReports.Detail
            Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
            Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
            Me.Label2 = New DataDynamics.ActiveReports.Label
            Me.Label6 = New DataDynamics.ActiveReports.Label
            Me.txtOSOtica = New DataDynamics.ActiveReports.TextBox
            Me.txtcodCliente = New DataDynamics.ActiveReports.TextBox
            Me.Label4 = New DataDynamics.ActiveReports.Label
            Me.txtCodProdOD = New DataDynamics.ActiveReports.TextBox
            Me.TextBox = New DataDynamics.ActiveReports.TextBox
            Me.txtIdFilial = New DataDynamics.ActiveReports.TextBox
            Me.txtCodOS = New DataDynamics.ActiveReports.TextBox
            Me.txtOs = New DataDynamics.ActiveReports.TextBox
            Me.txtOD = New DataDynamics.ActiveReports.TextBox
            Me.txtOE = New DataDynamics.ActiveReports.TextBox
            Me.Label = New DataDynamics.ActiveReports.Label
            Me.Label1 = New DataDynamics.ActiveReports.Label
            Me.Line = New DataDynamics.ActiveReports.Line
            Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
            Me.txtFase = New DataDynamics.ActiveReports.TextBox
            Me.Label3 = New DataDynamics.ActiveReports.Label
            Me.txtcodProdOE = New DataDynamics.ActiveReports.TextBox
            Me.Label5 = New DataDynamics.ActiveReports.Label
            Me.txtCodTabelaOD = New DataDynamics.ActiveReports.TextBox
            Me.txtCodTabelaOE = New DataDynamics.ActiveReports.TextBox
            Me.txtDocCliente = New DataDynamics.ActiveReports.TextBox
            Me.CheckBox = New DataDynamics.ActiveReports.CheckBox
            Me.CheckBox1 = New DataDynamics.ActiveReports.CheckBox
            Me.Barcode = New DataDynamics.ActiveReports.Barcode
            CType(Me.Label2,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label6,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtOSOtica,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtcodCliente,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label4,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtCodProdOD,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtIdFilial,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtCodOS,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtOs,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtOD,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtOE,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label1,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox1,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtFase,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label3,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtcodProdOE,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label5,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtCodTabelaOD,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtCodTabelaOE,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtDocCliente,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.CheckBox,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.CheckBox1,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
            '
            'Detail
            '
            Me.Detail.ColumnSpacing = 0!
            Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label6, Me.txtOSOtica, Me.txtcodCliente, Me.Label4, Me.txtCodProdOD, Me.TextBox, Me.txtIdFilial, Me.txtCodOS, Me.txtOs, Me.txtOD, Me.txtOE, Me.Label, Me.Label1, Me.Line, Me.TextBox1, Me.txtFase, Me.Label3, Me.txtcodProdOE, Me.Label5, Me.txtCodTabelaOD, Me.txtCodTabelaOE, Me.txtDocCliente, Me.CheckBox, Me.CheckBox1, Me.Barcode})
            Me.Detail.Height = 0.2708333!
            Me.Detail.Name = "Detail"
            '
            'PageHeader
            '
            Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label2})
            Me.PageHeader.Height = 0.2388889!
            Me.PageHeader.Name = "PageHeader"
            '
            'PageFooter
            '
            Me.PageFooter.Height = 0.02083333!
            Me.PageFooter.Name = "PageFooter"
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
            Me.Label2.Left = 0.0625!
            Me.Label2.Name = "Label2"
            Me.Label2.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; "
            Me.Label2.Text = "OS's Pendentes"
            Me.Label2.Top = 0!
            Me.Label2.Width = 7.4375!
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
            Me.Label6.Height = 0.1375!
            Me.Label6.HyperLink = Nothing
            Me.Label6.Left = 1.5!
            Me.Label6.Name = "Label6"
            Me.Label6.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; "
            Me.Label6.Text = "OS otica:"
            Me.Label6.Top = 0!
            Me.Label6.Width = 0.625!
            '
            'txtOSOtica
            '
            Me.txtOSOtica.Border.BottomColor = System.Drawing.Color.Black
            Me.txtOSOtica.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtOSOtica.Border.LeftColor = System.Drawing.Color.Black
            Me.txtOSOtica.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtOSOtica.Border.RightColor = System.Drawing.Color.Black
            Me.txtOSOtica.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtOSOtica.Border.TopColor = System.Drawing.Color.Black
            Me.txtOSOtica.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtOSOtica.Height = 0.1375!
            Me.txtOSOtica.Left = 1.5!
            Me.txtOSOtica.Name = "txtOSOtica"
            Me.txtOSOtica.Style = "ddo-char-set: 1; font-size: 8pt; "
            Me.txtOSOtica.Top = 0.125!
            Me.txtOSOtica.Width = 0.75!
            '
            'txtcodCliente
            '
            Me.txtcodCliente.Border.BottomColor = System.Drawing.Color.Black
            Me.txtcodCliente.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtcodCliente.Border.LeftColor = System.Drawing.Color.Black
            Me.txtcodCliente.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtcodCliente.Border.RightColor = System.Drawing.Color.Black
            Me.txtcodCliente.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtcodCliente.Border.TopColor = System.Drawing.Color.Black
            Me.txtcodCliente.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtcodCliente.DataField = "cod_cliente"
            Me.txtcodCliente.Height = 0.1375!
            Me.txtcodCliente.Left = 1.75!
            Me.txtcodCliente.Name = "txtcodCliente"
            Me.txtcodCliente.OutputFormat = resources.GetString("txtcodCliente.OutputFormat")
            Me.txtcodCliente.Style = "ddo-char-set: 1; text-align: left; font-size: 8pt; "
            Me.txtcodCliente.Top = 0.125!
            Me.txtcodCliente.Visible = false
            Me.txtcodCliente.Width = 0.25!
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
            Me.Label4.Height = 0.15!
            Me.Label4.HyperLink = Nothing
            Me.Label4.Left = 8.25!
            Me.Label4.Name = "Label4"
            Me.Label4.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; "
            Me.Label4.Text = "Cliente:"
            Me.Label4.Top = 0!
            Me.Label4.Width = 0.625!
            '
            'txtCodProdOD
            '
            Me.txtCodProdOD.Border.BottomColor = System.Drawing.Color.Black
            Me.txtCodProdOD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtCodProdOD.Border.LeftColor = System.Drawing.Color.Black
            Me.txtCodProdOD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtCodProdOD.Border.RightColor = System.Drawing.Color.Black
            Me.txtCodProdOD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtCodProdOD.Border.TopColor = System.Drawing.Color.Black
            Me.txtCodProdOD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtCodProdOD.DataField = "cod_produto_od"
            Me.txtCodProdOD.Height = 0.1375!
            Me.txtCodProdOD.Left = 3.177083!
            Me.txtCodProdOD.Name = "txtCodProdOD"
            Me.txtCodProdOD.Style = "ddo-char-set: 1; font-size: 8pt; "
            Me.txtCodProdOD.Top = 0!
            Me.txtCodProdOD.Width = 0.5625!
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
            Me.TextBox.CanGrow = false
            Me.TextBox.DataField = "nome_cliente"
            Me.TextBox.Height = 0.125!
            Me.TextBox.Left = 8.703125!
            Me.TextBox.Name = "TextBox"
            Me.TextBox.Style = "ddo-char-set: 1; font-size: 8pt; "
            Me.TextBox.Top = 0.0125!
            Me.TextBox.Width = 2.25!
            '
            'txtIdFilial
            '
            Me.txtIdFilial.Border.BottomColor = System.Drawing.Color.Black
            Me.txtIdFilial.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtIdFilial.Border.LeftColor = System.Drawing.Color.Black
            Me.txtIdFilial.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtIdFilial.Border.RightColor = System.Drawing.Color.Black
            Me.txtIdFilial.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtIdFilial.Border.TopColor = System.Drawing.Color.Black
            Me.txtIdFilial.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtIdFilial.DataField = "id_filial"
            Me.txtIdFilial.Height = 0.1875!
            Me.txtIdFilial.Left = 0!
            Me.txtIdFilial.Name = "txtIdFilial"
            Me.txtIdFilial.Style = "ddo-char-set: 1; font-size: 8pt; "
            Me.txtIdFilial.Top = 0!
            Me.txtIdFilial.Visible = false
            Me.txtIdFilial.Width = 0.4375!
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
            Me.txtCodOS.Height = 0.1875!
            Me.txtCodOS.Left = 0!
            Me.txtCodOS.Name = "txtCodOS"
            Me.txtCodOS.Style = "ddo-char-set: 1; font-size: 8pt; "
            Me.txtCodOS.Top = 0!
            Me.txtCodOS.Visible = false
            Me.txtCodOS.Width = 0.4375!
            '
            'txtOs
            '
            Me.txtOs.Border.BottomColor = System.Drawing.Color.Black
            Me.txtOs.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtOs.Border.LeftColor = System.Drawing.Color.Black
            Me.txtOs.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtOs.Border.RightColor = System.Drawing.Color.Black
            Me.txtOs.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtOs.Border.TopColor = System.Drawing.Color.Black
            Me.txtOs.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtOs.Height = 0.1375!
            Me.txtOs.Left = 0.25!
            Me.txtOs.Name = "txtOs"
            Me.txtOs.Style = "ddo-char-set: 1; font-size: 8pt; "
            Me.txtOs.Top = 0!
            Me.txtOs.Width = 0.75!
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
            Me.txtOD.Left = 3.739583!
            Me.txtOD.Name = "txtOD"
            Me.txtOD.Style = "ddo-char-set: 1; font-size: 8pt; "
            Me.txtOD.Top = 0!
            Me.txtOD.Width = 4.510417!
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
            Me.txtOE.Left = 3.75!
            Me.txtOE.Name = "txtOE"
            Me.txtOE.Style = "ddo-char-set: 1; font-size: 8pt; "
            Me.txtOE.Top = 0.125!
            Me.txtOE.Width = 4.5!
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
            Me.Label.Left = 2.4375!
            Me.Label.Name = "Label"
            Me.Label.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; "
            Me.Label.Text = "OD:"
            Me.Label.Top = 0!
            Me.Label.Width = 0.3125!
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
            Me.Label1.Left = 2.4375!
            Me.Label1.Name = "Label1"
            Me.Label1.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; "
            Me.Label1.Text = "OE:"
            Me.Label1.Top = 0.125!
            Me.Label1.Width = 0.3125!
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
            Me.Line.LineStyle = DataDynamics.ActiveReports.LineStyle.Dash
            Me.Line.LineWeight = 1!
            Me.Line.Name = "Line"
            Me.Line.Top = 0!
            Me.Line.Width = 10.9375!
            Me.Line.X1 = 0!
            Me.Line.X2 = 10.9375!
            Me.Line.Y1 = 0!
            Me.Line.Y2 = 0!
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
            Me.TextBox1.DataField = "data_verificacao"
            Me.TextBox1.Height = 0.1375!
            Me.TextBox1.Left = 0!
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.OutputFormat = resources.GetString("TextBox1.OutputFormat")
            Me.TextBox1.Style = "ddo-char-set: 1; text-align: left; font-size: 8pt; "
            Me.TextBox1.Top = 0.125!
            Me.TextBox1.Width = 0.75!
            '
            'txtFase
            '
            Me.txtFase.Border.BottomColor = System.Drawing.Color.Black
            Me.txtFase.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtFase.Border.LeftColor = System.Drawing.Color.Black
            Me.txtFase.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtFase.Border.RightColor = System.Drawing.Color.Black
            Me.txtFase.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtFase.Border.TopColor = System.Drawing.Color.Black
            Me.txtFase.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtFase.CanGrow = false
            Me.txtFase.DataField = "fase"
            Me.txtFase.Height = 0.125!
            Me.txtFase.Left = 8.703125!
            Me.txtFase.Name = "txtFase"
            Me.txtFase.Style = "ddo-char-set: 1; font-size: 8pt; "
            Me.txtFase.Top = 0.1625!
            Me.txtFase.Width = 2.25!
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
            Me.Label3.Height = 0.1375!
            Me.Label3.HyperLink = Nothing
            Me.Label3.Left = 0!
            Me.Label3.Name = "Label3"
            Me.Label3.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; "
            Me.Label3.Text = "OS:"
            Me.Label3.Top = 0!
            Me.Label3.Width = 0.3125!
            '
            'txtcodProdOE
            '
            Me.txtcodProdOE.Border.BottomColor = System.Drawing.Color.Black
            Me.txtcodProdOE.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtcodProdOE.Border.LeftColor = System.Drawing.Color.Black
            Me.txtcodProdOE.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtcodProdOE.Border.RightColor = System.Drawing.Color.Black
            Me.txtcodProdOE.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtcodProdOE.Border.TopColor = System.Drawing.Color.Black
            Me.txtcodProdOE.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtcodProdOE.DataField = "cod_produto_oe"
            Me.txtcodProdOE.Height = 0.1375!
            Me.txtcodProdOE.Left = 3.177083!
            Me.txtcodProdOE.Name = "txtcodProdOE"
            Me.txtcodProdOE.OutputFormat = resources.GetString("txtcodProdOE.OutputFormat")
            Me.txtcodProdOE.Style = "ddo-char-set: 1; font-size: 8pt; "
            Me.txtcodProdOE.Top = 0.15625!
            Me.txtcodProdOE.Width = 0.5625!
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
            Me.Label5.Height = 0.15!
            Me.Label5.HyperLink = Nothing
            Me.Label5.Left = 8.25!
            Me.Label5.Name = "Label5"
            Me.Label5.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; "
            Me.Label5.Text = "Status:"
            Me.Label5.Top = 0.15!
            Me.Label5.Width = 0.625!
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
            Me.txtCodTabelaOD.Height = 0.1375!
            Me.txtCodTabelaOD.Left = 2.677083!
            Me.txtCodTabelaOD.Name = "txtCodTabelaOD"
            Me.txtCodTabelaOD.Style = "ddo-char-set: 1; font-size: 8pt; "
            Me.txtCodTabelaOD.Top = 0!
            Me.txtCodTabelaOD.Width = 0.4375!
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
            Me.txtCodTabelaOE.Height = 0.1375!
            Me.txtCodTabelaOE.Left = 2.677083!
            Me.txtCodTabelaOE.Name = "txtCodTabelaOE"
            Me.txtCodTabelaOE.Style = "ddo-char-set: 1; font-size: 8pt; "
            Me.txtCodTabelaOE.Top = 0.1375!
            Me.txtCodTabelaOE.Width = 0.4375!
            '
            'txtDocCliente
            '
            Me.txtDocCliente.Border.BottomColor = System.Drawing.Color.Black
            Me.txtDocCliente.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtDocCliente.Border.LeftColor = System.Drawing.Color.Black
            Me.txtDocCliente.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtDocCliente.Border.RightColor = System.Drawing.Color.Black
            Me.txtDocCliente.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtDocCliente.Border.TopColor = System.Drawing.Color.Black
            Me.txtDocCliente.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtDocCliente.DataField = "doc_cliente"
            Me.txtDocCliente.Height = 0.1375!
            Me.txtDocCliente.Left = 1.875!
            Me.txtDocCliente.Name = "txtDocCliente"
            Me.txtDocCliente.OutputFormat = resources.GetString("txtDocCliente.OutputFormat")
            Me.txtDocCliente.Style = "ddo-char-set: 1; text-align: left; font-size: 8pt; "
            Me.txtDocCliente.Top = 0.125!
            Me.txtDocCliente.Visible = false
            Me.txtDocCliente.Width = 0.25!
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
            Me.CheckBox.Left = 2.25!
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
            Me.CheckBox1.Left = 2.25!
            Me.CheckBox1.Name = "CheckBox1"
            Me.CheckBox1.Style = ""
            Me.CheckBox1.Text = ""
            Me.CheckBox1.Top = 0.140625!
            Me.CheckBox1.Width = 0.125!
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
            Me.Barcode.Left = 1.015625!
            Me.Barcode.Name = "Barcode"
            Me.Barcode.Style = DataDynamics.ActiveReports.BarCodeStyle.Code_128_A
            Me.Barcode.Top = 0!
            Me.Barcode.Width = 0.4375!
            '
            'ActiveReport31
            '
            Me.MasterReport = false
            Me.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape
            Me.PageSettings.PaperHeight = 11.69!
            Me.PageSettings.PaperWidth = 8.27!
            Me.PrintWidth = 10.95833!
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
            CType(Me.Label2,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label6,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtOSOtica,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtcodCliente,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label4,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtCodProdOD,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtIdFilial,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtCodOS,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtOs,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtOD,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtOE,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label1,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox1,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtFase,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label3,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtcodProdOE,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label5,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtCodTabelaOD,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtCodTabelaOE,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtDocCliente,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.CheckBox,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.CheckBox1,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me,System.ComponentModel.ISupportInitialize).EndInit
        
	End Sub

#End Region
    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        txtOs.Text = adiciona_zeros(txtIdFilial.Text, 3) & adiciona_zeros(txtCodOS.Text, 6)
        If txtcodCliente.Text < 25 Then
            txtOSOtica.Text = adiciona_zeros(txtcodCliente.Text, 3) & adiciona_zeros(txtDocCliente.Text, 6)
        End If

        txtCodTabelaOD.Text = prod.Retorna_cod_Tabela(txtCodProdOD.Text)
        txtCodTabelaOE.Text = prod.Retorna_cod_Tabela(txtcodProdOE.Text)
    End Sub

    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format

    End Sub
End Class
