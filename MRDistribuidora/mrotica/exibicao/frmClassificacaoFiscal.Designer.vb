<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClassificacaoFiscal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClassificacaoFiscal))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.txtObservacao = New System.Windows.Forms.TextBox()
        Me.gbTipoPreco = New System.Windows.Forms.GroupBox()
        Me.rbVenda = New System.Windows.Forms.RadioButton()
        Me.rbCusto = New System.Windows.Forms.RadioButton()
        Me.gbTipoNotaFiscal = New System.Windows.Forms.GroupBox()
        Me.rbSaida = New System.Windows.Forms.RadioButton()
        Me.rbEntrada = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtReducaoICMS = New System.Windows.Forms.TextBox()
        Me.txtReducaoSTICMS = New System.Windows.Forms.TextBox()
        Me.txtAliquotaMotivoBC = New System.Windows.Forms.TextBox()
        Me.txtAliquotaICMS = New System.Windows.Forms.TextBox()
        Me.cbICMS = New System.Windows.Forms.CheckBox()
        Me.txtPMargem = New System.Windows.Forms.TextBox()
        Me.cbModalidadeBC = New System.Windows.Forms.ComboBox()
        Me.cbMotivoBC = New System.Windows.Forms.ComboBox()
        Me.cbSituacaoICMS = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCFOP = New System.Windows.Forms.TextBox()
        Me.txtSTributaria = New System.Windows.Forms.TextBox()
        Me.lblDescricaoCFOP = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNovo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAlterar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnExcluir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSalvar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSair = New System.Windows.Forms.ToolStripButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.txtAliquotaCofins = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtAliquotaPIS = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cbCOFINS = New System.Windows.Forms.ComboBox()
        Me.cbPIS = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtAliquotaIPI = New System.Windows.Forms.TextBox()
        Me.cbISS = New System.Windows.Forms.CheckBox()
        Me.cbIPILista = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtAliquotaISS = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.cbIPI = New System.Windows.Forms.CheckBox()
        Me.gbISS = New System.Windows.Forms.GroupBox()
        Me.gbDestino = New System.Windows.Forms.GroupBox()
        Me.cbDestinoOperacao = New System.Windows.Forms.ComboBox()
        Me.gbFinalidade = New System.Windows.Forms.GroupBox()
        Me.cbFinalidade = New System.Windows.Forms.ComboBox()
        Me.gbOperacao = New System.Windows.Forms.GroupBox()
        Me.cbConsumidorFinal = New System.Windows.Forms.ComboBox()
        Me.cbConsumidorPresente = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gbTipoPreco.SuspendLayout()
        Me.gbTipoNotaFiscal.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.gbISS.SuspendLayout()
        Me.gbDestino.SuspendLayout()
        Me.gbFinalidade.SuspendLayout()
        Me.gbOperacao.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Código:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Descrição:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Observação:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(82, 51)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(68, 20)
        Me.txtCodigo.TabIndex = 2
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDescricao
        '
        Me.txtDescricao.Enabled = False
        Me.txtDescricao.Location = New System.Drawing.Point(82, 76)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(351, 20)
        Me.txtDescricao.TabIndex = 4
        '
        'txtObservacao
        '
        Me.txtObservacao.Enabled = False
        Me.txtObservacao.Location = New System.Drawing.Point(82, 101)
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.Size = New System.Drawing.Size(351, 20)
        Me.txtObservacao.TabIndex = 6
        '
        'gbTipoPreco
        '
        Me.gbTipoPreco.Controls.Add(Me.rbVenda)
        Me.gbTipoPreco.Controls.Add(Me.rbCusto)
        Me.gbTipoPreco.Enabled = False
        Me.gbTipoPreco.Location = New System.Drawing.Point(8, 127)
        Me.gbTipoPreco.Name = "gbTipoPreco"
        Me.gbTipoPreco.Size = New System.Drawing.Size(170, 47)
        Me.gbTipoPreco.TabIndex = 9
        Me.gbTipoPreco.TabStop = False
        Me.gbTipoPreco.Text = "Tipo Preço"
        '
        'rbVenda
        '
        Me.rbVenda.AutoSize = True
        Me.rbVenda.Location = New System.Drawing.Point(105, 18)
        Me.rbVenda.Name = "rbVenda"
        Me.rbVenda.Size = New System.Drawing.Size(56, 17)
        Me.rbVenda.TabIndex = 1
        Me.rbVenda.TabStop = True
        Me.rbVenda.Text = "Venda"
        Me.rbVenda.UseVisualStyleBackColor = True
        '
        'rbCusto
        '
        Me.rbCusto.AutoSize = True
        Me.rbCusto.Location = New System.Drawing.Point(11, 18)
        Me.rbCusto.Name = "rbCusto"
        Me.rbCusto.Size = New System.Drawing.Size(52, 17)
        Me.rbCusto.TabIndex = 0
        Me.rbCusto.TabStop = True
        Me.rbCusto.Text = "Custo"
        Me.rbCusto.UseVisualStyleBackColor = True
        '
        'gbTipoNotaFiscal
        '
        Me.gbTipoNotaFiscal.Controls.Add(Me.rbSaida)
        Me.gbTipoNotaFiscal.Controls.Add(Me.rbEntrada)
        Me.gbTipoNotaFiscal.Enabled = False
        Me.gbTipoNotaFiscal.Location = New System.Drawing.Point(214, 127)
        Me.gbTipoNotaFiscal.Name = "gbTipoNotaFiscal"
        Me.gbTipoNotaFiscal.Size = New System.Drawing.Size(170, 47)
        Me.gbTipoNotaFiscal.TabIndex = 10
        Me.gbTipoNotaFiscal.TabStop = False
        Me.gbTipoNotaFiscal.Text = "Tipo Nota Fiscal"
        '
        'rbSaida
        '
        Me.rbSaida.AutoSize = True
        Me.rbSaida.Location = New System.Drawing.Point(105, 18)
        Me.rbSaida.Name = "rbSaida"
        Me.rbSaida.Size = New System.Drawing.Size(54, 17)
        Me.rbSaida.TabIndex = 1
        Me.rbSaida.TabStop = True
        Me.rbSaida.Text = "Saída"
        Me.rbSaida.UseVisualStyleBackColor = True
        '
        'rbEntrada
        '
        Me.rbEntrada.AutoSize = True
        Me.rbEntrada.Location = New System.Drawing.Point(11, 18)
        Me.rbEntrada.Name = "rbEntrada"
        Me.rbEntrada.Size = New System.Drawing.Size(62, 17)
        Me.rbEntrada.TabIndex = 0
        Me.rbEntrada.TabStop = True
        Me.rbEntrada.Text = "Entrada"
        Me.rbEntrada.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.txtCFOP)
        Me.GroupBox3.Controls.Add(Me.txtSTributaria)
        Me.GroupBox3.Controls.Add(Me.lblDescricaoCFOP)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 181)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(922, 173)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Situação Tributária"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "CFOP:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtReducaoICMS)
        Me.GroupBox5.Controls.Add(Me.txtReducaoSTICMS)
        Me.GroupBox5.Controls.Add(Me.txtAliquotaMotivoBC)
        Me.GroupBox5.Controls.Add(Me.txtAliquotaICMS)
        Me.GroupBox5.Controls.Add(Me.cbICMS)
        Me.GroupBox5.Controls.Add(Me.txtPMargem)
        Me.GroupBox5.Controls.Add(Me.cbModalidadeBC)
        Me.GroupBox5.Controls.Add(Me.cbMotivoBC)
        Me.GroupBox5.Controls.Add(Me.cbSituacaoICMS)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Location = New System.Drawing.Point(5, 59)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(910, 105)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        '
        'txtReducaoICMS
        '
        Me.txtReducaoICMS.Enabled = False
        Me.txtReducaoICMS.Location = New System.Drawing.Point(839, 49)
        Me.txtReducaoICMS.Name = "txtReducaoICMS"
        Me.txtReducaoICMS.Size = New System.Drawing.Size(65, 20)
        Me.txtReducaoICMS.TabIndex = 14
        Me.txtReducaoICMS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtReducaoSTICMS
        '
        Me.txtReducaoSTICMS.Enabled = False
        Me.txtReducaoSTICMS.Location = New System.Drawing.Point(839, 75)
        Me.txtReducaoSTICMS.Name = "txtReducaoSTICMS"
        Me.txtReducaoSTICMS.Size = New System.Drawing.Size(65, 20)
        Me.txtReducaoSTICMS.TabIndex = 22
        Me.txtReducaoSTICMS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAliquotaMotivoBC
        '
        Me.txtAliquotaMotivoBC.Enabled = False
        Me.txtAliquotaMotivoBC.Location = New System.Drawing.Point(707, 75)
        Me.txtAliquotaMotivoBC.Name = "txtAliquotaMotivoBC"
        Me.txtAliquotaMotivoBC.Size = New System.Drawing.Size(65, 20)
        Me.txtAliquotaMotivoBC.TabIndex = 20
        Me.txtAliquotaMotivoBC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAliquotaICMS
        '
        Me.txtAliquotaICMS.Enabled = False
        Me.txtAliquotaICMS.Location = New System.Drawing.Point(707, 49)
        Me.txtAliquotaICMS.Name = "txtAliquotaICMS"
        Me.txtAliquotaICMS.Size = New System.Drawing.Size(65, 20)
        Me.txtAliquotaICMS.TabIndex = 12
        Me.txtAliquotaICMS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbICMS
        '
        Me.cbICMS.AutoSize = True
        Me.cbICMS.Enabled = False
        Me.cbICMS.Location = New System.Drawing.Point(677, 23)
        Me.cbICMS.Name = "cbICMS"
        Me.cbICMS.Size = New System.Drawing.Size(90, 17)
        Me.cbICMS.TabIndex = 2
        Me.cbICMS.Text = "Calcula ICMS"
        Me.cbICMS.UseVisualStyleBackColor = True
        '
        'txtPMargem
        '
        Me.txtPMargem.Enabled = False
        Me.txtPMargem.Location = New System.Drawing.Point(579, 75)
        Me.txtPMargem.Name = "txtPMargem"
        Me.txtPMargem.Size = New System.Drawing.Size(59, 20)
        Me.txtPMargem.TabIndex = 18
        Me.txtPMargem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbModalidadeBC
        '
        Me.cbModalidadeBC.Enabled = False
        Me.cbModalidadeBC.FormattingEnabled = True
        Me.cbModalidadeBC.Location = New System.Drawing.Point(137, 75)
        Me.cbModalidadeBC.Name = "cbModalidadeBC"
        Me.cbModalidadeBC.Size = New System.Drawing.Size(348, 21)
        Me.cbModalidadeBC.TabIndex = 16
        '
        'cbMotivoBC
        '
        Me.cbMotivoBC.Enabled = False
        Me.cbMotivoBC.FormattingEnabled = True
        Me.cbMotivoBC.Location = New System.Drawing.Point(137, 49)
        Me.cbMotivoBC.Name = "cbMotivoBC"
        Me.cbMotivoBC.Size = New System.Drawing.Size(502, 21)
        Me.cbMotivoBC.TabIndex = 10
        '
        'cbSituacaoICMS
        '
        Me.cbSituacaoICMS.Enabled = False
        Me.cbSituacaoICMS.FormattingEnabled = True
        Me.cbSituacaoICMS.Location = New System.Drawing.Point(137, 23)
        Me.cbSituacaoICMS.Name = "cbSituacaoICMS"
        Me.cbSituacaoICMS.Size = New System.Drawing.Size(502, 21)
        Me.cbSituacaoICMS.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(780, 78)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 13)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Redução:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(780, 51)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 13)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Redução:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(653, 78)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 13)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Alíquota:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(653, 51)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Alíquota:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(514, 78)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "P. Margem:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(128, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Modalidade BC ICMS ST:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(126, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Modalidade BC do ICMS:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Tributação do ICMS:"
        '
        'txtCFOP
        '
        Me.txtCFOP.Enabled = False
        Me.txtCFOP.Location = New System.Drawing.Point(46, 25)
        Me.txtCFOP.Name = "txtCFOP"
        Me.txtCFOP.Size = New System.Drawing.Size(68, 20)
        Me.txtCFOP.TabIndex = 1
        '
        'txtSTributaria
        '
        Me.txtSTributaria.Enabled = False
        Me.txtSTributaria.Location = New System.Drawing.Point(748, 25)
        Me.txtSTributaria.Name = "txtSTributaria"
        Me.txtSTributaria.Size = New System.Drawing.Size(45, 20)
        Me.txtSTributaria.TabIndex = 3
        '
        'lblDescricaoCFOP
        '
        Me.lblDescricaoCFOP.Location = New System.Drawing.Point(120, 28)
        Me.lblDescricaoCFOP.Name = "lblDescricaoCFOP"
        Me.lblDescricaoCFOP.Size = New System.Drawing.Size(448, 13)
        Me.lblDescricaoCFOP.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(609, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Grupo Tributação do ICMS:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNovo, Me.ToolStripSeparator1, Me.btnAlterar, Me.ToolStripSeparator2, Me.btnExcluir, Me.ToolStripSeparator6, Me.btnSalvar, Me.ToolStripSeparator3, Me.btnCancelar, Me.ToolStripSeparator4, Me.ToolStripSeparator5, Me.btnSair})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(938, 39)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnNovo
        '
        Me.btnNovo.Image = CType(resources.GetObject("btnNovo.Image"), System.Drawing.Image)
        Me.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(72, 36)
        Me.btnNovo.Text = "Novo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'btnAlterar
        '
        Me.btnAlterar.Image = CType(resources.GetObject("btnAlterar.Image"), System.Drawing.Image)
        Me.btnAlterar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(78, 36)
        Me.btnAlterar.Text = "Alterar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'btnExcluir
        '
        Me.btnExcluir.Enabled = False
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(78, 36)
        Me.btnExcluir.Text = "Excluir"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 39)
        '
        'btnSalvar
        '
        Me.btnSalvar.Enabled = False
        Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
        Me.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(74, 36)
        Me.btnSalvar.Text = "Salvar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'btnCancelar
        '
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(89, 36)
        Me.btnCancelar.Text = "Cancelar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 39)
        '
        'btnSair
        '
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(62, 36)
        Me.btnSair.Text = "Sair"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 546)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Obs Impressa:"
        '
        'txtObs
        '
        Me.txtObs.Enabled = False
        Me.txtObs.Location = New System.Drawing.Point(139, 539)
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(514, 20)
        Me.txtObs.TabIndex = 34
        '
        'txtAliquotaCofins
        '
        Me.txtAliquotaCofins.Enabled = False
        Me.txtAliquotaCofins.Location = New System.Drawing.Point(853, 504)
        Me.txtAliquotaCofins.Name = "txtAliquotaCofins"
        Me.txtAliquotaCofins.Size = New System.Drawing.Size(65, 20)
        Me.txtAliquotaCofins.TabIndex = 32
        Me.txtAliquotaCofins.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(794, 507)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(50, 13)
        Me.Label21.TabIndex = 31
        Me.Label21.Text = "Alíquota:"
        '
        'txtAliquotaPIS
        '
        Me.txtAliquotaPIS.Enabled = False
        Me.txtAliquotaPIS.Location = New System.Drawing.Point(853, 478)
        Me.txtAliquotaPIS.Name = "txtAliquotaPIS"
        Me.txtAliquotaPIS.Size = New System.Drawing.Size(65, 20)
        Me.txtAliquotaPIS.TabIndex = 28
        Me.txtAliquotaPIS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(794, 481)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(50, 13)
        Me.Label20.TabIndex = 27
        Me.Label20.Text = "Alíquota:"
        '
        'cbCOFINS
        '
        Me.cbCOFINS.Enabled = False
        Me.cbCOFINS.FormattingEnabled = True
        Me.cbCOFINS.Location = New System.Drawing.Point(139, 501)
        Me.cbCOFINS.Name = "cbCOFINS"
        Me.cbCOFINS.Size = New System.Drawing.Size(514, 21)
        Me.cbCOFINS.TabIndex = 30
        '
        'cbPIS
        '
        Me.cbPIS.Enabled = False
        Me.cbPIS.FormattingEnabled = True
        Me.cbPIS.Location = New System.Drawing.Point(139, 475)
        Me.cbPIS.Name = "cbPIS"
        Me.cbPIS.Size = New System.Drawing.Size(514, 21)
        Me.cbPIS.TabIndex = 26
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(17, 503)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(94, 13)
        Me.Label18.TabIndex = 29
        Me.Label18.Text = "Situação COFINS:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(17, 478)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 13)
        Me.Label19.TabIndex = 25
        Me.Label19.Text = "Situação PIS:"
        '
        'txtAliquotaIPI
        '
        Me.txtAliquotaIPI.Enabled = False
        Me.txtAliquotaIPI.Location = New System.Drawing.Point(839, 23)
        Me.txtAliquotaIPI.Name = "txtAliquotaIPI"
        Me.txtAliquotaIPI.Size = New System.Drawing.Size(65, 20)
        Me.txtAliquotaIPI.TabIndex = 3
        Me.txtAliquotaIPI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbISS
        '
        Me.cbISS.AutoSize = True
        Me.cbISS.Enabled = False
        Me.cbISS.Location = New System.Drawing.Point(3, 17)
        Me.cbISS.Name = "cbISS"
        Me.cbISS.Size = New System.Drawing.Size(84, 17)
        Me.cbISS.TabIndex = 0
        Me.cbISS.Text = "Calcular ISS"
        Me.cbISS.UseVisualStyleBackColor = True
        '
        'cbIPILista
        '
        Me.cbIPILista.Enabled = False
        Me.cbIPILista.FormattingEnabled = True
        Me.cbIPILista.Location = New System.Drawing.Point(125, 23)
        Me.cbIPILista.Name = "cbIPILista"
        Me.cbIPILista.Size = New System.Drawing.Size(514, 21)
        Me.cbIPILista.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(780, 15)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 13)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Alíquota:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(780, 26)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(50, 13)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Alíquota:"
        '
        'txtAliquotaISS
        '
        Me.txtAliquotaISS.Enabled = False
        Me.txtAliquotaISS.Location = New System.Drawing.Point(839, 12)
        Me.txtAliquotaISS.Name = "txtAliquotaISS"
        Me.txtAliquotaISS.Size = New System.Drawing.Size(65, 20)
        Me.txtAliquotaISS.TabIndex = 2
        Me.txtAliquotaISS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(3, 26)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(68, 13)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "Situação IPI:"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtAliquotaIPI)
        Me.GroupBox6.Controls.Add(Me.cbIPI)
        Me.GroupBox6.Controls.Add(Me.cbIPILista)
        Me.GroupBox6.Controls.Add(Me.Label17)
        Me.GroupBox6.Controls.Add(Me.Label23)
        Me.GroupBox6.Location = New System.Drawing.Point(8, 363)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(922, 52)
        Me.GroupBox6.TabIndex = 23
        Me.GroupBox6.TabStop = False
        '
        'cbIPI
        '
        Me.cbIPI.AutoSize = True
        Me.cbIPI.Enabled = False
        Me.cbIPI.Location = New System.Drawing.Point(10, -1)
        Me.cbIPI.Name = "cbIPI"
        Me.cbIPI.Size = New System.Drawing.Size(80, 17)
        Me.cbIPI.TabIndex = 0
        Me.cbIPI.Text = "Calcular IPI"
        Me.cbIPI.UseVisualStyleBackColor = True
        '
        'gbISS
        '
        Me.gbISS.Controls.Add(Me.cbISS)
        Me.gbISS.Controls.Add(Me.txtAliquotaISS)
        Me.gbISS.Controls.Add(Me.Label16)
        Me.gbISS.Location = New System.Drawing.Point(8, 423)
        Me.gbISS.Name = "gbISS"
        Me.gbISS.Size = New System.Drawing.Size(922, 40)
        Me.gbISS.TabIndex = 24
        Me.gbISS.TabStop = False
        Me.gbISS.Text = "Calcula ISS"
        '
        'gbDestino
        '
        Me.gbDestino.Controls.Add(Me.cbDestinoOperacao)
        Me.gbDestino.Enabled = False
        Me.gbDestino.Location = New System.Drawing.Point(412, 128)
        Me.gbDestino.Name = "gbDestino"
        Me.gbDestino.Size = New System.Drawing.Size(235, 47)
        Me.gbDestino.TabIndex = 11
        Me.gbDestino.TabStop = False
        Me.gbDestino.Text = "Destino da Operação"
        '
        'cbDestinoOperacao
        '
        Me.cbDestinoOperacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDestinoOperacao.FormattingEnabled = True
        Me.cbDestinoOperacao.Items.AddRange(New Object() {"Operação Interna", "Operação Interestadual", "Operação com Exterior"})
        Me.cbDestinoOperacao.Location = New System.Drawing.Point(6, 19)
        Me.cbDestinoOperacao.Name = "cbDestinoOperacao"
        Me.cbDestinoOperacao.Size = New System.Drawing.Size(209, 21)
        Me.cbDestinoOperacao.TabIndex = 0
        '
        'gbFinalidade
        '
        Me.gbFinalidade.Controls.Add(Me.cbFinalidade)
        Me.gbFinalidade.Enabled = False
        Me.gbFinalidade.Location = New System.Drawing.Point(449, 71)
        Me.gbFinalidade.Name = "gbFinalidade"
        Me.gbFinalidade.Size = New System.Drawing.Size(270, 47)
        Me.gbFinalidade.TabIndex = 7
        Me.gbFinalidade.TabStop = False
        Me.gbFinalidade.Text = "Finalidade de emissão NF-e"
        '
        'cbFinalidade
        '
        Me.cbFinalidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFinalidade.FormattingEnabled = True
        Me.cbFinalidade.Items.AddRange(New Object() {"Normal", "Complementar", "Ajuste", "Devolução"})
        Me.cbFinalidade.Location = New System.Drawing.Point(6, 20)
        Me.cbFinalidade.Name = "cbFinalidade"
        Me.cbFinalidade.Size = New System.Drawing.Size(209, 21)
        Me.cbFinalidade.TabIndex = 0
        '
        'gbOperacao
        '
        Me.gbOperacao.Controls.Add(Me.cbConsumidorFinal)
        Me.gbOperacao.Enabled = False
        Me.gbOperacao.Location = New System.Drawing.Point(747, 71)
        Me.gbOperacao.Name = "gbOperacao"
        Me.gbOperacao.Size = New System.Drawing.Size(182, 47)
        Me.gbOperacao.TabIndex = 8
        Me.gbOperacao.TabStop = False
        Me.gbOperacao.Text = "Consumidor Final"
        '
        'cbConsumidorFinal
        '
        Me.cbConsumidorFinal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbConsumidorFinal.FormattingEnabled = True
        Me.cbConsumidorFinal.Items.AddRange(New Object() {"Não", "Consumidor Final"})
        Me.cbConsumidorFinal.Location = New System.Drawing.Point(9, 19)
        Me.cbConsumidorFinal.Name = "cbConsumidorFinal"
        Me.cbConsumidorFinal.Size = New System.Drawing.Size(167, 21)
        Me.cbConsumidorFinal.TabIndex = 0
        '
        'cbConsumidorPresente
        '
        Me.cbConsumidorPresente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbConsumidorPresente.FormattingEnabled = True
        Me.cbConsumidorPresente.Items.AddRange(New Object() {"Não se Aplica", "Operação Presencial", "Operação Não Presencial, pela internet", "Operação Não Presencial, Teleatendimento", "Operação não Presencial, Outros"})
        Me.cbConsumidorPresente.Location = New System.Drawing.Point(6, 19)
        Me.cbConsumidorPresente.Name = "cbConsumidorPresente"
        Me.cbConsumidorPresente.Size = New System.Drawing.Size(209, 21)
        Me.cbConsumidorPresente.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbConsumidorPresente)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(653, 128)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(249, 47)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consumidor Presente"
        '
        'frmClassificacaoFiscal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(938, 573)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbOperacao)
        Me.Controls.Add(Me.gbFinalidade)
        Me.Controls.Add(Me.gbDestino)
        Me.Controls.Add(Me.gbISS)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtObs)
        Me.Controls.Add(Me.txtAliquotaCofins)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtAliquotaPIS)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.cbCOFINS)
        Me.Controls.Add(Me.cbPIS)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.gbTipoNotaFiscal)
        Me.Controls.Add(Me.gbTipoPreco)
        Me.Controls.Add(Me.txtObservacao)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmClassificacaoFiscal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Classificação Fiscal"
        Me.gbTipoPreco.ResumeLayout(False)
        Me.gbTipoPreco.PerformLayout()
        Me.gbTipoNotaFiscal.ResumeLayout(False)
        Me.gbTipoNotaFiscal.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.gbISS.ResumeLayout(False)
        Me.gbISS.PerformLayout()
        Me.gbDestino.ResumeLayout(False)
        Me.gbFinalidade.ResumeLayout(False)
        Me.gbOperacao.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtDescricao As System.Windows.Forms.TextBox
    Friend WithEvents txtObservacao As System.Windows.Forms.TextBox
    Friend WithEvents gbTipoPreco As System.Windows.Forms.GroupBox
    Friend WithEvents rbVenda As System.Windows.Forms.RadioButton
    Friend WithEvents rbCusto As System.Windows.Forms.RadioButton
    Friend WithEvents gbTipoNotaFiscal As System.Windows.Forms.GroupBox
    Friend WithEvents rbSaida As System.Windows.Forms.RadioButton
    Friend WithEvents rbEntrada As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNovo As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtCFOP As System.Windows.Forms.TextBox
    Friend WithEvents txtSTributaria As System.Windows.Forms.TextBox
    Friend WithEvents cbICMS As System.Windows.Forms.CheckBox
    Friend WithEvents lblDescricaoCFOP As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtReducaoICMS As System.Windows.Forms.TextBox
    Friend WithEvents txtReducaoSTICMS As System.Windows.Forms.TextBox
    Friend WithEvents txtAliquotaMotivoBC As System.Windows.Forms.TextBox
    Friend WithEvents txtAliquotaICMS As System.Windows.Forms.TextBox
    Friend WithEvents txtPMargem As System.Windows.Forms.TextBox
    Friend WithEvents cbModalidadeBC As System.Windows.Forms.ComboBox
    Friend WithEvents cbMotivoBC As System.Windows.Forms.ComboBox
    Friend WithEvents cbSituacaoICMS As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSalvar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnExcluir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSair As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAlterar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtObs As System.Windows.Forms.TextBox
    Friend WithEvents txtAliquotaCofins As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaPIS As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cbCOFINS As System.Windows.Forms.ComboBox
    Friend WithEvents cbPIS As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaIPI As System.Windows.Forms.TextBox
    Friend WithEvents cbISS As System.Windows.Forms.CheckBox
    Friend WithEvents cbIPILista As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaISS As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents cbIPI As System.Windows.Forms.CheckBox
    Friend WithEvents gbISS As System.Windows.Forms.GroupBox
    Friend WithEvents gbDestino As System.Windows.Forms.GroupBox
    Friend WithEvents gbFinalidade As System.Windows.Forms.GroupBox
    Friend WithEvents gbOperacao As System.Windows.Forms.GroupBox
    Friend WithEvents cbConsumidorFinal As ComboBox
    Friend WithEvents cbFinalidade As ComboBox
    Friend WithEvents cbDestinoOperacao As ComboBox
    Friend WithEvents cbConsumidorPresente As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
