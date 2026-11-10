using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProtetorDigital.Services;

namespace ProtetorDigital.Forms
{
    public partial class FrmRelatos : Form
    {
        private List<Relato> _relatos = new();
        private int _indice = 0;
        private Form _janelaOrigem;
        public FrmRelatos(Form origem)
        {
            InitializeComponent();
            ProtetorDigital.Services.JanelaPadrao.Registrar(this);
            ProtetorDigital.Services.Suavizar.Aplicar(this);
            _janelaOrigem = origem;
            BtnAvancar.Click += BtnAvancar_Click;
            BtnVoltar.Click += BtnVoltar_Click;
            Load += FrmRelatos_Load;
            MinimumSize = new Size(800, 600);
            MaximizeBox = true;
            ProtetorDigital.Services.Responsivo.Registrar(this, new Size(1100, 650));
            Resize += (_, _) => AjustarLarguras();
        }

        private void FrmRelatos_Load(object? sender, EventArgs e)
        {
            try
            {
                _relatos = ConteudoService.CarregarLista<Relato>("relatos.json");
                MostrarRelato(0);
                AjustarLarguras();
            }
            catch (ConteudoException ex)
            {
                MessageBox.Show($"Não consegui abrir o conteúdo desta tela. Detalhe: {ex.Message}");
                Close();
            }
        }

        private void AjustarLarguras()
        {
            var largura = Math.Max(100, ClientSize.Width - 70);
            foreach (var label in new[] { lblFonte, lblVitima, lblRelato, lblLicoesAprendidas })
            {
                label.MaximumSize = new Size(largura, 0);
                label.AutoSize = true;
            }
        }
        private void MostrarRelato(int indice)
        {
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
            BtnVoltar.Enabled = _indice > 0;
            BtnAvancar.Enabled = _indice < _relatos.Count - 1;
        }

        private void LnkMateria_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lnkMateria.Tag is not string url) return;
            try { System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(url) { UseShellExecute = true }); }
            catch { MessageBox.Show($"Não foi possível abrir o navegador. Endereço da matéria: {url}"); }
        }

        private void BtnAvancar_Click(object? sender, EventArgs e)
        {
            if (_indice + 1 < _relatos.Count) MostrarRelato(_indice + 1);
        }

        private void BtnVoltar_Click(object? sender, EventArgs e)
        {
            // Navega para o relato anterior, se existir
            if (_indice - 1 >= 0) MostrarRelato(_indice - 1);
        }

        private void BtnRetorno_Click(object sender, EventArgs e)
        {
            _janelaOrigem.Show();
            this.Close();
        }

        
    }
}
