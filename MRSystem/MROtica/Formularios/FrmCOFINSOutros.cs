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
    public partial class FrmCOFINSOutros : Form
    {
        public FrmCOFINSOutros()
        {
            InitializeComponent();
            cboCSTCOFINSOutr.SelectedIndex = 0; 	// Código de Situacao Tributária - ver opções no Manual
            txtvBCCOFINSOutr.Text = "0.00";	// Valor da Base de Cálculo do COFINS
            txtpCOFINSOutr.Text = "0.00";	// Alíquota do COFINS em Percentual
            txtqBCProdCOFINSOutr.Text = "0"; // Quantidade Vendida
            txtvAliqProdCOFINSOutr.Text = "1"; // Alíquota da COFINS em Reais
            txtvCOFINSOutr.Text = "0.00";	// Valor do COFINS em Reais
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
