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
    public partial class FrmICMSSN900 : Form
    {
        public FrmICMSSN900()
        {
            InitializeComponent();
            cboOrigemICMSSN900.SelectedIndex = 0; // Origem da Mercadoria (0-Nacional, 1-Estrangeira, 2-Estrangeira adiquirida no Merc. Interno)
            txtCSOSNICMSSN900.Text = "900";
            cbomodBCICMSSN900.SelectedIndex = 2;
            txtvBCICMSSN900.Text = "0.91";
            txtpRedBCICMSSN900.Text = "0.01";
            txtpICMSICMSSN900.Text = "7.00";
            txtvICMSICMSSN900.Text = "0.06";
            cboModSTICMSSN900.SelectedIndex = 4; // modalidade de determinação da BC do ICMS ST            
            txtpMVASTICMSSN900.Text = "10.00";
            txtpRedBCSTICMSSN900.Text = "10.00";
            txtvBCSTICMSSN900.Text = "0.00";
            txtpICMSSTICMSSN900.Text = "0.00";
            txtvICMSSTICMSSN900.Text = "0.00";
            txtpCredSNICMSSN900.Text = "0.01";
            txtvCredICMSSNICMSSN900.Text = "0.01";
            txtpFCPST900.Text = "0.00";  // Alíquota suportada pelo Consumidor Final
            txtvBCFCPST900.Text = "0.00";  // Valor da Base de Cálculo do FCP retido por ST
            txtpFCPST900.Text = "0.00";  // Percentual do FCP retido por ST
            txtvFCPST900.Text = "0.00";  // Valor do FCP retido por ST
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
