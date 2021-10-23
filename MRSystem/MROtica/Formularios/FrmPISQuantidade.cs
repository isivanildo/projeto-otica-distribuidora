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
    public partial class FrmPISQuantidade : Form
    {
        public FrmPISQuantidade()
        {
            InitializeComponent();
            cboCSTPISQtde.SelectedIndex = 0;
            txtqBCProdPISQtde.Text = "0";
            txtvAliqProdPISQtde.Text = "1";
            txtvPISPISQtde.Text = "0.00";
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
