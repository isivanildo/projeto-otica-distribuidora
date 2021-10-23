Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports mrotica_util
Public Class rptPedidoBalcao2vias
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
	Private subItens As DataDynamics.ActiveReports.SubReport
    Private sub2Via As DataDynamics.ActiveReports.SubReport
    Friend WithEvents SubReport1 As DataDynamics.ActiveReports.SubReport
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptPedidoBalcao2vias))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.subItens = New DataDynamics.ActiveReports.SubReport()
        Me.sub2Via = New DataDynamics.ActiveReports.SubReport()
        Me.SubReport1 = New DataDynamics.ActiveReports.SubReport()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader()
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.subItens, Me.sub2Via, Me.SubReport1})
        Me.Detail.Height = 0.5729167!
        Me.Detail.Name = "Detail"
        '
        'subItens
        '
        Me.subItens.Border.BottomColor = System.Drawing.Color.Black
        Me.subItens.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.subItens.Border.LeftColor = System.Drawing.Color.Black
        Me.subItens.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.subItens.Border.RightColor = System.Drawing.Color.Black
        Me.subItens.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.subItens.Border.TopColor = System.Drawing.Color.Black
        Me.subItens.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.subItens.CloseBorder = False
        Me.subItens.Height = 0.1875!
        Me.subItens.Left = 0.0!
        Me.subItens.Name = "subItens"
        Me.subItens.Report = Nothing
        Me.subItens.Top = 0.0!
        Me.subItens.Width = 7.5625!
        '
        'sub2Via
        '
        Me.sub2Via.Border.BottomColor = System.Drawing.Color.Black
        Me.sub2Via.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.sub2Via.Border.LeftColor = System.Drawing.Color.Black
        Me.sub2Via.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.sub2Via.Border.RightColor = System.Drawing.Color.Black
        Me.sub2Via.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.sub2Via.Border.TopColor = System.Drawing.Color.Black
        Me.sub2Via.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.sub2Via.CloseBorder = False
        Me.sub2Via.Height = 0.1875!
        Me.sub2Via.Left = 0.0!
        Me.sub2Via.Name = "sub2Via"
        Me.sub2Via.Report = Nothing
        Me.sub2Via.Top = 0.1875!
        Me.sub2Via.Width = 7.5625!
        '
        'SubReport1
        '
        Me.SubReport1.Border.BottomColor = System.Drawing.Color.Black
        Me.SubReport1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.SubReport1.Border.LeftColor = System.Drawing.Color.Black
        Me.SubReport1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.SubReport1.Border.RightColor = System.Drawing.Color.Black
        Me.SubReport1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.SubReport1.Border.TopColor = System.Drawing.Color.Black
        Me.SubReport1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.SubReport1.CloseBorder = False
        Me.SubReport1.Height = 0.1875!
        Me.SubReport1.Left = 0.0!
        Me.SubReport1.Name = "SubReport1"
        Me.SubReport1.Report = Nothing
        Me.SubReport1.Top = 0.375!
        Me.SubReport1.Width = 7.5625!
        '
        'PageHeader
        '
        Me.PageHeader.Height = 0.0!
        Me.PageHeader.Name = "PageHeader"
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Height = 0.01041667!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Height = 0.0!
        Me.GroupFooter1.KeepTogether = True
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'rptPedidoBalcao2vias
        '
        Me.MasterReport = False
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.583333!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule(resources.GetString("$this.StyleSheet"), "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" & _
            "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei" & _
            "ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" & _
            "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading3", "Normal"))
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

	#End Region
    Public r As New rptPedido
    Public r2 As New rptPedido
    Public r3 As New rptPedido
    Public Total As String
    Public Prod, Serv As String
    Public n_pedido As String
    Public Vendedor As String
    Public cliente As String
    Public cod_cliente As String
    Public data As String
    Public forma As String
    Dim d As New dados
    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        subItens.Report = r
        sub2Via.Report = r2
        SubReport1.Report = r3
    End Sub

    Private Function os(ByVal n_pedido As Integer) As String
        Dim sql As String
        Dim tt As New DataTable
        sql = "select cod_os from os where num_pedido = " & n_pedido & ""
        d.carrega_Tabela(sql, tt)
        If tt.Rows.Count > 0 Then
            Return tt.Rows(0)("cod_os")
        End If
    End Function
End Class
