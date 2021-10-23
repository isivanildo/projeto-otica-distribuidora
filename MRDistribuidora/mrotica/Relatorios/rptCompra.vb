Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class rptCompra
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
	Private Label2 As DataDynamics.ActiveReports.Label
	Private Label3 As DataDynamics.ActiveReports.Label
	Private Label4 As DataDynamics.ActiveReports.Label
	Private TextBox As DataDynamics.ActiveReports.TextBox
	Private txtProduto As DataDynamics.ActiveReports.TextBox
	Private TextBox2 As DataDynamics.ActiveReports.TextBox
	Private TextBox3 As DataDynamics.ActiveReports.TextBox
	Private TextBox4 As DataDynamics.ActiveReports.TextBox
	Private txtDiferenca As DataDynamics.ActiveReports.TextBox
	Private TextBox1 As DataDynamics.ActiveReports.TextBox
	Private TextBox5 As DataDynamics.ActiveReports.TextBox
	Private txtTotalDiferenca As DataDynamics.ActiveReports.TextBox
	Private Line As DataDynamics.ActiveReports.Line
	Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptCompra))
            Me.Detail = New DataDynamics.ActiveReports.Detail
            Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
            Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
            Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader
            Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
            Me.Label = New DataDynamics.ActiveReports.Label
            Me.Label1 = New DataDynamics.ActiveReports.Label
            Me.Label2 = New DataDynamics.ActiveReports.Label
            Me.Label3 = New DataDynamics.ActiveReports.Label
            Me.Label4 = New DataDynamics.ActiveReports.Label
            Me.TextBox = New DataDynamics.ActiveReports.TextBox
            Me.txtProduto = New DataDynamics.ActiveReports.TextBox
            Me.TextBox2 = New DataDynamics.ActiveReports.TextBox
            Me.TextBox3 = New DataDynamics.ActiveReports.TextBox
            Me.TextBox4 = New DataDynamics.ActiveReports.TextBox
            Me.txtDiferenca = New DataDynamics.ActiveReports.TextBox
            Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
            Me.TextBox5 = New DataDynamics.ActiveReports.TextBox
            Me.txtTotalDiferenca = New DataDynamics.ActiveReports.TextBox
            Me.Line = New DataDynamics.ActiveReports.Line
            CType(Me.Label,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label1,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label2,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label3,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.Label4,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtProduto,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox2,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox3,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox4,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtDiferenca,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox1,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox5,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.txtTotalDiferenca,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
            '
            'Detail
            '
            Me.Detail.ColumnSpacing = 0!
            Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox, Me.txtProduto, Me.TextBox2, Me.TextBox3, Me.TextBox4, Me.txtDiferenca})
            Me.Detail.Height = 0.2076389!
            Me.Detail.Name = "Detail"
            '
            'PageHeader
            '
            Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label, Me.Label1, Me.Label2, Me.Label3, Me.Label4})
            Me.PageHeader.Height = 0.28125!
            Me.PageHeader.Name = "PageHeader"
            '
            'PageFooter
            '
            Me.PageFooter.Height = 0!
            Me.PageFooter.Name = "PageFooter"
            '
            'GroupHeader1
            '
            Me.GroupHeader1.Height = 0!
            Me.GroupHeader1.Name = "GroupHeader1"
            '
            'GroupFooter1
            '
            Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox1, Me.TextBox5, Me.txtTotalDiferenca, Me.Line})
            Me.GroupFooter1.Height = 0.25!
            Me.GroupFooter1.Name = "GroupFooter1"
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
            Me.Label.Left = 0.3125!
            Me.Label.Name = "Label"
            Me.Label.Style = "ddo-char-set: 1; font-weight: bold; font-size: 9pt; "
            Me.Label.Text = "Produto"
            Me.Label.Top = 0.125!
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
            Me.Label1.Height = 0.1375!
            Me.Label1.HyperLink = Nothing
            Me.Label1.Left = 3.75!
            Me.Label1.Name = "Label1"
            Me.Label1.Style = "ddo-char-set: 1; font-weight: bold; font-size: 9pt; "
            Me.Label1.Text = "Quant"
            Me.Label1.Top = 0.125!
            Me.Label1.Width = 0.4375!
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
            Me.Label2.Left = 4.25!
            Me.Label2.Name = "Label2"
            Me.Label2.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 9pt; "
            Me.Label2.Text = "V. Tabela"
            Me.Label2.Top = 0.125!
            Me.Label2.Width = 0.625!
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
            Me.Label3.Left = 4.9375!
            Me.Label3.Name = "Label3"
            Me.Label3.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 9pt; "
            Me.Label3.Text = "V. Nota"
            Me.Label3.Top = 0.125!
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
            Me.Label4.Height = 0.1375!
            Me.Label4.HyperLink = Nothing
            Me.Label4.Left = 5.75!
            Me.Label4.Name = "Label4"
            Me.Label4.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 9pt; "
            Me.Label4.Text = "Diferenca"
            Me.Label4.Top = 0.125!
            Me.Label4.Width = 0.625!
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
            Me.TextBox.DataField = "Item"
            Me.TextBox.Height = 0.1875!
            Me.TextBox.Left = 0!
            Me.TextBox.Name = "TextBox"
            Me.TextBox.Style = "ddo-char-set: 1; text-align: right; font-size: 9pt; "
            Me.TextBox.Text = "TextBox"
            Me.TextBox.Top = -0.0078125!
            Me.TextBox.Width = 0.25!
            '
            'txtProduto
            '
            Me.txtProduto.Border.BottomColor = System.Drawing.Color.Black
            Me.txtProduto.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtProduto.Border.LeftColor = System.Drawing.Color.Black
            Me.txtProduto.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtProduto.Border.RightColor = System.Drawing.Color.Black
            Me.txtProduto.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtProduto.Border.TopColor = System.Drawing.Color.Black
            Me.txtProduto.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtProduto.DataField = "Produto"
            Me.txtProduto.Height = 0.171875!
            Me.txtProduto.Left = 0.3125!
            Me.txtProduto.Name = "txtProduto"
            Me.txtProduto.Style = "ddo-char-set: 1; font-size: 9pt; "
            Me.txtProduto.Text = "TextBox"
            Me.txtProduto.Top = 0!
            Me.txtProduto.Width = 3.375!
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
            Me.TextBox2.Left = 3.90625!
            Me.TextBox2.Name = "TextBox2"
            Me.TextBox2.Style = "ddo-char-set: 1; text-align: center; font-size: 9pt; "
            Me.TextBox2.Text = "TextBox"
            Me.TextBox2.Top = 0!
            Me.TextBox2.Width = 0.25!
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
            Me.TextBox3.DataField = "preco"
            Me.TextBox3.Height = 0.1875!
            Me.TextBox3.Left = 4.239583!
            Me.TextBox3.Name = "TextBox3"
            Me.TextBox3.OutputFormat = resources.GetString("TextBox3.OutputFormat")
            Me.TextBox3.Style = "ddo-char-set: 1; text-align: right; font-size: 9pt; "
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
            Me.TextBox4.DataField = "preco_real"
            Me.TextBox4.Height = 0.1875!
            Me.TextBox4.Left = 4.927083!
            Me.TextBox4.Name = "TextBox4"
            Me.TextBox4.OutputFormat = resources.GetString("TextBox4.OutputFormat")
            Me.TextBox4.Style = "ddo-char-set: 1; text-align: right; font-size: 9pt; "
            Me.TextBox4.Text = "TextBox"
            Me.TextBox4.Top = 0!
            Me.TextBox4.Width = 0.625!
            '
            'txtDiferenca
            '
            Me.txtDiferenca.Border.BottomColor = System.Drawing.Color.Black
            Me.txtDiferenca.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtDiferenca.Border.LeftColor = System.Drawing.Color.Black
            Me.txtDiferenca.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtDiferenca.Border.RightColor = System.Drawing.Color.Black
            Me.txtDiferenca.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtDiferenca.Border.TopColor = System.Drawing.Color.Black
            Me.txtDiferenca.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtDiferenca.DataField = "diferenca"
            Me.txtDiferenca.Height = 0.1875!
            Me.txtDiferenca.Left = 5.739583!
            Me.txtDiferenca.Name = "txtDiferenca"
            Me.txtDiferenca.OutputFormat = resources.GetString("txtDiferenca.OutputFormat")
            Me.txtDiferenca.Style = "ddo-char-set: 1; text-align: right; font-size: 9pt; "
            Me.txtDiferenca.Text = "TextBox"
            Me.txtDiferenca.Top = 0!
            Me.txtDiferenca.Width = 0.625!
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
            Me.TextBox1.DataField = "preco_real"
            Me.TextBox1.Height = 0.1875!
            Me.TextBox1.Left = 4.9375!
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.OutputFormat = resources.GetString("TextBox1.OutputFormat")
            Me.TextBox1.Style = "ddo-char-set: 1; text-align: right; font-size: 9pt; "
            Me.TextBox1.SummaryGroup = "GroupHeader1"
            Me.TextBox1.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
            Me.TextBox1.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
            Me.TextBox1.Text = "TextBox"
            Me.TextBox1.Top = 0!
            Me.TextBox1.Width = 0.625!
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
            Me.TextBox5.DataField = "preco"
            Me.TextBox5.Height = 0.1875!
            Me.TextBox5.Left = 4.25!
            Me.TextBox5.Name = "TextBox5"
            Me.TextBox5.OutputFormat = resources.GetString("TextBox5.OutputFormat")
            Me.TextBox5.Style = "ddo-char-set: 1; text-align: right; font-size: 9pt; "
            Me.TextBox5.SummaryGroup = "GroupHeader1"
            Me.TextBox5.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
            Me.TextBox5.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
            Me.TextBox5.Text = "TextBox"
            Me.TextBox5.Top = 0!
            Me.TextBox5.Width = 0.625!
            '
            'txtTotalDiferenca
            '
            Me.txtTotalDiferenca.Border.BottomColor = System.Drawing.Color.Black
            Me.txtTotalDiferenca.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtTotalDiferenca.Border.LeftColor = System.Drawing.Color.Black
            Me.txtTotalDiferenca.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtTotalDiferenca.Border.RightColor = System.Drawing.Color.Black
            Me.txtTotalDiferenca.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtTotalDiferenca.Border.TopColor = System.Drawing.Color.Black
            Me.txtTotalDiferenca.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.txtTotalDiferenca.DataField = "diferenca"
            Me.txtTotalDiferenca.Height = 0.1875!
            Me.txtTotalDiferenca.Left = 5.75!
            Me.txtTotalDiferenca.Name = "txtTotalDiferenca"
            Me.txtTotalDiferenca.OutputFormat = resources.GetString("txtTotalDiferenca.OutputFormat")
            Me.txtTotalDiferenca.Style = "ddo-char-set: 1; text-align: right; font-size: 9pt; "
            Me.txtTotalDiferenca.SummaryGroup = "GroupHeader1"
            Me.txtTotalDiferenca.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
            Me.txtTotalDiferenca.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
            Me.txtTotalDiferenca.Text = "TextBox"
            Me.txtTotalDiferenca.Top = 0!
            Me.txtTotalDiferenca.Width = 0.625!
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
            Me.Line.Left = 4.25!
            Me.Line.LineWeight = 1!
            Me.Line.Name = "Line"
            Me.Line.Top = 0!
            Me.Line.Width = 2.1875!
            Me.Line.X1 = 4.25!
            Me.Line.X2 = 6.4375!
            Me.Line.Y1 = 0!
            Me.Line.Y2 = 0!
            '
            'ActiveReport31
            '
            Me.MasterReport = false
            Me.PageSettings.PaperHeight = 11.69!
            Me.PageSettings.PaperWidth = 8.27!
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
            CType(Me.Label,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label1,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label2,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label3,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.Label4,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtProduto,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox2,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox3,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox4,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtDiferenca,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox1,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox5,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.txtTotalDiferenca,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me,System.ComponentModel.ISupportInitialize).EndInit
        
	End Sub

	#End Region

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        If CDbl(txtDiferenca.Text) > 0 Then
            txtDiferenca.ForeColor = Color.Red
        End If

    End Sub

    Private Sub GroupFooter1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupFooter1.Format
        If CDbl(txtTotalDiferenca.Text) > 0 Then
            txtTotalDiferenca.ForeColor = Color.Red
        End If
    End Sub
End Class
