using System.Reflection;
using ProtetorDigital.Models;
using ProtetorDigital.Services;

namespace ProtetorDigital.Forms;

public sealed class FrmCreditos : Form
{
    private readonly TableLayoutPanel _principal;
    private readonly Button _fechar;

    public FrmCreditos()
    {
        JanelaPadrao.Registrar(this);
        var info = ConteudoService.CarregarObjeto<CreditosInfo>("creditos.json") ?? new CreditosInfo();
        Text = info.Titulo ?? string.Empty;
        MinimumSize = new Size(800, 600);
        StartPosition = FormStartPosition.CenterScreen;
        WindowState = FormWindowState.Normal;
        KeyPreview = true;
        AcceptButton = null;
        CancelButton = null;
        BackColor = Color.FromArgb(245, 247, 248);

        _fechar = new Button
        {
            Text = "Fechar",
            AutoSize = true,
            MinimumSize = new Size(150, 42),
            Anchor = AnchorStyles.None,
            DialogResult = DialogResult.OK,
            BackColor = Color.FromArgb(15, 124, 138),
            ForeColor = Color.White,
            FlatStyle = FlatStyle.Flat,
            Font = new Font("Segoe UI", 12, FontStyle.Bold)
        };
        _fechar.FlatAppearance.BorderSize = 0;
        _fechar.Click += (_, _) => Close();
        AcceptButton = _fechar;
        CancelButton = _fechar;
        KeyDown += (_, e) =>
        {
            if (e.KeyCode is Keys.Escape or Keys.Enter)
            {
                Close();
            }
        };

        _principal = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            ColumnCount = 1,
            RowCount = 5,
            Padding = new Padding(28),
            BackColor = BackColor
        };
        _principal.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        _principal.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        _principal.RowStyles.Add(new RowStyle(SizeType.Percent, 55));
        _principal.RowStyles.Add(new RowStyle(SizeType.Percent, 35));
        _principal.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        Controls.Add(_principal);

        var titulo = new Label
        {
            Text = info.Titulo ?? string.Empty,
            Dock = DockStyle.Fill,
            AutoSize = true,
            TextAlign = ContentAlignment.MiddleCenter,
            Font = new Font("Segoe UI", 30, FontStyle.Bold),
            ForeColor = Color.FromArgb(33, 37, 41),
            Padding = new Padding(0, 0, 0, 8)
        };
        _principal.Controls.Add(titulo, 0, 0);

        var subtitulo = new Label
        {
            Text = info.Subtitulo ?? string.Empty,
            Dock = DockStyle.Fill,
            AutoSize = true,
            TextAlign = ContentAlignment.MiddleCenter,
            Font = new Font("Segoe UI", 13),
            ForeColor = Color.FromArgb(70, 70, 70),
            Padding = new Padding(0, 0, 0, 14)
        };
        _principal.Controls.Add(subtitulo, 0, 1);

        var linhas = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            AutoScroll = true,
            ColumnCount = 2,
            RowCount = Math.Max(1, info.Linhas.Count),
            BackColor = Color.White,
            CellBorderStyle = TableLayoutPanelCellBorderStyle.Single,
            Padding = new Padding(14)
        };
        linhas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32));
        linhas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68));
        for (var i = 0; i < info.Linhas.Count; i++)
        {
            linhas.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            var linha = info.Linhas[i];
            linhas.Controls.Add(new Label
            {
                Text = linha.Rotulo ?? string.Empty,
                AutoSize = true,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                Padding = new Padding(5)
            }, 0, i);
            var valor = linha.Valor ?? string.Empty;
            if (string.Equals(linha.Rotulo, "Versão:", StringComparison.OrdinalIgnoreCase) && string.Equals(valor, "auto", StringComparison.OrdinalIgnoreCase))
            {
                valor = (Assembly.GetEntryAssembly() ?? Assembly.GetExecutingAssembly()).GetName().Version?.ToString() ?? string.Empty;
            }
            linhas.Controls.Add(new Label
            {
                Text = valor,
                AutoSize = true,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 11),
                Padding = new Padding(5)
            }, 1, i);
        }
        var linhasCartao = new Panel { Dock = DockStyle.Fill, Padding = new Padding(0, 10, 0, 10) };
        linhasCartao.Controls.Add(linhas);
        _principal.Controls.Add(linhasCartao, 0, 2);

        var cartoes = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            ColumnCount = 2,
            RowCount = 1,
            Padding = new Padding(0, 10, 0, 10)
        };
        cartoes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
        cartoes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
        for (var i = 0; i < Math.Min(2, info.Cartoes.Count); i++)
        {
            cartoes.Controls.Add(CriarCartao(info.Cartoes[i]), i, 0);
        }
        _principal.Controls.Add(cartoes, 0, 3);
        _principal.Controls.Add(_fechar, 0, 4);
        Responsivo.Registrar(this, new Size(1000, 700));
        foreach (Control controle in Controls)
        {
            Responsivo.Registrar(controle);
        }
    }

    private static Control CriarCartao(CartaoCredito cartao)
    {
        var painel = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            ColumnCount = 1,
            RowCount = 3,
            Margin = new Padding(8),
            BackColor = Color.White,
            CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
        };
        painel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        painel.RowStyles.Add(new RowStyle(SizeType.Percent, 65));
        painel.RowStyles.Add(new RowStyle(SizeType.Percent, 35));
        painel.Controls.Add(new Label
        {
            Text = cartao.Titulo ?? string.Empty,
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter,
            AutoSize = true,
            Font = new Font("Segoe UI", 13, FontStyle.Bold),
            Padding = new Padding(5)
        }, 0, 0);
        var corpo = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 1, RowCount = 2 };
        corpo.RowStyles.Add(new RowStyle(SizeType.Percent, 70));
        corpo.RowStyles.Add(new RowStyle(SizeType.Percent, 30));
        var logo = new PictureBox { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom, Margin = new Padding(8) };
        var caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imagens", cartao.Logo ?? string.Empty);
        if (File.Exists(caminho))
        {
            using var imagem = Image.FromFile(caminho);
            logo.Image = new Bitmap(imagem);
        }
        corpo.Controls.Add(logo, 0, 0);
        corpo.Controls.Add(new Label
        {
            Text = cartao.Texto ?? string.Empty,
            Dock = DockStyle.Fill,
            AutoSize = true,
            TextAlign = ContentAlignment.MiddleCenter,
            Font = new Font("Segoe UI", 12, FontStyle.Bold),
            Padding = new Padding(5)
        }, 0, 1);
        painel.Controls.Add(corpo, 0, 1);
        painel.Controls.Add(new Panel { Dock = DockStyle.Fill }, 0, 2);
        return painel;
    }
}
