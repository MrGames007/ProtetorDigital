# `Program.cs`

**Nível predominante:** 🟢 básico  
**Para que serve:** é o ponto de entrada do aplicativo. Ele prepara o Windows Forms e abre o `FrmMenu`.  
**Depende de:** Windows Forms e `FrmMenu`.  
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
| 11–12 | comentário | Aponta uma orientação do Visual Studio. | É apenas informação para o programador. | 🟢 |
| 13 | `ApplicationConfiguration.Initialize();` | Inicializa configurações padrão da aplicação. | Prepara o ambiente visual antes de abrir janelas. | 🟡 |
| 14 | `Application.Run(new FrmMenu());` | Cria o menu e inicia o ciclo de mensagens da aplicação. | Mantém a janela principal aberta e recebe cliques. | 🟡 |
| 15 | linha em branco | Não executa nada. | Separa visualmente as instruções. | 🟢 |
| 16–18 | `}` | Fecham método, classe e namespace. | Encerram os blocos abertos. | 🟢 |

## Pontos de atenção

- A aplicação começa no `FrmMenu`; não começa diretamente no Quiz.
- `Application.Run` mantém a aplicação funcionando enquanto a janela principal estiver viva.
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
5. `Application.Run` mantém o aplicativo ativo.
