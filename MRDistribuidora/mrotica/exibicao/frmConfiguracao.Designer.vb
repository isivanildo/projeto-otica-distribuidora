<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfiguracao
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfiguracao))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtBancoDados = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSalvarDB = New System.Windows.Forms.Button()
        Me.txtSenhaDB = New System.Windows.Forms.TextBox()
        Me.txtUsuarioDB = New System.Windows.Forms.TextBox()
        Me.txtLoja = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtServidorDB = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtDescVista = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtVendedorExterno = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtVendedorInterno = New System.Windows.Forms.TextBox()
        Me.btnSalvarVend = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtBancoDados)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btnSalvarDB)
        Me.GroupBox1.Controls.Add(Me.txtSenhaDB)
        Me.GroupBox1.Controls.Add(Me.txtUsuarioDB)
        Me.GroupBox1.Controls.Add(Me.txtLoja)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtServidorDB)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(455, 121)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Configuração de Acesso ao Banco de Dado do mrotica"
        '
        'txtBancoDados
        '
        Me.txtBancoDados.Location = New System.Drawing.Point(101, 56)
        Me.txtBancoDados.Name = "txtBancoDados"
        Me.txtBancoDados.Size = New System.Drawing.Size(121, 20)
        Me.txtBancoDados.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Banco de Dados:"
        '
        'btnSalvarDB
        '
        Me.btnSalvarDB.Image = CType(resources.GetObject("btnSalvarDB.Image"), System.Drawing.Image)
        Me.btnSalvarDB.Location = New System.Drawing.Point(363, 78)
        Me.btnSalvarDB.Name = "btnSalvarDB"
        Me.btnSalvarDB.Size = New System.Drawing.Size(79, 35)
        Me.btnSalvarDB.TabIndex = 9
        Me.btnSalvarDB.Text = "Salvar"
        Me.btnSalvarDB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvarDB.UseVisualStyleBackColor = True
        '
        'txtSenhaDB
        '
        Me.txtSenhaDB.Location = New System.Drawing.Point(251, 88)
        Me.txtSenhaDB.Name = "txtSenhaDB"
        Me.txtSenhaDB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenhaDB.Size = New System.Drawing.Size(91, 20)
        Me.txtSenhaDB.TabIndex = 8
        '
        'txtUsuarioDB
        '
        Me.txtUsuarioDB.Location = New System.Drawing.Point(76, 88)
        Me.txtUsuarioDB.Name = "txtUsuarioDB"
        Me.txtUsuarioDB.Size = New System.Drawing.Size(97, 20)
        Me.txtUsuarioDB.TabIndex = 7
        '
        'txtLoja
        '
        Me.txtLoja.Location = New System.Drawing.Point(281, 56)
        Me.txtLoja.Name = "txtLoja"
        Me.txtLoja.Size = New System.Drawing.Size(59, 20)
        Me.txtLoja.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(245, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Loja:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(189, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Senha DB:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Usuário DB:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Servidor DB:"
        '
        'txtServidorDB
        '
        Me.txtServidorDB.Location = New System.Drawing.Point(76, 27)
        Me.txtServidorDB.Name = "txtServidorDB"
        Me.txtServidorDB.Size = New System.Drawing.Size(265, 20)
        Me.txtServidorDB.TabIndex = 2
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.ImageList = Me.ImageList1
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(479, 206)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.ImageIndex = 0
        Me.TabPage1.Location = New System.Drawing.Point(4, 39)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(471, 163)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Configurações Gerais"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.btnSalvarVend)
        Me.TabPage2.Location = New System.Drawing.Point(4, 39)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(471, 163)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Outras Configurações"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtDescVista)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtVendedorExterno)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtVendedorInterno)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(263, 110)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Configurar Comissão (%)"
        '
        'txtDescVista
        '
        Me.txtDescVista.Location = New System.Drawing.Point(153, 80)
        Me.txtDescVista.Name = "txtDescVista"
        Me.txtDescVista.Size = New System.Drawing.Size(57, 20)
        Me.txtDescVista.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Desconto p/ Compra a Vista:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Vendedor Externo:"
        '
        'txtVendedorExterno
        '
        Me.txtVendedorExterno.Location = New System.Drawing.Point(104, 53)
        Me.txtVendedorExterno.Name = "txtVendedorExterno"
        Me.txtVendedorExterno.Size = New System.Drawing.Size(57, 20)
        Me.txtVendedorExterno.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Vendedor Interno:"
        '
        'txtVendedorInterno
        '
        Me.txtVendedorInterno.Location = New System.Drawing.Point(104, 27)
        Me.txtVendedorInterno.Name = "txtVendedorInterno"
        Me.txtVendedorInterno.Size = New System.Drawing.Size(57, 20)
        Me.txtVendedorInterno.TabIndex = 0
        '
        'btnSalvarVend
        '
        Me.btnSalvarVend.Image = CType(resources.GetObject("btnSalvarVend.Image"), System.Drawing.Image)
        Me.btnSalvarVend.Location = New System.Drawing.Point(196, 130)
        Me.btnSalvarVend.Name = "btnSalvarVend"
        Me.btnSalvarVend.Size = New System.Drawing.Size(75, 25)
        Me.btnSalvarVend.TabIndex = 1
        Me.btnSalvarVend.Text = "Salvar"
        Me.btnSalvarVend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvarVend.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "conf32.png")
        '
        'frmConfiguracao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 206)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConfiguracao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configurações do Sistema"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtServidorDB As System.Windows.Forms.TextBox
    Friend WithEvents btnSalvarDB As System.Windows.Forms.Button
    Friend WithEvents txtSenhaDB As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuarioDB As System.Windows.Forms.TextBox
    Friend WithEvents txtLoja As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents txtBancoDados As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSalvarVend As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtVendedorInterno As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtVendedorExterno As System.Windows.Forms.TextBox
    Friend WithEvents txtDescVista As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
