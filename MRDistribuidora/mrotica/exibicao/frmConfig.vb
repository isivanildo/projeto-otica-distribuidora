Imports mrotica_util
Public Class frmConfig
    Inherits System.Windows.Forms.Form
    Dim tb As New DataTable
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSenhaSql As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDBSql As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtUserSql As System.Windows.Forms.TextBox
    Friend WithEvents txtSQLServer As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Dim ds As New DataSet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDBBazar As System.Windows.Forms.TextBox
    Friend WithEvents cbMontagem As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbSurfacagem As System.Windows.Forms.ComboBox
    Dim o As New objSecurity
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbBloqueio As System.Windows.Forms.ComboBox
    Dim d As New dados
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtLoja As System.Windows.Forms.TextBox
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfig))
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLoja = New System.Windows.Forms.TextBox()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSenhaSql = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDBSql = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtUserSql = New System.Windows.Forms.TextBox()
        Me.txtSQLServer = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDBBazar = New System.Windows.Forms.TextBox()
        Me.cbMontagem = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbSurfacagem = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbBloqueio = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(8, 24)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(128, 20)
        Me.txtUser.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuario Autenticação"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(144, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Senha Autenticação"
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(144, 24)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.txtSenha.Size = New System.Drawing.Size(100, 20)
        Me.txtSenha.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Código da Loja"
        '
        'txtLoja
        '
        Me.txtLoja.Location = New System.Drawing.Point(88, 60)
        Me.txtLoja.MaxLength = 3
        Me.txtLoja.Name = "txtLoja"
        Me.txtLoja.Size = New System.Drawing.Size(40, 20)
        Me.txtLoja.TabIndex = 2
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(41, 422)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(75, 23)
        Me.btnSalvar.TabIndex = 8
        Me.btnSalvar.Text = "Salvar"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(129, 422)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Cancelar"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Senha SQL"
        '
        'txtSenhaSql
        '
        Me.txtSenhaSql.Location = New System.Drawing.Point(8, 191)
        Me.txtSenhaSql.Name = "txtSenhaSql"
        Me.txtSenhaSql.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.txtSenhaSql.Size = New System.Drawing.Size(240, 20)
        Me.txtSenhaSql.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 214)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(168, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Banco de Dados SQL mrotica"
        '
        'txtDBSql
        '
        Me.txtDBSql.Location = New System.Drawing.Point(8, 230)
        Me.txtDBSql.Name = "txtDBSql"
        Me.txtDBSql.Size = New System.Drawing.Size(240, 20)
        Me.txtDBSql.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 133)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(168, 16)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "login SQL"
        '
        'txtUserSql
        '
        Me.txtUserSql.Location = New System.Drawing.Point(8, 149)
        Me.txtUserSql.Name = "txtUserSql"
        Me.txtUserSql.Size = New System.Drawing.Size(240, 20)
        Me.txtUserSql.TabIndex = 4
        '
        'txtSQLServer
        '
        Me.txtSQLServer.Location = New System.Drawing.Point(8, 106)
        Me.txtSQLServer.Name = "txtSQLServer"
        Me.txtSQLServer.Size = New System.Drawing.Size(240, 20)
        Me.txtSQLServer.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(168, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Servidor SQL"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 256)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 16)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Banco de Dados SQL Bazar"
        '
        'txtDBBazar
        '
        Me.txtDBBazar.Location = New System.Drawing.Point(8, 272)
        Me.txtDBBazar.Name = "txtDBBazar"
        Me.txtDBBazar.Size = New System.Drawing.Size(240, 20)
        Me.txtDBBazar.TabIndex = 20
        '
        'cbMontagem
        '
        Me.cbMontagem.FormattingEnabled = True
        Me.cbMontagem.Location = New System.Drawing.Point(8, 314)
        Me.cbMontagem.Name = "cbMontagem"
        Me.cbMontagem.Size = New System.Drawing.Size(240, 21)
        Me.cbMontagem.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(10, 295)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 16)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Laboratorio Montagem"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 338)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(168, 16)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Laboratorio Surfacagem"
        '
        'cbSurfacagem
        '
        Me.cbSurfacagem.FormattingEnabled = True
        Me.cbSurfacagem.Location = New System.Drawing.Point(8, 357)
        Me.cbSurfacagem.Name = "cbSurfacagem"
        Me.cbSurfacagem.Size = New System.Drawing.Size(240, 21)
        Me.cbSurfacagem.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 376)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(168, 16)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Nível de Bloqueio"
        '
        'cbBloqueio
        '
        Me.cbBloqueio.FormattingEnabled = True
        Me.cbBloqueio.Items.AddRange(New Object() {"Leve", "Medio", "Pesado"})
        Me.cbBloqueio.Location = New System.Drawing.Point(8, 395)
        Me.cbBloqueio.Name = "cbBloqueio"
        Me.cbBloqueio.Size = New System.Drawing.Size(240, 21)
        Me.cbBloqueio.TabIndex = 25
        '
        'frmConfig
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(256, 452)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cbBloqueio)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbSurfacagem)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbMontagem)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDBBazar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtUserSql)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtSQLServer)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDBSql)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtSenhaSql)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtLoja)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUser)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConfig"
        Me.Text = "Configuração"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim r As DataRow
        Try
            r = ds.Tables(0).Rows(0)
            r("user") = txtUser.Text
            r("senha") = o.EncryptText(txtSenha.Text)
            r("servidor") = txtSQLServer.Text
            r("login") = txtUserSql.Text
            r("dbpass") = o.EncryptText(txtSenhaSql.Text)
            r("dbnome") = txtDBSql.Text
            r("loja") = txtLoja.Text
            r("dbbazar") = txtDBBazar.Text
            r("LabMont") = cbMontagem.SelectedValue
            r("labSurf") = cbSurfacagem.SelectedValue
            r("bloqueio") = cbBloqueio.Text
        Catch ex As Exception
            Dim tb As New DataTable
            tb = monta_tabela()
            r = tb.NewRow
            r("user") = txtUser.Text
            r("senha") = o.EncryptText(txtSenha.Text)
            r("servidor") = txtSQLServer.Text
            r("login") = txtUserSql.Text
            r("dbpass") = o.EncryptText(txtSenhaSql.Text)
            r("dbnome") = txtDBSql.Text
            r("loja") = txtLoja.Text
            r("dbbazar") = txtDBBazar.Text
            r("LabMont") = cbMontagem.SelectedValue
            r("labSurf") = cbSurfacagem.SelectedValue
            r("bloqueio") = cbBloqueio.Text
            tb.Rows.Add(r)
            ds = New DataSet
            ds.Tables.Add(tb)
        End Try
        ds.WriteXml(Application.StartupPath & "\config.xml")
        Me.Close()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub frmConfig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim conf As New config
        MsgBox(conf.load_config)
        Carrega_combos()
        txtUser.Text = conf.usuario
        txtSenha.Text = conf.senha
        txtSQLServer.Text = conf.servidorDB
        txtUserSql.Text = conf.usuarioSql
        txtSenhaSql.Text = conf.SenhaSql
        txtDBSql.Text = conf.Banco
        txtLoja.Text = conf.Filial
        txtDBBazar.Text = conf.dbBazar
        cbMontagem.SelectedValue = conf.labMont
        cbSurfacagem.SelectedValue = conf.labSurf
        cbBloqueio.SelectedText = conf.Bloqueio
    End Sub
    Private Sub Carrega_combos()
        Dim tt As New DataTable
        Dim tt2 As New DataTable
        d.carrega_Tabela("Select * from laboratorio_montagem", tt)
        cbMontagem.DataSource = tt
        cbMontagem.DisplayMember = "laboratorio"
        cbMontagem.ValueMember = "id_laboratorio"

        d.carrega_Tabela("Select * from laboratorio_surfacagem", tt2)
        cbSurfacagem.DataSource = tt2
        cbSurfacagem.DisplayMember = "laboratorio"
        cbSurfacagem.ValueMember = "cod_lab_surf"

    End Sub
    Private Function monta_tabela() As DataTable
        Dim tb As New DataTable
        tb.Columns.Add("user")
        tb.Columns.Add("senha")
        tb.Columns.Add("servidor")
        tb.Columns.Add("login")
        tb.Columns.Add("dbpass")
        tb.Columns.Add("dbnome")
        tb.Columns.Add("loja")
        tb.Columns.Add("dbBazar")
        tb.Columns.Add("LabMont")
        tb.Columns.Add("labSurf")
        tb.Columns.Add("bloqueio")
        Return tb
    End Function
End Class
