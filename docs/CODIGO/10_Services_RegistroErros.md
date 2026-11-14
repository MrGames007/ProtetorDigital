# `Services/RegistroErros.cs`

**Nível predominante:** 🟡 intermediário  
**Para que serve:** grava relatórios objetivos de exceções ocorridas durante a execução.  
**É usado por:** `Program.cs`.

## Formato do arquivo

Os relatórios são criados em:

```text
Erros/yyyy-MM-dd_HH-mm-ss-fff_ProtetorDigital.txt
```

O nome contém a data e o horário da ocorrência junto do nome do projeto. O conteúdo registra:

- projeto;
- data e hora com milissegundos e fuso horário;
- origem da exceção;
- tipo da exceção;
- mensagem;
- stack trace.

## Comportamento

`Registrar` cria a pasta `Erros` quando necessário, grava um arquivo UTF-8 e retorna o caminho criado. Se o próprio registro falhar, o método retorna `null` para não provocar uma segunda exceção durante o tratamento da primeira.

O `Program` usa o serviço para os seguintes cenários:

- exceção na thread da interface Windows Forms;
- exceção não tratada do `AppDomain`;
- exceção de tarefa não observada;
- erro na inicialização ou no ciclo principal da aplicação.

## Pontos de atenção

A pasta é relativa ao diretório base da aplicação. Em uma instalação sem permissão de escrita nesse diretório, o relatório não poderá ser criado e o usuário será informado sobre a falha.

## Mini-resumo

1. Recebe uma exceção e sua origem.
2. Cria `Erros` se necessário.
3. Usa data, hora e projeto no nome.
4. Grava mensagem e stack trace.
5. Retorna o caminho ou `null` se não puder salvar.