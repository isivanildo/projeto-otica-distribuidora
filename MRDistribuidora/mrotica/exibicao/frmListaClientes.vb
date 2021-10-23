Imports System.Data
Imports System.Data.SqlClient
Imports mrotica_util

Public Class frmListaClientes
    Dim d As New dados

    Private Sub frmListaClientes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        combo_promotor()
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

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        Dim f As New frmRpt
        Dim r As New rptListaClientes
        Dim r2 As New rptListaClientesSintetico
        Dim strsQL As String = ""
        Dim strTitulo As String = ""

        Try
            If cbTodos.Checked = False Then
                strsQL = "select cliente.*, promotor.promotor from cliente inner join Promotor_cliente on cliente.cod_cliente = Promotor_cliente.cod_cliente " & _
                        "inner join promotor on Promotor_cliente.cod_promotor = promotor.cod_promotor " & _
                        "where Promotor_cliente.cod_promotor = " & cbPromotor.SelectedValue
                strTitulo = "Listagem de Clientes por Consultor(a)"
            Else
                strsQL = "select * from cliente"
                strTitulo = "Listagem de Clientes"
                r.GroupHeader1.Visible = False
            End If


            d.conecta()
            Dim da As New SqlDataAdapter(strsQL, d.con)
            Dim ds As New DataSet
            da.Fill(ds, "Cliente")

            If rbAnalitico.Checked Then
                r.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape
                r.Label3.Text = strTitulo
            Else
                r2.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape
                r2.Label3.Text = strTitulo
            End If

            If ds.Tables(0).Rows.Count > 0 Then
                If rbAnalitico.Checked Then
                    r.DataSource = ds.Tables(0)
                Else
                    r2.DataSource = ds.Tables(0)
                End If
            Else
                MessageBox.Show("Não há registro a ser exibido.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If rbAnalitico.Checked Then
                f.Relat(r)
            Else
                f.Relat(r2)
            End If


            f.ShowDialog()
            f.Dispose()
            d.desconecta()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub cbTodos_Click(sender As System.Object, e As System.EventArgs) Handles cbTodos.Click
        If cbTodos.Checked = True Then
            cbPromotor.Enabled = False
        Else
            cbPromotor.Enabled = True
        End If
    End Sub
End Class