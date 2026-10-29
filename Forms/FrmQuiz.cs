using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ProtetorDigital.Services;

namespace ProtetorDigital.Forms
{
    public partial class FrmQuiz : Form
    {
        private List<Pergunta> _perguntas = new();
        private int _indiceAtual = 0;
        private int _pontuacao = 0;
        private List<OpcaoExibida> _opcoesExibidas = new();
        private int _respostaCorretaExibida = -1;
        private bool _respostaConfirmada;
        private readonly List<ResultadoPergunta> _respostasErradas = new();
        private readonly ConteudoService _conteudoService = new();
        private readonly Label _lblProgresso = new();
        private readonly ProgressBar _progressQuiz = new();
        private readonly Panel _pnlFeedback = new();
        private readonly Label _lblFeedback = new();
        private readonly Panel _pnlResultado = new();
        private readonly Label _lblResultado = new();
        private readonly Button _btnRefazer = new();
        private readonly Button _btnVoltarMenu = new();

        public FrmQuiz()
        {
            InitializeComponent();
            ConfigurarInterface();
            Load += FrmQuiz_Load;
            KeyPreview = true;
            KeyDown += FrmQuiz_KeyDown;
        }

        private void ConfigurarInterface()
        {
            ClientSize = new Size(1201, 700);

            _lblProgresso.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            _lblProgresso.Location = new Point(15, 75);
            _lblProgresso.Size = new Size(250, 30);
            Controls.Add(_lblProgresso);

            _progressQuiz.Location = new Point(280, 78);
            _progressQuiz.Size = new Size(880, 25);
            Controls.Add(_progressQuiz);

            lblPergunta.Location = new Point(15, 120);
            RBtnAlt1.Location = new Point(15, 205);
            RBtnAlt2.Location = new Point(15, 270);
            RBtnAlt3.Location = new Point(15, 335);
            RBtnAlt4.Location = new Point(15, 400);

            BtnVoltar.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            BtnVoltar.Size = new Size(180, 60);
            BtnVoltar.Location = new Point(15, 615);

            BtnConfirmar.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            BtnConfirmar.Size = new Size(250, 60);
            BtnConfirmar.Location = new Point(936, 615);
            BtnConfirmar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            _pnlFeedback.Location = new Point(15, 470);
            _pnlFeedback.Size = new Size(1145, 120);
            _pnlFeedback.Padding = new Padding(12);
            _pnlFeedback.Visible = false;
            _lblFeedback.Dock = DockStyle.Fill;
            _lblFeedback.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            _lblFeedback.AutoEllipsis = true;
            _pnlFeedback.Controls.Add(_lblFeedback);
            Controls.Add(_pnlFeedback);

            _pnlResultado.Dock = DockStyle.Fill;
            _pnlResultado.BackColor = Color.White;
            _pnlResultado.Padding = new Padding(30);
            _pnlResultado.Visible = false;
            _lblResultado.Dock = DockStyle.Fill;
            _lblResultado.Font = new Font("Segoe UI", 16F, FontStyle.Regular);
            _lblResultado.AutoEllipsis = true;
            _pnlResultado.Controls.Add(_lblResultado);
            _btnRefazer.Text = "Refazer";
            _btnRefazer.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            _btnRefazer.Size = new Size(200, 60);
            _btnRefazer.Location = new Point(30, 610);
            _btnRefazer.Click += BtnRefazer_Click;
            _pnlResultado.Controls.Add(_btnRefazer);
            _btnVoltarMenu.Text = "Voltar ao menu";
            _btnVoltarMenu.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            _btnVoltarMenu.Size = new Size(250, 60);
            _btnVoltarMenu.Location = new Point(890, 610);
            _btnVoltarMenu.Click += BtnVoltarMenu_Click;
            _pnlResultado.Controls.Add(_btnVoltarMenu);
            Controls.Add(_pnlResultado);
        }

