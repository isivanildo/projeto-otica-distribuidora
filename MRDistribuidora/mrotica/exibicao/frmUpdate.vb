Imports System.Net
Imports System.IO
Public Class frmUpdate
    Dim w As New WebClient
    Dim pr As New WebProxy("firewall", 8080)
    Dim c As New NetworkCredential("Ivanildo", "eaddrml", "labonorte.local")
    Dim strFile As String
    Private Sub frmUpdate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim v As Integer
        v = Application.ProductVersion
        strFile = "mrotica" & Application.ProductVersion & ".exe"
    End Sub
    Private Function versao() As Boolean
        Dim r As String
        r = File.ReadAllText("//servlabo/mrotica/inst/versao.txt")
        Exit Function
        If r <> strFile Then
            strFile = r & ".exe"
            Return True
        Else
            Return False
        End If
    End Function
    
    Private Sub baixa_normal()
        If versao() = False Then
            MsgBox("Não há atualizações disponíveis!")
            Exit Sub
        End If
        Try
            File.Copy("\\servlabo\mrotica\Inst\" & strFile, Application.StartupPath & "\" & strFile)
            MsgBox("OK!")
            File.Create(Application.StartupPath & "\" & "atualiza.ok")
        Catch ex As Exception
            AVISO(ex.Message & vbCrLf & "Pode não haver versão mais atual ou não foi possível conectar! Tentando via proxy.", Me, frmAviso.tipo_aviso.tipo_ok)
        End Try

    End Sub
    Private Sub btnAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizar.Click
        baixa_normal()
    End Sub
End Class