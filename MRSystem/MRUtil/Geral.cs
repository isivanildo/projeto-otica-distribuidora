using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Globalization;

namespace MRUtil
{
    public class Geral
    {
        public static Belemtech.TiposReg TipoReg { get; set; }
        public bool DDLInicializa { get; set; }
        public Belemtech.TiposReg AcaoAnterior {get; set;}

        public void AtivaControles(Control controle)
        {
            foreach (Control ctl in controle.Controls)
            {
                if (ctl is TextBox) ctl.Enabled = true;
                if (ctl is TextBox) (ctl as TextBox).CharacterCasing = CharacterCasing.Upper;
                if (ctl is ComboBox) ctl.Enabled = true;
                if (ctl is MaskedTextBox) ctl.Enabled = true;
                if (ctl is CheckBox) ctl.Enabled = true;
                if (ctl is ListBox) ctl.Enabled = true;
                if (ctl is TreeView) ctl.Enabled = true;

                if (Geral.TipoReg == Belemtech.TiposReg.Novo)
                {
                    if (ctl is TextBox) ctl.Text = "";
                    if (ctl is MaskedTextBox) ctl.Text = "";
                    if (ctl is ComboBox) (ctl as ComboBox).SelectedIndex = -1;
                    if (ctl is RadioButton) (ctl as RadioButton).Checked = false;
                    if (ctl is TreeView) (ctl as TreeView).Enabled = true;
                    if (ctl is CheckBox) (ctl as CheckBox).Enabled = true;
                    if (ctl is ListBox) (ctl as ListBox).Enabled = true;
                    if (ctl is TreeView) (ctl as TreeView).Nodes.Clear();
                }

                if (ctl.Controls.Count > 0)
                {
                    AtivaControles(ctl);
                }
            }
        }

        public void DesativaControles(Control controle)
        {
            foreach (Control ctl in controle.Controls)
            {
                if (ctl is TextBox) ctl.Enabled = false;
                if (ctl is ComboBox) ctl.Enabled = false;
                if (ctl is TreeView) (ctl as TreeView).Enabled = false;
                if (ctl is MaskedTextBox) ctl.Enabled = false;
                if (ctl is CheckBox) ctl.Enabled = false;
                if (ctl is ListBox) ctl.Enabled = false;

                if (ctl.Controls.Count > 0)
                {
                    DesativaControles(ctl);
                }
            }
        }

        public void LimpaTextBox(Control controle)
        {
            foreach (Control ctl in controle.Controls)
            {
                if (ctl is TextBox) ctl.Text = string.Empty;
                if (ctl is MaskedTextBox) ctl.Text = string.Empty;
                if (ctl is ComboBox) (ctl as ComboBox).SelectedIndex = -1;

                if (ctl.Controls.Count > 0)
                {
                    LimpaTextBox(ctl);
                }
            }
        }

