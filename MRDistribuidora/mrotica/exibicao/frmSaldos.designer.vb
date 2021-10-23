<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaldos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSaldos))
        Me.mnuGrd = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DetalhamentoSaldoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetalhamentoPedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.txtTabela = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCrit = New System.Windows.Forms.TextBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.cbFilial = New System.Windows.Forms.ComboBox()
        Me.grdItens = New System.Windows.Forms.DataGridView()
        Me.mnuGrd.SuspendLayout()
        CType(Me.grdItens, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuGrd
        '
        Me.mnuGrd.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DetalhamentoSaldoToolStripMenuItem, Me.DetalhamentoPedidosToolStripMenuItem})
        Me.mnuGrd.Name = "mnuGrd"
        Me.mnuGrd.Size = New System.Drawing.Size(195, 48)
        '
        'DetalhamentoSaldoToolStripMenuItem
        '
        Me.DetalhamentoSaldoToolStripMenuItem.Name = "DetalhamentoSaldoToolStripMenuItem"
        Me.DetalhamentoSaldoToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.DetalhamentoSaldoToolStripMenuItem.Text = "Detalhamento Saldo"
        '
        'DetalhamentoPedidosToolStripMenuItem
        '
        Me.DetalhamentoPedidosToolStripMenuItem.Name = "DetalhamentoPedidosToolStripMenuItem"
        Me.DetalhamentoPedidosToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.DetalhamentoPedidosToolStripMenuItem.Text = "Detalhamento Pedidos"
        '
        'btnConsultar
        '
        Me.btnConsultar.Image = CType(resources.GetObject("btnConsultar.Image"), System.Drawing.Image)
        Me.btnConsultar.Location = New System.Drawing.Point(570, 20)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(84, 26)
        Me.btnConsultar.TabIndex = 3
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'txtTabela
        '
        Me.txtTabela.Location = New System.Drawing.Point(7, 23)
        Me.txtTabela.Name = "txtTabela"
        Me.txtTabela.Size = New System.Drawing.Size(82, 20)
        Me.txtTabela.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Código Tabela"
        '
        'txtCrit
        '
        Me.txtCrit.Location = New System.Drawing.Point(95, 23)
        Me.txtCrit.Name = "txtCrit"
        Me.txtCrit.Size = New System.Drawing.Size(375, 20)
        Me.txtCrit.TabIndex = 1
        '
        'btnPrint
        '
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.Location = New System.Drawing.Point(288, 408)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(84, 29)
        Me.btnPrint.TabIndex = 5
        Me.btnPrint.Text = "Imprimir"
        Me.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'cbFilial
        '
        Me.cbFilial.FormattingEnabled = True
        Me.cbFilial.Location = New System.Drawing.Point(476, 23)
        Me.cbFilial.Name = "cbFilial"
        Me.cbFilial.Size = New System.Drawing.Size(90, 21)
        Me.cbFilial.TabIndex = 2
        '
        'grdItens
        '
        Me.grdItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdItens.ContextMenuStrip = Me.mnuGrd
        Me.grdItens.Location = New System.Drawing.Point(7, 52)
        Me.grdItens.Name = "grdItens"
        Me.grdItens.RowHeadersVisible = False
        Me.grdItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdItens.Size = New System.Drawing.Size(645, 353)
        Me.grdItens.TabIndex = 4
        '
        'frmSaldos
        '
        Me.AcceptButton = Me.btnConsultar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 441)
        Me.Controls.Add(Me.grdItens)
        Me.Controls.Add(Me.cbFilial)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.txtCrit)
        Me.Controls.Add(Me.txtTabela)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnConsultar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSaldos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Saldo"
        Me.mnuGrd.ResumeLayout(False)
        CType(Me.grdItens, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents txtTabela As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCrit As System.Windows.Forms.TextBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents cbFilial As System.Windows.Forms.ComboBox
    Friend WithEvents mnuGrd As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DetalhamentoSaldoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DetalhamentoPedidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grdItens As System.Windows.Forms.DataGridView
End Class
