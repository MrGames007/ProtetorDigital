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
        // Hub de conteúdo: recebe o menu como origem e abre as três telas educativas.
        private Form _janelaOrigem;
        public FrmBiblioteca(Form origem)
        {
            // Serviços comuns padronizam janela, pintura, responsividade e imagem de fundo.
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
            // Fecha a biblioteca e devolve o controle ao menu que a abriu.
            _janelaOrigem.Show();
            Close();
        }

        private void BtnRelatos_Click(object sender, EventArgs e)
        {
            // Relatos é modal para preservar a biblioteca como janela de origem.
            using var frmRelatos = new FrmRelatos(this);
            frmRelatos.ShowDialog(this);
        }

        private void BtnDicas_Click(object sender, EventArgs e)
        {
            // Abre dicas usando a própria biblioteca como origem da tela filha.
            using var frmDicas = new FrmDicas(this);
            frmDicas.ShowDialog(this);
        }

        private void BtnExGolpe_Click(object sender, EventArgs e)
        {
            // Abre exemplos de golpes sem duplicar a lógica de carregamento nesta tela.
            using var frmExGolpe = new FrmExGolpes(this);
            frmExGolpe.ShowDialog(this);
        }

        private void FrmBiblioteca_Load(object sender, EventArgs e)
        {
            // O fundo passa a preencher o formulário depois que o tamanho inicial foi aplicado.
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}

