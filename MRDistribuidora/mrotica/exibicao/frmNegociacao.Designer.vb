<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNegociacao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNegociacao))
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblFilialFatura = New System.Windows.Forms.Label()
        Me.lblNFatura = New System.Windows.Forms.Label()
        Me.txtFilial = New System.Windows.Forms.TextBox()
        Me.txtAcordo = New System.Windows.Forms.TextBox()
        Me.grpRec = New System.Windows.Forms.GroupBox()
        Me.cbVencimento = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtDias = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNparcelas = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbForma = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtVenc = New System.Windows.Forms.DateTimePicker()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAcrescimo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtHistórico = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtValorAcordo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grdRec = New System.Windows.Forms.DataGridView()
        Me.mmNegociacao = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ReceberAcordoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelarRecebimentoAcordoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblDesconto = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblJuros = New System.Windows.Forms.Label()
        Me.txtTaxaJuros = New System.Windows.Forms.TextBox()
        Me.txtTaxas = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblaPagar = New System.Windows.Forms.Label()
        Me.lblTotalPago = New System.Windows.Forms.Label()
        Me.txtJuros = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnGerar = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnComprovante = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnDetalhes = New System.Windows.Forms.ToolStripButton()
        Me.txtTextoBoleto = New System.Windows.Forms.RichTextBox()
        Me.grpRec.SuspendLayout()
        CType(Me.grdRec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mmNegociacao.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Location = New System.Drawing.Point(10, 48)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(142, 13)
        Me.lblCliente.TabIndex = 3
        Me.lblCliente.Text = "Identificação do Cliente"
        '
        'lblFilialFatura
        '
        Me.lblFilialFatura.AutoSize = True
        Me.lblFilialFatura.Location = New System.Drawing.Point(10, 67)
        Me.lblFilialFatura.Name = "lblFilialFatura"
        Me.lblFilialFatura.Size = New System.Drawing.Size(27, 13)
        Me.lblFilialFatura.TabIndex = 4
        Me.lblFilialFatura.Text = "Filial"
        '
        'lblNFatura
        '
        Me.lblNFatura.AutoSize = True
        Me.lblNFatura.Location = New System.Drawing.Point(62, 67)
        Me.lblNFatura.Name = "lblNFatura"
        Me.lblNFatura.Size = New System.Drawing.Size(56, 13)
        Me.lblNFatura.TabIndex = 5
        Me.lblNFatura.Text = "Nº Acordo"
        '
        'txtFilial
        '
        Me.txtFilial.BackColor = System.Drawing.Color.White
        Me.txtFilial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFilial.Location = New System.Drawing.Point(13, 83)
        Me.txtFilial.Name = "txtFilial"
        Me.txtFilial.ReadOnly = True
        Me.txtFilial.Size = New System.Drawing.Size(45, 20)
        Me.txtFilial.TabIndex = 6
        Me.txtFilial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAcordo
        '
        Me.txtAcordo.BackColor = System.Drawing.Color.White
        Me.txtAcordo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAcordo.Location = New System.Drawing.Point(65, 83)
        Me.txtAcordo.Name = "txtAcordo"
        Me.txtAcordo.ReadOnly = True
        Me.txtAcordo.Size = New System.Drawing.Size(86, 20)
        Me.txtAcordo.TabIndex = 7
        Me.txtAcordo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'grpRec
        '
        Me.grpRec.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpRec.Controls.Add(Me.cbVencimento)
        Me.grpRec.Controls.Add(Me.Label14)
        Me.grpRec.Controls.Add(Me.txtDias)
        Me.grpRec.Controls.Add(Me.Label8)
        Me.grpRec.Controls.Add(Me.txtNparcelas)
        Me.grpRec.Controls.Add(Me.Label7)
        Me.grpRec.Controls.Add(Me.txtValor)
        Me.grpRec.Controls.Add(Me.Label6)
        Me.grpRec.Controls.Add(Me.cbForma)
        Me.grpRec.Controls.Add(Me.Label5)
        Me.grpRec.Controls.Add(Me.dtVenc)
        Me.grpRec.Location = New System.Drawing.Point(13, 193)
        Me.grpRec.Name = "grpRec"
        Me.grpRec.Size = New System.Drawing.Size(498, 92)
        Me.grpRec.TabIndex = 16
        Me.grpRec.TabStop = False
        Me.grpRec.Text = "Recebimento"
        '
        'cbVencimento
        '
        Me.cbVencimento.AutoSize = True
        Me.cbVencimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbVencimento.Location = New System.Drawing.Point(10, 64)
        Me.cbVencimento.Name = "cbVencimento"
        Me.cbVencimento.Size = New System.Drawing.Size(132, 17)
        Me.cbVencimento.TabIndex = 14
        Me.cbVencimento.Text = "Vencimento para o dia"
        Me.cbVencimento.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(442, 15)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 13)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Dias"
        '
        'txtDias
        '
        Me.txtDias.Location = New System.Drawing.Point(442, 32)
        Me.txtDias.Name = "txtDias"
        Me.txtDias.Size = New System.Drawing.Size(46, 20)
        Me.txtDias.TabIndex = 12
        Me.txtDias.Text = "0"
        Me.txtDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(349, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Nº de Parcelas"
        '
        'txtNparcelas
        '
        Me.txtNparcelas.Location = New System.Drawing.Point(352, 32)
        Me.txtNparcelas.Name = "txtNparcelas"
        Me.txtNparcelas.Size = New System.Drawing.Size(78, 20)
        Me.txtNparcelas.TabIndex = 8
        Me.txtNparcelas.Text = "1"
        Me.txtNparcelas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(255, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Valor"
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(257, 32)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.ReadOnly = True
        Me.txtValor.Size = New System.Drawing.Size(80, 20)
        Me.txtValor.TabIndex = 6
        Me.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(102, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Forma Pagamento"
        '
        'cbForma
        '
        Me.cbForma.FormattingEnabled = True
        Me.cbForma.Location = New System.Drawing.Point(105, 32)
        Me.cbForma.Name = "cbForma"
        Me.cbForma.Size = New System.Drawing.Size(138, 21)
        Me.cbForma.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Data Vencimento"
        '
        'dtVenc
        '
        Me.dtVenc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtVenc.Location = New System.Drawing.Point(9, 32)
        Me.dtVenc.Name = "dtVenc"
        Me.dtVenc.Size = New System.Drawing.Size(84, 20)
        Me.dtVenc.TabIndex = 2
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(158, 126)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(78, 18)
        Me.lblTotal.TabIndex = 41
        Me.lblTotal.Text = "0,00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Total Atualizado:"
        '
        'txtAcrescimo
        '
        Me.txtAcrescimo.BackColor = System.Drawing.Color.White
        Me.txtAcrescimo.ForeColor = System.Drawing.Color.Red
        Me.txtAcrescimo.Location = New System.Drawing.Point(158, 20)
        Me.txtAcrescimo.Name = "txtAcrescimo"
        Me.txtAcrescimo.ReadOnly = True
        Me.txtAcrescimo.Size = New System.Drawing.Size(76, 20)
        Me.txtAcrescimo.TabIndex = 36
        Me.txtAcrescimo.Text = "0,00"
        Me.txtAcrescimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(26, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 13)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Multa:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(26, 196)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 13)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "A Pagar:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(26, 149)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Total Pago:"
        '
        'txtHistórico
        '
        Me.txtHistórico.BackColor = System.Drawing.Color.White
        Me.txtHistórico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHistórico.Location = New System.Drawing.Point(13, 125)
        Me.txtHistórico.Multiline = True
        Me.txtHistórico.Name = "txtHistórico"
        Me.txtHistórico.ReadOnly = True
        Me.txtHistórico.Size = New System.Drawing.Size(498, 58)
        Me.txtHistórico.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(10, 110)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Histórico"
        '
        'txtValorAcordo
        '
        Me.txtValorAcordo.BackColor = System.Drawing.Color.White
        Me.txtValorAcordo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtValorAcordo.Location = New System.Drawing.Point(158, 83)
        Me.txtValorAcordo.Name = "txtValorAcordo"
        Me.txtValorAcordo.ReadOnly = True
        Me.txtValorAcordo.Size = New System.Drawing.Size(80, 20)
        Me.txtValorAcordo.TabIndex = 25
        Me.txtValorAcordo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(160, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Valor do Débito"
        '
        'grdRec
        '
        Me.grdRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdRec.ContextMenuStrip = Me.mmNegociacao
        Me.grdRec.Location = New System.Drawing.Point(12, 291)
        Me.grdRec.Name = "grdRec"
        Me.grdRec.ReadOnly = True
        Me.grdRec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdRec.Size = New System.Drawing.Size(875, 226)
        Me.grdRec.TabIndex = 27
        '
        'mmNegociacao
        '
        Me.mmNegociacao.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReceberAcordoToolStripMenuItem, Me.CancelarRecebimentoAcordoToolStripMenuItem})
        Me.mmNegociacao.Name = "mmNegociacao"
        Me.mmNegociacao.Size = New System.Drawing.Size(236, 48)
        '
        'ReceberAcordoToolStripMenuItem
        '
        Me.ReceberAcordoToolStripMenuItem.Name = "ReceberAcordoToolStripMenuItem"
        Me.ReceberAcordoToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.ReceberAcordoToolStripMenuItem.Text = "Receber Acordo"
        '
        'CancelarRecebimentoAcordoToolStripMenuItem
        '
        Me.CancelarRecebimentoAcordoToolStripMenuItem.Name = "CancelarRecebimentoAcordoToolStripMenuItem"
        Me.CancelarRecebimentoAcordoToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.CancelarRecebimentoAcordoToolStripMenuItem.Text = "Cancelar Recebimento Acordo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblDesconto)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.lblJuros)
        Me.GroupBox1.Controls.Add(Me.txtTaxaJuros)
        Me.GroupBox1.Controls.Add(Me.txtTaxas)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblaPagar)
        Me.GroupBox1.Controls.Add(Me.lblTotalPago)
        Me.GroupBox1.Controls.Add(Me.txtJuros)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtAcrescimo)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Location = New System.Drawing.Point(642, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(241, 223)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Totais"
        '
        'lblDesconto
        '
        Me.lblDesconto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesconto.ForeColor = System.Drawing.Color.Blue
        Me.lblDesconto.Location = New System.Drawing.Point(158, 172)
        Me.lblDesconto.Name = "lblDesconto"
        Me.lblDesconto.Size = New System.Drawing.Size(78, 18)
        Me.lblDesconto.TabIndex = 47
        Me.lblDesconto.Text = "0,00"
        Me.lblDesconto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(26, 73)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(92, 13)
        Me.Label15.TabIndex = 46
        Me.Label15.Text = "Juros Negociados"
        '
        'lblJuros
        '
        Me.lblJuros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJuros.ForeColor = System.Drawing.Color.Blue
        Me.lblJuros.Location = New System.Drawing.Point(166, 72)
        Me.lblJuros.Name = "lblJuros"
        Me.lblJuros.Size = New System.Drawing.Size(68, 17)
        Me.lblJuros.TabIndex = 45
        Me.lblJuros.Text = "0,00"
        Me.lblJuros.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtTaxaJuros
        '
        Me.txtTaxaJuros.BackColor = System.Drawing.Color.White
        Me.txtTaxaJuros.ForeColor = System.Drawing.Color.Blue
        Me.txtTaxaJuros.Location = New System.Drawing.Point(121, 70)
        Me.txtTaxaJuros.Name = "txtTaxaJuros"
        Me.txtTaxaJuros.Size = New System.Drawing.Size(32, 20)
        Me.txtTaxaJuros.TabIndex = 44
        Me.txtTaxaJuros.Text = "0"
        Me.txtTaxaJuros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTaxas
        '
        Me.txtTaxas.BackColor = System.Drawing.Color.White
        Me.txtTaxas.ForeColor = System.Drawing.Color.Red
        Me.txtTaxas.Location = New System.Drawing.Point(158, 95)
        Me.txtTaxas.Name = "txtTaxas"
        Me.txtTaxas.Size = New System.Drawing.Size(76, 20)
        Me.txtTaxas.TabIndex = 39
        Me.txtTaxas.Text = "0,00"
        Me.txtTaxas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(26, 100)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 13)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "Taxas:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(26, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Desconto:"
        '
        'lblaPagar
        '
        Me.lblaPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblaPagar.Location = New System.Drawing.Point(158, 196)
        Me.lblaPagar.Name = "lblaPagar"
        Me.lblaPagar.Size = New System.Drawing.Size(78, 18)
        Me.lblaPagar.TabIndex = 40
        Me.lblaPagar.Text = "0,00"
        Me.lblaPagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalPago
        '
        Me.lblTotalPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPago.ForeColor = System.Drawing.Color.Blue
        Me.lblTotalPago.Location = New System.Drawing.Point(158, 149)
        Me.lblTotalPago.Name = "lblTotalPago"
        Me.lblTotalPago.Size = New System.Drawing.Size(78, 18)
        Me.lblTotalPago.TabIndex = 39
        Me.lblTotalPago.Text = "0,00"
        Me.lblTotalPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtJuros
        '
        Me.txtJuros.BackColor = System.Drawing.Color.White
        Me.txtJuros.ForeColor = System.Drawing.Color.Red
        Me.txtJuros.Location = New System.Drawing.Point(158, 46)
        Me.txtJuros.Name = "txtJuros"
        Me.txtJuros.ReadOnly = True
        Me.txtJuros.Size = New System.Drawing.Size(76, 20)
        Me.txtJuros.TabIndex = 38
        Me.txtJuros.Text = "0,00"
        Me.txtJuros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Juros:"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btnGerar, Me.ToolStripSeparator2, Me.btnCancelar, Me.ToolStripSeparator3, Me.btnComprovante, Me.ToolStripSeparator4, Me.btnDetalhes})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(901, 39)
        Me.ToolStrip1.TabIndex = 40
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnGerar
        '
        Me.btnGerar.Image = CType(resources.GetObject("btnGerar.Image"), System.Drawing.Image)
        Me.btnGerar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGerar.Name = "btnGerar"
        Me.btnGerar.Size = New System.Drawing.Size(113, 36)
        Me.btnGerar.Text = "Gerar Acordo"
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(131, 36)
        Me.btnCancelar.Text = "Cancelar Acordo"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'btnComprovante
        '
        Me.btnComprovante.Image = CType(resources.GetObject("btnComprovante.Image"), System.Drawing.Image)
        Me.btnComprovante.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnComprovante.Name = "btnComprovante"
        Me.btnComprovante.Size = New System.Drawing.Size(116, 36)
        Me.btnComprovante.Text = "Comprovante"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 39)
        '
        'btnDetalhes
        '
        Me.btnDetalhes.Enabled = False
        Me.btnDetalhes.Image = CType(resources.GetObject("btnDetalhes.Image"), System.Drawing.Image)
        Me.btnDetalhes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDetalhes.Name = "btnDetalhes"
        Me.btnDetalhes.Size = New System.Drawing.Size(133, 36)
        Me.btnDetalhes.Text = "Detalhe Contrato"
        '
        'txtTextoBoleto
        '
        Me.txtTextoBoleto.Location = New System.Drawing.Point(584, 292)
        Me.txtTextoBoleto.Name = "txtTextoBoleto"
        Me.txtTextoBoleto.Size = New System.Drawing.Size(63, 63)
        Me.txtTextoBoleto.TabIndex = 128
        Me.txtTextoBoleto.Text = resources.GetString("txtTextoBoleto.Text")
        Me.txtTextoBoleto.Visible = False
        '
        'frmNegociacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(901, 529)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grdRec)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtValorAcordo)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtHistórico)
        Me.Controls.Add(Me.grpRec)
        Me.Controls.Add(Me.txtAcordo)
        Me.Controls.Add(Me.txtFilial)
        Me.Controls.Add(Me.lblNFatura)
        Me.Controls.Add(Me.lblFilialFatura)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.txtTextoBoleto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNegociacao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Negociação"
        Me.grpRec.ResumeLayout(False)
        Me.grpRec.PerformLayout()
        CType(Me.grdRec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mmNegociacao.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents lblFilialFatura As System.Windows.Forms.Label
    Friend WithEvents lblNFatura As System.Windows.Forms.Label
    Friend WithEvents txtFilial As System.Windows.Forms.TextBox
    Friend WithEvents txtAcordo As System.Windows.Forms.TextBox
    Friend WithEvents grpRec As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtVenc As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbForma As System.Windows.Forms.ComboBox
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNparcelas As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtHistórico As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtValorAcordo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAcrescimo As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents grdRec As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblaPagar As System.Windows.Forms.Label
    Friend WithEvents lblTotalPago As System.Windows.Forms.Label
    Friend WithEvents txtJuros As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents mmNegociacao As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ReceberAcordoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelarRecebimentoAcordoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTaxas As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtDias As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGerar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnComprovante As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents cbVencimento As System.Windows.Forms.CheckBox
    Friend WithEvents txtTextoBoleto As System.Windows.Forms.RichTextBox
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnDetalhes As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtTaxaJuros As System.Windows.Forms.TextBox
    Friend WithEvents lblJuros As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblDesconto As System.Windows.Forms.Label
End Class
