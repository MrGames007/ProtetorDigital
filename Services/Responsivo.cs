using System.Drawing;
using System.Windows.Forms;

namespace ProtetorDigital.Services;

public static class Responsivo
{
    private sealed class EstadoFormulario
    {
        public Size TamanhoBase { get; init; }
        public Dictionary<Control, float> TamanhosFonte { get; } = new();
        public float UltimaEscala { get; set; } = 1f;
        public System.Windows.Forms.Timer? Timer { get; set; }
        public Action? AposAplicar { get; init; }
    }

    private static readonly Dictionary<Form, EstadoFormulario> Estados = new();

    public static void Registrar(Form formulario, Size tamanhoBase, Action? aposAplicar = null)
    {
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
                    continue;
                }

                var tamanho = Math.Clamp(tamanhoBaseFonte * escala, 12f, 36f);
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
