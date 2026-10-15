using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;
using System.Linq;

namespace ProtetorDigital.Forms
{
    public partial class FrmRelatos : Form
    {
        private List<Relato> _relatos = new();
        private int _indice = 0;

        private Form _janelaOrigem;
        public FrmRelatos(Form origem)
        {
            InitializeComponent();
            _janelaOrigem = origem;
            BtnAvancar.Click += BtnAvancar_Click;
            BtnVoltar.Click += BtnVoltar_Click;
            Load += FrmRelatos_Load;
        }

        private void FrmRelatos_Load(object? sender, EventArgs e)
        {
            try
            {
                string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dados", "relatos.json");
                if (!File.Exists(caminho))
                {
                    string caminhoProjeto = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "dados", "relatos.json");
                    if (File.Exists(caminhoProjeto)) caminho = caminhoProjeto;
                }

                if (!File.Exists(caminho)) return;

                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var json = File.ReadAllText(caminho, Encoding.UTF8);
                using var doc = JsonDocument.Parse(json);
                if (doc.RootElement.TryGetProperty("itens", out var itens))
                {
                    _relatos = JsonSerializer.Deserialize<List<Relato>>(itens.GetRawText(), options) ?? new List<Relato>();
                }

                if (_relatos.Any()) MostrarRelato(0);
            }
            catch
            {
                // ignorar erros de leitura para não quebrar a UI
            }
        }

        private void MostrarRelato(int indice)
        {
            if (indice < 0 || indice >= _relatos.Count) return;
            _indice = indice;
            var r = _relatos[indice];

            // Vincula cada campo JSON ao seu label correspondente
            lblTitulo.Text = r.Titulo ?? string.Empty;
            lblFonte.Text = r.Fonte ?? string.Empty;
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
            _janelaOrigem.Show();
            this.Close();
        }
    }
}
