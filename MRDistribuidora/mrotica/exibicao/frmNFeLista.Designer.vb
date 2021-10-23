<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNFeLista
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNFeLista))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnCancelarNFe = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCCe = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnInutilizar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnImprimirNFe = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnEnviarEmail = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnConsultaNFe = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tabPainel = New DevExpress.XtraBars.Navigation.TabPane()
        Me.tabNavNFE = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.mmMensagemNFe = New System.Windows.Forms.RichTextBox()
        Me.gbTipoDocumento = New System.Windows.Forms.GroupBox()
        Me.rbNFCe = New System.Windows.Forms.RadioButton()
        Me.rbNFe = New System.Windows.Forms.RadioButton()
        Me.cbEmitente = New System.Windows.Forms.ComboBox()
        Me.grdNFe = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tabNavCancelar = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.mmRetornoCancelamento = New System.Windows.Forms.RichTextBox()
        Me.mmRetCanc = New System.Windows.Forms.RichTextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNumNFeCan = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtJustificativaCan = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtChaveCancelamento = New System.Windows.Forms.TextBox()
        Me.tabNavCCe = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.mmRetornoCCe = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNumeroNotaCCe = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescricaoCCe = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtChaveCCe = New System.Windows.Forms.TextBox()
        Me.tabNavInutilizada = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.mmRetornoInutilizada = New System.Windows.Forms.RichTextBox()
        Me.gbInutilizada = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNumeroFinal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNumeroInicial = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtJusInutilizada = New System.Windows.Forms.TextBox()
        Me.SplashScreenManager1 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.BTSistemas.WaitForm1), True, True)
        Me.ToolStrip1.SuspendLayout()
        CType(Me.tabPainel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPainel.SuspendLayout()
        Me.tabNavNFE.SuspendLayout()
        Me.gbTipoDocumento.SuspendLayout()
        CType(Me.grdNFe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabNavCancelar.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.tabNavCCe.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tabNavInutilizada.SuspendLayout()
        Me.gbInutilizada.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelarNFe, Me.ToolStripSeparator6, Me.btnCCe, Me.ToolStripSeparator2, Me.btnInutilizar, Me.ToolStripSeparator5, Me.btnImprimirNFe, Me.ToolStripSeparator1, Me.btnEnviarEmail, Me.ToolStripSeparator3, Me.btnConsultaNFe, Me.ToolStripSeparator4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(923, 39)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnCancelarNFe
        '
        Me.btnCancelarNFe.Enabled = False
        Me.btnCancelarNFe.Image = CType(resources.GetObject("btnCancelarNFe.Image"), System.Drawing.Image)
        Me.btnCancelarNFe.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelarNFe.Name = "btnCancelarNFe"
        Me.btnCancelarNFe.Size = New System.Drawing.Size(157, 36)
        Me.btnCancelarNFe.Text = "Cancelar NF-e/NFC-e"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 39)
        '
        'btnCCe
        '
        Me.btnCCe.Enabled = False
        Me.btnCCe.Image = CType(resources.GetObject("btnCCe.Image"), System.Drawing.Image)
        Me.btnCCe.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCCe.Name = "btnCCe"
        Me.btnCCe.Size = New System.Drawing.Size(100, 36)
        Me.btnCCe.Text = "Enviar CCe"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'btnInutilizar
        '
        Me.btnInutilizar.Enabled = False
        Me.btnInutilizar.Image = CType(resources.GetObject("btnInutilizar.Image"), System.Drawing.Image)
        Me.btnInutilizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnInutilizar.Name = "btnInutilizar"
        Me.btnInutilizar.Size = New System.Drawing.Size(112, 36)
        Me.btnInutilizar.Text = "Inutilizar NFe"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 39)
        '
        'btnImprimirNFe
        '
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
        'btnConsultaNFe
        '
        Me.btnConsultaNFe.Enabled = False
        Me.btnConsultaNFe.Image = CType(resources.GetObject("btnConsultaNFe.Image"), System.Drawing.Image)
        Me.btnConsultaNFe.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnConsultaNFe.Name = "btnConsultaNFe"
        Me.btnConsultaNFe.Size = New System.Drawing.Size(123, 36)
        Me.btnConsultaNFe.Text = "Consultar NF-e"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 39)
        '
        'tabPainel
        '
        Me.tabPainel.Controls.Add(Me.tabNavNFE)
        Me.tabPainel.Controls.Add(Me.tabNavCancelar)
        Me.tabPainel.Controls.Add(Me.tabNavCCe)
        Me.tabPainel.Controls.Add(Me.tabNavInutilizada)
        Me.tabPainel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tabPainel.Location = New System.Drawing.Point(0, 36)
        Me.tabPainel.Name = "tabPainel"
        Me.tabPainel.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabNavNFE, Me.tabNavCancelar, Me.tabNavCCe, Me.tabNavInutilizada})
        Me.tabPainel.RegularSize = New System.Drawing.Size(923, 475)
        Me.tabPainel.SelectedPage = Me.tabNavNFE
        Me.tabPainel.Size = New System.Drawing.Size(923, 475)
        Me.tabPainel.TabIndex = 2
        Me.tabPainel.Text = "Cancelar NF-e"
        '
        'tabNavNFE
        '
        Me.tabNavNFE.Caption = "NF-e/NFC-e"
        Me.tabNavNFE.Controls.Add(Me.mmMensagemNFe)
        Me.tabNavNFE.Controls.Add(Me.gbTipoDocumento)
        Me.tabNavNFE.Controls.Add(Me.cbEmitente)
        Me.tabNavNFE.Controls.Add(Me.grdNFe)
        Me.tabNavNFE.Controls.Add(Me.Label7)
        Me.tabNavNFE.Name = "tabNavNFE"
        Me.tabNavNFE.Size = New System.Drawing.Size(923, 448)
        '
        'mmMensagemNFe
        '
        Me.mmMensagemNFe.Location = New System.Drawing.Point(10, 408)
        Me.mmMensagemNFe.Name = "mmMensagemNFe"
        Me.mmMensagemNFe.ReadOnly = True
        Me.mmMensagemNFe.Size = New System.Drawing.Size(903, 32)
        Me.mmMensagemNFe.TabIndex = 6
        Me.mmMensagemNFe.Text = ""
        '
        'gbTipoDocumento
        '
        Me.gbTipoDocumento.Controls.Add(Me.rbNFCe)
        Me.gbTipoDocumento.Controls.Add(Me.rbNFe)
        Me.gbTipoDocumento.Location = New System.Drawing.Point(12, 11)
        Me.gbTipoDocumento.Name = "gbTipoDocumento"
        Me.gbTipoDocumento.Size = New System.Drawing.Size(186, 41)
        Me.gbTipoDocumento.TabIndex = 2
        Me.gbTipoDocumento.TabStop = False
        Me.gbTipoDocumento.Text = "Tipo Documento"
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
        'cbEmitente
        '
        Me.cbEmitente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEmitente.FormattingEnabled = True
        Me.cbEmitente.Location = New System.Drawing.Point(274, 27)
        Me.cbEmitente.Name = "cbEmitente"
        Me.cbEmitente.Size = New System.Drawing.Size(476, 21)
        Me.cbEmitente.TabIndex = 4
        '
        'grdNFe
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdNFe.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdNFe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdNFe.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdNFe.Location = New System.Drawing.Point(10, 60)
        Me.grdNFe.Name = "grdNFe"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdNFe.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grdNFe.RowHeadersVisible = False
        Me.grdNFe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdNFe.Size = New System.Drawing.Size(903, 339)
        Me.grdNFe.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(211, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Emitente:"
        '
        'tabNavCancelar
        '
        Me.tabNavCancelar.Caption = "Cancelar NF-e"
        Me.tabNavCancelar.Controls.Add(Me.mmRetornoCancelamento)
        Me.tabNavCancelar.Controls.Add(Me.mmRetCanc)
        Me.tabNavCancelar.Controls.Add(Me.GroupBox4)
        Me.tabNavCancelar.Name = "tabNavCancelar"
        Me.tabNavCancelar.Size = New System.Drawing.Size(923, 448)
        '
        'mmRetornoCancelamento
        '
        Me.mmRetornoCancelamento.Location = New System.Drawing.Point(10, 408)
        Me.mmRetornoCancelamento.Name = "mmRetornoCancelamento"
        Me.mmRetornoCancelamento.ReadOnly = True
        Me.mmRetornoCancelamento.Size = New System.Drawing.Size(903, 32)
        Me.mmRetornoCancelamento.TabIndex = 151
        Me.mmRetornoCancelamento.Text = ""
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
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.txtNumNFeCan)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.txtJustificativaCan)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.txtChaveCancelamento)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(833, 198)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Dados para cancelamento da NF-e"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Número Nota"
        '
        'txtNumNFeCan
        '
        Me.txtNumNFeCan.Location = New System.Drawing.Point(6, 43)
        Me.txtNumNFeCan.Name = "txtNumNFeCan"
        Me.txtNumNFeCan.Size = New System.Drawing.Size(70, 20)
        Me.txtNumNFeCan.TabIndex = 9
        Me.txtNumNFeCan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 117)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(173, 13)
        Me.Label24.TabIndex = 12
        Me.Label24.Text = "Justificativa (mínimo 15 caracteres)"
        '
        'txtJustificativaCan
        '
        Me.txtJustificativaCan.Location = New System.Drawing.Point(6, 133)
        Me.txtJustificativaCan.Multiline = True
        Me.txtJustificativaCan.Name = "txtJustificativaCan"
        Me.txtJustificativaCan.Size = New System.Drawing.Size(414, 57)
        Me.txtJustificativaCan.TabIndex = 13
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 72)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(64, 13)
        Me.Label23.TabIndex = 10
        Me.Label23.Text = "Chave NF-e"
        '
        'txtChaveCancelamento
        '
        Me.txtChaveCancelamento.Location = New System.Drawing.Point(6, 88)
        Me.txtChaveCancelamento.Name = "txtChaveCancelamento"
        Me.txtChaveCancelamento.Size = New System.Drawing.Size(414, 20)
        Me.txtChaveCancelamento.TabIndex = 11
        '
        'tabNavCCe
        '
        Me.tabNavCCe.Caption = "Carta Correção (CCe)"
        Me.tabNavCCe.Controls.Add(Me.mmRetornoCCe)
        Me.tabNavCCe.Controls.Add(Me.GroupBox1)
        Me.tabNavCCe.Name = "tabNavCCe"
        Me.tabNavCCe.Size = New System.Drawing.Size(923, 448)
        '
        'mmRetornoCCe
        '
        Me.mmRetornoCCe.Location = New System.Drawing.Point(10, 408)
        Me.mmRetornoCCe.Name = "mmRetornoCCe"
        Me.mmRetornoCCe.ReadOnly = True
        Me.mmRetornoCCe.Size = New System.Drawing.Size(903, 32)
        Me.mmRetornoCCe.TabIndex = 21
        Me.mmRetornoCCe.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNumeroNotaCCe)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtDescricaoCCe)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtChaveCCe)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(833, 198)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados Correção da NF-e"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Número Nota"
        '
        'txtNumeroNotaCCe
        '
        Me.txtNumeroNotaCCe.Location = New System.Drawing.Point(6, 43)
        Me.txtNumeroNotaCCe.Name = "txtNumeroNotaCCe"
        Me.txtNumeroNotaCCe.Size = New System.Drawing.Size(70, 20)
        Me.txtNumeroNotaCCe.TabIndex = 16
        Me.txtNumeroNotaCCe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Texto de Correção (mínimo 15 caracteres)"
        '
        'txtDescricaoCCe
        '
        Me.txtDescricaoCCe.Location = New System.Drawing.Point(6, 133)
        Me.txtDescricaoCCe.Multiline = True
        Me.txtDescricaoCCe.Name = "txtDescricaoCCe"
        Me.txtDescricaoCCe.Size = New System.Drawing.Size(414, 57)
        Me.txtDescricaoCCe.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Chave NF-e"
        '
        'txtChaveCCe
        '
        Me.txtChaveCCe.Location = New System.Drawing.Point(6, 88)
        Me.txtChaveCCe.Name = "txtChaveCCe"
        Me.txtChaveCCe.Size = New System.Drawing.Size(414, 20)
        Me.txtChaveCCe.TabIndex = 18
        '
        'tabNavInutilizada
        '
        Me.tabNavInutilizada.Caption = "NF-e Inutilizada"
        Me.tabNavInutilizada.Controls.Add(Me.mmRetornoInutilizada)
        Me.tabNavInutilizada.Controls.Add(Me.gbInutilizada)
        Me.tabNavInutilizada.Name = "tabNavInutilizada"
        Me.tabNavInutilizada.Size = New System.Drawing.Size(923, 448)
        '
        'mmRetornoInutilizada
        '
        Me.mmRetornoInutilizada.Location = New System.Drawing.Point(10, 408)
        Me.mmRetornoInutilizada.Name = "mmRetornoInutilizada"
        Me.mmRetornoInutilizada.ReadOnly = True
        Me.mmRetornoInutilizada.Size = New System.Drawing.Size(903, 32)
        Me.mmRetornoInutilizada.TabIndex = 23
        Me.mmRetornoInutilizada.Text = ""
        '
        'gbInutilizada
        '
        Me.gbInutilizada.Controls.Add(Me.Label11)
        Me.gbInutilizada.Controls.Add(Me.txtModelo)
        Me.gbInutilizada.Controls.Add(Me.Label10)
        Me.gbInutilizada.Controls.Add(Me.txtSerie)
        Me.gbInutilizada.Controls.Add(Me.Label9)
        Me.gbInutilizada.Controls.Add(Me.txtNumeroFinal)
        Me.gbInutilizada.Controls.Add(Me.Label5)
        Me.gbInutilizada.Controls.Add(Me.txtNumeroInicial)
        Me.gbInutilizada.Controls.Add(Me.Label6)
        Me.gbInutilizada.Controls.Add(Me.txtJusInutilizada)
        Me.gbInutilizada.Location = New System.Drawing.Point(12, 11)
        Me.gbInutilizada.Name = "gbInutilizada"
        Me.gbInutilizada.Size = New System.Drawing.Size(833, 198)
        Me.gbInutilizada.TabIndex = 22
        Me.gbInutilizada.TabStop = False
        Me.gbInutilizada.Text = "Datalhe da Inutilização"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(250, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Modelo"
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(250, 43)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(70, 20)
        Me.txtModelo.TabIndex = 30
        Me.txtModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(169, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Série"
        '
        'txtSerie
        '
        Me.txtSerie.Location = New System.Drawing.Point(169, 43)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(70, 20)
        Me.txtSerie.TabIndex = 28
        Me.txtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(87, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Número Final"
        '
        'txtNumeroFinal
        '
        Me.txtNumeroFinal.Location = New System.Drawing.Point(87, 43)
        Me.txtNumeroFinal.Name = "txtNumeroFinal"
        Me.txtNumeroFinal.Size = New System.Drawing.Size(70, 20)
        Me.txtNumeroFinal.TabIndex = 26
        Me.txtNumeroFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Número Inicial"
        '
        'txtNumeroInicial
        '
        Me.txtNumeroInicial.Location = New System.Drawing.Point(6, 43)
        Me.txtNumeroInicial.Name = "txtNumeroInicial"
        Me.txtNumeroInicial.Size = New System.Drawing.Size(70, 20)
        Me.txtNumeroInicial.TabIndex = 24
        Me.txtNumeroInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Justificativa"
        '
        'txtJusInutilizada
        '
        Me.txtJusInutilizada.Location = New System.Drawing.Point(6, 89)
        Me.txtJusInutilizada.Multiline = True
        Me.txtJusInutilizada.Name = "txtJusInutilizada"
        Me.txtJusInutilizada.Size = New System.Drawing.Size(414, 98)
        Me.txtJusInutilizada.TabIndex = 32
        '
        'SplashScreenManager1
        '
        Me.SplashScreenManager1.ClosingDelay = 500
        '
        'frmNFeLista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 511)
        Me.Controls.Add(Me.tabPainel)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNFeLista"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmNFeLista"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.tabPainel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPainel.ResumeLayout(False)
        Me.tabNavNFE.ResumeLayout(False)
        Me.tabNavNFE.PerformLayout()
        Me.gbTipoDocumento.ResumeLayout(False)
        Me.gbTipoDocumento.PerformLayout()
        CType(Me.grdNFe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabNavCancelar.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.tabNavCCe.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tabNavInutilizada.ResumeLayout(False)
        Me.gbInutilizada.ResumeLayout(False)
        Me.gbInutilizada.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnCancelarNFe As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents btnCCe As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents btnInutilizar As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents btnImprimirNFe As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnEnviarEmail As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents btnConsultaNFe As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents tabPainel As DevExpress.XtraBars.Navigation.TabPane
    Friend WithEvents tabNavNFE As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents mmMensagemNFe As RichTextBox
    Friend WithEvents gbTipoDocumento As GroupBox
    Friend WithEvents rbNFCe As RadioButton
    Friend WithEvents rbNFe As RadioButton
    Friend WithEvents cbEmitente As ComboBox
    Friend WithEvents grdNFe As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents tabNavCancelar As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents mmRetornoCancelamento As RichTextBox
    Friend WithEvents mmRetCanc As RichTextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNumNFeCan As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtJustificativaCan As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtChaveCancelamento As TextBox
    Friend WithEvents tabNavCCe As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents mmRetornoCCe As RichTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNumeroNotaCCe As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDescricaoCCe As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtChaveCCe As TextBox
    Friend WithEvents tabNavInutilizada As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents mmRetornoInutilizada As RichTextBox
    Friend WithEvents gbInutilizada As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtSerie As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtNumeroFinal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNumeroInicial As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtJusInutilizada As TextBox
    Friend WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
End Class
