Imports System.Data
Imports System.Data.SqlClient
Imports mrotica_util
Public Class frmDebitoClienteJurosMUlta
    Dim d As New dados
    Dim acesso As New objMaster
    Dim cidade As New objCliente
    Dim excelExport As New DataDynamics.ActiveReports.Export.Xls.XlsExport
    Dim pdfExport As New DataDynamics.ActiveReports.Export.Pdf.PdfExport

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        Dim f As New frmRpt
        Dim r As New rptDebitoClienteJurosMulta
        Dim strsQL As String = ""
        Dim strTitulo As String = ""

        If rbCliente.Checked = True Then
            If txtCodigo.Text = String.Empty Or txtTaxaCartorio.Text = String.Empty Then
                MessageBox.Show("Verifique o campo código do cliente ou taxa de cartório.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If

        If rbGeral.Checked = True Or rbPromotora.Checked = True Or rbCidade.Checked = True Then
            If txtTaxaCartorio.Text = String.Empty Then
                MessageBox.Show("Verifique o campo taxa de cartório.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If

        Try
            If cbGeral.Checked = True And rbGeral.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, Valor, data_vencimento, data_lancamento, documento, tipo_documento, " & _
                "nossonumero, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor) * 1 / 100)),2) as multa," & _
                "round((((valor) * 0.16 / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," & _
                "round((Valor + ((valor) * 0.16 / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor) * 1 / 100)),2) as total " & _
                "from verifica_debito() where data_vencimento < " & d.Pdt(acesso.retornaDataHoraServidor) & " and data_recebimento is null " & _
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor, data_vencimento, data_lancamento, documento, " & _
                "tipo_documento, nossonumero order by nome_cliente"
                strTitulo = "Demonstrativo de Débito Geral de Cliente com Juros/Multa e Taxa de Cartório"
            ElseIf cbGeral.Checked = True And rbCliente.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, Valor, data_vencimento, data_lancamento, documento, tipo_documento, " & _
                "nossonumero, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor) * 1 / 100)),2) as multa," & _
                "round((((valor) * 0.16 / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," & _
                "round((Valor + ((valor) * 0.16 / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor) * 1 / 100)),2) as total " & _
                "from verifica_debito() where cod_cliente = " & CInt(txtCodigo.Text) & _
                " and data_vencimento < " & d.Pdt(acesso.retornaDataHoraServidor) & " and data_recebimento is null " & _
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor, data_vencimento, data_lancamento, documento, " & _
                "tipo_documento, nossonumero order by nome_cliente"
                strTitulo = "Demonstrativo de Débito de Cliente com Juros/Multa e Taxa de Cartório"
            ElseIf cbGeral.Checked = True And rbPromotora.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, Valor, data_vencimento, data_lancamento, documento, tipo_documento, " & _
                "nossonumero, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor) * 1 / 100)),2) as multa," & _
                "round((((valor) * 0.16 / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," & _
                "round((Valor + ((valor) * 0.16 / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor) * 1 / 100)),2) as total " & _
                "from verifica_debito() where cod_promotor = " & CInt(cbPromotor.SelectedValue) & _
                " and data_vencimento < " & d.Pdt(acesso.retornaDataHoraServidor) & " and data_recebimento is null " & _
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor, data_vencimento, data_lancamento, documento, " & _
                "tipo_documento, nossonumero order by nome_cliente"
                strTitulo = "Demonstrativo de Débito de Cliente com Juros/Multa e Taxa de Cartório da promotor(a) " & cbPromotor.Text
            ElseIf cbGeral.Checked = True And rbCidade.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, Valor, data_vencimento, data_lancamento, documento, tipo_documento, " & _
                "nossonumero, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor) * 1 / 100)),2) as multa," & _
                "round((((valor) * 0.16 / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," & _
                "round((Valor + ((valor) * 0.16 / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor) * 1 / 100)),2) as total " & _
                "from verifica_debito() where codigo_cidade = " & CInt(cbCidade.SelectedValue) & _
                " and data_vencimento < " & d.Pdt(acesso.retornaDataHoraServidor) & " and data_recebimento is null " & _
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor, data_vencimento, data_lancamento, documento, " & _
                "tipo_documento, nossonumero order by nome_cliente"
                strTitulo = "Demonstrativo de Débito de Cliente com Juros/Multa e Taxa de Cartório da cidade " & cbCidade.Text
            End If


            If cbGeral.Checked = False And rbGeral.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, Valor, data_vencimento, data_lancamento, documento, tipo_documento, " & _
                "nossonumero, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor) * 1 / 100)),2) as multa," & _
                "round((((valor) * 0.16 / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," & _
                "round((Valor + ((valor) * 0.16 / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor) * 1 / 100)),2) as total " & _
                "from verifica_debito() where data_vencimento >= " & d.Pdt(dtIni.Value.Date) & _
                " and data_vencimento < " & d.Pdt(dtFim.Value.Date) & " and data_recebimento is null " & _
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor, data_vencimento, data_lancamento, documento, " & _
                "tipo_documento, nossonumero order by nome_cliente"
                strTitulo = "Demonstrativo de Débito Geral de Cliente com Juros/Multa e Taxa de Cartório"
            ElseIf cbGeral.Checked = False And rbCliente.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, Valor, data_vencimento, data_lancamento, documento, tipo_documento, " & _
                "nossonumero, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor) * 1 / 100)),2) as multa," & _
                "round((((valor) * 0.16 / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," & _
                "round((Valor + ((valor) * 0.16 / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor) * 1 / 100)),2) as total " & _
                "from verifica_debito() where cod_cliente = " & CInt(txtCodigo.Text) & _
                " and data_vencimento >= " & d.Pdt(dtIni.Value.Date) & _
                " and data_vencimento < " & d.Pdt(dtFim.Value.Date) & " and data_recebimento is null " & _
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor, data_vencimento, data_lancamento, documento, " & _
                "tipo_documento, nossonumero order by nome_cliente"
                strTitulo = "Demonstrativo de Débito de Cliente com Juros/Multa e Taxa de Cartório"
            ElseIf cbGeral.Checked = False And rbPromotora.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, Valor, data_vencimento, data_lancamento, documento, tipo_documento, " & _
                "nossonumero, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor) * 1 / 100)),2) as multa," & _
                "round((((valor) * 0.16 / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," & _
                "round((Valor + ((valor) * 0.16 / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor) * 1 / 100)),2) as total " & _
                "from verifica_debito() where cod_promotor = " & CInt(cbPromotor.SelectedValue) & _
                " and data_vencimento >= " & d.Pdt(dtIni.Value.Date) & _
                " and data_vencimento < " & d.Pdt(dtFim.Value.Date) & " and data_recebimento is null " & _
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor, data_vencimento, data_lancamento, documento, " & _
                "tipo_documento, nossonumero order by nome_cliente"
                strTitulo = "Demonstrativo de Débito de Cliente com Juros/Multa e Taxa de Cartório da promotor(a) " & cbPromotor.Text
            ElseIf cbGeral.Checked = False And rbCidade.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, Valor, data_vencimento, data_lancamento, documento, tipo_documento, " & _
                "nossonumero, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor) * 1 / 100)),2) as multa," & _
                "round((((valor) * 0.16 / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," & _
                "round((Valor + ((valor) * 0.16 / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor) * 1 / 100)),2) as total " & _
                "from verifica_debito() where codigo_cidade = " & CInt(cbCidade.SelectedValue) & _
                " and data_vencimento >= " & d.Pdt(dtIni.Value.Date) & _
                " and data_vencimento < " & d.Pdt(dtFim.Value.Date) & " and data_recebimento is null " & _
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor, data_vencimento, data_lancamento, documento, " & _
                "tipo_documento, nossonumero order by nome_cliente"
                strTitulo = "Demonstrativo de Débito de Cliente com Juros/Multa e Taxa de Cartório da cidade " & cbCidade.Text
            End If


            d.conecta()
            Dim da As New SqlDataAdapter(strsQL, d.con)
            Dim ds As New DataSet
            da.Fill(ds, "Cliente")
            r.TextBox9.Text = Format(CDbl(txtTaxaCartorio.Text), "#,##0.00")
            r.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape
            r.Label3.Text = strTitulo
            If ds.Tables(0).Rows.Count > 0 Then
                r.DataSource = ds.Tables(0)
            Else
                MessageBox.Show("Não há registro a ser exibido.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            f.Relat(r)
            f.ShowDialog()
            f.Dispose()
            d.desconecta()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub btnSair_Click_1(sender As System.Object, e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub rbCliente_Click(sender As System.Object, e As System.EventArgs)
        Label1.Visible = True
        txtCodigo.Visible = True
    End Sub



    Private Sub txtTaxaCartorio_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTaxaCartorio.KeyPress
        If Not IsNumeric(e.KeyChar) And (Not e.KeyChar = vbBack) And (Not e.KeyChar = ",") Then
            e.Handled = True
            MessageBox.Show("Campo só permite valor monetário no formato" & Chr(13) &
                            "da moeda corrente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub cbGeral_Click(sender As System.Object, e As System.EventArgs) Handles cbGeral.Click
        If cbGeral.Checked = True Then
            dtIni.Enabled = False
            dtFim.Enabled = False
        Else
            dtIni.Enabled = True
            dtFim.Enabled = True
        End If
    End Sub

    Private Sub txtCodigo_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        If Not Char.IsNumber(e.KeyChar) And (Not e.KeyChar = vbBack) Then
            e.Handled = True
            MessageBox.Show("Neste campo só é permitido números.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub frmDebitoClienteJurosMUlta_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label4.Location = New System.Drawing.Point(9, 118)
        txtTaxaCartorio.Location = New System.Drawing.Point(9, 134)
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
        txtCodigo.Visible = False
        Label1.Visible = True
        Label1.Text = "Promotor(a)"
        cbPromotor.Location = New System.Drawing.Point(9, 134)
        cbPromotor.Visible = True
        Label4.Location = New System.Drawing.Point(165, 118)
        txtTaxaCartorio.Location = New System.Drawing.Point(165, 134)
    End Sub

    Private Sub rbCidade_Click(sender As System.Object, e As System.EventArgs) Handles rbCidade.Click
        Label1.Text = ""
        txtCodigo.Visible = False
        cbPromotor.Visible = False
        Label1.Visible = True
        Label1.Text = "Cidade"
        cbCidade.Width = 208
        cbCidade.Location = New System.Drawing.Point(9, 134)
        cbCidade.Visible = True
        Label4.Location = New System.Drawing.Point(225, 118)
        txtTaxaCartorio.Location = New System.Drawing.Point(225, 134)
    End Sub

    Private Sub rbCliente_Click_1(sender As System.Object, e As System.EventArgs) Handles rbCliente.Click
        cbPromotor.Visible = False
        cbCidade.Visible = False
        Label1.Visible = True
        txtCodigo.Visible = True
        Label4.Location = New System.Drawing.Point(92, 118)
        txtTaxaCartorio.Location = New System.Drawing.Point(92, 134)
    End Sub


    Private Sub rbGeral_Click(sender As System.Object, e As System.EventArgs) Handles rbGeral.Click
        cbPromotor.Visible = False
        cbCidade.Visible = False
        Label1.Visible = False
        txtCodigo.Visible = False
        Label4.Location = New System.Drawing.Point(9, 118)
        txtTaxaCartorio.Location = New System.Drawing.Point(9, 134)
    End Sub

    Private Sub btnPDF_Click(sender As System.Object, e As System.EventArgs) Handles btnPDF.Click
        Dim f As New frmRpt
        Dim r As New rptDebitoClienteJurosMulta
        Dim strsQL As String = ""
        Dim strTitulo As String = ""
        Dim path As String = ""

        If rbCliente.Checked = True Then
            If txtCodigo.Text = String.Empty Or txtTaxaCartorio.Text = String.Empty Then
                MessageBox.Show("Verifique o campo código do cliente ou taxa de cartório.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If

        If rbGeral.Checked = True Or rbPromotora.Checked = True Or rbCidade.Checked = True Then
            If txtTaxaCartorio.Text = String.Empty Then
                MessageBox.Show("Verifique o campo taxa de cartório.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If

        Try
            If cbGeral.Checked = True And rbGeral.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, Valor, data_vencimento, data_lancamento, documento, tipo_documento, " & _
                "nossonumero, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor) * 1 / 100)),2) as multa," & _
                "round((((valor) * 0.16 / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," & _
                "round((Valor + ((valor) * 0.16 / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor) * 1 / 100)),2) as total " & _
                "from verifica_debito() where data_vencimento < " & d.Pdt(acesso.retornaDataHoraServidor) & " and data_recebimento is null " & _
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor, data_vencimento, data_lancamento, documento, " & _
                "tipo_documento, nossonumero order by nome_cliente"
                strTitulo = "Demonstrativo de Débito Geral de Cliente com Juros/Multa e Taxa de Cartório"
            ElseIf cbGeral.Checked = True And rbCliente.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, Valor, data_vencimento, data_lancamento, documento, tipo_documento, " & _
                "nossonumero, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor) * 1 / 100)),2) as multa," & _
                "round((((valor) * 0.16 / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," & _
                "round((Valor + ((valor) * 0.16 / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor) * 1 / 100)),2) as total " & _
                "from verifica_debito() where cod_cliente = " & CInt(txtCodigo.Text) & _
                " and data_vencimento < " & d.Pdt(acesso.retornaDataHoraServidor) & " and data_recebimento is null " & _
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor, data_vencimento, data_lancamento, documento, " & _
                "tipo_documento, nossonumero order by nome_cliente"
                strTitulo = "Demonstrativo de Débito de Cliente com Juros/Multa e Taxa de Cartório"
            ElseIf cbGeral.Checked = True And rbPromotora.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, Valor, data_vencimento, data_lancamento, documento, tipo_documento, " & _
                "nossonumero, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor) * 1 / 100)),2) as multa," & _
                "round((((valor) * 0.16 / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," & _
                "round((Valor + ((valor) * 0.16 / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor) * 1 / 100)),2) as total " & _
                "from verifica_debito() where cod_promotor = " & CInt(cbPromotor.SelectedValue) & _
                " and data_vencimento < " & d.Pdt(acesso.retornaDataHoraServidor) & " and data_recebimento is null " & _
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor, data_vencimento, data_lancamento, documento, " & _
                "tipo_documento, nossonumero order by nome_cliente"
                strTitulo = "Demonstrativo de Débito de Cliente com Juros/Multa e Taxa de Cartório da promotor(a) " & cbPromotor.Text
            ElseIf cbGeral.Checked = True And rbCidade.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, Valor, data_vencimento, data_lancamento, documento, tipo_documento, " & _
                "nossonumero, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor) * 1 / 100)),2) as multa," & _
                "round((((valor) * 0.16 / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," & _
                "round((Valor + ((valor) * 0.16 / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor) * 1 / 100)),2) as total " & _
                "from verifica_debito() where codigo_cidade = " & CInt(cbCidade.SelectedValue) & _
                " and data_vencimento < " & d.Pdt(acesso.retornaDataHoraServidor) & " and data_recebimento is null " & _
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor, data_vencimento, data_lancamento, documento, " & _
                "tipo_documento, nossonumero order by nome_cliente"
                strTitulo = "Demonstrativo de Débito de Cliente com Juros/Multa e Taxa de Cartório da cidade " & cbCidade.Text
            End If


            If cbGeral.Checked = False And rbGeral.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, Valor, data_vencimento, data_lancamento, documento, tipo_documento, " & _
                "nossonumero, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor) * 1 / 100)),2) as multa," & _
                "round((((valor) * 0.16 / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," & _
                "round((Valor + ((valor) * 0.16 / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor) * 1 / 100)),2) as total " & _
                "from verifica_debito() where data_vencimento >= " & d.Pdt(dtIni.Value.Date) & _
                " and data_vencimento < " & d.Pdt(dtFim.Value.Date) & " and data_recebimento is null " & _
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor, data_vencimento, data_lancamento, documento, " & _
                "tipo_documento, nossonumero order by nome_cliente"
                strTitulo = "Demonstrativo de Débito Geral de Cliente com Juros/Multa e Taxa de Cartório"
            ElseIf cbGeral.Checked = False And rbCliente.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, Valor, data_vencimento, data_lancamento, documento, tipo_documento, " & _
                "nossonumero, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor) * 1 / 100)),2) as multa," & _
                "round((((valor) * 0.16 / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," & _
                "round((Valor + ((valor) * 0.16 / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor) * 1 / 100)),2) as total " & _
                "from verifica_debito() where cod_cliente = " & CInt(txtCodigo.Text) & _
                " and data_vencimento >= " & d.Pdt(dtIni.Value.Date) & _
                " and data_vencimento < " & d.Pdt(dtFim.Value.Date) & " and data_recebimento is null " & _
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor, data_vencimento, data_lancamento, documento, " & _
                "tipo_documento, nossonumero order by nome_cliente"
                strTitulo = "Demonstrativo de Débito de Cliente com Juros/Multa e Taxa de Cartório"
            ElseIf cbGeral.Checked = False And rbPromotora.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, Valor, data_vencimento, data_lancamento, documento, tipo_documento, " & _
                "nossonumero, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor) * 1 / 100)),2) as multa," & _
                "round((((valor) * 0.16 / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," & _
                "round((Valor + ((valor) * 0.16 / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor) * 1 / 100)),2) as total " & _
                "from verifica_debito() where cod_promotor = " & CInt(cbPromotor.SelectedValue) & _
                " and data_vencimento >= " & d.Pdt(dtIni.Value.Date) & _
                " and data_vencimento < " & d.Pdt(dtFim.Value.Date) & " and data_recebimento is null " & _
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor, data_vencimento, data_lancamento, documento, " & _
                "tipo_documento, nossonumero order by nome_cliente"
                strTitulo = "Demonstrativo de Débito de Cliente com Juros/Multa e Taxa de Cartório da promotor(a) " & cbPromotor.Text
            ElseIf cbGeral.Checked = False And rbCidade.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, Valor, data_vencimento, data_lancamento, documento, tipo_documento, " & _
                "nossonumero, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor) * 1 / 100)),2) as multa," & _
                "round((((valor) * 0.16 / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," & _
                "round((Valor + ((valor) * 0.16 / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor) * 1 / 100)),2) as total " & _
                "from verifica_debito() where codigo_cidade = " & CInt(cbCidade.SelectedValue) & _
                " and data_vencimento >= " & d.Pdt(dtIni.Value.Date) & _
                " and data_vencimento < " & d.Pdt(dtFim.Value.Date) & " and data_recebimento is null " & _
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor, data_vencimento, data_lancamento, documento, " & _
                "tipo_documento, nossonumero order by nome_cliente"
                strTitulo = "Demonstrativo de Débito de Cliente com Juros/Multa e Taxa de Cartório da cidade " & cbCidade.Text
            End If


            d.conecta()
            Dim da As New SqlDataAdapter(strsQL, d.con)
            Dim ds As New DataSet
            da.Fill(ds, "Cliente")
            r.TextBox9.Text = Format(CDbl(txtTaxaCartorio.Text), "#,##0.00")
            r.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape
            r.Label3.Text = strTitulo
            If ds.Tables(0).Rows.Count > 0 Then
                r.DataSource = ds.Tables(0)
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
                f.Relat(r)
                f.Dispose()
                exportaPDF(r.Document, path)
            Else
                MessageBox.Show("Não há registro a ser exibido.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            d.desconecta()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnExcel_Click(sender As System.Object, e As System.EventArgs) Handles btnExcel.Click
        Dim f As New frmRpt
        Dim r As New rptDebitoClienteJurosMulta
        Dim strsQL As String = ""
        Dim strTitulo As String = ""
        Dim path As String = ""

        If rbCliente.Checked = True Then
            If txtCodigo.Text = String.Empty Or txtTaxaCartorio.Text = String.Empty Then
                MessageBox.Show("Verifique o campo código do cliente ou taxa de cartório.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If

        If rbGeral.Checked = True Or rbPromotora.Checked = True Or rbCidade.Checked = True Then
            If txtTaxaCartorio.Text = String.Empty Then
                MessageBox.Show("Verifique o campo taxa de cartório.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If

        Try
            If cbGeral.Checked = True And rbGeral.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, Valor, data_vencimento, data_lancamento, documento, tipo_documento, " & _
                "nossonumero, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor) * 1 / 100)),2) as multa," & _
                "round((((valor) * 0.16 / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," & _
                "round((Valor + ((valor) * 0.16 / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor) * 1 / 100)),2) as total " & _
                "from verifica_debito() where data_vencimento < " & d.Pdt(acesso.retornaDataHoraServidor) & " and data_recebimento is null " & _
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor, data_vencimento, data_lancamento, documento, " & _
                "tipo_documento, nossonumero order by nome_cliente"
                strTitulo = "Demonstrativo de Débito Geral de Cliente com Juros/Multa e Taxa de Cartório"
            ElseIf cbGeral.Checked = True And rbCliente.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, Valor, data_vencimento, data_lancamento, documento, tipo_documento, " & _
                "nossonumero, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor) * 1 / 100)),2) as multa," & _
                "round((((valor) * 0.16 / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," & _
                "round((Valor + ((valor) * 0.16 / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor) * 1 / 100)),2) as total " & _
                "from verifica_debito() where cod_cliente = " & CInt(txtCodigo.Text) & _
                " and data_vencimento < " & d.Pdt(acesso.retornaDataHoraServidor) & " and data_recebimento is null " & _
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor, data_vencimento, data_lancamento, documento, " & _
                "tipo_documento, nossonumero order by nome_cliente"
                strTitulo = "Demonstrativo de Débito de Cliente com Juros/Multa e Taxa de Cartório"
            ElseIf cbGeral.Checked = True And rbPromotora.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, Valor, data_vencimento, data_lancamento, documento, tipo_documento, " & _
                "nossonumero, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor) * 1 / 100)),2) as multa," & _
                "round((((valor) * 0.16 / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," & _
                "round((Valor + ((valor) * 0.16 / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor) * 1 / 100)),2) as total " & _
                "from verifica_debito() where cod_promotor = " & CInt(cbPromotor.SelectedValue) & _
                " and data_vencimento < " & d.Pdt(acesso.retornaDataHoraServidor) & " and data_recebimento is null " & _
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor, data_vencimento, data_lancamento, documento, " & _
                "tipo_documento, nossonumero order by nome_cliente"
                strTitulo = "Demonstrativo de Débito de Cliente com Juros/Multa e Taxa de Cartório da promotor(a) " & cbPromotor.Text
            ElseIf cbGeral.Checked = True And rbCidade.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, Valor, data_vencimento, data_lancamento, documento, tipo_documento, " & _
                "nossonumero, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor) * 1 / 100)),2) as multa," & _
                "round((((valor) * 0.16 / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," & _
                "round((Valor + ((valor) * 0.16 / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor) * 1 / 100)),2) as total " & _
                "from verifica_debito() where codigo_cidade = " & CInt(cbCidade.SelectedValue) & _
                " and data_vencimento < " & d.Pdt(acesso.retornaDataHoraServidor) & " and data_recebimento is null " & _
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor, data_vencimento, data_lancamento, documento, " & _
                "tipo_documento, nossonumero order by nome_cliente"
                strTitulo = "Demonstrativo de Débito de Cliente com Juros/Multa e Taxa de Cartório da cidade " & cbCidade.Text
            End If


            If cbGeral.Checked = False And rbGeral.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, Valor, data_vencimento, data_lancamento, documento, tipo_documento, " & _
                "nossonumero, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor) * 1 / 100)),2) as multa," & _
                "round((((valor) * 0.16 / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," & _
                "round((Valor + ((valor) * 0.16 / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor) * 1 / 100)),2) as total " & _
                "from verifica_debito() where data_vencimento >= " & d.Pdt(dtIni.Value.Date) & _
                " and data_vencimento < " & d.Pdt(dtFim.Value.Date) & " and data_recebimento is null " & _
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor, data_vencimento, data_lancamento, documento, " & _
                "tipo_documento, nossonumero order by nome_cliente"
                strTitulo = "Demonstrativo de Débito Geral de Cliente com Juros/Multa e Taxa de Cartório"
            ElseIf cbGeral.Checked = False And rbCliente.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, Valor, data_vencimento, data_lancamento, documento, tipo_documento, " & _
                "nossonumero, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor) * 1 / 100)),2) as multa," & _
                "round((((valor) * 0.16 / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," & _
                "round((Valor + ((valor) * 0.16 / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor) * 1 / 100)),2) as total " & _
                "from verifica_debito() where cod_cliente = " & CInt(txtCodigo.Text) & _
                " and data_vencimento >= " & d.Pdt(dtIni.Value.Date) & _
                " and data_vencimento < " & d.Pdt(dtFim.Value.Date) & " and data_recebimento is null " & _
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor, data_vencimento, data_lancamento, documento, " & _
                "tipo_documento, nossonumero order by nome_cliente"
                strTitulo = "Demonstrativo de Débito de Cliente com Juros/Multa e Taxa de Cartório"
            ElseIf cbGeral.Checked = False And rbPromotora.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, Valor, data_vencimento, data_lancamento, documento, tipo_documento, " & _
                "nossonumero, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor) * 1 / 100)),2) as multa," & _
                "round((((valor) * 0.16 / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," & _
                "round((Valor + ((valor) * 0.16 / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor) * 1 / 100)),2) as total " & _
                "from verifica_debito() where cod_promotor = " & CInt(cbPromotor.SelectedValue) & _
                " and data_vencimento >= " & d.Pdt(dtIni.Value.Date) & _
                " and data_vencimento < " & d.Pdt(dtFim.Value.Date) & " and data_recebimento is null " & _
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor, data_vencimento, data_lancamento, documento, " & _
                "tipo_documento, nossonumero order by nome_cliente"
                strTitulo = "Demonstrativo de Débito de Cliente com Juros/Multa e Taxa de Cartório da promotor(a) " & cbPromotor.Text
            ElseIf cbGeral.Checked = False And rbCidade.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, Valor, data_vencimento, data_lancamento, documento, tipo_documento, " & _
                "nossonumero, DATEDIFF(DAY,data_vencimento,GETDATE()) as dias, round((((valor) * 1 / 100)),2) as multa," & _
                "round((((valor) * 0.16 / 100) * (DATEDIFF(day,data_vencimento,GETDATE()))),2) as juros," & _
                "round((Valor + ((valor) * 0.16 / 100) * (DATEDIFF(day,data_vencimento,GETDATE())) + ((valor) * 1 / 100)),2) as total " & _
                "from verifica_debito() where codigo_cidade = " & CInt(cbCidade.SelectedValue) & _
                " and data_vencimento >= " & d.Pdt(dtIni.Value.Date) & _
                " and data_vencimento < " & d.Pdt(dtFim.Value.Date) & " and data_recebimento is null " & _
                "and cod_status_lancamento = 1 group by cod_cliente, nome_cliente, valor, data_vencimento, data_lancamento, documento, " & _
                "tipo_documento, nossonumero order by nome_cliente"
                strTitulo = "Demonstrativo de Débito de Cliente com Juros/Multa e Taxa de Cartório da cidade " & cbCidade.Text
            End If



            d.conecta()
            Dim da As New SqlDataAdapter(strsQL, d.con)
            Dim ds As New DataSet
            da.Fill(ds, "Cliente")
            r.TextBox9.Text = Format(CDbl(txtTaxaCartorio.Text), "#,##0.00")
            r.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape
            r.Label3.Text = strTitulo
            If ds.Tables(0).Rows.Count > 0 Then
                r.DataSource = ds.Tables(0)
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
                f.Relat(r)
                f.Dispose()
                exportaExcel(r.Document, path)
            Else
                MessageBox.Show("Não há registro a ser exibido.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            d.desconecta()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub exportaExcel(ByVal r As DataDynamics.ActiveReports.Document.Document, ByVal path As String)
        If MessageBox.Show("Deseja exportar os dados para área de trabalho?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            excelExport.Export(r, path)
        End If
    End Sub

    Private Sub exportaPDF(ByVal r As DataDynamics.ActiveReports.Document.Document, ByVal path As String)
        If MessageBox.Show("Deseja exportar os dados para área de trabalho?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            pdfExport.Export(r, path)
        End If
    End Sub


End Class