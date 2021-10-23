Imports mrotica_util
Public Class frmConsultaProdDiopCod
    Public tipo As String
    Public Result As Integer
    Public diametro As Int16
    Dim d As New dados
    Dim objDioptria As New objMaster

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
        Else
            grpLente.Visible = True
            grpBloco.Visible = True
            txtAdicao.Enabled = False
            txtOlho.Enabled = False
            txtEsf.Focus()
        End If
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If tipo.ToString.ToUpper.Trim = "L" Then
            Dim L As New objLentesDiop

            Dim strsQL As String = "SELECT lentes.cod_produto, lentes_blocos.diametro FROM produtos INNER JOIN " &
            "lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente AND " &
            "produtos.id_fabricante = lentes_blocos.id_fabricante INNER JOIN " &
            "lentes_tabela ON lentes_blocos.cod_tabela = lentes_tabela.cod_tabela INNER JOIN " &
            "lentes ON produtos.cod_produto = lentes.cod_produto " &
            "WHERE (lentes_tabela.cod_tabela = " & CInt(txtCodTabela.Text) & ") AND " &
            "(lentes.esferico = " & d.cdin(txtEsf.Text) & ") AND " &
            "(lentes.cilindrico = " & d.cdin(txtCil.Text) & ")  order by diametro"

            Dim tbDioptria As New DataTable
            tbDioptria = objDioptria.retornaRegistro(strsQL).Tables(0)

            If tbDioptria.Rows.Count > 1 Then
                If cbDiametro.Text = String.Empty Then
                    MessageBox.Show("Informe o diametro do produto.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Label7.Visible = True
                    cbDiametro.Visible = True
                    carregaCombo()
                    cbDiametro.Focus()
                    Exit Sub
                End If
                Result = L.retorna_cod_lente(txtCodTabela.Text, txtEsf.Text, txtCil.Text, cbDiametro.SelectedValue)
            Else
                Result = L.retorna_cod_lente(txtCodTabela.Text, txtEsf.Text, txtCil.Text)
            End If
            'Result = L.retorna_cod_lente(txtCodTabela.Text, txtEsf.Text, txtCil.Text)
            Me.Close()

        ElseIf tipo.ToString.ToUpper.Trim = "B" Then
            Dim b As New objblocos
            Try
                If (txtCodTabela.Text = 11060) Or (txtCodTabela.Text = 11034) Then
                    Result = b.retorna_cod_produto_interview(txtBase.Text, txtAdicao.Text, txtOlho.Text, txtCodTabela.Text)
                Else
                    Result = b.retorna_cod_produto(txtBase.Text, txtAdicao.Text, txtOlho.Text, txtCodTabela.Text)
                End If

            Catch ex As Exception

            End Try
            Me.Close()
        ElseIf tipo.ToString.ToUpper.Trim = "BS" Then
            Dim bs As New objBlocoSurf
            Result = bs.retorna_cod_produto(txtAdicao.Text, txtOlho.Text, txtCodTabela.Text, txtEsf.Text, txtCil.Text)
            Me.Close()
        Else
            Dim LC As New objLenteContato
            Result = LC.retorna_cod_produto(txtCodTabela.Text, txtBase.Text, txtEsf.Text, txtCil.Text)
            Me.Close()
        End If
    End Sub

    Private Sub txtCodTabela_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodTabela.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                If tipo.ToString.ToUpper.Trim = "B" Then
                    txtBase.Focus()
                Else
                    txtEsf.Focus()
                End If
        End Select
    End Sub

    Private Sub txtEsf_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEsf.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                txtCil.Focus()
        End Select
    End Sub

    Private Sub txtCil_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCil.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                If txtCil.Text = "" Then
                    txtCil.Text = 0
                End If
                If txtCil.Text > 0 Then
                    txtCil.Text = txtCil.Text * -1
                End If
                If tipo.ToString.ToUpper.Trim = "L" Then
                    btnOk.Focus()
                Else
                    txtBase.Focus()
                End If

        End Select
    End Sub

    Private Sub txtBase_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                txtAdicao.Focus()
        End Select
    End Sub

    Private Sub txtAdicao_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAdicao.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                txtOlho.Focus()
        End Select
    End Sub

    Private Sub txtOlho_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOlho.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                btnOk.Focus()
        End Select
    End Sub

    Private Sub carregaCombo()
        Dim strsQL As String = "SELECT lentes.cod_produto, lentes_blocos.diametro FROM produtos INNER JOIN " & _
        "lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente AND " & _
        "produtos.id_fabricante = lentes_blocos.id_fabricante INNER JOIN " & _
        "lentes_tabela ON lentes_blocos.cod_tabela = lentes_tabela.cod_tabela INNER JOIN " & _
        "lentes ON produtos.cod_produto = lentes.cod_produto " & _
        "WHERE (lentes_tabela.cod_tabela = " & CInt(txtCodTabela.Text) & ") AND " & _
        "(lentes.esferico = " & d.cdin(txtEsf.Text) & ") AND " & _
        "(lentes.cilindrico = " & d.cdin(txtCil.Text) & ") AND " & _
        "(lentes_blocos.ativo = -1) order by diametro"

        Dim tbDiametro As New DataTable

        tbDiametro = objDioptria.retornaRegistro(strsQL).Tables(0)
        cbDiametro.DisplayMember = "diametro"
        cbDiametro.ValueMember = "diametro"
        cbDiametro.DataSource = tbDiametro
        cbDiametro.SelectedIndex = -1
    End Sub

End Class