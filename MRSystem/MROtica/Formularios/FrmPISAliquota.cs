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
    public partial class FrmPISAliquota : Form
    {
        public FrmPISAliquota()
        {
            InitializeComponent();
            cboCSTPISAliq.SelectedIndex = 0;
            txtvBCPISAliq.Text = "0.01";
            txtpPISPISAliq.Text = "1.65";
            txtvPISPISAliq.Text = "0.01";
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