        public void AcaoBotoesNormal(Control xBotao, Belemtech.TiposReg xAcao)
        {
            foreach (Control botao in xBotao.Controls)
            {
                if (botao is Button)
                {
                    if (xAcao == Belemtech.TiposReg.Novo)
                    {
                        switch (botao.Name)
                        {
                            case "btnNovo":
                                botao.Enabled = false;
                                break;
                            case "btnSalvar":
                                botao.Enabled = true;
                                break;
                            case "btnAlterar":
                                botao.Enabled = false;
                                break;
                            case "btnExcluir":
                                botao.Enabled = false;
                                break;
                            case "btnCancelar":
                                botao.Enabled = true;
                                break;
                            case "btnAddPromotor":
                                botao.Enabled = true;
                                break;
                            case "btnAddCompra":
                                botao.Enabled = true;
                                break;
                            case "btnNovoPacote":
                                botao.Enabled = false;
                                break;
                            case "btnExcluirPacote":
                                botao.Enabled = false;
                                break;
                            case "btnConcluirPacote":
                                botao.Enabled = false;
                                break;
                            case "btnImprimirPacote":
                                botao.Enabled = false;
                                break;
                            case "btnCancelarPacote":
                                botao.Enabled = true;
                                break;
                            case "btnAddItemProduto":
                                botao.Enabled = true;
                                break;
                            case "btnExcluirItemProduto":
                                botao.Enabled = true;
                                break;
                            case "btnAddItemSurfacagem":
                                botao.Enabled = true;
                                break;
                            case "btnExcluirItemSurfacagem":
                                botao.Enabled = true;
                                break;
                            case "btnAddItemMontagem":
                                botao.Enabled = true;
                                break;
                            case "btnExcluirItemMontagem":
                                botao.Enabled = true;
                                break;
                            case "btnAddItemTratamento":
                                botao.Enabled = true;
                                break;
                            case "btnExcluirItemTratamento":
                                botao.Enabled = true;
                                break;
                        }
                    } else if (xAcao == Belemtech.TiposReg.Salvar)
                    {
                        switch (botao.Name)
                        {
                            case "btnNovo":
                                botao.Enabled = true;
                                break;
                            case "btnSalvar":
                                botao.Enabled = false;
                                break;
                            case "btnAlterar":
                                botao.Enabled = true;
                                break;
                            case "btnExcluir":
                                botao.Enabled = false;
                                break;
                            case "btnCancelar":
                                botao.Enabled = false;
                                break;
                            case "btnSair":
                                botao.Enabled = true;
                                break;
                        }

                    } else if (xAcao == Belemtech.TiposReg.Alterar)
                    {
                        switch (botao.Name)
                        {
                            case "btnNovo":
                                botao.Enabled = false;
                                break;
                            case "btnSalvar":
                                botao.Enabled = true;
                                break;
                            case "btnAlterar":
                                botao.Enabled = false;
                                break;
                            case "btnExcluir":
                                botao.Enabled = true;
                                break;
                            case "btnCancelar":
                                botao.Enabled = true;
                                break;
                            case "btnAddPromotor":
                                botao.Enabled = true;
                                break;
                            case "btnAddCompra":
                                botao.Enabled = true;
                                break;
                            case "btnNovoPacote":
                                botao.Enabled = false;
                                break;
                            case "btnExcluirPacote":
                                botao.Enabled = true;
                                break;
                            case "btnConcluirPacote":
                                botao.Enabled = true;
                                break;
                            case "btnImprimirPacote":
                                botao.Enabled = true;
                                break;
                            case "btnCancelarPacote":
                                botao.Enabled = true;
                                break;
                            case "btnAddItemProduto":
                                botao.Enabled = true;
                                break;
                            case "btnExcluirItemProduto":
                                botao.Enabled = true;
                                break;
                            case "btnAddItemSurfacagem":
                                botao.Enabled = true;
                                break;
                            case "btnExcluirItemSurfacagem":
                                botao.Enabled = true;
                                break;
                            case "btnAddItemMontagem":
                                botao.Enabled = true;
                                break;
                            case "btnExcluirItemMontagem":
                                botao.Enabled = true;
                                break;
                            case "btnAddItemTratamento":
                                botao.Enabled = true;
                                break;
                            case "btnExcluirItemTratamento":
                                botao.Enabled = true;
                                break;
                        }
                    } else if ((xAcao == Belemtech.TiposReg.Excluir) || (xAcao == Belemtech.TiposReg.Cancelar))
                    {
                        switch (botao.Name)
                        {
                            case "btnNovo":
                                botao.Enabled = true;
                                break;
                            case "btnSalvar":
                                botao.Enabled = false;
                                break;
                            case "btnAlterar":
                                if (AcaoAnterior == Belemtech.TiposReg.Novo)
                                {
                                    botao.Enabled = false;      
                                } else
                                {
                                    botao.Enabled = true;
                                }
                                break;
                            case "btnExcluir":
                                botao.Enabled = false;
                                break;
                            case "btnCancelar":
                                botao.Enabled = false;
                                break;
                            case "btnAddPromotor":
                                botao.Enabled = false;
                                break;
                            case "btnAddCompra":
                                botao.Enabled = false;
                                break;
                            case "btnNovoPacote":
                                botao.Enabled = true;
                                break;
                            case "btnExcluirPacote":
                                if ((AcaoAnterior == Belemtech.TiposReg.Novo) || (AcaoAnterior == Belemtech.TiposReg.Alterar))
                                {
                                    botao.Enabled = false;
                                }
                                else
                                {
                                    botao.Enabled = true;
                                }     
                                break;
                            case "btnConcluirPacote":
                                if ((AcaoAnterior == Belemtech.TiposReg.Novo) || (AcaoAnterior == Belemtech.TiposReg.Alterar))
                                {
                                    botao.Enabled = false;
                                }
                                else
                                {
                                    botao.Enabled = true;
                                }
                                break;
                            case "btnImprimirPacote":
                                if ((AcaoAnterior == Belemtech.TiposReg.Novo) || (AcaoAnterior == Belemtech.TiposReg.Alterar))
                                {
                                    botao.Enabled = false;
                                }
                                else
                                {
                                    botao.Enabled = true;
                                }
                                break;
                            case "btnCancelarPacote":
                                if ((AcaoAnterior == Belemtech.TiposReg.Novo) || (AcaoAnterior == Belemtech.TiposReg.Alterar))
                                {
                                    botao.Enabled = false;
                                }
                                else
                                {
                                    botao.Enabled = true;
                                }
                                break;
                            case "btnAddItemProduto":
                                botao.Enabled = false;
                                break;
                            case "btnExcluirItemProduto":
                                botao.Enabled = false;
                                break;
                            case "btnAddItemSurfacagem":
                                botao.Enabled = false;
                                break;
                            case "btnExcluirItemSurfacagem":
                                botao.Enabled = false;
                                break;
                            case "btnAddItemMontagem":
                                botao.Enabled = false;
                                break;
                            case "btnExcluirItemMontagem":
                                botao.Enabled = false;
                                break;
                            case "btnAddItemTratamento":
                                botao.Enabled = false;
                                break;
                            case "btnExcluirItemTratamento":
                                botao.Enabled = false;
                                break;
                        }
                    } else if (xAcao == Belemtech.TiposReg.EntrarPacote)
                    {
                        switch (botao.Name)
                        {
                            case "btnNovoPacote":
                                botao.Enabled = true;
                                break;
                            case "btnExcluirPacote":
                                botao.Enabled = false;
                                break;
                            case "btnConcluirPacote":
                                botao.Enabled = false;
                                break;
                            case "btnImprimirPacote":
                                botao.Enabled = false;
                                break;
                        }
                    }
                }

                if (botao.Controls.Count > 0)
                {
                    AcaoBotoesNormal(botao, xAcao);
                }
            }
        }

