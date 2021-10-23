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
    public partial class FrmICMS60 : Form
    {
        public FrmICMS60()
        {
            InitializeComponent();
            cboOrigemICMS60.SelectedIndex = 0; // Origem da Mercadoria (0-Nacional, 1-Estrangeira, 2-Estrangeira adiquirida no Merc. Interno)
            txtCSTICMS60.Text = "60"; // Tipo da Tributação do ICMS (00 - Integralmente) - ver outras formas no Manual
            txtvBCSTRetICMS60.Text = "0.00"; // Valor da BC do ICMS ST
            txtvICMSSTRetICMS60.Text = "0.00"; // Valor do ICMS ST
            txtpST60.Text = "0.00"; // Alíquota suportada consumidor final
            txtvBCFCPSTRet60.Text = "0.00"; // Valor da Base de Cálculo FCP retido por ST
            txtpFCPSTRetICMS60.Text = "0.00"; // Percentual do FCP retido por ST
            txtvFCPSTRet60.Text = "0.00"; // Valor do FCP retido por ST
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
