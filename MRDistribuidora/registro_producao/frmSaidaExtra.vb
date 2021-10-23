Imports mrotica_util
Public Class frmSaidaExtra
    Dim d As New dados
    Dim x_os, x_id_filial As Integer
    Dim ordser As ObjOS
    Dim andamentos As New objAndamentos
    Dim usuario As New objUsuario
    Dim conf As New config
    Dim extra As New objSaidaExtra
    Dim tt As New DataTable
    Private Sub frmSaidaExtra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim os As String
        Try
            os = InputBox("Digite o número da os. Ex: 001000001")
            ordser = New ObjOS(os.Substring(3), os.Substring(0, 3))
            'Caso a OS não exista, fecha o form
            If ordser.max = 0 Then
                AVISO("Esta OS não existe!", Me, frmAviso.tipo_aviso.tipo_ok, True)
                Me.Close()
                Exit Sub
            End If
            carrega_combos()
            usuario.login(Me)
            'Procedimento 12 Solicitação de saída extra
            If usuario.acesso(12) = False Then
                MessageBox.Show("Usuário " & usuario.nome & " não tem acesso a este módulo", "ERROR: 12", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Exit Sub
            End If
            'Verifica se há uma saída extra em aberto para essa OS
            extra.filtra(ordser.cod_os, ordser.id_filial, "N")
            If extra.max > 0 Then
                AVISO("Já há uma saída extra em aberto para essa OS. É necessário concluí-la" & _
                " para iniciar uma nova saída extra !", Me, frmAviso.tipo_aviso.tipo_ok, True)
                Me.Close()
                Exit Sub
            Else
                With extra
                    .novo()
                    andamentos = New objAndamentos(ordser.cod_os, ordser.id_filial)
                End With
            End If
        Catch ex As Exception
            AVISO(ex.Message, Me, frmAviso.tipo_aviso.tipo_ok, True)
            Me.Close()
        End Try
    End Sub
    Private Sub carrega_combos()
        tt = ordser.andamentos_os_producao_validos
        cbAndamentos.DataSource = tt
        cbAndamentos.DisplayMember = "exibicao"
        cbAndamentos.ValueMember = "ordem"
    End Sub
    Private Function tem_troca() As String
        Dim troca As String = "N"
        If chkTrocaOD.Checked = True Then
            troca = "S"
        End If
        If chkTrocaOE.Checked = True Then
            troca = "S"
        End If
        Return troca
    End Function

    Private Function usuario_perda() As String
        'Identifica o usuário reponsável pelo andamento
        'onde ocorreu a causa 
        'da perda e consequente saída extra. 
        Dim dv As New DataView
        dv.Table = tt
        Try
            dv.RowFilter = " ordem = " & cbAndamentos.SelectedValue & ""
            Return dv.Item(0)("cod_usuario")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Private Function andamento_perda() As String
        'Identifica em que andamento ocorreu a causa 
        'da perda e consequente saída extra. 
        Dim dv As New DataView
        dv.Table = tt
        Try
            dv.RowFilter = " ordem = " & cbAndamentos.SelectedValue & ""
            Return dv.Item(0)("cod_andamento")
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
    Private Function sn(ByVal ctl As CheckBox) As String
        'Retorna variável de texto S ou N de acordo
        'com a opção marcada no checkbox.
        If ctl.Checked = True Then
            Return "S"
        Else
            Return "N"
        End If
    End Function

    Private Sub btnSalvar_Click(sender As System.Object, e As System.EventArgs) Handles btnSalvar.Click
        Dim r As String
        If chkOD.Checked = False And chkOE.Checked = False Then
            MessageBox.Show("Pelo menos um dos olhos deve estar marcado para saída extra!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If txtMotivo.Text = Nothing Then
            MessageBox.Show("É preciso definir o motivo da solicitação da saída extra!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        With extra
            .id_filial_movimento = conf.Filial
            .id_usuario = usuario.cod_usuario
            .doc = "Saída Extra " & .cod_saida_extra & ""
            .data = d.hora
            .id_filial_os = ordser.id_filial
            .cod_os = ordser.cod_os
            .Desc_saida_extra = txtMotivo.Text
            .id_usuario_perda = usuario_perda()
            .id_andamento = andamento_perda()
            .od = sn(chkOD)
            .oe = sn(chkOE)
            .troca_Produto_od = sn(chkTrocaOD)
            .troca_Produto_oe = sn(chkTrocaOE)
            r = .Salvar
            AVISO(r, Me, frmAviso.tipo_aviso.tipo_ok)
            If r.StartsWith("OK") Then
                andamentos.cancela_andamentos_producao("Cancelado saída extra!")
                andamentos.insere_andamento(objAndamentos.tipo.solicitaccao_saida_extra, ordser.id_filial, _
                ordser.cod_os, usuario.cod_usuario, txtMotivo.Text & " Nº saída Extra: " & extra.cod_saida_extra & "")
                AVISO("Anote o número da solicitação de saída extra na OS:" & extra.cod_saida_extra, Me, frmAviso.tipo_aviso.tipo_ok)
            End If
            Me.Close()
        End With
    End Sub
End Class