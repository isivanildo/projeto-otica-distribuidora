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
    public partial class FrmICMS30 : Form
    {
        public FrmICMS30()
        {
            InitializeComponent();
            cboOrigemICMS30.SelectedIndex = 0; // Origem da Mercadoria (0-Nacional, 1-Estrangeira, 2-Estrangeira adiquirida no Merc. Interno)
            txtCSTICMS30.Text = "30";   // Tipo da Tributação do ICMS (00 - Integralmente) - ver outras formas no Manual
            cboModSTICMS30.SelectedIndex = 4; // Modalidade de determinacao da BC do ICMS ST
            txtpMVASTICMS30.Text = "10.00"; // Percentual da Margem e Valor Adicional do ICMS ST
            txtpRedBCSTICMS30.Text = "10.00"; // Percentual da Reducao do BC ICMS ST
            txtvBCSTICMS30.Text = "0.00"; // Valor da BC do ICMS ST
            txtpICMSSTICMS30.Text = "0.00"; // Aliquota do Impostos ICMS ST
            txtvICMSSTICMS30.Text = "0.00"; // Valor do ICMS ST
            edtvICMS30Deson.Text = "0.01"; // Valor do ICMS Desonerado
            txtvBCFCPST30.Text = "0.00"; // Valor da BC FCP ST
            txtpFCPST30.Text = "0.00"; // Percentual FCP ST
            txtvFCPST30.Text = "0.00"; // Valor FCP ST
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
