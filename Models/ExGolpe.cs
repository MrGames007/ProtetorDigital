using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ProtetorDigital
{
    public class ExGolpe
    {
        public int Id { get; set; }

        [JsonPropertyName("nome_golpe")]
        public string? NomeGolpe { get; set; }

        [JsonPropertyName("como_funciona")]
        public string? ComoFunciona { get; set; }

        [JsonPropertyName("sinais_de_alerta")]
        public List<string>? SinaisDeAlerta { get; set; }
    }
}
