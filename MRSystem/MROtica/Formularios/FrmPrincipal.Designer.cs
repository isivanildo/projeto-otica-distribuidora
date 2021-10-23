namespace MROtica.Formularios
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.mmPrincipal = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nFeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nFCeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cFOPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClassificaçãoFiscalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerencialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balcãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bFerramenta = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblRodapeUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblData = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.mmPrincipal.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mmPrincipal
            // 
            this.mmPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.dToolStripMenuItem,
            this.gerencialToolStripMenuItem,
            this.caixaToolStripMenuItem,
            this.estoqueToolStripMenuItem,
            this.financeiroToolStripMenuItem,
            this.balcãoToolStripMenuItem,
            this.utilitáriosToolStripMenuItem});
            this.mmPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mmPrincipal.Name = "mmPrincipal";
            this.mmPrincipal.Size = new System.Drawing.Size(969, 24);
            this.mmPrincipal.TabIndex = 0;
            this.mmPrincipal.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nFeToolStripMenuItem,
            this.nFCeToolStripMenuItem,
            this.configuraçõesToolStripMenuItem});
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.dToolStripMenuItem.Text = "Documentos Fiscais";
            // 
            // nFeToolStripMenuItem
            // 
            this.nFeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eToolStripMenuItem});
            this.nFeToolStripMenuItem.Name = "nFeToolStripMenuItem";
            this.nFeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nFeToolStripMenuItem.Text = "NF-e";
            // 
            // eToolStripMenuItem
            // 
            this.eToolStripMenuItem.Name = "eToolStripMenuItem";
            this.eToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.eToolStripMenuItem.Text = "Emitir NF-e";
            this.eToolStripMenuItem.Click += new System.EventHandler(this.eToolStripMenuItem_Click);
            // 
            // nFCeToolStripMenuItem
            // 
            this.nFCeToolStripMenuItem.Name = "nFCeToolStripMenuItem";
            this.nFCeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nFCeToolStripMenuItem.Text = "NFC-e";
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cidadeToolStripMenuItem,
            this.cFOPToolStripMenuItem,
            this.ClassificaçãoFiscalToolStripMenuItem});
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.configuraçõesToolStripMenuItem.Text = "Configuração";
            // 
            // cidadeToolStripMenuItem
            // 
            this.cidadeToolStripMenuItem.Name = "cidadeToolStripMenuItem";
            this.cidadeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cidadeToolStripMenuItem.Text = "Cidade";
            // 
            // cFOPToolStripMenuItem
            // 
            this.cFOPToolStripMenuItem.Name = "cFOPToolStripMenuItem";
            this.cFOPToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cFOPToolStripMenuItem.Text = "CFOP";
            // 
            // ClassificaçãoFiscalToolStripMenuItem
            // 
            this.ClassificaçãoFiscalToolStripMenuItem.Name = "ClassificaçãoFiscalToolStripMenuItem";
            this.ClassificaçãoFiscalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ClassificaçãoFiscalToolStripMenuItem.Text = "Operação Tributária";
            this.ClassificaçãoFiscalToolStripMenuItem.Click += new System.EventHandler(this.ClassificaçãoFiscalToolStripMenuItem_Click);
            // 
            // gerencialToolStripMenuItem
            // 
            this.gerencialToolStripMenuItem.Name = "gerencialToolStripMenuItem";
            this.gerencialToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.gerencialToolStripMenuItem.Text = "Gerencial";
            // 
            // caixaToolStripMenuItem
            // 
            this.caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            this.caixaToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.caixaToolStripMenuItem.Text = "Caixa";
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // balcãoToolStripMenuItem
            // 
            this.balcãoToolStripMenuItem.Name = "balcãoToolStripMenuItem";
            this.balcãoToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.balcãoToolStripMenuItem.Text = "Balcão";
            // 
            // utilitáriosToolStripMenuItem
            // 
            this.utilitáriosToolStripMenuItem.Name = "utilitáriosToolStripMenuItem";
            this.utilitáriosToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.utilitáriosToolStripMenuItem.Text = "Utilitários";
            // 
            // bFerramenta
            // 
            this.bFerramenta.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.bFerramenta.Location = new System.Drawing.Point(0, 24);
            this.bFerramenta.Name = "bFerramenta";
            this.bFerramenta.Size = new System.Drawing.Size(969, 25);
            this.bFerramenta.TabIndex = 1;
            this.bFerramenta.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblRodapeUsuario,
            this.lblData});
            this.statusStrip1.Location = new System.Drawing.Point(0, 467);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(969, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblRodapeUsuario
            // 
            this.lblRodapeUsuario.Name = "lblRodapeUsuario";
            this.lblRodapeUsuario.Size = new System.Drawing.Size(118, 17);
            this.lblRodapeUsuario.Text = "toolStripStatusLabel1";
            // 
            // lblData
            // 
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(118, 17);
            this.lblData.Text = "toolStripStatusLabel1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 489);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.bFerramenta);
            this.Controls.Add(this.mmPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mmPrincipal;
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.mmPrincipal.ResumeLayout(false);
            this.mmPrincipal.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mmPrincipal;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.ToolStrip bFerramenta;
        private System.Windows.Forms.ToolStripMenuItem nFeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nFCeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cFOPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClassificaçãoFiscalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerencialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balcãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilitáriosToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel lblRodapeUsuario;
        public System.Windows.Forms.ToolStripStatusLabel lblData;
        private System.Windows.Forms.ToolStripMenuItem eToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}