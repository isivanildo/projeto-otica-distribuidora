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
    public partial class frmSenha : Form
    {
        private Usuario usuario = new Usuario();
        private Label lblNomeUsuario = new Label();
        public int CodigoUsuario { get; set; }

        public int _xResposta;
        public frmSenha()
        {
            InitializeComponent();
        }

        private void frmSenha_Load(object sender, EventArgs e)
        {
            Label lblUsuario = new Label();
            lblUsuario.Text = "Usuário";
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Location = new Point(155, 38);
            lblUsuario.Width = 50;
            pictureBox1.Controls.Add(lblUsuario);

            Label lblSenha = new Label();
            lblSenha.Text = "Senha";
            lblSenha.BackColor = Color.Transparent;
            lblSenha.Location = new Point(242, 38);
            lblSenha.Width = 50;
            pictureBox1.Controls.Add(lblSenha);
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            usuario.VerificaUsuarioLogado(usuario.CodigoUsuario, txtSenha.Text);
            if (usuario.UsuarioLogado == true)
            {
                CodigoUsuario = Convert.ToInt32(txtUsuario.Text);
                _xResposta = 1;
                this.Close();
            }
            else
            {
                Geral.TelaAviso("Erro ao efetuar o login. Por favor verificar se \nsuas credenciais estão corretas!", "ERROR", this, Belemtech.TipoAviso.OK, Belemtech.ImagemAviso.Error);
            }
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
            this.Dispose();
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "")
            {
                lblNomeUsuario.Text = "";
                lblNomeUsuario.Location = new Point(155, 80);
                lblNomeUsuario.BackColor = Color.Transparent;
                lblNomeUsuario.AutoSize = true;
                lblNomeUsuario.ForeColor = Color.Blue;
                lblNomeUsuario.Font = new Font(lblNomeUsuario.Font, FontStyle.Bold);
                pictureBox1.Controls.Add(lblNomeUsuario);
                usuario.RetornaRegistro(Convert.ToInt32(txtUsuario.Text));
                lblNomeUsuario.Text = usuario.NomeUsuario;
            }
        }

        private void frmSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
;            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
                Geral.TelaAviso("Campo usuário só aceita valores númericos \nFJSJHFH FASF ASDASD", "ERRO", this, Belemtech.TipoAviso.OK, Belemtech.ImagemAviso.Error);
            }
        }

        private void frmSenha_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_xResposta != 1)
            {
                Application.Exit();
            }
        }
    }
}
