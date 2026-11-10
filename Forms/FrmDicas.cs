using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProtetorDigital.Services;

namespace ProtetorDigital.Forms
{
    public partial class FrmDicas : Form
    {
        private List<Dica> _dicas = new();
        private int _indice = 0;

        private Form _janelaOrigem;
        public FrmDicas(Form origem)
        {
            _janelaOrigem = origem;
            InitializeComponent();
            ProtetorDigital.Services.JanelaPadrao.Registrar(this);
            ProtetorDigital.Services.Suavizar.Aplicar(this);
            BtnAvancar.Click += BtnAvancar_Click;
            BtnVoltar.Click += BtnVoltar_Click;
            Load += FrmDicas_Load;
            MinimumSize = new Size(800, 600);
            MaximizeBox = true;
            ProtetorDigital.Services.Responsivo.Registrar(this, new Size(1100, 650));
        }

        private void FrmDicas_Load(object? sender, EventArgs e)
        {
            try
            {
                _dicas = ConteudoService.CarregarLista<Dica>("dicas.json");
                MostrarDica(0);
            }
            catch (ConteudoException ex)
            {
                MessageBox.Show($"Não consegui abrir o conteúdo desta tela. Detalhe: {ex.Message}");
                Close();
            }
        }

        private void MostrarDica(int indice)
        {
            if (indice < 0 || indice >= _dicas.Count) return;
            _indice = indice;
            var d = _dicas[indice];
            lblTitulo.Text = d.Titulo ?? string.Empty;
            lblDescricao.Text = d.Descricao ?? string.Empty;
            if (d.PassosRecomendados != null && d.PassosRecomendados.Any())
            {
                var sb = new StringBuilder();
                foreach (var p in d.PassosRecomendados) sb.AppendLine("- " + p);
                lblPassos.Text = sb.ToString();
            }
            else
            {
                lblPassos.Text = string.Empty;
            }
        }

        private void BtnAvancar_Click(object? sender, EventArgs e)
        {
            if (_indice + 1 < _dicas.Count) MostrarDica(_indice + 1);
        }

        private void BtnVoltar_Click(object? sender, EventArgs e)
        {
            if (_indice - 1 >= 0) MostrarDica(_indice - 1);
            else Close();
        }

        private void BtnRetornar_Click(object? sender, EventArgs e)
        {
            _janelaOrigem.Show();
            Close();
        }

    }
}
