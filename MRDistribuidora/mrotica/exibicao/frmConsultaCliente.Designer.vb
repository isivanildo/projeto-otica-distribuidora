<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaCliente))
        Me.grdCliente = New System.Windows.Forms.DataGrid()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        CType(Me.grdCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdCliente
        '
        Me.grdCliente.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.grdCliente.BackColor = System.Drawing.Color.WhiteSmoke
        Me.grdCliente.BackgroundColor = System.Drawing.Color.White
        Me.grdCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdCliente.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.grdCliente.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.grdCliente.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.grdCliente.CaptionVisible = False
        Me.grdCliente.DataMember = ""
        Me.grdCliente.FlatMode = True
        Me.grdCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.grdCliente.ForeColor = System.Drawing.Color.MidnightBlue
        Me.grdCliente.GridLineColor = System.Drawing.Color.Gainsboro
        Me.grdCliente.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.grdCliente.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.grdCliente.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.grdCliente.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.grdCliente.LinkColor = System.Drawing.Color.Teal
        Me.grdCliente.Location = New System.Drawing.Point(12, 41)
        Me.grdCliente.Name = "grdCliente"
        Me.grdCliente.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.grdCliente.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.grdCliente.ReadOnly = True
        Me.grdCliente.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.grdCliente.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.grdCliente.Size = New System.Drawing.Size(825, 283)
        Me.grdCliente.TabIndex = 1
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(12, 12)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(327, 20)
        Me.txtNome.TabIndex = 0
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(345, 12)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(75, 23)
        Me.btnConsultar.TabIndex = 1
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(384, 330)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "&Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'frmConsultaCliente
        '
        Me.AcceptButton = Me.btnConsultar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 359)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.grdCliente)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConsultaCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmConsultaCliente"
        CType(Me.grdCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdCliente As System.Windows.Forms.DataGrid
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents btnOk As System.Windows.Forms.Button
End Class
