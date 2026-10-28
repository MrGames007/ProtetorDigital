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
            catch (ConteudoException)
            {
                throw;
            }
            catch (Exception ex) when (ex is IOException or UnauthorizedAccessException or JsonException or InvalidOperationException)
            {
                throw new ConteudoException($"Não foi possível ler o arquivo {nomeArquivo}.");
            }
        }
    }
}
