<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPedido
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPedido))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNpedido = New System.Windows.Forms.Label()
        Me.lblFilial = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.mnuProdutos = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mniAtualizaPreco = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrocaProdutoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreçoManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlterarPreçoProdutoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblTotProd = New System.Windows.Forms.TextBox()
        Me.lblTotServ = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.TextBox()
        Me.grpCabecalho = New System.Windows.Forms.GroupBox()
        Me.txtVendedorExterno = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cbForma = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.chkLente = New System.Windows.Forms.CheckBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.lblVendedor = New System.Windows.Forms.Label()
        Me.grpProdutos = New System.Windows.Forms.GroupBox()
        Me.grdProd = New System.Windows.Forms.DataGridView()
        Me.lblDescontoTabela = New System.Windows.Forms.Label()
        Me.lblPrecoTabela = New System.Windows.Forms.Label()
        Me.btnExcluirProd = New System.Windows.Forms.Button()
        Me.lblProduto = New System.Windows.Forms.Label()
        Me.btnSalvarItem = New System.Windows.Forms.Button()
        Me.txtCodProd = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtQuant = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.grpServicos = New System.Windows.Forms.GroupBox()
        Me.btnSalvarServico = New System.Windows.Forms.Button()
        Me.grdServico = New System.Windows.Forms.DataGridView()
        Me.mnuServicos = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnExcluirServico = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtQuantServ = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbServicos = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCancelarPedido = New System.Windows.Forms.ToolStripButton()
        Me.mnuProdutos.SuspendLayout()
        Me.grpCabecalho.SuspendLayout()
        Me.grpProdutos.SuspendLayout()
        CType(Me.grdProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpServicos.SuspendLayout()
        CType(Me.grdServico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuServicos.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nº Pedido"
        '
        'lblNpedido
        '
        Me.lblNpedido.AutoSize = True
        Me.lblNpedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNpedido.Location = New System.Drawing.Point(41, 29)
        Me.lblNpedido.Name = "lblNpedido"
        Me.lblNpedido.Size = New System.Drawing.Size(14, 13)
        Me.lblNpedido.TabIndex = 1
        Me.lblNpedido.Text = "0"
        '
        'lblFilial
        '
        Me.lblFilial.AutoSize = True
        Me.lblFilial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilial.Location = New System.Drawing.Point(9, 29)
        Me.lblFilial.Name = "lblFilial"
        Me.lblFilial.Size = New System.Drawing.Size(14, 13)
        Me.lblFilial.TabIndex = 3
        Me.lblFilial.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Filial"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(102, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Vendedor(a)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(276, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Data Venda"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(359, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Cliente"
        '
        'mnuProdutos
        '
        Me.mnuProdutos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniAtualizaPreco, Me.TrocaProdutoToolStripMenuItem, Me.PreçoManualToolStripMenuItem, Me.AlterarPreçoProdutoToolStripMenuItem})
        Me.mnuProdutos.Name = "mnuProdutos"
        Me.mnuProdutos.Size = New System.Drawing.Size(200, 92)
        '
        'mniAtualizaPreco
        '
        Me.mniAtualizaPreco.Name = "mniAtualizaPreco"
        Me.mniAtualizaPreco.Size = New System.Drawing.Size(199, 22)
        Me.mniAtualizaPreco.Text = "Atualizar Preço Produto"
        '
        'TrocaProdutoToolStripMenuItem
        '
        Me.TrocaProdutoToolStripMenuItem.Name = "TrocaProdutoToolStripMenuItem"
        Me.TrocaProdutoToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.TrocaProdutoToolStripMenuItem.Text = "Devolução"
        '
        'PreçoManualToolStripMenuItem
        '
        Me.PreçoManualToolStripMenuItem.Name = "PreçoManualToolStripMenuItem"
        Me.PreçoManualToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.PreçoManualToolStripMenuItem.Text = "Preço Manual"
        '
        'AlterarPreçoProdutoToolStripMenuItem
        '
        Me.AlterarPreçoProdutoToolStripMenuItem.Name = "AlterarPreçoProdutoToolStripMenuItem"
        Me.AlterarPreçoProdutoToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.AlterarPreçoProdutoToolStripMenuItem.Text = "Alterar Preço Produto"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(544, 543)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Total Produtos"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(717, 543)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Total Servicos"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(891, 543)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Total Pedido"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotProd
        '
        Me.lblTotProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotProd.Location = New System.Drawing.Point(637, 541)
        Me.lblTotProd.Name = "lblTotProd"
        Me.lblTotProd.ReadOnly = True
        Me.lblTotProd.Size = New System.Drawing.Size(77, 20)
        Me.lblTotProd.TabIndex = 17
        Me.lblTotProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTotServ
        '
        Me.lblTotServ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotServ.Location = New System.Drawing.Point(809, 541)
        Me.lblTotServ.Name = "lblTotServ"
        Me.lblTotServ.ReadOnly = True
        Me.lblTotServ.Size = New System.Drawing.Size(77, 20)
        Me.lblTotServ.TabIndex = 18
        Me.lblTotServ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(971, 541)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.ReadOnly = True
        Me.lblTotal.Size = New System.Drawing.Size(77, 20)
        Me.lblTotal.TabIndex = 19
        Me.lblTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'grpCabecalho
        '
        Me.grpCabecalho.Controls.Add(Me.txtVendedorExterno)
        Me.grpCabecalho.Controls.Add(Me.Label17)
        Me.grpCabecalho.Controls.Add(Me.cbForma)
        Me.grpCabecalho.Controls.Add(Me.Label15)
        Me.grpCabecalho.Controls.Add(Me.chkLente)
        Me.grpCabecalho.Controls.Add(Me.lblCliente)
        Me.grpCabecalho.Controls.Add(Me.lblData)
        Me.grpCabecalho.Controls.Add(Me.lblVendedor)
        Me.grpCabecalho.Controls.Add(Me.lblNpedido)
        Me.grpCabecalho.Controls.Add(Me.lblFilial)
        Me.grpCabecalho.Controls.Add(Me.Label4)
        Me.grpCabecalho.Controls.Add(Me.Label5)
        Me.grpCabecalho.Controls.Add(Me.Label1)
        Me.grpCabecalho.Controls.Add(Me.Label3)
        Me.grpCabecalho.Controls.Add(Me.Label2)
        Me.grpCabecalho.Location = New System.Drawing.Point(8, 40)
        Me.grpCabecalho.Name = "grpCabecalho"
        Me.grpCabecalho.Size = New System.Drawing.Size(1041, 55)
        Me.grpCabecalho.TabIndex = 21
        Me.grpCabecalho.TabStop = False
        '
        'txtVendedorExterno
        '
        Me.txtVendedorExterno.Location = New System.Drawing.Point(863, 30)
        Me.txtVendedorExterno.MaxLength = 12
        Me.txtVendedorExterno.Name = "txtVendedorExterno"
        Me.txtVendedorExterno.Size = New System.Drawing.Size(101, 20)
        Me.txtVendedorExterno.TabIndex = 38
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(859, 16)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(108, 13)
        Me.Label17.TabIndex = 37
        Me.Label17.Text = "Vendedor Externo"
        '
        'cbForma
        '
        Me.cbForma.BackColor = System.Drawing.SystemColors.Window
        Me.cbForma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbForma.FormattingEnabled = True
        Me.cbForma.Location = New System.Drawing.Point(723, 29)
        Me.cbForma.Name = "cbForma"
        Me.cbForma.Size = New System.Drawing.Size(129, 21)
        Me.cbForma.TabIndex = 36
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(720, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(126, 13)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "Forma de Pagamento"
        '
        'chkLente
        '
        Me.chkLente.AutoSize = True
        Me.chkLente.Checked = True
        Me.chkLente.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLente.Location = New System.Drawing.Point(981, 21)
        Me.chkLente.Name = "chkLente"
        Me.chkLente.Size = New System.Drawing.Size(53, 17)
        Me.chkLente.TabIndex = 34
        Me.chkLente.Text = "Lente"
        Me.chkLente.UseVisualStyleBackColor = True
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Location = New System.Drawing.Point(359, 29)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(52, 13)
        Me.lblCliente.TabIndex = 29
        Me.lblCliente.Text = "Label15"
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData.Location = New System.Drawing.Point(276, 29)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(52, 13)
        Me.lblData.TabIndex = 28
        Me.lblData.Text = "Label15"
        '
        'lblVendedor
        '
        Me.lblVendedor.AutoSize = True
        Me.lblVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVendedor.Location = New System.Drawing.Point(102, 29)
        Me.lblVendedor.Name = "lblVendedor"
        Me.lblVendedor.Size = New System.Drawing.Size(52, 13)
        Me.lblVendedor.TabIndex = 27
        Me.lblVendedor.Text = "Label15"
        '
        'grpProdutos
        '
        Me.grpProdutos.Controls.Add(Me.grdProd)
        Me.grpProdutos.Controls.Add(Me.lblDescontoTabela)
        Me.grpProdutos.Controls.Add(Me.lblPrecoTabela)
        Me.grpProdutos.Controls.Add(Me.btnExcluirProd)
        Me.grpProdutos.Controls.Add(Me.lblProduto)
        Me.grpProdutos.Controls.Add(Me.btnSalvarItem)
        Me.grpProdutos.Controls.Add(Me.txtCodProd)
        Me.grpProdutos.Controls.Add(Me.Label11)
        Me.grpProdutos.Controls.Add(Me.txtQuant)
        Me.grpProdutos.Controls.Add(Me.Label10)
        Me.grpProdutos.Controls.Add(Me.Label6)
        Me.grpProdutos.Controls.Add(Me.Label12)
        Me.grpProdutos.Location = New System.Drawing.Point(8, 97)
        Me.grpProdutos.Name = "grpProdutos"
        Me.grpProdutos.Size = New System.Drawing.Size(1041, 229)
        Me.grpProdutos.TabIndex = 22
        Me.grpProdutos.TabStop = False
        '
        'grdProd
        '
        Me.grdProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdProd.ContextMenuStrip = Me.mnuProdutos
        Me.grdProd.Location = New System.Drawing.Point(8, 41)
        Me.grdProd.Name = "grdProd"
        Me.grdProd.ReadOnly = True
        Me.grdProd.RowHeadersVisible = False
        Me.grdProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdProd.Size = New System.Drawing.Size(1026, 182)
        Me.grdProd.TabIndex = 34
        '
        'lblDescontoTabela
        '
        Me.lblDescontoTabela.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescontoTabela.Location = New System.Drawing.Point(637, 15)
        Me.lblDescontoTabela.Name = "lblDescontoTabela"
        Me.lblDescontoTabela.Size = New System.Drawing.Size(60, 16)
        Me.lblDescontoTabela.TabIndex = 33
        '
        'lblPrecoTabela
        '
        Me.lblPrecoTabela.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecoTabela.Location = New System.Drawing.Point(509, 15)
        Me.lblPrecoTabela.Name = "lblPrecoTabela"
        Me.lblPrecoTabela.Size = New System.Drawing.Size(60, 16)
        Me.lblPrecoTabela.TabIndex = 32
        '
        'btnExcluirProd
        '
        Me.btnExcluirProd.BackColor = System.Drawing.SystemColors.Control
        Me.btnExcluirProd.Enabled = False
        Me.btnExcluirProd.Image = CType(resources.GetObject("btnExcluirProd.Image"), System.Drawing.Image)
        Me.btnExcluirProd.Location = New System.Drawing.Point(964, 10)
        Me.btnExcluirProd.Name = "btnExcluirProd"
        Me.btnExcluirProd.Size = New System.Drawing.Size(71, 26)
        Me.btnExcluirProd.TabIndex = 3
        Me.btnExcluirProd.Text = "Excluir"
        Me.btnExcluirProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExcluirProd.UseVisualStyleBackColor = True
        '
        'lblProduto
        '
        Me.lblProduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProduto.Location = New System.Drawing.Point(222, 15)
        Me.lblProduto.Name = "lblProduto"
        Me.lblProduto.Size = New System.Drawing.Size(238, 16)
        Me.lblProduto.TabIndex = 30
        '
        'btnSalvarItem
        '
        Me.btnSalvarItem.BackColor = System.Drawing.SystemColors.Control
        Me.btnSalvarItem.Enabled = False
        Me.btnSalvarItem.Image = CType(resources.GetObject("btnSalvarItem.Image"), System.Drawing.Image)
        Me.btnSalvarItem.Location = New System.Drawing.Point(875, 10)
        Me.btnSalvarItem.Name = "btnSalvarItem"
        Me.btnSalvarItem.Size = New System.Drawing.Size(83, 26)
        Me.btnSalvarItem.TabIndex = 2
        Me.btnSalvarItem.Text = "Adicionar"
        Me.btnSalvarItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvarItem.UseVisualStyleBackColor = True
        '
        'txtCodProd
        '
        Me.txtCodProd.Location = New System.Drawing.Point(142, 12)
        Me.txtCodProd.MaxLength = 12
        Me.txtCodProd.Name = "txtCodProd"
        Me.txtCodProd.Size = New System.Drawing.Size(73, 20)
        Me.txtCodProd.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(13, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 16)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Quant."
        '
        'txtQuant
        '
        Me.txtQuant.Location = New System.Drawing.Point(56, 12)
        Me.txtQuant.Name = "txtQuant"
        Me.txtQuant.Size = New System.Drawing.Size(32, 20)
        Me.txtQuant.TabIndex = 0
        Me.txtQuant.Text = "1"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(99, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 16)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Produto"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(467, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 16)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "P. Unit"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(570, 15)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 16)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Desconto (%)"
        '
        'grpServicos
        '
        Me.grpServicos.Controls.Add(Me.btnSalvarServico)
        Me.grpServicos.Controls.Add(Me.grdServico)
        Me.grpServicos.Controls.Add(Me.btnExcluirServico)
        Me.grpServicos.Controls.Add(Me.Label14)
        Me.grpServicos.Controls.Add(Me.txtQuantServ)
        Me.grpServicos.Controls.Add(Me.Label13)
        Me.grpServicos.Controls.Add(Me.cbServicos)
        Me.grpServicos.Location = New System.Drawing.Point(8, 327)
        Me.grpServicos.Name = "grpServicos"
        Me.grpServicos.Size = New System.Drawing.Size(1041, 203)
        Me.grpServicos.TabIndex = 23
        Me.grpServicos.TabStop = False
        '
        'btnSalvarServico
        '
        Me.btnSalvarServico.Image = CType(resources.GetObject("btnSalvarServico.Image"), System.Drawing.Image)
        Me.btnSalvarServico.Location = New System.Drawing.Point(875, 12)
        Me.btnSalvarServico.Name = "btnSalvarServico"
        Me.btnSalvarServico.Size = New System.Drawing.Size(83, 26)
        Me.btnSalvarServico.TabIndex = 6
        Me.btnSalvarServico.Text = "Adicionar"
        Me.btnSalvarServico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvarServico.UseVisualStyleBackColor = True
        '
        'grdServico
        '
        Me.grdServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdServico.ContextMenuStrip = Me.mnuServicos
        Me.grdServico.Location = New System.Drawing.Point(11, 45)
        Me.grdServico.Name = "grdServico"
        Me.grdServico.ReadOnly = True
        Me.grdServico.RowHeadersVisible = False
        Me.grdServico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdServico.Size = New System.Drawing.Size(1026, 153)
        Me.grdServico.TabIndex = 29
        '
        'mnuServicos
        '
        Me.mnuServicos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3})
        Me.mnuServicos.Name = "mnuProdutos"
        Me.mnuServicos.Size = New System.Drawing.Size(148, 26)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(147, 22)
        Me.ToolStripMenuItem3.Text = "Preço Manual"
        '
        'btnExcluirServico
        '
        Me.btnExcluirServico.BackColor = System.Drawing.SystemColors.Control
        Me.btnExcluirServico.Image = CType(resources.GetObject("btnExcluirServico.Image"), System.Drawing.Image)
        Me.btnExcluirServico.Location = New System.Drawing.Point(964, 12)
        Me.btnExcluirServico.Name = "btnExcluirServico"
        Me.btnExcluirServico.Size = New System.Drawing.Size(71, 26)
        Me.btnExcluirServico.TabIndex = 7
        Me.btnExcluirServico.Text = "Excluir"
        Me.btnExcluirServico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExcluirServico.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(348, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 16)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Quant."
        '
        'txtQuantServ
        '
        Me.txtQuantServ.Location = New System.Drawing.Point(394, 14)
        Me.txtQuantServ.Name = "txtQuantServ"
        Me.txtQuantServ.Size = New System.Drawing.Size(32, 20)
        Me.txtQuantServ.TabIndex = 5
        Me.txtQuantServ.Text = "1"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 13)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Serviços."
        '
        'cbServicos
        '
        Me.cbServicos.FormattingEnabled = True
        Me.cbServicos.Location = New System.Drawing.Point(63, 14)
        Me.cbServicos.Name = "cbServicos"
        Me.cbServicos.Size = New System.Drawing.Size(280, 21)
        Me.cbServicos.TabIndex = 4
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnImprimir, Me.ToolStripSeparator1, Me.ToolStripButton2, Me.ToolStripSeparator2, Me.ToolStripButton3, Me.ToolStripSeparator3, Me.ToolStripSeparator4, Me.btnCancelarPedido})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1060, 39)
        Me.ToolStrip1.TabIndex = 24
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(113, 36)
        Me.btnImprimir.Text = "Imprimir Vias"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(133, 36)
        Me.ToolStripButton2.Text = "Imprimir Simples"
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
        Me.ToolStripButton3.Size = New System.Drawing.Size(134, 36)
        Me.ToolStripButton3.Text = "Imprimir Estoque"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 39)
        '
        'btnCancelarPedido
        '
        Me.btnCancelarPedido.Image = CType(resources.GetObject("btnCancelarPedido.Image"), System.Drawing.Image)
        Me.btnCancelarPedido.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelarPedido.Name = "btnCancelarPedido"
        Me.btnCancelarPedido.Size = New System.Drawing.Size(129, 36)
        Me.btnCancelarPedido.Text = "Cancelar Pedido"
        '
        'frmPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1060, 570)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblTotProd)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblTotServ)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.grpServicos)
        Me.Controls.Add(Me.grpCabecalho)
        Me.Controls.Add(Me.grpProdutos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pedido"
        Me.mnuProdutos.ResumeLayout(False)
        Me.grpCabecalho.ResumeLayout(False)
        Me.grpCabecalho.PerformLayout()
        Me.grpProdutos.ResumeLayout(False)
        Me.grpProdutos.PerformLayout()
        CType(Me.grdProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpServicos.ResumeLayout(False)
        Me.grpServicos.PerformLayout()
        CType(Me.grdServico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuServicos.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblNpedido As System.Windows.Forms.Label
    Friend WithEvents lblFilial As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblTotProd As System.Windows.Forms.TextBox
    Friend WithEvents lblTotServ As System.Windows.Forms.TextBox
    Friend WithEvents lblTotal As System.Windows.Forms.TextBox
    Friend WithEvents grpCabecalho As System.Windows.Forms.GroupBox
    Friend WithEvents grpProdutos As System.Windows.Forms.GroupBox
    Friend WithEvents btnSalvarItem As System.Windows.Forms.Button
    Friend WithEvents txtCodProd As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtQuant As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblProduto As System.Windows.Forms.Label
    Friend WithEvents grpServicos As System.Windows.Forms.GroupBox
    Friend WithEvents cbServicos As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtQuantServ As System.Windows.Forms.TextBox
    Friend WithEvents btnExcluirServico As System.Windows.Forms.Button
    Friend WithEvents btnExcluirProd As System.Windows.Forms.Button
    Friend WithEvents mnuProdutos As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mniAtualizaPreco As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrocaProdutoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkLente As System.Windows.Forms.CheckBox
    Friend WithEvents lblVendedor As System.Windows.Forms.Label
    Friend WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents lblDescontoTabela As System.Windows.Forms.Label
    Friend WithEvents lblPrecoTabela As System.Windows.Forms.Label
    Friend WithEvents cbForma As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtVendedorExterno As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents grdProd As System.Windows.Forms.DataGridView
    Friend WithEvents grdServico As System.Windows.Forms.DataGridView
    Friend WithEvents btnSalvarServico As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancelarPedido As System.Windows.Forms.ToolStripButton
    Friend WithEvents PreçoManualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuServicos As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents AlterarPreçoProdutoToolStripMenuItem As ToolStripMenuItem
End Class
