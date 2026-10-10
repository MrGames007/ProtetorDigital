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
using System.Collections.Generic;

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
            }
        }

        private void MostrarRelato(int indice)
        {
            if (indice < 0 || indice >= _relatos.Count) return;
            _indice = indice;
            var r = _relatos[indice];
            var sb = new StringBuilder();
            sb.AppendLine(r.Titulo);
            if (!string.IsNullOrWhiteSpace(r.Fonte)) sb.AppendLine().AppendLine("Fonte: " + r.Fonte);
            if (!string.IsNullOrWhiteSpace(r.Vitima)) sb.AppendLine().AppendLine("Vítima: " + r.Vitima);
            if (!string.IsNullOrWhiteSpace(r.Conteudo)) sb.AppendLine().AppendLine(r.Conteudo);
            if (!string.IsNullOrWhiteSpace(r.LicoesAprendidas)) sb.AppendLine().AppendLine("Lições aprendidas: " + r.LicoesAprendidas);
            lblRelato.Text = sb.ToString();
        }

        private void BtnAvancar_Click(object? sender, EventArgs e)
        {
            if (_indice + 1 < _relatos.Count) MostrarRelato(_indice + 1);
        }

        private void BtnVoltar_Click(object? sender, EventArgs e)
        {
            if (_indice - 1 >= 0) MostrarRelato(_indice - 1);
            else Close();
        }

        private void BtnRetornar_Click(object sender, EventArgs e)
        {
            _janelaOrigem.Show();
            this.Close();
        }
    }
}
