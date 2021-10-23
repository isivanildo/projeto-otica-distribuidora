Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports mrotica_util
Public Class rptEstornoCreditoEstoque
    Inherits DataDynamics.ActiveReports.ActiveReport3
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub
#Region "ActiveReports Designer generated code"
    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader = Nothing
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
    Friend WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label1 As DataDynamics.ActiveReports.Label
    Friend WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents TextBox As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox7 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ReportHeader As DataDynamics.ActiveReports.ReportHeader
    Public WithEvents Label3 As DataDynamics.ActiveReports.Label
    Private WithEvents ReportFooter As DataDynamics.ActiveReports.ReportFooter
    Friend WithEvents Label5 As DataDynamics.ActiveReports.Label
    Friend WithEvents Shape1 As DataDynamics.ActiveReports.Shape
    Friend WithEvents Line9 As DataDynamics.ActiveReports.Line
    Friend WithEvents Label24 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox20 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents SubReport1 As DataDynamics.ActiveReports.SubReport
    Friend WithEvents SubReport2 As DataDynamics.ActiveReports.SubReport
    Friend WithEvents Picture1 As DataDynamics.ActiveReports.Picture
    Friend WithEvents Shape2 As DataDynamics.ActiveReports.Shape
    Friend WithEvents Label2 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label As DataDynamics.ActiveReports.Label
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptEstornoCreditoEstoque))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.SubReport1 = New DataDynamics.ActiveReports.SubReport()
        Me.SubReport2 = New DataDynamics.ActiveReports.SubReport()
        Me.Label = New DataDynamics.ActiveReports.Label()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader()
        Me.TextBox = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox7 = New DataDynamics.ActiveReports.TextBox()
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter()
        Me.Shape1 = New DataDynamics.ActiveReports.Shape()
        Me.Label5 = New DataDynamics.ActiveReports.Label()
        Me.Line9 = New DataDynamics.ActiveReports.Line()
        Me.Label24 = New DataDynamics.ActiveReports.Label()
        Me.TextBox20 = New DataDynamics.ActiveReports.TextBox()
        Me.Shape2 = New DataDynamics.ActiveReports.Shape()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader()
        Me.Label3 = New DataDynamics.ActiveReports.Label()
        Me.Picture1 = New DataDynamics.ActiveReports.Picture()
        Me.ReportFooter = New DataDynamics.ActiveReports.ReportFooter()
        CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.SubReport1, Me.SubReport2})
        Me.Detail.Height = 0.4895833!
        Me.Detail.Name = "Detail"
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
        Me.SubReport1.Height = 0.125!
        Me.SubReport1.Left = 0!
        Me.SubReport1.Name = "SubReport1"
        Me.SubReport1.Report = Nothing
        Me.SubReport1.ReportName = "subProduto"
        Me.SubReport1.Top = 0.0625!
        Me.SubReport1.Width = 7.5625!
        '
        'SubReport2
        '
        Me.SubReport2.Border.BottomColor = System.Drawing.Color.Black
        Me.SubReport2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.SubReport2.Border.LeftColor = System.Drawing.Color.Black
        Me.SubReport2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.SubReport2.Border.RightColor = System.Drawing.Color.Black
        Me.SubReport2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.SubReport2.Border.TopColor = System.Drawing.Color.Black
        Me.SubReport2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.SubReport2.CloseBorder = False
        Me.SubReport2.Height = 0.125!
        Me.SubReport2.Left = 0!
        Me.SubReport2.Name = "SubReport2"
        Me.SubReport2.Report = Nothing
        Me.SubReport2.ReportName = "subServico"
        Me.SubReport2.Top = 0.25!
        Me.SubReport2.Width = 7.56!
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
        Me.Label.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; font-size: 7pt; "
        Me.Label.Text = "Código"
        Me.Label.Top = 0!
        Me.Label.Width = 0.375!
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
        Me.Label1.Left = 0.4375!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; font-size: 7pt; "
        Me.Label1.Text = "Nome Cliente"
        Me.Label1.Top = 0!
        Me.Label1.Width = 2.9375!
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
        'GroupHeader1
        '
        Me.GroupHeader1.BackColor = System.Drawing.Color.Silver
        Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox, Me.TextBox7, Me.Label1, Me.Label})
        Me.GroupHeader1.DataField = "nome_cliente"
        Me.GroupHeader1.Height = 0.34375!
        Me.GroupHeader1.Name = "GroupHeader1"
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
        Me.TextBox.Height = 0.1875!
        Me.TextBox.Left = 0.4375!
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 6.75pt; "
        Me.TextBox.Text = "TextBox"
        Me.TextBox.Top = 0.15625!
        Me.TextBox.Width = 2.9375!
        '
        'TextBox7
        '
        Me.TextBox7.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox7.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox7.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox7.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox7.DataField = "cod_cliente"
        Me.TextBox7.Height = 0.1875!
        Me.TextBox7.Left = 0!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.OutputFormat = resources.GetString("TextBox7.OutputFormat")
        Me.TextBox7.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 6.75pt; "
        Me.TextBox7.Text = "TextBox"
        Me.TextBox7.Top = 0.15625!
        Me.TextBox7.Width = 0.375!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Shape1, Me.Label5, Me.Line9, Me.Label24, Me.TextBox20, Me.Shape2, Me.Label2})
        Me.GroupFooter1.Height = 2.375!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'Shape1
        '
        Me.Shape1.Border.BottomColor = System.Drawing.Color.Black
        Me.Shape1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape1.Border.LeftColor = System.Drawing.Color.Black
        Me.Shape1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape1.Border.RightColor = System.Drawing.Color.Black
        Me.Shape1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape1.Border.TopColor = System.Drawing.Color.Black
        Me.Shape1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape1.Height = 0.5625!
        Me.Shape1.Left = 0!
        Me.Shape1.Name = "Shape1"
        Me.Shape1.RoundingRadius = 9.999999!
        Me.Shape1.Top = 0.0625!
        Me.Shape1.Width = 3.8125!
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
        Me.Label5.Height = 0.4375!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 0.0625!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; font-size: 7pt; "
        Me.Label5.Text = ""
        Me.Label5.Top = 0.125!
        Me.Label5.Width = 3.6875!
        '
        'Line9
        '
        Me.Line9.Border.BottomColor = System.Drawing.Color.Black
        Me.Line9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line9.Border.LeftColor = System.Drawing.Color.Black
        Me.Line9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line9.Border.RightColor = System.Drawing.Color.Black
        Me.Line9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line9.Border.TopColor = System.Drawing.Color.Black
        Me.Line9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line9.Height = 0!
        Me.Line9.Left = 0!
        Me.Line9.LineWeight = 1.0!
        Me.Line9.Name = "Line9"
        Me.Line9.Top = 0.75!
        Me.Line9.Width = 7.5625!
        Me.Line9.X1 = 0!
        Me.Line9.X2 = 7.5625!
        Me.Line9.Y1 = 0.75!
        Me.Line9.Y2 = 0.75!
        '
        'Label24
        '
        Me.Label24.Border.BottomColor = System.Drawing.Color.Black
        Me.Label24.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label24.Border.LeftColor = System.Drawing.Color.Black
        Me.Label24.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label24.Border.RightColor = System.Drawing.Color.Black
        Me.Label24.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label24.Border.TopColor = System.Drawing.Color.Black
        Me.Label24.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label24.Height = 0.1875!
        Me.Label24.HyperLink = Nothing
        Me.Label24.Left = 4.25!
        Me.Label24.Name = "Label24"
        Me.Label24.Style = "text-align: right; font-weight: bold; font-size: 9.75pt; "
        Me.Label24.Text = "Total devolvido ==>"
        Me.Label24.Top = 0.25!
        Me.Label24.Width = 1.9375!
        '
        'TextBox20
        '
        Me.TextBox20.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox20.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox20.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox20.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox20.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox20.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox20.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox20.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox20.Height = 0.1979167!
        Me.TextBox20.Left = 6.25!
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Style = "text-align: right; font-weight: bold; font-size: 9.75pt; "
        Me.TextBox20.Text = Nothing
        Me.TextBox20.Top = 0.25!
        Me.TextBox20.Width = 1.0!
        '
        'Shape2
        '
        Me.Shape2.Border.BottomColor = System.Drawing.Color.Black
        Me.Shape2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape2.Border.LeftColor = System.Drawing.Color.Black
        Me.Shape2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape2.Border.RightColor = System.Drawing.Color.Black
        Me.Shape2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape2.Border.TopColor = System.Drawing.Color.Black
        Me.Shape2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape2.Height = 0.5625!
        Me.Shape2.Left = 0!
        Me.Shape2.Name = "Shape2"
        Me.Shape2.RoundingRadius = 9.999999!
        Me.Shape2.Top = 0.875!
        Me.Shape2.Visible = False
        Me.Shape2.Width = 3.8125!
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
        Me.Label2.Height = 0.4375!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.0625!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; font-size: 7pt; "
        Me.Label2.Text = ""
        Me.Label2.Top = 0.9375!
        Me.Label2.Visible = False
        Me.Label2.Width = 3.6875!
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label3, Me.Picture1})
        Me.ReportHeader.Height = 0.5833333!
        Me.ReportHeader.Name = "ReportHeader"
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
        Me.Label3.Left = 1.458333!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 9.75pt; "
        Me.Label3.Text = "Devolução Crédito/Dinheiro"
        Me.Label3.Top = 0.125!
        Me.Label3.Width = 6.0625!
        '
        'Picture1
        '
        Me.Picture1.Border.BottomColor = System.Drawing.Color.Black
        Me.Picture1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture1.Border.LeftColor = System.Drawing.Color.Black
        Me.Picture1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture1.Border.RightColor = System.Drawing.Color.Black
        Me.Picture1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture1.Border.TopColor = System.Drawing.Color.Black
        Me.Picture1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture1.Height = 0.5!
        Me.Picture1.Image = CType(resources.GetObject("Picture1.Image"), System.Drawing.Image)
        Me.Picture1.ImageData = CType(resources.GetObject("Picture1.ImageData"), System.IO.Stream)
        Me.Picture1.Left = 0.125!
        Me.Picture1.LineWeight = 0!
        Me.Picture1.Name = "Picture1"
        Me.Picture1.SizeMode = DataDynamics.ActiveReports.SizeModes.Zoom
        Me.Picture1.Top = 0!
        Me.Picture1.Width = 1.3125!
        '
        'ReportFooter
        '
        Me.ReportFooter.Height = 0.5104167!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'rptEstornoCreditoEstoque
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.69!
        Me.PageSettings.PaperWidth = 8.27!
        Me.PrintWidth = 7.614583!
        Me.Sections.Add(Me.ReportHeader)
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.PageFooter)
        Me.Sections.Add(Me.ReportFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule(resources.GetString("$this.StyleSheet"), "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" &
            "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei" &
            "ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" &
            "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading3", "Normal"))
        CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

    Dim d As New dados
    Dim pedido As New objMaster
    Public intPedido As Integer
    Public intFilial As Integer
    Dim rPedido As New rptEstornoProduto
    Dim rServico As New rptEstornoServico

    Private Sub Detail_Format(sender As System.Object, e As System.EventArgs) Handles Detail.Format
        Dim dti As DateTime = Now().ToShortDateString & " 00:00:01"
        Dim dtf As DateTime = Now().ToShortDateString & " 23:59:59"
        Dim ttPedidoProduto As New DataTable
        Dim ttServico As New DataTable
        Try
            Dim strSQL As String = ""
            strSQL = "select pedido_balcao_itens.num_pedido, pedido_balcao_itens.id_filial, pedido_balcao_itens.item, pedido_balcao_itens.cod_produto, " & _
                "pedido_balcao_itens.quant, pedido_balcao_itens.compra, pedido_balcao_itens.desconto, pedido_balcao_itens.preco_tab, pedido_balcao_itens.preco, " & _
                "isnull(pedido_balcao_itens.preco * pedido_balcao_itens.quant ,0) as total, " & _
                "pedido_balcao_itens.cod_status_item, pedido_balcao_itens.Pacote, pedido_balcao_itens.cod_pacote, pedido_balcao_itens.desc_caixa, " & _
                "produtos.produto, status_item_pedido.status_item, pedido_balcao_itens.usuario_can, pedido_balcao_itens.tipo_devolucao, " & _
                "pedido_balcao_itens.devolvido_estoque, pedido_balcao_itens.data_devolucao from pedido_balcao_itens inner join produtos on " & _
                "pedido_balcao_itens.cod_produto = produtos.cod_produto inner join status_item_pedido on " & _
                "status_item_pedido.cod_status_item = pedido_balcao_itens.cod_status_item where pedido_balcao_itens.num_pedido = " & intPedido & _
                " And pedido_balcao_itens.id_filial = " & intFilial '& " and data_devolucao >= " & d.pdtm(dti) & " and data_devolucao <= " & d.pdtm(dtf)

            ttPedidoProduto = pedido.retornaRegistro(strSQL).Tables(0)
            If ttPedidoProduto.Rows.Count > 0 Then
                rPedido.DataSource = ttPedidoProduto
                SubReport1.Report = rPedido
            Else
                SubReport1.Visible = False
            End If
        Catch ex As Exception

        End Try

        Try
            Dim strSQL As String = "select pedido_balcao_servicos.num_pedido, pedido_balcao_servicos.id_filial, pedido_balcao_servicos.item_servico, " & _
              "pedido_balcao_servicos.cod_servico, pedido_balcao_servicos.quant, pedido_balcao_servicos.compra, pedido_balcao_servicos.desconto, " & _
              "pedido_balcao_servicos.preco_tab, pedido_balcao_servicos.preco, isnull(pedido_balcao_servicos.preco * pedido_balcao_servicos.quant ,0) as total, " & _
              "pedido_balcao_servicos.cod_status_servico, pedido_balcao_servicos.Pacote, " & _
              "pedido_balcao_servicos.cod_pacote, pedido_balcao_servicos.desc_caixa, produtos.produto, status_servico_pedido.status_servico, " & _
              "pedido_balcao_servicos.usuario_can, pedido_balcao_servicos.tipo_devolucao, pedido_balcao_servicos.devolvido_estoque, pedido_balcao_servicos.data_devolucao " & _
              "from pedido_balcao_servicos inner join produtos on pedido_balcao_servicos.cod_servico = produtos.cod_produto inner join " & _
              "status_servico_pedido on status_servico_pedido.cod_status_servico = pedido_balcao_servicos.cod_status_servico " & _
              "where pedido_balcao_servicos.num_pedido = " & intPedido & " And pedido_balcao_servicos.id_filial = " & intFilial & _
              " and data_devolucao >= " & d.pdtm(dti) & " and data_devolucao <= " & d.pdtm(dtf)

            ttServico = pedido.retornaRegistro(strSQL).Tables(0)
            If ttServico.Rows.Count > 0 Then
                rServico.DataSource = ttServico
                SubReport2.Report = rServico
            Else
                SubReport2.Visible = False
            End If
        Catch ex As Exception

        End Try

        Try
            Dim strSQL As String = "select valor_devolvido from pedido_balcao where pedido_balcao.num_pedido = " & intPedido & " And pedido_balcao.id_filial = " & intFilial

            Dim ttTotais As New DataTable
            ttTotais = pedido.retornaRegistro(strSQL).Tables(0)
            TextBox20.Text = Format(ttTotais.Rows(0)("valor_devolvido"), "#,##0.00")
        Catch ex As Exception

        End Try

        If ttPedidoProduto.Rows.Count > 0 Then
            'Verifica se o pedido está vonculado a uma OS
            Dim strSQLOS As String = "select cod_os from os where num_pedido = " & ttPedidoProduto.Rows(0)("num_pedido") & " and id_filial = " & ttPedidoProduto.Rows(0)("id_filial")
            Dim ttOS As New DataTable
            ttOS = pedido.retornaRegistro(strSQLOS).Tables(0)

            If ttPedidoProduto.Rows(0)("tipo_devolucao").ToString = "D" Then
                If pedido.verifica_existencia_registro(strSQLOS) = True Then
                    Label5.Text = "Devolução de dinheiro para o cliente acima especificado, " & Chr(13) & _
                    "referente ao cancelamento dos itens da OS Nº. " & ttOS.Rows(0)("cod_os") & "." & Chr(13) & _
                    "Devolvido em: " & ttPedidoProduto.Rows(0)("data_devolucao") & " - " & "Ass: __________________________________"
                Else
                    Label5.Text = "Devolução de dinheiro para o cliente acima especificado, " & Chr(13) & _
                    "referente ao cancelamento dos itens do pedido Nº. " & intPedido & "." & Chr(13) & _
                    "Devolvido em: " & ttPedidoProduto.Rows(0)("data_devolucao") & " - " & "Ass: __________________________________"
                End If
            End If

            If ttPedidoProduto.Rows(0)("tipo_devolucao").ToString = "C" Then
                If pedido.verifica_existencia_registro(strSQLOS) = True Then
                    Label5.Text = "Devolução de crédito para o cliente acima especificado, " & Chr(13) & _
                    "referente ao cancelamento dos itens da OS Nº. " & ttOS.Rows(0)("cod_os") & "." & Chr(13) & _
                    "Devolvido em: " & ttPedidoProduto.Rows(0)("data_devolucao") & " - " & "Ass: __________________________________"
                Else
                    Label5.Text = "Devolução de crédito para o cliente acima especificado, " & Chr(13) & _
                    "referente ao cancelamento dos itens do pedido Nº. " & intPedido & "." & Chr(13) & _
                    "Devolvido em: " & ttPedidoProduto.Rows(0)("data_devolucao") & " - " & "Ass: __________________________________"
                End If
            End If

            If ttPedidoProduto.Rows(0)("devolvido_estoque").ToString = "S" Then
                Shape2.Visible = True
                Label2.Visible = True
                If pedido.verifica_existencia_registro(strSQLOS) = True Then
                    Label2.Text = "Devolvido para o estoque, " & Chr(13) & _
                    "referente ao cancelamento dos itens da OS Nº. " & ttOS.Rows(0)("cod_os") & "." & Chr(13) & _
                    "Devolvido em: " & ttPedidoProduto.Rows(0)("data_devolucao") & " - " & "Ass: __________________________________"
                Else
                    Label2.Text = "Devolvido para o estoque, " & Chr(13) & _
                    "referente ao cancelamento dos itens do pedido Nº. " & intPedido & "." & Chr(13) & _
                    "Devolvido em: " & ttPedidoProduto.Rows(0)("data_devolucao") & " - " & "Ass: __________________________________"
                End If
            End If
        Else
            If ttServico.Rows(0)("tipo_devolucao").ToString = "D" Then
                Label5.Text = "Devolução de dinheiro para o cliente acima especificado, " & Chr(13) & _
                "referente ao cancelamento dos itens do pedido Nº. " & intPedido & "." & Chr(13) & _
                "Devolvido em: " & ttServico.Rows(0)("data_devolucao") & " - " & "Ass: __________________________________"
            End If

            If ttServico.Rows(0)("tipo_devolucao").ToString = "C" Then
                Label5.Text = "Devolução de crédito para o cliente acima especificado, " & Chr(13) & _
                "referente ao cancelamento dos itens do pedido Nº. " & intPedido & "." & Chr(13) & _
                "Devolvido em: " & ttServico.Rows(0)("data_devolucao") & " - " & "Ass: __________________________________"
            End If
        End If
    End Sub

End Class
