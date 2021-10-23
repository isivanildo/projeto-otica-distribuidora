<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaRecebimentoPromotor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListaRecebimentoPromotor))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDataFim = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDataIni = New System.Windows.Forms.MaskedTextBox()
        Me.cbPromotor = New System.Windows.Forms.ComboBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbRecebido = New System.Windows.Forms.RadioButton()
        Me.rbReceber = New System.Windows.Forms.RadioButton()
        Me.cbTudo = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDataFim)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtDataIni)
        Me.GroupBox1.Controls.Add(Me.cbPromotor)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(245, 93)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista Promotor/Período"
        '
        'txtDataFim
        '
        Me.txtDataFim.Location = New System.Drawing.Point(157, 64)
        Me.txtDataFim.Mask = "00/00/0000"
        Me.txtDataFim.Name = "txtDataFim"
        Me.txtDataFim.Size = New System.Drawing.Size(78, 20)
        Me.txtDataFim.TabIndex = 2
        Me.txtDataFim.ValidatingType = GetType(Date)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(125, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Até:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "De:"
        '
        'txtDataIni
        '
        Me.txtDataIni.Location = New System.Drawing.Point(34, 64)
        Me.txtDataIni.Mask = "00/00/0000"
        Me.txtDataIni.Name = "txtDataIni"
        Me.txtDataIni.Size = New System.Drawing.Size(78, 20)
        Me.txtDataIni.TabIndex = 1
        Me.txtDataIni.ValidatingType = GetType(Date)
        '
        'cbPromotor
        '
        Me.cbPromotor.FormattingEnabled = True
        Me.cbPromotor.Location = New System.Drawing.Point(6, 23)
        Me.cbPromotor.Name = "cbPromotor"
        Me.cbPromotor.Size = New System.Drawing.Size(230, 21)
        Me.cbPromotor.TabIndex = 0
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(179, 167)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(83, 28)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Image = CType(resources.GetObject("btnOK.Image"), System.Drawing.Image)
        Me.btnOK.Location = New System.Drawing.Point(93, 167)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(83, 28)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        Me.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbRecebido)
        Me.GroupBox2.Controls.Add(Me.rbReceber)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(245, 43)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo"
        '
        'rbRecebido
        '
        Me.rbRecebido.AutoSize = True
        Me.rbRecebido.Checked = True
        Me.rbRecebido.Location = New System.Drawing.Point(13, 19)
        Me.rbRecebido.Name = "rbRecebido"
        Me.rbRecebido.Size = New System.Drawing.Size(71, 17)
        Me.rbRecebido.TabIndex = 0
        Me.rbRecebido.TabStop = True
        Me.rbRecebido.Text = "Recebido"
        Me.rbRecebido.UseVisualStyleBackColor = True
        '
        'rbReceber
        '
        Me.rbReceber.AutoSize = True
        Me.rbReceber.Location = New System.Drawing.Point(132, 19)
        Me.rbReceber.Name = "rbReceber"
        Me.rbReceber.Size = New System.Drawing.Size(76, 17)
        Me.rbReceber.TabIndex = 1
        Me.rbReceber.Text = "A Receber"
        Me.rbReceber.UseVisualStyleBackColor = True
        '
        'cbTudo
        '
        Me.cbTudo.AutoSize = True
        Me.cbTudo.Location = New System.Drawing.Point(284, 21)
        Me.cbTudo.Name = "cbTudo"
        Me.cbTudo.Size = New System.Drawing.Size(51, 17)
        Me.cbTudo.TabIndex = 4
        Me.cbTudo.Text = "Geral"
        Me.cbTudo.UseVisualStyleBackColor = True
        '
        'frmListaRecebimentoPromotor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 205)
        Me.Controls.Add(Me.cbTudo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmListaRecebimentoPromotor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Clientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbPromotor As System.Windows.Forms.ComboBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents txtDataIni As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtDataFim As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbRecebido As System.Windows.Forms.RadioButton
    Friend WithEvents rbReceber As System.Windows.Forms.RadioButton
    Friend WithEvents cbTudo As System.Windows.Forms.CheckBox
End Class