        public void AcaoBotoes(ToolStrip xControle, Belemtech.TiposReg xAcao)
        {
            foreach (ToolStripItem item in xControle.Items)
            {
                if (xAcao == Belemtech.TiposReg.Novo)
                {
                    switch (item.Name)
                    {
                        case "btnNovo":
                            item.Enabled = false;
                            break;
                        case "btnSalvar":
                            item.Enabled = true;
                            break;
                        case "btnAlterar":
                            item.Enabled = false;
                            break;
                        case "btnExcluir":
                            item.Enabled = false;
                            break;
                        case "btnCancelar":
                            item.Enabled = true;
                            break;
                        case "btnSair":
                            item.Enabled = false;
                            break;
                    }
                }
                else if (xAcao == Belemtech.TiposReg.Salvar)
                {
                    switch (item.Name)
                    {
                        case "btnNovo":
                            item.Enabled = true;
                            break;
                        case "btnSalvar":
                            item.Enabled = false;
                            break;
                        case "btnAlterar":
                            item.Enabled = true;
                            break;
                        case "btnExcluir":
                            item.Enabled = false;
                            break;
                        case "btnCancelar":
                            item.Enabled = false;
                            break;
                        case "btnSair":
                            item.Enabled = true;
                            break;
                    }
                }
                else if (xAcao == Belemtech.TiposReg.Alterar)
                {
                    switch (item.Name)
                    {
                        case "btnNovo":
                            item.Enabled = false;
                            break;
                        case "btnSalvar":
                            item.Enabled = true;
                            break;
                        case "btnAlterar":
                            item.Enabled = false;
                            break;
                        case "btnExcluir":
                            item.Enabled = true;
                            break;
                        case "btnCancelar":
                            item.Enabled = true;
                            break;
                        case "btnSair":
                            item.Enabled = false;
                            break;
                    }
                }
                else if ((xAcao == Belemtech.TiposReg.Excluir) || (xAcao == Belemtech.TiposReg.Cancelar))
                {
                    switch (item.Name)
                    {
                        case "btnNovo":
                            item.Enabled = true;
                            break;
                        case "btnSalvar":
                            item.Enabled = false;
                            break;
                        case "btnAlterar":
                            item.Enabled = true;
                            break;
                        case "btnExcluir":
                            item.Enabled = false;
                            break;
                        case "btnCancelar":
                            item.Enabled = false;
                            break;
                        case "btnSair":
                            item.Enabled = true;
                            break;
                    }
                }
                else if (xAcao == Belemtech.TiposReg.NovoDoc)
                {
                    switch (item.Name)
                    {
                        case "btnNovoeDoc":
                            item.Enabled = false;
                            break;
                        case "btnGerar":
                            item.Enabled = true;
                            break;
                        case "btnEmitirNFe":
                            item.Enabled = false;
                            break;
                        case "btnImprimirNFe":
                            item.Enabled = false;
                            break;
                    }
                }
                else if (xAcao == Belemtech.TiposReg.GerarNFE)
                {
                    switch (item.Name)
                    {
                        case "btnNovoeDoc":
                            item.Enabled = false;
                            break;
                        case "btnGerar":
                            item.Enabled = false;
                            break;
                        case "btnEmitirNFe":
                            item.Enabled = true;
                            break;
                        case "btnImprimirNFe":
                            item.Enabled = false;
                            break;
                    }
                }
                else if (xAcao == Belemtech.TiposReg.EmitirNFE)
                {
                    switch (item.Name)
                    {
                        case "btnNovoeDoc":
                            item.Enabled = true;
                            break;
                        case "btnGerar":
                            item.Enabled = false;
                            break;
                        case "btnEmitirNFe":
                            item.Enabled = false;
                            break;
                        case "btnImprimirNFe":
                            item.Enabled = true;
                            break;
                    }
                }
            }
        }

