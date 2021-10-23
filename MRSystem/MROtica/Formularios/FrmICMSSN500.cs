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
    public partial class FrmICMSSN500 : Form
    {
        public FrmICMSSN500()
        {
            InitializeComponent();
            cboOrigemICMSSN500.SelectedIndex = 0; // Origem da Mercadoria (0-Nacional, 1-Estrangeira, 2-Estrangeira adiquirida no Merc. Interno)
            txtCSOSNICMSSN500.Text = "500";
            txtvBCSTRetICMSSN500.Text = "0.01";
            txtvICMSSTRetICMSSN500.Text = "0.01";
            txtpST500.Text = "0.00";  // Alíquota suportada pelo Consumidor Final
            txtvBCFCPSTRet500.Text = "0.00";  // Valor da Base de Cálculo do FCO retido
            txtvICMSSTRetICMSSN500.Text = "0.00";  // Valor do ICMS retido por ST
            txtvFCPSTRet500.Text = "0.00";  // Valor do FCP retido por ST
            txtpFCPSTRet500.Text = "0.00";  // Percentual do FCP retido por ST
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
