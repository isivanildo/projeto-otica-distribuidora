namespace MRUtil.Formulario
{
    partial class FrmAviso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAviso));
            this.lblMensagem = new System.Windows.Forms.Label();
            this.BtnSim = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnNao = new System.Windows.Forms.Button();
            this.BtnOK = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMensagem
            // 
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblMensagem.Location = new System.Drawing.Point(12, 9);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(360, 97);
            this.lblMensagem.TabIndex = 0;
            this.lblMensagem.Text = "lblMensagem";
            // 
            // BtnSim
            // 
            this.BtnSim.Image = global::MRUtil.Properties.Resources.ok_24;
            this.BtnSim.Location = new System.Drawing.Point(150, 8);
            this.BtnSim.Name = "BtnSim";
            this.BtnSim.Size = new System.Drawing.Size(75, 34);
            this.BtnSim.TabIndex = 1;
            this.BtnSim.Text = "SIM";
            this.BtnSim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSim.UseVisualStyleBackColor = true;
            this.BtnSim.Click += new System.EventHandler(this.BtnSim_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnNao);
            this.panel1.Controls.Add(this.BtnSim);
            this.panel1.Controls.Add(this.BtnOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 53);
            this.panel1.TabIndex = 4;
            // 
            // BtnNao
            // 
            this.BtnNao.Image = global::MRUtil.Properties.Resources.cancelar_24;
            this.BtnNao.Location = new System.Drawing.Point(302, 8);
            this.BtnNao.Name = "BtnNao";
            this.BtnNao.Size = new System.Drawing.Size(75, 34);
            this.BtnNao.TabIndex = 3;
            this.BtnNao.Text = "Não";
            this.BtnNao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnNao.UseVisualStyleBackColor = true;
            this.BtnNao.Click += new System.EventHandler(this.BtnNao_Click);
            // 
            // BtnOK
            // 
            this.BtnOK.Image = global::MRUtil.Properties.Resources.ok_24;
            this.BtnOK.Location = new System.Drawing.Point(226, 8);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 34);
            this.BtnOK.TabIndex = 2;
            this.BtnOK.Text = "OK";
            this.BtnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "informacao.ico");
            this.imageList1.Images.SetKeyName(1, "advertencia.ico");
            this.imageList1.Images.SetKeyName(2, "Erro.ico");
            // 
            // FrmAviso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblMensagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAviso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Aviso";
            this.Load += new System.EventHandler(this.FrmAviso_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnSim;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnNao;
        internal System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList1;
    }
}