Imports mrotica_util
Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class rptCaixaResumo
    Inherits DataDynamics.ActiveReports.ActiveReport3
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub
#Region "ActiveReports Designer generated code"
    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader = Nothing
    Friend WithEvents Detail As DataDynamics.ActiveReports.Detail
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
    Friend WithEvents Picture1 As DataDynamics.ActiveReports.Picture
    Friend WithEvents SubReport1 As DataDynamics.ActiveReports.SubReport
    Friend WithEvents SubReport2 As DataDynamics.ActiveReports.SubReport
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptCaixaResumo))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.SubReport1 = New DataDynamics.ActiveReports.SubReport()
        Me.SubReport2 = New DataDynamics.ActiveReports.SubReport()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.Picture1 = New DataDynamics.ActiveReports.Picture()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.SubReport1, Me.SubReport2})
        Me.Detail.Height = 0.5104167!
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
        Me.SubReport1.Top = 0.0625!
        Me.SubReport1.Width = 7.5!
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
        Me.SubReport2.Top = 0.25!
        Me.SubReport2.Width = 7.5!
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Picture1})
        Me.PageHeader.Height = 0.5!
        Me.PageHeader.Name = "PageHeader"
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
        Me.Picture1.Top = 0!
        Me.Picture1.Width = 1.3125!
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0!
        Me.PageFooter.Name = "PageFooter"
        '
        'rptCaixaResumo
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.69!
        Me.PageSettings.PaperWidth = 8.27!
        Me.PrintWidth = 7.520833!
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
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region
    Public diai As Date
    Public diaf As Date
    Public intFilial As Integer
    Dim conf As New config
    Dim rRecReceita As New rptRecebimentoReceita
    Dim rRecDespesa As New rptRecebimentoDespesa
    Dim lanc As New objLancamentos
    Dim d As New dados

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        Try
            rRecReceita.diai = diai
            rRecReceita.diaf = diaf
            rRecReceita.filial = intFilial
            Dim intMes As Integer
            intMes = diai.Month
            rRecReceita.TextBox26.Text = "Dia " & Chr(13) & diai.Day & "/" & diai.Month & "/" & diai.Year
            If intMes = 1 Then
                rRecReceita.TextBox2.Text = "Acumulado Mês " & Chr(13) & "01" & "/" & diai.Month & "/" & diai.Year & " a " & diaf.Day & "/" & diaf.Month & "/" & diaf.Year
                rRecReceita.TextBox3.Text = "Período Mês Anterior " & Chr(13) & "01" & "/" & 12 & "/" & diai.Year - 1 & " a " & diaf.Day & "/" & 12 & "/" & diaf.Year - 1
                rRecReceita.TextBox8.Text = "Período Ano Anterior " & Chr(13) & "01" & "/" & diai.Month & "/" & diai.Year - 1 & " a " & diaf.Day & "/" & diaf.Month & "/" & diaf.Year - 1
            Else
                rRecReceita.TextBox2.Text = "Acumulado Mês " & Chr(13) & "01" & "/" & diai.Month & "/" & diai.Year & " a " & diaf.Day & "/" & diaf.Month & "/" & diaf.Year

                If diai.Day = 31 Then
                    rRecReceita.TextBox3.Text = "Período Mês Anterior " & Chr(13) & "01" & "/" & diai.Month - 1 & "/" & diai.Year & " a " & diaf.Day - 1 & "/" & diaf.Month - 1 & "/" & diaf.Year
                Else
                    rRecReceita.TextBox3.Text = "Período Mês Anterior " & Chr(13) & "01" & "/" & diai.Month - 1 & "/" & diai.Year & " a " & diaf.Day & "/" & diaf.Month - 1 & "/" & diaf.Year
                End If

                If diai.Month = 3 Then
                    If diai.Day > 28 Then
                        rRecReceita.TextBox3.Text = "Período Mês Anterior " & Chr(13) & "01" & "/" & diai.Month - 1 & "/" & diai.Year & " a " & 28 & "/" & diaf.Month - 1 & "/" & diaf.Year
                    End If
                End If

                rRecReceita.TextBox8.Text = "Período Ano Anterior " & Chr(13) & "01" & "/" & diai.Month & "/" & diai.Year - 1 & " a " & diaf.Day & "/" & diaf.Month & "/" & diaf.Year - 1
            End If

            rRecReceita.DataSource = lanc.listar_resumo_caixa_receita(diai, diaf, intFilial)
            SubReport1.Report = rRecReceita
        Catch ex As Exception

        End Try

        Try
            rRecDespesa.diai = diai
            rRecDespesa.diaf = diaf
            rRecDespesa.filial = intFilial
            Dim intMes As Integer
            intMes = diai.Month
            rRecDespesa.TextBox26.Text = "Dia " & Chr(13) & diai.Day & "/" & diai.Month & "/" & diai.Year
            If intMes = 1 Then
                rRecDespesa.TextBox2.Text = "Acumulado Mês " & Chr(13) & "01" & "/" & diai.Month & "/" & diai.Year & " a " & diaf.Day & "/" & diaf.Month & "/" & diaf.Year
                rRecDespesa.TextBox3.Text = "Período Mês Anterior " & Chr(13) & "01" & "/" & 12 & "/" & diai.Year - 1 & " a " & diaf.Day & "/" & 12 & "/" & diaf.Year - 1
                rRecDespesa.TextBox8.Text = "Período Ano Anterior " & Chr(13) & "01" & "/" & diai.Month & "/" & diai.Year - 1 & " a " & diaf.Day & "/" & diaf.Month & "/" & diaf.Year - 1
            Else
                rRecDespesa.TextBox2.Text = "Acumulado Mês " & Chr(13) & "01" & "/" & diai.Month & "/" & diai.Year & " a " & diaf.Day & "/" & diaf.Month & "/" & diaf.Year

                If diai.Day = 31 Then
                    rRecDespesa.TextBox3.Text = "Período Mês Anterior " & Chr(13) & "01" & "/" & diai.Month - 1 & "/" & diai.Year & " a " & diaf.Day - 1 & "/" & diaf.Month - 1 & "/" & diaf.Year
                Else
                    rRecDespesa.TextBox3.Text = "Período Mês Anterior " & Chr(13) & "01" & "/" & diai.Month - 1 & "/" & diai.Year & " a " & diaf.Day & "/" & diaf.Month - 1 & "/" & diaf.Year
                End If

                If diai.Month = 3 Then
                    If diai.Day > 28 Then
                        rRecDespesa.TextBox3.Text = "Período Mês Anterior " & Chr(13) & "01" & "/" & diai.Month - 1 & "/" & diai.Year & " a " & 28 & "/" & diaf.Month - 1 & "/" & diaf.Year
                    End If
                End If

                rRecDespesa.TextBox8.Text = "Período Ano Anterior " & Chr(13) & "01" & "/" & diai.Month & "/" & diai.Year - 1 & " a " & diaf.Day & "/" & diaf.Month & "/" & diaf.Year - 1
            End If

            rRecDespesa.DataSource = lanc.listar_resumo_caixa_despesa(diai, diaf, intFilial)
            SubReport2.Report = rRecDespesa
        Catch ex As Exception

        End Try

    End Sub
    Private Function vendas_dia() As DataTable
        Dim sql As String
        Dim tt As New DataTable
        sql = "Select * from pedido_balcao where cod_cliente > 1000 " &
        "and (data_pedido >= " & d.pdtm(diai.Date & " 00:00:00") &
        "and data_pedido <=" & d.pdtm(diai.Date & " 23:59:59") &
        "and pedido_balcao.id_filial = " & intFilial & ") order by cod_cliente"
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Private Function CancOS() As DataTable
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "Select descricao from Cancelamento_os where data = " & d.Pdt(diai) & " and id_filial = " & intFilial & ""
        d.carrega_Tabela(tsql, tt)
        Return tt
    End Function

    Private Sub PageHeader_Format(sender As Object, e As EventArgs) Handles PageHeader.Format
        If My.Computer.FileSystem.FileExists(conf.ImagemRelatorio) Then
            Picture1.Image = Image.FromFile(conf.ImagemRelatorio)
        End If
    End Sub
End Class
