Imports mrotica_util
Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class rptDetPedido
Inherits DataDynamics.ActiveReports.ActiveReport3
	Public Sub New()
	MyBase.New()
		InitializeComponent()
	End Sub
	#Region "ActiveReports Designer generated code"
    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader = Nothing
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
	Private subServ As DataDynamics.ActiveReports.SubReport
	Private subItens As DataDynamics.ActiveReports.SubReport
	Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptDetPedido))
            Me.Detail = New DataDynamics.ActiveReports.Detail
            Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
            Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
            Me.subServ = New DataDynamics.ActiveReports.SubReport
            Me.subItens = New DataDynamics.ActiveReports.SubReport
            CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
            '
            'Detail
            '
            Me.Detail.ColumnSpacing = 0!
            Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.subServ, Me.subItens})
            Me.Detail.Height = 0.2708333!
            Me.Detail.Name = "Detail"
            '
            'PageHeader
            '
            Me.PageHeader.Height = 0!
            Me.PageHeader.Name = "PageHeader"
            '
            'PageFooter
            '
            Me.PageFooter.Height = 0!
            Me.PageFooter.Name = "PageFooter"
            '
            'subServ
            '
            Me.subServ.Border.BottomColor = System.Drawing.Color.Black
            Me.subServ.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.subServ.Border.LeftColor = System.Drawing.Color.Black
            Me.subServ.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.subServ.Border.RightColor = System.Drawing.Color.Black
            Me.subServ.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.subServ.Border.TopColor = System.Drawing.Color.Black
            Me.subServ.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
            Me.subServ.CloseBorder = false
            Me.subServ.Height = 0.0625!
            Me.subServ.Left = 0.125!
            Me.subServ.Name = "subServ"
            Me.subServ.Report = Nothing
            Me.subServ.Top = 0.1875!
            Me.subServ.Width = 7!
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
            Me.subItens.CloseBorder = false
            Me.subItens.Height = 0.1875!
            Me.subItens.Left = 0.125!
            Me.subItens.Name = "subItens"
            Me.subItens.Report = Nothing
            Me.subItens.Top = 0!
            Me.subItens.Width = 7!
            '
            'ActiveReport31
            '
            Me.MasterReport = false
            Me.PageSettings.PaperHeight = 11.69!
            Me.PageSettings.PaperWidth = 8.27!
            Me.PrintWidth = 7.125!
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
            CType(Me,System.ComponentModel.ISupportInitialize).EndInit
        
	End Sub

	#End Region
    Public num_pedido, id_filial As Integer
    Dim pedido As New objPedidoBalcao
    Private Sub rptDetPedido_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        pedido.carrega_pedido(num_pedido, id_filial)
        Dim rItens As New rptItensPedido
        Dim rServ As New rptServPedido
        If pedido.lista_itens(pedido.num_pedido, pedido.id_filial, False).Rows.Count > 0 Then
            rItens.tb = pedido.lista_itens(pedido.num_pedido, pedido.id_filial, False)
            Me.subItens.Report = rItens
        End If
        If pedido.lista_servicos(pedido.num_pedido, pedido.id_filial).Rows.Count > 0 Then
            rServ.tb = pedido.lista_servicos(pedido.num_pedido, pedido.id_filial)
            Me.subServ.Report = rServ
        End If
    End Sub
    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format

    End Sub
End Class
