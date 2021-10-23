
Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports mrotica_util
Public Class rptFatProdutosDesconto
    Inherits DataDynamics.ActiveReports.ActiveReport3
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub
    Dim tGraph As DataTable
#Region "ActiveReports Designer generated code"
    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader = Nothing
    Private WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader = Nothing
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
    Private WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter = Nothing
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
	Private TextBox As DataDynamics.ActiveReports.TextBox
	Private txtPedidos As DataDynamics.ActiveReports.TextBox
	Private txtPedCheio As DataDynamics.ActiveReports.TextBox
	Private txtPedFin As DataDynamics.ActiveReports.TextBox
	Private TextBox4 As DataDynamics.ActiveReports.TextBox
	Private txtOSCheio As DataDynamics.ActiveReports.TextBox
	Private txtOSFIN As DataDynamics.ActiveReports.TextBox
	Private txtPPedidos As DataDynamics.ActiveReports.TextBox
	Private txtPOS As DataDynamics.ActiveReports.TextBox
	Private txtCod_tabela As DataDynamics.ActiveReports.TextBox
	Private Chart1 As DataDynamics.ActiveReports.ChartControl
	Private Sub InitializeComponent()
            Dim ChartArea1 As DataDynamics.ActiveReports.Chart.ChartArea = New DataDynamics.ActiveReports.Chart.ChartArea
            Dim Axis1 As DataDynamics.ActiveReports.Chart.Axis = New DataDynamics.ActiveReports.Chart.Axis
            Dim Axis2 As DataDynamics.ActiveReports.Chart.Axis = New DataDynamics.ActiveReports.Chart.Axis
            Dim Axis3 As DataDynamics.ActiveReports.Chart.Axis = New DataDynamics.ActiveReports.Chart.Axis
            Dim Axis4 As DataDynamics.ActiveReports.Chart.Axis = New DataDynamics.ActiveReports.Chart.Axis
            Dim Axis5 As DataDynamics.ActiveReports.Chart.Axis = New DataDynamics.ActiveReports.Chart.Axis
            Dim Legend1 As DataDynamics.ActiveReports.Chart.Legend = New DataDynamics.ActiveReports.Chart.Legend
            Dim Title1 As DataDynamics.ActiveReports.Chart.Title = New DataDynamics.ActiveReports.Chart.Title
            Dim Title2 As DataDynamics.ActiveReports.Chart.Title = New DataDynamics.ActiveReports.Chart.Title
            Dim Series1 As DataDynamics.ActiveReports.Chart.Series = New DataDynamics.ActiveReports.Chart.Series
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptFatProdutosDesconto))
            Me.Detail = New DataDynamics.ActiveReports.Detail
            Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
            Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
            Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader
            Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
            Me.TextBox = New DataDynamics.ActiveReports.TextBox
            Me.txtPedidos = New DataDynamics.ActiveReports.TextBox
            Me.txtPedCheio = New DataDynamics.ActiveReports.TextBox
            Me.txtPedFin = New DataDynamics.ActiveReports.TextBox
            Me.TextBox4 = New DataDynamics.ActiveReports.TextBox
            Me.txtOSCheio = New DataDynamics.ActiveReports.TextBox
            Me.txtOSFIN = New DataDynamics.ActiveReports.TextBox
            Me.txtPPedidos = New DataDynamics.ActiveReports.TextBox
            Me.txtPOS = New DataDynamics.ActiveReports.TextBox
            Me.txtCod_tabela = New DataDynamics.ActiveReports.TextBox
            Me.Chart1 = New DataDynamics.ActiveReports.ChartControl
            CType(Me.TextBox,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtPedidos,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtPedCheio,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtPedFin,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox4,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtOSCheio,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtOSFIN,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtPPedidos,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtPOS,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtCod_tabela,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Chart1,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
            '
            'Detail
            '
            Me.Detail.ColumnSpacing = 0!
            Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox, Me.txtPedidos, Me.txtPedCheio, Me.txtPedFin, Me.TextBox4, Me.txtOSCheio, Me.txtOSFIN, Me.txtPPedidos, Me.txtPOS, Me.txtCod_tabela, Me.Chart1})
            Me.Detail.Height = 3.113889!
            Me.Detail.KeepTogether = true
            Me.Detail.Name = "Detail"
            '
            'PageHeader
            '
            Me.PageHeader.Height = 0.25!
            Me.PageHeader.Name = "PageHeader"
            '
            'PageFooter
            '
            Me.PageFooter.Height = 0.25!
            Me.PageFooter.Name = "PageFooter"
            '
            'GroupHeader1
            '
            Me.GroupHeader1.Height = 0.25!
            Me.GroupHeader1.Name = "GroupHeader1"
            '
            'GroupFooter1
            '
            Me.GroupFooter1.Height = 0.25!
            Me.GroupFooter1.Name = "GroupFooter1"
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
            Me.TextBox.DataField = "nome_Comercial"
            Me.TextBox.Height = 0.2!
            Me.TextBox.Left = 0!
            Me.TextBox.Name = "TextBox"
            Me.TextBox.Style = ""
            Me.TextBox.Text = "TextBox"
            Me.TextBox.Top = 0!
            Me.TextBox.Width = 2.9375!
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
            Me.txtPedidos.DataField = "pedidos"
            Me.txtPedidos.Height = 0.2!
            Me.txtPedidos.Left = 3.0625!
            Me.txtPedidos.Name = "txtPedidos"
            Me.txtPedidos.Style = ""
            Me.txtPedidos.Text = "TextBox"
            Me.txtPedidos.Top = 0!
            Me.txtPedidos.Width = 0.5625!
            '
            'txtPedCheio
            '
            Me.txtPedCheio.Border.BottomColor = System.Drawing.Color.Black
            Me.txtPedCheio.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtPedCheio.Border.LeftColor = System.Drawing.Color.Black
            Me.txtPedCheio.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtPedCheio.Border.RightColor = System.Drawing.Color.Black
            Me.txtPedCheio.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtPedCheio.Border.TopColor = System.Drawing.Color.Black
            Me.txtPedCheio.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtPedCheio.DataField = "pedidosCheio"
            Me.txtPedCheio.Height = 0.2!
            Me.txtPedCheio.Left = 3.833333!
            Me.txtPedCheio.Name = "txtPedCheio"
            Me.txtPedCheio.OutputFormat = resources.GetString("txtPedCheio.OutputFormat")
            Me.txtPedCheio.Style = "text-align: right; "
            Me.txtPedCheio.Text = "TextBox"
            Me.txtPedCheio.Top = 0!
            Me.txtPedCheio.Width = 0.875!
            '
            'txtPedFin
            '
            Me.txtPedFin.Border.BottomColor = System.Drawing.Color.Black
            Me.txtPedFin.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtPedFin.Border.LeftColor = System.Drawing.Color.Black
            Me.txtPedFin.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtPedFin.Border.RightColor = System.Drawing.Color.Black
            Me.txtPedFin.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtPedFin.Border.TopColor = System.Drawing.Color.Black
            Me.txtPedFin.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtPedFin.DataField = "pedidosFin"
            Me.txtPedFin.Height = 0.2!
            Me.txtPedFin.Left = 4.979167!
            Me.txtPedFin.Name = "txtPedFin"
            Me.txtPedFin.OutputFormat = resources.GetString("txtPedFin.OutputFormat")
            Me.txtPedFin.Style = "text-align: right; "
            Me.txtPedFin.Text = "TextBox"
            Me.txtPedFin.Top = 0!
            Me.txtPedFin.Width = 0.7916667!
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
            Me.TextBox4.DataField = "OS"
            Me.TextBox4.Height = 0.2!
            Me.TextBox4.Left = 7.1875!
            Me.TextBox4.Name = "TextBox4"
            Me.TextBox4.Style = ""
            Me.TextBox4.Text = "TextBox"
            Me.TextBox4.Top = 0!
            Me.TextBox4.Width = 0.5625!
            '
            'txtOSCheio
            '
            Me.txtOSCheio.Border.BottomColor = System.Drawing.Color.Black
            Me.txtOSCheio.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtOSCheio.Border.LeftColor = System.Drawing.Color.Black
            Me.txtOSCheio.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtOSCheio.Border.RightColor = System.Drawing.Color.Black
            Me.txtOSCheio.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtOSCheio.Border.TopColor = System.Drawing.Color.Black
            Me.txtOSCheio.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtOSCheio.DataField = "OSCheio"
            Me.txtOSCheio.Height = 0.2!
            Me.txtOSCheio.Left = 7.927083!
            Me.txtOSCheio.Name = "txtOSCheio"
            Me.txtOSCheio.OutputFormat = resources.GetString("txtOSCheio.OutputFormat")
            Me.txtOSCheio.Style = "text-align: right; "
            Me.txtOSCheio.Text = "TextBox"
            Me.txtOSCheio.Top = 0!
            Me.txtOSCheio.Width = 0.9375!
            '
            'txtOSFIN
            '
            Me.txtOSFIN.Border.BottomColor = System.Drawing.Color.Black
            Me.txtOSFIN.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtOSFIN.Border.LeftColor = System.Drawing.Color.Black
            Me.txtOSFIN.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtOSFIN.Border.RightColor = System.Drawing.Color.Black
            Me.txtOSFIN.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtOSFIN.Border.TopColor = System.Drawing.Color.Black
            Me.txtOSFIN.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtOSFIN.DataField = "OSFin"
            Me.txtOSFIN.Height = 0.2!
            Me.txtOSFIN.Left = 9.072917!
            Me.txtOSFIN.Name = "txtOSFIN"
            Me.txtOSFIN.OutputFormat = resources.GetString("txtOSFIN.OutputFormat")
            Me.txtOSFIN.Style = "text-align: right; "
            Me.txtOSFIN.Text = "TextBox"
            Me.txtOSFIN.Top = 0!
            Me.txtOSFIN.Width = 0.8541667!
            '
            'txtPPedidos
            '
            Me.txtPPedidos.Border.BottomColor = System.Drawing.Color.Black
            Me.txtPPedidos.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtPPedidos.Border.LeftColor = System.Drawing.Color.Black
            Me.txtPPedidos.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtPPedidos.Border.RightColor = System.Drawing.Color.Black
            Me.txtPPedidos.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtPPedidos.Border.TopColor = System.Drawing.Color.Black
            Me.txtPPedidos.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtPPedidos.Height = 0.2!
            Me.txtPPedidos.Left = 5.895833!
            Me.txtPPedidos.Name = "txtPPedidos"
            Me.txtPPedidos.Style = ""
            Me.txtPPedidos.Text = "TextBox1"
            Me.txtPPedidos.Top = 0!
            Me.txtPPedidos.Width = 0.6875!
            '
            'txtPOS
            '
            Me.txtPOS.Border.BottomColor = System.Drawing.Color.Black
            Me.txtPOS.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtPOS.Border.LeftColor = System.Drawing.Color.Black
            Me.txtPOS.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtPOS.Border.RightColor = System.Drawing.Color.Black
            Me.txtPOS.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtPOS.Border.TopColor = System.Drawing.Color.Black
            Me.txtPOS.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtPOS.Height = 0.2!
            Me.txtPOS.Left = 9.989583!
            Me.txtPOS.Name = "txtPOS"
            Me.txtPOS.Style = ""
            Me.txtPOS.Text = "TextBox1"
            Me.txtPOS.Top = 0!
            Me.txtPOS.Width = 0.6875!
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
            Me.txtCod_tabela.DataField = "cod_tabela"
            Me.txtCod_tabela.Height = 0.2!
            Me.txtCod_tabela.Left = 0!
            Me.txtCod_tabela.Name = "txtCod_tabela"
            Me.txtCod_tabela.OutputFormat = resources.GetString("txtCod_tabela.OutputFormat")
            Me.txtCod_tabela.Style = "text-align: right; "
            Me.txtCod_tabela.Text = "TextBox"
            Me.txtCod_tabela.Top = 0.25!
            Me.txtCod_tabela.Width = 0.875!
            '
            'Chart1
            '
            Me.Chart1.AutoRefresh = true
            Me.Chart1.Backdrop = New DataDynamics.ActiveReports.Chart.BackdropItem(DataDynamics.ActiveReports.Chart.Graphics.BackdropStyle.Transparent, System.Drawing.Color.White, System.Drawing.Color.SteelBlue, DataDynamics.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Drawing2D.HatchStyle.DottedGrid, Nothing, DataDynamics.ActiveReports.Chart.Graphics.PicturePutStyle.Stretched)
            Me.Chart1.Border.BottomColor = System.Drawing.Color.Black
            Me.Chart1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.Chart1.Border.LeftColor = System.Drawing.Color.Black
            Me.Chart1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.Chart1.Border.RightColor = System.Drawing.Color.Black
            Me.Chart1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.Chart1.Border.TopColor = System.Drawing.Color.Black
            Me.Chart1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            ChartArea1.AntiAliasMode = DataDynamics.ActiveReports.Chart.Graphics.AntiAliasMode.Graphics
            Axis1.AxisType = DataDynamics.ActiveReports.Chart.AxisType.Categorical
            Axis1.LabelFont = New DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8!))
            Axis1.MajorTick = New DataDynamics.ActiveReports.Chart.Tick(New DataDynamics.ActiveReports.Chart.Graphics.Line, New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Black, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.Dot), 1, 5!, true)
            Axis1.MinorTick = New DataDynamics.ActiveReports.Chart.Tick(New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0, 0!, false)
            Axis1.Title = "Axis X"
            Axis1.TitleFont = New DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8!))
            Axis2.LabelFont = New DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8!))
            Axis2.LabelsGap = 0
            Axis2.LabelsVisible = false
            Axis2.Line = New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None)
            Axis2.MajorTick = New DataDynamics.ActiveReports.Chart.Tick(New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0, 0!, false)
            Axis2.MinorTick = New DataDynamics.ActiveReports.Chart.Tick(New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0, 0!, false)
            Axis2.Position = 0
            Axis2.TickOffset = 0
            Axis2.TitleFont = New DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8!))
            Axis2.Visible = false
            Axis3.LabelFont = New DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8!))
            Axis3.LabelFormat = "{0:#.00}"
            Axis3.MajorTick = New DataDynamics.ActiveReports.Chart.Tick(New DataDynamics.ActiveReports.Chart.Graphics.Line, New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Black, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.Dot), 1, 5!, true)
            Axis3.MinorTick = New DataDynamics.ActiveReports.Chart.Tick(New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0, 0!, false)
            Axis3.Position = 0
            Axis3.Title = "Axis Y"
            Axis3.TitleFont = New DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8!), -90!)
            Axis4.LabelFont = New DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8!))
            Axis4.LabelsVisible = false
            Axis4.Line = New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None)
            Axis4.MajorTick = New DataDynamics.ActiveReports.Chart.Tick(New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0, 0!, false)
            Axis4.MinorTick = New DataDynamics.ActiveReports.Chart.Tick(New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0, 0!, false)
            Axis4.TitleFont = New DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8!))
            Axis4.Visible = false
            Axis5.LabelFont = New DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8!))
            Axis5.LabelsGap = 0
            Axis5.LabelsVisible = false
            Axis5.Line = New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None)
            Axis5.MajorTick = New DataDynamics.ActiveReports.Chart.Tick(New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0, 0!, false)
            Axis5.MinorTick = New DataDynamics.ActiveReports.Chart.Tick(New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0, 0!, false)
            Axis5.Position = 0
            Axis5.TickOffset = 0
            Axis5.TitleFont = New DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8!))
            Axis5.Visible = false
            ChartArea1.Axes.AddRange(New DataDynamics.ActiveReports.Chart.AxisBase() {Axis1, Axis2, Axis3, Axis4, Axis5})
            ChartArea1.Backdrop = New DataDynamics.ActiveReports.Chart.BackdropItem(DataDynamics.ActiveReports.Chart.Graphics.BackdropStyle.Transparent, System.Drawing.Color.White, System.Drawing.Color.White, DataDynamics.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Drawing2D.HatchStyle.DottedGrid, Nothing, DataDynamics.ActiveReports.Chart.Graphics.PicturePutStyle.Stretched)
            ChartArea1.Border = New DataDynamics.ActiveReports.Chart.Border(New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black)
            ChartArea1.Light = New DataDynamics.ActiveReports.Chart.Light(New DataDynamics.ActiveReports.Chart.Graphics.Point3d(10!, 40!, 20!), DataDynamics.ActiveReports.Chart.LightType.InfiniteDirectional, 0.3!)
            ChartArea1.Name = "defaultArea"
            ChartArea1.Projection = New DataDynamics.ActiveReports.Chart.Projection(DataDynamics.ActiveReports.Chart.Graphics.ProjectionType.Identical, 0.05968!, 0.13648!)
            ChartArea1.WallXY = New DataDynamics.ActiveReports.Chart.PlaneItem(New DataDynamics.ActiveReports.Chart.Graphics.Backdrop(DataDynamics.ActiveReports.Chart.Graphics.BackdropStyle.Transparent, System.Drawing.Color.White, System.Drawing.Color.White, DataDynamics.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Drawing2D.HatchStyle.DottedGrid, Nothing, DataDynamics.ActiveReports.Chart.Graphics.PicturePutStyle.Stretched))
            Me.Chart1.ChartAreas.AddRange(New DataDynamics.ActiveReports.Chart.ChartArea() {ChartArea1})
            Me.Chart1.ChartBorder = New DataDynamics.ActiveReports.Chart.Border(New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black)
            Me.Chart1.Height = 2!
            Me.Chart1.Left = 1.6875!
            Legend1.Alignment = DataDynamics.ActiveReports.Chart.Alignment.Right
            Legend1.Backdrop = New DataDynamics.ActiveReports.Chart.BackdropItem(System.Drawing.Color.White, CType(128,Byte))
            Legend1.Border = New DataDynamics.ActiveReports.Chart.Border(New DataDynamics.ActiveReports.Chart.Graphics.Line, 0, System.Drawing.Color.Black)
            Legend1.DockArea = ChartArea1
            Title1.Backdrop = New DataDynamics.ActiveReports.Chart.Graphics.Backdrop(DataDynamics.ActiveReports.Chart.Graphics.BackdropStyle.Transparent, System.Drawing.Color.White, System.Drawing.Color.White, DataDynamics.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Drawing2D.HatchStyle.DottedGrid, Nothing, DataDynamics.ActiveReports.Chart.Graphics.PicturePutStyle.Stretched)
            Title1.Border = New DataDynamics.ActiveReports.Chart.Border(New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black)
            Title1.DockArea = Nothing
            Title1.Font = New DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8!))
            Title1.Name = ""
            Title1.Text = ""
            Legend1.Footer = Title1
            Legend1.GridLayout = New DataDynamics.ActiveReports.Chart.GridLayout(0, 1)
            Title2.Border = New DataDynamics.ActiveReports.Chart.Border(New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.White, 2), 0, System.Drawing.Color.Black)
            Title2.DockArea = Nothing
            Title2.Font = New DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8!))
            Title2.Name = ""
            Title2.Text = "Legend"
            Legend1.Header = Title2
            Legend1.LabelsFont = New DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8!))
            Legend1.Name = "defaultLegend"
            Me.Chart1.Legends.AddRange(New DataDynamics.ActiveReports.Chart.Legend() {Legend1})
            Me.Chart1.Name = "Chart1"
            Series1.AxisX = Axis1
            Series1.AxisY = Axis3
            Series1.ChartArea = ChartArea1
            Series1.Legend = Legend1
            Series1.LegendText = ""
            Series1.Name = "Vendas"
            Series1.Properties = New DataDynamics.ActiveReports.Chart.CustomProperties(New DataDynamics.ActiveReports.Chart.KeyValuePair() {New DataDynamics.ActiveReports.Chart.KeyValuePair("CloseLine", New DataDynamics.ActiveReports.Chart.Graphics.Line), New DataDynamics.ActiveReports.Chart.KeyValuePair("HiloLine", New DataDynamics.ActiveReports.Chart.Graphics.Line), New DataDynamics.ActiveReports.Chart.KeyValuePair("TickLen", 5!), New DataDynamics.ActiveReports.Chart.KeyValuePair("BarType", DataDynamics.ActiveReports.Chart.BarType.Bar)})
            Series1.Type = DataDynamics.ActiveReports.Chart.ChartType.Line
            Me.Chart1.Series.AddRange(New DataDynamics.ActiveReports.Chart.Series() {Series1})
            Me.Chart1.Top = 0.5625!
            Me.Chart1.UIOptions = DataDynamics.ActiveReports.Chart.UIOptions.ForceHitTesting
            Me.Chart1.Width = 4.625!
            '
            'ActiveReport31
            '
            Me.MasterReport = false
            Me.PageSettings.DefaultPaperSize = false
            Me.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape
            Me.PageSettings.PaperHeight = 11.69306!
            Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
            Me.PageSettings.PaperWidth = 8.268056!
            Me.PrintWidth = 10.8125!
            Me.Sections.Add(Me.PageHeader)
            Me.Sections.Add(Me.GroupHeader1)
            Me.Sections.Add(Me.Detail)
            Me.Sections.Add(Me.GroupFooter1)
            Me.Sections.Add(Me.PageFooter)
            Me.StyleSheet.Add(New DDCssLib.StyleSheetRule(resources.GetString("$this.StyleSheet"), "Normal"))
            Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo"& _ 
                        "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading1", "Normal"))
            Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei"& _ 
                        "ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading2", "Normal"))
            Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo"& _ 
                        "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading3", "Normal"))
            CType(Me.TextBox,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtPedidos,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtPedCheio,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtPedFin,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox4,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtOSCheio,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtOSFIN,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtPPedidos,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtPOS,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtCod_tabela,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Chart1,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me,System.ComponentModel.ISupportInitialize).EndInit
        
	End Sub

