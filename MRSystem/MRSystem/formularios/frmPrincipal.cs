using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MRSystem.formularios;

namespace MRSystem
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void emitenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmitente f = new frmEmitente();
            f.ShowDialog();
            f.Dispose();
        }
    }
}
