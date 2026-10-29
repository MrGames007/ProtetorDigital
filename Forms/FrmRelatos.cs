using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using ProtetorDigital.Services;

namespace ProtetorDigital.Forms
{
    public partial class FrmRelatos : Form
    {
        private List<Relato> _relatos = new();
        private int _indice = 0;
        private readonly ConteudoService _conteudoService = new();

        public FrmRelatos()
        {
            InitializeComponent();
            BtnAvancar.Click += BtnAvancar_Click;
            BtnVoltar.Click += BtnVoltar_Click;
            Load += FrmRelatos_Load;
            KeyPreview = true;
            KeyDown += FrmRelatos_KeyDown;
        }

        private void FrmRelatos_Load(object? sender, EventArgs e)
        {
            try
            {
                _relatos = _conteudoService.CarregarLista<Relato>("relatos.json");

                if (_relatos.Any()) MostrarRelato(0);
            }
            catch (ConteudoException ex)
            {
                MessageBox.Show($"Não foi possível carregar os relatos.\n{ex.Message}", "Conteúdo indisponível", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
        }

        private void MostrarRelato(int indice)
        {
            if (indice < 0 || indice >= _relatos.Count) return;
            _indice = indice;
            var r = _relatos[indice];

            // Vincula cada campo JSON ao seu label correspondente
            lblTitulo.Text = r.Titulo ?? string.Empty;
            lblFonte.Text = r.Tipo == "noticiado" ? r.Fonte ?? string.Empty : string.Empty;
            lblTipo.Text = r.Tipo == "ilustrativo"
                ? "Caso ilustrativo, baseado em modalidades reais"
                : string.Empty;
            lblVitima.Text = r.Vitima ?? string.Empty;
            lblRelato.Text = r.Conteudo ?? string.Empty;
            lblLicoesAprendidas.Text = r.LicoesAprendidas ?? string.Empty;

            // Atualiza estado dos botões de navegação
            BtnVoltar.Enabled = _indice > 0;
            BtnAvancar.Enabled = _indice < _relatos.Count - 1;
        }

        private void BtnAvancar_Click(object? sender, EventArgs e)
        {
            if (_indice + 1 < _relatos.Count) MostrarRelato(_indice + 1);
        }

        private void BtnVoltar_Click(object? sender, EventArgs e)
        {
            // Navega para o relato anterior, se existir
            if (_indice - 1 >= 0) MostrarRelato(_indice - 1);
        }

        private void BtnRetorno_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmRelatos_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            else if (e.KeyCode == Keys.Left && BtnVoltar.Enabled)
            {
                MostrarRelato(_indice - 1);
            }
            else if (e.KeyCode == Keys.Right && BtnAvancar.Enabled)
            {
                MostrarRelato(_indice + 1);
            }
        }

        
    }
}
