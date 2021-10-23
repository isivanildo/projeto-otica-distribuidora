Imports System.Data
Imports System.Data.SqlClient
Imports mrotica_util
Public Class frmDebitoCliente
    Dim d As New dados
    Dim acesso As New objMaster
    Dim pdfExport As New DataDynamics.ActiveReports.Export.Pdf.PdfExport
    Dim excelExport As New DataDynamics.ActiveReports.Export.Xls.XlsExport
    Dim cidade As New objCliente

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        Dim f As New frmRpt
        Dim rs As New rptDebitoClienteSintetico
        Dim ra As New rptDebitoClienteAnalitico
        Dim strsQL As String = ""
        Dim strTitulo As String = ""

        If CheckBox1.Checked = True Then
            If rbSintetico.Checked = True And rbGeral.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, tipo_documento, " &
                "nossonumero, cod_acordo, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor_pago) * 1 / 100)),2) as multa," &
                "round((((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," &
                "round((valor_pago + ((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor_pago) * 1 / 100)),2) as total " &
                "from verifica_debito() where data_vencimento < " & d.Pdt(dtIni.Value.Date) &
                " and data_recebimento is null " &
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, " &
                "tipo_documento, nossonumero, cod_acordo order by nome_cliente"
                strTitulo = rbSintetico.Text & " " & rbGeral.Text
            ElseIf rbSintetico.Checked = True And rbCliente.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, tipo_documento, " &
                "nossonumero, cod_acordo, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor_pago) * 1 / 100)),2) as multa," &
                "round((((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," &
                "round((valor_pago + ((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor_pago) * 1 / 100)),2) as total " &
                "from verifica_debito() where cod_cliente = " & CInt(txtCodigo.Text) &
                " and data_vencimento < " & d.Pdt(dtIni.Value.Date) & " and data_recebimento is null " &
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, " &
                "tipo_documento, nossonumero, cod_acordo order by nome_cliente"
                strTitulo = rbSintetico.Text & " " & rbCliente.Text
            ElseIf rbSintetico.Checked = True And rbPromotora.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, tipo_documento, " &
                "nossonumero, cod_acordo, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor_pago) * 1 / 100)),2) as multa," &
                "round((((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," &
                "round((valor_pago + ((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor_pago) * 1 / 100)),2) as total " &
                "from verifica_debito() where cod_promotor = " & CInt(cbPromotor.SelectedValue) &
                " and data_vencimento < " & d.Pdt(dtIni.Value.Date) & " and data_recebimento is null " &
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, " &
                "tipo_documento, nossonumero, cod_acordo order by nome_cliente"
                strTitulo = rbSintetico.Text & " " & rbPromotora.Text
            ElseIf rbSintetico.Checked = True And rbCidade.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, tipo_documento, " &
                "nossonumero, cod_acordo, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor_pago) * 1 / 100)),2) as multa," &
                "round((((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," &
                "round((valor_pago + ((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor_pago) * 1 / 100)),2) as total " &
                "from verifica_debito() where codigo_cidade = " & CInt(cbCidade.SelectedValue) &
                " and data_vencimento < " & d.Pdt(dtIni.Value.Date) & " and data_recebimento is null " &
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, " &
                "tipo_documento, nossonumero, cod_acordo order by nome_cliente"
                strTitulo = rbSintetico.Text & " " & rbCidade.Text
            ElseIf rbAnalitico.Checked = True And rbGeral.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, tipo_documento, " &
                "nossonumero, cod_acordo, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor_pago) * 1 / 100)),2) as multa," &
                "round((((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," &
                "round((valor_pago + ((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor_pago) * 1 / 100)),2) as total " &
                "from verifica_debito() where data_vencimento < " & d.Pdt(dtIni.Value.Date) &
                " and data_recebimento is null " &
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, " &
                "tipo_documento, nossonumero, cod_acordo order by nome_cliente"
                strTitulo = rbAnalitico.Text & " " & rbGeral.Text
            ElseIf rbAnalitico.Checked = True And rbCliente.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, tipo_documento, " &
                "nossonumero, cod_acordo, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor_pago) * 1 / 100)),2) as multa," &
                "round((((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," &
                "round((valor_pago + ((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor_pago) * 1 / 100)),2) as total " &
                "from verifica_debito() where cod_cliente = " & CInt(txtCodigo.Text) &
                " and data_vencimento < " & d.Pdt(dtIni.Value.Date) & " and data_recebimento is null " &
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, " &
                "tipo_documento, nossonumero, cod_acordo order by nome_cliente"
                strTitulo = rbAnalitico.Text & " " & rbCliente.Text
            ElseIf rbAnalitico.Checked = True And rbPromotora.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, tipo_documento, " &
                "nossonumero, cod_acordo, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor_pago) * 1 / 100)),2) as multa," &
                "round((((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," &
                "round((valor_pago + ((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor_pago) * 1 / 100)),2) as total " &
                "from verifica_debito() where cod_promotor = " & CInt(cbPromotor.SelectedValue) &
                " and data_vencimento < " & d.Pdt(dtIni.Value.Date) & " and data_recebimento is null " &
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, " &
                "tipo_documento, nossonumero, cod_acordo order by nome_cliente"
                strTitulo = rbAnalitico.Text & " " & rbPromotora.Text
            End If
        ElseIf rbAnalitico.Checked = True And rbCidade.Checked = True Then
            strsQL = "select cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, tipo_documento, " &
            "nossonumero, cod_acordo, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor_pago) * 1 / 100)),2) as multa," &
            "round((((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," &
            "round((valor_pago + ((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor_pago) * 1 / 100)),2) as total " &
            "from verifica_debito() where codigo_cidade = " & CInt(cbCidade.SelectedValue) &
            " and data_vencimento < " & d.Pdt(dtIni.Value.Date) & " and data_recebimento is null " &
            "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, " &
            "tipo_documento, nossonumero, cod_acordo order by nome_cliente"
            strTitulo = rbAnalitico.Text & " " & rbCliente.Text
        End If
        ''ttt
        If CheckBox1.Checked = False Then
            If rbSintetico.Checked = True And rbGeral.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, tipo_documento, " &
                "nossonumero, cod_acordo, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor_pago) * 1 / 100)),2) as multa," &
                "round((((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," &
                "round((valor_pago + ((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor_pago) * 1 / 100)),2) as total " &
                "from verifica_debito() where data_vencimento >= " & d.Pdt(dtIni.Value.Date) &
                " and data_vencimento < " & d.Pdt(dtFim.Value.Date) & " and data_recebimento is null " &
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, " &
                "tipo_documento, nossonumero, cod_acordo order by nome_cliente"
                strTitulo = rbSintetico.Text & " " & rbGeral.Text
            ElseIf rbSintetico.Checked = True And rbCliente.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, tipo_documento, " &
                "nossonumero, cod_acordo, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor_pago) * 1 / 100)),2) as multa," &
                "round((((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," &
                "round((valor_pago + ((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor_pago) * 1 / 100)),2) as total " &
                "from verifica_debito() where cod_cliente = " & CInt(txtCodigo.Text) & " and data_vencimento >= " & d.Pdt(dtIni.Value.Date) &
                " and data_vencimento < " & d.Pdt(dtFim.Value.Date) & " and data_recebimento is null " &
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, " &
                "tipo_documento, nossonumero, cod_acordo order by nome_cliente"
                strTitulo = rbSintetico.Text & " " & rbCliente.Text
            ElseIf rbSintetico.Checked = True And rbPromotora.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, tipo_documento, " &
                "nossonumero, cod_acordo, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor_pago) * 1 / 100)),2) as multa," &
                "round((((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," &
                "round((valor_pago + ((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor_pago) * 1 / 100)),2) as total " &
                "from verifica_debito() where cod_promotor = " & CInt(cbPromotor.SelectedValue) & " and data_vencimento >= " & d.Pdt(dtIni.Value.Date) &
                " and data_vencimento < " & d.Pdt(dtFim.Value.Date) & " and data_recebimento is null " &
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, " &
                "tipo_documento, nossonumero, cod_acordo order by nome_cliente"
                strTitulo = rbSintetico.Text & " " & rbPromotora.Text
            ElseIf rbSintetico.Checked = True And rbCidade.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, tipo_documento, " &
                "nossonumero, cod_acordo, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor_pago) * 1 / 100)),2) as multa," &
                "round((((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," &
                "round((valor_pago + ((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor_pago) * 1 / 100)),2) as total " &
                "from verifica_debito() where codigo_cidade = " & CInt(cbCidade.SelectedValue) & " and data_vencimento >= " & d.Pdt(dtIni.Value.Date) &
                " and data_vencimento < " & d.Pdt(dtFim.Value.Date) & " and data_recebimento is null " &
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, " &
                "tipo_documento, nossonumero, cod_acordo order by nome_cliente"
                strTitulo = rbSintetico.Text & " " & rbCidade.Text
            ElseIf rbAnalitico.Checked = True And rbGeral.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, tipo_documento, " &
                "nossonumero, cod_acordo, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor_pago) * 1 / 100)),2) as multa," &
                "round((((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," &
                "round((valor_pago + ((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor_pago) * 1 / 100)),2) as total " &
                "from verifica_debito() where data_vencimento >= " & d.Pdt(dtIni.Value.Date) &
                "and data_vencimento < " & d.Pdt(dtFim.Value.Date) & " and data_recebimento is null " &
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, " &
                "tipo_documento, nossonumero, cod_acordo order by nome_cliente"
                strTitulo = rbAnalitico.Text & " " & rbGeral.Text
            ElseIf rbAnalitico.Checked = True And rbCliente.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, tipo_documento, " &
                "nossonumero, cod_acordo, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor_pago) * 1 / 100)),2) as multa," &
                "round((((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," &
                "round((valor_pago + ((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor_pago) * 1 / 100)),2) as total " &
                "from verifica_debito() where cod_cliente = " & CInt(txtCodigo.Text) & " and data_vencimento >= " & d.Pdt(dtIni.Value.Date) &
                "and data_vencimento < " & d.Pdt(dtFim.Value.Date) & " and data_recebimento is null " &
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, " &
                "tipo_documento, nossonumero, cod_acordo order by nome_cliente"
                strTitulo = rbAnalitico.Text & " " & rbCliente.Text
            ElseIf rbAnalitico.Checked = True And rbPromotora.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, tipo_documento, " &
                "nossonumero, cod_acordo, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor_pago) * 1 / 100)),2) as multa," &
                "round((((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," &
                "round((valor_pago + ((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor_pago) * 1 / 100)),2) as total " &
                "from verifica_debito() where cod_promotor = " & CInt(cbPromotor.SelectedValue) & " and data_vencimento >= " & d.Pdt(dtIni.Value.Date) &
                "and data_vencimento < " & d.Pdt(dtFim.Value.Date) & " and data_recebimento is null " &
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, " &
                "tipo_documento, nossonumero, cod_acordo order by nome_cliente"
                strTitulo = rbAnalitico.Text & " " & rbPromotora.Text
            ElseIf rbAnalitico.Checked = True And rbCidade.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, tipo_documento, " &
                "nossonumero, cod_acordo, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor_pago) * 1 / 100)),2) as multa," &
                "round((((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," &
                "round((valor_pago + ((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor_pago) * 1 / 100)),2) as total " &
                "from verifica_debito() where codigo_cidade = " & CInt(cbCidade.SelectedValue) & " and data_vencimento >= " & d.Pdt(dtIni.Value.Date) &
                "and data_vencimento < " & d.Pdt(dtFim.Value.Date) & " and data_recebimento is null " &
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, " &
                "tipo_documento, nossonumero, cod_acordo order by nome_cliente"
                strTitulo = rbAnalitico.Text & " " & rbCidade.Text
            End If
        End If

        Try
            If rbSintetico.Checked = True Then
                d.conecta()
                Dim da As New SqlDataAdapter(strsQL, d.con)
                Dim ds As New DataSet
                da.Fill(ds, "Cliente")
                If ds.Tables(0).Rows.Count > 0 Then
                    rs.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait
                    rs.Label3.Text = "Demonstrativo de Débito de Cliente " & strTitulo
                    rs.DataSource = ds.Tables(0)
                    f.Relat(rs)
                    f.ShowDialog()
                    f.Dispose()
                Else
                    MessageBox.Show("Nenhum registro foi encontrado encontrado.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                d.desconecta()
            End If

            If rbAnalitico.Checked = True Then
                d.conecta()
                Dim da As New SqlDataAdapter(strsQL, d.con)
                Dim ds As New DataSet
                da.Fill(ds, "Cliente")
                If ds.Tables(0).Rows.Count > 0 Then
                    ra.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait
                    ra.Label3.Text = "Demonstrativo de Débito de Cliente " & strTitulo
                    ra.DataSource = ds.Tables(0)
                    f.Relat(ra)
                    f.ShowDialog()
                    f.Dispose()
                Else
                    MessageBox.Show("Nenhum registro foi encontrado encontrado.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                d.desconecta()
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub btnSair_Click_1(sender As System.Object, e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub rbCliente_Click(sender As System.Object, e As System.EventArgs) Handles rbCliente.Click
        Label1.Visible = True
        Label1.Text = "Código Cliente"
        txtCodigo.Visible = True
        cbPromotor.Visible = False
        cbCidade.Visible = False
    End Sub

    Private Sub rbGeral_Click(sender As System.Object, e As System.EventArgs) Handles rbGeral.Click
        Label1.Visible = False
        txtCodigo.Visible = False
        cbPromotor.Visible = False
        cbCidade.Visible = False
    End Sub

    Private Sub CheckBox1_Click(sender As System.Object, e As System.EventArgs) Handles CheckBox1.Click
        If CheckBox1.Checked = False Then
            GroupBox3.Enabled = True
        Else
            GroupBox3.Enabled = False
        End If
    End Sub


    Private Sub exportaPDF(ByVal r As DataDynamics.ActiveReports.Document.Document, ByVal path As String)
        If MessageBox.Show("Deseja exportar os dados para área de trabalho?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            pdfExport.Export(r, path)
        End If
    End Sub

    Private Sub exportaExcel(ByVal r As DataDynamics.ActiveReports.Document.Document, ByVal path As String)
        If MessageBox.Show("Deseja exportar os dados para área de trabalho?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            excelExport.Export(r, path)
        End If
    End Sub

    Private Sub frmDebitoCliente_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        combo_promotor()
        combo_cidade()
    End Sub

    Private Sub combo_promotor()
        Dim strSQL As String = "SELECT * FROM PROMOTOR"
        d.conecta()
        Dim da As New SqlDataAdapter(strSQL, d.con)
        Dim ds As New DataSet
        da.Fill(ds, "Promotor")
        d.desconecta()

        cbPromotor.DataSource = ds.Tables(0)
        cbPromotor.DisplayMember = "promotor"
        cbPromotor.ValueMember = "cod_promotor"
    End Sub

    Private Sub combo_cidade()
        cbCidade.DataSource = cidade.cidades
        cbCidade.DisplayMember = "Cidade"
        cbCidade.ValueMember = "codigo"
    End Sub

    Private Sub rbPromotora_Click(sender As System.Object, e As System.EventArgs) Handles rbPromotora.Click
        Label1.Visible = True
        Label1.Text = "Promotor"
        txtCodigo.Visible = False
        cbCidade.Visible = False
        cbPromotor.Visible = True
        cbPromotor.Location = New System.Drawing.Point(9, 208)
    End Sub

    Private Sub rbCidade_Click(sender As System.Object, e As System.EventArgs) Handles rbCidade.Click
        Label1.Text = ""
        Label1.Text = "Cidade"
        Label1.Visible = True
        cbCidade.Visible = True
        cbCidade.Location = New System.Drawing.Point(9, 208)
        cbCidade.Width = 227
        txtCodigo.Visible = False
        cbPromotor.Visible = False
    End Sub

    Private Sub btnPDF_Click(sender As System.Object, e As System.EventArgs) Handles btnPDF.Click
        Dim f As New frmRpt
        Dim rs As New rptDebitoClienteSintetico
        Dim ra As New rptDebitoClienteAnalitico
        Dim strsQL As String = ""
        Dim strTitulo As String = ""
        Dim path As String = ""

        If CheckBox1.Checked = True Then
            If rbSintetico.Checked = True And rbGeral.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, tipo_documento, " &
                "nossonumero, cod_acordo, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor_pago) * 1 / 100)),2) as multa," &
                "round((((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," &
                "round((valor_pago + ((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor_pago) * 1 / 100)),2) as total " &
                "from verifica_debito() where data_vencimento < " & d.Pdt(dtIni.Value.Date) &
                " and data_recebimento is null " &
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, " &
                "tipo_documento, nossonumero, cod_acordo order by nome_cliente"
                strTitulo = rbSintetico.Text & " " & rbGeral.Text
            ElseIf rbSintetico.Checked = True And rbCliente.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, tipo_documento, " &
                "nossonumero, cod_acordo, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor_pago) * 1 / 100)),2) as multa," &
                "round((((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," &
                "round((valor_pago + ((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor_pago) * 1 / 100)),2) as total " &
                "from verifica_debito() where cod_cliente = " & CInt(txtCodigo.Text) &
                " and data_vencimento < " & d.Pdt(dtIni.Value.Date) & " and data_recebimento is null " &
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, " &
                "tipo_documento, nossonumero, cod_acordo order by nome_cliente"
                strTitulo = rbSintetico.Text & " " & rbCliente.Text
            ElseIf rbSintetico.Checked = True And rbPromotora.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, tipo_documento, " &
                "nossonumero, cod_acordo, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor_pago) * 1 / 100)),2) as multa," &
                "round((((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," &
                "round((valor_pago + ((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor_pago) * 1 / 100)),2) as total " &
                "from verifica_debito() where cod_promotor = " & CInt(cbPromotor.SelectedValue) &
                " and data_vencimento < " & d.Pdt(dtIni.Value.Date) & " and data_recebimento is null " &
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, " &
                "tipo_documento, nossonumero, cod_acordo order by nome_cliente"
                strTitulo = rbSintetico.Text & " " & rbPromotora.Text
            ElseIf rbSintetico.Checked = True And rbCidade.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, tipo_documento, " &
                "nossonumero, cod_acordo, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor_pago) * 1 / 100)),2) as multa," &
                "round((((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," &
                "round((valor_pago + ((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor_pago) * 1 / 100)),2) as total " &
                "from verifica_debito() where codigo_cidade = " & CInt(cbCidade.SelectedValue) &
                " and data_vencimento < " & d.Pdt(dtIni.Value.Date) & " and data_recebimento is null " &
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, " &
                "tipo_documento, nossonumero, cod_acordo order by nome_cliente"
                strTitulo = rbSintetico.Text & " " & rbCidade.Text
            ElseIf rbAnalitico.Checked = True And rbGeral.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, tipo_documento, " &
                "nossonumero, cod_acordo, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor_pago) * 1 / 100)),2) as multa," &
                "round((((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," &
                "round((valor_pago + ((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor_pago) * 1 / 100)),2) as total " &
                "from verifica_debito() where data_vencimento < " & d.Pdt(dtIni.Value.Date) &
                " and data_recebimento is null " &
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, " &
                "tipo_documento, nossonumero, cod_acordo order by nome_cliente"
                strTitulo = rbAnalitico.Text & " " & rbGeral.Text
            ElseIf rbAnalitico.Checked = True And rbCliente.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, tipo_documento, " &
                "nossonumero, cod_acordo, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor_pago) * 1 / 100)),2) as multa," &
                "round((((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," &
                "round((valor_pago + ((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor_pago) * 1 / 100)),2) as total " &
                "from verifica_debito() where cod_cliente = " & CInt(txtCodigo.Text) &
                " and data_vencimento < " & d.Pdt(dtIni.Value.Date) & " and data_recebimento is null " &
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, " &
                "tipo_documento, nossonumero, cod_acordo order by nome_cliente"
                strTitulo = rbAnalitico.Text & " " & rbCliente.Text
            ElseIf rbAnalitico.Checked = True And rbPromotora.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, tipo_documento, " &
                "nossonumero, cod_acordo, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor_pago) * 1 / 100)),2) as multa," &
                "round((((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," &
                "round((valor_pago + ((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor_pago) * 1 / 100)),2) as total " &
                "from verifica_debito() where cod_promotor = " & CInt(cbPromotor.SelectedValue) &
                " and data_vencimento < " & d.Pdt(dtIni.Value.Date) & " and data_recebimento is null " &
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, " &
                "tipo_documento, nossonumero, cod_acordo order by nome_cliente"
                strTitulo = rbAnalitico.Text & " " & rbPromotora.Text
            End If
        ElseIf rbAnalitico.Checked = True And rbCidade.Checked = True Then
            strsQL = "select cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, tipo_documento, " &
            "nossonumero, cod_acordo, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor_pago) * 1 / 100)),2) as multa," &
            "round((((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," &
            "round((valor_pago + ((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor_pago) * 1 / 100)),2) as total " &
            "from verifica_debito() where codigo_cidade = " & CInt(cbCidade.SelectedValue) &
            " and data_vencimento < " & d.Pdt(dtIni.Value.Date) & " and data_recebimento is null " &
            "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, " &
            "tipo_documento, nossonumero, cod_acordo order by nome_cliente"
            strTitulo = rbAnalitico.Text & " " & rbCliente.Text
        End If
        ''ttt
        If CheckBox1.Checked = False Then
            If rbSintetico.Checked = True And rbGeral.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, tipo_documento, " &
                "nossonumero, cod_acordo, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor_pago) * 1 / 100)),2) as multa," &
                "round((((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," &
                "round((valor_pago + ((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor_pago) * 1 / 100)),2) as total " &
                "from verifica_debito() where data_vencimento >= " & d.Pdt(dtIni.Value.Date) &
                " and data_vencimento < " & d.Pdt(dtFim.Value.Date) & " and data_recebimento is null " &
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, " &
                "tipo_documento, nossonumero, cod_acordo order by nome_cliente"
                strTitulo = rbSintetico.Text & " " & rbGeral.Text
            ElseIf rbSintetico.Checked = True And rbCliente.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, tipo_documento, " &
                "nossonumero, cod_acordo, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor_pago) * 1 / 100)),2) as multa," &
                "round((((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," &
                "round((valor_pago + ((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor_pago) * 1 / 100)),2) as total " &
                "from verifica_debito() where cod_cliente = " & CInt(txtCodigo.Text) & " and data_vencimento >= " & d.Pdt(dtIni.Value.Date) &
                " and data_vencimento < " & d.Pdt(dtFim.Value.Date) & " and data_recebimento is null " &
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, " &
                "tipo_documento, nossonumero, cod_acordo order by nome_cliente"
                strTitulo = rbSintetico.Text & " " & rbCliente.Text
            ElseIf rbSintetico.Checked = True And rbPromotora.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, tipo_documento, " &
                "nossonumero, cod_acordo, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor_pago) * 1 / 100)),2) as multa," &
                "round((((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," &
                "round((valor_pago + ((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor_pago) * 1 / 100)),2) as total " &
                "from verifica_debito() where cod_promotor = " & CInt(cbPromotor.SelectedValue) & " and data_vencimento >= " & d.Pdt(dtIni.Value.Date) &
                " and data_vencimento < " & d.Pdt(dtFim.Value.Date) & " and data_recebimento is null " &
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, " &
                "tipo_documento, nossonumero, cod_acordo order by nome_cliente"
                strTitulo = rbSintetico.Text & " " & rbPromotora.Text
            ElseIf rbSintetico.Checked = True And rbCidade.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, tipo_documento, " &
                "nossonumero, cod_acordo, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor_pago) * 1 / 100)),2) as multa," &
                "round((((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," &
                "round((valor_pago + ((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor_pago) * 1 / 100)),2) as total " &
                "from verifica_debito() where codigo_cidade = " & CInt(cbCidade.SelectedValue) & " and data_vencimento >= " & d.Pdt(dtIni.Value.Date) &
                " and data_vencimento < " & d.Pdt(dtFim.Value.Date) & " and data_recebimento is null " &
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, " &
                "tipo_documento, nossonumero, cod_acordo order by nome_cliente"
                strTitulo = rbSintetico.Text & " " & rbCidade.Text
            ElseIf rbAnalitico.Checked = True And rbGeral.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, tipo_documento, " &
                "nossonumero, cod_acordo, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor_pago) * 1 / 100)),2) as multa," &
                "round((((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," &
                "round((valor_pago + ((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor_pago) * 1 / 100)),2) as total " &
                "from verifica_debito() where data_vencimento >= " & d.Pdt(dtIni.Value.Date) &
                "and data_vencimento < " & d.Pdt(dtFim.Value.Date) & " and data_recebimento is null " &
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, " &
                "tipo_documento, nossonumero, cod_acordo order by nome_cliente"
                strTitulo = rbAnalitico.Text & " " & rbGeral.Text
            ElseIf rbAnalitico.Checked = True And rbCliente.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, tipo_documento, " &
                "nossonumero, cod_acordo, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor_pago) * 1 / 100)),2) as multa," &
                "round((((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," &
                "round((valor_pago + ((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor_pago) * 1 / 100)),2) as total " &
                "from verifica_debito() where cod_cliente = " & CInt(txtCodigo.Text) & " and data_vencimento >= " & d.Pdt(dtIni.Value.Date) &
                "and data_vencimento < " & d.Pdt(dtFim.Value.Date) & " and data_recebimento is null " &
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, " &
                "tipo_documento, nossonumero, cod_acordo order by nome_cliente"
                strTitulo = rbAnalitico.Text & " " & rbCliente.Text
            ElseIf rbAnalitico.Checked = True And rbPromotora.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, tipo_documento, " &
                "nossonumero, cod_acordo, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor_pago) * 1 / 100)),2) as multa," &
                "round((((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," &
                "round((valor_pago + ((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor_pago) * 1 / 100)),2) as total " &
                "from verifica_debito() where cod_promotor = " & CInt(cbPromotor.SelectedValue) & " and data_vencimento >= " & d.Pdt(dtIni.Value.Date) &
                "and data_vencimento < " & d.Pdt(dtFim.Value.Date) & " and data_recebimento is null " &
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, " &
                "tipo_documento, nossonumero, cod_acordo order by nome_cliente"
                strTitulo = rbAnalitico.Text & " " & rbPromotora.Text
            ElseIf rbAnalitico.Checked = True And rbCidade.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, tipo_documento, " &
                "nossonumero, cod_acordo, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor_pago) * 1 / 100)),2) as multa," &
                "round((((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," &
                "round((valor_pago + ((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor_pago) * 1 / 100)),2) as total " &
                "from verifica_debito() where codigo_cidade = " & CInt(cbCidade.SelectedValue) & " and data_vencimento >= " & d.Pdt(dtIni.Value.Date) &
                "and data_vencimento < " & d.Pdt(dtFim.Value.Date) & " and data_recebimento is null " &
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, " &
                "tipo_documento, nossonumero, cod_acordo order by nome_cliente"
                strTitulo = rbAnalitico.Text & " " & rbCidade.Text
            End If
        End If

        Try
            If rbSintetico.Checked = True Then
                d.conecta()
                Dim da As New SqlDataAdapter(strsQL, d.con)
                Dim ds As New DataSet
                da.Fill(ds, "Cliente")
                If ds.Tables(0).Rows.Count > 0 Then
                    rs.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait
                    rs.Label3.Text = "Demonstrativo de Débito de Cliente " & strTitulo
                    rs.DataSource = ds.Tables(0)
                    If rbGeral.Checked Then
                        path = My.Computer.FileSystem.SpecialDirectories.Desktop & "\Debito Geral.pdf"
                    End If
                    If rbCliente.Checked = True Then
                        path = My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & ds.Tables(0).Rows(0)("nome_cliente").ToString & ".pdf"
                    End If
                    If rbPromotora.Checked = True Then
                        path = My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & cbPromotor.Text & ".pdf"
                    End If
                    If rbCidade.Checked = True Then
                        path = My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & cbCidade.Text & ".pdf"
                    End If
                    f.Relat(rs)
                    f.Dispose()
                    exportaPDF(rs.Document, path)
                Else
                    MessageBox.Show("Nenhum registro foi encontrado encontrado.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                d.desconecta()
            End If

            If rbAnalitico.Checked = True Then
                d.conecta()
                Dim da As New SqlDataAdapter(strsQL, d.con)
                Dim ds As New DataSet
                da.Fill(ds, "Cliente")
                If ds.Tables(0).Rows.Count > 0 Then
                    ra.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait
                    ra.Label3.Text = "Demonstrativo de Débito de Cliente " & strTitulo
                    ra.DataSource = ds.Tables(0)
                    If rbGeral.Checked Then
                        path = My.Computer.FileSystem.SpecialDirectories.Desktop & "\Debito Geral.pdf"
                    End If
                    If rbCliente.Checked = True Then
                        path = My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & ds.Tables(0).Rows(0)("nome_cliente").ToString & ".pdf"
                    End If
                    If rbPromotora.Checked = True Then
                        path = My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & cbPromotor.Text & ".pdf"
                    End If
                    If rbCidade.Checked = True Then
                        path = My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & cbCidade.Text & ".pdf"
                    End If
                    f.Relat(ra)
                    f.Dispose()
                    exportaPDF(ra.Document, path)
                Else
                    MessageBox.Show("Nenhum registro foi encontrado encontrado.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                d.desconecta()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnExcel_Click(sender As System.Object, e As System.EventArgs) Handles btnExcel.Click
        Dim f As New frmRpt
        Dim rs As New rptDebitoClienteSintetico
        Dim ra As New rptDebitoClienteAnalitico
        Dim strsQL As String = ""
        Dim strTitulo As String = ""
        Dim path As String = ""

        If CheckBox1.Checked = True Then
            If rbSintetico.Checked = True And rbGeral.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, tipo_documento, " &
                "nossonumero, cod_acordo, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor_pago) * 1 / 100)),2) as multa," &
                "round((((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," &
                "round((valor_pago + ((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor_pago) * 1 / 100)),2) as total " &
                "from verifica_debito() where data_vencimento < " & d.Pdt(dtIni.Value.Date) &
                " and data_recebimento is null " &
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, " &
                "tipo_documento, nossonumero, cod_acordo order by nome_cliente"
                strTitulo = rbSintetico.Text & " " & rbGeral.Text
            ElseIf rbSintetico.Checked = True And rbCliente.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, tipo_documento, " &
                "nossonumero, cod_acordo, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor_pago) * 1 / 100)),2) as multa," &
                "round((((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," &
                "round((valor_pago + ((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor_pago) * 1 / 100)),2) as total " &
                "from verifica_debito() where cod_cliente = " & CInt(txtCodigo.Text) &
                " and data_vencimento < " & d.Pdt(dtIni.Value.Date) & " and data_recebimento is null " &
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, " &
                "tipo_documento, nossonumero, cod_acordo order by nome_cliente"
                strTitulo = rbSintetico.Text & " " & rbCliente.Text
            ElseIf rbSintetico.Checked = True And rbPromotora.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, tipo_documento, " &
                "nossonumero, cod_acordo, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor_pago) * 1 / 100)),2) as multa," &
                "round((((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," &
                "round((valor_pago + ((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor_pago) * 1 / 100)),2) as total " &
                "from verifica_debito() where cod_promotor = " & CInt(cbPromotor.SelectedValue) &
                " and data_vencimento < " & d.Pdt(dtIni.Value.Date) & " and data_recebimento is null " &
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, " &
                "tipo_documento, nossonumero, cod_acordo order by nome_cliente"
                strTitulo = rbSintetico.Text & " " & rbPromotora.Text
            ElseIf rbSintetico.Checked = True And rbCidade.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, tipo_documento, " &
                "nossonumero, cod_acordo, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor_pago) * 1 / 100)),2) as multa," &
                "round((((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," &
                "round((valor_pago + ((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor_pago) * 1 / 100)),2) as total " &
                "from verifica_debito() where codigo_cidade = " & CInt(cbCidade.SelectedValue) &
                " and data_vencimento < " & d.Pdt(dtIni.Value.Date) & " and data_recebimento is null " &
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, " &
                "tipo_documento, nossonumero, cod_acordo order by nome_cliente"
                strTitulo = rbSintetico.Text & " " & rbCidade.Text
            ElseIf rbAnalitico.Checked = True And rbGeral.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, tipo_documento, " &
                "nossonumero, cod_acordo, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor_pago) * 1 / 100)),2) as multa," &
                "round((((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," &
                "round((valor_pago + ((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor_pago) * 1 / 100)),2) as total " &
                "from verifica_debito() where data_vencimento < " & d.Pdt(dtIni.Value.Date) &
                " and data_recebimento is null " &
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, " &
                "tipo_documento, nossonumero, cod_acordo order by nome_cliente"
                strTitulo = rbAnalitico.Text & " " & rbGeral.Text
            ElseIf rbAnalitico.Checked = True And rbCliente.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, tipo_documento, " &
                "nossonumero, cod_acordo, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor_pago) * 1 / 100)),2) as multa," &
                "round((((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," &
                "round((valor_pago + ((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor_pago) * 1 / 100)),2) as total " &
                "from verifica_debito() where cod_cliente = " & CInt(txtCodigo.Text) &
                " and data_vencimento < " & d.Pdt(dtIni.Value.Date) & " and data_recebimento is null " &
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, " &
                "tipo_documento, nossonumero, cod_acordo order by nome_cliente"
                strTitulo = rbAnalitico.Text & " " & rbCliente.Text
            ElseIf rbAnalitico.Checked = True And rbPromotora.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, tipo_documento, " &
                "nossonumero, cod_acordo, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor_pago) * 1 / 100)),2) as multa," &
                "round((((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," &
                "round((valor_pago + ((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor_pago) * 1 / 100)),2) as total " &
                "from verifica_debito() where cod_promotor = " & CInt(cbPromotor.SelectedValue) &
                " and data_vencimento < " & d.Pdt(dtIni.Value.Date) & " and data_recebimento is null " &
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, " &
                "tipo_documento, nossonumero, cod_acordo order by nome_cliente"
                strTitulo = rbAnalitico.Text & " " & rbPromotora.Text
            End If
        ElseIf rbAnalitico.Checked = True And rbCidade.Checked = True Then
            strsQL = "select cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, tipo_documento, " &
            "nossonumero, cod_acordo, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor_pago) * 1 / 100)),2) as multa," &
            "round((((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," &
            "round((valor_pago + ((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor_pago) * 1 / 100)),2) as total " &
            "from verifica_debito() where codigo_cidade = " & CInt(cbCidade.SelectedValue) &
            " and data_vencimento < " & d.Pdt(dtIni.Value.Date) & " and data_recebimento is null " &
            "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, " &
            "tipo_documento, nossonumero, cod_acordo order by nome_cliente"
            strTitulo = rbAnalitico.Text & " " & rbCliente.Text
        End If
        ''ttt
        If CheckBox1.Checked = False Then
            If rbSintetico.Checked = True And rbGeral.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, tipo_documento, " &
                "nossonumero, cod_acordo, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor_pago) * 1 / 100)),2) as multa," &
                "round((((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," &
                "round((valor_pago + ((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor_pago) * 1 / 100)),2) as total " &
                "from verifica_debito() where data_vencimento >= " & d.Pdt(dtIni.Value.Date) &
                " and data_vencimento < " & d.Pdt(dtFim.Value.Date) & " and data_recebimento is null " &
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, " &
                "tipo_documento, nossonumero, cod_acordo order by nome_cliente"
                strTitulo = rbSintetico.Text & " " & rbGeral.Text
            ElseIf rbSintetico.Checked = True And rbCliente.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, tipo_documento, " &
                "nossonumero, cod_acordo, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor_pago) * 1 / 100)),2) as multa," &
                "round((((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," &
                "round((valor_pago + ((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor_pago) * 1 / 100)),2) as total " &
                "from verifica_debito() where cod_cliente = " & CInt(txtCodigo.Text) & " and data_vencimento >= " & d.Pdt(dtIni.Value.Date) &
                " and data_vencimento < " & d.Pdt(dtFim.Value.Date) & " and data_recebimento is null " &
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, " &
                "tipo_documento, nossonumero, cod_acordo order by nome_cliente"
                strTitulo = rbSintetico.Text & " " & rbCliente.Text
            ElseIf rbSintetico.Checked = True And rbPromotora.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, tipo_documento, " &
                "nossonumero, cod_acordo, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor_pago) * 1 / 100)),2) as multa," &
                "round((((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," &
                "round((valor_pago + ((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor_pago) * 1 / 100)),2) as total " &
                "from verifica_debito() where cod_promotor = " & CInt(cbPromotor.SelectedValue) & " and data_vencimento >= " & d.Pdt(dtIni.Value.Date) &
                " and data_vencimento < " & d.Pdt(dtFim.Value.Date) & " and data_recebimento is null " &
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, " &
                "tipo_documento, nossonumero, cod_acordo order by nome_cliente"
                strTitulo = rbSintetico.Text & " " & rbPromotora.Text
            ElseIf rbSintetico.Checked = True And rbCidade.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, tipo_documento, " &
                "nossonumero, cod_acordo, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor_pago) * 1 / 100)),2) as multa," &
                "round((((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," &
                "round((valor_pago + ((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor_pago) * 1 / 100)),2) as total " &
                "from verifica_debito() where codigo_cidade = " & CInt(cbCidade.SelectedValue) & " and data_vencimento >= " & d.Pdt(dtIni.Value.Date) &
                " and data_vencimento < " & d.Pdt(dtFim.Value.Date) & " and data_recebimento is null " &
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, " &
                "tipo_documento, nossonumero, cod_acordo order by nome_cliente"
                strTitulo = rbSintetico.Text & " " & rbCidade.Text
            ElseIf rbAnalitico.Checked = True And rbGeral.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, tipo_documento, " &
                "nossonumero, cod_acordo, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor_pago) * 1 / 100)),2) as multa," &
                "round((((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," &
                "round((valor_pago + ((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor_pago) * 1 / 100)),2) as total " &
                "from verifica_debito() where data_vencimento >= " & d.Pdt(dtIni.Value.Date) &
                "and data_vencimento < " & d.Pdt(dtFim.Value.Date) & " and data_recebimento is null " &
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, " &
                "tipo_documento, nossonumero, cod_acordo order by nome_cliente"
                strTitulo = rbAnalitico.Text & " " & rbGeral.Text
            ElseIf rbAnalitico.Checked = True And rbCliente.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, tipo_documento, " &
                "nossonumero, cod_acordo, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor_pago) * 1 / 100)),2) as multa," &
                "round((((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," &
                "round((valor_pago + ((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor_pago) * 1 / 100)),2) as total " &
                "from verifica_debito() where cod_cliente = " & CInt(txtCodigo.Text) & " and data_vencimento >= " & d.Pdt(dtIni.Value.Date) &
                "and data_vencimento < " & d.Pdt(dtFim.Value.Date) & " and data_recebimento is null " &
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, " &
                "tipo_documento, nossonumero, cod_acordo order by nome_cliente"
                strTitulo = rbAnalitico.Text & " " & rbCliente.Text
            ElseIf rbAnalitico.Checked = True And rbPromotora.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, tipo_documento, " &
                "nossonumero, cod_acordo, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor_pago) * 1 / 100)),2) as multa," &
                "round((((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," &
                "round((valor_pago + ((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor_pago) * 1 / 100)),2) as total " &
                "from verifica_debito() where cod_promotor = " & CInt(cbPromotor.SelectedValue) & " and data_vencimento >= " & d.Pdt(dtIni.Value.Date) &
                "and data_vencimento < " & d.Pdt(dtFim.Value.Date) & " and data_recebimento is null " &
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, " &
                "tipo_documento, nossonumero, cod_acordo order by nome_cliente"
                strTitulo = rbAnalitico.Text & " " & rbPromotora.Text
            ElseIf rbAnalitico.Checked = True And rbCidade.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, tipo_documento, " &
                "nossonumero, cod_acordo, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor_pago) * 1 / 100)),2) as multa," &
                "round((((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," &
                "round((valor_pago + ((valor_pago) * (5/30.0) / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor_pago) * 1 / 100)),2) as total " &
                "from verifica_debito() where codigo_cidade = " & CInt(cbCidade.SelectedValue) & " and data_vencimento >= " & d.Pdt(dtIni.Value.Date) &
                "and data_vencimento < " & d.Pdt(dtFim.Value.Date) & " and data_recebimento is null " &
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor_pago, data_vencimento, data_lancamento, documento, " &
                "tipo_documento, nossonumero, cod_acordo order by nome_cliente"
                strTitulo = rbAnalitico.Text & " " & rbCidade.Text
            End If
        End If

        Try
            If rbSintetico.Checked = True Then
                d.conecta()
                Dim da As New SqlDataAdapter(strsQL, d.con)
                Dim ds As New DataSet
                da.Fill(ds, "Cliente")
                If ds.Tables(0).Rows.Count > 0 Then
                    rs.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait
                    rs.Label3.Text = "Demonstrativo de Débito de Cliente " & strTitulo
                    rs.DataSource = ds.Tables(0)
                    If rbGeral.Checked Then
                        path = My.Computer.FileSystem.SpecialDirectories.Desktop & "\Debito Geral.xls"
                    End If
                    If rbCliente.Checked = True Then
                        path = My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & ds.Tables(0).Rows(0)("nome_cliente").ToString & ".xls"
                    End If
                    If rbPromotora.Checked = True Then
                        path = My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & cbPromotor.Text & ".xls"
                    End If
                    If rbCidade.Checked = True Then
                        path = My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & cbCidade.Text & ".xls"
                    End If
                    f.Relat(rs)
                    f.Dispose()
                    exportaExcel(rs.Document, path)
                Else
                    MessageBox.Show("Nenhum registro foi encontrado encontrado.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                d.desconecta()
            End If

            If rbAnalitico.Checked = True Then
                d.conecta()
                Dim da As New SqlDataAdapter(strsQL, d.con)
                Dim ds As New DataSet
                da.Fill(ds, "Cliente")
                If ds.Tables(0).Rows.Count > 0 Then
                    ra.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait
                    ra.Label3.Text = "Demonstrativo de Débito de Cliente " & strTitulo
                    ra.DataSource = ds.Tables(0)
                    If rbGeral.Checked Then
                        path = My.Computer.FileSystem.SpecialDirectories.Desktop & "\Debito Geral.xls"
                    End If
                    If rbCliente.Checked = True Then
                        path = My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & ds.Tables(0).Rows(0)("nome_cliente").ToString & ".xls"
                    End If
                    If rbPromotora.Checked = True Then
                        path = My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & cbPromotor.Text & ".xls"
                    End If
                    If rbCidade.Checked = True Then
                        path = My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & cbCidade.Text & ".xls"
                    End If
                    f.Relat(ra)
                    f.Dispose()
                    exportaExcel(ra.Document, path)
                Else
                    MessageBox.Show("Nenhum registro foi encontrado encontrado.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                d.desconecta()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class