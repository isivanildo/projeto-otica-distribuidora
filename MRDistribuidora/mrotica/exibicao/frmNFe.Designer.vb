<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNFe
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNFe))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNovoeDoc = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnGerar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnEmitirNFe = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnImprimirNFe = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnEnviarEmail = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tabPainel = New DevExpress.XtraBars.Navigation.TabPane()
        Me.tabNavNFE = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rbNFCe = New System.Windows.Forms.RadioButton()
        Me.rbNFe = New System.Windows.Forms.RadioButton()
        Me.chkManual = New System.Windows.Forms.CheckBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtObservacao = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.mmMensagemNFe = New System.Windows.Forms.RichTextBox()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbFornecedor = New System.Windows.Forms.ComboBox()
        Me.cbMeioPagamento = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbFormaPagamento = New System.Windows.Forms.ComboBox()
        Me.cbEmitente = New System.Windows.Forms.ComboBox()
        Me.btnLocalizar = New System.Windows.Forms.Button()
        Me.lblNomeCliente = New System.Windows.Forms.Label()
        Me.txtNumFatura = New System.Windows.Forms.TextBox()
        Me.txtFilial = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.cbOperacao = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.txtDescontoProd = New System.Windows.Forms.TextBox()
        Me.txtVUnitario = New System.Windows.Forms.TextBox()
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.lblDescriao = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.grdItens = New System.Windows.Forms.DataGridView()
        Me.txtNumeroNFE = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tabNavTransporte = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbModalidadeFrete = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtQuantidadeFrete = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tabNavOutros = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.mmRetOutros = New System.Windows.Forms.RichTextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtChave = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNFeRef = New System.Windows.Forms.TextBox()
        Me.tabNavCancelar = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.mmRetCanc = New System.Windows.Forms.RichTextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtJustificativaCan = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtChaveCancelamento = New System.Windows.Forms.TextBox()
        Me.SplashScreenManager1 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.BTSistemas.WaitForm1), True, True)
        Me.ToolStrip1.SuspendLayout()
        CType(Me.tabPainel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPainel.SuspendLayout()
        Me.tabNavNFE.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.grdItens, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabNavTransporte.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.tabNavOutros.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tabNavCancelar.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNovoeDoc, Me.ToolStripSeparator2, Me.btnGerar, Me.ToolStripSeparator5, Me.btnEmitirNFe, Me.ToolStripSeparator6, Me.btnImprimirNFe, Me.ToolStripSeparator1, Me.btnEnviarEmail, Me.ToolStripSeparator3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(943, 39)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnNovoeDoc
        '
        Me.btnNovoeDoc.Image = CType(resources.GetObject("btnNovoeDoc.Image"), System.Drawing.Image)
        Me.btnNovoeDoc.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNovoeDoc.Name = "btnNovoeDoc"
        Me.btnNovoeDoc.Size = New System.Drawing.Size(107, 36)
        Me.btnNovoeDoc.Text = "Novo e-Doc"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'btnGerar
        '
        Me.btnGerar.Enabled = False
        Me.btnGerar.Image = CType(resources.GetObject("btnGerar.Image"), System.Drawing.Image)
        Me.btnGerar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGerar.Name = "btnGerar"
        Me.btnGerar.Size = New System.Drawing.Size(106, 36)
        Me.btnGerar.Text = "Gerar e-Doc"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 39)
        '
        'btnEmitirNFe
        '
        Me.btnEmitirNFe.Enabled = False
        Me.btnEmitirNFe.Image = CType(resources.GetObject("btnEmitirNFe.Image"), System.Drawing.Image)
        Me.btnEmitirNFe.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEmitirNFe.Name = "btnEmitirNFe"
        Me.btnEmitirNFe.Size = New System.Drawing.Size(143, 36)
        Me.btnEmitirNFe.Text = "Enviar NF-e/NFC-e"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 39)
        '
        'btnImprimirNFe
        '
        Me.btnImprimirNFe.Enabled = False
        Me.btnImprimirNFe.Image = CType(resources.GetObject("btnImprimirNFe.Image"), System.Drawing.Image)
        Me.btnImprimirNFe.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimirNFe.Name = "btnImprimirNFe"
        Me.btnImprimirNFe.Size = New System.Drawing.Size(118, 36)
        Me.btnImprimirNFe.Text = "Imprimir NF-e"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'btnEnviarEmail
        '
        Me.btnEnviarEmail.Enabled = False
        Me.btnEnviarEmail.Image = CType(resources.GetObject("btnEnviarEmail.Image"), System.Drawing.Image)
        Me.btnEnviarEmail.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEnviarEmail.Name = "btnEnviarEmail"
        Me.btnEnviarEmail.Size = New System.Drawing.Size(138, 36)
        Me.btnEnviarEmail.Text = "Enviar para E-mail"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'tabPainel
        '
        Me.tabPainel.Controls.Add(Me.tabNavNFE)
        Me.tabPainel.Controls.Add(Me.tabNavTransporte)
        Me.tabPainel.Controls.Add(Me.tabNavOutros)
        Me.tabPainel.Controls.Add(Me.tabNavCancelar)
        Me.tabPainel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabPainel.Location = New System.Drawing.Point(0, 39)
        Me.tabPainel.Name = "tabPainel"
        Me.tabPainel.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabNavNFE, Me.tabNavTransporte, Me.tabNavOutros})
        Me.tabPainel.RegularSize = New System.Drawing.Size(943, 601)
        Me.tabPainel.SelectedPage = Me.tabNavNFE
        Me.tabPainel.Size = New System.Drawing.Size(943, 601)
        Me.tabPainel.TabIndex = 2
        Me.tabPainel.Text = "Cancelar NF-e"
        '
        'tabNavNFE
        '
        Me.tabNavNFE.Caption = "NF-e/NFC-e"
        Me.tabNavNFE.Controls.Add(Me.txtModelo)
        Me.tabNavNFE.Controls.Add(Me.Label25)
        Me.tabNavNFE.Controls.Add(Me.GroupBox5)
        Me.tabNavNFE.Controls.Add(Me.chkManual)
        Me.tabNavNFE.Controls.Add(Me.Label22)
        Me.tabNavNFE.Controls.Add(Me.txtObservacao)
        Me.tabNavNFE.Controls.Add(Me.Label9)
        Me.tabNavNFE.Controls.Add(Me.mmMensagemNFe)
        Me.tabNavNFE.Controls.Add(Me.txtSerie)
        Me.tabNavNFE.Controls.Add(Me.Label6)
        Me.tabNavNFE.Controls.Add(Me.cbFornecedor)
        Me.tabNavNFE.Controls.Add(Me.cbMeioPagamento)
        Me.tabNavNFE.Controls.Add(Me.Label5)
        Me.tabNavNFE.Controls.Add(Me.Label2)
        Me.tabNavNFE.Controls.Add(Me.cbFormaPagamento)
        Me.tabNavNFE.Controls.Add(Me.cbEmitente)
        Me.tabNavNFE.Controls.Add(Me.btnLocalizar)
        Me.tabNavNFE.Controls.Add(Me.lblNomeCliente)
        Me.tabNavNFE.Controls.Add(Me.txtNumFatura)
        Me.tabNavNFE.Controls.Add(Me.txtFilial)
        Me.tabNavNFE.Controls.Add(Me.Label32)
        Me.tabNavNFE.Controls.Add(Me.Label31)
        Me.tabNavNFE.Controls.Add(Me.cbOperacao)
        Me.tabNavNFE.Controls.Add(Me.Label1)
        Me.tabNavNFE.Controls.Add(Me.btnAdicionar)
        Me.tabNavNFE.Controls.Add(Me.txtDescontoProd)
        Me.tabNavNFE.Controls.Add(Me.txtVUnitario)
        Me.tabNavNFE.Controls.Add(Me.txtQuantidade)
        Me.tabNavNFE.Controls.Add(Me.lblDescriao)
        Me.tabNavNFE.Controls.Add(Me.txtCodigo)
        Me.tabNavNFE.Controls.Add(Me.Label30)
        Me.tabNavNFE.Controls.Add(Me.Label29)
        Me.tabNavNFE.Controls.Add(Me.Label28)
        Me.tabNavNFE.Controls.Add(Me.Label27)
        Me.tabNavNFE.Controls.Add(Me.Label26)
        Me.tabNavNFE.Controls.Add(Me.grdItens)
        Me.tabNavNFE.Controls.Add(Me.txtNumeroNFE)
        Me.tabNavNFE.Controls.Add(Me.Label8)
        Me.tabNavNFE.Controls.Add(Me.Label7)
        Me.tabNavNFE.Name = "tabNavNFE"
        Me.tabNavNFE.Size = New System.Drawing.Size(943, 574)
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(593, 56)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.ReadOnly = True
        Me.txtModelo.Size = New System.Drawing.Size(31, 20)
        Me.txtModelo.TabIndex = 10
        Me.txtModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(549, 59)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(45, 13)
        Me.Label25.TabIndex = 9
        Me.Label25.Text = "Modelo:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rbNFCe)
        Me.GroupBox5.Controls.Add(Me.rbNFe)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(186, 41)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Tipo Documento"
        '
        'rbNFCe
        '
        Me.rbNFCe.AutoSize = True
        Me.rbNFCe.Location = New System.Drawing.Point(106, 17)
        Me.rbNFCe.Name = "rbNFCe"
        Me.rbNFCe.Size = New System.Drawing.Size(55, 17)
        Me.rbNFCe.TabIndex = 1
        Me.rbNFCe.TabStop = True
        Me.rbNFCe.Text = "NFC-e"
        Me.rbNFCe.UseVisualStyleBackColor = True
        '
        'rbNFe
        '
        Me.rbNFe.AutoSize = True
        Me.rbNFe.Location = New System.Drawing.Point(18, 17)
        Me.rbNFe.Name = "rbNFe"
        Me.rbNFe.Size = New System.Drawing.Size(48, 17)
        Me.rbNFe.TabIndex = 0
        Me.rbNFe.TabStop = True
        Me.rbNFe.Text = "NF-e"
        Me.rbNFe.UseVisualStyleBackColor = True
        '
        'chkManual
        '
        Me.chkManual.AutoSize = True
        Me.chkManual.Location = New System.Drawing.Point(721, 175)
        Me.chkManual.Name = "chkManual"
        Me.chkManual.Size = New System.Drawing.Size(171, 17)
        Me.chkManual.TabIndex = 27
        Me.chkManual.Text = "Lançar Produtos Manualmente"
        Me.chkManual.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(12, 148)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(68, 13)
        Me.Label22.TabIndex = 22
        Me.Label22.Text = "Observação:"
        '
        'txtObservacao
        '
        Me.txtObservacao.Location = New System.Drawing.Point(12, 164)
        Me.txtObservacao.Multiline = True
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.Size = New System.Drawing.Size(622, 49)
        Me.txtObservacao.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(480, 106)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Fornecedor"
        '
        'mmMensagemNFe
        '
        Me.mmMensagemNFe.Location = New System.Drawing.Point(12, 534)
        Me.mmMensagemNFe.Name = "mmMensagemNFe"
        Me.mmMensagemNFe.Size = New System.Drawing.Size(887, 30)
        Me.mmMensagemNFe.TabIndex = 40
        Me.mmMensagemNFe.Text = ""
        '
        'txtSerie
        '
        Me.txtSerie.Location = New System.Drawing.Point(510, 56)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.ReadOnly = True
        Me.txtSerie.Size = New System.Drawing.Size(31, 20)
        Me.txtSerie.TabIndex = 8
        Me.txtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(473, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Serie:"
        '
        'cbFornecedor
        '
        Me.cbFornecedor.Enabled = False
        Me.cbFornecedor.FormattingEnabled = True
        Me.cbFornecedor.Location = New System.Drawing.Point(480, 122)
        Me.cbFornecedor.Name = "cbFornecedor"
        Me.cbFornecedor.Size = New System.Drawing.Size(416, 21)
        Me.cbFornecedor.TabIndex = 21
        '
        'cbMeioPagamento
        '
        Me.cbMeioPagamento.FormattingEnabled = True
        Me.cbMeioPagamento.Location = New System.Drawing.Point(250, 122)
        Me.cbMeioPagamento.Name = "cbMeioPagamento"
        Me.cbMeioPagamento.Size = New System.Drawing.Size(221, 21)
        Me.cbMeioPagamento.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(247, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Meio Pagamento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Forma de Pagamento"
        '
        'cbFormaPagamento
        '
        Me.cbFormaPagamento.FormattingEnabled = True
        Me.cbFormaPagamento.Items.AddRange(New Object() {"Pagamento á Vista", "Pagamento á Prazo"})
        Me.cbFormaPagamento.Location = New System.Drawing.Point(12, 122)
        Me.cbFormaPagamento.Name = "cbFormaPagamento"
        Me.cbFormaPagamento.Size = New System.Drawing.Size(227, 21)
        Me.cbFormaPagamento.TabIndex = 17
        '
        'cbEmitente
        '
        Me.cbEmitente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEmitente.FormattingEnabled = True
        Me.cbEmitente.Location = New System.Drawing.Point(275, 19)
        Me.cbEmitente.Name = "cbEmitente"
        Me.cbEmitente.Size = New System.Drawing.Size(476, 21)
        Me.cbEmitente.TabIndex = 2
        '
        'btnLocalizar
        '
        Me.btnLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLocalizar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnLocalizar.Image = CType(resources.GetObject("btnLocalizar.Image"), System.Drawing.Image)
        Me.btnLocalizar.Location = New System.Drawing.Point(270, 77)
        Me.btnLocalizar.Name = "btnLocalizar"
        Me.btnLocalizar.Size = New System.Drawing.Size(44, 27)
        Me.btnLocalizar.TabIndex = 15
        Me.btnLocalizar.UseVisualStyleBackColor = True
        '
        'lblNomeCliente
        '
        Me.lblNomeCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomeCliente.Location = New System.Drawing.Point(325, 85)
        Me.lblNomeCliente.Name = "lblNomeCliente"
        Me.lblNomeCliente.Size = New System.Drawing.Size(423, 13)
        Me.lblNomeCliente.TabIndex = 18
        '
        'txtNumFatura
        '
        Me.txtNumFatura.Location = New System.Drawing.Point(187, 82)
        Me.txtNumFatura.Name = "txtNumFatura"
        Me.txtNumFatura.Size = New System.Drawing.Size(60, 20)
        Me.txtNumFatura.TabIndex = 14
        Me.txtNumFatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFilial
        '
        Me.txtFilial.Location = New System.Drawing.Point(49, 83)
        Me.txtFilial.Name = "txtFilial"
        Me.txtFilial.Size = New System.Drawing.Size(40, 20)
        Me.txtFilial.TabIndex = 12
        Me.txtFilial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(104, 85)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(80, 13)
        Me.Label32.TabIndex = 13
        Me.Label32.Text = "Numero Fatura:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(17, 86)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(30, 13)
        Me.Label31.TabIndex = 11
        Me.Label31.Text = "Filial:"
        '
        'cbOperacao
        '
        Me.cbOperacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOperacao.FormattingEnabled = True
        Me.cbOperacao.Location = New System.Drawing.Point(97, 53)
        Me.cbOperacao.Name = "cbOperacao"
        Me.cbOperacao.Size = New System.Drawing.Size(237, 21)
        Me.cbOperacao.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tipo Operação:"
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Enabled = False
        Me.btnAdicionar.Image = CType(resources.GetObject("btnAdicionar.Image"), System.Drawing.Image)
        Me.btnAdicionar.Location = New System.Drawing.Point(810, 236)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(75, 27)
        Me.btnAdicionar.TabIndex = 34
        Me.btnAdicionar.Text = "Adicionar"
        Me.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'txtDescontoProd
        '
        Me.txtDescontoProd.Enabled = False
        Me.txtDescontoProd.Location = New System.Drawing.Point(693, 241)
        Me.txtDescontoProd.Name = "txtDescontoProd"
        Me.txtDescontoProd.Size = New System.Drawing.Size(78, 20)
        Me.txtDescontoProd.TabIndex = 33
        Me.txtDescontoProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtVUnitario
        '
        Me.txtVUnitario.Enabled = False
        Me.txtVUnitario.Location = New System.Drawing.Point(598, 241)
        Me.txtVUnitario.Name = "txtVUnitario"
        Me.txtVUnitario.Size = New System.Drawing.Size(78, 20)
        Me.txtVUnitario.TabIndex = 31
        Me.txtVUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Enabled = False
        Me.txtQuantidade.Location = New System.Drawing.Point(525, 241)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(57, 20)
        Me.txtQuantidade.TabIndex = 29
        Me.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblDescriao
        '
        Me.lblDescriao.Location = New System.Drawing.Point(114, 244)
        Me.lblDescriao.Name = "lblDescriao"
        Me.lblDescriao.Size = New System.Drawing.Size(326, 13)
        Me.lblDescriao.TabIndex = 27
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(12, 241)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(92, 20)
        Me.txtCodigo.TabIndex = 25
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(718, 225)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(53, 13)
        Me.Label30.TabIndex = 32
        Me.Label30.Text = "Desconto"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(620, 225)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(56, 13)
        Me.Label29.TabIndex = 30
        Me.Label29.Text = "V. Unitário"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(522, 225)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(62, 13)
        Me.Label28.TabIndex = 28
        Me.Label28.Text = "Quantidade"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(114, 225)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(55, 13)
        Me.Label27.TabIndex = 26
        Me.Label27.Text = "Descrição"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(12, 225)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(40, 13)
        Me.Label26.TabIndex = 24
        Me.Label26.Text = "Código"
        '
        'grdItens
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdItens.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdItens.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdItens.Location = New System.Drawing.Point(12, 267)
        Me.grdItens.Name = "grdItens"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdItens.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grdItens.RowHeadersVisible = False
        Me.grdItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdItens.Size = New System.Drawing.Size(887, 258)
        Me.grdItens.TabIndex = 35
        '
        'txtNumeroNFE
        '
        Me.txtNumeroNFE.Location = New System.Drawing.Point(404, 56)
        Me.txtNumeroNFE.Name = "txtNumeroNFE"
        Me.txtNumeroNFE.ReadOnly = True
        Me.txtNumeroNFE.Size = New System.Drawing.Size(65, 20)
        Me.txtNumeroNFE.TabIndex = 6
        Me.txtNumeroNFE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(343, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Nº da NFe:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(214, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Emitente:"
        '
        'tabNavTransporte
        '
        Me.tabNavTransporte.Caption = "Transporte/Frete"
        Me.tabNavTransporte.Controls.Add(Me.GroupBox2)
        Me.tabNavTransporte.Controls.Add(Me.Panel1)
        Me.tabNavTransporte.Name = "tabNavTransporte"
        Me.tabNavTransporte.Size = New System.Drawing.Size(913, 574)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbModalidadeFrete)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(263, 49)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Modalidade de Frete"
        '
        'cbModalidadeFrete
        '
        Me.cbModalidadeFrete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbModalidadeFrete.FormattingEnabled = True
        Me.cbModalidadeFrete.Location = New System.Drawing.Point(6, 19)
        Me.cbModalidadeFrete.Name = "cbModalidadeFrete"
        Me.cbModalidadeFrete.Size = New System.Drawing.Size(252, 21)
        Me.cbModalidadeFrete.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.TextBox11)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.TextBox12)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.TextBox8)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.TextBox9)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.TextBox10)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.txtQuantidadeFrete)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.TextBox6)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.TextBox5)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Location = New System.Drawing.Point(12, 66)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(715, 96)
        Me.Panel1.TabIndex = 42
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(165, 59)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(70, 13)
        Me.Label20.TabIndex = 69
        Me.Label20.Text = "Peso Líquido"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(240, 59)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(95, 20)
        Me.TextBox11.TabIndex = 9
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 59)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(62, 13)
        Me.Label21.TabIndex = 67
        Me.Label21.Text = "Peso Bruto:"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(74, 59)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(79, 20)
        Me.TextBox12.TabIndex = 8
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(516, 59)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(47, 13)
        Me.Label17.TabIndex = 65
        Me.Label17.Text = "Número:"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(601, 59)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(95, 20)
        Me.TextBox8.TabIndex = 11
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(344, 59)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(40, 13)
        Me.Label18.TabIndex = 63
        Me.Label18.Text = "Marca:"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(414, 59)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(95, 20)
        Me.TextBox9.TabIndex = 10
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(516, 35)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(48, 13)
        Me.Label19.TabIndex = 61
        Me.Label19.Text = "Espécie:"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(601, 35)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(95, 20)
        Me.TextBox10.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(344, 35)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(65, 13)
        Me.Label16.TabIndex = 59
        Me.Label16.Text = "Quantidade:"
        '
        'txtQuantidadeFrete
        '
        Me.txtQuantidadeFrete.Location = New System.Drawing.Point(414, 35)
        Me.txtQuantidadeFrete.Name = "txtQuantidadeFrete"
        Me.txtQuantidadeFrete.Size = New System.Drawing.Size(95, 20)
        Me.txtQuantidadeFrete.TabIndex = 6
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(165, 35)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(24, 13)
        Me.Label15.TabIndex = 57
        Me.Label15.Text = "UF:"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(240, 35)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(95, 20)
        Me.TextBox6.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 35)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 13)
        Me.Label14.TabIndex = 55
        Me.Label14.Text = "Placa:"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(74, 35)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(79, 20)
        Me.TextBox5.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(516, 13)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 13)
        Me.Label13.TabIndex = 52
        Me.Label13.Text = "Transportadora:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(601, 11)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(95, 20)
        Me.TextBox4.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(74, 11)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(79, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(414, 11)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(95, 20)
        Me.TextBox3.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(344, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 13)
        Me.Label12.TabIndex = 47
        Me.Label12.Text = "Acessórios:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Frete:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(240, 11)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(95, 20)
        Me.TextBox2.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(165, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Seguro:"
        '
        'tabNavOutros
        '
        Me.tabNavOutros.Caption = "Outros"
        Me.tabNavOutros.Controls.Add(Me.mmRetOutros)
        Me.tabNavOutros.Controls.Add(Me.GroupBox3)
        Me.tabNavOutros.Controls.Add(Me.GroupBox1)
        Me.tabNavOutros.Name = "tabNavOutros"
        Me.tabNavOutros.Size = New System.Drawing.Size(913, 574)
        '
        'mmRetOutros
        '
        Me.mmRetOutros.Location = New System.Drawing.Point(12, 504)
        Me.mmRetOutros.Name = "mmRetOutros"
        Me.mmRetOutros.Size = New System.Drawing.Size(914, 52)
        Me.mmRetOutros.TabIndex = 149
        Me.mmRetOutros.Text = ""
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtChave)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 105)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(833, 51)
        Me.GroupBox3.TabIndex = 44
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Chave NF-e para impressão"
        '
        'txtChave
        '
        Me.txtChave.Location = New System.Drawing.Point(9, 19)
        Me.txtChave.Name = "txtChave"
        Me.txtChave.Size = New System.Drawing.Size(414, 20)
        Me.txtChave.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNFeRef)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(833, 98)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Devolução"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(272, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Chaves das Notas Fiscais de Referência de Devolução:"
        '
        'txtNFeRef
        '
        Me.txtNFeRef.Location = New System.Drawing.Point(9, 39)
        Me.txtNFeRef.Multiline = True
        Me.txtNFeRef.Name = "txtNFeRef"
        Me.txtNFeRef.Size = New System.Drawing.Size(414, 40)
        Me.txtNFeRef.TabIndex = 1
        '
        'tabNavCancelar
        '
        Me.tabNavCancelar.Caption = "Cancelar NF-e"
        Me.tabNavCancelar.Controls.Add(Me.mmRetCanc)
        Me.tabNavCancelar.Controls.Add(Me.GroupBox4)
        Me.tabNavCancelar.Name = "tabNavCancelar"
        Me.tabNavCancelar.Size = New System.Drawing.Size(943, 574)
        '
        'mmRetCanc
        '
        Me.mmRetCanc.Location = New System.Drawing.Point(12, 504)
        Me.mmRetCanc.Name = "mmRetCanc"
        Me.mmRetCanc.Size = New System.Drawing.Size(914, 52)
        Me.mmRetCanc.TabIndex = 150
        Me.mmRetCanc.Text = ""
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.txtJustificativaCan)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.txtChaveCancelamento)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(833, 160)
        Me.GroupBox4.TabIndex = 149
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Dados para cancelamento da NF-e"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 70)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(173, 13)
        Me.Label24.TabIndex = 149
        Me.Label24.Text = "Justificativa (mínimo 15 caracteres)"
        '
        'txtJustificativaCan
        '
        Me.txtJustificativaCan.Location = New System.Drawing.Point(6, 89)
        Me.txtJustificativaCan.Multiline = True
        Me.txtJustificativaCan.Name = "txtJustificativaCan"
        Me.txtJustificativaCan.Size = New System.Drawing.Size(414, 57)
        Me.txtJustificativaCan.TabIndex = 148
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 20)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(64, 13)
        Me.Label23.TabIndex = 147
        Me.Label23.Text = "Chave NF-e"
        '
        'txtChaveCancelamento
        '
        Me.txtChaveCancelamento.Location = New System.Drawing.Point(6, 39)
        Me.txtChaveCancelamento.Name = "txtChaveCancelamento"
        Me.txtChaveCancelamento.Size = New System.Drawing.Size(414, 20)
        Me.txtChaveCancelamento.TabIndex = 146
        '
        'SplashScreenManager1
        '
        Me.SplashScreenManager1.ClosingDelay = 500
        '
        'frmNFe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 640)
        Me.Controls.Add(Me.tabPainel)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNFe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Emissão NF-e/NFC-e"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.tabPainel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPainel.ResumeLayout(False)
        Me.tabNavNFE.ResumeLayout(False)
        Me.tabNavNFE.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.grdItens, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabNavTransporte.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tabNavOutros.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tabNavCancelar.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnGerar As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents btnEmitirNFe As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents btnImprimirNFe As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnEnviarEmail As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tabPainel As DevExpress.XtraBars.Navigation.TabPane
    Friend WithEvents tabNavNFE As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents rbNFCe As RadioButton
    Friend WithEvents rbNFe As RadioButton
    Friend WithEvents chkManual As CheckBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtObservacao As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents mmMensagemNFe As RichTextBox
    Friend WithEvents txtSerie As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbFornecedor As ComboBox
    Friend WithEvents cbMeioPagamento As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbFormaPagamento As ComboBox
    Friend WithEvents cbEmitente As ComboBox
    Friend WithEvents btnLocalizar As Button
    Friend WithEvents lblNomeCliente As Label
    Friend WithEvents txtNumFatura As TextBox
    Friend WithEvents txtFilial As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents cbOperacao As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdicionar As Button
    Friend WithEvents txtDescontoProd As TextBox
    Friend WithEvents txtVUnitario As TextBox
    Friend WithEvents txtQuantidade As TextBox
    Friend WithEvents lblDescriao As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents grdItens As DataGridView
    Friend WithEvents txtNumeroNFE As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tabNavTransporte As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbModalidadeFrete As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtQuantidadeFrete As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tabNavOutros As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents mmRetOutros As RichTextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtChave As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNFeRef As TextBox
    Friend WithEvents tabNavCancelar As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents mmRetCanc As RichTextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtJustificativaCan As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtChaveCancelamento As TextBox
    Friend WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents btnNovoeDoc As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
End Class
