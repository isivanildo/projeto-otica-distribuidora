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
    public partial class FrmICMS20 : Form
    {
        public FrmICMS20()
        {
            InitializeComponent();
            cboOrigemICMS20.SelectedIndex = 0; // Origem da Mercadoria (0-Nacional, 1-Estrangeira, 2-Estrangeira adiquirida no Merc. Interno)
            txtCSTICMS20.Text = "20";       // Tipo da Tributação do ICMS (00 - Integralmente) - ver outras formas no Manual
            cboModalidadeICMS20.SelectedIndex = 0; // Modalidade de determinação da Base de Cálculo - ver Manual
            txtpRedBCSTICMS20.Text = "0.01"; // Percentual de Reducao da BC
            txtvBCSTICMS20.Text = "0.91"; // Valor da Base de Cálculo do ICMS
            txtAliquotaICMS20.Text = "17.00"; // Alíquota do ICMS em Percentual
            txtValorICMS20.Text = "0.01";
            edtvICMS20Deson.Text = "0.01";
            txtvBCFCP20.Text = "0.00";
            txtpFCP20.Text = "0.00";
            txtvFCP20.Text = "0.00";
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
