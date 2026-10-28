using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using ProtetorDigital.Services;

namespace ProtetorDigital.Forms
{
    public partial class FrmDicas : Form
    {
        private List<Dica> _dicas = new();
        private int _indice = 0;
        private readonly ConteudoService _conteudoService = new();

        public FrmDicas()
        {
            InitializeComponent();
            BtnAvancar.Click += BtnAvancar_Click;
            BtnVoltar.Click += BtnVoltar_Click;
            Load += FrmDicas_Load;
            KeyPreview = true;
            KeyDown += FrmDicas_KeyDown;
        }

        private void FrmDicas_Load(object? sender, EventArgs e)
        {
            try
            {
                _dicas = _conteudoService.CarregarLista<Dica>("dicas.json");

                if (_dicas.Any()) MostrarDica(0);
            }
            catch (ConteudoException ex)
            {
                MessageBox.Show($"Não foi possível carregar as dicas.\n{ex.Message}", "Conteúdo indisponível", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        }

        private void BtnRetornar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmDicas_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            else if (e.KeyCode == Keys.Left && BtnVoltar.Enabled)
            {
                MostrarDica(_indice - 1);
            }
            else if (e.KeyCode == Keys.Right && BtnAvancar.Enabled)
            {
                MostrarDica(_indice + 1);
            }
        }
    }
}
