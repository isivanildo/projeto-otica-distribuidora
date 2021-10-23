<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFaturaCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFaturaCliente))
        Me.pnFechaCaixa = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtSenhaGerente2 = New System.Windows.Forms.TextBox()
        Me.txtCodGerente2 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtOutro = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtBoleto = New System.Windows.Forms.TextBox()
        Me.txtCheque = New System.Windows.Forms.TextBox()
        Me.txtCartaoDebito = New System.Windows.Forms.TextBox()
        Me.txtCartaoCredito = New System.Windows.Forms.TextBox()
        Me.txtDinheiro = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.grdPedido = New System.Windows.Forms.DataGridView()
        Me.gbDados = New System.Windows.Forms.GroupBox()
        Me.rgNome = New System.Windows.Forms.RadioButton()
        Me.txtCodigo = New System.Windows.Forms.MaskedTextBox()
        Me.rgCodigo = New System.Windows.Forms.RadioButton()
        Me.btnLocalizar = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.cbTudo = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtFim = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtIni = New System.Windows.Forms.DateTimePicker()
        Me.txtPedido = New System.Windows.Forms.TextBox()
        Me.gbPedido = New System.Windows.Forms.GroupBox()
        Me.lblTotalItens = New System.Windows.Forms.Label()
        Me.lblTotalGeral = New System.Windows.Forms.Label()
        Me.btnFaturar = New System.Windows.Forms.Button()
        Me.pnFechaCaixa.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDados.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbPedido.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnFechaCaixa
        '
        Me.pnFechaCaixa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnFechaCaixa.Controls.Add(Me.GroupBox1)
        Me.pnFechaCaixa.Controls.Add(Me.txtOutro)
        Me.pnFechaCaixa.Controls.Add(Me.Label13)
        Me.pnFechaCaixa.Controls.Add(Me.Button5)
        Me.pnFechaCaixa.Controls.Add(Me.Button4)
        Me.pnFechaCaixa.Controls.Add(Me.txtBoleto)
        Me.pnFechaCaixa.Controls.Add(Me.txtCheque)
        Me.pnFechaCaixa.Controls.Add(Me.txtCartaoDebito)
        Me.pnFechaCaixa.Controls.Add(Me.txtCartaoCredito)
        Me.pnFechaCaixa.Controls.Add(Me.txtDinheiro)
        Me.pnFechaCaixa.Controls.Add(Me.Label12)
        Me.pnFechaCaixa.Controls.Add(Me.Label11)
        Me.pnFechaCaixa.Controls.Add(Me.Label10)
        Me.pnFechaCaixa.Controls.Add(Me.Label9)
        Me.pnFechaCaixa.Controls.Add(Me.Label8)
        Me.pnFechaCaixa.Controls.Add(Me.Label7)
        Me.pnFechaCaixa.Location = New System.Drawing.Point(444, 255)
        Me.pnFechaCaixa.Name = "pnFechaCaixa"
        Me.pnFechaCaixa.Size = New System.Drawing.Size(454, 241)
        Me.pnFechaCaixa.TabIndex = 26
        Me.pnFechaCaixa.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtSenhaGerente2)
        Me.GroupBox1.Controls.Add(Me.txtCodGerente2)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 149)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(215, 68)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gerência"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(119, 25)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(47, 13)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "Senha:"
        '
        'txtSenhaGerente2
        '
        Me.txtSenhaGerente2.Location = New System.Drawing.Point(122, 41)
        Me.txtSenhaGerente2.Name = "txtSenhaGerente2"
        Me.txtSenhaGerente2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenhaGerente2.Size = New System.Drawing.Size(86, 20)
        Me.txtSenhaGerente2.TabIndex = 1
        '
        'txtCodGerente2
        '
        Me.txtCodGerente2.Location = New System.Drawing.Point(15, 41)
        Me.txtCodGerente2.Name = "txtCodGerente2"
        Me.txtCodGerente2.Size = New System.Drawing.Size(96, 20)
        Me.txtCodGerente2.TabIndex = 0
        Me.txtCodGerente2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 25)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(86, 13)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "Cód. Gerente:"
        '
        'txtOutro
        '
        Me.txtOutro.Location = New System.Drawing.Point(318, 116)
        Me.txtOutro.Name = "txtOutro"
        Me.txtOutro.Size = New System.Drawing.Size(112, 20)
        Me.txtOutro.TabIndex = 11
        Me.txtOutro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(202, 116)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 13)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Outros:"
        '
        'Button5
        '
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(326, 174)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(77, 32)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "Cancelar"
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(249, 174)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 32)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "OK"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txtBoleto
        '
        Me.txtBoleto.Location = New System.Drawing.Point(71, 116)
        Me.txtBoleto.Name = "txtBoleto"
        Me.txtBoleto.Size = New System.Drawing.Size(112, 20)
        Me.txtBoleto.TabIndex = 10
        Me.txtBoleto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCheque
        '
        Me.txtCheque.Location = New System.Drawing.Point(71, 84)
        Me.txtCheque.Name = "txtCheque"
        Me.txtCheque.Size = New System.Drawing.Size(112, 20)
        Me.txtCheque.TabIndex = 8
        Me.txtCheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCartaoDebito
        '
        Me.txtCartaoDebito.Location = New System.Drawing.Point(318, 84)
        Me.txtCartaoDebito.Name = "txtCartaoDebito"
        Me.txtCartaoDebito.Size = New System.Drawing.Size(112, 20)
        Me.txtCartaoDebito.TabIndex = 9
        Me.txtCartaoDebito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCartaoCredito
        '
        Me.txtCartaoCredito.Location = New System.Drawing.Point(319, 53)
        Me.txtCartaoCredito.Name = "txtCartaoCredito"
        Me.txtCartaoCredito.Size = New System.Drawing.Size(112, 20)
        Me.txtCartaoCredito.TabIndex = 7
        Me.txtCartaoCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDinheiro
        '
        Me.txtDinheiro.Location = New System.Drawing.Point(71, 53)
        Me.txtDinheiro.Name = "txtDinheiro"
        Me.txtDinheiro.Size = New System.Drawing.Size(112, 20)
        Me.txtDinheiro.TabIndex = 6
        Me.txtDinheiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 116)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 13)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Boletos:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 84)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Cheques:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(202, 84)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Cartão de Débito:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(205, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Cartão de Crédito:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Dinheiro:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(147, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(158, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Fechamento de Caixa"
        '
        'grdPedido
        '
        Me.grdPedido.AllowUserToAddRows = False
        Me.grdPedido.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.grdPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdPedido.Location = New System.Drawing.Point(20, 90)
        Me.grdPedido.Name = "grdPedido"
        Me.grdPedido.RowHeadersVisible = False
        Me.grdPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdPedido.Size = New System.Drawing.Size(1171, 424)
        Me.grdPedido.TabIndex = 3
        '
        'gbDados
        '
        Me.gbDados.Controls.Add(Me.rgNome)
        Me.gbDados.Controls.Add(Me.txtCodigo)
        Me.gbDados.Controls.Add(Me.rgCodigo)
        Me.gbDados.Controls.Add(Me.btnLocalizar)
        Me.gbDados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDados.Location = New System.Drawing.Point(20, 38)
        Me.gbDados.Name = "gbDados"
        Me.gbDados.Size = New System.Drawing.Size(330, 47)
        Me.gbDados.TabIndex = 0
        Me.gbDados.TabStop = False
        Me.gbDados.Text = "Pesquisar por"
        '
        'rgNome
        '
        Me.rgNome.AutoSize = True
        Me.rgNome.Location = New System.Drawing.Point(86, 20)
        Me.rgNome.Name = "rgNome"
        Me.rgNome.Size = New System.Drawing.Size(57, 17)
        Me.rgNome.TabIndex = 1
        Me.rgNome.Text = "Nome"
        Me.rgNome.UseVisualStyleBackColor = True
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(151, 18)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(80, 20)
        Me.txtCodigo.TabIndex = 2
        Me.txtCodigo.ValidatingType = GetType(Date)
        '
        'rgCodigo
        '
        Me.rgCodigo.AutoSize = True
        Me.rgCodigo.Checked = True
        Me.rgCodigo.Location = New System.Drawing.Point(16, 20)
        Me.rgCodigo.Name = "rgCodigo"
        Me.rgCodigo.Size = New System.Drawing.Size(64, 17)
        Me.rgCodigo.TabIndex = 0
        Me.rgCodigo.TabStop = True
        Me.rgCodigo.Text = "Código"
        Me.rgCodigo.UseVisualStyleBackColor = True
        '
        'btnLocalizar
        '
        Me.btnLocalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLocalizar.Image = CType(resources.GetObject("btnLocalizar.Image"), System.Drawing.Image)
        Me.btnLocalizar.Location = New System.Drawing.Point(237, 10)
        Me.btnLocalizar.Name = "btnLocalizar"
        Me.btnLocalizar.Size = New System.Drawing.Size(85, 32)
        Me.btnLocalizar.TabIndex = 3
        Me.btnLocalizar.Text = "Localizar"
        Me.btnLocalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLocalizar.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.ToolStripButton1, Me.ToolStripSeparator3, Me.ToolStripButton2, Me.ToolStripSeparator2, Me.ToolStripButton3, Me.ToolStripSeparator4, Me.ToolStripButton4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1204, 39)
        Me.ToolStrip1.TabIndex = 36
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(105, 36)
        Me.ToolStripButton1.Text = "Abrir Fatura"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(138, 36)
        Me.ToolStripButton2.Text = "Imprimir a Faturar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(85, 36)
        Me.ToolStripButton3.Text = "Clientes"
        Me.ToolStripButton3.ToolTipText = "Cliente"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(78, 36)
        Me.ToolStripButton4.Text = "Fechar"
        '
        'cbTudo
        '
        Me.cbTudo.AutoSize = True
        Me.cbTudo.Location = New System.Drawing.Point(1098, 58)
        Me.cbTudo.Name = "cbTudo"
        Me.cbTudo.Size = New System.Drawing.Size(83, 17)
        Me.cbTudo.TabIndex = 5
        Me.cbTudo.Text = "Por Período"
        Me.cbTudo.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtFim)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.dtIni)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(356, 38)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(251, 47)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Período"
        '
        'dtFim
        '
        Me.dtFim.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFim.Location = New System.Drawing.Point(157, 19)
        Me.dtFim.Name = "dtFim"
        Me.dtFim.Size = New System.Drawing.Size(84, 20)
        Me.dtFim.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(127, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Até:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "De:"
        '
        'dtIni
        '
        Me.dtIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtIni.Location = New System.Drawing.Point(34, 19)
        Me.dtIni.Name = "dtIni"
        Me.dtIni.Size = New System.Drawing.Size(84, 20)
        Me.dtIni.TabIndex = 0
        '
        'txtPedido
        '
        Me.txtPedido.Location = New System.Drawing.Point(6, 18)
        Me.txtPedido.Name = "txtPedido"
        Me.txtPedido.Size = New System.Drawing.Size(115, 20)
        Me.txtPedido.TabIndex = 0
        '
        'gbPedido
        '
        Me.gbPedido.Controls.Add(Me.txtPedido)
        Me.gbPedido.Enabled = False
        Me.gbPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPedido.Location = New System.Drawing.Point(624, 38)
        Me.gbPedido.Name = "gbPedido"
        Me.gbPedido.Size = New System.Drawing.Size(128, 47)
        Me.gbPedido.TabIndex = 2
        Me.gbPedido.TabStop = False
        Me.gbPedido.Text = "Pesquisar Pedido"
        '
        'lblTotalItens
        '
        Me.lblTotalItens.AutoSize = True
        Me.lblTotalItens.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalItens.Location = New System.Drawing.Point(20, 529)
        Me.lblTotalItens.Name = "lblTotalItens"
        Me.lblTotalItens.Size = New System.Drawing.Size(72, 13)
        Me.lblTotalItens.TabIndex = 37
        Me.lblTotalItens.Text = "Total Itens:"
        Me.lblTotalItens.Visible = False
        '
        'lblTotalGeral
        '
        Me.lblTotalGeral.AutoSize = True
        Me.lblTotalGeral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalGeral.Location = New System.Drawing.Point(20, 551)
        Me.lblTotalGeral.Name = "lblTotalGeral"
        Me.lblTotalGeral.Size = New System.Drawing.Size(40, 13)
        Me.lblTotalGeral.TabIndex = 38
        Me.lblTotalGeral.Text = "Total:"
        Me.lblTotalGeral.Visible = False
        '
        'btnFaturar
        '
        Me.btnFaturar.Image = CType(resources.GetObject("btnFaturar.Image"), System.Drawing.Image)
        Me.btnFaturar.Location = New System.Drawing.Point(1094, 528)
        Me.btnFaturar.Name = "btnFaturar"
        Me.btnFaturar.Size = New System.Drawing.Size(99, 32)
        Me.btnFaturar.TabIndex = 4
        Me.btnFaturar.Text = "Faturar"
        Me.btnFaturar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFaturar.UseVisualStyleBackColor = True
        '
        'frmFaturaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1204, 578)
        Me.Controls.Add(Me.lblTotalGeral)
        Me.Controls.Add(Me.lblTotalItens)
        Me.Controls.Add(Me.gbPedido)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cbTudo)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btnFaturar)
        Me.Controls.Add(Me.gbDados)
        Me.Controls.Add(Me.grdPedido)
        Me.Controls.Add(Me.pnFechaCaixa)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFaturaCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Faturamento de Clientes"
        Me.pnFechaCaixa.ResumeLayout(False)
        Me.pnFechaCaixa.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdPedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDados.ResumeLayout(False)
        Me.gbDados.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gbPedido.ResumeLayout(False)
        Me.gbPedido.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnFechaCaixa As System.Windows.Forms.Panel
    Friend WithEvents txtBoleto As System.Windows.Forms.TextBox
    Friend WithEvents txtCheque As System.Windows.Forms.TextBox
    Friend WithEvents txtCartaoDebito As System.Windows.Forms.TextBox
    Friend WithEvents txtCartaoCredito As System.Windows.Forms.TextBox
    Friend WithEvents txtDinheiro As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents txtOutro As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtSenhaGerente2 As System.Windows.Forms.TextBox
    Friend WithEvents txtCodGerente2 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents grdPedido As System.Windows.Forms.DataGridView
    Friend WithEvents gbDados As System.Windows.Forms.GroupBox
    Friend WithEvents rgNome As System.Windows.Forms.RadioButton
    Friend WithEvents txtCodigo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnLocalizar As System.Windows.Forms.Button
    Friend WithEvents btnFaturar As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents rgCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents cbTudo As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtFim As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtPedido As System.Windows.Forms.TextBox
    Friend WithEvents gbPedido As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblTotalItens As System.Windows.Forms.Label
    Friend WithEvents lblTotalGeral As System.Windows.Forms.Label
End Class
