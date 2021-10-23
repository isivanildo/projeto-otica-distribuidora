namespace MROtica.Formularios
{
    partial class FrmPISAliquota
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
            this.cboCSTPISAliq = new System.Windows.Forms.ComboBox();
            this.lblCodSitTrib = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.txtvPISPISAliq = new System.Windows.Forms.TextBox();
            this.txtpPISPISAliq = new System.Windows.Forms.TextBox();
            this.txtvBCPISAliq = new System.Windows.Forms.TextBox();
            this.lblAliquota = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblVBasCalc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboCSTPISAliq
            // 
            this.cboCSTPISAliq.FormattingEnabled = true;
            this.cboCSTPISAliq.Items.AddRange(new object[] {
            "Operação Tributável=alíquota normal",
            "Operação tributável=alíquota diferenciada"});
            this.cboCSTPISAliq.Location = new System.Drawing.Point(15, 26);
            this.cboCSTPISAliq.Name = "cboCSTPISAliq";
            this.cboCSTPISAliq.Size = new System.Drawing.Size(149, 21);
            this.cboCSTPISAliq.TabIndex = 30;
            // 
            // lblCodSitTrib
            // 
            this.lblCodSitTrib.AutoSize = true;
            this.lblCodSitTrib.Location = new System.Drawing.Point(15, 10);
            this.lblCodSitTrib.Name = "lblCodSitTrib";
            this.lblCodSitTrib.Size = new System.Drawing.Size(91, 13);
            this.lblCodSitTrib.TabIndex = 29;
            this.lblCodSitTrib.Text = "Cód. Sit Tributária";
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(262, 109);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 28;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // txtvPISPISAliq
            // 
            this.txtvPISPISAliq.Location = new System.Drawing.Point(188, 74);
            this.txtvPISPISAliq.Name = "txtvPISPISAliq";
            this.txtvPISPISAliq.Size = new System.Drawing.Size(149, 20);
            this.txtvPISPISAliq.TabIndex = 27;
            // 
            // txtpPISPISAliq
            // 
            this.txtpPISPISAliq.Location = new System.Drawing.Point(15, 74);
            this.txtpPISPISAliq.Name = "txtpPISPISAliq";
            this.txtpPISPISAliq.Size = new System.Drawing.Size(149, 20);
            this.txtpPISPISAliq.TabIndex = 26;
            // 
            // txtvBCPISAliq
            // 
            this.txtvBCPISAliq.Location = new System.Drawing.Point(188, 25);
            this.txtvBCPISAliq.Name = "txtvBCPISAliq";
            this.txtvBCPISAliq.Size = new System.Drawing.Size(149, 20);
            this.txtvBCPISAliq.TabIndex = 25;
            // 
            // lblAliquota
            // 
            this.lblAliquota.AutoSize = true;
            this.lblAliquota.Location = new System.Drawing.Point(12, 58);
            this.lblAliquota.Name = "lblAliquota";
            this.lblAliquota.Size = new System.Drawing.Size(47, 13);
            this.lblAliquota.TabIndex = 24;
            this.lblAliquota.Text = "Alíquota";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(185, 58);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 23;
            this.lblValor.Text = "Valor";
            // 
            // lblVBasCalc
            // 
            this.lblVBasCalc.AutoSize = true;
            this.lblVBasCalc.Location = new System.Drawing.Point(185, 9);
            this.lblVBasCalc.Name = "lblVBasCalc";
            this.lblVBasCalc.Size = new System.Drawing.Size(126, 13);
            this.lblVBasCalc.TabIndex = 22;
            this.lblVBasCalc.Text = "Valor da Base de Cálculo";
            // 
            // FrmPISAliquota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 141);
            this.Controls.Add(this.cboCSTPISAliq);
            this.Controls.Add(this.lblCodSitTrib);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.txtvPISPISAliq);
            this.Controls.Add(this.txtpPISPISAliq);
            this.Controls.Add(this.txtvBCPISAliq);
            this.Controls.Add(this.lblAliquota);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblVBasCalc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmPISAliquota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPISAliquota";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cboCSTPISAliq;
        private System.Windows.Forms.Label lblCodSitTrib;
        private System.Windows.Forms.Button btnGravar;
        public System.Windows.Forms.TextBox txtvPISPISAliq;
        public System.Windows.Forms.TextBox txtpPISPISAliq;
        public System.Windows.Forms.TextBox txtvBCPISAliq;
        private System.Windows.Forms.Label lblAliquota;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblVBasCalc;
    }
}