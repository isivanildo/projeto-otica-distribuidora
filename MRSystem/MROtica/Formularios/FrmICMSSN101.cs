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
    public partial class FrmICMSSN101 : Form
    {
        public FrmICMSSN101()
        {
            InitializeComponent();
            cboOrigemICMSSN101.SelectedIndex = 0;
            txtCSOSNICMSN101.Text = "101";
            txtpCredSNICMSN101.Text = "0.01";
            txtvCredICMSSNICMSN101.Text = "0.01";
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
