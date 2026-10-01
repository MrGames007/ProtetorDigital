using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ProtetorDigital
{
    public class Pergunta
    {
        public int Id { get; set; }

        [JsonPropertyName("pergunta")]
        public string? Texto { get; set; }

        public List<string>? Opcoes { get; set; }

        public int RespostaCorreta { get; set; }

        public string? Explicacao { get; set; }
    }
}
