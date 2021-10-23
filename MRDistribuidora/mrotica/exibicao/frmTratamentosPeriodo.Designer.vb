<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTratamentosPeriodo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTratamentosPeriodo))
        Me.dtini = New System.Windows.Forms.DateTimePicker()
        Me.dtFim = New System.Windows.Forms.DateTimePicker()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'dtini
        '
        Me.dtini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtini.Location = New System.Drawing.Point(23, 26)
        Me.dtini.Name = "dtini"
        Me.dtini.Size = New System.Drawing.Size(86, 20)
        Me.dtini.TabIndex = 0
        '
        'dtFim
        '
        Me.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFim.Location = New System.Drawing.Point(155, 26)
        Me.dtFim.Name = "dtFim"
        Me.dtFim.Size = New System.Drawing.Size(86, 20)
        Me.dtFim.TabIndex = 1
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(89, 74)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'frmTratamentosPeriodo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(264, 112)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.dtFim)
        Me.Controls.Add(Me.dtini)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTratamentosPeriodo"
        Me.Text = "frmTratamentosPeriodo"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtini As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFim As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnOk As System.Windows.Forms.Button
End Class
