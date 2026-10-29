# `Forms/FrmRelatos.cs`

**Nível predominante:** 🟡 intermediário  
**Para que serve:** carrega relatos, exibe seus campos e controla botões anterior/próximo.  
**Depende de:** `Relato`, `relatos.json`, JSON, LINQ e Windows Forms.  
**É usado por:** `FrmBiblioteca`.

## Antes de ler

Leia [01_CONCEITOS.md](01_CONCEITOS.md) sobre campos, JSON, `try/catch`, comparação booleana e eventos.

## Explicação linha a linha

| Linha | Código | O que faz | Por quê | Nível |
|---:|---|---|---|---|
| 1–10 | imports | Importam tipos de texto, arquivo, JSON, LINQ e Forms. | Fornecem as ferramentas do arquivo. | 🟢 |
| 12–17 | namespace, classe e campos | Declaram lista de relatos e índice. | Guardam dados e posição. | 🟡 |
| 19–30 | construtor | Guarda origem, monta tela, liga eventos e responsividade. | Prepara o formulário. | 🟡 |
| 33–60 | `FrmRelatos_Load` | Localiza arquivo, lê `itens` e cria a lista. | Alimenta a tela. | 🟡 |
| 37–43 | caminhos | Tenta saída e fallback. | Funciona em build e desenvolvimento. | 🟡 |
| 44–54 | leitura | Confere arquivo, desserializa e mostra primeiro relato. | Começa o fluxo. | 🟡 |
| 56–59 | `catch` | Ignora erro de leitura. | Evita interromper a interface, mas esconde causa. | 🟡 |
| 62–78 | `MostrarRelato` | Valida índice, pega objeto, preenche cinco Labels e atualiza botões. | Exibe registro atual e limites. | 🟡 |
| 69–73 | atribuições | Colocam título, fonte, vítima, conteúdo e lições na tela. | Cada propriedade tem seu campo visual. | 🟢 |
| 75–77 | `Enabled` | Habilita anterior e próximo conforme o índice. | Evita navegar para fora da lista. | 🟡 |
| 80–83 | avançar | Mostra próximo relato se houver. | Mantém limite superior. | 🟢 |
| 85–89 | voltar | Mostra relato anterior se houver. | Mantém limite inferior. | 🟢 |
| 91–95 | retorno | Mostra origem e fecha. | Volta à Biblioteca. | 🟢 |
| 97–99 | linhas e chaves | Não executam ou encerram blocos. | Organização. | 🟢 |

## Pontos de atenção

O método de retorno é diferente do voltar entre relatos. O botão anterior apenas troca o índice; o botão de retorno mostra a origem. O `catch` é silencioso.

## Se der erro aqui

Sem arquivo ou com JSON inválido, a lista permanece vazia. Se o índice for inválido, nada muda. A origem nula causaria erro ao retornar, mas o construtor normalmente recebe uma janela.

## O que posso mudar com segurança?

É seguro editar os textos e adicionar relatos no formato existente. Para alterar a regra dos botões, revise o cálculo de `Enabled`.

## Mini-resumo

1. Relatos vêm de um objeto JSON com `itens`.
2. A lista fica no campo `_relatos`.
3. Cinco Labels recebem os dados.
4. Botões são habilitados pelo índice.
5. Retorno e navegação anterior são ações diferentes.
