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
            _janelaOrigem = origem;
            MinimumSize = new Size(800, 600);
            MaximizeBox = true;
            StartPosition = FormStartPosition.CenterScreen;
            Controls.Clear();
            var layout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 5,
                Padding = new Padding(80, 24, 80, 24)
            };
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 18));
            for (var i = 1; i < 5; i++) layout.RowStyles.Add(new RowStyle(SizeType.Percent, 20.5f));
            label1.Dock = BtnDicas.Dock = BtnRelatos.Dock = BtnExGolpe.Dock = DockStyle.Fill;
            BtnVoltar.Dock = DockStyle.Fill;
            label1.Margin = BtnVoltar.Margin = BtnDicas.Margin = BtnRelatos.Margin = BtnExGolpe.Margin = new Padding(8);
            layout.Controls.Add(label1, 0, 0);
            layout.Controls.Add(BtnExGolpe, 0, 1);
            layout.Controls.Add(BtnDicas, 0, 2);
            layout.Controls.Add(BtnRelatos, 0, 3);
            layout.Controls.Add(BtnVoltar, 0, 4);
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

