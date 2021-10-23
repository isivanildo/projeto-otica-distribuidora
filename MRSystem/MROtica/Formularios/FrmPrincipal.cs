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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            this.Text = "MR Ótica Versão: " + Application.ProductVersion;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNotaFiscal f = new FrmNotaFiscal();
            f.ShowDialog();
            f.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTesteNFe f = new frmTesteNFe();
            f.ShowDialog();
        }

        private void ClassificaçãoFiscalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOperacaoTributaria f = new FrmOperacaoTributaria();
            f.ShowDialog();
            f.Dispose();
        }
    }
}
