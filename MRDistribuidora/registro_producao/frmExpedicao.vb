Imports mrotica_util
Public Class frmExpedicao
    Dim us As New objUsuario
    Dim anda As New objAndamentos
    Dim ordserv As ObjOS
    Dim d As New dados
    Dim use As Integer = 96
    Dim nOS As String
    Dim item As Integer = 1
    Private Sub frmExpedicao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub
    Private Sub txtOS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOS.KeyDown
        'Procedimento 13, Expedição.
        Dim filial, os As Integer
        Select Case e.KeyCode
            Case Keys.Enter
                Try
                    filial = 1
                    os = txtOS.Text
                    If us.acesso(use, 13) = True Then
                        AVISO(anda.insere_andamento(objAndamentos.tipo.malote_loja, filial, os, us.cod_usuario, ""), Me, frmAviso.tipo_aviso.tipo_ok)
                        ordserv = New ObjOS(os, filial)
                        If ordserv.cod_cliente >= 1 And ordserv.cod_cliente <= 999 Then
                            nOS = adiciona_zeros(ordserv.cod_cliente, 3) & adiciona_zeros(ordserv.doc_cliente, 6)
                            If rtfLista.Text = "" Then
                                rtfLista.Text = adiciona_zeros(item, 3) & " - OS: " & nOS & " " & Now.ToString("dd/MM/yy hh:mm:ss")
                            Else
                                rtfLista.Text = rtfLista.Text & vbCrLf & adiciona_zeros(item, 3) & " - OS: " & nOS & " " & Now.ToString("dd/MM/yy hh:mm:ss")
                            End If
                        End If
                    Else
                        AVISO("Usuário não tem permissão para andamento de Malote para Loja!", Me, frmAviso.tipo_aviso.tipo_ok, True)
                    End If
                Catch ex As Exception
                    AVISO(ex.ToString, Me, frmAviso.tipo_aviso.tipo_ok, True)
                End Try
                
        End Select
    End Sub
    Private Sub fila()
        Dim sql As String
        sql = "Insert into fila_estoque_anamaria(id_filial,cod_os,id_lab,data_inclusao) values(" & _
        ordserv.cod_cliente & _
        "," & ordserv.doc_cliente & _
        "," & ordserv.id_laboratorio & _
        "," & d.pdtm(d.hora) & ")"
        d.Comando(sql, False)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
End Class