# `Forms/FrmDicas.cs`

**Nível predominante:** 🟡 intermediário  
**Para que serve:** lê dicas, mostra uma por vez e navega entre elas.  
**Depende de:** `Dica`, `dicas.json`, `JsonDocument`, controles do Designer, `Responsivo` e `LarguraTexto`.
**É usado por:** `FrmBiblioteca`.

## Antes de ler

Leia [01_CONCEITOS.md](01_CONCEITOS.md) sobre listas, JSON, `try/catch`, `Any`, `foreach` e eventos.

## Explicação linha a linha

| Linha | Código | O que faz | Por quê | Nível |
|---:|---|---|---|---|
| 1–11 | imports | Importam arquivos, JSON, LINQ e Windows Forms; `System.Collections.Generic` aparece duas vezes. | Fornecem os tipos usados. | 🟢 |
| 13–18 | classe e campos | Declaram lista de dicas e índice atual. | Guardam conteúdo e posição. | 🟡 |
| 20–34 | construtor | Monta controles, liga eventos, configura pintura dos botões e registra responsividade com limites de fonte e ajuste de largura. | Prepara a tela sem corte de texto. | 🟡 |
| 34–61 | `FrmDicas_Load` | Solicita e desserializa dicas por `ConteudoService`. | Executa ao carregar a janela. | 🟡 |
| 38–43 | carregamento | `ConteudoService` usa `RecursosApp`, priorizando arquivo externo e depois recurso embutido. | Funciona no build e na publicação single-file. | 🟡 |
| 45 | arquivo ausente ou inválido | Recebe `ConteudoException`. | Permite mostrar mensagem amigável e fechar a tela. | 🟢 |
| 47–53 | lista | Recebe a lista já desserializada pelo serviço. | Os formatos de array e `itens` ficam centralizados. | 🟡 |
| 55 | `Any` e primeira dica | Mostra índice 0 se houver itens. | Começa a navegação. | 🟢 |
| 57–60 | `catch (ConteudoException)` | Mostra a falha do conteúdo e fecha a tela. | Evita ocultar a causa do erro. | 🟡 |
| 63–82 | `MostrarDica` | Valida índice, salva posição, preenche Labels, atualiza os botões e recalcula as larguras. | Atualiza a tela para uma dica. | 🟡 |
| 65–69 | validação e campos | Evita índice inválido e usa `?? string.Empty`. | Protege a interface contra nulos. | 🟢 |
| 70–79 | passos | Junta cada passo com hífen ou limpa o Label. | Apresenta lista de forma legível. | 🟡 |
| 82–85 | avançar | Vai ao próximo item se existir. | Evita sair da lista. | 🟢 |
| 87–90 | `BtnAnterior_Click` | Vai ao item anterior quando ele existe. | Mantém a navegação de conteúdo separada do retorno da tela. | 🟢 |
| 92–95 | `BtnVoltar_Click` | Fecha a tela atual. | O formulário é modal e a origem permanece sob ele. | 🟢 |
| 97–112 | `ConfigurarBotaoNavegacao` | Desenha texto branco em botão desabilitado e troca a cor de fundo. | Mantém “Anterior” e “Avançar” legíveis nas pontas da lista. | 🟡 |
| 99–100 | chaves | Fecham classe e namespace. | Encerram arquivo. | 🟢 |

## Pontos de atenção

Há dois `using System.Collections.Generic` iguais nas linhas 2 e 11. O `catch` ignora qualquer erro. A largura dos textos é recalculada pelo `LarguraTexto` no carregamento, na troca de item, no redimensionamento do painel e após a escala responsiva.

## Se der erro aqui

Arquivo ausente ou JSON inválido deixa a lista vazia sem mensagem. Índice inválido não altera a tela. Uma lista sem passos limpa o texto dos passos.

## O que posso mudar com segurança?

É seguro editar o JSON respeitando `itens`, trocar textos de apresentação e alterar os limites de navegação. Para diagnosticar erros, seria preciso substituir o `catch` vazio, mas isso muda o comportamento.

## Mini-resumo

1. A tela mantém uma lista de dicas.
2. O carregamento ocorre no evento Load.
3. A raiz JSON precisa de `itens`.
4. Um índice controla a dica exibida.
5. `BtnAnterior` e `BtnAvancar` navegam; `BtnVoltar` fecha a tela.
