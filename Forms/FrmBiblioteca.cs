using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace p2elvio.Forms
{
    public partial class FrmBiblioteca : Form
    {
        private Form _janelaOrigem;
        public FrmBiblioteca(Form origem)
        {
            InitializeComponent();
            _janelaOrigem = origem;
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            _janelaOrigem.Show();
            this.Close();
        }
    }
}

