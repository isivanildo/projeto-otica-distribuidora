<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCredito
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCredito))
        Me.mnuFaturas = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RemoverFaturaDoPedidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblFilialFatura = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.grdPedido = New System.Windows.Forms.DataGridView()
        Me.lblCodFatura = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbDinheiro = New System.Windows.Forms.RadioButton()
        Me.rbCredito = New System.Windows.Forms.RadioButton()
        Me.grdServico = New System.Windows.Forms.DataGridView()
        Me.btnComprovante = New System.Windows.Forms.Button()
        Me.btnEstornar = New System.Windows.Forms.Button()
        Me.mnuFaturas.SuspendLayout()
        CType(Me.grdPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdServico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuFaturas
        '
        Me.mnuFaturas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoverFaturaDoPedidoToolStripMenuItem})
        Me.mnuFaturas.Name = "mnuFaturas"
        Me.mnuFaturas.Size = New System.Drawing.Size(212, 26)
        '
        'RemoverFaturaDoPedidoToolStripMenuItem
        '
        Me.RemoverFaturaDoPedidoToolStripMenuItem.Name = "RemoverFaturaDoPedidoToolStripMenuItem"
        Me.RemoverFaturaDoPedidoToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.RemoverFaturaDoPedidoToolStripMenuItem.Text = "Remover pedido da fatura"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Location = New System.Drawing.Point(11, 3)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(142, 13)
        Me.lblCliente.TabIndex = 3
        Me.lblCliente.Text = "Identificação do Cliente"
        '
        'lblFilialFatura
        '
        Me.lblFilialFatura.AutoSize = True
        Me.lblFilialFatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilialFatura.Location = New System.Drawing.Point(11, 22)
        Me.lblFilialFatura.Name = "lblFilialFatura"
        Me.lblFilialFatura.Size = New System.Drawing.Size(100, 15)
        Me.lblFilialFatura.TabIndex = 4
        Me.lblFilialFatura.Text = "Filial / Pedido:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(108, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 15)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "Label13"
        '
        'grdPedido
        '
        Me.grdPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdPedido.Location = New System.Drawing.Point(12, 45)
        Me.grdPedido.Name = "grdPedido"
        Me.grdPedido.RowHeadersVisible = False
        Me.grdPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdPedido.Size = New System.Drawing.Size(1044, 198)
        Me.grdPedido.TabIndex = 0
        '
        'lblCodFatura
        '
        Me.lblCodFatura.AutoSize = True
        Me.lblCodFatura.Location = New System.Drawing.Point(781, 22)
        Me.lblCodFatura.Name = "lblCodFatura"
        Me.lblCodFatura.Size = New System.Drawing.Size(39, 13)
        Me.lblCodFatura.TabIndex = 45
        Me.lblCodFatura.Text = "Label1"
        Me.lblCodFatura.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbDinheiro)
        Me.GroupBox1.Controls.Add(Me.rbCredito)
        Me.GroupBox1.Location = New System.Drawing.Point(562, 445)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(209, 45)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de devolução"
        '
        'rbDinheiro
        '
        Me.rbDinheiro.AutoSize = True
        Me.rbDinheiro.Location = New System.Drawing.Point(88, 21)
        Me.rbDinheiro.Name = "rbDinheiro"
        Me.rbDinheiro.Size = New System.Drawing.Size(64, 17)
        Me.rbDinheiro.TabIndex = 1
        Me.rbDinheiro.TabStop = True
        Me.rbDinheiro.Text = "Dinheiro"
        Me.rbDinheiro.UseVisualStyleBackColor = True
        '
        'rbCredito
        '
        Me.rbCredito.AutoSize = True
        Me.rbCredito.Location = New System.Drawing.Point(11, 21)
        Me.rbCredito.Name = "rbCredito"
        Me.rbCredito.Size = New System.Drawing.Size(58, 17)
        Me.rbCredito.TabIndex = 0
        Me.rbCredito.TabStop = True
        Me.rbCredito.Text = "Crédito"
        Me.rbCredito.UseVisualStyleBackColor = True
        '
        'grdServico
        '
        Me.grdServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdServico.Location = New System.Drawing.Point(13, 255)
        Me.grdServico.Name = "grdServico"
        Me.grdServico.RowHeadersVisible = False
        Me.grdServico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdServico.Size = New System.Drawing.Size(1044, 178)
        Me.grdServico.TabIndex = 46
        '
        'btnComprovante
        '
        Me.btnComprovante.Enabled = False
        Me.btnComprovante.Image = CType(resources.GetObject("btnComprovante.Image"), System.Drawing.Image)
        Me.btnComprovante.Location = New System.Drawing.Point(918, 457)
        Me.btnComprovante.Name = "btnComprovante"
        Me.btnComprovante.Size = New System.Drawing.Size(117, 26)
        Me.btnComprovante.TabIndex = 3
        Me.btnComprovante.Text = "Comprovante"
        Me.btnComprovante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnComprovante.UseVisualStyleBackColor = True
        '
        'btnEstornar
        '
        Me.btnEstornar.Image = CType(resources.GetObject("btnEstornar.Image"), System.Drawing.Image)
        Me.btnEstornar.Location = New System.Drawing.Point(795, 457)
        Me.btnEstornar.Name = "btnEstornar"
        Me.btnEstornar.Size = New System.Drawing.Size(117, 26)
        Me.btnEstornar.TabIndex = 2
        Me.btnEstornar.Text = "Estornar Crédito"
        Me.btnEstornar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEstornar.UseVisualStyleBackColor = True
        '
        'frmCredito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1069, 504)
        Me.Controls.Add(Me.grdServico)
        Me.Controls.Add(Me.btnComprovante)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblCodFatura)
        Me.Controls.Add(Me.grdPedido)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblFilialFatura)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.btnEstornar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCredito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estornar Crédito/Dinheiro"
        Me.mnuFaturas.ResumeLayout(False)
        CType(Me.grdPedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdServico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents lblFilialFatura As System.Windows.Forms.Label
    Friend WithEvents mnuFaturas As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RemoverFaturaDoPedidoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnEstornar As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents grdPedido As System.Windows.Forms.DataGridView
    Friend WithEvents lblCodFatura As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbDinheiro As System.Windows.Forms.RadioButton
    Friend WithEvents rbCredito As System.Windows.Forms.RadioButton
    Friend WithEvents btnComprovante As System.Windows.Forms.Button
    Friend WithEvents grdServico As System.Windows.Forms.DataGridView
End Class
