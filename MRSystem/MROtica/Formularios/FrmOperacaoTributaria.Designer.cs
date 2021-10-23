namespace MROtica.Formularios
{
    partial class FrmOperacaoTributaria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOperacaoTributaria));
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.rbFornecedor = new System.Windows.Forms.RadioButton();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.gbDestinatario = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.rbOpNormal = new System.Windows.Forms.RadioButton();
            this.gbOperacao = new System.Windows.Forms.GroupBox();
            this.rbOpConsumidor = new System.Windows.Forms.RadioButton();
            this.rbDevolucao = new System.Windows.Forms.RadioButton();
            this.rbAjuste = new System.Windows.Forms.RadioButton();
            this.rbComplementar = new System.Windows.Forms.RadioButton();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.gbFinalidade = new System.Windows.Forms.GroupBox();
            this.rbExterior = new System.Windows.Forms.RadioButton();
            this.rbInterestadual = new System.Windows.Forms.RadioButton();
            this.rbInterno = new System.Windows.Forms.RadioButton();
            this.gbDestino = new System.Windows.Forms.GroupBox();
            this.btnAlterar = new System.Windows.Forms.ToolStripButton();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboCOFINSST = new System.Windows.Forms.ComboBox();
            this.cboCOFINS = new System.Windows.Forms.ComboBox();
            this.cboPISST = new System.Windows.Forms.ComboBox();
            this.cboPIS = new System.Windows.Forms.ComboBox();
            this.cboISSQN = new System.Windows.Forms.ComboBox();
            this.cboII = new System.Windows.Forms.ComboBox();
            this.cboIPI = new System.Windows.Forms.ComboBox();
            this.cboICMS = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.rbSaida = new System.Windows.Forms.RadioButton();
            this.rbEntrada = new System.Windows.Forms.RadioButton();
            this.gbTipoNotaFiscal = new System.Windows.Forms.GroupBox();
            this.rbVenda = new System.Windows.Forms.RadioButton();
            this.rbCusto = new System.Windows.Forms.RadioButton();
            this.gbTipoPreco = new System.Windows.Forms.GroupBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dgOperacaoTributaria = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCFOP = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gbDestinatario.SuspendLayout();
            this.gbOperacao.SuspendLayout();
            this.gbFinalidade.SuspendLayout();
            this.gbDestino.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.gbTipoNotaFiscal.SuspendLayout();
            this.gbTipoPreco.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOperacaoTributaria)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(77, 36);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // rbFornecedor
            // 
            this.rbFornecedor.AutoSize = true;
            this.rbFornecedor.Location = new System.Drawing.Point(105, 18);
            this.rbFornecedor.Name = "rbFornecedor";
            this.rbFornecedor.Size = new System.Drawing.Size(79, 17);
            this.rbFornecedor.TabIndex = 2;
            this.rbFornecedor.TabStop = true;
            this.rbFornecedor.Text = "Fornecedor";
            this.rbFornecedor.UseVisualStyleBackColor = true;
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Location = new System.Drawing.Point(11, 18);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(57, 17);
            this.rbCliente.TabIndex = 1;
            this.rbCliente.TabStop = true;
            this.rbCliente.Text = "Cliente";
            this.rbCliente.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(62, 36);
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // ToolStripSeparator4
            // 
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            this.ToolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // gbDestinatario
            // 
            this.gbDestinatario.Controls.Add(this.rbFornecedor);
            this.gbDestinatario.Controls.Add(this.rbCliente);
            this.gbDestinatario.Enabled = false;
            this.gbDestinatario.Location = new System.Drawing.Point(191, 134);
            this.gbDestinatario.Name = "gbDestinatario";
            this.gbDestinatario.Size = new System.Drawing.Size(197, 41);
            this.gbDestinatario.TabIndex = 7;
            this.gbDestinatario.TabStop = false;
            this.gbDestinatario.Text = "Destinatário";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 36);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // ToolStripSeparator5
            // 
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            this.ToolStripSeparator5.Size = new System.Drawing.Size(6, 39);
            // 
            // ToolStripSeparator6
            // 
            this.ToolStripSeparator6.Name = "ToolStripSeparator6";
            this.ToolStripSeparator6.Size = new System.Drawing.Size(6, 39);
            // 
            // rbOpNormal
            // 
            this.rbOpNormal.AutoSize = true;
            this.rbOpNormal.Location = new System.Drawing.Point(7, 18);
            this.rbOpNormal.Name = "rbOpNormal";
            this.rbOpNormal.Size = new System.Drawing.Size(58, 17);
            this.rbOpNormal.TabIndex = 0;
            this.rbOpNormal.TabStop = true;
            this.rbOpNormal.Text = "Normal";
            this.rbOpNormal.UseVisualStyleBackColor = true;
            // 
            // gbOperacao
            // 
            this.gbOperacao.Controls.Add(this.rbOpConsumidor);
            this.gbOperacao.Controls.Add(this.rbOpNormal);
            this.gbOperacao.Enabled = false;
            this.gbOperacao.Location = new System.Drawing.Point(723, 75);
            this.gbOperacao.Name = "gbOperacao";
            this.gbOperacao.Size = new System.Drawing.Size(174, 51);
            this.gbOperacao.TabIndex = 4;
            this.gbOperacao.TabStop = false;
            this.gbOperacao.Text = "Tipo Operação";
            // 
            // rbOpConsumidor
            // 
            this.rbOpConsumidor.AutoSize = true;
            this.rbOpConsumidor.Location = new System.Drawing.Point(65, 18);
            this.rbOpConsumidor.Name = "rbOpConsumidor";
            this.rbOpConsumidor.Size = new System.Drawing.Size(105, 17);
            this.rbOpConsumidor.TabIndex = 1;
            this.rbOpConsumidor.TabStop = true;
            this.rbOpConsumidor.Text = "Consumidor Final";
            this.rbOpConsumidor.UseVisualStyleBackColor = true;
            // 
            // rbDevolucao
            // 
            this.rbDevolucao.AutoSize = true;
            this.rbDevolucao.Location = new System.Drawing.Point(117, 29);
            this.rbDevolucao.Name = "rbDevolucao";
            this.rbDevolucao.Size = new System.Drawing.Size(148, 17);
            this.rbDevolucao.TabIndex = 4;
            this.rbDevolucao.TabStop = true;
            this.rbDevolucao.Text = "Devolução de Mercadoria";
            this.rbDevolucao.UseVisualStyleBackColor = true;
            // 
            // rbAjuste
            // 
            this.rbAjuste.AutoSize = true;
            this.rbAjuste.Location = new System.Drawing.Point(117, 13);
            this.rbAjuste.Name = "rbAjuste";
            this.rbAjuste.Size = new System.Drawing.Size(54, 17);
            this.rbAjuste.TabIndex = 3;
            this.rbAjuste.TabStop = true;
            this.rbAjuste.Text = "Ajuste";
            this.rbAjuste.UseVisualStyleBackColor = true;
            // 
            // rbComplementar
            // 
            this.rbComplementar.AutoSize = true;
            this.rbComplementar.Location = new System.Drawing.Point(10, 29);
            this.rbComplementar.Name = "rbComplementar";
            this.rbComplementar.Size = new System.Drawing.Size(92, 17);
            this.rbComplementar.TabIndex = 2;
            this.rbComplementar.TabStop = true;
            this.rbComplementar.Text = "Complementar";
            this.rbComplementar.UseVisualStyleBackColor = true;
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Location = new System.Drawing.Point(10, 13);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(58, 17);
            this.rbNormal.TabIndex = 1;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Normal";
            this.rbNormal.UseVisualStyleBackColor = true;
            // 
            // gbFinalidade
            // 
            this.gbFinalidade.Controls.Add(this.rbDevolucao);
            this.gbFinalidade.Controls.Add(this.rbAjuste);
            this.gbFinalidade.Controls.Add(this.rbComplementar);
            this.gbFinalidade.Controls.Add(this.rbNormal);
            this.gbFinalidade.Enabled = false;
            this.gbFinalidade.Location = new System.Drawing.Point(449, 76);
            this.gbFinalidade.Name = "gbFinalidade";
            this.gbFinalidade.Size = new System.Drawing.Size(268, 51);
            this.gbFinalidade.TabIndex = 3;
            this.gbFinalidade.TabStop = false;
            this.gbFinalidade.Text = "Finalidade de emissão NF-e";
            // 
            // rbExterior
            // 
            this.rbExterior.AutoSize = true;
            this.rbExterior.Location = new System.Drawing.Point(206, 18);
            this.rbExterior.Name = "rbExterior";
            this.rbExterior.Size = new System.Drawing.Size(60, 17);
            this.rbExterior.TabIndex = 3;
            this.rbExterior.TabStop = true;
            this.rbExterior.Text = "Exterior";
            this.rbExterior.UseVisualStyleBackColor = true;
            // 
            // rbInterestadual
            // 
            this.rbInterestadual.AutoSize = true;
            this.rbInterestadual.Location = new System.Drawing.Point(96, 18);
            this.rbInterestadual.Name = "rbInterestadual";
            this.rbInterestadual.Size = new System.Drawing.Size(86, 17);
            this.rbInterestadual.TabIndex = 2;
            this.rbInterestadual.TabStop = true;
            this.rbInterestadual.Text = "Interestadual";
            this.rbInterestadual.UseVisualStyleBackColor = true;
            // 
            // rbInterno
            // 
            this.rbInterno.AutoSize = true;
            this.rbInterno.Location = new System.Drawing.Point(6, 18);
            this.rbInterno.Name = "rbInterno";
            this.rbInterno.Size = new System.Drawing.Size(58, 17);
            this.rbInterno.TabIndex = 1;
            this.rbInterno.TabStop = true;
            this.rbInterno.Text = "Interno";
            this.rbInterno.UseVisualStyleBackColor = true;
            // 
            // gbDestino
            // 
            this.gbDestino.Controls.Add(this.rbExterior);
            this.gbDestino.Controls.Add(this.rbInterestadual);
            this.gbDestino.Controls.Add(this.rbInterno);
            this.gbDestino.Enabled = false;
            this.gbDestino.Location = new System.Drawing.Point(397, 134);
            this.gbDestino.Name = "gbDestino";
            this.gbDestino.Size = new System.Drawing.Size(277, 41);
            this.gbDestino.TabIndex = 8;
            this.gbDestino.TabStop = false;
            this.gbDestino.Text = "Destino da Operação";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(78, 36);
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.label11);
            this.GroupBox3.Controls.Add(this.label10);
            this.GroupBox3.Controls.Add(this.label9);
            this.GroupBox3.Controls.Add(this.label8);
            this.GroupBox3.Controls.Add(this.label7);
            this.GroupBox3.Controls.Add(this.label6);
            this.GroupBox3.Controls.Add(this.label5);
            this.GroupBox3.Controls.Add(this.cboCOFINSST);
            this.GroupBox3.Controls.Add(this.cboCOFINS);
            this.GroupBox3.Controls.Add(this.cboPISST);
            this.GroupBox3.Controls.Add(this.cboPIS);
            this.GroupBox3.Controls.Add(this.cboISSQN);
            this.GroupBox3.Controls.Add(this.cboII);
            this.GroupBox3.Controls.Add(this.cboIPI);
            this.GroupBox3.Controls.Add(this.cboICMS);
            this.GroupBox3.Controls.Add(this.Label4);
            this.GroupBox3.Enabled = false;
            this.GroupBox3.Location = new System.Drawing.Point(8, 189);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(922, 101);
            this.GroupBox3.TabIndex = 9;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Situação Tributária";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(378, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 82;
            this.label11.Text = "Cofins ST";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 81;
            this.label10.Text = "Cofins";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(640, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 80;
            this.label9.Text = "Modelo PIS ST";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(378, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 79;
            this.label8.Text = "Modelo PIS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 78;
            this.label7.Text = "Modelo ISSQN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(640, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 77;
            this.label6.Text = "Modeo II";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 76;
            this.label5.Text = "Modelo IPI";
            // 
            // cboCOFINSST
            // 
            this.cboCOFINSST.FormattingEnabled = true;
            this.cboCOFINSST.Items.AddRange(new object[] {
            "COFINS Substituição Tributária"});
            this.cboCOFINSST.Location = new System.Drawing.Point(442, 73);
            this.cboCOFINSST.Name = "cboCOFINSST";
            this.cboCOFINSST.Size = new System.Drawing.Size(177, 21);
            this.cboCOFINSST.TabIndex = 6;
            this.cboCOFINSST.SelectedIndexChanged += new System.EventHandler(this.cboCOFINSST_SelectedIndexChanged);
            // 
            // cboCOFINS
            // 
            this.cboCOFINS.FormattingEnabled = true;
            this.cboCOFINS.Items.AddRange(new object[] {
            "COFINS Alíquota",
            "COFINS Quantidade",
            "COFINS Não Tributado",
            "COFINS Outras Operações"});
            this.cboCOFINS.Location = new System.Drawing.Point(176, 73);
            this.cboCOFINS.Name = "cboCOFINS";
            this.cboCOFINS.Size = new System.Drawing.Size(177, 21);
            this.cboCOFINS.TabIndex = 3;
            this.cboCOFINS.SelectedIndexChanged += new System.EventHandler(this.cboCOFINS_SelectedIndexChanged);
            // 
            // cboPISST
            // 
            this.cboPISST.FormattingEnabled = true;
            this.cboPISST.Items.AddRange(new object[] {
            "PIS Substituição Tributária"});
            this.cboPISST.Location = new System.Drawing.Point(726, 47);
            this.cboPISST.Name = "cboPISST";
            this.cboPISST.Size = new System.Drawing.Size(177, 21);
            this.cboPISST.TabIndex = 8;
            this.cboPISST.SelectedIndexChanged += new System.EventHandler(this.cboPISST_SelectedIndexChanged);
            // 
            // cboPIS
            // 
            this.cboPIS.FormattingEnabled = true;
            this.cboPIS.Items.AddRange(new object[] {
            "PIS Alíquota",
            "PIS Quantidade",
            "PIS Não Tributado",
            "PIS Outras Operações"});
            this.cboPIS.Location = new System.Drawing.Point(442, 47);
            this.cboPIS.Name = "cboPIS";
            this.cboPIS.Size = new System.Drawing.Size(177, 21);
            this.cboPIS.TabIndex = 5;
            this.cboPIS.SelectedIndexChanged += new System.EventHandler(this.cboPIS_SelectedIndexChanged);
            // 
            // cboISSQN
            // 
            this.cboISSQN.FormattingEnabled = true;
            this.cboISSQN.Items.AddRange(new object[] {
            "ISSQN"});
            this.cboISSQN.Location = new System.Drawing.Point(176, 47);
            this.cboISSQN.Name = "cboISSQN";
            this.cboISSQN.Size = new System.Drawing.Size(177, 21);
            this.cboISSQN.TabIndex = 2;
            this.cboISSQN.SelectedIndexChanged += new System.EventHandler(this.cboISSQN_SelectedIndexChanged);
            // 
            // cboII
            // 
            this.cboII.FormattingEnabled = true;
            this.cboII.Items.AddRange(new object[] {
            "II"});
            this.cboII.Location = new System.Drawing.Point(726, 22);
            this.cboII.Name = "cboII";
            this.cboII.Size = new System.Drawing.Size(177, 21);
            this.cboII.TabIndex = 7;
            this.cboII.SelectedIndexChanged += new System.EventHandler(this.cboII_SelectedIndexChanged);
            // 
            // cboIPI
            // 
            this.cboIPI.FormattingEnabled = true;
            this.cboIPI.Items.AddRange(new object[] {
            "IPI Tributado",
            "IPI Não Tributado"});
            this.cboIPI.Location = new System.Drawing.Point(442, 22);
            this.cboIPI.Name = "cboIPI";
            this.cboIPI.Size = new System.Drawing.Size(177, 21);
            this.cboIPI.TabIndex = 4;
            this.cboIPI.SelectedIndexChanged += new System.EventHandler(this.cboIPI_SelectedIndexChanged);
            // 
            // cboICMS
            // 
            this.cboICMS.FormattingEnabled = true;
            this.cboICMS.Location = new System.Drawing.Point(176, 22);
            this.cboICMS.Name = "cboICMS";
            this.cboICMS.Size = new System.Drawing.Size(177, 21);
            this.cboICMS.TabIndex = 1;
            this.cboICMS.SelectedIndexChanged += new System.EventHandler(this.cboICMS_SelectedIndexChanged);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(8, 25);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(162, 13);
            this.Label4.TabIndex = 1;
            this.Label4.Text = "Código Situação Tributária (CST)";
            // 
            // rbSaida
            // 
            this.rbSaida.AutoSize = true;
            this.rbSaida.Location = new System.Drawing.Point(105, 18);
            this.rbSaida.Name = "rbSaida";
            this.rbSaida.Size = new System.Drawing.Size(54, 17);
            this.rbSaida.TabIndex = 2;
            this.rbSaida.TabStop = true;
            this.rbSaida.Text = "Saída";
            this.rbSaida.UseVisualStyleBackColor = true;
            // 
            // rbEntrada
            // 
            this.rbEntrada.AutoSize = true;
            this.rbEntrada.Location = new System.Drawing.Point(11, 18);
            this.rbEntrada.Name = "rbEntrada";
            this.rbEntrada.Size = new System.Drawing.Size(62, 17);
            this.rbEntrada.TabIndex = 1;
            this.rbEntrada.TabStop = true;
            this.rbEntrada.Text = "Entrada";
            this.rbEntrada.UseVisualStyleBackColor = true;
            // 
            // gbTipoNotaFiscal
            // 
            this.gbTipoNotaFiscal.Controls.Add(this.rbSaida);
            this.gbTipoNotaFiscal.Controls.Add(this.rbEntrada);
            this.gbTipoNotaFiscal.Enabled = false;
            this.gbTipoNotaFiscal.Location = new System.Drawing.Point(11, 134);
            this.gbTipoNotaFiscal.Name = "gbTipoNotaFiscal";
            this.gbTipoNotaFiscal.Size = new System.Drawing.Size(170, 41);
            this.gbTipoNotaFiscal.TabIndex = 6;
            this.gbTipoNotaFiscal.TabStop = false;
            this.gbTipoNotaFiscal.Text = "Tipo Nota Fiscal";
            // 
            // rbVenda
            // 
            this.rbVenda.AutoSize = true;
            this.rbVenda.Location = new System.Drawing.Point(105, 18);
            this.rbVenda.Name = "rbVenda";
            this.rbVenda.Size = new System.Drawing.Size(56, 17);
            this.rbVenda.TabIndex = 1;
            this.rbVenda.TabStop = true;
            this.rbVenda.Text = "Venda";
            this.rbVenda.UseVisualStyleBackColor = true;
            // 
            // rbCusto
            // 
            this.rbCusto.AutoSize = true;
            this.rbCusto.Location = new System.Drawing.Point(11, 18);
            this.rbCusto.Name = "rbCusto";
            this.rbCusto.Size = new System.Drawing.Size(52, 17);
            this.rbCusto.TabIndex = 0;
            this.rbCusto.TabStop = true;
            this.rbCusto.Text = "Custo";
            this.rbCusto.UseVisualStyleBackColor = true;
            // 
            // gbTipoPreco
            // 
            this.gbTipoPreco.Controls.Add(this.rbVenda);
            this.gbTipoPreco.Controls.Add(this.rbCusto);
            this.gbTipoPreco.Enabled = false;
            this.gbTipoPreco.Location = new System.Drawing.Point(902, 81);
            this.gbTipoPreco.Name = "gbTipoPreco";
            this.gbTipoPreco.Size = new System.Drawing.Size(170, 41);
            this.gbTipoPreco.TabIndex = 5;
            this.gbTipoPreco.TabStop = false;
            this.gbTipoPreco.Text = "Tipo Preço";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Enabled = false;
            this.txtObservacao.Location = new System.Drawing.Point(82, 108);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(351, 20);
            this.txtObservacao.TabIndex = 2;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Location = new System.Drawing.Point(82, 83);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(351, 20);
            this.txtDescricao.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(82, 58);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(68, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(8, 111);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(68, 13);
            this.Label3.TabIndex = 54;
            this.Label3.Text = "Observação:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(8, 85);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(58, 13);
            this.Label2.TabIndex = 51;
            this.Label2.Text = "Descrição:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(8, 61);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(43, 13);
            this.Label1.TabIndex = 50;
            this.Label1.Text = "Código:";
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(74, 36);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // btnNovo
            // 
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(72, 36);
            this.btnNovo.Text = "Novo";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovo,
            this.ToolStripSeparator1,
            this.btnSalvar,
            this.ToolStripSeparator2,
            this.btnAlterar,
            this.ToolStripSeparator6,
            this.btnExcluir,
            this.ToolStripSeparator3,
            this.btnCancelar,
            this.ToolStripSeparator4,
            this.ToolStripSeparator5,
            this.btnSair});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(1081, 39);
            this.ToolStrip1.TabIndex = 60;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // dgOperacaoTributaria
            // 
            this.dgOperacaoTributaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOperacaoTributaria.Location = new System.Drawing.Point(8, 298);
            this.dgOperacaoTributaria.Name = "dgOperacaoTributaria";
            this.dgOperacaoTributaria.Size = new System.Drawing.Size(1062, 267);
            this.dgOperacaoTributaria.TabIndex = 10;
            this.dgOperacaoTributaria.SelectionChanged += new System.EventHandler(this.dgOperacaoTributaria_SelectionChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(684, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 61;
            this.label12.Text = "CFOP:";
            // 
            // txtCFOP
            // 
            this.txtCFOP.Enabled = false;
            this.txtCFOP.Location = new System.Drawing.Point(687, 152);
            this.txtCFOP.Name = "txtCFOP";
            this.txtCFOP.Size = new System.Drawing.Size(69, 20);
            this.txtCFOP.TabIndex = 62;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(472, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 63;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmOperacaoTributaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 576);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCFOP);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgOperacaoTributaria);
            this.Controls.Add(this.gbDestinatario);
            this.Controls.Add(this.gbOperacao);
            this.Controls.Add(this.gbFinalidade);
            this.Controls.Add(this.gbDestino);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.gbTipoNotaFiscal);
            this.Controls.Add(this.gbTipoPreco);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.ToolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmOperacaoTributaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operação Tributária";
            this.Load += new System.EventHandler(this.FrmOperacaoTributaria_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmOperacaoTributaria_KeyDown);
            this.gbDestinatario.ResumeLayout(false);
            this.gbDestinatario.PerformLayout();
            this.gbOperacao.ResumeLayout(false);
            this.gbOperacao.PerformLayout();
            this.gbFinalidade.ResumeLayout(false);
            this.gbFinalidade.PerformLayout();
            this.gbDestino.ResumeLayout(false);
            this.gbDestino.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.gbTipoNotaFiscal.ResumeLayout(false);
            this.gbTipoNotaFiscal.PerformLayout();
            this.gbTipoPreco.ResumeLayout(false);
            this.gbTipoPreco.PerformLayout();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOperacaoTributaria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStripButton btnExcluir;
        internal System.Windows.Forms.RadioButton rbFornecedor;
        internal System.Windows.Forms.RadioButton rbCliente;
        internal System.Windows.Forms.ToolStripButton btnSair;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator4;
        internal System.Windows.Forms.GroupBox gbDestinatario;
        internal System.Windows.Forms.ToolStripButton btnCancelar;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator5;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator6;
        internal System.Windows.Forms.RadioButton rbOpNormal;
        internal System.Windows.Forms.GroupBox gbOperacao;
        internal System.Windows.Forms.RadioButton rbOpConsumidor;
        internal System.Windows.Forms.RadioButton rbDevolucao;
        internal System.Windows.Forms.RadioButton rbAjuste;
        internal System.Windows.Forms.RadioButton rbComplementar;
        internal System.Windows.Forms.RadioButton rbNormal;
        internal System.Windows.Forms.GroupBox gbFinalidade;
        internal System.Windows.Forms.RadioButton rbExterior;
        internal System.Windows.Forms.RadioButton rbInterestadual;
        internal System.Windows.Forms.RadioButton rbInterno;
        internal System.Windows.Forms.GroupBox gbDestino;
        internal System.Windows.Forms.ToolStripButton btnAlterar;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.RadioButton rbSaida;
        internal System.Windows.Forms.RadioButton rbEntrada;
        internal System.Windows.Forms.GroupBox gbTipoNotaFiscal;
        internal System.Windows.Forms.RadioButton rbVenda;
        internal System.Windows.Forms.RadioButton rbCusto;
        internal System.Windows.Forms.GroupBox gbTipoPreco;
        internal System.Windows.Forms.TextBox txtObservacao;
        internal System.Windows.Forms.TextBox txtDescricao;
        internal System.Windows.Forms.TextBox txtCodigo;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        internal System.Windows.Forms.ToolStripButton btnSalvar;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton btnNovo;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        private System.Windows.Forms.ComboBox cboICMS;
        private System.Windows.Forms.ComboBox cboIPI;
        private System.Windows.Forms.ComboBox cboISSQN;
        private System.Windows.Forms.ComboBox cboII;
        private System.Windows.Forms.ComboBox cboPIS;
        private System.Windows.Forms.ComboBox cboPISST;
        private System.Windows.Forms.ComboBox cboCOFINSST;
        private System.Windows.Forms.ComboBox cboCOFINS;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgOperacaoTributaria;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCFOP;
        private System.Windows.Forms.Button button1;
    }
}