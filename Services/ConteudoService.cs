using System.Reflection;
using System.Text.Json;

namespace ProtetorDigital.Services;

public static class ConteudoService
{
    // Centraliza a leitura e a desserialização dos JSONs usados pelas telas educativas.
    private static readonly JsonSerializerOptions Opcoes = new()
    {
        PropertyNameCaseInsensitive = true,
        ReadCommentHandling = JsonCommentHandling.Skip,
        AllowTrailingCommas = true
    };

    public static T? CarregarObjeto<T>(string nomeArquivo)
    {
        // Carrega arquivos cuja raiz representa um único objeto, como creditos.json.
        var json = RecursosApp.LerTexto("dados", nomeArquivo);
        if (json is null)
        {
            throw Falha(nomeArquivo, "arquivo não encontrado");
        }

        try
        {
            return JsonSerializer.Deserialize<T>(json, Opcoes) ?? throw Falha(nomeArquivo, "conteúdo vazio");
        }
        catch (ConteudoException) { throw; }
        catch (JsonException ex) { throw Falha(nomeArquivo, $"JSON inválido na linha {ex.LineNumber}", ex); }
        catch (Exception ex) { throw Falha(nomeArquivo, ex.Message, ex); }
    }

    public static List<T> CarregarLista<T>(string nomeArquivo)
    {
        // Aceita tanto um array JSON direto quanto uma raiz com a propriedade "itens".
        var json = RecursosApp.LerTexto("dados", nomeArquivo) ?? throw Falha(nomeArquivo, "arquivo não encontrado");
        try
        {
            using var documento = JsonDocument.Parse(json);
            var raiz = documento.RootElement.ValueKind == JsonValueKind.Array
                ? documento.RootElement
                : documento.RootElement.GetProperty("itens");
            var lista = raiz.Deserialize<List<T>>(Opcoes) ?? new List<T>();
            if (lista.Count == 0) throw Falha(nomeArquivo, "lista vazia");
            return lista;
        }
        catch (ConteudoException) { throw; }
        catch (JsonException ex) { throw Falha(nomeArquivo, $"JSON inválido na linha {ex.LineNumber}", ex); }
        catch (Exception ex) { throw Falha(nomeArquivo, ex.Message, ex); }
    }

    public static string ObterVersaoAssembly()
    {
        var assembly = Assembly.GetEntryAssembly() ?? typeof(ConteudoService).Assembly;
        return assembly.GetName().Version?.ToString() ?? "1.0.0.0";
    }

    private static ConteudoException Falha(string arquivo, string detalhe, Exception? inner = null)
    {
        // Converte falhas técnicas em erro de conteúdo e mantém um log de diagnóstico no perfil do usuário.
        var erro = new ConteudoException($"{arquivo}: {detalhe}", inner);
        try
        {
            var pasta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ProtetorDigital");
            Directory.CreateDirectory(pasta);
            File.AppendAllText(Path.Combine(pasta, "log.txt"), $"{DateTime.Now:O} {erro.Message}{Environment.NewLine}");
        }
        catch { }
        return erro;
    }

}

public sealed class ConteudoException : Exception
{
    public ConteudoException(string message, Exception? inner = null) : base(message, inner) { }
}
