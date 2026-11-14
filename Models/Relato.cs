using System.Text.Json.Serialization;

namespace ProtetorDigital
{
    public class Relato
    {
        // Modelo de um caso educativo/noticiado exibido na tela de Relatos.
        public int Id { get; set; }

        public string? Titulo { get; set; }

        public string? Fonte { get; set; }

        public string? Vitima { get; set; }

        // Faz a ponte entre os nomes dos campos do JSON e os nomes usados na UI.
        [JsonPropertyName("relato")]
        public string? Conteudo { get; set; }

        [JsonPropertyName("licoes_aprendidas")]
        public string? LicoesAprendidas { get; set; }

        public string? Cidade { get; set; }
        public string? Url { get; set; }
        public string? Data { get; set; }
        public string? Tipo { get; set; }
        public bool Verificado { get; set; }
    }
}
