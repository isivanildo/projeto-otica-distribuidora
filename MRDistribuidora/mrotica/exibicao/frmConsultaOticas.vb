Imports mrotica_util

Public Class frmConsultaOticas
    Dim d As New dados
    Dim tbCliente As New DataTable
    Public intCodigoCli As Int32
    Public strCliente As String
    Public intTag As Int16

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        intTag = 1
        If rbLoja.Checked = True Then
            intCodigoCli = cbCliente.SelectedValue
            strCliente = cbCliente.Text
        Else
            intCodigoCli = 1000
        End If
        Me.Close()
    End Sub

    Private Sub frmConsultaOticas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim strsQL As String = "SELECT * FROM CLIENTE WHERE COD_CLIENTE >= 1 AND COD_CLIENTE <= 100"
        d.carrega_Tabela(strsQL, tbCliente)
        cbCliente.DataSource = tbCliente
        cbCliente.DisplayMember = "nome_cliente"
        cbCliente.ValueMember = "cod_cliente"
    End Sub

    Private Sub rbGeral_Click(sender As System.Object, e As System.EventArgs) Handles rbGeral.Click
        If rbGeral.Checked = True Then
            cbCliente.Enabled = False
        End If
    End Sub

    Private Sub rbLoja_Click(sender As System.Object, e As System.EventArgs) Handles rbLoja.Click
        If rbLoja.Checked = True Then
            cbCliente.Enabled = True
        End If
    End Sub
End Class