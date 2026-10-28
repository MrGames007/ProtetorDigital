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
        public FrmBiblioteca()
        {
            InitializeComponent();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnRelatos_Click(object sender, EventArgs e)
        {
            Hide();
            using var frmRelatos = new FrmRelatos();
            frmRelatos.ShowDialog(this);
            Show();
        }

        private void BtnDicas_Click(object sender, EventArgs e)
        {
            Hide();
            using var frmDicas = new FrmDicas();
            frmDicas.ShowDialog(this);
            Show();
        }

        private void BtnExGolpe_Click(object sender, EventArgs e)
        {
            Hide();
            using var frmExGolpe = new FrmExGolpes();
            frmExGolpe.ShowDialog(this);
            Show();
        }
    }
}

