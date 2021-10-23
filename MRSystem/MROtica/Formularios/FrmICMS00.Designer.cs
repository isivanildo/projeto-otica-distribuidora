namespace MROtica.Formularios
{
    partial class FrmICMS00
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
            this.txtpFCP00 = new System.Windows.Forms.TextBox();
            this.lblpFCP00 = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.txtAliquotaICMS00 = new System.Windows.Forms.TextBox();
            this.txtCSTICMS00 = new System.Windows.Forms.TextBox();
            this.cboModalidadeICMS00 = new System.Windows.Forms.ComboBox();
            this.cboOrigemICMS00 = new System.Windows.Forms.ComboBox();
            this.lblAliquota = new System.Windows.Forms.Label();
            this.lblModalidade = new System.Windows.Forms.Label();
            this.lblTrbICMS = new System.Windows.Forms.Label();
            this.lblOrigem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtpFCP00
            // 
            this.txtpFCP00.Location = new System.Drawing.Point(202, 81);
            this.txtpFCP00.Name = "txtpFCP00";
            this.txtpFCP00.Size = new System.Drawing.Size(153, 20);
            this.txtpFCP00.TabIndex = 30;
            // 
            // lblpFCP00
            // 
            this.lblpFCP00.AutoSize = true;
            this.lblpFCP00.Location = new System.Drawing.Point(199, 64);
            this.lblpFCP00.Name = "lblpFCP00";
            this.lblpFCP00.Size = new System.Drawing.Size(81, 13);
            this.lblpFCP00.TabIndex = 29;
            this.lblpFCP00.Text = "Percentual FCP";
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(280, 196);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 33;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // txtAliquotaICMS00
            // 
            this.txtAliquotaICMS00.Location = new System.Drawing.Point(23, 120);
            this.txtAliquotaICMS00.Name = "txtAliquotaICMS00";
            this.txtAliquotaICMS00.Size = new System.Drawing.Size(153, 20);
            this.txtAliquotaICMS00.TabIndex = 26;
            // 
            // txtCSTICMS00
            // 
            this.txtCSTICMS00.Location = new System.Drawing.Point(211, 38);
            this.txtCSTICMS00.Name = "txtCSTICMS00";
            this.txtCSTICMS00.Size = new System.Drawing.Size(144, 20);
            this.txtCSTICMS00.TabIndex = 20;
            // 
            // cboModalidadeICMS00
            // 
            this.cboModalidadeICMS00.FormattingEnabled = true;
            this.cboModalidadeICMS00.Items.AddRange(new object[] {
            "Margem Valor Agregado",
            "Pauta",
            "Preço Tabelado Máximo",
            "Valor da Operação"});
            this.cboModalidadeICMS00.Location = new System.Drawing.Point(23, 80);
            this.cboModalidadeICMS00.Name = "cboModalidadeICMS00";
            this.cboModalidadeICMS00.Size = new System.Drawing.Size(153, 21);
            this.cboModalidadeICMS00.TabIndex = 22;
            // 
            // cboOrigemICMS00
            // 
            this.cboOrigemICMS00.FormattingEnabled = true;
            this.cboOrigemICMS00.Items.AddRange(new object[] {
            "Nacional",
            "Estrangeira-Importação Direta",
            "Estrangeira-Adquirida no mercado interno",
            "Nacional-Conteúdo de Importação 40%",
            "Nacional-Produção conforme processo produtivo",
            "Nacional-Conteúdo de Importação menor 40%",
            "Estrangeira-Importação Direta sem Similar Nacional (CAMEX)",
            "Estrangeira-Adquirida Mercado Interno sem SimilarNacional (CAMEX)"});
            this.cboOrigemICMS00.Location = new System.Drawing.Point(23, 38);
            this.cboOrigemICMS00.Name = "cboOrigemICMS00";
            this.cboOrigemICMS00.Size = new System.Drawing.Size(153, 21);
            this.cboOrigemICMS00.TabIndex = 18;
            // 
            // lblAliquota
            // 
            this.lblAliquota.AutoSize = true;
            this.lblAliquota.Location = new System.Drawing.Point(20, 104);
            this.lblAliquota.Name = "lblAliquota";
            this.lblAliquota.Size = new System.Drawing.Size(76, 13);
            this.lblAliquota.TabIndex = 25;
            this.lblAliquota.Text = "Alíquota ICMS";
            // 
            // lblModalidade
            // 
            this.lblModalidade.AutoSize = true;
            this.lblModalidade.Location = new System.Drawing.Point(20, 61);
            this.lblModalidade.Name = "lblModalidade";
            this.lblModalidade.Size = new System.Drawing.Size(62, 13);
            this.lblModalidade.TabIndex = 21;
            this.lblModalidade.Text = "Modalidade";
            // 
            // lblTrbICMS
            // 
            this.lblTrbICMS.AutoSize = true;
            this.lblTrbICMS.Location = new System.Drawing.Point(208, 22);
            this.lblTrbICMS.Name = "lblTrbICMS";
            this.lblTrbICMS.Size = new System.Drawing.Size(102, 13);
            this.lblTrbICMS.TabIndex = 19;
            this.lblTrbICMS.Text = "Tributação do ICMS";
            // 
            // lblOrigem
            // 
            this.lblOrigem.AutoSize = true;
            this.lblOrigem.Location = new System.Drawing.Point(20, 18);
            this.lblOrigem.Name = "lblOrigem";
            this.lblOrigem.Size = new System.Drawing.Size(40, 13);
            this.lblOrigem.TabIndex = 17;
            this.lblOrigem.Text = "Origem";
            // 
            // FrmICMS00
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 236);
            this.Controls.Add(this.txtpFCP00);
            this.Controls.Add(this.lblpFCP00);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.txtAliquotaICMS00);
            this.Controls.Add(this.txtCSTICMS00);
            this.Controls.Add(this.cboModalidadeICMS00);
            this.Controls.Add(this.cboOrigemICMS00);
            this.Controls.Add(this.lblAliquota);
            this.Controls.Add(this.lblModalidade);
            this.Controls.Add(this.lblTrbICMS);
            this.Controls.Add(this.lblOrigem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmICMS00";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmICMS00";
            this.Load += new System.EventHandler(this.FrmICMS00_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txtpFCP00;
        private System.Windows.Forms.Label lblpFCP00;
        private System.Windows.Forms.Button btnGravar;
        public System.Windows.Forms.TextBox txtAliquotaICMS00;
        public System.Windows.Forms.TextBox txtCSTICMS00;
        public System.Windows.Forms.ComboBox cboModalidadeICMS00;
        public System.Windows.Forms.ComboBox cboOrigemICMS00;
        private System.Windows.Forms.Label lblAliquota;
        private System.Windows.Forms.Label lblModalidade;
        private System.Windows.Forms.Label lblTrbICMS;
        private System.Windows.Forms.Label lblOrigem;
    }
}