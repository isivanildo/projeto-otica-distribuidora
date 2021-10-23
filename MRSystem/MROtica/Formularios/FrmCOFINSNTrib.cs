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
    public partial class FrmCOFINSNTrib : Form
    {
        public FrmCOFINSNTrib()
        {
            InitializeComponent();
            cboCSTCOFINSNT.SelectedIndex = 0;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
