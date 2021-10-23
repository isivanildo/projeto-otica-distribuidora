<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExcluiPedidoFatura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExcluiPedidoFatura))
        Me.grdPedidoItem = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbExcluir = New System.Windows.Forms.RadioButton()
        Me.rbAdicionar = New System.Windows.Forms.RadioButton()
        Me.btnIncluirPedido = New System.Windows.Forms.Button()
        Me.btnExcluiPedido = New System.Windows.Forms.Button()
        CType(Me.grdPedidoItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdPedidoItem
        '
        Me.grdPedidoItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdPedidoItem.Location = New System.Drawing.Point(12, 12)
        Me.grdPedidoItem.Name = "grdPedidoItem"
        Me.grdPedidoItem.Size = New System.Drawing.Size(768, 282)
        Me.grdPedidoItem.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbExcluir)
        Me.GroupBox1.Controls.Add(Me.rbAdicionar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 310)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(225, 40)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados"
        '
        'rbExcluir
        '
        Me.rbExcluir.AutoSize = True
        Me.rbExcluir.Location = New System.Drawing.Point(128, 16)
        Me.rbExcluir.Name = "rbExcluir"
        Me.rbExcluir.Size = New System.Drawing.Size(92, 17)
        Me.rbExcluir.TabIndex = 1
        Me.rbExcluir.TabStop = True
        Me.rbExcluir.Text = "Excluir Pedido"
        Me.rbExcluir.UseVisualStyleBackColor = True
        '
        'rbAdicionar
        '
        Me.rbAdicionar.AutoSize = True
        Me.rbAdicionar.Location = New System.Drawing.Point(9, 16)
        Me.rbAdicionar.Name = "rbAdicionar"
        Me.rbAdicionar.Size = New System.Drawing.Size(105, 17)
        Me.rbAdicionar.TabIndex = 0
        Me.rbAdicionar.TabStop = True
        Me.rbAdicionar.Text = "Adicionar Pedido"
        Me.rbAdicionar.UseVisualStyleBackColor = True
        '
        'btnIncluirPedido
        '
        Me.btnIncluirPedido.Image = CType(resources.GetObject("btnIncluirPedido.Image"), System.Drawing.Image)
        Me.btnIncluirPedido.Location = New System.Drawing.Point(553, 315)
        Me.btnIncluirPedido.Name = "btnIncluirPedido"
        Me.btnIncluirPedido.Size = New System.Drawing.Size(111, 32)
        Me.btnIncluirPedido.TabIndex = 2
        Me.btnIncluirPedido.Text = "Adicionar Pedido"
        Me.btnIncluirPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnIncluirPedido.UseVisualStyleBackColor = True
        '
        'btnExcluiPedido
        '
        Me.btnExcluiPedido.Image = CType(resources.GetObject("btnExcluiPedido.Image"), System.Drawing.Image)
        Me.btnExcluiPedido.Location = New System.Drawing.Point(670, 315)
        Me.btnExcluiPedido.Name = "btnExcluiPedido"
        Me.btnExcluiPedido.Size = New System.Drawing.Size(111, 32)
        Me.btnExcluiPedido.TabIndex = 1
        Me.btnExcluiPedido.Text = "Excluir Pedido"
        Me.btnExcluiPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExcluiPedido.UseVisualStyleBackColor = True
        '
        'frmExcluiPedidoFatura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 359)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnIncluirPedido)
        Me.Controls.Add(Me.btnExcluiPedido)
        Me.Controls.Add(Me.grdPedidoItem)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmExcluiPedidoFatura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmExcluiPedidoFatura"
        CType(Me.grdPedidoItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdPedidoItem As System.Windows.Forms.DataGridView
    Friend WithEvents btnExcluiPedido As System.Windows.Forms.Button
    Friend WithEvents btnIncluirPedido As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbExcluir As System.Windows.Forms.RadioButton
    Friend WithEvents rbAdicionar As System.Windows.Forms.RadioButton
End Class
