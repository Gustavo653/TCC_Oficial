﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaTech.View.Principal
{
    public partial class TelaRequisicoes : Form
    {
        public TelaRequisicoes()
        {
            InitializeComponent();
        }

        private void TelaRequisicoes_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void TelaRequisicoes_Paint(object sender, PaintEventArgs e)
        {
            SetBackColorDegrade(sender, e);

        }


        private void SetBackColorDegrade(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics; Rectangle gradient_rect = new Rectangle(0, 0, Width, Height);
            //RGB vermelho verde azul
            Brush br = new LinearGradientBrush(gradient_rect, Color.FromArgb(103, 23, 205), Color.FromArgb(108, 226, 252), 45f);
            graphics.FillRectangle(br, gradient_rect);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Contains(tabResposta))
            {
                tabControl1.TabPages.Remove(tabResposta);
                tabControl1.TabPages.Add(tabRequisicoes);
           
            }
            else
            {
                this.Hide();
            }
        }


        private void TelaRequisicoes_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabResposta);
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabRequisicoes);
            tabControl1.TabPages.Add(tabResposta);
        }
    }
}
