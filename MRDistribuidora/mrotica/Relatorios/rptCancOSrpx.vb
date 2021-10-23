Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports mrotica_util

Public Class rptCancOSrpx
Inherits DataDynamics.ActiveReports.ActiveReport3
	Public Sub New()
	MyBase.New()
		InitializeComponent()
	End Sub
	#Region "ActiveReports Designer generated code"
    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader = Nothing
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
    Friend WithEvents txtEstoque As DataDynamics.ActiveReports.RichTextBox
    Friend WithEvents txtCliente As DataDynamics.ActiveReports.RichTextBox
    Friend WithEvents txtBalcao As DataDynamics.ActiveReports.RichTextBox
    Friend WithEvents Picture2 As DataDynamics.ActiveReports.Picture
    Friend WithEvents Picture3 As DataDynamics.ActiveReports.Picture
    Friend WithEvents Line1 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line2 As DataDynamics.ActiveReports.Line
    Friend WithEvents Label1 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label2 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label3 As DataDynamics.ActiveReports.Label
    Friend WithEvents Picture1 As Picture
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptCancOSrpx))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txtEstoque = New DataDynamics.ActiveReports.RichTextBox()
        Me.txtCliente = New DataDynamics.ActiveReports.RichTextBox()
        Me.txtBalcao = New DataDynamics.ActiveReports.RichTextBox()
        Me.Picture2 = New DataDynamics.ActiveReports.Picture()
        Me.Picture3 = New DataDynamics.ActiveReports.Picture()
        Me.Line1 = New DataDynamics.ActiveReports.Line()
        Me.Line2 = New DataDynamics.ActiveReports.Line()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.Label3 = New DataDynamics.ActiveReports.Label()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.Picture1 = New DataDynamics.ActiveReports.Picture()
        CType(Me.Picture2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtEstoque, Me.txtCliente, Me.txtBalcao, Me.Picture1, Me.Picture2, Me.Picture3, Me.Line1, Me.Line2, Me.Label1, Me.Label2, Me.Label3})
        Me.Detail.Height = 12.63542!
        Me.Detail.Name = "Detail"
        '
        'txtEstoque
        '
        Me.txtEstoque.AutoReplaceFields = True
        Me.txtEstoque.Border.BottomColor = System.Drawing.Color.Black
        Me.txtEstoque.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtEstoque.Border.LeftColor = System.Drawing.Color.Black
        Me.txtEstoque.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtEstoque.Border.RightColor = System.Drawing.Color.Black
        Me.txtEstoque.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtEstoque.Border.TopColor = System.Drawing.Color.Black
        Me.txtEstoque.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtEstoque.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtEstoque.Height = 3.0625!
        Me.txtEstoque.Left = 0!
        Me.txtEstoque.Name = "txtEstoque"
        Me.txtEstoque.RTF = resources.GetString("txtEstoque.RTF")
        Me.txtEstoque.Top = 0.75!
        Me.txtEstoque.Width = 7.3125!
        '
        'txtCliente
        '
        Me.txtCliente.AutoReplaceFields = True
        Me.txtCliente.Border.BottomColor = System.Drawing.Color.Black
        Me.txtCliente.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCliente.Border.LeftColor = System.Drawing.Color.Black
        Me.txtCliente.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCliente.Border.RightColor = System.Drawing.Color.Black
        Me.txtCliente.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCliente.Border.TopColor = System.Drawing.Color.Black
        Me.txtCliente.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCliente.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtCliente.Height = 3.0625!
        Me.txtCliente.Left = 0!
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.RTF = resources.GetString("txtCliente.RTF")
        Me.txtCliente.Top = 4.75!
        Me.txtCliente.Width = 7.3125!
        '
        'txtBalcao
        '
        Me.txtBalcao.AutoReplaceFields = True
        Me.txtBalcao.Border.BottomColor = System.Drawing.Color.Black
        Me.txtBalcao.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtBalcao.Border.LeftColor = System.Drawing.Color.Black
        Me.txtBalcao.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtBalcao.Border.RightColor = System.Drawing.Color.Black
        Me.txtBalcao.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtBalcao.Border.TopColor = System.Drawing.Color.Black
        Me.txtBalcao.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtBalcao.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtBalcao.Height = 3.06!
        Me.txtBalcao.Left = 0!
        Me.txtBalcao.Name = "txtBalcao"
        Me.txtBalcao.RTF = resources.GetString("txtBalcao.RTF")
        Me.txtBalcao.Top = 8.8125!
        Me.txtBalcao.Width = 7.3125!
        '
        'Picture2
        '
        Me.Picture2.Border.BottomColor = System.Drawing.Color.Black
        Me.Picture2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture2.Border.LeftColor = System.Drawing.Color.Black
        Me.Picture2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture2.Border.RightColor = System.Drawing.Color.Black
        Me.Picture2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture2.Border.TopColor = System.Drawing.Color.Black
        Me.Picture2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture2.Height = 0.5!
        Me.Picture2.Image = CType(resources.GetObject("Picture2.Image"), System.Drawing.Image)
        Me.Picture2.ImageData = CType(resources.GetObject("Picture2.ImageData"), System.IO.Stream)
        Me.Picture2.Left = 0!
        Me.Picture2.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Picture2.LineWeight = 0!
        Me.Picture2.Name = "Picture2"
        Me.Picture2.SizeMode = DataDynamics.ActiveReports.SizeModes.Stretch
        Me.Picture2.Top = 4.125!
        Me.Picture2.Width = 1.3125!
        '
        'Picture3
        '
        Me.Picture3.Border.BottomColor = System.Drawing.Color.Black
        Me.Picture3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture3.Border.LeftColor = System.Drawing.Color.Black
        Me.Picture3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture3.Border.RightColor = System.Drawing.Color.Black
        Me.Picture3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture3.Border.TopColor = System.Drawing.Color.Black
        Me.Picture3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture3.Height = 0.5!
        Me.Picture3.Image = CType(resources.GetObject("Picture3.Image"), System.Drawing.Image)
        Me.Picture3.ImageData = CType(resources.GetObject("Picture3.ImageData"), System.IO.Stream)
        Me.Picture3.Left = 0!
        Me.Picture3.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Picture3.LineWeight = 0!
        Me.Picture3.Name = "Picture3"
        Me.Picture3.SizeMode = DataDynamics.ActiveReports.SizeModes.Stretch
        Me.Picture3.Top = 8.1875!
        Me.Picture3.Width = 1.3125!
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
        Me.Line1.LineStyle = DataDynamics.ActiveReports.LineStyle.DashDot
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 8.0!
        Me.Line1.Width = 7.4375!
        Me.Line1.X1 = 0!
        Me.Line1.X2 = 7.4375!
        Me.Line1.Y1 = 8.0!
        Me.Line1.Y2 = 8.0!
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
        Me.Line2.Left = 0!
        Me.Line2.LineStyle = DataDynamics.ActiveReports.LineStyle.DashDot
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 4.0!
        Me.Line2.Width = 7.4375!
        Me.Line2.X1 = 0!
        Me.Line2.X2 = 7.4375!
        Me.Line2.Y1 = 4.0!
        Me.Line2.Y2 = 4.0!
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
        Me.Label1.Left = 2.927083!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-weight: bold; font-size: 11.25pt; "
        Me.Label1.Text = "Cancelamento de OS"
        Me.Label1.Top = 0.3125!
        Me.Label1.Width = 1.625!
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
        Me.Label2.Left = 2.927083!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-weight: bold; font-size: 11.25pt; "
        Me.Label2.Text = "Cancelamento de OS"
        Me.Label2.Top = 4.3125!
        Me.Label2.Width = 1.625!
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
        Me.Label3.Left = 2.927083!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-weight: bold; font-size: 11.25pt; "
        Me.Label3.Text = "Cancelamento de OS"
        Me.Label3.Top = 8.3125!
        Me.Label3.Width = 1.625!
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
        Me.Picture1.Left = 0!
        Me.Picture1.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Picture1.LineWeight = 0!
        Me.Picture1.Name = "Picture1"
        Me.Picture1.SizeMode = DataDynamics.ActiveReports.SizeModes.Zoom
        Me.Picture1.Top = 0.125!
        Me.Picture1.Width = 1.3125!
        '
        'rptCancOSrpx
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.69!
        Me.PageSettings.PaperWidth = 8.27!
        Me.PrintWidth = 7.479167!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule(resources.GetString("$this.StyleSheet"), "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" &
            "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei" &
            "ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" &
            "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading3", "Normal"))
        CType(Me.Picture2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region
    Public txtRTF As String
    Dim conf As New config
    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        txtEstoque.Text = txtRTF
        txtBalcao.Text = txtRTF
        txtCliente.Text = txtRTF

        If My.Computer.FileSystem.FileExists(conf.ImagemRelatorio) Then
            Picture1.Image = Image.FromFile(conf.ImagemRelatorio)
        End If
    End Sub
End Class
