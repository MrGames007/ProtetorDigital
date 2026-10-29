# `Models/ExGolpe.cs`

**Nível predominante:** 🟢 básico  
**Para que serve:** representa um exemplo de golpe digital.  
**Depende de:** listas, propriedades e nomes JSON personalizados.  
**É usado por:** `Forms/FrmExGolpes.cs`.

## Antes de ler

Leia [01_CONCEITOS.md](01_CONCEITOS.md) sobre classes, propriedades, listas e JSON.

## Explicação linha a linha

| Linha | Código | O que faz | Por quê | Nível |
|---:|---|---|---|---|
| 1 | `using System.Collections.Generic;` | Importa `List<T>`. | Permite a lista de alertas. | 🟢 |
| 2 | `using System.Text.Json.Serialization;` | Importa o atributo de JSON. | Permite mapear nomes com sublinhado. | 🟡 |
| 3 | em branco | Não executa. | Organização. | 🟢 |
| 4 | `namespace ProtetorDigital` | Define o agrupamento. | É o namespace usado pelas telas atuais. | 🟢 |
| 5–7 | classe `ExGolpe` | Declara o molde público. | Cada item do JSON vira um objeto. | 🟢 |
| 8 | `int Id` | Guarda o identificador. | Diferencia exemplos. | 🟢 |
| 9 | em branco | Não executa. | Organização. | 🟢 |
| 10–11 | atributo e `NomeGolpe` | Ligam `nome_golpe` ao nome C#. | Mantêm o modelo legível. | 🟡 |
| 12 | em branco | Não executa. | Organização. | 🟢 |
| 13–14 | atributo e `ComoFunciona` | Ligam `como_funciona` ao texto C#. | Recebem a explicação do golpe. | 🟡 |
| 15 | em branco | Não executa. | Organização. | 🟢 |
| 16–17 | atributo e `SinaisDeAlerta` | Ligam a lista `sinais_de_alerta`. | Guardam os sinais para a tela. | 🟡 |
| 18–19 | chaves finais | Fecham os blocos. | Encerram classe e namespace. | 🟢 |

## Pontos de atenção

Os nomes do JSON usam `snake_case`; os nomes C# usam PascalCase. Os três atributos fazem a tradução.

## Se der erro aqui

Um nome JSON errado deixa aquele campo vazio. Um tipo incompatível, como texto onde a aplicação espera lista, pode causar erro de leitura.

## O que posso mudar com segurança?

É seguro adicionar propriedades opcionais. Para mudar um nome, mantenha o atributo coerente com o JSON.

## Mini-resumo

1. O modelo descreve um golpe.
2. Há um identificador.
3. Há nome e funcionamento.
4. Há uma lista de alertas.
5. Atributos fazem o mapeamento JSON.
