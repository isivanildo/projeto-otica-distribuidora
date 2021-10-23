Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class rptListaPedidoatendido
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
	Private lbltitulo As DataDynamics.ActiveReports.Label
	Private Label5 As DataDynamics.ActiveReports.Label
	Private TextBox As DataDynamics.ActiveReports.TextBox
	Private txtProd As DataDynamics.ActiveReports.TextBox
	Private fldBarra As DataDynamics.ActiveReports.TextBox
	Private TextBox2 As DataDynamics.ActiveReports.TextBox
	Private TextBox1 As DataDynamics.ActiveReports.TextBox
	Private subRpt As DataDynamics.ActiveReports.SubReport
	Private lblTitSub As DataDynamics.ActiveReports.Label
	Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptListaPedidoatendido))
            Me.Detail = New DataDynamics.ActiveReports.Detail
            Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader
            Me.ReportFooter = New DataDynamics.ActiveReports.ReportFooter
            Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
            Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
            Me.Label = New DataDynamics.ActiveReports.Label
            Me.Label1 = New DataDynamics.ActiveReports.Label
            Me.Label2 = New DataDynamics.ActiveReports.Label
            Me.Label3 = New DataDynamics.ActiveReports.Label
            Me.lbltitulo = New DataDynamics.ActiveReports.Label
            Me.Label5 = New DataDynamics.ActiveReports.Label
            Me.TextBox = New DataDynamics.ActiveReports.TextBox
            Me.txtProd = New DataDynamics.ActiveReports.TextBox
            Me.fldBarra = New DataDynamics.ActiveReports.TextBox
            Me.TextBox2 = New DataDynamics.ActiveReports.TextBox
            Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
            Me.subRpt = New DataDynamics.ActiveReports.SubReport
            Me.lblTitSub = New DataDynamics.ActiveReports.Label
            CType(Me.Label,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label1,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label2,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label3,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.lbltitulo,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label5,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtProd,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.fldBarra,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox2,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox1,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.lblTitSub,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
            '
            'Detail
            '
            Me.Detail.ColumnSpacing = 0!
            Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox, Me.txtProd, Me.fldBarra, Me.TextBox2, Me.TextBox1})
            Me.Detail.Height = 0.1666667!
            Me.Detail.Name = "Detail"
            '
            'ReportHeader
            '
            Me.ReportHeader.Height = 0!
            Me.ReportHeader.Name = "ReportHeader"
            '
            'ReportFooter
            '
            Me.ReportFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.subRpt, Me.lblTitSub})
            Me.ReportFooter.Height = 0.4583333!
            Me.ReportFooter.Name = "ReportFooter"
            '
            'PageHeader
            '
            Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label, Me.Label1, Me.Label2, Me.Label3, Me.lbltitulo, Me.Label5})
            Me.PageHeader.Height = 0.71875!
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
            Me.Label.Height = 0.2!
            Me.Label.HyperLink = Nothing
            Me.Label.Left = 0!
            Me.Label.Name = "Label"
            Me.Label.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; font-family: Tahoma; "
            Me.Label.Text = "Tabela"
            Me.Label.Top = 0.5625!
            Me.Label.Width = 0.5!
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
            Me.Label1.Left = 0.625!
            Me.Label1.Name = "Label1"
            Me.Label1.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; font-family: Tahoma; "
            Me.Label1.Text = "Produto"
            Me.Label1.Top = 0.5625!
            Me.Label1.Width = 1.1875!
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
            Me.Label2.Left = 4.625!
            Me.Label2.Name = "Label2"
            Me.Label2.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; font-family: Tahoma; "
            Me.Label2.Text = "C. Barras"
            Me.Label2.Top = 0.5625!
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
            Me.Label3.Left = 5.375!
            Me.Label3.Name = "Label3"
            Me.Label3.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; font-family: Tahoma; "
            Me.Label3.Text = "Quant."
            Me.Label3.Top = 0.5625!
            Me.Label3.Width = 0.375!
            '
            'lbltitulo
            '
            Me.lbltitulo.Border.BottomColor = System.Drawing.Color.Black
            Me.lbltitulo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.lbltitulo.Border.LeftColor = System.Drawing.Color.Black
            Me.lbltitulo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.lbltitulo.Border.RightColor = System.Drawing.Color.Black
            Me.lbltitulo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.lbltitulo.Border.TopColor = System.Drawing.Color.Black
            Me.lbltitulo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.lbltitulo.Height = 0.2!
            Me.lbltitulo.HyperLink = Nothing
            Me.lbltitulo.Left = 0!
            Me.lbltitulo.Name = "lbltitulo"
            Me.lbltitulo.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; font-fami"& _ 
                "ly: Tahoma; "
            Me.lbltitulo.Text = ""
            Me.lbltitulo.Top = 0!
            Me.lbltitulo.Width = 7.25!
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
            Me.Label5.Height = 0.2!
            Me.Label5.HyperLink = Nothing
            Me.Label5.Left = 5.8125!
            Me.Label5.Name = "Label5"
            Me.Label5.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; font-family: Tahoma; "
            Me.Label5.Text = "Atendido"
            Me.Label5.Top = 0.5625!
            Me.Label5.Width = 0.5625!
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
            Me.TextBox.DataField = "cod_tabela"
            Me.TextBox.Height = 0.1822917!
            Me.TextBox.Left = 0!
            Me.TextBox.Name = "TextBox"
            Me.TextBox.Style = "ddo-char-set: 1; font-size: 8pt; font-family: Tahoma; "
            Me.TextBox.Text = "TextBox"
            Me.TextBox.Top = 0!
            Me.TextBox.Width = 0.5!
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
            Me.fldBarra.OutputFormat = resources.GetString("fldBarra.OutputFormat")
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
            Me.TextBox1.DataField = "atend"
            Me.TextBox1.Height = 0.1875!
            Me.TextBox1.Left = 5.875!
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Style = "ddo-char-set: 1; text-align: center; font-size: 8pt; font-family: Tahoma; "
            Me.TextBox1.Text = "TextBox"
            Me.TextBox1.Top = 0!
            Me.TextBox1.Width = 0.375!
            '
            'subRpt
            '
            Me.subRpt.Border.BottomColor = System.Drawing.Color.Black
            Me.subRpt.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.subRpt.Border.LeftColor = System.Drawing.Color.Black
            Me.subRpt.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.subRpt.Border.RightColor = System.Drawing.Color.Black
            Me.subRpt.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.subRpt.Border.TopColor = System.Drawing.Color.Black
            Me.subRpt.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.subRpt.CloseBorder = false
            Me.subRpt.Height = 0.1875!
            Me.subRpt.Left = 0!
            Me.subRpt.Name = "subRpt"
            Me.subRpt.Report = Nothing
            Me.subRpt.Top = 0.25!
            Me.subRpt.Width = 7.25!
            '
            'lblTitSub
            '
            Me.lblTitSub.Border.BottomColor = System.Drawing.Color.Black
            Me.lblTitSub.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.lblTitSub.Border.LeftColor = System.Drawing.Color.Black
            Me.lblTitSub.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.lblTitSub.Border.RightColor = System.Drawing.Color.Black
            Me.lblTitSub.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.lblTitSub.Border.TopColor = System.Drawing.Color.Black
            Me.lblTitSub.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.lblTitSub.Height = 0.2!
            Me.lblTitSub.HyperLink = Nothing
            Me.lblTitSub.Left = 0!
            Me.lblTitSub.Name = "lblTitSub"
            Me.lblTitSub.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; font-family: Tahoma; "
            Me.lblTitSub.Text = "Itens da Nota que não estavam no pedido"
            Me.lblTitSub.Top = 0!
            Me.lblTitSub.Width = 2.75!
            '
            'ActiveReport31
            '
            Me.MasterReport = false
            Me.PageSettings.PaperHeight = 11.69!
            Me.PageSettings.PaperWidth = 8.27!
            Me.PrintWidth = 7.291667!
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
            CType(Me.lbltitulo,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label5,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtProd,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.fldBarra,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox2,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox1,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.lblTitSub,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me,System.ComponentModel.ISupportInitialize).EndInit
        
	End Sub

#End Region
    Public tb_n_pedido As New DataTable
    Public titulo As String
    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        lbltitulo.Text = titulo
    End Sub
    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
    End Sub

    Private Sub ReportFooter_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportFooter.Format
        If tb_n_pedido.Rows.Count = 0 Then
            lblTitSub.Text = ""
            Exit Sub
        End If
        Dim r As New rptListaPedidoatendidoextra
        r.DataSource = tb_n_pedido
        subRpt.Report = r
    End Sub
End Class
