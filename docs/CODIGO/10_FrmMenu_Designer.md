# `Forms/FrmMenu.Designer.cs`

**Nível predominante:** 🟡 intermediário  
**Para que serve:** declara os campos e a montagem visual inicial do menu.  
**Depende de:** Windows Forms.  
**É usado por:** `FrmMenu.cs` por meio de `InitializeComponent`.

## Antes de ler

Leia [01_CONCEITOS.md](01_CONCEITOS.md) sobre `partial`, Designer, controles, propriedades, eventos e `Dock`/`Anchor`.

## Explicação por blocos de linhas

- **1–15:** namespace, classe parcial, componente e `Dispose`. `Dispose` libera componentes quando a janela é descartada.
- **16–23:** região gerada e início de `InitializeComponent`; cria `label1`, `BtnQuiz`, `BtnBiblioteca` e `BtnSair`, depois suspende o layout.
- **25–37:** configura o título: Anchor horizontal, fonte 28 em negrito, cor, posição, tamanho e centralização.
- **38–55:** configura `BtnQuiz`: cor, cursor, borda plana, fonte, posição, tamanho, texto e evento `Click`.
- **56–73:** configura `BtnBiblioteca` com o mesmo padrão, texto próprio e evento correspondente.
- **74–90:** configura `BtnSair`, com cor vermelha, fonte 14, texto e evento.
- **92–105:** define propriedades do Form, tamanho inicial, controles, nome e texto, e retoma layout.
- **108–114:** fecha região e declara os quatro campos privados.

### Controles

| Controle | Tipo | Para que serve | Propriedades que o diferenciam |
|---|---|---|---|
| `label1` | `Label` | Título do menu | Fonte 28, Anchor horizontal, texto centralizado |
| `BtnQuiz` | `Button` | Abre Quiz | Azul, texto `Quiz`, evento Quiz |
| `BtnBiblioteca` | `Button` | Abre Biblioteca | Azul, texto Biblioteca, evento Biblioteca |
| `BtnSair` | `Button` | Encerra | Vermelho, texto Sair, evento Sair |

## Pontos de atenção

Este arquivo é gerado pelo Visual Studio e não deve ser editado manualmente sem necessidade. O `FrmMenu` limpa esses controles e os coloca em outro `TableLayoutPanel` no construtor; portanto algumas posições iniciais são substituídas em tempo de execução.

## Se der erro aqui

Um campo ausente impede o arquivo parcial do Form de compilar. Um evento com nome errado causa erro de compilação.

## O que posso mudar com segurança?

Use o Designer para aparência. Alterações de fluxo devem ficar no `.cs`, não neste arquivo.

## Mini-resumo

1. Declara controles do menu.
2. Cria o método visual automático.
3. Configura propriedades repetitivas.
4. Liga eventos.
5. O código de runtime reorganiza o layout.
