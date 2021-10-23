<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCaixa
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCaixa))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnAbrirCaixa = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAbrirFatura = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAbrePedido = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCliente = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnEstorno = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnDespesa = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnOutrasDespesas = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnRelatorios = New System.Windows.Forms.ToolStripDropDownButton()
        Me.btnRelDespesas = New System.Windows.Forms.ToolStripMenuItem()
        Me.DespesasAcumuladasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnRelRecFat = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnVendasDia = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelCaixa = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendasDiaSintéticoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperaçõesDeCréditoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnFecharCaixa = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblDataCaixa = New System.Windows.Forms.Label()
        Me.pnCaixa = New System.Windows.Forms.Panel()
        Me.txtCodGerente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtDataAbertura = New System.Windows.Forms.MaskedTextBox()
        Me.txtSenhaGerente = New System.Windows.Forms.TextBox()
        Me.txtSaldoInicial = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDataAbertura = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
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
        Me.grdCaixa = New System.Windows.Forms.DataGridView()
        Me.gbDados = New System.Windows.Forms.GroupBox()
        Me.rgNome = New System.Windows.Forms.RadioButton()
        Me.txtDataIni = New System.Windows.Forms.MaskedTextBox()
        Me.rgCodigo = New System.Windows.Forms.RadioButton()
        Me.rgPedido = New System.Windows.Forms.RadioButton()
        Me.btnLocalizar = New System.Windows.Forms.Button()
        Me.lblFim = New System.Windows.Forms.Label()
        Me.lblInicio = New System.Windows.Forms.Label()
        Me.lblTotalGeral = New System.Windows.Forms.Label()
        Me.lblTotalItens = New System.Windows.Forms.Label()
        Me.btnAtualiza = New System.Windows.Forms.Button()
        Me.btnGerarFatura = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.pnCaixa.SuspendLayout()
        Me.pnFechaCaixa.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdCaixa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDados.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAbrirCaixa, Me.ToolStripSeparator1, Me.btnAbrirFatura, Me.ToolStripSeparator3, Me.btnAbrePedido, Me.ToolStripSeparator10, Me.btnCliente, Me.ToolStripSeparator6, Me.btnEstorno, Me.ToolStripSeparator8, Me.btnDespesa, Me.ToolStripSeparator4, Me.btnOutrasDespesas, Me.ToolStripSeparator5, Me.btnRelatorios, Me.ToolStripSeparator9, Me.ToolStripSeparator7, Me.btnFecharCaixa, Me.ToolStripSeparator2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1284, 39)
        Me.ToolStrip1.TabIndex = 20
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnAbrirCaixa
        '
        Me.btnAbrirCaixa.Image = CType(resources.GetObject("btnAbrirCaixa.Image"), System.Drawing.Image)
        Me.btnAbrirCaixa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAbrirCaixa.Name = "btnAbrirCaixa"
        Me.btnAbrirCaixa.Size = New System.Drawing.Size(101, 36)
        Me.btnAbrirCaixa.Text = "Abrir Caixa"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'btnAbrirFatura
        '
        Me.btnAbrirFatura.Image = CType(resources.GetObject("btnAbrirFatura.Image"), System.Drawing.Image)
        Me.btnAbrirFatura.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAbrirFatura.Name = "btnAbrirFatura"
        Me.btnAbrirFatura.Size = New System.Drawing.Size(105, 36)
        Me.btnAbrirFatura.Text = "Abrir Fatura"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'btnAbrePedido
        '
        Me.btnAbrePedido.Image = CType(resources.GetObject("btnAbrePedido.Image"), System.Drawing.Image)
        Me.btnAbrePedido.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAbrePedido.Name = "btnAbrePedido"
        Me.btnAbrePedido.Size = New System.Drawing.Size(108, 36)
        Me.btnAbrePedido.Text = "Abre Pedido"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 39)
        '
        'btnCliente
        '
        Me.btnCliente.Image = CType(resources.GetObject("btnCliente.Image"), System.Drawing.Image)
        Me.btnCliente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(151, 36)
        Me.btnCliente.Text = "Cadastro de Clientes"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 39)
        '
        'btnEstorno
        '
        Me.btnEstorno.Image = CType(resources.GetObject("btnEstorno.Image"), System.Drawing.Image)
        Me.btnEstorno.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEstorno.Name = "btnEstorno"
        Me.btnEstorno.Size = New System.Drawing.Size(178, 36)
        Me.btnEstorno.Text = "Estornar Crédito/Dinheiro"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 39)
        '
        'btnDespesa
        '
        Me.btnDespesa.Image = CType(resources.GetObject("btnDespesa.Image"), System.Drawing.Image)
        Me.btnDespesa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDespesa.Name = "btnDespesa"
        Me.btnDespesa.Size = New System.Drawing.Size(91, 36)
        Me.btnDespesa.Text = "Despesas"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 39)
        '
        'btnOutrasDespesas
        '
        Me.btnOutrasDespesas.Image = CType(resources.GetObject("btnOutrasDespesas.Image"), System.Drawing.Image)
        Me.btnOutrasDespesas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnOutrasDespesas.Name = "btnOutrasDespesas"
        Me.btnOutrasDespesas.Size = New System.Drawing.Size(124, 36)
        Me.btnOutrasDespesas.Text = "Outras Receitas"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 39)
        '
        'btnRelatorios
        '
        Me.btnRelatorios.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnRelDespesas, Me.DespesasAcumuladasToolStripMenuItem, Me.btnRelRecFat, Me.btnVendasDia, Me.RelCaixa, Me.VendasDiaSintéticoToolStripMenuItem, Me.OperaçõesDeCréditoToolStripMenuItem})
        Me.btnRelatorios.Image = CType(resources.GetObject("btnRelatorios.Image"), System.Drawing.Image)
        Me.btnRelatorios.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRelatorios.Name = "btnRelatorios"
        Me.btnRelatorios.Size = New System.Drawing.Size(104, 36)
        Me.btnRelatorios.Text = "Relatórios"
        '
        'btnRelDespesas
        '
        Me.btnRelDespesas.Image = CType(resources.GetObject("btnRelDespesas.Image"), System.Drawing.Image)
        Me.btnRelDespesas.Name = "btnRelDespesas"
        Me.btnRelDespesas.Size = New System.Drawing.Size(191, 22)
        Me.btnRelDespesas.Text = "Despesas"
        '
        'DespesasAcumuladasToolStripMenuItem
        '
        Me.DespesasAcumuladasToolStripMenuItem.Image = CType(resources.GetObject("DespesasAcumuladasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DespesasAcumuladasToolStripMenuItem.Name = "DespesasAcumuladasToolStripMenuItem"
        Me.DespesasAcumuladasToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.DespesasAcumuladasToolStripMenuItem.Text = "Despesas Acumuladas"
        '
        'btnRelRecFat
        '
        Me.btnRelRecFat.Image = CType(resources.GetObject("btnRelRecFat.Image"), System.Drawing.Image)
        Me.btnRelRecFat.Name = "btnRelRecFat"
        Me.btnRelRecFat.Size = New System.Drawing.Size(191, 22)
        Me.btnRelRecFat.Text = "Recebimento Faturas"
        '
        'btnVendasDia
        '
        Me.btnVendasDia.Image = CType(resources.GetObject("btnVendasDia.Image"), System.Drawing.Image)
        Me.btnVendasDia.Name = "btnVendasDia"
        Me.btnVendasDia.Size = New System.Drawing.Size(191, 22)
        Me.btnVendasDia.Text = "Vendas Dia"
        '
        'RelCaixa
        '
        Me.RelCaixa.Image = CType(resources.GetObject("RelCaixa.Image"), System.Drawing.Image)
        Me.RelCaixa.Name = "RelCaixa"
        Me.RelCaixa.Size = New System.Drawing.Size(191, 22)
        Me.RelCaixa.Text = "Caixa Dia"
        '
        'VendasDiaSintéticoToolStripMenuItem
        '
        Me.VendasDiaSintéticoToolStripMenuItem.Image = CType(resources.GetObject("VendasDiaSintéticoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VendasDiaSintéticoToolStripMenuItem.Name = "VendasDiaSintéticoToolStripMenuItem"
        Me.VendasDiaSintéticoToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.VendasDiaSintéticoToolStripMenuItem.Text = "Vendas Dia Sintético"
        '
        'OperaçõesDeCréditoToolStripMenuItem
        '
        Me.OperaçõesDeCréditoToolStripMenuItem.Image = CType(resources.GetObject("OperaçõesDeCréditoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OperaçõesDeCréditoToolStripMenuItem.Name = "OperaçõesDeCréditoToolStripMenuItem"
        Me.OperaçõesDeCréditoToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.OperaçõesDeCréditoToolStripMenuItem.Text = "Operações de Crédito"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 39)
        '
        'btnFecharCaixa
        '
        Me.btnFecharCaixa.Image = CType(resources.GetObject("btnFecharCaixa.Image"), System.Drawing.Image)
        Me.btnFecharCaixa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFecharCaixa.Name = "btnFecharCaixa"
        Me.btnFecharCaixa.Size = New System.Drawing.Size(110, 36)
        Me.btnFecharCaixa.Text = "Fechar Caixa"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'lblDataCaixa
        '
        Me.lblDataCaixa.AutoSize = True
        Me.lblDataCaixa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataCaixa.Location = New System.Drawing.Point(17, 45)
        Me.lblDataCaixa.Name = "lblDataCaixa"
        Me.lblDataCaixa.Size = New System.Drawing.Size(97, 16)
        Me.lblDataCaixa.TabIndex = 21
        Me.lblDataCaixa.Text = "lblDataCaixa"
        Me.lblDataCaixa.Visible = False
        '
        'pnCaixa
        '
        Me.pnCaixa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnCaixa.Controls.Add(Me.txtCodGerente)
        Me.pnCaixa.Controls.Add(Me.Label6)
        Me.pnCaixa.Controls.Add(Me.Button3)
        Me.pnCaixa.Controls.Add(Me.Button2)
        Me.pnCaixa.Controls.Add(Me.txtDataAbertura)
        Me.pnCaixa.Controls.Add(Me.txtSenhaGerente)
        Me.pnCaixa.Controls.Add(Me.txtSaldoInicial)
        Me.pnCaixa.Controls.Add(Me.Label2)
        Me.pnCaixa.Controls.Add(Me.Label1)
        Me.pnCaixa.Controls.Add(Me.lblDataAbertura)
        Me.pnCaixa.Location = New System.Drawing.Point(0, 42)
        Me.pnCaixa.Name = "pnCaixa"
        Me.pnCaixa.Size = New System.Drawing.Size(906, 38)
        Me.pnCaixa.TabIndex = 23
        Me.pnCaixa.Visible = False
        '
        'txtCodGerente
        '
        Me.txtCodGerente.Location = New System.Drawing.Point(518, 10)
        Me.txtCodGerente.Name = "txtCodGerente"
        Me.txtCodGerente.Size = New System.Drawing.Size(67, 20)
        Me.txtCodGerente.TabIndex = 8
        Me.txtCodGerente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(598, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Senha:"
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(826, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(77, 32)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Cancelar"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(748, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 32)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "OK"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtDataAbertura
        '
        Me.txtDataAbertura.Location = New System.Drawing.Point(105, 10)
        Me.txtDataAbertura.Mask = "00/00/0000"
        Me.txtDataAbertura.Name = "txtDataAbertura"
        Me.txtDataAbertura.Size = New System.Drawing.Size(75, 20)
        Me.txtDataAbertura.TabIndex = 6
        Me.txtDataAbertura.ValidatingType = GetType(Date)
        '
        'txtSenhaGerente
        '
        Me.txtSenhaGerente.Location = New System.Drawing.Point(651, 10)
        Me.txtSenhaGerente.Name = "txtSenhaGerente"
        Me.txtSenhaGerente.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenhaGerente.Size = New System.Drawing.Size(86, 20)
        Me.txtSenhaGerente.TabIndex = 9
        '
        'txtSaldoInicial
        '
        Me.txtSaldoInicial.Location = New System.Drawing.Point(327, 10)
        Me.txtSaldoInicial.Name = "txtSaldoInicial"
        Me.txtSaldoInicial.Size = New System.Drawing.Size(80, 20)
        Me.txtSaldoInicial.TabIndex = 7
        Me.txtSaldoInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(424, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cód. Gerente:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(191, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Saldo inicial do caixa:"
        '
        'lblDataAbertura
        '
        Me.lblDataAbertura.AutoSize = True
        Me.lblDataAbertura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataAbertura.Location = New System.Drawing.Point(12, 13)
        Me.lblDataAbertura.Name = "lblDataAbertura"
        Me.lblDataAbertura.Size = New System.Drawing.Size(89, 13)
        Me.lblDataAbertura.TabIndex = 0
        Me.lblDataAbertura.Text = "Data abertura:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "CAIXA:"
        Me.Label3.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(70, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Label5"
        Me.Label5.Visible = False
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
        'grdCaixa
        '
        Me.grdCaixa.AllowUserToAddRows = False
        Me.grdCaixa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.grdCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdCaixa.Location = New System.Drawing.Point(17, 109)
        Me.grdCaixa.Name = "grdCaixa"
        Me.grdCaixa.RowHeadersVisible = False
        Me.grdCaixa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdCaixa.Size = New System.Drawing.Size(1301, 526)
        Me.grdCaixa.TabIndex = 29
        Me.grdCaixa.Visible = False
        '
        'gbDados
        '
        Me.gbDados.Controls.Add(Me.rgNome)
        Me.gbDados.Controls.Add(Me.txtDataIni)
        Me.gbDados.Controls.Add(Me.rgCodigo)
        Me.gbDados.Controls.Add(Me.rgPedido)
        Me.gbDados.Controls.Add(Me.btnLocalizar)
        Me.gbDados.Controls.Add(Me.lblFim)
        Me.gbDados.Controls.Add(Me.lblInicio)
        Me.gbDados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDados.Location = New System.Drawing.Point(896, 56)
        Me.gbDados.Name = "gbDados"
        Me.gbDados.Size = New System.Drawing.Size(425, 47)
        Me.gbDados.TabIndex = 33
        Me.gbDados.TabStop = False
        Me.gbDados.Text = "Pesquisar por"
        Me.gbDados.Visible = False
        '
        'rgNome
        '
        Me.rgNome.AutoSize = True
        Me.rgNome.Location = New System.Drawing.Point(167, 20)
        Me.rgNome.Name = "rgNome"
        Me.rgNome.Size = New System.Drawing.Size(57, 17)
        Me.rgNome.TabIndex = 17
        Me.rgNome.TabStop = True
        Me.rgNome.Text = "Nome"
        Me.rgNome.UseVisualStyleBackColor = True
        '
        'txtDataIni
        '
        Me.txtDataIni.Location = New System.Drawing.Point(230, 18)
        Me.txtDataIni.Name = "txtDataIni"
        Me.txtDataIni.Size = New System.Drawing.Size(80, 20)
        Me.txtDataIni.TabIndex = 2
        Me.txtDataIni.ValidatingType = GetType(Date)
        '
        'rgCodigo
        '
        Me.rgCodigo.AutoSize = True
        Me.rgCodigo.Location = New System.Drawing.Point(98, 20)
        Me.rgCodigo.Name = "rgCodigo"
        Me.rgCodigo.Size = New System.Drawing.Size(64, 17)
        Me.rgCodigo.TabIndex = 1
        Me.rgCodigo.Text = "Código"
        Me.rgCodigo.UseVisualStyleBackColor = True
        '
        'rgPedido
        '
        Me.rgPedido.AutoSize = True
        Me.rgPedido.Checked = True
        Me.rgPedido.Location = New System.Drawing.Point(12, 20)
        Me.rgPedido.Name = "rgPedido"
        Me.rgPedido.Size = New System.Drawing.Size(82, 17)
        Me.rgPedido.TabIndex = 0
        Me.rgPedido.TabStop = True
        Me.rgPedido.Text = "Nº Pedido"
        Me.rgPedido.UseVisualStyleBackColor = True
        '
        'btnLocalizar
        '
        Me.btnLocalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLocalizar.Image = CType(resources.GetObject("btnLocalizar.Image"), System.Drawing.Image)
        Me.btnLocalizar.Location = New System.Drawing.Point(328, 10)
        Me.btnLocalizar.Name = "btnLocalizar"
        Me.btnLocalizar.Size = New System.Drawing.Size(93, 33)
        Me.btnLocalizar.TabIndex = 4
        Me.btnLocalizar.Text = "Localizar"
        Me.btnLocalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLocalizar.UseVisualStyleBackColor = True
        '
        'lblFim
        '
        Me.lblFim.AutoSize = True
        Me.lblFim.Location = New System.Drawing.Point(374, 21)
        Me.lblFim.Name = "lblFim"
        Me.lblFim.Size = New System.Drawing.Size(30, 13)
        Me.lblFim.TabIndex = 16
        Me.lblFim.Text = "Fim:"
        Me.lblFim.Visible = False
        '
        'lblInicio
        '
        Me.lblInicio.AutoSize = True
        Me.lblInicio.Location = New System.Drawing.Point(236, 21)
        Me.lblInicio.Name = "lblInicio"
        Me.lblInicio.Size = New System.Drawing.Size(42, 13)
        Me.lblInicio.TabIndex = 15
        Me.lblInicio.Text = "Inicio:"
        Me.lblInicio.Visible = False
        '
        'lblTotalGeral
        '
        Me.lblTotalGeral.AutoSize = True
        Me.lblTotalGeral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalGeral.Location = New System.Drawing.Point(14, 676)
        Me.lblTotalGeral.Name = "lblTotalGeral"
        Me.lblTotalGeral.Size = New System.Drawing.Size(40, 13)
        Me.lblTotalGeral.TabIndex = 40
        Me.lblTotalGeral.Text = "Total:"
        Me.lblTotalGeral.Visible = False
        '
        'lblTotalItens
        '
        Me.lblTotalItens.AutoSize = True
        Me.lblTotalItens.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalItens.Location = New System.Drawing.Point(14, 654)
        Me.lblTotalItens.Name = "lblTotalItens"
        Me.lblTotalItens.Size = New System.Drawing.Size(72, 13)
        Me.lblTotalItens.TabIndex = 39
        Me.lblTotalItens.Text = "Total Itens:"
        Me.lblTotalItens.Visible = False
        '
        'btnAtualiza
        '
        Me.btnAtualiza.Image = CType(resources.GetObject("btnAtualiza.Image"), System.Drawing.Image)
        Me.btnAtualiza.Location = New System.Drawing.Point(1101, 651)
        Me.btnAtualiza.Name = "btnAtualiza"
        Me.btnAtualiza.Size = New System.Drawing.Size(105, 36)
        Me.btnAtualiza.TabIndex = 32
        Me.btnAtualiza.Text = "Atualizar"
        Me.btnAtualiza.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAtualiza.UseVisualStyleBackColor = True
        '
        'btnGerarFatura
        '
        Me.btnGerarFatura.Image = CType(resources.GetObject("btnGerarFatura.Image"), System.Drawing.Image)
        Me.btnGerarFatura.Location = New System.Drawing.Point(1215, 651)
        Me.btnGerarFatura.Name = "btnGerarFatura"
        Me.btnGerarFatura.Size = New System.Drawing.Size(105, 36)
        Me.btnGerarFatura.TabIndex = 31
        Me.btnGerarFatura.Text = "Gerar Fatura "
        Me.btnGerarFatura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGerarFatura.UseVisualStyleBackColor = True
        '
        'frmCaixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 733)
        Me.Controls.Add(Me.lblTotalGeral)
        Me.Controls.Add(Me.lblTotalItens)
        Me.Controls.Add(Me.gbDados)
        Me.Controls.Add(Me.btnAtualiza)
        Me.Controls.Add(Me.btnGerarFatura)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pnCaixa)
        Me.Controls.Add(Me.lblDataCaixa)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.grdCaixa)
        Me.Controls.Add(Me.pnFechaCaixa)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCaixa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Caixa"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.pnCaixa.ResumeLayout(False)
        Me.pnCaixa.PerformLayout()
        Me.pnFechaCaixa.ResumeLayout(False)
        Me.pnFechaCaixa.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdCaixa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDados.ResumeLayout(False)
        Me.gbDados.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAbrirCaixa As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAbrirFatura As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnDespesa As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnOutrasDespesas As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnRelatorios As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents btnRelDespesas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnRelRecFat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnVendasDia As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RelCaixa As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VendasDiaSintéticoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblDataCaixa As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnFecharCaixa As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnCaixa As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblDataAbertura As System.Windows.Forms.Label
    Friend WithEvents txtDataAbertura As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtSenhaGerente As System.Windows.Forms.TextBox
    Friend WithEvents txtSaldoInicial As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCodGerente As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
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
    Friend WithEvents grdCaixa As System.Windows.Forms.DataGridView
    Friend WithEvents btnGerarFatura As System.Windows.Forms.Button
    Friend WithEvents btnAtualiza As System.Windows.Forms.Button
    Friend WithEvents btnLocalizar As System.Windows.Forms.Button
    Friend WithEvents gbDados As System.Windows.Forms.GroupBox
    Friend WithEvents rgCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents rgPedido As System.Windows.Forms.RadioButton
    Friend WithEvents txtDataIni As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblFim As System.Windows.Forms.Label
    Friend WithEvents lblInicio As System.Windows.Forms.Label
    Friend WithEvents rgNome As System.Windows.Forms.RadioButton
    Friend WithEvents DespesasAcumuladasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OperaçõesDeCréditoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEstorno As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCliente As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAbrePedido As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblTotalGeral As System.Windows.Forms.Label
    Friend WithEvents lblTotalItens As System.Windows.Forms.Label
End Class
