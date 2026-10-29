# `Models/Dica.cs`

**Nível predominante:** 🟢 básico  
**Para que serve:** representa uma dica educativa lida de `dados/dicas.json`.  
**Depende de:** `List<string>` e `JsonPropertyName`.  
**É usado por:** `Forms/FrmDicas.cs`.

## Antes de ler

Leia [01_CONCEITOS.md](01_CONCEITOS.md) sobre `using`, classe, propriedades, `List<T>` e JSON.

## Explicação linha a linha

| Linha | Código | O que faz | Por quê | Nível |
|---:|---|---|---|---|
| 1 | `using System.Collections.Generic;` | Importa listas genéricas. | Permite escrever `List<string>`. | 🟢 |
| 2 | `using System.Text.Json.Serialization;` | Importa atributos de JSON. | Permite usar `JsonPropertyName`. | 🟡 |
| 3 | em branco | Não executa. | Separa imports do namespace. | 🟢 |
| 4 | `namespace ProtetorDigital` | Coloca o modelo no namespace principal. | Mantém compatibilidade com as telas existentes. | 🟢 |
| 5–7 | classe `Dica` e chaves | Declaram o molde público. | A tela precisa criar e ler objetos `Dica`. | 🟢 |
| 8 | `int Id` | Guarda identificador inteiro. | Diferencia registros. | 🟢 |
| 9 | em branco | Não executa. | Organização. | 🟢 |
| 10 | `string? Titulo` | Guarda o título opcional. | Evita assumir que o JSON sempre tem texto. | 🟢 |
| 11 | em branco | Não executa. | Organização. | 🟢 |
| 12 | `string? Descricao` | Guarda a explicação da dica. | É exibida na tela. | 🟢 |
| 13 | em branco | Não executa. | Organização. | 🟢 |
| 14 | `[JsonPropertyName("passos_recomendados")]` | Mapeia o nome do JSON para o nome C#. | O JSON usa sublinhados; C# usa nome PascalCase. | 🟡 |
| 15 | `List<string>? PassosRecomendados` | Guarda os passos como textos opcionais. | A tela transforma cada passo em uma linha. | 🟡 |
| 16–17 | chaves finais | Fecham propriedade, classe e namespace. | Encerram os blocos. | 🟢 |

## Pontos de atenção

A propriedade `PassosRecomendados` é diferente do nome no JSON; o atributo da linha 14 é necessário para fazer a ligação.

## Se der erro aqui

Se o mapeamento for removido, os passos podem não aparecer. Se o tipo mudar, a desserialização pode falhar.

## O que posso mudar com segurança?

É seguro adicionar um novo campo opcional e usá-lo depois na tela. Não altere `passos_recomendados` sem atualizar o atributo e o JSON.

## Mini-resumo

1. `Dica` descreve uma dica.
2. `Id` é um número identificador.
3. Textos podem ser nulos.
4. A lista guarda passos.
5. O atributo liga nomes diferentes.
