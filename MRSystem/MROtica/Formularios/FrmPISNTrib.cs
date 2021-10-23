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
    public partial class FrmPISNTrib : Form
    {
        public FrmPISNTrib()
        {
            InitializeComponent();
            cboCSTPISNT.SelectedIndex = 0; // Codigo de Situacao Tributária
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
