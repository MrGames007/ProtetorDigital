using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
using System.Linq;


namespace p2elvio.Forms
{
    public partial class FrmQuiz : Form
    {
        private List<Pergunta> _perguntas = new();
        private int _indiceAtual = 0;

        private Form _janelaOrigem;
        public FrmQuiz(FrmMenu origem)
        {
            InitializeComponent();
            Load += FrmQuiz_Load;
            _janelaOrigem = origem;
        }

        private void FrmQuiz_Load(object? sender, EventArgs e)
        {
            try
            {
                var caminho = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    "dados",
                    "perguntas.json"
                );

                if (!File.Exists(caminho))
                {
                    MessageBox.Show($"Arquivo de perguntas não encontrado: {caminho}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var json = File.ReadAllText(caminho, Encoding.UTF8);
                _perguntas = JsonSerializer.Deserialize<List<Pergunta>>(json) ?? new List<Pergunta>();

                if (_perguntas.Any())
                {
                    MostrarPergunta(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar perguntas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarPergunta(int indice)
        {
            if (indice < 0 || indice >= _perguntas.Count) return;

            _indiceAtual = indice;
            var p = _perguntas[indice];

            lblPergunta.Text = p.Texto ?? string.Empty;

            // Preencher alternativas (segurança para listas curtas)
            RBtnAlt1.Text = p.Opcoes.Count > 0 ? p.Opcoes[0] : string.Empty;
            RBtnAlt2.Text = p.Opcoes.Count > 1 ? p.Opcoes[1] : string.Empty;
            RBtnAlt3.Text = p.Opcoes.Count > 2 ? p.Opcoes[2] : string.Empty;
            RBtnAlt4.Text = p.Opcoes.Count > 3 ? p.Opcoes[3] : string.Empty;

            RBtnAlt1.Checked = RBtnAlt2.Checked = RBtnAlt3.Checked = RBtnAlt4.Checked = false;
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            _janelaOrigem.Show();
            this.Close();
        }
    }
}