        public static string AspasSQL(string texto)
        {
            if (!string.IsNullOrEmpty(texto))
            {
                texto = "'" + texto + "'";
            }
            else
            {
                texto = "NULL";
            }

            return texto;
        }

        public static string NumeroSQL(int? texto)
        {
            string resultado = string.Empty;

            if (texto != null)
            {
                resultado = texto.Value.ToString();
            }
            else
            {
                resultado = "NULL";
            }

            return resultado;
        }

        public static string DataSQL(string valor)
        {
            string resultado;

            if (!string.IsNullOrEmpty(valor))
            {
                DateTime data = Convert.ToDateTime(valor);
                string formato = data.Year + data.Month.ToString().PadLeft(2, '0') + data.Day.ToString().PadLeft(2, '0') +
                    " " + data.Hour.ToString().PadLeft(2, '0') + ":" + data.Minute.ToString().PadLeft(2, '0') + ":" + data.Second.ToString().PadLeft(2, '0');
                resultado = "'" + formato + "'";
            }
            else
            {
                resultado = "NULL";
            }

            return resultado;
        }

        public static string ValorMoeda(decimal? valor)
        {
            string resultado = string.Empty;

            if (valor.HasValue)
            {
                resultado = valor.ToString().Replace(",", ".");
            }
            else
            {
                resultado = "NULL";
            }

            return resultado;
        }