#End Region
    Private Sub cria_tabela(ByVal nome As String)
        tGraph = New DataTable
        tGraph.Columns.Add("Mes")
        tGraph.Columns.Add("valor")
        tGraph.TableName = nome
    End Sub
    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        graph()
        Try
            If CDbl(txtPedCheio.Text) = 0 Then
                txtPPedidos.Text = "0,00%"
                Exit Sub
            End If
            txtPPedidos.Text = Format(((1 - ((txtPedFin.Text / txtPedCheio.Text))) * 100), "#,##0.00") & "%"
        Catch ex As Exception
            txtPPedidos.Text = "0%"
        End Try
        Try
            If CDbl(txtOSCheio.Text) = 0 Then
                txtPOS.Text = "0,00%"
                Exit Sub
            End If
            txtPOS.Text = Format(((1 - ((txtOSFIN.Text / txtOSCheio.Text))) * 100), "#,##0.00") & "%"
        Catch ex As Exception
            txtPOS.Text = "0%"
        End Try
    End Sub
    Private Sub graph()
        Dim m4, m3, m2, m1 As String
        Dim v4, v3, v2, v1 As Double
        Dim di, df As Date
        Dim p As New produtoClass
        Dim ds As New DataSet
        cria_tabela(txtCod_tabela.Text)
        Try

            'Mês Atual
            df = Now.Date & " 23:59:59"
            di = CDate("01/" & Now.Month & "/" & Now.Year)
            di = di.Date & " 00:00:00"
            m4 = "Mês " & df.Month & "/" & df.Year
            v4 = p.retorna_faturamento_periodo(txtCod_tabela.Text, di, df)
            'Mês Anterior
            df = DateAdd(DateInterval.Month, -1, df)
            df = Date.DaysInMonth(df.Year, df.Month) & "/" & df.Month & "/" & df.Year
            df = df.Date & " 23:59:59"
            di = "01/" & df.Month & "/" & df.Year
            di = di.Date & " 00:00:00"
            m3 = "Mês " & df.Month & "/" & df.Year
            v3 = p.retorna_faturamento_periodo(txtCod_tabela.Text, di, df)
            '2 Meses Antes
            df = DateAdd(DateInterval.Month, -1, df)
            df = Date.DaysInMonth(df.Year, df.Month) & "/" & df.Month & "/" & df.Year
            df = df.Date & " 23:59:59"
            di = "01/" & df.Month & "/" & df.Year
            di = di.Date & " 00:00:00"
            m2 = "Mês " & df.Month & "/" & df.Year
            v2 = p.retorna_faturamento_periodo(txtCod_tabela.Text, di, df)
            '3 Meses Antes
            df = DateAdd(DateInterval.Month, -1, df)
            df = Date.DaysInMonth(df.Year, df.Month) & "/" & df.Month & "/" & df.Year
            df = df.Date & " 23:59:59"
            di = "01/" & df.Month & "/" & df.Year
            di = di.Date & " 00:00:00"
            m1 = "Mês " & df.Month & "/" & df.Year
            v1 = p.retorna_faturamento_periodo(txtCod_tabela.Text, di, df)
            Dim r As DataRow
            r = tGraph.NewRow
            r("mes") = m1
            r("valor") = v1
            tGraph.Rows.Add(r)
            r = tGraph.NewRow
            r("mes") = m2
            r("valor") = v2
            tGraph.Rows.Add(r)
            r = tGraph.NewRow
            r("mes") = m3
            r("valor") = v3
            tGraph.Rows.Add(r)
            r = tGraph.NewRow
            r("mes") = m4
            r("valor") = v4
            tGraph.Rows.Add(r)
            ds.Clear()
            ds.Tables.Add(tGraph)

            'Dim s As New DataDynamics.ActiveReports.Chart.Series
            ' set the DataSource, ValueMembersY, and ValueMembersX properties
            Me.Chart1.DataSource = tGraph.DataSet
            Me.Chart1.Series(0).ValueMembersY = ds.Tables(txtCod_tabela.Text).Columns(1).ColumnName
            'Chart1.Series(0).AxisY.LabelsVisible = True
            'Chart1.Series(0).AxisY.SmartLabels = False
            'Chart1.Series(0).AxisY.LabelFormat = "{0:0.00}"    
            'Chart1.Series(0).AxisY.MajorTick.Step = 1000
            'Chart1.Series(0).AxisY.AxisType = Chart.AxisType.Numerical
            Chart1.Series(0).AxisY.Title = "Valor"
            Me.Chart1.Series(0).ValueMemberX = ds.Tables(txtCod_tabela.Text).Columns(0).ColumnName
            Chart1.Series(0).AxisX.Title = "Período"
            Chart1.Series(0).Type = Chart.ChartType.Line

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub rptFatProdutosDesconto_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart

    End Sub
End Class
