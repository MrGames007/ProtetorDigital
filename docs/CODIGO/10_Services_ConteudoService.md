# `Services/ConteudoService.cs`

**Nível predominante:** 🟡 intermediário  
**Para que serve:** localiza arquivos na pasta `dados`, lê JSON e converte o conteúdo para um objeto. Também obtém a versão do assembly.  
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
| 16 | `nomeArquivo` | Recebe o nome do arquivo. | Não fixa um único JSON no serviço. | 🟢 |
| 17 | `LocalizarArquivo` | Procura o caminho. | Centraliza a localização. | 🟡 |
| 18–21 | `if` e `return default` | Retorna o valor padrão se não houver arquivo. | Para um tipo de referência, o padrão é nulo. | 🟡 |
| 23 | `File.ReadAllText` | Lê todo o JSON como texto. | O serializer precisa do texto. | 🟡 |
| 24 | `Deserialize<T>` | Converte texto para o tipo solicitado. | O mesmo método serve para vários modelos. | 🔴 |
| 25–27 | fechamento e próximo método | Encerram e começam `LocalizarArquivo`. | Organização dos métodos. | 🟢 |
| 29 | `Path.Combine` | Monta o caminho da saída. | Evita concatenar barras manualmente. | 🟡 |
| 30–33 | teste e retorno | Usa o arquivo copiado para a pasta de execução. | É o caminho normal depois do build. | 🟢 |
| 35–37 | caminho alternativo | Sobe três pastas e procura `dados` do projeto. | Permite funcionar durante o desenvolvimento. | 🟡 |
| 40 | `ObterVersaoAssembly` | Declara método que devolve versão. | Créditos usa o valor automático. | 🟡 |
| 42 | `GetEntryAssembly() ?? ...` | Tenta o assembly de entrada e usa o do serviço como alternativa. | Evita resultado nulo. | 🔴 |
| 43 | `GetName().Version?.ToString() ?? "1.0.0.0"` | Converte versão para texto ou usa fallback. | Sempre devolve uma string. | 🔴 |
| 44–45 | chaves finais | Fecham métodos e classe. | Encerram o arquivo. | 🟢 |

## Pontos de atenção

As telas de Dicas, Golpes, Relatos e Quiz ainda leem JSON diretamente. O serviço compartilhado atual é usado pela tela de Créditos. Se o arquivo não existe, `CarregarObjeto` devolve nulo; se o JSON existe mas é inválido, a exceção do serializer não é escondida pelo serviço.

## Se der erro aqui

Arquivo ausente resulta em nulo. JSON inválido pode gerar exceção na chamada. Caminho errado faz a tela não encontrar o conteúdo.

## O que posso mudar com segurança?

É seguro acrescentar uma opção de serializer ou outro fallback de caminho, desde que os formatos atuais continuem aceitos. Não remova `AllowTrailingCommas` nem `ReadCommentHandling` se os comentários do JSON forem mantidos.

## Mini-resumo

1. O serviço é estático.
2. Procura primeiro na saída.
3. Tem fallback para a pasta do projeto.
4. Desserializa qualquer tipo `T`.
5. Também obtém a versão do assembly.
