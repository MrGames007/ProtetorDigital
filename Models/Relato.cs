using System.Text.Json.Serialization;

namespace ProtetorDigital
{
    public class Relato
    {
        public int Id { get; set; }

        public string? Titulo { get; set; }

        public string? Fonte { get; set; }

        public string? Vitima { get; set; }

        [JsonPropertyName("relato")]
        public string? Conteudo { get; set; }

        [JsonPropertyName("licoes_aprendidas")]
        public string? LicoesAprendidas { get; set; }
    }
}
