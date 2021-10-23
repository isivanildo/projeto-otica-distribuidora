<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFatura
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFatura))
        Me.mnuFaturas = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RemoverFaturaDoPedidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblFilialFatura = New System.Windows.Forms.Label()
        Me.grpRec = New System.Windows.Forms.GroupBox()
        Me.btnRecibo = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cbVencimento = New System.Windows.Forms.CheckBox()
        Me.txtDias = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnItemPedido = New System.Windows.Forms.Button()
        Me.btnExportarPdf = New System.Windows.Forms.Button()
        Me.txtNparcelas = New System.Windows.Forms.TextBox()
        Me.lblTroco = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtTroco = New System.Windows.Forms.TextBox()
        Me.cbForma = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.dtVenc = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtDevolvido = New System.Windows.Forms.TextBox()
        Me.txtDesconto = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtAcrescimo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtaPagar = New System.Windows.Forms.TextBox()
        Me.txtTotalPago = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTotalProd = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotalServ = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotalFatura = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grdPedido = New System.Windows.Forms.DataGridView()
        Me.txtTextoBoleto = New System.Windows.Forms.RichTextBox()
        Me.grdRec = New System.Windows.Forms.DataGridView()
        Me.lblFilial = New System.Windows.Forms.Label()
        Me.lblFatura = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.grdItens = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.SplashScreenManager1 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.BTSistemas.WaitForm1), True, True)
        Me.mnuFaturas.SuspendLayout()
        Me.grpRec.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdRec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grdItens, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuFaturas
        '
        Me.mnuFaturas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoverFaturaDoPedidoToolStripMenuItem})
        Me.mnuFaturas.Name = "mnuFaturas"
        Me.mnuFaturas.Size = New System.Drawing.Size(212, 26)
        '
        'RemoverFaturaDoPedidoToolStripMenuItem
        '
        Me.RemoverFaturaDoPedidoToolStripMenuItem.Name = "RemoverFaturaDoPedidoToolStripMenuItem"
        Me.RemoverFaturaDoPedidoToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.RemoverFaturaDoPedidoToolStripMenuItem.Text = "Remover pedido da fatura"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Location = New System.Drawing.Point(11, 3)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(142, 13)
        Me.lblCliente.TabIndex = 3
        Me.lblCliente.Text = "Identificação do Cliente"
        '
        'lblFilialFatura
        '
        Me.lblFilialFatura.AutoSize = True
        Me.lblFilialFatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilialFatura.Location = New System.Drawing.Point(11, 22)
        Me.lblFilialFatura.Name = "lblFilialFatura"
        Me.lblFilialFatura.Size = New System.Drawing.Size(96, 15)
        Me.lblFilialFatura.TabIndex = 4
        Me.lblFilialFatura.Text = "Filial / Fatura:"
        '
        'grpRec
        '
        Me.grpRec.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpRec.Controls.Add(Me.btnRecibo)
        Me.grpRec.Controls.Add(Me.Label17)
        Me.grpRec.Controls.Add(Me.cbVencimento)
        Me.grpRec.Controls.Add(Me.txtDias)
        Me.grpRec.Controls.Add(Me.btnOK)
        Me.grpRec.Controls.Add(Me.Label14)
        Me.grpRec.Controls.Add(Me.Label8)
        Me.grpRec.Controls.Add(Me.btnItemPedido)
        Me.grpRec.Controls.Add(Me.btnExportarPdf)
        Me.grpRec.Controls.Add(Me.txtNparcelas)
        Me.grpRec.Controls.Add(Me.lblTroco)
        Me.grpRec.Controls.Add(Me.Label7)
        Me.grpRec.Controls.Add(Me.Label15)
        Me.grpRec.Controls.Add(Me.txtValor)
        Me.grpRec.Controls.Add(Me.Label6)
        Me.grpRec.Controls.Add(Me.btnCancelar)
        Me.grpRec.Controls.Add(Me.txtTroco)
        Me.grpRec.Controls.Add(Me.cbForma)
        Me.grpRec.Controls.Add(Me.Label5)
        Me.grpRec.Controls.Add(Me.btnPrint)
        Me.grpRec.Controls.Add(Me.dtVenc)
        Me.grpRec.Location = New System.Drawing.Point(662, 261)
        Me.grpRec.Name = "grpRec"
        Me.grpRec.Size = New System.Drawing.Size(323, 263)
        Me.grpRec.TabIndex = 1
        Me.grpRec.TabStop = False
        Me.grpRec.Text = "Recebimento"
        '
        'btnRecibo
        '
        Me.btnRecibo.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnRecibo.Image = CType(resources.GetObject("btnRecibo.Image"), System.Drawing.Image)
        Me.btnRecibo.Location = New System.Drawing.Point(11, 234)
        Me.btnRecibo.Name = "btnRecibo"
        Me.btnRecibo.Size = New System.Drawing.Size(122, 28)
        Me.btnRecibo.TabIndex = 12
        Me.btnRecibo.Text = "Imprimir Recibo"
        Me.btnRecibo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRecibo.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(266, 23)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(28, 13)
        Me.Label17.TabIndex = 127
        Me.Label17.Text = "Dias"
        '
        'cbVencimento
        '
        Me.cbVencimento.AutoSize = True
        Me.cbVencimento.Location = New System.Drawing.Point(9, 115)
        Me.cbVencimento.Name = "cbVencimento"
        Me.cbVencimento.Size = New System.Drawing.Size(132, 17)
        Me.cbVencimento.TabIndex = 126
        Me.cbVencimento.Text = "Vencimento para o dia"
        Me.cbVencimento.UseVisualStyleBackColor = True
        '
        'txtDias
        '
        Me.txtDias.Location = New System.Drawing.Point(266, 40)
        Me.txtDias.Name = "txtDias"
        Me.txtDias.Size = New System.Drawing.Size(49, 20)
        Me.txtDias.TabIndex = 2
        Me.txtDias.Text = "0"
        '
        'btnOK
        '
        Me.btnOK.Image = CType(resources.GetObject("btnOK.Image"), System.Drawing.Image)
        Me.btnOK.Location = New System.Drawing.Point(263, 81)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(53, 28)
        Me.btnOK.TabIndex = 7
        Me.btnOK.Text = "OK"
        Me.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Enabled = False
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(177, 115)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 13)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "Troco"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(91, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Nº de Parcelas"
        '
        'btnItemPedido
        '
        Me.btnItemPedido.Image = CType(resources.GetObject("btnItemPedido.Image"), System.Drawing.Image)
        Me.btnItemPedido.Location = New System.Drawing.Point(11, 204)
        Me.btnItemPedido.Name = "btnItemPedido"
        Me.btnItemPedido.Size = New System.Drawing.Size(122, 28)
        Me.btnItemPedido.TabIndex = 11
        Me.btnItemPedido.Text = "Itens Pedido"
        Me.btnItemPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnItemPedido.UseVisualStyleBackColor = True
        '
        'btnExportarPdf
        '
        Me.btnExportarPdf.Image = CType(resources.GetObject("btnExportarPdf.Image"), System.Drawing.Image)
        Me.btnExportarPdf.Location = New System.Drawing.Point(139, 204)
        Me.btnExportarPdf.Name = "btnExportarPdf"
        Me.btnExportarPdf.Size = New System.Drawing.Size(122, 28)
        Me.btnExportarPdf.TabIndex = 9
        Me.btnExportarPdf.Text = "Exportar PDF"
        Me.btnExportarPdf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExportarPdf.UseVisualStyleBackColor = True
        '
        'txtNparcelas
        '
        Me.txtNparcelas.Location = New System.Drawing.Point(91, 87)
        Me.txtNparcelas.Name = "txtNparcelas"
        Me.txtNparcelas.Size = New System.Drawing.Size(78, 20)
        Me.txtNparcelas.TabIndex = 4
        Me.txtNparcelas.Text = "1"
        Me.txtNparcelas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTroco
        '
        Me.lblTroco.AutoSize = True
        Me.lblTroco.Enabled = False
        Me.lblTroco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTroco.ForeColor = System.Drawing.Color.Red
        Me.lblTroco.Location = New System.Drawing.Point(177, 130)
        Me.lblTroco.Name = "lblTroco"
        Me.lblTroco.Size = New System.Drawing.Size(73, 20)
        Me.lblTroco.TabIndex = 8
        Me.lblTroco.Text = "Label14"
        Me.lblTroco.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Valor"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Enabled = False
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(180, 70)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 13)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "Dinheiro"
        '
        'txtValor
        '
        Me.txtValor.ForeColor = System.Drawing.Color.Blue
        Me.txtValor.Location = New System.Drawing.Point(7, 87)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(73, 20)
        Me.txtValor.TabIndex = 3
        Me.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(105, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Forma Pagamento"
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(11, 173)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(122, 28)
        Me.btnCancelar.TabIndex = 10
        Me.btnCancelar.Text = "Cancelar Fatura"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtTroco
        '
        Me.txtTroco.Enabled = False
        Me.txtTroco.Location = New System.Drawing.Point(180, 87)
        Me.txtTroco.Name = "txtTroco"
        Me.txtTroco.Size = New System.Drawing.Size(73, 20)
        Me.txtTroco.TabIndex = 5
        Me.txtTroco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbForma
        '
        Me.cbForma.FormattingEnabled = True
        Me.cbForma.Location = New System.Drawing.Point(108, 40)
        Me.cbForma.Name = "cbForma"
        Me.cbForma.Size = New System.Drawing.Size(147, 21)
        Me.cbForma.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Data Vencimento"
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.Location = New System.Drawing.Point(139, 173)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(122, 28)
        Me.btnPrint.TabIndex = 8
        Me.btnPrint.Text = "Imprimir Fatura"
        Me.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'dtVenc
        '
        Me.dtVenc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtVenc.Location = New System.Drawing.Point(9, 40)
        Me.dtVenc.Name = "dtVenc"
        Me.dtVenc.Size = New System.Drawing.Size(84, 20)
        Me.dtVenc.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtDevolvido)
        Me.GroupBox1.Controls.Add(Me.txtDesconto)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtAcrescimo)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtaPagar)
        Me.GroupBox1.Controls.Add(Me.txtTotalPago)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtTotalProd)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtTotalServ)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtTotalFatura)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(662, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(323, 211)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Totais"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(141, 163)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(61, 13)
        Me.Label18.TabIndex = 35
        Me.Label18.Text = "Devolvidor:"
        '
        'txtDevolvido
        '
        Me.txtDevolvido.BackColor = System.Drawing.Color.White
        Me.txtDevolvido.ForeColor = System.Drawing.Color.Blue
        Me.txtDevolvido.Location = New System.Drawing.Point(209, 160)
        Me.txtDevolvido.Name = "txtDevolvido"
        Me.txtDevolvido.ReadOnly = True
        Me.txtDevolvido.Size = New System.Drawing.Size(101, 20)
        Me.txtDevolvido.TabIndex = 34
        Me.txtDevolvido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDesconto
        '
        Me.txtDesconto.BackColor = System.Drawing.Color.White
        Me.txtDesconto.ForeColor = System.Drawing.Color.Red
        Me.txtDesconto.Location = New System.Drawing.Point(208, 85)
        Me.txtDesconto.Name = "txtDesconto"
        Me.txtDesconto.ReadOnly = True
        Me.txtDesconto.Size = New System.Drawing.Size(101, 20)
        Me.txtDesconto.TabIndex = 3
        Me.txtDesconto.Text = "0"
        Me.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(143, 88)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 13)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Descontos:"
        '
        'txtAcrescimo
        '
        Me.txtAcrescimo.BackColor = System.Drawing.Color.White
        Me.txtAcrescimo.ForeColor = System.Drawing.Color.Red
        Me.txtAcrescimo.Location = New System.Drawing.Point(209, 62)
        Me.txtAcrescimo.Name = "txtAcrescimo"
        Me.txtAcrescimo.ReadOnly = True
        Me.txtAcrescimo.Size = New System.Drawing.Size(101, 20)
        Me.txtAcrescimo.TabIndex = 2
        Me.txtAcrescimo.Text = "0"
        Me.txtAcrescimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(143, 65)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 13)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Acréscimo:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(154, 188)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 13)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "A Pagar:"
        '
        'txtaPagar
        '
        Me.txtaPagar.BackColor = System.Drawing.Color.White
        Me.txtaPagar.ForeColor = System.Drawing.Color.Blue
        Me.txtaPagar.Location = New System.Drawing.Point(209, 185)
        Me.txtaPagar.Name = "txtaPagar"
        Me.txtaPagar.ReadOnly = True
        Me.txtaPagar.Size = New System.Drawing.Size(101, 20)
        Me.txtaPagar.TabIndex = 6
        Me.txtaPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalPago
        '
        Me.txtTotalPago.BackColor = System.Drawing.Color.White
        Me.txtTotalPago.ForeColor = System.Drawing.Color.Blue
        Me.txtTotalPago.Location = New System.Drawing.Point(209, 135)
        Me.txtTotalPago.Name = "txtTotalPago"
        Me.txtTotalPago.ReadOnly = True
        Me.txtTotalPago.Size = New System.Drawing.Size(101, 20)
        Me.txtTotalPago.TabIndex = 5
        Me.txtTotalPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(140, 138)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Total Pago:"
        '
        'txtTotalProd
        '
        Me.txtTotalProd.BackColor = System.Drawing.Color.White
        Me.txtTotalProd.ForeColor = System.Drawing.Color.Blue
        Me.txtTotalProd.Location = New System.Drawing.Point(209, 14)
        Me.txtTotalProd.Name = "txtTotalProd"
        Me.txtTotalProd.ReadOnly = True
        Me.txtTotalProd.Size = New System.Drawing.Size(101, 20)
        Me.txtTotalProd.TabIndex = 0
        Me.txtTotalProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(109, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Total de Produtos:"
        '
        'txtTotalServ
        '
        Me.txtTotalServ.BackColor = System.Drawing.Color.White
        Me.txtTotalServ.ForeColor = System.Drawing.Color.Blue
        Me.txtTotalServ.Location = New System.Drawing.Point(209, 38)
        Me.txtTotalServ.Name = "txtTotalServ"
        Me.txtTotalServ.ReadOnly = True
        Me.txtTotalServ.Size = New System.Drawing.Size(101, 20)
        Me.txtTotalServ.TabIndex = 1
        Me.txtTotalServ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(110, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Total de Serviços:"
        '
        'txtTotalFatura
        '
        Me.txtTotalFatura.BackColor = System.Drawing.Color.White
        Me.txtTotalFatura.ForeColor = System.Drawing.Color.Blue
        Me.txtTotalFatura.Location = New System.Drawing.Point(209, 109)
        Me.txtTotalFatura.Name = "txtTotalFatura"
        Me.txtTotalFatura.ReadOnly = True
        Me.txtTotalFatura.Size = New System.Drawing.Size(101, 20)
        Me.txtTotalFatura.TabIndex = 4
        Me.txtTotalFatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(121, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Total da Fatura:"
        '
        'grdPedido
        '
        Me.grdPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdPedido.Location = New System.Drawing.Point(368, 30)
        Me.grdPedido.Name = "grdPedido"
        Me.grdPedido.Size = New System.Drawing.Size(240, 150)
        Me.grdPedido.TabIndex = 36
        '
        'txtTextoBoleto
        '
        Me.txtTextoBoleto.Location = New System.Drawing.Point(556, 124)
        Me.txtTextoBoleto.Name = "txtTextoBoleto"
        Me.txtTextoBoleto.Size = New System.Drawing.Size(63, 63)
        Me.txtTextoBoleto.TabIndex = 126
        Me.txtTextoBoleto.Text = resources.GetString("txtTextoBoleto.Text")
        Me.txtTextoBoleto.Visible = False
        '
        'grdRec
        '
        Me.grdRec.AllowUserToAddRows = False
        Me.grdRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdRec.Location = New System.Drawing.Point(7, 19)
        Me.grdRec.Name = "grdRec"
        Me.grdRec.ReadOnly = True
        Me.grdRec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdRec.Size = New System.Drawing.Size(614, 184)
        Me.grdRec.TabIndex = 0
        '
        'lblFilial
        '
        Me.lblFilial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilial.Location = New System.Drawing.Point(438, 25)
        Me.lblFilial.Name = "lblFilial"
        Me.lblFilial.Size = New System.Drawing.Size(30, 13)
        Me.lblFilial.TabIndex = 39
        Me.lblFilial.Text = "Label13"
        Me.lblFilial.Visible = False
        '
        'lblFatura
        '
        Me.lblFatura.AutoSize = True
        Me.lblFatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFatura.Location = New System.Drawing.Point(462, 25)
        Me.lblFatura.Name = "lblFatura"
        Me.lblFatura.Size = New System.Drawing.Size(59, 15)
        Me.lblFatura.TabIndex = 40
        Me.lblFatura.Text = "Label13"
        Me.lblFatura.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(108, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 15)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "Label13"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.grdItens)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 261)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(630, 263)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pedido(s) Incluso(s) na Fatura"
        '
        'grdItens
        '
        Me.grdItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdItens.Location = New System.Drawing.Point(7, 19)
        Me.grdItens.Name = "grdItens"
        Me.grdItens.ReadOnly = True
        Me.grdItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdItens.Size = New System.Drawing.Size(615, 232)
        Me.grdItens.TabIndex = 43
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.grdRec)
        Me.GroupBox3.Controls.Add(Me.txtTextoBoleto)
        Me.GroupBox3.Controls.Add(Me.grdPedido)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 43)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(630, 211)
        Me.GroupBox3.TabIndex = 43
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detalhe Recebimento da Fatura"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(628, 6)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 16)
        Me.Label16.TabIndex = 44
        Me.Label16.Text = "Label16"
        '
        'SplashScreenManager1
        '
        Me.SplashScreenManager1.ClosingDelay = 500
        '
        'frmFatura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(997, 544)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblFatura)
        Me.Controls.Add(Me.lblFilial)
        Me.Controls.Add(Me.lblFilialFatura)
        Me.Controls.Add(Me.grpRec)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFatura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmFatura"
        Me.mnuFaturas.ResumeLayout(False)
        Me.grpRec.ResumeLayout(False)
        Me.grpRec.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdPedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdRec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.grdItens, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents lblFilialFatura As System.Windows.Forms.Label
    Friend WithEvents grpRec As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtVenc As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbForma As System.Windows.Forms.ComboBox
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNparcelas As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtaPagar As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalPago As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTotalProd As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTotalServ As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTotalFatura As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAcrescimo As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents txtDesconto As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents mnuFaturas As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RemoverFaturaDoPedidoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grdRec As System.Windows.Forms.DataGridView
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents lblFilial As System.Windows.Forms.Label
    Friend WithEvents lblFatura As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnExportarPdf As System.Windows.Forms.Button
    Friend WithEvents txtTroco As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblTroco As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnItemPedido As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents grdItens As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents txtDias As System.Windows.Forms.TextBox
    Friend WithEvents cbVencimento As System.Windows.Forms.CheckBox
    Friend WithEvents txtTextoBoleto As System.Windows.Forms.RichTextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtDevolvido As System.Windows.Forms.TextBox
    Friend WithEvents grdPedido As System.Windows.Forms.DataGridView
    Friend WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents btnRecibo As Button
End Class
