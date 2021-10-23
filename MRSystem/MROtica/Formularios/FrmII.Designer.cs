namespace MROtica.Formularios
{
    partial class FrmII
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
            this.btnGravar = new System.Windows.Forms.Button();
            this.txtvDespAdu = new System.Windows.Forms.TextBox();
            this.txtvIOFII = new System.Windows.Forms.TextBox();
            this.txtvII = new System.Windows.Forms.TextBox();
            this.txtvBCII = new System.Windows.Forms.TextBox();
            this.lblValorImpFin = new System.Windows.Forms.Label();
            this.lblValorDesp = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblValorBC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(245, 130);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 17;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // txtvDespAdu
            // 
            this.txtvDespAdu.Location = new System.Drawing.Point(177, 32);
            this.txtvDespAdu.Name = "txtvDespAdu";
            this.txtvDespAdu.Size = new System.Drawing.Size(143, 20);
            this.txtvDespAdu.TabIndex = 16;
            // 
            // txtvIOFII
            // 
            this.txtvIOFII.Location = new System.Drawing.Point(177, 90);
            this.txtvIOFII.Name = "txtvIOFII";
            this.txtvIOFII.Size = new System.Drawing.Size(143, 20);
            this.txtvIOFII.TabIndex = 15;
            // 
            // txtvII
            // 
            this.txtvII.Location = new System.Drawing.Point(20, 90);
            this.txtvII.Name = "txtvII";
            this.txtvII.Size = new System.Drawing.Size(143, 20);
            this.txtvII.TabIndex = 14;
            // 
            // txtvBCII
            // 
            this.txtvBCII.Location = new System.Drawing.Point(20, 32);
            this.txtvBCII.Name = "txtvBCII";
            this.txtvBCII.Size = new System.Drawing.Size(143, 20);
            this.txtvBCII.TabIndex = 13;
            // 
            // lblValorImpFin
            // 
            this.lblValorImpFin.AutoSize = true;
            this.lblValorImpFin.Location = new System.Drawing.Point(174, 74);
            this.lblValorImpFin.Name = "lblValorImpFin";
            this.lblValorImpFin.Size = new System.Drawing.Size(150, 13);
            this.lblValorImpFin.TabIndex = 12;
            this.lblValorImpFin.Text = "Valor do Imposto sobre op. fin.";
            // 
            // lblValorDesp
            // 
            this.lblValorDesp.AutoSize = true;
            this.lblValorDesp.Location = new System.Drawing.Point(174, 16);
            this.lblValorDesp.Name = "lblValorDesp";
            this.lblValorDesp.Size = new System.Drawing.Size(135, 13);
            this.lblValorDesp.TabIndex = 11;
            this.lblValorDesp.Text = "Valor das desp. aduaneiras";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(17, 74);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 10;
            this.lblValor.Text = "Valor";
            // 
            // lblValorBC
            // 
            this.lblValorBC.AutoSize = true;
            this.lblValorBC.Location = new System.Drawing.Point(17, 16);
            this.lblValorBC.Name = "lblValorBC";
            this.lblValorBC.Size = new System.Drawing.Size(63, 13);
            this.lblValorBC.TabIndex = 9;
            this.lblValorBC.Text = "Valor da BC";
            // 
            // FrmII
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 168);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.txtvDespAdu);
            this.Controls.Add(this.txtvIOFII);
            this.Controls.Add(this.txtvII);
            this.Controls.Add(this.txtvBCII);
            this.Controls.Add(this.lblValorImpFin);
            this.Controls.Add(this.lblValorDesp);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblValorBC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmII";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmII";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGravar;
        public System.Windows.Forms.TextBox txtvDespAdu;
        public System.Windows.Forms.TextBox txtvIOFII;
        public System.Windows.Forms.TextBox txtvII;
        public System.Windows.Forms.TextBox txtvBCII;
        private System.Windows.Forms.Label lblValorImpFin;
        private System.Windows.Forms.Label lblValorDesp;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblValorBC;
    }
}