        public static int? FormataNumero(string texto)
        {
            int? resultado = null;

            if (!string.IsNullOrEmpty(texto))
            {
                resultado = Convert.ToInt32(texto);
            }
            else
            {
                resultado = null;
            }

            return resultado;
        }

        public static string RetornaSoNumero(string valor)
        {
            char[] caracter = valor.ToCharArray();

            string resultado = "";

            foreach (var car in caracter)
            {
                if (char.IsDigit(car))
                    resultado += car;
            }

            resultado = (resultado != string.Empty) ? resultado : null;

            return resultado;
        }

        /// <summary>
        /// Verifica se um dado digitado é um número
        /// </summary>
        /// <param name="xTexto">Valor passado para a função</param>
        /// <returns></returns>
        public static bool ValidaCampoNumerico(string xTexto)
        {
            char[] caracter = xTexto.ToCharArray();

            foreach (var car in caracter)
            {
                if (!char.IsDigit(car))
                    return false;
            }

            return true;
        }

    public static string FormataCNPJCPF(string cnpjcpf)
        {
            if (cnpjcpf.Length == 14)
            {
                return Convert.ToUInt64(cnpjcpf).ToString(@"00\.000\.000\/0000\-00");
            }
            else
            {
                return Convert.ToUInt64(cnpjcpf).ToString(@"000\.000\.000\-00");
            }
        }

        public static string FormataCEP(string xCep)
        {
            string strResultado = string.Empty;

            if (xCep != string.Empty)
            {
                strResultado = Convert.ToUInt64(xCep).ToString(@"00000\-000");
            }

            return strResultado;
        }

        public static string FormataTelefone(string xTelefone)
        {
            string strResultado = string.Empty;

            if (xTelefone != string.Empty)
            {
                strResultado = Convert.ToUInt64(xTelefone).ToString(@"(00) 00000\-0000");
            }

            return strResultado;
        }

        public static string RemoveCaracter(string texto)
        {
            return texto.Replace(".", "").Replace(",", "").Replace("-", "").Replace("/", "");
        }

        public static string RemoveCaracterXmlInvalidos(string text)
        {
            var validXmlChars = text.Where(ch => XmlConvert.IsXmlChar(ch)).ToArray();
            return new string(validXmlChars);
        }

        public static string FormataMoeda(decimal xValor)
        {
            return xValor.ToString("#,##0.00", CultureInfo.GetCultureInfo("pt-BR")); 
        }

        public static Belemtech.Respo TelaAviso(string mensagem, string titulo, Form frm, Belemtech.TipoAviso tipo, Belemtech.ImagemAviso ImagemIcone = 0)
        {
            Formulario.FrmAviso f = new Formulario.FrmAviso();
            f.tipo = tipo;
            f.lblMensagem.Text = mensagem;
            f.Text = titulo;
            f.imgAviso = ImagemIcone;
            f.ShowDialog(frm);
            return f.resposta;
        }

        public static string Multiplicacao(params decimal[] xValor)
        {
            decimal total = 1;
            for (int i = 0; i < xValor.Length; i++)
            {
                total *= xValor[i];
            }

            return FormataMoeda(total);
        }

        public static string Total(params decimal[] xValor)
        {
            decimal total = 0;
            for (int i = 0; i < xValor.Length; i++)
            {
                total += xValor[i];
            }

            return Geral.FormataMoeda(total);
        }

    }

}
