using System.Text;

namespace ProtetorDigital.Services;

public static class RegistroErros
{
    // Gera relatórios objetivos para diagnosticar falhas ocorridas durante a execução.
    private const string NomeProjeto = "ProtetorDigital";

    public static string? Registrar(Exception excecao, string origem)
    {
        // A pasta e o arquivo são criados ao lado do executável, com data, hora e nome do projeto.
        try
        {
            var pasta = Path.Combine(AppContext.BaseDirectory, "Erros");
            Directory.CreateDirectory(pasta);

            var dataHora = DateTime.Now;
            var nomeArquivo = $"{dataHora:yyyy-MM-dd_HH-mm-ss-fff}_{NomeProjeto}.txt";
            var caminho = Path.Combine(pasta, nomeArquivo);
            var conteudo = new StringBuilder()
                .AppendLine($"Projeto: {NomeProjeto}")
                .AppendLine($"Data e hora: {dataHora:yyyy-MM-dd HH:mm:ss.fff zzz}")
                .AppendLine($"Origem: {origem}")
                .AppendLine($"Tipo: {excecao.GetType().FullName}")
                .AppendLine($"Mensagem: {excecao.Message}")
                .AppendLine("Stack trace:")
                .AppendLine(excecao.StackTrace ?? "não disponível")
                .ToString();

            File.WriteAllText(caminho, conteudo, Encoding.UTF8);
            return caminho;
        }
        catch
        {
            return null;
        }
    }
}
