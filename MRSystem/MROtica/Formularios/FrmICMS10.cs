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
    public partial class FrmICMS10 : Form
    {
        public FrmICMS10()
        {
            InitializeComponent();
            cboOrigemICMS10.SelectedIndex = 0;
            txtCSTICMS10.Text = "10";
            cboModalidadeICMS10.SelectedIndex = 0;
            txtValorBCICMS10.Text = "0.91";
            txtAliquotaICMS10.Text = "7.00";
            txtValorICMS10.Text = "0.06";
            cboModSTICMS10.SelectedIndex = 4;
            txtpMVASTICMS10.Text = "10.00";
            txtpRedBCSTICMS10.Text = "10.00";
            txtvBCSTICMS10.Text = "0.00";
            txtpICMSSTICMS10.Text = "0.00";
            txtvICMSSTICMS10.Text = "0.00";
            txtpFCP10.Text = "0.00";
            txtvFCP10.Text = "0.00";
            txtvBCFCPST10.Text = "0.00";
            txtpFCPST10.Text = "0.00";
            txtvFCPST10.Text = "0.00";
            txtvBCFCP10.Text = "0.00";
        }

        private void FrmICMS10_Load(object sender, EventArgs e)
        {

        }
    }
}
