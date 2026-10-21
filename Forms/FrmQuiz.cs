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

namespace ProtetorDigital.Forms
{
    public partial class FrmQuiz : Form
    {
        private List<Pergunta> _perguntas = new();
        private int _indiceAtual = 0;
        private int _pontuacao = 0;
        private List<string> _opcoesExibidas = new();
        private int _respostaCorretaExibida = -1;

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

            var opcoes = (p.Opcoes ?? new List<string>()).ToList();
            int indiceRespostaOriginal = p.RespostaCorreta - 1;
            var opcoesComResposta = opcoes
                .Select((texto, indice) => new
                {
                    Texto = texto,
                    Correta = indice == indiceRespostaOriginal
                })
                .OrderBy(_ => Random.Shared.Next())
                .ToList();

            // Embaralha apenas as alternativas exibidas; o JSON permanece inalterado.
            _opcoesExibidas = opcoesComResposta.Select(opcao => opcao.Texto).ToList();
            _respostaCorretaExibida = opcoesComResposta.FindIndex(opcao => opcao.Correta);

            RBtnAlt1.Text = _opcoesExibidas.Count > 0 ? _opcoesExibidas[0] : string.Empty;
            RBtnAlt2.Text = _opcoesExibidas.Count > 1 ? _opcoesExibidas[1] : string.Empty;
            RBtnAlt3.Text = _opcoesExibidas.Count > 2 ? _opcoesExibidas[2] : string.Empty;
            RBtnAlt4.Text = _opcoesExibidas.Count > 3 ? _opcoesExibidas[3] : string.Empty;

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

            // 3. Valida a resposta com a alternativa correta informada no JSON
            var perguntaAtual = _perguntas[_indiceAtual];
            bool acertou = respostaSelecionada == _respostaCorretaExibida;
            if (acertou)
            {
                _pontuacao++;
            }

            var opcoesAtuais = _opcoesExibidas;
            string alternativaEscolhida = respostaSelecionada < opcoesAtuais.Count
                ? opcoesAtuais[respostaSelecionada]
                : "Alternativa não identificada";
            int indiceCorreto = _respostaCorretaExibida;
            string alternativaCorreta = indiceCorreto >= 0 && indiceCorreto < opcoesAtuais.Count
                ? opcoesAtuais[indiceCorreto]
                : "Alternativa não identificada";

            string explicacao = perguntaAtual.Explicacao ?? "Não há explicação cadastrada para esta pergunta.";
            string feedback = acertou
                ? $"Você acertou!\n\n{explicacao}"
                : $"Você errou.\n\nSua resposta:\n{alternativaEscolhida}\n\n" +
                  $"Alternativa correta:\n{alternativaCorreta}\n\nPor que a sua resposta está errada:\n{explicacao}";

            MessageBox.Show(feedback, acertou ? "Resposta correta" : "Resposta incorreta",
                MessageBoxButtons.OK,
                acertou ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

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