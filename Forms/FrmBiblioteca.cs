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

