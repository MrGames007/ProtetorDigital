using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ProtetorDigital
{
    public class ExGolpe
    {
        // Modelo dos exemplos de golpes mostrados pela biblioteca educativa.
        public int Id { get; set; }

        // Os atributos abaixo traduzem os nomes snake_case do JSON para propriedades C#.
        [JsonPropertyName("nome_golpe")]
        public string? NomeGolpe { get; set; }

        [JsonPropertyName("como_funciona")]
        public string? ComoFunciona { get; set; }

        [JsonPropertyName("sinais_de_alerta")]
        public List<string>? SinaisDeAlerta { get; set; }
    }
}
