using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MRUtil;


namespace MROtica.Formularios
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        Usuario logar = new Usuario();
        Label lblNomeUsuario = new Label();
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Label lblUsuario = new Label();
            lblUsuario.Text = "Usuário";
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Location = new Point(230, 60);
            pictureBox1.Controls.Add(lblUsuario);

            Label lblSenha = new Label();
            lblSenha.Text = "Senha";
            lblSenha.BackColor = Color.Transparent;
            lblSenha.Location = new Point(338, 60);
            pictureBox1.Controls.Add(lblSenha);
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            int usuario = Convert.ToInt32(txtUsuario.Text);
            string senha = txtSenha.Text;

            if (logar.UsuarioLogado(usuario, senha) == "OK")
            {
                this.Visible = false;
                FrmPrincipal f = new FrmPrincipal();
                f.lblRodapeUsuario.Text = "USUÁRIO: " + lblNomeUsuario.Text + " | ";
                f.lblData.Text = DateTime.Now.ToShortDateString();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show(logar.MensagemRetorno, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "")
            {
                List<Usuario> usuario = new List<Usuario>();
                usuario = logar.RetornaDados(Convert.ToInt32(txtUsuario.Text));

                lblNomeUsuario.Text = "";
                lblNomeUsuario.Location = new Point(232, 105);
                lblNomeUsuario.BackColor = Color.Transparent;
                lblNomeUsuario.AutoSize = true;
                lblNomeUsuario.ForeColor = Color.Blue;
                lblNomeUsuario.Font = new Font(lblNomeUsuario.Font, FontStyle.Bold);

                pictureBox1.Controls.Add(lblNomeUsuario);

                foreach (Usuario dados in usuario)
                {
                    lblNomeUsuario.Text = dados.NomeUsuario.ToString();
                }

                if (usuario.Count == 0)
                {
                    MessageBox.Show(logar.MensagemRetorno, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }
    }
}
