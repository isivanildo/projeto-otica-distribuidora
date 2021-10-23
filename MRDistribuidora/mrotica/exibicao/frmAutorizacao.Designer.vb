<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAutorizacao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAutorizacao))
        Me.grpAutorizacao = New System.Windows.Forms.GroupBox()
        Me.grdAutorizacao = New System.Windows.Forms.DataGridView()
        Me.txtValorAutorizado = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txtDescricaoAut = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodCliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRazao = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnAutorizar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSair = New System.Windows.Forms.ToolStripButton()
        Me.grpAutorizacao.SuspendLayout()
        CType(Me.grdAutorizacao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpAutorizacao
        '
        Me.grpAutorizacao.Controls.Add(Me.grdAutorizacao)
        Me.grpAutorizacao.Controls.Add(Me.txtValorAutorizado)
        Me.grpAutorizacao.Controls.Add(Me.Label36)
        Me.grpAutorizacao.Controls.Add(Me.Label37)
        Me.grpAutorizacao.Controls.Add(Me.txtDescricaoAut)
        Me.grpAutorizacao.Location = New System.Drawing.Point(16, 110)
        Me.grpAutorizacao.Name = "grpAutorizacao"
        Me.grpAutorizacao.Size = New System.Drawing.Size(880, 279)
        Me.grpAutorizacao.TabIndex = 3
        Me.grpAutorizacao.TabStop = False
        Me.grpAutorizacao.Text = "Autorizações"
        '
        'grdAutorizacao
        '
        Me.grdAutorizacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdAutorizacao.Location = New System.Drawing.Point(9, 74)
        Me.grdAutorizacao.Name = "grdAutorizacao"
        Me.grdAutorizacao.Size = New System.Drawing.Size(865, 197)
        Me.grdAutorizacao.TabIndex = 2
        '
        'txtValorAutorizado
        '
        Me.txtValorAutorizado.Location = New System.Drawing.Point(6, 40)
        Me.txtValorAutorizado.Name = "txtValorAutorizado"
        Me.txtValorAutorizado.Size = New System.Drawing.Size(100, 20)
        Me.txtValorAutorizado.TabIndex = 0
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(116, 22)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(55, 13)
        Me.Label36.TabIndex = 4
        Me.Label36.Text = "Descrição"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(6, 22)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(84, 13)
        Me.Label37.TabIndex = 3
        Me.Label37.Text = "Valor Autorizado"
        '
        'txtDescricaoAut
        '
        Me.txtDescricaoAut.Location = New System.Drawing.Point(116, 40)
        Me.txtDescricaoAut.Name = "txtDescricaoAut"
        Me.txtDescricaoAut.Size = New System.Drawing.Size(756, 20)
        Me.txtDescricaoAut.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Cód. Cliente"
        '
        'txtCodCliente
        '
        Me.txtCodCliente.Location = New System.Drawing.Point(16, 72)
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.ReadOnly = True
        Me.txtCodCliente.Size = New System.Drawing.Size(84, 20)
        Me.txtCodCliente.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(112, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nome"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(112, 72)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.ReadOnly = True
        Me.txtNome.Size = New System.Drawing.Size(385, 20)
        Me.txtNome.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(508, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Razão Social"
        '
        'txtRazao
        '
        Me.txtRazao.Location = New System.Drawing.Point(508, 72)
        Me.txtRazao.Name = "txtRazao"
        Me.txtRazao.ReadOnly = True
        Me.txtRazao.Size = New System.Drawing.Size(385, 20)
        Me.txtRazao.TabIndex = 2
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAutorizar, Me.ToolStripSeparator1, Me.btnSair})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(915, 39)
        Me.ToolStrip1.TabIndex = 8
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnAutorizar
        '
        Me.btnAutorizar.Image = CType(resources.GetObject("btnAutorizar.Image"), System.Drawing.Image)
        Me.btnAutorizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAutorizar.Name = "btnAutorizar"
        Me.btnAutorizar.Size = New System.Drawing.Size(91, 36)
        Me.btnAutorizar.Text = "Autorizar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'btnSair
        '
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(62, 36)
        Me.btnSair.Text = "Sair"
        '
        'frmAutorizacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 415)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.txtRazao)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCodCliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpAutorizacao)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAutorizacao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Autorização para Clientes"
        Me.grpAutorizacao.ResumeLayout(False)
        Me.grpAutorizacao.PerformLayout()
        CType(Me.grdAutorizacao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpAutorizacao As System.Windows.Forms.GroupBox
    Friend WithEvents txtValorAutorizado As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents txtDescricaoAut As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRazao As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAutorizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSair As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdAutorizacao As System.Windows.Forms.DataGridView
End Class
