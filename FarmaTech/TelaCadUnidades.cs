﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaTech
{
    public partial class TelaCadUnidades : Form
    {
        public TelaCadUnidades()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new TelaNovaUnidade().Show();
        }

        private void TelaCadUnidades_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
    }
}
