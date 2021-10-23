namespace MROtica.Formularios
{
    partial class FrmPISOtros
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
            this.gbCalculo = new System.Windows.Forms.GroupBox();
            this.rbValor = new System.Windows.Forms.RadioButton();
            this.rbPercentual = new System.Windows.Forms.RadioButton();
            this.btnGravar = new System.Windows.Forms.Button();
            this.txtvAliqProdPISOutr = new System.Windows.Forms.TextBox();
            this.txtqBCProdPISOutr = new System.Windows.Forms.TextBox();
            this.txtpPISPISOutr = new System.Windows.Forms.TextBox();
            this.txtvBCPISOutr = new System.Windows.Forms.TextBox();
            this.txtvPISOutr = new System.Windows.Forms.TextBox();
            this.cboCSTPISOutr = new System.Windows.Forms.ComboBox();
            this.lblAliReais = new System.Windows.Forms.Label();
            this.lblqtdeVendida = new System.Windows.Forms.Label();
            this.lblBaseCalc = new System.Windows.Forms.Label();
            this.lblAliPer = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblCodSitTrib = new System.Windows.Forms.Label();
            this.gbCalculo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCalculo
            // 
            this.gbCalculo.Controls.Add(this.rbValor);
            this.gbCalculo.Controls.Add(this.rbPercentual);
            this.gbCalculo.Location = new System.Drawing.Point(17, 12);
            this.gbCalculo.Name = "gbCalculo";
            this.gbCalculo.Size = new System.Drawing.Size(328, 51);
            this.gbCalculo.TabIndex = 14;
            this.gbCalculo.TabStop = false;
            this.gbCalculo.Text = "Cálculo do PIS";
            // 
            // rbValor
            // 
            this.rbValor.AutoSize = true;
            this.rbValor.Location = new System.Drawing.Point(197, 19);
            this.rbValor.Name = "rbValor";
            this.rbValor.Size = new System.Drawing.Size(49, 17);
            this.rbValor.TabIndex = 1;
            this.rbValor.Text = "Valor";
            this.rbValor.UseVisualStyleBackColor = true;
            // 
            // rbPercentual
            // 
            this.rbPercentual.AutoSize = true;
            this.rbPercentual.Checked = true;
            this.rbPercentual.Location = new System.Drawing.Point(16, 19);
            this.rbPercentual.Name = "rbPercentual";
            this.rbPercentual.Size = new System.Drawing.Size(76, 17);
            this.rbPercentual.TabIndex = 0;
            this.rbPercentual.TabStop = true;
            this.rbPercentual.Text = "Percentual";
            this.rbPercentual.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(264, 234);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(81, 24);
            this.btnGravar.TabIndex = 27;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // txtvAliqProdPISOutr
            // 
            this.txtvAliqProdPISOutr.Enabled = false;
            this.txtvAliqProdPISOutr.Location = new System.Drawing.Point(214, 199);
            this.txtvAliqProdPISOutr.Name = "txtvAliqProdPISOutr";
            this.txtvAliqProdPISOutr.Size = new System.Drawing.Size(131, 20);
            this.txtvAliqProdPISOutr.TabIndex = 26;
            // 
            // txtqBCProdPISOutr
            // 
            this.txtqBCProdPISOutr.Enabled = false;
            this.txtqBCProdPISOutr.Location = new System.Drawing.Point(17, 199);
            this.txtqBCProdPISOutr.Name = "txtqBCProdPISOutr";
            this.txtqBCProdPISOutr.Size = new System.Drawing.Size(163, 20);
            this.txtqBCProdPISOutr.TabIndex = 25;
            // 
            // txtpPISPISOutr
            // 
            this.txtpPISPISOutr.Location = new System.Drawing.Point(214, 149);
            this.txtpPISPISOutr.Name = "txtpPISPISOutr";
            this.txtpPISPISOutr.Size = new System.Drawing.Size(131, 20);
            this.txtpPISPISOutr.TabIndex = 24;
            // 
            // txtvBCPISOutr
            // 
            this.txtvBCPISOutr.Location = new System.Drawing.Point(17, 149);
            this.txtvBCPISOutr.Name = "txtvBCPISOutr";
            this.txtvBCPISOutr.Size = new System.Drawing.Size(163, 20);
            this.txtvBCPISOutr.TabIndex = 23;
            // 
            // txtvPISOutr
            // 
            this.txtvPISOutr.Location = new System.Drawing.Point(214, 100);
            this.txtvPISOutr.Name = "txtvPISOutr";
            this.txtvPISOutr.Size = new System.Drawing.Size(131, 20);
            this.txtvPISOutr.TabIndex = 22;
            // 
            // cboCSTPISOutr
            // 
            this.cboCSTPISOutr.FormattingEnabled = true;
            this.cboCSTPISOutr.Items.AddRange(new object[] {
            "Outras Operações"});
            this.cboCSTPISOutr.Location = new System.Drawing.Point(19, 100);
            this.cboCSTPISOutr.Name = "cboCSTPISOutr";
            this.cboCSTPISOutr.Size = new System.Drawing.Size(161, 21);
            this.cboCSTPISOutr.TabIndex = 21;
            // 
            // lblAliReais
            // 
            this.lblAliReais.AutoSize = true;
            this.lblAliReais.Location = new System.Drawing.Point(211, 183);
            this.lblAliReais.Name = "lblAliReais";
            this.lblAliReais.Size = new System.Drawing.Size(83, 13);
            this.lblAliReais.TabIndex = 20;
            this.lblAliReais.Text = "Alíquota (Reais)";
            // 
            // lblqtdeVendida
            // 
            this.lblqtdeVendida.AutoSize = true;
            this.lblqtdeVendida.Location = new System.Drawing.Point(17, 183);
            this.lblqtdeVendida.Name = "lblqtdeVendida";
            this.lblqtdeVendida.Size = new System.Drawing.Size(104, 13);
            this.lblqtdeVendida.TabIndex = 19;
            this.lblqtdeVendida.Text = "Quantidade Vendida";
            // 
            // lblBaseCalc
            // 
            this.lblBaseCalc.AutoSize = true;
            this.lblBaseCalc.Location = new System.Drawing.Point(17, 133);
            this.lblBaseCalc.Name = "lblBaseCalc";
            this.lblBaseCalc.Size = new System.Drawing.Size(111, 13);
            this.lblBaseCalc.TabIndex = 18;
            this.lblBaseCalc.Text = "Valor Base de Cálculo";
            // 
            // lblAliPer
            // 
            this.lblAliPer.AutoSize = true;
            this.lblAliPer.Location = new System.Drawing.Point(211, 133);
            this.lblAliPer.Name = "lblAliPer";
            this.lblAliPer.Size = new System.Drawing.Size(107, 13);
            this.lblAliPer.TabIndex = 17;
            this.lblAliPer.Text = "Alíquota (Percentual)";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(211, 84);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 16;
            this.lblValor.Text = "Valor";
            // 
            // lblCodSitTrib
            // 
            this.lblCodSitTrib.AutoSize = true;
            this.lblCodSitTrib.Location = new System.Drawing.Point(17, 84);
            this.lblCodSitTrib.Name = "lblCodSitTrib";
            this.lblCodSitTrib.Size = new System.Drawing.Size(94, 13);
            this.lblCodSitTrib.TabIndex = 15;
            this.lblCodSitTrib.Text = "Cód. Sit. Tributária";
            // 
            // FrmPISOtros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 270);
            this.Controls.Add(this.gbCalculo);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.txtvAliqProdPISOutr);
            this.Controls.Add(this.txtqBCProdPISOutr);
            this.Controls.Add(this.txtpPISPISOutr);
            this.Controls.Add(this.txtvBCPISOutr);
            this.Controls.Add(this.txtvPISOutr);
            this.Controls.Add(this.cboCSTPISOutr);
            this.Controls.Add(this.lblAliReais);
            this.Controls.Add(this.lblqtdeVendida);
            this.Controls.Add(this.lblBaseCalc);
            this.Controls.Add(this.lblAliPer);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblCodSitTrib);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmPISOtros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPISOtros";
            this.gbCalculo.ResumeLayout(false);
            this.gbCalculo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCalculo;
        public System.Windows.Forms.RadioButton rbValor;
        public System.Windows.Forms.RadioButton rbPercentual;
        private System.Windows.Forms.Button btnGravar;
        public System.Windows.Forms.TextBox txtvAliqProdPISOutr;
        public System.Windows.Forms.TextBox txtqBCProdPISOutr;
        public System.Windows.Forms.TextBox txtpPISPISOutr;
        public System.Windows.Forms.TextBox txtvBCPISOutr;
        public System.Windows.Forms.TextBox txtvPISOutr;
        public System.Windows.Forms.ComboBox cboCSTPISOutr;
        private System.Windows.Forms.Label lblAliReais;
        private System.Windows.Forms.Label lblqtdeVendida;
        private System.Windows.Forms.Label lblBaseCalc;
        private System.Windows.Forms.Label lblAliPer;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblCodSitTrib;
    }
}