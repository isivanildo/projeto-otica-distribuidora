using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MROtica.Formularios
{
    public partial class FrmICMSSN202 : Form
    {
        public FrmICMSSN202()
        {
            InitializeComponent();
            cboOrigemICMSSN202.SelectedIndex = 0; // Origem da Mercadoria (0-Nacional, 1-Estrangeira, 2-Estrangeira adiquirida no Merc. Interno)
            txtCSOSNICMSSN202.Text = "202";
            cboModSTICMSSN202.SelectedIndex = 1; // modalidade de determinação da BC do ICMS ST            
            txtpMVASTICMSSN202.Text = "0.01";
            txtpRedBCSTICMSSN202.Text = "0.01";
            txtvBCSTICMSSN202.Text = "0.01";
            txtpICMSSTICMSSN202.Text = "0.01";
            txtvICMSSTICMSSN202.Text = "0.01";
            txtvBCFCPST202.Text = "0.00";  // Valor da Base de Cálculo do FCP por ST
            txtpFCPST202.Text = "0.00";  // Percentual do FCP retido por ST
            txtvFCPST202.Text = "0.00";  // Valor do FCP retido por ST
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
