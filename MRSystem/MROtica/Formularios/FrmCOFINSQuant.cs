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
    public partial class FrmCOFINSQuant : Form
    {
        public FrmCOFINSQuant()
        {
            InitializeComponent();
            cboCSTCOFINSQtde.SelectedIndex = 0;
            txtqBCProdCOFINSQtde.Text = "2.0200";
            txtvAliqProdCOFINSQtde.Text = "3.0000";
            txtvCOFINSQtde.Text = "0.03";
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
