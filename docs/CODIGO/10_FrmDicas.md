# `Forms/FrmDicas.cs`

**Nível predominante:** 🟡 intermediário  
**Para que serve:** lê dicas, mostra uma por vez e navega entre elas.  
**Depende de:** `Dica`, `dicas.json`, `JsonDocument`, controles do Designer e `Responsivo`.  
**É usado por:** `FrmBiblioteca`.

## Antes de ler

Leia [01_CONCEITOS.md](01_CONCEITOS.md) sobre listas, JSON, `try/catch`, `Any`, `foreach` e eventos.

## Explicação linha a linha

| Linha | Código | O que faz | Por quê | Nível |
|---:|---|---|---|---|
| 1–11 | imports | Importam arquivos, JSON, LINQ e Windows Forms; `System.Collections.Generic` aparece duas vezes. | Fornecem os tipos usados. | 🟢 |
| 13–18 | classe e campos | Declaram lista de dicas e índice atual. | Guardam conteúdo e posição. | 🟡 |
| 20–31 | construtor | Guarda origem, monta controles, liga eventos e registra responsividade. | Prepara a tela. | 🟡 |
| 34–61 | `FrmDicas_Load` | Procura, lê e desserializa dicas. | Executa ao carregar a janela. | 🟡 |
| 38–43 | caminhos | Tenta saída e depois pasta de desenvolvimento. | Funciona no build e no ambiente local. | 🟡 |
| 45 | arquivo ausente | Retorna silenciosamente. | Evita continuar sem dados. | 🟢 |
| 47–53 | opções, documento e lista | Lê objeto raiz e pega propriedade `itens`. | Os dados não são um array direto. | 🟡 |
| 55 | `Any` e primeira dica | Mostra índice 0 se houver itens. | Começa a navegação. | 🟢 |
| 57–60 | `catch` vazio com comentário | Ignora erro de leitura. | A UI não é interrompida, mas o erro fica sem diagnóstico. | 🟡 |
| 63–80 | `MostrarDica` | Valida índice, salva posição e preenche Labels. | Atualiza a tela para uma dica. | 🟡 |
| 65–69 | validação e campos | Evita índice inválido e usa `?? string.Empty`. | Protege a interface contra nulos. | 🟢 |
| 70–79 | passos | Junta cada passo com hífen ou limpa o Label. | Apresenta lista de forma legível. | 🟡 |
| 82–85 | avançar | Vai ao próximo item se existir. | Evita sair da lista. | 🟢 |
| 87–91 | voltar | Vai ao anterior ou fecha no primeiro. | Define o limite da navegação. | 🟢 |
| 93–97 | retornar | Mostra a origem e fecha. | Volta diretamente à Biblioteca. | 🟢 |
| 99–100 | chaves | Fecham classe e namespace. | Encerram arquivo. | 🟢 |

## Pontos de atenção

Há dois `using System.Collections.Generic` iguais nas linhas 2 e 11. O `catch` ignora qualquer erro. O método `BtnRetornar_Click` existe no código, embora o documento Designer deva ser consultado para confirmar qual controle está ligado a ele.

## Se der erro aqui

Arquivo ausente ou JSON inválido deixa a lista vazia sem mensagem. Índice inválido não altera a tela. Uma lista sem passos limpa o texto dos passos.

## O que posso mudar com segurança?

É seguro editar o JSON respeitando `itens`, trocar textos de apresentação e alterar os limites de navegação. Para diagnosticar erros, seria preciso substituir o `catch` vazio, mas isso muda o comportamento.

## Mini-resumo

1. A tela mantém uma lista de dicas.
2. O carregamento ocorre no evento Load.
3. A raiz JSON precisa de `itens`.
4. Um índice controla a dica exibida.
5. Botões avançam, voltam ou retornam.
