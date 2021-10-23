<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTitulosAcordo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTitulosAcordo))
        Me.btnOK = New System.Windows.Forms.Button()
        Me.grdTitulos = New System.Windows.Forms.DataGrid()
        CType(Me.grdTitulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(313, 307)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'grdTitulos
        '
        Me.grdTitulos.AllowSorting = False
        Me.grdTitulos.DataMember = ""
        Me.grdTitulos.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdTitulos.Location = New System.Drawing.Point(4, 6)
        Me.grdTitulos.Name = "grdTitulos"
        Me.grdTitulos.ReadOnly = True
        Me.grdTitulos.Size = New System.Drawing.Size(685, 295)
        Me.grdTitulos.TabIndex = 3
        '
        'frmTitulosAcordo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 336)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.grdTitulos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTitulosAcordo"
        Me.Text = "frmTitulosAcordo"
        CType(Me.grdTitulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents grdTitulos As System.Windows.Forms.DataGrid
End Class
