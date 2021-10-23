Imports System.Data
Imports System.Data.SqlClient
Imports mrotica_util

Public Class frmDetalheAcordo

    Public codlanc As Integer
    Public xCodFilialCliente As Integer
    Public data As Date
    Public intAcordo As Integer
    Public dtVencimento As Date
    Public dtRecebimento As Date
    Public valor As Double
    Dim d As New dados
    Dim intUsuario As Integer
    Dim objDetalhe As New objMaster


    Private Sub frmDetalheAcordo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        intUsuario = objDetalhe.retorna_codigo_usuario(frmMain.intCodigoUsuario)
        lblAcordo.Text = adiciona_zeros(intAcordo, 5)
        lblVencimento.Text = dtVencimento
        lblDias.Text = adiciona_zeros(DateDiff(DateInterval.Day, dtVencimento, dtRecebimento), 3)

        If CInt(lblDias.Text) < 0 Then
            lblDias.Text = 0
        End If

        lblParcela.Text = Format(valor, "#,##0.00")
        lblJuros.Text = Format((valor * 0.166 / 100) * CInt(lblDias.Text), "#,##0.00")

        lblValor.Text = Format(CDbl(lblParcela.Text) + CDbl(lblJuros.Text), "#,##0.00")
        txtDesconto.Text = Format(0.0, "#,##0.00")
    End Sub

    Private Sub btnReceber_Click(sender As System.Object, e As System.EventArgs) Handles btnReceber.Click
        If MessageBox.Show("Deseja receber esta parcela?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            'Rotina responsável por atualizar o status do pedido na tabela pedido_fornecedor
            Dim strSQL As String = ""
            strSQL = "update lancamentos set data_recebimento = " & d.Pdt(data) & "," & " juros = " & lblJuros.Text.Replace(",", ".") & _
                ", desconto = " & txtDesconto.Text.Replace(",", ".") & ", usuario_alt = " & intUsuario & " where cod_lancamento = " & codlanc & _
                " and id_filial = " & xCodFilialCliente
            Dim cmd As New SqlCommand(strSQL, d.con)
            d.conecta()
            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Recebimento realizado com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnReceber.Enabled = False
                txtDesconto.Enabled = False
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                d.desconecta()
            End Try
        Else
            MessageBox.Show("Recebimento cancelado com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtDesconto_Leave(sender As System.Object, e As System.EventArgs) Handles txtDesconto.Leave
        If CDbl(txtDesconto.Text) > 0 Then
            lblValor.Text = Format(CDbl(lblValor.Text) - CDbl(txtDesconto.Text), "#,##0.00")
        Else
            lblJuros.Text = Format((valor * 0.166 / 100) * CInt(lblDias.Text), "#,##0.00")
        End If
    End Sub
End Class