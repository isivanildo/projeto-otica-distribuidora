<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPedidoProducao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPedidoProducao))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNpedido = New System.Windows.Forms.Label()
        Me.lblFilial = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbVendedor = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtData = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.grdProd = New System.Windows.Forms.DataGrid()
        Me.mnuProdutos = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mniAtualizaPreco = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrocaProdutoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grdOS = New System.Windows.Forms.DataGrid()
        Me.mmOS = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExcluirOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.grpCabecalho = New System.Windows.Forms.GroupBox()
        Me.btnSalvarPedido = New System.Windows.Forms.Button()
        Me.grpProdutos = New System.Windows.Forms.GroupBox()
        Me.lblProdOE = New System.Windows.Forms.Label()
        Me.txtAdicaoOE = New System.Windows.Forms.TextBox()
        Me.txtBaseOE = New System.Windows.Forms.TextBox()
        Me.txtCilOE = New System.Windows.Forms.TextBox()
        Me.txtEsfOE = New System.Windows.Forms.TextBox()
        Me.txtCodTabOE = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblProdOD = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAdicaoOD = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBaseOD = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCilOD = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtEsfOD = New System.Windows.Forms.TextBox()
        Me.txtCodTabelaOD = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSalvarItem = New System.Windows.Forms.Button()
        Me.grpServicos = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnPrintEstoque = New System.Windows.Forms.Button()
        CType(Me.grdProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuProdutos.SuspendLayout()
        CType(Me.grdOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mmOS.SuspendLayout()
        Me.grpCabecalho.SuspendLayout()
        Me.grpProdutos.SuspendLayout()
        Me.grpServicos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número Pedido"
        '
        'lblNpedido
        '
        Me.lblNpedido.AutoSize = True
        Me.lblNpedido.Location = New System.Drawing.Point(6, 29)
        Me.lblNpedido.Name = "lblNpedido"
        Me.lblNpedido.Size = New System.Drawing.Size(13, 13)
        Me.lblNpedido.TabIndex = 1
        Me.lblNpedido.Text = "0"
        '
        'lblFilial
        '
        Me.lblFilial.AutoSize = True
        Me.lblFilial.Location = New System.Drawing.Point(101, 29)
        Me.lblFilial.Name = "lblFilial"
        Me.lblFilial.Size = New System.Drawing.Size(13, 13)
        Me.lblFilial.TabIndex = 3
        Me.lblFilial.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(101, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Filial"
        '
        'cbVendedor
        '
        Me.cbVendedor.FormattingEnabled = True
        Me.cbVendedor.Location = New System.Drawing.Point(133, 29)
        Me.cbVendedor.Name = "cbVendedor"
        Me.cbVendedor.Size = New System.Drawing.Size(158, 21)
        Me.cbVendedor.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(130, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Vendedor"
        '
        'dtData
        '
        Me.dtData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtData.Location = New System.Drawing.Point(297, 29)
        Me.dtData.Name = "dtData"
        Me.dtData.Size = New System.Drawing.Size(87, 20)
        Me.dtData.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(294, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Data Venda"
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(390, 29)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(278, 20)
        Me.txtCliente.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(387, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Cliente"
        '
        'grdProd
        '
        Me.grdProd.AllowSorting = False
        Me.grdProd.CaptionText = "Produtos"
        Me.grdProd.ContextMenuStrip = Me.mnuProdutos
        Me.grdProd.DataMember = ""
        Me.grdProd.FlatMode = True
        Me.grdProd.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdProd.Location = New System.Drawing.Point(4, 94)
        Me.grdProd.Name = "grdProd"
        Me.grdProd.ReadOnly = True
        Me.grdProd.Size = New System.Drawing.Size(756, 179)
        Me.grdProd.TabIndex = 10
        '
        'mnuProdutos
        '
        Me.mnuProdutos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniAtualizaPreco, Me.TrocaProdutoToolStripMenuItem})
        Me.mnuProdutos.Name = "mnuProdutos"
        Me.mnuProdutos.Size = New System.Drawing.Size(200, 48)
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
        'grdOS
        '
        Me.grdOS.CaptionText = "OS(s)"
        Me.grdOS.ContextMenuStrip = Me.mmOS
        Me.grdOS.DataMember = ""
        Me.grdOS.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdOS.Location = New System.Drawing.Point(4, 6)
        Me.grdOS.Name = "grdOS"
        Me.grdOS.ReadOnly = True
        Me.grdOS.Size = New System.Drawing.Size(254, 157)
        Me.grdOS.TabIndex = 11
        '
        'mmOS
        '
        Me.mmOS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExcluirOSToolStripMenuItem})
        Me.mmOS.Name = "mmOS"
        Me.mmOS.Size = New System.Drawing.Size(128, 26)
        '
        'ExcluirOSToolStripMenuItem
        '
        Me.ExcluirOSToolStripMenuItem.Name = "ExcluirOSToolStripMenuItem"
        Me.ExcluirOSToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.ExcluirOSToolStripMenuItem.Text = "Excluir OS"
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(623, 388)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(156, 23)
        Me.btnPrint.TabIndex = 20
        Me.btnPrint.Text = "Imprimir Vias"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'grpCabecalho
        '
        Me.grpCabecalho.Controls.Add(Me.btnSalvarPedido)
        Me.grpCabecalho.Controls.Add(Me.lblNpedido)
        Me.grpCabecalho.Controls.Add(Me.lblFilial)
        Me.grpCabecalho.Controls.Add(Me.cbVendedor)
        Me.grpCabecalho.Controls.Add(Me.dtData)
        Me.grpCabecalho.Controls.Add(Me.Label4)
        Me.grpCabecalho.Controls.Add(Me.txtCliente)
        Me.grpCabecalho.Controls.Add(Me.Label5)
        Me.grpCabecalho.Controls.Add(Me.Label1)
        Me.grpCabecalho.Controls.Add(Me.Label3)
        Me.grpCabecalho.Controls.Add(Me.Label2)
        Me.grpCabecalho.Location = New System.Drawing.Point(8, 3)
        Me.grpCabecalho.Name = "grpCabecalho"
        Me.grpCabecalho.Size = New System.Drawing.Size(767, 60)
        Me.grpCabecalho.TabIndex = 21
        Me.grpCabecalho.TabStop = False
        '
        'btnSalvarPedido
        '
        Me.btnSalvarPedido.BackColor = System.Drawing.SystemColors.Control
        Me.btnSalvarPedido.Location = New System.Drawing.Point(674, 27)
        Me.btnSalvarPedido.Name = "btnSalvarPedido"
        Me.btnSalvarPedido.Size = New System.Drawing.Size(56, 24)
        Me.btnSalvarPedido.TabIndex = 26
        Me.btnSalvarPedido.Text = "Salvar"
        Me.btnSalvarPedido.UseVisualStyleBackColor = False
        '
        'grpProdutos
        '
        Me.grpProdutos.Controls.Add(Me.lblProdOE)
        Me.grpProdutos.Controls.Add(Me.txtAdicaoOE)
        Me.grpProdutos.Controls.Add(Me.txtBaseOE)
        Me.grpProdutos.Controls.Add(Me.txtCilOE)
        Me.grpProdutos.Controls.Add(Me.txtEsfOE)
        Me.grpProdutos.Controls.Add(Me.txtCodTabOE)
        Me.grpProdutos.Controls.Add(Me.Label13)
        Me.grpProdutos.Controls.Add(Me.lblProdOD)
        Me.grpProdutos.Controls.Add(Me.Label7)
        Me.grpProdutos.Controls.Add(Me.txtQuantidade)
        Me.grpProdutos.Controls.Add(Me.Label8)
        Me.grpProdutos.Controls.Add(Me.txtAdicaoOD)
        Me.grpProdutos.Controls.Add(Me.Label9)
        Me.grpProdutos.Controls.Add(Me.txtBaseOD)
        Me.grpProdutos.Controls.Add(Me.Label10)
        Me.grpProdutos.Controls.Add(Me.txtCilOD)
        Me.grpProdutos.Controls.Add(Me.Label11)
        Me.grpProdutos.Controls.Add(Me.txtEsfOD)
        Me.grpProdutos.Controls.Add(Me.txtCodTabelaOD)
        Me.grpProdutos.Controls.Add(Me.Label6)
        Me.grpProdutos.Controls.Add(Me.btnSalvarItem)
        Me.grpProdutos.Controls.Add(Me.grdProd)
        Me.grpProdutos.Location = New System.Drawing.Point(8, 59)
        Me.grpProdutos.Name = "grpProdutos"
        Me.grpProdutos.Size = New System.Drawing.Size(767, 277)
        Me.grpProdutos.TabIndex = 22
        Me.grpProdutos.TabStop = False
        '
        'lblProdOE
        '
        Me.lblProdOE.Location = New System.Drawing.Point(386, 49)
        Me.lblProdOE.Name = "lblProdOE"
        Me.lblProdOE.Size = New System.Drawing.Size(214, 20)
        Me.lblProdOE.TabIndex = 47
        Me.lblProdOE.Text = "ProdOD"
        '
        'txtAdicaoOE
        '
        Me.txtAdicaoOE.Location = New System.Drawing.Point(335, 49)
        Me.txtAdicaoOE.Name = "txtAdicaoOE"
        Me.txtAdicaoOE.Size = New System.Drawing.Size(42, 20)
        Me.txtAdicaoOE.TabIndex = 46
        '
        'txtBaseOE
        '
        Me.txtBaseOE.Location = New System.Drawing.Point(287, 49)
        Me.txtBaseOE.Name = "txtBaseOE"
        Me.txtBaseOE.Size = New System.Drawing.Size(42, 20)
        Me.txtBaseOE.TabIndex = 45
        '
        'txtCilOE
        '
        Me.txtCilOE.Location = New System.Drawing.Point(239, 49)
        Me.txtCilOE.Name = "txtCilOE"
        Me.txtCilOE.Size = New System.Drawing.Size(42, 20)
        Me.txtCilOE.TabIndex = 44
        '
        'txtEsfOE
        '
        Me.txtEsfOE.Location = New System.Drawing.Point(191, 49)
        Me.txtEsfOE.Name = "txtEsfOE"
        Me.txtEsfOE.Size = New System.Drawing.Size(42, 20)
        Me.txtEsfOE.TabIndex = 43
        '
        'txtCodTabOE
        '
        Me.txtCodTabOE.Location = New System.Drawing.Point(92, 49)
        Me.txtCodTabOE.Name = "txtCodTabOE"
        Me.txtCodTabOE.Size = New System.Drawing.Size(90, 20)
        Me.txtCodTabOE.TabIndex = 41
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 52)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 13)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Cod. tabela OE"
        '
        'lblProdOD
        '
        Me.lblProdOD.Location = New System.Drawing.Point(386, 23)
        Me.lblProdOD.Name = "lblProdOD"
        Me.lblProdOD.Size = New System.Drawing.Size(214, 20)
        Me.lblProdOD.TabIndex = 40
        Me.lblProdOD.Text = "ProdOD"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(609, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Quantidade"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Location = New System.Drawing.Point(626, 40)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(42, 20)
        Me.txtQuantidade.TabIndex = 38
        Me.txtQuantidade.Text = "1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(332, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Adicao"
        '
        'txtAdicaoOD
        '
        Me.txtAdicaoOD.Location = New System.Drawing.Point(335, 23)
        Me.txtAdicaoOD.Name = "txtAdicaoOD"
        Me.txtAdicaoOD.Size = New System.Drawing.Size(42, 20)
        Me.txtAdicaoOD.TabIndex = 36
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(284, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Base"
        '
        'txtBaseOD
        '
        Me.txtBaseOD.Location = New System.Drawing.Point(287, 23)
        Me.txtBaseOD.Name = "txtBaseOD"
        Me.txtBaseOD.Size = New System.Drawing.Size(42, 20)
        Me.txtBaseOD.TabIndex = 34
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(236, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Cilindrico"
        '
        'txtCilOD
        '
        Me.txtCilOD.Location = New System.Drawing.Point(239, 23)
        Me.txtCilOD.Name = "txtCilOD"
        Me.txtCilOD.Size = New System.Drawing.Size(42, 20)
        Me.txtCilOD.TabIndex = 32
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(188, 7)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Esférico"
        '
        'txtEsfOD
        '
        Me.txtEsfOD.Location = New System.Drawing.Point(191, 23)
        Me.txtEsfOD.Name = "txtEsfOD"
        Me.txtEsfOD.Size = New System.Drawing.Size(42, 20)
        Me.txtEsfOD.TabIndex = 30
        '
        'txtCodTabelaOD
        '
        Me.txtCodTabelaOD.Location = New System.Drawing.Point(92, 23)
        Me.txtCodTabelaOD.Name = "txtCodTabelaOD"
        Me.txtCodTabelaOD.Size = New System.Drawing.Size(90, 20)
        Me.txtCodTabelaOD.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Cod. tabela OD"
        '
        'btnSalvarItem
        '
        Me.btnSalvarItem.BackColor = System.Drawing.SystemColors.Control
        Me.btnSalvarItem.Location = New System.Drawing.Point(674, 36)
        Me.btnSalvarItem.Name = "btnSalvarItem"
        Me.btnSalvarItem.Size = New System.Drawing.Size(56, 24)
        Me.btnSalvarItem.TabIndex = 25
        Me.btnSalvarItem.Text = "Salvar"
        Me.btnSalvarItem.UseVisualStyleBackColor = False
        '
        'grpServicos
        '
        Me.grpServicos.Controls.Add(Me.grdOS)
        Me.grpServicos.Location = New System.Drawing.Point(8, 336)
        Me.grpServicos.Name = "grpServicos"
        Me.grpServicos.Size = New System.Drawing.Size(600, 164)
        Me.grpServicos.TabIndex = 23
        Me.grpServicos.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(624, 417)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 23)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Imprimir Simples"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnPrintEstoque
        '
        Me.btnPrintEstoque.Location = New System.Drawing.Point(624, 446)
        Me.btnPrintEstoque.Name = "btnPrintEstoque"
        Me.btnPrintEstoque.Size = New System.Drawing.Size(155, 23)
        Me.btnPrintEstoque.TabIndex = 25
        Me.btnPrintEstoque.Text = "Imprimir Estoque"
        Me.btnPrintEstoque.UseVisualStyleBackColor = True
        '
        'frmPedidoProducao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 499)
        Me.Controls.Add(Me.btnPrintEstoque)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.grpServicos)
        Me.Controls.Add(Me.grpCabecalho)
        Me.Controls.Add(Me.grpProdutos)
        Me.Controls.Add(Me.btnPrint)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPedidoProducao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pedido"
        CType(Me.grdProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuProdutos.ResumeLayout(False)
        CType(Me.grdOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mmOS.ResumeLayout(False)
        Me.grpCabecalho.ResumeLayout(False)
        Me.grpCabecalho.PerformLayout()
        Me.grpProdutos.ResumeLayout(False)
        Me.grpProdutos.PerformLayout()
        Me.grpServicos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblNpedido As System.Windows.Forms.Label
    Friend WithEvents lblFilial As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbVendedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtData As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents grdProd As System.Windows.Forms.DataGrid
    Friend WithEvents grdOS As System.Windows.Forms.DataGrid
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents grpCabecalho As System.Windows.Forms.GroupBox
    Friend WithEvents grpProdutos As System.Windows.Forms.GroupBox
    Friend WithEvents btnSalvarItem As System.Windows.Forms.Button
    Friend WithEvents grpServicos As System.Windows.Forms.GroupBox
    Friend WithEvents btnSalvarPedido As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnPrintEstoque As System.Windows.Forms.Button
    Friend WithEvents mnuProdutos As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mniAtualizaPreco As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrocaProdutoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtCodTabelaOD As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtQuantidade As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtAdicaoOD As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtBaseOD As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCilOD As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtEsfOD As System.Windows.Forms.TextBox
    Friend WithEvents lblProdOD As System.Windows.Forms.Label
    Friend WithEvents lblProdOE As System.Windows.Forms.Label
    Friend WithEvents txtAdicaoOE As System.Windows.Forms.TextBox
    Friend WithEvents txtBaseOE As System.Windows.Forms.TextBox
    Friend WithEvents txtCilOE As System.Windows.Forms.TextBox
    Friend WithEvents txtEsfOE As System.Windows.Forms.TextBox
    Friend WithEvents txtCodTabOE As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents mmOS As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExcluirOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
