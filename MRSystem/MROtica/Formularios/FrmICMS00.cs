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
using MRUtil.Enumeracao;

namespace MROtica.Formularios
{
    public partial class FrmICMS00 : Form
    {
        public int codigoNaturezaOperacao = 0;
        public FrmICMS00()
        {
            InitializeComponent();
            cboOrigemICMS00.SelectedIndex = 0;
            txtCSTICMS00.Text = "00";
            cboModalidadeICMS00.SelectedIndex = 0;
            txtAliquotaICMS00.Text = "0.00";
            txtpFCP00.Text = "0.00";
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();

            tb.Columns.Add("OrigemMercadoria", Type.GetType("System.Int32"));
            tb.Columns.Add("Modalidade", Type.GetType("System.Int32"));
            tb.Columns.Add("CST", Type.GetType("System.String"));
            tb.Columns.Add("AliquotaICMS", Type.GetType("System.Decimal"));
            tb.Columns.Add("PFCP", Type.GetType("System.Decimal"));

            DataRow linha = tb.NewRow();

            if (cboOrigemICMS00.SelectedIndex == 0)
            {
                linha["OrigemMercadoria"] = OrigemMercadoriaNFe.Nacional;
                //linha["OrigemMercadoria"] = 0;
            }
            else if (cboOrigemICMS00.SelectedIndex == 1)
            {
                linha["OrigemMercadoria"] = (OrigemMercadoriaNFe)(cboOrigemICMS00.SelectedIndex);
                //linha["OrigemMercadoria"] = OrigemMercadoriaNFe.Estrangeira_Importacao_direta;
                //linha["OrigemMercadoria"] = 1;
            }
            else if (cboOrigemICMS00.SelectedIndex == 2)
            {
                linha["OrigemMercadoria"] = OrigemMercadoriaNFe.Estrangeira_Adquirida_no_mercado_interno;
                //linha["OrigemMercadoria"] = 2;
            }

            if (cboModalidadeICMS00.SelectedIndex == 0)
            {
                linha["Modalidade"] = 0;
            }
            else if (cboModalidadeICMS00.SelectedIndex == 1)
            {
                linha["Modalidade"] = 1;
            }
            else if (cboModalidadeICMS00.SelectedIndex == 2)
            {
                linha["Modalidade"] = 2;
            }
            else if (cboModalidadeICMS00.SelectedIndex == 3)
            {
               linha["Modalidade"] = 3;
            }

            linha["CST" ] = txtCSTICMS00.Text;
            linha["AliquotaICMS"] = txtAliquotaICMS00.Text;
            linha["PFCP"] = txtpFCP00.Text;

            tb.Rows.Add(linha);

            FrmOperacaoTributaria.tbCst = tb;

            this.Close();
        }

        private void FrmICMS00_Load(object sender, EventArgs e)
        {
            if (Geral.TipoReg != 'N')
            {
                ConexaoDB conexao = new ConexaoDB();
                DataTable tb = new DataTable();
                tb = conexao.CarregaTabela("select * from cstfiscal where codigonat = " + codigoNaturezaOperacao, ref tb);

                if (tb.Rows.Count > 0)
                {
                    cboOrigemICMS00.SelectedValue = tb.Rows[0]["origem"].ToString();
                    cboModalidadeICMS00.SelectedValue = tb.Rows[0]["modbc"].ToString();
                    txtAliquotaICMS00.Text = tb.Rows[0]["picms"].ToString();
                    txtpFCP00.Text = tb.Rows[0]["pfcp"].ToString();
                }
            }
        }
    }
}
