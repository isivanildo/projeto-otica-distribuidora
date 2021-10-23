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
    public partial class FrmIPITributado : Form
    {
        public FrmIPITributado()
        {
            InitializeComponent();
            txtclEnqIPITrib.Text = "NDA"; 	   // Classe de enquadramento do IPI para cigarros e Bebidas
            txtCNPJProdIPITrib.Text = "00000000000000"; // CNPJ do produtor da mercadoria quando diferente do emitente
            txtcSeloIPITrib.Text = "N"; 		   // Codigo do selo de Controle IPI
            txtqSeloIPITrib.Text = "0"; 		   // Quantidade de selo de Controle
            txtcEnqIPITrib.Text = "999"; 	   // Codigo de enquadramento legal do IPI
            cboCSTIPITrib.SelectedIndex = 0; // Codigo da Situacao tributaria do IPI
            txtvBCIPITrib.Text = "90.00"; // Valor da BC do IPI
            txtIPITrib.Text = "5.00";  // Aliquota do IPI
            txtqUnidIPITrib.Text = "1";  // Quantidade total na unidade padrao para tributacao
            txtvUnidIPITrib.Text = "5";  // Valor por unidade tributavel
            txtvIPITrib.Text = "1"; // Valor do IPI
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
