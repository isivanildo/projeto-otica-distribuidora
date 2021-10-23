Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class rptListaPedido
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
	Private txtTitulo As DataDynamics.ActiveReports.Label
	Private Label6 As DataDynamics.ActiveReports.Label
	Private Label8 As DataDynamics.ActiveReports.Label
	Private Label9 As DataDynamics.ActiveReports.Label
	Private Label10 As DataDynamics.ActiveReports.Label
	Private Label11 As DataDynamics.ActiveReports.Label
	Private Label12 As DataDynamics.ActiveReports.Label
	Private Label13 As DataDynamics.ActiveReports.Label
	Private Label7 As DataDynamics.ActiveReports.Label
	Private Label As DataDynamics.ActiveReports.Label
	Private Line3 As DataDynamics.ActiveReports.Line
	Private Line4 As DataDynamics.ActiveReports.Line
	Private txtProd As DataDynamics.ActiveReports.TextBox
	Private fldBarra As DataDynamics.ActiveReports.TextBox
	Private TextBox2 As DataDynamics.ActiveReports.TextBox
	Private TextBox3 As DataDynamics.ActiveReports.TextBox
	Private TextBox4 As DataDynamics.ActiveReports.TextBox
	Private Line2 As DataDynamics.ActiveReports.Line
	Private TextBox6 As DataDynamics.ActiveReports.TextBox
	Private TextBox7 As DataDynamics.ActiveReports.TextBox
	Private Label1 As DataDynamics.ActiveReports.Label
	Private Line1 As DataDynamics.ActiveReports.Line
	Private lblPag As DataDynamics.ActiveReports.Label
	Private TextBox1 As DataDynamics.ActiveReports.TextBox
	Private TextBox5 As DataDynamics.ActiveReports.TextBox
	Private Label2 As DataDynamics.ActiveReports.Label
	Private Line As DataDynamics.ActiveReports.Line
	Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptListaPedido))
            Me.Detail = New DataDynamics.ActiveReports.Detail
            Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader
            Me.ReportFooter = New DataDynamics.ActiveReports.ReportFooter
            Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
            Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
            Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader
            Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
            Me.txtTitulo = New DataDynamics.ActiveReports.Label
            Me.Label6 = New DataDynamics.ActiveReports.Label
            Me.Label8 = New DataDynamics.ActiveReports.Label
            Me.Label9 = New DataDynamics.ActiveReports.Label
            Me.Label10 = New DataDynamics.ActiveReports.Label
            Me.Label11 = New DataDynamics.ActiveReports.Label
            Me.Label12 = New DataDynamics.ActiveReports.Label
            Me.Label13 = New DataDynamics.ActiveReports.Label
            Me.Label7 = New DataDynamics.ActiveReports.Label
            Me.Label = New DataDynamics.ActiveReports.Label
            Me.Line3 = New DataDynamics.ActiveReports.Line
            Me.Line4 = New DataDynamics.ActiveReports.Line
            Me.txtProd = New DataDynamics.ActiveReports.TextBox
            Me.fldBarra = New DataDynamics.ActiveReports.TextBox
            Me.TextBox2 = New DataDynamics.ActiveReports.TextBox
            Me.TextBox3 = New DataDynamics.ActiveReports.TextBox
            Me.TextBox4 = New DataDynamics.ActiveReports.TextBox
            Me.Line2 = New DataDynamics.ActiveReports.Line
            Me.TextBox6 = New DataDynamics.ActiveReports.TextBox
            Me.TextBox7 = New DataDynamics.ActiveReports.TextBox
            Me.Label1 = New DataDynamics.ActiveReports.Label
            Me.Line1 = New DataDynamics.ActiveReports.Line
            Me.lblPag = New DataDynamics.ActiveReports.Label
            Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
            Me.TextBox5 = New DataDynamics.ActiveReports.TextBox
            Me.Label2 = New DataDynamics.ActiveReports.Label
            Me.Line = New DataDynamics.ActiveReports.Line
            CType(Me.txtTitulo,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label6,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label8,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label9,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label10,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label11,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label12,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label13,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label7,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtProd,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.fldBarra,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox2,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox3,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox4,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox6,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox7,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label1,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.lblPag,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox1,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox5,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label2,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
            '
            'Detail
            '
            Me.Detail.ColumnSpacing = 0!
            Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtProd, Me.fldBarra, Me.TextBox2, Me.TextBox3, Me.TextBox4, Me.Line2})
            Me.Detail.Height = 0.2076389!
            Me.Detail.Name = "Detail"
            '
            'ReportHeader
            '
            Me.ReportHeader.Height = 0!
            Me.ReportHeader.Name = "ReportHeader"
            '
            'ReportFooter
            '
            Me.ReportFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox1, Me.TextBox5, Me.Label2, Me.Line})
            Me.ReportFooter.Height = 0.2388889!
            Me.ReportFooter.Name = "ReportFooter"
            '
            'PageHeader
            '
            Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtTitulo})
            Me.PageHeader.Height = 0.2291667!
            Me.PageHeader.Name = "PageHeader"
            '
            'PageFooter
            '
            Me.PageFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblPag})
            Me.PageFooter.Height = 0.2!
            Me.PageFooter.Name = "PageFooter"
            '
            'GroupHeader1
            '
            Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label6, Me.Label8, Me.Label9, Me.Label10, Me.Label11, Me.Label12, Me.Label13, Me.Label7, Me.Label, Me.Line3, Me.Line4})
            Me.GroupHeader1.DataField = "cod_tabela"
            Me.GroupHeader1.Height = 0.5104167!
            Me.GroupHeader1.Name = "GroupHeader1"
            '
            'GroupFooter1
            '
            Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox6, Me.TextBox7, Me.Label1, Me.Line1})
            Me.GroupFooter1.Height = 0.1763889!
            Me.GroupFooter1.Name = "GroupFooter1"
            '
            'txtTitulo
            '
            Me.txtTitulo.Border.BottomColor = System.Drawing.Color.Black
            Me.txtTitulo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtTitulo.Border.LeftColor = System.Drawing.Color.Black
            Me.txtTitulo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtTitulo.Border.RightColor = System.Drawing.Color.Black
            Me.txtTitulo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtTitulo.Border.TopColor = System.Drawing.Color.Black
            Me.txtTitulo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtTitulo.Height = 0.375!
            Me.txtTitulo.HyperLink = Nothing
            Me.txtTitulo.Left = 0!
            Me.txtTitulo.Name = "txtTitulo"
            Me.txtTitulo.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; font-fami"& _ 
                "ly: Tahoma; "
            Me.txtTitulo.Text = "Tabela"
            Me.txtTitulo.Top = 0!
            Me.txtTitulo.Width = 7.25!
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
            Me.Label6.Left = 0.625!
            Me.Label6.Name = "Label6"
            Me.Label6.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; font-family: Tahoma; "
            Me.Label6.Text = "Descrição"
            Me.Label6.Top = 0.34375!
            Me.Label6.Width = 1.1875!
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
            Me.Label8.Height = 0.2!
            Me.Label8.HyperLink = Nothing
            Me.Label8.Left = 4.625!
            Me.Label8.Name = "Label8"
            Me.Label8.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; font-family: Tahoma; "
            Me.Label8.Text = "C. Barras"
            Me.Label8.Top = 0.34375!
            Me.Label8.Width = 0.6875!
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
            Me.Label9.Height = 0.2!
            Me.Label9.HyperLink = Nothing
            Me.Label9.Left = 5.375!
            Me.Label9.Name = "Label9"
            Me.Label9.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; font-family: Tahoma; "
            Me.Label9.Text = "Quant."
            Me.Label9.Top = 0.34375!
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
            Me.Label10.Height = 0.2!
            Me.Label10.HyperLink = Nothing
            Me.Label10.Left = 5.875!
            Me.Label10.Name = "Label10"
            Me.Label10.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; font-famil"& _ 
                "y: Tahoma; "
            Me.Label10.Text = "P. Unit."
            Me.Label10.Top = 0.34375!
            Me.Label10.Width = 0.5625!
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
            Me.Label11.Height = 0.2!
            Me.Label11.HyperLink = Nothing
            Me.Label11.Left = 6.6875!
            Me.Label11.Name = "Label11"
            Me.Label11.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; font-famil"& _ 
                "y: Tahoma; "
            Me.Label11.Text = "Total"
            Me.Label11.Top = 0.34375!
            Me.Label11.Width = 0.5625!
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
            Me.Label12.DataField = "cod_tabela"
            Me.Label12.Height = 0.2!
            Me.Label12.HyperLink = Nothing
            Me.Label12.Left = 0!
            Me.Label12.Name = "Label12"
            Me.Label12.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; font-family: Tahoma; "
            Me.Label12.Text = "Produto"
            Me.Label12.Top = 0.15625!
            Me.Label12.Width = 0.5625!
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
            Me.Label13.DataField = "Nome_Comercial"
            Me.Label13.Height = 0.2!
            Me.Label13.HyperLink = Nothing
            Me.Label13.Left = 0.625!
            Me.Label13.Name = "Label13"
            Me.Label13.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; font-family: Tahoma; "
            Me.Label13.Text = "Produto"
            Me.Label13.Top = 0.15625!
            Me.Label13.Width = 3.375!
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
            Me.Label7.Height = 0.2!
            Me.Label7.HyperLink = Nothing
            Me.Label7.Left = 0!
            Me.Label7.Name = "Label7"
            Me.Label7.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; font-family: Tahoma; "
            Me.Label7.Text = "Tabela"
            Me.Label7.Top = -0.03125!
            Me.Label7.Width = 0.5!
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
            Me.Label.Left = 0.625!
            Me.Label.Name = "Label"
            Me.Label.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; font-family: Tahoma; "
            Me.Label.Text = "Produto"
            Me.Label.Top = -0.03125!
            Me.Label.Width = 1.1875!
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
            Me.Line3.Height = 0!
            Me.Line3.Left = 0!
            Me.Line3.LineWeight = 1!
            Me.Line3.Name = "Line3"
            Me.Line3.Top = 0.34375!
            Me.Line3.Width = 7.3125!
            Me.Line3.X1 = 0!
            Me.Line3.X2 = 7.3125!
            Me.Line3.Y1 = 0.34375!
            Me.Line3.Y2 = 0.34375!
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
            Me.Line4.Height = 0!
            Me.Line4.Left = 0!
            Me.Line4.LineWeight = 1!
            Me.Line4.Name = "Line4"
            Me.Line4.Top = 0!
            Me.Line4.Width = 7.3125!
            Me.Line4.X1 = 0!
            Me.Line4.X2 = 7.3125!
            Me.Line4.Y1 = 0!
            Me.Line4.Y2 = 0!
            '
            'txtProd
            '
            Me.txtProd.Border.BottomColor = System.Drawing.Color.Black
            Me.txtProd.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtProd.Border.LeftColor = System.Drawing.Color.Black
            Me.txtProd.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtProd.Border.RightColor = System.Drawing.Color.Black
            Me.txtProd.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtProd.Border.TopColor = System.Drawing.Color.Black
            Me.txtProd.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtProd.DataField = "Produto"
            Me.txtProd.Height = 0.1875!
            Me.txtProd.Left = 0.625!
            Me.txtProd.Name = "txtProd"
            Me.txtProd.Style = "ddo-char-set: 1; font-size: 8pt; font-family: Tahoma; "
            Me.txtProd.Text = "TextBox"
            Me.txtProd.Top = 0!
            Me.txtProd.Width = 3.9375!
            '
            'fldBarra
            '
            Me.fldBarra.Border.BottomColor = System.Drawing.Color.Black
            Me.fldBarra.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.fldBarra.Border.LeftColor = System.Drawing.Color.Black
            Me.fldBarra.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.fldBarra.Border.RightColor = System.Drawing.Color.Black
            Me.fldBarra.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.fldBarra.Border.TopColor = System.Drawing.Color.Black
            Me.fldBarra.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.fldBarra.DataField = "cod_barra"
            Me.fldBarra.Height = 0.1875!
            Me.fldBarra.Left = 4.625!
            Me.fldBarra.Name = "fldBarra"
            Me.fldBarra.Style = "ddo-char-set: 1; font-size: 8pt; font-family: Tahoma; "
            Me.fldBarra.Text = "TextBox"
            Me.fldBarra.Top = 0!
            Me.fldBarra.Width = 0.6875!
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
            Me.TextBox2.DataField = "quant"
            Me.TextBox2.Height = 0.1875!
            Me.TextBox2.Left = 5.375!
            Me.TextBox2.Name = "TextBox2"
            Me.TextBox2.Style = "ddo-char-set: 1; text-align: center; font-size: 8pt; font-family: Tahoma; "
            Me.TextBox2.Text = "TextBox"
            Me.TextBox2.Top = 0!
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
            Me.TextBox3.DataField = "Preco"
            Me.TextBox3.Height = 0.1875!
            Me.TextBox3.Left = 5.8125!
            Me.TextBox3.Name = "TextBox3"
            Me.TextBox3.OutputFormat = resources.GetString("TextBox3.OutputFormat")
            Me.TextBox3.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; font-family: Tahoma; "
            Me.TextBox3.Text = "TextBox"
            Me.TextBox3.Top = 0!
            Me.TextBox3.Width = 0.625!
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
            Me.TextBox4.Height = 0.1875!
            Me.TextBox4.Left = 6.5625!
            Me.TextBox4.Name = "TextBox4"
            Me.TextBox4.OutputFormat = resources.GetString("TextBox4.OutputFormat")
            Me.TextBox4.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; font-family: Tahoma; "
            Me.TextBox4.Text = "TextBox"
            Me.TextBox4.Top = 0!
            Me.TextBox4.Width = 0.6875!
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
            Me.Line2.Left = 0.625!
            Me.Line2.LineStyle = DataDynamics.ActiveReports.LineStyle.Dash
            Me.Line2.LineWeight = 1!
            Me.Line2.Name = "Line2"
            Me.Line2.Top = 0!
            Me.Line2.Width = 6.6875!
            Me.Line2.X1 = 0.625!
            Me.Line2.X2 = 7.3125!
            Me.Line2.Y1 = 0!
            Me.Line2.Y2 = 0!
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
            Me.TextBox6.Left = 5.375!
            Me.TextBox6.Name = "TextBox6"
            Me.TextBox6.Style = "ddo-char-set: 1; text-align: center; font-size: 8pt; font-family: Tahoma; "
            Me.TextBox6.SummaryGroup = "GroupHeader1"
            Me.TextBox6.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
            Me.TextBox6.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
            Me.TextBox6.Text = "TextBox"
            Me.TextBox6.Top = 0!
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
            Me.TextBox7.DataField = "Total"
            Me.TextBox7.Height = 0.1875!
            Me.TextBox7.Left = 6.5625!
            Me.TextBox7.Name = "TextBox7"
            Me.TextBox7.OutputFormat = resources.GetString("TextBox7.OutputFormat")
            Me.TextBox7.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; font-family: Tahoma; "
            Me.TextBox7.SummaryGroup = "GroupHeader1"
            Me.TextBox7.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
            Me.TextBox7.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
            Me.TextBox7.Text = "TextBox"
            Me.TextBox7.Top = 0!
            Me.TextBox7.Width = 0.6875!
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
            Me.Label1.Left = 2.875!
            Me.Label1.Name = "Label1"
            Me.Label1.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; font-famil"& _ 
                "y: Tahoma; "
            Me.Label1.Text = "Total do Produto:"
            Me.Label1.Top = 0!
            Me.Label1.Width = 2.4375!
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
            Me.Line1.Left = 4.296875!
            Me.Line1.LineWeight = 1!
            Me.Line1.Name = "Line1"
            Me.Line1.Top = 0!
            Me.Line1.Width = 3!
            Me.Line1.X1 = 7.296875!
            Me.Line1.X2 = 4.296875!
            Me.Line1.Y1 = 0!
            Me.Line1.Y2 = 0!
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
            Me.lblPag.Left = 4.875!
            Me.lblPag.Name = "lblPag"
            Me.lblPag.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; font-famil"& _ 
                "y: Tahoma; "
            Me.lblPag.Text = "Página"
            Me.lblPag.Top = 0!
            Me.lblPag.Width = 2.4375!
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
            Me.TextBox1.DataField = "quant"
            Me.TextBox1.Height = 0.1875!
            Me.TextBox1.Left = 5.359375!
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Style = "ddo-char-set: 1; text-align: center; font-size: 8pt; font-family: Tahoma; "
            Me.TextBox1.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
            Me.TextBox1.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
            Me.TextBox1.Text = "TextBox"
            Me.TextBox1.Top = 0!
            Me.TextBox1.Width = 0.375!
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
            Me.TextBox5.DataField = "Total"
            Me.TextBox5.Height = 0.1875!
            Me.TextBox5.Left = 6.546875!
            Me.TextBox5.Name = "TextBox5"
            Me.TextBox5.OutputFormat = resources.GetString("TextBox5.OutputFormat")
            Me.TextBox5.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; font-family: Tahoma; "
            Me.TextBox5.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
            Me.TextBox5.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
            Me.TextBox5.Text = "TextBox"
            Me.TextBox5.Top = 0!
            Me.TextBox5.Width = 0.6875!
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
            Me.Label2.Left = 2.90625!
            Me.Label2.Name = "Label2"
            Me.Label2.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; font-famil"& _ 
                "y: Tahoma; "
            Me.Label2.Text = "Total da Nota:"
            Me.Label2.Top = 0!
            Me.Label2.Width = 2.4375!
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
            Me.Line.Left = 4.3125!
            Me.Line.LineWeight = 1!
            Me.Line.Name = "Line"
            Me.Line.Top = 0!
            Me.Line.Width = 3!
            Me.Line.X1 = 7.3125!
            Me.Line.X2 = 4.3125!
            Me.Line.Y1 = 0!
            Me.Line.Y2 = 0!
            '
            'ActiveReport31
            '
            Me.MasterReport = false
            Me.PageSettings.PaperHeight = 11.69!
            Me.PageSettings.PaperWidth = 8.27!
            Me.PrintWidth = 7.291667!
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
            CType(Me.txtTitulo,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label6,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label8,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label9,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label10,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label11,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label12,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label13,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label7,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtProd,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.fldBarra,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox2,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox3,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox4,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox6,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox7,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label1,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.lblPag,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox1,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox5,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label2,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me,System.ComponentModel.ISupportInitialize).EndInit
        
	End Sub

#End Region
    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        txtTitulo.Text = titulo
    End Sub

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
    End Sub

    Private Sub PageFooter_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageFooter.Format
        lblPag.Text = "Página " & Me.PageNumber
    End Sub
End Class
