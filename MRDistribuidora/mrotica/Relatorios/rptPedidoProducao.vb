Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports mrotica_util

Public Class rptPedidoProducao
    Inherits DataDynamics.ActiveReports.ActiveReport3
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub
    Public tbItens As New DataTable
    Public tbServ As New DataTable
    Public Total As String
    Public n_pedido As String
    Public filial As Integer
    Public Vendedor As String
    Public cliente As String
    Public cod_cliente As String
    Public data As String
    Public economia As String
    Public OSs As String
    Dim conf As New config
    Dim d As New dados
#Region "ActiveReports Designer generated code"
    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader = Nothing
    Private WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader = Nothing
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
    Private WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter = Nothing
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
    Private fldPedido As DataDynamics.ActiveReports.TextBox
    Private fldVendedor As DataDynamics.ActiveReports.TextBox
    Private fldCliente As DataDynamics.ActiveReports.TextBox
    Private lblData As DataDynamics.ActiveReports.Label
    Private subItens As DataDynamics.ActiveReports.SubReport
    Private subServ As DataDynamics.ActiveReports.SubReport
    Private txtTotal As DataDynamics.ActiveReports.TextBox
    Private Label As DataDynamics.ActiveReports.Label
    Private lblEconomia As DataDynamics.ActiveReports.Label
    Private WithEvents lblRazaoSocial As DataDynamics.ActiveReports.Label
    Private WithEvents lblEndereco As DataDynamics.ActiveReports.Label
    Private WithEvents lblFone As DataDynamics.ActiveReports.Label
    Private WithEvents Picture As DataDynamics.ActiveReports.Picture
    Friend WithEvents Line As DataDynamics.ActiveReports.Line
    Private Line1 As DataDynamics.ActiveReports.Line
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptPedidoProducao))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.subItens = New DataDynamics.ActiveReports.SubReport()
        Me.subServ = New DataDynamics.ActiveReports.SubReport()
        Me.Line = New DataDynamics.ActiveReports.Line()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader()
        Me.fldPedido = New DataDynamics.ActiveReports.TextBox()
        Me.fldVendedor = New DataDynamics.ActiveReports.TextBox()
        Me.fldCliente = New DataDynamics.ActiveReports.TextBox()
        Me.lblData = New DataDynamics.ActiveReports.Label()
        Me.lblRazaoSocial = New DataDynamics.ActiveReports.Label()
        Me.lblEndereco = New DataDynamics.ActiveReports.Label()
        Me.lblFone = New DataDynamics.ActiveReports.Label()
        Me.Picture = New DataDynamics.ActiveReports.Picture()
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter()
        Me.txtTotal = New DataDynamics.ActiveReports.TextBox()
        Me.Label = New DataDynamics.ActiveReports.Label()
        Me.lblEconomia = New DataDynamics.ActiveReports.Label()
        Me.Line1 = New DataDynamics.ActiveReports.Line()
        CType(Me.fldPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldVendedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblRazaoSocial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblEndereco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblEconomia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.subItens, Me.subServ, Me.Line})
        Me.Detail.Height = 0.3847222!
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
        Me.subItens.Left = 0!
        Me.subItens.Name = "subItens"
        Me.subItens.Report = Nothing
        Me.subItens.Top = 0!
        Me.subItens.Width = 7.375!
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
        Me.subServ.CloseBorder = False
        Me.subServ.Height = 0.1875!
        Me.subServ.Left = 0!
        Me.subServ.Name = "subServ"
        Me.subServ.Report = Nothing
        Me.subServ.Top = 0.1875!
        Me.subServ.Width = 7.375!
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
        Me.Line.LineWeight = 1.0!
        Me.Line.Name = "Line"
        Me.Line.Top = 0!
        Me.Line.Width = 7.0!
        Me.Line.X1 = 0!
        Me.Line.X2 = 7.0!
        Me.Line.Y1 = 0!
        Me.Line.Y2 = 0!
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
        Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.fldPedido, Me.fldVendedor, Me.fldCliente, Me.lblData, Me.lblRazaoSocial, Me.lblEndereco, Me.lblFone, Me.Picture})
        Me.GroupHeader1.Height = 1.21875!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'fldPedido
        '
        Me.fldPedido.Border.BottomColor = System.Drawing.Color.Black
        Me.fldPedido.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldPedido.Border.LeftColor = System.Drawing.Color.Black
        Me.fldPedido.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldPedido.Border.RightColor = System.Drawing.Color.Black
        Me.fldPedido.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldPedido.Border.TopColor = System.Drawing.Color.Black
        Me.fldPedido.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldPedido.Height = 0.1875!
        Me.fldPedido.Left = 0!
        Me.fldPedido.Name = "fldPedido"
        Me.fldPedido.Style = "ddo-char-set: 1; font-weight: bold; font-size: 10pt; font-family: Arial; "
        Me.fldPedido.Text = Nothing
        Me.fldPedido.Top = 1.0!
        Me.fldPedido.Width = 6.9375!
        '
        'fldVendedor
        '
        Me.fldVendedor.Border.BottomColor = System.Drawing.Color.Black
        Me.fldVendedor.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldVendedor.Border.LeftColor = System.Drawing.Color.Black
        Me.fldVendedor.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldVendedor.Border.RightColor = System.Drawing.Color.Black
        Me.fldVendedor.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldVendedor.Border.TopColor = System.Drawing.Color.Black
        Me.fldVendedor.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldVendedor.Height = 0.1875!
        Me.fldVendedor.Left = 0.0625!
        Me.fldVendedor.Name = "fldVendedor"
        Me.fldVendedor.Style = "ddo-char-set: 1; font-weight: bold; font-size: 10pt; font-family: Arial; "
        Me.fldVendedor.Text = Nothing
        Me.fldVendedor.Top = 0.75!
        Me.fldVendedor.Width = 2.375!
        '
        'fldCliente
        '
        Me.fldCliente.Border.BottomColor = System.Drawing.Color.Black
        Me.fldCliente.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldCliente.Border.LeftColor = System.Drawing.Color.Black
        Me.fldCliente.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldCliente.Border.RightColor = System.Drawing.Color.Black
        Me.fldCliente.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldCliente.Border.TopColor = System.Drawing.Color.Black
        Me.fldCliente.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldCliente.Height = 0.1875!
        Me.fldCliente.Left = 2.239173!
        Me.fldCliente.Name = "fldCliente"
        Me.fldCliente.Style = "ddo-char-set: 1; font-weight: bold; font-size: 10pt; font-family: Arial; "
        Me.fldCliente.Text = Nothing
        Me.fldCliente.Top = 0.5413386!
        Me.fldCliente.Width = 4.625!
        '
        'lblData
        '
        Me.lblData.Border.BottomColor = System.Drawing.Color.Black
        Me.lblData.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblData.Border.LeftColor = System.Drawing.Color.Black
        Me.lblData.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblData.Border.RightColor = System.Drawing.Color.Black
        Me.lblData.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblData.Border.TopColor = System.Drawing.Color.Black
        Me.lblData.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblData.Height = 0.2!
        Me.lblData.HyperLink = Nothing
        Me.lblData.Left = 0!
        Me.lblData.Name = "lblData"
        Me.lblData.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; font-size: 10pt; font-famil" &
    "y: Arial; "
        Me.lblData.Text = "Label1"
        Me.lblData.Top = 0.5413386!
        Me.lblData.Width = 2.1875!
        '
        'lblRazaoSocial
        '
        Me.lblRazaoSocial.Border.BottomColor = System.Drawing.Color.Black
        Me.lblRazaoSocial.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblRazaoSocial.Border.LeftColor = System.Drawing.Color.Black
        Me.lblRazaoSocial.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblRazaoSocial.Border.RightColor = System.Drawing.Color.Black
        Me.lblRazaoSocial.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblRazaoSocial.Border.TopColor = System.Drawing.Color.Black
        Me.lblRazaoSocial.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblRazaoSocial.Height = 0.1968504!
        Me.lblRazaoSocial.HyperLink = Nothing
        Me.lblRazaoSocial.Left = 2.952756!
        Me.lblRazaoSocial.Name = "lblRazaoSocial"
        Me.lblRazaoSocial.Style = "ddo-char-set: 1; text-align: center; font-weight: normal; "
        Me.lblRazaoSocial.Text = "TAVEIRA COMÉRCIO DE PRODUTOS ÓTICOS LTDA"
        Me.lblRazaoSocial.Top = 0!
        Me.lblRazaoSocial.Width = 3.494095!
        '
        'lblEndereco
        '
        Me.lblEndereco.Border.BottomColor = System.Drawing.Color.Black
        Me.lblEndereco.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblEndereco.Border.LeftColor = System.Drawing.Color.Black
        Me.lblEndereco.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblEndereco.Border.RightColor = System.Drawing.Color.Black
        Me.lblEndereco.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblEndereco.Border.TopColor = System.Drawing.Color.Black
        Me.lblEndereco.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblEndereco.Height = 0.1968504!
        Me.lblEndereco.HyperLink = Nothing
        Me.lblEndereco.Left = 2.977362!
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Style = "ddo-char-set: 1; text-align: center; font-weight: normal; "
        Me.lblEndereco.Text = "Rua Ó de Almeida, 298 - Térreo - Campina"
        Me.lblEndereco.Top = 0.1722441!
        Me.lblEndereco.Width = 2.755905!
        '
        'lblFone
        '
        Me.lblFone.Border.BottomColor = System.Drawing.Color.Black
        Me.lblFone.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblFone.Border.LeftColor = System.Drawing.Color.Black
        Me.lblFone.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblFone.Border.RightColor = System.Drawing.Color.Black
        Me.lblFone.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblFone.Border.TopColor = System.Drawing.Color.Black
        Me.lblFone.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblFone.Height = 0.2!
        Me.lblFone.HyperLink = Nothing
        Me.lblFone.Left = 2.952756!
        Me.lblFone.Name = "lblFone"
        Me.lblFone.Style = "ddo-char-set: 1; text-align: center; font-weight: normal; "
        Me.lblFone.Text = "Fones: (91) 3230-3124 / 3241-1837 - Fax: (91) 3241-9440"
        Me.lblFone.Top = 0.3198819!
        Me.lblFone.Width = 3.6875!
        '
        'Picture
        '
        Me.Picture.Border.BottomColor = System.Drawing.Color.Black
        Me.Picture.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture.Border.LeftColor = System.Drawing.Color.Black
        Me.Picture.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture.Border.RightColor = System.Drawing.Color.Black
        Me.Picture.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture.Border.TopColor = System.Drawing.Color.Black
        Me.Picture.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture.Height = 0.5!
        Me.Picture.Image = CType(resources.GetObject("Picture.Image"), System.Drawing.Image)
        Me.Picture.ImageData = CType(resources.GetObject("Picture.ImageData"), System.IO.Stream)
        Me.Picture.Left = 0!
        Me.Picture.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Picture.LineWeight = 0!
        Me.Picture.Name = "Picture"
        Me.Picture.SizeMode = DataDynamics.ActiveReports.SizeModes.Zoom
        Me.Picture.Top = 0!
        Me.Picture.Width = 2.9375!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtTotal, Me.Label, Me.lblEconomia, Me.Line1})
        Me.GroupFooter1.Height = 0.28125!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'txtTotal
        '
        Me.txtTotal.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTotal.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotal.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTotal.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotal.Border.RightColor = System.Drawing.Color.Black
        Me.txtTotal.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotal.Border.TopColor = System.Drawing.Color.Black
        Me.txtTotal.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotal.Height = 0.1875!
        Me.txtTotal.Left = 6.375!
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 10pt; "
        Me.txtTotal.Text = "TextBox"
        Me.txtTotal.Top = 0!
        Me.txtTotal.Width = 0.875!
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
        Me.Label.Left = 5.229167!
        Me.Label.Name = "Label"
        Me.Label.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 10pt; "
        Me.Label.Text = "Total Pedido:"
        Me.Label.Top = 0!
        Me.Label.Width = 1.0!
        '
        'lblEconomia
        '
        Me.lblEconomia.Border.BottomColor = System.Drawing.Color.Black
        Me.lblEconomia.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblEconomia.Border.LeftColor = System.Drawing.Color.Black
        Me.lblEconomia.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblEconomia.Border.RightColor = System.Drawing.Color.Black
        Me.lblEconomia.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblEconomia.Border.TopColor = System.Drawing.Color.Black
        Me.lblEconomia.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblEconomia.Height = 0.1875!
        Me.lblEconomia.HyperLink = Nothing
        Me.lblEconomia.Left = 0!
        Me.lblEconomia.Name = "lblEconomia"
        Me.lblEconomia.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; font-style: normal; font-si" &
    "ze: 10pt; "
        Me.lblEconomia.Text = ""
        Me.lblEconomia.Top = 0!
        Me.lblEconomia.Width = 5.125!
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
        Me.Line1.Left = 0!
        Me.Line1.LineStyle = DataDynamics.ActiveReports.LineStyle.Dash
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.25!
        Me.Line1.Width = 7.5!
        Me.Line1.X1 = 0!
        Me.Line1.X2 = 7.5!
        Me.Line1.Y1 = 0.25!
        Me.Line1.Y2 = 0.25!
        '
        'rptPedidoProducao
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.69!
        Me.PageSettings.PaperWidth = 8.27!
        Me.PrintWidth = 7.5!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule(resources.GetString("$this.StyleSheet"), "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" &
            "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei" &
            "ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" &
            "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading3", "Normal"))
        CType(Me.fldPedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldVendedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblRazaoSocial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblEndereco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblEconomia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region
    Private Sub rptServ_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        Dim rItens As New rptItensPedido
        Dim rServ As New rptServPedido
        If tbItens.Rows.Count > 0 Then
            rItens.tb = tbItens
            Me.subItens.Report = rItens
        End If
    End Sub
    Private Sub GroupFooter1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupFooter1.Format
        txtTotal.Text = Total
        lblEconomia.Text = economia
    End Sub

    Private Sub GroupHeader1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupHeader1.Format
        If My.Computer.FileSystem.FileExists(conf.ImagemRelatorio) Then
            Picture.Image = Image.FromFile(conf.ImagemRelatorio)
        End If

        fldPedido.Text = "Pedido: " & n_pedido & " OS(s) " & OSs
        fldVendedor.Text = "Vend.: " & Vendedor
        fldCliente.Text = "Cliente: " & cod_cliente & " " & cliente
        lblData.Text = data
        cabecalho()
    End Sub
    Private Sub cabecalho()
        Dim emitente As New objEmitente(conf.Filial)
        lblRazaoSocial.Text = emitente.razaoSocial
        lblEndereco.Text = emitente.endereco & " nº " & emitente.numero & " " & emitente.complemento & " Bairro: " & emitente.bairro
        lblFone.Text = "Telefone(s): " & emitente.telefone

    End Sub
    Private Function os(ByVal n_pedido As Integer) As String
        Dim sql As String
        Dim tt As New DataTable
        sql = "select cod_os from os where num_pedido = " & n_pedido & " and id_filial = " & filial
        d.carrega_Tabela(sql, tt)
        If tt.Rows.Count > 0 Then
            Return tt.Rows(0)("cod_os")
        End If
    End Function


    Private Sub PageFooter_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageFooter.Format

    End Sub

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format

    End Sub
End Class
