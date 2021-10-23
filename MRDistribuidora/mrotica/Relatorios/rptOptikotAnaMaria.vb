Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class rptOptikotAnaMaria
Inherits DataDynamics.ActiveReports.ActiveReport3
	Public Sub New()
	MyBase.New()
		InitializeComponent()
	End Sub
	#Region "ActiveReports Designer generated code"
    Private WithEvents ReportHeader As DataDynamics.ActiveReports.ReportHeader = Nothing
    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader = Nothing
    Private WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader = Nothing
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
    Private WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter = Nothing
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
    Private WithEvents ReportFooter As DataDynamics.ActiveReports.ReportFooter = Nothing
	Private lblTitulo As DataDynamics.ActiveReports.Label
	Private TextBox As DataDynamics.ActiveReports.TextBox
	Private Line2 As DataDynamics.ActiveReports.Line
	Private txtTrat As DataDynamics.ActiveReports.TextBox
	Private txtQuant As DataDynamics.ActiveReports.TextBox
	Private Line As DataDynamics.ActiveReports.Line
	Private txtOpt As DataDynamics.ActiveReports.TextBox
	Private quantOpt As DataDynamics.ActiveReports.TextBox
	Private TextBox1 As DataDynamics.ActiveReports.TextBox
	Private quantEasy As DataDynamics.ActiveReports.TextBox
	Private Line1 As DataDynamics.ActiveReports.Line
	Private TextBox2 As DataDynamics.ActiveReports.TextBox
	Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptOptikotAnaMaria))
            Me.Detail = New DataDynamics.ActiveReports.Detail
            Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader
            Me.ReportFooter = New DataDynamics.ActiveReports.ReportFooter
            Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
            Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
            Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader
            Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
            Me.lblTitulo = New DataDynamics.ActiveReports.Label
            Me.TextBox = New DataDynamics.ActiveReports.TextBox
            Me.Line2 = New DataDynamics.ActiveReports.Line
            Me.txtTrat = New DataDynamics.ActiveReports.TextBox
            Me.txtQuant = New DataDynamics.ActiveReports.TextBox
            Me.Line = New DataDynamics.ActiveReports.Line
            Me.txtOpt = New DataDynamics.ActiveReports.TextBox
            Me.quantOpt = New DataDynamics.ActiveReports.TextBox
            Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
            Me.quantEasy = New DataDynamics.ActiveReports.TextBox
            Me.Line1 = New DataDynamics.ActiveReports.Line
            Me.TextBox2 = New DataDynamics.ActiveReports.TextBox
            CType(Me.lblTitulo,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtTrat,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtQuant,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtOpt,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.quantOpt,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox1,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.quantEasy,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox2,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
            '
            'Detail
            '
            Me.Detail.ColumnSpacing = 0!
            Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtTrat, Me.txtQuant, Me.Line})
            Me.Detail.Height = 0.2388889!
            Me.Detail.Name = "Detail"
            '
            'ReportHeader
            '
            Me.ReportHeader.Height = 0!
            Me.ReportHeader.Name = "ReportHeader"
            '
            'ReportFooter
            '
            Me.ReportFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtOpt, Me.quantOpt, Me.TextBox1, Me.quantEasy, Me.Line1, Me.TextBox2})
            Me.ReportFooter.Height = 0.9263889!
            Me.ReportFooter.Name = "ReportFooter"
            '
            'PageHeader
            '
            Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblTitulo})
            Me.PageHeader.Height = 0.3645833!
            Me.PageHeader.Name = "PageHeader"
            '
            'PageFooter
            '
            Me.PageFooter.Height = 0!
            Me.PageFooter.Name = "PageFooter"
            '
            'GroupHeader1
            '
            Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox, Me.Line2})
            Me.GroupHeader1.DataField = "nome_cliente"
            Me.GroupHeader1.Height = 0.2597222!
            Me.GroupHeader1.Name = "GroupHeader1"
            '
            'GroupFooter1
            '
            Me.GroupFooter1.Height = 0!
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
            Me.lblTitulo.Height = 0.1875!
            Me.lblTitulo.HyperLink = Nothing
            Me.lblTitulo.Left = 0.0625!
            Me.lblTitulo.Name = "lblTitulo"
            Me.lblTitulo.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; "
            Me.lblTitulo.Text = "Label"
            Me.lblTitulo.Top = 0.0625!
            Me.lblTitulo.Width = 6.375!
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
            Me.TextBox.DataField = "nome_cliente"
            Me.TextBox.Height = 0.2!
            Me.TextBox.Left = 0.25!
            Me.TextBox.Name = "TextBox"
            Me.TextBox.Style = ""
            Me.TextBox.Text = "TextBox"
            Me.TextBox.Top = 0!
            Me.TextBox.Width = 2.5625!
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
            Me.Line2.Left = 0.25!
            Me.Line2.LineWeight = 1!
            Me.Line2.Name = "Line2"
            Me.Line2.Top = 0.1875!
            Me.Line2.Width = 2.625!
            Me.Line2.X1 = 0.25!
            Me.Line2.X2 = 2.875!
            Me.Line2.Y1 = 0.1875!
            Me.Line2.Y2 = 0.1875!
            '
            'txtTrat
            '
            Me.txtTrat.Border.BottomColor = System.Drawing.Color.Black
            Me.txtTrat.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtTrat.Border.LeftColor = System.Drawing.Color.Black
            Me.txtTrat.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtTrat.Border.RightColor = System.Drawing.Color.Black
            Me.txtTrat.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtTrat.Border.TopColor = System.Drawing.Color.Black
            Me.txtTrat.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtTrat.DataField = "produto"
            Me.txtTrat.Height = 0.2!
            Me.txtTrat.Left = 1.114583!
            Me.txtTrat.Name = "txtTrat"
            Me.txtTrat.Style = "text-align: right; "
            Me.txtTrat.Text = "TextBox"
            Me.txtTrat.Top = 0!
            Me.txtTrat.Width = 2.1875!
            '
            'txtQuant
            '
            Me.txtQuant.Border.BottomColor = System.Drawing.Color.Black
            Me.txtQuant.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtQuant.Border.LeftColor = System.Drawing.Color.Black
            Me.txtQuant.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtQuant.Border.RightColor = System.Drawing.Color.Black
            Me.txtQuant.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtQuant.Border.TopColor = System.Drawing.Color.Black
            Me.txtQuant.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtQuant.DataField = "quantidade"
            Me.txtQuant.Height = 0.2!
            Me.txtQuant.Left = 3.4375!
            Me.txtQuant.Name = "txtQuant"
            Me.txtQuant.Style = "text-align: right; "
            Me.txtQuant.Text = "TextBox"
            Me.txtQuant.Top = 0!
            Me.txtQuant.Width = 0.375!
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
            Me.Line.Left = 1.1875!
            Me.Line.LineWeight = 1!
            Me.Line.Name = "Line"
            Me.Line.Top = 0!
            Me.Line.Width = 2.625!
            Me.Line.X1 = 1.1875!
            Me.Line.X2 = 3.8125!
            Me.Line.Y1 = 0!
            Me.Line.Y2 = 0!
            '
            'txtOpt
            '
            Me.txtOpt.Border.BottomColor = System.Drawing.Color.Black
            Me.txtOpt.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtOpt.Border.LeftColor = System.Drawing.Color.Black
            Me.txtOpt.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtOpt.Border.RightColor = System.Drawing.Color.Black
            Me.txtOpt.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtOpt.Border.TopColor = System.Drawing.Color.Black
            Me.txtOpt.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtOpt.Height = 0.2!
            Me.txtOpt.Left = 1.3125!
            Me.txtOpt.Name = "txtOpt"
            Me.txtOpt.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
            Me.txtOpt.Text = "OPTIKOT"
            Me.txtOpt.Top = 0.265625!
            Me.txtOpt.Width = 2.1875!
            '
            'quantOpt
            '
            Me.quantOpt.Border.BottomColor = System.Drawing.Color.Black
            Me.quantOpt.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.quantOpt.Border.LeftColor = System.Drawing.Color.Black
            Me.quantOpt.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.quantOpt.Border.RightColor = System.Drawing.Color.Black
            Me.quantOpt.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.quantOpt.Border.TopColor = System.Drawing.Color.Black
            Me.quantOpt.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.quantOpt.Height = 0.2!
            Me.quantOpt.Left = 3.635417!
            Me.quantOpt.Name = "quantOpt"
            Me.quantOpt.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
            Me.quantOpt.Text = "TextBox"
            Me.quantOpt.Top = 0.265625!
            Me.quantOpt.Width = 0.375!
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
            Me.TextBox1.Height = 0.2!
            Me.TextBox1.Left = 1.3125!
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
            Me.TextBox1.Text = "OPTIKOT EASY CLEAN"
            Me.TextBox1.Top = 0.528125!
            Me.TextBox1.Width = 2.1875!
            '
            'quantEasy
            '
            Me.quantEasy.Border.BottomColor = System.Drawing.Color.Black
            Me.quantEasy.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.quantEasy.Border.LeftColor = System.Drawing.Color.Black
            Me.quantEasy.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.quantEasy.Border.RightColor = System.Drawing.Color.Black
            Me.quantEasy.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.quantEasy.Border.TopColor = System.Drawing.Color.Black
            Me.quantEasy.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.quantEasy.Height = 0.2!
            Me.quantEasy.Left = 3.635417!
            Me.quantEasy.Name = "quantEasy"
            Me.quantEasy.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
            Me.quantEasy.Text = "TextBox"
            Me.quantEasy.Top = 0.528125!
            Me.quantEasy.Width = 0.375!
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
            Me.Line1.Left = 1.25!
            Me.Line1.LineWeight = 1!
            Me.Line1.Name = "Line1"
            Me.Line1.Top = 0!
            Me.Line1.Width = 2.6875!
            Me.Line1.X1 = 1.25!
            Me.Line1.X2 = 3.9375!
            Me.Line1.Y1 = 0!
            Me.Line1.Y2 = 0!
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
            Me.TextBox2.Height = 0.2!
            Me.TextBox2.Left = 1.25!
            Me.TextBox2.Name = "TextBox2"
            Me.TextBox2.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; "
            Me.TextBox2.Text = "Totais"
            Me.TextBox2.Top = 0.015625!
            Me.TextBox2.Width = 2.75!
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
            CType(Me.TextBox,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtTrat,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtQuant,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtOpt,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.quantOpt,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox1,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.quantEasy,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox2,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me,System.ComponentModel.ISupportInitialize).EndInit
        
	End Sub

	#End Region
    Public titulo As String
    Dim opt As Double = 0
    Dim easy As Double = 0
    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        lblTitulo.Text = titulo
    End Sub

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        If txtTrat.Text = "OPTIKOT" Then opt = opt + txtQuant.Text
        If txtTrat.Text = "Optikot Easy Clean" Then easy = easy + txtQuant.Text
    End Sub
    Private Sub ReportFooter_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportFooter.Format
        quantOpt.Text = opt
        quantEasy.Text = easy
    End Sub
End Class
