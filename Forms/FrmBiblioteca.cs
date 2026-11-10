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
            ProtetorDigital.Services.Suavizar.Aplicar(this);
            _janelaOrigem = origem;
            MinimumSize = new Size(800, 600);
            MaximizeBox = true;
            ProtetorDigital.Services.Responsivo.Registrar(this, new Size(1000, 700));
            BackgroundImageLayout = ImageLayout.None;
            BackgroundImage = ProtetorDigital.Services.FundoCache.Obter(BackgroundImage, ClientSize);
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            _janelaOrigem.Show();
            Close();
        }

        private void BtnRelatos_Click(object sender, EventArgs e)
        {
            using var frmRelatos = new FrmRelatos(this);
            frmRelatos.ShowDialog(this);
        }

        private void BtnDicas_Click(object sender, EventArgs e)
        {
            using var frmDicas = new FrmDicas(this);
            frmDicas.ShowDialog(this);
        }

        private void BtnExGolpe_Click(object sender, EventArgs e)
        {
            using var frmExGolpe = new FrmExGolpes(this);
            frmExGolpe.ShowDialog(this);
        }

        private void FrmBiblioteca_Load(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}

