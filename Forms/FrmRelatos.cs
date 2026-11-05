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
        private LinkLabel _linkMateria = new();

        private Form _janelaOrigem;
        public FrmRelatos(Form origem)
        {
            InitializeComponent();
            ProtetorDigital.Services.JanelaPadrao.Registrar(this);
            ProtetorDigital.Services.Suavizar.Aplicar(this);
            _janelaOrigem = origem;
            BtnAvancar.Click += BtnAvancar_Click;
            BtnVoltar.Click += BtnVoltar_Click;
            Load += FrmRelatos_Load;
            MinimumSize = new Size(800, 600);
            MaximizeBox = true;
            StartPosition = FormStartPosition.CenterScreen;
            ProtetorDigital.Services.Responsivo.Registrar(this, new Size(1100, 650));
            Resize += (_, _) => AjustarLarguras();
            _linkMateria = new LinkLabel
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 16F),
                Text = "Ler a matéria original",
                Visible = false
            };
            _linkMateria.LinkClicked += (_, _) =>
            {
                if (_linkMateria.Tag is string url)
                {
                    try { System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(url) { UseShellExecute = true }); } catch { }
                }
            };
            Controls.Add(_linkMateria);
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
                AjustarLarguras();
            }
            catch
            {
                // ignorar erro de leitura para não quebrar a UI
            }
        }

        private void AjustarLarguras()
        {
            var largura = Math.Max(100, ClientSize.Width - 70);
            foreach (var label in new[] { lblFonte, lblVitima, lblRelato, lblLicoesAprendidas })
            {
                label.MaximumSize = new Size(largura, 0);
                label.AutoSize = true;
            }
            _linkMateria.Location = new Point(18, Math.Min(ClientSize.Height - 90, lblLicoesAprendidas.Bottom + 12));
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
            lblFonte.Text = !string.IsNullOrWhiteSpace(r.Tipo) && r.Tipo == "ilustrativo"
                ? "Caso ilustrativo, baseado em modalidades reais"
                : r.Tipo == "alerta_oficial" ? "Alerta oficial do INSS" : $"Fonte: {r.Fonte} ({r.Data})";
            _linkMateria.Tag = r.Url;
            _linkMateria.Visible = !string.IsNullOrWhiteSpace(r.Url);

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
