Imports mrotica_util
Public Class frmAndamentos
    Dim d As New dados
    Dim ordSer As New ObjOS
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carrega_combos()
        txtCodAndamento.Text = ""
        cbAndamento.SelectedValue = 0
        txtCodUsuario.Text = ""
        cbUsuario.SelectedValue = 0
        txtOS.Text = ""
    End Sub
    Private Sub carrega_combos()
        Dim tbUsuar As New DataTable
        Dim tbAnd As New DataTable
        Dim sql As String
        sql = "SELECT NOME, cod_usuario FROM Usuarios " & _
        "WHERE (cod_tipo_usuario = 4)"
        d.carrega_Tabela(sql, tbUsuar)
        cbUsuario.DataSource = tbUsuar
        cbUsuario.DisplayMember = "NOME"
        cbUsuario.ValueMember = "cod_usuario"

        sql = "Select  * from tipo_andamento where cod_setor > 2"
        d.carrega_Tabela(sql, tbAnd)
        cbAndamento.DataSource = tbAnd
        cbAndamento.DisplayMember = "andamento"
        cbAndamento.ValueMember = "cod_andamento"
    End Sub
    Private Sub txtCodUsuario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodUsuario.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                usuario()
        End Select
    End Sub
    Private Sub txtCodUsuario_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodUsuario.LostFocus
        usuario()
    End Sub
    Private Sub usuario()
        Try
            cbUsuario.SelectedValue = txtCodUsuario.Text
            txtCodAndamento.Focus()
        Catch ex As Exception

        End Try
        
    End Sub
    Private Sub txtCodAndamento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodAndamento.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                andamento()
        End Select
    End Sub
    Private Sub txtCodAndamento_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodAndamento.LostFocus
        andamento()
    End Sub
    Private Sub andamento()
        Try
            cbAndamento.SelectedValue = txtCodAndamento.Text
            txtOS.Focus()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtOS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOS.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                os()
        End Select
    End Sub
    Private Sub txtOS_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtOS.LostFocus
        os()
    End Sub
    Private Sub os()
        Dim andamentos As objAndamentos
        Dim fil, os As Integer
        Dim r As String
        Try
            fil = txtOS.Text.Substring(0, 3)
            os = txtOS.Text.Substring(3)
            andamentos = New objAndamentos(os, fil)
            If cbAndamento.SelectedValue = 0 Or cbUsuario.SelectedValue = 0 Then
                Exit Sub
            End If
            If cbAndamento.SelectedValue = 301 Then
                Try
                    r = andamentos.insere_andamento(301, fil, os, cbUsuario.SelectedValue, "Multiplos Surf")
                    r = andamentos.insere_andamento(302, fil, os, cbUsuario.SelectedValue, "Multiplos Surf")
                    r = andamentos.insere_andamento(303, fil, os, cbUsuario.SelectedValue, "Multiplos Surf")
                    r = andamentos.insere_andamento(304, fil, os, cbUsuario.SelectedValue, "Multiplos Surf")
                    r = andamentos.insere_andamento(305, fil, os, cbUsuario.SelectedValue, "Multiplos Surf")
                Catch ex As Exception

                End Try
            Else
                r = andamentos.insere_andamento(cbAndamento.SelectedValue, fil, os, cbUsuario.SelectedValue, "")
            End If
            txtCodAndamento.Text = ""
            cbAndamento.SelectedValue = 0
            txtCodUsuario.Text = ""
            cbUsuario.SelectedValue = 0
            txtOS.Text = ""
            txtCodUsuario.Focus()
            ordSer = New ObjOS(os, fil)
            If r.Substring(0, 3) = "ER:" Then
                AVISO(r.Substring(3), Me, frmAviso.tipo_aviso.tipo_ok, True, Color.Yellow)
            End If
            grdAndamentos.DataSource = ordSer.andamentos_os
            grdAndamentos.Refresh()
            formata_grid()
            lblStatus.Text = r
            som_ok()
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub formata_grid()
        Dim TStb As New DataGridTableStyle
        grdAndamentos.DataSource = ordSer.andamentos_os
        TStb.MappingName = grdAndamentos.DataSource.tablename

        Dim cdata As New DataGridTextBoxColumn
        With cdata
            .MappingName = "data"
            .HeaderText = "data"
            .Width = 105
        End With
        TStb.GridColumnStyles.Add(cdata)

        Dim cAnd As New DataGridTextBoxColumn
        With cAnd
            .MappingName = "andamento"
            .HeaderText = "Andamento"
            .Width = 180
        End With
        TStb.GridColumnStyles.Add(cAnd)


        Dim cuser As New DataGridTextBoxColumn
        With cuser
            .MappingName = "usuario"
            .HeaderText = "Usuário"
            .Width = 150
        End With
        TStb.GridColumnStyles.Add(cuser)

        Dim cOBS As New DataGridTextBoxColumn
        With cOBS
            .MappingName = "observacao"
            .HeaderText = "OBS"
            .Width = 250
        End With
        TStb.GridColumnStyles.Add(cOBS)

        grdAndamentos.TableStyles.Clear()
        grdAndamentos.TableStyles.Add(TStb)
    End Sub
    Private Sub btnAndamentos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAndamentos.Click
        Dim os As String
        Try
            os = InputBox("Digite o número da os. Ex: 001000001")
            ordSer = New ObjOS(os.Substring(3), os.Substring(0, 3))
            lblStatus.Text = "Andamentos da OS " & adiciona_zeros(CInt(os.Substring(0, 3)), 3) & _
            adiciona_zeros(CInt(os.Substring(3)), 6)
            grdAndamentos.DataSource = ordSer.andamentos_os
            grdAndamentos.Refresh()
            formata_grid()
        Catch ex As Exception

        End Try

    End Sub
End Class
