Imports System.Data
Imports System.Data.SqlClient
Imports mrotica_util

Public Class frmConfiguracao
    Dim objSeguranca As New objSecurity
    Dim dsDB As New DataSet
    Dim strCaminho As String = My.Computer.FileSystem.CurrentDirectory + "\config.xml"
    Dim d As New dados

    Private Sub frmConfiguracao_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        retornaDadosDB()
    End Sub

    Public Sub retornaDadosDB()
        Try
            dsDB.ReadXml(strCaminho)
            txtServidorDB.Text = dsDB.Tables(0).Rows(0)("servidor")
            txtBancoDados.Text = dsDB.Tables(0).Rows(0)("banco")
            txtLoja.Text = dsDB.Tables(0).Rows(0)("filial")
            txtUsuarioDB.Text = dsDB.Tables(0).Rows(0)("usuario")
            txtSenhaDB.Text = objSeguranca.DecryptText(dsDB.Tables(0).Rows(0)("senha"))

            Dim strSQL As String = "select comissao_vend_int, comissao_vend_ext, desconto_venda_vista from controle"
            d.conecta()
            Dim cmd As New SqlCommand(strSQL, d.con)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            dr.Read()
            txtVendedorInterno.Text = dr("comissao_vend_int").ToString
            txtVendedorExterno.Text = dr("comissao_vend_ext").ToString
            txtDescVista.Text = dr("desconto_venda_vista").ToString
            dr.Close()
            d.desconecta()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSalvarDB_Click(sender As System.Object, e As System.EventArgs) Handles btnSalvarDB.Click
        If MessageBox.Show("Deseja salvar essas alterações?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            dsDB.Tables(0).Rows(0)("servidor") = txtServidorDB.Text
            dsDB.Tables(0).Rows(0)("banco") = txtBancoDados.Text
            dsDB.Tables(0).Rows(0)("filial") = txtLoja.Text
            dsDB.Tables(0).Rows(0)("usuario") = txtUsuarioDB.Text
            dsDB.Tables(0).Rows(0)("senha") = objSeguranca.EncryptText(txtSenhaDB.Text)
            dsDB.WriteXml(strCaminho)
            MessageBox.Show("Alteração realizada com sucesso." & Chr(13) & "O sistema será fechado.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Application.Exit()
        Else
            MessageBox.Show("Operação cancelada com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSalvarVend_Click(sender As System.Object, e As System.EventArgs) Handles btnSalvarVend.Click
        If MessageBox.Show("Deseja salvar as comissões informadas?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim vendint As Double = CDbl(txtVendedorInterno.Text)
            Dim vendext As Double = CDbl(txtVendedorExterno.Text)
            Dim descvenda As Double = CDbl(txtDescVista.Text)
            Dim strSQL As String = "update controle set comissao_vend_int = " & Replace(vendint, ",", ".") & "," & "comissao_vend_ext = " & Replace(vendext, ",", ".") & _
                "," & "desconto_venda_vista = " & Replace(descvenda, ",", ".") & ""

            d.conecta()
            Dim cmd As New SqlCommand(strSQL, d.con)
            cmd.ExecuteNonQuery()
            d.desconecta()
            MessageBox.Show("Alterações salvas com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
End Class