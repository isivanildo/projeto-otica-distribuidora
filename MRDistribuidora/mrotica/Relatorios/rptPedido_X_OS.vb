Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class rptPedido_X_OS
Inherits DataDynamics.ActiveReports.ActiveReport3
	Public Sub New()
	MyBase.New()
		InitializeComponent()
	End Sub
	#Region "ActiveReports Designer generated code"
    Private WithEvents ReportHeader As DataDynamics.ActiveReports.ReportHeader = Nothing
    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader = Nothing
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
    Private WithEvents ReportFooter As DataDynamics.ActiveReports.ReportFooter = Nothing
	Private Label As DataDynamics.ActiveReports.Label
	Private Label1 As DataDynamics.ActiveReports.Label
	Private Label2 As DataDynamics.ActiveReports.Label
	Private Label3 As DataDynamics.ActiveReports.Label
	Private Label4 As DataDynamics.ActiveReports.Label
	Private TextBox As DataDynamics.ActiveReports.TextBox
	Private TextBox1 As DataDynamics.ActiveReports.TextBox
	Private TextBox2 As DataDynamics.ActiveReports.TextBox
	Private TextBox3 As DataDynamics.ActiveReports.TextBox
	Private TextBox4 As DataDynamics.ActiveReports.TextBox
	Private Line1 As DataDynamics.ActiveReports.Line
	Private SubReport As DataDynamics.ActiveReports.SubReport
	Private Line As DataDynamics.ActiveReports.Line
	Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptPedido_X_OS))
            Me.Detail = New DataDynamics.ActiveReports.Detail
            Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader
            Me.ReportFooter = New DataDynamics.ActiveReports.ReportFooter
            Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
            Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
            Me.Label = New DataDynamics.ActiveReports.Label
            Me.Label1 = New DataDynamics.ActiveReports.Label
            Me.Label2 = New DataDynamics.ActiveReports.Label
            Me.Label3 = New DataDynamics.ActiveReports.Label
            Me.Label4 = New DataDynamics.ActiveReports.Label
            Me.TextBox = New DataDynamics.ActiveReports.TextBox
            Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
            Me.TextBox2 = New DataDynamics.ActiveReports.TextBox
            Me.TextBox3 = New DataDynamics.ActiveReports.TextBox
            Me.TextBox4 = New DataDynamics.ActiveReports.TextBox
            Me.Line1 = New DataDynamics.ActiveReports.Line
            Me.SubReport = New DataDynamics.ActiveReports.SubReport
            Me.Line = New DataDynamics.ActiveReports.Line
            CType(Me.Label,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label1,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label2,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label3,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label4,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox1,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox2,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox3,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox4,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
            '
            'Detail
            '
            Me.Detail.ColumnSpacing = 0!
            Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox, Me.TextBox1, Me.TextBox2, Me.TextBox3, Me.TextBox4, Me.Line1})
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
            Me.ReportFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.SubReport, Me.Line})
            Me.ReportFooter.Height = 0.25!
            Me.ReportFooter.Name = "ReportFooter"
            '
            'PageHeader
            '
            Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label, Me.Label1, Me.Label2, Me.Label3, Me.Label4})
            Me.PageHeader.Height = 0.375!
            Me.PageHeader.Name = "PageHeader"
            '
            'PageFooter
            '
            Me.PageFooter.Height = 0!
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
            Me.Label.Height = 0.1875!
            Me.Label.HyperLink = Nothing
            Me.Label.Left = 0.5!
            Me.Label.Name = "Label"
            Me.Label.Style = "ddo-char-set: 1; font-size: 8pt; "
            Me.Label.Text = "Produto"
            Me.Label.Top = 0.1875!
            Me.Label.Width = 1!
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
            Me.Label1.Left = 4.9375!
            Me.Label1.Name = "Label1"
            Me.Label1.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
            Me.Label1.Text = "OS local"
            Me.Label1.Top = 0.1875!
            Me.Label1.Width = 0.5625!
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
            Me.Label2.Left = 5.5625!
            Me.Label2.Name = "Label2"
            Me.Label2.Style = "ddo-char-set: 1; text-align: left; font-size: 8pt; "
            Me.Label2.Text = "Cliente"
            Me.Label2.Top = 0.1875!
            Me.Label2.Width = 0.375!
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
            Me.Label3.Left = 6!
            Me.Label3.Name = "Label3"
            Me.Label3.Style = "ddo-char-set: 1; text-align: left; font-size: 8pt; "
            Me.Label3.Text = "OS Cliente"
            Me.Label3.Top = 0.1875!
            Me.Label3.Width = 0.625!
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
            Me.Label4.Left = 0!
            Me.Label4.Name = "Label4"
            Me.Label4.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; "
            Me.Label4.Text = "Produtos do Pedido e suas OS's"
            Me.Label4.Top = 0!
            Me.Label4.Width = 3.6875!
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
            Me.TextBox.DataField = "Produto"
            Me.TextBox.Height = 0.2!
            Me.TextBox.Left = 0.4375!
            Me.TextBox.Name = "TextBox"
            Me.TextBox.Style = "ddo-char-set: 1; font-size: 8pt; "
            Me.TextBox.Text = "TextBox"
            Me.TextBox.Top = 0!
            Me.TextBox.Width = 4.5!
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
            Me.TextBox1.DataField = "cod_os"
            Me.TextBox1.Height = 0.1875!
            Me.TextBox1.Left = 5.125!
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
            Me.TextBox1.Text = "TextBox"
            Me.TextBox1.Top = 0!
            Me.TextBox1.Width = 0.375!
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
            Me.TextBox2.DataField = "cod_cliente"
            Me.TextBox2.Height = 0.1875!
            Me.TextBox2.Left = 5.5625!
            Me.TextBox2.Name = "TextBox2"
            Me.TextBox2.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
            Me.TextBox2.Text = "TextBox"
            Me.TextBox2.Top = 0!
            Me.TextBox2.Width = 0.4375!
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
            Me.TextBox3.DataField = "doc_cliente"
            Me.TextBox3.Height = 0.1875!
            Me.TextBox3.Left = 6.0625!
            Me.TextBox3.Name = "TextBox3"
            Me.TextBox3.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
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
            Me.TextBox4.DataField = "item"
            Me.TextBox4.Height = 0.1875!
            Me.TextBox4.Left = 0!
            Me.TextBox4.Name = "TextBox4"
            Me.TextBox4.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
            Me.TextBox4.Text = "TextBox"
            Me.TextBox4.Top = 0!
            Me.TextBox4.Width = 0.375!
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
            Me.Line1.Left = 0.0625!
            Me.Line1.LineStyle = DataDynamics.ActiveReports.LineStyle.DashDot
            Me.Line1.LineWeight = 1!
            Me.Line1.Name = "Line1"
            Me.Line1.Top = 0.1875!
            Me.Line1.Width = 6.5625!
            Me.Line1.X1 = 0.0625!
            Me.Line1.X2 = 6.625!
            Me.Line1.Y1 = 0.1875!
            Me.Line1.Y2 = 0.1875!
            '
            'SubReport
            '
            Me.SubReport.Border.BottomColor = System.Drawing.Color.Black
            Me.SubReport.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.SubReport.Border.LeftColor = System.Drawing.Color.Black
            Me.SubReport.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.SubReport.Border.RightColor = System.Drawing.Color.Black
            Me.SubReport.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.SubReport.Border.TopColor = System.Drawing.Color.Black
            Me.SubReport.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.SubReport.CloseBorder = false
            Me.SubReport.Height = 0.1875!
            Me.SubReport.Left = 0!
            Me.SubReport.Name = "SubReport"
            Me.SubReport.Report = Nothing
            Me.SubReport.Top = 0!
            Me.SubReport.Width = 5.625!
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
            Me.Line.Width = 5.5625!
            Me.Line.X1 = 0!
            Me.Line.X2 = 5.5625!
            Me.Line.Y1 = 0!
            Me.Line.Y2 = 0!
            '
            'ActiveReport31
            '
            Me.MasterReport = false
            Me.PageSettings.PaperHeight = 11.69!
            Me.PageSettings.PaperWidth = 8.27!
            Me.PrintWidth = 6.677083!
            Me.Sections.Add(Me.ReportHeader)
            Me.Sections.Add(Me.PageHeader)
            Me.Sections.Add(Me.Detail)
            Me.Sections.Add(Me.PageFooter)
            Me.Sections.Add(Me.ReportFooter)
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
            CType(Me.Label4,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox1,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox2,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox3,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox4,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me,System.ComponentModel.ISupportInitialize).EndInit
        
	End Sub

	#End Region
    Public tb As New DataTable
    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format

    End Sub

    Private Sub rptPedido_X_OS_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        Dim r As New rptPedido_X_PedidoBalcao
        r.DataSource = tb
        Me.SubReport.Report = r
    End Sub

    Private Sub ReportFooter_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportFooter.Format

    End Sub
End Class
