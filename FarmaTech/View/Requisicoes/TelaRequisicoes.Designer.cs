﻿
namespace FarmaTech.View.Principal
{
    partial class TelaRequisicoes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaRequisicoes));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtPesquisaUsuario = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.dgRequisicoes = new System.Windows.Forms.DataGridView();
            this.NomeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilialCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssuntoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RespostaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabRequisicoes = new System.Windows.Forms.TabPage();
            this.btnResponder = new System.Windows.Forms.Button();
            this.tabResposta = new System.Windows.Forms.TabPage();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblFilial = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.txtResposta = new System.Windows.Forms.TextBox();
            this.lblResposta = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.lblAssunto = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNovaRec = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgRequisicoes)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabRequisicoes.SuspendLayout();
            this.tabResposta.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImage = global::FarmaTech.Properties.Resources.BotaoHome;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(26, 60);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(95, 95);
            this.btnVoltar.TabIndex = 89;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtPesquisaUsuario
            // 
            this.txtPesquisaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaUsuario.Location = new System.Drawing.Point(243, 39);
            this.txtPesquisaUsuario.Name = "txtPesquisaUsuario";
            this.txtPesquisaUsuario.Size = new System.Drawing.Size(300, 26);
            this.txtPesquisaUsuario.TabIndex = 95;
            this.txtPesquisaUsuario.TextChanged += new System.EventHandler(this.txtPesquisaUsuario_TextChanged);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.lblPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisar.Location = new System.Drawing.Point(144, 42);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(93, 20);
            this.lblPesquisar.TabIndex = 94;
            this.lblPesquisar.Text = "Pesquisar:";
            // 
            // dgRequisicoes
            // 
            this.dgRequisicoes.AllowUserToAddRows = false;
            this.dgRequisicoes.AllowUserToDeleteRows = false;
            this.dgRequisicoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRequisicoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeCol,
            this.FilialCol,
            this.DataCol,
            this.AssuntoCol,
            this.RespostaCol});
            this.dgRequisicoes.Location = new System.Drawing.Point(63, 108);
            this.dgRequisicoes.Name = "dgRequisicoes";
            this.dgRequisicoes.ReadOnly = true;
            this.dgRequisicoes.Size = new System.Drawing.Size(760, 332);
            this.dgRequisicoes.TabIndex = 93;
            // 
            // NomeCol
            // 
            this.NomeCol.HeaderText = "Nome";
            this.NomeCol.Name = "NomeCol";
            this.NomeCol.ReadOnly = true;
            this.NomeCol.Width = 150;
            // 
            // FilialCol
            // 
            this.FilialCol.HeaderText = "Filial";
            this.FilialCol.Name = "FilialCol";
            this.FilialCol.ReadOnly = true;
            this.FilialCol.Width = 150;
            // 
            // DataCol
            // 
            this.DataCol.HeaderText = "Data";
            this.DataCol.Name = "DataCol";
            this.DataCol.ReadOnly = true;
            // 
            // AssuntoCol
            // 
            this.AssuntoCol.HeaderText = "Assunto";
            this.AssuntoCol.Name = "AssuntoCol";
            this.AssuntoCol.ReadOnly = true;
            this.AssuntoCol.Width = 200;
            // 
            // RespostaCol
            // 
            this.RespostaCol.HeaderText = "Resposta";
            this.RespostaCol.Name = "RespostaCol";
            this.RespostaCol.ReadOnly = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvar.BackgroundImage")));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(26, 172);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(95, 95);
            this.btnSalvar.TabIndex = 96;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabRequisicoes);
            this.tabControl1.Controls.Add(this.tabResposta);
            this.tabControl1.Location = new System.Drawing.Point(141, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(925, 519);
            this.tabControl1.TabIndex = 97;
            // 
            // tabRequisicoes
            // 
            this.tabRequisicoes.BackColor = System.Drawing.Color.Lavender;
            this.tabRequisicoes.Controls.Add(this.dgRequisicoes);
            this.tabRequisicoes.Controls.Add(this.txtPesquisaUsuario);
            this.tabRequisicoes.Controls.Add(this.btnResponder);
            this.tabRequisicoes.Controls.Add(this.lblPesquisar);
            this.tabRequisicoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tabRequisicoes.Location = new System.Drawing.Point(4, 22);
            this.tabRequisicoes.Name = "tabRequisicoes";
            this.tabRequisicoes.Padding = new System.Windows.Forms.Padding(3);
            this.tabRequisicoes.Size = new System.Drawing.Size(917, 493);
            this.tabRequisicoes.TabIndex = 0;
            this.tabRequisicoes.Text = "Requisições";
            this.tabRequisicoes.Paint += new System.Windows.Forms.PaintEventHandler(this.tabRequisicoes_Paint);
            // 
            // btnResponder
            // 
            this.btnResponder.BackColor = System.Drawing.Color.Transparent;
            this.btnResponder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnResponder.BackgroundImage")));
            this.btnResponder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnResponder.FlatAppearance.BorderSize = 0;
            this.btnResponder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResponder.Location = new System.Drawing.Point(587, -12);
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.Size = new System.Drawing.Size(143, 142);
            this.btnResponder.TabIndex = 98;
            this.btnResponder.UseVisualStyleBackColor = false;
            this.btnResponder.Click += new System.EventHandler(this.btnResponder_Click);
            // 
            // tabResposta
            // 
            this.tabResposta.BackColor = System.Drawing.Color.Lavender;
            this.tabResposta.Controls.Add(this.lblUsuario);
            this.tabResposta.Controls.Add(this.lblFilial);
            this.tabResposta.Controls.Add(this.lblData);
            this.tabResposta.Controls.Add(this.txtResposta);
            this.tabResposta.Controls.Add(this.lblResposta);
            this.tabResposta.Controls.Add(this.label25);
            this.tabResposta.Controls.Add(this.txtDescricao);
            this.tabResposta.Controls.Add(this.lblDescricao);
            this.tabResposta.Controls.Add(this.txtAssunto);
            this.tabResposta.Controls.Add(this.lblAssunto);
            this.tabResposta.Controls.Add(this.label36);
            this.tabResposta.Controls.Add(this.label4);
            this.tabResposta.Location = new System.Drawing.Point(4, 22);
            this.tabResposta.Name = "tabResposta";
            this.tabResposta.Padding = new System.Windows.Forms.Padding(3);
            this.tabResposta.Size = new System.Drawing.Size(917, 493);
            this.tabResposta.TabIndex = 1;
            this.tabResposta.Text = "Resposta";
            this.tabResposta.Paint += new System.Windows.Forms.PaintEventHandler(this.tabResposta_Paint);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.Location = new System.Drawing.Point(543, 31);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(57, 20);
            this.lblUsuario.TabIndex = 34;
            this.lblUsuario.Text = "label3";
            // 
            // lblFilial
            // 
            this.lblFilial.AutoSize = true;
            this.lblFilial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblFilial.Location = new System.Drawing.Point(216, 88);
            this.lblFilial.Name = "lblFilial";
            this.lblFilial.Size = new System.Drawing.Size(57, 20);
            this.lblFilial.TabIndex = 33;
            this.lblFilial.Text = "label2";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblData.Location = new System.Drawing.Point(216, 25);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(57, 20);
            this.lblData.TabIndex = 32;
            this.lblData.Text = "label1";
            // 
            // txtResposta
            // 
            this.txtResposta.Location = new System.Drawing.Point(229, 343);
            this.txtResposta.Multiline = true;
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.Size = new System.Drawing.Size(527, 79);
            this.txtResposta.TabIndex = 31;
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblResposta.Location = new System.Drawing.Point(116, 341);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(91, 20);
            this.lblResposta.TabIndex = 30;
            this.lblResposta.Text = "Resposta:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label25.Location = new System.Drawing.Point(159, 88);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(51, 20);
            this.label25.TabIndex = 28;
            this.label25.Text = "Filial:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Location = new System.Drawing.Point(230, 202);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(527, 79);
            this.txtDescricao.TabIndex = 27;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblDescricao.Location = new System.Drawing.Point(116, 200);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(94, 20);
            this.lblDescricao.TabIndex = 26;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtAssunto
            // 
            this.txtAssunto.Enabled = false;
            this.txtAssunto.Location = new System.Drawing.Point(230, 149);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(527, 20);
            this.txtAssunto.TabIndex = 25;
            // 
            // lblAssunto
            // 
            this.lblAssunto.AutoSize = true;
            this.lblAssunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblAssunto.Location = new System.Drawing.Point(130, 147);
            this.lblAssunto.Name = "lblAssunto";
            this.lblAssunto.Size = new System.Drawing.Size(80, 20);
            this.lblAssunto.TabIndex = 24;
            this.lblAssunto.Text = "Assunto:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label36.Location = new System.Drawing.Point(461, 31);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(76, 20);
            this.label36.TabIndex = 22;
            this.label36.Text = "Usuário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(157, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Data:";
            // 
            // lblNovaRec
            // 
            this.lblNovaRec.AutoSize = true;
            this.lblNovaRec.BackColor = System.Drawing.Color.Transparent;
            this.lblNovaRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovaRec.Location = new System.Drawing.Point(860, 9);
            this.lblNovaRec.Name = "lblNovaRec";
            this.lblNovaRec.Size = new System.Drawing.Size(174, 36);
            this.lblNovaRec.TabIndex = 99;
            this.lblNovaRec.Text = "Requisição";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lblHora);
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 596);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1105, 30);
            this.panel2.TabIndex = 100;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblHora.Location = new System.Drawing.Point(1000, 8);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(34, 13);
            this.lblHora.TabIndex = 87;
            this.lblHora.Text = "Hora";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblDate.Location = new System.Drawing.Point(12, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(34, 13);
            this.lblDate.TabIndex = 86;
            this.lblDate.Text = "Data";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TelaRequisicoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 626);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblNovaRec);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaRequisicoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:Requisições";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TelaRequisicoes_FormClosed);
            this.Load += new System.EventHandler(this.TelaRequisicoes_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TelaRequisicoes_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgRequisicoes)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabRequisicoes.ResumeLayout(false);
            this.tabRequisicoes.PerformLayout();
            this.tabResposta.ResumeLayout(false);
            this.tabResposta.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtPesquisaUsuario;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.DataGridView dgRequisicoes;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabRequisicoes;
        private System.Windows.Forms.TabPage tabResposta;
        private System.Windows.Forms.TextBox txtResposta;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.Label lblAssunto;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFilial;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnResponder;
        private System.Windows.Forms.Label lblNovaRec;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilialCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssuntoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn RespostaCol;
    }
}