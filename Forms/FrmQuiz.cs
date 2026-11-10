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
        private List<Pergunta> _todasPerguntas = new();
        private const int QuantidadePorRodada = 10;
        private int _indiceAtual = 0;
        private int _pontuacao = 0;
        private List<OpcaoExibida> _opcoesExibidas = new();
        private int _respostaCorretaExibida = -1;
        private bool _respostaConfirmada;
        private readonly List<ResultadoPergunta> _respostasErradas = new();
        private readonly Form? _janelaOrigem;
        private readonly Label _lblProgresso = new();
        private readonly ProgressBar _progressQuiz = new();
        private readonly Panel _pnlFeedback = new();
        private readonly RichTextBox _txtFeedback = new();
        private readonly Panel _pnlResultado = new();
        private readonly Label _lblResultado = new();
        private readonly Button _btnRefazer = new();
        private readonly Button _btnVoltarMenu = new();
        private readonly RichTextBox _txtResultado = new();
        private TableLayoutPanel _tlpRaiz = new();
        private TableLayoutPanel _tlpBotoes = new();
        private TableLayoutPanel _cabecalho = new();
        private TableLayoutPanel _alternativas = new();

        public FrmQuiz()
        {
            InitializeComponent();
            ProtetorDigital.Services.JanelaPadrao.Registrar(this);
            ProtetorDigital.Services.Suavizar.Aplicar(this);
            ConfigurarInterface();
            MinimumSize = new Size(800, 600);
            Responsivo.Registrar(this, new Size(1201, 700), AjustarControlesParaCaber);
            foreach (Control controle in Controls)
            {
                Responsivo.Registrar(controle);
            }
            Load += FrmQuiz_Load;
            KeyPreview = true;
            KeyDown += FrmQuiz_KeyDown;
        }

        public FrmQuiz(FrmMenu origem) : this()
        {
            _janelaOrigem = origem;
        }

        private void ConfigurarInterface()
        {
            _tlpRaiz = new TableLayoutPanel { Dock = DockStyle.Fill, Padding = new Padding(20), ColumnCount = 1, RowCount = 5, BackColor = Color.Transparent, AutoScroll = true };
            foreach (var percentual in new[] { 8f, 14f, 34f, 28f, 16f }) _tlpRaiz.RowStyles.Add(new RowStyle(SizeType.Percent, percentual));

            _cabecalho = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 2, RowCount = 1, BackColor = Color.Transparent };
            _cabecalho.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
            _cabecalho.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75));
            _lblProgresso.Dock = DockStyle.Fill;
            _lblProgresso.AutoSize = false;
            _lblProgresso.AutoEllipsis = false;
            _lblProgresso.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            _lblProgresso.TextAlign = ContentAlignment.MiddleLeft;
            _lblProgresso.MinimumSize = new Size(0, 32);
            _progressQuiz.Dock = DockStyle.None;
            _progressQuiz.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            _progressQuiz.Height = 24;
            _progressQuiz.Margin = new Padding(12, 0, 0, 0);
            _cabecalho.Controls.Add(_lblProgresso, 0, 0);
            _cabecalho.Controls.Add(_progressQuiz, 1, 0);

            lblPergunta.Dock = DockStyle.Fill;
            lblPergunta.AutoSize = false;
            lblPergunta.TextAlign = ContentAlignment.MiddleLeft;
            lblPergunta.Font = new Font("Segoe UI", 16F, FontStyle.Bold);

            _alternativas = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 1, RowCount = 4, BackColor = Color.Transparent };
            for (var i = 0; i < 4; i++) _alternativas.RowStyles.Add(new RowStyle(SizeType.Percent, 25));
            foreach (var opcao in new[] { RBtnAlt1, RBtnAlt2, RBtnAlt3, RBtnAlt4 })
            {
                opcao.Dock = DockStyle.Fill;
                opcao.AutoSize = false;
                opcao.TextAlign = ContentAlignment.MiddleLeft;
                opcao.Font = new Font("Segoe UI", 13F, FontStyle.Regular);
                opcao.Margin = new Padding(4);
                _alternativas.Controls.Add(opcao, 0, _alternativas.Controls.Count);
            }

            _pnlFeedback.Dock = DockStyle.Fill;
            _pnlFeedback.Padding = new Padding(8);
            _pnlFeedback.Visible = false;
            _pnlFeedback.BackColor = Color.FromArgb(220, 252, 231);
            _txtFeedback.Dock = DockStyle.Fill;
            _txtFeedback.ReadOnly = true;
            _txtFeedback.BorderStyle = BorderStyle.None;
            _txtFeedback.ScrollBars = RichTextBoxScrollBars.Vertical;
            _txtFeedback.TabStop = false;
            _txtFeedback.BackColor = _pnlFeedback.BackColor;
            _txtFeedback.ForeColor = Color.FromArgb(33, 37, 41);
            _txtFeedback.Font = new Font("Segoe UI", 13F);
            _pnlFeedback.Controls.Add(_txtFeedback);

            _tlpBotoes = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 3, RowCount = 1, BackColor = Color.Transparent };
            _tlpBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
            _tlpBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60));
            _tlpBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
            BtnVoltar.Dock = BtnConfirmar.Dock = DockStyle.Fill;
            BtnVoltar.Margin = BtnConfirmar.Margin = new Padding(8);
            BtnVoltar.Font = BtnConfirmar.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            _tlpBotoes.Controls.Add(BtnVoltar, 0, 0);
            _tlpBotoes.Controls.Add(BtnConfirmar, 2, 0);

            _tlpRaiz.Controls.Add(_cabecalho, 0, 0);
            _tlpRaiz.Controls.Add(lblPergunta, 0, 1);
            _tlpRaiz.Controls.Add(_alternativas, 0, 2);
            _tlpRaiz.Controls.Add(_pnlFeedback, 0, 3);
            _tlpRaiz.Controls.Add(_tlpBotoes, 0, 4);
            Controls.Clear();
            Controls.Add(_tlpRaiz);

            _pnlResultado.Dock = DockStyle.Fill;
            _pnlResultado.BackColor = Color.White;
            _pnlResultado.Padding = new Padding(30);
            _pnlResultado.Visible = false;
            _txtResultado.Dock = DockStyle.Fill;
            _txtResultado.ReadOnly = true;
            _txtResultado.ScrollBars = RichTextBoxScrollBars.Vertical;
            _txtResultado.BackColor = Color.White;
            _txtResultado.BorderStyle = BorderStyle.None;
            _txtResultado.Font = new Font("Segoe UI", 16F);
            _lblResultado.Font = new Font("Segoe UI", 16F, FontStyle.Regular);
            _lblResultado.AutoEllipsis = false;
            _lblResultado.AutoSize = false;
            _lblResultado.TextAlign = ContentAlignment.TopLeft;
            _lblResultado.Dock = DockStyle.Fill;
            _pnlResultado.Controls.Add(_txtResultado);
            _btnRefazer.Text = "Refazer";
            _btnRefazer.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            _btnRefazer.Click += BtnRefazer_Click;
            _btnVoltarMenu.Text = "Voltar ao menu";
            _btnVoltarMenu.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            _btnVoltarMenu.Click += BtnVoltarMenu_Click;
            var botoesResultado = new FlowLayoutPanel { Dock = DockStyle.Bottom, Height = 76, FlowDirection = FlowDirection.LeftToRight, Padding = new Padding(0, 8, 0, 8) };
            _btnRefazer.AutoSize = false;
            _btnVoltarMenu.AutoSize = false;
            _btnRefazer.Size = new Size(200, 60);
            _btnVoltarMenu.Size = new Size(250, 60);
            botoesResultado.Controls.Add(_btnRefazer);
            botoesResultado.Controls.Add(_btnVoltarMenu);
            _pnlResultado.Controls.Add(botoesResultado);
            _txtResultado.BringToFront();
            Controls.Add(_pnlResultado);
        }

        private void FrmQuiz_Load(object? sender, EventArgs e)
        {
            try
            {
                _todasPerguntas = ConteudoService.CarregarLista<Pergunta>("perguntas.json");
                IniciarRodada();

                if (_perguntas.Any())
                {
                    MostrarPergunta(0);
                }
            }
            catch (ConteudoException ex)
            {
                MessageBox.Show($"Não consegui abrir o conteúdo desta tela. Detalhe: {ex.Message}", "Conteúdo indisponível", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
        }

        private void IniciarRodada()
        {
            var sorteadas = _todasPerguntas.ToArray();
            Random.Shared.Shuffle(sorteadas);
            _perguntas = sorteadas.Take(QuantidadePorRodada).ToList();
        }

        private void AjustarControlesParaCaber()
        {
            var controles = new Control[] { _lblProgresso, lblPergunta, RBtnAlt1, RBtnAlt2, RBtnAlt3, RBtnAlt4, BtnVoltar, BtnConfirmar };
            foreach (var controle in controles) Responsivo.AjustarParaCaber(controle);

            var menorFonte = new[] { RBtnAlt1, RBtnAlt2, RBtnAlt3, RBtnAlt4 }.Min(c => c.Font.Size);
            foreach (var opcao in new[] { RBtnAlt1, RBtnAlt2, RBtnAlt3, RBtnAlt4 })
            {
                if (Math.Abs(opcao.Font.Size - menorFonte) > 0.01f)
                {
                    var antiga = opcao.Font;
                    opcao.Font = new Font(antiga.FontFamily, menorFonte, antiga.Style, antiga.Unit);
                    antiga.Dispose();
                }
            }
            Responsivo.AjustarParaCaber(_lblProgresso);
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
            _janelaOrigem?.Show();
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

            string explicacaoEscolhida = string.Empty;
            if (!acertou && perguntaAtual.ExplicacaoOpcoes is { Count: > 0 } explicacoes &&
                _opcoesExibidas[respostaSelecionada].IndiceOriginal < explicacoes.Count)
            {
                explicacaoEscolhida = LimparPrefixo(explicacoes[_opcoesExibidas[respostaSelecionada].IndiceOriginal]);
            }
            string explicacao = perguntaAtual.Explicacao ?? "Não há explicação cadastrada para esta pergunta.";
            var blocos = new List<string> { acertou ? "Você acertou!" : "Você errou." };
            if (!string.IsNullOrWhiteSpace(explicacaoEscolhida)) blocos.Add(explicacaoEscolhida);
            blocos.Add($"A resposta certa é: {alternativaCorreta}");
            if (!string.IsNullOrWhiteSpace(explicacao)) blocos.Add(explicacao);
            _txtFeedback.Text = string.Join("\n\n", blocos);
            _txtFeedback.SelectAll();
            _txtFeedback.SelectionFont = new Font(_txtFeedback.Font, FontStyle.Regular);
            _txtFeedback.Select(0, (acertou ? "Você acertou!" : "Você errou.").Length);
            _txtFeedback.SelectionFont = new Font(_txtFeedback.Font, FontStyle.Bold);
            _txtFeedback.Select(0, 0);
            _pnlFeedback.BackColor = acertou ? Color.FromArgb(220, 252, 231) : Color.FromArgb(254, 226, 226);
            _txtFeedback.BackColor = _pnlFeedback.BackColor;
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
            try
            {
                string faixa = _pontuacao == _perguntas.Count ? "Excelente! Você demonstrou muito cuidado." :
                    _pontuacao >= (_perguntas.Count + 1) / 2 ? "Muito bem! Continue praticando os cuidados." :
                    "Tudo bem! Revise as dicas e tente novamente.";
                string erros = _respostasErradas.Count == 0 ? "\nVocê acertou todas as perguntas!" :
                    "\n\nPerguntas para revisar:\n" + string.Join("\n", _respostasErradas.Select((r, i) =>
                        $"{i + 1}. {r.Pergunta}\n   A resposta certa é: {r.RespostaCorreta}"));
                _txtResultado.Text = $"Resultado\n\nVocê acertou {_pontuacao} de {_perguntas.Count}.\n{faixa}{erros}";
                _tlpRaiz.Visible = false;
                _pnlResultado.Visible = true;
                _pnlResultado.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível exibir o resultado.\n{ex.Message}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRefazer_Click(object? sender, EventArgs e)
        {
            _indiceAtual = 0;
            _pontuacao = 0;
            _respostasErradas.Clear();
            IniciarRodada();
            _pnlResultado.Visible = false;
            _tlpRaiz.Visible = true;
            _tlpRaiz.BringToFront();
            MostrarPergunta(0);
        }

        private void BtnVoltarMenu_Click(object? sender, EventArgs e)
        {
            _janelaOrigem?.Show();
            Close();
        }

        private void FrmQuiz_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (_pnlResultado.Visible) Close();
                else if (MessageBox.Show("Sair do quiz? O progresso será perdido.", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) Close();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (_pnlResultado.Visible && e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (!_pnlResultado.Visible && !_respostaConfirmada && e.KeyCode is Keys.D1 or Keys.NumPad1 or Keys.D2 or Keys.NumPad2 or Keys.D3 or Keys.NumPad3 or Keys.D4 or Keys.NumPad4)
            {
                var indice = e.KeyCode is Keys.D1 or Keys.NumPad1 ? 0 : e.KeyCode is Keys.D2 or Keys.NumPad2 ? 1 : e.KeyCode is Keys.D3 or Keys.NumPad3 ? 2 : 3;
                new[] { RBtnAlt1, RBtnAlt2, RBtnAlt3, RBtnAlt4 }[indice].Checked = true;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (!_pnlResultado.Visible && e.KeyCode == Keys.Enter)
            {
                BtnConfirmar.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private sealed record OpcaoExibida(string Texto, int IndiceOriginal);
        private sealed record ResultadoPergunta(string Pergunta, string RespostaCorreta);

    }
}