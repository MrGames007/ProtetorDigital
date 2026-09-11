using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace p2elvio.Forms
{
    public partial class FrmVerdadeOuMentira : Form
    {

        private Form _janelaOrigem;
        public FrmVerdadeOuMentira(FrmMenu origem)
        {
            InitializeComponent();
            _janelaOrigem = origem;
        }

        private void FrmVerdadeOuMentira_Load(object? sender, EventArgs e)
        {
            try
            {
                // Busca 1: Pasta 'dados' no diretório de saída (bin/Debug/...)
                string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dados", "perguntas.json");

                // Busca 2 (Fallback para desenvolvimento): Volta 3 pastas a partir de bin/Debug/net10.0-windows/
                if (!File.Exists(caminho))
                {
                    string caminhoProjeto = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "dados", "perguntas.json");
                    if (File.Exists(caminhoProjeto))
                    {
                        caminho = caminhoProjeto;
                    }
                }

                if (!File.Exists(caminho))
                {
                    MessageBox.Show($"Arquivo de perguntas não encontrado em:\n{caminho}", "Erro de Leitura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                var json = File.ReadAllText(caminho, Encoding.UTF8);
                _perguntas = JsonSerializer.Deserialize<List<Pergunta>>(json, options) ?? new List<Pergunta>();

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
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            _janelaOrigem.Show();
            this.Close();
        }

        private void BtnMentira_Click(object sender, EventArgs e)
        {

        }

        private void BtnVerdade_Click(object sender, EventArgs e)
        {

        }
    }
}
