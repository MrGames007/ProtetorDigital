# `Models/Relato.cs`

**Nível predominante:** 🟢 básico  
**Para que serve:** representa um relato de caso carregado do JSON.  
**Depende de:** propriedades e `JsonPropertyName`.  
**É usado por:** `Forms/FrmRelatos.cs`.

## Antes de ler

Leia [01_CONCEITOS.md](01_CONCEITOS.md) sobre classes, propriedades, textos opcionais e JSON.

## Explicação linha a linha

| Linha | Código | O que faz | Por quê | Nível |
|---:|---|---|---|---|
| 1 | `using System.Text.Json.Serialization;` | Importa atributos JSON. | Necessário para nomes diferentes. | 🟡 |
| 2 | em branco | Não executa. | Organização. | 🟢 |
| 3 | namespace | Agrupa o modelo. | Mantém o namespace usado pela tela. | 🟢 |
| 4–6 | classe `Relato` | Declara o molde de um relato. | Cada item vira um objeto. | 🟢 |
| 7 | `Id` | Guarda identificador. | Diferencia registros. | 🟢 |
| 8 | em branco | Não executa. | Organização. | 🟢 |
| 9 | `Titulo` | Guarda o título. | Vai para o rótulo da tela. | 🟢 |
| 10 | em branco | Não executa. | Organização. | 🟢 |
| 11 | `Fonte` | Guarda a fonte do relato. | Exibe origem do conteúdo. | 🟢 |
| 12 | em branco | Não executa. | Organização. | 🟢 |
| 13 | `Vitima` | Guarda a identificação da vítima. | É mostrada na tela. | 🟢 |
| 14 | em branco | Não executa. | Organização. | 🟢 |
| 15–16 | atributo e `Conteudo` | Mapeiam `relato` para `Conteudo`. | O nome C# fica mais explicativo. | 🟡 |
| 17 | em branco | Não executa. | Organização. | 🟢 |
| 18–19 | atributo e `LicoesAprendidas` | Mapeiam `licoes_aprendidas`. | Mantêm o texto da lição no modelo. | 🟡 |
| 20–21 | chaves finais | Fecham classe e namespace. | Encerram os blocos. | 🟢 |

## Pontos de atenção

Os nomes `relato` e `licoes_aprendidas` precisam continuar coerentes com os atributos se o JSON for editado.

## Se der erro aqui

Campos mal escritos podem aparecer vazios. Um JSON com tipos errados pode falhar durante a leitura da lista.

## O que posso mudar com segurança?

Novos campos opcionais podem ser adicionados. Para renomear propriedades, atualize também a tela que as lê.

## Mini-resumo

1. `Relato` modela um caso.
2. Guarda título, fonte e vítima.
3. Guarda conteúdo principal.
4. Guarda lições aprendidas.
5. Dois atributos traduzem nomes do JSON.
