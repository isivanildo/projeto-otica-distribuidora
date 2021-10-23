<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCodBarraUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCodBarraUsuarios))
        Me.lstUsuarios = New System.Windows.Forms.ListBox()
        Me.lstPrint = New System.Windows.Forms.ListBox()
        Me.btpPrint = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstUsuarios
        '
        Me.lstUsuarios.FormattingEnabled = True
        Me.lstUsuarios.Location = New System.Drawing.Point(2, 12)
        Me.lstUsuarios.Name = "lstUsuarios"
        Me.lstUsuarios.Size = New System.Drawing.Size(202, 199)
        Me.lstUsuarios.TabIndex = 0
        '
        'lstPrint
        '
        Me.lstPrint.FormattingEnabled = True
        Me.lstPrint.Location = New System.Drawing.Point(275, 12)
        Me.lstPrint.Name = "lstPrint"
        Me.lstPrint.Size = New System.Drawing.Size(202, 199)
        Me.lstPrint.TabIndex = 1
        '
        'btpPrint
        '
        Me.btpPrint.Location = New System.Drawing.Point(202, 231)
        Me.btpPrint.Name = "btpPrint"
        Me.btpPrint.Size = New System.Drawing.Size(75, 23)
        Me.btpPrint.TabIndex = 2
        Me.btpPrint.Text = "Imprimir"
        Me.btpPrint.UseVisualStyleBackColor = True
        '
        'frmCodBarraUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 266)
        Me.Controls.Add(Me.btpPrint)
        Me.Controls.Add(Me.lstPrint)
        Me.Controls.Add(Me.lstUsuarios)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCodBarraUsuarios"
        Me.Text = "frmCodBarraUsuarios"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstUsuarios As System.Windows.Forms.ListBox
    Friend WithEvents lstPrint As System.Windows.Forms.ListBox
    Friend WithEvents btpPrint As System.Windows.Forms.Button
End Class
