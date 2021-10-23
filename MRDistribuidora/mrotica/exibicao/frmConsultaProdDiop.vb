Imports mrotica_util
Public Class frmConsultaProdDiop
    Public tipo As String
    Public cod_prod As Integer
    Public Result As Boolean = False
    Private Sub frmConsultaProdDiop_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If tipo.ToString.ToUpper.Trim = "L" Then
            grpLente.Visible = True
            grpBloco.Visible = False
            txtEsf.Focus()
        ElseIf tipo.ToString.ToUpper.Trim = "B" Then
            grpLente.Visible = False
            grpBloco.Visible = True
            txtBase.Focus()
        ElseIf tipo.ToString.ToUpper.Trim = "BS" Then
            grpLente.Visible = True
            grpBloco.Visible = True
            txtEsf.Focus()
        ElseIf tipo.ToString.ToUpper.Trim = "LC" Then
            grpLente.Visible = True
            grpBloco.Visible = True
            txtEsf.Focus()
            txtAdicao.Enabled = False
            txtOlho.Enabled = False
        End If
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If tipo.ToString.ToUpper.Trim = "L" Then
            Dim L As New objLentesDiop
            Result = L.confirma_lente_diop(txtEsf.Text, txtCil.Text, cod_prod)
            Me.Close()
        ElseIf tipo.ToString.ToUpper.Trim = "B" Then
            Dim b As New objblocos
            Result = b.confirma_bloco_Base(txtBase.Text, txtAdicao.Text, txtOlho.Text, cod_prod)
            Me.Close()
        ElseIf tipo.ToString.ToUpper.Trim = "BS" Then
            Dim bs As New objBlocoSurf
            Result = bs.confirma_bloco_Base(txtBase.Text, txtAdicao.Text, txtOlho.Text, cod_prod, txtEsf.Text, txtCil.Text)
            Me.Close()
        ElseIf tipo.ToString.ToUpper.Trim = "LC" Then
            Dim LC As New objLenteContato
            Result = LC.confirma_base_diop(txtBase.Text, cod_prod, txtEsf.Text, txtCil.Text)
            Me.Close()
        End If
    End Sub
End Class