<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportaBancos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImportaBancos))
        Me.txt = New System.Windows.Forms.RichTextBox()
        Me.btnProcessar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt
        '
        Me.txt.Location = New System.Drawing.Point(12, 12)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(520, 201)
        Me.txt.TabIndex = 12
        Me.txt.Text = "txt"
        '
        'btnProcessar
        '
        Me.btnProcessar.Location = New System.Drawing.Point(237, 219)
        Me.btnProcessar.Name = "btnProcessar"
        Me.btnProcessar.Size = New System.Drawing.Size(75, 23)
        Me.btnProcessar.TabIndex = 11
        Me.btnProcessar.Text = "Importa"
        '
        'frmImportaBancos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 257)
        Me.Controls.Add(Me.txt)
        Me.Controls.Add(Me.btnProcessar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmImportaBancos"
        Me.Text = "frmImportaBancos"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt As System.Windows.Forms.RichTextBox
    Friend WithEvents btnProcessar As System.Windows.Forms.Button
End Class
