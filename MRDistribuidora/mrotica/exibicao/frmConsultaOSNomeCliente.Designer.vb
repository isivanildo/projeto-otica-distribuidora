<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaOSNomeCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaOSNomeCliente))
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.grdOS = New System.Windows.Forms.DataGrid()
        CType(Me.grdOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(12, 12)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(659, 20)
        Me.txtNome.TabIndex = 0
        '
        'grdOS
        '
        Me.grdOS.AllowSorting = False
        Me.grdOS.CaptionText = "OS"
        Me.grdOS.DataMember = ""
        Me.grdOS.FlatMode = True
        Me.grdOS.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdOS.Location = New System.Drawing.Point(12, 38)
        Me.grdOS.Name = "grdOS"
        Me.grdOS.ReadOnly = True
        Me.grdOS.Size = New System.Drawing.Size(659, 301)
        Me.grdOS.TabIndex = 20
        '
        'frmConsultaOSNomeCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 366)
        Me.Controls.Add(Me.grdOS)
        Me.Controls.Add(Me.txtNome)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConsultaOSNomeCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmConsultaOSNomeCliente"
        CType(Me.grdOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents grdOS As System.Windows.Forms.DataGrid
End Class
