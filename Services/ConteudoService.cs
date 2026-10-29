using System.Reflection;
using System.Text.Json;

namespace ProtetorDigital.Services;

public static class ConteudoService
{
    private static readonly JsonSerializerOptions Opcoes = new()
    {
        PropertyNameCaseInsensitive = true,
        ReadCommentHandling = JsonCommentHandling.Skip,
        AllowTrailingCommas = true
    };

    public static T? CarregarObjeto<T>(string nomeArquivo)
    {
        var caminho = LocalizarArquivo(nomeArquivo);
        if (caminho is null)
        {
            return default;
        }

        var json = File.ReadAllText(caminho);
        return JsonSerializer.Deserialize<T>(json, Opcoes);
    }

    public static string? LocalizarArquivo(string nomeArquivo)
    {
        var caminhoSaida = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dados", nomeArquivo);
        if (File.Exists(caminhoSaida))
        {
            return caminhoSaida;
        }

        var caminhoProjeto = Path.GetFullPath(Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "dados", nomeArquivo));
        return File.Exists(caminhoProjeto) ? caminhoProjeto : null;
    }

    public static string ObterVersaoAssembly()
    {
        var assembly = Assembly.GetEntryAssembly() ?? typeof(ConteudoService).Assembly;
        return assembly.GetName().Version?.ToString() ?? "1.0.0.0";
    }
}
