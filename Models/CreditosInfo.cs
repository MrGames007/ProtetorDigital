namespace ProtetorDigital.Models;

public sealed class CreditosInfo
{
    public string? Titulo { get; set; }
    public string? Subtitulo { get; set; }
    public List<LinhaCredito> Linhas { get; set; } = new();
    public List<CartaoCredito> Cartoes { get; set; } = new();
}

public sealed class LinhaCredito
{
    public string? Rotulo { get; set; }
    public string? Valor { get; set; }
}

public sealed class CartaoCredito
{
    public string? Titulo { get; set; }
    public string? Logo { get; set; }
    public string? Texto { get; set; }
}