        private void FrmQuiz_Load(object? sender, EventArgs e)
        {
            try
            {
                _perguntas = _conteudoService.CarregarLista<Pergunta>("perguntas.json");

                if (_perguntas.Any())
                {
                    MostrarPergunta(0);
                }
            }
            catch (ConteudoException ex)
            {
                MessageBox.Show($"Não foi possível carregar o quiz.\n{ex.Message}", "Conteúdo indisponível", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
        }

        private void MostrarPergunta(int indice)
        {
            if (indice < 0 || indice >= _perguntas.Count) return;

            _indiceAtual = indice;
            var p = _perguntas[indice];
            _respostaConfirmada = false;

            lblPergunta.Text = p.Texto ?? string.Empty;
            _lblProgresso.Text = $"Pergunta {indice + 1} de {_perguntas.Count}";
            _progressQuiz.Maximum = Math.Max(1, _perguntas.Count);
            _progressQuiz.Value = indice + 1;

            var opcoes = (p.Opcoes ?? new List<string>()).ToList();
            var opcoesComResposta = opcoes
                .Select((texto, indiceOriginal) => new OpcaoExibida(texto, indiceOriginal))
                .ToArray();
            Random.Shared.Shuffle(opcoesComResposta);

            // Embaralha apenas as alternativas exibidas; o JSON permanece inalterado.
            _opcoesExibidas = opcoesComResposta.ToList();
            _respostaCorretaExibida = _opcoesExibidas.FindIndex(opcao => opcao.IndiceOriginal == p.RespostaCorreta - 1);

            RBtnAlt1.Text = _opcoesExibidas.Count > 0 ? _opcoesExibidas[0].Texto : string.Empty;
            RBtnAlt2.Text = _opcoesExibidas.Count > 1 ? _opcoesExibidas[1].Texto : string.Empty;
            RBtnAlt3.Text = _opcoesExibidas.Count > 2 ? _opcoesExibidas[2].Texto : string.Empty;
            RBtnAlt4.Text = _opcoesExibidas.Count > 3 ? _opcoesExibidas[3].Texto : string.Empty;

            RBtnAlt1.Checked = RBtnAlt2.Checked = RBtnAlt3.Checked = RBtnAlt4.Checked = false;
            RBtnAlt1.Enabled = RBtnAlt2.Enabled = RBtnAlt3.Enabled = RBtnAlt4.Enabled = true;
            _pnlFeedback.Visible = false;
            BtnConfirmar.Text = indice + 1 == _perguntas.Count ? "Confirmar" : "Confirmar ✓";
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (_respostaConfirmada)
            {
                if (_indiceAtual + 1 < _perguntas.Count)
                {
                    MostrarPergunta(_indiceAtual + 1);
                }
                else
                {
                    MostrarResultado();
                }
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

            string alternativaEscolhida = respostaSelecionada < _opcoesExibidas.Count
                ? _opcoesExibidas[respostaSelecionada].Texto
                : "Alternativa não identificada";
            int indiceCorreto = _respostaCorretaExibida;
            string alternativaCorreta = indiceCorreto >= 0 && indiceCorreto < _opcoesExibidas.Count
                ? _opcoesExibidas[indiceCorreto].Texto
                : "Alternativa não identificada";

            string explicacaoEscolhida = perguntaAtual.ExplicacaoOpcoesErradas != null &&
                _opcoesExibidas[respostaSelecionada].IndiceOriginal < perguntaAtual.ExplicacaoOpcoesErradas.Count
                ? LimparPrefixo(perguntaAtual.ExplicacaoOpcoesErradas[_opcoesExibidas[respostaSelecionada].IndiceOriginal])
                : string.Empty;
            string explicacao = perguntaAtual.Explicacao ?? "Não há explicação cadastrada para esta pergunta.";
            _lblFeedback.Text = (acertou ? "Você acertou!" : "Você errou.") +
                $"\n{explicacaoEscolhida}\nA resposta certa é: {alternativaCorreta}\n{explicacao}";
            _pnlFeedback.BackColor = acertou ? Color.FromArgb(220, 252, 231) : Color.FromArgb(254, 226, 226);
            _pnlFeedback.Visible = true;
            _respostaConfirmada = true;
            RBtnAlt1.Enabled = RBtnAlt2.Enabled = RBtnAlt3.Enabled = RBtnAlt4.Enabled = false;
            BtnConfirmar.Text = _indiceAtual + 1 < _perguntas.Count ? "Próxima ▶" : "Ver resultado";

            if (!acertou)
            {
                _respostasErradas.Add(new ResultadoPergunta(perguntaAtual.Texto ?? "Pergunta sem texto", alternativaCorreta));
            }
        }

        private static string LimparPrefixo(string texto)
        {
            if (texto.StartsWith("Errado!", StringComparison.OrdinalIgnoreCase)) return texto[7..].Trim();
            if (texto.StartsWith("Correta!", StringComparison.OrdinalIgnoreCase)) return texto[8..].Trim();
            return texto;
        }

        private void MostrarResultado()
        {
            string faixa = _pontuacao == _perguntas.Count ? "Excelente! Você demonstrou muito cuidado." :
                _pontuacao >= (_perguntas.Count + 1) / 2 ? "Muito bem! Continue praticando os cuidados." :
                "Tudo bem! Revise as dicas e tente novamente.";
            string erros = _respostasErradas.Count == 0 ? "\nVocê acertou todas as perguntas!" :
                "\n\nPerguntas para revisar:\n" + string.Join("\n", _respostasErradas.Select((r, i) =>
                    $"{i + 1}. {r.Pergunta}\n   A resposta certa é: {r.RespostaCorreta}"));
            _lblResultado.Text = $"Resultado\n\nVocê acertou {_pontuacao} de {_perguntas.Count}.\n{faixa}{erros}";
            _pnlResultado.Visible = true;
            _pnlFeedback.Visible = false;
            lblPergunta.Visible = false;
            _lblProgresso.Visible = false;
            _progressQuiz.Visible = false;
            RBtnAlt1.Visible = RBtnAlt2.Visible = RBtnAlt3.Visible = RBtnAlt4.Visible = false;
            BtnConfirmar.Visible = false;
            BtnVoltar.Visible = false;
        }

        private void BtnRefazer_Click(object? sender, EventArgs e)
        {
            _indiceAtual = 0;
            _pontuacao = 0;
            _respostasErradas.Clear();
            _pnlResultado.Visible = false;
            lblPergunta.Visible = true;
            _lblProgresso.Visible = true;
            _progressQuiz.Visible = true;
            RBtnAlt1.Visible = RBtnAlt2.Visible = RBtnAlt3.Visible = RBtnAlt4.Visible = true;
            BtnConfirmar.Visible = true;
            BtnVoltar.Visible = true;
            MostrarPergunta(0);
        }

        private void BtnVoltarMenu_Click(object? sender, EventArgs e) => Close();

        private void FrmQuiz_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Close();
        }

        private sealed record OpcaoExibida(string Texto, int IndiceOriginal);
        private sealed record ResultadoPergunta(string Pergunta, string RespostaCorreta);

    }
}