using System.Text;
using System.Text.Json;

namespace ProtetorDigital.Services
{
    public sealed class ConteudoException : Exception
    {
        public ConteudoException(string message) : base(message)
        {
        }
    }

    public sealed class ConteudoService
    {
        private readonly string _diretorioDados;

        public ConteudoService()
        {
            _diretorioDados = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dados");
        }

        public List<T> CarregarLista<T>(string nomeArquivo)
        {
            string caminho = Path.Combine(_diretorioDados, nomeArquivo);

            try
            {
                if (!File.Exists(caminho))
                {
                    throw new ConteudoException($"O arquivo {nomeArquivo} não foi encontrado.");
                }

                string json = File.ReadAllText(caminho, Encoding.UTF8);
                using JsonDocument documento = JsonDocument.Parse(json);
                JsonElement conteudo = documento.RootElement;

                if (conteudo.ValueKind == JsonValueKind.Object)
                {
                    if (!conteudo.TryGetProperty("itens", out conteudo))
                    {
                        throw new ConteudoException($"O arquivo {nomeArquivo} não contém itens válidos.");
                    }
                }

                if (conteudo.ValueKind != JsonValueKind.Array)
                {
                    throw new ConteudoException($"O arquivo {nomeArquivo} não contém uma lista válida.");
                }

                return JsonSerializer.Deserialize<List<T>>(conteudo.GetRawText(),
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true }) ?? new List<T>();
            }
            catch (ConteudoException ex)
            {
                RegistrarErro(nomeArquivo, ex.Message, ex);
                throw;
            }
            catch (JsonException ex)
            {
                long linha = (ex.LineNumber ?? 0) + 1;
                long posicao = (ex.BytePositionInLine ?? 0) + 1;
                string mensagem = $"Erro no arquivo {nomeArquivo}, linha {linha}, posição {posicao}.";
                RegistrarErro(nomeArquivo, mensagem, ex);
                throw new ConteudoException(mensagem);
            }
            catch (Exception ex) when (ex is IOException or UnauthorizedAccessException or InvalidOperationException)
            {
                string mensagem = $"Não foi possível ler o arquivo {nomeArquivo}.";
                RegistrarErro(nomeArquivo, mensagem, ex);
                throw new ConteudoException(mensagem);
            }
        }

        private static void RegistrarErro(string nomeArquivo, string mensagem, Exception excecao)
        {
            try
            {
                string diretorio = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                    "ProtetorDigital");
                Directory.CreateDirectory(diretorio);
                string caminhoLog = Path.Combine(diretorio, "log.txt");
                string linha = $"{DateTime.Now:O} | {nomeArquivo} | {mensagem} | {excecao.Message}{Environment.NewLine}";
                File.AppendAllText(caminhoLog, linha, Encoding.UTF8);
            }
            catch
            {
            }
        }
    }
}
