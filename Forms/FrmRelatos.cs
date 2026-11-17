using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProtetorDigital.Services;

namespace ProtetorDigital.Forms
{
    public partial class FrmRelatos : Form
    {
        // Exibe casos, fontes e lições aprendidas com navegação sequencial.
        private List<Relato> _relatos = new();
        private int _indice = 0;
        private FormWindowState _estadoJanelaAnterior;
        private Form _janelaOrigem;
        public FrmRelatos(Form origem)
        {
            // Configura o formulário, o link da matéria e o ajuste responsivo dos textos.
            InitializeComponent();
            _estadoJanelaAnterior = WindowState;
            ProtetorDigital.Services.JanelaPadrao.Registrar(this);
            ProtetorDigital.Services.Suavizar.Aplicar(this);
            _janelaOrigem = origem;
            BtnAvancar.Click += BtnAvancar_Click;
            BtnAnterior.Click += BtnAnterior_Click;
            ConfigurarBotaoNavegacao(BtnAnterior);
            ConfigurarBotaoNavegacao(BtnAvancar);
            flowLayoutPanel1.SizeChanged += (_, _) => LarguraTexto.Ajustar(flowLayoutPanel1, lblTitulo, lblFonte, lnkMateria, lblVitima, lblRelato, lblTexto, lblLicoesAprendidas);
            ResizeEnd += FrmRelatos_ResizeEnd;
            Load += FrmRelatos_Load;
            MinimumSize = new Size(800, 600);
            MaximizeBox = true;
            ProtetorDigital.Services.Responsivo.Registrar(this, new Size(1100, 650), () => LarguraTexto.Ajustar(flowLayoutPanel1, lblTitulo, lblFonte, lnkMateria, lblVitima, lblRelato, lblTexto, lblLicoesAprendidas));
            ProtetorDigital.Services.Responsivo.LimitarFonte(BtnAnterior, 14f, 22f);
            ProtetorDigital.Services.Responsivo.LimitarFonte(BtnAvancar, 14f, 22f);
        }

        private void FrmRelatos_ResizeEnd(object? sender, EventArgs e)
        {
            // Recalcula o painel e volta ao início quando a janela alterna entre normal e maximizada.
            var estadoAlterado = WindowState != _estadoJanelaAnterior;
            _estadoJanelaAnterior = WindowState;
            LarguraTexto.Ajustar(flowLayoutPanel1, lblTitulo, lblFonte, lnkMateria, lblVitima, lblRelato, lblTexto, lblLicoesAprendidas);

            if (!estadoAlterado)
            {
                return;
            }

            BeginInvoke(() =>
            {
                flowLayoutPanel1.AutoScrollPosition = Point.Empty;
                flowLayoutPanel1.PerformLayout();
                LarguraTexto.Ajustar(flowLayoutPanel1, lblTitulo, lblFonte, lnkMateria, lblVitima, lblRelato, lblTexto, lblLicoesAprendidas);
            });
        }

        private void FrmRelatos_Load(object? sender, EventArgs e)
        {
            // Carrega os relatos e inicia a exibição pelo primeiro registro.
            try
            {
                _relatos = ConteudoService.CarregarLista<Relato>("relatos.json");
                MostrarRelato(0);
                LarguraTexto.Ajustar(flowLayoutPanel1, lblTitulo, lblFonte, lnkMateria, lblVitima, lblRelato, lblTexto, lblLicoesAprendidas);
            }
            catch (ConteudoException ex)
            {
                MessageBox.Show($"Não consegui abrir o conteúdo desta tela. Detalhe: {ex.Message}");
                Close();
            }
        }

        private void MostrarRelato(int indice)
        {
            // Mapeia o relato para os controles, valida o link e atualiza a navegação.
            if (indice < 0 || indice >= _relatos.Count) return;
            _indice = indice;
            var r = _relatos[indice];

            // Vincula cada campo JSON ao seu label correspondente
            lblTitulo.Text = r.Titulo ?? string.Empty;
            lblFonte.Text = r.Fonte ?? string.Empty;
            lblVitima.Text = r.Vitima ?? string.Empty;
            lblRelato.Text = r.Conteudo ?? string.Empty;
            lblLicoesAprendidas.Text = r.LicoesAprendidas ?? string.Empty;
            lblFonte.Text = !string.IsNullOrWhiteSpace(r.Tipo) && r.Tipo == "ilustrativo"
                ? "Caso ilustrativo, baseado em modalidades reais"
                : r.Tipo == "alerta_oficial" ? "Alerta oficial do INSS" : $"Fonte: {r.Fonte} ({r.Data})";
            lnkMateria.Tag = r.Url;
            lnkMateria.Visible = Uri.TryCreate(r.Url, UriKind.Absolute, out var uri) && uri.Scheme is "http" or "https";

            // Atualiza estado dos botões de navegação
            BtnAnterior.Enabled = _indice > 0;
            BtnAvancar.Enabled = _indice < _relatos.Count - 1;
            LarguraTexto.Ajustar(flowLayoutPanel1, lblTitulo, lblFonte, lnkMateria, lblVitima, lblRelato, lblTexto, lblLicoesAprendidas);
        }

        private void LnkMateria_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            // Abre somente URLs HTTP/HTTPS válidas no navegador padrão do sistema.
            if (lnkMateria.Tag is not string url) return;
            try { System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(url) { UseShellExecute = true }); }
            catch { MessageBox.Show($"Não foi possível abrir o navegador. Endereço da matéria: {url}"); }
        }

        private void BtnAvancar_Click(object? sender, EventArgs e)
        {
            // Avança para o próximo relato quando o índice ainda está dentro da lista.
            if (_indice + 1 < _relatos.Count) MostrarRelato(_indice + 1);
        }

        private void BtnAnterior_Click(object? sender, EventArgs e)
        {
            // Retorna ao relato anterior sem fechar a janela.
            // Navega para o relato anterior, se existir
            if (_indice - 1 >= 0) MostrarRelato(_indice - 1);
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            // Fecha a janela modal de relatos.
            this.Close();
        }

        private static void ConfigurarBotaoNavegacao(Button botao)
        {
            // Redesenha o estado desabilitado para conservar contraste e legibilidade.
            botao.EnabledChanged += (_, _) => botao.BackColor = botao.Enabled
                ? Color.FromArgb(0, 120, 215)
                : Color.FromArgb(127, 169, 214);
            botao.Paint += (_, e) =>
            {
                if (botao.Enabled) return;
                e.Graphics.Clear(botao.BackColor);
                TextRenderer.DrawText(e.Graphics, botao.Text, botao.Font, botao.ClientRectangle,
                    Color.White, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);
            };
        }

    }
}
