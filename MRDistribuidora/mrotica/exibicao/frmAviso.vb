Imports System.Windows.Forms
Public Class frmAviso
    Public Enum tipo_aviso
        tipo_ok = 1
        tipo_sim_nao = 2
    End Enum
    Public Enum respo
        SIM = 1
        NAO = 2
        OK = 3
        Cancel = 4
    End Enum
    Public tipo As New tipo_aviso
    Public resposta As respo = respo.OK
    Public alarme As Boolean = False
    Public Overloads Sub Show(ByVal msg As String)
        lblMSg.MaximumSize = Me.Size
        lblMSg.Text = msg
        Me.Show()
    End Sub
    Private Sub frmAviso_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                som_erro()
        End Select
    End Sub
    Private Sub frmAviso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblMSg.MaximumSize = Me.Size
        Select Case tipo
            Case tipo_aviso.tipo_sim_nao
                btnNao.Visible = True
                btnSim.Visible = True
                btnEmerg.Focus()
            Case tipo_aviso.tipo_ok
                If alarme = True Then
                    som_erro()
                End If
                btnNao.Visible = False
                btnSim.Visible = False
                btnOk.Visible = True
                btnOk.Focus()
        End Select

    End Sub
    Private Sub som_erro()
        My.Computer.Audio.Play(Application.StartupPath & "\sounds\alertk2.wav")
    End Sub
    Private Sub btnSim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSim.Click
        resposta = respo.SIM
        Me.Close()
    End Sub
    Private Sub btnNao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNao.Click
        resposta = respo.NAO
        Me.Close()
    End Sub
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        resposta = respo.OK
        Me.Close()

    End Sub
    Private Sub btnEmerg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmerg.Click
        som_erro()
    End Sub
End Class
