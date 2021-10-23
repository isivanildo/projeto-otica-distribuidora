<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDevolvePedido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDevolvePedido))
        Me.grdProd = New System.Windows.Forms.DataGrid()
        Me.lblNpedido = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDevolverItens = New System.Windows.Forms.Button()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        CType(Me.grdProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdProd
        '
        Me.grdProd.AllowSorting = False
        Me.grdProd.CaptionText = "Produtos"
        Me.grdProd.DataMember = ""
        Me.grdProd.FlatMode = True
        Me.grdProd.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdProd.Location = New System.Drawing.Point(0, 49)
        Me.grdProd.Name = "grdProd"
        Me.grdProd.ReadOnly = True
        Me.grdProd.Size = New System.Drawing.Size(756, 179)
        Me.grdProd.TabIndex = 11
        '
        'lblNpedido
        '
        Me.lblNpedido.AutoSize = True
        Me.lblNpedido.Location = New System.Drawing.Point(12, 22)
        Me.lblNpedido.Name = "lblNpedido"
        Me.lblNpedido.Size = New System.Drawing.Size(13, 13)
        Me.lblNpedido.TabIndex = 13
        Me.lblNpedido.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Número Pedido"
        '
        'btnDevolverItens
        '
        Me.btnDevolverItens.BackColor = System.Drawing.SystemColors.Control
        Me.btnDevolverItens.Location = New System.Drawing.Point(332, 238)
        Me.btnDevolverItens.Name = "btnDevolverItens"
        Me.btnDevolverItens.Size = New System.Drawing.Size(94, 24)
        Me.btnDevolverItens.TabIndex = 33
        Me.btnDevolverItens.Text = "Devolver"
        Me.btnDevolverItens.UseVisualStyleBackColor = False
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(0, 267)
        Me.txtDescricao.Multiline = True
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(756, 113)
        Me.txtDescricao.TabIndex = 34
        '
        'frmDevolvePedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 404)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.btnDevolverItens)
        Me.Controls.Add(Me.lblNpedido)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grdProd)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDevolvePedido"
        Me.Text = "frmDevolvePedido"
        CType(Me.grdProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdProd As System.Windows.Forms.DataGrid
    Friend WithEvents lblNpedido As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnDevolverItens As System.Windows.Forms.Button
    Friend WithEvents txtDescricao As System.Windows.Forms.TextBox
End Class
