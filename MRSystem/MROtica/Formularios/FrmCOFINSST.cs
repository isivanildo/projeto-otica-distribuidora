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
    public partial class FrmCOFINSST : Form
    {
        public FrmCOFINSST()
        {
            InitializeComponent();
            txtvBCCOFINSST.Text = "1.02";   // Valor da Base de Calculo da COFINS
            txtpCOFINSST.Text = "7.60";   // Aliquota do COFINS em percentual
            txtqBCProdCOFINSST.Text = "2460"; 	// Quantidade Vendida
            txtvAliqProdCOFINSST.Text = "7.6000"; 	// Aliquota do COFINS em Reais
            txtvCOFINSST.Text = "0.04"; 	// Valor do COFINS em Reais
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
