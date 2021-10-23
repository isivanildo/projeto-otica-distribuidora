Imports mrotica_util
Public Class frmLentes_tabela
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents txtCodigoLente As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Fabricante As System.Windows.Forms.Label
    Friend WithEvents cbFabricante As System.Windows.Forms.ComboBox
    Friend WithEvents cbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNomeLente As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtEspecie As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtIR As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtABBE As System.Windows.Forms.TextBox
    Friend WithEvents tb2 As System.Windows.Forms.TabControl
    Friend WithEvents txtACOminimo As System.Windows.Forms.TextBox
    Friend WithEvents tabPrinc As System.Windows.Forms.TabPage
    Friend WithEvents cbMaterial As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtCaracteristicas As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtPVenda As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtDesconto As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDisponibilidade As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDescontoCompra As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPrecoCompra As System.Windows.Forms.TextBox
    Friend WithEvents grpFiltro As System.Windows.Forms.GroupBox
    Friend WithEvents cbFitroFab As System.Windows.Forms.ComboBox
    Friend WithEvents txtFiltroCodLente As System.Windows.Forms.TextBox
    Friend WithEvents txtFiltroNome As System.Windows.Forms.TextBox
    Friend WithEvents cbFiltroTipo As System.Windows.Forms.ComboBox
    Friend WithEvents tbTratamentos As System.Windows.Forms.TabPage
    Friend WithEvents cbEspecie As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtPrecoNota As System.Windows.Forms.TextBox
    Friend WithEvents btnUltimo As System.Windows.Forms.Button
    Friend WithEvents btnProximo As System.Windows.Forms.Button
    Friend WithEvents btnAnterior As System.Windows.Forms.Button
    Friend WithEvents btnPrimeiro As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnDeletar As System.Windows.Forms.Button
    Friend WithEvents rbFabricante As System.Windows.Forms.RadioButton
    Friend WithEvents btnPesquisar As System.Windows.Forms.Button
    Friend WithEvents rbCodLente As System.Windows.Forms.RadioButton
    Friend WithEvents rbTipoLente As System.Windows.Forms.RadioButton
    Friend WithEvents rbNomeLente As System.Windows.Forms.RadioButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNCM As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtUnidade As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtOrigem As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTributacao As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtSaldo As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecoFinal As System.Windows.Forms.TextBox
    Friend WithEvents cbLabonorte As System.Windows.Forms.CheckBox
    Friend WithEvents txtAdicao As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLentes_tabela))
        Me.tb2 = New System.Windows.Forms.TabControl()
        Me.tabPrinc = New System.Windows.Forms.TabPage()
        Me.cbLabonorte = New System.Windows.Forms.CheckBox()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.txtPrecoFinal = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtUnidade = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtOrigem = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTributacao = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNCM = New System.Windows.Forms.TextBox()
        Me.btnDeletar = New System.Windows.Forms.Button()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.btnProximo = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnPrimeiro = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtPrecoNota = New System.Windows.Forms.TextBox()
        Me.cbEspecie = New System.Windows.Forms.ComboBox()
        Me.grpFiltro = New System.Windows.Forms.GroupBox()
        Me.rbNomeLente = New System.Windows.Forms.RadioButton()
        Me.rbTipoLente = New System.Windows.Forms.RadioButton()
        Me.rbCodLente = New System.Windows.Forms.RadioButton()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.rbFabricante = New System.Windows.Forms.RadioButton()
        Me.txtFiltroCodLente = New System.Windows.Forms.TextBox()
        Me.cbFiltroTipo = New System.Windows.Forms.ComboBox()
        Me.txtFiltroNome = New System.Windows.Forms.TextBox()
        Me.cbFitroFab = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDescontoCompra = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPrecoCompra = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDisponibilidade = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAdicao = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtDesconto = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtPVenda = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtCaracteristicas = New System.Windows.Forms.TextBox()
        Me.cbMaterial = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtABBE = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtACOminimo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtIR = New System.Windows.Forms.TextBox()
        Me.txtEspecie = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNomeLente = New System.Windows.Forms.TextBox()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbFabricante = New System.Windows.Forms.ComboBox()
        Me.Fabricante = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigoLente = New System.Windows.Forms.TextBox()
        Me.tbTratamentos = New System.Windows.Forms.TabPage()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tb2.SuspendLayout()
        Me.tabPrinc.SuspendLayout()
        Me.grpFiltro.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tb2
        '
        Me.tb2.Controls.Add(Me.tabPrinc)
        Me.tb2.Controls.Add(Me.tbTratamentos)
        Me.tb2.Location = New System.Drawing.Point(8, 16)
        Me.tb2.Name = "tb2"
        Me.tb2.SelectedIndex = 0
        Me.tb2.Size = New System.Drawing.Size(616, 452)
        Me.tb2.TabIndex = 0
        '
        'tabPrinc
        '
        Me.tabPrinc.Controls.Add(Me.cbLabonorte)
        Me.tabPrinc.Controls.Add(Me.txtSaldo)
        Me.tabPrinc.Controls.Add(Me.txtPrecoFinal)
        Me.tabPrinc.Controls.Add(Me.Label18)
        Me.tabPrinc.Controls.Add(Me.Label17)
        Me.tabPrinc.Controls.Add(Me.Label15)
        Me.tabPrinc.Controls.Add(Me.txtUnidade)
        Me.tabPrinc.Controls.Add(Me.Label14)
        Me.tabPrinc.Controls.Add(Me.txtOrigem)
        Me.tabPrinc.Controls.Add(Me.Label10)
        Me.tabPrinc.Controls.Add(Me.txtTributacao)
        Me.tabPrinc.Controls.Add(Me.Label9)
        Me.tabPrinc.Controls.Add(Me.txtNCM)
        Me.tabPrinc.Controls.Add(Me.btnDeletar)
        Me.tabPrinc.Controls.Add(Me.btnUltimo)
        Me.tabPrinc.Controls.Add(Me.btnProximo)
        Me.tabPrinc.Controls.Add(Me.btnAnterior)
        Me.tabPrinc.Controls.Add(Me.btnPrimeiro)
        Me.tabPrinc.Controls.Add(Me.btnCancelar)
        Me.tabPrinc.Controls.Add(Me.btnSalvar)
        Me.tabPrinc.Controls.Add(Me.btnEditar)
        Me.tabPrinc.Controls.Add(Me.btnNovo)
        Me.tabPrinc.Controls.Add(Me.Panel1)
        Me.tabPrinc.Controls.Add(Me.Label16)
        Me.tabPrinc.Controls.Add(Me.txtPrecoNota)
        Me.tabPrinc.Controls.Add(Me.cbEspecie)
        Me.tabPrinc.Controls.Add(Me.grpFiltro)
        Me.tabPrinc.Controls.Add(Me.Label7)
        Me.tabPrinc.Controls.Add(Me.txtDescontoCompra)
        Me.tabPrinc.Controls.Add(Me.Label8)
        Me.tabPrinc.Controls.Add(Me.txtPrecoCompra)
        Me.tabPrinc.Controls.Add(Me.Label5)
        Me.tabPrinc.Controls.Add(Me.txtDisponibilidade)
        Me.tabPrinc.Controls.Add(Me.Label6)
        Me.tabPrinc.Controls.Add(Me.txtAdicao)
        Me.tabPrinc.Controls.Add(Me.Label25)
        Me.tabPrinc.Controls.Add(Me.txtDesconto)
        Me.tabPrinc.Controls.Add(Me.Label24)
        Me.tabPrinc.Controls.Add(Me.txtPVenda)
        Me.tabPrinc.Controls.Add(Me.Label23)
        Me.tabPrinc.Controls.Add(Me.txtCaracteristicas)
        Me.tabPrinc.Controls.Add(Me.cbMaterial)
        Me.tabPrinc.Controls.Add(Me.Label20)
        Me.tabPrinc.Controls.Add(Me.Label13)
        Me.tabPrinc.Controls.Add(Me.txtABBE)
        Me.tabPrinc.Controls.Add(Me.Label12)
        Me.tabPrinc.Controls.Add(Me.txtACOminimo)
        Me.tabPrinc.Controls.Add(Me.Label11)
        Me.tabPrinc.Controls.Add(Me.txtIR)
        Me.tabPrinc.Controls.Add(Me.txtEspecie)
        Me.tabPrinc.Controls.Add(Me.Label4)
        Me.tabPrinc.Controls.Add(Me.Label3)
        Me.tabPrinc.Controls.Add(Me.txtNomeLente)
        Me.tabPrinc.Controls.Add(Me.cbTipo)
        Me.tabPrinc.Controls.Add(Me.Label2)
        Me.tabPrinc.Controls.Add(Me.cbFabricante)
        Me.tabPrinc.Controls.Add(Me.Fabricante)
        Me.tabPrinc.Controls.Add(Me.Label1)
        Me.tabPrinc.Controls.Add(Me.txtCodigoLente)
        Me.tabPrinc.Location = New System.Drawing.Point(4, 22)
        Me.tabPrinc.Name = "tabPrinc"
        Me.tabPrinc.Size = New System.Drawing.Size(608, 426)
        Me.tabPrinc.TabIndex = 0
        Me.tabPrinc.Text = "Cadastro de Lentes e Blocos"
        '
        'cbLabonorte
        '
        Me.cbLabonorte.AutoSize = True
        Me.cbLabonorte.Location = New System.Drawing.Point(473, 40)
        Me.cbLabonorte.Name = "cbLabonorte"
        Me.cbLabonorte.Size = New System.Drawing.Size(115, 17)
        Me.cbLabonorte.TabIndex = 4
        Me.cbLabonorte.Text = "Sai pela Labonorte"
        Me.cbLabonorte.UseVisualStyleBackColor = True
        '
        'txtSaldo
        '
        Me.txtSaldo.BackColor = System.Drawing.Color.White
        Me.txtSaldo.Location = New System.Drawing.Point(520, 220)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.ReadOnly = True
        Me.txtSaldo.Size = New System.Drawing.Size(59, 20)
        Me.txtSaldo.TabIndex = 92
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPrecoFinal
        '
        Me.txtPrecoFinal.BackColor = System.Drawing.Color.White
        Me.txtPrecoFinal.Location = New System.Drawing.Point(400, 220)
        Me.txtPrecoFinal.Name = "txtPrecoFinal"
        Me.txtPrecoFinal.ReadOnly = True
        Me.txtPrecoFinal.Size = New System.Drawing.Size(59, 20)
        Me.txtPrecoFinal.TabIndex = 91
        Me.txtPrecoFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(473, 222)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(47, 16)
        Me.Label18.TabIndex = 90
        Me.Label18.Text = "Estoque"
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(337, 222)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(63, 16)
        Me.Label17.TabIndex = 89
        Me.Label17.Text = "Preço Final"
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(367, 129)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(47, 16)
        Me.Label15.TabIndex = 88
        Me.Label15.Text = "Unidade"
        '
        'txtUnidade
        '
        Me.txtUnidade.BackColor = System.Drawing.Color.White
        Me.txtUnidade.Location = New System.Drawing.Point(416, 125)
        Me.txtUnidade.Name = "txtUnidade"
        Me.txtUnidade.ReadOnly = True
        Me.txtUnidade.Size = New System.Drawing.Size(34, 20)
        Me.txtUnidade.TabIndex = 16
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(281, 129)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 16)
        Me.Label14.TabIndex = 86
        Me.Label14.Text = "Origem"
        '
        'txtOrigem
        '
        Me.txtOrigem.BackColor = System.Drawing.Color.White
        Me.txtOrigem.Location = New System.Drawing.Point(328, 125)
        Me.txtOrigem.Name = "txtOrigem"
        Me.txtOrigem.ReadOnly = True
        Me.txtOrigem.Size = New System.Drawing.Size(31, 20)
        Me.txtOrigem.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(172, 129)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 16)
        Me.Label10.TabIndex = 84
        Me.Label10.Text = "Tributação"
        '
        'txtTributacao
        '
        Me.txtTributacao.BackColor = System.Drawing.Color.White
        Me.txtTributacao.Location = New System.Drawing.Point(233, 125)
        Me.txtTributacao.Name = "txtTributacao"
        Me.txtTributacao.ReadOnly = True
        Me.txtTributacao.Size = New System.Drawing.Size(38, 20)
        Me.txtTributacao.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(15, 129)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 16)
        Me.Label9.TabIndex = 82
        Me.Label9.Text = "NCM"
        '
        'txtNCM
        '
        Me.txtNCM.BackColor = System.Drawing.Color.White
        Me.txtNCM.Location = New System.Drawing.Point(87, 125)
        Me.txtNCM.Name = "txtNCM"
        Me.txtNCM.ReadOnly = True
        Me.txtNCM.Size = New System.Drawing.Size(78, 20)
        Me.txtNCM.TabIndex = 13
        '
        'btnDeletar
        '
        Me.btnDeletar.Image = CType(resources.GetObject("btnDeletar.Image"), System.Drawing.Image)
        Me.btnDeletar.Location = New System.Drawing.Point(168, 292)
        Me.btnDeletar.Name = "btnDeletar"
        Me.btnDeletar.Size = New System.Drawing.Size(75, 34)
        Me.btnDeletar.TabIndex = 26
        Me.btnDeletar.Text = "Excluir"
        Me.btnDeletar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDeletar.UseVisualStyleBackColor = True
        '
        'btnUltimo
        '
        Me.btnUltimo.Image = CType(resources.GetObject("btnUltimo.Image"), System.Drawing.Image)
        Me.btnUltimo.Location = New System.Drawing.Point(547, 294)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(40, 27)
        Me.btnUltimo.TabIndex = 32
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'btnProximo
        '
        Me.btnProximo.Image = CType(resources.GetObject("btnProximo.Image"), System.Drawing.Image)
        Me.btnProximo.Location = New System.Drawing.Point(507, 294)
        Me.btnProximo.Name = "btnProximo"
        Me.btnProximo.Size = New System.Drawing.Size(40, 27)
        Me.btnProximo.TabIndex = 31
        Me.btnProximo.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Image = CType(resources.GetObject("btnAnterior.Image"), System.Drawing.Image)
        Me.btnAnterior.Location = New System.Drawing.Point(467, 294)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(40, 27)
        Me.btnAnterior.TabIndex = 30
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnPrimeiro
        '
        Me.btnPrimeiro.Image = CType(resources.GetObject("btnPrimeiro.Image"), System.Drawing.Image)
        Me.btnPrimeiro.Location = New System.Drawing.Point(427, 294)
        Me.btnPrimeiro.Name = "btnPrimeiro"
        Me.btnPrimeiro.Size = New System.Drawing.Size(40, 27)
        Me.btnPrimeiro.TabIndex = 29
        Me.btnPrimeiro.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(320, 292)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(87, 34)
        Me.btnCancelar.TabIndex = 28
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
        Me.btnSalvar.Location = New System.Drawing.Point(244, 292)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(75, 34)
        Me.btnSalvar.TabIndex = 27
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.Location = New System.Drawing.Point(92, 292)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 34)
        Me.btnEditar.TabIndex = 25
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnNovo
        '
        Me.btnNovo.Image = CType(resources.GetObject("btnNovo.Image"), System.Drawing.Image)
        Me.btnNovo.Location = New System.Drawing.Point(16, 292)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(75, 34)
        Me.btnNovo.TabIndex = 24
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(11, 287)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(581, 44)
        Me.Panel1.TabIndex = 23
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(336, 250)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 16)
        Me.Label16.TabIndex = 80
        Me.Label16.Text = "Preço Nota"
        '
        'txtPrecoNota
        '
        Me.txtPrecoNota.BackColor = System.Drawing.Color.White
        Me.txtPrecoNota.Location = New System.Drawing.Point(401, 249)
        Me.txtPrecoNota.Name = "txtPrecoNota"
        Me.txtPrecoNota.ReadOnly = True
        Me.txtPrecoNota.Size = New System.Drawing.Size(88, 20)
        Me.txtPrecoNota.TabIndex = 22
        Me.txtPrecoNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbEspecie
        '
        Me.cbEspecie.FormattingEnabled = True
        Me.cbEspecie.Items.AddRange(New Object() {"B", "L", "BS", "LC"})
        Me.cbEspecie.Location = New System.Drawing.Point(339, 68)
        Me.cbEspecie.Name = "cbEspecie"
        Me.cbEspecie.Size = New System.Drawing.Size(146, 21)
        Me.cbEspecie.TabIndex = 7
        '
        'grpFiltro
        '
        Me.grpFiltro.Controls.Add(Me.rbNomeLente)
        Me.grpFiltro.Controls.Add(Me.rbTipoLente)
        Me.grpFiltro.Controls.Add(Me.rbCodLente)
        Me.grpFiltro.Controls.Add(Me.btnPesquisar)
        Me.grpFiltro.Controls.Add(Me.rbFabricante)
        Me.grpFiltro.Controls.Add(Me.txtFiltroCodLente)
        Me.grpFiltro.Controls.Add(Me.cbFiltroTipo)
        Me.grpFiltro.Controls.Add(Me.txtFiltroNome)
        Me.grpFiltro.Controls.Add(Me.cbFitroFab)
        Me.grpFiltro.Location = New System.Drawing.Point(11, 341)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Size = New System.Drawing.Size(581, 76)
        Me.grpFiltro.TabIndex = 33
        Me.grpFiltro.TabStop = False
        Me.grpFiltro.Text = "Pesquisar por"
        '
        'rbNomeLente
        '
        Me.rbNomeLente.AutoSize = True
        Me.rbNomeLente.Location = New System.Drawing.Point(293, 21)
        Me.rbNomeLente.Name = "rbNomeLente"
        Me.rbNomeLente.Size = New System.Drawing.Size(98, 17)
        Me.rbNomeLente.TabIndex = 37
        Me.rbNomeLente.TabStop = True
        Me.rbNomeLente.Text = "Nome da Lente"
        Me.rbNomeLente.UseVisualStyleBackColor = True
        '
        'rbTipoLente
        '
        Me.rbTipoLente.AutoSize = True
        Me.rbTipoLente.Location = New System.Drawing.Point(189, 21)
        Me.rbTipoLente.Name = "rbTipoLente"
        Me.rbTipoLente.Size = New System.Drawing.Size(91, 17)
        Me.rbTipoLente.TabIndex = 36
        Me.rbTipoLente.TabStop = True
        Me.rbTipoLente.Text = "Tipo de Lente"
        Me.rbTipoLente.UseVisualStyleBackColor = True
        '
        'rbCodLente
        '
        Me.rbCodLente.AutoSize = True
        Me.rbCodLente.Location = New System.Drawing.Point(95, 21)
        Me.rbCodLente.Name = "rbCodLente"
        Me.rbCodLente.Size = New System.Drawing.Size(88, 17)
        Me.rbCodLente.TabIndex = 35
        Me.rbCodLente.TabStop = True
        Me.rbCodLente.Text = "Código Lente"
        Me.rbCodLente.UseVisualStyleBackColor = True
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Image = CType(resources.GetObject("btnPesquisar.Image"), System.Drawing.Image)
        Me.btnPesquisar.Location = New System.Drawing.Point(408, 17)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(43, 27)
        Me.btnPesquisar.TabIndex = 38
        Me.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'rbFabricante
        '
        Me.rbFabricante.AutoSize = True
        Me.rbFabricante.Location = New System.Drawing.Point(12, 21)
        Me.rbFabricante.Name = "rbFabricante"
        Me.rbFabricante.Size = New System.Drawing.Size(75, 17)
        Me.rbFabricante.TabIndex = 34
        Me.rbFabricante.TabStop = True
        Me.rbFabricante.Text = "Fabricante"
        Me.rbFabricante.UseVisualStyleBackColor = True
        '
        'txtFiltroCodLente
        '
        Me.txtFiltroCodLente.BackColor = System.Drawing.Color.White
        Me.txtFiltroCodLente.Location = New System.Drawing.Point(163, 46)
        Me.txtFiltroCodLente.Name = "txtFiltroCodLente"
        Me.txtFiltroCodLente.Size = New System.Drawing.Size(78, 20)
        Me.txtFiltroCodLente.TabIndex = 40
        Me.txtFiltroCodLente.Visible = False
        '
        'cbFiltroTipo
        '
        Me.cbFiltroTipo.BackColor = System.Drawing.Color.White
        Me.cbFiltroTipo.Location = New System.Drawing.Point(247, 46)
        Me.cbFiltroTipo.Name = "cbFiltroTipo"
        Me.cbFiltroTipo.Size = New System.Drawing.Size(121, 21)
        Me.cbFiltroTipo.TabIndex = 41
        Me.cbFiltroTipo.Visible = False
        '
        'txtFiltroNome
        '
        Me.txtFiltroNome.BackColor = System.Drawing.Color.White
        Me.txtFiltroNome.Location = New System.Drawing.Point(375, 46)
        Me.txtFiltroNome.Name = "txtFiltroNome"
        Me.txtFiltroNome.Size = New System.Drawing.Size(188, 20)
        Me.txtFiltroNome.TabIndex = 42
        Me.txtFiltroNome.Visible = False
        '
        'cbFitroFab
        '
        Me.cbFitroFab.BackColor = System.Drawing.Color.White
        Me.cbFitroFab.Location = New System.Drawing.Point(12, 46)
        Me.cbFitroFab.Name = "cbFitroFab"
        Me.cbFitroFab.Size = New System.Drawing.Size(146, 21)
        Me.cbFitroFab.TabIndex = 39
        Me.cbFitroFab.Visible = False
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(190, 250)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 16)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Desconto (%)"
        '
        'txtDescontoCompra
        '
        Me.txtDescontoCompra.BackColor = System.Drawing.Color.White
        Me.txtDescontoCompra.Location = New System.Drawing.Point(266, 249)
        Me.txtDescontoCompra.Name = "txtDescontoCompra"
        Me.txtDescontoCompra.ReadOnly = True
        Me.txtDescontoCompra.Size = New System.Drawing.Size(59, 20)
        Me.txtDescontoCompra.TabIndex = 21
        Me.txtDescontoCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(16, 250)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 16)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "Preço Compra"
        '
        'txtPrecoCompra
        '
        Me.txtPrecoCompra.BackColor = System.Drawing.Color.White
        Me.txtPrecoCompra.Location = New System.Drawing.Point(102, 249)
        Me.txtPrecoCompra.Name = "txtPrecoCompra"
        Me.txtPrecoCompra.ReadOnly = True
        Me.txtPrecoCompra.Size = New System.Drawing.Size(80, 20)
        Me.txtPrecoCompra.TabIndex = 20
        Me.txtPrecoCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(219, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Adição"
        '
        'txtDisponibilidade
        '
        Me.txtDisponibilidade.BackColor = System.Drawing.Color.White
        Me.txtDisponibilidade.Location = New System.Drawing.Point(447, 96)
        Me.txtDisponibilidade.Name = "txtDisponibilidade"
        Me.txtDisponibilidade.ReadOnly = True
        Me.txtDisponibilidade.Size = New System.Drawing.Size(136, 20)
        Me.txtDisponibilidade.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(366, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "Disponibilidade"
        '
        'txtAdicao
        '
        Me.txtAdicao.BackColor = System.Drawing.Color.White
        Me.txtAdicao.Location = New System.Drawing.Point(261, 96)
        Me.txtAdicao.Name = "txtAdicao"
        Me.txtAdicao.ReadOnly = True
        Me.txtAdicao.Size = New System.Drawing.Size(102, 20)
        Me.txtAdicao.TabIndex = 11
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(190, 222)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(71, 16)
        Me.Label25.TabIndex = 66
        Me.Label25.Text = "Desconto (%)"
        '
        'txtDesconto
        '
        Me.txtDesconto.BackColor = System.Drawing.Color.White
        Me.txtDesconto.Location = New System.Drawing.Point(266, 220)
        Me.txtDesconto.Name = "txtDesconto"
        Me.txtDesconto.ReadOnly = True
        Me.txtDesconto.Size = New System.Drawing.Size(59, 20)
        Me.txtDesconto.TabIndex = 19
        Me.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(16, 222)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 16)
        Me.Label24.TabIndex = 64
        Me.Label24.Text = "Preço Venda"
        '
        'txtPVenda
        '
        Me.txtPVenda.BackColor = System.Drawing.Color.White
        Me.txtPVenda.Location = New System.Drawing.Point(102, 220)
        Me.txtPVenda.Name = "txtPVenda"
        Me.txtPVenda.ReadOnly = True
        Me.txtPVenda.Size = New System.Drawing.Size(80, 20)
        Me.txtPVenda.TabIndex = 18
        Me.txtPVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(16, 156)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(80, 16)
        Me.Label23.TabIndex = 62
        Me.Label23.Text = "Características"
        '
        'txtCaracteristicas
        '
        Me.txtCaracteristicas.BackColor = System.Drawing.Color.White
        Me.txtCaracteristicas.Location = New System.Drawing.Point(99, 156)
        Me.txtCaracteristicas.Multiline = True
        Me.txtCaracteristicas.Name = "txtCaracteristicas"
        Me.txtCaracteristicas.ReadOnly = True
        Me.txtCaracteristicas.Size = New System.Drawing.Size(481, 56)
        Me.txtCaracteristicas.TabIndex = 17
        '
        'cbMaterial
        '
        Me.cbMaterial.BackColor = System.Drawing.Color.White
        Me.cbMaterial.Location = New System.Drawing.Point(88, 68)
        Me.cbMaterial.Name = "cbMaterial"
        Me.cbMaterial.Size = New System.Drawing.Size(151, 21)
        Me.cbMaterial.TabIndex = 5
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(16, 70)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(48, 16)
        Me.Label20.TabIndex = 59
        Me.Label20.Text = "Material"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(133, 100)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 16)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "ABBE"
        '
        'txtABBE
        '
        Me.txtABBE.BackColor = System.Drawing.Color.White
        Me.txtABBE.Location = New System.Drawing.Point(172, 96)
        Me.txtABBE.Name = "txtABBE"
        Me.txtABBE.ReadOnly = True
        Me.txtABBE.Size = New System.Drawing.Size(40, 20)
        Me.txtABBE.TabIndex = 10
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(16, 100)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 16)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "ACO Min."
        '
        'txtACOminimo
        '
        Me.txtACOminimo.BackColor = System.Drawing.Color.White
        Me.txtACOminimo.Location = New System.Drawing.Point(88, 96)
        Me.txtACOminimo.Name = "txtACOminimo"
        Me.txtACOminimo.ReadOnly = True
        Me.txtACOminimo.Size = New System.Drawing.Size(38, 20)
        Me.txtACOminimo.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(502, 70)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 16)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "I. R."
        '
        'txtIR
        '
        Me.txtIR.BackColor = System.Drawing.Color.White
        Me.txtIR.Location = New System.Drawing.Point(532, 68)
        Me.txtIR.Name = "txtIR"
        Me.txtIR.ReadOnly = True
        Me.txtIR.Size = New System.Drawing.Size(51, 20)
        Me.txtIR.TabIndex = 8
        '
        'txtEspecie
        '
        Me.txtEspecie.BackColor = System.Drawing.Color.White
        Me.txtEspecie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEspecie.Location = New System.Drawing.Point(254, 68)
        Me.txtEspecie.MaxLength = 2
        Me.txtEspecie.Name = "txtEspecie"
        Me.txtEspecie.ReadOnly = True
        Me.txtEspecie.Size = New System.Drawing.Size(24, 20)
        Me.txtEspecie.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(289, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Espécie"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nome Lente"
        '
        'txtNomeLente
        '
        Me.txtNomeLente.BackColor = System.Drawing.Color.White
        Me.txtNomeLente.Location = New System.Drawing.Point(88, 40)
        Me.txtNomeLente.Name = "txtNomeLente"
        Me.txtNomeLente.ReadOnly = True
        Me.txtNomeLente.Size = New System.Drawing.Size(359, 20)
        Me.txtNomeLente.TabIndex = 3
        '
        'cbTipo
        '
        Me.cbTipo.BackColor = System.Drawing.Color.White
        Me.cbTipo.Location = New System.Drawing.Point(445, 12)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(138, 21)
        Me.cbTipo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(413, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Tipo"
        '
        'cbFabricante
        '
        Me.cbFabricante.BackColor = System.Drawing.Color.White
        Me.cbFabricante.Location = New System.Drawing.Point(245, 12)
        Me.cbFabricante.Name = "cbFabricante"
        Me.cbFabricante.Size = New System.Drawing.Size(150, 21)
        Me.cbFabricante.TabIndex = 1
        '
        'Fabricante
        '
        Me.Fabricante.Location = New System.Drawing.Point(184, 14)
        Me.Fabricante.Name = "Fabricante"
        Me.Fabricante.Size = New System.Drawing.Size(64, 16)
        Me.Fabricante.TabIndex = 2
        Me.Fabricante.Text = "Fabricante"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cod. Tabela"
        '
        'txtCodigoLente
        '
        Me.txtCodigoLente.BackColor = System.Drawing.Color.White
        Me.txtCodigoLente.Location = New System.Drawing.Point(88, 12)
        Me.txtCodigoLente.Name = "txtCodigoLente"
        Me.txtCodigoLente.ReadOnly = True
        Me.txtCodigoLente.Size = New System.Drawing.Size(72, 20)
        Me.txtCodigoLente.TabIndex = 0
        '
        'tbTratamentos
        '
        Me.tbTratamentos.Location = New System.Drawing.Point(4, 22)
        Me.tbTratamentos.Name = "tbTratamentos"
        Me.tbTratamentos.Padding = New System.Windows.Forms.Padding(3)
        Me.tbTratamentos.Size = New System.Drawing.Size(608, 426)
        Me.tbTratamentos.TabIndex = 1
        Me.tbTratamentos.Text = "Tratamentos"
        Me.tbTratamentos.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 475)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(632, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'frmLentes_tabela
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(632, 497)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.tb2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLentes_tabela"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tabela de Lentes Comercial"
        Me.tb2.ResumeLayout(False)
        Me.tabPrinc.ResumeLayout(False)
        Me.tabPrinc.PerformLayout()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim lb As New objTabela
    Dim l As New objLentesDiop
    Dim d As New dados
    Dim especie As New objEspecie
    Dim strModo As String = ""
#Region "Load, Carrega_dados..."
    Private Sub frmLentes_blocos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ativadestivacontrole(1)
    End Sub
    Private Sub c_dados()
        Status()
        If lb.max = 0 Then
            LimpaControles(Me.tabPrinc.Controls)
            Exit Sub
        End If
        txtCodigoLente.Text = lb.cod_tabela
        cbFabricante.SelectedValue = lb.id_fabricante
        cbTipo.SelectedValue = lb.cod_tipo_lente
        cbMaterial.SelectedValue = lb.id_material
        txtNomeLente.Text = lb.nome_comercial
        txtEspecie.Text = lb.especie
        cbEspecie.SelectedValue = lb.especie
        txtIR.Text = lb.ir
        txtACOminimo.Text = lb.aco_minimo
        txtABBE.Text = lb.abbe
        txtCaracteristicas.Text = lb.caracteristicas
        txtPVenda.Text = rdDinheiro(lb.preco_venda)
        txtDesconto.Text = rdNum(lb.desconto_venda)
        txtPrecoFinal.Text = Format(rdNum(lb.preco_venda) - (rdNum(lb.preco_venda) * ((rdNum(lb.desconto_venda) / 100))), "#,##0.00")
        txtPrecoCompra.Text = rdDinheiro(lb.preco_compra)
        txtDescontoCompra.Text = rdNum(lb.desconto_compra)
        txtPrecoNota.Text = rdDinheiro(lb.preco_nota)
        txtDisponibilidade.Text = lb.disponibilidade
        txtAdicao.Text = lb.adicao
        txtNCM.Text = lb.ncm
        txtTributacao.Text = lb.tributacao
        txtOrigem.Text = lb.origem
        txtUnidade.Text = lb.unidade
        cbLabonorte.Checked = lb.labonorte_sai
        Try
            txtSaldo.Text = lb.saldo_filial(confFilial)("saldo").ToString
        Catch ex As Exception
            txtSaldo.Text = 0
        End Try
    End Sub
    Private Sub carrega_combos()
        Dim tbFab As New DataTable
        Dim tbTipo As New DataTable
        Dim tbMat As New DataTable
        Dim fabView As New DataView
        Dim tipoView As New DataView
        d.carrega_Tabela("Select * from fabricante Order by fabricante", tbFab)

        cbFabricante.DataSource = tbFab
        cbFabricante.DisplayMember = "fabricante"
        cbFabricante.ValueMember = "id_fabricante"

        d.carrega_Tabela("Select * from tipo_lente", tbTipo)

        cbTipo.DataSource = tbTipo
        cbTipo.DisplayMember = "tipo_lente"
        cbTipo.ValueMember = "cod_tipo_lente"

        d.carrega_Tabela("select * from materiais", tbMat)

        cbMaterial.DataSource = tbMat
        cbMaterial.DisplayMember = "material"
        cbMaterial.ValueMember = "id_material"

        cbEspecie.DataSource = especie.especies
        cbEspecie.DisplayMember = "desc"
        cbEspecie.ValueMember = "tipo"
    End Sub

    Private Sub carrega_combos_pesquisa(ByVal tipo As Char)
        Dim tbFab As New DataTable
        Dim tbTipo As New DataTable
        Dim tbMat As New DataTable
        Dim fabView As New DataView
        Dim tipoView As New DataView
        If tipo = "F" Then 'F = Fabricante
            d.carrega_Tabela("Select * from fabricante Order by fabricante", tbFab)
            fabView.Table = tbFab
            cbFitroFab.DataSource = fabView
            cbFitroFab.DisplayMember = "fabricante"
            cbFitroFab.ValueMember = "id_fabricante"
        End If

        If tipo = "L" Then 'L = Tipo de lente
            d.carrega_Tabela("Select * from tipo_lente", tbTipo)
            tipoView.Table = tbTipo
            cbFiltroTipo.DataSource = tipoView
            cbFiltroTipo.DisplayMember = "tipo_lente"
            cbFiltroTipo.ValueMember = "cod_tipo_lente"
        End If
    End Sub
#End Region
#Region "Novo,Salvar, Editar MASTER"
#End Region
#Region "Navegação e Status"
    Public Sub Status()
        If lb.max = 0 Then
            lblStatus.Text = "Não há registros para produtos. Pressione o botão novo para adicionar!"
            Exit Sub
        End If
        If lb.posicao > lb.max Then

        End If
        lblStatus.Text = "Registro " & lb.posicao + 1 & " de " & lb.max
    End Sub
#End Region
#Region "Tratamento"
    Private Sub txtDesconto_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDesconto.DoubleClick
        Dim preco_final As Double
        Dim desconto As Double
        Dim pd As Double
        preco_final = InputBox("Informe o preço final:")
        desconto = Format(CDbl(lb.preco_venda - preco_final), "#,##0.00")
        pd = Format(CDbl(desconto / lb.preco_venda) * 100, "#,##0.00")
        txtDesconto.Text = pd
    End Sub
    Private Sub txtDesconto_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDesconto.LostFocus
        If txtDesconto.Text = "" Then txtDesconto.Text = 0
    End Sub
#End Region
#Region "Filtro"
    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim filtro As String
        Dim sqli, sqle As String
        sqli = "Select * from "
        lb.Source("Select * from lentes_tabela where nome_comercial like '%" & filtro & "%' order by nome_comercial")
        lb.primeiro()
        c_dados()
    End Sub
    Private Sub filtrar()
        Dim filtro As New DataTable
        Dim sqlFiltro As String = ""
        Dim sql, sqli, sqle As String
        Dim i As Integer = 0
        sqli = "Select * from lentes_tabela "
        sqle = " order by nome_comercial"
        filtro.Columns.Add("filtro")
        If rbFabricante.Checked = True Then
            adFiltro("  id_fabricante = " & cbFitroFab.SelectedValue & "", filtro)
        End If
        If rbCodLente.Checked = True Then
            adFiltro(" cod_tabela = " & txtFiltroCodLente.Text, filtro)
        End If
        If rbNomeLente.Checked = True Then
            adFiltro(" nome_comercial like '" & txtFiltroNome.Text & "'", filtro)
        End If
        If rbTipoLente.Checked = True Then
            adFiltro(" cod_tipo_lente = " & cbFiltroTipo.SelectedValue & "", filtro)
        End If
        'Monta Filtro
        i = 0
        Try
            While i < filtro.Rows.Count
                If i = 0 Then
                    sqlFiltro = " Where " & filtro.Rows(i)(0)
                Else
                    sqlFiltro = sqlFiltro & " and " & filtro.Rows(i)(0)
                End If
                i = i + 1
            End While
        Catch ex As Exception

        End Try
        filtro.Dispose()
        If sqlFiltro.Trim.ToUpper = "WHERE" Then sqlFiltro = ""
        sql = sqli & sqlFiltro & sqle
        lb.Source(sql)
        lb.primeiro()
        carrega_combos()
        c_dados()
    End Sub
    Private Sub adFiltro(ByVal r As String, ByRef t As DataTable)
        Dim ro As DataRow
        ro = t.NewRow
        ro(0) = r
        t.Rows.Add(r)
    End Sub
#End Region

    Private Sub txtDescontoCompra_Leave(sender As System.Object, e As System.EventArgs) Handles txtDescontoCompra.Leave
        Try
            Dim nPrecoCompra As Double
            Dim nDesconto As Double
            Dim nValor As Double

            nPrecoCompra = CDbl(txtPrecoCompra.Text)
            nDesconto = 100 - (CDbl(rdNum(txtDescontoCompra.Text)))

            nValor = (nPrecoCompra * nDesconto) / 100

            txtPrecoNota.Text = nValor
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnNovo_Click(sender As System.Object, e As System.EventArgs) Handles btnNovo.Click
        lb.novo()
        DestravaControles(Me.tabPrinc.Controls)
        LimpaControles(Me.tabPrinc.Controls)
        cbLabonorte.Checked = True
        ativadestivacontrole(2)
        txtCodigoLente.Focus()
        lblStatus.Text = "Modo de Adição. Clique em Salvar ou Cancelar"
        strModo = "Novo"
        carrega_combos()
    End Sub

    Private Sub btnEditar_Click(sender As System.Object, e As System.EventArgs) Handles btnEditar.Click
        DestravaControles(Me.tabPrinc.Controls)
        ativadestivacontrole(5)
        lb.editar()
        lb.chaveCriterio = lb.cod_tabela
    End Sub

    Private Sub btnSalvar_Click(sender As System.Object, e As System.EventArgs) Handles btnSalvar.Click
        Dim r As DataRow
        Dim up As New SqlClient.SqlCommand
        Dim chave As Integer
        Dim res As String
        Dim checagem As String = ""
        lb.cod_tabela = txtCodigoLente.Text
        lb.id_fabricante = cbFabricante.SelectedValue
        lb.cod_tipo_lente = cbTipo.SelectedValue
        lb.nome_comercial = txtNomeLente.Text
        lb.especie = cbEspecie.SelectedValue
        If txtEspecie.Text.Trim = "L" Then
            txtAdicao.Text = Nothing
        End If
        lb.ir = pnum(txtIR.Text)
        lb.aco_minimo = pnum(txtACOminimo.Text)
        lb.abbe = pnum(txtABBE.Text)
        lb.id_material = cbMaterial.SelectedValue
        lb.caracteristicas = txtCaracteristicas.Text
        lb.preco_venda = wrNum(txtPVenda.Text)
        lb.desconto_venda = wrNum(txtDesconto.Text)
        lb.preco_compra = wrNum(txtPrecoCompra.Text)
        lb.desconto_compra = wrNum(txtDescontoCompra.Text)
        lb.fator_preco_prod = 1
        lb.preco_nota = wrNum(txtPrecoNota.Text)
        lb.disponibilidade = txtDisponibilidade.Text
        lb.adicao = txtAdicao.Text
        If strModo = "Novo" Then
            lb.ncm = 90015000
            lb.tributacao = 0
            lb.origem = "N"
            lb.unidade = "UN"
        Else
            lb.ncm = CInt(txtNCM.Text)
            lb.tributacao = CInt(txtTributacao.Text)
            lb.origem = txtOrigem.Text
            lb.unidade = txtUnidade.Text
        End If
        If cbLabonorte.Checked = True Then
            lb.labonorte_sai = True
        Else
            lb.labonorte_sai = False
        End If
        res = lb.Salvar()
        If res.Trim.Substring(0, 3) = "OK:" Then
            MsgBox(res.Trim.Substring(3))
            ativadestivacontrole(7)
        End If
        If res.Trim.Substring(0, 3) = "ER:" Then
            MsgBox(trata_erro(res.Trim.Substring(3)), MsgBoxStyle.Critical)
            lb.ultima_posicao()
        End If
        c_dados()
        Status()
        travaControles(Me.tabPrinc.Controls)
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        If strModo = "Novo" Then
            travaControles(Me.tabPrinc.Controls)
            LimpaControles(Me.tabPrinc.Controls)
            ativadestivacontrole(1)
            lblStatus.Text = ""
        Else
            lb.ultima_posicao()
            c_dados()
            carrega_combos()
            travaControles(Me.tabPrinc.Controls)
            ativadestivacontrole(3)
        End If
    End Sub

    Private Sub btnDeletar_Click(sender As System.Object, e As System.EventArgs) Handles btnDeletar.Click
        Dim res As String
        res = lb.deletar(lb.cod_tabela)
        If res.Trim.Substring(0, 3) = "OK:" Then
            MsgBox(res.Trim.Substring(3))
            c_dados()
            Cursor = Cursors.Default
        End If
        If res.Trim.Substring(0, 3) = "ER:" Then
            MsgBox(trata_erro(res.Trim.Substring(3)), MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btnPrimeiro_Click(sender As System.Object, e As System.EventArgs) Handles btnPrimeiro.Click
        lb.primeiro()
        c_dados()
        If lb.posicao + 1 = 1 Then
            btnAnterior.Enabled = False
            btnPrimeiro.Enabled = False
        End If
        If lb.posicao + 1 <= lb.max Then
            btnProximo.Enabled = True
            btnUltimo.Enabled = True
        End If
    End Sub

    Private Sub btnProximo_Click(sender As System.Object, e As System.EventArgs) Handles btnProximo.Click
        lb.proximo()
        c_dados()
        If lb.posicao + 1 < lb.max Then
            btnPrimeiro.Enabled = True
            btnAnterior.Enabled = True
        Else
            btnUltimo.Enabled = False
            btnProximo.Enabled = False
        End If
    End Sub

    Private Sub btnUltimo_Click(sender As System.Object, e As System.EventArgs) Handles btnUltimo.Click
        lb.ultimo()
        c_dados()
        If (lb.posicao + 1 = lb.max) Then
            btnPrimeiro.Enabled = True
            btnAnterior.Enabled = True
            btnProximo.Enabled = False
            btnUltimo.Enabled = False
        End If
    End Sub

    Private Sub ativadestivacontrole(ByVal status As Integer)
        If status = 1 Then '1 - Usado quando o abrimos o formulário pela primeira vez
            travaControles(Me.tabPrinc.Controls)
            btnNovo.Enabled = True
            btnEditar.Enabled = False
            btnDeletar.Enabled = False
            btnSalvar.Enabled = False
            btnCancelar.Enabled = False
            btnPrimeiro.Enabled = False
            btnAnterior.Enabled = False
            btnProximo.Enabled = False
            btnUltimo.Enabled = False
        ElseIf status = 2 Then '2 - Usado quando o clicamos no botão novo do formulário
            DestravaControles(Me.tabPrinc.Controls)
            btnNovo.Enabled = False
            btnEditar.Enabled = False
            btnDeletar.Enabled = False
            btnSalvar.Enabled = True
            btnCancelar.Enabled = True
            btnPrimeiro.Enabled = False
            btnAnterior.Enabled = False
            btnProximo.Enabled = False
            btnUltimo.Enabled = False
        ElseIf status = 3 Then '5- Usado quando o clicamos no botão cancelar do formulário
            travaControles(Me.tabPrinc.Controls)
            btnNovo.Enabled = True
            btnEditar.Enabled = True
            btnDeletar.Enabled = True
            btnSalvar.Enabled = False
            btnCancelar.Enabled = False
        ElseIf status = 4 Then '4- Usado quando o clicamos no botão pesquisar do formulário
            travaControles(Me.tabPrinc.Controls)
            btnNovo.Enabled = False
            btnEditar.Enabled = True
            btnDeletar.Enabled = True
            btnSalvar.Enabled = False
            btnCancelar.Enabled = False
        ElseIf status = 5 Then '5- Usado quando o clicamos no botão editar do formulário
            DestravaControles(Me.tabPrinc.Controls)
            btnNovo.Enabled = False
            btnEditar.Enabled = False
            btnDeletar.Enabled = False
            btnSalvar.Enabled = True
            btnCancelar.Enabled = True
        ElseIf status = 6 Then '6- Usado quando clicamos no botão pesquisar do formulário e a pesquisa retorna mais de 1 registro
            travaControles(Me.tabPrinc.Controls)
            btnNovo.Enabled = False
            btnEditar.Enabled = True
            btnDeletar.Enabled = True
            btnSalvar.Enabled = False
            btnCancelar.Enabled = False
        ElseIf status = 7 Then '7- Usado quando clicamos no botão salvar do formulário
            DestravaControles(Me.tabPrinc.Controls)
            btnNovo.Enabled = True
            btnEditar.Enabled = True
            btnDeletar.Enabled = True
            btnSalvar.Enabled = False
            btnCancelar.Enabled = False
        End If

    End Sub

    Private Sub btnPesquisar_Click(sender As System.Object, e As System.EventArgs) Handles btnPesquisar.Click
        filtrar()
        If lb.max = 1 Then
            btnPrimeiro.Enabled = False
            btnAnterior.Enabled = False
            btnProximo.Enabled = False
            btnUltimo.Enabled = False
            ativadestivacontrole(6)
        End If
        If lb.max > 1 Then
            btnProximo.Enabled = True
            btnUltimo.Enabled = True
            ativadestivacontrole(6)
        End If
    End Sub

    Private Sub rbFabricante_Click(sender As System.Object, e As System.EventArgs) Handles rbFabricante.Click
        cbFitroFab.Visible = True
        cbFitroFab.Focus()
        carrega_combos_pesquisa("F")
        txtFiltroCodLente.Visible = False
        cbFiltroTipo.Visible = False
        txtFiltroNome.Visible = False
    End Sub

    Private Sub rbCodLente_Click(sender As System.Object, e As System.EventArgs) Handles rbCodLente.Click
        cbFitroFab.Visible = False
        txtFiltroCodLente.Visible = True
        txtFiltroCodLente.Focus()
        txtFiltroCodLente.Location = New System.Drawing.Point(12, 46)
        cbFiltroTipo.Visible = False
        txtFiltroNome.Visible = False
    End Sub

    Private Sub rbTipoLente_Click(sender As System.Object, e As System.EventArgs) Handles rbTipoLente.Click
        cbFitroFab.Visible = False
        carrega_combos_pesquisa("L")
        txtFiltroCodLente.Visible = False
        cbFiltroTipo.Visible = True
        cbFiltroTipo.Location = New System.Drawing.Point(12, 46)
        txtFiltroNome.Visible = False
    End Sub

    Private Sub rbNomeLente_Click(sender As System.Object, e As System.EventArgs) Handles rbNomeLente.Click
        cbFitroFab.Visible = False
        txtFiltroCodLente.Visible = False
        cbFiltroTipo.Visible = False
        txtFiltroNome.Location = New System.Drawing.Point(12, 46)
        txtFiltroNome.Width = 300
        txtFiltroNome.Visible = True
    End Sub

    Private Sub txtFiltroCodLente_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtFiltroCodLente.KeyPress
        If rbCodLente.Checked = True Then
            If Not Char.IsNumber(e.KeyChar) And (Not e.KeyChar = vbBack) And (Not e.KeyChar = Convert.ToChar(Keys.Return)) Then
                e.Handled = True
                MessageBox.Show("Neste campo só é permitido números.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnAnterior_Click(sender As System.Object, e As System.EventArgs) Handles btnAnterior.Click
        lb.anterior()
        c_dados()
        If lb.posicao + 1 = 1 Then
            btnAnterior.Enabled = False
            btnPrimeiro.Enabled = False
        End If
        If lb.posicao + 1 <= lb.max Then
            btnProximo.Enabled = True
            btnUltimo.Enabled = True
        End If
    End Sub

    Private Sub txtFiltroCodLente_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtFiltroCodLente.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                If txtFiltroCodLente.Text <> String.Empty Then
                    Call btnPesquisar_Click(sender, e)
                Else
                    MessageBox.Show("Informe o código ou nome da lente.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
        End Select
    End Sub
End Class
