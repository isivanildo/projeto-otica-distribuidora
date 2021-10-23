Imports System.Data
Imports System.Data.SqlClient
Imports System.Globalization
Imports mrotica_util
Imports MRUtil

Public Class frmLentes_blocos
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Friend WithEvents tabLentes As System.Windows.Forms.TabPage
    Friend WithEvents lblStatusLentes As System.Windows.Forms.Label
    Friend WithEvents txtPreco As System.Windows.Forms.TextBox
    Friend WithEvents txtFatorPreco As System.Windows.Forms.TextBox
    Friend WithEvents txtlenteCodBarra As System.Windows.Forms.TextBox
    Friend WithEvents txtLenteCilindrico As System.Windows.Forms.TextBox
    Friend WithEvents txtLenteEsferico As System.Windows.Forms.TextBox
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents rdCil As System.Windows.Forms.RadioButton
    Friend WithEvents rdEsf As System.Windows.Forms.RadioButton
    Friend WithEvents chkFiltroBarrasLentes As System.Windows.Forms.CheckBox
    Friend WithEvents chkEstoqueLentes As System.Windows.Forms.CheckBox
    Friend WithEvents btnLentesIntervalo As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents tabBases As System.Windows.Forms.TabPage
    Friend WithEvents txtPrecoBloco As System.Windows.Forms.TextBox
    Friend WithEvents txtFatorPrecoBloco As System.Windows.Forms.TextBox
    Friend WithEvents txtCodBarrasBloco As System.Windows.Forms.TextBox
    Friend WithEvents txtEsfMenorBloco As System.Windows.Forms.TextBox
    Friend WithEvents txtEsfMaiorBloco As System.Windows.Forms.TextBox
    Friend WithEvents txtOlho As System.Windows.Forms.TextBox
    Friend WithEvents txtAdicao As System.Windows.Forms.TextBox
    Friend WithEvents txtBase As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tb2 As System.Windows.Forms.TabControl
    Friend WithEvents tab_Bloco_surfacado As System.Windows.Forms.TabPage
    Friend WithEvents txtPrecoBlocoSurf As System.Windows.Forms.TextBox
    Friend WithEvents txtFatorPrecoSurf As System.Windows.Forms.TextBox
    Friend WithEvents txtCodBarrasSurf As System.Windows.Forms.TextBox
    Friend WithEvents txtEsfSurf As System.Windows.Forms.TextBox
    Friend WithEvents txtCilindricoSurf As System.Windows.Forms.TextBox
    Friend WithEvents txtOlhoSurf As System.Windows.Forms.TextBox
    Friend WithEvents txtAdicaoSurf As System.Windows.Forms.TextBox
    Friend WithEvents txtBaseSurf As System.Windows.Forms.TextBox
    Friend WithEvents chkEstoqueSurf As System.Windows.Forms.CheckBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents grd_Bloco_surf As System.Windows.Forms.DataGrid
    Friend WithEvents pnlSalvarSurf As System.Windows.Forms.Panel
    Friend WithEvents btnCancelarBlocoSurf As System.Windows.Forms.Button
    Friend WithEvents btnSalvarBlocoSurf As System.Windows.Forms.Button
    Friend WithEvents pnlNovoBlocoSurf As System.Windows.Forms.Panel
    Friend WithEvents btnDeletarBlocoSurf As System.Windows.Forms.Button
    Friend WithEvents btnEditarBlocoSurf As System.Windows.Forms.Button
    Friend WithEvents btnNovoBlocoSurf As System.Windows.Forms.Button
    Friend WithEvents btnLimparBlocoSurf As System.Windows.Forms.Button
    Friend WithEvents pbBlocoSurf As System.Windows.Forms.ProgressBar
    Friend WithEvents lblStatusBlocoSurf As System.Windows.Forms.Label
    Friend WithEvents tabLenteContato As System.Windows.Forms.TabPage
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents txtPrecoContato As System.Windows.Forms.TextBox
    Friend WithEvents txtFatorPrecoContato As System.Windows.Forms.TextBox
    Friend WithEvents txtCodBarraContato As System.Windows.Forms.TextBox
    Friend WithEvents txtCilContato As System.Windows.Forms.TextBox
    Friend WithEvents txtEsfContato As System.Windows.Forms.TextBox
    Friend WithEvents btnLimparContato As System.Windows.Forms.Button
    Friend WithEvents chkEstoqueContato As System.Windows.Forms.CheckBox
    Friend WithEvents btnIntervaloContato As System.Windows.Forms.Button
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents grdContato As System.Windows.Forms.DataGrid
    Friend WithEvents pnlNovoContato As System.Windows.Forms.Panel
    Friend WithEvents btnDeletarContato As System.Windows.Forms.Button
    Friend WithEvents btnEditarContato As System.Windows.Forms.Button
    Friend WithEvents btnNovoContato As System.Windows.Forms.Button
    Friend WithEvents txtBaseContato As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents pnlSalvarContato As System.Windows.Forms.Panel
    Friend WithEvents btnCancelarContato As System.Windows.Forms.Button
    Friend WithEvents btnSalvarContato As System.Windows.Forms.Button
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents txtBlocoOrigem As System.Windows.Forms.TextBox
    Friend WithEvents mnuOrigemBloco As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mniAdicionarBlocoOrigem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniExcluirBlocoOrigem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnLimparBlocos As System.Windows.Forms.Button
    Friend WithEvents mnuGrdLentes As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AlterarContainerDeLentesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnExportaLentes As System.Windows.Forms.Button
    Friend WithEvents pbGeral As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents btnExportaBase As System.Windows.Forms.Button
    Friend WithEvents grdLentes As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnCancelarLente As System.Windows.Forms.Button
    Friend WithEvents btnSalvarLente As System.Windows.Forms.Button
    Friend WithEvents btnEditarLente As System.Windows.Forms.Button
    Friend WithEvents btnNovaLente As System.Windows.Forms.Button
    Friend WithEvents btnDeletarLente As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents grdBloco As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnDeletarBloco As System.Windows.Forms.Button
    Friend WithEvents btnCancelarBloco As System.Windows.Forms.Button
    Friend WithEvents btnSalvarBloco As System.Windows.Forms.Button
    Friend WithEvents btnEditarBloco As System.Windows.Forms.Button
    Friend WithEvents btnNovoBloco As System.Windows.Forms.Button
    Friend WithEvents btnAdFaixaBase As System.Windows.Forms.Button
    Friend WithEvents txtCilFiltro As System.Windows.Forms.TextBox
    Friend WithEvents tabPrinc As TabPage
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label46 As Label
    Friend WithEvents txtPrecoNota As TextBox
    Friend WithEvents Label47 As Label
    Friend WithEvents txtDescontoCompra As TextBox
    Friend WithEvents Label48 As Label
    Friend WithEvents txtPrecoCompra As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtPrecoFinal As TextBox
    Friend WithEvents Label45 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents txtDescontoVenda As TextBox
    Friend WithEvents Label50 As Label
    Friend WithEvents txtPrecoVenda As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtGtin As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents txtUnidade As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents txtTributacao As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents txtNCM As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtAdicaoDisponivel As TextBox
    Friend WithEvents Label51 As Label
    Friend WithEvents txtDisponibilidade As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtDiametro As TextBox
    Friend WithEvents txtABBE As TextBox
    Friend WithEvents txtACOminimo As TextBox
    Friend WithEvents txtIR As TextBox
    Friend WithEvents txtAdMenor As TextBox
    Friend WithEvents txtAdiMaior As TextBox
    Friend WithEvents txtCilMenor As TextBox
    Friend WithEvents txtEsfMenor As TextBox
    Friend WithEvents txtEsfMaior As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents Label44 As Label
    Friend WithEvents cbEspecie As ComboBox
    Friend WithEvents btnPesCod As Button
    Friend WithEvents chkAtivo As CheckBox
    Friend WithEvents Label27 As Label
    Friend WithEvents txtCodTabela As TextBox
    Friend WithEvents txtCaracteristicas As TextBox
    Friend WithEvents txtNomeProduto As TextBox
    Friend WithEvents txtCodLente As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents cbMaterial As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbTipo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbFabricante As ComboBox
    Friend WithEvents Fabricante As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnExportaDados As Button
    Friend WithEvents txtNomeComercial As TextBox
    Friend WithEvents Label52 As Label
    Friend WithEvents cbOrigem As ComboBox
    Friend WithEvents Label54 As Label
    Friend WithEvents txtReferencia As TextBox
    Friend WithEvents Label53 As Label
    Friend WithEvents txtCodigoBarra As TextBox
    Friend WithEvents btnAdicionar As Button
    Friend WithEvents cbEstoque As CheckBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnAlterar As Button
    Friend WithEvents btnNovo As Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLentes_blocos))
        Me.tabLentes = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCilFiltro = New System.Windows.Forms.TextBox()
        Me.btnExportaLentes = New System.Windows.Forms.Button()
        Me.btnLentesIntervalo = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnDeletarLente = New System.Windows.Forms.Button()
        Me.btnCancelarLente = New System.Windows.Forms.Button()
        Me.btnSalvarLente = New System.Windows.Forms.Button()
        Me.btnEditarLente = New System.Windows.Forms.Button()
        Me.btnNovaLente = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdCil = New System.Windows.Forms.RadioButton()
        Me.rdEsf = New System.Windows.Forms.RadioButton()
        Me.chkFiltroBarrasLentes = New System.Windows.Forms.CheckBox()
        Me.grdLentes = New System.Windows.Forms.DataGridView()
        Me.lblStatusLentes = New System.Windows.Forms.Label()
        Me.txtPreco = New System.Windows.Forms.TextBox()
        Me.txtFatorPreco = New System.Windows.Forms.TextBox()
        Me.txtlenteCodBarra = New System.Windows.Forms.TextBox()
        Me.txtLenteCilindrico = New System.Windows.Forms.TextBox()
        Me.txtLenteEsferico = New System.Windows.Forms.TextBox()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.chkEstoqueLentes = New System.Windows.Forms.CheckBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.mnuGrdLentes = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AlterarContainerDeLentesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tabBases = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnAdFaixaBase = New System.Windows.Forms.Button()
        Me.btnDeletarBloco = New System.Windows.Forms.Button()
        Me.btnCancelarBloco = New System.Windows.Forms.Button()
        Me.btnSalvarBloco = New System.Windows.Forms.Button()
        Me.btnExportaBase = New System.Windows.Forms.Button()
        Me.btnEditarBloco = New System.Windows.Forms.Button()
        Me.btnNovoBloco = New System.Windows.Forms.Button()
        Me.grdBloco = New System.Windows.Forms.DataGridView()
        Me.btnLimparBlocos = New System.Windows.Forms.Button()
        Me.txtPrecoBloco = New System.Windows.Forms.TextBox()
        Me.txtFatorPrecoBloco = New System.Windows.Forms.TextBox()
        Me.txtCodBarrasBloco = New System.Windows.Forms.TextBox()
        Me.txtEsfMenorBloco = New System.Windows.Forms.TextBox()
        Me.txtEsfMaiorBloco = New System.Windows.Forms.TextBox()
        Me.txtOlho = New System.Windows.Forms.TextBox()
        Me.txtAdicao = New System.Windows.Forms.TextBox()
        Me.txtBase = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tb2 = New System.Windows.Forms.TabControl()
        Me.tabPrinc = New System.Windows.Forms.TabPage()
        Me.cbEstoque = New System.Windows.Forms.CheckBox()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.txtReferencia = New System.Windows.Forms.TextBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.txtCodigoBarra = New System.Windows.Forms.TextBox()
        Me.txtNomeComercial = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.txtPrecoNota = New System.Windows.Forms.TextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.txtDescontoCompra = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.txtPrecoCompra = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtPrecoFinal = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.txtDescontoVenda = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.txtPrecoVenda = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cbOrigem = New System.Windows.Forms.ComboBox()
        Me.txtGtin = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtUnidade = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtTributacao = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtNCM = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtAdicaoDisponivel = New System.Windows.Forms.TextBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.txtDisponibilidade = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtDiametro = New System.Windows.Forms.TextBox()
        Me.txtABBE = New System.Windows.Forms.TextBox()
        Me.txtACOminimo = New System.Windows.Forms.TextBox()
        Me.txtIR = New System.Windows.Forms.TextBox()
        Me.txtAdMenor = New System.Windows.Forms.TextBox()
        Me.txtAdiMaior = New System.Windows.Forms.TextBox()
        Me.txtCilMenor = New System.Windows.Forms.TextBox()
        Me.txtEsfMenor = New System.Windows.Forms.TextBox()
        Me.txtEsfMaior = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.cbEspecie = New System.Windows.Forms.ComboBox()
        Me.chkAtivo = New System.Windows.Forms.CheckBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtCodTabela = New System.Windows.Forms.TextBox()
        Me.txtCaracteristicas = New System.Windows.Forms.TextBox()
        Me.txtNomeProduto = New System.Windows.Forms.TextBox()
        Me.txtCodLente = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cbMaterial = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbFabricante = New System.Windows.Forms.ComboBox()
        Me.Fabricante = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnPesCod = New System.Windows.Forms.Button()
        Me.btnExportaDados = New System.Windows.Forms.Button()
        Me.tab_Bloco_surfacado = New System.Windows.Forms.TabPage()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.txtBlocoOrigem = New System.Windows.Forms.TextBox()
        Me.mnuOrigemBloco = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mniAdicionarBlocoOrigem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniExcluirBlocoOrigem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblStatusBlocoSurf = New System.Windows.Forms.Label()
        Me.pbBlocoSurf = New System.Windows.Forms.ProgressBar()
        Me.btnLimparBlocoSurf = New System.Windows.Forms.Button()
        Me.txtPrecoBlocoSurf = New System.Windows.Forms.TextBox()
        Me.txtFatorPrecoSurf = New System.Windows.Forms.TextBox()
        Me.txtCodBarrasSurf = New System.Windows.Forms.TextBox()
        Me.txtEsfSurf = New System.Windows.Forms.TextBox()
        Me.txtCilindricoSurf = New System.Windows.Forms.TextBox()
        Me.txtOlhoSurf = New System.Windows.Forms.TextBox()
        Me.txtAdicaoSurf = New System.Windows.Forms.TextBox()
        Me.txtBaseSurf = New System.Windows.Forms.TextBox()
        Me.chkEstoqueSurf = New System.Windows.Forms.CheckBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.grd_Bloco_surf = New System.Windows.Forms.DataGrid()
        Me.pnlSalvarSurf = New System.Windows.Forms.Panel()
        Me.btnCancelarBlocoSurf = New System.Windows.Forms.Button()
        Me.btnSalvarBlocoSurf = New System.Windows.Forms.Button()
        Me.pnlNovoBlocoSurf = New System.Windows.Forms.Panel()
        Me.btnDeletarBlocoSurf = New System.Windows.Forms.Button()
        Me.btnEditarBlocoSurf = New System.Windows.Forms.Button()
        Me.btnNovoBlocoSurf = New System.Windows.Forms.Button()
        Me.tabLenteContato = New System.Windows.Forms.TabPage()
        Me.pnlSalvarContato = New System.Windows.Forms.Panel()
        Me.btnCancelarContato = New System.Windows.Forms.Button()
        Me.btnSalvarContato = New System.Windows.Forms.Button()
        Me.txtBaseContato = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txtPrecoContato = New System.Windows.Forms.TextBox()
        Me.txtFatorPrecoContato = New System.Windows.Forms.TextBox()
        Me.txtCodBarraContato = New System.Windows.Forms.TextBox()
        Me.txtCilContato = New System.Windows.Forms.TextBox()
        Me.txtEsfContato = New System.Windows.Forms.TextBox()
        Me.btnLimparContato = New System.Windows.Forms.Button()
        Me.chkEstoqueContato = New System.Windows.Forms.CheckBox()
        Me.btnIntervaloContato = New System.Windows.Forms.Button()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.grdContato = New System.Windows.Forms.DataGrid()
        Me.pnlNovoContato = New System.Windows.Forms.Panel()
        Me.btnDeletarContato = New System.Windows.Forms.Button()
        Me.btnEditarContato = New System.Windows.Forms.Button()
        Me.btnNovoContato = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pbGeral = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tabLentes.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdLentes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuGrdLentes.SuspendLayout()
        Me.tabBases.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.grdBloco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tb2.SuspendLayout()
        Me.tabPrinc.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.tab_Bloco_surfacado.SuspendLayout()
        Me.mnuOrigemBloco.SuspendLayout()
        CType(Me.grd_Bloco_surf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSalvarSurf.SuspendLayout()
        Me.pnlNovoBlocoSurf.SuspendLayout()
        Me.tabLenteContato.SuspendLayout()
        Me.pnlSalvarContato.SuspendLayout()
        CType(Me.grdContato, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlNovoContato.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabLentes
        '
        Me.tabLentes.Controls.Add(Me.GroupBox2)
        Me.tabLentes.Controls.Add(Me.Panel2)
        Me.tabLentes.Controls.Add(Me.GroupBox1)
        Me.tabLentes.Controls.Add(Me.grdLentes)
        Me.tabLentes.Controls.Add(Me.lblStatusLentes)
        Me.tabLentes.Controls.Add(Me.txtPreco)
        Me.tabLentes.Controls.Add(Me.txtFatorPreco)
        Me.tabLentes.Controls.Add(Me.txtlenteCodBarra)
        Me.tabLentes.Controls.Add(Me.txtLenteCilindrico)
        Me.tabLentes.Controls.Add(Me.txtLenteEsferico)
        Me.tabLentes.Controls.Add(Me.btnLimpar)
        Me.tabLentes.Controls.Add(Me.chkEstoqueLentes)
        Me.tabLentes.Controls.Add(Me.Label19)
        Me.tabLentes.Controls.Add(Me.Label21)
        Me.tabLentes.Controls.Add(Me.Label22)
        Me.tabLentes.Location = New System.Drawing.Point(4, 22)
        Me.tabLentes.Name = "tabLentes"
        Me.tabLentes.Size = New System.Drawing.Size(696, 557)
        Me.tabLentes.TabIndex = 2
        Me.tabLentes.Text = "Lentes"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCilFiltro)
        Me.GroupBox2.Controls.Add(Me.btnExportaLentes)
        Me.GroupBox2.Controls.Add(Me.btnLentesIntervalo)
        Me.GroupBox2.Location = New System.Drawing.Point(441, 136)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 133)
        Me.GroupBox2.TabIndex = 75
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opções"
        '
        'txtCilFiltro
        '
        Me.txtCilFiltro.Location = New System.Drawing.Point(96, 71)
        Me.txtCilFiltro.Name = "txtCilFiltro"
        Me.txtCilFiltro.Size = New System.Drawing.Size(82, 20)
        Me.txtCilFiltro.TabIndex = 8
        '
        'btnExportaLentes
        '
        Me.btnExportaLentes.Image = CType(resources.GetObject("btnExportaLentes.Image"), System.Drawing.Image)
        Me.btnExportaLentes.Location = New System.Drawing.Point(112, 17)
        Me.btnExportaLentes.Name = "btnExportaLentes"
        Me.btnExportaLentes.Size = New System.Drawing.Size(82, 34)
        Me.btnExportaLentes.TabIndex = 5
        Me.btnExportaLentes.Text = "Exportar"
        Me.btnExportaLentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btnExportaLentes, "Exporta as dioptrias para a fila de exportação.")
        Me.btnExportaLentes.UseVisualStyleBackColor = True
        '
        'btnLentesIntervalo
        '
        Me.btnLentesIntervalo.Image = CType(resources.GetObject("btnLentesIntervalo.Image"), System.Drawing.Image)
        Me.btnLentesIntervalo.Location = New System.Drawing.Point(6, 17)
        Me.btnLentesIntervalo.Name = "btnLentesIntervalo"
        Me.btnLentesIntervalo.Size = New System.Drawing.Size(105, 34)
        Me.btnLentesIntervalo.TabIndex = 6
        Me.btnLentesIntervalo.Text = "Cadastrar por Intervalo"
        Me.btnLentesIntervalo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLentesIntervalo.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnDeletarLente)
        Me.Panel2.Controls.Add(Me.btnCancelarLente)
        Me.Panel2.Controls.Add(Me.btnSalvarLente)
        Me.Panel2.Controls.Add(Me.btnEditarLente)
        Me.Panel2.Controls.Add(Me.btnNovaLente)
        Me.Panel2.Location = New System.Drawing.Point(8, 345)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(406, 44)
        Me.Panel2.TabIndex = 1
        '
        'btnDeletarLente
        '
        Me.btnDeletarLente.Image = CType(resources.GetObject("btnDeletarLente.Image"), System.Drawing.Image)
        Me.btnDeletarLente.Location = New System.Drawing.Point(159, 4)
        Me.btnDeletarLente.Name = "btnDeletarLente"
        Me.btnDeletarLente.Size = New System.Drawing.Size(75, 34)
        Me.btnDeletarLente.TabIndex = 2
        Me.btnDeletarLente.Text = "Excluir"
        Me.btnDeletarLente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDeletarLente.UseVisualStyleBackColor = True
        '
        'btnCancelarLente
        '
        Me.btnCancelarLente.Enabled = False
        Me.btnCancelarLente.Image = CType(resources.GetObject("btnCancelarLente.Image"), System.Drawing.Image)
        Me.btnCancelarLente.Location = New System.Drawing.Point(313, 4)
        Me.btnCancelarLente.Name = "btnCancelarLente"
        Me.btnCancelarLente.Size = New System.Drawing.Size(87, 34)
        Me.btnCancelarLente.TabIndex = 4
        Me.btnCancelarLente.Text = "Cancelar"
        Me.btnCancelarLente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelarLente.UseVisualStyleBackColor = True
        '
        'btnSalvarLente
        '
        Me.btnSalvarLente.Enabled = False
        Me.btnSalvarLente.Image = CType(resources.GetObject("btnSalvarLente.Image"), System.Drawing.Image)
        Me.btnSalvarLente.Location = New System.Drawing.Point(236, 4)
        Me.btnSalvarLente.Name = "btnSalvarLente"
        Me.btnSalvarLente.Size = New System.Drawing.Size(75, 34)
        Me.btnSalvarLente.TabIndex = 3
        Me.btnSalvarLente.Text = "Salvar"
        Me.btnSalvarLente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvarLente.UseVisualStyleBackColor = True
        '
        'btnEditarLente
        '
        Me.btnEditarLente.Image = CType(resources.GetObject("btnEditarLente.Image"), System.Drawing.Image)
        Me.btnEditarLente.Location = New System.Drawing.Point(81, 4)
        Me.btnEditarLente.Name = "btnEditarLente"
        Me.btnEditarLente.Size = New System.Drawing.Size(75, 34)
        Me.btnEditarLente.TabIndex = 1
        Me.btnEditarLente.Text = "Editar"
        Me.btnEditarLente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditarLente.UseVisualStyleBackColor = True
        '
        'btnNovaLente
        '
        Me.btnNovaLente.Image = CType(resources.GetObject("btnNovaLente.Image"), System.Drawing.Image)
        Me.btnNovaLente.Location = New System.Drawing.Point(4, 4)
        Me.btnNovaLente.Name = "btnNovaLente"
        Me.btnNovaLente.Size = New System.Drawing.Size(75, 34)
        Me.btnNovaLente.TabIndex = 0
        Me.btnNovaLente.Text = "Novo"
        Me.btnNovaLente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNovaLente.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdCil)
        Me.GroupBox1.Controls.Add(Me.rdEsf)
        Me.GroupBox1.Controls.Add(Me.chkFiltroBarrasLentes)
        Me.GroupBox1.Location = New System.Drawing.Point(441, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 104)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ordernar"
        '
        'rdCil
        '
        Me.rdCil.AutoSize = True
        Me.rdCil.Checked = True
        Me.rdCil.Location = New System.Drawing.Point(8, 19)
        Me.rdCil.Name = "rdCil"
        Me.rdCil.Size = New System.Drawing.Size(122, 17)
        Me.rdCil.TabIndex = 0
        Me.rdCil.TabStop = True
        Me.rdCil.Text = "Ordenar p/ Cilindrico"
        Me.rdCil.UseVisualStyleBackColor = True
        '
        'rdEsf
        '
        Me.rdEsf.AutoSize = True
        Me.rdEsf.Location = New System.Drawing.Point(8, 41)
        Me.rdEsf.Name = "rdEsf"
        Me.rdEsf.Size = New System.Drawing.Size(118, 17)
        Me.rdEsf.TabIndex = 1
        Me.rdEsf.Text = "Ordenar p/ Esférico"
        Me.rdEsf.UseVisualStyleBackColor = True
        '
        'chkFiltroBarrasLentes
        '
        Me.chkFiltroBarrasLentes.AutoSize = True
        Me.chkFiltroBarrasLentes.Location = New System.Drawing.Point(8, 81)
        Me.chkFiltroBarrasLentes.Name = "chkFiltroBarrasLentes"
        Me.chkFiltroBarrasLentes.Size = New System.Drawing.Size(189, 17)
        Me.chkFiltroBarrasLentes.TabIndex = 2
        Me.chkFiltroBarrasLentes.Text = "Exibir produto sem código de barra"
        Me.chkFiltroBarrasLentes.UseVisualStyleBackColor = True
        '
        'grdLentes
        '
        Me.grdLentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdLentes.Location = New System.Drawing.Point(11, 13)
        Me.grdLentes.Name = "grdLentes"
        Me.grdLentes.ReadOnly = True
        Me.grdLentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdLentes.Size = New System.Drawing.Size(422, 272)
        Me.grdLentes.TabIndex = 0
        '
        'lblStatusLentes
        '
        Me.lblStatusLentes.Location = New System.Drawing.Point(11, 395)
        Me.lblStatusLentes.Name = "lblStatusLentes"
        Me.lblStatusLentes.Size = New System.Drawing.Size(413, 23)
        Me.lblStatusLentes.TabIndex = 74
        '
        'txtPreco
        '
        Me.txtPreco.BackColor = System.Drawing.Color.White
        Me.txtPreco.Location = New System.Drawing.Point(287, 313)
        Me.txtPreco.Name = "txtPreco"
        Me.txtPreco.Size = New System.Drawing.Size(68, 20)
        Me.txtPreco.TabIndex = 6
        '
        'txtFatorPreco
        '
        Me.txtFatorPreco.BackColor = System.Drawing.Color.White
        Me.txtFatorPreco.Location = New System.Drawing.Point(210, 312)
        Me.txtFatorPreco.Name = "txtFatorPreco"
        Me.txtFatorPreco.Size = New System.Drawing.Size(68, 20)
        Me.txtFatorPreco.TabIndex = 5
        Me.txtFatorPreco.Text = "1"
        '
        'txtlenteCodBarra
        '
        Me.txtlenteCodBarra.BackColor = System.Drawing.Color.White
        Me.txtlenteCodBarra.Location = New System.Drawing.Point(129, 312)
        Me.txtlenteCodBarra.Name = "txtlenteCodBarra"
        Me.txtlenteCodBarra.Size = New System.Drawing.Size(72, 20)
        Me.txtlenteCodBarra.TabIndex = 4
        '
        'txtLenteCilindrico
        '
        Me.txtLenteCilindrico.BackColor = System.Drawing.Color.White
        Me.txtLenteCilindrico.Location = New System.Drawing.Point(68, 312)
        Me.txtLenteCilindrico.Name = "txtLenteCilindrico"
        Me.txtLenteCilindrico.Size = New System.Drawing.Size(52, 20)
        Me.txtLenteCilindrico.TabIndex = 3
        '
        'txtLenteEsferico
        '
        Me.txtLenteEsferico.BackColor = System.Drawing.Color.White
        Me.txtLenteEsferico.Location = New System.Drawing.Point(8, 312)
        Me.txtLenteEsferico.Name = "txtLenteEsferico"
        Me.txtLenteEsferico.Size = New System.Drawing.Size(52, 20)
        Me.txtLenteEsferico.TabIndex = 2
        '
        'btnLimpar
        '
        Me.btnLimpar.BackColor = System.Drawing.Color.AliceBlue
        Me.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpar.Location = New System.Drawing.Point(548, 404)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(52, 23)
        Me.btnLimpar.TabIndex = 70
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = False
        Me.btnLimpar.Visible = False
        '
        'chkEstoqueLentes
        '
        Me.chkEstoqueLentes.AutoSize = True
        Me.chkEstoqueLentes.Location = New System.Drawing.Point(365, 314)
        Me.chkEstoqueLentes.Name = "chkEstoqueLentes"
        Me.chkEstoqueLentes.Size = New System.Drawing.Size(65, 17)
        Me.chkEstoqueLentes.TabIndex = 7
        Me.chkEstoqueLentes.Text = "Estoque"
        Me.chkEstoqueLentes.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(129, 296)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(88, 16)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "Código Barras"
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(68, 296)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(56, 16)
        Me.Label21.TabIndex = 16
        Me.Label21.Text = "Cilindrico"
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(8, 296)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(48, 16)
        Me.Label22.TabIndex = 14
        Me.Label22.Text = "Esférico"
        '
        'mnuGrdLentes
        '
        Me.mnuGrdLentes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlterarContainerDeLentesToolStripMenuItem})
        Me.mnuGrdLentes.Name = "mnuGrdLentes"
        Me.mnuGrdLentes.Size = New System.Drawing.Size(218, 26)
        '
        'AlterarContainerDeLentesToolStripMenuItem
        '
        Me.AlterarContainerDeLentesToolStripMenuItem.Name = "AlterarContainerDeLentesToolStripMenuItem"
        Me.AlterarContainerDeLentesToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.AlterarContainerDeLentesToolStripMenuItem.Text = "Alterar Container de Lentes"
        '
        'tabBases
        '
        Me.tabBases.Controls.Add(Me.Panel3)
        Me.tabBases.Controls.Add(Me.grdBloco)
        Me.tabBases.Controls.Add(Me.btnLimparBlocos)
        Me.tabBases.Controls.Add(Me.txtPrecoBloco)
        Me.tabBases.Controls.Add(Me.txtFatorPrecoBloco)
        Me.tabBases.Controls.Add(Me.txtCodBarrasBloco)
        Me.tabBases.Controls.Add(Me.txtEsfMenorBloco)
        Me.tabBases.Controls.Add(Me.txtEsfMaiorBloco)
        Me.tabBases.Controls.Add(Me.txtOlho)
        Me.tabBases.Controls.Add(Me.txtAdicao)
        Me.tabBases.Controls.Add(Me.txtBase)
        Me.tabBases.Controls.Add(Me.Label18)
        Me.tabBases.Controls.Add(Me.Label17)
        Me.tabBases.Controls.Add(Me.Label16)
        Me.tabBases.Controls.Add(Me.Label15)
        Me.tabBases.Controls.Add(Me.Label14)
        Me.tabBases.Controls.Add(Me.Label7)
        Me.tabBases.Location = New System.Drawing.Point(4, 22)
        Me.tabBases.Name = "tabBases"
        Me.tabBases.Size = New System.Drawing.Size(696, 557)
        Me.tabBases.TabIndex = 1
        Me.tabBases.Text = "Bases"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btnAdFaixaBase)
        Me.Panel3.Controls.Add(Me.btnDeletarBloco)
        Me.Panel3.Controls.Add(Me.btnCancelarBloco)
        Me.Panel3.Controls.Add(Me.btnSalvarBloco)
        Me.Panel3.Controls.Add(Me.btnExportaBase)
        Me.Panel3.Controls.Add(Me.btnEditarBloco)
        Me.Panel3.Controls.Add(Me.btnNovoBloco)
        Me.Panel3.Location = New System.Drawing.Point(7, 340)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(486, 44)
        Me.Panel3.TabIndex = 11
        '
        'btnAdFaixaBase
        '
        Me.btnAdFaixaBase.Image = CType(resources.GetObject("btnAdFaixaBase.Image"), System.Drawing.Image)
        Me.btnAdFaixaBase.Location = New System.Drawing.Point(465, 4)
        Me.btnAdFaixaBase.Name = "btnAdFaixaBase"
        Me.btnAdFaixaBase.Size = New System.Drawing.Size(81, 34)
        Me.btnAdFaixaBase.TabIndex = 6
        Me.btnAdFaixaBase.Text = "Ad. Faixa Base"
        Me.btnAdFaixaBase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdFaixaBase.UseVisualStyleBackColor = True
        Me.btnAdFaixaBase.Visible = False
        '
        'btnDeletarBloco
        '
        Me.btnDeletarBloco.Image = CType(resources.GetObject("btnDeletarBloco.Image"), System.Drawing.Image)
        Me.btnDeletarBloco.Location = New System.Drawing.Point(159, 4)
        Me.btnDeletarBloco.Name = "btnDeletarBloco"
        Me.btnDeletarBloco.Size = New System.Drawing.Size(75, 34)
        Me.btnDeletarBloco.TabIndex = 2
        Me.btnDeletarBloco.Text = "Excluir"
        Me.btnDeletarBloco.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDeletarBloco.UseVisualStyleBackColor = True
        '
        'btnCancelarBloco
        '
        Me.btnCancelarBloco.Enabled = False
        Me.btnCancelarBloco.Image = CType(resources.GetObject("btnCancelarBloco.Image"), System.Drawing.Image)
        Me.btnCancelarBloco.Location = New System.Drawing.Point(313, 4)
        Me.btnCancelarBloco.Name = "btnCancelarBloco"
        Me.btnCancelarBloco.Size = New System.Drawing.Size(87, 34)
        Me.btnCancelarBloco.TabIndex = 4
        Me.btnCancelarBloco.Text = "Cancelar"
        Me.btnCancelarBloco.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelarBloco.UseVisualStyleBackColor = True
        '
        'btnSalvarBloco
        '
        Me.btnSalvarBloco.Enabled = False
        Me.btnSalvarBloco.Image = CType(resources.GetObject("btnSalvarBloco.Image"), System.Drawing.Image)
        Me.btnSalvarBloco.Location = New System.Drawing.Point(236, 4)
        Me.btnSalvarBloco.Name = "btnSalvarBloco"
        Me.btnSalvarBloco.Size = New System.Drawing.Size(75, 34)
        Me.btnSalvarBloco.TabIndex = 3
        Me.btnSalvarBloco.Text = "Salvar"
        Me.btnSalvarBloco.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvarBloco.UseVisualStyleBackColor = True
        '
        'btnExportaBase
        '
        Me.btnExportaBase.Image = CType(resources.GetObject("btnExportaBase.Image"), System.Drawing.Image)
        Me.btnExportaBase.Location = New System.Drawing.Point(412, 4)
        Me.btnExportaBase.Name = "btnExportaBase"
        Me.btnExportaBase.Size = New System.Drawing.Size(66, 34)
        Me.btnExportaBase.TabIndex = 5
        Me.btnExportaBase.Text = "Exportar"
        Me.btnExportaBase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btnExportaBase, "exportar os blocos para a fila de exportação.")
        Me.btnExportaBase.UseVisualStyleBackColor = True
        Me.btnExportaBase.Visible = False
        '
        'btnEditarBloco
        '
        Me.btnEditarBloco.Image = CType(resources.GetObject("btnEditarBloco.Image"), System.Drawing.Image)
        Me.btnEditarBloco.Location = New System.Drawing.Point(81, 4)
        Me.btnEditarBloco.Name = "btnEditarBloco"
        Me.btnEditarBloco.Size = New System.Drawing.Size(75, 34)
        Me.btnEditarBloco.TabIndex = 1
        Me.btnEditarBloco.Text = "Editar"
        Me.btnEditarBloco.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditarBloco.UseVisualStyleBackColor = True
        '
        'btnNovoBloco
        '
        Me.btnNovoBloco.Image = CType(resources.GetObject("btnNovoBloco.Image"), System.Drawing.Image)
        Me.btnNovoBloco.Location = New System.Drawing.Point(4, 4)
        Me.btnNovoBloco.Name = "btnNovoBloco"
        Me.btnNovoBloco.Size = New System.Drawing.Size(75, 34)
        Me.btnNovoBloco.TabIndex = 0
        Me.btnNovoBloco.Text = "Novo"
        Me.btnNovoBloco.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNovoBloco.UseVisualStyleBackColor = True
        '
        'grdBloco
        '
        Me.grdBloco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBloco.Location = New System.Drawing.Point(8, 16)
        Me.grdBloco.Name = "grdBloco"
        Me.grdBloco.ReadOnly = True
        Me.grdBloco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdBloco.Size = New System.Drawing.Size(630, 259)
        Me.grdBloco.TabIndex = 0
        '
        'btnLimparBlocos
        '
        Me.btnLimparBlocos.BackColor = System.Drawing.Color.AliceBlue
        Me.btnLimparBlocos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimparBlocos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimparBlocos.Location = New System.Drawing.Point(420, 390)
        Me.btnLimparBlocos.Name = "btnLimparBlocos"
        Me.btnLimparBlocos.Size = New System.Drawing.Size(68, 23)
        Me.btnLimparBlocos.TabIndex = 76
        Me.btnLimparBlocos.Text = "Limpar"
        Me.btnLimparBlocos.UseVisualStyleBackColor = False
        '
        'txtPrecoBloco
        '
        Me.txtPrecoBloco.BackColor = System.Drawing.Color.White
        Me.txtPrecoBloco.Location = New System.Drawing.Point(462, 305)
        Me.txtPrecoBloco.Name = "txtPrecoBloco"
        Me.txtPrecoBloco.Size = New System.Drawing.Size(62, 20)
        Me.txtPrecoBloco.TabIndex = 8
        '
        'txtFatorPrecoBloco
        '
        Me.txtFatorPrecoBloco.BackColor = System.Drawing.Color.White
        Me.txtFatorPrecoBloco.Location = New System.Drawing.Point(391, 305)
        Me.txtFatorPrecoBloco.Name = "txtFatorPrecoBloco"
        Me.txtFatorPrecoBloco.Size = New System.Drawing.Size(62, 20)
        Me.txtFatorPrecoBloco.TabIndex = 7
        '
        'txtCodBarrasBloco
        '
        Me.txtCodBarrasBloco.BackColor = System.Drawing.Color.White
        Me.txtCodBarrasBloco.Location = New System.Drawing.Point(312, 305)
        Me.txtCodBarrasBloco.Name = "txtCodBarrasBloco"
        Me.txtCodBarrasBloco.Size = New System.Drawing.Size(72, 20)
        Me.txtCodBarrasBloco.TabIndex = 6
        '
        'txtEsfMenorBloco
        '
        Me.txtEsfMenorBloco.BackColor = System.Drawing.Color.White
        Me.txtEsfMenorBloco.Location = New System.Drawing.Point(169, 305)
        Me.txtEsfMenorBloco.Name = "txtEsfMenorBloco"
        Me.txtEsfMenorBloco.Size = New System.Drawing.Size(64, 20)
        Me.txtEsfMenorBloco.TabIndex = 4
        '
        'txtEsfMaiorBloco
        '
        Me.txtEsfMaiorBloco.BackColor = System.Drawing.Color.White
        Me.txtEsfMaiorBloco.Location = New System.Drawing.Point(240, 305)
        Me.txtEsfMaiorBloco.Name = "txtEsfMaiorBloco"
        Me.txtEsfMaiorBloco.Size = New System.Drawing.Size(64, 20)
        Me.txtEsfMaiorBloco.TabIndex = 5
        '
        'txtOlho
        '
        Me.txtOlho.BackColor = System.Drawing.Color.White
        Me.txtOlho.Location = New System.Drawing.Point(138, 305)
        Me.txtOlho.MaxLength = 1
        Me.txtOlho.Name = "txtOlho"
        Me.txtOlho.Size = New System.Drawing.Size(24, 20)
        Me.txtOlho.TabIndex = 3
        '
        'txtAdicao
        '
        Me.txtAdicao.BackColor = System.Drawing.Color.White
        Me.txtAdicao.Location = New System.Drawing.Point(82, 305)
        Me.txtAdicao.Name = "txtAdicao"
        Me.txtAdicao.Size = New System.Drawing.Size(50, 20)
        Me.txtAdicao.TabIndex = 2
        '
        'txtBase
        '
        Me.txtBase.BackColor = System.Drawing.Color.White
        Me.txtBase.Location = New System.Drawing.Point(8, 305)
        Me.txtBase.Name = "txtBase"
        Me.txtBase.Size = New System.Drawing.Size(68, 20)
        Me.txtBase.TabIndex = 1
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(312, 289)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(88, 16)
        Me.Label18.TabIndex = 13
        Me.Label18.Text = "Código Barras"
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(169, 289)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 16)
        Me.Label17.TabIndex = 11
        Me.Label17.Text = "Esf. Menor"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(240, 289)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 16)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "Esf. Maior"
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(138, 289)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 16)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "Olho"
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(82, 289)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 16)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Adição"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 289)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Base Nominal"
        '
        'tb2
        '
        Me.tb2.Controls.Add(Me.tabPrinc)
        Me.tb2.Controls.Add(Me.tabBases)
        Me.tb2.Controls.Add(Me.tabLentes)
        Me.tb2.Controls.Add(Me.tab_Bloco_surfacado)
        Me.tb2.Controls.Add(Me.tabLenteContato)
        Me.tb2.Location = New System.Drawing.Point(8, 6)
        Me.tb2.Name = "tb2"
        Me.tb2.SelectedIndex = 0
        Me.tb2.Size = New System.Drawing.Size(704, 583)
        Me.tb2.TabIndex = 0
        '
        'tabPrinc
        '
        Me.tabPrinc.Controls.Add(Me.cbEstoque)
        Me.tabPrinc.Controls.Add(Me.btnAdicionar)
        Me.tabPrinc.Controls.Add(Me.Label54)
        Me.tabPrinc.Controls.Add(Me.txtReferencia)
        Me.tabPrinc.Controls.Add(Me.Label53)
        Me.tabPrinc.Controls.Add(Me.txtCodigoBarra)
        Me.tabPrinc.Controls.Add(Me.txtNomeComercial)
        Me.tabPrinc.Controls.Add(Me.Label52)
        Me.tabPrinc.Controls.Add(Me.GroupBox6)
        Me.tabPrinc.Controls.Add(Me.GroupBox5)
        Me.tabPrinc.Controls.Add(Me.GroupBox4)
        Me.tabPrinc.Controls.Add(Me.GroupBox3)
        Me.tabPrinc.Controls.Add(Me.txtSaldo)
        Me.tabPrinc.Controls.Add(Me.Label44)
        Me.tabPrinc.Controls.Add(Me.cbEspecie)
        Me.tabPrinc.Controls.Add(Me.chkAtivo)
        Me.tabPrinc.Controls.Add(Me.Label27)
        Me.tabPrinc.Controls.Add(Me.txtCodTabela)
        Me.tabPrinc.Controls.Add(Me.txtCaracteristicas)
        Me.tabPrinc.Controls.Add(Me.txtNomeProduto)
        Me.tabPrinc.Controls.Add(Me.txtCodLente)
        Me.tabPrinc.Controls.Add(Me.Label23)
        Me.tabPrinc.Controls.Add(Me.cbMaterial)
        Me.tabPrinc.Controls.Add(Me.Label20)
        Me.tabPrinc.Controls.Add(Me.Label4)
        Me.tabPrinc.Controls.Add(Me.Label3)
        Me.tabPrinc.Controls.Add(Me.cbTipo)
        Me.tabPrinc.Controls.Add(Me.Label2)
        Me.tabPrinc.Controls.Add(Me.cbFabricante)
        Me.tabPrinc.Controls.Add(Me.Fabricante)
        Me.tabPrinc.Controls.Add(Me.Label1)
        Me.tabPrinc.Controls.Add(Me.Panel1)
        Me.tabPrinc.Location = New System.Drawing.Point(4, 22)
        Me.tabPrinc.Name = "tabPrinc"
        Me.tabPrinc.Size = New System.Drawing.Size(696, 557)
        Me.tabPrinc.TabIndex = 0
        Me.tabPrinc.Text = "Cadastro de Lentes e Blocos"
        '
        'cbEstoque
        '
        Me.cbEstoque.AutoSize = True
        Me.cbEstoque.Checked = True
        Me.cbEstoque.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbEstoque.Location = New System.Drawing.Point(578, 26)
        Me.cbEstoque.Name = "cbEstoque"
        Me.cbEstoque.Size = New System.Drawing.Size(107, 17)
        Me.cbEstoque.TabIndex = 37
        Me.cbEstoque.Text = "Controla Estoque"
        Me.cbEstoque.UseVisualStyleBackColor = True
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Enabled = False
        Me.btnAdicionar.Image = CType(resources.GetObject("btnAdicionar.Image"), System.Drawing.Image)
        Me.btnAdicionar.Location = New System.Drawing.Point(341, 22)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(36, 26)
        Me.btnAdicionar.TabIndex = 36
        Me.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'Label54
        '
        Me.Label54.Location = New System.Drawing.Point(496, 92)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(62, 16)
        Me.Label54.TabIndex = 18
        Me.Label54.Text = "Referência"
        '
        'txtReferencia
        '
        Me.txtReferencia.BackColor = System.Drawing.Color.White
        Me.txtReferencia.Location = New System.Drawing.Point(497, 109)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(153, 20)
        Me.txtReferencia.TabIndex = 19
        '
        'Label53
        '
        Me.Label53.Location = New System.Drawing.Point(378, 92)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(90, 16)
        Me.Label53.TabIndex = 16
        Me.Label53.Text = "Código de Barra"
        '
        'txtCodigoBarra
        '
        Me.txtCodigoBarra.BackColor = System.Drawing.Color.White
        Me.txtCodigoBarra.Location = New System.Drawing.Point(377, 109)
        Me.txtCodigoBarra.Name = "txtCodigoBarra"
        Me.txtCodigoBarra.Size = New System.Drawing.Size(111, 20)
        Me.txtCodigoBarra.TabIndex = 17
        '
        'txtNomeComercial
        '
        Me.txtNomeComercial.BackColor = System.Drawing.Color.White
        Me.txtNomeComercial.Location = New System.Drawing.Point(8, 109)
        Me.txtNomeComercial.Name = "txtNomeComercial"
        Me.txtNomeComercial.Size = New System.Drawing.Size(358, 20)
        Me.txtNomeComercial.TabIndex = 15
        '
        'Label52
        '
        Me.Label52.Location = New System.Drawing.Point(8, 92)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(95, 16)
        Me.Label52.TabIndex = 14
        Me.Label52.Text = "Nome Comercial"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label46)
        Me.GroupBox6.Controls.Add(Me.txtPrecoNota)
        Me.GroupBox6.Controls.Add(Me.Label47)
        Me.GroupBox6.Controls.Add(Me.txtDescontoCompra)
        Me.GroupBox6.Controls.Add(Me.Label48)
        Me.GroupBox6.Controls.Add(Me.txtPrecoCompra)
        Me.GroupBox6.Location = New System.Drawing.Point(278, 315)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(271, 60)
        Me.GroupBox6.TabIndex = 23
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Preço Compra"
        '
        'Label46
        '
        Me.Label46.Location = New System.Drawing.Point(180, 16)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(63, 16)
        Me.Label46.TabIndex = 4
        Me.Label46.Text = "Preço Nota"
        '
        'txtPrecoNota
        '
        Me.txtPrecoNota.BackColor = System.Drawing.Color.White
        Me.txtPrecoNota.Location = New System.Drawing.Point(180, 33)
        Me.txtPrecoNota.Name = "txtPrecoNota"
        Me.txtPrecoNota.Size = New System.Drawing.Size(80, 20)
        Me.txtPrecoNota.TabIndex = 5
        Me.txtPrecoNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label47
        '
        Me.Label47.Location = New System.Drawing.Point(94, 16)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(71, 16)
        Me.Label47.TabIndex = 2
        Me.Label47.Text = "Desconto (%)"
        '
        'txtDescontoCompra
        '
        Me.txtDescontoCompra.BackColor = System.Drawing.Color.White
        Me.txtDescontoCompra.Location = New System.Drawing.Point(94, 33)
        Me.txtDescontoCompra.Name = "txtDescontoCompra"
        Me.txtDescontoCompra.Size = New System.Drawing.Size(80, 20)
        Me.txtDescontoCompra.TabIndex = 3
        Me.txtDescontoCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label48
        '
        Me.Label48.Location = New System.Drawing.Point(6, 16)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(82, 16)
        Me.Label48.TabIndex = 0
        Me.Label48.Text = "Preço Compra"
        '
        'txtPrecoCompra
        '
        Me.txtPrecoCompra.BackColor = System.Drawing.Color.White
        Me.txtPrecoCompra.Location = New System.Drawing.Point(6, 33)
        Me.txtPrecoCompra.Name = "txtPrecoCompra"
        Me.txtPrecoCompra.Size = New System.Drawing.Size(80, 20)
        Me.txtPrecoCompra.TabIndex = 1
        Me.txtPrecoCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtPrecoFinal)
        Me.GroupBox5.Controls.Add(Me.Label45)
        Me.GroupBox5.Controls.Add(Me.Label49)
        Me.GroupBox5.Controls.Add(Me.txtDescontoVenda)
        Me.GroupBox5.Controls.Add(Me.Label50)
        Me.GroupBox5.Controls.Add(Me.txtPrecoVenda)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 315)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(263, 60)
        Me.GroupBox5.TabIndex = 22
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Preço Venda"
        '
        'txtPrecoFinal
        '
        Me.txtPrecoFinal.BackColor = System.Drawing.Color.White
        Me.txtPrecoFinal.Location = New System.Drawing.Point(177, 34)
        Me.txtPrecoFinal.Name = "txtPrecoFinal"
        Me.txtPrecoFinal.Size = New System.Drawing.Size(80, 20)
        Me.txtPrecoFinal.TabIndex = 5
        Me.txtPrecoFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label45
        '
        Me.Label45.Location = New System.Drawing.Point(177, 17)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(63, 16)
        Me.Label45.TabIndex = 4
        Me.Label45.Text = "Preço Final"
        '
        'Label49
        '
        Me.Label49.Location = New System.Drawing.Point(92, 17)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(71, 16)
        Me.Label49.TabIndex = 2
        Me.Label49.Text = "Desconto (%)"
        '
        'txtDescontoVenda
        '
        Me.txtDescontoVenda.BackColor = System.Drawing.Color.White
        Me.txtDescontoVenda.Location = New System.Drawing.Point(92, 34)
        Me.txtDescontoVenda.Name = "txtDescontoVenda"
        Me.txtDescontoVenda.Size = New System.Drawing.Size(80, 20)
        Me.txtDescontoVenda.TabIndex = 3
        Me.txtDescontoVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label50
        '
        Me.Label50.Location = New System.Drawing.Point(7, 17)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(72, 16)
        Me.Label50.TabIndex = 0
        Me.Label50.Text = "Preço Venda"
        '
        'txtPrecoVenda
        '
        Me.txtPrecoVenda.BackColor = System.Drawing.Color.White
        Me.txtPrecoVenda.Location = New System.Drawing.Point(7, 34)
        Me.txtPrecoVenda.Name = "txtPrecoVenda"
        Me.txtPrecoVenda.Size = New System.Drawing.Size(80, 20)
        Me.txtPrecoVenda.TabIndex = 1
        Me.txtPrecoVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cbOrigem)
        Me.GroupBox4.Controls.Add(Me.txtGtin)
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.Controls.Add(Me.Label28)
        Me.GroupBox4.Controls.Add(Me.txtUnidade)
        Me.GroupBox4.Controls.Add(Me.Label29)
        Me.GroupBox4.Controls.Add(Me.Label30)
        Me.GroupBox4.Controls.Add(Me.txtTributacao)
        Me.GroupBox4.Controls.Add(Me.Label31)
        Me.GroupBox4.Controls.Add(Me.txtNCM)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 247)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(638, 62)
        Me.GroupBox4.TabIndex = 21
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Dados Fiscais"
        '
        'cbOrigem
        '
        Me.cbOrigem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOrigem.FormattingEnabled = True
        Me.cbOrigem.Items.AddRange(New Object() {"Nacional", "Estrangeira - Importação direta", "Estrangeira - Adquirida no mercado interno"})
        Me.cbOrigem.Location = New System.Drawing.Point(155, 36)
        Me.cbOrigem.Name = "cbOrigem"
        Me.cbOrigem.Size = New System.Drawing.Size(238, 21)
        Me.cbOrigem.TabIndex = 5
        '
        'txtGtin
        '
        Me.txtGtin.Location = New System.Drawing.Point(450, 36)
        Me.txtGtin.Name = "txtGtin"
        Me.txtGtin.Size = New System.Drawing.Size(100, 20)
        Me.txtGtin.TabIndex = 9
        Me.txtGtin.Text = "SEM GTIN"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(450, 19)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(61, 13)
        Me.Label25.TabIndex = 8
        Me.Label25.Text = "GTIN(EAN)"
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(397, 19)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(47, 16)
        Me.Label28.TabIndex = 6
        Me.Label28.Text = "Unidade"
        '
        'txtUnidade
        '
        Me.txtUnidade.BackColor = System.Drawing.Color.White
        Me.txtUnidade.Location = New System.Drawing.Point(400, 36)
        Me.txtUnidade.Name = "txtUnidade"
        Me.txtUnidade.Size = New System.Drawing.Size(44, 20)
        Me.txtUnidade.TabIndex = 7
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(155, 19)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(42, 16)
        Me.Label29.TabIndex = 4
        Me.Label29.Text = "Origem"
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(94, 19)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(60, 16)
        Me.Label30.TabIndex = 2
        Me.Label30.Text = "Tributação"
        '
        'txtTributacao
        '
        Me.txtTributacao.BackColor = System.Drawing.Color.White
        Me.txtTributacao.Location = New System.Drawing.Point(97, 36)
        Me.txtTributacao.Name = "txtTributacao"
        Me.txtTributacao.Size = New System.Drawing.Size(52, 20)
        Me.txtTributacao.TabIndex = 3
        '
        'Label31
        '
        Me.Label31.Location = New System.Drawing.Point(7, 19)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(56, 16)
        Me.Label31.TabIndex = 0
        Me.Label31.Text = "NCM"
        '
        'txtNCM
        '
        Me.txtNCM.BackColor = System.Drawing.Color.White
        Me.txtNCM.Location = New System.Drawing.Point(7, 36)
        Me.txtNCM.Name = "txtNCM"
        Me.txtNCM.Size = New System.Drawing.Size(85, 20)
        Me.txtNCM.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtAdicaoDisponivel)
        Me.GroupBox3.Controls.Add(Me.Label51)
        Me.GroupBox3.Controls.Add(Me.txtDisponibilidade)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.txtDiametro)
        Me.GroupBox3.Controls.Add(Me.txtABBE)
        Me.GroupBox3.Controls.Add(Me.txtACOminimo)
        Me.GroupBox3.Controls.Add(Me.txtIR)
        Me.GroupBox3.Controls.Add(Me.txtAdMenor)
        Me.GroupBox3.Controls.Add(Me.txtAdiMaior)
        Me.GroupBox3.Controls.Add(Me.txtCilMenor)
        Me.GroupBox3.Controls.Add(Me.txtEsfMenor)
        Me.GroupBox3.Controls.Add(Me.txtEsfMaior)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 139)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(640, 103)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Dados Optometricos"
        '
        'txtAdicaoDisponivel
        '
        Me.txtAdicaoDisponivel.Enabled = False
        Me.txtAdicaoDisponivel.Location = New System.Drawing.Point(125, 76)
        Me.txtAdicaoDisponivel.Name = "txtAdicaoDisponivel"
        Me.txtAdicaoDisponivel.Size = New System.Drawing.Size(112, 20)
        Me.txtAdicaoDisponivel.TabIndex = 22
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(125, 61)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(94, 13)
        Me.Label51.TabIndex = 21
        Me.Label51.Text = "Adição Disponível"
        '
        'txtDisponibilidade
        '
        Me.txtDisponibilidade.Enabled = False
        Me.txtDisponibilidade.Location = New System.Drawing.Point(7, 76)
        Me.txtDisponibilidade.Name = "txtDisponibilidade"
        Me.txtDisponibilidade.Size = New System.Drawing.Size(112, 20)
        Me.txtDisponibilidade.TabIndex = 20
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(7, 61)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(78, 13)
        Me.Label24.TabIndex = 19
        Me.Label24.Text = "Disponibilidade"
        '
        'txtDiametro
        '
        Me.txtDiametro.BackColor = System.Drawing.Color.White
        Me.txtDiametro.Location = New System.Drawing.Point(7, 36)
        Me.txtDiametro.Name = "txtDiametro"
        Me.txtDiametro.Size = New System.Drawing.Size(69, 20)
        Me.txtDiametro.TabIndex = 1
        '
        'txtABBE
        '
        Me.txtABBE.BackColor = System.Drawing.Color.White
        Me.txtABBE.Location = New System.Drawing.Point(523, 36)
        Me.txtABBE.Name = "txtABBE"
        Me.txtABBE.Size = New System.Drawing.Size(56, 20)
        Me.txtABBE.TabIndex = 17
        '
        'txtACOminimo
        '
        Me.txtACOminimo.BackColor = System.Drawing.Color.White
        Me.txtACOminimo.Location = New System.Drawing.Point(398, 36)
        Me.txtACOminimo.Name = "txtACOminimo"
        Me.txtACOminimo.Size = New System.Drawing.Size(56, 20)
        Me.txtACOminimo.TabIndex = 13
        '
        'txtIR
        '
        Me.txtIR.BackColor = System.Drawing.Color.White
        Me.txtIR.Location = New System.Drawing.Point(460, 36)
        Me.txtIR.Name = "txtIR"
        Me.txtIR.Size = New System.Drawing.Size(56, 20)
        Me.txtIR.TabIndex = 15
        '
        'txtAdMenor
        '
        Me.txtAdMenor.BackColor = System.Drawing.Color.White
        Me.txtAdMenor.Location = New System.Drawing.Point(270, 36)
        Me.txtAdMenor.Name = "txtAdMenor"
        Me.txtAdMenor.Size = New System.Drawing.Size(56, 20)
        Me.txtAdMenor.TabIndex = 9
        '
        'txtAdiMaior
        '
        Me.txtAdiMaior.BackColor = System.Drawing.Color.White
        Me.txtAdiMaior.Location = New System.Drawing.Point(335, 36)
        Me.txtAdiMaior.Name = "txtAdiMaior"
        Me.txtAdiMaior.Size = New System.Drawing.Size(56, 20)
        Me.txtAdiMaior.TabIndex = 11
        '
        'txtCilMenor
        '
        Me.txtCilMenor.BackColor = System.Drawing.Color.White
        Me.txtCilMenor.Location = New System.Drawing.Point(207, 36)
        Me.txtCilMenor.Name = "txtCilMenor"
        Me.txtCilMenor.Size = New System.Drawing.Size(56, 20)
        Me.txtCilMenor.TabIndex = 7
        '
        'txtEsfMenor
        '
        Me.txtEsfMenor.BackColor = System.Drawing.Color.White
        Me.txtEsfMenor.Location = New System.Drawing.Point(82, 36)
        Me.txtEsfMenor.Name = "txtEsfMenor"
        Me.txtEsfMenor.Size = New System.Drawing.Size(56, 20)
        Me.txtEsfMenor.TabIndex = 3
        '
        'txtEsfMaior
        '
        Me.txtEsfMaior.BackColor = System.Drawing.Color.White
        Me.txtEsfMaior.Location = New System.Drawing.Point(145, 36)
        Me.txtEsfMaior.Name = "txtEsfMaior"
        Me.txtEsfMaior.Size = New System.Drawing.Size(56, 20)
        Me.txtEsfMaior.TabIndex = 5
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(7, 19)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(72, 16)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "Diâmetro mm"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(523, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 16)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "ABBE"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(398, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 16)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "ACO Min."
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(460, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 16)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "I. R."
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(335, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 16)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Adi. Maior"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(207, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Cil. Menor"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(82, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 16)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Esf. Menor"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(145, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Esf. Maior"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(270, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 16)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Adi. Menor"
        '
        'txtSaldo
        '
        Me.txtSaldo.BackColor = System.Drawing.Color.White
        Me.txtSaldo.Location = New System.Drawing.Point(559, 349)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(80, 20)
        Me.txtSaldo.TabIndex = 25
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label44
        '
        Me.Label44.Location = New System.Drawing.Point(559, 332)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(47, 16)
        Me.Label44.TabIndex = 24
        Me.Label44.Text = "Estoque"
        '
        'cbEspecie
        '
        Me.cbEspecie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEspecie.FormattingEnabled = True
        Me.cbEspecie.Items.AddRange(New Object() {"B", "L", "BS", "LC", "AR"})
        Me.cbEspecie.Location = New System.Drawing.Point(523, 67)
        Me.cbEspecie.Name = "cbEspecie"
        Me.cbEspecie.Size = New System.Drawing.Size(128, 21)
        Me.cbEspecie.TabIndex = 13
        '
        'chkAtivo
        '
        Me.chkAtivo.AutoSize = True
        Me.chkAtivo.Checked = True
        Me.chkAtivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAtivo.Location = New System.Drawing.Point(578, 7)
        Me.chkAtivo.Name = "chkAtivo"
        Me.chkAtivo.Size = New System.Drawing.Size(50, 17)
        Me.chkAtivo.TabIndex = 35
        Me.chkAtivo.Text = "Ativo"
        Me.chkAtivo.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(96, 9)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(70, 16)
        Me.Label27.TabIndex = 2
        Me.Label27.Text = "Cod. Tabela"
        '
        'txtCodTabela
        '
        Me.txtCodTabela.BackColor = System.Drawing.Color.White
        Me.txtCodTabela.Location = New System.Drawing.Point(99, 26)
        Me.txtCodTabela.Name = "txtCodTabela"
        Me.txtCodTabela.ReadOnly = True
        Me.txtCodTabela.Size = New System.Drawing.Size(72, 20)
        Me.txtCodTabela.TabIndex = 3
        '
        'txtCaracteristicas
        '
        Me.txtCaracteristicas.BackColor = System.Drawing.Color.White
        Me.txtCaracteristicas.Location = New System.Drawing.Point(8, 397)
        Me.txtCaracteristicas.Multiline = True
        Me.txtCaracteristicas.Name = "txtCaracteristicas"
        Me.txtCaracteristicas.Size = New System.Drawing.Size(470, 44)
        Me.txtCaracteristicas.TabIndex = 27
        '
        'txtNomeProduto
        '
        Me.txtNomeProduto.BackColor = System.Drawing.Color.White
        Me.txtNomeProduto.Location = New System.Drawing.Point(8, 67)
        Me.txtNomeProduto.Name = "txtNomeProduto"
        Me.txtNomeProduto.Size = New System.Drawing.Size(358, 20)
        Me.txtNomeProduto.TabIndex = 9
        '
        'txtCodLente
        '
        Me.txtCodLente.BackColor = System.Drawing.Color.White
        Me.txtCodLente.Location = New System.Drawing.Point(8, 26)
        Me.txtCodLente.Name = "txtCodLente"
        Me.txtCodLente.ReadOnly = True
        Me.txtCodLente.Size = New System.Drawing.Size(72, 20)
        Me.txtCodLente.TabIndex = 1
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(8, 380)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(80, 16)
        Me.Label23.TabIndex = 26
        Me.Label23.Text = "Características"
        '
        'cbMaterial
        '
        Me.cbMaterial.BackColor = System.Drawing.Color.White
        Me.cbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMaterial.Location = New System.Drawing.Point(373, 67)
        Me.cbMaterial.Name = "cbMaterial"
        Me.cbMaterial.Size = New System.Drawing.Size(144, 21)
        Me.cbMaterial.TabIndex = 11
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(370, 50)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(48, 16)
        Me.Label20.TabIndex = 10
        Me.Label20.Text = "Material"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(520, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Espécie"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Nome Lente / Armação"
        '
        'cbTipo
        '
        Me.cbTipo.BackColor = System.Drawing.Color.White
        Me.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipo.Location = New System.Drawing.Point(384, 25)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(144, 21)
        Me.cbTipo.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(381, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Tipo"
        '
        'cbFabricante
        '
        Me.cbFabricante.BackColor = System.Drawing.Color.White
        Me.cbFabricante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFabricante.Location = New System.Drawing.Point(177, 25)
        Me.cbFabricante.Name = "cbFabricante"
        Me.cbFabricante.Size = New System.Drawing.Size(159, 21)
        Me.cbFabricante.TabIndex = 5
        '
        'Fabricante
        '
        Me.Fabricante.Location = New System.Drawing.Point(177, 10)
        Me.Fabricante.Name = "Fabricante"
        Me.Fabricante.Size = New System.Drawing.Size(64, 16)
        Me.Fabricante.TabIndex = 4
        Me.Fabricante.Text = "Fabricante"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cod. Lente"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.btnSalvar)
        Me.Panel1.Controls.Add(Me.btnAlterar)
        Me.Panel1.Controls.Add(Me.btnNovo)
        Me.Panel1.Controls.Add(Me.btnPesCod)
        Me.Panel1.Controls.Add(Me.btnExportaDados)
        Me.Panel1.Location = New System.Drawing.Point(9, 479)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(630, 44)
        Me.Panel1.TabIndex = 28
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(232, 4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(87, 34)
        Me.btnCancelar.TabIndex = 37
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
        Me.btnSalvar.Location = New System.Drawing.Point(156, 4)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(75, 34)
        Me.btnSalvar.TabIndex = 36
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Image = CType(resources.GetObject("btnAlterar.Image"), System.Drawing.Image)
        Me.btnAlterar.Location = New System.Drawing.Point(80, 4)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(75, 34)
        Me.btnAlterar.TabIndex = 35
        Me.btnAlterar.Text = "Editar"
        Me.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnNovo
        '
        Me.btnNovo.Image = CType(resources.GetObject("btnNovo.Image"), System.Drawing.Image)
        Me.btnNovo.Location = New System.Drawing.Point(4, 4)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(75, 34)
        Me.btnNovo.TabIndex = 34
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'btnPesCod
        '
        Me.btnPesCod.Image = CType(resources.GetObject("btnPesCod.Image"), System.Drawing.Image)
        Me.btnPesCod.Location = New System.Drawing.Point(415, 4)
        Me.btnPesCod.Name = "btnPesCod"
        Me.btnPesCod.Size = New System.Drawing.Size(82, 34)
        Me.btnPesCod.TabIndex = 3
        Me.btnPesCod.Text = "Localizar"
        Me.btnPesCod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPesCod.UseVisualStyleBackColor = True
        '
        'btnExportaDados
        '
        Me.btnExportaDados.Image = CType(resources.GetObject("btnExportaDados.Image"), System.Drawing.Image)
        Me.btnExportaDados.Location = New System.Drawing.Point(327, 4)
        Me.btnExportaDados.Name = "btnExportaDados"
        Me.btnExportaDados.Size = New System.Drawing.Size(82, 34)
        Me.btnExportaDados.TabIndex = 33
        Me.btnExportaDados.Text = "Exportar"
        Me.btnExportaDados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btnExportaDados, "Exporta as dioptrias para a fila de exportação.")
        Me.btnExportaDados.UseVisualStyleBackColor = True
        Me.btnExportaDados.Visible = False
        '
        'tab_Bloco_surfacado
        '
        Me.tab_Bloco_surfacado.Controls.Add(Me.Label43)
        Me.tab_Bloco_surfacado.Controls.Add(Me.txtBlocoOrigem)
        Me.tab_Bloco_surfacado.Controls.Add(Me.lblStatusBlocoSurf)
        Me.tab_Bloco_surfacado.Controls.Add(Me.pbBlocoSurf)
        Me.tab_Bloco_surfacado.Controls.Add(Me.btnLimparBlocoSurf)
        Me.tab_Bloco_surfacado.Controls.Add(Me.txtPrecoBlocoSurf)
        Me.tab_Bloco_surfacado.Controls.Add(Me.txtFatorPrecoSurf)
        Me.tab_Bloco_surfacado.Controls.Add(Me.txtCodBarrasSurf)
        Me.tab_Bloco_surfacado.Controls.Add(Me.txtEsfSurf)
        Me.tab_Bloco_surfacado.Controls.Add(Me.txtCilindricoSurf)
        Me.tab_Bloco_surfacado.Controls.Add(Me.txtOlhoSurf)
        Me.tab_Bloco_surfacado.Controls.Add(Me.txtAdicaoSurf)
        Me.tab_Bloco_surfacado.Controls.Add(Me.txtBaseSurf)
        Me.tab_Bloco_surfacado.Controls.Add(Me.chkEstoqueSurf)
        Me.tab_Bloco_surfacado.Controls.Add(Me.Label32)
        Me.tab_Bloco_surfacado.Controls.Add(Me.Label33)
        Me.tab_Bloco_surfacado.Controls.Add(Me.Label34)
        Me.tab_Bloco_surfacado.Controls.Add(Me.Label35)
        Me.tab_Bloco_surfacado.Controls.Add(Me.Label36)
        Me.tab_Bloco_surfacado.Controls.Add(Me.Label37)
        Me.tab_Bloco_surfacado.Controls.Add(Me.grd_Bloco_surf)
        Me.tab_Bloco_surfacado.Controls.Add(Me.pnlSalvarSurf)
        Me.tab_Bloco_surfacado.Controls.Add(Me.pnlNovoBlocoSurf)
        Me.tab_Bloco_surfacado.Location = New System.Drawing.Point(4, 22)
        Me.tab_Bloco_surfacado.Name = "tab_Bloco_surfacado"
        Me.tab_Bloco_surfacado.Size = New System.Drawing.Size(696, 557)
        Me.tab_Bloco_surfacado.TabIndex = 4
        Me.tab_Bloco_surfacado.Text = "Bloco Surfacado"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(6, 6)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(85, 13)
        Me.Label43.TabIndex = 80
        Me.Label43.Text = "Bloco de Origem"
        '
        'txtBlocoOrigem
        '
        Me.txtBlocoOrigem.ContextMenuStrip = Me.mnuOrigemBloco
        Me.txtBlocoOrigem.Location = New System.Drawing.Point(100, 3)
        Me.txtBlocoOrigem.Name = "txtBlocoOrigem"
        Me.txtBlocoOrigem.Size = New System.Drawing.Size(203, 20)
        Me.txtBlocoOrigem.TabIndex = 79
        '
        'mnuOrigemBloco
        '
        Me.mnuOrigemBloco.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniAdicionarBlocoOrigem, Me.mniExcluirBlocoOrigem})
        Me.mnuOrigemBloco.Name = "mnuOrigemBloco"
        Me.mnuOrigemBloco.Size = New System.Drawing.Size(202, 48)
        '
        'mniAdicionarBlocoOrigem
        '
        Me.mniAdicionarBlocoOrigem.Name = "mniAdicionarBlocoOrigem"
        Me.mniAdicionarBlocoOrigem.Size = New System.Drawing.Size(201, 22)
        Me.mniAdicionarBlocoOrigem.Text = "Adicionar Bloco Origem"
        '
        'mniExcluirBlocoOrigem
        '
        Me.mniExcluirBlocoOrigem.Name = "mniExcluirBlocoOrigem"
        Me.mniExcluirBlocoOrigem.Size = New System.Drawing.Size(201, 22)
        Me.mniExcluirBlocoOrigem.Text = "Excluir Bloco Origem"
        '
        'lblStatusBlocoSurf
        '
        Me.lblStatusBlocoSurf.Location = New System.Drawing.Point(85, 397)
        Me.lblStatusBlocoSurf.Name = "lblStatusBlocoSurf"
        Me.lblStatusBlocoSurf.Size = New System.Drawing.Size(433, 12)
        Me.lblStatusBlocoSurf.TabIndex = 78
        Me.lblStatusBlocoSurf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbBlocoSurf
        '
        Me.pbBlocoSurf.Location = New System.Drawing.Point(9, 412)
        Me.pbBlocoSurf.Name = "pbBlocoSurf"
        Me.pbBlocoSurf.Size = New System.Drawing.Size(594, 10)
        Me.pbBlocoSurf.TabIndex = 77
        '
        'btnLimparBlocoSurf
        '
        Me.btnLimparBlocoSurf.BackColor = System.Drawing.Color.AliceBlue
        Me.btnLimparBlocoSurf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimparBlocoSurf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimparBlocoSurf.Location = New System.Drawing.Point(535, 383)
        Me.btnLimparBlocoSurf.Name = "btnLimparBlocoSurf"
        Me.btnLimparBlocoSurf.Size = New System.Drawing.Size(65, 23)
        Me.btnLimparBlocoSurf.TabIndex = 76
        Me.btnLimparBlocoSurf.Text = "Limpar Produtos"
        Me.btnLimparBlocoSurf.UseVisualStyleBackColor = False
        '
        'txtPrecoBlocoSurf
        '
        Me.txtPrecoBlocoSurf.BackColor = System.Drawing.Color.White
        Me.txtPrecoBlocoSurf.Location = New System.Drawing.Point(496, 328)
        Me.txtPrecoBlocoSurf.Name = "txtPrecoBlocoSurf"
        Me.txtPrecoBlocoSurf.ReadOnly = True
        Me.txtPrecoBlocoSurf.Size = New System.Drawing.Size(72, 20)
        Me.txtPrecoBlocoSurf.TabIndex = 75
        '
        'txtFatorPrecoSurf
        '
        Me.txtFatorPrecoSurf.BackColor = System.Drawing.Color.White
        Me.txtFatorPrecoSurf.Location = New System.Drawing.Point(415, 327)
        Me.txtFatorPrecoSurf.Name = "txtFatorPrecoSurf"
        Me.txtFatorPrecoSurf.ReadOnly = True
        Me.txtFatorPrecoSurf.Size = New System.Drawing.Size(72, 20)
        Me.txtFatorPrecoSurf.TabIndex = 74
        '
        'txtCodBarrasSurf
        '
        Me.txtCodBarrasSurf.BackColor = System.Drawing.Color.White
        Me.txtCodBarrasSurf.Location = New System.Drawing.Point(336, 328)
        Me.txtCodBarrasSurf.Name = "txtCodBarrasSurf"
        Me.txtCodBarrasSurf.ReadOnly = True
        Me.txtCodBarrasSurf.Size = New System.Drawing.Size(72, 20)
        Me.txtCodBarrasSurf.TabIndex = 12
        '
        'txtEsfSurf
        '
        Me.txtEsfSurf.BackColor = System.Drawing.Color.White
        Me.txtEsfSurf.Location = New System.Drawing.Point(176, 328)
        Me.txtEsfSurf.Name = "txtEsfSurf"
        Me.txtEsfSurf.ReadOnly = True
        Me.txtEsfSurf.Size = New System.Drawing.Size(72, 20)
        Me.txtEsfSurf.TabIndex = 8
        '
        'txtCilindricoSurf
        '
        Me.txtCilindricoSurf.BackColor = System.Drawing.Color.White
        Me.txtCilindricoSurf.Location = New System.Drawing.Point(256, 328)
        Me.txtCilindricoSurf.Name = "txtCilindricoSurf"
        Me.txtCilindricoSurf.ReadOnly = True
        Me.txtCilindricoSurf.Size = New System.Drawing.Size(72, 20)
        Me.txtCilindricoSurf.TabIndex = 9
        '
        'txtOlhoSurf
        '
        Me.txtOlhoSurf.BackColor = System.Drawing.Color.White
        Me.txtOlhoSurf.Location = New System.Drawing.Point(144, 328)
        Me.txtOlhoSurf.MaxLength = 1
        Me.txtOlhoSurf.Name = "txtOlhoSurf"
        Me.txtOlhoSurf.ReadOnly = True
        Me.txtOlhoSurf.Size = New System.Drawing.Size(24, 20)
        Me.txtOlhoSurf.TabIndex = 6
        '
        'txtAdicaoSurf
        '
        Me.txtAdicaoSurf.BackColor = System.Drawing.Color.White
        Me.txtAdicaoSurf.Location = New System.Drawing.Point(80, 328)
        Me.txtAdicaoSurf.Name = "txtAdicaoSurf"
        Me.txtAdicaoSurf.ReadOnly = True
        Me.txtAdicaoSurf.Size = New System.Drawing.Size(56, 20)
        Me.txtAdicaoSurf.TabIndex = 4
        '
        'txtBaseSurf
        '
        Me.txtBaseSurf.BackColor = System.Drawing.Color.White
        Me.txtBaseSurf.Location = New System.Drawing.Point(8, 328)
        Me.txtBaseSurf.Name = "txtBaseSurf"
        Me.txtBaseSurf.ReadOnly = True
        Me.txtBaseSurf.Size = New System.Drawing.Size(56, 20)
        Me.txtBaseSurf.TabIndex = 2
        '
        'chkEstoqueSurf
        '
        Me.chkEstoqueSurf.AutoSize = True
        Me.chkEstoqueSurf.Location = New System.Drawing.Point(484, 360)
        Me.chkEstoqueSurf.Name = "chkEstoqueSurf"
        Me.chkEstoqueSurf.Size = New System.Drawing.Size(65, 17)
        Me.chkEstoqueSurf.TabIndex = 60
        Me.chkEstoqueSurf.Text = "Estoque"
        Me.chkEstoqueSurf.UseVisualStyleBackColor = True
        '
        'Label32
        '
        Me.Label32.Location = New System.Drawing.Point(336, 312)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(88, 16)
        Me.Label32.TabIndex = 13
        Me.Label32.Text = "Código Barras"
        '
        'Label33
        '
        Me.Label33.Location = New System.Drawing.Point(176, 312)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(64, 16)
        Me.Label33.TabIndex = 11
        Me.Label33.Text = "Esférico"
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(256, 312)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(64, 16)
        Me.Label34.TabIndex = 9
        Me.Label34.Text = "Cilindrico"
        '
        'Label35
        '
        Me.Label35.Location = New System.Drawing.Point(144, 312)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(32, 16)
        Me.Label35.TabIndex = 7
        Me.Label35.Text = "Olho"
        '
        'Label36
        '
        Me.Label36.Location = New System.Drawing.Point(80, 312)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(40, 16)
        Me.Label36.TabIndex = 5
        Me.Label36.Text = "Adição"
        '
        'Label37
        '
        Me.Label37.Location = New System.Drawing.Point(0, 312)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(80, 16)
        Me.Label37.TabIndex = 3
        Me.Label37.Text = "Base Nominal"
        '
        'grd_Bloco_surf
        '
        Me.grd_Bloco_surf.AllowSorting = False
        Me.grd_Bloco_surf.DataMember = ""
        Me.grd_Bloco_surf.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grd_Bloco_surf.Location = New System.Drawing.Point(8, 28)
        Me.grd_Bloco_surf.Name = "grd_Bloco_surf"
        Me.grd_Bloco_surf.ReadOnly = True
        Me.grd_Bloco_surf.Size = New System.Drawing.Size(592, 280)
        Me.grd_Bloco_surf.TabIndex = 0
        '
        'pnlSalvarSurf
        '
        Me.pnlSalvarSurf.Controls.Add(Me.btnCancelarBlocoSurf)
        Me.pnlSalvarSurf.Controls.Add(Me.btnSalvarBlocoSurf)
        Me.pnlSalvarSurf.Location = New System.Drawing.Point(247, 362)
        Me.pnlSalvarSurf.Name = "pnlSalvarSurf"
        Me.pnlSalvarSurf.Size = New System.Drawing.Size(127, 32)
        Me.pnlSalvarSurf.TabIndex = 59
        Me.pnlSalvarSurf.Visible = False
        '
        'btnCancelarBlocoSurf
        '
        Me.btnCancelarBlocoSurf.BackColor = System.Drawing.Color.AliceBlue
        Me.btnCancelarBlocoSurf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarBlocoSurf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarBlocoSurf.Location = New System.Drawing.Point(57, 5)
        Me.btnCancelarBlocoSurf.Name = "btnCancelarBlocoSurf"
        Me.btnCancelarBlocoSurf.Size = New System.Drawing.Size(64, 23)
        Me.btnCancelarBlocoSurf.TabIndex = 1
        Me.btnCancelarBlocoSurf.Text = "Cancelar"
        Me.btnCancelarBlocoSurf.UseVisualStyleBackColor = False
        '
        'btnSalvarBlocoSurf
        '
        Me.btnSalvarBlocoSurf.BackColor = System.Drawing.Color.AliceBlue
        Me.btnSalvarBlocoSurf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvarBlocoSurf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvarBlocoSurf.Location = New System.Drawing.Point(7, 5)
        Me.btnSalvarBlocoSurf.Name = "btnSalvarBlocoSurf"
        Me.btnSalvarBlocoSurf.Size = New System.Drawing.Size(49, 23)
        Me.btnSalvarBlocoSurf.TabIndex = 0
        Me.btnSalvarBlocoSurf.Text = "Salvar"
        Me.btnSalvarBlocoSurf.UseVisualStyleBackColor = False
        '
        'pnlNovoBlocoSurf
        '
        Me.pnlNovoBlocoSurf.Controls.Add(Me.btnDeletarBlocoSurf)
        Me.pnlNovoBlocoSurf.Controls.Add(Me.btnEditarBlocoSurf)
        Me.pnlNovoBlocoSurf.Controls.Add(Me.btnNovoBlocoSurf)
        Me.pnlNovoBlocoSurf.Location = New System.Drawing.Point(223, 360)
        Me.pnlNovoBlocoSurf.Name = "pnlNovoBlocoSurf"
        Me.pnlNovoBlocoSurf.Size = New System.Drawing.Size(161, 32)
        Me.pnlNovoBlocoSurf.TabIndex = 57
        '
        'btnDeletarBlocoSurf
        '
        Me.btnDeletarBlocoSurf.BackColor = System.Drawing.Color.AliceBlue
        Me.btnDeletarBlocoSurf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeletarBlocoSurf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeletarBlocoSurf.Location = New System.Drawing.Point(100, 5)
        Me.btnDeletarBlocoSurf.Name = "btnDeletarBlocoSurf"
        Me.btnDeletarBlocoSurf.Size = New System.Drawing.Size(52, 23)
        Me.btnDeletarBlocoSurf.TabIndex = 2
        Me.btnDeletarBlocoSurf.Text = "Deletar"
        Me.btnDeletarBlocoSurf.UseVisualStyleBackColor = False
        '
        'btnEditarBlocoSurf
        '
        Me.btnEditarBlocoSurf.BackColor = System.Drawing.Color.AliceBlue
        Me.btnEditarBlocoSurf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarBlocoSurf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarBlocoSurf.Location = New System.Drawing.Point(56, 5)
        Me.btnEditarBlocoSurf.Name = "btnEditarBlocoSurf"
        Me.btnEditarBlocoSurf.Size = New System.Drawing.Size(44, 23)
        Me.btnEditarBlocoSurf.TabIndex = 1
        Me.btnEditarBlocoSurf.Text = "Editar"
        Me.btnEditarBlocoSurf.UseVisualStyleBackColor = False
        '
        'btnNovoBlocoSurf
        '
        Me.btnNovoBlocoSurf.BackColor = System.Drawing.Color.AliceBlue
        Me.btnNovoBlocoSurf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovoBlocoSurf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNovoBlocoSurf.Location = New System.Drawing.Point(7, 5)
        Me.btnNovoBlocoSurf.Name = "btnNovoBlocoSurf"
        Me.btnNovoBlocoSurf.Size = New System.Drawing.Size(49, 23)
        Me.btnNovoBlocoSurf.TabIndex = 0
        Me.btnNovoBlocoSurf.Text = "Novo"
        Me.btnNovoBlocoSurf.UseVisualStyleBackColor = False
        '
        'tabLenteContato
        '
        Me.tabLenteContato.Controls.Add(Me.pnlSalvarContato)
        Me.tabLenteContato.Controls.Add(Me.txtBaseContato)
        Me.tabLenteContato.Controls.Add(Me.Label42)
        Me.tabLenteContato.Controls.Add(Me.Label38)
        Me.tabLenteContato.Controls.Add(Me.txtPrecoContato)
        Me.tabLenteContato.Controls.Add(Me.txtFatorPrecoContato)
        Me.tabLenteContato.Controls.Add(Me.txtCodBarraContato)
        Me.tabLenteContato.Controls.Add(Me.txtCilContato)
        Me.tabLenteContato.Controls.Add(Me.txtEsfContato)
        Me.tabLenteContato.Controls.Add(Me.btnLimparContato)
        Me.tabLenteContato.Controls.Add(Me.chkEstoqueContato)
        Me.tabLenteContato.Controls.Add(Me.btnIntervaloContato)
        Me.tabLenteContato.Controls.Add(Me.Label39)
        Me.tabLenteContato.Controls.Add(Me.Label40)
        Me.tabLenteContato.Controls.Add(Me.Label41)
        Me.tabLenteContato.Controls.Add(Me.grdContato)
        Me.tabLenteContato.Controls.Add(Me.pnlNovoContato)
        Me.tabLenteContato.Location = New System.Drawing.Point(4, 22)
        Me.tabLenteContato.Name = "tabLenteContato"
        Me.tabLenteContato.Padding = New System.Windows.Forms.Padding(3)
        Me.tabLenteContato.Size = New System.Drawing.Size(696, 557)
        Me.tabLenteContato.TabIndex = 5
        Me.tabLenteContato.Text = "Lente de Contato"
        Me.tabLenteContato.UseVisualStyleBackColor = True
        '
        'pnlSalvarContato
        '
        Me.pnlSalvarContato.Controls.Add(Me.btnCancelarContato)
        Me.pnlSalvarContato.Controls.Add(Me.btnSalvarContato)
        Me.pnlSalvarContato.Location = New System.Drawing.Point(99, 363)
        Me.pnlSalvarContato.Name = "pnlSalvarContato"
        Me.pnlSalvarContato.Size = New System.Drawing.Size(127, 32)
        Me.pnlSalvarContato.TabIndex = 95
        Me.pnlSalvarContato.Visible = False
        '
        'btnCancelarContato
        '
        Me.btnCancelarContato.BackColor = System.Drawing.Color.AliceBlue
        Me.btnCancelarContato.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarContato.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarContato.Location = New System.Drawing.Point(57, 5)
        Me.btnCancelarContato.Name = "btnCancelarContato"
        Me.btnCancelarContato.Size = New System.Drawing.Size(64, 23)
        Me.btnCancelarContato.TabIndex = 1
        Me.btnCancelarContato.Text = "Cancelar"
        Me.btnCancelarContato.UseVisualStyleBackColor = False
        '
        'btnSalvarContato
        '
        Me.btnSalvarContato.BackColor = System.Drawing.Color.AliceBlue
        Me.btnSalvarContato.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvarContato.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvarContato.Location = New System.Drawing.Point(7, 5)
        Me.btnSalvarContato.Name = "btnSalvarContato"
        Me.btnSalvarContato.Size = New System.Drawing.Size(49, 23)
        Me.btnSalvarContato.TabIndex = 0
        Me.btnSalvarContato.Text = "Salvar"
        Me.btnSalvarContato.UseVisualStyleBackColor = False
        '
        'txtBaseContato
        '
        Me.txtBaseContato.BackColor = System.Drawing.Color.White
        Me.txtBaseContato.Location = New System.Drawing.Point(6, 314)
        Me.txtBaseContato.Name = "txtBaseContato"
        Me.txtBaseContato.ReadOnly = True
        Me.txtBaseContato.Size = New System.Drawing.Size(56, 20)
        Me.txtBaseContato.TabIndex = 0
        '
        'Label42
        '
        Me.Label42.Location = New System.Drawing.Point(6, 298)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(48, 16)
        Me.Label42.TabIndex = 94
        Me.Label42.Text = "Base"
        '
        'Label38
        '
        Me.Label38.Location = New System.Drawing.Point(11, 389)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(413, 23)
        Me.Label38.TabIndex = 92
        '
        'txtPrecoContato
        '
        Me.txtPrecoContato.BackColor = System.Drawing.Color.White
        Me.txtPrecoContato.Location = New System.Drawing.Point(364, 315)
        Me.txtPrecoContato.Name = "txtPrecoContato"
        Me.txtPrecoContato.ReadOnly = True
        Me.txtPrecoContato.Size = New System.Drawing.Size(72, 20)
        Me.txtPrecoContato.TabIndex = 91
        '
        'txtFatorPrecoContato
        '
        Me.txtFatorPrecoContato.BackColor = System.Drawing.Color.White
        Me.txtFatorPrecoContato.Location = New System.Drawing.Point(283, 314)
        Me.txtFatorPrecoContato.Name = "txtFatorPrecoContato"
        Me.txtFatorPrecoContato.ReadOnly = True
        Me.txtFatorPrecoContato.Size = New System.Drawing.Size(72, 20)
        Me.txtFatorPrecoContato.TabIndex = 90
        '
        'txtCodBarraContato
        '
        Me.txtCodBarraContato.BackColor = System.Drawing.Color.White
        Me.txtCodBarraContato.Location = New System.Drawing.Point(203, 314)
        Me.txtCodBarraContato.Name = "txtCodBarraContato"
        Me.txtCodBarraContato.ReadOnly = True
        Me.txtCodBarraContato.Size = New System.Drawing.Size(72, 20)
        Me.txtCodBarraContato.TabIndex = 80
        '
        'txtCilContato
        '
        Me.txtCilContato.BackColor = System.Drawing.Color.White
        Me.txtCilContato.Location = New System.Drawing.Point(139, 314)
        Me.txtCilContato.Name = "txtCilContato"
        Me.txtCilContato.ReadOnly = True
        Me.txtCilContato.Size = New System.Drawing.Size(56, 20)
        Me.txtCilContato.TabIndex = 78
        '
        'txtEsfContato
        '
        Me.txtEsfContato.BackColor = System.Drawing.Color.White
        Me.txtEsfContato.Location = New System.Drawing.Point(75, 314)
        Me.txtEsfContato.Name = "txtEsfContato"
        Me.txtEsfContato.ReadOnly = True
        Me.txtEsfContato.Size = New System.Drawing.Size(56, 20)
        Me.txtEsfContato.TabIndex = 1
        '
        'btnLimparContato
        '
        Me.btnLimparContato.BackColor = System.Drawing.Color.AliceBlue
        Me.btnLimparContato.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimparContato.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimparContato.Location = New System.Drawing.Point(548, 398)
        Me.btnLimparContato.Name = "btnLimparContato"
        Me.btnLimparContato.Size = New System.Drawing.Size(52, 23)
        Me.btnLimparContato.TabIndex = 89
        Me.btnLimparContato.Text = "Limpar"
        Me.btnLimparContato.UseVisualStyleBackColor = False
        '
        'chkEstoqueContato
        '
        Me.chkEstoqueContato.AutoSize = True
        Me.chkEstoqueContato.Location = New System.Drawing.Point(136, 340)
        Me.chkEstoqueContato.Name = "chkEstoqueContato"
        Me.chkEstoqueContato.Size = New System.Drawing.Size(65, 17)
        Me.chkEstoqueContato.TabIndex = 85
        Me.chkEstoqueContato.Text = "Estoque"
        Me.chkEstoqueContato.UseVisualStyleBackColor = True
        '
        'btnIntervaloContato
        '
        Me.btnIntervaloContato.Location = New System.Drawing.Point(455, 354)
        Me.btnIntervaloContato.Name = "btnIntervaloContato"
        Me.btnIntervaloContato.Size = New System.Drawing.Size(132, 23)
        Me.btnIntervaloContato.TabIndex = 84
        Me.btnIntervaloContato.Text = "Cadastrar por Intervalo"
        Me.btnIntervaloContato.UseVisualStyleBackColor = True
        '
        'Label39
        '
        Me.Label39.Location = New System.Drawing.Point(203, 298)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(88, 16)
        Me.Label39.TabIndex = 81
        Me.Label39.Text = "Código Barras"
        '
        'Label40
        '
        Me.Label40.Location = New System.Drawing.Point(139, 298)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(56, 16)
        Me.Label40.TabIndex = 79
        Me.Label40.Text = "Cilindrico"
        '
        'Label41
        '
        Me.Label41.Location = New System.Drawing.Point(75, 298)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(48, 16)
        Me.Label41.TabIndex = 77
        Me.Label41.Text = "Esférico"
        '
        'grdContato
        '
        Me.grdContato.AllowSorting = False
        Me.grdContato.DataMember = ""
        Me.grdContato.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdContato.Location = New System.Drawing.Point(8, 10)
        Me.grdContato.Name = "grdContato"
        Me.grdContato.ReadOnly = True
        Me.grdContato.Size = New System.Drawing.Size(592, 280)
        Me.grdContato.TabIndex = 75
        '
        'pnlNovoContato
        '
        Me.pnlNovoContato.Controls.Add(Me.btnDeletarContato)
        Me.pnlNovoContato.Controls.Add(Me.btnEditarContato)
        Me.pnlNovoContato.Controls.Add(Me.btnNovoContato)
        Me.pnlNovoContato.Location = New System.Drawing.Point(232, 354)
        Me.pnlNovoContato.Name = "pnlNovoContato"
        Me.pnlNovoContato.Size = New System.Drawing.Size(152, 32)
        Me.pnlNovoContato.TabIndex = 82
        '
        'btnDeletarContato
        '
        Me.btnDeletarContato.BackColor = System.Drawing.Color.AliceBlue
        Me.btnDeletarContato.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeletarContato.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeletarContato.Location = New System.Drawing.Point(100, 5)
        Me.btnDeletarContato.Name = "btnDeletarContato"
        Me.btnDeletarContato.Size = New System.Drawing.Size(52, 23)
        Me.btnDeletarContato.TabIndex = 2
        Me.btnDeletarContato.Text = "Deletar"
        Me.btnDeletarContato.UseVisualStyleBackColor = False
        '
        'btnEditarContato
        '
        Me.btnEditarContato.BackColor = System.Drawing.Color.AliceBlue
        Me.btnEditarContato.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarContato.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarContato.Location = New System.Drawing.Point(56, 5)
        Me.btnEditarContato.Name = "btnEditarContato"
        Me.btnEditarContato.Size = New System.Drawing.Size(44, 23)
        Me.btnEditarContato.TabIndex = 1
        Me.btnEditarContato.Text = "Editar"
        Me.btnEditarContato.UseVisualStyleBackColor = False
        '
        'btnNovoContato
        '
        Me.btnNovoContato.BackColor = System.Drawing.Color.AliceBlue
        Me.btnNovoContato.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovoContato.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNovoContato.Location = New System.Drawing.Point(7, 5)
        Me.btnNovoContato.Name = "btnNovoContato"
        Me.btnNovoContato.Size = New System.Drawing.Size(49, 23)
        Me.btnNovoContato.TabIndex = 0
        Me.btnNovoContato.Text = "Novo"
        Me.btnNovoContato.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus, Me.pbGeral})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 593)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(793, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'pbGeral
        '
        Me.pbGeral.Name = "pbGeral"
        Me.pbGeral.Size = New System.Drawing.Size(300, 16)
        Me.pbGeral.Visible = False
        '
        'frmLentes_blocos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(793, 615)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.tb2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLentes_blocos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Produtos -Lentes e Blocos"
        Me.tabLentes.ResumeLayout(False)
        Me.tabLentes.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdLentes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuGrdLentes.ResumeLayout(False)
        Me.tabBases.ResumeLayout(False)
        Me.tabBases.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.grdBloco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tb2.ResumeLayout(False)
        Me.tabPrinc.ResumeLayout(False)
        Me.tabPrinc.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.tab_Bloco_surfacado.ResumeLayout(False)
        Me.tab_Bloco_surfacado.PerformLayout()
        Me.mnuOrigemBloco.ResumeLayout(False)
        CType(Me.grd_Bloco_surf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSalvarSurf.ResumeLayout(False)
        Me.pnlNovoBlocoSurf.ResumeLayout(False)
        Me.tabLenteContato.ResumeLayout(False)
        Me.tabLenteContato.PerformLayout()
        Me.pnlSalvarContato.ResumeLayout(False)
        CType(Me.grdContato, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlNovoContato.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim conexao As New ConexaoDB
    Dim lentecad As New Lentes
    Dim blococad As New Bloco
    Dim produtocad As New Produto
    Dim util As New Geral
    'Dim lb As New objLentes
    Dim Lente As New LentesDioptria
    'Dim bs As New objBlocoSurf
    'Dim LC As New objLenteContato
    'Dim p As New produtoClass
    Dim d As New dados
    Dim especie As New objEspecie
    Dim familia As New objMaster
    Dim tipo_cad_lente As String = "unitario"
    'Tipo de Cadastro de Lente. se "unitario" (padrão)
    'cadastro lente a lente; se "intervelo" cadatro por intervalo
    Dim tbBlocos As New DataTable
    Dim tblentes As New DataTable
    Dim base_origem As String = ""
    Dim registro As Integer
    Dim strModo = ""
    Dim strJanela As String = ""

#Region "Load, Carrega_dados..."
    Private Sub frmLentes_blocos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'travaControles(Me.tabPrinc.Controls)
        carrega_combos()
        CarregaFabricante()
        util.DesativaControles(Me)
        AtivaDesativaControle(1)
        cbFabricante.Text = ""
        cbTipo.Text = ""
        cbMaterial.Text = ""
    End Sub
    Private Sub c_dados()
        Status()

        If lentecad.CodigoLente IsNot Nothing Then
            txtCodLente.Text = lentecad.CodigoLente
            txtCodTabela.Text = lentecad.CodigoTabela
            cbFabricante.SelectedValue = lentecad.CodigoFabricante
            cbTipo.SelectedValue = lentecad.CodigoTipoLente
            cbMaterial.SelectedValue = lentecad.IdMaterial
            txtNomeProduto.Text = lentecad.NomeProduto
            txtNomeComercial.Text = lentecad.NomeComercial
            cbEspecie.SelectedValue = lentecad.Especie
            If lentecad.EsfericoMaior Is Nothing Then txtEsfMaior.Text = String.Empty Else txtEsfMaior.Text = lentecad.EsfericoMaior
            If lentecad.EsfericoMenor Is Nothing Then txtEsfMenor.Text = String.Empty Else txtEsfMenor.Text = lentecad.EsfericoMenor
            If lentecad.CilindricoMenor Is Nothing Then txtCilMenor.Text = String.Empty Else txtCilMenor.Text = lentecad.CilindricoMenor
            If lentecad.AdicaoMaior Is Nothing Then txtAdiMaior.Text = String.Empty Else txtAdiMaior.Text = lentecad.AdicaoMaior
            If lentecad.AdicaoMenor Is Nothing Then txtAdMenor.Text = String.Empty Else txtAdMenor.Text = lentecad.AdicaoMenor
            If lentecad.IR Is Nothing Then txtIR.Text = String.Empty Else txtIR.Text = lentecad.IR
            If lentecad.ACOMinimo Is Nothing Then txtACOminimo.Text = String.Empty Else txtACOminimo.Text = lentecad.ACOMinimo

            If lentecad.ABBE Is Nothing Then txtABBE.Text = String.Empty Else txtABBE.Text = lentecad.ABBE

            txtCaracteristicas.Text = lentecad.Caracteristicas
            txtPrecoVenda.Text = Format(lentecad.PrecoVenda, "#,##0.00")
            txtDescontoVenda.Text = Format(lentecad.DescontoVenda, "#,##0.00")
            txtPrecoCompra.Text = Format(lentecad.PrecoCompra, "#,##0.00")
            txtDescontoCompra.Text = Format(lentecad.DescontoCompra, "#,##0.00")
            If lentecad.Diametro Is Nothing Then txtDiametro.Text = String.Empty Else txtDiametro.Text = lentecad.Diametro
            chkAtivo.Checked = lentecad.Ativo
            cbEstoque.Checked = lentecad.ControlaEstoque
            txtDisponibilidade.Text = lentecad.Disponibilidade
            txtAdicaoDisponivel.Text = lentecad.AdicaoDisponivel
            If lentecad.NCM Is Nothing Then txtNCM.Text = String.Empty Else txtNCM.Text = lentecad.NCM
            If lentecad.Tributacao Is Nothing Then txtTributacao.Text = String.Empty Else txtTributacao.Text = lentecad.Tributacao

            If lentecad.Origem Is Nothing Then
                cbOrigem.SelectedIndex = -1
            End If

            If lentecad.Origem = 0 Then
                cbOrigem.SelectedIndex = 0 'Nacional
            ElseIf lentecad.Origem = 1 Then
                cbOrigem.SelectedIndex = 1 'Estrangeira
            ElseIf lentecad.Origem = 2 Then
                cbOrigem.SelectedIndex = 2 'Estrangeira
            End If

            If lentecad.Unidade Is Nothing Then txtUnidade.Text = String.Empty Else txtUnidade.Text = lentecad.Unidade
            If lentecad.GTIN Is Nothing Then txtGtin.Text = String.Empty Else txtGtin.Text = lentecad.GTIN
            If lentecad.QtdeEstoque Is Nothing Then txtSaldo.Text = String.Empty Else txtSaldo.Text = lentecad.QtdeEstoque
            txtPrecoFinal.Text = Format(lentecad.PrecoTabela, "#,##0.00")
            txtPrecoNota.Text = Format(lentecad.PrecoNota, "#,##0.00")

            If lentecad.Especie.ToString.Trim = "B" Then
                tabLentes.Enabled = False
                tabBases.Enabled = True
                tab_Bloco_surfacado.Enabled = False
                tabLenteContato.Enabled = False
                Carrega_bases(lentecad.CodigoLente)
            End If
            If lentecad.Especie.ToString.Trim = "L" Then
                tabLentes.Enabled = True
                tabBases.Enabled = False
                tab_Bloco_surfacado.Enabled = False
                tabLenteContato.Enabled = False
                Carrega_lentes(lentecad.CodigoFabricante, lentecad.CodigoLente)
            End If
            If lentecad.Especie.ToString.Trim = "BS" Then
                tab_Bloco_surfacado.Enabled = True
                tabLentes.Enabled = False
                tabBases.Enabled = False
                tabLenteContato.Enabled = False
                Carrega_bases(lentecad.CodigoLente)
            End If
            If lentecad.Especie.ToString.Trim = "LC" Then
                tabLenteContato.Enabled = True
                tabLentes.Enabled = False
                tabBases.Enabled = False
                tab_Bloco_surfacado.Enabled = False
                Carrega_bases(lentecad.CodigoLente)
            End If
        End If

    End Sub
    Private Sub carrega_combos()
        Dim tbTipo As New DataTable
        Dim tbMat As New DataTable

        d.carrega_Tabela("Select * from tipo_lente", tbTipo)

        cbTipo.DataSource = tbTipo
        cbTipo.DisplayMember = "tipo_lente"
        cbTipo.ValueMember = "cod_tipo_lente"
        cbTipo.SelectedIndex = -1

        d.carrega_Tabela("select * from materiais", tbMat)

        cbMaterial.DataSource = tbMat
        cbMaterial.DisplayMember = "material"
        cbMaterial.ValueMember = "id_material"
        cbMaterial.SelectedIndex = -1

        cbEspecie.DataSource = especie.especies
        cbEspecie.DisplayMember = "desc"
        cbEspecie.ValueMember = "tipo"
    End Sub

    Private Sub CarregaFabricante()
        Dim tbFab As New DataTable
        d.carrega_Tabela("Select * from fabricante", tbFab)

        cbFabricante.DataSource = tbFab
        cbFabricante.DisplayMember = "fabricante"
        cbFabricante.ValueMember = "id_fabricante"
        cbFabricante.SelectedIndex = -1
    End Sub

    Private Sub Carrega_bases(ByVal id_lente As Integer)
        Dim strSQL As String = ""

        grdBloco.Columns.Clear()
        grdBloco.DataSource = Nothing
        grdBloco.AutoGenerateColumns = False
        grdBloco.AllowUserToAddRows = False

        Dim basenominal As New DataGridViewTextBoxColumn
        basenominal.HeaderText = "Base Nominal"
        basenominal.DataPropertyName = "base_nominal"
        basenominal.Width = 95
        grdBloco.Columns.Add(basenominal)

        Dim adicao As New DataGridViewTextBoxColumn
        adicao.HeaderText = "Adição"
        adicao.DataPropertyName = "Adicao"
        adicao.Width = 55
        adicao.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        adicao.DefaultCellStyle.Format = "#0.00"
        grdBloco.Columns.Add(adicao)

        Dim olho As New DataGridViewTextBoxColumn
        olho.HeaderText = "Olho"
        olho.DataPropertyName = "olho"
        olho.Width = 50
        olho.DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        grdBloco.Columns.Add(olho)

        Dim codproduto As New DataGridViewTextBoxColumn
        codproduto.HeaderText = "Cód. Produto"
        codproduto.DataPropertyName = "cod_produto"
        codproduto.Width = 95
        codproduto.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdBloco.Columns.Add(codproduto)

        Dim codbarra As New DataGridViewTextBoxColumn
        codbarra.HeaderText = "Cód. Barra"
        codbarra.DataPropertyName = "cod_barra"
        codbarra.Width = 95
        codbarra.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdBloco.Columns.Add(codbarra)


        Dim esfmenor As New DataGridViewTextBoxColumn
        esfmenor.HeaderText = "Esf. Menor"
        esfmenor.DataPropertyName = "esf_menor"
        esfmenor.Width = 85
        esfmenor.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        esfmenor.DefaultCellStyle.Format = "#0.00"
        grdBloco.Columns.Add(esfmenor)

        Dim esfmaior As New DataGridViewTextBoxColumn
        esfmaior.HeaderText = "Esf. Maior"
        esfmaior.DataPropertyName = "esf_maior"
        esfmaior.Width = 85
        esfmaior.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        esfmaior.DefaultCellStyle.Format = "#0.00"
        grdBloco.Columns.Add(esfmaior)

        strSQL = "select b.* from blocos b inner join produtos p on b.Cod_produto = p.cod_produto where p.cod_lente = " & id_lente
        conexao.CarregaTabela(strSQL, tbBlocos)

        grdBloco.DataSource = tbBlocos
        grdBloco.Refresh()
    End Sub

    Private Sub Carrega_lentes(ByVal id_fab As Integer, ByVal id_lente As Integer)
        Dim ord As String

        grdLentes.Columns.Clear()
        grdLentes.DataSource = Nothing
        grdLentes.AutoGenerateColumns = False
        grdLentes.AllowUserToAddRows = False

        Dim esferico As New DataGridViewTextBoxColumn
        esferico.DataPropertyName = "esferico"
        esferico.HeaderText = "Esférico"
        esferico.Width = 70
        esferico.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        esferico.DefaultCellStyle.Format = "#0.00"
        grdLentes.Columns.Add(esferico)

        Dim cilindrico As New DataGridViewTextBoxColumn
        cilindrico.DataPropertyName = "cilindrico"
        cilindrico.HeaderText = "Cilíndrico"
        cilindrico.Width = 70
        cilindrico.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        cilindrico.DefaultCellStyle.Format = "#0.00"
        grdLentes.Columns.Add(cilindrico)

        Dim codbarra As New DataGridViewTextBoxColumn
        codbarra.DataPropertyName = "cod_barra"
        codbarra.HeaderText = "Cód. de Barra"
        codbarra.Width = 100
        codbarra.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdLentes.Columns.Add(codbarra)

        Dim codproduto As New DataGridViewTextBoxColumn
        codproduto.DataPropertyName = "cod_produto"
        codproduto.HeaderText = "Cód. Produto"
        codproduto.Width = 95
        codproduto.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdLentes.Columns.Add(codproduto)

        If rdCil.Checked Then
            ord = "C"
        Else
            ord = "E"
        End If
        Lente.Filtra(id_fab, id_lente, ord, txtCilFiltro.Text)
        tblentes = Lente.tb

        grdLentes.DataSource = tblentes
        grdLentes.Refresh()

    End Sub
#End Region
#Region "Novo,Salvar, Editar MASTER"

    Private Sub btnDeletar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim res As String
        ' res = lb.deletar(lb.cod_lente, lb.id_fabricante)
        If res.Trim.Substring(0, 3) = "OK:" Then
            MsgBox(res.Trim.Substring(3))
            c_dados()
            Cursor = Cursors.Default
        End If
        If res.Trim.Substring(0, 3) = "ER:" Then
            MsgBox(trata_erro(res.Trim.Substring(3)), MsgBoxStyle.Critical)
        End If
    End Sub
#End Region
#Region "Navegação e Status"
    Public Sub Status()
        'If lb.max = 0 Then
        'lblStatus.Text = "Não há registros para produtos. Pressione o botão novo para adicionar!"
        'Exit Sub
        'End If
        'If lb.posicao > lb.max Then

        ' End If
        'registro = lb.max
        'lblStatus.Text = "Registro " & lb.posicao + 1 & " de " & lb.max & "."
    End Sub
#End Region
#Region "Cad_Lente"
    Private Sub btnLentesIntervalo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLentesIntervalo.Click
        If MessageBox.Show("Deseja cadastrar todas as dioptrias?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim esfMaior, esfMenor, esf, cilMaior, cilMenor, cil, fac As Double
            tipo_cad_lente = "intervalo"
            fac = 0.25
            esfMaior = txtEsfMaior.Text
            esfMenor = txtEsfMenor.Text
            esf = esfMenor
            cilMaior = 0
            cilMenor = txtCilMenor.Text
            cil = cilMenor
            While cil <= cilMaior
                While esf <= esfMaior
                    If esf < 0 Then
                        If (esf + cil) >= esfMenor Then
                            novaLenteIntervalo()
                            txtLenteEsferico.Text = esf
                            txtLenteCilindrico.Text = cil
                            txtFatorPreco.Text = 1
                            SalvaLenteIntervalo()
                        End If
                    Else
                        novaLenteIntervalo()
                        txtLenteEsferico.Text = esf
                        txtLenteCilindrico.Text = cil
                        txtFatorPreco.Text = 1
                        SalvaLenteIntervalo()
                    End If
                    esf = esf + fac
                    Application.DoEvents()
                End While
                cil = cil + fac
                esf = esfMenor
                Application.DoEvents()
            End While
            MessageBox.Show("Dioptrias cadastradas com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            util.DesativaControles(Me.tabLentes)
            AtivaDesativaControle(8)
        Else
            MessageBox.Show("Operação cancelada com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        tipo_cad_lente = "unitario"
    End Sub


#End Region
#Region "Cad_Bloco"

#End Region
#Region "Cad_Bloco_surf"
    Private Sub btnNovoBlocoSurf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovoBlocoSurf.Click
        'bs.novo()
        produtocad.Novo()
        base_origem = "novo"
        DestravaControles(Me.tab_Bloco_surfacado.Controls)
        txtAdicaoSurf.Enabled = True
        txtOlhoSurf.Enabled = True
        txtCodBarrasSurf.Enabled = True
        LimpaControles(Me.tab_Bloco_surfacado.Controls)
        pnlNovoBlocoSurf.Visible = False
        pnlSalvarSurf.Visible = True
        txtBaseSurf.Focus()
    End Sub

    Private Sub btnSalvarBlocoSurf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarBlocoSurf.Click
        Dim chave As Integer
        Dim esfMaior, esfMenor, esf, cilMaior, cilMenor, cil, fac, esf_cil As Double
        Dim max, i, EMax, EMin As Integer
        'If validar() = False Then
        'Exit Sub
        'End If
        Me.Cursor = Cursors.WaitCursor
        Dim res As String
        'INSERINDO BASES PARA MULTIFOCAL
        'If base_origem = "novo" Then
        'Dim Ad_Atual As Double
        'Dim olho As Char = "D"
        'Ad_Atual = lentecad.AdicaoMenor 'lb.adicao_menor
        'txtFatorPrecoSurf.Text = 1
        'Tirar
        'Ad_Atual = lentecad.AdicaoMenor 'lb.adicao_menor
        'If cbTipo.SelectedValue = tipo_lente.BIFOCAIS Or cbTipo.SelectedValue = tipo_lente.INTERMEDIARIAS _
        '   Or txtCodTabela.Text = 11139 Then
        'olho = "A"
        'Ad_Atual = lentecad.AdicaoMenor 'lb.adicao_menor
        'End If
        'Fim tirar
        'esfMaior = InputBox("Informe o esférico Maior da base " & txtBaseSurf.Text & ":")
        'esfMenor = InputBox("Informe o esférico menor da base " & txtBaseSurf.Text & ":")
        'cilMenor = InputBox("Informe menor cilíndrico da base " & txtBaseSurf.Text & ":")
        'EMax = esfMaior
        'EMin = esfMenor
        'If esfMaior < 0 Then
        'EMax = -1 * esfMaior
        'End If
        'If esfMenor < 0 Then
        'EMin = esfMenor * -1
        'End If
        'If EMax < EMin Then
        'EMax = esfMenor * -1
        'EMin = esfMaior
        'End If
        'pbBlocoSurf.Value = 0
        'max = (((esfMaior) - (esfMenor) + 0.25) / 0.25) _
        '* (((lb.adicao_maior - lb.adicao_menor) + 0.25) / 0.25) _
        '* 2
        'pbBlocoSurf.Maximum = max
olho:
        '    While Ad_Atual <= lentecad.AdicaoMaior 'lb.adicao_maior
        'fac = 0.25
        'esf = esfMenor
        'cilMaior = 0
        'cil = cilMenor
        'While cil <= cilMaior
        'While esf <= esfMaior
        'If esf < 0 Then
        'esf_cil = esf + cil
        'Else
        '   esf_cil = esf
        'End If
        '   If (esf_cil) >= esfMenor Then
        'If bs.existe_base_diop(txtBaseSurf.Text, Ad_Atual, olho, txtCodTabela.Text, esf, cil) = False Then
        'bs.novo()
        '  produtocad.Novo()
        ' produtocad.CodigoProduto = chave
        'produtocad.CodigoBarra = txtCodBarrasBloco.Text
        'produtocad.CodigoFabricante = lb.id_fabricante
        'produtocad.CodigoGrupo = 1
        'produtocad.CodigoLente = lb.cod_lente
        'produtocad.ProdutoDescricao = lentecad.NomeProduto & " Base " & txtBaseSurf.Text & " Adição " & Ad_Atual & " olho " & olho &
        '                       " esf. " & Format(esf, "#,##0.00") & " cil. " & Format(cil, "#,##0.00")
        'produtocad.FatorPreco = txtFatorPrecoBloco.Text
        'produtocad.SalvaProduto()
        'If res.Trim.Substring(0, 3) = "OK:" Then

        'End If
        '   If res.Trim.Substring(0, 3) = "ER:" Then
        '  MsgBox(trata_erro(res.Trim.Substring(3)), MsgBoxStyle.Critical)
        'End If
salva_lente:
        ' bs.cod_produto = chave
        'bs.base = txtBaseSurf.Text
        'bs.adicao = Ad_Atual
        'bs.olho = olho
        'sf = esf
        'bs.cil = cil
        'bs.barra = txtCodBarrasSurf.Text
        'res = bs.Salvar()
        ' If res.Trim.Substring(0, 3) = "OK:" Then

        'End If
        '   If res.Trim.Substring(0, 3) = "ER:" Then
        '  MsgBox(trata_erro(res.Trim.Substring(3)), MsgBoxStyle.Critical)
        'End If
        'End If
        'End If
        '   esf = esf + fac
        'End While
        ' cil = cil + fac
        'esf = esfMenor
        'f.Value = i
        'locoSurf.Text = Math.Round((i / max) * 100, 2).ToString & "%"
        'i = i + 1
        'Application.DoEvents()
        'End While
marca:
        ' Ad_Atual = Ad_Atual + 0.25

        'Application.DoEvents()
        'End While
        ' If olho = "D" Then
        'olho = "E"
        'Ad_Atual = lb.adicao_menor
        'GoTo olho
        'End If
        'base_origem = ""
        'End If
        'FIM INSERINDO BASES MULTIFOCAL
        'SALVA INFORMAÇÃO DE BASES NA EDIÇÃO
        If base_origem = "edit" Then
            'p.fldCod_produto = chave
            produtocad.CodigoBarra = txtCodBarrasBloco.Text
            ' produtocad.CodigoFabricante = lb.id_fabricante
            produtocad.CodigoGrupo = 1
            ' produtocad.CodigoLente = lb.cod_lente
            produtocad.ProdutoDescricao = lentecad.NomeProduto & " Base " & txtBase.Text & " Adiçao " & txtAdicao.Text & " olho " & txtOlho.Text
            produtocad.Estoque = CInt(chkEstoqueSurf.Checked)
            produtocad.FatorPreco = txtFatorPrecoBloco.Text
            produtocad.SalvaProduto()
            If res.Trim.Substring(0, 3) = "OK:" Then

            End If
            If res.Trim.Substring(0, 3) = "ER:" Then
                MsgBox(trata_erro(res.Trim.Substring(3)), MsgBoxStyle.Critical)
                GoTo fim
            End If
salva_lente2:
            ' bs.cod_produto = chave
            ' bs.base = txtBaseSurf.Text
            ' bs.adicao = txtAdicaoSurf.Text
            ' bs.olho = txtOlhoSurf.Text
            ' bs.esf = txtEsfSurf.Text
            ' bs.cil = txtCilindricoSurf.Text
            ' bs.barra = txtCodBarrasSurf.Text
            ' res = bs.Salvar()
            If res.Trim.Substring(0, 3) = "OK:" Then

            End If
            If res.Trim.Substring(0, 3) = "ER:" Then
                MsgBox(trata_erro(res.Trim.Substring(3)), MsgBoxStyle.Critical)
            End If
        End If
        'FIM EDIÇÃO BASE
fim:
        'Carrega_bases(lb.cod_lente)
        travaControles(Me.tab_Bloco_surfacado.Controls)
        pnlNovoBlocoSurf.Visible = True
        pnlSalvarSurf.Visible = False
        MsgBox("Concluido")
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub btnCancelarBlocoSurf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarBlocoSurf.Click
        travaControles(Me.tabBases.Controls)
    End Sub
    Private Sub carrega_bloco_surf(ByVal id)
        'txtBaseSurf.Text = bs.base
        'txtAdicaoSurf.Text = rdNum(bs.adicao)
        'txtOlhoSurf.Text = bs.olho
        'txtEsfSurf.Text = rdNum(bs.esf)
        'txtCilindricoSurf.Text = rdNum(bs.cil)
        'txtCodBarrasSurf.Text = bs.barra
        txtFatorPrecoSurf.Text = produtocad.FatorPreco
        txtPreco.Text = CDbl(produtocad.PrecoVenda) * CDbl(txtFatorPrecoSurf.Text)
        chkEstoqueSurf.Checked = produtocad.Estoque
    End Sub
    Private Sub grd_bloco_surf_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_Bloco_surf.CurrentCellChanged
        Dim id As Integer
        Try
            id = grd_Bloco_surf.CurrentRowIndex
            ' bs.Registro(id)
            ' produtocad.RetornaRegistro(bs.cod_produto)
            carrega_bloco_surf(id)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnDeletarBlocoSurf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeletarBlocoSurf.Click
        Dim res As String
        ' If bs.max = 0 Then
        ' MsgBox("Não há registros para deletar")
        'Exit Sub
        ' End If
        ' res = bs.deletar(bs.cod_produto)
        'If res.Trim.Substring(0, 3) = "OK:" Then
        'MsgBox(res.Trim.Substring(3))
        'Carrega_bases(lb.cod_lente)
        'End If
        'If res.Trim.Substring(0, 3) = "ER:" Then
        'MsgBox(trata_erro(res.Trim.Substring(3)), MsgBoxStyle.Critical)
        'End If
    End Sub
    Private Sub mniAdicionarBlocoOrigem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mniAdicionarBlocoOrigem.Click
        Try
            'If txtBlocoOrigem.Text = "" Then
            'Dim cod_origem As Integer
            'cod_origem = InputBox("Informe o código do bloco de origem:")
            'MsgBox(bs.insere_origem(cod_origem, lb.cod_tabela))
            'Carrega_bases(lb.cod_lente)
            'End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub mniExcluirBlocoOrigem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mniExcluirBlocoOrigem.Click
        Dim cod_origem As Integer
        'cod_origem = bs.retorna_bloco_origem(lb.cod_tabela)
        'MsgBox(bs.exclui_origem(cod_origem, lb.cod_tabela))
        'Carrega_bases(lb.cod_lente)
    End Sub
#End Region
#Region "Lente Contato"
    Private Sub btnNovoContato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovoContato.Click
        'LC.novo()
        produtocad.Novo()
        base_origem = "novo"
        DestravaControles(Me.tabLenteContato.Controls)
        txtBaseContato.Enabled = True
        txtEsfContato.Enabled = True
        txtCodBarraContato.Enabled = True
        LimpaControles(Me.tabLenteContato.Controls)
        pnlNovoContato.Visible = False
        pnlSalvarContato.Visible = True
        txtBaseContato.Focus()
    End Sub

    Private Sub btnSalvarContato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarContato.Click
        Me.Cursor = Cursors.WaitCursor
        Dim res As String
        Dim sqlTrans As New objSqlTrans
        produtocad.CodigoBarra = txtCodBarraContato.Text
        'produtocad.CodigoFabricante = lb.id_fabricante
        produtocad.CodigoGrupo = 1
        'produtocad.CodigoLente = lb.cod_lente
        produtocad.FatorPreco = txtFatorPrecoContato.Text
        'If LC.OrigemSalvar = "Novo" Then
        'If LC.existe_base_diop(txtBaseContato.Text, txtCodTabela.Text, txtEsfContato.Text, txtCilContato.Text) = True Then
        'MsgBox("Dioptria já existe!")
        'Me.Cursor = Cursors.Default
        'it Sub
        'End If
        'End If
        'produtocad.ProdutoDescricao = p.nome_lente_contato(lb.nome_lente, txtBaseContato.Text, txtEsfContato.Text, txtCilContato.Text)
        'p.estoque = CInt(chkEstoqueLentes.Checked)
        'sqlTrans.insere_instrucao(p.Salvar(produtoClass.tiposalvar.Transaction))
salva_lente:
        'LC.cod_produto = p.fldCod_produto
        'LC.base = txtBaseContato.Text
        'LC.esf = txtEsfContato.Text
        'LC.cil = txtCilContato.Text
        'sqlTrans.insere_instrucao(LC.Salvar(objLenteContato.tiposalvar.Transaction))
        res = d.executa_transaction(sqlTrans.instrucoes, True)
        If res.Trim.Substring(0, 3) = "OK:" Then
            If tipo_cad_lente = "unitario" Then MsgBox(res.Trim.Substring(3))
        End If
        If res.Trim.Substring(0, 3) = "ER:" Then
            MsgBox(trata_erro(res.Trim.Substring(3)), MsgBoxStyle.Critical)
        End If
        'Carrega_lentes(lb.id_fabricante, lb.cod_lente)
        travaControles(Me.tabLenteContato.Controls)
        pnlNovoContato.Visible = True
        pnlSalvarContato.Visible = False
        Me.Cursor = Cursors.Default
        Application.DoEvents()
    End Sub
    Private Sub btnCancelarCONTATO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarContato.Click
        travaControles(Me.tabLenteContato.Controls)
        pnlNovoContato.Visible = True
        pnlSalvarContato.Visible = False
    End Sub
    Private Sub carrega_lente_contato()
        'txtBaseContato.Text = LC.base
        'txtEsfContato.Text = rdNum(LC.esf)
        'txtCilContato.Text = rdNum(LC.cil)
        't 'xtCodBarraContato.Text = LC.barra
        'txtFatorPrecoContato.Text = p.fator_preco
        'txtPrecoContato.Text = CDbl(p.fldPreco_venda) * CDbl(txtFatorPrecoContato.Text)
        'chkEstoqueContato.Checked = p.estoque
    End Sub
    Private Sub grdContato_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdContato.CurrentCellChanged
        Dim id As Integer
        Try
            id = grdContato.CurrentRowIndex
            'LC.Registro(id)
            'p.filtra(LC.cod_produto)
            carrega_lente_contato()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnDeletarContato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeletarContato.Click
        Dim res As String
        'If LC.max = 0 Then
        ' MsgBox("Não há registros para deletar")
        ' Exit Sub
        ' End If
        ' res = LC.deletar(LC.cod_produto)
        'If res.Trim.Substring(0, 3) = "OK:" Then
        'sgBox(res.Trim.Substring(3))
        'Carrega_bases(lb.cod_lente)
        'End If
        ' If res.Trim.Substring(0, 3) = "ER:" Then
        ' MsgBox(trata_erro(res.Trim.Substring(3)), MsgBoxStyle.Critical)
        ' End If
    End Sub
#End Region
    Private Sub btnCadastrarBase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim base As Double
        Dim adMenor, adMaior, ad, fac As Double
        base = InputBox("Informe a base:")
        fac = 0.25
        adMenor = txtAdMenor.Text
        adMaior = txtAdiMaior.Text
        ad = adMenor
        While ad <= adMaior
            If cbTipo.SelectedValue = tipo_lente.BIFOCAIS Or cbTipo.SelectedValue = tipo_lente.UNIFOCAIS Then
                btnNovoBloco_Click(Me, e)
                txtBase.Text = base
                txtAdicao.Text = ad
                txtOlho.Text = "A"
                btnSalvarBloco_Click(Me, e)
                ad = ad + fac
            End If
        End While
        If cbTipo.SelectedValue = tipo_lente.BIFOCAIS Or cbTipo.SelectedValue = tipo_lente.UNIFOCAIS Then

        End If
    End Sub
    Private Sub txtCodTabela_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodTabela.DoubleClick
        Dim f As New frmLentes_tabela
        f.ShowDialog(Me)
        txtCodTabela.Text = f.txtCodigoLente.Text
        f.Dispose()
    End Sub

#Region "Filtro"
    Private Sub filtrar(ByVal codigo As Long)
        grdBloco.Columns.Clear()
        grdBloco.DataSource = Nothing
        grdBloco.Refresh()

        grdLentes.Columns.Clear()
        grdLentes.DataSource = Nothing
        grdLentes.Refresh()

        If lentecad.RetornaRegistro(codigo) = True Then
            c_dados()
            AtivaDesativaControle(4)
        End If

    End Sub
    Private Sub adFiltro(ByVal r As String, ByRef t As DataTable)
        Dim ro As DataRow
        ro = t.NewRow
        ro(0) = r
        t.Rows.Add(r)
    End Sub

    Private Sub chkFiltroBarrasLentes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFiltroBarrasLentes.CheckedChanged
        'Carrega_lentes(lb.id_fabricante, lb.cod_lente)
    End Sub
    Private Sub chkFiltroBarrasBlocos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Carrega_bases(lb.cod_lente)
    End Sub
#End Region

    Private Sub btnLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpar.Click
        Dim i, m As Integer
        Dim prod As Integer
        m = tblentes.Rows.Count
        i = 0
        Try
            While i < m
                prod = tblentes.Rows(i)("Cod_produto")
                'p.deletar(prod, produtoClass.tiposalvar.Normal)

                lblStatusLentes.Text = "Apagando Registro " & i + 1 & " de " & m
                Application.DoEvents()
                i = i + 1
            End While
            MsgBox("OK!")
            lblStatusLentes.Text = ""
            'Carrega_lentes(lb.id_fabricante, lb.cod_lente)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub btnLimparBlocoSurf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimparBlocoSurf.Click
        Dim r As Integer
        Dim ms As New frmAviso
        If UserID = 1 Then
            r = MsgBox("Deseja realmente eliminar todos os produtos deste bloco?", MsgBoxStyle.YesNo)
            If r = vbYes Then
                Me.Cursor = Cursors.WaitCursor
                ms.StartPosition = FormStartPosition.CenterScreen
                ms.Show("Deletando Registros. Essa operação pode levar vários minutos, aguarde...")
                Application.DoEvents()
                'MsgBox(bs.limpar())
                Me.Cursor = Cursors.Default
                Application.DoEvents()
                ms.Close()
                ms.Dispose()
                'Carrega_bases(lb.cod_lente)

            End If
        End If
    End Sub

    Private Sub btnIntervaloContato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIntervaloContato.Click
        Dim esfMaior, esfMenor, esf, cilMaior, cilMenor, cil, fac, base As Double
        Dim res As frmAviso.respo
        res = AVISO("Deseja realmente cadastrar todas as dioptrias?", Me, frmAviso.tipo_aviso.tipo_sim_nao)
        If res = frmAviso.respo.NAO Then Exit Sub
        tipo_cad_lente = "intervalo"
        fac = InputBox("Fator Acréscimo (0.25 ou 0.50 ...)")
        esfMaior = InputBox("Esférico Maior:")
        esfMenor = InputBox("Esférico menor:")
        base = InputBox("Base:")
        esf = esfMenor
        cilMaior = InputBox("cilindrico maior:")
        cilMenor = InputBox("Cilindrico Menor:")
        cil = cilMenor
        While cil <= cilMaior
            While esf <= esfMaior
                If (esf + cil) >= esfMenor Then
                    btnNovoContato_Click(Me, e)
                    txtBaseContato.Text = base
                    txtEsfContato.Text = esf
                    txtCilContato.Text = cil
                    txtFatorPrecoContato.Text = 1
                    chkEstoqueContato.Checked = True
                    btnSalvarContato_Click(Me, e)
                End If
                esf = esf + fac
            End While
            cil = cil + fac
            esf = esfMenor
        End While
        tipo_cad_lente = "unitario"
        'Carrega_bases(lb.cod_lente)
    End Sub

    Private Sub btnLimparBlocos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimparBlocos.Click
        Dim i, m As Integer
        Dim prod As Integer
        m = tbBlocos.Rows.Count
        i = 0
        Try
            While i < m
                prod = tbBlocos.Rows(i)("Cod_produto")
                'p.deletar(prod, produtoClass.tiposalvar.Normal)

                lblStatusLentes.Text = "Apagando Registro " & i + 1 & " de " & m
                Application.DoEvents()
                i = i + 1
            End While
            MsgBox("OK!")
            lblStatusLentes.Text = ""
            'Carrega_lentes(lb.id_fabricante, lb.cod_lente)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub AlterarContainerDeLentesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlterarContainerDeLentesToolStripMenuItem.Click
        Dim i As String()
        Dim c As Integer = 0
        Dim s As String = ""
        Dim nova_lente As Integer = InputBox("Nova Lente")
        While c < grdLentes.DataSource.rows.count
            If grdLentes.SelectedRows.Item(c).Index Then
                If s = "" Then
                    s = grdLentes.Item(c, 3).ToString
                Else
                    s = s & ";" & grdLentes.Item(c, 3).ToString
                End If
            End If
            c = c + 1
        End While
        MsgBox(s)
        i = s.Split(";")
        c = 0
        While c < i.Length
            d.Comando("Update produtos set cod_lente = " & nova_lente & " where cod_produto = " & i(c) & "", True)
            c = c + 1
        End While
        MsgBox("Concluído")
        'Carrega_lentes(lb.id_fabricante, lb.cod_lente)
    End Sub

    Private Sub rdCil_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdCil.CheckedChanged
        'Carrega_lentes(lb.id_fabricante, lb.cod_lente)
    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        Geral.TipoReg = Belemtech.TiposReg.Novo
        lentecad.Novo()
        grdBloco.DataSource = Nothing
        grdLentes.DataSource = Nothing
        util.AtivaControles(Me)
        AtivaDesativaControle(2)
        txtFatorPreco.Text = 1
        txtFatorPrecoBloco.Text = 1
        btnAdicionar.Enabled = True

        txtCodLente.Text = retorna_Chave("cod_lente", "lentes_blocos", "")
        txtCodTabela.Text = retorna_Chave("cod_tabela", "lentes_tabela", "")
        txtGtin.Text = "SEM GTIN"
        txtCodLente.Focus()
        lblStatus.Text = "Modo de Inclusão. Clique em Salvar ou Cancelar"
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        Geral.TipoReg = Belemtech.TiposReg.Alterar
        util.AtivaControles(Me)
        AtivaDesativaControle(5)
        btnAdicionar.Enabled = True
        lblStatus.Text = "Modo de Edição. Clique em Salvar ou Cancelar"
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        If MessageBox.Show("Deseja salvar os dados do registro?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            lentecad.CodigoLente = Convert.ToInt32(txtCodLente.Text)
            lentecad.CodigoTabela = Convert.ToInt32(txtCodTabela.Text)
            lentecad.CodigoFabricante = Convert.ToInt32(cbFabricante.SelectedValue)
            lentecad.CodigoTipoLente = Convert.ToInt32(cbTipo.SelectedValue)
            lentecad.NomeProduto = txtNomeProduto.Text
            lentecad.NomeComercial = txtNomeComercial.Text
            lentecad.Especie = cbEspecie.SelectedValue
            If txtEsfMaior.Text = String.Empty Then lentecad.EsfericoMaior = Nothing Else lentecad.EsfericoMaior = txtEsfMaior.Text
            If txtEsfMenor.Text = String.Empty Then lentecad.EsfericoMenor = Nothing Else lentecad.EsfericoMenor = txtEsfMenor.Text
            If txtCilMenor.Text = String.Empty Then lentecad.CilindricoMenor = Nothing Else lentecad.CilindricoMenor = txtCilMenor.Text

            If cbEspecie.SelectedValue = "L" Then
                lentecad.AdicaoMenor = Nothing
                lentecad.AdicaoMaior = Nothing
            Else
                If txtAdMenor.Text = String.Empty Then lentecad.AdicaoMenor = Nothing Else lentecad.AdicaoMenor = txtAdMenor.Text
                If txtAdiMaior.Text = String.Empty Then lentecad.AdicaoMaior = Nothing Else lentecad.AdicaoMaior = txtAdiMaior.Text
            End If

            If txtIR.Text = String.Empty Then lentecad.IR = Nothing Else lentecad.IR = txtIR.Text
            If txtACOminimo.Text = String.Empty Then lentecad.ACOMinimo = Nothing Else lentecad.ACOMinimo = txtACOminimo.Text
            If txtABBE.Text = String.Empty Then lentecad.ABBE = Nothing Else lentecad.ABBE = txtABBE.Text
            lentecad.PrecoCusto = 0
            If txtPrecoCompra.Text = String.Empty Then lentecad.PrecoCompra = Nothing Else lentecad.PrecoCompra = txtPrecoCompra.Text
            If txtDescontoCompra.Text = String.Empty Then lentecad.DescontoCompra = Nothing Else lentecad.DescontoCompra = txtDescontoCompra.Text
            If txtPrecoNota.Text = String.Empty Then lentecad.PrecoNota = Nothing Else lentecad.PrecoNota = txtPrecoNota.Text
            If txtPrecoVenda.Text = String.Empty Then lentecad.PrecoVenda = Nothing Else lentecad.PrecoVenda = txtPrecoVenda.Text
            If txtDescontoVenda.Text = String.Empty Then lentecad.DescontoVenda = Nothing Else lentecad.DescontoVenda = txtDescontoVenda.Text
            If txtPrecoFinal.Text = String.Empty Then lentecad.PrecoTabela = Nothing Else lentecad.PrecoTabela = txtPrecoFinal.Text
            lentecad.Caracteristicas = txtCaracteristicas.Text
            If cbMaterial.SelectedValue = 0 Then lentecad.IdMaterial = Nothing Else lentecad.IdMaterial = cbMaterial.SelectedValue
            If txtDiametro.Text = String.Empty Then lentecad.Diametro = Nothing Else lentecad.Diametro = txtDiametro.Text
            lentecad.Ativo = chkAtivo.Checked
            lentecad.Disponibilidade = txtDisponibilidade.Text
            lentecad.AdicaoDisponivel = txtAdicaoDisponivel.Text
            If txtNCM.Text = String.Empty Then lentecad.NCM = Nothing Else lentecad.NCM = txtNCM.Text
            If txtTributacao.Text = String.Empty Then lentecad.Tributacao = Nothing Else lentecad.Tributacao = txtTributacao.Text
            If cbOrigem.SelectedIndex = 0 Then
                lentecad.Origem = 0 'Nacional
            ElseIf cbOrigem.SelectedIndex = 1 Then
                lentecad.Origem = 1 'Estrangeira
            Else
                lentecad.Origem = 2 'Estrangeira
            End If

            lentecad.Unidade = txtUnidade.Text
            lentecad.GTIN = txtGtin.Text
            If txtSaldo.Text = String.Empty Then lentecad.QtdeEstoque = Nothing Else lentecad.QtdeEstoque = txtSaldo.Text

            If txtPrecoFinal.Text = String.Empty Then lentecad.PrecoTabela = Nothing Else lentecad.PrecoTabela = txtPrecoFinal.Text
            If txtPrecoNota.Text = String.Empty Then lentecad.PrecoNota = Nothing Else lentecad.PrecoNota = txtPrecoNota.Text

            lentecad.ControlaEstoque = cbEstoque.Checked

            If lentecad.VerificaCampoObrigatorio() = True Then
                Exit Sub
            End If

            If Geral.TipoReg = Belemtech.TiposReg.Novo Then
                lentecad.SalvaLente()

                If cbTipo.SelectedValue = 50 Then
                    produtocad.Novo()
                    If txtCodBarrasBloco.Text <> String.Empty Then
                        produtocad.CodigoBarra = txtCodBarrasBloco.Text
                    Else
                        produtocad.CodigoBarra = 0
                    End If

                    produtocad.CodigoFabricante = lentecad.CodigoFabricante
                    produtocad.CodigoGrupo = 1
                    produtocad.CodigoLente = lentecad.CodigoLente
                    produtocad.ProdutoDescricao = lentecad.NomeProduto
                    produtocad.Unidade = lentecad.Unidade
                    produtocad.EstoqueMinimo = 0
                    produtocad.EstoqueMaximo = 0
                    produtocad.PrecoCusto = lentecad.PrecoCusto
                    produtocad.PrecoVenda = lentecad.PrecoVenda
                    produtocad.PrecoTabela = lentecad.PrecoTabela
                    produtocad.Desconto = lentecad.DescontoVenda
                    produtocad.Observacao = lentecad.Caracteristicas
                    produtocad.FatorPreco = txtFatorPreco.Text
                    produtocad.Estoque = CInt(chkEstoqueLentes.Checked)
                    produtocad.PrecoCompra = lentecad.PrecoCompra
                    produtocad.DescontoCompra = lentecad.DescontoCompra
                    produtocad.NCM = lentecad.NCM
                    produtocad.CodigoTributacao = lentecad.Tributacao
                    produtocad.Origem = lentecad.Origem
                    produtocad.GTIN = lentecad.GTIN
                    produtocad.CEST = 0
                    produtocad.CodigoBarra = txtCodigoBarra.Text
                    produtocad.Referencia = txtReferencia.Text
                    produtocad.ControlaEstoque = cbEstoque.Checked
                    chave = produtocad.Chave()
                    produtocad.CodigoProduto = chave
                    produtocad.SalvaProduto()
                End If
            Else
                lentecad.AtualizaDadosLente()
                MessageBox.Show(lentecad.AtualizaDadosProdutos())
            End If

            util.DesativaControles(Me)
            AtivaDesativaControle(7)
            btnAdicionar.Enabled = False
            lblStatus.Text = ""
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        If Geral.TipoReg = Belemtech.TiposReg.Novo Then
            util.DesativaControles(Me)
            AtivaDesativaControle(3)
            lblStatus.Text = ""
            btnAdicionar.Enabled = False
        Else
            util.DesativaControles(Me)
            AtivaDesativaControle(3)
            lblStatus.Text = ""
            btnAdicionar.Enabled = False
        End If
    End Sub

    Private Sub btnPesCod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesCod.Click
        Geral.TipoReg = ""
        Dim f As New frmConsultaProduto
        f.strLocalConsulta = "Produtos"
        f.strTela = "Localizar Produto"
        f.ShowDialog()
        filtrar(f.cod_lente)
        'If rbCodLente.Checked = True Then
        'filtrar()
        'ElseIf rbNomeLente.Checked = True Then
        ' lentecad.ParametroPesquisa = txtLocalizar.Text
        ' filtrar()
        'Dim filtro As String
        'filtro = txtLocalizar.Text
        'c_dados()
        'End If


        pbGeral.Visible = True
    End Sub

    Private Sub AtivaDesativaControle(ByVal status As Integer)
        If status = 1 Then '1 - Usado quando o abrimos o formulário pela primeira vez
            'travaControles(Me.tabPrinc.Controls)
            btnAlterar.Enabled = False
            btnSalvar.Enabled = False
            btnCancelar.Enabled = False
        ElseIf status = 2 Then '2 - Usado quando o clicamos no botão novo do formulário
            'DestravaControles(Me.tabPrinc.Controls)
            btnNovo.Enabled = False
            btnAlterar.Enabled = False
            btnSalvar.Enabled = True
            btnCancelar.Enabled = True
        ElseIf status = 3 Then '5- Usado quando o clicamos no botão cancelar do formulário
            'travaControles(Me.tabPrinc.Controls)
            btnNovo.Enabled = True
            btnAlterar.Enabled = False
            btnSalvar.Enabled = False
            btnCancelar.Enabled = False
        ElseIf status = 4 Then '4- Usado quando o clicamos no botão pesquisar do formulário
            'travaControles(Me.tabPrinc.Controls)
            btnNovo.Enabled = False
            btnAlterar.Enabled = True
            btnSalvar.Enabled = False
            btnCancelar.Enabled = False
        ElseIf status = 5 Then '5- Usado quando o clicamos no botão editar do formulário
            'DestravaControles(Me.tabPrinc.Controls)
            btnNovo.Enabled = False
            btnAlterar.Enabled = False
            btnSalvar.Enabled = True
            btnCancelar.Enabled = True
        ElseIf status = 6 Then '6- Usado quando clicamos no botão pesquisar do formulário e a pesquisa retorna mais de 1 registro
            'travaControles(Me.tabPrinc.Controls)
            btnNovo.Enabled = False
            btnAlterar.Enabled = True
            btnSalvar.Enabled = False
            btnCancelar.Enabled = False
        ElseIf status = 7 Then '7- Usado quando clicamos no botão salvar do formulário
            'DestravaControles(Me.tabPrinc.Controls)
            btnNovo.Enabled = True
            btnAlterar.Enabled = True
            btnSalvar.Enabled = False
            btnCancelar.Enabled = False
        ElseIf status = 8 Then '8 - Usado quando clicamos e entramos no formulário da lente
            'DestravaControles(Me.tabPrinc.Controls)
            btnNovaLente.Enabled = True
            btnEditarLente.Enabled = True
            btnDeletarLente.Enabled = True
            btnSalvarLente.Enabled = False
            btnCancelarLente.Enabled = False
        ElseIf status = 9 Then '9 - Usado quando clicamos nos demais botões do formulário da lente
            'DestravaControles(Me.tabPrinc.Controls)
            btnNovaLente.Enabled = False
            btnEditarLente.Enabled = False
            btnDeletarLente.Enabled = False
            btnSalvarLente.Enabled = True
            btnCancelarLente.Enabled = True
        ElseIf status = 10 Then '10 - Usado quando clicamos e entramos no formulário da base
            'DestravaControles(Me.tabPrinc.Controls)
            btnNovoBloco.Enabled = True
            btnEditarBloco.Enabled = True
            btnDeletarBloco.Enabled = True
            btnSalvarBloco.Enabled = False
            btnCancelarBloco.Enabled = False
        ElseIf status = 11 Then '11 - Usado quando clicamos nos demais botões do formulário da base
            'DestravaControles(Me.tabPrinc.Controls)
            btnNovoBloco.Enabled = False
            btnEditarBloco.Enabled = False
            btnDeletarBloco.Enabled = False
            btnSalvarBloco.Enabled = True
            btnCancelarBloco.Enabled = True
        End If

    End Sub

    Private Sub btnExportaLentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportaLentes.Click
        If MessageBox.Show("Deseja exportar para a fila de exportação as informações da lente?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim tbProdutos As New DataTable
            Dim tbLentes As New DataTable
            Dim dsProdutos As New DataSet
            Dim dsLentes As New DataSet
            'DataSet que contém o retorno da pesquisa de produtos
            'dsProdutos = familia.retornaProdutos(p.Cod_lente, p.fld_id_fabricante)
            'Guarda o DataSet em uma tabela
            tbProdutos = dsProdutos.Tables(0)

            Dim strSQL As String = ""
            Dim strLentes = ""
            Dim i, j As Integer

            pbGeral.Visible = True
            pbGeral.Value = 0

            'Pecorre os registro da tabela em questão
            Do While i < tbProdutos.Rows.Count
                j = 0
                strSQL = "Insert into produtos(cod_produto,id_fabricante, cod_lente, cod_barra, cod_grupo, Produto,und," &
                "min_estoque,max_estoque,preco_custo,preco_venda, preco_tabela,desconto," &
                "obs, fator_preco,estoque,preco_compra,desconto_compra) Values(" &
                tbProdutos.Rows(i)("cod_produto") & "," & tbProdutos.Rows(i)("id_fabricante") & "," & tbProdutos.Rows(i)("cod_lente") & "," &
                d.cdin(tbProdutos.Rows(i)("cod_barra")) & "," & tbProdutos.Rows(i)("cod_grupo") & "," & d.PStr(tbProdutos.Rows(i)("produto")) & "," &
                d.PStr(tbProdutos.Rows(i)("und")) & "," & d.cdin(tbProdutos.Rows(i)("min_Estoque")) & "," &
                d.cdin(tbProdutos.Rows(i)("max_Estoque")) & "," & d.cdin(tbProdutos.Rows(i)("preco_custo")) & "," &
                d.cdin(tbProdutos.Rows(i)("preco_venda")) & "," & d.cdin(tbProdutos.Rows(i)("preco_tabela")) & "," &
                d.cdin(tbProdutos.Rows(i)("desconto")) & "," & d.PStr(tbProdutos.Rows(i)("obs")) & "," &
                d.cdin(tbProdutos.Rows(i)("fator_preco")) & "," & d.cdin(tbProdutos.Rows(i)("estoque")) & "," &
                d.cdin(tbProdutos.Rows(i)("preco_compra")) & "," & d.cdin(tbProdutos.Rows(i)("desconto_compra")) & ")"

                'Envia os dados para a tabela exportação
                d.ComandoSQL(strSQL, True)
                pbGeral.Minimum = 1
                pbGeral.Maximum = tbProdutos.Rows.Count
                pbGeral.Increment(i + 1)
                pbGeral.Value = i + 1

                'DataSet que contém o retorno da pesquisa de dioptrias para cada produto cadastrado
                dsLentes = familia.retornaLentes(tbProdutos.Rows(i)("cod_produto"))
                tbLentes = dsLentes.Tables(0)

                'Pecorre os registro da tabela em questão
                Do While j < tbLentes.Rows.Count
                    strLentes = "Insert into lentes(cod_produto,esferico,cilindrico) " &
                    "Values(" & tbLentes.Rows(j)("cod_produto") & "," & d.cdin(tbLentes.Rows(j)("esferico")) & "," &
                    d.cdin(tbLentes.Rows(j)("cilindrico")) & ")"
                    d.ComandoSQL(strLentes, True)
                    j = j + 1
                Loop

                i = i + 1
            Loop
            MessageBox.Show("Enviado " & i & " registro(s) para fila de exportação.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Operação cancelada com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnExportaBase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportaBase.Click
        If MessageBox.Show("Deseja exportar para a fila de exportação as informações da lente?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim tbProdutos As New DataTable
            Dim tbBase As New DataTable
            Dim dsProdutos As New DataSet
            Dim dsBase As New DataSet
            'DataSet que contém o retorno da pesquisa de produtos
            'dsProdutos = familia.retornaProdutos(p.Cod_lente, p.fld_id_fabricante)
            'Guarda o DataSet em uma tabela
            tbProdutos = dsProdutos.Tables(0)

            Dim strSQL As String = ""
            Dim strBase = ""
            Dim i, j As Integer

            pbGeral.Visible = True
            pbGeral.Minimum = 0

            'Pecorre os registro da tabela em questão
            Do While i < tbProdutos.Rows.Count
                j = 0
                strSQL = "Insert into produtos(cod_produto,id_fabricante, cod_lente, cod_barra, cod_grupo, Produto,und," &
                "min_estoque,max_estoque,preco_custo,preco_venda, preco_tabela,desconto," &
                "obs, fator_preco,estoque,preco_compra,desconto_compra) Values(" &
                tbProdutos.Rows(i)("cod_produto") & "," & tbProdutos.Rows(i)("id_fabricante") & "," & tbProdutos.Rows(i)("cod_lente") & "," &
                d.cdin(tbProdutos.Rows(i)("cod_barra")) & "," & tbProdutos.Rows(i)("cod_grupo") & "," & d.PStr(tbProdutos.Rows(i)("produto")) & "," &
                d.PStr(tbProdutos.Rows(i)("und")) & "," & d.cdin(tbProdutos.Rows(i)("min_Estoque")) & "," &
                d.cdin(tbProdutos.Rows(i)("max_Estoque")) & "," & d.cdin(tbProdutos.Rows(i)("preco_custo")) & "," &
                d.cdin(tbProdutos.Rows(i)("preco_venda")) & "," & d.cdin(tbProdutos.Rows(i)("preco_tabela")) & "," &
                d.cdin(tbProdutos.Rows(i)("desconto")) & "," & d.PStr(tbProdutos.Rows(i)("obs")) & "," &
                d.cdin(tbProdutos.Rows(i)("fator_preco")) & "," & d.cdin(tbProdutos.Rows(i)("estoque")) & "," &
                d.cdin(tbProdutos.Rows(i)("preco_compra")) & "," & d.cdin(tbProdutos.Rows(i)("desconto_compra")) & ")"

                'Envia os dados para a tabela exportação
                d.ComandoSQL(strSQL, True)
                pbGeral.Minimum = 1
                pbGeral.Maximum = tbProdutos.Rows.Count
                pbGeral.Increment(i + 1)
                pbGeral.Value = i + 1

                'DataSet que contém o retorno da pesquisa de dioptrias para cada produto cadastrado
                dsBase = familia.retornaBloco(tbProdutos.Rows(i)("cod_produto"))
                tbBase = dsBase.Tables(0)

                'Pecorre os registro da tabela em questão
                Do While j < tbBase.Rows.Count
                    strBase = "Insert into blocos(cod_produto,base_nominal,adicao,olho,esf_maior,esf_menor) " &
                    "Values(" &
                    tbBase.Rows(j)("cod_produto") & "," & d.cdin(tbBase.Rows(j)("base_nominal")) & "," & d.cdin(tbBase.Rows(j)("adicao")) & "," &
                    d.PStr(tbBase.Rows(j)("olho")) & "," & d.cdin(tbBase.Rows(j)("esf_maior")) & "," & d.cdin(tbBase.Rows(j)("esf_menor")) & ")"
                    d.ComandoSQL(strBase, True)
                    j = j + 1
                Loop

                i = i + 1
            Loop
            MessageBox.Show("Enviado " & i & " registro(s) para fila de exportação.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Operação cancelada com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnNovaLente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovaLente.Click
        Geral.TipoReg = Belemtech.TiposReg.Novo
        Lente.Novo()
        produtocad.Novo()
        util.AtivaControles(Me.tabLentes)
        AtivaDesativaControle(9)
        pbGeral.Visible = False
        txtLenteEsferico.Focus()
    End Sub

    Private Sub btnEditarLente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditarLente.Click
        Geral.TipoReg = Belemtech.TiposReg.Alterar
        util.AtivaControles(Me.tabLentes)
        AtivaDesativaControle(9)
        pbGeral.Visible = False
    End Sub

    Private Sub btnSalvarLente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarLente.Click
        If MessageBox.Show("Deseja salvar essa(s) alteração(ões) para a lente?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim chave As Integer

            If Geral.TipoReg = Belemtech.TiposReg.Novo Then
                If Lente.VerificaDioptriaExistente(txtLenteEsferico.Text, txtLenteCilindrico.Text, lentecad.CodigoTabela) = True Then
                    MsgBox("Dioptria já existe!")
                    Me.Cursor = Cursors.Default
                    Exit Sub
                End If

                produtocad.Novo()
                If txtlenteCodBarra.Text <> String.Empty Then
                    produtocad.CodigoBarra = txtlenteCodBarra.Text
                Else
                    produtocad.CodigoBarra = 0
                End If

                produtocad.CodigoFabricante = lentecad.CodigoFabricante
                produtocad.CodigoGrupo = 1
                produtocad.CodigoLente = lentecad.CodigoLente
                produtocad.ProdutoDescricao = lentecad.NomeProduto & " " & txtLenteEsferico.Text & " com " & txtLenteCilindrico.Text
                produtocad.Unidade = lentecad.Unidade
                produtocad.EstoqueMinimo = 0
                produtocad.EstoqueMaximo = 0
                produtocad.PrecoCusto = lentecad.PrecoCusto
                produtocad.PrecoVenda = lentecad.PrecoVenda
                produtocad.PrecoTabela = lentecad.PrecoTabela
                produtocad.Desconto = lentecad.DescontoVenda
                produtocad.Observacao = lentecad.Caracteristicas
                produtocad.FatorPreco = txtFatorPreco.Text
                produtocad.Estoque = CInt(chkEstoqueLentes.Checked)
                produtocad.PrecoCompra = lentecad.PrecoCompra
                produtocad.DescontoCompra = lentecad.DescontoCompra
                produtocad.NCM = lentecad.NCM
                produtocad.CodigoTributacao = lentecad.Tributacao
                produtocad.Origem = lentecad.Origem
                produtocad.GTIN = lentecad.GTIN
                produtocad.CEST = 0
                chave = produtocad.Chave()
                produtocad.SalvaProduto()
            End If

salva_lente:
            If Geral.TipoReg = Belemtech.TiposReg.Novo Then
                Lente.CodigoProduto = chave
                Lente.Esferico = txtLenteEsferico.Text
                Lente.Cilindrico = txtLenteCilindrico.Text
                Lente.SalvaLentes()
                chkFiltroBarrasLentes.Enabled = True
                Application.DoEvents()
            End If

            If Geral.TipoReg = Belemtech.TiposReg.Alterar Then
                If txtCodBarrasBloco.Text <> String.Empty Then
                    produtocad.CodigoBarra = txtCodBarrasBloco.Text
                Else
                    produtocad.CodigoBarra = 0
                End If

                produtocad.CodigoFabricante = lentecad.CodigoFabricante
                produtocad.CodigoGrupo = 1
                produtocad.CodigoLente = lentecad.CodigoLente
                produtocad.ProdutoDescricao = lentecad.NomeProduto & " " & txtLenteEsferico.Text & " com " & txtLenteCilindrico.Text
                produtocad.Unidade = lentecad.Unidade
                produtocad.EstoqueMinimo = 0
                produtocad.EstoqueMaximo = 0
                produtocad.PrecoCusto = lentecad.PrecoCusto
                produtocad.PrecoVenda = lentecad.PrecoVenda
                produtocad.PrecoTabela = lentecad.PrecoTabela
                produtocad.Desconto = lentecad.DescontoVenda
                produtocad.Observacao = lentecad.Caracteristicas
                produtocad.FatorPreco = txtFatorPreco.Text
                produtocad.Estoque = CInt(chkEstoqueLentes.Checked)
                produtocad.PrecoCompra = lentecad.PrecoCompra
                produtocad.DescontoCompra = lentecad.DescontoCompra
                produtocad.NCM = lentecad.NCM
                produtocad.CodigoTributacao = lentecad.Tributacao
                produtocad.Origem = lentecad.Origem
                produtocad.GTIN = lentecad.GTIN
                produtocad.CEST = 0
                produtocad.AtualizaProduto()

                Lente.Esferico = txtLenteEsferico.Text
                Lente.Cilindrico = txtLenteCilindrico.Text
                Lente.AtualizaLentes(produtocad.CodigoProduto)
                chkFiltroBarrasLentes.Enabled = True
                Application.DoEvents()
            End If

            MessageBox.Show("Registro inserido ou alterado com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Carrega_lentes(lentecad.CodigoFabricante, lentecad.CodigoLente)
        Else
            MessageBox.Show("Operação cancelada com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        AtivaDesativaControle(8)
    End Sub

    Private Sub btnCancelarLente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarLente.Click
        'travaControles(Me.tabLentes.Controls)
        util.DesativaControles(Me.tabLentes)
        AtivaDesativaControle(8)
    End Sub

    Private Sub btnDeletarLente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeletarLente.Click
        Geral.TipoReg = Belemtech.TiposReg.Excluir
        Dim res As String = ""
        If MessageBox.Show("Deseja realmente apagar esta dioptria?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            'res = p.deletar(Lente.CodigoProduto, produtoClass.tiposalvar.Normal)
            If res.Trim.Substring(0, 3) = "OK:" Then
                ' Carrega_lentes(lb.id_fabricante, lb.cod_lente)
                MessageBox.Show("Dioptria apagada com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            If res.Trim.Substring(0, 3) = "ER:" Then
                MessageBox.Show(res.Substring(3), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Operação cancelada com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnNovoBloco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovoBloco.Click
        blococad.Novo()
        produtocad.Novo()
        Geral.TipoReg = Belemtech.TiposReg.Novo
        'DestravaControles(Me.tabBases.Controls)
        util.AtivaControles(Me.tabBases)
        AtivaDesativaControle(11)
        'txtAdicao.Enabled = True
        'txtOlho.Enabled = True
        'txtCodBarrasBloco.Enabled = True
        'LimpaControles(Me.tabBases.Controls)
        pbGeral.Visible = False
        txtBase.Focus()
    End Sub

    Private Sub btnEditarBloco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditarBloco.Click
        txtCodBarrasBloco.ReadOnly = False
        Geral.TipoReg = Belemtech.TiposReg.Alterar
        util.AtivaControles(Me.tabBases)
        AtivaDesativaControle(11)
        pbGeral.Visible = False
        txtBase.Focus()
    End Sub

    Private Sub btnSalvarBloco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarBloco.Click
        If MessageBox.Show("Deseja salvar essa(s) alteração(ões) para o bloco?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim chave As Integer
            'INSERINDO BASES PARA MULTIFOCAL
            If Geral.TipoReg = Belemtech.TiposReg.Novo Then
                Dim Ad_Atual As Double
                Dim olho As Char = "D"
                Dim esfMaior As Double = txtEsfMaiorBloco.Text
                Dim esfMenor As Double = txtEsfMenorBloco.Text
                Ad_Atual = lentecad.AdicaoMenor
                If cbTipo.SelectedValue = tipo_lente.UNIFOCAIS Or cbTipo.SelectedValue = tipo_lente.INTERMEDIARIAS _
                Or txtCodTabela.Text = 11139 Then
                    olho = "A"
                    Ad_Atual = lentecad.AdicaoMenor
                End If
                txtFatorPrecoBloco.Text = 1
olho:
                While Ad_Atual <= lentecad.AdicaoMaior
                    If blococad.VerificaExistenciaBaseAdicaoOlho(txtBase.Text, Ad_Atual, olho, txtCodTabela.Text) = False Then
                        blococad.Novo()
                        produtocad.Novo()
                        chave = produtocad.Chave()
                        produtocad.CodigoProduto = chave

                        If txtCodBarrasBloco.Text <> String.Empty Then
                            produtocad.CodigoBarra = txtCodBarrasBloco.Text
                        Else
                            produtocad.CodigoBarra = 0
                        End If

                        produtocad.CodigoFabricante = lentecad.CodigoFabricante
                        produtocad.CodigoGrupo = 1
                        produtocad.CodigoLente = lentecad.CodigoLente
                        produtocad.ProdutoDescricao = lentecad.NomeProduto & " Base " & txtBase.Text & " Adição " & Ad_Atual & " olho " & olho
                        produtocad.Unidade = txtUnidade.Text
                        produtocad.EstoqueMinimo = 0
                        produtocad.EstoqueMaximo = 0
                        produtocad.PrecoCusto = lentecad.PrecoCusto
                        produtocad.PrecoVenda = lentecad.PrecoVenda
                        produtocad.PrecoTabela = txtPrecoFinal.Text
                        produtocad.Desconto = lentecad.DescontoVenda
                        produtocad.Observacao = lentecad.Caracteristicas
                        produtocad.FatorPreco = txtFatorPrecoBloco.Text
                        produtocad.Estoque = 0
                        produtocad.PrecoCompra = lentecad.PrecoCompra
                        produtocad.DescontoCompra = lentecad.DescontoCompra
                        produtocad.NCM = lentecad.NCM
                        produtocad.CodigoTributacao = lentecad.Tributacao
                        produtocad.Origem = lentecad.Origem
                        produtocad.GTIN = lentecad.GTIN
                        produtocad.CEST = lentecad.CEST
                        produtocad.SalvaProduto()
salva_lente:
                        blococad.CodigoProduto = chave
                        blococad.BaseNominal = txtBase.Text
                        blococad.Adicao = Ad_Atual
                        blococad.Olho = olho
                        blococad.EsfericoMaior = esfMaior
                        blococad.EsfericoMenor = esfMenor
                        'b.barra = txtCodBarrasBloco.Text
                        If blococad.SalvaBlocos() = True Then
                            Carrega_bases(lentecad.CodigoLente)
                        End If
                    Else
                        MessageBox.Show("Esta base já existe no sistema.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
marca:
                    Ad_Atual = Ad_Atual + 0.25
                    Application.DoEvents()
                End While
                If olho = "D" Then
                    olho = "E"
                    Ad_Atual = lentecad.AdicaoMenor
                    GoTo olho
                End If
                Geral.TipoReg = ""
                GoTo fim
            End If
            'FIM INSERINDO BASES MULTIFOCAL
            'SALVA INFORMAÇÃO DE BASES NA EDIÇÃO
            If Geral.TipoReg = Belemtech.TiposReg.Alterar Then
                'p.fldCod_produto = chave
                txtFatorPrecoBloco.Text = 1

                If txtCodBarrasBloco.Text <> String.Empty Then
                    produtocad.CodigoBarra = txtCodBarrasBloco.Text
                Else
                    produtocad.CodigoBarra = 0
                End If
                produtocad.CodigoFabricante = lentecad.CodigoFabricante
                produtocad.CodigoGrupo = 1
                produtocad.CodigoLente = lentecad.CodigoLente
                produtocad.ProdutoDescricao = lentecad.NomeProduto & " Base " & txtBase.Text & " Adiçao " & txtAdicao.Text & " olho " & txtOlho.Text
                produtocad.Unidade = txtUnidade.Text
                produtocad.EstoqueMinimo = 0
                produtocad.EstoqueMaximo = 0
                produtocad.PrecoCusto = 0
                produtocad.PrecoVenda = txtPrecoVenda.Text
                produtocad.PrecoTabela = txtPrecoFinal.Text
                produtocad.Desconto = txtDescontoVenda.Text
                produtocad.Observacao = txtCaracteristicas.Text
                produtocad.FatorPreco = txtFatorPrecoBloco.Text
                produtocad.Estoque = 0
                produtocad.PrecoCompra = txtPrecoCompra.Text
                produtocad.DescontoCompra = txtDescontoCompra.Text
                produtocad.NCM = txtNCM.Text
                produtocad.CodigoTributacao = txtTributacao.Text
                produtocad.Origem = cbOrigem.SelectedValue
                produtocad.GTIN = txtGtin.Text
                produtocad.CEST = 0
                produtocad.AtualizaProduto()

salva_lente2:
                'blococad.CodigoProduto = chave
                blococad.BaseNominal = txtBase.Text
                blococad.Adicao = txtAdicao.Text
                blococad.Olho = txtOlho.Text
                blococad.EsfericoMaior = txtEsfMaiorBloco.Text
                blococad.EsfericoMenor = txtEsfMenorBloco.Text
                'b.barra = txtCodBarrasBloco.Text
                blococad.AtualizaBlocos(produtocad.CodigoProduto)
                'FIM EDIÇÃO BASE
fim:
                Carrega_bases(lentecad.CodigoLente)

                MessageBox.Show("Registro(s) inserido(s) ou alterado(s) com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Operação cancelada com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            AtivaDesativaControle(10)
        End If
    End Sub

    Private Sub btnCancelarBloco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarBloco.Click
        util.AtivaControles(Me.tabBases)
        AtivaDesativaControle(10)
    End Sub

    Private Sub btnExportaDados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportaDados.Click
        ' If MessageBox.Show("Deseja exportar para a fila de exportação os dados cadastrais da lente?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        'Dim strSQL As String = "Insert into lentes_blocos(cod_lente,cod_tabela,id_fabricante,cod_tipo_lente, " &
        '      "nome_lente,especie,esf_maior,esf_menor,cil_menor,adicao_menor,adicao_maior, " &
        '      "ir,aco_minimo,abbe,id_material,preco_compra,desconto_compra," &
        '     "preco_venda,desconto_venda,caracteristicas,diametro,ativo) Values(" &
        ' CInt(txtCodLente.Text) & "," & lb.cod_tabela & "," & lb.id_fabricante & "," & lb.cod_tipo_lente & "," &
        'd.PStr(lb.nome_lente) & "," & d.PStr(lb.especie) & "," & d.cdin(lb.esf_maior) &
        '  "," & d.cdin(lb.esf_menor) & "," & d.cdin(lb.cil_menor) & "," & d.cdin(lb.adicao_maior) &
        ' "," & d.cdin(lb.adicao_menor) & "," & d.cdin(lb.ir) & "," & d.cdin(lb.aco_minimo) &
        '  "," & d.cdin(lb.abbe) & "," & lb.id_material & "," & d.cdin(lb.preco_compra) &
        '  "," & d.cdin(lb.desconto_compra) & "," & d.cdin(lb.preco_venda) & "," &
        'd.cdin(lb.desconto_venda) & "," & d.PStr(lb.caracteristicas) & "," & d.cdin(lb.diametro) &
        ' "," & lb.ativo & ")"
        'd.ComandoSQL(strSQL, True)
        'If lb.especie.ToString.Trim = "L" Then
        'Call btnExportaLentes_Click(sender, e)
        'End If
        'If lb.especie.ToString.Trim = "B" Then
        'Call btnExportaBase_Click(sender, e)
        'End If
        'MessageBox.Show("Dados exportados com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Else
        'MessageBox.Show("Operação cancelada com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If
    End Sub

    Private Sub grdBloco_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdBloco.SelectionChanged
        If Geral.TipoReg <> Belemtech.TiposReg.Novo Then
            Dim id As Integer
            id = grdBloco.CurrentRow.Index
            txtBase.Text = grdBloco.CurrentRow.Cells(0).Value
            txtAdicao.Text = grdBloco.CurrentRow.Cells(1).Value
            txtOlho.Text = grdBloco.CurrentRow.Cells(2).Value
            txtEsfMenorBloco.Text = grdBloco.CurrentRow.Cells(5).Value
            txtEsfMaiorBloco.Text = grdBloco.CurrentRow.Cells(6).Value

            produtocad.CodigoProduto = grdBloco.CurrentRow.Cells(3).Value
        End If
    End Sub

    Private Sub SalvaLenteIntervalo()
        'Me.Cursor = Cursors.WaitCursor
        Dim chave As Integer

        If txtCodBarrasBloco.Text <> String.Empty Then
            produtocad.CodigoBarra = txtCodBarrasBloco.Text
        Else
            produtocad.CodigoBarra = 0
        End If

        produtocad.CodigoFabricante = lentecad.CodigoFabricante
        produtocad.CodigoGrupo = 1
        produtocad.CodigoLente = lentecad.CodigoLente
        If Geral.TipoReg = Belemtech.TiposReg.Novo Then
            If Lente.VerificaDioptriaExistente(txtLenteEsferico.Text, txtLenteCilindrico.Text, lentecad.CodigoTabela) = True Then
                MsgBox("Dioptria já existe!")
                Me.Cursor = Cursors.Default
                Exit Sub
            End If
        End If
        produtocad.ProdutoDescricao = lentecad.NomeProduto & " " & txtLenteEsferico.Text & " com " & txtLenteCilindrico.Text
        produtocad.Unidade = lentecad.Unidade
        produtocad.EstoqueMinimo = 0
        produtocad.EstoqueMaximo = 0
        produtocad.PrecoCusto = lentecad.PrecoCusto
        produtocad.PrecoVenda = lentecad.PrecoVenda
        produtocad.PrecoTabela = lentecad.PrecoTabela
        produtocad.Desconto = lentecad.DescontoVenda
        produtocad.Observacao = lentecad.Caracteristicas
        produtocad.FatorPreco = txtFatorPreco.Text
        produtocad.Estoque = CInt(chkEstoqueLentes.Checked)
        produtocad.PrecoCompra = lentecad.PrecoCompra
        produtocad.DescontoCompra = lentecad.DescontoCompra
        produtocad.NCM = lentecad.NCM
        produtocad.CodigoTributacao = lentecad.Tributacao
        produtocad.Origem = lentecad.Origem
        produtocad.GTIN = lentecad.GTIN
        produtocad.CEST = 0
        chave = produtocad.Chave()
        produtocad.CodigoProduto = chave
        produtocad.SalvaProduto()

salva_lente:
        Lente.CodigoProduto = chave
        Lente.Esferico = txtLenteEsferico.Text
        Lente.Cilindrico = txtLenteCilindrico.Text
        Lente.SalvaLentes()

        Carrega_lentes(lentecad.CodigoFabricante, lentecad.CodigoLente)
        chkFiltroBarrasLentes.Enabled = True
    End Sub

    Private Sub novaLenteIntervalo()
        Lente.Novo()
        produtocad.Novo()
    End Sub

    Private Sub txtEsfMaior_Leave(sender As Object, e As EventArgs) Handles txtEsfMaior.Leave
        If txtEsfMaior.Text <> String.Empty Then
            Dim _esfMenor As Decimal = txtEsfMenor.Text
            Dim _esfMaior As Decimal = txtEsfMaior.Text
            txtDisponibilidade.Text = String.Format("{0:#0.00} A {1:#0.00}", _esfMenor, _esfMaior, CultureInfo.InvariantCulture)
        End If
    End Sub

    Private Sub txtAdiMaior_Leave(sender As Object, e As EventArgs) Handles txtAdiMaior.Leave
        If txtAdiMaior.Text <> String.Empty Then
            Dim _adiMenor As Decimal = txtAdMenor.Text
            Dim _adiMaior As Decimal = txtAdiMaior.Text
            txtAdicaoDisponivel.Text = String.Format("{0:#0.00} A {1:#0.00}", _adiMenor, _adiMaior, CultureInfo.InvariantCulture)
        End If
    End Sub

    Private Sub cbEspecie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEspecie.SelectedIndexChanged
        If cbEspecie.SelectedIndex = 1 Or cbEspecie.SelectedIndex = 3 Then
            txtAdMenor.Enabled = False
            txtAdiMaior.Enabled = False
        Else
            txtAdMenor.Enabled = True
            txtAdiMaior.Enabled = True
        End If
    End Sub

    Private Sub txtDescontoVenda_Leave(sender As Object, e As EventArgs) Handles txtDescontoVenda.Leave
        If txtDescontoVenda.Text = String.Empty Then
            txtDescontoVenda.Text = "0,00"
        End If

        Dim _PrecoVenda As Decimal = Convert.ToDecimal(txtPrecoVenda.Text)
        Dim _DescontoVenda As Decimal = Convert.ToDecimal(txtDescontoVenda.Text)
        txtPrecoFinal.Text = String.Format("{0:##0.00}", _PrecoVenda - ((_PrecoVenda * _DescontoVenda) / 100))
    End Sub

    Private Sub txtDescontoCompra_Leave(sender As Object, e As EventArgs) Handles txtDescontoCompra.Leave
        If txtDescontoCompra.Text = String.Empty Then
            txtDescontoCompra.Text = "0,00"
        End If

        Dim _PrecoCompra As Decimal = Convert.ToDecimal(txtPrecoCompra.Text)
        Dim _DescontoCompra As Decimal = Convert.ToDecimal(txtDescontoCompra.Text)
        txtPrecoNota.Text = String.Format("{0:##0.00}", _PrecoCompra - ((_PrecoCompra * _DescontoCompra) / 100))
    End Sub

    Private Sub btnDeletarBloco_Click(sender As Object, e As EventArgs) Handles btnDeletarBloco.Click
        Geral.TipoReg = Belemtech.TiposReg.Excluir
        If MessageBox.Show("Deseja excluir o bloco selecionado?", "CONFIRMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            blococad.ExcluirBlocos(produtocad.CodigoProduto)
            Carrega_bases(lentecad.CodigoLente)
            util.DesativaControles(Me.tabBases)
        End If

    End Sub

    Private Sub grdLentes_SelectionChanged(sender As Object, e As EventArgs) Handles grdLentes.SelectionChanged
        If Geral.TipoReg <> Belemtech.TiposReg.Alterar Then
            Dim id As Integer
            id = grdLentes.CurrentRow.Index
            txtLenteEsferico.Text = grdLentes.CurrentRow.Cells(0).Value
            txtLenteCilindrico.Text = grdLentes.CurrentRow.Cells(1).Value
            txtlenteCodBarra.Text = grdLentes.CurrentRow.Cells(2).Value
            produtocad.CodigoProduto = grdLentes.CurrentRow.Cells(3).Value
            'chkEstoqueLentes.Checked = produtocad.Estoque
            txtPreco.Text = Convert.ToDecimal(txtPrecoVenda.Text) * Convert.ToDecimal(txtFatorPreco.Text)
        End If

    End Sub

    Private Sub cbTipo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbTipo.SelectionChangeCommitted
        If cbTipo.SelectedValue = 50 Then
            Dim tbMaterialArmacao As New DataTable()
            cbMaterial.DataSource = Nothing
            d.carrega_Tabela("Select * from tipo_armacao_material where tipo = " & cbTipo.SelectedValue, tbMaterialArmacao)
            cbMaterial.DisplayMember = "material"
            cbMaterial.ValueMember = "codigo"
            cbMaterial.DataSource = tbMaterialArmacao
            cbMaterial.SelectedIndex = -1

            txtDiametro.Enabled = False
            txtEsfMenor.Enabled = False
            txtEsfMaior.Enabled = False
            txtCilMenor.Enabled = False
            txtAdMenor.Enabled = False
            txtAdiMaior.Enabled = False
            txtACOminimo.Enabled = False
            txtIR.Enabled = False
            txtABBE.Enabled = False
            txtDisponibilidade.Enabled = False
            txtAdicaoDisponivel.Enabled = False
        Else
            Dim tbMat As New DataTable()
            cbMaterial.DataSource = Nothing
            d.carrega_Tabela("select * from materiais", tbMat)

            cbMaterial.DataSource = tbMat
            cbMaterial.DisplayMember = "material"
            cbMaterial.ValueMember = "id_material"
            cbMaterial.SelectedIndex = -1

            txtDiametro.Enabled = True
            txtEsfMenor.Enabled = True
            txtEsfMaior.Enabled = True
            txtCilMenor.Enabled = True
            txtAdMenor.Enabled = True
            txtAdiMaior.Enabled = True
            txtACOminimo.Enabled = True
            txtIR.Enabled = True
            txtABBE.Enabled = True
            txtDisponibilidade.Enabled = True
            txtAdicaoDisponivel.Enabled = True
        End If
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        Dim f As New frmFabricante
        f.ShowDialog()
        f.Dispose()
        CarregaFabricante()
    End Sub

End Class
