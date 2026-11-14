using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProtetorDigital.Services;

namespace ProtetorDigital.Forms
{
    public partial class FrmExGolpes : Form
    {
        // Apresenta exemplos de golpes e seus sinais de alerta, um registro por vez.
        private List<ExGolpe> _golpes = new();
        private int _indice = 0;

        private Form _janelaOrigem;
        public FrmExGolpes(Form origem)
        {
            // Configura serviços comuns, navegação e limites de fonte dos botões.
            _janelaOrigem = origem;
            InitializeComponent();
            ProtetorDigital.Services.JanelaPadrao.Registrar(this);
            ProtetorDigital.Services.Suavizar.Aplicar(this);
            BtnAvancar.Click += BtnAvancar_Click;
            BtnAnterior.Click += BtnAnterior_Click;
            ConfigurarBotaoNavegacao(BtnAnterior);
            ConfigurarBotaoNavegacao(BtnAvancar);
            flowLayoutPanel1.SizeChanged += (_, _) => AjustarLarguras();
            Load += FrmExGolpes_Load;
            MinimumSize = new Size(800, 600);
            MaximizeBox = true;
            ProtetorDigital.Services.Responsivo.Registrar(this, new Size(1100, 650), () => LarguraTexto.Ajustar(flowLayoutPanel1, lblNomeGolpe, lblFuncionamento, lblTexto, lblSinaisAlerta));
            ProtetorDigital.Services.Responsivo.LimitarFonte(BtnAnterior, 14f, 22f);
            ProtetorDigital.Services.Responsivo.LimitarFonte(BtnAvancar, 14f, 22f);
        }

        private void AjustarLarguras()
        {
            // Mantém nomes, explicações e alertas dentro da área rolável.
            LarguraTexto.Ajustar(flowLayoutPanel1, lblNomeGolpe, lblFuncionamento, lblTexto, lblSinaisAlerta);
        }

        private void FrmExGolpes_Load(object? sender, EventArgs e)
        {
            // Carrega os exemplos do JSON quando a tela é exibida.
            try
            {
                _golpes = ConteudoService.CarregarLista<ExGolpe>("exgolpes.json");
                MostrarGolpe(0);
                AjustarLarguras();
            }
            catch (ConteudoException ex)
            {
                MessageBox.Show($"Não consegui abrir o conteúdo desta tela. Detalhe: {ex.Message}");
                Close();
            }
        }

        private void MostrarGolpe(int indice)
        {
            // Preenche o golpe atual e atualiza os limites da navegação.
            if (indice < 0 || indice >= _golpes.Count) return;
            _indice = indice;
            var g = _golpes[indice];
            lblNomeGolpe.Text = g.NomeGolpe ?? string.Empty;
            lblFuncionamento.Text = g.ComoFunciona ?? string.Empty;
            if (g.SinaisDeAlerta != null && g.SinaisDeAlerta.Any())
            {
                var sb = new StringBuilder();
                foreach (var s in g.SinaisDeAlerta) sb.AppendLine("- " + s);
                lblSinaisAlerta.Text = sb.ToString();
            }
            else
            {
                lblSinaisAlerta.Text = string.Empty;
            }

            BtnAnterior.Enabled = _indice > 0;
            BtnAvancar.Enabled = _indice < _golpes.Count - 1;
            AjustarLarguras();
        }

        private void BtnAvancar_Click(object? sender, EventArgs e)
        {
            // Mostra o próximo exemplo somente se ele existir.
            if (_indice + 1 < _golpes.Count) MostrarGolpe(_indice + 1);
        }

        private void BtnAnterior_Click(object? sender, EventArgs e)
        {
            // Mostra o exemplo anterior sem alterar a lista original.
            if (_indice - 1 >= 0) MostrarGolpe(_indice - 1);
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            // Fecha a janela modal de exemplos.
            this.Close();
        }

        private static void ConfigurarBotaoNavegacao(Button botao)
        {
            // Mantém o texto do botão legível mesmo no estado desabilitado.
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
