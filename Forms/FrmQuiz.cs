using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace p2elvio.Forms
{
    public partial class FrmQuiz : Form
    {
        private List<Pergunta> _perguntas = new();
        private int _indiceAtual = 0;
        private int _pontuacao = 0;

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

        private void MostrarPergunta(int indice)
        {
            if (indice < 0 || indice >= _perguntas.Count) return;

            _indiceAtual = indice;
            var p = _perguntas[indice];

            lblPergunta.Text = p.Texto ?? string.Empty;

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

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            // 1. Identifica qual RadioButton foi selecionado
            int respostaSelecionada = -1;

            if (RBtnAlt1.Checked) respostaSelecionada = 0;
            else if (RBtnAlt2.Checked) respostaSelecionada = 1;
            else if (RBtnAlt3.Checked) respostaSelecionada = 2;
            else if (RBtnAlt4.Checked) respostaSelecionada = 3;

            // 2. Garante que o usuário marcou alguma opção antes de prosseguir
            if (respostaSelecionada == -1)
            {
                MessageBox.Show("Por favor, selecione uma alternativa antes de confirmar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Valida a resposta com a propriedade Correta da classe Pergunta
            var perguntaAtual = _perguntas[_indiceAtual];
            if (respostaSelecionada == perguntaAtual.RespostaCorreta)
            {
                _pontuacao++;
            }

            // 4. Avança para a próxima pergunta ou encerra o Quiz
            if (_indiceAtual + 1 < _perguntas.Count)
            {
                MostrarPergunta(_indiceAtual + 1);
            }
            else
            {
                MessageBox.Show($"Fim do Quiz!\nVocê acertou {_pontuacao} de {_perguntas.Count} perguntas.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _janelaOrigem.Show();
                this.Close();
            }
        }
    }
}