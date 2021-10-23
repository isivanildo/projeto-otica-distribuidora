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
    public partial class FrmPISST : Form
    {
        public FrmPISST()
        {
            InitializeComponent();
            txtvBCPISST.Text = "0.91"; // Valor da Base de Calculo do PIS
            txtpPISST.Text = "1.65"; // Aliquota do PIS em Percentual
            txtqBCProdPISST.Text = "246";      // Quantidade Vendida
            txtvAliqProdPISST.Text = "107.6000"; // Aliquota do PIS em Reais
            txtvPISST.Text = "0.02"; // Valor do PIS em Reais
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
