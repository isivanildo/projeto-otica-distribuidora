<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFaturamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFaturamento))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cbPromotor = New System.Windows.Forms.ComboBox()
        Me.cbCidade = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbPromotorTrans = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtFim = New System.Windows.Forms.DateTimePicker()
        Me.dtIni = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbFamilia = New System.Windows.Forms.CheckBox()
        Me.cbPromotorFamilia = New System.Windows.Forms.CheckBox()
        Me.btnPromotorGeral = New System.Windows.Forms.Button()
        Me.chkCrizal = New System.Windows.Forms.RadioButton()
        Me.chkAcclimate = New System.Windows.Forms.RadioButton()
        Me.chkTransitions = New System.Windows.Forms.RadioButton()
        Me.btnPromotor = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.pb = New System.Windows.Forms.ToolStripProgressBar()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnProdutosSemFilial = New System.Windows.Forms.Button()
        Me.btnProdutos = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnVendedora = New System.Windows.Forms.Button()
        Me.btnProdCliente = New System.Windows.Forms.Button()
        Me.btnProdOtica = New System.Windows.Forms.Button()
        Me.btnDescontos = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rbUf = New System.Windows.Forms.RadioButton()
        Me.rbCidade = New System.Windows.Forms.RadioButton()
        Me.btnClienteCidade = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnClientePromo = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnCrizal = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(444, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 44)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Por Clientes"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 18)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(52, 13)
        Me.Label20.TabIndex = 109
        Me.Label20.Text = "Promotor:"
        '
        'cbPromotor
        '
        Me.cbPromotor.FormattingEnabled = True
        Me.cbPromotor.Location = New System.Drawing.Point(6, 34)
        Me.cbPromotor.Name = "cbPromotor"
        Me.cbPromotor.Size = New System.Drawing.Size(249, 21)
        Me.cbPromotor.TabIndex = 0
        '
        'cbCidade
        '
        Me.cbCidade.Enabled = False
        Me.cbCidade.FormattingEnabled = True
        Me.cbCidade.Location = New System.Drawing.Point(6, 58)
        Me.cbCidade.Name = "cbCidade"
        Me.cbCidade.Size = New System.Drawing.Size(270, 21)
        Me.cbCidade.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "Cidade"
        '
        'cbPromotorTrans
        '
        Me.cbPromotorTrans.Enabled = False
        Me.cbPromotorTrans.FormattingEnabled = True
        Me.cbPromotorTrans.Location = New System.Drawing.Point(8, 41)
        Me.cbPromotorTrans.Name = "cbPromotorTrans"
        Me.cbPromotorTrans.Size = New System.Drawing.Size(200, 21)
        Me.cbPromotorTrans.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtFim)
        Me.GroupBox1.Controls.Add(Me.dtIni)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(262, 42)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Período"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(132, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Até:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "De:"
        '
        'dtFim
        '
        Me.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFim.Location = New System.Drawing.Point(162, 16)
        Me.dtFim.Name = "dtFim"
        Me.dtFim.Size = New System.Drawing.Size(90, 20)
        Me.dtFim.TabIndex = 1
        '
        'dtIni
        '
        Me.dtIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtIni.Location = New System.Drawing.Point(35, 16)
        Me.dtIni.Name = "dtIni"
        Me.dtIni.Size = New System.Drawing.Size(90, 20)
        Me.dtIni.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbFamilia)
        Me.GroupBox2.Controls.Add(Me.cbPromotorFamilia)
        Me.GroupBox2.Controls.Add(Me.btnPromotorGeral)
        Me.GroupBox2.Controls.Add(Me.chkCrizal)
        Me.GroupBox2.Controls.Add(Me.chkAcclimate)
        Me.GroupBox2.Controls.Add(Me.chkTransitions)
        Me.GroupBox2.Controls.Add(Me.btnPromotor)
        Me.GroupBox2.Controls.Add(Me.cbPromotorTrans)
        Me.GroupBox2.Location = New System.Drawing.Point(412, 213)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(395, 98)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Faturamento por"
        '
        'cbFamilia
        '
        Me.cbFamilia.AutoSize = True
        Me.cbFamilia.Location = New System.Drawing.Point(121, 18)
        Me.cbFamilia.Name = "cbFamilia"
        Me.cbFamilia.Size = New System.Drawing.Size(88, 17)
        Me.cbFamilia.TabIndex = 1
        Me.cbFamilia.Text = "Familia Lente"
        Me.cbFamilia.UseVisualStyleBackColor = True
        '
        'cbPromotorFamilia
        '
        Me.cbPromotorFamilia.AutoSize = True
        Me.cbPromotorFamilia.Location = New System.Drawing.Point(12, 18)
        Me.cbPromotorFamilia.Name = "cbPromotorFamilia"
        Me.cbPromotorFamilia.Size = New System.Drawing.Size(105, 17)
        Me.cbPromotorFamilia.TabIndex = 0
        Me.cbPromotorFamilia.Text = "Promotor/Familia"
        Me.cbPromotorFamilia.UseVisualStyleBackColor = True
        '
        'btnPromotorGeral
        '
        Me.btnPromotorGeral.Enabled = False
        Me.btnPromotorGeral.Image = CType(resources.GetObject("btnPromotorGeral.Image"), System.Drawing.Image)
        Me.btnPromotorGeral.Location = New System.Drawing.Point(302, 31)
        Me.btnPromotorGeral.Name = "btnPromotorGeral"
        Me.btnPromotorGeral.Size = New System.Drawing.Size(90, 40)
        Me.btnPromotorGeral.TabIndex = 7
        Me.btnPromotorGeral.Text = "Familia"
        Me.btnPromotorGeral.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPromotorGeral.UseVisualStyleBackColor = True
        '
        'chkCrizal
        '
        Me.chkCrizal.AutoSize = True
        Me.chkCrizal.Enabled = False
        Me.chkCrizal.Location = New System.Drawing.Point(162, 67)
        Me.chkCrizal.Name = "chkCrizal"
        Me.chkCrizal.Size = New System.Drawing.Size(50, 17)
        Me.chkCrizal.TabIndex = 5
        Me.chkCrizal.TabStop = True
        Me.chkCrizal.Text = "Crizal"
        Me.chkCrizal.UseVisualStyleBackColor = True
        '
        'chkAcclimate
        '
        Me.chkAcclimate.AutoSize = True
        Me.chkAcclimate.Enabled = False
        Me.chkAcclimate.Location = New System.Drawing.Point(91, 67)
        Me.chkAcclimate.Name = "chkAcclimate"
        Me.chkAcclimate.Size = New System.Drawing.Size(71, 17)
        Me.chkAcclimate.TabIndex = 4
        Me.chkAcclimate.TabStop = True
        Me.chkAcclimate.Text = "Acclimate"
        Me.chkAcclimate.UseVisualStyleBackColor = True
        '
        'chkTransitions
        '
        Me.chkTransitions.AutoSize = True
        Me.chkTransitions.Enabled = False
        Me.chkTransitions.Location = New System.Drawing.Point(12, 67)
        Me.chkTransitions.Name = "chkTransitions"
        Me.chkTransitions.Size = New System.Drawing.Size(76, 17)
        Me.chkTransitions.TabIndex = 3
        Me.chkTransitions.TabStop = True
        Me.chkTransitions.Text = "Transitions"
        Me.chkTransitions.UseVisualStyleBackColor = True
        '
        'btnPromotor
        '
        Me.btnPromotor.Enabled = False
        Me.btnPromotor.Image = CType(resources.GetObject("btnPromotor.Image"), System.Drawing.Image)
        Me.btnPromotor.Location = New System.Drawing.Point(212, 31)
        Me.btnPromotor.Name = "btnPromotor"
        Me.btnPromotor.Size = New System.Drawing.Size(90, 40)
        Me.btnPromotor.TabIndex = 6
        Me.btnPromotor.Text = "Promotor"
        Me.btnPromotor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPromotor.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pb})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 322)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(824, 36)
        Me.StatusStrip1.TabIndex = 122
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'pb
        '
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(280, 30)
        '
        'cbEstado
        '
        Me.cbEstado.Enabled = False
        Me.cbEstado.FormattingEnabled = True
        Me.cbEstado.Location = New System.Drawing.Point(6, 97)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(270, 21)
        Me.cbEstado.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 117
        Me.Label4.Text = "Estado"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnProdutosSemFilial)
        Me.GroupBox3.Controls.Add(Me.btnProdutos)
        Me.GroupBox3.Controls.Add(Me.btnClientes)
        Me.GroupBox3.Controls.Add(Me.btnVendedora)
        Me.GroupBox3.Controls.Add(Me.btnProdCliente)
        Me.GroupBox3.Controls.Add(Me.btnProdOtica)
        Me.GroupBox3.Controls.Add(Me.btnDescontos)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 69)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(398, 160)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Faturamento por"
        '
        'btnProdutosSemFilial
        '
        Me.btnProdutosSemFilial.Image = CType(resources.GetObject("btnProdutosSemFilial.Image"), System.Drawing.Image)
        Me.btnProdutosSemFilial.Location = New System.Drawing.Point(135, 20)
        Me.btnProdutosSemFilial.Name = "btnProdutosSemFilial"
        Me.btnProdutosSemFilial.Size = New System.Drawing.Size(125, 44)
        Me.btnProdutosSemFilial.TabIndex = 1
        Me.btnProdutosSemFilial.Text = "Produto Sem Filial"
        Me.btnProdutosSemFilial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProdutosSemFilial.UseVisualStyleBackColor = True
        '
        'btnProdutos
        '
        Me.btnProdutos.Image = CType(resources.GetObject("btnProdutos.Image"), System.Drawing.Image)
        Me.btnProdutos.Location = New System.Drawing.Point(6, 20)
        Me.btnProdutos.Name = "btnProdutos"
        Me.btnProdutos.Size = New System.Drawing.Size(125, 44)
        Me.btnProdutos.TabIndex = 0
        Me.btnProdutos.Text = "Produto"
        Me.btnProdutos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProdutos.UseVisualStyleBackColor = True
        '
        'btnClientes
        '
        Me.btnClientes.Image = CType(resources.GetObject("btnClientes.Image"), System.Drawing.Image)
        Me.btnClientes.Location = New System.Drawing.Point(265, 20)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(125, 44)
        Me.btnClientes.TabIndex = 2
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'btnVendedora
        '
        Me.btnVendedora.Image = CType(resources.GetObject("btnVendedora.Image"), System.Drawing.Image)
        Me.btnVendedora.Location = New System.Drawing.Point(6, 66)
        Me.btnVendedora.Name = "btnVendedora"
        Me.btnVendedora.Size = New System.Drawing.Size(125, 44)
        Me.btnVendedora.TabIndex = 3
        Me.btnVendedora.Text = "Vendedora"
        Me.btnVendedora.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVendedora.UseVisualStyleBackColor = True
        '
        'btnProdCliente
        '
        Me.btnProdCliente.Image = CType(resources.GetObject("btnProdCliente.Image"), System.Drawing.Image)
        Me.btnProdCliente.Location = New System.Drawing.Point(135, 66)
        Me.btnProdCliente.Name = "btnProdCliente"
        Me.btnProdCliente.Size = New System.Drawing.Size(125, 44)
        Me.btnProdCliente.TabIndex = 4
        Me.btnProdCliente.Text = "Produtos do Cliente"
        Me.btnProdCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProdCliente.UseVisualStyleBackColor = True
        '
        'btnProdOtica
        '
        Me.btnProdOtica.Image = CType(resources.GetObject("btnProdOtica.Image"), System.Drawing.Image)
        Me.btnProdOtica.Location = New System.Drawing.Point(6, 112)
        Me.btnProdOtica.Name = "btnProdOtica"
        Me.btnProdOtica.Size = New System.Drawing.Size(125, 44)
        Me.btnProdOtica.TabIndex = 6
        Me.btnProdOtica.Text = "Produto Ana Maria"
        Me.btnProdOtica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProdOtica.UseVisualStyleBackColor = True
        Me.btnProdOtica.Visible = False
        '
        'btnDescontos
        '
        Me.btnDescontos.Image = CType(resources.GetObject("btnDescontos.Image"), System.Drawing.Image)
        Me.btnDescontos.Location = New System.Drawing.Point(265, 66)
        Me.btnDescontos.Name = "btnDescontos"
        Me.btnDescontos.Size = New System.Drawing.Size(125, 44)
        Me.btnDescontos.TabIndex = 5
        Me.btnDescontos.Text = "Produtos com Desconto"
        Me.btnDescontos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDescontos.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rbUf)
        Me.GroupBox4.Controls.Add(Me.rbCidade)
        Me.GroupBox4.Controls.Add(Me.cbEstado)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.cbCidade)
        Me.GroupBox4.Controls.Add(Me.btnClienteCidade)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Location = New System.Drawing.Point(412, 69)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(398, 123)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Faturamento por Cidade/UF"
        '
        'rbUf
        '
        Me.rbUf.AutoSize = True
        Me.rbUf.Location = New System.Drawing.Point(81, 19)
        Me.rbUf.Name = "rbUf"
        Me.rbUf.Size = New System.Drawing.Size(58, 17)
        Me.rbUf.TabIndex = 1
        Me.rbUf.TabStop = True
        Me.rbUf.Text = "Estado"
        Me.rbUf.UseVisualStyleBackColor = True
        '
        'rbCidade
        '
        Me.rbCidade.AutoSize = True
        Me.rbCidade.Location = New System.Drawing.Point(9, 19)
        Me.rbCidade.Name = "rbCidade"
        Me.rbCidade.Size = New System.Drawing.Size(58, 17)
        Me.rbCidade.TabIndex = 0
        Me.rbCidade.TabStop = True
        Me.rbCidade.Text = "Cidade"
        Me.rbCidade.UseVisualStyleBackColor = True
        '
        'btnClienteCidade
        '
        Me.btnClienteCidade.Image = CType(resources.GetObject("btnClienteCidade.Image"), System.Drawing.Image)
        Me.btnClienteCidade.Location = New System.Drawing.Point(313, 78)
        Me.btnClienteCidade.Name = "btnClienteCidade"
        Me.btnClienteCidade.Size = New System.Drawing.Size(79, 40)
        Me.btnClienteCidade.TabIndex = 4
        Me.btnClienteCidade.Text = "Cliente"
        Me.btnClienteCidade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClienteCidade.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnClientePromo)
        Me.GroupBox5.Controls.Add(Me.cbPromotor)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 237)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(398, 74)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Faturmento por Promotor"
        '
        'btnClientePromo
        '
        Me.btnClientePromo.Image = CType(resources.GetObject("btnClientePromo.Image"), System.Drawing.Image)
        Me.btnClientePromo.Location = New System.Drawing.Point(266, 23)
        Me.btnClientePromo.Name = "btnClientePromo"
        Me.btnClientePromo.Size = New System.Drawing.Size(124, 44)
        Me.btnClientePromo.TabIndex = 1
        Me.btnClientePromo.Text = "Cliente"
        Me.btnClientePromo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClientePromo.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btnCrizal)
        Me.GroupBox6.Location = New System.Drawing.Point(594, 9)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(172, 59)
        Me.GroupBox6.TabIndex = 126
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Faturamento por"
        Me.GroupBox6.Visible = False
        '
        'btnCrizal
        '
        Me.btnCrizal.Image = CType(resources.GetObject("btnCrizal.Image"), System.Drawing.Image)
        Me.btnCrizal.Location = New System.Drawing.Point(6, 14)
        Me.btnCrizal.Name = "btnCrizal"
        Me.btnCrizal.Size = New System.Drawing.Size(125, 44)
        Me.btnCrizal.TabIndex = 115
        Me.btnCrizal.Text = "Lentes Crizal"
        Me.btnCrizal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCrizal.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(143, 51)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(70, 17)
        Me.CheckBox1.TabIndex = 127
        Me.CheckBox1.Text = "Sem Filial"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(290, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(126, 40)
        Me.Button2.TabIndex = 128
        Me.Button2.Text = "Produto/Serviços"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmFaturamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 358)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFaturamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Faturamento"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnProdutos As System.Windows.Forms.Button
    Friend WithEvents btnVendedora As System.Windows.Forms.Button
    Friend WithEvents btnClientes As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnDescontos As System.Windows.Forms.Button
    Friend WithEvents btnClientePromo As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cbPromotor As System.Windows.Forms.ComboBox
    Friend WithEvents btnProdCliente As System.Windows.Forms.Button
    Friend WithEvents btnProdOtica As System.Windows.Forms.Button
    Friend WithEvents cbCidade As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClienteCidade As System.Windows.Forms.Button
    Friend WithEvents cbPromotorTrans As System.Windows.Forms.ComboBox
    Friend WithEvents btnPromotor As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtFim As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents pb As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkCrizal As System.Windows.Forms.RadioButton
    Friend WithEvents chkAcclimate As System.Windows.Forms.RadioButton
    Friend WithEvents chkTransitions As System.Windows.Forms.RadioButton
    Friend WithEvents btnCrizal As System.Windows.Forms.Button
    Friend WithEvents btnPromotorGeral As System.Windows.Forms.Button
    Friend WithEvents cbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rbUf As System.Windows.Forms.RadioButton
    Friend WithEvents rbCidade As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents cbPromotorFamilia As System.Windows.Forms.CheckBox
    Friend WithEvents cbFamilia As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents btnProdutosSemFilial As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
