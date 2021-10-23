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
    public partial class FrmISSQN : Form
    {
        public FrmISSQN()
        {
            InitializeComponent();
            txtvBCISSQN.Text = "82.60";   // Valor da Base de Calculo da ISSQN
            txtvAliqISSQN.Text = "5.00";    // Aliquota do ISSQN
            txtvISSQN.Text = "4.13";    // Valor do ISSQN
            txtcMunFGISSQN.Text = "5208707"; // Codigo do Municipio de Ororrencia do fato gerador do ISSQN
            txtcListServISSQN.Text = "1402";    // Codigo da Lista de Servicos
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
