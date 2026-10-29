# `Models/CreditosInfo.cs`

**Nível predominante:** 🟢 básico  
**Para que serve:** define os três moldes usados para transformar `creditos.json` em objetos.  
**Depende de:** `List<T>` e nullable habilitado.  
**É usado por:** `Forms/FrmCreditos.cs` e `Services/ConteudoService.cs` indiretamente.

## Antes de ler

Leia [01_CONCEITOS.md](01_CONCEITOS.md) sobre classe, propriedade, `string?`, `List<T>` e generic.

## Explicação linha a linha

| Linha | Código | O que faz | Por quê | Nível |
|---:|---|---|---|---|
| 1 | `namespace ProtetorDigital.Models;` | Define o namespace dos modelos de créditos. | Separa modelos de outras partes. | 🟢 |
| 2 | em branco | Não executa. | Melhora a leitura. | 🟢 |
| 3 | `public sealed class CreditosInfo` | Cria o molde principal e impede herança. | Representa o objeto raiz do JSON. | 🟡 |
| 4 | `{` | Abre a classe. | Delimita suas propriedades. | 🟢 |
| 5 | `Titulo` | Guarda o título, podendo ser nulo. | Recebe o campo `titulo`. | 🟢 |
| 6 | `Subtitulo` | Guarda o subtítulo, podendo ser nulo. | Recebe `subtitulo`. | 🟢 |
| 7 | `Linhas` | Guarda uma lista de `LinhaCredito`. | Representa várias linhas do cartão principal. `new()` começa com lista vazia. | 🟡 |
| 8 | `Cartoes` | Guarda uma lista de `CartaoCredito`. | Representa os cartões laterais. | 🟡 |
| 9 | `}` | Fecha a classe. | Encerra o molde. | 🟢 |
| 10 | em branco | Não executa. | Separa classes. | 🟢 |
| 11 | `public sealed class LinhaCredito` | Cria o molde de uma linha. | Cada item tem rótulo e valor. | 🟢 |
| 12 | `{` | Abre a classe. | Delimita propriedades. | 🟢 |
| 13 | `Rotulo` | Guarda o texto à esquerda. | Recebe `rotulo`. | 🟢 |
| 14 | `Valor` | Guarda o texto à direita. | Recebe `valor`. | 🟢 |
| 15–16 | `}` | Fecham propriedade e classe. | Encerram blocos. | 🟢 |
| 17 | `public sealed class CartaoCredito` | Cria o molde de um cartão. | Representa cada cartão visual. | 🟢 |
| 18 | `{` | Abre a classe. | Delimita propriedades. | 🟢 |
| 19 | `Titulo` | Guarda o nome do cartão. | Recebe `titulo`. | 🟢 |
| 20 | `Logo` | Guarda o nome do arquivo de imagem. | Permite procurar a logo na pasta `imagens`. | 🟢 |
| 21 | `Texto` | Guarda a mensagem do cartão. | Recebe `texto`. | 🟢 |
| 22 | `}` | Fecha a classe. | Encerra o molde. | 🟢 |

## Pontos de atenção

O modelo não valida se uma lista tem dois itens nem se a imagem existe. Essas decisões ficam na tela de Créditos.

## Se der erro aqui

Um nome de propriedade incorreto pode impedir o preenchimento do objeto ou deixar a tela vazia. A desserialização pode continuar sem preencher textos nulos.

## O que posso mudar com segurança?

É seguro adicionar propriedades que correspondam a novos campos do JSON, desde que a tela também saiba usá-las. Alterar nomes exige atualizar o JSON ou usar um mapeamento.

## Mini-resumo

1. `CreditosInfo` é o objeto raiz.
2. `Linhas` contém dados rotulados.
3. `Cartoes` contém cartões visuais.
4. `?` indica texto opcional.
5. `sealed` impede herança dessas classes.
