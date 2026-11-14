namespace ProtetorDigital.Models;

public sealed class CreditosInfo
{
    // Representa a raiz de dados usada pela tela de Créditos.
    public string? Titulo { get; set; }
    public string? Subtitulo { get; set; }
    public List<LinhaCredito> Linhas { get; set; } = new();
    public List<CartaoCredito> Cartoes { get; set; } = new();
}

public sealed class LinhaCredito
{
    // Par rótulo/valor exibido na tabela institucional de créditos.
    public string? Rotulo { get; set; }
    public string? Valor { get; set; }
}

public sealed class CartaoCredito
{
    // Cartão visual com título, logo opcional e texto explicativo.
    public string? Titulo { get; set; }
    public string? Logo { get; set; }
    public string? Texto { get; set; }
}
