Imports System.Data
Imports System.Data.SqlClient
Imports mrotica_util
Public Class frmCartaCobrancaCliente
    Dim d As New dados
    Dim acesso As New objMaster
    Dim xlsExport As New DataDynamics.ActiveReports.Export.Pdf.PdfExport

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        Dim f As New frmRpt
        Dim ra As New rptCartaCobrancaClienteA
        Dim rb As New rptCartaCobrancaClienteB
        Dim rc As New rptCartaCobrancaClienteC
        Dim strsQL As String = ""
        Dim strSQLTotal As String = ""
        Dim strTitulo As String = ""

        If rbModeloA.Checked = False And rbModeloB.Checked = False And rbModeloC.Checked = False Then
            MessageBox.Show("Selecione um modelo de carta de cobrança.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If rbGeral.Checked = True Then
            strsQL = "select cod_cliente, nome_cliente, SUM(valor) as valor, round(SUM(multa),2,1) as multa, round(SUM(juros),2,1) as juros, round(SUM(valor+multa+juros),2,1) as total" & _
                " from DEBITO_CARTA_CLIENTE()" & _
                " where data_vencimento < " & d.Pdt(acesso.retornaDataHoraServidor) & " and data_recebimento is null and cod_status_lancamento = 1" & _
                " group by nome_cliente, cod_cliente"
        End If

        If rbCliente.Checked = True Then
            strsQL = "select cod_cliente, nome_cliente, SUM(valor) as valor, round(SUM(multa),2,1) as multa, round(SUM(juros),2,1) as juros, round(SUM(valor+multa+juros),2,1) as total" & _
            " from DEBITO_CARTA_CLIENTE()" & _
            " where cod_cliente = " & CInt(txtCodigo.Text) & _
            " and data_vencimento < " & d.Pdt(acesso.retornaDataHoraServidor) & " and data_recebimento is null and cod_status_lancamento = 1" & _
            " group by nome_cliente, cod_cliente"


            strSQLTotal = "select nome_cliente from DEBITO_CARTA_CLIENTE()" & _
            " where cod_cliente = " & CInt(txtCodigo.Text) & _
            " and data_vencimento < " & d.Pdt(acesso.retornaDataHoraServidor) & " and data_recebimento is null and cod_status_lancamento = 1"
        End If

            Try
                If rbModeloA.Checked = True Then
                    d.conecta()
                    Dim da As New SqlDataAdapter(strsQL, d.con)
                    Dim ds As New DataSet
                'Contar
                Dim i As Integer
                If rbCliente.Checked = True Then
                    Dim dat As New SqlDataAdapter(strSQLTotal, d.con)
                    Dim dst As New DataSet
                    dat.Fill(dst, "TotalCliente")
                    i = dst.Tables(0).Rows.Count
                Else
                    i = 1
                End If
                'Fim contar
                da.Fill(ds, "Cliente")
                ra.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait
                ra.Label1.Text = acesso.dataPorExtenso
                ra.Label2.Text = acesso.dataPorExtenso
                ra.TextBox16.Text = txtPerc.Text
                ra.TextBox23.Text = txtPerc.Text & " %"
                ra.TextBox28.Text = CDbl(txtTaxaCart.Text) * i
                If ds.Tables(0).Rows.Count > 0 Then
                    ra.DataSource = ds.Tables(0)
                Else
                    MessageBox.Show("Não há registro as ser exibido.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                f.Relat(ra)
                f.ShowDialog()
                f.Dispose()
                d.desconecta()
            End If

                If rbModeloB.Checked = True Then
                    d.conecta()
                    Dim da As New SqlDataAdapter(strsQL, d.con)
                    Dim ds As New DataSet
                    da.Fill(ds, "Cliente")
                    rb.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait
                    rb.Label3.Text = strTitulo
                    If ds.Tables(0).Rows.Count > 0 Then
                        rb.DataSource = ds.Tables(0)
                    Else
                        MessageBox.Show("Não há registro as ser exibido.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                    f.Relat(rb)
                    f.ShowDialog()
                    f.Dispose()
                    d.desconecta()
                End If

                If rbModeloC.Checked = True Then
                    d.conecta()
                    Dim da As New SqlDataAdapter(strsQL, d.con)
                    Dim ds As New DataSet
                    da.Fill(ds, "Cliente")
                    rc.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait
                    rc.Label3.Text = strTitulo
                    rc.TextBox26.Text = txtPerc.Text
                    rc.TextBox28.Text = txtTaxaCart.Text
                    If ds.Tables(0).Rows.Count > 0 Then
                        rc.DataSource = ds.Tables(0)
                    Else
                        MessageBox.Show("Não há registro as ser exibido.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                    f.Relat(rc)
                    f.ShowDialog()
                    f.Dispose()
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
        txtCodigo.Visible = True
    End Sub

    Private Sub rbGeral_Click(sender As System.Object, e As System.EventArgs) Handles rbGeral.Click
        Label1.Visible = False
        txtCodigo.Visible = False
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim path As String = ""
        Dim f As New frmRpt
        Dim ra As New rptCartaCobrancaClienteA
        Dim strsQL As String = ""
        Dim strTitulo As String = ""

        If rbModeloA.Checked = False And rbModeloB.Checked = False And rbModeloC.Checked = False Then
            MessageBox.Show("Selecione um modelo de carta de cobrança.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If rbGeral.Checked = True Then
            strsQL = "select cod_cliente, nome_cliente, SUM(valor) as valor, round(SUM(multa),2,1) as multa, round(SUM(juros),2,1) as juros, round(SUM(valor+multa+juros),2,1) as total" & _
                " from DEBITO_CARTA_CLIENTE()" & _
                " where data_vencimento < " & d.Pdt(Now()) & " and data_recebimento is null and cod_status_lancamento = 1" & _
                " group by nome_cliente, cod_cliente"
        End If

        If rbCliente.Checked = True Then
            strsQL = "select cod_cliente, nome_cliente, SUM(valor) as valor, round(SUM(multa),2,1) as multa, round(SUM(juros),2,1) as juros, round(SUM(valor+multa+juros),2,1) as total" & _
            " from DEBITO_CARTA_CLIENTE()" & _
            " where cod_cliente = " & CInt(txtCodigo.Text) & _
            " and data_vencimento < " & d.Pdt(Now()) & " and data_recebimento is null and cod_status_lancamento = 1" & _
            " group by nome_cliente, cod_cliente"
        End If

        Try
            If rbModeloA.Checked = True Then
                d.conecta()
                Dim da As New SqlDataAdapter(strsQL, d.con)
                Dim ds As New DataSet
                da.Fill(ds, "Cliente")
                ra.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait
                ra.Label1.Text = acesso.dataPorExtenso
                ra.Label2.Text = acesso.dataPorExtenso
                ra.TextBox16.Text = txtPerc.Text
                ra.TextBox23.Text = txtPerc.Text & " %"
                ra.TextBox28.Text = txtTaxaCart.Text
                If ds.Tables(0).Rows.Count > 0 Then
                    ra.DataSource = ds.Tables(0)
                    If rbCliente.Checked = True Then
                        path = My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & ds.Tables(0).Rows(0)("nome_cliente").ToString & ".pdf"
                    Else
                        path = My.Computer.FileSystem.SpecialDirectories.Desktop & "\Carta de Cobranca.pdf"
                    End If
                Else
                    MessageBox.Show("Não há registro as ser exibido.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                f.Relat(ra)
                f.Dispose()
                d.desconecta()
                exporta(ra.Document, path)
                MessageBox.Show("Carta exportada com sucesso para área de trabalho.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub exporta(ByVal r As DataDynamics.ActiveReports.Document.Document, ByVal path As String)
        If MessageBox.Show("Deseja exportar os dados para área de trabalho?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            xlsExport.Export(r, path)
        End If
    End Sub
End Class