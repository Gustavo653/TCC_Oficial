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
    public partial class TelaNovoUsuario : Form
    {
        public TelaNovoUsuario()
        {
            InitializeComponent();
        }

        private void TelaNovoUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }


    }
}
