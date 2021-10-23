Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class rptCodBarraAndamentos
    Inherits DataDynamics.ActiveReports.ActiveReport3
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub
#Region "ActiveReports Designer generated code"
    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader = Nothing
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
	Private Barcode As DataDynamics.ActiveReports.Barcode
	Private Label1 As DataDynamics.ActiveReports.Label
	Private TextBox As DataDynamics.ActiveReports.TextBox
	Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptCodBarraAndamentos))
            Me.Detail = New DataDynamics.ActiveReports.Detail
            Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
            Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
            Me.Barcode = New DataDynamics.ActiveReports.Barcode
            Me.Label1 = New DataDynamics.ActiveReports.Label
            Me.TextBox = New DataDynamics.ActiveReports.TextBox
            CType(Me.Label1,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me.TextBox,System.ComponentModel.ISupportInitialize).BeginInit
            CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
            '
            'Detail
            '
            Me.Detail.ColumnCount = 4
            Me.Detail.ColumnSpacing = 0!
            Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Barcode, Me.Label1, Me.TextBox})
            Me.Detail.Height = 0.9166667!
            Me.Detail.KeepTogether = true
            Me.Detail.Name = "Detail"
            '
            'PageHeader
            '
            Me.PageHeader.Height = 0!
            Me.PageHeader.Name = "PageHeader"
            '
            'PageFooter
            '
            Me.PageFooter.Height = 0.25!
            Me.PageFooter.Name = "PageFooter"
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
            Me.Barcode.DataField = "cod_andamento"
            Me.Barcode.Font = New System.Drawing.Font("Courier New", 8!)
            Me.Barcode.Height = 0.5!
            Me.Barcode.Left = 0.0625!
            Me.Barcode.Name = "Barcode"
            Me.Barcode.Style = DataDynamics.ActiveReports.BarCodeStyle.Code_128_A
            Me.Barcode.Top = 0.1875!
            Me.Barcode.Width = 1.5!
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
            Me.Label1.DataField = "cod_andamento"
            Me.Label1.Height = 0.2!
            Me.Label1.HyperLink = Nothing
            Me.Label1.Left = 0.25!
            Me.Label1.Name = "Label1"
            Me.Label1.Style = "ddo-char-set: 1; font-weight: bold; font-size: 9pt; "
            Me.Label1.Text = "Label"
            Me.Label1.Top = 0.6875!
            Me.Label1.Width = 1!
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
            Me.TextBox.DataField = "andamento"
            Me.TextBox.Height = 0.2!
            Me.TextBox.Left = 0!
            Me.TextBox.Name = "TextBox"
            Me.TextBox.Style = "ddo-char-set: 1; font-size: 8pt; font-family: Times New Roman; "
            Me.TextBox.Text = "TextBox"
            Me.TextBox.Top = 0!
            Me.TextBox.Width = 1.75!
            '
            'ActiveReport31
            '
            Me.MasterReport = false
            Me.PageSettings.PaperHeight = 11.69!
            Me.PageSettings.PaperWidth = 8.27!
            Me.PrintWidth = 7.135417!
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
            CType(Me.Label1,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me.TextBox,System.ComponentModel.ISupportInitialize).EndInit
            CType(Me,System.ComponentModel.ISupportInitialize).EndInit
        
	End Sub

#End Region

    Private Sub PageFooter_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageFooter.Format

    End Sub

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format

    End Sub
End Class
