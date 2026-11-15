using System.Reflection;
using System.Text;

namespace ProtetorDigital.Services;

public static class RecursosApp
{
    // Lê primeiro uma versão externa editável e usa o recurso embutido como fallback.
    public static string? LerTexto(string subpasta, string arquivo)
    {
        try
        {
            var caminhoExterno = LocalizarArquivoExterno(subpasta, arquivo);
            if (caminhoExterno is not null)
            {
                return File.ReadAllText(caminhoExterno, Encoding.UTF8);
            }

            using var fluxo = AbrirRecurso(subpasta, arquivo);
            if (fluxo is null)
            {
                return null;
            }

            using var leitor = new StreamReader(fluxo, Encoding.UTF8, detectEncodingFromByteOrderMarks: true);
            return leitor.ReadToEnd();
        }
        catch
        {
            return null;
        }
    }

    public static Image? CarregarImagem(string subpasta, string arquivo)
    {
        try
        {
            var caminhoExterno = LocalizarArquivoExterno(subpasta, arquivo);
            if (caminhoExterno is not null)
            {
                try
                {
                    using var fluxoExterno = File.OpenRead(caminhoExterno);
                    using var imagemExterna = new Bitmap(fluxoExterno);
                    return new Bitmap(imagemExterna);
                }
                catch
                {
                }
            }

            using var fluxo = AbrirRecurso(subpasta, arquivo);
            if (fluxo is null)
            {
                return null;
            }

            using var imagem = new Bitmap(fluxo);
            return new Bitmap(imagem);
        }
        catch
        {
            return null;
        }
    }

    public static bool Existe(string subpasta, string arquivo)
    {
        try
        {
            if (LocalizarArquivoExterno(subpasta, arquivo) is not null)
            {
                return true;
            }

            using var recurso = AbrirRecurso(subpasta, arquivo);
            return recurso is not null;
        }
        catch
        {
            return false;
        }
    }

    private static string? LocalizarArquivoExterno(string subpasta, string arquivo)
    {
        // A pasta do processo atende à publicação e a base da aplicação atende ao desenvolvimento.
        var candidatos = new[]
        {
            ObterPastaDoProcesso(),
            AppContext.BaseDirectory
        };

        foreach (var pasta in candidatos.Where(pasta => !string.IsNullOrWhiteSpace(pasta)).Distinct(StringComparer.OrdinalIgnoreCase))
        {
            var caminho = Path.Combine(pasta!, subpasta, arquivo);
            if (File.Exists(caminho))
            {
                return caminho;
            }
        }

        return null;
    }

    private static string? ObterPastaDoProcesso()
    {
        var caminhoProcesso = Environment.ProcessPath;
        return string.IsNullOrWhiteSpace(caminhoProcesso) ? null : Path.GetDirectoryName(caminhoProcesso);
    }

    private static Stream? AbrirRecurso(string subpasta, string arquivo)
    {
        // O nome lógico permite localizar diretamente o recurso; o sufixo cobre nomes gerados pelo MSBuild.
        var assembly = Assembly.GetExecutingAssembly();
        var nome = $"{subpasta}.{arquivo}";
        var fluxo = assembly.GetManifestResourceStream(nome);
        if (fluxo is not null)
        {
            return fluxo;
        }

        var nomeEncontrado = assembly.GetManifestResourceNames()
            .FirstOrDefault(recurso => recurso.EndsWith(nome, StringComparison.OrdinalIgnoreCase));
        return nomeEncontrado is null ? null : assembly.GetManifestResourceStream(nomeEncontrado);
    }
}
