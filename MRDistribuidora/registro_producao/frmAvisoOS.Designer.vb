<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAvisoOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAvisoOS))
        Me.txtAviso = New System.Windows.Forms.TextBox()
        Me.btnAviso = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtAviso
        '
        Me.txtAviso.Location = New System.Drawing.Point(12, 12)
        Me.txtAviso.Multiline = True
        Me.txtAviso.Name = "txtAviso"
        Me.txtAviso.Size = New System.Drawing.Size(364, 54)
        Me.txtAviso.TabIndex = 0
        '
        'btnAviso
        '
        Me.btnAviso.Image = CType(resources.GetObject("btnAviso.Image"), System.Drawing.Image)
        Me.btnAviso.Location = New System.Drawing.Point(98, 72)
        Me.btnAviso.Name = "btnAviso"
        Me.btnAviso.Size = New System.Drawing.Size(89, 28)
        Me.btnAviso.TabIndex = 1
        Me.btnAviso.Text = "OK"
        Me.btnAviso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAviso.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(200, 72)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(89, 28)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancelar"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmAvisoOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 107)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAviso)
        Me.Controls.Add(Me.txtAviso)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAvisoOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aviso sobre OS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAviso As System.Windows.Forms.TextBox
    Friend WithEvents btnAviso As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
