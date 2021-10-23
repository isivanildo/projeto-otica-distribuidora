<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAjusteContagem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAjusteContagem))
        Me.grdProd = New System.Windows.Forms.DataGrid()
        Me.txtsql = New System.Windows.Forms.TextBox()
        Me.pb = New System.Windows.Forms.ProgressBar()
        Me.Pdf = New DataDynamics.ActiveReports.Export.Pdf.PdfExport()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnInventario = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        CType(Me.grdProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdProd
        '
        Me.grdProd.DataMember = ""
        Me.grdProd.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdProd.Location = New System.Drawing.Point(8, 47)
        Me.grdProd.Name = "grdProd"
        Me.grdProd.Size = New System.Drawing.Size(632, 416)
        Me.grdProd.TabIndex = 5
        '
        'txtsql
        '
        Me.txtsql.Location = New System.Drawing.Point(8, 474)
        Me.txtsql.Name = "txtsql"
        Me.txtsql.Size = New System.Drawing.Size(632, 20)
        Me.txtsql.TabIndex = 7
        '
        'pb
        '
        Me.pb.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pb.Location = New System.Drawing.Point(0, 500)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(646, 23)
        Me.pb.TabIndex = 17
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnInventario, Me.ToolStripSeparator1, Me.btnPrint})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(646, 39)
        Me.ToolStrip1.TabIndex = 18
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnInventario
        '
        Me.btnInventario.Image = CType(resources.GetObject("btnInventario.Image"), System.Drawing.Image)
        Me.btnInventario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnInventario.Name = "btnInventario"
        Me.btnInventario.Size = New System.Drawing.Size(119, 36)
        Me.btnInventario.Text = "Estoque Inicial"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'btnPrint
        '
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(89, 36)
        Me.btnPrint.Text = "Imprimir"
        '
        'frmAjusteContagem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 523)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.pb)
        Me.Controls.Add(Me.txtsql)
        Me.Controls.Add(Me.grdProd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAjusteContagem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajuste Contagem Estoque"
        CType(Me.grdProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdProd As System.Windows.Forms.DataGrid
    Friend WithEvents txtsql As System.Windows.Forms.TextBox
    Friend WithEvents pb As System.Windows.Forms.ProgressBar
    Friend WithEvents Pdf As DataDynamics.ActiveReports.Export.Pdf.PdfExport
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnInventario As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
End Class
