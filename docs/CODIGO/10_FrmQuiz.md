# `Forms/FrmQuiz.cs`

**Nível predominante:** 🟡 intermediário  
**Para que serve:** carrega perguntas, embaralha alternativas, confere respostas e mostra resultado.  
**Depende de:** `Pergunta`, `perguntas.json`, quatro `RadioButton`, `MessageBox` e janela de origem.  
**É usado por:** `FrmMenu`.

## Antes de ler

Leia [01_CONCEITOS.md](01_CONCEITOS.md) sobre campos, listas, JSON, LINQ, lambda, ternário, eventos e exceções.

## Resumo do método grande: `FrmQuiz_Load`

1. Procura o arquivo na saída e no projeto.
2. Lê o array JSON para `List<Pergunta>`.
3. Mostra a primeira pergunta, ou informa erro.

## Explicação linha a linha

| Linha | Código | O que faz | Por quê | Nível |
|---:|---|---|---|---|
| 1–10 | imports | Importam coleção, arquivo, LINQ, texto, JSON e Forms. | Fornecem todas as ferramentas usadas. | 🟢 |
| 12–14 | namespace e classe | Declaram o Form parcial. | O Designer completa a classe. | 🟡 |
| 16–20 | campos | Guardam perguntas, índice, pontuação, opções exibidas e posição correta. | Mantêm o estado do jogo. | 🟡 |
| 22–31 | origem e construtor | Recebe `FrmMenu`, monta componentes, liga Load e registra responsividade. | Prepara o Quiz. | 🟡 |
| 34–74 | `FrmQuiz_Load` | Executa o carregamento protegido por `try/catch`. | Erros viram aviso visual. | 🟡 |
| 38–49 | carregamento | `ConteudoService` usa `RecursosApp`, priorizando arquivo externo e depois recurso embutido. | Permite rodar no build e na publicação single-file. | 🟡 |
| 51–55 | arquivo ausente ou inválido | `ConteudoException` é capturada e exibida em `MessageBox`. | Não tenta continuar sem conteúdo válido. | 🟢 |
| 57–63 | opções e desserialização | Recebe o array como `List<Pergunta>` pelo serviço. | Perguntas têm array direto na raiz. | 🟡 |
| 65–68 | primeira pergunta | Chama `MostrarPergunta(0)` se houver itens. | Inicia o jogo. | 🟢 |
| 70–73 | `catch` | Mostra exceção de carregamento. | Ajuda a identificar problema no conteúdo. | 🟡 |
| 76–106 | `MostrarPergunta` | Valida índice, prepara alternativas, embaralha e preenche controles. | É a atualização de uma rodada. | 🔴 |
| 78–83 | índice e texto | Salva índice, pega pergunta e atualiza Label. | Define o registro atual. | 🟢 |
| 85–94 | cópia e embaralhamento | Converte resposta base 1 para índice 0, associa corretas e usa `Random.Shared.Shuffle`. | Embaralha sem perder a identidade da correta. | 🔴 |
| 96–98 | listas de exibição | Salva ordem exibida e posição correta nova. | A validação usa a posição visual. | 🔴 |
| 100–105 | RadioButtons | Distribui até quatro textos e limpa seleção. | Atualiza alternativas para a nova pergunta. | 🟡 |
| 108–112 | `BtnVoltar_Click` | Mostra origem e fecha. | Abandona o Quiz. | 🟢 |
| 114–169 | `BtnConfirmar_Click` | Identifica seleção, valida, calcula feedback e avança ou encerra. | É o ciclo principal de resposta. | 🔴 |
| 116–123 | seleção | Começa com -1 e verifica os quatro RadioButtons. | -1 representa nenhuma escolha. | 🟢 |
| 125–129 | validação | Mostra aviso e retorna sem pontuar. | Impede confirmar sem alternativa. | 🟢 |
| 131–137 | comparação e pontuação | Compara posição exibida e incrementa acerto. | A posição já foi atualizada pelo embaralhamento. | 🟡 |
| 139–146 | textos escolhido/correto | Busca textos com proteção de faixa. | Monta feedback seguro. | 🟡 |
| 148–152 | explicação e interpolação | Monta mensagem diferente para acerto ou erro. | Explica a resposta. | 🟡 |
| 154–156 | `MessageBox` | Mostra feedback com ícone adequado. | Informa o resultado da rodada. | 🟢 |
| 158–162 | próxima pergunta | Avança se ainda houver itens. | Continua o Quiz. | 🟢 |
| 163–168 | fim | Mostra resultado, revela origem e fecha. | Finaliza o fluxo. | 🟡 |
| 171–172 | chaves | Fecham classe e namespace. | Encerram arquivo. | 🟢 |

## Fim de cada método

- **Construtor:** se a origem for inválida, o retorno pode falhar; é seguro ajustar aparência e tamanho.
- **`FrmQuiz_Load`:** arquivo ausente mostra aviso; JSON inválido mostra exceção; é seguro trocar o caminho mantendo o formato.
- **`MostrarPergunta`:** índice inválido não faz nada; é seguro mudar os textos visuais, mas a correspondência da resposta deve ser preservada.
- **`BtnVoltar_Click`:** fecha e mostra origem; é seguro trocar o texto do botão.
- **`BtnConfirmar_Click`:** sem seleção não avança; é seguro mudar mensagens, não a comparação de índices sem revisar o embaralhamento.

## Pontos de atenção

`RespostaCorreta` começa em 1 no JSON, mas listas começam em 0; o código faz a conversão. As 20 perguntas mantêm cinco respostas corretas em cada posição de 1 a 4, e `Random.Shared.Shuffle` embaralha uma cópia das alternativas, não o JSON. Não existe histórico persistente: a pontuação fica na memória.

## Mini-resumo

1. O Quiz carrega um array de perguntas.
2. Cada pergunta tem até quatro alternativas exibidas.
3. A ordem visual é aleatória.
4. A posição correta é atualizada junto.
5. O resultado aparece e a origem volta ao final.
