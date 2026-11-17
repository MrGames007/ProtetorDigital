# `Services/ConteudoService.cs`

**Nível predominante:** 🟡 intermediário  
**Para que serve:** lê JSON por `RecursosApp`, priorizando arquivos externos e usando recursos embutidos como fallback, e converte o conteúdo para objetos ou listas. Também obtém a versão do assembly.  
**Depende de:** `System.Reflection`, `System.Text.Json`, `File`, `Path` e `Assembly`.  
**É usado por:** `Forms/FrmCreditos.cs`.

## Antes de ler

Leia [01_CONCEITOS.md](01_CONCEITOS.md) sobre classes estáticas, generics, JSON, `File`, `Path`, `if`, `??` e assembly.

## Explicação linha a linha

| Linha | Código | O que faz | Por quê | Nível |
|---:|---|---|---|---|
| 1 | `using System.Reflection;` | Importa recursos de reflexão. | Permite consultar a versão do assembly. | 🔴 |
| 2 | `using System.Text.Json;` | Importa o leitor JSON. | Fornece serializer e opções. | 🟡 |
| 3 | em branco | Não executa. | Organização. | 🟢 |
| 4 | namespace | Agrupa o serviço. | Separa serviços dos Forms. | 🟢 |
| 5 | em branco | Não executa. | Organização. | 🟢 |
| 6 | `public static class ConteudoService` | Cria uma caixa de ferramentas sem instância. | Seus métodos são chamados diretamente. | 🟡 |
| 7 | `{` | Abre a classe. | Delimita membros. | 🟢 |
| 8–13 | `JsonSerializerOptions Opcoes` | Configura leitura sem diferenciar maiúsculas, ignorando comentários e aceitando vírgula final. | Permite editar o JSON com mais flexibilidade. | 🟡 |
| 14–15 | chaves e método | Começam `CarregarObjeto<T>`. | O método é genérico. | 🔴 |
| 16–23 | `CarregarObjeto<T>` | Lê o texto por `RecursosApp` e lança `ConteudoException` se não encontrar o arquivo. | Mantém uma falha amigável e centralizada. | 🟡 |
| 25–31 | desserialização e tratamento | Converte o texto e preserva mensagens de JSON inválido com linha. | Diagnostica conteúdo sem expor erro técnico à tela. | 🔴 |
| 34–51 | `CarregarLista<T>` | Aceita array direto ou raiz com `itens`, validando lista e erros. | Atende os formatos usados pelas telas. | 🔴 |
| 40 | `ObterVersaoAssembly` | Declara método que devolve versão. | Créditos usa o valor automático. | 🟡 |
| 42 | `GetEntryAssembly() ?? ...` | Tenta o assembly de entrada e usa o do serviço como alternativa. | Evita resultado nulo. | 🔴 |
| 43 | `GetName().Version?.ToString() ?? "1.0.0.0"` | Converte versão para texto ou usa fallback. | Sempre devolve uma string. | 🔴 |
| 44–45 | chaves finais | Fecham métodos e classe. | Encerram o arquivo. | 🟢 |

## Pontos de atenção

As telas de Dicas, Golpes, Relatos, Quiz e Créditos usam o serviço compartilhado. `RecursosApp` procura primeiro arquivos externos na pasta do processo e na base da aplicação e depois recursos embutidos. JSON inválido ou ausente gera `ConteudoException`, registrada no log de `%AppData%\ProtetorDigital\log.txt`.

## Se der erro aqui

Arquivo ausente ou JSON inválido gera `ConteudoException`; as telas exibem mensagem amigável e encerram o carregamento do conteúdo.

## O que posso mudar com segurança?

É seguro acrescentar uma opção de serializer ou outro fallback de caminho, desde que os formatos atuais continuem aceitos. Não remova `AllowTrailingCommas` nem `ReadCommentHandling` se os comentários do JSON forem mantidos.

## Mini-resumo

1. O serviço é estático.
2. Procura primeiro na saída.
3. Tem fallback para a pasta do projeto.
4. Desserializa qualquer tipo `T`.
5. Também obtém a versão do assembly.
