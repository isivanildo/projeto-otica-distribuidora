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
    public partial class FrmIPINTributado : Form
    {
        public FrmIPINTributado()
        {
            InitializeComponent();
            txtclEnqIPINTrib.Text = "NDA"; 	   // Classe de enquadramento do IPI para cigarros e Bebidas
            txtCNPJProdIPINTrib.Text = "00000000000000"; // CNPJ do produtor da mercadoria quando diferente do emitente
            txtcSeloIPINTrib.Text = "N"; 		   // Codigo do selo de Controle IPI
            txtqSeloIPINTrib.Text = "0"; 		   // Quantidade de selo de Controle
            txtcEnqIPINTrib.Text = "999"; 	   // Codigo de enquadramento legal do IPI
            cboCSTIPINTrib.SelectedIndex = 0; // Codigo da Situacao tributaria do IPI
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
