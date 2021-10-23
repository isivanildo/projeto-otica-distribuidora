namespace MROtica.Formularios
{
    partial class FrmCOFINSQuant
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
            this.lblValor = new System.Windows.Forms.Label();
            this.cboCSTCOFINSQtde = new System.Windows.Forms.ComboBox();
            this.lblCodSitTrib = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.txtvCOFINSQtde = new System.Windows.Forms.TextBox();
            this.txtvAliqProdCOFINSQtde = new System.Windows.Forms.TextBox();
            this.txtqBCProdCOFINSQtde = new System.Windows.Forms.TextBox();
            this.lblAliquota = new System.Windows.Forms.Label();
            this.lblQuantVen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(184, 62);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 57;
            this.lblValor.Text = "Valor";
            // 
            // cboCSTCOFINSQtde
            // 
            this.cboCSTCOFINSQtde.FormattingEnabled = true;
            this.cboCSTCOFINSQtde.Items.AddRange(new object[] {
            "Operação Tributável=quantidade vendida x alíquota por unidade de produto"});
            this.cboCSTCOFINSQtde.Location = new System.Drawing.Point(14, 30);
            this.cboCSTCOFINSQtde.Name = "cboCSTCOFINSQtde";
            this.cboCSTCOFINSQtde.Size = new System.Drawing.Size(149, 21);
            this.cboCSTCOFINSQtde.TabIndex = 56;
            // 
            // lblCodSitTrib
            // 
            this.lblCodSitTrib.AutoSize = true;
            this.lblCodSitTrib.Location = new System.Drawing.Point(14, 14);
            this.lblCodSitTrib.Name = "lblCodSitTrib";
            this.lblCodSitTrib.Size = new System.Drawing.Size(91, 13);
            this.lblCodSitTrib.TabIndex = 55;
            this.lblCodSitTrib.Text = "Cód. Sit Tributária";
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(261, 113);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 54;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // txtvCOFINSQtde
            // 
            this.txtvCOFINSQtde.Location = new System.Drawing.Point(187, 78);
            this.txtvCOFINSQtde.Name = "txtvCOFINSQtde";
            this.txtvCOFINSQtde.Size = new System.Drawing.Size(149, 20);
            this.txtvCOFINSQtde.TabIndex = 53;
            // 
            // txtvAliqProdCOFINSQtde
            // 
            this.txtvAliqProdCOFINSQtde.Location = new System.Drawing.Point(14, 78);
            this.txtvAliqProdCOFINSQtde.Name = "txtvAliqProdCOFINSQtde";
            this.txtvAliqProdCOFINSQtde.Size = new System.Drawing.Size(149, 20);
            this.txtvAliqProdCOFINSQtde.TabIndex = 52;
            // 
            // txtqBCProdCOFINSQtde
            // 
            this.txtqBCProdCOFINSQtde.Location = new System.Drawing.Point(187, 29);
            this.txtqBCProdCOFINSQtde.Name = "txtqBCProdCOFINSQtde";
            this.txtqBCProdCOFINSQtde.Size = new System.Drawing.Size(149, 20);
            this.txtqBCProdCOFINSQtde.TabIndex = 51;
            // 
            // lblAliquota
            // 
            this.lblAliquota.AutoSize = true;
            this.lblAliquota.Location = new System.Drawing.Point(11, 62);
            this.lblAliquota.Name = "lblAliquota";
            this.lblAliquota.Size = new System.Drawing.Size(78, 13);
            this.lblAliquota.TabIndex = 50;
            this.lblAliquota.Text = "Alíquota (reais)";
            // 
            // lblQuantVen
            // 
            this.lblQuantVen.AutoSize = true;
            this.lblQuantVen.Location = new System.Drawing.Point(184, 13);
            this.lblQuantVen.Name = "lblQuantVen";
            this.lblQuantVen.Size = new System.Drawing.Size(104, 13);
            this.lblQuantVen.TabIndex = 49;
            this.lblQuantVen.Text = "Quantidade Vendida";
            // 
            // FrmCOFINSQuant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 149);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.cboCSTCOFINSQtde);
            this.Controls.Add(this.lblCodSitTrib);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.txtvCOFINSQtde);
            this.Controls.Add(this.txtvAliqProdCOFINSQtde);
            this.Controls.Add(this.txtqBCProdCOFINSQtde);
            this.Controls.Add(this.lblAliquota);
            this.Controls.Add(this.lblQuantVen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmCOFINSQuant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCOFINSQuant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValor;
        public System.Windows.Forms.ComboBox cboCSTCOFINSQtde;
        private System.Windows.Forms.Label lblCodSitTrib;
        private System.Windows.Forms.Button btnGravar;
        public System.Windows.Forms.TextBox txtvCOFINSQtde;
        public System.Windows.Forms.TextBox txtvAliqProdCOFINSQtde;
        public System.Windows.Forms.TextBox txtqBCProdCOFINSQtde;
        private System.Windows.Forms.Label lblAliquota;
        private System.Windows.Forms.Label lblQuantVen;
    }
}