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
    public partial class FrmII : Form
    {
        public FrmII()
        {
            InitializeComponent();
            txtvBCII.Text = "1.00";
            txtvDespAdu.Text = "1.00";
            txtvII.Text = "1.00";
            txtvIOFII.Text = "1.00";
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
