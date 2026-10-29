# `Forms/FrmMenu.cs`

**Nível predominante:** 🟡 intermediário  
**Para que serve:** monta o menu principal, cria o botão de Créditos e abre as outras janelas.  
**Depende de:** `FrmQuiz`, `FrmBiblioteca`, `FrmCreditos`, Windows Forms e `Responsivo`.  
**É usado por:** `Program.cs`; outras telas recebem este Form como origem.

## Antes de ler

Leia [01_CONCEITOS.md](01_CONCEITOS.md): Form, construtor, evento, `Show`, `ShowDialog`, `Hide`, `TableLayoutPanel` e lambda.

## Explicação linha a linha

| Linha | Código | O que faz | Por quê | Nível |
|---:|---|---|---|---|
| 1 | `using ProtetorDigital.Forms;` | Importa as telas do namespace Forms. | Permite criar Quiz, Biblioteca e Créditos. | 🟢 |
| 3–5 | namespace, classe parcial e `Form` | Declara a janela principal. | `partial` divide a classe com o Designer. | 🟡 |
| 7–9 | construtor e `InitializeComponent` | Monta primeiro os controles do Designer. | A montagem visual precisa existir antes da reorganização. | 🟡 |
| 10–12 | tamanho mínimo, maximização e posição | Define comportamento da janela. | Mantém uma área mínima e centraliza. | 🟢 |
| 14–24 | criação de `btnCreditos` | Cria o botão em código e define aparência. | Créditos não está no Designer original. | 🟡 |
| 25 | borda do botão | Remove a borda padrão. | Mantém o visual plano. | 🟢 |
| 26–30 | evento `Click` | Cria Créditos dentro de `using` e abre modal. | O botão mostra a janela e libera o objeto ao fechar. | 🟡 |
| 32 | `Controls.Clear()` | Remove controles originalmente adicionados à janela. | Permite usar a nova grade. | 🟡 |
| 33–39 | criação do `TableLayoutPanel` | Cria uma grade com uma coluna e cinco linhas. | Organiza o menu sem coordenadas fixas. | 🟡 |
| 40–41 | estilos de linha e `for` | Distribui espaço entre título e botões. | As linhas crescem proporcionalmente. | 🟡 |
| 42–45 | `Dock` e `Margin` dos controles | Faz controles ocuparem as células. | Mantém botões alinhados e semelhantes. | 🟡 |
| 46–50 | `Controls.Add` | Coloca título e botões na grade. | Define a ordem visual. | 🟢 |
| 51–52 | adiciona layout e registra | Exibe a grade e ativa responsividade. | Fontes acompanham o tamanho. | 🔴 |
| 53 | fecha construtor | Finaliza montagem. | Encera preparação. | 🟢 |
| 55–60 | `BtnQuiz_Click` | Cria Quiz, mostra e esconde menu. | Mantém referência de origem. | 🟡 |
| 61–64 | `BtnSair_Click` | Encerra a aplicação. | Sair deve fechar o ciclo principal. | 🟢 |
| 66–71 | `BtnBiblioteca_Click` | Cria Biblioteca, mostra e esconde menu. | Segue o mesmo padrão do Quiz. | 🟡 |
| 73–74 | chaves | Fecham classe e namespace. | Encerram arquivo. | 🟢 |

## Pontos de atenção

Os nomes `segundaJanela` e `quartaJanela` não indicam exatamente todas as telas; são apenas variáveis locais. Quiz e Biblioteca usam `Show`, enquanto Créditos usa `ShowDialog`.

## Se der erro aqui

Erros em controles ou Forms impedem o menu de abrir. Se um evento for removido, o botão pode não fazer nada.

## O que posso mudar com segurança?

É seguro trocar cores, margens e proporções do layout. Para adicionar um botão, crie-o, ligue um evento, coloque-o em uma linha e registre-o se necessário.

## Mini-resumo

1. O construtor monta o menu.
2. Créditos é criado em código.
3. A grade organiza cinco linhas.
4. Quiz e Biblioteca são não modais.
5. Sair encerra a aplicação.
