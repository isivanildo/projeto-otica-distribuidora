﻿namespace MROtica.Formularios
{
    partial class FrmPISNTrib
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
            this.cboCSTPISNT = new System.Windows.Forms.ComboBox();
            this.lblCodSitTrib = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboCSTPISNT
            // 
            this.cboCSTPISNT.FormattingEnabled = true;
            this.cboCSTPISNT.Items.AddRange(new object[] {
            "Operação Tributável=tributação monofásica",
            "Operação Tributável=Substituição Tributária",
            "Operação Tributável=alíquota zero",
            "Operação Isenta de Contribuição",
            "Operação Sem Incidência da Contribuição",
            "Operação Com Suspensão da Contribuição"});
            this.cboCSTPISNT.Location = new System.Drawing.Point(16, 29);
            this.cboCSTPISNT.Name = "cboCSTPISNT";
            this.cboCSTPISNT.Size = new System.Drawing.Size(149, 21);
            this.cboCSTPISNT.TabIndex = 36;
            // 
            // lblCodSitTrib
            // 
            this.lblCodSitTrib.AutoSize = true;
            this.lblCodSitTrib.Location = new System.Drawing.Point(16, 13);
            this.lblCodSitTrib.Name = "lblCodSitTrib";
            this.lblCodSitTrib.Size = new System.Drawing.Size(91, 13);
            this.lblCodSitTrib.TabIndex = 35;
            this.lblCodSitTrib.Text = "Cód. Sit Tributária";
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(187, 27);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 34;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // FrmPISNTrib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 63);
            this.Controls.Add(this.cboCSTPISNT);
            this.Controls.Add(this.lblCodSitTrib);
            this.Controls.Add(this.btnGravar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmPISNTrib";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPISNTrib";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cboCSTPISNT;
        private System.Windows.Forms.Label lblCodSitTrib;
        private System.Windows.Forms.Button btnGravar;
    }
}