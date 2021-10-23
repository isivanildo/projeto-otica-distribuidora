Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports mrotica_util
Public Class rptAndamentos
Inherits DataDynamics.ActiveReports.ActiveReport3
	Public Sub New()
	MyBase.New()
		InitializeComponent()
	End Sub
	#Region "ActiveReports Designer generated code"
    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader = Nothing
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
	Private Label As DataDynamics.ActiveReports.Label
	Private Label1 As DataDynamics.ActiveReports.Label
	Private Label2 As DataDynamics.ActiveReports.Label
	Private Label3 As DataDynamics.ActiveReports.Label
	Private Label6 As DataDynamics.ActiveReports.Label
	Private fldLenteOE As DataDynamics.ActiveReports.TextBox
	Private Label5 As DataDynamics.ActiveReports.Label
	Private fldLenteOD As DataDynamics.ActiveReports.TextBox
	Private fldOSLocal As DataDynamics.ActiveReports.TextBox
	Private txtTratamento As DataDynamics.ActiveReports.TextBox
	Private Label4 As DataDynamics.ActiveReports.Label
	Private txtObs As DataDynamics.ActiveReports.TextBox
	Private txtCor As DataDynamics.ActiveReports.TextBox
	Private Line1 As DataDynamics.ActiveReports.Line
	Private TextBox As DataDynamics.ActiveReports.TextBox
	Private TextBox1 As DataDynamics.ActiveReports.TextBox
	Private TextBox2 As DataDynamics.ActiveReports.TextBox
	Private TextBox3 As DataDynamics.ActiveReports.TextBox
	Private Line As DataDynamics.ActiveReports.Line
	Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptAndamentos))
            Me.Detail = New DataDynamics.ActiveReports.Detail
            Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
            Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
            Me.Label = New DataDynamics.ActiveReports.Label
            Me.Label1 = New DataDynamics.ActiveReports.Label
            Me.Label2 = New DataDynamics.ActiveReports.Label
            Me.Label3 = New DataDynamics.ActiveReports.Label
            Me.Label6 = New DataDynamics.ActiveReports.Label
            Me.fldLenteOE = New DataDynamics.ActiveReports.TextBox
            Me.Label5 = New DataDynamics.ActiveReports.Label
            Me.fldLenteOD = New DataDynamics.ActiveReports.TextBox
            Me.fldOSLocal = New DataDynamics.ActiveReports.TextBox
            Me.txtTratamento = New DataDynamics.ActiveReports.TextBox
            Me.Label4 = New DataDynamics.ActiveReports.Label
            Me.txtObs = New DataDynamics.ActiveReports.TextBox
            Me.txtCor = New DataDynamics.ActiveReports.TextBox
            Me.Line1 = New DataDynamics.ActiveReports.Line
            Me.TextBox = New DataDynamics.ActiveReports.TextBox
            Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
            Me.TextBox2 = New DataDynamics.ActiveReports.TextBox
            Me.TextBox3 = New DataDynamics.ActiveReports.TextBox
            Me.Line = New DataDynamics.ActiveReports.Line
            CType(Me.Label,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label1,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label2,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label3,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label6,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.fldLenteOE,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label5,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.fldLenteOD,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.fldOSLocal,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtTratamento,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label4,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtObs,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtCor,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox1,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox2,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox3,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
            '
            'Detail
            '
            Me.Detail.ColumnSpacing = 0!
            Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox, Me.TextBox1, Me.TextBox2, Me.TextBox3, Me.Line})
            Me.Detail.Height = 0.1666667!
            Me.Detail.Name = "Detail"
            '
            'PageHeader
            '
            Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label, Me.Label1, Me.Label2, Me.Label3, Me.Label6, Me.fldLenteOE, Me.Label5, Me.fldLenteOD, Me.fldOSLocal, Me.txtTratamento, Me.Label4, Me.txtObs, Me.txtCor, Me.Line1})
            Me.PageHeader.Height = 1.399306!
            Me.PageHeader.Name = "PageHeader"
            '
            'PageFooter
            '
            Me.PageFooter.Height = 0.25!
            Me.PageFooter.Name = "PageFooter"
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
            Me.Label.Left = 0!
            Me.Label.Name = "Label"
            Me.Label.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; "
            Me.Label.Text = "Data / Hora"
            Me.Label.Top = 1.260417!
            Me.Label.Width = 0.75!
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
            Me.Label1.Left = 1!
            Me.Label1.Name = "Label1"
            Me.Label1.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; "
            Me.Label1.Text = "Andamento"
            Me.Label1.Top = 1.260417!
            Me.Label1.Width = 1!
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
            Me.Label2.Height = 0.1375!
            Me.Label2.HyperLink = Nothing
            Me.Label2.Left = 2.9375!
            Me.Label2.Name = "Label2"
            Me.Label2.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; "
            Me.Label2.Text = "Usuário"
            Me.Label2.Top = 1.260417!
            Me.Label2.Width = 1!
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
            Me.Label3.Left = 4.25!
            Me.Label3.Name = "Label3"
            Me.Label3.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; "
            Me.Label3.Text = "Observações"
            Me.Label3.Top = 1.260417!
            Me.Label3.Width = 1!
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
            Me.Label6.Height = 0.1479167!
            Me.Label6.HyperLink = Nothing
            Me.Label6.Left = 0!
            Me.Label6.Name = "Label6"
            Me.Label6.Style = "ddo-char-set: 1; font-size: 8pt; "
            Me.Label6.Text = "OE:"
            Me.Label6.Top = 0.4490812!
            Me.Label6.Width = 0.2395833!
            '
            'fldLenteOE
            '
            Me.fldLenteOE.Border.BottomColor = System.Drawing.Color.Black
            Me.fldLenteOE.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.fldLenteOE.Border.LeftColor = System.Drawing.Color.Black
            Me.fldLenteOE.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.fldLenteOE.Border.RightColor = System.Drawing.Color.Black
            Me.fldLenteOE.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.fldLenteOE.Border.TopColor = System.Drawing.Color.Black
            Me.fldLenteOE.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.fldLenteOE.DataField = "EST_OE"
            Me.fldLenteOE.Height = 0.16875!
            Me.fldLenteOE.Left = 0.3541667!
            Me.fldLenteOE.Name = "fldLenteOE"
            Me.fldLenteOE.Style = "ddo-char-set: 1; font-weight: normal; white-space: nowrap; "
            Me.fldLenteOE.Text = "TextBox2"
            Me.fldLenteOE.Top = 0.4479168!
            Me.fldLenteOE.Width = 6.843998!
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
            Me.Label5.Height = 0.1479167!
            Me.Label5.HyperLink = Nothing
            Me.Label5.Left = 0!
            Me.Label5.Name = "Label5"
            Me.Label5.Style = "ddo-char-set: 1; font-size: 8pt; "
            Me.Label5.Text = "OD:"
            Me.Label5.Top = 0.25!
            Me.Label5.Width = 0.2395833!
            '
            'fldLenteOD
            '
            Me.fldLenteOD.Border.BottomColor = System.Drawing.Color.Black
            Me.fldLenteOD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.fldLenteOD.Border.LeftColor = System.Drawing.Color.Black
            Me.fldLenteOD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.fldLenteOD.Border.RightColor = System.Drawing.Color.Black
            Me.fldLenteOD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.fldLenteOD.Border.TopColor = System.Drawing.Color.Black
            Me.fldLenteOD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.fldLenteOD.DataField = "EST_OD"
            Me.fldLenteOD.Height = 0.16875!
            Me.fldLenteOD.Left = 0.3541667!
            Me.fldLenteOD.Name = "fldLenteOD"
            Me.fldLenteOD.Style = "ddo-char-set: 1; font-weight: normal; white-space: nowrap; "
            Me.fldLenteOD.Text = "TextBox"
            Me.fldLenteOD.Top = 0.2604167!
            Me.fldLenteOD.Width = 6.847771!
            '
            'fldOSLocal
            '
            Me.fldOSLocal.Border.BottomColor = System.Drawing.Color.Black
            Me.fldOSLocal.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.fldOSLocal.Border.LeftColor = System.Drawing.Color.Black
            Me.fldOSLocal.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.fldOSLocal.Border.RightColor = System.Drawing.Color.Black
            Me.fldOSLocal.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.fldOSLocal.Border.TopColor = System.Drawing.Color.Black
            Me.fldOSLocal.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.fldOSLocal.Height = 0.2!
            Me.fldOSLocal.Left = 0!
            Me.fldOSLocal.Name = "fldOSLocal"
            Me.fldOSLocal.Style = "ddo-char-set: 1; font-weight: bold; "
            Me.fldOSLocal.Text = "TextBox4"
            Me.fldOSLocal.Top = 0!
            Me.fldOSLocal.Width = 7.1875!
            '
            'txtTratamento
            '
            Me.txtTratamento.Border.BottomColor = System.Drawing.Color.Black
            Me.txtTratamento.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtTratamento.Border.LeftColor = System.Drawing.Color.Black
            Me.txtTratamento.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtTratamento.Border.RightColor = System.Drawing.Color.Black
            Me.txtTratamento.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtTratamento.Border.TopColor = System.Drawing.Color.Black
            Me.txtTratamento.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtTratamento.Height = 0.16875!
            Me.txtTratamento.Left = 0.875!
            Me.txtTratamento.Name = "txtTratamento"
            Me.txtTratamento.Style = "ddo-char-set: 1; font-weight: normal; white-space: nowrap; "
            Me.txtTratamento.Text = "TextBox2"
            Me.txtTratamento.Top = 0.671875!
            Me.txtTratamento.Width = 5.406498!
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
            Me.Label4.Height = 0.1375!
            Me.Label4.HyperLink = Nothing
            Me.Label4.Left = 0!
            Me.Label4.Name = "Label4"
            Me.Label4.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; "
            Me.Label4.Text = "Tratamento"
            Me.Label4.Top = 0.6875!
            Me.Label4.Width = 0.6875!
            '
            'txtObs
            '
            Me.txtObs.Border.BottomColor = System.Drawing.Color.Black
            Me.txtObs.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtObs.Border.LeftColor = System.Drawing.Color.Black
            Me.txtObs.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtObs.Border.RightColor = System.Drawing.Color.Black
            Me.txtObs.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtObs.Border.TopColor = System.Drawing.Color.Black
            Me.txtObs.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtObs.Height = 0.16875!
            Me.txtObs.Left = 0!
            Me.txtObs.Name = "txtObs"
            Me.txtObs.Style = "ddo-char-set: 1; font-weight: normal; font-size: 8pt; white-space: nowrap; "
            Me.txtObs.Text = "TextBox2"
            Me.txtObs.Top = 0.875!
            Me.txtObs.Width = 7.375!
            '
            'txtCor
            '
            Me.txtCor.Border.BottomColor = System.Drawing.Color.Black
            Me.txtCor.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtCor.Border.LeftColor = System.Drawing.Color.Black
            Me.txtCor.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtCor.Border.RightColor = System.Drawing.Color.Black
            Me.txtCor.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtCor.Border.TopColor = System.Drawing.Color.Black
            Me.txtCor.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtCor.Height = 0.16875!
            Me.txtCor.Left = 0!
            Me.txtCor.Name = "txtCor"
            Me.txtCor.Style = "ddo-char-set: 1; font-weight: normal; font-size: 8pt; white-space: nowrap; "
            Me.txtCor.Text = "TextBox2"
            Me.txtCor.Top = 1.04375!
            Me.txtCor.Width = 7.375!
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
            Me.Line1.LineWeight = 1!
            Me.Line1.Name = "Line1"
            Me.Line1.Top = 1.1875!
            Me.Line1.Width = 7.375!
            Me.Line1.X1 = 0!
            Me.Line1.X2 = 7.375!
            Me.Line1.Y1 = 1.1875!
            Me.Line1.Y2 = 1.1875!
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
            Me.TextBox.DataField = "data"
            Me.TextBox.Height = 0.1375!
            Me.TextBox.Left = 0!
            Me.TextBox.Name = "TextBox"
            Me.TextBox.OutputFormat = resources.GetString("TextBox.OutputFormat")
            Me.TextBox.Style = "ddo-char-set: 1; font-size: 8pt; "
            Me.TextBox.Text = "TextBox"
            Me.TextBox.Top = 0!
            Me.TextBox.Width = 0.9375!
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
            Me.TextBox1.DataField = "andamento"
            Me.TextBox1.Height = 0.1375!
            Me.TextBox1.Left = 1!
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.OutputFormat = resources.GetString("TextBox1.OutputFormat")
            Me.TextBox1.Style = "ddo-char-set: 1; font-size: 8pt; "
            Me.TextBox1.Text = "TextBox"
            Me.TextBox1.Top = 0!
            Me.TextBox1.Width = 1.875!
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
            Me.TextBox2.CanGrow = false
            Me.TextBox2.DataField = "usuario"
            Me.TextBox2.Height = 0.1375!
            Me.TextBox2.Left = 2.9375!
            Me.TextBox2.Name = "TextBox2"
            Me.TextBox2.OutputFormat = resources.GetString("TextBox2.OutputFormat")
            Me.TextBox2.Style = "ddo-char-set: 1; font-size: 8pt; "
            Me.TextBox2.Text = "TextBox"
            Me.TextBox2.Top = 0!
            Me.TextBox2.Width = 1.25!
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
            Me.TextBox3.DataField = "observacao"
            Me.TextBox3.Height = 0.1375!
            Me.TextBox3.Left = 4.25!
            Me.TextBox3.Name = "TextBox3"
            Me.TextBox3.OutputFormat = resources.GetString("TextBox3.OutputFormat")
            Me.TextBox3.Style = "ddo-char-set: 1; font-size: 8pt; "
            Me.TextBox3.Text = "TextBox"
            Me.TextBox3.Top = 0!
            Me.TextBox3.Width = 3.1875!
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
            Me.Line.LineWeight = 1!
            Me.Line.Name = "Line"
            Me.Line.Top = 0.140625!
            Me.Line.Width = 7.5!
            Me.Line.X1 = 0!
            Me.Line.X2 = 7.5!
            Me.Line.Y1 = 0.140625!
            Me.Line.Y2 = 0.140625!
            '
            'ActiveReport31
            '
            Me.MasterReport = false
            Me.PageSettings.PaperHeight = 11.69!
            Me.PageSettings.PaperWidth = 8.27!
            Me.PrintWidth = 7.479167!
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
            CType(Me.Label,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label1,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label2,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label3,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label6,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.fldLenteOE,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label5,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.fldLenteOD,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.fldOSLocal,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtTratamento,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label4,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtObs,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtCor,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox1,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox2,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox3,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me,System.ComponentModel.ISupportInitialize).EndInit
        
	End Sub

	#End Region
    Public titulo As String
    Public xos, xfilial As Integer
    Dim os As ObjOS
    Dim prod As New produtoClass
    Dim d As New dados
    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        Try
            os = New ObjOS(xos, xfilial)
            fldOSLocal.Text = "OS Local: " & adiciona_zeros(os.id_filial, 3) & adiciona_zeros(os.cod_os, 6) & _
            " OS cliente " & adiciona_zeros(os.cod_cliente, 3) & adiciona_zeros(os.doc_cliente, 6)
            fldLenteOD.Text = os.cod_tab_od & " " & prod.Retorna_nome_prod(os.cod_produto_od)
            fldLenteOE.Text = os.cod_tab_oe & " " & prod.Retorna_nome_prod(os.cod_produto_oe)
            txtTratamento.Text = tratamentos(os.id_filial, os.cod_os)
            txtCor.Text = "Cor: " & os.cor_coloracao
            txtObs.Text = os.observacao
        Catch ex As Exception

        End Try
        
    End Sub
    Private Function tratamentos(ByVal id_filial As Integer, ByVal cod_os As Integer) As String
        Dim tTrat As New DataTable
        Dim strTratamentos As String = ""
        Dim sql As String
        Dim i As Integer = 0
        sql = "SELECT produtos.produto " & _
        "FROM tratamentos_os INNER JOIN " & _
        "produtos ON tratamentos_os.cod_produto = produtos.cod_produto " & _
        "where id_filial = " & id_filial & " and cod_os = " & cod_os & ""
        d.carrega_Tabela(sql, tTrat)

        While i < tTrat.Rows.Count
            If strTratamentos.Length = 0 Then
                strTratamentos = tTrat.Rows(i)(0)
            Else
                strTratamentos = strTratamentos & ";" & tTrat.Rows(i)(0)
            End If
            i = i + 1
        End While
        strTratamentos = strTratamentos & "."
        Return strTratamentos
    End Function

End Class
