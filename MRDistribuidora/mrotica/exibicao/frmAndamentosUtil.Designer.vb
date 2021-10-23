<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAndamentosUtil
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAndamentosUtil))
        Me.txtFilial = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtOS = New System.Windows.Forms.TextBox()
        Me.grdAndamentos = New System.Windows.Forms.DataGridView()
        Me.mnuAcoes = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeletarAndamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        CType(Me.grdAndamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuAcoes.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtFilial
        '
        Me.txtFilial.Location = New System.Drawing.Point(45, 9)
        Me.txtFilial.Name = "txtFilial"
        Me.txtFilial.Size = New System.Drawing.Size(39, 20)
        Me.txtFilial.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Filial"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(90, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "OS"
        '
        'txtOS
        '
        Me.txtOS.Location = New System.Drawing.Point(123, 9)
        Me.txtOS.Name = "txtOS"
        Me.txtOS.Size = New System.Drawing.Size(111, 20)
        Me.txtOS.TabIndex = 1
        '
        'grdAndamentos
        '
        Me.grdAndamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdAndamentos.ContextMenuStrip = Me.mnuAcoes
        Me.grdAndamentos.Location = New System.Drawing.Point(12, 35)
        Me.grdAndamentos.Name = "grdAndamentos"
        Me.grdAndamentos.Size = New System.Drawing.Size(1054, 331)
        Me.grdAndamentos.TabIndex = 4
        '
        'mnuAcoes
        '
        Me.mnuAcoes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeletarAndamentoToolStripMenuItem})
        Me.mnuAcoes.Name = "mnuAcoes"
        Me.mnuAcoes.Size = New System.Drawing.Size(178, 26)
        '
        'DeletarAndamentoToolStripMenuItem
        '
        Me.DeletarAndamentoToolStripMenuItem.Name = "DeletarAndamentoToolStripMenuItem"
        Me.DeletarAndamentoToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.DeletarAndamentoToolStripMenuItem.Text = "Deletar Andamento"
        '
        'cbStatus
        '
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Location = New System.Drawing.Point(453, 12)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(232, 21)
        Me.cbStatus.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(390, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Status OS"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(240, 7)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(704, 9)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(75, 23)
        Me.btnSalvar.TabIndex = 4
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'frmAndamentosUtil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1089, 378)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbStatus)
        Me.Controls.Add(Me.grdAndamentos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtOS)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFilial)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAndamentosUtil"
        Me.Text = "frmAndamentosUtil"
        CType(Me.grdAndamentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuAcoes.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFilial As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtOS As System.Windows.Forms.TextBox
    Friend WithEvents grdAndamentos As System.Windows.Forms.DataGridView
    Friend WithEvents cbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents mnuAcoes As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeletarAndamentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
