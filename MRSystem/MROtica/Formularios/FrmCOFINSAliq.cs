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
    public partial class FrmCOFINSAliq : Form
    {
        public FrmCOFINSAliq()
        {
            InitializeComponent();
            cboCSTCOFINSAliq.SelectedIndex = 0;
            txtvBCCOFINSAliq.Text = "0.01";
            txtpCOFINSAliq.Text = "7.60";
            txtCOFINSAliq.Text = "0.01";
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
