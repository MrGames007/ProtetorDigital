using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ProtetorDigital
{
    public class Dica
    {
        // Modelo desserializado de uma dica educativa carregada de dados/dicas.json.
        public int Id { get; set; }

        public string? Titulo { get; set; }

        public string? Descricao { get; set; }

        // Mantém o nome do campo do JSON separado do nome idiomático usado no C#.
        [JsonPropertyName("passos_recomendados")]
        public List<string>? PassosRecomendados { get; set; }
    }
}
