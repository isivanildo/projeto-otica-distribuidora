<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPedidosCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPedidosCliente))
        Me.grdPedidos = New System.Windows.Forms.DataGrid()
        Me.btnOK = New System.Windows.Forms.Button()
        CType(Me.grdPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdPedidos
        '
        Me.grdPedidos.AllowSorting = False
        Me.grdPedidos.DataMember = ""
        Me.grdPedidos.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdPedidos.Location = New System.Drawing.Point(4, 6)
        Me.grdPedidos.Name = "grdPedidos"
        Me.grdPedidos.ReadOnly = True
        Me.grdPedidos.Size = New System.Drawing.Size(685, 295)
        Me.grdPedidos.TabIndex = 1
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(313, 307)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'frmPedidosCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 342)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.grdPedidos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPedidosCliente"
        Me.Text = "Pedidos Cliente"
        CType(Me.grdPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdPedidos As System.Windows.Forms.DataGrid
    Friend WithEvents btnOK As System.Windows.Forms.Button
End Class
