# `Program.cs`

**Nível predominante:** 🟢 básico  
**Para que serve:** é o ponto de entrada do aplicativo. Ele configura o tratamento global de exceções, prepara o Windows Forms e abre o `FrmMenu`.
**Depende de:** Windows Forms, `FrmMenu` e `RegistroErros`.
**É usado por:** o sistema operacional, quando inicia o programa.

## Antes de ler

Veja [01_CONCEITOS.md](01_CONCEITOS.md): programa, classe, método, namespace, objeto e construtor.

## Explicação linha a linha

| Linha | Código | O que faz | Por quê | Nível |
|---:|---|---|---|---|
| 1 | `namespace ProtetorDigital` | Define o agrupamento do código. | Mantém o ponto de entrada no namespace principal. | 🟢 |
| 2 | `{` | Abre o bloco do namespace. | Delimita o conteúdo. | 🟢 |
| 3 | `internal static class Program` | Declara a classe `Program`. | `internal` limita o acesso ao projeto; `static` indica que não é preciso criar um objeto. | 🟡 |
| 4 | `{` | Abre a classe. | Delimita seus membros. | 🟢 |
| 5–7 | comentário XML | Descreve o ponto de entrada. | Ajuda ferramentas e leitores. | 🟢 |
| 8 | `[STAThread]` | Marca o método para o modelo de thread usado pela interface Windows. | Windows Forms precisa dessa configuração para trabalhar com seus controles. | 🟡 |
| 9 | `static void Main()` | Declara o método inicial. | O sistema começa a execução aqui; `void` significa que não retorna valor. | 🟢 |
| 10 | `{` | Abre `Main`. | Delimita as instruções iniciais. | 🟢 |
| 11–13 | registro dos handlers | Configura captura de exceções da interface, do AppDomain e de tarefas. | Garante que falhas de execução sejam registradas. | 🟡 |
| 15–22 | `try/catch` | Inicializa o Windows Forms e abre o menu; registra falhas de inicialização ou execução. | Cobre erros que ocorram fora dos eventos específicos. | 🟡 |
| 24–47 | handlers de exceção | Gravam relatório em `Erros/` e, para falhas da UI, exibem o caminho ao usuário. | Torna o erro objetivo e rastreável. | 🟡 |
| 49–57 | `ExibirErro` | Mostra mensagem com o caminho do arquivo ou informa falha ao salvar. | Orienta o usuário sem expor apenas uma mensagem genérica. | 🟢 |

## Pontos de atenção

- A aplicação começa no `FrmMenu`; não começa diretamente no Quiz.
- `Application.Run` mantém a aplicação funcionando enquanto a janela principal estiver viva.
- Exceções da UI são tratadas por `Application.ThreadException`; exceções fora dela usam `AppDomain.CurrentDomain.UnhandledException`.
- Falhas de tarefas não observadas são registradas e marcadas como observadas.
- O arquivo não lê JSON e não calcula regras de negócio.

## Se der erro aqui

Se `FrmMenu` não existir ou não compilar, o aplicativo não inicia. Se a inicialização do Windows Forms falhar, nenhuma tela será aberta.

## O que posso mudar com segurança?

É seguro trocar a classe inicial passada para `Application.Run` por outra janela existente, desde que o fluxo desejado seja conhecido. Não remova `[STAThread]` nem a inicialização sem compreender o efeito na interface.

## Mini-resumo

1. `Program` é a classe inicial.
2. `Main` é o método chamado pelo sistema.
3. A configuração visual vem antes da janela.
4. `new FrmMenu()` cria o menu.
5. Os handlers globais registram erros na pasta `Erros`.
