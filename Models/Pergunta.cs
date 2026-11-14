using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ProtetorDigital
{
    public class Pergunta
    {
        // Representa uma questão do quiz, suas alternativas e o material de correção.
        public int Id { get; set; }

        // O JSON usa "pergunta", enquanto a interface trabalha com o nome Texto.
        [JsonPropertyName("pergunta")]
        public string? Texto { get; set; }

        public List<string>? Opcoes { get; set; }

        public int RespostaCorreta { get; set; }

        public string? Explicacao { get; set; }

        // Explicações individuais acompanham as alternativas incorretas do quiz.
        [JsonPropertyName("explicacaoOpcoesErradas")]
        public List<string>? ExplicacaoOpcoes { get; set; }
    }
}
