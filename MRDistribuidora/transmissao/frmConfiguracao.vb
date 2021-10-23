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
            txtBancoDados.Text = dsDB.Tables(0).Rows(0)("dbnome")
            txtLoja.Text = dsDB.Tables(0).Rows(0)("loja")
            txtUsuarioDB.Text = dsDB.Tables(0).Rows(0)("login")
            txtSenhaDB.Text = objSeguranca.DecryptText(dsDB.Tables(0).Rows(0)("dbpass"))
            txtDias.Text = dsDB.Tables(0).Rows(0)("dias")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSalvarDB_Click(sender As System.Object, e As System.EventArgs) Handles btnSalvarDB.Click
        If MessageBox.Show("Deseja salvar essas alterações?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            dsDB.Tables(0).Rows(0)("servidor") = txtServidorDB.Text
            dsDB.Tables(0).Rows(0)("dbnome") = txtBancoDados.Text
            dsDB.Tables(0).Rows(0)("loja") = txtLoja.Text
            dsDB.Tables(0).Rows(0)("login") = txtUsuarioDB.Text
            dsDB.Tables(0).Rows(0)("dbpass") = objSeguranca.EncryptText(txtSenhaDB.Text)
            dsDB.Tables(0).Rows(0)("dias") = txtDias.Text
            dsDB.WriteXml(strCaminho)
            MessageBox.Show("Alteração realizada com sucesso." & Chr(13) & "O sistema será fechado.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Application.Exit()
        Else
            MessageBox.Show("Operação cancelada com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class