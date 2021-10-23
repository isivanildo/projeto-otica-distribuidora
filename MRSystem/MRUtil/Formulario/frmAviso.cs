using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRUtil.Formulario
{
    public partial class FrmAviso : Form
    {
        public Belemtech.TipoAviso tipo;
        public Belemtech.Respo resposta = Belemtech.Respo.OK;
        public Belemtech.ImagemAviso imgAviso;
        public FrmAviso()
        {
            InitializeComponent();
        }

        private void FrmAviso_Load(object sender, EventArgs e)
        {
            lblMensagem.MaximumSize = this.Size;
            switch (tipo)
            {
                case Belemtech.TipoAviso.SIMNAO:
                    BtnSim.Visible = true;
                    BtnSim.Location = new Point(226, 8);
                    BtnNao.Visible = true;
                    BtnNao.TabIndex = 0;
                    BtnOK.Visible = false;
                    break;
                case Belemtech.TipoAviso.OK:
                    BtnSim.Visible = false;
                    BtnNao.Visible = false;
                    BtnOK.Visible = true;
                    BtnOK.Location = new Point(302, 8);
                    BtnOK.Focus();
                    break;
            }

            try
            {
                if (imgAviso == Belemtech.ImagemAviso.Informacao)
                {
                    this.Icon = new System.Drawing.Icon(imageList1.Images.Keys[0]);
                }
                else if (imgAviso == Belemtech.ImagemAviso.Advertencia)
                {
                    this.Icon = new System.Drawing.Icon(imageList1.Images.Keys[1]);
                }
                else if (imgAviso == Belemtech.ImagemAviso.Error)
                {
                    this.Icon = new System.Drawing.Icon(imageList1.Images.Keys[2]);
                }
            }
            catch (System.IO.FileNotFoundException ex)
            {
                this.Icon = this.Icon;
            }

        }

        private void BtnSim_Click(object sender, EventArgs e)
        {
            resposta = Belemtech.Respo.SIM;
            this.Close();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            resposta = Belemtech.Respo.OK;
            this.Close();
        }

        private void BtnNao_Click(object sender, EventArgs e)
        {
            resposta = Belemtech.Respo.NAO;
            this.Close();
        }
    }
}
