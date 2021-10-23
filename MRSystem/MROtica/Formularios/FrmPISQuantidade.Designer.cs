﻿namespace MROtica.Formularios
{
    partial class FrmPISQuantidade
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
            this.cboCSTPISQtde = new System.Windows.Forms.ComboBox();
            this.lblCodSitTrib = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.txtvPISPISQtde = new System.Windows.Forms.TextBox();
            this.txtvAliqProdPISQtde = new System.Windows.Forms.TextBox();
            this.txtqBCProdPISQtde = new System.Windows.Forms.TextBox();
            this.lblAliquota = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblQuantVen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboCSTPISQtde
            // 
            this.cboCSTPISQtde.FormattingEnabled = true;
            this.cboCSTPISQtde.Items.AddRange(new object[] {
            "Operação Tributável=qtde vendida x alíquota por unidade de produto"});
            this.cboCSTPISQtde.Location = new System.Drawing.Point(9, 24);
            this.cboCSTPISQtde.Name = "cboCSTPISQtde";
            this.cboCSTPISQtde.Size = new System.Drawing.Size(149, 21);
            this.cboCSTPISQtde.TabIndex = 39;
            // 
            // lblCodSitTrib
            // 
            this.lblCodSitTrib.AutoSize = true;
            this.lblCodSitTrib.Location = new System.Drawing.Point(9, 8);
            this.lblCodSitTrib.Name = "lblCodSitTrib";
            this.lblCodSitTrib.Size = new System.Drawing.Size(91, 13);
            this.lblCodSitTrib.TabIndex = 38;
            this.lblCodSitTrib.Text = "Cód. Sit Tributária";
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(256, 107);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 37;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // txtvPISPISQtde
            // 
            this.txtvPISPISQtde.Location = new System.Drawing.Point(182, 72);
            this.txtvPISPISQtde.Name = "txtvPISPISQtde";
            this.txtvPISPISQtde.Size = new System.Drawing.Size(149, 20);
            this.txtvPISPISQtde.TabIndex = 36;
            // 
            // txtvAliqProdPISQtde
            // 
            this.txtvAliqProdPISQtde.Location = new System.Drawing.Point(9, 72);
            this.txtvAliqProdPISQtde.Name = "txtvAliqProdPISQtde";
            this.txtvAliqProdPISQtde.Size = new System.Drawing.Size(149, 20);
            this.txtvAliqProdPISQtde.TabIndex = 35;
            // 
            // txtqBCProdPISQtde
            // 
            this.txtqBCProdPISQtde.Location = new System.Drawing.Point(182, 23);
            this.txtqBCProdPISQtde.Name = "txtqBCProdPISQtde";
            this.txtqBCProdPISQtde.Size = new System.Drawing.Size(149, 20);
            this.txtqBCProdPISQtde.TabIndex = 34;
            // 
            // lblAliquota
            // 
            this.lblAliquota.AutoSize = true;
            this.lblAliquota.Location = new System.Drawing.Point(6, 56);
            this.lblAliquota.Name = "lblAliquota";
            this.lblAliquota.Size = new System.Drawing.Size(83, 13);
            this.lblAliquota.TabIndex = 33;
            this.lblAliquota.Text = "Alíquota (Reais)";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(179, 56);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 32;
            this.lblValor.Text = "Valor";
            // 
            // lblQuantVen
            // 
            this.lblQuantVen.AutoSize = true;
            this.lblQuantVen.Location = new System.Drawing.Point(179, 7);
            this.lblQuantVen.Name = "lblQuantVen";
            this.lblQuantVen.Size = new System.Drawing.Size(104, 13);
            this.lblQuantVen.TabIndex = 31;
            this.lblQuantVen.Text = "Quantidade Vendida";
            // 
            // FrmPISQuantidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 137);
            this.Controls.Add(this.cboCSTPISQtde);
            this.Controls.Add(this.lblCodSitTrib);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.txtvPISPISQtde);
            this.Controls.Add(this.txtvAliqProdPISQtde);
            this.Controls.Add(this.txtqBCProdPISQtde);
            this.Controls.Add(this.lblAliquota);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblQuantVen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmPISQuantidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPISQuantidade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCSTPISQtde;
        private System.Windows.Forms.Label lblCodSitTrib;
        private System.Windows.Forms.Button btnGravar;
        public System.Windows.Forms.TextBox txtvPISPISQtde;
        public System.Windows.Forms.TextBox txtvAliqProdPISQtde;
        public System.Windows.Forms.TextBox txtqBCProdPISQtde;
        private System.Windows.Forms.Label lblAliquota;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblQuantVen;
    }
}