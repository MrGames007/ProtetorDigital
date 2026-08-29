using System.Collections.Generic;
using System.Text.Json.Serialization;

public class Pergunta
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("pergunta")]
    public string Texto { get; set; } = string.Empty;

    [JsonPropertyName("opcoes")]
    public List<string> Opcoes { get; set; } = new();

    [JsonPropertyName("respostaCorreta")]
    public int RespostaCorreta { get; set; }

    [JsonPropertyName("explicacao")]
    public string Explicacao { get; set; } = string.Empty;
}
