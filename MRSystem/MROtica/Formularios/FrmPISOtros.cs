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
    public partial class FrmPISOtros : Form
    {
        public FrmPISOtros()
        {
            InitializeComponent();
            cboCSTPISOutr.SelectedIndex = 0;   // Codigo de Situacao Tributária - ver opções no Manual
            txtvBCPISOutr.Text = "0.00"; // Valor da Base de Cálculo do PIS
            txtpPISPISOutr.Text = "0.00"; // Alíquota em Percencual do PIS
            txtqBCProdPISOutr.Text = "0"; // Quantidade Vendida
            txtvAliqProdPISOutr.Text = "1"; // Alíquota do PIS em Reais
            txtvPISOutr.Text = "0.00"; // Valor do PIS em Reais
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
