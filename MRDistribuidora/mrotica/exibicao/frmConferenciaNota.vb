Imports mrotica_util
Imports System.Net
Imports System.Data
Imports System.Data.SqlClient
Imports System.Xml

Public Class frmConferenciaNota
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
    Friend WithEvents grdProd As System.Windows.Forms.DataGrid
    Friend WithEvents btnLimpa As System.Windows.Forms.Button
    Friend WithEvents txtCodBarra As System.Windows.Forms.TextBox
    Friend WithEvents btnRelat As System.Windows.Forms.Button
    Friend WithEvents txtDoc As System.Windows.Forms.TextBox
    Friend WithEvents lblDesc As System.Windows.Forms.Label
    Friend WithEvents dtCont As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstNex As System.Windows.Forms.ListBox
    Friend WithEvents btnInvetario As System.Windows.Forms.Button
    Friend WithEvents btnExcluiItem As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPedidos As System.Windows.Forms.TextBox
    Friend WithEvents grpCabecalho As System.Windows.Forms.GroupBox
    Friend WithEvents txtObs As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents grpDetalhes As System.Windows.Forms.GroupBox
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbFornecedor As System.Windows.Forms.ComboBox
    Friend WithEvents btnCadBarra As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnRelatorioOutros As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AtualizarPreçoCompraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtValorFrete As System.Windows.Forms.TextBox
    Friend WithEvents lblValorFrete As System.Windows.Forms.Label
    Friend WithEvents txtValorTotalNota As System.Windows.Forms.TextBox
    Friend WithEvents lblValorTotalNota As System.Windows.Forms.Label
    Friend WithEvents txtValorTotalProd As System.Windows.Forms.TextBox
    Friend WithEvents lblValorTotalProd As System.Windows.Forms.Label
    Friend WithEvents txtVParcelas As System.Windows.Forms.TextBox
    Friend WithEvents lblVParcela As System.Windows.Forms.Label
    Friend WithEvents txtNParcelas As System.Windows.Forms.TextBox
    Friend WithEvents lblNParcelas As System.Windows.Forms.Label
    Friend WithEvents btnImportar As System.Windows.Forms.Button
    Friend WithEvents txtQtde As System.Windows.Forms.TextBox
    Friend WithEvents lblQtde As System.Windows.Forms.Label
    Friend WithEvents btnManual As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents pb As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbPagamento As System.Windows.Forms.ComboBox
    Friend WithEvents cbAvulsa As System.Windows.Forms.CheckBox
    Friend WithEvents btnEntradaAvulsa As System.Windows.Forms.Button
    Friend WithEvents cbReembolso As System.Windows.Forms.CheckBox
    Friend WithEvents cbFrete As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConferenciaNota))
        Me.grdProd = New System.Windows.Forms.DataGrid()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AtualizarPreçoCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtCodBarra = New System.Windows.Forms.TextBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.txtDoc = New System.Windows.Forms.TextBox()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.dtCont = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstNex = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPedidos = New System.Windows.Forms.TextBox()
        Me.grpCabecalho = New System.Windows.Forms.GroupBox()
        Me.cbReembolso = New System.Windows.Forms.CheckBox()
        Me.cbFrete = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbPagamento = New System.Windows.Forms.ComboBox()
        Me.txtQtde = New System.Windows.Forms.TextBox()
        Me.lblQtde = New System.Windows.Forms.Label()
        Me.txtVParcelas = New System.Windows.Forms.TextBox()
        Me.lblVParcela = New System.Windows.Forms.Label()
        Me.txtNParcelas = New System.Windows.Forms.TextBox()
        Me.lblNParcelas = New System.Windows.Forms.Label()
        Me.txtValorFrete = New System.Windows.Forms.TextBox()
        Me.lblValorFrete = New System.Windows.Forms.Label()
        Me.txtValorTotalNota = New System.Windows.Forms.TextBox()
        Me.lblValorTotalNota = New System.Windows.Forms.Label()
        Me.txtValorTotalProd = New System.Windows.Forms.TextBox()
        Me.lblValorTotalProd = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbFornecedor = New System.Windows.Forms.ComboBox()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpDetalhes = New System.Windows.Forms.GroupBox()
        Me.btnEntradaAvulsa = New System.Windows.Forms.Button()
        Me.cbAvulsa = New System.Windows.Forms.CheckBox()
        Me.btnCadBarra = New System.Windows.Forms.Button()
        Me.btnLimpa = New System.Windows.Forms.Button()
        Me.btnExcluiItem = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.pb = New System.Windows.Forms.ToolStripProgressBar()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnManual = New System.Windows.Forms.Button()
        Me.btnRelatorioOutros = New System.Windows.Forms.Button()
        Me.btnImportar = New System.Windows.Forms.Button()
        Me.btnRelat = New System.Windows.Forms.Button()
        Me.btnInvetario = New System.Windows.Forms.Button()
        CType(Me.grdProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.grpCabecalho.SuspendLayout()
        Me.grpDetalhes.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdProd
        '
        Me.grdProd.ContextMenuStrip = Me.ContextMenuStrip1
        Me.grdProd.DataMember = ""
        Me.grdProd.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdProd.Location = New System.Drawing.Point(8, 206)
        Me.grdProd.Name = "grdProd"
        Me.grdProd.ReadOnly = True
        Me.grdProd.Size = New System.Drawing.Size(804, 356)
        Me.grdProd.TabIndex = 4
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AtualizarPreçoCompraToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(200, 26)
        '
        'AtualizarPreçoCompraToolStripMenuItem
        '
        Me.AtualizarPreçoCompraToolStripMenuItem.Name = "AtualizarPreçoCompraToolStripMenuItem"
        Me.AtualizarPreçoCompraToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.AtualizarPreçoCompraToolStripMenuItem.Text = "Atualizar Preço Compra"
        '
        'txtCodBarra
        '
        Me.txtCodBarra.Location = New System.Drawing.Point(101, 16)
        Me.txtCodBarra.Name = "txtCodBarra"
        Me.txtCodBarra.Size = New System.Drawing.Size(106, 20)
        Me.txtCodBarra.TabIndex = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "lixeira.png")
        Me.ImageList1.Images.SetKeyName(1, "excluir.png")
        Me.ImageList1.Images.SetKeyName(2, "barra.png")
        Me.ImageList1.Images.SetKeyName(3, "salvar.png")
        Me.ImageList1.Images.SetKeyName(4, "importa_nota.png")
        Me.ImageList1.Images.SetKeyName(5, "nota_manual.png")
        Me.ImageList1.Images.SetKeyName(6, "entrada_estoque.png")
        Me.ImageList1.Images.SetKeyName(7, "relatorio.png")
        '
        'txtDoc
        '
        Me.txtDoc.Enabled = False
        Me.txtDoc.Location = New System.Drawing.Point(7, 31)
        Me.txtDoc.Name = "txtDoc"
        Me.txtDoc.Size = New System.Drawing.Size(124, 20)
        Me.txtDoc.TabIndex = 0
        '
        'lblDesc
        '
        Me.lblDesc.Location = New System.Drawing.Point(4, 15)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(129, 16)
        Me.lblDesc.TabIndex = 9
        Me.lblDesc.Text = "Nota Fiscal"
        '
        'dtCont
        '
        Me.dtCont.Enabled = False
        Me.dtCont.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtCont.Location = New System.Drawing.Point(302, 32)
        Me.dtCont.Name = "dtCont"
        Me.dtCont.Size = New System.Drawing.Size(88, 20)
        Me.dtCont.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(7, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 19)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Código de Barras:"
        '
        'lstNex
        '
        Me.lstNex.Enabled = False
        Me.lstNex.FormattingEnabled = True
        Me.lstNex.Location = New System.Drawing.Point(818, 206)
        Me.lstNex.Name = "lstNex"
        Me.lstNex.Size = New System.Drawing.Size(126, 355)
        Me.lstNex.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(136, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 19)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Pedido(s) atendido(s) na nota "
        '
        'txtPedidos
        '
        Me.txtPedidos.BackColor = System.Drawing.SystemColors.Window
        Me.txtPedidos.Enabled = False
        Me.txtPedidos.Location = New System.Drawing.Point(139, 31)
        Me.txtPedidos.Name = "txtPedidos"
        Me.txtPedidos.ReadOnly = True
        Me.txtPedidos.Size = New System.Drawing.Size(157, 20)
        Me.txtPedidos.TabIndex = 1
        '
        'grpCabecalho
        '
        Me.grpCabecalho.Controls.Add(Me.cbReembolso)
        Me.grpCabecalho.Controls.Add(Me.cbFrete)
        Me.grpCabecalho.Controls.Add(Me.Label7)
        Me.grpCabecalho.Controls.Add(Me.cbPagamento)
        Me.grpCabecalho.Controls.Add(Me.txtQtde)
        Me.grpCabecalho.Controls.Add(Me.lblQtde)
        Me.grpCabecalho.Controls.Add(Me.txtVParcelas)
        Me.grpCabecalho.Controls.Add(Me.lblVParcela)
        Me.grpCabecalho.Controls.Add(Me.txtNParcelas)
        Me.grpCabecalho.Controls.Add(Me.lblNParcelas)
        Me.grpCabecalho.Controls.Add(Me.txtValorFrete)
        Me.grpCabecalho.Controls.Add(Me.lblValorFrete)
        Me.grpCabecalho.Controls.Add(Me.txtValorTotalNota)
        Me.grpCabecalho.Controls.Add(Me.lblValorTotalNota)
        Me.grpCabecalho.Controls.Add(Me.txtValorTotalProd)
        Me.grpCabecalho.Controls.Add(Me.lblValorTotalProd)
        Me.grpCabecalho.Controls.Add(Me.Label5)
        Me.grpCabecalho.Controls.Add(Me.cbFornecedor)
        Me.grpCabecalho.Controls.Add(Me.btnSalvar)
        Me.grpCabecalho.Controls.Add(Me.Label4)
        Me.grpCabecalho.Controls.Add(Me.txtObs)
        Me.grpCabecalho.Controls.Add(Me.txtDoc)
        Me.grpCabecalho.Controls.Add(Me.txtPedidos)
        Me.grpCabecalho.Controls.Add(Me.lblDesc)
        Me.grpCabecalho.Controls.Add(Me.dtCont)
        Me.grpCabecalho.Controls.Add(Me.Label1)
        Me.grpCabecalho.Controls.Add(Me.Label3)
        Me.grpCabecalho.Location = New System.Drawing.Point(8, 0)
        Me.grpCabecalho.Name = "grpCabecalho"
        Me.grpCabecalho.Size = New System.Drawing.Size(786, 152)
        Me.grpCabecalho.TabIndex = 24
        Me.grpCabecalho.TabStop = False
        Me.grpCabecalho.Text = "Cabecalho"
        '
        'cbReembolso
        '
        Me.cbReembolso.AutoSize = True
        Me.cbReembolso.Enabled = False
        Me.cbReembolso.Location = New System.Drawing.Point(689, 30)
        Me.cbReembolso.Name = "cbReembolso"
        Me.cbReembolso.Size = New System.Drawing.Size(79, 17)
        Me.cbReembolso.TabIndex = 46
        Me.cbReembolso.Text = "Reembolso"
        Me.cbReembolso.UseVisualStyleBackColor = True
        '
        'cbFrete
        '
        Me.cbFrete.Checked = True
        Me.cbFrete.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbFrete.Enabled = False
        Me.cbFrete.Location = New System.Drawing.Point(571, 20)
        Me.cbFrete.Name = "cbFrete"
        Me.cbFrete.Size = New System.Drawing.Size(104, 37)
        Me.cbFrete.TabIndex = 45
        Me.cbFrete.Text = "Incluir Frete no Faturamento"
        Me.cbFrete.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(535, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 16)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Forma Pagamento"
        '
        'cbPagamento
        '
        Me.cbPagamento.Enabled = False
        Me.cbPagamento.FormattingEnabled = True
        Me.cbPagamento.Location = New System.Drawing.Point(539, 74)
        Me.cbPagamento.Name = "cbPagamento"
        Me.cbPagamento.Size = New System.Drawing.Size(139, 21)
        Me.cbPagamento.TabIndex = 10
        '
        'txtQtde
        '
        Me.txtQtde.Enabled = False
        Me.txtQtde.Location = New System.Drawing.Point(325, 76)
        Me.txtQtde.Name = "txtQtde"
        Me.txtQtde.Size = New System.Drawing.Size(36, 20)
        Me.txtQtde.TabIndex = 7
        Me.txtQtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblQtde
        '
        Me.lblQtde.AutoSize = True
        Me.lblQtde.Location = New System.Drawing.Point(322, 60)
        Me.lblQtde.Name = "lblQtde"
        Me.lblQtde.Size = New System.Drawing.Size(30, 13)
        Me.lblQtde.TabIndex = 42
        Me.lblQtde.Text = "Qtde"
        '
        'txtVParcelas
        '
        Me.txtVParcelas.Enabled = False
        Me.txtVParcelas.Location = New System.Drawing.Point(441, 76)
        Me.txtVParcelas.Name = "txtVParcelas"
        Me.txtVParcelas.Size = New System.Drawing.Size(90, 20)
        Me.txtVParcelas.TabIndex = 9
        Me.txtVParcelas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblVParcela
        '
        Me.lblVParcela.AutoSize = True
        Me.lblVParcela.Location = New System.Drawing.Point(441, 60)
        Me.lblVParcela.Name = "lblVParcela"
        Me.lblVParcela.Size = New System.Drawing.Size(70, 13)
        Me.lblVParcela.TabIndex = 39
        Me.lblVParcela.Text = "Valor Parcela"
        '
        'txtNParcelas
        '
        Me.txtNParcelas.Enabled = False
        Me.txtNParcelas.Location = New System.Drawing.Point(371, 76)
        Me.txtNParcelas.Name = "txtNParcelas"
        Me.txtNParcelas.Size = New System.Drawing.Size(64, 20)
        Me.txtNParcelas.TabIndex = 8
        Me.txtNParcelas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblNParcelas
        '
        Me.lblNParcelas.AutoSize = True
        Me.lblNParcelas.Location = New System.Drawing.Point(369, 60)
        Me.lblNParcelas.Name = "lblNParcelas"
        Me.lblNParcelas.Size = New System.Drawing.Size(69, 13)
        Me.lblNParcelas.TabIndex = 37
        Me.lblNParcelas.Text = "Nº Parcela(s)"
        '
        'txtValorFrete
        '
        Me.txtValorFrete.Enabled = False
        Me.txtValorFrete.Location = New System.Drawing.Point(230, 76)
        Me.txtValorFrete.Name = "txtValorFrete"
        Me.txtValorFrete.Size = New System.Drawing.Size(84, 20)
        Me.txtValorFrete.TabIndex = 6
        Me.txtValorFrete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblValorFrete
        '
        Me.lblValorFrete.AutoSize = True
        Me.lblValorFrete.Location = New System.Drawing.Point(228, 60)
        Me.lblValorFrete.Name = "lblValorFrete"
        Me.lblValorFrete.Size = New System.Drawing.Size(73, 13)
        Me.lblValorFrete.TabIndex = 35
        Me.lblValorFrete.Text = "Valor do Frete"
        '
        'txtValorTotalNota
        '
        Me.txtValorTotalNota.Enabled = False
        Me.txtValorTotalNota.Location = New System.Drawing.Point(120, 76)
        Me.txtValorTotalNota.Name = "txtValorTotalNota"
        Me.txtValorTotalNota.Size = New System.Drawing.Size(100, 20)
        Me.txtValorTotalNota.TabIndex = 5
        Me.txtValorTotalNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblValorTotalNota
        '
        Me.lblValorTotalNota.AutoSize = True
        Me.lblValorTotalNota.Location = New System.Drawing.Point(120, 60)
        Me.lblValorTotalNota.Name = "lblValorTotalNota"
        Me.lblValorTotalNota.Size = New System.Drawing.Size(99, 13)
        Me.lblValorTotalNota.TabIndex = 33
        Me.lblValorTotalNota.Text = "Valor Total da Nota"
        '
        'txtValorTotalProd
        '
        Me.txtValorTotalProd.Enabled = False
        Me.txtValorTotalProd.Location = New System.Drawing.Point(7, 76)
        Me.txtValorTotalProd.Name = "txtValorTotalProd"
        Me.txtValorTotalProd.Size = New System.Drawing.Size(102, 20)
        Me.txtValorTotalProd.TabIndex = 4
        Me.txtValorTotalProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblValorTotalProd
        '
        Me.lblValorTotalProd.AutoSize = True
        Me.lblValorTotalProd.Location = New System.Drawing.Point(7, 60)
        Me.lblValorTotalProd.Name = "lblValorTotalProd"
        Me.lblValorTotalProd.Size = New System.Drawing.Size(103, 13)
        Me.lblValorTotalProd.TabIndex = 31
        Me.lblValorTotalProd.Text = "Valor Total Produtos"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(392, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Fornecedor"
        '
        'cbFornecedor
        '
        Me.cbFornecedor.Enabled = False
        Me.cbFornecedor.FormattingEnabled = True
        Me.cbFornecedor.Location = New System.Drawing.Point(396, 31)
        Me.cbFornecedor.Name = "cbFornecedor"
        Me.cbFornecedor.Size = New System.Drawing.Size(162, 21)
        Me.cbFornecedor.TabIndex = 3
        '
        'btnSalvar
        '
        Me.btnSalvar.Enabled = False
        Me.btnSalvar.ImageIndex = 3
        Me.btnSalvar.ImageList = Me.ImageList1
        Me.btnSalvar.Location = New System.Drawing.Point(606, 109)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(72, 26)
        Me.btnSalvar.TabIndex = 12
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(9, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 18)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Obs.:"
        '
        'txtObs
        '
        Me.txtObs.Enabled = False
        Me.txtObs.Location = New System.Drawing.Point(48, 106)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(437, 37)
        Me.txtObs.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(299, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Data"
        '
        'grpDetalhes
        '
        Me.grpDetalhes.Controls.Add(Me.btnEntradaAvulsa)
        Me.grpDetalhes.Controls.Add(Me.cbAvulsa)
        Me.grpDetalhes.Controls.Add(Me.btnCadBarra)
        Me.grpDetalhes.Controls.Add(Me.btnLimpa)
        Me.grpDetalhes.Controls.Add(Me.txtCodBarra)
        Me.grpDetalhes.Controls.Add(Me.btnExcluiItem)
        Me.grpDetalhes.Controls.Add(Me.Label2)
        Me.grpDetalhes.Enabled = False
        Me.grpDetalhes.Location = New System.Drawing.Point(8, 154)
        Me.grpDetalhes.Name = "grpDetalhes"
        Me.grpDetalhes.Size = New System.Drawing.Size(935, 46)
        Me.grpDetalhes.TabIndex = 19
        Me.grpDetalhes.TabStop = False
        Me.grpDetalhes.Text = "Detalhes"
        '
        'btnEntradaAvulsa
        '
        Me.btnEntradaAvulsa.Enabled = False
        Me.btnEntradaAvulsa.ImageIndex = 6
        Me.btnEntradaAvulsa.ImageList = Me.ImageList1
        Me.btnEntradaAvulsa.Location = New System.Drawing.Point(563, 14)
        Me.btnEntradaAvulsa.Name = "btnEntradaAvulsa"
        Me.btnEntradaAvulsa.Size = New System.Drawing.Size(164, 26)
        Me.btnEntradaAvulsa.TabIndex = 46
        Me.btnEntradaAvulsa.Text = "Entrada no Estoque Avulsa"
        Me.btnEntradaAvulsa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEntradaAvulsa.UseVisualStyleBackColor = True
        '
        'cbAvulsa
        '
        Me.cbAvulsa.AutoSize = True
        Me.cbAvulsa.Location = New System.Drawing.Point(744, 18)
        Me.cbAvulsa.Name = "cbAvulsa"
        Me.cbAvulsa.Size = New System.Drawing.Size(98, 17)
        Me.cbAvulsa.TabIndex = 13
        Me.cbAvulsa.Text = "Entrada Avulsa"
        Me.cbAvulsa.UseVisualStyleBackColor = True
        '
        'btnCadBarra
        '
        Me.btnCadBarra.ImageIndex = 2
        Me.btnCadBarra.ImageList = Me.ImageList1
        Me.btnCadBarra.Location = New System.Drawing.Point(422, 14)
        Me.btnCadBarra.Name = "btnCadBarra"
        Me.btnCadBarra.Size = New System.Drawing.Size(135, 26)
        Me.btnCadBarra.TabIndex = 3
        Me.btnCadBarra.Text = "Cad. Codigo de Barra"
        Me.btnCadBarra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'btnLimpa
        '
        Me.btnLimpa.ImageIndex = 0
        Me.btnLimpa.ImageList = Me.ImageList1
        Me.btnLimpa.Location = New System.Drawing.Point(224, 14)
        Me.btnLimpa.Name = "btnLimpa"
        Me.btnLimpa.Size = New System.Drawing.Size(75, 26)
        Me.btnLimpa.TabIndex = 1
        Me.btnLimpa.Text = "Limpa"
        Me.btnLimpa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'btnExcluiItem
        '
        Me.btnExcluiItem.ImageIndex = 1
        Me.btnExcluiItem.ImageList = Me.ImageList1
        Me.btnExcluiItem.Location = New System.Drawing.Point(304, 14)
        Me.btnExcluiItem.Name = "btnExcluiItem"
        Me.btnExcluiItem.Size = New System.Drawing.Size(113, 26)
        Me.btnExcluiItem.TabIndex = 2
        Me.btnExcluiItem.Text = "Eliminar um item"
        Me.btnExcluiItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pb, Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 567)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(953, 22)
        Me.StatusStrip1.TabIndex = 43
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'pb
        '
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(164, 16)
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'btnManual
        '
        Me.btnManual.ImageIndex = 5
        Me.btnManual.ImageList = Me.ImageList1
        Me.btnManual.Location = New System.Drawing.Point(805, 37)
        Me.btnManual.Name = "btnManual"
        Me.btnManual.Size = New System.Drawing.Size(138, 26)
        Me.btnManual.TabIndex = 14
        Me.btnManual.Text = "Nota Manual"
        Me.btnManual.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnManual.UseVisualStyleBackColor = True
        '
        'btnRelatorioOutros
        '
        Me.btnRelatorioOutros.Enabled = False
        Me.btnRelatorioOutros.ImageIndex = 7
        Me.btnRelatorioOutros.ImageList = Me.ImageList1
        Me.btnRelatorioOutros.Location = New System.Drawing.Point(805, 124)
        Me.btnRelatorioOutros.Name = "btnRelatorioOutros"
        Me.btnRelatorioOutros.Size = New System.Drawing.Size(138, 26)
        Me.btnRelatorioOutros.TabIndex = 18
        Me.btnRelatorioOutros.Text = "Relatorio Outros"
        Me.btnRelatorioOutros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'btnImportar
        '
        Me.btnImportar.ImageIndex = 4
        Me.btnImportar.ImageList = Me.ImageList1
        Me.btnImportar.Location = New System.Drawing.Point(805, 8)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(138, 26)
        Me.btnImportar.TabIndex = 13
        Me.btnImportar.Text = "Nota Importada"
        Me.btnImportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnImportar.UseVisualStyleBackColor = True
        '
        'btnRelat
        '
        Me.btnRelat.Enabled = False
        Me.btnRelat.ImageIndex = 7
        Me.btnRelat.ImageList = Me.ImageList1
        Me.btnRelat.Location = New System.Drawing.Point(805, 95)
        Me.btnRelat.Name = "btnRelat"
        Me.btnRelat.Size = New System.Drawing.Size(138, 26)
        Me.btnRelat.TabIndex = 17
        Me.btnRelat.Text = "Relatorio Lentes"
        Me.btnRelat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'btnInvetario
        '
        Me.btnInvetario.Enabled = False
        Me.btnInvetario.ImageIndex = 6
        Me.btnInvetario.ImageList = Me.ImageList1
        Me.btnInvetario.Location = New System.Drawing.Point(805, 66)
        Me.btnInvetario.Name = "btnInvetario"
        Me.btnInvetario.Size = New System.Drawing.Size(138, 26)
        Me.btnInvetario.TabIndex = 16
        Me.btnInvetario.Text = "Entrar no Estoque"
        Me.btnInvetario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'frmConferenciaNota
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(953, 589)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnManual)
        Me.Controls.Add(Me.btnRelatorioOutros)
        Me.Controls.Add(Me.grpDetalhes)
        Me.Controls.Add(Me.btnImportar)
        Me.Controls.Add(Me.btnRelat)
        Me.Controls.Add(Me.grpCabecalho)
        Me.Controls.Add(Me.btnInvetario)
        Me.Controls.Add(Me.lstNex)
        Me.Controls.Add(Me.grdProd)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConferenciaNota"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entrada e Conferência de Nota"
        CType(Me.grdProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.grpCabecalho.ResumeLayout(False)
        Me.grpCabecalho.PerformLayout()
        Me.grpDetalhes.ResumeLayout(False)
        Me.grpDetalhes.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim tb As New DataTable
    Dim entrada As New objEntradaNota
    Dim tbCont As New DataTable
    Dim d As New dados()
    Dim p As New produtoClass
    Dim user As New objUsuario(UserID)
    Public conf As New config
    Dim mov As New objMovimentoDetalhe
    Dim chave_movimento As Integer
    Public novo As Boolean = False
    Public x_id_conferencia, x_filial As Integer
    Dim x_tabela As String = ""
    Dim x_tipo As String = ""
    Dim item As Integer = Nothing 'Guarda o número do item para inserir na entrada
    Dim trans As New objSqlTrans
    Dim lblCodTabela As New Label
    Dim lblCodTabela_Atualiza As New Label 'Guarda o código da lente
    Dim arquivonota As String = "" 'Guarda o caminho do arquivo xml para leitura da NFe
    Dim cnpjfor As String = "" 'Guarda o cnpj do Fornecedor
    Dim tiponota As String = ""
    Dim grdCalcula As New DataGridView 'Cria o grid em tempo de execução
    Dim nQtdeTotal As Integer  'Guarda o total de itens do grid em execução em tempo de execução
    Dim nValorTotal As Double 'Guarda o valor total do grid em tempo de execução
    Dim notafiscal As New objMaster
    Dim lblCodigoProd As New Label
    Dim lblCodigoPed As New Label
    Dim frete As String = ""
    Dim strDevolucao As String = ""
    Dim strReembolso As String = ""

    Private Sub frmConferenciaLentes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Procedimento 18 Entrada de Nota Estoque
        If novo = False Then
            entrada.carrega_nota(x_id_conferencia, x_filial)
            txtDoc.Text = entrada.documento
            txtPedidos.Text = entrada.pedido
            dtCont.Value = entrada.data
            cbFornecedor.Text = busca_fornecedor(CInt(entrada.cod_fornecedor))
            cbPagamento.Text = busca_forma_pagamento(entrada.cod_forma_pagamento)
            'txtParte.Text = entrada.parte
            txtObs.Text = entrada.observacao
            txtValorTotalProd.Text = Format(entrada.valor_total_prod, "#,##0.00")
            txtValorTotalNota.Text = Format(entrada.valor_total_nota, "#,##0.00")
            txtValorFrete.Text = Format(entrada.valor_frete, "#,##0.00")
            txtQtde.Text = entrada.quantidade
            txtNParcelas.Text = entrada.num_parcela
            txtVParcelas.Text = Format(entrada.valor_parcela, "#,##0.00")
            tiponota = entrada.tipo_nota

            If entrada.reembolso = "S" Then
                cbReembolso.Checked = True
            Else
                cbReembolso.Checked = False
            End If

            If entrada.frete_paga = "D" Then
                cbFrete.Checked = True
            ElseIf entrada.frete_paga = "R" Then
                cbFrete.Checked = False
            End If

            lstNex.Enabled = True

            notafiscal.status_movimento = notafiscal.busca_status_Movimento_Master(x_id_conferencia, x_filial)

            If notafiscal.status_movimento = "N" Then
                btnInvetario.Enabled = True
                grpDetalhes.Enabled = True
                btnImportar.Enabled = False
                btnManual.Enabled = False
            Else
                btnImportar.Enabled = False
                btnManual.Enabled = False
            End If

        Else
        End If
        carrega_grd()
    End Sub

    Private Sub carrega_cb()
        Dim sql As String
        Dim tt As New DataTable
        sql = "Select cod_fornecedor,fornecedor from fornecedor order by fornecedor"
        d.carrega_Tabela(sql, tt)
        cbFornecedor.DataSource = tt
        cbFornecedor.DisplayMember = "fornecedor"
        cbFornecedor.ValueMember = "cod_fornecedor"
    End Sub

    Private Function busca_fornecedor(ByVal codigo As Integer) As String
        Dim sql As String
        Dim resultado As String = ""
        sql = "Select fornecedor from fornecedor where cod_fornecedor = @codigo"
        Dim cmd As New SqlCommand(sql, d.con)
        cmd.Parameters.AddWithValue("@codigo", codigo)
        Dim dr As SqlDataReader
        d.conecta()
        Try
            dr = cmd.ExecuteReader
            dr.Read()
            resultado = dr.Item("fornecedor").ToString
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            d.desconecta()
        End Try
        Return resultado
    End Function

    Private Function busca_forma_pagamento(ByVal codigo As Integer) As String
        Dim sql As String
        Dim resultado As String = ""
        sql = "Select forma_pagamento from forma_pagamento where cod_forma_pagamento = @codigo"
        Dim cmd As New SqlCommand(sql, d.con)
        cmd.Parameters.AddWithValue("@codigo", codigo)
        Dim dr As SqlDataReader
        d.conecta()
        Try
            dr = cmd.ExecuteReader()
            dr.Read()
            resultado = dr.Item("forma_pagamento").ToString
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            d.desconecta()
        End Try
        Return resultado
    End Function


    Private Sub carrega_cf()
        Dim sql As String
        Dim tt As New DataTable
        sql = "Select cod_forma_pagamento,forma_pagamento from forma_pagamento order by forma_pagamento"
        d.carrega_Tabela(sql, tt)
        cbPagamento.DataSource = tt
        cbPagamento.DisplayMember = "forma_pagamento"
        cbPagamento.ValueMember = "cod_forma_pagamento"
    End Sub

    'Procedure responsável por localiza
    Private Sub busca_fornecedor(ByVal cnpj As String)
        Dim sql As String
        Dim tt As New DataTable
        sql = "Select cod_fornecedor,fornecedor from fornecedor where cgc = " & cnpj

        d.carrega_Tabela(sql, tt)
        cbFornecedor.DataSource = tt
        cbFornecedor.DisplayMember = "fornecedor"
        cbFornecedor.ValueMember = "cod_fornecedor"
    End Sub

    Private Sub carrega_grd()
        Dim sql As String
        Dim TStb As New DataGridTableStyle
        tb = entrada.lista_itens_exibir("DESC", conf.Filial)
        grdProd.DataSource = tb
        TStb.MappingName = grdProd.DataSource.tablename

        Dim cItem As New DataGridTextBoxColumn
        With cItem
            .MappingName = "id_item"
            .HeaderText = "Item"
            .Width = 30
        End With
        TStb.GridColumnStyles.Add(cItem)

        Dim cProd As New DataGridTextBoxColumn
        With cProd
            .MappingName = "produto"
            .HeaderText = "Produto"
            .Width = 430
        End With
        TStb.GridColumnStyles.Add(cProd)

        Dim cCod As New DataGridTextBoxColumn
        With cCod
            .MappingName = "cod_barra"
            .HeaderText = "Cod. Barras"
            .Width = 65
        End With
        TStb.GridColumnStyles.Add(cCod)

        Dim quant As New DataGridTextBoxColumn
        With quant
            .MappingName = "quantidade"
            .HeaderText = "Qtde Conf."
            .Width = 60
        End With
        TStb.GridColumnStyles.Add(quant)
        ''
        Dim preco As New DataGridTextBoxColumn
        With preco
            .MappingName = "preco_nota"
            .Format = "#,##0.00"
            .HeaderText = "Pr. Conf."
            .Width = 60
        End With
        TStb.GridColumnStyles.Add(preco)
        ''
        Dim quantnota As New DataGridTextBoxColumn
        With quantnota
            .MappingName = "totalqtde"
            .HeaderText = "Qtde Nota"
            .Width = 60
        End With
        TStb.GridColumnStyles.Add(quantnota)

        Dim preconota As New DataGridTextBoxColumn
        With preconota
            .MappingName = "preco"
            .Format = "#,##0.00"
            .HeaderText = "Pr. Nota"
            .Width = 60
        End With
        TStb.GridColumnStyles.Add(preconota)

        grdProd.TableStyles.Clear()
        grdProd.TableStyles.Add(TStb)

    End Sub
    Private Sub btnLimpa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpa.Click
        If entrada.concluido = "S" Then
            AVISO("Os produtos dessa nota já deram entrada no estoque, não é mais possível alterá-la!", Me, frmAviso.tipo_aviso.tipo_ok)
            Exit Sub
        End If
        Dim R As frmAviso.respo
        R = AVISO("Tem certeza que deseja excluir toda a contagem?", Me, frmAviso.tipo_aviso.tipo_sim_nao)
        If R = frmAviso.respo.SIM Then
            entrada.limpa_nota()
            carrega_grd()
            lstNex.Items.Clear()
            txtCodBarra.Focus()
        End If
    End Sub
    Private Sub txtCodBarra_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodBarra.KeyDown
        Dim RES As String
        Select Case e.KeyCode
            Case Keys.Enter
                If entrada.concluido = "S" Then
                    AVISO("Os produtos dessa nota já deram entrada no estoque, não é mais possível alterá-la!", Me, frmAviso.tipo_aviso.tipo_ok)
                    Exit Sub
                End If
                If txtCodBarra.Text = "" Then
                    prod_manual()
                Else
                    processa_barra()
                End If
        End Select
    End Sub
    Private Sub prod_manual()
        Dim f As New frmConsultaProdDiopCod
        Dim es As String
        Dim cod_prod As Integer
        Dim prod As New produtoClass
        Dim sql As String
        Dim res As String
        Dim item As Integer
        Dim quant As Integer
        Dim strAvulsa As String
        es = InputBox("Digite o tipo B para bloco, L para lente pronta, BS para bloco surfaçado e LC para Lente de Contato!", "", x_tipo)
        x_tipo = es
        If es.ToString.Trim.ToUpper <> "L" And es.ToString.ToUpper <> "B" And es.ToString <> "BS" And es.ToString <> "LC" Then
            som_erro()
            MsgBox("Erro!")
            Exit Sub
        End If
        'Se o produto for Lente pronta, abre o formulário 
        'de lente.
        If es = "L" Then
            f.tipo = "L"
            f.txtCodTabela.Text = x_tabela
            f.ShowDialog(Me)
            cod_prod = f.Result
        ElseIf es = "B" Then
            'Se o produto for bloco, abre o formulário 
            'de bloco.
            f.tipo = "B"
            f.txtCodTabela.Text = x_tabela
            f.ShowDialog(Me)
            cod_prod = f.Result
        ElseIf es = "BS" Then
            f.tipo = "BS"
            f.txtCodTabela.Text = x_tabela
            f.ShowDialog(Me)
            cod_prod = f.Result
        ElseIf es = "LC" Then
            f.tipo = "LC"
            f.txtCodTabela.Text = x_tabela
            f.ShowDialog(Me)
            cod_prod = f.Result
        End If
        If cod_prod = 0 Then
            AVISO("Produto não encontrado!", Me, frmAviso.tipo_aviso.tipo_ok, True)
            Exit Sub
        End If
        x_tabela = f.txtCodTabela.Text
        quant = InputBox("Quantidade:", "", 1)
        item = existe_produto(cod_prod)

        If cbAvulsa.Checked = False Then
            strAvulsa = "N"
        Else
            strAvulsa = "S"
        End If

        If txtCodBarra.Text <> "555555" Then
            'Retorna o código da lente na tabela pelo codigo do produto "tabela_conferencia_nota
            lblCodTabela.Text = busca_cod_tabela(cod_prod)
        End If

        lblCodigoProd.Text = cod_prod 'Pega o código do produto para ser utilizado na função verifica_produto_pedido
        lblCodigoPed.Text = notafiscal.so_numeros(txtPedidos.Text) 'Pega o código do pedido para ser utilizado na função verifica_produto_pedido

        If cbAvulsa.Checked = False Then
            If Not notafiscal.so_texto(txtDoc.Text).Contains("NP") Then
                'Verifica se o produto existe no pedido informado
                If notafiscal.verifica_produto_pedido(CInt(lblCodigoPed.Text), CInt(lblCodigoProd.Text), confFilial) = False Then
                    If MessageBox.Show("Produto não faz parte do pedido: " & lblCodigoPed.Text & Chr(13) & "Deseja realmente dá entrada no estoque assim mesmo?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                        strAvulsa = "D" 'O D significa produto a devolver
                        strDevolucao = "D"
                        txtPedidos.Text = lblCodigoPed.Text & " - " & "Atendido Parcialmente"
                    Else
                        strAvulsa = "N" 'O N significa entrada normal
                    End If
                End If
            End If
        End If


        If item = 0 Then
            If txtCodBarra.Text <> "555555" Then
                inserir_produto(cod_prod, 1, busca_preco_lente(cod_prod), busca_cod_tabela(cod_prod), _
                busca_desconto_lente(cod_prod), strAvulsa)
            Else
                inserir_produto(cod_prod, 1, busca_preco_lente_optifogue(20), 20, busca_desconto_lente_optifogue(20), "N")
            End If
            lblStatus.Text = "Último produto: " & tb.Rows(0)("Produto") & " - " & "Conf: " & entrada.id_conferencia
        Else
            atualizar_produto(item, quant_produto(cod_prod) + quant)
        End If
        carrega_grd()
        txtCodBarra.Focus()
    End Sub
    Private Sub processa_barra()
        Dim res As String
        Dim sql As String
        Dim item As Integer
        Dim strAvulsa As String
        Try
            'Consulta o produto na tabelaprodutos pelo codigo de barra
            tb = p.Consultar_produtos_barra(txtCodBarra.Text)

            If cbAvulsa.Checked = False Then
                strAvulsa = "N"
            Else
                strAvulsa = "S"
            End If

            If txtCodBarra.Text <> "555555" Then
                'Retorna o código da lente na tabela pelo codigo do produto "tabela_conferencia_nota
                lblCodTabela.Text = busca_cod_tabela(tb.Rows(0)("cod_produto"))
            End If

            lblCodigoProd.Text = tb.Rows(0)("cod_produto") 'Pega o código do produto para ser utilizado na função verifica_produto_pedido
            If cbReembolso.Checked = False Then
                lblCodigoPed.Text = notafiscal.so_numeros(txtPedidos.Text) 'Pega o código do pedido para ser utilizado na função verifica_produto_pedido
            Else
                lblCodigoPed.Text = 0
            End If

            If cbReembolso.Checked = False Then
                If cbAvulsa.Checked = False Then
                    If Not notafiscal.so_texto(txtDoc.Text).Contains("NP") Then
                        'Verifica se o produto existe no pedido informado
                        If notafiscal.verifica_produto_pedido(CInt(lblCodigoPed.Text), CInt(lblCodigoProd.Text), confFilial) = False Then
                            If MessageBox.Show("Produto não faz parte do pedido: " & lblCodigoPed.Text & Chr(13) & "Deseja realmente dá entrada no estoque assim mesmo?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                                strAvulsa = "D" 'O D significa produto a devolver
                                strDevolucao = "D"
                                txtPedidos.Text = lblCodigoPed.Text & " - " & "Atendido Parcialmente"
                            Else
                                strAvulsa = "N" 'O N significa entrada normal
                            End If
                        End If
                    End If
                End If
            End If

            If tb.Rows.Count > 0 Then
                calcula_valor()
                item = existe_produto(tb.Rows(0)("cod_produto"))
                If item = 0 Then
                    If txtCodBarra.Text <> "555555" Then
                        'inserir_produto(tb.Rows(0)("cod_produto"), 1, busca_preco_lente(tb.Rows(0)("cod_produto")), busca_cod_tabela(tb.Rows(0)("cod_produto")), _
                        If tiponota = "I" Then
                            Dim preco As Double
                            preco = retorna_preco(entrada.id_conferencia, conf.Filial, tb.Rows(0)("cod_produto"))
                            inserir_produto(tb.Rows(0)("cod_produto"), 1, preco, busca_cod_tabela(tb.Rows(0)("cod_produto")), _
                            busca_desconto_lente(tb.Rows(0)("cod_produto")), strAvulsa)
                            atualiza_preco_tabela_lente(busca_cod_tabela(tb.Rows(0)("cod_produto")), preco)
                            atualiza_desconto_tabela_lente(busca_cod_tabela(tb.Rows(0)("cod_produto")), busca_preco(lblCodTabela.Text), busca_preco_nota(lblCodTabela.Text))
                        Else
                            inserir_produto(tb.Rows(0)("cod_produto"), 1, busca_preco_lente(tb.Rows(0)("cod_produto")), busca_cod_tabela(tb.Rows(0)("cod_produto")), _
                            busca_desconto_lente(tb.Rows(0)("cod_produto")), strAvulsa)
                        End If

                    Else
                        inserir_produto(tb.Rows(0)("cod_produto"), 1, busca_preco_lente_optifogue(20), 20, busca_desconto_lente_optifogue(20), strAvulsa)
                    End If
                    lblStatus.Text = "Último produto: " & tb.Rows(0)("Produto") & " - " & "Conf: " & entrada.id_conferencia

                Else
                    atualizar_produto(item, quant_produto(item) + 1)
                End If
                carrega_grd()
            Else
                AVISO(txtCodBarra.Text & vbCrLf & "Código de Barras não encontrado!", Me, frmAviso.tipo_aviso.tipo_ok, True)
                lstNex.Items.Add(txtCodBarra.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString) 'depois tirar
        End Try
        txtCodBarra.Text = Nothing
        txtCodBarra.Focus()
    End Sub
    Private Sub inserir_produto(ByVal xCod_prod As Integer, ByVal xQuant As Integer, xpreco_nota As String, _
                                xcod_tabela As Integer, ByVal xdesconto_compra As String, ByVal xavulsa As String)
        Dim sql As String
        Dim res As String
        res = entrada.insere_item(xCod_prod, xQuant, UserID, xpreco_nota, xcod_tabela, xdesconto_compra, xavulsa)
        If res.StartsWith("OK") Then
            som_ok()
        Else
            MsgBox(res)
            AVISO(res, Me, frmAviso.tipo_aviso.tipo_ok, True)
        End If
        carrega_grd()
    End Sub
    Private Sub atualizar_produto(ByVal xitem As Integer, ByVal xQuant As Integer)
        Dim res As String
        res = entrada.atualiza_quantidade(xitem, xQuant)
        If res.StartsWith("OK") Then
            som_ok()
        Else
            AVISO(res, Me, frmAviso.tipo_aviso.tipo_ok, True)
        End If
    End Sub
    Private Sub btnRelat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRelat.Click
        Dim rp As New rptContagem
        Dim f As New frmRpt
        rp.titulo = "Entrada no estoque do documento: " & txtDoc.Text & " em " & dtCont.Value
        rp.DataSource = entrada.lista_itens_impressao
        f.Relat(rp)
        f.ShowDialog(Me)
        Me.Close()
    End Sub
    Private Function existe_produto(ByVal xCod_prod As Integer) As Integer
        Dim tt As New DataTable
        Dim sql As String
        sql = "Select id_item from conferencia_nota where cod_produto = " & xCod_prod & _
        " and id_conferencia = " & entrada.id_conferencia & " and id_filial_nota = " & _
        entrada.id_filial_nota
        d.carrega_Tabela(sql, tt)
        If tt.Rows.Count > 0 Then
            Return tt.Rows(0)("id_item")
        Else
            Return 0
        End If
    End Function
    Private Function quant_produto(ByVal xitem As Integer) As Integer
        Dim tt As New DataTable
        Dim sql As String
        sql = "select quant from conferencia_nota where id_item = " & xitem & " and " & _
        "id_conferencia = " & entrada.id_conferencia & " and id_filial_nota = " & _
        entrada.id_filial_nota & ""
        d.carrega_Tabela(sql, tt)
        If tt.Rows.Count > 0 Then
            Return tt.Rows(0)("quant")
        Else
            Return 0
        End If
    End Function
    Private Sub btnInvetario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInvetario.Click
        calcula_valor()
        Dim valor As Double
        Dim valorconv As Double
        Dim quantidade As Integer
        Dim status As Integer
        Dim strDocumento As String = ""

        quantidade = CInt(txtQtde.Text)
        valor = CDbl(txtValorTotalProd.Text)
        valorconv = Format(CDbl(nValorTotal), "#,##0.00")

        If cbReembolso.Checked = True Then
            If (nQtdeTotal <> quantidade) Then
                MessageBox.Show("A nota não pode ser fechada. Quantidade de itens não conferem." & Chr(13) & "Total de item(ens) calculado pelo sistema: " & nQtdeTotal, _
                                "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If

        If cbReembolso.Checked = False Then
            If (nQtdeTotal <> quantidade) Then
                MessageBox.Show("A nota não pode ser fechada. Quantidade de itens não conferem." & Chr(13) & "Total de item(ens) calculado pelo sistema: " & nQtdeTotal, _
                "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            'Verifica se o valor total informado na nota coincide com o valor total calculado pelo sistema
            If (valorconv <> valor) Then
                If MessageBox.Show("A nota não pode ser fechada. Valor total da nota não confere." & Chr(13) & "Valor total calculado pelo sistema: " & Format(valorconv, "#,##0.00") & _
                                   Chr(13) & Chr(13) & "Deseja fechar a nota assim mesmo?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then

                    Dim resp As String
                    resp = user.login(Me)
                    If resp.StartsWith("ER") = True Then
                        AVISO(resp, Me, frmAviso.tipo_aviso.tipo_ok)
                        Exit Sub
                    End If

                    If user.acesso(user.cod_usuario, 42) = True Then
                        Dim f As New frmObservacao
                        f.ShowDialog()
                        entrada.observacao = f.strObservacao
                        txtObs.Text = entrada.observacao
                    Else
                        MessageBox.Show("Você não tem permissão para fechar nota com valores " & Chr(13) & "diferentes do calculado pelo sistema.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                Else
                    Exit Sub
                End If
            End If

        End If

        If grdProd.CurrentRowIndex > -1 Then
            Dim resp As String
            resp = user.login(Me)
            If resp.StartsWith("ER") = True Then
                AVISO(resp, Me, frmAviso.tipo_aviso.tipo_ok)
                Exit Sub
            End If
            If entrada.concluido = "S" Then
                AVISO("Os itens dessa nota já deram entrada no estoque!", Me, frmAviso.tipo_aviso.tipo_ok, True)
                Exit Sub
            End If
            Dim sql As String
            Dim tSql As String
            Dim iSql As String
            Dim tt As New DataTable
            Dim res As String
            Dim i, m As Integer
            'Seleciona os itens da tabela conferencia_nota para posterior inserção dos dados na tabela movimento
            tt = entrada.lista_itens("asc")
            i = 0
            pb.Minimum = 0
            m = tt.Rows.Count 'Guarda a quantidade de registro selecionado na instrução entrada.lista_itens
            pb.Maximum = m
            Dim dt As Object
            item = mov.ret_ultimo_item(entrada.cod_movimento) 'retorna o item inicial
            While i < m
                dt = rdData(tt.Rows(i)("Processado"))
                If dt = Nothing Then
                    insere_item_nota(tt.Rows(i)("cod_produto"), tt.Rows(i)("quantidade")) 'Insere os dados na tabela movimento
                    Application.DoEvents()
                    entrada.PROCESSADO(tt.Rows(i)("id_item")) 'atualiza a data em que foi processado o registro
                    entrada.PROCESSADO_AVULSA() 'atualiza a data em que foi processado o registro em que a entrada foi de forma avulsa
                    entrada.PROCESSADO_DEVOLUCAO()
                End If
                i = i + 1
                pb.Value = i
            End While
            entrada.editar()
            entrada.cod_usuario = user.cod_usuario 'retorna o codigo do usuário logado
            entrada.Salvar()
            AVISO("Concluído!", Me, frmAviso.tipo_aviso.tipo_ok)
            entrada.conclui()

            If cbReembolso.Checked = False Then
                inserir_fatura_lancamento()
            End If

            strDocumento = notafiscal.so_texto(txtDoc.Text).Replace(" ", "")
            If strDocumento <> "NP" Then
                If cbReembolso.Checked = False Then
                    status = notafiscal.retorna_status_pedido(notafiscal.so_texto(txtPedidos.Text))
                    notafiscal.atualiza_status_pedido(status, notafiscal.so_numeros(txtPedidos.Text), confFilial)
                End If
            End If

            espelho_nota() 'Exibi o relatório referente o espelho da nota fiscal

            If strDevolucao = "D" Then
                rel_produto_devolucao() ' Exibi relatório dos produtos que não foram solicitados no pedido informado
            End If

            hab_desabilita_controle_salva(5)
        Else
            MessageBox.Show("Não existe itens para  serem lançados para nota fiscal.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub insere_item_nota(ByVal _x_cod_prod As Integer, ByVal q As Double)
        Dim media_len, media_prod As Double
        Dim cod_len As Integer
        Dim p As New produtoClass
        p.filtra(_x_cod_prod)
        mov.novo()
        mov.item = item
        mov.cod_movimento = entrada.cod_movimento
        mov.id_filial = entrada.id_filial
        mov.cod_produto = p.fldCod_produto
        mov.quant = q
        mov.desconto = p.Desconto_compra
        mov.pUnit = p.Preco_compra
        mov.estoqueFis = mov.ret_saldo_fisico(p.fldCod_produto) + CDbl(q)
        mov.estoqueFin = mov.estoqueFis * ((p.Preco_compra - (p.Preco_compra * (p.Desconto_compra / 100))))
        '( + mov.ret_saldo_fin(txtCodProd.Text)
        Try
            cod_len = mov.retorna_cod_lentebloco(p.fldCod_produto)
            media_len = media_movel(mov.ret_saldo_todos_fisico(cod_len), mov.ret_saldo_todos_fin(cod_len), q, (p.Preco_compra) - (p.Preco_compra * (p.Desconto_compra / 100)))
        Catch ex As Exception
            cod_len = 0
            media_len = 0
        End Try
        media_prod = media_movel(mov.ret_saldo_fisico(p.fldCod_produto), mov.ret_saldo_fin(p.fldCod_produto), q, (p.Preco_compra) - (p.Preco_compra * (p.Desconto_compra / 100)))
        mov.atualiza_custo(cod_len, media_len, p.fldCod_produto, media_prod)
        mov.historico = "Compra conf. Doc. " & txtDoc.Text & ""
        lstNex.Items.Add(mov.Salvar().ToString)
    End Sub
    Private Sub btnRelatCaixa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim tSQL As String
        Dim tt As New DataTable
        Dim f As New frmGaveta
        Dim gaveta As String
        Dim rp As New rptContagem
        Dim fr As New frmRpt
        f.ShowDialog(Me)
        gaveta = f.cbGaveta.Text
        tSQL = "SELECT produtos.produto, produtos.cod_barra, SUM(conferencia_nota.quant) AS quantidade  " & _
        "FROM   conferencia_nota INNER JOIN  " & _
        "produtos ON conferencia_nota.cod_produto = produtos.cod_produto INNER JOIN  " & _
        "lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente AND produtos.id_fabricante = lentes_blocos.id_fabricante  " & _
        "Where id_conferencia = 1  and conferencia_nota.gaveta = " & d.PStr(gaveta) & _
        "GROUP BY  produtos.cod_barra,produtos.produto"
        d.carrega_Tabela(tSQL, tt)
        rp.titulo = txtDoc.Text & " " & " Gaveta / Caixa: " & gaveta & " " & dtCont.Value
        rp.DataSource = tt
        fr.Relat(rp)
        fr.ShowDialog(Me)
    End Sub
    Private Sub btnExcluiItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluiItem.Click
        If entrada.concluido = "S" Then
            AVISO("Os produtos dessa nota já deram entrada no estoque, não é mais possível alterá-la!", Me, frmAviso.tipo_aviso.tipo_ok)
            Exit Sub
        End If
        Dim p As New produtoClass
        Dim g As String
        Dim item As Integer
        item = InputBox("Digite o item que deseja excluir:", "", grdProd.Item(grdProd.CurrentRowIndex, 0))
        MsgBox(entrada.exclui_item(item))
        carrega_grd()
    End Sub
    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim codmovimento As Integer
        Dim codnota As Int64
        Dim codped As Integer
        Dim codfor As Integer

        If entrada.concluido = "S" Then
            AVISO("Os produtos dessa nota já deram entrada no estoque, não é mais possível alterá-la!", Me, frmAviso.tipo_aviso.tipo_ok)
            Exit Sub
        End If

        If (txtDoc.Text <> String.Empty) And (txtPedidos.Text <> String.Empty) And (txtValorTotalProd.Text <> String.Empty) And _
            (txtValorTotalNota.Text <> String.Empty) And (txtValorFrete.Text <> String.Empty) _
            And (txtQtde.Text <> String.Empty) And (txtNParcelas.Text <> String.Empty) And _
            (cbFornecedor.Text <> String.Empty) And (cbPagamento.Text <> String.Empty) Then

            If novo = True Then
                entrada.novo()
                entrada.data = dtCont.Value
                entrada.documento = txtDoc.Text
                entrada.pedido = txtPedidos.Text
                entrada.cod_fornecedor = cbFornecedor.SelectedValue
                entrada.id_filial_nota = conf.Filial
                entrada.observacao = txtObs.Text
                entrada.parte = "1"
                entrada.cod_usuario = UserID
                entrada.valor_total_prod = txtValorTotalProd.Text
                entrada.valor_total_nota = txtValorTotalNota.Text
                entrada.valor_frete = txtValorFrete.Text
                entrada.quantidade = txtQtde.Text
                entrada.num_parcela = txtNParcelas.Text
                entrada.valor_parcela = txtVParcelas.Text
                entrada.tipo_nota = tiponota
                entrada.cod_forma_pagamento = cbPagamento.SelectedValue

                If cbReembolso.Checked = False Then
                    entrada.cod_pedido = notafiscal.so_numeros(txtPedidos.Text)
                End If

                If cbReembolso.Checked = True Then
                    strReembolso = "S"
                Else
                    strReembolso = "N"
                End If
                entrada.reembolso = strReembolso
                entrada.filial_loja = 0
                entrada.os_loja = 0

                If cbFrete.Checked = True Then
                    frete = "D"
                End If

                entrada.frete_paga = frete

                MsgBox(entrada.Salvar)

                If tiponota = "I" Then
                    Dim caminho As New XmlDocument 'Variável responsável por alocar o arquivo XML da nota fiscal eletrônica
                    caminho.Load(arquivonota)
                    incluiItemNotaFiscal(caminho)
                End If

                codnota = notafiscal.so_numeros(txtDoc.Text) 'Variavel local que aramazena o número da nota fiscal
                If cbReembolso.Checked = False Then
                    codped = notafiscal.so_numeros(txtPedidos.Text) 'Variavel local que aramazena o código do pedido
                Else
                    codped = 0

                End If

                codfor = cbFornecedor.SelectedValue ''Variavel local que aramazena o número do fornecedor

                'Retorna o código de movimento após a inserção dos dados na tabela conferencia_nota_master
                codmovimento = notafiscal.busca_Codigo_Movimento(entrada.id_conferencia, conf.Filial)
                'Insere os dados na tabela nota_pedido
                notafiscal.inseri_nota_pedido(codmovimento, codnota, codped, codfor, conf.Filial)

                grpDetalhes.Enabled = True
                lstNex.Enabled = True
                hab_desabilita_controle_salva(3)
                hab_desabilita_controle_salva(0)
                btnImportar.Enabled = False
                btnManual.Enabled = False
                cbFrete.Enabled = False
                cbReembolso.Enabled = False
                novo = False
                Exit Sub
            Else
                entrada.editar()
                entrada.data = dtCont.Value
                entrada.documento = txtDoc.Text
                entrada.pedido = txtPedidos.Text
                entrada.cod_fornecedor = cbFornecedor.SelectedValue
                entrada.id_filial_nota = conf.Filial
                entrada.observacao = txtObs.Text
                'entrada.parte = txtParte.Text
                entrada.valor_total_prod = txtValorTotalProd.Text
                entrada.valor_total_nota = txtValorTotalNota.Text
                entrada.valor_frete = txtValorFrete.Text
                entrada.quantidade = txtQtde.Text
                entrada.num_parcela = txtNParcelas.Text
                entrada.valor_parcela = txtVParcelas.Text
                MsgBox(entrada.Salvar)
                grpDetalhes.Enabled = True
                lstNex.Enabled = True
                btnImportar.Enabled = False
                btnManual.Enabled = False
                hab_desabilita_controle_salva(3)
                hab_desabilita_controle_salva(0)
                carrega_grd()
            End If
        Else
            MessageBox.Show("Existem campo(s) em branco. Favor verificar.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub grdProd_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdProd.DoubleClick
        If entrada.concluido = "S" Then
            AVISO("Os produtos dessa nota já deram entrada no estoque, não é mais possível alterá-la!", Me, frmAviso.tipo_aviso.tipo_ok)
            Exit Sub
        End If
        Dim item
        Try
            item = grdProd.Item(grdProd.CurrentRowIndex, 0)
            MsgBox(entrada.atualiza_quantidade(item, InputBox("Digite a nova quantidade:")))
        Catch ex As Exception

        End Try

        carrega_grd()
    End Sub

    Private Sub btnCadBarra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadBarra.Click
        Dim f As New frmCadBarraDiop
        f.Show()
    End Sub

    Private Sub btnRelatorioOutros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRelatorioOutros.Click
        Dim tSQL As String
        Dim tt As New DataTable
        Dim f As New frmGaveta
        Dim gaveta As String
        Dim rp As New rptContagem
        Dim fr As New frmRpt

        tSQL = "SELECT produtos.produto, produtos.cod_barra, SUM(conferencia_nota.quant) AS quantidade  " & _
        "FROM   conferencia_nota INNER JOIN  " & _
        "produtos ON conferencia_nota.cod_produto = produtos.cod_produto " & _
        "Where id_conferencia = " & entrada.id_conferencia & _
        "GROUP BY  produtos.cod_barra,produtos.produto"
        d.carrega_Tabela(tSQL, tt)
        rp.titulo = txtDoc.Text
        rp.DataSource = tt
        fr.Relat(rp)
        fr.ShowDialog(Me)
        Me.Close()
    End Sub

    'Função responsável por buscar o preço de compra da lente e o preço de desconto
    Private Function busca_preco_lente(ByVal xCod_prod As Integer) As String
        Dim tt As New DataTable
        Dim sql As String
        Dim valor As String = ""

        ' Dim cod_lente As Integer
        sql = "Select p.cod_lente,lb.cod_lente,lb.cod_tabela, lt.preco_nota from produtos p  inner join lentes_blocos lb " & _
            "on p.cod_lente = lb.cod_lente inner join lentes_tabela lt on lb.cod_tabela = lt.cod_tabela where cod_produto = " & xCod_prod


        '"Select cod_lente from produtos where cod_produto = " & xCod_prod
        d.carrega_Tabela(sql, tt)

        If tt.Rows(0)("preco_nota").ToString = Nothing Then
            tt.Rows(0)("preco_nota") = "0,00"
            valor = Convert.ToString(tt.Rows(0)("preco_nota"))
            atualiza_preco_tabela_lente(Convert.ToInt32(lblCodTabela.Text), valor)
            'atualiza_preco_tabela_lente2(Label7.Text, "0,00")
            'Else
            'Return tt.Rows(0)("preco_nota")
        End If

        Return tt.Rows(0)("preco_nota").ToString   '& "-" & tt.Rows(1)("cod_tabela")
    End Function

    'Função responsável por buscar o preço de compra da lente e o preço de desconto
    Private Function busca_preco_lente_optifogue(ByVal xCod_tabela As Integer) As String
        Dim tt As New DataTable
        Dim sql As String
        Dim valor As String = ""

        ' Dim cod_lente As Integer
        sql = "Select preco_nota from lentes_tabela where cod_tabela = " & xCod_tabela

        '"Select cod_lente from produtos where cod_produto = " & xCod_prod
        d.carrega_Tabela(sql, tt)

        If tt.Rows(0)("preco_nota").ToString = Nothing Then
            tt.Rows(0)("preco_nota") = "0,00"
            valor = Convert.ToString(tt.Rows(0)("preco_nota"))
            atualiza_preco_tabela_lente(Convert.ToInt32(lblCodTabela.Text), valor)
            'atualiza_preco_tabela_lente2(Label7.Text, "0,00")
            'Else
            'Return tt.Rows(0)("preco_nota")
        End If

        Return tt.Rows(0)("preco_nota").ToString   '& "-" & tt.Rows(1)("cod_tabela")
    End Function

    Private Function busca_desconto_lente(ByVal xCod_prod As Integer) As String
        Dim tt As New DataTable
        Dim sql As String
        Dim total_geral As Double

        ' Dim cod_lente As Integer
        sql = "Select p.cod_lente,lb.cod_lente,lb.cod_tabela, lt.preco_compra, lt.preco_nota, " & _
            "sum((lt.preco_nota/lt.preco_compra) * 100) as Total from produtos p  inner join lentes_blocos lb " & _
            "on p.cod_lente = lb.cod_lente inner join lentes_tabela lt on lb.cod_tabela = lt.cod_tabela where cod_produto = " & xCod_prod & _
            " group by p.cod_lente, lb.cod_lente, lb.cod_tabela, lt.preco_compra, lt.preco_nota"


        '"Select cod_lente from produtos where cod_produto = " & xCod_prod
        d.carrega_Tabela(sql, tt)

        total_geral = FormatNumber(tt.Rows(0)("Total").ToString, 2)   '& "-" & tt.Rows(1)("cod_tabela")

        Return total_geral
    End Function

    Private Function busca_desconto_lente_optifogue(ByVal xCod_tabela As Integer) As String
        Dim tt As New DataTable
        Dim sql As String
        Dim total_geral As Double

        ' Dim cod_lente As Integer
        sql = "Select sum((preco_nota/preco_compra) * 100) as Total from lentes_tabela where cod_tabela = " & xCod_tabela

        '"Select cod_lente from produtos where cod_produto = " & xCod_prod
        d.carrega_Tabela(sql, tt)

        total_geral = FormatNumber(tt.Rows(0)("Total").ToString, 2)   '& "-" & tt.Rows(1)("cod_tabela")

        Return total_geral
    End Function


    'Função responsável por buscar o preço de compra na tabela lentes_tabela
    Private Function busca_preco(ByVal xCod_tab As Integer) As Double
        Dim tt As New DataTable
        Dim sql As String

        sql = "Select preco_compra from lentes_tabela where cod_tabela = " & xCod_tab

        d.carrega_Tabela(sql, tt)

        Return tt.Rows(0)("preco_compra").ToString
    End Function

    'Função responsável por buscar o preço de compra na tabela lentes_tabela
    Private Function busca_preco_nota(ByVal xCod_tab As Integer) As String
        Dim tt As New DataTable
        Dim sql As String

        sql = "Select preco_nota from lentes_tabela where cod_tabela = " & xCod_tab

        d.carrega_Tabela(sql, tt)

        Return tt.Rows(0)("preco_nota").ToString
    End Function

    Private Function busca_cod_tabela(ByVal xCod_prod As Integer) As Double
        Dim tt As New DataTable
        Dim sql As String
        ' Dim cod_lente As Integer
        sql = "Select p.cod_lente,lb.cod_lente,lb.cod_tabela, lt.preco_nota from produtos p  inner join lentes_blocos lb " & _
            "on p.cod_lente = lb.cod_lente inner join lentes_tabela lt on lb.cod_tabela = lt.cod_tabela where cod_produto = " & xCod_prod

        d.carrega_Tabela(sql, tt)

        Return tt.Rows(0)("cod_tabela")
    End Function

    Private Sub AtualizarPreçoCompraToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AtualizarPreçoCompraToolStripMenuItem.Click
        Dim valor As String
        Dim nvalor As Double

        If entrada.concluido = "S" Then
            AVISO("Os produtos dessa nota já deram entrada no estoque, não é mais possível alterá-la!", Me, frmAviso.tipo_aviso.tipo_ok)
            Exit Sub
        End If

        Try
            valor = InputBox("Digite o novo valor de compra:")

            nvalor = CDbl(valor)

            'Pega o valor da linha e coluna selecionada
            item = grdProd.Item(grdProd.CurrentRowIndex, 0)

            'Atualiza o preço de compra da tabela conferencia_nota
            entrada.atualiza_preco_compra(item, nvalor)
            entrada.atualiza_desconto_compra(item, nvalor, busca_preco(lblCodTabela_Atualiza.Text))
            MsgBox("Preço atualizado com sucesso.")

            'Atualiza o preço nota da tabela lentes_tabela
            atualiza_preco_tabela_lente(entrada.retorna_codigo_tabela(grdProd.Item(grdProd.CurrentRowIndex, 0)), nvalor)

            atualiza_desconto_tabela_lente(lblCodTabela_Atualiza.Text, busca_preco(lblCodTabela_Atualiza.Text), busca_preco_nota(lblCodTabela_Atualiza.Text))

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        carrega_grd()
    End Sub

    'Função responsável por atualizar preço da nota na tabela lentes_tabela
    Public Function atualiza_preco_tabela_lente(ByVal xcod_tabela As Integer, ByVal preco As Double) As String
        Dim valor As String
        valor = preco
        Dim sql As String
        Dim r As String
        sql = "update lentes_tabela" & _
        " set preco_nota = " & valor.Replace(",", ".") & _
        " where (cod_tabela = " & xcod_tabela & ")"
        r = d.Comando(sql, True)
        Return r
    End Function

    'Função responsável por atualizar o preço de desconto da compra na tabela lentes_tabela
    Public Function atualiza_desconto_tabela_lente(ByVal xcod_tabela As Integer, ByVal preco As String, ByVal nota As String) As String
        Dim valor_nota As Double
        Dim valor_preco As Double
        Dim Total As Double
        Dim Total_Formato As String
        Dim Total_Geral As String
        valor_nota = CDbl(nota)
        valor_preco = CDbl(preco)
        Total = 100 - ((valor_nota / valor_preco) * 100)
        Total_Formato = FormatNumber(Total, 2)
        Total_Geral = Total_Formato.Replace(",", ".")

        Dim sql As String
        Dim r As String
        sql = "update lentes_tabela" & _
        " set desconto_compra = " & Total_Geral & _
        " where (cod_tabela = " & xcod_tabela & ")"
        r = d.Comando(sql, True)
        Return r
    End Function

    Private Sub grdProd_Click(sender As System.Object, e As System.EventArgs) Handles grdProd.Click
        lblCodTabela_Atualiza.Text = entrada.retorna_codigo_tabela(grdProd.Item(grdProd.CurrentRowIndex, 0))
    End Sub

    Private Sub btnBusca_Click(sender As System.Object, e As System.EventArgs) Handles btnImportar.Click
        Dim caminhoarquivo As New XmlDocument

        tiponota = "I"

        Dim abre As New OpenFileDialog
        abre.Filter = "Arquivo de Notas Fiscais (*.xml)|*.xml"

        Dim janela As DialogResult = abre.ShowDialog
        arquivonota = abre.FileName
        If arquivonota <> String.Empty Then
            Try
                caminhoarquivo.Load(arquivonota)
                lerNotaFiscal(caminhoarquivo)
                busca_fornecedor(cnpjfor)
                carrega_cf()
                hab_desabilita_controle_salva(1)
                txtPedidos.Focus()
                cbFrete.Enabled = True
                cbReembolso.Enabled = True
            Catch ex As Exception
                MessageBox.Show("Erro ao abrir o arquivo da nota fiscal.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    'Procedure responsável por pegar os dados da nota fiscal eletrônica
    Public Sub lerNotaFiscal(ByRef docXML As XmlDocument)
        Dim strRetorno As String = "", _
            noPai As XmlElement, _
            noFilho As XmlElement, _
            noNeto As XmlElement, _
            noBisneto As XmlElement, _
            noTetra As XmlElement, _
            nodelist As XmlNodeList = docXML.DocumentElement.ChildNodes
        Dim totalqtde As Integer = 0
        Dim qtde As Integer
        Dim vTotalProduto As Double
        Dim vFrete As Double
        Dim vTotalNota As Double


        If Len(docXML.OuterXml) > 0 Then

            For Each noPai In nodelist 'Le os nós principais da NFe
                If noPai.Name = "NFe" Then
                    For Each noFilho In noPai 'Lê os Nós secundários
                        If noFilho.Name = "infNFe" Then 'Se for o cabecalho da NFe

                            For Each noNeto In noFilho
                                If noNeto.Name = "emit" Then
                                    For Each noBisneto In noNeto
                                        If noBisneto.Name = "CNPJ" Then
                                            cnpjfor = noBisneto.InnerText
                                        End If
                                    Next
                                End If
                            Next

                            For Each noNeto In noFilho 'Lê as Tags da NFe
                                If noNeto.Name = "ide" Then
                                    For Each noBisneto In noNeto
                                        If noBisneto.Name = "nNF" Then
                                            txtDoc.Text = "NF-e " & noBisneto.InnerText
                                        End If
                                    Next
                                End If

                                If noNeto.Name = "det" Then 'Dados do detalhe da nota
                                    For Each noBisneto In noNeto
                                        If noBisneto.Name = "prod" Then 'Dados do produto da nota
                                            For Each noTetra In noBisneto
                                                If noTetra.Name = "qTrib" Then
                                                    qtde = noTetra.InnerText.Replace(".", ",")
                                                    totalqtde += qtde
                                                    txtQtde.Text = totalqtde
                                                    strRetorno &= noTetra.InnerText & "|"
                                                End If
                                            Next
                                        Else
                                            strRetorno &= noBisneto.InnerText & "|"
                                        End If
                                    Next

                                End If
                                'inicio de outro
                                If noNeto.Name = "total" Then 'Dados do Emitente da NFe
                                    For Each noBisneto In noNeto
                                        If noBisneto.Name = "ICMSTot" Then 'Dados do Endereço do emitente
                                            For Each noTetra In noBisneto
                                                'Pega o valor total dos produto
                                                If noTetra.Name = "vProd" Then
                                                    'ListBox1.Items.Add(noTetra.InnerText)
                                                    vTotalProduto = noTetra.InnerText.Replace(".", ",")
                                                    txtValorTotalProd.Text = Format(vTotalProduto, "#,##0.00")
                                                    strRetorno &= noTetra.InnerText & "|"
                                                End If
                                                'Fim pega o valor total dos produtos

                                                'Pega o valor do frete
                                                If noTetra.Name = "vFrete" Then
                                                    'ListBox1.Items.Add(noTetra.InnerText)
                                                    vFrete = noTetra.InnerText.Replace(".", ",")
                                                    txtValorFrete.Text = Format(vFrete, "#,##0.00")
                                                    strRetorno &= noTetra.InnerText & "|"
                                                End If
                                                'Fim pega o valor do frete

                                                'Pega o valor da NFe
                                                If noTetra.Name = "vNF" Then
                                                    'ListBox1.Items.Add(noTetra.InnerText)
                                                    vTotalNota = noTetra.InnerText.Replace(".", ",")
                                                    txtValorTotalNota.Text = Format(vTotalNota, "#,##0.00")
                                                    strRetorno &= noTetra.InnerText & "|"
                                                End If
                                                'Fim do valor da NFe
                                            Next
                                        Else
                                            'ListBox1.Items.Add(noBisneto.InnerText)
                                            strRetorno &= noBisneto.InnerText & "|"
                                        End If
                                    Next

                                End If
                                'fim
                            Next
                        End If
                    Next
                End If
            Next
        End If
    End Sub

    'Procedure responsável por pegar os dados da nota fiscal eletrônica
    Public Sub incluiItemNotaFiscal(ByRef docXML As XmlDocument)
        Dim strRetorno As String = "", _
            noPai As XmlElement, _
            noFilho As XmlElement, _
            noNeto As XmlElement, _
            noBisneto As XmlElement, _
            noTetra As XmlElement, _
            nodelist As XmlNodeList = docXML.DocumentElement.ChildNodes
        Dim qtde As Integer
        Dim vProduto As Double
        Dim codbarra As Integer
        Dim codprod As Integer


        If Len(docXML.OuterXml) > 0 Then

            For Each noPai In nodelist 'Le os nós principais da NFe
                If noPai.Name = "NFe" Then
                    For Each noFilho In noPai 'Lê os Nós secundários
                        If noFilho.Name = "infNFe" Then 'Se for o cabecalho da NFe

                            For Each noNeto In noFilho 'Lê as Tags da NFe
                                If noNeto.Name = "det" Then 'Dados do detalhe da nota
                                    For Each noBisneto In noNeto
                                        If noBisneto.Name = "prod" Then 'Dados do produto da nota
                                            For Each noTetra In noBisneto

                                                If noTetra.Name = "cProd" Then
                                                    codbarra = CInt(noTetra.InnerText)
                                                    codprod = busca_codigo_prod(codbarra)
                                                End If

                                                If noTetra.Name = "qTrib" Then
                                                    qtde = noTetra.InnerText.Replace(".", ",")
                                                End If

                                                If noTetra.Name = "vUnCom" Then
                                                    vProduto = CDbl(noTetra.InnerText.Replace(".", ","))
                                                End If
                                            Next

                                            inseri_dados_conferencia_nota_item(entrada.id_conferencia, conf.Filial, codprod, qtde, vProduto)
                                        Else
                                            strRetorno &= noBisneto.InnerText & "|"
                                        End If
                                    Next

                                End If
                            Next
                        End If
                    Next
                End If
            Next
        End If
    End Sub

    Private Function calculaParcela() As Double
        Dim nvalornota As Double
        Dim nparcela As Integer
        Dim nvalor As Double

        If cbFrete.Checked = True Then
            nvalornota = CDbl(txtValorTotalNota.Text)
        Else
            nvalornota = CDbl(txtValorTotalProd.Text)
        End If

        nparcela = CInt(txtNParcelas.Text)

        nvalor = nvalornota / nparcela

        Return nvalor

    End Function


    Private Sub txtNParcelas_Leave(sender As System.Object, e As System.EventArgs) Handles txtNParcelas.Leave
        Try
            If (txtNParcelas.Text = "") Or (txtNParcelas.Text = 0) Or (txtNParcelas.Text < 0) Then
                MessageBox.Show("Número de Parcela não pode ser ZERO, VAZIO nem NERGATIVO!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtNParcelas.Focus()
                txtNParcelas.Clear()
                txtVParcelas.Clear()
            Else
                txtVParcelas.Text = Format(calculaParcela(), "#,##0.00")
            End If
        Catch ex As Exception
            MessageBox.Show("Número de Parcela deve ser númerico.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNParcelas.Focus()
            txtNParcelas.Clear()
        End Try
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnManual.Click
        tiponota = "D"

        carrega_cb()
        carrega_cf()
        hab_desabilita_controle_salva(4)
        hab_desabilita_controle_salva(2)
        cbFrete.Enabled = True
        cbReembolso.Enabled = True
        txtDoc.Focus()
        txtPedidos.ReadOnly = False
    End Sub

    Private Sub txtValorTotalProd_Leave(sender As System.Object, e As System.EventArgs) Handles txtValorTotalProd.Leave
        Dim valor As Double

        Try
            If (txtValorTotalProd.Text = 0) Or (txtValorTotalProd.Text < 0) Then
                MessageBox.Show("Valor Total do(s) Produto(s) não pode ser ZERO ou NEGATIVO!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtValorTotalProd.Focus()
                txtValorTotalProd.Clear()
            Else
                valor = CDbl(txtValorTotalProd.Text)
                txtValorTotalProd.Text = Format(valor, "#,##0.00")
            End If
        Catch ex As Exception
            MessageBox.Show("O Valor Total dos Produtos deve ser númerico.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtValorTotalProd.Focus()
            txtValorTotalProd.Clear()
        End Try
    End Sub

    Private Sub txtValorTotalNota_Leave(sender As System.Object, e As System.EventArgs) Handles txtValorTotalNota.Leave
        Dim valor As Double

        Try
            If (txtValorTotalNota.Text = 0) Or (txtValorTotalNota.Text < 0) Then
                MessageBox.Show("Valor Total da Nota não pode ser ZERO ou NEGATIVO!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtValorTotalNota.Focus()
                txtValorTotalNota.Clear()
            Else
                valor = CDbl(txtValorTotalNota.Text)
                txtValorTotalNota.Text = Format(valor, "#,##0.00")
            End If
        Catch ex As Exception
            MessageBox.Show("O Valor Total da Nota deve ser númerico.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtValorTotalNota.Focus()
            txtValorTotalNota.Clear()
        End Try
    End Sub

    Private Sub txtValorFrete_Leave(sender As System.Object, e As System.EventArgs) Handles txtValorFrete.Leave
        Dim valor As Double

        Try
            If (txtValorFrete.Text = "") Or (txtValorFrete.Text < 0) Then
                MessageBox.Show("Valor do Frete não pode ser NULO nem NEGATIVO!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtValorFrete.Focus()
                txtValorFrete.Clear()
            Else
                valor = CDbl(txtValorFrete.Text)
                txtValorFrete.Text = Format(valor, "#,##0.00")
            End If
        Catch ex As Exception
            MessageBox.Show("O Valor do Frete deve ser númerico.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtValorFrete.Focus()
            txtValorFrete.Clear()
        End Try
    End Sub

    Private Sub txtQtde_Leave(sender As System.Object, e As System.EventArgs) Handles txtQtde.Leave
        Try
            If (txtQtde.Text = "") Or (txtQtde.Text = 0) Or (txtQtde.Text < 0) Then
                MessageBox.Show("Quantidade não pode ser ZERO, VAZIO nem NERGATIVO!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtQtde.Focus()
                txtQtde.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show("Quantidade deve ser númerico.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtQtde.Focus()
            txtQtde.Clear()
        End Try
    End Sub

    Private Sub hab_desabilita_controle_salva(ByVal opcao As Integer)

        If opcao = 0 Then
            txtDoc.Enabled = False
            txtPedidos.Enabled = False
            dtCont.Enabled = False
            cbFornecedor.Enabled = False
            txtValorTotalProd.Enabled = False
            txtValorTotalNota.Enabled = False
            txtValorFrete.Enabled = False
            txtQtde.Enabled = False
            txtNParcelas.Enabled = False
            txtVParcelas.Enabled = False
            cbPagamento.Enabled = False
            txtObs.Enabled = False
            btnSalvar.Enabled = False
        ElseIf opcao = 1 Then
            txtDoc.Enabled = False
            txtPedidos.Enabled = True
            dtCont.Enabled = True
            cbFornecedor.Enabled = False
            txtValorTotalProd.Enabled = False
            txtValorTotalNota.Enabled = False
            txtValorFrete.Enabled = False
            txtQtde.Enabled = False
            txtNParcelas.Enabled = True
            txtVParcelas.Enabled = False
            cbPagamento.Enabled = True
            cbPagamento.Text = ""
            txtObs.Enabled = True
            btnSalvar.Enabled = True
        ElseIf opcao = 2 Then
            txtDoc.Enabled = True
            txtPedidos.Enabled = True
            dtCont.Enabled = True
            cbFornecedor.Enabled = True
            txtValorTotalProd.Enabled = True
            txtValorTotalNota.Enabled = True
            txtValorFrete.Enabled = True
            txtQtde.Enabled = True
            txtNParcelas.Enabled = True
            txtVParcelas.Enabled = False
            cbPagamento.Enabled = True
            txtObs.Enabled = True
            btnSalvar.Enabled = True
        ElseIf opcao = 3 Then
            btnInvetario.Enabled = True
            btnRelat.Enabled = False
            btnRelatorioOutros.Enabled = False
        ElseIf opcao = 4 Then
            btnImportar.Enabled = True
            btnManual.Enabled = True
            btnInvetario.Enabled = False
            btnRelat.Enabled = False
            btnRelatorioOutros.Enabled = False
            txtDoc.Clear()
            txtPedidos.Clear()
            cbFornecedor.Text = ""
            txtValorTotalProd.Clear()
            txtValorTotalNota.Clear()
            txtValorFrete.Clear()
            txtQtde.Clear()
            txtNParcelas.Clear()
            txtVParcelas.Clear()
            cbPagamento.Text = ""
            txtObs.Clear()
            btnSalvar.Enabled = False
            grpDetalhes.Enabled = False
        ElseIf opcao = 5 Then
            btnInvetario.Enabled = False
            btnRelat.Enabled = True
            btnRelatorioOutros.Enabled = True
        End If

    End Sub

    'Rotina responsável por montar o grid para armazenar a quantidade e o valor total da nota
    Private Sub grid_calculo()
        'instrução sql que traz os registros
        Dim strSQL As String = "SELECT id_item,quant, preco_nota, sum(quant * preco_nota) as total FROM conferencia_nota where " & _
        "id_conferencia = " & entrada.id_conferencia & " and id_filial_nota = " & _
        entrada.id_filial_nota & " group by id_item,quant, preco_nota"
        'conecta aos banco de dados
        d.conecta()
        'objeto de leitura dos valores retornados
        Dim dr As SqlDataReader

        'Cria a coluna quantidade
        Dim quantidade As New DataGridViewTextBoxColumn
        quantidade.HeaderText = "Quantidade"
        quantidade.Width = 60
        grdCalcula.Columns.Add(quantidade)

        'Cria a coluna Valor
        Dim valor As New DataGridViewTextBoxColumn
        valor.HeaderText = "Valor"
        valor.Width = 40
        grdCalcula.Columns.Add(valor)

        'Cria a coluna Total
        Dim total As New DataGridViewTextBoxColumn
        total.HeaderText = "Total"
        total.Width = 40
        grdCalcula.Columns.Add(total)

        d.carrega_reader(strSQL, dr)

        While dr.Read()
            grdCalcula.Rows.Add(dr.Item("quant"), dr.Item("preco_nota"), dr.Item("total"))
        End While

        dr.Close()
        d.desconecta()
    End Sub

    Private Sub calcula_valor()
        grdCalcula.Rows.Clear()
        grdCalcula.Columns.Clear()
        grid_calculo()
        Dim calculo As Double
        Dim quantidade As Integer

        For Each total As DataGridViewRow In grdCalcula.Rows
            quantidade += total.Cells(0).Value
            calculo += total.Cells(2).Value
        Next

        nQtdeTotal = quantidade
        nValorTotal = calculo
    End Sub

    Private Sub espelho_nota()
        Dim rp As New rptEspelhoNota
        Dim f As New frmRpt
        rp.TextBox18.Text = FormatDateTime(dtCont.Value, DateFormat.ShortDate)
        rp.TextBox9.Text = txtDoc.Text
        rp.TextBox10.Text = txtPedidos.Text
        rp.TextBox11.Text = cbFornecedor.Text
        rp.TextBox12.Text = txtValorTotalProd.Text
        rp.TextBox13.Text = txtValorTotalNota.Text
        rp.DataSource = entrada.lista_itens_espelho_nota
        rp.TextBox14.Text = txtValorFrete.Text
        rp.TextBox15.Text = txtQtde.Text
        rp.TextBox16.Text = txtNParcelas.Text
        If cbReembolso.Checked = False Then
            rp.Label21.Text = "Espelho da Nota Fiscal"
            rp.Label6.Text = "Nota fiscal faturada em " & txtNParcelas.Text & "x."
        Else
            rp.Label21.Text = "Reembolso de produtos"
        End If
        rp.TextBox17.Text = txtVParcelas.Text
        rp.TextBox4.Text = txtObs.Text
        rp.TextBox19.Text = cbPagamento.Text
        If tiponota = "I" Then
            rp.CheckBox1.Checked = True
        Else
            rp.CheckBox2.Checked = True
        End If
        rp.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape
        f.Relat(rp)
        f.ShowDialog(Me)
    End Sub

    Private Sub rel_produto_devolucao()
        Dim rp As New rptProdutoDevolucao
        Dim f As New frmRpt
        rp.TextBox18.Text = FormatDateTime(dtCont.Value, DateFormat.ShortDate)
        rp.TextBox9.Text = txtDoc.Text
        rp.TextBox10.Text = txtPedidos.Text
        rp.TextBox11.Text = cbFornecedor.Text
        rp.DataSource = entrada.lista_itens_espelho_nota_pedido_dev()
        rp.Label6.Text = "Nota fiscal faturada em " & txtNParcelas.Text & "x."
        rp.Label10.Text = "Produtos a ser devolvidos que não foram pedidos na solicitação do pedido abaixo"
        rp.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait
        f.Relat(rp)
        f.ShowDialog(Me)
    End Sub

    Public Function retorna_Chave_cod_lancamento(ByVal fld As String, ByVal tbl As String, ByVal criterio As String) As Long
        Dim tabela As New DataTable
        Dim sql As String
        Dim v As Long
        Dim d As New dados
        Try
            sql = "Select max(" & fld & ") as chave from " & tbl & " " & criterio
            d.carrega_Tabela(sql, tabela)
            If tabela.Rows.Count = 0 Then
                Return 1
                Exit Function
            End If
            If IsDBNull(tabela.Rows(0)("chave")) = True Then v = 0 Else v = tabela.Rows(0)("chave")
            Return v + 1
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        tabela.Dispose()
    End Function

    Private Sub inserir_fatura_lancamento()
        Dim strSQL As String = ""
        'Dim conexao As New SqlConnection
        Dim i As Integer
        Dim chave As Integer
        Dim dtvenc As DateTime
        Dim strObs As String = "ENTRADA NO ESTOQUE REF. " & txtDoc.Text & " E PEDIDO: " & txtPedidos.Text

        strSQL = "INSERT INTO lancamentos (cod_lancamento,id_filial_lancamento,id_filial,data_lancamento,cod_conta,Valor,cod_forma_pagamento," & _
        "n_parcelas,n_parcela,data_vencimento,historico,doc,tipo,cod_status_lancamento, cod_fatura, acrescimo,juros,desconto,taxas) " & _
        "VALUES(@cod_lanc,@id_filial_lanc,@id_filial,@data_lanc,@cod_conta,@valor,@cod_forma_pag,@n_parcelas,@n_parcela,@data_venc,@historico," & _
        "@doc,@tipo,@cod_status_lanc,@cod_fatura,@acrescimo,@juros,@desconto,@taxas)"

        Try

            For i = 1 To CInt(txtNParcelas.Text)

                Dim cmd As New SqlCommand(strSQL, d.con)
                d.conecta()
                chave = retorna_Chave_cod_lancamento("cod_lancamento", "lancamentos", " where id_filial_lancamento = " & conf.Filial & "")

                dtvenc = DateAdd(DateInterval.Month, i, dtCont.Value)

                cmd.Parameters.AddWithValue("@cod_lanc", chave)
                cmd.Parameters.AddWithValue("@id_filial_lanc", conf.Filial)
                cmd.Parameters.AddWithValue("@id_filial", conf.Filial)
                cmd.Parameters.AddWithValue("@data_lanc", dtCont.Value)
                cmd.Parameters.AddWithValue("@cod_conta", 281) 'rever para o certo
                cmd.Parameters.AddWithValue("@valor", CDbl(txtVParcelas.Text))
                cmd.Parameters.AddWithValue("@cod_forma_pag", entrada.cod_forma_pagamento)
                cmd.Parameters.AddWithValue("@n_parcelas", txtNParcelas.Text)
                cmd.Parameters.AddWithValue("@n_parcela", i)
                cmd.Parameters.AddWithValue("@data_venc", dtvenc)
                cmd.Parameters.AddWithValue("@historico", strObs)
                cmd.Parameters.AddWithValue("@doc", txtDoc.Text)
                cmd.Parameters.AddWithValue("@tipo", "S")
                cmd.Parameters.AddWithValue("@cod_status_lanc", 1)
                cmd.Parameters.AddWithValue("@cod_fatura", 0)
                cmd.Parameters.AddWithValue("@acrescimo", 0)
                cmd.Parameters.AddWithValue("@juros", 0)
                cmd.Parameters.AddWithValue("@desconto", 0)
                cmd.Parameters.AddWithValue("@taxas", 0)

                cmd.ExecuteNonQuery()
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            d.desconecta()
        End Try

    End Sub

    Private Sub txtPedidos_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtPedidos.KeyDown
        Dim f As New frmConsultaPedido
        Select Case e.KeyCode
            Case Keys.Enter
                f.ShowDialog(Me)
                If f.situacao = False Then
                    txtPedidos.Text = ""
                Else
                    txtPedidos.Text = f.codigopedido & " - " & f.descsitucao
                End If
                f.Dispose()
        End Select
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles btnEntradaAvulsa.Click

        If grdProd.CurrentRowIndex > -1 Then
            Dim resp As String
            resp = user.login(Me)
            If resp.StartsWith("ER") = True Then
                AVISO(resp, Me, frmAviso.tipo_aviso.tipo_ok)
                Exit Sub
            End If

            Dim tt As New DataTable
            Dim i, m As Integer
            tt = entrada.lista_itens_avulsa("asc")
            i = 0
            pb.Minimum = 0
            m = tt.Rows.Count
            pb.Maximum = m
            item = mov.ret_ultimo_item(entrada.cod_movimento) 'retorna o item inicial
            While i < m
                insere_item_nota(tt.Rows(i)("cod_produto"), tt.Rows(i)("quantidade"))
                i = i + 1
                pb.Value = i
            End While
            entrada.editar()
            entrada.cod_usuario = user.cod_usuario
            entrada.Salvar()
            AVISO("Concluído!", Me, frmAviso.tipo_aviso.tipo_ok)
        Else
            MessageBox.Show("Não existe itens para  serem lançados para nota fiscal.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cbAvulsa_Click(sender As System.Object, e As System.EventArgs) Handles cbAvulsa.Click
        If cbAvulsa.Checked = True Then
            cbAvulsa.Enabled = False
            btnEntradaAvulsa.Enabled = True
            btnInvetario.Enabled = False
        End If
    End Sub

    Private Sub cbFrete_Click(sender As System.Object, e As System.EventArgs) Handles cbFrete.Click
        Try
            If (txtNParcelas.Text = "") Or (txtNParcelas.Text = 0) Or (txtNParcelas.Text < 0) Then
                MessageBox.Show("Número de Parcela não pode ser ZERO, VAZIO nem NERGATIVO!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtNParcelas.Focus()
                txtNParcelas.Clear()
                txtVParcelas.Clear()
            Else
                txtVParcelas.Text = Format(calculaParcela(), "#,##0.00")
            End If
        Catch ex As Exception
            MessageBox.Show("Número de Parcela deve ser númerico.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNParcelas.Focus()
            txtNParcelas.Clear()
        End Try

        If cbFrete.Checked = True Then
            frete = "D"
        ElseIf cbFrete.Checked = False Then
            frete = "R"
        End If
    End Sub

    Private Sub cbReembolso_Click(sender As System.Object, e As System.EventArgs) Handles cbReembolso.Click
        If cbReembolso.Checked = True Then
            txtValorTotalProd.Text = "0,00"
            txtValorTotalProd.Enabled = False
            txtValorTotalNota.Text = "0,00"
            txtValorTotalNota.Enabled = False
            txtValorFrete.Text = "0,00"
            txtValorFrete.Enabled = False
            txtQtde.Enabled = True
            txtNParcelas.Text = "0"
            txtNParcelas.Enabled = False
            txtVParcelas.Text = "0,00"
            txtVParcelas.Enabled = False
            txtPedidos.Text = "REEMBOLSO"
            txtPedidos.ReadOnly = True
        End If
    End Sub

    Private Sub txtPedidos_Leave(sender As System.Object, e As System.EventArgs) Handles txtPedidos.Leave
        If txtPedidos.Text = "555555" Then
            txtPedidos.Text = txtPedidos.Text & " - " & "OPTIFOG"
        End If
    End Sub

    Private Function busca_codigo_prod(ByVal codbarra As Integer) As Integer
        Dim strSQL As String = "Select cod_produto from produtos where cod_barra = " & codbarra
        Dim cmd As New SqlCommand(strSQL, d.con)
        Dim dr As SqlDataReader
        Try
            d.conecta()
            dr = cmd.ExecuteReader()
            dr.Read()
            Return dr.Item("cod_produto").ToString
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            d.desconecta()
        End Try
    End Function

    Private Sub inseri_dados_conferencia_nota_item(ByVal idconf As Integer, ByVal idfilial As Integer, ByVal codprod As Integer, _
                                                   ByVal quant As Integer, ByVal preco As Double)
        Dim strSQL As String = "Insert into Conferencia_nota_item (id_conferencia, id_filial_nota, cod_produto,qtde,preco) " & _
            "Values(@idconf, @idfilial,@codprod, @quant,@preco)"
        Dim cmd As New SqlCommand(strSQL, d.con)
        cmd.Parameters.AddWithValue("@idconf", idconf)
        cmd.Parameters.AddWithValue("@idfilial", idfilial)
        cmd.Parameters.AddWithValue("@codprod", codprod)
        cmd.Parameters.AddWithValue("@quant", quant)
        cmd.Parameters.AddWithValue("@preco", preco)

        Try
            d.conecta()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            d.desconecta()
        End Try
    End Sub

    Private Function retorna_preco(ByVal idconf As Integer, ByVal idfilial As Integer, ByVal codprod As Integer) As Double
        Dim strSQL As String = "Select preco From Conferencia_nota_item where id_conferencia = @idconf and id_filial_nota = @idfilial " & _
            "and cod_produto = @codprod"
        Dim cmd As New SqlCommand(strSQL, d.con)
        cmd.Parameters.AddWithValue("@idconf", idconf)
        cmd.Parameters.AddWithValue("@idfilial", idfilial)
        cmd.Parameters.AddWithValue("@codprod", codprod)
        Dim dr As SqlDataReader

        Try
            d.conecta()
            dr = cmd.ExecuteReader
            dr.Read()
            Return dr.Item("preco").ToString
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            d.desconecta()
        End Try
    End Function
End Class

