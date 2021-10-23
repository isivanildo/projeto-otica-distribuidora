namespace MROtica.Formularios
{
    partial class FrmICMSPartilha
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
            this.lblUFdICMSST = new System.Windows.Forms.Label();
            this.lblPercBC = new System.Windows.Forms.Label();
            this.txtUFSTICMSPart = new System.Windows.Forms.TextBox();
            this.txtpBCOpICMSPart = new System.Windows.Forms.TextBox();
            this.txtpRedBCICMSPart = new System.Windows.Forms.TextBox();
            this.lblpRedBC = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.cboModSTICMSPart = new System.Windows.Forms.ComboBox();
            this.txtpRedBCSTICMSPart = new System.Windows.Forms.TextBox();
            this.txtpICMSSTICMSPart = new System.Windows.Forms.TextBox();
            this.txtvICMSSTICMSPart = new System.Windows.Forms.TextBox();
            this.txtvBCSTICMSPart = new System.Windows.Forms.TextBox();
            this.txtpMVASTICMSPart = new System.Windows.Forms.TextBox();
            this.lblValorICMSST = new System.Windows.Forms.Label();
            this.lblValorVBICMSST = new System.Windows.Forms.Label();
            this.lblPercRedBCICMSST = new System.Windows.Forms.Label();
            this.lblAliquotaICMSST = new System.Windows.Forms.Label();
            this.lblPercICMSST = new System.Windows.Forms.Label();
            this.lblBCICMSST = new System.Windows.Forms.Label();
            this.lblModalidade = new System.Windows.Forms.Label();
            this.txtValorICMSPart = new System.Windows.Forms.TextBox();
            this.txtAliquotaICMSPart = new System.Windows.Forms.TextBox();
            this.txtValorBCICMSPart = new System.Windows.Forms.TextBox();
            this.txtCSTICMSPart = new System.Windows.Forms.TextBox();
            this.cboModalidadeICMSPart = new System.Windows.Forms.ComboBox();
            this.cboOrigemICMSPart = new System.Windows.Forms.ComboBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblAliquota = new System.Windows.Forms.Label();
            this.lblbcICMS = new System.Windows.Forms.Label();
            this.lblTrbICMS = new System.Windows.Forms.Label();
            this.lblOrigem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUFdICMSST
            // 
            this.lblUFdICMSST.AutoSize = true;
            this.lblUFdICMSST.Location = new System.Drawing.Point(6, 379);
            this.lblUFdICMSST.Name = "lblUFdICMSST";
            this.lblUFdICMSST.Size = new System.Drawing.Size(102, 13);
            this.lblUFdICMSST.TabIndex = 59;
            this.lblUFdICMSST.Text = "UF devido ICMS ST";
            // 
            // lblPercBC
            // 
            this.lblPercBC.AutoSize = true;
            this.lblPercBC.Location = new System.Drawing.Point(185, 332);
            this.lblPercBC.Name = "lblPercBC";
            this.lblPercBC.Size = new System.Drawing.Size(90, 13);
            this.lblPercBC.TabIndex = 57;
            this.lblPercBC.Text = "Percentual da BC";
            // 
            // txtUFSTICMSPart
            // 
            this.txtUFSTICMSPart.Location = new System.Drawing.Point(9, 395);
            this.txtUFSTICMSPart.Name = "txtUFSTICMSPart";
            this.txtUFSTICMSPart.Size = new System.Drawing.Size(142, 20);
            this.txtUFSTICMSPart.TabIndex = 60;
            // 
            // txtpBCOpICMSPart
            // 
            this.txtpBCOpICMSPart.Location = new System.Drawing.Point(188, 348);
            this.txtpBCOpICMSPart.Name = "txtpBCOpICMSPart";
            this.txtpBCOpICMSPart.Size = new System.Drawing.Size(144, 20);
            this.txtpBCOpICMSPart.TabIndex = 58;
            // 
            // txtpRedBCICMSPart
            // 
            this.txtpRedBCICMSPart.Location = new System.Drawing.Point(9, 139);
            this.txtpRedBCICMSPart.Name = "txtpRedBCICMSPart";
            this.txtpRedBCICMSPart.Size = new System.Drawing.Size(142, 20);
            this.txtpRedBCICMSPart.TabIndex = 40;
            // 
            // lblpRedBC
            // 
            this.lblpRedBC.AutoSize = true;
            this.lblpRedBC.Location = new System.Drawing.Point(6, 123);
            this.lblpRedBC.Name = "lblpRedBC";
            this.lblpRedBC.Size = new System.Drawing.Size(152, 13);
            this.lblpRedBC.TabIndex = 39;
            this.lblpRedBC.Text = "Percentual da Redução de BC";
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(257, 393);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 61;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // cboModSTICMSPart
            // 
            this.cboModSTICMSPart.FormattingEnabled = true;
            this.cboModSTICMSPart.Items.AddRange(new object[] {
            "Preço tabelado ou máximo sugerido",
            "Lista Negativa",
            "Lista Positiva",
            "Lista Neutra",
            "Margem Valor Agregado",
            "Pauta"});
            this.cboModSTICMSPart.Location = new System.Drawing.Point(188, 190);
            this.cboModSTICMSPart.Name = "cboModSTICMSPart";
            this.cboModSTICMSPart.Size = new System.Drawing.Size(144, 21);
            this.cboModSTICMSPart.TabIndex = 46;
            // 
            // txtpRedBCSTICMSPart
            // 
            this.txtpRedBCSTICMSPart.Location = new System.Drawing.Point(188, 244);
            this.txtpRedBCSTICMSPart.Name = "txtpRedBCSTICMSPart";
            this.txtpRedBCSTICMSPart.Size = new System.Drawing.Size(144, 20);
            this.txtpRedBCSTICMSPart.TabIndex = 50;
            // 
            // txtpICMSSTICMSPart
            // 
            this.txtpICMSSTICMSPart.Location = new System.Drawing.Point(188, 296);
            this.txtpICMSSTICMSPart.Name = "txtpICMSSTICMSPart";
            this.txtpICMSSTICMSPart.Size = new System.Drawing.Size(144, 20);
            this.txtpICMSSTICMSPart.TabIndex = 54;
            // 
            // txtvICMSSTICMSPart
            // 
            this.txtvICMSSTICMSPart.Location = new System.Drawing.Point(9, 348);
            this.txtvICMSSTICMSPart.Name = "txtvICMSSTICMSPart";
            this.txtvICMSSTICMSPart.Size = new System.Drawing.Size(144, 20);
            this.txtvICMSSTICMSPart.TabIndex = 56;
            // 
            // txtvBCSTICMSPart
            // 
            this.txtvBCSTICMSPart.Location = new System.Drawing.Point(9, 296);
            this.txtvBCSTICMSPart.Name = "txtvBCSTICMSPart";
            this.txtvBCSTICMSPart.Size = new System.Drawing.Size(144, 20);
            this.txtvBCSTICMSPart.TabIndex = 52;
            // 
            // txtpMVASTICMSPart
            // 
            this.txtpMVASTICMSPart.Location = new System.Drawing.Point(9, 242);
            this.txtpMVASTICMSPart.Name = "txtpMVASTICMSPart";
            this.txtpMVASTICMSPart.Size = new System.Drawing.Size(144, 20);
            this.txtpMVASTICMSPart.TabIndex = 48;
            // 
            // lblValorICMSST
            // 
            this.lblValorICMSST.AutoSize = true;
            this.lblValorICMSST.Location = new System.Drawing.Point(6, 332);
            this.lblValorICMSST.Name = "lblValorICMSST";
            this.lblValorICMSST.Size = new System.Drawing.Size(92, 13);
            this.lblValorICMSST.TabIndex = 55;
            this.lblValorICMSST.Text = "Valor do ICMS ST";
            // 
            // lblValorVBICMSST
            // 
            this.lblValorVBICMSST.AutoSize = true;
            this.lblValorVBICMSST.Location = new System.Drawing.Point(6, 280);
            this.lblValorVBICMSST.Name = "lblValorVBICMSST";
            this.lblValorVBICMSST.Size = new System.Drawing.Size(109, 13);
            this.lblValorVBICMSST.TabIndex = 51;
            this.lblValorVBICMSST.Text = "Valor da BC ICMS ST";
            // 
            // lblPercRedBCICMSST
            // 
            this.lblPercRedBCICMSST.AutoSize = true;
            this.lblPercRedBCICMSST.Location = new System.Drawing.Point(185, 228);
            this.lblPercRedBCICMSST.Name = "lblPercRedBCICMSST";
            this.lblPercRedBCICMSST.Size = new System.Drawing.Size(168, 13);
            this.lblPercRedBCICMSST.TabIndex = 49;
            this.lblPercRedBCICMSST.Text = "Percentual Redução BC ICMS ST";
            // 
            // lblAliquotaICMSST
            // 
            this.lblAliquotaICMSST.AutoSize = true;
            this.lblAliquotaICMSST.Location = new System.Drawing.Point(185, 280);
            this.lblAliquotaICMSST.Name = "lblAliquotaICMSST";
            this.lblAliquotaICMSST.Size = new System.Drawing.Size(93, 13);
            this.lblAliquotaICMSST.TabIndex = 53;
            this.lblAliquotaICMSST.Text = "Alíquota ICMS ST";
            // 
            // lblPercICMSST
            // 
            this.lblPercICMSST.AutoSize = true;
            this.lblPercICMSST.Location = new System.Drawing.Point(6, 226);
            this.lblPercICMSST.Name = "lblPercICMSST";
            this.lblPercICMSST.Size = new System.Drawing.Size(159, 13);
            this.lblPercICMSST.TabIndex = 47;
            this.lblPercICMSST.Text = "Percentual da margem ICMS ST";
            // 
            // lblBCICMSST
            // 
            this.lblBCICMSST.AutoSize = true;
            this.lblBCICMSST.Location = new System.Drawing.Point(185, 174);
            this.lblBCICMSST.Name = "lblBCICMSST";
            this.lblBCICMSST.Size = new System.Drawing.Size(125, 13);
            this.lblBCICMSST.TabIndex = 45;
            this.lblBCICMSST.Text = "Modalidade BC ICMS ST";
            // 
            // lblModalidade
            // 
            this.lblModalidade.AutoSize = true;
            this.lblModalidade.Location = new System.Drawing.Point(6, 68);
            this.lblModalidade.Name = "lblModalidade";
            this.lblModalidade.Size = new System.Drawing.Size(62, 13);
            this.lblModalidade.TabIndex = 35;
            this.lblModalidade.Text = "Modalidade";
            // 
            // txtValorICMSPart
            // 
            this.txtValorICMSPart.Location = new System.Drawing.Point(9, 190);
            this.txtValorICMSPart.Name = "txtValorICMSPart";
            this.txtValorICMSPart.Size = new System.Drawing.Size(144, 20);
            this.txtValorICMSPart.TabIndex = 44;
            // 
            // txtAliquotaICMSPart
            // 
            this.txtAliquotaICMSPart.Location = new System.Drawing.Point(188, 137);
            this.txtAliquotaICMSPart.Name = "txtAliquotaICMSPart";
            this.txtAliquotaICMSPart.Size = new System.Drawing.Size(144, 20);
            this.txtAliquotaICMSPart.TabIndex = 42;
            // 
            // txtValorBCICMSPart
            // 
            this.txtValorBCICMSPart.Location = new System.Drawing.Point(188, 92);
            this.txtValorBCICMSPart.Name = "txtValorBCICMSPart";
            this.txtValorBCICMSPart.Size = new System.Drawing.Size(144, 20);
            this.txtValorBCICMSPart.TabIndex = 38;
            // 
            // txtCSTICMSPart
            // 
            this.txtCSTICMSPart.Location = new System.Drawing.Point(188, 32);
            this.txtCSTICMSPart.Name = "txtCSTICMSPart";
            this.txtCSTICMSPart.Size = new System.Drawing.Size(144, 20);
            this.txtCSTICMSPart.TabIndex = 34;
            // 
            // cboModalidadeICMSPart
            // 
            this.cboModalidadeICMSPart.FormattingEnabled = true;
            this.cboModalidadeICMSPart.Items.AddRange(new object[] {
            "Margem Valor Agregado",
            "Pauta",
            "Preço Tabelado Máximo",
            "Valor da Operação"});
            this.cboModalidadeICMSPart.Location = new System.Drawing.Point(9, 92);
            this.cboModalidadeICMSPart.Name = "cboModalidadeICMSPart";
            this.cboModalidadeICMSPart.Size = new System.Drawing.Size(144, 21);
            this.cboModalidadeICMSPart.TabIndex = 36;
            // 
            // cboOrigemICMSPart
            // 
            this.cboOrigemICMSPart.FormattingEnabled = true;
            this.cboOrigemICMSPart.Items.AddRange(new object[] {
            "Nacional",
            "Estrangeira-Importação Direta",
            "Estrangeira-Adquirida no mercado interno",
            "Nacional-Conteúdo de Importação 40%",
            "Nacional-Produção conforme processo produtivo",
            "Nacional-Conteúdo de Importação menor 40%",
            "Estrangeira-Importação Direta sem Similar Nacional (CAMEX)",
            "Estrangeira-Adquirida Mercado Interno sem SimilarNacional (CAMEX)"});
            this.cboOrigemICMSPart.Location = new System.Drawing.Point(9, 32);
            this.cboOrigemICMSPart.Name = "cboOrigemICMSPart";
            this.cboOrigemICMSPart.Size = new System.Drawing.Size(144, 21);
            this.cboOrigemICMSPart.TabIndex = 32;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(6, 174);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 43;
            this.lblValor.Text = "Valor";
            // 
            // lblAliquota
            // 
            this.lblAliquota.AutoSize = true;
            this.lblAliquota.Location = new System.Drawing.Point(185, 121);
            this.lblAliquota.Name = "lblAliquota";
            this.lblAliquota.Size = new System.Drawing.Size(47, 13);
            this.lblAliquota.TabIndex = 41;
            this.lblAliquota.Text = "Alíquota";
            // 
            // lblbcICMS
            // 
            this.lblbcICMS.AutoSize = true;
            this.lblbcICMS.Location = new System.Drawing.Point(185, 68);
            this.lblbcICMS.Name = "lblbcICMS";
            this.lblbcICMS.Size = new System.Drawing.Size(107, 13);
            this.lblbcICMS.TabIndex = 37;
            this.lblbcICMS.Text = "Valor da BC do ICMS";
            // 
            // lblTrbICMS
            // 
            this.lblTrbICMS.AutoSize = true;
            this.lblTrbICMS.Location = new System.Drawing.Point(185, 12);
            this.lblTrbICMS.Name = "lblTrbICMS";
            this.lblTrbICMS.Size = new System.Drawing.Size(102, 13);
            this.lblTrbICMS.TabIndex = 33;
            this.lblTrbICMS.Text = "Tributação do ICMS";
            // 
            // lblOrigem
            // 
            this.lblOrigem.AutoSize = true;
            this.lblOrigem.Location = new System.Drawing.Point(6, 16);
            this.lblOrigem.Name = "lblOrigem";
            this.lblOrigem.Size = new System.Drawing.Size(40, 13);
            this.lblOrigem.TabIndex = 31;
            this.lblOrigem.Text = "Origem";
            // 
            // FrmICMSPartilha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 428);
            this.Controls.Add(this.lblUFdICMSST);
            this.Controls.Add(this.lblPercBC);
            this.Controls.Add(this.txtUFSTICMSPart);
            this.Controls.Add(this.txtpBCOpICMSPart);
            this.Controls.Add(this.txtpRedBCICMSPart);
            this.Controls.Add(this.lblpRedBC);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.cboModSTICMSPart);
            this.Controls.Add(this.txtpRedBCSTICMSPart);
            this.Controls.Add(this.txtpICMSSTICMSPart);
            this.Controls.Add(this.txtvICMSSTICMSPart);
            this.Controls.Add(this.txtvBCSTICMSPart);
            this.Controls.Add(this.txtpMVASTICMSPart);
            this.Controls.Add(this.lblValorICMSST);
            this.Controls.Add(this.lblValorVBICMSST);
            this.Controls.Add(this.lblPercRedBCICMSST);
            this.Controls.Add(this.lblAliquotaICMSST);
            this.Controls.Add(this.lblPercICMSST);
            this.Controls.Add(this.lblBCICMSST);
            this.Controls.Add(this.lblModalidade);
            this.Controls.Add(this.txtValorICMSPart);
            this.Controls.Add(this.txtAliquotaICMSPart);
            this.Controls.Add(this.txtValorBCICMSPart);
            this.Controls.Add(this.txtCSTICMSPart);
            this.Controls.Add(this.cboModalidadeICMSPart);
            this.Controls.Add(this.cboOrigemICMSPart);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblAliquota);
            this.Controls.Add(this.lblbcICMS);
            this.Controls.Add(this.lblTrbICMS);
            this.Controls.Add(this.lblOrigem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmICMSPartilha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmICMSPartilha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUFdICMSST;
        private System.Windows.Forms.Label lblPercBC;
        public System.Windows.Forms.TextBox txtUFSTICMSPart;
        public System.Windows.Forms.TextBox txtpBCOpICMSPart;
        public System.Windows.Forms.TextBox txtpRedBCICMSPart;
        private System.Windows.Forms.Label lblpRedBC;
        private System.Windows.Forms.Button btnGravar;
        public System.Windows.Forms.ComboBox cboModSTICMSPart;
        public System.Windows.Forms.TextBox txtpRedBCSTICMSPart;
        public System.Windows.Forms.TextBox txtpICMSSTICMSPart;
        public System.Windows.Forms.TextBox txtvICMSSTICMSPart;
        public System.Windows.Forms.TextBox txtvBCSTICMSPart;
        public System.Windows.Forms.TextBox txtpMVASTICMSPart;
        private System.Windows.Forms.Label lblValorICMSST;
        private System.Windows.Forms.Label lblValorVBICMSST;
        private System.Windows.Forms.Label lblPercRedBCICMSST;
        private System.Windows.Forms.Label lblAliquotaICMSST;
        private System.Windows.Forms.Label lblPercICMSST;
        private System.Windows.Forms.Label lblBCICMSST;
        private System.Windows.Forms.Label lblModalidade;
        public System.Windows.Forms.TextBox txtValorICMSPart;
        public System.Windows.Forms.TextBox txtAliquotaICMSPart;
        public System.Windows.Forms.TextBox txtValorBCICMSPart;
        public System.Windows.Forms.TextBox txtCSTICMSPart;
        public System.Windows.Forms.ComboBox cboModalidadeICMSPart;
        public System.Windows.Forms.ComboBox cboOrigemICMSPart;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblAliquota;
        private System.Windows.Forms.Label lblbcICMS;
        private System.Windows.Forms.Label lblTrbICMS;
        private System.Windows.Forms.Label lblOrigem;
    }
}