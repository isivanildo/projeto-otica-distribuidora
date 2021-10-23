Imports mrotica_util
Imports System.Windows.Forms
Imports System.Drawing

Public Class frmSenha
    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.
    Public usuario As New objUsuario
    Private lblNomeUsuario As New Label
    Private Sub btnEntrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrar.Click
        Me.Close()
    End Sub
    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub frmSenha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lblUsuario As Label = New Label
        lblUsuario.Text = "Usuário"
        lblUsuario.BackColor = Color.Transparent
        lblUsuario.Location = New Point(155, 38)
        lblUsuario.Width = 50
        pictureBox1.Controls.Add(lblUsuario)

        Dim lblSenha As Label = New Label
        lblSenha.Text = "Senha"
        lblSenha.BackColor = Color.Transparent
        lblSenha.Location = New Point(242, 38)
        pictureBox1.Controls.Add(lblSenha)
    End Sub

    Private Sub txtUsuario_Leave(sender As Object, e As EventArgs) Handles txtUsuario.Leave
        If txtUsuario.Text <> "" Then
            lblNomeUsuario.Text = ""
            lblNomeUsuario.Location = New Point(155, 80)
            lblNomeUsuario.BackColor = Color.Transparent
            lblNomeUsuario.AutoSize = True
            lblNomeUsuario.ForeColor = Color.Blue
            lblNomeUsuario.Font = New Font(lblNomeUsuario.Font, FontStyle.Bold)
            pictureBox1.Controls.Add(lblNomeUsuario)
            lblNomeUsuario.Text = usuario.nome_usuario(txtUsuario.Text)
        End If
    End Sub

    Private Sub frmSenha_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
End Class
