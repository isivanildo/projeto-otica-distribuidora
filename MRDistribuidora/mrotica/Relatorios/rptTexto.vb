Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class rptTexto
    Inherits DataDynamics.ActiveReports.ActiveReport3
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub
#Region "ActiveReports Designer generated code"
    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader = Nothing
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
    Private Titulo As DataDynamics.ActiveReports.Label
    Private TextBox As DataDynamics.ActiveReports.TextBox
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptOSsRetiradas))
        Me.Detail = New DataDynamics.ActiveReports.Detail
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
        Me.Titulo = New DataDynamics.ActiveReports.Label
        Me.TextBox = New DataDynamics.ActiveReports.TextBox
        CType(Me.Titulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox})
        Me.Detail.Height = 0.2597222!
        Me.Detail.Name = "Detail"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Titulo})
        Me.PageHeader.Height = 0.25!
        Me.PageHeader.Name = "PageHeader"
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0.03125!
        Me.PageFooter.Name = "PageFooter"
        '
        'Titulo
        '
        Me.Titulo.Border.BottomColor = System.Drawing.Color.Black
        Me.Titulo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Titulo.Border.LeftColor = System.Drawing.Color.Black
        Me.Titulo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Titulo.Border.RightColor = System.Drawing.Color.Black
        Me.Titulo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Titulo.Border.TopColor = System.Drawing.Color.Black
        Me.Titulo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Titulo.Height = 0.1875!
        Me.Titulo.HyperLink = Nothing
        Me.Titulo.Left = 0.1875!
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; "
        Me.Titulo.Text = "Label"
        Me.Titulo.Top = 0.0!
        Me.Titulo.Width = 6.75!
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
        Me.TextBox.Height = 0.2!
        Me.TextBox.Left = 0.0625!
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Style = ""
        Me.TextBox.Text = "TextBox"
        Me.TextBox.Top = 0.0!
        Me.TextBox.Width = 7.0!
        '
        'ActiveReport31
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.69!
        Me.PageSettings.PaperWidth = 8.27!
        Me.PrintWidth = 7.09375!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule(resources.GetString("$this.StyleSheet"), "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" & _
                    "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei" & _
                    "ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" & _
                    "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading3", "Normal"))
        CType(Me.Titulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region
    Public texto As String
    Public strTitulo As String
    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        Titulo.Text = strTitulo
    End Sub

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        TextBox.Text = texto
    End Sub
End Class
