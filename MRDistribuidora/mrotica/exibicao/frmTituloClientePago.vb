Imports System.Data
Imports System.Data.SqlClient
Imports mrotica_util
Public Class frmTituloClientePago
    Dim d As New dados
    Dim acesso As New objMaster
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        Dim f As New frmRpt
        Dim r As New rptTituloClientePago
        Dim strsQL As String = ""

        If txtCodigo.Text = String.Empty Then
            MessageBox.Show("Verifique o campo código do cliente ou taxa de cartório.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Try
            If cbGeral.Checked = True Then
                strsQL = "select cod_cliente, nome_cliente, Valor_pago, data_recebimento, data_lancamento, documento, tipo_documento, " &
                "nossonumero from verifica_debito() where cod_cliente = " & CInt(txtCodigo.Text) &
                " and data_recebimento < " & d.Pdt(acesso.retornaDataHoraServidor) &
                " and cod_status_lancamento = 1 order by data_recebimento"
            Else
                strsQL = "select cod_cliente, nome_cliente, Valor_pago, data_recebimento, data_lancamento, documento, tipo_documento, " &
                "nossonumero from verifica_debito() where cod_cliente = " & CInt(txtCodigo.Text) &
                " and data_recebimento >= " & d.Pdt(dtIni.Value.Date) &
                " and data_recebimento <= " & d.Pdt(dtFim.Value.Date) &
                " and cod_status_lancamento = 1 order by data_recebimento"
            End If

            d.conecta()
            Dim da As New SqlDataAdapter(strsQL, d.con)
            Dim ds As New DataSet
            da.Fill(ds, "Cliente")
            r.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait
            r.Label3.Text = "Demonstrativo de Título Pagos"
            r.TextBox10.Text = "Emitido em: " & acesso.dataPorExtensoSemBelem
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

    Private Sub rbGeral_Click(sender As System.Object, e As System.EventArgs)
        Label1.Visible = False
        txtCodigo.Visible = False
    End Sub

    Private Sub txtTaxaCartorio_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
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
End Class