using System.Drawing;
using System.Windows.Forms;

namespace ProtetorDigital.Services;

public static class LarguraTexto
{
    // Mantém textos longos das telas de conteúdo dentro da largura útil do painel rolável.
    public static void Ajustar(FlowLayoutPanel painel, params Label[] labels)
    {
        // Desconta padding, rolagem e margem antes de permitir a quebra vertical dos textos.
        var largura = Math.Max(200, painel.ClientSize.Width - painel.Padding.Horizontal - SystemInformation.VerticalScrollBarWidth);
        foreach (var label in labels)
        {
            if (label is null || !label.Visible)
            {
                continue;
            }

            label.MaximumSize = new Size(Math.Max(200, largura - label.Margin.Horizontal), 0);
            label.AutoSize = true;
        }
    }
}
