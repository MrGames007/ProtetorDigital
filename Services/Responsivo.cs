using System.Drawing;
using System.Windows.Forms;

namespace ProtetorDigital.Services;

public static class Responsivo
{
    // Redimensiona fontes sem alterar a lógica das telas e permite callbacks de layout após a escala.
    private sealed class EstadoFormulario
    {
        // Estado isolado de cada Form: fontes originais, limites, timer e ação pós-aplicação.
        public Size TamanhoBase { get; init; }
        public Dictionary<Control, float> TamanhosFonte { get; } = new();
        public Dictionary<Control, (float Minimo, float Maximo)> LimitesFonte { get; } = new();
        public float UltimaEscala { get; set; } = 1f;
        public System.Windows.Forms.Timer? Timer { get; set; }
        public Action? AposAplicar { get; init; }
    }

    public static void LimitarFonte(Control controle, float minimo, float maximo)
    {
        // Alguns botões têm faixa própria para continuar legíveis em telas maximizadas.
        if (controle.FindForm() is Form formulario && Estados.TryGetValue(formulario, out var estado))
        {
            estado.LimitesFonte[controle] = (minimo, maximo);
            Redimensionar(formulario, estado);
        }
    }

    private static readonly Dictionary<Form, EstadoFormulario> Estados = new();

    public static void Registrar(Form formulario, Size tamanhoBase, Action? aposAplicar = null)
    {
        // Registra a árvore de controles e agenda os ajustes durante Resize/SizeChanged.
        if (Estados.ContainsKey(formulario))
        {
            return;
        }

        var estado = new EstadoFormulario { TamanhoBase = tamanhoBase, AposAplicar = aposAplicar };
        Estados[formulario] = estado;
        RegistrarControles(formulario, estado);
        formulario.Load += (_, _) =>
        {
            formulario.SuspendLayout();
            Redimensionar(formulario, estado);
            formulario.PerformLayout();
            formulario.ResumeLayout(true);
        };
        estado.Timer = new System.Windows.Forms.Timer { Interval = 60 };
        estado.Timer.Tick += (_, _) => { estado.Timer.Stop(); Redimensionar(formulario, estado); estado.AposAplicar?.Invoke(); };
        formulario.Resize += (_, _) => { estado.Timer.Stop(); estado.Timer.Start(); };
        formulario.ResizeEnd += (_, _) => Redimensionar(formulario, estado);
        formulario.SizeChanged += (_, _) => { if (formulario.WindowState != FormWindowState.Minimized) estado.Timer.Start(); };
        formulario.FormClosed += (_, _) =>
        {
            foreach (var controle in estado.TamanhosFonte.Keys.ToList())
            {
                estado.TamanhosFonte.Remove(controle);
                estado.LimitesFonte.Remove(controle);
            }
            Estados.Remove(formulario);
            estado.Timer?.Dispose();
        };
        Redimensionar(formulario, estado);
    }

    public static void Registrar(Control controle)
    {
        if (controle.FindForm() is Form formulario && Estados.TryGetValue(formulario, out var estado))
        {
            RegistrarControle(controle, estado);
            Redimensionar(formulario, estado);
        }
    }

    private static void RegistrarControles(Control controle, EstadoFormulario estado)
    {
        RegistrarControle(controle, estado);
        foreach (Control filho in controle.Controls)
        {
            RegistrarControles(filho, estado);
        }
    }

    private static void RegistrarControle(Control controle, EstadoFormulario estado)
    {
        if (controle is Form || estado.TamanhosFonte.ContainsKey(controle))
        {
            return;
        }

        estado.TamanhosFonte[controle] = controle.Font.Size;
        foreach (Control filho in controle.Controls)
        {
            RegistrarControle(filho, estado);
        }
    }

    private static void Redimensionar(Form formulario, EstadoFormulario estado)
    {
        // Calcula uma escala limitada e recria as fontes a partir do tamanho original, sem acumular erro.
        var larguraBase = Math.Max(1, estado.TamanhoBase.Width);
        var alturaBase = Math.Max(1, estado.TamanhoBase.Height);
        var escala = Math.Clamp(
            Math.Min((float)formulario.ClientSize.Width / larguraBase, (float)formulario.ClientSize.Height / alturaBase),
            0.85f, 1.6f);

        if (Math.Abs(escala - estado.UltimaEscala) < 0.02f)
        {
            return;
        }

        formulario.SuspendLayout();
        try
        {
            foreach (var (controle, tamanhoBaseFonte) in estado.TamanhosFonte.ToList())
            {
                if (controle.IsDisposed)
                {
                    estado.TamanhosFonte.Remove(controle);
                    estado.LimitesFonte.Remove(controle);
                    continue;
                }

                var limites = estado.LimitesFonte.TryGetValue(controle, out var limite)
                    ? limite
                    : (12f, 36f);
                var tamanho = Math.Clamp(tamanhoBaseFonte * escala, limites.Item1, limites.Item2);
                var fonteAnterior = controle.Font;
                controle.Font = new Font(fonteAnterior.FontFamily, tamanho, fonteAnterior.Style, fonteAnterior.Unit, fonteAnterior.GdiCharSet, fonteAnterior.GdiVerticalFont);
                if (!ReferenceEquals(fonteAnterior, formulario.Font))
                {
                    fonteAnterior.Dispose();
                }
            }
            estado.UltimaEscala = escala;
        }
        finally
        {
            formulario.ResumeLayout(true);
        }
        estado.AposAplicar?.Invoke();
    }

    public static void AjustarParaCaber(Control controle)
    {
        // Reduz gradualmente textos que não cabem em Labels, RadioButtons ou Buttons.
        if (controle is not (Label or RadioButton or Button) || controle.Width <= 0 || controle.Height <= 0)
        {
            return;
        }

        for (var tentativa = 0; tentativa < 12 && controle.Font.Size > 12f; tentativa++)
        {
            var largura = Math.Max(1, controle.ClientSize.Width - controle.Padding.Horizontal);
            var altura = Math.Max(1, controle.ClientSize.Height - controle.Padding.Vertical);
            var flags = controle is Label or RadioButton ? TextFormatFlags.WordBreak : TextFormatFlags.NoPadding;
            var medido = TextRenderer.MeasureText(controle.Text, controle.Font, new Size(largura, int.MaxValue), flags);
            var palavraMaior = controle.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Any(palavra => TextRenderer.MeasureText(palavra, controle.Font, Size.Empty, TextFormatFlags.NoPadding).Width > largura);
            var umaLinha = controle is Button || controle == controle.Parent?.Controls[0] && controle.Text.StartsWith("Pergunta", StringComparison.Ordinal);
            if ((!umaLinha && medido.Height <= altura && !palavraMaior) ||
                (umaLinha && medido.Width <= largura))
            {
                break;
            }

            var antiga = controle.Font;
            controle.Font = new Font(antiga.FontFamily, Math.Max(12f, antiga.Size - 1f), antiga.Style, antiga.Unit);
            antiga.Dispose();
        }
    }

}
