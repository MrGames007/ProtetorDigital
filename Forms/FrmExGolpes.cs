using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using ProtetorDigital.Services;

namespace ProtetorDigital.Forms
{
    public partial class FrmExGolpes : Form
    {
        private List<ExGolpe> _golpes = new();
        private int _indice = 0;
        private readonly ConteudoService _conteudoService = new();

        public FrmExGolpes()
        {
            InitializeComponent();
            BtnAvancar.Click += BtnAvancar_Click;
            BtnVoltar.Click += BtnVoltar_Click;
            Load += FrmExGolpes_Load;
            KeyPreview = true;
            KeyDown += FrmExGolpes_KeyDown;
        }

        private void FrmExGolpes_Load(object? sender, EventArgs e)
        {
            try
            {
                _golpes = _conteudoService.CarregarLista<ExGolpe>("exgolpes.json");

                if (_golpes.Any()) MostrarGolpe(0);
            }
            catch (ConteudoException ex)
            {
                MessageBox.Show($"Não foi possível carregar os exemplos de golpes.\n{ex.Message}", "Conteúdo indisponível", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
        }

        private void MostrarGolpe(int indice)
        {
            if (indice < 0 || indice >= _golpes.Count) return;
            _indice = indice;
            var g = _golpes[indice];
            lblNomeGolpe.Text = g.NomeGolpe ?? string.Empty;
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

            BtnVoltar.Enabled = _indice > 0;
            BtnAvancar.Enabled = _indice < _golpes.Count - 1;
        }

        private void BtnAvancar_Click(object? sender, EventArgs e)
        {
            if (_indice + 1 < _golpes.Count) MostrarGolpe(_indice + 1);
        }

        private void BtnVoltar_Click(object? sender, EventArgs e)
        {
            if (_indice - 1 >= 0) MostrarGolpe(_indice - 1);
        }

        private void BtnRetornar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmExGolpes_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            else if (e.KeyCode == Keys.Left && BtnVoltar.Enabled)
            {
                MostrarGolpe(_indice - 1);
            }
            else if (e.KeyCode == Keys.Right && BtnAvancar.Enabled)
            {
                MostrarGolpe(_indice + 1);
            }
        }

        
    }
}
