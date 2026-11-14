using System.Drawing.Drawing2D;

namespace ProtetorDigital.Services;

public static class FundoCache
{
    // Reutiliza o bitmap de fundo para reduzir custo de redimensionamento e repintura das janelas.
    private static readonly object Sincronizacao = new();
    private static Bitmap? _bitmap;
    private static Size _tamanho;

    public static void Precarregar(Image? imagem, Size tamanho)
    {
        // Permite preparar o fundo antes da primeira pintura da tela.
        if (imagem is null) return;
        Obter(imagem, tamanho);
    }

    public static Bitmap? Obter(Image? imagem, Size tamanho)
    {
        // Retorna o cache quando o tamanho é próximo; caso contrário cria uma nova imagem suavizada.
        if (imagem is null || tamanho.Width <= 0 || tamanho.Height <= 0) return null;
        lock (Sincronizacao)
        {
            if (_bitmap is not null && Math.Abs(_tamanho.Width - tamanho.Width) <= 50 && Math.Abs(_tamanho.Height - tamanho.Height) <= 50)
                return _bitmap;

            var novo = new Bitmap(tamanho.Width, tamanho.Height, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
            using (var graphics = Graphics.FromImage(novo))
            {
                graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
                graphics.DrawImage(imagem, new Rectangle(Point.Empty, tamanho));
            }
            _bitmap?.Dispose();
            _bitmap = novo;
            _tamanho = tamanho;
            return _bitmap;
        }
    }
}
