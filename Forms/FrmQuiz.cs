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

        public FrmQuiz()
        {
            InitializeComponent();
            Load += FrmQuiz_Load;
            KeyPreview = true;
            KeyDown += FrmQuiz_KeyDown;
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
            lblProgresso.Text = $"Pergunta {indice + 1} de {_perguntas.Count}";
            progressQuiz.Maximum = Math.Max(1, _perguntas.Count);
            progressQuiz.Value = indice + 1;

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
            pnlFeedback.Visible = false;
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
            txtFeedback.Text = (acertou ? "Você acertou!" : "Você errou.") +
                $"\n{explicacaoEscolhida}\nA resposta certa é: {alternativaCorreta}\n{explicacao}";
            pnlFeedback.BackColor = acertou ? Color.FromArgb(220, 252, 231) : Color.FromArgb(254, 226, 226);
            txtFeedback.BackColor = pnlFeedback.BackColor;
            pnlFeedback.Visible = true;
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
            txtResultado.Text = $"Resultado\n\nVocê acertou {_pontuacao} de {_perguntas.Count}.\n{faixa}{erros}";
            pnlResultado.Visible = true;
            pnlFeedback.Visible = false;
            lblPergunta.Visible = false;
            lblProgresso.Visible = false;
            progressQuiz.Visible = false;
            RBtnAlt1.Visible = RBtnAlt2.Visible = RBtnAlt3.Visible = RBtnAlt4.Visible = false;
            BtnConfirmar.Visible = false;
            BtnVoltar.Visible = false;
        }

        private void BtnRefazer_Click(object? sender, EventArgs e)
        {
            _indiceAtual = 0;
            _pontuacao = 0;
            _respostasErradas.Clear();
            pnlResultado.Visible = false;
            lblPergunta.Visible = true;
            lblProgresso.Visible = true;
            progressQuiz.Visible = true;
            RBtnAlt1.Visible = RBtnAlt2.Visible = RBtnAlt3.Visible = RBtnAlt4.Visible = true;
            BtnConfirmar.Visible = true;
            BtnVoltar.Visible = true;
            MostrarPergunta(0);
        }

        private void BtnVoltarMenu_Click(object? sender, EventArgs e) => Close();

        private void FrmQuiz_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (pnlResultado.Visible || MessageBox.Show("Deseja sair do quiz? O progresso será perdido.", "Sair do quiz", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Close();
                }
            }
            else if (e.KeyCode == Keys.Enter && BtnConfirmar.Visible)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                BtnConfirmar.PerformClick();
            }
            else if (!_respostaConfirmada && !pnlResultado.Visible && (e.KeyCode is Keys.D1 or Keys.NumPad1))
            {
                RBtnAlt1.Checked = true;
            }
            else if (!_respostaConfirmada && !pnlResultado.Visible && (e.KeyCode is Keys.D2 or Keys.NumPad2))
            {
                RBtnAlt2.Checked = true;
            }
            else if (!_respostaConfirmada && !pnlResultado.Visible && (e.KeyCode is Keys.D3 or Keys.NumPad3))
            {
                RBtnAlt3.Checked = true;
            }
            else if (!_respostaConfirmada && !pnlResultado.Visible && (e.KeyCode is Keys.D4 or Keys.NumPad4))
            {
                RBtnAlt4.Checked = true;
            }
        }

        private sealed record OpcaoExibida(string Texto, int IndiceOriginal);
        private sealed record ResultadoPergunta(string Pergunta, string RespostaCorreta);

    }
}