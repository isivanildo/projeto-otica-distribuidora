namespace MROtica.Formularios
{
    partial class FrmCOFINSST
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
            this.txtvAliqProdCOFINSST = new System.Windows.Forms.TextBox();
            this.txtqBCProdCOFINSST = new System.Windows.Forms.TextBox();
            this.txtpCOFINSST = new System.Windows.Forms.TextBox();
            this.txtvCOFINSST = new System.Windows.Forms.TextBox();
            this.rbPercentual = new System.Windows.Forms.RadioButton();
            this.txtvBCCOFINSST = new System.Windows.Forms.TextBox();
            this.lblAliReais = new System.Windows.Forms.Label();
            this.lblqtdeVendida = new System.Windows.Forms.Label();
            this.lblBaseCalc = new System.Windows.Forms.Label();
            this.lblAliPer = new System.Windows.Forms.Label();
            this.rbValor = new System.Windows.Forms.RadioButton();
            this.lblValor = new System.Windows.Forms.Label();
            this.gbCalculo = new System.Windows.Forms.GroupBox();
            this.gbCalculo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(259, 172);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(81, 24);
            this.btnGravar.TabIndex = 51;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // txtvAliqProdCOFINSST
            // 
            this.txtvAliqProdCOFINSST.Enabled = false;
            this.txtvAliqProdCOFINSST.Location = new System.Drawing.Point(193, 133);
            this.txtvAliqProdCOFINSST.Name = "txtvAliqProdCOFINSST";
            this.txtvAliqProdCOFINSST.Size = new System.Drawing.Size(147, 20);
            this.txtvAliqProdCOFINSST.TabIndex = 50;
            // 
            // txtqBCProdCOFINSST
            // 
            this.txtqBCProdCOFINSST.Enabled = false;
            this.txtqBCProdCOFINSST.Location = new System.Drawing.Point(12, 133);
            this.txtqBCProdCOFINSST.Name = "txtqBCProdCOFINSST";
            this.txtqBCProdCOFINSST.Size = new System.Drawing.Size(163, 20);
            this.txtqBCProdCOFINSST.TabIndex = 49;
            // 
            // txtpCOFINSST
            // 
            this.txtpCOFINSST.Location = new System.Drawing.Point(193, 87);
            this.txtpCOFINSST.Name = "txtpCOFINSST";
            this.txtpCOFINSST.Size = new System.Drawing.Size(147, 20);
            this.txtpCOFINSST.TabIndex = 48;
            // 
            // txtvCOFINSST
            // 
            this.txtvCOFINSST.Location = new System.Drawing.Point(12, 176);
            this.txtvCOFINSST.Name = "txtvCOFINSST";
            this.txtvCOFINSST.Size = new System.Drawing.Size(163, 20);
            this.txtvCOFINSST.TabIndex = 46;
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
            // txtvBCCOFINSST
            // 
            this.txtvBCCOFINSST.Location = new System.Drawing.Point(12, 87);
            this.txtvBCCOFINSST.Name = "txtvBCCOFINSST";
            this.txtvBCCOFINSST.Size = new System.Drawing.Size(163, 20);
            this.txtvBCCOFINSST.TabIndex = 47;
            // 
            // lblAliReais
            // 
            this.lblAliReais.AutoSize = true;
            this.lblAliReais.Location = new System.Drawing.Point(190, 117);
            this.lblAliReais.Name = "lblAliReais";
            this.lblAliReais.Size = new System.Drawing.Size(83, 13);
            this.lblAliReais.TabIndex = 45;
            this.lblAliReais.Text = "Alíquota (Reais)";
            // 
            // lblqtdeVendida
            // 
            this.lblqtdeVendida.AutoSize = true;
            this.lblqtdeVendida.Location = new System.Drawing.Point(12, 117);
            this.lblqtdeVendida.Name = "lblqtdeVendida";
            this.lblqtdeVendida.Size = new System.Drawing.Size(104, 13);
            this.lblqtdeVendida.TabIndex = 44;
            this.lblqtdeVendida.Text = "Quantidade Vendida";
            // 
            // lblBaseCalc
            // 
            this.lblBaseCalc.AutoSize = true;
            this.lblBaseCalc.Location = new System.Drawing.Point(12, 71);
            this.lblBaseCalc.Name = "lblBaseCalc";
            this.lblBaseCalc.Size = new System.Drawing.Size(111, 13);
            this.lblBaseCalc.TabIndex = 43;
            this.lblBaseCalc.Text = "Valor Base de Cálculo";
            // 
            // lblAliPer
            // 
            this.lblAliPer.AutoSize = true;
            this.lblAliPer.Location = new System.Drawing.Point(190, 71);
            this.lblAliPer.Name = "lblAliPer";
            this.lblAliPer.Size = new System.Drawing.Size(107, 13);
            this.lblAliPer.TabIndex = 42;
            this.lblAliPer.Text = "Alíquota (Percentual)";
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
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(9, 160);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 41;
            this.lblValor.Text = "Valor";
            // 
            // gbCalculo
            // 
            this.gbCalculo.Controls.Add(this.rbValor);
            this.gbCalculo.Controls.Add(this.rbPercentual);
            this.gbCalculo.Location = new System.Drawing.Point(12, 14);
            this.gbCalculo.Name = "gbCalculo";
            this.gbCalculo.Size = new System.Drawing.Size(328, 51);
            this.gbCalculo.TabIndex = 40;
            this.gbCalculo.TabStop = false;
            this.gbCalculo.Text = "Cálculo da COFINS ST";
            // 
            // FrmCOFINSST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 210);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.txtvAliqProdCOFINSST);
            this.Controls.Add(this.txtqBCProdCOFINSST);
            this.Controls.Add(this.txtpCOFINSST);
            this.Controls.Add(this.txtvCOFINSST);
            this.Controls.Add(this.txtvBCCOFINSST);
            this.Controls.Add(this.lblAliReais);
            this.Controls.Add(this.lblqtdeVendida);
            this.Controls.Add(this.lblBaseCalc);
            this.Controls.Add(this.lblAliPer);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.gbCalculo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmCOFINSST";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCOFINSST";
            this.gbCalculo.ResumeLayout(false);
            this.gbCalculo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGravar;
        public System.Windows.Forms.TextBox txtvAliqProdCOFINSST;
        public System.Windows.Forms.TextBox txtqBCProdCOFINSST;
        public System.Windows.Forms.TextBox txtpCOFINSST;
        public System.Windows.Forms.TextBox txtvCOFINSST;
        public System.Windows.Forms.RadioButton rbPercentual;
        public System.Windows.Forms.TextBox txtvBCCOFINSST;
        private System.Windows.Forms.Label lblAliReais;
        private System.Windows.Forms.Label lblqtdeVendida;
        private System.Windows.Forms.Label lblBaseCalc;
        private System.Windows.Forms.Label lblAliPer;
        public System.Windows.Forms.RadioButton rbValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.GroupBox gbCalculo;
    }
}