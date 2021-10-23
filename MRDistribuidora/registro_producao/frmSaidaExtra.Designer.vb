<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaidaExtra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSaidaExtra))
        Me.chkOD = New System.Windows.Forms.CheckBox()
        Me.chkOE = New System.Windows.Forms.CheckBox()
        Me.grpSaidaExtra = New System.Windows.Forms.GroupBox()
        Me.chkTrocaOE = New System.Windows.Forms.CheckBox()
        Me.chkTrocaOD = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMotivo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbAndamentos = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnSalvar = New System.Windows.Forms.ToolStripButton()
        Me.grpSaidaExtra.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkOD
        '
        Me.chkOD.AutoSize = True
        Me.chkOD.Location = New System.Drawing.Point(19, 20)
        Me.chkOD.Name = "chkOD"
        Me.chkOD.Size = New System.Drawing.Size(81, 17)
        Me.chkOD.TabIndex = 0
        Me.chkOD.Text = "Olho Direito"
        Me.chkOD.UseVisualStyleBackColor = True
        '
        'chkOE
        '
        Me.chkOE.AutoSize = True
        Me.chkOE.Location = New System.Drawing.Point(19, 37)
        Me.chkOE.Name = "chkOE"
        Me.chkOE.Size = New System.Drawing.Size(96, 17)
        Me.chkOE.TabIndex = 1
        Me.chkOE.Text = "Olho Esquerdo"
        Me.chkOE.UseVisualStyleBackColor = True
        '
        'grpSaidaExtra
        '
        Me.grpSaidaExtra.Controls.Add(Me.chkTrocaOE)
        Me.grpSaidaExtra.Controls.Add(Me.chkTrocaOD)
        Me.grpSaidaExtra.Controls.Add(Me.Label2)
        Me.grpSaidaExtra.Controls.Add(Me.txtMotivo)
        Me.grpSaidaExtra.Controls.Add(Me.Label1)
        Me.grpSaidaExtra.Controls.Add(Me.cbAndamentos)
        Me.grpSaidaExtra.Controls.Add(Me.chkOE)
        Me.grpSaidaExtra.Controls.Add(Me.chkOD)
        Me.grpSaidaExtra.Location = New System.Drawing.Point(12, 49)
        Me.grpSaidaExtra.Name = "grpSaidaExtra"
        Me.grpSaidaExtra.Size = New System.Drawing.Size(556, 167)
        Me.grpSaidaExtra.TabIndex = 2
        Me.grpSaidaExtra.TabStop = False
        Me.grpSaidaExtra.Text = "Solicitação de Saída extra"
        '
        'chkTrocaOE
        '
        Me.chkTrocaOE.AutoSize = True
        Me.chkTrocaOE.Location = New System.Drawing.Point(335, 121)
        Me.chkTrocaOE.Name = "chkTrocaOE"
        Me.chkTrocaOE.Size = New System.Drawing.Size(181, 17)
        Me.chkTrocaOE.TabIndex = 5
        Me.chkTrocaOE.Text = "Troca produto do Olho Esquerdo"
        Me.chkTrocaOE.UseVisualStyleBackColor = True
        '
        'chkTrocaOD
        '
        Me.chkTrocaOD.AutoSize = True
        Me.chkTrocaOD.Location = New System.Drawing.Point(335, 98)
        Me.chkTrocaOD.Name = "chkTrocaOD"
        Me.chkTrocaOD.Size = New System.Drawing.Size(166, 17)
        Me.chkTrocaOD.TabIndex = 4
        Me.chkTrocaOD.Text = "Troca produto do Olho Direito"
        Me.chkTrocaOD.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Motivo da solicitação de Saída extra"
        '
        'txtMotivo
        '
        Me.txtMotivo.Location = New System.Drawing.Point(6, 86)
        Me.txtMotivo.Multiline = True
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.Size = New System.Drawing.Size(314, 63)
        Me.txtMotivo.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(209, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Fase / Usuário onde ocorreu o problema"
        '
        'cbAndamentos
        '
        Me.cbAndamentos.FormattingEnabled = True
        Me.cbAndamentos.Location = New System.Drawing.Point(209, 33)
        Me.cbAndamentos.Name = "cbAndamentos"
        Me.cbAndamentos.Size = New System.Drawing.Size(341, 21)
        Me.cbAndamentos.TabIndex = 2
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSalvar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(580, 39)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnSalvar
        '
        Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
        Me.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(74, 36)
        Me.btnSalvar.Text = "Salvar"
        '
        'frmSaidaExtra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 230)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.grpSaidaExtra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSaidaExtra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Saida Extra"
        Me.grpSaidaExtra.ResumeLayout(False)
        Me.grpSaidaExtra.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkOD As System.Windows.Forms.CheckBox
    Friend WithEvents chkOE As System.Windows.Forms.CheckBox
    Friend WithEvents grpSaidaExtra As System.Windows.Forms.GroupBox
    Friend WithEvents cbAndamentos As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMotivo As System.Windows.Forms.TextBox
    Friend WithEvents chkTrocaOD As System.Windows.Forms.CheckBox
    Friend WithEvents chkTrocaOE As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnSalvar As System.Windows.Forms.ToolStripButton
End Class
