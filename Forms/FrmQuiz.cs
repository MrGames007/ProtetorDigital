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
        private bool _aguardandoProxima;
        private TableLayoutPanel _layoutQuiz = null!;

        private Form _janelaOrigem;
        public FrmQuiz(FrmMenu origem)
        {
            InitializeComponent();
            Load += FrmQuiz_Load;
            _janelaOrigem = origem;
            MinimumSize = new Size(800, 600);
            MaximizeBox = true;
            StartPosition = FormStartPosition.CenterScreen;
            ConfigurarLayoutCentralizado();
            ProtetorDigital.Services.Responsivo.Registrar(this, new Size(1200, 700));
        }

        private void ConfigurarLayoutCentralizado()
        {
            _layoutQuiz = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 5,
                Padding = new Padding(24),
                AutoScroll = true
            };
            _layoutQuiz.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            _layoutQuiz.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            _layoutQuiz.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            _layoutQuiz.RowStyles.Add(new RowStyle(SizeType.Percent, 65));
            _layoutQuiz.RowStyles.Add(new RowStyle(SizeType.Absolute, 0));
            _layoutQuiz.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            lblPergunta.AutoSize = false;
            lblPergunta.Dock = DockStyle.Fill;
            lblPergunta.TextAlign = ContentAlignment.MiddleCenter;
            lblPergunta.Margin = new Padding(8, 8, 8, 16);
            _layoutQuiz.Controls.Add(lblPergunta, 0, 0);

            var alternativas = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 4,
                Padding = new Padding(80, 8, 80, 8)
            };
            alternativas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            alternativas.RowStyles.Add(new RowStyle(SizeType.Percent, 25));
            alternativas.RowStyles.Add(new RowStyle(SizeType.Percent, 25));
            alternativas.RowStyles.Add(new RowStyle(SizeType.Percent, 25));
            alternativas.RowStyles.Add(new RowStyle(SizeType.Percent, 25));
            foreach (var alternativa in new[] { RBtnAlt1, RBtnAlt2, RBtnAlt3, RBtnAlt4 })
            {
                alternativa.AutoSize = false;
                alternativa.Dock = DockStyle.Fill;
                alternativa.TextAlign = ContentAlignment.MiddleCenter;
                alternativa.Margin = new Padding(8, 4, 8, 4);
            }
            alternativas.Controls.Add(RBtnAlt1, 0, 0);
            alternativas.Controls.Add(RBtnAlt2, 0, 1);
            alternativas.Controls.Add(RBtnAlt3, 0, 2);
            alternativas.Controls.Add(RBtnAlt4, 0, 3);
            _layoutQuiz.Controls.Add(alternativas, 0, 1);

            pnlFeedback.Dock = DockStyle.Fill;
            pnlFeedback.Anchor = AnchorStyles.None;
            pnlFeedback.Margin = new Padding(8);
            _layoutQuiz.Controls.Add(pnlFeedback, 0, 2);

            var painelAcoes = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 3,
                RowCount = 1,
                Padding = new Padding(80, 8, 80, 8)
            };
            painelAcoes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            painelAcoes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            painelAcoes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            var acoes = new FlowLayoutPanel
            {
                AutoSize = true,
                Anchor = AnchorStyles.None,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                Margin = new Padding(0)
            };
            BtnVoltar.AutoSize = false;
            BtnVoltar.Size = new Size(180, 44);
            BtnConfirmar.AutoSize = false;
            BtnConfirmar.Size = new Size(180, 44);
            acoes.Controls.Add(BtnVoltar);
            acoes.Controls.Add(BtnConfirmar);
            painelAcoes.Controls.Add(acoes, 1, 0);
            _layoutQuiz.Controls.Add(painelAcoes, 0, 3);

            Controls.Clear();
            Controls.Add(_layoutQuiz);
            DefinirFeedbackVisivel(false);
        }

        private void DefinirFeedbackVisivel(bool visivel)
        {
            pnlFeedback.Visible = visivel;
            _layoutQuiz.RowStyles[2] = new RowStyle(
                visivel ? SizeType.Percent : SizeType.Absolute,
                visivel ? 35 : 0);
            _layoutQuiz.RowStyles[1] = new RowStyle(
                SizeType.Percent,
                visivel ? 65 : 100);
            _layoutQuiz.PerformLayout();
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
            _aguardandoProxima = false;
            BtnConfirmar.Text = "Confirmar ✓";
            DefinirFeedbackVisivel(false);
            lblVeredito.Text = string.Empty;
            txtFeedback.Clear();
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
            if (_aguardandoProxima)
            {
                MostrarPergunta(_indiceAtual + 1);
                return;
            }

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
            int fimDoVeredito = feedback.IndexOf('\n');
            string explicacaoFeedback = fimDoVeredito >= 0
                ? feedback[(fimDoVeredito + 1)..].TrimStart('\r', '\n')
                : feedback;

            MessageBox.Show(feedback, acertou ? "Resposta correta" : "Resposta incorreta",
                MessageBoxButtons.OK,
                acertou ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            var corFundoFeedback = acertou
                ? Color.FromArgb(220, 252, 231)
                : Color.FromArgb(254, 226, 226);
            var corVeredito = acertou
                ? Color.FromArgb(20, 108, 67)
                : Color.FromArgb(176, 42, 55);
            pnlFeedback.BackColor = corFundoFeedback;
            lblVeredito.ForeColor = corVeredito;
            lblVeredito.Text = acertou ? "✔ Você acertou!" : "✘ Você errou.";
            txtFeedback.BackColor = corFundoFeedback;
            txtFeedback.ForeColor = Color.FromArgb(33, 37, 41);
            txtFeedback.Text = explicacaoFeedback;
            DefinirFeedbackVisivel(true);

            // 4. Avança para a próxima pergunta ou encerra o Quiz
            if (_indiceAtual + 1 < _perguntas.Count)
            {
                _aguardandoProxima = true;
                BtnConfirmar.Text = "Próxima ▶";
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