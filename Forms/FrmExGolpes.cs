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
    public partial class FrmExGolpes : Form
    {
        private List<ExGolpe> _golpes = new();
        private int _indice = 0;

        private Form _janelaOrigem;
        public FrmExGolpes(Form origem)
        {
            _janelaOrigem = origem;
            InitializeComponent();
            BtnAvancar.Click += BtnAvancar_Click;
            BtnVoltar.Click += BtnVoltar_Click;
            Load += FrmExGolpes_Load;
        }

        private void FrmExGolpes_Load(object? sender, EventArgs e)
        {
            try
            {
                string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dados", "exgolpes.json");
                if (!File.Exists(caminho))
                {
                    string caminhoProjeto = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "dados", "exgolpes.json");
                    if (File.Exists(caminhoProjeto)) caminho = caminhoProjeto;
                }

                if (!File.Exists(caminho)) return;

                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var json = File.ReadAllText(caminho, Encoding.UTF8);
                using var doc = JsonDocument.Parse(json);
                if (doc.RootElement.TryGetProperty("itens", out var itens))
                {
                    _golpes = JsonSerializer.Deserialize<List<ExGolpe>>(itens.GetRawText(), options) ?? new List<ExGolpe>();
                }

                if (_golpes.Any()) MostrarGolpe(0);
            }
            catch
            {
            }
        }

        private void MostrarGolpe(int indice)
        {
            if (indice < 0 || indice >= _golpes.Count) return;
            _indice = indice;
            var g = _golpes[indice];
            lbl.Text = g.NomeGolpe ?? string.Empty;
            lblFuncionamento.Text = g.ComoFunciona ?? string.Empty;
            if (g.SinaisDeAlerta != null && g.SinaisDeAlerta.Any())
            {
                var sb = new StringBuilder();
                foreach (var s in g.SinaisDeAlerta) sb.AppendLine("- " + s);
                lblSinaisAlerta.Text = sb.ToString();
            }
            else
            {
                lblSinaisAlerta.Text = string.Empty;
            }
        }

        private void BtnAvancar_Click(object? sender, EventArgs e)
        {
            if (_indice + 1 < _golpes.Count) MostrarGolpe(_indice + 1);
        }

        private void BtnVoltar_Click(object? sender, EventArgs e)
        {
            if (_indice - 1 >= 0) MostrarGolpe(_indice - 1);
            else Close();
        }

        private void BtnRetornar_Click(object sender, EventArgs e)
        {
            _janelaOrigem.Show();
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnVoltar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
