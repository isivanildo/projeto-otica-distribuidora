﻿using System;
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
    public partial class FrmICMS51 : Form
    {
        public FrmICMS51()
        {
            InitializeComponent();
            cboOrigemICMS51.SelectedIndex = 0; // Origem da Mercadoria (0-Nacional, 1-Estrangeira, 2-Estrangeira adiquirida no Merc.
            txtCSTICMS51.Text = "51"; // Tipo da Tributação do ICMS (00 - Integralmente) - ver outras formas no Manual
            cboModalidadeICMS51.SelectedIndex = 0; // Modalidade de determinação da Base de Cálculo - ver Manual
            txtpRedBCICMS51.Text = "0.01"; // Percentual de Reducao da BC
            txtValorBCICMS51.Text = "0.91"; // Valor da Base de Cálculo do ICMS
            txtAliquotaICMS51.Text = "7.00"; // Alíquota do ICMS em Percentual
            txtValorICMS51.Text = "0.06"; // Valor do ICMS em Reais
            txtvICMSOp51.Text = "0.01"; // Valor do ICMS da Operação
            edtvICMS51Dif.Text = "0.00"; // Valor do ICMS Diferido
            edtPercentualDifICMS51.Text = "100"; // Percentual do Diferimento
            txtvBCFCP51.Text = "0.00"; // Valor da Base de Cálculo FCP
            txtpFCP51.Text = "0.00"; // Percentual do FCP
            txtvFCP51.Text = "0.00"; // Valor do FCP       
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
