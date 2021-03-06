Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class rptPedido_X_PedidoBalcao
Inherits DataDynamics.ActiveReports.ActiveReport3
	Public Sub New()
	MyBase.New()
		InitializeComponent()
	End Sub
	#Region "ActiveReports Designer generated code"
    Private WithEvents ReportHeader As DataDynamics.ActiveReports.ReportHeader = Nothing
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
    Private WithEvents ReportFooter As DataDynamics.ActiveReports.ReportFooter = Nothing
	Private Label1 As DataDynamics.ActiveReports.Label
	Private Label2 As DataDynamics.ActiveReports.Label
	Private Label As DataDynamics.ActiveReports.Label
	Private Label4 As DataDynamics.ActiveReports.Label
	Private TextBox3 As DataDynamics.ActiveReports.TextBox
	Private TextBox As DataDynamics.ActiveReports.TextBox
	Private TextBox1 As DataDynamics.ActiveReports.TextBox
	Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptPedido_X_PedidoBalcao))
            Me.Detail = New DataDynamics.ActiveReports.Detail
            Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader
            Me.ReportFooter = New DataDynamics.ActiveReports.ReportFooter
            Me.Label1 = New DataDynamics.ActiveReports.Label
            Me.Label2 = New DataDynamics.ActiveReports.Label
            Me.Label = New DataDynamics.ActiveReports.Label
            Me.Label4 = New DataDynamics.ActiveReports.Label
            Me.TextBox3 = New DataDynamics.ActiveReports.TextBox
            Me.TextBox = New DataDynamics.ActiveReports.TextBox
            Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
            CType(Me.Label1,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label2,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label4,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox3,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox1,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
            '
            'Detail
            '
            Me.Detail.ColumnSpacing = 0!
            Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox3, Me.TextBox, Me.TextBox1})
            Me.Detail.Height = 0.21875!
            Me.Detail.Name = "Detail"
            '
            'ReportHeader
            '
            Me.ReportHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label1, Me.Label2, Me.Label, Me.Label4})
            Me.ReportHeader.Height = 0.4375!
            Me.ReportHeader.Name = "ReportHeader"
            '
            'ReportFooter
            '
            Me.ReportFooter.Height = 0.25!
            Me.ReportFooter.Name = "ReportFooter"
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
            Me.Label1.Left = 3.9375!
            Me.Label1.Name = "Label1"
            Me.Label1.Style = "ddo-char-set: 1; text-align: center; font-size: 8pt; "
            Me.Label1.Text = "Quantidade"
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
            Me.Label2.Height = 0.1875!
            Me.Label2.HyperLink = Nothing
            Me.Label2.Left = 4.75!
            Me.Label2.Name = "Label2"
            Me.Label2.Style = "ddo-char-set: 1; text-align: left; font-size: 8pt; "
            Me.Label2.Text = "N? Pedido"
            Me.Label2.Top = 0.25!
            Me.Label2.Width = 0.5625!
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
            Me.Label.Left = 0!
            Me.Label.Name = "Label"
            Me.Label.Style = "ddo-char-set: 1; font-size: 8pt; "
            Me.Label.Text = "Produto"
            Me.Label.Top = 0.25!
            Me.Label.Width = 1!
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
            Me.Label4.Text = "Produtos do Pedido e seus pedidos de Balc?o"
            Me.Label4.Top = 0.0625!
            Me.Label4.Width = 3.6875!
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
            Me.TextBox3.DataField = "num_pedido"
            Me.TextBox3.Height = 0.1875!
            Me.TextBox3.Left = 4.75!
            Me.TextBox3.Name = "TextBox3"
            Me.TextBox3.Style = "ddo-char-set: 1; text-align: center; font-size: 8pt; "
            Me.TextBox3.Text = "TextBox"
            Me.TextBox3.Top = 0!
            Me.TextBox3.Width = 0.5625!
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
            Me.TextBox.Left = 0!
            Me.TextBox.Name = "TextBox"
            Me.TextBox.Style = "ddo-char-set: 1; font-size: 8pt; "
            Me.TextBox.Text = "TextBox"
            Me.TextBox.Top = 0!
            Me.TextBox.Width = 3.8125!
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
            Me.TextBox1.DataField = "atendido"
            Me.TextBox1.Height = 0.1875!
            Me.TextBox1.Left = 3.9375!
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Style = "ddo-char-set: 1; text-align: center; font-size: 8pt; "
            Me.TextBox1.Text = "TextBox"
            Me.TextBox1.Top = 0!
            Me.TextBox1.Width = 0.5625!
            '
            'ActiveReport31
            '
            Me.MasterReport = false
            Me.PageSettings.PaperHeight = 11.69!
            Me.PageSettings.PaperWidth = 8.27!
            Me.PrintWidth = 5.354167!
            Me.Sections.Add(Me.ReportHeader)
            Me.Sections.Add(Me.Detail)
            Me.Sections.Add(Me.ReportFooter)
            Me.StyleSheet.Add(New DDCssLib.StyleSheetRule(resources.GetString("$this.StyleSheet"), "Normal"))
            Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo"& _ 
                        "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading1", "Normal"))
            Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei"& _ 
                        "ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading2", "Normal"))
            Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo"& _ 
                        "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading3", "Normal"))
            CType(Me.Label1,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label2,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label4,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox3,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox1,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me,System.ComponentModel.ISupportInitialize).EndInit
        
	End Sub

	#End Region
End Class
