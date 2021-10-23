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
    public partial class FrmICMSST : Form
    {
        public FrmICMSST()
        {
            InitializeComponent();
            cboOrigemICMSST.SelectedIndex = 0; // Origem da Mercadoria (0-Nacional, 1-Estrangeira, 2-Estrangeira adiquirida no Merc. Interno)
            txtCSTICMSST.Text = "41";   // Tipo da Tributação do ICMS (00 - Integralmente) - ver outras formas no Manual
            txtvBCSTRetICMSST.Text = "0.01";
            txtvICMSSTRetICMSST.Text = "0.01";
            txtvBCSTDestICMSST.Text = "0.01";
            txtvICMSSTDestICMSST.Text = "0.01";
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
