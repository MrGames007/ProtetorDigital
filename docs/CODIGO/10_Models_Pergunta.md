# `Models/Pergunta.cs`

**Nível predominante:** 🟢 básico  
**Para que serve:** representa uma pergunta do Quiz.  
**Depende de:** lista de textos e mapeamento JSON.  
**É usado por:** `Forms/FrmQuiz.cs`.

## Antes de ler

Leia [01_CONCEITOS.md](01_CONCEITOS.md) sobre propriedades, listas, inteiro e JSON.

## Explicação linha a linha

| Linha | Código | O que faz | Por quê | Nível |
|---:|---|---|---|---|
| 1 | `using System.Collections.Generic;` | Importa listas. | `Opcoes` é uma lista. | 🟢 |
| 2 | `using System.Text.Json.Serialization;` | Importa atributos JSON. | Permite mapear `pergunta`. | 🟡 |
| 3 | em branco | Não executa. | Organização. | 🟢 |
| 4 | namespace | Agrupa o modelo. | Mantém o nome usado pela tela. | 🟢 |
| 5–7 | classe `Pergunta` | Declara o molde de pergunta. | O JSON vira objeto. | 🟢 |
| 8 | `Id` | Guarda identificador. | Permite identificar a pergunta. | 🟢 |
| 9 | em branco | Não executa. | Organização. | 🟢 |
| 10–11 | atributo e `Texto` | Mapeiam `pergunta` para `Texto`. | A tela usa um nome mais claro. | 🟡 |
| 12 | em branco | Não executa. | Organização. | 🟢 |
| 13 | `List<string>? Opcoes` | Guarda alternativas. | O Quiz mostra cada item em um RadioButton. | 🟡 |
| 14 | em branco | Não executa. | Organização. | 🟢 |
| 15 | `int RespostaCorreta` | Guarda a posição correta original. | O código converte a posição para índice ao exibir. | 🟡 |
| 16 | em branco | Não executa. | Organização. | 🟢 |
| 17 | `string? Explicacao` | Guarda o texto do feedback. | O Quiz mostra a explicação após a resposta. | 🟢 |
| 18–19 | chaves finais | Fecham os blocos. | Encerram a classe. | 🟢 |

## Pontos de atenção

`RespostaCorreta` vem em base 1 no conteúdo, enquanto índices de lista começam em 0. A conversão ocorre no Quiz, não neste modelo.

## Se der erro aqui

Se `Opcoes` não for uma lista, o Quiz não conseguirá preparar as alternativas. Se `RespostaCorreta` estiver fora da faixa, a marcação pode ficar incorreta.

## O que posso mudar com segurança?

É seguro adicionar uma propriedade opcional para um novo campo do JSON. O Quiz atual não usa campos adicionais automaticamente.

## Mini-resumo

1. `Pergunta` é o molde de uma questão.
2. `Opcoes` contém alternativas.
3. `RespostaCorreta` guarda a posição original.
4. `Explicacao` aparece no feedback.
5. O Quiz faz a lógica de embaralhamento.
