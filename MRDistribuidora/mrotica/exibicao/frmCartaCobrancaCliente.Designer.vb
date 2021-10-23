<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCartaCobrancaCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCartaCobrancaCliente))
        Me.gbTipo = New System.Windows.Forms.GroupBox()
        Me.rbCliente = New System.Windows.Forms.RadioButton()
        Me.rbGeral = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtPerc = New System.Windows.Forms.TextBox()
        Me.txtTaxaCart = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbModeloC = New System.Windows.Forms.RadioButton()
        Me.rbModeloB = New System.Windows.Forms.RadioButton()
        Me.rbModeloA = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.gbTipo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbTipo
        '
        Me.gbTipo.Controls.Add(Me.rbCliente)
        Me.gbTipo.Controls.Add(Me.rbGeral)
        Me.gbTipo.Location = New System.Drawing.Point(259, 8)
        Me.gbTipo.Name = "gbTipo"
        Me.gbTipo.Size = New System.Drawing.Size(155, 44)
        Me.gbTipo.TabIndex = 1
        Me.gbTipo.TabStop = False
        Me.gbTipo.Text = "Por"
        '
        'rbCliente
        '
        Me.rbCliente.AutoSize = True
        Me.rbCliente.Location = New System.Drawing.Point(75, 15)
        Me.rbCliente.Name = "rbCliente"
        Me.rbCliente.Size = New System.Drawing.Size(76, 17)
        Me.rbCliente.TabIndex = 1
        Me.rbCliente.TabStop = True
        Me.rbCliente.Text = "Por Cliente"
        Me.rbCliente.UseVisualStyleBackColor = True
        '
        'rbGeral
        '
        Me.rbGeral.AutoSize = True
        Me.rbGeral.Checked = True
        Me.rbGeral.Location = New System.Drawing.Point(15, 15)
        Me.rbGeral.Name = "rbGeral"
        Me.rbGeral.Size = New System.Drawing.Size(50, 17)
        Me.rbGeral.TabIndex = 0
        Me.rbGeral.TabStop = True
        Me.rbGeral.Text = "Geral"
        Me.rbGeral.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(178, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Código Cliente"
        Me.Label1.Visible = False
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(179, 81)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(71, 20)
        Me.txtCodigo.TabIndex = 4
        Me.txtCodigo.Visible = False
        '
        'txtPerc
        '
        Me.txtPerc.Location = New System.Drawing.Point(16, 81)
        Me.txtPerc.Name = "txtPerc"
        Me.txtPerc.Size = New System.Drawing.Size(66, 20)
        Me.txtPerc.TabIndex = 2
        Me.txtPerc.Text = "0,00"
        '
        'txtTaxaCart
        '
        Me.txtTaxaCart.Location = New System.Drawing.Point(91, 81)
        Me.txtTaxaCart.Name = "txtTaxaCart"
        Me.txtTaxaCart.Size = New System.Drawing.Size(81, 20)
        Me.txtTaxaCart.TabIndex = 3
        Me.txtTaxaCart.Text = "0,00"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbModeloC)
        Me.GroupBox1.Controls.Add(Me.rbModeloB)
        Me.GroupBox1.Controls.Add(Me.rbModeloA)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(241, 44)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo Relatório"
        '
        'rbModeloC
        '
        Me.rbModeloC.AutoSize = True
        Me.rbModeloC.Location = New System.Drawing.Point(166, 21)
        Me.rbModeloC.Name = "rbModeloC"
        Me.rbModeloC.Size = New System.Drawing.Size(70, 17)
        Me.rbModeloC.TabIndex = 3
        Me.rbModeloC.TabStop = True
        Me.rbModeloC.Text = "Modelo C"
        Me.rbModeloC.UseVisualStyleBackColor = True
        '
        'rbModeloB
        '
        Me.rbModeloB.AutoSize = True
        Me.rbModeloB.Location = New System.Drawing.Point(88, 21)
        Me.rbModeloB.Name = "rbModeloB"
        Me.rbModeloB.Size = New System.Drawing.Size(70, 17)
        Me.rbModeloB.TabIndex = 2
        Me.rbModeloB.TabStop = True
        Me.rbModeloB.Text = "Modelo B"
        Me.rbModeloB.UseVisualStyleBackColor = True
        '
        'rbModeloA
        '
        Me.rbModeloA.AutoSize = True
        Me.rbModeloA.Location = New System.Drawing.Point(12, 21)
        Me.rbModeloA.Name = "rbModeloA"
        Me.rbModeloA.Size = New System.Drawing.Size(70, 17)
        Me.rbModeloA.TabIndex = 1
        Me.rbModeloA.TabStop = True
        Me.rbModeloA.Text = "Modelo A"
        Me.rbModeloA.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Percentagem"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(88, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Taxa de Cartório"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(315, 127)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 28)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Exportar PDF"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.Location = New System.Drawing.Point(235, 127)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(77, 28)
        Me.btnSair.TabIndex = 6
        Me.btnSair.Text = "Sair"
        Me.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Image = CType(resources.GetObject("btnOK.Image"), System.Drawing.Image)
        Me.btnOK.Location = New System.Drawing.Point(155, 127)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(77, 28)
        Me.btnOK.TabIndex = 5
        Me.btnOK.Text = "OK"
        Me.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'frmCartaCobrancaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 166)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtTaxaCart)
        Me.Controls.Add(Me.txtPerc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.gbTipo)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCartaCobrancaCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Debito Cliente"
        Me.gbTipo.ResumeLayout(False)
        Me.gbTipo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents gbTipo As System.Windows.Forms.GroupBox
    Friend WithEvents rbCliente As System.Windows.Forms.RadioButton
    Friend WithEvents rbGeral As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtPerc As System.Windows.Forms.TextBox
    Friend WithEvents txtTaxaCart As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbModeloC As System.Windows.Forms.RadioButton
    Friend WithEvents rbModeloB As System.Windows.Forms.RadioButton
    Friend WithEvents rbModeloA As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
