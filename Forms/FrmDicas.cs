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
    public partial class FrmDicas : Form
    {
        private List<Dica> _dicas = new();
        private int _indice = 0;

        private Form _janelaOrigem;
        public FrmDicas(Form origem)
        {
            _janelaOrigem = origem;
            InitializeComponent();
            BtnAvancar.Click += BtnAvancar_Click;
            BtnVoltar.Click += BtnVoltar_Click;
            Load += FrmDicas_Load;
        }

        private void FrmDicas_Load(object? sender, EventArgs e)
        {
            try
            {
                string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dados", "dicas.json");
                if (!File.Exists(caminho))
                {
                    string caminhoProjeto = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "dados", "dicas.json");
                    if (File.Exists(caminhoProjeto)) caminho = caminhoProjeto;
                }

                if (!File.Exists(caminho)) return;

                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var json = File.ReadAllText(caminho, Encoding.UTF8);
                using var doc = JsonDocument.Parse(json);
                if (doc.RootElement.TryGetProperty("itens", out var itens))
                {
                    _dicas = JsonSerializer.Deserialize<List<Dica>>(itens.GetRawText(), options) ?? new List<Dica>();
                }

                if (_dicas.Any()) MostrarDica(0);
            }
            catch
            {
                // ignorar erro de leitura para não quebrar a UI
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

            BtnVoltar.Enabled = _indice > 0;
            BtnAvancar.Enabled = _indice < _dicas.Count - 1;
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

        private void BtnRetornar_Click(object sender, EventArgs e)
        {
            _janelaOrigem.Show();
            this.Close();
        }
    }
}
