<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnAndamento = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnVerificaAndamento = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.CancelarTrocaBaseProdutoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSaidaExtra = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrocaDeBaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnTroaProd = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.btnTratamento = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnTratamentoRec = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAviso = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAndamento, Me.ToolStripSeparator1, Me.btnVerificaAndamento, Me.ToolStripSeparator2, Me.ToolStripDropDownButton1, Me.ToolStripSeparator3, Me.ToolStripDropDownButton2, Me.ToolStripSeparator4, Me.btnAviso})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(795, 39)
        Me.ToolStrip1.TabIndex = 12
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnAndamento
        '
        Me.btnAndamento.Image = CType(resources.GetObject("btnAndamento.Image"), System.Drawing.Image)
        Me.btnAndamento.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAndamento.Name = "btnAndamento"
        Me.btnAndamento.Size = New System.Drawing.Size(111, 36)
        Me.btnAndamento.Text = "Andamentos"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'btnVerificaAndamento
        '
        Me.btnVerificaAndamento.Image = CType(resources.GetObject("btnVerificaAndamento.Image"), System.Drawing.Image)
        Me.btnVerificaAndamento.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnVerificaAndamento.Name = "btnVerificaAndamento"
        Me.btnVerificaAndamento.Size = New System.Drawing.Size(151, 36)
        Me.btnVerificaAndamento.Text = "Verificar Andamento"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CancelarTrocaBaseProdutoToolStripMenuItem, Me.btnSaidaExtra, Me.TrocaDeBaseToolStripMenuItem, Me.btnTroaProd})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(109, 36)
        Me.ToolStripDropDownButton1.Text = "Solicitação"
        '
        'CancelarTrocaBaseProdutoToolStripMenuItem
        '
        Me.CancelarTrocaBaseProdutoToolStripMenuItem.Name = "CancelarTrocaBaseProdutoToolStripMenuItem"
        Me.CancelarTrocaBaseProdutoToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.CancelarTrocaBaseProdutoToolStripMenuItem.Text = "Cancelar Troca Base/Produto"
        '
        'btnSaidaExtra
        '
        Me.btnSaidaExtra.Name = "btnSaidaExtra"
        Me.btnSaidaExtra.Size = New System.Drawing.Size(226, 22)
        Me.btnSaidaExtra.Text = "Saída Extra"
        '
        'TrocaDeBaseToolStripMenuItem
        '
        Me.TrocaDeBaseToolStripMenuItem.Name = "TrocaDeBaseToolStripMenuItem"
        Me.TrocaDeBaseToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.TrocaDeBaseToolStripMenuItem.Text = "Troca de Base"
        '
        'btnTroaProd
        '
        Me.btnTroaProd.Name = "btnTroaProd"
        Me.btnTroaProd.Size = New System.Drawing.Size(226, 22)
        Me.btnTroaProd.Text = "Troca de Produto"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripDropDownButton2
        '
        Me.ToolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnTratamento, Me.btnTratamentoRec})
        Me.ToolStripDropDownButton2.Image = CType(resources.GetObject("ToolStripDropDownButton2.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(98, 36)
        Me.ToolStripDropDownButton2.Text = "Controle"
        '
        'btnTratamento
        '
        Me.btnTratamento.Name = "btnTratamento"
        Me.btnTratamento.Size = New System.Drawing.Size(205, 22)
        Me.btnTratamento.Text = "Enviado para Tratamento"
        '
        'btnTratamentoRec
        '
        Me.btnTratamentoRec.Name = "btnTratamentoRec"
        Me.btnTratamentoRec.Size = New System.Drawing.Size(205, 22)
        Me.btnTratamentoRec.Text = "Retorno do Tratamento"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 39)
        '
        'btnAviso
        '
        Me.btnAviso.Image = CType(resources.GetObject("btnAviso.Image"), System.Drawing.Image)
        Me.btnAviso.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAviso.Name = "btnAviso"
        Me.btnAviso.Size = New System.Drawing.Size(122, 36)
        Me.btnAviso.Text = "Aviso sobre OS"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 361)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Controle de Produção"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAndamento As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnVerificaAndamento As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAviso As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents btnSaidaExtra As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnTroaProd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripDropDownButton2 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents btnTratamento As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnTratamentoRec As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrocaDeBaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CancelarTrocaBaseProdutoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
