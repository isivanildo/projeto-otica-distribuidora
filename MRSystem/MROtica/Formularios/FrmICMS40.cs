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
    public partial class FrmICMS40 : Form
    {
        public FrmICMS40()
        {
            InitializeComponent();
            cboOrigemICMS40.SelectedIndex = 0; // Origem da Mercadoria (0-Nacional, 1-Estrangeira, 2-Estrangeira adiquirida no Merc. Interno)
            txtCSTICMS40.Text = "40";       // Tipo da Tributação do ICMS (00 - Integralmente) - ver outras formas no Manual
            txtValorICMS40.Text = "1.00";
            cbmotivoICMS40Deson.SelectedIndex = 7;
            edtvIcms40Deson.Text = "0.01"; // Valor do ICMS Desonerado
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
