using System.Drawing;

namespace ProtetorDigital.Services;

public static class Responsivo
{
    private sealed class EstadoFormulario
    {
        public Size TamanhoBase { get; init; }
        public Dictionary<Control, float> TamanhosFonte { get; } = new();
        public float UltimaEscala { get; set; } = 1f;
    }

    private static readonly Dictionary<Form, EstadoFormulario> Estados = new();

    public static void Registrar(Form formulario, Size tamanhoBase)
    {
        if (Estados.ContainsKey(formulario))
        {
            return;
        }

        var estado = new EstadoFormulario { TamanhoBase = tamanhoBase };
        Estados[formulario] = estado;
        RegistrarControles(formulario, estado);
        formulario.Resize += (_, _) => Redimensionar(formulario, estado);
        formulario.FormClosed += (_, _) =>
        {
            foreach (var controle in estado.TamanhosFonte.Keys.ToList())
            {
                estado.TamanhosFonte.Remove(controle);
            }
            Estados.Remove(formulario);
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
            0.85f, 2f);

        if (Math.Abs(escala - estado.UltimaEscala) < 0.02f)
        {
            AtualizarLarguras(formulario);
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

                var tamanho = Math.Max(12f, tamanhoBaseFonte * escala);
                var fonteAnterior = controle.Font;
                controle.Font = new Font(fonteAnterior.FontFamily, tamanho, fonteAnterior.Style, fonteAnterior.Unit, fonteAnterior.GdiCharSet, fonteAnterior.GdiVerticalFont);
                if (!ReferenceEquals(fonteAnterior, formulario.Font))
                {
                    fonteAnterior.Dispose();
                }
            }
            estado.UltimaEscala = escala;
            AtualizarLarguras(formulario);
        }
        finally
        {
            formulario.ResumeLayout(true);
        }
    }

    private static void AtualizarLarguras(Control controle)
    {
        foreach (Control filho in controle.Controls)
        {
            if (filho is Label label && label.AutoSize && label.MaximumSize.Height == 0)
            {
                var margem = label.Parent is null ? 0 : label.Margin.Horizontal + label.Parent.Padding.Horizontal;
                label.MaximumSize = new Size(Math.Max(100, label.Parent!.ClientSize.Width - label.Left - margem), 0);
            }
            AtualizarLarguras(filho);
        }
    }
}
