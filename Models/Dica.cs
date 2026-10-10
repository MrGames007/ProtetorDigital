using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ProtetorDigital
{
    public class Dica
    {
        public int Id { get; set; }

        public string? Titulo { get; set; }

        public string? Descricao { get; set; }

        [JsonPropertyName("passos_recomendados")]
        public List<string>? PassosRecomendados { get; set; }
    }
}
