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
    public partial class FrmOperacaoTributaria : Form
    {
        FrmICMS00 icms00 = null;
        FrmICMS10 icms10 = null;
        FrmICMS20 icms20 = null;
        FrmICMS30 icms30 = null;
        FrmICMS40 icms40 = null;
        FrmICMS51 icms51 = null;
        FrmICMS60 icms60 = null;
        FrmICMS70 icms70 = null;
        FrmICMS90 icms90 = null;
        FrmICMSPartilha icmsPart = null;
        FrmICMSST icmsST = null;
        FrmICMSSN101 icmsSN101 = null;
        FrmICMSSN102 icmsSN102 = null;
        FrmICMSSN201 icmsSN201 = null;
        FrmICMSSN202 icmsSN202 = null;
        FrmICMSSN500 icmsSN500 = null;
        FrmICMSSN900 icmsSN900 = null;

        //ipi
        FrmIPITributado ipiTrib = null;
        FrmIPINTributado ipiNTrib = null;

        //ii
        FrmII ii = null;

        //ISSQN
        FrmISSQN issqn = null;

        //PIS
        FrmPISAliquota pisAliq = null;
        FrmPISQuantidade pisQuant = null;
        FrmPISNTrib pisNTrib = null;
        FrmPISOtros pisOutros = null;

        //PISSIT
        FrmPISST pissit = null;

        //COFINS
        FrmCOFINSAliq cofinsAliq = null;
        FrmCOFINSQuant cofinsQuant = null;
        FrmCOFINSNTrib cofisNTrib = null;
        FrmCOFINSOutros cofinsOutros = null;

        //COFINSST
        FrmCOFINSST cofinsST = null;

        //Geral
        Geral geral = null;

        OperacaoTributaria operacaoTrib = null;
        CstNFe cstCodigo = null;

        public static DataTable tbCst = new DataTable();

        private int intTag = 0;
        public FrmOperacaoTributaria()
        {
            InitializeComponent();
        }

        private void FrmOperacaoTributaria_Load(object sender, EventArgs e)
        {
            intTag = 0;
            ConexaoDB conexao = new ConexaoDB();
            DataTable tb = new DataTable();
            cboICMS.DisplayMember = "descricao";
            cboICMS.ValueMember = "codigocst";
            cboICMS.DataSource = conexao.CarregaTabela("select * from cst", ref tb);
            cboICMS.SelectedValue = -1;
            CarregaGrid();
        }

        private void ICSMController(int index)
        {
            switch (index)
            {
                case 0:
                    if (icms00 == null)
                    {
                        icms00 = new FrmICMS00();
                    }
                    icms00.codigoNaturezaOperacao = Convert.ToInt32(txtCodigo.Text);
                    icms00.ShowDialog();
                    break;
                case 1:
                    if (icms10 == null)
                    {
                        icms10 = new FrmICMS10();
                    }
                    icms10.ShowDialog();
                    break;
                case 2:
                    if (icms20 == null)
                    {
                        icms20 = new FrmICMS20();
                    }
                    icms20.ShowDialog();
                    break;
                case 3:
                    if (icms30 == null)
                    {
                        icms30 = new FrmICMS30();
                    }
                    icms30.ShowDialog();
                    break;
                case 4:
                    if (icms40 == null)
                    {
                        icms40 = new FrmICMS40();
                    }
                    icms40.ShowDialog();
                    break;
                case 5:
                    if (icms40 == null)
                    {
                        icms40 = new FrmICMS40();
                    }
                    icms40.ShowDialog();
                    break;
                case 6:
                    if (icms40 == null)
                    {
                        icms40 = new FrmICMS40();
                    }
                    icms40.ShowDialog();
                    break;
                case 7:
                    if (icms51 == null)
                    {
                        icms51 = new FrmICMS51();
                    }
                    icms51.ShowDialog();
                    break;
                case 8:
                    if (icms60 == null)
                    {
                        icms60 = new FrmICMS60();
                    }
                    icms60.ShowDialog();
                    break;
                case 9:
                    if (icms70 == null)
                    {
                        icms70 = new FrmICMS70();
                    }
                    icms70.ShowDialog();
                    break;
                case 10:
                    if (icms90 == null)
                    {
                        icms90 = new FrmICMS90();
                    }
                    icms90.ShowDialog();
                    break;
                case 11:
                    if (icmsPart == null)
                    {
                        icmsPart = new FrmICMSPartilha();
                    }
                    icmsPart.ShowDialog();
                    break;
                case 12:
                    if (icmsST == null)
                    {
                        icmsST = new FrmICMSST();
                    }
                    icmsST.ShowDialog();
                    break;
                case 13:
                    if (icmsSN101 == null)
                    {
                        icmsSN101 = new FrmICMSSN101();
                    }
                    icmsSN101.ShowDialog();
                    break;
                case 14:
                    if (icmsSN102 == null)
                    {
                        icmsSN102 = new FrmICMSSN102();
                    }
                    icmsSN102.ShowDialog();
                    break;
                case 15:
                    if (icmsSN201 == null)
                    {
                        icmsSN201 = new FrmICMSSN201();
                    }
                    icmsSN201.ShowDialog();
                    break;
                case 16:
                    if (icmsSN202 == null)
                    {
                        icmsSN202 = new FrmICMSSN202();
                    }
                    icmsSN202.ShowDialog();
                    break;
                case 17:
                    if (icmsSN500 == null)
                    {
                        icmsSN500 = new FrmICMSSN500();
                    }
                    icmsSN500.ShowDialog();
                    break;
                case 18:
                    if (icmsSN900 == null)
                    {
                        icmsSN900 = new FrmICMSSN900();
                    }
                    icmsSN900.ShowDialog();
                    break;
            }
        }

        private void IPIController(int index)
        {
            switch (index)
            {
                case 0:
                    if (ipiTrib == null)
                    {
                        ipiTrib = new FrmIPITributado();
                    }
                    ipiTrib.ShowDialog();
                    break;
                case 1:
                    if (ipiNTrib == null)
                    {
                        ipiNTrib = new FrmIPINTributado();
                    }
                    ipiNTrib.ShowDialog();
                    break;
            }
        }
        private void IIController(int index)
        {
            switch (index)
            {
                case 0:
                    if (ii == null)
                    {
                        ii = new FrmII();
                    }
                    ii.ShowDialog();
                    break;
            }
        }

        //telas do ISSQN
        private void ISSQNController(int index)
        {
            switch (index)
            {
                case 0:
                    if (issqn == null)
                    {
                        issqn = new FrmISSQN();
                    }
                    issqn.ShowDialog();
                    break;
            }
        }

        //telas do PIS
        private void PISController(int index)
        {
            switch (index)
            {
                case 0:
                    if (pisAliq == null)
                    {
                        pisAliq = new FrmPISAliquota();
                    }
                    pisAliq.ShowDialog();
                    break;
                case 1:
                    if (pisQuant == null)
                    {
                        pisQuant = new FrmPISQuantidade();
                    }
                    pisQuant.ShowDialog();
                    break;
                case 2:
                    if (pisNTrib == null)
                    {
                        pisNTrib = new FrmPISNTrib();
                    }
                    pisNTrib.ShowDialog();
                    break;
                case 3:
                    if (pisOutros == null)
                    {
                        pisOutros = new FrmPISOtros();
                    }
                    pisOutros.ShowDialog();
                    break;
            }
        }

        //telas do PISST
        private void PISSTControler(int index)
        {
            switch (index)
            {
                case 0:
                    if (pissit == null)
                    {
                        pissit = new FrmPISST();
                    }
                    pissit.ShowDialog();
                    break;
            }
        }

        //telas do COFINS
        private void COFINSController(int index)
        {
            switch (index)
            {
                case 0:
                    if (cofinsAliq == null)
                    {
                        cofinsAliq = new FrmCOFINSAliq();
                    }
                    cofinsAliq.ShowDialog();
                    break;
                case 1:
                    if (cofinsQuant == null)
                    {
                        cofinsQuant = new FrmCOFINSQuant();
                    }
                    cofinsQuant.ShowDialog();
                    break;
                case 2:
                    if (cofisNTrib == null)
                    {
                        cofisNTrib = new FrmCOFINSNTrib();
                    }
                    cofisNTrib.ShowDialog();
                    break;
                case 3:
                    if (cofinsOutros == null)
                    {
                        cofinsOutros = new FrmCOFINSOutros();
                    }
                    cofinsOutros.ShowDialog();
                    break;
            }
        }

        //telas do COFINSST
        private void COFINSSTController(int index)
        {
            switch (index)
            {
                case 0:
                    if (cofinsST == null)
                    {
                        cofinsST = new FrmCOFINSST();
                    }
                    cofinsST.ShowDialog();
                    break;
            }
        }

        private void cboICMS_SelectedIndexChanged(object sender, EventArgs e)
        {
            intTag = intTag + 1;
            if (intTag > 1)
            {
                ICSMController(cboICMS.SelectedIndex);
            }
        }
        private void cboIPI_SelectedIndexChanged(object sender, EventArgs e)
        {
            IPIController(cboIPI.SelectedIndex);
        }

        private void cboII_SelectedIndexChanged(object sender, EventArgs e)
        {
            IIController(cboII.SelectedIndex);
        }

        private void cboISSQN_SelectedIndexChanged(object sender, EventArgs e)
        {
            ISSQNController(cboISSQN.SelectedIndex);
        }

        private void cboPIS_SelectedIndexChanged(object sender, EventArgs e)
        {
            PISController(cboPIS.SelectedIndex);
        }

        private void cboPISST_SelectedIndexChanged(object sender, EventArgs e)
        {
            PISSTControler(cboPISST.SelectedIndex);
        }

        private void cboCOFINS_SelectedIndexChanged(object sender, EventArgs e)
        {
            COFINSController(cboCOFINS.SelectedIndex);
        }

        private void cboCOFINSST_SelectedIndexChanged(object sender, EventArgs e)
        {
            COFINSSTController(cboCOFINSST.SelectedIndex);
        }
        private void CarregaGrid()
        {
            dgOperacaoTributaria.Columns.Clear();
            dgOperacaoTributaria.AutoGenerateColumns = false;
            dgOperacaoTributaria.AllowUserToAddRows = false;
            dgOperacaoTributaria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgOperacaoTributaria.RowHeadersVisible = false;
            dgOperacaoTributaria.ReadOnly = true;

            DataGridViewTextBoxColumn codigo = new DataGridViewTextBoxColumn(); //Posição 0
            codigo.DataPropertyName = "Codigo";
            codigo.HeaderText = "Código";
            codigo.Width = 50;
            codigo.DefaultCellStyle.Format = "000";
            codigo.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            codigo.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgOperacaoTributaria.Columns.Add(codigo);

            DataGridViewTextBoxColumn tipoEntradaSaida = new DataGridViewTextBoxColumn(); //Posição 1
            tipoEntradaSaida.DataPropertyName = "TipoEntradaSaida";
            tipoEntradaSaida.HeaderText = "Tipo de Nota";
            tipoEntradaSaida.Width = 100;
            tipoEntradaSaida.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgOperacaoTributaria.Columns.Add(tipoEntradaSaida);

            DataGridViewTextBoxColumn descricao = new DataGridViewTextBoxColumn(); //Posição 2
            descricao.DataPropertyName = "Descricao";
            descricao.HeaderText = "Descrição";
            descricao.Width = 250;
            dgOperacaoTributaria.Columns.Add(descricao);

            DataGridViewTextBoxColumn precoUsado = new DataGridViewTextBoxColumn(); //Posição 3
            precoUsado.DataPropertyName = "PrecoUsado";
            precoUsado.HeaderText = "Preço Usado";
            precoUsado.Width = 100;
            precoUsado.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgOperacaoTributaria.Columns.Add(precoUsado);

            DataGridViewTextBoxColumn destinatario = new DataGridViewTextBoxColumn(); //Posição 4
            destinatario.DataPropertyName = "Destinatario";
            destinatario.HeaderText = "Destinatário";
            destinatario.Width = 100;
            dgOperacaoTributaria.Columns.Add(destinatario);

            DataGridViewTextBoxColumn observacao = new DataGridViewTextBoxColumn(); //Posição 5
            observacao.DataPropertyName = "Observacao";
            observacao.HeaderText = "Observacao";
            observacao.Width = 300;
            dgOperacaoTributaria.Columns.Add(observacao);

            DataGridViewCheckBoxColumn complementar = new DataGridViewCheckBoxColumn(); //Posição 6
            complementar.DataPropertyName = "Complementar";
            complementar.HeaderText = "Complementar";
            complementar.Width = 80;
            complementar.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            complementar.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgOperacaoTributaria.Columns.Add(complementar);

            DataGridViewCheckBoxColumn devolucao = new DataGridViewCheckBoxColumn(); //Posição 7
            devolucao.DataPropertyName = "Devolucao";
            devolucao.HeaderText = "Devolução";
            devolucao.Width = 70;
            devolucao.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            devolucao.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgOperacaoTributaria.Columns.Add(devolucao);

            DataGridViewTextBoxColumn destino = new DataGridViewTextBoxColumn(); //Posição 8
            destino.DataPropertyName = "Destino";
            destino.HeaderText = "Destino";
            destino.Width = 90;
            dgOperacaoTributaria.Columns.Add(destino);

            DataGridViewCheckBoxColumn normal = new DataGridViewCheckBoxColumn(); //Posição 9
            normal.DataPropertyName = "Normal";
            normal.Width = 50;
            normal.HeaderText = "Normal";
            dgOperacaoTributaria.Columns.Add(normal);

            DataGridViewCheckBoxColumn ajuste = new DataGridViewCheckBoxColumn(); //Posição 10
            ajuste.DataPropertyName = "Ajuste";
            ajuste.HeaderText = "Ajuste";
            ajuste.Width = 50;
            ajuste.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ajuste.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgOperacaoTributaria.Columns.Add(ajuste);

            DataGridViewTextBoxColumn operacaonfe = new DataGridViewTextBoxColumn(); //Posição 11
            operacaonfe.DataPropertyName = "OperacaoNFe";
            operacaonfe.HeaderText = "Operação NFe";
            operacaonfe.Width = 100;
            dgOperacaoTributaria.Columns.Add(operacaonfe);

            DataGridViewTextBoxColumn cfop = new DataGridViewTextBoxColumn(); //Posição 12
            cfop.DataPropertyName = "cfop";
            cfop.HeaderText = "CFOP";
            cfop.Width = 70;
            dgOperacaoTributaria.Columns.Add(cfop);

            DataGridViewTextBoxColumn cst = new DataGridViewTextBoxColumn(); //Posição 13
            cst.DataPropertyName = "codigocst";
            cst.HeaderText = "CST";
            cst.Width = 50;
            dgOperacaoTributaria.Columns.Add(cst);

            OperacaoTributaria operacaoTrib = new OperacaoTributaria();
            dgOperacaoTributaria.DataSource = operacaoTrib.RetornaDados("select * from  NaturezaOperacao");
        }

        private void dgOperacaoTributaria_SelectionChanged(object sender, EventArgs e)
        {
            if (operacaoTrib == null)
            {
                operacaoTrib = new OperacaoTributaria();
            }
            int intIndex = Convert.ToInt32(dgOperacaoTributaria.CurrentRow.Cells[0].Value);

            operacaoTrib.RetornaRegistro("select * from NaturezaOperacao where codigonat=" + intIndex);
            txtCodigo.Text = Convert.ToString(operacaoTrib.Codigo.ToString("000"));
            txtDescricao.Text = operacaoTrib.Descricao;
            txtObservacao.Text = operacaoTrib.Observacao;
            if (operacaoTrib.TipoEntradaSaida == "Saída")
            {
                rbSaida.Checked = true;
            }
            else
            {
                rbEntrada.Checked = true;
            }
            if (operacaoTrib.PrecoUsado == "Venda")
            {
                rbVenda.Checked = true;
            }
            else
            {
                rbCusto.Checked = true;
            }

            rbNormal.Checked = operacaoTrib.Normal;
            rbComplementar.Checked = operacaoTrib.Complementar;
            rbAjuste.Checked = operacaoTrib.Ajuste;
            rbDevolucao.Checked = operacaoTrib.Devolucao;

            if (operacaoTrib.Destinatario == "Cliente")
            {
                rbCliente.Checked = true;
            }
            else
            {
                rbFornecedor.Checked = true;
            }

            if (operacaoTrib.Destino == "Interno")
            {
                rbInterno.Checked = true;
            }
            else if (operacaoTrib.Destino == "Interestadual")
            {
                rbInterestadual.Checked = true;
            }
            else
            {
                rbExterior.Checked = true;
            }

            if (operacaoTrib.OperacaoNFe == "Consumidor")
            {
                rbOpConsumidor.Checked = true;
            }
            else
            {
                rbOpNormal.Checked = true;
            }

            cstCodigo = new CstNFe();
            cstCodigo.RetornaRegistro(intIndex);
            if (cstCodigo.CST != null)
            {
                cboICMS.SelectedValue = cstCodigo.CST;
            }
            else
            {
                cboICMS.SelectedValue = "";
            }

        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            Geral.TipoReg = 'N';
            if (geral == null)
            {
                geral = new Geral();
            }

            geral.AtivaControles(this);
            //geral.LimpaControles(this);

            operacaoTrib = new OperacaoTributaria();
            operacaoTrib.Novo();
            txtCodigo.Text = Convert.ToString(operacaoTrib.Codigo + 1);

            geral.AcaoBotoes(ToolStrip1, "Novo");
            txtCodigo.Enabled = false;
            dgOperacaoTributaria.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja realmente salvar este registro?", "CONFIRMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                operacaoTrib = new OperacaoTributaria();
                operacaoTrib.Codigo = Convert.ToInt32(txtCodigo.Text);
                operacaoTrib.Descricao = txtDescricao.Text;
                operacaoTrib.Observacao = txtObservacao.Text;
                operacaoTrib.Normal = rbNormal.Checked;
                operacaoTrib.Complementar = rbComplementar.Checked;
                operacaoTrib.Ajuste = rbAjuste.Checked;
                if (rbOpNormal.Checked)
                {
                    operacaoTrib.OperacaoNFe = "0";
                }
                else
                {
                    operacaoTrib.OperacaoNFe = "1";
                }

                if (rbCusto.Checked)
                {
                    operacaoTrib.PrecoUsado = "1";
                }
                else
                {
                    operacaoTrib.PrecoUsado = "2";
                }

                if (rbEntrada.Checked)
                {
                    operacaoTrib.TipoEntradaSaida = "E";
                }
                else
                {
                    operacaoTrib.TipoEntradaSaida = "S";
                }

                if (rbCliente.Checked)
                {
                    operacaoTrib.Destinatario = "1";
                }
                else
                {
                    operacaoTrib.Destinatario = "2";
                }

                if (rbInterno.Checked)
                {
                    operacaoTrib.Destino = "1";
                }
                else if (rbInterestadual.Checked)
                {
                    operacaoTrib.Destino = "2";
                }
                else
                {
                    operacaoTrib.Destino = "3";
                }

                if (operacaoTrib.SalvaAtualizaExclui() == true)
                {
                    cstCodigo = new CstNFe();
                    foreach (DataRow linha in tbCst.Rows)
                    {
                        cstCodigo.CodigoNaturezaOperacao = int.Parse(txtCodigo.Text);
                        cstCodigo.CodigoOrigemMercadoria = (OrigemMercadoriaNFe)linha["OrigemMercadoria"];
                        cstCodigo.ModBC = int.Parse(linha["Modalidade"].ToString());
                        cstCodigo.PIcms = decimal.Parse(linha["AliquotaICMS"].ToString());
                        cstCodigo.PFCP = decimal.Parse(linha["PFCP"].ToString());
                    }
                    cstCodigo.CST = Convert.ToString(cboICMS.SelectedValue);

                    cstCodigo.SalvaAtualizaExcluiCst();
                }

                CarregaGrid();

                if (geral == null)
                {
                    geral = new Geral();
                }
                geral.DestativaControles(this);
                geral.AcaoBotoes(ToolStrip1, "Salvar");
                dgOperacaoTributaria.Enabled = true;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Geral.TipoReg = 'A';
            if (geral == null)
            {
                geral = new Geral();
            }

            geral.AtivaControles(this);
            geral.AcaoBotoes(ToolStrip1, "Alterar");
            txtCodigo.Enabled = false;
            dgOperacaoTributaria.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Geral.TipoReg = 'E';

            if (DialogResult.Yes == MessageBox.Show("Deseja excluir o registro selecionado?", "CONFIRMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (geral == null)
                {
                    geral = new Geral();
                }
                operacaoTrib = new OperacaoTributaria();
                operacaoTrib.Codigo = Convert.ToInt32(txtCodigo.Text);
                if (operacaoTrib.SalvaAtualizaExclui() == true)
                {
                    cstCodigo = new CstNFe();
                    cstCodigo.CST = Convert.ToString(cboICMS.SelectedValue);
                    cstCodigo.SalvaAtualizaExcluiCst();

                }
                CarregaGrid();
                geral.DestativaControles(this);
                geral.AcaoBotoes(ToolStrip1, "Excluir");
                dgOperacaoTributaria.Enabled = true;
            }
            else
            {
                geral.DestativaControles(this);
                geral.AcaoBotoes(ToolStrip1, "Excluir");
                dgOperacaoTributaria.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (geral == null)
            {
                geral = new Geral();
            }
            geral.DestativaControles(this);
            geral.AcaoBotoes(ToolStrip1, "Cancelar");
            dgOperacaoTributaria.Enabled = true;
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmOperacaoTributaria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //OrigemMercadoriaNFe valor = OrigemMercadoriaNFe.Estrangeira_Importacao_direta;
            //int teste = (int)valor;
            //MessageBox.Show(teste.ToString(), "teste", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cstCodigo = new CstNFe();
            foreach (DataRow linha in tbCst.Rows)
            {
                cstCodigo.CodigoNaturezaOperacao = int.Parse(txtCodigo.Text);
                cstCodigo.CodigoOrigemMercadoria = (OrigemMercadoriaNFe)linha["OrigemMercadoria"];
                int teste = (int)cstCodigo.CodigoOrigemMercadoria;
                cstCodigo.CodigoOrigemMercadoria = (OrigemMercadoriaNFe)teste;
                //cstCodigo.CodigoOrigemMercadoria = int.Parse(linha["OrigemMercadoria"].ToString());
                cstCodigo.ModBC = int.Parse(linha["Modalidade"].ToString());
                cstCodigo.PIcms = decimal.Parse(linha["AliquotaICMS"].ToString());
                cstCodigo.PFCP = decimal.Parse(linha["PFCP"].ToString());
            }
        }
    }
}
