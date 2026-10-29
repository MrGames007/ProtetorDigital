using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProtetorDigital.Forms
{
    public partial class FrmBiblioteca : Form
    {
        private Form _janelaOrigem;
        public FrmBiblioteca(Form origem)
        {
            InitializeComponent();
            ProtetorDigital.Services.JanelaPadrao.Registrar(this);
            _janelaOrigem = origem;
            MinimumSize = new Size(800, 600);
            MaximizeBox = true;
            StartPosition = FormStartPosition.CenterScreen;
            Controls.Clear();
            var layout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoSize = false,
                ColumnCount = 3,
                RowCount = 5,
                Padding = new Padding(0)
            };
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60));
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 18));
            for (var i = 1; i < 5; i++) layout.RowStyles.Add(new RowStyle(SizeType.Percent, 20.5f));
            label1.Dock = BtnDicas.Dock = BtnRelatos.Dock = BtnExGolpe.Dock = DockStyle.Fill;
            BtnVoltar.Dock = DockStyle.Fill;
            label1.Margin = BtnVoltar.Margin = BtnDicas.Margin = BtnRelatos.Margin = BtnExGolpe.Margin = new Padding(8);
            layout.Controls.Add(label1, 1, 0);
            layout.Controls.Add(BtnExGolpe, 1, 1);
            layout.Controls.Add(BtnDicas, 1, 2);
            layout.Controls.Add(BtnRelatos, 1, 3);
            layout.Controls.Add(BtnVoltar, 1, 4);
            Controls.Add(layout);
            ProtetorDigital.Services.Responsivo.Registrar(this, new Size(1000, 700));
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            _janelaOrigem.Show();
            this.Close();
        }

        private void BtnRelatos_Click(object sender, EventArgs e)
        {
            var frmRelatos = new FrmRelatos(this);
            frmRelatos.Show();
            this.Hide();
        }

        private void BtnDicas_Click(object sender, EventArgs e)
        {
            var frmDicas = new FrmDicas(this);
            frmDicas.Show();
            this.Hide();
        }

        private void BtnExGolpe_Click(object sender, EventArgs e)
        {
            var frmExGolpe = new FrmExGolpes(this);
            frmExGolpe.Show();
            this.Hide();
        }
    }
}

